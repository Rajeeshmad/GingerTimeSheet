using GingerTimeSheet.Models.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace GingerTimeSheet.Models
{
    public class TimeSheetDue : ModelBase
    {
       [Key]
       public int Id { get; set; }
        public string Name { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}