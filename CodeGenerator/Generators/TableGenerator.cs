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
            Model grandParent = null;

            if (m.Parent != "")
                parent = Program.project.Models.Find(item => item.Name == m.Parent);

            if (parent != null)
                if (parent.Parent != "")
                    grandParent = Program.project.Models.Find(item => item.Name == parent.Parent);

            string fileName = "Scripts.sql";
            string text = "";

            text += "CREATE TABLE [jobmanager].[" + m.Name + "]\r\n";
            text += "(\r\n";

            for (int i = 0; i < m.Properties.Count; i++)
            {
                if (i == 0)
                {
                    if (ConvertTypeToSQL(m.Properties[i].Type) != "")
                        text += "\t[" + m.Properties[i].Name + "] " + ConvertTypeToSQL(m.Properties[i].Type) + " PRIMARY KEY,\r\n";
                }
                else
                {
                    if (ConvertTypeToSQL(m.Properties[i].Type) != "")
                    {
                        if (i == (m.Properties.Count - 1))
                        {
                            text += "\t[" + m.Properties[i].Name + "] " + ConvertTypeToSQL(m.Properties[i].Type) + " NUL\r\n";
                        }
                        else
                        {
                            text += "\t[" + m.Properties[i].Name + "] " + ConvertTypeToSQL(m.Properties[i].Type) + " NULL,\r\n";
                        }
                    }
                }
            }

            if (parent != null)
            {
                for (int i = 0; i < parent.Properties.Count; i++)
                {
                    if (ConvertTypeToSQL(parent.Properties[i].Type) != "")
                        text += "\t[" + parent.Properties[i].Name + "] " + ConvertTypeToSQL(parent.Properties[i].Type) + " NULL,\r\n";
                }
            }

            if (grandParent != null)
            {
                for (int i = 0; i < grandParent.Properties.Count; i++)
                {
                    if (ConvertTypeToSQL(grandParent.Properties[i].Type) != "")
                        text += "\t[" + grandParent.Properties[i].Name + "] " + ConvertTypeToSQL(grandParent.Properties[i].Type) + " NULL,\r\n";
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
