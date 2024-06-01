using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public int questNumber;
    public int[] items;
    public GameObject[] smth;
    public GameObject barrier;
    public GameObject reward;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag != "Player" && other.gameObject.GetComponent<PickUp>().id == items[questNumber])
        {
            questNumber++;
            Destroy(other.gameObject);
        }
    }
    public void CheckQuest()
    {
        for (int i = 0; i < smth.Length; i++)
        {
            if (i == questNumber)
            {
                //Enable smth
            }
            else
            {
                //Disable smth
            }
        }
        if (questNumber == 1)
        {
            //proseed
        }
        else if (questNumber == 2) 
        {
            //done
        }
    }
    
}
