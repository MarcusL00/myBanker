namespace myBanker.Model;

class Maestro : Card
{
    public Maestro(string cardHolderName) : base(cardHolderName)
    {
        GenerateCardNumber();
        GenerateExpiryDate();
    }

    public override void GenerateCardNumber()
    {
        // array over the different prefixes
        string[] prefixes = { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763" };
        // gives the prefix variable the prefix thats picked with a random generator
        string prefix = prefixes[random.Next(prefixes.Length)];
        // assigns the cardnumber with first the prefix and then a random sequence of 15 numbers between 0-9
        CardNumber = prefix + new string(Enumerable.Range(0, 15).Select(_ => (char)random.Next('0', '9' + 1)).ToArray());
    }

    public override void GenerateExpiryDate()
    {
        // Creates the expirydate
        DateTime now = DateTime.Now;
        ExpiryDate = now.AddYears(5).AddMonths(8).ToString("MM/yy");
    }
}