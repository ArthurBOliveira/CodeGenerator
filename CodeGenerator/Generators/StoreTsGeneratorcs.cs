using System;
using System.IO;

namespace CodeGenerator
{
    class StoreTsGeneratorcs : Generator
    {
        public static bool Generate(Model m, string path)
        {
            if (!GenerateActions(m, path)) return false;
            if (!GenerateReducer(m, path)) return false;
            if (!GenerateEffects(m, path)) return false;
            if (!GenerateSelector(m, path)) return false;

            return true;
        }

        private static bool GenerateActions(Model m, string path)
        {
            return GenericStoreSliceGenerator(m, path, "actions");
        }

        private static bool GenerateReducer(Model m, string path)
        {
            return GenericStoreSliceGenerator(m, path, "reducer");
        }

        private static bool GenerateEffects(Model m, string path)
        {
            return GenericStoreSliceGenerator(m, path, "effects");
        }

        private static bool GenerateSelector(Model m, string path)
        {
            return GenericStoreSliceGenerator(m, path, "selector");
        }

        private static bool GenericStoreSliceGenerator(Model m, string path, string slice)
        {
            bool result = true;
            try
            {
                string fileName = path + LowercaseFirst(m.Name) + "." + slice + ".ts";
                string modelClassFile = LowercaseFirst(m.Name);

                string text = "";

                text = GetBaseFile("Generators\\NGRXBaseFiles\\x." + slice + ".ts");

                if (m.Name.EndsWith("Hist"))
                {
                    modelClassFile = modelClassFile.Replace("Hist", ""); // remove Hist from filename as Hist class and interface lies in the same file as the entity class

                    if (slice == "reducer")
                    {
                        // If you are creating a reducer for a history class, it need to have the ID field
                        // (which is default in NGRX to property 'id')
                        // to idHist as 'id' will always point to the original object
                        text = GetBaseFile("Generators\\NGRXBaseFiles\\x." + slice + ".hist.ts");
                    }
                }

                text = text.Replace("modelClassFile", modelClassFile);
                text = text.Replace("modelClass", LowercaseFirst(m.Name));
                text = text.Replace("ModelClass", UppercaseFirst(m.Name));

                var file = File.AppendText(fileName);

                file.WriteLine(text);

                file.Close();
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }
    }
}
