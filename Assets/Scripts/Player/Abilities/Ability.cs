using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("All of the main information about this particular ability.")]
    protected AbilityInfo m_Info;
    #endregion

    #region Cached Components
    protected ParticleSystem cc_Ps;
    #endregion

    #region Initialization
    private void Awake()
    {
        cc_Ps = GetComponent<ParticleSystem>();
    }
    #endregion

    #region Use Methods
    public abstract void use(Vector3 spawnPos);

    #endregion
}
