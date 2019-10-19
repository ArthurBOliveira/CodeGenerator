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
        public static bool Generate(Model m, string path)
        {
            if (m.Name == "BaseModel")
                return false;

            bool result = false;
            List<Model> parents = GetAllParents(m);

            string fileName = "Scripts.sql";
            string text = "";

            text += "CREATE TABLE [jm].[" + m.Name + "]\r\n";
            text += "(\r\n";

            for (int i = 0; i < m.Properties.Count; i++)
            {
                if (i == 0)
                {
                    if (ConvertTypeToSQL(m.Properties[i].Type) != "")
                        text += "\t[" + m.Properties[i].Name + "] " + ConvertTypeToSQL(m.Properties[i].Type) + " PRIMARY KEY";
                }
                else
                {
                    if (ConvertTypeToSQL(m.Properties[i].Type) != "")
                    {
                        text += ",\r\n\t[" + m.Properties[i].Name + "] " + ConvertTypeToSQL(m.Properties[i].Type) + " NULL";
                    }
                }
            }

            foreach(Model parent in parents)
            {
                for (int i = 0; i < parent.Properties.Count; i++)
                {
                    if (ConvertTypeToSQL(parent.Properties[i].Type) != "")
                        text += ",\r\n\t[" + parent.Properties[i].Name + "] " + ConvertTypeToSQL(parent.Properties[i].Type) + " NULL";
                }
            }

            text += "\r\n)";

            StreamWriter file = File.AppendText(path + fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }
    }
}
