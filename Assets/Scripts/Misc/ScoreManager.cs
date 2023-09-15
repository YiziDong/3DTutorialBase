using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager singleton;

    #region Private Variables
    private int m_CurScore;
    #endregion

    #region Intialization
    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
        }
        else if (singleton != null) {
            Destroy(gameObject);
        }
        m_CurScore = 0;
    }
    #endregion

    #region Score Methods
    public void IncreaseScore(int amount) {
        m_CurScore += amount;
    }
    private void UpdateHightScore()
    {
        if (!PlayerPrefs.HasKey("HS")) {
            PlayerPrefs.SetInt("HS", m_CurScore);
            return;
        }
        int hs = PlayerPrefs.GetInt("HS");
        if (hs < m_CurScore) {
            PlayerPrefs.SetInt("HS", m_CurScore);
        }
    }
    #endregion

    #region Destruction
    private void OnDisable() {
        UpdateHightScore();
    }
    #endregion
}
