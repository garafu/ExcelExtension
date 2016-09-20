namespace ExcelX.AddIn
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using System.Xml.Linq;
    using ExcelX.AddIn.Config;
    using Microsoft.Office.Tools.Excel;
    using Excel = Microsoft.Office.Interop.Excel;
    using Office = Microsoft.Office.Core;

    /// <summary>
    /// アドインルートクラス
    /// </summary>
    public partial class ThisAddIn
    {
        /// <summary>
        /// VSTOアドインが読み込まれ、アセンブリ内のすべての初期化コードが実行された後に発生します。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            // 例外を補足するイベントハンドラの設定
            System.AppDomain.CurrentDomain.UnhandledException += this.CurrentDomain_UnhandledException;

            // 設定ファイルの読み込み
            ConfigDocument.Load();
        }

        /// <summary>
        /// キャッチされない例外を補足したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var exception = e.ExceptionObject as Exception;
            var caption = "予期しない例外";
            var text = exception.Message;
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// コードが読み込まれるアプリケーションドメインがアンロードされるとき発生します。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // 設定ファイルの保存
            ConfigDocument.Save();
        }

        #region VSTO で生成されたコード

        /// <summary>
        /// デザイナーのサポートに必要なメソッドです。
        /// このメソッドの内容をコード エディターで変更しないでください。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(this.ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(this.ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
