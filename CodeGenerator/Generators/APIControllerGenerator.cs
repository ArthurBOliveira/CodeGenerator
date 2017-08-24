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
            text += "using System.Web.Http;\r\n";
            text += "using System.Web.Http.Description;\r\n";
            text += "using System.Web.Http.OData;\r\n";
            text += "using JobManager_Back.Models;\r\n";
            text += "using JobManager_Back.Services;\r\n\r\n";

            text += "namespace " + m.NameProject + ".Controllers\r\n";
            text += "{\r\n";

            //Documentation
            text += "\t///<summary>\r\n";
            text += "\t/// Controller for the " + m.Name + "\r\n";
            text += "\t///</summary>\r\n";

            text += "\t[RoutePrefix(\"api/" + m.Name + "\")]\r\n";
            text += "\tpublic class " + m.Name + "Controller : BaseController\r\n";
            text += "\t{\r\n";

            text += "\t\tprotected " + m.Name + "Service GetService()\r\n";
            text += "\t\t{\r\n";
            text += "\t\t\treturn new " + m.Name + "Service(GetRequestUserHostAddress(), GetRequestUserHostName());\r\n";
            text += "\t\t}\r\n\r\n";

            //Documentation
            text += "\t\t///<summary>\r\n";
            text += "\t\t/// LIST all " + m.Name + "s with the specifics Ids\r\n";
            text += "\t\t///</summary>\r\n";
            text += "\t\t///<param name=\"ids\">List of Ids</param>\r\n";
            text += "\t\t///<param name=\"all\">Include the inactive or not</param>\r\n";
            text += "\t\t///<returns>200 - List of " + m.Name + "</returns>\r\n";

            //List by Ids
            text += "\t\t[HttpPost, Route(\"Get" + m.Name + "ByIds\"), EnableQuery, ResponseType(typeof(IEnumerable<" + m.Name + ">))]\r\n";
            text += "\t\tpublic IHttpActionResult Get" + m.Name + "ByIds([FromBody]IEnumerable<Guid> ids, [FromODataUri]Boolean all = false)\r\n";
            text += "\t\t{\r\n";

            text += "\t\t\ttry { return Ok(GetService().GetByIds<" + m.Name + ">(ids, all)); }\r\n";
            text += "\t\t\tcatch (Exception ex) { return base.ThreatExceptions(ex); }\r\n";

            text += "\t\t}\r\n\r\n";


            //List by Guids
            foreach (Property p in m.Properties)
            {
                if (p.Type == "Guid" && p.Name != "id")
                {
                    //Documentation
                    text += "\t\t///<summary>\r\n";
                    text += "\t\t/// LIST all " + m.Name + "s connected with the specifics " + UppercaseFirst(p.Name) + "\r\n";
                    text += "\t\t///</summary>\r\n";
                    text += "\t\t///<param name=\"ids\">List of " + UppercaseFirst(p.Name) + " Ids</param>\r\n";
                    text += "\t\t///<param name=\"all\">Include the inactive or not</param>\r\n";
                    text += "\t\t///<returns>200 - List of " + m.Name + "</returns>\r\n";

                    text += "\t\t[HttpPost, Route(\"Get" + m.Name + "By" + UppercaseFirst(p.Name) + "\"), EnableQuery, ResponseType(typeof(IEnumerable<" + m.Name + ">))]\r\n";
                    text += "\t\tpublic IHttpActionResult Get" + m.Name + "By" + UppercaseFirst(p.Name) + "([FromBody]IEnumerable<Guid> ids, [FromODataUri]Boolean all = false)\r\n";
                    text += "\t\t{\r\n";

                    text += "\t\t\ttry { return Ok(GetService().GetByIds<" + m.Name + ">(ids, all, \"" + UppercaseFirst(p.Name) + "\")); }\r\n";
                    text += "\t\t\tcatch (Exception ex) { return base.ThreatExceptions(ex); }\r\n";

                    text += "\t\t}\r\n\r\n";
                }
            }


            //Documentation
            text += "\t\t///<summary>\r\n";
            text += "\t\t/// GET the historic of a specific " + m.Name + "\r\n";
            text += "\t\t///</summary>\r\n";
            text += "\t\t///<param name=\"id\">" + m.Name + " Id</param>\r\n";
            text += "\t\t///<param name=\"all\">Include the inactive or not</param>\r\n";
            text += "\t\t///<returns>200 - List of " + m.Name + " historic</returns>\r\n";

            //Hist
            text += "\t\t[HttpGet, Route(\"Get" + m.Name + "HistBy" + m.Name + "\"), EnableQuery(PageSize = 50), ResponseType(typeof(IEnumerable<" + m.Name + ">))]\r\n";
            text += "\t\tpublic IHttpActionResult Get" + m.Name + "HistBy" + m.Name + "([FromODataUri]Guid id)\r\n";
            text += "\t\t{\r\n";

            text += "\t\t\ttry { return Ok(GetService().GetByHist<" + m.Name + ">(id)); }\r\n";
            text += "\t\t\tcatch (Exception ex) { return base.ThreatExceptions(ex); }\r\n";

            text += "\t\t}\r\n\r\n";


            //Documentation
            text += "\t\t///<summary>\r\n";
            text += "\t\t///GET a specific " + m.Name + "\r\n";
            text += "\t\t///</summary>\r\n";
            text += "\t\t///<param name=\"id\">" + m.Name + " Id</param>\r\n";
            text += "\t\t///<returns>200 - List of " + m.Name + "</returns>\r\n";

            //Get
            text += "\t\t[HttpGet, EnableQuery, ResponseType(typeof(" + m.Name + "))]\r\n";
            text += "\t\tpublic IHttpActionResult Get([FromUri]Guid id)\r\n";
            text += "\t\t{\r\n";

            text += "\t\t\ttry { return Ok(GetService().Get<" + m.Name + ">(id)); }\r\n";
            text += "\t\t\tcatch (Exception ex) { return base.ThreatExceptions(ex); }\r\n";

            text += "\t\t}\r\n\r\n";


            //Documentation
            text += "\t\t///<summary>\r\n";
            text += "\t\t///GET all " + m.Name + "s on Database\r\n";
            text += "\t\t///</summary>\r\n";
            text += "\t\t///<param name=\"all\">Include the inactive or not</param>\r\n";
            text += "\t\t///<returns>200 - List of " + m.Name + "</returns>\r\n";

            //List
            text += "\t\t[HttpGet, EnableQuery, ResponseType(typeof(IEnumerable<" + m.Name + ">))]\r\n";
            text += "\t\tpublic IHttpActionResult Get([FromODataUri]Boolean all = false)\r\n";
            text += "\t\t{\r\n";

            text += "\t\t\ttry { return Ok(GetService().Get<" + m.Name + ">(all)); }\r\n";
            text += "\t\t\tcatch (Exception ex) { return base.ThreatExceptions(ex); }\r\n";

            text += "\t\t}\r\n\r\n";


            //Documentation
            text += "\t\t///<summary>\r\n";
            text += "\t\t///POST a " + m.Name + "\r\n";
            text += "\t\t///</summary>\r\n";
            text += "\t\t///<param name=\"value\">" + m.Name + " to Post</param>\r\n";
            text += "\t\t///<returns>200 - " + m.Name + "</returns>\r\n";

            //Post
            text += "\t\tpublic IHttpActionResult Post([FromBody]" + m.Name + " value)\r\n";
            text += "\t\t{\r\n";

            text += "\t\t\tif (!ModelState.IsValid)\r\n";
            text += "\t\t\t\treturn BadRequest(ModelState);\r\n\r\n";

            text += "\t\t\ttry { return Created(\"Database\", GetService().Post(value)); }\r\n";
            text += "\t\t\tcatch (Exception ex) { return base.ThreatExceptions(ex); }\r\n";

            text += "\t\t}\r\n\r\n";


            //Documentation
            text += "\t\t///<summary>\r\n";
            text += "\t\t///PUT a " + m.Name + "\r\n";
            text += "\t\t///</summary>\r\n";
            text += "\t\t///<param name=\"value\">" + m.Name + " to Update</param>\r\n";
            text += "\t\t///<returns>200 - " + m.Name + "</returns>\r\n";

            if (!m.IsRelation)
            {
                //Put
                text += "\t\tpublic IHttpActionResult Put([FromBody]" + m.Name + " value)\r\n";
                text += "\t\t{\r\n";

                text += "\t\t\tif (!ModelState.IsValid)\r\n";
                text += "\t\t\t\treturn BadRequest(ModelState);\r\n\r\n";

                text += "\t\t\ttry { return Ok(GetService().Put<" + m.Name + ">(value, new List<String>() { \"" + m.Properties[1].Name + "\", \"" + m.Properties[2].Name + "\" })); }\r\n";
                text += "\t\t\tcatch (Exception ex) { return base.ThreatExceptions(ex); }\r\n";

                text += "\t\t}\r\n\r\n";
            }
            else
            {
                //Put
                text += "\t\tpublic IHttpActionResult Put([FromBody]" + m.Name + " value)\r\n";
                text += "\t\t{\r\n";

                text += "\t\t\tif (!ModelState.IsValid)\r\n";
                text += "\t\t\t\treturn BadRequest(ModelState);\r\n\r\n";

                text += "\t\t\ttry { return Ok(GetService().Put<" + m.Name + ">(value)); }\r\n";
                text += "\t\t\tcatch (Exception ex) { return base.ThreatExceptions(ex); }\r\n";

                text += "\t\t}\r\n\r\n";
            }


            if (!m.IsRelation)
            {
                //Documentation
                text += "\t\t///<summary>\r\n";
                text += "\t\t///Delete a " + m.Name + ". A " + m.Name + " is always soft deleted\r\n";
                text += "\t\t///</summary>\r\n";
                text += "\t\t///<param name=\"id\">" + m.Name + " to Delete</param>\r\n";
                text += "\t\t///<returns>200</returns>\r\n";

                //Delete
                text += "\t\tpublic IHttpActionResult Delete([FromUri]Guid id)\r\n";
                text += "\t\t{\r\n";

                text += "\t\t\ttry { return Ok(GetService().Delete<" + m.Name + ">(id)); }\r\n";
                text += "\t\t\tcatch (Exception ex) { return base.ThreatExceptions(ex); }\r\n";

                text += "\t\t}\r\n";
            }
            else
            {
                //Documentation
                text += "\t\t///<summary>\r\n";
                text += "\t\t///Delete a " + m.Name + "\r\n";
                text += "\t\t///</summary>\r\n";
                text += "\t\t///<param name=\"id\">" + m.Name + " to Delete</param>\r\n";
                text += "\t\t///<returns>200</returns>\r\n";

                //Delete
                text += "\t\tpublic IHttpActionResult Delete([FromUri]Guid id)\r\n";
                text += "\t\t{\r\n";

                text += "\t\t\ttry { return Ok(GetService().Drop<" + m.Name + ">(id)); }\r\n";
                text += "\t\t\tcatch (Exception ex) { return base.ThreatExceptions(ex); }\r\n";

                text += "\t\t}\r\n";
            }

            text += "\t}";
            text += "}";

            StreamWriter file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }

        public static bool Generate()
        {
            bool result = false;
            string fileName = "BaseController.cs";
            string text = "using System; using System.Collections.Generic; using System.Linq; using System.Net; using System.Net.Http; using System.Web.Http; using System.Security.Principal; using System.Web; namespace Teste.Controllers { public abstract class BaseController<T> : ApiController { private Repositories.BaseRepository<T> rep; public BaseController(Repositories.BaseRepository<T> _rep, HttpRequestBase request, IIdentity userIdentity) { this.rep = _rep; this.requestService = request; this.userIdentityService = userIdentity; } #region MetaData (Control) private HttpRequestBase requestService; private IIdentity userIdentityService; protected String GetRequestUserHostAddress() { return requestService.UserHostAddress; } protected Boolean GetRequestUserHostAddress(string userHostAddress) { return requestService.UserHostAddress.Equals(userHostAddress); } protected String GetRequestUserHostName() { return userIdentityService.Name; } protected Boolean GetRequestUserHostName(string userHostName) { return userIdentityService.Name.Equals(userHostName); } #endregion public virtual IEnumerable<T> GetData(Boolean all = true) { return rep.GetData<T>(all); } public virtual T GetData(Guid id) { return rep.GetData<T>(id); } public virtual T PostData(T obj) { rep.PostData<T>(obj); return obj; } public virtual T PutData(T obj) { rep.PutData<T>(obj); return obj; } public virtual T DeleteData(Guid id) { rep.DeleteData<T>(id); return GetData(id); } public virtual bool ExistsData(Guid id) { return rep.ExistsData<T>(id); } public void Dispose() { this.rep.Dispose(); } } }";

            StreamWriter file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }
    }
}