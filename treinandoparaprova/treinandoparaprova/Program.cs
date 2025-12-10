Console.WriteLine("\n-----Ativide1---");

int idade;
Console.WriteLine("qual a sua idade?"); 
idade = int.Parse(Console.ReadLine()); // o int.parse pega uma string e tranforma para int


// aqui eu criei uma variabel int idade, ela guarda um numero inteiro
//depois eu pergunto a idade do usuario com console.writeline.
// o usuario digita um texto, console.readline, sempre le como string, mesmo que o usuario digite 18
// int.parse converte essa string para o numero 

/* int.Parse(Console.ReadLine());*/ //isso transforma, por exemplo "18" -> 18 (numero)
                                    // a variavel idade recebe esse numero int.parse( console. readline));

/*Console.WriteLine() ➜ mostra a pergunta

Console.ReadLine() ➜ pega a resposta (como texto)

int.Parse() ➜ transforma o texto em número

idade = ... ➜ guarda o número dentro da variável idade*/

Console.WriteLine("\nAtividade2");

int numero1;
int numero2;
Console.WriteLine("qual seria o numero?");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("proximo numero");
numero2 = int.Parse(Console.ReadLine());
int soma = numero1 + numero2;
Console.WriteLine("A soma é: " + soma);


