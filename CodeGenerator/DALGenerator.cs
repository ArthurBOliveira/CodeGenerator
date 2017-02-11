using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    class DALGenerator : Generator
    {
        public static bool Generate(Model m)
        {
            bool result = false;
            string fileName = m.Name + "DAL.cs";
            string text = "";

            text += "using System;\r\n";
            text += "using System.Collections.Generic;\r\n";
            text += "using System.Linq;\r\n";
            text += "using System.Web;\r\n";
            text += "using " + m.NameProject + ".Models;\r\n";
            text += "using System.Configuration;\r\n";
            text += "using System.Data;\r\n";
            text += "using System.Data.SqlClient;\r\n\r\n";

            text += "namespace " + m.NameProject + ".DAL\r\n";
            text += "{\r\n";

            text += "\tpublic class " + m.Name + "DAL\r\n";
            text += "\t{\r\n";

            //Connection String
            text += "\t\tprivate static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[\"ConnectionString\"].ConnectionString);\r\n\r\n";

            #region Select
            text += "\t\tpublic static " + m.Name + " Select(int id)\r\n";
            text += "\t\t{\r\n";

            text += "\t\t\t" + m.Name + " result = new " + m.Name + "();\r\n";

            text += "\t\t\tSqlCommand cmd = new SqlCommand(\"proc_" + LowercaseFirst(m.Name) + "_select\", conn);\r\n";
            text += "\t\t\tSqlDataReader reader;\r\n\r\n";

            text += "\t\t\tcmd.CommandType = CommandType.StoredProcedure;\r\n";
            text += "\t\t\tcmd.Parameters.Add(new SqlParameter(\"@id_" + LowercaseFirst(m.Name) + "\", id));\r\n\r\n";

            text += "\t\t\ttry\r\n";
            text += "\t\t\t{\r\n";

            text += "\t\t\t\tconn.Open();\r\n";
            text += "\t\t\t\treader = cmd.ExecuteReader();\r\n\r\n";

            text += "\t\t\t\tif (reader.Read())\r\n";
            text += "\t\t\t\t{\r\n";

            for(int i = 0; i < m.Properties.Count; i++)
            {
                if(m.Properties[i].Type == "int")
                    text += "\t\t\t\t\tresult." + UppercaseFirst(m.Properties[i].Name) + " = reader.Get" + UppercaseFirst(m.Properties[i].Type) + "32(" + i + ");\r\n";
                else if (m.Properties[i].Type == "bool")
                    text += "\t\t\t\t\tresult." + UppercaseFirst(m.Properties[i].Name) + " = reader.Get" + UppercaseFirst(m.Properties[i].Type) + "ean(" + i + ");\r\n";
                else
                    text += "\t\t\t\t\tresult." + UppercaseFirst(m.Properties[i].Name) + " = reader.Get" + UppercaseFirst(m.Properties[i].Type) + "(" + i + ");\r\n";
            }

            text += "\t\t\t\t}\r\n";
            text += "\t\t\t}\r\n";

            text += "\t\t\tcatch (Exception e)\r\n";
            text += "\t\t\t{\r\n";

            text += "\t\t\t\tresult = new " + m.Name + "();\r\n";

            text += "\t\t\t}\r\n";

            text += "\t\t\tfinally\r\n";
            text += "\t\t\t{\r\n";

            text += "\t\t\t\tconn.Close();\r\n";

            text += "\t\t\t}\r\n\r\n";

            text += "\t\t\treturn result;\r\n";

            text += "\t\t}\r\n\r\n";
            #endregion

            #region List
            text += "\t\tpublic static List<" + m.Name + "> List()\r\n";
            text += "\t\t{\r\n";

            text += "\t\t\tList<" + m.Name + "> result = new List<" + m.Name + ">();\r\n";
            text += "\t\t\t" + m.Name + " aux = new " + m.Name + "();\r\n\r\n";

            text += "\t\t\tSqlCommand cmd = new SqlCommand(\"proc_" + LowercaseFirst(m.Name) + "_list\", conn);\r\n";
            text += "\t\t\tSqlDataReader reader;\r\n\r\n";

            text += "\t\t\tcmd.CommandType = CommandType.StoredProcedure;\r\n\r\n";

            text += "\t\t\ttry\r\n";
            text += "\t\t\t{\r\n";

            text += "\t\t\t\tconn.Open();\r\n";
            text += "\t\t\t\treader = cmd.ExecuteReader();\r\n\r\n";

            text += "\t\t\t\twhile (reader.Read())\r\n";
            text += "\t\t\t\t{\r\n";

            for (int i = 0; i < m.Properties.Count; i++)
            {
                if (m.Properties[i].Type == "int")
                    text += "\t\t\t\t\taux." + UppercaseFirst(m.Properties[i].Name) + " = reader.Get" + UppercaseFirst(m.Properties[i].Type) + "32(" + i + ");\r\n";
                else if (m.Properties[i].Type == "bool")
                    text += "\t\t\t\t\taux." + UppercaseFirst(m.Properties[i].Name) + " = reader.Get" + UppercaseFirst(m.Properties[i].Type) + "ean(" + i + ");\r\n";                
                else
                    text += "\t\t\t\t\taux." + UppercaseFirst(m.Properties[i].Name) + " = reader.Get" + UppercaseFirst(m.Properties[i].Type) + "(" + i + ");\r\n";
            }

            text += "\r\n\t\t\t\t\tresult.Add(aux);\r\n";
            text += "\t\t\t\t\taux = new " + m.Name + "();\r\n";

            text += "\t\t\t\t}\r\n";
            text += "\t\t\t}\r\n";

            text += "\t\t\tcatch (Exception e)\r\n";
            text += "\t\t\t{\r\n";

            text += "\t\t\t\tresult = new List<" + m.Name + ">();\r\n";

            text += "\t\t\t}\r\n";

            text += "\t\t\tfinally\r\n";
            text += "\t\t\t{\r\n";

            text += "\t\t\t\tconn.Close();\r\n";

            text += "\t\t\t}\r\n\r\n";

            text += "\t\t\treturn result;\r\n";

            text += "\t\t}\r\n\r\n";
            #endregion

            #region Create
            text += "\t\tpublic static bool Create(" + m.Name + " value)\r\n";
            text += "\t\t{\r\n";
            text += "\t\t\tbool result = false;\r\n";

            text += "\t\t\tSqlCommand cmd = new SqlCommand(\"proc_" + LowercaseFirst(m.Name) + "_create\", conn);\r\n";

            text += "\t\t\tcmd.CommandType = CommandType.StoredProcedure;\r\n\r\n";

            foreach (Property p in m.Properties)
            {
                text += "\t\t\tcmd.Parameters.Add(new SqlParameter(\"@" + ConvertNameToSQL(p.Name) + "\", value." + UppercaseFirst(p.Name) + "));\r\n";
            }

            text += "\r\n\t\t\ttry\r\n";
            text += "\t\t\t{\r\n";

            text += "\t\t\t\tconn.Open();\r\n";
            text += "\t\t\t\tif(cmd.ExecuteNonQuery() == 1)\r\n";
            text += "\t\t\t\t\tresult = true;\r\n\r\n";

            text += "\t\t\t}\r\n";

            text += "\t\t\tcatch (Exception e)\r\n";
            text += "\t\t\t{\r\n";

            text += "\t\t\t\tresult = false;\r\n";

            text += "\t\t\t}\r\n";

            text += "\t\t\tfinally\r\n";
            text += "\t\t\t{\r\n";

            text += "\t\t\t\tconn.Close();\r\n";

            text += "\t\t\t}\r\n\r\n";

            text += "\t\t\treturn result;\r\n";

            text += "\t\t}\r\n\r\n";
            #endregion

            #region Update
            text += "\t\tpublic static bool Update(" + m.Name + " value)\r\n";
            text += "\t\t{\r\n";
            text += "\t\t\tbool result = false;\r\n";

            text += "\t\t\tSqlCommand cmd = new SqlCommand(\"proc_" + LowercaseFirst(m.Name) + "_update\", conn);\r\n";

            text += "\t\t\tcmd.CommandType = CommandType.StoredProcedure;\r\n\r\n";

            foreach (Property p in m.Properties)
            {
                text += "\t\t\tcmd.Parameters.Add(new SqlParameter(\"@" + ConvertNameToSQL(p.Name) + "\", value." + UppercaseFirst(p.Name) + "));\r\n";
            }

            text += "\r\n\t\t\ttry\r\n";
            text += "\t\t\t{\r\n";

            text += "\t\t\t\tconn.Open();\r\n";
            text += "\t\t\t\tif(cmd.ExecuteNonQuery() == 1)\r\n";
            text += "\t\t\t\t\tresult = true;\r\n\r\n";

            text += "\t\t\t}\r\n";

            text += "\t\t\tcatch (Exception e)\r\n";
            text += "\t\t\t{\r\n";

            text += "\t\t\t\tresult = false;\r\n";

            text += "\t\t\t}\r\n";

            text += "\t\t\tfinally\r\n";
            text += "\t\t\t{\r\n";

            text += "\t\t\t\tconn.Close();\r\n";

            text += "\t\t\t}\r\n\r\n";

            text += "\t\t\treturn result;\r\n";

            text += "\t\t}\r\n\r\n";
            #endregion

            #region Delete
            text += "\t\tpublic static bool Delete(int id)\r\n";
            text += "\t\t{\r\n";
            text += "\t\t\tbool result = false;\r\n";

            text += "\t\t\tSqlCommand cmd = new SqlCommand(\"proc_" + LowercaseFirst(m.Name) + "_delete\", conn);\r\n";

            text += "\t\t\tcmd.CommandType = CommandType.StoredProcedure;\r\n\r\n";
            text += "\t\t\tcmd.Parameters.Add(new SqlParameter(\"@id_" + LowercaseFirst(m.Name) + "\", id));\r\n\r\n";

            text += "\r\n\t\t\ttry\r\n";
            text += "\t\t\t{\r\n";

            text += "\t\t\t\tconn.Open();\r\n";
            text += "\t\t\t\tif(cmd.ExecuteNonQuery() == 1)\r\n";
            text += "\t\t\t\t\tresult = true;\r\n\r\n";

            text += "\t\t\t}\r\n";

            text += "\t\t\tcatch (Exception e)\r\n";
            text += "\t\t\t{\r\n";

            text += "\t\t\t\tresult = false;\r\n";

            text += "\t\t\t}\r\n";

            text += "\t\t\tfinally\r\n";
            text += "\t\t\t{\r\n";

            text += "\t\t\t\tconn.Close();\r\n";

            text += "\t\t\t}\r\n\r\n";

            text += "\t\t\treturn result;\r\n";

            text += "\t\t}\r\n\r\n";
            #endregion

            text += "\t}\r\n";

            text += "}\r\n";


            StreamWriter file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }
    }
}
