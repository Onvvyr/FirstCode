using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FirstCode
{
    [Table("Comments")]  // za pomocą atrybutu nadajemy nazwę naszej tabeli
    public class CommentModel
    {
        [Key]  // ustawiamy klucz główny tabeli
        public int Id { get; set; }
        [ForeignKey("Cars")] // ustawiamy klucz obcy
        public int CarId { get; set; }
        public string Comment { get; set; }
        // będziemy widzieli, które samochody przynależą do tego komentarza
        public virtual CarModel Cars { get; set; }
    }
}