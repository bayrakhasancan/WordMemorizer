using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Word word = new Word
            {
                Language = "English",
                TranslatedLanguage = "Turkish",
                Text = "Door",
                TranslatedText = "Kapı",
                Level = "A1",
                Pronunciation = "Door",
                ImageUrl = "../../image.png"
            };

            WordManager wordManager = new WordManager(new EFWordDal());

            var result = wordManager.Add(word);
            Console.WriteLine(result.Message);
            Console.ReadLine();
        }
    }
}
