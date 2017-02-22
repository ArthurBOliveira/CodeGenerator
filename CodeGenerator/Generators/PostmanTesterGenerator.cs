using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    class PostmanTesterGenerator : Generator
    {
        public static bool Generate(Model m)
        {
            bool result = false;
            string fileName = "JobManager.postman_collection.json";
            string text = "";

            text += "{ \"variables\": [], \"info\": { \"name\": \"JobManager\", \"_postman_id\": \"cc292aa3 - b9e0 - eab1 - 545e-40ed2347a408\", \"description\": \"\", \"schema\": \"https://schema.getpostman.com/json/collection/v2.0.0/collection.json\" }, \"item\": [";

            //Get List
            text += "{";
            
            text += "\"name\": \"Get " + m.Name + " List\",";
            text += "\"event\": [";
            text += "{";
            text += "\"listen\": \"test\",";
            text += "\"script\": {";
            text += "\"type\": \"text/javascript\",";
            text += "\"exec\": [";
            text += "\"tests[\\\"Status code is 200\\\"] = responseCode.code === 200;\"";
            text += "]";
            text += "}";
            text += "}";
            text += "],";
            text += "\"request\": {";
            text += "\"url\": \"https://localhost:44313/api/BankAccount?value=true\",";
            text += "\"method\": \"GET\",";
            text += "\"header\": [";

            text += "{";
            text += "\"key\": \"Authorization\",";
            text += "\"value\": \"Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6Il9VZ3FYR190TUxkdVNKMVQ4Y2FIeFU3Y090YyIsImtpZCI6Il9VZ3FYR190TUxkdVNKMVQ4Y2FIeFU3Y090YyJ9.eyJhdWQiOiI1ZTE2Yzg4My1kOWUxLTQxYWYtOGE4NC00YTZhYTI1YTMxY2IiLCJpc3MiOiJodHRwczovL3N0cy53aW5kb3dzLm5ldC8yYmIzMWE3Yi0yM2Q0LTQ4M2MtYjExNC01N2NhZWU5NTAxZjMvIiwiaWF0IjoxNDg3Njk5MDgzLCJuYmYiOjE0ODc2OTkwODMsImV4cCI6MTQ4NzcwMjk4MywiYW1yIjpbInB3ZCJdLCJmYW1pbHlfbmFtZSI6Ik9saXZlaXJhIiwiZ2l2ZW5fbmFtZSI6IkFydGh1ciIsImlwYWRkciI6IjE4OS4xMjUuMzguMTIyIiwibmFtZSI6IkFydGh1ciBCYXB0aXN0YSBNb3JhZXMgQXJydWRhIGRlIE9saXZlaXJhIiwibm9uY2UiOiJiNWU1NTYwMy03Zjk5LTQ4YWMtYjVkNS1iZTVhMGYyMDUyNWQiLCJvaWQiOiJlNDE4MTAzMy0yODA2LTRkNTgtYTU2OC03YTUwY2VjODc4YTYiLCJvbnByZW1fc2lkIjoiUy0xLTUtMjEtMTczODA3NzQ5NC0xNzkyMjcwODgwLTMzMTc3MjU0LTkxNDYiLCJwbGF0ZiI6IjMiLCJzdWIiOiJ5NEZwZ1FjRzdqMDhCNGtSeUhsd3lxUTQ1R2syN1FXZFIxOTlhUWM3MlFjIiwidGlkIjoiMmJiMzFhN2ItMjNkNC00ODNjLWIxMTQtNTdjYWVlOTUwMWYzIiwidW5pcXVlX25hbWUiOiJhcnRodXIub2xpdmVpcmFAY2FzZWltYWdpbmUuY29tIiwidXBuIjoiYXJ0aHVyLm9saXZlaXJhQGNhc2VpbWFnaW5lLmNvbSIsInZlciI6IjEuMCJ9.FDApqFr_DbS_Sf6yqenaFuWS7g0dFBljxBXnn5OCr7PSJVQsven_Y7TAbRWZIoofULvs8SkVIFLvfbONH7DYfi8YCie09gEgQypDbRgVuB60mWDSc2sI-Hdj5V7sp2nm6sKQUTsunEIVm8Agkfw0R6A-UCK_xJEbgCT8MqrJUeXcD4u6cEKgRnh32VPsgqNh893Ch5Y9UPPzg-0nlswSGX9xBwaY9XrpIv_TQdAF_n6MkjdSrCFHHs53EMe0bTZudi8OQRXc6hU8TD5YArKQrlVLrcNPDpGPXAzo2FLJjNH2l6_Wrk5HSVoEF9SntXxWlq3Qfjv8DTX4ZVEx5r8cIQ\",";
            text += "\"description\": \"\"";
            text += "}";
            text += "],";
            text += "\"body\": {},";
            text += "\"description\": \"\"";

            text += "},";
            text += "\"response\": []";

            text += "},";

            //Get Id
            text += "{";

            text += "\"name\": \"Get " + m.Name + " by Id\",";
            text += "\"event\": [";
            text += "{";
            text += "\"listen\": \"test\",";
            text += "\"script\": {";
            text += "\"type\": \"text/javascript\",";
            text += "\"exec\": [";
            text += "\"tests[\\\"Status code is 200\\\"] = responseCode.code === 200;\"";
            text += "]";
            text += "}";
            text += "}";
            text += "],";
            text += "\"request\": {";
            text += "\"url\": \"https://localhost:44313/api/BankAccount?id=55A81B46-F811-4293-AFED-7228ED074185\",";
            text += "\"method\": \"GET\",";
            text += "\"header\": [";

            text += "{";
            text += "\"key\": \"Authorization\",";
            text += "\"value\": \"Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6Il9VZ3FYR190TUxkdVNKMVQ4Y2FIeFU3Y090YyIsImtpZCI6Il9VZ3FYR190TUxkdVNKMVQ4Y2FIeFU3Y090YyJ9.eyJhdWQiOiI1ZTE2Yzg4My1kOWUxLTQxYWYtOGE4NC00YTZhYTI1YTMxY2IiLCJpc3MiOiJodHRwczovL3N0cy53aW5kb3dzLm5ldC8yYmIzMWE3Yi0yM2Q0LTQ4M2MtYjExNC01N2NhZWU5NTAxZjMvIiwiaWF0IjoxNDg3Njk5MDgzLCJuYmYiOjE0ODc2OTkwODMsImV4cCI6MTQ4NzcwMjk4MywiYW1yIjpbInB3ZCJdLCJmYW1pbHlfbmFtZSI6Ik9saXZlaXJhIiwiZ2l2ZW5fbmFtZSI6IkFydGh1ciIsImlwYWRkciI6IjE4OS4xMjUuMzguMTIyIiwibmFtZSI6IkFydGh1ciBCYXB0aXN0YSBNb3JhZXMgQXJydWRhIGRlIE9saXZlaXJhIiwibm9uY2UiOiJiNWU1NTYwMy03Zjk5LTQ4YWMtYjVkNS1iZTVhMGYyMDUyNWQiLCJvaWQiOiJlNDE4MTAzMy0yODA2LTRkNTgtYTU2OC03YTUwY2VjODc4YTYiLCJvbnByZW1fc2lkIjoiUy0xLTUtMjEtMTczODA3NzQ5NC0xNzkyMjcwODgwLTMzMTc3MjU0LTkxNDYiLCJwbGF0ZiI6IjMiLCJzdWIiOiJ5NEZwZ1FjRzdqMDhCNGtSeUhsd3lxUTQ1R2syN1FXZFIxOTlhUWM3MlFjIiwidGlkIjoiMmJiMzFhN2ItMjNkNC00ODNjLWIxMTQtNTdjYWVlOTUwMWYzIiwidW5pcXVlX25hbWUiOiJhcnRodXIub2xpdmVpcmFAY2FzZWltYWdpbmUuY29tIiwidXBuIjoiYXJ0aHVyLm9saXZlaXJhQGNhc2VpbWFnaW5lLmNvbSIsInZlciI6IjEuMCJ9.FDApqFr_DbS_Sf6yqenaFuWS7g0dFBljxBXnn5OCr7PSJVQsven_Y7TAbRWZIoofULvs8SkVIFLvfbONH7DYfi8YCie09gEgQypDbRgVuB60mWDSc2sI-Hdj5V7sp2nm6sKQUTsunEIVm8Agkfw0R6A-UCK_xJEbgCT8MqrJUeXcD4u6cEKgRnh32VPsgqNh893Ch5Y9UPPzg-0nlswSGX9xBwaY9XrpIv_TQdAF_n6MkjdSrCFHHs53EMe0bTZudi8OQRXc6hU8TD5YArKQrlVLrcNPDpGPXAzo2FLJjNH2l6_Wrk5HSVoEF9SntXxWlq3Qfjv8DTX4ZVEx5r8cIQ\",";
            text += "\"description\": \"\"";
            text += "}";
            text += "],";
            text += "\"body\": {},";
            text += "\"description\": \"\"";

            text += "},";
            text += "\"response\": []";

            text += "},";

            //Post
            text += "{";

            text += "\"name\": \"Post " + m.Name + "\",";
            text += "\"event\": [";
            text += "{";
            text += "\"listen\": \"test\",";
            text += "\"script\": {";
            text += "\"type\": \"text/javascript\",";
            text += "\"exec\": [";
            text += "\"tests[\\\"Status code is 200\\\"] = responseCode.code === 200;\"";
            text += "]";
            text += "}";
            text += "}";
            text += "],";
            text += "\"request\": {";
            text += "\"url\": \"https://localhost:44313/api/BankAccount?id=55A81B46-F811-4293-AFED-7228ED074185\",";
            text += "\"method\": \"GET\",";
            text += "\"header\": [";

            text += "{";
            text += "\"key\": \"Authorization\",";
            text += "\"value\": \"Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6Il9VZ3FYR190TUxkdVNKMVQ4Y2FIeFU3Y090YyIsImtpZCI6Il9VZ3FYR190TUxkdVNKMVQ4Y2FIeFU3Y090YyJ9.eyJhdWQiOiI1ZTE2Yzg4My1kOWUxLTQxYWYtOGE4NC00YTZhYTI1YTMxY2IiLCJpc3MiOiJodHRwczovL3N0cy53aW5kb3dzLm5ldC8yYmIzMWE3Yi0yM2Q0LTQ4M2MtYjExNC01N2NhZWU5NTAxZjMvIiwiaWF0IjoxNDg3Njk5MDgzLCJuYmYiOjE0ODc2OTkwODMsImV4cCI6MTQ4NzcwMjk4MywiYW1yIjpbInB3ZCJdLCJmYW1pbHlfbmFtZSI6Ik9saXZlaXJhIiwiZ2l2ZW5fbmFtZSI6IkFydGh1ciIsImlwYWRkciI6IjE4OS4xMjUuMzguMTIyIiwibmFtZSI6IkFydGh1ciBCYXB0aXN0YSBNb3JhZXMgQXJydWRhIGRlIE9saXZlaXJhIiwibm9uY2UiOiJiNWU1NTYwMy03Zjk5LTQ4YWMtYjVkNS1iZTVhMGYyMDUyNWQiLCJvaWQiOiJlNDE4MTAzMy0yODA2LTRkNTgtYTU2OC03YTUwY2VjODc4YTYiLCJvbnByZW1fc2lkIjoiUy0xLTUtMjEtMTczODA3NzQ5NC0xNzkyMjcwODgwLTMzMTc3MjU0LTkxNDYiLCJwbGF0ZiI6IjMiLCJzdWIiOiJ5NEZwZ1FjRzdqMDhCNGtSeUhsd3lxUTQ1R2syN1FXZFIxOTlhUWM3MlFjIiwidGlkIjoiMmJiMzFhN2ItMjNkNC00ODNjLWIxMTQtNTdjYWVlOTUwMWYzIiwidW5pcXVlX25hbWUiOiJhcnRodXIub2xpdmVpcmFAY2FzZWltYWdpbmUuY29tIiwidXBuIjoiYXJ0aHVyLm9saXZlaXJhQGNhc2VpbWFnaW5lLmNvbSIsInZlciI6IjEuMCJ9.FDApqFr_DbS_Sf6yqenaFuWS7g0dFBljxBXnn5OCr7PSJVQsven_Y7TAbRWZIoofULvs8SkVIFLvfbONH7DYfi8YCie09gEgQypDbRgVuB60mWDSc2sI-Hdj5V7sp2nm6sKQUTsunEIVm8Agkfw0R6A-UCK_xJEbgCT8MqrJUeXcD4u6cEKgRnh32VPsgqNh893Ch5Y9UPPzg-0nlswSGX9xBwaY9XrpIv_TQdAF_n6MkjdSrCFHHs53EMe0bTZudi8OQRXc6hU8TD5YArKQrlVLrcNPDpGPXAzo2FLJjNH2l6_Wrk5HSVoEF9SntXxWlq3Qfjv8DTX4ZVEx5r8cIQ\",";
            text += "\"description\": \"\"";
            text += "},";
            text += "{";
            text += "\"key\": \"Content-Type\",";
            text += "\"value\": \"application/json\",";
            text += "\"description\": \"\"";
            text += "}";
            text += "],";
            text += "\"body\": {";
            text += "\"mode\": \"raw\",";
            text += "\"raw\": \"{";

            foreach (Property p in m.Properties)
                text += "\"" + p.Name + "\": \"" + ConvertToJson(p.Type) + "\",";

            text = text.Substring(0, text.Length - 1);
            text += "}\"";

            text += "},";
            text += "\"description\": \"\"";

            text += "},";
            text += "\"response\": []";

            text += "},";

            text += "]}";

            //Put
            text += "{";

            text += "\"name\": \"Get " + m.Name + " by Id\",";
            text += "\"event\": [";
            text += "{";
            text += "\"listen\": \"test\",";
            text += "\"script\": {";
            text += "\"type\": \"text/javascript\",";
            text += "\"exec\": [";
            text += "\"tests[\\\"Status code is 200\\\"] = responseCode.code === 200;\"";
            text += "]";
            text += "}";
            text += "}";
            text += "],";
            text += "\"request\": {";
            text += "\"url\": \"https://localhost:44313/api/BankAccount?id=55A81B46-F811-4293-AFED-7228ED074185\",";
            text += "\"method\": \"GET\",";
            text += "\"header\": [";

            text += "{";
            text += "\"key\": \"Authorization\",";
            text += "\"value\": \"Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6Il9VZ3FYR190TUxkdVNKMVQ4Y2FIeFU3Y090YyIsImtpZCI6Il9VZ3FYR190TUxkdVNKMVQ4Y2FIeFU3Y090YyJ9.eyJhdWQiOiI1ZTE2Yzg4My1kOWUxLTQxYWYtOGE4NC00YTZhYTI1YTMxY2IiLCJpc3MiOiJodHRwczovL3N0cy53aW5kb3dzLm5ldC8yYmIzMWE3Yi0yM2Q0LTQ4M2MtYjExNC01N2NhZWU5NTAxZjMvIiwiaWF0IjoxNDg3Njk5MDgzLCJuYmYiOjE0ODc2OTkwODMsImV4cCI6MTQ4NzcwMjk4MywiYW1yIjpbInB3ZCJdLCJmYW1pbHlfbmFtZSI6Ik9saXZlaXJhIiwiZ2l2ZW5fbmFtZSI6IkFydGh1ciIsImlwYWRkciI6IjE4OS4xMjUuMzguMTIyIiwibmFtZSI6IkFydGh1ciBCYXB0aXN0YSBNb3JhZXMgQXJydWRhIGRlIE9saXZlaXJhIiwibm9uY2UiOiJiNWU1NTYwMy03Zjk5LTQ4YWMtYjVkNS1iZTVhMGYyMDUyNWQiLCJvaWQiOiJlNDE4MTAzMy0yODA2LTRkNTgtYTU2OC03YTUwY2VjODc4YTYiLCJvbnByZW1fc2lkIjoiUy0xLTUtMjEtMTczODA3NzQ5NC0xNzkyMjcwODgwLTMzMTc3MjU0LTkxNDYiLCJwbGF0ZiI6IjMiLCJzdWIiOiJ5NEZwZ1FjRzdqMDhCNGtSeUhsd3lxUTQ1R2syN1FXZFIxOTlhUWM3MlFjIiwidGlkIjoiMmJiMzFhN2ItMjNkNC00ODNjLWIxMTQtNTdjYWVlOTUwMWYzIiwidW5pcXVlX25hbWUiOiJhcnRodXIub2xpdmVpcmFAY2FzZWltYWdpbmUuY29tIiwidXBuIjoiYXJ0aHVyLm9saXZlaXJhQGNhc2VpbWFnaW5lLmNvbSIsInZlciI6IjEuMCJ9.FDApqFr_DbS_Sf6yqenaFuWS7g0dFBljxBXnn5OCr7PSJVQsven_Y7TAbRWZIoofULvs8SkVIFLvfbONH7DYfi8YCie09gEgQypDbRgVuB60mWDSc2sI-Hdj5V7sp2nm6sKQUTsunEIVm8Agkfw0R6A-UCK_xJEbgCT8MqrJUeXcD4u6cEKgRnh32VPsgqNh893Ch5Y9UPPzg-0nlswSGX9xBwaY9XrpIv_TQdAF_n6MkjdSrCFHHs53EMe0bTZudi8OQRXc6hU8TD5YArKQrlVLrcNPDpGPXAzo2FLJjNH2l6_Wrk5HSVoEF9SntXxWlq3Qfjv8DTX4ZVEx5r8cIQ\",";
            text += "\"description\": \"\"";
            text += "}";
            text += "],";
            text += "\"body\": {";
            text += "\"mode\": \"raw\",";
            text += "\"raw\": \"{";

            foreach (Property p in m.Properties)
                text += "\"" + p.Name + "\": \"" + ConvertToJson(p.Type) + "\",";

            text = text.Substring(0, text.Length - 1);
            text += "}\"";

            text += "},";
            text += "\"description\": \"\"";

            text += "},";
            text += "\"response\": []";

            text += "},";

            text += "]}";

            //Delete
            text += "{";

            text += "\"name\": \"Delete " + m.Name + " by Id\",";
            text += "\"event\": [";
            text += "{";
            text += "\"listen\": \"test\",";
            text += "\"script\": {";
            text += "\"type\": \"text/javascript\",";
            text += "\"exec\": [";
            text += "\"tests[\\\"Status code is 200\\\"] = responseCode.code === 200;\"";
            text += "]";
            text += "}";
            text += "}";
            text += "],";
            text += "\"request\": {";
            text += "\"url\": \"https://localhost:44313/api/BankAccount?id=55A81B46-F811-4293-AFED-7228ED074185\",";
            text += "\"method\": \"GET\",";
            text += "\"header\": [";

            text += "{";
            text += "\"key\": \"Authorization\",";
            text += "\"value\": \"Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6Il9VZ3FYR190TUxkdVNKMVQ4Y2FIeFU3Y090YyIsImtpZCI6Il9VZ3FYR190TUxkdVNKMVQ4Y2FIeFU3Y090YyJ9.eyJhdWQiOiI1ZTE2Yzg4My1kOWUxLTQxYWYtOGE4NC00YTZhYTI1YTMxY2IiLCJpc3MiOiJodHRwczovL3N0cy53aW5kb3dzLm5ldC8yYmIzMWE3Yi0yM2Q0LTQ4M2MtYjExNC01N2NhZWU5NTAxZjMvIiwiaWF0IjoxNDg3Njk5MDgzLCJuYmYiOjE0ODc2OTkwODMsImV4cCI6MTQ4NzcwMjk4MywiYW1yIjpbInB3ZCJdLCJmYW1pbHlfbmFtZSI6Ik9saXZlaXJhIiwiZ2l2ZW5fbmFtZSI6IkFydGh1ciIsImlwYWRkciI6IjE4OS4xMjUuMzguMTIyIiwibmFtZSI6IkFydGh1ciBCYXB0aXN0YSBNb3JhZXMgQXJydWRhIGRlIE9saXZlaXJhIiwibm9uY2UiOiJiNWU1NTYwMy03Zjk5LTQ4YWMtYjVkNS1iZTVhMGYyMDUyNWQiLCJvaWQiOiJlNDE4MTAzMy0yODA2LTRkNTgtYTU2OC03YTUwY2VjODc4YTYiLCJvbnByZW1fc2lkIjoiUy0xLTUtMjEtMTczODA3NzQ5NC0xNzkyMjcwODgwLTMzMTc3MjU0LTkxNDYiLCJwbGF0ZiI6IjMiLCJzdWIiOiJ5NEZwZ1FjRzdqMDhCNGtSeUhsd3lxUTQ1R2syN1FXZFIxOTlhUWM3MlFjIiwidGlkIjoiMmJiMzFhN2ItMjNkNC00ODNjLWIxMTQtNTdjYWVlOTUwMWYzIiwidW5pcXVlX25hbWUiOiJhcnRodXIub2xpdmVpcmFAY2FzZWltYWdpbmUuY29tIiwidXBuIjoiYXJ0aHVyLm9saXZlaXJhQGNhc2VpbWFnaW5lLmNvbSIsInZlciI6IjEuMCJ9.FDApqFr_DbS_Sf6yqenaFuWS7g0dFBljxBXnn5OCr7PSJVQsven_Y7TAbRWZIoofULvs8SkVIFLvfbONH7DYfi8YCie09gEgQypDbRgVuB60mWDSc2sI-Hdj5V7sp2nm6sKQUTsunEIVm8Agkfw0R6A-UCK_xJEbgCT8MqrJUeXcD4u6cEKgRnh32VPsgqNh893Ch5Y9UPPzg-0nlswSGX9xBwaY9XrpIv_TQdAF_n6MkjdSrCFHHs53EMe0bTZudi8OQRXc6hU8TD5YArKQrlVLrcNPDpGPXAzo2FLJjNH2l6_Wrk5HSVoEF9SntXxWlq3Qfjv8DTX4ZVEx5r8cIQ\",";
            text += "\"description\": \"\"";
            text += "}";
            text += "],";
            text += "\"body\": {},";
            text += "\"description\": \"\"";

            text += "},";
            text += "\"response\": []";

            text += "},";

            text += "]}";

            text += "]}";

            StreamWriter file = File.AppendText(fileName);

            file.WriteLine(text);

            file.Close();

            return result;
        }

        private static string ConvertToJson(string s)
        {
            switch (s)
            {
                case "Guid":
                    return "0AD9DE87-DE8C-412A-BF22-F1CE034A4065";
                case "Int":
                    return "1";
                case "int":
                    return "1";
                case "Bool":
                    return "False";
                case "bool":
                    return "False";
                case "Boolean":
                    return "False";
                case "boolean":
                    return "False";
                case "DateTime":
                    return "2017-01-05 00:00:00.000";
                case "String":
                    return "Teste";
                case "string":
                    return "Teste";
                case "Float":
                    return "1";
                case "Double":
                    return "1";
                case "Decimal":
                    return "1";
                case "float":
                    return "1";
                case "double":
                    return "1";
                case "decimal":
                    return "1";
                default:
                    return "";
            }
        }
    }
}
