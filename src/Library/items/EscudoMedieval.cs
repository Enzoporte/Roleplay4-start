namespace RoleplayGame.Items
{
    /// <summary>
    /// Escudo Medieval. Gran escudo. Permite pegar.
    /// </summary>
    public class EscudoMedieval : IAttackItem, IDefenseItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 10;
            }
        }

        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 30;
            }
        }

        public override string ToString()
        {
            return "Escudo Medieval";
        }
    }
}