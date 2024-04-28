using Practice2.Data.Entity;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Practice2.Data.JsonData
{
    public class JsonData
    {
        public List<User> Users { get; set; } = new List<User>(); //Лист людей
        public static List<Apartments> Apartments { get; set; } = new List<Apartments>(); //Лист квартир

        public static string file = @"Resources\users.json"; //файл людей
        public static string apartmentfile = @"Resources\Apartments\Apartments.json"; //файл квартир


        public static JsonSerializerOptions optionsSerializer = new JsonSerializerOptions //параметри збереження json
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true
        };

        public static void CreateDirectory() //створення папок якщо їх не існує
        {
            if (!Directory.Exists("Resources"))
            {
                Directory.CreateDirectory("Resources");
            }

            if (!File.Exists(file))
            {
                File.WriteAllText(file, "");
            }

            if (!Directory.Exists(@"Resources\Apartments"))
            {
                Directory.CreateDirectory(@"Resources\Apartments");
            }
        }
        public static void CreateFile() //створення файлів
        {
            if (!File.Exists(file))
            {
                File.WriteAllText(file, "{}");
            }
            if (!File.Exists(apartmentfile))
            {
                File.WriteAllText(apartmentfile, "{}");
            }
        }
        #region User
        public static void SaveUsersToJson(User user) //збереження користувача в файл
        {
            List<User> users = LoadUsersFromJson();
            users.Add(user);
            string json = JsonSerializer.Serialize(users, optionsSerializer);
            File.WriteAllText(file, json);
        }
        public static List<User> LoadUsersFromJson() //загрузка користувачів з файлу
        {
            string json = File.ReadAllText(file);
            return !string.IsNullOrWhiteSpace(json) ? JsonSerializer.Deserialize<List<User>>(json) : new List<User>();
        }
        #endregion

        #region Apartments
        public static void SaveApartmentsToJson(Apartments apartments) //збереження квартири в файл
        {
            List<Apartments> apartment = LoadApartmentsFromJson();
            if (!apartment.FirstOrDefault(a => a.Name == apartments.Name).Equals(default(Apartments)))
            {
                apartment[apartment.FindIndex(a => a.Name == apartments.Name)] = apartments;
            }
            else
            {
                apartment.Add(apartments);
            }

            string json = JsonSerializer.Serialize(apartment, optionsSerializer);
            File.WriteAllText(apartmentfile, json);
        }

        public static List<Apartments> LoadApartmentsFromJson() //загрузка квартир з файлу
        {
            string json = File.ReadAllText(apartmentfile);
            return !string.IsNullOrWhiteSpace(json) ? JsonSerializer.Deserialize<List<Apartments>>(json) : new List<Apartments>();
        }
        #endregion

    }

}
