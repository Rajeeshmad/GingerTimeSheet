using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GingerTimeSheet.Models.Interface
{
    interface IModelTimeStamp
    {
        string RowVersion { get; set; }
    }
}
