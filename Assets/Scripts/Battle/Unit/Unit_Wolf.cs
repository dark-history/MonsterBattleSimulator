﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit_Wolf : Unit
{
    public GameObject skillObject;

    public override void Attack()
    {
        base.Attack();
    }
    public override void UseSkill()
    {
        base.UseSkill();

        // 데미지 설정
        Damage damage = new Damage();
        damage.buffList.Add(new BuffData(BuffType.attackSpeedUp2, 4f * currentAbilityPower / 100));

        // 스킬 생성
        GameObject tempObject = Instantiate(skillObject, transform.position, Quaternion.identity); // 스킬 방향이 보는 방향이 일치해야하며, 내 위치에서 생성될 때

        // 스킬 정보 설정
        Skill skill = tempObject.GetComponent<Skill>();
        skill.team = team; // 팀 구별 색인자
        skill.damage = damage; // 범위내 적에게 줄 데미지 정보, 틱데미지일경우 한틱당 데미지
    }
    public override void Dead()
    {
        base.Dead();
    }
    public override void ApplyDamage(Damage damage)
    { 
        base.ApplyDamage(damage);
    }
}
