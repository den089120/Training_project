using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Train_project_Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")] // выводит указанное имя
        [Required] //проверяет на пустую строку
        [Range(1, int.MaxValue, ErrorMessage ="Display Order for category must be greater than 0")] // задает проверку на число
        public int DisplayOrder { get; set; }
    }
}
