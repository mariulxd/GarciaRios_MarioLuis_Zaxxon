// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/Player1.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player1"",
    ""maps"": [
        {
            ""name"": ""NaveCnt"",
            ""id"": ""c7211a76-004c-45a5-a904-0750a4593b63"",
            ""actions"": [
                {
                    ""name"": ""Disparar"",
                    ""type"": ""Button"",
                    ""id"": ""fed73dda-b5f3-4f98-9100-eddd07c6cab4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveKey"",
                    ""type"": ""Value"",
                    ""id"": ""488a46c7-7dda-424e-903e-4f6d46f67b1b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveH"",
                    ""type"": ""Value"",
                    ""id"": ""bb41b8ba-4b88-4d12-b52a-0a74b14989b4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveV"",
                    ""type"": ""Value"",
                    ""id"": ""53b318ca-bf3b-4cf4-864d-2d687898966f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e185f8cb-8f3e-4cf2-9998-36853e330184"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Disparar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b01f1431-ce81-47b5-a61e-8f530016620c"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Disparar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""919dc977-c28a-4044-aee2-e26f08869640"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKey"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7dc085fa-c256-4c3b-b9ce-f35c7cea07cd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3dc937b9-65e0-4349-9e23-7cdc9b702cff"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f824a465-2b5c-4449-aef7-d8fb9726a621"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f7620345-fd5f-4c69-bca1-edfff50679fa"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a8e4fc81-8fb1-4406-ac92-4b6a41132734"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6274443-a277-4d0b-8787-34bd13a977b9"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CamCnt"",
            ""id"": ""d6bf9226-c8ea-410c-964a-d33bbeb6190a"",
            ""actions"": [
                {
                    ""name"": ""RotX"",
                    ""type"": ""Value"",
                    ""id"": ""713a9f59-81b1-42e3-bf71-478f4206cae0"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotY"",
                    ""type"": ""Value"",
                    ""id"": ""91cdb656-a9a1-440c-a0aa-fd56fe7e586e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7701f2e7-f5ab-4207-b678-3840d502f022"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""65fddc3d-e921-4f06-a558-f498940be155"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // NaveCnt
        m_NaveCnt = asset.FindActionMap("NaveCnt", throwIfNotFound: true);
        m_NaveCnt_Disparar = m_NaveCnt.FindAction("Disparar", throwIfNotFound: true);
        m_NaveCnt_MoveKey = m_NaveCnt.FindAction("MoveKey", throwIfNotFound: true);
        m_NaveCnt_MoveH = m_NaveCnt.FindAction("MoveH", throwIfNotFound: true);
        m_NaveCnt_MoveV = m_NaveCnt.FindAction("MoveV", throwIfNotFound: true);
        // CamCnt
        m_CamCnt = asset.FindActionMap("CamCnt", throwIfNotFound: true);
        m_CamCnt_RotX = m_CamCnt.FindAction("RotX", throwIfNotFound: true);
        m_CamCnt_RotY = m_CamCnt.FindAction("RotY", throwIfNotFound: true);
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

    // NaveCnt
    private readonly InputActionMap m_NaveCnt;
    private INaveCntActions m_NaveCntActionsCallbackInterface;
    private readonly InputAction m_NaveCnt_Disparar;
    private readonly InputAction m_NaveCnt_MoveKey;
    private readonly InputAction m_NaveCnt_MoveH;
    private readonly InputAction m_NaveCnt_MoveV;
    public struct NaveCntActions
    {
        private @InputActions m_Wrapper;
        public NaveCntActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Disparar => m_Wrapper.m_NaveCnt_Disparar;
        public InputAction @MoveKey => m_Wrapper.m_NaveCnt_MoveKey;
        public InputAction @MoveH => m_Wrapper.m_NaveCnt_MoveH;
        public InputAction @MoveV => m_Wrapper.m_NaveCnt_MoveV;
        public InputActionMap Get() { return m_Wrapper.m_NaveCnt; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NaveCntActions set) { return set.Get(); }
        public void SetCallbacks(INaveCntActions instance)
        {
            if (m_Wrapper.m_NaveCntActionsCallbackInterface != null)
            {
                @Disparar.started -= m_Wrapper.m_NaveCntActionsCallbackInterface.OnDisparar;
                @Disparar.performed -= m_Wrapper.m_NaveCntActionsCallbackInterface.OnDisparar;
                @Disparar.canceled -= m_Wrapper.m_NaveCntActionsCallbackInterface.OnDisparar;
                @MoveKey.started -= m_Wrapper.m_NaveCntActionsCallbackInterface.OnMoveKey;
                @MoveKey.performed -= m_Wrapper.m_NaveCntActionsCallbackInterface.OnMoveKey;
                @MoveKey.canceled -= m_Wrapper.m_NaveCntActionsCallbackInterface.OnMoveKey;
                @MoveH.started -= m_Wrapper.m_NaveCntActionsCallbackInterface.OnMoveH;
                @MoveH.performed -= m_Wrapper.m_NaveCntActionsCallbackInterface.OnMoveH;
                @MoveH.canceled -= m_Wrapper.m_NaveCntActionsCallbackInterface.OnMoveH;
                @MoveV.started -= m_Wrapper.m_NaveCntActionsCallbackInterface.OnMoveV;
                @MoveV.performed -= m_Wrapper.m_NaveCntActionsCallbackInterface.OnMoveV;
                @MoveV.canceled -= m_Wrapper.m_NaveCntActionsCallbackInterface.OnMoveV;
            }
            m_Wrapper.m_NaveCntActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Disparar.started += instance.OnDisparar;
                @Disparar.performed += instance.OnDisparar;
                @Disparar.canceled += instance.OnDisparar;
                @MoveKey.started += instance.OnMoveKey;
                @MoveKey.performed += instance.OnMoveKey;
                @MoveKey.canceled += instance.OnMoveKey;
                @MoveH.started += instance.OnMoveH;
                @MoveH.performed += instance.OnMoveH;
                @MoveH.canceled += instance.OnMoveH;
                @MoveV.started += instance.OnMoveV;
                @MoveV.performed += instance.OnMoveV;
                @MoveV.canceled += instance.OnMoveV;
            }
        }
    }
    public NaveCntActions @NaveCnt => new NaveCntActions(this);

    // CamCnt
    private readonly InputActionMap m_CamCnt;
    private ICamCntActions m_CamCntActionsCallbackInterface;
    private readonly InputAction m_CamCnt_RotX;
    private readonly InputAction m_CamCnt_RotY;
    public struct CamCntActions
    {
        private @InputActions m_Wrapper;
        public CamCntActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotX => m_Wrapper.m_CamCnt_RotX;
        public InputAction @RotY => m_Wrapper.m_CamCnt_RotY;
        public InputActionMap Get() { return m_Wrapper.m_CamCnt; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CamCntActions set) { return set.Get(); }
        public void SetCallbacks(ICamCntActions instance)
        {
            if (m_Wrapper.m_CamCntActionsCallbackInterface != null)
            {
                @RotX.started -= m_Wrapper.m_CamCntActionsCallbackInterface.OnRotX;
                @RotX.performed -= m_Wrapper.m_CamCntActionsCallbackInterface.OnRotX;
                @RotX.canceled -= m_Wrapper.m_CamCntActionsCallbackInterface.OnRotX;
                @RotY.started -= m_Wrapper.m_CamCntActionsCallbackInterface.OnRotY;
                @RotY.performed -= m_Wrapper.m_CamCntActionsCallbackInterface.OnRotY;
                @RotY.canceled -= m_Wrapper.m_CamCntActionsCallbackInterface.OnRotY;
            }
            m_Wrapper.m_CamCntActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RotX.started += instance.OnRotX;
                @RotX.performed += instance.OnRotX;
                @RotX.canceled += instance.OnRotX;
                @RotY.started += instance.OnRotY;
                @RotY.performed += instance.OnRotY;
                @RotY.canceled += instance.OnRotY;
            }
        }
    }
    public CamCntActions @CamCnt => new CamCntActions(this);
    public interface INaveCntActions
    {
        void OnDisparar(InputAction.CallbackContext context);
        void OnMoveKey(InputAction.CallbackContext context);
        void OnMoveH(InputAction.CallbackContext context);
        void OnMoveV(InputAction.CallbackContext context);
    }
    public interface ICamCntActions
    {
        void OnRotX(InputAction.CallbackContext context);
        void OnRotY(InputAction.CallbackContext context);
    }
}
