//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;

namespace CoreLib.Entity
{
    using System;
    using System.Collections.Generic;
    [DataContract]
    public partial class User
    {
      [DataMember]
        public int Id { get; set; }
      [DataMember]
        public string Name { get; set; }
      [DataMember]
      public string Login { get; set; }
      [DataMember]
      public string PasswordHash { get; set; }
      [DataMember]
      public long AccessLevel { get; set; }

      [DataMember]
      public virtual SessionKey SessionKey { get; set; }
   }
}
