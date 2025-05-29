using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
namespace oop_project

{
    internal  class TestAPI
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task CallGeminiAsync()
        {

            //string apiKey = Environment.GetEnvironmentVariable("GEMINI_API_KEY");
            string apiKey = "";
            string url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key={apiKey}";
            //Console.WriteLine("API KEY: " + apiKey); // זמני רק לבדיקה

            // הטקסט שאתה שולח ל־Gemini
            string prompt = "למה בקונסול זה מדפיס את התשובה שלך הפוך?";

            // יצירת גוף הבקשה לפי המבנה של Gemini
            var requestBody = new {contents = new[]{ new { parts = new[] {new { text = prompt }}}}};

            // הפיכת גוף הבקשה ל־JSON
            string jsonBody = JsonSerializer.Serialize(requestBody);

            try
            {
                // יצירת בקשת POST עם תוכן מסוג JSON
                StringContent httpContent = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                // שליחת הבקשה
                HttpResponseMessage response = await client.PostAsync(url, httpContent);

                // בדיקת תקינות
                response.EnsureSuccessStatusCode();

                // קריאת התגובה כמחרוזת
                string responseBody = await response.Content.ReadAsStringAsync();

                Console.WriteLine("📦 Gemini response:");
                Console.WriteLine(responseBody);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ שגיאה בבקשה:");
                Console.WriteLine(ex.Message);
            }

        }

    }
}
