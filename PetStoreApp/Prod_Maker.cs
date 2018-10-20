using System;
using System.Collections.Generic;
using System.Text;

namespace PetStoreApp
{
    static class Prod_Maker
    {
        public static Product CreateProduct(string name, string description, decimal price, int initial_quantity = 0, TypeOfPet pet = TypeOfPet.Dog)
        {
            var product = new Product
            {
                Name = name,
                Description = description,
                Price = price,
                Pet = pet,
            };
            
            if (initial_quantity > 0)
            {
                product.Input(initial_quantity);
            }
            return product;
        }
    }
}
