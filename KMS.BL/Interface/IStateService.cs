using KMS.BL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.BL.Interface
{
   public interface IStateService
    {
        int Save(StateVM model);
        List<StateVM> GetState();
    }
}
