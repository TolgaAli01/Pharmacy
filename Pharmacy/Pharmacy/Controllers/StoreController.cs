using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.BL.Interfaces;
using Pharmacy.BL.Services;
using Pharmacy.Models.Request;
using Pharmacy.Models.Response;
using Pharmacy.Models.User;
using Pharmacy.Validators;

namespace Pharmacy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService _storeService;

        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }

        [HttpPost]
        public GetMedicinesByManufacturerResponse? GetMedicinesByManufacturer(GetMedicinesByManufacturerRequest request)
        {
            if (request == null) return null;

            return _storeService.GetMedicinesByManufacturer(request);

        }

        [HttpPost("TestEndpoint")]
        public string GetTestEndpoint([FromBody] GetMedicinesByManufacturerRequest request)
        {
            var validator = new GetMedicinesByManufacturerRequestValidator();

            var result = validator.Validate(request);
            if (result.IsValid)
            {
                return "Test Pass";
            }
            return "Test Not Pass";
        }
    }
}
