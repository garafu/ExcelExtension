﻿namespace ExcelX.AddIn.Dialog
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
            this.SearchScopeComboBox.Items.AddRange(new object[] 
            {
                    new ListBoxItem<SearchScopeType>(SearchScopeType.CURRENT_SHEET),
                    new ListBoxItem<SearchScopeType>(SearchScopeType.SELECTED_RANGE),
                    new ListBoxItem<SearchScopeType>(SearchScopeType.SELECTED_SHEET),
                    new ListBoxItem<SearchScopeType>(SearchScopeType.BOOK)
            });
            this.SearchScopeComboBox.SelectedIndex = 0;

            // 「検索対象」リストを初期化
            this.SearchTargetCheckedListBox.Items.AddRange(new object[]
            {
                new ListBoxItem<SearchTargetType>(SearchTargetType.FORMULA),
                new ListBoxItem<SearchTargetType>(SearchTargetType.VALUE),
                new ListBoxItem<SearchTargetType>(SearchTargetType.COMMENT),
                new ListBoxItem<SearchTargetType>(SearchTargetType.SHAPE),
                new ListBoxItem<SearchTargetType>(SearchTargetType.CHART)
            });
            this.SearchTargetCheckedListBox.SetItemChecked(1, true);
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
        /// 指定したシート、セルに存在するオートシェイプにフォーカスします。
        /// </summary>
        /// <param name="sheetName">シート名</param>
        /// <param name="cellName">セル名</param>
        /// <param name="objectName">オブジェクト名</param>
        /// <returns>オートシェイプが存在する領域</returns>
        private Range FocusAutoShape(string sheetName, string cellName, string objectName)
        {
            var sheet = this.FocusSheet(sheetName);
            var range = sheet.Range[cellName];
            var shape = sheet.Shapes.Item(objectName);

            // オブジェクトが存在する場所に表示領域を移動させる
            range.Select();
            range.Activate();

            try
            {
                // オブジェクトを選択
                shape.Select();
            }
            catch 
            {
            }

            return range;
        }

        /// <summary>
        /// 指定されたセルにフォーカスします。
        /// </summary>
        /// <param name="sheetName">シート名</param>
        /// <param name="cellName">セル名</param>
        /// <returns>フォーカスした範囲</returns>
        private Range FocusCell(string sheetName, string cellName)
        {
            var sheet = this.FocusSheet(sheetName);
            var range = sheet.Range[cellName];

            range.Select();
            range.Activate();

            return range;
        }

        /// <summary>
        /// 指定されたグラフにフォーカスします。
        /// </summary>
        /// <param name="sheetName">シート名</param>
        /// <param name="cellName">セル名</param>
        /// <param name="objectName">グラフ名</param>
        /// <returns>フォーカスした範囲</returns>
        private Range FocusChart(string sheetName, string cellName, string objectName)
        {
            var sheet = this.FocusSheet(sheetName);
            var range = sheet.Range[cellName];
            var chart = sheet.ChartObjects(objectName);

            // オブジェクトが存在する場所に表示領域を移動させる
            range.Select();
            range.Activate();

            try
            {
                // オブジェクトを選択
                chart.Select();
            }
            catch 
            {
            }

            return range;
        }

        /// <summary>
        /// コメント入力されたセルにフォーカスします。
        /// </summary>
        /// <param name="sheetName">シート名</param>
        /// <param name="cellName">セル名</param>
        /// <returns>フォーカスした範囲</returns>
        private Range FocusComment(string sheetName, string cellName)
        {
            var sheet = this.FocusSheet(sheetName);
            var range = sheet.Range[cellName];

            range.Select();
            range.Activate();

            return range;
        }

        /// <summary>
        /// 指定されたシートが表示していなければ表示します。
        /// </summary>
        /// <param name="sheetName">シート名</param>
        /// <returns>フォーカスしたシート</returns>
        private Worksheet FocusSheet(string sheetName)
        {
            var application = Globals.ThisAddIn.Application;
            Workbook book = application.ActiveWorkbook;
            Worksheet sheet = null;

            if (application.ActiveSheet.Name == sheetName)
            {
                sheet = application.ActiveSheet;
            }
            else
            {
                sheet = book.Sheets.Item[sheetName];
                sheet.Select();
                ((Microsoft.Office.Interop.Excel._Worksheet)sheet).Activate();
            }

            return sheet;
        }

        /// <summary>
        /// 検索結果のセルを選択したとき、呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void ResultDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // ヘッダー行を選択時は何もしない
            if (e.RowIndex < 0)
            {
                return;
            }

            // 行に設定したデータを取り出す
            var row = (sender as DataGridView).Rows[e.RowIndex];
            var result = row.DataBoundItem as SearchResult;
            var sheetName = result.Sheet;
            var cellName = result.Cell;
            var objectName = result.Name;

            // 種別に応じてフォーカス
            switch (result.Type)
            {
                case SearchTargetType.FORMULA:
                    this.FocusCell(sheetName, cellName);
                    break;
                case SearchTargetType.VALUE:
                    this.FocusCell(sheetName, cellName);
                    break;
                case SearchTargetType.COMMENT:
                    this.FocusComment(sheetName, cellName);
                    break;
                case SearchTargetType.SHAPE:
                    this.FocusAutoShape(sheetName, cellName, objectName);
                    break;
                case SearchTargetType.CHART:
                    this.FocusChart(sheetName, cellName, objectName);
                    break;
            }
        }

        /// <summary>
        /// 条件に従ってすべてを検索します。
        /// </summary>
        private void SearchAll()
        {
            // 検索履歴を作成
            var text = this.SearchTextComboBox.Text.Trim();
            var isIncluded = false;
            foreach (var item in this.SearchTextComboBox.Items)
            {
                if (text == item.ToString())
                {
                    isIncluded = true;
                    break;
                }
            }

            if (isIncluded == false)
            {
                if (this.SearchTextComboBox.Items.Count >= 10)
                {
                    this.SearchTextComboBox.Items.RemoveAt(this.SearchTextComboBox.Items.Count - 1);
                }

                this.SearchTextComboBox.Items.Insert(0, text);
            }
            else
            {
                this.SearchTextComboBox.Items.Remove(text);
                this.SearchTextComboBox.Items.Insert(0, text);
            }

            // 検索範囲を設定
            var scope = new SearchScope(
                (this.SearchScopeComboBox.SelectedItem as ListBoxItem<SearchScopeType>).Key);

            // 検索対象を設定
            var target = new SearchTarget(
                this.SearchTargetCheckedListBox.GetItemChecked(0),
                this.SearchTargetCheckedListBox.GetItemChecked(1),
                this.SearchTargetCheckedListBox.GetItemChecked(2),
                this.SearchTargetCheckedListBox.GetItemChecked(3),
                this.SearchTargetCheckedListBox.GetItemChecked(4));

            // 検索条件を設定
            var condition = new SearchCondition(
                this.SearchTextComboBox.Text,
                this.MatchRegexpCheckBox.Checked,
                this.MatchExactCheckBox.Checked,
                this.MatchCaseCheckBox.Checked,
                this.MatchByteCheckBox.Checked);

            // 検索の実行
            var engine = new SearchEngine();
            var result = engine.Execute(scope, target, condition);

            // 検索結果を画面に反映
            this.ResultDataGridView.SuspendLayout();
            this.ResultDataGridView.DataSource = result;
            this.ResultDataGridView.ResumeLayout();
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
    }
}
