using classeheranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace classeheranca
{
    //classe base (superclasse)
    internal class Animal
    {
        //propriedade da classe animal
        public string Nome {  get; set; }

        // metodo que sera sobrecarregado nas classes derivadas
        public virtual void EmitirSom()
        {
            Console.WriteLine("o animal emite um som");
        }
    }

    // calsse derivada (subclasse)
    internal class Cachorro : Animal // aqui ela esta herdando as carecteristacas da classe original
    {
        // sobreescrevendo o metodo emitirSom
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} late: AU AU!");
        }
    }
    //outra classe derivada
    internal class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} mia: MIAU!");
        }
    }
}
internal class Program // basicmanete rode o programa
{
    static void Main(string[] args)
    {
        // criando instancias das classes derivada
        Animal meuCachorro = new Cachorro { Nome = "rex" };
        Animal meuGato = new Gato { Nome = "Felix" };

        // chamando metodo emitirsom para cada animal
        meuCachorro.EmitirSom(); // saida: rex late: auau
        meuGato.EmitirSom(); // saida; felix mia; miau miau

        //ultilizando polimorfismo: array de animals
        Animal[] animais = { meuCachorro, meuGato };

        foreach (var animal in animais)
        {
            animal.EmitirSom(); // cada obejto chama o metodo adequado de sua classe
        }
    }
}