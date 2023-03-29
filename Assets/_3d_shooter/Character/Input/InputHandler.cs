using Character;
using UnityEngine;

namespace _3d_shooter.Character.Input
{
    public class InputHandler
    {
        private readonly PlayerInputSystem _playerInputSystem;

        public InputHandler()
        {
            _playerInputSystem = new PlayerInputSystem();
            _playerInputSystem.Enable();
        }

        public Vector2 GetMoveDirection()
        {
            return _playerInputSystem.Player.Move.ReadValue<Vector2>();
        }

        public bool JumpPressed()
        {
            return _playerInputSystem.Player.Jump.IsPressed();
        }

        ~InputHandler()
        {
            _playerInputSystem.Disable();
        }
    }
}