using ReferencePicker;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKL_AS_DamageAction : SKL_SkillAction
{
    [Header("Damage Datas")]
    [SerializeField] private SKL_DamageData[] damagesData;

    [Header("Animation")]
    [SerializeField, SerializeReference, ReferenceEditor(typeof(SKL_SkillActionAnimation))] private SKL_SkillActionAnimation[] damageAnimations;

    [Header("Actions")]
    [SerializeField] private SKL_SkillActionChooser nextAction;

    public SKL_DamageData[] DamagesData => damagesData;

    public SKL_SkillActionAnimation[] DamageAnimations => damageAnimations;

    public SKL_SkillAction GetNextAction(SKL_ResolvingSkillData resolvingSkillData)
    {
        return nextAction.GetFirstUsableAction(resolvingSkillData);
    }
}
