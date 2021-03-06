﻿namespace ExcelX.AddIn
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using ExcelX.AddIn.Command;
    using ExcelX.AddIn.Dialog;
    using Microsoft.Office.Tools.Ribbon;

    /// <summary>
    /// リボンを表現するクラス
    /// </summary>
    public partial class Ribbon
    {
        /// <summary>
        /// リボンが読み込まれたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
        }

        /// <summary>
        /// 「現在のブックを別ウィンドウの読み取り専用で開く」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void OpenActiveWorkbookReadOnlyButton_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new OpenActiveWorkbookReadOnlyCommand();
            command.Execute();
        }

        /// <summary>
        /// 「現在のブックを別ウィンドウの編集用で開く」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void OpenActiveWorkbookEditableButton_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new OpenActiveWorkbookEditableCommand();
            command.Execute();
        }

        /// <summary>
        /// 「ファイルを選択して別ウィンドウの読み取り専用で開く」コマンド
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void OpenSelectWorkbookReadOnlyButton_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new OpenSelectWorkbookReadOnlyCommand();
            command.Execute();
        }

        /// <summary>
        /// 「ファイルを選択して別ウィンドウの編集用で開く」コマンド
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void OpenSelectWorkbookEditableButton_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new OpenSelectWorkbookEditableCommand();
            command.Execute();
        }

        /// <summary>
        /// 「フォルダを開く」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void OpenFolderButton_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new OpenActiveWorkbookFolderCommand();
            command.Execute();
        }

        /// <summary>
        /// 「読み取り専用の設定/解除」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void ToggleEditModeButton_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new ToggleEditModeCommand();
            command.Execute();
        }

        /// <summary>
        /// 「検索」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void SearchButton_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new OpenSearchReplaceCommand();
            command.Execute();
        }

        /// <summary>
        /// 「A1」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void SetA1Button_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new SetA1Command();
            command.Execute();
        }

        /// <summary>
        /// 「スタイル初期化」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void InitializeStyleButton_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new InitializeStyleCommand();
            command.Execute();
        }

        /// <summary>
        /// 「方眼紙」ボタンを押下したときに呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void MakeGridButton_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new MakeGridCommand();
            command.Execute();
        }

        /// <summary>
        /// 「シート管理」ボタンを押下したときに呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void ManageWorksheetButton_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new OpenWorksheetManageWindowCommand();
            command.Execute();
        }

        /// <summary>
        /// 吹き出しメニューの項目が読み込まれるとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void BalloonMenu_ItemsLoading(object sender, RibbonControlEventArgs e)
        {
            this.InitializeShapeMenu();
        }

        /// <summary>
        /// 「ヘルプ」ボタンを押下したときに呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void OpenHelpButton_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new OpenHelpCommand();
            command.Execute();
        }

        /// <summary>
        /// 「バージョン」ボタンを押下したときに呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void OpenVersionInfoButton_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new OpenVersionInfoWindowCommand();
            command.Execute();
        }

        /// <summary>
        /// 「設定」ボタンを押下したときに呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void ConfigButton_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new OpenConfigWindowCommand();
            command.Callback += (obj, evt) =>
            {
                this.InitializeShapeMenu();
            };
            command.Execute();
        }

        /// <summary>
        /// 「問題の報告」ボタンを押下したときに呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void ReportIssuesButton_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new ReportIssuesCommand();
            command.Execute();
        }

        /// <summary>
        /// 「吹き出し」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void AddBalloonButton_Click(object sender, RibbonControlEventArgs e)
        {
            var button = sender as RibbonButton;
            if (button == null)
            {
                return;
            }

            var command = new AddBalloonCommand();
            command.Execute((int)button.Tag);
        }

        /// <summary>
        /// 「図形」グループに含まれる個別メニューを初期化します。
        /// </summary>
        private void InitializeShapeMenu()
        {
            var config = Config.ConfigDocument.Current.Shape;

            this.balloonMenu.SuspendLayout();

            // もともとのボタンは削除
            this.balloonMenu.Items.Clear();

            // 「吹き出し」メニューの初期化
            for (var i = 0; i < config.RectangleBalloonList.Count; i++)
            {
                // 設定情報の取得
                var item = config.RectangleBalloonList[i];

                if (item.Enabled == false)
                {
                    continue;
                }

                // ボタンの生成
                var button = this.Factory.CreateRibbonButton();
                button.Label = item.DisplayName;
                button.Name = "addBalloonButton" + i;
                button.Tag = i;
                button.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AddBalloonButton_Click);

                // ボタンをメニューに追加
                this.balloonMenu.Items.Add(button);
            }

            this.balloonMenu.ResumeLayout();
        }
    }
}
