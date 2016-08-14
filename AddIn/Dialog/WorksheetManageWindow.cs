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
    using ExcelX.AddIn.Module.WorksheetManage;

    /// <summary>
    /// ワークシート管理ダイアログ
    /// </summary>
    public partial class WorksheetManageWindow : Form
    {
        /// <summary>
        /// 処理の実態
        /// </summary>
        private WorksheetManager manager = new WorksheetManager();

        /// <summary>
        /// ワークシートリスト
        /// </summary>
        private BindingSource datasource = new BindingSource();

        /// <summary>
        /// WorksheetMnageWindow クラス を初期化します。
        /// </summary>
        public WorksheetManageWindow()
        {
            this.InitializeComponent();

            // データソースの準備
            this.datasource.DataSource = this.manager.WorksheetInfoList;

            // DataGridView に データソース を適用
            this.DataGridView.AutoGenerateColumns = false;
            this.DataGridView.DataSource = this.datasource;
        }

        /// <summary>
        /// 「完了」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void CompleteButton_Click(object sender, EventArgs e)
        {
            this.manager.Update();
            this.Close();
        }

        /// <summary>
        /// 「キャンセル」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 「適用」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            this.manager.Update();
        }

        /// <summary>
        /// 「追加」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            var item = this.manager.CreateNewWorksheet();
            this.datasource.Add(item);
        }

        /// <summary>
        /// 「削除」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.DataGridView.SelectedRows)
            {
                var target = this.datasource[row.Index] as WorksheetInfo;
                this.datasource.RemoveAt(row.Index);
                this.manager.Delete(target);
            }
        }

        /// <summary>
        /// 「上へ」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void UpButton_Click(object sender, EventArgs e)
        {
            if (this.DataGridView.SelectedRows.Count != 1)
            {
                return;
            }

            // 選択中の行を取得
            DataGridViewRow row = this.DataGridView.SelectedRows[0];

            // 先頭行の場合、何もしない
            if (row.Index == 0)
            {
                return;
            }

            // 上の行と入れ替え
            var index = row.Index;
            var source = this.datasource[index] as WorksheetInfo;
            var target = this.datasource[index - 1] as WorksheetInfo;
            this.datasource.RemoveAt(index);
            this.datasource.Insert(index - 1, source);
            index = source.NewIndex;
            source.NewIndex = target.NewIndex;
            target.NewIndex = index;

            // 新しい行を選択
            this.DataGridView.CurrentCell = this.DataGridView.Rows[source.NewIndex - 1].Cells[0];
        }

        /// <summary>
        /// 「下へ」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void DownButton_Click(object sender, EventArgs e)
        {
            if (this.DataGridView.SelectedRows.Count != 1)
            {
                return;
            }

            // 選択中の行を取得
            DataGridViewRow row = this.DataGridView.SelectedRows[0];

            // 末尾行の場合、何もしない
            if (row.Index == this.DataGridView.Rows.Count - 1)
            {
                return;
            }

            // 下の行と入れ替え
            var index = row.Index;
            var source = this.datasource[index] as WorksheetInfo;
            var target = this.datasource[index + 1] as WorksheetInfo;
            this.datasource.RemoveAt(index);
            this.datasource.Insert(index + 1, source);
            index = source.NewIndex;
            source.NewIndex = target.NewIndex;
            target.NewIndex = index;

            // 新しい行を選択
            this.DataGridView.CurrentCell = this.DataGridView.Rows[source.NewIndex - 1].Cells[0];
        }

        /// <summary>
        /// 「昇順」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void AscButton_Click(object sender, EventArgs e)
        {
            this.DataGridView.Sort(this.DataGridView.Columns[2], ListSortDirection.Ascending);
            for (var i = 0; i < this.datasource.Count; i++)
            {
                var item = this.datasource[i] as WorksheetInfo;
                item.NewIndex = i + 1;
            }
        }

        /// <summary>
        /// 「降順」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void DescButton_Click(object sender, EventArgs e)
        {
            this.DataGridView.Sort(this.DataGridView.Columns[2], ListSortDirection.Descending);
            for (var i = 0; i < this.datasource.Count; i++)
            {
                var item = this.datasource[i] as WorksheetInfo;
                item.NewIndex = i + 1;
            }
        }

        /// <summary>
        /// DataGridViewのセルをダブルクリックしたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DataGridView.SelectedRows.Count != 1)
            {
                return;
            }

            // 選択中の行を取得
            DataGridViewRow row = this.DataGridView.SelectedRows[0];

            // 選択中のワークシート情報を取得
            var info = this.datasource[row.Index] as WorksheetInfo;

            // 選択中のワークシートへ移動
            this.manager.MoveTo(info);
        }

        /// <summary>
        /// DataGridViewのセルが入力フォーカスを失ったとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void DataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex != 2)
            {
                return;
            }

            // エラーテキストは消去
            this.DataGridView.Rows[e.RowIndex].ErrorText = string.Empty;

            // 変更しようとしている新しいテキストを取得
            var text = e.FormattedValue.ToString();

            // 空文字かどうか
            if (string.IsNullOrEmpty(text) == true)
            {
                this.DataGridView.Rows[e.RowIndex].ErrorText = "シート名を空文字にできません。";
                e.Cancel = true;
                return;
            }

            // 同じ名称のシート名が存在しないかどうか
            foreach (WorksheetInfo item in this.datasource)
            {
                if (item.NewIndex == e.RowIndex + 1)
                {
                    continue;
                }

                if (item.NewName == text)
                {
                    this.DataGridView.Rows[e.RowIndex].ErrorText = string.Format("No.{0}シートと同じ名称のシート名を指定できません。", item.NewIndex);
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}
