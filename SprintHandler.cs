using UnityEngine;

namespace SprintMod
{
    public class SprintHandler
    {
        public bool IsSprinting => _isSprinting;

        public float sprintSpeed;

        bool _isSprinting;
        float _normalSpeed;
        FirstPersonController player;

        public void OnSwitchScene(int buildindex, string scene)
        {
            player = GameManager.instance._firstPersonController;
            if (player == null)
            {
                Core.Logger.Msg("Player not found in scene: " + scene);
                return;
            }
            _normalSpeed = Patches.PlayerController.GetSpeed(player);
            sprintSpeed = _normalSpeed * 1.8f;
        }

        public void Update()
        {
            if (player == null) return;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                if (!_isSprinting)
                {
                    Patches.PlayerController.SetSpeed(player, sprintSpeed);
                    _isSprinting = true;
                }
            }
            else
            {
                if (_isSprinting)
                {
                    Patches.PlayerController.SetSpeed(player, _normalSpeed);
                    _isSprinting = false;
                }
            }
        }
    }
}
