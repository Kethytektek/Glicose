int avaliacao;
void loop(){
Console.WriteLine("------------Diabetes gestacional------------");

Console.WriteLine("Digite a sua glicose:");
avaliacao = Convert.ToInt32(Console.ReadLine());



        if(avaliacao < 92)
    {
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.Write("reavaliar entre 24 e 28 semanas com TTOG 75g de glicose\n");
    }

        if(avaliacao < 126 && avaliacao >= 92)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Compatível com Diabetes Gestacional\n");}
    
        if(avaliacao >= 126)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Diabetes Mellitus na gravidez\n");
    }

    Console.ResetColor();

    
    Console.WriteLine("Você quer recomeçar o programa? [S/N]");
    string reposta = Console.ReadLine()!;
    
    if(reposta.ToUpper() == "S")
    {
    Console.ResetColor();
        loop();
    }
    else{

    }
}
loop();