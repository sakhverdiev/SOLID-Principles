// ======================================================================================================
// I – Interface Segregation Principle (ISP) => Interface-ler mumkun qeder parcalanmalidir.
// Yeni ki bir Interface, hemin Class-in ehtiyac duydugu metodlari saxlamalidir, artiq metod olmamalidir.
// ======================================================================================================


namespace ISP_Before
{
    public interface IProduct
    {
        int ID { get; set; }
        double Weight { get; set; }
        int Stock { get; set; }
        int Inseam { get; set; }
        int WaistSize { get; set; }
    }

    public class Jeans : IProduct
    {
        public int ID { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }
        public int Inseam { get; set; }
        public int WaistSize { get; set; }
    }
    public class BaseballCap : IProduct
    {
        public int ID { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }
        public int Inseam { get; set; }
        public int WaistSize { get; set; }
        public int HatSize { get; set; }
    }
}


// ===========================================================================


namespace ISP_After
{
    public interface IProduct
    {
        int ID { get; set; }
        double Weight { get; set; }
        int Stock { get; set; }
    }
    public interface IPants
    {
        int Inseam { get; set; }
        int WaistSize { get; set; }
    }
    public interface IHat
    {
        int HatSize { get; set; }
    }

    public class Jeans : IProduct, IPants
    {
        public int ID { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }
        public int Inseam { get; set; }
        public int WaistSize { get; set; }
    }

    public class BaseballCap : IProduct, IHat
    {
        public int ID { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }
        public int HatSize { get; set; }
    }
}