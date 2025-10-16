using UnityEngine;
using TMPro;

public class GradeSettings : MonoBehaviour
{
    private string BaseText = "Your current grade: ";

    [SerializeField] private GameObject ExitButton;
    [SerializeField] private GameObject Settings;
    [SerializeField] private TMP_Text GradeText;
    void Start()
    {
        bool IsGradeSet = PlayerPrefs.HasKey("Grade");
        if (!IsGradeSet)
        {
            Settings.SetActive(true);
            ExitButton.SetActive(false); //disabling ability to close menu
            UpdateText(-1, true);
        }
        else UpdateText(PlayerPrefs.GetInt("Grade"));
    }

    void UpdateText(int Grade, bool hide = false)
    {
        if (!hide)
            GradeText.text = BaseText + Grade.ToString();
        else
            GradeText.text = "";
    }
    void UnlockExitButton()
    {
        ExitButton.SetActive(true); //if not active
    }
    public void SetGrade(int Grade)
    {
        PlayerPrefs.SetInt("Grade", Grade);
        UpdateText(Grade);
        UnlockExitButton();
        Settings.SetActive(false);
    }
}
