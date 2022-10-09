using System;

namespace Activity5
{

    public class boardMarker
    {
         public boardMarker() 
        { 
        } 
         
        public string inkColor = "white"; 
        public int inkContent = 20;
        
        
      
         
        public void write(string msg){ 
            inkContent--;
            
            
            if (inkContent>10)
                inkContent = 10;
            
            
            else
                inkContent = 0;
   
            Console.WriteLine(msg); 
            Console.WriteLine("Remaining ink in : " + inkContent ); 
            if(inkContent == 0)
                
                Console.WriteLine("You are out of Ink Refill first");
 
           
         
        } 
         
        public void refill(){     
            
            if (inkContent>=10)
                inkContent = 20;
            else
                inkContent = 20;
          Console.WriteLine("Remaining ink: " + inkContent); 
          Console.ReadKey();
        }
        public void changeColor(string userColor){ 

            inkColor = userColor; 
            
             
                 switch(inkColor){                 
                case "White":
                    inkColor = "white"; 
                    break;                 
                   case "Blue":
                    inkColor = "blue"; 
                    break;                 
                   case "Red":
                    inkColor = "red"; 
                    break;                 
                    default:                     
                    inkColor = "white";
                    break; 

            } 
             
             
            Console.WriteLine("Marker Color: " + inkColor); 
        } 
         
        public void DisplayInfo(){ 
            Console.WriteLine("inkColor: " + inkColor ); 
            Console.WriteLine("inkContent: " + inkContent); 
        } 
    } 
     
} 


