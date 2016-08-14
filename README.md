# Excel拡張 （ExcelExtension）

Excel を利用していて微妙に足りなかったあんなことやこんなことができるようになる…ハズ！


## 説明

現状では検索機能を強化して シェイプ や グラフ が検索できるようになります。
また、正規表現を利用した検索も行えます。

実装は VSTO (Visual Studio Tools for Office) を利用して作成しているので、
利用する際は以下の「動作環境」に記載の注意事項をご確認ください。


## 機能

- ファイル
 - 現在のブックを別ウィンドウで開く
 - ファイルを指定して別ウィンドウで開く
 - 現在のブックのフォルダを開く
 - 読み取り専用の設定/解除
- 編集
 - シェイプ、グラフの検索
 - 正規表現を利用した検索
 - すべてのシートでA1セルへフォーカス
 - デフォルト以外のスタイルをすべて削除
 - シート管理
- ...


## 動作環境

- [.NET Framework 4.5](https://www.microsoft.com/ja-jp/download/details.aspx?id=30653) 以上
- [Visual Studio 2010 Tools for Office Runtime](https://www.microsoft.com/ja-jp/download/details.aspx?id=48217)
- Microsoft Excel 2007 / 2010 / 2013


## 使い方

1. リボンに追加された「拡張ツール」を選択
2. 使いたい機能のボタンを押下（…といっても現状は「検索」だけ）
3. 検索文字列を入力して「検索」を実行


## インストール方法

1. 任意のバージョンの インストーラ（installer.msi） をダウンロードします。

  [Release : garafu/ExcelExtension](https://github.com/garafu/ExcelExtension/releases)

2. ダウンロードした installer.msi ファイルを実行します。

3. 指示に従ってインストールします。

4. インストールが完了したら Excel を起動します。

  →「拡張ツール」タブが増えているハズ！

※アンインストールは「コントロールパネル」の「プログラムと機能」から「Excel Extension Addin」を削除してください。


## その他

この プロジェクト では [セマンティックバージョニング](http://semver.org/lang/ja/) を採用します。


## 作者

- [GitHub / garafu](https://github.com/garafu)


## ライセンス

- [MIT](https://raw.githubusercontent.com/garafu/ExcelExtension/master/MIT-LICENSE.txt)

