namespace Tumakov_DZ.Classes
{
    internal class ListBuildings
    {
        public Building[] buildings = new Building[10];
        public Building this[int index]
        {
            get
            {
                return buildings[index];
            }
            set
            {
                buildings[index] = value;
            }
        }
    }
}
