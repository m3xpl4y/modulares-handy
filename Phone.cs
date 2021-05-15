namespace Modulares_Handy
{
    public class Phone
    {
        public string Color { get; set; }
        //Constructor
        public Phone(string color)
        {
            this.Color = color;
        }

        #region FUNCTIONS
        public void TakePicture()
        {

        }

        public string MakeCall()
        {
            return null;
        }

        public int GetFreeSpace()
        {
            return 0;
        }

        public void PrintAllFiles()
        {

        }
        #endregion
    }
}