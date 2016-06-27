using Nancy;
using Parcel.Objects;



namespace Parcel
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };
      Get["/parcel_display"] = _ => {
        ParcelVariables myParcelVariables = new ParcelVariables
        {
          Length=Request.Query["length"],
          Width=Request.Query["width"],
          Height=Request.Query["height"],
          Weight=Request.Query["weight"],
        };
        return View["parcel.cshtml", myParcelVariables];
      };
    }
  }
}
