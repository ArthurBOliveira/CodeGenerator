using System.Collections.Generic;
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
            string fileName = LowercaseFirst(m.Name) + ".model.ts";
            List<Model> parents = GetAllParents(m);
            string parentProperties = GetParentProperties(parents);

            string text = "";

            //text = "import { BaseModel } from \"../../models/base.model\""; // I have removed the base class import as this should be imported depending on where the final file will be placed

            // interface
            text += "\r\n\r\n";
            text += "export interface " + m.Name + " extends BaseModel {\r\n";
            foreach (var p in m.Properties)
                text += "\t" + p.Name + ": " + ConvertTypeToTS(p.Type) + ";\r\n";
            text += "}";

            text += "\r\n\r\n";

            //model
            text += "export class " + m.Name + "Model implements " + m.Name + " {\r\n";
            foreach (var p in m.Properties)
                text += "\t" + p.Name + ": " + ConvertTypeToTS(p.Type) + ";\r\n";
            text += parentProperties;
            text += "\tconstructor() {\r\n\r\n";
            text += "\t}\r\n";
            text += "}";

            //history interface
            text += "\r\n\r\n";
            text += "export interface " + m.Name + "Hist extends " + m.Name + " {\r\n";
            text += "\tidHist: string;\r\n";
            text += "}";

            //history model
            text += "\r\n\r\n";
            text += "export class " + m.Name + "HistModel implements " + m.Name + "Hist {\r\n";
            text += "\tidHist: string;\r\n";
            foreach (var p in m.Properties)
                text += "\t" + p.Name + ": " + ConvertTypeToTS(p.Type) + ";\r\n";
            text += parentProperties;
            text += "}";

            var file = File.AppendText(path + fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }

        private static string GetParentProperties(List<Model> parents)
        {
            string retObj = "";

            foreach (var item in parents)
            {
                foreach (var p in item.Properties)
                    retObj += "\t" + p.Name + ": " + ConvertTypeToTS(p.Type) + ";\r\n";
            }

            return retObj;
        }
    }
}
