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
                case "Guid":
                    return "UNIQUEIDENTIFIER";
                case "Int":
                    return "INT";
                case "Bool":
                    return "BIT";
                case "Boolean":
                    return "BIT";
                case "DateTime":
                    return "DATETIME";
                case "String":
                    return "NVARCHAR(MAX)";
                case "Float":
                    return "DECIMAL(20,6)";
                case "Double":
                    return "DECIMAL(20,6)";
                case "Decimal":
                    return "DECIMAL(18,2)";
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
