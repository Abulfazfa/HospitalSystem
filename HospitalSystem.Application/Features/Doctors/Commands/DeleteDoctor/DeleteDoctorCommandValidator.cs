﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Application.Features.Doctors.Commands.DeleteDoctor
{
    public class DeleteDoctorCommandValidator : AbstractValidator<DeleteDoctorCommandRequest>
    {
        public DeleteDoctorCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
        }
    }
}
