package InterfaceAbstraction;

public class Ship implements Transportation, WaterTranspo {
    public static final String ANSI_RESET = "\u001B[0m";

    public static final String ANSI_GREEN = "\u001B[32m";
    int ship_capacity = 3000;

    public void capacity() {
        System.out.println(ANSI_GREEN+"SHIP"+ANSI_RESET);
        System.out.println("Capacity: " + ship_capacity + " passenger");
    }
    public void water(){
        System.out.println("Ability of Ship: float in water \n");
    }
}
