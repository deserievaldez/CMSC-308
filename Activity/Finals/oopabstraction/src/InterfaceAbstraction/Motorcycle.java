package InterfaceAbstraction;

public class Motorcycle implements Transportation, LandTranspo {
    public static final String ANSI_RESET = "\u001B[0m";

    public static final String ANSI_GREEN = "\u001B[32m";
    int motorcycle_capacity = 2;


    public void capacity() {
        System.out.println(ANSI_GREEN+"MOTORCYCLE"+ANSI_RESET);
        System.out.println("Capacity: " + motorcycle_capacity + " passenger");

    }

        public void land(){
            System.out.println("Ability Motorcycle: travel in land ");
    }
}