
string[] names = new string[] { "Shan", "John", "Grace", "Hailey", "Hamlet" };

string[] homeTown = new string[] { "Chicago", "Detriot", "Parker", "Puerto Rico", "Denver" };

string[] favoriteFood = new string[] { "Deep Dish", "Coney Dog", "Saag Paneer", "Arroz con Pollo", "Green Chile" };



while (true)
{
    Console.WriteLine("Which student would like to know about? Give me a number between 1 and 5.\n");

    Console.WriteLine($"1. {names[0]}");
    Console.WriteLine($"2. {names[1]}");
    Console.WriteLine($"3. {names[2]}");
    Console.WriteLine($"4. {names[3]}");
    Console.WriteLine($"5. {names[4]}");

    int studentNumber = Convert.ToInt32(Console.ReadLine());

    int studentIndexNumber = studentNumber - 1;

    if (names.Length <= 5)
    {
        Console.WriteLine("\n" + names[studentIndexNumber]);

    }
    else if (names.Length > 6)
    {
        Console.WriteLine("That student doesn't exist. \n");

    }


    while (true)
    {
        Console.WriteLine("What would you like to know about the student, Hometown or Favorite Food?");
        string funFact = Convert.ToString(Console.ReadLine());


        if (funFact.ToLower() == "hometown")
        {
            Console.WriteLine(homeTown[studentIndexNumber]);
            break;
        }
        else if (funFact.ToLower() == "favorite food" || funFact.ToLower() == "food")
        {
            Console.WriteLine(favoriteFood[studentIndexNumber]);
            break;
        }
        else
        {
            Console.WriteLine("We don't know that information.\n");
            continue;
        }
    }
    

    Console.WriteLine("Do you want to know more information about another students?");
    string answer = Convert.ToString(Console.ReadLine());

    if (answer.ToLower() == "yes \n")
    {
        continue;
    }
    else
    {
        Console.ReadKey();
        break;
    }
}

//Methods

//static void ReturnStudentName(string[] names)
//{
//    Console.WriteLine("Which student would like to know about? Give me a number between 1 and 5.\n");

//    Console.WriteLine($"1. {names[0]}");
//    Console.WriteLine($"2. {names[1]}");
//    Console.WriteLine($"3. {names[2]}");
//    Console.WriteLine($"4. {names[3]}");
//    Console.WriteLine($"5. {names[4]}");

//    int studentNumber = Convert.ToInt32(Console.ReadLine());

//    int studentIndexNumber = studentNumber - 1;

//    if (names.Length <= 5)
//    {
//        Console.WriteLine(names[studentIndexNumber]);
        
//    }
//    else if (names.Length > 6)
//    {
//        Console.WriteLine("That student doesn't exist.");
        
//    }

//   ReturnHomeTownOrFood(studentIndexNumber,)
    
//}

//static void ReturnHomeTownOrFood(int studentReference, string[] homeTown, string[] favoriteFood)
//{
//    Console.WriteLine("What would you like to know about the student, Hometown or Favorite Food?");
//    string funFact = Convert.ToString(Console.ReadLine());


//    if (funFact.ToLower() == "hometown")
//    {
//        Console.WriteLine(homeTown[studentReference]);
//    }
//    else if (funFact.ToLower() == "favorite food" || funFact.ToLower() == "food")
//    {
//        Console.WriteLine(favoriteFood[studentReference]);
//    }
//    else
//    {
//        Console.WriteLine("We don't know that information.");
//    }
//}

