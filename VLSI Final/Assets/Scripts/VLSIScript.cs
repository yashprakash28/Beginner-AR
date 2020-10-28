using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VLSIScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject ingot, lattice, wafer, film, uv, pcb;
    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour> ();
        for(int i=0 ; i<6 ; i++)
        {
            vrb[i].RegisterEventHandler(this);
        }

        ingot.SetActive(false);
        lattice.SetActive(false);
        wafer.SetActive(false);
        film.SetActive(false);
        uv.SetActive(false);
        pcb.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName == "LatticeVB")
        {
            Debug.Log("OpAmpButton Pressed");
            ingot.SetActive(false);
            lattice.SetActive(true);
            wafer.SetActive(false);
            film.SetActive(false);
            uv.SetActive(false);
            pcb.SetActive(false);
        }
        else if(vb.VirtualButtonName == "WaferVB")
        {
            Debug.Log("LeadVersionButton Pressed");
        ingot.SetActive(false);
        lattice.SetActive(false);
        wafer.SetActive(true);
        film.SetActive(false);
        uv.SetActive(false);
        pcb.SetActive(false);          
        }
        else if(vb.VirtualButtonName == "FilmVB")
        {
            Debug.Log("LeadVersionButton Pressed");
        ingot.SetActive(false);
        lattice.SetActive(false);
        wafer.SetActive(false);
        film.SetActive(true);
        uv.SetActive(false);
        pcb.SetActive(false);          
        }
        else if(vb.VirtualButtonName == "UVVB")
        {
            Debug.Log("LeadVersionButton Pressed");
        ingot.SetActive(false);
        lattice.SetActive(false);
        wafer.SetActive(false);
        film.SetActive(false);
        uv.SetActive(true);
        pcb.SetActive(false);        
        }
        else if(vb.VirtualButtonName == "PCBVB")
        {
            Debug.Log("LeadVersionButton Pressed");
        ingot.SetActive(false);
        lattice.SetActive(false);
        wafer.SetActive(false);
        film.SetActive(false);
        uv.SetActive(false);
        pcb.SetActive(true);
        }
        else if(vb.VirtualButtonName == "IngotVB")
        {
            Debug.Log("LeadVersionButton Pressed");
        ingot.SetActive(true);
        lattice.SetActive(false);
        wafer.SetActive(false);
        film.SetActive(false);
        uv.SetActive(false);
        pcb.SetActive(false);          
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
