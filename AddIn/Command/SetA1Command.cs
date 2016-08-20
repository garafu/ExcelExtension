namespace ExcelX.AddIn.Command
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using ExcelX.AddIn;
    using ExcelX.AddIn.Config;
    using Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 「A1」コマンド
    /// </summary>
    public class SetA1Command : ICommand
    {
        /// <summary>
        /// コマンドを実行します。
        /// </summary>
        public void Execute()
        {
            var config = Config.ConfigDocument.Current.Edit.A1;
            var application = Globals.ThisAddIn.Application;
            Workbook book = application.ActiveWorkbook;

            // 後ろのシートから先頭のシートに向かって処理する
            for (var i = book.Worksheets.Count; i > 0; i--)
            {
                Window window = book.Windows[1];
                _Worksheet sheet = book.Worksheets[i];

                // 表示中シートのみが対象
                if (sheet.Visible != XlSheetVisibility.xlSheetVisible)
                {
                    continue;
                }

                // デフォルト状態に設定
                this.SetDefault(window, sheet, config);
            }

            // 自動保存するかどうか
            if (config.AutoSaveEnabled)
            {
                if (config.AutoSaveOverwrite)
                {
                    // 上書き保存
                    book.Save();
                }
                else
                {
                    // 名前を付けて保存
                    var dialog = new SaveFileDialog();
                    dialog.Title = "ファイル名を指定して保存";
                    dialog.FileName = book.Name;
                    dialog.Filter = this.CreateSaveFileDialogFilter();
                    dialog.FilterIndex = 0;
                    dialog.AddExtension = true;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        book.SaveAs(
                            Filename: dialog.FileName,
                            FileFormat: this.GetFileFormat(dialog.FilterIndex));
                    }
                }
            }
        }

        /// <summary>
        /// 指定されたウィンドウおよびシートをデフォルト設定に設定しなおします。
        /// </summary>
        /// <param name="window">アクティブなウィンドウ</param>
        /// <param name="sheet">アクティブなシート</param>
        /// <param name="config">設定</param>
        private void SetDefault(Window window, _Worksheet sheet, A1Config config)
        {
            sheet.Activate();
            
            // "A1"セルをフォーカス
            sheet.Range["A1"].Activate();

            // スクロールを左上へ設定
            window.ScrollRow = 1;
            window.ScrollColumn = 1;
            
            // 表示倍率を設定
            if (config.ZoomEnabled)
            {
                window.Zoom = config.ZoomRatio;
            }

            // グループ化を設定
            if (config.GroupEnabled)
            {
                sheet.Outline.ShowLevels(RowLevels: config.RowLevels, ColumnLevels: config.ColumnLevels);
            }
        }

        /// <summary>
        /// ファイル名を指定して保存ダイアログのフィルター文字列を生成します。
        /// </summary>
        /// <returns>フィルター文字列</returns>
        private string CreateSaveFileDialogFilter()
        {
            var builder = new FilterStringBuilder();

            builder.Append(new FilterInfo("Excel ブック", "xlsx"));
            builder.Append(new FilterInfo("Excel 97-2003 ブック", "xls"));
            builder.Append(new FilterInfo("CSV(カンマ区切り)", "csv"));
            builder.Append(new FilterInfo("テキスト(タブ区切り)", "txt"));
            builder.Append(new FilterInfo("テキスト(スペース区切り)", "prn"));
            builder.Append(new FilterInfo("Unicode テキスト", "txt"));
            builder.Append(new FilterInfo("Web ページ", "htm", "html"));
            builder.Append(new FilterInfo("単一ファイル Web ページ", "mht", "mhtml"));

            return builder.ToString();
        }

        /// <summary>
        /// 選択中のフィルターインデックスからファイルフォーマットを取得します。
        /// </summary>
        /// <param name="index">選択中のフィルターインデックス</param>
        /// <returns>保存するファイルフォーマット</returns>
        private XlFileFormat GetFileFormat(int index)
        {
            switch (index)
            {
                case 1:
                    return XlFileFormat.xlWorkbookNormal;
                case 2:
                    ////return XlFileFormat.xlExcel9795;
                    return XlFileFormat.xlWorkbookNormal;
                case 3:
                    return XlFileFormat.xlCSV;
                case 4:
                    return XlFileFormat.xlCurrentPlatformText;
                case 5:
                    return XlFileFormat.xlTextPrinter;
                case 6:
                    return XlFileFormat.xlUnicodeText;
                case 7:
                    return XlFileFormat.xlHtml;
                case 8:
                    return XlFileFormat.xlWebArchive;
            }

            return XlFileFormat.xlWorkbookDefault;
        }
    }
}
