using Pharmacy.BL.Interfaces;
using Pharmacy.DL.Interfaces;
using Pharmacy.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.BL.Services
{
    public class MedicineService : IMedicineService
    {
        private readonly IMedicineService _medicineRepository;
        public MedicineService(IMedicineRepository medicineRepository) 
        { 
            _medicineRepository = (IMedicineService?)medicineRepository; 
        }
        

        public void Add(Medicine medicine)
        {
            _medicineRepository.Add(medicine);
        }

        public List<Medicine> GetAll()
        {
            return _medicineRepository.GetAll();
        }

        public Medicine GetById(int id)
        {
            return _medicineRepository.GetById(id);
        }

        public void Remove(int id)
        {
            _medicineRepository.Remove(id);
        }

        public List<Medicine> GetAllBooksByAuthorId(int authorId)
        {
            return _medicineRepository.GetAllBooksByAuthorId(authorId);
        }

        public int TestCalculation(int number)
        {
            var medicines = _medicineRepository.GetAll();
            return medicines.Count() + number;

        }
    }
}
