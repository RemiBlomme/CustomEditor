using UnityEngine;

namespace LogWrapper.Runtime
{
    public class DebugLogUnity : DebugLogImplementation
    {
        #region Main Methods

        public override void DebugLog(string log)
        {
            Debug.Log(log);
        }
        public override void DebugLogWarning(string log)
        {
            Debug.LogWarning(log);
        }
        public override void DebugLogError(string log)
        {
            Debug.LogError(log);
        }

        #endregion
    }
}