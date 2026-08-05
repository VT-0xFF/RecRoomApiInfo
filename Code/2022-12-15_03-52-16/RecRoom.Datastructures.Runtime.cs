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
public class HEJKAENIMLC : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0")]
	public HEJKAENIMLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, ECOILECAPEP, NBMFECGHEHI, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x697140", Offset = "0x695B40", VA = "0x180697140", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676B30", VA = "0x180678130", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x772F00", VA = "0x180774500", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash ECCMGNHBKIL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xEC6A60", Offset = "0xEC5460", VA = "0x180EC6A60")]
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
	[GGKJBJHDMEO]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[GGKJBJHDMEO]
	[SerializeField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F72880", Offset = "0x5F71280", VA = "0x185F72880")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F72840", Offset = "0x5F71240", VA = "0x185F72840")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5F728C0", Offset = "0x5F712C0", VA = "0x185F728C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5F72A90", Offset = "0x5F71490", VA = "0x185F72A90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5F72A00", Offset = "0x5F71400", VA = "0x185F72A00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x10A3330", Offset = "0x10A1D30", VA = "0x1810A3330")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1022E60", Offset = "0x1021860", VA = "0x181022E60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5F72800", Offset = "0x5F71200", VA = "0x185F72800")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5F72970", Offset = "0x5F71370", VA = "0x185F72970")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5F72240", Offset = "0x5F70C40", VA = "0x185F72240")]
	public void CopyBounds(SavedExtents OANENNOJEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5F72760", Offset = "0x5F71160", VA = "0x185F72760")]
	public void SetLocalSpaceBounds(Bounds CBCMPHADIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x13847A0", Offset = "0x13831A0", VA = "0x1813847A0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5F72750", Offset = "0x5F71150", VA = "0x185F72750")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5F72330", Offset = "0x5F70D30", VA = "0x185F72330")]
	private void KKFFDDHCNFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5F72520", Offset = "0x5F70F20", VA = "0x185F72520")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5F71C00", Offset = "0x5F70600", VA = "0x185F71C00")]
	public static void CalculateLocalBoundsFor(GameObject EHEABJNEALG, out Bounds CBCMPHADIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5F72270", Offset = "0x5F70C70", VA = "0x185F72270")]
	private static void KEDKAOIPIHP(Bounds LKLEFAIICIC, Color KOIHHAIHBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5F72780", Offset = "0x5F71180", VA = "0x185F72780")]
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
		[Cpp2IlInjected.Address(RVA = "0x677040", Offset = "0x675A40", VA = "0x180677040")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x697F30", Offset = "0x696930", VA = "0x180697F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x104B9F0", Offset = "0x104A3F0", VA = "0x18104B9F0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAE9750", Offset = "0xAE8150", VA = "0x180AE9750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "4")]
	public virtual void GJMHFJBPIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
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
	[HEJKAENIMLC]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x323D780", Offset = "0x323C180", VA = "0x18323D780", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x323CEB0", Offset = "0x323B8B0", VA = "0x18323CEB0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x323DCC0", Offset = "0x323C6C0", VA = "0x18323DCC0")]
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
	private sealed class FNKAMAALPJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public FNKAMAALPJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x32581B0", Offset = "0x3256BB0", VA = "0x1832581B0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[HEJKAENIMLC]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x14A8010", Offset = "0x14A6A10", VA = "0x1814A8010", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x14A8040", Offset = "0x14A6A40", VA = "0x1814A8040", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x14A7F60", Offset = "0x14A6960", VA = "0x1814A7F60", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey AIGAKEKDKHM]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x14A7F90", Offset = "0x14A6990", VA = "0x1814A7F90", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x14A7E60", Offset = "0x14A6860", VA = "0x1814A7E60", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x14A77E0", Offset = "0x14A61E0", VA = "0x1814A77E0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x14A6EB0", Offset = "0x14A58B0", VA = "0x1814A6EB0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x14A6E80", Offset = "0x14A5880", VA = "0x1814A6E80", Slot = "14")]
	protected virtual string OCHLEPBJFEA(TKeyVal FDMNPBFAPHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x14A6D60", Offset = "0x14A5760", VA = "0x1814A6D60", Slot = "4")]
	public bool ContainsKey(TKey AIGAKEKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x14A7D50", Offset = "0x14A6750", VA = "0x1814A7D50", Slot = "5")]
	public bool TryGetValue(TKey AIGAKEKDKHM, out TVal MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x14A6D90", Offset = "0x14A5790", VA = "0x1814A6D90", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x14A6D90", Offset = "0x14A5790", VA = "0x1814A6D90", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x14A7D80", Offset = "0x14A6780", VA = "0x1814A7D80")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HFBCPJGMFKN<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KEOAKPDBOEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public KEOAKPDBOEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2680760", Offset = "0x267F160", VA = "0x182680760")]
		internal bool <GetSamples>b__0(global::GEFDKGMPAKE<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float HEBJBMHKDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float GAFBLCCMGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::GEFDKGMPAKE<float, T>> FPLJEENENLC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int IEBJGIHPOJC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2E54D60", Offset = "0x2E53760", VA = "0x182E54D60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2E55190", Offset = "0x2E53B90", VA = "0x182E55190")]
	public HFBCPJGMFKN(float GGEFAPICMLM, float OEMLCINMGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2E54F40", Offset = "0x2E53940", VA = "0x182E54F40")]
	public bool OEALBGNMMEC(float BPPPFJGDDBP, T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2E54600", Offset = "0x2E53000", VA = "0x182E54600")]
	public int GAEGEPBLNNL(float BPPPFJGDDBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2E549A0", Offset = "0x2E533A0", VA = "0x182E549A0")]
	public IEnumerable<T> KFLOPOPGMAI(float BPPPFJGDDBP, [Optional] float? FGPAGJNIFIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2E55160", Offset = "0x2E53B60", VA = "0x182E55160")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2E550A0", Offset = "0x2E53AA0", VA = "0x182E550A0")]
	private void OHMKMIEDGJC(float BPPPFJGDDBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class OJAMPJHFPBK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct DEMGCOILEEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T OIHHNPGGOMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float LLCKOAKEFIJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float GDFMOEBIPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> FHGANAOEHAA;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int EBIFGFMIIME = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private DEMGCOILEEC[] HEONDDEAIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int EDIAEAGGLAA;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float GDNFJGIOGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xE91950", Offset = "0xE90350", VA = "0x180E91950")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xE91960", Offset = "0xE90360", VA = "0x180E91960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x32D6040", Offset = "0x32D4A40", VA = "0x1832D6040")]
	public OJAMPJHFPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x32D6070", Offset = "0x32D4A70", VA = "0x1832D6070")]
	public OJAMPJHFPBK(int JLMAIAGOBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x32D5610", Offset = "0x32D4010", VA = "0x1832D5610")]
	public void MFMCNFFMIAP(float BPPPFJGDDBP, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x32D5C00", Offset = "0x32D4600", VA = "0x1832D5C00")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x32D4F90", Offset = "0x32D3990", VA = "0x1832D4F90")]
	public bool FKCCLBNFDGO(float LGMCDNJLHGA, float KICOLLELCAK, out T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x32D52B0", Offset = "0x32D3CB0", VA = "0x1832D52B0")]
	public bool HDAKFHHKHOI(float LGMCDNJLHGA, float KICOLLELCAK, out T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x32D5AE0", Offset = "0x32D44E0", VA = "0x1832D5AE0")]
	public void MGDOJNOLDGG(float LGMCDNJLHGA, float KICOLLELCAK, List<T> DICKNCEHGPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x32D4B90", Offset = "0x32D3590", VA = "0x1832D4B90")]
	private int FENGPILKLKH(int POCOCMDOEGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x32D55D0", Offset = "0x32D3FD0", VA = "0x1832D55D0")]
	private void LDHBFCEPLKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T ECKGFNMGKOL();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T NECJNGDDOKK(T OLACFPEGPAG, T GLLCOOLKDAC, float KHJLEOILJMF);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T GLCLEPEPGOE(T MAKFNMHIJIF, float KHJLEOILJMF);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T GLCEGHIOHGE(T OLACFPEGPAG, T GLLCOOLKDAC);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T IOJPOBGMBOD(T OLACFPEGPAG, T GLLCOOLKDAC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class JHAHODAHCAI : global::OJAMPJHFPBK<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x137B370", Offset = "0x1379D70", VA = "0x18137B370", Slot = "4")]
	protected override Vector3 ECKGFNMGKOL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B200", Offset = "0x1E19C00", VA = "0x181E1B200", Slot = "5")]
	protected override Vector3 NECJNGDDOKK(Vector3 OLACFPEGPAG, Vector3 GLLCOOLKDAC, float KHJLEOILJMF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D550", Offset = "0x5F6BF50", VA = "0x185F6D550", Slot = "6")]
	protected override Vector3 GLCLEPEPGOE(Vector3 MAKFNMHIJIF, float KHJLEOILJMF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D4D0", Offset = "0x5F6BED0", VA = "0x185F6D4D0", Slot = "7")]
	protected override Vector3 GLCEGHIOHGE(Vector3 OLACFPEGPAG, Vector3 GLLCOOLKDAC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D5B0", Offset = "0x5F6BFB0", VA = "0x185F6D5B0", Slot = "8")]
	protected override Vector3 IOJPOBGMBOD(Vector3 OLACFPEGPAG, Vector3 GLLCOOLKDAC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D620", Offset = "0x5F6C020", VA = "0x185F6D620")]
	public JHAHODAHCAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MKPAGDABFKH : global::OJAMPJHFPBK<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5F6FAC0", Offset = "0x5F6E4C0", VA = "0x185F6FAC0")]
	public MKPAGDABFKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5F6FA50", Offset = "0x5F6E450", VA = "0x185F6FA50")]
	public MKPAGDABFKH(int JLMAIAGOBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x12DC850", Offset = "0x12DB250", VA = "0x1812DC850", Slot = "4")]
	protected override float ECKGFNMGKOL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x37C02D0", Offset = "0x37BECD0", VA = "0x1837C02D0", Slot = "5")]
	protected override float NECJNGDDOKK(float OLACFPEGPAG, float GLLCOOLKDAC, float KHJLEOILJMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5078310", Offset = "0x5076D10", VA = "0x185078310", Slot = "6")]
	protected override float GLCLEPEPGOE(float MAKFNMHIJIF, float KHJLEOILJMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x234CF90", Offset = "0x234B990", VA = "0x18234CF90", Slot = "7")]
	protected override float GLCEGHIOHGE(float OLACFPEGPAG, float GLLCOOLKDAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5F6FA40", Offset = "0x5F6E440", VA = "0x185F6FA40", Slot = "8")]
	protected override float IOJPOBGMBOD(float OLACFPEGPAG, float GLLCOOLKDAC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CBDOOBFOPFO
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x249BA90", Offset = "0x249A490", VA = "0x18249BA90")]
	public static global::HMFNIHIIFBA<T1> CBFHJGEFJHE<T1>(T1 AHJFFIDLGPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D110", Offset = "0x2D9BB10", VA = "0x182D9D110")]
	public static global::GEFDKGMPAKE<T1, T2> CBFHJGEFJHE<T1, T2>(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D180", Offset = "0x2D9BB80", VA = "0x182D9D180")]
	public static global::ECKKONNAHCG<T1, T2, T3> CBFHJGEFJHE<T1, T2, T3>(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1C53960", Offset = "0x1C52360", VA = "0x181C53960")]
	public static global::PHDINFOANPK<T1, T2, T3, T4> CBFHJGEFJHE<T1, T2, T3, T4>(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM, T4 KHPOJGAGIKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D450", Offset = "0x2D9BE50", VA = "0x182D9D450")]
	public static global::OPPOOJLHLCE<T1, T2, T3, T4, T5> CBFHJGEFJHE<T1, T2, T3, T4, T5>(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM, T4 KHPOJGAGIKD, T5 AFABEFPKEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D3A0", Offset = "0x2D9BDA0", VA = "0x182D9D3A0")]
	public static global::POOFPBPPPMG<T1, T2, T3, T4, T5, T6> CBFHJGEFJHE<T1, T2, T3, T4, T5, T6>(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM, T4 KHPOJGAGIKD, T5 AFABEFPKEEG, T6 NJPBMMPBPIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D2E0", Offset = "0x2D9BCE0", VA = "0x182D9D2E0")]
	public static global::LNGIMINACFN<T1, T2, T3, T4, T5, T6, T7> CBFHJGEFJHE<T1, T2, T3, T4, T5, T6, T7>(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM, T4 KHPOJGAGIKD, T5 AFABEFPKEEG, T6 NJPBMMPBPIF, T7 GHJLALOIFKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D210", Offset = "0x2D9BC10", VA = "0x182D9D210")]
	public static global::GFPILPNIEGL<T1, T2, T3, T4, T5, T6, T7, T8> CBFHJGEFJHE<T1, T2, T3, T4, T5, T6, T7, T8>(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM, T4 KHPOJGAGIKD, T5 AFABEFPKEEG, T6 NJPBMMPBPIF, T7 GHJLALOIFKC, T8 GHMECOEOKBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1723C30", Offset = "0x1722630", VA = "0x181723C30")]
	[IteratorStateMachine(typeof(JGKIAJMPHMG))]
	public static IEnumerable<global::GEFDKGMPAKE<T1, T2>> LECKPNHPLFB<T1, T2>(IEnumerable<T1> IKAMJBDPPHG, IEnumerable<T2> LKLEFAIICIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1723E10", Offset = "0x1722810", VA = "0x181723E10")]
	[IteratorStateMachine(typeof(AMIHPOLMDPI))]
	public static IEnumerable<global::ECKKONNAHCG<T1, T2, T3>> LECKPNHPLFB<T1, T2, T3>(IEnumerable<T1> IKAMJBDPPHG, IEnumerable<T2> LKLEFAIICIC, IEnumerable<T3> KOIHHAIHBKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x84D040", Offset = "0x84BA40", VA = "0x18084D040")]
	internal static int JHFMCALLEIH(int NKIDJJCJGNM, int LHCICPFPJPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x84D030", Offset = "0x84BA30", VA = "0x18084D030")]
	internal static int JHFMCALLEIH(int NKIDJJCJGNM, int LHCICPFPJPL, int GKIDFCHIPEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x84D010", Offset = "0x84BA10", VA = "0x18084D010")]
	internal static int JHFMCALLEIH(int NKIDJJCJGNM, int LHCICPFPJPL, int GKIDFCHIPEB, int JFMBFICMNHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B330", Offset = "0x5F69D30", VA = "0x185F6B330")]
	internal static int JHFMCALLEIH(int NKIDJJCJGNM, int LHCICPFPJPL, int GKIDFCHIPEB, int JFMBFICMNHH, int NCNMPAHJPBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B380", Offset = "0x5F69D80", VA = "0x185F6B380")]
	internal static int JHFMCALLEIH(int NKIDJJCJGNM, int LHCICPFPJPL, int GKIDFCHIPEB, int JFMBFICMNHH, int NCNMPAHJPBE, int OGPIBDFLKLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B350", Offset = "0x5F69D50", VA = "0x185F6B350")]
	internal static int JHFMCALLEIH(int NKIDJJCJGNM, int LHCICPFPJPL, int GKIDFCHIPEB, int JFMBFICMNHH, int NCNMPAHJPBE, int OGPIBDFLKLL, int EIEAGALFJHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B300", Offset = "0x5F69D00", VA = "0x185F6B300")]
	internal static int JHFMCALLEIH(int NKIDJJCJGNM, int LHCICPFPJPL, int GKIDFCHIPEB, int JFMBFICMNHH, int NCNMPAHJPBE, int OGPIBDFLKLL, int EIEAGALFJHC, int GMNNNGGDJNL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HMFNIHIIFBA<T1> : IComparable<global::HMFNIHIIFBA<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 PKPDGHDMNLF;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x257A080", Offset = "0x2578A80", VA = "0x18257A080")]
	public HMFNIHIIFBA(T1 AHJFFIDLGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x431B0C0", Offset = "0x4319AC0", VA = "0x18431B0C0", Slot = "4")]
	public int CompareTo(global::HMFNIHIIFBA<T1> OANENNOJEBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x431B130", Offset = "0x4319B30", VA = "0x18431B130", Slot = "0")]
	public override bool Equals(object OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x955D80", Offset = "0x954780", VA = "0x180955D80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x431B1D0", Offset = "0x4319BD0", VA = "0x18431B1D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GEFDKGMPAKE<T1, T2> : IComparable<global::GEFDKGMPAKE<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 PKPDGHDMNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 EAMBACBOMFF;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2A73910", Offset = "0x2A72310", VA = "0x182A73910")]
	public GEFDKGMPAKE(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2A71650", Offset = "0x2A70050", VA = "0x182A71650", Slot = "4")]
	public int CompareTo(global::GEFDKGMPAKE<T1, T2> OANENNOJEBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2A71DA0", Offset = "0x2A707A0", VA = "0x182A71DA0", Slot = "0")]
	public override bool Equals(object OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2A729E0", Offset = "0x2A713E0", VA = "0x182A729E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2A73090", Offset = "0x2A71A90", VA = "0x182A73090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ECKKONNAHCG<T1, T2, T3> : IComparable<global::ECKKONNAHCG<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 PKPDGHDMNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 EAMBACBOMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 IPOOHFDAKJK;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x369AFE0", Offset = "0x36999E0", VA = "0x18369AFE0")]
	public ECKKONNAHCG(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x369A7D0", Offset = "0x36991D0", VA = "0x18369A7D0", Slot = "4")]
	public int CompareTo(global::ECKKONNAHCG<T1, T2, T3> OANENNOJEBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x369A9D0", Offset = "0x36993D0", VA = "0x18369A9D0", Slot = "0")]
	public override bool Equals(object OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x369ACC0", Offset = "0x36996C0", VA = "0x18369ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x369AE30", Offset = "0x3699830", VA = "0x18369AE30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class PHDINFOANPK<T1, T2, T3, T4> : IComparable<global::PHDINFOANPK<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 PKPDGHDMNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 EAMBACBOMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 IPOOHFDAKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 EBLKLMDBBHN;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3171FF0", Offset = "0x31709F0", VA = "0x183171FF0")]
	public PHDINFOANPK(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM, T4 KHPOJGAGIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3174E80", Offset = "0x3173880", VA = "0x183174E80", Slot = "4")]
	public int CompareTo(global::PHDINFOANPK<T1, T2, T3, T4> OANENNOJEBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3174FC0", Offset = "0x31739C0", VA = "0x183174FC0", Slot = "0")]
	public override bool Equals(object OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x31750E0", Offset = "0x3173AE0", VA = "0x1831750E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x31751A0", Offset = "0x3173BA0", VA = "0x1831751A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OPPOOJLHLCE<T1, T2, T3, T4, T5> : IComparable<global::OPPOOJLHLCE<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 PKPDGHDMNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 EAMBACBOMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 IPOOHFDAKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 EBLKLMDBBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 AJBKLDENBJO;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2586AD0", Offset = "0x25854D0", VA = "0x182586AD0")]
	public OPPOOJLHLCE(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM, T4 KHPOJGAGIKD, T5 AFABEFPKEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3B36930", Offset = "0x3B35330", VA = "0x183B36930", Slot = "4")]
	public int CompareTo(global::OPPOOJLHLCE<T1, T2, T3, T4, T5> OANENNOJEBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3B36AB0", Offset = "0x3B354B0", VA = "0x183B36AB0", Slot = "0")]
	public override bool Equals(object OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3B36BF0", Offset = "0x3B355F0", VA = "0x183B36BF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3B36CF0", Offset = "0x3B356F0", VA = "0x183B36CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class POOFPBPPPMG<T1, T2, T3, T4, T5, T6> : IComparable<global::POOFPBPPPMG<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 PKPDGHDMNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 EAMBACBOMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 IPOOHFDAKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 EBLKLMDBBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 AJBKLDENBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 MFCDFJCOBBN;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x25867C0", Offset = "0x25851C0", VA = "0x1825867C0")]
	public POOFPBPPPMG(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM, T4 KHPOJGAGIKD, T5 AFABEFPKEEG, T6 NJPBMMPBPIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2586200", Offset = "0x2584C00", VA = "0x182586200", Slot = "4")]
	public int CompareTo(global::POOFPBPPPMG<T1, T2, T3, T4, T5, T6> OANENNOJEBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x25863C0", Offset = "0x2584DC0", VA = "0x1825863C0", Slot = "0")]
	public override bool Equals(object OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2586530", Offset = "0x2584F30", VA = "0x182586530", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2586650", Offset = "0x2585050", VA = "0x182586650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class LNGIMINACFN<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::LNGIMINACFN<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 PKPDGHDMNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 EAMBACBOMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 IPOOHFDAKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 EBLKLMDBBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 AJBKLDENBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 MFCDFJCOBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 KELILMNDAEG;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2267570", Offset = "0x2265F70", VA = "0x182267570")]
	public LNGIMINACFN(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM, T4 KHPOJGAGIKD, T5 AFABEFPKEEG, T6 NJPBMMPBPIF, T7 GHJLALOIFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2266EF0", Offset = "0x22658F0", VA = "0x182266EF0", Slot = "4")]
	public int CompareTo(global::LNGIMINACFN<T1, T2, T3, T4, T5, T6, T7> OANENNOJEBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x22670F0", Offset = "0x2265AF0", VA = "0x1822670F0", Slot = "0")]
	public override bool Equals(object OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2267290", Offset = "0x2265C90", VA = "0x182267290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x22673E0", Offset = "0x2265DE0", VA = "0x1822673E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class GFPILPNIEGL<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::GFPILPNIEGL<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 PKPDGHDMNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 EAMBACBOMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 IPOOHFDAKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 EBLKLMDBBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 AJBKLDENBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 MFCDFJCOBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 KELILMNDAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 KMGMHKECNML;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2A76050", Offset = "0x2A74A50", VA = "0x182A76050")]
	public GFPILPNIEGL(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM, T4 KHPOJGAGIKD, T5 AFABEFPKEEG, T6 NJPBMMPBPIF, T7 GHJLALOIFKC, T8 GHMECOEOKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2A75920", Offset = "0x2A74320", VA = "0x182A75920", Slot = "4")]
	public int CompareTo(global::GFPILPNIEGL<T1, T2, T3, T4, T5, T6, T7, T8> OANENNOJEBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2A75B70", Offset = "0x2A74570", VA = "0x182A75B70", Slot = "0")]
	public override bool Equals(object OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2A75D30", Offset = "0x2A74730", VA = "0x182A75D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2A75EA0", Offset = "0x2A748A0", VA = "0x182A75EA0", Slot = "3")]
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
	public T OIHHNPGGOMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1967E30", Offset = "0x1966830", VA = "0x181967E30")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x42D8160", Offset = "0x42D6B60", VA = "0x1842D8160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float FLKCLBCGGNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1026220", Offset = "0x1024C20", VA = "0x181026220")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x42D8460", Offset = "0x42D6E60", VA = "0x1842D8460")]
	public T ONKOBHOOIKC(float KHJLEOILJMF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x42D8200", Offset = "0x42D6C00", VA = "0x1842D8200")]
	public T BJOBKFAOPIH(float KHJLEOILJMF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T NECJNGDDOKK(T OLACFPEGPAG, T GLLCOOLKDAC, float KHJLEOILJMF);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x37C02D0", Offset = "0x37BECD0", VA = "0x1837C02D0", Slot = "4")]
	protected override float NECJNGDDOKK(float OLACFPEGPAG, float GLLCOOLKDAC, float KHJLEOILJMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BE50", Offset = "0x5F6A850", VA = "0x185F6BE50")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B200", Offset = "0x1E19C00", VA = "0x181E1B200", Slot = "4")]
	protected override Vector3 NECJNGDDOKK(Vector3 OLACFPEGPAG, Vector3 GLLCOOLKDAC, float KHJLEOILJMF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5F73A20", Offset = "0x5F72420", VA = "0x185F73A20")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B3A0", Offset = "0x5F69DA0", VA = "0x185F6B3A0", Slot = "4")]
	protected override Color NECJNGDDOKK(Color OLACFPEGPAG, Color GLLCOOLKDAC, float KHJLEOILJMF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B3F0", Offset = "0x5F69DF0", VA = "0x185F6B3F0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JGACENBDGLI : global::NGIJOHKPMMH<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D480", Offset = "0x5F6BE80", VA = "0x185F6D480")]
	public JGACENBDGLI(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D420", Offset = "0x5F6BE20", VA = "0x185F6D420")]
	public JGACENBDGLI(JCGAALIHFEC[] HJKDLBPJPBF, bool BCIAEBEODEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D3B0", Offset = "0x5F6BDB0", VA = "0x185F6D3B0", Slot = "6")]
	protected override uint EKEMOIMKPIB(uint ECCMGNHBKIL, string MAKFNMHIJIF)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NBIJGHGGABN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public NBIJGHGGABN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct ICPPHJLENFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class EMBHEGLBNPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<ABCENELPPGI> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public EMBHEGLBNPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5F6B520", Offset = "0x5F69F20", VA = "0x185F6B520")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<ABCENELPPGI>> LKFHFIAKKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int FDGANBPNMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int KOAIHBGLMKH;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xCB2250", Offset = "0xCB0C50", VA = "0x180CB2250")]
	private ICPPHJLENFJ(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<ABCENELPPGI>> AGICIICLKFB, int DEMCEDMGDPL, int CAEOMKLPFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5F6CDB0", Offset = "0x5F6B7B0", VA = "0x185F6CDB0")]
	public static ICPPHJLENFJ OJKIKDBCCPC()
	{
		return default(ICPPHJLENFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C9C0", Offset = "0x5F6B3C0", VA = "0x185F6C9C0")]
	public (int, int, Task) MJKNFAAADGM(int BDKOHAFBNID, [Optional] CancellationToken JLIEBAENBAG)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C8E0", Offset = "0x5F6B2E0", VA = "0x185F6C8E0")]
	public void ADGGEAFGMIG(int BDKOHAFBNID, int CAEOMKLPFEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class JAHOPNJIMNI<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> AJCEPGLHDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> NBDKEHKKFAO;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7930", Offset = "0x1FE6330", VA = "0x181FE7930", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool DEIPNMFGOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> IBCHNDKEOEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2596BB0", Offset = "0x25955B0", VA = "0x182596BB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> HENELDMCHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2596A10", Offset = "0x2595410", VA = "0x182596A10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x319BA40", Offset = "0x319A440", VA = "0x18319BA40", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x319BA70", Offset = "0x319A470", VA = "0x18319BA70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x319B170", Offset = "0x3199B70", VA = "0x18319B170")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x319B0F0", Offset = "0x3199AF0", VA = "0x18319B0F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x319AE30", Offset = "0x3199830", VA = "0x18319AE30", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x319B910", Offset = "0x319A310", VA = "0x18319B910", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x25819C0", Offset = "0x25803C0", VA = "0x1825819C0", Slot = "9")]
	public void Add(TKey AIGAKEKDKHM, TVal MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x319AE00", Offset = "0x3199800", VA = "0x18319AE00", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x319AE90", Offset = "0x3199890", VA = "0x18319AE90", Slot = "8")]
	public bool ContainsKey(TKey AIGAKEKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x319AEF0", Offset = "0x31998F0", VA = "0x18319AEF0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x319B860", Offset = "0x319A260", VA = "0x18319B860", Slot = "10")]
	public bool Remove(TKey AIGAKEKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x319B860", Offset = "0x319A260", VA = "0x18319B860", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2585D30", Offset = "0x2584730", VA = "0x182585D30", Slot = "11")]
	public bool TryGetValue(TKey AIGAKEKDKHM, out TVal MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x319B1A0", Offset = "0x3199BA0", VA = "0x18319B1A0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x319AF20", Offset = "0x3199920", VA = "0x18319AF20", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] HEONDDEAIBL, int EBNCDCCMBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x319B740", Offset = "0x319A140", VA = "0x18319B740")]
	public void MFMCNFFMIAP(TVal PHMPKLAMLAM, TKey AIGAKEKDKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x319B7F0", Offset = "0x319A1F0", VA = "0x18319B7F0")]
	public void MFMCNFFMIAP(KeyValuePair<TVal, TKey> GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x319B830", Offset = "0x319A230", VA = "0x18319B830")]
	public bool OMNCCBLJMKA(TVal AIGAKEKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x319B2D0", Offset = "0x3199CD0", VA = "0x18319B2D0")]
	public bool HEBLGIOGKGC(KeyValuePair<TVal, TKey> GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x319B090", Offset = "0x3199A90", VA = "0x18319B090")]
	public bool EMIFMEAGDDE(TVal AIGAKEKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x319B090", Offset = "0x3199A90", VA = "0x18319B090")]
	public bool EMIFMEAGDDE(KeyValuePair<TVal, TKey> GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x319B410", Offset = "0x3199E10", VA = "0x18319B410")]
	public bool IDEDABPJLGL(TVal AIGAKEKDKHM, out TKey MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x319ACC0", Offset = "0x31996C0", VA = "0x18319ACC0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> AAFLPNCIFMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x319B300", Offset = "0x3199D00", VA = "0x18319B300")]
	private void HNNKDLKGAFI(TKey AIGAKEKDKHM, TVal PHMPKLAMLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x319B010", Offset = "0x3199A10", VA = "0x18319B010")]
	private void DFEJOPEGFOA(TKey AIGAKEKDKHM, TVal PHMPKLAMLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x319B440", Offset = "0x3199E40", VA = "0x18319B440")]
	private bool LCFIBBDBNFE(TKey AIGAKEKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x319B500", Offset = "0x3199F00", VA = "0x18319B500")]
	private bool LCFIBBDBNFE(TVal PHMPKLAMLAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x319B960", Offset = "0x319A360", VA = "0x18319B960")]
	public JAHOPNJIMNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class OPHCFFOEKGN<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::OPHCFFOEKGN<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2F86400", Offset = "0x2F84E00", VA = "0x182F86400", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2F89680", Offset = "0x2F88080", VA = "0x182F89680")]
		public Enumerator(global::OPHCFFOEKGN<T> DICKNCEHGPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2F83A30", Offset = "0x2F82430", VA = "0x182F83A30", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2F85400", Offset = "0x2F83E00", VA = "0x182F85400", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2F80B30", Offset = "0x2F7F530", VA = "0x182F80B30")]
		private void CCBJBIJFDDH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] GCBELKIOIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int LGAFDCAKAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int ILBGCAOLGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int AJGHIJIKOBE;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3B35960", Offset = "0x3B34360", VA = "0x183B35960")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3B34930", Offset = "0x3B33330", VA = "0x183B34930")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3B346B0", Offset = "0x3B330B0", VA = "0x183B346B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3B35F90", Offset = "0x3B34990", VA = "0x183B35F90")]
	public OPHCFFOEKGN(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3B358A0", Offset = "0x3B342A0", VA = "0x183B358A0")]
	public void MFMCNFFMIAP(T KHJLEOILJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3B349E0", Offset = "0x3B333E0", VA = "0x183B349E0")]
	public void HGKMPAKBDLD(IEnumerable<T> NGFNEKEOBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3B35A30", Offset = "0x3B34430", VA = "0x183B35A30")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3B355E0", Offset = "0x3B33FE0", VA = "0x183B355E0")]
	public void LPOBKMOKLBH(int FPLNDBJJHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3B359A0", Offset = "0x3B343A0", VA = "0x183B359A0")]
	public void NINMKKOOPEI(int FPLNDBJJHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3B343A0", Offset = "0x3B32DA0", VA = "0x183B343A0")]
	public void DCEIPPFEHJE(T[] HEONDDEAIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3B34080", Offset = "0x3B32A80", VA = "0x183B34080")]
	public Enumerator CBILBBMABKJ()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3B35F10", Offset = "0x3B34910", VA = "0x183B35F10", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3B35F10", Offset = "0x3B34910", VA = "0x183B35F10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3B35C30", Offset = "0x3B34630", VA = "0x183B35C30")]
	private int PMELEOIIPOO(int EBBLFLFCHFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3B34830", Offset = "0x3B33230", VA = "0x183B34830")]
	private int GCKNPIDPANO(int EBBLFLFCHFB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class JCJOHEIBNOL<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> JNICKEKIKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> BGDBKLMEHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> ACLENHAHHHH;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> GPLGJABMAHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676B30", VA = "0x180678130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool DEIPNMFGOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x767F80", Offset = "0x766980", VA = "0x180767F80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x731170", Offset = "0x72FB70", VA = "0x180731170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x31A2690", Offset = "0x31A1090", VA = "0x1831A2690", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x31A2730", Offset = "0x31A1130", VA = "0x1831A2730", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x31A2630", Offset = "0x31A1030", VA = "0x1831A2630", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x31A25A0", Offset = "0x31A0FA0", VA = "0x1831A25A0")]
	public JCJOHEIBNOL(Func<Internal, External> JNICKEKIKKP, Func<External, Internal> BGDBKLMEHHK, bool JPIIMKIJCFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x31A22C0", Offset = "0x31A0CC0", VA = "0x1831A22C0", Slot = "6")]
	public int IndexOf(External GIFJLGCAEHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x31A1F40", Offset = "0x31A0940", VA = "0x1831A1F40", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x31A1FA0", Offset = "0x31A09A0", VA = "0x1831A1FA0", Slot = "13")]
	public bool Contains(External GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x31A2030", Offset = "0x31A0A30", VA = "0x1831A2030", Slot = "14")]
	public void CopyTo(External[] HEONDDEAIBL, int EBNCDCCMBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x31A1E50", Offset = "0x31A0850", VA = "0x1831A1E50", Slot = "11")]
	public void Add(External GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x31A23B0", Offset = "0x31A0DB0", VA = "0x1831A23B0", Slot = "7")]
	public void Insert(int EBBLFLFCHFB, External GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x31A2510", Offset = "0x31A0F10", VA = "0x1831A2510", Slot = "15")]
	public bool Remove(External GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x31A2450", Offset = "0x31A0E50", VA = "0x1831A2450", Slot = "8")]
	public void RemoveAt(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x31A2250", Offset = "0x31A0C50", VA = "0x1831A2250", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x25721F0", Offset = "0x2570BF0", VA = "0x1825721F0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class MAPCALNMOCM<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> JNICKEKIKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> ACLENHAHHHH;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> GPLGJABMAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x697140", Offset = "0x695B40", VA = "0x180697140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool DEIPNMFGOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x698020", Offset = "0x696A20", VA = "0x180698020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x3CEC1E0", Offset = "0x3CEABE0", VA = "0x183CEC1E0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3CEC180", Offset = "0x3CEAB80", VA = "0x183CEC180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x257A080", Offset = "0x2578A80", VA = "0x18257A080")]
	public MAPCALNMOCM(Func<Internal, External> JNICKEKIKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3CEC130", Offset = "0x3CEAB30", VA = "0x183CEC130")]
	public MAPCALNMOCM(IReadOnlyList<Internal> ACLENHAHHHH, Func<Internal, External> JNICKEKIKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3CEBEA0", Offset = "0x3CEA8A0", VA = "0x183CEBEA0")]
	public void DCEIPPFEHJE(External[] HEONDDEAIBL, int EBNCDCCMBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3CEC0C0", Offset = "0x3CEAAC0", VA = "0x183CEC0C0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x24CF620", Offset = "0x24CE020", VA = "0x1824CF620", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class OEBLBOHKBEE<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> ACLENHAHHHH;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> GPLGJABMAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x697130", Offset = "0x695B30", VA = "0x180697130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool DEIPNMFGOOD
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x698020", Offset = "0x696A20", VA = "0x180698020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x32C0E10", Offset = "0x32BF810", VA = "0x1832C0E10", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x32C0DB0", Offset = "0x32BF7B0", VA = "0x1832C0DB0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x257A080", Offset = "0x2578A80", VA = "0x18257A080")]
	public OEBLBOHKBEE(IReadOnlyList<Internal> ACLENHAHHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x32C0D10", Offset = "0x32BF710", VA = "0x1832C0D10")]
	public bool HEBLGIOGKGC(External GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x32C0A70", Offset = "0x32BF470", VA = "0x1832C0A70")]
	public void DCEIPPFEHJE(External[] HEONDDEAIBL, int EBNCDCCMBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x32C0CA0", Offset = "0x32BF6A0", VA = "0x1832C0CA0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x25721F0", Offset = "0x2570BF0", VA = "0x1825721F0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class LOHEPEKNJDG
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BJMBPBAPMOH(object[] HNGHLHHNPMK);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	protected LOHEPEKNJDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class FEOCLBIEGLC<T> : LOHEPEKNJDG
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	protected struct OBHOJOHNPLL
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum INIMLGANLJJ
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
		public INIMLGANLJJ MCLMFJEAHEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T PBOHOIMMGFG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int AJJJNGALJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool MEMKEMAFGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool KELLOJKFALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> OKELIODFDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<OBHOJOHNPLL> JENPMNNFNPJ;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool BOONJHGAGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x31D6940", Offset = "0x31D5340", VA = "0x1831D6940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x31D6A90", Offset = "0x31D5490", VA = "0x1831D6A90")]
	protected FEOCLBIEGLC(bool KELLOJKFALD, bool MEMKEMAFGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x31D66A0", Offset = "0x31D50A0", VA = "0x1831D66A0")]
	protected bool GPJDEDLFLMP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x31D6720", Offset = "0x31D5120", VA = "0x1831D6720")]
	protected void IJNBNODPPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x31D63B0", Offset = "0x31D4DB0", VA = "0x1831D63B0")]
	protected void DFKKOMNLOAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2D6E770", Offset = "0x2D6D170", VA = "0x182D6E770")]
	private static void MEHGBHBBNJD<U>(ref List<U> ACLENHAHHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x31D67E0", Offset = "0x31D51E0", VA = "0x1831D67E0", Slot = "5")]
	public void MFMCNFFMIAP(T PBOHOIMMGFG, bool EOKOPABKJOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x31D6560", Offset = "0x31D4F60", VA = "0x1831D6560", Slot = "6")]
	public void EMIFMEAGDDE(T PBOHOIMMGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x31D6980", Offset = "0x31D5380", VA = "0x1831D6980")]
	public void PGHHBKOCHPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface CHKJNDLPICI
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFMCNFFMIAP(Action PBOHOIMMGFG, bool EOKOPABKJOD = false);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMIFMEAGDDE(Action PBOHOIMMGFG);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class FHIFKLKAEJA : global::FEOCLBIEGLC<Action>, CHKJNDLPICI
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BDF0", Offset = "0x5F6A7F0", VA = "0x185F6BDF0")]
	public FHIFKLKAEJA(bool KELLOJKFALD = false, bool MEMKEMAFGFI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BB20", Offset = "0x5F6A520", VA = "0x185F6BB20")]
	public void BOKGNJCLLJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BAB0", Offset = "0x5F6A4B0", VA = "0x185F6BAB0", Slot = "4")]
	public override void BJMBPBAPMOH(object[] HNGHLHHNPMK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BD30", Offset = "0x5F6A730", VA = "0x185F6BD30")]
	public static FHIFKLKAEJA CPMGNAGFNGK(FHIFKLKAEJA BJPMLKBCBLO, Action PBOHOIMMGFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BD90", Offset = "0x5F6A790", VA = "0x185F6BD90")]
	public static FHIFKLKAEJA NBCCFCPLHOF(FHIFKLKAEJA BJPMLKBCBLO, Action PBOHOIMMGFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface NCHOAGBLPIG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFMCNFFMIAP(Action<T> PBOHOIMMGFG, bool EOKOPABKJOD = false);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMIFMEAGDDE(Action<T> PBOHOIMMGFG);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class DIDGCDLBPOE<T> : global::FEOCLBIEGLC<Action<T>>, global::NCHOAGBLPIG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2652590", Offset = "0x2650F90", VA = "0x182652590")]
	public DIDGCDLBPOE(bool KELLOJKFALD = false, bool MEMKEMAFGFI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2651650", Offset = "0x2650050", VA = "0x182651650")]
	public void BOKGNJCLLJG(T KHJLEOILJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x264F770", Offset = "0x264E170", VA = "0x18264F770", Slot = "4")]
	public override void BJMBPBAPMOH(object[] HNGHLHHNPMK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2652450", Offset = "0x2650E50", VA = "0x182652450")]
	public static global::DIDGCDLBPOE<T> CPMGNAGFNGK(global::DIDGCDLBPOE<T> BJPMLKBCBLO, Action<T> PBOHOIMMGFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x26524F0", Offset = "0x2650EF0", VA = "0x1826524F0")]
	public static global::DIDGCDLBPOE<T> NBCCFCPLHOF(global::DIDGCDLBPOE<T> BJPMLKBCBLO, Action<T> PBOHOIMMGFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface LJEOMBABBJN<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFMCNFFMIAP(Action<T, U> PBOHOIMMGFG, bool EOKOPABKJOD = false);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMIFMEAGDDE(Action<T, U> PBOHOIMMGFG);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class HHFONFHJAEB<T, U> : global::FEOCLBIEGLC<Action<T, U>>, global::LJEOMBABBJN<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2652590", Offset = "0x2650F90", VA = "0x182652590")]
	public HHFONFHJAEB(bool KELLOJKFALD = false, bool MEMKEMAFGFI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3F38EA0", Offset = "0x3F378A0", VA = "0x183F38EA0")]
	public void BOKGNJCLLJG(T KHJLEOILJMF, U LOKAFGDNNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3F35820", Offset = "0x3F34220", VA = "0x183F35820", Slot = "4")]
	public override void BJMBPBAPMOH(object[] HNGHLHHNPMK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3F39340", Offset = "0x3F37D40", VA = "0x183F39340")]
	public static global::HHFONFHJAEB<T, U> CPMGNAGFNGK(global::HHFONFHJAEB<T, U> BJPMLKBCBLO, Action<T, U> PBOHOIMMGFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3F393E0", Offset = "0x3F37DE0", VA = "0x183F393E0")]
	public static global::HHFONFHJAEB<T, U> NBCCFCPLHOF(global::HHFONFHJAEB<T, U> BJPMLKBCBLO, Action<T, U> PBOHOIMMGFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface KDAKOHIOEII<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFMCNFFMIAP(Action<T, U, V> PBOHOIMMGFG, bool EOKOPABKJOD = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMIFMEAGDDE(Action<T, U, V> PBOHOIMMGFG);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class PKFHEEKPKKD<T, U, V> : global::FEOCLBIEGLC<Action<T, U, V>>, global::KDAKOHIOEII<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2652590", Offset = "0x2650F90", VA = "0x182652590")]
	public PKFHEEKPKKD(bool KELLOJKFALD = false, bool MEMKEMAFGFI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x3180B50", Offset = "0x317F550", VA = "0x183180B50")]
	public void BOKGNJCLLJG(T KHJLEOILJMF, U LOKAFGDNNFC, V HIGLPPEBKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x317DF50", Offset = "0x317C950", VA = "0x18317DF50", Slot = "4")]
	public override void BJMBPBAPMOH(object[] HNGHLHHNPMK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x31812E0", Offset = "0x317FCE0", VA = "0x1831812E0")]
	public static global::PKFHEEKPKKD<T, U, V> CPMGNAGFNGK(global::PKFHEEKPKKD<T, U, V> BJPMLKBCBLO, Action<T, U, V> PBOHOIMMGFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3181380", Offset = "0x317FD80", VA = "0x183181380")]
	public static global::PKFHEEKPKKD<T, U, V> NBCCFCPLHOF(global::PKFHEEKPKKD<T, U, V> BJPMLKBCBLO, Action<T, U, V> PBOHOIMMGFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface KPEKPINBHDM<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFMCNFFMIAP(Action<T, U, V, W> PBOHOIMMGFG, bool EOKOPABKJOD = false);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMIFMEAGDDE(Action<T, U, V, W> PBOHOIMMGFG);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class BMFLDIECGBN<T, U, V, W> : global::FEOCLBIEGLC<Action<T, U, V, W>>, global::KPEKPINBHDM<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2652590", Offset = "0x2650F90", VA = "0x182652590")]
	public BMFLDIECGBN(bool KELLOJKFALD = false, bool MEMKEMAFGFI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3436350", Offset = "0x3434D50", VA = "0x183436350")]
	public void BOKGNJCLLJG(T KHJLEOILJMF, U LOKAFGDNNFC, V HIGLPPEBKMI, W JNLBJEDABNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3435620", Offset = "0x3434020", VA = "0x183435620", Slot = "4")]
	public override void BJMBPBAPMOH(object[] HNGHLHHNPMK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3437010", Offset = "0x3435A10", VA = "0x183437010")]
	public static global::BMFLDIECGBN<T, U, V, W> CPMGNAGFNGK(global::BMFLDIECGBN<T, U, V, W> BJPMLKBCBLO, Action<T, U, V, W> PBOHOIMMGFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x34370B0", Offset = "0x3435AB0", VA = "0x1834370B0")]
	public static global::BMFLDIECGBN<T, U, V, W> NBCCFCPLHOF(global::BMFLDIECGBN<T, U, V, W> BJPMLKBCBLO, Action<T, U, V, W> PBOHOIMMGFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface LCECLIOGCID<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFMCNFFMIAP(Action<T, U, V, W, X> PBOHOIMMGFG, bool EOKOPABKJOD = false);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMIFMEAGDDE(Action<T, U, V, W, X> PBOHOIMMGFG);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class AAMCBGHEIGI<T, U, V, W, X> : global::FEOCLBIEGLC<Action<T, U, V, W, X>>, global::LCECLIOGCID<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x2652590", Offset = "0x2650F90", VA = "0x182652590")]
	public AAMCBGHEIGI(bool KELLOJKFALD = false, bool MEMKEMAFGFI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x38A7520", Offset = "0x38A5F20", VA = "0x1838A7520")]
	public void BOKGNJCLLJG(T KHJLEOILJMF, U LOKAFGDNNFC, V HIGLPPEBKMI, W JNLBJEDABNH, X FBHIPILAOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x38A7230", Offset = "0x38A5C30", VA = "0x1838A7230", Slot = "4")]
	public override void BJMBPBAPMOH(object[] HNGHLHHNPMK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x38A7AE0", Offset = "0x38A64E0", VA = "0x1838A7AE0")]
	public static global::AAMCBGHEIGI<T, U, V, W, X> CPMGNAGFNGK(global::AAMCBGHEIGI<T, U, V, W, X> BJPMLKBCBLO, Action<T, U, V, W, X> PBOHOIMMGFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x38A7B80", Offset = "0x38A6580", VA = "0x1838A7B80")]
	public static global::AAMCBGHEIGI<T, U, V, W, X> NBCCFCPLHOF(global::AAMCBGHEIGI<T, U, V, W, X> BJPMLKBCBLO, Action<T, U, V, W, X> PBOHOIMMGFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface NHNCIFKPEPN<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFMCNFFMIAP(Action<T, U, V, W, X, Y> PBOHOIMMGFG, bool EOKOPABKJOD = false);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMIFMEAGDDE(Action<T, U, V, W, X, Y> PBOHOIMMGFG);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class OOFMMIOMMON<T, U, V, W, X, Y> : global::FEOCLBIEGLC<Action<T, U, V, W, X, Y>>, global::NHNCIFKPEPN<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x2652590", Offset = "0x2650F90", VA = "0x182652590")]
	public OOFMMIOMMON(bool KELLOJKFALD = false, bool MEMKEMAFGFI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3B2F740", Offset = "0x3B2E140", VA = "0x183B2F740")]
	public void BOKGNJCLLJG(T KHJLEOILJMF, U LOKAFGDNNFC, V HIGLPPEBKMI, W JNLBJEDABNH, X FBHIPILAOBE, Y DPKHPCDGHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3B2EAC0", Offset = "0x3B2D4C0", VA = "0x183B2EAC0", Slot = "4")]
	public override void BJMBPBAPMOH(object[] HNGHLHHNPMK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3B2F9F0", Offset = "0x3B2E3F0", VA = "0x183B2F9F0")]
	public static global::OOFMMIOMMON<T, U, V, W, X, Y> CPMGNAGFNGK(global::OOFMMIOMMON<T, U, V, W, X, Y> BJPMLKBCBLO, Action<T, U, V, W, X, Y> PBOHOIMMGFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3B2FA90", Offset = "0x3B2E490", VA = "0x183B2FA90")]
	public static global::OOFMMIOMMON<T, U, V, W, X, Y> NBCCFCPLHOF(global::OOFMMIOMMON<T, U, V, W, X, Y> BJPMLKBCBLO, Action<T, U, V, W, X, Y> PBOHOIMMGFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class OCAOLNHHFPP<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct MDIJKHLFBFG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::OCAOLNHHFPP<T> OKNLHBNKJNO;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T OIHHNPGGOMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x2E8F860", Offset = "0x2E8E260", VA = "0x182E8F860")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2E8F830", Offset = "0x2E8E230", VA = "0x182E8F830", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x88CB80", Offset = "0x88B580", VA = "0x18088CB80")]
		public MDIJKHLFBFG(global::OCAOLNHHFPP<T> OKNLHBNKJNO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct OHOHAKMBCEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<MDIJKHLFBFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::OCAOLNHHFPP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x32C7EA0", Offset = "0x32C68A0", VA = "0x1832C7EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x1FDA340", Offset = "0x1FD8D40", VA = "0x181FDA340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct NKIBGJBNHIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<MDIJKHLFBFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::OCAOLNHHFPP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2C1AD20", Offset = "0x2C19720", VA = "0x182C1AD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1FDA340", Offset = "0x1FD8D40", VA = "0x181FDA340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim BANBNCJNNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T DJGLBNHLKLO;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int LLMGNDGLNPK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8790", Offset = "0x2AB7190", VA = "0x182AB8790")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2AB8D50", Offset = "0x2AB7750", VA = "0x182AB8D50")]
	public OCAOLNHHFPP(in T DJGLBNHLKLO, int COPBECCINLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2AB8E90", Offset = "0x2AB7890", VA = "0x182AB8E90")]
	public OCAOLNHHFPP(in T DJGLBNHLKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2AB8710", Offset = "0x2AB7110", VA = "0x182AB8710")]
	public MDIJKHLFBFG LLONAODEMDC()
	{
		return default(MDIJKHLFBFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2AB8750", Offset = "0x2AB7150", VA = "0x182AB8750")]
	public MDIJKHLFBFG LLONAODEMDC(CancellationToken JLIEBAENBAG)
	{
		return default(MDIJKHLFBFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2AB8A80", Offset = "0x2AB7480", VA = "0x182AB8A80")]
	[AsyncStateMachine(typeof(global::OCAOLNHHFPP<>.OHOHAKMBCEE))]
	public Task<MDIJKHLFBFG> MGNLFBNOIJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2AB87B0", Offset = "0x2AB71B0", VA = "0x182AB87B0")]
	[AsyncStateMachine(typeof(global::OCAOLNHHFPP<>.NKIBGJBNHIN))]
	public Task<MDIJKHLFBFG> MGNLFBNOIJC(CancellationToken JLIEBAENBAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class LMDDJENOAJL
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E0C0", Offset = "0x5F6CAC0", VA = "0x185F6E0C0")]
	public static global::OCAOLNHHFPP<ABCENELPPGI> OJKIKDBCCPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E120", Offset = "0x5F6CB20", VA = "0x185F6E120")]
	public static global::OCAOLNHHFPP<ABCENELPPGI> OJKIKDBCCPC(int COPBECCINLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x249BA90", Offset = "0x249A490", VA = "0x18249BA90")]
	public static global::OCAOLNHHFPP<T> OJKIKDBCCPC<T>(in T DJGLBNHLKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2799B10", Offset = "0x2798510", VA = "0x182799B10")]
	public static global::OCAOLNHHFPP<T> OJKIKDBCCPC<T>(in T DJGLBNHLKLO, int COPBECCINLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class ELCIDDJLDCB<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate Task<TResult> MLEPNILKGCO(TRequest GHNJJOLFHLE, CancellationToken JLIEBAENBAG);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum OBNKLKLEAOO
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class NOOJLBKCGBM
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float EANJNIDMKPE = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan BJHMKFAALIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int KLKFANEFKBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public OBNKLKLEAOO HHOKHFNNFEG;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly NOOJLBKCGBM MKNJDLGIAOG;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float CMFKEDHHCPI
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3B233E0", Offset = "0x3B21DE0", VA = "0x183B233E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan DBCHIHAOLJG
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3B234C0", Offset = "0x3B21EC0", VA = "0x183B234C0")]
		public NOOJLBKCGBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private readonly struct AAGMAFIMKAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest GHNJJOLFHLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken JLIEBAENBAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> FELNAAAPKJO;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x38A6E60", Offset = "0x38A5860", VA = "0x1838A6E60")]
		public AAGMAFIMKAD(TRequest GHNJJOLFHLE, TaskCompletionSource<TResult> FELNAAAPKJO, CancellationToken JLIEBAENBAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class DLEHDGNBGDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public DLEHDGNBGDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7930", Offset = "0x1FE6330", VA = "0x181FE7930")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct CFINJIPBCPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::ELCIDDJLDCB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x289B6D0", Offset = "0x289A0D0", VA = "0x18289B6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x67F320", Offset = "0x67DD20", VA = "0x18067F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct DHKCGHGFKID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::ELCIDDJLDCB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private AAGMAFIMKAD <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x264DF80", Offset = "0x264C980", VA = "0x18264DF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x67F320", Offset = "0x67DD20", VA = "0x18067F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource MMJAONOMCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<AAGMAFIMKAD> FKBBDDOPLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly NOOJLBKCGBM ANIIMKCDHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MLEPNILKGCO NIHBKGFFHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task OJDPKHDKCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int IHNACPPDDPE;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x25701E0", Offset = "0x256EBE0", VA = "0x1825701E0")]
	public ELCIDDJLDCB(MLEPNILKGCO NIHBKGFFHID, [Optional] NOOJLBKCGBM ANIIMKCDHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x256F9A0", Offset = "0x256E3A0", VA = "0x18256F9A0")]
	public Task<TResult> NMNBJNPMHAB(TRequest GHNJJOLFHLE, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x256FE60", Offset = "0x256E860", VA = "0x18256FE60")]
	private void OJODPNCOPLA(AAGMAFIMKAD FKBEKHPDNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x256F2E0", Offset = "0x256DCE0", VA = "0x18256F2E0")]
	[AsyncStateMachine(typeof(global::ELCIDDJLDCB<, >.CFINJIPBCPL))]
	private Task LADICEMNKHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x256EAE0", Offset = "0x256D4E0", VA = "0x18256EAE0")]
	private AAGMAFIMKAD EFOLMBHNDHM()
	{
		return default(AAGMAFIMKAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x256E860", Offset = "0x256D260", VA = "0x18256E860")]
	[AsyncStateMachine(typeof(global::ELCIDDJLDCB<, >.DHKCGHGFKID))]
	private Task DOPBNONFNDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x256F5B0", Offset = "0x256DFB0", VA = "0x18256F5B0")]
	private void MGIBPPOBDNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x256EAA0", Offset = "0x256D4A0", VA = "0x18256EAA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class DCHACEMAAJB<TKey, TVal> : global::NDNGBBCKHCE<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int DHBDDFIAENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> OGPKNOAFACL;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int GFMOOKAPJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x26407F0", Offset = "0x263F1F0", VA = "0x1826407F0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int NMHGIFHEGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2640720", Offset = "0x263F120", VA = "0x182640720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2640B50", Offset = "0x263F550", VA = "0x182640B50", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2640C20", Offset = "0x263F620", VA = "0x182640C20")]
	public DCHACEMAAJB(int FHGNFGIEADL, [Optional] CMBLDCEKAGA CFFGMELEKKB, [Optional] IEqualityComparer<TKey> HBGNHHMIMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2640750", Offset = "0x263F150", VA = "0x182640750")]
	public void FMEOPAEPEHB(TKey AIGAKEKDKHM, TVal MAKFNMHIJIF, bool KCEMNGGENMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x2640A30", Offset = "0x263F430", VA = "0x182640A30")]
	public bool HLDGLPNLMHP(TKey AIGAKEKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x2640AB0", Offset = "0x263F4B0", VA = "0x182640AB0", Slot = "6")]
	public override bool IDEDABPJLGL(TKey EMOIKMNLKII, out TVal MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2640820", Offset = "0x263F220", VA = "0x182640820")]
	public bool GACFEKPHLIM(TKey AIGAKEKDKHM, TVal MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x2640570", Offset = "0x263EF70", VA = "0x182640570")]
	public bool BPECLAKNIMF(TKey AIGAKEKDKHM, TVal MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2640BB0", Offset = "0x263F5B0", VA = "0x182640BB0", Slot = "7")]
	public override void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2640680", Offset = "0x263F080", VA = "0x182640680")]
	private bool CCNBKKLLHKE(TKey AIGAKEKDKHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class NDNGBBCKHCE<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public delegate int CMBLDCEKAGA(TKey AIGAKEKDKHM, TVal MAKFNMHIJIF);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class MJNGCLLDKNC
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey LLHJHGGBGGL
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xD6AC50", Offset = "0xD69650", VA = "0x180D6AC50")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal OIHHNPGGOMC
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676B30", VA = "0x180678130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int DAPJFJMMFBP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x6991B0", Offset = "0x697BB0", VA = "0x1806991B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x82CDE0", Offset = "0x82B7E0", VA = "0x18082CDE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime NPCKGPMDEKL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C0F0", VA = "0x18068D6F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xE659A0", Offset = "0xE643A0", VA = "0x180E659A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2EA6EB0", Offset = "0x2EA58B0", VA = "0x182EA6EB0")]
		public MJNGCLLDKNC(TKey AIGAKEKDKHM, TVal PHMPKLAMLAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int LLGKFGDGHLP = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<MJNGCLLDKNC>> DCCOKGJBFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<MJNGCLLDKNC> GNFGFEDEFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly CMBLDCEKAGA CFFGMELEKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan BKCGMNJIHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly JEIIFICOFCM JKFNNLDKEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int IOELDJAOBCD;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int KMFAFOCNGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x677020", Offset = "0x675A20", VA = "0x180677020")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool NBHHELAGNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2C0C2D0", Offset = "0x2C0ACD0", VA = "0x182C0C2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int GFMOOKAPJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x95F870", Offset = "0x95E270", VA = "0x18095F870", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int FPLNDBJJHMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2767D60", Offset = "0x2766760", VA = "0x182767D60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x226C700", Offset = "0x226B100", VA = "0x18226C700", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> IBCHNDKEOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2C0A4F0", Offset = "0x2C08EF0", VA = "0x182C0A4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2C0AF00", Offset = "0x2C09900", VA = "0x182C0AF00")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2C0AE90", Offset = "0x2C09890", VA = "0x182C0AE90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x2C0D880", Offset = "0x2C0C280", VA = "0x182C0D880")]
	public NDNGBBCKHCE(int FHGNFGIEADL, [Optional] CMBLDCEKAGA CFFGMELEKKB, [Optional] IEqualityComparer<TKey> HBGNHHMIMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2C0D490", Offset = "0x2C0BE90", VA = "0x182C0D490")]
	public NDNGBBCKHCE(TimeSpan BKCGMNJIHAM, [Optional] IEqualityComparer<TKey> HBGNHHMIMOI, [Optional] JEIIFICOFCM JKFNNLDKEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2C0D4E0", Offset = "0x2C0BEE0", VA = "0x182C0D4E0")]
	public NDNGBBCKHCE(int FHGNFGIEADL, TimeSpan BKCGMNJIHAM, [Optional] IEqualityComparer<TKey> HBGNHHMIMOI, [Optional] JEIIFICOFCM JKFNNLDKEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2C0DF20", Offset = "0x2C0C920", VA = "0x182C0DF20")]
	public NDNGBBCKHCE(int FHGNFGIEADL, CMBLDCEKAGA CFFGMELEKKB, TimeSpan BKCGMNJIHAM, [Optional] IEqualityComparer<TKey> HBGNHHMIMOI, [Optional] JEIIFICOFCM JKFNNLDKEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2C0B0B0", Offset = "0x2C09AB0", VA = "0x182C0B0B0")]
	public void IAEIAJCJPJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2C0C070", Offset = "0x2C0AA70", VA = "0x182C0C070")]
	public void KMNEKDAGPNL(TKey AIGAKEKDKHM, TVal MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2C0AB90", Offset = "0x2C09590", VA = "0x182C0AB90")]
	public bool EMIFMEAGDDE(TKey AIGAKEKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2C0A7F0", Offset = "0x2C091F0", VA = "0x182C0A7F0")]
	private TVal DNJGGIFCOKL(TKey EMOIKMNLKII)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2C0B500", Offset = "0x2C09F00", VA = "0x182C0B500", Slot = "6")]
	public virtual bool IDEDABPJLGL(TKey EMOIKMNLKII, out TVal MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2C0D420", Offset = "0x2C0BE20", VA = "0x182C0D420", Slot = "7")]
	public virtual void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x2C0A1F0", Offset = "0x2C08BF0", VA = "0x182C0A1F0")]
	private bool AEGOGJBDNHC(MJNGCLLDKNC DCAFEJFFOOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2C0D1D0", Offset = "0x2C0BBD0", VA = "0x182C0D1D0")]
	private void OPMGFKBEAOC(LinkedListNode<MJNGCLLDKNC> GADFCCOIBBL, TVal MAEOIACPFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C0C540", Offset = "0x2C0AF40", VA = "0x182C0C540")]
	private void OGKJCDPEKGH(TKey AIGAKEKDKHM, TVal MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x2C0B920", Offset = "0x2C0A320", VA = "0x182C0B920")]
	private void KDPCHMCHNEH(MJNGCLLDKNC DCAFEJFFOOI, TVal MAEOIACPFFP, int PJNHBAIDLOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
public class ANKBCJBOEIJ<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> ACLENHAHHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> EMPLNBBNKIE;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7930", Offset = "0x1FE6330", VA = "0x181FE7930", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool DEIPNMFGOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1EAC060", Offset = "0x1EAAA60", VA = "0x181EAC060", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3827860", Offset = "0x3826260", VA = "0x183827860", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2913590", Offset = "0x2911F90", VA = "0x182913590", Slot = "11")]
	public void Add(T GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3826F60", Offset = "0x3825960", VA = "0x183826F60")]
	public bool FKGKAEHMBPL(T GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x38275B0", Offset = "0x3825FB0", VA = "0x1838275B0", Slot = "15")]
	public bool Remove(T GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2585C80", Offset = "0x2584680", VA = "0x182585C80", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x24BBF40", Offset = "0x24BA940", VA = "0x1824BBF40", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3826ED0", Offset = "0x38258D0", VA = "0x183826ED0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2689DB0", Offset = "0x26887B0", VA = "0x182689DB0", Slot = "13")]
	public bool Contains(T GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3826F30", Offset = "0x3825930", VA = "0x183826F30", Slot = "14")]
	public void CopyTo(T[] HEONDDEAIBL, int EBNCDCCMBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x319BA40", Offset = "0x319A440", VA = "0x18319BA40", Slot = "6")]
	public int IndexOf(T GIFJLGCAEHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x3827180", Offset = "0x3825B80", VA = "0x183827180", Slot = "7")]
	public void Insert(int EBBLFLFCHFB, T GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3827410", Offset = "0x3825E10", VA = "0x183827410", Slot = "8")]
	public void RemoveAt(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3827240", Offset = "0x3825C40", VA = "0x183827240")]
	public void KCBMKPEBDJF(Predicate<T> KIEFNBLKNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x38273E0", Offset = "0x3825DE0", VA = "0x1838273E0")]
	public void MJAFONJILHK(Comparison<T> FEIBNCKGMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x38276C0", Offset = "0x38260C0", VA = "0x1838276C0")]
	public ANKBCJBOEIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class FFIIGFJDANN
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B7E0", Offset = "0x5F6A1E0", VA = "0x185F6B7E0")]
	public static Vector3 COHOIIBDACI(this GameObject EHEABJNEALG, float JNAACOPLCPJ)
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
			[Cpp2IlInjected.Address(RVA = "0x297D4A0", Offset = "0x297BEA0", VA = "0x18297D4A0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5F73000", Offset = "0x5F71A00", VA = "0x185F73000")]
		public SerializedGuid(in Guid GDIIAHJOKME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5F72B20", Offset = "0x5F71520", VA = "0x185F72B20")]
		public static SerializedGuid CFKPLKEHJHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5F72D80", Offset = "0x5F71780", VA = "0x185F72D80")]
		public static SerializedGuid IFCIKIILLEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5F72F70", Offset = "0x5F71970", VA = "0x185F72F70")]
		public bool PNDBPNEHPOE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5F72EB0", Offset = "0x5F718B0", VA = "0x185F72EB0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5F72E10", Offset = "0x5F71810", VA = "0x185F72E10", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5F72EE0", Offset = "0x5F718E0", VA = "0x185F72EE0")]
		public bool PEGCDPIHGIH(in Guid GDIIAHJOKME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5F72BE0", Offset = "0x5F715E0", VA = "0x185F72BE0", Slot = "7")]
		public bool Equals(SerializedGuid OANENNOJEBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5F72C90", Offset = "0x5F71690", VA = "0x185F72C90", Slot = "0")]
		public override bool Equals(object LGKNNMGLNIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5F72D70", Offset = "0x5F71770", VA = "0x185F72D70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5F72BB0", Offset = "0x5F715B0", VA = "0x185F72BB0", Slot = "6")]
		public int CompareTo(SerializedGuid OANENNOJEBB)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class GJHKMGNLKJA : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type CMLGKHBCMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string PCEHNKHGHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool FBJMPPDNEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool GDIJMEMDFPL;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C170", Offset = "0x5F6AB70", VA = "0x185F6C170")]
	public GJHKMGNLKJA(Type FLEMACEHAPO, string BKKDIDMLLFG, bool KBIGAAHLLEB = false, bool LEKBAMDDNAP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface MIMJNBMJCHL
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface GJDDGLMMKIJ<T> : MIMJNBMJCHL
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T OIHHNPGGOMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool GICPBKDAEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string DDCPHGIIMND
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
	global::GJDDGLMMKIJ<T> JGMENGAGDMG(Action<T> MJJOKKCPEKP);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::GJDDGLMMKIJ<T> JLNMNDOGGIM(Action<T> MJJOKKCPEKP);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::GJDDGLMMKIJ<T> HAKGPJDJIOP(Action<T, T> BOMOHCIBPDL);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::GJDDGLMMKIJ<T> DNMJMICAJCD(Action<T, T> BOMOHCIBPDL);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::GJDDGLMMKIJ<T> BIAKLLMNNJJ(Action<string> NGKDMEPIKJK);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::GJDDGLMMKIJ<T> CAJGPDBBOAO(Action<string> NGKDMEPIKJK);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class INJNELLJIKP<T> : global::GJDDGLMMKIJ<T>, MIMJNBMJCHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::HHFONFHJAEB<T, T> KPIMPLJCOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::DIDGCDLBPOE<T> JHPNHNEPMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::DIDGCDLBPOE<string> HBEFLBCKNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string OOMNIJBIFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T BIDLMNEFHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool HODKIGJFECK;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T OIHHNPGGOMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C0F0", VA = "0x18068D6F0", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x24BB0C0", Offset = "0x24B9AC0", VA = "0x1824BB0C0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool GICPBKDAEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x742540", Offset = "0x740F40", VA = "0x180742540", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string DDCPHGIIMND
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6902E0", VA = "0x1806918E0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x1554420", Offset = "0x1552E20", VA = "0x181554420", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x24BB200", Offset = "0x24B9C00", VA = "0x1824BB200")]
	private void CKBOMKNNBHG(T GOMBJHKPMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x24BB4D0", Offset = "0x24B9ED0", VA = "0x1824BB4D0")]
	private void LHKBMOIOJDA(string DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x24BB2F0", Offset = "0x24B9CF0", VA = "0x1824BB2F0")]
	public void GJKIOCLBKIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x24BB3A0", Offset = "0x24B9DA0", VA = "0x1824BB3A0", Slot = "6")]
	public global::GJDDGLMMKIJ<T> HAKGPJDJIOP(Action<T, T> BOMOHCIBPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x24BB2A0", Offset = "0x24B9CA0", VA = "0x1824BB2A0", Slot = "7")]
	public global::GJDDGLMMKIJ<T> DNMJMICAJCD(Action<T, T> BOMOHCIBPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x24BB3F0", Offset = "0x24B9DF0", VA = "0x1824BB3F0", Slot = "4")]
	public global::GJDDGLMMKIJ<T> JGMENGAGDMG(Action<T> BOMOHCIBPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x24BB480", Offset = "0x24B9E80", VA = "0x1824BB480", Slot = "5")]
	public global::GJDDGLMMKIJ<T> JLNMNDOGGIM(Action<T> MJJOKKCPEKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x24BB0F0", Offset = "0x24B9AF0", VA = "0x1824BB0F0", Slot = "8")]
	public global::GJDDGLMMKIJ<T> BIAKLLMNNJJ(Action<string> NGKDMEPIKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x24BB190", Offset = "0x24B9B90", VA = "0x1824BB190", Slot = "9")]
	public global::GJDDGLMMKIJ<T> CAJGPDBBOAO(Action<string> NGKDMEPIKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x24BB580", Offset = "0x24B9F80", VA = "0x1824BB580")]
	public INJNELLJIKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class NKEHOIEMFLB
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class PGLLILBFKEE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::GJDDGLMMKIJ<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::HCPAFFBNPPI<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public PGLLILBFKEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3172FD0", Offset = "0x31719D0", VA = "0x183172FD0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x39D0640", Offset = "0x39CF040", VA = "0x1839D0640")]
	public static global::DIHJKCFGFNO<T> IHBCBCAIMIC<T>(this global::GJDDGLMMKIJ<T> JLDPICNFBOB, Action<T> ONHFNOPIIKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class IMNAINPHIAI<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public readonly struct MECHGGHOKGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long JCJBGGEHJCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long DCCAPHBMAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int GAJNHPMBIEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int NLKGPLEOMKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool GPGIIALFPII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string FFCMOKMMJLP;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2E96240", Offset = "0x2E94C40", VA = "0x182E96240")]
		public MECHGGHOKGB(long JCJBGGEHJCO, int GAJNHPMBIEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x2E96210", Offset = "0x2E94C10", VA = "0x182E96210")]
		public MECHGGHOKGB(long JCJBGGEHJCO, long DCCAPHBMAKM, int GAJNHPMBIEF, int NLKGPLEOMKF, bool GPGIIALFPII, string FFCMOKMMJLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2E96110", Offset = "0x2E94B10", VA = "0x182E96110")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void JLNALMCFDOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2E960C0", Offset = "0x2E94AC0", VA = "0x182E960C0")]
		public int DFJMMPOKCGO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2E96180", Offset = "0x2E94B80", VA = "0x182E96180")]
		public int LHBEPPGOMIM(int KHFJNOFBFJH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2E961A0", Offset = "0x2E94BA0", VA = "0x182E961A0")]
		public double OJHIINBEAEI()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2E96030", Offset = "0x2E94A30", VA = "0x182E96030")]
		public MECHGGHOKGB CBPBEHAHNAH(long DCCAPHBMAKM, int NLKGPLEOMKF)
		{
			return default(MECHGGHOKGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class GPNAMOIINIG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey LLHJHGGBGGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::IMNAINPHIAI<TKey> IDKFKDEHFHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<GPNAMOIINIG> DBNMDABHIBI;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string BJGMNENHOPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x1E25F60", Offset = "0x1E24960", VA = "0x181E25F60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x35D62A0", Offset = "0x35D4CA0", VA = "0x1835D62A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<GPNAMOIINIG> KEPEEEPLAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x35D62D0", Offset = "0x35D4CD0", VA = "0x1835D62D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public MECHGGHOKGB GMECMLPGFKC
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x16A3990", Offset = "0x16A2390", VA = "0x1816A3990")]
			[CompilerGenerated]
			get
			{
				return default(MECHGGHOKGB);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x35D65B0", Offset = "0x35D4FB0", VA = "0x1835D65B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x35D66C0", Offset = "0x35D50C0", VA = "0x1835D66C0")]
		internal GPNAMOIINIG(global::IMNAINPHIAI<TKey> IDKFKDEHFHM, TKey AIGAKEKDKHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x35D62F0", Offset = "0x35D4CF0", VA = "0x1835D62F0")]
		public GPNAMOIINIG DMCONOPIPBN(TKey AIGAKEKDKHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x35D65E0", Offset = "0x35D4FE0", VA = "0x1835D65E0")]
		public void PDLAKBALGNK(TKey AIGAKEKDKHM, Action<GPNAMOIINIG> PBOHOIMMGFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x376D260", Offset = "0x376BC60", VA = "0x18376D260")]
		public T PDLAKBALGNK<T>(TKey AIGAKEKDKHM, Func<GPNAMOIINIG, T> FIFMLJNEANH)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x376D0F0", Offset = "0x376BAF0", VA = "0x18376D0F0")]
		[AsyncStateMachine(typeof(IMLPJAOINKO))]
		public Task<T> FMELLIGOPBO<T>(TKey AIGAKEKDKHM, Func<GPNAMOIINIG, Task<T>> FIFMLJNEANH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x35D6400", Offset = "0x35D4E00", VA = "0x1835D6400", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class ILINBGMHPCM : IEnumerable<(TKey, List<TKey>, MECHGGHOKGB)>, IEnumerable, IEnumerator<(TKey, List<TKey>, MECHGGHOKGB)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, MECHGGHOKGB timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::IMNAINPHIAI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, MECHGGHOKGB timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, MECHGGHOKGB) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x21FD300", Offset = "0x21FBD00", VA = "0x1821FD300", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, MECHGGHOKGB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x24B2910", Offset = "0x24B1310", VA = "0x1824B2910", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x21FD560", Offset = "0x21FBF60", VA = "0x1821FD560")]
		[DebuggerHidden]
		public ILINBGMHPCM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x220F700", Offset = "0x220E100", VA = "0x18220F700", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x24B2530", Offset = "0x24B0F30", VA = "0x1824B2530", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x24B2970", Offset = "0x24B1370", VA = "0x1824B2970")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x24B28D0", Offset = "0x24B12D0", VA = "0x1824B28D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x24B27E0", Offset = "0x24B11E0", VA = "0x1824B27E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, MECHGGHOKGB)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x24B28A0", Offset = "0x24B12A0", VA = "0x1824B28A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class IFCICJPLNMO : IEnumerable<(TKey, List<TKey>, MECHGGHOKGB)>, IEnumerable, IEnumerator<(TKey, List<TKey>, MECHGGHOKGB)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, MECHGGHOKGB timerEntry) <>2__current;

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
		private GPNAMOIINIG timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public GPNAMOIINIG <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::IMNAINPHIAI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<GPNAMOIINIG> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, MECHGGHOKGB timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, MECHGGHOKGB) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x21FD300", Offset = "0x21FBD00", VA = "0x1821FD300", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, MECHGGHOKGB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x21FD3A0", Offset = "0x21FBDA0", VA = "0x1821FD3A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x21FD560", Offset = "0x21FBF60", VA = "0x1821FD560")]
		[DebuggerHidden]
		public IFCICJPLNMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x21FD400", Offset = "0x21FBE00", VA = "0x1821FD400", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x21FCC80", Offset = "0x21FB680", VA = "0x1821FCC80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x21FD4A0", Offset = "0x21FBEA0", VA = "0x1821FD4A0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x21FD500", Offset = "0x21FBF00", VA = "0x1821FD500")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x21FD360", Offset = "0x21FBD60", VA = "0x1821FD360", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x21FD220", Offset = "0x21FBC20", VA = "0x1821FD220", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, MECHGGHOKGB)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x21FD330", Offset = "0x21FBD30", VA = "0x1821FD330", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, MECHGGHOKGB> CKAINHNLOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, MECHGGHOKGB> GDIJDPANPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::IMNAINPHIAI<TKey>> EEGOMPKNKGG;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string OGKBMKGGOLO = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly GPNAMOIINIG LACALLMKCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool GLPBIJFMILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int JKMPNLPCCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch BJBNCBNGCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int PGKCHINKOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string JCFCJFGKCFL;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public GPNAMOIINIG LPKMKPCJJCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6902E0", VA = "0x1806918E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string BJGMNENHOPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6770D0", Offset = "0x675AD0", VA = "0x1806770D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x24BAD40", Offset = "0x24B9740", VA = "0x1824BAD40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long KAHLIBHKHDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x24BAF20", Offset = "0x24B9920", VA = "0x1824BAF20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int LDAPHMBDBBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x24BAEF0", Offset = "0x24B98F0", VA = "0x1824BAEF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x24BAF40", Offset = "0x24B9940", VA = "0x1824BAF40")]
	public IMNAINPHIAI(TKey ANCBBPDPCKE, [Optional] int? GAJNHPMBIEF, [Optional][CanBeNull] Stopwatch BJBNCBNGCEP, [Optional] Action<TKey, MECHGGHOKGB> CKAINHNLOMD, [Optional] Action<TKey, MECHGGHOKGB> GDIJDPANPIK, [Optional] Action<global::IMNAINPHIAI<TKey>> EEGOMPKNKGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x24BAE40", Offset = "0x24B9840", VA = "0x1824BAE40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x24BAE20", Offset = "0x24B9820", VA = "0x1824BAE20")]
	public void DKDNBCMJFNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x24BAED0", Offset = "0x24B98D0", VA = "0x1824BAED0")]
	public void EHPMFPNKDKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x24BABE0", Offset = "0x24B95E0", VA = "0x1824BABE0")]
	[IteratorStateMachine(typeof(global::IMNAINPHIAI<>.ILINBGMHPCM))]
	public IEnumerable<(TKey, List<TKey>, MECHGGHOKGB)> ABCMDMKPDKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x24BAC70", Offset = "0x24B9670", VA = "0x1824BAC70")]
	[IteratorStateMachine(typeof(global::IMNAINPHIAI<>.IFCICJPLNMO))]
	private IEnumerable<(TKey, List<TKey>, MECHGGHOKGB)> ABCMDMKPDKB(List<TKey> GFBIJELPOGE, GPNAMOIINIG DFEFIINOOJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x24BADA0", Offset = "0x24B97A0", VA = "0x1824BADA0")]
	private (long, int) BPGOOIBKFMC()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class DLOHCIFPCOL<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut GMGNBAIFOHI(global::IMNAINPHIAI<TKey> IDKFKDEHFHM);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
	protected DLOHCIFPCOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class HKMLBLLANGJ<TKey> : global::DLOHCIFPCOL<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate string ELHJGOONKLJ(TKey AIGAKEKDKHM);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x431A8D0", Offset = "0x43192D0", VA = "0x18431A8D0")]
	protected string OKAKEKMGIAI(double HHGANBKBOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x431A650", Offset = "0x4319050", VA = "0x18431A650")]
	protected string GDDJBHOLPHC(int FEIKHKEENLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x431A6B0", Offset = "0x43190B0", VA = "0x18431A6B0")]
	private static string GEKOLILBPIN(TKey AIGAKEKDKHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x431A820", Offset = "0x4319220", VA = "0x18431A820", Slot = "4")]
	public override string GMGNBAIFOHI(global::IMNAINPHIAI<TKey> IDKFKDEHFHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x431A6F0", Offset = "0x43190F0", VA = "0x18431A6F0")]
	public string GMGNBAIFOHI(global::IMNAINPHIAI<TKey> IDKFKDEHFHM, [NotNull] ELHJGOONKLJ KKILGMJELKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string PLADKDGLFHA(global::IMNAINPHIAI<TKey> IDKFKDEHFHM, [NotNull] ELHJGOONKLJ KKILGMJELKL);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x25721F0", Offset = "0x2570BF0", VA = "0x1825721F0")]
	protected HKMLBLLANGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class ICOHJPNAGPK<TKey> : global::DLOHCIFPCOL<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate string LKJJNDFICGB(TKey AIGAKEKDKHM);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int OHKMEJKKLCJ = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string MAPEFNAHLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double CAJLNGEOJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool MEBMPGHCDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int GMLGNFOAOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> MFGNDLJIAPF;

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2788240", Offset = "0x2786C40", VA = "0x182788240")]
	private static string GEKOLILBPIN(TKey AIGAKEKDKHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2788A20", Offset = "0x2787420", VA = "0x182788A20")]
	public ICOHJPNAGPK(string MAPEFNAHLOH = "F2", double CAJLNGEOJLJ = double.MaxValue, bool MEBMPGHCDHF = false, int GMLGNFOAOPG = int.MaxValue, [Optional] ISet<string> MFGNDLJIAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x27887C0", Offset = "0x27871C0", VA = "0x1827887C0", Slot = "4")]
	public override Dictionary<string, string> GMGNBAIFOHI(global::IMNAINPHIAI<TKey> IDKFKDEHFHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2788160", Offset = "0x2786B60", VA = "0x182788160")]
	private bool DGJKFODNPAH(string BFFCDBNLLNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2788280", Offset = "0x2786C80", VA = "0x182788280")]
	public Dictionary<string, string> GMGNBAIFOHI(global::IMNAINPHIAI<TKey> IDKFKDEHFHM, LKJJNDFICGB KKILGMJELKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2788870", Offset = "0x2787270", VA = "0x182788870")]
	private string LHIPIEDKAAD(StringBuilder ADEGNJKGLGH, List<TKey> EOBCGCHNBEH, LKJJNDFICGB KKILGMJELKL, bool EAMABKOMBMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2787FE0", Offset = "0x27869E0", VA = "0x182787FE0")]
	private static void DBIHMGKCKDH(StringBuilder FKNABNKLMLP, string NIFNMPKFCFF, bool EKGNAMIMBKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class PFDIGCIPPFB<TKey> : global::HKMLBLLANGJ<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct OGKLGEKMFDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public ELHJGOONKLJ keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::PFDIGCIPPFB<TKey> LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int BOAKNOKBHHE = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] DDENEKFDCHH;

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x31707B0", Offset = "0x316F1B0", VA = "0x1831707B0")]
	private PFDIGCIPPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x316F7C0", Offset = "0x316E1C0", VA = "0x18316F7C0", Slot = "5")]
	protected override string PLADKDGLFHA(global::IMNAINPHIAI<TKey> IDKFKDEHFHM, ELHJGOONKLJ KKILGMJELKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x316F6D0", Offset = "0x316E0D0", VA = "0x18316F6D0")]
	[CompilerGenerated]
	internal static string PAFIFJEIPHI(string BNDGOHBFEAI, TKey AIGAKEKDKHM, ref OGKLGEKMFDO P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class IDOAMPNKHHD<TKey> : global::HKMLBLLANGJ<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class BFLFHGMPDFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public ELHJGOONKLJ keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public BFLFHGMPDFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1E26660", Offset = "0x1E25060", VA = "0x181E26660")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2793F60", Offset = "0x2792960", VA = "0x182793F60", Slot = "5")]
	protected override string PLADKDGLFHA(global::IMNAINPHIAI<TKey> IDKFKDEHFHM, ELHJGOONKLJ KKILGMJELKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2585E60", Offset = "0x2584860", VA = "0x182585E60")]
	public IDOAMPNKHHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public sealed class GAKMFMMDBHB : global::IMNAINPHIAI<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class OGLMFGNHGGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<GAKMFMMDBHB> callback;

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public OGLMFGNHGGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5F70700", Offset = "0x5F6F100", VA = "0x185F70700")]
		internal void <Wrap>b__0(global::IMNAINPHIAI<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BF70", Offset = "0x5F6A970", VA = "0x185F6BF70")]
	public GAKMFMMDBHB([Optional] string OOCECJOPGJJ, [Optional] int? GAJNHPMBIEF, [Optional] Stopwatch BJBNCBNGCEP, [Optional] Action<string, MECHGGHOKGB> CKAINHNLOMD, [Optional] Action<string, MECHGGHOKGB> GDIJDPANPIK, [Optional] Action<GAKMFMMDBHB> EEGOMPKNKGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BE90", Offset = "0x5F6A890", VA = "0x185F6BE90")]
	private static Action<global::IMNAINPHIAI<string>> PDLAKBALGNK(Action<GAKMFMMDBHB> ONHFNOPIIKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class JEIIFICOFCM
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class KMGCCBPJCHN : JEIIFICOFCM
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static JEIIFICOFCM LOGBPMLPMIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x5F6DF10", Offset = "0x5F6C910", VA = "0x185F6DF10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime CPNEFJKBOJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x5F6DF70", Offset = "0x5F6C970", VA = "0x185F6DF70", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float CEKALADGLHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x5F6DF00", Offset = "0x5F6C900", VA = "0x185F6DF00", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5F6E060", Offset = "0x5F6CA60", VA = "0x185F6E060")]
		public KMGCCBPJCHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static JEIIFICOFCM JECOKCHGCAG;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static JEIIFICOFCM MKNJDLGIAOG
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5F6D220", Offset = "0x5F6BC20", VA = "0x185F6D220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime CPNEFJKBOJO
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float CEKALADGLHG
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	protected JEIIFICOFCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class AOIMBPIFNMN : global::EKMNAMHGPIH<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A260", Offset = "0x5F68C60", VA = "0x185F6A260")]
	public AOIMBPIFNMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class EKMNAMHGPIH<T> : global::IIADFENEKIO<T>, PMGNJJECALA, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> KLHDKFIHOGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task INDBBJFPDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x1563EC0", Offset = "0x15628C0", VA = "0x181563EC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::DIHJKCFGFNO<T> JIMIEHFMAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private IGOPHNBFNOE KAOKMONIIIH
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1554230", Offset = "0x1552C30", VA = "0x181554230", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x25670C0", Offset = "0x2565AC0", VA = "0x1825670C0")]
	public EKMNAMHGPIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class BDMBEJNMMBP : global::NCMPNKNHBEP<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B220", Offset = "0x5F69C20", VA = "0x185F6B220")]
	public BDMBEJNMMBP(Exception CNABBHHIHOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class NCMPNKNHBEP<T> : global::IIADFENEKIO<T>, PMGNJJECALA, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> KLHDKFIHOGD
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task INDBBJFPDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1563EC0", Offset = "0x15628C0", VA = "0x181563EC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::DIHJKCFGFNO<T> JIMIEHFMAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private IGOPHNBFNOE KAOKMONIIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1554230", Offset = "0x1552C30", VA = "0x181554230", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x239ACD0", Offset = "0x23996D0", VA = "0x18239ACD0")]
	public NCMPNKNHBEP(Exception CNABBHHIHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface PMGNJJECALA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task KLHDKFIHOGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	IGOPHNBFNOE JIMIEHFMAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface IIADFENEKIO<T> : PMGNJJECALA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> KLHDKFIHOGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::DIHJKCFGFNO<T> JIMIEHFMAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public abstract class KNDNJAHLILL<TTask, T> : global::IIADFENEKIO<T>, PMGNJJECALA, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class NLGNCHCJIEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public global::KNDNJAHLILL<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public NLGNCHCJIEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool IFIAOIHIOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> LMDFEBFDNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource MFPMCEFBCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool GLPBIJFMILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private SynchronizationContext JBMMBAINBME;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> KLHDKFIHOGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task INDBBJFPDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::DIHJKCFGFNO<T> JIMIEHFMAPK
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private IGOPHNBFNOE KAOKMONIIIH
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x1562240", Offset = "0x1560C40", VA = "0x181562240", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool OKJAKPPJFHO
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x767F80", Offset = "0x766980", VA = "0x180767F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x370B370", Offset = "0x3709D70", VA = "0x18370B370")]
	static KNDNJAHLILL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x370B650", Offset = "0x370A050", VA = "0x18370B650")]
	protected KNDNJAHLILL(TTask LMDFEBFDNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x370B2B0", Offset = "0x3709CB0", VA = "0x18370B2B0", Slot = "1")]
	~KNDNJAHLILL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x370B280", Offset = "0x3709C80", VA = "0x18370B280", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x370B110", Offset = "0x3709B10", VA = "0x18370B110")]
	private void BOHBKACNFPB(bool NMPOCBGKCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T LLIMFJLEJAB(TTask FPOKMIILBGH);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void DELDDFBAIPA();

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x370B320", Offset = "0x3709D20", VA = "0x18370B320")]
	[CompilerGenerated]
	private void GGNKDCKBHFK(object IAHPHHNFGHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface EIPKADAOJJH
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float JHIACKNNLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event OOHNJLLKJKP BOMFJCMHNEA;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class MNFBCLMGCPE : EIPKADAOJJH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public readonly struct KDGJHJMAIOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float PMIJFIGEABJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public readonly float OADENGHFLFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		internal readonly bool DEHMHJNDOKD;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float DAPJFJMMFBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x5F6D690", Offset = "0x5F6C090", VA = "0x185F6D690")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x5F6D820", Offset = "0x5F6C220", VA = "0x185F6D820")]
		public KDGJHJMAIOG(float LJECKBCMELA, float EAJAFIHJLHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x5F6D6A0", Offset = "0x5F6C0A0", VA = "0x185F6D6A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class BIDAJLJPBKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public MNFBCLMGCPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public BIDAJLJPBKC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly int FHGNFGIEADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private int LFNMGIOGJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly EIPKADAOJJH[] HEIDPMPJDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly OOHNJLLKJKP[] NBJJAAKBODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly KDGJHJMAIOG[] NNENFPGBNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private KDGJHJMAIOG NLOJELHBMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly IKHDPONDBON LECICDBBPNG;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public KDGJHJMAIOG APLMKNCCCHO
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x32DC290", Offset = "0x32DAC90", VA = "0x1832DC290")]
		get
		{
			return default(KDGJHJMAIOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float JHIACKNNLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5F70260", Offset = "0x5F6EC60", VA = "0x185F70260", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event OOHNJLLKJKP BOMFJCMHNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5F70280", Offset = "0x5F6EC80", VA = "0x185F70280", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5F6FCC0", Offset = "0x5F6E6C0", VA = "0x185F6FCC0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x5F703E0", Offset = "0x5F6EDE0", VA = "0x185F703E0")]
	public MNFBCLMGCPE(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x5F6FD80", Offset = "0x5F6E780", VA = "0x185F6FD80")]
	public IKHDPONDBON GJFAIHPAPAA(KDGJHJMAIOG NGFNEKEOBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x5F6FE10", Offset = "0x5F6E810", VA = "0x185F6FE10")]
	public void KCALJDMAEHK(EIPKADAOJJH IACBHIONDIF, [Optional] KDGJHJMAIOG HLHAKPMJOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x5F70340", Offset = "0x5F6ED40", VA = "0x185F70340")]
	internal int NCLIALNFMIA(EIPKADAOJJH CNCPFNFODHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x5F70390", Offset = "0x5F6ED90", VA = "0x185F70390")]
	internal KDGJHJMAIOG NDKNHHBOKKE(int EBBLFLFCHFB)
	{
		return default(KDGJHJMAIOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x5F6FB30", Offset = "0x5F6E530", VA = "0x185F6FB30", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public delegate void OOHNJLLKJKP(float FDGOEGBIGCD);
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal static class DEKCJEGPOAI
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	internal const float JJBNNNNJKML = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class PDEELILHKCA
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private class ODGOBOGPHLL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly EIPKADAOJJH CNCPFNFODHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly OOHNJLLKJKP ONHFNOPIIKL;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5F70610", Offset = "0x5F6F010", VA = "0x185F70610")]
		public ODGOBOGPHLL(EIPKADAOJJH CNCPFNFODHI, OOHNJLLKJKP ONHFNOPIIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5F705C0", Offset = "0x5F6EFC0", VA = "0x185F705C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5F708D0", Offset = "0x5F6F2D0", VA = "0x185F708D0")]
	internal static bool POEFOKGLMMH(float IKAMJBDPPHG, float LKLEFAIICIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x4A8CD70", Offset = "0x4A8B770", VA = "0x184A8CD70")]
	internal static float OBHJNKNMFEJ(float IKAMJBDPPHG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5F70810", Offset = "0x5F6F210", VA = "0x185F70810")]
	public static IDisposable OOJFNEMMMFG(this EIPKADAOJJH CNCPFNFODHI, OOHNJLLKJKP ONHFNOPIIKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class IKHDPONDBON : EIPKADAOJJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float FDGOEGBIGCD;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float JHIACKNNLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x10A3330", Offset = "0x10A1D30", VA = "0x1810A3330", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x5F6CE30", Offset = "0x5F6B830", VA = "0x185F6CE30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event OOHNJLLKJKP BOMFJCMHNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x5F6CF90", Offset = "0x5F6B990", VA = "0x185F6CF90", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x5F6CEF0", Offset = "0x5F6B8F0", VA = "0x185F6CEF0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public IKHDPONDBON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class KGKIFCOAOID
{
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D9D0", Offset = "0x5F6C3D0", VA = "0x185F6D9D0")]
	[NotNull]
	public static byte[] BJKBMJFHFBC(this ECOILECAPEP EILJKFHPELP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D960", Offset = "0x5F6C360", VA = "0x185F6D960")]
	[NotNull]
	public static byte[] BJKBMJFHFBC(this ECOILECAPEP EILJKFHPELP, HashAlgorithmName FEHIEOHKAKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5F6DBE0", Offset = "0x5F6C5E0", VA = "0x185F6DBE0")]
	public static bool DGJAEEMELCH([CanBeNull] this ECOILECAPEP EILJKFHPELP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5F6DA40", Offset = "0x5F6C440", VA = "0x185F6DA40")]
	public static bool DGJAEEMELCH([CanBeNull] this ECOILECAPEP EILJKFHPELP, out string OOMNIJBIFDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5F6DE90", Offset = "0x5F6C890", VA = "0x185F6DE90")]
	private static string HJEMCGICJMM([CanBeNull] byte[] PPJLGCLGPJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5F6DD70", Offset = "0x5F6C770", VA = "0x185F6DD70")]
	private static bool GIMALLCAFMK([NotNull] ECOILECAPEP EILJKFHPELP, [CanBeNull] out byte[] EGDKJDNBEFE, [CanBeNull] out byte[] FIIDHBLMLOE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class FBAOPPDKBFC
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B570", Offset = "0x5F69F70", VA = "0x185F6B570")]
	[NotNull]
	public static byte[] BJKBMJFHFBC(this NBMFECGHEHI NIGMFGAHEGM, byte[] PMKNAHPIBFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B5B0", Offset = "0x5F69FB0", VA = "0x185F6B5B0")]
	[NotNull]
	public static byte[] BJKBMJFHFBC(this NBMFECGHEHI NIGMFGAHEGM, HashAlgorithmName FEHIEOHKAKE, byte[] PMKNAHPIBFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface NBMFECGHEHI
{
	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash ECCMGNHBKIL);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface ECOILECAPEP : NBMFECGHEHI
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] DHGBECBLBDD
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
	byte[] BEDNMMIBODP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object OKHPOEJNNND
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class MDJBBHEBGLH
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private class IPFBPGHEMIE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x5F6D1A0", Offset = "0x5F6BBA0", VA = "0x185F6D1A0")]
		public IPFBPGHEMIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5F6D140", Offset = "0x5F6BB40", VA = "0x185F6D140", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte GEFLDMKBDJL = 1;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private const byte LIKDEGOANPA = 0;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly ArrayPool<byte> MFHFCMIPIGM;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static bool GGDIOEPFMGM;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x3BD0790", Offset = "0x3BCF190", VA = "0x183BD0790")]
	[Conditional("UNITY_EDITOR")]
	private static void LJANPNJINJL<T>(params T[] ANNJCJHIHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5F6F1C0", Offset = "0x5F6DBC0", VA = "0x185F6F1C0")]
	public static IDisposable JBNJJJAANNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x5F6F2D0", Offset = "0x5F6DCD0", VA = "0x185F6F2D0")]
	public static void MKNMHEFCOED(this IncrementalHash HCJBOJAANGO, [CanBeNull] GameObject EHEABJNEALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x3BD0A80", Offset = "0x3BCF480", VA = "0x183BD0A80")]
	public static void MKNMHEFCOED<T>(this IncrementalHash HCJBOJAANGO, [CanBeNull] T AALANACCLGM) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x3BD0010", Offset = "0x3BCEA10", VA = "0x183BD0010")]
	public static void GOJBIADPPMN<T>(this IncrementalHash HCJBOJAANGO, [CanBeNull] T NIGMFGAHEGM) where T : NBMFECGHEHI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x3BCFBB0", Offset = "0x3BCE5B0", VA = "0x183BCFBB0")]
	public static void DOOKOPOHBBN<T>(this IncrementalHash HCJBOJAANGO, [CanBeNull] IList<T> AFNILCHGKFB) where T : NBMFECGHEHI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E7C0", Offset = "0x5F6D1C0", VA = "0x185F6E7C0")]
	private static bool AMONLGEGCDG([CanBeNull] NBMFECGHEHI NIGMFGAHEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5F6EDD0", Offset = "0x5F6D7D0", VA = "0x185F6EDD0")]
	public static void FCLMCFNAPDJ(this IncrementalHash ECCMGNHBKIL, [CanBeNull] string KDLMPPJJELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5F6EA90", Offset = "0x5F6D490", VA = "0x185F6EA90")]
	public static void CONPHABDNEI(this IncrementalHash ECCMGNHBKIL, long DECMILFNAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E850", Offset = "0x5F6D250", VA = "0x185F6E850")]
	public static void AOKPDAMMMDC(this IncrementalHash ECCMGNHBKIL, int MFHOJLOFIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5F6F650", Offset = "0x5F6E050", VA = "0x185F6F650")]
	public static void ONJGPGGAAEP(this IncrementalHash ECCMGNHBKIL, short OJMGOIPAPAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5F6EC60", Offset = "0x5F6D660", VA = "0x185F6EC60")]
	public static void EFANKHEGIJH(this IncrementalHash ECCMGNHBKIL, byte AAOMPDMLJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F6F420", Offset = "0x5F6DE20", VA = "0x185F6F420")]
	public static void NFGJJDKHLOG(this IncrementalHash ECCMGNHBKIL, bool IJFFHGFJGFP, bool LGPLAOGCEOF = false, bool MMALKLKCCHK = false, bool GFLECIHMMNO = false, bool NDJGGJKKFDG = false, bool FELOPOHFBOF = false, bool GPNDHNEOAOH = false, bool EJLFDPKNNBC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x3BD00A0", Offset = "0x3BCEAA0", VA = "0x183BD00A0")]
	public static void LABAPOMDFGM<T>(this IncrementalHash ECCMGNHBKIL, T AOKJAINPPBI) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5F6F3C0", Offset = "0x5F6DDC0", VA = "0x185F6F3C0")]
	public static void MOGCNLIGMOO(this IncrementalHash ECCMGNHBKIL, float ABDNBEJOKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5F6F5F0", Offset = "0x5F6DFF0", VA = "0x185F6F5F0")]
	public static void NNLLNKJAHLD(this IncrementalHash ECCMGNHBKIL, double CAOHMGJLGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5F6EA20", Offset = "0x5F6D420", VA = "0x185F6EA20")]
	public static void BGMPDDNPLAG(this IncrementalHash ECCMGNHBKIL, ulong EFFMHOAJCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5F6EFA0", Offset = "0x5F6D9A0", VA = "0x185F6EFA0")]
	public static void IEJLONKKDKB(this IncrementalHash ECCMGNHBKIL, uint JLFBDPMFDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5F6F260", Offset = "0x5F6DC60", VA = "0x185F6F260")]
	public static void KDHAAHFCLLB(this IncrementalHash ECCMGNHBKIL, ushort GINMPNEGLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5F6EE30", Offset = "0x5F6D830", VA = "0x185F6EE30")]
	public static void HKOCMONNFDC(this IncrementalHash ECCMGNHBKIL, Vector3 HNEJEJCMCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5F6F000", Offset = "0x5F6DA00", VA = "0x185F6F000")]
	public static void IOOFHNMCHJK(this IncrementalHash ECCMGNHBKIL, Quaternion ICDLIGELECK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class ODMBFKEDGEL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly Type CMLGKHBCMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly string PCEHNKHGHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly bool FBJMPPDNEOC;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5F706A0", Offset = "0x5F6F0A0", VA = "0x185F706A0")]
	public ODMBFKEDGEL(Type FLEMACEHAPO, string BKKDIDMLLFG, bool KBIGAAHLLEB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class DLFJMKEBAAG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B4B0", Offset = "0x5F69EB0", VA = "0x185F6B4B0")]
	public DLFJMKEBAAG(string DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B430", Offset = "0x5F69E30", VA = "0x185F6B430")]
	public DLFJMKEBAAG(string DIDMFBHHIEC, Exception JFHFLCLBOLL)
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
			[Cpp2IlInjected.Address(RVA = "0x677040", Offset = "0x675A40", VA = "0x180677040")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x68D790", Offset = "0x68C190", VA = "0x18068D790")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int LJOFAPCHBHE, int OMAAILJEECD]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x36E0620", Offset = "0x36DF020", VA = "0x1836E0620")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x36E06C0", Offset = "0x36DF0C0", VA = "0x1836E06C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x36E0590", Offset = "0x36DEF90", VA = "0x1836E0590")]
		public Array2D(uint LEFBNKJDKNL, uint ELIEMKLAFPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x36E0510", Offset = "0x36DEF10", VA = "0x1836E0510")]
		public void PGHHBKOCHPM()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5F6A2A0", Offset = "0x5F68CA0", VA = "0x185F6A2A0")]
		public Array2DVector3(uint LEFBNKJDKNL, uint ELIEMKLAFPL)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal static class BNANMFAFOBE
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public const int NDIHHHDFJGN = -1;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public const int EDENMHLHABL = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[DefaultMember("Item")]
public class MCPCGCNIBLF<THandle, TValue> : IDisposable where THandle : struct, LDGEBNEMAMI where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly List<THandle> OEKBACIGMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly List<TValue> ECINCKPHFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly Func<TValue> HLCEOPOLEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly Action<TValue> MFIHNAIHJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int IDEHGJEBNAG;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x319B090", Offset = "0x3199A90", VA = "0x18319B090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x3CFE5C0", Offset = "0x3CFCFC0", VA = "0x183CFE5C0")]
	public MCPCGCNIBLF(Action<TValue> MFIHNAIHJDF, [Optional] Func<TValue> HLCEOPOLEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x3CFDE40", Offset = "0x3CFC840", VA = "0x183CFDE40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x3CFDA50", Offset = "0x3CFC450", VA = "0x183CFDA50")]
	public THandle CBFHJGEFJHE()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x3CFE390", Offset = "0x3CFCD90", VA = "0x183CFE390")]
	public THandle MFMCNFFMIAP(TValue MAKFNMHIJIF)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x3CFDF00", Offset = "0x3CFC900", VA = "0x183CFDF00")]
	public bool EMIFMEAGDDE(THandle ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x3CFE090", Offset = "0x3CFCA90", VA = "0x183CFE090")]
	public bool GGPEMOPMMCE(THandle ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x3CFDC70", Offset = "0x3CFC670", VA = "0x183CFDC70")]
	public bool DJEIEOEOGPA(THandle ODMNDKFKJHN, out TValue MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x3CFDD10", Offset = "0x3CFC710", VA = "0x183CFDD10")]
	public TValue DNJGGIFCOKL(THandle ODMNDKFKJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x3CFDD90", Offset = "0x3CFC790", VA = "0x183CFDD90")]
	public bool DPFPNIAFGMD(THandle ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x3CFDD60", Offset = "0x3CFC760", VA = "0x183CFDD60")]
	private THandle DOIDECLDOIC(int EBBLFLFCHFB)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x3CFE160", Offset = "0x3CFCB60", VA = "0x183CFE160")]
	private TValue IHBCBCAIMIC(int EBBLFLFCHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x3CFDEC0", Offset = "0x3CFC8C0", VA = "0x183CFDEC0")]
	private void EKLAELDPIGA(int EBBLFLFCHFB, in THandle ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x3CFDC30", Offset = "0x3CFC630", VA = "0x183CFDC30")]
	private void CKBOMKNNBHG(int EBBLFLFCHFB, in TValue MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x3CFE4B0", Offset = "0x3CFCEB0", VA = "0x183CFE4B0")]
	private THandle PHFDOILMBOA()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x3CFE400", Offset = "0x3CFCE00", VA = "0x183CFE400")]
	private void OCLOHIPKDCJ(THandle ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x3CFE190", Offset = "0x3CFCB90", VA = "0x183CFE190")]
	private int JAFIBKELMNB(int AJGHIJIKOBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x3CFDA40", Offset = "0x3CFC440", VA = "0x183CFDA40")]
	private bool ACCCDHLNJKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6DE640", Offset = "0x6DD040", VA = "0x1806DE640")]
	private void PMNKDBAKHPN(THandle ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x3CFDFB0", Offset = "0x3CFC9B0", VA = "0x183CFDFB0")]
	private bool FMJJCKPDKGH(out THandle ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x3CFE2C0", Offset = "0x3CFCCC0", VA = "0x183CFE2C0")]
	private bool LOBAKCMDLGA(out THandle ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x3CFE030", Offset = "0x3CFCA30", VA = "0x183CFE030")]
	private void FNACONNAFLO(THandle ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x3CFE1A0", Offset = "0x3CFCBA0", VA = "0x183CFE1A0")]
	private void JIMHKKHAHNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface LDGEBNEMAMI
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int DNFPKCNMAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int HOBPJIMDIAG
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
public interface LAJFKAIBBBL<T> : LDGEBNEMAMI, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class INEHKEHNKJO
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0xD832B0", Offset = "0xD81CB0", VA = "0x180D832B0")]
	public static bool NACDKJIFFFI<T>(this T ODMNDKFKJHN, T OANENNOJEBB) where T : struct, LDGEBNEMAMI
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x25F4510", Offset = "0x25F2F10", VA = "0x1825F4510")]
	public static bool DEHMHJNDOKD<T>(this T ODMNDKFKJHN) where T : struct, LDGEBNEMAMI
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D030", Offset = "0x5F6BA30", VA = "0x185F6D030")]
	public static string KDKGONCFMAM(this LDGEBNEMAMI ODMNDKFKJHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class BCAKKLDEJBK
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private enum CNBDJGLAHCG : byte
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
	private int ECCMGNHBKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private bool KEDLJMBPGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private CNBDJGLAHCG BLJBLMCPLPH;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool NGOMAJBEGFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5F6B120", Offset = "0x5F69B20", VA = "0x185F6B120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool MBBANKOLFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5F6A5A0", Offset = "0x5F68FA0", VA = "0x185F6A5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B1F0", Offset = "0x5F69BF0", VA = "0x185F6B1F0")]
	public BCAKKLDEJBK(bool KEDLJMBPGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A5B0", Offset = "0x5F68FB0", VA = "0x185F6A5B0")]
	public void IGEJOACLPAO(object LGKNNMGLNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A500", Offset = "0x5F68F00", VA = "0x185F6A500")]
	public void GGJAALDKKAO(int MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x5F6ACA0", Offset = "0x5F696A0", VA = "0x185F6ACA0")]
	public void KHPAONBDDCA(uint CMFNPEENAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A340", Offset = "0x5F68D40", VA = "0x185F6A340")]
	public void CIDPANDJGAJ(bool GFGHAEEEKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A300", Offset = "0x5F68D00", VA = "0x185F6A300")]
	public void CDKFOPGMBJN(long EDNJKCLGGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B1A0", Offset = "0x5F69BA0", VA = "0x185F6B1A0")]
	public void PAGCBEMODKK(ulong OCIEPMHGJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5F6AC30", Offset = "0x5F69630", VA = "0x185F6AC30")]
	public void KBGKLICOPBA(string FLFBAMENJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5F6ACB0", Offset = "0x5F696B0", VA = "0x185F6ACB0")]
	public void MHEPDNEFJNO(Enum CNABBHHIHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A360", Offset = "0x5F68D60", VA = "0x185F6A360")]
	public void EAAOMEOPGPP(IList ACLENHAHHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x25E12A0", Offset = "0x25DFCA0", VA = "0x1825E12A0")]
	public void IJDNEAKDBIE<T, U>(Dictionary<T, U> GKDAPMHFKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5F6AD40", Offset = "0x5F69740", VA = "0x185F6AD40")]
	private void NFKMHBENHBD(IDictionary GKDAPMHFKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B0B0", Offset = "0x5F69AB0", VA = "0x185F6B0B0")]
	public int OBCDNHOIKEG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A490", Offset = "0x5F68E90", VA = "0x185F6A490")]
	public short FHPKHBHIDIO()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B1E0", Offset = "0x5F69BE0", VA = "0x185F6B1E0")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B130", Offset = "0x5F69B30", VA = "0x185F6B130")]
	private void PAFECGDHMMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public abstract class OEFJLGMAFKB<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	internal class HJPFCJGKJPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public TNode DKOFBKPNBJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public TNode LFAIGCEGCPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public KKMMBHGNJPK BMNJCJDHIKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public List<KKMMBHGNJPK> OCGNIPAEEKH;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public HJPFCJGKJPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal struct KKMMBHGNJPK : IComparable<KKMMBHGNJPK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int IPGJOMPJEJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public TClaimant FJEAGLNJIBC;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x6A20B0", Offset = "0x6A0AB0", VA = "0x1806A20B0")]
		public KKMMBHGNJPK(int IPGJOMPJEJJ, TClaimant FJEAGLNJIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x2695B10", Offset = "0x2694510", VA = "0x182695B10")]
		public bool IABHICHANOJ(in KKMMBHGNJPK OANENNOJEBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x2695B70", Offset = "0x2694570", VA = "0x182695B70")]
		public bool POKDPOHIMFL(in KKMMBHGNJPK OANENNOJEBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x2695B00", Offset = "0x2694500", VA = "0x182695B00", Slot = "4")]
		public int CompareTo(KKMMBHGNJPK OANENNOJEBB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x2695B80", Offset = "0x2694580", VA = "0x182695B80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum EHBGGPNGMGB
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class KIFJGMDMLML : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public global::OEFJLGMAFKB<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x220F820", Offset = "0x220E220", VA = "0x18220F820")]
		[DebuggerHidden]
		public KIFJGMDMLML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x26817E0", Offset = "0x26801E0", VA = "0x1826817E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x26819A0", Offset = "0x26803A0", VA = "0x1826819A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x26818C0", Offset = "0x26802C0", VA = "0x1826818C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x1552730", Offset = "0x1551130", VA = "0x181552730", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly global::OHEBPJCKCKG<HJPFCJGKJPC> HMCPGJNLNOJ;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly global::OHEBPJCKCKG<List<KKMMBHGNJPK>> NGJNDJLNKAG;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static int APKEMHEPIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	internal readonly Dictionary<TClaimant, TNode> MCODPBMCMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	internal readonly Dictionary<TNode, HJPFCJGKJPC> IJLMJMKCIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private EHBGGPNGMGB OLBBMHHLPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool LNPMOHBLPOO;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode NCMHOFMDGAH(TNode ELOCLFMIMAL);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void NPBJNCPIEIM(TNode ELOCLFMIMAL, TClaimant OOHIIFMAPMN, TClaimant HEGGCMKDAEE);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x32C2620", Offset = "0x32C1020", VA = "0x1832C2620")]
	public OEFJLGMAFKB(EHBGGPNGMGB OLBBMHHLPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x32C20F0", Offset = "0x32C0AF0", VA = "0x1832C20F0")]
	public void MJDBLNOJKMG(TNode ELOCLFMIMAL, TNode EBIGGMLCEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x32C1AE0", Offset = "0x32C04E0", VA = "0x1832C1AE0")]
	public void HIMLOJILFDG(TClaimant FJEAGLNJIBC, TNode DFJNDOHLODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x32C1410", Offset = "0x32BFE10", VA = "0x1832C1410", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x32C16D0", Offset = "0x32C00D0", VA = "0x1832C16D0")]
	private void GMJHKFGHLEL(TClaimant FJEAGLNJIBC, TNode HAMBJOBGGEI, TNode DFJNDOHLODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x32C1670", Offset = "0x32C0070", VA = "0x1832C1670")]
	private int EBHCKINCHKK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x32C0ED0", Offset = "0x32BF8D0", VA = "0x1832C0ED0")]
	private void BBNLBOMBKAK(TClaimant FJEAGLNJIBC, TNode AKNMMMMELFH, TNode EGGHGELDMAI, int BCMLLFOABBC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x32C1F50", Offset = "0x32C0950", VA = "0x1832C1F50")]
	private void IPJGGBMJLAI(KKMMBHGNJPK HEOKMMJOMEO, HJPFCJGKJPC EOJBPKALALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x32C1BE0", Offset = "0x32C05E0", VA = "0x1832C1BE0")]
	private void HMKAHEIMBCK(TClaimant FJEAGLNJIBC, TNode AKNMMMMELFH, TNode EGGHGELDMAI, int BCMLLFOABBC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x32C1E40", Offset = "0x32C0840", VA = "0x1832C1E40")]
	private void HNJDKEKLIGI(KKMMBHGNJPK HEOKMMJOMEO, TNode ELOCLFMIMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x32C1180", Offset = "0x32BFB80", VA = "0x1832C1180")]
	private void BNNHEICBFAP(KKMMBHGNJPK HEOKMMJOMEO, HJPFCJGKJPC EOJBPKALALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x32C1FE0", Offset = "0x32C09E0", VA = "0x1832C1FE0")]
	private void KBKEHFLBCLA(HJPFCJGKJPC EOJBPKALALP, bool MENJEIPMLFN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x32C1770", Offset = "0x32C0170", VA = "0x1832C1770")]
	private void HEGDJKAIPBP(HJPFCJGKJPC EOJBPKALALP, TNode EBIGGMLCEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x32C2170", Offset = "0x32C0B70", VA = "0x1832C2170")]
	[IteratorStateMachine(typeof(global::OEFJLGMAFKB<, >.KIFJGMDMLML))]
	private IEnumerable<TNode> MOMPKGECPDH(TNode AKNMMMMELFH, TNode EGGHGELDMAI, bool MOLGOHNOGOA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x32C2400", Offset = "0x32C0E00", VA = "0x1832C2400")]
	private HJPFCJGKJPC OKANIOOALDF(TNode ELOCLFMIMAL, TNode LFAIGCEGCPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x32C1280", Offset = "0x32BFC80", VA = "0x1832C1280")]
	private HJPFCJGKJPC DJIGDJJGHPI(TNode ELOCLFMIMAL, TNode LFAIGCEGCPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x32C2240", Offset = "0x32C0C40", VA = "0x1832C2240")]
	private void NNCONMAHDDI(HJPFCJGKJPC EOJBPKALALP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class NGIJOHKPMMH<T> : IEnumerable<global::NGIJOHKPMMH<T>.JCGAALIHFEC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public struct JCGAALIHFEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public T MAKFNMHIJIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int EBBLFLFCHFB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class MLGBKNNBLID : IEnumerator<JCGAALIHFEC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private global::NGIJOHKPMMH<T> BLDLHAOGGDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private int EBBLFLFCHFB;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x14A84B0", Offset = "0x14A6EB0", VA = "0x1814A84B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public JCGAALIHFEC BMLOECHOMBO
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x2EACEF0", Offset = "0x2EAB8F0", VA = "0x182EACEF0", Slot = "4")]
			get
			{
				return default(JCGAALIHFEC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x67B060", Offset = "0x679A60", VA = "0x18067B060")]
		public MLGBKNNBLID(global::NGIJOHKPMMH<T> BLDLHAOGGDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x2EACE70", Offset = "0x2EAB870", VA = "0x182EACE70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x67B050", Offset = "0x679A50", VA = "0x18067B050", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x89DBC0", Offset = "0x89C5C0", VA = "0x18089DBC0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private struct PEENKKNHMEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public bool CHPNAFPCAOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public T MAKFNMHIJIF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private const int KHAPGHOAKPP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Dictionary<T, int> GNBJOKGMJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private PEENKKNHMEA[] NCNBGMINPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int MEALCPBMEIH;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int IJCOOGMKPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x697D90", Offset = "0x696790", VA = "0x180697D90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x849EB0", Offset = "0x8488B0", VA = "0x180849EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7930", Offset = "0x1FE6330", VA = "0x181FE7930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2C153F0", Offset = "0x2C13DF0", VA = "0x182C153F0")]
	public NGIJOHKPMMH(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2C158D0", Offset = "0x2C142D0", VA = "0x182C158D0")]
	public NGIJOHKPMMH(JCGAALIHFEC[] HJKDLBPJPBF, bool BCIAEBEODEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2C14F60", Offset = "0x2C13960", VA = "0x182C14F60")]
	public int KHNELHCEHCN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2C14230", Offset = "0x2C12C30", VA = "0x182C14230")]
	private int DPKIEIPLOAG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2C14750", Offset = "0x2C13150", VA = "0x182C14750", Slot = "6")]
	protected virtual uint EKEMOIMKPIB(uint ECCMGNHBKIL, T MAKFNMHIJIF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2C14430", Offset = "0x2C12E30", VA = "0x182C14430")]
	public bool ECFOPOGDNHI(T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2C13FF0", Offset = "0x2C129F0", VA = "0x182C13FF0")]
	public bool BCFBEIKJAEM(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2C14D20", Offset = "0x2C13720", VA = "0x182C14D20")]
	public bool HEBLGIOGKGC(Func<T, bool> LBGOBMKAOKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x2C15020", Offset = "0x2C13A20", VA = "0x182C15020")]
	public int LBOLLNKDDHK(T MAKFNMHIJIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2C14F00", Offset = "0x2C13900", VA = "0x182C14F00")]
	public T IHBCBCAIMIC(int EBBLFLFCHFB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2C152F0", Offset = "0x2C13CF0", VA = "0x182C152F0")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x2C14AB0", Offset = "0x2C134B0", VA = "0x182C14AB0")]
	public bool FKGKAEHMBPL(T MAKFNMHIJIF, bool EOAICLNBGGE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2C14AF0", Offset = "0x2C134F0", VA = "0x182C14AF0")]
	public bool FKGKAEHMBPL(T MAKFNMHIJIF, int EBBLFLFCHFB, bool EOAICLNBGGE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2C147A0", Offset = "0x2C131A0", VA = "0x182C147A0")]
	public bool EMIFMEAGDDE(T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2C13F50", Offset = "0x2C12950", VA = "0x182C13F50")]
	public bool APBNDDFINKH(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2C15080", Offset = "0x2C13A80", VA = "0x182C15080")]
	private void LCFIBBDBNFE(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2C14610", Offset = "0x2C13010", VA = "0x182C14610")]
	public JCGAALIHFEC[] EGJGLNFOKNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2C152A0", Offset = "0x2C13CA0", VA = "0x182C152A0")]
	private int NHFDCMNKNKJ(int LGAFDCAKAMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2C15370", Offset = "0x2C13D70", VA = "0x182C15370", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2C15370", Offset = "0x2C13D70", VA = "0x182C15370", Slot = "4")]
	private IEnumerator<JCGAALIHFEC> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct ANKGGOGGJGH<Handle> where Handle : LDGEBNEMAMI, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct JLLOHMJAHNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly global::ANKGGOGGJGH<Handle> NACBNKAHJFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private int EBBLFLFCHFB;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int JGLGMMFMOOM
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x3317230", Offset = "0x3315C30", VA = "0x183317230")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle GFEBJBJDFMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x3316D90", Offset = "0x3315790", VA = "0x183316D90")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x3317430", Offset = "0x3315E30", VA = "0x183317430")]
		public JLLOHMJAHNH(global::ANKGGOGGJGH<Handle> NACBNKAHJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x3316F90", Offset = "0x3315990", VA = "0x183316F90")]
		public JDMIPIODAMK OJKIKDBCCPC(in JDMIPIODAMK IBHBGBEBHJM)
		{
			return default(JDMIPIODAMK);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x3316EF0", Offset = "0x33158F0", VA = "0x183316EF0")]
		public AEIHIGMIJCC OJKIKDBCCPC(in AEIHIGMIJCC IBHBGBEBHJM)
		{
			return default(AEIHIGMIJCC);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x33164F0", Offset = "0x3314EF0", VA = "0x1833164F0")]
		public bool CKMCKKHDBJB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x3316450", Offset = "0x3314E50", VA = "0x183316450")]
		private int BOOPGCLKGFA(string DIDMFBHHIEC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x3316310", Offset = "0x3314D10", VA = "0x183316310")]
		private Handle BIBOFHAJPNJ(string DIDMFBHHIEC)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public struct JDMIPIODAMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private JLLOHMJAHNH EAJFEOBJLFK;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int BMLOECHOMBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x31A2FA0", Offset = "0x31A19A0", VA = "0x1831A2FA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x31A30A0", Offset = "0x31A1AA0", VA = "0x1831A30A0")]
		public JDMIPIODAMK(global::ANKGGOGGJGH<Handle> NACBNKAHJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x31A2EA0", Offset = "0x31A18A0", VA = "0x1831A2EA0")]
		public bool CKMCKKHDBJB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x31A2E20", Offset = "0x31A1820", VA = "0x1831A2E20")]
		public JDMIPIODAMK CBILBBMABKJ()
		{
			return default(JDMIPIODAMK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct AEIHIGMIJCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private JLLOHMJAHNH EAJFEOBJLFK;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle BMLOECHOMBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x322BF50", Offset = "0x322A950", VA = "0x18322BF50")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x31A30A0", Offset = "0x31A1AA0", VA = "0x1831A30A0")]
		public AEIHIGMIJCC(global::ANKGGOGGJGH<Handle> NACBNKAHJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x31A2EA0", Offset = "0x31A18A0", VA = "0x1831A2EA0")]
		public bool CKMCKKHDBJB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x322BE90", Offset = "0x322A890", VA = "0x18322BE90")]
		public AEIHIGMIJCC CBILBBMABKJ()
		{
			return default(AEIHIGMIJCC);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private NativeList<int> LGEBBBGKPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private NativeList<int> NBJFLMGGGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private int JDBPMMOLOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private int EINDBCNPEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private bool NHFDDGKOOMD;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool CAJAMKMLDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x767F80", Offset = "0x766980", VA = "0x180767F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int KMFAFOCNGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x382AA20", Offset = "0x3829420", VA = "0x18382AA20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int KIKMIHMFFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x677010", Offset = "0x675A10", VA = "0x180677010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int PACLCIBBJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x677010", Offset = "0x675A10", VA = "0x180677010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public JDMIPIODAMK HEOEFKAKLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x3827920", Offset = "0x3826320", VA = "0x183827920")]
		get
		{
			return default(JDMIPIODAMK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public AEIHIGMIJCC NLDGMAPEKAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x382B8C0", Offset = "0x382A2C0", VA = "0x18382B8C0")]
		get
		{
			return default(AEIHIGMIJCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x382C020", Offset = "0x382AA20", VA = "0x18382C020")]
	public ANKGGOGGJGH(int PLJBLNIOMOD, Allocator GGLOKAHPEPM = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3827C00", Offset = "0x3826600", VA = "0x183827C00")]
	public void BOHBKACNFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x12E9F00", Offset = "0x12E8900", VA = "0x1812E9F00")]
	public static int JAFIBKELMNB(int HIGLPPEBKMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x382A2D0", Offset = "0x3828CD0", VA = "0x18382A2D0")]
	public static bool JBMCKHGPAOG(int HIGLPPEBKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3829690", Offset = "0x3828090", VA = "0x183829690")]
	public static bool IMEABOMMBBB(int HIGLPPEBKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x382B440", Offset = "0x3829E40", VA = "0x18382B440")]
	public bool OEEHHDLPCKK(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x382B960", Offset = "0x382A360", VA = "0x18382B960")]
	public bool OMDBJOFJKNF(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x3828680", Offset = "0x3827080", VA = "0x183828680")]
	public bool FOKHJJDOFFH(Handle ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x3828A50", Offset = "0x3827450", VA = "0x183828A50")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void HHOHMINLNPM(Handle ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x3828130", Offset = "0x3826B30", VA = "0x183828130")]
	public Handle EJCNOCAMALL()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x3829CD0", Offset = "0x38286D0", VA = "0x183829CD0")]
	public void IODDGDFPLFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x382AF60", Offset = "0x3829960", VA = "0x18382AF60")]
	public void NHCNMOFPIOH(Handle ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x3828790", Offset = "0x3827190", VA = "0x183828790")]
	public bool FPNGMEIBKBN(Handle ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x767F80", Offset = "0x766980", VA = "0x180767F80")]
	private bool KNHGNLCGJBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x382A2E0", Offset = "0x3828CE0", VA = "0x18382A2E0")]
	private bool JKNPGANNAME(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x382A5D0", Offset = "0x3828FD0", VA = "0x18382A5D0")]
	private void JPMALOLHGBO(out int EBBLFLFCHFB, out int AJGHIJIKOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x382B240", Offset = "0x3829C40", VA = "0x18382B240")]
	private void NPHDHDNIOGO(Handle ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x3827EF0", Offset = "0x38268F0", VA = "0x183827EF0")]
	private void DGIPPHFJIDE(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x382AD30", Offset = "0x3829730", VA = "0x18382AD30")]
	private bool MJELFMPEKHP(out int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x3827CC0", Offset = "0x38266C0", VA = "0x183827CC0")]
	private static Handle DDJJGJBCIJO(int EBBLFLFCHFB, int AJGHIJIKOBE)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[DefaultMember("Item")]
public struct BGFDJNFLFAN<Handle, T> where Handle : LDGEBNEMAMI, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private global::ANKGGOGGJGH<Handle> PHOHJFJGNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private T[] JJLOBPPKGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private Action<T> KFONKFCCOOB;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool CAJAMKMLDEK
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x341F700", Offset = "0x341E100", VA = "0x18341F700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int KMFAFOCNGGD
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x341E600", Offset = "0x341D000", VA = "0x18341E600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x341F6D0", Offset = "0x341E0D0", VA = "0x18341F6D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x341E490", Offset = "0x341CE90", VA = "0x18341E490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x341FB00", Offset = "0x341E500", VA = "0x18341FB00")]
	public BGFDJNFLFAN(int PLJBLNIOMOD, [Optional] Action<T> KFONKFCCOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x341C910", Offset = "0x341B310", VA = "0x18341C910")]
	public void BOHBKACNFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x341E440", Offset = "0x341CE40", VA = "0x18341E440")]
	public bool FOKHJJDOFFH(Handle ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void HHOHMINLNPM(Handle ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x341D460", Offset = "0x341BE60", VA = "0x18341D460")]
	public T DNJGGIFCOKL(Handle ODMNDKFKJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x341D170", Offset = "0x341BB70", VA = "0x18341D170")]
	public bool DJEIEOEOGPA(Handle ODMNDKFKJHN, out T LGKNNMGLNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x341EEC0", Offset = "0x341D8C0", VA = "0x18341EEC0")]
	public void KMNEKDAGPNL(Handle ODMNDKFKJHN, T MBCDHJMNIAB, out T EMJDPHLDGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x341EF60", Offset = "0x341D960", VA = "0x18341EF60")]
	public void KMNEKDAGPNL(Handle ODMNDKFKJHN, T MBCDHJMNIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x341DF70", Offset = "0x341C970", VA = "0x18341DF70")]
	public bool FFFKFHDEEJJ(Handle ODMNDKFKJHN, T MBCDHJMNIAB, out T EMJDPHLDGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x341E150", Offset = "0x341CB50", VA = "0x18341E150")]
	public bool FFFKFHDEEJJ(Handle ODMNDKFKJHN, T MBCDHJMNIAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x341F2A0", Offset = "0x341DCA0", VA = "0x18341F2A0")]
	public Handle MFMCNFFMIAP(T LGKNNMGLNIA)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x341EA60", Offset = "0x341D460", VA = "0x18341EA60")]
	public void KCBMKPEBDJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x341D970", Offset = "0x341C370", VA = "0x18341D970")]
	public void EMIFMEAGDDE(Handle ODMNDKFKJHN, out T EMJDPHLDGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x341DB10", Offset = "0x341C510", VA = "0x18341DB10")]
	public void EMIFMEAGDDE(Handle ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x341CBF0", Offset = "0x341B5F0", VA = "0x18341CBF0")]
	public bool CPPINAJNHMI(Handle ODMNDKFKJHN, out T EMJDPHLDGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x341CDF0", Offset = "0x341B7F0", VA = "0x18341CDF0")]
	public bool CPPINAJNHMI(Handle ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x341C790", Offset = "0x341B190", VA = "0x18341C790")]
	private T APBNDDFINKH(int EBBLFLFCHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x341F730", Offset = "0x341E130", VA = "0x18341F730")]
	private void OLOLAGONDMO(int HFEDBJBGGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class OHEBPJCKCKG<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Stack<T> NACBNKAHJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<T> ECLCDNHNFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly int LNMFHOCNGJJ;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int CMJFEJIDEEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x1E25F60", Offset = "0x1E24960", VA = "0x181E25F60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int MCFEBJJFOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x24CF730", Offset = "0x24CE130", VA = "0x1824CF730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x32C71B0", Offset = "0x32C5BB0", VA = "0x1832C71B0")]
	public static global::OHEBPJCKCKG<T> BEKHMELEDAB(int FHGNFGIEADL = 0, int LNMFHOCNGJJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x32C77E0", Offset = "0x32C61E0", VA = "0x1832C77E0")]
	public static global::OHEBPJCKCKG<T> LLJDFNMKOIC(int FHGNFGIEADL = 0, int LNMFHOCNGJJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x32C7980", Offset = "0x32C6380", VA = "0x1832C7980")]
	public OHEBPJCKCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x32C79C0", Offset = "0x32C63C0", VA = "0x1832C79C0")]
	public OHEBPJCKCKG(int FHGNFGIEADL, int LNMFHOCNGJJ = int.MaxValue, bool OMPNOHHJNEG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x32C7280", Offset = "0x32C5C80", VA = "0x1832C7280")]
	public T DLOPPNFOCOA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x32C7510", Offset = "0x32C5F10", VA = "0x1832C7510")]
	public void ENCBMHFAOCP(T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x32C78B0", Offset = "0x32C62B0", VA = "0x1832C78B0")]
	private void OMIJDNEBJGM(T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x32C7190", Offset = "0x32C5B90", VA = "0x1832C7190")]
	private void BEBFIBFIPPD(T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x32C75C0", Offset = "0x32C5FC0", VA = "0x1832C75C0")]
	[Conditional("DEBUG_BUILD")]
	private void HJPACKAPJHN(T JPIDECFHPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x32C7480", Offset = "0x32C5E80", VA = "0x1832C7480")]
	[Conditional("DEBUG_BUILD")]
	private void ELKDFJJGKHC(T JPIDECFHPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x32C7390", Offset = "0x32C5D90", VA = "0x1832C7390", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x32C7640", Offset = "0x32C6040", VA = "0x1832C7640")]
	private void IAACAJCBOKL(IEnumerable<T> ECINCKPHFMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class CDPBDJPINBH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private Dictionary<int, T> EFKHNCDCECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private T DNIKNLEBOPJ;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T ALAFJJADFBM
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x697140", Offset = "0x695B40", VA = "0x180697140", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool MMPPENFBFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x2F3CB50", Offset = "0x2F3B550", VA = "0x182F3CB50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x2F3CFB0", Offset = "0x2F3B9B0", VA = "0x182F3CFB0")]
	public bool OGKJCDPEKGH(T MAKFNMHIJIF, int IPGJOMPJEJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2F3CAF0", Offset = "0x2F3B4F0", VA = "0x182F3CAF0")]
	public bool BJHOJHPKHGP(int IPGJOMPJEJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2F3CDC0", Offset = "0x2F3B7C0", VA = "0x182F3CDC0")]
	public T MLKPGDKPOJF(int FDDNEAODHIB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2F3D070", Offset = "0x2F3BA70", VA = "0x182F3D070")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2F3C950", Offset = "0x2F3B350", VA = "0x182F3C950")]
	private bool APJDPKMJMFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x2F3CB90", Offset = "0x2F3B590", VA = "0x182F3CB90")]
	public bool IDEDABPJLGL(int IPGJOMPJEJJ, out T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x2F3D0D0", Offset = "0x2F3BAD0", VA = "0x182F3D0D0")]
	public CDPBDJPINBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class MKBNJHDAACI<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	protected struct CEAAMHGCECH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public T OIHHNPGGOMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int JDIIMBFLEBI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	protected readonly List<CEAAMHGCECH> GCBELKIOIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private T HPPLIBCHCIM;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7930", Offset = "0x1FE6330", VA = "0x181FE7930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2EA91E0", Offset = "0x2EA7BE0", VA = "0x182EA91E0")]
	public bool HEBLGIOGKGC(T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2EA9460", Offset = "0x2EA7E60", VA = "0x182EA9460")]
	public void MFMCNFFMIAP(T MAKFNMHIJIF, int IPGJOMPJEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x2EA90C0", Offset = "0x2EA7AC0", VA = "0x182EA90C0")]
	public bool EMIFMEAGDDE(T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2EA96C0", Offset = "0x2EA80C0", VA = "0x182EA96C0")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x2EA93F0", Offset = "0x2EA7DF0", VA = "0x182EA93F0")]
	public T LPPJAHJFKKB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2EA9050", Offset = "0x2EA7A50", VA = "0x182EA9050")]
	public T EFOLMBHNDHM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2EA9500", Offset = "0x2EA7F00", VA = "0x182EA9500")]
	private void NCKEKOFMLJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2EA9720", Offset = "0x2EA8120", VA = "0x182EA9720")]
	public MKBNJHDAACI()
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
		[EICDDLDLOGE(BHMLOOPGMEN.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x5F71680", Offset = "0x5F70080", VA = "0x185F71680")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x5F71A10", Offset = "0x5F70410", VA = "0x185F71A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x5F71890", Offset = "0x5F70290", VA = "0x185F71890")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x5F71B70", Offset = "0x5F70570", VA = "0x185F71B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x5F715A0", Offset = "0x5F6FFA0", VA = "0x185F715A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x5F71930", Offset = "0x5F70330", VA = "0x185F71930")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x5F717B0", Offset = "0x5F701B0", VA = "0x185F717B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5F71550", Offset = "0x5F6FF50", VA = "0x185F71550")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface GDPMGICCCBK
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class ResourcePrefabReference<T> : GDPMGICCCBK where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x283F0F0", Offset = "0x283DAF0", VA = "0x18283F0F0", Slot = "4")]
		public virtual T LGJMCPOMIOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class PDPFLNOPKKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly Dictionary<byte, HNGACIELLJC> MHFFJFGEGOP;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public HNGACIELLJC HOMHDGNOPOC
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x697130", Offset = "0x695B30", VA = "0x180697130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 PHODGNBGFDM
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x2137F80", Offset = "0x2136980", VA = "0x182137F80")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x6C0CD0", Offset = "0x6BF6D0", VA = "0x1806C0CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 FNHNFLDJGAP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x1FD3F40", Offset = "0x1FD2940", VA = "0x181FD3F40")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x160DE10", Offset = "0x160C810", VA = "0x18160DE10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 LHLHNODKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x5F70B30", Offset = "0x5F6F530", VA = "0x185F70B30")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x12DA6B0", Offset = "0x12D90B0", VA = "0x1812DA6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int KPBOFPENJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x6770E0", Offset = "0x675AE0", VA = "0x1806770E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6DE640", Offset = "0x6DD040", VA = "0x1806DE640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F71050", Offset = "0x5F6FA50", VA = "0x185F71050")]
	public PDPFLNOPKKH(Bounds MKJEBMJBNGG, Vector2[] NAPEDCMJDNN, int LOCJNHPLLBM, byte LGAFDCAKAMG, float OBHHMOHGHDE = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5F70AB0", Offset = "0x5F6F4B0", VA = "0x185F70AB0")]
	public HNGACIELLJC CBICBFIDBKD(byte EBBLFLFCHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5F70F50", Offset = "0x5F6F950", VA = "0x185F70F50")]
	public void MFPBNIJEBND(Vector3 EINGNKDKDHC, float IMKCGPGMDMF, float IMALJJABLAD, ref List<byte> LKOKGPNCGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5F70B10", Offset = "0x5F6F510", VA = "0x185F70B10")]
	public void EHFEOKAOPHD(HNGACIELLJC.NDNACBCDLGI JDJOHDKLJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5F70950", Offset = "0x5F6F350", VA = "0x185F70950")]
	private HNGACIELLJC BANDPGBBIJP(byte EBBLFLFCHFB, HNGACIELLJC.NIPLOEGKMKP MMLILHDNNPP, HNGACIELLJC LFAIGCEGCPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5F70B50", Offset = "0x5F6F550", VA = "0x185F70B50")]
	private void KAMIBOIDDHF(HNGACIELLJC LFAIGCEGCPL, Vector2[] NAPEDCMJDNN, int EEADEAIPIAC, int KKNAIOMCLJN, int OMGCHCOJFJE, int MJICFKEGKBB, float OBHHMOHGHDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class HNGACIELLJC
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public enum NIPLOEGKMKP
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public enum NDNACBCDLGI
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
	public byte GOODPMCPKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public Vector3 ELLMFCGGHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector3 DAPJFJMMFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Vector3 GCLJJPMBEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public Vector3 NGLEGOLAPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public NIPLOEGKMKP PLLFCOIBIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public HNGACIELLJC HDIMMFJBNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public List<HNGACIELLJC> AHIMGHMDPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public bool IKMAAFLIJMA;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C860", Offset = "0x5F6B260", VA = "0x185F6C860")]
	public HNGACIELLJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C880", Offset = "0x5F6B280", VA = "0x185F6C880")]
	public HNGACIELLJC(byte CBBOJGIJLHN, NIPLOEGKMKP MMLILHDNNPP, HNGACIELLJC LFAIGCEGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C7A0", Offset = "0x5F6B1A0", VA = "0x185F6C7A0")]
	public void OPJJCFHECII(HNGACIELLJC IMDKOHMGEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	public void EHFEOKAOPHD(int GONGBLMKLJK, NDNACBCDLGI JDJOHDKLJNM, int JDGEMNDPNNE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C4F0", Offset = "0x5F6AEF0", VA = "0x185F6C4F0")]
	public void MFPBNIJEBND(List<byte> LKOKGPNCGAJ, Vector3 EINGNKDKDHC, float IMKCGPGMDMF, float IMALJJABLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C460", Offset = "0x5F6AE60", VA = "0x185F6C460")]
	public bool ANGAJPCJIFO(Vector3 IGAJPNPGFIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C4B0", Offset = "0x5F6AEB0", VA = "0x185F6C4B0")]
	public bool HMDLBIDOGIH(Vector3 IGAJPNPGFIA, float HKLKHPMOALF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class BGBAENJABAB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly Dictionary<T, object> GKPHJBKLHIH;

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x1E26660", Offset = "0x1E25060", VA = "0x181E26660")]
	public bool EBNIBDHMIKC(T FFLGINHJFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x45C7F70", Offset = "0x45C6970", VA = "0x1845C7F70")]
	public bool EBNIBDHMIKC(T FFLGINHJFHB, object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x45C7FB0", Offset = "0x45C69B0", VA = "0x1845C7FB0")]
	public bool EBNIBDHMIKC(T FFLGINHJFHB, object HKLDIENGNNB, out object EAJBBDKNLHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x45C8110", Offset = "0x45C6B10", VA = "0x1845C8110")]
	public bool JNEANDEICAG(T FFLGINHJFHB, object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x45C8040", Offset = "0x45C6A40", VA = "0x1845C8040")]
	public bool FPCBCAODKIJ(T FFLGINHJFHB, object HKLDIENGNNB, out object EAJBBDKNLHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x45C8080", Offset = "0x45C6A80", VA = "0x1845C8080")]
	public bool JNEANDEICAG(T FFLGINHJFHB, object HKLDIENGNNB, out object EAJBBDKNLHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x45C8010", Offset = "0x45C6A10", VA = "0x1845C8010")]
	public void EFLNHNAEDNM(T FFLGINHJFHB, object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x45C8150", Offset = "0x45C6B50", VA = "0x1845C8150")]
	public void ODJFOAJGBMP(T FFLGINHJFHB, object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x45C81F0", Offset = "0x45C6BF0", VA = "0x1845C81F0")]
	public BGBAENJABAB()
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
		public struct FKAMGCPNDKL<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			private readonly List<Component> ACLENHAHHHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private readonly bool FKLPHALDEMJ;

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x8D7970", Offset = "0x8D6370", VA = "0x1808D7970")]
			public FKAMGCPNDKL(List<Component> ACLENHAHHHH, bool FKLPHALDEMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x31E5A70", Offset = "0x31E4470", VA = "0x1831E5A70")]
			public ONIPLJHFHPL<T> CBILBBMABKJ()
			{
				return default(ONIPLJHFHPL<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x31E5AE0", Offset = "0x31E44E0", VA = "0x1831E5AE0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x31E5AE0", Offset = "0x31E44E0", VA = "0x1831E5AE0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		public struct ONIPLJHFHPL<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private readonly List<Component> ACLENHAHHHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private readonly bool FKLPHALDEMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private int EBBLFLFCHFB;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T BMLOECHOMBO
			{
				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x3B2E120", Offset = "0x3B2CB20", VA = "0x183B2E120", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0x3B2E0B0", Offset = "0x3B2CAB0", VA = "0x183B2E0B0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x3B2E0F0", Offset = "0x3B2CAF0", VA = "0x183B2E0F0")]
			public ONIPLJHFHPL(List<Component> ACLENHAHHHH, bool FKLPHALDEMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x3B2DFF0", Offset = "0x3B2C9F0", VA = "0x183B2DFF0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x3B2E000", Offset = "0x3B2CA00", VA = "0x183B2E000", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x2F80C00", Offset = "0x2F7F600", VA = "0x182F80C00", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x5F738C0", Offset = "0x5F722C0", VA = "0x185F738C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5F73880", Offset = "0x5F72280", VA = "0x185F73880")]
		public ToolHierarchyCache(GameObject POFNLMLLLOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5F73610", Offset = "0x5F72010", VA = "0x185F73610")]
		private void OIEJOMHJJDA(GameObject POFNLMLLLOA, bool CBEIFKNKIIE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5F73770", Offset = "0x5F72170", VA = "0x185F73770")]
		public static void OIEJOMHJJDA(GameObject POFNLMLLLOA, ref ToolHierarchyCache ODMPDKFLOEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5F730B0", Offset = "0x5F71AB0", VA = "0x185F730B0")]
		public void BMOEIMDFFHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x5F730C0", Offset = "0x5F71AC0", VA = "0x185F730C0")]
		public void BPOMIGMEPDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x34A67E0", Offset = "0x34A51E0", VA = "0x1834A67E0")]
		public void IMLEINFLFAA<T>(Action<T> PBOHOIMMGFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x5F73110", Offset = "0x5F71B10", VA = "0x185F73110")]
		public Component DJCMNOAAJEN(Type MCLMFJEAHEC, bool FKLPHALDEMJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x34A6760", Offset = "0x34A5160", VA = "0x1834A6760")]
		public T DJCMNOAAJEN<T>(bool FKLPHALDEMJ = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x5F73030", Offset = "0x5F71A30", VA = "0x185F73030")]
		public FKAMGCPNDKL<Component> AINJNNGJLHE(Type MCLMFJEAHEC, bool FKLPHALDEMJ = false)
		{
			return default(FKAMGCPNDKL<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x34A6690", Offset = "0x34A5090", VA = "0x1834A6690")]
		public FKAMGCPNDKL<T> AINJNNGJLHE<T>(bool FKLPHALDEMJ = false) where T : class
		{
			return default(FKAMGCPNDKL<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x5F732E0", Offset = "0x5F71CE0", VA = "0x185F732E0")]
		public List<Component> NECEEIJHBOA(Type MCLMFJEAHEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x5F731E0", Offset = "0x5F71BE0", VA = "0x185F731E0", Slot = "4")]
		public bool Equals(ToolHierarchyCache FBHIPILAOBE, ToolHierarchyCache DPKHPCDGHJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x5F73260", Offset = "0x5F71C60", VA = "0x185F73260", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache LGKNNMGLNIA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public class HGOBKIGLAMO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private int FHGNFGIEADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private int MBKNLELIAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private List<T> EPKPHBHDHGH;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x1E25F60", Offset = "0x1E24960", VA = "0x181E25F60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T MJCEALLDFPC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B090", Offset = "0x3F29A90", VA = "0x183F2B090")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T MCBKGMLNLLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x3F2AFB0", Offset = "0x3F299B0", VA = "0x183F2AFB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T KLAFOCHJOAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x3F2AC60", Offset = "0x3F29660", VA = "0x183F2AC60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x3F2B160", Offset = "0x3F29B60", VA = "0x183F2B160")]
	public HGOBKIGLAMO(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x3F2AE90", Offset = "0x3F29890", VA = "0x183F2AE90")]
	public void MFMCNFFMIAP(T AHNJHFGNBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x3F2B120", Offset = "0x3F29B20", VA = "0x183F2B120")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x3F2AD20", Offset = "0x3F29720", VA = "0x183F2AD20")]
	public void GBCNHKFADAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x3F2ACD0", Offset = "0x3F296D0", VA = "0x183F2ACD0")]
	public void DDEPFNIOABP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x3F2ACC0", Offset = "0x3F296C0", VA = "0x183F2ACC0")]
	public void BMMHPGDCJFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class PJLHCNAOPNF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private bool MAJOBBGOMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private Action PBOHOIMMGFG;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static PJLHCNAOPNF GPPONFMPFBH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5F714D0", Offset = "0x5F6FED0", VA = "0x185F714D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool DIIJOOGAEKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x67B250", Offset = "0x679C50", VA = "0x18067B250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x82C810", Offset = "0x82B210", VA = "0x18082C810")]
	public PJLHCNAOPNF(Action PBOHOIMMGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5F714B0", Offset = "0x5F6FEB0", VA = "0x185F714B0")]
	public void ADFDICGOODJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5F714B0", Offset = "0x5F6FEB0", VA = "0x185F714B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class ALFFBNHEIBH
{
	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A0E0", Offset = "0x5F68AE0", VA = "0x185F6A0E0")]
	public static void AHLDDFDMEGK(ADNKCEEOLDO CHCEKBPDNGP, string NGFODIDHBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	public static void AHLDDFDMEGK(IEnumerable<object> JDMFCLOEMNK, string NGFODIDHBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class CMLGHMPCLLF<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private struct GGPFADGFLMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public int JDIIMBFLEBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public T OIHHNPGGOMC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly Dictionary<object, GGPFADGFLMB> EFKHNCDCECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly EqualityComparer<T> LLPJMAKBKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private T DNIKNLEBOPJ;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T ALAFJJADFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xC97010", Offset = "0xC95A10", VA = "0x180C97010", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x22C5380", Offset = "0x22C3D80", VA = "0x1822C5380", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool MMPPENFBFJA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x28AC180", Offset = "0x28AAB80", VA = "0x1828AC180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object KBIPJOFDDHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C0F0", VA = "0x18068D6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x70FAE0", Offset = "0x70E4E0", VA = "0x18070FAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x28AC680", Offset = "0x28AB080", VA = "0x1828AC680")]
	public bool OGKJCDPEKGH(T MAKFNMHIJIF, object HKLDIENGNNB, int IPGJOMPJEJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x28AC100", Offset = "0x28AAB00", VA = "0x1828AC100")]
	public bool BJHOJHPKHGP(object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x28AC340", Offset = "0x28AAD40", VA = "0x1828AC340")]
	public bool IDEDABPJLGL(object HKLDIENGNNB, out T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x264E6F0", Offset = "0x264D0F0", VA = "0x18264E6F0")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x28AA510", Offset = "0x28A8F10", VA = "0x1828AA510")]
	private bool APJDPKMJMFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x28AC980", Offset = "0x28AB380", VA = "0x1828AC980")]
	public CMLGHMPCLLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class HJLOCAOOABO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private Dictionary<object, float> EFKHNCDCECP;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float BEEEJDACBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x10A3330", Offset = "0x10A1D30", VA = "0x1810A3330")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xEC82C0", Offset = "0xEC6CC0", VA = "0x180EC82C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C250", Offset = "0x5F6AC50", VA = "0x185F6C250")]
	public void OGKJCDPEKGH(float MAKFNMHIJIF, object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C1E0", Offset = "0x5F6ABE0", VA = "0x185F6C1E0")]
	public void BJHOJHPKHGP(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C2C0", Offset = "0x5F6ACC0", VA = "0x185F6C2C0")]
	private void OJFICGNHNPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C3E0", Offset = "0x5F6ADE0", VA = "0x185F6C3E0")]
	public HJLOCAOOABO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class MFNIHNNDJBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public readonly string IKBCOHNJIAG;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676940", VA = "0x180677F40")]
	public MFNIHNNDJBP(string PGBLILALBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x5F6F980", Offset = "0x5F6E380", VA = "0x185F6F980")]
	public MFNIHNNDJBP(UnityEngine.Object GCLKAELNFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x5F6F930", Offset = "0x5F6E330", VA = "0x185F6F930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class ADNKCEEOLDO
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class GHMGPDKPAAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public GHMGPDKPAAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x5F6C0C0", Offset = "0x5F6AAC0", VA = "0x185F6C0C0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private HashSet<object> JDMFCLOEMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private int LJOLPACMCAL;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> JCMEBGAMNHL
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x5F69BE0", Offset = "0x5F685E0", VA = "0x185F69BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool JBJJGGGFHBP
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x5F69F10", Offset = "0x5F68910", VA = "0x185F69F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x678BD0", Offset = "0x6775D0", VA = "0x180678BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5F69E20", Offset = "0x5F68820", VA = "0x185F69E20")]
	public bool MFMCNFFMIAP(object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5F69CB0", Offset = "0x5F686B0", VA = "0x185F69CB0")]
	public bool EMIFMEAGDDE(object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5F69DC0", Offset = "0x5F687C0", VA = "0x185F69DC0")]
	public bool HEBLGIOGKGC(object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5F69D50", Offset = "0x5F68750", VA = "0x185F69D50")]
	public void FMCFPECHEBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5F69F20", Offset = "0x5F68920", VA = "0x185F69F20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public ADNKCEEOLDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class MKJFLENGDLA<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private struct JMAICAPICJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public float LLCKOAKEFIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public T OIHHNPGGOMC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private Dictionary<object, JMAICAPICJB> EFKHNCDCECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private T DGCJGGEAJBF;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T NEAGIMCOEDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x11AC440", Offset = "0x11AAE40", VA = "0x1811AC440", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x16A4480", Offset = "0x16A2E80", VA = "0x1816A4480", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object CBEKBLNIJEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x70FAE0", Offset = "0x70E4E0", VA = "0x18070FAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool MMPPENFBFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x2EAAEB0", Offset = "0x2EA98B0", VA = "0x182EAAEB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x2EAB470", Offset = "0x2EA9E70", VA = "0x182EAB470")]
	public bool OGKJCDPEKGH(T MAKFNMHIJIF, object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x2EAAE50", Offset = "0x2EA9850", VA = "0x182EAAE50")]
	public bool BJHOJHPKHGP(object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x264E6F0", Offset = "0x264D0F0", VA = "0x18264E6F0")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x2EAAEF0", Offset = "0x2EA98F0", VA = "0x182EAAEF0")]
	public bool IDEDABPJLGL(object HKLDIENGNNB, out T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x2EAA4A0", Offset = "0x2EA8EA0", VA = "0x182EAA4A0")]
	private bool APJDPKMJMFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x2EAB730", Offset = "0x2EAA130", VA = "0x182EAB730")]
	public MKJFLENGDLA()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class MDBMMECDLKK
{
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static byte[] GADOFMLHAHJ;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static int HEJKOBPMNOJ;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static int HLKLMDMLFLE;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static BigInteger DBAKCFGFCLA;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public MDBMMECDLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E4E0", Offset = "0x5F6CEE0", VA = "0x185F6E4E0")]
	private static string LLKJKMBGMPE(byte[] LKLEFAIICIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E190", Offset = "0x5F6CB90", VA = "0x185F6E190")]
	public static string FCKPDHOJNPG(byte[] PPJLGCLGPJE, bool KMFFDGBHCMI)
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
