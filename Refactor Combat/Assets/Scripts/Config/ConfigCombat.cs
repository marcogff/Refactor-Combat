using UnityEngine;

[CreateAssetMenu(fileName = "New ConfigCombat", menuName = "Config/ConfigCombat", order = 0)]
public class ConfigCombat : ScriptableObject
{
    public float transitionDuration;
    public float waitCombatDuration;
    public float evaluationDuration;
    public float scaleCombat;
    public Vector3 positionCombat;
    public float positionCharacter;
    
}
