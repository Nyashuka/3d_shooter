using _3d_shooter.Character.Input;
using UnityEngine;

namespace _3d_shooter.Character
{
    [RequireComponent(typeof(CharacterController))]
    public class Player : MonoBehaviour
    {
        [SerializeField] private CharacterController _controller;
        [SerializeField] private int _speed;
        [SerializeField] private int _jumpHeight;
        private CharacterMovement _characterMovement;
        
        private void Start()
        {
            _characterMovement = new CharacterMovement(_speed, _jumpHeight, _controller);
        }

        private void Update()
        {
            _characterMovement.OnUpdate();
        }
    }
}