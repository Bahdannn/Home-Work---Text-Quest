using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ui Elements")]
    [SerializeField] private TextMeshProUGUI _headerLabel;
    [SerializeField] private TextMeshProUGUI _storyLabel;
    [SerializeField] private TextMeshProUGUI _choiceLabel;
    [SerializeField] private TextMeshProUGUI _locationLabel;

    
    [Header("Initial Setup")]
    [SerializeField] private Step _startStep;

    private Step _currentStep;

    
    
    private void Start()
    {
        SetCurrentStep(_startStep);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Step nextStep = _currentStep.Choice1;
            SetCurrentStep(nextStep);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            SetCurrentStep(_currentStep.Choice2);
        }
    }

    private void SetCurrentStep(Step step)
    {
        _currentStep = step;
        _headerLabel.text = _currentStep.HeaderText;
        _storyLabel.text = _currentStep.StoryText;
        _choiceLabel.text = _currentStep.ChoiseText;
        _locationLabel.text = _currentStep.LocationText;
        
    }
}