﻿using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.Appointments.Commands.Models
{
    public class EditAppointmentCommand : IRequest<CusResponse<string>>
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int DoctorId { get; set; }
        public int PatientCaseId { get; set; }
        public int AppointmentStatusId { get; set; }
    }
}
