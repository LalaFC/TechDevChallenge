//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/PlayerInputEditor.inputactions
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

public partial class @PlayerInputEditor: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputEditor()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputEditor"",
    ""maps"": [
        {
            ""name"": ""playerMovements"",
            ""id"": ""792265f8-32e9-4a23-bc9a-63734c3579ec"",
            ""actions"": [
                {
                    ""name"": ""walk"",
                    ""type"": ""Value"",
                    ""id"": ""748fe8ce-695a-46c9-9165-04ca836050bf"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""98bccf6b-af60-420d-a4de-0d8ccfdc48ad"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d07c2fed-2da4-4a69-aaf7-3ea9282c8537"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d4efa2a0-453c-442e-913a-fed06fdc7158"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d018e111-55b0-422c-bf29-f131d9f6a5fe"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""812df204-9b1c-4eca-b944-c589dd80eb17"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // playerMovements
        m_playerMovements = asset.FindActionMap("playerMovements", throwIfNotFound: true);
        m_playerMovements_walk = m_playerMovements.FindAction("walk", throwIfNotFound: true);
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

    // playerMovements
    private readonly InputActionMap m_playerMovements;
    private List<IPlayerMovementsActions> m_PlayerMovementsActionsCallbackInterfaces = new List<IPlayerMovementsActions>();
    private readonly InputAction m_playerMovements_walk;
    public struct PlayerMovementsActions
    {
        private @PlayerInputEditor m_Wrapper;
        public PlayerMovementsActions(@PlayerInputEditor wrapper) { m_Wrapper = wrapper; }
        public InputAction @walk => m_Wrapper.m_playerMovements_walk;
        public InputActionMap Get() { return m_Wrapper.m_playerMovements; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementsActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerMovementsActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerMovementsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerMovementsActionsCallbackInterfaces.Add(instance);
            @walk.started += instance.OnWalk;
            @walk.performed += instance.OnWalk;
            @walk.canceled += instance.OnWalk;
        }

        private void UnregisterCallbacks(IPlayerMovementsActions instance)
        {
            @walk.started -= instance.OnWalk;
            @walk.performed -= instance.OnWalk;
            @walk.canceled -= instance.OnWalk;
        }

        public void RemoveCallbacks(IPlayerMovementsActions instance)
        {
            if (m_Wrapper.m_PlayerMovementsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerMovementsActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerMovementsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerMovementsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerMovementsActions @playerMovements => new PlayerMovementsActions(this);
    public interface IPlayerMovementsActions
    {
        void OnWalk(InputAction.CallbackContext context);
    }
}