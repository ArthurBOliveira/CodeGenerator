using System.IO;

namespace CodeGenerator
{
    class ModelGenerator : Generator
    {
        public static bool Generate(Model m, string path)
        {
            if (m.Name.Contains("Hist") || m.Name == "BaseModel")
                return false;

            bool result = false;
            string fileName = m.Name + ".cs";
            string text = "";

            text += "using System;\r\n";
            text += "using System.Collections.Generic;\r\n";
            text += "using System.Linq;\r\n";
            text += "using System.Web;\r\n\r\n";

            text += "namespace " + m.NameProject + ".Models\r\n";
            text += "{\r\n";

            text += "\tpublic class " + m.Name + " : Control\r\n";
            text += "\t{\r\n";

            foreach (Property p in m.Properties)
                text += "\t\tpublic " + p.Type + " " + UppercaseFirst(p.Name) + " { get; set; }\r\n";

            text += "\r\n\t\t#region Methods\r\n";

            //Create
            text += "\t\tpublic void Create(String UserHostAddress, String UserHostName)\r\n";
            text += "\t\t{\r\n";
            text += "\t\t\tId = Guid.NewGuid();\r\n\r\n";

            text += "\t\t\tbase.Update(UserHostAddress, UserHostName);\r\n";
            text += "\t\t}\r\n\r\n";

            //Update
            text += "\t\tpublic void Update(String UserHostAddress, String UserHostName, " + m.Name + " " + LowercaseFirst(m.Name) + ")\r\n";
            text += "\t\t{\r\n";
            text += "\t\t\tbase.Update(UserHostAddress, UserHostName);\r\n\r\n";

            text += "\t\t\tUpdate(" + LowercaseFirst(m.Name) + ");\r\n";
            text += "\t\t}\r\n\r\n";


            //Update Model
            text += "\t\tpublic void Update(" + m.Name + " " + LowercaseFirst(m.Name) + ")\r\n";
            text += "\t\t{\r\n";

            foreach (Property p in m.Properties)
                text += "\t\t\t" + UppercaseFirst(p.Name) + " = " + LowercaseFirst(m.Name) + "." + UppercaseFirst(p.Name) + ";\r\n";

            text += "\t\t}\r\n\r\n";

            //Equals
            text += "\t\tpublic override bool Equals(object obj)\r\n";
            text += "\t\t{\r\n";

            text += "\t\t\tif(obj is " + m.Name + ")\r\n";
            text += "\t\t\t{\r\n";

            text += "\t\t\t\t" + m.Name + " aux = obj as " + m.Name + ";\r\n\r\n";

            foreach (Property p in m.Properties)
                text += "\t\t\t\tif( aux." + UppercaseFirst(p.Name) + " != " + UppercaseFirst(p.Name) + ") { return false; }\r\n";

            text += "\r\n\t\t\t\treturn true;\r\n";

            text += "\t\t\t}\r\n";

            text += "\t\t\treturn false;\r\n";

            text += "\t\t}\r\n\r\n";


            //GetHashCode
            text += "\t\tpublic override int GetHashCode()\r\n";
            text += "\t\t{\r\n";
            text += "\t\t\tint hash = 0;\r\n\r\n";

            foreach (Property p in m.Properties)
                text += "\t\t\thash += " + UppercaseFirst(p.Name) + ".GetHashCode();\r\n";

            text += "\r\n\t\t\treturn hash;\r\n";
            text += "\t\t}\r\n\r\n";

            text += "\t\t#endregion\r\n\r\n";

            text += "\t}\r\n\r\n";

            //Generate Class Hist
            text += "\r\n\r\n\tpublic class " + m.Name + "Hist : " + m.Name + "\r\n";
            text += "\t{\r\n";

            text += "\t\tpublic Guid IdHist { get; set; }\r\n\r\n";

            text += "\t\t#region Methods\r\n";

            //To Hist
            text += "\t\tpublic void ToHist(" + m.Name + " value)\r\n";
            text += "\t\t{\r\n";
            text += "\t\t\tIdHist = Guid.NewGuid();\r\n\r\n";
            foreach (Property p in m.Properties)
                text += "\t\t\tthis." + UppercaseFirst(p.Name) + " = value." + UppercaseFirst(p.Name) + ";\r\n";

            text += "\t\t}\r\n\r\n";

            //From Hist
            text += "\t\tpublic " + m.Name + " FromHist()\r\n";
            text += "\t\t{\r\n";
            text += "\t\t\t" + m.Name + " aux = new " + m.Name + "()\r\n";
            text += "\t\t\t{\r\n";
            for (int i = 0; i < m.Properties.Count; i++)
            {
                if (i != m.Properties.Count - 1)
                    text += "\t\t\t\t" + UppercaseFirst(m.Properties[i].Name) + " = this." + UppercaseFirst(m.Properties[i].Name) + ",\r\n";
                else
                    text += "\t\t\t\t" + UppercaseFirst(m.Properties[i].Name) + " = this." + UppercaseFirst(m.Properties[i].Name) + "\r\n";
            }
            text += "\t\t\t};\r\n\r\n";

            text += "\t\t\treturn aux;\r\n";
            text += "\t\t}\r\n\r\n";

            //Equals
            text += "\t\tpublic override bool Equals(object obj)\r\n";
            text += "\t\t{\r\n";
            text += "\t\t\tif (obj is " + m.Name + ")\r\n";
            text += "\t\t\t{\r\n";
            text += "\t\t\t\t" + m.Name + " auxObj = obj as " + m.Name + ";\r\n";

            text += "\t\t\t\treturn this.Equals(auxObj);\r\n";
            text += "\t\t\t}\r\n";
            text += "\t\t\telse if (obj is " + m.Name + "Hist)\r\n";
            text += "\t\t\t{\r\n";
            text += "\t\t\t\t" + m.Name + "Hist auxHistObj = obj as " + m.Name + "Hist;\r\n";
            text += "\t\t\t\t" + m.Name + " auxObj = auxHistObj.FromHist();\r\n";

            text += "\t\t\t\treturn this.Equals(auxObj);\r\n";
            text += "\t\t\t}\r\n";

            text += "\t\t\treturn false;\r\n";
            text += "\t\t}\r\n\r\n";

            //GetHashCode
            text += "\t\tpublic override int GetHashCode()\r\n";
            text += "\t\t{\r\n";
            text += "\r\n\t\t\treturn this.FromHist().GetHashCode();\r\n";
            text += "\t\t}\r\n\r\n";

            text += "\t\t#endregion\r\n\r\n";

            text += "\t}\r\n";

            text += "}";

            StreamWriter file = File.AppendText(path + fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }

        public static bool Generate()
        {
            bool result = false;
            string fileName = "Control.cs";

            string text = @"using System; namespace + " + Program.project.Name + " +.Models { public class Control { public Boolean control_active { get; set; } public String control_hostAddress { get; set; } public DateTime control_date { get; set; } public String control_userHostName { get; set; } public void Update(string UserHostAddress, String UserHostName) { control_active = true; MetaData(UserHostAddress, UserHostName); } public void Delete(string UserHostAddress, String UserHostName) { control_active = false; MetaData(UserHostAddress, UserHostName); } /// <summary> /// True, if same control entry /// </summary> public bool RowVersion(Control control) { this.control_date = this.control_date.AddMilliseconds(-this.control_date.Millisecond); return this.control_date == control.control_date; } /// <summary> /// Update the entry /// </summary> private void MetaData(string UserHostAddress, String UserHostName) { control_hostAddress = UserHostAddress; control_date = DateTime.UtcNow; control_userHostName = UserHostName; } public override bool Equals(object obj) { if (obj is Control) { Control control = obj as Control; if (control.control_active != control_active) { return false; } if (control.control_hostAddress != control_hostAddress) { return false; } if (control.control_date != control_date) { return false; } if (control.control_userHostName != control_userHostName) { return false; } return true; } return false; } public override int GetHashCode() { int hash = 0; hash += control_active.GetHashCode(); hash += control_hostAddress.GetHashCode(); hash += control_date.GetHashCode(); hash += control_userHostName.GetHashCode(); return hash; } } }";

            StreamWriter file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }
    }
}
