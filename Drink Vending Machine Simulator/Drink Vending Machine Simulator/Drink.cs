using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drink_Vending_Machine_Simulator
{
    class Drink
    {
        // Fields to represent the drinks
        private string _name;       // The drinks name
        private decimal _cost;      // The drinks cost
        private int _amount;        // The initial number of drinks
                
        // Constructor
        public Drink()
        {
            _name = "";
            _cost = 0m;
            _amount = 0;
        }

        // Constructor
        public Drink(string name, decimal cost, int amount)
        {
            _name = name;
            _cost = cost;
            _amount = amount;
        }

        // Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        } // end Name Accessor

        // Cost property
        public decimal Cost
        {
            get { return _cost; }
            set { _cost = value; }
        } // end Cost Accessor

        // Amount property
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        } // end Cost Accessor

        // Amount property (read-only)
        public int StartAmount
        {
            get { return _amount; }
        }
    }
}
