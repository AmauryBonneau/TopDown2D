// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""GeneralGameplay"",
            ""id"": ""bcd2bdbf-c31b-4e8e-a4b6-4bd161d4e9bf"",
            ""actions"": [
                {
                    ""name"": ""WalkVertical"",
                    ""type"": ""Value"",
                    ""id"": ""7097cd41-2404-478e-af99-b0607a77d741"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WalkHorizontal"",
                    ""type"": ""Value"",
                    ""id"": ""42228ff6-e2d1-4e76-8726-d3e74f0aab35"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""cb8d396a-3076-469a-8283-caf4659f231c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""VerticalKeyboard"",
                    ""id"": ""10de6561-2920-4b45-8ec7-745149544d66"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WalkVertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5a716be8-4757-440f-a8f2-97838f77364e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""WalkVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""91ca059b-0fe4-4ad8-bc32-817f364c040e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""WalkVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""VerticalDpad"",
                    ""id"": ""f5dc36fc-dcc6-4d33-9d23-18111c3f2ab8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""WalkVertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""143a56f0-0daa-46eb-9246-426abb9a5b32"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""WalkVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4ff34def-1243-4ea5-aaae-7f2d180560a4"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""WalkVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""VerticalLStick"",
                    ""id"": ""55914651-7e0e-42e7-acb4-cd9b7552afd4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""WalkVertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c246b39f-06d9-4760-a012-dba483eb2feb"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""WalkVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d4048d43-05d3-4782-b384-dac18f28a005"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""WalkVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""HorizontalKeyboard"",
                    ""id"": ""aa175f3a-381c-4a2b-9599-0ef86df53e5b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WalkHorizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""12c018c0-2aed-47f8-b2d6-743ce50904a9"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""WalkHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a8a4e59d-2e6f-4786-b2fc-596c5eaf2ed1"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""WalkHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""HorizontalDpad"",
                    ""id"": ""86c503c0-f40c-4f44-b179-078e1e565d55"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""WalkHorizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""af842939-9bcc-48d3-aca3-be9e9dd44411"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""WalkHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0da74d23-2427-4fac-a26f-ab37f9d33cde"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""WalkHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""HorizontalLStick"",
                    ""id"": ""0f3268f8-ea4e-4401-97ae-bb8b0cd81036"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""WalkHorizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d2efc04c-7587-437b-9b75-5383b01e5b59"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""WalkHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e44ea937-57b3-4881-abba-b81a00e23d76"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""WalkHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bcc73e2b-67e3-420a-9be8-099127f8d8fa"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""daf933a3-923f-497b-9513-880ea44b1f8b"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""54fdbd2c-ef2a-45cc-a398-0150da934497"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""8ceb4140-5434-44a4-94b9-c930bf384691"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""179847f3-f191-4581-bd12-2ad08321f9c2"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""TitleScreen"",
            ""id"": ""e02ca2a0-a630-4ae9-90b9-4e800d5ce020"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""366d64e1-64bd-4b47-9cc4-ee7f3fb00628"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""721bc9fc-fb18-478e-9c30-4de2e2c78e7d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // GeneralGameplay
        m_GeneralGameplay = asset.FindActionMap("GeneralGameplay", throwIfNotFound: true);
        m_GeneralGameplay_WalkVertical = m_GeneralGameplay.FindAction("WalkVertical", throwIfNotFound: true);
        m_GeneralGameplay_WalkHorizontal = m_GeneralGameplay.FindAction("WalkHorizontal", throwIfNotFound: true);
        m_GeneralGameplay_Attack = m_GeneralGameplay.FindAction("Attack", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Newaction = m_Menu.FindAction("New action", throwIfNotFound: true);
        // TitleScreen
        m_TitleScreen = asset.FindActionMap("TitleScreen", throwIfNotFound: true);
        m_TitleScreen_Newaction = m_TitleScreen.FindAction("New action", throwIfNotFound: true);
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

    // GeneralGameplay
    private readonly InputActionMap m_GeneralGameplay;
    private IGeneralGameplayActions m_GeneralGameplayActionsCallbackInterface;
    private readonly InputAction m_GeneralGameplay_WalkVertical;
    private readonly InputAction m_GeneralGameplay_WalkHorizontal;
    private readonly InputAction m_GeneralGameplay_Attack;
    public struct GeneralGameplayActions
    {
        private @InputMaster m_Wrapper;
        public GeneralGameplayActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @WalkVertical => m_Wrapper.m_GeneralGameplay_WalkVertical;
        public InputAction @WalkHorizontal => m_Wrapper.m_GeneralGameplay_WalkHorizontal;
        public InputAction @Attack => m_Wrapper.m_GeneralGameplay_Attack;
        public InputActionMap Get() { return m_Wrapper.m_GeneralGameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GeneralGameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGeneralGameplayActions instance)
        {
            if (m_Wrapper.m_GeneralGameplayActionsCallbackInterface != null)
            {
                @WalkVertical.started -= m_Wrapper.m_GeneralGameplayActionsCallbackInterface.OnWalkVertical;
                @WalkVertical.performed -= m_Wrapper.m_GeneralGameplayActionsCallbackInterface.OnWalkVertical;
                @WalkVertical.canceled -= m_Wrapper.m_GeneralGameplayActionsCallbackInterface.OnWalkVertical;
                @WalkHorizontal.started -= m_Wrapper.m_GeneralGameplayActionsCallbackInterface.OnWalkHorizontal;
                @WalkHorizontal.performed -= m_Wrapper.m_GeneralGameplayActionsCallbackInterface.OnWalkHorizontal;
                @WalkHorizontal.canceled -= m_Wrapper.m_GeneralGameplayActionsCallbackInterface.OnWalkHorizontal;
                @Attack.started -= m_Wrapper.m_GeneralGameplayActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_GeneralGameplayActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_GeneralGameplayActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_GeneralGameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @WalkVertical.started += instance.OnWalkVertical;
                @WalkVertical.performed += instance.OnWalkVertical;
                @WalkVertical.canceled += instance.OnWalkVertical;
                @WalkHorizontal.started += instance.OnWalkHorizontal;
                @WalkHorizontal.performed += instance.OnWalkHorizontal;
                @WalkHorizontal.canceled += instance.OnWalkHorizontal;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public GeneralGameplayActions @GeneralGameplay => new GeneralGameplayActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Newaction;
    public struct MenuActions
    {
        private @InputMaster m_Wrapper;
        public MenuActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Menu_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // TitleScreen
    private readonly InputActionMap m_TitleScreen;
    private ITitleScreenActions m_TitleScreenActionsCallbackInterface;
    private readonly InputAction m_TitleScreen_Newaction;
    public struct TitleScreenActions
    {
        private @InputMaster m_Wrapper;
        public TitleScreenActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_TitleScreen_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_TitleScreen; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TitleScreenActions set) { return set.Get(); }
        public void SetCallbacks(ITitleScreenActions instance)
        {
            if (m_Wrapper.m_TitleScreenActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_TitleScreenActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_TitleScreenActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_TitleScreenActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_TitleScreenActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public TitleScreenActions @TitleScreen => new TitleScreenActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IGeneralGameplayActions
    {
        void OnWalkVertical(InputAction.CallbackContext context);
        void OnWalkHorizontal(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface ITitleScreenActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
