using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectDifficulty : MonoBehaviour
{
    public enum Difficult
    {
        Easy,
        Normal,
        Hard,
        Expert
    }

    public Difficult selectDifficulty;

    private void Start()
    {
        SceneManager.LoadScene((int)selectDifficulty);
    }
}
