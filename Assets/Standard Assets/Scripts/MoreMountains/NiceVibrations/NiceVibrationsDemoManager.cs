using UnityEngine;
using UnityEngine.UI;

namespace MoreMountains.NiceVibrations
{
	public class NiceVibrationsDemoManager : MonoBehaviour
	{
		public Text DebugTextBox;

		protected string _debugString;

		protected string _platformString;

		protected const string _CURRENTVERSION = "1.2";

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void DisplayInformation()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void TriggerDefault()
		{
		}

		public virtual void TriggerVibrate()
		{
		}

		public virtual void TriggerSelection()
		{
		}

		public virtual void TriggerSuccess()
		{
		}

		public virtual void TriggerWarning()
		{
		}

		public virtual void TriggerFailure()
		{
		}

		public virtual void TriggerLightImpact()
		{
		}

		public virtual void TriggerMediumImpact()
		{
		}

		public virtual void TriggerHeavyImpact()
		{
		}
	}
}
