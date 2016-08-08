namespace ExcelX.Addin.Command
{
    using Excel = Microsoft.Office.Interop.Excel;
    using ExcelX.AddIn;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.IO;

    /// <summary>
    /// 「ファイルを開く」コマンドの基底クラス
    /// </summary>
    public class OpenFileCommand
    {
        /// <summary>
        /// 現在のワークブックが新規ブックかどうかを取得します。
        /// </summary>
        /// <returns>新規ブックの場合 true 、それ以外の場合 false</returns>
        protected bool IsNewBook()
        {
            var workbook = Globals.ThisAddIn.Application.ActiveWorkbook;

            return workbook.FullName == workbook.Name;
        }

        /// <summary>
        /// 現在のワークブックのファイルパスを取得します。
        /// 新規ファイルの場合は空文字が取得されます。
        /// </summary>
        /// <returns>現在のワークブックのファイルパス</returns>
        protected string GetActiveWorkbookPath()
        {
            var application = Globals.ThisAddIn.Application;
            var workbook = application.ActiveWorkbook;
            return (workbook.FullName != workbook.Name) ? workbook.FullName : string.Empty;
        }

        /// <summary>
        /// ファイルパスと読み取り専用設定を指定して新規ウィンドウを開きます。
        /// </summary>
        /// <param name="filepath">ファイルパス</param>
        /// <param name="readOnly">読み取り専用かどうか</param>
        /// <returns>非同期タスク</returns>
        protected Excel.Workbook OpenNewWindow(string filepath, bool readOnly)
        {
            // Excelを新規起動
            var excel = new Excel.Application();
            excel.Visible = true;

            // ファイルを開く
            var workbook = excel.Workbooks.Open(filepath, ReadOnly: readOnly);

            return workbook;
        }

        /// <summary>
        /// ファイルパスと読み取り専用設定を指定して非同期に新規ウィンドウを開きます。
        /// </summary>
        /// <param name="filepath">ファイルパス</param>
        /// <param name="readOnly">読み取り専用かどうか</param>
        /// <returns>非同期タスク</returns>
        protected Task<Excel.Workbook> OpenNewWindowAsync(string filepath, bool readOnly)
        {
            return Task<Excel.Workbook>.Factory.StartNew(() =>
            {
                return this.OpenNewWindow(filepath, readOnly);
            });
        }

        /// <summary>
        /// OpenFileDialogのインスタンスを作成します。
        /// </summary>
        /// <returns>OpenFileDialogインスタンス</returns>
        protected OpenFileDialog CreateOpenFileDialog()
        {
            var initialdirectory = (this.IsNewBook() == false) ?
                        Path.GetDirectoryName(this.GetActiveWorkbookPath()) :
                        string.Empty;

            var ofd = new OpenFileDialog()
            {
                Title = @"開くファイルを指定してください",
                InitialDirectory = initialdirectory,
                Filter = this.CreateOpenFileDialogFilter(),
                FilterIndex = 3,
                Multiselect = false,
                CheckFileExists = true,
                CheckPathExists = true
            };

            return ofd;
        } 

        /// <summary>
        /// OpenFileDialogのフィルタ文字列を作成します。
        /// </summary>
        /// <returns>OpenFileDialogのフィルタ</returns>
        protected string CreateOpenFileDialogFilter()
        {
            var builder = new FilterStringBuilder();

            builder.Append(new FilterInfo(
                "すべてのファイル",
                "*"));
            builder.Append(new FilterInfo(
                "すべての Excel ファイル",
                "xl", "xlsx", "xlsm", "xlsb", "xlam", "xltx", "xltm", "xls", "xlt", "htm", "html", "mht", "mhtml", "xml", "xla", "xlm", "xlw", "odc", "ods"));
            builder.Append(new FilterInfo(
                "Excel ファイル",
                "xl", "xlsx", "xlsm", "xlsb", "xlam", "xltx", "xltm", "xls", "xla", "xlt", "xlm", "xlw", "xjs", "xjm", "xjc"));
            builder.Append(new FilterInfo(
                "すべての Web ページ",
                "htm", "html", "mht", "mhtml"));
            builder.Append(new FilterInfo(
                "XML ファイル",
                "xml"));
            builder.Append(new FilterInfo(
                "テキスト ファイル",
                "prn", "txt", "csv"));
            builder.Append(new FilterInfo(
                "すべてのデータソース",
                "odc", "udl", "dsn", "mdb", "mde", "accdb", "accde", "dbc", "iqy", "dqy", "rqy", "oqy", "cub", "atom", "atomsvc"));
            builder.Append(new FilterInfo(
                "Access データベース",
                "mdb", "mde", "accdb", "accde"));
            builder.Append(new FilterInfo(
                "クエリ ファイル",
                "iqy", "dqy", "oqy", "rqy"));
            builder.Append(new FilterInfo(
                "dBASE ファイル",
                "dbf"));
            builder.Append(new FilterInfo(
                "Microsoft Excel 4.0 マクロシート",
                "xlm", "xla"));
            builder.Append(new FilterInfo(
                "Microsoft Excel 4.0 ブック",
                "xlw"));
            builder.Append(new FilterInfo(
                "ワークシート",
                "xlsx", "xlsm", "xlsb", "xls", "xjs"));
            builder.Append(new FilterInfo(
                "作業状態ファイル",
                "xlw"));
            builder.Append(new FilterInfo(
                "テンプレート",
                "xltx", "xltm", "xlt", "xjt"));
            builder.Append(new FilterInfo(
                "アドイン",
                "xlam", "xla", "xll", "xja"));
            builder.Append(new FilterInfo(
                "ツールバー ファイル",
                "xlb"));
            builder.Append(new FilterInfo(
                "SYLK ファイル",
                "slk"));
            builder.Append(new FilterInfo(
                "DIF ファイル",
                "dif"));
            builder.Append(new FilterInfo(
                "バックアップ ファイル",
                "xlk", "bak"));
            builder.Append(new FilterInfo(
                "OpenDocument スプレッドシート",
                "ods"));

            return builder.ToString();
        }

        /// <summary>
        /// OpenFileDialogのフィルタ情報
        /// </summary>
        public class FilterInfo
        {
            public FilterInfo()
            {
                this.DisplayName = string.Empty;
                this.Extensions = new List<string>();
            }

            public FilterInfo(string displayName, params string[] extensions)
            {
                this.DisplayName = displayName;
                this.Extensions = new List<string>(extensions);
            }

            public string DisplayName { get; set; }

            public List<string> Extensions { get; set; }

            public override string ToString()
            {
                var extensions = new StringBuilder();

                foreach (var ext in this.Extensions)
                {
                    extensions.Append("*.");
                    extensions.Append(ext);
                    extensions.Append(";");
                }

                extensions.Remove(extensions.Length - 1, 1);

                var filter = new StringBuilder();

                filter.Append(this.DisplayName);
                filter.Append("(");
                filter.Append(extensions.ToString());
                filter.Append(")|");
                filter.Append(extensions.ToString());

                return filter.ToString();
            }
        }

        /// <summary>
        /// OpenFileDialogのフィルタ文字列を生成します。
        /// </summary>
        public class FilterStringBuilder
        {
            private List<FilterInfo> filters;

            public FilterStringBuilder()
            {
                this.filters = new List<FilterInfo>();
            }

            public void Append(FilterInfo filterInfo)
            {
                this.filters.Add(filterInfo);
            }

            public override string ToString()
            {
                var result = new StringBuilder();

                foreach (var item in this.filters)
                {
                    result.Append(item.ToString());
                    result.Append("|");
                }

                result.Remove(result.Length - 1, 1);

                return result.ToString();
            }
        }
    }
}
