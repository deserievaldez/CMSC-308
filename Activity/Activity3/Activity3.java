import java.util.Scanner;
public class Activity3 {
    public static void main(String[] args) throws Exception {

      Scanner scan = new Scanner(System.in);

      
    System.out.print("\nSCIENCE   : "); float science = scan.nextFloat();

    System.out.print("PE        : ");float pe = scan.nextFloat();

    System.out.print("FILIPINO  : ");float filipino = scan.nextFloat();

    System.out.print("ENGLISH   : "); float english = scan.nextFloat();

    float average = (science + pe + filipino + english) / 4;


    System.out.println("\nAverage : " + average );


    if (average > 100)       System.out.println("Invalid Grade");

    else if (average >= 98)  System.out.println("With Highest Honors");

    else if (average >= 95)  System.out.println("With High Honors");

    else if (average >= 90)  System.out.println("With Honors");

    else if (average >= 75)  System.out.println("Passed");



    else  System.out.println("Failed");
    

    }
}
