using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Contact
{
    public int phoneNum;
    public string firstName;
    public string lastName;
    public string occupation;
    public string company;
    public string email;
    public int age;
    public string birthday;

    public Contact(int phoneNum, string firstName, string lastName, string occupation, string company, string email, int age, string birthday)
    {
        this.phoneNum = phoneNum;
        this.firstName = firstName;
        this.lastName = lastName;
        this.occupation = occupation;
        this.company = company;
        this.email = email;
        this.age = age;
        this.birthday = birthday;
    }

    public void display()
    {
        Console.WriteLine("First and last name: " + firstName + " " + lastName);
        Console.WriteLine("Phone number: " + phoneNum);
        Console.WriteLine("Occupation: " + occupation);
        Console.WriteLine("Company: " + company);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Date of birth: " + birthday);
    }
}

namespace ObjektoveOrientovaneProgramovani
{
    internal class Program
    {
        private static int menu;
        static int Main(string[] args)
        {

            Contact Pavel = new Contact(789225103, "Pavel", "Novak", "Elektrikar", "LCD Labs", "pnovak@lcd.cz", 39, "15. leden 1985");
            Contact Adam = new Contact(608995422, "Adam", "Novotny", "Programator", "Microsoft", "adamdeveloper@microsoft.com", 26, "10. brezen 1998");
            Contact Josef = new Contact(991238250, "Josef", "Dvorak", "Duchodce", "N/A", "N/A", 91, "29. unor 1933");
            Contact Klara = new Contact(775148952, "Klara", "Svobodova", "Student", "SSIPF Cichnova", "st011862@student.cichnovabrno.cz", 17, "7. duben 2007");

            do{
                
                Console.WriteLine("Welcome to contacts list");
                Console.WriteLine("1. Pavel");
                Console.WriteLine("2. Adam");
                Console.WriteLine("3. Josef");
                Console.WriteLine("4. Klara");
                Console.WriteLine("5. Exit program");
                Console.Write("Choose a valid option: ");
                int menu = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.ReadKey();

                switch (menu)
                {
                    case 1:

                        Pavel.display();

                        break;

                    case 2:

                        Adam.display();

                        break;

                    case 3:

                        Josef.display();

                        break;

                    case 4:

                        Klara.display();

                        break;

                    case 5:

                        Console.WriteLine("Thank you for using my program");
                        return 0;

                        break;

                    default:

                        Console.WriteLine("This is not a valid option.");
                        return 0;

                        break;

                }

                Console.Clear();
                Console.ReadKey();

            } while(menu != 5);

            Console.ReadKey();
            return 0;

        //    Console.WriteLine(Tobis.age);
        //    Console.WriteLine(Tobis.occupation);
            
        }

    }
}
