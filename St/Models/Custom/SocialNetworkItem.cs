using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace St.Models.Custom
{
    public class SocialNetworkItem
    {
        public string SocialNetworkItemId { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Тип: share или follow")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Ссылка")]
        public string Url { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Html для иконки")]
        public string IconClass { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Название соцсети")]
        public string Name { get; set; }
    }
}