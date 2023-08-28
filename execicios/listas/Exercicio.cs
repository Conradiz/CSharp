using System.Globalization;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.Write("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine());

            List <Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i}");
                Console.Write("ID:");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee (id, name, salary));
            }
            Console.WriteLine("Deseja aumentar algum salario [S/N] ");
            string res = Console.ReadLine();
            if (res == "S" || res == "s")
            {
                Console.Write("Entre com o Id do Funcionario que tera acrescimo no salario : ");
                int escId = int.Parse(Console.ReadLine());
                Employee emp = list.Find(s => s.Id == escId);
                if (emp != null)
                {
                    Console.Write("Entre com a porcentagem:% ");
                    double porcentage = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
                    emp.IncreaseSalary(porcentage);
                }
                else
                {
                    Console.WriteLine("Este Id não existe");
                }

            }
            Console.WriteLine();
            Console.WriteLine("Lista dos funcionarios atualizada:");
            foreach (Employee ite in list)
            {
                Console.WriteLine(ite);
            }
        }
    }
}