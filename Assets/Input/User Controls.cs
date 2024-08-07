//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input/User Controls.inputactions
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

public partial class @UserControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @UserControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""User Controls"",
    ""maps"": [
        {
            ""name"": ""Hero"",
            ""id"": ""deb54384-0359-4826-8395-7cfef598a7c6"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""361527ad-3809-4a85-81ef-daa556bdc8c0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""b5ac7393-1cf1-4731-80ab-a26dcafd2488"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""f8e1c1ff-e572-4b62-99ee-274d79734c7f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5d795524-f66c-4fd8-b466-0d1510e17df7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7e893cde-b353-4640-b440-9ff8cb334dfe"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3713ab34-c43d-4038-9792-7c90f42aac2a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a2d45fd0-ae89-446e-87e2-f8bed9bc4eac"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""55e896ef-3c7d-4a3f-989b-e7dbf248772e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Test"",
            ""id"": ""a8eb74d3-10b0-42cb-938e-bdb4f39bd603"",
            ""actions"": [
                {
                    ""name"": ""Die"",
                    ""type"": ""Button"",
                    ""id"": ""ead1394d-cfeb-4b30-9e03-adc888977d40"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AddScore"",
                    ""type"": ""Button"",
                    ""id"": ""aafccf7d-73ab-4b1e-86c2-9841e2377279"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hurt"",
                    ""type"": ""Button"",
                    ""id"": ""2defd5f5-641b-4f19-b6f2-f3f59e8c961a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7fe87688-e7ea-4052-a793-84588c754289"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Die"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fbb6616d-bd83-4106-bdcd-a2c7c7439772"",
                    ""path"": ""<Keyboard>/0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AddScore"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1754e686-4254-40ab-8508-6bbeb6beaa60"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hurt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Hero
        m_Hero = asset.FindActionMap("Hero", throwIfNotFound: true);
        m_Hero_Move = m_Hero.FindAction("Move", throwIfNotFound: true);
        m_Hero_Fire = m_Hero.FindAction("Fire", throwIfNotFound: true);
        // Test
        m_Test = asset.FindActionMap("Test", throwIfNotFound: true);
        m_Test_Die = m_Test.FindAction("Die", throwIfNotFound: true);
        m_Test_AddScore = m_Test.FindAction("AddScore", throwIfNotFound: true);
        m_Test_Hurt = m_Test.FindAction("Hurt", throwIfNotFound: true);
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

    // Hero
    private readonly InputActionMap m_Hero;
    private List<IHeroActions> m_HeroActionsCallbackInterfaces = new List<IHeroActions>();
    private readonly InputAction m_Hero_Move;
    private readonly InputAction m_Hero_Fire;
    public struct HeroActions
    {
        private @UserControls m_Wrapper;
        public HeroActions(@UserControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Hero_Move;
        public InputAction @Fire => m_Wrapper.m_Hero_Fire;
        public InputActionMap Get() { return m_Wrapper.m_Hero; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HeroActions set) { return set.Get(); }
        public void AddCallbacks(IHeroActions instance)
        {
            if (instance == null || m_Wrapper.m_HeroActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_HeroActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Fire.started += instance.OnFire;
            @Fire.performed += instance.OnFire;
            @Fire.canceled += instance.OnFire;
        }

        private void UnregisterCallbacks(IHeroActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Fire.started -= instance.OnFire;
            @Fire.performed -= instance.OnFire;
            @Fire.canceled -= instance.OnFire;
        }

        public void RemoveCallbacks(IHeroActions instance)
        {
            if (m_Wrapper.m_HeroActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IHeroActions instance)
        {
            foreach (var item in m_Wrapper.m_HeroActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_HeroActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public HeroActions @Hero => new HeroActions(this);

    // Test
    private readonly InputActionMap m_Test;
    private List<ITestActions> m_TestActionsCallbackInterfaces = new List<ITestActions>();
    private readonly InputAction m_Test_Die;
    private readonly InputAction m_Test_AddScore;
    private readonly InputAction m_Test_Hurt;
    public struct TestActions
    {
        private @UserControls m_Wrapper;
        public TestActions(@UserControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Die => m_Wrapper.m_Test_Die;
        public InputAction @AddScore => m_Wrapper.m_Test_AddScore;
        public InputAction @Hurt => m_Wrapper.m_Test_Hurt;
        public InputActionMap Get() { return m_Wrapper.m_Test; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TestActions set) { return set.Get(); }
        public void AddCallbacks(ITestActions instance)
        {
            if (instance == null || m_Wrapper.m_TestActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TestActionsCallbackInterfaces.Add(instance);
            @Die.started += instance.OnDie;
            @Die.performed += instance.OnDie;
            @Die.canceled += instance.OnDie;
            @AddScore.started += instance.OnAddScore;
            @AddScore.performed += instance.OnAddScore;
            @AddScore.canceled += instance.OnAddScore;
            @Hurt.started += instance.OnHurt;
            @Hurt.performed += instance.OnHurt;
            @Hurt.canceled += instance.OnHurt;
        }

        private void UnregisterCallbacks(ITestActions instance)
        {
            @Die.started -= instance.OnDie;
            @Die.performed -= instance.OnDie;
            @Die.canceled -= instance.OnDie;
            @AddScore.started -= instance.OnAddScore;
            @AddScore.performed -= instance.OnAddScore;
            @AddScore.canceled -= instance.OnAddScore;
            @Hurt.started -= instance.OnHurt;
            @Hurt.performed -= instance.OnHurt;
            @Hurt.canceled -= instance.OnHurt;
        }

        public void RemoveCallbacks(ITestActions instance)
        {
            if (m_Wrapper.m_TestActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITestActions instance)
        {
            foreach (var item in m_Wrapper.m_TestActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TestActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TestActions @Test => new TestActions(this);
    public interface IHeroActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
    public interface ITestActions
    {
        void OnDie(InputAction.CallbackContext context);
        void OnAddScore(InputAction.CallbackContext context);
        void OnHurt(InputAction.CallbackContext context);
    }
}
