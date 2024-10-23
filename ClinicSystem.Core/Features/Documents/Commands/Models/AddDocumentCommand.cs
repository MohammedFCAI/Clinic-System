﻿using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.Documents.Commands.Models
{
    public class AddDocumentCommand : IRequest<CusResponse<string>>
    {
        public string DocumentName { get; set; } = null!;
        public string? Details { get; set; }
        public int DocumentTypeId { get; set; }
        public int AppointmentId { get; set; }
    }
}
