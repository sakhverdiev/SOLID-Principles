// ========================================================================================
// O - Open/Closed Principle (OCP)  => Class genislenmeye aciq, deyismeye qapali olmalidir.
// ========================================================================================


namespace OCP_Before
{
    class IPhone
    {
        public string? Processor { get; set; }
        public string? DisplayResolution { get; set; }
        public string? RAM { get; set; }
        public string? ROM { get; set; }

        public string? Model { get; set; }

        private double _price;

        public double Price
        {
            get { return _price; }
            set
            {
                if (Model == "Iphone14")
                    _price = 2000;
                else if (Model == "Iphone15")
                    _price = 2500;
                else throw new InvalidOperationException();
            }
        }

        public void SetSpecifications()
        {
            //do something
        }
    }

}


// ===========================================================================


namespace OCP_After
{
    interface IModel
    {
        void SetModel();
        double SetPrice();
    }

    class IPhoneXR : IModel
    {
        public string? ModelName { get; set; }

        public void SetModel()
        {
            ModelName = nameof(IPhoneXR);
        }

        public double SetPrice()
        {
            return 2000;
        }
    }
    class IPhoneX : IModel
    {
        public string? ModelName { get; set; }

        public void SetModel()
        {
            ModelName = nameof(IPhoneX);
        }

        public double SetPrice()
        {
            return 2500;
        }
    }

    class IPhone
    {
        public string? Processor { get; set; }
        public string? DisplayResolution { get; set; }
        public string? RAM { get; set; }
        public string? ROM { get; set; }

        public IModel Model { get; }

        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = Model.SetPrice(); }
        }

        public void SetSpecifications()
        {
            //...
        }
    }


}