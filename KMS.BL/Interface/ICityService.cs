using KMS.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.BL.Interface
{
    /// <summary>
    /// This is the interface of City
    /// </summary>
   public interface ICityService
    {
        int Save(CityVM model);
        List<CityVM> GetCity();
    }
}
