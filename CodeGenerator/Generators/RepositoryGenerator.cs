using System.IO;

namespace CodeGenerator
{
    class RepositoryGenerator : Generator
    {
        public static bool Generate(Model m)
        {
            bool result = false;
            string fileName = m.Name + "Repository.cs";
            string text = "";

            text += "using System;\r\n";
            text += "using Back.Repositories;\r\n";
            text += "using JobManager_Back.Models;\r\n\r\n";

            text += "namespace " + m.NameProject + "_Back.Repositories\r\n";
            text += "{\r\n";

            text += "\tpublic class " + m.Name + "Repository : BaseRepository<" + m.Name + ">\r\n";
            text += "\t{\r\n";

            text += "\t\tpublic " + m.Name + "Repository(string tablePrefix = \"jm.\") : base(tablePrefix)\r\n";
            text += "\t\t{ }\r\n";

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
            string fileName = "BaseRepository.cs";
            string text = "";

            text += "using Dapper; using System; using System.Collections.Generic; using System.Configuration; using System.Data.SqlClient; using System.Linq; namespace " + Program.project.Name + ".Repositories { public abstract class BaseRepository<T> : IDisposable { public string tablePrefix; public BaseRepository(string tablePrefix = \"\") { this.tablePrefix = tablePrefix; } protected IEnumerable<string> GetProperties(Type t) { return t.GetProperties().Select(x => x.Name); } protected String GetTableName(Type t) { return tablePrefix + t.Name; } public virtual IEnumerable<T> GetData<T>(Boolean all = true) { IEnumerable<T> result = new List<T>(); using (var conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings[\"SignatureContext\"].ConnectionString)) { IEnumerable<string> properties = GetProperties(typeof(T)); result = conexaoBD.Query<T>(\"select \" + string.Join(\",\", properties) + \" from \" + GetTableName(typeof(T)) + (all ? \"\" : \" where control_active = 1\")); } return result; } public virtual T GetData<T>(Guid Id) { T result; using (var conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings[\"SignatureContext\"].ConnectionString)) { IEnumerable<string> properties = GetProperties(typeof(T)); result = conexaoBD.Query<T>(\"select \" + string.Join(\",\", properties) + \" from \" + GetTableName(typeof(T)) + \" where Id = @Id\", new { Id = Id.ToString() }).SingleOrDefault(); } return result; } public virtual bool ExistsData<T>(Guid Id) { int result; using (var conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings[\"SignatureContext\"].ConnectionString)) { IEnumerable<string> properties = GetProperties(typeof(T)); result = conexaoBD.ExecuteScalar<int>(\"select 1 from \" + GetTableName(typeof(T)) + \" where Id = @Id\", new { Id = Id.ToString() }); } return result.Equals(1); } public virtual void PostData<T>(T obj) { using (var conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings[\"SignatureContext\"].ConnectionString)) { IEnumerable<string> properties = GetProperties(typeof(T)); conexaoBD.Execute(\"insert into \" + GetTableName(typeof(T)) + \" (\" + string.Join(\",\", properties) + \") values (\" + string.Join(\",\", properties.Select(x => string.Format(\"@{0}\", x))) + \")\", obj); } } public virtual void PutData<T>(T obj) { using (var conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings[\"SignatureContext\"].ConnectionString)) { IEnumerable<string> properties = GetProperties(typeof(T)); conexaoBD.Execute(\"update \" + GetTableName(typeof(T)) + \" set \" + string.Join(\",\", properties.Select(x => string.Format(\"{0} = @{1}\", x, x))) + \" where Id = @Id\", obj); } } public virtual void DeleteData<T>(Guid Id) { using (var conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings[\"SignatureContext\"].ConnectionString)) { IEnumerable<string> properties = GetProperties(typeof(T)); conexaoBD.Execute(\"delete \" + GetTableName(typeof(T)) + \" where Id = @Id\", new { Id = Id.ToString() }); } } public void Dispose() { //this.Dispose(); } } }";

            StreamWriter file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }
    }
}
