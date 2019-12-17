using System;
using System.Collections.Generic;

namespace BLL.Order
{
    //Section 9.5
    public class OrderLine
    {
        //Peab viitama kaubale, mida tellitakse
        private int _numberOrdered;
        private string _productName;
        public string? Description { get; set; }
        public string? Comment { get; set; }
        private double _unitPrice;
        public DateTime ExpectedDeliveryDate { get; set; }

        private OrderLineIdentifier OrderLineIdentifier;
        private List<TaxOnLine>? TaxOnLines;
        public List<ChargeLine>? ChargeLines;
        private DeliveryReceiver? DeliveryReceiver;

        public OrderLine(int numberOrdered, string productName, double unitPrice)
        {
            _numberOrdered = numberOrdered;
            _productName = productName;
            _unitPrice = unitPrice;
        }

        //Manage identification
        public OrderLineIdentifier GetOrderLineIdentifier()
        {
            return OrderLineIdentifier;
        }

        //Manage number ordered
        public int GetNumberOrdered()
        {
            //Returns the number of ProductInstances recorded by the OrderLine 
            return _numberOrdered;
        }
        
        public void IncrementNumberOrdered(int number)
        {
            //Increments (suurenda) the number of ProductInstances recorded by the OrderLine
            _numberOrdered += 1;
        }

        public void DecrementNumberOrdered(int number)
        {
            //Decrements the number of ProductInstances recorded by the OrderLine
            _numberOrdered -= 1;
        }

        //Manage Parties
        public void AddDeliveryReceiver(DeliveryReceiver receiver)
        {
            //Adds a DeliveryReceiver to the OrderLine
            DeliveryReceiver = receiver;
        }

        public DeliveryReceiver GetDeliveryReceiver()
        {
            //Return the DeliveryReceiver for this OrderLine
            return DeliveryReceiver;
        }

        public void RemoveDeliveryReceiver()
        {
            //Remove the DeliveryReceiver from the OrderLine
            DeliveryReceiver = null;
        }

        //Manage tax
        public void AddTax(TaxOnLine tax)
        {
            //Adds tax to the OrderLine
            TaxOnLines.Add(tax);
        }

        public List<TaxOnLine> GetTaxes()
        {
            //Return all the TaxOnlines for the OrderLine
            return TaxOnLines;
        }

        public void RemoveTax(TaxOnLine tax)
        {
            //Remove a TaxOnLine from the OrderLine
            TaxOnLines.Remove(tax);
        }

        //Manage ChargeLines
        public void AddChargeLine(ChargeLine line)
        {
            //Add a ChargeLine to the OrderLine
            ChargeLines.Add(line);
        }

        public List<ChargeLine> GetChargeLines()
        {
            //Return all the ChargeLines associated with this OrderLine
            return ChargeLines;
        }

        public void RemoveChargeLine(OrderLineIdentifier id)
        {
            //Remove a ChargeLine from the OrderLine
            foreach (var chargeLine in ChargeLines)
            {
                if (chargeLine.OrderLineIdentifier == id)
                {
                    ChargeLines.Remove(chargeLine);
                }
            }
        }
    }
}