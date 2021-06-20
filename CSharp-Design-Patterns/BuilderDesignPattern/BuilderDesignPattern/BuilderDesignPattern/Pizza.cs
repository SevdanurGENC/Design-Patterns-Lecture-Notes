using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.BuilderDesignPattern
{
    public class Pizza
    {

        private int size;

        private String name;

        private bool cheese;

        private bool olive;

        private bool pepperoni;

        private bool bacon;

        private bool mushroom;

        private bool mozarella;

        private Pizza(PizzaBuilder pizzaBuilder)
        {
            this.size = pizzaBuilder.size;
            this.name = pizzaBuilder.name;
            this.cheese = pizzaBuilder.cheese;
            this.olive = pizzaBuilder.olive;
            this.pepperoni = pizzaBuilder.pepperoni;
            this.bacon = pizzaBuilder.bacon;
            this.mushroom = pizzaBuilder.mushroom;
            this.mozarella = pizzaBuilder.mozarella;
        }

        public class PizzaBuilder
        {

            public int size;

            public String name;

            public bool cheese;

            public bool olive;

            public bool pepperoni;

            public bool bacon;

            public bool mushroom;

            public bool mozarella;

            public PizzaBuilder(int size, String name)
            {
                this.size = size;
                this.name = name;
            }

            public PizzaBuilder withOptionalCheese(bool cheese)
            {
                this.cheese = cheese;
                return this;
            }

            public PizzaBuilder withOptionalOlive(bool olive)
            {
                this.olive = olive;
                return this;
            }

            public PizzaBuilder withOptionalPepperoni(bool pepperoni)
            {
                this.pepperoni = pepperoni;
                return this;
            }

            public PizzaBuilder withOptionalMushroom(bool mushroom)
            {
                this.mushroom = mushroom;
                return this;
            }

            public PizzaBuilder withOptionalBacon(bool bacon)
            {
                this.bacon = bacon;
                return this;
            }

            public PizzaBuilder withOptionalMozarella(bool mozarella)
            {
                this.mozarella = mozarella;
                return this;
            }

            public Pizza buildPizza()
            {
                return new Pizza(this);
            }
        }
    }
}