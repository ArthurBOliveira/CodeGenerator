using System;
using System.Collections.Generic;

namespace CodeGenerator
{
    class Controller
    {
        public string Name { get; set; }
        public List<Endpoint> Endpoints { get; set; }

        public Controller(string text)
        {
            Name = text.Split(new string[] { "Controller" }, StringSplitOptions.None)[0]
                       .Split(new string[] { "class " }, StringSplitOptions.None)[1];

            Endpoints = new List<Endpoint>();
            var ends = text.Split(new string[] { "[Http" }, StringSplitOptions.None);

            for(int i = 1; i <= ends.Length; i++)
            {
                try
                {
                    var endpoint = new Endpoint()
                    {
                        Name = ends[i].Split(new string[] { "Route(\"" }, StringSplitOptions.None)[1]
                                  .Split(new string[] { "\"), ResponseType" }, StringSplitOptions.None)[0],
                        HttpVerb = ends[i].Split(',')[0],
                        ReturnType = ends[i].Split(new string[] { "typeof(" }, StringSplitOptions.None)[1]
                                        .Split(new string[] { "))]" }, StringSplitOptions.None)[0],
                        Properties = new List<Property>()
                    };

                    var aux = ends[i].Split(new string[] { "public" }, StringSplitOptions.None)[1]
                    .Split('(')[1]
                    .Split(')')[0];

                    if (aux == "")
                    {
                        Endpoints.Add(endpoint);
                        continue;
                    }

                    var endParams = aux.Contains(",")
                                  ? aux.Split(',')
                                  : new string[] { aux };

                    foreach (string param in endParams)
                    {
                        var prop = new Property()
                        {
                            Name = param.Split(new string[] { " " }, StringSplitOptions.None)[1],
                            Type = param.Split(new string[] { " " }, StringSplitOptions.None)[0]
                                        .Split(new string[] { "]" }, StringSplitOptions.None)[1],
                        };

                        endpoint.Properties.Add(prop);
                    }

                    Endpoints.Add(endpoint);
                }
                catch { }
            }
        }
    }

    class Endpoint
    {
        public string Name { get; set; }
        public string HttpVerb { get; set; }
        public string ReturnType { get; set; }
        public List<Property> Properties { get; set; }
    }
}
