namespace myBanker.Model;

class Mastercard : Card
{
    public Mastercard(string cardHolderName) : base(cardHolderName)
    {
        GenerateCardNumber();
        GenerateExpiryDate();
    }

    public override void GenerateCardNumber()
    {
        // array over the different prefixes
        string[] prefixes = { "51", "52", "53", "54", "55" };
        // gives the prefix variable the prefix thats picked with a random generator
        string prefix = prefixes[random.Next(prefixes.Length)];
        // assigns the cardnumber with first the prefix and then a random sequence of 15 numbers between 0-9
        CardNumber = prefix + new string(Enumerable.Range(0, 14).Select(_ => (char)random.Next('0', '9' + 1)).ToArray());
    }

    public override void GenerateExpiryDate()
    {
        DateTime now = DateTime.Now;
        ExpiryDate = now.AddYears(5).ToString("MM/yy");
    }
}