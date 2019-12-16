using System;

namespace BLL.Order
{
    public class SalesOrder : Order
    {
        //Details of an initiating PurchaseOrder
        //Is responsible for tracking Payments received and refunds made
        public DateTime DatePurchaseOrderReceived { get; set; }
        public string CustomerPurchaseOrderReference { get; set; }

        //Track ProductInstances
        public void ProcessDespatchEvent(ProductInstances productInstances)
        {
            //Records that the specified number of ProductInstances have been dispatched 
        }

        //Track Payments
        public void ProcessInvoiceEvent(Payment payment)
        {
            //Kas see tuleb overrideda?
            //Records that an invoice has been raised for this SalesOrder
        }

        public void ProcessAcceptPaymentEvent(Payment payment)
        {
            //Records that a Payment has been received for this SalesOrder
        }

        public void ProcessMakeRefundEvent(Payment payment)
        {
            //Records that a refund has been made against this SalesOrder
        }
    }
}