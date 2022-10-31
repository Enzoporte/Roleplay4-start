using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje exclusivamente creado para pablo
    /// </summary>
    public class Princesa : Character
    {
        public Princesa(string name)
            : base(name)
        {
            this.Health = 500;
            this.AddItem(new Robes());
        }
    }
}