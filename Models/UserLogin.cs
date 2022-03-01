using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MAQFurni.Models
{
    [Index(nameof(UserId), Name = "IX_UserLogins_UserId")]
    public partial class UserLogin
    {
        [Key]
        public string LoginProvider { get; set; }
        [Key]
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        [Required]
        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("UserLogins")]
        public virtual User User { get; set; }
    }
}
