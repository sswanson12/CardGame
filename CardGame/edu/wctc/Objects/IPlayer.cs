namespace CardGame.edu.wctc.Objects
{
    public interface IPlayer
    {
        string ShowHand();

        IHand GetHand();
    }
}