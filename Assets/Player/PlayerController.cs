using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Animator animator;
    
    private Vector3 normalizedInputs; 
    private Rigidbody selfRigedbody;

    private List<string> inventory;

    public void Start()
    {
        selfRigedbody = GetComponent<Rigidbody>();
        inventory = new List<string>();
    }

    
    public void Update()
    {
        ProcessInputs();
    }

    public void FixedUpdate()
    {
        MoveWithInput();
        AnimateWithInput();
    }

    /* DATA */

    private void AddToInventory(string item){
        inventory.Add(item);

        foreach(string thing in inventory)
        Debug.Log(thing);
    }

    /* INPUT */

    private void ProcessInputs()
    {
        normalizedInputs = (transform.right * Input.GetAxis("Horizontal")) +
            (transform.forward * Input.GetAxis("Vertical"));
        normalizedInputs = Vector3.Normalize(normalizedInputs);

        if (Input.GetButtonDown("Fire1")){
            
        }

        if (Input.GetButtonDown("Fire2")){
            
        }

    }

    /* PHYSICS */

    private void MoveWithInput()
    {
        selfRigedbody.velocity = normalizedInputs * speed;
    }

    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "Hazard"){
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Item"){
            Item otherItem = other.gameObject.GetComponent<Item>();
            AddToInventory(otherItem.name);
            otherItem.Remove();
        }
    }

    /* ANIMATIONS */

    private void AnimateWithInput()
    {
        if (normalizedInputs.z > 0.5){
            animator.SetInteger("WalkDirection", 1);
        }
        if (normalizedInputs.z < -0.5){
            animator.SetInteger("WalkDirection", 2);
        }
        if (normalizedInputs.x > 0.5){
            animator.SetInteger("WalkDirection", 3);
        }
        if (normalizedInputs.x < -0.5){
            animator.SetInteger("WalkDirection", 4);
        }
        if (normalizedInputs.x > -0.5 && normalizedInputs.x < 0.5 && normalizedInputs.z < 0.5 && normalizedInputs.z > -0.5 ){
            animator.SetInteger("WalkDirection", 0);
        }
    }
}
