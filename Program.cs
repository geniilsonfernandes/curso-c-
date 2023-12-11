// See https://aka.ms/new-console-template for more information
// using construtores.models;




/*

 - GUIA DE ESTUDOS

    DE CADA NOVA COISA, APRENDER PELO MENOS 3 METODOS DA CLASSE
    EX: ARRAY.FOREACH() ... ETC 
    E DOCUMENTAR ABAIXO COM COMENTS


*/

// TUPLAS



// DECLARAR UMA TUPLA
//   dessa forma consigo da o nome para as variaveis
(int id, string nome, string sobrenome) tupla = (1, "Genil", "C#");

// OUTRA FORMA DE DECLARAR UMA TUPLA
ValueTuple<int, string, string> tupla2 = (1, "Genil", "C#");
var tupla3 = Tuple.Create(1, "Genil", "C#");

Console.WriteLine(tupla.id);
Console.WriteLine(tupla2.Item3);
Console.WriteLine(tupla.GetType());
Console.WriteLine(tupla.ToString());

