namespace myBanker.Model;

class VisaCredit : Card
{
    public VisaCredit(string cardHolderName) : base(cardHolderName)
    {
        GenerateCardNumber();
        GenerateExpiryDate();
    }

    public override void GenerateCardNumber()
    {
        CardNumber = "4" + new string(Enumerable.Range(0, 15).Select(_ => (char)random.Next('0', '9' + 1)).ToArray());
    }

    public override void GenerateExpiryDate()
    {
        DateTime now = DateTime.Now;
        ExpiryDate = now.AddYears(5).ToString("MM/yy");
    }
}