namespace RoleplayGame.Items
{
    /// <summary>
    /// Capa de invisibilidad. Aumenta la defensa en 30.
    /// </summary>
    public class CapaInvisibilidad : IDefenseItem
    {

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
            return "Capa Invisibilidad";
        }
    }
}