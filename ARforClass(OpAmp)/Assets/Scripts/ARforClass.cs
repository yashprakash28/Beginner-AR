using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARforClass : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject opamp, leadversion;
    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour> ();
        for(int i=0 ; i<2 ; i++)
        {
            vrb[i].RegisterEventHandler(this);
        }


        opamp.SetActive(false);
        leadversion.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName == "OpAmpVB")
        {
            Debug.Log("OpAmpButton Pressed");
            opamp.SetActive(true);
            leadversion.SetActive(false);
        }
        else if(vb.VirtualButtonName == "LeadVersionVB")
        {
            Debug.Log("LeadVersionButton Pressed");
            opamp.SetActive(false);
            leadversion.SetActive(true);            
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual Button Not Supported");
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Virtual Button Pressed");
    }
}
