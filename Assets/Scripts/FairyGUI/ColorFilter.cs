using UnityEngine;

namespace FairyGUI
{
	public class ColorFilter : IFilter
	{
		private DisplayObject _target;

		private float[] _matrix;

		private const float LUMA_R = 0.299f;

		private const float LUMA_G = 0.587f;

		private const float LUMA_B = 0.114f;

		private static float[] IDENTITY;

		private static float[] tmp;

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

		public void Invert()
		{
		}

		public void AdjustSaturation(float sat)
		{
		}

		public void AdjustContrast(float value)
		{
		}

		public void AdjustBrightness(float value)
		{
		}

		public void AdjustHue(float value)
		{
		}

		public void Tint(Color color, float amount = 1f)
		{
		}

		public void Reset()
		{
		}

		private void _ConcatValues(int index, float f0, float f1, float f2, float f3, float f4)
		{
		}

		public void ConcatValues(params float[] values)
		{
		}

		private void UpdateMatrix()
		{
		}
	}
}
