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
        #endregion

        #region Constructor
        public Model() { }

        public Model(string name)
        {
            Name = name;
        }
        #endregion
    }
}
