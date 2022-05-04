namespace ignatov10.Models
{
    public class ClientSub
    {
        public int ClientId { get; set; }
        public int SubscriptionId { get; set; }

        public ClientSub(int clientId, int subscriptionId)
        {
            ClientId = clientId;
            SubscriptionId = subscriptionId;
        }
    }
}
