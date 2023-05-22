using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EditorExploration.Runtime
{

    [CreateAssetMenu(fileName = "EnemyData", menuName = "Data/EnemyData", order = 1)]
    public class MyScriptableObject : ScriptableObject
    {
        #region Public Members

        public int m_life;

        #endregion
    }
}
