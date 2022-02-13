using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using GDA.Interactibles.UserObj;
using GDA.Interactibles.UserAbility;
using GDA.Interactibles.UserControlSettings;
using GDA.Interfaces;

namespace GDA.Interactibles.UserControls
{
    [RequireComponent(typeof(Obj), typeof(Ability), typeof(ControlSettings))]
    public class Controls : MonoBehaviour
    {
        Obj obj;
        Ability ability;
        ControlSettings controlSettings;
        CommandManager commandManager;
        IInventorySettings inventorySettings;
        AnimCallback animCallback;
        float speed;

        void Start()
        {
            obj = GetComponent<Obj>();
            ability = GetComponent<Ability>();
            controlSettings = GetComponent<ControlSettings>();
            inventorySettings = GetComponent<IInventorySettings>();
            commandManager = new CommandManager(obj, ability, inventorySettings);                 
            animCallback = new AnimCallback(obj);
        }      

        void Update()
        {
            if (Time.timeScale > 0)
                PlayerInput();
        }

        void PlayerInput()
        {
            speed = 1f;
            if (Input.GetKey(controlSettings.sprint))
                speed = 2f;
            if (Input.GetKey(controlSettings.forward) && Input.GetKey(controlSettings.right))
                obj.anim.Velocity(speed, speed);
            else if (Input.GetKey(controlSettings.right) && Input.GetKey(controlSettings.back))
                obj.anim.Velocity(speed, -speed);
            else if (Input.GetKey(controlSettings.back) && Input.GetKey(controlSettings.left))
                obj.anim.Velocity(-speed, -speed);
            else if (Input.GetKey(controlSettings.left) && Input.GetKey(controlSettings.forward))
                obj.anim.Velocity(-speed, speed);
            
            else if (Input.GetKey(controlSettings.forward))
                obj.anim.Velocity(0f, speed);
            else if (Input.GetKey(controlSettings.back))
                obj.anim.Velocity(0f, -speed);
            else if (Input.GetKey(controlSettings.left))
                obj.anim.Velocity(-speed, 0f);
            else if (Input.GetKey(controlSettings.right))
                obj.anim.Velocity(speed, 0f);
            else
                obj.anim.ResetVelocity();

            if (Input.GetKeyDown(KeyCode.Space))
                obj.movement.Jump(obj.isGrounded, obj.anim.Jump);

            if (Input.GetKeyDown(controlSettings.attack))
                commandManager.UseCurrentCommand();
            if (Input.GetKeyDown(controlSettings.scrollAbilities))
                commandManager.ScrollAbilities();
            if (Input.GetKeyDown(controlSettings.toggleAbility))
                commandManager.ToggleCommand();

            obj.rotation.Interpolate();

            Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));          
            obj.anim.Aim(mouseDelta.x / 10f, mouseDelta.y / 10f);
        }
    }
}