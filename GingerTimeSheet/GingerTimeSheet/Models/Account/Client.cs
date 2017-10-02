using GingerTimeSheet.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GingerTimeSheet.Models
{
    public class Client:ModelBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}