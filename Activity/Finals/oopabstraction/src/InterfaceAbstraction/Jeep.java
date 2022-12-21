package InterfaceAbstraction;

public class Jeep implements Transportation, LandTranspo{
    public static final String ANSI_RESET = "\u001B[0m";

    public static final String ANSI_GREEN = "\u001B[32m";
    int jeep_capacity = 20;


    public void capacity() {
        System.out.println(ANSI_GREEN+"JEEP"+ANSI_RESET);
        System.out.println("Capacity: " + jeep_capacity + " passenger");
    }
    public void land(){
        System.out.println("Ability of Jeep: travel in land \n");
    }
}
