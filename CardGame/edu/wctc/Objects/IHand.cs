namespace CardGame.edu.wctc.Objects
{
    public interface IHand
    {
        bool AddCard(ICard card);

        int MaxHandSize();
    }
}