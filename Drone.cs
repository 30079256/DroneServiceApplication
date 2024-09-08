using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

// 6.1	Create a separate class file to hold the data items of the Drone.
// Use separate getter and setter methods, ensure the attributes are private and the accessor methods are public.
// Add a display method that returns a string for Client Name and Service Cost.
// Add suitable code to the Client Name and Service Problem accessor methods so the data is formatted as Title case or Sentence case.
// Save the class as “Drone.cs”.

namespace IcarusDrones
{
    internal class Drone
    {
        private string _clientName;
        private string _droneModel;
        private string _serviceProblem;
        private double _serviceCost;
        private int? _serviceTag;

        public string GetClientName()
        {
            return _clientName;
        }

        public void SetClientName(string clientName)
        {
            if (clientName == null)
            {
                _clientName = "Unknown";
            }
            else
            {
                _clientName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(clientName); 
            }
        }

        public string GetDroneModel()
        {
            return _droneModel;
        }

        public void SetDroneModel(string droneModel)
        {
            _droneModel = droneModel;
        }

        public string GetServiceProblem()
        {
            return _serviceProblem;
        }

        public void SetServiceProblem(string serviceProblem)
        {
            var sentenceRegex = new Regex(@"(^[a-z])|[?!.:;]\s+(.)", RegexOptions.ExplicitCapture);
            _serviceProblem = sentenceRegex.Replace(serviceProblem.ToLower(), s => s.Value.ToUpper());            
        }

        public string GetServiceCost() 
        { 
            return string.Format("{0:0.00}", _serviceCost);
        }

        public void SetServiceCost(double serviceCost)
        {
            _serviceCost = serviceCost;
        } 

        public static string DisplayNameAndCost(string clientName, string serviceCost) 
        {
            return clientName + " $" + serviceCost;
        }

        public void IncreaseServiceCost()
        {            
            _serviceCost = Math.Round(_serviceCost * 1.15, 2);
        }

        internal void SetServiceTag(int? value)
        {
            _serviceTag = value;
        }

        internal int? GetServiceTag()
        {
            return _serviceTag;
        }
    }
}
