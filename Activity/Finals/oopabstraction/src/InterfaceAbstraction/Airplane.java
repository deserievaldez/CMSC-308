package InterfaceAbstraction;



public class Airplane implements Transportation, AirTranspo {
    public static final String ANSI_RESET = "\u001B[0m";

    public static final String ANSI_GREEN = "\u001B[32m";
    int airplane_capacity = 400;

    public void capacity() {
        System.out.println(ANSI_GREEN+"AIRPLANE"+ANSI_RESET);
        System.out.println("Capacity: " + airplane_capacity + " passenger");

    }
    public void fly(){
        System.out.println("Ability of Airplane: Fly \n");
    }
}