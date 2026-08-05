using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Mono.Math;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class KGFJCOBLDHL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0")]
	public KGFJCOBLDHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, IMCNOLHKLGP, JHMBKELLFAK, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x69FA00", Offset = "0x69E600", VA = "0x18069FA00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x696D30", VA = "0x180698130", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6BA2B0", Offset = "0x6B8EB0", VA = "0x1806BA2B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6DA0B0", Offset = "0x6D8CB0", VA = "0x1806DA0B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash FHKABFEFMDN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x71C1E0", Offset = "0x71ADE0", VA = "0x18071C1E0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[ODCNOJHGDMD]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[ODCNOJHGDMD]
	[SerializeField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5FA4AF0", Offset = "0x5FA36F0", VA = "0x185FA4AF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FA4AB0", Offset = "0x5FA36B0", VA = "0x185FA4AB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FA4B30", Offset = "0x5FA3730", VA = "0x185FA4B30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5FA4D00", Offset = "0x5FA3900", VA = "0x185FA4D00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FA4C70", Offset = "0x5FA3870", VA = "0x185FA4C70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x82E840", Offset = "0x82D440", VA = "0x18082E840")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x85AA40", Offset = "0x859640", VA = "0x18085AA40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5FA4A70", Offset = "0x5FA3670", VA = "0x185FA4A70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5FA4BE0", Offset = "0x5FA37E0", VA = "0x185FA4BE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5FA44B0", Offset = "0x5FA30B0", VA = "0x185FA44B0")]
	public void CopyBounds(SavedExtents GHLMPEGFGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5FA49D0", Offset = "0x5FA35D0", VA = "0x185FA49D0")]
	public void SetLocalSpaceBounds(Bounds COHBFKLGPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9DE680", Offset = "0x9DD280", VA = "0x1809DE680")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5FA49C0", Offset = "0x5FA35C0", VA = "0x185FA49C0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5FA44E0", Offset = "0x5FA30E0", VA = "0x185FA44E0")]
	private void FCKJOIJBMLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4790", Offset = "0x5FA3390", VA = "0x185FA4790")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3E70", Offset = "0x5FA2A70", VA = "0x185FA3E70")]
	public static void CalculateLocalBoundsFor(GameObject OKGHLJEDAEA, out Bounds COHBFKLGPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5FA46D0", Offset = "0x5FA32D0", VA = "0x185FA46D0")]
	private static void ICLOKGKHGHO(Bounds APLKEMLCGID, Color KIBHBIAPJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5FA49F0", Offset = "0x5FA35F0", VA = "0x185FA49F0")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x678060", Offset = "0x676C60", VA = "0x180678060")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7072B0", Offset = "0x705EB0", VA = "0x1807072B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9300F0", Offset = "0x92ECF0", VA = "0x1809300F0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xF87400", Offset = "0xF86000", VA = "0x180F87400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "4")]
	public virtual void GPAIAAMOMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[KGFJCOBLDHL]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3704A10", Offset = "0x3703610", VA = "0x183704A10", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3704140", Offset = "0x3702D40", VA = "0x183704140", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3704F50", Offset = "0x3703B50", VA = "0x183704F50")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class FGKDIBLFAFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		public FGKDIBLFAFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x39FFCF0", Offset = "0x39FE8F0", VA = "0x1839FFCF0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[KGFJCOBLDHL]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1DCB430", Offset = "0x1DCA030", VA = "0x181DCB430", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1DCB460", Offset = "0x1DCA060", VA = "0x181DCB460", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1DCB380", Offset = "0x1DC9F80", VA = "0x181DCB380", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey NANBEBOOGPM]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1DCB3B0", Offset = "0x1DC9FB0", VA = "0x181DCB3B0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1DCB280", Offset = "0x1DC9E80", VA = "0x181DCB280", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1DCAC00", Offset = "0x1DC9800", VA = "0x181DCAC00", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA2D0", Offset = "0x1DC8ED0", VA = "0x181DCA2D0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA240", Offset = "0x1DC8E40", VA = "0x181DCA240", Slot = "14")]
	protected virtual string MNFLAILPMPP(TKeyVal BOMIEMKLDNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA180", Offset = "0x1DC8D80", VA = "0x181DCA180", Slot = "4")]
	public bool ContainsKey(TKey NANBEBOOGPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB170", Offset = "0x1DC9D70", VA = "0x181DCB170", Slot = "5")]
	public bool TryGetValue(TKey NANBEBOOGPM, out TVal NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA1B0", Offset = "0x1DC8DB0", VA = "0x181DCA1B0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA1B0", Offset = "0x1DC8DB0", VA = "0x181DCA1B0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB1A0", Offset = "0x1DC9DA0", VA = "0x181DCB1A0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GCEAAJCNEPI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class MIAENKBEHKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		public MIAENKBEHKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x39CC8B0", Offset = "0x39CB4B0", VA = "0x1839CC8B0")]
		internal bool <GetSamples>b__0(global::LBIBBDKENBP<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float CKCPGBMOBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float PBLAONLPLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::LBIBBDKENBP<float, T>> GMPMEDCIKDI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int LAKNIOMGHOF
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x393C260", Offset = "0x393AE60", VA = "0x18393C260")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x393C360", Offset = "0x393AF60", VA = "0x18393C360")]
	public GCEAAJCNEPI(float HFHPCNGDAFA, float BLBPHBMOLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x393C100", Offset = "0x393AD00", VA = "0x18393C100")]
	public bool KFHJBMKPKGA(float JNDEHJNOJMH, T NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x393BF10", Offset = "0x393AB10", VA = "0x18393BF10")]
	public int FHAKAFEAKCN(float JNDEHJNOJMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x393B890", Offset = "0x393A490", VA = "0x18393B890")]
	public IEnumerable<T> BLGPKEJACNC(float JNDEHJNOJMH, [Optional] float? BHOAAKPACCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x393BF70", Offset = "0x393AB70", VA = "0x18393BF70")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x393B7D0", Offset = "0x393A3D0", VA = "0x18393B7D0")]
	private void AFPHCLCMFCN(float JNDEHJNOJMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class OODAOPGLIJI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct POIANLAGHON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T FGHAAIAMOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float PIEGCEOIJOP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float DILMIFOLLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> NOCDNADJLOA;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int FPJCJKCIOHE = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private POIANLAGHON[] NMDKCEHJACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int EHJHKMCLLMD;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float CLJNHLIAMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x92F940", Offset = "0x92E540", VA = "0x18092F940")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x92F9D0", Offset = "0x92E5D0", VA = "0x18092F9D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x46246D0", Offset = "0x46232D0", VA = "0x1846246D0")]
	public OODAOPGLIJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x46245F0", Offset = "0x46231F0", VA = "0x1846245F0")]
	public OODAOPGLIJI(int PJGFFECCBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4623140", Offset = "0x4621D40", VA = "0x184623140")]
	public void AABPNGPFBPJ(float JNDEHJNOJMH, T NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4623BF0", Offset = "0x46227F0", VA = "0x184623BF0")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x46233C0", Offset = "0x4621FC0", VA = "0x1846233C0")]
	public bool AACLLBNMDGK(float FBEKNIGGMOA, float ECOOBJIIINB, out T NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4623D40", Offset = "0x4622940", VA = "0x184623D40")]
	public bool GPFIKIMBHKB(float FBEKNIGGMOA, float ECOOBJIIINB, out T NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4624330", Offset = "0x4622F30", VA = "0x184624330")]
	public void MEKKJMNIDJB(float FBEKNIGGMOA, float ECOOBJIIINB, List<T> MMDGIKEBLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x46241C0", Offset = "0x4622DC0", VA = "0x1846241C0")]
	private int JHMNIDALKGE(int AFDHLBCLKHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4624560", Offset = "0x4623160", VA = "0x184624560")]
	private void OOBDEPHBHEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T EGHDDMBKMPE();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T FFEBHHLGNAN(T NEDFKMIBIEI, T FMLJLFCAJGB, float KKEIOLMHDBP);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T HDGBDHAGOIB(T NENFOEKGNGK, float KKEIOLMHDBP);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T OBDHOBOECKE(T NEDFKMIBIEI, T FMLJLFCAJGB);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T KEBDANKPIHE(T NEDFKMIBIEI, T FMLJLFCAJGB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LLOEPIJLKME : global::OODAOPGLIJI<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8DE4C0", Offset = "0x8DD0C0", VA = "0x1808DE4C0", Slot = "4")]
	protected override Vector3 EGHDDMBKMPE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x29CE380", Offset = "0x29CCF80", VA = "0x1829CE380", Slot = "5")]
	protected override Vector3 FFEBHHLGNAN(Vector3 NEDFKMIBIEI, Vector3 FMLJLFCAJGB, float KKEIOLMHDBP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0AF0", Offset = "0x5F9F6F0", VA = "0x185FA0AF0", Slot = "6")]
	protected override Vector3 HDGBDHAGOIB(Vector3 NENFOEKGNGK, float KKEIOLMHDBP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0BC0", Offset = "0x5F9F7C0", VA = "0x185FA0BC0", Slot = "7")]
	protected override Vector3 OBDHOBOECKE(Vector3 NEDFKMIBIEI, Vector3 FMLJLFCAJGB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0B50", Offset = "0x5F9F750", VA = "0x185FA0B50", Slot = "8")]
	protected override Vector3 KEBDANKPIHE(Vector3 NEDFKMIBIEI, Vector3 FMLJLFCAJGB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0C40", Offset = "0x5F9F840", VA = "0x185FA0C40")]
	public LLOEPIJLKME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MIICKPFMBJK : global::OODAOPGLIJI<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0FD0", Offset = "0x5F9FBD0", VA = "0x185FA0FD0")]
	public MIICKPFMBJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1040", Offset = "0x5F9FC40", VA = "0x185FA1040")]
	public MIICKPFMBJK(int PJGFFECCBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8311F0", Offset = "0x82FDF0", VA = "0x1808311F0", Slot = "4")]
	protected override float EGHDDMBKMPE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x9106E0", Offset = "0x90F2E0", VA = "0x1809106E0", Slot = "5")]
	protected override float FFEBHHLGNAN(float NEDFKMIBIEI, float FMLJLFCAJGB, float KKEIOLMHDBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x51EC9D0", Offset = "0x51EB5D0", VA = "0x1851EC9D0", Slot = "6")]
	protected override float HDGBDHAGOIB(float NENFOEKGNGK, float KKEIOLMHDBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x29847F0", Offset = "0x29833F0", VA = "0x1829847F0", Slot = "7")]
	protected override float OBDHOBOECKE(float NEDFKMIBIEI, float FMLJLFCAJGB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0FC0", Offset = "0x5F9FBC0", VA = "0x185FA0FC0", Slot = "8")]
	protected override float KEBDANKPIHE(float NEDFKMIBIEI, float FMLJLFCAJGB)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EANKFOMONIH
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x25436F0", Offset = "0x25422F0", VA = "0x1825436F0")]
	public static global::DADHFHGDKPK<T1> NBONEDNFGGC<T1>(T1 CIEEOBFKICF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D980", Offset = "0x2C9C580", VA = "0x182C9D980")]
	public static global::LBIBBDKENBP<T1, T2> NBONEDNFGGC<T1, T2>(T1 CIEEOBFKICF, T2 FILILLBKALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D9F0", Offset = "0x2C9C5F0", VA = "0x182C9D9F0")]
	public static global::AIFOJGDKKBN<T1, T2, T3> NBONEDNFGGC<T1, T2, T3>(T1 CIEEOBFKICF, T2 FILILLBKALI, T3 HIGCKAHEHMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2C9DD60", Offset = "0x2C9C960", VA = "0x182C9DD60")]
	public static global::DDAFPLLDJOF<T1, T2, T3, T4> NBONEDNFGGC<T1, T2, T3, T4>(T1 CIEEOBFKICF, T2 FILILLBKALI, T3 HIGCKAHEHMB, T4 ELPJMEOPDAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2C9DCC0", Offset = "0x2C9C8C0", VA = "0x182C9DCC0")]
	public static global::JIBEBBGFGLN<T1, T2, T3, T4, T5> NBONEDNFGGC<T1, T2, T3, T4, T5>(T1 CIEEOBFKICF, T2 FILILLBKALI, T3 HIGCKAHEHMB, T4 ELPJMEOPDAK, T5 AIDEJBLIHHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2C9DC10", Offset = "0x2C9C810", VA = "0x182C9DC10")]
	public static global::ACHLHEAHECB<T1, T2, T3, T4, T5, T6> NBONEDNFGGC<T1, T2, T3, T4, T5, T6>(T1 CIEEOBFKICF, T2 FILILLBKALI, T3 HIGCKAHEHMB, T4 ELPJMEOPDAK, T5 AIDEJBLIHHC, T6 LENAKLLDJOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2C9DB50", Offset = "0x2C9C750", VA = "0x182C9DB50")]
	public static global::CIONNOGLJMG<T1, T2, T3, T4, T5, T6, T7> NBONEDNFGGC<T1, T2, T3, T4, T5, T6, T7>(T1 CIEEOBFKICF, T2 FILILLBKALI, T3 HIGCKAHEHMB, T4 ELPJMEOPDAK, T5 AIDEJBLIHHC, T6 LENAKLLDJOP, T7 HHOIKNPACMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2C9DA80", Offset = "0x2C9C680", VA = "0x182C9DA80")]
	public static global::NKBGBFFGALI<T1, T2, T3, T4, T5, T6, T7, T8> NBONEDNFGGC<T1, T2, T3, T4, T5, T6, T7, T8>(T1 CIEEOBFKICF, T2 FILILLBKALI, T3 HIGCKAHEHMB, T4 ELPJMEOPDAK, T5 AIDEJBLIHHC, T6 LENAKLLDJOP, T7 HHOIKNPACMO, T8 OLNHICAOMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2320B10", Offset = "0x231F710", VA = "0x182320B10")]
	[IteratorStateMachine(typeof(HBGHEKAOCFG))]
	public static IEnumerable<global::LBIBBDKENBP<T1, T2>> OAFMCPLNAJH<T1, T2>(IEnumerable<T1> APGJBFJMIBK, IEnumerable<T2> APLKEMLCGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2320CF0", Offset = "0x231F8F0", VA = "0x182320CF0")]
	[IteratorStateMachine(typeof(OEMEOPAANHA))]
	public static IEnumerable<global::AIFOJGDKKBN<T1, T2, T3>> OAFMCPLNAJH<T1, T2, T3>(IEnumerable<T1> APGJBFJMIBK, IEnumerable<T2> APLKEMLCGID, IEnumerable<T3> KIBHBIAPJEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xB88A30", Offset = "0xB87630", VA = "0x180B88A30")]
	internal static int HHAOAEOBFJE(int EJMHFKDLFIN, int JCLBOPJKILP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xB88A20", Offset = "0xB87620", VA = "0x180B88A20")]
	internal static int HHAOAEOBFJE(int EJMHFKDLFIN, int JCLBOPJKILP, int GLHNJOLNCDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xB88A00", Offset = "0xB87600", VA = "0x180B88A00")]
	internal static int HHAOAEOBFJE(int EJMHFKDLFIN, int JCLBOPJKILP, int GLHNJOLNCDI, int DAECFDBCHKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D8E0", Offset = "0x5F9C4E0", VA = "0x185F9D8E0")]
	internal static int HHAOAEOBFJE(int EJMHFKDLFIN, int JCLBOPJKILP, int GLHNJOLNCDI, int DAECFDBCHKO, int GGDOHPHPGJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D890", Offset = "0x5F9C490", VA = "0x185F9D890")]
	internal static int HHAOAEOBFJE(int EJMHFKDLFIN, int JCLBOPJKILP, int GLHNJOLNCDI, int DAECFDBCHKO, int GGDOHPHPGJH, int FIFKPALKKPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D8B0", Offset = "0x5F9C4B0", VA = "0x185F9D8B0")]
	internal static int HHAOAEOBFJE(int EJMHFKDLFIN, int JCLBOPJKILP, int GLHNJOLNCDI, int DAECFDBCHKO, int GGDOHPHPGJH, int FIFKPALKKPM, int EGABOFOOEMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D860", Offset = "0x5F9C460", VA = "0x185F9D860")]
	internal static int HHAOAEOBFJE(int EJMHFKDLFIN, int JCLBOPJKILP, int GLHNJOLNCDI, int DAECFDBCHKO, int GGDOHPHPGJH, int FIFKPALKKPM, int EGABOFOOEMD, int HFFHAACDOFC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DADHFHGDKPK<T1> : IComparable<global::DADHFHGDKPK<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 FMOGGIIDHPP;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x26FDAA0", Offset = "0x26FC6A0", VA = "0x1826FDAA0")]
	public DADHFHGDKPK(T1 CIEEOBFKICF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3D02990", Offset = "0x3D01590", VA = "0x183D02990", Slot = "4")]
	public int CompareTo(global::DADHFHGDKPK<T1> GHLMPEGFGCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3D02A00", Offset = "0x3D01600", VA = "0x183D02A00", Slot = "0")]
	public override bool Equals(object GHLMPEGFGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7B6D90", Offset = "0x7B5990", VA = "0x1807B6D90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3D02AA0", Offset = "0x3D016A0", VA = "0x183D02AA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LBIBBDKENBP<T1, T2> : IComparable<global::LBIBBDKENBP<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 FMOGGIIDHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 EMJFDCGLKJP;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x270DB10", Offset = "0x270C710", VA = "0x18270DB10")]
	public LBIBBDKENBP(T1 CIEEOBFKICF, T2 FILILLBKALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x270BE40", Offset = "0x270AA40", VA = "0x18270BE40", Slot = "4")]
	public int CompareTo(global::LBIBBDKENBP<T1, T2> GHLMPEGFGCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x270C0B0", Offset = "0x270ACB0", VA = "0x18270C0B0", Slot = "0")]
	public override bool Equals(object GHLMPEGFGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x270CDF0", Offset = "0x270B9F0", VA = "0x18270CDF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x270D7C0", Offset = "0x270C3C0", VA = "0x18270D7C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AIFOJGDKKBN<T1, T2, T3> : IComparable<global::AIFOJGDKKBN<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 FMOGGIIDHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 EMJFDCGLKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 EMBCIKPOEBK;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3065DC0", Offset = "0x30649C0", VA = "0x183065DC0")]
	public AIFOJGDKKBN(T1 CIEEOBFKICF, T2 FILILLBKALI, T3 HIGCKAHEHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x30656B0", Offset = "0x30642B0", VA = "0x1830656B0", Slot = "4")]
	public int CompareTo(global::AIFOJGDKKBN<T1, T2, T3> GHLMPEGFGCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x30658A0", Offset = "0x30644A0", VA = "0x1830658A0", Slot = "0")]
	public override bool Equals(object GHLMPEGFGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3065A10", Offset = "0x3064610", VA = "0x183065A10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3065C10", Offset = "0x3064810", VA = "0x183065C10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DDAFPLLDJOF<T1, T2, T3, T4> : IComparable<global::DDAFPLLDJOF<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 FMOGGIIDHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 EMJFDCGLKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 EMBCIKPOEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 LCOCABFCFGL;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2BF0A30", Offset = "0x2BEF630", VA = "0x182BF0A30")]
	public DDAFPLLDJOF(T1 CIEEOBFKICF, T2 FILILLBKALI, T3 HIGCKAHEHMB, T4 ELPJMEOPDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2D806E0", Offset = "0x2D7F2E0", VA = "0x182D806E0", Slot = "4")]
	public int CompareTo(global::DDAFPLLDJOF<T1, T2, T3, T4> GHLMPEGFGCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2D80820", Offset = "0x2D7F420", VA = "0x182D80820", Slot = "0")]
	public override bool Equals(object GHLMPEGFGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2D80940", Offset = "0x2D7F540", VA = "0x182D80940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2D80A00", Offset = "0x2D7F600", VA = "0x182D80A00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JIBEBBGFGLN<T1, T2, T3, T4, T5> : IComparable<global::JIBEBBGFGLN<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 FMOGGIIDHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 EMJFDCGLKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 EMBCIKPOEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 LCOCABFCFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 KKIBDCGFLKB;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2FCF560", Offset = "0x2FCE160", VA = "0x182FCF560")]
	public JIBEBBGFGLN(T1 CIEEOBFKICF, T2 FILILLBKALI, T3 HIGCKAHEHMB, T4 ELPJMEOPDAK, T5 AIDEJBLIHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x31E1250", Offset = "0x31DFE50", VA = "0x1831E1250", Slot = "4")]
	public int CompareTo(global::JIBEBBGFGLN<T1, T2, T3, T4, T5> GHLMPEGFGCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x31E13D0", Offset = "0x31DFFD0", VA = "0x1831E13D0", Slot = "0")]
	public override bool Equals(object GHLMPEGFGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x31E1510", Offset = "0x31E0110", VA = "0x1831E1510", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x31E1610", Offset = "0x31E0210", VA = "0x1831E1610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ACHLHEAHECB<T1, T2, T3, T4, T5, T6> : IComparable<global::ACHLHEAHECB<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 FMOGGIIDHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 EMJFDCGLKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 EMBCIKPOEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 LCOCABFCFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 KKIBDCGFLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 FHIHLNEOJEE;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x304E5B0", Offset = "0x304D1B0", VA = "0x18304E5B0")]
	public ACHLHEAHECB(T1 CIEEOBFKICF, T2 FILILLBKALI, T3 HIGCKAHEHMB, T4 ELPJMEOPDAK, T5 AIDEJBLIHHC, T6 LENAKLLDJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x304DFF0", Offset = "0x304CBF0", VA = "0x18304DFF0", Slot = "4")]
	public int CompareTo(global::ACHLHEAHECB<T1, T2, T3, T4, T5, T6> GHLMPEGFGCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x304E1B0", Offset = "0x304CDB0", VA = "0x18304E1B0", Slot = "0")]
	public override bool Equals(object GHLMPEGFGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x304E320", Offset = "0x304CF20", VA = "0x18304E320", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x304E440", Offset = "0x304D040", VA = "0x18304E440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CIONNOGLJMG<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::CIONNOGLJMG<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 FMOGGIIDHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 EMJFDCGLKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 EMBCIKPOEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 LCOCABFCFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 KKIBDCGFLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 FHIHLNEOJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 IAMOMHHOODF;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x30E7770", Offset = "0x30E6370", VA = "0x1830E7770")]
	public CIONNOGLJMG(T1 CIEEOBFKICF, T2 FILILLBKALI, T3 HIGCKAHEHMB, T4 ELPJMEOPDAK, T5 AIDEJBLIHHC, T6 LENAKLLDJOP, T7 HHOIKNPACMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x30E70F0", Offset = "0x30E5CF0", VA = "0x1830E70F0", Slot = "4")]
	public int CompareTo(global::CIONNOGLJMG<T1, T2, T3, T4, T5, T6, T7> GHLMPEGFGCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x30E72F0", Offset = "0x30E5EF0", VA = "0x1830E72F0", Slot = "0")]
	public override bool Equals(object GHLMPEGFGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x30E7490", Offset = "0x30E6090", VA = "0x1830E7490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x30E75E0", Offset = "0x30E61E0", VA = "0x1830E75E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NKBGBFFGALI<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::NKBGBFFGALI<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 FMOGGIIDHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 EMJFDCGLKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 EMBCIKPOEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 LCOCABFCFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 KKIBDCGFLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 FHIHLNEOJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 IAMOMHHOODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 PEHADPABNGO;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3327550", Offset = "0x3326150", VA = "0x183327550")]
	public NKBGBFFGALI(T1 CIEEOBFKICF, T2 FILILLBKALI, T3 HIGCKAHEHMB, T4 ELPJMEOPDAK, T5 AIDEJBLIHHC, T6 LENAKLLDJOP, T7 HHOIKNPACMO, T8 OLNHICAOMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3326E20", Offset = "0x3325A20", VA = "0x183326E20", Slot = "4")]
	public int CompareTo(global::NKBGBFFGALI<T1, T2, T3, T4, T5, T6, T7, T8> GHLMPEGFGCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3327070", Offset = "0x3325C70", VA = "0x183327070", Slot = "0")]
	public override bool Equals(object GHLMPEGFGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3327230", Offset = "0x3325E30", VA = "0x183327230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x33273A0", Offset = "0x3325FA0", VA = "0x1833273A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T FGHAAIAMOAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1FC62A0", Offset = "0x1FC4EA0", VA = "0x181FC62A0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x426EE70", Offset = "0x426DA70", VA = "0x18426EE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float ECAKCOKIFAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x74B670", Offset = "0x74A270", VA = "0x18074B670")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x426F060", Offset = "0x426DC60", VA = "0x18426F060")]
	public T DAFLJFMJLFI(float KKEIOLMHDBP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x426F200", Offset = "0x426DE00", VA = "0x18426F200")]
	public T DNLGLIJCEOJ(float KKEIOLMHDBP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T FFEBHHLGNAN(T NEDFKMIBIEI, T FMLJLFCAJGB, float KKEIOLMHDBP);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x9106E0", Offset = "0x90F2E0", VA = "0x1809106E0", Slot = "4")]
	protected override float FFEBHHLGNAN(float NEDFKMIBIEI, float FMLJLFCAJGB, float KKEIOLMHDBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F9EEB0", Offset = "0x5F9DAB0", VA = "0x185F9EEB0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x29CE380", Offset = "0x29CCF80", VA = "0x1829CE380", Slot = "4")]
	protected override Vector3 FFEBHHLGNAN(Vector3 NEDFKMIBIEI, Vector3 FMLJLFCAJGB, float KKEIOLMHDBP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5C90", Offset = "0x5FA4890", VA = "0x185FA5C90")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5F9CBB0", Offset = "0x5F9B7B0", VA = "0x185F9CBB0", Slot = "4")]
	protected override Color FFEBHHLGNAN(Color NEDFKMIBIEI, Color FMLJLFCAJGB, float KKEIOLMHDBP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5F9CC00", Offset = "0x5F9B800", VA = "0x185F9CC00")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JKJJOACPKJL : global::MNPIPBJHEJI<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0060", Offset = "0x5F9EC60", VA = "0x185FA0060")]
	public JKJJOACPKJL(int KOHJKAOCDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0000", Offset = "0x5F9EC00", VA = "0x185FA0000")]
	public JKJJOACPKJL(CINDKDIKOEG[] IFDILEIGNOD, bool CHMAFJJOCKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5F9FF90", Offset = "0x5F9EB90", VA = "0x185F9FF90", Slot = "6")]
	protected override uint EKNKKHIFOMA(uint FHKABFEFMDN, string NENFOEKGNGK)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DDNNLEBIDDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable OHEGMANNBEJ;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public DDNNLEBIDDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct ADOOLPBABFL
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class KFNOLAJHPKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<CJFIGKJMGNA> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public KFNOLAJHPKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5FA0870", Offset = "0x5F9F470", VA = "0x185FA0870")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<CJFIGKJMGNA>> NIMFFGEMFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int PMIOPLNFJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int CKIJECHGGLI;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x9D5A30", Offset = "0x9D4630", VA = "0x1809D5A30")]
	private ADOOLPBABFL(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<CJFIGKJMGNA>> HNMAOGBPOBF, int FJMNCLINFKN, int JLCECPGLFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5F9C410", Offset = "0x5F9B010", VA = "0x185F9C410")]
	public static ADOOLPBABFL GADFBDMBHED()
	{
		return default(ADOOLPBABFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5F9C020", Offset = "0x5F9AC20", VA = "0x185F9C020")]
	public (int, int, Task) ADOJDDKAADF(int EAIIKDHHCAH, [Optional] CancellationToken OKPCBPJCBCJ)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5F9BF40", Offset = "0x5F9AB40", VA = "0x185F9BF40")]
	public void ACDOEEEFCDO(int EAIIKDHHCAH, int JLCECPGLFFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class GIHGFAMGDBN<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> BNGLGICBGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> HAJJFFJEBGP;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2628870", Offset = "0x2627470", VA = "0x182628870", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool AALAJCGHMIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8E0", Offset = "0x6AC4E0", VA = "0x1806AD8E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> ECDFCCCLKDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2DBC9C0", Offset = "0x2DBB5C0", VA = "0x182DBC9C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> GJJIHPMPOBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2C3E7B0", Offset = "0x2C3D3B0", VA = "0x182C3E7B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x33AC6A0", Offset = "0x33AB2A0", VA = "0x1833AC6A0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x30F6210", Offset = "0x30F4E10", VA = "0x1830F6210", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x33AC160", Offset = "0x33AAD60", VA = "0x1833AC160")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x33ABCA0", Offset = "0x33AA8A0", VA = "0x1833ABCA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x33ABB50", Offset = "0x33AA750", VA = "0x1833ABB50", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x33AC520", Offset = "0x33AB120", VA = "0x1833AC520", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x33ABA90", Offset = "0x33AA690", VA = "0x1833ABA90", Slot = "9")]
	public void Add(TKey NANBEBOOGPM, TVal NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x33ABAF0", Offset = "0x33AA6F0", VA = "0x1833ABAF0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> ALHICNJOIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x33ABBB0", Offset = "0x33AA7B0", VA = "0x1833ABBB0", Slot = "8")]
	public bool ContainsKey(TKey NANBEBOOGPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x33ABC10", Offset = "0x33AA810", VA = "0x1833ABC10", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> ALHICNJOIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x33AC4F0", Offset = "0x33AB0F0", VA = "0x1833AC4F0", Slot = "10")]
	public bool Remove(TKey NANBEBOOGPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x33AC4F0", Offset = "0x33AB0F0", VA = "0x1833AC4F0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> ALHICNJOIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2DD8060", Offset = "0x2DD6C60", VA = "0x182DD8060", Slot = "11")]
	public bool TryGetValue(TKey NANBEBOOGPM, out TVal NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x33ABE30", Offset = "0x33AAA30", VA = "0x1833ABE30", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x33ABC40", Offset = "0x33AA840", VA = "0x1833ABC40", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] NMDKCEHJACP, int JBNOJAIGFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x33AB9E0", Offset = "0x33AA5E0", VA = "0x1833AB9E0")]
	public void AABPNGPFBPJ(TVal IAFIPJAFKOF, TKey NANBEBOOGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x33ABA20", Offset = "0x33AA620", VA = "0x1833ABA20")]
	public void AABPNGPFBPJ(KeyValuePair<TVal, TKey> ALHICNJOIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x33ABB20", Offset = "0x33AA720", VA = "0x1833ABB20")]
	public bool BLBCENAIAJB(TVal NANBEBOOGPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x33ABFC0", Offset = "0x33AABC0", VA = "0x1833ABFC0")]
	public bool INBBKHIKIAC(KeyValuePair<TVal, TKey> ALHICNJOIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2FC41F0", Offset = "0x2FC2DF0", VA = "0x182FC41F0")]
	public bool KFPKFODPJHB(TVal NANBEBOOGPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2FC41F0", Offset = "0x2FC2DF0", VA = "0x182FC41F0")]
	public bool KFPKFODPJHB(KeyValuePair<TVal, TKey> ALHICNJOIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x33AC190", Offset = "0x33AAD90", VA = "0x1833AC190")]
	public bool PDCGIMKGOOO(TVal NANBEBOOGPM, out TKey NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x33ABF40", Offset = "0x33AAB40", VA = "0x1833ABF40")]
	public IEnumerator<KeyValuePair<TVal, TKey>> HENALCLOMHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x33ABDB0", Offset = "0x33AA9B0", VA = "0x1833ABDB0")]
	private void GFMIPPPJCDO(TKey NANBEBOOGPM, TVal IAFIPJAFKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x33AC020", Offset = "0x33AAC20", VA = "0x1833AC020")]
	private void JDDCJIBKDGK(TKey NANBEBOOGPM, TVal IAFIPJAFKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x33AC340", Offset = "0x33AAF40", VA = "0x1833AC340")]
	private bool PMCJKECIICG(TKey NANBEBOOGPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x33AC1C0", Offset = "0x33AADC0", VA = "0x1833AC1C0")]
	private bool PMCJKECIICG(TVal IAFIPJAFKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x33AC5C0", Offset = "0x33AB1C0", VA = "0x1833AC5C0")]
	public GIHGFAMGDBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class DKOBGKOJBLF<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::DKOBGKOJBLF<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x368A560", Offset = "0x3689160", VA = "0x18368A560", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x35F0F20", Offset = "0x35EFB20", VA = "0x1835F0F20")]
		public Enumerator(global::DKOBGKOJBLF<T> MMDGIKEBLFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3688E40", Offset = "0x3687A40", VA = "0x183688E40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3689D60", Offset = "0x3688960", VA = "0x183689D60", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3687070", Offset = "0x3685C70", VA = "0x183687070")]
		private void BHCDHIBJAHI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] MKBIPAOEEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int DOEIFPENHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int JLAKIGJBAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int OLOLCGEOMNE;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2FC62C0", Offset = "0x2FC4EC0", VA = "0x182FC62C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7370", Offset = "0x2FC5F70", VA = "0x182FC7370")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6570", Offset = "0x2FC5170", VA = "0x182FC6570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7B50", Offset = "0x2FC6750", VA = "0x182FC7B50")]
	public DKOBGKOJBLF(int KOHJKAOCDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2FC5E40", Offset = "0x2FC4A40", VA = "0x182FC5E40")]
	public void AABPNGPFBPJ(T KKEIOLMHDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6A00", Offset = "0x2FC5600", VA = "0x182FC6A00")]
	public void IPAEIBMBLLJ(IEnumerable<T> KDPIBNOPKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6660", Offset = "0x2FC5260", VA = "0x182FC6660")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6680", Offset = "0x2FC5280", VA = "0x182FC6680")]
	public void GJOOAJIALDF(int GGKDNLHEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6300", Offset = "0x2FC4F00", VA = "0x182FC6300")]
	public void DDKIHAHALAA(int GGKDNLHEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7490", Offset = "0x2FC6090", VA = "0x182FC7490")]
	public void NHFCLGLPBNB(T[] NMDKCEHJACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2FC63F0", Offset = "0x2FC4FF0", VA = "0x182FC63F0")]
	public Enumerator EEAMIAJAFGO()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7A50", Offset = "0x2FC6650", VA = "0x182FC7A50", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7A50", Offset = "0x2FC6650", VA = "0x182FC7A50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2FC60E0", Offset = "0x2FC4CE0", VA = "0x182FC60E0")]
	private int BCKMOIBOHLA(int KLEGICPDLIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6390", Offset = "0x2FC4F90", VA = "0x182FC6390")]
	private int ECOJMIJGKMC(int KLEGICPDLIF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class FDNLDINPKNF<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> FDBGEGDEIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> EIANMFPBAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> FOLHIKGIGJA;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> CEEGDGDOKMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x696D30", VA = "0x180698130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6BA2B0", Offset = "0x6B8EB0", VA = "0x1806BA2B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool AALAJCGHMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7C4280", Offset = "0x7C2E80", VA = "0x1807C4280", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7C4300", Offset = "0x7C2F00", VA = "0x1807C4300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2DB1170", Offset = "0x2DAFD70", VA = "0x182DB1170", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2DB1210", Offset = "0x2DAFE10", VA = "0x182DB1210", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2DB1110", Offset = "0x2DAFD10", VA = "0x182DB1110", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2DB1080", Offset = "0x2DAFC80", VA = "0x182DB1080")]
	public FDNLDINPKNF(Func<Internal, External> FDBGEGDEIEF, Func<External, Internal> EIANMFPBAKI, bool GEAOBIGLECL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2DB0DA0", Offset = "0x2DAF9A0", VA = "0x182DB0DA0", Slot = "6")]
	public int IndexOf(External ALHICNJOIJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2DB0A20", Offset = "0x2DAF620", VA = "0x182DB0A20", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2DB0A80", Offset = "0x2DAF680", VA = "0x182DB0A80", Slot = "13")]
	public bool Contains(External ALHICNJOIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2DB0B10", Offset = "0x2DAF710", VA = "0x182DB0B10", Slot = "14")]
	public void CopyTo(External[] NMDKCEHJACP, int JBNOJAIGFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2DB0990", Offset = "0x2DAF590", VA = "0x182DB0990", Slot = "11")]
	public void Add(External ALHICNJOIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2DB0E90", Offset = "0x2DAFA90", VA = "0x182DB0E90", Slot = "7")]
	public void Insert(int KLEGICPDLIF, External ALHICNJOIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2DB0FF0", Offset = "0x2DAFBF0", VA = "0x182DB0FF0", Slot = "15")]
	public bool Remove(External ALHICNJOIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2DB0F30", Offset = "0x2DAFB30", VA = "0x182DB0F30", Slot = "8")]
	public void RemoveAt(int KLEGICPDLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2DB0D30", Offset = "0x2DAF930", VA = "0x182DB0D30", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2A71EC0", Offset = "0x2A70AC0", VA = "0x182A71EC0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class IDHMCLOCKON<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> FDBGEGDEIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> FOLHIKGIGJA;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> CEEGDGDOKMA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x69FA00", Offset = "0x69E600", VA = "0x18069FA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool AALAJCGHMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6AD850", Offset = "0x6AC450", VA = "0x1806AD850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2BF5FC0", Offset = "0x2BF4BC0", VA = "0x182BF5FC0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2BF5F60", Offset = "0x2BF4B60", VA = "0x182BF5F60", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x26FDAA0", Offset = "0x26FC6A0", VA = "0x1826FDAA0")]
	public IDHMCLOCKON(Func<Internal, External> FDBGEGDEIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5F10", Offset = "0x2BF4B10", VA = "0x182BF5F10")]
	public IDHMCLOCKON(IReadOnlyList<Internal> FOLHIKGIGJA, Func<Internal, External> FDBGEGDEIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5CF0", Offset = "0x2BF48F0", VA = "0x182BF5CF0")]
	public void NHFCLGLPBNB(External[] NMDKCEHJACP, int JBNOJAIGFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5C80", Offset = "0x2BF4880", VA = "0x182BF5C80", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2A71A00", Offset = "0x2A70600", VA = "0x182A71A00", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class HMCPDCOJHOB<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> FOLHIKGIGJA;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> CEEGDGDOKMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x695F10", Offset = "0x694B10", VA = "0x180695F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool AALAJCGHMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6AD850", Offset = "0x6AC450", VA = "0x1806AD850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5020", Offset = "0x3CF3C20", VA = "0x183CF5020", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4FC0", Offset = "0x3CF3BC0", VA = "0x183CF4FC0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x26FDAA0", Offset = "0x26FC6A0", VA = "0x1826FDAA0")]
	public HMCPDCOJHOB(IReadOnlyList<Internal> FOLHIKGIGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3CF4CF0", Offset = "0x3CF38F0", VA = "0x183CF4CF0")]
	public bool INBBKHIKIAC(External ALHICNJOIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3CF4D90", Offset = "0x3CF3990", VA = "0x183CF4D90")]
	public void NHFCLGLPBNB(External[] NMDKCEHJACP, int JBNOJAIGFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3CF4C80", Offset = "0x3CF3880", VA = "0x183CF4C80", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2A71EC0", Offset = "0x2A70AC0", VA = "0x182A71EC0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class FNLBNHPGJJM
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void IHGLGFNOOGG(object[] JGHKPEFMHLD);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	protected FNLBNHPGJJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class PDPAGHJIHKO<T> : FNLBNHPGJJM
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	protected struct ALIMOPBDFNK
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum OOBCJJBMJLC
		{
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public OOBCJJBMJLC JMPEGNOKOOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T MNJNLIAKBME;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int JECBHNNMNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool HMKOLDHBLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool AEDMGCADMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> ACAIBBFIFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<ALIMOPBDFNK> OOOAAJGKHCN;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool OONBNIMMMNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7840", Offset = "0x2DD6440", VA = "0x182DD7840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2DD7880", Offset = "0x2DD6480", VA = "0x182DD7880")]
	protected PDPAGHJIHKO(bool AEDMGCADMPC, bool HMKOLDHBLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2DD7570", Offset = "0x2DD6170", VA = "0x182DD7570")]
	protected bool CFFHOINLNDE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2DD7300", Offset = "0x2DD5F00", VA = "0x182DD7300")]
	protected void ACKHCMOHDFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2DD73C0", Offset = "0x2DD5FC0", VA = "0x182DD73C0")]
	protected void CBMDBFOFAJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2E4B9F0", Offset = "0x2E4A5F0", VA = "0x182E4B9F0")]
	private static void NHALGOEDBDN<U>(ref List<U> FOLHIKGIGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2DD71A0", Offset = "0x2DD5DA0", VA = "0x182DD71A0", Slot = "5")]
	public void AABPNGPFBPJ(T MNJNLIAKBME, bool KHFDDOKNACA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2DD7700", Offset = "0x2DD6300", VA = "0x182DD7700", Slot = "6")]
	public void KFPKFODPJHB(T MNJNLIAKBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2DD75F0", Offset = "0x2DD61F0", VA = "0x182DD75F0")]
	public void GGNFLDPHLOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface DCOFMFEEJJO
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AABPNGPFBPJ(Action MNJNLIAKBME, bool KHFDDOKNACA = false);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFPKFODPJHB(Action MNJNLIAKBME);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class IOJAEKNEPPN : global::PDPAGHJIHKO<Action>, DCOFMFEEJJO
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5F9FF30", Offset = "0x5F9EB30", VA = "0x185F9FF30")]
	public IOJAEKNEPPN(bool AEDMGCADMPC = false, bool HMKOLDHBLLM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5F9FCB0", Offset = "0x5F9E8B0", VA = "0x185F9FCB0")]
	public void GEBDNCFIHAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5F9FEC0", Offset = "0x5F9EAC0", VA = "0x185F9FEC0", Slot = "4")]
	public override void IHGLGFNOOGG(object[] JGHKPEFMHLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5F9FC50", Offset = "0x5F9E850", VA = "0x185F9FC50")]
	public static IOJAEKNEPPN EPPLOIEHBAA(IOJAEKNEPPN AAKHILCALEC, Action MNJNLIAKBME)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5F9FBF0", Offset = "0x5F9E7F0", VA = "0x185F9FBF0")]
	public static IOJAEKNEPPN BJENDDILOPK(IOJAEKNEPPN AAKHILCALEC, Action MNJNLIAKBME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface CNINFNPGFBF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AABPNGPFBPJ(Action<T> MNJNLIAKBME, bool KHFDDOKNACA = false);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFPKFODPJHB(Action<T> MNJNLIAKBME);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class PPCLKJMOJCH<T> : global::PDPAGHJIHKO<Action<T>>, global::CNINFNPGFBF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x270E720", Offset = "0x270D320", VA = "0x18270E720")]
	public PPCLKJMOJCH(bool AEDMGCADMPC = false, bool HMKOLDHBLLM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2FFEDE0", Offset = "0x2FFD9E0", VA = "0x182FFEDE0")]
	public void GEBDNCFIHAJ(T KKEIOLMHDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3001390", Offset = "0x2FFFF90", VA = "0x183001390", Slot = "4")]
	public override void IHGLGFNOOGG(object[] JGHKPEFMHLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2FFDDE0", Offset = "0x2FFC9E0", VA = "0x182FFDDE0")]
	public static global::PPCLKJMOJCH<T> EPPLOIEHBAA(global::PPCLKJMOJCH<T> AAKHILCALEC, Action<T> MNJNLIAKBME)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2FFDD40", Offset = "0x2FFC940", VA = "0x182FFDD40")]
	public static global::PPCLKJMOJCH<T> BJENDDILOPK(global::PPCLKJMOJCH<T> AAKHILCALEC, Action<T> MNJNLIAKBME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface APNALNHFHLO<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AABPNGPFBPJ(Action<T, U> MNJNLIAKBME, bool KHFDDOKNACA = false);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFPKFODPJHB(Action<T, U> MNJNLIAKBME);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class PCKIOEFGILN<T, U> : global::PDPAGHJIHKO<Action<T, U>>, global::APNALNHFHLO<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x270E720", Offset = "0x270D320", VA = "0x18270E720")]
	public PCKIOEFGILN(bool AEDMGCADMPC = false, bool HMKOLDHBLLM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x2DCE0C0", Offset = "0x2DCCCC0", VA = "0x182DCE0C0")]
	public void GEBDNCFIHAJ(T KKEIOLMHDBP, U EDEMBAPNNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2DD0C20", Offset = "0x2DCF820", VA = "0x182DD0C20", Slot = "4")]
	public override void IHGLGFNOOGG(object[] JGHKPEFMHLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD710", Offset = "0x2DCC310", VA = "0x182DCD710")]
	public static global::PCKIOEFGILN<T, U> EPPLOIEHBAA(global::PCKIOEFGILN<T, U> AAKHILCALEC, Action<T, U> MNJNLIAKBME)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD670", Offset = "0x2DCC270", VA = "0x182DCD670")]
	public static global::PCKIOEFGILN<T, U> BJENDDILOPK(global::PCKIOEFGILN<T, U> AAKHILCALEC, Action<T, U> MNJNLIAKBME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface MAOMPBOCGNB<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AABPNGPFBPJ(Action<T, U, V> MNJNLIAKBME, bool KHFDDOKNACA = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFPKFODPJHB(Action<T, U, V> MNJNLIAKBME);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class FKGLJKOGBLF<T, U, V> : global::PDPAGHJIHKO<Action<T, U, V>>, global::MAOMPBOCGNB<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x270E720", Offset = "0x270D320", VA = "0x18270E720")]
	public FKGLJKOGBLF(bool AEDMGCADMPC = false, bool HMKOLDHBLLM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x3A10B90", Offset = "0x3A0F790", VA = "0x183A10B90")]
	public void GEBDNCFIHAJ(T KKEIOLMHDBP, U EDEMBAPNNBE, V ILBEOCCCHNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3A11CD0", Offset = "0x3A108D0", VA = "0x183A11CD0", Slot = "4")]
	public override void IHGLGFNOOGG(object[] JGHKPEFMHLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3A0FBC0", Offset = "0x3A0E7C0", VA = "0x183A0FBC0")]
	public static global::FKGLJKOGBLF<T, U, V> EPPLOIEHBAA(global::FKGLJKOGBLF<T, U, V> AAKHILCALEC, Action<T, U, V> MNJNLIAKBME)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3A0FB20", Offset = "0x3A0E720", VA = "0x183A0FB20")]
	public static global::FKGLJKOGBLF<T, U, V> BJENDDILOPK(global::FKGLJKOGBLF<T, U, V> AAKHILCALEC, Action<T, U, V> MNJNLIAKBME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface ALKADMCJOBO<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AABPNGPFBPJ(Action<T, U, V, W> MNJNLIAKBME, bool KHFDDOKNACA = false);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFPKFODPJHB(Action<T, U, V, W> MNJNLIAKBME);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class LPIBCBBDCPM<T, U, V, W> : global::PDPAGHJIHKO<Action<T, U, V, W>>, global::ALKADMCJOBO<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x270E720", Offset = "0x270D320", VA = "0x18270E720")]
	public LPIBCBBDCPM(bool AEDMGCADMPC = false, bool HMKOLDHBLLM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x35BF490", Offset = "0x35BE090", VA = "0x1835BF490")]
	public void GEBDNCFIHAJ(T KKEIOLMHDBP, U EDEMBAPNNBE, V ILBEOCCCHNM, W OCOLKLFLIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x35C0490", Offset = "0x35BF090", VA = "0x1835C0490", Slot = "4")]
	public override void IHGLGFNOOGG(object[] JGHKPEFMHLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x35BEEF0", Offset = "0x35BDAF0", VA = "0x1835BEEF0")]
	public static global::LPIBCBBDCPM<T, U, V, W> EPPLOIEHBAA(global::LPIBCBBDCPM<T, U, V, W> AAKHILCALEC, Action<T, U, V, W> MNJNLIAKBME)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x35BEE50", Offset = "0x35BDA50", VA = "0x1835BEE50")]
	public static global::LPIBCBBDCPM<T, U, V, W> BJENDDILOPK(global::LPIBCBBDCPM<T, U, V, W> AAKHILCALEC, Action<T, U, V, W> MNJNLIAKBME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface DIKPMLJKBOJ<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AABPNGPFBPJ(Action<T, U, V, W, X> MNJNLIAKBME, bool KHFDDOKNACA = false);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFPKFODPJHB(Action<T, U, V, W, X> MNJNLIAKBME);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class HKIEDJNOHOL<T, U, V, W, X> : global::PDPAGHJIHKO<Action<T, U, V, W, X>>, global::DIKPMLJKBOJ<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x270E720", Offset = "0x270D320", VA = "0x18270E720")]
	public HKIEDJNOHOL(bool AEDMGCADMPC = false, bool HMKOLDHBLLM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x3CEEA60", Offset = "0x3CED660", VA = "0x183CEEA60")]
	public void GEBDNCFIHAJ(T KKEIOLMHDBP, U EDEMBAPNNBE, V ILBEOCCCHNM, W OCOLKLFLIPF, X CCOKEBDEHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3CEF020", Offset = "0x3CEDC20", VA = "0x183CEF020", Slot = "4")]
	public override void IHGLGFNOOGG(object[] JGHKPEFMHLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3CEE9C0", Offset = "0x3CED5C0", VA = "0x183CEE9C0")]
	public static global::HKIEDJNOHOL<T, U, V, W, X> EPPLOIEHBAA(global::HKIEDJNOHOL<T, U, V, W, X> AAKHILCALEC, Action<T, U, V, W, X> MNJNLIAKBME)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3CEE920", Offset = "0x3CED520", VA = "0x183CEE920")]
	public static global::HKIEDJNOHOL<T, U, V, W, X> BJENDDILOPK(global::HKIEDJNOHOL<T, U, V, W, X> AAKHILCALEC, Action<T, U, V, W, X> MNJNLIAKBME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface BAKBIIEHABI<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AABPNGPFBPJ(Action<T, U, V, W, X, Y> MNJNLIAKBME, bool KHFDDOKNACA = false);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFPKFODPJHB(Action<T, U, V, W, X, Y> MNJNLIAKBME);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class KKONNCPHAJL<T, U, V, W, X, Y> : global::PDPAGHJIHKO<Action<T, U, V, W, X, Y>>, global::BAKBIIEHABI<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x270E720", Offset = "0x270D320", VA = "0x18270E720")]
	public KKONNCPHAJL(bool AEDMGCADMPC = false, bool HMKOLDHBLLM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x37C1B50", Offset = "0x37C0750", VA = "0x1837C1B50")]
	public void GEBDNCFIHAJ(T KKEIOLMHDBP, U EDEMBAPNNBE, V ILBEOCCCHNM, W OCOLKLFLIPF, X CCOKEBDEHII, Y DEGPJNBMBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x37C1E00", Offset = "0x37C0A00", VA = "0x1837C1E00", Slot = "4")]
	public override void IHGLGFNOOGG(object[] JGHKPEFMHLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x37C14E0", Offset = "0x37C00E0", VA = "0x1837C14E0")]
	public static global::KKONNCPHAJL<T, U, V, W, X, Y> EPPLOIEHBAA(global::KKONNCPHAJL<T, U, V, W, X, Y> AAKHILCALEC, Action<T, U, V, W, X, Y> MNJNLIAKBME)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x37C1440", Offset = "0x37C0040", VA = "0x1837C1440")]
	public static global::KKONNCPHAJL<T, U, V, W, X, Y> BJENDDILOPK(global::KKONNCPHAJL<T, U, V, W, X, Y> AAKHILCALEC, Action<T, U, V, W, X, Y> MNJNLIAKBME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class OKNKCKFKLEA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct PPKAPDOFPFO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::OKNKCKFKLEA<T> BBJNBABDKPN;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T FGHAAIAMOAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x30028C0", Offset = "0x30014C0", VA = "0x1830028C0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3002890", Offset = "0x3001490", VA = "0x183002890", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x695F00", Offset = "0x694B00", VA = "0x180695F00")]
		public PPKAPDOFPFO(global::OKNKCKFKLEA<T> BBJNBABDKPN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct LCCAFFODANN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<PPKAPDOFPFO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::OKNKCKFKLEA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2C38360", Offset = "0x2C36F60", VA = "0x182C38360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x261B4C0", Offset = "0x261A0C0", VA = "0x18261B4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct LENFOBJBPML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<PPKAPDOFPFO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::OKNKCKFKLEA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2C41AA0", Offset = "0x2C406A0", VA = "0x182C41AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x261B4C0", Offset = "0x261A0C0", VA = "0x18261B4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim AGHAGKMAEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T IOIMHDKAIHO;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int HKHOKBICOFK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x461B230", Offset = "0x4619E30", VA = "0x18461B230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x461B280", Offset = "0x4619E80", VA = "0x18461B280")]
	public OKNKCKFKLEA(in T IOIMHDKAIHO, int MALCAMOILKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x461B250", Offset = "0x4619E50", VA = "0x18461B250")]
	public OKNKCKFKLEA(in T IOIMHDKAIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x461B1F0", Offset = "0x4619DF0", VA = "0x18461B1F0")]
	public PPKAPDOFPFO GLMNHCCCGJG()
	{
		return default(PPKAPDOFPFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x461B1B0", Offset = "0x4619DB0", VA = "0x18461B1B0")]
	public PPKAPDOFPFO GLMNHCCCGJG(CancellationToken OKPCBPJCBCJ)
	{
		return default(PPKAPDOFPFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x461AD80", Offset = "0x4619980", VA = "0x18461AD80")]
	[AsyncStateMachine(typeof(global::OKNKCKFKLEA<>.LCCAFFODANN))]
	public Task<PPKAPDOFPFO> FNNLNLPMFJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x461AEE0", Offset = "0x4619AE0", VA = "0x18461AEE0")]
	[AsyncStateMachine(typeof(global::OKNKCKFKLEA<>.LENFOBJBPML))]
	public Task<PPKAPDOFPFO> FNNLNLPMFJF(CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class KIILCAGGJBL
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0930", Offset = "0x5F9F530", VA = "0x185FA0930")]
	public static global::OKNKCKFKLEA<CJFIGKJMGNA> GADFBDMBHED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA08C0", Offset = "0x5F9F4C0", VA = "0x185FA08C0")]
	public static global::OKNKCKFKLEA<CJFIGKJMGNA> GADFBDMBHED(int MALCAMOILKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x25436F0", Offset = "0x25422F0", VA = "0x1825436F0")]
	public static global::OKNKCKFKLEA<T> GADFBDMBHED<T>(in T IOIMHDKAIHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1F70", Offset = "0x2CB0B70", VA = "0x182CB1F70")]
	public static global::OKNKCKFKLEA<T> GADFBDMBHED<T>(in T IOIMHDKAIHO, int MALCAMOILKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class PMGJDHMIOHC<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate Task<TResult> FGPBLJDMBLG(TRequest PJCBPMCBLEN, CancellationToken OKPCBPJCBCJ);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum IOMGFJOPADL
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class NIHCPHOAFPA
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float DGGFGEFIEPF = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan PKBGJFAGBFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int BMNACFJILNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public IOMGFJOPADL FBPKCAOOJAP;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly NIHCPHOAFPA DJCOHFHFNJC;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float JDGEBKJJAKH
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x331F460", Offset = "0x331E060", VA = "0x18331F460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan CIEPIJNAGIM
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x331F690", Offset = "0x331E290", VA = "0x18331F690")]
		public NIHCPHOAFPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private readonly struct DGBKOFEHNCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest PJCBPMCBLEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken OKPCBPJCBCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> OAMBOBJCFBA;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2D907B0", Offset = "0x2D8F3B0", VA = "0x182D907B0")]
		public DGBKOFEHNCJ(TRequest PJCBPMCBLEN, TaskCompletionSource<TResult> OAMBOBJCFBA, CancellationToken OKPCBPJCBCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class LCFMJOCCKBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		public LCFMJOCCKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2628870", Offset = "0x2627470", VA = "0x182628870")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct BOFAGKLKFLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::PMGJDHMIOHC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2A6A130", Offset = "0x2A68D30", VA = "0x182A6A130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct IGMHNCGNPGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::PMGJDHMIOHC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private DGBKOFEHNCJ <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x31F5650", Offset = "0x31F4250", VA = "0x1831F5650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource LFHFHLEJEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<DGBKOFEHNCJ> LPIBPEDMOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly NIHCPHOAFPA HAMCILFDMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly FGPBLJDMBLG FPFCJKCJPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task EMMMGPJFLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int GPMIPOAIAEN;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2FF90A0", Offset = "0x2FF7CA0", VA = "0x182FF90A0")]
	public PMGJDHMIOHC(FGPBLJDMBLG FPFCJKCJPEL, [Optional] NIHCPHOAFPA HAMCILFDMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2FF8470", Offset = "0x2FF7070", VA = "0x182FF8470")]
	public Task<TResult> HAOIEHIGIFE(TRequest PJCBPMCBLEN, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2FF8750", Offset = "0x2FF7350", VA = "0x182FF8750")]
	private void HEDAHCHJKMB(DGBKOFEHNCJ JKPIEAFHIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2FF8A90", Offset = "0x2FF7690", VA = "0x182FF8A90")]
	[AsyncStateMachine(typeof(global::PMGJDHMIOHC<, >.BOFAGKLKFLP))]
	private Task OGPEPAECDLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2FF7600", Offset = "0x2FF6200", VA = "0x182FF7600")]
	private DGBKOFEHNCJ DFOMNHDCLOK()
	{
		return default(DGBKOFEHNCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2FF8DD0", Offset = "0x2FF79D0", VA = "0x182FF8DD0")]
	[AsyncStateMachine(typeof(global::PMGJDHMIOHC<, >.IGMHNCGNPGF))]
	private Task PIMAABKGNBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2FF7D00", Offset = "0x2FF6900", VA = "0x182FF7D00")]
	private void DPLIKJBDKOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2FF7F70", Offset = "0x2FF6B70", VA = "0x182FF7F70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class MNKFPDLBOLO<TKey, TVal> : global::OLGNIMBEJFK<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int PNCFCBPPFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> KGOBFEKHJNJ;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int NHBDHHCBFNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4161800", Offset = "0x4160400", VA = "0x184161800", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int KAANKGJBNOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4161C00", Offset = "0x4160800", VA = "0x184161C00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4161580", Offset = "0x4160180", VA = "0x184161580", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x4161C30", Offset = "0x4160830", VA = "0x184161C30")]
	public MNKFPDLBOLO(int KOHJKAOCDIM, [Optional] OGOOINICIPI OJJPNHOFJHN, [Optional] IEqualityComparer<TKey> HKMMJOLJECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x4161650", Offset = "0x4160250", VA = "0x184161650")]
	public void HGMCIEABDCO(TKey NANBEBOOGPM, TVal NENFOEKGNGK, bool JIADBIOOILF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x41618D0", Offset = "0x41604D0", VA = "0x1841618D0")]
	public bool MNIPDJKMCMB(TKey NANBEBOOGPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x4161B60", Offset = "0x4160760", VA = "0x184161B60", Slot = "6")]
	public override bool PDCGIMKGOOO(TKey FLBKNCEIEBJ, out TVal NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x4161950", Offset = "0x4160550", VA = "0x184161950")]
	public bool OPPONEFPBIE(TKey NANBEBOOGPM, TVal NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x41616F0", Offset = "0x41602F0", VA = "0x1841616F0")]
	public bool KANGLNHFDLO(TKey NANBEBOOGPM, TVal NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x41615E0", Offset = "0x41601E0", VA = "0x1841615E0", Slot = "7")]
	public override void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4161830", Offset = "0x4160430", VA = "0x184161830")]
	private bool MAGEJKJGGNJ(TKey NANBEBOOGPM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class OLGNIMBEJFK<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public delegate int OGOOINICIPI(TKey NANBEBOOGPM, TVal NENFOEKGNGK);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class CPNFNCDKCPP
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey OAGIAGFOKAP
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C90", Offset = "0x6D8890", VA = "0x1806D9C90")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal FGHAAIAMOAB
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x696D30", VA = "0x180698130")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x6BA2B0", Offset = "0x6B8EB0", VA = "0x1806BA2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int PAPHLGGFPJM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x6A4AD0", Offset = "0x6A36D0", VA = "0x1806A4AD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x6A4C30", Offset = "0x6A3830", VA = "0x1806A4C30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime NLIDFKPPJHE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x6B6560", Offset = "0x6B5160", VA = "0x1806B6560")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xC14CA0", Offset = "0xC138A0", VA = "0x180C14CA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x30F70D0", Offset = "0x30F5CD0", VA = "0x1830F70D0")]
		public CPNFNCDKCPP(TKey NANBEBOOGPM, TVal IAFIPJAFKOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int IMFHMDGPKJF = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<CPNFNCDKCPP>> COOMHJMGEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<CPNFNCDKCPP> IHMNEPDNKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly OGOOINICIPI OJJPNHOFJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan GFFGOJGCPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly KBNKLPHBOKC BPAIPHPCJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int FLPABJBBKDM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int IGIALMEDHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6B6550", Offset = "0x6B5150", VA = "0x1806B6550")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool GGGBANOOGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x461DB20", Offset = "0x461C720", VA = "0x18461DB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int NHBDHHCBFNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x69CC70", Offset = "0x69B870", VA = "0x18069CC70", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int GGKDNLHEHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2CF7A80", Offset = "0x2CF6680", VA = "0x182CF7A80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2705A40", Offset = "0x2704640", VA = "0x182705A40", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> ECDFCCCLKDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x461DBB0", Offset = "0x461C7B0", VA = "0x18461DBB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x461F040", Offset = "0x461DC40", VA = "0x18461F040")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3048110", Offset = "0x3046D10", VA = "0x183048110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x461F9F0", Offset = "0x461E5F0", VA = "0x18461F9F0")]
	public OLGNIMBEJFK(int KOHJKAOCDIM, [Optional] OGOOINICIPI OJJPNHOFJHN, [Optional] IEqualityComparer<TKey> HKMMJOLJECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x461F600", Offset = "0x461E200", VA = "0x18461F600")]
	public OLGNIMBEJFK(TimeSpan GFFGOJGCPEG, [Optional] IEqualityComparer<TKey> HKMMJOLJECO, [Optional] KBNKLPHBOKC BPAIPHPCJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x461F9A0", Offset = "0x461E5A0", VA = "0x18461F9A0")]
	public OLGNIMBEJFK(int KOHJKAOCDIM, TimeSpan GFFGOJGCPEG, [Optional] IEqualityComparer<TKey> HKMMJOLJECO, [Optional] KBNKLPHBOKC BPAIPHPCJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x461FAC0", Offset = "0x461E6C0", VA = "0x18461FAC0")]
	public OLGNIMBEJFK(int KOHJKAOCDIM, OGOOINICIPI OJJPNHOFJHN, TimeSpan GFFGOJGCPEG, [Optional] IEqualityComparer<TKey> HKMMJOLJECO, [Optional] KBNKLPHBOKC BPAIPHPCJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x461CA20", Offset = "0x461B620", VA = "0x18461CA20")]
	public void ENNCCEEBGCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x461C880", Offset = "0x461B480", VA = "0x18461C880")]
	public void CKBKODEFPCJ(TKey NANBEBOOGPM, TVal NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x461E460", Offset = "0x461D060", VA = "0x18461E460")]
	public bool KFPKFODPJHB(TKey NANBEBOOGPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x461CF20", Offset = "0x461BB20", VA = "0x18461CF20")]
	private TVal FABELHKIKFB(TKey FLBKNCEIEBJ)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x461F1D0", Offset = "0x461DDD0", VA = "0x18461F1D0", Slot = "6")]
	public virtual bool PDCGIMKGOOO(TKey FLBKNCEIEBJ, out TVal NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x461D1A0", Offset = "0x461BDA0", VA = "0x18461D1A0", Slot = "7")]
	public virtual void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x461C4C0", Offset = "0x461B0C0", VA = "0x18461C4C0")]
	private bool APJFMIJMGKP(CPNFNCDKCPP BHBBEEAOJJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x461D210", Offset = "0x461BE10", VA = "0x18461D210")]
	private void GOFCKCLCOLN(LinkedListNode<CPNFNCDKCPP> NAOPDCKHFLI, TVal KCIMCONOGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x461EA70", Offset = "0x461D670", VA = "0x18461EA70")]
	private void KMNMLABECCC(TKey NANBEBOOGPM, TVal NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x461E120", Offset = "0x461CD20", VA = "0x18461E120")]
	private void KBKMLJIMIEH(CPNFNCDKCPP BHBBEEAOJJN, TVal KCIMCONOGCA, int EBFPGEKJEJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
public class KPAOJFPIEMG<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> FOLHIKGIGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> ALFLMJJFKFL;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2628870", Offset = "0x2627470", VA = "0x182628870", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool AALAJCGHMIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8E0", Offset = "0x6AC4E0", VA = "0x1806AD8E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2A36600", Offset = "0x2A35200", VA = "0x182A36600", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x37CC460", Offset = "0x37CB060", VA = "0x1837CC460", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2F93240", Offset = "0x2F91E40", VA = "0x182F93240", Slot = "11")]
	public void Add(T ALHICNJOIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x37CBA80", Offset = "0x37CA680", VA = "0x1837CBA80")]
	public bool CLKFKCPMKCB(T ALHICNJOIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x37CC1B0", Offset = "0x37CADB0", VA = "0x1837CC1B0", Slot = "15")]
	public bool Remove(T ALHICNJOIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x37CBC60", Offset = "0x37CA860", VA = "0x1837CBC60", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2FC5380", Offset = "0x2FC3F80", VA = "0x182FC5380", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x37CBBD0", Offset = "0x37CA7D0", VA = "0x1837CBBD0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x31EF840", Offset = "0x31EE440", VA = "0x1831EF840", Slot = "13")]
	public bool Contains(T ALHICNJOIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x37CBC30", Offset = "0x37CA830", VA = "0x1837CBC30", Slot = "14")]
	public void CopyTo(T[] NMDKCEHJACP, int JBNOJAIGFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x33AC6A0", Offset = "0x33AB2A0", VA = "0x1833AC6A0", Slot = "6")]
	public int IndexOf(T ALHICNJOIJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x37CBDB0", Offset = "0x37CA9B0", VA = "0x1837CBDB0", Slot = "7")]
	public void Insert(int KLEGICPDLIF, T ALHICNJOIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x37CC0E0", Offset = "0x37CACE0", VA = "0x1837CC0E0", Slot = "8")]
	public void RemoveAt(int KLEGICPDLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x37CBE70", Offset = "0x37CAA70", VA = "0x1837CBE70")]
	public void KMFBNIHKEHL(Predicate<T> FGOJNBAPFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x37CBA50", Offset = "0x37CA650", VA = "0x1837CBA50")]
	public void BCBAAAOFGPO(Comparison<T> MFPMGHLLCGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x37CC2C0", Offset = "0x37CAEC0", VA = "0x1837CC2C0")]
	public KPAOJFPIEMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class LOCIACDBKDD
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0CB0", Offset = "0x5F9F8B0", VA = "0x185FA0CB0")]
	public static Vector3 EBEMLFHNCCA(this GameObject OKGHLJEDAEA, float HBGLOLIJHIM)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x9D3820", Offset = "0x9D2420", VA = "0x1809D3820")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5FA5270", Offset = "0x5FA3E70", VA = "0x185FA5270")]
		public SerializedGuid(in Guid PKLNDGIEPCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5FA5080", Offset = "0x5FA3C80", VA = "0x185FA5080")]
		public static SerializedGuid JMMOAMNGDHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5FA4FF0", Offset = "0x5FA3BF0", VA = "0x185FA4FF0")]
		public static SerializedGuid IMAAOMDCGII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5FA4DC0", Offset = "0x5FA39C0", VA = "0x185FA4DC0")]
		public bool DPHPNEKDHEK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5FA5240", Offset = "0x5FA3E40", VA = "0x185FA5240", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5FA51A0", Offset = "0x5FA3DA0", VA = "0x185FA51A0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5FA5110", Offset = "0x5FA3D10", VA = "0x185FA5110")]
		public bool MNDEPBAJPKN(in Guid PKLNDGIEPCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5FA4E50", Offset = "0x5FA3A50", VA = "0x185FA4E50", Slot = "7")]
		public bool Equals(SerializedGuid GHLMPEGFGCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5FA4F00", Offset = "0x5FA3B00", VA = "0x185FA4F00", Slot = "0")]
		public override bool Equals(object AOEMDAGAALP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5FA4FE0", Offset = "0x5FA3BE0", VA = "0x185FA4FE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5FA4D90", Offset = "0x5FA3990", VA = "0x185FA4D90", Slot = "6")]
		public int CompareTo(SerializedGuid GHLMPEGFGCH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class ODIPLEFEIIL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type CLOGIBMGIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string IGBKJEMFBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool MOAHDELGGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool DAJJLJPOMJK;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5FA36B0", Offset = "0x5FA22B0", VA = "0x185FA36B0")]
	public ODIPLEFEIIL(Type IEHJFAGHAKK, string GEBHGENFPCG, bool BNDOAJHGDKH = false, bool CGNJHKGFGMG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface EDCLBGFPMON
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface OINBHNCBIMH<T> : EDCLBGFPMON
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T FGHAAIAMOAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool MHKCFOJNCGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string LHJOMPLHKCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::OINBHNCBIMH<T> IAJCNAGPBEP(Action<T> LEFCHOFHJPA);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::OINBHNCBIMH<T> CJJHMDNKLGP(Action<T> LEFCHOFHJPA);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::OINBHNCBIMH<T> JEGHNOBEHJH(Action<T, T> BJICDHMGKDL);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::OINBHNCBIMH<T> DJBIFLGBCPE(Action<T, T> BJICDHMGKDL);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::OINBHNCBIMH<T> KEDHIOOCCMF(Action<string> GGMOKOPBGAG);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::OINBHNCBIMH<T> JNPCMOAMADB(Action<string> GGMOKOPBGAG);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class GMLIGJNNPNN<T> : global::OINBHNCBIMH<T>, EDCLBGFPMON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::PCKIOEFGILN<T, T> OGPMBDMBOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::PPCLKJMOJCH<T> KFCADJMKEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::PPCLKJMOJCH<string> KJDOFDBPDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string CHGFDAMICCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T HJIMPKKMPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool MBBCJEIBCKJ;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T FGHAAIAMOAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6B6560", Offset = "0x6B5160", VA = "0x1806B6560", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x2D975E0", Offset = "0x2D961E0", VA = "0x182D975E0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool MHKCFOJNCGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x698370", Offset = "0x696F70", VA = "0x180698370", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string LHJOMPLHKCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6982D0", Offset = "0x696ED0", VA = "0x1806982D0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2AD57F0", Offset = "0x2AD43F0", VA = "0x182AD57F0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x33B5190", Offset = "0x33B3D90", VA = "0x1833B5190")]
	private void IALGHGAGPAB(T ADEMJHPFLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x33B5390", Offset = "0x33B3F90", VA = "0x1833B5390")]
	private void MOCBKNKCBJI(string DPNJMDFICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x33B5440", Offset = "0x33B4040", VA = "0x1833B5440")]
	public void PACBOHNGOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x33B5230", Offset = "0x33B3E30", VA = "0x1833B5230", Slot = "6")]
	public global::OINBHNCBIMH<T> JEGHNOBEHJH(Action<T, T> BJICDHMGKDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x33B50B0", Offset = "0x33B3CB0", VA = "0x1833B50B0", Slot = "7")]
	public global::OINBHNCBIMH<T> DJBIFLGBCPE(Action<T, T> BJICDHMGKDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x33B5100", Offset = "0x33B3D00", VA = "0x1833B5100", Slot = "4")]
	public global::OINBHNCBIMH<T> IAJCNAGPBEP(Action<T> BJICDHMGKDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x33B5060", Offset = "0x33B3C60", VA = "0x1833B5060", Slot = "5")]
	public global::OINBHNCBIMH<T> CJJHMDNKLGP(Action<T> LEFCHOFHJPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x33B52F0", Offset = "0x33B3EF0", VA = "0x1833B52F0", Slot = "8")]
	public global::OINBHNCBIMH<T> KEDHIOOCCMF(Action<string> GGMOKOPBGAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x33B5280", Offset = "0x33B3E80", VA = "0x1833B5280", Slot = "9")]
	public global::OINBHNCBIMH<T> JNPCMOAMADB(Action<string> GGMOKOPBGAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x33B54F0", Offset = "0x33B40F0", VA = "0x1833B54F0")]
	public GMLIGJNNPNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class DLBAEAPOIPL
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class ICKFPAGKMGK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::OINBHNCBIMH<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::NMCHCEAGLKO<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		public ICKFPAGKMGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2BEE480", Offset = "0x2BED080", VA = "0x182BEE480")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2C935D0", Offset = "0x2C921D0", VA = "0x182C935D0")]
	public static global::GANDAICPPHN<T> LGHOHGDAHCA<T>(this global::OINBHNCBIMH<T> ALANIJHODDB, Action<T> JGLIBPMCCNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class EOHJIFBBDNE<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public readonly struct LCANGBKGJKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long PGHNOFMKLFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long CKIALCAOOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int POBEPBDPECM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int DCKELNGNMAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool LIKLJDEJIPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string EELLMKKFNIC;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2C38120", Offset = "0x2C36D20", VA = "0x182C38120")]
		public LCANGBKGJKD(long PGHNOFMKLFB, int POBEPBDPECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x2C38190", Offset = "0x2C36D90", VA = "0x182C38190")]
		public LCANGBKGJKD(long PGHNOFMKLFB, long CKIALCAOOAB, int POBEPBDPECM, int DCKELNGNMAA, bool LIKLJDEJIPJ, string EELLMKKFNIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2C38040", Offset = "0x2C36C40", VA = "0x182C38040")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void NFBIJKEHCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2C37F40", Offset = "0x2C36B40", VA = "0x182C37F40")]
		public int JPLBPBOAOLG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2C38020", Offset = "0x2C36C20", VA = "0x182C38020")]
		public int LDKJEEPPJEL(int EELMBKDLJAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2C380B0", Offset = "0x2C36CB0", VA = "0x182C380B0")]
		public double NHJAAFABJHK()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2C37F90", Offset = "0x2C36B90", VA = "0x182C37F90")]
		public LCANGBKGJKD LALFLIJDPIF(long CKIALCAOOAB, int DCKELNGNMAA)
		{
			return default(LCANGBKGJKD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class IFANLHMJJPA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey OAGIAGFOKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::EOHJIFBBDNE<TKey> KIACJFINHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<IFANLHMJJPA> ACPFEHMALGB;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string POMFOFJBHEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x2DA08D0", Offset = "0x2D9F4D0", VA = "0x182DA08D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x2F02FD0", Offset = "0x2F01BD0", VA = "0x182F02FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<IFANLHMJJPA> NJFILFAEPLM
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x2F033A0", Offset = "0x2F01FA0", VA = "0x182F033A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public LCANGBKGJKD PHFOGFGLEDI
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xA7FE20", Offset = "0xA7EA20", VA = "0x180A7FE20")]
			[CompilerGenerated]
			get
			{
				return default(LCANGBKGJKD);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x2F033C0", Offset = "0x2F01FC0", VA = "0x182F033C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x2F033F0", Offset = "0x2F01FF0", VA = "0x182F033F0")]
		internal IFANLHMJJPA(global::EOHJIFBBDNE<TKey> KIACJFINHDJ, TKey NANBEBOOGPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2F03290", Offset = "0x2F01E90", VA = "0x182F03290")]
		public IFANLHMJJPA FIKEILNCIPJ(TKey NANBEBOOGPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2F03000", Offset = "0x2F01C00", VA = "0x182F03000")]
		public void DDCDALPPDEE(TKey NANBEBOOGPM, Action<IFANLHMJJPA> MNJNLIAKBME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2A48340", Offset = "0x2A46F40", VA = "0x182A48340")]
		public T DDCDALPPDEE<T>(TKey NANBEBOOGPM, Func<IFANLHMJJPA, T> LHPENGCHIMB)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2A48430", Offset = "0x2A47030", VA = "0x182A48430")]
		[AsyncStateMachine(typeof(MJPGEOHBEJJ))]
		public Task<T> MIALHIMKJOA<T>(TKey NANBEBOOGPM, Func<IFANLHMJJPA, Task<T>> LHPENGCHIMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2F030E0", Offset = "0x2F01CE0", VA = "0x182F030E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class IDEDPMFJHPE : IEnumerable<(TKey, List<TKey>, LCANGBKGJKD)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LCANGBKGJKD)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, LCANGBKGJKD timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::EOHJIFBBDNE<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, LCANGBKGJKD timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, LCANGBKGJKD) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2BF4940", Offset = "0x2BF3540", VA = "0x182BF4940", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LCANGBKGJKD));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2BF49B0", Offset = "0x2BF35B0", VA = "0x182BF49B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x2BF4A60", Offset = "0x2BF3660", VA = "0x182BF4A60")]
		[DebuggerHidden]
		public IDEDPMFJHPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2BE6810", Offset = "0x2BE5410", VA = "0x182BE6810", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2BF45D0", Offset = "0x2BF31D0", VA = "0x182BF45D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2BF4A10", Offset = "0x2BF3610", VA = "0x182BF4A10")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2BF4970", Offset = "0x2BF3570", VA = "0x182BF4970", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x2BF4880", Offset = "0x2BF3480", VA = "0x182BF4880", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LCANGBKGJKD)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x26FE980", Offset = "0x26FD580", VA = "0x1826FE980", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class GAPFKCKIHDE : IEnumerable<(TKey, List<TKey>, LCANGBKGJKD)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LCANGBKGJKD)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, LCANGBKGJKD timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private IFANLHMJJPA timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public IFANLHMJJPA <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::EOHJIFBBDNE<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<IFANLHMJJPA> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, LCANGBKGJKD timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, LCANGBKGJKD) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x2BF4940", Offset = "0x2BF3540", VA = "0x182BF4940", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LCANGBKGJKD));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x39398B0", Offset = "0x39384B0", VA = "0x1839398B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2BF4A60", Offset = "0x2BF3660", VA = "0x182BF4A60")]
		[DebuggerHidden]
		public GAPFKCKIHDE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3939910", Offset = "0x3938510", VA = "0x183939910", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x39391C0", Offset = "0x3937DC0", VA = "0x1839391C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x39399B0", Offset = "0x39385B0", VA = "0x1839399B0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3939A10", Offset = "0x3938610", VA = "0x183939A10")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3939870", Offset = "0x3938470", VA = "0x183939870", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3939760", Offset = "0x3938360", VA = "0x183939760", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LCANGBKGJKD)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3939840", Offset = "0x3938440", VA = "0x183939840", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, LCANGBKGJKD> MLBILOLLLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, LCANGBKGJKD> LMECKIOOMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::EOHJIFBBDNE<TKey>> OLFBNDONEEN;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string AFOIDMBOFCO = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly IFANLHMJJPA LMCDGPHIGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool LNPINMMGACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int KPCAIIFIKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch BHBHJNHOJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int HBOBGLJLLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string OKOENAKPNNH;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public IFANLHMJJPA AEJPOHEGLBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6982D0", Offset = "0x696ED0", VA = "0x1806982D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string POMFOFJBHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x69B9C0", Offset = "0x69A5C0", VA = "0x18069B9C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x23A5370", Offset = "0x23A3F70", VA = "0x1823A5370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long CFAHOLNJGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x23A5630", Offset = "0x23A4230", VA = "0x1823A5630")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int MAEFIGPMPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x23A5600", Offset = "0x23A4200", VA = "0x1823A5600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x23A56D0", Offset = "0x23A42D0", VA = "0x1823A56D0")]
	public EOHJIFBBDNE(TKey APKPECGENEB, [Optional] int? POBEPBDPECM, [Optional][CanBeNull] Stopwatch BHBHJNHOJNC, [Optional] Action<TKey, LCANGBKGJKD> MLBILOLLLIK, [Optional] Action<TKey, LCANGBKGJKD> LMECKIOOMLM, [Optional] Action<global::EOHJIFBBDNE<TKey>> OLFBNDONEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x23A53D0", Offset = "0x23A3FD0", VA = "0x1823A53D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x23A5460", Offset = "0x23A4060", VA = "0x1823A5460")]
	public void FLNABJMEOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x23A5480", Offset = "0x23A4080", VA = "0x1823A5480")]
	public void FNLACLDIHPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x23A5570", Offset = "0x23A4170", VA = "0x1823A5570")]
	[IteratorStateMachine(typeof(global::EOHJIFBBDNE<>.IDEDPMFJHPE))]
	public IEnumerable<(TKey, List<TKey>, LCANGBKGJKD)> LEJEBIHIEHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x23A54A0", Offset = "0x23A40A0", VA = "0x1823A54A0")]
	[IteratorStateMachine(typeof(global::EOHJIFBBDNE<>.GAPFKCKIHDE))]
	private IEnumerable<(TKey, List<TKey>, LCANGBKGJKD)> LEJEBIHIEHE(List<TKey> HKLHFKDNFJF, IFANLHMJJPA MINDFCIGDDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x23A5650", Offset = "0x23A4250", VA = "0x1823A5650")]
	private (long, int) MNCOFONKOMN()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class NFKICGJDLJB<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut OBNLCIMFHDK(global::EOHJIFBBDNE<TKey> KIACJFINHDJ);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
	protected NFKICGJDLJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class GHCIHGGMKKM<TKey> : global::NFKICGJDLJB<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate string KCNIEGPAJOF(TKey NANBEBOOGPM);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x33A9020", Offset = "0x33A7C20", VA = "0x1833A9020")]
	protected string ACCJPFLOPHP(double AHNBCOIANDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x33A90D0", Offset = "0x33A7CD0", VA = "0x1833A90D0")]
	protected string JAKCNNKGMLG(int KALPJADNKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x33A9090", Offset = "0x33A7C90", VA = "0x1833A9090")]
	private static string AFLJOIJBMKM(TKey NANBEBOOGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x33A9260", Offset = "0x33A7E60", VA = "0x1833A9260", Slot = "4")]
	public override string OBNLCIMFHDK(global::EOHJIFBBDNE<TKey> KIACJFINHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x33A9130", Offset = "0x33A7D30", VA = "0x1833A9130")]
	public string OBNLCIMFHDK(global::EOHJIFBBDNE<TKey> KIACJFINHDJ, [NotNull] KCNIEGPAJOF MDIHHNLOGEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string DBKBCBJNCDM(global::EOHJIFBBDNE<TKey> KIACJFINHDJ, [NotNull] KCNIEGPAJOF MDIHHNLOGEB);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x2A71EC0", Offset = "0x2A70AC0", VA = "0x182A71EC0")]
	protected GHCIHGGMKKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class NLBMPAEMIAP<TKey> : global::NFKICGJDLJB<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate string NGNPDOGPELA(TKey NANBEBOOGPM);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int PHKNGJNDCBE = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string KGPOBNANDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double FGEANKOBBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool CBELACAJMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int BEEOOPNNKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> HIBIFKIFJMP;

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x332A170", Offset = "0x3328D70", VA = "0x18332A170")]
	private static string AFLJOIJBMKM(TKey NANBEBOOGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x332ABB0", Offset = "0x33297B0", VA = "0x18332ABB0")]
	public NLBMPAEMIAP(string KGPOBNANDIB = "F2", double FGEANKOBBHJ = double.MaxValue, bool CBELACAJMHA = false, int BEEOOPNNKJD = int.MaxValue, [Optional] ISet<string> HIBIFKIFJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x332A5C0", Offset = "0x33291C0", VA = "0x18332A5C0", Slot = "4")]
	public override Dictionary<string, string> OBNLCIMFHDK(global::EOHJIFBBDNE<TKey> KIACJFINHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x332A4E0", Offset = "0x33290E0", VA = "0x18332A4E0")]
	private bool LIMMGIPJPKE(string LEHOAMEBLEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x332A670", Offset = "0x3329270", VA = "0x18332A670")]
	public Dictionary<string, string> OBNLCIMFHDK(global::EOHJIFBBDNE<TKey> KIACJFINHDJ, NGNPDOGPELA MDIHHNLOGEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x332A1B0", Offset = "0x3328DB0", VA = "0x18332A1B0")]
	private string GNPDFEAOKOD(StringBuilder HFFLEFBIHPB, List<TKey> BPBONDEDKCA, NGNPDOGPELA MDIHHNLOGEB, bool DMGJMEKOAFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x332A360", Offset = "0x3328F60", VA = "0x18332A360")]
	private static void KHMCLFOEFOJ(StringBuilder DDJKGOCNEJP, string JHGFNNNCGBH, bool OCOLGEPKBAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class KKPIPMLKHPN<TKey> : global::GHCIHGGMKKM<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct BOEAOPBNHNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public KCNIEGPAJOF keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::KKPIPMLKHPN<TKey> OHEGMANNBEJ;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int BJNMNPJOFFL = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] HJOKICBKKPI;

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x37C5B00", Offset = "0x37C4700", VA = "0x1837C5B00")]
	private KKPIPMLKHPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x37C4A20", Offset = "0x37C3620", VA = "0x1837C4A20", Slot = "5")]
	protected override string DBKBCBJNCDM(global::EOHJIFBBDNE<TKey> KIACJFINHDJ, KCNIEGPAJOF MDIHHNLOGEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x37C5910", Offset = "0x37C4510", VA = "0x1837C5910")]
	[CompilerGenerated]
	internal static string OOCILNCDIHO(string NLBJNLNCONH, TKey NANBEBOOGPM, ref BOEAOPBNHNP P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class DOMAHEMBGNC<TKey> : global::GHCIHGGMKKM<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class FBNKNFNAOKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public KCNIEGPAJOF keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		public FBNKNFNAOKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2A571B0", Offset = "0x2A55DB0", VA = "0x182A571B0")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE990", Offset = "0x2FCD590", VA = "0x182FCE990", Slot = "5")]
	protected override string DBKBCBJNCDM(global::EOHJIFBBDNE<TKey> KIACJFINHDJ, KCNIEGPAJOF MDIHHNLOGEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2FCF280", Offset = "0x2FCDE80", VA = "0x182FCF280")]
	public DOMAHEMBGNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public sealed class CJOGPBLNOHO : global::EOHJIFBBDNE<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class IFADPKNCGEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<CJOGPBLNOHO> callback;

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public IFADPKNCGEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F510", Offset = "0x5F9E110", VA = "0x185F9F510")]
		internal void <Wrap>b__0(global::EOHJIFBBDNE<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5F9CA60", Offset = "0x5F9B660", VA = "0x185F9CA60")]
	public CJOGPBLNOHO([Optional] string FOAHDNEHBIO, [Optional] int? POBEPBDPECM, [Optional] Stopwatch BHBHJNHOJNC, [Optional] Action<string, LCANGBKGJKD> MLBILOLLLIK, [Optional] Action<string, LCANGBKGJKD> LMECKIOOMLM, [Optional] Action<CJOGPBLNOHO> OLFBNDONEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5F9C980", Offset = "0x5F9B580", VA = "0x185F9C980")]
	private static Action<global::EOHJIFBBDNE<string>> DDCDALPPDEE(Action<CJOGPBLNOHO> JGLIBPMCCNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class KBNKLPHBOKC
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class GPFGPCBLMPK : KBNKLPHBOKC
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static KBNKLPHBOKC OHEGMANNBEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DC70", VA = "0x185F9F070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime GAFCIMAOBNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x5F9F0D0", Offset = "0x5F9DCD0", VA = "0x185F9F0D0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float EDHPFDNJIFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x5F9F120", Offset = "0x5F9DD20", VA = "0x185F9F120", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F1D0", Offset = "0x5F9DDD0", VA = "0x185F9F1D0")]
		public GPFGPCBLMPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static KBNKLPHBOKC IJLILBLMONI;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static KBNKLPHBOKC DJCOHFHFNJC
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5FA06E0", Offset = "0x5F9F2E0", VA = "0x185FA06E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime GAFCIMAOBNM
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float EDHPFDNJIFI
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	protected KBNKLPHBOKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class MEANBHELEOI : global::MHFOJGPIMMD<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0F80", Offset = "0x5F9FB80", VA = "0x185FA0F80")]
	public MEANBHELEOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class MHFOJGPIMMD<T> : global::IKLFCLDFOJM<T>, IFAGHOIFMDN, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> PGMICCNICHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task PMLKLDGFEJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x1C29DE0", Offset = "0x1C289E0", VA = "0x181C29DE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::GANDAICPPHN<T> JNDHHABHACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private CKHAEIDHOPE INJFOPIBMLE
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2AD57C0", Offset = "0x2AD43C0", VA = "0x182AD57C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x39C08D0", Offset = "0x39BF4D0", VA = "0x1839C08D0")]
	public MHFOJGPIMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class KPDMCNPNPKH : global::GFKPGACCIAB<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0AA0", Offset = "0x5F9F6A0", VA = "0x185FA0AA0")]
	public KPDMCNPNPKH(Exception MPIBPKBJNBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class GFKPGACCIAB<T> : global::IKLFCLDFOJM<T>, IFAGHOIFMDN, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> PGMICCNICHL
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task PMLKLDGFEJC
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1C29DE0", Offset = "0x1C289E0", VA = "0x181C29DE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::GANDAICPPHN<T> JNDHHABHACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private CKHAEIDHOPE INJFOPIBMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2AD57C0", Offset = "0x2AD43C0", VA = "0x182AD57C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x33A69F0", Offset = "0x33A55F0", VA = "0x1833A69F0")]
	public GFKPGACCIAB(Exception MPIBPKBJNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface IFAGHOIFMDN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task PGMICCNICHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	CKHAEIDHOPE JNDHHABHACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface IKLFCLDFOJM<T> : IFAGHOIFMDN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> PGMICCNICHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::GANDAICPPHN<T> JNDHHABHACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public abstract class EOCCCCKNDHA<TTask, T> : global::IKLFCLDFOJM<T>, IFAGHOIFMDN, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class ILPAMFLOAHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public global::EOCCCCKNDHA<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		public ILPAMFLOAHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool DOGBCMPNMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> DJBOLOFCCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource NAMBCJPDCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool LNPINMMGACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private SynchronizationContext CFJCOJJEPPI;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> PGMICCNICHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task PMLKLDGFEJC
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::GANDAICPPHN<T> JNDHHABHACB
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private CKHAEIDHOPE INJFOPIBMLE
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x238AD50", Offset = "0x2389950", VA = "0x18238AD50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool EHAKBDFLKEP
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7C4280", Offset = "0x7C2E80", VA = "0x1807C4280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x23A4CF0", Offset = "0x23A38F0", VA = "0x1823A4CF0")]
	static EOCCCCKNDHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x23A4FD0", Offset = "0x23A3BD0", VA = "0x1823A4FD0")]
	protected EOCCCCKNDHA(TTask DJBOLOFCCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x23A4C30", Offset = "0x23A3830", VA = "0x1823A4C30", Slot = "1")]
	~EOCCCCKNDHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x23A4920", Offset = "0x23A3520", VA = "0x1823A4920", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x23A4AC0", Offset = "0x23A36C0", VA = "0x1823A4AC0")]
	private void EKCDHDCHCGJ(bool NJOMLJBAHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T GAEEFBEHELA(TTask KPDNPPCEPLP);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void HDNBKBFMKDO();

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x23A4CA0", Offset = "0x23A38A0", VA = "0x1823A4CA0")]
	[CompilerGenerated]
	private void GBCDCKKEOBB(object IHJLHGLAGGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface AACCMMBHPBL
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float CNCPBENEOFE
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event AIGLFAGDEND HOPFJDHFPEL;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class MOBDJEKJCIH : AACCMMBHPBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public readonly struct FGAPGGAANGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float NEICDGFOHHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public readonly float OBHKBCJHNDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		internal readonly bool BPOKJGMAKGF;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float PAPHLGGFPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x5F9DCC0", Offset = "0x5F9C8C0", VA = "0x185F9DCC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x5F9DE50", Offset = "0x5F9CA50", VA = "0x185F9DE50")]
		public FGAPGGAANGF(float IOMMLLJBIGB, float IEPBHGAJDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x5F9DCD0", Offset = "0x5F9C8D0", VA = "0x185F9DCD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class CCMFGGFFKHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public MOBDJEKJCIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public CCMFGGFFKHH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly int KOHJKAOCDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private int ECIKFCBGJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly AACCMMBHPBL[] CLEDLAAECDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly AIGLFAGDEND[] OPBBALMJDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly FGAPGGAANGF[] DIAJAMFFKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private FGAPGGAANGF NPBIKBCDJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly HJJEFEBIANJ IJIGFFLNGPC;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public FGAPGGAANGF DOCAIDNNGPG
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xED7910", Offset = "0xED6510", VA = "0x180ED7910")]
		get
		{
			return default(FGAPGGAANGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float CNCPBENEOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5FA27E0", Offset = "0x5FA13E0", VA = "0x185FA27E0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event AIGLFAGDEND HOPFJDHFPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5FA2720", Offset = "0x5FA1320", VA = "0x185FA2720", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5FA2F10", Offset = "0x5FA1B10", VA = "0x185FA2F10", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2FD0", Offset = "0x5FA1BD0", VA = "0x185FA2FD0")]
	public MOBDJEKJCIH(int KOHJKAOCDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2E80", Offset = "0x5FA1A80", VA = "0x185FA2E80")]
	public HJJEFEBIANJ KDADFIBFPKO(FGAPGGAANGF KDPIBNOPKDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2990", Offset = "0x5FA1590", VA = "0x185FA2990")]
	public void EENAJFGAGHC(AACCMMBHPBL PPIFJIMEEEJ, [Optional] FGAPGGAANGF JIMBFHCJBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2E30", Offset = "0x5FA1A30", VA = "0x185FA2E30")]
	internal int GOBCNAPLMBL(AACCMMBHPBL OPMAJDAEOJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2DE0", Offset = "0x5FA19E0", VA = "0x185FA2DE0")]
	internal FGAPGGAANGF GLAPGHLEKMF(int KLEGICPDLIF)
	{
		return default(FGAPGGAANGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2800", Offset = "0x5FA1400", VA = "0x185FA2800", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public delegate void AIGLFAGDEND(float ALNDCKIFDLN);
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal static class GCNNFKMKDEN
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	internal const float JDHFMPKCKOK = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class ELHFOFPBIAN
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private class HDAJPKFODGD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly AACCMMBHPBL OPMAJDAEOJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly AIGLFAGDEND JGLIBPMCCNL;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F280", Offset = "0x5F9DE80", VA = "0x185F9F280")]
		public HDAJPKFODGD(AACCMMBHPBL OPMAJDAEOJH, AIGLFAGDEND JGLIBPMCCNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F230", Offset = "0x5F9DE30", VA = "0x185F9F230", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5F9DB80", Offset = "0x5F9C780", VA = "0x185F9DB80")]
	internal static bool LAJLLCMJPOA(float APGJBFJMIBK, float APLKEMLCGID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x4C1ED90", Offset = "0x4C1D990", VA = "0x184C1ED90")]
	internal static float CPFGAIHAHLB(float APGJBFJMIBK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5F9DC00", Offset = "0x5F9C800", VA = "0x185F9DC00")]
	public static IDisposable PCLBHEMMMCF(this AACCMMBHPBL OPMAJDAEOJH, AIGLFAGDEND JGLIBPMCCNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class HJJEFEBIANJ : AACCMMBHPBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float ALNDCKIFDLN;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float CNCPBENEOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x82E840", Offset = "0x82D440", VA = "0x18082E840", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F450", Offset = "0x5F9E050", VA = "0x185F9F450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event AIGLFAGDEND HOPFJDHFPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9DF10", VA = "0x185F9F310", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F3B0", Offset = "0x5F9DFB0", VA = "0x185F9F3B0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public HJJEFEBIANJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class IIDOMLEAIMC
{
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5F9F980", Offset = "0x5F9E580", VA = "0x185F9F980")]
	[NotNull]
	public static byte[] BNGOMOKBOOG(this IMCNOLHKLGP NJFJNKPLNDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5F9F9F0", Offset = "0x5F9E5F0", VA = "0x185F9F9F0")]
	[NotNull]
	public static byte[] BNGOMOKBOOG(this IMCNOLHKLGP NJFJNKPLNDE, HashAlgorithmName BCOCIGMLPMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5F9F650", Offset = "0x5F9E250", VA = "0x185F9F650")]
	public static bool BHDOGDNNPAM([CanBeNull] this IMCNOLHKLGP NJFJNKPLNDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5F9F7E0", Offset = "0x5F9E3E0", VA = "0x185F9F7E0")]
	public static bool BHDOGDNNPAM([CanBeNull] this IMCNOLHKLGP NJFJNKPLNDE, out string CHGFDAMICCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5F9FB80", Offset = "0x5F9E780", VA = "0x185F9FB80")]
	private static string EEKDBBGHGBO([CanBeNull] byte[] FCLGIGIIKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5F9FA60", Offset = "0x5F9E660", VA = "0x185F9FA60")]
	private static bool CCCBPECKGEP([NotNull] IMCNOLHKLGP NJFJNKPLNDE, [CanBeNull] out byte[] JKNNCBIFLJA, [CanBeNull] out byte[] GJEOGLKLNFM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class BCPBJKOCHNM
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5F9C680", Offset = "0x5F9B280", VA = "0x185F9C680")]
	[NotNull]
	public static byte[] BNGOMOKBOOG(this JHMBKELLFAK ACLIJMGFLIL, byte[] OAHMIMHKCHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5F9C6C0", Offset = "0x5F9B2C0", VA = "0x185F9C6C0")]
	[NotNull]
	public static byte[] BNGOMOKBOOG(this JHMBKELLFAK ACLIJMGFLIL, HashAlgorithmName BCOCIGMLPMP, byte[] OAHMIMHKCHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface JHMBKELLFAK
{
	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash FHKABFEFMDN);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface IMCNOLHKLGP : JHMBKELLFAK
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] IIIKBKHCHOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	[CanBeNull]
	byte[] LOFAABINHKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object PPLAKBJPDAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class MLKKHJFNIFD
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private class NFECFBBGICE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x5FA31B0", Offset = "0x5FA1DB0", VA = "0x185FA31B0")]
		public NFECFBBGICE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5FA3150", Offset = "0x5FA1D50", VA = "0x185FA3150", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte HANPMDJDEBM = 1;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private const byte EICMDEKGHKB = 0;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly ArrayPool<byte> OCJHPEELCBB;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static bool CNFKLEPOAPM;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x31007A0", Offset = "0x30FF3A0", VA = "0x1831007A0")]
	[Conditional("UNITY_EDITOR")]
	private static void MDFHNMGDCHB<T>(params T[] JLIDMMKOHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1F00", Offset = "0x5FA0B00", VA = "0x185FA1F00")]
	public static IDisposable ONAFCEBBPAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1A80", Offset = "0x5FA0680", VA = "0x185FA1A80")]
	public static void MACKKHCIPHA(this IncrementalHash AFBNOHGHIPA, [CanBeNull] GameObject OKGHLJEDAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x31006D0", Offset = "0x30FF2D0", VA = "0x1831006D0")]
	public static void MACKKHCIPHA<T>(this IncrementalHash AFBNOHGHIPA, [CanBeNull] T CNBPNBOALAL) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x3100640", Offset = "0x30FF240", VA = "0x183100640")]
	public static void HMKNPHBAMME<T>(this IncrementalHash AFBNOHGHIPA, [CanBeNull] T ACLIJMGFLIL) where T : JHMBKELLFAK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x31001E0", Offset = "0x30FEDE0", VA = "0x1831001E0")]
	public static void FDDAFMEBIGG<T>(this IncrementalHash AFBNOHGHIPA, [CanBeNull] IList<T> LOPMHDKIACK) where T : JHMBKELLFAK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1220", Offset = "0x5F9FE20", VA = "0x185FA1220")]
	private static bool AGJDANLONEB([CanBeNull] JHMBKELLFAK ACLIJMGFLIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1540", Offset = "0x5FA0140", VA = "0x185FA1540")]
	public static void EEJCAJHOGCM(this IncrementalHash FHKABFEFMDN, [CanBeNull] string MGAPJIAMDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1310", Offset = "0x5F9FF10", VA = "0x185FA1310")]
	public static void BKICLKHNKAB(this IncrementalHash FHKABFEFMDN, long EKMHHKCNKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5FA18B0", Offset = "0x5FA04B0", VA = "0x185FA18B0")]
	public static void LEACJLNBIAF(this IncrementalHash FHKABFEFMDN, int KOMLALMBMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5FA15A0", Offset = "0x5FA01A0", VA = "0x185FA15A0")]
	public static void ENBKKCLKEDA(this IncrementalHash FHKABFEFMDN, short LCHKBEFBDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5FA10B0", Offset = "0x5F9FCB0", VA = "0x185FA10B0")]
	public static void ABBPLKFGIAH(this IncrementalHash FHKABFEFMDN, byte MJBEBDCOANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1B70", Offset = "0x5FA0770", VA = "0x185FA1B70")]
	public static void MOHDBDDEILK(this IncrementalHash FHKABFEFMDN, bool AMMADPIEJBK, bool FNEPCNCJGIJ = false, bool OIJJKOJOLIN = false, bool DENDCGGALIF = false, bool ILBBGAGJBAG = false, bool EGFJFFLCEGM = false, bool DGMBGJLDAFC = false, bool PMFLLJBHOHI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x3100A90", Offset = "0x30FF690", VA = "0x183100A90")]
	public static void PBEEFAMIALG<T>(this IncrementalHash FHKABFEFMDN, T IBKBCIIEFMD) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5FA14E0", Offset = "0x5FA00E0", VA = "0x185FA14E0")]
	public static void ECKNMIABANJ(this IncrementalHash FHKABFEFMDN, float LIPAHCAHDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5FA12B0", Offset = "0x5F9FEB0", VA = "0x185FA12B0")]
	public static void APNCANPGDHD(this IncrementalHash FHKABFEFMDN, double NPCAGBEAFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5FA17D0", Offset = "0x5FA03D0", VA = "0x185FA17D0")]
	public static void IBOBNKPJKOL(this IncrementalHash FHKABFEFMDN, ulong PDHPOBBDDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1770", Offset = "0x5FA0370", VA = "0x185FA1770")]
	public static void HEOJMKOPFHA(this IncrementalHash FHKABFEFMDN, uint ELKOFOADFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1840", Offset = "0x5FA0440", VA = "0x185FA1840")]
	public static void IJLEGIAKOLL(this IncrementalHash FHKABFEFMDN, ushort FMLJIMEEJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1FA0", Offset = "0x5FA0BA0", VA = "0x185FA1FA0")]
	public static void POILALDGADH(this IncrementalHash FHKABFEFMDN, Vector3 CCBIJBBPLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1D40", Offset = "0x5FA0940", VA = "0x185FA1D40")]
	public static void OEIFMNAMGKG(this IncrementalHash FHKABFEFMDN, Quaternion HBGDGGOEIAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class DIHBIHPILAE : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly Type CLOGIBMGIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly string IGBKJEMFBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly bool MOAHDELGGMO;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D800", Offset = "0x5F9C400", VA = "0x185F9D800")]
	public DIHBIHPILAE(Type IEHJFAGHAKK, string GEBHGENFPCG, bool BNDOAJHGDKH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class ABFIBHNLGOL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5F9BED0", Offset = "0x5F9AAD0", VA = "0x185F9BED0")]
	public ABFIBHNLGOL(string DPNJMDFICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5F9BE50", Offset = "0x5F9AA50", VA = "0x185F9BE50")]
	public ABFIBHNLGOL(string DPNJMDFICMK, Exception CENDNNNNIKC)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x678060", Offset = "0x676C60", VA = "0x180678060")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x7072A0", Offset = "0x705EA0", VA = "0x1807072A0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int NFLKAEEEFMF, int PLBCNNNFJCO]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x3D679C0", Offset = "0x3D665C0", VA = "0x183D679C0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x3D67A60", Offset = "0x3D66660", VA = "0x183D67A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x3D67930", Offset = "0x3D66530", VA = "0x183D67930")]
		public Array2D(uint EFDIFNHGBMG, uint KEJDIAAOACK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x3D678B0", Offset = "0x3D664B0", VA = "0x183D678B0")]
		public void GGNFLDPHLOD()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5F9C620", Offset = "0x5F9B220", VA = "0x185F9C620")]
		public Array2DVector3(uint EFDIFNHGBMG, uint KEJDIAAOACK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal static class HFHFEGLICKG
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public const int NAPBAIMDJNP = -1;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public const int HOPLBHCDLMB = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[DefaultMember("Item")]
public class DJBGJNBMNEB<THandle, TValue> : IDisposable where THandle : struct, IIENHJEKFBL where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly List<THandle> MIICOLKKHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly List<TValue> BHBEDDCMEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly Func<TValue> OGPHOAHCBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly Action<TValue> JBKDGDBODOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int LKHFKCJNIMH;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x2FC41F0", Offset = "0x2FC2DF0", VA = "0x182FC41F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x2FC45B0", Offset = "0x2FC31B0", VA = "0x182FC45B0")]
	public DJBGJNBMNEB(Action<TValue> JBKDGDBODOH, [Optional] Func<TValue> OGPHOAHCBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3B30", Offset = "0x2FC2730", VA = "0x182FC3B30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4440", Offset = "0x2FC3040", VA = "0x182FC4440")]
	public THandle NBONEDNFGGC()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3A00", Offset = "0x2FC2600", VA = "0x182FC3A00")]
	public THandle AABPNGPFBPJ(TValue NENFOEKGNGK)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3F20", Offset = "0x2FC2B20", VA = "0x182FC3F20")]
	public bool KFPKFODPJHB(THandle LBLAJOOMAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3FE0", Offset = "0x2FC2BE0", VA = "0x182FC3FE0")]
	public bool LFFHDJLOGBM(THandle LBLAJOOMAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3E80", Offset = "0x2FC2A80", VA = "0x182FC3E80")]
	public bool JIJNIMCPPHN(THandle LBLAJOOMAIC, out TValue NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3BF0", Offset = "0x2FC27F0", VA = "0x182FC3BF0")]
	public TValue FABELHKIKFB(THandle LBLAJOOMAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4220", Offset = "0x2FC2E20", VA = "0x182FC4220")]
	public bool MKAKFEIOKNJ(THandle LBLAJOOMAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4580", Offset = "0x2FC3180", VA = "0x182FC4580")]
	private THandle PIJGKMDEOFH(int KLEGICPDLIF)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2FC41C0", Offset = "0x2FC2DC0", VA = "0x182FC41C0")]
	private TValue LGHOHGDAHCA(int KLEGICPDLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3BB0", Offset = "0x2FC27B0", VA = "0x182FC3BB0")]
	private void ECAAEMJJKPB(int KLEGICPDLIF, in THandle LBLAJOOMAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3DC0", Offset = "0x2FC29C0", VA = "0x182FC3DC0")]
	private void IALGHGAGPAB(int KLEGICPDLIF, in TValue NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2FC40B0", Offset = "0x2FC2CB0", VA = "0x182FC40B0")]
	private THandle LFGICMLPOIL()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3A70", Offset = "0x2FC2670", VA = "0x182FC3A70")]
	private void BHKILGLAJHJ(THandle LBLAJOOMAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3FD0", Offset = "0x2FC2BD0", VA = "0x182FC3FD0")]
	private int KGBFHPJIMKB(int OLOLCGEOMNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3B20", Offset = "0x2FC2720", VA = "0x182FC3B20")]
	private bool CCJIPPPKFJE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x813D30", Offset = "0x812930", VA = "0x180813D30")]
	private void OBNCNLLNDFG(THandle LBLAJOOMAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3E00", Offset = "0x2FC2A00", VA = "0x182FC3E00")]
	private bool IFGALHCHKBE(out THandle LBLAJOOMAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2FC42D0", Offset = "0x2FC2ED0", VA = "0x182FC42D0")]
	private bool MKONEFHCNEM(out THandle LBLAJOOMAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3D60", Offset = "0x2FC2960", VA = "0x182FC3D60")]
	private void HBOFCHBOFEO(THandle LBLAJOOMAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3C40", Offset = "0x2FC2840", VA = "0x182FC3C40")]
	private void FKMLDHEENEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface IIENHJEKFBL
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int KLCIKJBGNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int LKNCJMEJAON
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface AHIMPCNGIKJ<T> : IIENHJEKFBL, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class KMHPECCLGPA
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x131CC70", Offset = "0x131B870", VA = "0x18131CC70")]
	public static bool BCNALMBPJEP<T>(this T LBLAJOOMAIC, T GHLMPEGFGCH) where T : struct, IIENHJEKFBL
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x3FA8EB0", Offset = "0x3FA7AB0", VA = "0x183FA8EB0")]
	public static bool BPOKJGMAKGF<T>(this T LBLAJOOMAIC) where T : struct, IIENHJEKFBL
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0990", Offset = "0x5F9F590", VA = "0x185FA0990")]
	public static string ONKFIDNLEDD(this IIENHJEKFBL LBLAJOOMAIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class FJEBEDJLMOJ
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private enum IBJCEDGONEB : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private int FHKABFEFMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private bool IPHBHPKGFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private IBJCEDGONEB DBOAJCAFPEK;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool DIPMMBHCBIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5F9E290", Offset = "0x5F9CE90", VA = "0x185F9E290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool OBDKFKLMNIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5F9DF90", Offset = "0x5F9CB90", VA = "0x185F9DF90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5F9EE80", Offset = "0x5F9DA80", VA = "0x185F9EE80")]
	public FJEBEDJLMOJ(bool IPHBHPKGFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E7C0", Offset = "0x5F9D3C0", VA = "0x185F9E7C0")]
	public void NKIFEOJODBB(object AOEMDAGAALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E0F0", Offset = "0x5F9CCF0", VA = "0x185F9E0F0")]
	public void IAEDEBHMAFL(int NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E610", Offset = "0x5F9D210", VA = "0x185F9E610")]
	public void LBAOAAMGONF(uint COIHDIOGEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E0C0", Offset = "0x5F9CCC0", VA = "0x185F9E0C0")]
	public void FGPIHNHGMIC(bool OKCPCLIDLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5F9DFA0", Offset = "0x5F9CBA0", VA = "0x185F9DFA0")]
	public void DKFFCDCAEMG(long AOMALPIOKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5F9EE40", Offset = "0x5F9DA40", VA = "0x185F9EE40")]
	public void PCBEKBDOKJO(ulong CAHDPGHEGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E050", Offset = "0x5F9CC50", VA = "0x185F9E050")]
	public void EGKJBAFCPHE(string FFBECOINFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E190", Offset = "0x5F9CD90", VA = "0x185F9E190")]
	public void IKMFAHMGGDF(Enum MPIBPKBJNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E620", Offset = "0x5F9D220", VA = "0x185F9E620")]
	public void NDMPDLPACDI(IList FOLHIKGIGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2B5ED20", Offset = "0x2B5D920", VA = "0x182B5ED20")]
	public void DGGMLBGEMMH<T, U>(Dictionary<T, U> DADJDNPOMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E2A0", Offset = "0x5F9CEA0", VA = "0x185F9E2A0")]
	private void KKNDOLFFEKE(IDictionary DADJDNPOMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E220", Offset = "0x5F9CE20", VA = "0x185F9E220")]
	public int JBLEBBJFDAN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5F9DFE0", Offset = "0x5F9CBE0", VA = "0x185F9DFE0")]
	public short DPCHMAFJPAJ()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E0E0", Offset = "0x5F9CCE0", VA = "0x185F9E0E0")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E750", Offset = "0x5F9D350", VA = "0x185F9E750")]
	private void NILNMLDJJOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public abstract class EPECBNFPDLE<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	internal class OMNMOJDMMAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public TNode JELCPGCJLIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public TNode NIGFDFKEKGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public AJCEBEINLIB DGIABMCLHLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public List<AJCEBEINLIB> AAHHOOCGFOA;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		public OMNMOJDMMAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal struct AJCEBEINLIB : IComparable<AJCEBEINLIB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int ILJBAGMHILE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public TClaimant NIOCFLJJPCI;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x7979E0", Offset = "0x7965E0", VA = "0x1807979E0")]
		public AJCEBEINLIB(int ILJBAGMHILE, TClaimant NIOCFLJJPCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x30661C0", Offset = "0x3064DC0", VA = "0x1830661C0")]
		public bool GHCMAMFLFID(in AJCEBEINLIB GHLMPEGFGCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x3066220", Offset = "0x3064E20", VA = "0x183066220")]
		public bool JBDBIPENHFJ(in AJCEBEINLIB GHLMPEGFGCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x30661B0", Offset = "0x3064DB0", VA = "0x1830661B0", Slot = "4")]
		public int CompareTo(AJCEBEINLIB GHLMPEGFGCH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x3066230", Offset = "0x3064E30", VA = "0x183066230", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum IDAMPNIFPJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class BNBMNNEDAEC : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public global::EPECBNFPDLE<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x2705B40", Offset = "0x2704740", VA = "0x182705B40")]
		[DebuggerHidden]
		public BNBMNNEDAEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x2A66570", Offset = "0x2A65170", VA = "0x182A66570", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x2A66730", Offset = "0x2A65330", VA = "0x182A66730", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2A66650", Offset = "0x2A65250", VA = "0x182A66650", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x2706060", Offset = "0x2704C60", VA = "0x182706060", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly global::GGOLNJMHEFH<OMNMOJDMMAM> OEPDNJNFDJL;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly global::GGOLNJMHEFH<List<AJCEBEINLIB>> AKOHCIOHMOJ;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static int NNLLMAJMAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	internal readonly Dictionary<TClaimant, TNode> GOGJEJMHGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	internal readonly Dictionary<TNode, OMNMOJDMMAM> FIBFFCKHPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private IDAMPNIFPJF NGMKMMBHLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool JIGLPOGPBPP;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode OBGHCIILFKA(TNode PABNHBKHCNM);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void OCCJBBEPDFP(TNode PABNHBKHCNM, TClaimant ONMCPMNCHAM, TClaimant IGOEOLICNDD);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x23A8340", Offset = "0x23A6F40", VA = "0x1823A8340")]
	public EPECBNFPDLE(IDAMPNIFPJF NGMKMMBHLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x23A6BF0", Offset = "0x23A57F0", VA = "0x1823A6BF0")]
	public void AOMIGNHDJOE(TNode PABNHBKHCNM, TNode FJCPKFBPJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x23A7B00", Offset = "0x23A6700", VA = "0x1823A7B00")]
	public void HEINOGKJFDN(TClaimant NIOCFLJJPCI, TNode NMKNOBLHHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x23A6D40", Offset = "0x23A5940", VA = "0x1823A6D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x23A7C00", Offset = "0x23A6800", VA = "0x1823A7C00")]
	private void JNCCCKKLELP(TClaimant NIOCFLJJPCI, TNode BBCFJHILJBH, TNode NMKNOBLHHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x23A8180", Offset = "0x23A6D80", VA = "0x1823A8180")]
	private int MCDGMMFAGHI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x23A70A0", Offset = "0x23A5CA0", VA = "0x1823A70A0")]
	private void EDNCLNFDLND(TClaimant NIOCFLJJPCI, TNode JLFBALIGMFK, TNode DGPJCMKHAEC, int ILMGJFFHFKA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x23A7350", Offset = "0x23A5F50", VA = "0x1823A7350")]
	private void EEMJEKAABJA(AJCEBEINLIB JOFOFOIPALH, OMNMOJDMMAM LOLPIOKBEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x23A7E60", Offset = "0x23A6A60", VA = "0x1823A7E60")]
	private void LJBJDCHKJIN(TClaimant NIOCFLJJPCI, TNode JLFBALIGMFK, TNode DGPJCMKHAEC, int ILMGJFFHFKA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x23A73E0", Offset = "0x23A5FE0", VA = "0x1823A73E0")]
	private void FEKOOIGKIKI(AJCEBEINLIB JOFOFOIPALH, TNode PABNHBKHCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x23A6FA0", Offset = "0x23A5BA0", VA = "0x1823A6FA0")]
	private void EBPLGHFNPMP(AJCEBEINLIB JOFOFOIPALH, OMNMOJDMMAM LOLPIOKBEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x23A7680", Offset = "0x23A6280", VA = "0x1823A7680")]
	private void HAKKHLCKJHP(OMNMOJDMMAM LOLPIOKBEEP, bool KLLGOCKIDFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x23A7790", Offset = "0x23A6390", VA = "0x1823A7790")]
	private void HCDEDPFKDEF(OMNMOJDMMAM LOLPIOKBEEP, TNode FJCPKFBPJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x23A6C70", Offset = "0x23A5870", VA = "0x1823A6C70")]
	[IteratorStateMachine(typeof(global::EPECBNFPDLE<, >.BNBMNNEDAEC))]
	private IEnumerable<TNode> DANPDMHIBKN(TNode JLFBALIGMFK, TNode DGPJCMKHAEC, bool GAGJAAMPBDK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x23A80C0", Offset = "0x23A6CC0", VA = "0x1823A80C0")]
	private OMNMOJDMMAM LLABDIDAOGO(TNode PABNHBKHCNM, TNode NIGFDFKEKGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x23A74F0", Offset = "0x23A60F0", VA = "0x1823A74F0")]
	private OMNMOJDMMAM FPMBAEDPGHH(TNode PABNHBKHCNM, TNode NIGFDFKEKGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x23A7CA0", Offset = "0x23A68A0", VA = "0x1823A7CA0")]
	private void KEPBDHLJNPG(OMNMOJDMMAM LOLPIOKBEEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class MNPIPBJHEJI<T> : IEnumerable<global::MNPIPBJHEJI<T>.CINDKDIKOEG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public struct CINDKDIKOEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public T NENFOEKGNGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int KLEGICPDLIF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class LFCDICNDFBO : IEnumerator<CINDKDIKOEG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private global::MNPIPBJHEJI<T> FDJAPCCPCPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private int KLEGICPDLIF;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x1C286D0", Offset = "0x1C272D0", VA = "0x181C286D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public CINDKDIKOEG LEMCHMBGFHM
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x2C435B0", Offset = "0x2C421B0", VA = "0x182C435B0", Slot = "4")]
			get
			{
				return default(CINDKDIKOEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x7374A0", Offset = "0x7360A0", VA = "0x1807374A0")]
		public LFCDICNDFBO(global::MNPIPBJHEJI<T> FDJAPCCPCPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x2C433F0", Offset = "0x2C41FF0", VA = "0x182C433F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x737490", Offset = "0x736090", VA = "0x180737490", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xBD8FE0", Offset = "0xBD7BE0", VA = "0x180BD8FE0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private struct NNALNGJJAPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public bool PLAKKEENDLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public T NENFOEKGNGK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private const int DINDJBKNOPL = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Dictionary<T, int> JMEAHBMHBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private NNALNGJJAPO[] NPBENMKDKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int MNGIBPHOFLG;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int GKNPJMOIOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x74B6B0", Offset = "0x74A2B0", VA = "0x18074B6B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x85ACF0", Offset = "0x8598F0", VA = "0x18085ACF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2628870", Offset = "0x2627470", VA = "0x182628870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x41632F0", Offset = "0x4161EF0", VA = "0x1841632F0")]
	public MNPIPBJHEJI(int KOHJKAOCDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x41637D0", Offset = "0x41623D0", VA = "0x1841637D0")]
	public MNPIPBJHEJI(CINDKDIKOEG[] IFDILEIGNOD, bool CHMAFJJOCKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x41622C0", Offset = "0x4160EC0", VA = "0x1841622C0")]
	public int DBHNEPJCKAL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x4162C60", Offset = "0x4161860", VA = "0x184162C60")]
	private int NHLKLEABKAL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x41625C0", Offset = "0x41611C0", VA = "0x1841625C0", Slot = "6")]
	protected virtual uint EKNKKHIFOMA(uint FHKABFEFMDN, T NENFOEKGNGK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x4162470", Offset = "0x4161070", VA = "0x184162470")]
	public bool DJGCNILBMJP(T NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x4162420", Offset = "0x4161020", VA = "0x184162420")]
	public bool DIHHPBJEPKC(int KLEGICPDLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x4162660", Offset = "0x4161260", VA = "0x184162660")]
	public bool INBBKHIKIAC(Func<T, bool> ELLFPNJNAMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x41624E0", Offset = "0x41610E0", VA = "0x1841624E0")]
	public int EJEHGMHJEFE(T NENFOEKGNGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x4162C00", Offset = "0x4161800", VA = "0x184162C00")]
	public T LGHOHGDAHCA(int KLEGICPDLIF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x41625E0", Offset = "0x41611E0", VA = "0x1841625E0")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x4162050", Offset = "0x4160C50", VA = "0x184162050")]
	public bool CLKFKCPMKCB(T NENFOEKGNGK, bool BIPMBPCDLKG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x4161E50", Offset = "0x4160A50", VA = "0x184161E50")]
	public bool CLKFKCPMKCB(T NENFOEKGNGK, int KLEGICPDLIF, bool BIPMBPCDLKG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x4162B10", Offset = "0x4161710", VA = "0x184162B10")]
	public bool KFPKFODPJHB(T NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x4163050", Offset = "0x4161C50", VA = "0x184163050")]
	public bool OKDMEHCANKP(int KLEGICPDLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x4163180", Offset = "0x4161D80", VA = "0x184163180")]
	private void PMCJKECIICG(int KLEGICPDLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x4162950", Offset = "0x4161550", VA = "0x184162950")]
	public CINDKDIKOEG[] JDIBDDEDEKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x4162330", Offset = "0x4160F30", VA = "0x184162330")]
	private int DGGIDFLOOOK(int DOEIFPENHPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x4163270", Offset = "0x4161E70", VA = "0x184163270", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x4163270", Offset = "0x4161E70", VA = "0x184163270", Slot = "4")]
	private IEnumerator<CINDKDIKOEG> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct HDHOJNGNHFE<Handle> where Handle : IIENHJEKFBL, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct IDHILNEKCGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly global::HDHOJNGNHFE<Handle> OCHEEHNMMOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private int KLEGICPDLIF;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int DJGDCGPEBEP
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5260", Offset = "0x2BF3E60", VA = "0x182BF5260")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle KPHMFAHGFFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x2BF59C0", Offset = "0x2BF45C0", VA = "0x182BF59C0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x2BF5C60", Offset = "0x2BF4860", VA = "0x182BF5C60")]
		public IDHILNEKCGM(global::HDHOJNGNHFE<Handle> OCHEEHNMMOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x2BF4AA0", Offset = "0x2BF36A0", VA = "0x182BF4AA0")]
		public GECFIFBKFJC GADFBDMBHED(in GECFIFBKFJC DGKCGFAKKDB)
		{
			return default(GECFIFBKFJC);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x2BF4B40", Offset = "0x2BF3740", VA = "0x182BF4B40")]
		public OHPICDFKBNE GADFBDMBHED(in OHPICDFKBNE DGKCGFAKKDB)
		{
			return default(OHPICDFKBNE);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x2BF4BE0", Offset = "0x2BF37E0", VA = "0x182BF4BE0")]
		public bool GFBBAGFNJHL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x2BF5460", Offset = "0x2BF4060", VA = "0x182BF5460")]
		private int KDGKGJNMOCK(string DPNJMDFICMK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x2BF5BC0", Offset = "0x2BF47C0", VA = "0x182BF5BC0")]
		private Handle MEKDBOFPIKG(string DPNJMDFICMK)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public struct GECFIFBKFJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private IDHILNEKCGM KAHKPBAGPGJ;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int LEMCHMBGFHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x339EA10", Offset = "0x339D610", VA = "0x18339EA10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x2F9E8A0", Offset = "0x2F9D4A0", VA = "0x182F9E8A0")]
		public GECFIFBKFJC(global::HDHOJNGNHFE<Handle> OCHEEHNMMOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x2F9E760", Offset = "0x2F9D360", VA = "0x182F9E760")]
		public bool GFBBAGFNJHL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x339E950", Offset = "0x339D550", VA = "0x18339E950")]
		public GECFIFBKFJC EEAMIAJAFGO()
		{
			return default(GECFIFBKFJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct OHPICDFKBNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private IDHILNEKCGM KAHKPBAGPGJ;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle LEMCHMBGFHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x2F9E7A0", Offset = "0x2F9D3A0", VA = "0x182F9E7A0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x2F9E8A0", Offset = "0x2F9D4A0", VA = "0x182F9E8A0")]
		public OHPICDFKBNE(global::HDHOJNGNHFE<Handle> OCHEEHNMMOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x2F9E760", Offset = "0x2F9D360", VA = "0x182F9E760")]
		public bool GFBBAGFNJHL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x2F9E620", Offset = "0x2F9D220", VA = "0x182F9E620")]
		public OHPICDFKBNE EEAMIAJAFGO()
		{
			return default(OHPICDFKBNE);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private NativeList<int> CKJHDIGJOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private NativeList<int> DHBMKMKHKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private int JLNCKFJAMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private int PAFKDHHHNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private bool OAJEAEBJBJO;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool LLDLPKJFACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x7C4280", Offset = "0x7C2E80", VA = "0x1807C4280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int IGIALMEDHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x3907940", Offset = "0x3906540", VA = "0x183907940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int PKKLLOFFMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6948E0", Offset = "0x6934E0", VA = "0x1806948E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int ADEGOMJKDBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x6948E0", Offset = "0x6934E0", VA = "0x1806948E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public GECFIFBKFJC PGMNPEPCJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x39095F0", Offset = "0x39081F0", VA = "0x1839095F0")]
		get
		{
			return default(GECFIFBKFJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public OHPICDFKBNE FCPPPPGOAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x3909090", Offset = "0x3907C90", VA = "0x183909090")]
		get
		{
			return default(OHPICDFKBNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x390BA60", Offset = "0x390A660", VA = "0x18390BA60")]
	public HDHOJNGNHFE(int ABEGDLHOKEP, Allocator JMMNDPMBMFC = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3908080", Offset = "0x3906C80", VA = "0x183908080")]
	public void EKCDHDCHCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x26049D0", Offset = "0x26035D0", VA = "0x1826049D0")]
	public static int KGBFHPJIMKB(int ILBEOCCCHNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3909690", Offset = "0x3908290", VA = "0x183909690")]
	public static bool KOGIDPHKIGM(int ILBEOCCCHNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x39082C0", Offset = "0x3906EC0", VA = "0x1839082C0")]
	public static bool EOBFCAKDKJK(int ILBEOCCCHNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x390B6A0", Offset = "0x390A2A0", VA = "0x18390B6A0")]
	public bool PMEMPGICCGP(int KLEGICPDLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x3909A00", Offset = "0x3908600", VA = "0x183909A00")]
	public bool LIBODOKHFFN(int KLEGICPDLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x3909130", Offset = "0x3907D30", VA = "0x183909130")]
	public bool GLNIBLOFFFA(Handle LBLAJOOMAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x390AB40", Offset = "0x3909740", VA = "0x18390AB40")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void PKPPKAIIEFK(Handle LBLAJOOMAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x3909B20", Offset = "0x3908720", VA = "0x183909B20")]
	public Handle MPHCIGHMOCG()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x39082D0", Offset = "0x3906ED0", VA = "0x1839082D0")]
	public void FBKPEEBNIFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x3907980", Offset = "0x3906580", VA = "0x183907980")]
	public void BOJGLFPLHDB(Handle LBLAJOOMAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x3907D00", Offset = "0x3906900", VA = "0x183907D00")]
	public bool DFGJIKCKHPB(Handle LBLAJOOMAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x7C4280", Offset = "0x7C2E80", VA = "0x1807C4280")]
	private bool AJJMAEGNDHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x3907B80", Offset = "0x3906780", VA = "0x183907B80")]
	private bool CNBAFNBEBLB(int KLEGICPDLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x390A6B0", Offset = "0x39092B0", VA = "0x18390A6B0")]
	private void PEKLADKAFNL(out int KLEGICPDLIF, out int OLOLCGEOMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x3907680", Offset = "0x3906280", VA = "0x183907680")]
	private void AFKKBIFBGJB(Handle LBLAJOOMAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x3909EB0", Offset = "0x3908AB0", VA = "0x183909EB0")]
	private void ODPNHNJMMEM(int KLEGICPDLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x390A050", Offset = "0x3908C50", VA = "0x18390A050")]
	private bool PEGKLDJCBDE(out int KLEGICPDLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x3908F00", Offset = "0x3907B00", VA = "0x183908F00")]
	private static Handle FKHBBGDOKCB(int KLEGICPDLIF, int OLOLCGEOMNE)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[DefaultMember("Item")]
public struct FNIOGEGGNAD<Handle, T> where Handle : IIENHJEKFBL, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private global::HDHOJNGNHFE<Handle> GCMMGMEBDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private T[] EBGMODCAFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private Action<T> CBJJMOEEGNK;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool LLDLPKJFACL
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x30C5190", Offset = "0x30C3D90", VA = "0x1830C5190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int IGIALMEDHOD
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x3A175A0", Offset = "0x3A161A0", VA = "0x183A175A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x30C4C30", Offset = "0x30C3830", VA = "0x1830C4C30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x3A18D70", Offset = "0x3A17970", VA = "0x183A18D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x3A19510", Offset = "0x3A18110", VA = "0x183A19510")]
	public FNIOGEGGNAD(int ABEGDLHOKEP, [Optional] Action<T> CBJJMOEEGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x3A17830", Offset = "0x3A16430", VA = "0x183A17830")]
	public void EKCDHDCHCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x3A17F00", Offset = "0x3A16B00", VA = "0x183A17F00")]
	public bool GLNIBLOFFFA(Handle LBLAJOOMAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void PKPPKAIIEFK(Handle LBLAJOOMAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x3A17950", Offset = "0x3A16550", VA = "0x183A17950")]
	public T FABELHKIKFB(Handle LBLAJOOMAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x3A180A0", Offset = "0x3A16CA0", VA = "0x183A180A0")]
	public bool JIJNIMCPPHN(Handle LBLAJOOMAIC, out T AOEMDAGAALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x3A175E0", Offset = "0x3A161E0", VA = "0x183A175E0")]
	public void CKBKODEFPCJ(Handle LBLAJOOMAIC, T GFLAOIKJHGJ, out T KGPCALPJHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x3A17680", Offset = "0x3A16280", VA = "0x183A17680")]
	public void CKBKODEFPCJ(Handle LBLAJOOMAIC, T GFLAOIKJHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x3A17A80", Offset = "0x3A16680", VA = "0x183A17A80")]
	public bool FFIBKKMIOAO(Handle LBLAJOOMAIC, T GFLAOIKJHGJ, out T KGPCALPJHJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x3A17B70", Offset = "0x3A16770", VA = "0x183A17B70")]
	public bool FFIBKKMIOAO(Handle LBLAJOOMAIC, T GFLAOIKJHGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x3A17420", Offset = "0x3A16020", VA = "0x183A17420")]
	public Handle AABPNGPFBPJ(T AOEMDAGAALP)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x3A18B40", Offset = "0x3A17740", VA = "0x183A18B40")]
	public void KMFBNIHKEHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x3A18200", Offset = "0x3A16E00", VA = "0x183A18200")]
	public void KFPKFODPJHB(Handle LBLAJOOMAIC, out T KGPCALPJHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x3A18470", Offset = "0x3A17070", VA = "0x183A18470")]
	public void KFPKFODPJHB(Handle LBLAJOOMAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x3A19070", Offset = "0x3A17C70", VA = "0x183A19070")]
	public bool PFKFPKEELDF(Handle LBLAJOOMAIC, out T KGPCALPJHJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x3A19150", Offset = "0x3A17D50", VA = "0x183A19150")]
	public bool PFKFPKEELDF(Handle LBLAJOOMAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x30C5860", Offset = "0x30C4460", VA = "0x1830C5860")]
	private T OKDMEHCANKP(int KLEGICPDLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x30C52F0", Offset = "0x30C3EF0", VA = "0x1830C52F0")]
	private void KBIFLGFAFLH(int BGJFBNEJEJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class GGOLNJMHEFH<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Stack<T> OCHEEHNMMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<T> ENIMLNCMEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly int MIGFCMBEFHA;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int AOJFHHPHBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x2DA08D0", Offset = "0x2D9F4D0", VA = "0x182DA08D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int NAPHIFJLJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x33A8B90", Offset = "0x33A7790", VA = "0x1833A8B90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x33A87D0", Offset = "0x33A73D0", VA = "0x1833A87D0")]
	public static global::GGOLNJMHEFH<T> CFNAOEMJOJH(int KOHJKAOCDIM = 0, int MIGFCMBEFHA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x33A8D80", Offset = "0x33A7980", VA = "0x1833A8D80")]
	public static global::GGOLNJMHEFH<T> OKBHMHEMDGJ(int KOHJKAOCDIM = 0, int MIGFCMBEFHA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x33A8FE0", Offset = "0x33A7BE0", VA = "0x1833A8FE0")]
	public GGOLNJMHEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x33A8E50", Offset = "0x33A7A50", VA = "0x1833A8E50")]
	public GGOLNJMHEFH(int KOHJKAOCDIM, int MIGFCMBEFHA = int.MaxValue, bool JCFDLKJADJM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x33A88A0", Offset = "0x33A74A0", VA = "0x1833A88A0")]
	public T DAHCFDBKLKE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x33A8C50", Offset = "0x33A7850", VA = "0x1833A8C50")]
	public void MCMCELGEBEK(T NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x33A89B0", Offset = "0x33A75B0", VA = "0x1833A89B0")]
	private void DEAOBAAOLOF(T NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x33A8B70", Offset = "0x33A7770", VA = "0x1833A8B70")]
	private void IGDBNKEPBKP(T NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x33A8D00", Offset = "0x33A7900", VA = "0x1833A8D00")]
	[Conditional("DEBUG_BUILD")]
	private void MFANKIDCMIE(T FFKLDEGMPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x33A8BC0", Offset = "0x33A77C0", VA = "0x1833A8BC0")]
	[Conditional("DEBUG_BUILD")]
	private void KIJCPPAJBIF(T FFKLDEGMPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x33A8A80", Offset = "0x33A7680", VA = "0x1833A8A80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x33A8630", Offset = "0x33A7230", VA = "0x1833A8630")]
	private void AIFMJEKMANB(IEnumerable<T> BHBEDDCMEIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class DAOIIMMOAAN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private Dictionary<int, T> KGHEIHGAAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private T CMCMGLMJPKO;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T DHFLNNAOLLB
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x69FA00", Offset = "0x69E600", VA = "0x18069FA00", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool GOHJIJINGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x2D77730", Offset = "0x2D76330", VA = "0x182D77730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x2D776D0", Offset = "0x2D762D0", VA = "0x182D776D0")]
	public bool KMNMLABECCC(T NENFOEKGNGK, int ILJBAGMHILE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2D77020", Offset = "0x2D75C20", VA = "0x182D77020")]
	public bool EIDHPLNDEKK(int ILJBAGMHILE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2D77080", Offset = "0x2D75C80", VA = "0x182D77080")]
	public T GCOKNJPGMDC(int BHAOEJIBJEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2D77470", Offset = "0x2D76070", VA = "0x182D77470")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2D774D0", Offset = "0x2D760D0", VA = "0x182D774D0")]
	private bool JOOMABDLNJH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x2D77770", Offset = "0x2D76370", VA = "0x182D77770")]
	public bool PDCGIMKGOOO(int ILJBAGMHILE, out T NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x2D777A0", Offset = "0x2D763A0", VA = "0x182D777A0")]
	public DAOIIMMOAAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class LHPKIIJBIAI<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	protected struct JINBMDBLGAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public T FGHAAIAMOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int MCHGIDGNMMM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	protected readonly List<JINBMDBLGAI> MKBIPAOEEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private T IAFIJKGLFMD;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x2628870", Offset = "0x2627470", VA = "0x182628870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2C4AB20", Offset = "0x2C49720", VA = "0x182C4AB20")]
	public bool INBBKHIKIAC(T NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2C4A9B0", Offset = "0x2C495B0", VA = "0x182C4A9B0")]
	public void AABPNGPFBPJ(T NENFOEKGNGK, int ILJBAGMHILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x2C4AEF0", Offset = "0x2C49AF0", VA = "0x182C4AEF0")]
	public bool KFPKFODPJHB(T NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2C4AAC0", Offset = "0x2C496C0", VA = "0x182C4AAC0")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x2C4B010", Offset = "0x2C49C10", VA = "0x182C4B010")]
	public T LDFNHLNCMEN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2C4AA50", Offset = "0x2C49650", VA = "0x182C4AA50")]
	public T DFOMNHDCLOK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2C4AD30", Offset = "0x2C49930", VA = "0x182C4AD30")]
	private void JKPFGIJJFKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2C4B080", Offset = "0x2C49C80", VA = "0x182C4B080")]
	public LHPKIIJBIAI()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		[MBKFNACBIPJ(GHABDIHKABP.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x5FA38F0", Offset = "0x5FA24F0", VA = "0x185FA38F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x5FA3C80", Offset = "0x5FA2880", VA = "0x185FA3C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x5FA3B00", Offset = "0x5FA2700", VA = "0x185FA3B00")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x5FA3DE0", Offset = "0x5FA29E0", VA = "0x185FA3DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x5FA3810", Offset = "0x5FA2410", VA = "0x185FA3810")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x5FA3BA0", Offset = "0x5FA27A0", VA = "0x185FA3BA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x5FA3A20", Offset = "0x5FA2620", VA = "0x185FA3A20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5FA37C0", Offset = "0x5FA23C0", VA = "0x185FA37C0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface GJNABMEBDDK
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class ResourcePrefabReference<T> : GJNABMEBDDK where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x3583010", Offset = "0x3581C10", VA = "0x183583010", Slot = "4")]
		public virtual T KMEJLINFKMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class DDCDIPJKNPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly Dictionary<byte, NKOIBCDGABH> AHLGEANPACK;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public NKOIBCDGABH KCDABAJNKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x695F10", Offset = "0x694B10", VA = "0x180695F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 EMHOGPLBJDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xA7A360", Offset = "0xA78F60", VA = "0x180A7A360")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x7D9D70", Offset = "0x7D8970", VA = "0x1807D9D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 CMACJECDNDA
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xDB36C0", Offset = "0xDB22C0", VA = "0x180DB36C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x83B590", Offset = "0x83A190", VA = "0x18083B590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 GJKDHCEALCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D0A0", Offset = "0x5F9BCA0", VA = "0x185F9D0A0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x7B7E00", Offset = "0x7B6A00", VA = "0x1807B7E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int KJCBGBJGLFE
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x7335B0", Offset = "0x7321B0", VA = "0x1807335B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x813D30", Offset = "0x812930", VA = "0x180813D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D340", Offset = "0x5F9BF40", VA = "0x185F9D340")]
	public DDCDIPJKNPF(Bounds KBBJCIMMACA, Vector2[] FBPHLIDCCPC, int GPMHHEMKOFP, byte DOEIFPENHPA, float BLAFOMIMDAF = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5F9CC40", Offset = "0x5F9B840", VA = "0x185F9CC40")]
	public NKOIBCDGABH AGODMMGLNEE(byte KLEGICPDLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D240", Offset = "0x5F9BE40", VA = "0x185F9D240")]
	public void PJKMIOFFENF(Vector3 BBEHPKKOBDE, float JLNGPBNNNEI, float DCFLKJKNIGJ, ref List<byte> KIMBNMOAFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D220", Offset = "0x5F9BE20", VA = "0x185F9D220")]
	public void NENDGECLHAD(NKOIBCDGABH.LCPPGDODJMP AIIFOGDCIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D0C0", Offset = "0x5F9BCC0", VA = "0x185F9D0C0")]
	private NKOIBCDGABH MIPJCECBEDB(byte KLEGICPDLIF, NKOIBCDGABH.MIKLLLEIPLO CCJFNCEGGAP, NKOIBCDGABH NIGFDFKEKGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5F9CCA0", Offset = "0x5F9B8A0", VA = "0x185F9CCA0")]
	private void CDKMLLALNMN(NKOIBCDGABH NIGFDFKEKGM, Vector2[] FBPHLIDCCPC, int JFJBKFJDILP, int JLFEJJNJEIN, int JEJDGONAJLC, int PLMINHHBGMJ, float BLAFOMIMDAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class NKOIBCDGABH
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public enum MIKLLLEIPLO
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public enum LCPPGDODJMP
	{
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public byte EHMEPDKHBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public Vector3 HCBJBHCJOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector3 PAPHLGGFPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Vector3 IGGIOPPEMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public Vector3 OPFPOABNMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public MIKLLLEIPLO HOAAPBJNMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public NKOIBCDGABH GJANBAOLOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public List<NKOIBCDGABH> EOCELAGGHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public bool EIGHKEBJOJK;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3690", Offset = "0x5FA2290", VA = "0x185FA3690")]
	public NKOIBCDGABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3630", Offset = "0x5FA2230", VA = "0x185FA3630")]
	public NKOIBCDGABH(byte BEAOEMMHBNI, MIKLLLEIPLO CCJFNCEGGAP, NKOIBCDGABH NIGFDFKEKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5FA32C0", Offset = "0x5FA1EC0", VA = "0x185FA32C0")]
	public void LFGMLIPOPPB(NKOIBCDGABH JAFNGMFCAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	public void NENDGECLHAD(int COHOIHGCGOC, LCPPGDODJMP AIIFOGDCIDH, int HICAKNINFGB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3380", Offset = "0x5FA1F80", VA = "0x185FA3380")]
	public void PJKMIOFFENF(List<byte> KIMBNMOAFBC, Vector3 BBEHPKKOBDE, float JLNGPBNNNEI, float DCFLKJKNIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3230", Offset = "0x5FA1E30", VA = "0x185FA3230")]
	public bool DJHCNJHKLMF(Vector3 LGCBMACDBHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3280", Offset = "0x5FA1E80", VA = "0x185FA3280")]
	public bool DNFOPBEOGBD(Vector3 LGCBMACDBHA, float KDKCHCBLAOI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class CMHPDDACOPC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly Dictionary<T, object> HPCFDJLAOGO;

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A571B0", Offset = "0x2A55DB0", VA = "0x182A571B0")]
	public bool JMFNCBBBOGJ(T FMKFGDOIMGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x30F00D0", Offset = "0x30EECD0", VA = "0x1830F00D0")]
	public bool JMFNCBBBOGJ(T FMKFGDOIMGF, object GIHOLCNOBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x30F0110", Offset = "0x30EED10", VA = "0x1830F0110")]
	public bool JMFNCBBBOGJ(T FMKFGDOIMGF, object GIHOLCNOBIB, out object CFMNEALGPHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x30F0170", Offset = "0x30EED70", VA = "0x1830F0170")]
	public bool KKEKFODKBFL(T FMKFGDOIMGF, object GIHOLCNOBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x30F0090", Offset = "0x30EEC90", VA = "0x1830F0090")]
	public bool GCJMDNOMBGH(T FMKFGDOIMGF, object GIHOLCNOBIB, out object CFMNEALGPHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x30F01B0", Offset = "0x30EEDB0", VA = "0x1830F01B0")]
	public bool KKEKFODKBFL(T FMKFGDOIMGF, object GIHOLCNOBIB, out object CFMNEALGPHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x30F0060", Offset = "0x30EEC60", VA = "0x1830F0060")]
	public void EKBHFACDLBP(T FMKFGDOIMGF, object GIHOLCNOBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x30F0240", Offset = "0x30EEE40", VA = "0x1830F0240")]
	public void KNNHKHLHJIJ(T FMKFGDOIMGF, object GIHOLCNOBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x30F02E0", Offset = "0x30EEEE0", VA = "0x1830F02E0")]
	public CMHPDDACOPC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		public struct ABPPACADFPA<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			private readonly List<Component> FOLHIKGIGJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private readonly bool EPBCADGKFHC;

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xCAABF0", Offset = "0xCA97F0", VA = "0x180CAABF0")]
			public ABPPACADFPA(List<Component> FOLHIKGIGJA, bool EPBCADGKFHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x304DEA0", Offset = "0x304CAA0", VA = "0x18304DEA0")]
			public OLCAMAAMBAO<T> EEAMIAJAFGO()
			{
				return default(OLCAMAAMBAO<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x304DF10", Offset = "0x304CB10", VA = "0x18304DF10", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x304DF10", Offset = "0x304CB10", VA = "0x18304DF10", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		public struct OLCAMAAMBAO<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private readonly List<Component> FOLHIKGIGJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private readonly bool EPBCADGKFHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private int KLEGICPDLIF;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T LEMCHMBGFHM
			{
				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x461B640", Offset = "0x461A240", VA = "0x18461B640", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0x461B5D0", Offset = "0x461A1D0", VA = "0x18461B5D0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x461B610", Offset = "0x461A210", VA = "0x18461B610")]
			public OLCAMAAMBAO(List<Component> FOLHIKGIGJA, bool EPBCADGKFHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x461B510", Offset = "0x461A110", VA = "0x18461B510", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x461B520", Offset = "0x461A120", VA = "0x18461B520", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x2C4BC00", Offset = "0x2C4A800", VA = "0x182C4BC00", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x5FA5B30", Offset = "0x5FA4730", VA = "0x185FA5B30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5FA5AF0", Offset = "0x5FA46F0", VA = "0x185FA5AF0")]
		public ToolHierarchyCache(GameObject IOHAHKHBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5FA53B0", Offset = "0x5FA3FB0", VA = "0x185FA53B0")]
		private void CKNDJHJGHOM(GameObject IOHAHKHBMPK, bool HLLKIIKCMBO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5FA5320", Offset = "0x5FA3F20", VA = "0x185FA5320")]
		public static void CKNDJHJGHOM(GameObject IOHAHKHBMPK, ref ToolHierarchyCache OKMBJHAADLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5FA5590", Offset = "0x5FA4190", VA = "0x185FA5590")]
		public void GJALKGHEBII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x5FA5A20", Offset = "0x5FA4620", VA = "0x185FA5A20")]
		public void OPIIFECFDOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x3A54CA0", Offset = "0x3A538A0", VA = "0x183A54CA0")]
		public void JAKMKLGGKFH<T>(Action<T> MNJNLIAKBME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x5FA5950", Offset = "0x5FA4550", VA = "0x185FA5950")]
		public Component LPKAFKGLDIH(Type JMPEGNOKOOB, bool EPBCADGKFHC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x3A54F30", Offset = "0x3A53B30", VA = "0x183A54F30")]
		public T LPKAFKGLDIH<T>(bool EPBCADGKFHC = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x5FA52A0", Offset = "0x5FA3EA0", VA = "0x185FA52A0")]
		public ABPPACADFPA<Component> ALOJJDFGGHG(Type JMPEGNOKOOB, bool EPBCADGKFHC = false)
		{
			return default(ABPPACADFPA<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x3A54BD0", Offset = "0x3A537D0", VA = "0x183A54BD0")]
		public ABPPACADFPA<T> ALOJJDFGGHG<T>(bool EPBCADGKFHC = false) where T : class
		{
			return default(ABPPACADFPA<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x5FA5620", Offset = "0x5FA4220", VA = "0x185FA5620")]
		public List<Component> HIOBDDCDDKF(Type JMPEGNOKOOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x5FA5510", Offset = "0x5FA4110", VA = "0x185FA5510", Slot = "4")]
		public bool Equals(ToolHierarchyCache CCOKEBDEHII, ToolHierarchyCache DEGPJNBMBCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x5FA55A0", Offset = "0x5FA41A0", VA = "0x185FA55A0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache AOEMDAGAALP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public class GPGEMDNEOEC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private int KOHJKAOCDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private int GMBALCONGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private List<T> IBDDKLPMGNI;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x2DA08D0", Offset = "0x2D9F4D0", VA = "0x182DA08D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T MKCGMKFKIHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x43B7CF0", Offset = "0x43B68F0", VA = "0x1843B7CF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T CAOAMAJAEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x43B7F40", Offset = "0x43B6B40", VA = "0x1843B7F40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T DOKBFGAMLBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x43B8030", Offset = "0x43B6C30", VA = "0x1843B8030")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x43B8090", Offset = "0x43B6C90", VA = "0x1843B8090")]
	public GPGEMDNEOEC(int KOHJKAOCDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x43B7C10", Offset = "0x43B6810", VA = "0x1843B7C10")]
	public void AABPNGPFBPJ(T HHOIDAMKHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x43B7FA0", Offset = "0x43B6BA0", VA = "0x1843B7FA0")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x43B7E60", Offset = "0x43B6A60", VA = "0x1843B7E60")]
	public void ELJBAGNDOCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x43B7E00", Offset = "0x43B6A00", VA = "0x1843B7E00")]
	public void BIPBEMFEFFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x43B7E50", Offset = "0x43B6A50", VA = "0x1843B7E50")]
	public void BKAGBDBGGPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class POCBLPGNKBP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private bool NBBACGCFAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private Action MNJNLIAKBME;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static POCBLPGNKBP BLBDHPEODCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5FA3720", Offset = "0x5FA2320", VA = "0x185FA3720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool IGNLNPOLLFL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x711D10", Offset = "0x710910", VA = "0x180711D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x76F810", Offset = "0x76E410", VA = "0x18076F810")]
	public POCBLPGNKBP(Action MNJNLIAKBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5FA37A0", Offset = "0x5FA23A0", VA = "0x185FA37A0")]
	public void OAIJALNIHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5FA37A0", Offset = "0x5FA23A0", VA = "0x185FA37A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class GBKODJIHIED
{
	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x5F9EEF0", Offset = "0x5F9DAF0", VA = "0x185F9EEF0")]
	public static void DKKJGIIDMHM(MMFAJFOCIGH ELMCPJHPOFL, string OALBMLJKPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	public static void DKKJGIIDMHM(IEnumerable<object> FHIGBPAOILI, string OALBMLJKPLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class KPHMMEMAIPD<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private struct MMAMGBMBFFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public int MCHGIDGNMMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public T FGHAAIAMOAB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly Dictionary<object, MMAMGBMBFFL> KGHEIHGAAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly EqualityComparer<T> FBKMCNCBPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private T CMCMGLMJPKO;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T DHFLNNAOLLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x706ED0", Offset = "0x705AD0", VA = "0x180706ED0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7070D0", Offset = "0x705CD0", VA = "0x1807070D0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool GOHJIJINGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x37CD210", Offset = "0x37CBE10", VA = "0x1837CD210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object JEOHFGADOKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x6B6560", Offset = "0x6B5160", VA = "0x1806B6560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x7070C0", Offset = "0x705CC0", VA = "0x1807070C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x37CD050", Offset = "0x37CBC50", VA = "0x1837CD050")]
	public bool KMNMLABECCC(T NENFOEKGNGK, object GIHOLCNOBIB, int ILJBAGMHILE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x37CC520", Offset = "0x37CB120", VA = "0x1837CC520")]
	public bool EIDHPLNDEKK(object GIHOLCNOBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x37CD300", Offset = "0x37CBF00", VA = "0x1837CD300")]
	public bool PDCGIMKGOOO(object GIHOLCNOBIB, out T NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2FC1FD0", Offset = "0x2FC0BD0", VA = "0x182FC1FD0")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x37CC590", Offset = "0x37CB190", VA = "0x1837CC590")]
	private bool JOOMABDLNJH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x37CD370", Offset = "0x37CBF70", VA = "0x1837CD370")]
	public KPHMMEMAIPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class EFKAGDAJBMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private Dictionary<object, float> KGHEIHGAAIG;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float MMFAJIJJGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x82E840", Offset = "0x82D440", VA = "0x18082E840")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x82E850", Offset = "0x82D450", VA = "0x18082E850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D970", Offset = "0x5F9C570", VA = "0x185F9D970")]
	public void KMNMLABECCC(float NENFOEKGNGK, object GIHOLCNOBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D900", Offset = "0x5F9C500", VA = "0x185F9D900")]
	public void EIDHPLNDEKK(object GIHOLCNOBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D9E0", Offset = "0x5F9C5E0", VA = "0x185F9D9E0")]
	private void OEOJDOGLIIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5F9DB00", Offset = "0x5F9C700", VA = "0x185F9DB00")]
	public EFKAGDAJBMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class ALINNECOEFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public readonly string KHFNJLJCKOB;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x7343F0", Offset = "0x732FF0", VA = "0x1807343F0")]
	public ALINNECOEFE(string KLMBOFGPFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x5F9C560", Offset = "0x5F9B160", VA = "0x185F9C560")]
	public ALINNECOEFE(UnityEngine.Object LNHFMEBKBOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x5F9C510", Offset = "0x5F9B110", VA = "0x185F9C510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class MMFAJFOCIGH
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class IFGJHOENBGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public IFGJHOENBGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F5A0", Offset = "0x5F9E1A0", VA = "0x185F9F5A0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private HashSet<object> FHIGBPAOILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private int OECIGHEACCL;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> FPIONBFBIHL
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x5FA2310", Offset = "0x5FA0F10", VA = "0x185FA2310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool APKBPPNGJGB
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x5FA24E0", Offset = "0x5FA10E0", VA = "0x185FA24E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x6B7080", Offset = "0x6B5C80", VA = "0x1806B7080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2220", Offset = "0x5FA0E20", VA = "0x185FA2220")]
	public bool AABPNGPFBPJ(object GIHOLCNOBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2440", Offset = "0x5FA1040", VA = "0x185FA2440")]
	public bool KFPKFODPJHB(object GIHOLCNOBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5FA23E0", Offset = "0x5FA0FE0", VA = "0x185FA23E0")]
	public bool INBBKHIKIAC(object GIHOLCNOBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5FA24F0", Offset = "0x5FA10F0", VA = "0x185FA24F0")]
	public void PNEKKIOFOJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2560", Offset = "0x5FA1160", VA = "0x185FA2560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public MMFAJFOCIGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class CFECGPFMBCB<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private struct KNPLNHLIJEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public float PIEGCEOIJOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public T FGHAAIAMOAB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private Dictionary<object, KNPLNHLIJEI> KGHEIHGAAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private T BGPNPNDBMLE;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T LCDJBAHEGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x19ED140", Offset = "0x19EBD40", VA = "0x1819ED140", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6C10", Offset = "0x1DD5810", VA = "0x181DD6C10", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object FOBOFDPGCHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x6B6560", Offset = "0x6B5160", VA = "0x1806B6560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x7070C0", Offset = "0x705CC0", VA = "0x1807070C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool GOHJIJINGPE
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x30E1A30", Offset = "0x30E0630", VA = "0x1830E1A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x30E1540", Offset = "0x30E0140", VA = "0x1830E1540")]
	public bool KMNMLABECCC(T NENFOEKGNGK, object GIHOLCNOBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x30DFDA0", Offset = "0x30DE9A0", VA = "0x1830DFDA0")]
	public bool EIDHPLNDEKK(object GIHOLCNOBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x2FC1FD0", Offset = "0x2FC0BD0", VA = "0x182FC1FD0")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x30E1A70", Offset = "0x30E0670", VA = "0x1830E1A70")]
	public bool PDCGIMKGOOO(object GIHOLCNOBIB, out T NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x30E0AB0", Offset = "0x30DF6B0", VA = "0x1830E0AB0")]
	private bool JOOMABDLNJH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x30E1CE0", Offset = "0x30E08E0", VA = "0x1830E1CE0")]
	public CFECGPFMBCB()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class JKMMEKILHLE
{
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static byte[] AGGHFJMNIJN;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static int BFFGPOMCPJB;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static int MBPNPBCPPJJ;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static BigInteger ELICCIFCIHI;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public JKMMEKILHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x5FA00B0", Offset = "0x5F9ECB0", VA = "0x185FA00B0")]
	private static string HIPMGELGEMF(byte[] APLKEMLCGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5FA01C0", Offset = "0x5F9EDC0", VA = "0x185FA01C0")]
	public static string OIADEFGOGFH(byte[] FCLGIGIIKEH, bool ABEBLNADKAB)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
