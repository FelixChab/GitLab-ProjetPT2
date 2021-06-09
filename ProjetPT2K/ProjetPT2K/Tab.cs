using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPT2K
{
    class Tab
    {

        private Dictionary<String, List<String>> content = new Dictionary<string, List<string>>();

        public Tab(String[] collums)
        {
            foreach(String s in collums)
            {
                content.Add(s, new List<string>());
            }
        }

        public void addLine(String collum, String line)
        {
            content[collum].Add(line);
        }

        //public List<String> format()
       // {
       //     collums = new List<string>(content.Keys);

//        }
    }
}
