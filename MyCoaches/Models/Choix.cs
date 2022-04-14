//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyCoaches.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Choix
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Choix()
        {
            this.Abonnements = new HashSet<Abonnement>();
            this.Posts = new HashSet<Post>();
        }
    
        public int id { get; set; }
        public Nullable<int> C_idEntraineur { get; set; }
        public Nullable<int> C_idSport { get; set; }
        public string Category { get; set; }
        public Nullable<decimal> AbonnemetPrix { get; set; }
        public string textPub { get; set; }
        public string img { get; set; }
        public string TypeEntrainment { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Abonnement> Abonnements { get; set; }
        public virtual Entraineur Entraineur { get; set; }
        public virtual Sport Sport { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Post> Posts { get; set; }
    }
}
