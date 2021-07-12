using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {

            PhoneDirectory p = new();
            p.addPerson("Ahmet", "YILDIRIM", "5411235496");
            p.addPerson("Mustafa", "ULKER", "5481543839");
            p.addPerson("Ulunay", "OCAK", "5075167834");
            p.addPerson("Alex", "de Souza", "1010101010");
            p.addPerson("Mateja", "Kezman", "0707070707");

            int q = 1;
            while (q == 1)
            {
                Console.WriteLine("Please choose what you want to do ");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Add New Number ");
                Console.WriteLine("(2) Delete Exist Number ");
                Console.WriteLine("(3) Update Exist Number ");
                Console.WriteLine("(4) Print List ");
                Console.WriteLine("(5) Search Number");
                Console.WriteLine("(0) Quit");
                Console.Write("Your Choose: ");
                int choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:

                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Surname: ");
                        string surname = Console.ReadLine();
                        Console.Write("Phone: ");
                        string phone = Console.ReadLine();
                        p.addPerson(name, surname, phone);

                        break;

                    case 2:

                        Console.Write("Please enter the name or surname of the person whose number you want to delete: ");
                        string deleteName = Console.ReadLine();

                        int isNumberExist = p.searchByName(deleteName);

                        if (isNumberExist == 0)
                        {

                            Console.WriteLine("The data matching your search criteria could not be found in the directory. Please make a selection.");
                            Console.WriteLine("* To terminate the deletion: (1)");
                            Console.WriteLine("* To try again : (2)");
                            Console.Write("Your Choose: ");
                            int deleteNameChoise = int.Parse(Console.ReadLine());
                            if (deleteNameChoise == 1)
                            {
                                return;
                            }
                            else
                            {
                                continue;
                            }

                        }
                        else
                        {
                            Console.Write("The person named {0} is about to be deleted from the directory, do you confirm?(y/n) ", deleteName);
                            string sure = Console.ReadLine();
                            if (sure == "y")
                            {
                                p.deleteNumber(deleteName);
                            }
                            else
                            {
                                break;
                            }
                        }

                        break;

                    case 3:

                        Console.Write("Please enter the name or surname of the person whose number you want to update: ");
                        string updateName = Console.ReadLine();

                        int isNumberExistt = p.searchByName(updateName);

                        if (isNumberExistt == 0)
                        {
                            Console.WriteLine("The data matching your search criteria could not be found in the directory. Please make a selection.");
                            Console.WriteLine("* To terminate the update: (1)");
                            Console.WriteLine("* To try again : (2)");
                            Console.Write("Your Choose: ");
                            int updateNameChoise = int.Parse(Console.ReadLine());
                            if (updateNameChoise == 1)
                            {
                                return;
                            }
                            else
                            {
                                continue;
                            }

                        }
                        else
                        {
                            Console.Write("Please type new number: ");
                            string newNumber = Console.ReadLine();
                            p.updateNumber(updateName, newNumber);

                        }



                        break;
                    case 4:

                        Console.WriteLine("Telephone directory");
                        Console.WriteLine("**********************************************");
                        p.printAll();
                        break;

                    case 5:
                        Console.WriteLine("Choose how you want to search by.");
                        Console.WriteLine("**********************************************");
                        Console.WriteLine("Search by name or surname: (1)");
                        Console.WriteLine("Search by phone: (2)");
                        Console.Write("Your Choose: ");
                        int searchBy = int.Parse(Console.ReadLine());
                        if (searchBy == 1)
                        {
                            Console.Write("Type the name or surname: ");
                            string wantedName = Console.ReadLine();
                            p.searchByName(wantedName);
                        }
                        else if (searchBy == 2)
                        {
                            Console.Write("Type the number: ");
                            string wantedNumber = Console.ReadLine();
                            p.searchByPhone(wantedNumber);
                        }
                        else
                        {
                            Console.WriteLine("Do not try me, please.");
                        }
                        break;
                    case 0:
                        Console.WriteLine("See You Later");
                        q = 0;
                        break;
                    default:
                        Console.WriteLine("Do not try me, please.");
                        break;
                }
            }


        }
    }
}
