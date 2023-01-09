using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameManager gameManager;
    public float speed;
    public Animator animator;
    public string currentLevel;


    private bool canMove = true;
    
    private Vector3 normalizedInputs; 
    private Rigidbody selfRigedbody;

    // item pickup
    private List<string> inventory;

    // tile interaction
    private GameObject tileObject;

    public void Start()
    {
        selfRigedbody = GetComponent<Rigidbody>();
        inventory = new List<string>();
        tileObject = null;
    }

    
    public void Update()
    {
        MovementInputs();
        TileInputs();
    }

    public void FixedUpdate()
    {
        if(canMove)
        {
            MoveWithInput();
            AnimateWithInput();
        }
    }

    /* DATA */

    private void AddToInventory(string item){
        inventory.Add(item);
        gameManager.PickupItem(item);

        foreach(string thing in inventory)
        Debug.Log(thing);
    }

    /* INPUT */

    private void MovementInputs()
    {
        normalizedInputs = (transform.right * Input.GetAxis("Horizontal")) +
            (transform.forward * Input.GetAxis("Vertical"));
        normalizedInputs = Vector3.Normalize(normalizedInputs);
    }

    private void TileInputs()
    {
        if (Input.GetButtonDown("Fire1")){
            if (tileObject){
                tileObject.GetComponent<Plant>().Action(inventory);
            }
        }
    }

    /* PHYSICS */

    private void MoveWithInput()
    {
        selfRigedbody.velocity = normalizedInputs * speed;
    }

    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "Hazard"){
            canMove = false;
            StartCoroutine(DeadRoutine());
        }
    }

    IEnumerator DeadRoutine()
    {
        animator.SetFloat("WalkDirection", 5);
        yield return new WaitForSeconds(1f);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(currentLevel);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Item"){
            Item otherItem = other.gameObject.GetComponent<Item>();
            AddToInventory(otherItem.name);
            otherItem.Remove();
        }

        else if(other.gameObject.tag == "Tile"){
            tileObject = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Tile"){
            tileObject = null;
        }
    }

    /* ANIMATIONS */

    private void AnimateWithInput()
    {
        if (normalizedInputs.z > 0.5){
            animator.SetFloat("WalkDirection", 1);
        }
        if (normalizedInputs.z < -0.5){
            animator.SetFloat("WalkDirection", 2);
        }
        if (normalizedInputs.x > 0.5){
            animator.SetFloat("WalkDirection", 4);
        }
        if (normalizedInputs.x < -0.5){
            animator.SetFloat("WalkDirection", 3);
        }
        if (normalizedInputs.x > -0.5 && normalizedInputs.x < 0.5 && normalizedInputs.z < 0.5 && normalizedInputs.z > -0.5 ){
            animator.SetFloat("WalkDirection", 0);
        }
    }
}
