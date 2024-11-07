


using Bridge;

//Input

List<Forma> formas = new List<Forma>();

//Inyectando la dependencia
Forma circuloRojo = new Circulo( new Rojo());
Forma circuloAzul = new Circulo( new Azul());
Forma cuadradoRojo = new Cuadrado( new Rojo());
Forma cuadradoAzul = new Cuadrado(new Azul());


//Aplicando Polimorfismo
formas.Add(circuloRojo);
formas.Add(circuloAzul);
formas.Add(cuadradoRojo);
formas.Add(cuadradoAzul);


//Output
foreach (var item in formas)
{
    item.Dibujar();
}








Console.Read();
