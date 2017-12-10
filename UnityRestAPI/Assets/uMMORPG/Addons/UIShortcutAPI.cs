using System.Text;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class UIShortcuts {
    public Button buttonAPI;
    public GameObject APIPanel;
    void Update_UIShortcutAPI() {
        buttonAPI.onClick.SetListener(() =>
        {
            APIPanel.SetActive(!APIPanel.activeSelf);
        });
    }
}
