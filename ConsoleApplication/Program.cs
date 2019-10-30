using System;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet ShopDB = new DataSet();
            DataTable Orders = new DataTable("Orders");
            DataTable Customers = new DataTable("Customers");
            DataTable Employees = new DataTable("Employees");
            DataTable OrderDetails = new DataTable("OrderDetails");
            DataTable Products = new DataTable("Products");
            ShopDB.Tables.Add(Orders);
            ShopDB.Tables.Add(Customers);
            ShopDB.Tables.Add(Employees);
            ShopDB.Tables.Add(OrderDetails);
            ShopDB.Tables.Add(Products);
            Orders.PrimaryKey = new DataColumn[] { Orders.Columns["Id"] };
            Customers.PrimaryKey = new DataColumn[] { Orders.Columns["Id"] };
            OrderDetails.PrimaryKey = new DataColumn[] { Orders.Columns["Id"] };
            Employees.PrimaryKey = new DataColumn[] { Orders.Columns["Id"] };
            Products.PrimaryKey = new DataColumn[] { Orders.Columns["Id"] };
            DataColumn cust_foreignkey = new DataColumn("CustomerId", Type.GetType("System.Int32"));
            cust_foreignkey.Unique = true;
            cust_foreignkey.AllowDBNull = false;
            cust_foreignkey.AutoIncrement = true;
            cust_foreignkey.AutoIncrementSeed = 1;
            cust_foreignkey.AutoIncrementStep = 1;
            DataColumn emp_foreignkey = new DataColumn("EmployeeId", Type.GetType("System.Int32"));
            emp_foreignkey.Unique = true;
            emp_foreignkey.AllowDBNull = false;
            emp_foreignkey.AutoIncrement = true;
            emp_foreignkey.AutoIncrementSeed = 1;
            emp_foreignkey.AutoIncrementStep = 1;
            DataColumn order_foreignkey = new DataColumn("OrderId", Type.GetType("System.Int32"));
            order_foreignkey.Unique = true;
            order_foreignkey.AllowDBNull = false;
            order_foreignkey.AutoIncrement = true;
            order_foreignkey.AutoIncrementSeed = 1;
            order_foreignkey.AutoIncrementStep = 1;
            DataColumn prod_foreignkey = new DataColumn("ProductId", Type.GetType("System.Int32"));
            prod_foreignkey.Unique = true;
            prod_foreignkey.AllowDBNull = false;
            prod_foreignkey.AutoIncrement = true;
            prod_foreignkey.AutoIncrementSeed = 1;
            prod_foreignkey.AutoIncrementStep = 1;
            DataColumn onameColumn = new DataColumn("Name", Type.GetType("System.String"));
            DataColumn odPrice = new DataColumn("Price", Type.GetType("System.Int32"));
            DataColumn pnameColumn = new DataColumn("Name", Type.GetType("System.String"));
            DataColumn cnameColumn = new DataColumn("Name", Type.GetType("System.String"));
            DataColumn enameColumn = new DataColumn("Name", Type.GetType("System.String"));
            Orders.Columns.Add(onameColumn);
            OrderDetails.Columns.Add(odPrice);
            Customers.Columns.Add(cnameColumn);
            Employees.Columns.Add(enameColumn);
            Products.Columns.Add(pnameColumn);
            Orders.Columns.Add(cust_foreignkey);
            Orders.Columns.Add(emp_foreignkey);
            OrderDetails.Columns.Add(order_foreignkey);
            OrderDetails.Columns.Add(prod_foreignkey);
            DataRow OrderRow1 = Orders.NewRow();
            OrderRow1.ItemArray = new object[] { "001", null, null };
            Orders.Rows.Add(OrderRow1);
            DataRow OrderDetailsRow1 = OrderDetails.NewRow();
            OrderDetailsRow1.ItemArray = new object[] { 122, null, null };
            OrderDetails.Rows.Add(OrderDetailsRow1);
            DataRow CustomersRow1 = Customers.NewRow();
            CustomersRow1.ItemArray = new object[] { "Egor" };
            Customers.Rows.Add(CustomersRow1);
            DataRow EmployeesRow1 = Employees.NewRow();
            EmployeesRow1.ItemArray = new object[] { "Amazon" };
            Employees.Rows.Add(EmployeesRow1);
            DataRow ProductsRow1 = Products.NewRow();
            ProductsRow1.ItemArray = new object[] { "Laptop" };
            Products.Rows.Add(ProductsRow1);
            Console.WriteLine("\tOrders:");
            foreach (DataRow r in Orders.Rows)
            {
                foreach (var cell in r.ItemArray)
                    Console.Write("\t{0}", cell); 
            }
            Console.WriteLine();
            Console.WriteLine("\tOrderDetails");
            foreach (DataRow r in OrderDetails.Rows)
            {
                foreach (var cell in r.ItemArray)
                    Console.Write("\t{0}", cell);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("\tCustomers:");
            foreach (DataRow r in Customers.Rows)
            {
                foreach (var cell in r.ItemArray)
                    Console.Write("\t{0}", cell);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("\tEmployees:");
            foreach (DataRow r in Employees.Rows)
            {
                foreach (var cell in r.ItemArray)
                    Console.Write("\t{0}", cell);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("\tProducts:");
            foreach (DataRow r in Products.Rows)
            {
                foreach (var cell in r.ItemArray)
                    Console.Write("\t{0}", cell);
                Console.WriteLine();
            }
            Console.Read();
            //Console.WriteLine();
        }
    }
}
