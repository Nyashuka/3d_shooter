using System;

namespace _3d_shooter.Character.Input
{
    public interface IUserInput
    {
        event Action<PlayerInputData> MoveEvent;
        void OnUpdate();
    }
}