﻿using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.Users.Commands.Models
{
    public class AddUserCommand : IRequest<CusResponse<string>>
    {
        public string FullName { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string ConfirmPassword { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string? Country { get; set; }
        public string? Address { get; set; }
    }
}
