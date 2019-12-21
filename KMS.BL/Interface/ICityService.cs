using KMS.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.BL.Interface
{
   public interface ICityService
    {
        int Save(CityVM model);
        List<CityVM> GetCity();
    }
}
