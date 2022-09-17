decimal GastosMensais, ValorAinvestir;
double dividendYield;

Console.WriteLine("---vivendo de dividendos ---\n");


Console.Write("Gastos Mensais (em R$)...:");

GastosMensais = Convert.ToDecimal(Console.ReadLine());

Console.Write("rendimentos mensais(%)...:");
dividendYield = Convert.ToDouble(Console.ReadLine());

ValorAinvestir = GastosMensais / Convert.ToDecimal(dividendYield / 100);
Console.WriteLine($"\nPara receber {GastosMensais:C} Por Mês Com Redimentos de {dividendYield:N1}% você precisa ter investido {ValorAinvestir:C}. ");


