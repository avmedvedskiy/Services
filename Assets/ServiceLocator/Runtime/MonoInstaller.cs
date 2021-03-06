using UnityEngine;

namespace Services
{
    public abstract class MonoInstaller : MonoBehaviour
    {
        public abstract void InstallBindings(ServiceContainer container);
    }
}
