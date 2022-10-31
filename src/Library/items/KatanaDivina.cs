namespace RoleplayGame.Items
{
    /// <summary>
    /// Escudo Medieval. Gran escudo. Permite pegar.
    /// </summary>
    public class KatanaDivina : IAttackItem
    {

        public Katana Katana = new Katana();
        public PolvoDivino PolvoDivino = new PolvoDivino();
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return Katana.AttackPower + PolvoDivino.AttackPower;
            }
        }

        public override string ToString()
        {
            return "Katana Divina";
        }
    }
}