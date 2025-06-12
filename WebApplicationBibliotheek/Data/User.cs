using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLoginApp.Data
{
    [Table("tblgebruiker")]
    public class User
    {
        [Key]

        public string Email { get; set; }

        public string Wachtwoord { get; set; }
    }
}
