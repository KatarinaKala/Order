using System;
using BLL.Party;

namespace BLL.Order
{
    public class SalesOrder : Order
    {
        //Is responsible for tracking Payments received and refunds made
        
        //Details of an initiating PurchaseOrder
        public DateTime DatePurchaseOrderReceived { get; set; }
        public string CustomerPurchaseOrderReference { get; set; }

        
        //Track ProductInstances
        public void ProcessDespatchEvent()
        {
            //Records that the specified number of ProductInstances have been dispatched 
        }

        //Track Payments
        public void ProcessInvoiceEvent()
        {
            //Kas see tuleb overrideda?
            //Records that an invoice has been raised for this SalesOrder
        }

        public void ProcessAcceptPaymentEvent()
        {
            //Records that a Payment has been received for this SalesOrder
        }

        public void ProcessMakeRefundEvent()
        {
            //Records that a refund has been made against this SalesOrder
        }
    }
}