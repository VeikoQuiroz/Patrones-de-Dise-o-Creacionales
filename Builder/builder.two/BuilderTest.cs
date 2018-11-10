using System;

namespace builder.two
{
    class BuilderTest
    {
        static void Main(string[] args)
        {
            String[] datos = { "d", "g", "a", "b", "c", "h", "k" };
            OrdenacionFactory factory = new OrdenacionFactory();
            OrdenacionBuilder builder = factory.GetOrdenacionBuilder("QS");
            OrdenacionDirector director = new OrdenacionDirector(builder);
            director.build(datos);
            for (int i = 0; i < datos.Length; i++)
            {
                Console.WriteLine(datos[i]);
            }
            Console.ReadKey();
        }
    }
}
