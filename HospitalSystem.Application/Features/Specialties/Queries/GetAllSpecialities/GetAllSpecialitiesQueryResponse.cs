﻿
using HospitalSystem.Domain.Entities;

namespace HospitalSystem.Application.Features.Specialties.Queries.GetAllSpecialities
{
    public class GetAllSpecialitiesQueryResponse
    {
        public string Name { get; set; } = string.Empty;
        public List<Doctor> Doctors { get; set; }
        public int PhotoId { get; set; }
    }
}
