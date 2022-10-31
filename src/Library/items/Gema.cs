namespace RoleplayGame.Items
{
    /// <summary>
    /// Gemas.
    /// </summary>
    public class Gema : IAttackItem
    {
        public int Ataque;

        public Gema(int ataque)
        {
            this.Ataque = ataque;
        }

        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return this.Ataque;
            }
        }

        

        public override string ToString()
        {
            return "Gema";
        }
    }
}