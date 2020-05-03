using System.IO;

namespace CodeGenerator.Generators.JoMDM
{
    class JoMDMControllerGenerator : Generator
    {
        public static bool Generate(Model m, string path)
        {
            if (m.Name.Contains("Hist") || m.Name == "BaseModel")
                return false;

            bool result = false;
            string fileName = m.Name + "Controller.cs";
            string text = "using JobManager_Back.Models; using JobManager_Back.Services; using System; using System.Web.Mvc; namespace JoMDM.Controllers { public class ModelClassController : Controller { private ModelClassService ModelClassService; public ModelClassController() { ModelClassService = new ModelClassService(\"JoMDM\", Guid.NewGuid()); } public ActionResult Index() { var list = ModelClassService.Get<ModelClass>(); return View(list); } [HttpPost] public JsonResult InsertModelClass(ModelClass ps) { try { ps = ModelClassService.Post(ps); return Json(ps); } catch (Exception ex) { return Json(ex); } } [HttpPost] public ActionResult DeleteModelClass(ModelClass ps) { try { ModelClassService.Delete<ModelClass>(ps.id); return Json(\"\"); } catch (Exception ex) { return Json(ex); } } } }";

            text = text.Replace("ModelClass", m.Name);

            StreamWriter file = File.AppendText(path + fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }
    }
}
