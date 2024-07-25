using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodefirstAsp.Models
{
    public class Student
    {
        [Key]  /*Atrribute */ /*#reprasent primary key*/
        public int Id { get; set; }

        [Column("StudentName",TypeName ="varchar(100)")]
        public string Name { get; set; }

        [Column("StudentGender", TypeName = "varchar(100)")]

        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
