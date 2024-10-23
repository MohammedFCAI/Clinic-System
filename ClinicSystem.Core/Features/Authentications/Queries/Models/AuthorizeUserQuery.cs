using ClinicSystem.Core.BasesCore;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace ClinicSystem.Core.Features.Authentications.Queries.Models
{
    public class AuthorizeUserQuery : IRequest<CusResponse<string>>
    {
        [Required(ErrorMessage = "AccessToken can't be blank.")]
        public string Accesstoken { get; set; } = null!;
    }
}
