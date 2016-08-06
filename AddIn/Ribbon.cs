namespace ExcelX.AddIn
{
    using ExcelX.AddIn.Dialog;
    using Microsoft.Office.Tools.Ribbon;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void SearchSplitButton_Click(object sender, RibbonControlEventArgs e)
        {
            this.OpenSearchReplaceWindow();
        }

        private void OpenSearchReplaceWindow()
        {
            // ダイアログのインスタンスを取得
            var dialog = SearchReplaceWindow.GetInstance();

            if (dialog.Visible == false)
            {
                // Excelのウィンドウハンドルを取得
                var owner = Control.FromHandle(Process.GetCurrentProcess().MainWindowHandle);

                // オーナーを指定してダイアログの表示
                dialog.Show(owner);
            }
            else
            {
                // 既に表示済みなのでフォーカス
                dialog.Focus();
            }
        }
    }
}
