using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class OrderClass
    {
        private string senderId = string.Empty;
        private int cardNo = 0;
        private int quantity = 0;
        private double unitPrice = 0;

        public OrderClass(string senderId, int cardNo, int quantity, int unitPrice) 
        {
            this.senderId = senderId;
            this.cardNo = cardNo;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }

        public string getSenderId() { return senderId; }

        public int getCardNo() { return cardNo; }

        public int getQuantity() { return quantity; }

        public double getUnitPrice() { return unitPrice; }

    }

}
