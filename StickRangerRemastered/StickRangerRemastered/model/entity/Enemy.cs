using StickRangerRemastered.model.type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickRangerRemastered.model.entity
{
    class Enemy
    {

        // attack specific
        public uint health { get; }
        public uint minAttack { get; }
        public uint maxAttack { get; }
        public uint minAGI { get; }
        public uint maxAGI { get; }
        public uint range { get; }
        public DamageType strenghts { get; }
        public DamageType weaknesses { get; }

        // drop specific
        public uint level { get; }
        public uint exp { get; }
        public uint gold { get; }
        public List<Tuple<Item, double>> drops { get; }

        // textures
        public string headColor { get; }
        public string bodyColor { get; }
        public string head { get; }
        public string attack1 { get; }
        public string attack2 { get; }
        public EnemyType type { get; }

        public Enemy()
        {

        }
    }
}
