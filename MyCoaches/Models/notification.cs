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
    
    public partial class notification
    {
        public int id { get; set; }
        public Nullable<int> C_idPersonne { get; set; }
        public Nullable<int> C_idPost { get; set; }
        public Nullable<bool> Vue { get; set; }
        public string typeNtif { get; set; }
    
        public virtual Personne Personne { get; set; }
        public virtual Post Post { get; set; }
    }
}
