using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    class StoredProceduresGenerator : Generator
    {
        public static bool Generate(Model m)
        {
            bool result = false;

            result = CreateProcedure(m);
            result = ListProcedure(m);
            result = SelectProcedure(m);
            result = UpdateProcedure(m);
            result = DeleteProcedure(m);

            return result;
        }

        private static bool CreateProcedure(Model m)
        {
            bool result = false;

            string fileName = "dbo." + m.Name + "-create.sql";
            string text = "";

            text += "CREATE PROCEDURE [dbo].[proc_" + LowercaseFirst(m.Name) + "_create]\r\n";

            for (int i = 0; i < m.Properties.Count; i++)
            {
                if (i == (m.Properties.Count - 1))
                    text += "\t@" + ConvertNameToSQL(m.Properties[i].Name) + " " + ConvertTypeToSQL(m.Properties[i].Type) + "\r\n";
                else
                    text += "\t@" + ConvertNameToSQL(m.Properties[i].Name) + " " + ConvertTypeToSQL(m.Properties[i].Type) + ",\r\n";
            }

            text += "AS\r\n";

            text += "INSERT INTO " + LowercaseFirst(m.Name) + "\r\n";

            text += "\t(";

            for (int i = 0; i < m.Properties.Count; i++)
            {
                if (i == (m.Properties.Count - 1))
                    text += ConvertNameToSQL(m.Properties[i].Name);
                else
                    text += ConvertNameToSQL(m.Properties[i].Name) + ", ";
            }

            text += ")\r\n";

            text += "\tVALUES (";

            for (int i = 0; i < m.Properties.Count; i++)
            {
                if (i == (m.Properties.Count - 1))
                    text += "@" + ConvertNameToSQL(m.Properties[i].Name);
                else
                    text += "@" + ConvertNameToSQL(m.Properties[i].Name) + ", ";
            }

            text += ")\r\n";

            text += "Return 0";

            StreamWriter file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }

        private static bool ListProcedure(Model m)
        {
            bool result = false;

            string fileName = "dbo." + m.Name + "-list.sql";
            string text = "";

            text += "CREATE PROCEDURE [dbo].[proc_" + LowercaseFirst(m.Name) + "_list]\r\n";

            text += "AS\r\n";

            text += "\tSELECT * FROM " + LowercaseFirst(m.Name) + "\r\n";

            text += "Return 0";

            StreamWriter file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }

        private static bool SelectProcedure(Model m)
        {
            bool result = false;

            string fileName = "dbo." + m.Name + "-select.sql";
            string text = "";

            text += "CREATE PROCEDURE [dbo].[proc_" + LowercaseFirst(m.Name) + "_select]\r\n";

            text += "\t@" + ConvertNameToSQL(m.Properties[0].Name) + " " + ConvertTypeToSQL(m.Properties[0].Type) + "\r\n";

            text += "AS\r\n";

            text += "\tSELECT * FROM " + LowercaseFirst(m.Name) + "\r\n";

            text += "\tWHERE " + ConvertNameToSQL(m.Properties[0].Name) + " = @" + ConvertNameToSQL(m.Properties[0].Name) + "\r\n";

            text += "Return 0";

            StreamWriter file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }

        private static bool UpdateProcedure(Model m)
        {
            bool result = false;

            string fileName = "dbo." + m.Name + "-update.sql";
            string text = "";

            text += "CREATE PROCEDURE [dbo].[proc_" + LowercaseFirst(m.Name) + "_update]\r\n";

            for (int i = 0; i < m.Properties.Count; i++)
            {
                if (i == (m.Properties.Count - 1))
                    text += "\t@" + ConvertNameToSQL(m.Properties[i].Name) + " " + ConvertTypeToSQL(m.Properties[i].Type) + "\r\n";
                else
                    text += "\t@" + ConvertNameToSQL(m.Properties[i].Name) + " " + ConvertTypeToSQL(m.Properties[i].Type) + ",\r\n";
            }

            text += "AS\r\n";

            text += "\tUPDATE " + LowercaseFirst(m.Name) + "\r\n";

            text += "\tSET ";

            for (int i = 1; i < m.Properties.Count; i++)
            {
                if (i == (m.Properties.Count - 1))
                    text += ConvertNameToSQL(m.Properties[i].Name) + " = @" + ConvertNameToSQL(m.Properties[i].Name) + "\r\n";
                else
                    text += ConvertNameToSQL(m.Properties[i].Name) + " = @" + ConvertNameToSQL(m.Properties[i].Name) + ", ";
            }


            text += "\tWHERE " + ConvertNameToSQL(m.Properties[0].Name) + " = @" + ConvertNameToSQL(m.Properties[0].Name) + "\r\n";

            text += "Return 0";

            StreamWriter file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }

        private static bool DeleteProcedure(Model m)
        {
            bool result = false;

            string fileName = "dbo." + m.Name + "-delete.sql";
            string text = "";

            text += "CREATE PROCEDURE [dbo].[proc_" + LowercaseFirst(m.Name) + "_delete]\r\n";

            text += "\t@" + ConvertNameToSQL(m.Properties[0].Name) + " " + ConvertTypeToSQL(m.Properties[0].Type) + "\r\n";

            text += "AS\r\n";

            text += "\tDELETE " + LowercaseFirst(m.Name) + "\r\n";

            text += "\tWHERE " + ConvertNameToSQL(m.Properties[0].Name) + " = @" + ConvertNameToSQL(m.Properties[0].Name) + "\r\n";

            text += "Return 0";

            StreamWriter file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }
    }
}
