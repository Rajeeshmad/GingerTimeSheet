using GingerTimeSheet.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GingerTimeSheet.Models
{
    public class Employee: ModelBase
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Designation { get; set; }

        
        public Employee Parent { get; set; }
    }
}