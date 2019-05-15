using System.Collections.Generic;

namespace CodeGenerator
{
    class Project
    {
        public string Name { get; set; }
        public List<Model> Models { get; set; }
        public List<Controller> Controllers { get; set; }
        
        public Project()
        {
            Models = new List<Model>();
            Controllers = new List<Controller>();
        }
    }
}
