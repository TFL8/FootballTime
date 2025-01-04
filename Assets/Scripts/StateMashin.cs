using UnityEngine;

public class StateMashin : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject statisticCanvas;
    public GameObject adminkaCanvas;

    public GameObject curentCanvas;

    public GameObject[] canvasesMainMenu;
    public GameObject[] canvasesStatistic;
    public GameObject[] canvasesAdminka;

    public void Start()
    {
        foreach (GameObject c in canvasesMainMenu)
        {
            c.SetActive(false);
        }

        if (mainCanvas != null)
        {
            mainCanvas.SetActive(true);
            curentCanvas = mainCanvas;
        }
    }

    public void StateMashinCanvases(GameObject canvas)
    {
        curentCanvas = canvas;

        foreach (GameObject c in canvasesMainMenu)
        {
            c.SetActive(false);
        }
        curentCanvas.SetActive(true);
    }

    public void StateMashinCanvasesStatistic(GameObject canvas)
    {
        curentCanvas = canvas;

        foreach (GameObject c in canvasesStatistic)
        {
            c.SetActive(false);
        }
        curentCanvas.SetActive(true);
    }

    public void StateMashinCanvasesAdminka(GameObject canvas)
    {
        curentCanvas = canvas;

        foreach (GameObject c in canvasesAdminka)
        {
            c.SetActive(false);
        }
        curentCanvas.SetActive(true);
    }

    public void ReturnMainMenu()
    {
        foreach (GameObject c in canvasesMainMenu)
        {
            c.SetActive(false);
        }
        foreach (GameObject c in canvasesStatistic)
        {
            c.SetActive(false);
        }
        foreach (GameObject c in canvasesAdminka)
        {
            c.SetActive(false);
        }

        mainCanvas.SetActive(true);
    }

    public void ReturnStatisticMenu()
    {
        foreach (GameObject c in canvasesStatistic)
        {
            c.SetActive(false);
        }
        statisticCanvas.SetActive(true);
    }

    public void ReturnAdminkaMenu()
    {
        foreach (GameObject c in canvasesAdminka)
        {
            c.SetActive(false);
        }
        adminkaCanvas.SetActive(true);
    }

}
