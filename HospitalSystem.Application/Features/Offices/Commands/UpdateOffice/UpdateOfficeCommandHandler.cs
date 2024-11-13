﻿using HospitalSystem.Application.Bases;
using HospitalSystem.Application.Interfaces.AutoMapper;
using HospitalSystem.Application.Interfaces.UnitOfWorks;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalSystem.Domain.Entities;

namespace HospitalSystem.Application.Features.Offices.Commands.UpdateDoctor
{
    public class UpdateOfficeCommandHandler : BaseHandler, IRequestHandler<UpdateOfficeCommandRequest, Unit>
    {
        public UpdateOfficeCommandHandler(IMyMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<Unit> Handle(UpdateOfficeCommandRequest request, CancellationToken cancellationToken)
        {
            var product = await unitOfWork.GetReadRepository<Office>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = mapper.Map<Office, UpdateOfficeCommandRequest>(request);

            await unitOfWork.GetWriteRepository<Office>().UpdateAsync(map);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
