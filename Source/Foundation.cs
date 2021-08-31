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
        // Localizer.Format("#Foundations_WindowTitle", Version.Text), //"Logistics Network v "

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


        [KSPEvent(active = true, guiActive = true, guiName = "#Foundations-Attach")]
        public void EventAttach()
        {
            Debug.Log(string.Format("[Foundations v{0}]: EventAttach()", Version.Text));
            //Events["EventAttach"].guiName = "Attach Foundations";
            if (part.GroundContact)
            {
#if DEBUG
                Debug.Log(string.Format("[Foundations v{0}]: AttachEvent().", Version.Text));
#endif
                Attach();
            }
            else
            {
#if DEBUG
                Debug.Log(string.Format("[Foundations v{0}]: {1} has no ground contact, aborting.", Version.Text, part.name));
#endif
                // Message("Foundations not touching the ground.");
                Message(Localizer.Format("#Foundations-NotTouching", part.name)); // Foundation <<1>> not touching the ground.
            }
        }

        [KSPEvent(active = false, guiActive = true, guiName = "#Foundations-Detach")]
        public void EventDetach()
        {
            Debug.Log(string.Format("[Foundations v{0}]: EventDetach().", Version.Text));
            //Message(Localizer.Format("#Foundations-PartDetach", part.name)); // <<1>> Foundation removed.
        }

        [KSPAction("#Foundations-Toggle")]
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
#if DEBUG
            Debug.Log(string.Format("[Foundations v{0}]: Attach().", Version.Text)); // "Foundations: Attach()");

            Debug.Log(string.Format("[Foundations v{0}]: breakForce {1:0.0000}.", Version.Text, breakForce));
            Debug.Log(string.Format("[Foundations v{0}]: breakTorque {1:0.0000}.", Version.Text, breakTorque));
            Debug.Log(string.Format("[Foundations v{0}]: attachOffset {1:0.0000}.", Version.Text, attachOffset));
            Debug.Log(string.Format("[Foundations v{0}]: attachRotation {1:0.0000}.", Version.Text, attachRotation));
#endif

            attachOffset = Vector3.zero;
            attachRotation = transform.rotation;

            SwitchEventState();

            isAttached = true;

            CreateAttachment();
            Message(Localizer.Format("#Foundations-PartAttach", part.name)); // <<1>> Foundation created.
        }

        private void Detach()
        {
#if DEBUG
            Debug.Log(string.Format("[Foundations v{0}]: Detach().", Version.Text));  // "Foundations: Detach()");

            Debug.Log(string.Format("[Foundations v{0}]: breakForce {1:0.0000}.", Version.Text, breakForce));
            Debug.Log(string.Format("[Foundations v{0}]: breakTorque {1:0.0000}.", Version.Text, breakTorque));
            Debug.Log(string.Format("[Foundations v{0}]: attachOffset {1:0.0000}.", Version.Text, attachOffset));
            Debug.Log(string.Format("[Foundations v{0}]: attachRotation {1:0.0000}.", Version.Text, attachRotation));
#endif


            attachOffset = Vector3.zero;
            attachRotation = Quaternion.identity;

            SwitchEventState();

            isAttached = false;

            DestroyAttachment();
            Message(Localizer.Format("#Foundations-PartDetach", part.name)); // <<1>> Foundation removed.
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

        /// OnUpdate
        /// Clean up the PAW if the part doesn't touch the ground
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

            // attachOffset = Vector3.op_Subtraction(this.fixedObject.get_transform().get_position(), ((Component)this.get_part()).get_transform().get_position());
            // Vector3 attachOffset = (fixedObject.transform.position - part.transform.position);
        }

        public void OnJointBreak(float force)
        {

#if DEBUG
            Debug.LogWarning(string.Format("[Foundations v{0}]: OnJointBreak(force = {1}, isAttached = {2})", Version.Text, force, isAttached));
# endif

            Detach();
        }

        private void CreateAttachment()
        {

#if DEBUG
            Debug.Log("Foundations: CreateAttachment");
            Debug.Log("Foundations: Creating object");
#endif

            CreateFixedObject();

#if DEBUG
            Debug.Log("Foundations: Creating joint");
#endif

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

#if DEBUG
            Debug.Log("Foundations: DestroyAttachment()");
#endif
            if (fixedJoint != null)
            {

#if DEBUG
                Debug.Log("Foundations: Destroying joint.");
#endif
                Destroy(fixedJoint);
                fixedJoint = null;
            }

            if (fixedObject != null)
            {

#if DEBUG
                Debug.Log("Foundations: Destroying object.");
#endif
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


