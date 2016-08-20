namespace ExcelX.AddIn.Dialog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// バージョンダイアログ
    /// </summary>
    public partial class VersionInfoWindow : Form
    {
        /// <summary>
        /// VersionInfoWindow クラス の インスタンス を初期化します。
        /// </summary>
        public VersionInfoWindow()
        {
            this.InitializeComponent();

            var asmprd = (AssemblyProductAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyProductAttribute));
            this.productNameLabel.Text = asmprd.Product;

            var version = Assembly.GetExecutingAssembly().GetName().Version;
            this.versionLabel.Text = version.ToString();
        }

        /// <summary>
        /// 「OK」ボタンを押下したときに呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
