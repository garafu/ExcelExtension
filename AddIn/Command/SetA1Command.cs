namespace ExcelX.AddIn.Command
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
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
    }
}
