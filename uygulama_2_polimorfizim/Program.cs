using System.Net;

namespace campanyManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employeeEmre = new Employee(1, "EMRE", "YAZILIMCI", 50000);


            Manager managerFurkan = new Manager("FULL", "MERCEDES", "VAR", 2, 2, "FURKAN", "LEVEL-1", 75000);
            
            HouseMaid houseKeeper_Ahmet = new HouseMaid("Mavi", 3, "AHMET", "ODA SERVİSİ", 20000);

            employeeEmre.getSalary();
            managerFurkan.getSalary();
            houseKeeper_Ahmet.getSalary();

            HouseMaid securityGuard_Mehmet = new HouseMaid("Siyah", 4, "MEHMET", "GÜVENLİK GÖREVLİSİ", 22000);

            //POLIMORFISM
            Console.WriteLine("********************************");
            Employee employee_2 = new Employee(1, "AYŞE", "YAZILIMCI", 50000);
            Employee manager_2 = new Manager("FULL", "MERCEDES", "VAR", 2, 2, "FATMA", "LEVEL-1", 75000);
            Employee houseKeeper_2 = new HouseMaid("Mavi", 3, "HAYRİYE", "ODA SERVİSİ", 20000);

            employee_2.getSalary();
            manager_2.getSalary();
            houseKeeper_2.getSalary();

             
            Console.WriteLine("********************************");
            employee_2.getSalary_2();
            manager_2.getSalary_2();
            houseKeeper_2.getSalary_2();

            //POLIMORFISM
            Console.WriteLine("********************************");
            Employee employee_3 = new Employee(1, "AYŞE", "YAZILIMCI", 50000);
            Manager manager_3 = new Manager("FULL", "MERCEDES", "VAR", 2, 2, "FATMA", "LEVEL-1", 75000);
            HouseMaid houseKeeper_3 = new HouseMaid("Mavi", 3, "HAYRİYE", "ODA SERVİSİ", 20000);

            Console.WriteLine("********************************");
            employee_3.getSalary_2();
            manager_3.getSalary_2();
            houseKeeper_3.getSalary_2();
        }
    }

    public class Employee
    {
        private int employeeId;
        private string name;
        private string description;
        private string title;
        private string phoneNumber;
        private int salary;
        private string address;
        private string identityNumber;
        private string mail;
        private string educationLevel;
        private string expirence;

        public Employee(int employeeId, string name, string description, int salary)
        {
            EmployeeId = employeeId;
            Name = name;
            Description = description;
            //Title = title;
            //PhoneNumber = phoneNumber;
            Salary = salary;
            //Address = address;
            //IdentityNumber = identityNumber;
            //Mail = mail;
            //EducationLevel = educationLevel;
            //Expirence = expirence;
        }

        public void getSalary()
        {
            Console.WriteLine("Düz Çalışan Maaşı:" + 10000);
        }

        public virtual void getSalary_2()
        {
            Console.WriteLine("Düz Çalışan Maaşı:" + 10000);
        }

        public void PrintAllFields()
        {
            Console.WriteLine("EmployeeId: " + EmployeeId);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Description: " + Description);
        }

        public int EmployeeId { get { return employeeId; } set { employeeId = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Title { get { return title; } set { title = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public int Salary { get { return salary; } set { salary = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string IdentityNumber { get { return identityNumber; } set { identityNumber = value; } }
        public string Mail { get { return mail; } set { mail = value; } }
        public string EducationLevel { get { return educationLevel; } set { educationLevel = value; } }
        public string Expirence { get { return expirence; } set { expirence = value; } }


    }
    public class Manager : Employee
    {
        private string auth;
        private string car;
        private string secretary;
        private int manageTeam;

        public Manager(string auth, string car, string secretary, int manageTeam,
            int employeeId, string name, string description, int salary)
            : base(employeeId, name, description, salary)
        {
            Auth = auth;
            Car = car;
            Secretary = secretary;
            ManageTeam = manageTeam;
        }

        public void getSalary()
        {
            Console.WriteLine("Yönetici Çalışan Maaşı:" + 20000);
        }

        public override void getSalary_2()
        {
            Console.WriteLine("Yönetici Çalışan Maaşı:" + 20000);
        }

        public void PrintAllFields()
        {
            base.PrintAllFields(); // Temel sınıftaki metodun özelliklerini yazdır

            Console.WriteLine("Auth: " + Auth);
            Console.WriteLine("Car: " + Car);
            Console.WriteLine("Secretary: " + Secretary);
            Console.WriteLine("ManageTeam: " + ManageTeam);
        }


        public string Auth { get { return auth; } set { auth = value; } }
        public string Car { get { return car; } set { car = value; } }
        public string Secretary { get { return secretary; } set { secretary = value; } }
        public int ManageTeam { get { return manageTeam; } set { manageTeam = value; } }
    }

    public class HouseMaid : Employee
    {

        private string uniformType;

        public HouseMaid(string uniformType, int employeeId, string name, string description, int salary)
            : base(employeeId, name, description, salary)
        {
            //this.uniformType = uniformType;
            UniformType = uniformType;
        }

        public void getSalary()
        {
            Console.WriteLine("Hizmetli Çalışan Maaşı:" + 5000);
        }

        public override void getSalary_2()
        {
            Console.WriteLine("Hizmetli Çalışan Maaşı:" + 5000);
        }

        public string UniformType { get { return uniformType; } set { uniformType = value; } }
    }
}