using System.Collections.Generic;
using ForgeShopDB.Entities;
using ForgeShopDB.Models;

namespace ForgeShopDB.Entities
{
    public class DBMapper : IMapper


    {
    

        public Models.Customer ParseCustomer(Customer customer)
        {
            return new Models.Customer(){
                fName = customer.Fname,
                lName = customer.Lname,
                eMail = customer.Email,
                userName = customer.Username,
                pin = customer.Pin,
                address = customer.Address,
                street = customer.Street,
                state = customer.State,
                city = customer.City,
                zipCode = customer.Zipcode,
                id = customer.Id



            };
        }

        public Customer ParseCustomer(Models.Customer customer)
        {
            return new Entities.Customer()
            {
                Fname = customer.fName,
                Lname = customer.lName,
                Email = customer.eMail,
                Username = customer.userName,
                Pin = customer.pin,
                Address = customer.address,
                Street = customer.street,
                State = customer.state,
                City = customer.city,
                Zipcode = customer.zipCode,
                Id = customer.id
            };
        }

        public Models.Inventory ParseInventory(Inventory inventory)
        {
            return new Models.Inventory()
            {
                id = inventory.Id,
                storeId = inventory.Storeid,
                ball = inventory.Ballhammer,
                flat = inventory.Flathammer,
                cross = inventory.Crosshammer,
                apronblack = inventory.Apronblack,
                apronbrown = inventory.Apronbrown,
                anvilsmall = inventory.Anvilsmall,
                anvilmed = inventory.Anvilmed,
                anvillarge = inventory.Anvillarge,
            };
        }

        public Entities.Inventory ParseInventory(Models.Inventory inventory)
        {
            return new Entities.Inventory()
            {
                Id = inventory.id,
                Storeid = inventory.storeId,
                Ballhammer = inventory.ball,
                Flathammer = inventory.flat,
                Crosshammer = inventory.cross,
                Apronblack = inventory.apronblack,
                Apronbrown = inventory.apronbrown,
                Anvilsmall = inventory.anvilsmall,
                Anvilmed = inventory.anvilmed,
                Anvillarge = inventory.anvillarge
            };
        }

        public Models.Location ParseLocation(Location location)
        {
            return new Models.Location()
            {
                id = location.Id,
                name = location.Name,
                address = location.Address
            };
        }

        public Location ParseLocation(Models.Location location)
        {
            return new Entities.Location()
            {
                Id = location.id,
                Name = location.name,
                Address = location.address
            };
        }

        public Models.Manager ParseManager(Entities.Manager manager)
        {
            return new Models.Manager()
            {
                id = manager.Id,
                fName = manager.Fname,
                lName = manager.Lname,
                userName = manager.Username,
                pin = manager.Pin,
                storeId = manager.Storeid

            };
        }

        public Entities.Manager ParseManager(Models.Manager manager)
        {
            return new Entities.Manager()
            {
                Id = manager.id,
                Fname = manager.fName,
                Lname = manager.lName,
                Username = manager.userName,
                Pin = manager.pin,
                Storeid = manager.storeId

            };
            
        }

        public Order ParseOrder(Orders orders)
        {
            
            return new Order()
            {
                id = orders.Id,
                storeId = orders.Storeid,
                custId = orders.Custid,
                price = orders.Price,
                ball = orders.Ballhammer,
                cross = orders.Crosshammer,
                flat = orders.Flathammer,
                apronblack = orders.Apronblack,
                apronbrown = orders.Apronbrown,
                aviltwenty = orders.Aviltwenty,
                anvilforty = orders.Anvilforty,
                anvilhundred = orders.Anvilhundred,
                date = orders.Date

                
            };
        }

        public Orders ParseOrder(Order order)
        {
            return new Orders()
            {
                Id = order.id,
                Storeid = order.storeId,
                Custid = order.custId,
                Price = order.price,
                Ballhammer = order.ball,
                Crosshammer = order.cross,
                Flathammer = order.flat,
                Apronblack = order.apronblack,
                Apronbrown = order.apronbrown,
                Aviltwenty = order.aviltwenty,
                Anvilforty = order.anvilforty,
                Anvilhundred = order.anvilhundred,
                Date = order.date

            };
        }

        public Product ParseProduct(Products products)
        {
           return new Product()
           {
               id = products.Id,
               name = products.Name,
               description = products.Description,
               price = products.Price
           };
        }

        public Products ParseProduct(Product product)
        {
            return new Products()
            {
                Id = product.id,
                Name = product.name,
                Description = product.description,
                Price = product.price
            };
            
        }
    }
}