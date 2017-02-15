using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeGenerator
{
    class TableGenerator : Generator
    {
        public static bool Generate(Model m)
        {
            bool result = false;
            Model parent = null;

            if(m.Parent != "")
            {
                parent = Program.project.Models.Find(item => item.Name == m.Parent);
            }

            string fileName = "dbo." + m.Name + ".sql";
            string text = "";

            text += "CREATE TABLE [dbo].[" + LowercaseFirst(m.Name) + "]\r\n";
            text += "(\r\n";

            for(int i = 0; i < m.Properties.Count; i++)
            {
                if(i == 0)
                    text += "\t[" + m.Properties[i].Name + "] " + ConvertTypeToSQL(m.Properties[i].Type) + " NULL PRIMARY KEY,\r\n";
                else if(i == (m.Properties.Count - 1) && parent == null)
                    text += "\t[" + m.Properties[i].Name + "] " + ConvertTypeToSQL(m.Properties[i].Type) + " NULL\r\n";
                else
                    text += "\t[" + m.Properties[i].Name + "] " + ConvertTypeToSQL(m.Properties[i].Type) + " NULL,\r\n";
            }

            if(parent != null)
            {
                for (int i = 0; i < parent.Properties.Count; i++)
                {
                    if (i == (parent.Properties.Count - 1))
                        text += "\t[" + parent.Properties[i].Name + "] " + ConvertTypeToSQL(parent.Properties[i].Type) + " NULL\r\n";
                    else
                        text += "\t[" + parent.Properties[i].Name + "] " + ConvertTypeToSQL(parent.Properties[i].Type) + " NULL,\r\n";
                }
            }

            text += ")";

            StreamWriter file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }
    }
}
