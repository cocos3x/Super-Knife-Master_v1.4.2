using UnityEngine;

namespace FairyGUI
{
	public class BlurFilter : IFilter
	{
		public float blurSize;

		private DisplayObject _target;

		private Material _blitMaterial;

		public DisplayObject target
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Dispose()
		{
		}

		public void Update()
		{
		}

		private void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		private void OnRenderImage()
		{
		}
	}
}
