using UsersConsoleApp1;
List<User> listUser = new List<User>();
void CreateObject()
{
    //for (int index = 0; index < 3; index++)
    //{
    User user1 = new User();
    Console.WriteLine("enter fname");
    user1.FirstName = Console.ReadLine();
    Console.WriteLine("enter lname");
    user1.LastName = Console.ReadLine();
    Console.WriteLine("enter email");
    user1.Email = Console.ReadLine();
    Console.WriteLine("enter yearB");
    user1.BirthYear = int.Parse(Console.ReadLine());
    listUser.Add(user1);
    //}
}
//User[] arrayUser = new User[] { listUser[0], listUser[1], listUser[2] };
//Console.WriteLine("before sort");
//int i = 0;
//while (i < arrayUser.Length)
//{
//    Console.WriteLine(arrayUser[i].Print());
//    i++;
//}
//Array.Sort(arrayUser);
//Console.WriteLine("after sort");
//int x = 0;
//while (x < arrayUser.Length)
//{
//    Console.WriteLine(arrayUser[x].Print());
//    x++;
//}

/// exe 6 ///

void GetUsersList(List<User> user)
{
    FileStream fs = new FileStream(@$"C:/User/all-users.txt", FileMode.Append);
    using(StreamWriter writer =new StreamWriter(fs))
    {
        int i = 0;
        while (i < user.Count())
        {
         writer.WriteLine($"{user[i].Print()}\n");
            i++;
        }
    }
}
//GetUsersList(listUser);
/// exe 7 ///
void ReaderFromFile()
{
    FileStream fs = new FileStream(@"C:\User\all-users.txt", FileMode.Open);
    using(StreamReader reader =new StreamReader(fs))
    {
        Console.WriteLine(reader.ReadToEnd());

        //for(int i = 0; i < reader.Peek(); i++)
        //{
        //    Console.WriteLine(reader.ReadLine());
        //}
    }
}
//ReaderFromFile();
/// exe 8 // 
void CreateSeprateFile(List<User> user)
{
    for(int i = 0; i < user.Count(); i++)
    {
        FileStream fs = new FileStream($@"C:\User\{user[i].FirstName}.txt", FileMode.Append);
        using(StreamWriter writer =new StreamWriter(fs))
        {
            writer.WriteLine(user[i].Print());
        }
    }
}
CreateSeprateFile(listUser);
/// exe 9 \\
void GetUserFile(string name)
{
    FileStream fs = new FileStream(@$"C:\User\{name}.txt", FileMode.Open);
    using (StreamReader reader = new StreamReader(fs))
    {
        Console.Write(reader.ReadLine());
    }
}
// exe 10 \\
void DeleteFileByName(string name)
{
    File.Delete(@$"C:/User/{name}.txt");
}
void EditUserFile(string name)
{
    //string editUser = "";
    //FileStream fs = new FileStream($@"C:/User/{name}.txt", FileMode.Open);
    //using(StreamReader reader = new StreamReader(fs))
    //{
    //  editUser = reader.ReadLine();
    //}
    
    FileStream fss = new FileStream($@"C:/User/{name}.txt", FileMode.Create);
    using (StreamWriter Writer = new StreamWriter(fss))
    {
        User user1 = new User();
        Console.WriteLine("enter fname");
        user1.FirstName = Console.ReadLine();
        Console.WriteLine("enter lname");
        user1.LastName = Console.ReadLine();
        Console.WriteLine("enter email");
        user1.Email = Console.ReadLine();
        Console.WriteLine("enter yearB");
        user1.BirthYear = int.Parse(Console.ReadLine());
        Writer.WriteLine($"{user1.Print()}");
    }
}
EditUserFile(Console.ReadLine());
void MainFunction()
{
    Console.WriteLine("1 - to add user");
    Console.WriteLine("2 - to edit user");
    Console.WriteLine("3 - to delete user");
    Console.WriteLine("4 - to present user");
    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            CreateObject();
            break;
        case 2:

            break;
        case 3:
            DeleteFileByName(Console.ReadLine());
            break;
        case 4:
            GetUserFile(Console.ReadLine());
            break;
        default:
            break;
    }
}