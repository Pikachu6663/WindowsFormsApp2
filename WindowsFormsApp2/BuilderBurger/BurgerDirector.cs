using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.DBCon;
using WindowsFormsApp2.BuilderBurger;

namespace WindowsFormsApp2.BuilderBurger
{
    public class BurgerDirector

    {
        private readonly IBurgerBuilder _builder;
        public BurgerDirector(IBurgerBuilder builder)
        {
            _builder = builder;
        }
        public void BuildDefault()
        {
            _builder
                .AddCheese()
                .AddTomato().
                AddPickles();
        }
        public void BuildWithBeacon()
        {
            _builder
            .AddCheese()
           .AddTomato().
            AddPickles();
        }
    } }
