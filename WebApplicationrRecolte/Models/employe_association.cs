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
    
    public partial class employe_association
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employe_association()
        {
            this.utilisateurs = new HashSet<utilisateur>();
        }
    
        public int ID_employe { get; set; }
        public string CNI { get; set; }
        public int ID_association { get; set; }
        public string NOM_employe { get; set; }
        public string PRENOM_employe { get; set; }
        public string TEL_employe { get; set; }
        public string EMAIL_employe { get; set; }
        public string Statut { get; set; }
    
        public virtual association association { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<utilisateur> utilisateurs { get; set; }
    }
}
