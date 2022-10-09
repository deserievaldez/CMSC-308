using System;

namespace Activity5
{
    public class Program
    {
    
               public static void Main(string[] args) 
        { 
             
            boardMarker bm = new boardMarker(); 
             
            int choice = 0; 
            string msg = string.Empty; 
            string userColor = string.Empty; 
           
            Console.Clear();
             
            
            
            while(true){ 
                Console.Clear(); 
                Console.WriteLine("==MENU==");
                Console.WriteLine("1. Display Info"); 
                Console.WriteLine("2. Change Color"); 
                Console.WriteLine("3. Refill "); 
                Console.WriteLine("4. Write ");      
                Console.WriteLine("Enter your Choice:");
                choice = Convert.ToInt32(Console.ReadLine()); 
                 
                switch(choice){                 
                    case 1:
                        Console.Clear(); 
                        bm.DisplayInfo();  
                        Console.ReadKey();
                        break;

                    case 2: 
                         Console.Clear(); 
                        Console.WriteLine("Choose from: White, Blue and Red");                         Console.Write("Color: "); 
                        userColor = Console.ReadLine();                        
                        Console.Write("\n");
                        bm.changeColor(userColor);                        
                        Console.ReadKey(true);                      
                        break;


                    case 3: 
                         
                         Console.Clear(); 
                        bm.refill(); 
                         
                        break; 
                  
                       case 4:
            
                           Console.Write("\n");
                        Console.Write("Message: "); 
                        Console.Write("\n"); 
                         
                        msg = Console.ReadLine(); 
                         
                         
                        switch(bm.inkColor){                             
                        case "blue": 
                        Console.ForegroundColor = ConsoleColor.Blue;                                 break;                             case "red": 
                        Console.ForegroundColor = ConsoleColor.Red;                                 break; 
       } 
                        Console.Write("\n");                        
                        bm.write(msg);
                        Console.ForegroundColor = ConsoleColor.White; 
                        Console.ReadKey(true); 
                        break; 
                        
                        default:                          
                        Console.WriteLine("Invalid command...");  
                        Console.ReadKey();
                        Console.Clear();
                        break;
                } 
 
            } 
        } 
    } 
} 

