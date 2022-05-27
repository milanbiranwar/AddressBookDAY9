// See https://aka.ms/new-console-template for more information
using AddressBookDAY9;

Console.WriteLine("Hello, World!");




Console.WriteLine("Hello, World!");

AddressBook addressBook = new AddressBook();
addressBook.AddNewContact();
addressBook.AddNewContact();

AddressBook.PrintAddressBook();
Console.WriteLine("Enter the FirstName to Edit");
string firstName = Console.ReadLine();
addressBook.EditContact(firstName);
AddressBook.PrintAddressBook();


AddressBook.PrintAddressBook();
Console.WriteLine("Enter the FirstName to Delete");
string firstName1 = Console.ReadLine();
addressBook.DeleteContact(firstName1);
AddressBook.PrintAddressBook();
Console.ReadLine();
