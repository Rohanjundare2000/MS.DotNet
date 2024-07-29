
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace Lab_Exam
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message) { }
    }

    public class Customer
    {
        private int _customerId;
        private string _customerName;
        private string _email;
        public int OrderId { get; set; }

        public int CustomerId
        {
            get { return _customerId; }
            set
            {
                if (value <= 0)
                    throw new ValidationException("CustomerID must be greater than 0");
                _customerId = value;
            }
        }

        public string CustomerName
        {
            get { return _customerName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ValidationException("CustomerName can not be null");
                _customerName = value;
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (!Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    throw new ValidationException("InValid Email Format");
                _email = value;
            }
        }


        public override string ToString()
        {
            return $"CustomerId: {CustomerId}, CustomerName: {CustomerName}, Email:{Email}, OrderId:{OrderId}";
        }


    }

    public class Order
    {
        private int _orderId;
        private string _orderDetails;

        public int OrderId
        {
            get => _orderId;

            set
            {
                if (value <= 0)
                {
                    throw new ValidationException("OrderId must be Greater than zero");
                }
                _orderId = value;
            }
        }

        public string OrderDetails
        {
            get => _orderDetails;

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ValidationException("orderDetails can not be null or empty");
                _orderDetails = value;
            }

        }

        public override string ToString()
        {
            return $"OrderId:{OrderId}, OrderDetails:{OrderDetails}";
        }
    }

    public class TestCode
    {
        public static List<Customer> Customers = new List<Customer>();
        public static List<Order> Orders = new List<Order>();

        public static void InitiateRecords()
        {
            Orders.AddRange(new List<Order>
            {
                new Order{OrderId= 1, OrderDetails="Ordre 1 details"},
                 new Order{OrderId= 2, OrderDetails="Ordre 2 details"},
                  new Order{OrderId= 3, OrderDetails="Ordre 3 details"},
                   new Order{OrderId= 4, OrderDetails="Ordre 4 details"},
                    new Order{OrderId= 5, OrderDetails="Ordre 5 details"}

            });

            Customers.AddRange(new List<Customer>
            {

                new Customer {CustomerId= 1, CustomerName="aksay", Email="aksay@gmail.com", OrderId=1},
                new Customer {CustomerId= 2, CustomerName="rohan", Email="rohan@gmail.com", OrderId=2},
                new Customer {CustomerId= 3, CustomerName="revati", Email="revati@gmail.com", OrderId=3},
                new Customer {CustomerId= 4, CustomerName="soham", Email="soham@gmail.com", OrderId=4},
                new Customer {CustomerId= 5, CustomerName="sakshi", Email="sakshi@gmail.com", OrderId=5},
                new Customer {CustomerId= 6, CustomerName="jay", Email="jay@gmail.com", OrderId=1},
                new Customer {CustomerId= 7, CustomerName="om", Email="om@gmail.com", OrderId=2},
                new Customer {CustomerId= 8, CustomerName="sai", Email="sai@gmail.com", OrderId=3},
                new Customer {CustomerId= 9, CustomerName="ravi", Email="ravi@gmail.com", OrderId=4},
                new Customer {CustomerId= 10, CustomerName="tai", Email="tai@gmail.com", OrderId=5},
            });
        }

        public static void Main()
        {
            InitiateRecords();

            var allCustomersQuery = from c in Customers select c;

            foreach (var customer in allCustomersQuery)
            {
                Console.WriteLine(customer);
            }

            var allCustomersLamda = Customers.Select(c => c);
            foreach (var customer in allCustomersLamda)
            {
                Console.WriteLine(customer);
            }


            var customerIdNameQuery = from c in Customers select new { c.CustomerId, c.CustomerName };
            foreach (var item in customerIdNameQuery)
            {
                Console.WriteLine($"CustomerId: {item.CustomerId}, CustomerName: {item.CustomerName}");
            }

            var customerIdNameLamda = Customers.Select(c => new { c.CustomerId, c.CustomerName });
            foreach (var item in customerIdNameLamda)
            {
                Console.WriteLine($"CustomerId: {item.CustomerId}, CustomerName: {item.CustomerName}");
            }

            var gmailCustomerQuery = from c in Customers where c.Email.Contains("gmail.com") select c;
            foreach (var customer in gmailCustomerQuery)
            {
                Console.WriteLine(customer);
            }

            var gmailCustomersLambda = Customers.Where(c => c.Email.Contains("gmail.com"));
            foreach (var customer in gmailCustomersLambda)
            {
                Console.WriteLine(customer);
            }

            var nonNullOrderCustomersQuery = from c in Customers where c.OrderId != 0 select c;
            foreach (var customer in nonNullOrderCustomersQuery)
            {
                Console.WriteLine(customer);
            }

            var nonNullOrderCustomersLambda = Customers.Where(c => c.OrderId != 0);
            foreach (var customer in nonNullOrderCustomersLambda)
            {
                Console.WriteLine(customer);
            }

            var descOrderCustomersQuery = from c in Customers orderby c.CustomerName descending select c;
            foreach (var customer in descOrderCustomersQuery)
            {
                Console.WriteLine(customer);
            }

            var descOrderCustomersLambda = Customers.OrderByDescending(c => c.CustomerName);
            foreach (var customer in descOrderCustomersLambda)
            {
                Console.WriteLine(customer);
            }


            var mixOrderCustomerQurey = from c in Customers orderby c.CustomerName ascending, c.CustomerId descending select c;
            foreach (var customer in mixOrderCustomerQurey)
            {
                Console.WriteLine(customer);
            }

            var mixOrderCustomerLambda = Customers.OrderBy(c => c.CustomerName).ThenByDescending(c => c.CustomerId);
            foreach (var customer in mixOrderCustomerLambda)
            {
                Console.WriteLine(customer);
            }

            var JoinCustomerQurey = from c in Customers
                                    join o in Orders on c.OrderId equals o.OrderId
                                    select c;

            foreach (var customer in JoinCustomerQurey)
            {
                Console.WriteLine(customer);
            }

            var JoinCustomerLambda = Customers.Join(Orders, c => c.OrderId, o => o.OrderId, (c, o) => c);
            foreach (var customer in JoinCustomerLambda)
            {
                Console.WriteLine(customer);
            }

            var joinOrdersQuery = from o in Orders
                                  join c in Customers on o.OrderId equals c.OrderId
                                  select o;
            foreach (var order in joinOrdersQuery)
            {
                Console.WriteLine(order);
            }

            var joinOrdersLambda = Orders.Join(Customers, o => o.OrderId, c => c.OrderId, (o, c) => o);
            foreach (var order in joinOrdersLambda)
            {
                Console.WriteLine(order);
            }

            foreach (var customer in JoinCustomerQurey)
            {
                Console.WriteLine(customer);
            }

            foreach (var customer in JoinCustomerLambda)
            {
                Console.WriteLine(customer);
            }

            var JoinSelectQuery = from c in Customers
                                  join o in Orders on c.OrderId equals o.OrderId
                                  select new { c.CustomerId, c.CustomerName, o.OrderId, o.OrderDetails };
            foreach (var item in JoinSelectQuery)
            {
                Console.WriteLine($"CustomerId: {item.CustomerId}, CustomerName:{item.CustomerName}, OrderId:{item.OrderId}, OrderDetailed:{item.OrderDetails} ");
            }

            var JoinSelectLambda = Customers.Join(Orders, c => c.OrderId, o => o.OrderId, (c, o) => new { c.CustomerId, c.CustomerName, o.OrderId, o.OrderDetails });
            foreach (var item in JoinSelectLambda)
            {
                Console.WriteLine($"CustomerId: {item.CustomerId}, CustomerName:{item.CustomerName}, OrderId:{item.OrderId}, OrderDetailed:{item.OrderDetails} ");
            }


        }

    }
}