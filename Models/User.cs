using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MAQFurni.Models
{
    [Index(nameof(NormalizedEmail), Name = "EmailIndex")]
    public partial class User : IdentityUser
    {
        public User()
        {
            Orders = new HashSet<Order>();
            UserClaims = new HashSet<UserClaim>();
            UserLogins = new HashSet<UserLogin>();
            UserRoles = new HashSet<UserRole>();
            UserTokens = new HashSet<UserToken>();
        }

        public DateTime CreateDate { get; set; }
        public int UserStatusId { get; set; }
        public int RoleId { get; set; }
        [ForeignKey(nameof(UserStatusId))]
        [InverseProperty("Users")]
        public virtual UserStatus UserStatus { get; set; }
        [InverseProperty(nameof(Order.User))]
        public virtual ICollection<Order> Orders { get; set; }
        [InverseProperty(nameof(UserClaim.User))]
        public virtual ICollection<UserClaim> UserClaims { get; set; }
        [InverseProperty(nameof(UserLogin.User))]
        public virtual ICollection<UserLogin> UserLogins { get; set; }
        [InverseProperty(nameof(UserRole.User))]
        public virtual ICollection<UserRole> UserRoles { get; set; }
        [InverseProperty(nameof(UserToken.User))]
        public virtual ICollection<UserToken> UserTokens { get; set; }
    }
}
