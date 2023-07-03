namespace Simple_DnD_Builder.Models.Player
{
    public class PlayerHelper
    {
        public static void PlayerPurger() 
        {
        for(int i = Player.Players.Count - 1; i > 0; i--)
            {
                Player.Players.RemoveAt(i);
            }
        }
    }
}
