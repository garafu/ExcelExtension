namespace ExcelX.AddIn.Dialog.Config
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
    /// 設定のメインウィンドウ
    /// </summary>
    public partial class ConfigWindow : Form
    {
        /// <summary>
        /// 各設定の子画面ハッシュ
        /// </summary>
        private Dictionary<string, ConfigItemBase> configlist = new Dictionary<string, ConfigItemBase>();

        /// <summary>
        /// ConfigWindow クラスのインスタンスを初期化します。
        /// </summary>
        public ConfigWindow()
        {
            this.InitializeComponent();
            this.Initialize();
        }

        /// <summary>
        /// 「適用」が実行されたとき発生します。
        /// </summary>
        public event EventHandler Apply;

        /// <summary>
        /// 「適用」ボタンが押下されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            this.OnApply();
        }

        /// <summary>
        /// 「キャンセル」ボタンが押下されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 設定リスト項目が選択されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void ConfigListTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var pane = this.configItemPanel;
            ConfigItemBase content;

            // スクロールを無効化してスクロール位置を初期化
            pane.AutoScroll = false;

            // 古いコンテンツを削除
            if (pane.Controls.Count > 0)
            {
                content = pane.Controls[0] as ConfigItemBase;
                pane.Controls.Clear();
                content.OnHide();
            }

            // 新しいコンテンツを表示
            if (e.Node.Name != e.Node.Text)
            {
                content = this.configlist[e.Node.Name];
                pane.Controls.Add(content);
                content.OnShow();
            }

            // スクロールを有効化して必要に応じてスクロール表示
            pane.AutoScroll = true;
        }

        /// <summary>
        /// 「OK」ボタンが押下されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            this.OnApply();
            this.Close();
        }

        /// <summary>
        /// 指定された情報を元に設定カテゴリーを表す TreeNode を作成します。
        /// </summary>
        /// <param name="item">設定画面</param>
        /// <returns>カテゴリーを表す TreeNode</returns>
        private TreeNode CreateCategoryTreeNode(ConfigItemBase item)
        {
            var node = new TreeNode()
            {
                Name = item.CategoryName,
                Text = item.CategoryName
            };

            return node;
        }

        /// <summary>
        /// 指定された情報を元に設定値を表す TreeNode を作成します。
        /// </summary>
        /// <param name="item">設定画面</param>
        /// <returns>設定値を表す TreeNode</returns>
        private TreeNode CreateTreeNode(ConfigItemBase item)
        {
            var node = new TreeNode()
            {
                Name = item.GUID,
                Text = item.ItemName,
            };

            return node;
        }

        /// <summary>
        /// インスタンスを初期化します。
        /// </summary>
        private void Initialize()
        {
            var assembly = this.GetType().Assembly;
            var baseName = typeof(ConfigItemBase).FullName;
            var trunk = new List<TreeNode>();
            var category = new Dictionary<string, TreeNode>();
            TreeNode parentNode, childNode;

            // 実行中のアセンブリから ConfigItemBase を継承している UserControl を探す
            foreach (var type in assembly.GetTypes())
            {
                if (!type.IsClass || !type.IsPublic || type.IsAbstract || type.BaseType.FullName != baseName)
                {
                    continue;
                }

                // インスタンス作成
                var item = assembly.CreateInstance(type.FullName) as ConfigItemBase;

                // カテゴリノードを取得または生成
                if (category.ContainsKey(item.CategoryName) == true)
                {
                    parentNode = category[item.CategoryName];
                }
                else
                {
                    parentNode = this.CreateCategoryTreeNode(item);
                    parentNode.Expand();
                    trunk.Add(parentNode);
                    category.Add(item.CategoryName, parentNode);
                }

                // アイテムノードをカテゴリノードに追加
                childNode = this.CreateTreeNode(item);
                parentNode.Nodes.Add(childNode);

                // ハッシュテーブルに保存
                this.configlist.Add(item.GUID, item);
            }
            
            // TreeViewに反映
            this.configListTreeView.SuspendLayout();
            this.configListTreeView.Nodes.AddRange(trunk.ToArray());
            this.configListTreeView.ResumeLayout();
        }

        /// <summary>
        /// 画面上で設定された値を現在の設定に反映します。
        /// </summary>
        private void OnApply()
        {
            foreach (var key in this.configlist.Keys)
            {
                var item = this.configlist[key];
                item.OnApply();
            }

            if (this.Apply != null)
            {
                this.Apply(this, new EventArgs());
            }
        }
    }
}
