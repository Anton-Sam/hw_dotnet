namespace HW06.AssemblyOne
{
    public class Motorcycle
    {
        private string vinNumber;

        public string VinNumber  //Full property exapmle
        {
            get { return vinNumber; }
            set { vinNumber = value; }
        }

        public ushort MaxSpeed { get; } = 300;  //Readonly autoproperty exampler

        public int OdometrePublic { get; set; }

        private int OdometrePrivate { get; set; }

        protected int OdometreProtected { get; set; }

        internal int OdometreInternal { get; set; }

        private protected int OdometrePrivateProtected { get; set; }

        protected internal int OdometreProtectedInternal { get; set; }

        void StartEnginePrivate()
        { }

        public void StartEnginePublic()
        { }
    }
}
