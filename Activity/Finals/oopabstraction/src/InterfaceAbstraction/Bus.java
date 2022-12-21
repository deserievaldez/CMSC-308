package InterfaceAbstraction;

public class Bus implements Transportation, LandTranspo {
    public static final String ANSI_RESET = "\u001B[0m";

    public static final String ANSI_GREEN = "\u001B[32m";
    int bus_capacity = 50;

    public void capacity() {
        System.out.println(ANSI_GREEN+"BUS"+ANSI_RESET);
        System.out.println("Capacity: " + bus_capacity + " passenger");
    }
    public void land(){
        System.out.println("Ability of Bus: travel in land \n");
    }
}
