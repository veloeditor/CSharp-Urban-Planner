using System;
using System.Collections.Generic;

namespace Planner
{
    class Building
    {
        private string _address = "";
    
        private string _designer = "Brian Wilson";
        private DateTime _dateConstructed = new DateTime();
       
        private string _owner;
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume 
        { 
            get 
            {
                return Width * Depth * (3 * Stories);
            }
        }

        //methods
        public Building(string buildingAddress){
            _address = buildingAddress; 
        }

        public void Construct() {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase (string buyerName) {
            _owner = buyerName;
        }

        public string GetAddress() {
            return _address;
        }

        public DateTime GetDateConstructed() {
            return _dateConstructed;
        }

        public string GetDesigner() {
            return _designer;
        }

        public string GetOwner() {
            return _owner;
        }


    }
}
