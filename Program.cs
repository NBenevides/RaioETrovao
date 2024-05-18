Console.Clear();

Console.Write("Digite a quantos segundos ouviu o raio: ");
double segundos = Convert.ToDouble(Console.ReadLine());

double resultado = DistanciaDoRaioKm(segundos);

Console.Write($"Você esta a {resultado:N5}km do trovão");

double DistanciaDoRaioKm(double segundos)
{
    const double VelocidadeDoSomKmS = 340.29 / 1000;
    return segundos * VelocidadeDoSomKmS;
}
