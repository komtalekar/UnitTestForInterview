using System;
using System.Collections.Generic;
using System.Text;

namespace CodepadTestSample
{
    public class Calculator
        {

           private readonly IInventoryRepo _inventoryRepo;

           public Calculator(IInventoryRepo inventoryRepo)
           {
               _inventoryRepo = inventoryRepo;
            }

            public bool IsStockRunningLow(int productId)
            {
                var currentStock = _inventoryRepo.GetStock(productId);
    
                return currentStock < 10;
            }

        
        
            public double CalculateTotal(double price, int quantity)
            {
                return price * quantity;
            }
        
            public double CalculateDiscount(int quantity)
            {
                if (quantity >= 1000)
                    return 0.20;
        
                if (quantity >= 100)
                    return 0.10;
        
                return 0;
            }
        
            public double CalculateFinalTotal(double price, int quantity)
            {
                var total = CalculateTotal(price, quantity);
                var discount = CalculateDiscount(quantity);
        
                return total * (1 - discount);
            }
        }

}
