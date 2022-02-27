
using ReferansTipleri;

Customer customer = new Customer();
customer.FirstName = "Ali";

Employee employee = new Employee();
employee.FirstName = "Veli";

PersonManager personManager = new PersonManager();
personManager.Add(customer); //Customer classımı ekleyebildim çünkü Person classım hem Employee hem de Customer classının
// referans numaralarını tutuyor.
personManager.Add(employee);

Person person = customer; //Person classı Customer classının referans numarasını tuttuğu için customer'ı Person classına atayabildim.
