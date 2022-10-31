namespace RoleplayGame.Items
{
    /// <summary>
    /// Escudo Medieval. Gran escudo. Permite pegar.
    /// </summary>
    public class Katana : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 40;
            }
        }

        public override string ToString()
        {
            return "Katana";
        }
    }
}