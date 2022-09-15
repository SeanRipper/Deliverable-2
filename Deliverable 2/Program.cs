





using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee or juice. How many people are in your group? Please, parties of 6 or lower.");


int partysize = int.Parse(Console.ReadLine());

if  (partysize <= 6)
{
  
    int diff = partysize - 1;
    int first = partysize - diff;
    int second = first + 1;
    int third = first + 2;
    int fourth = first + 3;
    int fifth = first + 4;
    int sixth = first + 5;
    int bevJ = 0;
    int bevC = 0;
    Console.WriteLine("A table for " + partysize + "! Please follow me and take a seat.");

    Console.WriteLine("Let's get everyone started with some drinks. We've got juice or coffee.");

    Console.WriteLine("");

    Console.WriteLine("Alright, person number " + first + ", juice or coffee?");

    string orderfirst = Console.ReadLine();
    if (orderfirst == "juice")
    {

        Console.WriteLine("{0}, good choice!", orderfirst);
    bevJ = bevJ + 1;
       
    }
    else if (orderfirst == "coffee")
    {


        Console.WriteLine("{0}, good choice!", orderfirst);
        bevC = bevC + 1;
        
    }
    else
    {
        Console.WriteLine("We don't have that. No drink for you!");
        
    }

    

    Console.WriteLine("");
    Console.WriteLine("Alright, person number " + second + ", juice or coffee?");

    string ordersecond = Console.ReadLine();
    if (ordersecond == "juice")
    {
        Console.WriteLine("{0}, good choice!", ordersecond);
    bevJ = bevJ + 1;
}
    else if (ordersecond == "coffee")
    {
        Console.WriteLine("{0}, good choice!", ordersecond);
    bevC = bevC + 1;
}
    else
    {
        Console.WriteLine("We don't have that. No drink for you!");
    }
 
    Console.WriteLine("");
    Console.WriteLine("Alright, person number " + third + ", juice or coffee?");

    string orderthird = Console.ReadLine();
    if (orderthird == "juice")
    {
        Console.WriteLine("{0}, good choice!", orderthird);
            bevJ = bevJ + 1;
}
    else if (orderthird == "coffee")
    {
        Console.WriteLine("{0}, good choice!", orderthird);
            bevC = bevC + 1;
}
    else
    {
        Console.WriteLine("We don't have that. No drink for you!");
    }
    Console.WriteLine("");
    Console.WriteLine("Alright, person number " + fourth + ", juice or coffee?");

    string orderfourth = Console.ReadLine();
    if (orderfourth == "juice")
    {
        Console.WriteLine("{0}, good choice!", orderfourth);
bevJ = bevJ + 1;
    }
    else if (orderfourth == "coffee")
    {
        Console.WriteLine("{0}, good choice!", orderfourth);
    bevC = bevC + 1;
}
    else
    {
        Console.WriteLine("We don't have that. No drink for you!");
    }
    Console.WriteLine();
    Console.WriteLine("Alright, person number " + fifth + ", juice or coffee?");

    string orderfifth = Console.ReadLine();
    if (orderfifth == "juice")
    {
        Console.WriteLine("{0}, good choice!", orderfifth);
            bevJ = bevJ + 1;
}
    else if (orderfifth == "coffee")
    {
        Console.WriteLine("{0}, good choice!", orderfifth);
    bevC = bevC + 1;
    }
    else
    {
        Console.WriteLine("We don't have that. No drink for you!");
    }
    Console.WriteLine();
    Console.WriteLine("Alright, person number " + sixth + ", juice or coffee?");

    string ordersixth = Console.ReadLine();
    if (ordersixth == "juice")
    {
        Console.WriteLine("{0}, good choice!", ordersixth);
        bevJ = bevJ + 1;
    }
    else if (ordersixth == "coffee")
    {
        Console.WriteLine("{0}, good choice!", ordersixth);
            bevC = bevC + 1;

}
    else
    {
        Console.WriteLine("We don't have that. No drink for you!");
    }
                        double totalbuffet = (partysize * 9.99);
                        double finalbuffet = Math.Round(totalbuffet, 2);
                        double totaljuice = (bevJ * 1.99);
                        double finaljuice = Math.Round(totaljuice, 2);
                        double totalcoffee = (bevC * 2.99);
                        double finalcoffee = Math.Round(totalcoffee, 2);
                        double totalprice = finalbuffet + finalcoffee + finaljuice;
                          
    double finalprice = Math.Round(totalprice, 2);
    
    Console.WriteLine("Okay, so that's " + bevC + " coffees and " + bevJ + " juices. I'll be right back. Feel free to grab your food!");
    Console.WriteLine("Here's your bill!");
    Console.WriteLine("Total Price: " + finalprice);
                                Console.WriteLine(partysize + " buffets = " + partysize + " x 9.99 = " + finalbuffet);
                        Console.WriteLine(bevC + " coffees = " + bevC + " x 2.99 = " + finalcoffee);
                        Console.WriteLine(bevJ + " juices = " + bevJ + " x 1.99 = " + finaljuice);
  
}
    

else if (partysize > 6)

{
    Console.WriteLine("Oh sorry, can only seat parties up to 6. Have a nice day.");

}

