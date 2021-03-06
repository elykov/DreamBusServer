﻿using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using BusinessLayerLibrary.Models;
using DataAccessLayer;
using DreamBusDBLayer;

namespace BusinessLayerLibrary.Services
{
    public class NeighborCityService : AGenericService<NeighborCity, NeighborCitiesDTO>
    {
        public NeighborCityService(IGenericRepository<NeighborCity> repository) : base(repository)
        {
        }

        protected override IMapper GetMapper()
        {
            return new MapperConfiguration(cfg => {
                cfg.AddExpressionMapping();
                cfg.CreateMap<NeighborCity, NeighborCitiesDTO>();
                cfg.CreateMap<NeighborCitiesDTO, NeighborCity>();
            }).CreateMapper();
        }
    }
}
