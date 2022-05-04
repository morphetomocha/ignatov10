using System;
using System.Collections.Generic;
using System.Text;

namespace ignatov10.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public string Plan { get; set; }
        public string Bonuses { get; set; }

        public Subscription(int id, string plan, string bonuses)
        {
            Id = id;
            Plan = plan;
            Bonuses = bonuses;
        }

        public Subscription(int id, string plan)
        {
            Id = id;
            Plan = plan;
        }

        public Subscription(int id)
        {
            Id = id;
            Plan = "Стандартный тариф";
        }
    }
}
