using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour {

    private Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update () {

    }

    public void Break () {
        anim.SetBool ("isBroken", true);
        StartCoroutine (BreakCo ());
        if (gameObject.name == "Pot") {
            FindObjectOfType<AudioManager> ().Play ("Pot Breaking");
        }
        if (gameObject.name == "Bush") {
            FindObjectOfType<AudioManager> ().Play ("Bush Breaking");
        }
    }

    IEnumerator BreakCo () {
        yield return new WaitForSeconds (.3f);
        this.gameObject.SetActive (false);
    }
}