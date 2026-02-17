using System.Collections;
using UnityEngine;
using TMPro;

public class DonutBakerScript : MonoBehaviour
{
    public GameObject[] donutPrefabs;
    public float bakeInterval = 1.0f;
    public float offset = 0.7f;

    private float timeElapsed = 0f;
    public TextMeshProUGUI timerText;
    private bool isTimerRunning = false;

    float minPoz, maxPoz;
    Transform ovenTransform;

    void Start()
    {
        ovenTransform = GetComponent<Transform>();
    }
    void Update()
    {
        if (isTimerRunning)
        {
            timeElapsed += Time.deltaTime;
            UpdateTimerDisplay(timeElapsed);
        }
    }

    public void BakeDonut(bool state)
    {
        if (state)
        {
            isTimerRunning = true;
            StopAllCoroutines();
            StartCoroutine(Bake());
        }
        else
        {
            isTimerRunning = false;
            StopAllCoroutines();
        }
    }

    IEnumerator Bake()
    {
        while (true)
        {
            minPoz = ovenTransform.position.x - offset;
            maxPoz = ovenTransform.position.x + offset;
            float randPoz = Random.Range(minPoz, maxPoz);
            Vector2 spawnPoz = new Vector2(randPoz, ovenTransform.position.y);

            int donutIndex = Random.Range(0, donutPrefabs.Length);
            Instantiate(donutPrefabs[donutIndex], spawnPoz, Quaternion.identity, ovenTransform);

            yield return new WaitForSeconds(bakeInterval);
        }
    }

    void UpdateTimerDisplay(float timeToDisplay)
    {
        if (timerText == null) return;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}