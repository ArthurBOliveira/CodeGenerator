using System.IO;

namespace CodeGenerator
{
    class StoreTsGeneratorcs : Generator
    {
        public static bool Generate(Model m)
        {
            if (!GenerateActions(m)) return false;
            if (!GenerateReducer(m)) return false;
            if (!GenerateEffects(m)) return false;
            if (!GenerateSelector(m)) return false;

            return true;
        }

        private static bool GenerateActions(Model m)
        {
            bool result = false;
            string fileName = LowercaseFirst(m.Name) + ".actions.ts";

            string text = "";

            text += "import { Action } from '@ngrx/store';\r\n";
            text += "import { Update } from '@ngrx/entity';\r\n";
            text += "import { " + m.Name + " } from '../../shared/" + m.Name + "';\r\n\r\n";

            text += "export enum " + m.Name + "ActionTypes\r\n";
            text += "{\r\n";
            text += "\tLoad" + m.Name + "s = '[" + m.Name + "] Load " + m.Name + "s',\r\n";
            text += "\tAdd" + m.Name + " = '[" + m.Name + "] Add " + m.Name + "',\r\n";
            text += "\tUpsert" + m.Name + " = '[" + m.Name + "] Upsert " + m.Name + "',\r\n";
            text += "\tAdd" + m.Name + "s = '[" + m.Name + "] Add " + m.Name + "s',\r\n";
            text += "\tUpsert" + m.Name + "s = '[" + m.Name + "] Upsert " + m.Name + "s',\r\n";
            text += "\tUpdate" + m.Name + " = '[" + m.Name + "] Update " + m.Name + "',\r\n";
            text += "\tUpdate" + m.Name + "s = '[" + m.Name + "] Update " + m.Name + "s',\r\n";
            text += "\tDelete" + m.Name + " = '[" + m.Name + "] Delete " + m.Name + "',\r\n";
            text += "\tDelete" + m.Name + "s = '[" + m.Name + "] Delete " + m.Name + "s',\r\n";
            text += "\tClear" + m.Name + "s = '[" + m.Name + "] Clear " + m.Name + "s',\r\n";
            text += "}\r\n\r\n";

            text += "export class Load" + m.Name + "s implements Action {\r\n";
            text += "\treadonly type = " + m.Name + "ActionTypes.Load" + m.Name + "s;\r\n\r\n";
            text += "\tconstructor(public payload: { " + m.Name + "s: " + m.Name + "[] }) {}\r\n";
            text += "}\r\n";

            text += "export class Add" + m.Name + " implements Action {\r\n";
            text += "\treadonly type = " + m.Name + "ActionTypes.Add" + m.Name + ";\r\n\r\n";
            text += "\tconstructor(public payload: { " + m.Name + ": " + m.Name + " }) {}\r\n";
            text += "}\r\n\r\n";

            text += "export class Upsert" + m.Name + " implements Action {\r\n";
            text += "\treadonly type = " + m.Name + "ActionTypes.Upsert" + m.Name + ";\r\n\r\n";
            text += "\tconstructor(public payload: { " + m.Name + ": " + m.Name + " }) {}\r\n";
            text += "}\r\n";

            text += "export class Add" + m.Name + "s implements Action {\r\n";
            text += "\treadonly type = " + m.Name + "ActionTypes.Add" + m.Name + "s;\r\n\r\n";
            text += "\tconstructor(public payload: { " + m.Name + "s: " + m.Name + "[] }) {}\r\n";
            text += "}\r\n\r\n";

            text += "export class Upsert" + m.Name + "s implements Action {\r\n";
            text += "\treadonly type = " + m.Name + "ActionTypes.Upsert" + m.Name + "s;\r\n\r\n";
            text += "\tconstructor(public payload: { " + m.Name + "s: " + m.Name + "[] }) {}\r\n";
            text += "}\r\n\r\n";

            text += "export class Update" + m.Name + " implements Action {\r\n";
            text += "\treadonly type = " + m.Name + "ActionTypes.Update" + m.Name + ";\r\n\r\n";
            text += "\tconstructor(public payload: { " + m.Name + ": Update<" + m.Name + "> }) {}\r\n";
            text += "}\r\n\r\n";

            text += "export class Update" + m.Name + "s implements Action {\r\n";
            text += "\treadonly type = " + m.Name + "ActionTypes.Update" + m.Name + "s;\r\n\r\n";
            text += "\tconstructor(public payload: { " + m.Name + "s: Update<" + m.Name + ">[] }) {}\r\n";
            text += "}\r\n\r\n";

            text += "export class Delete" + m.Name + " implements Action {\r\n";
            text += "\treadonly type = " + m.Name + "ActionTypes.Delete" + m.Name + ";\r\n\r\n";
            text += "\tconstructor(public payload: { id: string }) {}\r\n";
            text += "}\r\n\r\n";

            text += "export class Delete" + m.Name + "s implements Action {\r\n";
            text += "\treadonly type = " + m.Name + "ActionTypes.Delete" + m.Name + "s;\r\n\r\n";
            text += "\tconstructor(public payload: { ids: string[] }) {}\r\n";
            text += "}\r\n\r\n";

            text += "export class Clear" + m.Name + "s implements Action {\r\n";
            text += "\treadonly type = " + m.Name + "ActionTypes.Clear" + m.Name + "s;\r\n";
            text += "}\r\n\r\n";

            text += "export type " + m.Name + "Actions =\r\n";
            text += "Load" + m.Name + "s\r\n";
            text += "| Add" + m.Name + "\r\n";
            text += "| Upsert" + m.Name + "\r\n";
            text += "| Add" + m.Name + "s\r\n";
            text += "| Upsert" + m.Name + "s\r\n";
            text += "| Update" + m.Name + "\r\n";
            text += "| Update" + m.Name + "s\r\n";
            text += "| Delete" + m.Name + "\r\n";
            text += "| Delete" + m.Name + "s\r\n";
            text += "| Clear" + m.Name + "s\r\n";

            var file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();
            return result;
        }

        private static bool GenerateReducer(Model m)
        {
            bool result = false;
            string fileName = LowercaseFirst(m.Name) + ".reducer.ts";

            string text = "";

            var file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();
            return result;
        }

        private static bool GenerateEffects(Model m)
        {
            bool result = false;
            string fileName = LowercaseFirst(m.Name) + ".effects.ts";

            string text = "";

            var file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();
            return result;
        }

        private static bool GenerateSelector(Model m)
        {
            bool result = false;
            string fileName = LowercaseFirst(m.Name) + ".selector.ts";

            string text = "";

            var file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();
            return result;
        }
    }
}
