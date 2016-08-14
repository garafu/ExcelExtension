namespace ExcelX.AddIn.Module.WorksheetManage
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ExcelX.AddIn;
    using Microsoft.Office.Interop.Excel;

    /// <summary>
    /// ワークシート管理の実装
    /// </summary>
    public class WorksheetManager
    {
        /// <summary>
        /// ワークシートを削除対象リスト
        /// </summary>
        private List<WorksheetInfo> deleteList = new List<WorksheetInfo>();

        /// <summary>
        /// ワークシートを追加したときのシーケンス
        /// </summary>
        private int sequence;

        /// <summary>
        /// WorksheetManger クラス を初期化します。
        /// </summary>
        public WorksheetManager()
        {
            this.Initialize();
        }

        /// <summary>
        /// ワークシート情報リストを取得または設定します。
        /// </summary>
        public SortableBindingList<WorksheetInfo> WorksheetInfoList { get; set; }

        /// <summary>
        /// ワークシート情報を新規作成します。
        /// </summary>
        /// <returns>ワークシート情報</returns>
        public WorksheetInfo CreateNewWorksheet()
        {
            var sequence = this.GetSequence();

            var info = new WorksheetInfo()
            {
                NewIndex = sequence,
                NewName = string.Format("ワークシート({0})", sequence),
                NewVisible = true,
            };

            return info;
        }

        /// <summary>
        /// 指定されたワークシート情報を削除します。
        /// </summary>
        /// <param name="info">ワークシート情報</param>
        public void Delete(WorksheetInfo info)
        {
            this.deleteList.Add(info);
            info.NewIndex = -1;
        }

        /// <summary>
        /// 現在のワークシート情報リストに従って実際のワークブックを更新します。
        /// </summary>
        public void Update()
        {
            var datasource = this.WorksheetInfoList;
            var application = Globals.ThisAddIn.Application;
            Workbook workbook = application.ActiveWorkbook;
            Worksheet worksheet = null;
            Worksheet crrWorksheet = null;
            Worksheet bfrWorksheet = null;

            // 警告の抑止
            application.DisplayAlerts = false;

            // シートの削除
            foreach (var info in this.deleteList)
            {
                if (info.IsCreated)
                {
                    continue;
                }

                worksheet = workbook.Sheets[info.NewName];
                worksheet.Delete();
            }

            // シートの追加または更新
            for (var i = 0; i < datasource.Count; i++)
            {
                var info = datasource[i];

                if (info.IsCreated)
                {
                    // 追加
                    if (info.NewIndex == 0)
                    {
                        crrWorksheet = workbook.Sheets.Add();
                    }
                    else
                    {
                        crrWorksheet = workbook.Sheets.Add(After: bfrWorksheet);
                    }

                    crrWorksheet.Name = info.NewName;
                    crrWorksheet.Visible = info.NewVisible ? XlSheetVisibility.xlSheetVisible : XlSheetVisibility.xlSheetHidden;
                    info.Initialize(crrWorksheet);
                }
                else if (info.IsUpdated)
                {
                    // 更新
                    crrWorksheet = workbook.Sheets[info.OldName];
                    crrWorksheet.Name = info.NewName;
                    crrWorksheet.Visible = info.NewVisible ? XlSheetVisibility.xlSheetVisible : XlSheetVisibility.xlSheetHidden;
                    if (info.NewIndex > 1)
                    {
                        crrWorksheet.Move(After: bfrWorksheet);
                    }

                    info.Initialize(crrWorksheet);
                }

                bfrWorksheet = info.Worksheet;
            }

            // 削除対象リストを初期化
            this.deleteList.Clear();

            // 警告抑止の解除
            application.DisplayAlerts = true;
        }

        /// <summary>
        /// 指定されたワークシート情報が示すワークシートを表示します。
        /// </summary>
        /// <param name="info">表示したいワークシート情報</param>
        public void MoveTo(WorksheetInfo info)
        {
            _Worksheet worksheet = info.Worksheet;

            if (worksheet == null)
            {
                return;
            }

            worksheet.Activate();
        }

        /// <summary>
        /// 新しいシーケンス番号を取得します。
        /// </summary>
        /// <returns>シーケンス番号</returns>
        private int GetSequence()
        {
            return this.sequence++;
        }

        /// <summary>
        /// 実際のワークブックからワークシート情報を取得します。
        /// </summary>
        /// <returns>ワークシート情報リスト</returns>
        private SortableBindingList<WorksheetInfo> GetWorksheetInfo()
        {
            Workbook book = Globals.ThisAddIn.Application.ActiveWorkbook;
            var list = new SortableBindingList<WorksheetInfo>();

            foreach (Worksheet sheet in book.Worksheets)
            {
                list.Add(new WorksheetInfo(sheet));
            }

            return list;
        }

        /// <summary>
        /// このクラスを初期化します。
        /// </summary>
        private void Initialize()
        {
            this.WorksheetInfoList = this.GetWorksheetInfo();
            this.sequence = this.WorksheetInfoList.Count + 1;
        }
    }
}
