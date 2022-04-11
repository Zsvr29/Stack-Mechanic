using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackManager : MonoBehaviour
{
    public static StackManager instance;
    [SerializeField] private float distanceBetweenObjects;
    [SerializeField] private Transform prevObject;
    [SerializeField] private Transform parent;

    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
    }
    void Start()
    {

        distanceBetweenObjects = prevObject.localPosition.y-0.7f;
    }

   public void PickUp(GameObject pickObjcet,bool needtag=false, string tag=null, bool downOrUp=true)
    {
        pickObjcet.transform.parent = parent;
        Vector3 despos = prevObject.localPosition;
         despos.y+=downOrUp ? distanceBetweenObjects:-distanceBetweenObjects;
        pickObjcet.transform.localPosition= despos;
        prevObject = pickObjcet.transform;


    }
}
