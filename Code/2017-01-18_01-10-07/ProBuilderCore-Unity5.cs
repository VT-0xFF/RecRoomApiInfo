using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using ProBuilder2.Common;
using UnityEngine;

[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: CompilationRelaxations(8)]
[assembly: AssemblyVersion("0.0.0.0")]
namespace ProBuilder2.Common
{
	public static class pbUtil
	{
		private struct SearchRange
		{
			public int begin;

			public int end;

			public SearchRange(int begin, int end)
			{
				this.begin = begin;
				this.end = end;
			}

			public bool Valid()
			{
				return end - begin > 1;
			}

			public int Center()
			{
				return begin + (end - begin) / 2;
			}

			public override string ToString()
			{
				return "{" + begin + ", " + end + "} : " + Center();
			}
		}

		public static T[] GetComponents<T>(this GameObject[] _gameObjects) where T : Component
		{
			List<T> list = new List<T>();
			for (int i = 0; i < _gameObjects.Length; i++)
			{
				list.AddRange(_gameObjects[i].transform.GetComponentsInChildren<T>());
			}
			return list.ToArray();
		}

		public static T[] GetComponents<T>(GameObject go) where T : Component
		{
			return new Transform[1] { go.transform }.GetComponents<T>();
		}

		public static T[] GetComponents<T>(this Transform[] _transforms) where T : Component
		{
			List<T> list = new List<T>();
			foreach (Transform transform in _transforms)
			{
				list.AddRange(transform.GetComponentsInChildren<T>());
			}
			return list.ToArray();
		}

		public static Vector3[] ToWorldSpace(this Transform t, Vector3[] v)
		{
			Vector3[] array = new Vector3[v.Length];
			for (int i = 0; i < array.Length; i++)
			{
				ref Vector3 reference = ref array[i];
				reference = t.TransformPoint(v[i]);
			}
			return array;
		}

		public static GameObject EmptyGameObjectWithTransform(Transform t)
		{
			GameObject gameObject = new GameObject();
			gameObject.transform.position = t.position;
			gameObject.transform.localRotation = t.localRotation;
			gameObject.transform.localScale = t.localScale;
			return gameObject;
		}

		public static T[] ValuesWithIndices<T>(this T[] arr, int[] indices)
		{
			T[] array = new T[indices.Length];
			for (int i = 0; i < indices.Length; i++)
			{
				array[i] = arr[indices[i]];
			}
			return array;
		}

		public static List<T> ValuesWithIndices<T>(this IList<T> arr, IList<int> indices)
		{
			List<T> list = new List<T>();
			foreach (int index in indices)
			{
				list.Add(arr[index]);
			}
			return list;
		}

		public static int[] AllIndexesOf<T>(T[] arr, T instance)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < arr.Length; i++)
			{
				ref readonly T reference = ref arr[i];
				object obj = instance;
				if (reference.Equals(obj))
				{
					list.Add(i);
				}
			}
			return list.ToArray();
		}

		public static bool IsEqual<T>(T[] a, T[] b)
		{
			if (a == null && b == null)
			{
				return true;
			}
			if ((a == null && b != null) || (a != null && b == null))
			{
				return false;
			}
			if (a.Length != b.Length)
			{
				return false;
			}
			for (int i = 0; i < a.Length; i++)
			{
				ref readonly T reference = ref a[i];
				object obj = b[i];
				if (!reference.Equals(obj))
				{
					return false;
				}
			}
			return true;
		}

		public static T[] Add<T>(this T[] arr, T val)
		{
			T[] array = new T[arr.Length + 1];
			Array.ConstrainedCopy(arr, 0, array, 0, arr.Length);
			array[arr.Length] = val;
			return array;
		}

		public static T[] AddRange<T>(this T[] arr, T[] val)
		{
			T[] array = new T[arr.Length + val.Length];
			Array.ConstrainedCopy(arr, 0, array, 0, arr.Length);
			Array.ConstrainedCopy(val, 0, array, arr.Length, val.Length);
			return array;
		}

		public static T[] Remove<T>(this T[] arr, T val)
		{
			List<T> list = new List<T>(arr);
			list.Remove(val);
			return list.ToArray();
		}

		public static T[] Remove<T>(this T[] arr, IEnumerable<T> val)
		{
			return arr.Except(val).ToArray();
		}

		public static T[] RemoveAt<T>(this T[] arr, int index)
		{
			T[] array = new T[arr.Length - 1];
			int num = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (i != index)
				{
					array[num] = arr[i];
					num++;
				}
			}
			return array;
		}

		public static T[] RemoveAt<T>(this IList<T> list, IEnumerable<int> indices)
		{
			List<int> list2 = new List<int>(indices);
			list2.Sort();
			return list.SortedRemoveAt(list2);
		}

		public static T[] SortedRemoveAt<T>(this IList<T> list, IList<int> sorted_indices)
		{
			int count = sorted_indices.Count;
			int count2 = list.Count;
			T[] array = new T[count2 - count];
			int i = 0;
			for (int j = 0; j < count2; j++)
			{
				if (i < count && sorted_indices[i] == j)
				{
					for (; i < count && sorted_indices[i] == j; i++)
					{
					}
				}
				else
				{
					array[j - i] = list[j];
				}
			}
			return array;
		}

		public static int NearestIndexPriorToValue<T>(IList<T> sorted_list, T value) where T : IComparable<T>
		{
			int count = sorted_list.Count;
			if (count < 1)
			{
				return -1;
			}
			SearchRange searchRange = new SearchRange(0, count - 1);
			T other = sorted_list[0];
			if (value.CompareTo(other) < 0)
			{
				return -1;
			}
			T other2 = sorted_list[count - 1];
			if (value.CompareTo(other2) > 0)
			{
				return count - 1;
			}
			while (searchRange.Valid())
			{
				if (sorted_list[searchRange.Center()].CompareTo(value) > 0)
				{
					searchRange.end = searchRange.Center();
					continue;
				}
				searchRange.begin = searchRange.Center();
				if (sorted_list[searchRange.begin + 1].CompareTo(value) < 0)
				{
					continue;
				}
				return searchRange.begin;
			}
			return 0;
		}

		public static T[] Fill<T>(T val, int length)
		{
			return FilledArray(val, length);
		}

		public static List<T> Fill<T>(Func<int, T> ctor, int length)
		{
			List<T> list = new List<T>(length);
			for (int i = 0; i < length; i++)
			{
				list.Add(ctor(i));
			}
			return list;
		}

		public static T[] FilledArray<T>(T val, int length)
		{
			T[] array = new T[length];
			for (int i = 0; i < length; i++)
			{
				array[i] = val;
			}
			return array;
		}

		public static bool ContainsMatch<T>(this T[] a, T[] b)
		{
			int num = -1;
			for (int i = 0; i < a.Length; i++)
			{
				num = Array.IndexOf(b, a[i]);
				if (num > -1)
				{
					return true;
				}
			}
			return false;
		}

		public static bool ContainsMatch<T>(this T[] a, T[] b, out int index_a, out int index_b)
		{
			index_b = -1;
			for (index_a = 0; index_a < a.Length; index_a++)
			{
				index_b = Array.IndexOf(b, a[index_a]);
				if (index_b > -1)
				{
					return true;
				}
			}
			return false;
		}

		public static T[] Concat<T>(this T[] x, T[] y)
		{
			if (x == null)
			{
				throw new ArgumentNullException("x");
			}
			if (y == null)
			{
				throw new ArgumentNullException("y");
			}
			int destinationIndex = x.Length;
			Array.Resize(ref x, x.Length + y.Length);
			Array.Copy(y, 0, x, destinationIndex, y.Length);
			return x;
		}

		public static int IndexOf<T>(this List<List<T>> InList, T InValue)
		{
			for (int i = 0; i < InList.Count; i++)
			{
				for (int j = 0; j < InList[i].Count; j++)
				{
					if (InList[i][j].Equals(InValue))
					{
						return i;
					}
				}
			}
			return -1;
		}

		public static T[] Fill<T>(int count, Func<int, T> ctor)
		{
			T[] array = new T[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = ctor(i);
			}
			return array;
		}

		public static void AddOrAppend<T, K>(this Dictionary<T, List<K>> dictionary, T key, K value)
		{
			if (dictionary.TryGetValue(key, out var value2))
			{
				value2.Add(value);
				return;
			}
			dictionary.Add(key, new List<K> { value });
		}

		public static void AddOrAppendRange<T, K>(this Dictionary<T, List<K>> dictionary, T key, List<K> value)
		{
			if (dictionary.TryGetValue(key, out var value2))
			{
				value2.AddRange(value);
			}
			else
			{
				dictionary.Add(key, value);
			}
		}

		public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			HashSet<TKey> knownKeys = new HashSet<TKey>();
			foreach (TSource element in source)
			{
				if (knownKeys.Add(keySelector(element)))
				{
					yield return element;
				}
			}
		}

		public static Vector3 SnapValue(Vector3 vertex, float snpVal)
		{
			return new Vector3(snpVal * Mathf.Round(vertex.x / snpVal), snpVal * Mathf.Round(vertex.y / snpVal), snpVal * Mathf.Round(vertex.z / snpVal));
		}

		public static float SnapValue(float val, float snpVal)
		{
			return snpVal * Mathf.Round(val / snpVal);
		}

		public static Vector3 SnapValue(Vector3 vertex, Vector3 snap)
		{
			float x = vertex.x;
			float y = vertex.y;
			float z = vertex.z;
			Vector3 result = new Vector3((Mathf.Abs(snap.x) < 0.0001f) ? x : (snap.x * Mathf.Round(x / snap.x)), (Mathf.Abs(snap.y) < 0.0001f) ? y : (snap.y * Mathf.Round(y / snap.y)), (Mathf.Abs(snap.z) < 0.0001f) ? z : (snap.z * Mathf.Round(z / snap.z)));
			return result;
		}

		public static T ParseEnum<T>(string value, T defaultValue) where T : struct, IConvertible
		{
			if (!typeof(T).IsEnum)
			{
				throw new ArgumentException("T must be an enumerated type");
			}
			if (string.IsNullOrEmpty(value))
			{
				return defaultValue;
			}
			foreach (T value2 in Enum.GetValues(typeof(T)))
			{
				if (value2.ToString().ToLower().Equals(value.Trim().ToLower()))
				{
					return value2;
				}
			}
			return defaultValue;
		}

		[Obsolete]
		public static string ToFormattedString<T>(this T[] t, string _delimiter)
		{
			return t.ToFormattedString(_delimiter, 0, -1);
		}

		[Obsolete]
		public static string ToFormattedString<T>(this T[] t, string _delimiter, int entriesPerLine, int maxEntries)
		{
			int num = ((maxEntries > 0) ? Mathf.Min(t.Length, maxEntries) : t.Length);
			if (t == null || num < 1)
			{
				return "Empty Array.";
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < num - 1; i++)
			{
				if (entriesPerLine > 0 && (i + 1) % entriesPerLine == 0)
				{
					stringBuilder.AppendLine(((t[i] == null) ? "null" : t[i].ToString()) + _delimiter);
				}
				else
				{
					stringBuilder.Append(((t[i] == null) ? "null" : t[i].ToString()) + _delimiter);
				}
			}
			stringBuilder.Append((t[num - 1] == null) ? "null" : t[num - 1].ToString());
			return stringBuilder.ToString();
		}

		[Obsolete]
		public static string ToFormattedString<T>(this List<T> t, string _delimiter)
		{
			return t.ToArray().ToFormattedString(_delimiter);
		}

		[Obsolete]
		public static string ToFormattedString<T>(this HashSet<T> t, string _delimiter)
		{
			return t.ToArray().ToFormattedString(_delimiter);
		}

		public static string ToString<TKey, TValue>(this Dictionary<TKey, TValue> dict)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (KeyValuePair<TKey, TValue> item in dict)
			{
				stringBuilder.AppendLine($"Key: {item.Key}  Value: {item.Value}");
			}
			return stringBuilder.ToString();
		}

		public static string ToString<T>(this IEnumerable<T> arr, string separator = ", ")
		{
			return string.Join(separator, arr.Select((T x) => x.ToString()).ToArray());
		}

		public static string ControlKeyString(char character)
		{
			return character switch
			{
				'⌘' => "Control", 
				'⇧' => "Shift", 
				'⌥' => "Alt", 
				'⎇' => "Alt", 
				'⌫' => "Delete", 
				_ => character.ToString(), 
			};
		}

		public static bool ColorWithString(string value, out Color col)
		{
			string valid = "01234567890.,";
			value = new string(value.Where((char c) => valid.Contains(c)).ToArray());
			string[] array = value.Split(',');
			if (array.Length < 4)
			{
				col = Color.white;
				return false;
			}
			col = new Color(float.Parse(array[0]), float.Parse(array[1]), float.Parse(array[2]), float.Parse(array[3]));
			return true;
		}

		public static Vector3[] StringToVector3Array(string str)
		{
			List<Vector3> list = new List<Vector3>();
			str = str.Replace(" ", "");
			string[] array = str.Split('\n');
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (!text.Contains("//"))
				{
					string[] array3 = text.Split(',');
					if (array3.Length >= 3 && float.TryParse(array3[0], NumberStyles.Any, CultureInfo.InvariantCulture, out var result) && float.TryParse(array3[1], NumberStyles.Any, CultureInfo.InvariantCulture, out var result2) && float.TryParse(array3[2], NumberStyles.Any, CultureInfo.InvariantCulture, out var result3))
					{
						list.Add(new Vector3(result, result2, result3));
					}
				}
			}
			return list.ToArray();
		}

		public static Vector2 DivideBy(this Vector2 v, Vector2 o)
		{
			return new Vector2(v.x / o.x, v.y / o.y);
		}

		public static Vector3 DivideBy(this Vector3 v, Vector3 o)
		{
			return new Vector3(v.x / o.x, v.y / o.y, v.z / o.z);
		}
	}
	public enum Status
	{
		Success,
		Failure,
		Canceled,
		NoChange
	}
	public class pb_ActionResult
	{
		public Status status;

		public string notification = "";

		public static pb_ActionResult Success => new pb_ActionResult(Status.Success, "");

		public static pb_ActionResult NoSelection => new pb_ActionResult(Status.Canceled, "Nothing Selected");

		public static pb_ActionResult UserCanceled => new pb_ActionResult(Status.Canceled, "User Canceled");

		public pb_ActionResult(Status status, string notification)
		{
			this.status = status;
			this.notification = notification;
		}

		public static implicit operator bool(pb_ActionResult res)
		{
			return res.status == Status.Success;
		}
	}
	public class pb_HsvColor
	{
		public float h;

		public float s;

		public float v;

		public pb_HsvColor(float h, float s, float v)
		{
			this.h = h;
			this.s = s;
			this.v = v;
		}

		public pb_HsvColor(float h, float s, float v, float sv_modifier)
		{
			this.h = h;
			this.s = s * sv_modifier;
			this.v = v * sv_modifier;
		}

		public static pb_HsvColor FromRGB(Color col)
		{
			return pb_ColorUtil.RGBtoHSV(col);
		}

		public override string ToString()
		{
			return $"( {h}, {s}, {v} )";
		}

		public float SqrDistance(pb_HsvColor InColor)
		{
			return InColor.h / 360f - h / 360f + (InColor.s - s) + (InColor.v - v);
		}
	}
	public class pb_XYZ_Color
	{
		public float x;

		public float y;

		public float z;

		public pb_XYZ_Color(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public static pb_XYZ_Color FromRGB(Color col)
		{
			return pb_ColorUtil.RGBToXYZ(col);
		}

		public static pb_XYZ_Color FromRGB(float R, float G, float B)
		{
			return pb_ColorUtil.RGBToXYZ(R, G, B);
		}

		public override string ToString()
		{
			return $"( {x}, {y}, {z} )";
		}
	}
	public class pb_CIE_Lab_Color
	{
		public float L;

		public float a;

		public float b;

		public pb_CIE_Lab_Color(float L, float a, float b)
		{
			this.L = L;
			this.a = a;
			this.b = b;
		}

		public static pb_CIE_Lab_Color FromXYZ(pb_XYZ_Color xyz)
		{
			return pb_ColorUtil.XYZToCIE_Lab(xyz);
		}

		public static pb_CIE_Lab_Color FromRGB(Color col)
		{
			pb_XYZ_Color xyz = pb_XYZ_Color.FromRGB(col);
			return pb_ColorUtil.XYZToCIE_Lab(xyz);
		}

		public override string ToString()
		{
			return $"( {L}, {a}, {b} )";
		}
	}
	public static class pb_ColorUtil
	{
		private static readonly Dictionary<string, pb_CIE_Lab_Color> ColorNameLookup = new Dictionary<string, pb_CIE_Lab_Color>
		{
			{
				"Acid Green",
				CIELabFromRGB(69f, 75f, 10f, 100f)
			},
			{
				"Aero",
				CIELabFromRGB(49f, 73f, 91f, 100f)
			},
			{
				"Aero Blue",
				CIELabFromRGB(79f, 100f, 90f, 100f)
			},
			{
				"African Violet",
				CIELabFromRGB(70f, 52f, 75f, 100f)
			},
			{
				"Air Force Blue (RAF)",
				CIELabFromRGB(36f, 54f, 66f, 100f)
			},
			{
				"Air Force Blue (USAF)",
				CIELabFromRGB(0f, 19f, 56f, 100f)
			},
			{
				"Air Superiority Blue",
				CIELabFromRGB(45f, 63f, 76f, 100f)
			},
			{
				"Alabama Crimson",
				CIELabFromRGB(69f, 0f, 16f, 100f)
			},
			{
				"Alice Blue",
				CIELabFromRGB(94f, 97f, 100f, 100f)
			},
			{
				"Alizarin Crimson",
				CIELabFromRGB(89f, 15f, 21f, 100f)
			},
			{
				"Alloy Orange",
				CIELabFromRGB(77f, 38f, 6f, 100f)
			},
			{
				"Almond",
				CIELabFromRGB(94f, 87f, 80f, 100f)
			},
			{
				"Amaranth",
				CIELabFromRGB(90f, 17f, 31f, 100f)
			},
			{
				"Amaranth Deep Purple",
				CIELabFromRGB(67f, 15f, 31f, 100f)
			},
			{
				"Amaranth Pink",
				CIELabFromRGB(95f, 61f, 73f, 100f)
			},
			{
				"Amaranth Purple",
				CIELabFromRGB(67f, 15f, 31f, 100f)
			},
			{
				"Amaranth Red",
				CIELabFromRGB(83f, 13f, 18f, 100f)
			},
			{
				"Amazon",
				CIELabFromRGB(23f, 48f, 34f, 100f)
			},
			{
				"Amber",
				CIELabFromRGB(100f, 75f, 0f, 100f)
			},
			{
				"Amber (SAE/ECE)",
				CIELabFromRGB(100f, 49f, 0f, 100f)
			},
			{
				"American Rose",
				CIELabFromRGB(100f, 1f, 24f, 100f)
			},
			{
				"Amethyst",
				CIELabFromRGB(60f, 40f, 80f, 100f)
			},
			{
				"Android Green",
				CIELabFromRGB(64f, 78f, 22f, 100f)
			},
			{
				"Anti-Flash White",
				CIELabFromRGB(95f, 95f, 96f, 100f)
			},
			{
				"Antique Brass",
				CIELabFromRGB(80f, 58f, 46f, 100f)
			},
			{
				"Antique Bronze",
				CIELabFromRGB(40f, 36f, 12f, 100f)
			},
			{
				"Antique Fuchsia",
				CIELabFromRGB(57f, 36f, 51f, 100f)
			},
			{
				"Antique Ruby",
				CIELabFromRGB(52f, 11f, 18f, 100f)
			},
			{
				"Antique White",
				CIELabFromRGB(98f, 92f, 84f, 100f)
			},
			{
				"Ao (English)",
				CIELabFromRGB(0f, 50f, 0f, 100f)
			},
			{
				"Apple Green",
				CIELabFromRGB(55f, 71f, 0f, 100f)
			},
			{
				"Apricot",
				CIELabFromRGB(98f, 81f, 69f, 100f)
			},
			{
				"Aqua",
				CIELabFromRGB(0f, 100f, 100f, 100f)
			},
			{
				"Aquamarine",
				CIELabFromRGB(50f, 100f, 83f, 100f)
			},
			{
				"Army Green",
				CIELabFromRGB(29f, 33f, 13f, 100f)
			},
			{
				"Arsenic",
				CIELabFromRGB(23f, 27f, 29f, 100f)
			},
			{
				"Artichoke",
				CIELabFromRGB(56f, 59f, 47f, 100f)
			},
			{
				"Arylide Yellow",
				CIELabFromRGB(91f, 84f, 42f, 100f)
			},
			{
				"Ash Grey",
				CIELabFromRGB(70f, 75f, 71f, 100f)
			},
			{
				"Asparagus",
				CIELabFromRGB(53f, 66f, 42f, 100f)
			},
			{
				"Atomic Tangerine",
				CIELabFromRGB(100f, 60f, 40f, 100f)
			},
			{
				"Auburn",
				CIELabFromRGB(65f, 16f, 16f, 100f)
			},
			{
				"Aureolin",
				CIELabFromRGB(99f, 93f, 0f, 100f)
			},
			{
				"AuroMetalSaurus",
				CIELabFromRGB(43f, 50f, 50f, 100f)
			},
			{
				"Avocado",
				CIELabFromRGB(34f, 51f, 1f, 100f)
			},
			{
				"Azure",
				CIELabFromRGB(0f, 50f, 100f, 100f)
			},
			{
				"Azure (Web Color)",
				CIELabFromRGB(94f, 100f, 100f, 100f)
			},
			{
				"Azure Mist",
				CIELabFromRGB(94f, 100f, 100f, 100f)
			},
			{
				"Azureish White",
				CIELabFromRGB(86f, 91f, 96f, 100f)
			},
			{
				"Baby Blue",
				CIELabFromRGB(54f, 81f, 94f, 100f)
			},
			{
				"Baby Blue Eyes",
				CIELabFromRGB(63f, 79f, 95f, 100f)
			},
			{
				"Baby Pink",
				CIELabFromRGB(96f, 76f, 76f, 100f)
			},
			{
				"Baby Powder",
				CIELabFromRGB(100f, 100f, 98f, 100f)
			},
			{
				"Baker-Miller Pink",
				CIELabFromRGB(100f, 57f, 69f, 100f)
			},
			{
				"Ball Blue",
				CIELabFromRGB(13f, 67f, 80f, 100f)
			},
			{
				"Banana Mania",
				CIELabFromRGB(98f, 91f, 71f, 100f)
			},
			{
				"Banana Yellow",
				CIELabFromRGB(100f, 88f, 21f, 100f)
			},
			{
				"Bangladesh Green",
				CIELabFromRGB(0f, 42f, 31f, 100f)
			},
			{
				"Barbie Pink",
				CIELabFromRGB(88f, 13f, 54f, 100f)
			},
			{
				"Barn Red",
				CIELabFromRGB(49f, 4f, 1f, 100f)
			},
			{
				"Battleship Grey",
				CIELabFromRGB(52f, 52f, 51f, 100f)
			},
			{
				"Bazaar",
				CIELabFromRGB(60f, 47f, 48f, 100f)
			},
			{
				"Beau Blue",
				CIELabFromRGB(74f, 83f, 90f, 100f)
			},
			{
				"Beaver",
				CIELabFromRGB(62f, 51f, 44f, 100f)
			},
			{
				"Beige",
				CIELabFromRGB(96f, 96f, 86f, 100f)
			},
			{
				"B'dazzled Blue",
				CIELabFromRGB(18f, 35f, 58f, 100f)
			},
			{
				"Big Dip O’ruby",
				CIELabFromRGB(61f, 15f, 26f, 100f)
			},
			{
				"Bisque",
				CIELabFromRGB(100f, 89f, 77f, 100f)
			},
			{
				"Bistre",
				CIELabFromRGB(24f, 17f, 12f, 100f)
			},
			{
				"Bistre Brown",
				CIELabFromRGB(59f, 44f, 9f, 100f)
			},
			{
				"Bitter Lemon",
				CIELabFromRGB(79f, 88f, 5f, 100f)
			},
			{
				"Bitter Lime",
				CIELabFromRGB(75f, 100f, 0f, 100f)
			},
			{
				"Bittersweet",
				CIELabFromRGB(100f, 44f, 37f, 100f)
			},
			{
				"Bittersweet Shimmer",
				CIELabFromRGB(75f, 31f, 32f, 100f)
			},
			{
				"Black",
				CIELabFromRGB(0f, 0f, 0f, 100f)
			},
			{
				"Black Bean",
				CIELabFromRGB(24f, 5f, 1f, 100f)
			},
			{
				"Black Leather Jacket",
				CIELabFromRGB(15f, 21f, 16f, 100f)
			},
			{
				"Black Olive",
				CIELabFromRGB(23f, 24f, 21f, 100f)
			},
			{
				"Blanched Almond",
				CIELabFromRGB(100f, 92f, 80f, 100f)
			},
			{
				"Blast-Off Bronze",
				CIELabFromRGB(65f, 44f, 39f, 100f)
			},
			{
				"Bleu De France",
				CIELabFromRGB(19f, 55f, 91f, 100f)
			},
			{
				"Blizzard Blue",
				CIELabFromRGB(67f, 90f, 93f, 100f)
			},
			{
				"Blond",
				CIELabFromRGB(98f, 94f, 75f, 100f)
			},
			{
				"Blue",
				CIELabFromRGB(0f, 0f, 100f, 100f)
			},
			{
				"Blue (Crayola)",
				CIELabFromRGB(12f, 46f, 100f, 100f)
			},
			{
				"Blue (Munsell)",
				CIELabFromRGB(0f, 58f, 69f, 100f)
			},
			{
				"Blue (NCS)",
				CIELabFromRGB(0f, 53f, 74f, 100f)
			},
			{
				"Blue (Pantone)",
				CIELabFromRGB(0f, 9f, 66f, 100f)
			},
			{
				"Blue (Pigment)",
				CIELabFromRGB(20f, 20f, 60f, 100f)
			},
			{
				"Blue (RYB)",
				CIELabFromRGB(1f, 28f, 100f, 100f)
			},
			{
				"Blue Bell",
				CIELabFromRGB(64f, 64f, 82f, 100f)
			},
			{
				"Blue-Gray",
				CIELabFromRGB(40f, 60f, 80f, 100f)
			},
			{
				"Blue-Green",
				CIELabFromRGB(5f, 60f, 73f, 100f)
			},
			{
				"Blue Lagoon",
				CIELabFromRGB(37f, 58f, 63f, 100f)
			},
			{
				"Blue-Magenta Violet",
				CIELabFromRGB(33f, 21f, 57f, 100f)
			},
			{
				"Blue Sapphire",
				CIELabFromRGB(7f, 38f, 50f, 100f)
			},
			{
				"Blue-Violet",
				CIELabFromRGB(54f, 17f, 89f, 100f)
			},
			{
				"Blue Yonder",
				CIELabFromRGB(31f, 45f, 65f, 100f)
			},
			{
				"Blueberry",
				CIELabFromRGB(31f, 53f, 97f, 100f)
			},
			{
				"Bluebonnet",
				CIELabFromRGB(11f, 11f, 94f, 100f)
			},
			{
				"Blush",
				CIELabFromRGB(87f, 36f, 51f, 100f)
			},
			{
				"Bole",
				CIELabFromRGB(47f, 27f, 23f, 100f)
			},
			{
				"Bondi Blue",
				CIELabFromRGB(0f, 58f, 71f, 100f)
			},
			{
				"Bone",
				CIELabFromRGB(89f, 85f, 79f, 100f)
			},
			{
				"Boston University Red",
				CIELabFromRGB(80f, 0f, 0f, 100f)
			},
			{
				"Bottle Green",
				CIELabFromRGB(0f, 42f, 31f, 100f)
			},
			{
				"Boysenberry",
				CIELabFromRGB(53f, 20f, 38f, 100f)
			},
			{
				"Brandeis Blue",
				CIELabFromRGB(0f, 44f, 100f, 100f)
			},
			{
				"Brass",
				CIELabFromRGB(71f, 65f, 26f, 100f)
			},
			{
				"Brick Red",
				CIELabFromRGB(80f, 25f, 33f, 100f)
			},
			{
				"Bright Cerulean",
				CIELabFromRGB(11f, 67f, 84f, 100f)
			},
			{
				"Bright Green",
				CIELabFromRGB(40f, 100f, 0f, 100f)
			},
			{
				"Bright Lavender",
				CIELabFromRGB(75f, 58f, 89f, 100f)
			},
			{
				"Bright Lilac",
				CIELabFromRGB(85f, 57f, 94f, 100f)
			},
			{
				"Bright Maroon",
				CIELabFromRGB(76f, 13f, 28f, 100f)
			},
			{
				"Bright Navy Blue",
				CIELabFromRGB(10f, 45f, 82f, 100f)
			},
			{
				"Bright Pink",
				CIELabFromRGB(100f, 0f, 50f, 100f)
			},
			{
				"Bright Turquoise",
				CIELabFromRGB(3f, 91f, 87f, 100f)
			},
			{
				"Bright Ube",
				CIELabFromRGB(82f, 62f, 91f, 100f)
			},
			{
				"Brilliant Azure",
				CIELabFromRGB(20f, 60f, 100f, 100f)
			},
			{
				"Brilliant Lavender",
				CIELabFromRGB(96f, 73f, 100f, 100f)
			},
			{
				"Brilliant Rose",
				CIELabFromRGB(100f, 33f, 64f, 100f)
			},
			{
				"Brink Pink",
				CIELabFromRGB(98f, 38f, 50f, 100f)
			},
			{
				"British Racing Green",
				CIELabFromRGB(0f, 26f, 15f, 100f)
			},
			{
				"Bronze",
				CIELabFromRGB(80f, 50f, 20f, 100f)
			},
			{
				"Bronze Yellow",
				CIELabFromRGB(45f, 44f, 0f, 100f)
			},
			{
				"Brown (Traditional)",
				CIELabFromRGB(59f, 29f, 0f, 100f)
			},
			{
				"Brown (Web)",
				CIELabFromRGB(65f, 16f, 16f, 100f)
			},
			{
				"Brown-Nose",
				CIELabFromRGB(42f, 27f, 14f, 100f)
			},
			{
				"Brown Yellow",
				CIELabFromRGB(80f, 60f, 40f, 100f)
			},
			{
				"Brunswick Green",
				CIELabFromRGB(11f, 30f, 24f, 100f)
			},
			{
				"Bubble Gum",
				CIELabFromRGB(100f, 76f, 80f, 100f)
			},
			{
				"Bubbles",
				CIELabFromRGB(91f, 100f, 100f, 100f)
			},
			{
				"Buff",
				CIELabFromRGB(94f, 86f, 51f, 100f)
			},
			{
				"Bud Green",
				CIELabFromRGB(48f, 71f, 38f, 100f)
			},
			{
				"Bulgarian Rose",
				CIELabFromRGB(28f, 2f, 3f, 100f)
			},
			{
				"Burgundy",
				CIELabFromRGB(50f, 0f, 13f, 100f)
			},
			{
				"Burlywood",
				CIELabFromRGB(87f, 72f, 53f, 100f)
			},
			{
				"Burnt Orange",
				CIELabFromRGB(80f, 33f, 0f, 100f)
			},
			{
				"Burnt Sienna",
				CIELabFromRGB(91f, 45f, 32f, 100f)
			},
			{
				"Burnt Umber",
				CIELabFromRGB(54f, 20f, 14f, 100f)
			},
			{
				"Byzantine",
				CIELabFromRGB(74f, 20f, 64f, 100f)
			},
			{
				"Byzantium",
				CIELabFromRGB(44f, 16f, 39f, 100f)
			},
			{
				"Cadet",
				CIELabFromRGB(33f, 41f, 45f, 100f)
			},
			{
				"Cadet Blue",
				CIELabFromRGB(37f, 62f, 63f, 100f)
			},
			{
				"Cadet Grey",
				CIELabFromRGB(57f, 64f, 69f, 100f)
			},
			{
				"Cadmium Green",
				CIELabFromRGB(0f, 42f, 24f, 100f)
			},
			{
				"Cadmium Orange",
				CIELabFromRGB(93f, 53f, 18f, 100f)
			},
			{
				"Cadmium Red",
				CIELabFromRGB(89f, 0f, 13f, 100f)
			},
			{
				"Cadmium Yellow",
				CIELabFromRGB(100f, 96f, 0f, 100f)
			},
			{
				"Cafe Au Lait",
				CIELabFromRGB(65f, 48f, 36f, 100f)
			},
			{
				"Cafe Noir",
				CIELabFromRGB(29f, 21f, 13f, 100f)
			},
			{
				"Cal Poly Green",
				CIELabFromRGB(12f, 30f, 17f, 100f)
			},
			{
				"Cambridge Blue",
				CIELabFromRGB(64f, 76f, 68f, 100f)
			},
			{
				"Camel",
				CIELabFromRGB(76f, 60f, 42f, 100f)
			},
			{
				"Cameo Pink",
				CIELabFromRGB(94f, 73f, 80f, 100f)
			},
			{
				"Camouflage Green",
				CIELabFromRGB(47f, 53f, 42f, 100f)
			},
			{
				"Canary Yellow",
				CIELabFromRGB(100f, 94f, 0f, 100f)
			},
			{
				"Candy Apple Red",
				CIELabFromRGB(100f, 3f, 0f, 100f)
			},
			{
				"Candy Pink",
				CIELabFromRGB(89f, 44f, 48f, 100f)
			},
			{
				"Capri",
				CIELabFromRGB(0f, 75f, 100f, 100f)
			},
			{
				"Caput Mortuum",
				CIELabFromRGB(35f, 15f, 13f, 100f)
			},
			{
				"Cardinal",
				CIELabFromRGB(77f, 12f, 23f, 100f)
			},
			{
				"Caribbean Green",
				CIELabFromRGB(0f, 80f, 60f, 100f)
			},
			{
				"Carmine",
				CIELabFromRGB(59f, 0f, 9f, 100f)
			},
			{
				"Carmine (M&P)",
				CIELabFromRGB(84f, 0f, 25f, 100f)
			},
			{
				"Carmine Pink",
				CIELabFromRGB(92f, 30f, 26f, 100f)
			},
			{
				"Carmine Red",
				CIELabFromRGB(100f, 0f, 22f, 100f)
			},
			{
				"Carnation Pink",
				CIELabFromRGB(100f, 65f, 79f, 100f)
			},
			{
				"Carnelian",
				CIELabFromRGB(70f, 11f, 11f, 100f)
			},
			{
				"Carolina Blue",
				CIELabFromRGB(34f, 63f, 83f, 100f)
			},
			{
				"Carrot Orange",
				CIELabFromRGB(93f, 57f, 13f, 100f)
			},
			{
				"Castleton Green",
				CIELabFromRGB(0f, 34f, 25f, 100f)
			},
			{
				"Catalina Blue",
				CIELabFromRGB(2f, 16f, 47f, 100f)
			},
			{
				"Catawba",
				CIELabFromRGB(44f, 21f, 26f, 100f)
			},
			{
				"Cedar Chest",
				CIELabFromRGB(79f, 35f, 29f, 100f)
			},
			{
				"Ceil",
				CIELabFromRGB(57f, 63f, 81f, 100f)
			},
			{
				"Celadon",
				CIELabFromRGB(67f, 88f, 69f, 100f)
			},
			{
				"Celadon Blue",
				CIELabFromRGB(0f, 48f, 65f, 100f)
			},
			{
				"Celadon Green",
				CIELabFromRGB(18f, 52f, 49f, 100f)
			},
			{
				"Celeste",
				CIELabFromRGB(70f, 100f, 100f, 100f)
			},
			{
				"Celestial Blue",
				CIELabFromRGB(29f, 59f, 82f, 100f)
			},
			{
				"Cerise",
				CIELabFromRGB(87f, 19f, 39f, 100f)
			},
			{
				"Cerise Pink",
				CIELabFromRGB(93f, 23f, 51f, 100f)
			},
			{
				"Cerulean",
				CIELabFromRGB(0f, 48f, 65f, 100f)
			},
			{
				"Cerulean Blue",
				CIELabFromRGB(16f, 32f, 75f, 100f)
			},
			{
				"Cerulean Frost",
				CIELabFromRGB(43f, 61f, 76f, 100f)
			},
			{
				"CG Blue",
				CIELabFromRGB(0f, 48f, 65f, 100f)
			},
			{
				"CG Red",
				CIELabFromRGB(88f, 24f, 19f, 100f)
			},
			{
				"Chamoisee",
				CIELabFromRGB(63f, 47f, 35f, 100f)
			},
			{
				"Champagne",
				CIELabFromRGB(97f, 91f, 81f, 100f)
			},
			{
				"Charcoal",
				CIELabFromRGB(21f, 27f, 31f, 100f)
			},
			{
				"Charleston Green",
				CIELabFromRGB(14f, 17f, 17f, 100f)
			},
			{
				"Charm Pink",
				CIELabFromRGB(90f, 56f, 67f, 100f)
			},
			{
				"Chartreuse (Traditional)",
				CIELabFromRGB(87f, 100f, 0f, 100f)
			},
			{
				"Chartreuse (Web)",
				CIELabFromRGB(50f, 100f, 0f, 100f)
			},
			{
				"Cherry",
				CIELabFromRGB(87f, 19f, 39f, 100f)
			},
			{
				"Cherry Blossom Pink",
				CIELabFromRGB(100f, 72f, 77f, 100f)
			},
			{
				"Chestnut",
				CIELabFromRGB(58f, 27f, 21f, 100f)
			},
			{
				"China Pink",
				CIELabFromRGB(87f, 44f, 63f, 100f)
			},
			{
				"China Rose",
				CIELabFromRGB(66f, 32f, 43f, 100f)
			},
			{
				"Chinese Red",
				CIELabFromRGB(67f, 22f, 12f, 100f)
			},
			{
				"Chinese Violet",
				CIELabFromRGB(52f, 38f, 53f, 100f)
			},
			{
				"Chocolate (Traditional)",
				CIELabFromRGB(48f, 25f, 0f, 100f)
			},
			{
				"Chocolate (Web)",
				CIELabFromRGB(82f, 41f, 12f, 100f)
			},
			{
				"Chrome Yellow",
				CIELabFromRGB(100f, 65f, 0f, 100f)
			},
			{
				"Cinereous",
				CIELabFromRGB(60f, 51f, 48f, 100f)
			},
			{
				"Cinnabar",
				CIELabFromRGB(89f, 26f, 20f, 100f)
			},
			{
				"Cinnamon",
				CIELabFromRGB(82f, 41f, 12f, 100f)
			},
			{
				"Citrine",
				CIELabFromRGB(89f, 82f, 4f, 100f)
			},
			{
				"Citron",
				CIELabFromRGB(62f, 66f, 12f, 100f)
			},
			{
				"Claret",
				CIELabFromRGB(50f, 9f, 20f, 100f)
			},
			{
				"Classic Rose",
				CIELabFromRGB(98f, 80f, 91f, 100f)
			},
			{
				"Cobalt Blue",
				CIELabFromRGB(0f, 28f, 67f, 100f)
			},
			{
				"Cocoa Brown",
				CIELabFromRGB(82f, 41f, 12f, 100f)
			},
			{
				"Coconut",
				CIELabFromRGB(59f, 35f, 24f, 100f)
			},
			{
				"Coffee",
				CIELabFromRGB(44f, 31f, 22f, 100f)
			},
			{
				"Columbia Blue",
				CIELabFromRGB(77f, 85f, 89f, 100f)
			},
			{
				"Congo Pink",
				CIELabFromRGB(97f, 51f, 47f, 100f)
			},
			{
				"Cool Black",
				CIELabFromRGB(0f, 18f, 39f, 100f)
			},
			{
				"Cool Grey",
				CIELabFromRGB(55f, 57f, 67f, 100f)
			},
			{
				"Copper",
				CIELabFromRGB(72f, 45f, 20f, 100f)
			},
			{
				"Copper (Crayola)",
				CIELabFromRGB(85f, 54f, 40f, 100f)
			},
			{
				"Copper Penny",
				CIELabFromRGB(68f, 44f, 41f, 100f)
			},
			{
				"Copper Red",
				CIELabFromRGB(80f, 43f, 32f, 100f)
			},
			{
				"Copper Rose",
				CIELabFromRGB(60f, 40f, 40f, 100f)
			},
			{
				"Coquelicot",
				CIELabFromRGB(100f, 22f, 0f, 100f)
			},
			{
				"Coral",
				CIELabFromRGB(100f, 50f, 31f, 100f)
			},
			{
				"Coral Pink",
				CIELabFromRGB(97f, 51f, 47f, 100f)
			},
			{
				"Coral Red",
				CIELabFromRGB(100f, 25f, 25f, 100f)
			},
			{
				"Cordovan",
				CIELabFromRGB(54f, 25f, 27f, 100f)
			},
			{
				"Corn",
				CIELabFromRGB(98f, 93f, 36f, 100f)
			},
			{
				"Cornell Red",
				CIELabFromRGB(70f, 11f, 11f, 100f)
			},
			{
				"Cornflower Blue",
				CIELabFromRGB(39f, 58f, 93f, 100f)
			},
			{
				"Cornsilk",
				CIELabFromRGB(100f, 97f, 86f, 100f)
			},
			{
				"Cosmic Latte",
				CIELabFromRGB(100f, 97f, 91f, 100f)
			},
			{
				"Coyote Brown",
				CIELabFromRGB(51f, 38f, 24f, 100f)
			},
			{
				"Cotton Candy",
				CIELabFromRGB(100f, 74f, 85f, 100f)
			},
			{
				"Cream",
				CIELabFromRGB(100f, 99f, 82f, 100f)
			},
			{
				"Crimson",
				CIELabFromRGB(86f, 8f, 24f, 100f)
			},
			{
				"Crimson Glory",
				CIELabFromRGB(75f, 0f, 20f, 100f)
			},
			{
				"Crimson Red",
				CIELabFromRGB(60f, 0f, 0f, 100f)
			},
			{
				"Cyan",
				CIELabFromRGB(0f, 100f, 100f, 100f)
			},
			{
				"Cyan Azure",
				CIELabFromRGB(31f, 51f, 71f, 100f)
			},
			{
				"Cyan-Blue Azure",
				CIELabFromRGB(27f, 51f, 75f, 100f)
			},
			{
				"Cyan Cobalt Blue",
				CIELabFromRGB(16f, 35f, 61f, 100f)
			},
			{
				"Cyan Cornflower Blue",
				CIELabFromRGB(9f, 55f, 76f, 100f)
			},
			{
				"Cyan (Process)",
				CIELabFromRGB(0f, 72f, 92f, 100f)
			},
			{
				"Cyber Grape",
				CIELabFromRGB(35f, 26f, 49f, 100f)
			},
			{
				"Cyber Yellow",
				CIELabFromRGB(100f, 83f, 0f, 100f)
			},
			{
				"Daffodil",
				CIELabFromRGB(100f, 100f, 19f, 100f)
			},
			{
				"Dandelion",
				CIELabFromRGB(94f, 88f, 19f, 100f)
			},
			{
				"Dark Blue",
				CIELabFromRGB(0f, 0f, 55f, 100f)
			},
			{
				"Dark Blue-Gray",
				CIELabFromRGB(40f, 40f, 60f, 100f)
			},
			{
				"Dark Brown",
				CIELabFromRGB(40f, 26f, 13f, 100f)
			},
			{
				"Dark Brown-Tangelo",
				CIELabFromRGB(53f, 40f, 31f, 100f)
			},
			{
				"Dark Byzantium",
				CIELabFromRGB(36f, 22f, 33f, 100f)
			},
			{
				"Dark Candy Apple Red",
				CIELabFromRGB(64f, 0f, 0f, 100f)
			},
			{
				"Dark Cerulean",
				CIELabFromRGB(3f, 27f, 49f, 100f)
			},
			{
				"Dark Chestnut",
				CIELabFromRGB(60f, 41f, 38f, 100f)
			},
			{
				"Dark Coral",
				CIELabFromRGB(80f, 36f, 27f, 100f)
			},
			{
				"Dark Cyan",
				CIELabFromRGB(0f, 55f, 55f, 100f)
			},
			{
				"Dark Electric Blue",
				CIELabFromRGB(33f, 41f, 47f, 100f)
			},
			{
				"Dark Goldenrod",
				CIELabFromRGB(72f, 53f, 4f, 100f)
			},
			{
				"Dark Gray (X11)",
				CIELabFromRGB(66f, 66f, 66f, 100f)
			},
			{
				"Dark Green",
				CIELabFromRGB(0f, 20f, 13f, 100f)
			},
			{
				"Dark Green (X11)",
				CIELabFromRGB(0f, 39f, 0f, 100f)
			},
			{
				"Dark Imperial Blue",
				CIELabFromRGB(0f, 25f, 42f, 100f)
			},
			{
				"Dark Imperial-er Blue",
				CIELabFromRGB(0f, 8f, 49f, 100f)
			},
			{
				"Dark Jungle Green",
				CIELabFromRGB(10f, 14f, 13f, 100f)
			},
			{
				"Dark Khaki",
				CIELabFromRGB(74f, 72f, 42f, 100f)
			},
			{
				"Dark Lava",
				CIELabFromRGB(28f, 24f, 20f, 100f)
			},
			{
				"Dark Lavender",
				CIELabFromRGB(45f, 31f, 59f, 100f)
			},
			{
				"Dark Liver",
				CIELabFromRGB(33f, 29f, 31f, 100f)
			},
			{
				"Dark Liver (Horses)",
				CIELabFromRGB(33f, 24f, 22f, 100f)
			},
			{
				"Dark Magenta",
				CIELabFromRGB(55f, 0f, 55f, 100f)
			},
			{
				"Dark Medium Gray",
				CIELabFromRGB(66f, 66f, 66f, 100f)
			},
			{
				"Dark Midnight Blue",
				CIELabFromRGB(0f, 20f, 40f, 100f)
			},
			{
				"Dark Moss Green",
				CIELabFromRGB(29f, 36f, 14f, 100f)
			},
			{
				"Dark Olive Green",
				CIELabFromRGB(33f, 42f, 18f, 100f)
			},
			{
				"Dark Orange",
				CIELabFromRGB(100f, 55f, 0f, 100f)
			},
			{
				"Dark Orchid",
				CIELabFromRGB(60f, 20f, 80f, 100f)
			},
			{
				"Dark Pastel Blue",
				CIELabFromRGB(47f, 62f, 80f, 100f)
			},
			{
				"Dark Pastel Green",
				CIELabFromRGB(1f, 75f, 24f, 100f)
			},
			{
				"Dark Pastel Purple",
				CIELabFromRGB(59f, 44f, 84f, 100f)
			},
			{
				"Dark Pastel Red",
				CIELabFromRGB(76f, 23f, 13f, 100f)
			},
			{
				"Dark Pink",
				CIELabFromRGB(91f, 33f, 50f, 100f)
			},
			{
				"Dark Powder Blue",
				CIELabFromRGB(0f, 20f, 60f, 100f)
			},
			{
				"Dark Puce",
				CIELabFromRGB(31f, 23f, 24f, 100f)
			},
			{
				"Dark Purple",
				CIELabFromRGB(19f, 10f, 20f, 100f)
			},
			{
				"Dark Raspberry",
				CIELabFromRGB(53f, 15f, 34f, 100f)
			},
			{
				"Dark Red",
				CIELabFromRGB(55f, 0f, 0f, 100f)
			},
			{
				"Dark Salmon",
				CIELabFromRGB(91f, 59f, 48f, 100f)
			},
			{
				"Dark Scarlet",
				CIELabFromRGB(34f, 1f, 10f, 100f)
			},
			{
				"Dark Sea Green",
				CIELabFromRGB(56f, 74f, 56f, 100f)
			},
			{
				"Dark Sienna",
				CIELabFromRGB(24f, 8f, 8f, 100f)
			},
			{
				"Dark Sky Blue",
				CIELabFromRGB(55f, 75f, 84f, 100f)
			},
			{
				"Dark Slate Blue",
				CIELabFromRGB(28f, 24f, 55f, 100f)
			},
			{
				"Dark Slate Gray",
				CIELabFromRGB(18f, 31f, 31f, 100f)
			},
			{
				"Dark Spring Green",
				CIELabFromRGB(9f, 45f, 27f, 100f)
			},
			{
				"Dark Tan",
				CIELabFromRGB(57f, 51f, 32f, 100f)
			},
			{
				"Dark Tangerine",
				CIELabFromRGB(100f, 66f, 7f, 100f)
			},
			{
				"Dark Taupe",
				CIELabFromRGB(28f, 24f, 20f, 100f)
			},
			{
				"Dark Terra Cotta",
				CIELabFromRGB(80f, 31f, 36f, 100f)
			},
			{
				"Dark Turquoise",
				CIELabFromRGB(0f, 81f, 82f, 100f)
			},
			{
				"Dark Vanilla",
				CIELabFromRGB(82f, 75f, 66f, 100f)
			},
			{
				"Dark Violet",
				CIELabFromRGB(58f, 0f, 83f, 100f)
			},
			{
				"Dark Yellow",
				CIELabFromRGB(61f, 53f, 5f, 100f)
			},
			{
				"Dartmouth Green",
				CIELabFromRGB(0f, 44f, 24f, 100f)
			},
			{
				"Davy's Grey",
				CIELabFromRGB(33f, 33f, 33f, 100f)
			},
			{
				"Debian Red",
				CIELabFromRGB(84f, 4f, 33f, 100f)
			},
			{
				"Deep Aquamarine",
				CIELabFromRGB(25f, 51f, 43f, 100f)
			},
			{
				"Deep Carmine",
				CIELabFromRGB(66f, 13f, 24f, 100f)
			},
			{
				"Deep Carmine Pink",
				CIELabFromRGB(94f, 19f, 22f, 100f)
			},
			{
				"Deep Carrot Orange",
				CIELabFromRGB(91f, 41f, 17f, 100f)
			},
			{
				"Deep Cerise",
				CIELabFromRGB(85f, 20f, 53f, 100f)
			},
			{
				"Deep Champagne",
				CIELabFromRGB(98f, 84f, 65f, 100f)
			},
			{
				"Deep Chestnut",
				CIELabFromRGB(73f, 31f, 28f, 100f)
			},
			{
				"Deep Coffee",
				CIELabFromRGB(44f, 26f, 25f, 100f)
			},
			{
				"Deep Fuchsia",
				CIELabFromRGB(76f, 33f, 76f, 100f)
			},
			{
				"Deep Green",
				CIELabFromRGB(2f, 40f, 3f, 100f)
			},
			{
				"Deep Green-Cyan Turquoise",
				CIELabFromRGB(5f, 49f, 38f, 100f)
			},
			{
				"Deep Jungle Green",
				CIELabFromRGB(0f, 29f, 29f, 100f)
			},
			{
				"Deep Koamaru",
				CIELabFromRGB(20f, 20f, 40f, 100f)
			},
			{
				"Deep Lemon",
				CIELabFromRGB(96f, 78f, 10f, 100f)
			},
			{
				"Deep Lilac",
				CIELabFromRGB(60f, 33f, 73f, 100f)
			},
			{
				"Deep Magenta",
				CIELabFromRGB(80f, 0f, 80f, 100f)
			},
			{
				"Deep Maroon",
				CIELabFromRGB(51f, 0f, 0f, 100f)
			},
			{
				"Deep Mauve",
				CIELabFromRGB(83f, 45f, 83f, 100f)
			},
			{
				"Deep Moss Green",
				CIELabFromRGB(21f, 37f, 23f, 100f)
			},
			{
				"Deep Peach",
				CIELabFromRGB(100f, 80f, 64f, 100f)
			},
			{
				"Deep Pink",
				CIELabFromRGB(100f, 8f, 58f, 100f)
			},
			{
				"Deep Puce",
				CIELabFromRGB(66f, 36f, 41f, 100f)
			},
			{
				"Deep Red",
				CIELabFromRGB(52f, 0f, 0f, 100f)
			},
			{
				"Deep Ruby",
				CIELabFromRGB(52f, 25f, 36f, 100f)
			},
			{
				"Deep Saffron",
				CIELabFromRGB(100f, 60f, 20f, 100f)
			},
			{
				"Deep Sky Blue",
				CIELabFromRGB(0f, 75f, 100f, 100f)
			},
			{
				"Deep Space Sparkle",
				CIELabFromRGB(29f, 39f, 42f, 100f)
			},
			{
				"Deep Spring Bud",
				CIELabFromRGB(33f, 42f, 18f, 100f)
			},
			{
				"Deep Taupe",
				CIELabFromRGB(49f, 37f, 38f, 100f)
			},
			{
				"Deep Tuscan Red",
				CIELabFromRGB(40f, 26f, 30f, 100f)
			},
			{
				"Deep Violet",
				CIELabFromRGB(20f, 0f, 40f, 100f)
			},
			{
				"Deer",
				CIELabFromRGB(73f, 53f, 35f, 100f)
			},
			{
				"Denim",
				CIELabFromRGB(8f, 38f, 74f, 100f)
			},
			{
				"Desaturated Cyan",
				CIELabFromRGB(40f, 60f, 60f, 100f)
			},
			{
				"Desert",
				CIELabFromRGB(76f, 60f, 42f, 100f)
			},
			{
				"Desert Sand",
				CIELabFromRGB(93f, 79f, 69f, 100f)
			},
			{
				"Desire",
				CIELabFromRGB(92f, 24f, 33f, 100f)
			},
			{
				"Diamond",
				CIELabFromRGB(73f, 95f, 100f, 100f)
			},
			{
				"Dim Gray",
				CIELabFromRGB(41f, 41f, 41f, 100f)
			},
			{
				"Dirt",
				CIELabFromRGB(61f, 46f, 33f, 100f)
			},
			{
				"Dodger Blue",
				CIELabFromRGB(12f, 56f, 100f, 100f)
			},
			{
				"Dogwood Rose",
				CIELabFromRGB(84f, 9f, 41f, 100f)
			},
			{
				"Dollar Bill",
				CIELabFromRGB(52f, 73f, 40f, 100f)
			},
			{
				"Donkey Brown",
				CIELabFromRGB(40f, 30f, 16f, 100f)
			},
			{
				"Drab",
				CIELabFromRGB(59f, 44f, 9f, 100f)
			},
			{
				"Duke Blue",
				CIELabFromRGB(0f, 0f, 61f, 100f)
			},
			{
				"Dust Storm",
				CIELabFromRGB(90f, 80f, 79f, 100f)
			},
			{
				"Dutch White",
				CIELabFromRGB(94f, 87f, 73f, 100f)
			},
			{
				"Earth Yellow",
				CIELabFromRGB(88f, 66f, 37f, 100f)
			},
			{
				"Ebony",
				CIELabFromRGB(33f, 36f, 31f, 100f)
			},
			{
				"Ecru",
				CIELabFromRGB(76f, 70f, 50f, 100f)
			},
			{
				"Eerie Black",
				CIELabFromRGB(11f, 11f, 11f, 100f)
			},
			{
				"Eggplant",
				CIELabFromRGB(38f, 25f, 32f, 100f)
			},
			{
				"Eggshell",
				CIELabFromRGB(94f, 92f, 84f, 100f)
			},
			{
				"Egyptian Blue",
				CIELabFromRGB(6f, 20f, 65f, 100f)
			},
			{
				"Electric Blue",
				CIELabFromRGB(49f, 98f, 100f, 100f)
			},
			{
				"Electric Crimson",
				CIELabFromRGB(100f, 0f, 25f, 100f)
			},
			{
				"Electric Cyan",
				CIELabFromRGB(0f, 100f, 100f, 100f)
			},
			{
				"Electric Green",
				CIELabFromRGB(0f, 100f, 0f, 100f)
			},
			{
				"Electric Indigo",
				CIELabFromRGB(44f, 0f, 100f, 100f)
			},
			{
				"Electric Lavender",
				CIELabFromRGB(96f, 73f, 100f, 100f)
			},
			{
				"Electric Lime",
				CIELabFromRGB(80f, 100f, 0f, 100f)
			},
			{
				"Electric Purple",
				CIELabFromRGB(75f, 0f, 100f, 100f)
			},
			{
				"Electric Ultramarine",
				CIELabFromRGB(25f, 0f, 100f, 100f)
			},
			{
				"Electric Violet",
				CIELabFromRGB(56f, 0f, 100f, 100f)
			},
			{
				"Electric Yellow",
				CIELabFromRGB(100f, 100f, 20f, 100f)
			},
			{
				"Emerald",
				CIELabFromRGB(31f, 78f, 47f, 100f)
			},
			{
				"Eminence",
				CIELabFromRGB(42f, 19f, 51f, 100f)
			},
			{
				"English Green",
				CIELabFromRGB(11f, 30f, 24f, 100f)
			},
			{
				"English Lavender",
				CIELabFromRGB(71f, 51f, 58f, 100f)
			},
			{
				"English Red",
				CIELabFromRGB(67f, 29f, 32f, 100f)
			},
			{
				"English Violet",
				CIELabFromRGB(34f, 24f, 36f, 100f)
			},
			{
				"Eton Blue",
				CIELabFromRGB(59f, 78f, 64f, 100f)
			},
			{
				"Eucalyptus",
				CIELabFromRGB(27f, 84f, 66f, 100f)
			},
			{
				"Fallow",
				CIELabFromRGB(76f, 60f, 42f, 100f)
			},
			{
				"Falu Red",
				CIELabFromRGB(50f, 9f, 9f, 100f)
			},
			{
				"Fandango",
				CIELabFromRGB(71f, 20f, 54f, 100f)
			},
			{
				"Fandango Pink",
				CIELabFromRGB(87f, 32f, 52f, 100f)
			},
			{
				"Fashion Fuchsia",
				CIELabFromRGB(96f, 0f, 63f, 100f)
			},
			{
				"Fawn",
				CIELabFromRGB(90f, 67f, 44f, 100f)
			},
			{
				"Feldgrau",
				CIELabFromRGB(30f, 36f, 33f, 100f)
			},
			{
				"Feldspar",
				CIELabFromRGB(99f, 84f, 69f, 100f)
			},
			{
				"Fern Green",
				CIELabFromRGB(31f, 47f, 26f, 100f)
			},
			{
				"Ferrari Red",
				CIELabFromRGB(100f, 16f, 0f, 100f)
			},
			{
				"Field Drab",
				CIELabFromRGB(42f, 33f, 12f, 100f)
			},
			{
				"Firebrick",
				CIELabFromRGB(70f, 13f, 13f, 100f)
			},
			{
				"Fire Engine Red",
				CIELabFromRGB(81f, 13f, 16f, 100f)
			},
			{
				"Flame",
				CIELabFromRGB(89f, 35f, 13f, 100f)
			},
			{
				"Flamingo Pink",
				CIELabFromRGB(99f, 56f, 67f, 100f)
			},
			{
				"Flattery",
				CIELabFromRGB(42f, 27f, 14f, 100f)
			},
			{
				"Flavescent",
				CIELabFromRGB(97f, 91f, 56f, 100f)
			},
			{
				"Flax",
				CIELabFromRGB(93f, 86f, 51f, 100f)
			},
			{
				"Flirt",
				CIELabFromRGB(64f, 0f, 43f, 100f)
			},
			{
				"Floral White",
				CIELabFromRGB(100f, 98f, 94f, 100f)
			},
			{
				"Fluorescent Orange",
				CIELabFromRGB(100f, 75f, 0f, 100f)
			},
			{
				"Fluorescent Pink",
				CIELabFromRGB(100f, 8f, 58f, 100f)
			},
			{
				"Fluorescent Yellow",
				CIELabFromRGB(80f, 100f, 0f, 100f)
			},
			{
				"Folly",
				CIELabFromRGB(100f, 0f, 31f, 100f)
			},
			{
				"Forest Green (Traditional)",
				CIELabFromRGB(0f, 27f, 13f, 100f)
			},
			{
				"Forest Green (Web)",
				CIELabFromRGB(13f, 55f, 13f, 100f)
			},
			{
				"French Beige",
				CIELabFromRGB(65f, 48f, 36f, 100f)
			},
			{
				"French Bistre",
				CIELabFromRGB(52f, 43f, 30f, 100f)
			},
			{
				"French Blue",
				CIELabFromRGB(0f, 45f, 73f, 100f)
			},
			{
				"French Fuchsia",
				CIELabFromRGB(99f, 25f, 57f, 100f)
			},
			{
				"French Lilac",
				CIELabFromRGB(53f, 38f, 56f, 100f)
			},
			{
				"French Lime",
				CIELabFromRGB(62f, 99f, 22f, 100f)
			},
			{
				"French Mauve",
				CIELabFromRGB(83f, 45f, 83f, 100f)
			},
			{
				"French Pink",
				CIELabFromRGB(99f, 42f, 62f, 100f)
			},
			{
				"French Plum",
				CIELabFromRGB(51f, 8f, 33f, 100f)
			},
			{
				"French Puce",
				CIELabFromRGB(31f, 9f, 4f, 100f)
			},
			{
				"French Raspberry",
				CIELabFromRGB(78f, 17f, 28f, 100f)
			},
			{
				"French Rose",
				CIELabFromRGB(96f, 29f, 54f, 100f)
			},
			{
				"French Sky Blue",
				CIELabFromRGB(47f, 71f, 100f, 100f)
			},
			{
				"French Violet",
				CIELabFromRGB(53f, 2f, 81f, 100f)
			},
			{
				"French Wine",
				CIELabFromRGB(67f, 12f, 27f, 100f)
			},
			{
				"Fresh Air",
				CIELabFromRGB(65f, 91f, 100f, 100f)
			},
			{
				"Fuchsia",
				CIELabFromRGB(100f, 0f, 100f, 100f)
			},
			{
				"Fuchsia (Crayola)",
				CIELabFromRGB(76f, 33f, 76f, 100f)
			},
			{
				"Fuchsia Pink",
				CIELabFromRGB(100f, 47f, 100f, 100f)
			},
			{
				"Fuchsia Purple",
				CIELabFromRGB(80f, 22f, 48f, 100f)
			},
			{
				"Fuchsia Rose",
				CIELabFromRGB(78f, 26f, 46f, 100f)
			},
			{
				"Fulvous",
				CIELabFromRGB(89f, 52f, 0f, 100f)
			},
			{
				"Fuzzy Wuzzy",
				CIELabFromRGB(80f, 40f, 40f, 100f)
			},
			{
				"Gainsboro",
				CIELabFromRGB(86f, 86f, 86f, 100f)
			},
			{
				"Gamboge",
				CIELabFromRGB(89f, 61f, 6f, 100f)
			},
			{
				"Gamboge Orange (Brown)",
				CIELabFromRGB(60f, 40f, 0f, 100f)
			},
			{
				"Generic Viridian",
				CIELabFromRGB(0f, 50f, 40f, 100f)
			},
			{
				"Ghost White",
				CIELabFromRGB(97f, 97f, 100f, 100f)
			},
			{
				"Giants Orange",
				CIELabFromRGB(100f, 35f, 11f, 100f)
			},
			{
				"Grussrel",
				CIELabFromRGB(69f, 40f, 0f, 100f)
			},
			{
				"Glaucous",
				CIELabFromRGB(38f, 51f, 71f, 100f)
			},
			{
				"Glitter",
				CIELabFromRGB(90f, 91f, 98f, 100f)
			},
			{
				"GO Green",
				CIELabFromRGB(0f, 67f, 40f, 100f)
			},
			{
				"Gold (Metallic)",
				CIELabFromRGB(83f, 69f, 22f, 100f)
			},
			{
				"Gold (Web) (Golden)",
				CIELabFromRGB(100f, 84f, 0f, 100f)
			},
			{
				"Gold Fusion",
				CIELabFromRGB(52f, 46f, 31f, 100f)
			},
			{
				"Golden Brown",
				CIELabFromRGB(60f, 40f, 8f, 100f)
			},
			{
				"Golden Poppy",
				CIELabFromRGB(99f, 76f, 0f, 100f)
			},
			{
				"Golden Yellow",
				CIELabFromRGB(100f, 87f, 0f, 100f)
			},
			{
				"Goldenrod",
				CIELabFromRGB(85f, 65f, 13f, 100f)
			},
			{
				"Granny Smith Apple",
				CIELabFromRGB(66f, 89f, 63f, 100f)
			},
			{
				"Grape",
				CIELabFromRGB(44f, 18f, 66f, 100f)
			},
			{
				"Gray",
				CIELabFromRGB(50f, 50f, 50f, 100f)
			},
			{
				"Gray (HTML/CSS Gray)",
				CIELabFromRGB(50f, 50f, 50f, 100f)
			},
			{
				"Gray (X11 Gray)",
				CIELabFromRGB(75f, 75f, 75f, 100f)
			},
			{
				"Gray-Asparagus",
				CIELabFromRGB(27f, 35f, 27f, 100f)
			},
			{
				"Gray-Blue",
				CIELabFromRGB(55f, 57f, 67f, 100f)
			},
			{
				"Green (Color Wheel) (X11 Green)",
				CIELabFromRGB(0f, 100f, 0f, 100f)
			},
			{
				"Green (Crayola)",
				CIELabFromRGB(11f, 67f, 47f, 100f)
			},
			{
				"Green (HTML/CSS Color)",
				CIELabFromRGB(0f, 50f, 0f, 100f)
			},
			{
				"Green (Munsell)",
				CIELabFromRGB(0f, 66f, 47f, 100f)
			},
			{
				"Green (NCS)",
				CIELabFromRGB(0f, 62f, 42f, 100f)
			},
			{
				"Green (Pantone)",
				CIELabFromRGB(0f, 68f, 26f, 100f)
			},
			{
				"Green (Pigment)",
				CIELabFromRGB(0f, 65f, 31f, 100f)
			},
			{
				"Green (RYB)",
				CIELabFromRGB(40f, 69f, 20f, 100f)
			},
			{
				"Green-Blue",
				CIELabFromRGB(7f, 39f, 71f, 100f)
			},
			{
				"Green-Cyan",
				CIELabFromRGB(0f, 60f, 40f, 100f)
			},
			{
				"Green-Yellow",
				CIELabFromRGB(68f, 100f, 18f, 100f)
			},
			{
				"Grizzly",
				CIELabFromRGB(53f, 35f, 9f, 100f)
			},
			{
				"Grullo",
				CIELabFromRGB(66f, 60f, 53f, 100f)
			},
			{
				"Guppie Green",
				CIELabFromRGB(0f, 100f, 50f, 100f)
			},
			{
				"Halayà Úbe",
				CIELabFromRGB(40f, 22f, 33f, 100f)
			},
			{
				"Han Blue",
				CIELabFromRGB(27f, 42f, 81f, 100f)
			},
			{
				"Han Purple",
				CIELabFromRGB(32f, 9f, 98f, 100f)
			},
			{
				"Hansa Yellow",
				CIELabFromRGB(91f, 84f, 42f, 100f)
			},
			{
				"Harlequin",
				CIELabFromRGB(25f, 100f, 0f, 100f)
			},
			{
				"Harlequin Green",
				CIELabFromRGB(27f, 80f, 9f, 100f)
			},
			{
				"Harvard Crimson",
				CIELabFromRGB(79f, 0f, 9f, 100f)
			},
			{
				"Harvest Gold",
				CIELabFromRGB(85f, 57f, 0f, 100f)
			},
			{
				"Heart Gold",
				CIELabFromRGB(50f, 50f, 0f, 100f)
			},
			{
				"Heliotrope",
				CIELabFromRGB(87f, 45f, 100f, 100f)
			},
			{
				"Heliotrope Gray",
				CIELabFromRGB(67f, 60f, 66f, 100f)
			},
			{
				"Heliotrope Magenta",
				CIELabFromRGB(67f, 0f, 73f, 100f)
			},
			{
				"Hollywood Cerise",
				CIELabFromRGB(96f, 0f, 63f, 100f)
			},
			{
				"Honeydew",
				CIELabFromRGB(94f, 100f, 94f, 100f)
			},
			{
				"Honolulu Blue",
				CIELabFromRGB(0f, 43f, 69f, 100f)
			},
			{
				"Hooker's Green",
				CIELabFromRGB(29f, 47f, 42f, 100f)
			},
			{
				"Hot Magenta",
				CIELabFromRGB(100f, 11f, 81f, 100f)
			},
			{
				"Hot Pink",
				CIELabFromRGB(100f, 41f, 71f, 100f)
			},
			{
				"Hunter Green",
				CIELabFromRGB(21f, 37f, 23f, 100f)
			},
			{
				"Iceberg",
				CIELabFromRGB(44f, 65f, 82f, 100f)
			},
			{
				"Icterine",
				CIELabFromRGB(99f, 97f, 37f, 100f)
			},
			{
				"Illuminating Emerald",
				CIELabFromRGB(19f, 57f, 47f, 100f)
			},
			{
				"Imperial",
				CIELabFromRGB(38f, 18f, 42f, 100f)
			},
			{
				"Imperial Blue",
				CIELabFromRGB(0f, 14f, 58f, 100f)
			},
			{
				"Imperial Purple",
				CIELabFromRGB(40f, 1f, 24f, 100f)
			},
			{
				"Imperial Red",
				CIELabFromRGB(93f, 16f, 22f, 100f)
			},
			{
				"Inchworm",
				CIELabFromRGB(70f, 93f, 36f, 100f)
			},
			{
				"Independence",
				CIELabFromRGB(30f, 32f, 43f, 100f)
			},
			{
				"India Green",
				CIELabFromRGB(7f, 53f, 3f, 100f)
			},
			{
				"Indian Red",
				CIELabFromRGB(80f, 36f, 36f, 100f)
			},
			{
				"Indian Yellow",
				CIELabFromRGB(89f, 66f, 34f, 100f)
			},
			{
				"Indigo",
				CIELabFromRGB(44f, 0f, 100f, 100f)
			},
			{
				"Indigo Dye",
				CIELabFromRGB(4f, 12f, 57f, 100f)
			},
			{
				"Indigo (Web)",
				CIELabFromRGB(29f, 0f, 51f, 100f)
			},
			{
				"International Klein Blue",
				CIELabFromRGB(0f, 18f, 65f, 100f)
			},
			{
				"International Orange (Aerospace)",
				CIELabFromRGB(100f, 31f, 0f, 100f)
			},
			{
				"International Orange (Engineering)",
				CIELabFromRGB(73f, 9f, 5f, 100f)
			},
			{
				"International Orange (Golden Gate Bridge)",
				CIELabFromRGB(75f, 21f, 17f, 100f)
			},
			{
				"Iris",
				CIELabFromRGB(35f, 31f, 81f, 100f)
			},
			{
				"Irresistible",
				CIELabFromRGB(70f, 27f, 42f, 100f)
			},
			{
				"Isabelline",
				CIELabFromRGB(96f, 94f, 93f, 100f)
			},
			{
				"Islamic Green",
				CIELabFromRGB(0f, 56f, 0f, 100f)
			},
			{
				"Italian Sky Blue",
				CIELabFromRGB(70f, 100f, 100f, 100f)
			},
			{
				"Ivory",
				CIELabFromRGB(100f, 100f, 94f, 100f)
			},
			{
				"Jade",
				CIELabFromRGB(0f, 66f, 42f, 100f)
			},
			{
				"Japanese Carmine",
				CIELabFromRGB(62f, 16f, 20f, 100f)
			},
			{
				"Japanese Indigo",
				CIELabFromRGB(15f, 26f, 28f, 100f)
			},
			{
				"Japanese Violet",
				CIELabFromRGB(36f, 20f, 34f, 100f)
			},
			{
				"Jasmine",
				CIELabFromRGB(97f, 87f, 49f, 100f)
			},
			{
				"Jasper",
				CIELabFromRGB(84f, 23f, 24f, 100f)
			},
			{
				"Jazzberry Jam",
				CIELabFromRGB(65f, 4f, 37f, 100f)
			},
			{
				"Jelly Bean",
				CIELabFromRGB(85f, 38f, 31f, 100f)
			},
			{
				"Jet",
				CIELabFromRGB(20f, 20f, 20f, 100f)
			},
			{
				"Jonquil",
				CIELabFromRGB(96f, 79f, 9f, 100f)
			},
			{
				"Jordy Blue",
				CIELabFromRGB(54f, 73f, 95f, 100f)
			},
			{
				"June Bud",
				CIELabFromRGB(74f, 85f, 34f, 100f)
			},
			{
				"Jungle Green",
				CIELabFromRGB(16f, 67f, 53f, 100f)
			},
			{
				"Kelly Green",
				CIELabFromRGB(30f, 73f, 9f, 100f)
			},
			{
				"Kenyan Copper",
				CIELabFromRGB(49f, 11f, 2f, 100f)
			},
			{
				"Keppel",
				CIELabFromRGB(23f, 69f, 62f, 100f)
			},
			{
				"Jawad/Chicken Color (HTML/CSS) (Khaki)",
				CIELabFromRGB(76f, 69f, 57f, 100f)
			},
			{
				"Khaki (X11) (Light Khaki)",
				CIELabFromRGB(94f, 90f, 55f, 100f)
			},
			{
				"Kobe",
				CIELabFromRGB(53f, 18f, 9f, 100f)
			},
			{
				"Kobi",
				CIELabFromRGB(91f, 62f, 77f, 100f)
			},
			{
				"Kombu Green",
				CIELabFromRGB(21f, 26f, 19f, 100f)
			},
			{
				"KU Crimson",
				CIELabFromRGB(91f, 0f, 5f, 100f)
			},
			{
				"La Salle Green",
				CIELabFromRGB(3f, 47f, 19f, 100f)
			},
			{
				"Languid Lavender",
				CIELabFromRGB(84f, 79f, 87f, 100f)
			},
			{
				"Lapis Lazuli",
				CIELabFromRGB(15f, 38f, 61f, 100f)
			},
			{
				"Laser Lemon",
				CIELabFromRGB(100f, 100f, 40f, 100f)
			},
			{
				"Laurel Green",
				CIELabFromRGB(66f, 73f, 62f, 100f)
			},
			{
				"Lava",
				CIELabFromRGB(81f, 6f, 13f, 100f)
			},
			{
				"Lavender (Floral)",
				CIELabFromRGB(71f, 49f, 86f, 100f)
			},
			{
				"Lavender (Web)",
				CIELabFromRGB(90f, 90f, 98f, 100f)
			},
			{
				"Lavender Blue",
				CIELabFromRGB(80f, 80f, 100f, 100f)
			},
			{
				"Lavender Blush",
				CIELabFromRGB(100f, 94f, 96f, 100f)
			},
			{
				"Lavender Gray",
				CIELabFromRGB(77f, 76f, 82f, 100f)
			},
			{
				"Lavender Indigo",
				CIELabFromRGB(58f, 34f, 92f, 100f)
			},
			{
				"Lavender Magenta",
				CIELabFromRGB(93f, 51f, 93f, 100f)
			},
			{
				"Lavender Mist",
				CIELabFromRGB(90f, 90f, 98f, 100f)
			},
			{
				"Lavender Pink",
				CIELabFromRGB(98f, 68f, 82f, 100f)
			},
			{
				"Lavender Purple",
				CIELabFromRGB(59f, 48f, 71f, 100f)
			},
			{
				"Lavender Rose",
				CIELabFromRGB(98f, 63f, 89f, 100f)
			},
			{
				"Lawn Green",
				CIELabFromRGB(49f, 99f, 0f, 100f)
			},
			{
				"Lemon",
				CIELabFromRGB(100f, 97f, 0f, 100f)
			},
			{
				"Lemon Chiffon",
				CIELabFromRGB(100f, 98f, 80f, 100f)
			},
			{
				"Lemon Curry",
				CIELabFromRGB(80f, 63f, 11f, 100f)
			},
			{
				"Lemon Glacier",
				CIELabFromRGB(99f, 100f, 0f, 100f)
			},
			{
				"Lemon Lime",
				CIELabFromRGB(89f, 100f, 0f, 100f)
			},
			{
				"Lemon Meringue",
				CIELabFromRGB(96f, 92f, 75f, 100f)
			},
			{
				"Lemon Yellow",
				CIELabFromRGB(100f, 96f, 31f, 100f)
			},
			{
				"Lenurple",
				CIELabFromRGB(73f, 58f, 85f, 100f)
			},
			{
				"Licorice",
				CIELabFromRGB(10f, 7f, 6f, 100f)
			},
			{
				"Liberty",
				CIELabFromRGB(33f, 35f, 65f, 100f)
			},
			{
				"Light Apricot",
				CIELabFromRGB(99f, 84f, 69f, 100f)
			},
			{
				"Light Blue",
				CIELabFromRGB(68f, 85f, 90f, 100f)
			},
			{
				"Light Brilliant Red",
				CIELabFromRGB(100f, 18f, 18f, 100f)
			},
			{
				"Light Brown",
				CIELabFromRGB(71f, 40f, 11f, 100f)
			},
			{
				"Light Carmine Pink",
				CIELabFromRGB(90f, 40f, 44f, 100f)
			},
			{
				"Light Cobalt Blue",
				CIELabFromRGB(53f, 67f, 88f, 100f)
			},
			{
				"Light Coral",
				CIELabFromRGB(94f, 50f, 50f, 100f)
			},
			{
				"Light Cornflower Blue",
				CIELabFromRGB(58f, 80f, 92f, 100f)
			},
			{
				"Light Crimson",
				CIELabFromRGB(96f, 41f, 57f, 100f)
			},
			{
				"Light Cyan",
				CIELabFromRGB(88f, 100f, 100f, 100f)
			},
			{
				"Light Deep Pink",
				CIELabFromRGB(100f, 36f, 80f, 100f)
			},
			{
				"Light French Beige",
				CIELabFromRGB(78f, 68f, 50f, 100f)
			},
			{
				"Light Fuchsia Pink",
				CIELabFromRGB(98f, 52f, 94f, 100f)
			},
			{
				"Light Goldenrod Yellow",
				CIELabFromRGB(98f, 98f, 82f, 100f)
			},
			{
				"Light Gray",
				CIELabFromRGB(83f, 83f, 83f, 100f)
			},
			{
				"Light Grayish Magenta",
				CIELabFromRGB(80f, 60f, 80f, 100f)
			},
			{
				"Light Green",
				CIELabFromRGB(56f, 93f, 56f, 100f)
			},
			{
				"Light Hot Pink",
				CIELabFromRGB(100f, 70f, 87f, 100f)
			},
			{
				"Light Khaki",
				CIELabFromRGB(94f, 90f, 55f, 100f)
			},
			{
				"Light Medium Orchid",
				CIELabFromRGB(83f, 61f, 80f, 100f)
			},
			{
				"Light Moss Green",
				CIELabFromRGB(68f, 87f, 68f, 100f)
			},
			{
				"Light Orchid",
				CIELabFromRGB(90f, 66f, 84f, 100f)
			},
			{
				"Light Pastel Purple",
				CIELabFromRGB(69f, 61f, 85f, 100f)
			},
			{
				"Light Pink",
				CIELabFromRGB(100f, 71f, 76f, 100f)
			},
			{
				"Light Red Ochre",
				CIELabFromRGB(91f, 45f, 32f, 100f)
			},
			{
				"Light Salmon",
				CIELabFromRGB(100f, 63f, 48f, 100f)
			},
			{
				"Light Salmon Pink",
				CIELabFromRGB(100f, 60f, 60f, 100f)
			},
			{
				"Light Sea Green",
				CIELabFromRGB(13f, 70f, 67f, 100f)
			},
			{
				"Light Sky Blue",
				CIELabFromRGB(53f, 81f, 98f, 100f)
			},
			{
				"Light Slate Gray",
				CIELabFromRGB(47f, 53f, 60f, 100f)
			},
			{
				"Light Steel Blue",
				CIELabFromRGB(69f, 77f, 87f, 100f)
			},
			{
				"Light Taupe",
				CIELabFromRGB(70f, 55f, 43f, 100f)
			},
			{
				"Light Thulian Pink",
				CIELabFromRGB(90f, 56f, 67f, 100f)
			},
			{
				"Light Yellow",
				CIELabFromRGB(100f, 100f, 88f, 100f)
			},
			{
				"Lilac",
				CIELabFromRGB(78f, 64f, 78f, 100f)
			},
			{
				"Lime (Color Wheel)",
				CIELabFromRGB(75f, 100f, 0f, 100f)
			},
			{
				"Lime (Web) (X11 Green)",
				CIELabFromRGB(0f, 100f, 0f, 100f)
			},
			{
				"Lime Green",
				CIELabFromRGB(20f, 80f, 20f, 100f)
			},
			{
				"Limerick",
				CIELabFromRGB(62f, 76f, 4f, 100f)
			},
			{
				"Lincoln Green",
				CIELabFromRGB(10f, 35f, 2f, 100f)
			},
			{
				"Linen",
				CIELabFromRGB(98f, 94f, 90f, 100f)
			},
			{
				"Lion",
				CIELabFromRGB(76f, 60f, 42f, 100f)
			},
			{
				"Liseran Purple",
				CIELabFromRGB(87f, 44f, 63f, 100f)
			},
			{
				"Little Boy Blue",
				CIELabFromRGB(42f, 63f, 86f, 100f)
			},
			{
				"Liver",
				CIELabFromRGB(40f, 30f, 28f, 100f)
			},
			{
				"Liver (Dogs)",
				CIELabFromRGB(72f, 43f, 16f, 100f)
			},
			{
				"Liver (Organ)",
				CIELabFromRGB(42f, 18f, 12f, 100f)
			},
			{
				"Liver Chestnut",
				CIELabFromRGB(60f, 45f, 34f, 100f)
			},
			{
				"Livid",
				CIELabFromRGB(40f, 60f, 80f, 100f)
			},
			{
				"Lumber",
				CIELabFromRGB(100f, 89f, 80f, 100f)
			},
			{
				"Lust",
				CIELabFromRGB(90f, 13f, 13f, 100f)
			},
			{
				"Magenta",
				CIELabFromRGB(100f, 0f, 100f, 100f)
			},
			{
				"Magenta (Crayola)",
				CIELabFromRGB(100f, 33f, 64f, 100f)
			},
			{
				"Magenta (Dye)",
				CIELabFromRGB(79f, 12f, 48f, 100f)
			},
			{
				"Magenta (Pantone)",
				CIELabFromRGB(82f, 25f, 49f, 100f)
			},
			{
				"Magenta (Process)",
				CIELabFromRGB(100f, 0f, 56f, 100f)
			},
			{
				"Magenta Haze",
				CIELabFromRGB(62f, 27f, 46f, 100f)
			},
			{
				"Magenta-Pink",
				CIELabFromRGB(80f, 20f, 55f, 100f)
			},
			{
				"Magic Mint",
				CIELabFromRGB(67f, 94f, 82f, 100f)
			},
			{
				"Magnolia",
				CIELabFromRGB(97f, 96f, 100f, 100f)
			},
			{
				"Mahogany",
				CIELabFromRGB(75f, 25f, 0f, 100f)
			},
			{
				"Maize",
				CIELabFromRGB(98f, 93f, 36f, 100f)
			},
			{
				"Majorelle Blue",
				CIELabFromRGB(38f, 31f, 86f, 100f)
			},
			{
				"Malachite",
				CIELabFromRGB(4f, 85f, 32f, 100f)
			},
			{
				"Manatee",
				CIELabFromRGB(59f, 60f, 67f, 100f)
			},
			{
				"Mango Tango",
				CIELabFromRGB(100f, 51f, 26f, 100f)
			},
			{
				"Mantis",
				CIELabFromRGB(45f, 76f, 40f, 100f)
			},
			{
				"Mardi Gras",
				CIELabFromRGB(53f, 0f, 52f, 100f)
			},
			{
				"Marigold",
				CIELabFromRGB(92f, 64f, 13f, 100f)
			},
			{
				"Maroon (Crayola)",
				CIELabFromRGB(76f, 13f, 28f, 100f)
			},
			{
				"Maroon (HTML/CSS)",
				CIELabFromRGB(50f, 0f, 0f, 100f)
			},
			{
				"Maroon (X11)",
				CIELabFromRGB(69f, 19f, 38f, 100f)
			},
			{
				"Mauve",
				CIELabFromRGB(88f, 69f, 100f, 100f)
			},
			{
				"Mauve Taupe",
				CIELabFromRGB(57f, 37f, 43f, 100f)
			},
			{
				"Mauvelous",
				CIELabFromRGB(94f, 60f, 67f, 100f)
			},
			{
				"May Green",
				CIELabFromRGB(30f, 57f, 25f, 100f)
			},
			{
				"Maya Blue",
				CIELabFromRGB(45f, 76f, 98f, 100f)
			},
			{
				"Meat Brown",
				CIELabFromRGB(90f, 72f, 23f, 100f)
			},
			{
				"Medium Aquamarine",
				CIELabFromRGB(40f, 87f, 67f, 100f)
			},
			{
				"Medium Blue",
				CIELabFromRGB(0f, 0f, 80f, 100f)
			},
			{
				"Medium Candy Apple Red",
				CIELabFromRGB(89f, 2f, 17f, 100f)
			},
			{
				"Medium Carmine",
				CIELabFromRGB(69f, 25f, 21f, 100f)
			},
			{
				"Medium Champagne",
				CIELabFromRGB(95f, 90f, 67f, 100f)
			},
			{
				"Medium Electric Blue",
				CIELabFromRGB(1f, 31f, 59f, 100f)
			},
			{
				"Medium Jungle Green",
				CIELabFromRGB(11f, 21f, 18f, 100f)
			},
			{
				"Medium Lavender Magenta",
				CIELabFromRGB(87f, 63f, 87f, 100f)
			},
			{
				"Medium Orchid",
				CIELabFromRGB(73f, 33f, 83f, 100f)
			},
			{
				"Medium Persian Blue",
				CIELabFromRGB(0f, 40f, 65f, 100f)
			},
			{
				"Medium Purple",
				CIELabFromRGB(58f, 44f, 86f, 100f)
			},
			{
				"Medium Red-Violet",
				CIELabFromRGB(73f, 20f, 52f, 100f)
			},
			{
				"Medium Ruby",
				CIELabFromRGB(67f, 25f, 41f, 100f)
			},
			{
				"Medium Sea Green",
				CIELabFromRGB(24f, 70f, 44f, 100f)
			},
			{
				"Medium Sky Blue",
				CIELabFromRGB(50f, 85f, 92f, 100f)
			},
			{
				"Medium Slate Blue",
				CIELabFromRGB(48f, 41f, 93f, 100f)
			},
			{
				"Medium Spring Bud",
				CIELabFromRGB(79f, 86f, 53f, 100f)
			},
			{
				"Medium Spring Green",
				CIELabFromRGB(0f, 98f, 60f, 100f)
			},
			{
				"Medium Taupe",
				CIELabFromRGB(40f, 30f, 28f, 100f)
			},
			{
				"Medium Turquoise",
				CIELabFromRGB(28f, 82f, 80f, 100f)
			},
			{
				"Medium Tuscan Red",
				CIELabFromRGB(47f, 27f, 23f, 100f)
			},
			{
				"Medium Vermilion",
				CIELabFromRGB(85f, 38f, 23f, 100f)
			},
			{
				"Medium Violet-Red",
				CIELabFromRGB(78f, 8f, 52f, 100f)
			},
			{
				"Mellow Apricot",
				CIELabFromRGB(97f, 72f, 47f, 100f)
			},
			{
				"Mellow Yellow",
				CIELabFromRGB(97f, 87f, 49f, 100f)
			},
			{
				"Melon",
				CIELabFromRGB(99f, 74f, 71f, 100f)
			},
			{
				"Metallic Seaweed",
				CIELabFromRGB(4f, 49f, 55f, 100f)
			},
			{
				"Metallic Sunburst",
				CIELabFromRGB(61f, 49f, 22f, 100f)
			},
			{
				"Mexican Pink",
				CIELabFromRGB(89f, 0f, 49f, 100f)
			},
			{
				"Midnight Blue",
				CIELabFromRGB(10f, 10f, 44f, 100f)
			},
			{
				"Midnight Green (Eagle Green)",
				CIELabFromRGB(0f, 29f, 33f, 100f)
			},
			{
				"Mikado Yellow",
				CIELabFromRGB(100f, 77f, 5f, 100f)
			},
			{
				"Mindaro",
				CIELabFromRGB(89f, 98f, 53f, 100f)
			},
			{
				"Ming",
				CIELabFromRGB(21f, 45f, 49f, 100f)
			},
			{
				"Mint",
				CIELabFromRGB(24f, 71f, 54f, 100f)
			},
			{
				"Mint Cream",
				CIELabFromRGB(96f, 100f, 98f, 100f)
			},
			{
				"Mint Green",
				CIELabFromRGB(60f, 100f, 60f, 100f)
			},
			{
				"Misty Rose",
				CIELabFromRGB(100f, 89f, 88f, 100f)
			},
			{
				"Moccasin",
				CIELabFromRGB(98f, 92f, 84f, 100f)
			},
			{
				"Mode Beige",
				CIELabFromRGB(59f, 44f, 9f, 100f)
			},
			{
				"Moonstone Blue",
				CIELabFromRGB(45f, 66f, 76f, 100f)
			},
			{
				"Mordant Red 19",
				CIELabFromRGB(68f, 5f, 0f, 100f)
			},
			{
				"Moss Green",
				CIELabFromRGB(54f, 60f, 36f, 100f)
			},
			{
				"Mountain Meadow",
				CIELabFromRGB(19f, 73f, 56f, 100f)
			},
			{
				"Mountbatten Pink",
				CIELabFromRGB(60f, 48f, 55f, 100f)
			},
			{
				"MSU Green",
				CIELabFromRGB(9f, 27f, 23f, 100f)
			},
			{
				"Mughal Green",
				CIELabFromRGB(19f, 38f, 19f, 100f)
			},
			{
				"Mulberry",
				CIELabFromRGB(77f, 29f, 55f, 100f)
			},
			{
				"Mustard",
				CIELabFromRGB(100f, 86f, 35f, 100f)
			},
			{
				"Myrtle Green",
				CIELabFromRGB(19f, 47f, 45f, 100f)
			},
			{
				"Nadeshiko Pink",
				CIELabFromRGB(96f, 68f, 78f, 100f)
			},
			{
				"Napier Green",
				CIELabFromRGB(16f, 50f, 0f, 100f)
			},
			{
				"Naples Yellow",
				CIELabFromRGB(98f, 85f, 37f, 100f)
			},
			{
				"Navajo White",
				CIELabFromRGB(100f, 87f, 68f, 100f)
			},
			{
				"Navy",
				CIELabFromRGB(0f, 0f, 50f, 100f)
			},
			{
				"Navy Purple",
				CIELabFromRGB(58f, 34f, 92f, 100f)
			},
			{
				"Neon Carrot",
				CIELabFromRGB(100f, 64f, 26f, 100f)
			},
			{
				"Neon Fuchsia",
				CIELabFromRGB(100f, 25f, 39f, 100f)
			},
			{
				"Neon Green",
				CIELabFromRGB(22f, 100f, 8f, 100f)
			},
			{
				"New Car",
				CIELabFromRGB(13f, 31f, 78f, 100f)
			},
			{
				"New York Pink",
				CIELabFromRGB(84f, 51f, 50f, 100f)
			},
			{
				"Non-Photo Blue",
				CIELabFromRGB(64f, 87f, 93f, 100f)
			},
			{
				"North Texas Green",
				CIELabFromRGB(2f, 56f, 20f, 100f)
			},
			{
				"Nyanza",
				CIELabFromRGB(91f, 100f, 86f, 100f)
			},
			{
				"Ocean Boat Blue",
				CIELabFromRGB(0f, 47f, 75f, 100f)
			},
			{
				"Ochre",
				CIELabFromRGB(80f, 47f, 13f, 100f)
			},
			{
				"Office Green",
				CIELabFromRGB(0f, 50f, 0f, 100f)
			},
			{
				"Old Burgundy",
				CIELabFromRGB(26f, 19f, 18f, 100f)
			},
			{
				"Old Gold",
				CIELabFromRGB(81f, 71f, 23f, 100f)
			},
			{
				"Old Heliotrope",
				CIELabFromRGB(34f, 24f, 36f, 100f)
			},
			{
				"Old Lace",
				CIELabFromRGB(99f, 96f, 90f, 100f)
			},
			{
				"Old Lavender",
				CIELabFromRGB(47f, 41f, 47f, 100f)
			},
			{
				"Old Mauve",
				CIELabFromRGB(40f, 19f, 28f, 100f)
			},
			{
				"Old Moss Green",
				CIELabFromRGB(53f, 49f, 21f, 100f)
			},
			{
				"Old Rose",
				CIELabFromRGB(75f, 50f, 51f, 100f)
			},
			{
				"Old Silver",
				CIELabFromRGB(52f, 52f, 51f, 100f)
			},
			{
				"Olive",
				CIELabFromRGB(50f, 50f, 0f, 100f)
			},
			{
				"Olive Drab",
				CIELabFromRGB(24f, 20f, 12f, 100f)
			},
			{
				"Olivine",
				CIELabFromRGB(60f, 73f, 45f, 100f)
			},
			{
				"Onyx",
				CIELabFromRGB(21f, 22f, 22f, 100f)
			},
			{
				"Opera Mauve",
				CIELabFromRGB(72f, 52f, 65f, 100f)
			},
			{
				"Orange (Color Wheel)",
				CIELabFromRGB(100f, 50f, 0f, 100f)
			},
			{
				"Orange (Crayola)",
				CIELabFromRGB(100f, 46f, 22f, 100f)
			},
			{
				"Orange (Pantone)",
				CIELabFromRGB(100f, 35f, 0f, 100f)
			},
			{
				"Orange (RYB)",
				CIELabFromRGB(98f, 60f, 1f, 100f)
			},
			{
				"Orange (Web)",
				CIELabFromRGB(100f, 65f, 0f, 100f)
			},
			{
				"Orange Peel",
				CIELabFromRGB(100f, 62f, 0f, 100f)
			},
			{
				"Orange-Red",
				CIELabFromRGB(100f, 27f, 0f, 100f)
			},
			{
				"Orange-Yellow",
				CIELabFromRGB(97f, 84f, 41f, 100f)
			},
			{
				"Orchid",
				CIELabFromRGB(85f, 44f, 84f, 100f)
			},
			{
				"Orchid Pink",
				CIELabFromRGB(95f, 74f, 80f, 100f)
			},
			{
				"Orioles Orange",
				CIELabFromRGB(98f, 31f, 8f, 100f)
			},
			{
				"Otter Brown",
				CIELabFromRGB(40f, 26f, 13f, 100f)
			},
			{
				"Outer Space",
				CIELabFromRGB(25f, 29f, 30f, 100f)
			},
			{
				"Outrageous Orange",
				CIELabFromRGB(100f, 43f, 29f, 100f)
			},
			{
				"Oxford Blue",
				CIELabFromRGB(0f, 13f, 28f, 100f)
			},
			{
				"OU Crimson Red",
				CIELabFromRGB(60f, 0f, 0f, 100f)
			},
			{
				"Pakistan Green",
				CIELabFromRGB(0f, 40f, 0f, 100f)
			},
			{
				"Palatinate Blue",
				CIELabFromRGB(15f, 23f, 89f, 100f)
			},
			{
				"Palatinate Purple",
				CIELabFromRGB(41f, 16f, 38f, 100f)
			},
			{
				"Pale Aqua",
				CIELabFromRGB(74f, 83f, 90f, 100f)
			},
			{
				"Pale Blue",
				CIELabFromRGB(69f, 93f, 93f, 100f)
			},
			{
				"Pale Brown",
				CIELabFromRGB(60f, 46f, 33f, 100f)
			},
			{
				"Pale Carmine",
				CIELabFromRGB(69f, 25f, 21f, 100f)
			},
			{
				"Pale Cerulean",
				CIELabFromRGB(61f, 77f, 89f, 100f)
			},
			{
				"Pale Chestnut",
				CIELabFromRGB(87f, 68f, 69f, 100f)
			},
			{
				"Pale Copper",
				CIELabFromRGB(85f, 54f, 40f, 100f)
			},
			{
				"Pale Cornflower Blue",
				CIELabFromRGB(67f, 80f, 94f, 100f)
			},
			{
				"Pale Cyan",
				CIELabFromRGB(53f, 83f, 97f, 100f)
			},
			{
				"Pale Gold",
				CIELabFromRGB(90f, 75f, 54f, 100f)
			},
			{
				"Pale Goldenrod",
				CIELabFromRGB(93f, 91f, 67f, 100f)
			},
			{
				"Pale Green",
				CIELabFromRGB(60f, 98f, 60f, 100f)
			},
			{
				"Pale Lavender",
				CIELabFromRGB(86f, 82f, 100f, 100f)
			},
			{
				"Pale Magenta",
				CIELabFromRGB(98f, 52f, 90f, 100f)
			},
			{
				"Pale Magenta-Pink",
				CIELabFromRGB(100f, 60f, 80f, 100f)
			},
			{
				"Pale Pink",
				CIELabFromRGB(98f, 85f, 87f, 100f)
			},
			{
				"Pale Plum",
				CIELabFromRGB(87f, 63f, 87f, 100f)
			},
			{
				"Pale Red-Violet",
				CIELabFromRGB(86f, 44f, 58f, 100f)
			},
			{
				"Pale Robin Egg Blue",
				CIELabFromRGB(59f, 87f, 82f, 100f)
			},
			{
				"Pale Silver",
				CIELabFromRGB(79f, 75f, 73f, 100f)
			},
			{
				"Pale Spring Bud",
				CIELabFromRGB(93f, 92f, 74f, 100f)
			},
			{
				"Pale Taupe",
				CIELabFromRGB(74f, 60f, 49f, 100f)
			},
			{
				"Pale Turquoise",
				CIELabFromRGB(69f, 93f, 93f, 100f)
			},
			{
				"Pale Violet",
				CIELabFromRGB(80f, 60f, 100f, 100f)
			},
			{
				"Pale Violet-Red",
				CIELabFromRGB(86f, 44f, 58f, 100f)
			},
			{
				"Pansy Purple",
				CIELabFromRGB(47f, 9f, 29f, 100f)
			},
			{
				"Paolo Veronese Green",
				CIELabFromRGB(0f, 61f, 49f, 100f)
			},
			{
				"Papaya Whip",
				CIELabFromRGB(100f, 94f, 84f, 100f)
			},
			{
				"Paradise Pink",
				CIELabFromRGB(90f, 24f, 38f, 100f)
			},
			{
				"Paris Green",
				CIELabFromRGB(31f, 78f, 47f, 100f)
			},
			{
				"Pastel Blue",
				CIELabFromRGB(68f, 78f, 81f, 100f)
			},
			{
				"Pastel Brown",
				CIELabFromRGB(51f, 41f, 33f, 100f)
			},
			{
				"Pastel Gray",
				CIELabFromRGB(81f, 81f, 77f, 100f)
			},
			{
				"Pastel Green",
				CIELabFromRGB(47f, 87f, 47f, 100f)
			},
			{
				"Pastel Magenta",
				CIELabFromRGB(96f, 60f, 76f, 100f)
			},
			{
				"Pastel Orange",
				CIELabFromRGB(100f, 70f, 28f, 100f)
			},
			{
				"Pastel Pink",
				CIELabFromRGB(87f, 65f, 64f, 100f)
			},
			{
				"Pastel Purple",
				CIELabFromRGB(70f, 62f, 71f, 100f)
			},
			{
				"Pastel Red",
				CIELabFromRGB(100f, 41f, 38f, 100f)
			},
			{
				"Pastel Violet",
				CIELabFromRGB(80f, 60f, 79f, 100f)
			},
			{
				"Pastel Yellow",
				CIELabFromRGB(99f, 99f, 59f, 100f)
			},
			{
				"Patriarch",
				CIELabFromRGB(50f, 0f, 50f, 100f)
			},
			{
				"Payne's Grey",
				CIELabFromRGB(33f, 41f, 47f, 100f)
			},
			{
				"Peachier",
				CIELabFromRGB(100f, 90f, 71f, 100f)
			},
			{
				"Peach",
				CIELabFromRGB(100f, 80f, 64f, 100f)
			},
			{
				"Peach-Orange",
				CIELabFromRGB(100f, 80f, 60f, 100f)
			},
			{
				"Peach Puff",
				CIELabFromRGB(100f, 85f, 73f, 100f)
			},
			{
				"Peach-Yellow",
				CIELabFromRGB(98f, 87f, 68f, 100f)
			},
			{
				"Pear",
				CIELabFromRGB(82f, 89f, 19f, 100f)
			},
			{
				"Pearl",
				CIELabFromRGB(92f, 88f, 78f, 100f)
			},
			{
				"Pearl Aqua",
				CIELabFromRGB(53f, 85f, 75f, 100f)
			},
			{
				"Pearly Purple",
				CIELabFromRGB(72f, 41f, 64f, 100f)
			},
			{
				"Peridot",
				CIELabFromRGB(90f, 89f, 0f, 100f)
			},
			{
				"Periwinkle",
				CIELabFromRGB(80f, 80f, 100f, 100f)
			},
			{
				"Persian Blue",
				CIELabFromRGB(11f, 22f, 73f, 100f)
			},
			{
				"Persian Green",
				CIELabFromRGB(0f, 65f, 58f, 100f)
			},
			{
				"Persian Indigo",
				CIELabFromRGB(20f, 7f, 48f, 100f)
			},
			{
				"Persian Orange",
				CIELabFromRGB(85f, 56f, 35f, 100f)
			},
			{
				"Persian Pink",
				CIELabFromRGB(97f, 50f, 75f, 100f)
			},
			{
				"Persian Plum",
				CIELabFromRGB(44f, 11f, 11f, 100f)
			},
			{
				"Persian Red",
				CIELabFromRGB(80f, 20f, 20f, 100f)
			},
			{
				"Persian Rose",
				CIELabFromRGB(100f, 16f, 64f, 100f)
			},
			{
				"Persimmon",
				CIELabFromRGB(93f, 35f, 0f, 100f)
			},
			{
				"Peru",
				CIELabFromRGB(80f, 52f, 25f, 100f)
			},
			{
				"Phlox",
				CIELabFromRGB(87f, 0f, 100f, 100f)
			},
			{
				"Phthalo Blue",
				CIELabFromRGB(0f, 6f, 54f, 100f)
			},
			{
				"Phthalo Green",
				CIELabFromRGB(7f, 21f, 14f, 100f)
			},
			{
				"Picton Blue",
				CIELabFromRGB(27f, 69f, 91f, 100f)
			},
			{
				"Pictorial Carmine",
				CIELabFromRGB(76f, 4f, 31f, 100f)
			},
			{
				"Piggy Pink",
				CIELabFromRGB(99f, 87f, 90f, 100f)
			},
			{
				"Pine Green",
				CIELabFromRGB(0f, 47f, 44f, 100f)
			},
			{
				"Pineapple",
				CIELabFromRGB(34f, 24f, 5f, 100f)
			},
			{
				"Pink",
				CIELabFromRGB(100f, 75f, 80f, 100f)
			},
			{
				"Pink (Pantone)",
				CIELabFromRGB(84f, 28f, 58f, 100f)
			},
			{
				"Pink Lace",
				CIELabFromRGB(100f, 87f, 96f, 100f)
			},
			{
				"Pink Lavender",
				CIELabFromRGB(85f, 70f, 82f, 100f)
			},
			{
				"Pink-Orange",
				CIELabFromRGB(100f, 60f, 40f, 100f)
			},
			{
				"Pink Pearl",
				CIELabFromRGB(91f, 67f, 81f, 100f)
			},
			{
				"Pink Raspberry",
				CIELabFromRGB(60f, 0f, 21f, 100f)
			},
			{
				"Pink Sherbet",
				CIELabFromRGB(97f, 56f, 65f, 100f)
			},
			{
				"Pistachio",
				CIELabFromRGB(58f, 77f, 45f, 100f)
			},
			{
				"Platinum",
				CIELabFromRGB(90f, 89f, 89f, 100f)
			},
			{
				"Plum",
				CIELabFromRGB(56f, 27f, 52f, 100f)
			},
			{
				"Plum (Web)",
				CIELabFromRGB(87f, 63f, 87f, 100f)
			},
			{
				"Pomp And Power",
				CIELabFromRGB(53f, 38f, 56f, 100f)
			},
			{
				"Popstar",
				CIELabFromRGB(75f, 31f, 38f, 100f)
			},
			{
				"Portland Orange",
				CIELabFromRGB(100f, 35f, 21f, 100f)
			},
			{
				"Powder Blue",
				CIELabFromRGB(69f, 88f, 90f, 100f)
			},
			{
				"Princeton Orange",
				CIELabFromRGB(96f, 50f, 15f, 100f)
			},
			{
				"Prune",
				CIELabFromRGB(44f, 11f, 11f, 100f)
			},
			{
				"Prussian Blue",
				CIELabFromRGB(0f, 19f, 33f, 100f)
			},
			{
				"Psychedelic Purple",
				CIELabFromRGB(87f, 0f, 100f, 100f)
			},
			{
				"Puce",
				CIELabFromRGB(80f, 53f, 60f, 100f)
			},
			{
				"Puce Red",
				CIELabFromRGB(45f, 18f, 22f, 100f)
			},
			{
				"Pullman Brown (UPS Brown)",
				CIELabFromRGB(39f, 25f, 9f, 100f)
			},
			{
				"Pullman Green",
				CIELabFromRGB(23f, 20f, 11f, 100f)
			},
			{
				"Pumpkin",
				CIELabFromRGB(100f, 46f, 9f, 100f)
			},
			{
				"Purple (HTML)",
				CIELabFromRGB(50f, 0f, 50f, 100f)
			},
			{
				"Purple (Munsell)",
				CIELabFromRGB(62f, 0f, 77f, 100f)
			},
			{
				"Purple (X11)",
				CIELabFromRGB(63f, 13f, 94f, 100f)
			},
			{
				"Purple Heart",
				CIELabFromRGB(41f, 21f, 61f, 100f)
			},
			{
				"Purple Mountain Majesty",
				CIELabFromRGB(59f, 47f, 71f, 100f)
			},
			{
				"Purple Navy",
				CIELabFromRGB(31f, 32f, 50f, 100f)
			},
			{
				"Purple Pizzazz",
				CIELabFromRGB(100f, 31f, 85f, 100f)
			},
			{
				"Purple Taupe",
				CIELabFromRGB(31f, 25f, 30f, 100f)
			},
			{
				"Purpureus",
				CIELabFromRGB(60f, 31f, 68f, 100f)
			},
			{
				"Quartz",
				CIELabFromRGB(32f, 28f, 31f, 100f)
			},
			{
				"Queen Blue",
				CIELabFromRGB(26f, 42f, 58f, 100f)
			},
			{
				"Queen Pink",
				CIELabFromRGB(91f, 80f, 84f, 100f)
			},
			{
				"Quinacridone Magenta",
				CIELabFromRGB(56f, 23f, 35f, 100f)
			},
			{
				"Rackley",
				CIELabFromRGB(36f, 54f, 66f, 100f)
			},
			{
				"Radical Red",
				CIELabFromRGB(100f, 21f, 37f, 100f)
			},
			{
				"Rajah",
				CIELabFromRGB(98f, 67f, 38f, 100f)
			},
			{
				"Raspberry",
				CIELabFromRGB(89f, 4f, 36f, 100f)
			},
			{
				"Raspberry Glace",
				CIELabFromRGB(57f, 37f, 43f, 100f)
			},
			{
				"Raspberry Pink",
				CIELabFromRGB(89f, 31f, 60f, 100f)
			},
			{
				"Raspberry Rose",
				CIELabFromRGB(70f, 27f, 42f, 100f)
			},
			{
				"Raw Umber",
				CIELabFromRGB(51f, 40f, 27f, 100f)
			},
			{
				"Razzle Dazzle Rose",
				CIELabFromRGB(100f, 20f, 80f, 100f)
			},
			{
				"Razzmatazz",
				CIELabFromRGB(89f, 15f, 42f, 100f)
			},
			{
				"Razzmic Berry",
				CIELabFromRGB(55f, 31f, 52f, 100f)
			},
			{
				"Rebecca Purple",
				CIELabFromRGB(40f, 20f, 60f, 100f)
			},
			{
				"Red",
				CIELabFromRGB(100f, 0f, 0f, 100f)
			},
			{
				"Red (Crayola)",
				CIELabFromRGB(93f, 13f, 30f, 100f)
			},
			{
				"Red (Munsell)",
				CIELabFromRGB(95f, 0f, 24f, 100f)
			},
			{
				"Red (NCS)",
				CIELabFromRGB(77f, 1f, 20f, 100f)
			},
			{
				"Red (Pantone)",
				CIELabFromRGB(93f, 16f, 22f, 100f)
			},
			{
				"Red (Pigment)",
				CIELabFromRGB(93f, 11f, 14f, 100f)
			},
			{
				"Red (RYB)",
				CIELabFromRGB(100f, 15f, 7f, 100f)
			},
			{
				"Red-Brown",
				CIELabFromRGB(65f, 16f, 16f, 100f)
			},
			{
				"Red Devil",
				CIELabFromRGB(53f, 0f, 7f, 100f)
			},
			{
				"Red-Orange",
				CIELabFromRGB(100f, 33f, 29f, 100f)
			},
			{
				"Red-Purple",
				CIELabFromRGB(89f, 0f, 47f, 100f)
			},
			{
				"Red-Violet",
				CIELabFromRGB(78f, 8f, 52f, 100f)
			},
			{
				"Redwood",
				CIELabFromRGB(64f, 35f, 32f, 100f)
			},
			{
				"Regalia",
				CIELabFromRGB(32f, 18f, 50f, 100f)
			},
			{
				"Registration Black",
				CIELabFromRGB(0f, 0f, 0f, 100f)
			},
			{
				"Resolution Blue",
				CIELabFromRGB(0f, 14f, 53f, 100f)
			},
			{
				"Rhythm",
				CIELabFromRGB(47f, 46f, 59f, 100f)
			},
			{
				"Rich Black",
				CIELabFromRGB(0f, 25f, 25f, 100f)
			},
			{
				"Rich Black (FOGRA29)",
				CIELabFromRGB(0f, 4f, 7f, 100f)
			},
			{
				"Rich Black (FOGRA39)",
				CIELabFromRGB(0f, 1f, 1f, 100f)
			},
			{
				"Rich Brilliant Lavender",
				CIELabFromRGB(95f, 65f, 100f, 100f)
			},
			{
				"Rich Carmine",
				CIELabFromRGB(84f, 0f, 25f, 100f)
			},
			{
				"Rich Electric Blue",
				CIELabFromRGB(3f, 57f, 82f, 100f)
			},
			{
				"Rich Lavender",
				CIELabFromRGB(65f, 42f, 81f, 100f)
			},
			{
				"Rich Lilac",
				CIELabFromRGB(71f, 40f, 82f, 100f)
			},
			{
				"Rich Maroon",
				CIELabFromRGB(69f, 19f, 38f, 100f)
			},
			{
				"Rifle Green",
				CIELabFromRGB(27f, 30f, 22f, 100f)
			},
			{
				"Roast Coffee",
				CIELabFromRGB(44f, 26f, 25f, 100f)
			},
			{
				"Robin Egg Blue",
				CIELabFromRGB(0f, 80f, 80f, 100f)
			},
			{
				"Rocket Metallic",
				CIELabFromRGB(54f, 50f, 50f, 100f)
			},
			{
				"Roman Silver",
				CIELabFromRGB(51f, 54f, 59f, 100f)
			},
			{
				"Rose",
				CIELabFromRGB(100f, 0f, 50f, 100f)
			},
			{
				"Rose Bonbon",
				CIELabFromRGB(98f, 26f, 62f, 100f)
			},
			{
				"Rose Ebony",
				CIELabFromRGB(40f, 28f, 27f, 100f)
			},
			{
				"Rose Gold",
				CIELabFromRGB(72f, 43f, 47f, 100f)
			},
			{
				"Rose Madder",
				CIELabFromRGB(89f, 15f, 21f, 100f)
			},
			{
				"Rose Pink",
				CIELabFromRGB(100f, 40f, 80f, 100f)
			},
			{
				"Rose Quartz",
				CIELabFromRGB(67f, 60f, 66f, 100f)
			},
			{
				"Rose Red",
				CIELabFromRGB(76f, 12f, 34f, 100f)
			},
			{
				"Rose Taupe",
				CIELabFromRGB(56f, 36f, 36f, 100f)
			},
			{
				"Rose Vale",
				CIELabFromRGB(67f, 31f, 32f, 100f)
			},
			{
				"Rosewood",
				CIELabFromRGB(40f, 0f, 4f, 100f)
			},
			{
				"Rosso Corsa",
				CIELabFromRGB(83f, 0f, 0f, 100f)
			},
			{
				"Rosy Brown",
				CIELabFromRGB(74f, 56f, 56f, 100f)
			},
			{
				"Royal Azure",
				CIELabFromRGB(0f, 22f, 66f, 100f)
			},
			{
				"Royal Blue",
				CIELabFromRGB(0f, 14f, 40f, 100f)
			},
			{
				"Royal Blue 2",
				CIELabFromRGB(25f, 41f, 88f, 100f)
			},
			{
				"Royal Fuchsia",
				CIELabFromRGB(79f, 17f, 57f, 100f)
			},
			{
				"Royal Purple",
				CIELabFromRGB(47f, 32f, 66f, 100f)
			},
			{
				"Royal Yellow",
				CIELabFromRGB(98f, 85f, 37f, 100f)
			},
			{
				"Ruber",
				CIELabFromRGB(81f, 27f, 46f, 100f)
			},
			{
				"Rubine Red",
				CIELabFromRGB(82f, 0f, 34f, 100f)
			},
			{
				"Ruby",
				CIELabFromRGB(88f, 7f, 37f, 100f)
			},
			{
				"Ruby Red",
				CIELabFromRGB(61f, 7f, 12f, 100f)
			},
			{
				"Ruddy",
				CIELabFromRGB(100f, 0f, 16f, 100f)
			},
			{
				"Ruddy Brown",
				CIELabFromRGB(73f, 40f, 16f, 100f)
			},
			{
				"Ruddy Pink",
				CIELabFromRGB(88f, 56f, 59f, 100f)
			},
			{
				"Rufous",
				CIELabFromRGB(66f, 11f, 3f, 100f)
			},
			{
				"Russet",
				CIELabFromRGB(50f, 27f, 11f, 100f)
			},
			{
				"Russian Green",
				CIELabFromRGB(40f, 57f, 40f, 100f)
			},
			{
				"Russian Violet",
				CIELabFromRGB(20f, 9f, 30f, 100f)
			},
			{
				"Rust",
				CIELabFromRGB(72f, 25f, 5f, 100f)
			},
			{
				"Rusty Red",
				CIELabFromRGB(85f, 17f, 26f, 100f)
			},
			{
				"Sacramento State Green",
				CIELabFromRGB(0f, 34f, 25f, 100f)
			},
			{
				"Saddle Brown",
				CIELabFromRGB(55f, 27f, 7f, 100f)
			},
			{
				"Safety Orange",
				CIELabFromRGB(100f, 47f, 0f, 100f)
			},
			{
				"Safety Orange (Blaze Orange)",
				CIELabFromRGB(100f, 40f, 0f, 100f)
			},
			{
				"Safety Yellow",
				CIELabFromRGB(93f, 82f, 1f, 100f)
			},
			{
				"Saffron",
				CIELabFromRGB(96f, 77f, 19f, 100f)
			},
			{
				"Sage",
				CIELabFromRGB(74f, 72f, 54f, 100f)
			},
			{
				"St. Patrick's Blue",
				CIELabFromRGB(14f, 16f, 48f, 100f)
			},
			{
				"Salmon",
				CIELabFromRGB(98f, 50f, 45f, 100f)
			},
			{
				"Salmon Pink",
				CIELabFromRGB(100f, 57f, 64f, 100f)
			},
			{
				"Sand",
				CIELabFromRGB(76f, 70f, 50f, 100f)
			},
			{
				"Sand Dune",
				CIELabFromRGB(59f, 44f, 9f, 100f)
			},
			{
				"Sandstorm",
				CIELabFromRGB(93f, 84f, 25f, 100f)
			},
			{
				"Sandy Brown",
				CIELabFromRGB(96f, 64f, 38f, 100f)
			},
			{
				"Sandy Taupe",
				CIELabFromRGB(59f, 44f, 9f, 100f)
			},
			{
				"Sangria",
				CIELabFromRGB(57f, 0f, 4f, 100f)
			},
			{
				"Sap Green",
				CIELabFromRGB(31f, 49f, 16f, 100f)
			},
			{
				"Sapphire",
				CIELabFromRGB(6f, 32f, 73f, 100f)
			},
			{
				"Sapphire Blue",
				CIELabFromRGB(0f, 40f, 65f, 100f)
			},
			{
				"Satin Sheen Gold",
				CIELabFromRGB(80f, 63f, 21f, 100f)
			},
			{
				"Scarlet",
				CIELabFromRGB(100f, 14f, 0f, 100f)
			},
			{
				"Scarlet-ier",
				CIELabFromRGB(99f, 5f, 21f, 100f)
			},
			{
				"Schauss Pink",
				CIELabFromRGB(100f, 57f, 69f, 100f)
			},
			{
				"School Bus Yellow",
				CIELabFromRGB(100f, 85f, 0f, 100f)
			},
			{
				"Screamin' Green",
				CIELabFromRGB(46f, 100f, 48f, 100f)
			},
			{
				"Sea Blue",
				CIELabFromRGB(0f, 41f, 58f, 100f)
			},
			{
				"Sea Green",
				CIELabFromRGB(18f, 55f, 34f, 100f)
			},
			{
				"Seal Brown",
				CIELabFromRGB(20f, 8f, 8f, 100f)
			},
			{
				"Seashell",
				CIELabFromRGB(100f, 96f, 93f, 100f)
			},
			{
				"Selective Yellow",
				CIELabFromRGB(100f, 73f, 0f, 100f)
			},
			{
				"Sepia",
				CIELabFromRGB(44f, 26f, 8f, 100f)
			},
			{
				"Shadow",
				CIELabFromRGB(54f, 47f, 36f, 100f)
			},
			{
				"Shadow Blue",
				CIELabFromRGB(47f, 55f, 65f, 100f)
			},
			{
				"Shampoo",
				CIELabFromRGB(100f, 81f, 95f, 100f)
			},
			{
				"Shamrock Green",
				CIELabFromRGB(0f, 62f, 38f, 100f)
			},
			{
				"Sheen Green",
				CIELabFromRGB(56f, 83f, 0f, 100f)
			},
			{
				"Shimmering Blush",
				CIELabFromRGB(85f, 53f, 58f, 100f)
			},
			{
				"Shocking Pink",
				CIELabFromRGB(99f, 6f, 75f, 100f)
			},
			{
				"Shocking Pink (Crayola)",
				CIELabFromRGB(100f, 44f, 100f, 100f)
			},
			{
				"Sienna",
				CIELabFromRGB(53f, 18f, 9f, 100f)
			},
			{
				"Silver",
				CIELabFromRGB(75f, 75f, 75f, 100f)
			},
			{
				"Silver Chalice",
				CIELabFromRGB(67f, 67f, 67f, 100f)
			},
			{
				"Silver Lake Blue",
				CIELabFromRGB(36f, 54f, 73f, 100f)
			},
			{
				"Silver Pink",
				CIELabFromRGB(77f, 68f, 68f, 100f)
			},
			{
				"Silver Sand",
				CIELabFromRGB(75f, 76f, 76f, 100f)
			},
			{
				"Sinopia",
				CIELabFromRGB(80f, 25f, 4f, 100f)
			},
			{
				"Skobeloff",
				CIELabFromRGB(0f, 45f, 45f, 100f)
			},
			{
				"Sky Blue",
				CIELabFromRGB(53f, 81f, 92f, 100f)
			},
			{
				"Sky Magenta",
				CIELabFromRGB(81f, 44f, 69f, 100f)
			},
			{
				"Slate Blue",
				CIELabFromRGB(42f, 35f, 80f, 100f)
			},
			{
				"Slate Gray",
				CIELabFromRGB(44f, 50f, 56f, 100f)
			},
			{
				"Smalt (Dark Powder Blue)",
				CIELabFromRGB(0f, 20f, 60f, 100f)
			},
			{
				"Smitten",
				CIELabFromRGB(78f, 25f, 53f, 100f)
			},
			{
				"Smoke",
				CIELabFromRGB(45f, 51f, 46f, 100f)
			},
			{
				"Smoky Black",
				CIELabFromRGB(6f, 5f, 3f, 100f)
			},
			{
				"Smoky Topaz",
				CIELabFromRGB(58f, 24f, 25f, 100f)
			},
			{
				"Snow",
				CIELabFromRGB(100f, 98f, 98f, 100f)
			},
			{
				"Soap",
				CIELabFromRGB(81f, 78f, 94f, 100f)
			},
			{
				"Solid Pink",
				CIELabFromRGB(54f, 22f, 26f, 100f)
			},
			{
				"Sonic Silver",
				CIELabFromRGB(46f, 46f, 46f, 100f)
			},
			{
				"Spartan Crimson",
				CIELabFromRGB(62f, 7f, 9f, 100f)
			},
			{
				"Space Cadet",
				CIELabFromRGB(11f, 16f, 32f, 100f)
			},
			{
				"Spanish Bistre",
				CIELabFromRGB(50f, 46f, 20f, 100f)
			},
			{
				"Spanish Blue",
				CIELabFromRGB(0f, 44f, 72f, 100f)
			},
			{
				"Spanish Carmine",
				CIELabFromRGB(82f, 0f, 28f, 100f)
			},
			{
				"Spanish Crimson",
				CIELabFromRGB(90f, 10f, 30f, 100f)
			},
			{
				"Spanish Gray",
				CIELabFromRGB(60f, 60f, 60f, 100f)
			},
			{
				"Spanish Green",
				CIELabFromRGB(0f, 57f, 31f, 100f)
			},
			{
				"Spanish Orange",
				CIELabFromRGB(91f, 38f, 0f, 100f)
			},
			{
				"Spanish Pink",
				CIELabFromRGB(97f, 75f, 75f, 100f)
			},
			{
				"Spanish Red",
				CIELabFromRGB(90f, 0f, 15f, 100f)
			},
			{
				"Spanish Sky Blue",
				CIELabFromRGB(0f, 100f, 100f, 100f)
			},
			{
				"Spanish Violet",
				CIELabFromRGB(30f, 16f, 51f, 100f)
			},
			{
				"Spanish Viridian",
				CIELabFromRGB(0f, 50f, 36f, 100f)
			},
			{
				"Spicy Mix",
				CIELabFromRGB(55f, 37f, 30f, 100f)
			},
			{
				"Spiro Disco Ball",
				CIELabFromRGB(6f, 75f, 99f, 100f)
			},
			{
				"Spring Bud",
				CIELabFromRGB(65f, 99f, 0f, 100f)
			},
			{
				"Spring Green",
				CIELabFromRGB(0f, 100f, 50f, 100f)
			},
			{
				"Star Command Blue",
				CIELabFromRGB(0f, 48f, 72f, 100f)
			},
			{
				"Steel Blue",
				CIELabFromRGB(27f, 51f, 71f, 100f)
			},
			{
				"Steel Pink",
				CIELabFromRGB(80f, 20f, 80f, 100f)
			},
			{
				"Stil De Grain Yellow",
				CIELabFromRGB(98f, 85f, 37f, 100f)
			},
			{
				"Stizza",
				CIELabFromRGB(60f, 0f, 0f, 100f)
			},
			{
				"Stormcloud",
				CIELabFromRGB(31f, 40f, 42f, 100f)
			},
			{
				"Thistle",
				CIELabFromRGB(85f, 75f, 85f, 100f)
			},
			{
				"Straw",
				CIELabFromRGB(89f, 85f, 44f, 100f)
			},
			{
				"Strawberry",
				CIELabFromRGB(99f, 35f, 55f, 100f)
			},
			{
				"Sunglow",
				CIELabFromRGB(100f, 80f, 20f, 100f)
			},
			{
				"Sunray",
				CIELabFromRGB(89f, 67f, 34f, 100f)
			},
			{
				"Sunset",
				CIELabFromRGB(98f, 84f, 65f, 100f)
			},
			{
				"Sunset Orange",
				CIELabFromRGB(99f, 37f, 33f, 100f)
			},
			{
				"Super Pink",
				CIELabFromRGB(81f, 42f, 66f, 100f)
			},
			{
				"Tan",
				CIELabFromRGB(82f, 71f, 55f, 100f)
			},
			{
				"Tangelo",
				CIELabFromRGB(98f, 30f, 0f, 100f)
			},
			{
				"Tangerine",
				CIELabFromRGB(95f, 52f, 0f, 100f)
			},
			{
				"Tangerine Yellow",
				CIELabFromRGB(100f, 80f, 0f, 100f)
			},
			{
				"Tango Pink",
				CIELabFromRGB(89f, 44f, 48f, 100f)
			},
			{
				"Taupe",
				CIELabFromRGB(28f, 24f, 20f, 100f)
			},
			{
				"Taupe Gray",
				CIELabFromRGB(55f, 52f, 54f, 100f)
			},
			{
				"Tea Green",
				CIELabFromRGB(82f, 94f, 75f, 100f)
			},
			{
				"Tea Rose",
				CIELabFromRGB(97f, 51f, 47f, 100f)
			},
			{
				"Tea Rosier",
				CIELabFromRGB(96f, 76f, 76f, 100f)
			},
			{
				"Teal",
				CIELabFromRGB(0f, 50f, 50f, 100f)
			},
			{
				"Teal Blue",
				CIELabFromRGB(21f, 46f, 53f, 100f)
			},
			{
				"Teal Deer",
				CIELabFromRGB(60f, 90f, 70f, 100f)
			},
			{
				"Teal Green",
				CIELabFromRGB(0f, 51f, 50f, 100f)
			},
			{
				"Telemagenta",
				CIELabFromRGB(81f, 20f, 46f, 100f)
			},
			{
				"Tenné",
				CIELabFromRGB(80f, 34f, 0f, 100f)
			},
			{
				"Terra Cotta",
				CIELabFromRGB(89f, 45f, 36f, 100f)
			},
			{
				"Thulian Pink",
				CIELabFromRGB(87f, 44f, 63f, 100f)
			},
			{
				"Tickle Me Pink",
				CIELabFromRGB(99f, 54f, 67f, 100f)
			},
			{
				"Tiffany Blue",
				CIELabFromRGB(4f, 73f, 71f, 100f)
			},
			{
				"Tiger's Eye",
				CIELabFromRGB(88f, 55f, 24f, 100f)
			},
			{
				"Timberwolf",
				CIELabFromRGB(86f, 84f, 82f, 100f)
			},
			{
				"Titanium Yellow",
				CIELabFromRGB(93f, 90f, 0f, 100f)
			},
			{
				"Tomato",
				CIELabFromRGB(100f, 39f, 28f, 100f)
			},
			{
				"Toolbox",
				CIELabFromRGB(45f, 42f, 75f, 100f)
			},
			{
				"Topaz",
				CIELabFromRGB(100f, 78f, 49f, 100f)
			},
			{
				"Tractor Red",
				CIELabFromRGB(99f, 5f, 21f, 100f)
			},
			{
				"Trolley Grey",
				CIELabFromRGB(50f, 50f, 50f, 100f)
			},
			{
				"Tropical Rain Forest",
				CIELabFromRGB(0f, 46f, 37f, 100f)
			},
			{
				"True Blue",
				CIELabFromRGB(0f, 45f, 81f, 100f)
			},
			{
				"Tufts Blue",
				CIELabFromRGB(25f, 49f, 76f, 100f)
			},
			{
				"Tulip",
				CIELabFromRGB(100f, 53f, 55f, 100f)
			},
			{
				"Tumbleweed",
				CIELabFromRGB(87f, 67f, 53f, 100f)
			},
			{
				"Turkish Rose",
				CIELabFromRGB(71f, 45f, 51f, 100f)
			},
			{
				"Turquoise",
				CIELabFromRGB(25f, 88f, 82f, 100f)
			},
			{
				"Turquoise Blue",
				CIELabFromRGB(0f, 100f, 94f, 100f)
			},
			{
				"Turquoise Green",
				CIELabFromRGB(63f, 84f, 71f, 100f)
			},
			{
				"Tuscan",
				CIELabFromRGB(98f, 84f, 65f, 100f)
			},
			{
				"Tuscan Brown",
				CIELabFromRGB(44f, 31f, 22f, 100f)
			},
			{
				"Tuscan Red",
				CIELabFromRGB(49f, 28f, 28f, 100f)
			},
			{
				"Tuscan Tan",
				CIELabFromRGB(65f, 48f, 36f, 100f)
			},
			{
				"Tuscany",
				CIELabFromRGB(75f, 60f, 60f, 100f)
			},
			{
				"Twilight Lavender",
				CIELabFromRGB(54f, 29f, 42f, 100f)
			},
			{
				"Tyrian Purple",
				CIELabFromRGB(40f, 1f, 24f, 100f)
			},
			{
				"UA Blue",
				CIELabFromRGB(0f, 20f, 67f, 100f)
			},
			{
				"UA Red",
				CIELabFromRGB(85f, 0f, 30f, 100f)
			},
			{
				"Ube",
				CIELabFromRGB(53f, 47f, 76f, 100f)
			},
			{
				"UCLA Blue",
				CIELabFromRGB(33f, 41f, 58f, 100f)
			},
			{
				"UCLA Gold",
				CIELabFromRGB(100f, 70f, 0f, 100f)
			},
			{
				"UFO Green",
				CIELabFromRGB(24f, 82f, 44f, 100f)
			},
			{
				"Ultramarine",
				CIELabFromRGB(7f, 4f, 56f, 100f)
			},
			{
				"Ultramarine Blue",
				CIELabFromRGB(25f, 40f, 96f, 100f)
			},
			{
				"Ultra Pink",
				CIELabFromRGB(100f, 44f, 100f, 100f)
			},
			{
				"Ultra Red",
				CIELabFromRGB(99f, 42f, 52f, 100f)
			},
			{
				"Umber",
				CIELabFromRGB(39f, 32f, 28f, 100f)
			},
			{
				"Unbleached Silk",
				CIELabFromRGB(100f, 87f, 79f, 100f)
			},
			{
				"United Nations Blue",
				CIELabFromRGB(36f, 57f, 90f, 100f)
			},
			{
				"University Of California Gold",
				CIELabFromRGB(72f, 53f, 15f, 100f)
			},
			{
				"Unmellow Yellow",
				CIELabFromRGB(100f, 100f, 40f, 100f)
			},
			{
				"UP Forest Green",
				CIELabFromRGB(0f, 27f, 13f, 100f)
			},
			{
				"UP Maroon",
				CIELabFromRGB(48f, 7f, 7f, 100f)
			},
			{
				"Upsdell Red",
				CIELabFromRGB(68f, 13f, 16f, 100f)
			},
			{
				"Urobilin",
				CIELabFromRGB(88f, 68f, 13f, 100f)
			},
			{
				"USAFA Blue",
				CIELabFromRGB(0f, 31f, 60f, 100f)
			},
			{
				"USC Cardinal",
				CIELabFromRGB(60f, 0f, 0f, 100f)
			},
			{
				"USC Gold",
				CIELabFromRGB(100f, 80f, 0f, 100f)
			},
			{
				"University Of Tennessee Orange",
				CIELabFromRGB(97f, 50f, 0f, 100f)
			},
			{
				"Utah Crimson",
				CIELabFromRGB(83f, 0f, 25f, 100f)
			},
			{
				"Vanilla",
				CIELabFromRGB(95f, 90f, 67f, 100f)
			},
			{
				"Vanilla Ice",
				CIELabFromRGB(95f, 56f, 66f, 100f)
			},
			{
				"Vegas Gold",
				CIELabFromRGB(77f, 70f, 35f, 100f)
			},
			{
				"Venetian Red",
				CIELabFromRGB(78f, 3f, 8f, 100f)
			},
			{
				"Verdigris",
				CIELabFromRGB(26f, 70f, 68f, 100f)
			},
			{
				"Vermilion",
				CIELabFromRGB(89f, 26f, 20f, 100f)
			},
			{
				"Vermilion 2",
				CIELabFromRGB(85f, 22f, 12f, 100f)
			},
			{
				"Veronica",
				CIELabFromRGB(63f, 13f, 94f, 100f)
			},
			{
				"Very Light Azure",
				CIELabFromRGB(45f, 73f, 98f, 100f)
			},
			{
				"Very Light Blue",
				CIELabFromRGB(40f, 40f, 100f, 100f)
			},
			{
				"Very Light Malachite Green",
				CIELabFromRGB(39f, 91f, 53f, 100f)
			},
			{
				"Very Light Tangelo",
				CIELabFromRGB(100f, 69f, 47f, 100f)
			},
			{
				"Very Pale Orange",
				CIELabFromRGB(100f, 87f, 75f, 100f)
			},
			{
				"Very Pale Yellow",
				CIELabFromRGB(100f, 100f, 75f, 100f)
			},
			{
				"Violet",
				CIELabFromRGB(56f, 0f, 100f, 100f)
			},
			{
				"Violet (Color Wheel)",
				CIELabFromRGB(50f, 0f, 100f, 100f)
			},
			{
				"Violet (RYB)",
				CIELabFromRGB(53f, 0f, 69f, 100f)
			},
			{
				"Violet (Web)",
				CIELabFromRGB(93f, 51f, 93f, 100f)
			},
			{
				"Violet-Blue",
				CIELabFromRGB(20f, 29f, 70f, 100f)
			},
			{
				"Violet-Red",
				CIELabFromRGB(97f, 33f, 58f, 100f)
			},
			{
				"Viridian",
				CIELabFromRGB(25f, 51f, 43f, 100f)
			},
			{
				"Viridian Green",
				CIELabFromRGB(0f, 59f, 60f, 100f)
			},
			{
				"Vista Blue",
				CIELabFromRGB(49f, 62f, 85f, 100f)
			},
			{
				"Vivid Amber",
				CIELabFromRGB(80f, 60f, 0f, 100f)
			},
			{
				"Vivid Auburn",
				CIELabFromRGB(57f, 15f, 14f, 100f)
			},
			{
				"Vivid Burgundy",
				CIELabFromRGB(62f, 11f, 21f, 100f)
			},
			{
				"Vivid Cerise",
				CIELabFromRGB(85f, 11f, 51f, 100f)
			},
			{
				"Vivid Cerulean",
				CIELabFromRGB(0f, 67f, 93f, 100f)
			},
			{
				"Vivid Crimson",
				CIELabFromRGB(80f, 0f, 20f, 100f)
			},
			{
				"Vivid Gamboge",
				CIELabFromRGB(100f, 60f, 0f, 100f)
			},
			{
				"Vivid Lime Green",
				CIELabFromRGB(65f, 84f, 3f, 100f)
			},
			{
				"Vivid Malachite",
				CIELabFromRGB(0f, 80f, 20f, 100f)
			},
			{
				"Vivid Mulberry",
				CIELabFromRGB(72f, 5f, 89f, 100f)
			},
			{
				"Vivid Orange",
				CIELabFromRGB(100f, 37f, 0f, 100f)
			},
			{
				"Vivid Orange Peel",
				CIELabFromRGB(100f, 63f, 0f, 100f)
			},
			{
				"Vivid Orchid",
				CIELabFromRGB(80f, 0f, 100f, 100f)
			},
			{
				"Vivid Raspberry",
				CIELabFromRGB(100f, 0f, 42f, 100f)
			},
			{
				"Vivid Red",
				CIELabFromRGB(97f, 5f, 10f, 100f)
			},
			{
				"Vivid Red-Tangelo",
				CIELabFromRGB(87f, 38f, 14f, 100f)
			},
			{
				"Vivid Sky Blue",
				CIELabFromRGB(0f, 80f, 100f, 100f)
			},
			{
				"Vivid Tangelo",
				CIELabFromRGB(94f, 45f, 15f, 100f)
			},
			{
				"Vivid Tangerine",
				CIELabFromRGB(100f, 63f, 54f, 100f)
			},
			{
				"Vivid Vermilion",
				CIELabFromRGB(90f, 38f, 14f, 100f)
			},
			{
				"Vivid Violet",
				CIELabFromRGB(62f, 0f, 100f, 100f)
			},
			{
				"Vivid Yellow",
				CIELabFromRGB(100f, 89f, 1f, 100f)
			},
			{
				"Warm Black",
				CIELabFromRGB(0f, 26f, 26f, 100f)
			},
			{
				"Waterspout",
				CIELabFromRGB(64f, 96f, 98f, 100f)
			},
			{
				"Wenge",
				CIELabFromRGB(39f, 33f, 32f, 100f)
			},
			{
				"Wheat",
				CIELabFromRGB(96f, 87f, 70f, 100f)
			},
			{
				"White",
				CIELabFromRGB(100f, 100f, 100f, 100f)
			},
			{
				"White Smoke",
				CIELabFromRGB(96f, 96f, 96f, 100f)
			},
			{
				"Wild Blue Yonder",
				CIELabFromRGB(64f, 68f, 82f, 100f)
			},
			{
				"Wild Orchid",
				CIELabFromRGB(83f, 44f, 64f, 100f)
			},
			{
				"Wild Strawberry",
				CIELabFromRGB(100f, 26f, 64f, 100f)
			},
			{
				"Wild Watermelon",
				CIELabFromRGB(99f, 42f, 52f, 100f)
			},
			{
				"Willpower Orange",
				CIELabFromRGB(99f, 35f, 0f, 100f)
			},
			{
				"Windsor Tan",
				CIELabFromRGB(65f, 33f, 1f, 100f)
			},
			{
				"Wine",
				CIELabFromRGB(45f, 18f, 22f, 100f)
			},
			{
				"Wine Dregs",
				CIELabFromRGB(40f, 19f, 28f, 100f)
			},
			{
				"Wisteria",
				CIELabFromRGB(79f, 63f, 86f, 100f)
			},
			{
				"Wood Brown",
				CIELabFromRGB(76f, 60f, 42f, 100f)
			},
			{
				"Xanadu",
				CIELabFromRGB(45f, 53f, 47f, 100f)
			},
			{
				"Yale Blue",
				CIELabFromRGB(6f, 30f, 57f, 100f)
			},
			{
				"Yankees Blue",
				CIELabFromRGB(11f, 16f, 25f, 100f)
			},
			{
				"Yellow",
				CIELabFromRGB(100f, 100f, 0f, 100f)
			},
			{
				"Yellow (Crayola)",
				CIELabFromRGB(99f, 91f, 51f, 100f)
			},
			{
				"Yellow (Munsell)",
				CIELabFromRGB(94f, 80f, 0f, 100f)
			},
			{
				"Yellow (NCS)",
				CIELabFromRGB(100f, 83f, 0f, 100f)
			},
			{
				"Yellow (Pantone)",
				CIELabFromRGB(100f, 87f, 0f, 100f)
			},
			{
				"Yellow (Process)",
				CIELabFromRGB(100f, 94f, 0f, 100f)
			},
			{
				"Yellow (RYB)",
				CIELabFromRGB(100f, 100f, 20f, 100f)
			},
			{
				"Yellow-Green",
				CIELabFromRGB(60f, 80f, 20f, 100f)
			},
			{
				"Yellow Orange",
				CIELabFromRGB(100f, 68f, 26f, 100f)
			},
			{
				"Yellow Rose",
				CIELabFromRGB(100f, 94f, 0f, 100f)
			},
			{
				"Zaffre",
				CIELabFromRGB(0f, 8f, 66f, 100f)
			},
			{
				"Zinnwaldite Brown",
				CIELabFromRGB(17f, 9f, 3f, 100f)
			},
			{
				"Zomp",
				CIELabFromRGB(22f, 65f, 56f, 100f)
			}
		};

		private static bool approx(float lhs, float rhs)
		{
			return Mathf.Abs(lhs - rhs) < Mathf.Epsilon;
		}

		public static pb_XYZ_Color RGBToXYZ(Color col)
		{
			return RGBToXYZ(col.r, col.g, col.b);
		}

		public static pb_XYZ_Color RGBToXYZ(float r, float g, float b)
		{
			r = ((!(r > 0.04045f)) ? (r / 12.92f) : Mathf.Pow((r + 0.055f) / 1.055f, 2.4f));
			g = ((!(g > 0.04045f)) ? (g / 12.92f) : Mathf.Pow((g + 0.055f) / 1.055f, 2.4f));
			b = ((!(b > 0.04045f)) ? (b / 12.92f) : Mathf.Pow((b + 0.055f) / 1.055f, 2.4f));
			r *= 100f;
			g *= 100f;
			b *= 100f;
			float x = r * 0.4124f + g * 0.3576f + b * 0.1805f;
			float y = r * 0.2126f + g * 0.7152f + b * 0.0722f;
			float z = r * 0.0193f + g * 0.1192f + b * 0.9505f;
			return new pb_XYZ_Color(x, y, z);
		}

		public static pb_CIE_Lab_Color XYZToCIE_Lab(pb_XYZ_Color xyz)
		{
			float num = xyz.x / 95.047f;
			float num2 = xyz.y / 100f;
			float num3 = xyz.z / 108.883f;
			num = ((!(num > 0.008856f)) ? (7.787f * num + 0.13793103f) : Mathf.Pow(num, 1f / 3f));
			num2 = ((!(num2 > 0.008856f)) ? (7.787f * num2 + 0.13793103f) : Mathf.Pow(num2, 1f / 3f));
			num3 = ((!(num3 > 0.008856f)) ? (7.787f * num3 + 0.13793103f) : Mathf.Pow(num3, 1f / 3f));
			float l = 116f * num2 - 16f;
			float a = 500f * (num - num2);
			float b = 200f * (num2 - num3);
			return new pb_CIE_Lab_Color(l, a, b);
		}

		public static float DeltaE(pb_CIE_Lab_Color lhs, pb_CIE_Lab_Color rhs)
		{
			return Mathf.Sqrt(Mathf.Pow(lhs.L - rhs.L, 2f) + Mathf.Pow(lhs.a - rhs.a, 2f) + Mathf.Pow(lhs.b - rhs.b, 2f));
		}

		public static Color HSVtoRGB(pb_HsvColor hsv)
		{
			return HSVtoRGB(hsv.h, hsv.s, hsv.v);
		}

		public static Color HSVtoRGB(float h, float s, float v)
		{
			if (s == 0f)
			{
				return new Color(v, v, v, 1f);
			}
			h /= 60f;
			int num = (int)Mathf.Floor(h);
			float num2 = h - (float)num;
			float num3 = v * (1f - s);
			float num4 = v * (1f - s * num2);
			float num5 = v * (1f - s * (1f - num2));
			float r;
			float g;
			float b;
			switch (num)
			{
			case 0:
				r = v;
				g = num5;
				b = num3;
				break;
			case 1:
				r = num4;
				g = v;
				b = num3;
				break;
			case 2:
				r = num3;
				g = v;
				b = num5;
				break;
			case 3:
				r = num3;
				g = num4;
				b = v;
				break;
			case 4:
				r = num5;
				g = num3;
				b = v;
				break;
			default:
				r = v;
				g = num3;
				b = num4;
				break;
			}
			return new Color(r, g, b, 1f);
		}

		public static pb_HsvColor RGBtoHSV(Color color)
		{
			float r = color.r;
			float b = color.b;
			float g = color.g;
			float num = Mathf.Min(Mathf.Min(r, g), b);
			float num2 = Mathf.Max(Mathf.Max(r, g), b);
			float v = num2;
			float num3 = num2 - num;
			float s;
			float num4;
			if (num2 != 0f)
			{
				s = num3 / num2;
				if (!approx(r, num2))
				{
					num4 = ((!approx(g, num2)) ? (4f + (r - g) / num3) : (2f + (b - r) / num3));
				}
				else
				{
					num4 = (g - b) / num3;
					if (float.IsNaN(num4))
					{
						num4 = 0f;
					}
				}
				num4 *= 60f;
				if (num4 < 0f)
				{
					num4 += 360f;
				}
				return new pb_HsvColor(num4, s, v);
			}
			s = 0f;
			num4 = 0f;
			return new pb_HsvColor(num4, s, v);
		}

		public static string GetColorName(Color InColor)
		{
			pb_CIE_Lab_Color lhs = pb_CIE_Lab_Color.FromRGB(InColor);
			string result = "Unknown";
			float num = float.PositiveInfinity;
			foreach (KeyValuePair<string, pb_CIE_Lab_Color> item in ColorNameLookup)
			{
				float num2 = Mathf.Abs(DeltaE(lhs, item.Value));
				if (num2 < num)
				{
					num = num2;
					result = item.Key;
				}
			}
			return result;
		}

		private static pb_CIE_Lab_Color CIELabFromRGB(float R, float G, float B, float Scale)
		{
			float num = 1f / Scale;
			pb_XYZ_Color xyz = pb_XYZ_Color.FromRGB(R * num, G * num, B * num);
			return pb_CIE_Lab_Color.FromXYZ(xyz);
		}
	}
}
public static class pb_Constant
{
	public const string PRODUCT_NAME = "ProBuilder";

	public const char DEGREE_SYMBOL = '°';

	public const char CMD_SUPER = '⌘';

	public const char CMD_SHIFT = '⇧';

	public const char CMD_OPTION = '⌥';

	public const char CMD_ALT = '⎇';

	public const char CMD_DELETE = '⌫';

	public const string pbDefaultEditLevel = "pbDefaultEditLevel";

	public const string pbDefaultSelectionMode = "pbDefaultSelectionMode";

	public const string pbHandleAlignment = "pbHandleAlignment";

	public const string pbVertexColorTool = "pbVertexColorTool";

	public const string pbToolbarLocation = "pbToolbarLocation";

	public const string pbDefaultEntity = "pbDefaultEntity";

	public const string pbDefaultFaceColor = "pbDefaultFaceColor";

	public const string pbDefaultEdgeColor = "pbDefaultEdgeColor";

	public const string pbDefaultSelectedVertexColor = "pbDefaultSelectedVertexColor";

	public const string pbDefaultVertexColor = "pbDefaultVertexColor";

	public const string pbDefaultOpenInDockableWindow = "pbDefaultOpenInDockableWindow";

	public const string pbEditorPrefVersion = "pbEditorPrefVersion";

	public const string pbEditorShortcutsVersion = "pbEditorShortcutsVersion";

	public const string pbDefaultCollider = "pbDefaultCollider";

	public const string pbForceConvex = "pbForceConvex";

	public const string pbVertexColorPrefs = "pbVertexColorPrefs";

	public const string pbShowEditorNotifications = "pbShowEditorNotifications";

	public const string pbDragCheckLimit = "pbDragCheckLimit";

	public const string pbForceVertexPivot = "pbForceVertexPivot";

	public const string pbForceGridPivot = "pbForceGridPivot";

	public const string pbManifoldEdgeExtrusion = "pbManifoldEdgeExtrusion";

	public const string pbPerimeterEdgeBridgeOnly = "pbPerimeterEdgeBridgeOnly";

	public const string pbPBOSelectionOnly = "pbPBOSelectionOnly";

	public const string pbCloseShapeWindow = "pbCloseShapeWindow";

	public const string pbUVEditorFloating = "pbUVEditorFloating";

	public const string pbUVMaterialPreview = "pbUVMaterialPreview";

	public const string pbShowSceneToolbar = "pbShowSceneToolbar";

	public const string pbNormalizeUVsOnPlanarProjection = "pbNormalizeUVsOnPlanarProjection";

	public const string pbStripProBuilderOnBuild = "pbStripProBuilderOnBuild";

	public const string pbDisableAutoUV2Generation = "pbDisableAutoUV2Generation";

	public const string pbShowSceneInfo = "pbShowSceneInfo";

	public const string pbEnableBackfaceSelection = "pbEnableBackfaceSelection";

	public const string pbVertexPaletteDockable = "pbVertexPaletteDockable";

	public const string pbExtrudeAsGroup = "pbExtrudeAsGroup";

	public const string pbUniqueModeShortcuts = "pbUniqueModeShortcuts";

	public const string pbMaterialEditorFloating = "pbMaterialEditorFloating";

	public const string pbShapeWindowFloating = "pbShapeWindowFloating";

	public const string pbIconGUI = "pbIconGUI";

	public const string pbShiftOnlyTooltips = "pbShiftOnlyTooltips";

	public const string pbDrawAxisLines = "pbDrawAxisLines";

	public const string pbCollapseVertexToFirst = "pbCollapseVertexToFirst";

	public const string pbMeshesAreAssets = "pbMeshesAreAssets";

	public const string pbElementSelectIsHamFisted = "pbElementSelectIsHamFisted";

	public const string pbFillHoleSelectsEntirePath = "pbFillHoleSelectsEntirePath";

	public const string pbDetachToNewObject = "pbDetachToNewObject";

	public const string pbPreserveFaces = "pbPreserveFaces";

	public const string pbDragSelectWholeElement = "pbDragSelectWholeElement";

	public const string pbDragSelectMode = "pbDragSelectMode";

	public const string pbShadowCastingMode = "pbShadowCastingMode";

	public const string pbVertexHandleSize = "pbVertexHandleSize";

	public const string pbUVGridSnapValue = "pbUVGridSnapValue";

	public const string pbUVWeldDistance = "pbUVWeldDistance";

	public const string pbWeldDistance = "pbWeldDistance";

	public const string pbExtrudeDistance = "pbExtrudeDistance";

	public const string pbBevelAmount = "pbBevelAmount";

	public const string pbEdgeSubdivisions = "pbEdgeSubdivisions";

	public const string pbDefaultShortcuts = "pbDefaultShortcuts";

	public const string pbDefaultMaterial = "pbDefaultMaterial";

	public const string pbGrowSelectionUsingAngle = "pbGrowSelectionUsingAngle";

	public const string pbGrowSelectionAngle = "pbGrowSelectionAngle";

	public const string pbGrowSelectionAngleIterative = "pbGrowSelectionAngleIterative";

	public const string pbShowDetail = "pbShowDetail";

	public const string pbShowOccluder = "pbShowOccluder";

	public const string pbShowMover = "pbShowMover";

	public const string pbShowCollider = "pbShowCollider";

	public const string pbShowTrigger = "pbShowTrigger";

	public const string pbShowNoDraw = "pbShowNoDraw";

	public const int MENU_ABOUT = 0;

	public const int MENU_EDITOR = 100;

	public const int MENU_SELECTION = 200;

	public const int MENU_GEOMETRY = 200;

	public const int MENU_ACTIONS = 300;

	public const int MENU_MATERIAL_COLORS = 400;

	public const int MENU_VERTEX_COLORS = 400;

	public const int MENU_REPAIR = 600;

	public const int MENU_MISC = 600;

	public const int MENU_EXPORT = 800;

	public const int MAX_VERTEX_COUNT = 65000;

	public static readonly HideFlags EDITOR_OBJECT_HIDE_FLAGS = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;

	private static Material _defaultMaterial = null;

	private static Material _facePickerMaterial;

	private static Material _vertexPickerMaterial;

	private static Shader _selectionPickerShader = null;

	private static Material _UnityDefaultDiffuse = null;

	private static Material _UnlitVertexColorMaterial;

	public static readonly Rect RectZero = new Rect(0f, 0f, 0f, 0f);

	public static Color ProBuilderBlue = new Color(0f, 0.682f, 0.937f, 1f);

	public static Color ProBuilderLightGray = new Color(0.35f, 0.35f, 0.35f, 0.4f);

	public static Color ProBuilderDarkGray = new Color(0.1f, 0.1f, 0.1f, 0.3f);

	public static Vector3[] VERTICES_CUBE = new Vector3[8]
	{
		new Vector3(-0.5f, -0.5f, 0.5f),
		new Vector3(0.5f, -0.5f, 0.5f),
		new Vector3(0.5f, -0.5f, -0.5f),
		new Vector3(-0.5f, -0.5f, -0.5f),
		new Vector3(-0.5f, 0.5f, 0.5f),
		new Vector3(0.5f, 0.5f, 0.5f),
		new Vector3(0.5f, 0.5f, -0.5f),
		new Vector3(-0.5f, 0.5f, -0.5f)
	};

	public static int[] TRIANGLES_CUBE = new int[24]
	{
		0, 1, 4, 5, 1, 2, 5, 6, 2, 3,
		6, 7, 3, 0, 7, 4, 4, 5, 7, 6,
		3, 2, 0, 1
	};

	public static Material DefaultMaterial
	{
		get
		{
			if (_defaultMaterial == null)
			{
				_defaultMaterial = (Material)Resources.Load("Materials/Default_Prototype", typeof(Material));
				if (_defaultMaterial == null)
				{
					_defaultMaterial = UnityDefaultDiffuse;
				}
			}
			return _defaultMaterial;
		}
	}

	public static Material FacePickerMaterial
	{
		get
		{
			if (_facePickerMaterial == null)
			{
				_facePickerMaterial = Resources.Load<Material>("Materials/FacePicker");
				_facePickerMaterial.shader = Shader.Find("Hidden/ProBuilder/FacePicker");
			}
			return _facePickerMaterial;
		}
	}

	public static Material VertexPickerMaterial
	{
		get
		{
			if (_vertexPickerMaterial == null)
			{
				_vertexPickerMaterial = Resources.Load<Material>("Materials/VertexPicker");
				_vertexPickerMaterial.shader = Shader.Find("Hidden/ProBuilder/VertexPicker");
			}
			return _vertexPickerMaterial;
		}
	}

	public static Shader SelectionPickerShader
	{
		get
		{
			if (_selectionPickerShader == null)
			{
				_selectionPickerShader = Shader.Find("Hidden/ProBuilder/SelectionPicker");
			}
			return _selectionPickerShader;
		}
	}

	public static Material TriggerMaterial => (Material)Resources.Load("Materials/Trigger", typeof(Material));

	public static Material ColliderMaterial => (Material)Resources.Load("Materials/Collider", typeof(Material));

	public static Material NoDrawMaterial => (Material)Resources.Load("Materials/NoDraw", typeof(Material));

	public static Material UnityDefaultDiffuse
	{
		get
		{
			if (_UnityDefaultDiffuse == null)
			{
				GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
				_UnityDefaultDiffuse = gameObject.GetComponent<MeshRenderer>().sharedMaterial;
				UnityEngine.Object.DestroyImmediate(gameObject);
			}
			return _UnityDefaultDiffuse;
		}
	}

	public static Material UnlitVertexColor
	{
		get
		{
			if (_UnlitVertexColorMaterial == null)
			{
				_UnlitVertexColorMaterial = (Material)Resources.Load("Materials/UnlitVertexColor", typeof(Material));
			}
			return _UnlitVertexColorMaterial;
		}
	}
}
[AddComponentMenu("")]
public class pb_DummyScript : MonoBehaviour
{
}
namespace ProBuilder2.Common
{
	[Serializable]
	public class pb_Edge : IEquatable<pb_Edge>
	{
		public int x;

		public int y;

		public pb_Edge()
		{
		}

		public pb_Edge(int _x, int _y)
		{
			x = _x;
			y = _y;
		}

		public pb_Edge(pb_Edge edge)
		{
			x = edge.x;
			y = edge.y;
		}

		public bool IsValid()
		{
			if (x > -1 && y > -1)
			{
				return x != y;
			}
			return false;
		}

		public override string ToString()
		{
			return "[" + x + ", " + y + "]";
		}

		public bool Equals(pb_Edge edge)
		{
			if (edge != null)
			{
				if (x != edge.x || y != edge.y)
				{
					if (x == edge.y)
					{
						return y == edge.x;
					}
					return false;
				}
				return true;
			}
			return false;
		}

		public override bool Equals(object b)
		{
			return Equals(b as pb_Edge);
		}

		public override int GetHashCode()
		{
			int num = 27;
			num = num * 29 + ((x < y) ? x : y);
			return num * 29 + ((x < y) ? y : x);
		}

		public static pb_Edge operator +(pb_Edge a, pb_Edge b)
		{
			return new pb_Edge(a.x + b.x, a.y + b.y);
		}

		public static pb_Edge operator -(pb_Edge a, pb_Edge b)
		{
			return new pb_Edge(a.x - b.x, a.y - b.y);
		}

		public static pb_Edge operator +(pb_Edge a, int b)
		{
			return new pb_Edge(a.x + b, a.y + b);
		}

		public static pb_Edge operator -(pb_Edge a, int b)
		{
			return new pb_Edge(a.x - b, a.y - b);
		}

		public int[] ToArray()
		{
			return new int[2] { x, y };
		}

		public bool Equals(pb_Edge b, Dictionary<int, int> lookup)
		{
			int num = lookup[x];
			int num2 = lookup[y];
			int num3 = lookup[b.x];
			int num4 = lookup[b.y];
			if (num != num3 || num2 != num4)
			{
				if (num == num4)
				{
					return num2 == num3;
				}
				return false;
			}
			return true;
		}

		public bool Contains(int a)
		{
			if (x != a)
			{
				return y == a;
			}
			return true;
		}

		public bool Contains(pb_Edge b)
		{
			if (x != b.x && y != b.x && x != b.y)
			{
				return y == b.x;
			}
			return true;
		}

		public bool Contains(int a, pb_IntArray[] sharedIndices)
		{
			int num = sharedIndices.IndexOf(a);
			if (Array.IndexOf(sharedIndices[num], x) <= -1)
			{
				return Array.IndexOf(sharedIndices[num], y) > -1;
			}
			return true;
		}

		public static pb_Edge[] GetUniversalEdges(pb_Edge[] edges, Dictionary<int, int> sharedIndicesLookup)
		{
			pb_Edge[] array = new pb_Edge[edges.Length];
			for (int i = 0; i < edges.Length; i++)
			{
				array[i] = new pb_Edge(sharedIndicesLookup[edges[i].x], sharedIndicesLookup[edges[i].y]);
			}
			return array;
		}

		public static pb_Edge[] GetUniversalEdges(pb_Edge[] edges, pb_IntArray[] sharedIndices)
		{
			return GetUniversalEdges(edges, sharedIndices.ToDictionary());
		}

		public static pb_Edge GetLocalEdgeFast(pb_Edge edge, pb_IntArray[] sharedIndices)
		{
			return new pb_Edge(sharedIndices[edge.x][0], sharedIndices[edge.y][0]);
		}

		public static bool ValidateEdge(pb_Object pb, pb_Edge edge, out pb_Tuple<pb_Face, pb_Edge> validEdge)
		{
			pb_Face[] faces = pb.faces;
			pb_IntArray[] sharedIndices = pb.sharedIndices;
			pb_Edge pb_Edge2 = new pb_Edge(sharedIndices.IndexOf(edge.x), sharedIndices.IndexOf(edge.y));
			int index_a = -1;
			int index_a2 = -1;
			int index_b = -1;
			int index_b2 = -1;
			for (int i = 0; i < faces.Length; i++)
			{
				if (faces[i].distinctIndices.ContainsMatch(sharedIndices[pb_Edge2.x].array, out index_a, out index_b) && faces[i].distinctIndices.ContainsMatch(sharedIndices[pb_Edge2.y].array, out index_a2, out index_b2))
				{
					int num = faces[i].distinctIndices[index_a];
					int num2 = faces[i].distinctIndices[index_a2];
					validEdge = new pb_Tuple<pb_Face, pb_Edge>(faces[i], new pb_Edge(num, num2));
					return true;
				}
			}
			validEdge = null;
			return false;
		}

		public static List<pb_Edge> ValidateEdges(pb_Object pb, pb_Edge[] edges)
		{
			pb_Face[] faces = pb.faces;
			Dictionary<int, int> dictionary = pb.sharedIndices.ToDictionary();
			HashSet<pb_EdgeLookup> hashSet = new HashSet<pb_EdgeLookup>(pb_EdgeLookup.GetEdgeLookup(edges, dictionary));
			List<pb_Edge> list = new List<pb_Edge>();
			bool flag = false;
			for (int i = 0; i < faces.Length; i++)
			{
				if (flag)
				{
					break;
				}
				pb_Edge[] edges2 = faces[i].edges;
				for (int j = 0; j < edges2.Length; j++)
				{
					if (flag)
					{
						break;
					}
					pb_EdgeLookup pb_EdgeLookup2 = new pb_EdgeLookup(dictionary[edges2[j].x], dictionary[edges2[j].y], edges2[j].x, edges2[j].y);
					if (hashSet.Contains(pb_EdgeLookup2))
					{
						hashSet.Remove(pb_EdgeLookup2);
						flag = hashSet.Count < 1;
						list.Add(pb_EdgeLookup2.local);
					}
				}
			}
			return list;
		}

		public static pb_Edge[] GetLocalEdges_Fast(pb_Edge[] edges, pb_IntArray[] sharedIndices)
		{
			pb_Edge[] array = new pb_Edge[edges.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new pb_Edge(sharedIndices[edges[i].x][0], sharedIndices[edges[i].y][0]);
			}
			return array;
		}

		public static pb_Edge[] AllEdges(pb_Face[] faces)
		{
			List<pb_Edge> list = new List<pb_Edge>();
			foreach (pb_Face pb_Face2 in faces)
			{
				list.AddRange(pb_Face2.edges);
			}
			return list.ToArray();
		}

		public static bool ContainsDuplicateFast(pb_Edge[] edges, pb_Edge edge)
		{
			int num = 0;
			for (int i = 0; i < edges.Length; i++)
			{
				if (edges[i].Equals(edge))
				{
					num++;
				}
			}
			return num > 1;
		}

		public static Vector3[] VerticesWithEdges(pb_Edge[] edges, Vector3[] vertices)
		{
			Vector3[] array = new Vector3[edges.Length * 2];
			int num = 0;
			for (int i = 0; i < edges.Length; i++)
			{
				ref Vector3 reference = ref array[num++];
				reference = vertices[edges[i].x];
				ref Vector3 reference2 = ref array[num++];
				reference2 = vertices[edges[i].y];
			}
			return array;
		}

		public static pb_Edge[] GetPerimeterEdges(pb_Edge[] edges)
		{
			int[] count = pbUtil.FilledArray(0, edges.Length);
			for (int i = 0; i < edges.Length - 1; i++)
			{
				for (int j = i + 1; j < edges.Length; j++)
				{
					if (edges[i].Equals(edges[j]))
					{
						count[i]++;
						count[j]++;
					}
				}
			}
			return edges.Where((pb_Edge val, int index) => count[index] < 1).ToArray();
		}
	}
	public static class EdgeExtensions
	{
		public static bool ContainsDuplicate(this List<pb_Edge> edges, pb_Edge edge, Dictionary<int, int> lookup)
		{
			int num = 0;
			for (int i = 0; i < edges.Count; i++)
			{
				if (edges[i].Equals(edge, lookup) && ++num > 1)
				{
					return true;
				}
			}
			return false;
		}

		public static bool Contains(this pb_Edge[] edges, pb_Edge edge)
		{
			for (int i = 0; i < edges.Length; i++)
			{
				if (edges[i].Equals(edge))
				{
					return true;
				}
			}
			return false;
		}

		public static bool Contains(this pb_Edge[] edges, int x, int y)
		{
			for (int i = 0; i < edges.Length; i++)
			{
				if ((x == edges[i].x && y == edges[i].y) || (x == edges[i].y && y == edges[i].x))
				{
					return true;
				}
			}
			return false;
		}

		public static IEnumerable<pb_Edge> DistinctCommon(this IEnumerable<pb_Edge> edges, Dictionary<int, int> lookup)
		{
			IEnumerable<pb_EdgeLookup> source = edges.Select((pb_Edge x) => new pb_EdgeLookup(new pb_Edge(lookup[x.x], lookup[x.y]), x));
			source = source.Distinct();
			return source.Select((pb_EdgeLookup x) => x.local);
		}

		public static int IndexOf(this IList<pb_Edge> edges, pb_Edge edge, Dictionary<int, int> lookup)
		{
			for (int i = 0; i < edges.Count; i++)
			{
				if (edges[i].Equals(edge, lookup))
				{
					return i;
				}
			}
			return -1;
		}

		public static List<int> ToIntList(this List<pb_Edge> edges)
		{
			List<int> list = new List<int>();
			foreach (pb_Edge edge in edges)
			{
				list.Add(edge.x);
				list.Add(edge.y);
			}
			return list;
		}

		public static int[] AllTriangles(this pb_Edge[] edges)
		{
			int[] array = new int[edges.Length * 2];
			int num = 0;
			for (int i = 0; i < edges.Length; i++)
			{
				array[num++] = edges[i].x;
				array[num++] = edges[i].y;
			}
			return array;
		}

		public static List<int> AllTriangles(this List<pb_Edge> edges)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < edges.Count; i++)
			{
				list.Add(edges[i].x);
				list.Add(edges[i].y);
			}
			return list;
		}
	}
	public class pb_MonoBehaviourSingleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		private static MonoBehaviour _instance;

		public static T instance
		{
			get
			{
				if (nullableInstance == null)
				{
					GameObject gameObject = new GameObject();
					gameObject.name = typeof(T).ToString();
					_instance = gameObject.AddComponent<T>();
				}
				return (T)_instance;
			}
		}

		public static T nullableInstance
		{
			get
			{
				if (_instance == null)
				{
					T[] array = Resources.FindObjectsOfTypeAll<T>();
					if (array != null && array.Length > 0)
					{
						_instance = array[0];
						for (int i = 1; i < array.Length; i++)
						{
							UnityEngine.Object.DestroyImmediate(array[i]);
						}
					}
				}
				return (T)_instance;
			}
		}

		public static bool Valid()
		{
			return nullableInstance != null;
		}

		public virtual void Awake()
		{
			if (_instance == null)
			{
				_instance = this;
			}
			else
			{
				UnityEngine.Object.Destroy(this);
			}
		}

		public virtual void OnEnable()
		{
			_instance = this;
		}
	}
	[Serializable]
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	public class pb_ElementGraphics : pb_MonoBehaviourSingleton<pb_ElementGraphics>
	{
		private const string FACE_SHADER = "Hidden/ProBuilder/FaceHighlight";

		private const string EDGE_SHADER = "Hidden/ProBuilder/FaceHighlight";

		private const string VERT_SHADER = "Hidden/ProBuilder/pb_VertexShader";

		private const string PREVIEW_OBJECT_NAME = "ProBuilderSelectionGameObject";

		private const string WIREFRAME_OBJECT_NAME = "ProBuilderWireframeGameObject";

		private const string SELECTION_MESH_NAME = "ProBuilderEditorSelectionMesh";

		private const string WIREFRAME_MESH_NAME = "ProBuilderEditorWireframeMesh";

		private static float vertexHandleSize = 0.03f;

		[SerializeField]
		private Material faceMaterial;

		[SerializeField]
		private Material vertexMaterial;

		[SerializeField]
		private Material wireframeMaterial;

		[SerializeField]
		private pb_MeshRenderer pbRenderer;

		[SerializeField]
		private Color faceSelectionColor = new Color(0f, 1f, 1f, 0.275f);

		[SerializeField]
		private Color edgeSelectionColor = new Color(0f, 0.6f, 0.7f, 1f);

		[SerializeField]
		private Color vertSelectionColor = new Color(1f, 0.2f, 0.2f, 1f);

		[SerializeField]
		private Color wireframeColor = new Color(0.53f, 0.65f, 0.84f, 1f);

		[SerializeField]
		private Color vertexDotColor = new Color(0.8f, 0.8f, 0.8f, 1f);

		private static readonly HideFlags PB_EDITOR_GRAPHIC_HIDE_FLAGS = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;

		private pb_ObjectPool<pb_Renderable> pool;

		public override void Awake()
		{
			base.Awake();
			base.gameObject.hideFlags = HideFlags.HideAndDontSave;
			pbRenderer = base.gameObject.AddComponent<pb_MeshRenderer>();
			wireframeMaterial = CreateMaterial(Shader.Find("Hidden/ProBuilder/FaceHighlight"), "WIREFRAME_MATERIAL");
			wireframeMaterial.SetColor("_Color", wireframeColor);
			faceMaterial = CreateMaterial(Shader.Find("Hidden/ProBuilder/FaceHighlight"), "FACE_SELECTION_MATERIAL");
			faceMaterial.SetColor("_Color", faceSelectionColor);
			vertexMaterial = CreateMaterial(Shader.Find("Hidden/ProBuilder/pb_VertexShader"), "VERTEX_BILLBOARD_MATERIAL");
			vertexMaterial.SetColor("_Color", vertexDotColor);
			vertexMaterial.SetFloat("_Scale", vertexHandleSize * 4f);
		}

		private void OnDestroy()
		{
			UnityEngine.Object.DestroyImmediate(faceMaterial);
			UnityEngine.Object.DestroyImmediate(vertexMaterial);
			UnityEngine.Object.DestroyImmediate(wireframeMaterial);
		}

		public override void OnEnable()
		{
			base.OnEnable();
			pool = new pb_ObjectPool<pb_Renderable>(0, 8, pb_Renderable.CreateInstance, pb_Renderable.DestroyInstance);
		}

		private void OnDisable()
		{
			pool.Empty();
		}

		private Material CreateMaterial(Shader shader, string materialName)
		{
			Material material = new Material(shader);
			material.name = materialName;
			material.hideFlags = PB_EDITOR_GRAPHIC_HIDE_FLAGS;
			return material;
		}

		public void LoadPrefs(Hashtable prefs)
		{
			faceSelectionColor = (Color)prefs["pbDefaultFaceColor"];
			edgeSelectionColor = (Color)prefs["pbDefaultEdgeColor"];
			vertSelectionColor = (Color)prefs["pbDefaultSelectedVertexColor"];
			vertexDotColor = (Color)prefs["pbDefaultVertexColor"];
			vertexHandleSize = (float)prefs["pbVertexHandleSize"];
			wireframeMaterial.SetColor("_Color", wireframeColor);
			faceMaterial.SetColor("_Color", faceSelectionColor);
			vertexMaterial.SetColor("_Color", vertexDotColor);
			vertexMaterial.SetFloat("_Scale", vertexHandleSize * 4f);
		}

		public void RebuildGraphics(pb_Object[] selection, pb_Edge[][] universalEdgesDistinct, EditLevel editLevel, SelectMode selectionMode)
		{
			if (pool == null)
			{
				return;
			}
			foreach (pb_Renderable renderable in pbRenderer.renderables)
			{
				pool.Put(renderable);
			}
			pbRenderer.renderables.Clear();
			wireframeMaterial.SetColor("_Color", (selectionMode == SelectMode.Edge && editLevel == EditLevel.Geometry) ? edgeSelectionColor : wireframeColor);
			for (int i = 0; i < selection.Length; i++)
			{
				pbRenderer.renderables.Add(BuildEdgeMesh(selection[i], universalEdgesDistinct[i]));
			}
			if (editLevel != EditLevel.Geometry)
			{
				return;
			}
			switch (selectionMode)
			{
			case SelectMode.Face:
				foreach (pb_Object pb2 in selection)
				{
					pbRenderer.renderables.Add(BuildFaceMesh(pb2));
				}
				break;
			case SelectMode.Vertex:
				foreach (pb_Object pb in selection)
				{
					pbRenderer.renderables.Add(BuildVertexMesh(pb));
				}
				break;
			case SelectMode.Edge:
				break;
			}
		}

		private pb_Renderable BuildFaceMesh(pb_Object pb)
		{
			int[] indices = pb_Face.AllTriangles(pb.SelectedFaces);
			Vector3[] array = pb.vertices.ValuesWithIndices(indices);
			pb_Renderable pb_Renderable2 = pool.Get();
			pb_Renderable2.name = "Faces Renderable";
			pb_Renderable2.transform = pb.transform;
			pb_Renderable2.materials = new Material[1] { faceMaterial };
			pb_Renderable2.mesh.Clear();
			pb_Renderable2.mesh.vertices = array;
			pb_Renderable2.mesh.normals = array;
			pb_Renderable2.mesh.uv = new Vector2[array.Length];
			pb_Renderable2.mesh.triangles = SequentialTriangles(array.Length);
			return pb_Renderable2;
		}

		private pb_Renderable BuildVertexMesh(pb_Object pb)
		{
			int num = 0;
			Vector3[] array = new Vector3[pb.sharedIndices.Length];
			HashSet<int> hashSet = new HashSet<int>(pb.sharedIndices.GetCommonIndices(pb.SelectedTriangles));
			for (int i = 0; i < array.Length; i++)
			{
				ref Vector3 reference = ref array[i];
				reference = pb.vertices[pb.sharedIndices[i][0]];
			}
			Vector3[] array2 = new Vector3[array.Length * 4];
			Vector3[] array3 = new Vector3[array.Length * 4];
			Vector2[] array4 = new Vector2[array.Length * 4];
			Vector2[] array5 = new Vector2[array.Length * 4];
			Color[] array6 = new Color[array.Length * 4];
			int[] array7 = new int[array.Length * 6];
			int num2 = 0;
			int num3 = 0;
			Vector3 up = Vector3.up;
			Vector3 right = Vector3.right;
			for (int j = 0; j < array.Length; j++)
			{
				ref Vector3 reference2 = ref array2[num3];
				reference2 = array[j];
				ref Vector3 reference3 = ref array2[num3 + 1];
				reference3 = array[j];
				ref Vector3 reference4 = ref array2[num3 + 2];
				reference4 = array[j];
				ref Vector3 reference5 = ref array2[num3 + 3];
				reference5 = array[j];
				ref Vector2 reference6 = ref array4[num3];
				reference6 = Vector3.zero;
				ref Vector2 reference7 = ref array4[num3 + 1];
				reference7 = Vector3.right;
				ref Vector2 reference8 = ref array4[num3 + 2];
				reference8 = Vector3.up;
				ref Vector2 reference9 = ref array4[num3 + 3];
				reference9 = Vector3.one;
				ref Vector2 reference10 = ref array5[num3];
				reference10 = -up - right;
				ref Vector2 reference11 = ref array5[num3 + 1];
				reference11 = -up + right;
				ref Vector2 reference12 = ref array5[num3 + 2];
				reference12 = up - right;
				ref Vector2 reference13 = ref array5[num3 + 3];
				reference13 = up + right;
				ref Vector3 reference14 = ref array3[num3];
				reference14 = Vector3.forward;
				ref Vector3 reference15 = ref array3[num3 + 1];
				reference15 = Vector3.forward;
				ref Vector3 reference16 = ref array3[num3 + 2];
				reference16 = Vector3.forward;
				ref Vector3 reference17 = ref array3[num3 + 3];
				reference17 = Vector3.forward;
				array7[num2] = num3 + num;
				array7[num2 + 1] = num3 + 1 + num;
				array7[num2 + 2] = num3 + 2 + num;
				array7[num2 + 3] = num3 + 1 + num;
				array7[num2 + 4] = num3 + 3 + num;
				array7[num2 + 5] = num3 + 2 + num;
				if (hashSet.Contains(j))
				{
					ref Color reference18 = ref array6[num3];
					reference18 = vertSelectionColor;
					ref Color reference19 = ref array6[num3 + 1];
					reference19 = vertSelectionColor;
					ref Color reference20 = ref array6[num3 + 2];
					reference20 = vertSelectionColor;
					ref Color reference21 = ref array6[num3 + 3];
					reference21 = vertSelectionColor;
				}
				else
				{
					ref Color reference22 = ref array6[num3];
					reference22 = vertexDotColor;
					ref Color reference23 = ref array6[num3 + 1];
					reference23 = vertexDotColor;
					ref Color reference24 = ref array6[num3 + 2];
					reference24 = vertexDotColor;
					ref Color reference25 = ref array6[num3 + 3];
					reference25 = vertexDotColor;
				}
				num3 += 4;
				num2 += 6;
			}
			pb_Renderable pb_Renderable2 = pool.Get();
			pb_Renderable2.name = "Vertex Renderable";
			pb_Renderable2.transform = pb.transform;
			pb_Renderable2.materials = new Material[1] { vertexMaterial };
			pb_Renderable2.mesh.Clear();
			pb_Renderable2.mesh.vertices = array2;
			pb_Renderable2.mesh.normals = array3;
			pb_Renderable2.mesh.uv = array4;
			pb_Renderable2.mesh.uv2 = array5;
			pb_Renderable2.mesh.colors = array6;
			pb_Renderable2.mesh.triangles = array7;
			return pb_Renderable2;
		}

		private pb_Renderable BuildEdgeMesh(pb_Object pb, pb_Edge[] universalEdgesDistinct)
		{
			Vector3[] vertices = pb.vertices;
			pb_IntArray[] sharedIndices = pb.sharedIndices;
			int num = System.Math.Min(universalEdgesDistinct.Count() * 2, 65000);
			Vector3[] array = new Vector3[num];
			int num2 = 0;
			for (int i = 0; i < num / 2; i++)
			{
				ref Vector3 reference = ref array[num2++];
				reference = vertices[sharedIndices[universalEdgesDistinct[i].x][0]];
				ref Vector3 reference2 = ref array[num2++];
				reference2 = vertices[sharedIndices[universalEdgesDistinct[i].y][0]];
			}
			pb_Renderable pb_Renderable2 = pool.Get();
			pb_Renderable2.name = "Wireframe Renderable";
			pb_Renderable2.materials = new Material[1] { wireframeMaterial };
			pb_Renderable2.transform = pb.transform;
			pb_Renderable2.mesh.name = "Wireframe Mesh";
			pb_Renderable2.mesh.Clear();
			pb_Renderable2.mesh.vertices = array;
			pb_Renderable2.mesh.normals = array;
			pb_Renderable2.mesh.uv = new Vector2[array.Length];
			pb_Renderable2.mesh.subMeshCount = 1;
			pb_Renderable2.mesh.SetIndices(SequentialTriangles(array.Length), MeshTopology.Lines, 0);
			return pb_Renderable2;
		}

		private static int[] SequentialTriangles(int len)
		{
			int[] array = new int[len];
			for (int i = 0; i < len; i++)
			{
				array[i] = i;
			}
			return array;
		}
	}
}
[AddComponentMenu("")]
public class pb_Entity : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	private EntityType _entityType;

	public EntityType entityType => _entityType;

	public void Awake()
	{
		MeshRenderer component = GetComponent<MeshRenderer>();
		if ((bool)component)
		{
			switch (entityType)
			{
			case EntityType.Trigger:
				component.enabled = false;
				break;
			case EntityType.Collider:
				component.enabled = false;
				break;
			case EntityType.Detail:
			case EntityType.Occluder:
				break;
			}
		}
	}

	public void SetEntity(EntityType t)
	{
		_entityType = t;
	}
}
namespace ProBuilder2.Common
{
	[Flags]
	public enum SelectMode
	{
		Vertex = 0,
		Edge = 1,
		Face = 2
	}
	[Flags]
	public enum EditLevel
	{
		Top = 0,
		Geometry = 1,
		Texture = 2,
		Plugin = 4
	}
	public enum HandleAlignment
	{
		World,
		Local,
		Plane
	}
	public enum DragSelectMode
	{
		Add,
		Subtract,
		Difference
	}
	public enum EntityType
	{
		Detail,
		Occluder,
		Trigger,
		Collider,
		Mover
	}
	[Flags]
	public enum SelectionRenderState
	{
		None = 0,
		Wireframe = 1,
		Outline = 2
	}
	public enum ColliderType
	{
		None,
		BoxCollider,
		MeshCollider
	}
	public enum ProjectionAxis
	{
		X,
		Y,
		Z,
		X_Negative,
		Y_Negative,
		Z_Negative
	}
	public enum Shape
	{
		Cube,
		Stair,
		Prism,
		Cylinder,
		Plane,
		Door,
		Pipe,
		Cone,
		Sprite,
		Arch,
		Icosahedron,
		Torus,
		Custom
	}
	public enum Axis
	{
		Right,
		Left,
		Up,
		Down,
		Forward,
		Backward
	}
	public enum UV2Method
	{
		Unity,
		BinPack
	}
	public enum WindingOrder
	{
		Unknown,
		Clockwise,
		CounterClockwise
	}
	public enum SortMethod
	{
		Clockwise,
		CounterClockwise
	}
	public enum Culling
	{
		Back,
		Front,
		FrontBack
	}
	public enum MeshRebuildReason
	{
		Null,
		InstanceIDMismatch,
		Lightmap,
		None
	}
	public enum AttibuteType
	{
		Position,
		UV0,
		UV1,
		UV2,
		UV3,
		Color,
		Normal,
		Tangent
	}
	public enum IndexFormat
	{
		Local,
		Common,
		Both
	}
	[Serializable]
	public class pb_Face
	{
		[SerializeField]
		private int[] _indices;

		[SerializeField]
		private int[] _distinctIndices;

		[SerializeField]
		private pb_Edge[] _edges;

		[SerializeField]
		private int _smoothingGroup;

		[SerializeField]
		private pb_UV _uv;

		[SerializeField]
		private Material _mat;

		public bool manualUV;

		public int elementGroup;

		public int textureGroup = -1;

		public int[] indices => _indices;

		public int[] distinctIndices
		{
			get
			{
				if (_distinctIndices != null)
				{
					return _distinctIndices;
				}
				return CacheDistinctIndices();
			}
		}

		public pb_Edge[] edges
		{
			get
			{
				if (_edges != null)
				{
					return _edges;
				}
				return CacheEdges();
			}
		}

		public int smoothingGroup
		{
			get
			{
				return _smoothingGroup;
			}
			set
			{
				_smoothingGroup = value;
			}
		}

		public Material material
		{
			get
			{
				return _mat;
			}
			set
			{
				_mat = value;
			}
		}

		public pb_UV uv
		{
			get
			{
				return _uv;
			}
			set
			{
				_uv = value;
			}
		}

		public pb_Face()
		{
		}

		public pb_Face(int[] i)
		{
			SetIndices(i);
			_uv = new pb_UV();
			_mat = pb_Constant.DefaultMaterial;
			_smoothingGroup = 0;
			elementGroup = 0;
		}

		public pb_Face(int[] i, Material m, pb_UV u, int smoothingGroup, int textureGroup, int elementGroup, bool manualUV)
		{
			SetIndices(i);
			_uv = new pb_UV(u);
			_mat = m;
			_smoothingGroup = smoothingGroup;
			this.textureGroup = textureGroup;
			this.elementGroup = elementGroup;
			this.manualUV = manualUV;
		}

		public pb_Face(pb_Face face)
		{
			_indices = new int[face.indices.Length];
			Array.Copy(face.indices, _indices, face.indices.Length);
			_uv = new pb_UV(face.uv);
			_mat = face.material;
			_smoothingGroup = face.smoothingGroup;
			textureGroup = face.textureGroup;
			elementGroup = face.elementGroup;
			manualUV = face.manualUV;
			RebuildCaches();
		}

		public void CopyFrom(pb_Face other)
		{
			int num = ((other.indices != null) ? other.indices.Length : 0);
			_indices = new int[num];
			Array.Copy(other.indices, _indices, num);
			_smoothingGroup = other.smoothingGroup;
			_uv = new pb_UV(other.uv);
			_mat = other.material;
			manualUV = other.manualUV;
			elementGroup = other.elementGroup;
			RebuildCaches();
		}

		[Obsolete("Use face.material property.")]
		public void SetMaterial(Material material)
		{
			_mat = material;
		}

		[Obsolete("Use face.uv property.")]
		public void SetUV(pb_UV uvs)
		{
			_uv = uvs;
		}

		[Obsolete("Use face.smoothingGroup property.")]
		public void SetSmoothingGroup(int smoothing)
		{
			_smoothingGroup = smoothing;
		}

		public bool IsValid()
		{
			return indices.Length > 2;
		}

		public Vector3[] GetDistinctVertices(Vector3[] verts)
		{
			int[] array = distinctIndices;
			Vector3[] array2 = new Vector3[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				ref Vector3 reference = ref array2[i];
				reference = verts[array[i]];
			}
			return array2;
		}

		public int[] GetTriangle(int index)
		{
			if (index * 3 + 3 > indices.Length)
			{
				return null;
			}
			return new int[3]
			{
				indices[index * 3],
				indices[index * 3 + 1],
				indices[index * 3 + 2]
			};
		}

		public pb_Edge[] GetAllEdges()
		{
			pb_Edge[] array = new pb_Edge[indices.Length];
			for (int i = 0; i < indices.Length; i += 3)
			{
				array[i] = new pb_Edge(indices[i], indices[i + 1]);
				array[i + 1] = new pb_Edge(indices[i + 1], indices[i + 2]);
				array[i + 2] = new pb_Edge(indices[i + 2], indices[i]);
			}
			return array;
		}

		public void SetIndices(int[] i)
		{
			_indices = i;
			RebuildCaches();
		}

		public void ShiftIndices(int offset)
		{
			for (int i = 0; i < _indices.Length; i++)
			{
				_indices[i] += offset;
			}
		}

		public int SmallestIndexValue()
		{
			int num = _indices[0];
			for (int i = 0; i < _indices.Length; i++)
			{
				if (_indices[i] < num)
				{
					num = _indices[i];
				}
			}
			return num;
		}

		public void ShiftIndicesToZero()
		{
			int num = SmallestIndexValue();
			for (int i = 0; i < indices.Length; i++)
			{
				_indices[i] -= num;
			}
			for (int j = 0; j < _distinctIndices.Length; j++)
			{
				_distinctIndices[j] -= num;
			}
			for (int k = 0; k < _edges.Length; k++)
			{
				_edges[k].x -= num;
				_edges[k].y -= num;
			}
		}

		public void ReverseIndices()
		{
			Array.Reverse(_indices);
			RebuildCaches();
		}

		public void RebuildCaches()
		{
			CacheDistinctIndices();
			CacheEdges();
		}

		private pb_Edge[] CacheEdges()
		{
			if (_indices == null)
			{
				return null;
			}
			HashSet<pb_Edge> hashSet = new HashSet<pb_Edge>();
			List<pb_Edge> list = new List<pb_Edge>();
			for (int i = 0; i < indices.Length; i += 3)
			{
				pb_Edge item = new pb_Edge(indices[i], indices[i + 1]);
				pb_Edge item2 = new pb_Edge(indices[i + 1], indices[i + 2]);
				pb_Edge item3 = new pb_Edge(indices[i + 2], indices[i]);
				if (!hashSet.Add(item))
				{
					list.Add(item);
				}
				if (!hashSet.Add(item2))
				{
					list.Add(item2);
				}
				if (!hashSet.Add(item3))
				{
					list.Add(item3);
				}
			}
			hashSet.ExceptWith(list);
			_edges = hashSet.ToArray();
			return _edges;
		}

		private int[] CacheDistinctIndices()
		{
			if (_indices == null)
			{
				return null;
			}
			_distinctIndices = new HashSet<int>(_indices).ToArray();
			return distinctIndices;
		}

		public bool Contains(int[] triangle)
		{
			for (int i = 0; i < indices.Length; i += 3)
			{
				if (triangle.Contains(indices[i]) && triangle.Contains(indices[i + 1]) && triangle.Contains(indices[i + 2]))
				{
					return true;
				}
			}
			return false;
		}

		public static int[] AllTriangles(pb_Face[] q)
		{
			List<int> list = new List<int>();
			foreach (pb_Face pb_Face2 in q)
			{
				list.AddRange(pb_Face2.indices);
			}
			return list.ToArray();
		}

		public static int[] AllTriangles(List<pb_Face> q)
		{
			List<int> list = new List<int>();
			foreach (pb_Face item in q)
			{
				list.AddRange(item.indices);
			}
			return list.ToArray();
		}

		public static int[] AllTrianglesDistinct(pb_Face[] q)
		{
			List<int> list = new List<int>();
			foreach (pb_Face pb_Face2 in q)
			{
				list.AddRange(pb_Face2.distinctIndices);
			}
			return list.ToArray();
		}

		public static List<int> AllTrianglesDistinct(List<pb_Face> f)
		{
			List<int> list = new List<int>();
			foreach (pb_Face item in f)
			{
				list.AddRange(item.distinctIndices);
			}
			return list;
		}

		public static int MeshTriangles(pb_Face[] faces, out int[][] submeshes, out Material[] materials)
		{
			Dictionary<Material, List<pb_Face>> dictionary = new Dictionary<Material, List<pb_Face>>();
			int num = 0;
			for (num = 0; num < faces.Length; num++)
			{
				if (faces[num] == null)
				{
					Debug.LogWarning("Null face found!  Skipping these triangles.");
					continue;
				}
				Material key = faces[num].material ?? pb_Constant.UnityDefaultDiffuse;
				if (dictionary.ContainsKey(key))
				{
					dictionary[key].Add(faces[num]);
					continue;
				}
				dictionary.Add(key, new List<pb_Face>(1) { faces[num] });
			}
			materials = new Material[dictionary.Count];
			submeshes = new int[materials.Length][];
			num = 0;
			foreach (KeyValuePair<Material, List<pb_Face>> item in dictionary)
			{
				submeshes[num] = AllTriangles(item.Value);
				materials[num] = item.Key;
				num++;
			}
			return submeshes.Length;
		}

		public override string ToString()
		{
			if (indices.Length % 3 != 0)
			{
				return "Index count is not a multiple of 3.";
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < indices.Length; i += 3)
			{
				stringBuilder.Append("[");
				stringBuilder.Append(indices[i]);
				stringBuilder.Append(", ");
				stringBuilder.Append(indices[i + 1]);
				stringBuilder.Append(", ");
				stringBuilder.Append(indices[i + 2]);
				stringBuilder.Append("]");
				if (i < indices.Length - 3)
				{
					stringBuilder.Append(", ");
				}
			}
			return stringBuilder.ToString();
		}

		public string ToStringDetailed()
		{
			string text = "index count: " + _indices.Length + "\nmat name : " + material.name + "\nisManual : " + manualUV + "\nsmoothing group: " + smoothingGroup + "\n";
			for (int i = 0; i < indices.Length; i += 3)
			{
				object obj = text;
				text = string.Concat(obj, "Tri ", i, ": ", _indices[i], ", ", _indices[i + 1], ", ", _indices[i + 2], "\n");
			}
			text += "Distinct Indices:\n";
			for (int j = 0; j < distinctIndices.Length; j++)
			{
				text = text + distinctIndices[j] + ", ";
			}
			return text;
		}
	}
	public class pb_HandleUtility
	{
		private const float MAX_EDGE_SELECT_DISTANCE = 20f;

		public static bool FaceRaycast(Ray InWorldRay, pb_Object mesh, out pb_RaycastHit hit, HashSet<pb_Face> ignore = null)
		{
			return FaceRaycast(InWorldRay, mesh, out hit, float.PositiveInfinity, Culling.Front, ignore);
		}

		public static bool FaceRaycast(Ray InWorldRay, pb_Object mesh, out pb_RaycastHit hit, float distance, Culling cullingMode, HashSet<pb_Face> ignore = null)
		{
			InWorldRay.origin -= mesh.transform.position;
			InWorldRay.origin = mesh.transform.worldToLocalMatrix * InWorldRay.origin;
			InWorldRay.direction = mesh.transform.worldToLocalMatrix * InWorldRay.direction;
			Vector3[] vertices = mesh.vertices;
			float OutDistance = 0f;
			Vector3 OutPoint = Vector3.zero;
			float num = float.PositiveInfinity;
			int num2 = -1;
			Vector3 inNormal = Vector3.zero;
			for (int i = 0; i < mesh.faces.Length; i++)
			{
				if (ignore != null && ignore.Contains(mesh.faces[i]))
				{
					continue;
				}
				int[] indices = mesh.faces[i].indices;
				for (int j = 0; j < indices.Length; j += 3)
				{
					Vector3 vector = vertices[indices[j]];
					Vector3 vector2 = vertices[indices[j + 1]];
					Vector3 vector3 = vertices[indices[j + 2]];
					Vector3 vector4 = Vector3.Cross(vector2 - vector, vector3 - vector);
					float num3 = Vector3.Dot(InWorldRay.direction, vector4);
					bool flag = false;
					switch (cullingMode)
					{
					case Culling.Front:
						if (num3 > 0f)
						{
							flag = true;
						}
						break;
					case Culling.Back:
						if (num3 < 0f)
						{
							flag = true;
						}
						break;
					}
					if (!flag && pb_Math.RayIntersectsTriangle(InWorldRay, vector, vector2, vector3, out OutDistance, out OutPoint) && !(OutDistance > num) && !(OutDistance > distance))
					{
						inNormal = vector4;
						num2 = i;
						num = OutDistance;
					}
				}
			}
			hit = new pb_RaycastHit(num, InWorldRay.GetPoint(num), inNormal, num2);
			return num2 > -1;
		}

		public static bool FaceRaycast(Ray InWorldRay, pb_Object mesh, out List<pb_RaycastHit> hits, float distance, Culling cullingMode, HashSet<pb_Face> ignore = null)
		{
			InWorldRay.origin -= mesh.transform.position;
			InWorldRay.origin = mesh.transform.worldToLocalMatrix * InWorldRay.origin;
			InWorldRay.direction = mesh.transform.worldToLocalMatrix * InWorldRay.direction;
			Vector3[] vertices = mesh.vertices;
			float OutDistance = 0f;
			Vector3 OutPoint = Vector3.zero;
			hits = new List<pb_RaycastHit>();
			for (int i = 0; i < mesh.faces.Length; i++)
			{
				if (ignore != null && ignore.Contains(mesh.faces[i]))
				{
					continue;
				}
				int[] indices = mesh.faces[i].indices;
				for (int j = 0; j < indices.Length; j += 3)
				{
					Vector3 vector = vertices[indices[j]];
					Vector3 vector2 = vertices[indices[j + 1]];
					Vector3 vector3 = vertices[indices[j + 2]];
					if (!pb_Math.RayIntersectsTriangle(InWorldRay, vector, vector2, vector3, out OutDistance, out OutPoint))
					{
						continue;
					}
					Vector3 vector4 = Vector3.Cross(vector2 - vector, vector3 - vector);
					switch (cullingMode)
					{
					case Culling.Front:
					{
						float num = Vector3.Dot(InWorldRay.direction, -vector4);
						if (!(num > 0f))
						{
							continue;
						}
						break;
					}
					case Culling.Back:
					{
						float num = Vector3.Dot(InWorldRay.direction, vector4);
						if (!(num > 0f))
						{
							continue;
						}
						break;
					}
					case Culling.FrontBack:
						break;
					default:
						continue;
					}
					hits.Add(new pb_RaycastHit(OutDistance, InWorldRay.GetPoint(OutDistance), vector4, i));
				}
			}
			return hits.Count > 0;
		}

		public static bool EdgeRaycast(Camera cam, Vector2 mousePosition, pb_Object mesh, pb_Edge[] edges, Vector3[] verticesInWorldSpace, out pb_Edge edge)
		{
			float num = float.PositiveInfinity;
			float num2 = 0f;
			edge = null;
			GameObject gameObject = ObjectRaycast(cam, mousePosition, (GameObject[])Resources.FindObjectsOfTypeAll(typeof(GameObject)));
			if (gameObject == null || gameObject != mesh.gameObject)
			{
				int width = Screen.width;
				int height = Screen.height;
				for (int i = 0; i < edges.Length; i++)
				{
					Vector3 vector = verticesInWorldSpace[edges[i].x];
					Vector3 vector2 = verticesInWorldSpace[edges[i].y];
					num2 = DistancePoint2DToLine(cam, mousePosition, vector, vector2);
					if (!(num2 < num) || !(num2 < 20f))
					{
						continue;
					}
					Vector3 vector3 = cam.WorldToScreenPoint(vector);
					if (!(vector3.z <= 0f) && !(vector3.x < 0f) && !(vector3.y < 0f) && !(vector3.x > (float)width) && !(vector3.y > (float)height))
					{
						Vector3 vector4 = cam.WorldToScreenPoint(vector2);
						if (!(vector4.z <= 0f) && !(vector4.x < 0f) && !(vector4.y < 0f) && !(vector4.x > (float)width) && !(vector4.y > (float)height))
						{
							num = num2;
							edge = edges[i];
						}
					}
				}
			}
			else
			{
				Ray inWorldRay = cam.ScreenPointToRay(mousePosition);
				if (FaceRaycast(inWorldRay, mesh, out List<pb_RaycastHit> hits, float.PositiveInfinity, Culling.FrontBack, (HashSet<pb_Face>)null))
				{
					hits.Sort((pb_RaycastHit x, pb_RaycastHit y) => x.distance.CompareTo(y.distance));
					Vector3[] vertices = mesh.vertices;
					for (int num3 = 0; num3 < hits.Count; num3++)
					{
						if (PointIsOccluded(cam, mesh, mesh.transform.TransformPoint(hits[num3].point)))
						{
							continue;
						}
						pb_Edge[] allEdges = mesh.faces[hits[num3].face].GetAllEdges();
						foreach (pb_Edge pb_Edge2 in allEdges)
						{
							float num5 = pb_Math.DistancePointLineSegment(hits[num3].point, vertices[pb_Edge2.x], vertices[pb_Edge2.y]);
							if (num5 < num)
							{
								num = num5;
								edge = pb_Edge2;
							}
						}
						if (Vector3.Dot(inWorldRay.direction, mesh.transform.TransformDirection(hits[num3].normal)) < 0f)
						{
							break;
						}
					}
					if (edge != null && DistancePoint2DToLine(cam, mousePosition, mesh.transform.TransformPoint(vertices[edge.x]), mesh.transform.TransformPoint(vertices[edge.y])) > 20f)
					{
						edge = null;
					}
				}
			}
			return edge != null;
		}

		public static GameObject ObjectRaycast(Camera cam, Vector2 mousePosition, GameObject[] objects)
		{
			return null;
		}

		public static float DistancePoint2DToLine(Camera cam, Vector2 mousePosition, Vector3 worldPosition1, Vector3 worldPosition2)
		{
			Vector2 v = cam.WorldToScreenPoint(worldPosition1);
			Vector2 w = cam.WorldToScreenPoint(worldPosition2);
			return pb_Math.DistancePointLineSegment(mousePosition, v, w);
		}

		public static bool PointIsOccluded(Camera cam, pb_Object pb, Vector3 worldPoint)
		{
			Vector3 normalized = (cam.transform.position - worldPoint).normalized;
			Ray inWorldRay = new Ray(worldPoint + normalized * 0.0001f, normalized);
			pb_RaycastHit hit;
			return FaceRaycast(inWorldRay, pb, out hit, Vector3.Distance(cam.transform.position, worldPoint), Culling.Back, (HashSet<pb_Face>)null);
		}

		public static bool IsOccluded(Camera cam, pb_Object pb, pb_Face face)
		{
			Vector3 zero = Vector3.zero;
			int num = face.distinctIndices.Length;
			for (int i = 0; i < num; i++)
			{
				zero += pb.vertices[face.distinctIndices[i]];
			}
			zero *= 1f / (float)num;
			return PointIsOccluded(cam, pb, pb.transform.TransformPoint(zero));
		}
	}
	[Serializable]
	public class pb_IntArray
	{
		public int[] array;

		public int this[int i]
		{
			get
			{
				return array[i];
			}
			set
			{
				array[i] = value;
			}
		}

		public int Length => array.Length;

		public List<int> ToList()
		{
			return new List<int>(array);
		}

		public pb_IntArray(int[] intArray)
		{
			array = intArray;
		}

		public pb_IntArray(pb_IntArray intArray)
		{
			array = intArray.array;
		}

		public static implicit operator int[](pb_IntArray intArr)
		{
			return intArr.array;
		}

		public static explicit operator pb_IntArray(int[] arr)
		{
			return new pb_IntArray(arr);
		}

		public override string ToString()
		{
			string text = "";
			for (int i = 0; i < array.Length - 1; i++)
			{
				text = text + array[i] + ", ";
			}
			if (array.Length > 0)
			{
				text += array[array.Length - 1];
			}
			return text;
		}

		public bool IsEmpty()
		{
			if (array != null)
			{
				return array.Length < 1;
			}
			return true;
		}

		public static void RemoveEmptyOrNull(ref pb_IntArray[] val)
		{
			List<pb_IntArray> list = new List<pb_IntArray>();
			pb_IntArray[] array = val;
			foreach (pb_IntArray pb_IntArray2 in array)
			{
				if (pb_IntArray2 != null && !pb_IntArray2.IsEmpty())
				{
					list.Add(pb_IntArray2);
				}
			}
			val = list.ToArray();
		}
	}
	public static class pb_IntArrayUtility
	{
		public static int[][] ToArray(this pb_IntArray[] val)
		{
			int[][] array = new int[val.Length][];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = val[i].array;
			}
			return array;
		}

		public static Dictionary<int, int> ToDictionary(this pb_IntArray[] array)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array[i].array.Length; j++)
				{
					if (!dictionary.ContainsKey(array[i][j]))
					{
						dictionary.Add(array[i][j], i);
					}
				}
			}
			return dictionary;
		}

		public static pb_IntArray[] ToSharedIndices(this IEnumerable<KeyValuePair<int, int>> lookup)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			List<List<int>> list = new List<List<int>>();
			foreach (KeyValuePair<int, int> item in lookup)
			{
				if (item.Value < 0)
				{
					list.Add(new List<int> { item.Key });
					continue;
				}
				int value = -1;
				if (dictionary.TryGetValue(item.Value, out value))
				{
					list[value].Add(item.Key);
					continue;
				}
				dictionary.Add(item.Value, list.Count);
				list.Add(new List<int> { item.Key });
			}
			return list.ToPbIntArray();
		}

		public static pb_IntArray[] ToPbIntArray(this int[][] val)
		{
			pb_IntArray[] array = new pb_IntArray[val.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (pb_IntArray)val[i];
			}
			return array;
		}

		public static pb_IntArray[] ToPbIntArray(this List<List<int>> val)
		{
			pb_IntArray[] array = new pb_IntArray[val.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (pb_IntArray)val[i].ToArray();
			}
			return array;
		}

		public static List<List<int>> ToList(this pb_IntArray[] val)
		{
			List<List<int>> list = new List<List<int>>();
			for (int i = 0; i < val.Length; i++)
			{
				list.Add(val[i].ToList());
			}
			return list;
		}

		public static string ToFormattedString(this pb_IntArray[] arr)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < arr.Length; i++)
			{
				stringBuilder.Append("[" + pbUtil.ToString(arr[i].array) + "] ");
			}
			return stringBuilder.ToString();
		}

		public static int IndexOf(this int[] array, int val, pb_IntArray[] sharedIndices)
		{
			int num = sharedIndices.IndexOf(val);
			if (num < 0)
			{
				return -1;
			}
			int[] array2 = sharedIndices[num];
			for (int i = 0; i < array.Length; i++)
			{
				if (Array.IndexOf(array2, array[i]) > -1)
				{
					return i;
				}
			}
			return -1;
		}

		public static int IndexOf(this IList<int> indices, int triangle, ref Dictionary<int, int> lookup)
		{
			int num = lookup[triangle];
			if (num < 0)
			{
				return -1;
			}
			int num2 = indices.Count();
			for (int i = 0; i < num2; i++)
			{
				if (lookup[indices[i]] == num)
				{
					return i;
				}
			}
			return -1;
		}

		public static int IndexOf(this pb_IntArray[] intArray, int index)
		{
			if (intArray == null)
			{
				return -1;
			}
			for (int i = 0; i < intArray.Length; i++)
			{
				for (int j = 0; j < intArray[i].Length; j++)
				{
					if (intArray[i][j] == index)
					{
						return i;
					}
				}
			}
			return -1;
		}

		public static IList<int> AllIndicesWithValues(this pb_IntArray[] pbIntArr, IList<int> indices)
		{
			int[] array = pbIntArr.GetCommonIndices(indices).ToArray();
			List<int> list = new List<int>();
			for (int i = 0; i < array.Length; i++)
			{
				list.AddRange(pbIntArr[array[i]].array);
			}
			return list;
		}

		public static IList<int> AllIndicesWithValues(this pb_IntArray[] pbIntArr, Dictionary<int, int> lookup, IList<int> indices)
		{
			int[] array = GetCommonIndices(lookup, indices).ToArray();
			List<int> list = new List<int>();
			for (int i = 0; i < array.Length; i++)
			{
				list.AddRange(pbIntArr[array[i]].array);
			}
			return list;
		}

		public static IList<int> UniqueIndicesWithValues(this pb_IntArray[] pbIntArr, IList<int> indices)
		{
			Dictionary<int, int> dictionary = pbIntArr.ToDictionary();
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int index in indices)
			{
				hashSet.Add(dictionary[index]);
			}
			List<int> list = new List<int>();
			foreach (int item in hashSet)
			{
				list.Add(pbIntArr[item][0]);
			}
			return list;
		}

		public static HashSet<int> GetCommonIndices(this pb_IntArray[] pbIntArr, IList<int> indices)
		{
			return GetCommonIndices(pbIntArr.ToDictionary(), indices);
		}

		public static HashSet<int> GetCommonIndices(Dictionary<int, int> lookup, IList<int> indices)
		{
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int index in indices)
			{
				hashSet.Add(lookup[index]);
			}
			return hashSet;
		}

		public static IEnumerable<int> GetIndicesWithCommon(this pb_IntArray[] pbIntArr, IEnumerable<int> common)
		{
			return common.Select((int x) => pbIntArr[x][0]);
		}

		public static pb_IntArray[] ExtractSharedIndices(Vector3[] v)
		{
			Dictionary<pb_IntVec3, List<int>> dictionary = new Dictionary<pb_IntVec3, List<int>>();
			for (int i = 0; i < v.Length; i++)
			{
				if (dictionary.TryGetValue(v[i], out var value))
				{
					value.Add(i);
					continue;
				}
				dictionary.Add(new pb_IntVec3(v[i]), new List<int> { i });
			}
			pb_IntArray[] array = new pb_IntArray[dictionary.Count];
			int num = 0;
			foreach (KeyValuePair<pb_IntVec3, List<int>> item in dictionary)
			{
				array[num++] = new pb_IntArray(item.Value.ToArray());
			}
			return array;
		}

		public static int MergeSharedIndices(ref pb_IntArray[] sharedIndices, int[] indices)
		{
			if (indices.Length < 2)
			{
				return -1;
			}
			if (sharedIndices == null)
			{
				sharedIndices = new pb_IntArray[1] { (pb_IntArray)indices };
				return 0;
			}
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			for (int i = 0; i < indices.Length; i++)
			{
				int num = sharedIndices.IndexOf(indices[i]);
				if (!list.Contains(num))
				{
					if (num > -1)
					{
						list2.AddRange(sharedIndices[num].array);
						list.Add(num);
					}
					else
					{
						list2.Add(indices[i]);
					}
				}
			}
			int num2 = sharedIndices.Length - list.Count;
			pb_IntArray[] array = new pb_IntArray[num2];
			int num3 = 0;
			for (int j = 0; j < sharedIndices.Length; j++)
			{
				if (!list.Contains(j))
				{
					array[num3++] = sharedIndices[j];
				}
			}
			sharedIndices = array.Add(new pb_IntArray(list2.ToArray()));
			return sharedIndices.Length - 1;
		}

		public static void MergeSharedIndices(ref pb_IntArray[] sharedIndices, int a, int b)
		{
			int sharedIndex = sharedIndices.IndexOf(a);
			int num = sharedIndices.IndexOf(b);
			AddValueAtIndex(ref sharedIndices, sharedIndex, b);
			int[] array = sharedIndices[num].array;
			sharedIndices[num].array = array.RemoveAt(Array.IndexOf(array, b));
			pb_IntArray.RemoveEmptyOrNull(ref sharedIndices);
		}

		public static int AddValueAtIndex(ref pb_IntArray[] sharedIndices, int sharedIndex, int value)
		{
			if (sharedIndex > -1)
			{
				sharedIndices[sharedIndex].array = sharedIndices[sharedIndex].array.Add(value);
			}
			else
			{
				sharedIndices = sharedIndices.Add(new pb_IntArray(new int[1] { value }));
			}
			if (sharedIndex <= -1)
			{
				return sharedIndices.Length - 1;
			}
			return sharedIndex;
		}

		public static int AddRangeAtIndex(ref pb_IntArray[] sharedIndices, int sharedIndex, int[] indices)
		{
			if (sharedIndex > -1)
			{
				sharedIndices[sharedIndex].array = sharedIndices[sharedIndex].array.AddRange(indices);
			}
			else
			{
				sharedIndices = sharedIndices.Add(new pb_IntArray(indices));
			}
			if (sharedIndex <= -1)
			{
				return sharedIndices.Length - 1;
			}
			return sharedIndex;
		}

		public static void RemoveValues(ref pb_IntArray[] sharedIndices, int[] remove)
		{
			for (int i = 0; i < sharedIndices.Length; i++)
			{
				for (int j = 0; j < remove.Length; j++)
				{
					int num = Array.IndexOf(sharedIndices[i], remove[j]);
					if (num > -1)
					{
						sharedIndices[i].array = sharedIndices[i].array.RemoveAt(num);
					}
				}
			}
			pb_IntArray.RemoveEmptyOrNull(ref sharedIndices);
		}

		public static void RemoveValuesAndShift(ref pb_IntArray[] sharedIndices, IEnumerable<int> remove)
		{
			Dictionary<int, int> dictionary = sharedIndices.ToDictionary();
			foreach (int item in remove)
			{
				dictionary[item] = -1;
			}
			sharedIndices = dictionary.Where((KeyValuePair<int, int> x) => x.Value > -1).ToSharedIndices();
			List<int> list = new List<int>(remove);
			list.Sort();
			for (int num = 0; num < sharedIndices.Length; num++)
			{
				for (int num2 = 0; num2 < sharedIndices[num].Length; num2++)
				{
					int num3 = pbUtil.NearestIndexPriorToValue(list, sharedIndices[num][num2]);
					sharedIndices[num][num2] -= num3 + 1;
				}
			}
		}
	}
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	public class pb_LineRenderer : pb_MonoBehaviourSingleton<pb_LineRenderer>
	{
		private HideFlags SceneCameraHideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable;

		private pb_ObjectPool<Mesh> pool;

		[HideInInspector]
		public List<Mesh> gizmos = new List<Mesh>();

		[HideInInspector]
		public Material mat;

		private static Mesh MeshConstructor()
		{
			Mesh mesh = new Mesh();
			mesh.hideFlags = pb_Constant.EDITOR_OBJECT_HIDE_FLAGS;
			mesh.name = "pb_LineRenderer::Mesh";
			return mesh;
		}

		public override void OnEnable()
		{
			base.OnEnable();
			pool = new pb_ObjectPool<Mesh>(1, 8, MeshConstructor, null);
		}

		private void OnDisable()
		{
			pool.Empty();
		}

		public override void Awake()
		{
			base.Awake();
			base.gameObject.hideFlags = HideFlags.HideAndDontSave;
			mat = new Material(Shader.Find("ProBuilder/UnlitVertexColor"));
			mat.name = "pb_LineRenderer_Material";
			mat.SetColor("_Color", Color.white);
			mat.hideFlags = pb_Constant.EDITOR_OBJECT_HIDE_FLAGS;
		}

		private void OnDestroy()
		{
			foreach (Mesh gizmo in gizmos)
			{
				if (gizmo != null)
				{
					UnityEngine.Object.DestroyImmediate(gizmo);
				}
			}
			UnityEngine.Object.DestroyImmediate(mat);
		}

		public void AddLineSegments(Vector3[] segments, Color[] colors)
		{
			if (pool == null)
			{
				pool = new pb_ObjectPool<Mesh>(1, 4, MeshConstructor, null);
			}
			Mesh mesh = pool.Get();
			mesh.Clear();
			mesh.name = "pb_LineRenderer::Mesh_" + mesh.GetInstanceID();
			mesh.MarkDynamic();
			int num = segments.Length;
			int num2 = colors.Length;
			mesh.vertices = segments;
			int[] array = new int[num];
			Color[] array2 = new Color[num];
			int num3 = 0;
			for (int i = 0; i < num; i++)
			{
				array[i] = i;
				ref Color reference = ref array2[i];
				reference = colors[num3 % num2];
				if (i % 2 == 1)
				{
					num3++;
				}
			}
			mesh.subMeshCount = 1;
			mesh.SetIndices(array, MeshTopology.Lines, 0);
			mesh.uv = new Vector2[mesh.vertexCount];
			mesh.colors = array2;
			mesh.hideFlags = pb_Constant.EDITOR_OBJECT_HIDE_FLAGS;
			gizmos.Add(mesh);
		}

		public void Clear()
		{
			for (int i = 0; i < gizmos.Count; i++)
			{
				pool.Put(gizmos[i]);
			}
			gizmos.Clear();
		}

		private void OnRenderObject()
		{
			if (!(mat == null) && (Camera.current.gameObject.hideFlags & SceneCameraHideFlags) == SceneCameraHideFlags && !(Camera.current.name != "SceneCamera"))
			{
				mat.SetPass(0);
				for (int i = 0; i < gizmos.Count && gizmos[i] != null; i++)
				{
					Graphics.DrawMeshNow(gizmos[i], Vector3.zero, Quaternion.identity, 0);
				}
			}
		}
	}
}
namespace ProBuilder2.Math
{
	[Obsolete("pb_Math has moved to ProBuilder2.Common")]
	public static class pb_Math
	{
	}
}
namespace ProBuilder2.Common
{
	public static class pb_Math
	{
		public const float PHI = 1.618034f;

		public const float FLT_EPSILON = float.Epsilon;

		public const float FLT_COMPARE_EPSILON = 0.0001f;

		public const float HANDLE_EPSILON = 0.0001f;

		public static Vector2 PointInCircumference(float radius, float angleInDegrees, Vector2 origin)
		{
			float x = radius * Mathf.Cos((float)System.Math.PI / 180f * angleInDegrees) + origin.x;
			float y = radius * Mathf.Sin((float)System.Math.PI / 180f * angleInDegrees) + origin.y;
			return new Vector2(x, y);
		}

		public static Vector3 PointInSphere(float radius, float latitudeAngle, float longitudeAngle)
		{
			float x = radius * Mathf.Cos((float)System.Math.PI / 180f * latitudeAngle) * Mathf.Sin((float)System.Math.PI / 180f * longitudeAngle);
			float y = radius * Mathf.Sin((float)System.Math.PI / 180f * latitudeAngle) * Mathf.Sin((float)System.Math.PI / 180f * longitudeAngle);
			float z = radius * Mathf.Cos((float)System.Math.PI / 180f * longitudeAngle);
			return new Vector3(x, y, z);
		}

		public static float SignedAngle(Vector2 a, Vector2 b)
		{
			float num = Vector2.Angle(a, b);
			if (b.x - a.x < 0f)
			{
				num = 360f - num;
			}
			return num;
		}

		public static float TriangleArea(Vector3 a, Vector3 b, Vector3 c)
		{
			float num = Vector3.Distance(a, b);
			float num2 = Vector3.Distance(b, c);
			float num3 = Vector3.Distance(c, a);
			float num4 = (num + num2 + num3) / 2f;
			return Mathf.Sqrt(num4 * (num4 - num) * (num4 - num2) * (num4 - num3));
		}

		public static Vector2 RotateAroundPoint(this Vector2 v, Vector2 origin, float theta)
		{
			float x = origin.x;
			float y = origin.y;
			float x2 = v.x;
			float y2 = v.y;
			float num = Mathf.Sin(theta * ((float)System.Math.PI / 180f));
			float num2 = Mathf.Cos(theta * ((float)System.Math.PI / 180f));
			x2 -= x;
			y2 -= y;
			float num3 = x2 * num2 + y2 * num;
			float num4 = (0f - x2) * num + y2 * num2;
			x2 = num3 + x;
			y2 = num4 + y;
			return new Vector2(x2, y2);
		}

		public static Vector2 ScaleAroundPoint(this Vector2 v, Vector2 origin, Vector2 scale)
		{
			Vector2 a = v - origin;
			a = Vector2.Scale(a, scale);
			return a + origin;
		}

		public static Vector2 Perpendicular(Vector2 a, Vector2 b)
		{
			float x = a.x;
			float y = a.y;
			float x2 = b.x;
			float y2 = b.y;
			return new Vector2(0f - (y2 - y), x2 - x).normalized;
		}

		public static Vector2 Perpendicular(Vector2 a)
		{
			return new Vector2(0f - a.y, a.x).normalized;
		}

		public static Vector2 ReflectPoint(Vector2 point, Vector2 a, Vector2 b)
		{
			Vector2 vector = b - a;
			Vector2 vector2 = new Vector2(0f - vector.y, vector.x);
			float num = Mathf.Sin(Vector2.Angle(vector, point - a) * ((float)System.Math.PI / 180f)) * Vector2.Distance(point, a);
			return point + vector2 * (num * 2f) * ((Vector2.Dot(point - a, vector2) > 0f) ? (-1f) : 1f);
		}

		public static float DistancePointLineSegment(Vector2 p, Vector2 v, Vector2 w)
		{
			float num = (v.x - w.x) * (v.x - w.x) + (v.y - w.y) * (v.y - w.y);
			if (num == 0f)
			{
				return Vector2.Distance(p, v);
			}
			float num2 = Vector2.Dot(p - v, w - v) / num;
			if ((double)num2 < 0.0)
			{
				return Vector2.Distance(p, v);
			}
			if ((double)num2 > 1.0)
			{
				return Vector2.Distance(p, w);
			}
			Vector2 b = v + num2 * (w - v);
			return Vector2.Distance(p, b);
		}

		public static float DistancePointLineSegment(Vector3 p, Vector3 v, Vector3 w)
		{
			float num = (v.x - w.x) * (v.x - w.x) + (v.y - w.y) * (v.y - w.y) + (v.z - w.z) * (v.z - w.z);
			if (num == 0f)
			{
				return Vector3.Distance(p, v);
			}
			float num2 = Vector3.Dot(p - v, w - v) / num;
			if ((double)num2 < 0.0)
			{
				return Vector3.Distance(p, v);
			}
			if ((double)num2 > 1.0)
			{
				return Vector3.Distance(p, w);
			}
			Vector3 b = v + num2 * (w - v);
			return Vector3.Distance(p, b);
		}

		public static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, ref Vector2 intersect)
		{
			intersect = Vector2.zero;
			Vector2 vector = default(Vector2);
			vector.x = p1.x - p0.x;
			vector.y = p1.y - p0.y;
			Vector2 vector2 = default(Vector2);
			vector2.x = p3.x - p2.x;
			vector2.y = p3.y - p2.y;
			float num = ((0f - vector.y) * (p0.x - p2.x) + vector.x * (p0.y - p2.y)) / ((0f - vector2.x) * vector.y + vector.x * vector2.y);
			float num2 = (vector2.x * (p0.y - p2.y) - vector2.y * (p0.x - p2.x)) / ((0f - vector2.x) * vector.y + vector.x * vector2.y);
			if (num >= 0f && num <= 1f && num2 >= 0f && num2 <= 1f)
			{
				intersect.x = p0.x + num2 * vector.x;
				intersect.y = p0.y + num2 * vector.y;
				return true;
			}
			return false;
		}

		public static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
		{
			Vector2 vector = default(Vector2);
			vector.x = p1.x - p0.x;
			vector.y = p1.y - p0.y;
			Vector2 vector2 = default(Vector2);
			vector2.x = p3.x - p2.x;
			vector2.y = p3.y - p2.y;
			float num = ((0f - vector.y) * (p0.x - p2.x) + vector.x * (p0.y - p2.y)) / ((0f - vector2.x) * vector.y + vector.x * vector2.y);
			float num2 = (vector2.x * (p0.y - p2.y) - vector2.y * (p0.x - p2.x)) / ((0f - vector2.x) * vector.y + vector.x * vector2.y);
			if (num >= 0f && num <= 1f && num2 >= 0f)
			{
				return num2 <= 1f;
			}
			return false;
		}

		public static bool PointInPolygon(Vector2[] polygon, Vector2 point, int[] indices = null)
		{
			int num = ((indices != null) ? indices.Length : polygon.Length);
			if (num % 2 != 0)
			{
				Debug.LogError("PointInPolygon requires polygon indices be divisible by 2!");
				return false;
			}
			pb_Bounds2D pb_Bounds2D2 = new pb_Bounds2D(polygon, indices);
			if (pb_Bounds2D2.ContainsPoint(point))
			{
				Vector2 p = pb_Bounds2D2.center + Vector2.up * (pb_Bounds2D2.size.y + 2f);
				int num2 = 0;
				for (int i = 0; i < num; i += 2)
				{
					int num3 = ((indices != null) ? indices[i] : i);
					int num4 = ((indices != null) ? indices[i + 1] : (i + 1));
					if (GetLineSegmentIntersect(p, point, polygon[num3], polygon[num4]))
					{
						num2++;
					}
				}
				return num2 % 2 != 0;
			}
			return false;
		}

		public static bool PointInPolygon(Vector2[] polygon, pb_Bounds2D polyBounds, pb_Edge[] edges, Vector2 point)
		{
			int num = edges.Length * 2;
			Vector2 p = polyBounds.center + Vector2.up * (polyBounds.size.y + 2f);
			int num2 = 0;
			for (int i = 0; i < num; i += 2)
			{
				if (GetLineSegmentIntersect(p, point, polygon[i], polygon[i + 1]))
				{
					num2++;
				}
			}
			return num2 % 2 != 0;
		}

		public static bool RectIntersectsLineSegment(Rect rect, Vector2 a, Vector2 b)
		{
			Vector2 vector = new Vector2(rect.xMin, rect.yMax);
			Vector2 p = new Vector2(rect.xMax, rect.yMax);
			Vector2 vector2 = new Vector2(rect.xMin, rect.yMin);
			Vector2 vector3 = new Vector2(rect.xMax, rect.yMin);
			if (!GetLineSegmentIntersect(p, vector, a, b) && !GetLineSegmentIntersect(vector, vector2, a, b) && !GetLineSegmentIntersect(vector2, vector3, a, b))
			{
				return GetLineSegmentIntersect(vector3, vector, a, b);
			}
			return true;
		}

		public static bool RayIntersectsTriangle(Ray InRay, Vector3 InTriangleA, Vector3 InTriangleB, Vector3 InTriangleC, out float OutDistance, out Vector3 OutPoint)
		{
			OutDistance = 0f;
			OutPoint = Vector3.zero;
			Vector3 vector = InTriangleB - InTriangleA;
			Vector3 vector2 = InTriangleC - InTriangleA;
			Vector3 rhs = Vector3.Cross(InRay.direction, vector2);
			float num = Vector3.Dot(vector, rhs);
			if (num > 0f - Mathf.Epsilon && num < Mathf.Epsilon)
			{
				return false;
			}
			float num2 = 1f / num;
			Vector3 lhs = InRay.origin - InTriangleA;
			float num3 = Vector3.Dot(lhs, rhs) * num2;
			if (num3 < 0f || num3 > 1f)
			{
				return false;
			}
			Vector3 rhs2 = Vector3.Cross(lhs, vector);
			float num4 = Vector3.Dot(InRay.direction, rhs2) * num2;
			if (num4 < 0f || num3 + num4 > 1f)
			{
				return false;
			}
			float num5 = Vector3.Dot(vector2, rhs2) * num2;
			if (num5 > Mathf.Epsilon)
			{
				OutDistance = num5;
				OutPoint.x = num3 * InTriangleB.x + num4 * InTriangleC.x + (1f - (num3 + num4)) * InTriangleA.x;
				OutPoint.y = num3 * InTriangleB.y + num4 * InTriangleC.y + (1f - (num3 + num4)) * InTriangleA.y;
				OutPoint.z = num3 * InTriangleB.z + num4 * InTriangleC.z + (1f - (num3 + num4)) * InTriangleA.z;
				return true;
			}
			return false;
		}

		public static Vector3 Normal(Vector3 p0, Vector3 p1, Vector3 p2)
		{
			Vector3 result = Vector3.Cross(p1 - p0, p2 - p0);
			result.Normalize();
			return result;
		}

		public static Vector3 Normal(IList<pb_Vertex> vertices, IList<int> indices = null)
		{
			if (indices == null || indices.Count % 3 != 0)
			{
				Vector3 result = Vector3.Cross(vertices[1].position - vertices[0].position, vertices[2].position - vertices[0].position);
				result.Normalize();
				return result;
			}
			int count = indices.Count;
			Vector3 zero = Vector3.zero;
			for (int i = 0; i < count; i += 3)
			{
				zero += Normal(vertices[indices[i]].position, vertices[indices[i + 1]].position, vertices[indices[i + 2]].position);
			}
			zero /= (float)count / 3f;
			zero.Normalize();
			return zero;
		}

		public static Vector3 Normal(pb_Object pb, pb_Face face)
		{
			Vector3[] vertices = pb.vertices;
			Vector3 vector = Normal(vertices[face.indices[0]], vertices[face.indices[1]], vertices[face.indices[2]]);
			if (face.indices.Length > 7)
			{
				Vector3 normal = pb_Projection.FindBestPlane(vertices, face.distinctIndices).normal;
				if (Vector3.Dot(vector, normal) < 0f)
				{
					vector.x = 0f - normal.x;
					vector.y = 0f - normal.y;
					vector.z = 0f - normal.z;
				}
				else
				{
					vector.x = normal.x;
					vector.y = normal.y;
					vector.z = normal.z;
				}
			}
			return vector;
		}

		public static Vector3 Normal(IList<Vector3> p)
		{
			if (p == null || p.Count < 3)
			{
				return Vector3.zero;
			}
			int count = p.Count;
			if (count % 3 == 0)
			{
				Vector3 zero = Vector3.zero;
				for (int i = 0; i < count; i += 3)
				{
					zero += Normal(p[i], p[i + 1], p[i + 2]);
				}
				zero /= (float)count / 3f;
				zero.Normalize();
				return zero;
			}
			Vector3 vector = Vector3.Cross(p[1] - p[0], p[2] - p[0]);
			if (vector.magnitude < Mathf.Epsilon)
			{
				return new Vector3(0f, 0f, 0f);
			}
			return vector.normalized;
		}

		public static void NormalTangentBitangent(pb_Object pb, pb_Face face, out Vector3 normal, out Vector3 tangent, out Vector3 bitangent)
		{
			if (face.indices.Length < 3)
			{
				Debug.LogWarning("Cannot find normal / tangent / bitangent for face with < 3 indices.");
				normal = Vector3.zero;
				tangent = Vector3.zero;
				bitangent = Vector3.zero;
				return;
			}
			normal = Normal(pb, face);
			Vector3 tangent2 = Vector3.zero;
			Vector3 zero = Vector3.zero;
			Vector4 vector = new Vector4(0f, 0f, 0f, 1f);
			long num = face.indices[0];
			long num2 = face.indices[1];
			long num3 = face.indices[2];
			Vector3 vector2 = pb.vertices[num];
			Vector3 vector3 = pb.vertices[num2];
			Vector3 vector4 = pb.vertices[num3];
			Vector2 vector5 = pb.uv[num];
			Vector2 vector6 = pb.uv[num2];
			Vector2 vector7 = pb.uv[num3];
			float num4 = vector3.x - vector2.x;
			float num5 = vector4.x - vector2.x;
			float num6 = vector3.y - vector2.y;
			float num7 = vector4.y - vector2.y;
			float num8 = vector3.z - vector2.z;
			float num9 = vector4.z - vector2.z;
			float num10 = vector6.x - vector5.x;
			float num11 = vector7.x - vector5.x;
			float num12 = vector6.y - vector5.y;
			float num13 = vector7.y - vector5.y;
			float num14 = 1f / (num10 * num13 - num11 * num12);
			Vector3 vector8 = new Vector3((num13 * num4 - num12 * num5) * num14, (num13 * num6 - num12 * num7) * num14, (num13 * num8 - num12 * num9) * num14);
			Vector3 vector9 = new Vector3((num10 * num5 - num11 * num4) * num14, (num10 * num7 - num11 * num6) * num14, (num10 * num9 - num11 * num8) * num14);
			tangent2 += vector8;
			zero += vector9;
			Vector3 normal2 = normal;
			Vector3.OrthoNormalize(ref normal2, ref tangent2);
			vector.x = tangent2.x;
			vector.y = tangent2.y;
			vector.z = tangent2.z;
			vector.w = ((Vector3.Dot(Vector3.Cross(normal2, tangent2), zero) < 0f) ? (-1f) : 1f);
			tangent = (Vector3)vector * vector.w;
			bitangent = Vector3.Cross(normal, tangent);
		}

		public static T Max<T>(T[] array) where T : IComparable<T>
		{
			if (array == null || array.Length < 1)
			{
				return default(T);
			}
			T val = array[0];
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i].CompareTo(val) >= 0)
				{
					val = array[i];
				}
			}
			return val;
		}

		public static T Min<T>(T[] array) where T : IComparable<T>
		{
			if (array == null || array.Length < 1)
			{
				return default(T);
			}
			T val = array[0];
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i].CompareTo(val) < 0)
				{
					val = array[i];
				}
			}
			return val;
		}

		public static float LargestValue(Vector3 v)
		{
			if (v.x > v.y && v.x > v.z)
			{
				return v.x;
			}
			if (v.y > v.x && v.y > v.z)
			{
				return v.y;
			}
			return v.z;
		}

		public static float LargestValue(Vector2 v)
		{
			if (!(v.x > v.y))
			{
				return v.y;
			}
			return v.x;
		}

		public static Vector2 SmallestVector2(Vector2[] v)
		{
			Vector2 result = v[0];
			for (int i = 1; i < v.Length; i++)
			{
				if (v[i].x < result.x)
				{
					result.x = v[i].x;
				}
				if (v[i].y < result.y)
				{
					result.y = v[i].y;
				}
			}
			return result;
		}

		public static Vector2 LargestVector2(Vector2[] v)
		{
			Vector2 result = v[0];
			for (int i = 0; i < v.Length; i++)
			{
				if (v[i].x > result.x)
				{
					result.x = v[i].x;
				}
				if (v[i].y > result.y)
				{
					result.y = v[i].y;
				}
			}
			return result;
		}

		public static Vector3 BoundsCenter(Vector3[] verts)
		{
			if (verts.Length < 1)
			{
				return Vector3.zero;
			}
			Vector3 vector = verts[0];
			Vector3 vector2 = vector;
			for (int i = 1; i < verts.Length; i++)
			{
				vector.x = Mathf.Min(verts[i].x, vector.x);
				vector2.x = Mathf.Max(verts[i].x, vector2.x);
				vector.y = Mathf.Min(verts[i].y, vector.y);
				vector2.y = Mathf.Max(verts[i].y, vector2.y);
				vector.z = Mathf.Min(verts[i].z, vector.z);
				vector2.z = Mathf.Max(verts[i].z, vector2.z);
			}
			return (vector + vector2) * 0.5f;
		}

		public static Vector2 Average(IList<Vector2> v, IList<int> indices = null)
		{
			Vector2 zero = Vector2.zero;
			float num = indices?.Count ?? v.Count;
			if (indices == null)
			{
				for (int i = 0; (float)i < num; i++)
				{
					zero += v[i];
				}
			}
			else
			{
				for (int j = 0; (float)j < num; j++)
				{
					zero += v[indices[j]];
				}
			}
			return zero / num;
		}

		public static Vector3 Average(IList<Vector3> v, IList<int> indices = null)
		{
			Vector3 zero = Vector3.zero;
			float num = indices?.Count ?? v.Count;
			if (indices == null)
			{
				for (int i = 0; (float)i < num; i++)
				{
					zero += v[i];
				}
			}
			else
			{
				for (int j = 0; (float)j < num; j++)
				{
					zero += v[indices[j]];
				}
			}
			return zero / num;
		}

		public static Vector3 Average<T>(this IList<T> v, Func<T, Vector3> selector, IList<int> indices = null)
		{
			Vector3 zero = Vector3.zero;
			float num = indices?.Count ?? v.Count;
			if (indices == null)
			{
				for (int i = 0; (float)i < num; i++)
				{
					zero += selector(v[i]);
				}
			}
			else
			{
				for (int j = 0; (float)j < num; j++)
				{
					zero += selector(v[indices[j]]);
				}
			}
			return zero / num;
		}

		public static Vector4 Average(IList<Vector4> v, IList<int> indices = null)
		{
			Vector4 zero = Vector4.zero;
			float num = indices?.Count ?? v.Count;
			if (indices == null)
			{
				for (int i = 0; (float)i < num; i++)
				{
					zero += v[i];
				}
			}
			else
			{
				for (int j = 0; (float)j < num; j++)
				{
					zero += v[indices[j]];
				}
			}
			return zero / num;
		}

		public static Color Average(IList<Color> c, IList<int> indices = null)
		{
			Color color = c[0];
			float num = indices?.Count ?? c.Count;
			if (indices == null)
			{
				for (int i = 1; (float)i < num; i++)
				{
					color += c[i];
				}
			}
			else
			{
				for (int j = 1; (float)j < num; j++)
				{
					color += c[indices[j]];
				}
			}
			return color / num;
		}

		public static bool Approx2(this Vector2 v, Vector2 b, float delta = 0.0001f)
		{
			if (Mathf.Abs(v.x - b.x) < delta)
			{
				return Mathf.Abs(v.y - b.y) < delta;
			}
			return false;
		}

		public static bool Approx3(this Vector3 v, Vector3 b, float delta = 0.0001f)
		{
			if (Mathf.Abs(v.x - b.x) < delta && Mathf.Abs(v.y - b.y) < delta)
			{
				return Mathf.Abs(v.z - b.z) < delta;
			}
			return false;
		}

		public static bool Approx4(this Vector4 v, Vector4 b, float delta = 0.0001f)
		{
			if (Mathf.Abs(v.x - b.x) < delta && Mathf.Abs(v.y - b.y) < delta && Mathf.Abs(v.z - b.z) < delta)
			{
				return Mathf.Abs(v.w - b.w) < delta;
			}
			return false;
		}

		public static bool ApproxC(this Color a, Color b, float delta = 0.0001f)
		{
			if (Mathf.Abs(a.r - b.r) < delta && Mathf.Abs(a.g - b.g) < delta && Mathf.Abs(a.b - b.b) < delta)
			{
				return Mathf.Abs(a.a - b.a) < delta;
			}
			return false;
		}

		public static bool Approx(this float a, float b, float delta)
		{
			return Mathf.Abs(b - a) < Mathf.Abs(delta);
		}

		public static bool ContainsApprox(Vector3[] v, Vector3 p, float eps)
		{
			for (int i = 0; i < v.Length; i++)
			{
				if (v[i].Approx3(p, eps))
				{
					return true;
				}
			}
			return false;
		}

		public static Vector2 ToMask(this Vector2 vec, float delta = float.Epsilon)
		{
			return new Vector2((Mathf.Abs(vec.x) > delta) ? 1f : 0f, (Mathf.Abs(vec.y) > delta) ? 1f : 0f);
		}

		public static Vector3 ToMask(this Vector3 vec, float delta = float.Epsilon)
		{
			return new Vector3((Mathf.Abs(vec.x) > delta) ? 1f : 0f, (Mathf.Abs(vec.y) > delta) ? 1f : 0f, (Mathf.Abs(vec.z) > delta) ? 1f : 0f);
		}

		public static Vector3 ToSignedMask(this Vector3 vec, float delta = float.Epsilon)
		{
			return new Vector3((Mathf.Abs(vec.x) > delta) ? (vec.x / Mathf.Abs(vec.x)) : 0f, (Mathf.Abs(vec.y) > delta) ? (vec.y / Mathf.Abs(vec.y)) : 0f, (Mathf.Abs(vec.z) > delta) ? (vec.z / Mathf.Abs(vec.z)) : 0f);
		}

		public static Vector3 Abs(this Vector3 v)
		{
			return new Vector3(Mathf.Abs(v.x), Mathf.Abs(v.y), Mathf.Abs(v.z));
		}

		public static int Sum(this Vector3 mask)
		{
			return (int)Mathf.Abs(mask.x) + (int)Mathf.Abs(mask.y) + (int)Mathf.Abs(mask.z);
		}
	}
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	public class pb_MeshRenderer : MonoBehaviour
	{
		public List<pb_Renderable> renderables = new List<pb_Renderable>();

		private readonly HideFlags SceneCameraHideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable;

		private int clamp(int val, int min, int max)
		{
			if (val >= min)
			{
				if (val <= max)
				{
					return val;
				}
				return max;
			}
			return min;
		}

		private void OnRenderObject()
		{
			if ((Camera.current.gameObject.hideFlags & SceneCameraHideFlags) != SceneCameraHideFlags || Camera.current.name != "SceneCamera")
			{
				return;
			}
			int num = 0;
			for (int i = 0; i < renderables.Count; i++)
			{
				if (renderables[i].materials == null)
				{
					Debug.Log("renderables[i].materials == null -> " + base.name);
				}
				Material[] materials = renderables[i].materials;
				if (renderables[i].mesh == null)
				{
					Debug.Log("renderables[i] mesh is null");
					continue;
				}
				for (int j = 0; j < renderables[i].mesh.subMeshCount; j++)
				{
					num = clamp(j, 0, materials.Length - 1);
					if (materials[num] == null || !materials[num].SetPass(0))
					{
						Debug.Log("material is null");
					}
					else
					{
						Graphics.DrawMeshNow(renderables[i].mesh, (renderables[i].transform != null) ? renderables[i].transform.localToWorldMatrix : Matrix4x4.identity, j);
					}
				}
			}
		}

		private void OnDestroy()
		{
			foreach (pb_Renderable renderable in renderables)
			{
				UnityEngine.Object.DestroyImmediate(renderable);
			}
		}
	}
	public class pb_MeshUtility
	{
		public static string Print(Mesh m)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine($"vertices: {m.vertexCount}\ntriangles: {m.triangles.Length}\nsubmeshes: {m.subMeshCount}");
			stringBuilder.AppendLine(string.Format("{0,-28}{1,-28}{2,-28}{3,-28}{4,-28}{5,-28}{6,-28}", "Positions", "Colors", "Tangents", "UV0", "UV2", "UV3", "UV4"));
			Vector3[] array = m.vertices;
			Color[] array2 = m.colors;
			Vector4[] array3 = m.tangents;
			List<Vector4> list = new List<Vector4>();
			Vector2[] array4 = m.uv2;
			List<Vector4> list2 = new List<Vector4>();
			List<Vector4> list3 = new List<Vector4>();
			m.GetUVs(0, list);
			m.GetUVs(2, list2);
			m.GetUVs(3, list3);
			if (array != null && array.Count() != m.vertexCount)
			{
				array = null;
			}
			if (array2 != null && array2.Count() != m.vertexCount)
			{
				array2 = null;
			}
			if (array3 != null && array3.Count() != m.vertexCount)
			{
				array3 = null;
			}
			if (list != null && list.Count() != m.vertexCount)
			{
				list = null;
			}
			if (array4 != null && array4.Count() != m.vertexCount)
			{
				array4 = null;
			}
			if (list2 != null && list2.Count() != m.vertexCount)
			{
				list2 = null;
			}
			if (list3 != null && list3.Count() != m.vertexCount)
			{
				list3 = null;
			}
			for (int i = 0; i < m.vertexCount; i++)
			{
				stringBuilder.AppendLine(string.Format("{0,-28}{1,-28}{2,-28}{3,-28}{4,-28}{5,-28}{6,-28}", (array == null) ? "null" : $"{array[i].x:F2}, {array[i].y:F2}, {array[i].z:F2}", (array2 == null) ? "null" : $"{array2[i].r:F2}, {array2[i].g:F2}, {array2[i].b:F2}, {array2[i].a:F2}", (array3 == null) ? "null" : $"{array3[i].x:F2}, {array3[i].y:F2}, {array3[i].z:F2}, {array3[i].w:F2}", (list == null) ? "null" : $"{list[i].x:F2}, {list[i].y:F2}, {list[i].z:F2}, {list[i].w:F2}", (array4 == null) ? "null" : $"{array4[i].x:F2}, {array4[i].y:F2}", (list2 == null) ? "null" : $"{list2[i].x:F2}, {list2[i].y:F2}, {list2[i].z:F2}, {list2[i].w:F2}", (list3 == null) ? "null" : $"{list3[i].x:F2}, {list3[i].y:F2}, {list3[i].z:F2}, {list3[i].w:F2}"));
			}
			for (int j = 0; j < m.triangles.Length; j += 3)
			{
				stringBuilder.AppendLine($"{m.triangles[j]}, {m.triangles[j + 1]}, {m.triangles[j + 2]}");
			}
			return stringBuilder.ToString();
		}

		public static pb_Vertex[] GeneratePerTriangleMesh(Mesh m)
		{
			pb_Vertex[] vertices = pb_Vertex.GetVertices(m);
			int subMeshCount = m.subMeshCount;
			pb_Vertex[] array = new pb_Vertex[m.triangles.Length];
			int[][] array2 = new int[subMeshCount][];
			int num = 0;
			for (int i = 0; i < subMeshCount; i++)
			{
				array2[i] = m.GetTriangles(i);
				int num2 = array2[i].Length;
				for (int j = 0; j < num2; j++)
				{
					array[num++] = new pb_Vertex(vertices[array2[i][j]]);
					array2[i][j] = num - 1;
				}
			}
			pb_Vertex.SetMesh(m, array);
			m.subMeshCount = subMeshCount;
			for (int k = 0; k < subMeshCount; k++)
			{
				m.SetTriangles(array2[k], k);
			}
			return array;
		}

		public static void CollapseSharedVertices(Mesh m, pb_Vertex[] vertices = null)
		{
			if (vertices == null)
			{
				vertices = pb_Vertex.GetVertices(m);
			}
			int subMeshCount = m.subMeshCount;
			List<Dictionary<pb_Vertex, int>> list = new List<Dictionary<pb_Vertex, int>>();
			int[][] array = new int[subMeshCount][];
			int num = 0;
			for (int i = 0; i < subMeshCount; i++)
			{
				array[i] = m.GetTriangles(i);
				Dictionary<pb_Vertex, int> dictionary = new Dictionary<pb_Vertex, int>();
				for (int j = 0; j < array[i].Length; j++)
				{
					pb_Vertex key = vertices[array[i][j]];
					if (dictionary.TryGetValue(key, out var value))
					{
						array[i][j] = value;
						continue;
					}
					array[i][j] = num;
					dictionary.Add(key, num);
					num++;
				}
				list.Add(dictionary);
			}
			pb_Vertex[] vertices2 = list.SelectMany((Dictionary<pb_Vertex, int> x) => x.Keys).ToArray();
			pb_Vertex.SetMesh(m, vertices2);
			m.subMeshCount = subMeshCount;
			for (int num2 = 0; num2 < subMeshCount; num2++)
			{
				m.SetTriangles(array[num2], num2);
			}
		}

		public static void GenerateTangent(ref Mesh InMesh)
		{
			int[] triangles = InMesh.triangles;
			Vector3[] vertices = InMesh.vertices;
			Vector2[] uv = InMesh.uv;
			Vector3[] normals = InMesh.normals;
			int num = triangles.Length;
			int num2 = vertices.Length;
			Vector3[] array = new Vector3[num2];
			Vector3[] array2 = new Vector3[num2];
			Vector4[] array3 = new Vector4[num2];
			for (long num3 = 0L; num3 < num; num3 += 3)
			{
				long num4 = triangles[num3];
				long num5 = triangles[num3 + 1];
				long num6 = triangles[num3 + 2];
				Vector3 vector = vertices[num4];
				Vector3 vector2 = vertices[num5];
				Vector3 vector3 = vertices[num6];
				Vector2 vector4 = uv[num4];
				Vector2 vector5 = uv[num5];
				Vector2 vector6 = uv[num6];
				float num7 = vector2.x - vector.x;
				float num8 = vector3.x - vector.x;
				float num9 = vector2.y - vector.y;
				float num10 = vector3.y - vector.y;
				float num11 = vector2.z - vector.z;
				float num12 = vector3.z - vector.z;
				float num13 = vector5.x - vector4.x;
				float num14 = vector6.x - vector4.x;
				float num15 = vector5.y - vector4.y;
				float num16 = vector6.y - vector4.y;
				float num17 = 1f / (num13 * num16 - num14 * num15);
				Vector3 vector7 = new Vector3((num16 * num7 - num15 * num8) * num17, (num16 * num9 - num15 * num10) * num17, (num16 * num11 - num15 * num12) * num17);
				Vector3 vector8 = new Vector3((num13 * num8 - num14 * num7) * num17, (num13 * num10 - num14 * num9) * num17, (num13 * num12 - num14 * num11) * num17);
				array[num4] += vector7;
				array[num5] += vector7;
				array[num6] += vector7;
				array2[num4] += vector8;
				array2[num5] += vector8;
				array2[num6] += vector8;
			}
			for (long num18 = 0L; num18 < num2; num18++)
			{
				Vector3 normal = normals[num18];
				Vector3 tangent = array[num18];
				Vector3.OrthoNormalize(ref normal, ref tangent);
				array3[num18].x = tangent.x;
				array3[num18].y = tangent.y;
				array3[num18].z = tangent.z;
				array3[num18].w = ((Vector3.Dot(Vector3.Cross(normal, tangent), array2[num18]) < 0f) ? (-1f) : 1f);
			}
			InMesh.tangents = array3;
		}

		public static Mesh DeepCopy(Mesh mesh)
		{
			Mesh mesh2 = new Mesh();
			CopyTo(mesh, mesh2);
			return mesh2;
		}

		public static void CopyTo(Mesh source, Mesh destination)
		{
			Vector3[] array = new Vector3[source.vertices.Length];
			int[][] array2 = new int[source.subMeshCount][];
			Vector2[] array3 = new Vector2[source.uv.Length];
			Vector2[] array4 = new Vector2[source.uv2.Length];
			Vector4[] array5 = new Vector4[source.tangents.Length];
			Vector3[] array6 = new Vector3[source.normals.Length];
			Color32[] array7 = new Color32[source.colors32.Length];
			Array.Copy(source.vertices, array, array.Length);
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = source.GetTriangles(i);
			}
			Array.Copy(source.uv, array3, array3.Length);
			Array.Copy(source.uv2, array4, array4.Length);
			Array.Copy(source.normals, array6, array6.Length);
			Array.Copy(source.tangents, array5, array5.Length);
			Array.Copy(source.colors32, array7, array7.Length);
			destination.Clear();
			destination.name = source.name;
			destination.vertices = array;
			destination.subMeshCount = array2.Length;
			for (int j = 0; j < array2.Length; j++)
			{
				destination.SetTriangles(array2[j], j);
			}
			destination.uv = array3;
			destination.uv2 = array4;
			destination.tangents = array5;
			destination.normals = array6;
			destination.colors32 = array7;
		}
	}
}
[AddComponentMenu("")]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(pb_Entity))]
[RequireComponent(typeof(MeshFilter))]
[ExecuteInEditMode]
public class pb_Object : MonoBehaviour
{
	[SerializeField]
	private pb_Face[] _quads;

	[SerializeField]
	private pb_IntArray[] _sharedIndices;

	[SerializeField]
	private Vector3[] _vertices;

	[SerializeField]
	private Vector2[] _uv;

	[SerializeField]
	private List<Vector4> _uv3;

	[SerializeField]
	private List<Vector4> _uv4;

	[SerializeField]
	private Vector4[] _tangents;

	[SerializeField]
	private pb_IntArray[] _sharedIndicesUV = new pb_IntArray[0];

	[SerializeField]
	private Color[] _colors;

	public bool userCollisions;

	public bool isSelectable = true;

	public pb_UnwrapParameters unwrapParameters = new pb_UnwrapParameters();

	public string asset_guid;

	public bool dontDestroyMeshOnDelete;

	[SerializeField]
	private int[] m_selectedFaces = new int[0];

	[SerializeField]
	private pb_Edge[] m_SelectedEdges = new pb_Edge[0];

	[SerializeField]
	private int[] m_selectedTriangles = new int[0];

	private pb_Face[] _faces => _quads;

	public Mesh msh
	{
		get
		{
			return GetComponent<MeshFilter>().sharedMesh;
		}
		set
		{
			base.gameObject.GetComponent<MeshFilter>().sharedMesh = value;
		}
	}

	public pb_Face[] faces => _quads;

	public pb_Face[] quads
	{
		get
		{
			Debug.LogWarning("pb_Quad is deprecated.  Please use pb_Face instead.");
			return _quads;
		}
	}

	public pb_IntArray[] sharedIndices => _sharedIndices;

	public pb_IntArray[] sharedIndicesUV => _sharedIndicesUV;

	public int id => base.gameObject.GetInstanceID();

	public Vector3[] vertices => _vertices;

	public Color[] colors => _colors;

	public Vector2[] uv => _uv;

	public bool hasUv3
	{
		get
		{
			if (_uv3 != null)
			{
				return _uv3.Count == vertexCount;
			}
			return false;
		}
	}

	public bool hasUv4
	{
		get
		{
			if (_uv4 != null)
			{
				return _uv4.Count == vertexCount;
			}
			return false;
		}
	}

	public List<Vector4> uv3 => _uv3;

	public List<Vector4> uv4 => _uv4;

	public int faceCount => _faces.Length;

	public int vertexCount => _vertices.Length;

	public int triangleCount => _faces.Sum((pb_Face x) => x.indices.Length);

	public pb_Face[] SelectedFaces => faces.ValuesWithIndices(m_selectedFaces);

	public int SelectedFaceCount => m_selectedFaces.Length;

	public int[] SelectedTriangles => m_selectedTriangles;

	public int SelectedTriangleCount => m_selectedTriangles.Length;

	public pb_Edge[] SelectedEdges => m_SelectedEdges;

	public int SelectedEdgeCount => m_SelectedEdges.Length;

	public static event Action<pb_Object> onDestroyObject;

	private void Awake()
	{
		if (!GetComponent<MeshRenderer>().isPartOfStaticBatch && (msh == null || msh.normals == null || msh.normals.Length != msh.vertexCount || msh.normals[0] == Vector3.zero) && _vertices != null)
		{
			ToMesh();
			Refresh();
		}
	}

	public static pb_Object InitWithObject(pb_Object pb)
	{
		Vector3[] array = new Vector3[pb.vertexCount];
		Array.Copy(pb.vertices, array, pb.vertexCount);
		Vector2[] array2 = new Vector2[pb.vertexCount];
		Array.Copy(pb.uv, array2, pb.vertexCount);
		Color[] array3 = new Color[pb.vertexCount];
		Array.Copy(pb.colors, array3, pb.vertexCount);
		pb_Face[] array4 = new pb_Face[pb.faces.Length];
		for (int i = 0; i < array4.Length; i++)
		{
			array4[i] = new pb_Face(pb.faces[i]);
		}
		pb_Object pb_Object2 = CreateInstanceWithElements(array, array2, array3, array4, pb.GetSharedIndices(), pb.GetSharedIndicesUV());
		pb_Object2.gameObject.name = pb.gameObject.name + "-clone";
		return pb_Object2;
	}

	public static pb_Object CreateInstanceWithPoints(Vector3[] vertices)
	{
		if (vertices.Length % 4 != 0)
		{
			Debug.LogWarning("Invalid Geometry.  Make sure vertices in are pairs of 4 (faces).");
			return null;
		}
		GameObject gameObject = new GameObject();
		pb_Object pb_Object2 = gameObject.AddComponent<pb_Object>();
		gameObject.name = "ProBuilder Mesh";
		pb_Object2.GeometryWithPoints(vertices);
		pb_Object2.GetComponent<pb_Entity>().SetEntity(EntityType.Detail);
		return pb_Object2;
	}

	public static pb_Object CreateInstanceWithVerticesFaces(Vector3[] v, pb_Face[] f)
	{
		GameObject gameObject = new GameObject();
		pb_Object pb_Object2 = gameObject.AddComponent<pb_Object>();
		gameObject.name = "ProBuilder Mesh";
		pb_Object2.GeometryWithVerticesFaces(v, f);
		return pb_Object2;
	}

	public static pb_Object CreateInstanceWithElements(Vector3[] v, Vector2[] u, Color[] c, pb_Face[] f, pb_IntArray[] si, pb_IntArray[] si_uv)
	{
		GameObject gameObject = new GameObject();
		pb_Object pb_Object2 = gameObject.AddComponent<pb_Object>();
		pb_Object2.SetVertices(v);
		pb_Object2.SetUV(u);
		pb_Object2.SetColors(c);
		pb_Object2.SetSharedIndices(si ?? pb_IntArrayUtility.ExtractSharedIndices(v));
		pb_Object2.SetSharedIndicesUV(si_uv ?? new pb_IntArray[0]);
		pb_Object2.SetFaces(f);
		pb_Object2.ToMesh();
		pb_Object2.Refresh();
		pb_Object2.GetComponent<pb_Entity>().SetEntity(EntityType.Detail);
		return pb_Object2;
	}

	public static pb_Object CreateInstanceWithElements(pb_Vertex[] vertices, pb_Face[] faces, pb_IntArray[] si, pb_IntArray[] si_uv)
	{
		GameObject gameObject = new GameObject();
		pb_Object pb_Object2 = gameObject.AddComponent<pb_Object>();
		pb_Vertex.GetArrays(vertices, out var position, out var color, out var uv, out var _, out var _, out var _, out var list, out var list2);
		pb_Object2.SetVertices(position);
		pb_Object2.SetColors(color);
		pb_Object2.SetUV(uv);
		if (list != null)
		{
			pb_Object2._uv3 = list;
		}
		if (list2 != null)
		{
			pb_Object2._uv4 = list2;
		}
		pb_Object2.SetSharedIndices(si ?? pb_IntArrayUtility.ExtractSharedIndices(position));
		pb_Object2.SetSharedIndicesUV(si_uv ?? new pb_IntArray[0]);
		pb_Object2.SetFaces(faces);
		pb_Object2.ToMesh();
		pb_Object2.Refresh();
		pb_Object2.GetComponent<pb_Entity>().SetEntity(EntityType.Detail);
		return pb_Object2;
	}

	public pb_IntArray[] GetSharedIndices()
	{
		int num = _sharedIndices.Length;
		pb_IntArray[] array = new pb_IntArray[num];
		for (int i = 0; i < num; i++)
		{
			int[] array2 = new int[_sharedIndices[i].Length];
			Array.Copy(_sharedIndices[i].array, array2, array2.Length);
			array[i] = new pb_IntArray(array2);
		}
		return array;
	}

	public pb_IntArray[] GetSharedIndicesUV()
	{
		int num = _sharedIndicesUV.Length;
		pb_IntArray[] array = new pb_IntArray[num];
		for (int i = 0; i < num; i++)
		{
			int[] array2 = new int[_sharedIndicesUV[i].Length];
			Array.Copy(_sharedIndicesUV[i].array, array2, array2.Length);
			array[i] = new pb_IntArray(array2);
		}
		return array;
	}

	public void AddToFaceSelection(pb_Face face)
	{
		int num = Array.IndexOf(faces, face);
		if (num > -1)
		{
			SetSelectedFaces(m_selectedFaces.Add(num));
		}
	}

	public void SetSelectedFaces(IEnumerable<pb_Face> selected)
	{
		List<int> list = new List<int>();
		foreach (pb_Face item in selected)
		{
			int num = Array.IndexOf(faces, item);
			if (num > -1)
			{
				list.Add(num);
			}
		}
		SetSelectedFaces(list);
	}

	public void SetSelectedFaces(IEnumerable<int> selected)
	{
		m_selectedFaces = selected.ToArray();
		m_selectedTriangles = pb_Face.AllTriangles(SelectedFaces);
		pb_Edge[] array = pb_Edge.AllEdges(SelectedFaces);
		int num = array.Length;
		m_SelectedEdges = new pb_Edge[num];
		for (int i = 0; i < num; i++)
		{
			m_SelectedEdges[i] = new pb_Edge(array[i]);
		}
	}

	public void SetSelectedEdges(IEnumerable<pb_Edge> edges)
	{
		m_selectedFaces = new int[0];
		m_SelectedEdges = edges.Select((pb_Edge x) => new pb_Edge(x)).ToArray();
		m_selectedTriangles = m_SelectedEdges.AllTriangles();
	}

	public void SetSelectedTriangles(int[] tris)
	{
		m_selectedFaces = new int[0];
		m_SelectedEdges = new pb_Edge[0];
		m_selectedTriangles = tris ?? new int[0];
	}

	public void RemoveFromFaceSelectionAtIndex(int index)
	{
		SetSelectedFaces(m_selectedFaces.RemoveAt(index));
	}

	public void RemoveFromFaceSelection(pb_Face face)
	{
		int num = Array.IndexOf(faces, face);
		if (num > -1)
		{
			SetSelectedFaces(m_selectedFaces.Remove(num));
		}
	}

	public void ClearSelection()
	{
		m_selectedFaces = new int[0];
		m_SelectedEdges = new pb_Edge[0];
		m_selectedTriangles = new int[0];
	}

	public void SetVertices(Vector3[] v)
	{
		_vertices = v;
	}

	public void SetVertices(IList<pb_Vertex> vertices, bool applyMesh = false)
	{
		pb_Vertex.GetArrays(vertices, out var position, out var color, out var uv, out var normal, out var tangent, out var uv2, out var list, out var list2);
		SetVertices(position);
		SetColors(color);
		SetUV(uv);
		if (list != null)
		{
			_uv3 = list;
		}
		if (list2 != null)
		{
			_uv4 = list2;
		}
		if (applyMesh)
		{
			Mesh mesh = msh;
			pb_Vertex pb_Vertex = vertices[0];
			if (pb_Vertex.hasPosition)
			{
				mesh.vertices = position;
			}
			if (pb_Vertex.hasColor)
			{
				mesh.colors = color;
			}
			if (pb_Vertex.hasUv0)
			{
				mesh.uv = uv;
			}
			if (pb_Vertex.hasNormal)
			{
				mesh.normals = normal;
			}
			if (pb_Vertex.hasTangent)
			{
				mesh.tangents = tangent;
			}
			if (pb_Vertex.hasUv2)
			{
				mesh.uv2 = uv2;
			}
			if (pb_Vertex.hasUv3 && list != null)
			{
				mesh.SetUVs(2, list);
			}
			if (pb_Vertex.hasUv4 && list2 != null)
			{
				mesh.SetUVs(3, list2);
			}
		}
	}

	public void SetUV(Vector2[] uvs)
	{
		_uv = uvs;
	}

	public void SetFaces(pb_Face[] _qds)
	{
		_quads = _qds.Where((pb_Face x) => x != null).ToArray();
		if (_quads.Length != _qds.Length)
		{
			Debug.LogWarning("SetFaces() pruned " + (_qds.Length - _quads.Length) + " null faces from this object.");
		}
	}

	public void SetSharedIndices(pb_IntArray[] si)
	{
		_sharedIndices = si;
	}

	public void SetSharedIndices(Dictionary<int, int> si)
	{
		_sharedIndices = si.ToSharedIndices();
	}

	public void SetSharedIndicesUV(pb_IntArray[] si)
	{
		_sharedIndicesUV = si;
	}

	public void SetSharedIndicesUV(Dictionary<int, int> si)
	{
		_sharedIndicesUV = si.ToSharedIndices();
	}

	private void GeometryWithPoints(Vector3[] v)
	{
		pb_Face[] array = new pb_Face[v.Length / 4];
		for (int i = 0; i < v.Length; i += 4)
		{
			array[i / 4] = new pb_Face(new int[6]
			{
				i,
				i + 1,
				i + 2,
				i + 1,
				i + 3,
				i + 2
			}, pb_Constant.DefaultMaterial, new pb_UV(), 0, -1, -1, manualUV: false);
		}
		SetVertices(v);
		SetUV(new Vector2[v.Length]);
		SetColors(pbUtil.FilledArray(Color.white, v.Length));
		SetFaces(array);
		SetSharedIndices(pb_IntArrayUtility.ExtractSharedIndices(v));
		ToMesh();
		Refresh();
	}

	public void GeometryWithVerticesFaces(Vector3[] v, pb_Face[] f)
	{
		SetVertices(v);
		SetUV(new Vector2[v.Length]);
		SetFaces(f);
		SetSharedIndices(pb_IntArrayUtility.ExtractSharedIndices(v));
		ToMesh();
		Refresh();
	}

	private void GeometryWithVerticesFacesIndices(Vector3[] v, pb_Face[] f, pb_IntArray[] s)
	{
		SetFaces(f);
		SetVertices(v);
		SetUV(new Vector2[v.Length]);
		SetSharedIndices(s);
		if (msh != null)
		{
			UnityEngine.Object.DestroyImmediate(msh);
		}
		ToMesh();
		Refresh();
	}

	public MeshRebuildReason Verify()
	{
		if (msh == null)
		{
			try
			{
				ToMesh();
				Refresh();
			}
			catch (Exception ex)
			{
				Debug.LogError("Failed rebuilding null pb_Object.  Cached mesh attributes are invalid or missing.\n" + ex.ToString());
			}
			return MeshRebuildReason.Null;
		}
		int.TryParse(msh.name.Replace("pb_Mesh", ""), out var result);
		if (result != id)
		{
			return MeshRebuildReason.InstanceIDMismatch;
		}
		if (msh.uv2 != null)
		{
			return MeshRebuildReason.None;
		}
		return MeshRebuildReason.Lightmap;
	}

	public void ToMesh()
	{
		Mesh mesh = msh;
		if (mesh != null && mesh.vertexCount == _vertices.Length)
		{
			mesh = msh;
			mesh.vertices = _vertices;
			if (_uv != null)
			{
				mesh.uv = _uv;
			}
		}
		else
		{
			if (mesh == null)
			{
				mesh = new Mesh();
			}
			else
			{
				mesh.Clear();
			}
			mesh.vertices = _vertices;
		}
		mesh.uv2 = null;
		mesh.subMeshCount = pb_Face.MeshTriangles(faces, out var submeshes, out var materials);
		for (int i = 0; i < submeshes.Length; i++)
		{
			mesh.SetTriangles(submeshes[i], i);
		}
		mesh.name = "pb_Mesh" + id;
		GetComponent<MeshFilter>().sharedMesh = mesh;
		GetComponent<MeshRenderer>().sharedMaterials = materials;
	}

	public void MakeUnique()
	{
		pb_Face[] array = new pb_Face[_faces.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = new pb_Face(_faces[i]);
		}
		pb_IntArray[] array2 = new pb_IntArray[_sharedIndices.Length];
		Array.Copy(_sharedIndices, array2, array2.Length);
		SetSharedIndices(array2);
		SetFaces(array);
		Vector3[] destinationArray = new Vector3[vertexCount];
		Array.Copy(_vertices, destinationArray, vertexCount);
		SetVertices(destinationArray);
		if (_uv != null && _uv.Length == vertexCount)
		{
			Vector2[] array3 = new Vector2[vertexCount];
			Array.Copy(_uv, array3, vertexCount);
			SetUV(array3);
		}
		msh = new Mesh();
		ToMesh();
		Refresh();
	}

	public void Refresh()
	{
		RefreshUV();
		RefreshColors();
		RefreshNormals();
		RefreshTangents();
		RefreshCollisions();
	}

	public void RefreshCollisions()
	{
		Mesh mesh = msh;
		mesh.RecalculateBounds();
		if (userCollisions || !GetComponent<Collider>())
		{
			return;
		}
		Collider[] components = base.gameObject.GetComponents<Collider>();
		foreach (Collider collider in components)
		{
			Type type = collider.GetType();
			if (type == typeof(BoxCollider))
			{
				((BoxCollider)collider).center = mesh.bounds.center;
				((BoxCollider)collider).size = mesh.bounds.size;
			}
			else if (type == typeof(SphereCollider))
			{
				((SphereCollider)collider).center = mesh.bounds.center;
				((SphereCollider)collider).radius = pb_Math.LargestValue(mesh.bounds.extents);
			}
			else if (type == typeof(CapsuleCollider))
			{
				((CapsuleCollider)collider).center = mesh.bounds.center;
				Vector2 v = new Vector2(mesh.bounds.extents.x, mesh.bounds.extents.z);
				((CapsuleCollider)collider).radius = pb_Math.LargestValue(v);
				((CapsuleCollider)collider).height = mesh.bounds.size.y;
			}
			else if (type == typeof(WheelCollider))
			{
				((WheelCollider)collider).center = mesh.bounds.center;
				((WheelCollider)collider).radius = pb_Math.LargestValue(mesh.bounds.extents);
			}
			else if (type == typeof(MeshCollider))
			{
				base.gameObject.GetComponent<MeshCollider>().sharedMesh = null;
				base.gameObject.GetComponent<MeshCollider>().sharedMesh = mesh;
			}
		}
	}

	public int GetUnusedTextureGroup(int i = 1)
	{
		while (Array.Exists(faces, (pb_Face element) => element.textureGroup == i))
		{
			i++;
		}
		return i;
	}

	public int UnusedElementGroup(int i = 1)
	{
		while (Array.Exists(faces, (pb_Face element) => element.elementGroup == i))
		{
			i++;
		}
		return i;
	}

	public void RefreshUV()
	{
		RefreshUV(faces);
	}

	public void GetUVs(int channel, List<Vector4> uvs)
	{
		uvs.Clear();
		switch (channel)
		{
		default:
		{
			for (int j = 0; j < vertexCount; j++)
			{
				uvs.Add(_uv[j]);
			}
			break;
		}
		case 1:
			if (msh != null && msh.uv2 != null)
			{
				Vector2[] uv = msh.uv2;
				for (int i = 0; i < uv.Length; i++)
				{
					uvs.Add(uv[i]);
				}
			}
			break;
		case 2:
			if (_uv3 != null)
			{
				uvs.AddRange(_uv3);
			}
			break;
		case 3:
			if (_uv4 != null)
			{
				uvs.AddRange(_uv4);
			}
			break;
		}
	}

	public void SetUVs(int channel, List<Vector4> uvs)
	{
		switch (channel)
		{
		case 1:
			msh.uv2 = uvs.Cast<Vector2>().ToArray();
			break;
		case 2:
			_uv3 = uvs;
			break;
		case 3:
			_uv4 = uvs;
			break;
		default:
			_uv = uvs.Cast<Vector2>().ToArray();
			break;
		}
	}

	public void RefreshUV(IEnumerable<pb_Face> facesToRefresh)
	{
		Vector2[] array;
		if (_uv != null && _uv.Length == vertexCount)
		{
			array = _uv;
		}
		else if (msh.uv != null && msh.uv.Length == vertexCount)
		{
			array = msh.uv;
		}
		else
		{
			pb_Face[] array2 = faces;
			foreach (pb_Face pb_Face in array2)
			{
				pb_Face.manualUV = false;
			}
			facesToRefresh = faces;
			array = new Vector2[vertexCount];
		}
		int num = -2;
		Dictionary<int, List<pb_Face>> dictionary = new Dictionary<int, List<pb_Face>>();
		foreach (pb_Face item in facesToRefresh)
		{
			if (item != null && !item.manualUV)
			{
				if (item.textureGroup > 0 && dictionary.ContainsKey(item.textureGroup))
				{
					dictionary[item.textureGroup].Add(item);
					continue;
				}
				dictionary.Add((item.textureGroup > 0) ? item.textureGroup : num--, new List<pb_Face>(1) { item });
			}
		}
		if (faces.Length != facesToRefresh.Count())
		{
			pb_Face[] array3 = faces;
			foreach (pb_Face pb_Face2 in array3)
			{
				if (!pb_Face2.manualUV && dictionary.ContainsKey(pb_Face2.textureGroup) && !dictionary[pb_Face2.textureGroup].Contains(pb_Face2))
				{
					dictionary[pb_Face2.textureGroup].Add(pb_Face2);
				}
			}
		}
		num = 0;
		foreach (KeyValuePair<int, List<pb_Face>> item2 in dictionary)
		{
			Vector3 vector;
			if (item2.Value.Count > 1)
			{
				vector = pb_Projection.FindBestPlane(_vertices, item2.Value.SelectMany((pb_Face x) => x.distinctIndices).ToList()).normal;
			}
			else
			{
				pb_Face pb_Face3 = item2.Value[0];
				vector = ((pb_Face3.indices.Length >= 7) ? pb_Projection.FindBestPlane(_vertices, pb_Face3.distinctIndices).normal : pb_Math.Normal(_vertices[pb_Face3.indices[0]], _vertices[pb_Face3.indices[1]], _vertices[pb_Face3.indices[2]]));
			}
			Vector2[] array4;
			if (item2.Value[0].uv.useWorldSpace)
			{
				vector = base.transform.TransformDirection(vector);
				array4 = pb_UVUtility.PlanarMap(base.transform.ToWorldSpace(vertices.ValuesWithIndices(pb_Face.AllTrianglesDistinct(item2.Value).ToArray())), item2.Value[0].uv, vector);
			}
			else
			{
				array4 = pb_UVUtility.PlanarMap(vertices.ValuesWithIndices(pb_Face.AllTrianglesDistinct(item2.Value).ToArray()), item2.Value[0].uv, vector);
			}
			int num2 = 0;
			Vector2 localPivot = item2.Value[0].uv.localPivot;
			Vector2 localSize = item2.Value[0].uv.localSize;
			foreach (pb_Face item3 in item2.Value)
			{
				item3.uv.localPivot = localPivot;
				item3.uv.localSize = localSize;
				int[] distinctIndices = item3.distinctIndices;
				foreach (int num4 in distinctIndices)
				{
					ref Vector2 reference = ref array[num4];
					reference = array4[num2++];
				}
			}
		}
		_uv = array;
		msh.uv = array;
	}

	public void SetFaceMaterial(pb_Face[] quad, Material mat)
	{
		for (int i = 0; i < quad.Length; i++)
		{
			quad[i].material = mat;
		}
	}

	public void SetUV2(Vector2[] v)
	{
		GetComponent<MeshFilter>().sharedMesh.uv2 = v;
	}

	public void RefreshColors()
	{
		Mesh sharedMesh = GetComponent<MeshFilter>().sharedMesh;
		if (_colors == null || _colors.Length != vertexCount)
		{
			_colors = pbUtil.FilledArray(Color.white, vertexCount);
		}
		sharedMesh.colors = _colors;
	}

	public void SetColors(Color[] InColors)
	{
		_colors = ((InColors.Length == vertexCount) ? InColors : pbUtil.FilledArray(Color.white, vertexCount));
	}

	public void SetFaceColor(pb_Face face, Color color)
	{
		if (_colors == null)
		{
			_colors = pbUtil.FilledArray(Color.white, vertexCount);
		}
		int[] distinctIndices = face.distinctIndices;
		foreach (int num in distinctIndices)
		{
			_colors[num] = color;
		}
	}

	public void SetTangents(Vector4[] tangents)
	{
		_tangents = tangents;
	}

	public void RefreshNormals()
	{
		msh.RecalculateNormals();
		Vector3[] normals = msh.normals;
		int[] array = new int[normals.Length];
		pb_Face[] array2 = faces;
		foreach (pb_Face pb_Face in array2)
		{
			int[] distinctIndices = pb_Face.distinctIndices;
			foreach (int num in distinctIndices)
			{
				array[num] = pb_Face.smoothingGroup;
			}
		}
		for (int k = 0; k < sharedIndices.Length; k++)
		{
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array3 = sharedIndices[k].array;
			foreach (int num2 in array3)
			{
				if (array[num2] >= 1 && array[num2] <= 24)
				{
					if (dictionary.TryGetValue(array[num2], out var value))
					{
						value.Add(num2);
						continue;
					}
					dictionary.Add(array[num2], new List<int> { num2 });
				}
			}
			foreach (KeyValuePair<int, List<int>> item in dictionary)
			{
				Vector3 zero = Vector3.zero;
				List<int> value2 = item.Value;
				for (int m = 0; m < value2.Count; m++)
				{
					zero += normals[value2[m]];
				}
				zero = (zero / item.Value.Count).normalized;
				foreach (int item2 in item.Value)
				{
					normals[item2] = zero;
				}
			}
		}
		GetComponent<MeshFilter>().sharedMesh.normals = normals;
	}

	public void RefreshTangents()
	{
		Mesh InMesh = GetComponent<MeshFilter>().sharedMesh;
		if (_tangents != null && _tangents.Length == vertexCount)
		{
			InMesh.tangents = _tangents;
		}
		else
		{
			pb_MeshUtility.GenerateTangent(ref InMesh);
		}
	}

	public void OnDestroy()
	{
		if (!dontDestroyMeshOnDelete)
		{
			if (pb_Object.onDestroyObject != null)
			{
				pb_Object.onDestroyObject(this);
			}
			else
			{
				UnityEngine.Object.DestroyImmediate(base.gameObject.GetComponent<MeshFilter>().sharedMesh, allowDestroyingAssets: true);
			}
		}
	}
}
namespace ProBuilder2.Common
{
	public class pb_ObjectPool<T> where T : UnityEngine.Object, new()
	{
		public int desiredSize;

		public Func<T> constructor;

		public Action<T> destructor;

		private Queue pool = new Queue();

		public pb_ObjectPool(int initialSize, int desiredSize, Func<T> constructor, Action<T> destructor)
		{
			this.constructor = constructor;
			this.destructor = ((destructor == null) ? new Action<T>(DestroyObject) : destructor);
			this.desiredSize = desiredSize;
			for (int i = 0; i < initialSize && i < desiredSize; i++)
			{
				pool.Enqueue((constructor != null) ? constructor() : new T());
			}
		}

		public T Get()
		{
			T val = ((pool.Count > 0) ? ((T)pool.Dequeue()) : null);
			if (val == null)
			{
				val = ((constructor == null) ? new T() : constructor());
			}
			return val;
		}

		public void Put(T obj)
		{
			if (pool.Count < desiredSize)
			{
				pool.Enqueue(obj);
			}
			else
			{
				UnityEngine.Object.DestroyImmediate(obj);
			}
		}

		public void Empty()
		{
			int count = pool.Count;
			for (int i = 0; i < count; i++)
			{
				if (destructor != null)
				{
					destructor((T)pool.Dequeue());
				}
				else
				{
					DestroyObject((T)pool.Dequeue());
				}
			}
		}

		private static void DestroyObject(T obj)
		{
			UnityEngine.Object.DestroyImmediate(obj);
		}

		private void OnDestroy()
		{
			Empty();
		}
	}
	public static class pb_Projection
	{
		public static Vector2[] PlanarProject(IList<Vector3> verts, Vector3 planeNormal)
		{
			return PlanarProject(verts, planeNormal, VectorToProjectionAxis(planeNormal));
		}

		public static Vector2[] PlanarProject(pb_Object pb, pb_Face face)
		{
			Vector3 vector = pb_Math.Normal(pb, face);
			return PlanarProject(pb.vertices, vector, VectorToProjectionAxis(vector), face.indices);
		}

		public static Vector2[] PlanarProject(IList<Vector3> verts, Vector3 planeNormal, ProjectionAxis projectionAxis, IList<int> indices = null)
		{
			int num = ((indices == null || indices.Count < 1) ? verts.Count : indices.Count);
			Vector2[] array = new Vector2[num];
			Vector3 rhs = Vector3.zero;
			switch (projectionAxis)
			{
			case ProjectionAxis.X:
			case ProjectionAxis.X_Negative:
				rhs = Vector3.up;
				break;
			case ProjectionAxis.Y:
			case ProjectionAxis.Y_Negative:
				rhs = Vector3.forward;
				break;
			case ProjectionAxis.Z:
			case ProjectionAxis.Z_Negative:
				rhs = Vector3.up;
				break;
			}
			Vector3 lhs = Vector3.Cross(planeNormal, rhs);
			lhs.Normalize();
			Vector3 lhs2 = Vector3.Cross(lhs, planeNormal);
			lhs2.Normalize();
			for (int i = 0; i < num; i++)
			{
				int index = indices?[i] ?? i;
				float x = Vector3.Dot(lhs, verts[index]);
				float y = Vector3.Dot(lhs2, verts[index]);
				ref Vector2 reference = ref array[i];
				reference = new Vector2(x, y);
			}
			return array;
		}

		public static Vector2[] PlanarProject(IList<pb_Vertex> vertices, IList<int> indices)
		{
			int count = indices.Count;
			Vector3[] array = new Vector3[count];
			for (int i = 0; i < count; i++)
			{
				ref Vector3 reference = ref array[i];
				reference = vertices[indices[i]].position;
			}
			Vector3 vector = pb_Math.Normal(vertices, indices);
			ProjectionAxis projectionAxis = VectorToProjectionAxis(vector);
			return PlanarProject(array, vector, projectionAxis);
		}

		public static Vector2[] SphericalProject(IList<Vector3> vertices, IList<int> indices = null)
		{
			int num = indices?.Count ?? vertices.Count;
			Vector2[] array = new Vector2[num];
			Vector3 vector = pb_Math.Average(vertices, indices);
			for (int i = 0; i < num; i++)
			{
				int index = indices?[i] ?? i;
				Vector3 vector2 = vertices[index] - vector;
				vector2.Normalize();
				array[i].x = 0.5f + Mathf.Atan2(vector2.z, vector2.x) / ((float)System.Math.PI * 2f);
				array[i].y = 0.5f - Mathf.Asin(vector2.y) / (float)System.Math.PI;
			}
			return array;
		}

		public static IList<Vector2> Sort(IList<Vector2> verts, SortMethod method = SortMethod.CounterClockwise)
		{
			Vector2 vector = pb_Math.Average(verts);
			Vector2 up = Vector2.up;
			int count = verts.Count;
			List<pb_Tuple<float, Vector2>> list = new List<pb_Tuple<float, Vector2>>(count);
			for (int i = 0; i < count; i++)
			{
				list.Add(new pb_Tuple<float, Vector2>(pb_Math.SignedAngle(up, verts[i] - vector), verts[i]));
			}
			list.Sort((pb_Tuple<float, Vector2> a, pb_Tuple<float, Vector2> b) => (!(a.Item1 < b.Item1)) ? 1 : (-1));
			IList<Vector2> list2 = list.Select((pb_Tuple<float, Vector2> x) => x.Item2).ToList();
			if (method == SortMethod.Clockwise)
			{
				list2.Reverse();
			}
			return list2;
		}

		public static Vector3 ProjectionAxisToVector(ProjectionAxis axis)
		{
			return axis switch
			{
				ProjectionAxis.X => Vector3.right, 
				ProjectionAxis.Y => Vector3.up, 
				ProjectionAxis.Z => Vector3.forward, 
				ProjectionAxis.X_Negative => -Vector3.right, 
				ProjectionAxis.Y_Negative => -Vector3.up, 
				ProjectionAxis.Z_Negative => -Vector3.forward, 
				_ => Vector3.zero, 
			};
		}

		public static ProjectionAxis VectorToProjectionAxis(Vector3 plane)
		{
			if (Mathf.Abs(plane.x) > Mathf.Abs(plane.y) && Mathf.Abs(plane.x) > Mathf.Abs(plane.z))
			{
				if (!(plane.x > 0f))
				{
					return ProjectionAxis.X_Negative;
				}
				return ProjectionAxis.X;
			}
			if (Mathf.Abs(plane.y) > Mathf.Abs(plane.z))
			{
				if (!(plane.y > 0f))
				{
					return ProjectionAxis.Y_Negative;
				}
				return ProjectionAxis.Y;
			}
			if (!(plane.z > 0f))
			{
				return ProjectionAxis.Z_Negative;
			}
			return ProjectionAxis.Z;
		}

		public static Plane FindBestPlane<T>(IList<T> points, Func<T, Vector3> selector, IList<int> indices = null)
		{
			float num = 0f;
			float num2 = 0f;
			float num3 = 0f;
			float num4 = 0f;
			float num5 = 0f;
			float num6 = 0f;
			bool flag = indices != null && indices.Count > 0;
			int num7 = (flag ? indices.Count : points.Count);
			Vector3 vector = points.Average(selector, indices);
			for (int i = 0; i < num7; i++)
			{
				Vector3 vector2 = selector(points[flag ? indices[i] : i]) - vector;
				num += vector2.x * vector2.x;
				num2 += vector2.x * vector2.y;
				num3 += vector2.x * vector2.z;
				num4 += vector2.y * vector2.y;
				num5 += vector2.y * vector2.z;
				num6 += vector2.z * vector2.z;
			}
			float num8 = num4 * num6 - num5 * num5;
			float num9 = num * num6 - num3 * num3;
			float num10 = num * num4 - num2 * num2;
			Vector3 inNormal = ((num8 > num9 && num8 > num10) ? new Vector3(1f, (num3 * num5 - num2 * num6) / num8, (num2 * num5 - num3 * num4) / num8) : ((!(num9 > num10)) ? new Vector3((num5 * num2 - num3 * num4) / num10, (num3 * num2 - num5 * num) / num10, 1f) : new Vector3((num5 * num3 - num2 * num6) / num9, 1f, (num2 * num3 - num5 * num) / num9)));
			inNormal.Normalize();
			return new Plane(inNormal, vector);
		}

		public static Plane FindBestPlane(IList<Vector3> points, IList<int> indices = null)
		{
			float num = 0f;
			float num2 = 0f;
			float num3 = 0f;
			float num4 = 0f;
			float num5 = 0f;
			float num6 = 0f;
			bool flag = indices != null && indices.Count > 0;
			int num7 = (flag ? indices.Count : points.Count);
			Vector3 vector = pb_Math.Average(points, indices);
			for (int i = 0; i < num7; i++)
			{
				Vector3 vector2 = points[flag ? indices[i] : i] - vector;
				num += vector2.x * vector2.x;
				num2 += vector2.x * vector2.y;
				num3 += vector2.x * vector2.z;
				num4 += vector2.y * vector2.y;
				num5 += vector2.y * vector2.z;
				num6 += vector2.z * vector2.z;
			}
			float num8 = num4 * num6 - num5 * num5;
			float num9 = num * num6 - num3 * num3;
			float num10 = num * num4 - num2 * num2;
			Vector3 inNormal = ((num8 > num9 && num8 > num10) ? new Vector3(1f, (num3 * num5 - num2 * num6) / num8, (num2 * num5 - num3 * num4) / num8) : ((!(num9 > num10)) ? new Vector3((num5 * num2 - num3 * num4) / num10, (num3 * num2 - num5 * num) / num10, 1f) : new Vector3((num5 * num3 - num2 * num6) / num9, 1f, (num2 * num3 - num5 * num) / num9)));
			inNormal.Normalize();
			return new Plane(inNormal, vector);
		}
	}
	public static class pb_Reflection
	{
		private const BindingFlags ALL_FLAGS = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

		public static bool enableWarnings = true;

		private static void Warning(string text)
		{
			if (enableWarnings)
			{
				Debug.LogWarning(text);
			}
		}

		public static object GetComponent(this GameObject gameObject, string componentTypeName)
		{
			return gameObject.GetComponent(componentTypeName);
		}

		public static Type GetType(string type, string assembly = null)
		{
			Type type2 = Type.GetType(type);
			if (type2 == null)
			{
				IEnumerable<Assembly> enumerable = AppDomain.CurrentDomain.GetAssemblies();
				if (assembly != null)
				{
					enumerable = enumerable.Where((Assembly x) => x.FullName.Contains(assembly));
				}
				foreach (Assembly item in enumerable)
				{
					type2 = item.GetType(type);
					if (type2 != null)
					{
						return type2;
					}
				}
			}
			return type2;
		}

		public static object Invoke(object target, string method, BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, params object[] args)
		{
			if (target == null)
			{
				Warning("Invoke failed, target is null and no type was provided.");
				return null;
			}
			return Invoke(target, target.GetType(), method, null, flags, args);
		}

		public static object Invoke(object target, string type, string method, BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, string assembly = null, params object[] args)
		{
			Type type2 = GetType(type, assembly);
			if (type2 == null && target != null)
			{
				type2 = target.GetType();
			}
			if (type2 != null)
			{
				return Invoke(target, type2, method, null, flags, args);
			}
			Warning("Invoke failed, type is null: " + type);
			return null;
		}

		public static object Invoke(object target, Type type, string method, Type[] methodParams = null, BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, params object[] args)
		{
			MethodInfo methodInfo = null;
			methodInfo = ((methodParams != null) ? type.GetMethod(method, flags, null, methodParams, null) : type.GetMethod(method, flags));
			if (methodInfo == null)
			{
				Warning("Failed to find method " + method + " in type " + type);
				return null;
			}
			return methodInfo.Invoke(target, args);
		}

		public static object GetValue(object target, string type, string member, BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
		{
			Type type2 = GetType(type);
			if (type2 == null)
			{
				Warning($"Could not find type \"{type}\"!");
				return null;
			}
			return GetValue(target, type2, member, flags);
		}

		public static object GetValue(object target, Type type, string member, BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
		{
			PropertyInfo property = type.GetProperty(member, flags);
			if (property != null)
			{
				return property.GetValue(target, null);
			}
			return type.GetField(member, flags)?.GetValue(target);
		}

		public static bool SetValue(object target, string member, object value, BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
		{
			if (target == null)
			{
				return false;
			}
			PropertyInfo property = target.GetType().GetProperty(member, flags);
			property?.SetValue(target, value, flags, null, null, null);
			FieldInfo field = target.GetType().GetField(member, flags);
			field?.SetValue(target, value);
			if (property == null)
			{
				return field != null;
			}
			return true;
		}
	}
	public static class pb_SelectionPicker
	{
		public static Dictionary<pb_Object, HashSet<pb_Face>> PickFacesInRect(Camera camera, Rect pickerRect, IEnumerable<pb_Object> selection, int renderTextureWidth = -1, int renderTextureHeight = -1)
		{
			Dictionary<uint, pb_Tuple<pb_Object, pb_Face>> map;
			Texture2D texture2D = RenderSelectionPickerTexture(camera, selection, out map, renderTextureWidth, renderTextureHeight);
			Color32[] pixels = texture2D.GetPixels32();
			int num = System.Math.Max(0, Mathf.FloorToInt(pickerRect.x));
			int num2 = System.Math.Max(0, Mathf.FloorToInt((float)texture2D.height - pickerRect.y - pickerRect.height));
			int width = texture2D.width;
			int height = texture2D.height;
			int num3 = Mathf.FloorToInt(pickerRect.width);
			int num4 = Mathf.FloorToInt(pickerRect.height);
			UnityEngine.Object.DestroyImmediate(texture2D);
			Dictionary<pb_Object, HashSet<pb_Face>> dictionary = new Dictionary<pb_Object, HashSet<pb_Face>>();
			HashSet<pb_Face> value = null;
			HashSet<uint> hashSet = new HashSet<uint>();
			for (int i = num2; i < System.Math.Min(num2 + num4, height); i++)
			{
				for (int j = num; j < System.Math.Min(num + num3, width); j++)
				{
					uint num5 = DecodeRGBA(pixels[i * width + j]);
					if (hashSet.Add(num5) && map.TryGetValue(num5, out var value2))
					{
						if (dictionary.TryGetValue(value2.Item1, out value))
						{
							value.Add(value2.Item2);
							continue;
						}
						dictionary.Add(value2.Item1, new HashSet<pb_Face> { value2.Item2 });
					}
				}
			}
			return dictionary;
		}

		public static Dictionary<pb_Object, HashSet<int>> PickVerticesInRect(Camera camera, Rect pickerRect, IEnumerable<pb_Object> selection, int renderTextureWidth = -1, int renderTextureHeight = -1)
		{
			Dictionary<uint, pb_Tuple<pb_Object, int>> map;
			Texture2D texture2D = RenderSelectionPickerTexture(camera, selection, out map, renderTextureWidth, renderTextureHeight);
			Color32[] pixels = texture2D.GetPixels32();
			int num = System.Math.Max(0, Mathf.FloorToInt(pickerRect.x));
			int num2 = System.Math.Max(0, Mathf.FloorToInt((float)texture2D.height - pickerRect.y - pickerRect.height));
			int width = texture2D.width;
			int height = texture2D.height;
			int num3 = Mathf.FloorToInt(pickerRect.width);
			int num4 = Mathf.FloorToInt(pickerRect.height);
			UnityEngine.Object.DestroyImmediate(texture2D);
			Dictionary<pb_Object, HashSet<int>> dictionary = new Dictionary<pb_Object, HashSet<int>>();
			HashSet<int> value = null;
			HashSet<uint> hashSet = new HashSet<uint>();
			for (int i = num2; i < System.Math.Min(num2 + num4, height); i++)
			{
				for (int j = num; j < System.Math.Min(num + num3, width); j++)
				{
					uint num5 = DecodeRGBA(pixels[i * width + j]);
					if (hashSet.Add(num5) && map.TryGetValue(num5, out var value2))
					{
						if (dictionary.TryGetValue(value2.Item1, out value))
						{
							value.Add(value2.Item2);
							continue;
						}
						dictionary.Add(value2.Item1, new HashSet<int> { value2.Item2 });
					}
				}
			}
			return dictionary;
		}

		public static Texture2D RenderSelectionPickerTexture(Camera camera, IEnumerable<pb_Object> selection, out Dictionary<uint, pb_Tuple<pb_Object, pb_Face>> map, int width = -1, int height = -1)
		{
			List<GameObject> list = GenerateFaceDepthTestMeshes(selection, out map);
			Texture2D result = RenderWithReplacementShader(camera, pb_Constant.SelectionPickerShader, "ProBuilderPicker", width, height);
			foreach (GameObject item in list)
			{
				UnityEngine.Object.DestroyImmediate(item.GetComponent<MeshFilter>().sharedMesh);
				UnityEngine.Object.DestroyImmediate(item);
			}
			return result;
		}

		public static Texture2D RenderSelectionPickerTexture(Camera camera, IEnumerable<pb_Object> selection, out Dictionary<uint, pb_Tuple<pb_Object, int>> map, int width = -1, int height = -1)
		{
			List<GameObject> list = GenerateVertexDepthTestMeshes(selection, out map);
			Texture2D result = RenderWithReplacementShader(camera, pb_Constant.SelectionPickerShader, "ProBuilderPicker", width, height);
			foreach (GameObject item in list)
			{
				UnityEngine.Object.DestroyImmediate(item.GetComponent<MeshFilter>().sharedMesh);
				UnityEngine.Object.DestroyImmediate(item);
			}
			return result;
		}

		public static List<GameObject> GenerateFaceDepthTestMeshes(IEnumerable<pb_Object> selection, out Dictionary<uint, pb_Tuple<pb_Object, pb_Face>> map)
		{
			List<GameObject> list = new List<GameObject>();
			map = new Dictionary<uint, pb_Tuple<pb_Object, pb_Face>>();
			uint num = 0u;
			foreach (pb_Object item in selection)
			{
				GameObject gameObject = new GameObject();
				gameObject.name = item.name + " (Face Depth Test)";
				gameObject.transform.position = item.transform.position;
				gameObject.transform.localRotation = item.transform.localRotation;
				gameObject.transform.localScale = item.transform.localScale;
				Mesh mesh = new Mesh();
				mesh.vertices = item.vertices;
				mesh.triangles = item.faces.SelectMany((pb_Face x) => x.indices).ToArray();
				Color32[] array = new Color32[mesh.vertexCount];
				pb_Face[] faces = item.faces;
				foreach (pb_Face pb_Face2 in faces)
				{
					Color32 color = EncodeRGBA(num++);
					map.Add(DecodeRGBA(color), new pb_Tuple<pb_Object, pb_Face>(item, pb_Face2));
					for (int num3 = 0; num3 < pb_Face2.distinctIndices.Length; num3++)
					{
						array[pb_Face2.distinctIndices[num3]] = color;
					}
				}
				mesh.colors32 = array;
				gameObject.AddComponent<MeshFilter>().sharedMesh = mesh;
				gameObject.AddComponent<MeshRenderer>().sharedMaterial = pb_Constant.FacePickerMaterial;
				list.Add(gameObject);
			}
			return list;
		}

		private static List<GameObject> GenerateVertexDepthTestMeshes(IEnumerable<pb_Object> selection, out Dictionary<uint, pb_Tuple<pb_Object, int>> map)
		{
			List<GameObject> list = new List<GameObject>();
			map = new Dictionary<uint, pb_Tuple<pb_Object, int>>();
			Color32 val = new Color32(0, 0, 0, byte.MaxValue);
			uint index = 2u;
			foreach (pb_Object item in selection)
			{
				GameObject gameObject = pbUtil.EmptyGameObjectWithTransform(item.transform);
				gameObject.name = item.name + "  (Depth Mask)";
				Mesh mesh = new Mesh();
				mesh.vertices = item.vertices;
				mesh.triangles = item.faces.SelectMany((pb_Face x) => x.indices).ToArray();
				mesh.colors32 = pbUtil.Fill(val, item.vertexCount);
				gameObject.AddComponent<MeshFilter>().sharedMesh = mesh;
				gameObject.AddComponent<MeshRenderer>().sharedMaterial = pb_Constant.FacePickerMaterial;
				list.Add(gameObject);
				GameObject gameObject2 = pbUtil.EmptyGameObjectWithTransform(item.transform);
				gameObject2.name = item.name + "  (Vertex Billboards)";
				gameObject2.AddComponent<MeshFilter>().sharedMesh = BuildVertexMesh(item, map, ref index);
				gameObject2.AddComponent<MeshRenderer>().sharedMaterial = pb_Constant.VertexPickerMaterial;
				list.Add(gameObject2);
			}
			return list;
		}

		private static Mesh BuildVertexMesh(pb_Object pb, Dictionary<uint, pb_Tuple<pb_Object, int>> map, ref uint index)
		{
			int num = System.Math.Min(pb.sharedIndices.Length, 16382);
			Vector3[] array = new Vector3[num * 4];
			Vector2[] array2 = new Vector2[num * 4];
			Vector2[] array3 = new Vector2[num * 4];
			Color[] array4 = new Color[num * 4];
			int[] array5 = new int[num * 6];
			int num2 = 0;
			int num3 = 0;
			Vector3 up = Vector3.up;
			Vector3 right = Vector3.right;
			for (int i = 0; i < num; i++)
			{
				Vector3 vector = pb.vertices[pb.sharedIndices[i][0]];
				array[num3] = vector;
				array[num3 + 1] = vector;
				array[num3 + 2] = vector;
				array[num3 + 3] = vector;
				ref Vector2 reference = ref array2[num3];
				reference = Vector3.zero;
				ref Vector2 reference2 = ref array2[num3 + 1];
				reference2 = Vector3.right;
				ref Vector2 reference3 = ref array2[num3 + 2];
				reference3 = Vector3.up;
				ref Vector2 reference4 = ref array2[num3 + 3];
				reference4 = Vector3.one;
				ref Vector2 reference5 = ref array3[num3];
				reference5 = -up - right;
				ref Vector2 reference6 = ref array3[num3 + 1];
				reference6 = -up + right;
				ref Vector2 reference7 = ref array3[num3 + 2];
				reference7 = up - right;
				ref Vector2 reference8 = ref array3[num3 + 3];
				reference8 = up + right;
				array5[num2] = num3;
				array5[num2 + 1] = num3 + 1;
				array5[num2 + 2] = num3 + 2;
				array5[num2 + 3] = num3 + 1;
				array5[num2 + 4] = num3 + 3;
				array5[num2 + 5] = num3 + 2;
				Color32 color = EncodeRGBA(index);
				map.Add(index++, new pb_Tuple<pb_Object, int>(pb, i));
				ref Color reference9 = ref array4[num3];
				reference9 = color;
				ref Color reference10 = ref array4[num3 + 1];
				reference10 = color;
				ref Color reference11 = ref array4[num3 + 2];
				reference11 = color;
				ref Color reference12 = ref array4[num3 + 3];
				reference12 = color;
				num3 += 4;
				num2 += 6;
			}
			Mesh mesh = new Mesh();
			mesh.name = "Vertex Billboard";
			mesh.vertices = array;
			mesh.uv = array2;
			mesh.uv2 = array3;
			mesh.colors = array4;
			mesh.triangles = array5;
			return mesh;
		}

		public static uint DecodeRGBA(Color32 color)
		{
			uint r = color.r;
			uint g = color.g;
			uint b = color.b;
			if (BitConverter.IsLittleEndian)
			{
				return (r << 16) | (g << 8) | b;
			}
			return (r << 24) | (g << 16) | (b << 8);
		}

		public static Color32 EncodeRGBA(uint hash)
		{
			if (BitConverter.IsLittleEndian)
			{
				return new Color32((byte)((hash >> 16) & 0xFF), (byte)((hash >> 8) & 0xFF), (byte)(hash & 0xFF), byte.MaxValue);
			}
			return new Color32((byte)((hash >> 24) & 0xFF), (byte)((hash >> 16) & 0xFF), (byte)((hash >> 8) & 0xFF), byte.MaxValue);
		}

		public static Texture2D RenderWithReplacementShader(Camera camera, Shader shader, string tag, int width = -1, int height = -1)
		{
			bool flag = width < 0 || height < 0;
			int num = (flag ? ((int)camera.pixelRect.width) : width);
			int num2 = (flag ? ((int)camera.pixelRect.height) : height);
			GameObject gameObject = new GameObject();
			Camera camera2 = gameObject.AddComponent<Camera>();
			camera2.CopyFrom(camera);
			camera2.renderingPath = RenderingPath.Forward;
			camera2.enabled = false;
			camera2.clearFlags = CameraClearFlags.Color;
			camera2.backgroundColor = Color.white;
			RenderTexture renderTexture = (camera2.targetTexture = RenderTexture.GetTemporary(num, num2, 16, RenderTextureFormat.Default, RenderTextureReadWrite.Linear, 1));
			camera2.RenderWithShader(shader, tag);
			RenderTexture active = RenderTexture.active;
			RenderTexture.active = renderTexture;
			Texture2D texture2D = new Texture2D(num, num2);
			texture2D.ReadPixels(new Rect(0f, 0f, num, num2), 0, 0);
			texture2D.Apply();
			RenderTexture.active = active;
			RenderTexture.ReleaseTemporary(renderTexture);
			UnityEngine.Object.DestroyImmediate(gameObject);
			return texture2D;
		}
	}
	public class pb_Shortcut
	{
		public string action;

		public string description;

		public KeyCode key;

		public EventModifiers eventModifiers;

		public pb_Shortcut(string a, string d, KeyCode k, EventModifiers e)
		{
			action = a;
			description = d;
			key = k;
			eventModifiers = e;
		}

		public pb_Shortcut(string str)
		{
			try
			{
				string[] array = str.Split('-');
				action = array[0];
				description = array[1];
				if (int.TryParse(array[2], out var result))
				{
					key = (KeyCode)result;
				}
				if (int.TryParse(array[3], out result))
				{
					eventModifiers = (EventModifiers)result;
				}
			}
			catch
			{
				Debug.LogWarning("Failed parsing shortcut: " + str);
			}
		}

		public bool Matches(KeyCode key, EventModifiers modifiers)
		{
			if (this.key == key)
			{
				return eventModifiers == modifiers;
			}
			return false;
		}

		public static int IndexOf(pb_Shortcut[] shortcuts, KeyCode k, EventModifiers e)
		{
			for (int i = 0; i < shortcuts.Length; i++)
			{
				if (shortcuts[i].key == k && shortcuts[i].eventModifiers == e)
				{
					return i;
				}
			}
			return -1;
		}

		public static IEnumerable<pb_Shortcut> DefaultShortcuts()
		{
			List<pb_Shortcut> list = new List<pb_Shortcut>();
			list.Add(new pb_Shortcut("Escape", "Top Level", KeyCode.Escape, EventModifiers.None));
			list.Add(new pb_Shortcut("Toggle Geometry Mode", "Geometry Level", KeyCode.G, EventModifiers.None));
			list.Add(new pb_Shortcut("Toggle Selection Mode", "Toggle Selection Mode.  If Toggle Mode Shortcuts is disabled, this shortcut does not apply.", KeyCode.H, EventModifiers.None));
			list.Add(new pb_Shortcut("Set Trigger", "Sets all selected objects to entity type Trigger.", KeyCode.T, EventModifiers.None));
			list.Add(new pb_Shortcut("Set Occluder", "Sets all selected objects to entity type Occluder.", KeyCode.O, EventModifiers.None));
			list.Add(new pb_Shortcut("Set Collider", "Sets all selected objects to entity type Collider.", KeyCode.C, EventModifiers.None));
			list.Add(new pb_Shortcut("Set Mover", "Sets all selected objects to entity type Mover.", KeyCode.M, EventModifiers.None));
			list.Add(new pb_Shortcut("Set Detail", "Sets all selected objects to entity type Brush.", KeyCode.B, EventModifiers.None));
			list.Add(new pb_Shortcut("Toggle Handle Pivot", "Toggles the orientation of the ProBuilder selection handle.", KeyCode.P, EventModifiers.None));
			list.Add(new pb_Shortcut("Set Pivot", "Center pivot around current selection.", KeyCode.J, EventModifiers.Command));
			list.Add(new pb_Shortcut("Delete Face", "Deletes all selected faces.", KeyCode.Backspace, EventModifiers.FunctionKey));
			list.Add(new pb_Shortcut("Vertex Mode", "Enter Vertex editing mode.  Automatically swaps to Element level editing.", KeyCode.H, EventModifiers.None));
			list.Add(new pb_Shortcut("Edge Mode", "Enter Edge editing mode.  Automatically swaps to Element level editing.", KeyCode.J, EventModifiers.None));
			list.Add(new pb_Shortcut("Face Mode", "Enter Face editing mode.  Automatically swaps to Element level editing.", KeyCode.K, EventModifiers.None));
			return list;
		}

		public static IEnumerable<pb_Shortcut> ParseShortcuts(string str)
		{
			if (str == null || str.Length < 3)
			{
				return DefaultShortcuts();
			}
			string[] array = str.Split('*');
			pb_Shortcut[] array2 = new pb_Shortcut[array.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = new pb_Shortcut(array[i]);
			}
			return array2;
		}

		public override string ToString()
		{
			return $"{action}: {key.ToString()}, {eventModifiers.ToString()} ({(int)eventModifiers})";
		}

		public string Serialize()
		{
			action = action.Replace("-", " ").Replace("*", "");
			description = description.Replace("-", " ").Replace("*", "");
			return action + "-" + description + "-" + (int)key + "-" + (int)eventModifiers;
		}

		public static string ShortcutsToString(pb_Shortcut[] shortcuts)
		{
			string text = "";
			for (int i = 0; i < shortcuts.Length; i++)
			{
				text += shortcuts[i].Serialize();
				if (i != shortcuts.Length - 1)
				{
					text += "*";
				}
			}
			return text;
		}
	}
}
[Serializable]
public class pb_UV
{
	[Obsolete("See pb_UV.Anchor")]
	public enum Justify
	{
		Right,
		Left,
		Top,
		Center,
		Bottom,
		None
	}

	public enum Anchor
	{
		UpperLeft,
		UpperCenter,
		UpperRight,
		MiddleLeft,
		MiddleCenter,
		MiddleRight,
		LowerLeft,
		LowerCenter,
		LowerRight
	}

	public enum Fill
	{
		Fit,
		Tile,
		Stretch
	}

	public bool useWorldSpace;

	public bool flipU;

	public bool flipV;

	public bool swapUV;

	public Fill fill;

	public Vector2 scale;

	public Vector2 offset;

	public float rotation;

	[Obsolete("Please use pb_UV.anchor.")]
	public Justify justify;

	public Vector2 localPivot;

	public Vector2 localSize;

	public Anchor anchor;

	public pb_UV()
	{
		useWorldSpace = false;
		flipU = false;
		flipV = false;
		swapUV = false;
		fill = Fill.Tile;
		scale = new Vector2(1f, 1f);
		offset = new Vector2(0f, 0f);
		rotation = 0f;
		anchor = Anchor.LowerLeft;
	}

	public pb_UV(pb_UV uvs)
	{
		useWorldSpace = uvs.useWorldSpace;
		flipU = uvs.flipU;
		flipV = uvs.flipV;
		swapUV = uvs.swapUV;
		fill = uvs.fill;
		scale = uvs.scale;
		offset = uvs.offset;
		rotation = uvs.rotation;
		anchor = uvs.anchor;
	}

	[Obsolete("Please use constructor with pb_UV.Anchor parameter.")]
	public pb_UV(bool _useWorldSpace, bool _flipU, bool _flipV, bool _swapUV, Fill _fill, Vector2 _scale, Vector2 _offset, float _rotation, Justify _justify)
	{
		useWorldSpace = _useWorldSpace;
		flipU = _flipU;
		flipV = _flipV;
		swapUV = _swapUV;
		fill = _fill;
		scale = _scale;
		offset = _offset;
		rotation = _rotation;
		justify = _justify;
	}

	public void Reset()
	{
		useWorldSpace = false;
		flipU = false;
		flipV = false;
		swapUV = false;
		fill = Fill.Tile;
		scale = new Vector2(1f, 1f);
		offset = new Vector2(0f, 0f);
		rotation = 0f;
		anchor = Anchor.LowerLeft;
	}

	public override string ToString()
	{
		return string.Concat("Use World Space: ", useWorldSpace, "\nFlip U: ", flipU, "\nFlip V: ", flipV, "\nSwap UV: ", swapUV, "\nFill Mode: ", fill, "\nAnchor: ", anchor, "\nScale: ", scale, "\nOffset: ", offset, "\nRotation: ", rotation, "\nPivot: ", localPivot, "\n");
	}
}
namespace ProBuilder2.Common
{
	public class pb_UVUtility
	{
		public static Vector2[] PlanarMap(Vector3[] verts, pb_UV uvSettings, Vector3 normal)
		{
			Vector2[] uvs = pb_Projection.PlanarProject(verts, normal);
			return ApplyUVSettings(uvs, uvSettings);
		}

		private static Vector2[] ApplyUVSettings(Vector2[] uvs, pb_UV uvSettings)
		{
			int num = uvs.Length;
			switch (uvSettings.fill)
			{
			case pb_UV.Fill.Fit:
				uvs = NormalizeUVs(uvs);
				break;
			case pb_UV.Fill.Stretch:
				uvs = StretchUVs(uvs);
				break;
			}
			if (!uvSettings.useWorldSpace)
			{
				ApplyUVAnchor(uvs, uvSettings.anchor);
			}
			pb_Bounds2D pb_Bounds2D2 = new pb_Bounds2D(uvs);
			for (int i = 0; i < uvs.Length; i++)
			{
				ref Vector2 reference = ref uvs[i];
				reference = uvs[i].ScaleAroundPoint(pb_Bounds2D2.center, uvSettings.scale);
				ref Vector2 reference2 = ref uvs[i];
				reference2 = uvs[i].RotateAroundPoint(pb_Bounds2D2.center, uvSettings.rotation);
			}
			for (int j = 0; j < num; j++)
			{
				float num2 = uvs[j].x;
				float num3 = uvs[j].y;
				if (uvSettings.flipU)
				{
					num2 = 0f - num2;
				}
				if (uvSettings.flipV)
				{
					num3 = 0f - num3;
				}
				if (!uvSettings.swapUV)
				{
					ref Vector2 reference3 = ref uvs[j];
					reference3 = new Vector2(num2, num3);
				}
				else
				{
					ref Vector2 reference4 = ref uvs[j];
					reference4 = new Vector2(num3, num2);
				}
			}
			pb_Bounds2D2 = new pb_Bounds2D(uvs);
			uvSettings.localPivot = pb_Bounds2D2.center;
			uvSettings.localSize = pb_Bounds2D2.size;
			for (int k = 0; k < uvs.Length; k++)
			{
				uvs[k] -= uvSettings.offset;
			}
			return uvs;
		}

		private static Vector2[] StretchUVs(Vector2[] uvs)
		{
			Vector2 vector = pb_Math.LargestVector2(uvs) - pb_Math.SmallestVector2(uvs);
			for (int i = 0; i < uvs.Length; i++)
			{
				ref Vector2 reference = ref uvs[i];
				reference = new Vector2(uvs[i].x / vector.x, uvs[i].y / vector.y);
			}
			return uvs;
		}

		private static Vector2[] NormalizeUVs(Vector2[] uvs)
		{
			Vector2 vector = pb_Math.SmallestVector2(uvs);
			for (int i = 0; i < uvs.Length; i++)
			{
				uvs[i] -= vector;
			}
			float num = pb_Math.LargestValue(pb_Math.LargestVector2(uvs));
			for (int i = 0; i < uvs.Length; i++)
			{
				uvs[i] /= num;
			}
			return uvs;
		}

		[Obsolete("See ApplyAnchor().")]
		private static Vector2[] JustifyUVs(Vector2[] uvs, pb_UV.Justify j)
		{
			Vector2 vector = new Vector2(0f, 0f);
			switch (j)
			{
			case pb_UV.Justify.Left:
				vector = new Vector2(pb_Math.SmallestVector2(uvs).x, 0f);
				break;
			case pb_UV.Justify.Right:
				vector = new Vector2(pb_Math.LargestVector2(uvs).x - 1f, 0f);
				break;
			case pb_UV.Justify.Top:
				vector = new Vector2(0f, pb_Math.LargestVector2(uvs).y - 1f);
				break;
			case pb_UV.Justify.Bottom:
				vector = new Vector2(0f, pb_Math.SmallestVector2(uvs).y);
				break;
			case pb_UV.Justify.Center:
				vector = pb_Math.Average(uvs) - new Vector2(0.5f, 0.5f);
				break;
			}
			for (int i = 0; i < uvs.Length; i++)
			{
				uvs[i] -= vector;
			}
			return uvs;
		}

		private static void ApplyUVAnchor(Vector2[] uvs, pb_UV.Anchor anchor)
		{
			Vector2 zero = Vector2.zero;
			Vector2 vector = pb_Math.SmallestVector2(uvs);
			Vector2 vector2 = pb_Math.LargestVector2(uvs);
			switch (anchor)
			{
			case pb_UV.Anchor.UpperLeft:
			case pb_UV.Anchor.MiddleLeft:
			case pb_UV.Anchor.LowerLeft:
				zero.x = vector.x;
				break;
			case pb_UV.Anchor.UpperRight:
			case pb_UV.Anchor.MiddleRight:
			case pb_UV.Anchor.LowerRight:
				zero.x = vector2.x - 1f;
				break;
			default:
				zero.x = vector.x + (vector2.x - vector.x) * 0.5f - 0.5f;
				break;
			}
			switch (anchor)
			{
			case pb_UV.Anchor.UpperLeft:
			case pb_UV.Anchor.UpperCenter:
			case pb_UV.Anchor.UpperRight:
				zero.y = vector2.y - 1f;
				break;
			case pb_UV.Anchor.MiddleLeft:
			case pb_UV.Anchor.MiddleCenter:
			case pb_UV.Anchor.MiddleRight:
				zero.y = vector.y + (vector2.y - vector.y) * 0.5f - 0.5f;
				break;
			default:
				zero.y = vector.y;
				break;
			}
			for (int i = 0; i < uvs.Length; i++)
			{
				uvs[i] -= zero;
			}
		}
	}
	public class pb_Bounds2D
	{
		public Vector2 center;

		[SerializeField]
		private Vector2 _size;

		public Vector2 size
		{
			get
			{
				return _size;
			}
			set
			{
				_size = value;
				extents = value / 2f;
			}
		}

		public Vector2 extents { get; private set; }

		public Vector2[] corners => new Vector2[4]
		{
			new Vector2(center.x - extents.x, center.y + extents.y),
			new Vector2(center.x + extents.x, center.y + extents.y),
			new Vector2(center.x - extents.x, center.y - extents.y),
			new Vector2(center.x + extents.x, center.y - extents.y)
		};

		public pb_Bounds2D(Vector2 center, Vector2 size)
		{
			this.center = center;
			this.size = size;
		}

		public pb_Bounds2D(Vector2[] points)
		{
			float num = 0f;
			float num2 = 0f;
			float num3 = 0f;
			float num4 = 0f;
			if (points.Length > 0)
			{
				num = points[0].x;
				num3 = points[0].y;
				num2 = num;
				num4 = num3;
				for (int i = 1; i < points.Length; i++)
				{
					num = Mathf.Min(num, points[i].x);
					num3 = Mathf.Min(num3, points[i].y);
					num2 = Mathf.Max(num2, points[i].x);
					num4 = Mathf.Max(num4, points[i].y);
				}
			}
			center = new Vector2((num + num2) / 2f, (num3 + num4) / 2f);
			size = new Vector3(num2 - num, num4 - num3);
		}

		public pb_Bounds2D(Vector2[] points, int[] indices)
		{
			float num = 0f;
			float num2 = 0f;
			float num3 = 0f;
			float num4 = 0f;
			if (points.Length > 0 && indices.Length > 0)
			{
				num = points[indices[0]].x;
				num3 = points[indices[0]].y;
				num2 = num;
				num4 = num3;
				for (int i = 1; i < indices.Length; i++)
				{
					num = Mathf.Min(num, points[indices[i]].x);
					num3 = Mathf.Min(num3, points[indices[i]].y);
					num2 = Mathf.Max(num2, points[indices[i]].x);
					num4 = Mathf.Max(num4, points[indices[i]].y);
				}
			}
			center = new Vector2((num + num2) / 2f, (num3 + num4) / 2f);
			size = new Vector3(num2 - num, num4 - num3);
		}

		public pb_Bounds2D(Vector2[] points, pb_Edge[] edges)
		{
			float num = 0f;
			float num2 = 0f;
			float num3 = 0f;
			float num4 = 0f;
			if (points.Length > 0 && edges.Length > 0)
			{
				num = points[edges[0].x].x;
				num3 = points[edges[0].x].y;
				num2 = num;
				num4 = num3;
				for (int i = 0; i < edges.Length; i++)
				{
					num = Mathf.Min(num, points[edges[i].x].x);
					num = Mathf.Min(num, points[edges[i].y].x);
					num3 = Mathf.Min(num3, points[edges[i].x].y);
					num3 = Mathf.Min(num3, points[edges[i].y].y);
					num2 = Mathf.Max(num2, points[edges[i].x].x);
					num2 = Mathf.Max(num2, points[edges[i].y].x);
					num4 = Mathf.Max(num4, points[edges[i].x].y);
					num4 = Mathf.Max(num4, points[edges[i].y].y);
				}
			}
			center = new Vector2((num + num2) / 2f, (num3 + num4) / 2f);
			size = new Vector3(num2 - num, num4 - num3);
		}

		public pb_Bounds2D(Vector2[] points, int length)
		{
			float num = 0f;
			float num2 = 0f;
			float num3 = 0f;
			float num4 = 0f;
			if (points.Length > 0)
			{
				num = points[0].x;
				num3 = points[0].y;
				num2 = num;
				num4 = num3;
				for (int i = 1; i < length; i++)
				{
					num = Mathf.Min(num, points[i].x);
					num3 = Mathf.Min(num3, points[i].y);
					num2 = Mathf.Max(num2, points[i].x);
					num4 = Mathf.Max(num4, points[i].y);
				}
			}
			center = new Vector2((num + num2) / 2f, (num3 + num4) / 2f);
			size = new Vector3(num2 - num, num4 - num3);
		}

		public bool ContainsPoint(Vector2 point)
		{
			if (!(point.x > center.x + extents.x) && !(point.x < center.x - extents.x) && !(point.y > center.y + extents.y))
			{
				return !(point.y < center.y - extents.y);
			}
			return false;
		}

		public bool IntersectsLineSegment(Vector2 lineStart, Vector2 lineEnd)
		{
			if (ContainsPoint(lineStart) || ContainsPoint(lineEnd))
			{
				return true;
			}
			Vector2[] array = corners;
			if (!pb_Math.GetLineSegmentIntersect(array[0], array[1], lineStart, lineEnd) && !pb_Math.GetLineSegmentIntersect(array[1], array[3], lineStart, lineEnd) && !pb_Math.GetLineSegmentIntersect(array[3], array[2], lineStart, lineEnd))
			{
				return pb_Math.GetLineSegmentIntersect(array[2], array[0], lineStart, lineEnd);
			}
			return true;
		}

		public bool Intersects(pb_Bounds2D bounds)
		{
			Vector2 vector = center - bounds.center;
			Vector2 vector2 = size + bounds.size;
			if (Mathf.Abs(vector.x) * 2f < vector2.x)
			{
				return Mathf.Abs(vector.y) * 2f < vector2.y;
			}
			return false;
		}

		public bool Intersects(Rect rect)
		{
			Vector2 vector = center - rect.center;
			Vector2 vector2 = size + rect.size;
			if (Mathf.Abs(vector.x) * 2f < vector2.x)
			{
				return Mathf.Abs(vector.y) * 2f < vector2.y;
			}
			return false;
		}

		public static Vector2 Center(List<Vector2> points)
		{
			return Center(points.ToArray());
		}

		public static Vector2 Center(Vector2[] points)
		{
			return Center(points, points.Length);
		}

		public static Vector2 Center(Vector2[] points, int length)
		{
			float num = 0f;
			float num2 = 0f;
			float num3 = 0f;
			float num4 = 0f;
			if (points.Length > 0)
			{
				num = points[0].x;
				num3 = points[0].y;
				num2 = num;
				num4 = num3;
				for (int i = 1; i < length; i++)
				{
					num = Mathf.Min(num, points[i].x);
					num3 = Mathf.Min(num3, points[i].y);
					num2 = Mathf.Max(num2, points[i].x);
					num4 = Mathf.Max(num4, points[i].y);
				}
			}
			return new Vector2((num + num2) / 2f, (num3 + num4) / 2f);
		}

		public override string ToString()
		{
			return string.Concat("[cen: ", center, " size: ", size, "]");
		}
	}
}
[Serializable]
public class pb_Color
{
	public float r;

	public float g;

	public float b;

	public float a;

	public static implicit operator Color(pb_Color c)
	{
		return new Color(c.r, c.g, c.b, c.a);
	}

	public static implicit operator pb_Color(Color c)
	{
		return new pb_Color(c);
	}

	public pb_Color()
	{
		r = 0f;
		g = 0f;
		b = 0f;
		a = 0f;
	}

	public pb_Color(Color c)
	{
		r = c.r;
		g = c.g;
		b = c.b;
		a = c.a;
	}

	public pb_Color(float r, float g, float b, float a)
	{
		this.r = r;
		this.g = g;
		this.b = b;
		this.a = a;
	}
}
namespace ProBuilder2.Common
{
	[Obsolete("Use pb_ConnectEdges class directly.")]
	public class pb_EdgeConnection : IEquatable<pb_EdgeConnection>
	{
		public pb_Face face;

		public List<pb_Edge> edges;

		public bool isValid
		{
			get
			{
				if (edges != null)
				{
					return edges.Count > 1;
				}
				return false;
			}
		}

		public pb_EdgeConnection(pb_Face face, List<pb_Edge> edges)
		{
			this.face = face;
			this.edges = edges;
		}

		public override bool Equals(object b)
		{
			if (!(b is pb_EdgeConnection))
			{
				return false;
			}
			return face == ((pb_EdgeConnection)b).face;
		}

		public bool Equals(pb_EdgeConnection fc)
		{
			return face == fc.face;
		}

		public static explicit operator pb_Face(pb_EdgeConnection fc)
		{
			return fc.face;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return face.ToString() + " : " + pbUtil.ToString(edges);
		}

		public static List<int> AllTriangles(List<pb_EdgeConnection> ec)
		{
			List<pb_Edge> list = new List<pb_Edge>();
			foreach (pb_EdgeConnection item in ec)
			{
				list.AddRange(item.edges);
			}
			return list.AllTriangles();
		}
	}
	public class pb_EdgeLookup : IEquatable<pb_EdgeLookup>
	{
		public pb_Edge local;

		public pb_Edge common;

		public pb_EdgeLookup(pb_Edge common, pb_Edge local)
		{
			this.common = common;
			this.local = local;
		}

		public pb_EdgeLookup(int cx, int cy, int x, int y)
		{
			common = new pb_Edge(cx, cy);
			local = new pb_Edge(x, y);
		}

		public bool Equals(pb_EdgeLookup b)
		{
			return common.Equals(b.common);
		}

		public override bool Equals(object b)
		{
			pb_EdgeLookup pb_EdgeLookup2 = b as pb_EdgeLookup;
			if (pb_EdgeLookup2 != null)
			{
				return common.Equals(pb_EdgeLookup2.common);
			}
			return false;
		}

		public static bool operator ==(pb_EdgeLookup a, pb_EdgeLookup b)
		{
			return a.Equals(b);
		}

		public static bool operator !=(pb_EdgeLookup a, pb_EdgeLookup b)
		{
			return !a.Equals(b);
		}

		public override int GetHashCode()
		{
			return common.GetHashCode();
		}

		public override string ToString()
		{
			return $"c({common.x}, {common.y})  l({local.x}, {local.y})  > {GetHashCode()}";
		}

		public static IEnumerable<pb_EdgeLookup> GetEdgeLookup(IEnumerable<pb_Edge> edges, Dictionary<int, int> lookup)
		{
			return edges.Select((pb_Edge x) => new pb_EdgeLookup(new pb_Edge(lookup[x.x], lookup[x.y]), x));
		}
	}
	public class pb_FaceRebuildData
	{
		public pb_Face face;

		public List<pb_Vertex> vertices;

		public List<int> sharedIndices;

		public List<int> sharedIndicesUV;

		private int _appliedOffset;

		public int Offset()
		{
			return _appliedOffset;
		}

		public override string ToString()
		{
			return $"{pbUtil.ToString(vertices)}\n{pbUtil.ToString(sharedIndices)}";
		}

		public static void Apply(IEnumerable<pb_FaceRebuildData> newFaces, pb_Object pb, List<pb_Vertex> vertices = null, List<pb_Face> faces = null, Dictionary<int, int> lookup = null, Dictionary<int, int> lookupUV = null)
		{
			List<pb_Face> list = ((faces == null) ? new List<pb_Face>(pb.faces) : faces);
			if (vertices == null)
			{
				vertices = new List<pb_Vertex>(pb_Vertex.GetVertices(pb));
			}
			if (lookup == null)
			{
				lookup = pb.sharedIndices.ToDictionary();
			}
			if (lookupUV == null)
			{
				lookupUV = ((pb.sharedIndicesUV != null) ? pb.sharedIndicesUV.ToDictionary() : null);
			}
			Apply(newFaces, vertices, list, lookup, lookupUV);
			pb.SetVertices(vertices);
			pb.SetFaces(list.ToArray());
			pb.SetSharedIndices(lookup);
			pb.SetSharedIndicesUV(lookupUV);
		}

		public static void Apply(IEnumerable<pb_FaceRebuildData> newFaces, List<pb_Vertex> vertices, List<pb_Face> faces, Dictionary<int, int> sharedIndices, Dictionary<int, int> sharedIndicesUV = null)
		{
			int num = vertices.Count;
			foreach (pb_FaceRebuildData newFace in newFaces)
			{
				pb_Face pb_Face2 = newFace.face;
				int count = newFace.vertices.Count;
				bool flag = sharedIndices != null && newFace.sharedIndices != null && newFace.sharedIndices.Count == count;
				bool flag2 = sharedIndicesUV != null && newFace.sharedIndicesUV != null && newFace.sharedIndicesUV.Count == count;
				for (int i = 0; i < count; i++)
				{
					int num2 = i;
					sharedIndices?.Add(num2 + num, flag ? newFace.sharedIndices[num2] : (-1));
					sharedIndicesUV?.Add(num2 + num, flag2 ? newFace.sharedIndicesUV[num2] : (-1));
				}
				newFace._appliedOffset = num;
				for (int j = 0; j < pb_Face2.indices.Length; j++)
				{
					pb_Face2.indices[j] += num;
				}
				pb_Face2.RebuildCaches();
				num += newFace.vertices.Count;
				faces.Add(pb_Face2);
				vertices.AddRange(newFace.vertices);
			}
		}
	}
	public class pb_HandleConstraint2D
	{
		public int x;

		public int y;

		public static readonly pb_HandleConstraint2D None = new pb_HandleConstraint2D(1, 1);

		public pb_HandleConstraint2D(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public pb_HandleConstraint2D Inverse()
		{
			return new pb_HandleConstraint2D((x != 1) ? 1 : 0, (y != 1) ? 1 : 0);
		}

		public Vector2 Mask(Vector2 v)
		{
			v.x *= x;
			v.y *= y;
			return v;
		}

		public Vector2 InverseMask(Vector2 v)
		{
			v.x *= ((x == 1) ? 0f : 1f);
			v.y *= ((y == 1) ? 0f : 1f);
			return v;
		}

		public static bool operator ==(pb_HandleConstraint2D a, pb_HandleConstraint2D b)
		{
			if (a.x == b.x)
			{
				return a.y == b.y;
			}
			return false;
		}

		public static bool operator !=(pb_HandleConstraint2D a, pb_HandleConstraint2D b)
		{
			if (a.x == b.x)
			{
				return a.y != b.y;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object o)
		{
			if (o is pb_HandleConstraint2D && ((pb_HandleConstraint2D)o).x == x)
			{
				return ((pb_HandleConstraint2D)o).y == y;
			}
			return false;
		}

		public override string ToString()
		{
			return "(" + x + ", " + y + ")";
		}
	}
	public struct pb_IntVec3 : IEquatable<pb_IntVec3>
	{
		public const float RESOLUTION = 1000f;

		public Vector3 vec;

		public float x => vec.x;

		public float y => vec.y;

		public float z => vec.z;

		public pb_IntVec3(Vector3 vector)
		{
			vec = vector;
		}

		public override string ToString()
		{
			return $"({x:F2}, {y:F2}, {z:F2})";
		}

		public static bool operator ==(pb_IntVec3 a, pb_IntVec3 b)
		{
			return a.Equals(b);
		}

		public static bool operator !=(pb_IntVec3 a, pb_IntVec3 b)
		{
			return !(a == b);
		}

		public bool Equals(pb_IntVec3 p)
		{
			if (round(x) == round(p.x) && round(y) == round(p.y))
			{
				return round(z) == round(p.z);
			}
			return false;
		}

		public bool Equals(Vector3 p)
		{
			if (round(x) == round(p.x) && round(y) == round(p.y))
			{
				return round(z) == round(p.z);
			}
			return false;
		}

		public override bool Equals(object b)
		{
			if (!(b is pb_IntVec3) || !Equals((pb_IntVec3)b))
			{
				if (b is Vector3)
				{
					return Equals((Vector3)b);
				}
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return pb_Vector.GetHashCode(vec);
		}

		private static int round(float v)
		{
			return (int)(v * 1000f);
		}

		public static implicit operator Vector3(pb_IntVec3 p)
		{
			return p.vec;
		}

		public static implicit operator pb_IntVec3(Vector3 p)
		{
			return new pb_IntVec3(p);
		}
	}
	public class pb_RaycastHit
	{
		public float distance;

		public Vector3 point;

		public Vector3 normal;

		public int face;

		public pb_RaycastHit(float InDistance, Vector3 InPoint, Vector3 InNormal, int InFaceIndex)
		{
			distance = InDistance;
			point = InPoint;
			normal = InNormal;
			face = InFaceIndex;
		}
	}
	[Serializable]
	public class pb_Renderable : ScriptableObject
	{
		public Mesh mesh;

		public Material[] materials;

		public Transform transform;

		public static pb_Renderable CreateInstance(Mesh InMesh, Material[] InMaterials)
		{
			pb_Renderable pb_Renderable2 = ScriptableObject.CreateInstance<pb_Renderable>();
			pb_Renderable2.mesh = InMesh;
			pb_Renderable2.materials = InMaterials;
			return pb_Renderable2;
		}

		public static pb_Renderable CreateInstance(Mesh InMesh, Material InMaterial)
		{
			pb_Renderable pb_Renderable2 = ScriptableObject.CreateInstance<pb_Renderable>();
			pb_Renderable2.mesh = InMesh;
			pb_Renderable2.materials = new Material[1] { InMaterial };
			return pb_Renderable2;
		}

		public static pb_Renderable CreateInstance()
		{
			pb_Renderable pb_Renderable2 = CreateInstance(new Mesh(), (Material)null);
			pb_Renderable2.mesh.name = "pb_Renderable::Mesh";
			pb_Renderable2.mesh.hideFlags = HideFlags.DontSave;
			pb_Renderable2.mesh.MarkDynamic();
			pb_Renderable2.hideFlags = HideFlags.DontSave;
			return pb_Renderable2;
		}

		public static void DestroyInstance(UnityEngine.Object ren)
		{
			UnityEngine.Object.DestroyImmediate(ren);
		}

		private void OnDestroy()
		{
			if (mesh != null)
			{
				UnityEngine.Object.DestroyImmediate(mesh);
			}
		}
	}
	public class pb_Transform2D
	{
		public Vector2 position;

		public float rotation;

		public Vector2 scale;

		public pb_Transform2D(Vector2 position, float rotation, Vector2 scale)
		{
			this.position = position;
			this.rotation = rotation;
			this.scale = scale;
		}

		public Vector2 TransformPoint(Vector2 p)
		{
			p += position;
			p.RotateAroundPoint(p, rotation);
			p.ScaleAroundPoint(p, scale);
			return p;
		}

		public override string ToString()
		{
			return string.Concat("T: ", position, "\nR: ", rotation, '°', "\nS: ", scale);
		}
	}
	public class pb_Tuple<T1, T2>
	{
		public T1 Item1;

		public T2 Item2;

		public pb_Tuple()
		{
		}

		public pb_Tuple(T1 item1, T2 item2)
		{
			Item1 = item1;
			Item2 = item2;
		}

		public override string ToString()
		{
			return $"{Item1.ToString()}, {Item2.ToString()}";
		}
	}
	public class pb_Tuple<T1, T2, T3>
	{
		public T1 Item1;

		public T2 Item2;

		public T3 Item3;

		public pb_Tuple()
		{
		}

		public pb_Tuple(T1 item1, T2 item2, T3 item3)
		{
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
		}

		public override string ToString()
		{
			return $"{Item1.ToString()}, {Item2.ToString()}, {Item3.ToString()}";
		}
	}
	public class pb_Tuple<T1, T2, T3, T4>
	{
		public T1 Item1;

		public T2 Item2;

		public T3 Item3;

		public T4 Item4;

		public pb_Tuple()
		{
		}

		public pb_Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
			Item4 = item4;
		}

		public override string ToString()
		{
			return $"{Item1.ToString()}, {Item2.ToString()}, {Item3.ToString()}, {Item4.ToString()}";
		}
	}
	[Serializable]
	public class pb_Type : ISerializationCallbackReceiver
	{
		[SerializeField]
		private string assemblyQualifiedName;

		public Type type;

		public pb_Type(Type t)
		{
			type = t;
		}

		public void OnBeforeSerialize()
		{
			assemblyQualifiedName = type.AssemblyQualifiedName;
		}

		public void OnAfterDeserialize()
		{
			type = Type.GetType(assemblyQualifiedName);
		}

		public static implicit operator Type(pb_Type t)
		{
			return t.type;
		}

		public static implicit operator pb_Type(Type t)
		{
			return new pb_Type(t);
		}
	}
	[Serializable]
	public class pb_UnwrapParameters
	{
		[Tooltip("Angle between neighbor triangles that will generate seam.")]
		[Range(1f, 180f)]
		public float hardAngle = 88f;

		[Tooltip("Measured in pixels, assuming mesh will cover an entire 1024x1024 lightmap.")]
		[Range(1f, 64f)]
		public float packMargin = 4f;

		[Range(1f, 75f)]
		[Tooltip("Measured in percents. Angle error measures deviation of UV angles from geometry angles. Area error measures deviation of UV triangles area from geometry triangles if they were uniformly scaled.")]
		public float angleError = 8f;

		[Tooltip("Does... something.")]
		[Range(1f, 75f)]
		public float areaError = 15f;

		public void Reset()
		{
			hardAngle = 88f;
			packMargin = 4f;
			angleError = 8f;
			areaError = 15f;
		}
	}
	public static class pb_Vector
	{
		public const float FLT_COMPARE_RESOLUTION = 1000f;

		public static int GetHashCode(Vector2 v)
		{
			int num = 27;
			num = num * 29 + (int)(v.x * 1000f);
			return num * 29 + (int)(v.y * 1000f);
		}

		public static int GetHashCode(Vector3 v)
		{
			int num = 27;
			num = num * 29 + (int)(v.x * 1000f);
			num = num * 29 + (int)(v.y * 1000f);
			return num * 29 + (int)(v.z * 1000f);
		}

		public static int GetHashCode(Vector4 v)
		{
			int num = 27;
			num = num * 29 + (int)(v.x * 1000f);
			num = num * 29 + (int)(v.y * 1000f);
			num = num * 29 + (int)(v.z * 1000f);
			return num * 29 + (int)(v.w * 1000f);
		}
	}
	public class pb_Vertex : IEquatable<pb_Vertex>
	{
		public Vector3 position;

		public Color color;

		public Vector3 normal;

		public Vector4 tangent;

		public Vector2 uv0;

		public Vector2 uv2;

		public Vector4 uv3;

		public Vector4 uv4;

		public bool hasPosition;

		public bool hasColor;

		public bool hasNormal;

		public bool hasTangent;

		public bool hasUv0;

		public bool hasUv2;

		public bool hasUv3;

		public bool hasUv4;

		public pb_Vertex(bool hasAllValues = false)
		{
			hasPosition = hasAllValues;
			hasColor = hasAllValues;
			hasNormal = hasAllValues;
			hasTangent = hasAllValues;
			hasUv0 = hasAllValues;
			hasUv2 = hasAllValues;
			hasUv3 = hasAllValues;
			hasUv4 = hasAllValues;
		}

		public override bool Equals(object other)
		{
			if (other is pb_Vertex)
			{
				return Equals(other as pb_Vertex);
			}
			return false;
		}

		public bool Equals(pb_Vertex other)
		{
			if (other == null)
			{
				return false;
			}
			if (position.Approx3(other.position) && color.ApproxC(other.color) && normal.Approx3(other.normal) && tangent.Approx4(other.tangent) && uv0.Approx2(other.uv0) && uv2.Approx2(other.uv2) && uv3.Approx4(other.uv3))
			{
				return uv4.Approx4(other.uv4);
			}
			return false;
		}

		public override int GetHashCode()
		{
			int num = 783 + pb_Vector.GetHashCode(position);
			num = num * 29 + pb_Vector.GetHashCode(uv0);
			return num * 31 + pb_Vector.GetHashCode(normal);
		}

		public pb_Vertex(pb_Vertex v)
		{
			position = v.position;
			hasPosition = v.hasPosition;
			color = v.color;
			hasColor = v.hasColor;
			uv0 = v.uv0;
			hasUv0 = v.hasUv0;
			normal = v.normal;
			hasNormal = v.hasNormal;
			tangent = v.tangent;
			hasTangent = v.hasTangent;
			uv2 = v.uv2;
			hasUv2 = v.hasUv2;
			uv3 = v.uv3;
			hasUv3 = v.hasUv3;
			uv4 = v.uv4;
			hasUv4 = v.hasUv4;
		}

		public static pb_Vertex operator +(pb_Vertex a, pb_Vertex b)
		{
			pb_Vertex pb_Vertex2 = new pb_Vertex(a);
			pb_Vertex2.Add(b);
			return pb_Vertex2;
		}

		public void Add(pb_Vertex b)
		{
			position += b.position;
			color += b.color;
			normal += b.normal;
			tangent += b.tangent;
			uv0 += b.uv0;
			uv2 += b.uv2;
			uv3 += b.uv3;
			uv4 += b.uv4;
		}

		public static pb_Vertex operator -(pb_Vertex a, pb_Vertex b)
		{
			pb_Vertex pb_Vertex2 = new pb_Vertex(a);
			pb_Vertex2.Subtract(b);
			return pb_Vertex2;
		}

		public void Subtract(pb_Vertex b)
		{
			position -= b.position;
			color -= b.color;
			normal -= b.normal;
			tangent -= b.tangent;
			uv0 -= b.uv0;
			uv2 -= b.uv2;
			uv3 -= b.uv3;
			uv4 -= b.uv4;
		}

		public static pb_Vertex operator *(pb_Vertex a, float value)
		{
			pb_Vertex pb_Vertex2 = new pb_Vertex(a);
			pb_Vertex2.Multiply(value);
			return pb_Vertex2;
		}

		public void Multiply(float value)
		{
			position *= value;
			color *= value;
			normal *= value;
			tangent *= value;
			uv0 *= value;
			uv2 *= value;
			uv3 *= value;
			uv4 *= value;
		}

		public static pb_Vertex operator /(pb_Vertex a, float value)
		{
			pb_Vertex pb_Vertex2 = new pb_Vertex(a);
			pb_Vertex2.Divide(value);
			return pb_Vertex2;
		}

		public void Divide(float value)
		{
			position /= value;
			color /= value;
			normal /= value;
			tangent /= value;
			uv0 /= value;
			uv2 /= value;
			uv3 /= value;
			uv4 /= value;
		}

		public void Normalize()
		{
			position.Normalize();
			Vector4 vector = color;
			vector.Normalize();
			color.r = vector.x;
			color.g = vector.y;
			color.b = vector.z;
			color.a = vector.w;
			normal.Normalize();
			tangent.Normalize();
			uv0.Normalize();
			uv2.Normalize();
			uv3.Normalize();
			uv4.Normalize();
		}

		public override string ToString()
		{
			return position.ToString();
		}

		public static pb_Vertex[] GetVertices(pb_Object pb, IList<int> indices = null)
		{
			int vertexCount = pb.vertexCount;
			int num = indices?.Count ?? pb.vertexCount;
			pb_Vertex[] array = new pb_Vertex[num];
			Vector3[] vertices = pb.vertices;
			Color[] colors = pb.colors;
			Vector2[] uv = pb.uv;
			Vector3[] normals = pb.msh.normals;
			Vector4[] tangents = pb.msh.tangents;
			Vector2[] array2 = pb.msh.uv2;
			List<Vector4> list = new List<Vector4>();
			List<Vector4> list2 = new List<Vector4>();
			pb.GetUVs(2, list);
			pb.GetUVs(3, list2);
			bool flag = vertices != null && vertices.Count() == vertexCount;
			bool flag2 = colors != null && colors.Count() == vertexCount;
			bool flag3 = normals != null && normals.Count() == vertexCount;
			bool flag4 = tangents != null && tangents.Count() == vertexCount;
			bool flag5 = uv != null && uv.Count() == vertexCount;
			bool flag6 = array2 != null && array2.Count() == vertexCount;
			bool flag7 = list != null && list.Count() == vertexCount;
			bool flag8 = list2 != null && list2.Count() == vertexCount;
			for (int i = 0; i < num; i++)
			{
				array[i] = new pb_Vertex();
				int num2 = indices?[i] ?? i;
				if (flag)
				{
					array[i].hasPosition = true;
					array[i].position = vertices[num2];
				}
				if (flag2)
				{
					array[i].hasColor = true;
					array[i].color = colors[num2];
				}
				if (flag3)
				{
					array[i].hasNormal = true;
					array[i].normal = normals[num2];
				}
				if (flag4)
				{
					array[i].hasTangent = true;
					array[i].tangent = tangents[num2];
				}
				if (flag5)
				{
					array[i].hasUv0 = true;
					array[i].uv0 = uv[num2];
				}
				if (flag6)
				{
					array[i].hasUv2 = true;
					array[i].uv2 = array2[num2];
				}
				if (flag7)
				{
					array[i].hasUv3 = true;
					array[i].uv3 = list[num2];
				}
				if (flag8)
				{
					array[i].hasUv4 = true;
					array[i].uv4 = list2[num2];
				}
			}
			return array;
		}

		public static pb_Vertex[] GetVertices(Mesh m)
		{
			if (m == null)
			{
				return null;
			}
			int vertexCount = m.vertexCount;
			pb_Vertex[] array = new pb_Vertex[vertexCount];
			Vector3[] vertices = m.vertices;
			Color[] colors = m.colors;
			Vector3[] normals = m.normals;
			Vector4[] tangents = m.tangents;
			Vector2[] uv = m.uv;
			Vector2[] array2 = m.uv2;
			List<Vector4> list = new List<Vector4>();
			List<Vector4> list2 = new List<Vector4>();
			m.GetUVs(2, list);
			m.GetUVs(3, list2);
			bool flag = vertices != null && vertices.Count() == vertexCount;
			bool flag2 = colors != null && colors.Count() == vertexCount;
			bool flag3 = normals != null && normals.Count() == vertexCount;
			bool flag4 = tangents != null && tangents.Count() == vertexCount;
			bool flag5 = uv != null && uv.Count() == vertexCount;
			bool flag6 = array2 != null && array2.Count() == vertexCount;
			bool flag7 = list != null && list.Count() == vertexCount;
			bool flag8 = list2 != null && list2.Count() == vertexCount;
			for (int i = 0; i < vertexCount; i++)
			{
				array[i] = new pb_Vertex();
				if (flag)
				{
					array[i].hasPosition = true;
					array[i].position = vertices[i];
				}
				if (flag2)
				{
					array[i].hasColor = true;
					array[i].color = colors[i];
				}
				if (flag3)
				{
					array[i].hasNormal = true;
					array[i].normal = normals[i];
				}
				if (flag4)
				{
					array[i].hasTangent = true;
					array[i].tangent = tangents[i];
				}
				if (flag5)
				{
					array[i].hasUv0 = true;
					array[i].uv0 = uv[i];
				}
				if (flag6)
				{
					array[i].hasUv2 = true;
					array[i].uv2 = array2[i];
				}
				if (flag7)
				{
					array[i].hasUv3 = true;
					array[i].uv3 = list[i];
				}
				if (flag8)
				{
					array[i].hasUv4 = true;
					array[i].uv4 = list2[i];
				}
			}
			return array;
		}

		public static void GetArrays(IList<pb_Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4)
		{
			int count = vertices.Count;
			position = new Vector3[count];
			color = new Color[count];
			uv0 = new Vector2[count];
			normal = new Vector3[count];
			tangent = new Vector4[count];
			uv2 = new Vector2[count];
			uv3 = new List<Vector4>(count);
			uv4 = new List<Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				ref Vector3 reference = ref position[i];
				reference = vertices[i].position;
				ref Color reference2 = ref color[i];
				reference2 = vertices[i].color;
				ref Vector2 reference3 = ref uv0[i];
				reference3 = vertices[i].uv0;
				ref Vector3 reference4 = ref normal[i];
				reference4 = vertices[i].normal;
				ref Vector4 reference5 = ref tangent[i];
				reference5 = vertices[i].tangent;
				ref Vector2 reference6 = ref uv2[i];
				reference6 = vertices[i].uv2;
				uv3.Add(vertices[i].uv3);
				uv4.Add(vertices[i].uv4);
			}
		}

		public static void SetMesh(Mesh m, IList<pb_Vertex> vertices)
		{
			Vector3[] vertices2 = null;
			Color[] colors = null;
			Vector2[] uv = null;
			Vector3[] normals = null;
			Vector4[] tangents = null;
			Vector2[] array = null;
			List<Vector4> list = null;
			List<Vector4> list2 = null;
			GetArrays(vertices, out vertices2, out colors, out uv, out normals, out tangents, out array, out list, out list2);
			m.Clear();
			pb_Vertex pb_Vertex2 = vertices[0];
			if (pb_Vertex2.hasPosition)
			{
				m.vertices = vertices2;
			}
			if (pb_Vertex2.hasColor)
			{
				m.colors = colors;
			}
			if (pb_Vertex2.hasUv0)
			{
				m.uv = uv;
			}
			if (pb_Vertex2.hasNormal)
			{
				m.normals = normals;
			}
			if (pb_Vertex2.hasTangent)
			{
				m.tangents = tangents;
			}
			if (pb_Vertex2.hasUv2)
			{
				m.uv2 = array;
			}
			if (pb_Vertex2.hasUv3 && list != null)
			{
				m.SetUVs(2, list);
			}
			if (pb_Vertex2.hasUv4 && list2 != null)
			{
				m.SetUVs(3, list2);
			}
		}

		public static pb_Vertex Average(IList<pb_Vertex> vertices, IList<int> indices = null)
		{
			pb_Vertex pb_Vertex2 = new pb_Vertex();
			int num = indices?.Count ?? vertices.Count;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			for (int i = 0; i < num; i++)
			{
				int index = indices?[i] ?? i;
				pb_Vertex2.position += vertices[index].position;
				pb_Vertex2.color += vertices[index].color;
				pb_Vertex2.uv0 += vertices[index].uv0;
				if (vertices[index].hasNormal)
				{
					num2++;
					pb_Vertex2.normal += vertices[index].normal;
				}
				if (vertices[index].hasTangent)
				{
					num3++;
					pb_Vertex2.tangent += vertices[index].tangent;
				}
				if (vertices[index].hasUv2)
				{
					num4++;
					pb_Vertex2.uv2 += vertices[index].uv2;
				}
				if (vertices[index].hasUv3)
				{
					num5++;
					pb_Vertex2.uv3 += vertices[index].uv3;
				}
				if (vertices[index].hasUv4)
				{
					num6++;
					pb_Vertex2.uv4 += vertices[index].uv4;
				}
			}
			pb_Vertex2.position *= 1f / (float)num;
			pb_Vertex2.color *= 1f / (float)num;
			pb_Vertex2.uv0 *= 1f / (float)num;
			pb_Vertex2.normal *= 1f / (float)num2;
			pb_Vertex2.tangent *= 1f / (float)num3;
			pb_Vertex2.uv2 *= 1f / (float)num4;
			pb_Vertex2.uv3 *= 1f / (float)num5;
			pb_Vertex2.uv4 *= 1f / (float)num6;
			return pb_Vertex2;
		}

		public static pb_Vertex Mix(pb_Vertex x, pb_Vertex y, float a)
		{
			float num = 1f - a;
			pb_Vertex pb_Vertex2 = new pb_Vertex();
			pb_Vertex2.position = x.position * num + y.position * a;
			pb_Vertex2.color = x.color * num + y.color * a;
			pb_Vertex2.uv0 = x.uv0 * num + y.uv0 * a;
			if (x.hasNormal && y.hasNormal)
			{
				pb_Vertex2.normal = x.normal * num + y.normal * a;
			}
			else if (x.hasNormal)
			{
				pb_Vertex2.normal = x.normal;
			}
			else if (y.hasNormal)
			{
				pb_Vertex2.normal = y.normal;
			}
			if (x.hasTangent && y.hasTangent)
			{
				pb_Vertex2.tangent = x.tangent * num + y.tangent * a;
			}
			else if (x.hasTangent)
			{
				pb_Vertex2.tangent = x.tangent;
			}
			else if (y.hasTangent)
			{
				pb_Vertex2.tangent = y.tangent;
			}
			if (x.hasUv2 && y.hasUv2)
			{
				pb_Vertex2.uv2 = x.uv2 * num + y.uv2 * a;
			}
			else if (x.hasUv2)
			{
				pb_Vertex2.uv2 = x.uv2;
			}
			else if (y.hasUv2)
			{
				pb_Vertex2.uv2 = y.uv2;
			}
			if (x.hasUv3 && y.hasUv3)
			{
				pb_Vertex2.uv3 = x.uv3 * num + y.uv3 * a;
			}
			else if (x.hasUv3)
			{
				pb_Vertex2.uv3 = x.uv3;
			}
			else if (y.hasUv3)
			{
				pb_Vertex2.uv3 = y.uv3;
			}
			if (x.hasUv4 && y.hasUv4)
			{
				pb_Vertex2.uv4 = x.uv4 * num + y.uv4 * a;
			}
			else if (x.hasUv4)
			{
				pb_Vertex2.uv4 = x.uv4;
			}
			else if (y.hasUv4)
			{
				pb_Vertex2.uv4 = y.uv4;
			}
			return pb_Vertex2;
		}
	}
	public class pb_VertexConnection : IEquatable<pb_VertexConnection>
	{
		public pb_Face face;

		public List<int> indices;

		public bool isValid
		{
			get
			{
				if (indices != null)
				{
					return indices.Count > 1;
				}
				return false;
			}
		}

		public pb_VertexConnection(pb_Face face, List<int> indices)
		{
			this.face = face;
			this.indices = indices;
		}

		public pb_VertexConnection Distinct(pb_IntArray[] sharedIndices)
		{
			return new pb_VertexConnection(face, sharedIndices.UniqueIndicesWithValues(indices).ToList());
		}

		public override bool Equals(object b)
		{
			if (!(b is pb_VertexConnection))
			{
				return false;
			}
			return face == ((pb_VertexConnection)b).face;
		}

		public bool Equals(pb_VertexConnection vc)
		{
			return face == vc.face;
		}

		public static implicit operator pb_Face(pb_VertexConnection vc)
		{
			return vc.face;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return face.ToString() + " : " + pbUtil.ToString(indices);
		}

		public static List<int> AllTriangles(List<pb_VertexConnection> vcs)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < vcs.Count; i++)
			{
				list.AddRange(vcs[i].indices);
			}
			return list;
		}
	}
	public class pb_WingedEdge : IEquatable<pb_WingedEdge>, IEnumerable
	{
		public pb_EdgeLookup edge;

		public pb_Face face;

		public pb_WingedEdge next;

		public pb_WingedEdge previous;

		public pb_WingedEdge opposite;

		public bool Equals(pb_WingedEdge b)
		{
			if (b != null)
			{
				return edge.local.Equals(b.edge.local);
			}
			return false;
		}

		public override bool Equals(object b)
		{
			if (b is pb_WingedEdge b2 && Equals(b2))
			{
				return true;
			}
			if (b is pb_Edge obj && Equals(obj))
			{
				return true;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return edge.local.GetHashCode();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public pb_WingedEdgeEnumerator GetEnumerator()
		{
			return new pb_WingedEdgeEnumerator(this);
		}

		public override string ToString()
		{
			return string.Format("Common: {0}\nLocal: {1}\nOpposite: {2}\nFace: {3}", edge.common.ToString(), edge.local.ToString(), (opposite == null) ? "null" : opposite.edge.ToString(), face.ToString());
		}

		public pb_WingedEdge GetAdjacentEdgeWithCommonIndex(int common)
		{
			if (next.edge.common.Contains(common))
			{
				return next;
			}
			if (previous.edge.common.Contains(common))
			{
				return previous;
			}
			return null;
		}

		public static List<pb_Edge> SortEdgesByAdjacency(pb_Face face)
		{
			List<pb_Edge> edges = new List<pb_Edge>(face.edges);
			return SortEdgesByAdjacency(edges);
		}

		public static List<pb_Edge> SortEdgesByAdjacency(List<pb_Edge> edges)
		{
			for (int i = 1; i < edges.Count; i++)
			{
				int y = edges[i - 1].y;
				for (int j = i + 1; j < edges.Count; j++)
				{
					if (edges[j].x == y || edges[j].y == y)
					{
						pb_Edge value = edges[j];
						edges[j] = edges[i];
						edges[i] = value;
					}
				}
			}
			return edges;
		}

		public static Dictionary<int, List<pb_WingedEdge>> GetSpokes(List<pb_WingedEdge> wings)
		{
			Dictionary<int, List<pb_WingedEdge>> dictionary = new Dictionary<int, List<pb_WingedEdge>>();
			List<pb_WingedEdge> value = null;
			for (int i = 0; i < wings.Count; i++)
			{
				if (dictionary.TryGetValue(wings[i].edge.common.x, out value))
				{
					value.Add(wings[i]);
				}
				else
				{
					dictionary.Add(wings[i].edge.common.x, new List<pb_WingedEdge> { wings[i] });
				}
				if (dictionary.TryGetValue(wings[i].edge.common.y, out value))
				{
					value.Add(wings[i]);
					continue;
				}
				dictionary.Add(wings[i].edge.common.y, new List<pb_WingedEdge> { wings[i] });
			}
			return dictionary;
		}

		public static List<int> SortCommonIndicesByAdjacency(List<pb_WingedEdge> wings, HashSet<int> common)
		{
			List<pb_Edge> list = (from y in wings
				where common.Contains(y.edge.common.x) && common.Contains(y.edge.common.y)
				select y.edge.common).ToList();
			if (list.Count != common.Count)
			{
				return null;
			}
			return (from x in SortEdgesByAdjacency(list)
				select x.x).ToList();
		}

		public static List<pb_WingedEdge> GetWingedEdges(pb_Object pb, bool oneWingPerFace = false)
		{
			return GetWingedEdges(pb, pb.faces, oneWingPerFace);
		}

		public static List<pb_WingedEdge> GetWingedEdges(pb_Object pb, IEnumerable<pb_Face> faces, bool oneWingPerFace = false)
		{
			Dictionary<int, int> dictionary = pb.sharedIndices.ToDictionary();
			IEnumerable<pb_Face> enumerable = faces.Distinct();
			List<pb_WingedEdge> list = new List<pb_WingedEdge>();
			Dictionary<pb_Edge, pb_WingedEdge> dictionary2 = new Dictionary<pb_Edge, pb_WingedEdge>();
			int num = 0;
			foreach (pb_Face item in enumerable)
			{
				List<pb_Edge> list2 = SortEdgesByAdjacency(item);
				int count = list2.Count;
				pb_WingedEdge pb_WingedEdge2 = null;
				pb_WingedEdge pb_WingedEdge3 = null;
				for (int i = 0; i < count; i++)
				{
					pb_Edge pb_Edge2 = list2[i];
					pb_WingedEdge pb_WingedEdge4 = new pb_WingedEdge();
					pb_WingedEdge4.edge = new pb_EdgeLookup(dictionary[pb_Edge2.x], dictionary[pb_Edge2.y], pb_Edge2.x, pb_Edge2.y);
					pb_WingedEdge4.face = item;
					if (i < 1)
					{
						pb_WingedEdge2 = pb_WingedEdge4;
					}
					if (i > 0)
					{
						pb_WingedEdge4.previous = pb_WingedEdge3;
						pb_WingedEdge3.next = pb_WingedEdge4;
					}
					if (i == count - 1)
					{
						pb_WingedEdge4.next = pb_WingedEdge2;
						pb_WingedEdge2.previous = pb_WingedEdge4;
					}
					pb_WingedEdge3 = pb_WingedEdge4;
					if (dictionary2.TryGetValue(pb_WingedEdge4.edge.common, out var value))
					{
						value.opposite = pb_WingedEdge4;
						pb_WingedEdge4.opposite = value;
					}
					else
					{
						pb_WingedEdge4.opposite = null;
						dictionary2.Add(pb_WingedEdge4.edge.common, pb_WingedEdge4);
					}
					if (!oneWingPerFace || i < 1)
					{
						list.Add(pb_WingedEdge4);
					}
				}
				num += count;
			}
			return list;
		}
	}
	public class pb_WingedEdgeEnumerator : IEnumerator
	{
		private pb_WingedEdge _start;

		private pb_WingedEdge _current;

		object IEnumerator.Current => Current;

		public pb_WingedEdge Current
		{
			get
			{
				try
				{
					return _current;
				}
				catch (IndexOutOfRangeException)
				{
					throw new InvalidOperationException();
				}
			}
		}

		public pb_WingedEdgeEnumerator(pb_WingedEdge start)
		{
			_start = start;
			_current = null;
		}

		public bool MoveNext()
		{
			if (_current == null)
			{
				_current = _start;
				return _current != null;
			}
			_current = _current.next;
			if (_current != null)
			{
				return _current != _start;
			}
			return false;
		}

		public void Reset()
		{
			_current = null;
		}
	}
}
