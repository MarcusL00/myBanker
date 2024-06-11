using myBanker.Model;

class Program
{
    static void Main(string[] args)
    {
        Card debitCard = new DebitCard("Roberto");
        Card maestro = new Maestro("Shazil");
        Card visaElectron = new VisaElectron("magnussy");
        Card visaCredit = new VisaCredit("Otto wind");
        Card mastercard = new Mastercard("Marcus lystrup");

        Console.WriteLine(debitCard);
        Console.WriteLine(maestro);
        Console.WriteLine(visaElectron);
        Console.WriteLine(visaCredit);
        Console.WriteLine(mastercard);
    }
}