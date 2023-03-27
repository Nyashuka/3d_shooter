using UnityEngine;

namespace _3d_shooter.Character.Input
{
    public class PlayerInputData
    {
        public PlayerInputData(bool isJumped, Vector2 moveDirection)
        {
            IsJumped = isJumped;
            MoveDirection = moveDirection;
        }

        public bool IsJumped { get; }
        public Vector2 MoveDirection { get; }
    }
}