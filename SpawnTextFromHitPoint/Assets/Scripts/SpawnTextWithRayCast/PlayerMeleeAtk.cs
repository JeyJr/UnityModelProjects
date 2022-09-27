using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMeleeAtk : MonoBehaviour
{
    public Transform origin;
    public LayerMask enemyMask;


    [SerializeField] private PlayerAttributes playerAttributes;
    [SerializeField] private float distance = 2f;
    [SerializeField] private bool hitTarget;


    private void FixedUpdate()
    {
        if (playerAttributes.IsAtk) AtkEnemy();
    }


    internal void AtkEnemy()
    {

        RaycastHit2D[] hit = Physics2D.RaycastAll(origin.position, Vector2.right, distance, enemyMask);
        //RaycastHit2D hit = Physics2D.Raycast(origin.position, Vector2.right, distance, enemyMask);
        Debug.DrawRay(origin.position, Vector2.right * distance, Color.green);

        if (hit != null && hitTarget)
        {
            hitTarget = !hitTarget;

            for (int i = 0; i < hit.Length; i++)
            {
                //Debug.Log($"Nome: {hit[i].collider.name}");
                //Debug.Log($"Vida: {hit[i].collider.GetComponent<TargetAttributes>().Life}");

                SetCritical(hit[i].collider.gameObject, Random.Range(1, 101));
            }
        }
       
    }

    internal void SetCritical(GameObject targetAttributes, float num)
    {
        if(num < playerAttributes.CritRange)
        {
            int critValue = Mathf.RoundToInt(playerAttributes.AtkPower * playerAttributes.CritMult);
            targetAttributes.GetComponent<TargetAttributes>().TakeDmg(critValue, true);
        }
        else
        {
            targetAttributes.GetComponent<TargetAttributes>().TakeDmg(playerAttributes.AtkPower, false);
        }
    }

    public void HitTarget()
    {
        hitTarget = true;
    }
}
