Console.WriteLine("-----ETANOL OU GASOLINA-----");

Console.Write("preço do Etanol (R$).....:");
decimal Etanol = Convert.ToDecimal(Console.ReadLine());

Console.Write("preço da gasolina (R$).....:");
decimal Gasolina = Convert.ToDecimal(Console.ReadLine());

string recomendacao;

if (AbastecerComEtanol (Etanol, Gasolina))   
{
    recomendacao = "Gasolina";
}
else 
{
    recomendacao = "Etanol";
}

double razao = RazaoEtanolGasolina (Etanol, Gasolina ) * 100;

Console.WriteLine($"\n O preço etanol correposto a {razao:N1}% do preço da gasolina");
Console.WriteLine($"\n Recomendado abastecer com {recomendacao.ToUpper()}");

double RazaoEtanolGasolina(decimal preçoEtanol, decimal preçoGasolina)
{
    return Convert.ToDouble(preçoEtanol / preçoGasolina);
}
bool AbastecerComEtanol( decimal preçoEtanol, decimal preçoGasolina)
{
    const double MinimaRazaoUsoGasolina = 0.73; 
    return RazaoEtanolGasolina(preçoEtanol, preçoGasolina) >= MinimaRazaoUsoGasolina;
}




