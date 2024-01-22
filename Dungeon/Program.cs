// Program.cs
class Program
{
    static void Main()
    {
        UserInterface ui = new UserInterface();
        PlayerInteractionClass playerClass = new PlayerInteractionClass();

        playerClass.OnInformPlayer += ui.DisplayMessage;

        playerClass.InteractWithPlayer();
    }
}
