using UnityEngine;

namespace LogWrapper.Runtime
{
    [DisallowMultipleComponent]
    public abstract class DebugLogImplementation : MonoBehaviour
    {
        #region Main Methods

        public abstract void DebugLog(string log);
        public abstract void DebugLogWarning(string log);
        public abstract void DebugLogError(string log);

        #endregion
    }
}