using liblab2.Test;
try
{
    Console.WriteLine("Уведіть текст");
    string str = Console.ReadLine();
    var reve = new Reverse();
    Console.WriteLine(reve.rev(str));
    return 0;
}
catch (Exception)
{
    return 1;
    throw;
}