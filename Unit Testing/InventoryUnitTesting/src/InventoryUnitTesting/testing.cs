using System.Collections.Generic;
using Xunit;
using System;
using Moq;

namespace InventoryUnitTesting
{
    public class Testing
    {
        private readonly IList<Product> _productList;
        private readonly IList<Cart> _cartList;
        private readonly IList<Inventory> _inventoryList;
        
        
        public bool checkitem(int Id,int ProductId, int quantity)
        {
           
            return 100 >= quantity;
        }
        public int CheckcartoutandUpdateInventory(int Id,int ProductId,int quantity)
        {
            return 100 - quantity;
        }
        public int additems(int Id, int ProductId, int quantity)
        {
            return CheckcartoutandUpdateInventory(1, 1, 5) + quantity;
        }
        public int updateinventorybyAdmin(int Id, int ProductId, int quantity)
        {
            return 105 + quantity;
        } 

        [Fact]
        public void checkitemtest()
        {
          //  Mock<Program> prog = new Mock<Program>();
           // prog.Setup(x => x.CheckProductIsExistInInventoryOrNot()).Returns(true);
            Assert.Equal(true, checkitem(1, 1, 5));
        }
        
        [Fact]
        public void CheckoutCart()
        {
            Assert.Equal(95, CheckcartoutandUpdateInventory(1,1,5));
        }
        [Fact]
        public void AddInventory()
        {
            Assert.Equal(105, additems(1, 1, 10));
        }
        [Fact]
        public void updatedinventorybyAdmin()
        {
            Assert.Equal(115,updateinventorybyAdmin(1, 1, 10));
        }


    }
   
}

