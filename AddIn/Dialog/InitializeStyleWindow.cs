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

    /// <summary>
    /// 「スタイルの初期化」ダイアログ
    /// </summary>
    public partial class InitializeStyleWindow : Form
    {
        /// <summary>
        /// InitializeStyleWindow のインスタンスを初期化します。
        /// </summary>
        public InitializeStyleWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// キャンセルボタンが押下されたとき呼び出されます。
        /// </summary>
        public event EventHandler Canceled;

        /// <summary>
        /// 最大値を取得または設定します。
        /// </summary>
        public int Maximum
        {
            get
            {
                return this.progressBar1.Maximum;
            }

            set
            {
                this.progressBar1.Maximum = value;
            }
        }

        /// <summary>
        /// 最小値を取得または設定します。
        /// </summary>
        public int Minimum
        {
            get
            {
                return this.progressBar1.Minimum;
            }

            set
            {
                this.progressBar1.Minimum = value;
            }
        }

        /// <summary>
        /// ステップを取得または設定します。
        /// </summary>
        public int Step
        {
            get
            {
                return this.progressBar1.Step;
            }

            set
            {
                this.progressBar1.Step = value;
            }
        }

        /// <summary>
        /// 現在の値を取得または設定します。
        /// </summary>
        public int Value
        {
            get
            {
                return this.progressBar1.Value;
            }

            set
            {
                this.progressBar1.Value = value;
            }
        }

        /// <summary>
        /// ウィンドウを閉じます。
        /// </summary>
        public new void Close()
        {
            Action action = () =>
            {
                base.Close();
            };

            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        /// <summary>
        /// メッセージを指定してステップを進めます。
        /// </summary>
        /// <param name="message">表示するメッセージ</param>
        public void PerformStep(string message)
        {
            Action action = () =>
            {
                this.progressBar1.PerformStep();
                this.label1.Text = message;
            };

            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        /// <summary>
        /// キャンセルボタンが押下されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベントオブジェクト</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.OnCanceled(new EventArgs());
        }

        /// <summary>
        /// キャンセルイベントを実行します。
        /// </summary>
        /// <param name="e">イベントオブジェクト</param>
        private void OnCanceled(EventArgs e)
        {
            if (this.Canceled != null)
            {
                this.Canceled(this, e);
            }
        }
    }
}
