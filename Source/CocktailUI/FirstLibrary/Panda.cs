namespace FirstLibrary
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Panda
    {
        #region Variables.
        private readonly string _name;

        #endregion

        public Panda(string name)
        {
            _name = name;
            Population++;
        }

        #region Properties
        public static int Population { get; private set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Name: {_name}";
        }
        #endregion
    }

}
