package test;

import dominio.*;

public class PersonaPrueba {
    public static void main(String[] args) {
        Persona persona1 = new Persona("Emiliano", 5000, false);
        System.out.println("persona1:" + persona1.toString());

        persona1.setNombre("Diana");
        System.out.println("persona1: " + persona1);
    }
}
