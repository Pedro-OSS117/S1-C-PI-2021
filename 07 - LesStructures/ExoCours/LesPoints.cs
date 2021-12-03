
namespace ExoCours
{
    public struct Point
    {
        public int x;
        public int y;

        private string _name;

        public void SetName(string newName)
        {
            if(newName == "")
            {
                newName ="Mettez un nom bordel";
            }
            _name = newName;
        }
    }
}