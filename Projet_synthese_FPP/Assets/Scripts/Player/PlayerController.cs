using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Assets.Scripts;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float speed = 1;

    private Mover mover;

	// Use this for initialization
	void Start ()
	{

	}

    void Awake()
    {
        mover = GetComponent<Mover>();
    }
	
	// Update is called once per frame
	void Update ()
	{
	    if (Input.GetKey(KeyCode.LeftArrow))
	    {
	        mover.move(speed);
	    }
	    if (Input.GetKeyDown(KeyCode.UpArrow))
	    {
	        mover.move(speed);
        }
	    if (Input.GetKeyDown(KeyCode.DownArrow))
	    {
	        mover.move(speed);
        }
	    if (Input.GetKeyDown(KeyCode.RightArrow))
	    {
	        mover.move(speed);
        }
        
    }
}
