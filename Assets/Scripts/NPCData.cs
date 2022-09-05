using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ? "NPCDataSO", menuName = "NPC Data")]

public class NPCData : ScriptableObjects
{
    public string[] dialogueFrases;
    public bool hasTalked;
}
