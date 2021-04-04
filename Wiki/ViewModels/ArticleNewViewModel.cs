using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace Wiki.ViewModels
{
    public class ArticleNewViewModel
    {
        [Required(ErrorMessage = "Не указан текст статьи")]
        public string ТекстСтатьи { get; set; }
        [Required(ErrorMessage = "Не указано название статьи")]
        public string Название { get; set; }
        [Required(ErrorMessage = "Не указан код части речи")]
        public long КодЧастиРечи { get; set; }
        public List<string> СписокТегов { get; set; }
        public IFormFile Изображение { get; set; }
        public IFormFile Аудио { get; set; }
    }
}
