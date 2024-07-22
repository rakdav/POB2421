//List<string> people = new List<string>() { "Tom", "Jerry", "Sam" };
//List<string> employee = new List<string>(people);
//List<string> doctors = [];
//List<string> strings = new List<string>(16);
//Console.WriteLine(people.Count+" "+employee.Count+
//    " "+doctors.Count+" "+strings.Count);
//Console.WriteLine(people.Capacity + " " + employee.Capacity +
//    " " + doctors.Capacity + " " + strings.Capacity);
//people.Add("Bob");
//people.Add("Mike");
//Console.WriteLine(people.Count + " " + employee.Count +
//    " " + doctors.Count + " " + strings.Count);
//Console.WriteLine(people.Capacity + " " + employee.Capacity +
//    " " + doctors.Capacity + " " + strings.Capacity);
//doctors.AddRange(employee);
//Console.WriteLine(people.Count + " " + employee.Count +
//    " " + doctors.Count + " " + strings.Count);
//Console.WriteLine(people.Capacity + " " + employee.Capacity +
//    " " + doctors.Capacity + " " + strings.Capacity);
//string[] mas = { "1", "2" };
//doctors.AddRange(mas);
//for (int i = 0;i < doctors.Count; i++) Console.Write(doctors[i]+" ");
//Console.WriteLine();
////из List в массив
//string[] copyMas=new string[doctors.Count];
//doctors.CopyTo(copyMas);
//for (int i = 0; i < copyMas.Length; i++) Console.Write(copyMas[i]+" ");
//Console.WriteLine();
////бинарный поиск
//doctors.Sort();
//for (int i = 0; i < doctors.Count; i++) Console.Write(doctors[i] + " ");
//Console.WriteLine();
//Console.WriteLine(doctors.BinarySearch("1"));
//Console.WriteLine(doctors.BinarySearch("4"));
//Console.WriteLine(doctors.Contains("Jerry"));
//bool yes = doctors.Exists(p => p.Length == 3);
//Console.WriteLine(yes);
//Console.WriteLine(doctors.Find(p => p.Length == 3));
//Console.WriteLine(doctors.FindLast(p=>p.Length==3));
//List<string> list = doctors.FindAll(p => p.Length == 3);
//for (int i = 0; i < list.Count; i++) Console.Write(list[i] + " ");
//Console.WriteLine();
//Console.WriteLine(doctors.IndexOf("1"));
//Console.WriteLine(doctors.LastIndexOf("2"));
//List<string> list2 = doctors.Where(p => p.Length > 4).ToList();
//doctors.RemoveAll(p => p.Length < 2);
//doctors.Insert(3, "five");
//for (int i = 0; i < doctors.Count; i++) Console.Write(doctors[i] + " ");
//Console.WriteLine();
//doctors.InsertRange(3, employee);
//for (int i = 0; i < doctors.Count; i++) Console.Write(doctors[i] + " ");
//Console.WriteLine();
//doctors.Reverse();
//for (int i = 0; i < doctors.Count; i++) Console.Write(doctors[i] + " ");
//Console.WriteLine();
//doctors.Remove("five");
//for (int i = 0; i < doctors.Count; i++) Console.Write(doctors[i] + " ");
//Console.WriteLine();
//doctors.RemoveAt(3);
//for (int i = 0; i < doctors.Count; i++) Console.Write(doctors[i] + " ");
//Console.WriteLine();
//doctors.RemoveRange(1, 3);
//for (int i = 0; i < doctors.Count; i++) Console.Write(doctors[i] + " ");
//Console.WriteLine();

//var range = doctors.GetRange(1, 2);
//for (int i = 0; i < range.Count; i++) Console.Write(range[i] + " ");
//Console.WriteLine();
//doctors.Clear();

List<Contact> contacts = new List<Contact>();
do
{
    Console.Clear();
    Console.WriteLine("1 - Добавить\n" +
        "2 - Удалить по имени\n" +
        "3 - Поиск");
    foreach (Contact contact in contacts)
    {
        Console.WriteLine(contact.Name+" "+contact.Phone);
    }
    Console.WriteLine();
    Console.Write("Выберите пункт меню:");
    int n;
    int.TryParse(Console.ReadLine(), out n);
    switch (n)
    {
        case 1 : 
            {
                Console.Write("Введите имя:");
                string name=Console.ReadLine()!;
                Console.Write("Введите телефон:");
                string phone = Console.ReadLine()!;
                Contact contact = new Contact(name,phone);
                contacts.Add(contact);
            } 
            break;
        case 2: 
            {
                Console.Write("Введите имя:");
                string name = Console.ReadLine()!;
                Contact contact=contacts.Find(x => x.Name==name);
                contacts.Remove(contact);
            }
            break;
        case 3:
            {
                Console.WriteLine("1 - поиск по имени\n" +
                    "2 - поиск по телефону");
                Console.Write("Введите номер:");
                int m;
                int.TryParse(Console.ReadLine(), out m);
                switch (m)
                {
                    case 1: 
                        {
                            Console.Write("Введите имя:");
                            string name=Console.ReadLine()!;
                            Contact contact = contacts.Find(x => x.Name == name);
                            Console.WriteLine(contact.Name+" "+contact.Phone);
                            Console.ReadKey();
                        }
                        break;
                    case 2: 
                        {
                            Console.Write("Введите телефон:");
                            string phone = Console.ReadLine()!;
                            Contact contact = contacts.Find(x => x.Phone == phone);
                            Console.WriteLine(contact.Name + " " + contact.Phone);
                            Console.ReadKey();
                        }
                        break;
                }
            }
            break;
    }
}
while (true);
struct Contact
{
    public string Name;
    public string Phone;
    public Contact(string name, string phone)
    {
        Name = name;
        Phone = phone;
    }
}
