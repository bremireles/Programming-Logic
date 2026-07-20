namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
//Problem 1: Simple For Loop
    {
        Console.WriteLine("Problem 1: ");
        for(int i = 1; i <= 10 ; i++)
        {
            Console.WriteLine(i);
        }
    }

//Problem 2: Even Numbers from 1 to 20 (using modulus operator)
{
    Console.WriteLine("Problem 2: "); 
     for(int i = 1 ; i <=20 ; i++)
    {
        if (i  % 2 ==0)
        {
            Console.Write(i+" ");
        }

    }
    Console.WriteLine();
}
//Problem 3: While Loop Countdown
{
    Console.WriteLine("Problem 3: ");
    int i = 5;
    while (i >=1)
            {
                Console.Write(i+" ");
                i--; 
            }
    Console.WriteLine();
}
 //Problem 4: While Loop - Multiples of 10 from 10 to 1000
    {
        Console.WriteLine("Problem 4:");
        int i =10;
        while (i <= 1000)
            {
            Console.Write(i+ " ");
            i +=10;
            }
            
    }
    Console.WriteLine();
// Problem 5: Seasons of the Year
        {
            Console.WriteLine("Problem 5:"); 
            string[] seasons ={"Summer", "Spring", "Fall", "Winter"};
            foreach(string season in seasons)
            {
                Console.Write(season + " "); 
            }
            
        }
        Console.WriteLine();
        
// Problem 6: Days of the Week 
        {
        Console.WriteLine("Problem 6: "); 
         string[] days = new string[7] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};    
         while(true){
            Console.WriteLine("Enter a number from 1-7");
            string dayofWeek= Console.ReadLine();
            int number = int.Parse(dayofWeek);
            if (number >= 1 && number <= 7)
            {
                Console.WriteLine(days[number-1]);
                break;
            }
            else
            {
                Console.WriteLine("You entered an invalid number my guy. Enter a number between 1-7");
            }
            }
        }
 //Problem 7: Favorite Books and Authors 
        Console.WriteLine("Problem 7: "); 
        string [] favBooks = {"Holy Bible", "The Seeker of Nothing", "The Giver"};
        string[] bookAuth = {"Jesus", "Kabir Munjal","Lois Lowry"};
        for (int  i = 0 ; i <= 2 ; i++)
        {
            Console.WriteLine("Favorite book titles: " + favBooks[i]+ " by " + bookAuth[i]);
        }
    
//Problem 8 : Temperature Tracker
    Console.WriteLine("Problem 8: "); 
    int [] temp = {80, 90, 70, 50, 60};
    Array.Sort(temp);
    foreach (int i in temp)
        {
            Console.Write(i+ " ");
        }
    Console.WriteLine();
    Console.Write("Lowest temp: "+ temp[0]+ " Highest temp: "+ temp[4]);
        
    Console.WriteLine();
    
//Problem 9: Reverse Countdown 
    Console.WriteLine("Problem 9: "); 
    int [] val = {5,4,3,2,1};
    Array.Reverse(val);
    for (int i = 0; i < val.Length; i++)
        {
            Console.Write(val[i]+" "); 
        }
        }
        }
    
    
