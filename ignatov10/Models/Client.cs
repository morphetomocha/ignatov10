using System;
using System.Collections.Generic;
using System.Text;

namespace ignatov10.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int SubscriptionId { get; set; }

        public Client(int id, string name, string phone, string email, int subscription)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            SubscriptionId = subscription;
        }

        public Client(int id, string name, string phone, string email)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            SubscriptionId = -1;
        }

        public Client(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Phone = "";
            Email = email;
            SubscriptionId = -1;
        }

        public string UpdateSubscription(int id)
        {
            SubscriptionId = id;

            return $"{Name} оформил подписку под номером {SubscriptionId}";
        }

        public void UpdateEmail(string newMail)
        {
            Email = newMail;
        }

        public override string ToString()
        {
            return $"Клиент: {Name}, с телефоном {Phone}, с почтой {Email}, с подпиской {SubscriptionId}";
        }
    }
}
