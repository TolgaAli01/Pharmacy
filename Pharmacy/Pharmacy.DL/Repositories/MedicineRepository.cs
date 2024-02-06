using Pharmacy.DL.Interfaces;
using Pharmacy.DL.MemoryDb;
using Pharmacy.Models.User;

namespace Pharmacy.DL.Repositories
{
    public class MedicineRepository : IMedicineRepository
    {

        public List<Medicine> GetAll()
        {
            return InMemoryDb.MedicineData;
        }
        public Medicine GetById(int id)
        {
            return InMemoryDb.MedicineData.First(a => a.Id == id);
        }
        public void Add(Medicine medicine)
        {
            InMemoryDb.MedicineData.Add(medicine);
        }
        public void Remove(int id)
        {
            var medicine = GetById(id);
            InMemoryDb.MedicineData.Remove(medicine);
        }
        public List<Medicine> GetAllMedicinesByManufacturerId(int id)
        {
            var result = InMemoryDb.MedicineData.Where(b => b.ManufacturerId == id).ToList();
            return result;
        }
    }
}
