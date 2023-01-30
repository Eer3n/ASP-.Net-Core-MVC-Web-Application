using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ASP_NetCore_6.Enum;

namespace ASP_NetCore_6.Entity;
[Table("USER")]
public class User
{
   [Key]
   [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
   public long Id { get; set; }
   public string name { get; set; }
   public string surname { get; set; }
   public string password { get; set; }
   public string country { get; set; }
   public Gender Gender { get; set; }
}