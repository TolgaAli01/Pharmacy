using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.BL.Interfaces;
using Pharmacy.BL.Services;
using Pharmacy.Models.User;

namespace Pharmacy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        private readonly IMedicineService _medicineService;

        public MedicineController(IMedicineService medicineService)
        {
            _medicineService = medicineService;
        }

        [HttpGet("GetBookById")]
        public Medicine GetMedicineById(int id)
        {
            return _medicineService.GetById(id);
        }

        [HttpGet("GetAll")]
        public List<Medicine> GetAllBMedicine()
        {
            return _medicineService.GetAll();
        }

        [HttpPost("Add")]
        public void Add([FromBody] Medicine medicine)
        {
            if (medicine == null) return;
            _medicineService.Add(medicine);

        }

        [HttpDelete]
        public void Delete(int id)
        {
            _medicineService.Remove(id);
        }
    }
}
