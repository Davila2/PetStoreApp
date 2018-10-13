using System;

namespace PetStoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var prod = new Product
            {
                Name = "Treats",
                Description = "Chiken flavor treats",
                Price = 15.00M,
                Pet = TypeOfPet.Dog,
            };
            prod.Input(50);
            prod.Output(20);

            Console.WriteLine($"PD: {prod.ID}, Name: {prod.Name}, Pet: {prod.Pet}, Price: {prod.Price:C}, Quantity: {prod.Quantity}");

            var prod2 = new Product
            {
                Name = "Leash",
                Description = "Large leash with lock",
                Price = 20.00M,
                Pet = TypeOfPet.Dog,
            };

            Console.WriteLine($"PD: {prod2.ID}, Name: {prod2.Name}, Pet: {prod2.Pet}, Price: {prod2.Price:C}");

            var prod3 = new Product
            {
                Name = "Brush",
                Description = "Soft large size brush",
                Price = 8.00M,
                Pet = TypeOfPet.Cat,
            };

            Console.WriteLine($"PD: {prod3.ID}, Name: {prod3.Name}, Pet: {prod3.Pet}, Price: {prod3.Price:C}");


        }
    }
}
