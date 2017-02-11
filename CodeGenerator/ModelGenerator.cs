using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    class ModelGenerator : Generator
    {
        public static bool Generate(Model m)
        {
            bool result = false;
            string fileName = m.Name + ".cs";
            string text = "";

            text += "using System;\r\n";
            text += "using System.Collections.Generic;\r\n";
            text += "using System.Linq;\r\n";
            text += "using System.Web;\r\n\r\n";

            text += "namespace " + m.NameProject + ".Models\r\n";
            text += "{\r\n";

            text += "\tpublic class " + m.Name + "\r\n";
            text += "\t{\r\n";

            foreach (Property p in m.Properties)
            {
                text += "\t\tprivate " + p.Type + " " + p.Name + ";\r\n";
            }

            text += "\r\n\t\t#region Properties\r\n";

            foreach (Property p in m.Properties)
            {
                text += "\t\tpublic " + p.Type + " " + UppercaseFirst(p.Name) + "\r\n";
                text += "\t\t{\r\n";
                text += "\t\t\tget\r\n";
                text += "\t\t\t{\r\n";
                text += "\t\t\t\treturn " + p.Name + ";\r\n";
                text += "\t\t\t}\r\n";

                text += "\t\t\tset\r\n";
                text += "\t\t\t{\r\n";
                text += "\t\t\t\t" + p.Name + " = value;\r\n";
                text += "\t\t\t}\r\n";
                text += "\t\t}\r\n\r\n";
            }

            text += "\t\t#endregion\r\n\r\n";

            text += "\t\t#region Constructor\r\n";

            text += "\t\tpublic " + m.Name + " () { }\r\n\r\n";

            text += "\t\t#endregion\r\n\r\n";

            text += "\t}\r\n";

            text += "}\r\n";


            StreamWriter file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }
    }
}
