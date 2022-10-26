using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TextPreprocessor.Models
{
    public class Text
    {
        public int Id { get; set; }
        [DisplayName("Слово")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Слово должно состоять минимум из 3 букв")]
        public string Word { get; set; }
    }
}