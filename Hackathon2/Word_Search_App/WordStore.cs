using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon2
{
    public static class WordStore
    {
        private static string key = "Words";

        public static Dictionary<string, string> Words
        {
            get
            {
                if (HttpContext.Current.Session[key] == null)
                {
                    HttpContext.Current.Session[key] = new Dictionary<string, string>()
                {
                    { "fun", "" },
                    { "sequel", "" },
                    { "adulation", "" }
                };
                }
                return (Dictionary<string, string>)HttpContext.Current.Session[key];
            }
        }

        public static void AddTranslation(string word, string translation)
        {
            if (Words.ContainsKey(word))
            {
                Words[word] = translation;
            }
        }

        public static bool WordExists(string word)
        {
            return Words.ContainsKey(word);
        }

        public static Dictionary<string, string> GetAllWords()
        {
            return Words;
        }
    }


}

