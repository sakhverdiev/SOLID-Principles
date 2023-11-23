// =====================================================================================================================================================
// L – Liskov‘s Substitution Principle (LSP) => Derived Class-lar torendiyi Base Class-in butun xususiyetlerini islede bilmelidir.
// Derived Class-da yaradilan obyektler, Base Class-da yaradilan Obyektler ile yer deyisdirdikde Error vermemeli ve isledilmeyen xususiyyet olmamalidir.
// =====================================================================================================================================================


namespace LSP_Before
{
    public class SumCalculator
    {
        protected readonly int[] _numbers;
        public SumCalculator(int[] numbers)
        {
            _numbers = numbers;
        }
        public virtual int Calculate() => _numbers.Sum();
    }

    public class EvenNumbersSumCalculator : SumCalculator
    {
        public EvenNumbersSumCalculator(int[] numbers)
            : base(numbers)
        {
        }
        public override int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
    }

}


// ===========================================================================


namespace LSP_After
{

    public abstract class Calculator
    {
        protected readonly int[] _numbers;
        public Calculator(int[] numbers)
        {
            _numbers = numbers;
        }
        public abstract int Calculate();
    }

    public class SumCalculator : Calculator
    {
        public SumCalculator(int[] numbers)
            : base(numbers)
        { }
        public override int Calculate() => _numbers.Sum();
    }

    public class EvenNumberSumCalculator : Calculator
    {
        public EvenNumberSumCalculator(int[] numbers)
            : base(numbers)
        { }
        public override int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
    }

}