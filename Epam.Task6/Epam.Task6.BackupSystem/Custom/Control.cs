using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Epam.Task6.BackupSystem
{
    internal static class Control
    {
        private static readonly BinaryFormatter BinaryFormatter = new BinaryFormatter();
        private static FileSystemWatcher watcher;
        private static List<TextFileInfo> fileInfos;
        private static string directory;
        private static List<string> pathes;
        private static int currentPathNumber;

        public static void Restore(DateTime currentTime)
        {
            var input = Directory.GetFiles(directory, "*.txt", SearchOption.AllDirectories);
            TextFileInfo.Restore(fileInfos, currentTime, input, currentPathNumber);
        }

        public static void Start(string directory)
        {
            Control.directory = directory;
            watcher = new FileSystemWatcher(directory);
            Directory.CreateDirectory(@".\Logs");
            try
            {
                using (var fs = new FileStream("pathlist.dat", FileMode.OpenOrCreate))
                {
                    pathes = BinaryFormatter.Deserialize(fs) as List<string>;
                }

                if (pathes.Contains(directory))
                {
                    currentPathNumber = pathes.IndexOf(directory);
                    using (var fs = new FileStream($"data{pathes.IndexOf(directory)}.dat", FileMode.OpenOrCreate))
                    {
                        fileInfos = BinaryFormatter.Deserialize(fs) as List<TextFileInfo>;
                    }
                }
                else
                {
                    fileInfos = new List<TextFileInfo>();
                    pathes.Add(directory);
                    currentPathNumber = pathes.Count - 1;
                }
            }
            catch (Exception)
            {
                pathes = new List<string> { directory };
                fileInfos = new List<TextFileInfo>();
                currentPathNumber = 0;
            }

            watcher.EnableRaisingEvents = true;
            Watcher(null, null);
        }

        public static void Watch()
        {
            watcher.Changed += Watcher;
        }

        public static void DoNotWatch()
        {
            watcher.Changed -= Watcher;
        }

        public static void Save()
        {
            using (var fs = new FileStream($"data{currentPathNumber}.dat", FileMode.Create))
            {
                BinaryFormatter.Serialize(fs, fileInfos);
            }

            using (var fs = new FileStream("pathlist.dat", FileMode.Create))
            {
                BinaryFormatter.Serialize(fs, pathes);
            }
        }

        private static void Watcher(object sender, FileSystemEventArgs a)
        {
            var input = Directory.GetFiles(directory, "*.txt", SearchOption.AllDirectories);
            foreach (var item in input)
            {
                TextFileInfo.Add(fileInfos, new TextFileInfo(item), currentPathNumber);
            }

            TextFileInfo.DeathTimeAdd(fileInfos, input);
        }
    }
}