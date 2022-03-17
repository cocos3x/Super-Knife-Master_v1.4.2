using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Master
{
	public static class RandomUtil
	{
		public delegate int Weight<in T>(T x);

		public delegate double WeightD<in T>(T x);

		public delegate int[] WeightArray<in T>(T x);

		public static int sign => 0;

		public static float value => 0f;

		public static bool IsInChance(double value)
		{
			return false;
		}

		public static int Range(int min, int max)
		{
			return 0;
		}

		public static int FromTo(int min, int max)
		{
			return 0;
		}

		public static float FromTo(float min, float max)
		{
			return 0f;
		}

		public static int RandomWeightIndex(int[] array, string name)
		{
			return 0;
		}

		public static int RandomWeightValue(int[] array, string name)
		{
			return 0;
		}

		public static T RandomAorB<T>(T a, T b)
		{
			return (T)null;
		}

		public static T ArrayRandom<T>(T[] a)
		{
			return (T)null;
		}

		public static T ArrayRandom<T>(List<T> a)
		{
			return (T)null;
		}

		public static T GetSuitData<T>(T[] array, Weight<T> conditionFun, int condition, string name)
		{
			return (T)null;
		}

		public static T GetSuitData<T>(List<T> list, Weight<T> conditionFun, int condition, string name)
		{
			return (T)null;
		}

		public static T GetSuitData<T>(T[] array, WeightD<T> conditionFun, double condition, string name)
		{
			return (T)null;
		}

		public static T GetSuitData<T>(List<T> list, WeightD<T> conditionFun, double condition, string name)
		{
			return (T)null;
		}

		public static int GetRandomByWeight<T>(T[] array, Weight<T> conditionFun, WeightArray<T> conditionArrayFun, int[] ratioArray, int condition, string name)
		{
			return 0;
		}

		public static double GetRandomByWeight<T>(T[] array, Weight<T> conditionFun, WeightArray<T> conditionArrayFun, double[] ratioArray, int condition, string name)
		{
			return 0.0;
		}

		public static int GetRandomByWeight<T>(T[] array, WeightD<T> conditionFun, WeightArray<T> conditionArrayFun, int[] ratioArray, double condition, string name)
		{
			return 0;
		}

		public static double GetRandomByWeight<T>(T[] array, WeightD<T> conditionFun, WeightArray<T> conditionArrayFun, double[] ratioArray, double condition, string name)
		{
			return 0.0;
		}

		public static int GetRandomByWeight(int[] weightArray, int[] ratioArray, string name)
		{
			return 0;
		}

		public static double GetRandomByWeight(int[] weightArray, double[] ratioArray, string name)
		{
			return 0.0;
		}

		public static T GetRandomByWeight<T>(T[] weightList, Weight<T> weight, string name)
		{
			return (T)null;
		}

		public static T GetRandomByWeight<T>(List<T> weightList, Weight<T> weight, string name)
		{
			return (T)null;
		}

		public static T[] Shuffle<T>(T[] cards)
		{
			return null;
		}

		public static List<T> Shuffle<T>(List<T> cards)
		{
			return null;
		}

		public static bool GetRandomProb(int prob, [Optional] string key)
		{
			return false;
		}

		public static T GetRandomValue<T>(List<T> list)
		{
			return (T)null;
		}

		public static T GetRandomValue<T>(T[] list)
		{
			return (T)null;
		}
	}
}
