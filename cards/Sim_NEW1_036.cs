﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_NEW1_036 : SimTemplate//commanding shout
    {

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            for (int i = 0; i < temp.Count; i++)
            {
                temp[i].cantLowerHPbelowONE = true;
            }
            p.drawACard(CardDB.cardName.unknown, ownplay);
        }

    }
}
