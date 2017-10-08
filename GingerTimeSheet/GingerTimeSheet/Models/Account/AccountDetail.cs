using GingerTimeSheet.Models.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GingerTimeSheet.Models
{
    public class AccountDetail: ModelBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        
        public Client Client{ get; set; }
    }
}