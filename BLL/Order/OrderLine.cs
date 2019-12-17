using System;
using System.Collections.Generic;

namespace BLL.Order
{
    //Section 9.5
    public class OrderLine
    {
        //Peab viitama kaubale, mida tellitakse
        public ProductIdentifier ProductType { get; set; }
        public SerialNumber SerialNumber { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public int NumberOrdered { get; set; }
        public Money UnitPrice { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        
        public OrderLineIdentifier OrderLineIdentifier { get; set; }

        //Manage identification
        public OrderLineIdentifier GetOrderLineIdentifier()
        {
            return OrderLineIdentifier;
        }

        //Manage number ordered
        public void IncrementNumberOrdered(int number)
        {
            //Increments the number of ProductInstances recorded by the OrderLine
            throw new NotImplementedException();
        }

        public int GetNumberOrdered()
        {
           //Returns the number of ProductInstances recorded by the OrderLine 
           throw new NotImplementedException();
        }

        public void DecrementNumberOrdered(int number)
        {
            //Decrements the number of ProductInstances recorded by the OrderLine
            throw new NotImplementedException();
        }

        //Manage Parties
        public void AddDeliveryReceiver(DeliveryReceiver receiver)
        {
            //Adds a DeliveryReceiver to the OrderLine
            throw new NotImplementedException();
        }

        public DeliveryReceiver GetDeliveryReceiver()
        {
            //Return the DeliveryReceiver for this OrderLine
            throw new NotImplementedException();
        }

        public void RemoveDeliveryReceiver()
        {
            //Remove the DeliveryReceiver from the OrderLine
            throw new NotImplementedException();
        }

        //Manage tax
        public void AddTax(TaxOnLine tax)
        {
            //Adds tax to the OrderLine
            throw new NotImplementedException();
        }

        public List<TaxOnLine> GetTaxes()
        {
            //Return all the TaxOnlines for the OrderLine
            throw new NotImplementedException();
        }

        public void RemoveTax(TaxOnLine tax)
        {
            //Remove a TaxOnLine from the OrderLine
            throw new NotImplementedException();
        }

        //Manage ChargeLines
        public void AddChargeLine(ChargeLine line)
        {
            //Add a ChargeLine to the OrderLine
            throw new NotImplementedException();
        }

        public List<ChargeLine> GetChargeLines()
        {
            //Return all the ChargeLines associated with this OrderLine
            throw new NotImplementedException();
        }

        public void RemoveChargeLine(OrderLineIdentifier id)
        {
            //Remove a ChargeLine from the OrderLine
            throw new NotImplementedException();
        }

        //Clone itself for amendment purposes
        public OrderLine Clone()
        {
            //Makes a copy of the OrderLine and any associated objects that can be used to create amended OrderLine
            
            throw new NotImplementedException();
        }
    }
}