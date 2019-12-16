using System;
using System.Collections.Generic;

namespace Order
{
    //Section 9.5
    public class OrderLine
    {
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
        }

        public int GetNumberOrdered()
        {
           //Returns the number of ProductInstances recorded by the OrderLine 
        }

        public void DecrementNumberOrdered(int number)
        {
            //Decrements the number of ProductInstances recorded by the OrderLine
        }

        //Manage Parties
        public void AddDeliveryReceiver(DeliveryReceiver receiver)
        {
            //Adds a DeliveryReceiver to the OrderLine
        }

        public DeliveryReceiver GetDeliveryReceiver()
        {
            //Return the DeliveryReceiver for this OrderLine
        }

        public void RemoveDeliveryReceiver()
        {
            //Remove the DeliveryReceiver from the OrderLine
        }

        //Manage tax
        public void AddTax(TaxOnLine tax)
        {
            //Adds tax to the OrderLine
        }

        public List<TaxOnLine> GetTaxes()
        {
            //Return all the TaxOnlines for the OrderLine
        }

        public void RemoveTax(TaxOnLine tax)
        {
            //Remove a TaxOnLine from the OrderLine
        }

        //Manage ChargeLines
        public void AddChargeLine(ChargeLine line)
        {
            //Add a ChargeLine to the OrderLine
        }

        public List<ChargeLine> GetChargeLines()
        {
            //Return all the ChargeLines associated with this OrderLine
        }

        public void RemoveChargeLine(OrderLineIdentifier id)
        {
            //Remove a ChargeLine from the OrderLine
        }

        //Clone itself for amendment purposes
        public OrderLine Clone()
        {
            //Makes a copy of the OrderLine and any associated objects that can be used to create amended OrderLine
        }
    }
}