//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prak3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Snasti
    {
        public int SnastID { get; set; }
        public string SnastName { get; set; }
        public string Cvet { get; set; }
        public string TypeOfSnast { get; set; }
        public string Razmer { get; set; }
        public Nullable<int> IDSklad {private get; set; }
    
        public virtual Sklad Sklad { get; set; }
    }
}
