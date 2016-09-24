namespace ExcelX.AddIn
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using log4net;

    /// <summary>
    /// ログ出力機能を提供します。
    /// </summary>
    public static class Log
    {
        /// <summary>
        /// ルートログ
        /// </summary>
        private static ILog logger = LogManager.GetLogger(Assembly.GetExecutingAssembly().Location);

        /// <summary>
        /// メッセージを指定して Debug ログを出力します。
        /// </summary>
        /// <param name="message">ログメッセージ</param>
        public static void Debug(object message)
        {
            Log.logger.Debug(message);
        }

        /// <summary>
        /// メッセージと例外を指定して Debug ログを出力します。
        /// </summary>
        /// <param name="message">ログメッセージ</param>
        /// <param name="exception">例外</param>
        public static void Debug(object message, Exception exception)
        {
            Log.logger.Debug(message, exception);
        }

        /// <summary>
        /// メッセージを指定して Info ログを出力します。
        /// </summary>
        /// <param name="message">ログメッセージ</param>
        public static void Info(object message)
        {
            Log.logger.Info(message);
        }

        /// <summary>
        /// メッセージと例外を指定して Info ログを出力します。
        /// </summary>
        /// <param name="message">ログメッセージ</param>
        /// <param name="exception">例外</param>
        public static void Info(object message, Exception exception)
        {
            Log.logger.Info(message, exception);
        }

        /// <summary>
        /// メッセージを指定して Warn ログを出力します。
        /// </summary>
        /// <param name="message">ログメッセージ</param>
        public static void Warn(object message)
        {
            Log.logger.Debug(message);
        }

        /// <summary>
        /// メッセージと例外を指定して Warn ログを出力します。
        /// </summary>
        /// <param name="message">ログメッセージ</param>
        /// <param name="exception">例外</param>
        public static void Warn(object message, Exception exception)
        {
            Log.logger.Warn(message, exception);
        }

        /// <summary>
        /// メッセージを指定して Error ログを出力します。
        /// </summary>
        /// <param name="message">ログメッセージ</param>
        public static void Error(object message)
        {
            Log.logger.Error(message);
        }

        /// <summary>
        /// メッセージと例外を指定して Error ログを出力します。
        /// </summary>
        /// <param name="message">ログメッセージ</param>
        /// <param name="exception">例外</param>
        public static void Error(object message, Exception exception)
        {
            Log.logger.Error(message, exception);
        }

        /// <summary>
        /// メッセージを指定して Fatal ログを出力します。
        /// </summary>
        /// <param name="message">ログメッセージ</param>
        public static void Fatal(object message)
        {
            Log.logger.Fatal(message);
        }

        /// <summary>
        /// メッセージと例外を指定して Fatal ログを出力します。
        /// </summary>
        /// <param name="message">ログメッセージ</param>
        /// <param name="exception">例外</param>
        public static void Fatal(object message, Exception exception)
        {
            Log.logger.Fatal(message, exception);
        }
    }
}
