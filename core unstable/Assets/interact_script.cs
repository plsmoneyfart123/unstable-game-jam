using System;
using System.Linq;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

public class interact_script : MonoBehaviour
{
    [SerializeField] private Transform _TransTable;
    [SerializeField] private  GameObject player;
    private float gubby;
    [SerializeField] GameObject interact;
    public bool active= false;
    void Update()
    {
       gubby =  player.transform.position.x - _TransTable.position.x;
       sifam();
    } 
    void sifam()
    {
        
        if (gubby >= -2.1 && gubby <= 2.1)
        {
            active = true;
            interact.SetActive(active);
        }else
        {
            active = false;
            interact.SetActive(active);
        }
    }
}
