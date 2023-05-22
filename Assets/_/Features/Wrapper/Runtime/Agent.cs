using UnityEngine;
using static LogWrapper.Runtime.DebugLogWrapper;

namespace LogWrapper.Runtime
{
    public class Agent : MonoBehaviour
    {
        #region Unity API

        void Start()
        {
            DebugLog("Toto");
            DebugLogWarning("Tata");
            DebugLogError("Titi");
        }

        #endregion
    }
}