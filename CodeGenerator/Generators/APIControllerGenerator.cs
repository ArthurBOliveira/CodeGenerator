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
            text += "using System.Web;\r\n";
            text += "using System.Net.Http;\r\n";
            text += "using System.Web.Http;\r\n";
            text += "using " + m.NameProject + ".Models;\r\n";
            text += "using " + m.NameProject + ".Repositories;\r\n\r\n";

            text += "namespace " + m.NameProject + ".Controllers\r\n";
            text += "{\r\n";

            text += "\t[RoutePrefix(\"api/" + m.Name + "\")]\r\n";
            text += "\tpublic class " + m.Name + "Controller : BaseController\r\n";
            text += "\t{\r\n";

            text += "\t\tprivate " + m.Name + "Repository _" + m.Name + "Repository;\r\n";

            //Constructor
            text += "\t\tpublic " + m.Name + "Controller()\r\n";
            text += "\t\t{\r\n";
            text += "\t\t\t_" + m.Name + "Repository = new " + m.Name + "Repository();\r\n";
            text += "\t\t}\r\n\r\n";

            //Get
            text += "\t\tpublic IHttpActionResult Get([FromUri]Guid id)\r\n";
            text += "\t\t{\r\n";

            text += "\t\t\t" + m.Name + " result = _" + m.Name + "Repository.GetData<" + m.Name + ">(id);\r\n\r\n";

            text += "\t\t\tif (result != null)\r\n";
            text += "\t\t\t\treturn Ok(result);\r\n";
            text += "\t\t\telse\r\n";
            text += "\t\t\t\treturn NotFound();\r\n";

            text += "\t\t}\r\n\r\n";

            //List
            text += "\t\tpublic IHttpActionResult Get([FromUri]bool value)\r\n";
            text += "\t\t{\r\n";

            text += "\t\t\tIEnumerable<" + m.Name + "> result = _" + m.Name + "Repository.GetData<" + m.Name + ">(value);\r\n\r\n";

            text += "\t\t\tif (result == null)\r\n";
            text += "\t\t\t\treturn BadRequest();\r\n";
            text += "\t\t\tif (result.Count() != 0)\r\n";
            text += "\t\t\t\treturn Ok(result);\r\n";
            text += "\t\t\telse\r\n";
            text += "\t\t\t\treturn NotFound();\r\n";

            text += "\t\t}\r\n\r\n";

            //Post
            text += "\t\tpublic IHttpActionResult Post([FromBody]" + m.Name + " value)\r\n";
            text += "\t\t{\r\n";

            text += "\t\t\tif (!ModelState.IsValid)\r\n";
            text += "\t\t\t\treturn BadRequest(ModelState);\r\n";

            text += "\t\t\tif (_" + m.Name + "Repository.ExistsData<" + m.Name + ">(value.Id))\r\n";
            text += "\t\t\t\treturn Conflict();\r\n";

            text += "\t\t\ttry\r\n";
            text += "\t\t\t{\r\n";
            text += "\t\t\tvalue.Id = Guid.NewGuid();\r\n";
            text += "\t\t\t\tif(_" + m.Name + "Repository.PostData<" + m.Name + ">(value))\r\n";
            text += "\t\t\t\t{\r\n";
            text += "\t\t\t\t\treturn Ok();\r\n";
            text += "\t\t\t\t}\r\n";
            text += "\t\t\t\telse\r\n";
            text += "\t\t\t\t\treturn BadRequest(\"No Rows Affected!!\");\r\n";
            text += "\t\t\t}\r\n";
            text += "\t\t\tcatch (Exception ex)\r\n";
            text += "\t\t\t{\r\n";
            text += "\t\t\t\treturn BadRequest(ex.Message);\r\n";
            text += "\t\t\t}\r\n";

            text += "\t\t}\r\n\r\n";

            //Put
            text += "\t\tpublic IHttpActionResult Put([FromBody]" + m.Name + " value)\r\n";
            text += "\t\t{\r\n";

            text += "\t\t\tif (!ModelState.IsValid)\r\n";
            text += "\t\t\t\treturn BadRequest(ModelState);\r\n\r\n";

            text += "\t\t\t" + m.Name + " result = _" + m.Name + "Repository.GetData<" + m.Name + ">(value.Id);\r\n\r\n";

            text += "\t\t\tif (result == null)\r\n";
            text += "\t\t\t\treturn NotFound();\r\n";
            text += "\t\t\tif (value.RowVersion(result))\r\n";
            text += "\t\t\t\treturn BadRequest(\"RowVersion!\");\r\n";

            text += "\t\t\ttry\r\n";
            text += "\t\t\t{\r\n";
            text += "\t\t\t\tif(_" + m.Name + "Repository.PutData<" + m.Name + ">(value))\r\n";
            text += "\t\t\t\t{\r\n";
            text += "\t\t\t\t\treturn Ok();\r\n";
            text += "\t\t\t\t}\r\n";
            text += "\t\t\t\telse\r\n";
            text += "\t\t\t\t\treturn BadRequest(\"No Rows Affected!\");\r\n";
            text += "\t\t\t}\r\n";
            text += "\t\t\tcatch (Exception ex)\r\n";
            text += "\t\t\t{\r\n";
            text += "\t\t\t\treturn BadRequest(ex.Message);\r\n";
            text += "\t\t\t}\r\n";

            text += "\t\t}\r\n\r\n";

            //Delete
            text += "\t\tpublic IHttpActionResult Delete([FromUri]Guid id)\r\n";
            text += "\t\t{\r\n";

            text += "\t\t\tif (!_" + m.Name + "Repository.ExistsData<" + m.Name + ">(id))\r\n";
            text += "\t\t\t\treturn NotFound();\r\n";

            text += "\t\t\ttry\r\n";
            text += "\t\t\t{\r\n";
            text += "\t\t\t\tif(_" + m.Name + "Repository.DeleteData<" + m.Name + ">(id))\r\n";
            text += "\t\t\t\t{\r\n";
            text += "\t\t\t\t\treturn Ok();\r\n";
            text += "\t\t\t\t}\r\n";
            text += "\t\t\t\telse\r\n";
            text += "\t\t\t\t\treturn BadRequest(\"No Rows Affected!\");\r\n";
            text += "\t\t\t}\r\n";
            text += "\t\t\tcatch (Exception ex)\r\n";
            text += "\t\t\t{\r\n";
            text += "\t\t\t\treturn BadRequest(ex.Message);\r\n";
            text += "\t\t\t}\r\n";

            text += "\t\t}\r\n\r\n";

            //Get Hist
            text += "\t\t[Route(\"GetHist\")]\r\n";
            text += "\t\tpublic IHttpActionResult GetHist([FromUri]Guid id)\r\n";
            text += "\t\t{\r\n";

            text += "\t\t\t" + m.Name + " result = _" + m.Name + "Repository.GetHist<" + m.Name + ">(id);\r\n\r\n";

            text += "\t\t\tif (result != null)\r\n";
            text += "\t\t\t\treturn Ok(result);\r\n";
            text += "\t\t\telse\r\n";
            text += "\t\t\t\treturn NotFound();\r\n";

            text += "\t\t}\r\n";

            //Post Hist
            /*text += "\t\t[NonAction]\r\n";
            text += "\t\tprivate bool PostHist(" + m.Name + "Hist value)\r\n";
            text += "\t\t{\r\n";

            text += "\t\t\t" + m.Name + "Hist hist = new " + m.Name + "Hist();\r\n";

            text += "\t\t\thist.ToHist(value);\r\n";

            text += "\t\t\treturn _" + m.Name + "HistRepository.PostData<" + m.Name + "Hist>(value);\r\n";
            text += "\t\t}\r\n";*/

            text += "\t}\r\n";
            text += "}\r\n";
            
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