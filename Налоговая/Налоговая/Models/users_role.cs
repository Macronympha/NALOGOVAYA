//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Налоговая.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class users_role
    {
        public int id_users_role { get; set; }
        public int id_role { get; set; }
        public int id_users { get; set; }
    
        public virtual role role { get; set; }
        public virtual users users { get; set; }
    }
}
