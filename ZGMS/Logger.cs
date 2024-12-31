using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ZGMS
{
    public class Logger
    {
        // 定义日志文件夹路径和日志文件的基础名称
        private static string logFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log");
        private static string logFileNameBase = "log";

        // 获取带有当天日期的日志文件完整路径
        private static string GetLogFilePath()
        {
            // 确保日志文件夹存在
            if (!Directory.Exists(logFolderPath))
            {
                Directory.CreateDirectory(logFolderPath);
            }

            // 构造日志文件名（例如：log_2024-12-20.txt）
            string logFileName = $"{logFileNameBase}_{DateTime.Now:yyyy-MM-dd}.txt";
            return Path.Combine(logFolderPath, logFileName);
        }

        // 向日志文件写入一条日志
        public static void WriteLog(string message)
        {
            // 获取日志文件路径
            string logFilePath = GetLogFilePath();

            // 将消息写入日志文件，使用追加模式
            File.AppendAllText(logFilePath, $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}{Environment.NewLine}");
        }
    }
}
