using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ЛР5.DBCon;

namespace ЛР5.BuilderBurger
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private Burger _burger;
        public BurgerBuilder() 
        { 
            _burger = new Burger();
        }
        public IBurgerBuilder AddBacon()
        {
            _burger.Bacon = true;
            return this;
        }

        public IBurgerBuilder AddCheese()
        {
            _burger.Cheese = true;
            return this;
        }

        public IBurgerBuilder AddLetuce()
        {
            _burger.Letuce = true;
            return this;
        }

        public IBurgerBuilder AddPickles()
        {
            _burger.Pickles = true;
            return this;
        }

        public IBurgerBuilder AddTomato()
        {
            _burger.Tomato = true;
            return this;
        }

        public Burger GetBurgers()
        {
            Burger burger = new Burger();
            _burger = new Burger();
            return burger;
        }
    }
}
