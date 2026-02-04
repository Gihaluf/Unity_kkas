using UnityEngine;

public class ChangeTvPanel : MonoBehaviour
{
    public GameObject maj;
    public GameObject kaz;
    public GameObject couch;
    public GameObject tvOn;
    public GameObject staticsc;
    private SoundEffectScript sfxScript;
    private int x=1;
    void Start()
    {
        sfxScript = FindFirstObjectByType<SoundEffectScript>();
        sfxScript.PlaySFX(0);
    }
    public void AddOne(int y)
    {
        if(y ==1 )
            x++;
        else 
            x--;
        ChangeChannel();
    }
    public void ChangeChannel()
    {
       
        if (x == 4)
            x = 1;
        if (x == 0)
            x = 3;
        switch (x)
            {
                case 1:
                    sfxScript.PlaySFX(1);
                    couch.SetActive(true);
                    kaz.SetActive(false);
                    maj.SetActive(false);
                    break;
                case 2:
                    sfxScript.PlaySFX(2);
                    couch.SetActive(false);
                    kaz.SetActive(true);
                    maj.SetActive(false);
                break;
                case 3:
                    sfxScript.PlaySFX(3);
                    couch.SetActive(false);
                    kaz.SetActive(false);
                    maj.SetActive(true);
                break;
        }
        
    }
    public void turnTV(int state)
    {
        if (state == 0)
        { 
            sfxScript.PlaySFX(0);
            staticsc.SetActive(true);
            couch.SetActive(false);
            kaz.SetActive(false);
            maj.SetActive(false);
            tvOn.SetActive(true);
        }
        else {
            staticsc.SetActive(false);
            tvOn.SetActive(false);
            ChangeChannel();
        }
    }
}
