namespace RoleplayGame.Items
{
    public class HachaLibertad
    {
        string Name;
        int AttackPower{ get; }

        public HachaLibertad()
        {
            this.Name = "Libertad";
            this.AttackPower = 30;
        }

        public int GetAttackPower
        {
            get
            {
                return 30;
            }
            
        }

        public string ToString()
        {
            return "Hacha Libertad: Y se marcho y a su barco le llamo Libertad";
        }

    }
}
