Console.WriteLine("--- Etanol ou Gasolina? ---");
 
Console.Write("Coloque o preço do etanol (R$).....: ");
double PcE = Convert.ToDouble(Console.ReadLine());
 
Console.Write("Coloque o preço da gasolina (R$)...: ");
double PcG = Convert.ToDouble(Console.ReadLine());
 
double R = CalcularRazao(PcE, PcG);
bool VLG = ValeAPenaGasolina(R);
 
double porc = R * 100;
Console.WriteLine();
Console.WriteLine($"O preço do etanol corresponde a {porc:F1}% do preço da gasolina.");
 
if (VLG)
    Console.WriteLine("Recomendação: Abasteça com GASOLINA.");
else
    Console.WriteLine("Recomendação: Abasteça com ETANOL.");
 
double CalcularRazao(double E, double G)
{
    return E / G;
}
 
bool ValeAPenaGasolina(double RGeE)
{
    return RGeE > 0.73;
}