namespace ArmSwing
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class ArmSwingCustom : MonoBehaviour
    {
        public enum ControlOptions
        {
            ControllersOnly
        }

        public enum DirectionalMethod
        {
            ControllerRotation
        }

        [Header("Control Settings")]

        [Tooltip("If this is checked then the left controller touchpad will be enabled to move the play area.")]
        public bool leftController = true;
        [Tooltip("If this is checked then the right controller touchpad will be enabled to move the play area.")]
        public bool rightController = true;
        [Tooltip("Select which button to hold to engage Move In Place.")]
        public VRTK.VRTK_ControllerEvents.ButtonAlias engageButton = VRTK.VRTK_ControllerEvents.ButtonAlias.TouchpadPress;
        [Tooltip("Select which trackables are used to determine movement.")]
        public ControlOptions controlOptions = ControlOptions.ControllersOnly;
        [Tooltip("How the user's movement direction will be determined.  The Gaze method tends to lead to the least motion sickness.  Smart decoupling is still a Work In Progress.")]
        public DirectionalMethod directionalMethod = DirectionalMethod.ControllerRotation;

        [Header("Speed Settings")]

        [Tooltip("Lower to decrease speed, raise to increase.")]
        public float speedScale = 1;
        [Tooltip("The max speed the user can move in game units. (If 0 or less, max speed is uncapped)")]
        public float maxSpeed = 4;
        [Tooltip("The speed in which the play area slows down to a complete stop when the user is no longer pressing the engage button. This deceleration effect can ease any motion sickness that may be suffered.")]
        public float deceleration = 0.1f;
        [Tooltip("The speed in which the play area slows down to a complete stop when the user is falling.")]
        public float fallingDeceleration = 0.01f;

        [Header("Advanced Settings")]

        [Tooltip("The degree threshold that all tracked objects (controllers, headset) must be within to change direction when using the Smart Decoupling Direction Method.")]
        public float smartDecoupleThreshold = 30f;
        // The cap before we stop adding the delta to the movement list. This will help regulate speed.
        [Tooltip("The maximum amount of movement required to register in the virtual world.  Decreasing this will increase acceleration, and vice versa.")]
        public float sensitivity = 0.02f;

        [Header("Custom Settings")]
        [Tooltip("An optional Body Physics script to check for potential collisions in the moving direction. If any potential collision is found then the move will not take place. This can help reduce collision tunnelling.")]
        public VRTK.VRTK_BodyPhysics bodyPhysics;


        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}