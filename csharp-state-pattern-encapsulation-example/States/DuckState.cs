namespace CSharpStatePatternEncapsulationExample.States
{
  public class DuckState : Context.State
  {
    public override void Handle(Context context)
    {
      // context.CurrentSeason setter and context.currentState cannot be accessed directly here
      // but we can call the base class to modify them

      if (context.CurrentSeason == Season.Duck)
      {
        base.SetSeason(context, Season.Rabbit);
      }

      base.SetState(context, new RabbitState());
    }
  }
}
