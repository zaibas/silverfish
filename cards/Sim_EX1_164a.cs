using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_164a : SimTemplate //nourish
	{

//    erhaltet 2 manakristalle.

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                if (p.ownMaxMana == 10)
                {
                    p.drawACard(CardDB.cardName.excessmana, true);
                }
                else
                {
                    p.ownMaxMana++;
                    p.mana++;
                }
                if (p.ownMaxMana == 10)
                {
                    //this.owncarddraw++;
                    p.drawACard(CardDB.cardName.excessmana, true);
                }
                else
                {
                    p.ownMaxMana++;
                    p.mana++;
                }
            }
            else
            {
                if (p.enemyMaxMana == 10)
                {
                    p.drawACard(CardDB.cardName.excessmana, false);
                }
                else
                {
                    p.enemyMaxMana++;
                }
                if (p.enemyMaxMana == 10)
                {
                    //this.owncarddraw++;
                    p.drawACard(CardDB.cardName.excessmana, false);
                }
                else
                {
                    p.enemyMaxMana++;
                }
            }
		}

	}
}