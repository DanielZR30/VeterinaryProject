//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VeterynaryProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        public string IDInvoice { get; set; }
        public Nullable<decimal> InvoiceTotal { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public string InvoiceDescription { get; set; }
        public string IDCustomer { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
