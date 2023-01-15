using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject obstacle;
    public Transform spawnPoint;
    int core = 0;
    public TextMeshProUGUI coreText;
    public GameObject player;
    public GameObject startButton;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnObstacle()
    {
        while (true)
        {
            float waitTime = Random.Range(0.7f, 1.6f);
            yield return new WaitForSeconds(waitTime);
            Instantiate(obstacle, spawnPoint.position, Quaternion.identity);
        }
    }
    public void GameStart()
    {
        player.SetActive(true);
        startButton.SetActive(false);
        StartCoroutine(SpawnObstacle());
        InvokeRepeating("CoreUp",2f,1f);
    }
    void CoreUp()
    {
        core++;
        coreText.text = core.ToString();
    }
}
