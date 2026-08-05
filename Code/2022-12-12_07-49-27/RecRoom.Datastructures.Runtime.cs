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
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x728F30", Offset = "0x727530", VA = "0x180728F30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x70DB30", Offset = "0x70C130", VA = "0x18070DB30", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71E890", Offset = "0x71CE90", VA = "0x18071E890", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash ECCMGNHBKIL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7FADF0", Offset = "0x7F93F0", VA = "0x1807FADF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6026910", Offset = "0x6024F10", VA = "0x186026910")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60268D0", Offset = "0x6024ED0", VA = "0x1860268D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6026950", Offset = "0x6024F50", VA = "0x186026950")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6026B20", Offset = "0x6025120", VA = "0x186026B20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6026A90", Offset = "0x6025090", VA = "0x186026A90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9F86F0", Offset = "0x9F6CF0", VA = "0x1809F86F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA24840", Offset = "0xA22E40", VA = "0x180A24840")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6026890", Offset = "0x6024E90", VA = "0x186026890")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6026A00", Offset = "0x6025000", VA = "0x186026A00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60262D0", Offset = "0x60248D0", VA = "0x1860262D0")]
	public void CopyBounds(SavedExtents OANENNOJEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60267F0", Offset = "0x6024DF0", VA = "0x1860267F0")]
	public void SetLocalSpaceBounds(Bounds CBCMPHADIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xC2E0E0", Offset = "0xC2C6E0", VA = "0x180C2E0E0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x60267E0", Offset = "0x6024DE0", VA = "0x1860267E0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x60263C0", Offset = "0x60249C0", VA = "0x1860263C0")]
	private void KKFFDDHCNFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60265B0", Offset = "0x6024BB0", VA = "0x1860265B0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6025C90", Offset = "0x6024290", VA = "0x186025C90")]
	public static void CalculateLocalBoundsFor(GameObject EHEABJNEALG, out Bounds CBCMPHADIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6026300", Offset = "0x6024900", VA = "0x186026300")]
	private static void KEDKAOIPIHP(Bounds LKLEFAIICIC, Color KOIHHAIHBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6026810", Offset = "0x6024E10", VA = "0x186026810")]
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
		[Cpp2IlInjected.Address(RVA = "0x695660", Offset = "0x693C60", VA = "0x180695660")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x709AB0", Offset = "0x7080B0", VA = "0x180709AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xAF9D70", Offset = "0xAF8370", VA = "0x180AF9D70")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xBE5EC0", Offset = "0xBE44C0", VA = "0x180BE5EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "4")]
	public virtual void GJMHFJBPIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E356C0", Offset = "0x3E33CC0", VA = "0x183E356C0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3E34DF0", Offset = "0x3E333F0", VA = "0x183E34DF0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3E35C00", Offset = "0x3E34200", VA = "0x183E35C00")]
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
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public FNKAMAALPJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3E500F0", Offset = "0x3E4E6F0", VA = "0x183E500F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x229A990", Offset = "0x2298F90", VA = "0x18229A990", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x229A9C0", Offset = "0x2298FC0", VA = "0x18229A9C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x229A8E0", Offset = "0x2298EE0", VA = "0x18229A8E0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey AIGAKEKDKHM]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x229A910", Offset = "0x2298F10", VA = "0x18229A910", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x229A7E0", Offset = "0x2298DE0", VA = "0x18229A7E0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x229A160", Offset = "0x2298760", VA = "0x18229A160", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2299830", Offset = "0x2297E30", VA = "0x182299830", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2299800", Offset = "0x2297E00", VA = "0x182299800", Slot = "14")]
	protected virtual string OCHLEPBJFEA(TKeyVal FDMNPBFAPHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x22996E0", Offset = "0x2297CE0", VA = "0x1822996E0", Slot = "4")]
	public bool ContainsKey(TKey AIGAKEKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x229A6D0", Offset = "0x2298CD0", VA = "0x18229A6D0", Slot = "5")]
	public bool TryGetValue(TKey AIGAKEKDKHM, out TVal MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2299710", Offset = "0x2297D10", VA = "0x182299710", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2299710", Offset = "0x2297D10", VA = "0x182299710", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x229A700", Offset = "0x2298D00", VA = "0x18229A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public KEOAKPDBOEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x344E860", Offset = "0x344CE60", VA = "0x18344E860")]
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
		[Cpp2IlInjected.Address(RVA = "0x3AFEF40", Offset = "0x3AFD540", VA = "0x183AFEF40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3AFF370", Offset = "0x3AFD970", VA = "0x183AFF370")]
	public HFBCPJGMFKN(float GGEFAPICMLM, float OEMLCINMGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3AFF120", Offset = "0x3AFD720", VA = "0x183AFF120")]
	public bool OEALBGNMMEC(float BPPPFJGDDBP, T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3AFE7E0", Offset = "0x3AFCDE0", VA = "0x183AFE7E0")]
	public int GAEGEPBLNNL(float BPPPFJGDDBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3AFEB80", Offset = "0x3AFD180", VA = "0x183AFEB80")]
	public IEnumerable<T> KFLOPOPGMAI(float BPPPFJGDDBP, [Optional] float? FGPAGJNIFIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3AFF340", Offset = "0x3AFD940", VA = "0x183AFF340")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3AFF280", Offset = "0x3AFD880", VA = "0x183AFF280")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF95C0", Offset = "0xAF7BC0", VA = "0x180AF95C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xAF9650", Offset = "0xAF7C50", VA = "0x180AF9650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2790", Offset = "0x3EB0D90", VA = "0x183EB2790")]
	public OJAMPJHFPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3EB27C0", Offset = "0x3EB0DC0", VA = "0x183EB27C0")]
	public OJAMPJHFPBK(int JLMAIAGOBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3EB1D60", Offset = "0x3EB0360", VA = "0x183EB1D60")]
	public void MFMCNFFMIAP(float BPPPFJGDDBP, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2350", Offset = "0x3EB0950", VA = "0x183EB2350")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3EB16E0", Offset = "0x3EAFCE0", VA = "0x183EB16E0")]
	public bool FKCCLBNFDGO(float LGMCDNJLHGA, float KICOLLELCAK, out T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3EB1A00", Offset = "0x3EB0000", VA = "0x183EB1A00")]
	public bool HDAKFHHKHOI(float LGMCDNJLHGA, float KICOLLELCAK, out T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2230", Offset = "0x3EB0830", VA = "0x183EB2230")]
	public void MGDOJNOLDGG(float LGMCDNJLHGA, float KICOLLELCAK, List<T> DICKNCEHGPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3EB12E0", Offset = "0x3EAF8E0", VA = "0x183EB12E0")]
	private int FENGPILKLKH(int POCOCMDOEGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3EB1D20", Offset = "0x3EB0320", VA = "0x183EB1D20")]
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
	[Cpp2IlInjected.Address(RVA = "0xAA81A0", Offset = "0xAA67A0", VA = "0x180AA81A0", Slot = "4")]
	protected override Vector3 ECKGFNMGKOL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2C0B230", Offset = "0x2C09830", VA = "0x182C0B230", Slot = "5")]
	protected override Vector3 NECJNGDDOKK(Vector3 OLACFPEGPAG, Vector3 GLLCOOLKDAC, float KHJLEOILJMF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x60215E0", Offset = "0x601FBE0", VA = "0x1860215E0", Slot = "6")]
	protected override Vector3 GLCLEPEPGOE(Vector3 MAKFNMHIJIF, float KHJLEOILJMF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6021560", Offset = "0x601FB60", VA = "0x186021560", Slot = "7")]
	protected override Vector3 GLCEGHIOHGE(Vector3 OLACFPEGPAG, Vector3 GLLCOOLKDAC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6021640", Offset = "0x601FC40", VA = "0x186021640", Slot = "8")]
	protected override Vector3 IOJPOBGMBOD(Vector3 OLACFPEGPAG, Vector3 GLLCOOLKDAC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x60216B0", Offset = "0x601FCB0", VA = "0x1860216B0")]
	public JHAHODAHCAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MKPAGDABFKH : global::OJAMPJHFPBK<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6023B50", Offset = "0x6022150", VA = "0x186023B50")]
	public MKPAGDABFKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6023AE0", Offset = "0x60220E0", VA = "0x186023AE0")]
	public MKPAGDABFKH(int JLMAIAGOBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x9FB070", Offset = "0x9F9670", VA = "0x1809FB070", Slot = "4")]
	protected override float ECKGFNMGKOL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0xADA3C0", Offset = "0xAD89C0", VA = "0x180ADA3C0", Slot = "5")]
	protected override float NECJNGDDOKK(float OLACFPEGPAG, float GLLCOOLKDAC, float KHJLEOILJMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x175A450", Offset = "0x1758A50", VA = "0x18175A450", Slot = "6")]
	protected override float GLCLEPEPGOE(float MAKFNMHIJIF, float KHJLEOILJMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x311BBE0", Offset = "0x311A1E0", VA = "0x18311BBE0", Slot = "7")]
	protected override float GLCEGHIOHGE(float OLACFPEGPAG, float GLLCOOLKDAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6023AD0", Offset = "0x60220D0", VA = "0x186023AD0", Slot = "8")]
	protected override float IOJPOBGMBOD(float OLACFPEGPAG, float GLLCOOLKDAC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CBDOOBFOPFO
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x326A2C0", Offset = "0x32688C0", VA = "0x18326A2C0")]
	public static global::HMFNIHIIFBA<T1> CBFHJGEFJHE<T1>(T1 AHJFFIDLGPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3A6F240", Offset = "0x3A6D840", VA = "0x183A6F240")]
	public static global::GEFDKGMPAKE<T1, T2> CBFHJGEFJHE<T1, T2>(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3A6F2B0", Offset = "0x3A6D8B0", VA = "0x183A6F2B0")]
	public static global::ECKKONNAHCG<T1, T2, T3> CBFHJGEFJHE<T1, T2, T3>(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2A44710", Offset = "0x2A42D10", VA = "0x182A44710")]
	public static global::PHDINFOANPK<T1, T2, T3, T4> CBFHJGEFJHE<T1, T2, T3, T4>(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM, T4 KHPOJGAGIKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3A6F580", Offset = "0x3A6DB80", VA = "0x183A6F580")]
	public static global::OPPOOJLHLCE<T1, T2, T3, T4, T5> CBFHJGEFJHE<T1, T2, T3, T4, T5>(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM, T4 KHPOJGAGIKD, T5 AFABEFPKEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3A6F4D0", Offset = "0x3A6DAD0", VA = "0x183A6F4D0")]
	public static global::POOFPBPPPMG<T1, T2, T3, T4, T5, T6> CBFHJGEFJHE<T1, T2, T3, T4, T5, T6>(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM, T4 KHPOJGAGIKD, T5 AFABEFPKEEG, T6 NJPBMMPBPIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3A6F410", Offset = "0x3A6DA10", VA = "0x183A6F410")]
	public static global::LNGIMINACFN<T1, T2, T3, T4, T5, T6, T7> CBFHJGEFJHE<T1, T2, T3, T4, T5, T6, T7>(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM, T4 KHPOJGAGIKD, T5 AFABEFPKEEG, T6 NJPBMMPBPIF, T7 GHJLALOIFKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3A6F340", Offset = "0x3A6D940", VA = "0x183A6F340")]
	public static global::GFPILPNIEGL<T1, T2, T3, T4, T5, T6, T7, T8> CBFHJGEFJHE<T1, T2, T3, T4, T5, T6, T7, T8>(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM, T4 KHPOJGAGIKD, T5 AFABEFPKEEG, T6 NJPBMMPBPIF, T7 GHJLALOIFKC, T8 GHMECOEOKBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2515BD0", Offset = "0x25141D0", VA = "0x182515BD0")]
	[IteratorStateMachine(typeof(JGKIAJMPHMG))]
	public static IEnumerable<global::GEFDKGMPAKE<T1, T2>> LECKPNHPLFB<T1, T2>(IEnumerable<T1> IKAMJBDPPHG, IEnumerable<T2> LKLEFAIICIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2515DB0", Offset = "0x25143B0", VA = "0x182515DB0")]
	[IteratorStateMachine(typeof(AMIHPOLMDPI))]
	public static IEnumerable<global::ECKKONNAHCG<T1, T2, T3>> LECKPNHPLFB<T1, T2, T3>(IEnumerable<T1> IKAMJBDPPHG, IEnumerable<T2> LKLEFAIICIC, IEnumerable<T3> KOIHHAIHBKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xEB60A0", Offset = "0xEB46A0", VA = "0x180EB60A0")]
	internal static int JHFMCALLEIH(int NKIDJJCJGNM, int LHCICPFPJPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xEB6090", Offset = "0xEB4690", VA = "0x180EB6090")]
	internal static int JHFMCALLEIH(int NKIDJJCJGNM, int LHCICPFPJPL, int GKIDFCHIPEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xEB6070", Offset = "0xEB4670", VA = "0x180EB6070")]
	internal static int JHFMCALLEIH(int NKIDJJCJGNM, int LHCICPFPJPL, int GKIDFCHIPEB, int JFMBFICMNHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x601F3C0", Offset = "0x601D9C0", VA = "0x18601F3C0")]
	internal static int JHFMCALLEIH(int NKIDJJCJGNM, int LHCICPFPJPL, int GKIDFCHIPEB, int JFMBFICMNHH, int NCNMPAHJPBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x601F410", Offset = "0x601DA10", VA = "0x18601F410")]
	internal static int JHFMCALLEIH(int NKIDJJCJGNM, int LHCICPFPJPL, int GKIDFCHIPEB, int JFMBFICMNHH, int NCNMPAHJPBE, int OGPIBDFLKLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x601F3E0", Offset = "0x601D9E0", VA = "0x18601F3E0")]
	internal static int JHFMCALLEIH(int NKIDJJCJGNM, int LHCICPFPJPL, int GKIDFCHIPEB, int JFMBFICMNHH, int NCNMPAHJPBE, int OGPIBDFLKLL, int EIEAGALFJHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x601F390", Offset = "0x601D990", VA = "0x18601F390")]
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
	[Cpp2IlInjected.Address(RVA = "0x33487E0", Offset = "0x3346DE0", VA = "0x1833487E0")]
	public HMFNIHIIFBA(T1 AHJFFIDLGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x498A5A0", Offset = "0x4988BA0", VA = "0x18498A5A0", Slot = "4")]
	public int CompareTo(global::HMFNIHIIFBA<T1> OANENNOJEBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x498A610", Offset = "0x4988C10", VA = "0x18498A610", Slot = "0")]
	public override bool Equals(object OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x84FB60", Offset = "0x84E160", VA = "0x18084FB60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x498A6B0", Offset = "0x4988CB0", VA = "0x18498A6B0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x37CE9E0", Offset = "0x37CCFE0", VA = "0x1837CE9E0")]
	public GEFDKGMPAKE(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x37CC720", Offset = "0x37CAD20", VA = "0x1837CC720", Slot = "4")]
	public int CompareTo(global::GEFDKGMPAKE<T1, T2> OANENNOJEBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x37CCE70", Offset = "0x37CB470", VA = "0x1837CCE70", Slot = "0")]
	public override bool Equals(object OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x37CDAB0", Offset = "0x37CC0B0", VA = "0x1837CDAB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x37CE160", Offset = "0x37CC760", VA = "0x1837CE160", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x4123380", Offset = "0x4121980", VA = "0x184123380")]
	public ECKKONNAHCG(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4122B70", Offset = "0x4121170", VA = "0x184122B70", Slot = "4")]
	public int CompareTo(global::ECKKONNAHCG<T1, T2, T3> OANENNOJEBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4122D70", Offset = "0x4121370", VA = "0x184122D70", Slot = "0")]
	public override bool Equals(object OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4123060", Offset = "0x4121660", VA = "0x184123060", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x41231D0", Offset = "0x41217D0", VA = "0x1841231D0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D86D70", Offset = "0x3D85370", VA = "0x183D86D70")]
	public PHDINFOANPK(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM, T4 KHPOJGAGIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3D89C00", Offset = "0x3D88200", VA = "0x183D89C00", Slot = "4")]
	public int CompareTo(global::PHDINFOANPK<T1, T2, T3, T4> OANENNOJEBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3D89D40", Offset = "0x3D88340", VA = "0x183D89D40", Slot = "0")]
	public override bool Equals(object OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3D89E60", Offset = "0x3D88460", VA = "0x183D89E60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3D89F20", Offset = "0x3D88520", VA = "0x183D89F20", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3355230", Offset = "0x3353830", VA = "0x183355230")]
	public OPPOOJLHLCE(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM, T4 KHPOJGAGIKD, T5 AFABEFPKEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x442DA10", Offset = "0x442C010", VA = "0x18442DA10", Slot = "4")]
	public int CompareTo(global::OPPOOJLHLCE<T1, T2, T3, T4, T5> OANENNOJEBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x442DB90", Offset = "0x442C190", VA = "0x18442DB90", Slot = "0")]
	public override bool Equals(object OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x442DCD0", Offset = "0x442C2D0", VA = "0x18442DCD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x442DDD0", Offset = "0x442C3D0", VA = "0x18442DDD0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3354F20", Offset = "0x3353520", VA = "0x183354F20")]
	public POOFPBPPPMG(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM, T4 KHPOJGAGIKD, T5 AFABEFPKEEG, T6 NJPBMMPBPIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3354960", Offset = "0x3352F60", VA = "0x183354960", Slot = "4")]
	public int CompareTo(global::POOFPBPPPMG<T1, T2, T3, T4, T5, T6> OANENNOJEBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3354B20", Offset = "0x3353120", VA = "0x183354B20", Slot = "0")]
	public override bool Equals(object OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3354C90", Offset = "0x3353290", VA = "0x183354C90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3354DB0", Offset = "0x33533B0", VA = "0x183354DB0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3054EB0", Offset = "0x30534B0", VA = "0x183054EB0")]
	public LNGIMINACFN(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM, T4 KHPOJGAGIKD, T5 AFABEFPKEEG, T6 NJPBMMPBPIF, T7 GHJLALOIFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3054830", Offset = "0x3052E30", VA = "0x183054830", Slot = "4")]
	public int CompareTo(global::LNGIMINACFN<T1, T2, T3, T4, T5, T6, T7> OANENNOJEBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3054A30", Offset = "0x3053030", VA = "0x183054A30", Slot = "0")]
	public override bool Equals(object OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3054BD0", Offset = "0x30531D0", VA = "0x183054BD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3054D20", Offset = "0x3053320", VA = "0x183054D20", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x37D1120", Offset = "0x37CF720", VA = "0x1837D1120")]
	public GFPILPNIEGL(T1 AHJFFIDLGPI, T2 FOFHPAHMKFI, T3 MGBDCFNALCM, T4 KHPOJGAGIKD, T5 AFABEFPKEEG, T6 NJPBMMPBPIF, T7 GHJLALOIFKC, T8 GHMECOEOKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x37D09F0", Offset = "0x37CEFF0", VA = "0x1837D09F0", Slot = "4")]
	public int CompareTo(global::GFPILPNIEGL<T1, T2, T3, T4, T5, T6, T7, T8> OANENNOJEBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x37D0C40", Offset = "0x37CF240", VA = "0x1837D0C40", Slot = "0")]
	public override bool Equals(object OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x37D0E00", Offset = "0x37CF400", VA = "0x1837D0E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x37D0F70", Offset = "0x37CF570", VA = "0x1837D0F70", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x15AEDE0", Offset = "0x15AD3E0", VA = "0x1815AEDE0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x15AEE30", Offset = "0x15AD430", VA = "0x1815AEE30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float FLKCLBCGGNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x886E30", Offset = "0x885430", VA = "0x180886E30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4947980", Offset = "0x4945F80", VA = "0x184947980")]
	public T ONKOBHOOIKC(float KHJLEOILJMF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4947720", Offset = "0x4945D20", VA = "0x184947720")]
	public T BJOBKFAOPIH(float KHJLEOILJMF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T NECJNGDDOKK(T OLACFPEGPAG, T GLLCOOLKDAC, float KHJLEOILJMF);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0xADA3C0", Offset = "0xAD89C0", VA = "0x180ADA3C0", Slot = "4")]
	protected override float NECJNGDDOKK(float OLACFPEGPAG, float GLLCOOLKDAC, float KHJLEOILJMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x601FEE0", Offset = "0x601E4E0", VA = "0x18601FEE0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2C0B230", Offset = "0x2C09830", VA = "0x182C0B230", Slot = "4")]
	protected override Vector3 NECJNGDDOKK(Vector3 OLACFPEGPAG, Vector3 GLLCOOLKDAC, float KHJLEOILJMF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6027A10", Offset = "0x6026010", VA = "0x186027A10")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x601F430", Offset = "0x601DA30", VA = "0x18601F430", Slot = "4")]
	protected override Color NECJNGDDOKK(Color OLACFPEGPAG, Color GLLCOOLKDAC, float KHJLEOILJMF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x601F480", Offset = "0x601DA80", VA = "0x18601F480")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JGACENBDGLI : global::NGIJOHKPMMH<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6021510", Offset = "0x601FB10", VA = "0x186021510")]
	public JGACENBDGLI(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x60214B0", Offset = "0x601FAB0", VA = "0x1860214B0")]
	public JGACENBDGLI(JCGAALIHFEC[] HJKDLBPJPBF, bool BCIAEBEODEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6021440", Offset = "0x601FA40", VA = "0x186021440", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public EMBHEGLBNPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x601F5B0", Offset = "0x601DBB0", VA = "0x18601F5B0")]
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
	[Cpp2IlInjected.Address(RVA = "0xC25490", Offset = "0xC23A90", VA = "0x180C25490")]
	private ICPPHJLENFJ(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<ABCENELPPGI>> AGICIICLKFB, int DEMCEDMGDPL, int CAEOMKLPFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6020E40", Offset = "0x601F440", VA = "0x186020E40")]
	public static ICPPHJLENFJ OJKIKDBCCPC()
	{
		return default(ICPPHJLENFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6020A50", Offset = "0x601F050", VA = "0x186020A50")]
	public (int, int, Task) MJKNFAAADGM(int BDKOHAFBNID, [Optional] CancellationToken JLIEBAENBAG)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6020970", Offset = "0x601EF70", VA = "0x186020970")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DD7140", Offset = "0x2DD5740", VA = "0x182DD7140", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool DEIPNMFGOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> IBCHNDKEOEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x33652D0", Offset = "0x33638D0", VA = "0x1833652D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> HENELDMCHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3365130", Offset = "0x3363730", VA = "0x183365130", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3DB0770", Offset = "0x3DAED70", VA = "0x183DB0770", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3DB07A0", Offset = "0x3DAEDA0", VA = "0x183DB07A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3DAFEA0", Offset = "0x3DAE4A0", VA = "0x183DAFEA0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3DAFE20", Offset = "0x3DAE420", VA = "0x183DAFE20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3DAFB60", Offset = "0x3DAE160", VA = "0x183DAFB60", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3DB0640", Offset = "0x3DAEC40", VA = "0x183DB0640", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3350120", Offset = "0x334E720", VA = "0x183350120", Slot = "9")]
	public void Add(TKey AIGAKEKDKHM, TVal MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3DAFB30", Offset = "0x3DAE130", VA = "0x183DAFB30", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3DAFBC0", Offset = "0x3DAE1C0", VA = "0x183DAFBC0", Slot = "8")]
	public bool ContainsKey(TKey AIGAKEKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3DAFC20", Offset = "0x3DAE220", VA = "0x183DAFC20", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3DB0590", Offset = "0x3DAEB90", VA = "0x183DB0590", Slot = "10")]
	public bool Remove(TKey AIGAKEKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3DB0590", Offset = "0x3DAEB90", VA = "0x183DB0590", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3354490", Offset = "0x3352A90", VA = "0x183354490", Slot = "11")]
	public bool TryGetValue(TKey AIGAKEKDKHM, out TVal MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3DAFED0", Offset = "0x3DAE4D0", VA = "0x183DAFED0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3DAFC50", Offset = "0x3DAE250", VA = "0x183DAFC50", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] HEONDDEAIBL, int EBNCDCCMBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3DB0470", Offset = "0x3DAEA70", VA = "0x183DB0470")]
	public void MFMCNFFMIAP(TVal PHMPKLAMLAM, TKey AIGAKEKDKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3DB0520", Offset = "0x3DAEB20", VA = "0x183DB0520")]
	public void MFMCNFFMIAP(KeyValuePair<TVal, TKey> GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3DB0560", Offset = "0x3DAEB60", VA = "0x183DB0560")]
	public bool OMNCCBLJMKA(TVal AIGAKEKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3DB0000", Offset = "0x3DAE600", VA = "0x183DB0000")]
	public bool HEBLGIOGKGC(KeyValuePair<TVal, TKey> GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3DAFDC0", Offset = "0x3DAE3C0", VA = "0x183DAFDC0")]
	public bool EMIFMEAGDDE(TVal AIGAKEKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3DAFDC0", Offset = "0x3DAE3C0", VA = "0x183DAFDC0")]
	public bool EMIFMEAGDDE(KeyValuePair<TVal, TKey> GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3DB0140", Offset = "0x3DAE740", VA = "0x183DB0140")]
	public bool IDEDABPJLGL(TVal AIGAKEKDKHM, out TKey MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3DAF9F0", Offset = "0x3DADFF0", VA = "0x183DAF9F0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> AAFLPNCIFMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3DB0030", Offset = "0x3DAE630", VA = "0x183DB0030")]
	private void HNNKDLKGAFI(TKey AIGAKEKDKHM, TVal PHMPKLAMLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3DAFD40", Offset = "0x3DAE340", VA = "0x183DAFD40")]
	private void DFEJOPEGFOA(TKey AIGAKEKDKHM, TVal PHMPKLAMLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3DB0170", Offset = "0x3DAE770", VA = "0x183DB0170")]
	private bool LCFIBBDBNFE(TKey AIGAKEKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3DB0230", Offset = "0x3DAE830", VA = "0x183DB0230")]
	private bool LCFIBBDBNFE(TVal PHMPKLAMLAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3DB0690", Offset = "0x3DAEC90", VA = "0x183DB0690")]
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
			[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x3C2FAA0", Offset = "0x3C2E0A0", VA = "0x183C2FAA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3C32D10", Offset = "0x3C31310", VA = "0x183C32D10")]
		public Enumerator(global::OPHCFFOEKGN<T> DICKNCEHGPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3C2D0E0", Offset = "0x3C2B6E0", VA = "0x183C2D0E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3C2EAA0", Offset = "0x3C2D0A0", VA = "0x183C2EAA0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3C2A210", Offset = "0x3C28810", VA = "0x183C2A210")]
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
		[Cpp2IlInjected.Address(RVA = "0x442CA40", Offset = "0x442B040", VA = "0x18442CA40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x442BA10", Offset = "0x442A010", VA = "0x18442BA10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x442B790", Offset = "0x4429D90", VA = "0x18442B790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x442D070", Offset = "0x442B670", VA = "0x18442D070")]
	public OPHCFFOEKGN(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x442C980", Offset = "0x442AF80", VA = "0x18442C980")]
	public void MFMCNFFMIAP(T KHJLEOILJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x442BAC0", Offset = "0x442A0C0", VA = "0x18442BAC0")]
	public void HGKMPAKBDLD(IEnumerable<T> NGFNEKEOBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x442CB10", Offset = "0x442B110", VA = "0x18442CB10")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x442C6C0", Offset = "0x442ACC0", VA = "0x18442C6C0")]
	public void LPOBKMOKLBH(int FPLNDBJJHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x442CA80", Offset = "0x442B080", VA = "0x18442CA80")]
	public void NINMKKOOPEI(int FPLNDBJJHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x442B480", Offset = "0x4429A80", VA = "0x18442B480")]
	public void DCEIPPFEHJE(T[] HEONDDEAIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x442B160", Offset = "0x4429760", VA = "0x18442B160")]
	public Enumerator CBILBBMABKJ()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x442CFF0", Offset = "0x442B5F0", VA = "0x18442CFF0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x442CFF0", Offset = "0x442B5F0", VA = "0x18442CFF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x442CD10", Offset = "0x442B310", VA = "0x18442CD10")]
	private int PMELEOIIPOO(int EBBLFLFCHFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x442B910", Offset = "0x4429F10", VA = "0x18442B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x70DB30", Offset = "0x70C130", VA = "0x18070DB30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool DEIPNMFGOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x84A610", Offset = "0x848C10", VA = "0x18084A610", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x84A6A0", Offset = "0x848CA0", VA = "0x18084A6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3DB73C0", Offset = "0x3DB59C0", VA = "0x183DB73C0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3DB7460", Offset = "0x3DB5A60", VA = "0x183DB7460", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3DB7360", Offset = "0x3DB5960", VA = "0x183DB7360", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3DB72D0", Offset = "0x3DB58D0", VA = "0x183DB72D0")]
	public JCJOHEIBNOL(Func<Internal, External> JNICKEKIKKP, Func<External, Internal> BGDBKLMEHHK, bool JPIIMKIJCFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3DB6FF0", Offset = "0x3DB55F0", VA = "0x183DB6FF0", Slot = "6")]
	public int IndexOf(External GIFJLGCAEHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3DB6C70", Offset = "0x3DB5270", VA = "0x183DB6C70", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3DB6CD0", Offset = "0x3DB52D0", VA = "0x183DB6CD0", Slot = "13")]
	public bool Contains(External GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3DB6D60", Offset = "0x3DB5360", VA = "0x183DB6D60", Slot = "14")]
	public void CopyTo(External[] HEONDDEAIBL, int EBNCDCCMBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3DB6B80", Offset = "0x3DB5180", VA = "0x183DB6B80", Slot = "11")]
	public void Add(External GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3DB70E0", Offset = "0x3DB56E0", VA = "0x183DB70E0", Slot = "7")]
	public void Insert(int EBBLFLFCHFB, External GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3DB7240", Offset = "0x3DB5840", VA = "0x183DB7240", Slot = "15")]
	public bool Remove(External GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3DB7180", Offset = "0x3DB5780", VA = "0x183DB7180", Slot = "8")]
	public void RemoveAt(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3DB6F80", Offset = "0x3DB5580", VA = "0x183DB6F80", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3340970", Offset = "0x333EF70", VA = "0x183340970", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x728F30", Offset = "0x727530", VA = "0x180728F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool DEIPNMFGOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x747120", Offset = "0x745720", VA = "0x180747120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4521220", Offset = "0x451F820", VA = "0x184521220", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x45211C0", Offset = "0x451F7C0", VA = "0x1845211C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x33487E0", Offset = "0x3346DE0", VA = "0x1833487E0")]
	public MAPCALNMOCM(Func<Internal, External> JNICKEKIKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x4521170", Offset = "0x451F770", VA = "0x184521170")]
	public MAPCALNMOCM(IReadOnlyList<Internal> ACLENHAHHHH, Func<Internal, External> JNICKEKIKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x4520EE0", Offset = "0x451F4E0", VA = "0x184520EE0")]
	public void DCEIPPFEHJE(External[] HEONDDEAIBL, int EBNCDCCMBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4521100", Offset = "0x451F700", VA = "0x184521100", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x329DE50", Offset = "0x329C450", VA = "0x18329DE50", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x71E880", Offset = "0x71CE80", VA = "0x18071E880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool DEIPNMFGOOD
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x747120", Offset = "0x745720", VA = "0x180747120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x3E9D580", Offset = "0x3E9BB80", VA = "0x183E9D580", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3E9D520", Offset = "0x3E9BB20", VA = "0x183E9D520", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x33487E0", Offset = "0x3346DE0", VA = "0x1833487E0")]
	public OEBLBOHKBEE(IReadOnlyList<Internal> ACLENHAHHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3E9D480", Offset = "0x3E9BA80", VA = "0x183E9D480")]
	public bool HEBLGIOGKGC(External GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3E9D1E0", Offset = "0x3E9B7E0", VA = "0x183E9D1E0")]
	public void DCEIPPFEHJE(External[] HEONDDEAIBL, int EBNCDCCMBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3E9D410", Offset = "0x3E9BA10", VA = "0x183E9D410", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3340970", Offset = "0x333EF70", VA = "0x183340970", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DEB630", Offset = "0x3DE9C30", VA = "0x183DEB630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB780", Offset = "0x3DE9D80", VA = "0x183DEB780")]
	protected FEOCLBIEGLC(bool KELLOJKFALD, bool MEMKEMAFGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB390", Offset = "0x3DE9990", VA = "0x183DEB390")]
	protected bool GPJDEDLFLMP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB410", Offset = "0x3DE9A10", VA = "0x183DEB410")]
	protected void IJNBNODPPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB0A0", Offset = "0x3DE96A0", VA = "0x183DEB0A0")]
	protected void DFKKOMNLOAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3A408A0", Offset = "0x3A3EEA0", VA = "0x183A408A0")]
	private static void MEHGBHBBNJD<U>(ref List<U> ACLENHAHHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB4D0", Offset = "0x3DE9AD0", VA = "0x183DEB4D0", Slot = "5")]
	public void MFMCNFFMIAP(T PBOHOIMMGFG, bool EOKOPABKJOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB250", Offset = "0x3DE9850", VA = "0x183DEB250", Slot = "6")]
	public void EMIFMEAGDDE(T PBOHOIMMGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB670", Offset = "0x3DE9C70", VA = "0x183DEB670")]
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
	[Cpp2IlInjected.Address(RVA = "0x601FE80", Offset = "0x601E480", VA = "0x18601FE80")]
	public FHIFKLKAEJA(bool KELLOJKFALD = false, bool MEMKEMAFGFI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x601FBB0", Offset = "0x601E1B0", VA = "0x18601FBB0")]
	public void BOKGNJCLLJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x601FB40", Offset = "0x601E140", VA = "0x18601FB40", Slot = "4")]
	public override void BJMBPBAPMOH(object[] HNGHLHHNPMK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x601FDC0", Offset = "0x601E3C0", VA = "0x18601FDC0")]
	public static FHIFKLKAEJA CPMGNAGFNGK(FHIFKLKAEJA BJPMLKBCBLO, Action PBOHOIMMGFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x601FE20", Offset = "0x601E420", VA = "0x18601FE20")]
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
	[Cpp2IlInjected.Address(RVA = "0x3420A10", Offset = "0x341F010", VA = "0x183420A10")]
	public DIDGCDLBPOE(bool KELLOJKFALD = false, bool MEMKEMAFGFI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x341FAD0", Offset = "0x341E0D0", VA = "0x18341FAD0")]
	public void BOKGNJCLLJG(T KHJLEOILJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x341DBF0", Offset = "0x341C1F0", VA = "0x18341DBF0", Slot = "4")]
	public override void BJMBPBAPMOH(object[] HNGHLHHNPMK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x34208D0", Offset = "0x341EED0", VA = "0x1834208D0")]
	public static global::DIDGCDLBPOE<T> CPMGNAGFNGK(global::DIDGCDLBPOE<T> BJPMLKBCBLO, Action<T> PBOHOIMMGFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3420970", Offset = "0x341EF70", VA = "0x183420970")]
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
	[Cpp2IlInjected.Address(RVA = "0x3420A10", Offset = "0x341F010", VA = "0x183420A10")]
	public HHFONFHJAEB(bool KELLOJKFALD = false, bool MEMKEMAFGFI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x46DD610", Offset = "0x46DBC10", VA = "0x1846DD610")]
	public void BOKGNJCLLJG(T KHJLEOILJMF, U LOKAFGDNNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x46D9F90", Offset = "0x46D8590", VA = "0x1846D9F90", Slot = "4")]
	public override void BJMBPBAPMOH(object[] HNGHLHHNPMK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x46DDAB0", Offset = "0x46DC0B0", VA = "0x1846DDAB0")]
	public static global::HHFONFHJAEB<T, U> CPMGNAGFNGK(global::HHFONFHJAEB<T, U> BJPMLKBCBLO, Action<T, U> PBOHOIMMGFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x46DDB50", Offset = "0x46DC150", VA = "0x1846DDB50")]
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
	[Cpp2IlInjected.Address(RVA = "0x3420A10", Offset = "0x341F010", VA = "0x183420A10")]
	public PKFHEEKPKKD(bool KELLOJKFALD = false, bool MEMKEMAFGFI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x3D958D0", Offset = "0x3D93ED0", VA = "0x183D958D0")]
	public void BOKGNJCLLJG(T KHJLEOILJMF, U LOKAFGDNNFC, V HIGLPPEBKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3D92CD0", Offset = "0x3D912D0", VA = "0x183D92CD0", Slot = "4")]
	public override void BJMBPBAPMOH(object[] HNGHLHHNPMK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3D96060", Offset = "0x3D94660", VA = "0x183D96060")]
	public static global::PKFHEEKPKKD<T, U, V> CPMGNAGFNGK(global::PKFHEEKPKKD<T, U, V> BJPMLKBCBLO, Action<T, U, V> PBOHOIMMGFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3D96100", Offset = "0x3D94700", VA = "0x183D96100")]
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
	[Cpp2IlInjected.Address(RVA = "0x3420A10", Offset = "0x341F010", VA = "0x183420A10")]
	public BMFLDIECGBN(bool KELLOJKFALD = false, bool MEMKEMAFGFI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3FAFD30", Offset = "0x3FAE330", VA = "0x183FAFD30")]
	public void BOKGNJCLLJG(T KHJLEOILJMF, U LOKAFGDNNFC, V HIGLPPEBKMI, W JNLBJEDABNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3FAF000", Offset = "0x3FAD600", VA = "0x183FAF000", Slot = "4")]
	public override void BJMBPBAPMOH(object[] HNGHLHHNPMK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3FB09F0", Offset = "0x3FAEFF0", VA = "0x183FB09F0")]
	public static global::BMFLDIECGBN<T, U, V, W> CPMGNAGFNGK(global::BMFLDIECGBN<T, U, V, W> BJPMLKBCBLO, Action<T, U, V, W> PBOHOIMMGFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3FB0A90", Offset = "0x3FAF090", VA = "0x183FB0A90")]
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
	[Cpp2IlInjected.Address(RVA = "0x3420A10", Offset = "0x341F010", VA = "0x183420A10")]
	public AAMCBGHEIGI(bool KELLOJKFALD = false, bool MEMKEMAFGFI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x42777D0", Offset = "0x4275DD0", VA = "0x1842777D0")]
	public void BOKGNJCLLJG(T KHJLEOILJMF, U LOKAFGDNNFC, V HIGLPPEBKMI, W JNLBJEDABNH, X FBHIPILAOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x42774E0", Offset = "0x4275AE0", VA = "0x1842774E0", Slot = "4")]
	public override void BJMBPBAPMOH(object[] HNGHLHHNPMK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4277D90", Offset = "0x4276390", VA = "0x184277D90")]
	public static global::AAMCBGHEIGI<T, U, V, W, X> CPMGNAGFNGK(global::AAMCBGHEIGI<T, U, V, W, X> BJPMLKBCBLO, Action<T, U, V, W, X> PBOHOIMMGFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4277E30", Offset = "0x4276430", VA = "0x184277E30")]
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
	[Cpp2IlInjected.Address(RVA = "0x3420A10", Offset = "0x341F010", VA = "0x183420A10")]
	public OOFMMIOMMON(bool KELLOJKFALD = false, bool MEMKEMAFGFI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4426820", Offset = "0x4424E20", VA = "0x184426820")]
	public void BOKGNJCLLJG(T KHJLEOILJMF, U LOKAFGDNNFC, V HIGLPPEBKMI, W JNLBJEDABNH, X FBHIPILAOBE, Y DPKHPCDGHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4425BA0", Offset = "0x44241A0", VA = "0x184425BA0", Slot = "4")]
	public override void BJMBPBAPMOH(object[] HNGHLHHNPMK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4426AD0", Offset = "0x44250D0", VA = "0x184426AD0")]
	public static global::OOFMMIOMMON<T, U, V, W, X, Y> CPMGNAGFNGK(global::OOFMMIOMMON<T, U, V, W, X, Y> BJPMLKBCBLO, Action<T, U, V, W, X, Y> PBOHOIMMGFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4426B70", Offset = "0x4425170", VA = "0x184426B70")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B39A40", Offset = "0x3B38040", VA = "0x183B39A40")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3B39A10", Offset = "0x3B38010", VA = "0x183B39A10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x72F870", Offset = "0x72DE70", VA = "0x18072F870")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EA45F0", Offset = "0x3EA2BF0", VA = "0x183EA45F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2DC9C60", Offset = "0x2DC8260", VA = "0x182DC9C60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x39506E0", Offset = "0x394ECE0", VA = "0x1839506E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2DC9C60", Offset = "0x2DC8260", VA = "0x182DC9C60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3812F00", Offset = "0x3811500", VA = "0x183812F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x38134C0", Offset = "0x3811AC0", VA = "0x1838134C0")]
	public OCAOLNHHFPP(in T DJGLBNHLKLO, int COPBECCINLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3813600", Offset = "0x3811C00", VA = "0x183813600")]
	public OCAOLNHHFPP(in T DJGLBNHLKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3812E80", Offset = "0x3811480", VA = "0x183812E80")]
	public MDIJKHLFBFG LLONAODEMDC()
	{
		return default(MDIJKHLFBFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3812EC0", Offset = "0x38114C0", VA = "0x183812EC0")]
	public MDIJKHLFBFG LLONAODEMDC(CancellationToken JLIEBAENBAG)
	{
		return default(MDIJKHLFBFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x38131F0", Offset = "0x38117F0", VA = "0x1838131F0")]
	[AsyncStateMachine(typeof(global::OCAOLNHHFPP<>.OHOHAKMBCEE))]
	public Task<MDIJKHLFBFG> MGNLFBNOIJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3812F20", Offset = "0x3811520", VA = "0x183812F20")]
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
	[Cpp2IlInjected.Address(RVA = "0x6022150", Offset = "0x6020750", VA = "0x186022150")]
	public static global::OCAOLNHHFPP<ABCENELPPGI> OJKIKDBCCPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x60221B0", Offset = "0x60207B0", VA = "0x1860221B0")]
	public static global::OCAOLNHHFPP<ABCENELPPGI> OJKIKDBCCPC(int COPBECCINLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x326A2C0", Offset = "0x32688C0", VA = "0x18326A2C0")]
	public static global::OCAOLNHHFPP<T> OJKIKDBCCPC<T>(in T DJGLBNHLKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3567830", Offset = "0x3565E30", VA = "0x183567830")]
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
			[Cpp2IlInjected.Address(RVA = "0x441A4C0", Offset = "0x4418AC0", VA = "0x18441A4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan DBCHIHAOLJG
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x441A5A0", Offset = "0x4418BA0", VA = "0x18441A5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4277110", Offset = "0x4275710", VA = "0x184277110")]
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
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public DLEHDGNBGDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7140", Offset = "0x2DD5740", VA = "0x182DD7140")]
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
		[Cpp2IlInjected.Address(RVA = "0x364E7B0", Offset = "0x364CDB0", VA = "0x18364E7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x341C400", Offset = "0x341AA00", VA = "0x18341C400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x333E960", Offset = "0x333CF60", VA = "0x18333E960")]
	public ELCIDDJLDCB(MLEPNILKGCO NIHBKGFFHID, [Optional] NOOJLBKCGBM ANIIMKCDHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x333E120", Offset = "0x333C720", VA = "0x18333E120")]
	public Task<TResult> NMNBJNPMHAB(TRequest GHNJJOLFHLE, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x333E5E0", Offset = "0x333CBE0", VA = "0x18333E5E0")]
	private void OJODPNCOPLA(AAGMAFIMKAD FKBEKHPDNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x333DA60", Offset = "0x333C060", VA = "0x18333DA60")]
	[AsyncStateMachine(typeof(global::ELCIDDJLDCB<, >.CFINJIPBCPL))]
	private Task LADICEMNKHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x333D260", Offset = "0x333B860", VA = "0x18333D260")]
	private AAGMAFIMKAD EFOLMBHNDHM()
	{
		return default(AAGMAFIMKAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x333CFE0", Offset = "0x333B5E0", VA = "0x18333CFE0")]
	[AsyncStateMachine(typeof(global::ELCIDDJLDCB<, >.DHKCGHGFKID))]
	private Task DOPBNONFNDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x333DD30", Offset = "0x333C330", VA = "0x18333DD30")]
	private void MGIBPPOBDNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x333D220", Offset = "0x333B820", VA = "0x18333D220", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x340ECA0", Offset = "0x340D2A0", VA = "0x18340ECA0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int NMHGIFHEGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x340EBD0", Offset = "0x340D1D0", VA = "0x18340EBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x340F000", Offset = "0x340D600", VA = "0x18340F000", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x340F0D0", Offset = "0x340D6D0", VA = "0x18340F0D0")]
	public DCHACEMAAJB(int FHGNFGIEADL, [Optional] CMBLDCEKAGA CFFGMELEKKB, [Optional] IEqualityComparer<TKey> HBGNHHMIMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x340EC00", Offset = "0x340D200", VA = "0x18340EC00")]
	public void FMEOPAEPEHB(TKey AIGAKEKDKHM, TVal MAKFNMHIJIF, bool KCEMNGGENMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x340EEE0", Offset = "0x340D4E0", VA = "0x18340EEE0")]
	public bool HLDGLPNLMHP(TKey AIGAKEKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x340EF60", Offset = "0x340D560", VA = "0x18340EF60", Slot = "6")]
	public override bool IDEDABPJLGL(TKey EMOIKMNLKII, out TVal MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x340ECD0", Offset = "0x340D2D0", VA = "0x18340ECD0")]
	public bool GACFEKPHLIM(TKey AIGAKEKDKHM, TVal MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x340EA20", Offset = "0x340D020", VA = "0x18340EA20")]
	public bool BPECLAKNIMF(TKey AIGAKEKDKHM, TVal MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x340F060", Offset = "0x340D660", VA = "0x18340F060", Slot = "7")]
	public override void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x340EB30", Offset = "0x340D130", VA = "0x18340EB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x792CB0", Offset = "0x7912B0", VA = "0x180792CB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x70DB30", Offset = "0x70C130", VA = "0x18070DB30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int DAPJFJMMFBP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x73E3B0", Offset = "0x73C9B0", VA = "0x18073E3B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x73E500", Offset = "0x73CB00", VA = "0x18073E500")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime NPCKGPMDEKL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x67A0D0", Offset = "0x6786D0", VA = "0x18067A0D0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x7226B0", Offset = "0x720CB0", VA = "0x1807226B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3B51080", Offset = "0x3B4F680", VA = "0x183B51080")]
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
		[Cpp2IlInjected.Address(RVA = "0x74FE00", Offset = "0x74E400", VA = "0x18074FE00")]
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
		[Cpp2IlInjected.Address(RVA = "0x3941C90", Offset = "0x3940290", VA = "0x183941C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int GFMOOKAPJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x736580", Offset = "0x734B80", VA = "0x180736580", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int FPLNDBJJHMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3535DD0", Offset = "0x35343D0", VA = "0x183535DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x305A030", Offset = "0x3058630", VA = "0x18305A030", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> IBCHNDKEOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x393FEB0", Offset = "0x393E4B0", VA = "0x18393FEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x39408C0", Offset = "0x393EEC0", VA = "0x1839408C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3940850", Offset = "0x393EE50", VA = "0x183940850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3943240", Offset = "0x3941840", VA = "0x183943240")]
	public NDNGBBCKHCE(int FHGNFGIEADL, [Optional] CMBLDCEKAGA CFFGMELEKKB, [Optional] IEqualityComparer<TKey> HBGNHHMIMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3942E50", Offset = "0x3941450", VA = "0x183942E50")]
	public NDNGBBCKHCE(TimeSpan BKCGMNJIHAM, [Optional] IEqualityComparer<TKey> HBGNHHMIMOI, [Optional] JEIIFICOFCM JKFNNLDKEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3942EA0", Offset = "0x39414A0", VA = "0x183942EA0")]
	public NDNGBBCKHCE(int FHGNFGIEADL, TimeSpan BKCGMNJIHAM, [Optional] IEqualityComparer<TKey> HBGNHHMIMOI, [Optional] JEIIFICOFCM JKFNNLDKEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x39438E0", Offset = "0x3941EE0", VA = "0x1839438E0")]
	public NDNGBBCKHCE(int FHGNFGIEADL, CMBLDCEKAGA CFFGMELEKKB, TimeSpan BKCGMNJIHAM, [Optional] IEqualityComparer<TKey> HBGNHHMIMOI, [Optional] JEIIFICOFCM JKFNNLDKEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x3940A70", Offset = "0x393F070", VA = "0x183940A70")]
	public void IAEIAJCJPJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3941A30", Offset = "0x3940030", VA = "0x183941A30")]
	public void KMNEKDAGPNL(TKey AIGAKEKDKHM, TVal MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3940550", Offset = "0x393EB50", VA = "0x183940550")]
	public bool EMIFMEAGDDE(TKey AIGAKEKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x39401B0", Offset = "0x393E7B0", VA = "0x1839401B0")]
	private TVal DNJGGIFCOKL(TKey EMOIKMNLKII)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3940EC0", Offset = "0x393F4C0", VA = "0x183940EC0", Slot = "6")]
	public virtual bool IDEDABPJLGL(TKey EMOIKMNLKII, out TVal MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3942DE0", Offset = "0x39413E0", VA = "0x183942DE0", Slot = "7")]
	public virtual void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x393FBB0", Offset = "0x393E1B0", VA = "0x18393FBB0")]
	private bool AEGOGJBDNHC(MJNGCLLDKNC DCAFEJFFOOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3942B90", Offset = "0x3941190", VA = "0x183942B90")]
	private void OPMGFKBEAOC(LinkedListNode<MJNGCLLDKNC> GADFCCOIBBL, TVal MAEOIACPFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3941F00", Offset = "0x3940500", VA = "0x183941F00")]
	private void OGKJCDPEKGH(TKey AIGAKEKDKHM, TVal MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x39412E0", Offset = "0x393F8E0", VA = "0x1839412E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DD7140", Offset = "0x2DD5740", VA = "0x182DD7140", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool DEIPNMFGOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2C9BD30", Offset = "0x2C9A330", VA = "0x182C9BD30", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x423C560", Offset = "0x423AB60", VA = "0x18423C560", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x36C6210", Offset = "0x36C4810", VA = "0x1836C6210", Slot = "11")]
	public void Add(T GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x423BC60", Offset = "0x423A260", VA = "0x18423BC60")]
	public bool FKGKAEHMBPL(T GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x423C2B0", Offset = "0x423A8B0", VA = "0x18423C2B0", Slot = "15")]
	public bool Remove(T GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x33543E0", Offset = "0x33529E0", VA = "0x1833543E0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x328A770", Offset = "0x3288D70", VA = "0x18328A770", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x423BBD0", Offset = "0x423A1D0", VA = "0x18423BBD0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3457EB0", Offset = "0x34564B0", VA = "0x183457EB0", Slot = "13")]
	public bool Contains(T GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x423BC30", Offset = "0x423A230", VA = "0x18423BC30", Slot = "14")]
	public void CopyTo(T[] HEONDDEAIBL, int EBNCDCCMBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3DB0770", Offset = "0x3DAED70", VA = "0x183DB0770", Slot = "6")]
	public int IndexOf(T GIFJLGCAEHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x423BE80", Offset = "0x423A480", VA = "0x18423BE80", Slot = "7")]
	public void Insert(int EBBLFLFCHFB, T GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x423C110", Offset = "0x423A710", VA = "0x18423C110", Slot = "8")]
	public void RemoveAt(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x423BF40", Offset = "0x423A540", VA = "0x18423BF40")]
	public void KCBMKPEBDJF(Predicate<T> KIEFNBLKNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x423C0E0", Offset = "0x423A6E0", VA = "0x18423C0E0")]
	public void MJAFONJILHK(Comparison<T> FEIBNCKGMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x423C3C0", Offset = "0x423A9C0", VA = "0x18423C3C0")]
	public ANKBCJBOEIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class FFIIGFJDANN
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x601F870", Offset = "0x601DE70", VA = "0x18601F870")]
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
			[Cpp2IlInjected.Address(RVA = "0xC23280", Offset = "0xC21880", VA = "0x180C23280")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1CB2EF0", Offset = "0x1CB14F0", VA = "0x181CB2EF0")]
		public SerializedGuid(in Guid GDIIAHJOKME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6026BB0", Offset = "0x60251B0", VA = "0x186026BB0")]
		public static SerializedGuid CFKPLKEHJHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6026DD0", Offset = "0x60253D0", VA = "0x186026DD0")]
		public static SerializedGuid IFCIKIILLEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6026F90", Offset = "0x6025590", VA = "0x186026F90")]
		public bool PNDBPNEHPOE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1CB2EC0", Offset = "0x1CB14C0", VA = "0x181CB2EC0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6026E60", Offset = "0x6025460", VA = "0x186026E60", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6026F00", Offset = "0x6025500", VA = "0x186026F00")]
		public bool PEGCDPIHGIH(in Guid GDIIAHJOKME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6026C40", Offset = "0x6025240", VA = "0x186026C40", Slot = "7")]
		public bool Equals(SerializedGuid OANENNOJEBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6026CF0", Offset = "0x60252F0", VA = "0x186026CF0", Slot = "0")]
		public override bool Equals(object LGKNNMGLNIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x1CB2E10", Offset = "0x1CB1410", VA = "0x181CB2E10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1CB2C50", Offset = "0x1CB1250", VA = "0x181CB2C50", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x6020200", Offset = "0x601E800", VA = "0x186020200")]
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
		[Cpp2IlInjected.Address(RVA = "0x67A0D0", Offset = "0x6786D0", VA = "0x18067A0D0", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x32898F0", Offset = "0x3287EF0", VA = "0x1832898F0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool GICPBKDAEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x731C90", Offset = "0x730290", VA = "0x180731C90", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string DDCPHGIIMND
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x681C00", Offset = "0x680200", VA = "0x180681C00", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2346A50", Offset = "0x2345050", VA = "0x182346A50", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x3289A30", Offset = "0x3288030", VA = "0x183289A30")]
	private void CKBOMKNNBHG(T GOMBJHKPMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x3289D00", Offset = "0x3288300", VA = "0x183289D00")]
	private void LHKBMOIOJDA(string DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3289B20", Offset = "0x3288120", VA = "0x183289B20")]
	public void GJKIOCLBKIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3289BD0", Offset = "0x32881D0", VA = "0x183289BD0", Slot = "6")]
	public global::GJDDGLMMKIJ<T> HAKGPJDJIOP(Action<T, T> BOMOHCIBPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x3289AD0", Offset = "0x32880D0", VA = "0x183289AD0", Slot = "7")]
	public global::GJDDGLMMKIJ<T> DNMJMICAJCD(Action<T, T> BOMOHCIBPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3289C20", Offset = "0x3288220", VA = "0x183289C20", Slot = "4")]
	public global::GJDDGLMMKIJ<T> JGMENGAGDMG(Action<T> BOMOHCIBPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x3289CB0", Offset = "0x32882B0", VA = "0x183289CB0", Slot = "5")]
	public global::GJDDGLMMKIJ<T> JLNMNDOGGIM(Action<T> MJJOKKCPEKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x3289920", Offset = "0x3287F20", VA = "0x183289920", Slot = "8")]
	public global::GJDDGLMMKIJ<T> BIAKLLMNNJJ(Action<string> NGKDMEPIKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x32899C0", Offset = "0x3287FC0", VA = "0x1832899C0", Slot = "9")]
	public global::GJDDGLMMKIJ<T> CAJGPDBBOAO(Action<string> NGKDMEPIKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x3289DB0", Offset = "0x32883B0", VA = "0x183289DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public PGLLILBFKEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3D87D50", Offset = "0x3D86350", VA = "0x183D87D50")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x433CA00", Offset = "0x433B000", VA = "0x18433CA00")]
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
		[Cpp2IlInjected.Address(RVA = "0x3B40420", Offset = "0x3B3EA20", VA = "0x183B40420")]
		public MECHGGHOKGB(long JCJBGGEHJCO, int GAJNHPMBIEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3B403F0", Offset = "0x3B3E9F0", VA = "0x183B403F0")]
		public MECHGGHOKGB(long JCJBGGEHJCO, long DCCAPHBMAKM, int GAJNHPMBIEF, int NLKGPLEOMKF, bool GPGIIALFPII, string FFCMOKMMJLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3B402F0", Offset = "0x3B3E8F0", VA = "0x183B402F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void JLNALMCFDOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3B402A0", Offset = "0x3B3E8A0", VA = "0x183B402A0")]
		public int DFJMMPOKCGO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3B40360", Offset = "0x3B3E960", VA = "0x183B40360")]
		public int LHBEPPGOMIM(int KHFJNOFBFJH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3B40380", Offset = "0x3B3E980", VA = "0x183B40380")]
		public double OJHIINBEAEI()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3B40210", Offset = "0x3B3E810", VA = "0x183B40210")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C15CA0", Offset = "0x2C142A0", VA = "0x182C15CA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x4092C10", Offset = "0x4091210", VA = "0x184092C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<GPNAMOIINIG> KEPEEEPLAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x4092C40", Offset = "0x4091240", VA = "0x184092C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public MECHGGHOKGB GMECMLPGFKC
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xD60CC0", Offset = "0xD5F2C0", VA = "0x180D60CC0")]
			[CompilerGenerated]
			get
			{
				return default(MECHGGHOKGB);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x4092F20", Offset = "0x4091520", VA = "0x184092F20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x4093030", Offset = "0x4091630", VA = "0x184093030")]
		internal GPNAMOIINIG(global::IMNAINPHIAI<TKey> IDKFKDEHFHM, TKey AIGAKEKDKHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x4092C60", Offset = "0x4091260", VA = "0x184092C60")]
		public GPNAMOIINIG DMCONOPIPBN(TKey AIGAKEKDKHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4092F50", Offset = "0x4091550", VA = "0x184092F50")]
		public void PDLAKBALGNK(TKey AIGAKEKDKHM, Action<GPNAMOIINIG> PBOHOIMMGFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x41D6020", Offset = "0x41D4620", VA = "0x1841D6020")]
		public T PDLAKBALGNK<T>(TKey AIGAKEKDKHM, Func<GPNAMOIINIG, T> FIFMLJNEANH)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x41D5EB0", Offset = "0x41D44B0", VA = "0x1841D5EB0")]
		[AsyncStateMachine(typeof(IMLPJAOINKO))]
		public Task<T> FMELLIGOPBO<T>(TKey AIGAKEKDKHM, Func<GPNAMOIINIG, Task<T>> FIFMLJNEANH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x4092D70", Offset = "0x4091370", VA = "0x184092D70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2FEC010", Offset = "0x2FEA610", VA = "0x182FEC010", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3281140", Offset = "0x327F740", VA = "0x183281140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x2FEC270", Offset = "0x2FEA870", VA = "0x182FEC270")]
		[DebuggerHidden]
		public ILINBGMHPCM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2FFD4C0", Offset = "0x2FFBAC0", VA = "0x182FFD4C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3280D60", Offset = "0x327F360", VA = "0x183280D60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x32811A0", Offset = "0x327F7A0", VA = "0x1832811A0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3281100", Offset = "0x327F700", VA = "0x183281100", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3281010", Offset = "0x327F610", VA = "0x183281010", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, MECHGGHOKGB)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x32810D0", Offset = "0x327F6D0", VA = "0x1832810D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2FEC010", Offset = "0x2FEA610", VA = "0x182FEC010", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2FEC0B0", Offset = "0x2FEA6B0", VA = "0x182FEC0B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2FEC270", Offset = "0x2FEA870", VA = "0x182FEC270")]
		[DebuggerHidden]
		public IFCICJPLNMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x2FEC110", Offset = "0x2FEA710", VA = "0x182FEC110", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2FEB990", Offset = "0x2FE9F90", VA = "0x182FEB990", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2FEC1B0", Offset = "0x2FEA7B0", VA = "0x182FEC1B0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x2FEC210", Offset = "0x2FEA810", VA = "0x182FEC210")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2FEC070", Offset = "0x2FEA670", VA = "0x182FEC070", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2FEBF30", Offset = "0x2FEA530", VA = "0x182FEBF30", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, MECHGGHOKGB)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x2FEC040", Offset = "0x2FEA640", VA = "0x182FEC040", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x681C00", Offset = "0x680200", VA = "0x180681C00")]
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
		[Cpp2IlInjected.Address(RVA = "0x694B00", Offset = "0x693100", VA = "0x180694B00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3289570", Offset = "0x3287B70", VA = "0x183289570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long KAHLIBHKHDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3289750", Offset = "0x3287D50", VA = "0x183289750")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int LDAPHMBDBBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3289720", Offset = "0x3287D20", VA = "0x183289720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x3289770", Offset = "0x3287D70", VA = "0x183289770")]
	public IMNAINPHIAI(TKey ANCBBPDPCKE, [Optional] int? GAJNHPMBIEF, [Optional][CanBeNull] Stopwatch BJBNCBNGCEP, [Optional] Action<TKey, MECHGGHOKGB> CKAINHNLOMD, [Optional] Action<TKey, MECHGGHOKGB> GDIJDPANPIK, [Optional] Action<global::IMNAINPHIAI<TKey>> EEGOMPKNKGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x3289670", Offset = "0x3287C70", VA = "0x183289670", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x3289650", Offset = "0x3287C50", VA = "0x183289650")]
	public void DKDNBCMJFNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x3289700", Offset = "0x3287D00", VA = "0x183289700")]
	public void EHPMFPNKDKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x3289410", Offset = "0x3287A10", VA = "0x183289410")]
	[IteratorStateMachine(typeof(global::IMNAINPHIAI<>.ILINBGMHPCM))]
	public IEnumerable<(TKey, List<TKey>, MECHGGHOKGB)> ABCMDMKPDKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x32894A0", Offset = "0x3287AA0", VA = "0x1832894A0")]
	[IteratorStateMachine(typeof(global::IMNAINPHIAI<>.IFCICJPLNMO))]
	private IEnumerable<(TKey, List<TKey>, MECHGGHOKGB)> ABCMDMKPDKB(List<TKey> GFBIJELPOGE, GPNAMOIINIG DFEFIINOOJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x32895D0", Offset = "0x3287BD0", VA = "0x1832895D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
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
	[Cpp2IlInjected.Address(RVA = "0x4989DB0", Offset = "0x49883B0", VA = "0x184989DB0")]
	protected string OKAKEKMGIAI(double HHGANBKBOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x4989B30", Offset = "0x4988130", VA = "0x184989B30")]
	protected string GDDJBHOLPHC(int FEIKHKEENLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x4989B90", Offset = "0x4988190", VA = "0x184989B90")]
	private static string GEKOLILBPIN(TKey AIGAKEKDKHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x4989D00", Offset = "0x4988300", VA = "0x184989D00", Slot = "4")]
	public override string GMGNBAIFOHI(global::IMNAINPHIAI<TKey> IDKFKDEHFHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x4989BD0", Offset = "0x49881D0", VA = "0x184989BD0")]
	public string GMGNBAIFOHI(global::IMNAINPHIAI<TKey> IDKFKDEHFHM, [NotNull] ELHJGOONKLJ KKILGMJELKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string PLADKDGLFHA(global::IMNAINPHIAI<TKey> IDKFKDEHFHM, [NotNull] ELHJGOONKLJ KKILGMJELKL);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x3340970", Offset = "0x333EF70", VA = "0x183340970")]
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
	[Cpp2IlInjected.Address(RVA = "0x3555FE0", Offset = "0x35545E0", VA = "0x183555FE0")]
	private static string GEKOLILBPIN(TKey AIGAKEKDKHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x35567C0", Offset = "0x3554DC0", VA = "0x1835567C0")]
	public ICOHJPNAGPK(string MAPEFNAHLOH = "F2", double CAJLNGEOJLJ = double.MaxValue, bool MEBMPGHCDHF = false, int GMLGNFOAOPG = int.MaxValue, [Optional] ISet<string> MFGNDLJIAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3556560", Offset = "0x3554B60", VA = "0x183556560", Slot = "4")]
	public override Dictionary<string, string> GMGNBAIFOHI(global::IMNAINPHIAI<TKey> IDKFKDEHFHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x3555F00", Offset = "0x3554500", VA = "0x183555F00")]
	private bool DGJKFODNPAH(string BFFCDBNLLNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3556020", Offset = "0x3554620", VA = "0x183556020")]
	public Dictionary<string, string> GMGNBAIFOHI(global::IMNAINPHIAI<TKey> IDKFKDEHFHM, LKJJNDFICGB KKILGMJELKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x3556610", Offset = "0x3554C10", VA = "0x183556610")]
	private string LHIPIEDKAAD(StringBuilder ADEGNJKGLGH, List<TKey> EOBCGCHNBEH, LKJJNDFICGB KKILGMJELKL, bool EAMABKOMBMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x3555D80", Offset = "0x3554380", VA = "0x183555D80")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D85530", Offset = "0x3D83B30", VA = "0x183D85530")]
	private PFDIGCIPPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x3D84540", Offset = "0x3D82B40", VA = "0x183D84540", Slot = "5")]
	protected override string PLADKDGLFHA(global::IMNAINPHIAI<TKey> IDKFKDEHFHM, ELHJGOONKLJ KKILGMJELKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x3D84450", Offset = "0x3D82A50", VA = "0x183D84450")]
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
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public BFLFHGMPDFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2C163A0", Offset = "0x2C149A0", VA = "0x182C163A0")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x3561CB0", Offset = "0x35602B0", VA = "0x183561CB0", Slot = "5")]
	protected override string PLADKDGLFHA(global::IMNAINPHIAI<TKey> IDKFKDEHFHM, ELHJGOONKLJ KKILGMJELKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x33545C0", Offset = "0x3352BC0", VA = "0x1833545C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public OGLMFGNHGGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6024790", Offset = "0x6022D90", VA = "0x186024790")]
		internal void <Wrap>b__0(global::IMNAINPHIAI<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6020000", Offset = "0x601E600", VA = "0x186020000")]
	public GAKMFMMDBHB([Optional] string OOCECJOPGJJ, [Optional] int? GAJNHPMBIEF, [Optional] Stopwatch BJBNCBNGCEP, [Optional] Action<string, MECHGGHOKGB> CKAINHNLOMD, [Optional] Action<string, MECHGGHOKGB> GDIJDPANPIK, [Optional] Action<GAKMFMMDBHB> EEGOMPKNKGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x601FF20", Offset = "0x601E520", VA = "0x18601FF20")]
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
			[Cpp2IlInjected.Address(RVA = "0x6021FA0", Offset = "0x60205A0", VA = "0x186021FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6022000", Offset = "0x6020600", VA = "0x186022000", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float CEKALADGLHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x6021F90", Offset = "0x6020590", VA = "0x186021F90", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x60220F0", Offset = "0x60206F0", VA = "0x1860220F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x60212B0", Offset = "0x601F8B0", VA = "0x1860212B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	protected JEIIFICOFCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class AOIMBPIFNMN : global::EKMNAMHGPIH<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x601E2F0", Offset = "0x601C8F0", VA = "0x18601E2F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x23564F0", Offset = "0x2354AF0", VA = "0x1823564F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::DIHJKCFGFNO<T> JIMIEHFMAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2346860", Offset = "0x2344E60", VA = "0x182346860", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x3335840", Offset = "0x3333E40", VA = "0x183335840")]
	public EKMNAMHGPIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class BDMBEJNMMBP : global::NCMPNKNHBEP<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x601F2B0", Offset = "0x601D8B0", VA = "0x18601F2B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x23564F0", Offset = "0x2354AF0", VA = "0x1823564F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::DIHJKCFGFNO<T> JIMIEHFMAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2346860", Offset = "0x2344E60", VA = "0x182346860", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x3169600", Offset = "0x3167C00", VA = "0x183169600")]
	public NCMPNKNHBEP(Exception CNABBHHIHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task INDBBJFPDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::DIHJKCFGFNO<T> JIMIEHFMAPK
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2354870", Offset = "0x2352E70", VA = "0x182354870", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool OKJAKPPJFHO
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x84A610", Offset = "0x848C10", VA = "0x18084A610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x4174130", Offset = "0x4172730", VA = "0x184174130")]
	static KNDNJAHLILL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x4174410", Offset = "0x4172A10", VA = "0x184174410")]
	protected KNDNJAHLILL(TTask LMDFEBFDNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x4174070", Offset = "0x4172670", VA = "0x184174070", Slot = "1")]
	~KNDNJAHLILL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x4174040", Offset = "0x4172640", VA = "0x184174040", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x4173ED0", Offset = "0x41724D0", VA = "0x184173ED0")]
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
	[Cpp2IlInjected.Address(RVA = "0x41740E0", Offset = "0x41726E0", VA = "0x1841740E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6021720", Offset = "0x601FD20", VA = "0x186021720")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x60218B0", Offset = "0x601FEB0", VA = "0x1860218B0")]
		public KDGJHJMAIOG(float LJECKBCMELA, float EAJAFIHJLHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6021730", Offset = "0x601FD30", VA = "0x186021730", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x12C1B30", Offset = "0x12C0130", VA = "0x1812C1B30")]
		get
		{
			return default(KDGJHJMAIOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float JHIACKNNLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x60242F0", Offset = "0x60228F0", VA = "0x1860242F0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event OOHNJLLKJKP BOMFJCMHNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6024310", Offset = "0x6022910", VA = "0x186024310", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6023D50", Offset = "0x6022350", VA = "0x186023D50", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6024470", Offset = "0x6022A70", VA = "0x186024470")]
	public MNFBCLMGCPE(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6023E10", Offset = "0x6022410", VA = "0x186023E10")]
	public IKHDPONDBON GJFAIHPAPAA(KDGJHJMAIOG NGFNEKEOBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6023EA0", Offset = "0x60224A0", VA = "0x186023EA0")]
	public void KCALJDMAEHK(EIPKADAOJJH IACBHIONDIF, [Optional] KDGJHJMAIOG HLHAKPMJOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x60243D0", Offset = "0x60229D0", VA = "0x1860243D0")]
	internal int NCLIALNFMIA(EIPKADAOJJH CNCPFNFODHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6024420", Offset = "0x6022A20", VA = "0x186024420")]
	internal KDGJHJMAIOG NDKNHHBOKKE(int EBBLFLFCHFB)
	{
		return default(KDGJHJMAIOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6023BC0", Offset = "0x60221C0", VA = "0x186023BC0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x60246A0", Offset = "0x6022CA0", VA = "0x1860246A0")]
		public ODGOBOGPHLL(EIPKADAOJJH CNCPFNFODHI, OOHNJLLKJKP ONHFNOPIIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6024650", Offset = "0x6022C50", VA = "0x186024650", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6024960", Offset = "0x6022F60", VA = "0x186024960")]
	internal static bool POEFOKGLMMH(float IKAMJBDPPHG, float LKLEFAIICIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x14C9AB0", Offset = "0x14C80B0", VA = "0x1814C9AB0")]
	internal static float OBHJNKNMFEJ(float IKAMJBDPPHG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x60248A0", Offset = "0x6022EA0", VA = "0x1860248A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F86F0", Offset = "0x9F6CF0", VA = "0x1809F86F0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x6020EC0", Offset = "0x601F4C0", VA = "0x186020EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event OOHNJLLKJKP BOMFJCMHNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6021020", Offset = "0x601F620", VA = "0x186021020", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6020F80", Offset = "0x601F580", VA = "0x186020F80", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public IKHDPONDBON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class KGKIFCOAOID
{
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6021A60", Offset = "0x6020060", VA = "0x186021A60")]
	[NotNull]
	public static byte[] BJKBMJFHFBC(this ECOILECAPEP EILJKFHPELP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x60219F0", Offset = "0x601FFF0", VA = "0x1860219F0")]
	[NotNull]
	public static byte[] BJKBMJFHFBC(this ECOILECAPEP EILJKFHPELP, HashAlgorithmName FEHIEOHKAKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6021C70", Offset = "0x6020270", VA = "0x186021C70")]
	public static bool DGJAEEMELCH([CanBeNull] this ECOILECAPEP EILJKFHPELP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6021AD0", Offset = "0x60200D0", VA = "0x186021AD0")]
	public static bool DGJAEEMELCH([CanBeNull] this ECOILECAPEP EILJKFHPELP, out string OOMNIJBIFDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6021F20", Offset = "0x6020520", VA = "0x186021F20")]
	private static string HJEMCGICJMM([CanBeNull] byte[] PPJLGCLGPJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6021E00", Offset = "0x6020400", VA = "0x186021E00")]
	private static bool GIMALLCAFMK([NotNull] ECOILECAPEP EILJKFHPELP, [CanBeNull] out byte[] EGDKJDNBEFE, [CanBeNull] out byte[] FIIDHBLMLOE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class FBAOPPDKBFC
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x601F600", Offset = "0x601DC00", VA = "0x18601F600")]
	[NotNull]
	public static byte[] BJKBMJFHFBC(this NBMFECGHEHI NIGMFGAHEGM, byte[] PMKNAHPIBFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x601F640", Offset = "0x601DC40", VA = "0x18601F640")]
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
		[Cpp2IlInjected.Address(RVA = "0x6021230", Offset = "0x601F830", VA = "0x186021230")]
		public IPFBPGHEMIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x60211D0", Offset = "0x601F7D0", VA = "0x1860211D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4476950", Offset = "0x4474F50", VA = "0x184476950")]
	[Conditional("UNITY_EDITOR")]
	private static void LJANPNJINJL<T>(params T[] ANNJCJHIHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6023250", Offset = "0x6021850", VA = "0x186023250")]
	public static IDisposable JBNJJJAANNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6023360", Offset = "0x6021960", VA = "0x186023360")]
	public static void MKNMHEFCOED(this IncrementalHash HCJBOJAANGO, [CanBeNull] GameObject EHEABJNEALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x4476C40", Offset = "0x4475240", VA = "0x184476C40")]
	public static void MKNMHEFCOED<T>(this IncrementalHash HCJBOJAANGO, [CanBeNull] T AALANACCLGM) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x44761D0", Offset = "0x44747D0", VA = "0x1844761D0")]
	public static void GOJBIADPPMN<T>(this IncrementalHash HCJBOJAANGO, [CanBeNull] T NIGMFGAHEGM) where T : NBMFECGHEHI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x4475D70", Offset = "0x4474370", VA = "0x184475D70")]
	public static void DOOKOPOHBBN<T>(this IncrementalHash HCJBOJAANGO, [CanBeNull] IList<T> AFNILCHGKFB) where T : NBMFECGHEHI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6022850", Offset = "0x6020E50", VA = "0x186022850")]
	private static bool AMONLGEGCDG([CanBeNull] NBMFECGHEHI NIGMFGAHEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6022E60", Offset = "0x6021460", VA = "0x186022E60")]
	public static void FCLMCFNAPDJ(this IncrementalHash ECCMGNHBKIL, [CanBeNull] string KDLMPPJJELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6022B20", Offset = "0x6021120", VA = "0x186022B20")]
	public static void CONPHABDNEI(this IncrementalHash ECCMGNHBKIL, long DECMILFNAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x60228E0", Offset = "0x6020EE0", VA = "0x1860228E0")]
	public static void AOKPDAMMMDC(this IncrementalHash ECCMGNHBKIL, int MFHOJLOFIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x60236E0", Offset = "0x6021CE0", VA = "0x1860236E0")]
	public static void ONJGPGGAAEP(this IncrementalHash ECCMGNHBKIL, short OJMGOIPAPAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6022CF0", Offset = "0x60212F0", VA = "0x186022CF0")]
	public static void EFANKHEGIJH(this IncrementalHash ECCMGNHBKIL, byte AAOMPDMLJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x60234B0", Offset = "0x6021AB0", VA = "0x1860234B0")]
	public static void NFGJJDKHLOG(this IncrementalHash ECCMGNHBKIL, bool IJFFHGFJGFP, bool LGPLAOGCEOF = false, bool MMALKLKCCHK = false, bool GFLECIHMMNO = false, bool NDJGGJKKFDG = false, bool FELOPOHFBOF = false, bool GPNDHNEOAOH = false, bool EJLFDPKNNBC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x4476260", Offset = "0x4474860", VA = "0x184476260")]
	public static void LABAPOMDFGM<T>(this IncrementalHash ECCMGNHBKIL, T AOKJAINPPBI) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6023450", Offset = "0x6021A50", VA = "0x186023450")]
	public static void MOGCNLIGMOO(this IncrementalHash ECCMGNHBKIL, float ABDNBEJOKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6023680", Offset = "0x6021C80", VA = "0x186023680")]
	public static void NNLLNKJAHLD(this IncrementalHash ECCMGNHBKIL, double CAOHMGJLGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6022AB0", Offset = "0x60210B0", VA = "0x186022AB0")]
	public static void BGMPDDNPLAG(this IncrementalHash ECCMGNHBKIL, ulong EFFMHOAJCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6023030", Offset = "0x6021630", VA = "0x186023030")]
	public static void IEJLONKKDKB(this IncrementalHash ECCMGNHBKIL, uint JLFBDPMFDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x60232F0", Offset = "0x60218F0", VA = "0x1860232F0")]
	public static void KDHAAHFCLLB(this IncrementalHash ECCMGNHBKIL, ushort GINMPNEGLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6022EC0", Offset = "0x60214C0", VA = "0x186022EC0")]
	public static void HKOCMONNFDC(this IncrementalHash ECCMGNHBKIL, Vector3 HNEJEJCMCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6023090", Offset = "0x6021690", VA = "0x186023090")]
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
	[Cpp2IlInjected.Address(RVA = "0x6024730", Offset = "0x6022D30", VA = "0x186024730")]
	public ODMBFKEDGEL(Type FLEMACEHAPO, string BKKDIDMLLFG, bool KBIGAAHLLEB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class DLFJMKEBAAG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x601F540", Offset = "0x601DB40", VA = "0x18601F540")]
	public DLFJMKEBAAG(string DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x601F4C0", Offset = "0x601DAC0", VA = "0x18601F4C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x695660", Offset = "0x693C60", VA = "0x180695660")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x777490", Offset = "0x775A90", VA = "0x180777490")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int LJOFAPCHBHE, int OMAAILJEECD]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x4167E90", Offset = "0x4166490", VA = "0x184167E90")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x4167F30", Offset = "0x4166530", VA = "0x184167F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x4167E00", Offset = "0x4166400", VA = "0x184167E00")]
		public Array2D(uint LEFBNKJDKNL, uint ELIEMKLAFPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x4167D80", Offset = "0x4166380", VA = "0x184167D80")]
		public void PGHHBKOCHPM()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x601E330", Offset = "0x601C930", VA = "0x18601E330")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DAFDC0", Offset = "0x3DAE3C0", VA = "0x183DAFDC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x4533140", Offset = "0x4531740", VA = "0x184533140")]
	public MCPCGCNIBLF(Action<TValue> MFIHNAIHJDF, [Optional] Func<TValue> HLCEOPOLEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x45329C0", Offset = "0x4530FC0", VA = "0x1845329C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x45325D0", Offset = "0x4530BD0", VA = "0x1845325D0")]
	public THandle CBFHJGEFJHE()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x4532F10", Offset = "0x4531510", VA = "0x184532F10")]
	public THandle MFMCNFFMIAP(TValue MAKFNMHIJIF)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x4532A80", Offset = "0x4531080", VA = "0x184532A80")]
	public bool EMIFMEAGDDE(THandle ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x4532C10", Offset = "0x4531210", VA = "0x184532C10")]
	public bool GGPEMOPMMCE(THandle ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x45327F0", Offset = "0x4530DF0", VA = "0x1845327F0")]
	public bool DJEIEOEOGPA(THandle ODMNDKFKJHN, out TValue MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x4532890", Offset = "0x4530E90", VA = "0x184532890")]
	public TValue DNJGGIFCOKL(THandle ODMNDKFKJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x4532910", Offset = "0x4530F10", VA = "0x184532910")]
	public bool DPFPNIAFGMD(THandle ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x45328E0", Offset = "0x4530EE0", VA = "0x1845328E0")]
	private THandle DOIDECLDOIC(int EBBLFLFCHFB)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x4532CE0", Offset = "0x45312E0", VA = "0x184532CE0")]
	private TValue IHBCBCAIMIC(int EBBLFLFCHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x4532A40", Offset = "0x4531040", VA = "0x184532A40")]
	private void EKLAELDPIGA(int EBBLFLFCHFB, in THandle ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x45327B0", Offset = "0x4530DB0", VA = "0x1845327B0")]
	private void CKBOMKNNBHG(int EBBLFLFCHFB, in TValue MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x4533030", Offset = "0x4531630", VA = "0x184533030")]
	private THandle PHFDOILMBOA()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x4532F80", Offset = "0x4531580", VA = "0x184532F80")]
	private void OCLOHIPKDCJ(THandle ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x4532D10", Offset = "0x4531310", VA = "0x184532D10")]
	private int JAFIBKELMNB(int AJGHIJIKOBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x45325C0", Offset = "0x4530BC0", VA = "0x1845325C0")]
	private bool ACCCDHLNJKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x98DA50", Offset = "0x98C050", VA = "0x18098DA50")]
	private void PMNKDBAKHPN(THandle ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x4532B30", Offset = "0x4531130", VA = "0x184532B30")]
	private bool FMJJCKPDKGH(out THandle ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x4532E40", Offset = "0x4531440", VA = "0x184532E40")]
	private bool LOBAKCMDLGA(out THandle ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x4532BB0", Offset = "0x45311B0", VA = "0x184532BB0")]
	private void FNACONNAFLO(THandle ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x4532D20", Offset = "0x4531320", VA = "0x184532D20")]
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
	[Cpp2IlInjected.Address(RVA = "0x18EA6B0", Offset = "0x18E8CB0", VA = "0x1818EA6B0")]
	public static bool NACDKJIFFFI<T>(this T ODMNDKFKJHN, T OANENNOJEBB) where T : struct, LDGEBNEMAMI
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x33C2D50", Offset = "0x33C1350", VA = "0x1833C2D50")]
	public static bool DEHMHJNDOKD<T>(this T ODMNDKFKJHN) where T : struct, LDGEBNEMAMI
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x60210C0", Offset = "0x601F6C0", VA = "0x1860210C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x601F1B0", Offset = "0x601D7B0", VA = "0x18601F1B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool MBBANKOLFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x601E630", Offset = "0x601CC30", VA = "0x18601E630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x601F280", Offset = "0x601D880", VA = "0x18601F280")]
	public BCAKKLDEJBK(bool KEDLJMBPGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x601E640", Offset = "0x601CC40", VA = "0x18601E640")]
	public void IGEJOACLPAO(object LGKNNMGLNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x601E590", Offset = "0x601CB90", VA = "0x18601E590")]
	public void GGJAALDKKAO(int MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x601ED30", Offset = "0x601D330", VA = "0x18601ED30")]
	public void KHPAONBDDCA(uint CMFNPEENAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x601E3D0", Offset = "0x601C9D0", VA = "0x18601E3D0")]
	public void CIDPANDJGAJ(bool GFGHAEEEKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x601E390", Offset = "0x601C990", VA = "0x18601E390")]
	public void CDKFOPGMBJN(long EDNJKCLGGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x601F230", Offset = "0x601D830", VA = "0x18601F230")]
	public void PAGCBEMODKK(ulong OCIEPMHGJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x601ECC0", Offset = "0x601D2C0", VA = "0x18601ECC0")]
	public void KBGKLICOPBA(string FLFBAMENJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x601ED40", Offset = "0x601D340", VA = "0x18601ED40")]
	public void MHEPDNEFJNO(Enum CNABBHHIHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x601E3F0", Offset = "0x601C9F0", VA = "0x18601E3F0")]
	public void EAAOMEOPGPP(IList ACLENHAHHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x33AFAE0", Offset = "0x33AE0E0", VA = "0x1833AFAE0")]
	public void IJDNEAKDBIE<T, U>(Dictionary<T, U> GKDAPMHFKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x601EDD0", Offset = "0x601D3D0", VA = "0x18601EDD0")]
	private void NFKMHBENHBD(IDictionary GKDAPMHFKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x601F140", Offset = "0x601D740", VA = "0x18601F140")]
	public int OBCDNHOIKEG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x601E520", Offset = "0x601CB20", VA = "0x18601E520")]
	public short FHPKHBHIDIO()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x601F270", Offset = "0x601D870", VA = "0x18601F270")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x601F1C0", Offset = "0x601D7C0", VA = "0x18601F1C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D2FE0", Offset = "0x8D15E0", VA = "0x1808D2FE0")]
		public KKMMBHGNJPK(int IPGJOMPJEJJ, TClaimant FJEAGLNJIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x3463C10", Offset = "0x3462210", VA = "0x183463C10")]
		public bool IABHICHANOJ(in KKMMBHGNJPK OANENNOJEBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x3463C70", Offset = "0x3462270", VA = "0x183463C70")]
		public bool POKDPOHIMFL(in KKMMBHGNJPK OANENNOJEBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x3463C00", Offset = "0x3462200", VA = "0x183463C00", Slot = "4")]
		public int CompareTo(KKMMBHGNJPK OANENNOJEBB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x3463C80", Offset = "0x3462280", VA = "0x183463C80", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x2FFD5E0", Offset = "0x2FFBBE0", VA = "0x182FFD5E0")]
		[DebuggerHidden]
		public KIFJGMDMLML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x344F8E0", Offset = "0x344DEE0", VA = "0x18344F8E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x344FAA0", Offset = "0x344E0A0", VA = "0x18344FAA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x344F9C0", Offset = "0x344DFC0", VA = "0x18344F9C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x2344D60", Offset = "0x2343360", VA = "0x182344D60", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E9ED90", Offset = "0x3E9D390", VA = "0x183E9ED90")]
	public OEFJLGMAFKB(EHBGGPNGMGB OLBBMHHLPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x3E9E860", Offset = "0x3E9CE60", VA = "0x183E9E860")]
	public void MJDBLNOJKMG(TNode ELOCLFMIMAL, TNode EBIGGMLCEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3E9E250", Offset = "0x3E9C850", VA = "0x183E9E250")]
	public void HIMLOJILFDG(TClaimant FJEAGLNJIBC, TNode DFJNDOHLODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x3E9DB80", Offset = "0x3E9C180", VA = "0x183E9DB80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x3E9DE40", Offset = "0x3E9C440", VA = "0x183E9DE40")]
	private void GMJHKFGHLEL(TClaimant FJEAGLNJIBC, TNode HAMBJOBGGEI, TNode DFJNDOHLODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x3E9DDE0", Offset = "0x3E9C3E0", VA = "0x183E9DDE0")]
	private int EBHCKINCHKK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x3E9D640", Offset = "0x3E9BC40", VA = "0x183E9D640")]
	private void BBNLBOMBKAK(TClaimant FJEAGLNJIBC, TNode AKNMMMMELFH, TNode EGGHGELDMAI, int BCMLLFOABBC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x3E9E6C0", Offset = "0x3E9CCC0", VA = "0x183E9E6C0")]
	private void IPJGGBMJLAI(KKMMBHGNJPK HEOKMMJOMEO, HJPFCJGKJPC EOJBPKALALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3E9E350", Offset = "0x3E9C950", VA = "0x183E9E350")]
	private void HMKAHEIMBCK(TClaimant FJEAGLNJIBC, TNode AKNMMMMELFH, TNode EGGHGELDMAI, int BCMLLFOABBC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3E9E5B0", Offset = "0x3E9CBB0", VA = "0x183E9E5B0")]
	private void HNJDKEKLIGI(KKMMBHGNJPK HEOKMMJOMEO, TNode ELOCLFMIMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x3E9D8F0", Offset = "0x3E9BEF0", VA = "0x183E9D8F0")]
	private void BNNHEICBFAP(KKMMBHGNJPK HEOKMMJOMEO, HJPFCJGKJPC EOJBPKALALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3E9E750", Offset = "0x3E9CD50", VA = "0x183E9E750")]
	private void KBKEHFLBCLA(HJPFCJGKJPC EOJBPKALALP, bool MENJEIPMLFN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x3E9DEE0", Offset = "0x3E9C4E0", VA = "0x183E9DEE0")]
	private void HEGDJKAIPBP(HJPFCJGKJPC EOJBPKALALP, TNode EBIGGMLCEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x3E9E8E0", Offset = "0x3E9CEE0", VA = "0x183E9E8E0")]
	[IteratorStateMachine(typeof(global::OEFJLGMAFKB<, >.KIFJGMDMLML))]
	private IEnumerable<TNode> MOMPKGECPDH(TNode AKNMMMMELFH, TNode EGGHGELDMAI, bool MOLGOHNOGOA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x3E9EB70", Offset = "0x3E9D170", VA = "0x183E9EB70")]
	private HJPFCJGKJPC OKANIOOALDF(TNode ELOCLFMIMAL, TNode LFAIGCEGCPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x3E9D9F0", Offset = "0x3E9BFF0", VA = "0x183E9D9F0")]
	private HJPFCJGKJPC DJIGDJJGHPI(TNode ELOCLFMIMAL, TNode LFAIGCEGCPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3E9E9B0", Offset = "0x3E9CFB0", VA = "0x183E9E9B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x229AE30", Offset = "0x2299430", VA = "0x18229AE30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public JCGAALIHFEC BMLOECHOMBO
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x3B570C0", Offset = "0x3B556C0", VA = "0x183B570C0", Slot = "4")]
			get
			{
				return default(JCGAALIHFEC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8563F0", Offset = "0x8549F0", VA = "0x1808563F0")]
		public MLGBKNNBLID(global::NGIJOHKPMMH<T> BLDLHAOGGDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x3B57040", Offset = "0x3B55640", VA = "0x183B57040", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8563E0", Offset = "0x8549E0", VA = "0x1808563E0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xF25DB0", Offset = "0xF243B0", VA = "0x180F25DB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x83C670", Offset = "0x83AC70", VA = "0x18083C670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x83C680", Offset = "0x83AC80", VA = "0x18083C680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7140", Offset = "0x2DD5740", VA = "0x182DD7140")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x394ADB0", Offset = "0x39493B0", VA = "0x18394ADB0")]
	public NGIJOHKPMMH(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x394B290", Offset = "0x3949890", VA = "0x18394B290")]
	public NGIJOHKPMMH(JCGAALIHFEC[] HJKDLBPJPBF, bool BCIAEBEODEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x394A920", Offset = "0x3948F20", VA = "0x18394A920")]
	public int KHNELHCEHCN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3949BF0", Offset = "0x39481F0", VA = "0x183949BF0")]
	private int DPKIEIPLOAG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x394A110", Offset = "0x3948710", VA = "0x18394A110", Slot = "6")]
	protected virtual uint EKEMOIMKPIB(uint ECCMGNHBKIL, T MAKFNMHIJIF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x3949DF0", Offset = "0x39483F0", VA = "0x183949DF0")]
	public bool ECFOPOGDNHI(T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x39499B0", Offset = "0x3947FB0", VA = "0x1839499B0")]
	public bool BCFBEIKJAEM(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x394A6E0", Offset = "0x3948CE0", VA = "0x18394A6E0")]
	public bool HEBLGIOGKGC(Func<T, bool> LBGOBMKAOKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x394A9E0", Offset = "0x3948FE0", VA = "0x18394A9E0")]
	public int LBOLLNKDDHK(T MAKFNMHIJIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x394A8C0", Offset = "0x3948EC0", VA = "0x18394A8C0")]
	public T IHBCBCAIMIC(int EBBLFLFCHFB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x394ACB0", Offset = "0x39492B0", VA = "0x18394ACB0")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x394A470", Offset = "0x3948A70", VA = "0x18394A470")]
	public bool FKGKAEHMBPL(T MAKFNMHIJIF, bool EOAICLNBGGE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x394A4B0", Offset = "0x3948AB0", VA = "0x18394A4B0")]
	public bool FKGKAEHMBPL(T MAKFNMHIJIF, int EBBLFLFCHFB, bool EOAICLNBGGE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x394A160", Offset = "0x3948760", VA = "0x18394A160")]
	public bool EMIFMEAGDDE(T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3949910", Offset = "0x3947F10", VA = "0x183949910")]
	public bool APBNDDFINKH(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x394AA40", Offset = "0x3949040", VA = "0x18394AA40")]
	private void LCFIBBDBNFE(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x3949FD0", Offset = "0x39485D0", VA = "0x183949FD0")]
	public JCGAALIHFEC[] EGJGLNFOKNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x394AC60", Offset = "0x3949260", VA = "0x18394AC60")]
	private int NHFDCMNKNKJ(int LGAFDCAKAMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x394AD30", Offset = "0x3949330", VA = "0x18394AD30", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x394AD30", Offset = "0x3949330", VA = "0x18394AD30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EF3620", Offset = "0x3EF1C20", VA = "0x183EF3620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle GFEBJBJDFMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x3EF3180", Offset = "0x3EF1780", VA = "0x183EF3180")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x3EF3820", Offset = "0x3EF1E20", VA = "0x183EF3820")]
		public JLLOHMJAHNH(global::ANKGGOGGJGH<Handle> NACBNKAHJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x3EF3380", Offset = "0x3EF1980", VA = "0x183EF3380")]
		public JDMIPIODAMK OJKIKDBCCPC(in JDMIPIODAMK IBHBGBEBHJM)
		{
			return default(JDMIPIODAMK);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x3EF32E0", Offset = "0x3EF18E0", VA = "0x183EF32E0")]
		public AEIHIGMIJCC OJKIKDBCCPC(in AEIHIGMIJCC IBHBGBEBHJM)
		{
			return default(AEIHIGMIJCC);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x3EF28E0", Offset = "0x3EF0EE0", VA = "0x183EF28E0")]
		public bool CKMCKKHDBJB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x3EF2840", Offset = "0x3EF0E40", VA = "0x183EF2840")]
		private int BOOPGCLKGFA(string DIDMFBHHIEC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x3EF2700", Offset = "0x3EF0D00", VA = "0x183EF2700")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DB7CD0", Offset = "0x3DB62D0", VA = "0x183DB7CD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x3DB7DD0", Offset = "0x3DB63D0", VA = "0x183DB7DD0")]
		public JDMIPIODAMK(global::ANKGGOGGJGH<Handle> NACBNKAHJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x3DB7BD0", Offset = "0x3DB61D0", VA = "0x183DB7BD0")]
		public bool CKMCKKHDBJB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x3DB7B50", Offset = "0x3DB6150", VA = "0x183DB7B50")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E23E90", Offset = "0x3E22490", VA = "0x183E23E90")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x3DB7DD0", Offset = "0x3DB63D0", VA = "0x183DB7DD0")]
		public AEIHIGMIJCC(global::ANKGGOGGJGH<Handle> NACBNKAHJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x3DB7BD0", Offset = "0x3DB61D0", VA = "0x183DB7BD0")]
		public bool CKMCKKHDBJB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x3E23DD0", Offset = "0x3E223D0", VA = "0x183E23DD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84A610", Offset = "0x848C10", VA = "0x18084A610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int KMFAFOCNGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x423F720", Offset = "0x423DD20", VA = "0x18423F720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int KIKMIHMFFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x70F350", Offset = "0x70D950", VA = "0x18070F350")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int PACLCIBBJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x70F350", Offset = "0x70D950", VA = "0x18070F350")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public JDMIPIODAMK HEOEFKAKLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x423C620", Offset = "0x423AC20", VA = "0x18423C620")]
		get
		{
			return default(JDMIPIODAMK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public AEIHIGMIJCC NLDGMAPEKAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x42405C0", Offset = "0x423EBC0", VA = "0x1842405C0")]
		get
		{
			return default(AEIHIGMIJCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x4240D20", Offset = "0x423F320", VA = "0x184240D20")]
	public ANKGGOGGJGH(int PLJBLNIOMOD, Allocator GGLOKAHPEPM = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x423C900", Offset = "0x423AF00", VA = "0x18423C900")]
	public void BOHBKACNFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x20DD8A0", Offset = "0x20DBEA0", VA = "0x1820DD8A0")]
	public static int JAFIBKELMNB(int HIGLPPEBKMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x423EFD0", Offset = "0x423D5D0", VA = "0x18423EFD0")]
	public static bool JBMCKHGPAOG(int HIGLPPEBKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x423E390", Offset = "0x423C990", VA = "0x18423E390")]
	public static bool IMEABOMMBBB(int HIGLPPEBKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x4240140", Offset = "0x423E740", VA = "0x184240140")]
	public bool OEEHHDLPCKK(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x4240660", Offset = "0x423EC60", VA = "0x184240660")]
	public bool OMDBJOFJKNF(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x423D380", Offset = "0x423B980", VA = "0x18423D380")]
	public bool FOKHJJDOFFH(Handle ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x423D750", Offset = "0x423BD50", VA = "0x18423D750")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void HHOHMINLNPM(Handle ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x423CE30", Offset = "0x423B430", VA = "0x18423CE30")]
	public Handle EJCNOCAMALL()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x423E9D0", Offset = "0x423CFD0", VA = "0x18423E9D0")]
	public void IODDGDFPLFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x423FC60", Offset = "0x423E260", VA = "0x18423FC60")]
	public void NHCNMOFPIOH(Handle ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x423D490", Offset = "0x423BA90", VA = "0x18423D490")]
	public bool FPNGMEIBKBN(Handle ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x84A610", Offset = "0x848C10", VA = "0x18084A610")]
	private bool KNHGNLCGJBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x423EFE0", Offset = "0x423D5E0", VA = "0x18423EFE0")]
	private bool JKNPGANNAME(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x423F2D0", Offset = "0x423D8D0", VA = "0x18423F2D0")]
	private void JPMALOLHGBO(out int EBBLFLFCHFB, out int AJGHIJIKOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x423FF40", Offset = "0x423E540", VA = "0x18423FF40")]
	private void NPHDHDNIOGO(Handle ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x423CBF0", Offset = "0x423B1F0", VA = "0x18423CBF0")]
	private void DGIPPHFJIDE(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x423FA30", Offset = "0x423E030", VA = "0x18423FA30")]
	private bool MJELFMPEKHP(out int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x423C9C0", Offset = "0x423AFC0", VA = "0x18423C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F990F0", Offset = "0x3F976F0", VA = "0x183F990F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int KMFAFOCNGGD
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x3F97FF0", Offset = "0x3F965F0", VA = "0x183F97FF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x3F990C0", Offset = "0x3F976C0", VA = "0x183F990C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x3F97E80", Offset = "0x3F96480", VA = "0x183F97E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x3F994F0", Offset = "0x3F97AF0", VA = "0x183F994F0")]
	public BGFDJNFLFAN(int PLJBLNIOMOD, [Optional] Action<T> KFONKFCCOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x3F96300", Offset = "0x3F94900", VA = "0x183F96300")]
	public void BOHBKACNFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x3F97E30", Offset = "0x3F96430", VA = "0x183F97E30")]
	public bool FOKHJJDOFFH(Handle ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void HHOHMINLNPM(Handle ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x3F96E50", Offset = "0x3F95450", VA = "0x183F96E50")]
	public T DNJGGIFCOKL(Handle ODMNDKFKJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x3F96B60", Offset = "0x3F95160", VA = "0x183F96B60")]
	public bool DJEIEOEOGPA(Handle ODMNDKFKJHN, out T LGKNNMGLNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x3F988B0", Offset = "0x3F96EB0", VA = "0x183F988B0")]
	public void KMNEKDAGPNL(Handle ODMNDKFKJHN, T MBCDHJMNIAB, out T EMJDPHLDGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x3F98950", Offset = "0x3F96F50", VA = "0x183F98950")]
	public void KMNEKDAGPNL(Handle ODMNDKFKJHN, T MBCDHJMNIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x3F97960", Offset = "0x3F95F60", VA = "0x183F97960")]
	public bool FFFKFHDEEJJ(Handle ODMNDKFKJHN, T MBCDHJMNIAB, out T EMJDPHLDGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x3F97B40", Offset = "0x3F96140", VA = "0x183F97B40")]
	public bool FFFKFHDEEJJ(Handle ODMNDKFKJHN, T MBCDHJMNIAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x3F98C90", Offset = "0x3F97290", VA = "0x183F98C90")]
	public Handle MFMCNFFMIAP(T LGKNNMGLNIA)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x3F98450", Offset = "0x3F96A50", VA = "0x183F98450")]
	public void KCBMKPEBDJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x3F97360", Offset = "0x3F95960", VA = "0x183F97360")]
	public void EMIFMEAGDDE(Handle ODMNDKFKJHN, out T EMJDPHLDGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x3F97500", Offset = "0x3F95B00", VA = "0x183F97500")]
	public void EMIFMEAGDDE(Handle ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x3F965E0", Offset = "0x3F94BE0", VA = "0x183F965E0")]
	public bool CPPINAJNHMI(Handle ODMNDKFKJHN, out T EMJDPHLDGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x3F967E0", Offset = "0x3F94DE0", VA = "0x183F967E0")]
	public bool CPPINAJNHMI(Handle ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x3F96180", Offset = "0x3F94780", VA = "0x183F96180")]
	private T APBNDDFINKH(int EBBLFLFCHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x3F99120", Offset = "0x3F97720", VA = "0x183F99120")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C15CA0", Offset = "0x2C142A0", VA = "0x182C15CA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int MCFEBJJFOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x329DF60", Offset = "0x329C560", VA = "0x18329DF60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x3EA3900", Offset = "0x3EA1F00", VA = "0x183EA3900")]
	public static global::OHEBPJCKCKG<T> BEKHMELEDAB(int FHGNFGIEADL = 0, int LNMFHOCNGJJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x3EA3F30", Offset = "0x3EA2530", VA = "0x183EA3F30")]
	public static global::OHEBPJCKCKG<T> LLJDFNMKOIC(int FHGNFGIEADL = 0, int LNMFHOCNGJJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x3EA40D0", Offset = "0x3EA26D0", VA = "0x183EA40D0")]
	public OHEBPJCKCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x3EA4110", Offset = "0x3EA2710", VA = "0x183EA4110")]
	public OHEBPJCKCKG(int FHGNFGIEADL, int LNMFHOCNGJJ = int.MaxValue, bool OMPNOHHJNEG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x3EA39D0", Offset = "0x3EA1FD0", VA = "0x183EA39D0")]
	public T DLOPPNFOCOA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x3EA3C60", Offset = "0x3EA2260", VA = "0x183EA3C60")]
	public void ENCBMHFAOCP(T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x3EA4000", Offset = "0x3EA2600", VA = "0x183EA4000")]
	private void OMIJDNEBJGM(T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x3EA38E0", Offset = "0x3EA1EE0", VA = "0x183EA38E0")]
	private void BEBFIBFIPPD(T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x3EA3D10", Offset = "0x3EA2310", VA = "0x183EA3D10")]
	[Conditional("DEBUG_BUILD")]
	private void HJPACKAPJHN(T JPIDECFHPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x3EA3BD0", Offset = "0x3EA21D0", VA = "0x183EA3BD0")]
	[Conditional("DEBUG_BUILD")]
	private void ELKDFJJGKHC(T JPIDECFHPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x3EA3AE0", Offset = "0x3EA20E0", VA = "0x183EA3AE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x3EA3D90", Offset = "0x3EA2390", VA = "0x183EA3D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x728F30", Offset = "0x727530", VA = "0x180728F30", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool MMPPENFBFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x3BE69D0", Offset = "0x3BE4FD0", VA = "0x183BE69D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x3BE6E30", Offset = "0x3BE5430", VA = "0x183BE6E30")]
	public bool OGKJCDPEKGH(T MAKFNMHIJIF, int IPGJOMPJEJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3BE6970", Offset = "0x3BE4F70", VA = "0x183BE6970")]
	public bool BJHOJHPKHGP(int IPGJOMPJEJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x3BE6C40", Offset = "0x3BE5240", VA = "0x183BE6C40")]
	public T MLKPGDKPOJF(int FDDNEAODHIB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x3BE6EF0", Offset = "0x3BE54F0", VA = "0x183BE6EF0")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x3BE67D0", Offset = "0x3BE4DD0", VA = "0x183BE67D0")]
	private bool APJDPKMJMFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x3BE6A10", Offset = "0x3BE5010", VA = "0x183BE6A10")]
	public bool IDEDABPJLGL(int IPGJOMPJEJJ, out T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x3BE6F50", Offset = "0x3BE5550", VA = "0x183BE6F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DD7140", Offset = "0x2DD5740", VA = "0x182DD7140")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3B533B0", Offset = "0x3B519B0", VA = "0x183B533B0")]
	public bool HEBLGIOGKGC(T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3B53630", Offset = "0x3B51C30", VA = "0x183B53630")]
	public void MFMCNFFMIAP(T MAKFNMHIJIF, int IPGJOMPJEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x3B53290", Offset = "0x3B51890", VA = "0x183B53290")]
	public bool EMIFMEAGDDE(T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x3B53890", Offset = "0x3B51E90", VA = "0x183B53890")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x3B535C0", Offset = "0x3B51BC0", VA = "0x183B535C0")]
	public T LPPJAHJFKKB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x3B53220", Offset = "0x3B51820", VA = "0x183B53220")]
	public T EFOLMBHNDHM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x3B536D0", Offset = "0x3B51CD0", VA = "0x183B536D0")]
	private void NCKEKOFMLJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x3B538F0", Offset = "0x3B51EF0", VA = "0x183B538F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6025710", Offset = "0x6023D10", VA = "0x186025710")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x6025AA0", Offset = "0x60240A0", VA = "0x186025AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x6025920", Offset = "0x6023F20", VA = "0x186025920")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x6025C00", Offset = "0x6024200", VA = "0x186025C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x6025630", Offset = "0x6023C30", VA = "0x186025630")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x60259C0", Offset = "0x6023FC0", VA = "0x1860259C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x6025840", Offset = "0x6023E40", VA = "0x186025840")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x60255E0", Offset = "0x6023BE0", VA = "0x1860255E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x35F21D0", Offset = "0x35F07D0", VA = "0x1835F21D0", Slot = "4")]
		public virtual T LGJMCPOMIOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x71E880", Offset = "0x71CE80", VA = "0x18071E880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 PHODGNBGFDM
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xD5B250", Offset = "0xD59850", VA = "0x180D5B250")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x936FB0", Offset = "0x9355B0", VA = "0x180936FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 FNHNFLDJGAP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x1138DC0", Offset = "0x11373C0", VA = "0x181138DC0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x728EC0", Offset = "0x7274C0", VA = "0x180728EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 LHLHNODKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x6024BC0", Offset = "0x60231C0", VA = "0x186024BC0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x7226A0", Offset = "0x720CA0", VA = "0x1807226A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int KPBOFPENJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x852590", Offset = "0x850B90", VA = "0x180852590")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x98DA50", Offset = "0x98C050", VA = "0x18098DA50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x60250E0", Offset = "0x60236E0", VA = "0x1860250E0")]
	public PDPFLNOPKKH(Bounds MKJEBMJBNGG, Vector2[] NAPEDCMJDNN, int LOCJNHPLLBM, byte LGAFDCAKAMG, float OBHHMOHGHDE = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6024B40", Offset = "0x6023140", VA = "0x186024B40")]
	public HNGACIELLJC CBICBFIDBKD(byte EBBLFLFCHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x6024FE0", Offset = "0x60235E0", VA = "0x186024FE0")]
	public void MFPBNIJEBND(Vector3 EINGNKDKDHC, float IMKCGPGMDMF, float IMALJJABLAD, ref List<byte> LKOKGPNCGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x6024BA0", Offset = "0x60231A0", VA = "0x186024BA0")]
	public void EHFEOKAOPHD(HNGACIELLJC.NDNACBCDLGI JDJOHDKLJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x60249E0", Offset = "0x6022FE0", VA = "0x1860249E0")]
	private HNGACIELLJC BANDPGBBIJP(byte EBBLFLFCHFB, HNGACIELLJC.NIPLOEGKMKP MMLILHDNNPP, HNGACIELLJC LFAIGCEGCPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6024BE0", Offset = "0x60231E0", VA = "0x186024BE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x60208F0", Offset = "0x601EEF0", VA = "0x1860208F0")]
	public HNGACIELLJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x6020910", Offset = "0x601EF10", VA = "0x186020910")]
	public HNGACIELLJC(byte CBBOJGIJLHN, NIPLOEGKMKP MMLILHDNNPP, HNGACIELLJC LFAIGCEGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x6020830", Offset = "0x601EE30", VA = "0x186020830")]
	public void OPJJCFHECII(HNGACIELLJC IMDKOHMGEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	public void EHFEOKAOPHD(int GONGBLMKLJK, NDNACBCDLGI JDJOHDKLJNM, int JDGEMNDPNNE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6020580", Offset = "0x601EB80", VA = "0x186020580")]
	public void MFPBNIJEBND(List<byte> LKOKGPNCGAJ, Vector3 EINGNKDKDHC, float IMKCGPGMDMF, float IMALJJABLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x60204F0", Offset = "0x601EAF0", VA = "0x1860204F0")]
	public bool ANGAJPCJIFO(Vector3 IGAJPNPGFIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6020540", Offset = "0x601EB40", VA = "0x186020540")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C163A0", Offset = "0x2C149A0", VA = "0x182C163A0")]
	public bool EBNIBDHMIKC(T FFLGINHJFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x4BCFBF0", Offset = "0x4BCE1F0", VA = "0x184BCFBF0")]
	public bool EBNIBDHMIKC(T FFLGINHJFHB, object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x4BCFC30", Offset = "0x4BCE230", VA = "0x184BCFC30")]
	public bool EBNIBDHMIKC(T FFLGINHJFHB, object HKLDIENGNNB, out object EAJBBDKNLHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x4BCFD90", Offset = "0x4BCE390", VA = "0x184BCFD90")]
	public bool JNEANDEICAG(T FFLGINHJFHB, object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x4BCFCC0", Offset = "0x4BCE2C0", VA = "0x184BCFCC0")]
	public bool FPCBCAODKIJ(T FFLGINHJFHB, object HKLDIENGNNB, out object EAJBBDKNLHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x4BCFD00", Offset = "0x4BCE300", VA = "0x184BCFD00")]
	public bool JNEANDEICAG(T FFLGINHJFHB, object HKLDIENGNNB, out object EAJBBDKNLHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x4BCFC90", Offset = "0x4BCE290", VA = "0x184BCFC90")]
	public void EFLNHNAEDNM(T FFLGINHJFHB, object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x4BCFDD0", Offset = "0x4BCE3D0", VA = "0x184BCFDD0")]
	public void ODJFOAJGBMP(T FFLGINHJFHB, object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x4BCFE70", Offset = "0x4BCE470", VA = "0x184BCFE70")]
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
			[Cpp2IlInjected.Address(RVA = "0xFDA160", Offset = "0xFD8760", VA = "0x180FDA160")]
			public FKAMGCPNDKL(List<Component> ACLENHAHHHH, bool FKLPHALDEMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x3DFA490", Offset = "0x3DF8A90", VA = "0x183DFA490")]
			public ONIPLJHFHPL<T> CBILBBMABKJ()
			{
				return default(ONIPLJHFHPL<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x3DFA500", Offset = "0x3DF8B00", VA = "0x183DFA500", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x3DFA500", Offset = "0x3DF8B00", VA = "0x183DFA500", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4425200", Offset = "0x4423800", VA = "0x184425200", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0x4425190", Offset = "0x4423790", VA = "0x184425190", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x44251D0", Offset = "0x44237D0", VA = "0x1844251D0")]
			public ONIPLJHFHPL(List<Component> ACLENHAHHHH, bool FKLPHALDEMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x44250D0", Offset = "0x44236D0", VA = "0x1844250D0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x44250E0", Offset = "0x44236E0", VA = "0x1844250E0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x3C2A2E0", Offset = "0x3C288E0", VA = "0x183C2A2E0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x60278B0", Offset = "0x6025EB0", VA = "0x1860278B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x6027870", Offset = "0x6025E70", VA = "0x186027870")]
		public ToolHierarchyCache(GameObject POFNLMLLLOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x6027600", Offset = "0x6025C00", VA = "0x186027600")]
		private void OIEJOMHJJDA(GameObject POFNLMLLLOA, bool CBEIFKNKIIE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x6027760", Offset = "0x6025D60", VA = "0x186027760")]
		public static void OIEJOMHJJDA(GameObject POFNLMLLLOA, ref ToolHierarchyCache ODMPDKFLOEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x60270A0", Offset = "0x60256A0", VA = "0x1860270A0")]
		public void BMOEIMDFFHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x60270B0", Offset = "0x60256B0", VA = "0x1860270B0")]
		public void BPOMIGMEPDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7490", Offset = "0x3FE5A90", VA = "0x183FE7490")]
		public void IMLEINFLFAA<T>(Action<T> PBOHOIMMGFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x6027100", Offset = "0x6025700", VA = "0x186027100")]
		public Component DJCMNOAAJEN(Type MCLMFJEAHEC, bool FKLPHALDEMJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7410", Offset = "0x3FE5A10", VA = "0x183FE7410")]
		public T DJCMNOAAJEN<T>(bool FKLPHALDEMJ = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x6027020", Offset = "0x6025620", VA = "0x186027020")]
		public FKAMGCPNDKL<Component> AINJNNGJLHE(Type MCLMFJEAHEC, bool FKLPHALDEMJ = false)
		{
			return default(FKAMGCPNDKL<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7340", Offset = "0x3FE5940", VA = "0x183FE7340")]
		public FKAMGCPNDKL<T> AINJNNGJLHE<T>(bool FKLPHALDEMJ = false) where T : class
		{
			return default(FKAMGCPNDKL<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x60272D0", Offset = "0x60258D0", VA = "0x1860272D0")]
		public List<Component> NECEEIJHBOA(Type MCLMFJEAHEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x60271D0", Offset = "0x60257D0", VA = "0x1860271D0", Slot = "4")]
		public bool Equals(ToolHierarchyCache FBHIPILAOBE, ToolHierarchyCache DPKHPCDGHJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x6027250", Offset = "0x6025850", VA = "0x186027250", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C15CA0", Offset = "0x2C142A0", VA = "0x182C15CA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T MJCEALLDFPC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x46CF800", Offset = "0x46CDE00", VA = "0x1846CF800")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T MCBKGMLNLLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x46CF720", Offset = "0x46CDD20", VA = "0x1846CF720")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T KLAFOCHJOAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x46CF3D0", Offset = "0x46CD9D0", VA = "0x1846CF3D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x46CF8D0", Offset = "0x46CDED0", VA = "0x1846CF8D0")]
	public HGOBKIGLAMO(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x46CF600", Offset = "0x46CDC00", VA = "0x1846CF600")]
	public void MFMCNFFMIAP(T AHNJHFGNBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x46CF890", Offset = "0x46CDE90", VA = "0x1846CF890")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x46CF490", Offset = "0x46CDA90", VA = "0x1846CF490")]
	public void GBCNHKFADAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x46CF440", Offset = "0x46CDA40", VA = "0x1846CF440")]
	public void DDEPFNIOABP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x46CF430", Offset = "0x46CDA30", VA = "0x1846CF430")]
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
		[Cpp2IlInjected.Address(RVA = "0x6025560", Offset = "0x6023B60", VA = "0x186025560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool DIIJOOGAEKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x7F09A0", Offset = "0x7EEFA0", VA = "0x1807F09A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x8AAEB0", Offset = "0x8A94B0", VA = "0x1808AAEB0")]
	public PJLHCNAOPNF(Action PBOHOIMMGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x6025540", Offset = "0x6023B40", VA = "0x186025540")]
	public void ADFDICGOODJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x6025540", Offset = "0x6023B40", VA = "0x186025540", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class ALFFBNHEIBH
{
	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x601E170", Offset = "0x601C770", VA = "0x18601E170")]
	public static void AHLDDFDMEGK(ADNKCEEOLDO CHCEKBPDNGP, string NGFODIDHBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
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
		[Cpp2IlInjected.Address(RVA = "0x783BB0", Offset = "0x7821B0", VA = "0x180783BB0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D80", Offset = "0x7E4380", VA = "0x1807E5D80", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool MMPPENFBFJA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x365EF60", Offset = "0x365D560", VA = "0x18365EF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object KBIPJOFDDHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x67A0D0", Offset = "0x6786D0", VA = "0x18067A0D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D70", Offset = "0x7E4370", VA = "0x1807E5D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x365F460", Offset = "0x365DA60", VA = "0x18365F460")]
	public bool OGKJCDPEKGH(T MAKFNMHIJIF, object HKLDIENGNNB, int IPGJOMPJEJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x365EEE0", Offset = "0x365D4E0", VA = "0x18365EEE0")]
	public bool BJHOJHPKHGP(object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x365F120", Offset = "0x365D720", VA = "0x18365F120")]
	public bool IDEDABPJLGL(object HKLDIENGNNB, out T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x341CB70", Offset = "0x341B170", VA = "0x18341CB70")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x365D2F0", Offset = "0x365B8F0", VA = "0x18365D2F0")]
	private bool APJDPKMJMFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x365F760", Offset = "0x365DD60", VA = "0x18365F760")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F86F0", Offset = "0x9F6CF0", VA = "0x1809F86F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x9F8700", Offset = "0x9F6D00", VA = "0x1809F8700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x60202E0", Offset = "0x601E8E0", VA = "0x1860202E0")]
	public void OGKJCDPEKGH(float MAKFNMHIJIF, object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x6020270", Offset = "0x601E870", VA = "0x186020270")]
	public void BJHOJHPKHGP(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x6020350", Offset = "0x601E950", VA = "0x186020350")]
	private void OJFICGNHNPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x6020470", Offset = "0x601EA70", VA = "0x186020470")]
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
	[Cpp2IlInjected.Address(RVA = "0x709E40", Offset = "0x708440", VA = "0x180709E40")]
	public MFNIHNNDJBP(string PGBLILALBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x6023A10", Offset = "0x6022010", VA = "0x186023A10")]
	public MFNIHNNDJBP(UnityEngine.Object GCLKAELNFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x60239C0", Offset = "0x6021FC0", VA = "0x1860239C0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public GHMGPDKPAAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x6020150", Offset = "0x601E750", VA = "0x186020150")]
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
		[Cpp2IlInjected.Address(RVA = "0x601DC70", Offset = "0x601C270", VA = "0x18601DC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool JBJJGGGFHBP
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x601DFA0", Offset = "0x601C5A0", VA = "0x18601DFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x6BA600", Offset = "0x6B8C00", VA = "0x1806BA600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x601DEB0", Offset = "0x601C4B0", VA = "0x18601DEB0")]
	public bool MFMCNFFMIAP(object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x601DD40", Offset = "0x601C340", VA = "0x18601DD40")]
	public bool EMIFMEAGDDE(object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x601DE50", Offset = "0x601C450", VA = "0x18601DE50")]
	public bool HEBLGIOGKGC(object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x601DDE0", Offset = "0x601C3E0", VA = "0x18601DDE0")]
	public void FMCFPECHEBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x601DFB0", Offset = "0x601C5B0", VA = "0x18601DFB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B4B3F0", Offset = "0x1B499F0", VA = "0x181B4B3F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x24965B0", Offset = "0x2494BB0", VA = "0x1824965B0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object CBEKBLNIJEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D70", Offset = "0x7E4370", VA = "0x1807E5D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool MMPPENFBFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x3B55080", Offset = "0x3B53680", VA = "0x183B55080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x3B55640", Offset = "0x3B53C40", VA = "0x183B55640")]
	public bool OGKJCDPEKGH(T MAKFNMHIJIF, object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x3B55020", Offset = "0x3B53620", VA = "0x183B55020")]
	public bool BJHOJHPKHGP(object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x341CB70", Offset = "0x341B170", VA = "0x18341CB70")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x3B550C0", Offset = "0x3B536C0", VA = "0x183B550C0")]
	public bool IDEDABPJLGL(object HKLDIENGNNB, out T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x3B54670", Offset = "0x3B52C70", VA = "0x183B54670")]
	private bool APJDPKMJMFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x3B55900", Offset = "0x3B53F00", VA = "0x183B55900")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public MDBMMECDLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x6022570", Offset = "0x6020B70", VA = "0x186022570")]
	private static string LLKJKMBGMPE(byte[] LKLEFAIICIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x6022220", Offset = "0x6020820", VA = "0x186022220")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
