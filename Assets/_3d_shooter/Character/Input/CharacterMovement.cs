using UnityEngine;

namespace _3d_shooter.Character.Input
{
    public class CharacterMovement
    { 
        private const float GRAVITY_FORCE = 9.81f;
        private readonly int _speed;
        private readonly int _jumpHeight;
        private readonly CharacterController _characterController;
        private readonly InputHandler _inputHandler;
        private Vector3 _motion = Vector3.zero;
        
        public CharacterMovement(int speed, int jumpHeight, CharacterController characterController)
        {
            _speed = speed;
            _jumpHeight = jumpHeight;
            _characterController = characterController;
            _inputHandler = new InputHandler();
        }
        
        private void Gravity()
        {
            _motion.y -= GRAVITY_FORCE * Time.deltaTime;
        }

        private void Jump()
        {
            if (_inputHandler.JumpPressed() && _characterController.isGrounded)
            {
                _motion.y = _jumpHeight;
            }
        }

        private void Run()
        {
            Vector2 direction = _inputHandler.GetMoveDirection();
            
            _motion.x = direction.x * _speed;
            _motion.z = direction.y * _speed;
        }

        public void OnUpdate()
        {
            Jump();
            Run();
            Gravity();
            
            _characterController.Move(_motion * Time.deltaTime);
        }
    }
}