using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.ProductLibrary
{
    public class Assignment1
    {
        public double CalculateCostPerPerson(double mileage, double amountPerLitre, int distanceOneWay)
        {
            int totalDistance = distanceOneWay * 2;
            double totalExpense = (totalDistance / mileage) * amountPerLitre;
            double expensePerPerson = totalExpense / 4;
            return expensePerPerson;
        }
    }
}
