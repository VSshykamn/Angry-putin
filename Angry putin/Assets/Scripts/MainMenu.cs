using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//перечисления
enum ActivePanal 
{
    Level,
    Option,
    About,
    Quit,
    LevelChouse
}
public class MainMenu : MonoBehaviour
{
    [SerializeField] private List<GameObject> panals;
    [SerializeField] private List<Animator> animators;


    ActivePanal activePanal = ActivePanal.Level;
    private void Awake()
    {
        foreach (GameObject panal in panals)
        {
            animators.Add(panal.GetComponent<Animator>());
        }
    }
    public void StartGame()
    {
        if (activePanal != ActivePanal.LevelChouse) 
        {
            panals[3].SetActive(true);
            animators[0].SetTrigger("Open");
        }
    }
    public void QuitGame()
    {
        if (activePanal != ActivePanal.Quit)
        {
            panals[2].SetActive(true);
            animators[2].SetTrigger("Open"); 
        }
        activePanal = ActivePanal.Quit;
    }
    public void Options()
    {

        if (activePanal != ActivePanal.Option)
        {
            //optionsPanlnAnimator.SetTrigger("Open");
            panals[0].SetActive(true);
            //panals[1].SetActive(false);
            animators[0].SetTrigger("Open");
            animators[1].SetTrigger("Close");
        }
        activePanal = ActivePanal.Option;
    }
    public void About()
    {
        if (activePanal != ActivePanal.About)
        {

            animators[0].SetTrigger("Close");

            animators[1].SetTrigger("Open");
            panals[1].SetActive(true);
        }
        activePanal = ActivePanal.About;
    }



    public void QuitNoButton()
    {
        panals[2].SetActive(false);
        animators[2].SetTrigger("Close");
    }

    public void QuitYesButton()
    {
        Application.Quit();
    }




}

