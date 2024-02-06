using Pharmacy.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.BL.Interfaces
{
    public interface IMedicineService
    {
        List<Medicine> GetAll();

        Medicine GetById(int id);

        void Add(Medicine medicine);

        void Remove(int id);
        List<Medicine> GetAllBooksByAuthorId(int medicineId);

    }
}
