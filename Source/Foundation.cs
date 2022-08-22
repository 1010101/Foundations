//Originally written by forum user Sparkle: https://forum.kerbalspaceprogram.com/index.php?/profile/91081-sparkle/
//Link to the original thread: https://forum.kerbalspaceprogram.com/index.php?/topic/51430-plugin-022-wip-foundations-update-alpha-release-02/&tab=comments#comment-739075

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;*/
using UnityEngine;
using KSP.Localization;

namespace Foundations
{
    class Foundation : PartModule
    {
        /// <summary>Module information shown in editors</summary>
        private string info = string.Empty;


        [KSPField(isPersistant = true,
                  guiActive = false,
                  guiActiveEditor = false,
                  guiName = "#FND-breakForce")]
        public float breakForce = 500f;

        [KSPField(isPersistant = true,
                  guiActive = false,
                  guiActiveEditor = false,
                  guiName = "#FND-breakTorque")]
        public float breakTorque = 500f;

        // Ground Header in PAW
        //[KSPField(isPersistant = true,
        //          guiActive = true,
        //          guiActiveEditor = false,
        //          guiActiveUnfocused = false,
        //          guiName = "#FND-GroupName"),
        //          //  groupStartCollapsed = true),
        //          UI_Toggle(disabledText = "#FND-Detached", enabledText = "#FND-Attached",
        //          affectSymCounterparts = UI_Scene.All)]
        [KSPField(isPersistant = true)]
        public bool isAttached;

        [KSPField(isPersistant = true)]
        private Vector3 attachOffset;

        [KSPField(isPersistant = true)]
        private Quaternion attachRotation;

        private FixedJoint fixedJoint;
        private GameObject fixedObject;

        /// <summary>Called when the user requests attachment via the GUI.</summary>
        [KSPEvent(active = true, guiActive = true, guiName = "#FND-Attach")] //groupName = "Foundations",
        public void EventAttach()
        {
            Dlog("EventAttach()", true);
            if (part.GroundContact)
            {
                Dlog("Has Ground Contact().");
                // Attach();
                Dlog("Attach().", true); // "Foundations: Attach()");

                attachOffset = Vector3.zero;
                attachRotation = transform.rotation;
                isAttached = true;
                Attach();
                // SwitchEventState();

                //CreateAttachment();
            }
            else
            {
                Dlog(string.Format("{1} has no ground contact, aborting.", part.name), xDebug: true);

                Message(Localizer.Format("#FND-NotTouching", part.name)); // Foundation <<1>> not touching the ground.
            }
        }

        /// <summary>Called when the user requests detachment via the GUI.</summary>
        [KSPEvent(active = false, guiActive = true, guiName = "#FND-Detach")]  // groupName = "Foundations",
        public void EventDetach()
        {
            Detach();
            Dlog("EventDetach()", true);
            Message(Localizer.Format("#FND-PartDetach", part.name)); // <<1>> Foundation removed.
        }

        /// <summary>Called when the user toggle attachment via the GUI.</summary>
        //[KSPAction("#FND-Toggle")]
        [KSPAction("Toggle Foundation")]
        public void ToggleAttachment(KSPActionParam param)
        {
            if (isAttached)
            {
                EventDetach();
            }
            else
            {
                EventAttach();
            }
        }

        /// <summary>Switches the state of the event.</summary>
        public void SwitchEventState()
        {

            if (Events["EventAttach"].active)
            {
                Events["EventAttach"].active = false;
                Events["EventDetach"].active = true;
            }
            else
            {
                Events["EventAttach"].active = true;
                Events["EventDetach"].active = false;
            }
        }

        /// <summary>OnUpdate:Clean up the PAW if the part doesn't touch the ground</summary>
        public override void OnUpdate()
        {
            if (!part.GroundContact)
            {
                Events["EventAttach"].guiActive = false;
                Events["EventDetach"].guiActive = false;
            }
            else
            {
                Events["EventAttach"].guiActive = true;
                Events["EventDetach"].guiActive = true;
            }
            //attachOffset = fixedObject.transform.position - part.transform.position;  // from Sparkles original code

            // attachOffset = Vector3.op_Subtraction(this.fixedObject.get_transform().get_position(), ((Component)this.get_part()).get_transform().get_position());
            // Vector3 attachOffset = (fixedObject.transform.position - part.transform.position);
        }

        /// <summary>Updates the game state to record that we are now attached.</summary>
        private void Attach()
        {
            Dlog("Attach().", true); // "Foundations: Attach()");
            Dlog(string.Format("breakForce {0}.", breakForce.ToString()));
            Dlog(string.Format("breakTorque {0}.", breakTorque.ToString()));
            Dlog(string.Format("attachOffset {0}.", attachOffset.ToString()));
            Dlog(string.Format("attachRotation {0}.", attachRotation.ToString()));

            /*        attachOffset = Vector3.zero;
                        attachRotation = transform.rotation;*/

            isAttached = true;

            SwitchEventState();
            CreateAttachment();

            Message(Localizer.Format("#FND-PartAttach", part.name)); // <<1>> Foundation created.
        }

        /// <summary>Updates the game state to record that we are now detached.</summary>
        private void Detach()
        {
            Dlog("Detach().", true);  // "Foundations: Detach()");
            Dlog(string.Format("breakForce {0}.", breakForce.ToString()));
            Dlog(string.Format("breakTorque {0}.", breakTorque.ToString()));
            Dlog(string.Format("attachOffset {0}.", attachOffset.ToString()));
            Dlog(string.Format("attachRotation {0}.", attachRotation.ToString()));

            /*          attachOffset = Vector3.zero;
                        attachRotation = Quaternion.identity;*/
            isAttached = false;

            SwitchEventState();
            DestroyAttachment();

            Message(Localizer.Format("#FND-PartDetach", part.name)); // <<1>> Foundation removed.
        }

