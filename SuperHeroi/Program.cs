Console.WriteLine("-----------------Super herói-----------------");

//Variaveis
string? Nome;
string? input;
string? Resposta;
bool Menu = true;
decimal Xp;
int contador = 0;

//Loop de repetição para informa ao usuário qual o nivel de experiencia do seu heroi. Que o meu eo heróis dos heróis DEUS.
while (Menu)
{
    Console.WriteLine("Qual o nome do seu herói ?");
    Nome = Console.ReadLine()?.ToString();

    Console.WriteLine("Nivel do seu herói");
     input = Console.ReadLine()?.ToString();

    if (decimal.TryParse(input, out Xp))
    {
        for (decimal i = 0; i < Xp;)
        {
            if (Xp == 1000)
            {
                Console.WriteLine($"O nivél do {Nome} e ferro\n");
                break;
            }
            else if(Xp >= 1001 && Xp <= 2000)
            {
                Console.WriteLine($"O nivel do {Nome} e bronze\n");
                break;
            }
            else if(Xp >= 2001 && Xp <= 2500)
            {
                Console.WriteLine($"O nivel do {Nome} é: prata\n");
                break;
            }
            else if (Xp >= 2501 && Xp <= 5000)
            {
                Console.WriteLine($"O nivel do {Nome} é : ouro\n");
                break;
            }
            else if(Xp >= 5001 && Xp <= 5500)
            {
                Console.WriteLine($"O nivel do {Nome} é : platina\n");
                break;
            }
            else if(Xp >= 5501 && Xp <= 8000)
            {
                Console.WriteLine($"O nivel do {Nome} é : diamante\n");
                break;
            }
            else if(Xp >= 8001 && Xp <= 9000)
            {
                Console.WriteLine($"O nivel do {Nome} é : Imortal\n");
                break;
            }
            else if(Xp >= 9001 && Xp <= 10000)
            {
                Console.WriteLine($"O nivel de {Nome} é : Radiante\n");
                break;
            }
            else if(Xp > 10000)
            {
                Console.WriteLine($"{Nome} já chegou no limite de xp");
                break;
            }
            else
            {
                Console.WriteLine("Seu herói não possue o nivel necessario. Volte a farma\n");
                return;
            }
        }
    }
    else
    {
        Console.WriteLine("Nivel do herói aceita apenas numeros decimal");
    }

    Console.WriteLine("Deseja verifcar outro herói? (S/N)");
    Resposta = Console.ReadLine()?.ToString();
    if (Resposta?.ToUpper() != "s")
    {

    }
    else
    {
        Menu = false;
    }
    contador++;
}


