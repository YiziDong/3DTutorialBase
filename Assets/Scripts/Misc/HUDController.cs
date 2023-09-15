using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("The part of the health that decrease")]
    private RectTransform m_HealthBar;
    #endregion  

    #region Privates Variables
    private float p_HealthBarorgWidth;
    #endregion

    #region Initialization
    private void Awake()
    {
        p_HealthBarorgWidth = m_HealthBar.sizeDelta.x;

    }
    #endregion

    #region Update Health Bar
    public void UpdateHealth(float percent) {
        m_HealthBar.sizeDelta = new Vector2(p_HealthBarorgWidth * percent, m_HealthBar.sizeDelta.y);
    }
    #endregion
}
