using UnityEngine;
using System.Collections;
 
 [RequireComponent(typeof(MeshCollider))]
 
 public class GizmosController : MonoBehaviour 
 {
 
 	private Vector3 screenPoint;
 	private Vector3 offset;
 
	 void OnMouseDown()
 	{
    	 screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    	 offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
 	}
	 void OnMouseDrag()
 	{
 		float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen ));
 	}

 	/*void OnCollisionStay(Collision collisionInfo)
 	{
 		if (collision.gameObject.tag == "Hole")
 		{
 			transform.freeze;
 		}
 	}*/
 }