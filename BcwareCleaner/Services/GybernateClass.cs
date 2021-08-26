using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcwareCleaner.Services
{
    public class GybernateClass
    {
        /* Проверяем включение */
        public bool Activated()
        {
            List<string> cmdtext = new BcwareCleaner.Utilites.ProcessUtils().StartCmd("chcp 1251 & powercfg /a");
            foreach (string text in cmdtext)
            {
                string text1 = text;
                if (!string.IsNullOrEmpty(text1))
                {
                    if (text1.Contains("Режим гибернации не включен"))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        /* Включаем и выключаем */
        public void Enable(bool on)
        {
            new BcwareCleaner.Utilites.ProcessUtils().StartCmd("chcp 1251 & powercfg /h " + on.ToString().Replace("True", "on").Replace("False", "off"));
        }
    }
}
