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
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class PCJPPLCPKAK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7AF100", Offset = "0x7AE500", VA = "0x1807AF100")]
	public PCJPPLCPKAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, IOAENIMNFEC, FPNAMDIBNMO, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7A2700", Offset = "0x7A1B00", VA = "0x1807A2700", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7A2710", Offset = "0x7A1B10", VA = "0x1807A2710", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash GMMFGHNCIAK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x858890", Offset = "0x857C90", VA = "0x180858890")]
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
	[SerializeField]
	[IFNNACLMLLP]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[HideInInspector]
	[SerializeField]
	[IFNNACLMLLP]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6059780", Offset = "0x6058B80", VA = "0x186059780")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6059740", Offset = "0x6058B40", VA = "0x186059740")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60597C0", Offset = "0x6058BC0", VA = "0x1860597C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6059970", Offset = "0x6058D70", VA = "0x186059970")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60598E0", Offset = "0x6058CE0", VA = "0x1860598E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8BCF60", Offset = "0x8BC360", VA = "0x1808BCF60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x939570", Offset = "0x938970", VA = "0x180939570")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6059700", Offset = "0x6058B00", VA = "0x186059700")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6059850", Offset = "0x6058C50", VA = "0x186059850")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6059170", Offset = "0x6058570", VA = "0x186059170")]
	public void CopyBounds(SavedExtents KMJGEHGGFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6059650", Offset = "0x6058A50", VA = "0x186059650")]
	public void SetLocalSpaceBounds(Bounds HKLCPECANLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x991A30", Offset = "0x990E30", VA = "0x180991A30")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6059640", Offset = "0x6058A40", VA = "0x186059640")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x60591A0", Offset = "0x60585A0", VA = "0x1860591A0")]
	private void GJEODMEBIDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6059420", Offset = "0x6058820", VA = "0x186059420")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6058B00", Offset = "0x6057F00", VA = "0x186058B00")]
	public static void CalculateLocalBoundsFor(GameObject ILLDLCGIGNA, [Out] Bounds HKLCPECANLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6059360", Offset = "0x6058760", VA = "0x186059360")]
	private static void HHFNGENOKCA(Bounds NFAPJGNODPK, Color CBOLNMOOFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6059670", Offset = "0x6058A70", VA = "0x186059670")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E180", Offset = "0x79D580", VA = "0x18079E180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7ABCF0", Offset = "0x7AB0F0", VA = "0x1807ABCF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xDBDC80", Offset = "0xDBD080", VA = "0x180DBDC80")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x42A0C50", Offset = "0x42A0050", VA = "0x1842A0C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "4")]
	public virtual void ICOMGNKANJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
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
	[PCJPPLCPKAK]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x42A0830", Offset = "0x429FC30", VA = "0x1842A0830", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x429F4D0", Offset = "0x429E8D0", VA = "0x18429F4D0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x42A0B80", Offset = "0x429FF80", VA = "0x1842A0B80")]
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
	private sealed class DELNCJGDMBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public DELNCJGDMBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4FC6370", Offset = "0x4FC5770", VA = "0x184FC6370")]
		internal int GAIFCLKPNNK(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[PCJPPLCPKAK]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x32EDD60", Offset = "0x32ED160", VA = "0x1832EDD60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x32EDDB0", Offset = "0x32ED1B0", VA = "0x1832EDDB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x32EDC60", Offset = "0x32ED060", VA = "0x1832EDC60", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey GPGELODKPOB]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x32EDD00", Offset = "0x32ED100", VA = "0x1832EDD00", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x32EDB40", Offset = "0x32ECF40", VA = "0x1832EDB40", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x32ED860", Offset = "0x32ECC60", VA = "0x1832ED860", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x32ECD00", Offset = "0x32EC100", VA = "0x1832ECD00", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x32ECC70", Offset = "0x32EC070", VA = "0x1832ECC70", Slot = "14")]
	protected virtual string KNMMHDNKMBO(TKeyVal OFJAOCENFHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x32ECB80", Offset = "0x32EBF80", VA = "0x1832ECB80", Slot = "4")]
	public bool ContainsKey(TKey GPGELODKPOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x32EDA00", Offset = "0x32ECE00", VA = "0x1832EDA00", Slot = "5")]
	public bool TryGetValue(TKey GPGELODKPOB, [Out] TVal ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x32ECBD0", Offset = "0x32EBFD0", VA = "0x1832ECBD0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x32ECBD0", Offset = "0x32EBFD0", VA = "0x1832ECBD0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x32EDA50", Offset = "0x32ECE50", VA = "0x1832EDA50")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EKFPOHPOEDO<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class BKDJEICHKAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float EDGHECPBEHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public T BDGBGLMDOLF;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public BKDJEICHKAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class HGKJGMFJEOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public HGKJGMFJEOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x375D050", Offset = "0x375C450", VA = "0x18375D050")]
		internal bool PHCOEECCBHD(BKDJEICHKAH sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float NALBFHFCBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float IJOEKCMGPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<BKDJEICHKAH> GKLLBOLDBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private LEALFLKHAHB<BKDJEICHKAH> DBHJJBOPBIF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int BAMDMKPFGDP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x32BE860", Offset = "0x32BDC60", VA = "0x1832BE860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x32BED40", Offset = "0x32BE140", VA = "0x1832BED40")]
	public EKFPOHPOEDO(float HIPGMECOGMB, float GAJELPKKOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x32BEA30", Offset = "0x32BDE30", VA = "0x1832BEA30")]
	public bool MHFFBFHCGIC(float OJFBKFAHIPG, T ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x32BE190", Offset = "0x32BD590", VA = "0x1832BE190")]
	public IEnumerable<T> CPNEECHKJFG(float OJFBKFAHIPG, [Optional] float? IFDNAPKBPEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x32BE120", Offset = "0x32BD520", VA = "0x1832BE120")]
	public void BILLODBOEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x32BE8D0", Offset = "0x32BDCD0", VA = "0x1832BE8D0")]
	private void JOFPIPJHBBM(float OJFBKFAHIPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class PEGEGIGGKJL<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct HPEDEEMMGPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public T BDGBGLMDOLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public float GINOLNPNPBN;
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static float EBCCJJPDPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private List<T> FAPFJOHLIDC;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private const int ILFNKDIOIFJ = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private HPEDEEMMGPO[] MGNOJHKHDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private int HHMDLOGJIOF;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float JHEJDKELIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xB58990", Offset = "0xB57D90", VA = "0x180B58990")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB589A0", Offset = "0xB57DA0", VA = "0x180B589A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4089FB0", Offset = "0x40893B0", VA = "0x184089FB0")]
	public PEGEGIGGKJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4089EC0", Offset = "0x40892C0", VA = "0x184089EC0")]
	public PEGEGIGGKJL(int HFPFBPPBALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4088FE0", Offset = "0x40883E0", VA = "0x184088FE0")]
	public void AFPNFDHLNMK(float OJFBKFAHIPG, T ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4089160", Offset = "0x4088560", VA = "0x184089160")]
	public void BILLODBOEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4089850", Offset = "0x4088C50", VA = "0x184089850")]
	public bool CONPEPAJLPA(float BDKBBLLDCLE, float LCAGFJPECFK, [Out] T ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4089C40", Offset = "0x4089040", VA = "0x184089C40")]
	public bool EFLAMLDMCLJ(float BDKBBLLDCLE, float LCAGFJPECFK, [Out] T ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4089340", Offset = "0x4088740", VA = "0x184089340")]
	public void CGEALBJNKID(float BDKBBLLDCLE, float LCAGFJPECFK, List<T> DICNEFJIMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4089E30", Offset = "0x4089230", VA = "0x184089E30")]
	private int MLEPFMPIDBN(int GDGBBBHIPEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4089DE0", Offset = "0x40891E0", VA = "0x184089DE0")]
	private void GBABNJMLLAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GIGKLOBGGEJ();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T LKFKAADKILH(T ANJCCKHBJJO, float MMKOHGNNHLF);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T ABDHDCEMFFE(T NNOKPENDLPE, T OBLEBBNJEBK);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T ABCAJGECHCO(T NNOKPENDLPE, T OBLEBBNJEBK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JKJCCFBJGKJ : PEGEGIGGKJL<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7AF990", Offset = "0x7AED90", VA = "0x1807AF990", Slot = "4")]
	protected override Vector3 GIGKLOBGGEJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6056EB0", Offset = "0x60562B0", VA = "0x186056EB0", Slot = "5")]
	protected override Vector3 LKFKAADKILH(Vector3 ANJCCKHBJJO, float MMKOHGNNHLF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6056E60", Offset = "0x6056260", VA = "0x186056E60", Slot = "6")]
	protected override Vector3 ABDHDCEMFFE(Vector3 NNOKPENDLPE, Vector3 OBLEBBNJEBK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6056DE0", Offset = "0x60561E0", VA = "0x186056DE0", Slot = "7")]
	protected override Vector3 ABCAJGECHCO(Vector3 NNOKPENDLPE, Vector3 OBLEBBNJEBK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6056EF0", Offset = "0x60562F0", VA = "0x186056EF0")]
	public JKJCCFBJGKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HGJDMNNIMBA
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2688510", Offset = "0x2687910", VA = "0x182688510")]
	public static PNOPFGEDAKM<T1, T2> HDHFILGDDKG<T1, T2>(T1 NLDGMJBICBN, T2 BKNEBBGJFPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2688590", Offset = "0x2687990", VA = "0x182688590")]
	public static DICLOHPNJMM<T1, T2, T3> HDHFILGDDKG<T1, T2, T3>(T1 NLDGMJBICBN, T2 BKNEBBGJFPJ, T3 NOLOKBPCAJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3E64410", Offset = "0x3E63810", VA = "0x183E64410")]
	internal static int ELHKDKNIBOK(int BCFJBMPNEPA, int GELNGAGDDMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x54BE4D0", Offset = "0x54BD8D0", VA = "0x1854BE4D0")]
	internal static int ELHKDKNIBOK(int BCFJBMPNEPA, int GELNGAGDDMI, int FHDLCJAEEJD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PNOPFGEDAKM<T1, T2> : IComparable<PNOPFGEDAKM<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T1 ENPONDEOKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T2 IHMPPDICPCN;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x40C2770", Offset = "0x40C1B70", VA = "0x1840C2770")]
	public PNOPFGEDAKM(T1 NLDGMJBICBN, T2 BKNEBBGJFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x40C0E30", Offset = "0x40C0230", VA = "0x1840C0E30", Slot = "4")]
	public int CompareTo(PNOPFGEDAKM<T1, T2> KMJGEHGGFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x40C1A30", Offset = "0x40C0E30", VA = "0x1840C1A30", Slot = "0")]
	public override bool Equals(object KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x40C1BE0", Offset = "0x40C0FE0", VA = "0x1840C1BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x40C1EF0", Offset = "0x40C12F0", VA = "0x1840C1EF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DICLOHPNJMM<T1, T2, T3> : IComparable<DICLOHPNJMM<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 ENPONDEOKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 IHMPPDICPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T3 KOMODNBHBIG;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4FDA4B0", Offset = "0x4FD98B0", VA = "0x184FDA4B0")]
	public DICLOHPNJMM(T1 NLDGMJBICBN, T2 BKNEBBGJFPJ, T3 NOLOKBPCAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4FD9B70", Offset = "0x4FD8F70", VA = "0x184FD9B70", Slot = "4")]
	public int CompareTo(DICLOHPNJMM<T1, T2, T3> KMJGEHGGFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4FD9F00", Offset = "0x4FD9300", VA = "0x184FD9F00", Slot = "0")]
	public override bool Equals(object KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4FDA140", Offset = "0x4FD9540", VA = "0x184FDA140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4FDA2F0", Offset = "0x4FD96F0", VA = "0x184FDA2F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T BDGBGLMDOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x204EC60", Offset = "0x204E060", VA = "0x18204EC60")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x204EAF0", Offset = "0x204DEF0", VA = "0x18204EAF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float DONLHLMNBMO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xB16EC0", Offset = "0xB162C0", VA = "0x180B16EC0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x44D6AA0", Offset = "0x44D5EA0", VA = "0x1844D6AA0")]
	public T KAOKADCGJIE(float MMKOHGNNHLF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x44D6740", Offset = "0x44D5B40", VA = "0x1844D6740")]
	public T JHPECMDGDIC(float MMKOHGNNHLF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T PNHENFOMLBI(T NNOKPENDLPE, T OBLEBBNJEBK, float MMKOHGNNHLF);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6056440", Offset = "0x6055840", VA = "0x186056440", Slot = "4")]
	protected override float PNHENFOMLBI(float NNOKPENDLPE, float OBLEBBNJEBK, float MMKOHGNNHLF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6056480", Offset = "0x6055880", VA = "0x186056480")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xC80A60", Offset = "0xC7FE60", VA = "0x180C80A60", Slot = "4")]
	protected override Vector3 PNHENFOMLBI(Vector3 NNOKPENDLPE, Vector3 OBLEBBNJEBK, float MMKOHGNNHLF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x605A650", Offset = "0x6059A50", VA = "0x18605A650")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x60561D0", Offset = "0x60555D0", VA = "0x1860561D0", Slot = "4")]
	protected override Color PNHENFOMLBI(Color NNOKPENDLPE, Color OBLEBBNJEBK, float MMKOHGNNHLF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6056290", Offset = "0x6055690", VA = "0x186056290")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CJFPGJPLHHG : NELMIJNIFJD<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6056180", Offset = "0x6055580", VA = "0x186056180")]
	public CJFPGJPLHHG(int LNJIGPAGCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6056110", Offset = "0x6055510", VA = "0x186056110", Slot = "6")]
	protected override uint NKDHFLFDIAN(uint GMMFGHNCIAK, string ANJCCKHBJJO)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NDFAIBLDLIC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly IDisposable GHDJCOLHINO;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public NDFAIBLDLIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct FJDPCNCKLOH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> NHBANEAPFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int DLNINANOODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int FHHIEEGOMCJ;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3642FB0", Offset = "0x36423B0", VA = "0x183642FB0")]
	private FJDPCNCKLOH(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> CPOKIIDJDLD, int DJHABHGLPGO, int PBEMKFFJNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3642970", Offset = "0x3641D70", VA = "0x183642970")]
	public static FJDPCNCKLOH<T> CPLKLKACALP()
	{
		return default(FJDPCNCKLOH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3641BF0", Offset = "0x3640FF0", VA = "0x183641BF0")]
	public (int, int, Task<T>) AKGMJHLGOND(int EKIMCCFCFIG, [Optional] CancellationToken PPJMMMGPFGD, double MINLHDMFCJJ = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3642DC0", Offset = "0x36421C0", VA = "0x183642DC0")]
	public void HEKBBEKJFCA(int EKIMCCFCFIG, int PBEMKFFJNCL, [In] T ANIEEDIHIEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class OFEODEPKMGO
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x60584F0", Offset = "0x60578F0", VA = "0x1860584F0")]
	public static FJDPCNCKLOH<MKHCJDDCMIA> CPLKLKACALP()
	{
		return default(FJDPCNCKLOH<MKHCJDDCMIA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6058540", Offset = "0x6057940", VA = "0x186058540")]
	public static void HEKBBEKJFCA([In] this FJDPCNCKLOH<MKHCJDDCMIA> LOMPFKEACIP, int EKIMCCFCFIG, int PBEMKFFJNCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class JDIGNNKIMOJ<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TVal> CLFAFJPNMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly Dictionary<TVal, TKey> NFEFOIKKALH;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x30D6B80", Offset = "0x30D5F80", VA = "0x1830D6B80", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool DKAJDONKALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> EACLPELBJEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3826D80", Offset = "0x3826180", VA = "0x183826D80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> HJIKCNONOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3A1B0A0", Offset = "0x3A1A4A0", VA = "0x183A1B0A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3A1AFF0", Offset = "0x3A1A3F0", VA = "0x183A1AFF0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3A1B0E0", Offset = "0x3A1A4E0", VA = "0x183A1B0E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3A1A260", Offset = "0x3A19660", VA = "0x183A1A260")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A580", Offset = "0x3A19980", VA = "0x183A1A580", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3A1AE20", Offset = "0x3A1A220", VA = "0x183A1AE20", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A350", Offset = "0x3A19750", VA = "0x183A1A350", Slot = "9")]
	public void Add(TKey GPGELODKPOB, TVal ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A320", Offset = "0x3A19720", VA = "0x183A1A320", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> IEEBNOOJIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A5E0", Offset = "0x3A199E0", VA = "0x183A1A5E0", Slot = "8")]
	public bool ContainsKey(TKey GPGELODKPOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A620", Offset = "0x3A19A20", VA = "0x183A1A620", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> IEEBNOOJIPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3A1AD40", Offset = "0x3A1A140", VA = "0x183A1AD40", Slot = "10")]
	public bool Remove(TKey GPGELODKPOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3A1AD70", Offset = "0x3A1A170", VA = "0x183A1AD70", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> IEEBNOOJIPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3A1AEC0", Offset = "0x3A1A2C0", VA = "0x183A1AEC0", Slot = "11")]
	public bool TryGetValue(TKey GPGELODKPOB, [Out] TVal ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A730", Offset = "0x3A19B30", VA = "0x183A1A730", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A6B0", Offset = "0x3A19AB0", VA = "0x183A1A6B0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] MGNOJHKHDPK, int PNCNANACKBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3A1AAE0", Offset = "0x3A19EE0", VA = "0x183A1AAE0")]
	public bool NICDJPMLKAP(TVal GPGELODKPOB, [Out] TKey ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A3C0", Offset = "0x3A197C0", VA = "0x183A1A3C0")]
	private void CHLJPAGHLIO(TKey GPGELODKPOB, TVal LEPPJAEDELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3A1AB80", Offset = "0x3A19F80", VA = "0x183A1AB80")]
	private void OLJALKALDNM(TKey GPGELODKPOB, TVal LEPPJAEDELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A930", Offset = "0x3A19D30", VA = "0x183A1A930")]
	private bool NAILPGCJOGE(TKey GPGELODKPOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3A1AF00", Offset = "0x3A1A300", VA = "0x183A1AF00")]
	public JDIGNNKIMOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[DefaultMember("Item")]
public class CBHENOLCHHH<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private CBHENOLCHHH<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x33338D0", Offset = "0x3332CD0", VA = "0x1833338D0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x3344DD0", Offset = "0x33441D0", VA = "0x183344DD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x33460A0", Offset = "0x33454A0", VA = "0x1833460A0")]
		public Enumerator(CBHENOLCHHH<T> DICNEFJIMOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3342F70", Offset = "0x3342370", VA = "0x183342F70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3343E90", Offset = "0x3343290", VA = "0x183343E90", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x33425E0", Offset = "0x33419E0", VA = "0x1833425E0")]
		private void MKMBPAOHPBE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T[] DBBLFAFCFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int ACGCEBPHGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int OJNGOFBJPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int MCCNLGBAILL;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x48353D0", Offset = "0x48347D0", VA = "0x1848353D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4833D60", Offset = "0x4833160", VA = "0x184833D60")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4835250", Offset = "0x4834650", VA = "0x184835250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4835650", Offset = "0x4834A50", VA = "0x184835650")]
	public CBHENOLCHHH(int LNJIGPAGCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4833EE0", Offset = "0x48332E0", VA = "0x184833EE0")]
	public void AFPNFDHLNMK(T MMKOHGNNHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4834310", Offset = "0x4833710", VA = "0x184834310")]
	public void BILLODBOEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4835320", Offset = "0x4834720", VA = "0x184835320")]
	public void MLCAKIEHDMD(int CBPPKGAPPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4834610", Offset = "0x4833A10", VA = "0x184834610")]
	public void FMFHOBOMMIA(T[] MGNOJHKHDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4835020", Offset = "0x4834420", VA = "0x184835020")]
	public Enumerator JLFJDPHFECC()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4835590", Offset = "0x4834990", VA = "0x184835590", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4835590", Offset = "0x4834990", VA = "0x184835590", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4834A60", Offset = "0x4833E60", VA = "0x184834A60")]
	private int HPEFHJPHEBM(int AHDNEIKOMIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x48352F0", Offset = "0x48346F0", VA = "0x1848352F0")]
	private int LLGHLFCFGLA(int AHDNEIKOMIB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class ADJCIMJIIAB<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Func<Internal, External> FOCNHDFOINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private IReadOnlyList<Internal> PHHAAPDMADG;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x36BA760", Offset = "0x36B9B60", VA = "0x1836BA760", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x36BA710", Offset = "0x36B9B10", VA = "0x1836BA710", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	public ADJCIMJIIAB(Func<Internal, External> FOCNHDFOINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x36BA6C0", Offset = "0x36B9AC0", VA = "0x1836BA6C0")]
	public ADJCIMJIIAB(IReadOnlyList<Internal> PHHAAPDMADG, Func<Internal, External> FOCNHDFOINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x36BA640", Offset = "0x36B9A40", VA = "0x1836BA640", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3539DB0", Offset = "0x35391B0", VA = "0x183539DB0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GBENCFLMOAH<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate Task<TResult> HJLIIEOOALM(TRequest DKBCOOIEPBC, CancellationToken PPJMMMGPFGD);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public enum CDICGCNBPAA
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class NJFGKFJCEGH
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float MJCGAHEMEPB = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TimeSpan OKGCHMOEHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int OCPHDDDAMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CDICGCNBPAA KOLFMJMNHOD;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly NJFGKFJCEGH JPDBNDFGACM;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float LGMNIIAIGOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x3ED38C0", Offset = "0x3ED2CC0", VA = "0x183ED38C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan GPIODLJDGPF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3A10", Offset = "0x3ED2E10", VA = "0x183ED3A10")]
		public NJFGKFJCEGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private readonly struct JBPILFFCFCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly TRequest DKBCOOIEPBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CancellationToken PPJMMMGPFGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TaskCompletionSource<TResult> FGKMLCAPEPJ;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x39C0F90", Offset = "0x39C0390", VA = "0x1839C0F90")]
		public JBPILFFCFCK(TRequest DKBCOOIEPBC, TaskCompletionSource<TResult> FGKMLCAPEPJ, CancellationToken PPJMMMGPFGD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct POKEPHOIDIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public GBENCFLMOAH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x40C3E00", Offset = "0x40C3200", VA = "0x1840C3E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x40C4680", Offset = "0x40C3A80", VA = "0x1840C4680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct JAPBMGKEBIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public GBENCFLMOAH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private JBPILFFCFCK <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x39B99B0", Offset = "0x39B8DB0", VA = "0x1839B99B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x39BA500", Offset = "0x39B9900", VA = "0x1839BA500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CancellationTokenSource KHHHBJPCLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<JBPILFFCFCK> KLFKDMPCCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly NJFGKFJCEGH ELMLJNFJOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HJLIIEOOALM CMBLIBHKHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Task JJMNEIEDPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int LMIJAGJBIMD;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x36F5FE0", Offset = "0x36F53E0", VA = "0x1836F5FE0")]
	public GBENCFLMOAH(HJLIIEOOALM CMBLIBHKHEJ, [Optional] NJFGKFJCEGH ELMLJNFJOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x36F5720", Offset = "0x36F4B20", VA = "0x1836F5720")]
	public Task<TResult> IBGPAOOKEIH(TRequest DKBCOOIEPBC, CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x36F5B10", Offset = "0x36F4F10", VA = "0x1836F5B10")]
	private void MCJGMCGHBOL(JBPILFFCFCK AEKLCACJGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x36F5130", Offset = "0x36F4530", VA = "0x1836F5130")]
	[AsyncStateMachine(typeof(GBENCFLMOAH<, >.POKEPHOIDIH))]
	private Task FFPAIMGIHGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x36F4D00", Offset = "0x36F4100", VA = "0x1836F4D00")]
	private JBPILFFCFCK EENCCNKCLPH()
	{
		return default(JBPILFFCFCK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x36F5EF0", Offset = "0x36F52F0", VA = "0x1836F5EF0")]
	[AsyncStateMachine(typeof(GBENCFLMOAH<, >.JAPBMGKEBIJ))]
	private Task OKKPLCAAOLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x36F53E0", Offset = "0x36F47E0", VA = "0x1836F53E0")]
	private void HKCPKMPIKPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x36F4780", Offset = "0x36F3B80", VA = "0x1836F4780", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class OOLCIPGPBNO<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly List<T> PHHAAPDMADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T> PEGOIPDONEG;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x30D6B80", Offset = "0x30D5F80", VA = "0x1830D6B80", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool DKAJDONKALI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x36C0AA0", Offset = "0x36BFEA0", VA = "0x1836C0AA0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3FE3D70", Offset = "0x3FE3170", VA = "0x183FE3D70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3668130", Offset = "0x3667530", VA = "0x183668130", Slot = "11")]
	public void Add(T IEEBNOOJIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3FE3530", Offset = "0x3FE2930", VA = "0x183FE3530")]
	public bool GCIFENLCIND(T IEEBNOOJIPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3FE3A60", Offset = "0x3FE2E60", VA = "0x183FE3A60", Slot = "15")]
	public bool Remove(T IEEBNOOJIPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3822F40", Offset = "0x3822340", VA = "0x183822F40", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3674290", Offset = "0x3673690", VA = "0x183674290", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3FE3460", Offset = "0x3FE2860", VA = "0x183FE3460", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3FE34C0", Offset = "0x3FE28C0", VA = "0x183FE34C0", Slot = "13")]
	public bool Contains(T IEEBNOOJIPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3FE3500", Offset = "0x3FE2900", VA = "0x183FE3500", Slot = "14")]
	public void CopyTo(T[] MGNOJHKHDPK, int PNCNANACKBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3AFB3A0", Offset = "0x3AFA7A0", VA = "0x183AFB3A0", Slot = "6")]
	public int IndexOf(T IEEBNOOJIPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3FE3790", Offset = "0x3FE2B90", VA = "0x183FE3790", Slot = "7")]
	public void Insert(int AHDNEIKOMIB, T IEEBNOOJIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3FE3870", Offset = "0x3FE2C70", VA = "0x183FE3870", Slot = "8")]
	public void RemoveAt(int AHDNEIKOMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3FE3BA0", Offset = "0x3FE2FA0", VA = "0x183FE3BA0")]
	public OOLCIPGPBNO()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x1EBEB40", Offset = "0x1EBDF40", VA = "0x181EBEB40")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1939270", Offset = "0x1938670", VA = "0x181939270")]
		public SerializedGuid([In] Guid LHLNCEHJAOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6059C90", Offset = "0x6059090", VA = "0x186059C90")]
		public static SerializedGuid PJDCMCAMGND()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6059B10", Offset = "0x6058F10", VA = "0x186059B10")]
		public static SerializedGuid NLCHHAKEJIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6059C30", Offset = "0x6059030", VA = "0x186059C30")]
		public bool PFEHLHJGPIL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6059C00", Offset = "0x6059000", VA = "0x186059C00", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6059B80", Offset = "0x6058F80", VA = "0x186059B80", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6059A30", Offset = "0x6058E30", VA = "0x186059A30", Slot = "7")]
		public bool Equals(SerializedGuid KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6059A70", Offset = "0x6058E70", VA = "0x186059A70", Slot = "0")]
		public override bool Equals(object BHPOPDOKECN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6059B00", Offset = "0x6058F00", VA = "0x186059B00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6059A00", Offset = "0x6058E00", VA = "0x186059A00", Slot = "6")]
		public int CompareTo(SerializedGuid KMJGEHGGFFC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class KOAPDCACEOJ : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type EDLFAPLPDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string GFNJCBADOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool DDGIMPIDECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool OKEBENNAJLB;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6057D60", Offset = "0x6057160", VA = "0x186057D60")]
	public KOAPDCACEOJ(Type LGPBDLACJOD, string CINIAMHICCG, bool GPEOODLBLFA = false, bool ONLFFDMJCPM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class PHNJPJKEIOH<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public readonly struct CLLOBHIFGED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly long IIILEGNJBHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly long OMEBLKBKHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly int ADCBKLONFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly int LCNBBBJNHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool ONHIPOOFCNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string LFNAGLINDLD;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4B014A0", Offset = "0x4B008A0", VA = "0x184B014A0")]
		public CLLOBHIFGED(long IIILEGNJBHJ, int ADCBKLONFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4B01510", Offset = "0x4B00910", VA = "0x184B01510")]
		public CLLOBHIFGED(long IIILEGNJBHJ, long OMEBLKBKHDP, int ADCBKLONFIM, int LCNBBBJNHLJ, bool ONHIPOOFCNG, string LFNAGLINDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4B01390", Offset = "0x4B00790", VA = "0x184B01390")]
		public int IDJMPEGODPL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4B01480", Offset = "0x4B00880", VA = "0x184B01480")]
		public int OKJBAGHLAKH(int DJOBDKFEPEP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4B01330", Offset = "0x4B00730", VA = "0x184B01330")]
		public double HECONAMKMEC()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x4B013E0", Offset = "0x4B007E0", VA = "0x184B013E0")]
		public CLLOBHIFGED MMCGIDBJIGP(long OMEBLKBKHDP, int LCNBBBJNHLJ)
		{
			return default(CLLOBHIFGED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class DNICKHEMCOE : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct IHFPBNGOPIG<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public DNICKHEMCOE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Func<DNICKHEMCOE, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private DNICKHEMCOE <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x38271C0", Offset = "0x38265C0", VA = "0x1838271C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x38276E0", Offset = "0x3826AE0", VA = "0x1838276E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly TKey LGEKOOBGCAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly PHNJPJKEIOH<TKey> KJPGODIMAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly OKECMMGLCGL ECHPFBNKINH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<DNICKHEMCOE> FHDNNLKHPDL;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string EIPPMHEBKHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x5017EE0", Offset = "0x50172E0", VA = "0x185017EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<DNICKHEMCOE> BDNCPDNOGEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x5017EA0", Offset = "0x50172A0", VA = "0x185017EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public CLLOBHIFGED LHHJPJKNBKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x5017F10", Offset = "0x5017310", VA = "0x185017F10")]
			[CompilerGenerated]
			get
			{
				return default(CLLOBHIFGED);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x5017E70", Offset = "0x5017270", VA = "0x185017E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5018090", Offset = "0x5017490", VA = "0x185018090")]
		internal DNICKHEMCOE(PHNJPJKEIOH<TKey> KJPGODIMAEL, TKey GPGELODKPOB, OKECMMGLCGL ECHPFBNKINH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5017F30", Offset = "0x5017330", VA = "0x185017F30")]
		public DNICKHEMCOE PFAELJMAEKL(TKey GPGELODKPOB, [Optional] OKECMMGLCGL? IMNBFFMFIFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2FAD9E0", Offset = "0x2FACDE0", VA = "0x182FAD9E0")]
		[AsyncStateMachine(typeof(IHFPBNGOPIG<>))]
		public Task<T> ABODIKECNBI<T>(TKey GPGELODKPOB, Func<DNICKHEMCOE, Task<T>> KCPEOJNECNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5017C70", Offset = "0x5017070", VA = "0x185017C70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class FAOLLGDEJMJ : IEnumerable<(TKey, List<TKey>, CLLOBHIFGED)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CLLOBHIFGED)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private (TKey key, List<TKey> path, CLLOBHIFGED timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public PHNJPJKEIOH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<(TKey key, List<TKey> path, CLLOBHIFGED timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, CLLOBHIFGED) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1EBC520", Offset = "0x1EBB920", VA = "0x181EBC520", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CLLOBHIFGED));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x3628A70", Offset = "0x3627E70", VA = "0x183628A70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1EBC610", Offset = "0x1EBBA10", VA = "0x181EBC610")]
		[DebuggerHidden]
		public FAOLLGDEJMJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3534370", Offset = "0x3533770", VA = "0x183534370", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x36285C0", Offset = "0x36279C0", VA = "0x1836285C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3628570", Offset = "0x3627970", VA = "0x183628570")]
		private void JIKMBFFNLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3628A20", Offset = "0x3627E20", VA = "0x183628A20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3628960", Offset = "0x3627D60", VA = "0x183628960", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CLLOBHIFGED)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x353D890", Offset = "0x353CC90", VA = "0x18353D890", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class BFICKBJICGF : IEnumerable<(TKey, List<TKey>, CLLOBHIFGED)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CLLOBHIFGED)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private (TKey key, List<TKey> path, CLLOBHIFGED timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private DNICKHEMCOE timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public DNICKHEMCOE <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public PHNJPJKEIOH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IEnumerator<DNICKHEMCOE> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<(TKey key, List<TKey> path, CLLOBHIFGED timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, CLLOBHIFGED) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1EBC520", Offset = "0x1EBB920", VA = "0x181EBC520", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CLLOBHIFGED));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x472F3F0", Offset = "0x472E7F0", VA = "0x18472F3F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1EBC610", Offset = "0x1EBBA10", VA = "0x181EBC610")]
		[DebuggerHidden]
		public BFICKBJICGF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x472F450", Offset = "0x472E850", VA = "0x18472F450", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x472EB10", Offset = "0x472DF10", VA = "0x18472EB10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x472EAB0", Offset = "0x472DEB0", VA = "0x18472EAB0")]
		private void JIKMBFFNLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x472EA50", Offset = "0x472DE50", VA = "0x18472EA50")]
		private void DNFFEPBIMEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x472F3A0", Offset = "0x472E7A0", VA = "0x18472F3A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x472F2C0", Offset = "0x472E6C0", VA = "0x18472F2C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CLLOBHIFGED)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x42C7360", Offset = "0x42C6760", VA = "0x1842C7360", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Action<TKey, CLLOBHIFGED, OKECMMGLCGL> KGKCJGKBIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Action<TKey, CLLOBHIFGED, OKECMMGLCGL> KFMCFCACMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<PHNJPJKEIOH<TKey>, OKECMMGLCGL> ICJCOFIENNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly OKECMMGLCGL ECHPFBNKINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly DNICKHEMCOE LNIDJOJLNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool BDMHAMLDKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int FANEBHAKMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Stopwatch IHKMHHIMFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly int PNNGOKCBCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string CDNHPLDGEFL;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public DNICKHEMCOE LPEOAKPAHII
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7A26C0", Offset = "0x7A1AC0", VA = "0x1807A26C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string EIPPMHEBKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7A6790", Offset = "0x7A5B90", VA = "0x1807A6790")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4097B20", Offset = "0x4096F20", VA = "0x184097B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4097C00", Offset = "0x4097000", VA = "0x184097C00")]
	public PHNJPJKEIOH(TKey LMMNGCOBFKA, OKECMMGLCGL ECHPFBNKINH, [Optional] int? ADCBKLONFIM, [Optional][CanBeNull] Stopwatch IHKMHHIMFGH, [Optional] Action<TKey, CLLOBHIFGED, OKECMMGLCGL> KGKCJGKBIMD, [Optional] Action<TKey, CLLOBHIFGED, OKECMMGLCGL> KFMCFCACMPB, [Optional] Action<PHNJPJKEIOH<TKey>, OKECMMGLCGL> ICJCOFIENNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4097930", Offset = "0x4096D30", VA = "0x184097930", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4097A90", Offset = "0x4096E90", VA = "0x184097A90")]
	[IteratorStateMachine(typeof(PHNJPJKEIOH<>.FAOLLGDEJMJ))]
	public IEnumerable<(TKey, List<TKey>, CLLOBHIFGED)> IJOBCPJKOEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x40979C0", Offset = "0x4096DC0", VA = "0x1840979C0")]
	[IteratorStateMachine(typeof(PHNJPJKEIOH<>.BFICKBJICGF))]
	private IEnumerable<(TKey, List<TKey>, CLLOBHIFGED)> IJOBCPJKOEJ(List<TKey> NFJOGILOIIO, DNICKHEMCOE MPDCNDPJAEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4097B80", Offset = "0x4096F80", VA = "0x184097B80")]
	private (long, int) OHHEEMGLNLN()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public abstract class DPKOBJBPFBO<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut CLIBAEOBPHL(PHNJPJKEIOH<TKey> KJPGODIMAEL);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	protected DPKOBJBPFBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public abstract class JDOAJMCLPIG<TKey> : DPKOBJBPFBO<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate string IAJHDLALFKP(TKey GPGELODKPOB);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3A1B960", Offset = "0x3A1AD60", VA = "0x183A1B960")]
	private static string AHKGFENBCJE(TKey GPGELODKPOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3A1BAF0", Offset = "0x3A1AEF0", VA = "0x183A1BAF0", Slot = "4")]
	public override string CLIBAEOBPHL(PHNJPJKEIOH<TKey> KJPGODIMAEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3A1B9A0", Offset = "0x3A1ADA0", VA = "0x183A1B9A0")]
	public string CLIBAEOBPHL(PHNJPJKEIOH<TKey> KJPGODIMAEL, [NotNull] IAJHDLALFKP AJJFAMDMAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string NGDIFOOEEFP(PHNJPJKEIOH<TKey> KJPGODIMAEL, [NotNull] IAJHDLALFKP AJJFAMDMAMK);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3843A30", Offset = "0x3842E30", VA = "0x183843A30")]
	protected JDOAJMCLPIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class BCPHPABPCOH<TKey> : DPKOBJBPFBO<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate string GEAFFJKFKEG(TKey GPGELODKPOB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string BMNIHFEAHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly double HGBHFHKMCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly bool BCKJIJCKMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly int LLCMJHKECAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ISet<string> GGHFGGHHDAI;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4712BA0", Offset = "0x4711FA0", VA = "0x184712BA0")]
	private static string AHKGFENBCJE(TKey GPGELODKPOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x4713710", Offset = "0x4712B10", VA = "0x184713710")]
	public BCPHPABPCOH(string BMNIHFEAHEG = "F2", double HGBHFHKMCBD = double.MaxValue, bool BCKJIJCKMLE = false, int LLCMJHKECAF = int.MaxValue, [Optional] ISet<string> GGHFGGHHDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x47131D0", Offset = "0x47125D0", VA = "0x1847131D0", Slot = "4")]
	public override Dictionary<string, string> CLIBAEOBPHL(PHNJPJKEIOH<TKey> KJPGODIMAEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4713630", Offset = "0x4712A30", VA = "0x184713630")]
	private bool OEOLHPGJEPK(string NMLIKIPFOAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4712BE0", Offset = "0x4711FE0", VA = "0x184712BE0")]
	public Dictionary<string, string> CLIBAEOBPHL(PHNJPJKEIOH<TKey> KJPGODIMAEL, GEAFFJKFKEG AJJFAMDMAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4713290", Offset = "0x4712690", VA = "0x184713290")]
	private string EBHDMDGOKCM(StringBuilder IPJEHIKKDPH, List<TKey> LKIOMPGBMOE, GEAFFJKFKEG AJJFAMDMAMK, bool CCNCOFJEPCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x47134D0", Offset = "0x47128D0", VA = "0x1847134D0")]
	private static void NINDBOFADJC(StringBuilder OPLEMEKLPPG, string JHKAOLOGHNC, bool KMDMHHGMLPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class EMHPGMNOJOM<TKey> : JDOAJMCLPIG<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct FAKAOIPIFFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public IAJHDLALFKP keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static EMHPGMNOJOM<TKey> GHDJCOLHINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly string[] HHKCDPOCNBB;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x32C26A0", Offset = "0x32C1AA0", VA = "0x1832C26A0")]
	private EMHPGMNOJOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x32C1730", Offset = "0x32C0B30", VA = "0x1832C1730", Slot = "5")]
	protected override string NGDIFOOEEFP(PHNJPJKEIOH<TKey> KJPGODIMAEL, IAJHDLALFKP AJJFAMDMAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x32C1640", Offset = "0x32C0A40", VA = "0x1832C1640")]
	[CompilerGenerated]
	internal static string FLKGJJJNLAF(string KCHJALAKPFD, TKey GPGELODKPOB, FAKAOIPIFFH P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class MNOBCMOPHND : PHNJPJKEIOH<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class JLPBFAIOOPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action<MNOBCMOPHND, OKECMMGLCGL> callback;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public JLPBFAIOOPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6056F50", Offset = "0x6056350", VA = "0x186056F50")]
		internal void LKIJNFEAOLM(PHNJPJKEIOH<string> timer, OKECMMGLCGL log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6057E90", Offset = "0x6057290", VA = "0x186057E90")]
	public MNOBCMOPHND(OKECMMGLCGL ECHPFBNKINH, [Optional] string HKNDIGHHANL, [Optional] int? ADCBKLONFIM, [Optional] Stopwatch IHKMHHIMFGH, [Optional] Action<string, CLLOBHIFGED, OKECMMGLCGL> KGKCJGKBIMD, [Optional] Action<string, CLLOBHIFGED, OKECMMGLCGL> KFMCFCACMPB, [Optional] Action<MNOBCMOPHND, OKECMMGLCGL> ICJCOFIENNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6057DD0", Offset = "0x60571D0", VA = "0x186057DD0")]
	private static Action<PHNJPJKEIOH<string>, OKECMMGLCGL> OFKDNCFBDBC(Action<MNOBCMOPHND, OKECMMGLCGL> KNDPECEGMIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class DAHLPAJJOGH
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private class GKKJAGAEMOM : DAHLPAJJOGH
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static DAHLPAJJOGH GHDJCOLHINO
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x60564C0", Offset = "0x60558C0", VA = "0x1860564C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float KHAPFNGGBMH
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x1D0F7D0", Offset = "0x1D0EBD0", VA = "0x181D0F7D0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x60565C0", Offset = "0x60559C0", VA = "0x1860565C0")]
		public GKKJAGAEMOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static DAHLPAJJOGH PIGJABKEACD;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static DAHLPAJJOGH JPDBNDFGACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x60562D0", Offset = "0x60556D0", VA = "0x1860562D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float KHAPFNGGBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	protected DAHLPAJJOGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class BAKMPJIENHJ<T> : BGAJOJOMPDJ<T> where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public override Task<T> ACFAKOCIEPK
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public override GKAGCLBDDCM<T> OODGNLKMCLO
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4709C80", Offset = "0x4709080", VA = "0x184709C80")]
	public BAKMPJIENHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "10")]
	protected override void EHCMNGOBIAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class DCACNFIPDKM<T> : BGAJOJOMPDJ<T> where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public override Task<T> ACFAKOCIEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override GKAGCLBDDCM<T> OODGNLKMCLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4FAD9F0", Offset = "0x4FACDF0", VA = "0x184FAD9F0")]
	public DCACNFIPDKM(Exception ADINNMOLMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "10")]
	protected override void EHCMNGOBIAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface IKLGPLDMACJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool FMCKFONPAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface MCDOFGKDLFK<T> : IKLGPLDMACJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	Task<T> ACFAKOCIEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[NotNull]
	GKAGCLBDDCM<T> OODGNLKMCLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class BGAJOJOMPDJ<T> : MCDOFGKDLFK<T>, IKLGPLDMACJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly LKOBEBLODOA LIBBGDECOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool BDMHAMLDKKB;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool FMCKFONPAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x992870", Offset = "0x991C70", VA = "0x180992870", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public abstract Task<T> ACFAKOCIEPK
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public abstract GKAGCLBDDCM<T> OODGNLKMCLO
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x472F7A0", Offset = "0x472EBA0", VA = "0x18472F7A0")]
	public BGAJOJOMPDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x472F6B0", Offset = "0x472EAB0", VA = "0x18472F6B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void EHCMNGOBIAB();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public abstract class COBDBKGEENF<TTask, T> : BGAJOJOMPDJ<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class PIFCDNNCBDC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public PIFCDNNCBDC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x30C6870", Offset = "0x30C5C70", VA = "0x1830C6870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x30C70B0", Offset = "0x30C64B0", VA = "0x1830C70B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public COBDBKGEENF<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public PIFCDNNCBDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x409D200", Offset = "0x409C600", VA = "0x18409D200")]
		[AsyncStateMachine(typeof(COBDBKGEENF<, >.PIFCDNNCBDC.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> BJAPOLDOAHO(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Task<T> CMOICIKGDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	protected readonly CancellationTokenSource FDJCMGONJAM;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public override Task<T> ACFAKOCIEPK
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public override GKAGCLBDDCM<T> OODGNLKMCLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x4B08DE0", Offset = "0x4B081E0", VA = "0x184B08DE0")]
	protected COBDBKGEENF(TTask CMOICIKGDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x4B08A50", Offset = "0x4B07E50", VA = "0x184B08A50", Slot = "10")]
	protected override void EHCMNGOBIAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T JCAMIOLHEJD(TTask ACBMEBCLMED);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void OFLEEECIJLD();
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class HGPBCGOAGEE<T> : BGAJOJOMPDJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly NJKEHFGOEOH<Task<T>> CBCNNOPLNPN;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public override Task<T> ACFAKOCIEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x32A0F40", Offset = "0x32A0340", VA = "0x1832A0F40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public override GKAGCLBDDCM<T> OODGNLKMCLO
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x375D300", Offset = "0x375C700", VA = "0x18375D300")]
	public HGPBCGOAGEE(NJKEHFGOEOH<Task<T>> JMHOIHNNACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x375D2E0", Offset = "0x375C6E0", VA = "0x18375D2E0", Slot = "10")]
	protected override void EHCMNGOBIAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class GNENJOMIOOI
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6056610", Offset = "0x6055A10", VA = "0x186056610")]
	[NotNull]
	public static byte[] BKHPFFGLFBB(this IOAENIMNFEC LPEIFOIIAEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6056680", Offset = "0x6055A80", VA = "0x186056680")]
	[NotNull]
	public static byte[] BKHPFFGLFBB(this IOAENIMNFEC LPEIFOIIAEI, HashAlgorithmName OGJNOJBOGKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x60566F0", Offset = "0x6055AF0", VA = "0x1860566F0")]
	public static bool BLCKGMNNMDN([CanBeNull] this IOAENIMNFEC LPEIFOIIAEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6056880", Offset = "0x6055C80", VA = "0x186056880")]
	public static bool BLCKGMNNMDN([CanBeNull] this IOAENIMNFEC LPEIFOIIAEI, [Out] string FHHKCHCDKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6056A20", Offset = "0x6055E20", VA = "0x186056A20")]
	private static bool NCOOKJLILHC([NotNull] IOAENIMNFEC LPEIFOIIAEI, [Out][CanBeNull] byte[] GANCIJLMFOK, [Out][CanBeNull] byte[] FAJCENHBEDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class JCGCNEGOOBO
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6056B40", Offset = "0x6055F40", VA = "0x186056B40")]
	[NotNull]
	public static byte[] BKHPFFGLFBB(this FPNAMDIBNMO DOHNKMHFAEH, HashAlgorithmName OGJNOJBOGKJ, byte[] MEFDALNNGII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface FPNAMDIBNMO
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash GMMFGHNCIAK);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface IOAENIMNFEC : FPNAMDIBNMO
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[CanBeNull]
	byte[] MPLCAHOFBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	[CanBeNull]
	byte[] PLBPJIGEODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class JMONOAOIBDI
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly ArrayPool<byte> NAGONFMNDHE;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static bool MHLOCFGILGA;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x60575F0", Offset = "0x60569F0", VA = "0x1860575F0")]
	public static void GOFILFHNKKD(this IncrementalHash KKDPODPAJNB, [CanBeNull] GameObject ILLDLCGIGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x26F3520", Offset = "0x26F2920", VA = "0x1826F3520")]
	public static void GOFILFHNKKD<T>(this IncrementalHash KKDPODPAJNB, [CanBeNull] T LHKDOCKFFOG) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x26F35E0", Offset = "0x26F29E0", VA = "0x1826F35E0")]
	public static void IHJFDICDFCL<T>(this IncrementalHash KKDPODPAJNB, [CanBeNull] T DOHNKMHFAEH) where T : FPNAMDIBNMO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x26F3670", Offset = "0x26F2A70", VA = "0x1826F3670")]
	public static void LBKOECBBBPK<T>(this IncrementalHash KKDPODPAJNB, [CanBeNull] IList<T> EAPFGKGOJMC) where T : FPNAMDIBNMO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x60574A0", Offset = "0x60568A0", VA = "0x1860574A0")]
	private static bool DLLGKGEHHKD([CanBeNull] FPNAMDIBNMO DOHNKMHFAEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6057590", Offset = "0x6056990", VA = "0x186057590")]
	public static void GBEHKIEKDPB(this IncrementalHash GMMFGHNCIAK, [CanBeNull] string NFOIPALFJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x60572D0", Offset = "0x60566D0", VA = "0x1860572D0")]
	public static void BNBDFLAMDEE(this IncrementalHash GMMFGHNCIAK, long KAGPCHCPJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x60570A0", Offset = "0x60564A0", VA = "0x1860570A0")]
	public static void BHKDLADBMBL(this IncrementalHash GMMFGHNCIAK, int FKPCMNOCJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x60576D0", Offset = "0x6056AD0", VA = "0x1860576D0")]
	public static void LECJCGPJMKC(this IncrementalHash GMMFGHNCIAK, short NNPEJFHPDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x60578A0", Offset = "0x6056CA0", VA = "0x1860578A0")]
	public static void MBHDBPPJEAN(this IncrementalHash GMMFGHNCIAK, byte ECDILHDIIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6057AE0", Offset = "0x6056EE0", VA = "0x186057AE0")]
	public static void PBOMJIEHKJJ(this IncrementalHash GMMFGHNCIAK, bool EMMBGJFBMKM, bool OCJHGFPLBHF = false, bool BALBONLLEMM = false, bool FDJHJNAOAOL = false, bool JPOHEHMDGDE = false, bool KJGDNMIPMIF = false, bool ECMDMFLGAOF = false, bool LOKEBCCLLIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x26F2EF0", Offset = "0x26F22F0", VA = "0x1826F2EF0")]
	public static void ALONJONKMAA<T>(this IncrementalHash GMMFGHNCIAK, T DBNNOOCLLFO) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6057530", Offset = "0x6056930", VA = "0x186057530")]
	public static void FBNPFLDGLLA(this IncrementalHash GMMFGHNCIAK, float CLLPDAFPEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6057040", Offset = "0x6056440", VA = "0x186057040")]
	public static void APOJLJLMLNP(this IncrementalHash GMMFGHNCIAK, ulong DFAMDNAHMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6057270", Offset = "0x6056670", VA = "0x186057270")]
	public static void BKACPHCADBP(this IncrementalHash GMMFGHNCIAK, uint IHBFNKMHGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6056FE0", Offset = "0x60563E0", VA = "0x186056FE0")]
	public static void AGGCGGOJJAC(this IncrementalHash GMMFGHNCIAK, ushort ADFOOEOHMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x60579B0", Offset = "0x6056DB0", VA = "0x1860579B0")]
	public static void NKMNPHPDNHN(this IncrementalHash GMMFGHNCIAK, Vector3 KPNMNPKIGDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class JHPGNFJOHEE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6056D80", Offset = "0x6056180", VA = "0x186056D80")]
	public JHPGNFJOHEE(string CAIOIMEOMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class OFECJKJAHLB<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class DAFMCLLJBHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public TNode LOMPFKEACIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public TNode EMDODFFCGEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public IACMPKFMBIO EOKDDHDHEIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public List<IACMPKFMBIO> ABJOFAJKNMO;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public DAFMCLLJBHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal struct IACMPKFMBIO : IComparable<IACMPKFMBIO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int ODENJDCNKKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public TClaimant DMDPIPEEAFI;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xB97460", Offset = "0xB96860", VA = "0x180B97460")]
		public IACMPKFMBIO(int ODENJDCNKKN, TClaimant DMDPIPEEAFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3809E00", Offset = "0x3809200", VA = "0x183809E00")]
		public bool MFNNANJABND([In] IACMPKFMBIO KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3809E60", Offset = "0x3809260", VA = "0x183809E60")]
		public bool NLKEHACFJNI([In] IACMPKFMBIO KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3809DF0", Offset = "0x38091F0", VA = "0x183809DF0", Slot = "4")]
		public int CompareTo(IACMPKFMBIO KMJGEHGGFFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3809E70", Offset = "0x3809270", VA = "0x183809E70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum JLHMBDGDJPN
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class AIEPLMMCPEE : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public OFECJKJAHLB<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x92DDA0", Offset = "0x92D1A0", VA = "0x18092DDA0")]
		[DebuggerHidden]
		public AIEPLMMCPEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x36D7920", Offset = "0x36D6D20", VA = "0x1836D7920", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x36D7AE0", Offset = "0x36D6EE0", VA = "0x1836D7AE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x36D7A00", Offset = "0x36D6E00", VA = "0x1836D7A00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x35357E0", Offset = "0x3534BE0", VA = "0x1835357E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly LEALFLKHAHB<DAFMCLLJBHI> FJIBILMDFID;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static readonly LEALFLKHAHB<List<IACMPKFMBIO>> BLIGMAOEJPE;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static int OPGFPCMFNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal readonly Dictionary<TClaimant, TNode> OAJOJGINBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	internal readonly Dictionary<TNode, DAFMCLLJBHI> APNLCANJDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private JLHMBDGDJPN JNDDDHJCEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool KAJILOPLFHP;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode KOBPKOONGJA(TNode DKBEBHEBAJO);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void MNFNAMFOHAP(TNode DKBEBHEBAJO, TClaimant BNLINOCBOGM, TClaimant LEEIFPJEPKB);

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3FD1340", Offset = "0x3FD0740", VA = "0x183FD1340")]
	public OFECJKJAHLB(JLHMBDGDJPN JNDDDHJCEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3FCFE00", Offset = "0x3FCF200", VA = "0x183FCFE00")]
	public void CKFBFAGFMJF(TNode DKBEBHEBAJO, TNode FOONBHGCLLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3FCFE90", Offset = "0x3FCF290", VA = "0x183FCFE90")]
	public void DGOLFABPOPA(TClaimant DMDPIPEEAFI, TNode GNPNLDJMKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3FCFFB0", Offset = "0x3FCF3B0", VA = "0x183FCFFB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3FD0BC0", Offset = "0x3FCFFC0", VA = "0x183FD0BC0")]
	private void KOKMILBLMHJ(TClaimant DMDPIPEEAFI, TNode CAPPCAFACOB, TNode GNPNLDJMKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3FD0D40", Offset = "0x3FD0140", VA = "0x183FD0D40")]
	private int LJHMNCAFNAP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3FD0880", Offset = "0x3FCFC80", VA = "0x183FD0880")]
	private void JNHCOKFHNJH(TClaimant DMDPIPEEAFI, TNode APNFHNOBNFP, TNode KONKEKDJKDB, int EICEOEFMLDB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3FD0270", Offset = "0x3FCF670", VA = "0x183FD0270")]
	private void FPACGICKIPL(IACMPKFMBIO EBNGEOBOLMB, DAFMCLLJBHI GBEIAENCKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3FCFB20", Offset = "0x3FCEF20", VA = "0x183FCFB20")]
	private void BNKBFAPGDFH(TClaimant DMDPIPEEAFI, TNode APNFHNOBNFP, TNode KONKEKDJKDB, int EICEOEFMLDB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3FD0430", Offset = "0x3FCF830", VA = "0x183FD0430")]
	private void IJKMECGOHBL(IACMPKFMBIO EBNGEOBOLMB, TNode DKBEBHEBAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3FD0180", Offset = "0x3FCF580", VA = "0x183FD0180")]
	private void EJAFGGOHAHH(IACMPKFMBIO EBNGEOBOLMB, DAFMCLLJBHI GBEIAENCKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3FD0300", Offset = "0x3FCF700", VA = "0x183FD0300")]
	private void IDKAIHLKNEL(DAFMCLLJBHI GBEIAENCKNB, bool GKADCGDEOCO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3FD0540", Offset = "0x3FCF940", VA = "0x183FD0540")]
	private void JDLCIOJANFA(DAFMCLLJBHI GBEIAENCKNB, TNode FOONBHGCLLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3FD0C60", Offset = "0x3FD0060", VA = "0x183FD0C60")]
	[IteratorStateMachine(typeof(OFECJKJAHLB<, >.AIEPLMMCPEE))]
	private IEnumerable<TNode> LFMDPGLKDEP(TNode APNFHNOBNFP, TNode KONKEKDJKDB, bool HEEODCOOINE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3FD0DB0", Offset = "0x3FD01B0", VA = "0x183FD0DB0")]
	private DAFMCLLJBHI LNPHBCPFGKG(TNode DKBEBHEBAJO, TNode EMDODFFCGEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3FD0EA0", Offset = "0x3FD02A0", VA = "0x183FD0EA0")]
	private DAFMCLLJBHI MKPLEMGMMJL(TNode DKBEBHEBAJO, TNode EMDODFFCGEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3FD1010", Offset = "0x3FD0410", VA = "0x183FD1010")]
	private void PGJHMJEIJFE(DAFMCLLJBHI GBEIAENCKNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class NELMIJNIFJD<T> : IEnumerable<NELMIJNIFJD<T>.MKJAMNIBDBP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct MKJAMNIBDBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public T ANJCCKHBJJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int AHDNEIKOMIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class GHNCAEHENFD : IEnumerator<MKJAMNIBDBP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private NELMIJNIFJD<T> MPJJCEJFHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int AHDNEIKOMIB;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x32EE110", Offset = "0x32ED510", VA = "0x1832EE110", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public MKJAMNIBDBP PPPEJOJKNAK
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x370FD20", Offset = "0x370F120", VA = "0x18370FD20", Slot = "4")]
			get
			{
				return default(MKJAMNIBDBP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x370FCE0", Offset = "0x370F0E0", VA = "0x18370FCE0")]
		public GHNCAEHENFD(NELMIJNIFJD<T> MPJJCEJFHBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x370FBE0", Offset = "0x370EFE0", VA = "0x18370FBE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3340380", Offset = "0x333F780", VA = "0x183340380", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xC48BA0", Offset = "0xC47FA0", VA = "0x180C48BA0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct AMFKHFDBKPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public bool IHEJPAODLAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public T ANJCCKHBJJO;
	}

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int AKIBANGHEOP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly Dictionary<T, int> JFJJPNDCJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private AMFKHFDBKPO[] BMLLJNMBGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int PFHDPEPPAGH;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int DGOCMKBENBB
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC20", Offset = "0x7DE020", VA = "0x1807DEC20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDE50", VA = "0x1807DEA50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x30D6B80", Offset = "0x30D5F80", VA = "0x1830D6B80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3EBC440", Offset = "0x3EBB840", VA = "0x183EBC440")]
	public NELMIJNIFJD(int LNJIGPAGCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3EBC520", Offset = "0x3EBB920", VA = "0x183EBC520")]
	public NELMIJNIFJD(MKJAMNIBDBP[] EMPNMACFLGA, bool DHDHGGGDCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3EBC170", Offset = "0x3EBB570", VA = "0x183EBC170")]
	public int KKHEDKBIAGK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3EBB7E0", Offset = "0x3EBABE0", VA = "0x183EBB7E0")]
	private int DDMJKKHGEHK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3EBC2C0", Offset = "0x3EBB6C0", VA = "0x183EBC2C0", Slot = "6")]
	protected virtual uint NKDHFLFDIAN(uint GMMFGHNCIAK, T ANJCCKHBJJO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3EBC120", Offset = "0x3EBB520", VA = "0x183EBC120")]
	public bool IBCLOJGJCMH(T ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3EBB710", Offset = "0x3EBAB10", VA = "0x183EBB710")]
	public int AAFGDJAPIGG(T ANJCCKHBJJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3EBC250", Offset = "0x3EBB650", VA = "0x183EBC250")]
	public T LCDBLOKAMEI(int AHDNEIKOMIB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3EBBE20", Offset = "0x3EBB220", VA = "0x183EBBE20")]
	public bool GCIFENLCIND(T ANJCCKHBJJO, bool CLIJPADHCOJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3EBBE70", Offset = "0x3EBB270", VA = "0x183EBBE70")]
	public bool GCIFENLCIND(T ANJCCKHBJJO, int AHDNEIKOMIB, bool CLIJPADHCOJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3EBC370", Offset = "0x3EBB770", VA = "0x183EBC370")]
	private int NLHCCNHFACE(int ACGCEBPHGCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3EBC3C0", Offset = "0x3EBB7C0", VA = "0x183EBC3C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3EBC3C0", Offset = "0x3EBB7C0", VA = "0x183EBC3C0", Slot = "4")]
	private IEnumerator<MKJAMNIBDBP> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class LEALFLKHAHB<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Stack<T> BPDPCIOCIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly List<T> HPHALDOMOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly int NNKLFNNMKIA;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3B68390", Offset = "0x3B67790", VA = "0x183B68390")]
	public static LEALFLKHAHB<T> LOPMLOHMGBC(int LNJIGPAGCFO = 0, int NNKLFNNMKIA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3B682B0", Offset = "0x3B676B0", VA = "0x183B682B0")]
	public static LEALFLKHAHB<T> JPPFLHEIPKK(int LNJIGPAGCFO = 0, int NNKLFNNMKIA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3B68550", Offset = "0x3B67950", VA = "0x183B68550")]
	public LEALFLKHAHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3B68580", Offset = "0x3B67980", VA = "0x183B68580")]
	public LEALFLKHAHB(int LNJIGPAGCFO, int NNKLFNNMKIA = int.MaxValue, bool LKDCOCGGPIF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3B68060", Offset = "0x3B67460", VA = "0x183B68060")]
	public T JBGOGNMBDAE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3B681E0", Offset = "0x3B675E0", VA = "0x183B681E0")]
	public void JGNAPAAMDNO(T ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3B68470", Offset = "0x3B67870", VA = "0x183B68470")]
	private void ODIHNIPMJFH(T ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3B68040", Offset = "0x3B67440", VA = "0x183B68040")]
	private void FCECFAEDJKM(T ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x3B67F00", Offset = "0x3B67300", VA = "0x183B67F00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x3B67D00", Offset = "0x3B67100", VA = "0x183B67D00")]
	private void BOKOGJLKALO(IEnumerable<T> KOOGKOFEACD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class NNLEGILFNJM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private Dictionary<int, T> LGLDLFPPHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private T LGHBHJJPKAB;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T IALPKDKEDMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7A2700", Offset = "0x7A1B00", VA = "0x1807A2700", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3EFFF70", Offset = "0x3EFF370", VA = "0x183EFFF70")]
	public bool KLFCHEOKNCD(T ANJCCKHBJJO, int ODENJDCNKKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x37091E0", Offset = "0x37085E0", VA = "0x1837091E0")]
	public bool DKBAFHHGGMJ(int ODENJDCNKKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3EFFB90", Offset = "0x3EFEF90", VA = "0x183EFFB90")]
	public T GCANAOLIOHI(int JIIBJLCLGJN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3EFF9E0", Offset = "0x3EFEDE0", VA = "0x183EFF9E0")]
	private bool CMGIFAPDBLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3F00060", Offset = "0x3EFF460", VA = "0x183F00060")]
	public bool NICDJPMLKAP(int ODENJDCNKKN, [Out] T ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3F000B0", Offset = "0x3EFF4B0", VA = "0x183F000B0")]
	public NNLEGILFNJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class KLMAFFGEGFC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	protected struct IHNJIMABJKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public T BDGBGLMDOLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int EGLNGLIPKAE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	protected readonly List<IHNJIMABJKO> DBBLFAFCFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private T OOGMCEDHLHP;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x30D6B80", Offset = "0x30D5F80", VA = "0x1830D6B80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x3AD34C0", Offset = "0x3AD28C0", VA = "0x183AD34C0")]
	public bool JKHAEKACGLL(T ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x3AD3090", Offset = "0x3AD2490", VA = "0x183AD3090")]
	public void AFPNFDHLNMK(T ANJCCKHBJJO, int ODENJDCNKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x3AD3370", Offset = "0x3AD2770", VA = "0x183AD3370")]
	public bool JJHPGEAJNEC(T ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3AD3130", Offset = "0x3AD2530", VA = "0x183AD3130")]
	public void BILLODBOEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3AD32F0", Offset = "0x3AD26F0", VA = "0x183AD32F0")]
	public T JHIOCKANHDP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3AD3190", Offset = "0x3AD2590", VA = "0x183AD3190")]
	private void EKAJDCHJIOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3AD3640", Offset = "0x3AD2A40", VA = "0x183AD3640")]
	public KLMAFFGEGFC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[SerializeField]
		[CKNMEKOIECA(PBLEKPGDGOG.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x6058700", Offset = "0x6057B00", VA = "0x186058700")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x60589D0", Offset = "0x6057DD0", VA = "0x1860589D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x60588E0", Offset = "0x6057CE0", VA = "0x1860588E0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x6058650", Offset = "0x6057A50", VA = "0x186058650")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x6058920", Offset = "0x6057D20", VA = "0x186058920")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x6058830", Offset = "0x6057C30", VA = "0x186058830")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x60585C0", Offset = "0x60579C0", VA = "0x1860585C0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4266960", Offset = "0x4265D60", VA = "0x184266960", Slot = "4")]
		public virtual T MGEFFGMHKNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class AIHOBELHFHG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly Dictionary<byte, NCOEAPOECAO> NPDGJGGAAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly LEALFLKHAHB<NCOEAPOECAO> AKFPOLFPFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly bool CABNJPALJDE;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public NCOEAPOECAO IBEIELEOINL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7A26E0", Offset = "0x7A1AE0", VA = "0x1807A26E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector2 MLDNJECEPPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xB26600", Offset = "0xB25A00", VA = "0x180B26600")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xE11240", Offset = "0xE10640", VA = "0x180E11240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Vector2 LKEEGFDJDAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xE47C60", Offset = "0xE47060", VA = "0x180E47C60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector2 CJLJKDPKJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6055C60", Offset = "0x6055060", VA = "0x186055C60")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A20", Offset = "0x7A4E20", VA = "0x1807A5A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int EDPBAEADAPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7A47C0", Offset = "0x7A3BC0", VA = "0x1807A47C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7A47B0", Offset = "0x7A3BB0", VA = "0x1807A47B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6055C80", Offset = "0x6055080", VA = "0x186055C80")]
	public AIHOBELHFHG(Bounds OPEGPCPGHGN, Vector2[] IKNNJHMEPPJ, int ENBHIKPHPFM, byte ACGCEBPHGCG, float PKPFAPGECNF = 0f, [Optional] LEALFLKHAHB<NCOEAPOECAO> AKFPOLFPFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6055930", Offset = "0x6054D30", VA = "0x186055930")]
	public NCOEAPOECAO HDBLGJHOCBD(byte AHDNEIKOMIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6055990", Offset = "0x6054D90", VA = "0x186055990")]
	public void MIEDMHJNNNC(Vector3 BEBKKMFGLCG, float DKPOPDKAEBL, float PPECDGECAPJ, List<byte> IMLCIPFIKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5D5E300", Offset = "0x5D5D700", VA = "0x185D5E300")]
	public void FPKPHACIPGP(NCOEAPOECAO.KHADHGKPABN LDODKLNNMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6055430", Offset = "0x6054830", VA = "0x186055430")]
	public static int FCOFHAFAACH(Vector2[] IKNNJHMEPPJ, int ENBHIKPHPFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6055A60", Offset = "0x6054E60", VA = "0x186055A60")]
	private NCOEAPOECAO NLCBOPFAMOF(byte AHDNEIKOMIB, NCOEAPOECAO.NBMAAHGKADG EHPHOFFEKDC, NCOEAPOECAO EMDODFFCGEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6055520", Offset = "0x6054920", VA = "0x186055520")]
	private void FOMLFMDBOPF(NCOEAPOECAO EMDODFFCGEF, Vector2[] IKNNJHMEPPJ, int GHCKOEDEIJL, int AOACPGCBEFI, int KJEMJEDFHBP, int GNNIDBBNGNJ, float PKPFAPGECNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x60551B0", Offset = "0x60545B0", VA = "0x1860551B0")]
	private void ABGACJBAGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x60553D0", Offset = "0x60547D0", VA = "0x1860553D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x60558D0", Offset = "0x6054CD0", VA = "0x1860558D0", Slot = "1")]
	~AIHOBELHFHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class NCOEAPOECAO
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum NBMAAHGKADG
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum KHADHGKPABN
	{
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public byte CFEBOJMAFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public Vector3 OOKHHOCIIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public Vector3 COAOMNLBCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public Vector3 DBFIDCHCFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public Vector3 MLDMDPACPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public NBMAAHGKADG EADBFEODLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public NCOEAPOECAO EOGAOJCDEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public List<NCOEAPOECAO> FICOHOJLDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public bool KLCHINILJBB;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6058450", Offset = "0x6057850", VA = "0x186058450")]
	public NCOEAPOECAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6057FE0", Offset = "0x60573E0", VA = "0x186057FE0")]
	public void CBNJEMBLCPC(NCOEAPOECAO PBEFJCLMEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900")]
	public void FPKPHACIPGP(int CIBGKFECJGL, KHADHGKPABN LDODKLNNMJM, int KJBFCIIMCED = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6058100", Offset = "0x6057500", VA = "0x186058100")]
	public void MIEDMHJNNNC(List<byte> IMLCIPFIKLK, Vector3 BEBKKMFGLCG, float DKPOPDKAEBL, float PPECDGECAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6058420", Offset = "0x6057820", VA = "0x186058420")]
	public bool OKLJKANAOFI(Vector3 GODCLMMKACL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6058360", Offset = "0x6057760", VA = "0x186058360")]
	public bool MNLKMKCPNLN(Vector3 GODCLMMKACL, float MMMIPFBOAHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6058390", Offset = "0x6057790", VA = "0x186058390")]
	public void OBMDJKKOMOC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public struct CMFMCEMGIOF<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private readonly List<Component> PHHAAPDMADG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private readonly bool BKPCHHKHDCG;

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x32A1E60", Offset = "0x32A1260", VA = "0x1832A1E60")]
			public CMFMCEMGIOF(List<Component> PHHAAPDMADG, bool BKPCHHKHDCG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x4B07BA0", Offset = "0x4B06FA0", VA = "0x184B07BA0")]
			public AMJNJKFHNIK<T> JLFJDPHFECC()
			{
				return default(AMJNJKFHNIK<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x4B07C10", Offset = "0x4B07010", VA = "0x184B07C10", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x4B07C10", Offset = "0x4B07010", VA = "0x184B07C10", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public struct AMJNJKFHNIK<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly List<Component> PHHAAPDMADG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private readonly bool BKPCHHKHDCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private int AHDNEIKOMIB;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public T PPPEJOJKNAK
			{
				[Cpp2IlInjected.Token(Token = "0x60001ED")]
				[Cpp2IlInjected.Address(RVA = "0x36E67D0", Offset = "0x36E5BD0", VA = "0x1836E67D0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EE")]
				[Cpp2IlInjected.Address(RVA = "0x36E6760", Offset = "0x36E5B60", VA = "0x1836E6760", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x36E67A0", Offset = "0x36E5BA0", VA = "0x1836E67A0")]
			public AMJNJKFHNIK(List<Component> PHHAAPDMADG, bool BKPCHHKHDCG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x36E66A0", Offset = "0x36E5AA0", VA = "0x1836E66A0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x36E66B0", Offset = "0x36E5AB0", VA = "0x1836E66B0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x3333980", Offset = "0x3332D80", VA = "0x183333980", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x605A150", Offset = "0x6059550", VA = "0x18605A150")]
		private void OBMDJKKOMOC(GameObject KBHIFOELGCI, bool BICEHKAFMDO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x605A2C0", Offset = "0x60596C0", VA = "0x18605A2C0")]
		public static void OBMDJKKOMOC(GameObject KBHIFOELGCI, ToolHierarchyCache ABNDHJPENBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2966DD0", Offset = "0x29661D0", VA = "0x182966DD0")]
		public void DKJMJDKMCPA<T>(Action<T> HKJBPIINLDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2966FF0", Offset = "0x29663F0", VA = "0x182966FF0")]
		public T ELIGLCNKKHB<T>(bool BKPCHHKHDCG = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2967060", Offset = "0x2966460", VA = "0x182967060")]
		public CMFMCEMGIOF<T> GOHAKLNOAEN<T>(bool BKPCHHKHDCG = false) where T : class
		{
			return default(CMFMCEMGIOF<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6059D90", Offset = "0x6059190", VA = "0x186059D90")]
		public List<Component> FANBNNCKGMK(Type FICJMFBEBIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6059D10", Offset = "0x6059110", VA = "0x186059D10", Slot = "4")]
		public bool Equals(ToolHierarchyCache NEEBEKKMNIB, ToolHierarchyCache IGHOLFEOMDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x605A0E0", Offset = "0x60594E0", VA = "0x18605A0E0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache BHPOPDOKECN)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class EANMOIGBMKM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private int LNJIGPAGCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int ADGOLFFFDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private List<T> HAJDGKCJJAJ;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x32A0F40", Offset = "0x32A0340", VA = "0x1832A0F40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public T NKLJCNFJDFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x32A0F80", Offset = "0x32A0380", VA = "0x1832A0F80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public T HGLLDFLJKLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x32A0E00", Offset = "0x32A0200", VA = "0x1832A0E00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public T ACGHOHELCLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x32A0CB0", Offset = "0x32A00B0", VA = "0x1832A0CB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x32A10F0", Offset = "0x32A04F0", VA = "0x1832A10F0")]
	public EANMOIGBMKM(int LNJIGPAGCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x32A0A20", Offset = "0x329FE20", VA = "0x1832A0A20")]
	public void AFPNFDHLNMK(T NIIPIHJJNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x32A0C10", Offset = "0x32A0010", VA = "0x1832A0C10")]
	public void BILLODBOEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x32A0D30", Offset = "0x32A0130", VA = "0x1832A0D30")]
	public void CMBOCHBJHLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x32A0EE0", Offset = "0x32A02E0", VA = "0x1832A0EE0")]
	public void KEAAHCAENOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x32A0ED0", Offset = "0x32A02D0", VA = "0x1832A0ED0")]
	public void JKPOIEAJIAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class AOMMJOAMENO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private struct MEIOCHPFAEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int EGLNGLIPKAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public T BDGBGLMDOLF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly Dictionary<object, MEIOCHPFAEO> LGLDLFPPHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly EqualityComparer<T> FHHGOCLHELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private T LGHBHJJPKAB;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public virtual T IALPKDKEDMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xEDE870", Offset = "0xEDDC70", VA = "0x180EDE870", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x37AA170", Offset = "0x37A9570", VA = "0x1837AA170", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool OJHOIMMPEBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x37ADEC0", Offset = "0x37AD2C0", VA = "0x1837ADEC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public object MPPDKINLJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7A26C0", Offset = "0x7A1AC0", VA = "0x1807A26C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7A26B0", Offset = "0x7A1AB0", VA = "0x1807A26B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x37ACF20", Offset = "0x37AC320", VA = "0x1837ACF20")]
	public bool KLFCHEOKNCD(T ANJCCKHBJJO, object BDHKJODLPCL, int ODENJDCNKKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x37ACBA0", Offset = "0x37ABFA0", VA = "0x1837ACBA0")]
	public bool DKBAFHHGGMJ(object BDHKJODLPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x37AD720", Offset = "0x37ACB20", VA = "0x1837AD720")]
	public bool NICDJPMLKAP(object BDHKJODLPCL, [Out] T ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x37AA210", Offset = "0x37A9610", VA = "0x1837AA210")]
	public void BILLODBOEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x37AC390", Offset = "0x37AB790", VA = "0x1837AC390")]
	private bool CMGIFAPDBLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x37ADF10", Offset = "0x37AD310", VA = "0x1837ADF10")]
	public AOMMJOAMENO()
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
