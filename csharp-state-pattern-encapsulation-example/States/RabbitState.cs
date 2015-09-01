namespace CSharpStatePatternEncapsulationExample.States
{
  public class RabbitState : Context.State
  {
    public override void Handle(Context context)
    {
      // context.CurrentSeason setter and context.currentState cannot be accessed directly here
      // but we can call the base class to modify them

      if (context.CurrentSeason == Season.Rabbit)
      {
        base.SetSeason(context, Season.Duck);
      }

      base.SetState(context, new DuckState());
    }
  }
}
