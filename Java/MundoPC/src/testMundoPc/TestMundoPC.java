package testMundoPc;

import mundoPc.*;

public class TestMundoPC {
    public static void main(String[] args) {
        Raton ratonInalambrico = new Raton("Inalambrico", "pcWorld");
        Raton ratonCableado = new Raton("Cableado", "HP");
        Raton ratonLenovo = new Raton("Inalabrico", "Lenovo");

        Teclado tecladoInalambrico = new Teclado("Inalambrico", "Mac");
        Teclado tecladoCableado = new Teclado("Bluetooth", "HP");
        Teclado tecladoLenovo = new Teclado("Bluetooth", "Lenovo");

        Monitor monitorPantalla21 = new Monitor("iMac", 21);
        Monitor monitorLG = new Monitor("LG", 27);

        Computadora compu1 = new Computadora("Mac", monitorPantalla21, tecladoInalambrico, ratonInalambrico);
        Computadora compu2 = new Computadora("Ensamblada", monitorLG, tecladoLenovo, ratonCableado);

        Orden orden1 = new Orden();
        orden1.agregarComputadora(compu1);
        orden1.mostrarOrden();

        Orden orden2 = new Orden();
        orden2.agregarComputadora(compu2);
        orden2.mostrarOrden();


    }
}
