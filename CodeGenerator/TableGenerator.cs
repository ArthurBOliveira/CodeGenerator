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

            string fileName = "dbo." + m.Name + ".sql";
            string text = "";

            text += "CREATE TABLE [dbo].[" + LowercaseFirst(m.Name) + "]\r\n";
            text += "(\r\n";

            for(int i = 0; i < m.Properties.Count; i++)
            {
                if(i == 0)
                    text += "\t[" + ConvertNameToSQL(m.Properties[i].Name) + "] " + ConvertTypeToSQL(m.Properties[i].Type) + " NOT NULL PRIMARY KEY IDENTITY,\r\n";
                else if(i == (m.Properties.Count - 1))
                    text += "\t[" + ConvertNameToSQL(m.Properties[i].Name) + "] " + ConvertTypeToSQL(m.Properties[i].Type) + " NOT NULL\r\n";
                else
                    text += "\t[" + ConvertNameToSQL(m.Properties[i].Name) + "] " + ConvertTypeToSQL(m.Properties[i].Type) + " NOT NULL,\r\n";
            }

            text += ")";

            StreamWriter file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }
    }
}
