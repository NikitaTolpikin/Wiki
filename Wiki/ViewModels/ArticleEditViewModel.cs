using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wiki.ViewModels
{
    public class ArticleEditViewModel
    {
        public Guid IdСтатьи { get; set; }
        [Required (ErrorMessage = "Не указано название статьи")]
        public string Название { get; set; }
        [Required(ErrorMessage = "Не указан текст статьи")]
        public string ТекстСтатьи { get; set; }
        public IFormFile Изображение { get; set; }
        public IFormFile Аудио { get; set; }
        public string ПутьДоИзображения { get; set; }
        public string ПутьДоАудио { get; set; }
        [Required(ErrorMessage = "Не указана часть речи")]
        public long КодЧастиРечи { get; set; }
        public ICollection<СловарнаяСтатьяТег> СловарнаяСтатьяТег { get; set; }    }
}
