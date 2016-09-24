namespace ExcelX.AddIn.Config
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Serialization;

    /// <summary>
    /// 設定ファイル
    /// </summary>
    [Serializable]
    [XmlRoot("ExcelExtensionAddIn")]
    public class ConfigDocument
    {
        /// <summary>
        /// 設定ファイル名
        /// </summary>
        private static string fileName = @"ExcelExtensionAddIn.config";

        /// <summary>
        /// 設定ファイルパス
        /// </summary>
        private static string filePath = Path.Combine(
                                            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                                            ConfigDocument.fileName);

        /// <summary>
        /// ConfigDocument クラスのインスタンスを初期化します。
        /// </summary>
        public ConfigDocument()
        {
            // デフォルト設定で初期化
            this.Initialize();
        }

        /// <summary>
        /// ConfigDocument の 現在のインスタンスを取得します。
        /// </summary>
        public static ConfigDocument Current { get; private set; }

        /// <summary>
        /// デフォルトのファイル名を取得します。
        /// </summary>
        public static string FileName
        {
            get
            {
                return ConfigDocument.fileName;
            }
        }

        /// <summary>
        /// 編集に関する設定を取得または設定します。
        /// </summary>
        [XmlElement("Edit")]
        public EditConfig Edit { get; set; }

        /// <summary>
        /// 図形に関する設定を取得または設定します。
        /// </summary>
        [XmlElement("Shape")]
        public ShapeConfig Shape { get; set; }

        /// <summary>
        /// ローカルファイルから設定を読み込みます。
        /// </summary>
        public static void Load()
        {
            if (File.Exists(ConfigDocument.filePath) == true)
            {
                ConfigDocument.Current = ConfigDocument.LoadFromFile(ConfigDocument.filePath);
            }
            else
            {
                ConfigDocument.Current = new ConfigDocument();
            }
        }

        /// <summary>
        /// パスを指定して設定を読み込みます。
        /// </summary>
        /// <param name="filePath">ファイルパス</param>
        public static void Load(string filePath)
        {
            if (File.Exists(filePath) == false)
            {
                return;
            }

            ConfigDocument.Current = ConfigDocument.LoadFromFile(filePath);
        }

        /// <summary>
        /// ローカルファイルに設定を保存します。
        /// </summary>
        public static void Save()
        {
            ConfigDocument.SaveToFile(ConfigDocument.filePath, ConfigDocument.Current);
        }

        /// <summary>
        /// 保存先を指定して設定を保存します。
        /// </summary>
        /// <param name="filePath">ファイルパス</param>
        public static void Save(string filePath)
        {
            ConfigDocument.SaveToFile(filePath, ConfigDocument.Current);
        }

        /// <summary>
        /// XMLファイルからシリアライズ可能なオブジェクトを読み込みます。
        /// </summary>
        /// <param name="filePath">オブジェクトが保存されたXMLファイルパス</param>
        /// <returns>デシリアライズされたオブジェクト</returns>
        private static ConfigDocument LoadFromFile(string filePath)
        {
            ConfigDocument obj = null;
            var serializer = new XmlSerializer(typeof(ConfigDocument));

            // ファイルが存在するときだけ実行可能
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException();
            }

            // ファイルからオブジェクトの読み込み（デシリアライズ）
            using (var fs = new FileStream(filePath, FileMode.Open))
            {
                obj = serializer.Deserialize(fs) as ConfigDocument;
            }

            return obj;
        }

        /// <summary>
        /// シリアライズ可能なオブジェクトをXMLファイルへ書き込みます。
        /// </summary>
        /// <param name="filePath">書き込むXMLファイルパス</param>
        /// <param name="obj">シリアライズするオブジェクト</param>
        private static void SaveToFile(string filePath, object obj)
        {
            var serializer = new XmlSerializer(typeof(ConfigDocument));

            // 空の名前空間を設定
            var ns = new XmlSerializerNamespaces();
            ns.Add(string.Empty, string.Empty);

            // 書き込む書式の設定
            var settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            settings.Indent = true;
            settings.NewLineChars = Environment.NewLine;

            // ファイルへオブジェクトを書き込み（シリアライズ）
            using (var writer = XmlWriter.Create(filePath, settings))
            {
                serializer.Serialize(writer, obj, ns);
            }
        }

        /// <summary>
        /// デフォルト設定で初期化します。
        /// </summary>
        private void Initialize()
        {
            this.Edit = new EditConfig()
            {
                A1 = new A1Config()
                {
                    ZoomEnabled = false,
                    ZoomRatio = 100,
                    AutoSaveEnabled = false,
                    AutoSaveOverwrite = true,
                    GroupEnabled = false,
                    RowLevels = 1,
                    ColumnLevels = 1
                },
                Grid = new GridConfig()
                {
                    Size = 15
                }
            };
            this.Shape = new ShapeConfig()
            {
                RectangleBalloonList = new List<RectangleBalloonConfig>()
                {
                    new RectangleBalloonConfig()
                    {
                        DisplayName = "吹き出し(青)",
                        Enabled = true,
                        Width = 160,
                        Height = 90,
                        BorderSize = 1,
                        BorderColor = new ColorConfig(0, 0, 255),
                        BackgroundColor = new ColorConfig(153, 204, 255, 0.25f),
                        FontSize = 9,
                        FontColor = new ColorConfig(0, 0, 0),
                        FontName = "ＭＳ Ｐゴシック"
                    },
                    new RectangleBalloonConfig()
                    {
                        DisplayName = "吹き出し(白)",
                        Enabled = true,
                        Width = 160,
                        Height = 90,
                        BorderSize = 1,
                        BorderColor = new ColorConfig(51, 51, 51),
                        BackgroundColor = new ColorConfig(255, 255, 255, 0.25f),
                        FontSize = 9,
                        FontColor = new ColorConfig(0, 0, 0),
                        FontName = "ＭＳ Ｐゴシック"
                    }
                }
            };
        }
    }
}
