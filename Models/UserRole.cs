using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MAQFurni.Models
{
    [Index(nameof(RoleId), Name = "IX_UserRoles_RoleId")]
    public partial class UserRole
    {
        [Key]
        public string UserId { get; set; }
        [Key]
        public string RoleId { get; set; }

        [ForeignKey(nameof(RoleId))]
        [InverseProperty("UserRoles")]
        public virtual Role Role { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("UserRoles")]
        public virtual User User { get; set; }
    }
}
