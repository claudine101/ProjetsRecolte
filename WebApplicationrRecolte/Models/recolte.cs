//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationrRecolte.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class recolte
    {
        public int ID_recolte { get; set; }
        public int ID_client { get; set; }
        public int ID_qualite { get; set; }
        public int ID_station { get; set; }
        public double quantite { get; set; }
        public double Prix { get; set; }
        public Nullable<System.DateTime> Date_insertion { get; set; }
    
        public virtual client client { get; set; }
        public virtual qualite qualite { get; set; }
        public virtual station_lavage station_lavage { get; set; }
    }
}