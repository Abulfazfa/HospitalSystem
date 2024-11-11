﻿
using HospitalSystem.Domain.Entities;

namespace HospitalSystem.Application.Features.Offices.Queries.GetAllOffices
{
    public class GetAllOfficesQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Tel { get; set; }
        public ICollection<WorkingTime> WorkingTimes { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}
