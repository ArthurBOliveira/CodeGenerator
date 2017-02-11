using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    class Generator
    {
        protected static string UppercaseFirst(string s)
        {
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        protected static string LowercaseFirst(string s)
        {
            // Return char and concat substring.
            return char.ToLower(s[0]) + s.Substring(1);
        }

        protected static string ConvertTypeToSQL(string s)
        {
            switch (s)
            {
                case "int":
                    return "INT";
                case "bool":
                    return "BIT";
                case "DateTime":
                    return "DATETIME";
                case "string":
                    return "VARCHAR(MAX)";
                case "float":
                    return "FLOAT";
                default:
                    return "";
            }
        }

        protected static string ConvertNameToSQL(string s)
        {
            string result = "";

            char[] letters = s.ToCharArray();

            for(int i = 0; i < letters.Length; i++)
            {
                if (Char.IsUpper(letters[i]))
                    result += "_" + char.ToLower(letters[i]);
                else
                    result += letters[i];
            }

            return result;
        }
    }
}
