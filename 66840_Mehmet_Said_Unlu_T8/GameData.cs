using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _66840_Mehmet_Said_Unlu_T8
{
    public static class GameData
    {
        public enum GameMode
        {
            WordOnly,
            SentencesOnly,
            Both
        }

        public static List<string> Words { get; private set; }
        public static List<string> Sentences { get; private set; }
        public static List<string> All { get; private set; }
        public static GameMode Mode { get; set; }

        static GameData()
        {
            LoadData();
        }

        private static void LoadData()
        {
            Words = new List<string>();
            Sentences = new List<string>();
            All = new List<string>();

            string[] lines = File.ReadAllLines("AllWordsAndSentences.TXT");

            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');

                if (parts.Length == 1)
                {
                    Words.Add(parts[0]);
                }
                else
                {
                    Sentences.Add(string.Join(" ", parts));
                }

                All.Add(line);
            }
        }
    }
}
