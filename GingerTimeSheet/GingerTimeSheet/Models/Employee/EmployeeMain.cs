using GingerTimeSheet.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace GingerTimeSheet.Models
{
    public class EmployeeMain: ModelBase
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
    }
}