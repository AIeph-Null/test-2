using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class SetTurnType : MonoBehaviour
{

    public ActionBasedSnapTurnProvider snapTurn;
    public ActionBasedContinuousTurnProvider continuousTurn;

    public void SetTypeFromIndex(int index)
  {
    if(index == 0)
    {
      snapTurn.enabled = false;
      continuousTurn.enabled = true;
    }
    else
    {
      snapTurn.enabled = true;
      continuousTurn.enabled = false;
    }
  }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
