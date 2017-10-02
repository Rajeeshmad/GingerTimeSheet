using System;

namespace GingerTimeSheet.Models
{
    interface IModelBase
    {
        bool IsDeleted { get; set; }
    }
}
