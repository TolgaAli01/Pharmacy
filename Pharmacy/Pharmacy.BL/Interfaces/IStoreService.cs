using Pharmacy.Models.Request;
using Pharmacy.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.BL.Interfaces
{
    public interface IStoreService
    {
        GetMedicinesByManufacturerResponse? GetMedicinesByManufacturer(GetMedicinesByManufacturerRequest request);
    }
}
