namespace RoleplayGame.Items
{
    public class HachaLibertad : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 30;
            }
            
        }

        public override string ToString()
        {
            return "Hacha de la Libertad";
        }

    }
}
