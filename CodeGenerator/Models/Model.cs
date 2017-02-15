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

        internal List<Property> Properties
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
        #endregion

        #region Constructor
        public Model() { }

        public Model(string name)
        {
            Name = name;
        }

        public Model(string text, bool v)
        {
            string[] strings;
            Property prop = new Property();

            NameProject = Program.project.Name;

            name = text.Split(new string[] { "class" }, StringSplitOptions.None)[1].Split(new string[] { " " }, StringSplitOptions.None)[1].Split(new string[] { "\r" }, StringSplitOptions.None)[0];

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

            for(int i = 0; i < strings.Length; i++)
            {
                if (i != 0)
                {
                    prop.Type = strings[i].Split(new string[] { "public" }, StringSplitOptions.None)[1].Split(new string[] { " " }, StringSplitOptions.None)[1].Trim();
                    prop.Name = strings[i].Split(new string[] { "public" }, StringSplitOptions.None)[1].Split(new string[] { " " }, StringSplitOptions.None)[2];
                }
                else
                {
                    prop.Type = strings[i].Split(new string[] { "public" }, StringSplitOptions.None)[2].Split(new string[] { " " }, StringSplitOptions.None)[1].Trim();
                    prop.Name = strings[i].Split(new string[] { "public" }, StringSplitOptions.None)[2].Split(new string[] { " " }, StringSplitOptions.None)[2];
                }
            
                if(prop.Type != "void")
                    properties.Add(prop);

                prop = new Property();
            }
        }
        #endregion
    }
}
