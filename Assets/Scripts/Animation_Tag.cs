using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Tag : MonoBehaviour
{
    public const string MOVEMENT = "MoveMent";

    public const string PUNCH_1_TRIGGER = "punch1";
    public const string PUNCH_2_TRIGGER = "punch2";
    public const string PUNCH_3_TRIGGER = "punch3";

    public const string KICK_1_TRIGGER = "kick1";
    public const string KICK_2_TRIGGER = "kick2";

    public const string ATTACK_1_TRIGGER = "Attack1";
    public const string ATTACK_2_TRIGGER = "Attack2";
    public const string ATTACK_3_TRIGGER = "Attack3";

    public const string IDLE_ANIMATION = "Idle";

    public const string KNOCK_DOWN_TRIGGER = "KnockDown";
    public const string STANT_UP_TRIGGER = "StandUp";
    public const string HIT_TRIGGER = "Hit";
    public const string DEATH_TRIGGER = "Death";
}

public class Axis
{
    public const string HORIZONTAL_AXIS = "Horizontal";
    public const string VERTCALO_AXIS = "Vertical";
}

public class Tags
{
    public const string GROUND_TAG = "Ground";
    public const string PLAYER_TAG = "Player";
    public const string ENEMY_TAG = "Enemy";

    public const string LEFT_ARM_TAG = "LeftArm";
    public const string LEFT_LEG_TAG = "LeftLeg";
    public const string UNTAGGED = "untagged";
    public const string MAIN_CAMERA_TAG = "MainCamera";
    public const string HEALTH_UI = "HealthUI";

}

