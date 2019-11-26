using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selection : MonoBehaviour
{

    //objeto que marca el objeto seleccionado.
	public GameObject slc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	selectv2();
    }
    
    public void selectv2()
    {
    	Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    	RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
    	if(hit)
    	{
    	    s1 = hit.transform;//objeto seleccionado.
    		seccionado(s1);
    	}
    }
    
    public void seccionado(Transform b)
    {
    	slc.transform.position = b.transform.position;
        slc.transform.Translate(0,0,-1);
    }
}
