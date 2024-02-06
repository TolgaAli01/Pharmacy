using Pharmacy.Models.User;
using Pharmacy.DL.MemoryDb;
using Pharmacy.DL.Interfaces;
using Pharmacy.BL.Services;
using Moq;

namespace Pharmacy.Test
{
    public class MedicineTest
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
        [Fact]
        public void GetAllByManufacturerId_Count_Check()
        {
            var expectedCount = 1;
            var manufacturerId = 2;

            var mockedProductRepository = new Mock<IMedicineRepository>();
            mockedProductRepository.Setup(x => x.GetAllMedicinesByManufacturerId(manufacturerId))
                .Returns(MedicineData.Where(p => p.ManufacturerId == manufacturerId).ToList());

            //injects
            var service = new MedicineService(mockedMedicineRepository.Object);

            //act
            var result = service.GetAllMedicinesByManufacturerId(manufacturerId);

            //assert
            Assert.NotNull(result);
            Assert.Equal(expectedCount, result.Count());
        }

        [Fact]
        public void GetAllByManufacturerId_WrongId()
        {
            var expectedCount = 0;
            var manufacturerId = 4;

            var mockedMedicineRepository = new Mock<IMedicineRepository>();
            mockedMedicineRepository.Setup(x => x.GetAllMedicinesByManufacturerId(manufacturerId))
                .Returns(MedicineData.Where(p => p.ManufacturerId == manufacturerId).ToList());

            //injects
            var service = new MedicineService(mockedMedicineRepository.Object);

            //act
            var result = service.GetAllMedicinesByManufacturerId(manufacturerId);

            //assert
            Assert.NotNull(result);
            Assert.Equal(expectedCount, result.Count());
        }

        [Fact]
        public void TestCalculation_Result_Check()
        {
            var expectedResult = 13;
            var testNumber = 10;

            var mockedMedicineRepository = new Mock<IMedicineRepository>();
            mockedMedicineRepository.Setup(x => x.GetAll())
                .Returns(MedicineData);

            //injects
            var service = new MedicineService(mockedMedicineRepository.Object);

            //act
            var result = service.TestCalculation(testNumber);

            //assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Remove_Count_Check()
        {
            var expectedResult = 2;
            var medicineId = 1;
            var medicineToRemove = MedicineData.FirstOrDefault(x => x.Id == medicineId);

            var mockedMedicineRepository = new Mock<IMedicineRepository>();
            mockedMedicineRepository.Setup(x => x.Remove(medicineId)).Callback(() =>
            {
                MedicineData.Remove(medicineToRemove);
            });

            //injects
            var service = new MedicineService(mockedMedicineRepository.Object);

            //act
            service.Remove(medicineId);

            //assert
            Assert.Equal(expectedResult, MedicineData.Count);
        }
    }
}