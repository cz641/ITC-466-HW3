using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW3EX1.Tests
{
    [TestClass]
    public class HW3EX1
    {
        [TestMethod]
        public void CardChargeTest()
        {
            var chargeCard = new CardCharge.CardCharge();
    
        }

        [TestMethod]
        public void CustomerNotificationTest()
        {
            var NotifyCustomer = new CustomerNotification();
           
        }

        [TestMethod]
        public void InventoryReservationTest()
        {
            var InventoryReservation = new InventoryReeservation();
            

        }

        [TestMethod]
        public void CashTransactionsTest()
        {
            var CashTransactions = new TransacationOfCash();
            
        }

        [TestMethod]
        public void POStransactionsTest()
        {
            var POStransactions = new PointOfSalesTransaction();
          
        }
    }

    internal class PointOfSalesTransaction
    {
        public PointOfSalesTransaction()
        {
        }
    }

    internal class TransacationOfCash
    {
        public TransacationOfCash()
        {
        }
    }

    internal class InventoryReeservation
    {
        public InventoryReeservation()
        {
        }
    }

    internal class CustomerNotification
    {
        public CustomerNotification()
        {
        }
    }

    internal class chrageCard
    {
        public chrageCard()
        {
        }
    }
}
