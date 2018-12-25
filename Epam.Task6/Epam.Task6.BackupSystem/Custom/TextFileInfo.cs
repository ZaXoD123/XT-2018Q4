using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Epam.Task6.BackupSystem
{
    [Serializable]
    public class TextFileInfo
    {
        public TextFileInfo(string str)
        {
            var file = new FileInfo(str);
            this.Id = ++IdLast;
            this.Rev = 1;
            this.Path = file.FullName;
            this.DeathTime = new List<(DateTime, DateTime?)>();
            this.LastChangeTime = file.LastWriteTime;
        }

        public static string DirPath { get; set; }

        public static int IdLast { get; private set; }

        public int Id { get; }

        public int Rev { get; private set; }

        public string Path { get; }

        public List<(DateTime, DateTime?)> DeathTime { get; }

        public DateTime LastChangeTime { get; private set; }
        
        public static void Add(List<TextFileInfo> files, TextFileInfo newFile, int currentPathNumber)
        {
            var temp = files.SingleOrDefault(x => x.Path == newFile.Path);
            if (temp == null)
            {
                Directory.CreateDirectory($@".\Logs\{currentPathNumber}");
                File.Copy(newFile.Path, $@".\Logs\{currentPathNumber}\{newFile.Id}${newFile.Rev}.backup");
                files.Add(newFile);
            }
            else
            {
                if (temp.LastChangeTime < newFile.LastChangeTime)
                {
                    temp.Update(newFile);
                    Directory.CreateDirectory($@".\Logs\{currentPathNumber}");
                    File.Copy(temp.Path, $@".\Logs\{currentPathNumber}\{temp.Id}${temp.Rev}.backup");
                }

                if (temp.DeathTime.Count != 0 && temp.DeathTime[temp.DeathTime.Count - 1].Item2 == null)
                {
                    temp.DeathTime[temp.DeathTime.Count - 1] = (temp.DeathTime[temp.DeathTime.Count - 1].Item1, DateTime.Now);
                }
            }
        }

        public static void DeathTimeAdd(List<TextFileInfo> files, string[] a)
        {
            foreach (var item in files.Where(x => !a.Contains(x.Path)))
            {
                if (item.DeathTime.Count == 0 || item.DeathTime[item.DeathTime.Count - 1].Item2 != null)
                {
                    item.DeathTime.Add((DateTime.Now, null));
                }
            }
        }

        public static void Restore(List<TextFileInfo> files, DateTime time, string[] input, int currentPathNumber)
        {
            var a = files.Where(x => x.DeathTime.Count == 0 || !x.DeathTime.Any(y => y.Item1.Ticks < time.Ticks && (y.Item2 == null || ((DateTime)y.Item2).Ticks > time.Ticks)));

            foreach (var item in input)
            {
                File.Delete(item);
            }

            foreach (var item in a)
            {
                var z = Directory.GetFiles($@".\Logs\{currentPathNumber}", $"{item.Id}$*.backup");

                for (var i = z.Length - 1; i >= 0; i--)
                {
                    var tempStr = $@".\Logs\{currentPathNumber}\{z[i].Remove(0, z[i].LastIndexOf(@"\"[0]) + 1)}";
                    var temp = new FileInfo(tempStr);
                    if (temp.LastWriteTime.Ticks < time.Ticks)
                    {
                        Directory.CreateDirectory(item.Path.Substring(0, item.Path.LastIndexOf(@"\")));
                        File.Copy(tempStr, item.Path, true);
                        break;
                    }
                }
            }
        }

        public void Update(TextFileInfo update)
        {
            this.Rev++;
            this.LastChangeTime = update.LastChangeTime;
        }
    }
}