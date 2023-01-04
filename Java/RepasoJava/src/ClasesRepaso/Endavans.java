package ClasesRepaso;

public class Endavans {

    // Atributos
    private String nombre;
    public String apellido;
    public int identificacion;

    // Getter and Setter
    public void setNombre(String nombre){
        this.nombre = nombre;
    }

    public String getNombre(){
        return this.nombre;
    }

    // Metodos
    public void mostrarDatos(){
        System.out.println("\nNombre: " + nombre +
                "\nApellido: " + apellido +
                "\nIdentificacion: " + identificacion);
    }

    public void estadoBench(){
        System.out.println("El endavan esta en Bench");
    }

    public void estadoAsignado(){
        System.out.println("El endavan esta asignado");
    }

    public void estadoVacaciones(){
        System.out.println("El Endavan esta de Vacaciones");
    }
}
