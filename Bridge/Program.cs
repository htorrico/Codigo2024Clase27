


using Bridge;

void SinPolimorfismo()
{
    #region SinPolimorfismo
    //Input
    Circulo circulo1 = new Circulo();
    Cuadrado cuadrado1 = new Cuadrado();
    Cuadrado cuadrado2 = new Cuadrado();
    Circulo circulo2 = new Circulo();


    //Output
    circulo1.Dibujar();
    cuadrado1.Dibujar();
    cuadrado2.Dibujar();
    cuadrado2.Dibujar();

    #endregion


}


#region Polimorfismo
//Input

List<Forma> formas = new List<Forma>();

Forma circuloRojo = new Circulo();
circuloRojo._color = new Rojo();

Forma circuloAzul = new Circulo();
circuloAzul._color = new Azul();

Forma cuadradoRojo = new Cuadrado();
cuadradoRojo._color = new Rojo();

Forma cuadradoAzul = new Cuadrado();
cuadradoAzul._color = new Azul();



formas.Add(circuloRojo);
formas.Add(circuloAzul);
formas.Add(cuadradoRojo);
formas.Add(cuadradoAzul);


//Output
foreach (var item in formas)
{
    item.Dibujar();
}


#endregion





Console.Read();
