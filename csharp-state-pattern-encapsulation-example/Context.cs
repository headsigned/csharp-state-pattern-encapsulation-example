namespace CSharpStatePatternEncapsulationExample
{
  using System;

  public class Context
  {
    private State currentState;
    public Season CurrentSeason { get; private set; }

    public Context(State initialState, Season initialSeason)
    {
      if (initialState == null) throw new ArgumentNullException("initialState");

      currentState = initialState;
      CurrentSeason = initialSeason;
    }

    public void Request()
    {
      currentState.Handle(this);
    }

    public abstract class State
    {
      public abstract void Handle(Context context);

      protected void SetSeason(Context context, Season season)
      {
        // Even though this setter is private
        // it can be accessed from this nested class
        context.CurrentSeason = season;
      }

      protected void SetState(Context context, State state)
      {
        // Even though this variable is private
        // it can be modified from this nested class
        context.currentState = state;
      }
    }
  }
}
