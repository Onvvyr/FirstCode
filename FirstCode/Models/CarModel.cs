using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FirstCode
{
    [Table("Cars")] // za pomocą atrybutu nadajemy nazwę naszej tabeli
    public class CarModel
    {
        [Key] // ustawiamy klucz główny tabeli
        public int CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        // do każdego samochodu możemy przypisać wiele komentarzy
        public virtual ICollection<CommentModel> Comments { get; set; }
    }
}