using System.Collections;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


namespace NodeCanvas.Tasks.Actions {

	public class ArtTrackAT : ActionTask {

		public BBParameter<Transform> artTarget;
		public Vector3 localTransform;
		public Vector3 offset;
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
            return null;
		}

        //This is called once each time the task is enabled.
        //Call EndAction() to mark the action as finished, either in success or failure.
        //EndAction can be called from anywhere.
        protected override void OnExecute()
        {

        }
			
		        //Called once per frame while the action is active.
        protected override void OnUpdate() {
            localTransform.z = artTarget.value.transform.position.z;


            agent.transform.position = localTransform + offset;


        }

        

        //Called when the task is disabled.
        protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}