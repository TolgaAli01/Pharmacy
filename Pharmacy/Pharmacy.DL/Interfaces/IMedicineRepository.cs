using Pharmacy.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.DL.Interfaces
{
    public interface IMedicineRepository
    {
        List<Medicine> GetAll();

        Medicine GetById(int id);

        void Add(Medicine medicine);

        void Remove(int id);

        List<Medicine> GetAllMedicinesByManufacturerId(int authorId);
    }
}
