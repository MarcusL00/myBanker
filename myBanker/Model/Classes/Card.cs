namespace myBanker.Model;

public class Card: Prefix   
{
    
    // fields
    private string _name;
    private string _cardAccount;
    private int _cardNumber;
    private DateTime _expireDate;

    // properties
    public string Name
    {
        get => _name;
        set => _name = value;
    }
    public string CardAccount
    {
        get => _cardAccount;
        set => _cardAccount = value;
    }
    public int CardNumber
    {
        get => _cardNumber;
        set => _cardNumber = value;
    }
    public DateTime ExpireDate
    {
        get => _expireDate;
        set => _expireDate = value;
    }
}