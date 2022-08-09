// GENERATED AUTOMATICALLY FROM 'Assets/_Scripts/PlayerActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""PlayerMap"",
            ""id"": ""3540fee2-c1c1-463d-8c54-703c17381a47"",
            ""actions"": [
                {
                    ""name"": ""Mouse"",
                    ""type"": ""Value"",
                    ""id"": ""07fdafd6-bb9b-4c4c-bb3b-8466f8cf50f1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""2056deef-39b1-4198-9162-678e12b44921"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""e35b994e-f525-4a18-b0bb-fb394e620e4b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""90d9fa70-fc63-4e3e-a7fc-165824f6fa05"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Drop"",
                    ""type"": ""Button"",
                    ""id"": ""dfd4e3ed-02ec-4e92-8b31-d3076fe1f5cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MenuOpen"",
                    ""type"": ""Button"",
                    ""id"": ""fd00674b-a49a-4006-b37e-298517f8033a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Restart"",
                    ""type"": ""Button"",
                    ""id"": ""1105f5e4-3e7b-4b26-9c75-627421b3731d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e98a6677-3a42-4893-a649-764e9af57043"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""03285f42-bb98-4440-82ac-de1d0cd63b10"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""79f45a07-856b-4436-bf53-334f632cd411"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""42dc9dcd-a099-4073-b1e5-0156099bd857"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7820cbfb-b658-4289-b042-ebcce2d71d67"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""30ba4499-75d2-4bb1-8db3-07eca1c7f2ce"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1c0906d6-7454-4e5a-a607-ab6400f24649"",
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
                    ""id"": ""58250129-6699-46e5-a66b-57bf2fc2c59c"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22fbd8dc-e160-4362-beda-220e8e36e58d"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f817e7bf-2ebe-486e-83c1-b3ccfec6cfbf"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuOpen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ceaf982-b4e5-4413-8373-93228ef3045b"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMap
        m_PlayerMap = asset.FindActionMap("PlayerMap", throwIfNotFound: true);
        m_PlayerMap_Mouse = m_PlayerMap.FindAction("Mouse", throwIfNotFound: true);
        m_PlayerMap_Movement = m_PlayerMap.FindAction("Movement", throwIfNotFound: true);
        m_PlayerMap_Shoot = m_PlayerMap.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerMap_Dash = m_PlayerMap.FindAction("Dash", throwIfNotFound: true);
        m_PlayerMap_Drop = m_PlayerMap.FindAction("Drop", throwIfNotFound: true);
        m_PlayerMap_MenuOpen = m_PlayerMap.FindAction("MenuOpen", throwIfNotFound: true);
        m_PlayerMap_Restart = m_PlayerMap.FindAction("Restart", throwIfNotFound: true);
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

    // PlayerMap
    private readonly InputActionMap m_PlayerMap;
    private IPlayerMapActions m_PlayerMapActionsCallbackInterface;
    private readonly InputAction m_PlayerMap_Mouse;
    private readonly InputAction m_PlayerMap_Movement;
    private readonly InputAction m_PlayerMap_Shoot;
    private readonly InputAction m_PlayerMap_Dash;
    private readonly InputAction m_PlayerMap_Drop;
    private readonly InputAction m_PlayerMap_MenuOpen;
    private readonly InputAction m_PlayerMap_Restart;
    public struct PlayerMapActions
    {
        private @PlayerActions m_Wrapper;
        public PlayerMapActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Mouse => m_Wrapper.m_PlayerMap_Mouse;
        public InputAction @Movement => m_Wrapper.m_PlayerMap_Movement;
        public InputAction @Shoot => m_Wrapper.m_PlayerMap_Shoot;
        public InputAction @Dash => m_Wrapper.m_PlayerMap_Dash;
        public InputAction @Drop => m_Wrapper.m_PlayerMap_Drop;
        public InputAction @MenuOpen => m_Wrapper.m_PlayerMap_MenuOpen;
        public InputAction @Restart => m_Wrapper.m_PlayerMap_Restart;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMapActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMapActions instance)
        {
            if (m_Wrapper.m_PlayerMapActionsCallbackInterface != null)
            {
                @Mouse.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnMouse;
                @Mouse.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnMouse;
                @Mouse.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnMouse;
                @Movement.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnMovement;
                @Shoot.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnShoot;
                @Dash.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnDash;
                @Drop.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnDrop;
                @Drop.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnDrop;
                @Drop.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnDrop;
                @MenuOpen.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnMenuOpen;
                @MenuOpen.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnMenuOpen;
                @MenuOpen.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnMenuOpen;
                @Restart.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnRestart;
                @Restart.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnRestart;
                @Restart.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnRestart;
            }
            m_Wrapper.m_PlayerMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Mouse.started += instance.OnMouse;
                @Mouse.performed += instance.OnMouse;
                @Mouse.canceled += instance.OnMouse;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Drop.started += instance.OnDrop;
                @Drop.performed += instance.OnDrop;
                @Drop.canceled += instance.OnDrop;
                @MenuOpen.started += instance.OnMenuOpen;
                @MenuOpen.performed += instance.OnMenuOpen;
                @MenuOpen.canceled += instance.OnMenuOpen;
                @Restart.started += instance.OnRestart;
                @Restart.performed += instance.OnRestart;
                @Restart.canceled += instance.OnRestart;
            }
        }
    }
    public PlayerMapActions @PlayerMap => new PlayerMapActions(this);
    public interface IPlayerMapActions
    {
        void OnMouse(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnDrop(InputAction.CallbackContext context);
        void OnMenuOpen(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
    }
}
