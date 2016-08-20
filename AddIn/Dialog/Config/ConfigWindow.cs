﻿namespace ExcelX.AddIn.Dialog.Config
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
        /// 画面上で設定された値を現在の設定に反映します。
        /// </summary>
        private void Apply()
        {
            foreach (var key in this.configlist.Keys)
            {
                var item = this.configlist[key];
                item.OnApply();
            }
        }

        /// <summary>
        /// 「適用」ボタンが押下されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void BtnApply_Click(object sender, EventArgs e)
        {
            this.Apply();
        }

        /// <summary>
        /// 「キャンセル」ボタンが押下されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 「OK」ボタンが押下されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            this.Apply();
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
            this.TrvConfigList.SuspendLayout();
            this.TrvConfigList.Nodes.AddRange(trunk.ToArray());
            this.TrvConfigList.ResumeLayout();
        }

        /// <summary>
        /// 設定リスト項目が選択されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void TrvConfigList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var pane = this.PnlConfigItemt;
            ConfigItemBase content;

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
        }
    }
}