using System.IO;

namespace CodeGenerator.Generators.JoMDM
{
    class JoMDMViewGenerator : Generator
    {
        public static bool Generate(Model m, string path)
        {
            if (m.Name.Contains("Hist") || m.Name == "BaseModel")
                return false;

            bool result = false;
            string fileName = m.Name + ".cshtml";
            string text = "";

            text += "@model IEnumerable<JobManager_Back.Models.ModelClass> <div> <h3 id=\"ControllerModelClass\" href=\"#ModelClass\" style=\"cursor: pointer;\" data-toggle=\"collapse\" class=\"collapsed\" aria-expanded=\"false\"> ModelClass </h3> <div id=\"ModelClass\" class=\"collapse\" aria-expanded=\"false\" style=\"height: 0px;\"> <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"> <tr> <td style=\"width: 150px\"> Name<br /> <input type=\"text\" id=\"txtName\" style=\"width:140px\" /> </td> <td style=\"width: 150px\"> Color<br /> <input type=\"text\" id=\"txtColor\" style=\"width:140px\" /> </td> <td style=\"width: 200px\"> <br /> <input type=\"button\" id=\"btnModelClassAdd\" value=\"Add\" /> </td> </tr> </table> <table id=\"tblModelClass\" class=\"table\" cellpadding=\"0\" cellspacing=\"0\"> <tr> <th> @Html.DisplayNameFor(model => model.name) </th> <th> @Html.DisplayNameFor(model => model.color) </th> <th></th> </tr> @foreach (var item in Model) { <tr> <td hidden=\"hidden\" class=\"ModelClassId\"> <span>@item.id</span> </td> <td class=\"Name\"> <span>@item.name</span> <input type=\"text\" value=\"@item.name\" style=\"display:none\" /> </td> <td class=\"Color\"> <span>@item.color</span> <input type=\"text\" value=\"@item.color\" style=\"display:none\" /> </td> <td> @*<a class=\"Edit\" href=\"javascript:;\">Edit</a>*@ <a class=\"Update\" href=\"javascript:;\" style=\"display:none\">Update</a> <a class=\"Cancel\" href=\"javascript:;\" style=\"display:none\">Cancel</a> <a class=\"Delete\" href=\"javascript:;\">Delete</a> </td> </tr> } </table> </div> </div> <script type=\"text/javascript\" src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js\"></script> <script type=\"text/javascript\" src=\"https://ajax.cdnjs.com/ajax/libs/json2/20110223/json2.js\"></script> <script type=\"text/javascript\"> $(function () { //Remove the dummy row if data present. if ($(\"#tblModelClass tr\").length > 2) { $(\"#tblModelClass tr:eq(1)\").remove(); } else { var row = $(\"#tblModelClass tr:last-child\"); row.find(\".Edit\").hide(); row.find(\".Delete\").hide(); row.find(\"span\").html('&nbsp;'); } }); function AppendRow(row, id, name, color) { $(\".ModelClassId\", row).find(\"span\").html(id); $(\".Name\", row).find(\"span\").html(name); $(\".Name\", row).find(\"input\").val(name); $(\".Color\", row).find(\"span\").html(color); $(\".Color\", row).find(\"input\").val(color); row.find(\".Delete\").show(); $(\"#tblModelClass\").append(row); }; //Add event handler. $(\"body\").on(\"click\", \"#btnModelClassAdd\", function () { var txtName = $(\"#txtName\"); var txtColor = $(\"#txtColor\"); $.ajax({ type: \"POST\", url: \"/ModelClass/InsertModelClass\", data: '{name: \"' + txtName.val() + '\", color: \"' + txtColor.val() + '\" }', contentType: \"application/json; charset=utf-8\", dataType: \"json\", success: function (r) { console.log(r); var row = $(\"#tblModelClass tr:last-child\"); if ($(\"#tblModelClass tr:last-child span\").eq(0).html() != \"&nbsp;\") { row = row.clone(); } AppendRow(row, r.id, r.name, r.color); txtName.val(\"\"); txtColor.val(\"\"); } }); }); //Delete event handler. $(\"body\").on(\"click\", \"#tblModelClass .Delete\", function () { if (confirm(\"Do you want to delete this row?\")) { var row = $(this).closest(\"tr\"); var item = {}; item.Id = row.find(\".ModelClassId\").find(\"span\").html(); $.ajax({ type: \"POST\", url: \"/ModelClass/DeleteModelClass\", data: '{ps: ' + JSON.stringify(item) + '}', contentType: \"application/json; charset=utf-8\", dataType: \"json\", success: function (response) { if ($(\"#tblModelClass tr\").length > 2) { row.remove(); } else { row.find(\".Edit\").hide(); row.find(\".Delete\").hide(); row.find(\"span\").html('&nbsp;'); } } }); } }); </script>";

            text = text.Replace("ModelClass", m.Name);

            StreamWriter file = File.AppendText(path + fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }
    }
}
