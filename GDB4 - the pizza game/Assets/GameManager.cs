using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    public List<Texture> pic;
    public GameObject go; //your plane
                          // Use this for initialization
    void Start () {
        ApplyTexture(pic[Random.Range(0, pic.Count)]);

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void ApplyTexture(Texture texture)
    {
        GetComponent<Renderer>().material.mainTexture = texture;
    }
}
