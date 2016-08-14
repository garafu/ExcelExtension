namespace ExcelX.AddIn.Module.WorksheetManage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Excel = Microsoft.Office.Interop.Excel;

    /// <summary>
    /// ワークシート情報を表現するクラス
    /// </summary>
    public class WorksheetInfo
    {
        /// <summary>
        /// WorksheetInfo クラスを初期化します。
        /// </summary>
        public WorksheetInfo()
        {
            this.NewIndex = 1;
            this.NewName = "ワークシート";
            this.NewVisible = true;
            this.NewType = this.GetSheetTypeDisplayName(Excel.XlSheetType.xlWorksheet);
            this.NewProtected = false;
        }

        /// <summary>
        /// ワークシート を指定して WorksheetInfo クラスを初期化します。
        /// </summary>
        /// <param name="worksheet">ワークシート</param>
        public WorksheetInfo(Excel.Worksheet worksheet)
        {
            this.Initialize(worksheet);
        }

        /// <summary>
        /// ワークシート情報が新規作成された情報かどうかを取得します。
        /// </summary>
        public bool IsCreated
        {
            get
            {
                return this.OldIndex < 0;
            }
        }

        /// <summary>
        /// ワークシート情報が削除された情報かどうかを取得します。
        /// </summary>
        public bool IsDeleted
        {
            get
            {
                return this.NewIndex < 0;
            }
        }

        /// <summary>
        /// ワークシート情報が更新されているかどうかを取得します。
        /// </summary>
        public bool IsUpdated
        {
            get
            {
                return this.OldIndex != this.NewIndex ||
                        this.OldName != this.NewName ||
                        this.OldVisible != this.NewVisible ||
                        this.OldType != this.NewType ||
                        this.OldProtected != this.NewProtected;
            }
        }

        /// <summary>
        /// 新しいインデックスを取得または設定します。
        /// </summary>
        public int NewIndex { get; set; }

        /// <summary>
        /// 新しいシート名を取得または設定します。
        /// </summary>
        public string NewName { get; set; }

        /// <summary>
        /// 新しい保護状態を取得または設定します。
        /// </summary>
        public bool NewProtected { get; set; }

        /// <summary>
        /// 新しいワークシート種類を取得または設定します。
        /// </summary>
        public string NewType { get; set; }

        /// <summary>
        /// 新しい表示状態を取得または設定します。
        /// </summary>
        public bool NewVisible { get; set; }

        /// <summary>
        /// 古いインデックスを取得します。
        /// </summary>
        public int OldIndex
        {
            get
            {
                return this.Worksheet != null ? this.Worksheet.Index : -1;
            }
        }

        /// <summary>
        /// 古い名前を取得します。
        /// </summary>
        public string OldName
        {
            get
            {
                return this.Worksheet != null ? this.Worksheet.Name : string.Empty;
            }
        }

        /// <summary>
        /// 古い保護状態を取得します。
        /// </summary>
        public bool OldProtected
        {
            get
            {
                return this.Worksheet != null ? this.Worksheet.ProtectContents : false;
            }
        }

        /// <summary>
        /// 古いワークシート種類を取得します。
        /// </summary>
        public string OldType
        {
            get
            {
                return this.Worksheet != null ? this.GetSheetTypeDisplayName(this.Worksheet.Type) : string.Empty;
            }
        }

        /// <summary>
        /// 古い表示状態を取得します。
        /// </summary>
        public bool OldVisible
        {
            get
            {
                return this.Worksheet != null ? this.Worksheet.Visible == Excel.XlSheetVisibility.xlSheetVisible : false;
            }
        }

        /// <summary>
        /// 対象としているワークシートを取得または設定します。
        /// </summary>
        public Excel.Worksheet Worksheet { get; set; }

        /// <summary>
        /// ワークシートを指定して WorksheetInfo クラス を初期化します。
        /// </summary>
        /// <param name="worksheet">ワークシート</param>
        public void Initialize(Excel.Worksheet worksheet)
        {
            this.Worksheet = worksheet;
            this.NewIndex = worksheet.Index;
            this.NewName = worksheet.Name;
            this.NewVisible = worksheet.Visible == Excel.XlSheetVisibility.xlSheetVisible;
            this.NewType = this.GetSheetTypeDisplayName(worksheet.Type);
            this.NewProtected = worksheet.ProtectContents;
        }

        /// <summary>
        /// ワークシート種類の表示名を取得します。
        /// </summary>
        /// <param name="type">ワークシート種類</param>
        /// <returns>表示名</returns>
        private string GetSheetTypeDisplayName(Excel.XlSheetType type)
        {
            switch (type)
            {
                case Excel.XlSheetType.xlChart:
                    return "グラフ";
                case Excel.XlSheetType.xlDialogSheet:
                    return "ダイアログ シート";
                case Excel.XlSheetType.xlExcel4IntlMacroSheet:
                    return "Excel 4.0 インターナショナル マクロ シート";
                case Excel.XlSheetType.xlExcel4MacroSheet:
                    return "Excel 4.0 マクロ シート";
                case Excel.XlSheetType.xlWorksheet:
                    return "ワークシート";
            }

            return string.Empty;
        }
    }
}
