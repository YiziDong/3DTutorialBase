using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaLaserAttack : Ability
{
    public override void use(Vector3 spawnPos)
    {
        RaycastHit[] hits = Physics.SphereCastAll(spawnPos, 1f, transform.forward, m_Info.Range);
        foreach (RaycastHit hit in hits) {
            if (hit.collider.CompareTag("Enemy")) {
                hit.collider.GetComponent<EnemyController>().DecreaseHealth(m_Info.Power);
            }
        }
        var emitterShape = cc_Ps.shape;
        emitterShape.length = m_Info.Range;
        cc_Ps.Play();
    } 
}
