using System;
using BLL.Party;

namespace BLL.Order
{
    public class PurchaseOrder : Order
    {
        //Is responsible for tracking Payments made and refunds received
        
        //Records the date when order was sent to the seller
        public DateTime DateSent { get; set; }

        //Track ProductInstances
        public void ProcessReceiptEvent()
        {
            //Records that a number of ProductInstances have been received and accepted or rejected
        }

        //Track Payments
        public void ProcessInvoiceEvent()
        {
            //Kas see tuleb overrideda?
            //Records that an invoice has been received for this PurchaseOrder
        }

        public void ProcessMakePaymentEvent()
        {
            //Records that a Payment has been made against this PurchaseOrder
        }

        public void ProcessAcceptRefundEvent()
        {
            //Records that a refund has been received against this PurchaseOrder 
        }
    }
}