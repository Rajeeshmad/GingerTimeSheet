using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GingerTimeSheet.Model
{
    public class AccountDetailModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int? Parent { get; set; }
    }
}
