//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Schedule
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule_pn
    {
        public int id { get; set; }
        public Nullable<int> id_Item { get; set; }
    
        public virtual Items Items { get; set; }
    }
}
