using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using parkyapi.Models;

namespace parkyapi.Repository.iRepository
{
    public interface iNationalParkRepository
    {
        ICollection<NationalPark> GetNationalParks();
        NationalPark GetNationalPark(int nationalParkID);
        bool NationalParkExists(string name);
        bool NationalParkExists(int id);
        bool CreateNationalPark(NationalPark nationalPark);
        bool UpdateNationalPark(NationalPark nationalPark);
        bool DeleteNationalPark(NationalPark nationalPark);
        bool Save();
    }
}
