//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LopushokApp.ADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductMaterial
    {
        public int Product_Material_ID { get; set; }
        public string VendorCode { get; set; }
        public int Material_ID { get; set; }
        public int MaterialCount { get; set; }
    
        public virtual Material Material { get; set; }
        public virtual Product Product { get; set; }
    }
}
