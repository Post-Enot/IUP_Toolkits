using UnityEngine;
using UnityEngine.InputSystem;

namespace IUP.Toolkits
{
    [CreateAssetMenu(fileName = "InputEventsWrapper", menuName = "IUP/Input Events Wrapper")]
    public sealed class InputEventsWrapperAsset : ScriptableObject
    {
        [SerializeField] private InputActionAsset _inputActionAsset;

        [SerializeField] private string _eventsFilePath;
        [SerializeField] private string _eventsClassName;
        [SerializeField] private string _eventsNamespace;

        [SerializeField] private string _facadeFilePath;
        [SerializeField] private string _facadeClassName;
        [SerializeField] private string _facadeNamespace;
    }
}
