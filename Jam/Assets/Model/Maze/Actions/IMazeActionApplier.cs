using Assets.Model.Maze;
using Assets.Scripts;

namespace Assets.Model
{
  public interface IMazeActionApplier
  {
    void ApplyAction(GameState state, MazeActionType actionType);
  }
}