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
        [KSPField(isPersistant = true)]
        public float breakForce = 500f;

        [KSPField(isPersistant = true)]
        public float breakTorque = 500f;

        [KSPField(isPersistant = true)]
        private bool isAttached;

        [KSPField(isPersistant = true)]
        private Vector3 attachOffset;

        [KSPField(isPersistant = true)]
        private Quaternion attachRotation;

        private FixedJoint fixedJoint;
        private GameObject fixedObject;


        [KSPEvent(active = true, guiActive = true, guiName = "Attach Foundations")]
        public void EventAttach()
        {
            Debug.Log("Foundations: EventAttach()");
            //Events["EventAttach"].guiName = "Attach Foundations";
            if (part.GroundContact)
            {
                Debug.Log(string.Format("[Foundations v{0}]: AttachEvent().", Version.Text));
                Attach();
            }
            else
            {
                Debug.Log(string.Format("[Foundations v{0}]: No ground contact, aborting.", Version.Text));
                Message("Foundations not touching the ground.");
            }
        }

        [KSPEvent(active = false, guiActive = true, guiName = "Detach Foundations")]
        public void EventDetach()
        {
            Debug.Log(string.Format("[Foundations v{0}]: EventDetach().", Version.Text));
        }

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

        private void Attach()
        {
            Debug.Log("Foundations: Attach()");

            /*            Events["EventAttach"].active = false;
                        Events["EventDetach"].active = true;            
                        attachOffset = Vector3.zero;            
                        attachRotation = transform.rotation;*/
            isAttached = true;
            /*            Debug.Log("Foundation: rotation:");
                        Debug.Log(Convert.ToString(attachRotation));*/
            SwitchEventState();
            CreateAttachment();
        }

        private void Detach()
        {
            Debug.Log("Foundations: Detach()");

            /*            Events["EventAttach"].active = true;
                        Events["EventDetach"].active = false;

                        attachOffset = Vector3.zero;
                        attachRotation = Quaternion.identity;*/
            isAttached = false;
            SwitchEventState();
            DestroyAttachment();
        }

        public void OnPartUnpack()
        {
#if DEBUG
            Debug.Log(string.Format("Foundations: OnPartUnpack(isAttached = {0})", isAttached));
#endif
            if (isAttached)
            {
                DestroyAttachment();
                CreateAttachment();
                SwitchEventState();
            }
        }

        //Clean up the PAW if the part doesn't touch the ground
        public override void OnUpdate()
        //Clean up the PAW if the part doesn't touch the ground
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

            //attachOffset = Vector3.op_Subtraction(this.fixedObject.get_transform().get_position(), ((Component)this.get_part()).get_transform().get_position());
            //Vector3 attachOffset = (fixedObject.transform.position - part.transform.position);
        }

        public void OnJointBreak(float force)
        {
            Debug.LogWarning(string.Format("Foundations: OnJointBreak(force = {0}, isAttached = {1})", force, isAttached));
            Detach();
        }

        private void CreateAttachment()
        {
            Debug.Log("Foundations: CreateAttachment");

            Debug.Log("Foundations: Creating object");
            CreateFixedObject();

            Debug.Log("Foundations: Creating joint");
            CreateFixedJoint();
        }

        private void CreateFixedObject()
        {
            attachOffset = Vector3.zero;
            attachRotation = transform.rotation;
            Vector3 position = (part.transform.position + attachOffset);

            fixedObject = new GameObject("FoundationsBody");
            fixedObject.AddComponent<Rigidbody>();
            fixedObject.GetComponent<Rigidbody>().isKinematic = true;
            fixedObject.transform.position = position;
            fixedObject.transform.rotation = attachRotation;
        }

        private void CreateFixedJoint()
        {
            fixedJoint = part.gameObject.AddComponent<FixedJoint>();
            fixedJoint.connectedBody = fixedObject.GetComponent<Rigidbody>();
            fixedJoint.breakForce = breakForce;
            fixedJoint.breakTorque = breakTorque;
        }

        private void DestroyAttachment()
        {
            Debug.Log("Foundations: DestroyAttachment()");
            if (fixedJoint != null)
            {
                Debug.Log("Foundations: Destroying joint.");
                Destroy(fixedJoint);
                fixedJoint = null;
            }

            if (fixedObject != null)
            {
                Debug.Log("Foundations: Destroying object.");
                Destroy(fixedObject);
                fixedObject = null;
            }
        }

        private void Message(string format, params object[] args)
        {
            ScreenMessages.PostScreenMessage(string.Format(format, args), 3f, 0);
        }
    }
}


