using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickRangerRemastered.model.entity
{
    class Enemy
    {

        private uint health;
        private uint minAttack;
        private uint maxAttack;
        private uint minAGI;
        private uint maxAGI;
        private uint range;

        private uint level;
        private uint exp;
        private uint gold;

        private string headColor;
        private string bodyColor;

        private HeadType head;
        private EnemyType type;
        private DamageType strenghts;
        private DamageType weaknesses;

        private List<Tuple<uint, double>> drops;
    }
}
