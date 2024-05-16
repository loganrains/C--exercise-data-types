// Get User's name
Console.WriteLine("What is your name?");
string? name = Console.ReadLine();

// Get Rectangle Length
Console.WriteLine("Hello " + name + "!\nPlease enter the length of a rectangle");
string? input = Console.ReadLine();
double length = double.Parse(input);

// Get Rectangle Width
Console.WriteLine("Now please enter the width of a rectangle");
string? inputTwo = Console.ReadLine();
double width = double.Parse(inputTwo);

// Return Rectangle Area
double area = length * width;
Console.WriteLine("The area of the rectangle is " + area);

// Get User Miles
   Console.WriteLine("How many miles did you drive on your trip?");
   string mi = Console.ReadLine();
   int miles = Int32.Parse(mi);

   Console.WriteLine("How many gallons of gas did you use?");
   string gal = Console.ReadLine();
   int gallons = Int32.Parse(gal);

   int mpg = miles / gallons;
   Console.WriteLine("The MPG for the trip was: " + mpg);

// Alice search example
   string alice = @"Alice was beginning to get very tired of sitting by her sister on the
   bank, and of having nothing to do: once or twice she had peeped into the
   book her sister was reading, but it had no pictures or conversations in
   it, 'and what is the use of a book,' thought Alice 'without pictures or
   conversation?'";
   
   Console.WriteLine(alice);
   Console.WriteLine("What word would you like to look for in the sentence above?");
   string searchTerm = Console.ReadLine();
   string compSearchTerm = searchTerm.ToLower();
   string compAlice = alice.ToLower();

   if (compAlice.IndexOf(compSearchTerm, 0) != -1)
   {
      Console.WriteLine("true");
      Console.Write(" , Your word can be found at index " + compAlice.IndexOf(compSearchTerm, 0) + " and it is " + compSearchTerm.Length + " characters long.");
   }
   else 
   {
      Console.WriteLine("false");
   }


