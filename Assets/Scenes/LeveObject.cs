using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeveObject : MonoBehaviour
{
    public string nextLevel;

    // Start is called before the first frame update
    public void moveTonextLecel()
    {

        SceneManager.LoadScene(nextLevel);
    }
    
        

    // Update is called once per frame
    void Update()
    {
        
    }
}
