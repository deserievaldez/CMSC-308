package InterfaceAbstraction;

    public class Main {

        public static void main(String[] args) {

            System.out.println("\n==Different types of Transportation==\n");

            Airplane p = new Airplane();
            Bus b = new Bus();
            Jeep j = new Jeep();
            Ship s = new Ship();
            Motorcycle m = new Motorcycle();

            p.capacity();
            p.fly();
            b.capacity();
            b.land();
            j.capacity();
            j.land();
            s.capacity();
            s.water();
            m.capacity();
            m.land();



        }
    }

