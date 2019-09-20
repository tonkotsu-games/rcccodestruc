public interface IAction
{
    void Enter();

    void Execute();

    void Exit();

    bool IsDone();
}