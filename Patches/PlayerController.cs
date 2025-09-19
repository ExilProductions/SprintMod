using HarmonyLib;

namespace SprintMod.Patches
{
    public static class PlayerController
    {
        // movement speeds
        private static readonly AccessTools.FieldRef<FirstPersonController, float> speedRef =
            AccessTools.FieldRefAccess<FirstPersonController, float>("_speed");
        private static readonly AccessTools.FieldRef<FirstPersonController, float> airSpeedRef =
            AccessTools.FieldRefAccess<FirstPersonController, float>("_airSpeed");

        // physics
        private static readonly AccessTools.FieldRef<FirstPersonController, float> gravityRef =
            AccessTools.FieldRefAccess<FirstPersonController, float>("_gravity");
        private static readonly AccessTools.FieldRef<FirstPersonController, float> jumpForceRef =
            AccessTools.FieldRefAccess<FirstPersonController, float>("_jumpForce");
        private static readonly AccessTools.FieldRef<FirstPersonController, float> groundDragRef =
            AccessTools.FieldRefAccess<FirstPersonController, float>("_groundDrag");
        private static readonly AccessTools.FieldRef<FirstPersonController, float> airDragRef =
            AccessTools.FieldRefAccess<FirstPersonController, float>("_airDrag");

        // rotation / mouse look
        private static readonly AccessTools.FieldRef<FirstPersonController, float> rotationSpeedRef =
            AccessTools.FieldRefAccess<FirstPersonController, float>("_rotationSpeed");
        private static readonly AccessTools.FieldRef<FirstPersonController, float> mouseSensitivityRef =
            AccessTools.FieldRefAccess<FirstPersonController, float>("_mouseSensitivity");

        // crouch
        private static readonly AccessTools.FieldRef<FirstPersonController, float> crouchSpeedMultiplierRef =
            AccessTools.FieldRefAccess<FirstPersonController, float>("_crouchSpeedMultiplier");
        private static readonly AccessTools.FieldRef<FirstPersonController, float> crouchSizeRef =
            AccessTools.FieldRefAccess<FirstPersonController, float>("_crouchSize");

        // --- Speed ---
        public static float GetSpeed(FirstPersonController instance) => speedRef(instance);
        public static void SetSpeed(FirstPersonController instance, float value) => speedRef(instance) = value;

        // --- AirSpeed ---
        public static float GetAirSpeed(FirstPersonController instance) => airSpeedRef(instance);
        public static void SetAirSpeed(FirstPersonController instance, float value) => airSpeedRef(instance) = value;

        // --- Gravity ---
        public static float GetGravity(FirstPersonController instance) => gravityRef(instance);
        public static void SetGravity(FirstPersonController instance, float value) => gravityRef(instance) = value;

        // --- JumpForce ---
        public static float GetJumpForce(FirstPersonController instance) => jumpForceRef(instance);
        public static void SetJumpForce(FirstPersonController instance, float value) => jumpForceRef(instance) = value;

        // --- GroundDrag ---
        public static float GetGroundDrag(FirstPersonController instance) => groundDragRef(instance);
        public static void SetGroundDrag(FirstPersonController instance, float value) => groundDragRef(instance) = value;

        // --- AirDrag ---
        public static float GetAirDrag(FirstPersonController instance) => airDragRef(instance);
        public static void SetAirDrag(FirstPersonController instance, float value) => airDragRef(instance) = value;

        // --- RotationSpeed ---
        public static float GetRotationSpeed(FirstPersonController instance) => rotationSpeedRef(instance);
        public static void SetRotationSpeed(FirstPersonController instance, float value) => rotationSpeedRef(instance) = value;

        // --- MouseSensitivity ---
        public static float GetMouseSensitivity(FirstPersonController instance) => mouseSensitivityRef(instance);
        public static void SetMouseSensitivity(FirstPersonController instance, float value) => mouseSensitivityRef(instance) = value;

        // --- CrouchSpeedMultiplier ---
        public static float GetCrouchSpeedMultiplier(FirstPersonController instance) => crouchSpeedMultiplierRef(instance);
        public static void SetCrouchSpeedMultiplier(FirstPersonController instance, float value) => crouchSpeedMultiplierRef(instance) = value;

        // --- CrouchSize ---
        public static float GetCrouchSize(FirstPersonController instance) => crouchSizeRef(instance);
        public static void SetCrouchSize(FirstPersonController instance, float value) => crouchSizeRef(instance) = value;
    }
}