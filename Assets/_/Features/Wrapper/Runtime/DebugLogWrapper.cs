using UnityEngine;

namespace LogWrapper.Runtime
{
    [DisallowMultipleComponent]
    public class DebugLogWrapper : MonoBehaviour
    {
        #region Public Members

        public static DebugLogImplementation Wrapped;

        #endregion


        #region Unity API

        private void Awake()
        {
            Wrapped = GetComponent<DebugLogImplementation>();
        }

        #endregion


        #region Main Methods

        public static void DebugLog(string log)
        {
            Wrapped.DebugLog(log);
        }
        public static void DebugLogWarning(string log)
        {
            Wrapped.DebugLogWarning(log);
        }
        public static void DebugLogError(string log)
        {
            Wrapped.DebugLogError(log);
        }

        #endregion
    }
}