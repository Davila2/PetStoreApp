using System;

namespace PetStoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************");
            Console.WriteLine("PetStore");
            Console.WriteLine("***************************");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Register new product");
            Console.WriteLine("2. Print all Products"); //WriteLine: write the whole thing and go to the next line
            Console.Write("Please select an option: ");   //Write: will write andd stay in the same place          
            var option = Console.ReadLine();

            switch (option)
            {
                case "0":
                    return;
                    
                case "1":
                    Console.Write("Name: ");
                    var name = Console.ReadLine();
                    Console.Write("Description of the product: ");
                    var description = Console.ReadLine();
                    Console.Write("Enter the price of the product: ");
                    var price = Console.ReadLine();
                    var pet = Enum.GetNames(typeof(TypeOfPet));

                    for (var i = 0; i < pet.Length; i++)
                    {
                        Console.WriteLine($"{i+1}.{pet[i]}");
                    }
                    Console.Write("Select a pet: ");
                    var petOption = Console.ReadLine();
                    break;
            }


            #region Old 
            /* var prod = new Product
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
             */
            #endregion
        }
    }
}
