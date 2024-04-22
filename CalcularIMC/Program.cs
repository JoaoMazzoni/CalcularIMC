while (true)
{
    double altura;
    double peso;
    string sexo = "";
    double IMC;
    int opcao = 0;

    do
    {
        Console.Write("Digite a altura (Metros): ");
        altura = double.Parse(Console.ReadLine());
        if (altura <= 0)
        {
            Console.WriteLine("\nValor inválido para altura!");
            Console.WriteLine("--------------------------------------------\n\n");
        }

    } while (altura <= 0);

    do
    {
        Console.Write("Digite o peso (KG): ");
        peso = double.Parse(Console.ReadLine());
        if (peso <= 0)
        {
            Console.WriteLine("\nValor inválido para peso!");
            Console.WriteLine("--------------------------------------------\n\n");
        }

    } while (peso <= 0);

    Console.WriteLine("\nSelecione o sexo: \n");
    Console.WriteLine("|1| Feminino");
    Console.WriteLine("|2| Masculino");
    opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {

        case 1:
            sexo = "Feminino";
            break;

        case 2:
            sexo = "Masculino";
            break;
    }


    IMC = peso / (altura * altura);

    Console.WriteLine("\n\nAltura {0:0.00}cm", altura);
    Console.WriteLine("Peso: {0:0.00}kg", peso);
    Console.WriteLine("Sexo: {0}", sexo);
    Console.WriteLine("IMC: {0:0.00}", IMC);

    if (IMC < 18.5)
    {
        Console.WriteLine("Situação: Baixo Peso");
    }

    else if (IMC >= 18.5 && IMC <= 24.9)
    {
        Console.WriteLine("Situação: Peso Normal");
    }

    else if (IMC >= 25 && IMC <= 29.9)
    {
        Console.WriteLine("Situação: Sobrepeso");
    }

    else if (IMC >= 30 && IMC <= 34.9)
    {
        Console.WriteLine("Situação: Obesidade Grau I");
    }

    else if (IMC >= 35 && IMC <= 39.9)
    {
        Console.WriteLine("Situação: Obesidade Grau II");
    }

    else if (IMC >= 40)
    {
        Console.WriteLine("Situação: Obesidade Grau III");
    }

    
        Console.Write("\nPressione qualquer tecla: ");
        Console.ReadKey();
        Console.Clear();
    
}