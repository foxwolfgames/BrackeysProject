//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/_Project/Input/GameInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @GameInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInputActions"",
    ""maps"": [
        {
            ""name"": ""InGameMovement"",
            ""id"": ""bf206f8e-2059-4e15-b1de-3f0b58322593"",
            ""actions"": [
                {
                    ""name"": ""Forward"",
                    ""type"": ""Button"",
                    ""id"": ""d63f39fd-bd9a-4b53-8be0-794987be52ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""b47bdf35-21b7-4161-a64e-228dd7ea1c0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""cd0edc54-c3ff-40ee-bd2e-dace7bb75b0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""1a3f0bdb-77f8-40bf-b7ce-e018cb3b1ffb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ce0170c3-246c-46d5-964e-fbdc30f98055"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""647431f2-115f-4560-9805-e2313f77c934"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56e5e2af-dbaa-48ac-93d3-bc0ddbe5e537"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e68e3d7-c956-4382-b4a9-013d58106479"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""WeaponInteraction"",
            ""id"": ""5e18acb2-5bd8-438a-943f-3f6890f389e1"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""8510a99e-ee42-4b2a-a69a-c7d712441fec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""a0c333e1-6dd9-4f2f-ab25-4389066a8419"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ADS"",
                    ""type"": ""Button"",
                    ""id"": ""8a92b270-1a2d-49a5-910a-58da29acf324"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3d239513-7eeb-4cd4-ac36-d27314bcaea8"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01744695-9664-401b-a8d7-d6f73484c72c"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03455314-bbe2-493f-aef5-b27e2aad121f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ADS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // InGameMovement
        m_InGameMovement = asset.FindActionMap("InGameMovement", throwIfNotFound: true);
        m_InGameMovement_Forward = m_InGameMovement.FindAction("Forward", throwIfNotFound: true);
        m_InGameMovement_Left = m_InGameMovement.FindAction("Left", throwIfNotFound: true);
        m_InGameMovement_Back = m_InGameMovement.FindAction("Back", throwIfNotFound: true);
        m_InGameMovement_Right = m_InGameMovement.FindAction("Right", throwIfNotFound: true);
        // WeaponInteraction
        m_WeaponInteraction = asset.FindActionMap("WeaponInteraction", throwIfNotFound: true);
        m_WeaponInteraction_Shoot = m_WeaponInteraction.FindAction("Shoot", throwIfNotFound: true);
        m_WeaponInteraction_Reload = m_WeaponInteraction.FindAction("Reload", throwIfNotFound: true);
        m_WeaponInteraction_ADS = m_WeaponInteraction.FindAction("ADS", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // InGameMovement
    private readonly InputActionMap m_InGameMovement;
    private List<IInGameMovementActions> m_InGameMovementActionsCallbackInterfaces = new List<IInGameMovementActions>();
    private readonly InputAction m_InGameMovement_Forward;
    private readonly InputAction m_InGameMovement_Left;
    private readonly InputAction m_InGameMovement_Back;
    private readonly InputAction m_InGameMovement_Right;
    public struct InGameMovementActions
    {
        private @GameInputActions m_Wrapper;
        public InGameMovementActions(@GameInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Forward => m_Wrapper.m_InGameMovement_Forward;
        public InputAction @Left => m_Wrapper.m_InGameMovement_Left;
        public InputAction @Back => m_Wrapper.m_InGameMovement_Back;
        public InputAction @Right => m_Wrapper.m_InGameMovement_Right;
        public InputActionMap Get() { return m_Wrapper.m_InGameMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGameMovementActions set) { return set.Get(); }
        public void AddCallbacks(IInGameMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_InGameMovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InGameMovementActionsCallbackInterfaces.Add(instance);
            @Forward.started += instance.OnForward;
            @Forward.performed += instance.OnForward;
            @Forward.canceled += instance.OnForward;
            @Left.started += instance.OnLeft;
            @Left.performed += instance.OnLeft;
            @Left.canceled += instance.OnLeft;
            @Back.started += instance.OnBack;
            @Back.performed += instance.OnBack;
            @Back.canceled += instance.OnBack;
            @Right.started += instance.OnRight;
            @Right.performed += instance.OnRight;
            @Right.canceled += instance.OnRight;
        }

        private void UnregisterCallbacks(IInGameMovementActions instance)
        {
            @Forward.started -= instance.OnForward;
            @Forward.performed -= instance.OnForward;
            @Forward.canceled -= instance.OnForward;
            @Left.started -= instance.OnLeft;
            @Left.performed -= instance.OnLeft;
            @Left.canceled -= instance.OnLeft;
            @Back.started -= instance.OnBack;
            @Back.performed -= instance.OnBack;
            @Back.canceled -= instance.OnBack;
            @Right.started -= instance.OnRight;
            @Right.performed -= instance.OnRight;
            @Right.canceled -= instance.OnRight;
        }

        public void RemoveCallbacks(IInGameMovementActions instance)
        {
            if (m_Wrapper.m_InGameMovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInGameMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_InGameMovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InGameMovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InGameMovementActions @InGameMovement => new InGameMovementActions(this);

    // WeaponInteraction
    private readonly InputActionMap m_WeaponInteraction;
    private List<IWeaponInteractionActions> m_WeaponInteractionActionsCallbackInterfaces = new List<IWeaponInteractionActions>();
    private readonly InputAction m_WeaponInteraction_Shoot;
    private readonly InputAction m_WeaponInteraction_Reload;
    private readonly InputAction m_WeaponInteraction_ADS;
    public struct WeaponInteractionActions
    {
        private @GameInputActions m_Wrapper;
        public WeaponInteractionActions(@GameInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_WeaponInteraction_Shoot;
        public InputAction @Reload => m_Wrapper.m_WeaponInteraction_Reload;
        public InputAction @ADS => m_Wrapper.m_WeaponInteraction_ADS;
        public InputActionMap Get() { return m_Wrapper.m_WeaponInteraction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WeaponInteractionActions set) { return set.Get(); }
        public void AddCallbacks(IWeaponInteractionActions instance)
        {
            if (instance == null || m_Wrapper.m_WeaponInteractionActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_WeaponInteractionActionsCallbackInterfaces.Add(instance);
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @Reload.started += instance.OnReload;
            @Reload.performed += instance.OnReload;
            @Reload.canceled += instance.OnReload;
            @ADS.started += instance.OnADS;
            @ADS.performed += instance.OnADS;
            @ADS.canceled += instance.OnADS;
        }

        private void UnregisterCallbacks(IWeaponInteractionActions instance)
        {
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @Reload.started -= instance.OnReload;
            @Reload.performed -= instance.OnReload;
            @Reload.canceled -= instance.OnReload;
            @ADS.started -= instance.OnADS;
            @ADS.performed -= instance.OnADS;
            @ADS.canceled -= instance.OnADS;
        }

        public void RemoveCallbacks(IWeaponInteractionActions instance)
        {
            if (m_Wrapper.m_WeaponInteractionActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IWeaponInteractionActions instance)
        {
            foreach (var item in m_Wrapper.m_WeaponInteractionActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_WeaponInteractionActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public WeaponInteractionActions @WeaponInteraction => new WeaponInteractionActions(this);
    public interface IInGameMovementActions
    {
        void OnForward(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
    }
    public interface IWeaponInteractionActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnADS(InputAction.CallbackContext context);
    }
}