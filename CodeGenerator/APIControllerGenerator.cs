using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    class APIControllerGenerator : Generator
    {
        public static bool Generate(Model m)
        {
            bool result = false;
            string fileName = m.Name + "Controller.cs";
            string text = "";

            text += "using System;\r\n";
            text += "using System.Collections.Generic;\r\n";
            text += "using System.Linq;\r\n";
            text += "using System.Web;\r\n";
            text += "using System.Net.Http;\r\n";
            text += "using System.Web.Http;\r\n";
            text += "using " + m.NameProject + ".BLL;\r\n";
            text += "using " + m.NameProject + ".Models;\r\n\r\n";

            text += "namespace " + m.NameProject + ".Controllers\r\n";
            text += "{\r\n";

            text += "\tpublic class " + m.Name + "Controller : ApiController\r\n";
            text += "\t{\r\n";

            //Get
            text += "\t\tpublic IHttpActionResult Get(int id)\r\n";
            text += "\t\t{\r\n";

            text += "\t\t\t" + m.Name + " result = " + m.Name + "BLL.Select(id);\r\n\r\n";

            text += "\t\t\tif (result." + UppercaseFirst(m.Properties[0].Name) + " != 0)\r\n";
            text += "\t\t\t\treturn Ok(result);\r\n";
            text += "\t\t\telse\r\n";
            text += "\t\t\t\treturn BadRequest();\r\n";

            text += "\t\t}\r\n";

            //Get List
            text += "\t\tpublic IHttpActionResult Get()\r\n";
            text += "\t\t{\r\n";

            text += "\t\t\tList<" + m.Name + "> result = " + m.Name + "BLL.List();\r\n\r\n";

            text += "\t\t\tif (result.Count != 0)\r\n";
            text += "\t\t\t\treturn Ok(result);\r\n";
            text += "\t\t\telse\r\n";
            text += "\t\t\t\treturn BadRequest();\r\n";

            text += "\t\t}\r\n";

            //Post
            text += "\t\tpublic IHttpActionResult Post([FromBody]" + m.Name + " value)\r\n";
            text += "\t\t{\r\n";

            text += "\t\t\tif (" + m.Name + "BLL.Create(value))\r\n";
            text += "\t\t\t\treturn Ok();\r\n";
            text += "\t\t\telse\r\n";
            text += "\t\t\t\treturn BadRequest();\r\n";

            text += "\t\t}\r\n";

            //Put
            text += "\t\tpublic IHttpActionResult Put([FromBody]" + m.Name + " value)\r\n";
            text += "\t\t{\r\n";

            text += "\t\t\tif (" + m.Name + "BLL.Update(value))\r\n";
            text += "\t\t\t\treturn Ok();\r\n";
            text += "\t\t\telse\r\n";
            text += "\t\t\t\treturn BadRequest();\r\n";

            text += "\t\t}\r\n";

            //Delete
            text += "\t\tpublic IHttpActionResult Delete(int id)\r\n";
            text += "\t\t{\r\n";

            text += "\t\t\tif (" + m.Name + "BLL.Delete(id))\r\n";
            text += "\t\t\t\treturn Ok();\r\n";
            text += "\t\t\telse\r\n";
            text += "\t\t\t\treturn BadRequest();\r\n";

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
