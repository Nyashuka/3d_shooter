using _3d_shooter.Character.Input;
using Character;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _3d_shooter.Character
{
    [RequireComponent(typeof(CharacterController))]
    public class Player : MonoBehaviour
    {
        [SerializeField] private CharacterController _controller;
        [SerializeField] private int _speed;
        private PlayerMove _playerMove;
        private void Start()
        {
            _playerMove = new PlayerMove(_speed, new PCUserInput(), _controller);
        }

        private void Update()
        {
            _playerMove.Move();
        }
        
    }
}