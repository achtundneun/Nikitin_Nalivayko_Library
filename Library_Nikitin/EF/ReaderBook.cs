//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_Nikitin.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReaderBook
    {
        public int Id { get; set; }
        public int IdBook { get; set; }
        public int IdReader { get; set; }
        public System.DateTime DateOfIssue { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public int IdEmployee { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Reader Reader { get; set; }
    }
}