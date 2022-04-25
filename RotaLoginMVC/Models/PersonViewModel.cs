using System.ComponentModel.DataAnnotations;

namespace RotaLoginMVC.Models
{
    public class PersonViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Name { get; set; }

        [Display(Name = "Disponível")]
        public bool IsAvailable { get; set; }

        public PersonViewModel() { }

        public PersonViewModel(string id, string name, bool isAvailable)
        {
            Id = id;
            Name = name;
            IsAvailable = isAvailable;
        }
    }
}
