using System;
using System.Collections.Generic;
using System.Text;

namespace PetStoreApp
{
    enum TypeOfPet
    {
        Dog,
        Cat,
        Fish,
        Reptile,
    }

    class Product
    {
        private static int last_ID = 0;

        #region Properties
        public string Name { get; set; }
        public int ID { get; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; private set; }
        public TypeOfPet Pet { get; set; }
        public DateTime EnterDate { get; }
        #endregion

        #region Constructor
        public Product()
        {
            ID = ++last_ID;
            EnterDate = DateTime.Now;
        }
        #endregion

        #region Methods

        public void Input(int amount)
        {
            Quantity += amount;
        }

        public void Output(int amount)
        {
            Quantity -= amount;
        }
        #endregion
    }
}
