namespace Parcel.Objects
{
  public class ParcelVariables
  {
    public int Length{get;set;}
    public int Width{get;set;}
    public int Height{get;set;}
    public int Weight{get;set;}
    public int Volume()
    {
      return Length * Width * Height;
    }
    public int Price()
    {
      return (5*Weight)+(Volume()/6);
    }
  }
}
