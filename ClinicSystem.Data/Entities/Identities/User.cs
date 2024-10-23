﻿using Microsoft.AspNetCore.Identity;

namespace ClinicSystem.Data.Entities.Identities
{
    public class User : IdentityUser<int>
    {
        public string FullName { get; set; } = null!;
        public string? Address { get; set; }
        public string? Country { get; set; }

        public virtual ICollection<UserRefreshToken> UserRefreshTokens { get; set; } = null!;
    }
}
