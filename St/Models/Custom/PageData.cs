using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace St.Models.Custom
{
    public class PageData
    {
        public string PageDataId { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Название страницы")]
        public string PageName { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Заголовок страницы")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Мета описание страницы")]
        public string MetaDescription { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Мета ключевые слова страницы")]
        public string MetaKeywords { get; set; }
    }
}