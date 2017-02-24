using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace product_manage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program prog = new Program();
            using (var db = new Context())
            {              
                db.Database.Migrate();               
            };
            prog.SlectTable();
        }
        private void SlectTable()
        {           
            string ch = "";
            do
            {
                Console.WriteLine("\n\n\n Select Table ");
                Console.WriteLine("\n1. Product Table");
                Console.WriteLine("2. Update Table");
                Console.WriteLine("for Exit(y/n)?");
                Console.WriteLine("Enter your Choice");
                ch = Console.ReadLine().ElementAt(0) + "";
                switch (ch)
                {
                    case "1":                        
                        SelectOperations("Product");
                        break;
                    case "2":                      
                       SelectOperations("Update");
                        break;
                    case "y":
                        break;
                    case "n":
                        break;
                    default:
                        Console.WriteLine("You Select Rong Option \n Try Again \n\n");
                        break;
                }
            }while (ch != "y");
        }
        private void SelectOperations(string TableChoice)
        {
            string ch = null;
            do
            {
                Console.WriteLine("\n Select Your Operation");
                Console.WriteLine("1. Add Row");
                Console.WriteLine("2. update Row");
                Console.WriteLine("3. Remove Row");
                Console.WriteLine("for Exit(y/n)");
                Console.WriteLine("\n Enter your choice");
                ch = Console.ReadLine().ElementAt(0)+"";              
                switch (ch)
                {
                    case  "1":                        
                        AddData(TableChoice);
                        break;
                    case  "2":                       
                        UpdateData(TableChoice);
                        break;
                    case  "3":                       
                        RemoveData(TableChoice);
                        break;
                    case "y":
                        break;
                    case "n":
                        break;
                    default:
                        Console.WriteLine("You Select Rong Option \n Try Again");
                        break;
                }
            } while (ch != "y");
        }

        private void AddData(string TableChoice)
        {
            try
            {


                int id;
                string Name, Description, HomePageURL;        
                Console.WriteLine("Enter Name :: ");
                Name = Console.ReadLine();
                Console.WriteLine("Enter Description :: ");
                Description = Console.ReadLine();
                using (var db = new Context())
                {
                    if (TableChoice == "Product")
                    {
                        Console.WriteLine("Enter HomePageURl :: ");
                        HomePageURL = Console.ReadLine().ToString();
                        db.Product.Add(new Product { name = Name, description = Description, HomePageUrl = HomePageURL });
                        var result = db.SaveChanges();
                        Console.WriteLine("\n " + result + "row Add successfully");
                    }

                    else
                    {
                        try
                        {
                            Console.WriteLine("Enter Product Id ::");
                            id = int.Parse(Console.ReadLine());
                            db.UpdateProduct.Add(new UpdateProduct { name = Name, description = Description, productid = id });
                            var result = db.SaveChanges();
                            Console.WriteLine(result + " row Add successfully");
                        }
                        catch(DbUpdateException ex)
                        {
                            Console.WriteLine("\n \t Poduct Id is not Exited in product Table");
                        }
                        
                    }
                }
            }
            catch (FormatException ex)
            { 
                 Console.WriteLine("Error :\n Not Enter Proper Data in proper Formate Try Again! \n");
            }
        }

        public void UpdateData(string TableChoice)
        {       
                int updateid, productid;
                string Name, Description, HomePageURL;
            try
            {
                using (var db = new Context())
                {
                   
                    if (TableChoice == "Product")
                    {
                        
                        Console.WriteLine("Enter Product Id ::");
                        productid = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Product Name :: ");
                        Name = Console.ReadLine().ToString();
                        Console.WriteLine("Enter product Description :: ");
                        Description = Console.ReadLine().ToString();
                        Console.WriteLine("Enter HomePageURl :: ");
                        HomePageURL = Console.ReadLine().ToString();
                        db.Product.Update(new Product { id = productid, name = Name, description = Description, HomePageUrl = HomePageURL });
                        var result = db.SaveChanges();
                        Console.WriteLine(result + "  row Update successfully");
                    }
                    else
                    {

                        Console.WriteLine("Enter Update Id ::");
                        updateid = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Product Id ::");
                        productid = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Product Name :: ");
                        Name = Console.ReadLine().ToString();
                        Console.WriteLine("Enter product Description :: ");
                        Description = Console.ReadLine().ToString();
                        db.UpdateProduct.Update(new UpdateProduct { name = Name, description = Description, productid = productid, id = updateid });
                        var result = db.SaveChanges();
                        Console.WriteLine(result + " row Update successfully");
                    }
                }
        }  
        catch (DbUpdateException ex)
        {
            Console.WriteLine("\tError :\n Id Is Not Exited Try Again!");
        } 
        catch(FormatException ex)
        {
            Console.WriteLine("\tError :\n Not Enter Proper Data in Formate");
        }              
     }
        public void RemoveData(string TableChoice)
        {
            try
            {
                using (var db = new Context())
                {
                    if (TableChoice == "Product")
                    {
                        Console.WriteLine("Enter product Id ::");
                        int Productid = int.Parse(Console.ReadLine());
                        db.Product.Remove(new Product { id = Productid });
                        var result = db.SaveChanges();
                        Console.WriteLine(result + " row Remove successfully");
                    }
                    else
                    {
                        Console.WriteLine("Enter Update Id ::");
                        int Updateid = int.Parse(Console.ReadLine());
                        db.UpdateProduct.Remove(new UpdateProduct { id = Updateid });
                        var result = db.SaveChanges();
                        Console.WriteLine(result + " row Remove successfully");
                    }
                }
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine("\tError :\n Id Is Not Exited Try Again!");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("\tError :\n Not Enter Proper Data in Formate");
            }           
        }  
    }
}



      
