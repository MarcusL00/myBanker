using System;
using System.Linq;

namespace myBanker.Model;

public abstract class Card
{
    public string CardHolderName { get; set; }
    public string CardNumber { get; protected set; }
    public string ExpiryDate { get; protected set; }
    public string AccountNumber { get; protected set; } 

    protected static Random random = new Random();
    
    protected Card(string cardHolderName)
    {
        CardHolderName = cardHolderName;
        AccountNumber = GenerateAccountNumber();
    }

    public abstract void GenerateCardNumber();
    public abstract void GenerateExpiryDate();

    protected string GenerateAccountNumber()
    {
        return "3520" + new string(Enumerable.Range(0, 10).Select(_ => (char)random.Next('0', '9' + 1)).ToArray());
    }
    
    public override string ToString()
    {
        return $"CardHolder: {CardHolderName}, CardNumber: {CardNumber}, ExpiryDate: {ExpiryDate}, AccountNumber: {AccountNumber}";
    } 
}