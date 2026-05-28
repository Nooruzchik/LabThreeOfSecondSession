using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Text.Json;

namespace LabThreeOfSecondSession.Model
{
    /// <summary>
    /// Предоставляет методы для сохранения и загрузки списка книг в файл.
    /// </summary
    public static class FileStorage
    {
        // Путь: C:\Users\Main\AppData\Local\ListOfBooks\books.json
        private static string _filePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "ListOfBooks",
            "books.json"
        );

        /// <summary>
        /// Сохраняет список книг в файл
        /// </summary>
        public static void SaveBooks(List<Book> books)
        {
            try
            {
                // Получаем папку, где будет лежать файл (C:\Users\...\ListOfBooks)
                string folder = Path.GetDirectoryName(_filePath);

                // Если папки не существует - создаём её
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                // Превращаем список книг в JSON-строку
                string json = JsonSerializer.Serialize(books);

                // Записываем JSON-строку в файл
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
            }
        }

        /// <summary>
        /// Загружает список книг из файла
        /// </summary>
        public static List<Book> LoadBooks()
        {
            try
            {
                // Если файла не существует - возвращаем пустой список
                if (!File.Exists(_filePath))
                {
                    return new List<Book>();
                }

                // Читаем весь текст из файла
                string json = File.ReadAllText(_filePath);

                // Превращаем JSON-строку обратно в список книг
                List<Book> books = JsonSerializer.Deserialize<List<Book>>(json);

                // Если десериализация вернула null - возвращаем пустой список
                if (books == null)
                {
                    return new List<Book>();
                }

                return books;
            }
            catch (Exception ex)
            {
                // Если ошибка - показываем сообщение и возвращаем пустой список
                MessageBox.Show($"Ошибка при загрузке: {ex.Message}");
                return new List<Book>();
            }
        }
    }
}
