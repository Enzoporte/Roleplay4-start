namespace RoleplayGame.Items
{
    /// <summary>
    /// Escudo Medieval. Gran escudo. Permite pegar.
    /// </summary>
    public class PolvoDivino : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 15;
            }
        }


        public override string ToString()
        {
            return "Polvo de los Dioses";
        }
    }
}