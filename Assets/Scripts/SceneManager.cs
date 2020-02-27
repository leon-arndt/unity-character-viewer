using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Animation and Particle Viewer
/// </summary>
public class SceneManager : MonoBehaviour
{
    public Portrait currentPortrait;
    public GameObject portraitHolder;

    /*
     * Click through the animations of each character
     * Player particle effects (instantiate)
     * Bool in editor whether to loop animations
     * Get data from a scriptable object which has all of this info
     */

    // Start is called before the first frame update
    void Start()
    {
        //LoadPortrait(currentPortrait);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoadPortrait(currentPortrait);
        }
    }

    public void LoadPortrait(Portrait portrait)
    {
        //Delete current portrait
        foreach (Transform child in portraitHolder.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        //Instantiate
        GameObject mesh = Instantiate(portrait.meshPrefab);
        mesh.transform.SetParent(portraitHolder.transform);

        GameObject particles = Instantiate(portrait.particlePrefab);
        particles.transform.SetParent(portraitHolder.transform);

        //play animation
        mesh.GetComponent<Animator>().Play(portrait.animClip.name);

        bool matches = mesh.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName(portrait.animClip.name);
        Debug.Log("Animation matches: " + matches);
    }
}
