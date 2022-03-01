using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MAQFurni.Models
{
    public partial class UserToken
    {
        [Key]
        public string UserId { get; set; }
        [Key]
        public string LoginProvider { get; set; }
        [Key]
        public string Name { get; set; }
        public string Value { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("UserTokens")]
        public virtual User User { get; set; }
    }
}
