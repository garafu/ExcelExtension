namespace ExcelX.AddIn.Command
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ExcelX.AddIn.Config;
    using Core = Microsoft.Office.Core;
    using Excel = Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 「吹き出し」コマンド
    /// </summary>
    public class AddBalloonCommand : ICommand
    {
        /// <summary>
        /// コマンドを実行します。
        /// NOTE: このコマンドでは引数なしでは実行できません。
        /// </summary>
        public void Execute()
        {
        }

        /// <summary>
        /// 作成する設定のインデックスを指定してコマンドを実行します。
        /// </summary>
        /// <param name="index">作成する吹き出し設定のインデックス</param>
        public void Execute(int index)
        {
            // 吹き出し設定一覧を取得
            var configs = ConfigDocument.Current.Shape.RectangleBalloonList;

            // 指定されたインデックスが設定数の範囲内かどうか
            if (index < 0 || configs.Count <= index)
            {
                return;
            }

            // 設定の取得
            var config = configs[index];

            // ワークシートを取得
            var application = Globals.ThisAddIn.Application;
            Excel.Worksheet sheet = application.ActiveSheet;
            Excel.Range cell = application.ActiveCell;

            // シェープ作成
            Excel.Shape shape = sheet.Shapes.AddShape(Core.MsoAutoShapeType.msoShapeRectangularCallout, cell.Left, cell.Top, config.Width, config.Height);

            // 枠線の設定
            shape.Line.Weight = config.BorderSize;
            shape.Line.ForeColor.RGB = config.BorderColor.Color;

            // 背景色の設定
            shape.Fill.ForeColor.RGB = config.BackgroundColor.Color;
            shape.Fill.Transparency = config.BackgroundColor.Transparency;

            // テキストスタイルの設定
            Excel.Characters characters = shape.TextFrame.Characters();
            characters.Font.Color = config.FontColor.Color;
            characters.Font.Size = (config.FontSize < 0) ? application.StandardFontSize : config.FontSize;
            characters.Font.Name = string.IsNullOrEmpty(config.FontName) ? application.StandardFont : config.FontName;
        }
    }
}
