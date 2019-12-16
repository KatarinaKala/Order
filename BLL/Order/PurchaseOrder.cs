using System;

namespace BLL.Order
{
    public class PurchaseOrder : Order
    {
        //Records the date when order was sent to the seller
        //Is responsible for tracking Payments made and refunds received
        public DateTime DateSent { get; set; }
        
        //Track ProductInstances
        public void ProcessReceiptEvent(ProductInstances productInstances)
        {
            //Records that a number of ProductInstances have been received and accepted or rejected
        }

        //Track Payments
        public void ProcessInvoiceEvent(Payment payment)
        {
            //Kas see tuleb overrideda?
            //Records that an invoice has been received for this PurchaseOrder
        }

        public void ProcessMakePaymentEvent(Payment payment)
        {
            //Records that a Payment has been made against this PurchaseOrder
        }

        public void ProcessAcceptRefundEvent(Payment payment)
        {
            //Records that a refund has been received against this PurchaseOrder 
        }
    }
}