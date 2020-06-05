/*Gog Ionela-Maria
 * Text strip problem
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace TextStrip
{
    class StripText
    {
        public StripText()
        {
        }

        public string Text(string text, char[] mark)
        {
            int i, pos;
            string trim = "";
            string strip = "";
            string text_new = "";
            bool flag = false;

            string[] sep = new string[] { "\n" };
            string[] str = text.Split(sep, StringSplitOptions.None);

            foreach (string s in str)
            {
                flag = false;
                for (i = 0; i < mark.Length; i++)
                {
                    if (s.Contains(mark[i]))
                    {
                        pos = s.IndexOf(mark[i]);
                        strip = s.Substring(0, s.Length - pos);
                        trim = strip.Trim();
                        text_new = text_new + trim + "\n";
                        flag = true;
                    }             
                }
                if (flag == false)
                    text_new = text_new + s + "\n";
            }      
            return text_new;
        }
    }
}
