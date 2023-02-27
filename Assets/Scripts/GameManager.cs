using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int currrentGold;
    public TextMeshProUGUI goldText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addGold(int goldToAdd)
    {
        currrentGold += goldToAdd;
        goldText.text = "Gold: " + currrentGold + "/17";
        if(currrentGold == 17)
        {
            SceneManager.LoadScene("FimDeJogo");
        }
    }
}
