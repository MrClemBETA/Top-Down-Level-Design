using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTrigger : MonoBehaviour
{
    public string triggerName;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(triggerName);
        if(PlayerData.instance.EnterTriggerLocation == triggerName)
        {
            Debug.Log("This has been reached.");
            PlayerData.instance.gameObject.transform.position = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