        /// <summary>Called when the part is ready to play with the rest of the physics world.</summary>
        public void OnPartUnpack()
        {
            Dlog(string.Format("OnPartUnpack: part {0} isAttached = {1})", part.name, isAttached));

            if (isAttached)
            {
                DestroyAttachment();
                CreateAttachment();
                SwitchEventState();
            }
        }

        /// <summary>Called if you our joint breaks - i.e. we get torn out of the ground.</summary>
        public void OnJointBreak(float force)
        {
            DlogWarning(string.Format("OnJointBreak(force = {0}, isAttached = {1})", force.ToString(), isAttached), xDebug: true);
            Detach();
        }

        /// <summary>Creates the physical joint constraining our position.</summary>
        private void CreateAttachment()
        {
            Dlog("CreateAttachment");
            CreateFixedObject();
            CreateFixedJoint();
        }

        private void CreateFixedObject()
        {
            Dlog("Creating object");

            attachOffset = Vector3.zero;
            attachRotation = transform.rotation;
            Vector3 attachPosition = (part.transform.position + attachOffset);

            fixedObject = new GameObject("FoundationsBody");
            fixedObject.AddComponent<Rigidbody>();
            fixedObject.GetComponent<Rigidbody>().isKinematic = true;
            fixedObject.transform.position = attachPosition;
            fixedObject.transform.rotation = attachRotation;
        }

        private void CreateFixedJoint()
        {
            Dlog("Creating joint");

            fixedJoint = part.gameObject.AddComponent<FixedJoint>();
            fixedJoint.connectedBody = fixedObject.GetComponent<Rigidbody>();
            fixedJoint.breakForce = breakForce;
            fixedJoint.breakTorque = breakTorque;

            fixedJoint = part.gameObject.AddComponent<FixedJoint>();
            fixedJoint.connectedBody = fixedObject.GetComponent<Rigidbody>();
            fixedJoint.breakForce = breakForce;
            fixedJoint.breakTorque = breakTorque;
        }

        /// <summary>Removes the physical joint constraining our position.</summary>
        private void DestroyAttachment()
        {
            Dlog("DestroyAttachment()");

            if (fixedJoint != null)
            {
                Dlog("Destroying joint.");
                Destroy(fixedJoint);
                fixedJoint = null;
            }

            if (fixedObject != null)
            {
                Dlog("Destroying object.");
                Destroy(fixedObject);
                fixedObject = null;
            }
        }

        /// <summary>Messages to the screen in the specified format.</summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The arguments.</param>
        private void Message(string format, params object[] args)
        {
            //ScreenMessages.PostScreenMessage(string.Format(format, args), 3.0f, ScreenMessageStyle.UPPER_CENTER);
            ScreenMessages.PostScreenMessage(string.Format(format, args), 3f, 0);
        }

        /// <summary>Add messages to the log. Prepends "Foundations v{0}]: ", Version.Text</summary>
        /// <param name="logMsg">The message.</param>
        /// <param name="xDebug">require DEBUG setting to create log entry</param>
        private void DlogWarning(string logMsg, bool xDebug = true)
        {
            logMsg = string.Format("[Foundations v{0}]: ", Version.Text) + logMsg;
            if (xDebug || HighLogic.CurrentGame.Parameters.CustomParams<Foundations_Options>().foundationsXDebug)
            {
                Debug.LogWarning(logMsg);
            }
            else
            {
#if DEBUG
                //Debug.LogWarning(string.Format("[Foundations v{0}]: OnJointBreak(force = {1}, isAttached = {2})", Version.Text, force, isAttached));
                Debug.LogWarning(logMsg);
#endif
            }
        }

        /// <summary>LogError: Add messages to the log. Prepends "Foundations v{0}]: ", Version.Text</summary>
        /// <param name="logMsg">The message.</param>
        /// <param name="xDebug">require DEBUG setting to create log entry</param>
        private void DlogError(string logMsg, bool xDebug = true)
        {
            logMsg = string.Format("[Foundations v{0}]: ", Version.Text) + logMsg;
            if (xDebug || HighLogic.CurrentGame.Parameters.CustomParams<Foundations_Options>().foundationsXDebug)
            {
                Debug.LogError(logMsg);
            }
            else
            {
            #if DEBUG
                    Debug.LogError(logMsg);
            #endif
            }
        }

        /// <summary>LogWarning: Add messages to the log. Prepends "Foundations v{0}]: ", Version.Text</summary>
        /// <param name="logMsg">The message.</param>
        /// <param name="xDebug">require DEBUG setting to create log entry</param>
        private void Dlog(string logMsg, bool xDebug = true)
        {
            logMsg = string.Format("[Foundations v{0}]: ", Version.Text) + logMsg;
            if (xDebug || HighLogic.CurrentGame.Parameters.CustomParams<Foundations_Options>().foundationsXDebug)
            {
                Debug.Log(logMsg);
            }
            else
            {
            #if DEBUG
                //Debug.LogWarning(string.Format("[Foundations v{0}]: OnJointBreak(force = {1}, isAttached = {2})", Version.Text, force, isAttached));
                Debug.Log(logMsg);
            #endif
            }
        }

        /// <summary>Formats the information for the part information in the editors.</summary>
        /// <returns>info</returns>
        public override string GetInfo()
        {
            // this is what is show in the editor
            if (info == string.Empty)
            {
                //info += "\n<color=#BADA55>Breaking Force:  </color>\t" + breakForce.ToString() + "\n<color=#BADA55>Breaking Torque:</color>\t" + breakTorque.ToString();
                info += Localizer.Format("#FND-Info", breakForce.ToString(), breakTorque.ToString());
            }
            return info;
        }
    }
}