namespace ExcelX.AddIn.Dialog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using ExcelX.AddIn.Module.SearchReplace;
    using Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 検索ダイアログ
    /// </summary>
    public partial class SearchReplaceWindow : Form
    {
        /// <summary>
        /// ダイアログのシングルトンインスタンス
        /// </summary>
        private static SearchReplaceWindow instance = null;

        /// <summary>
        /// SearchReplaceWindow クラス の インスタンス を初期化します。
        /// </summary>
        private SearchReplaceWindow()
        {
            this.InitializeComponent();

            // 「検索範囲」リストを初期化
            this.searchScopeComboBox.Items.AddRange(new object[] 
            {
                    new ListBoxItem<SearchScopeType>(SearchScopeType.CURRENT_SHEET),
                    new ListBoxItem<SearchScopeType>(SearchScopeType.SELECTED_RANGE),
                    new ListBoxItem<SearchScopeType>(SearchScopeType.SELECTED_SHEET),
                    new ListBoxItem<SearchScopeType>(SearchScopeType.BOOK)
            });
            this.searchScopeComboBox.SelectedIndex = 0;

            // 「検索対象」リストを初期化
            this.searchTargetCheckedListBox.Items.AddRange(new object[]
            {
                new ListBoxItem<SearchTargetType>(SearchTargetType.FORMULA),
                new ListBoxItem<SearchTargetType>(SearchTargetType.VALUE),
                new ListBoxItem<SearchTargetType>(SearchTargetType.COMMENT),
                new ListBoxItem<SearchTargetType>(SearchTargetType.SHAPE),
                new ListBoxItem<SearchTargetType>(SearchTargetType.CHART)
            });
            this.searchTargetCheckedListBox.SetItemChecked(1, true);

            // 「検索結果」リストを設定
            this.resultDataGridView.AutoGenerateColumns = false;
        }

        /// <summary>
        /// SearchReplaceWindow の シングルトンインスタンス を取得します。
        /// </summary>
        /// <returns>SearchReplaceWindowインスタンス</returns>
        public static SearchReplaceWindow GetInstance()
        {
            if (SearchReplaceWindow.instance == null)
            {
                SearchReplaceWindow.instance = new SearchReplaceWindow();
            }

            return SearchReplaceWindow.instance;
        }

        /// <summary>
        /// ウィンドウを閉じようとする際、呼び出されます。
        /// </summary>
        /// <param name="e">イベント変数</param>
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            e.Cancel = true;

            this.Visible = false;
        }

        /// <summary>
        /// 「閉じる」ボタンが押下されたとき、呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 検索文字列コンボボックスでキーを押下したとき、呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void SearchTextComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.SearchAll();
            }
        }

        /// <summary>
        /// 「検索」ボタンが押下されたとき、呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.SearchAll();
        }

        /// <summary>
        /// 検索結果の行に対するフォーカスが変更されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void ResultDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.FocusSelectedResult();
        }

        /// <summary>
        /// 条件に従ってすべてを検索します。
        /// </summary>
        private void SearchAll()
        {
            // 検索条件が正しいか検証
            if (this.ValidateSearchCondition() == false)
            {
                return;
            }

            // 検索履歴を作成
            this.CreateSearchHistory();

            // 検索範囲を設定
            var scope = new SearchScope(
                (this.searchScopeComboBox.SelectedItem as ListBoxItem<SearchScopeType>).Key);

            // 検索対象を設定
            var target = new SearchTarget(
                this.searchTargetCheckedListBox.GetItemChecked(0),
                this.searchTargetCheckedListBox.GetItemChecked(1),
                this.searchTargetCheckedListBox.GetItemChecked(2),
                this.searchTargetCheckedListBox.GetItemChecked(3),
                this.searchTargetCheckedListBox.GetItemChecked(4));

            // 検索条件を設定
            var condition = new SearchCondition(
                this.searchTextComboBox.Text,
                this.matchRegexpCheckBox.Checked,
                this.matchExactCheckBox.Checked,
                this.matchCaseCheckBox.Checked,
                this.matchByteCheckBox.Checked);

            // 検索の実行
            var engine = new SearchEngine();
            var result = engine.Execute(scope, target, condition);

            // 検索結果を画面に反映
            this.resultDataGridView.SuspendLayout();
            this.resultDataGridView.DataSource = result;
            this.resultDataGridView.ResumeLayout();
        }

        /// <summary>
        /// 検索条件の設定が正しいかどうかを判定します。
        /// </summary>
        /// <returns>検索条件が正しく設定されている場合 true、それ以外の場合 false</returns>
        private bool ValidateSearchCondition()
        {
            // 検索文字が何か入力されているか
            var text = this.searchTextComboBox.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            // 検索対象が何か選ばれているか
            if (this.searchTargetCheckedListBox.CheckedItems.Count == 0)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 検索履歴を作成する
        /// </summary>
        private void CreateSearchHistory()
        {
            var text = this.searchTextComboBox.Text.Trim();
            var isIncluded = false;
            foreach (var item in this.searchTextComboBox.Items)
            {
                if (text == item.ToString())
                {
                    isIncluded = true;
                    break;
                }
            }

            if (isIncluded == false)
            {
                if (this.searchTextComboBox.Items.Count >= 10)
                {
                    this.searchTextComboBox.Items.RemoveAt(this.searchTextComboBox.Items.Count - 1);
                }

                this.searchTextComboBox.Items.Insert(0, text);
            }
            else
            {
                this.searchTextComboBox.Items.Remove(text);
                this.searchTextComboBox.Items.Insert(0, text);
            }
        }

        /// <summary>
        /// 現在選択されている検索結果に対してフォーカスします。
        /// </summary>
        private void FocusSelectedResult()
        {
            if (this.resultDataGridView.SelectedRows.Count <= 0)
            {
                return;
            }

            // 選択中の行からフォーカスするオブジェクト情報を取得
            var row = this.resultDataGridView.SelectedRows[0];
            var result = row.DataBoundItem as SearchResult;

            // 該当のオブジェクトにフォーカス
            var engine = new SearchEngine();
            engine.Focus(result);

            // 検索ウィンドウにフォーカスを戻す
            this.Activate();
        }
    }
}
