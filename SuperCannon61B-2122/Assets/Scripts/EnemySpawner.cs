using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public static EnemySpawner _instance;

    private void Awake()
    {
        if (_instance == null)    //SINGLETON PATTERN
        {
            _instance = this;
        }
        else if (_instance != this)
        {
            Destroy(this.gameObject);
        }
    }



    [SerializeField] List<GameObject> myenemiesList;
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(SpawnEnemies());
    }


    IEnumerator SpawnEnemies()
    {

        while (true)
        {
            int enemychoice = Random.Range(0, myenemiesList.Count );
            float xpos = Random.Range(GameData.GetXMin(), GameData.GetXMax());

            //instantiate a new gameobject from the loaded prefab at the top of the scene
            Instantiate(myenemiesList[enemychoice], new Vector3(xpos, GameData.GetYMax() + 1, 0f), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(0.2f, 2f));
        }

    }

}
