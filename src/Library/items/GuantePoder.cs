using System.Collections.Generic;
namespace RoleplayGame.Items
{
    /// <summary>
    /// Túnica. Permite defenderse levemente.
    /// </summary>
    public class GuantePoder : IAttackItem
    {
        public List<Gema> ListaGemas;
        public int DañoBase = 10;

        public GuantePoder()
        {
            this.ListaGemas = new List<Gema>();
        }

        /// <summary>
        /// El poder de ataque.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return this.CalcularDaño();
            }
        }

        public int CalcularDaño()
        {
            int daño = this.DañoBase;
            foreach (var elemento in this.ListaGemas)
            {
                daño += elemento.AttackPower;
            }
            return daño;
        }

        public void AgregarGema(Gema gema)
        {
            ListaGemas.Add(gema);
        }

        public override string ToString()
        {
            return "Robes";
        }
    }
}