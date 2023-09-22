using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeExplore : Ability
{

    public override void use(Vector3 spawnPos)
    {
        Collider[] hitColliders = Physics.OverlapBox(gameObject.transform.position, new Vector3(10, 10, 10), Quaternion.identity);
        foreach (Collider hit in hitColliders)
        {
            if (hit.CompareTag("Enemy"))
            {
                hit.GetComponent<EnemyController>().DecreaseHealth(m_Info.Power);
            }
        }
        var emitterShape = cc_Ps.shape;
        emitterShape.length = m_Info.Range;
        cc_Ps.Play();
    }
}
