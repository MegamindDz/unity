using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{

    public Animator chestAnim;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray;
            RaycastHit hit;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.CompareTag("Chest"))
                {
                    if (chestAnim.GetInteger("state") == 0)
                        chestAnim.SetInteger("state", 1);
                    else if (chestAnim.GetInteger("state") == 1)
                        chestAnim.SetInteger("state", 0);
                }
            }
        }
    }
}