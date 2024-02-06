using Pharmacy.BL.Interfaces;
using Pharmacy.Models.Request;
using Pharmacy.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pharmacy.BL.Services.StoreService;

namespace Pharmacy.BL.Services
{
 
        public class StoreService : IStoreService
        {
            private readonly IManufacturerService _manufacturerService;
            private readonly IMedicineService _medicineService;

            public StoreService(IManufacturerService manufacturerService, IMedicineService medicineService)
            {
                _manufacturerService = manufacturerService;
                _medicineService = medicineService;
            }

            public GetMedicinesByManufacturerResponse? GetMedicinesByManufacturer(GetMedicinesByManufacturerRequest request)
            {
                var medicines = _medicineService.GetAllMedicinesByManufacturerId(request.ManufacturerId);

            if (medicines != null && medicines.Count > 0)
            {
                var response = new GetMedicinesByManufacturerResponse
                {
                    Manufacturer = _manufacturerService.GetById(request.ManufacturerId),
                    Medicines = medicines
                    .Where(product =>
                        (product.Price >= request.MinPrice) &&
                        (product.Price <= request.MaxPrice))
                    .ToList()
                };
                return response;
            }
                return null;
            }
        };
    }

