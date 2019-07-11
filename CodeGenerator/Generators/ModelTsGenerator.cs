using System.IO;

namespace CodeGenerator
{
    class ModelTsGenerator : Generator
    {
        public static bool Generate(Model m, string path)
        {
            if (m.Name.Contains("Hist") || m.Name == "BaseModel")
                return false;

            bool result = false;
            string fileName = LowercaseFirst(m.Name) + ".ts";

            string text = "import { BaseModel } from \"../../models/base.model\"";

            text += "\r\n\r\n";
            text += "export interface " + m.Name + " extends BaseModel {\r\n";
            foreach (var p in m.Properties)
                text += "\t" + p.Name + ": " + ConvertTypeToTS(p.Type) + ";\r\n";
            text += "}";

            text += "\r\n\r\n";
            text += "export class " + m.Name + "Model implements " + m.Name + " {\r\n";
            foreach (var p in m.Properties)
                text += "\t" + p.Name + ": " + ConvertTypeToTS(p.Type) + ";\r\n";
            text += "\tactive: number;\r\n";
            text += "\tuserHost: string;\r\n";
            text += "\tdate: Date;\r\n";
            text += "\thostAddress: string;\r\n";

            text += "\tconstructor() {\r\n\r\n";
            text += "\t}\r\n";
            text += "}";

            var file = File.AppendText(path + fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }

    }
}
