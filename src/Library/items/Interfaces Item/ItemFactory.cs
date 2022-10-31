namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemType
    {
        Magic = 1,
        Robes = 2,
        EscudoMedieval = 3,
        Katana = 7,
        KatanaDivina = 8,

    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Permite crear elementos dado un tipo de elemento.
        /// </summary>
        /// <param name="type">El tipo de elemento</param>
        /// <returns>El elemento</returns>
        public static IItem GetItem(ItemType type)
        {
            switch (type)
            {
                case ItemType.Magic: return new Magic();
                case ItemType.Robes: return new Robes();
                case ItemType.EscudoMedieval: return new EscudoMedieval();
                case ItemType.Katana: return new Katana();
                case ItemType.KatanaDivina: return new KatanaDivina();



                default: return null;
            }
        }
    }
}