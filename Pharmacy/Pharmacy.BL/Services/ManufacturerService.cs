using Pharmacy.BL.Interfaces;
using Pharmacy.DL.Interfaces;
using Pharmacy.DL.Repositories;
using Pharmacy.Models.User;

namespace Pharmacy.BL.Services
{
    public class ManufacturerService:IManufacturerService
    {
        private readonly IManufacturerRepository _manufacturerRepository;

        public ManufacturerService(IManufacturerRepository manufacturerRepository)
        {
            _manufacturerRepository = manufacturerRepository;
        }

        public void Add(Manufacturer manufacturer)
        {
            _manufacturerRepository.Add(manufacturer);
         }

        public List<Manufacturer> GetAll()
        {
            return _manufacturerRepository.GetAll();
        }

        public Manufacturer GetById(int id)
        {
            return _manufacturerRepository.GetById(id);
        }

        public void Remove(int id)
        {
            _manufacturerRepository.Remove(id);
        }
    }
}
