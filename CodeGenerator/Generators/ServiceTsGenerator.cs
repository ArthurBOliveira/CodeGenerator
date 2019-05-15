using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    class ServiceTsGenerator : Generator
    {
        public static bool Generate(Controller c)
        {
            bool result = false;
            string fileName = LowercaseFirst(c.Name) + ".service.ts";

            string text = "import { Injectable } from '@angular/core';\r\n";
            text += "import { HttpClient } from '@angular/common/http';\r\n";
            text += "import { Observable } from 'rxjs';\r\n";
            text += "import { JMServiceDefaultClass } from '../../shared/contracts/jm.api.service.contract';\r\n";
            text += "\r\n";
            text += "@Injectable({\r\n";
            text += "\tprovidedIn: 'root'\r\n";
            text += "})\r\n";
            text += "export interface " + c.Name + "Service extends JMServiceDefaultClass<" + c.Name + "> {\r\n\r\n";

            text += "\tconstructor(protected httpService: HttpClient) {\r\n";
            text += "\t\tsuper(httpService, '" + c.Name + "');\r\n";
            text += "\t}\r\n\r\n";

            //Generate the functions
            foreach(var end in c.Endpoints)
            {
                string param = "";
                foreach(var p in end.Properties)
                    param += p.Name + ": " + ConvertTypeToTS(p.Type) + ", ";
                param = param != "" ? param.Substring(0, param.Length - 2) : param;

                text += "\tpublic " + LowercaseFirst(end.Name) + "(" + param + "): Observable<" 
                                    + ConvertTypeToTS(end.ReturnType) + ">{\r\n";
                if (end.HttpVerb == "Get")
                {
                    string urlParam = "";

                    if (end.Properties.Count > 0)
                    {
                        urlParam = "?";

                        foreach (var p in end.Properties)
                            urlParam += p.Name + "=${" + p.Name + "}&";

                        urlParam = urlParam.Substring(0, urlParam.Length - 1);
                    }

                    text += "\t\treturn this.httpService." + LowercaseFirst(end.HttpVerb) 
                         + "<" + ConvertTypeToTS(end.ReturnType) + ">(`${ this.entity_url}/" 
                         + end.Name + urlParam + "`);\r\n";
                }
                else
                {
                    if (end.Properties.Count > 0)
                        foreach (var p in end.Properties)
                            text += "\t\tlet content: " + p.Type + " = INSERT_CODE_HERE;\r\n";

                    text += "\t\treturn this.httpService." + LowercaseFirst(end.HttpVerb) 
                         + "<" + ConvertTypeToTS(end.ReturnType) + ">(`${ this.entity_url}/" 
                         + end.Name + "`, ids);\r\n";
                }
                text += "\t}\r\n";
            }

            text += "}";

            var file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();
            return result;
        }
    }
}
