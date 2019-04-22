using System.ComponentModel.DataAnnotations;  //Для добавления атрибута Required

namespace Identity_test.Models
{
    public class CreateModel
    {
        [Required]  //Этот атрибут указывает системе валидации модели на то, что эти свойства обязательно должны быть заданы.
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}