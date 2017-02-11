using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    class BLLGenerator : Generator
    {
        public static bool Generate(Model m)
        {
            bool result = false;
            string fileName = m.Name + "BLL.cs";
            string text = "";

            text += "using System;\r\n";
            text += "using System.Collections.Generic;\r\n";
            text += "using System.Linq;\r\n";
            text += "using System.Web;\r\n";
            text += "using " + m.NameProject + ".DAL;\r\n";
            text += "using " + m.NameProject + ".Models;\r\n";

            text += "namespace " + m.NameProject + ".BLL\r\n";
            text += "{\r\n";

            text += "\tpublic class " + m.Name + "BLL\r\n";
            text += "\t{\r\n";

            //Select
            text += "\t\tpublic static " + m.Name + " Select(int id)\r\n";
            text += "\t\t{\r\n";
            text += "\t\t\treturn " + m.Name + "DAL.Select(id);" + "\r\n";
            text += "\t\t}\r\n";

            //List
            text += "\t\tpublic static List<" + m.Name + "> List()\r\n";
            text += "\t\t{\r\n";
            text += "\t\t\treturn " + m.Name + "DAL.List();" + "\r\n";
            text += "\t\t}\r\n";

            //Create
            text += "\t\tpublic static bool Create(" + m.Name + " value)\r\n";
            text += "\t\t{\r\n";
            text += "\t\t\treturn " + m.Name + "DAL.Create(value);" + "\r\n";
            text += "\t\t}\r\n";

            //Update
            text += "\t\tpublic static bool Update(" + m.Name + " value)\r\n";
            text += "\t\t{\r\n";
            text += "\t\t\treturn " + m.Name + "DAL.Update(value);" + "\r\n";
            text += "\t\t}\r\n";

            //Delete
            text += "\t\tpublic static bool Delete(int id)\r\n";
            text += "\t\t{\r\n";
            text += "\t\t\treturn " + m.Name + "DAL.Delete(id);" + "\r\n";
            text += "\t\t}\r\n";

            text += "\t}\r\n";

            text += "}\r\n";


            StreamWriter file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }
    }
}
