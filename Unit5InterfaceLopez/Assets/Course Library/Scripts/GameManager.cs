using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    private int score;
    public List<GameObject> games;
    private float spawnrate = 1.0f;
  
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SPawnTarget());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SPawnTarget ()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnrate);
            int  index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);

        }
    }

}
