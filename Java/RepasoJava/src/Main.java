import java.util.Scanner;
import ClasesRepaso.*;

public class Main {
    public static void main(String[] args){
        

    }



    static void entradaSalida(){
        String nombre;

        // Entrada de datos
        Scanner entradaDatos = new Scanner(System.in);

        System.out.println("Entre su nombre: ");
        nombre = entradaDatos.nextLine();

        // Salida de datos
        System.out.println("que hubo pues!" + " " + nombre);
    }

    static void poo(){
        Endavans endv1 = new Endavans();
        //endv1.nombre = "Fredy";
        endv1.setNombre("Fredy");
        endv1.apellido = "Viracacha";
        endv1.identificacion = 123456;
        endv1.mostrarDatos();
        endv1.estadoBench();

        Endavans endv2 = new Endavans();
        //endv2.nombre = "Emiliano";
        endv2.setNombre("Emiliano");
        endv2.apellido = "Duque";
        endv2.identificacion = 789456;
        endv2.mostrarDatos();
        endv2.estadoAsignado();

        Endavans endv3 = new Endavans();
        //endv3.nombre = "Juan";
        endv3.setNombre("Juan");
        endv3.apellido = "Perez";
        endv3.identificacion = 456789;
        endv3.mostrarDatos();
        endv3.estadoVacaciones();
    }


}