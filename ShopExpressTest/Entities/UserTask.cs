using System.ComponentModel.DataAnnotations;

namespace ShopExpressTest.Entities
{
    public class UserTask
    {
        [Key]
        public Guid Id {  get; set; }
        [Required(ErrorMessage = "Поле 'Назва' є обов'язковим.")]
        [StringLength(100, ErrorMessage = "Назва завдання повинна бути не більше 100 символів.")]
        public string Title { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
    }
}
