namespace myBanker.Model;

public class DebitCard : Card
{
    public DebitCard(string cardHolderName) : base(cardHolderName)
    {
        GenerateCardNumber();
        GenerateExpiryDate(); // Generate expiry date to ensure consistency, even if it's null
    }

    public override void GenerateCardNumber()
    {
        CardNumber = "2400" + new string(Enumerable.Range(0, 12).Select(_ => (char)random.Next('0', '9' + 1)).ToArray());
    }

    public override void GenerateExpiryDate()
    {
        ExpiryDate = null; // No expiry date for Debit cards
    }
}