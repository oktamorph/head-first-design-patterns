﻿namespace FactoryPattern
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }
        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }
        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }
        public Clams CreateClam()
        {
            return new FreshClams();
        }
    }
}
