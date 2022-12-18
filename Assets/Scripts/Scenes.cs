using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public SceneAsset scene;
    public GameObject GameObject;

    public void GoToLevel(SceneAsset scene)
    {
        SceneManager.LoadScene(scene.name);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == GameObject.name)
        {
            GoToLevel(scene);
        }
    }
    //public void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name == GameObject.name)
    //        GoToLevel(scene);
    //}

    // Update is called once per frame
}
