//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bibekbooks
{
    using System;
    using System.Collections.Generic;
    
    public partial class productimage
    {
        public int img_id { get; set; }
        public int p_id { get; set; }
        public string img_path { get; set; }
    
        public virtual product product { get; set; }
    }
}
