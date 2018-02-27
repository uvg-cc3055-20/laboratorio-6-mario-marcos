using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class VirtualBottom : MonoBehaviour,
IVirtualButtonEventHandler
{ 

 public VirtualButtonBehaviour virtualBtn;
  public Animator birdAnim;
    public AudioSource sound;
	// Use this for initialization
	void Start () {
        virtualBtn = GetComponent<VirtualButtonBehaviour>();
        virtualBtn.RegisterEventHandler(this);
    }
 

        public void OnButtonPressed(VirtualButtonBehaviour vb)
        {
          //  throw new System.NotImplementedException();
            birdAnim.SetTrigger("sing");
            sound.Play();
    }

        public void OnButtonReleased(VirtualButtonBehaviour vb)
        {
            
        }
    }
   