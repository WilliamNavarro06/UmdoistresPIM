for(int i = 0; i <= 101; i++){
    if(i % 4 == 0){
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("PIM");
        Console.ResetColor();
    }
    else{
        Console.WriteLine(i);
    }
}