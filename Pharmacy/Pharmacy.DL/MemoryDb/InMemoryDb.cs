using Pharmacy.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pharmacy.DL.MemoryDb
{
    public static class InMemoryDb
    {
        public static List<Medicine> MedicineData = new List<Medicine>() { 
        new Medicine()
        {
            Id = 1,
            Name = "Healixin",
            Price = 49.99m,
            ManufacturerId = 1,
        },
        new Medicine()
        {
            Id = 2,
            Name = "NeuroCalm", 
            Price = 79.99m,
            ManufacturerId = 2,
        },
        new Medicine()
        {
            Id = 3,
            Name = "RespiraGuard",
            Price = 39.99m,
            ManufacturerId = 3,
        }
    };

    public static List<Manufacturer> ManufacturerData = new List<Manufacturer>()
        {
        new Manufacturer()
        {
            Id = 1,
            Name = "Quantum Pharmaceuticals",
            Country = "Bulgaria"
        },
        new Manufacturer()
        {
            Id= 2,
            Name = "BioHealth Solutions Ltd.",
            Country = "USA"
        },
        new Manufacturer()
        {
            Id = 3,
            Name = "SynthoMinds Inc.",
            Country = "UK"
        },
        };
}
}
