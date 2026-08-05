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
public class PDDOCPBACOF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x860C90", Offset = "0x85FA90", VA = "0x180860C90")]
	public PDDOCPBACOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, OMCDKJFFLCG, HGMLOMJHBJD, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x701A00", Offset = "0x700800", VA = "0x180701A00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x71C2B0", Offset = "0x71B0B0", VA = "0x18071C2B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x73C0B0", Offset = "0x73AEB0", VA = "0x18073C0B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash HJECOOILIMC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x79C840", Offset = "0x79B640", VA = "0x18079C840")]
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
	[IKCCMANNNGJ]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[IKCCMANNNGJ]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x64EDC80", Offset = "0x64ECA80", VA = "0x1864EDC80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x64EDC40", Offset = "0x64ECA40", VA = "0x1864EDC40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x64EDCC0", Offset = "0x64ECAC0", VA = "0x1864EDCC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x64EDE90", Offset = "0x64ECC90", VA = "0x1864EDE90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x64EDE00", Offset = "0x64ECC00", VA = "0x1864EDE00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x87B100", Offset = "0x879F00", VA = "0x18087B100")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8A7360", Offset = "0x8A6160", VA = "0x1808A7360")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x64EDC00", Offset = "0x64ECA00", VA = "0x1864EDC00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x64EDD70", Offset = "0x64ECB70", VA = "0x1864EDD70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x64ED640", Offset = "0x64EC440", VA = "0x1864ED640")]
	public void CopyBounds(SavedExtents ONICAEEHHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x64EDB60", Offset = "0x64EC960", VA = "0x1864EDB60")]
	public void SetLocalSpaceBounds(Bounds NOMEIFDKOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xA50AA0", Offset = "0xA4F8A0", VA = "0x180A50AA0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x64EDB50", Offset = "0x64EC950", VA = "0x1864EDB50")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x64ED670", Offset = "0x64EC470", VA = "0x1864ED670")]
	private void EDLAOIBNCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x64ED920", Offset = "0x64EC720", VA = "0x1864ED920")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x64ED000", Offset = "0x64EBE00", VA = "0x1864ED000")]
	public static void CalculateLocalBoundsFor(GameObject AAMBGNNHMBI, out Bounds NOMEIFDKOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x64ED860", Offset = "0x64EC660", VA = "0x1864ED860")]
	private static void ODPGKKFLPOG(Bounds MIECAKFJHNF, Color BPJNCMDPHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x64EDB80", Offset = "0x64EC980", VA = "0x1864EDB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DA060", Offset = "0x6D8E60", VA = "0x1806DA060")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x768440", Offset = "0x767240", VA = "0x180768440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x945FD0", Offset = "0x944DD0", VA = "0x180945FD0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xE6A5C0", Offset = "0xE693C0", VA = "0x180E6A5C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "4")]
	public virtual void GHAFPGPNGFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
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
	[PDDOCPBACOF]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x31CE000", Offset = "0x31CCE00", VA = "0x1831CE000", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x31CD730", Offset = "0x31CC530", VA = "0x1831CD730", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x31CE540", Offset = "0x31CD340", VA = "0x1831CE540")]
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
	private sealed class KGGDPKIEDCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public KGGDPKIEDCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2722370", Offset = "0x2721170", VA = "0x182722370")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[PDDOCPBACOF]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE470", Offset = "0x1FED270", VA = "0x181FEE470", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE4A0", Offset = "0x1FED2A0", VA = "0x181FEE4A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE3C0", Offset = "0x1FED1C0", VA = "0x181FEE3C0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey ANFHHLAHMJD]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE420", Offset = "0x1FED220", VA = "0x181FEE420", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE2C0", Offset = "0x1FED0C0", VA = "0x181FEE2C0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDE10", Offset = "0x1FECC10", VA = "0x181FEDE10", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1FED630", Offset = "0x1FEC430", VA = "0x181FED630", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1FED220", Offset = "0x1FEC020", VA = "0x181FED220", Slot = "14")]
	protected virtual string ABILGMBBDHN(TKeyVal OAMNHOAFMBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1FED250", Offset = "0x1FEC050", VA = "0x181FED250", Slot = "4")]
	public bool ContainsKey(TKey ANFHHLAHMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE1B0", Offset = "0x1FECFB0", VA = "0x181FEE1B0", Slot = "5")]
	public bool TryGetValue(TKey ANFHHLAHMJD, out TVal NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1FED280", Offset = "0x1FEC080", VA = "0x181FED280", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1FED280", Offset = "0x1FEC080", VA = "0x181FED280", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE1E0", Offset = "0x1FECFE0", VA = "0x181FEE1E0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PEHMGJAFHKA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ICEJNFKMHGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public ICEJNFKMHGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF790", Offset = "0x2AAE590", VA = "0x182AAF790")]
		internal bool <GetSamples>b__0(global::EOABNEGFADA<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float FGMKHHEEOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float ANPBGMFIBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::EOABNEGFADA<float, T>> FJHEHNKPBHJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int EINKAGEDEFB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x389D390", Offset = "0x389C190", VA = "0x18389D390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x389D410", Offset = "0x389C210", VA = "0x18389D410")]
	public PEHMGJAFHKA(float JCEAONHMPNE, float CNAOOOOFHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x389D050", Offset = "0x389BE50", VA = "0x18389D050")]
	public bool GMOGHMHOLDO(float BOMIODHNHJM, T NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x389CFC0", Offset = "0x389BDC0", VA = "0x18389CFC0")]
	public int DMJLEKLIPKH(float BOMIODHNHJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x389C940", Offset = "0x389B740", VA = "0x18389C940")]
	public IEnumerable<T> DJMBBANLKFF(float BOMIODHNHJM, [Optional] float? BBEPBFKKJBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x389D020", Offset = "0x389BE20", VA = "0x18389D020")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x389C880", Offset = "0x389B680", VA = "0x18389C880")]
	private void AFHPFEILEAG(float BOMIODHNHJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class PIMEDLBHLPG<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct BPMELKMKNPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T DKPIGGFDHBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float IGNPCPGAGLL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float NNLNKFMKKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> APMILBIAJBO;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int MDIIGJGDFIG = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private BPMELKMKNPA[] ECEFKNGMHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int BLKLJCBFABM;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float GJAOBGIFCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x945820", Offset = "0x944620", VA = "0x180945820")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9458B0", Offset = "0x9446B0", VA = "0x1809458B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6AD0", Offset = "0x2AC58D0", VA = "0x182AC6AD0")]
	public PIMEDLBHLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6B00", Offset = "0x2AC5900", VA = "0x182AC6B00")]
	public PIMEDLBHLPG(int MBCLCCPKDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5700", Offset = "0x2AC4500", VA = "0x182AC5700")]
	public void AHKNMMEAEHA(float BOMIODHNHJM, T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2AC63A0", Offset = "0x2AC51A0", VA = "0x182AC63A0")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6710", Offset = "0x2AC5510", VA = "0x182AC6710")]
	public bool FLDPICAMPFC(float MIJNONLKFAG, float HACJBAPFMGG, out T NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5E30", Offset = "0x2AC4C30", VA = "0x182AC5E30")]
	public bool DOJKGBHGFOP(float MIJNONLKFAG, float HACJBAPFMGG, out T NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5AF0", Offset = "0x2AC48F0", VA = "0x182AC5AF0")]
	public void BMLFLCFBOJD(float MIJNONLKFAG, float HACJBAPFMGG, List<T> IHLLHGOCNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5C50", Offset = "0x2AC4A50", VA = "0x182AC5C50")]
	private int CJPFLJOCDPN(int KBLOPJCAKIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5C10", Offset = "0x2AC4A10", VA = "0x182AC5C10")]
	private void CFOEGMIGOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T OLLDLFIKKFK();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T HDKBLOAKLDA(T PLAIMEGKAGI, T PENEJEHLCIP, float KFBDCAJNIAB);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T LDDDMLFNCFP(T NLHFEJHKLAH, float KFBDCAJNIAB);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T PLMHFNAMFOK(T PLAIMEGKAGI, T PENEJEHLCIP);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T MAKBJKPKOCD(T PLAIMEGKAGI, T PENEJEHLCIP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class IFPMCMIACNM : global::PIMEDLBHLPG<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1838F10", Offset = "0x1837D10", VA = "0x181838F10", Slot = "4")]
	protected override Vector3 OLLDLFIKKFK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1F30DB0", Offset = "0x1F2FBB0", VA = "0x181F30DB0", Slot = "5")]
	protected override Vector3 HDKBLOAKLDA(Vector3 PLAIMEGKAGI, Vector3 PENEJEHLCIP, float KFBDCAJNIAB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x64E84A0", Offset = "0x64E72A0", VA = "0x1864E84A0", Slot = "6")]
	protected override Vector3 LDDDMLFNCFP(Vector3 NLHFEJHKLAH, float KFBDCAJNIAB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x64E8570", Offset = "0x64E7370", VA = "0x1864E8570", Slot = "7")]
	protected override Vector3 PLMHFNAMFOK(Vector3 PLAIMEGKAGI, Vector3 PENEJEHLCIP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x64E8500", Offset = "0x64E7300", VA = "0x1864E8500", Slot = "8")]
	protected override Vector3 MAKBJKPKOCD(Vector3 PLAIMEGKAGI, Vector3 PENEJEHLCIP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x64E85F0", Offset = "0x64E73F0", VA = "0x1864E85F0")]
	public IFPMCMIACNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HCCENJCPGBD : global::PIMEDLBHLPG<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x64E8360", Offset = "0x64E7160", VA = "0x1864E8360")]
	public HCCENJCPGBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x64E83D0", Offset = "0x64E71D0", VA = "0x1864E83D0")]
	public HCCENJCPGBD(int MBCLCCPKDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x87DB00", Offset = "0x87C900", VA = "0x18087DB00", Slot = "4")]
	protected override float OLLDLFIKKFK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3CE2030", Offset = "0x3CE0E30", VA = "0x183CE2030", Slot = "5")]
	protected override float HDKBLOAKLDA(float PLAIMEGKAGI, float PENEJEHLCIP, float KFBDCAJNIAB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5333070", Offset = "0x5331E70", VA = "0x185333070", Slot = "6")]
	protected override float LDDDMLFNCFP(float NLHFEJHKLAH, float KFBDCAJNIAB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x302E7C0", Offset = "0x302D5C0", VA = "0x18302E7C0", Slot = "7")]
	protected override float PLMHFNAMFOK(float PLAIMEGKAGI, float PENEJEHLCIP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x64E8350", Offset = "0x64E7150", VA = "0x1864E8350", Slot = "8")]
	protected override float MAKBJKPKOCD(float PLAIMEGKAGI, float PENEJEHLCIP)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GAFBDEONHNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2289AA0", Offset = "0x22888A0", VA = "0x182289AA0")]
	public static global::APCMKEBPCHF<T1> FBMANFCLCAO<T1>(T1 OFDJEFOJGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2289530", Offset = "0x2288330", VA = "0x182289530")]
	public static global::EOABNEGFADA<T1, T2> FBMANFCLCAO<T1, T2>(T1 OFDJEFOJGPG, T2 AJODJKPADNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x22895A0", Offset = "0x22883A0", VA = "0x1822895A0")]
	public static global::PKECEAKEEJB<T1, T2, T3> FBMANFCLCAO<T1, T2, T3>(T1 OFDJEFOJGPG, T2 AJODJKPADNC, T3 OPDBGLFLMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2289910", Offset = "0x2288710", VA = "0x182289910")]
	public static global::DCEICDMEAIM<T1, T2, T3, T4> FBMANFCLCAO<T1, T2, T3, T4>(T1 OFDJEFOJGPG, T2 AJODJKPADNC, T3 OPDBGLFLMFP, T4 EFOJBIPJKPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2289870", Offset = "0x2288670", VA = "0x182289870")]
	public static global::JKIEEGOPNJA<T1, T2, T3, T4, T5> FBMANFCLCAO<T1, T2, T3, T4, T5>(T1 OFDJEFOJGPG, T2 AJODJKPADNC, T3 OPDBGLFLMFP, T4 EFOJBIPJKPK, T5 OHLFBHGCMJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x22897C0", Offset = "0x22885C0", VA = "0x1822897C0")]
	public static global::IHLPMNDCHOH<T1, T2, T3, T4, T5, T6> FBMANFCLCAO<T1, T2, T3, T4, T5, T6>(T1 OFDJEFOJGPG, T2 AJODJKPADNC, T3 OPDBGLFLMFP, T4 EFOJBIPJKPK, T5 OHLFBHGCMJB, T6 FKKMAGICCBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2289700", Offset = "0x2288500", VA = "0x182289700")]
	public static global::NGEHDOFACJF<T1, T2, T3, T4, T5, T6, T7> FBMANFCLCAO<T1, T2, T3, T4, T5, T6, T7>(T1 OFDJEFOJGPG, T2 AJODJKPADNC, T3 OPDBGLFLMFP, T4 EFOJBIPJKPK, T5 OHLFBHGCMJB, T6 FKKMAGICCBG, T7 GICIOFLMMFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2289630", Offset = "0x2288430", VA = "0x182289630")]
	public static global::GPLLFPNOGDI<T1, T2, T3, T4, T5, T6, T7, T8> FBMANFCLCAO<T1, T2, T3, T4, T5, T6, T7, T8>(T1 OFDJEFOJGPG, T2 AJODJKPADNC, T3 OPDBGLFLMFP, T4 EFOJBIPJKPK, T5 OHLFBHGCMJB, T6 FKKMAGICCBG, T7 GICIOFLMMFO, T8 GOMCEHGEGEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2289BC0", Offset = "0x22889C0", VA = "0x182289BC0")]
	[IteratorStateMachine(typeof(PEPHIEMMOJN))]
	public static IEnumerable<global::EOABNEGFADA<T1, T2>> FPFBFBPCAHO<T1, T2>(IEnumerable<T1> FEIPFLDEPBD, IEnumerable<T2> MIECAKFJHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2289B00", Offset = "0x2288900", VA = "0x182289B00")]
	[IteratorStateMachine(typeof(PHLGCDGHBOF))]
	public static IEnumerable<global::PKECEAKEEJB<T1, T2, T3>> FPFBFBPCAHO<T1, T2, T3>(IEnumerable<T1> FEIPFLDEPBD, IEnumerable<T2> MIECAKFJHNF, IEnumerable<T3> BPJNCMDPHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2E865A0", Offset = "0x2E853A0", VA = "0x182E865A0")]
	internal static int BGAOKJFBBNO(int OMCALDMMOBB, int JHGHLPHCOAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4385240", Offset = "0x4384040", VA = "0x184385240")]
	internal static int BGAOKJFBBNO(int OMCALDMMOBB, int JHGHLPHCOAA, int AABJKGACLJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4385220", Offset = "0x4384020", VA = "0x184385220")]
	internal static int BGAOKJFBBNO(int OMCALDMMOBB, int JHGHLPHCOAA, int AABJKGACLJN, int DMPPPHAFMEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4385250", Offset = "0x4384050", VA = "0x184385250")]
	internal static int BGAOKJFBBNO(int OMCALDMMOBB, int JHGHLPHCOAA, int AABJKGACLJN, int DMPPPHAFMEO, int KDPKHFPLNLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x64E81B0", Offset = "0x64E6FB0", VA = "0x1864E81B0")]
	internal static int BGAOKJFBBNO(int OMCALDMMOBB, int JHGHLPHCOAA, int AABJKGACLJN, int DMPPPHAFMEO, int KDPKHFPLNLC, int IELGJOALJIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x64E8180", Offset = "0x64E6F80", VA = "0x1864E8180")]
	internal static int BGAOKJFBBNO(int OMCALDMMOBB, int JHGHLPHCOAA, int AABJKGACLJN, int DMPPPHAFMEO, int KDPKHFPLNLC, int IELGJOALJIH, int IGAMGMDNKHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x64E8150", Offset = "0x64E6F50", VA = "0x1864E8150")]
	internal static int BGAOKJFBBNO(int OMCALDMMOBB, int JHGHLPHCOAA, int AABJKGACLJN, int DMPPPHAFMEO, int KDPKHFPLNLC, int IELGJOALJIH, int IGAMGMDNKHB, int EKJAIAFDOOG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class APCMKEBPCHF<T1> : IComparable<global::APCMKEBPCHF<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 FKBEBFOMCKP;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x28D63A0", Offset = "0x28D51A0", VA = "0x1828D63A0")]
	public APCMKEBPCHF(T1 OFDJEFOJGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3B801F0", Offset = "0x3B7EFF0", VA = "0x183B801F0", Slot = "4")]
	public int CompareTo(global::APCMKEBPCHF<T1> ONICAEEHHFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3B80260", Offset = "0x3B7F060", VA = "0x183B80260", Slot = "0")]
	public override bool Equals(object ONICAEEHHFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8200E0", Offset = "0x81EEE0", VA = "0x1808200E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3B80300", Offset = "0x3B7F100", VA = "0x183B80300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EOABNEGFADA<T1, T2> : IComparable<global::EOABNEGFADA<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 FKBEBFOMCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 FEBEDOHMBEG;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3524DD0", Offset = "0x3523BD0", VA = "0x183524DD0")]
	public EOABNEGFADA(T1 OFDJEFOJGPG, T2 AJODJKPADNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3523280", Offset = "0x3522080", VA = "0x183523280", Slot = "4")]
	public int CompareTo(global::EOABNEGFADA<T1, T2> ONICAEEHHFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x35236A0", Offset = "0x35224A0", VA = "0x1835236A0", Slot = "0")]
	public override bool Equals(object ONICAEEHHFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3523FA0", Offset = "0x3522DA0", VA = "0x183523FA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x35243A0", Offset = "0x35231A0", VA = "0x1835243A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PKECEAKEEJB<T1, T2, T3> : IComparable<global::PKECEAKEEJB<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 FKBEBFOMCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 FEBEDOHMBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 JAFOLMPGMIC;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7E70", Offset = "0x2AC6C70", VA = "0x182AC7E70")]
	public PKECEAKEEJB(T1 OFDJEFOJGPG, T2 AJODJKPADNC, T3 OPDBGLFLMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7660", Offset = "0x2AC6460", VA = "0x182AC7660", Slot = "4")]
	public int CompareTo(global::PKECEAKEEJB<T1, T2, T3> ONICAEEHHFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7860", Offset = "0x2AC6660", VA = "0x182AC7860", Slot = "0")]
	public override bool Equals(object ONICAEEHHFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7B50", Offset = "0x2AC6950", VA = "0x182AC7B50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7CC0", Offset = "0x2AC6AC0", VA = "0x182AC7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DCEICDMEAIM<T1, T2, T3, T4> : IComparable<global::DCEICDMEAIM<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 FKBEBFOMCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 FEBEDOHMBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 JAFOLMPGMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 HNMNLPHHJIM;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x29781C0", Offset = "0x2976FC0", VA = "0x1829781C0")]
	public DCEICDMEAIM(T1 OFDJEFOJGPG, T2 AJODJKPADNC, T3 OPDBGLFLMFP, T4 EFOJBIPJKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2B03330", Offset = "0x2B02130", VA = "0x182B03330", Slot = "4")]
	public int CompareTo(global::DCEICDMEAIM<T1, T2, T3, T4> ONICAEEHHFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2B03470", Offset = "0x2B02270", VA = "0x182B03470", Slot = "0")]
	public override bool Equals(object ONICAEEHHFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2B03590", Offset = "0x2B02390", VA = "0x182B03590", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2B03650", Offset = "0x2B02450", VA = "0x182B03650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JKIEEGOPNJA<T1, T2, T3, T4, T5> : IComparable<global::JKIEEGOPNJA<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 FKBEBFOMCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 FEBEDOHMBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 JAFOLMPGMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 HNMNLPHHJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 DLCPKDAIANB;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2F56EB0", Offset = "0x2F55CB0", VA = "0x182F56EB0")]
	public JKIEEGOPNJA(T1 OFDJEFOJGPG, T2 AJODJKPADNC, T3 OPDBGLFLMFP, T4 EFOJBIPJKPK, T5 OHLFBHGCMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2F569A0", Offset = "0x2F557A0", VA = "0x182F569A0", Slot = "4")]
	public int CompareTo(global::JKIEEGOPNJA<T1, T2, T3, T4, T5> ONICAEEHHFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2F56B20", Offset = "0x2F55920", VA = "0x182F56B20", Slot = "0")]
	public override bool Equals(object ONICAEEHHFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2F56C60", Offset = "0x2F55A60", VA = "0x182F56C60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2F56D60", Offset = "0x2F55B60", VA = "0x182F56D60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class IHLPMNDCHOH<T1, T2, T3, T4, T5, T6> : IComparable<global::IHLPMNDCHOH<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 FKBEBFOMCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 FEBEDOHMBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 JAFOLMPGMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 HNMNLPHHJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 DLCPKDAIANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 EKHHJDJJJHB;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x25A0A40", Offset = "0x259F840", VA = "0x1825A0A40")]
	public IHLPMNDCHOH(T1 OFDJEFOJGPG, T2 AJODJKPADNC, T3 OPDBGLFLMFP, T4 EFOJBIPJKPK, T5 OHLFBHGCMJB, T6 FKKMAGICCBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x25A0480", Offset = "0x259F280", VA = "0x1825A0480", Slot = "4")]
	public int CompareTo(global::IHLPMNDCHOH<T1, T2, T3, T4, T5, T6> ONICAEEHHFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x25A0640", Offset = "0x259F440", VA = "0x1825A0640", Slot = "0")]
	public override bool Equals(object ONICAEEHHFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x25A07B0", Offset = "0x259F5B0", VA = "0x1825A07B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x25A08D0", Offset = "0x259F6D0", VA = "0x1825A08D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class NGEHDOFACJF<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::NGEHDOFACJF<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 FKBEBFOMCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 FEBEDOHMBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 JAFOLMPGMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 HNMNLPHHJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 DLCPKDAIANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 EKHHJDJJJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 NEJBGHCNECP;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3915970", Offset = "0x3914770", VA = "0x183915970")]
	public NGEHDOFACJF(T1 OFDJEFOJGPG, T2 AJODJKPADNC, T3 OPDBGLFLMFP, T4 EFOJBIPJKPK, T5 OHLFBHGCMJB, T6 FKKMAGICCBG, T7 GICIOFLMMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x39152F0", Offset = "0x39140F0", VA = "0x1839152F0", Slot = "4")]
	public int CompareTo(global::NGEHDOFACJF<T1, T2, T3, T4, T5, T6, T7> ONICAEEHHFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x39154F0", Offset = "0x39142F0", VA = "0x1839154F0", Slot = "0")]
	public override bool Equals(object ONICAEEHHFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3915690", Offset = "0x3914490", VA = "0x183915690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x39157E0", Offset = "0x39145E0", VA = "0x1839157E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class GPLLFPNOGDI<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::GPLLFPNOGDI<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 FKBEBFOMCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 FEBEDOHMBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 JAFOLMPGMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 HNMNLPHHJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 DLCPKDAIANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 EKHHJDJJJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 NEJBGHCNECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 NJHOEICFDKL;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3D34F40", Offset = "0x3D33D40", VA = "0x183D34F40")]
	public GPLLFPNOGDI(T1 OFDJEFOJGPG, T2 AJODJKPADNC, T3 OPDBGLFLMFP, T4 EFOJBIPJKPK, T5 OHLFBHGCMJB, T6 FKKMAGICCBG, T7 GICIOFLMMFO, T8 GOMCEHGEGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3D34810", Offset = "0x3D33610", VA = "0x183D34810", Slot = "4")]
	public int CompareTo(global::GPLLFPNOGDI<T1, T2, T3, T4, T5, T6, T7, T8> ONICAEEHHFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3D34A60", Offset = "0x3D33860", VA = "0x183D34A60", Slot = "0")]
	public override bool Equals(object ONICAEEHHFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3D34C20", Offset = "0x3D33A20", VA = "0x183D34C20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3D34D90", Offset = "0x3D33B90", VA = "0x183D34D90", Slot = "3")]
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
	public T DKPIGGFDHBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2F46580", Offset = "0x2F45380", VA = "0x182F46580")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3E52880", Offset = "0x3E51680", VA = "0x183E52880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float INAHFIBCMDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B5790", Offset = "0x7B4590", VA = "0x1807B5790")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x44F4650", Offset = "0x44F3450", VA = "0x1844F4650")]
	public T POFHDDJLHPB(float KFBDCAJNIAB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x44F4230", Offset = "0x44F3030", VA = "0x1844F4230")]
	public T HBKHCOPIGBP(float KFBDCAJNIAB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T HDKBLOAKLDA(T PLAIMEGKAGI, T PENEJEHLCIP, float KFBDCAJNIAB);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3CE2030", Offset = "0x3CE0E30", VA = "0x183CE2030", Slot = "4")]
	protected override float HDKBLOAKLDA(float PLAIMEGKAGI, float PENEJEHLCIP, float KFBDCAJNIAB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x64E8110", Offset = "0x64E6F10", VA = "0x1864E8110")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1F30DB0", Offset = "0x1F2FBB0", VA = "0x181F30DB0", Slot = "4")]
	protected override Vector3 HDKBLOAKLDA(Vector3 PLAIMEGKAGI, Vector3 PENEJEHLCIP, float KFBDCAJNIAB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x64EEE40", Offset = "0x64EDC40", VA = "0x1864EEE40")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x64E6620", Offset = "0x64E5420", VA = "0x1864E6620", Slot = "4")]
	protected override Color HDKBLOAKLDA(Color PLAIMEGKAGI, Color PENEJEHLCIP, float KFBDCAJNIAB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x64E6670", Offset = "0x64E5470", VA = "0x1864E6670")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AEEILKFFALI : global::NCCMGMLGJKO<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x64E4D50", Offset = "0x64E3B50", VA = "0x1864E4D50")]
	public AEEILKFFALI(int FPMMBKCOHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x64E4DA0", Offset = "0x64E3BA0", VA = "0x1864E4DA0")]
	public AEEILKFFALI(FGCKOMJEIKG[] PIJHGEFGNKO, bool IAABPOFOOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x64E4CE0", Offset = "0x64E3AE0", VA = "0x1864E4CE0", Slot = "6")]
	protected override uint AMHJLJNGCKF(uint HJECOOILIMC, string NLHFEJHKLAH)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JDIIAMDFOMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public JDIIAMDFOMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct JIODPIPIFEJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class FMIJONKAPFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public FMIJONKAPFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B6EC80", Offset = "0x2B6DA80", VA = "0x182B6EC80")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> OHNKFHABAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int IKECAIABMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int MCMDHCALCMP;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xA47E50", Offset = "0xA46C50", VA = "0x180A47E50")]
	private JIODPIPIFEJ(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> DHIMILAJKEG, int INEFOFHDDIF, int GAOCBNNBJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2F51270", Offset = "0x2F50070", VA = "0x182F51270")]
	public static global::JIODPIPIFEJ<T> LBKFKMLCCNN()
	{
		return default(global::JIODPIPIFEJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2F50410", Offset = "0x2F4F210", VA = "0x182F50410")]
	public (int, int, Task<T>) BHJJMGAMGDB(int BAOCCOKLHIB, [Optional] CancellationToken ONFKFAAPNBK, double IHNJKOANCPJ = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2F516A0", Offset = "0x2F504A0", VA = "0x182F516A0")]
	public void NJNGNMDNDKC(int BAOCCOKLHIB, int GAOCBNNBJAD, in T DGEANHLCFIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class IOCAODGKJDG
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x64E8660", Offset = "0x64E7460", VA = "0x1864E8660")]
	public static global::JIODPIPIFEJ<BCGDFNNBADB> LBKFKMLCCNN()
	{
		return default(global::JIODPIPIFEJ<BCGDFNNBADB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x64E86B0", Offset = "0x64E74B0", VA = "0x1864E86B0")]
	public static void NJNGNMDNDKC(this in global::JIODPIPIFEJ<BCGDFNNBADB> CNBAEMLJEBG, int BAOCCOKLHIB, int GAOCBNNBJAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class CHGPKKDCPDF<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> EOKHMHOKNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> KOLLHGFCJNC;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2642890", Offset = "0x2641690", VA = "0x182642890", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool MIBACEBEMNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x70F8E0", Offset = "0x70E6E0", VA = "0x18070F8E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> BCKCFDANKGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2AB39F0", Offset = "0x2AB27F0", VA = "0x182AB39F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> ANCMJCNFOJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2C552C0", Offset = "0x2C540C0", VA = "0x182C552C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x357D090", Offset = "0x357BE90", VA = "0x18357D090", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x357D100", Offset = "0x357BF00", VA = "0x18357D100", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x357C0C0", Offset = "0x357AEC0", VA = "0x18357C0C0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x357C7C0", Offset = "0x357B5C0", VA = "0x18357C7C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x357C100", Offset = "0x357AF00", VA = "0x18357C100", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x357CEC0", Offset = "0x357BCC0", VA = "0x18357CEC0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x357C010", Offset = "0x357AE10", VA = "0x18357C010", Slot = "9")]
	public void Add(TKey ANFHHLAHMJD, TVal NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x357C050", Offset = "0x357AE50", VA = "0x18357C050", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> CDHGABCIPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x357C160", Offset = "0x357AF60", VA = "0x18357C160", Slot = "8")]
	public bool ContainsKey(TKey ANFHHLAHMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x357C190", Offset = "0x357AF90", VA = "0x18357C190", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> CDHGABCIPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x357CE30", Offset = "0x357BC30", VA = "0x18357CE30", Slot = "10")]
	public bool Remove(TKey ANFHHLAHMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x357CE60", Offset = "0x357BC60", VA = "0x18357CE60", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> CDHGABCIPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x31844C0", Offset = "0x31832C0", VA = "0x1831844C0", Slot = "11")]
	public bool TryGetValue(TKey ANFHHLAHMJD, out TVal NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2F48970", Offset = "0x2F47770", VA = "0x182F48970", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x357C1F0", Offset = "0x357AFF0", VA = "0x18357C1F0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] ECEFKNGMHII, int NKBOPBAMDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x357BF00", Offset = "0x357AD00", VA = "0x18357BF00")]
	public void AHKNMMEAEHA(TVal JMFDIAPBCKC, TKey ANFHHLAHMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x357BE50", Offset = "0x357AC50", VA = "0x18357BE50")]
	public void AHKNMMEAEHA(KeyValuePair<TVal, TKey> CDHGABCIPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x357C870", Offset = "0x357B670", VA = "0x18357C870")]
	public bool HOKNCBODOOP(TVal ANFHHLAHMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x357CDC0", Offset = "0x357BBC0", VA = "0x18357CDC0")]
	public bool PGDHOKOGAJF(KeyValuePair<TVal, TKey> CDHGABCIPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x357C9F0", Offset = "0x357B7F0", VA = "0x18357C9F0")]
	public bool IHKCCNMHHEB(TVal ANFHHLAHMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x357C9F0", Offset = "0x357B7F0", VA = "0x18357C9F0")]
	public bool IHKCCNMHHEB(KeyValuePair<TVal, TKey> CDHGABCIPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x357BF40", Offset = "0x357AD40", VA = "0x18357BF40")]
	public bool AMKBCCEHNAL(TVal ANFHHLAHMJD, out TKey NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x357C8B0", Offset = "0x357B6B0", VA = "0x18357C8B0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> IBIALAPJHHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x357CAB0", Offset = "0x357B8B0", VA = "0x18357CAB0")]
	private void KGIAPFEJCPJ(TKey ANFHHLAHMJD, TVal JMFDIAPBCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x357CCF0", Offset = "0x357BAF0", VA = "0x18357CCF0")]
	private void NCCILNKGNFD(TKey ANFHHLAHMJD, TVal JMFDIAPBCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x357C250", Offset = "0x357B050", VA = "0x18357C250")]
	private bool GCHOMDGPEKF(TKey ANFHHLAHMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x357C320", Offset = "0x357B120", VA = "0x18357C320")]
	private bool GCHOMDGPEKF(TVal JMFDIAPBCKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x357CFB0", Offset = "0x357BDB0", VA = "0x18357CFB0")]
	public CHGPKKDCPDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class LFEDHHHPNBH<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::LFEDHHHPNBH<T> buffer;

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
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3683C90", Offset = "0x3682A90", VA = "0x183683C90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x32EEC70", Offset = "0x32EDA70", VA = "0x1832EEC70")]
		public Enumerator(global::LFEDHHHPNBH<T> IHLLHGOCNMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x36817E0", Offset = "0x36805E0", VA = "0x1836817E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3682470", Offset = "0x3681270", VA = "0x183682470", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x367F5C0", Offset = "0x367E3C0", VA = "0x18367F5C0")]
		private void BDHAFAFBMGD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] IKFMHLLOBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int PGFGHPKFPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int AIGNFABBDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int CPFPNOFCGCI;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2FE2990", Offset = "0x2FE1790", VA = "0x182FE2990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2FE1970", Offset = "0x2FE0770", VA = "0x182FE1970")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2FE28E0", Offset = "0x2FE16E0", VA = "0x182FE28E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2FE3090", Offset = "0x2FE1E90", VA = "0x182FE3090")]
	public LFEDHHHPNBH(int FPMMBKCOHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2FE1510", Offset = "0x2FE0310", VA = "0x182FE1510")]
	public void AHKNMMEAEHA(T KFBDCAJNIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2FE23B0", Offset = "0x2FE11B0", VA = "0x182FE23B0")]
	public void EMAILJOLPAC(IEnumerable<T> BIMJJIGDDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2FE26A0", Offset = "0x2FE14A0", VA = "0x182FE26A0")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2FE1A10", Offset = "0x2FE0810", VA = "0x182FE1A10")]
	public void DFOKCBDCLMM(int PHHDFCFDFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2FE1800", Offset = "0x2FE0600", VA = "0x182FE1800")]
	public void CAMCFMNIDEF(int PHHDFCFDFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2FE2B20", Offset = "0x2FE1920", VA = "0x182FE2B20")]
	public void OHBDFGIIBPN(T[] ECEFKNGMHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2FE26C0", Offset = "0x2FE14C0", VA = "0x182FE26C0")]
	public Enumerator FGLPNHJPKAJ()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2FE2F90", Offset = "0x2FE1D90", VA = "0x182FE2F90", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2FE2F90", Offset = "0x2FE1D90", VA = "0x182FE2F90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2FE1420", Offset = "0x2FE0220", VA = "0x182FE1420")]
	private int AEEIKKIBGBN(int CPOAAGLEIPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2FE2960", Offset = "0x2FE1760", VA = "0x182FE2960")]
	private int INBHAAJOOMM(int CPOAAGLEIPE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class KOIJFFBDIBO<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> BFDJLDFAEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> JMHMBGJOCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> LLMBPPCBLOM;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> GOGKKMMBAGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x71C2B0", Offset = "0x71B0B0", VA = "0x18071C2B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool MIBACEBEMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x82D580", Offset = "0x82C380", VA = "0x18082D580", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x82D600", Offset = "0x82C400", VA = "0x18082D600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2EF2A80", Offset = "0x2EF1880", VA = "0x182EF2A80", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2EF2B20", Offset = "0x2EF1920", VA = "0x182EF2B20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2EF2A20", Offset = "0x2EF1820", VA = "0x182EF2A20", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2EF2990", Offset = "0x2EF1790", VA = "0x182EF2990")]
	public KOIJFFBDIBO(Func<Internal, External> BFDJLDFAEFL, Func<External, Internal> JMHMBGJOCJM, bool DCLDMIHOKIB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2EF26B0", Offset = "0x2EF14B0", VA = "0x182EF26B0", Slot = "6")]
	public int IndexOf(External CDHGABCIPJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2EF22E0", Offset = "0x2EF10E0", VA = "0x182EF22E0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2EF2390", Offset = "0x2EF1190", VA = "0x182EF2390", Slot = "13")]
	public bool Contains(External CDHGABCIPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2EF2420", Offset = "0x2EF1220", VA = "0x182EF2420", Slot = "14")]
	public void CopyTo(External[] ECEFKNGMHII, int NKBOPBAMDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2EF21F0", Offset = "0x2EF0FF0", VA = "0x182EF21F0", Slot = "11")]
	public void Add(External CDHGABCIPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2EF27A0", Offset = "0x2EF15A0", VA = "0x182EF27A0", Slot = "7")]
	public void Insert(int CPOAAGLEIPE, External CDHGABCIPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2EF2900", Offset = "0x2EF1700", VA = "0x182EF2900", Slot = "15")]
	public bool Remove(External CDHGABCIPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2EF2840", Offset = "0x2EF1640", VA = "0x182EF2840", Slot = "8")]
	public void RemoveAt(int CPOAAGLEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2EF2640", Offset = "0x2EF1440", VA = "0x182EF2640", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x28D05C0", Offset = "0x28CF3C0", VA = "0x1828D05C0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class JMEKPFPDCJP<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> BFDJLDFAEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> LLMBPPCBLOM;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> GOGKKMMBAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x701A00", Offset = "0x700800", VA = "0x180701A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool MIBACEBEMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x70F850", Offset = "0x70E650", VA = "0x18070F850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2F594C0", Offset = "0x2F582C0", VA = "0x182F594C0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2F59460", Offset = "0x2F58260", VA = "0x182F59460", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x28D63A0", Offset = "0x28D51A0", VA = "0x1828D63A0")]
	public JMEKPFPDCJP(Func<Internal, External> BFDJLDFAEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2F59410", Offset = "0x2F58210", VA = "0x182F59410")]
	public JMEKPFPDCJP(IReadOnlyList<Internal> LLMBPPCBLOM, Func<Internal, External> BFDJLDFAEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2F591F0", Offset = "0x2F57FF0", VA = "0x182F591F0")]
	public void OHBDFGIIBPN(External[] ECEFKNGMHII, int NKBOPBAMDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2F59180", Offset = "0x2F57F80", VA = "0x182F59180", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x28D0100", Offset = "0x28CEF00", VA = "0x1828D0100", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public class OJMOKIBEGBG<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> LLMBPPCBLOM;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> GOGKKMMBAGO
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F10", Offset = "0x6F6D10", VA = "0x1806F7F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MIBACEBEMNK
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x70F850", Offset = "0x70E650", VA = "0x18070F850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x36BBA10", Offset = "0x36BA810", VA = "0x1836BBA10", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x36BB9B0", Offset = "0x36BA7B0", VA = "0x1836BB9B0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x28D63A0", Offset = "0x28D51A0", VA = "0x1828D63A0")]
	public OJMOKIBEGBG(IReadOnlyList<Internal> LLMBPPCBLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x36BB910", Offset = "0x36BA710", VA = "0x1836BB910")]
	public bool PGDHOKOGAJF(External CDHGABCIPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x36BB6E0", Offset = "0x36BA4E0", VA = "0x1836BB6E0")]
	public void OHBDFGIIBPN(External[] ECEFKNGMHII, int NKBOPBAMDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x36BB670", Offset = "0x36BA470", VA = "0x1836BB670", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x28D05C0", Offset = "0x28CF3C0", VA = "0x1828D05C0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class EAGFKIFNNFB
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void PNAKOOMJFBL(object[] GLNACLILDAP);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	protected EAGFKIFNNFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public abstract class BCPDMJIHBMB<T> : EAGFKIFNNFB
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	protected struct MJNHDCIDKAG
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public enum AGAGNBEPPAG
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
		public AGAGNBEPPAG MAIOHDHBGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T KKJDJCJOLIF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int NEBILDCBMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool ENGEKOOPDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool MCLHOAENJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> LIJAOLPBIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<MJNHDCIDKAG> JIMDCFKIFDL;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool LCEKCENKGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x296E6F0", Offset = "0x296D4F0", VA = "0x18296E6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x296E730", Offset = "0x296D530", VA = "0x18296E730")]
	protected BCPDMJIHBMB(bool MCLHOAENJDD, bool ENGEKOOPDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x296E1B0", Offset = "0x296CFB0", VA = "0x18296E1B0")]
	protected bool BDHEIHGLGPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x296E340", Offset = "0x296D140", VA = "0x18296E340")]
	protected void IFJFGKPLFIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x296E540", Offset = "0x296D340", VA = "0x18296E540")]
	protected void JJEELNKOLFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x263DB20", Offset = "0x263C920", VA = "0x18263DB20")]
	private static void HPFGGCFHFOD<U>(ref List<U> LLMBPPCBLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x296E050", Offset = "0x296CE50", VA = "0x18296E050", Slot = "5")]
	public void AHKNMMEAEHA(T KKJDJCJOLIF, bool IAOBBMLCPID = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x296E400", Offset = "0x296D200", VA = "0x18296E400", Slot = "6")]
	public void IHKCCNMHHEB(T KKJDJCJOLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x296E230", Offset = "0x296D030", VA = "0x18296E230")]
	public void FDAOBHPPNLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface GGFALDJILPL
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHKNMMEAEHA(Action KKJDJCJOLIF, bool IAOBBMLCPID = false);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHKCCNMHHEB(Action KKJDJCJOLIF);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class CPHLPGCHIIP : global::BCPDMJIHBMB<Action>, GGFALDJILPL
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x64E65C0", Offset = "0x64E53C0", VA = "0x1864E65C0")]
	public CPHLPGCHIIP(bool MCLHOAENJDD = false, bool ENGEKOOPDKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x64E62E0", Offset = "0x64E50E0", VA = "0x1864E62E0")]
	public void KOIGNNKBIOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x64E6550", Offset = "0x64E5350", VA = "0x1864E6550", Slot = "4")]
	public override void PNAKOOMJFBL(object[] GLNACLILDAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x64E6280", Offset = "0x64E5080", VA = "0x1864E6280")]
	public static CPHLPGCHIIP DHHECOJPLIP(CPHLPGCHIIP JHJKHIENGFC, Action KKJDJCJOLIF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x64E64F0", Offset = "0x64E52F0", VA = "0x1864E64F0")]
	public static CPHLPGCHIIP OHKKABPHOED(CPHLPGCHIIP JHJKHIENGFC, Action KKJDJCJOLIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface NEKALIIOGPI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHKNMMEAEHA(Action<T> KKJDJCJOLIF, bool IAOBBMLCPID = false);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHKCCNMHHEB(Action<T> KKJDJCJOLIF);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class KMABOJJOEJK<T> : global::BCPDMJIHBMB<Action<T>>, global::NEKALIIOGPI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2738E30", Offset = "0x2737C30", VA = "0x182738E30")]
	public KMABOJJOEJK(bool MCLHOAENJDD = false, bool ENGEKOOPDKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x27371C0", Offset = "0x2735FC0", VA = "0x1827371C0")]
	public void KOIGNNKBIOA(T KFBDCAJNIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2738760", Offset = "0x2737560", VA = "0x182738760", Slot = "4")]
	public override void PNAKOOMJFBL(object[] GLNACLILDAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2737120", Offset = "0x2735F20", VA = "0x182737120")]
	public static global::KMABOJJOEJK<T> DHHECOJPLIP(global::KMABOJJOEJK<T> JHJKHIENGFC, Action<T> KKJDJCJOLIF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2737FD0", Offset = "0x2736DD0", VA = "0x182737FD0")]
	public static global::KMABOJJOEJK<T> OHKKABPHOED(global::KMABOJJOEJK<T> JHJKHIENGFC, Action<T> KKJDJCJOLIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface LDGLAHKPMPB<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHKNMMEAEHA(Action<T, U> KKJDJCJOLIF, bool IAOBBMLCPID = false);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHKCCNMHHEB(Action<T, U> KKJDJCJOLIF);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class EHEADPCJBOA<T, U> : global::BCPDMJIHBMB<Action<T, U>>, global::LDGLAHKPMPB<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2738E30", Offset = "0x2737C30", VA = "0x182738E30")]
	public EHEADPCJBOA(bool MCLHOAENJDD = false, bool ENGEKOOPDKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x33B96B0", Offset = "0x33B84B0", VA = "0x1833B96B0")]
	public void KOIGNNKBIOA(T KFBDCAJNIAB, U AMGJBIFICNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x33BD610", Offset = "0x33BC410", VA = "0x1833BD610", Slot = "4")]
	public override void PNAKOOMJFBL(object[] GLNACLILDAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x33B8620", Offset = "0x33B7420", VA = "0x1833B8620")]
	public static global::EHEADPCJBOA<T, U> DHHECOJPLIP(global::EHEADPCJBOA<T, U> JHJKHIENGFC, Action<T, U> KKJDJCJOLIF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x33BAE30", Offset = "0x33B9C30", VA = "0x1833BAE30")]
	public static global::EHEADPCJBOA<T, U> OHKKABPHOED(global::EHEADPCJBOA<T, U> JHJKHIENGFC, Action<T, U> KKJDJCJOLIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface IGHDJEEMJEO<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHKNMMEAEHA(Action<T, U, V> KKJDJCJOLIF, bool IAOBBMLCPID = false);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHKCCNMHHEB(Action<T, U, V> KKJDJCJOLIF);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class LOMIOBFHBNE<T, U, V> : global::BCPDMJIHBMB<Action<T, U, V>>, global::IGHDJEEMJEO<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2738E30", Offset = "0x2737C30", VA = "0x182738E30")]
	public LOMIOBFHBNE(bool MCLHOAENJDD = false, bool ENGEKOOPDKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x320E790", Offset = "0x320D590", VA = "0x18320E790")]
	public void KOIGNNKBIOA(T KFBDCAJNIAB, U AMGJBIFICNF, V PALFKPAOLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x320FF90", Offset = "0x320ED90", VA = "0x18320FF90", Slot = "4")]
	public override void PNAKOOMJFBL(object[] GLNACLILDAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x320D560", Offset = "0x320C360", VA = "0x18320D560")]
	public static global::LOMIOBFHBNE<T, U, V> DHHECOJPLIP(global::LOMIOBFHBNE<T, U, V> JHJKHIENGFC, Action<T, U, V> KKJDJCJOLIF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x320F670", Offset = "0x320E470", VA = "0x18320F670")]
	public static global::LOMIOBFHBNE<T, U, V> OHKKABPHOED(global::LOMIOBFHBNE<T, U, V> JHJKHIENGFC, Action<T, U, V> KKJDJCJOLIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface PJHOJAIAEIK<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHKNMMEAEHA(Action<T, U, V, W> KKJDJCJOLIF, bool IAOBBMLCPID = false);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHKCCNMHHEB(Action<T, U, V, W> KKJDJCJOLIF);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class LMCGGPKPIDE<T, U, V, W> : global::BCPDMJIHBMB<Action<T, U, V, W>>, global::PJHOJAIAEIK<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2738E30", Offset = "0x2737C30", VA = "0x182738E30")]
	public LMCGGPKPIDE(bool MCLHOAENJDD = false, bool ENGEKOOPDKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3191C20", Offset = "0x3190A20", VA = "0x183191C20")]
	public void KOIGNNKBIOA(T KFBDCAJNIAB, U AMGJBIFICNF, V PALFKPAOLKL, W NBNGFNKGOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x31933C0", Offset = "0x31921C0", VA = "0x1831933C0", Slot = "4")]
	public override void PNAKOOMJFBL(object[] GLNACLILDAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3191360", Offset = "0x3190160", VA = "0x183191360")]
	public static global::LMCGGPKPIDE<T, U, V, W> DHHECOJPLIP(global::LMCGGPKPIDE<T, U, V, W> JHJKHIENGFC, Action<T, U, V, W> KKJDJCJOLIF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3192670", Offset = "0x3191470", VA = "0x183192670")]
	public static global::LMCGGPKPIDE<T, U, V, W> OHKKABPHOED(global::LMCGGPKPIDE<T, U, V, W> JHJKHIENGFC, Action<T, U, V, W> KKJDJCJOLIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface OIADGIHEBAP<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHKNMMEAEHA(Action<T, U, V, W, X> KKJDJCJOLIF, bool IAOBBMLCPID = false);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHKCCNMHHEB(Action<T, U, V, W, X> KKJDJCJOLIF);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class OJBALMKJAPL<T, U, V, W, X> : global::BCPDMJIHBMB<Action<T, U, V, W, X>>, global::OIADGIHEBAP<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2738E30", Offset = "0x2737C30", VA = "0x182738E30")]
	public OJBALMKJAPL(bool MCLHOAENJDD = false, bool ENGEKOOPDKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x36BAA00", Offset = "0x36B9800", VA = "0x1836BAA00")]
	public void KOIGNNKBIOA(T KFBDCAJNIAB, U AMGJBIFICNF, V PALFKPAOLKL, W NBNGFNKGOEK, X PAMKNJCGOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x36BB380", Offset = "0x36BA180", VA = "0x1836BB380", Slot = "4")]
	public override void PNAKOOMJFBL(object[] GLNACLILDAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x36BA960", Offset = "0x36B9760", VA = "0x1836BA960")]
	public static global::OJBALMKJAPL<T, U, V, W, X> DHHECOJPLIP(global::OJBALMKJAPL<T, U, V, W, X> JHJKHIENGFC, Action<T, U, V, W, X> KKJDJCJOLIF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x36BAFC0", Offset = "0x36B9DC0", VA = "0x1836BAFC0")]
	public static global::OJBALMKJAPL<T, U, V, W, X> OHKKABPHOED(global::OJBALMKJAPL<T, U, V, W, X> JHJKHIENGFC, Action<T, U, V, W, X> KKJDJCJOLIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface KJIODCMDAHK<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHKNMMEAEHA(Action<T, U, V, W, X, Y> KKJDJCJOLIF, bool IAOBBMLCPID = false);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHKCCNMHHEB(Action<T, U, V, W, X, Y> KKJDJCJOLIF);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class IPMOEHGAPDP<T, U, V, W, X, Y> : global::BCPDMJIHBMB<Action<T, U, V, W, X, Y>>, global::KJIODCMDAHK<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2738E30", Offset = "0x2737C30", VA = "0x182738E30")]
	public IPMOEHGAPDP(bool MCLHOAENJDD = false, bool ENGEKOOPDKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2B6FE40", Offset = "0x2B6EC40", VA = "0x182B6FE40")]
	public void KOIGNNKBIOA(T KFBDCAJNIAB, U AMGJBIFICNF, V PALFKPAOLKL, W NBNGFNKGOEK, X PAMKNJCGOGK, Y IOAMOMOPNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2B70B70", Offset = "0x2B6F970", VA = "0x182B70B70", Slot = "4")]
	public override void PNAKOOMJFBL(object[] GLNACLILDAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2B6FAF0", Offset = "0x2B6E8F0", VA = "0x182B6FAF0")]
	public static global::IPMOEHGAPDP<T, U, V, W, X, Y> DHHECOJPLIP(global::IPMOEHGAPDP<T, U, V, W, X, Y> JHJKHIENGFC, Action<T, U, V, W, X, Y> KKJDJCJOLIF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2B70410", Offset = "0x2B6F210", VA = "0x182B70410")]
	public static global::IPMOEHGAPDP<T, U, V, W, X, Y> OHKKABPHOED(global::IPMOEHGAPDP<T, U, V, W, X, Y> JHJKHIENGFC, Action<T, U, V, W, X, Y> KKJDJCJOLIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class LFEOKKBMDOG<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct HGGNGDBEFDJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::LFEOKKBMDOG<T> LOGELMLAAMN;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T DKPIGGFDHBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3A8C900", Offset = "0x3A8B700", VA = "0x183A8C900")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3A8C8D0", Offset = "0x3A8B6D0", VA = "0x183A8C8D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F00", Offset = "0x6F6D00", VA = "0x1806F7F00")]
		public HGGNGDBEFDJ(global::LFEOKKBMDOG<T> LOGELMLAAMN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct GECJKGFNDJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<HGGNGDBEFDJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::LFEOKKBMDOG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4445940", Offset = "0x4444740", VA = "0x184445940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2301EE0", Offset = "0x2300CE0", VA = "0x182301EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct MFCODDMKGOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<HGGNGDBEFDJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::LFEOKKBMDOG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x35E3FB0", Offset = "0x35E2DB0", VA = "0x1835E3FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2301EE0", Offset = "0x2300CE0", VA = "0x182301EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim CBEPDINFOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T DJGMGNEEAKE;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int AHHOPHBOBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2FE3130", Offset = "0x2FE1F30", VA = "0x182FE3130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2FE3810", Offset = "0x2FE2610", VA = "0x182FE3810")]
	public LFEOKKBMDOG(in T DJGMGNEEAKE, int FNNIGMAJABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2FE38B0", Offset = "0x2FE26B0", VA = "0x182FE38B0")]
	public LFEOKKBMDOG(in T DJGMGNEEAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2FE3150", Offset = "0x2FE1F50", VA = "0x182FE3150")]
	public HGGNGDBEFDJ JHNFAENDOKK()
	{
		return default(HGGNGDBEFDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2FE3190", Offset = "0x2FE1F90", VA = "0x182FE3190")]
	public HGGNGDBEFDJ JHNFAENDOKK(CancellationToken ONFKFAAPNBK)
	{
		return default(HGGNGDBEFDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2FE31D0", Offset = "0x2FE1FD0", VA = "0x182FE31D0")]
	[AsyncStateMachine(typeof(global::LFEOKKBMDOG<>.GECJKGFNDJB))]
	public Task<HGGNGDBEFDJ> MAFPBBFGLCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2FE3600", Offset = "0x2FE2400", VA = "0x182FE3600")]
	[AsyncStateMachine(typeof(global::LFEOKKBMDOG<>.MFCODDMKGOK))]
	public Task<HGGNGDBEFDJ> MAFPBBFGLCJ(CancellationToken ONFKFAAPNBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class BKGGANOAGIB
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x64E5E80", Offset = "0x64E4C80", VA = "0x1864E5E80")]
	public static global::LFEOKKBMDOG<BCGDFNNBADB> LBKFKMLCCNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x64E5EE0", Offset = "0x64E4CE0", VA = "0x1864E5EE0")]
	public static global::LFEOKKBMDOG<BCGDFNNBADB> LBKFKMLCCNN(int FNNIGMAJABC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2289AA0", Offset = "0x22888A0", VA = "0x182289AA0")]
	public static global::LFEOKKBMDOG<T> LBKFKMLCCNN<T>(in T DJGMGNEEAKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x228A040", Offset = "0x2288E40", VA = "0x18228A040")]
	public static global::LFEOKKBMDOG<T> LBKFKMLCCNN<T>(in T DJGMGNEEAKE, int FNNIGMAJABC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class NCJPHGMJAPE<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TResult> OAIPJIKNABN(TRequest MGDDHKPDDMF, CancellationToken ONFKFAAPNBK);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum HEHNHOCBBKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class LKGECPNPLAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float CMDFBPEAHND = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan NOEEIIOCOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int GILPKEAOIKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public HEHNHOCBBKA DDHJCDCNNEI;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly LKGECPNPLAD LKPPHHDONBO;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float DFAPDPDHACC
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x318A110", Offset = "0x3188F10", VA = "0x18318A110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan KBMIPIJBCGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x318A260", Offset = "0x3189060", VA = "0x18318A260")]
		public LKGECPNPLAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private readonly struct FLOCMIMPNAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest MGDDHKPDDMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken ONFKFAAPNBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> BDFHNDBMPGJ;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x36DD430", Offset = "0x36DC230", VA = "0x1836DD430")]
		public FLOCMIMPNAP(TRequest MGDDHKPDDMF, TaskCompletionSource<TResult> BDFHNDBMPGJ, CancellationToken ONFKFAAPNBK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class GNPFEDHIFKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public GNPFEDHIFKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2642890", Offset = "0x2641690", VA = "0x182642890")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct FLOEOBPAGNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::NCJPHGMJAPE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x36DD8B0", Offset = "0x36DC6B0", VA = "0x1836DD8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x14868C0", Offset = "0x14856C0", VA = "0x1814868C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct NKJHOFGEJFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::NCJPHGMJAPE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private FLOCMIMPNAP <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x395BA90", Offset = "0x395A890", VA = "0x18395BA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x14868C0", Offset = "0x14856C0", VA = "0x1814868C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource NIIALLJJDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<FLOCMIMPNAP> POJPIKMMCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly LKGECPNPLAD DGNAOKJMFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly OAIPJIKNABN AIFDFAKPBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task EOHPPGKPONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int BJEKCAJJJHI;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x390D980", Offset = "0x390C780", VA = "0x18390D980")]
	public NCJPHGMJAPE(OAIPJIKNABN AIFDFAKPBHI, [Optional] LKGECPNPLAD DGNAOKJMFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x390C940", Offset = "0x390B740", VA = "0x18390C940")]
	public Task<TResult> HEGDAMMBFOO(TRequest MGDDHKPDDMF, CancellationToken ONFKFAAPNBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x390BD30", Offset = "0x390AB30", VA = "0x18390BD30")]
	private void BHHGOKNONDP(FLOCMIMPNAP JGILNPFNOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x390C600", Offset = "0x390B400", VA = "0x18390C600")]
	[AsyncStateMachine(typeof(global::NCJPHGMJAPE<, >.FLOEOBPAGNB))]
	private Task DAPDAHBIPPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x390BF00", Offset = "0x390AD00", VA = "0x18390BF00")]
	private FLOCMIMPNAP BLMPNGAAAGK()
	{
		return default(FLOCMIMPNAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x390D290", Offset = "0x390C090", VA = "0x18390D290")]
	[AsyncStateMachine(typeof(global::NCJPHGMJAPE<, >.NKJHOFGEJFL))]
	private Task KNPCLNPCGGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x390D480", Offset = "0x390C280", VA = "0x18390D480")]
	private void MAKNECMLAEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x390C900", Offset = "0x390B700", VA = "0x18390C900", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class ELOMGJCIMCG<TKey, TVal> : global::AIKGMLMKCAN<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int CDKOIGKPCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> BLIMEEGNNBC;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int BKAJMFBHFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3519DF0", Offset = "0x3518BF0", VA = "0x183519DF0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int CBEEKOADJGE
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3519A00", Offset = "0x3518800", VA = "0x183519A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3519E20", Offset = "0x3518C20", VA = "0x183519E20", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3519F20", Offset = "0x3518D20", VA = "0x183519F20")]
	public ELOMGJCIMCG(int FPMMBKCOHLA, [Optional] KHPMFBCMKGC IMJIJKCOFKD, [Optional] IEqualityComparer<TKey> NOMGNKFFMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3519E80", Offset = "0x3518C80", VA = "0x183519E80")]
	public void NBBBCICJKKG(TKey ANFHHLAHMJD, TVal NLHFEJHKLAH, bool PNIGMKLKAMP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3519910", Offset = "0x3518710", VA = "0x183519910")]
	public bool EEMLCFKONDG(TKey ANFHHLAHMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3519870", Offset = "0x3518670", VA = "0x183519870", Slot = "6")]
	public override bool AMKBCCEHNAL(TKey LPOCHCEIGOE, out TVal NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3519B40", Offset = "0x3518940", VA = "0x183519B40")]
	public bool IHPKPOIECFN(TKey ANFHHLAHMJD, TVal NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3519A30", Offset = "0x3518830", VA = "0x183519A30")]
	public bool GABCKBMGHJI(TKey ANFHHLAHMJD, TVal NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3519990", Offset = "0x3518790", VA = "0x183519990", Slot = "7")]
	public override void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3519D50", Offset = "0x3518B50", VA = "0x183519D50")]
	private bool IJAALDINJNO(TKey ANFHHLAHMJD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DefaultMember("Item")]
public class AIKGMLMKCAN<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public delegate int KHPMFBCMKGC(TKey ANFHHLAHMJD, TVal NLHFEJHKLAH);

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class IGJCKPPBNGF
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey EGGKJKOHLOL
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x73BC90", Offset = "0x73AA90", VA = "0x18073BC90")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal DKPIGGFDHBP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x71C2B0", Offset = "0x71B0B0", VA = "0x18071C2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int LACBNDDFFOB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x706AD0", Offset = "0x7058D0", VA = "0x180706AD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x706C30", Offset = "0x705A30", VA = "0x180706C30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime JJHCEAKBAAN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xB55B90", Offset = "0xB54990", VA = "0x180B55B90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x259FD10", Offset = "0x259EB10", VA = "0x18259FD10")]
		public IGJCKPPBNGF(TKey ANFHHLAHMJD, TVal JMFDIAPBCKC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int MEKHNHMFILN = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<IGJCKPPBNGF>> AJGPNHJDFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<IGJCKPPBNGF> GPPFGCFGLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly KHPMFBCMKGC IMJIJKCOFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan PLAJAAJOECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly BLDGEHEJIGG KDGBBOODJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int AOLDHCFKJLL;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int BACNEHOFKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x718550", Offset = "0x717350", VA = "0x180718550")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool DNOGLBALEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2C36DA0", Offset = "0x2C35BA0", VA = "0x182C36DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int BKAJMFBHFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC70", Offset = "0x6FDA70", VA = "0x1806FEC70", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int PHHDFCFDFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x25A0010", Offset = "0x259EE10", VA = "0x1825A0010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x28CFF10", Offset = "0x28CED10", VA = "0x1828CFF10", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> BCKCFDANKGL
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2C33B90", Offset = "0x2C32990", VA = "0x182C33B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2C34680", Offset = "0x2C33480", VA = "0x182C34680")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2C34DF0", Offset = "0x2C33BF0", VA = "0x182C34DF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2C37720", Offset = "0x2C36520", VA = "0x182C37720")]
	public AIKGMLMKCAN(int FPMMBKCOHLA, [Optional] KHPMFBCMKGC IMJIJKCOFKD, [Optional] IEqualityComparer<TKey> NOMGNKFFMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2C37380", Offset = "0x2C36180", VA = "0x182C37380")]
	public AIKGMLMKCAN(TimeSpan PLAJAAJOECB, [Optional] IEqualityComparer<TKey> NOMGNKFFMDL, [Optional] BLDGEHEJIGG KDGBBOODJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2C36E30", Offset = "0x2C35C30", VA = "0x182C36E30")]
	public AIKGMLMKCAN(int FPMMBKCOHLA, TimeSpan PLAJAAJOECB, [Optional] IEqualityComparer<TKey> NOMGNKFFMDL, [Optional] BLDGEHEJIGG KDGBBOODJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2C378C0", Offset = "0x2C366C0", VA = "0x182C378C0")]
	public AIKGMLMKCAN(int FPMMBKCOHLA, KHPMFBCMKGC IMJIJKCOFKD, TimeSpan PLAJAAJOECB, [Optional] IEqualityComparer<TKey> NOMGNKFFMDL, [Optional] BLDGEHEJIGG KDGBBOODJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2C36490", Offset = "0x2C35290", VA = "0x182C36490")]
	public void MEIDBJPHDJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2C36B40", Offset = "0x2C35940", VA = "0x182C36B40")]
	public void NIPKJFNBLBF(TKey ANFHHLAHMJD, TVal NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2C34F90", Offset = "0x2C33D90", VA = "0x182C34F90")]
	public bool IHKCCNMHHEB(TKey ANFHHLAHMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2C343E0", Offset = "0x2C331E0", VA = "0x182C343E0")]
	private TVal BPAEGFNIDAI(TKey LPOCHCEIGOE)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x2C341C0", Offset = "0x2C32FC0", VA = "0x182C341C0", Slot = "6")]
	public virtual bool AMKBCCEHNAL(TKey LPOCHCEIGOE, out TVal NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2C346C0", Offset = "0x2C334C0", VA = "0x182C346C0", Slot = "7")]
	public virtual void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C36900", Offset = "0x2C35700", VA = "0x182C36900")]
	private bool NBDPJCCOMFE(IGJCKPPBNGF JPBMJBLPABN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x2C356E0", Offset = "0x2C344E0", VA = "0x182C356E0")]
	private void JABHKACCAHA(LinkedListNode<IGJCKPPBNGF> LCHFFHEBCNG, TVal BHOEDLDNCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x2C35B70", Offset = "0x2C34970", VA = "0x182C35B70")]
	private void LLJCPJLNFOC(TKey ANFHHLAHMJD, TVal NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x2C34C20", Offset = "0x2C33A20", VA = "0x182C34C20")]
	private void GNEPAJEDHPM(IGJCKPPBNGF JPBMJBLPABN, TVal BHOEDLDNCKL, int CADJHEOGHIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DefaultMember("Item")]
public class KGFOEHPBBPG<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> LLMBPPCBLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> MAKOFLDBOAI;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2642890", Offset = "0x2641690", VA = "0x182642890", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool MIBACEBEMNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x70F8E0", Offset = "0x70E6E0", VA = "0x18070F8E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2640860", Offset = "0x263F660", VA = "0x182640860", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x27222B0", Offset = "0x27210B0", VA = "0x1827222B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2721810", Offset = "0x2720610", VA = "0x182721810", Slot = "11")]
	public void Add(T CDHGABCIPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2721840", Offset = "0x2720640", VA = "0x182721840")]
	public bool COOLJMALOJN(T CDHGABCIPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2721FD0", Offset = "0x2720DD0", VA = "0x182721FD0", Slot = "15")]
	public bool Remove(T CDHGABCIPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2721A20", Offset = "0x2720820", VA = "0x182721A20", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x27220E0", Offset = "0x2720EE0", VA = "0x1827220E0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2721990", Offset = "0x2720790", VA = "0x182721990", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x271EF90", Offset = "0x271DD90", VA = "0x18271EF90", Slot = "13")]
	public bool Contains(T CDHGABCIPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x27219F0", Offset = "0x27207F0", VA = "0x1827219F0", Slot = "14")]
	public void CopyTo(T[] ECEFKNGMHII, int NKBOPBAMDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2721AA0", Offset = "0x27208A0", VA = "0x182721AA0", Slot = "6")]
	public int IndexOf(T CDHGABCIPJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2721AD0", Offset = "0x27208D0", VA = "0x182721AD0", Slot = "7")]
	public void Insert(int CPOAAGLEIPE, T CDHGABCIPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2721F00", Offset = "0x2720D00", VA = "0x182721F00", Slot = "8")]
	public void RemoveAt(int CPOAAGLEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2721D60", Offset = "0x2720B60", VA = "0x182721D60")]
	public void NDDPAGENINN(Predicate<T> AFIJHKJMKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x2721C60", Offset = "0x2720A60", VA = "0x182721C60")]
	public void KOHGINEFLIA(Comparison<T> ADDNFADOGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x2722110", Offset = "0x2720F10", VA = "0x182722110")]
	public KGFOEHPBBPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class JEKJPICOEPO
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x64E88A0", Offset = "0x64E76A0", VA = "0x1864E88A0")]
	public static Vector3 GAMNBEGDPLE(this GameObject AAMBGNNHMBI, float PFIOADEOMLN)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
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
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44A40", VA = "0x180A45C40")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x64EE400", Offset = "0x64ED200", VA = "0x1864EE400")]
		public SerializedGuid(in Guid LAJNKLHJFND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x64EE370", Offset = "0x64ED170", VA = "0x1864EE370")]
		public static SerializedGuid PFMJJJDHAKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x64EDF20", Offset = "0x64ECD20", VA = "0x1864EDF20")]
		public static SerializedGuid CCIBIMJMPKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x64EE210", Offset = "0x64ED010", VA = "0x1864EE210")]
		public bool NNIBKOJBFNK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x64EE340", Offset = "0x64ED140", VA = "0x1864EE340", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x64EE2A0", Offset = "0x64ED0A0", VA = "0x1864EE2A0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x64EE180", Offset = "0x64ECF80", VA = "0x1864EE180")]
		public bool MIHMMJHONAF(in Guid LAJNKLHJFND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x64EDFE0", Offset = "0x64ECDE0", VA = "0x1864EDFE0", Slot = "7")]
		public bool Equals(SerializedGuid ONICAEEHHFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x64EE090", Offset = "0x64ECE90", VA = "0x1864EE090", Slot = "0")]
		public override bool Equals(object BLIKPCIFNNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x64EE170", Offset = "0x64ECF70", VA = "0x1864EE170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x64EDFB0", Offset = "0x64ECDB0", VA = "0x1864EDFB0", Slot = "6")]
		public int CompareTo(SerializedGuid ONICAEEHHFG)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class ADEIBHNECHC : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type DCGHHIKOCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string DEIMNPGJIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool EMABLNDCLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool BHPLDMIPPGJ;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x64E4C70", Offset = "0x64E3A70", VA = "0x1864E4C70")]
	public ADEIBHNECHC(Type JOPACEIBBHM, string FJDMHDBBLDB, bool EGJAPHPCEBI = false, bool IBOKANMMMCD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface KKKLJCNJNEE
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface NMAICHNINOG<T> : KKKLJCNJNEE
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T DKPIGGFDHBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool CJFHCEOMMDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string JCHHAFEADJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::NMAICHNINOG<T> OPMIPPODHBF(Action<T> OCOPHCPCJFO);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::NMAICHNINOG<T> ELNMIDKLBLE(Action<T> OCOPHCPCJFO);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::NMAICHNINOG<T> IBDHJJBONBP(Action<T, T> MIONPNIDNNJ);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::NMAICHNINOG<T> NPMEGCHMCDL(Action<T, T> MIONPNIDNNJ);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::NMAICHNINOG<T> BFHLNOPBOOF(Action<string> JMBCOCOGCKH);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::NMAICHNINOG<T> MBNAOAPMJNJ(Action<string> JMBCOCOGCKH);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class FBAHNKADLFG<T> : global::NMAICHNINOG<T>, KKKLJCNJNEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::EHEADPCJBOA<T, T> BIIGEKCOCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::KMABOJJOEJK<T> ADICBDBKHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::KMABOJJOEJK<string> JGCOGCAKKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string EDMHEICKIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T DGEANHLCFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool DKDGMAIPJKM;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T DKPIGGFDHBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8020", Offset = "0x1FE6E20", VA = "0x181FE8020", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool CJFHCEOMMDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6FA370", Offset = "0x6F9170", VA = "0x1806FA370", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string JCHHAFEADJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2773E70", Offset = "0x2772C70", VA = "0x182773E70", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3D920E0", Offset = "0x3D90EE0", VA = "0x183D920E0")]
	private void DJFHMHBCIBN(T GFDIIEHKLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3D92220", Offset = "0x3D91020", VA = "0x183D92220")]
	private void JOJADKOJNBP(string GNDOGDAIOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x3D92030", Offset = "0x3D90E30", VA = "0x183D92030")]
	public void CELKGMNMMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3D921D0", Offset = "0x3D90FD0", VA = "0x183D921D0", Slot = "6")]
	public global::NMAICHNINOG<T> IBDHJJBONBP(Action<T, T> MIONPNIDNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x3D92340", Offset = "0x3D91140", VA = "0x183D92340", Slot = "7")]
	public global::NMAICHNINOG<T> NPMEGCHMCDL(Action<T, T> MIONPNIDNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x3D92390", Offset = "0x3D91190", VA = "0x183D92390", Slot = "4")]
	public global::NMAICHNINOG<T> OPMIPPODHBF(Action<T> MIONPNIDNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x3D92180", Offset = "0x3D90F80", VA = "0x183D92180", Slot = "5")]
	public global::NMAICHNINOG<T> ELNMIDKLBLE(Action<T> OCOPHCPCJFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x3D91F90", Offset = "0x3D90D90", VA = "0x183D91F90", Slot = "8")]
	public global::NMAICHNINOG<T> BFHLNOPBOOF(Action<string> JMBCOCOGCKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x3D922D0", Offset = "0x3D910D0", VA = "0x183D922D0", Slot = "9")]
	public global::NMAICHNINOG<T> MBNAOAPMJNJ(Action<string> JMBCOCOGCKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x3D92420", Offset = "0x3D91220", VA = "0x183D92420")]
	public FBAHNKADLFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class BNEMAFCPHEC
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class IHKBACMAJFB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::NMAICHNINOG<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::NGNFCAOIKLE<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public IHKBACMAJFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x25A0380", Offset = "0x259F180", VA = "0x1825A0380")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x2848CA0", Offset = "0x2847AA0", VA = "0x182848CA0")]
	public static global::ONJEHKCKOLK<T> GMDGPINAMDC<T>(this global::NMAICHNINOG<T> NNAODLBOBAG, Action<T> JDLJMIHPPKE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class GKOFEHKMFNM<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public readonly struct HKPMNDCDLOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long ACCOHBNKMAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long PHMBJFMJDKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int GPKIKABFBGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int JDMEGNEJAKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool IMPBEDMPBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string OCDOLCNLJNN;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2C67370", Offset = "0x2C66170", VA = "0x182C67370")]
		public HKPMNDCDLOE(long ACCOHBNKMAI, int GPKIKABFBGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2C67340", Offset = "0x2C66140", VA = "0x182C67340")]
		public HKPMNDCDLOE(long ACCOHBNKMAI, long PHMBJFMJDKO, int GPKIKABFBGG, int JDMEGNEJAKP, bool IMPBEDMPBOM, string OCDOLCNLJNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2C67160", Offset = "0x2C65F60", VA = "0x182C67160")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void DCMKNEBHPIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2C672F0", Offset = "0x2C660F0", VA = "0x182C672F0")]
		public int MALODNCBPOE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2C67260", Offset = "0x2C66060", VA = "0x182C67260")]
		public int LBDMMPJNMAM(int CJILFLGLBLG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2C67280", Offset = "0x2C66080", VA = "0x182C67280")]
		public double LBIAJLJLPHB()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x2C671D0", Offset = "0x2C65FD0", VA = "0x182C671D0")]
		public HKPMNDCDLOE DHOACHGBEPH(long PHMBJFMJDKO, int JDMEGNEJAKP)
		{
			return default(HKPMNDCDLOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class KHFLMDIKDOP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey EGGKJKOHLOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::GKOFEHKMFNM<TKey> DGBAJNEJLED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<KHFLMDIKDOP> KDIPEMBEEFC;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string DPMJKJPNPPA
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x2724520", Offset = "0x2723320", VA = "0x182724520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x2724410", Offset = "0x2723210", VA = "0x182724410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<KHFLMDIKDOP> IAJCOJILOEF
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x2724840", Offset = "0x2723640", VA = "0x182724840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public HKPMNDCDLOE NIJOLJNFAMD
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x9A22E0", Offset = "0x9A10E0", VA = "0x1809A22E0")]
			[CompilerGenerated]
			get
			{
				return default(HKPMNDCDLOE);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x2724810", Offset = "0x2723610", VA = "0x182724810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2724860", Offset = "0x2723660", VA = "0x182724860")]
		internal KHFLMDIKDOP(global::GKOFEHKMFNM<TKey> DGBAJNEJLED, TKey ANFHHLAHMJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2724700", Offset = "0x2723500", VA = "0x182724700")]
		public KHFLMDIKDOP GDDEHNMBBID(TKey ANFHHLAHMJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2724440", Offset = "0x2723240", VA = "0x182724440")]
		public void BIIBKEBOMEO(TKey ANFHHLAHMJD, Action<KHFLMDIKDOP> KKJDJCJOLIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2D37560", Offset = "0x2D36360", VA = "0x182D37560")]
		public T BIIBKEBOMEO<T>(TKey ANFHHLAHMJD, Func<KHFLMDIKDOP, T> HHJDMJPABNC)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2D373F0", Offset = "0x2D361F0", VA = "0x182D373F0")]
		[AsyncStateMachine(typeof(EJBKIKFHCNE))]
		public Task<T> BEKHFLPEHFG<T>(TKey ANFHHLAHMJD, Func<KHFLMDIKDOP, Task<T>> HHJDMJPABNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x2724550", Offset = "0x2723350", VA = "0x182724550", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class KBHJEHMKPPB : IEnumerable<(TKey, List<TKey>, HKPMNDCDLOE)>, IEnumerable, IEnumerator<(TKey, List<TKey>, HKPMNDCDLOE)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, HKPMNDCDLOE timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::GKOFEHKMFNM<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, HKPMNDCDLOE timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, HKPMNDCDLOE) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2BBA260", Offset = "0x2BB9060", VA = "0x182BBA260", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, HKPMNDCDLOE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x2BBA2D0", Offset = "0x2BB90D0", VA = "0x182BBA2D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2BBA3E0", Offset = "0x2BB91E0", VA = "0x182BBA3E0")]
		[DebuggerHidden]
		public KBHJEHMKPPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2BBA330", Offset = "0x2BB9130", VA = "0x182BBA330", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x2BB9EF0", Offset = "0x2BB8CF0", VA = "0x182BB9EF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2BBA390", Offset = "0x2BB9190", VA = "0x182BBA390")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x2BBA290", Offset = "0x2BB9090", VA = "0x182BBA290", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2BBA1A0", Offset = "0x2BB8FA0", VA = "0x182BBA1A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, HKPMNDCDLOE)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x2A99E90", Offset = "0x2A98C90", VA = "0x182A99E90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class CMBIODAHKDC : IEnumerable<(TKey, List<TKey>, HKPMNDCDLOE)>, IEnumerable, IEnumerator<(TKey, List<TKey>, HKPMNDCDLOE)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, HKPMNDCDLOE timerEntry) <>2__current;

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
		private KHFLMDIKDOP timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public KHFLMDIKDOP <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::GKOFEHKMFNM<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<KHFLMDIKDOP> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, HKPMNDCDLOE timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, HKPMNDCDLOE) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x2BBA260", Offset = "0x2BB9060", VA = "0x182BBA260", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, HKPMNDCDLOE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x3587260", Offset = "0x3586060", VA = "0x183587260", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2BBA3E0", Offset = "0x2BB91E0", VA = "0x182BBA3E0")]
		[DebuggerHidden]
		public CMBIODAHKDC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x35872C0", Offset = "0x35860C0", VA = "0x1835872C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3586B70", Offset = "0x3585970", VA = "0x183586B70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3587360", Offset = "0x3586160", VA = "0x183587360")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x35873C0", Offset = "0x35861C0", VA = "0x1835873C0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3587220", Offset = "0x3586020", VA = "0x183587220", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3587110", Offset = "0x3585F10", VA = "0x183587110", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, HKPMNDCDLOE)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x35871F0", Offset = "0x3585FF0", VA = "0x1835871F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, HKPMNDCDLOE> AAIEAGBBHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, HKPMNDCDLOE> HHEIJIFMLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::GKOFEHKMFNM<TKey>> IFGNAJHKAPJ;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string IKGNINEGEJJ = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly KHFLMDIKDOP OLKCOMJOELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool JFHKLPCKLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int ACDGOJIDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch OBFBKMKDGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int ILEEDDKJBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string BJGFHCCKIGP;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public KHFLMDIKDOP CNBDIOBBDFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string DPMJKJPNPPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9C0", Offset = "0x6FC7C0", VA = "0x1806FD9C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3C2D430", Offset = "0x3C2C230", VA = "0x183C2D430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long KABDBGBNGKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3C2D490", Offset = "0x3C2C290", VA = "0x183C2D490")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int GNOLGNEPECM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3C2D760", Offset = "0x3C2C560", VA = "0x183C2D760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D790", Offset = "0x3C2C590", VA = "0x183C2D790")]
	public GKOFEHKMFNM(TKey FMNNJCCJFFO, [Optional] int? GPKIKABFBGG, [Optional][CanBeNull] Stopwatch OBFBKMKDGFB, [Optional] Action<TKey, HKPMNDCDLOE> AAIEAGBBHCI, [Optional] Action<TKey, HKPMNDCDLOE> HHEIJIFMLOA, [Optional] Action<global::GKOFEHKMFNM<TKey>> IFGNAJHKAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D610", Offset = "0x3C2C410", VA = "0x183C2D610", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D6A0", Offset = "0x3C2C4A0", VA = "0x183C2D6A0")]
	public void GFOFGMLJAPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D740", Offset = "0x3C2C540", VA = "0x183C2D740")]
	public void ILEODFHFEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D580", Offset = "0x3C2C380", VA = "0x183C2D580")]
	[IteratorStateMachine(typeof(global::GKOFEHKMFNM<>.KBHJEHMKPPB))]
	public IEnumerable<(TKey, List<TKey>, HKPMNDCDLOE)> DHNAHKLHAPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D4B0", Offset = "0x3C2C2B0", VA = "0x183C2D4B0")]
	[IteratorStateMachine(typeof(global::GKOFEHKMFNM<>.CMBIODAHKDC))]
	private IEnumerable<(TKey, List<TKey>, HKPMNDCDLOE)> DHNAHKLHAPP(List<TKey> BOFDAKKMDPM, KHFLMDIKDOP ILEJDKHPHDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D6C0", Offset = "0x3C2C4C0", VA = "0x183C2D6C0")]
	private (long, int) IEGJMNALHGL()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class AJFKPODODJF<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut JIOJKEJHKOC(global::GKOFEHKMFNM<TKey> DGBAJNEJLED);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
	protected AJFKPODODJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public abstract class KAHIPCBHOJN<TKey> : global::AJFKPODODJF<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate string CFCMDBHDNFD(TKey ANFHHLAHMJD);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7F20", Offset = "0x2BB6D20", VA = "0x182BB7F20")]
	protected string HNPJCIEIGKC(double NMPAPLMMNGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7EC0", Offset = "0x2BB6CC0", VA = "0x182BB7EC0")]
	protected string DEDBBINCFKM(int FLPHPKBALLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7F90", Offset = "0x2BB6D90", VA = "0x182BB7F90")]
	private static string IGHBPJJOINI(TKey ANFHHLAHMJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8100", Offset = "0x2BB6F00", VA = "0x182BB8100", Slot = "4")]
	public override string JIOJKEJHKOC(global::GKOFEHKMFNM<TKey> DGBAJNEJLED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7FD0", Offset = "0x2BB6DD0", VA = "0x182BB7FD0")]
	public string JIOJKEJHKOC(global::GKOFEHKMFNM<TKey> DGBAJNEJLED, [NotNull] CFCMDBHDNFD JGFAIDGBNCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string HBPMJOKJFAP(global::GKOFEHKMFNM<TKey> DGBAJNEJLED, [NotNull] CFCMDBHDNFD JGFAIDGBNCB);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x28D05C0", Offset = "0x28CF3C0", VA = "0x1828D05C0")]
	protected KAHIPCBHOJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class MMDJGJHADIE<TKey> : global::AJFKPODODJF<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate string ABCCEPGKCOC(TKey ANFHHLAHMJD);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int MAHLCIOFCNN = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string NBNGLEOOCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double GEMDPMGHKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool JEBGAFKCFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int PLALEILJFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> COHLHGOKMHF;

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x396EDB0", Offset = "0x396DBB0", VA = "0x18396EDB0")]
	private static string IGHBPJJOINI(TKey ANFHHLAHMJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x396F640", Offset = "0x396E440", VA = "0x18396F640")]
	public MMDJGJHADIE(string NBNGLEOOCBC = "F2", double GEMDPMGHKEL = double.MaxValue, bool JEBGAFKCFOB = false, int PLALEILJFIL = int.MaxValue, [Optional] ISet<string> COHLHGOKMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x396EDF0", Offset = "0x396DBF0", VA = "0x18396EDF0", Slot = "4")]
	public override Dictionary<string, string> JIOJKEJHKOC(global::GKOFEHKMFNM<TKey> DGBAJNEJLED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x396F3E0", Offset = "0x396E1E0", VA = "0x18396F3E0")]
	private bool KAKJIGJMEIC(string JKBAJOKNCBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x396EEA0", Offset = "0x396DCA0", VA = "0x18396EEA0")]
	public Dictionary<string, string> JIOJKEJHKOC(global::GKOFEHKMFNM<TKey> DGBAJNEJLED, ABCCEPGKCOC JGFAIDGBNCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x396EC00", Offset = "0x396DA00", VA = "0x18396EC00")]
	private string EELBBJDCKPF(StringBuilder GHPGDLFDLCA, List<TKey> DLFGDEIJEMK, ABCCEPGKCOC JGFAIDGBNCB, bool IBMKHOLBJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x396F4C0", Offset = "0x396E2C0", VA = "0x18396F4C0")]
	private static void NKDPCKBJAGO(StringBuilder CKODLJCONBH, string NNCMNNGMNPF, bool KBABPCDDKOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class HCKPNOPAAFF<TKey> : global::KAHIPCBHOJN<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct HKCAEIDIGIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public CFCMDBHDNFD keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::HCKPNOPAAFF<TKey> PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int BOIDJCJFLIC = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] HBDFELEFBBA;

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x3A847E0", Offset = "0x3A835E0", VA = "0x183A847E0")]
	private HCKPNOPAAFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x3A836B0", Offset = "0x3A824B0", VA = "0x183A836B0", Slot = "5")]
	protected override string HBPMJOKJFAP(global::GKOFEHKMFNM<TKey> DGBAJNEJLED, CFCMDBHDNFD JGFAIDGBNCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x3A845F0", Offset = "0x3A833F0", VA = "0x183A845F0")]
	[CompilerGenerated]
	internal static string LCNLPKDLMGC(string IKOEHHEBGAO, TKey ANFHHLAHMJD, ref HKCAEIDIGIA P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class JHFPHFBFIFG<TKey> : global::KAHIPCBHOJN<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class FDLJIJJLGDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public CFCMDBHDNFD keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public FDLJIJJLGDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x25B7DF0", Offset = "0x25B6BF0", VA = "0x1825B7DF0")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x2F4E790", Offset = "0x2F4D590", VA = "0x182F4E790", Slot = "5")]
	protected override string HBPMJOKJFAP(global::GKOFEHKMFNM<TKey> DGBAJNEJLED, CFCMDBHDNFD JGFAIDGBNCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2F4F080", Offset = "0x2F4DE80", VA = "0x182F4F080")]
	public JHFPHFBFIFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public sealed class MHBIGJFJBBH : global::GKOFEHKMFNM<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class BPADPCGGLPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<MHBIGJFJBBH> callback;

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public BPADPCGGLPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x64E60E0", Offset = "0x64E4EE0", VA = "0x1864E60E0")]
		internal void <Wrap>b__0(global::GKOFEHKMFNM<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x64EA250", Offset = "0x64E9050", VA = "0x1864EA250")]
	public MHBIGJFJBBH([Optional] string JCLEPDBAMDG, [Optional] int? GPKIKABFBGG, [Optional] Stopwatch OBFBKMKDGFB, [Optional] Action<string, HKPMNDCDLOE> AAIEAGBBHCI, [Optional] Action<string, HKPMNDCDLOE> HHEIJIFMLOA, [Optional] Action<MHBIGJFJBBH> IFGNAJHKAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x64EA170", Offset = "0x64E8F70", VA = "0x1864EA170")]
	private static Action<global::GKOFEHKMFNM<string>> BIIBKEBOMEO(Action<MHBIGJFJBBH> JDLJMIHPPKE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class BLDGEHEJIGG
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class MAKMDHEBCGB : BLDGEHEJIGG
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static BLDGEHEJIGG PDNDNIMAPDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x64E9FB0", Offset = "0x64E8DB0", VA = "0x1864E9FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime FCOLBKGNJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x64EA020", Offset = "0x64E8E20", VA = "0x1864EA020", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float DOIAMEFHOBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x64EA010", Offset = "0x64E8E10", VA = "0x1864EA010", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x64EA110", Offset = "0x64E8F10", VA = "0x1864EA110")]
		public MAKMDHEBCGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static BLDGEHEJIGG PAONEJJEEAH;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static BLDGEHEJIGG LKPPHHDONBO
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x64E5F50", Offset = "0x64E4D50", VA = "0x1864E5F50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime FCOLBKGNJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float DOIAMEFHOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	protected BLDGEHEJIGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class DHJGAJPKPMK : global::IKFDIOEKEFB<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x64E6980", Offset = "0x64E5780", VA = "0x1864E6980")]
	public DHJGAJPKPMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class IKFDIOEKEFB<T> : global::HBCJHPKGFFI<T>, JLEECCFLDND, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> NFOALBONBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task MJNHFHJACGO
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x18DA7B0", Offset = "0x18D95B0", VA = "0x1818DA7B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::ONJEHKCKOLK<T> AOIBAIHJCAM
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private LMAPELGHNPL PNBNKIHNACH
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x25B00F0", Offset = "0x25AEEF0", VA = "0x1825B00F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x25B0120", Offset = "0x25AEF20", VA = "0x1825B0120")]
	public IKFDIOEKEFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class ALIMHKNBKLL : global::KNAJHPKNPDM<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x64E4E00", Offset = "0x64E3C00", VA = "0x1864E4E00")]
	public ALIMHKNBKLL(Exception ABJFFBJEJDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class KNAJHPKNPDM<T> : global::HBCJHPKGFFI<T>, JLEECCFLDND, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> NFOALBONBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task MJNHFHJACGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x18DA7B0", Offset = "0x18D95B0", VA = "0x1818DA7B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::ONJEHKCKOLK<T> AOIBAIHJCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private LMAPELGHNPL PNBNKIHNACH
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x25B00F0", Offset = "0x25AEEF0", VA = "0x1825B00F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x2EF20E0", Offset = "0x2EF0EE0", VA = "0x182EF20E0")]
	public KNAJHPKNPDM(Exception ABJFFBJEJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface JLEECCFLDND : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task NFOALBONBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	LMAPELGHNPL AOIBAIHJCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface HBCJHPKGFFI<T> : JLEECCFLDND, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> NFOALBONBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::ONJEHKCKOLK<T> AOIBAIHJCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public abstract class OLHDHIKHBPA<TTask, T> : global::HBCJHPKGFFI<T>, JLEECCFLDND, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class BDAEDJMMEIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public global::OLHDHIKHBPA<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public BDAEDJMMEIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool CGCADJNKBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> JNBKFGCNLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource EGHIEJEBCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool JFHKLPCKLKK;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> NFOALBONBMO
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task MJNHFHJACGO
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::ONJEHKCKOLK<T> AOIBAIHJCAM
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private LMAPELGHNPL PNBNKIHNACH
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2780C20", Offset = "0x277FA20", VA = "0x182780C20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool NOIGHNNNJBE
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x82D580", Offset = "0x82C380", VA = "0x18082D580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x36BEDA0", Offset = "0x36BDBA0", VA = "0x1836BEDA0")]
	static OLHDHIKHBPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x36BF080", Offset = "0x36BDE80", VA = "0x1836BF080")]
	protected OLHDHIKHBPA(TTask JNBKFGCNLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x36BE820", Offset = "0x36BD620", VA = "0x1836BE820", Slot = "1")]
	~OLHDHIKHBPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x36BE7F0", Offset = "0x36BD5F0", VA = "0x1836BE7F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x36BE890", Offset = "0x36BD690", VA = "0x1836BE890")]
	private void HNJHICBJAJE(bool GMIOPLAMNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T HNNOFLINICM(TTask GIJDPMPADJF);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void HOJKAFOJKNK();
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface CMELLFLBHGF
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float GCANAAHABMB
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event CEPNOFNHPJD BAABBGGOLNC;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class BBENNLBOLIA : CMELLFLBHGF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public readonly struct DHANJHKGDML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public readonly float JAFMPPMJCJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float BIEKLAGKDBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		internal readonly bool FFNEOGDCCGC;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float LACBNDDFFOB
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x64E66B0", Offset = "0x64E54B0", VA = "0x1864E66B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x64E6840", Offset = "0x64E5640", VA = "0x1864E6840")]
		public DHANJHKGDML(float HJHFBPCCKIM, float HDNNAAICFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x64E66C0", Offset = "0x64E54C0", VA = "0x1864E66C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class ANKIPCPLLDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public BBENNLBOLIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public ANKIPCPLLDE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly int FPMMBKCOHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int KEHMKDFCFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly CMELLFLBHGF[] LPOEJOLMGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly CEPNOFNHPJD[] JPLBGCKPACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly DHANJHKGDML[] NJDMLGAEEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private DHANJHKGDML EJHHNLHNDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly NMEEJAJPDAO KKIOGJLGHLO;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public DHANJHKGDML GIFLECFFJDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xDCC3F0", Offset = "0xDCB1F0", VA = "0x180DCC3F0")]
		get
		{
			return default(DHANJHKGDML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float GCANAAHABMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x64E55E0", Offset = "0x64E43E0", VA = "0x1864E55E0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event CEPNOFNHPJD BAABBGGOLNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x64E5690", Offset = "0x64E4490", VA = "0x1864E5690", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x64E5340", Offset = "0x64E4140", VA = "0x1864E5340", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x64E5BF0", Offset = "0x64E49F0", VA = "0x1864E5BF0")]
	public BBENNLBOLIA(int FPMMBKCOHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x64E5600", Offset = "0x64E4400", VA = "0x1864E5600")]
	public NMEEJAJPDAO LIBJBMFBOGJ(DHANJHKGDML BIMJJIGDDCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x64E57A0", Offset = "0x64E45A0", VA = "0x1864E57A0")]
	public void OHANKPILFHI(CMELLFLBHGF OJBHJBBMCJC, [Optional] DHANJHKGDML MCCABDLOFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x64E5590", Offset = "0x64E4390", VA = "0x1864E5590")]
	internal int EAKNCNMGFIF(CMELLFLBHGF ODLNLJDHJPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x64E5750", Offset = "0x64E4550", VA = "0x1864E5750")]
	internal DHANJHKGDML NPLICPANNNC(int CPOAAGLEIPE)
	{
		return default(DHANJHKGDML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x64E5400", Offset = "0x64E4200", VA = "0x1864E5400", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public delegate void CEPNOFNHPJD(float IOMFBIJMHJD);
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class LDJIABFHLNG
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	internal const float AFFCIJGCIJA = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class LPBHFKEHGDH
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private class GOHDMDBKMKN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly CMELLFLBHGF ODLNLJDHJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly CEPNOFNHPJD JDLJMIHPPKE;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x64E82C0", Offset = "0x64E70C0", VA = "0x1864E82C0")]
		public GOHDMDBKMKN(CMELLFLBHGF ODLNLJDHJPL, CEPNOFNHPJD JDLJMIHPPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x64E8270", Offset = "0x64E7070", VA = "0x1864E8270", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x64E9E70", Offset = "0x64E8C70", VA = "0x1864E9E70")]
	internal static bool CLBHOFKDOBO(float FEIPFLDEPBD, float MIECAKFJHNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x49BE2B0", Offset = "0x49BD0B0", VA = "0x1849BE2B0")]
	internal static float KJDPMBBHGLF(float FEIPFLDEPBD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x64E9EF0", Offset = "0x64E8CF0", VA = "0x1864E9EF0")]
	public static IDisposable JHHOEJDADJP(this CMELLFLBHGF ODLNLJDHJPL, CEPNOFNHPJD JDLJMIHPPKE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class NMEEJAJPDAO : CMELLFLBHGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float IOMFBIJMHJD;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float GCANAAHABMB
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x87B100", Offset = "0x879F00", VA = "0x18087B100", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x64EB700", Offset = "0x64EA500", VA = "0x1864EB700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event CEPNOFNHPJD BAABBGGOLNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x64EB660", Offset = "0x64EA460", VA = "0x1864EB660", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x64EB5C0", Offset = "0x64EA3C0", VA = "0x1864EB5C0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public NMEEJAJPDAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class DPLGNDCIDNM
{
	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x64E7B30", Offset = "0x64E6930", VA = "0x1864E7B30")]
	[NotNull]
	public static byte[] NCPMKIKIIND(this OMCDKJFFLCG EBHNPDEECPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x64E7AC0", Offset = "0x64E68C0", VA = "0x1864E7AC0")]
	[NotNull]
	public static byte[] NCPMKIKIIND(this OMCDKJFFLCG EBHNPDEECPM, HashAlgorithmName NCAGKGBCNEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x64E7790", Offset = "0x64E6590", VA = "0x1864E7790")]
	public static bool IHPJICHLEBK([CanBeNull] this OMCDKJFFLCG EBHNPDEECPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x64E7920", Offset = "0x64E6720", VA = "0x1864E7920")]
	public static bool IHPJICHLEBK([CanBeNull] this OMCDKJFFLCG EBHNPDEECPM, out string EDMHEICKIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x64E7720", Offset = "0x64E6520", VA = "0x1864E7720")]
	private static string ELJDEHCCKGE([CanBeNull] byte[] NJGGJPEFKKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x64E7600", Offset = "0x64E6400", VA = "0x1864E7600")]
	private static bool BDKPLPKAIHE([NotNull] OMCDKJFFLCG EBHNPDEECPM, [CanBeNull] out byte[] BJCKJBLHKIE, [CanBeNull] out byte[] KCOFMEALBOL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class OKJGKMBMLCH
{
	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x64EB7C0", Offset = "0x64EA5C0", VA = "0x1864EB7C0")]
	[NotNull]
	public static byte[] NCPMKIKIIND(this HGMLOMJHBJD FHCBEEMOOFI, byte[] IKHCMKIIMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x64EB800", Offset = "0x64EA600", VA = "0x1864EB800")]
	[NotNull]
	public static byte[] NCPMKIKIIND(this HGMLOMJHBJD FHCBEEMOOFI, HashAlgorithmName NCAGKGBCNEO, byte[] IKHCMKIIMGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface HGMLOMJHBJD
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash HJECOOILIMC);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface OMCDKJFFLCG : HGMLOMJHBJD
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] ADNKLONAACD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	[CanBeNull]
	byte[] DPHPLCGOODP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object NKAPKOLFPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class MOKPAOJFAEP
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private class DLPNEKMOKKF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x64E6A20", Offset = "0x64E5820", VA = "0x1864E6A20")]
		public DLPNEKMOKKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x64E69C0", Offset = "0x64E57C0", VA = "0x1864E69C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private const byte ABGMJPMMAHC = 1;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte PGOPPNDGNBL = 0;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly ArrayPool<byte> MHEBKAKCCEB;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static bool LEOIKDDIAKA;

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x2E7C410", Offset = "0x2E7B210", VA = "0x182E7C410")]
	[Conditional("UNITY_EDITOR")]
	private static void BBNEJACCLBN<T>(params T[] MNFAIKFPFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x64EA3A0", Offset = "0x64E91A0", VA = "0x1864EA3A0")]
	public static IDisposable ANOJEMMEDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x64EB2B0", Offset = "0x64EA0B0", VA = "0x1864EB2B0")]
	public static void PLFOJJBEGPO(this IncrementalHash JOIPBEEGBLL, [CanBeNull] GameObject AAMBGNNHMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2E7D2E0", Offset = "0x2E7C0E0", VA = "0x182E7D2E0")]
	public static void PLFOJJBEGPO<T>(this IncrementalHash JOIPBEEGBLL, [CanBeNull] T BJCJNGNNING) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2E7CDF0", Offset = "0x2E7BBF0", VA = "0x182E7CDF0")]
	public static void CBFPIDPOHLD<T>(this IncrementalHash JOIPBEEGBLL, [CanBeNull] T FHCBEEMOOFI) where T : HGMLOMJHBJD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2E7CE80", Offset = "0x2E7BC80", VA = "0x182E7CE80")]
	public static void LJOLOLGBINL<T>(this IncrementalHash JOIPBEEGBLL, [CanBeNull] IList<T> NDMAEBLHCEA) where T : HGMLOMJHBJD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x64EAAE0", Offset = "0x64E98E0", VA = "0x1864EAAE0")]
	private static bool FIFCCMPJKCO([CanBeNull] HGMLOMJHBJD FHCBEEMOOFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x64EB250", Offset = "0x64EA050", VA = "0x1864EB250")]
	public static void PFMBAHJPCMJ(this IncrementalHash HJECOOILIMC, [CanBeNull] string KHDCKMOGBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x64EA910", Offset = "0x64E9710", VA = "0x1864EA910")]
	public static void DNBKENLGLLD(this IncrementalHash HJECOOILIMC, long FFNAINCBEKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x64EAF10", Offset = "0x64E9D10", VA = "0x1864EAF10")]
	public static void LJCEMDANOBH(this IncrementalHash HJECOOILIMC, int NGMLBCJJKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x64EA740", Offset = "0x64E9540", VA = "0x1864EA740")]
	public static void DLECMCONBNF(this IncrementalHash HJECOOILIMC, short DJGJBMADFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x64EB0E0", Offset = "0x64E9EE0", VA = "0x1864EB0E0")]
	public static void OMGPBOOPGAJ(this IncrementalHash HJECOOILIMC, byte AFBAIPANJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x64EAD40", Offset = "0x64E9B40", VA = "0x1864EAD40")]
	public static void JHFBHHGPOKE(this IncrementalHash HJECOOILIMC, bool BJNJOFOPGPC, bool ODMECEAENFK = false, bool LIDMFNMBFHB = false, bool HNHPLGHBADH = false, bool FEDDFMGMHOO = false, bool MMDNCHABBCI = false, bool LCFOHDHOJBA = false, bool APKMLHGPDIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2E7C700", Offset = "0x2E7B500", VA = "0x182E7C700")]
	public static void BONLBDEDCMI<T>(this IncrementalHash HJECOOILIMC, T NNGLOLHLJEH) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x64EA440", Offset = "0x64E9240", VA = "0x1864EA440")]
	public static void BKHGGJGJHAI(this IncrementalHash HJECOOILIMC, float IPDJNOBBBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x64EB3A0", Offset = "0x64EA1A0", VA = "0x1864EB3A0")]
	public static void POADMGPHNEG(this IncrementalHash HJECOOILIMC, double LCDBAFILABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x64EA510", Offset = "0x64E9310", VA = "0x1864EA510")]
	public static void DCEAPNCPPGJ(this IncrementalHash HJECOOILIMC, ulong AEOLLNHEFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x64EACE0", Offset = "0x64E9AE0", VA = "0x1864EACE0")]
	public static void JDJPJJGIGCF(this IncrementalHash HJECOOILIMC, uint AGNNFNKJKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x64EA4A0", Offset = "0x64E92A0", VA = "0x1864EA4A0")]
	public static void COADPANJMFJ(this IncrementalHash HJECOOILIMC, ushort JBBMNMGPPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x64EAB70", Offset = "0x64E9970", VA = "0x1864EAB70")]
	public static void HDHGACDBFJB(this IncrementalHash HJECOOILIMC, Vector3 MOJGIIMIJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x64EA580", Offset = "0x64E9380", VA = "0x1864EA580")]
	public static void DENJMJBFFFK(this IncrementalHash HJECOOILIMC, Quaternion JDNCAADPJCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class HHKGMDBAAEL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly Type DCGHHIKOCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly string DEIMNPGJIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly bool EMABLNDCLFM;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x64E8440", Offset = "0x64E7240", VA = "0x1864E8440")]
	public HHKGMDBAAEL(Type JOPACEIBBHM, string FJDMHDBBLDB, bool EGJAPHPCEBI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class FBKBKCMKGOE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x64E80A0", Offset = "0x64E6EA0", VA = "0x1864E80A0")]
	public FBKBKCMKGOE(string GNDOGDAIOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x64E8020", Offset = "0x64E6E20", VA = "0x1864E8020")]
	public FBKBKCMKGOE(string GNDOGDAIOKH, Exception HPLLHKLNNGP)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x6DA060", Offset = "0x6D8E60", VA = "0x1806DA060")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x768420", Offset = "0x767220", VA = "0x180768420")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int MHNCIMAMLJL, int DOBOABGHHFJ]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x3C50F60", Offset = "0x3C4FD60", VA = "0x183C50F60")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x3C51000", Offset = "0x3C4FE00", VA = "0x183C51000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x3C50ED0", Offset = "0x3C4FCD0", VA = "0x183C50ED0")]
		public Array2D(uint FLPAOFBCNFM, uint BDNEGOJDOMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x3C50E50", Offset = "0x3C4FC50", VA = "0x183C50E50")]
		public void FDAOBHPPNLM()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x64E5060", Offset = "0x64E3E60", VA = "0x1864E5060")]
		public Array2DVector3(uint FLPAOFBCNFM, uint BDNEGOJDOMD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct KBHMEKHGBOP
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public delegate bool CJKCKPGBIHO(string AGDLOHFCDCO, KBHMEKHGBOP EOFELBHHAGF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public int NNGLOLHLJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public string PPIDKPEDBEB;

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x64E93A0", Offset = "0x64E81A0", VA = "0x1864E93A0")]
	public static Dictionary<string, KBHMEKHGBOP> CFIAFMFAMBG(Type HGBKBJDELGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x64E9070", Offset = "0x64E7E70", VA = "0x1864E9070")]
	public static Dictionary<string, KBHMEKHGBOP> ALBJJADNLCM(Type HGBKBJDELGO, CJKCKPGBIHO PCLLHIMJLJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x64E9690", Offset = "0x64E8490", VA = "0x1864E9690")]
	public static Dictionary<int, string> GGHIEFMFBKE(Dictionary<string, KBHMEKHGBOP> HOKEJKCPCMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal static class PNIEAMICGMN
{
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public const int AJNKODFGOHI = -1;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public const int APJHFABOKNL = 0;
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[DefaultMember("Item")]
public class LHIFGMDEFMC<THandle, TValue> : IDisposable where THandle : struct, MNGNANHHIDL where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly List<THandle> KGOPFMGEEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly List<TValue> EHBFOFELEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly Func<TValue> DJPFGKEBKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly Action<TValue> KLINJLEOKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private int INCKGHOAAOM;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x2FED1B0", Offset = "0x2FEBFB0", VA = "0x182FED1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x2FEDC00", Offset = "0x2FECA00", VA = "0x182FEDC00")]
	public LHIFGMDEFMC(Action<TValue> KLINJLEOKAG, [Optional] Func<TValue> DJPFGKEBKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2FED2D0", Offset = "0x2FEC0D0", VA = "0x182FED2D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2FED5D0", Offset = "0x2FEC3D0", VA = "0x182FED5D0")]
	public THandle FBMANFCLCAO()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2FED0F0", Offset = "0x2FEBEF0", VA = "0x182FED0F0")]
	public THandle AHKNMMEAEHA(TValue NLHFEJHKLAH)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x2FED8D0", Offset = "0x2FEC6D0", VA = "0x182FED8D0")]
	public bool IHKCCNMHHEB(THandle EFHAIHKDJDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2FED350", Offset = "0x2FEC150", VA = "0x182FED350")]
	public bool ECKNMJDFBGK(THandle EFHAIHKDJDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2FEDB60", Offset = "0x2FEC960", VA = "0x182FEDB60")]
	public bool OOMGGBPLIIB(THandle EFHAIHKDJDK, out TValue NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2FED160", Offset = "0x2FEBF60", VA = "0x182FED160")]
	public TValue BPAEGFNIDAI(THandle EFHAIHKDJDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2FED7C0", Offset = "0x2FEC5C0", VA = "0x182FED7C0")]
	public bool HKAKAEDOFMA(THandle EFHAIHKDJDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2FED980", Offset = "0x2FEC780", VA = "0x182FED980")]
	private THandle JNEAKFHKLDG(int CPOAAGLEIPE)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2FED790", Offset = "0x2FEC590", VA = "0x182FED790")]
	private TValue GMDGPINAMDC(int CPOAAGLEIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2FED670", Offset = "0x2FEC470", VA = "0x182FED670")]
	private void FKABLIKPLNA(int CPOAAGLEIPE, in THandle EFHAIHKDJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2FED290", Offset = "0x2FEC090", VA = "0x182FED290")]
	private void DJFHMHBCIBN(int CPOAAGLEIPE, in TValue NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2FED420", Offset = "0x2FEC220", VA = "0x182FED420")]
	private THandle EOCFMGEMJIP()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2FED1E0", Offset = "0x2FEBFE0", VA = "0x182FED1E0")]
	private void CLEIHNKKLHG(THandle EFHAIHKDJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x2FED9B0", Offset = "0x2FEC7B0", VA = "0x182FED9B0")]
	private int KDPPOECPFGF(int CPFPNOFCGCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x2FED6B0", Offset = "0x2FEC4B0", VA = "0x182FED6B0")]
	private bool GIACKACCBBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x8605F0", Offset = "0x85F3F0", VA = "0x1808605F0")]
	private void LGMFLNJHBOC(THandle EFHAIHKDJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x2FED9C0", Offset = "0x2FEC7C0", VA = "0x182FED9C0")]
	private bool LADFBLDNDAN(out THandle EFHAIHKDJDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x2FED6C0", Offset = "0x2FEC4C0", VA = "0x182FED6C0")]
	private bool GLDIPKGAOJA(out THandle EFHAIHKDJDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x2FED870", Offset = "0x2FEC670", VA = "0x182FED870")]
	private void IDGGCCLLKHL(THandle EFHAIHKDJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x2FEDA40", Offset = "0x2FEC840", VA = "0x182FEDA40")]
	private void NHLOENEAFLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface MNGNANHHIDL
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int HGGIJKLHICO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int LFENOMEJLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public interface IODKAPMFEOL<T> : MNGNANHHIDL, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class BJHMBAALHOJ
{
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0xE53810", Offset = "0xE52610", VA = "0x180E53810")]
	public static bool NMKJEHNJACL<T>(this T EFHAIHKDJDK, T ONICAEEHHFG) where T : struct, MNGNANHHIDL
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x28401E0", Offset = "0x283EFE0", VA = "0x1828401E0")]
	public static bool FFNEOGDCCGC<T>(this T EFHAIHKDJDK) where T : struct, MNGNANHHIDL
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x64E5D70", Offset = "0x64E4B70", VA = "0x1864E5D70")]
	public static string COOOGJIOIKH(this MNGNANHHIDL EFHAIHKDJDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class PCAFBCGAOIO
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private enum NFHCHCIECPJ : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private int HJECOOILIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private bool AFPNKEFNDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private NFHCHCIECPJ NNMLCFCBKLN;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool BHEOFCJHCHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x64EC250", Offset = "0x64EB050", VA = "0x1864EC250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool AODPPKELFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x64EC910", Offset = "0x64EB710", VA = "0x1864EC910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x64EC920", Offset = "0x64EB720", VA = "0x1864EC920")]
	public PCAFBCGAOIO(bool AFPNKEFNDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x64EBA30", Offset = "0x64EA830", VA = "0x1864EBA30")]
	public void ALKCHDELAPK(object BLIKPCIFNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x64EC140", Offset = "0x64EAF40", VA = "0x1864EC140")]
	public void CEDAKPGFDBB(int NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x64EC890", Offset = "0x64EB690", VA = "0x1864EC890")]
	public void IDOBDKBNJAJ(uint MMOPPGDICED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x64EC0B0", Offset = "0x64EAEB0", VA = "0x1864EC0B0")]
	public void BOHJDHKJHBG(bool FFENPMKEEJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x64EC260", Offset = "0x64EB060", VA = "0x1864EC260")]
	public void DAKLHMMMADF(long AEEDIGMAOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x64EC3B0", Offset = "0x64EB1B0", VA = "0x1864EC3B0")]
	public void GDODJDMGDGL(ulong INBHEAFDOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x64EC1E0", Offset = "0x64EAFE0", VA = "0x1864EC1E0")]
	public void CEOONCKJCHD(string HAGBHFAOFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x64EC2B0", Offset = "0x64EB0B0", VA = "0x1864EC2B0")]
	public void GAECOFMIDAE(Enum ABJFFBJEJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x64EC3F0", Offset = "0x64EB1F0", VA = "0x1864EC3F0")]
	public void GLAIILOIIGM(IList LLMBPPCBLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x24AD070", Offset = "0x24ABE70", VA = "0x1824AD070")]
	public void ONIMMCEKMJO<T, U>(Dictionary<T, U> ACEGKOBDPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x64EC520", Offset = "0x64EB320", VA = "0x1864EC520")]
	private void IBLLLJCNCAM(IDictionary ACEGKOBDPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x64EC0D0", Offset = "0x64EAED0", VA = "0x1864EC0D0")]
	public int CABIGPDEOIB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x64EC340", Offset = "0x64EB140", VA = "0x1864EC340")]
	public short GDHGBNEOHDI()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x64EC2A0", Offset = "0x64EB0A0", VA = "0x1864EC2A0")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x64EC8A0", Offset = "0x64EB6A0", VA = "0x1864EC8A0")]
	private void LKHKDAHOKHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public abstract class BEOAEFKOPFG<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	internal class ENJFLIIOOJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public TNode CNBAEMLJEBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public TNode AABHIBJPKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public CGHOHJLMIGH JANOPLPFDEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public List<CGHOHJLMIGH> HJMPODCACJP;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public ENJFLIIOOJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	internal struct CGHOHJLMIGH : IComparable<CGHOHJLMIGH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int PEOIJCAMOPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public TClaimant ILCOLCHLOPE;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x800F90", Offset = "0x7FFD90", VA = "0x180800F90")]
		public CGHOHJLMIGH(int PEOIJCAMOPO, TClaimant ILCOLCHLOPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x35796D0", Offset = "0x35784D0", VA = "0x1835796D0")]
		public bool LOKGFBHMHKN(in CGHOHJLMIGH ONICAEEHHFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x35796C0", Offset = "0x35784C0", VA = "0x1835796C0")]
		public bool GGOAHADJCGI(in CGHOHJLMIGH ONICAEEHHFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x35796B0", Offset = "0x35784B0", VA = "0x1835796B0", Slot = "4")]
		public int CompareTo(CGHOHJLMIGH ONICAEEHHFG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x3579730", Offset = "0x3578530", VA = "0x183579730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public enum MNEHCHMAAIN
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class AJDLFDPHEPA : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public global::BEOAEFKOPFG<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0850", Offset = "0x2ABF650", VA = "0x182AC0850")]
		[DebuggerHidden]
		public AJDLFDPHEPA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2C37CD0", Offset = "0x2C36AD0", VA = "0x182C37CD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x2C37E90", Offset = "0x2C36C90", VA = "0x182C37E90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x2C37DB0", Offset = "0x2C36BB0", VA = "0x182C37DB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x2771140", Offset = "0x276FF40", VA = "0x182771140", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly global::IAIPNGJOAOF<ENJFLIIOOJN> HHEAPKMAAPP;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly global::IAIPNGJOAOF<List<CGHOHJLMIGH>> OEJCMPBNHAO;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static int KIJLHGGOBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	internal readonly Dictionary<TClaimant, TNode> NEIGPGNOGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	internal readonly Dictionary<TNode, ENJFLIIOOJN> HFCNKAHNGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private MNEHCHMAAIN FOMLKLNHMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private bool LKLAHNKMKAI;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode FANBPIBOJLO(TNode CKNHANKHIBG);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void IDFACHMGFCD(TNode CKNHANKHIBG, TClaimant LENIHDHLMCP, TClaimant CGPJMAMLFPJ);

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x29799A0", Offset = "0x29787A0", VA = "0x1829799A0")]
	public BEOAEFKOPFG(MNEHCHMAAIN FOMLKLNHMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x2978FB0", Offset = "0x2977DB0", VA = "0x182978FB0")]
	public void IDAHCOOOEFP(TNode CKNHANKHIBG, TNode BANCJNAJPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2978590", Offset = "0x2977390", VA = "0x182978590")]
	public void APLENHFEHIG(TClaimant ILCOLCHLOPE, TNode OJDFKCFNPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2978920", Offset = "0x2977720", VA = "0x182978920", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2979090", Offset = "0x2977E90", VA = "0x182979090")]
	private void LOEBPKEFDFJ(TClaimant ILCOLCHLOPE, TNode MPALAMBLIDE, TNode OJDFKCFNPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x2979030", Offset = "0x2977E30", VA = "0x182979030")]
	private int JPLAMGBJDHN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x29782E0", Offset = "0x29770E0", VA = "0x1829782E0")]
	private void ADOEAMEIABC(TClaimant ILCOLCHLOPE, TNode IHDPPAIDCGA, TNode FPEOKJIPIBA, int AALJKBOMDIA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2978250", Offset = "0x2977050", VA = "0x182978250")]
	private void ABCIGFMHHPH(CGHOHJLMIGH EMMLLIPGCBP, ENJFLIIOOJN PBDMJBPFBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2979240", Offset = "0x2978040", VA = "0x182979240")]
	private void NLPOKAEFFNG(TClaimant ILCOLCHLOPE, TNode IHDPPAIDCGA, TNode FPEOKJIPIBA, int AALJKBOMDIA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2979730", Offset = "0x2978530", VA = "0x182979730")]
	private void PLLIKDPCEGB(CGHOHJLMIGH EMMLLIPGCBP, TNode CKNHANKHIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x29794A0", Offset = "0x29782A0", VA = "0x1829794A0")]
	private void PJAOPJAHBNK(CGHOHJLMIGH EMMLLIPGCBP, ENJFLIIOOJN PBDMJBPFBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2979130", Offset = "0x2977F30", VA = "0x182979130")]
	private void NFMFEFJGDAJ(ENJFLIIOOJN PBDMJBPFBLI, bool LGBIJIHEJKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2978B80", Offset = "0x2977980", VA = "0x182978B80")]
	private void EDGOIIHJNAC(ENJFLIIOOJN PBDMJBPFBLI, TNode BANCJNAJPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x2978690", Offset = "0x2977490", VA = "0x182978690")]
	[IteratorStateMachine(typeof(global::BEOAEFKOPFG<, >.AJDLFDPHEPA))]
	private IEnumerable<TNode> BGMLCODJHJC(TNode IHDPPAIDCGA, TNode FPEOKJIPIBA, bool KGJENDDBJAC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2978EF0", Offset = "0x2977CF0", VA = "0x182978EF0")]
	private ENJFLIIOOJN HOOFLJPPJKI(TNode CKNHANKHIBG, TNode AABHIBJPKOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x29795A0", Offset = "0x29783A0", VA = "0x1829795A0")]
	private ENJFLIIOOJN PJEKPKMMKFI(TNode CKNHANKHIBG, TNode AABHIBJPKOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2978760", Offset = "0x2977560", VA = "0x182978760")]
	private void CGGFBCMCFOJ(ENJFLIIOOJN PBDMJBPFBLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class NCCMGMLGJKO<T> : IEnumerable<global::NCCMGMLGJKO<T>.FGCKOMJEIKG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public struct FGCKOMJEIKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public T NLHFEJHKLAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public int CPOAAGLEIPE;
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class MPFDOJOPPOO : IEnumerator<FGCKOMJEIKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private global::NCCMGMLGJKO<T> IEPEFMMEENM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private int CPOAAGLEIPE;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x18D9080", Offset = "0x18D7E80", VA = "0x1818D9080", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public FGCKOMJEIKG MPEDNLDPMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x3979380", Offset = "0x3978180", VA = "0x183979380", Slot = "4")]
			get
			{
				return default(FGCKOMJEIKG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x9C8340", Offset = "0x9C7140", VA = "0x1809C8340")]
		public MPFDOJOPPOO(global::NCCMGMLGJKO<T> IEPEFMMEENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x3979280", Offset = "0x3978080", VA = "0x183979280", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x9C8330", Offset = "0x9C7130", VA = "0x1809C8330", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xBB6EC0", Offset = "0xBB5CC0", VA = "0x180BB6EC0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private struct CLCOCHOGJCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public bool LGKEBFOACAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T NLHFEJHKLAH;
	}

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int FJEIDFDBDOI = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly Dictionary<T, int> HGBILAFCNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private CLCOCHOGJCN[] EDLKHIKHHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private int FCHKPCNFMHG;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int IFAJOLLKFAB
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x7B57D0", Offset = "0x7B45D0", VA = "0x1807B57D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8A7610", Offset = "0x8A6410", VA = "0x1808A7610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x2642890", Offset = "0x2641690", VA = "0x182642890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x390B120", Offset = "0x3909F20", VA = "0x18390B120")]
	public NCCMGMLGJKO(int FPMMBKCOHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x390B200", Offset = "0x390A000", VA = "0x18390B200")]
	public NCCMGMLGJKO(FGCKOMJEIKG[] PIJHGEFGNKO, bool IAABPOFOOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x390AB90", Offset = "0x3909990", VA = "0x18390AB90")]
	public int GHLLNJLMANH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x390A040", Offset = "0x3908E40", VA = "0x18390A040")]
	private int CNNCFIMJFMB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x3909F30", Offset = "0x3908D30", VA = "0x183909F30", Slot = "6")]
	protected virtual uint AMHJLJNGCKF(uint HJECOOILIMC, T NLHFEJHKLAH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x3909FB0", Offset = "0x3908DB0", VA = "0x183909FB0")]
	public bool BDDGBCAOHCA(T NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x390AE80", Offset = "0x3909C80", VA = "0x18390AE80")]
	public bool MAPODJEGJNM(int CPOAAGLEIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x390AFD0", Offset = "0x3909DD0", VA = "0x18390AFD0")]
	public bool PGDHOKOGAJF(Func<T, bool> NPAKBFKDFCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x390ADD0", Offset = "0x3909BD0", VA = "0x18390ADD0")]
	public int JHMEDDLKAGC(T NLHFEJHKLAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x390AC60", Offset = "0x3909A60", VA = "0x18390AC60")]
	public T GMDGPINAMDC(int CPOAAGLEIPE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x390A8A0", Offset = "0x39096A0", VA = "0x18390A8A0")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x390A860", Offset = "0x3909660", VA = "0x18390A860")]
	public bool COOLJMALOJN(T NLHFEJHKLAH, bool JGHIEJJEANE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x390A430", Offset = "0x3909230", VA = "0x18390A430")]
	public bool COOLJMALOJN(T NLHFEJHKLAH, int CPOAAGLEIPE, bool JGHIEJJEANE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x390AD40", Offset = "0x3909B40", VA = "0x18390AD40")]
	public bool IHKCCNMHHEB(T NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x3909FF0", Offset = "0x3908DF0", VA = "0x183909FF0")]
	public bool BPJGFIPNNHC(int CPOAAGLEIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x390A9C0", Offset = "0x39097C0", VA = "0x18390A9C0")]
	private void GCHOMDGPEKF(int CPOAAGLEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x3909C80", Offset = "0x3908A80", VA = "0x183909C80")]
	public FGCKOMJEIKG[] ADDGACCNMHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x390A920", Offset = "0x3909720", VA = "0x18390A920")]
	private int FJGNLGFKCEC(int PGFGHPKFPLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x390B0A0", Offset = "0x3909EA0", VA = "0x18390B0A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x390B0A0", Offset = "0x3909EA0", VA = "0x18390B0A0", Slot = "4")]
	private IEnumerator<FGCKOMJEIKG> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct GKJGJALMCAC<Handle> where Handle : MNGNANHHIDL, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private struct AEDFEEFEOFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly global::GKJGJALMCAC<Handle> HKCJHIDMENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private int CPOAAGLEIPE;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int EGGCDBBOOKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x2C28DF0", Offset = "0x2C27BF0", VA = "0x182C28DF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle KIPEOBFMGKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x2C29190", Offset = "0x2C27F90", VA = "0x182C29190")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x2C29B70", Offset = "0x2C28970", VA = "0x182C29B70")]
		public AEDFEEFEOFD(global::GKJGJALMCAC<Handle> HKCJHIDMENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x2C295B0", Offset = "0x2C283B0", VA = "0x182C295B0")]
		public GHPCOECDFHI LBKFKMLCCNN(in GHPCOECDFHI CEIGCFEFIIO)
		{
			return default(GHPCOECDFHI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x2C29650", Offset = "0x2C28450", VA = "0x182C29650")]
		public ECMCBKEFBDB LBKFKMLCCNN(in ECMCBKEFBDB CEIGCFEFIIO)
		{
			return default(ECMCBKEFBDB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x2C29A50", Offset = "0x2C28850", VA = "0x182C29A50")]
		public bool NEMKFFAFJOI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x2C28A50", Offset = "0x2C27850", VA = "0x182C28A50")]
		private int BJMLDCKIEKN(string GNDOGDAIOKH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x2C28F40", Offset = "0x2C27D40", VA = "0x182C28F40")]
		private Handle GMNLEKCLDON(string GNDOGDAIOKH)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public struct GHPCOECDFHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private AEDFEEFEOFD GDKLJPPHLGP;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int MPEDNLDPMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x3C1F3F0", Offset = "0x3C1E1F0", VA = "0x183C1F3F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x33B17C0", Offset = "0x33B05C0", VA = "0x1833B17C0")]
		public GHPCOECDFHI(global::GKJGJALMCAC<Handle> HKCJHIDMENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x33B1780", Offset = "0x33B0580", VA = "0x1833B1780")]
		public bool NEMKFFAFJOI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x3C1F330", Offset = "0x3C1E130", VA = "0x183C1F330")]
		public GHPCOECDFHI FGLPNHJPKAJ()
		{
			return default(GHPCOECDFHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public struct ECMCBKEFBDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private AEDFEEFEOFD GDKLJPPHLGP;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle MPEDNLDPMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x33B15C0", Offset = "0x33B03C0", VA = "0x1833B15C0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x33B17C0", Offset = "0x33B05C0", VA = "0x1833B17C0")]
		public ECMCBKEFBDB(global::GKJGJALMCAC<Handle> HKCJHIDMENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x33B1780", Offset = "0x33B0580", VA = "0x1833B1780")]
		public bool NEMKFFAFJOI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x33B1540", Offset = "0x33B0340", VA = "0x1833B1540")]
		public ECMCBKEFBDB FGLPNHJPKAJ()
		{
			return default(ECMCBKEFBDB);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private NativeList<int> OJDIADOIJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private NativeList<int> KBDCLIJIDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private int NGNJFIMBOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private int CGBLKEGOAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private bool JFBIJKKKKIE;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool AMFLHOGACPG
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x82D580", Offset = "0x82C380", VA = "0x18082D580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int BACNEHOFKKO
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x3C2C9E0", Offset = "0x3C2B7E0", VA = "0x183C2C9E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int PHPFBEOFBCH
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x6F68E0", Offset = "0x6F56E0", VA = "0x1806F68E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int FNLJIGLKCGF
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x6F68E0", Offset = "0x6F56E0", VA = "0x1806F68E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public GHPCOECDFHI ELLFMAGEAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x3C2CA60", Offset = "0x3C2B860", VA = "0x183C2CA60")]
		get
		{
			return default(GHPCOECDFHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public ECMCBKEFBDB AONHBDCJDFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x3C2C720", Offset = "0x3C2B520", VA = "0x183C2C720")]
		get
		{
			return default(ECMCBKEFBDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D130", Offset = "0x3C2BF30", VA = "0x183C2D130")]
	public GKJGJALMCAC(int GCCDCLBLDEA, Allocator HIEJKCFDMDD = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3C2B7E0", Offset = "0x3C2A5E0", VA = "0x183C2B7E0")]
	public void HNJHICBJAJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x24E0E30", Offset = "0x24DFC30", VA = "0x1824E0E30")]
	public static int KDPPOECPFGF(int PALFKPAOLKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x3C2CAE0", Offset = "0x3C2B8E0", VA = "0x183C2CAE0")]
	public static bool NOONKAMKKLI(int PALFKPAOLKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C950", Offset = "0x3C2B750", VA = "0x183C2C950")]
	public static bool MCLBFFLNIBO(int PALFKPAOLKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3C2A820", Offset = "0x3C29620", VA = "0x183C2A820")]
	public bool DNKDHLPMIAO(int CPOAAGLEIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x3C29E20", Offset = "0x3C28C20", VA = "0x183C29E20")]
	public bool CBPFLKCHECM(int CPOAAGLEIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x3C2CEA0", Offset = "0x3C2BCA0", VA = "0x183C2CEA0")]
	public bool ONLFFAHPLIJ(Handle EFHAIHKDJDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x3C2BAE0", Offset = "0x3C2A8E0", VA = "0x183C2BAE0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void JCHGHNMCEGB(Handle EFHAIHKDJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x3C2A1B0", Offset = "0x3C28FB0", VA = "0x183C2A1B0")]
	public Handle CMCHJEFFKCF()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x3C297C0", Offset = "0x3C285C0", VA = "0x183C297C0")]
	public void BGMDJHAHEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x3C28D90", Offset = "0x3C27B90", VA = "0x183C28D90")]
	public void BEGMOAJFNPG(Handle EFHAIHKDJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x3C2B010", Offset = "0x3C29E10", VA = "0x183C2B010")]
	public bool HDMJAMOFPKE(Handle EFHAIHKDJDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x82D580", Offset = "0x82C380", VA = "0x18082D580")]
	private bool MJFPGACKCEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D070", Offset = "0x3C2BE70", VA = "0x183C2D070")]
	private bool OPIGIKHJBAG(int CPOAAGLEIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x3C2B220", Offset = "0x3C2A020", VA = "0x183C2B220")]
	private void HMPGPFFGCHC(out int CPOAAGLEIPE, out int CPFPNOFCGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x3C2A620", Offset = "0x3C29420", VA = "0x183C2A620")]
	private void DNJAPHJDBHA(Handle EFHAIHKDJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x3C2A320", Offset = "0x3C29120", VA = "0x183C2A320")]
	private void DHGLCDEGOBG(int CPOAAGLEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x3C2AEB0", Offset = "0x3C29CB0", VA = "0x183C2AEB0")]
	private bool GAEBMMMJKLD(out int CPOAAGLEIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C8B0", Offset = "0x3C2B6B0", VA = "0x183C2C8B0")]
	private static Handle LOFPAEEIOIC(int CPOAAGLEIPE, int CPFPNOFCGCI)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[DefaultMember("Item")]
public struct OBLKPMNJCIK<Handle, T> where Handle : MNGNANHHIDL, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private global::GKJGJALMCAC<Handle> IOPHEEEPIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private T[] KHMBBLMNJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private Action<T> LBFBKGJJPAD;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool AMFLHOGACPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x2947E40", Offset = "0x2946C40", VA = "0x182947E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int BACNEHOFKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x29482D0", Offset = "0x29470D0", VA = "0x1829482D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x2947E10", Offset = "0x2946C10", VA = "0x182947E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x2947B80", Offset = "0x2946980", VA = "0x182947B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x2948800", Offset = "0x2947600", VA = "0x182948800")]
	public OBLKPMNJCIK(int GCCDCLBLDEA, [Optional] Action<T> LBFBKGJJPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x2947BE0", Offset = "0x29469E0", VA = "0x182947BE0")]
	public void HNJHICBJAJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2948700", Offset = "0x2947500", VA = "0x182948700")]
	public bool ONLFFAHPLIJ(Handle EFHAIHKDJDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void JCHGHNMCEGB(Handle EFHAIHKDJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2947AE0", Offset = "0x29468E0", VA = "0x182947AE0")]
	public T BPAEGFNIDAI(Handle EFHAIHKDJDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2948750", Offset = "0x2947550", VA = "0x182948750")]
	public bool OOMGGBPLIIB(Handle EFHAIHKDJDK, out T BLIKPCIFNNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x2948540", Offset = "0x2947340", VA = "0x182948540")]
	public void NIPKJFNBLBF(Handle EFHAIHKDJDK, T OEIGHJKDDFO, out T AGNIHHADEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x29485E0", Offset = "0x29473E0", VA = "0x1829485E0")]
	public void NIPKJFNBLBF(Handle EFHAIHKDJDK, T OEIGHJKDDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x29481E0", Offset = "0x2946FE0", VA = "0x1829481E0")]
	public bool MELDEDNCFHO(Handle EFHAIHKDJDK, T OEIGHJKDDFO, out T AGNIHHADEED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x2948100", Offset = "0x2946F00", VA = "0x182948100")]
	public bool MELDEDNCFHO(Handle EFHAIHKDJDK, T OEIGHJKDDFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x29479E0", Offset = "0x29467E0", VA = "0x1829479E0")]
	public Handle AHKNMMEAEHA(T BLIKPCIFNNO)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x2948310", Offset = "0x2947110", VA = "0x182948310")]
	public void NDDPAGENINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2947D40", Offset = "0x2946B40", VA = "0x182947D40")]
	public void IHKCCNMHHEB(Handle EFHAIHKDJDK, out T AGNIHHADEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x2947C70", Offset = "0x2946A70", VA = "0x182947C70")]
	public void IHKCCNMHHEB(Handle EFHAIHKDJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2947F40", Offset = "0x2946D40", VA = "0x182947F40")]
	public bool LPOFFMKJMIC(Handle EFHAIHKDJDK, out T AGNIHHADEED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2948020", Offset = "0x2946E20", VA = "0x182948020")]
	public bool LPOFFMKJMIC(Handle EFHAIHKDJDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x2947B20", Offset = "0x2946920", VA = "0x182947B20")]
	private T BPJGFIPNNHC(int CPOAAGLEIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2947E70", Offset = "0x2946C70", VA = "0x182947E70")]
	private void LDNDDAIJFAA(int DOICJGOFEBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class IAIPNGJOAOF<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Stack<T> HKCJHIDMENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly List<T> DCHKLIJJLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly int HKEJEGOGLAJ;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int PLLHEACCEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x2724520", Offset = "0x2723320", VA = "0x182724520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int AEHMMBLGJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6FB0", Offset = "0x2AA5DB0", VA = "0x182AA6FB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6A10", Offset = "0x2AA5810", VA = "0x182AA6A10")]
	public static global::IAIPNGJOAOF<T> GKPIAEDMOHN(int FPMMBKCOHLA = 0, int HKEJEGOGLAJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6C70", Offset = "0x2AA5A70", VA = "0x182AA6C70")]
	public static global::IAIPNGJOAOF<T> MMBAMFLKBMF(int FPMMBKCOHLA = 0, int HKEJEGOGLAJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6FE0", Offset = "0x2AA5DE0", VA = "0x182AA6FE0")]
	public IAIPNGJOAOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7020", Offset = "0x2AA5E20", VA = "0x182AA7020")]
	public IAIPNGJOAOF(int FPMMBKCOHLA, int HKEJEGOGLAJ = int.MaxValue, bool ICHEFMPLFAJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6AE0", Offset = "0x2AA58E0", VA = "0x182AA6AE0")]
	public T GPPFLJDNMKO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6960", Offset = "0x2AA5760", VA = "0x182AA6960")]
	public void GHJILDGPFOF(T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6EE0", Offset = "0x2AA5CE0", VA = "0x182AA6EE0")]
	private void ONAEEHKEDBC(T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6940", Offset = "0x2AA5740", VA = "0x182AA6940")]
	private void EPFCHODNOKE(T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6BF0", Offset = "0x2AA59F0", VA = "0x182AA6BF0")]
	[Conditional("DEBUG_BUILD")]
	private void JNOKPHNIHOO(T PBGCJHDJJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2AA67C0", Offset = "0x2AA55C0", VA = "0x182AA67C0")]
	[Conditional("DEBUG_BUILD")]
	private void DGPAJKGNCBK(T PBGCJHDJJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6850", Offset = "0x2AA5650", VA = "0x182AA6850", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6D40", Offset = "0x2AA5B40", VA = "0x182AA6D40")]
	private void NLOKJLALMCB(IEnumerable<T> EHBFOFELEHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class GJBHAOFKGMM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private Dictionary<int, T> PHBGHHDKNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private T NEAJFCEMODJ;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T AAGNIJGNLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x701A00", Offset = "0x700800", VA = "0x180701A00", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool OOBJLNLFEJE
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x3C1FDB0", Offset = "0x3C1EBB0", VA = "0x183C1FDB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x3C1F8A0", Offset = "0x3C1E6A0", VA = "0x183C1F8A0")]
	public bool LLJCPJLNFOC(T NLHFEJHKLAH, int PEOIJCAMOPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3C1F960", Offset = "0x3C1E760", VA = "0x183C1F960")]
	public bool MIHAOOFDKCE(int PEOIJCAMOPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3C1FBC0", Offset = "0x3C1E9C0", VA = "0x183C1FBC0")]
	public T OHCHBPKAHCC(int OKIDGNOPLCP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x3C1F6A0", Offset = "0x3C1E4A0", VA = "0x183C1F6A0")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x3C1F700", Offset = "0x3C1E500", VA = "0x183C1F700")]
	private bool KDDPKIIAOIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x3C1F670", Offset = "0x3C1E470", VA = "0x183C1F670")]
	public bool AMKBCCEHNAL(int PEOIJCAMOPO, out T NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x3C1FDF0", Offset = "0x3C1EBF0", VA = "0x183C1FDF0")]
	public GJBHAOFKGMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class KMHNLHNEABG<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	protected struct LHIHFFIIFEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public T DKPIGGFDHBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int NDNLMIFPDGL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	protected readonly List<LHIHFFIIFEA> IKFMHLLOBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private T KILGMPPNIAG;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x2642890", Offset = "0x2641690", VA = "0x182642890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x2EF0B80", Offset = "0x2EEF980", VA = "0x182EF0B80")]
	public bool PGDHOKOGAJF(T NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x2EF06C0", Offset = "0x2EEF4C0", VA = "0x182EF06C0")]
	public void AHKNMMEAEHA(T NLHFEJHKLAH, int PEOIJCAMOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x2EF08A0", Offset = "0x2EEF6A0", VA = "0x182EF08A0")]
	public bool IHKCCNMHHEB(T NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x2EF0840", Offset = "0x2EEF640", VA = "0x182EF0840")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x2EF07D0", Offset = "0x2EEF5D0", VA = "0x182EF07D0")]
	public T CFOEBLFAPBJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x2EF0760", Offset = "0x2EEF560", VA = "0x182EF0760")]
	public T BLMPNGAAAGK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x2EF09C0", Offset = "0x2EEF7C0", VA = "0x182EF09C0")]
	private void NMNMJAMDOFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x2EF0D90", Offset = "0x2EEFB90", VA = "0x182EF0D90")]
	public KMHNLHNEABG()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		[CGLCMPPNAMG(PCMMCGDMCAJ.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x64ECA80", Offset = "0x64EB880", VA = "0x1864ECA80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x64ECE10", Offset = "0x64EBC10", VA = "0x1864ECE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x64ECC90", Offset = "0x64EBA90", VA = "0x1864ECC90")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x64ECF70", Offset = "0x64EBD70", VA = "0x1864ECF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x64EC9A0", Offset = "0x64EB7A0", VA = "0x1864EC9A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x64ECD30", Offset = "0x64EBB30", VA = "0x1864ECD30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x64ECBB0", Offset = "0x64EB9B0", VA = "0x1864ECBB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x64EC950", Offset = "0x64EB750", VA = "0x1864EC950")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface HDJBIBONHBI
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public abstract class ResourcePrefabReference<T> : HDJBIBONHBI where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D89290", Offset = "0x2D88090", VA = "0x182D89290", Slot = "4")]
		public virtual T BBBIMOJJKJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class DMJDLLGILHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly Dictionary<byte, ECIPGPIGLPG> NDDIOCKHDFE;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public ECIPGPIGLPG DEEMFJJFMEM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F10", Offset = "0x6F6D10", VA = "0x1806F7F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 LAIDDJFILKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x9AE340", Offset = "0x9AD140", VA = "0x1809AE340")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x842E90", Offset = "0x841C90", VA = "0x180842E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 HCDKEBLMPCK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xBD4090", Offset = "0xBD2E90", VA = "0x180BD4090")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x887EA0", Offset = "0x886CA0", VA = "0x180887EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 NCPEHNLCBOA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x64E7100", Offset = "0x64E5F00", VA = "0x1864E7100")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x821110", Offset = "0x81FF10", VA = "0x180821110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int LOLLPBFIIEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7B5750", Offset = "0x7B4550", VA = "0x1807B5750")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x8605F0", Offset = "0x85F3F0", VA = "0x1808605F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x64E71A0", Offset = "0x64E5FA0", VA = "0x1864E71A0")]
	public DMJDLLGILHF(Bounds ECHNBCDFJBA, Vector2[] CIHOHPJCOEP, int ONJANJKOILA, byte PGFGHPKFPLO, float HNOPCOIODPD = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x64E7140", Offset = "0x64E5F40", VA = "0x1864E7140")]
	public ECIPGPIGLPG NPDFPKNHHKJ(byte CPOAAGLEIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x64E6C00", Offset = "0x64E5A00", VA = "0x1864E6C00")]
	public void AOMCMJPLFCI(Vector3 CBAKPHLPCPB, float HHMPHGCDGEG, float EPMFPBLBGNK, ref List<byte> HMHHCFGAPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x64E7120", Offset = "0x64E5F20", VA = "0x1864E7120")]
	public void NPADBCDBLOH(ECIPGPIGLPG.CFHGNGGDNNC FHMCGFLFDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x64E6AA0", Offset = "0x64E58A0", VA = "0x1864E6AA0")]
	private ECIPGPIGLPG AGCDEHPACDC(byte CPOAAGLEIPE, ECIPGPIGLPG.OIOHPELJPIG GBJFAKNMLBM, ECIPGPIGLPG AABHIBJPKOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x64E6D00", Offset = "0x64E5B00", VA = "0x1864E6D00")]
	private void BLGLPNNGJJM(ECIPGPIGLPG AABHIBJPKOH, Vector2[] CIHOHPJCOEP, int HINHGNABBKP, int IEOEIFIKIAA, int HGKAFAKPJPL, int PMALMJMMCEI, float HNOPCOIODPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class ECIPGPIGLPG
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public enum OIOHPELJPIG
	{
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public enum CFHGNGGDNNC
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public byte NOKJCDGHKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector3 INBOIMEFLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Vector3 LACBNDDFFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public Vector3 HHIFJKIIMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public Vector3 GGNOLFCMOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public OIOHPELJPIG DAKJODNADHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public ECIPGPIGLPG KFPCMBOLNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public List<ECIPGPIGLPG> KMHNCEMLGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public bool KFHKCOLFGPI;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x64E7FA0", Offset = "0x64E6DA0", VA = "0x1864E7FA0")]
	public ECIPGPIGLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x64E7FC0", Offset = "0x64E6DC0", VA = "0x1864E7FC0")]
	public ECIPGPIGLPG(byte NEMDNBLCKKH, OIOHPELJPIG GBJFAKNMLBM, ECIPGPIGLPG AABHIBJPKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x64E7E50", Offset = "0x64E6C50", VA = "0x1864E7E50")]
	public void DCMJCJJFMCK(ECIPGPIGLPG CPAHKPHLOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	public void NPADBCDBLOH(int LIBIBFIEODD, CFHGNGGDNNC FHMCGFLFDFP, int FFAMLMLBIPG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x64E7BA0", Offset = "0x64E69A0", VA = "0x1864E7BA0")]
	public void AOMCMJPLFCI(List<byte> HMHHCFGAPHM, Vector3 CBAKPHLPCPB, float HHMPHGCDGEG, float EPMFPBLBGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x64E7F50", Offset = "0x64E6D50", VA = "0x1864E7F50")]
	public bool ONCGJHMJOCH(Vector3 LKPMINMHIIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x64E7F10", Offset = "0x64E6D10", VA = "0x1864E7F10")]
	public bool OANJJHNCHHM(Vector3 LKPMINMHIIB, float FBICHNMAGBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public class PNBEMDHGCKC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly Dictionary<T, object> PJIGBDBJIKA;

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x25B7DF0", Offset = "0x25B6BF0", VA = "0x1825B7DF0")]
	public bool DJODGKJLLHK(T KPPLKNJJEIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB8A0", Offset = "0x2ACA6A0", VA = "0x182ACB8A0")]
	public bool DJODGKJLLHK(T KPPLKNJJEIP, object INDCJAMMAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB840", Offset = "0x2ACA640", VA = "0x182ACB840")]
	public bool DJODGKJLLHK(T KPPLKNJJEIP, object INDCJAMMAIN, out object KDJMMIFKHPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB800", Offset = "0x2ACA600", VA = "0x182ACB800")]
	public bool CCBGJCEKGKO(T KPPLKNJJEIP, object INDCJAMMAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB910", Offset = "0x2ACA710", VA = "0x182ACB910")]
	public bool JAENIAFCEFE(T KPPLKNJJEIP, object INDCJAMMAIN, out object KDJMMIFKHPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB770", Offset = "0x2ACA570", VA = "0x182ACB770")]
	public bool CCBGJCEKGKO(T KPPLKNJJEIP, object INDCJAMMAIN, out object KDJMMIFKHPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB8E0", Offset = "0x2ACA6E0", VA = "0x182ACB8E0")]
	public void EKPCIIEPBOB(T KPPLKNJJEIP, object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB950", Offset = "0x2ACA750", VA = "0x182ACB950")]
	public void LMIOHAOPGMM(T KPPLKNJJEIP, object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB9F0", Offset = "0x2ACA7F0", VA = "0x182ACB9F0")]
	public PNBEMDHGCKC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AE")]
		public struct IKCCABDLEPO<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private readonly List<Component> LLMBPPCBLOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private readonly bool ADOAKHCFMOJ;

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x18A0280", Offset = "0x189F080", VA = "0x1818A0280")]
			public IKCCABDLEPO(List<Component> LLMBPPCBLOM, bool ADOAKHCFMOJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x25AFFA0", Offset = "0x25AEDA0", VA = "0x1825AFFA0")]
			public DKBIHHMKADJ<T> FGLPNHJPKAJ()
			{
				return default(DKBIHHMKADJ<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x25B0010", Offset = "0x25AEE10", VA = "0x1825B0010", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x25B0010", Offset = "0x25AEE10", VA = "0x1825B0010", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AF")]
		public struct DKBIHHMKADJ<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private readonly List<Component> LLMBPPCBLOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private readonly bool ADOAKHCFMOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			private int CPOAAGLEIPE;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T MPEDNLDPMJJ
			{
				[Cpp2IlInjected.Token(Token = "0x60003E9")]
				[Cpp2IlInjected.Address(RVA = "0x2B124F0", Offset = "0x2B112F0", VA = "0x182B124F0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0x2B12480", Offset = "0x2B11280", VA = "0x182B12480", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x2B124C0", Offset = "0x2B112C0", VA = "0x182B124C0")]
			public DKBIHHMKADJ(List<Component> LLMBPPCBLOM, bool ADOAKHCFMOJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x2B123C0", Offset = "0x2B111C0", VA = "0x182B123C0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x2B123D0", Offset = "0x2B111D0", VA = "0x182B123D0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x297AF50", Offset = "0x2979D50", VA = "0x18297AF50", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x64EECE0", Offset = "0x64EDAE0", VA = "0x1864EECE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x64EECA0", Offset = "0x64EDAA0", VA = "0x1864EECA0")]
		public ToolHierarchyCache(GameObject BEPEHBCCEGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x64EE540", Offset = "0x64ED340", VA = "0x1864EE540")]
		private void GIHONBOCKDC(GameObject BEPEHBCCEGM, bool AJKJHFCHOAK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x64EE6A0", Offset = "0x64ED4A0", VA = "0x1864EE6A0")]
		public static void GIHONBOCKDC(GameObject BEPEHBCCEGM, ref ToolHierarchyCache IMBDKJJAFKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x64EE430", Offset = "0x64ED230", VA = "0x1864EE430")]
		public void BOCPEAJCCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x64EEBD0", Offset = "0x64ED9D0", VA = "0x1864EEBD0")]
		public void MEGJPFPEEHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3740", Offset = "0x2AF2540", VA = "0x182AF3740")]
		public void MDPFAKKBNEB<T>(Action<T> KKJDJCJOLIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x64EE7B0", Offset = "0x64ED5B0", VA = "0x1864EE7B0")]
		public Component IFDHPJMHAAN(Type MAIOHDHBGKE, bool ADOAKHCFMOJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x2AF36C0", Offset = "0x2AF24C0", VA = "0x182AF36C0")]
		public T IFDHPJMHAAN<T>(bool ADOAKHCFMOJ = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x64EE440", Offset = "0x64ED240", VA = "0x1864EE440")]
		public IKCCABDLEPO<Component> BPBFEGACMHF(Type MAIOHDHBGKE, bool ADOAKHCFMOJ = false)
		{
			return default(IKCCABDLEPO<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x2AF35F0", Offset = "0x2AF23F0", VA = "0x182AF35F0")]
		public IKCCABDLEPO<T> BPBFEGACMHF<T>(bool ADOAKHCFMOJ = false) where T : class
		{
			return default(IKCCABDLEPO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x64EE880", Offset = "0x64ED680", VA = "0x1864EE880")]
		public List<Component> KMAMAIDHKDA(Type MAIOHDHBGKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x64EE4C0", Offset = "0x64ED2C0", VA = "0x1864EE4C0", Slot = "4")]
		public bool Equals(ToolHierarchyCache PAMKNJCGOGK, ToolHierarchyCache IOAMOMOPNDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x64EE730", Offset = "0x64ED530", VA = "0x1864EE730", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache BLIKPCIFNNO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class BJEKJEEEAHB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private int FPMMBKCOHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private int CJEHDBBMOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private List<T> ICBAFEALNLG;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x2724520", Offset = "0x2723320", VA = "0x182724520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T PBBMJFDJIAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x29832A0", Offset = "0x29820A0", VA = "0x1829832A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T EIAGGHIBLEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x2983440", Offset = "0x2982240", VA = "0x182983440")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T EMGJPPOJDMM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x2983590", Offset = "0x2982390", VA = "0x182983590")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2983640", Offset = "0x2982440", VA = "0x182983640")]
	public BJEKJEEEAHB(int FPMMBKCOHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x29831C0", Offset = "0x2981FC0", VA = "0x1829831C0")]
	public void AHKNMMEAEHA(T JHKGKAEBACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x29833B0", Offset = "0x29821B0", VA = "0x1829833B0")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x29834A0", Offset = "0x29822A0", VA = "0x1829834A0")]
	public void HILPNKDJOMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x29835F0", Offset = "0x29823F0", VA = "0x1829835F0")]
	public void OHDEMHPECKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x29833F0", Offset = "0x29821F0", VA = "0x1829833F0")]
	public void FEFIBKHGJLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class GDMLOGDOPLM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private bool POGDBHHAIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private Action KKJDJCJOLIF;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static GDMLOGDOPLM DHDPPMCMLAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x64E81F0", Offset = "0x64E6FF0", VA = "0x1864E81F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool BOOHAEHGJAF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x792380", Offset = "0x791180", VA = "0x180792380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x76E690", Offset = "0x76D490", VA = "0x18076E690")]
	public GDMLOGDOPLM(Action KKJDJCJOLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x64E81D0", Offset = "0x64E6FD0", VA = "0x1864E81D0")]
	public void EMMGNHCOPMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x64E81D0", Offset = "0x64E6FD0", VA = "0x1864E81D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public static class AOOHPDENFNJ
{
	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x64E4EE0", Offset = "0x64E3CE0", VA = "0x1864E4EE0")]
	public static void KNDBOENGANC(JGIJICGALKO FCGIBJPIJEA, string GHALJEBNKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	public static void KNDBOENGANC(IEnumerable<object> DOKHJFOLKHN, string GHALJEBNKDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class ENABPGELIHJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private struct PDHCELBKPLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int NDNLMIFPDGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public T DKPIGGFDHBP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly Dictionary<object, PDHCELBKPLP> PHBGHHDKNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private readonly EqualityComparer<T> PJJPFMJNIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private T NEAJFCEMODJ;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T AAGNIJGNLAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x787590", Offset = "0x786390", VA = "0x180787590", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x787780", Offset = "0x786580", VA = "0x180787780", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool OOBJLNLFEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x351F4F0", Offset = "0x351E2F0", VA = "0x18351F4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object HGJEKOAEMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x763EF0", VA = "0x1807650F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x351EFC0", Offset = "0x351DDC0", VA = "0x18351EFC0")]
	public bool LLJCPJLNFOC(T NLHFEJHKLAH, object INDCJAMMAIN, int PEOIJCAMOPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x351F480", Offset = "0x351E280", VA = "0x18351F480")]
	public bool MIHAOOFDKCE(object INDCJAMMAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x351A610", Offset = "0x3519410", VA = "0x18351A610")]
	public bool AMKBCCEHNAL(object INDCJAMMAIN, out T NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x2B112D0", Offset = "0x2B100D0", VA = "0x182B112D0")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x351D4E0", Offset = "0x351C2E0", VA = "0x18351D4E0")]
	private bool KDDPKIIAOIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x351F520", Offset = "0x351E320", VA = "0x18351F520")]
	public ENABPGELIHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class BAMCOFHAEMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private Dictionary<object, float> PHBGHHDKNIF;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float GOKHLBKJCOG
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x87B100", Offset = "0x879F00", VA = "0x18087B100")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x87B110", Offset = "0x879F10", VA = "0x18087B110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x64E51E0", Offset = "0x64E3FE0", VA = "0x1864E51E0")]
	public void LLJCPJLNFOC(float NLHFEJHKLAH, object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x64E5250", Offset = "0x64E4050", VA = "0x1864E5250")]
	public void MIHAOOFDKCE(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x64E50C0", Offset = "0x64E3EC0", VA = "0x1864E50C0")]
	private void KFEGPNAIJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x64E52C0", Offset = "0x64E40C0", VA = "0x1864E52C0")]
	public BAMCOFHAEMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class JCLADCGAMED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public readonly string HNPNIACFAAD;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x76B3B0", Offset = "0x76A1B0", VA = "0x18076B3B0")]
	public JCLADCGAMED(string HEEKOCPKEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x64E8780", Offset = "0x64E7580", VA = "0x1864E8780")]
	public JCLADCGAMED(UnityEngine.Object AGLLNIBDCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x64E8730", Offset = "0x64E7530", VA = "0x1864E8730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public sealed class JGIJICGALKO
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class NFJHCOOCMLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public NFJHCOOCMLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x64EB510", Offset = "0x64EA310", VA = "0x1864EB510")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private HashSet<object> DOKHJFOLKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private int HCNAICKFAKM;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> OPFBLMNLHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x64E8C60", Offset = "0x64E7A60", VA = "0x1864E8C60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool LLIGIPPHBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x64E8E40", Offset = "0x64E7C40", VA = "0x1864E8E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x719080", Offset = "0x717E80", VA = "0x180719080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x64E8B70", Offset = "0x64E7970", VA = "0x1864E8B70")]
	public bool AHKNMMEAEHA(object INDCJAMMAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x64E8D30", Offset = "0x64E7B30", VA = "0x1864E8D30")]
	public bool IHKCCNMHHEB(object INDCJAMMAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x64E8E50", Offset = "0x64E7C50", VA = "0x1864E8E50")]
	public bool PGDHOKOGAJF(object INDCJAMMAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x64E8DD0", Offset = "0x64E7BD0", VA = "0x1864E8DD0")]
	public void NIJECMNFHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x64E8EB0", Offset = "0x64E7CB0", VA = "0x1864E8EB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public JGIJICGALKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class ENALOFLIEGA<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct ANLIOADGFBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public float IGNPCPGAGLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public T DKPIGGFDHBP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private Dictionary<object, ANLIOADGFBB> PHBGHHDKNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private T AEPCPDLCHFI;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T KKMDFHOPAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x1575FB0", Offset = "0x1574DB0", VA = "0x181575FB0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1ACAD00", Offset = "0x1AC9B00", VA = "0x181ACAD00", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object LLHICFGHKNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x763EF0", VA = "0x1807650F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool OOBJLNLFEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x3521A50", Offset = "0x3520850", VA = "0x183521A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x35218F0", Offset = "0x35206F0", VA = "0x1835218F0")]
	public bool LLJCPJLNFOC(T NLHFEJHKLAH, object INDCJAMMAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x35219F0", Offset = "0x35207F0", VA = "0x1835219F0")]
	public bool MIHAOOFDKCE(object INDCJAMMAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x2B112D0", Offset = "0x2B100D0", VA = "0x182B112D0")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x351FBB0", Offset = "0x351E9B0", VA = "0x18351FBB0")]
	public bool AMKBCCEHNAL(object INDCJAMMAIN, out T NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x35209A0", Offset = "0x351F7A0", VA = "0x1835209A0")]
	private bool KDDPKIIAOIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x3521A90", Offset = "0x3520890", VA = "0x183521A90")]
	public ENALOFLIEGA()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public class KNPJDABNJNB
{
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static byte[] KJPEJCPNACN;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static int ENGDLONOMNK;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static int IBOHBKOLMLK;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static BigInteger BMOFNNOLMPE;

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KNPJDABNJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x64E9840", Offset = "0x64E8640", VA = "0x1864E9840")]
	private static string NKHPLDDEAIA(byte[] MIECAKFJHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x64E9950", Offset = "0x64E8750", VA = "0x1864E9950")]
	public static string OEIELDLCBEJ(byte[] NJGGJPEFKKD, bool NCDJBNMKDFA)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
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
