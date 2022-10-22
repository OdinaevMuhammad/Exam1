var pr = new Person();
pr.n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Person q:");
System.Console.WriteLine($"Name:");
pr.Name = System.Console.ReadLine();
System.Console.WriteLine($"Surname:");

pr.Surname = System.Console.ReadLine();
System.Console.WriteLine($"Age:");

pr.Age = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(pr.GetInfo());
