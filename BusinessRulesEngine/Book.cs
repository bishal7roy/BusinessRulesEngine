namespace BusinessRulesEngine
{
    public class Book : PhysicalProduct
    {
        public Book() : base()
        {
            RoyaltyDepartment royalty = new RoyaltyDepartment();
            royalty.Royalty(true);    //RoyaltyDepartment will be called to provide duplicate slip
        }
    }
}
