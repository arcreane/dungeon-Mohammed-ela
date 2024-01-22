public class PlayerInteractionClass : CommunicatingClass
{
    public void InteractWithPlayer()
    {
        ReceivePlayerAction("Jump");
        SendPlayerInformation("You received a new item");
    }
}
