using _3d_shooter.Character.Input;
using UnityEngine;

namespace _3d_shooter.Character
{
    public class PlayerMove
    {
        private readonly int _speed;
        private readonly IUserInput _userInput;
        private readonly CharacterController _characterController;
        private Vector3 _motion = Vector3.zero;
        
        public PlayerMove(int speed, IUserInput userInput, CharacterController characterController)
        {
            _speed = speed;
            _userInput = userInput;
            _characterController = characterController;

            _userInput.MoveEvent += OnMove;
        }
        
        public void Move()
        {
            _userInput.OnUpdate();
        }

        private void OnMove(PlayerInputData inputData)
        {
            _motion.x = inputData.MoveDirection.x * _speed;
            _motion.z = inputData.MoveDirection.y * _speed;

            if (inputData.IsJumped && _characterController.isGrounded)
            {
                _motion.y = 6;
            }

            _motion.y -= 9.81f * Time.deltaTime;

            _characterController.Move(_motion * Time.deltaTime);
        }
    }
}