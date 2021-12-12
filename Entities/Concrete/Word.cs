using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Word : IEntity
    {
        public int Id { get; set; }
        public string Language { get; set; }
        public string TranslatedLanguage { get; set; }
        public string Text { get; set; }
        public string TranslatedText { get; set; }
        public string Pronunciation { get; set; }
        public string Level { get; set; }
        public string ImageUrl { get; set; }

    }
}
