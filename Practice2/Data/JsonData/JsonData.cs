using Practice2.Data.Entity;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Practice2.Data.JsonData
{
    public class JsonData
    {
        public List<User> Users { get; set; } = new List<User>();
        public static string file = @"Resources\users.json";


        public static JsonSerializerOptions optionsSerializer = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true
        };

        public static void CreateDirectory()
        {
            if (!Directory.Exists("Resources"))
            {
                Directory.CreateDirectory("Resources");
            }

            if (!File.Exists(file))
            {
                File.WriteAllText(file, "");
            }

            if (!Directory.Exists(@"Resources\Apartaments"))
            {
                Directory.CreateDirectory(@"Resources\Apartaments");
            }
        }
        public static void SaveUsersToJson(User user)
        {
            List<User> users = LoadUsersFromJson();
            users.Add(user);
            string json = JsonSerializer.Serialize(users, optionsSerializer);
            File.WriteAllText(file, json);
        }
        public static List<User> LoadUsersFromJson()
        {
            string json = File.ReadAllText(file);
            return !string.IsNullOrWhiteSpace(json) ? JsonSerializer.Deserialize<List<User>>(json) : new List<User>();
        }

    }

}
