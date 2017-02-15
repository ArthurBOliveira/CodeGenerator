using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    class ServiceGenerator : Generator
    {
        public static bool Generate(Model m)
        {
            bool result = false;
            string fileName = m.Name + "Services.cs";
            string text = "";

            text += "using System;\r\n";
            text += "using System.Collections.Generic;\r\n";
            text += "using System.Security.Principal;\r\n";
            text += "using System.Web;\r\n";
            text += "using System.Web.Mvc;\r\n";

            text += "namespace " + m.NameProject + "Services\r\n";
            text += "{\r\n";

            text += "\tpublic class " + m.Name + "Services : BaseServices<Models." + m.Name + ">\r\n";
            text += "\t{\r\n";      



            text += "\t}\r\n";
            text += "}";

            StreamWriter file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }

        public static bool Generate()
        {
            bool result = false;
            string fileName = "BaseServices.cs";

            string text = @"using System; using System.Collections.Generic; using System.Security.Principal; using System.Web; namespace " + Program.project.Name + ".Services { public abstract class BaseServices<T> : IDisposable { private Repositories.BaseRepository<T> rep; public BaseServices(Repositories.BaseRepository<T> _rep, HttpRequestBase request, IIdentity userIdentity) { this.rep = _rep; this.requestService = request; this.userIdentityService = userIdentity; } #region MetaData (Control) private HttpRequestBase requestService; private IIdentity userIdentityService; protected String GetRequestUserHostAddress() { return requestService.UserHostAddress; } protected Boolean GetRequestUserHostAddress(string userHostAddress) { return requestService.UserHostAddress.Equals(userHostAddress); } protected String GetRequestUserHostName() { return userIdentityService.Name; } protected Boolean GetRequestUserHostName(string userHostName) { return userIdentityService.Name.Equals(userHostName); } #endregion public virtual IEnumerable<T> GetData(Boolean all = true) { return rep.GetData<T>(all); } public virtual T GetData(Guid id) { return rep.GetData<T>(id); } public virtual T PostData(T obj) { rep.PostData<T>(obj); return obj; } public virtual T PutData(T obj) { rep.PutData<T>(obj); return obj; } public virtual T DeleteData(Guid id) { rep.DeleteData<T>(id); return GetData(id); } public virtual bool ExistsData(Guid id) { return rep.ExistsData<T>(id); } public void Dispose() { this.rep.Dispose(); } } }";

            StreamWriter file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }
    }
}
