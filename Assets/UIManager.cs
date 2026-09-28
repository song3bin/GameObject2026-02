using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject inventoryPanel;
    public GameObject skillPanel;
    public GameObject rankPanel;

    private GameObject currentPanel;

    void Start()
    {
        inventoryPanel.SetActive(false);
        skillPanel.SetActive(false);
        rankPanel.SetActive(false);

        currentPanel = null;
    }

    public void ToggleInventory()
    {
        TogglePanel(inventoryPanel);
    }

    public void ToggleSkill()
    {
        TogglePanel(skillPanel);
    }

    public void ToggleRank()
    {
        TogglePanel(rankPanel);
    }

    void TogglePanel(GameObject panel)
    {
        // 이미 열려 있는 패널을 다시 누르면 닫기
        if (currentPanel == panel)
        {
            panel.SetActive(false);
            currentPanel = null;
        }
        else
        {
            // 기존 패널 닫기
            if (currentPanel != null)
            {
                currentPanel.SetActive(false);
            }

            // 새 패널 열기
            panel.SetActive(true);
            currentPanel = panel;
        }
    }
}