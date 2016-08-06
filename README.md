# Excel拡張 （ExcelExtension）

Excel を利用していて微妙に足りなかったあんなことやこんなことができるようになる…ハズ！


## 説明

現状では検索機能を強化して シェイプ や グラフ が検索できるようになります。
また、正規表現を利用した検索も行えます。

実装は VSTO (Visual Studio Tools for Office) を利用して作成しているので、
利用する際は以下の「動作環境」に記載の注意事項をご確認ください。


## 機能

- シェイプ、グラフの検索
- 正規表現を利用した検索
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

1. ファイルの配置

  以下に記載のファイルを任意のディレクトリに配置します。

    - ExcelX.dll
    - ExcelX.dll.manifest
    - ExcelX.vsto
    - Microsoft.Office.Tools.Common.v4.0.Utilities.dll
    - Microsoft.Office.Tools.Excel.v4.0.Utilities.dll

2. レジストリの追加

  デスクトップで `[Win] + [R]` を押下して、 `regedit` を指定して「レジストリエディタ」を起動します。
  以下のキーおよび値を追加します。

  - 追加するキー

      - HKEY_CURRENT_USER\Software\Microsoft\Office\Excel\Addins\ExcelExtension

  - 追加する値

      - Description : ExcelExtension
      - FriendlyName : ExcelExtension
      - LoadBehavior : 3
      - Manifest : [INSTALLDIR]ExcelExtension.vsto

  ※[INSTALLDIR] には 1. で配置したパスを指定します。

3. アドイン登録

  Excelを起動してアドイン登録を行います。
  「COMアドイン」 に項目追加されているため、チェックを入れて「OK」を選択します。
  インストールが始まり、利用可能になります。


## その他

この プロジェクト では [セマンティックバージョニング](http://semver.org/lang/ja/) を採用します。


## 作者

- [GitHub / garafu](https://github.com/garafu)


## ライセンス

- [MIT](http://b4b4r07.mit-license.org)
