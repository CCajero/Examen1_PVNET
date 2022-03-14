public class juego{
    private int cantidadTiros;
    private int cantidadRojos;
    private int cantidadNegros;
    private int cantidadPares;
    private int cantidadImpares;
    private int dinero;
    private ruleta Ruleta;

    public juego()
    {
        Ruleta = new ruleta();
        cantidadTiros = 0;
        cantidadNegros = 0;
        cantidadPares = 0;
        cantidadImpares = 0;
        cantidadRojos = 0;
        dinero = 300;
    }

    public Boolean esRojo(int tiro)
    {
        if (tiro == 1 || tiro == 3 || tiro == 5 || tiro == 7 || tiro == 9 ||
        tiro == 12 || tiro == 14 || tiro == 16 || tiro == 18 || tiro == 19 || tiro == 21 ||
        tiro == 23 || tiro == 25 || tiro == 27 || tiro == 30 || tiro == 32 || tiro == 34 || tiro == 36)
        {
            return true;
        }
        else
        {
            return false;
        }


    }

    public Boolean esPar(int tiro)
    {
        if (tiro % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public int tirar()
    {
        int resultado = Ruleta.hacerTiro();

        cantidadTiros++;
        return resultado;
    }
    public void analizaTiro(int tiro)
    {

        if(esRojo(tiro))
        {
            cantidadRojos ++;
        }
        else
        {
            cantidadNegros++;
        }


        if(esPar(tiro))
        {
            cantidadPares++;
        }
        else
        {
            cantidadImpares++;
        }

    }


    /**
     * apuesta es el numero al que aposto.
     * resultado es lo que dio la ruleta.
     * tipoApuesta es el tipo de apuesta.
     * cantidad es el dinero apostado.
     */
    public int evaluarApuesta(int apuesta, int resultado, int tipoApuesta, int cantidad)
    {
        int ganancias = 0;

        if(tipoApuesta == 0)//Por número
        {
            if(apuesta == resultado)
            {
                ganancias = cantidad * 10;
            }
            else
            {
                ganancias = (cantidad * -10);
            }
        }
        if (tipoApuesta == 1)//Por color
        {

            if(esRojo(resultado) == esRojo(apuesta))
            {
                ganancias = cantidad * 5;
            }
            else
            {
                ganancias = cantidad * -5;
            }


        }
        if(tipoApuesta == 2)//Por impar
        {
            if(esPar(apuesta) == esPar(resultado))
            {
                ganancias = cantidad * 2;
            }
            else
            {
                ganancias = cantidad * -2;
            }
        }

        return ganancias;
    }

    public int obtenerResultadosNegros()
    {
        return cantidadNegros;
    }
    public int obtenerResultadosRojos()
    {
        return cantidadRojos;
    }
    public int obtenerResultadosPares()
    {
        return cantidadPares;
    }
    public int obtenerResultadosImpares()
    {
        return cantidadImpares;
    }

    public int CantidadTiros
    {
        get { return cantidadTiros; }
    }
    public int CantidadNegros
    {
        get { return cantidadNegros; }
    }
    public int CantidadRojos
    {
        get { return cantidadRojos; }
    }
    public int CantidadPares
    {
        get { return cantidadPares; }
    }
    public int CantidadImpares
    {
        get { return cantidadImpares; }
    }

    public void elementoMasRepetido()
    {
        Ruleta.elementoMasRepetido();
    }

}