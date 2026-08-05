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
public class EMOKMJKPILM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640")]
	public EMOKMJKPILM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, NGMNPBPGABM, OCJIFHHOAOJ, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x623BB0", Offset = "0x622DB0", VA = "0x180623BB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD10", Offset = "0x5FCF10", VA = "0x1805FDD10", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD20", Offset = "0x5FCF20", VA = "0x1805FDD20", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6D6330", Offset = "0x6D5530", VA = "0x1806D6330", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash HGCLPJPLDLN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A5230", Offset = "0x6A4430", VA = "0x1806A5230")]
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
	[BKECFMALJKH]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[HideInInspector]
	[BKECFMALJKH]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x26D38E0", Offset = "0x26D2AE0", VA = "0x1826D38E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x26D38A0", Offset = "0x26D2AA0", VA = "0x1826D38A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x26D3920", Offset = "0x26D2B20", VA = "0x1826D3920")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x26D3B30", Offset = "0x26D2D30", VA = "0x1826D3B30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x26D3AA0", Offset = "0x26D2CA0", VA = "0x1826D3AA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7DB5B0", Offset = "0x7DA7B0", VA = "0x1807DB5B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7DB2A0", Offset = "0x7DA4A0", VA = "0x1807DB2A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x26D3860", Offset = "0x26D2A60", VA = "0x1826D3860")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x26D3A10", Offset = "0x26D2C10", VA = "0x1826D3A10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x26D3290", Offset = "0x26D2490", VA = "0x1826D3290")]
	public void CopyBounds(SavedExtents GHOINNFPLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x26D37D0", Offset = "0x26D29D0", VA = "0x1826D37D0")]
	public void SetLocalSpaceBounds(Bounds NFOHOMOGAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x901B00", Offset = "0x900D00", VA = "0x180901B00")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x26D37C0", Offset = "0x26D29C0", VA = "0x1826D37C0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x26D32C0", Offset = "0x26D24C0", VA = "0x1826D32C0")]
	private void FHMJKILGEKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x26D3590", Offset = "0x26D2790", VA = "0x1826D3590")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x26D2CD0", Offset = "0x26D1ED0", VA = "0x1826D2CD0")]
	public static void CalculateLocalBoundsFor(GameObject NEFMINHNLIG, out Bounds NFOHOMOGAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x26D34D0", Offset = "0x26D26D0", VA = "0x1826D34D0")]
	private static void IFALLJDIANJ(Bounds KLGGEDCBMPK, Color FBCEFPPNKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x26D37F0", Offset = "0x26D29F0", VA = "0x1826D37F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6EDC00", Offset = "0x6ECE00", VA = "0x1806EDC00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x623BB0", Offset = "0x622DB0", VA = "0x180623BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "4")]
	public virtual void GLICDPNIPOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
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
	[EMOKMJKPILM]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF700", Offset = "0x4CEE900", VA = "0x184CEF700", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4CEEFD0", Offset = "0x4CEE1D0", VA = "0x184CEEFD0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4CF0000", Offset = "0x4CEF200", VA = "0x184CF0000")]
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
	private sealed class LCDMFBAKDKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		public LCDMFBAKDKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4791850", Offset = "0x4790A50", VA = "0x184791850")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[EMOKMJKPILM]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x478B1E0", Offset = "0x478A3E0", VA = "0x18478B1E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x478B210", Offset = "0x478A410", VA = "0x18478B210", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x478B130", Offset = "0x478A330", VA = "0x18478B130", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey JCNAPFOCJDI]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x478B160", Offset = "0x478A360", VA = "0x18478B160", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x478B030", Offset = "0x478A230", VA = "0x18478B030", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x478A890", Offset = "0x4789A90", VA = "0x18478A890", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x478A200", Offset = "0x4789400", VA = "0x18478A200", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4789D70", Offset = "0x4788F70", VA = "0x184789D70", Slot = "14")]
	protected virtual string AMFODPIOBBC(TKeyVal CAEJEGMFHKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4663920", Offset = "0x4662B20", VA = "0x184663920", Slot = "4")]
	public bool ContainsKey(TKey JCNAPFOCJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x478AF20", Offset = "0x478A120", VA = "0x18478AF20", Slot = "5")]
	public bool TryGetValue(TKey JCNAPFOCJDI, out TVal ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4789E00", Offset = "0x4789000", VA = "0x184789E00", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4789E00", Offset = "0x4789000", VA = "0x184789E00", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x478AF50", Offset = "0x478A150", VA = "0x18478AF50")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FHMKIFGOOGK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JAOENNIFMNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		public JAOENNIFMNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x485FF80", Offset = "0x485F180", VA = "0x18485FF80")]
		internal bool <GetSamples>b__0(global::PJLKDAAMBAL<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float NEBDHCNMNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float FFMDLCPNOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::PJLKDAAMBAL<float, T>> HLEDMKMMLMP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int IKEOHHMFMLH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x484F700", Offset = "0x484E900", VA = "0x18484F700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x484F8C0", Offset = "0x484EAC0", VA = "0x18484F8C0")]
	public FHMKIFGOOGK(float BJIGNPGONCG, float IPMJAMPKHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x484F3B0", Offset = "0x484E5B0", VA = "0x18484F3B0")]
	public bool GKEIDGGICDF(float KACBNKCNDPG, T ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x484F670", Offset = "0x484E870", VA = "0x18484F670")]
	public int KCKNCMOHAIC(float KACBNKCNDPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x484F070", Offset = "0x484E270", VA = "0x18484F070")]
	public IEnumerable<T> CLLGDNPJEGD(float KACBNKCNDPG, [Optional] float? HCOMIMCHLLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x484F6D0", Offset = "0x484E8D0", VA = "0x18484F6D0")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x484F800", Offset = "0x484EA00", VA = "0x18484F800")]
	private void PKKKCFKBKML(float KACBNKCNDPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class PKBPOAANIGO<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct MABEHPJDKHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T MDDADGNJOKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float OLEFMHDFHCH;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float GEFCBBLCANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> DGKNNBCHPFA;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int LPDNNOJCCAH = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private MABEHPJDKHK[] NAJOFPKLJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int MGNBKOHJJEE;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float OHGKAEJEPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6B0", Offset = "0x7DA8B0", VA = "0x1807DB6B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6A0", Offset = "0x7DA8A0", VA = "0x1807DB6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x452ECD0", Offset = "0x452DED0", VA = "0x18452ECD0")]
	public PKBPOAANIGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x452EBF0", Offset = "0x452DDF0", VA = "0x18452EBF0")]
	public PKBPOAANIGO(int DFCIFDODMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x452DBB0", Offset = "0x452CDB0", VA = "0x18452DBB0")]
	public void KAGEPJABGKM(float KACBNKCNDPG, T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x452E900", Offset = "0x452DB00", VA = "0x18452E900")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x452DE30", Offset = "0x452D030", VA = "0x18452DE30")]
	public bool LCPMHHNOGEN(float KPPGNLFANEB, float NFMOAOEHJLP, out T ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x452D890", Offset = "0x452CA90", VA = "0x18452D890")]
	public bool ENFEMECFGBI(float KPPGNLFANEB, float NFMOAOEHJLP, out T ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x452E660", Offset = "0x452D860", VA = "0x18452E660")]
	public void LMMFGHNNKMB(float KPPGNLFANEB, float NFMOAOEHJLP, List<T> MNCACBMIHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x452D6C0", Offset = "0x452C8C0", VA = "0x18452D6C0")]
	private int BCOPHIPCPIB(int INMJNBFHMLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x452D6F0", Offset = "0x452C8F0", VA = "0x18452D6F0")]
	private void CDPFCFNHPGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T HIAPOCANOLN();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T HFHKCJHEKNA(T DHAMHGONHGF, T ODBGDMOKIMO, float FOLCGJFJJMP);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T MJPFAMNOKEC(T ADBNEBBHMOP, float FOLCGJFJJMP);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T BGIEEJEEIIB(T DHAMHGONHGF, T ODBGDMOKIMO);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T LMHEKLFDLOD(T DHAMHGONHGF, T ODBGDMOKIMO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ECACMIBIELA : global::PKBPOAANIGO<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x26CB840", Offset = "0x26CAA40", VA = "0x1826CB840", Slot = "4")]
	protected override Vector3 HIAPOCANOLN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x26CB780", Offset = "0x26CA980", VA = "0x1826CB780", Slot = "5")]
	protected override Vector3 HFHKCJHEKNA(Vector3 DHAMHGONHGF, Vector3 ODBGDMOKIMO, float FOLCGJFJJMP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x26CB920", Offset = "0x26CAB20", VA = "0x1826CB920", Slot = "6")]
	protected override Vector3 MJPFAMNOKEC(Vector3 ADBNEBBHMOP, float FOLCGJFJJMP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x26CB6D0", Offset = "0x26CA8D0", VA = "0x1826CB6D0", Slot = "7")]
	protected override Vector3 BGIEEJEEIIB(Vector3 DHAMHGONHGF, Vector3 ODBGDMOKIMO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x26CB8B0", Offset = "0x26CAAB0", VA = "0x1826CB8B0", Slot = "8")]
	protected override Vector3 LMHEKLFDLOD(Vector3 DHAMHGONHGF, Vector3 ODBGDMOKIMO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x26CB9C0", Offset = "0x26CABC0", VA = "0x1826CB9C0")]
	public ECACMIBIELA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HLIOJHAIDLK : global::PKBPOAANIGO<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x26CC180", Offset = "0x26CB380", VA = "0x1826CC180")]
	public HLIOJHAIDLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x26CC110", Offset = "0x26CB310", VA = "0x1826CC110")]
	public HLIOJHAIDLK(int DFCIFDODMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xE21500", Offset = "0xE20700", VA = "0x180E21500", Slot = "4")]
	protected override float HIAPOCANOLN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x26CC080", Offset = "0x26CB280", VA = "0x1826CC080", Slot = "5")]
	protected override float HFHKCJHEKNA(float DHAMHGONHGF, float ODBGDMOKIMO, float FOLCGJFJJMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1D085A0", Offset = "0x1D077A0", VA = "0x181D085A0", Slot = "6")]
	protected override float MJPFAMNOKEC(float ADBNEBBHMOP, float FOLCGJFJJMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xB79930", Offset = "0xB78B30", VA = "0x180B79930", Slot = "7")]
	protected override float BGIEEJEEIIB(float DHAMHGONHGF, float ODBGDMOKIMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x26CC100", Offset = "0x26CB300", VA = "0x1826CC100", Slot = "8")]
	protected override float LMHEKLFDLOD(float DHAMHGONHGF, float ODBGDMOKIMO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JAHHHONCJKA
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3824660", Offset = "0x3823860", VA = "0x183824660")]
	public static global::ANPMMONHANK<T1> CNOGLGNGFED<T1>(T1 MKDGNCIIHKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x428A570", Offset = "0x4289770", VA = "0x18428A570")]
	public static global::PJLKDAAMBAL<T1, T2> CNOGLGNGFED<T1, T2>(T1 MKDGNCIIHKB, T2 DMBCCBCLHAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x398DA70", Offset = "0x398CC70", VA = "0x18398DA70")]
	public static global::JGAJBDGLKIC<T1, T2, T3> CNOGLGNGFED<T1, T2, T3>(T1 MKDGNCIIHKB, T2 DMBCCBCLHAH, T3 EFDAJAMOOGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x398B100", Offset = "0x398A300", VA = "0x18398B100")]
	public static global::PMFPKNMMNHO<T1, T2, T3, T4> CNOGLGNGFED<T1, T2, T3, T4>(T1 MKDGNCIIHKB, T2 DMBCCBCLHAH, T3 EFDAJAMOOGA, T4 ANJBKMFBJNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x428A690", Offset = "0x4289890", VA = "0x18428A690")]
	public static global::OFEGLHLONMK<T1, T2, T3, T4, T5> CNOGLGNGFED<T1, T2, T3, T4, T5>(T1 MKDGNCIIHKB, T2 DMBCCBCLHAH, T3 EFDAJAMOOGA, T4 ANJBKMFBJNE, T5 AFCJDHMAGCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x428A5E0", Offset = "0x42897E0", VA = "0x18428A5E0")]
	public static global::OLGFEGDPFIN<T1, T2, T3, T4, T5, T6> CNOGLGNGFED<T1, T2, T3, T4, T5, T6>(T1 MKDGNCIIHKB, T2 DMBCCBCLHAH, T3 EFDAJAMOOGA, T4 ANJBKMFBJNE, T5 AFCJDHMAGCP, T6 COHJHAJBDNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3A0A090", Offset = "0x3A09290", VA = "0x183A0A090")]
	public static global::BHODPMOALGK<T1, T2, T3, T4, T5, T6, T7> CNOGLGNGFED<T1, T2, T3, T4, T5, T6, T7>(T1 MKDGNCIIHKB, T2 DMBCCBCLHAH, T3 EFDAJAMOOGA, T4 ANJBKMFBJNE, T5 AFCJDHMAGCP, T6 COHJHAJBDNK, T7 BGNKPNBKOHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x398DB00", Offset = "0x398CD00", VA = "0x18398DB00")]
	public static global::JJIILPGJJEF<T1, T2, T3, T4, T5, T6, T7, T8> CNOGLGNGFED<T1, T2, T3, T4, T5, T6, T7, T8>(T1 MKDGNCIIHKB, T2 DMBCCBCLHAH, T3 EFDAJAMOOGA, T4 ANJBKMFBJNE, T5 AFCJDHMAGCP, T6 COHJHAJBDNK, T7 BGNKPNBKOHD, T8 FGLDEEEBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6D60F0", Offset = "0x6D52F0", VA = "0x1806D60F0")]
	[IteratorStateMachine(typeof(LLIDFHGPIHI))]
	public static IEnumerable<global::PJLKDAAMBAL<T1, T2>> JFDONBHEONH<T1, T2>(IEnumerable<T1> PJIOBOBOEGF, IEnumerable<T2> KLGGEDCBMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6D8400", Offset = "0x6D7600", VA = "0x1806D8400")]
	[IteratorStateMachine(typeof(IECAHEJHODL))]
	public static IEnumerable<global::JGAJBDGLKIC<T1, T2, T3>> JFDONBHEONH<T1, T2, T3>(IEnumerable<T1> PJIOBOBOEGF, IEnumerable<T2> KLGGEDCBMPK, IEnumerable<T3> FBCEFPPNKHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x188F480", Offset = "0x188E680", VA = "0x18188F480")]
	internal static int BJNNOIENEPM(int JOFMKJBKHFA, int BNDEGDJOIBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1C44AF0", Offset = "0x1C43CF0", VA = "0x181C44AF0")]
	internal static int BJNNOIENEPM(int JOFMKJBKHFA, int BNDEGDJOIBN, int IAEFPJNDGDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1C44B00", Offset = "0x1C43D00", VA = "0x181C44B00")]
	internal static int BJNNOIENEPM(int JOFMKJBKHFA, int BNDEGDJOIBN, int IAEFPJNDGDE, int DAPHOOKJPDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x26CCCA0", Offset = "0x26CBEA0", VA = "0x1826CCCA0")]
	internal static int BJNNOIENEPM(int JOFMKJBKHFA, int BNDEGDJOIBN, int IAEFPJNDGDE, int DAPHOOKJPDA, int PKIJKCFKOMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x26CCC50", Offset = "0x26CBE50", VA = "0x1826CCC50")]
	internal static int BJNNOIENEPM(int JOFMKJBKHFA, int BNDEGDJOIBN, int IAEFPJNDGDE, int DAPHOOKJPDA, int PKIJKCFKOMH, int PJNIKAFLAOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x26CCC70", Offset = "0x26CBE70", VA = "0x1826CCC70")]
	internal static int BJNNOIENEPM(int JOFMKJBKHFA, int BNDEGDJOIBN, int IAEFPJNDGDE, int DAPHOOKJPDA, int PKIJKCFKOMH, int PJNIKAFLAOK, int OKDEEIKIJDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x26CCCC0", Offset = "0x26CBEC0", VA = "0x1826CCCC0")]
	internal static int BJNNOIENEPM(int JOFMKJBKHFA, int BNDEGDJOIBN, int IAEFPJNDGDE, int DAPHOOKJPDA, int PKIJKCFKOMH, int PJNIKAFLAOK, int OKDEEIKIJDD, int GGIPNIEFKDB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ANPMMONHANK<T1> : IComparable<global::ANPMMONHANK<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 BPAPJJGCOFM;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1343700", Offset = "0x1342900", VA = "0x181343700")]
	public ANPMMONHANK(T1 MKDGNCIIHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4626F30", Offset = "0x4626130", VA = "0x184626F30", Slot = "4")]
	public int CompareTo(global::ANPMMONHANK<T1> GHOINNFPLDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4626FA0", Offset = "0x46261A0", VA = "0x184626FA0", Slot = "0")]
	public override bool Equals(object GHOINNFPLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x973A30", Offset = "0x972C30", VA = "0x180973A30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4627040", Offset = "0x4626240", VA = "0x184627040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PJLKDAAMBAL<T1, T2> : IComparable<global::PJLKDAAMBAL<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 BPAPJJGCOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 KBGEJMIHBBM;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x452BE20", Offset = "0x452B020", VA = "0x18452BE20")]
	public PJLKDAAMBAL(T1 MKDGNCIIHKB, T2 DMBCCBCLHAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4529F60", Offset = "0x4529160", VA = "0x184529F60", Slot = "4")]
	public int CompareTo(global::PJLKDAAMBAL<T1, T2> GHOINNFPLDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x452AA00", Offset = "0x4529C00", VA = "0x18452AA00", Slot = "0")]
	public override bool Equals(object GHOINNFPLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x452B140", Offset = "0x452A340", VA = "0x18452B140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x452B320", Offset = "0x452A520", VA = "0x18452B320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JGAJBDGLKIC<T1, T2, T3> : IComparable<global::JGAJBDGLKIC<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 BPAPJJGCOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 KBGEJMIHBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 KFMCBHGGINO;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x46B7E20", Offset = "0x46B7020", VA = "0x1846B7E20")]
	public JGAJBDGLKIC(T1 MKDGNCIIHKB, T2 DMBCCBCLHAH, T3 EFDAJAMOOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x46B7740", Offset = "0x46B6940", VA = "0x1846B7740", Slot = "4")]
	public int CompareTo(global::JGAJBDGLKIC<T1, T2, T3> GHOINNFPLDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x46B7840", Offset = "0x46B6A40", VA = "0x1846B7840", Slot = "0")]
	public override bool Equals(object GHOINNFPLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x46B7AA0", Offset = "0x46B6CA0", VA = "0x1846B7AA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x46B7C90", Offset = "0x46B6E90", VA = "0x1846B7C90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class PMFPKNMMNHO<T1, T2, T3, T4> : IComparable<global::PMFPKNMMNHO<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 BPAPJJGCOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 KBGEJMIHBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 KFMCBHGGINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 JNKCHHMBALC;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x452EF90", Offset = "0x452E190", VA = "0x18452EF90")]
	public PMFPKNMMNHO(T1 MKDGNCIIHKB, T2 DMBCCBCLHAH, T3 EFDAJAMOOGA, T4 ANJBKMFBJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x452F8B0", Offset = "0x452EAB0", VA = "0x18452F8B0", Slot = "4")]
	public int CompareTo(global::PMFPKNMMNHO<T1, T2, T3, T4> GHOINNFPLDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x452F9F0", Offset = "0x452EBF0", VA = "0x18452F9F0", Slot = "0")]
	public override bool Equals(object GHOINNFPLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x452FB10", Offset = "0x452ED10", VA = "0x18452FB10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x452FBD0", Offset = "0x452EDD0", VA = "0x18452FBD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OFEGLHLONMK<T1, T2, T3, T4, T5> : IComparable<global::OFEGLHLONMK<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 BPAPJJGCOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 KBGEJMIHBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 KFMCBHGGINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 JNKCHHMBALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 AKBNDPADLPE;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1E09080", Offset = "0x1E08280", VA = "0x181E09080")]
	public OFEGLHLONMK(T1 MKDGNCIIHKB, T2 DMBCCBCLHAH, T3 EFDAJAMOOGA, T4 ANJBKMFBJNE, T5 AFCJDHMAGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1E08B90", Offset = "0x1E07D90", VA = "0x181E08B90", Slot = "4")]
	public int CompareTo(global::OFEGLHLONMK<T1, T2, T3, T4, T5> GHOINNFPLDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1E08D10", Offset = "0x1E07F10", VA = "0x181E08D10", Slot = "0")]
	public override bool Equals(object GHOINNFPLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1E08E50", Offset = "0x1E08050", VA = "0x181E08E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1E08F50", Offset = "0x1E08150", VA = "0x181E08F50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OLGFEGDPFIN<T1, T2, T3, T4, T5, T6> : IComparable<global::OLGFEGDPFIN<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 BPAPJJGCOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 KBGEJMIHBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 KFMCBHGGINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 JNKCHHMBALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 AKBNDPADLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 KGIJKNDHDMD;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3ECC9B0", Offset = "0x3ECBBB0", VA = "0x183ECC9B0")]
	public OLGFEGDPFIN(T1 MKDGNCIIHKB, T2 DMBCCBCLHAH, T3 EFDAJAMOOGA, T4 ANJBKMFBJNE, T5 AFCJDHMAGCP, T6 COHJHAJBDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3ECC410", Offset = "0x3ECB610", VA = "0x183ECC410", Slot = "4")]
	public int CompareTo(global::OLGFEGDPFIN<T1, T2, T3, T4, T5, T6> GHOINNFPLDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3ECC5D0", Offset = "0x3ECB7D0", VA = "0x183ECC5D0", Slot = "0")]
	public override bool Equals(object GHOINNFPLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3ECC740", Offset = "0x3ECB940", VA = "0x183ECC740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3ECC860", Offset = "0x3ECBA60", VA = "0x183ECC860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BHODPMOALGK<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::BHODPMOALGK<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 BPAPJJGCOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 KBGEJMIHBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 KFMCBHGGINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 JNKCHHMBALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 AKBNDPADLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 KGIJKNDHDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 DGPKJKCPJJJ;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4238BC0", Offset = "0x4237DC0", VA = "0x184238BC0")]
	public BHODPMOALGK(T1 MKDGNCIIHKB, T2 DMBCCBCLHAH, T3 EFDAJAMOOGA, T4 ANJBKMFBJNE, T5 AFCJDHMAGCP, T6 COHJHAJBDNK, T7 BGNKPNBKOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4238560", Offset = "0x4237760", VA = "0x184238560", Slot = "4")]
	public int CompareTo(global::BHODPMOALGK<T1, T2, T3, T4, T5, T6, T7> GHOINNFPLDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4238760", Offset = "0x4237960", VA = "0x184238760", Slot = "0")]
	public override bool Equals(object GHOINNFPLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4238900", Offset = "0x4237B00", VA = "0x184238900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4238A50", Offset = "0x4237C50", VA = "0x184238A50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JJIILPGJJEF<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::JJIILPGJJEF<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 BPAPJJGCOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 KBGEJMIHBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 KFMCBHGGINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 JNKCHHMBALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 AKBNDPADLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 KGIJKNDHDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 DGPKJKCPJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 DJMHEOJJLJP;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1F10230", Offset = "0x1F0F430", VA = "0x181F10230")]
	public JJIILPGJJEF(T1 MKDGNCIIHKB, T2 DMBCCBCLHAH, T3 EFDAJAMOOGA, T4 ANJBKMFBJNE, T5 AFCJDHMAGCP, T6 COHJHAJBDNK, T7 BGNKPNBKOHD, T8 FGLDEEEBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1F0FB20", Offset = "0x1F0ED20", VA = "0x181F0FB20", Slot = "4")]
	public int CompareTo(global::JJIILPGJJEF<T1, T2, T3, T4, T5, T6, T7, T8> GHOINNFPLDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1F0FD70", Offset = "0x1F0EF70", VA = "0x181F0FD70", Slot = "0")]
	public override bool Equals(object GHOINNFPLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1F0FF30", Offset = "0x1F0F130", VA = "0x181F0FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1F100A0", Offset = "0x1F0F2A0", VA = "0x181F100A0", Slot = "3")]
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
	public T MDDADGNJOKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x734270", Offset = "0x733470", VA = "0x180734270")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7D6460", Offset = "0x7D5660", VA = "0x1807D6460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float JPPEAKBGPBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA82520", Offset = "0xA81720", VA = "0x180A82520")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4D12B60", Offset = "0x4D11D60", VA = "0x184D12B60")]
	public T FLOHOCDKJGA(float FOLCGJFJJMP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4D12E70", Offset = "0x4D12070", VA = "0x184D12E70")]
	public T NOJCBELBIPN(float FOLCGJFJJMP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T HFHKCJHEKNA(T DHAMHGONHGF, T ODBGDMOKIMO, float FOLCGJFJJMP);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x26CBE30", Offset = "0x26CB030", VA = "0x1826CBE30", Slot = "4")]
	protected override float HFHKCJHEKNA(float DHAMHGONHGF, float ODBGDMOKIMO, float FOLCGJFJJMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x26CBEB0", Offset = "0x26CB0B0", VA = "0x1826CBEB0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x26D4A90", Offset = "0x26D3C90", VA = "0x1826D4A90", Slot = "4")]
	protected override Vector3 HFHKCJHEKNA(Vector3 DHAMHGONHGF, Vector3 ODBGDMOKIMO, float FOLCGJFJJMP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x26D4B50", Offset = "0x26D3D50", VA = "0x1826D4B50")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x26CAFC0", Offset = "0x26CA1C0", VA = "0x1826CAFC0", Slot = "4")]
	protected override Color HFHKCJHEKNA(Color DHAMHGONHGF, Color ODBGDMOKIMO, float FOLCGJFJJMP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x26CB010", Offset = "0x26CA210", VA = "0x1826CB010")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GGLHEMILAJC : global::IOFCMOFAJIE<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x26CBFC0", Offset = "0x26CB1C0", VA = "0x1826CBFC0")]
	public GGLHEMILAJC(int GOCCOAPEHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x26CBF60", Offset = "0x26CB160", VA = "0x1826CBF60")]
	public GGLHEMILAJC(GMFFNIMNEKA[] GDAIIMHJJBJ, bool FHAAEOAEPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x26CBEF0", Offset = "0x26CB0F0", VA = "0x1826CBEF0", Slot = "6")]
	protected override uint JGINEIJDCPL(uint HGCLPJPLDLN, string ADBNEBBHMOP)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NCPEKNIENAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public NCPEKNIENAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DebuggerTypeProxy(typeof(global::LCBLLODEHKA<>.OLADHKFBAID))]
[DefaultMember("Item")]
public sealed class LCBLLODEHKA<T> : IDisposable, global::DMBLADBHILG<T>, PAEOMNDDDKI, global::CONBNEAOHLD<T, global::LCBLLODEHKA<T>.OIACLNBGNMK>, global::EGJDHGKNEFG<T>, global::FFKMMEJPBGC<T, global::LCBLLODEHKA<T>.OIACLNBGNMK>, global::KCCNHJKNACL<T>, global::PCNGBKGMJLN<T, global::LCBLLODEHKA<T>.OIACLNBGNMK>, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct OIACLNBGNMK : PAEOMNDDDKI, global::EOHJBOPFHML<T>, global::CJLLEHHANFJ<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly global::LCBLLODEHKA<T> DMFCGEBKMOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private int JLOLLFHGPON;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int NAIIACDHEPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x1F7C760", Offset = "0x1F7B960", VA = "0x181F7C760", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public T EGCCHNLJPLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x21AD9F0", Offset = "0x21ACBF0", VA = "0x1821AD9F0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private T HGGAPLJFNOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x21AD200", Offset = "0x21AC400", VA = "0x1821AD200", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x21AD520", Offset = "0x21AC720", VA = "0x1821AD520", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x21AD7E0", Offset = "0x21AC9E0", VA = "0x1821AD7E0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x17D4F90", Offset = "0x17D4190", VA = "0x1817D4F90")]
		private OIACLNBGNMK(global::LCBLLODEHKA<T> BJFNBIEJBCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x1345D50", Offset = "0x1344F50", VA = "0x181345D50")]
		public static OIACLNBGNMK HCEINCHCOLK(global::LCBLLODEHKA<T> BJFNBIEJBCK)
		{
			return default(OIACLNBGNMK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x21AD380", Offset = "0x21AC580", VA = "0x1821AD380", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1345DE0", Offset = "0x1344FE0", VA = "0x181345DE0", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class OLADHKFBAID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly global::LCBLLODEHKA<T> DMFCGEBKMOP;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public int NAIIACDHEPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xF2A9C0", Offset = "0xF29BC0", VA = "0x180F2A9C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public T[] CFGJIEBBIFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x21ADAE0", Offset = "0x21ACCE0", VA = "0x1821ADAE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool DBJPCLELEGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x21ADBA0", Offset = "0x21ACDA0", VA = "0x1821ADBA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x1343700", Offset = "0x1342900", VA = "0x181343700")]
		public OLADHKFBAID(global::LCBLLODEHKA<T> BJFNBIEJBCK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly BEJDGKOPDGE JPNIGGNEPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private T[] MGKNDECDGAF;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x610600", Offset = "0x60F800", VA = "0x180610600", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7CF0F0", Offset = "0x7CE2F0", VA = "0x1807CF0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Span<T> CFGJIEBBIFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x21A7140", Offset = "0x21A6340", VA = "0x1821A7140")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T CJFAJFAJLNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x21A5020", Offset = "0x21A4220", VA = "0x1821A5020")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T BLAHADPOAPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x21A5020", Offset = "0x21A4220", VA = "0x1821A5020")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public T LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x21A8480", Offset = "0x21A7680", VA = "0x1821A8480")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x21A5CF0", Offset = "0x21A4EF0", VA = "0x1821A5CF0")]
	public static global::LCBLLODEHKA<T> HCEINCHCOLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x21A6400", Offset = "0x21A5600", VA = "0x1821A6400")]
	public static global::LCBLLODEHKA<T> LLOOJNBJJML(int GOCCOAPEHDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x21A8830", Offset = "0x21A7A30", VA = "0x1821A8830")]
	internal LCBLLODEHKA(T[] FHGHECKKPID, int AEKEPEKODMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x21A7C60", Offset = "0x21A6E60", VA = "0x1821A7C60", Slot = "5")]
	public T NMEKMIHCNFD(int OCLFFJGEIJK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x21A4FA0", Offset = "0x21A41A0", VA = "0x1821A4FA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x21A6010", Offset = "0x21A5210", VA = "0x1821A6010")]
	public void KAGEPJABGKM(in T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x21A8020", Offset = "0x21A7220", VA = "0x1821A8020")]
	public void OANFOENKONO(int MJNAIOAAGCG, in T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x21A5080", Offset = "0x21A4280", VA = "0x1821A5080")]
	public void GEKNCFKGFNI(int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x21A4B60", Offset = "0x21A3D60", VA = "0x1821A4B60")]
	public void DPAALGJDGOJ(int DFCIFDODMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x21A5830", Offset = "0x21A4A30", VA = "0x1821A5830")]
	private void GFBBAIKPDNM(int GOCCOAPEHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x21A7C30", Offset = "0x21A6E30", VA = "0x1821A7C30")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x21A6A80", Offset = "0x21A5C80", VA = "0x1821A6A80")]
	public global::LCBLLODEHKA<T> LOINOKKOFKF(global::MIMFAPJNEIA<T, T> PKKIPCLHPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x21A5CB0", Offset = "0x21A4EB0", VA = "0x1821A5CB0", Slot = "11")]
	public OIACLNBGNMK GetEnumerator()
	{
		return default(OIACLNBGNMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x21A4320", Offset = "0x21A3520", VA = "0x1821A4320", Slot = "8")]
	private global::EOHJBOPFHML<T> FMABCJOACKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x21A4320", Offset = "0x21A3520", VA = "0x1821A4320", Slot = "10")]
	private global::CJLLEHHANFJ<T> CLEKDCFPCEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x21A4320", Offset = "0x21A3520", VA = "0x1821A4320", Slot = "12")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x21A4320", Offset = "0x21A3520", VA = "0x1821A4320", Slot = "13")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class LNEKGDAOGEF
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3ADA560", Offset = "0x3AD9760", VA = "0x183ADA560")]
	public static bool LHEPJGNGIJE<T>(this global::LCBLLODEHKA<T> BJFNBIEJBCK, in T ADBNEBBHMOP) where T : global::KAGDCAKBEHF<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct IDFEDPCBBCB
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class COCEHPHDBKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public TaskCompletionSource<JMNHLBPPELC> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public COCEHPHDBKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x26CAF70", Offset = "0x26CA170", VA = "0x1826CAF70")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<JMNHLBPPELC>> HIBDGIKLHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private int MFHGBNLNLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int MMCCABPGODA;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0xEEA950", Offset = "0xEE9B50", VA = "0x180EEA950")]
	private IDFEDPCBBCB(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<JMNHLBPPELC>> OMFLILMKKBI, int LDBNPDHCECM, int MGGEMHPGBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x26CC1E0", Offset = "0x26CB3E0", VA = "0x1826CC1E0")]
	public static IDFEDPCBBCB HCEINCHCOLK()
	{
		return default(IDFEDPCBBCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x26CC260", Offset = "0x26CB460", VA = "0x1826CC260")]
	public (int, int, Task) JNFGJABIPHC(int FDPPFMAFMMG, [Optional] CancellationToken GENHLOEKMNL)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x26CC5B0", Offset = "0x26CB7B0", VA = "0x1826CC5B0")]
	public void MBKLLOPCMPL(int FDPPFMAFMMG, int MGGEMHPGBME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class HCAKPDBECHN<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly Dictionary<TKey, TVal> KHDJDPGPLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<TVal, TKey> IOOBBEPDFIA;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xF2A9C0", Offset = "0xF29BC0", VA = "0x180F2A9C0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool BNGNOGOPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ICollection<TKey> KEDDEBFFHED
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1F72FA0", Offset = "0x1F721A0", VA = "0x181F72FA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public ICollection<TVal> PJHDBPJEPNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1CC57C0", Offset = "0x1CC49C0", VA = "0x181CC57C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public TVal LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1CCA440", Offset = "0x1CC9640", VA = "0x181CCA440", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2410", Offset = "0x3AB1610", VA = "0x183AB2410", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public TKey LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2200", Offset = "0x3AB1400", VA = "0x183AB2200")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3AB1DE0", Offset = "0x3AB0FE0", VA = "0x183AB1DE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3AB17B0", Offset = "0x3AB09B0", VA = "0x183AB17B0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2290", Offset = "0x3AB1490", VA = "0x183AB2290", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1720", Offset = "0x3AB0920", VA = "0x183AB1720", Slot = "9")]
	public void Add(TKey JCNAPFOCJDI, TVal ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1750", Offset = "0x3AB0950", VA = "0x183AB1750", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> BCDFAIJCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1810", Offset = "0x3AB0A10", VA = "0x183AB1810", Slot = "8")]
	public bool ContainsKey(TKey JCNAPFOCJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1CC5B90", Offset = "0x1CC4D90", VA = "0x181CC5B90", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> BCDFAIJCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2230", Offset = "0x3AB1430", VA = "0x183AB2230", Slot = "10")]
	public bool Remove(TKey JCNAPFOCJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2230", Offset = "0x3AB1430", VA = "0x183AB2230", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> BCDFAIJCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x1E064A0", Offset = "0x1E056A0", VA = "0x181E064A0", Slot = "11")]
	public bool TryGetValue(TKey JCNAPFOCJDI, out TVal ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1CE0", Offset = "0x3AB0EE0", VA = "0x183AB1CE0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1870", Offset = "0x3AB0A70", VA = "0x183AB1870", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] NAJOFPKLJJG, int LEAMOGPCOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1FA0", Offset = "0x3AB11A0", VA = "0x183AB1FA0")]
	public void KAGEPJABGKM(TVal AKJAPNHANKH, TKey JCNAPFOCJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1EF0", Offset = "0x3AB10F0", VA = "0x183AB1EF0")]
	public void KAGEPJABGKM(KeyValuePair<TVal, TKey> BCDFAIJCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1E90", Offset = "0x3AB1090", VA = "0x183AB1E90")]
	public bool HLPFPKFLNFA(TVal JCNAPFOCJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1E083B0", Offset = "0x1E075B0", VA = "0x181E083B0")]
	public bool HIPEHFAIGLD(KeyValuePair<TVal, TKey> BCDFAIJCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x39F1F00", Offset = "0x39F1100", VA = "0x1839F1F00")]
	public bool CEDMIKNCMLN(TVal JCNAPFOCJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x39F1F00", Offset = "0x39F1100", VA = "0x1839F1F00")]
	public bool CEDMIKNCMLN(KeyValuePair<TVal, TKey> BCDFAIJCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1EC0", Offset = "0x3AB10C0", VA = "0x183AB1EC0")]
	public bool HNIJFJOBNMJ(TVal JCNAPFOCJDI, out TKey ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2070", Offset = "0x3AB1270", VA = "0x183AB2070")]
	public IEnumerator<KeyValuePair<TVal, TKey>> LOIJHHOPBGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2180", Offset = "0x3AB1380", VA = "0x183AB2180")]
	private void MONAJOKGGJG(TKey JCNAPFOCJDI, TVal AKJAPNHANKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1960", Offset = "0x3AB0B60", VA = "0x183AB1960")]
	private void DOKBHABJEJP(TKey JCNAPFOCJDI, TVal AKJAPNHANKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3AB19E0", Offset = "0x3AB0BE0", VA = "0x183AB19E0")]
	private bool FNOCDAPJIIO(TKey JCNAPFOCJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1C20", Offset = "0x3AB0E20", VA = "0x183AB1C20")]
	private bool FNOCDAPJIIO(TVal AKJAPNHANKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2330", Offset = "0x3AB1530", VA = "0x183AB2330")]
	public HCAKPDBECHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class JCBBEMNCBBH<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private global::JCBBEMNCBBH<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7DB6B0", Offset = "0x7DA8B0", VA = "0x1807DB6B0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x46AB1F0", Offset = "0x46AA3F0", VA = "0x1846AB1F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x46AB4F0", Offset = "0x46AA6F0", VA = "0x1846AB4F0")]
		public Enumerator(global::JCBBEMNCBBH<T> MNCACBMIHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x46AAA70", Offset = "0x46A9C70", VA = "0x1846AAA70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x46AAEB0", Offset = "0x46AA0B0", VA = "0x1846AAEB0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x46AA730", Offset = "0x46A9930", VA = "0x1846AA730")]
		private void KEHCEDCCDNP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private T[] DBJAENPKIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private int KKDHFPHHHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private int IHFIGFEOJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private int BCHFMCCIDMH;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x46AE5E0", Offset = "0x46AD7E0", VA = "0x1846AE5E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public T LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x46AFEF0", Offset = "0x46AF0F0", VA = "0x1846AFEF0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x46AE8F0", Offset = "0x46ADAF0", VA = "0x1846AE8F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x46B0210", Offset = "0x46AF410", VA = "0x1846B0210")]
	public JCBBEMNCBBH(int GOCCOAPEHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x46AFB60", Offset = "0x46AED60", VA = "0x1846AFB60")]
	public void KAGEPJABGKM(T FOLCGJFJJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x46AEC70", Offset = "0x46ADE70", VA = "0x1846AEC70")]
	public void HBOOAGEADLM(IEnumerable<T> BDGFDBONONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x46AFE50", Offset = "0x46AF050", VA = "0x1846AFE50")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x46AE190", Offset = "0x46AD390", VA = "0x1846AE190")]
	public void AKIPDLFMFFI(int AEKEPEKODMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x46AF590", Offset = "0x46AE790", VA = "0x1846AF590")]
	public void IAAFGPDJBHE(int AEKEPEKODMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x46AF8C0", Offset = "0x46AEAC0", VA = "0x1846AF8C0")]
	public void INFFHPJLHHE(T[] NAJOFPKLJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x46AE710", Offset = "0x46AD910", VA = "0x1846AE710")]
	public Enumerator ENNIMPBLHKI()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x46B0020", Offset = "0x46AF220", VA = "0x1846B0020", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x46B0020", Offset = "0x46AF220", VA = "0x1846B0020", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x46AE400", Offset = "0x46AD600", VA = "0x1846AE400")]
	private int BOIHAHEGFOF(int MJNAIOAAGCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x46AFFF0", Offset = "0x46AF1F0", VA = "0x1846AFFF0")]
	private int ODEOBGCFGGH(int MJNAIOAAGCG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct BPHDDDPIBNM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly IDisposable[] MGKNDECDGAF;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8EF1D0", Offset = "0x8EE3D0", VA = "0x1808EF1D0")]
	public BPHDDDPIBNM(params IDisposable[] FHGHECKKPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8ECD40", Offset = "0x8EBF40", VA = "0x1808ECD40")]
	public static BPHDDDPIBNM HCEINCHCOLK(params IDisposable[] FHGHECKKPID)
	{
		return default(BPHDDDPIBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x26CAC70", Offset = "0x26C9E70", VA = "0x1826CAC70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct KIIFDNKCEJN<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IDisposable CODPGIGHGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public T MDDADGNJOKH;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1343630", Offset = "0x1342830", VA = "0x181343630")]
	public KIIFDNKCEJN(IDisposable GBCHFDDLKJO, in T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8F20", Offset = "0x3CB8120", VA = "0x183CB8F20")]
	public static global::KIIFDNKCEJN<U> ADNKJCENEEF<U>(in global::KIIFDNKCEJN<T> GBCHFDDLKJO, in U ADBNEBBHMOP)
	{
		return default(global::KIIFDNKCEJN<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3839D90", Offset = "0x3838F90", VA = "0x183839D90")]
	public global::KIIFDNKCEJN<U> FGOMJJOMCEG<U>(in U ADBNEBBHMOP)
	{
		return default(global::KIIFDNKCEJN<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8F60", Offset = "0x3CB8160", VA = "0x183CB8F60")]
	public static global::KIIFDNKCEJN<(T, U)> IOOFFIOAGNI<U>(in global::KIIFDNKCEJN<T> PJIOBOBOEGF, in global::KIIFDNKCEJN<U> KLGGEDCBMPK)
	{
		return default(global::KIIFDNKCEJN<(T, U)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x13434D0", Offset = "0x13426D0", VA = "0x1813434D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class NEAHHMPFGNB
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3CBCEF0", Offset = "0x3CBC0F0", VA = "0x183CBCEF0")]
	public static global::KIIFDNKCEJN<T> HCEINCHCOLK<T>(IDisposable GBCHFDDLKJO, in T ADBNEBBHMOP)
	{
		return default(global::KIIFDNKCEJN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3839D90", Offset = "0x3838F90", VA = "0x183839D90")]
	public static global::KIIFDNKCEJN<U> ADNKJCENEEF<U, T>(in global::KIIFDNKCEJN<T> KMJBDGGIGGL, in U ADBNEBBHMOP)
	{
		return default(global::KIIFDNKCEJN<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3839D00", Offset = "0x3838F00", VA = "0x183839D00")]
	public static global::KIIFDNKCEJN<(T, U)> IOOFFIOAGNI<T, U>(in global::KIIFDNKCEJN<T> PJIOBOBOEGF, in global::KIIFDNKCEJN<U> KLGGEDCBMPK)
	{
		return default(global::KIIFDNKCEJN<(T, U)>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct BEJDGKOPDGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270")]
	public static BEJDGKOPDGE EPFIPEGMDAC<T>([Optional] string PEGPMDFKDMB, [Optional] string CNKHEJGOIGI, bool NPKMCICPBJK = false)
	{
		return default(BEJDGKOPDGE);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public readonly struct ICOBDKPNEDE<T> : global::FFKMMEJPBGC<T, global::ICOBDKPNEDE<T>.DCPGMBGHKLN>, global::KCCNHJKNACL<T>, global::PCNGBKGMJLN<T, global::ICOBDKPNEDE<T>.DCPGMBGHKLN>, IEnumerable<T>, IEnumerable, global::DMBLADBHILG<T>, PAEOMNDDDKI
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct DCPGMBGHKLN : PAEOMNDDDKI, global::CJLLEHHANFJ<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly T[] DMFCGEBKMOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int JLOLLFHGPON;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int NAIIACDHEPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xAEE550", Offset = "0xAED750", VA = "0x180AEE550", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public T EGCCHNLJPLC
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x1345E40", Offset = "0x1345040", VA = "0x181345E40", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x1345DF0", Offset = "0x1344FF0", VA = "0x181345DF0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x1345DF0", Offset = "0x1344FF0", VA = "0x181345DF0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xC4FDD0", Offset = "0xC4EFD0", VA = "0x180C4FDD0")]
		private DCPGMBGHKLN(T[] BJFNBIEJBCK, int MJNAIOAAGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1345D50", Offset = "0x1344F50", VA = "0x181345D50")]
		public static DCPGMBGHKLN HCEINCHCOLK(T[] BJFNBIEJBCK)
		{
			return default(DCPGMBGHKLN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x1345DB0", Offset = "0x1344FB0", VA = "0x181345DB0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x1345DE0", Offset = "0x1344FE0", VA = "0x181345DE0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly T[] OAFEGCNLIJH;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int IPIKHFMIGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xAEE550", Offset = "0xAED750", VA = "0x180AEE550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x133E3C0", Offset = "0x133D5C0", VA = "0x18133E3C0", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public T LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x133E740", Offset = "0x133D940", VA = "0x18133E740")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x8EF1D0", Offset = "0x8EE3D0", VA = "0x1808EF1D0")]
	internal ICOBDKPNEDE(T[] NAJOFPKLJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x133E680", Offset = "0x133D880", VA = "0x18133E680")]
	public static global::ICOBDKPNEDE<T> NPKBEJHDJME()
	{
		return default(global::ICOBDKPNEDE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x133E620", Offset = "0x133D820", VA = "0x18133E620", Slot = "9")]
	public T NMEKMIHCNFD(int MJNAIOAAGCG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x41138A0", Offset = "0x4112AA0", VA = "0x1841138A0", Slot = "6")]
	public DCPGMBGHKLN GetEnumerator()
	{
		return default(DCPGMBGHKLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x41137A0", Offset = "0x41129A0", VA = "0x1841137A0", Slot = "5")]
	private global::CJLLEHHANFJ<T> CLEKDCFPCEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x41137A0", Offset = "0x41129A0", VA = "0x1841137A0", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x41137A0", Offset = "0x41129A0", VA = "0x1841137A0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class MILNDFEJCHK
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3993A00", Offset = "0x3992C00", VA = "0x183993A00")]
	public static global::ICOBDKPNEDE<T> HCEINCHCOLK<T>(T[] NAJOFPKLJJG)
	{
		return default(global::ICOBDKPNEDE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x1937DE0", Offset = "0x1936FE0", VA = "0x181937DE0")]
	public static global::ICOBDKPNEDE<T> GMHPPKHPBLI<T>(this T[] BJFNBIEJBCK)
	{
		return default(global::ICOBDKPNEDE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x387EB90", Offset = "0x387DD90", VA = "0x18387EB90")]
	public static global::ICOBDKPNEDE<T>.DCPGMBGHKLN PAPPDJFEBHA<T>(this T[] BJFNBIEJBCK)
	{
		return default(global::ICOBDKPNEDE<T>.DCPGMBGHKLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x1937DE0", Offset = "0x1936FE0", VA = "0x181937DE0")]
	public static global::ICOBDKPNEDE<T> LDINHKAAIOL<T>(this T[] BJFNBIEJBCK)
	{
		return default(global::ICOBDKPNEDE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct KNGPKPDAFHE<T, U> : global::FFKMMEJPBGC<T, U>, global::KCCNHJKNACL<T>, global::PCNGBKGMJLN<T, U>, IEnumerable<T>, IEnumerable where U : global::CJLLEHHANFJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly U GHOIFCGFEPA;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0xE94B80", Offset = "0xE93D80", VA = "0x180E94B80")]
	internal KNGPKPDAFHE(in U FCHPKFGDGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x72F660", Offset = "0x72E860", VA = "0x18072F660", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0xF395C0", Offset = "0xF387C0", VA = "0x180F395C0", Slot = "5")]
	private global::CJLLEHHANFJ<T> CLEKDCFPCEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0xF395C0", Offset = "0xF387C0", VA = "0x180F395C0", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0xF395C0", Offset = "0xF387C0", VA = "0x180F395C0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class NBBKEMEMCML<T>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3A07B40", Offset = "0x3A06D40", VA = "0x183A07B40")]
	public static global::KNGPKPDAFHE<T, U> HCEINCHCOLK<U>(in U FCHPKFGDGGN) where U : global::CJLLEHHANFJ<T>
	{
		return default(global::KNGPKPDAFHE<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class DHENGGHMBLF<TResult, TResultEnumerator> where TResultEnumerator : global::CJLLEHHANFJ<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3A071A0", Offset = "0x3A063A0", VA = "0x183A071A0")]
	public static global::ACKDBFEJIEL<TSourceEnumerator, TResultEnumerator, TResult> DCCPJCMHPJJ<TSourceEnumerator>(in TSourceEnumerator BJFNBIEJBCK) where TSourceEnumerator : IEnumerator<TResultEnumerator>
	{
		return default(global::ACKDBFEJIEL<TSourceEnumerator, TResultEnumerator, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct ACKDBFEJIEL<TSourceEnumerator, TResultEnumerator, TResult> : global::CJLLEHHANFJ<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : IEnumerator<TResultEnumerator> where TResultEnumerator : global::CJLLEHHANFJ<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private TSourceEnumerator DMFCGEBKMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private TResultEnumerator ONFNBLBNBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool ICIFOKACLNM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public TResult EGCCHNLJPLC
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x37E39D0", Offset = "0x37E2BD0", VA = "0x1837E39D0", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x37E3930", Offset = "0x37E2B30", VA = "0x1837E3930", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x37E3930", Offset = "0x37E2B30", VA = "0x1837E3930", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x37E3980", Offset = "0x37E2B80", VA = "0x1837E3980")]
	internal ACKDBFEJIEL(in TSourceEnumerator BJFNBIEJBCK, in TResultEnumerator CMAEDKIMLCK, bool NOCLPOBJBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x37E37B0", Offset = "0x37E29B0", VA = "0x1837E37B0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x37E38E0", Offset = "0x37E2AE0", VA = "0x1837E38E0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x37E3760", Offset = "0x37E2960", VA = "0x1837E3760", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct EODGLLBJOOP<TSourceEnumerator, TSource, TResult> : PAEOMNDDDKI, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : PAEOMNDDDKI, global::CJLLEHHANFJ<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private TSourceEnumerator DMFCGEBKMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly global::MIMFAPJNEIA<TSource, TResult> GJNCGPFJIOI;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4788850", Offset = "0x4787A50", VA = "0x184788850", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public TResult EGCCHNLJPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x47892A0", Offset = "0x47884A0", VA = "0x1847892A0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x4788FD0", Offset = "0x47881D0", VA = "0x184788FD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3BF4170", Offset = "0x3BF3370", VA = "0x183BF4170")]
	internal EODGLLBJOOP(in TSourceEnumerator BJFNBIEJBCK, global::MIMFAPJNEIA<TSource, TResult> MMJPJBIPBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4788C60", Offset = "0x4787E60", VA = "0x184788C60", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4788DA0", Offset = "0x4787FA0", VA = "0x184788DA0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4788A80", Offset = "0x4787C80", VA = "0x184788A80", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct FHCLPDPLMDH<TSourceEnumerator, TSource, TResultEnumerator, TResult> : global::CJLLEHHANFJ<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : global::CJLLEHHANFJ<TSource> where TResultEnumerator : global::CJLLEHHANFJ<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private TSourceEnumerator DMFCGEBKMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private TResultEnumerator ONFNBLBNBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly global::MIMFAPJNEIA<TSource, TResultEnumerator> GJNCGPFJIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool ICIFOKACLNM;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TResult EGCCHNLJPLC
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x484ECC0", Offset = "0x484DEC0", VA = "0x18484ECC0", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x484EBD0", Offset = "0x484DDD0", VA = "0x18484EBD0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x484EBD0", Offset = "0x484DDD0", VA = "0x18484EBD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x484EC60", Offset = "0x484DE60", VA = "0x18484EC60")]
	internal FHCLPDPLMDH(in TSourceEnumerator BJFNBIEJBCK, in TResultEnumerator CMAEDKIMLCK, global::MIMFAPJNEIA<TSource, TResultEnumerator> MMJPJBIPBNN, bool NOCLPOBJBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x484E9F0", Offset = "0x484DBF0", VA = "0x18484E9F0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x484EB80", Offset = "0x484DD80", VA = "0x18484EB80", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x484E9A0", Offset = "0x484DBA0", VA = "0x18484E9A0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct EHAJABIFCBN<TSource1Enumerator, TSource1, TSource2Enumerator, TSource2> : PAEOMNDDDKI, IEnumerator<(TSource1, TSource2)>, IEnumerator, IDisposable where TSource1Enumerator : PAEOMNDDDKI, global::CJLLEHHANFJ<TSource1> where TSource2Enumerator : PAEOMNDDDKI, global::CJLLEHHANFJ<TSource2>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private TSource1Enumerator APLHCIJPPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private TSource2Enumerator MBALKIEPPID;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x4E34FD0", Offset = "0x4E341D0", VA = "0x184E34FD0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public (TSource1, TSource2) EGCCHNLJPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x4E35250", Offset = "0x4E34450", VA = "0x184E35250", Slot = "5")]
		get
		{
			return default((TSource1, TSource2));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x4E351B0", Offset = "0x4E343B0", VA = "0x184E351B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x457D6D0", Offset = "0x457C8D0", VA = "0x18457D6D0")]
	internal EHAJABIFCBN(in TSource1Enumerator DDDAAFLILIE, in TSource2Enumerator MNDNDIKDBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x4E350D0", Offset = "0x4E342D0", VA = "0x184E350D0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x4E35140", Offset = "0x4E34340", VA = "0x184E35140", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x4E35070", Offset = "0x4E34270", VA = "0x184E35070", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct NGDAFOKHPCE<T, U> : global::PCNGBKGMJLN<T, U>, IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly U GHOIFCGFEPA;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0xF39690", Offset = "0xF38890", VA = "0x180F39690")]
	internal NGDAFOKHPCE(in U FCHPKFGDGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0xF39520", Offset = "0xF38720", VA = "0x180F39520", Slot = "4")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0xF395F0", Offset = "0xF387F0", VA = "0x180F395F0", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0xF395F0", Offset = "0xF387F0", VA = "0x180F395F0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class IPMNLAKFPJC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x428A4E0", Offset = "0x42896E0", VA = "0x18428A4E0")]
	public static global::NGDAFOKHPCE<T, U> HCEINCHCOLK<U>(in U FCHPKFGDGGN) where U : IEnumerator<T>
	{
		return default(global::NGDAFOKHPCE<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct APOOBGBBBBG<TSourceEnumerator, TSource, TResult> : PAEOMNDDDKI, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : PAEOMNDDDKI, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private TSourceEnumerator DMFCGEBKMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Func<TSource, TResult> GJNCGPFJIOI;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x4627160", Offset = "0x4626360", VA = "0x184627160", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public TResult EGCCHNLJPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x4627340", Offset = "0x4626540", VA = "0x184627340", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4627300", Offset = "0x4626500", VA = "0x184627300", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x37E1BF0", Offset = "0x37E0DF0", VA = "0x1837E1BF0")]
	internal APOOBGBBBBG(in TSourceEnumerator BJFNBIEJBCK, Func<TSource, TResult> MMJPJBIPBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x4627260", Offset = "0x4626460", VA = "0x184627260", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x46272B0", Offset = "0x46264B0", VA = "0x1846272B0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4627210", Offset = "0x4626410", VA = "0x184627210", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class CGOJACMBOHK
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x469C630", Offset = "0x469B830", VA = "0x18469C630")]
	public static bool PFJGNFEFMJD<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator BJFNBIEJBCK, in TArgs HHILANAMFFB, in global::GIOOCAKJPBK<TArgs, TSource, bool> GPAFAFLAFAB) where TSourceEnumerator : global::CJLLEHHANFJ<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0xD4F400", Offset = "0xD4E600", VA = "0x180D4F400")]
	public static int PGEMGBAIOHI<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator BJFNBIEJBCK, in TArgs HHILANAMFFB, global::GIOOCAKJPBK<TArgs, TSource, bool> GPAFAFLAFAB) where TSourceEnumerator : global::CJLLEHHANFJ<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x469C910", Offset = "0x469BB10", VA = "0x18469C910")]
	public static bool PMGMJACANLO<TSourceEnumerator, TSource>(this TSourceEnumerator BJFNBIEJBCK, in TSource BCDFAIJCGDO) where TSourceEnumerator : global::CJLLEHHANFJ<TSource> where TSource : global::KAGDCAKBEHF<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0xD4F0E0", Offset = "0xD4E2E0", VA = "0x180D4F0E0")]
	public static int ALJOIHNPPCJ<TSourceEnumerator, TSource>(this TSourceEnumerator BJFNBIEJBCK, in TSource ADBNEBBHMOP) where TSourceEnumerator : global::CJLLEHHANFJ<TSource> where TSource : global::KAGDCAKBEHF<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3830CC0", Offset = "0x382FEC0", VA = "0x183830CC0")]
	public static global::EODGLLBJOOP<TSourceEnumerator, TSource, TResult> NOPIOKPHPEA<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator BJFNBIEJBCK, global::MIMFAPJNEIA<TSource, TResult> MMJPJBIPBNN) where TSourceEnumerator : PAEOMNDDDKI, global::CJLLEHHANFJ<TSource>
	{
		return default(global::EODGLLBJOOP<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3830D10", Offset = "0x382FF10", VA = "0x183830D10")]
	public static global::APOOBGBBBBG<TSourceEnumerator, TSource, TResult> BHIFKDOJLHD<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator BJFNBIEJBCK, Func<TSource, TResult> MMJPJBIPBNN) where TSourceEnumerator : PAEOMNDDDKI, IEnumerator<TSource>
	{
		return default(global::APOOBGBBBBG<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class ABDNGLAPGPC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x4693BF0", Offset = "0x4692DF0", VA = "0x184693BF0")]
	public static bool KCCAGMALFBD<TSourceEnumerator>(TSourceEnumerator BJFNBIEJBCK) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x3B633C0", Offset = "0x3B625C0", VA = "0x183B633C0")]
	public static T FDNPCBLJBPE<TSourceEnumerator>(TSourceEnumerator BJFNBIEJBCK) where TSourceEnumerator : global::CJLLEHHANFJ<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x382EB60", Offset = "0x382DD60", VA = "0x18382EB60")]
	public static global::FHCLPDPLMDH<TSourceEnumerator, TSource, TResultEnumerator, T> NPMOAEFALLC<TSourceEnumerator, TSource, TResultEnumerator>(in TSourceEnumerator BJFNBIEJBCK, global::MIMFAPJNEIA<TSource, TResultEnumerator> MMJPJBIPBNN) where TSourceEnumerator : global::CJLLEHHANFJ<TSource> where TResultEnumerator : global::CJLLEHHANFJ<T>
	{
		return default(global::FHCLPDPLMDH<TSourceEnumerator, TSource, TResultEnumerator, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3856600", Offset = "0x3855800", VA = "0x183856600")]
	public static string IGABBHJHCON<TSourceEnumerator>(TSourceEnumerator BJFNBIEJBCK) where TSourceEnumerator : IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x488C050", Offset = "0x488B250", VA = "0x18488C050")]
	public static T[] HCDLFBDPLND<TSourceEnumerator>(TSourceEnumerator BJFNBIEJBCK) where TSourceEnumerator : PAEOMNDDDKI, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3842AC0", Offset = "0x3841CC0", VA = "0x183842AC0")]
	public static T MFADMINPLBC<TSourceEnumerator>(TSourceEnumerator BJFNBIEJBCK) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x4693D20", Offset = "0x4692F20", VA = "0x184693D20")]
	public static bool NPIGMHPGFKC<TSourceEnumerator>(TSourceEnumerator BJFNBIEJBCK) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class GDHKIHOMAFK<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3837B10", Offset = "0x3836D10", VA = "0x183837B10")]
	public static global::EHAJABIFCBN<TSource1Enumerator, T, TSource2Enumerator, U> EDLDBIKFAJI<TSource1Enumerator, TSource2Enumerator>(in TSource1Enumerator DDDAAFLILIE, in TSource2Enumerator MNDNDIKDBDE) where TSource1Enumerator : PAEOMNDDDKI, global::CJLLEHHANFJ<T> where TSource2Enumerator : PAEOMNDDDKI, global::CJLLEHHANFJ<U>
	{
		return default(global::EHAJABIFCBN<TSource1Enumerator, T, TSource2Enumerator, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface KCCNHJKNACL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::CJLLEHHANFJ<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface FFKMMEJPBGC<T, TEnumerator> : global::KCCNHJKNACL<T>, global::PCNGBKGMJLN<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::CJLLEHHANFJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface CJLLEHHANFJ<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T EGCCHNLJPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface DMBLADBHILG<T> : PAEOMNDDDKI
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T NMEKMIHCNFD(int OCLFFJGEIJK);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface PCNGBKGMJLN<T, TEnumerator> : IEnumerable<T>, IEnumerable where TEnumerator : IEnumerator<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface PAEOMNDDDKI
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface KAGDCAKBEHF<T>
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OFBJACCBFGB(in T GHOINNFPLDF);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface EGJDHGKNEFG<T>
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::EOHJBOPFHML<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface CONBNEAOHLD<T, TEnumerator> : global::EGJDHGKNEFG<T>, global::FFKMMEJPBGC<T, TEnumerator>, global::KCCNHJKNACL<T>, global::PCNGBKGMJLN<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::EOHJBOPFHML<T>
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface EOHJBOPFHML<T> : global::CJLLEHHANFJ<T>, IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	new T EGCCHNLJPLC
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public delegate void OJDNPMFAGIL<T>(in T ACHMMDGBDID);
[Cpp2IlInjected.Token(Token = "0x200004A")]
public delegate void PNLFEFBEEFL<T1, T2>(in T1 FDJNOJEIGEJ, in T2 IOJNOBKDCED);
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class OOIDLIEJAIC
{
	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3AE22A0", Offset = "0x3AE14A0", VA = "0x183AE22A0")]
	public static bool NGJBMCNANBA<T, U>(this T BJFNBIEJBCK, in U PBKPNJLDBOM) where T : global::KAGDCAKBEHF<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public delegate TResult MIMFAPJNEIA<T, out TResult>(in T ACHMMDGBDID);
[Cpp2IlInjected.Token(Token = "0x200004D")]
public delegate TResult GIOOCAKJPBK<T1, T2, out TResult>(in T1 FDJNOJEIGEJ, in T2 IOJNOBKDCED);
[Cpp2IlInjected.Token(Token = "0x200004E")]
public delegate TResult PJLPIJGEPJJ<T1, T2, T3, out TResult>(in T1 FDJNOJEIGEJ, in T2 IOJNOBKDCED, in T3 CFHJIJKALEN);
[Cpp2IlInjected.Token(Token = "0x200004F")]
public delegate TResult MLMDHKOKKIN<T1, T2, T3, T4, out TResult>(in T1 FDJNOJEIGEJ, in T2 IOJNOBKDCED, in T3 CFHJIJKALEN, in T4 LKEHMBJHOOH);
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate TResult OOIMOKDGJKM<T1, T2, T3, T4, T5, out TResult>(in T1 FDJNOJEIGEJ, in T2 IOJNOBKDCED, in T3 CFHJIJKALEN, in T4 LKEHMBJHOOH, in T5 AKEBPHADNKP);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate TResult KOHDJONENAF<T, TResult>(in T ACHMMDGBDID);
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate TResult PLDEJPKCIME<T1, T2, TResult>(in T1 FDJNOJEIGEJ, in T2 IOJNOBKDCED);
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate TResult KOIOBHBIAHF<T1, T2, T3, TResult>(in T1 FDJNOJEIGEJ, in T2 IOJNOBKDCED, in T3 CFHJIJKALEN);
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DefaultMember("Item")]
public struct KBAMDEICBHG<T> : global::CONBNEAOHLD<T, global::KBAMDEICBHG<T>.NCDKLPFOJOB>, global::EGJDHGKNEFG<T>, global::FFKMMEJPBGC<T, global::KBAMDEICBHG<T>.NCDKLPFOJOB>, global::KCCNHJKNACL<T>, global::PCNGBKGMJLN<T, global::KBAMDEICBHG<T>.NCDKLPFOJOB>, IEnumerable<T>, IEnumerable, global::DMBLADBHILG<T>, PAEOMNDDDKI
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct NCDKLPFOJOB : PAEOMNDDDKI, global::EOHJBOPFHML<T>, global::CJLLEHHANFJ<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private T[] DMFCGEBKMOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int JLOLLFHGPON;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int NAIIACDHEPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0xAEE550", Offset = "0xAED750", VA = "0x180AEE550", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public T EGCCHNLJPLC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x1345E40", Offset = "0x1345040", VA = "0x181345E40", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		private T HGGAPLJFNOC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x1345D00", Offset = "0x1344F00", VA = "0x181345D00", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x1345DF0", Offset = "0x1344FF0", VA = "0x181345DF0", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x1345DF0", Offset = "0x1344FF0", VA = "0x181345DF0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xC4FDD0", Offset = "0xC4EFD0", VA = "0x180C4FDD0")]
		private NCDKLPFOJOB(T[] BJFNBIEJBCK, int MJNAIOAAGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1345D50", Offset = "0x1344F50", VA = "0x181345D50")]
		public static NCDKLPFOJOB HCEINCHCOLK(T[] BJFNBIEJBCK)
		{
			return default(NCDKLPFOJOB);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1345DB0", Offset = "0x1344FB0", VA = "0x181345DB0", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x1345DE0", Offset = "0x1344FE0", VA = "0x181345DE0", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private T[] OAFEGCNLIJH;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public int IPIKHFMIGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xAEE550", Offset = "0xAED750", VA = "0x180AEE550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x133E3C0", Offset = "0x133D5C0", VA = "0x18133E3C0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public T LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x133E740", Offset = "0x133D940", VA = "0x18133E740")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x8EF1D0", Offset = "0x8EE3D0", VA = "0x1808EF1D0")]
	internal KBAMDEICBHG(T[] NAJOFPKLJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x133E680", Offset = "0x133D880", VA = "0x18133E680")]
	public static global::KBAMDEICBHG<T> NPKBEJHDJME()
	{
		return default(global::KBAMDEICBHG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x133E620", Offset = "0x133D820", VA = "0x18133E620", Slot = "11")]
	public T NMEKMIHCNFD(int MJNAIOAAGCG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x133E5A0", Offset = "0x133D7A0", VA = "0x18133E5A0")]
	public global::ICOBDKPNEDE<T> KFHGPHMDHPP()
	{
		return default(global::ICOBDKPNEDE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x133E500", Offset = "0x133D700", VA = "0x18133E500", Slot = "8")]
	public NCDKLPFOJOB GetEnumerator()
	{
		return default(NCDKLPFOJOB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x133E400", Offset = "0x133D600", VA = "0x18133E400", Slot = "5")]
	private global::EOHJBOPFHML<T> FMABCJOACKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x133E400", Offset = "0x133D600", VA = "0x18133E400", Slot = "7")]
	private global::CJLLEHHANFJ<T> CLEKDCFPCEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x133E400", Offset = "0x133D600", VA = "0x18133E400", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x133E400", Offset = "0x133D600", VA = "0x18133E400", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class OKCMJCCKFAF
{
	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3993A00", Offset = "0x3992C00", VA = "0x183993A00")]
	public static global::KBAMDEICBHG<T> HCEINCHCOLK<T>(T[] NAJOFPKLJJG)
	{
		return default(global::KBAMDEICBHG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1937DE0", Offset = "0x1936FE0", VA = "0x181937DE0")]
	public static global::KBAMDEICBHG<T> FCKMOMONCOL<T>(this T[] BJFNBIEJBCK)
	{
		return default(global::KBAMDEICBHG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x387EB90", Offset = "0x387DD90", VA = "0x18387EB90")]
	public static global::KBAMDEICBHG<T>.NCDKLPFOJOB FMPOOCIPBDI<T>(this T[] BJFNBIEJBCK)
	{
		return default(global::KBAMDEICBHG<T>.NCDKLPFOJOB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x1937DE0", Offset = "0x1936FE0", VA = "0x181937DE0")]
	public static global::KBAMDEICBHG<T> FPPNLGMBKHD<T>(this T[] BJFNBIEJBCK)
	{
		return default(global::KBAMDEICBHG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct BJBHBKINOAN<T, U> : global::CONBNEAOHLD<T, U>, global::EGJDHGKNEFG<T>, global::FFKMMEJPBGC<T, U>, global::KCCNHJKNACL<T>, global::PCNGBKGMJLN<T, U>, IEnumerable<T>, IEnumerable where U : global::EOHJBOPFHML<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly U GHOIFCGFEPA;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0xE94B80", Offset = "0xE93D80", VA = "0x180E94B80")]
	internal BJBHBKINOAN(in U FCHPKFGDGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x72F660", Offset = "0x72E860", VA = "0x18072F660", Slot = "8")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0xF395C0", Offset = "0xF387C0", VA = "0x180F395C0", Slot = "5")]
	private global::EOHJBOPFHML<T> FMABCJOACKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0xF395C0", Offset = "0xF387C0", VA = "0x180F395C0", Slot = "7")]
	private global::CJLLEHHANFJ<T> CLEKDCFPCEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0xF395C0", Offset = "0xF387C0", VA = "0x180F395C0", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0xF395C0", Offset = "0xF387C0", VA = "0x180F395C0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class FJGENPCMDHA<T>
{
	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3A07B40", Offset = "0x3A06D40", VA = "0x183A07B40")]
	public static global::BJBHBKINOAN<T, U> HCEINCHCOLK<U>(in U FCHPKFGDGGN) where U : global::EOHJBOPFHML<T>
	{
		return default(global::BJBHBKINOAN<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DefaultMember("Item")]
public class MEECPNNCFBA<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly Func<Internal, External> NLICJCFEPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly Func<External, Internal> PIGOKANGDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private IList<Internal> MDBHJOENILE;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public IList<Internal> MIANGCJEECA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD10", Offset = "0x5FCF10", VA = "0x1805FDD10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD20", Offset = "0x5FCF20", VA = "0x1805FDD20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool BNGNOGOPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7E7390", Offset = "0x7E6590", VA = "0x1807E7390", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7E7600", Offset = "0x7E6800", VA = "0x1807E7600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public External LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x43F3A40", Offset = "0x43F2C40", VA = "0x1843F3A40", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x43F3AE0", Offset = "0x43F2CE0", VA = "0x1843F3AE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x43F39E0", Offset = "0x43F2BE0", VA = "0x1843F39E0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x1C943F0", Offset = "0x1C935F0", VA = "0x181C943F0")]
	public MEECPNNCFBA(Func<Internal, External> NLICJCFEPKK, Func<External, Internal> PIGOKANGDMJ, bool FOOOLENCPCJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x43F36F0", Offset = "0x43F28F0", VA = "0x1843F36F0", Slot = "6")]
	public int IndexOf(External BCDFAIJCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x43F3370", Offset = "0x43F2570", VA = "0x1843F3370", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x43F33D0", Offset = "0x43F25D0", VA = "0x1843F33D0", Slot = "13")]
	public bool Contains(External BCDFAIJCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x43F3460", Offset = "0x43F2660", VA = "0x1843F3460", Slot = "14")]
	public void CopyTo(External[] NAJOFPKLJJG, int LEAMOGPCOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x43F3280", Offset = "0x43F2480", VA = "0x1843F3280", Slot = "11")]
	public void Add(External BCDFAIJCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x43F37E0", Offset = "0x43F29E0", VA = "0x1843F37E0", Slot = "7")]
	public void Insert(int MJNAIOAAGCG, External BCDFAIJCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x43F3950", Offset = "0x43F2B50", VA = "0x1843F3950", Slot = "15")]
	public bool Remove(External BCDFAIJCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x43F3880", Offset = "0x43F2A80", VA = "0x1843F3880", Slot = "8")]
	public void RemoveAt(int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x43F3680", Offset = "0x43F2880", VA = "0x1843F3680", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4520", Offset = "0x1CC3720", VA = "0x181CC4520", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[DefaultMember("Item")]
public class IAFNGKOKLHO<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Func<Internal, External> NLICJCFEPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private IReadOnlyList<Internal> MDBHJOENILE;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public IReadOnlyList<Internal> MIANGCJEECA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x623BB0", Offset = "0x622DB0", VA = "0x180623BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool BNGNOGOPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x601070", Offset = "0x600270", VA = "0x180601070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public External LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4113550", Offset = "0x4112750", VA = "0x184113550", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x41134F0", Offset = "0x41126F0", VA = "0x1841134F0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x1343700", Offset = "0x1342900", VA = "0x181343700")]
	public IAFNGKOKLHO(Func<Internal, External> NLICJCFEPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x41134A0", Offset = "0x41126A0", VA = "0x1841134A0")]
	public IAFNGKOKLHO(IReadOnlyList<Internal> MDBHJOENILE, Func<Internal, External> NLICJCFEPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x4113280", Offset = "0x4112480", VA = "0x184113280")]
	public void INFFHPJLHHE(External[] NAJOFPKLJJG, int LEAMOGPCOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x4113210", Offset = "0x4112410", VA = "0x184113210", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x1343310", Offset = "0x1342510", VA = "0x181343310", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[DefaultMember("Item")]
public class LNCBCAGJFMJ<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private IReadOnlyList<Internal> MDBHJOENILE;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public IReadOnlyList<Internal> MIANGCJEECA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6EE480", Offset = "0x6ED680", VA = "0x1806EE480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool BNGNOGOPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x601070", Offset = "0x600270", VA = "0x180601070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public External LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x1CC45B0", Offset = "0x1CC37B0", VA = "0x181CC45B0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x1CC4550", Offset = "0x1CC3750", VA = "0x181CC4550", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x1343700", Offset = "0x1342900", VA = "0x181343700")]
	public LNCBCAGJFMJ(IReadOnlyList<Internal> MDBHJOENILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4250", Offset = "0x1CC3450", VA = "0x181CC4250")]
	public bool HIPEHFAIGLD(External BCDFAIJCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x1CC42F0", Offset = "0x1CC34F0", VA = "0x181CC42F0")]
	public void INFFHPJLHHE(External[] NAJOFPKLJJG, int LEAMOGPCOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x1CC41E0", Offset = "0x1CC33E0", VA = "0x181CC41E0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4520", Offset = "0x1CC3720", VA = "0x181CC4520", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class FAIMNPIEFAF
{
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void PBBGHCPAFNJ(object[] HHILANAMFFB);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	protected FAIMNPIEFAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class EOMDIJBLEJA<T> : FAIMNPIEFAF
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	protected struct BBKCGFIDENB
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public enum NNKGEIKEDFE
		{
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public NNKGEIKEDFE BGMCKNGNOJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public T GHCLFMPOHGP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int LIIBPIJFIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly bool BAOLIJOGFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	protected readonly bool FFDANOKAHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	protected List<T> AJAAGMPFHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private List<BBKCGFIDENB> BPFEHAGAPBI;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool FIONOEIGGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x4789BB0", Offset = "0x4788DB0", VA = "0x184789BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4789D20", Offset = "0x4788F20", VA = "0x184789D20")]
	protected EOMDIJBLEJA(bool FFDANOKAHIN, bool BAOLIJOGFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x47898B0", Offset = "0x4788AB0", VA = "0x1847898B0")]
	protected bool DMLJIENHDEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4789950", Offset = "0x4788B50", VA = "0x184789950")]
	protected void EKDNBCOMAIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x47895A0", Offset = "0x47887A0", VA = "0x1847895A0")]
	protected void ABGHFLDOIEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4552BB0", Offset = "0x4551DB0", VA = "0x184552BB0")]
	private static void ACCGFJLGIHE<U>(ref List<U> MDBHJOENILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4789A30", Offset = "0x4788C30", VA = "0x184789A30", Slot = "5")]
	public void KAGEPJABGKM(T GHCLFMPOHGP, bool PGGCIMOCPNE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4789750", Offset = "0x4788950", VA = "0x184789750", Slot = "6")]
	public void CEDMIKNCMLN(T GHCLFMPOHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4789BF0", Offset = "0x4788DF0", VA = "0x184789BF0")]
	public void NLALCDJNEAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface FDPOBNHIOKF
{
	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAGEPJABGKM(Action GHCLFMPOHGP, bool PGGCIMOCPNE = false);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CEDMIKNCMLN(Action GHCLFMPOHGP);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public sealed class EOAHAKPACKC : global::EOMDIJBLEJA<Action>, FDPOBNHIOKF
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x26CBD20", Offset = "0x26CAF20", VA = "0x1826CBD20")]
	public EOAHAKPACKC(bool FFDANOKAHIN = false, bool BAOLIJOGFAO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x26CBB60", Offset = "0x26CAD60", VA = "0x1826CBB60")]
	public void PJMIDIIBLNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x26CBAE0", Offset = "0x26CACE0", VA = "0x1826CBAE0", Slot = "4")]
	public override void PBBGHCPAFNJ(object[] HHILANAMFFB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x26CBA20", Offset = "0x26CAC20", VA = "0x1826CBA20")]
	public static EOAHAKPACKC ANJIEFFMCOH(EOAHAKPACKC KABNEEBKGJN, Action GHCLFMPOHGP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x26CBA80", Offset = "0x26CAC80", VA = "0x1826CBA80")]
	public static EOAHAKPACKC JNDNLPFCIJJ(EOAHAKPACKC KABNEEBKGJN, Action GHCLFMPOHGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface FBBFKIDJFGE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAGEPJABGKM(Action<T> GHCLFMPOHGP, bool PGGCIMOCPNE = false);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CEDMIKNCMLN(Action<T> GHCLFMPOHGP);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public sealed class FKOLNGKNIEI<T> : global::EOMDIJBLEJA<Action<T>>, global::FBBFKIDJFGE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x16AB290", Offset = "0x16AA490", VA = "0x1816AB290")]
	public FKOLNGKNIEI(bool FFDANOKAHIN = false, bool BAOLIJOGFAO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x485DDA0", Offset = "0x485CFA0", VA = "0x18485DDA0")]
	public void PJMIDIIBLNP(T FOLCGJFJJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x485B440", Offset = "0x485A640", VA = "0x18485B440", Slot = "4")]
	public override void PBBGHCPAFNJ(object[] HHILANAMFFB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x485A280", Offset = "0x4859480", VA = "0x18485A280")]
	public static global::FKOLNGKNIEI<T> ANJIEFFMCOH(global::FKOLNGKNIEI<T> KABNEEBKGJN, Action<T> GHCLFMPOHGP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x485A320", Offset = "0x4859520", VA = "0x18485A320")]
	public static global::FKOLNGKNIEI<T> JNDNLPFCIJJ(global::FKOLNGKNIEI<T> KABNEEBKGJN, Action<T> GHCLFMPOHGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface PCFFABFJGDF<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAGEPJABGKM(Action<T, U> GHCLFMPOHGP, bool PGGCIMOCPNE = false);

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CEDMIKNCMLN(Action<T, U> GHCLFMPOHGP);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public sealed class NOGAHDENHIE<T, U> : global::EOMDIJBLEJA<Action<T, U>>, global::PCFFABFJGDF<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x16AB290", Offset = "0x16AA490", VA = "0x1816AB290")]
	public NOGAHDENHIE(bool FFDANOKAHIN = false, bool BAOLIJOGFAO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x468C1A0", Offset = "0x468B3A0", VA = "0x18468C1A0")]
	public void PJMIDIIBLNP(T FOLCGJFJJMP, U EGJEGCJLGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x46881C0", Offset = "0x46873C0", VA = "0x1846881C0", Slot = "4")]
	public override void PBBGHCPAFNJ(object[] HHILANAMFFB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x4686160", Offset = "0x4685360", VA = "0x184686160")]
	public static global::NOGAHDENHIE<T, U> ANJIEFFMCOH(global::NOGAHDENHIE<T, U> KABNEEBKGJN, Action<T, U> GHCLFMPOHGP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x4686200", Offset = "0x4685400", VA = "0x184686200")]
	public static global::NOGAHDENHIE<T, U> JNDNLPFCIJJ(global::NOGAHDENHIE<T, U> KABNEEBKGJN, Action<T, U> GHCLFMPOHGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface PEHCHBNKHDO<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAGEPJABGKM(Action<T, U, V> GHCLFMPOHGP, bool PGGCIMOCPNE = false);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CEDMIKNCMLN(Action<T, U, V> GHCLFMPOHGP);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public sealed class AGCEEALILAN<T, U, V> : global::EOMDIJBLEJA<Action<T, U, V>>, global::PEHCHBNKHDO<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x16AB290", Offset = "0x16AA490", VA = "0x1816AB290")]
	public AGCEEALILAN(bool FFDANOKAHIN = false, bool BAOLIJOGFAO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x37E7800", Offset = "0x37E6A00", VA = "0x1837E7800")]
	public void PJMIDIIBLNP(T FOLCGJFJJMP, U EGJEGCJLGEC, V BGOLGEMKCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x37E66F0", Offset = "0x37E58F0", VA = "0x1837E66F0", Slot = "4")]
	public override void PBBGHCPAFNJ(object[] HHILANAMFFB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x37E59A0", Offset = "0x37E4BA0", VA = "0x1837E59A0")]
	public static global::AGCEEALILAN<T, U, V> ANJIEFFMCOH(global::AGCEEALILAN<T, U, V> KABNEEBKGJN, Action<T, U, V> GHCLFMPOHGP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x37E5A40", Offset = "0x37E4C40", VA = "0x1837E5A40")]
	public static global::AGCEEALILAN<T, U, V> JNDNLPFCIJJ(global::AGCEEALILAN<T, U, V> KABNEEBKGJN, Action<T, U, V> GHCLFMPOHGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface LOLLJOIOMGO<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAGEPJABGKM(Action<T, U, V, W> GHCLFMPOHGP, bool PGGCIMOCPNE = false);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CEDMIKNCMLN(Action<T, U, V, W> GHCLFMPOHGP);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public sealed class BFIOPHKAKBO<T, U, V, W> : global::EOMDIJBLEJA<Action<T, U, V, W>>, global::LOLLJOIOMGO<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x16AB290", Offset = "0x16AA490", VA = "0x1816AB290")]
	public BFIOPHKAKBO(bool FFDANOKAHIN = false, bool BAOLIJOGFAO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4235CB0", Offset = "0x4234EB0", VA = "0x184235CB0")]
	public void PJMIDIIBLNP(T FOLCGJFJJMP, U EGJEGCJLGEC, V BGOLGEMKCDC, W OBCBDNBHHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x4234AC0", Offset = "0x4233CC0", VA = "0x184234AC0", Slot = "4")]
	public override void PBBGHCPAFNJ(object[] HHILANAMFFB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4233D10", Offset = "0x4232F10", VA = "0x184233D10")]
	public static global::BFIOPHKAKBO<T, U, V, W> ANJIEFFMCOH(global::BFIOPHKAKBO<T, U, V, W> KABNEEBKGJN, Action<T, U, V, W> GHCLFMPOHGP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x4233DB0", Offset = "0x4232FB0", VA = "0x184233DB0")]
	public static global::BFIOPHKAKBO<T, U, V, W> JNDNLPFCIJJ(global::BFIOPHKAKBO<T, U, V, W> KABNEEBKGJN, Action<T, U, V, W> GHCLFMPOHGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface HGAJJEMJMJN<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAGEPJABGKM(Action<T, U, V, W, X> GHCLFMPOHGP, bool PGGCIMOCPNE = false);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CEDMIKNCMLN(Action<T, U, V, W, X> GHCLFMPOHGP);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public sealed class IKAFCDHGOLJ<T, U, V, W, X> : global::EOMDIJBLEJA<Action<T, U, V, W, X>>, global::HGAJJEMJMJN<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x16AB290", Offset = "0x16AA490", VA = "0x1816AB290")]
	public IKAFCDHGOLJ(bool FFDANOKAHIN = false, bool BAOLIJOGFAO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x16AACE0", Offset = "0x16A9EE0", VA = "0x1816AACE0")]
	public void PJMIDIIBLNP(T FOLCGJFJJMP, U EGJEGCJLGEC, V BGOLGEMKCDC, W OBCBDNBHHOM, X FMHEJMEECNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x16AA9F0", Offset = "0x16A9BF0", VA = "0x1816AA9F0", Slot = "4")]
	public override void PBBGHCPAFNJ(object[] HHILANAMFFB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x16AA590", Offset = "0x16A9790", VA = "0x1816AA590")]
	public static global::IKAFCDHGOLJ<T, U, V, W, X> ANJIEFFMCOH(global::IKAFCDHGOLJ<T, U, V, W, X> KABNEEBKGJN, Action<T, U, V, W, X> GHCLFMPOHGP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x16AA630", Offset = "0x16A9830", VA = "0x1816AA630")]
	public static global::IKAFCDHGOLJ<T, U, V, W, X> JNDNLPFCIJJ(global::IKAFCDHGOLJ<T, U, V, W, X> KABNEEBKGJN, Action<T, U, V, W, X> GHCLFMPOHGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface KDHDGKPIJKM<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAGEPJABGKM(Action<T, U, V, W, X, Y> GHCLFMPOHGP, bool PGGCIMOCPNE = false);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CEDMIKNCMLN(Action<T, U, V, W, X, Y> GHCLFMPOHGP);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public sealed class DOEKGEHEPMC<T, U, V, W, X, Y> : global::EOMDIJBLEJA<Action<T, U, V, W, X, Y>>, global::KDHDGKPIJKM<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x16AB290", Offset = "0x16AA490", VA = "0x1816AB290")]
	public DOEKGEHEPMC(bool FFDANOKAHIN = false, bool BAOLIJOGFAO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x4575530", Offset = "0x4574730", VA = "0x184575530")]
	public void PJMIDIIBLNP(T FOLCGJFJJMP, U EGJEGCJLGEC, V BGOLGEMKCDC, W OBCBDNBHHOM, X FMHEJMEECNK, Y EDNBLCPIBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x4574560", Offset = "0x4573760", VA = "0x184574560", Slot = "4")]
	public override void PBBGHCPAFNJ(object[] HHILANAMFFB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x4574420", Offset = "0x4573620", VA = "0x184574420")]
	public static global::DOEKGEHEPMC<T, U, V, W, X, Y> ANJIEFFMCOH(global::DOEKGEHEPMC<T, U, V, W, X, Y> KABNEEBKGJN, Action<T, U, V, W, X, Y> GHCLFMPOHGP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x45744C0", Offset = "0x45736C0", VA = "0x1845744C0")]
	public static global::DOEKGEHEPMC<T, U, V, W, X, Y> JNDNLPFCIJJ(global::DOEKGEHEPMC<T, U, V, W, X, Y> KABNEEBKGJN, Action<T, U, V, W, X, Y> GHCLFMPOHGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public sealed class KFCLEANFHKA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct JIDNLOKFLHI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly global::KFCLEANFHKA<T> GNLCIFPKOPO;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public T MDDADGNJOKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x133C9E0", Offset = "0x133BBE0", VA = "0x18133C9E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x133C9B0", Offset = "0x133BBB0", VA = "0x18133C9B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x8EF1D0", Offset = "0x8EE3D0", VA = "0x1808EF1D0")]
		public JIDNLOKFLHI(global::KFCLEANFHKA<T> GNLCIFPKOPO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct FGEELAJBEEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder<JIDNLOKFLHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::KFCLEANFHKA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x133C360", Offset = "0x133B560", VA = "0x18133C360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x133C530", Offset = "0x133B730", VA = "0x18133C530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct GPBPDMDKBFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public AsyncTaskMethodBuilder<JIDNLOKFLHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public global::KFCLEANFHKA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x133C750", Offset = "0x133B950", VA = "0x18133C750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x133C530", Offset = "0x133B730", VA = "0x18133C530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly SemaphoreSlim PKANEHIJPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private T EKJKKDDOBFM;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int LNAOHDHPNNC
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x13402B0", Offset = "0x133F4B0", VA = "0x1813402B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x1340380", Offset = "0x133F580", VA = "0x181340380")]
	public KFCLEANFHKA(in T EKJKKDDOBFM, int OCLLOHPDFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x1340350", Offset = "0x133F550", VA = "0x181340350")]
	public KFCLEANFHKA(in T EKJKKDDOBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x1340310", Offset = "0x133F510", VA = "0x181340310")]
	public JIDNLOKFLHI OAHOFHNKPPB()
	{
		return default(JIDNLOKFLHI);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x13402D0", Offset = "0x133F4D0", VA = "0x1813402D0")]
	public JIDNLOKFLHI OAHOFHNKPPB(CancellationToken GENHLOEKMNL)
	{
		return default(JIDNLOKFLHI);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x133FCF0", Offset = "0x133EEF0", VA = "0x18133FCF0")]
	[AsyncStateMachine(typeof(global::KFCLEANFHKA<>.FGEELAJBEEI))]
	public Task<JIDNLOKFLHI> BHIBGMKCKDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x133FE50", Offset = "0x133F050", VA = "0x18133FE50")]
	[AsyncStateMachine(typeof(global::KFCLEANFHKA<>.GPBPDMDKBFL))]
	public Task<JIDNLOKFLHI> BHIBGMKCKDO(CancellationToken GENHLOEKMNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class NKFLBEDIOOI
{
	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x26D15C0", Offset = "0x26D07C0", VA = "0x1826D15C0")]
	public static global::KFCLEANFHKA<JMNHLBPPELC> HCEINCHCOLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x26D1620", Offset = "0x26D0820", VA = "0x1826D1620")]
	public static global::KFCLEANFHKA<JMNHLBPPELC> HCEINCHCOLK(int OCLLOHPDFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x3824660", Offset = "0x3823860", VA = "0x183824660")]
	public static global::KFCLEANFHKA<T> HCEINCHCOLK<T>(in T EKJKKDDOBFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3837D70", Offset = "0x3836F70", VA = "0x183837D70")]
	public static global::KFCLEANFHKA<T> HCEINCHCOLK<T>(in T EKJKKDDOBFM, int OCLLOHPDFAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class MCDMHMIKFDJ<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public delegate Task<TResult> BMPCNGINCCN(TRequest KPOBLGGEAFB, CancellationToken GENHLOEKMNL);

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public enum CFKKOGLJDIA
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class HPNFDEDFNEH
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private const float HCCOBACFAME = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private TimeSpan IMGIKKBMPPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public int MHCDOAJDLJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public CFKKOGLJDIA GOFBEKKJNAN;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public static readonly HPNFDEDFNEH HPMHEACECHL;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public float MOAMILMHGKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x43EBF10", Offset = "0x43EB110", VA = "0x1843EBF10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public TimeSpan JCGHHLLOAKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x43EBFF0", Offset = "0x43EB1F0", VA = "0x1843EBFF0")]
		public HPNFDEDFNEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private readonly struct JFIDDJBKMIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public readonly TRequest KPOBLGGEAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public readonly CancellationToken GENHLOEKMNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public readonly TaskCompletionSource<TResult> AOJFIHKLIBC;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x43EC120", Offset = "0x43EB320", VA = "0x1843EC120")]
		public JFIDDJBKMIE(TRequest KPOBLGGEAFB, TaskCompletionSource<TResult> AOJFIHKLIBC, CancellationToken GENHLOEKMNL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class FNGFDALBDGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		public FNGFDALBDGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xF2A9C0", Offset = "0xF29BC0", VA = "0x180F2A9C0")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct NKBMLOPKILE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public global::MCDMHMIKFDJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x43F6C20", Offset = "0x43F5E20", VA = "0x1843F6C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct FDLONEGFBPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public global::MCDMHMIKFDJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private JFIDDJBKMIE <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x43E83E0", Offset = "0x43E75E0", VA = "0x1843E83E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly CancellationTokenSource HHLOAMJLJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly List<JFIDDJBKMIE> PKEPECBPCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly HPNFDEDFNEH CHCELCAGEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly BMPCNGINCCN PAKNNNMLLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Task CFHADNIPCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int PJBDMHHPJKP;

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x43F2BB0", Offset = "0x43F1DB0", VA = "0x1843F2BB0")]
	public MCDMHMIKFDJ(BMPCNGINCCN PAKNNNMLLLP, [Optional] HPNFDEDFNEH CHCELCAGEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x43F2480", Offset = "0x43F1680", VA = "0x1843F2480")]
	public Task<TResult> OJPGEHPFJEF(TRequest KPOBLGGEAFB, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x43F1380", Offset = "0x43F0580", VA = "0x1843F1380")]
	private void EEDOMNEAKAI(JFIDDJBKMIE MAPCLOPIMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x43F1630", Offset = "0x43F0830", VA = "0x1843F1630")]
	[AsyncStateMachine(typeof(global::MCDMHMIKFDJ<, >.NKBMLOPKILE))]
	private Task IDEBDDONNGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x43F1C60", Offset = "0x43F0E60", VA = "0x1843F1C60")]
	private JFIDDJBKMIE JALDEFDHIGM()
	{
		return default(JFIDDJBKMIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x43F2350", Offset = "0x43F1550", VA = "0x1843F2350")]
	[AsyncStateMachine(typeof(global::MCDMHMIKFDJ<, >.FDLONEGFBPN))]
	private Task NNIBNOOELIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x43F18E0", Offset = "0x43F0AE0", VA = "0x1843F18E0")]
	private void IJIJFJLNHFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x43F1200", Offset = "0x43F0400", VA = "0x1843F1200", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class DFHMGBJPPCA<TKey, TVal> : global::MLAMKDIPHDH<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int KLDBAODEGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	internal Dictionary<TKey, (TVal value, int size)> FCBLFJDOPOE;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	internal override int OODEPNDCHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x46C9460", Offset = "0x46C8660", VA = "0x1846C9460", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	internal int FLLDHBCBEBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x46C96F0", Offset = "0x46C88F0", VA = "0x1846C96F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public override int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x46C9400", Offset = "0x46C8600", VA = "0x1846C9400", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x46C9830", Offset = "0x46C8A30", VA = "0x1846C9830")]
	public DFHMGBJPPCA(int GOCCOAPEHDE, [Optional] AECHGGMNPFK KEONCMJEJAE, [Optional] IEqualityComparer<TKey> KHBLBMKIJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x46C95E0", Offset = "0x46C87E0", VA = "0x1846C95E0")]
	public void MMDKPEPGOPJ(TKey JCNAPFOCJDI, TVal ADBNEBBHMOP, bool ELJAHCIFFHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x46C9150", Offset = "0x46C8350", VA = "0x1846C9150")]
	public bool BGNLLEPCCFE(TKey JCNAPFOCJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x46C9490", Offset = "0x46C8690", VA = "0x1846C9490", Slot = "6")]
	public override bool HNIJFJOBNMJ(TKey JOFEMOMAGIJ, out TVal ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x46C91D0", Offset = "0x46C83D0", VA = "0x1846C91D0")]
	public bool BKKIDBBHOLC(TKey JCNAPFOCJDI, TVal ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x46C9720", Offset = "0x46C8920", VA = "0x1846C9720")]
	public bool PMFPEEDHDAH(TKey JCNAPFOCJDI, TVal ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x46C9680", Offset = "0x46C8880", VA = "0x1846C9680", Slot = "7")]
	public override void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x46C9540", Offset = "0x46C8740", VA = "0x1846C9540")]
	private bool JDAEDFHMIHI(TKey JCNAPFOCJDI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[DefaultMember("Item")]
public class MLAMKDIPHDH<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public delegate int AECHGGMNPFK(TKey JCNAPFOCJDI, TVal ADBNEBBHMOP);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class MGBAFHOHPAP
	{
		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public TKey MOGKCHDHBJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x62D550", Offset = "0x62C750", VA = "0x18062D550")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public TVal MDDADGNJOKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x623BB0", Offset = "0x622DB0", VA = "0x180623BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public int FFGCGCCOGIH
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x610600", Offset = "0x60F800", VA = "0x180610600")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x7CF0F0", Offset = "0x7CE2F0", VA = "0x1807CF0F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public DateTime EIFCCBCNFFO
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x622F40", Offset = "0x622140", VA = "0x180622F40")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x7003D0", Offset = "0x6FF5D0", VA = "0x1807003D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x15FD9E0", Offset = "0x15FCBE0", VA = "0x1815FD9E0")]
		public MGBAFHOHPAP(TKey JCNAPFOCJDI, TVal AKJAPNHANKH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const int BGLKJGGAENC = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<TKey, LinkedListNode<MGBAFHOHPAP>> OBNKLPLNDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly LinkedList<MGBAFHOHPAP> DKGMADHGBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly AECHGGMNPFK KEONCMJEJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly TimeSpan OAIINDGIBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly JKMBAMDHOFB JCFFOCNKKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int NPCACJPOCKC;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public int DAKMKNJEHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x605670", Offset = "0x604870", VA = "0x180605670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private bool LGGNFBNFEIM
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x15FF470", Offset = "0x15FE670", VA = "0x1815FF470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	internal virtual int OODEPNDCHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8A9080", Offset = "0x8A8280", VA = "0x1808A9080", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	private int AEKEPEKODMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xE92C10", Offset = "0xE91E10", VA = "0x180E92C10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public virtual int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x15FE640", Offset = "0x15FD840", VA = "0x1815FE640", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IEnumerable<TKey> KEDDEBFFHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x15FF750", Offset = "0x15FE950", VA = "0x1815FF750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public TVal LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x1600B90", Offset = "0x15FFD90", VA = "0x181600B90")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x15FF970", Offset = "0x15FEB70", VA = "0x1815FF970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x1600C10", Offset = "0x15FFE10", VA = "0x181600C10")]
	public MLAMKDIPHDH(int GOCCOAPEHDE, [Optional] AECHGGMNPFK KEONCMJEJAE, [Optional] IEqualityComparer<TKey> KHBLBMKIJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x1600BC0", Offset = "0x15FFDC0", VA = "0x181600BC0")]
	public MLAMKDIPHDH(TimeSpan OAIINDGIBAP, [Optional] IEqualityComparer<TKey> KHBLBMKIJEN, [Optional] JKMBAMDHOFB JCFFOCNKKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1601160", Offset = "0x1600360", VA = "0x181601160")]
	public MLAMKDIPHDH(int GOCCOAPEHDE, TimeSpan OAIINDGIBAP, [Optional] IEqualityComparer<TKey> KHBLBMKIJEN, [Optional] JKMBAMDHOFB JCFFOCNKKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x1600CE0", Offset = "0x15FFEE0", VA = "0x181600CE0")]
	public MLAMKDIPHDH(int GOCCOAPEHDE, AECHGGMNPFK KEONCMJEJAE, TimeSpan OAIINDGIBAP, [Optional] IEqualityComparer<TKey> KHBLBMKIJEN, [Optional] JKMBAMDHOFB JCFFOCNKKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x15FFF20", Offset = "0x15FF120", VA = "0x1815FFF20")]
	public void LGHMDENPAIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x15FE7F0", Offset = "0x15FD9F0", VA = "0x1815FE7F0")]
	public void CEAJIHNFBDD(TKey JCNAPFOCJDI, TVal ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x15FE8B0", Offset = "0x15FDAB0", VA = "0x1815FE8B0")]
	public bool CEDMIKNCMLN(TKey JCNAPFOCJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x15FF5B0", Offset = "0x15FE7B0", VA = "0x1815FF5B0")]
	private TVal FCLOOBPJBAH(TKey JOFEMOMAGIJ)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x15FFC50", Offset = "0x15FEE50", VA = "0x1815FFC50", Slot = "6")]
	public virtual bool HNIJFJOBNMJ(TKey JOFEMOMAGIJ, out TVal ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x1600570", Offset = "0x15FF770", VA = "0x181600570", Slot = "7")]
	public virtual void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x15FF2F0", Offset = "0x15FE4F0", VA = "0x1815FF2F0")]
	private bool DNFFEKCFDFE(MGBAFHOHPAP AGJMCFJMFKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x15FEDB0", Offset = "0x15FDFB0", VA = "0x1815FEDB0")]
	private void DGJDDJFHFNB(LinkedListNode<MGBAFHOHPAP> FEBAFHCPEKC, TVal DNIHHNBJJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x16009B0", Offset = "0x15FFBB0", VA = "0x1816009B0")]
	private void NLOPPMNLCMA(TKey JCNAPFOCJDI, TVal ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x1600090", Offset = "0x15FF290", VA = "0x181600090")]
	private void LMKAMEKFDDB(MGBAFHOHPAP AGJMCFJMFKD, TVal DNIHHNBJJIE, int CLDHFBKGCMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DefaultMember("Item")]
public class GPNMIHEFNGI<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly List<T> MDBHJOENILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private HashSet<T> NILGEECKEIG;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xF2A9C0", Offset = "0xF29BC0", VA = "0x180F2A9C0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool BNGNOGOPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x169EAD0", Offset = "0x169DCD0", VA = "0x18169EAD0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x459AB60", Offset = "0x4599D60", VA = "0x18459AB60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x2284830", Offset = "0x2283A30", VA = "0x182284830", Slot = "11")]
	public void Add(T BCDFAIJCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x459A380", Offset = "0x4599580", VA = "0x18459A380")]
	public bool EOLFFDHHMOF(T BCDFAIJCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x459A940", Offset = "0x4599B40", VA = "0x18459A940", Slot = "15")]
	public bool Remove(T BCDFAIJCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x459A500", Offset = "0x4599700", VA = "0x18459A500", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x39F7D10", Offset = "0x39F6F10", VA = "0x1839F7D10", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x459A180", Offset = "0x4599380", VA = "0x18459A180", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x1A30140", Offset = "0x1A2F340", VA = "0x181A30140", Slot = "13")]
	public bool Contains(T BCDFAIJCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x1E06380", Offset = "0x1E05580", VA = "0x181E06380", Slot = "14")]
	public void CopyTo(T[] NAJOFPKLJJG, int LEAMOGPCOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA440", Offset = "0x1CC9640", VA = "0x181CCA440", Slot = "6")]
	public int IndexOf(T BCDFAIJCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x459A650", Offset = "0x4599850", VA = "0x18459A650", Slot = "7")]
	public void Insert(int MJNAIOAAGCG, T BCDFAIJCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x459A710", Offset = "0x4599910", VA = "0x18459A710", Slot = "8")]
	public void RemoveAt(int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x459A2B0", Offset = "0x45994B0", VA = "0x18459A2B0")]
	public void EGJDABAAJPK(Predicate<T> EECGAHKGANG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x459A4D0", Offset = "0x45996D0", VA = "0x18459A4D0")]
	public void FNMLGCJLDLH(Comparison<T> HNPJKMGNPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x459A9C0", Offset = "0x4599BC0", VA = "0x18459A9C0")]
	public GPNMIHEFNGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class JANICPNALBA
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x26CCF70", Offset = "0x26CC170", VA = "0x1826CCF70")]
	public static Vector3 POHBLBDEEKJ(this GameObject NEFMINHNLIG, float HMOMMDNALIC)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x9E1DF0", Offset = "0x9E0FF0", VA = "0x1809E1DF0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x26D4070", Offset = "0x26D3270", VA = "0x1826D4070")]
		public SerializedGuid(in Guid DHMJIJECAJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x26D3E90", Offset = "0x26D3090", VA = "0x1826D3E90")]
		public static SerializedGuid IDKGILAOPEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x26D3E00", Offset = "0x26D3000", VA = "0x1826D3E00")]
		public static SerializedGuid GENEKNLIDIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x26D3BC0", Offset = "0x26D2DC0", VA = "0x1826D3BC0")]
		public bool AEDNLGNMBLH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x26D4040", Offset = "0x26D3240", VA = "0x1826D4040", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x26D3FA0", Offset = "0x26D31A0", VA = "0x1826D3FA0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x26D3F10", Offset = "0x26D3110", VA = "0x1826D3F10")]
		public bool KCEJIHLPAFP(in Guid DHMJIJECAJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x26D3C80", Offset = "0x26D2E80", VA = "0x1826D3C80", Slot = "7")]
		public bool Equals(SerializedGuid GHOINNFPLDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x26D3D20", Offset = "0x26D2F20", VA = "0x1826D3D20", Slot = "0")]
		public override bool Equals(object PBKPNJLDBOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x26D3E80", Offset = "0x26D3080", VA = "0x1826D3E80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x26D3C50", Offset = "0x26D2E50", VA = "0x1826D3C50", Slot = "6")]
		public int CompareTo(SerializedGuid GHOINNFPLDF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class GPBGLABBMMM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public readonly Type JNDBPAMMJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public readonly string DCDAHFIOFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public readonly bool BPBDPJBJFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public readonly bool BDGELJGPBHP;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x26CC010", Offset = "0x26CB210", VA = "0x1826CC010")]
	public GPBGLABBMMM(Type MOHNDMJPJDM, string CEFEOHCDLBJ, bool JDJKBPLGEHO = false, bool OKLPHBIMFFN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface PLNMFAHJHHE
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface HJLIGLIDHLK<T> : PLNMFAHJHHE
{
	[Cpp2IlInjected.Token(Token = "0x17000078")]
	T MDDADGNJOKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	bool PLMAHGMHABA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	string KAHKLOILIGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::HJLIGLIDHLK<T> JFHDNGMLLIN(Action<T> MCFHJPHKHAP);

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::HJLIGLIDHLK<T> OEMBMLDFEEL(Action<T> MCFHJPHKHAP);

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::HJLIGLIDHLK<T> IBKINFJFJDC(Action<T, T> CFMGKEBNGOC);

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::HJLIGLIDHLK<T> PJBJDNIFPLL(Action<T, T> CFMGKEBNGOC);

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::HJLIGLIDHLK<T> JAHBHBGOLOH(Action<string> EIDKPKMMCFM);

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::HJLIGLIDHLK<T> AGAAAEKDJOK(Action<string> EIDKPKMMCFM);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class MKICCOEGENE<T> : global::HJLIGLIDHLK<T>, PLNMFAHJHHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private global::NOGAHDENHIE<T, T> DCBJLAAMNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private global::FKOLNGKNIEI<T> MODCFNFALLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private global::FKOLNGKNIEI<string> IMDGMNFFNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private string IEPGAFBBMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private T LHPJBAGJLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool LLBGICEEIPC;

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T MDDADGNJOKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x734270", Offset = "0x733470", VA = "0x180734270", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x1C94820", Offset = "0x1C93A20", VA = "0x181C94820", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool PLMAHGMHABA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x9A4880", Offset = "0x9A3A80", VA = "0x1809A4880", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public string KAHKLOILIGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x622F40", Offset = "0x622140", VA = "0x180622F40", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x1B36700", Offset = "0x1B35900", VA = "0x181B36700", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x1C94600", Offset = "0x1C93800", VA = "0x181C94600")]
	private void CGCKBGBOJEO(T FDBJMNOLEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x1C946A0", Offset = "0x1C938A0", VA = "0x181C946A0")]
	private void HHCKFMCFCII(string HGHEMBBLDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x1C948E0", Offset = "0x1C93AE0", VA = "0x181C948E0")]
	public void MJIFHFDNIAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x1C94740", Offset = "0x1C93940", VA = "0x181C94740", Slot = "6")]
	public global::HJLIGLIDHLK<T> IBKINFJFJDC(Action<T, T> CFMGKEBNGOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x1C949E0", Offset = "0x1C93BE0", VA = "0x181C949E0", Slot = "7")]
	public global::HJLIGLIDHLK<T> PJBJDNIFPLL(Action<T, T> CFMGKEBNGOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x1C94850", Offset = "0x1C93A50", VA = "0x181C94850", Slot = "4")]
	public global::HJLIGLIDHLK<T> JFHDNGMLLIN(Action<T> CFMGKEBNGOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x1C94990", Offset = "0x1C93B90", VA = "0x181C94990", Slot = "5")]
	public global::HJLIGLIDHLK<T> OEMBMLDFEEL(Action<T> MCFHJPHKHAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x1C94790", Offset = "0x1C93990", VA = "0x181C94790", Slot = "8")]
	public global::HJLIGLIDHLK<T> JAHBHBGOLOH(Action<string> EIDKPKMMCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x1C94590", Offset = "0x1C93790", VA = "0x181C94590", Slot = "9")]
	public global::HJLIGLIDHLK<T> AGAAAEKDJOK(Action<string> EIDKPKMMCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x1C94A30", Offset = "0x1C93C30", VA = "0x181C94A30")]
	public MKICCOEGENE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class BLIIGEGHPCI
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class ONPCAPFNMNA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public global::HJLIGLIDHLK<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::OKHIKHGPKEJ<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		public ONPCAPFNMNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x421C920", Offset = "0x421BB20", VA = "0x18421C920")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x38304F0", Offset = "0x382F6F0", VA = "0x1838304F0")]
	public static global::GDKGOJJDLGI<T> JPMCGEINDNN<T>(this global::HJLIGLIDHLK<T> IIJEPCAIOJI, Action<T> ELMGCHGCEJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class AHNHODFKKCG<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public readonly struct ABKLLNIOANH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly long FDDAKBIEHMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public readonly long LBPHJHJHOEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public readonly int MJPPIGEPNFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public readonly int NAHFOBDGDFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly bool HKJGCLGFELF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly string BLIHONDALLA;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x4535820", Offset = "0x4534A20", VA = "0x184535820")]
		public ABKLLNIOANH(long FDDAKBIEHMO, int MJPPIGEPNFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x45357F0", Offset = "0x45349F0", VA = "0x1845357F0")]
		public ABKLLNIOANH(long FDDAKBIEHMO, long LBPHJHJHOEE, int MJPPIGEPNFA, int NAHFOBDGDFE, bool HKJGCLGFELF, string BLIHONDALLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x45355E0", Offset = "0x45347E0", VA = "0x1845355E0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CMOIJEGGPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x4535730", Offset = "0x4534930", VA = "0x184535730")]
		public int OBAGGPEMALJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x4535650", Offset = "0x4534850", VA = "0x184535650")]
		public int DCJLHIIKFFI(int PPMIICFHDKL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x4535780", Offset = "0x4534980", VA = "0x184535780")]
		public double POOLPMAKHNP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x4535670", Offset = "0x4534870", VA = "0x184535670")]
		public ABKLLNIOANH ELCKLDHOOMC(long LBPHJHJHOEE, int NAHFOBDGDFE)
		{
			return default(ABKLLNIOANH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class CIHEPFKAKNH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public readonly TKey MOGKCHDHBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly global::AHNHODFKKCG<TKey> NDCCOMJDOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private List<CIHEPFKAKNH> CGNAEOINDHH;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public string KBEEIGAPLFI
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x1340680", Offset = "0x133F880", VA = "0x181340680")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x4114140", Offset = "0x4113340", VA = "0x184114140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public IEnumerable<CIHEPFKAKNH> KGMJAAFNPCE
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x45402F0", Offset = "0x453F4F0", VA = "0x1845402F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public ABKLLNIOANH NCLEGBKEGIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0xE11690", Offset = "0xE10890", VA = "0x180E11690")]
			[CompilerGenerated]
			get
			{
				return default(ABKLLNIOANH);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x4540310", Offset = "0x453F510", VA = "0x184540310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x4540550", Offset = "0x453F750", VA = "0x184540550")]
		internal CIHEPFKAKNH(global::AHNHODFKKCG<TKey> NDCCOMJDOFK, TKey JCNAPFOCJDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x4540340", Offset = "0x453F540", VA = "0x184540340")]
		public CIHEPFKAKNH LAMGHNLLHHH(TKey JCNAPFOCJDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x4540450", Offset = "0x453F650", VA = "0x184540450")]
		public void OBHPDOFLJLO(TKey JCNAPFOCJDI, Action<CIHEPFKAKNH> GHCLFMPOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x38478B0", Offset = "0x3846AB0", VA = "0x1838478B0")]
		public T OBHPDOFLJLO<T>(TKey JCNAPFOCJDI, Func<CIHEPFKAKNH, T> EMDDKFAAHLO)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x385B1E0", Offset = "0x385A3E0", VA = "0x18385B1E0")]
		[AsyncStateMachine(typeof(GHCGLKOAGGK))]
		public Task<T> HEOAGPENBHO<T>(TKey JCNAPFOCJDI, Func<CIHEPFKAKNH, Task<T>> EMDDKFAAHLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x4540130", Offset = "0x453F330", VA = "0x184540130", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class EPENMCJMLJP : IEnumerable<(TKey, List<TKey>, ABKLLNIOANH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, ABKLLNIOANH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private (TKey key, List<TKey> path, ABKLLNIOANH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public global::AHNHODFKKCG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private IEnumerator<(TKey key, List<TKey> path, ABKLLNIOANH timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		private (TKey, List<TKey>, ABKLLNIOANH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x4540D10", Offset = "0x453FF10", VA = "0x184540D10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, ABKLLNIOANH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x4541FE0", Offset = "0x45411E0", VA = "0x184541FE0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x4540F60", Offset = "0x4540160", VA = "0x184540F60")]
		[DebuggerHidden]
		public EPENMCJMLJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x4542040", Offset = "0x4541240", VA = "0x184542040", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x4541C60", Offset = "0x4540E60", VA = "0x184541C60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x45420C0", Offset = "0x45412C0", VA = "0x1845420C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x4541F90", Offset = "0x4541190", VA = "0x184541F90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x4541ED0", Offset = "0x45410D0", VA = "0x184541ED0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, ABKLLNIOANH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x21AAA00", Offset = "0x21A9C00", VA = "0x1821AAA00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class CLNKJBGMLNK : IEnumerable<(TKey, List<TKey>, ABKLLNIOANH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, ABKLLNIOANH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private (TKey key, List<TKey> path, ABKLLNIOANH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private CIHEPFKAKNH timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public CIHEPFKAKNH <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public global::AHNHODFKKCG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private IEnumerator<CIHEPFKAKNH> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private IEnumerator<(TKey key, List<TKey> path, ABKLLNIOANH timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		private (TKey, List<TKey>, ABKLLNIOANH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x4540D10", Offset = "0x453FF10", VA = "0x184540D10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, ABKLLNIOANH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x4540D90", Offset = "0x453FF90", VA = "0x184540D90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x4540F60", Offset = "0x4540160", VA = "0x184540F60")]
		[DebuggerHidden]
		public CLNKJBGMLNK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x4540DF0", Offset = "0x453FFF0", VA = "0x184540DF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x4540700", Offset = "0x453F900", VA = "0x184540700", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x4540EC0", Offset = "0x45400C0", VA = "0x184540EC0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x4540F10", Offset = "0x4540110", VA = "0x184540F10")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x4540D40", Offset = "0x453FF40", VA = "0x184540D40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x4540C40", Offset = "0x453FE40", VA = "0x184540C40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, ABKLLNIOANH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x1CCB100", Offset = "0x1CCA300", VA = "0x181CCB100", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Action<TKey, ABKLLNIOANH> EAHKKPEEKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Action<TKey, ABKLLNIOANH> BFABFOFOHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Action<global::AHNHODFKKCG<TKey>> FBNBCIDPOCK;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private const string BDBIOGFMKFB = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly CIHEPFKAKNH ILPMAIAPFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private bool ODHDMLLLNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int PJKGANDHAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Stopwatch PKCGGAGOMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public readonly int FABDMCOOHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private string FLJKDALBCDN;

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public CIHEPFKAKNH HKAPODAFIAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x622F40", Offset = "0x622140", VA = "0x180622F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	[NotNull]
	public string KBEEIGAPLFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x5F8940", Offset = "0x5F7B40", VA = "0x1805F8940")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x4535B10", Offset = "0x4534D10", VA = "0x184535B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public long BKBOMMJBDFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x4535AD0", Offset = "0x4534CD0", VA = "0x184535AD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public int HNAPOFOOAFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x4535AA0", Offset = "0x4534CA0", VA = "0x184535AA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x4535C00", Offset = "0x4534E00", VA = "0x184535C00")]
	public AHNHODFKKCG(TKey JPDPINABMIF, [Optional] int? MJPPIGEPNFA, [Optional][CanBeNull] Stopwatch PKCGGAGOMBP, [Optional] Action<TKey, ABKLLNIOANH> EAHKKPEEKKC, [Optional] Action<TKey, ABKLLNIOANH> BFABFOFOHLP, [Optional] Action<global::AHNHODFKKCG<TKey>> FBNBCIDPOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x4535A10", Offset = "0x4534C10", VA = "0x184535A10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x4535AF0", Offset = "0x4534CF0", VA = "0x184535AF0")]
	public void HDINKKPFLJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x45359F0", Offset = "0x4534BF0", VA = "0x1845359F0")]
	public void COGOOKAOBBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x4535890", Offset = "0x4534A90", VA = "0x184535890")]
	[IteratorStateMachine(typeof(global::AHNHODFKKCG<>.EPENMCJMLJP))]
	public IEnumerable<(TKey, List<TKey>, ABKLLNIOANH)> BIICEGCBMAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x4535920", Offset = "0x4534B20", VA = "0x184535920")]
	[IteratorStateMachine(typeof(global::AHNHODFKKCG<>.CLNKJBGMLNK))]
	private IEnumerable<(TKey, List<TKey>, ABKLLNIOANH)> BIICEGCBMAF(List<TKey> DLBDGCGKOKN, CIHEPFKAKNH JAMIJLLLFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x4535B70", Offset = "0x4534D70", VA = "0x184535B70")]
	private (long, int) MACNLAHHNLO()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public abstract class CEDFNJMFAHN<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut JHKMHABLILA(global::AHNHODFKKCG<TKey> NDCCOMJDOFK);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
	protected CEDFNJMFAHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public abstract class EEEHGMNKGIO<TKey> : global::CEDFNJMFAHN<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public delegate string JHOKBJIKBEG(TKey JCNAPFOCJDI);

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x465F440", Offset = "0x465E640", VA = "0x18465F440")]
	protected string IGICPIPDFLC(double AEBINMDEPEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x465F670", Offset = "0x465E870", VA = "0x18465F670")]
	protected string KBDOEJKCMHE(int IONDOHGENOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x465F6C0", Offset = "0x465E8C0", VA = "0x18465F6C0")]
	private static string NKNKCAGDCIL(TKey JCNAPFOCJDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x465F5C0", Offset = "0x465E7C0", VA = "0x18465F5C0", Slot = "4")]
	public override string JHKMHABLILA(global::AHNHODFKKCG<TKey> NDCCOMJDOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x465F4A0", Offset = "0x465E6A0", VA = "0x18465F4A0")]
	public string JHKMHABLILA(global::AHNHODFKKCG<TKey> NDCCOMJDOFK, [NotNull] JHOKBJIKBEG EGCJPGGIPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string AEEMAPEOLBL(global::AHNHODFKKCG<TKey> NDCCOMJDOFK, [NotNull] JHOKBJIKBEG EGCJPGGIPLH);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4520", Offset = "0x1CC3720", VA = "0x181CC4520")]
	protected EEEHGMNKGIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class IFDDOLDFGIA<TKey> : global::CEDFNJMFAHN<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public delegate string PJPEIKGAEBH(TKey JCNAPFOCJDI);

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int CPAGIEBANGB = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly string LJBEBKLPEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly double DPJHEFCCKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly bool PDLGALFOLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly int LOBEDJCPAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly ISet<string> FHLPGIECBKH;

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x4114D60", Offset = "0x4113F60", VA = "0x184114D60")]
	private static string NKNKCAGDCIL(TKey JCNAPFOCJDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x4114DA0", Offset = "0x4113FA0", VA = "0x184114DA0")]
	public IFDDOLDFGIA(string LJBEBKLPEOD = "F2", double DPJHEFCCKAE = double.MaxValue, bool PDLGALFOLGL = false, int LOBEDJCPAFM = int.MaxValue, [Optional] ISet<string> FHLPGIECBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x4114B00", Offset = "0x4113D00", VA = "0x184114B00", Slot = "4")]
	public override Dictionary<string, string> JHKMHABLILA(global::AHNHODFKKCG<TKey> NDCCOMJDOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x4114580", Offset = "0x4113780", VA = "0x184114580")]
	private bool DOAFMCEAFDC(string IKCHDFNFKAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x4114660", Offset = "0x4113860", VA = "0x184114660")]
	public Dictionary<string, string> JHKMHABLILA(global::AHNHODFKKCG<TKey> NDCCOMJDOFK, PJPEIKGAEBH EGCJPGGIPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x4114BB0", Offset = "0x4113DB0", VA = "0x184114BB0")]
	private string KAFEECMALNL(StringBuilder DINCBBLKCFI, List<TKey> NKJHMDGLGNO, PJPEIKGAEBH EGCJPGGIPLH, bool GMDLALPKPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x4114420", Offset = "0x4113620", VA = "0x184114420")]
	private static void CGOJGBBHDDF(StringBuilder EAAHGEDKLLN, string MPJCKGJBDGB, bool JADBCMKLMOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class FBCPFIIDFCI<TKey> : global::EEEHGMNKGIO<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct ELMFGDOCPED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JHOKBJIKBEG keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static global::FBCPFIIDFCI<TKey> HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int NJDFDCKLELJ = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly string[] BIODHIJHJBD;

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x478C560", Offset = "0x478B760", VA = "0x18478C560")]
	private FBCPFIIDFCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x478B560", Offset = "0x478A760", VA = "0x18478B560", Slot = "5")]
	protected override string AEEMAPEOLBL(global::AHNHODFKKCG<TKey> NDCCOMJDOFK, JHOKBJIKBEG EGCJPGGIPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x478C380", Offset = "0x478B580", VA = "0x18478C380")]
	[CompilerGenerated]
	internal static string CNBKJJMNOEC(string JDKOIKPCELH, TKey JCNAPFOCJDI, ref ELMFGDOCPED P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class PMBDBNOGIEC<TKey> : global::EEEHGMNKGIO<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class OOALDMPENIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public JHOKBJIKBEG keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		public OOALDMPENIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x133FC40", Offset = "0x133EE40", VA = "0x18133FC40")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x452F020", Offset = "0x452E220", VA = "0x18452F020", Slot = "5")]
	protected override string AEEMAPEOLBL(global::AHNHODFKKCG<TKey> NDCCOMJDOFK, JHOKBJIKBEG EGCJPGGIPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x1C943C0", Offset = "0x1C935C0", VA = "0x181C943C0")]
	public PMBDBNOGIEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public sealed class CEEEMBIAJAF : global::AHNHODFKKCG<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class OBEJGNIPOCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public Action<CEEEMBIAJAF> callback;

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public OBEJGNIPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x26D1690", Offset = "0x26D0890", VA = "0x1826D1690")]
		internal void <Wrap>b__0(global::AHNHODFKKCG<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x26CAE50", Offset = "0x26CA050", VA = "0x1826CAE50")]
	public CEEEMBIAJAF([Optional] string GNMFAGMKIOB, [Optional] int? MJPPIGEPNFA, [Optional] Stopwatch PKCGGAGOMBP, [Optional] Action<string, ABKLLNIOANH> EAHKKPEEKKC, [Optional] Action<string, ABKLLNIOANH> BFABFOFOHLP, [Optional] Action<CEEEMBIAJAF> FBNBCIDPOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x26CAD90", Offset = "0x26C9F90", VA = "0x1826CAD90")]
	private static Action<global::AHNHODFKKCG<string>> OBHPDOFLJLO(Action<CEEEMBIAJAF> ELMGCHGCEJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public abstract class JKMBAMDHOFB
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private class OMICPPPKILM : JKMBAMDHOFB
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public static JKMBAMDHOFB HBKBBJLFPOI
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x26D1C80", Offset = "0x26D0E80", VA = "0x1826D1C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public override DateTime ACICAFBJPID
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x26D1CE0", Offset = "0x26D0EE0", VA = "0x1826D1CE0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public override float CNEPENFJODI
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x26D1D30", Offset = "0x26D0F30", VA = "0x1826D1D30", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x26D1DE0", Offset = "0x26D0FE0", VA = "0x1826D1DE0")]
		public OMICPPPKILM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static JKMBAMDHOFB ONLGBMKEKJH;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public static JKMBAMDHOFB HPMHEACECHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x26CDFA0", Offset = "0x26CD1A0", VA = "0x1826CDFA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public abstract DateTime ACICAFBJPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public abstract float CNEPENFJODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	protected JKMBAMDHOFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class MPKDGPPMOPF : global::MIGBLJJGOLF<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x26D1520", Offset = "0x26D0720", VA = "0x1826D1520")]
	public MPKDGPPMOPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class MIGBLJJGOLF<T> : global::PLAJGGCOHJE<T>, FKJIIKADHIG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Task<T> GNDKIKHLFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Task CBLFDFGNIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA90", Offset = "0xE8AC90", VA = "0x180E8BA90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public global::GDKGOJJDLGI<T> EMINKDNPHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private NOJPGNEJCEO HCMFHJLNIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x1C91DC0", Offset = "0x1C90FC0", VA = "0x181C91DC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x1C91DF0", Offset = "0x1C90FF0", VA = "0x181C91DF0")]
	public MIGBLJJGOLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class FJKPCEPHINO : global::EFBHDKJJLCF<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x26CBDE0", Offset = "0x26CAFE0", VA = "0x1826CBDE0")]
	public FJKPCEPHINO(Exception MAMHFFLAIIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class EFBHDKJJLCF<T> : global::PLAJGGCOHJE<T>, FKJIIKADHIG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Task<T> GNDKIKHLFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private Task CBLFDFGNIAH
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA90", Offset = "0xE8AC90", VA = "0x180E8BA90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public global::GDKGOJJDLGI<T> EMINKDNPHCC
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private NOJPGNEJCEO HCMFHJLNIID
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x1C91DC0", Offset = "0x1C90FC0", VA = "0x181C91DC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x4660CD0", Offset = "0x465FED0", VA = "0x184660CD0")]
	public EFBHDKJJLCF(Exception MAMHFFLAIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface FKJIIKADHIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000097")]
	[NotNull]
	Task GNDKIKHLFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	[NotNull]
	NOJPGNEJCEO EMINKDNPHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface PLAJGGCOHJE<T> : FKJIIKADHIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000099")]
	[NotNull]
	new Task<T> GNDKIKHLFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	[NotNull]
	new global::GDKGOJJDLGI<T> EMINKDNPHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public abstract class ONAPAGKMHPA<TTask, T> : global::PLAJGGCOHJE<T>, FKJIIKADHIG, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class FFONLCOKLOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public global::ONAPAGKMHPA<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		public FFONLCOKLOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static bool MPNGKJECILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly Task<T> HAJJIJILELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	protected readonly CancellationTokenSource OEEOLLPACLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private bool ODHDMLLLNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private SynchronizationContext DEEEOIAEKOB;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Task<T> GNDKIKHLFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private Task CBLFDFGNIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public global::GDKGOJJDLGI<T> EMINKDNPHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private NOJPGNEJCEO HCMFHJLNIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x12085B0", Offset = "0x12077B0", VA = "0x1812085B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool DBJPCLELEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x7E7390", Offset = "0x7E6590", VA = "0x1807E7390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3ECFDF0", Offset = "0x3ECEFF0", VA = "0x183ECFDF0")]
	static ONAPAGKMHPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x3ED0280", Offset = "0x3ECF480", VA = "0x183ED0280")]
	protected ONAPAGKMHPA(TTask HAJJIJILELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3ECFD50", Offset = "0x3ECEF50", VA = "0x183ECFD50", Slot = "1")]
	~ONAPAGKMHPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3ECFC80", Offset = "0x3ECEE80", VA = "0x183ECFC80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3ECF9A0", Offset = "0x3ECEBA0", VA = "0x183ECF9A0")]
	private void DIPAICNNLME(bool HIEMIBDCAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T KLPIFCMCHJN(TTask OKHGLMHKOML);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void KIMGPNJGKGI();

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x3ECF950", Offset = "0x3ECEB50", VA = "0x183ECF950")]
	[CompilerGenerated]
	private void ACNGLHJECAK(object DPMFCNNBNAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface DGILGBLHKKK
{
	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	float DHDAOMCPKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event JEOFJMEBFME BHJJOLGJFCO;
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class KBPNBEMIOLG : DGILGBLHKKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public readonly struct PEGNLLKKJMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public readonly float LPCFCGJIHMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public readonly float AALALEOFLKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		internal readonly bool MJFCPIFHOGF;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float FFGCGCCOGIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x26D1E40", Offset = "0x26D1040", VA = "0x1826D1E40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x26D1FB0", Offset = "0x26D11B0", VA = "0x1826D1FB0")]
		public PEGNLLKKJMC(float FLFAMDBICFJ, float FOKHGDFDAEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x26D1E50", Offset = "0x26D1050", VA = "0x1826D1E50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class PKOCHIGCGFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public KBPNBEMIOLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public PKOCHIGCGFF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly int GOCCOAPEHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private int ONBIAGCJNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly DGILGBLHKKK[] ECGELKMLDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly JEOFJMEBFME[] FEPEKJBDLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly PEGNLLKKJMC[] JEIOAHOBHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private PEGNLLKKJMC LJKDKMDLHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly MOPMEHDPIJM BEMMNGFNHAD;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public PEGNLLKKJMC DGGKKDFIPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x148DF50", Offset = "0x148D150", VA = "0x18148DF50")]
		get
		{
			return default(PEGNLLKKJMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float DHDAOMCPKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x26CEDE0", Offset = "0x26CDFE0", VA = "0x1826CEDE0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event JEOFJMEBFME BHJJOLGJFCO
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x26CE8F0", Offset = "0x26CDAF0", VA = "0x1826CE8F0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x26CE650", Offset = "0x26CD850", VA = "0x1826CE650", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x26CEE80", Offset = "0x26CE080", VA = "0x1826CEE80")]
	public KBPNBEMIOLG(int GOCCOAPEHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x26CEE00", Offset = "0x26CE000", VA = "0x1826CEE00")]
	public MOPMEHDPIJM PEHKMOFJPAH(PEGNLLKKJMC BDGFDBONONK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x26CE9B0", Offset = "0x26CDBB0", VA = "0x1826CE9B0")]
	public void HELDMLLDKJM(DGILGBLHKKK MNPJDBHBBLD, [Optional] PEGNLLKKJMC LNPFEMLBLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x26CE710", Offset = "0x26CD910", VA = "0x1826CE710")]
	internal int CHJPILKFEHL(DGILGBLHKKK BBPIMOBLHBL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x26CED90", Offset = "0x26CDF90", VA = "0x1826CED90")]
	internal PEGNLLKKJMC KGGMALOHKDC(int MJNAIOAAGCG)
	{
		return default(PEGNLLKKJMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x26CE760", Offset = "0x26CD960", VA = "0x1826CE760", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public delegate void JEOFJMEBFME(float KNCEFPKIICO);
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal static class FDGPCKHFGBP
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	internal const float NIBFIOBNHPJ = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class LKLKCBOCCPL
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class EBGGLCNOHMI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly DGILGBLHKKK BBPIMOBLHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private readonly JEOFJMEBFME ELMGCHGCEJD;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x26CB640", Offset = "0x26CA840", VA = "0x1826CB640")]
		public EBGGLCNOHMI(DGILGBLHKKK BBPIMOBLHBL, JEOFJMEBFME ELMGCHGCEJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x26CB5F0", Offset = "0x26CA7F0", VA = "0x1826CB5F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x26D1290", Offset = "0x26D0490", VA = "0x1826D1290")]
	internal static bool LGILDDGMNOK(float PJIOBOBOEGF, float KLGGEDCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x1A95C20", Offset = "0x1A94E20", VA = "0x181A95C20")]
	internal static float NCMMAMGFIHM(float PJIOBOBOEGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x26D11D0", Offset = "0x26D03D0", VA = "0x1826D11D0")]
	public static IDisposable INGIINAPFBI(this DGILGBLHKKK BBPIMOBLHBL, JEOFJMEBFME ELMGCHGCEJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class MOPMEHDPIJM : DGILGBLHKKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private float KNCEFPKIICO;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float DHDAOMCPKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7DB5B0", Offset = "0x7DA7B0", VA = "0x1807DB5B0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x26D1450", Offset = "0x26D0650", VA = "0x1826D1450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event JEOFJMEBFME BHJJOLGJFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x26D13B0", Offset = "0x26D05B0", VA = "0x1826D13B0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x26D1310", Offset = "0x26D0510", VA = "0x1826D1310", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public MOPMEHDPIJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class OLJMHGLIEDD
{
	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x26D1BA0", Offset = "0x26D0DA0", VA = "0x1826D1BA0")]
	[NotNull]
	public static byte[] MMFHNFHJANO(this NGMNPBPGABM KDOAMOCDPBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x26D1B30", Offset = "0x26D0D30", VA = "0x1826D1B30")]
	[NotNull]
	public static byte[] MMFHNFHJANO(this NGMNPBPGABM KDOAMOCDPBJ, HashAlgorithmName FGODLKNDICJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x26D1840", Offset = "0x26D0A40", VA = "0x1826D1840")]
	public static bool HEBPBPIOMCA([CanBeNull] this NGMNPBPGABM KDOAMOCDPBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x26D19B0", Offset = "0x26D0BB0", VA = "0x1826D19B0")]
	public static bool HEBPBPIOMCA([CanBeNull] this NGMNPBPGABM KDOAMOCDPBJ, out string IEPGAFBBMGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x26D1C10", Offset = "0x26D0E10", VA = "0x1826D1C10")]
	private static string NINNPMMCHIF([CanBeNull] byte[] FAOJAOEJLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x26D1710", Offset = "0x26D0910", VA = "0x1826D1710")]
	private static bool FGIDFMAOMHN([NotNull] NGMNPBPGABM KDOAMOCDPBJ, [CanBeNull] out byte[] HGGHAHEPMBD, [CanBeNull] out byte[] BAGGEAAGIOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class PIKMBPFPKFJ
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x26D20E0", Offset = "0x26D12E0", VA = "0x1826D20E0")]
	[NotNull]
	public static byte[] MMFHNFHJANO(this OCJIFHHOAOJ GNPMJJIGPOD, byte[] ADGGADBLINM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x26D2120", Offset = "0x26D1320", VA = "0x1826D2120")]
	[NotNull]
	public static byte[] MMFHNFHJANO(this OCJIFHHOAOJ GNPMJJIGPOD, HashAlgorithmName FGODLKNDICJ, byte[] ADGGADBLINM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public interface OCJIFHHOAOJ
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash HGCLPJPLDLN);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public interface NGMNPBPGABM : OCJIFHHOAOJ
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	[CanBeNull]
	byte[] NAPBCHAFKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	[CanBeNull]
	byte[] LGOKIKPNDEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	UnityEngine.Object JNFGKGNGBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public static class LAAJCOBMKIO
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class JONKICCKDGO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x26CE180", Offset = "0x26CD380", VA = "0x1826CE180")]
		public JONKICCKDGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x26CE120", Offset = "0x26CD320", VA = "0x1826CE120", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private const byte KOECCOJGEGJ = 1;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private const byte PPLAAEICFFI = 0;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly ArrayPool<byte> CLNLELPEHOF;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static bool KEJHLEHGMOG;

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x3D52FD0", Offset = "0x3D521D0", VA = "0x183D52FD0")]
	[Conditional("UNITY_EDITOR")]
	private static void ONNMJPPGGGB<T>(params T[] NFNOHDKBCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x26CF8B0", Offset = "0x26CEAB0", VA = "0x1826CF8B0")]
	public static IDisposable IELBNIAKCHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x26CFF80", Offset = "0x26CF180", VA = "0x1826CFF80")]
	public static void MMANBKKMMNO(this IncrementalHash IPLCBPCDNLF, [CanBeNull] GameObject NEFMINHNLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x3D52F10", Offset = "0x3D52110", VA = "0x183D52F10")]
	public static void MMANBKKMMNO<T>(this IncrementalHash IPLCBPCDNLF, [CanBeNull] T OFADDADJKKI) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x3D52E80", Offset = "0x3D52080", VA = "0x183D52E80")]
	public static void LAHIHLGLOCB<T>(this IncrementalHash IPLCBPCDNLF, [CanBeNull] T GNPMJJIGPOD) where T : OCJIFHHOAOJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x3D52A20", Offset = "0x3D51C20", VA = "0x183D52A20")]
	public static void KIHEAKLJCIL<T>(this IncrementalHash IPLCBPCDNLF, [CanBeNull] IList<T> AIFDCPGJIDD) where T : OCJIFHHOAOJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x26CF1B0", Offset = "0x26CE3B0", VA = "0x1826CF1B0")]
	private static bool EBJJEFMMCOP([CanBeNull] OCJIFHHOAOJ GNPMJJIGPOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x26CFD30", Offset = "0x26CEF30", VA = "0x1826CFD30")]
	public static void MCNAHDBAILJ(this IncrementalHash HGCLPJPLDLN, [CanBeNull] string IOOFAGPMONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x26CF660", Offset = "0x26CE860", VA = "0x1826CF660")]
	public static void FKCBNNAJGMH(this IncrementalHash HGCLPJPLDLN, long CBDLLJPPGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x26CFD90", Offset = "0x26CEF90", VA = "0x1826CFD90")]
	public static void MEMCFIDJBAF(this IncrementalHash HGCLPJPLDLN, int CJOMNOAJOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x26D0060", Offset = "0x26CF260", VA = "0x1826D0060")]
	public static void PHDHPNKOPHP(this IncrementalHash HGCLPJPLDLN, short LACGMAPGELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x26CF950", Offset = "0x26CEB50", VA = "0x1826CF950")]
	public static void IIFFOCFOMIH(this IncrementalHash HGCLPJPLDLN, byte MHJGNINMJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x26CF410", Offset = "0x26CE610", VA = "0x1826CF410")]
	public static void EODHJEOGHNJ(this IncrementalHash HGCLPJPLDLN, bool OMDENIOCMLH, bool KIJDMGEBIGE = false, bool HFNHLDGJLBH = false, bool KJFNOJJEJHL = false, bool LKEMMMJCIKP = false, bool NOHNCHHKIID = false, bool NHFAJBMKCNM = false, bool BDAFEHBHNMG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3D523B0", Offset = "0x3D515B0", VA = "0x183D523B0")]
	public static void IDKIILLLALB<T>(this IncrementalHash HGCLPJPLDLN, T BFAJJAMJKLN) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x26CFAE0", Offset = "0x26CECE0", VA = "0x1826CFAE0")]
	public static void INHLOOFAJPG(this IncrementalHash HGCLPJPLDLN, float MLEBDADDHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x26CF600", Offset = "0x26CE800", VA = "0x1826CF600")]
	public static void FKANAELJICP(this IncrementalHash HGCLPJPLDLN, double OBLDAKBONIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x26CFB40", Offset = "0x26CED40", VA = "0x1826CFB40")]
	public static void LDONEMJEHFO(this IncrementalHash HGCLPJPLDLN, ulong AAFPNDNOIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x26CF850", Offset = "0x26CEA50", VA = "0x1826CF850")]
	public static void HDENFFACELE(this IncrementalHash HGCLPJPLDLN, uint MFCKCKDNPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x26D0250", Offset = "0x26CF450", VA = "0x1826D0250")]
	public static void PJAFJALPFJO(this IncrementalHash HGCLPJPLDLN, ushort MGPOGKKMFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x26CFBB0", Offset = "0x26CEDB0", VA = "0x1826CFBB0")]
	public static void LHLCHOBLLMP(this IncrementalHash HGCLPJPLDLN, Vector3 AJLKNFFMOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x26CF260", Offset = "0x26CE460", VA = "0x1826CF260")]
	public static void EKPIHLDGOOJ(this IncrementalHash HGCLPJPLDLN, Quaternion MCPDLNCPINH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class FFNCACACBJI : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public readonly Type JNDBPAMMJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public readonly string DCDAHFIOFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public readonly bool BPBDPJBJFCN;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x26CBD80", Offset = "0x26CAF80", VA = "0x1826CBD80")]
	public FFNCACACBJI(Type MOHNDMJPJDM, string CEFEOHCDLBJ, bool JDJKBPLGEHO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class AMOIIJCPGJP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x26CAB20", Offset = "0x26C9D20", VA = "0x1826CAB20")]
	public AMOIIJCPGJP(string HGHEMBBLDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x26CAB90", Offset = "0x26C9D90", VA = "0x1826CAB90")]
	public AMOIIJCPGJP(string HGHEMBBLDIC, Exception JFPPAOGPCNB)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x62D550", Offset = "0x62C750", VA = "0x18062D550")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x7CC210", Offset = "0x7CB410", VA = "0x1807CC210")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public T this[int OCLFFJGEIJK, int CFGPOPGGKIH]
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x3A189D0", Offset = "0x3A17BD0", VA = "0x183A189D0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x3A18A70", Offset = "0x3A17C70", VA = "0x183A18A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x3A18940", Offset = "0x3A17B40", VA = "0x183A18940")]
		public Array2D(uint FNNLNDILPIG, uint AKPHHICECEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x3A188C0", Offset = "0x3A17AC0", VA = "0x183A188C0")]
		public void NLALCDJNEAF()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x26CAC10", Offset = "0x26C9E10", VA = "0x1826CAC10")]
		public Array2DVector3(uint FNNLNDILPIG, uint AKPHHICECEJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal static class CKAONJLIDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public const int JBKEIHEAFAP = -1;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public const int ELOFIIKHKEL = 0;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[DefaultMember("Item")]
public class OKHLJPIHHFM<THandle, TValue> : IDisposable where THandle : struct, AMBNOAMFBPJ where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly List<THandle> DJEDGFAAOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly List<TValue> BBHHJPHFDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private readonly Func<TValue> FLKGKHPEFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly Action<TValue> GGFBDGKGAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private int CEMBCODPPGI;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TValue LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x39F1F00", Offset = "0x39F1100", VA = "0x1839F1F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x3ECC0C0", Offset = "0x3ECB2C0", VA = "0x183ECC0C0")]
	public OKHLJPIHHFM(Action<TValue> GGFBDGKGAAD, [Optional] Func<TValue> FLKGKHPEFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x3ECB8D0", Offset = "0x3ECAAD0", VA = "0x183ECB8D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x3ECB830", Offset = "0x3ECAA30", VA = "0x183ECB830")]
	public THandle CNOGLGNGFED()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBBD0", Offset = "0x3ECADD0", VA = "0x183ECBBD0")]
	public THandle KAGEPJABGKM(TValue ADBNEBBHMOP)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x3ECB530", Offset = "0x3ECA730", VA = "0x183ECB530")]
	public bool CEDMIKNCMLN(THandle BEDKMKLJIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBD60", Offset = "0x3ECAF60", VA = "0x183ECBD60")]
	public bool LDDOKODCMGI(THandle BEDKMKLJIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x3ECB9E0", Offset = "0x3ECABE0", VA = "0x183ECB9E0")]
	public bool GJMMOBCKDJC(THandle BEDKMKLJIGF, out TValue ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x3ECB990", Offset = "0x3ECAB90", VA = "0x183ECB990")]
	public TValue FCLOOBPJBAH(THandle BEDKMKLJIGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3ECC010", Offset = "0x3ECB210", VA = "0x183ECC010")]
	public bool PNGIIMFCLDE(THandle BEDKMKLJIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBFE0", Offset = "0x3ECB1E0", VA = "0x183ECBFE0")]
	private THandle NNCMJGFJINA(int MJNAIOAAGCG)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBBA0", Offset = "0x3ECADA0", VA = "0x183ECBBA0")]
	private TValue JPMCGEINDNN(int MJNAIOAAGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x3ECB950", Offset = "0x3ECAB50", VA = "0x183ECB950")]
	private void EGCECJDCNLE(int MJNAIOAAGCG, in THandle BEDKMKLJIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x3ECB5E0", Offset = "0x3ECA7E0", VA = "0x183ECB5E0")]
	private void CGCKBGBOJEO(int MJNAIOAAGCG, in TValue ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBE50", Offset = "0x3ECB050", VA = "0x183ECBE50")]
	private THandle MMEHPCHCJCG()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBAE0", Offset = "0x3ECACE0", VA = "0x183ECBAE0")]
	private void HGACEFDJAAM(THandle BEDKMKLJIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBE40", Offset = "0x3ECB040", VA = "0x183ECBE40")]
	private int MKKHLNLNECO(int BCHFMCCIDMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x3ECB520", Offset = "0x3ECA720", VA = "0x183ECB520")]
	private bool BEOPIMBMFEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x700390", Offset = "0x6FF590", VA = "0x180700390")]
	private void BDGOBEJJNNK(THandle BEDKMKLJIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBF60", Offset = "0x3ECB160", VA = "0x183ECBF60")]
	private bool NIGFMHNIJKB(out THandle BEDKMKLJIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x3ECB620", Offset = "0x3ECA820", VA = "0x183ECB620")]
	private bool CHLMHDNENNJ(out THandle BEDKMKLJIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBA80", Offset = "0x3ECAC80", VA = "0x183ECBA80")]
	private void GOHLLABCCPN(THandle BEDKMKLJIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBC40", Offset = "0x3ECAE40", VA = "0x183ECBC40")]
	private void KCCFDNENFOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public interface AMBNOAMFBPJ
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	int CCIFACONDAF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	int IDFONEJIHAP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public interface FMOBBOIANPF<T> : AMBNOAMFBPJ, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public static class KJHLLAAJBEB
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x13975E0", Offset = "0x13967E0", VA = "0x1813975E0")]
	public static bool HEHLHNOGOPD<T>(this T BEDKMKLJIGF, T GHOINNFPLDF) where T : struct, AMBNOAMFBPJ
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x3ADA550", Offset = "0x3AD9750", VA = "0x183ADA550")]
	public static bool MJFCPIFHOGF<T>(this T BEDKMKLJIGF) where T : struct, AMBNOAMFBPJ
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x26CF0C0", Offset = "0x26CE2C0", VA = "0x1826CF0C0")]
	public static string DCIEJKMMBEO(this AMBNOAMFBPJ BEDKMKLJIGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public class LHNNICLMBCG
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum ICMKKMDPNMH : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int HGCLPJPLDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private bool KMIHLHDIKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private ICMKKMDPNMH IBBEGDPIJBO;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool NPKBEJHDJME
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x26D0950", Offset = "0x26CFB50", VA = "0x1826D0950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool PIBBFPBLJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x26D0940", Offset = "0x26CFB40", VA = "0x1826D0940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x26D11A0", Offset = "0x26D03A0", VA = "0x1826D11A0")]
	public LHNNICLMBCG(bool KMIHLHDIKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x26D0A10", Offset = "0x26CFC10", VA = "0x1826D0A10")]
	public void GNHLCGJFPFI(object PBKPNJLDBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x26D0FF0", Offset = "0x26D01F0", VA = "0x1826D0FF0")]
	public void NOOGJHBOEFD(int ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x26D03C0", Offset = "0x26CF5C0", VA = "0x1826D03C0")]
	public void BDKDPBDGDAJ(uint BHIBKCNMPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x26D03D0", Offset = "0x26CF5D0", VA = "0x1826D03D0")]
	public void BOHOKOJCNLE(bool IEAPBBMCMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x26D09D0", Offset = "0x26CFBD0", VA = "0x1826D09D0")]
	public void EPHCIJGAICH(long CKJEMFLBEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x26D0FA0", Offset = "0x26D01A0", VA = "0x1826D0FA0")]
	public void NKHKCOOKJPF(ulong LIPBEJMILID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x26D0F30", Offset = "0x26D0130", VA = "0x1826D0F30")]
	public void LFMKHAHEEBB(string NBKPPCECHEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x26D1110", Offset = "0x26D0310", VA = "0x1826D1110")]
	public void PLPAKFEPGCA(Enum MAMHFFLAIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x26D0820", Offset = "0x26CFA20", VA = "0x1826D0820")]
	public void DIPDKHKKMKO(IList MDBHJOENILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x3D55680", Offset = "0x3D54880", VA = "0x183D55680")]
	public void OEBOCJGFOND<T, U>(Dictionary<T, U> IEAFMFMBKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x26D03F0", Offset = "0x26CF5F0", VA = "0x1826D03F0")]
	private void CFBBBIPLPMF(IDictionary IEAFMFMBKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x26D10A0", Offset = "0x26D02A0", VA = "0x1826D10A0")]
	public int OHDKNKFFPPJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x26D07B0", Offset = "0x26CF9B0", VA = "0x1826D07B0")]
	public short CGEJCCJJDBE()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x26D0FE0", Offset = "0x26D01E0", VA = "0x1826D0FE0")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x26D0960", Offset = "0x26CFB60", VA = "0x1826D0960")]
	private void EIOICDFKPFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public abstract class HMLABIKGHFJ<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	internal class MLPOBELJLMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public TNode BJFNBIEJBCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public TNode ENAGHEEPLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public BEAMIKHCKBL GBCHFDDLKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public List<BEAMIKHCKBL> FFPPOGDKGEE;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		public MLPOBELJLMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	internal struct BEAMIKHCKBL : IComparable<BEAMIKHCKBL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int JKCDJLGNPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public TClaimant OJOCMGLAKFD;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7F1CB0", Offset = "0x7F0EB0", VA = "0x1807F1CB0")]
		public BEAMIKHCKBL(int JKCDJLGNPKP, TClaimant OJOCMGLAKFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x39E8160", Offset = "0x39E7360", VA = "0x1839E8160")]
		public bool ALGMNCLBPFP(in BEAMIKHCKBL GHOINNFPLDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x39E81D0", Offset = "0x39E73D0", VA = "0x1839E81D0")]
		public bool GPEBDGGPMLC(in BEAMIKHCKBL GHOINNFPLDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x39E81C0", Offset = "0x39E73C0", VA = "0x1839E81C0", Slot = "4")]
		public int CompareTo(BEAMIKHCKBL GHOINNFPLDF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x39E81E0", Offset = "0x39E73E0", VA = "0x1839E81E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public enum AEHEIPGIGCF
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class NPMIPIHGENF : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public global::HMLABIKGHFJ<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x12086D0", Offset = "0x12078D0", VA = "0x1812086D0")]
		[DebuggerHidden]
		public NPMIPIHGENF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x39FE340", Offset = "0x39FD540", VA = "0x1839FE340", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x39FE500", Offset = "0x39FD700", VA = "0x1839FE500", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x39FE420", Offset = "0x39FD620", VA = "0x1839FE420", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x1208F50", Offset = "0x1208150", VA = "0x181208F50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly global::KFGBIODBAHM<MLPOBELJLMP> OICLHNEECBC;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly global::KFGBIODBAHM<List<BEAMIKHCKBL>> MHOIEBKNGDP;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static int AFCEINAEPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	internal readonly Dictionary<TClaimant, TNode> OBGJJKFPHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	internal readonly Dictionary<TNode, MLPOBELJLMP> CILGGPONLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private AEHEIPGIGCF PCDNKMPEHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private bool JGKFDLIIMNF;

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode JIPNBHNLIBO(TNode ENDNNBHCICP);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void LJMCHFPJNHP(TNode ENDNNBHCICP, TClaimant AFEBKCLLFCD, TClaimant AMCFGPMDGFO);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x39FD710", Offset = "0x39FC910", VA = "0x1839FD710")]
	public HMLABIKGHFJ(AEHEIPGIGCF PCDNKMPEHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x39FBEB0", Offset = "0x39FB0B0", VA = "0x1839FBEB0")]
	public void ANHLILPDEIE(TNode ENDNNBHCICP, TNode NHDMOENBBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x39FC0A0", Offset = "0x39FB2A0", VA = "0x1839FC0A0")]
	public void DIGOANJEOIJ(TClaimant OJOCMGLAKFD, TNode IELKCIDNPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x39FC1A0", Offset = "0x39FB3A0", VA = "0x1839FC1A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x39FBF30", Offset = "0x39FB130", VA = "0x1839FBF30")]
	private void AOAMKGBKJFG(TClaimant OJOCMGLAKFD, TNode DGBIIHMOBEK, TNode IELKCIDNPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x39FCAD0", Offset = "0x39FBCD0", VA = "0x1839FCAD0")]
	private int KAEBGBKAFDI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x39FC6D0", Offset = "0x39FB8D0", VA = "0x1839FC6D0")]
	private void ILIHOLEBHJJ(TClaimant OJOCMGLAKFD, TNode CCDBMJKIAID, TNode KIENEBDMBHE, int ANCBJEOAGGK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x39FCA40", Offset = "0x39FBC40", VA = "0x1839FCA40")]
	private void JDCGBFJMBFH(BEAMIKHCKBL GDAIPEJHAFH, MLPOBELJLMP OCNILCIMLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x39FD180", Offset = "0x39FC380", VA = "0x1839FD180")]
	private void NMAEHAEGFKG(TClaimant OJOCMGLAKFD, TNode CCDBMJKIAID, TNode KIENEBDMBHE, int ANCBJEOAGGK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x39FCC40", Offset = "0x39FBE40", VA = "0x1839FCC40")]
	private void MKBIAHFKALL(BEAMIKHCKBL GDAIPEJHAFH, TNode ENDNNBHCICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x39FCB40", Offset = "0x39FBD40", VA = "0x1839FCB40")]
	private void MEIPADACAFE(BEAMIKHCKBL GDAIPEJHAFH, MLPOBELJLMP OCNILCIMLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x39FC590", Offset = "0x39FB790", VA = "0x1839FC590")]
	private void HLJCKIDKGMI(MLPOBELJLMP OCNILCIMLOB, bool JOEFOMGJELL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x39FCD40", Offset = "0x39FBF40", VA = "0x1839FCD40")]
	private void MNOBDJPNCOI(MLPOBELJLMP OCNILCIMLOB, TNode NHDMOENBBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x39FBFD0", Offset = "0x39FB1D0", VA = "0x1839FBFD0")]
	[IteratorStateMachine(typeof(global::HMLABIKGHFJ<, >.NPMIPIHGENF))]
	private IEnumerable<TNode> CAEMHKGPMJG(TNode CCDBMJKIAID, TNode KIENEBDMBHE, bool MOADFHBLICM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x39FC980", Offset = "0x39FBB80", VA = "0x1839FC980")]
	private MLPOBELJLMP ININLLHBNCJ(TNode ENDNNBHCICP, TNode ENAGHEEPLJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x39FC400", Offset = "0x39FB600", VA = "0x1839FC400")]
	private MLPOBELJLMP GJNNHONAMNC(TNode ENDNNBHCICP, TNode ENAGHEEPLJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x39FD3F0", Offset = "0x39FC5F0", VA = "0x1839FD3F0")]
	private void OIIFEKBEIJL(MLPOBELJLMP OCNILCIMLOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class IOFCMOFAJIE<T> : IEnumerable<global::IOFCMOFAJIE<T>.GMFFNIMNEKA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public struct GMFFNIMNEKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public T ADBNEBBHMOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int MJNAIOAAGCG;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public class MNLKMEMCHNE : IEnumerator<GMFFNIMNEKA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private global::IOFCMOFAJIE<T> FIKJOBHDMCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private int MJNAIOAAGCG;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x3D46110", Offset = "0x3D45310", VA = "0x183D46110", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public GMFFNIMNEKA EGCCHNLJPLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x3D46190", Offset = "0x3D45390", VA = "0x183D46190", Slot = "4")]
			get
			{
				return default(GMFFNIMNEKA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xF97F90", Offset = "0xF97190", VA = "0x180F97F90")]
		public MNLKMEMCHNE(global::IOFCMOFAJIE<T> FIKJOBHDMCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x3D45F80", Offset = "0x3D45180", VA = "0x183D45F80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xF97F80", Offset = "0xF97180", VA = "0x180F97F80", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0xBE1FB0", Offset = "0xBE11B0", VA = "0x180BE1FB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	private struct KGEDHBKIFPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public bool JNHGELANFJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public T ADBNEBBHMOP;
	}

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private const int FFGPNDFHLHH = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private readonly Dictionary<T, int> DNAMJDBKOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private KGEDHBKIFPB[] BIIMFOFLJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private int BOANOHPJHLB;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public int BKJAEKECHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x7E9D80", Offset = "0x7E8F80", VA = "0x1807E9D80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x96D550", Offset = "0x96C750", VA = "0x18096D550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xF2A9C0", Offset = "0xF29BC0", VA = "0x180F2A9C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x3D423D0", Offset = "0x3D415D0", VA = "0x183D423D0")]
	public IOFCMOFAJIE(int GOCCOAPEHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x3D424B0", Offset = "0x3D416B0", VA = "0x183D424B0")]
	public IOFCMOFAJIE(GMFFNIMNEKA[] GDAIIMHJJBJ, bool FHAAEOAEPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x3D40FB0", Offset = "0x3D401B0", VA = "0x183D40FB0")]
	public int EELELKIOIHC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x3D41EA0", Offset = "0x3D410A0", VA = "0x183D41EA0")]
	private int ODIIOCCJHMP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x3D41B90", Offset = "0x3D40D90", VA = "0x183D41B90", Slot = "6")]
	protected virtual uint JGINEIJDCPL(uint HGCLPJPLDLN, T ADBNEBBHMOP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x3D40E60", Offset = "0x3D40060", VA = "0x183D40E60")]
	public bool BPJIGKOGONM(T ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x3D40D70", Offset = "0x3D3FF70", VA = "0x183D40D70")]
	public bool BLKPFBAADFO(int MJNAIOAAGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x3D41AC0", Offset = "0x3D40CC0", VA = "0x183D41AC0")]
	public bool HIPEHFAIGLD(Func<T, bool> ECNMDGCPMBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x3D41CD0", Offset = "0x3D40ED0", VA = "0x183D41CD0")]
	public int MALFBHNKEPG(T ADBNEBBHMOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x3D41C50", Offset = "0x3D40E50", VA = "0x183D41C50")]
	public T JPMCGEINDNN(int MJNAIOAAGCG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x3D41E20", Offset = "0x3D41020", VA = "0x183D41E20")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x3D41530", Offset = "0x3D40730", VA = "0x183D41530")]
	public bool EOLFFDHHMOF(T ADBNEBBHMOP, bool EPHPJHJFCOL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x3D41570", Offset = "0x3D40770", VA = "0x183D41570")]
	public bool EOLFFDHHMOF(T ADBNEBBHMOP, int MJNAIOAAGCG, bool EPHPJHJFCOL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x3D40EA0", Offset = "0x3D400A0", VA = "0x183D40EA0")]
	public bool CEDMIKNCMLN(T ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x3D419C0", Offset = "0x3D40BC0", VA = "0x183D419C0")]
	public bool GEKNCFKGFNI(int MJNAIOAAGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x3D417F0", Offset = "0x3D409F0", VA = "0x183D417F0")]
	private void FNOCDAPJIIO(int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x3D41190", Offset = "0x3D40390", VA = "0x183D41190")]
	public GMFFNIMNEKA[] EIADJMKAIGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x3D41DD0", Offset = "0x3D40FD0", VA = "0x183D41DD0")]
	private int NELELKIBADH(int KKDHFPHHHIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x3D42350", Offset = "0x3D41550", VA = "0x183D42350", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x3D42350", Offset = "0x3D41550", VA = "0x183D42350", Slot = "4")]
	private IEnumerator<GMFFNIMNEKA> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public struct NMEJENJABEP<Handle> where Handle : AMBNOAMFBPJ, new()
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	private struct MAOJCGGFDAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private readonly global::NMEJENJABEP<Handle> LOOAOCAIODO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private int MJNAIOAAGCG;

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public int HCMDGLODFAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x22747F0", Offset = "0x22739F0", VA = "0x1822747F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Handle PGILKLCDFMA
		{
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0x2274290", Offset = "0x2273490", VA = "0x182274290")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x2274A50", Offset = "0x2273C50", VA = "0x182274A50")]
		public MAOJCGGFDAM(global::NMEJENJABEP<Handle> LOOAOCAIODO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x2273DA0", Offset = "0x2272FA0", VA = "0x182273DA0")]
		public HPHHPLFIAEH HCEINCHCOLK(in HPHHPLFIAEH ILPNDFPPNDK)
		{
			return default(HPHHPLFIAEH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x2273CF0", Offset = "0x2272EF0", VA = "0x182273CF0")]
		public AEFJDOKJPEO HCEINCHCOLK(in AEFJDOKJPEO ILPNDFPPNDK)
		{
			return default(AEFJDOKJPEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x2273970", Offset = "0x2272B70", VA = "0x182273970")]
		public bool GJHOJJIIOKI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x22749F0", Offset = "0x2273BF0", VA = "0x1822749F0")]
		private int OHCGNCBJHDM(string HGHEMBBLDIC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x2273F10", Offset = "0x2273110", VA = "0x182273F10")]
		private Handle NAIEKFGDEDO(string HGHEMBBLDIC)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public struct HPHHPLFIAEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private MAOJCGGFDAM PPBOMLGEDDN;

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public int EGCCHNLJPLC
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x22738F0", Offset = "0x2272AF0", VA = "0x1822738F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x2273730", Offset = "0x2272930", VA = "0x182273730")]
		public HPHHPLFIAEH(global::NMEJENJABEP<Handle> LOOAOCAIODO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x2273570", Offset = "0x2272770", VA = "0x182273570")]
		public bool GJHOJJIIOKI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x2273790", Offset = "0x2272990", VA = "0x182273790")]
		public HPHHPLFIAEH ENNIMPBLHKI()
		{
			return default(HPHHPLFIAEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public struct AEFJDOKJPEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private MAOJCGGFDAM PPBOMLGEDDN;

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Handle EGCCHNLJPLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0x2273630", Offset = "0x2272830", VA = "0x182273630")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x2273730", Offset = "0x2272930", VA = "0x182273730")]
		public AEFJDOKJPEO(global::NMEJENJABEP<Handle> LOOAOCAIODO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x2273570", Offset = "0x2272770", VA = "0x182273570")]
		public bool GJHOJJIIOKI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x2273450", Offset = "0x2272650", VA = "0x182273450")]
		public AEFJDOKJPEO ENNIMPBLHKI()
		{
			return default(AEFJDOKJPEO);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private NativeList<int> MNLCAPEFINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private NativeList<int> CMKIHGOCMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private int ECGPMECAIKA;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool GPCFLNCLBKI
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x22853C0", Offset = "0x22845C0", VA = "0x1822853C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public int DAKMKNJEHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x2284A70", Offset = "0x2283C70", VA = "0x182284A70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public int PJBPFBPPEJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x610600", Offset = "0x60F800", VA = "0x180610600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public int AJMBDJEMELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x610600", Offset = "0x60F800", VA = "0x180610600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public HPHHPLFIAEH HECCNLDIEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x2285550", Offset = "0x2284750", VA = "0x182285550")]
		get
		{
			return default(HPHHPLFIAEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public AEFJDOKJPEO GIHOLKMHEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x22856B0", Offset = "0x22848B0", VA = "0x1822856B0")]
		get
		{
			return default(AEFJDOKJPEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x2285AC0", Offset = "0x2284CC0", VA = "0x182285AC0")]
	public NMEJENJABEP(int LJJGEKPHHNB, Allocator MKFODJKMOCC = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x2284960", Offset = "0x2283B60", VA = "0x182284960")]
	public void DIPAICNNLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x22858B0", Offset = "0x2284AB0", VA = "0x1822858B0")]
	public static int MKKHLNLNECO(int BGOLGEMKCDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x2284950", Offset = "0x2283B50", VA = "0x182284950")]
	public static bool BMMDPLPBGFF(int BGOLGEMKCDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x22856A0", Offset = "0x22848A0", VA = "0x1822856A0")]
	public static bool LPJIBBEIBID(int BGOLGEMKCDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x22858C0", Offset = "0x2284AC0", VA = "0x1822858C0")]
	public bool NPIJBMJFDFP(int MJNAIOAAGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x22859C0", Offset = "0x2284BC0", VA = "0x1822859C0")]
	public bool PHCBABKIIAC(int MJNAIOAAGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x2284BA0", Offset = "0x2283DA0", VA = "0x182284BA0")]
	public bool JCLMDGHLMBC(Handle BEDKMKLJIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x2285130", Offset = "0x2284330", VA = "0x182285130")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void JJCMCGPEKIN(Handle BEDKMKLJIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x2285760", Offset = "0x2284960", VA = "0x182285760")]
	public Handle MCCKNIOACGM()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x2284DF0", Offset = "0x2283FF0", VA = "0x182284DF0")]
	public void JICLIEHAMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x2285400", Offset = "0x2284600", VA = "0x182285400")]
	public void JLLCDDMJMLN(Handle BEDKMKLJIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x2285810", Offset = "0x2284A10", VA = "0x182285810")]
	public bool MHLMDIABDFI(Handle BEDKMKLJIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x2284AB0", Offset = "0x2283CB0", VA = "0x182284AB0")]
	private bool HDNPJELMNFI(int MJNAIOAAGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x2284CA0", Offset = "0x2283EA0", VA = "0x182284CA0")]
	private void JGINMBNJFNI(out int MJNAIOAAGCG, out int BCHFMCCIDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x2285450", Offset = "0x2284650", VA = "0x182285450")]
	private void LKDFBNDCLNM(Handle BEDKMKLJIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x2284A20", Offset = "0x2283C20", VA = "0x182284A20")]
	private void FBJHBHKKLGO(int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x2285600", Offset = "0x2284800", VA = "0x182285600")]
	private bool LPIJNCJBKAP(out int MJNAIOAAGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x2284B10", Offset = "0x2283D10", VA = "0x182284B10")]
	private static Handle JAFFIEAEDEN(int MJNAIOAAGCG, int BCHFMCCIDMH)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[DefaultMember("Item")]
public struct NNJNOKFJADK<Handle, T> where Handle : AMBNOAMFBPJ, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private global::NMEJENJABEP<Handle> HGGOEFKIMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private T[] GNDNCDKHCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private Action<T> LJMOCBOKPJD;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool GPCFLNCLBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x4684820", Offset = "0x4683A20", VA = "0x184684820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public int DAKMKNJEHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x4684510", Offset = "0x4683710", VA = "0x184684510")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x46826A0", Offset = "0x46818A0", VA = "0x1846826A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public T LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x4685480", Offset = "0x4684680", VA = "0x184685480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x4685F20", Offset = "0x4685120", VA = "0x184685F20")]
	public NNJNOKFJADK(int LJJGEKPHHNB, [Optional] Action<T> LJMOCBOKPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x46832E0", Offset = "0x46824E0", VA = "0x1846832E0")]
	public void DIPAICNNLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x4684690", Offset = "0x4683890", VA = "0x184684690")]
	public bool JCLMDGHLMBC(Handle BEDKMKLJIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void JJCMCGPEKIN(Handle BEDKMKLJIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x4683D80", Offset = "0x4682F80", VA = "0x184683D80")]
	public T FCLOOBPJBAH(Handle BEDKMKLJIGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x46842D0", Offset = "0x46834D0", VA = "0x1846842D0")]
	public bool GJMMOBCKDJC(Handle BEDKMKLJIGF, out T PBKPNJLDBOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x46828C0", Offset = "0x4681AC0", VA = "0x1846828C0")]
	public void CEAJIHNFBDD(Handle BEDKMKLJIGF, T BLMHFGBNMHD, out T NHIOCMHKOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x46826D0", Offset = "0x46818D0", VA = "0x1846826D0")]
	public void CEAJIHNFBDD(Handle BEDKMKLJIGF, T BLMHFGBNMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x4685530", Offset = "0x4684730", VA = "0x184685530")]
	public bool OLNHFFKNPOC(Handle BEDKMKLJIGF, T BLMHFGBNMHD, out T NHIOCMHKOOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x4685BC0", Offset = "0x4684DC0", VA = "0x184685BC0")]
	public bool OLNHFFKNPOC(Handle BEDKMKLJIGF, T BLMHFGBNMHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x46848B0", Offset = "0x4683AB0", VA = "0x1846848B0")]
	public Handle KAGEPJABGKM(T PBKPNJLDBOM)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x4683440", Offset = "0x4682640", VA = "0x184683440")]
	public void EGJDABAAJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x4682A30", Offset = "0x4681C30", VA = "0x184682A30")]
	public void CEDMIKNCMLN(Handle BEDKMKLJIGF, out T NHIOCMHKOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x4682CB0", Offset = "0x4681EB0", VA = "0x184682CB0")]
	public void CEDMIKNCMLN(Handle BEDKMKLJIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x4684FC0", Offset = "0x46841C0", VA = "0x184684FC0")]
	public bool MLCBBBDMEEJ(Handle BEDKMKLJIGF, out T NHIOCMHKOOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x4684D10", Offset = "0x4683F10", VA = "0x184684D10")]
	public bool MLCBBBDMEEJ(Handle BEDKMKLJIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x4683DC0", Offset = "0x4682FC0", VA = "0x184683DC0")]
	private T GEKNCFKGFNI(int MJNAIOAAGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x4684020", Offset = "0x4683220", VA = "0x184684020")]
	private void GFBBAIKPDNM(int FHPMJNICFAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class KFGBIODBAHM<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Stack<T> LOOAOCAIODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly List<T> GNEPLEGNMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly int JPOLLFFHKHJ;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public int BGALMGNIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x1340680", Offset = "0x133F880", VA = "0x181340680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int LMEPPGPEFBH
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x1340950", Offset = "0x133FB50", VA = "0x181340950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x1340880", Offset = "0x133FA80", VA = "0x181340880")]
	public static global::KFGBIODBAHM<T> FBJPKMFKNMK(int GOCCOAPEHDE = 0, int JPOLLFFHKHJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x13409A0", Offset = "0x133FBA0", VA = "0x1813409A0")]
	public static global::KFGBIODBAHM<T> HMDLKCGLBNF(int GOCCOAPEHDE = 0, int JPOLLFFHKHJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x1340DB0", Offset = "0x133FFB0", VA = "0x181340DB0")]
	public KFGBIODBAHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x1340DF0", Offset = "0x133FFF0", VA = "0x181340DF0")]
	public KFGBIODBAHM(int GOCCOAPEHDE, int JPOLLFFHKHJ = int.MaxValue, bool LNCELDEGJLJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x1340C80", Offset = "0x133FE80", VA = "0x181340C80")]
	public T PNAMDBOJCNA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x1340BC0", Offset = "0x133FDC0", VA = "0x181340BC0")]
	public void PLGIPNAJDEI(T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x13406B0", Offset = "0x133F8B0", VA = "0x1813406B0")]
	private void DDKNLBIPPFB(T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x1340980", Offset = "0x133FB80", VA = "0x181340980")]
	private void GJJPJDIOCDM(T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x1340B20", Offset = "0x133FD20", VA = "0x181340B20")]
	[Conditional("DEBUG_BUILD")]
	private void OLCFNADKDFM(T DDHNOCJLMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x1340A70", Offset = "0x133FC70", VA = "0x181340A70")]
	[Conditional("DEBUG_BUILD")]
	private void LKNNMLFAGFF(T DDHNOCJLMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x1340770", Offset = "0x133F970", VA = "0x181340770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x13404C0", Offset = "0x133F6C0", VA = "0x1813404C0")]
	private void BKGOKBAMOHE(IEnumerable<T> BBHHJPHFDEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class NGBKMCLOAJM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private Dictionary<int, T> PONIPBDCKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private T NDDGCKBEGLL;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public virtual T EIHKFMKDGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x623BB0", Offset = "0x622DB0", VA = "0x180623BB0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool FBCDLJMIAHD
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0xF385A0", Offset = "0xF377A0", VA = "0x180F385A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0xF386D0", Offset = "0xF378D0", VA = "0x180F386D0")]
	public bool NLOPPMNLCMA(T ADBNEBBHMOP, int JKCDJLGNPKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0xF38610", Offset = "0xF37810", VA = "0x180F38610")]
	public bool HPPOBMDBMOI(int JKCDJLGNPKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0xF38930", Offset = "0xF37B30", VA = "0x180F38930")]
	public T PDDLGLFHFDP(int PJIJBALAKIO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0xF38670", Offset = "0xF37870", VA = "0x180F38670")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0xF388A0", Offset = "0xF37AA0", VA = "0x180F388A0")]
	private bool NPGPHMFPMMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0xF385E0", Offset = "0xF377E0", VA = "0x180F385E0")]
	public bool HNIJFJOBNMJ(int JKCDJLGNPKP, out T ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0xF38E00", Offset = "0xF38000", VA = "0x180F38E00")]
	public NGBKMCLOAJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class PIGHCLBOIBD<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	protected struct DDPPNFABDBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public T MDDADGNJOKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public int MONGBBFOOKD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	protected readonly List<DDPPNFABDBI> DBJAENPKIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private T MMFMHDJFNDD;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xF2A9C0", Offset = "0xF29BC0", VA = "0x180F2A9C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x4610B50", Offset = "0x460FD50", VA = "0x184610B50")]
	public bool HIPEHFAIGLD(T ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x4611020", Offset = "0x4610220", VA = "0x184611020")]
	public void KAGEPJABGKM(T ADBNEBBHMOP, int JKCDJLGNPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x46109A0", Offset = "0x460FBA0", VA = "0x1846109A0")]
	public bool CEDMIKNCMLN(T ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x46110C0", Offset = "0x46102C0", VA = "0x1846110C0")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x4610AC0", Offset = "0x460FCC0", VA = "0x184610AC0")]
	public T FHNKJJDEJJB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x4610FB0", Offset = "0x46101B0", VA = "0x184610FB0")]
	public T JALDEFDHIGM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x4610DA0", Offset = "0x460FFA0", VA = "0x184610DA0")]
	private void IJKMDFGAKEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x4611120", Offset = "0x4610320", VA = "0x184611120")]
	public PIGHCLBOIBD()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		[NODNICKNPLO(NOMJLFGGPAB.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0x26D25D0", Offset = "0x26D17D0", VA = "0x1826D25D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0x26D2AA0", Offset = "0x26D1CA0", VA = "0x1826D2AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0x26D28C0", Offset = "0x26D1AC0", VA = "0x1826D28C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0x26D2C40", Offset = "0x26D1E40", VA = "0x1826D2C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0x26D2490", Offset = "0x26D1690", VA = "0x1826D2490")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0x26D2960", Offset = "0x26D1B60", VA = "0x1826D2960")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000482")]
			[Cpp2IlInjected.Address(RVA = "0x26D2780", Offset = "0x26D1980", VA = "0x1826D2780")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x26D23F0", Offset = "0x26D15F0", VA = "0x1826D23F0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public interface ODGHKDBAOOE
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public abstract class ResourcePrefabReference<T> : ODGHKDBAOOE where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x3A24D70", Offset = "0x3A23F70", VA = "0x183A24D70", Slot = "4")]
		public virtual T AHGLNLLCAOL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class JDBBEHIIAPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly Dictionary<byte, KAJOFLPNNFO> MMDGENFLCBC;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public KAJOFLPNNFO MEMOMFEBHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x6EE480", Offset = "0x6ED680", VA = "0x1806EE480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public Vector2 CMLIOKBJKCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x153B910", Offset = "0x153AB10", VA = "0x18153B910")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x1CC40C0", Offset = "0x1CC32C0", VA = "0x181CC40C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public Vector2 LLPDCIDAOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x1CC3E30", Offset = "0x1CC3030", VA = "0x181CC3E30")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x1CC3520", Offset = "0x1CC2720", VA = "0x181CC3520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector2 ABGBDNMNMBK
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x26CD200", Offset = "0x26CC400", VA = "0x1826CD200")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x26CD9E0", Offset = "0x26CCBE0", VA = "0x1826CD9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public int HALAJCAIDFG
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x624060", Offset = "0x623260", VA = "0x180624060")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x700390", Offset = "0x6FF590", VA = "0x180700390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x26CDA00", Offset = "0x26CCC00", VA = "0x1826CDA00")]
	public JDBBEHIIAPM(Bounds PAMNJADEEEC, Vector2[] JALFCJLMGEK, int CMJJLKNDCGL, byte KKDHFPHHHIP, float KNLJIGABPMH = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x26CD890", Offset = "0x26CCA90", VA = "0x1826CD890")]
	public KAJOFLPNNFO NGLPBOMPANP(byte MJNAIOAAGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x26CD8F0", Offset = "0x26CCAF0", VA = "0x1826CD8F0")]
	public void PCJBIJFODPI(Vector3 BCCJFEBGGPE, float KMMIGODNMIF, float LFLHFMHKEGN, ref List<byte> MAJBABACEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x26CD740", Offset = "0x26CC940", VA = "0x1826CD740")]
	public void HDEEPLIMNNK(KAJOFLPNNFO.JOGCEFNAGNC OIFHADGCHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x26CD760", Offset = "0x26CC960", VA = "0x1826CD760")]
	private KAJOFLPNNFO KCJGHLBKAOM(byte MJNAIOAAGCG, KAJOFLPNNFO.PBOJKAFCADJ FNIIEDFHGEN, KAJOFLPNNFO ENAGHEEPLJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x26CD220", Offset = "0x26CC420", VA = "0x1826CD220")]
	private void EJDAAGOKLGO(KAJOFLPNNFO ENAGHEEPLJN, Vector2[] JALFCJLMGEK, int CDACFBLNNDP, int DDOINBFPPGM, int BEMEPEICKOE, int FBHFBACMMNK, float KNLJIGABPMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public class KAJOFLPNNFO
{
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public enum PBOJKAFCADJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public enum JOGCEFNAGNC
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public byte JAEIODDCFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public Vector3 PEMAIBJJMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public Vector3 FFGCGCCOGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public Vector3 MKLMFIPLICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public Vector3 NAHCOEDDKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public PBOJKAFCADJ LOKPEMINJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public KAJOFLPNNFO KBODKBKLNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public List<KAJOFLPNNFO> DPPCNOBDAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public bool HCHHPDCOFJA;

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x26CE5D0", Offset = "0x26CD7D0", VA = "0x1826CE5D0")]
	public KAJOFLPNNFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x26CE5F0", Offset = "0x26CD7F0", VA = "0x1826CE5F0")]
	public KAJOFLPNNFO(byte IHPCCBHNEMN, PBOJKAFCADJ FNIIEDFHGEN, KAJOFLPNNFO ENAGHEEPLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x26CE200", Offset = "0x26CD400", VA = "0x1826CE200")]
	public void COODBNEDKMC(KAJOFLPNNFO MEFCJLOHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	public void HDEEPLIMNNK(int BEKFBEPBOKM, JOGCEFNAGNC OIFHADGCHFG, int KNLNKDALFLD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x26CE340", Offset = "0x26CD540", VA = "0x1826CE340")]
	public void PCJBIJFODPI(List<byte> MAJBABACEMA, Vector3 BCCJFEBGGPE, float KMMIGODNMIF, float LFLHFMHKEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x26CE2A0", Offset = "0x26CD4A0", VA = "0x1826CE2A0")]
	public bool FNAADPOMKKN(Vector3 FPDOMCKPEJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x26CE300", Offset = "0x26CD500", VA = "0x1826CE300")]
	public bool GAHKBJAPECG(Vector3 FPDOMCKPEJE, float LLHGIKJEGLB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public class KELKAEBKPNG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly Dictionary<T, object> FMODBJJHBOF;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x133FC40", Offset = "0x133EE40", VA = "0x18133FC40")]
	public bool IHAEJDNKJJB(T FMFBJNGMOKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x133FC00", Offset = "0x133EE00", VA = "0x18133FC00")]
	public bool IHAEJDNKJJB(T FMFBJNGMOKN, object HCPCDENCJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x133FBA0", Offset = "0x133EDA0", VA = "0x18133FBA0")]
	public bool IHAEJDNKJJB(T FMFBJNGMOKN, object HCPCDENCJBA, out object KDAIOKFCJEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x133FB60", Offset = "0x133ED60", VA = "0x18133FB60")]
	public bool IAAMAKHJDMO(T FMFBJNGMOKN, object HCPCDENCJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x133FA90", Offset = "0x133EC90", VA = "0x18133FA90")]
	public bool FEEMAEOOMLA(T FMFBJNGMOKN, object HCPCDENCJBA, out object KDAIOKFCJEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x133FAD0", Offset = "0x133ECD0", VA = "0x18133FAD0")]
	public bool IAAMAKHJDMO(T FMFBJNGMOKN, object HCPCDENCJBA, out object KDAIOKFCJEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x133FA60", Offset = "0x133EC60", VA = "0x18133FA60")]
	public void AJFMBAJNMFF(T FMFBJNGMOKN, object HCPCDENCJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x133F9C0", Offset = "0x133EBC0", VA = "0x18133F9C0")]
	public void AAAJOCHKJIC(T FMFBJNGMOKN, object HCPCDENCJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x133FC70", Offset = "0x133EE70", VA = "0x18133FC70")]
	public KELKAEBKPNG()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		public struct OGBAOADOOCE<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			private readonly List<Component> MDBHJOENILE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			private readonly bool AGMICKJHEJM;

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x104F610", Offset = "0x104E810", VA = "0x18104F610")]
			public OGBAOADOOCE(List<Component> MDBHJOENILE, bool AGMICKJHEJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x3A202A0", Offset = "0x3A1F4A0", VA = "0x183A202A0")]
			public NAOENBMDMGF<T> ENNIMPBLHKI()
			{
				return default(NAOENBMDMGF<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x3A20310", Offset = "0x3A1F510", VA = "0x183A20310", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x3A20310", Offset = "0x3A1F510", VA = "0x183A20310", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		public struct NAOENBMDMGF<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			private readonly List<Component> MDBHJOENILE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			private readonly bool AGMICKJHEJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			private int MJNAIOAAGCG;

			[Cpp2IlInjected.Token(Token = "0x170000D4")]
			public T EGCCHNLJPLC
			{
				[Cpp2IlInjected.Token(Token = "0x60004BB")]
				[Cpp2IlInjected.Address(RVA = "0x3A20190", Offset = "0x3A1F390", VA = "0x183A20190", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D5")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004BC")]
				[Cpp2IlInjected.Address(RVA = "0x3A20120", Offset = "0x3A1F320", VA = "0x183A20120", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x3A20160", Offset = "0x3A1F360", VA = "0x183A20160")]
			public NAOENBMDMGF(List<Component> MDBHJOENILE, bool AGMICKJHEJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x3A20050", Offset = "0x3A1F250", VA = "0x183A20050", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x3A20060", Offset = "0x3A1F260", VA = "0x183A20060", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x3A20110", Offset = "0x3A1F310", VA = "0x183A20110", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x26D4900", Offset = "0x26D3B00", VA = "0x1826D4900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x26D48C0", Offset = "0x26D3AC0", VA = "0x1826D48C0")]
		public ToolHierarchyCache(GameObject DJIJHLPKCLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x26D45E0", Offset = "0x26D37E0", VA = "0x1826D45E0")]
		private void MGEPLKAAEGI(GameObject DJIJHLPKCLD, bool JCMDBKNCKJK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x26D4700", Offset = "0x26D3900", VA = "0x1826D4700")]
		public static void MGEPLKAAEGI(GameObject DJIJHLPKCLD, ref ToolHierarchyCache BJICPIJMIJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x26D4790", Offset = "0x26D3990", VA = "0x1826D4790")]
		public void ONLBCAEIJEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x26D40A0", Offset = "0x26D32A0", VA = "0x1826D40A0")]
		public void COFAAJMDIBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x3B34570", Offset = "0x3B33770", VA = "0x183B34570")]
		public void KKEPAAFKIIO<T>(Action<T> GHCLFMPOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x26D4180", Offset = "0x26D3380", VA = "0x1826D4180")]
		public Component EEDPNHEBHHF(Type BGMCKNGNOJI, bool AGMICKJHEJM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x3887480", Offset = "0x3886680", VA = "0x183887480")]
		public T EEDPNHEBHHF<T>(bool AGMICKJHEJM = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x26D40F0", Offset = "0x26D32F0", VA = "0x1826D40F0")]
		public OGBAOADOOCE<Component> DMPGCGLCCEM(Type BGMCKNGNOJI, bool AGMICKJHEJM = false)
		{
			return default(OGBAOADOOCE<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x4292490", Offset = "0x4291690", VA = "0x184292490")]
		public OGBAOADOOCE<T> DMPGCGLCCEM<T>(bool AGMICKJHEJM = false) where T : class
		{
			return default(OGBAOADOOCE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x26D42C0", Offset = "0x26D34C0", VA = "0x1826D42C0")]
		public List<Component> GEOKCGCFPCB(Type BGMCKNGNOJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x26D4240", Offset = "0x26D3440", VA = "0x1826D4240", Slot = "4")]
		public bool Equals(ToolHierarchyCache FMHEJMEECNK, ToolHierarchyCache EDNBLCPIBHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x26D4570", Offset = "0x26D3770", VA = "0x1826D4570", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache PBKPNJLDBOM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public class EKBMPFPPDJD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private int GOCCOAPEHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private int NBFLNMPMJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private List<T> EHBKMHADDAO;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x1340680", Offset = "0x133F880", VA = "0x181340680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public T NPEHAMEJHBD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x4E45EE0", Offset = "0x4E450E0", VA = "0x184E45EE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public T DJABMHGIADL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x4E46320", Offset = "0x4E45520", VA = "0x184E46320")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public T GDAFMJPOBDM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x4E45E90", Offset = "0x4E45090", VA = "0x184E45E90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x4E463A0", Offset = "0x4E455A0", VA = "0x184E463A0")]
	public EKBMPFPPDJD(int GOCCOAPEHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x4E46100", Offset = "0x4E45300", VA = "0x184E46100")]
	public void KAGEPJABGKM(T POGOBGJDBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x4E46360", Offset = "0x4E45560", VA = "0x184E46360")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x4E46000", Offset = "0x4E45200", VA = "0x184E46000")]
	public void GEJILMPNLIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x4E460B0", Offset = "0x4E452B0", VA = "0x184E460B0")]
	public void JLCKNMEIGGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x4E460A0", Offset = "0x4E452A0", VA = "0x184E460A0")]
	public void GPMKBADEAJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public class EBCIGMCKNJI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private bool CCBFKLDOFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private Action GHCLFMPOHGP;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public static EBCIGMCKNJI DKNHBAECBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x26CB570", Offset = "0x26CA770", VA = "0x1826CB570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool HCLHJOBLAPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x7CC130", Offset = "0x7CB330", VA = "0x1807CC130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x8D2270", Offset = "0x8D1470", VA = "0x1808D2270")]
	public EBCIGMCKNJI(Action GHCLFMPOHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x26CB550", Offset = "0x26CA750", VA = "0x1826CB550")]
	public void EBIMOMABEEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x26CB550", Offset = "0x26CA750", VA = "0x1826CB550", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class BJPFKMGLHFE
{
	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	public static void DPKDBAOHALN(DJJPHFEAJPD PIJHBPMAOAA, string BLPFOODMECN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public class ALFEOBHIAHC<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	private struct EHBPPLKBLHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public int MONGBBFOOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public T MDDADGNJOKH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private readonly Dictionary<object, EHBPPLKBLHA> PONIPBDCKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private T NDDGCKBEGLL;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public virtual T EIHKFMKDGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x153B910", Offset = "0x153AB10", VA = "0x18153B910", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x1CC40C0", Offset = "0x1CC32C0", VA = "0x181CC40C0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool FBCDLJMIAHD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x453D580", Offset = "0x453C780", VA = "0x18453D580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public object OMJLJNKPJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD10", Offset = "0x5FCF10", VA = "0x1805FDD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD20", Offset = "0x5FCF20", VA = "0x1805FDD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x461D4D0", Offset = "0x461C6D0", VA = "0x18461D4D0")]
	public bool NLOPPMNLCMA(T ADBNEBBHMOP, object HCPCDENCJBA, int JKCDJLGNPKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x453D8D0", Offset = "0x453CAD0", VA = "0x18453D8D0")]
	public bool HPPOBMDBMOI(object HCPCDENCJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x453D730", Offset = "0x453C930", VA = "0x18453D730")]
	public bool HNIJFJOBNMJ(object HCPCDENCJBA, out T ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0xF37FD0", Offset = "0xF371D0", VA = "0x180F37FD0")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x453E490", Offset = "0x453D690", VA = "0x18453E490")]
	private bool NPGPHMFPMMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0xF38E00", Offset = "0xF38000", VA = "0x180F38E00")]
	public ALFEOBHIAHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public class JAMKPAOLIEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private Dictionary<object, float> PONIPBDCKCO;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public float LLGICFGHOGC
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x7DB5B0", Offset = "0x7DA7B0", VA = "0x1807DB5B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x7DB380", Offset = "0x7DA580", VA = "0x1807DB380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x26CCE80", Offset = "0x26CC080", VA = "0x1826CCE80")]
	public void NLOPPMNLCMA(float ADBNEBBHMOP, object HCPCDENCJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x26CCE10", Offset = "0x26CC010", VA = "0x1826CCE10")]
	public void HPPOBMDBMOI(object HCPCDENCJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x26CCCF0", Offset = "0x26CBEF0", VA = "0x1826CCCF0")]
	private void ABOCPLMGNGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x26CCEF0", Offset = "0x26CC0F0", VA = "0x1826CCEF0")]
	public JAMKPAOLIEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public class KHMNKHEBLDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public readonly string JDPEBLPLMDN;

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x6270A0", Offset = "0x6262A0", VA = "0x1806270A0")]
	public KHMNKHEBLDL(string FDFMLOPMHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x26CF010", Offset = "0x26CE210", VA = "0x1826CF010")]
	public KHMNKHEBLDL(UnityEngine.Object DOOCPNANGOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x26CEFC0", Offset = "0x26CE1C0", VA = "0x1826CEFC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class DJJPHFEAJPD
{
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class DMHNJMNMFKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public DMHNJMNMFKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x26CB4A0", Offset = "0x26CA6A0", VA = "0x1826CB4A0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private HashSet<object> HEBPGFLINFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private int PNFKALFMMEE;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public IReadOnlyCollection<object> OPPJBEJOLOG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x26CB270", Offset = "0x26CA470", VA = "0x1826CB270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool IMKLGJHDGNN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x26CB1A0", Offset = "0x26CA3A0", VA = "0x1826CB1A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public int NAIIACDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD60", Offset = "0x6FEF60", VA = "0x1806FFD60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x26CB1B0", Offset = "0x26CA3B0", VA = "0x1826CB1B0")]
	public bool KAGEPJABGKM(object HCPCDENCJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x26CB0B0", Offset = "0x26CA2B0", VA = "0x1826CB0B0")]
	public bool CEDMIKNCMLN(object HCPCDENCJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x26CB140", Offset = "0x26CA340", VA = "0x1826CB140")]
	public bool HIPEHFAIGLD(object HCPCDENCJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x26CB050", Offset = "0x26CA250", VA = "0x1826CB050")]
	public void ACINCKDIKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x26CB340", Offset = "0x26CA540", VA = "0x1826CB340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public DJJPHFEAJPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public class JHJCNJEAFAJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	private struct MFOAKIDNHBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public float OLEFMHDFHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public T MDDADGNJOKH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private Dictionary<object, MFOAKIDNHBL> PONIPBDCKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private T ODJJBOIKCMD;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public virtual T LBHILJLDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xBC6900", Offset = "0xBC5B00", VA = "0x180BC6900", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x1F0C800", Offset = "0x1F0BA00", VA = "0x181F0C800", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public object IMDEBNHCPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x734270", Offset = "0x733470", VA = "0x180734270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x7D6460", Offset = "0x7D5660", VA = "0x1807D6460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public bool FBCDLJMIAHD
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x1F0C550", Offset = "0x1F0B750", VA = "0x181F0C550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x1F0CA10", Offset = "0x1F0BC10", VA = "0x181F0CA10")]
	public bool NLOPPMNLCMA(T ADBNEBBHMOP, object HCPCDENCJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x1F0C7A0", Offset = "0x1F0B9A0", VA = "0x181F0C7A0")]
	public bool HPPOBMDBMOI(object HCPCDENCJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0xF37FD0", Offset = "0xF371D0", VA = "0x180F37FD0")]
	public void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x1F0C660", Offset = "0x1F0B860", VA = "0x181F0C660")]
	public bool HNIJFJOBNMJ(object HCPCDENCJBA, out T ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x46B8FB0", Offset = "0x46B81B0", VA = "0x1846B8FB0")]
	private bool NPGPHMFPMMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x1F0DDD0", Offset = "0x1F0CFD0", VA = "0x181F0DDD0")]
	public JHJCNJEAFAJ()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class INAFFMAFPID
{
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private static byte[] JIMOKIHBHOH;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private static int FMDPFNLECKI;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static int AONCPEEEHKG;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private static BigInteger ILKJFGLFAMB;

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public INAFFMAFPID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x26CC990", Offset = "0x26CBB90", VA = "0x1826CC990")]
	private static string JBPNMHMEPIE(byte[] KLGGEDCBMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x26CC660", Offset = "0x26CB860", VA = "0x1826CC660")]
	public static string HDPEGNHHKLG(byte[] FAOJAOEJLMO, bool CGIGAMOFOGM)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x20000EC")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
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
