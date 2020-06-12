﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using parkyapi.Models;
using parkyapi.Models.Dtos;

namespace parkyapi.ParkyMapper
{
    public class ParkyMappings : Profile
    {
        public ParkyMappings()
        {
            CreateMap<NationalPark, NationalParkDto>().ReverseMap();
        }
    }
}
