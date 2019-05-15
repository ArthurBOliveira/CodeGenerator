using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    class Model
    {
        private string name;
        private List<Property> properties;
        private string nameProject;
        private string parent;
        private bool isRelation;

        #region Properties
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public List<Property> Properties
        {
            get
            {
                return properties;
            }

            set
            {
                properties = value;
            }
        }

        public string NameProject
        {
            get
            {
                return nameProject;
            }

            set
            {
                nameProject = value;
            }
        }

        public string Parent
        {
            get
            {
                return parent;
            }

            set
            {
                parent = value;
            }
        }

        public bool IsRelation
        {
            get
            {
                return isRelation;
            }

            set
            {
                isRelation = value;
            }
        }
        #endregion

        #region Constructor
        public Model() { }

        public Model(string text)
        {
            string[] strings;
            var prop = new Property();

            NameProject = Program.project.Name;

            name = text.Split(new string[] { " " }, StringSplitOptions.None)[1].Split(new string[] { "\r" }, StringSplitOptions.None)[0];

            try
            {
                parent = text.Split(new string[] { name + " :" }, StringSplitOptions.None)[1].Split(new string[] { "\r" }, StringSplitOptions.None)[0].Trim();
            }
            catch
            {
                parent = "";
            }

            properties = new List<Property>();

            strings = text.Split(new string[] { "{ get; set; }" }, StringSplitOptions.None);

            for (int i = 0; i < strings.Length - 1; i++)
            {
                string type = strings[i].Split(new string[] { "public" }, StringSplitOptions.None)[1].Split(new string[] { " " }, StringSplitOptions.None)[1].Trim();
                string name = strings[i].Split(new string[] { "public" }, StringSplitOptions.None)[1].Split(new string[] { " " }, StringSplitOptions.None)[2];

                if (!CheckType(type))
                {
                    prop.Type = type;
                    prop.Name = name;

                    if (prop.Type != "void")
                        properties.Add(prop);

                    prop = new Property();
                }
            }
        }

        private bool CheckType(string type)
        {
            switch (type)
            {
                case "Guid":
                    return false;
                case "Int":
                    return false;
                case "int":
                    return false;
                case "Bool":
                    return false;
                case "bool":
                    return false;
                case "Boolean":
                    return false;
                case "boolean":
                    return false;
                case "DateTime":
                    return false;
                case "String":
                    return false;
                case "string":
                    return false;
                case "Float":
                    return false;
                case "float":
                    return false;
                case "Double":
                    return false;
                case "double":
                    return false;
                case "Decimal":
                    return false;
                case "decimal":
                    return false;
                case "void":
                    return false;
                default:
                    return true;
            }
        }
        #endregion
    }
}