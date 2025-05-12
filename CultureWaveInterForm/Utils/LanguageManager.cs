using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CultureWaveInterForm.Utils
{
    public static class LanguageManager
    {
        public static event Action LoadLanguage;

        public static void LoadSavedLanguage()
        {
            string language = Properties.Settings.Default.Language;
            ChangeLanguage(language, false);
        }

        public static void ChangeLanguage(string language, bool notify = true)
        {
            Thread.CurrentThread.CurrentUICulture =
                string.IsNullOrEmpty(language) || language == "es"
                ? new System.Globalization.CultureInfo("")
                : new System.Globalization.CultureInfo(language);


            Properties.Settings.Default.Language = language;
            Properties.Settings.Default.Save();

            if (notify)
            {
                LoadLanguage?.Invoke();
            }
        }

        public static string GetString(string key)
        {
            ResourceManager rm = new ResourceManager("CultureWaveInterForm.Resources.Strings", typeof(LanguageManager).Assembly);
            return rm.GetString(key) ?? "[{key}]";
        }
    }
}
