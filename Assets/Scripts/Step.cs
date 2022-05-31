using UnityEngine;

public class Step : MonoBehaviour
{
    public string LocationText;
    public string HeaderText;
    [TextArea(5,7)]
    public string StoryText;
    [TextArea(5,7)]
    public string ChoiseText;
    
    public Step Choice1;
    public Step Choice2;
    
}