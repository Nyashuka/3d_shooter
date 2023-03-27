using System;
using Character;
using UnityEngine;

namespace _3d_shooter.Character.Input
{
    public class PCUserInput : IUserInput
    {
        private readonly PlayerInputSystem _playerInputSystem;
        public event Action<PlayerInputData> MoveEvent;

        public PCUserInput()
        {
            _playerInputSystem = new PlayerInputSystem();
            _playerInputSystem.Enable();
        }

        public void OnUpdate()
        {
            MoveEvent?.Invoke(new PlayerInputData(_playerInputSystem.Player.Jump.IsPressed(), _playerInputSystem.Player.Move.ReadValue<Vector2>()));
        }

        ~PCUserInput()
        {
            _playerInputSystem.Disable();
        }
    }
}