﻿using System.Collections.Generic;

namespace TennisMingle.API.Models
{
    public interface ITennisMingleRepository
    {
        IEnumerable<CityDTO> GetAllCities();
        IEnumerable<CityDTO> GetCityById(int id);
    }
}