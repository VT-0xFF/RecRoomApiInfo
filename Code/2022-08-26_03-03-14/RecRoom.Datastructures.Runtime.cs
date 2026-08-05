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
public class NDFGKDBIKGJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0")]
	public NDFGKDBIKGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, HMMHNBPHCGO, JKGNMEEONGA, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4A0", Offset = "0x5EB0A0", VA = "0x1805EC4A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDF0", Offset = "0x5ED9F0", VA = "0x1805EEDF0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x616D70", Offset = "0x615970", VA = "0x180616D70", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6A1F60", Offset = "0x6A0B60", VA = "0x1806A1F60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash CLFDHFBNGEA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xDDC560", Offset = "0xDDB160", VA = "0x180DDC560")]
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
	[EOCHCEPLPHC]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[HideInInspector]
	[EOCHCEPLPHC]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x57954F0", Offset = "0x57940F0", VA = "0x1857954F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x57954B0", Offset = "0x57940B0", VA = "0x1857954B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5795530", Offset = "0x5794130", VA = "0x185795530")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5795740", Offset = "0x5794340", VA = "0x185795740")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x57956B0", Offset = "0x57942B0", VA = "0x1857956B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x124C640", Offset = "0x124B240", VA = "0x18124C640")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x12354A0", Offset = "0x12340A0", VA = "0x1812354A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5795470", Offset = "0x5794070", VA = "0x185795470")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5795620", Offset = "0x5794220", VA = "0x185795620")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x57950B0", Offset = "0x5793CB0", VA = "0x1857950B0")]
	public void CopyBounds(SavedExtents NPKIIGGBCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x57953E0", Offset = "0x5793FE0", VA = "0x1857953E0")]
	public void SetLocalSpaceBounds(Bounds KIELLDPKEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x903690", Offset = "0x902290", VA = "0x180903690")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x57953D0", Offset = "0x5793FD0", VA = "0x1857953D0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x57948E0", Offset = "0x57934E0", VA = "0x1857948E0")]
	private void CEFAJNLCAFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x57951A0", Offset = "0x5793DA0", VA = "0x1857951A0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5794AF0", Offset = "0x57936F0", VA = "0x185794AF0")]
	public static void CalculateLocalBoundsFor(GameObject MHECAANKLIB, out Bounds KIELLDPKEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x57950E0", Offset = "0x5793CE0", VA = "0x1857950E0")]
	private static void HHFPPAMBOGC(Bounds EDLPJGEPJPK, Color OEMAJCAKGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5795400", Offset = "0x5794000", VA = "0x185795400")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEE0", Offset = "0x5EBAE0", VA = "0x1805ECEE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4A0", Offset = "0x5EB0A0", VA = "0x1805EC4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "4")]
	public virtual void FLNKJLLHEHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
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
	[NDFGKDBIKGJ]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x455F870", Offset = "0x455E470", VA = "0x18455F870", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x455F140", Offset = "0x455DD40", VA = "0x18455F140", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4560170", Offset = "0x455ED70", VA = "0x184560170")]
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
	private sealed class FNJOPJJLIOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		public FNJOPJJLIOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x499E650", Offset = "0x499D250", VA = "0x18499E650")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[NDFGKDBIKGJ]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x499E3A0", Offset = "0x499CFA0", VA = "0x18499E3A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x499E3D0", Offset = "0x499CFD0", VA = "0x18499E3D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x499E2F0", Offset = "0x499CEF0", VA = "0x18499E2F0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey KKDEFIFHPNN]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x499E320", Offset = "0x499CF20", VA = "0x18499E320", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x499E1F0", Offset = "0x499CDF0", VA = "0x18499E1F0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x499DA50", Offset = "0x499C650", VA = "0x18499DA50", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x499D3C0", Offset = "0x499BFC0", VA = "0x18499D3C0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x499D020", Offset = "0x499BC20", VA = "0x18499D020", Slot = "14")]
	protected virtual string HFMJOFKANGO(TKeyVal CFLOLIOEACC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4734D30", Offset = "0x4733930", VA = "0x184734D30", Slot = "4")]
	public bool ContainsKey(TKey KKDEFIFHPNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x499E0E0", Offset = "0x499CCE0", VA = "0x18499E0E0", Slot = "5")]
	public bool TryGetValue(TKey KKDEFIFHPNN, out TVal KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x499CF30", Offset = "0x499BB30", VA = "0x18499CF30", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x499CF30", Offset = "0x499BB30", VA = "0x18499CF30", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x499E110", Offset = "0x499CD10", VA = "0x18499E110")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NOOILGCPALB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class LFMJOKBGFGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		public LFMJOKBGFGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3E77640", Offset = "0x3E76240", VA = "0x183E77640")]
		internal bool <GetSamples>b__0(global::JKOIKBEOONN<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float KJGPONPNIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float OBPOICEPKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::JKOIKBEOONN<float, T>> KLMNPHAGKOK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int IFFLKNOIODM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E630", Offset = "0x3E7D230", VA = "0x183E7E630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3E7E790", Offset = "0x3E7D390", VA = "0x183E7E790")]
	public NOOILGCPALB(float HEGLNJDNFKG, float POOIELJCKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3E7DC00", Offset = "0x3E7C800", VA = "0x183E7DC00")]
	public bool BDPHEPBPCAF(float DGJLIHODPMN, T KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3E7E730", Offset = "0x3E7D330", VA = "0x183E7E730")]
	public int POKLDMGINFD(float DGJLIHODPMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3E7E200", Offset = "0x3E7CE00", VA = "0x183E7E200")]
	public IEnumerable<T> DFBGLOHFINN(float DGJLIHODPMN, [Optional] float? HGKDGGNNAFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3E7E600", Offset = "0x3E7D200", VA = "0x183E7E600")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3E7E540", Offset = "0x3E7D140", VA = "0x183E7E540")]
	private void IDKDOKMACLA(float DGJLIHODPMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class OFKBNNKANNL<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct ECMIIJCFMPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T ONGHMHAEIAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float NCALJMHDMEL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float IOMMKBANGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> ECFGCIMEFFI;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int CNMJFBLCDGF = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private ECMIIJCFMPI[] LBLDONKHBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int CMLHGBMLKPM;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float DPPHJHMBKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1150E60", Offset = "0x114FA60", VA = "0x181150E60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x109BC40", Offset = "0x109A840", VA = "0x18109BC40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2626C00", Offset = "0x2625800", VA = "0x182626C00")]
	public OFKBNNKANNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2626B20", Offset = "0x2625720", VA = "0x182626B20")]
	public OFKBNNKANNL(int OEBMILJLIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2626150", Offset = "0x2624D50", VA = "0x182626150")]
	public void LFMPFEAFMAL(float DGJLIHODPMN, T KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2626980", Offset = "0x2625580", VA = "0x182626980")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x26257E0", Offset = "0x26243E0", VA = "0x1826257E0")]
	public bool EMCFHDHAFGE(float BHIINNLFIPN, float BNIHMHICMNF, out T KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2626390", Offset = "0x2624F90", VA = "0x182626390")]
	public bool LLJIOOALIGH(float BHIINNLFIPN, float BNIHMHICMNF, out T KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2625D20", Offset = "0x2624920", VA = "0x182625D20")]
	public void KICOCECKDLK(float BHIINNLFIPN, float BNIHMHICMNF, List<T> LGIIJIKLGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x26266B0", Offset = "0x26252B0", VA = "0x1826266B0")]
	private int LMJEDJJMDHN(int FMJNBLHJIAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x26255F0", Offset = "0x26241F0", VA = "0x1826255F0")]
	private void AJCNOPMHFNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T KJFBHMKFBMP();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T BKGJLGBBEAA(T EHGLDEHJCJA, T POGMGOCOOHC, float LDKDBEMBOCB);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T CGNFMJMGNEI(T KGJOJGIPNPH, float LDKDBEMBOCB);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T OGPKKEBMJAJ(T EHGLDEHJCJA, T POGMGOCOOHC);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T PPBDIJFCGIG(T EHGLDEHJCJA, T POGMGOCOOHC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class EMHAAMANJDI : global::OFKBNNKANNL<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x578ECC0", Offset = "0x578D8C0", VA = "0x18578ECC0", Slot = "4")]
	protected override Vector3 KJFBHMKFBMP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x578EB60", Offset = "0x578D760", VA = "0x18578EB60", Slot = "5")]
	protected override Vector3 BKGJLGBBEAA(Vector3 EHGLDEHJCJA, Vector3 POGMGOCOOHC, float LDKDBEMBOCB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x578EC20", Offset = "0x578D820", VA = "0x18578EC20", Slot = "6")]
	protected override Vector3 CGNFMJMGNEI(Vector3 KGJOJGIPNPH, float LDKDBEMBOCB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x578ED30", Offset = "0x578D930", VA = "0x18578ED30", Slot = "7")]
	protected override Vector3 OGPKKEBMJAJ(Vector3 EHGLDEHJCJA, Vector3 POGMGOCOOHC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x578EDE0", Offset = "0x578D9E0", VA = "0x18578EDE0", Slot = "8")]
	protected override Vector3 PPBDIJFCGIG(Vector3 EHGLDEHJCJA, Vector3 POGMGOCOOHC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x578EE50", Offset = "0x578DA50", VA = "0x18578EE50")]
	public EMHAAMANJDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GCKNIAKEMPI : global::OFKBNNKANNL<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x578FE00", Offset = "0x578EA00", VA = "0x18578FE00")]
	public GCKNIAKEMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x578FE60", Offset = "0x578EA60", VA = "0x18578FE60")]
	public GCKNIAKEMPI(int OEBMILJLIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xF16E50", Offset = "0xF15A50", VA = "0x180F16E50", Slot = "4")]
	protected override float KJFBHMKFBMP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x578FD70", Offset = "0x578E970", VA = "0x18578FD70", Slot = "5")]
	protected override float BKGJLGBBEAA(float EHGLDEHJCJA, float POGMGOCOOHC, float LDKDBEMBOCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x40CADA0", Offset = "0x40C99A0", VA = "0x1840CADA0", Slot = "6")]
	protected override float CGNFMJMGNEI(float KGJOJGIPNPH, float LDKDBEMBOCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x22C3C60", Offset = "0x22C2860", VA = "0x1822C3C60", Slot = "7")]
	protected override float OGPKKEBMJAJ(float EHGLDEHJCJA, float POGMGOCOOHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x578FDF0", Offset = "0x578E9F0", VA = "0x18578FDF0", Slot = "8")]
	protected override float PPBDIJFCGIG(float EHGLDEHJCJA, float POGMGOCOOHC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GKMIIBGDEDH
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1E38E00", Offset = "0x1E37A00", VA = "0x181E38E00")]
	public static global::NINGKGAHBGD<T1> DPFIJBHMAAN<T1>(T1 EKJNFLPGMED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x20C80A0", Offset = "0x20C6CA0", VA = "0x1820C80A0")]
	public static global::JKOIKBEOONN<T1, T2> DPFIJBHMAAN<T1, T2>(T1 EKJNFLPGMED, T2 AEAJKGBAOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9D90", Offset = "0x1FB8990", VA = "0x181FB9D90")]
	public static global::AFMKCHMEDMF<T1, T2, T3> DPFIJBHMAAN<T1, T2, T3>(T1 EKJNFLPGMED, T2 AEAJKGBAOBC, T3 NDLLHLDJBLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8FA0", Offset = "0x1FB7BA0", VA = "0x181FB8FA0")]
	public static global::HGIBNMPKHOH<T1, T2, T3, T4> DPFIJBHMAAN<T1, T2, T3, T4>(T1 EKJNFLPGMED, T2 AEAJKGBAOBC, T3 NDLLHLDJBLA, T4 ODOFLELNGBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9E20", Offset = "0x1FB8A20", VA = "0x181FB9E20")]
	public static global::CMAGLLIADPM<T1, T2, T3, T4, T5> DPFIJBHMAAN<T1, T2, T3, T4, T5>(T1 EKJNFLPGMED, T2 AEAJKGBAOBC, T3 NDLLHLDJBLA, T4 ODOFLELNGBF, T5 HIFOGJJOPPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3132BE0", Offset = "0x31317E0", VA = "0x183132BE0")]
	public static global::OKDMKPFGJAM<T1, T2, T3, T4, T5, T6> DPFIJBHMAAN<T1, T2, T3, T4, T5, T6>(T1 EKJNFLPGMED, T2 AEAJKGBAOBC, T3 NDLLHLDJBLA, T4 ODOFLELNGBF, T5 HIFOGJJOPPC, T6 EGJMFAFKGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x20C81E0", Offset = "0x20C6DE0", VA = "0x1820C81E0")]
	public static global::MMNIGBPBIIA<T1, T2, T3, T4, T5, T6, T7> DPFIJBHMAAN<T1, T2, T3, T4, T5, T6, T7>(T1 EKJNFLPGMED, T2 AEAJKGBAOBC, T3 NDLLHLDJBLA, T4 ODOFLELNGBF, T5 HIFOGJJOPPC, T6 EGJMFAFKGND, T7 FEEJFOOPMIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x20C8110", Offset = "0x20C6D10", VA = "0x1820C8110")]
	public static global::IGFOFFNBJBE<T1, T2, T3, T4, T5, T6, T7, T8> DPFIJBHMAAN<T1, T2, T3, T4, T5, T6, T7, T8>(T1 EKJNFLPGMED, T2 AEAJKGBAOBC, T3 NDLLHLDJBLA, T4 ODOFLELNGBF, T5 HIFOGJJOPPC, T6 EGJMFAFKGND, T7 FEEJFOOPMIP, T8 EAGLPCHLDEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1AA8980", Offset = "0x1AA7580", VA = "0x181AA8980")]
	[IteratorStateMachine(typeof(BHKEBJFGECE))]
	public static IEnumerable<global::JKOIKBEOONN<T1, T2>> KMPOIDKJCJM<T1, T2>(IEnumerable<T1> FNKIIBFNLFB, IEnumerable<T2> EDLPJGEPJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1DD0330", Offset = "0x1DCEF30", VA = "0x181DD0330")]
	[IteratorStateMachine(typeof(EBGJACICLKN))]
	public static IEnumerable<global::AFMKCHMEDMF<T1, T2, T3>> KMPOIDKJCJM<T1, T2, T3>(IEnumerable<T1> FNKIIBFNLFB, IEnumerable<T2> EDLPJGEPJPK, IEnumerable<T3> OEMAJCAKGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xC11EE0", Offset = "0xC10AE0", VA = "0x180C11EE0")]
	internal static int FMIOJGJCHLO(int FPBGHLNDJOD, int KHMIGJAOKDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xC11EF0", Offset = "0xC10AF0", VA = "0x180C11EF0")]
	internal static int FMIOJGJCHLO(int FPBGHLNDJOD, int KHMIGJAOKDB, int LCGAHMGMPHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xC11F00", Offset = "0xC10B00", VA = "0x180C11F00")]
	internal static int FMIOJGJCHLO(int FPBGHLNDJOD, int KHMIGJAOKDB, int LCGAHMGMPHA, int BDAKGDADOEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5790540", Offset = "0x578F140", VA = "0x185790540")]
	internal static int FMIOJGJCHLO(int FPBGHLNDJOD, int KHMIGJAOKDB, int LCGAHMGMPHA, int BDAKGDADOEI, int GLDIJPFLAIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x57904C0", Offset = "0x578F0C0", VA = "0x1857904C0")]
	internal static int FMIOJGJCHLO(int FPBGHLNDJOD, int KHMIGJAOKDB, int LCGAHMGMPHA, int BDAKGDADOEI, int GLDIJPFLAIH, int IBAENGKOAJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x57904E0", Offset = "0x578F0E0", VA = "0x1857904E0")]
	internal static int FMIOJGJCHLO(int FPBGHLNDJOD, int KHMIGJAOKDB, int LCGAHMGMPHA, int BDAKGDADOEI, int GLDIJPFLAIH, int IBAENGKOAJG, int LIACDNHBELI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5790510", Offset = "0x578F110", VA = "0x185790510")]
	internal static int FMIOJGJCHLO(int FPBGHLNDJOD, int KHMIGJAOKDB, int LCGAHMGMPHA, int BDAKGDADOEI, int GLDIJPFLAIH, int IBAENGKOAJG, int LIACDNHBELI, int OCGLKBJPHJJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NINGKGAHBGD<T1> : IComparable<global::NINGKGAHBGD<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 CBBKOHMDNDG;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2265A90", Offset = "0x2264690", VA = "0x182265A90")]
	public NINGKGAHBGD(T1 EKJNFLPGMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x28C61E0", Offset = "0x28C4DE0", VA = "0x1828C61E0", Slot = "4")]
	public int CompareTo(global::NINGKGAHBGD<T1> NPKIIGGBCCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x28C6250", Offset = "0x28C4E50", VA = "0x1828C6250", Slot = "0")]
	public override bool Equals(object NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8F6150", Offset = "0x8F4D50", VA = "0x1808F6150", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x28C62F0", Offset = "0x28C4EF0", VA = "0x1828C62F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JKOIKBEOONN<T1, T2> : IComparable<global::JKOIKBEOONN<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 CBBKOHMDNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 LEBPDNAKONM;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x366BDD0", Offset = "0x366A9D0", VA = "0x18366BDD0")]
	public JKOIKBEOONN(T1 EKJNFLPGMED, T2 AEAJKGBAOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x366A050", Offset = "0x3668C50", VA = "0x18366A050", Slot = "4")]
	public int CompareTo(global::JKOIKBEOONN<T1, T2> NPKIIGGBCCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x366A760", Offset = "0x3669360", VA = "0x18366A760", Slot = "0")]
	public override bool Equals(object NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x366B2C0", Offset = "0x3669EC0", VA = "0x18366B2C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x366B720", Offset = "0x366A320", VA = "0x18366B720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AFMKCHMEDMF<T1, T2, T3> : IComparable<global::AFMKCHMEDMF<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 CBBKOHMDNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 LEBPDNAKONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 KKOLODHPAFL;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2D96150", Offset = "0x2D94D50", VA = "0x182D96150")]
	public AFMKCHMEDMF(T1 EKJNFLPGMED, T2 AEAJKGBAOBC, T3 NDLLHLDJBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2D95A70", Offset = "0x2D94670", VA = "0x182D95A70", Slot = "4")]
	public int CompareTo(global::AFMKCHMEDMF<T1, T2, T3> NPKIIGGBCCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2D95C60", Offset = "0x2D94860", VA = "0x182D95C60", Slot = "0")]
	public override bool Equals(object NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2D95E60", Offset = "0x2D94A60", VA = "0x182D95E60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2D95ED0", Offset = "0x2D94AD0", VA = "0x182D95ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HGIBNMPKHOH<T1, T2, T3, T4> : IComparable<global::HGIBNMPKHOH<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 CBBKOHMDNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 LEBPDNAKONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 KKOLODHPAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 BIOGHKDKCJO;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2623620", Offset = "0x2622220", VA = "0x182623620")]
	public HGIBNMPKHOH(T1 EKJNFLPGMED, T2 AEAJKGBAOBC, T3 NDLLHLDJBLA, T4 ODOFLELNGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3A57C80", Offset = "0x3A56880", VA = "0x183A57C80", Slot = "4")]
	public int CompareTo(global::HGIBNMPKHOH<T1, T2, T3, T4> NPKIIGGBCCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3A57DC0", Offset = "0x3A569C0", VA = "0x183A57DC0", Slot = "0")]
	public override bool Equals(object NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3A57EE0", Offset = "0x3A56AE0", VA = "0x183A57EE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3A57FA0", Offset = "0x3A56BA0", VA = "0x183A57FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CMAGLLIADPM<T1, T2, T3, T4, T5> : IComparable<global::CMAGLLIADPM<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 CBBKOHMDNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 LEBPDNAKONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 KKOLODHPAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 BIOGHKDKCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 OJCKEDDPNGH;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x37F7C70", Offset = "0x37F6870", VA = "0x1837F7C70")]
	public CMAGLLIADPM(T1 EKJNFLPGMED, T2 AEAJKGBAOBC, T3 NDLLHLDJBLA, T4 ODOFLELNGBF, T5 HIFOGJJOPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x37F7780", Offset = "0x37F6380", VA = "0x1837F7780", Slot = "4")]
	public int CompareTo(global::CMAGLLIADPM<T1, T2, T3, T4, T5> NPKIIGGBCCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x37F7900", Offset = "0x37F6500", VA = "0x1837F7900", Slot = "0")]
	public override bool Equals(object NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x37F7A40", Offset = "0x37F6640", VA = "0x1837F7A40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x37F7B40", Offset = "0x37F6740", VA = "0x1837F7B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OKDMKPFGJAM<T1, T2, T3, T4, T5, T6> : IComparable<global::OKDMKPFGJAM<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 CBBKOHMDNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 LEBPDNAKONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 KKOLODHPAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 BIOGHKDKCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 OJCKEDDPNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 LIOOCCKJLCF;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x497D480", Offset = "0x497C080", VA = "0x18497D480")]
	public OKDMKPFGJAM(T1 EKJNFLPGMED, T2 AEAJKGBAOBC, T3 NDLLHLDJBLA, T4 ODOFLELNGBF, T5 HIFOGJJOPPC, T6 EGJMFAFKGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x497CEE0", Offset = "0x497BAE0", VA = "0x18497CEE0", Slot = "4")]
	public int CompareTo(global::OKDMKPFGJAM<T1, T2, T3, T4, T5, T6> NPKIIGGBCCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x497D0A0", Offset = "0x497BCA0", VA = "0x18497D0A0", Slot = "0")]
	public override bool Equals(object NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x497D210", Offset = "0x497BE10", VA = "0x18497D210", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x497D330", Offset = "0x497BF30", VA = "0x18497D330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MMNIGBPBIIA<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::MMNIGBPBIIA<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 CBBKOHMDNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 LEBPDNAKONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 KKOLODHPAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 BIOGHKDKCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 OJCKEDDPNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 LIOOCCKJLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 NGOGDKOGAEN;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4021BB0", Offset = "0x40207B0", VA = "0x184021BB0")]
	public MMNIGBPBIIA(T1 EKJNFLPGMED, T2 AEAJKGBAOBC, T3 NDLLHLDJBLA, T4 ODOFLELNGBF, T5 HIFOGJJOPPC, T6 EGJMFAFKGND, T7 FEEJFOOPMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4021550", Offset = "0x4020150", VA = "0x184021550", Slot = "4")]
	public int CompareTo(global::MMNIGBPBIIA<T1, T2, T3, T4, T5, T6, T7> NPKIIGGBCCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4021750", Offset = "0x4020350", VA = "0x184021750", Slot = "0")]
	public override bool Equals(object NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x40218F0", Offset = "0x40204F0", VA = "0x1840218F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4021A40", Offset = "0x4020640", VA = "0x184021A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class IGFOFFNBJBE<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::IGFOFFNBJBE<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 CBBKOHMDNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 LEBPDNAKONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 KKOLODHPAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 BIOGHKDKCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 OJCKEDDPNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 LIOOCCKJLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 NGOGDKOGAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 KPMDIBECPFI;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2CAB5C0", Offset = "0x2CAA1C0", VA = "0x182CAB5C0")]
	public IGFOFFNBJBE(T1 EKJNFLPGMED, T2 AEAJKGBAOBC, T3 NDLLHLDJBLA, T4 ODOFLELNGBF, T5 HIFOGJJOPPC, T6 EGJMFAFKGND, T7 FEEJFOOPMIP, T8 EAGLPCHLDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2CAAEB0", Offset = "0x2CA9AB0", VA = "0x182CAAEB0", Slot = "4")]
	public int CompareTo(global::IGFOFFNBJBE<T1, T2, T3, T4, T5, T6, T7, T8> NPKIIGGBCCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2CAB100", Offset = "0x2CA9D00", VA = "0x182CAB100", Slot = "0")]
	public override bool Equals(object NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2CAB2C0", Offset = "0x2CA9EC0", VA = "0x182CAB2C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2CAB430", Offset = "0x2CAA030", VA = "0x182CAB430", Slot = "3")]
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
	public T ONGHMHAEIAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x614A30", Offset = "0x613630", VA = "0x180614A30")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x724880", Offset = "0x723480", VA = "0x180724880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float HOIIEANPBIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1026E00", Offset = "0x1025A00", VA = "0x181026E00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x42EA600", Offset = "0x42E9200", VA = "0x1842EA600")]
	public T GPKIMIINOIL(float LDKDBEMBOCB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x42EA1A0", Offset = "0x42E8DA0", VA = "0x1842EA1A0")]
	public T AIHDBLICJFJ(float LDKDBEMBOCB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BKGJLGBBEAA(T EHGLDEHJCJA, T POGMGOCOOHC, float LDKDBEMBOCB);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x578EF90", Offset = "0x578DB90", VA = "0x18578EF90", Slot = "4")]
	protected override float BKGJLGBBEAA(float EHGLDEHJCJA, float POGMGOCOOHC, float LDKDBEMBOCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x578F010", Offset = "0x578DC10", VA = "0x18578F010")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x57966A0", Offset = "0x57952A0", VA = "0x1857966A0", Slot = "4")]
	protected override Vector3 BKGJLGBBEAA(Vector3 EHGLDEHJCJA, Vector3 POGMGOCOOHC, float LDKDBEMBOCB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5796760", Offset = "0x5795360", VA = "0x185796760")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x578E5A0", Offset = "0x578D1A0", VA = "0x18578E5A0", Slot = "4")]
	protected override Color BKGJLGBBEAA(Color EHGLDEHJCJA, Color POGMGOCOOHC, float LDKDBEMBOCB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x578E5F0", Offset = "0x578D1F0", VA = "0x18578E5F0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OKGPDLHICBB : global::KMMNMGPMDCL<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5793C60", Offset = "0x5792860", VA = "0x185793C60")]
	public OKGPDLHICBB(int LAODCMGHKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5793C00", Offset = "0x5792800", VA = "0x185793C00")]
	public OKGPDLHICBB(NODPGKNJGNO[] BOKEGPABBHH, bool PDCCHFAIJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5793B90", Offset = "0x5792790", VA = "0x185793B90", Slot = "6")]
	protected override uint ILPFKINAKDO(uint CLFDHFBNGEA, string KGJOJGIPNPH)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GMJJJINJGFO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable DBFNMCLAAPC;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public GMJJJINJGFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DebuggerTypeProxy(typeof(global::MLPOACMMMJN<>.AHMFFHIIDAD))]
[DefaultMember("Item")]
public sealed class MLPOACMMMJN<T> : IDisposable, global::EIKCEKABEEJ<T>, LIEBLJHOMNH, global::IPAEEKBEOBE<T, global::MLPOACMMMJN<T>.FEBDOCHCAOJ>, global::HPIMHAGOMMH<T>, global::NPLDJALPNAC<T, global::MLPOACMMMJN<T>.FEBDOCHCAOJ>, global::IOPLDKDIGGC<T>, global::EPCHNKGLMFP<T, global::MLPOACMMMJN<T>.FEBDOCHCAOJ>, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct FEBDOCHCAOJ : LIEBLJHOMNH, global::KJAADGLJOHG<T>, global::PJBCEPJCBDK<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly global::MLPOACMMMJN<T> KJJBMKIAPLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private int NIKGHOOEPAJ;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int NGNMMFPKHGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x1FC7790", Offset = "0x1FC6390", VA = "0x181FC7790", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public T IJPBKONCNPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x2A186A0", Offset = "0x2A172A0", VA = "0x182A186A0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private T BMLCBKEIGEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x2A17F60", Offset = "0x2A16B60", VA = "0x182A17F60", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x2A18130", Offset = "0x2A16D30", VA = "0x182A18130", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x2A182A0", Offset = "0x2A16EA0", VA = "0x182A182A0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2A18590", Offset = "0x2A17190", VA = "0x182A18590")]
		private FEBDOCHCAOJ(global::MLPOACMMMJN<T> FNGHHBJHDMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2872930", Offset = "0x2871530", VA = "0x182872930")]
		public static FEBDOCHCAOJ GLGBCEHJPPK(global::MLPOACMMMJN<T> FNGHHBJHDMF)
		{
			return default(FEBDOCHCAOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2A17FC0", Offset = "0x2A16BC0", VA = "0x182A17FC0", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x28729C0", Offset = "0x28715C0", VA = "0x1828729C0", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class AHMFFHIIDAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly global::MLPOACMMMJN<T> KJJBMKIAPLP;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public int NGNMMFPKHGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x2777150", Offset = "0x2775D50", VA = "0x182777150")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public T[] NGJHLCKDBLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x2A16CC0", Offset = "0x2A158C0", VA = "0x182A16CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool GAILNDCGGNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x2A16C00", Offset = "0x2A15800", VA = "0x182A16C00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2265A90", Offset = "0x2264690", VA = "0x182265A90")]
		public AHMFFHIIDAD(global::MLPOACMMMJN<T> FNGHHBJHDMF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly OCCNDPBMNNC JKNGFDGCKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private T[] ILHLJGCJPMC;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCD0", Offset = "0x5EB8D0", VA = "0x1805ECCD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x66DA10", Offset = "0x66C610", VA = "0x18066DA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Span<T> NGJHLCKDBLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2A25F50", Offset = "0x2A24B50", VA = "0x182A25F50")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T LAAHBFAPJIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2A242C0", Offset = "0x2A22EC0", VA = "0x182A242C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T GOFLCMJPHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A242C0", Offset = "0x2A22EC0", VA = "0x182A242C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public T GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x401FCE0", Offset = "0x401E8E0", VA = "0x18401FCE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2A24C30", Offset = "0x2A23830", VA = "0x182A24C30")]
	public static global::MLPOACMMMJN<T> GLGBCEHJPPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A24A50", Offset = "0x2A23650", VA = "0x182A24A50")]
	public static global::MLPOACMMMJN<T> FNBECMGLCOM(int LAODCMGHKOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A26AD0", Offset = "0x2A256D0", VA = "0x182A26AD0")]
	internal MLPOACMMMJN(T[] IOKOEGGOMPK, int BKKGFAKFDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2715780", Offset = "0x2714380", VA = "0x182715780", Slot = "5")]
	public T FNLBPOMBHHO(int JNJLPHNJHIN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2A24890", Offset = "0x2A23490", VA = "0x182A24890", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2A25C10", Offset = "0x2A24810", VA = "0x182A25C10")]
	public void LFMPFEAFMAL(in T KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2A26850", Offset = "0x2A25450", VA = "0x182A26850")]
	public void PIKMDDMGAGA(int HIANDEDCLIF, in T KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2A24B90", Offset = "0x2A23790", VA = "0x182A24B90")]
	public void FNJJGGMAHAD(int HIANDEDCLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2A251F0", Offset = "0x2A23DF0", VA = "0x182A251F0")]
	public void IELPOGKABBL(int OEBMILJLIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2A25980", Offset = "0x2A24580", VA = "0x182A25980")]
	private void IMOGNEIGOBH(int LAODCMGHKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2A25F20", Offset = "0x2A24B20", VA = "0x182A25F20")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2A244E0", Offset = "0x2A230E0", VA = "0x182A244E0")]
	public global::MLPOACMMMJN<T> DJGGNJCKKCO(global::PEJBAIBNPEG<T, T> KEKJJFLHHNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2A24D70", Offset = "0x2A23970", VA = "0x182A24D70", Slot = "11")]
	public FEBDOCHCAOJ GetEnumerator()
	{
		return default(FEBDOCHCAOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2A24910", Offset = "0x2A23510", VA = "0x182A24910", Slot = "8")]
	private global::KJAADGLJOHG<T> EBDLCIIHKAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2A24910", Offset = "0x2A23510", VA = "0x182A24910", Slot = "10")]
	private global::PJBCEPJCBDK<T> FNDBPEHMELG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2A24910", Offset = "0x2A23510", VA = "0x182A24910", Slot = "12")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2A24910", Offset = "0x2A23510", VA = "0x182A24910", Slot = "13")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class IJODINJPLIJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x27E39D0", Offset = "0x27E25D0", VA = "0x1827E39D0")]
	public static bool ODGMBAOCBHK<T>(this global::MLPOACMMMJN<T> FNGHHBJHDMF, in T KGJOJGIPNPH) where T : global::AMFKIKPGKDH<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct CEKFPOBHJLL
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class DGAMGNJIFJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public TaskCompletionSource<CLMGAOKFIAE> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public DGAMGNJIFJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x578E630", Offset = "0x578D230", VA = "0x18578E630")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<CLMGAOKFIAE>> ILFCECDNPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private int IKGIJPFEPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int PHPGEJNPLNM;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x9F99E0", Offset = "0x9F85E0", VA = "0x1809F99E0")]
	private CEKFPOBHJLL(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<CLMGAOKFIAE>> DNNKNDMMGIF, int AAGGDFOELAG, int BANAAFJPHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x578CFB0", Offset = "0x578BBB0", VA = "0x18578CFB0")]
	public static CEKFPOBHJLL GLGBCEHJPPK()
	{
		return default(CEKFPOBHJLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x578D030", Offset = "0x578BC30", VA = "0x18578D030")]
	public (int, int, Task) IABDLCDMCJL(int HNNEPLMLAAB, [Optional] CancellationToken DHCIMDILIGO)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x578CF00", Offset = "0x578BB00", VA = "0x18578CF00")]
	public void BFGEMCFCBJC(int HNNEPLMLAAB, int BANAAFJPHEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class CGDLNGIMIEG<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly Dictionary<TKey, TVal> IFGIKNEPOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<TVal, TKey> EJCBCKMDPAD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2777150", Offset = "0x2775D50", VA = "0x182777150", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool IDIBHBMOFCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ICollection<TKey> BAECMHCJKEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x29C5EB0", Offset = "0x29C4AB0", VA = "0x1829C5EB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public ICollection<TVal> HPAEFAPGEKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x21D8F40", Offset = "0x21D7B40", VA = "0x1821D8F40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public TVal GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6090", Offset = "0x2CA4C90", VA = "0x182CA6090", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2908960", Offset = "0x2907560", VA = "0x182908960", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public TKey GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x33CC590", Offset = "0x33CB190", VA = "0x1833CC590")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x33CBFF0", Offset = "0x33CABF0", VA = "0x1833CBFF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x33CC140", Offset = "0x33CAD40", VA = "0x1833CC140", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x33CCAC0", Offset = "0x33CB6C0", VA = "0x1833CCAC0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3384EB0", Offset = "0x3383AB0", VA = "0x183384EB0", Slot = "9")]
	public void Add(TKey KKDEFIFHPNN, TVal KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x33CBF50", Offset = "0x33CAB50", VA = "0x1833CBF50", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> IGAPBICELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x33CC1A0", Offset = "0x33CADA0", VA = "0x1833CC1A0", Slot = "8")]
	public bool ContainsKey(TKey KKDEFIFHPNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x33CC1D0", Offset = "0x33CADD0", VA = "0x1833CC1D0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> IGAPBICELKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x33CCA60", Offset = "0x33CB660", VA = "0x1833CCA60", Slot = "10")]
	public bool Remove(TKey KKDEFIFHPNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x33CCA60", Offset = "0x33CB660", VA = "0x1833CCA60", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> IGAPBICELKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2A1BC30", Offset = "0x2A1A830", VA = "0x182A1BC30", Slot = "11")]
	public bool TryGetValue(TKey KKDEFIFHPNN, out TVal KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x33CC640", Offset = "0x33CB240", VA = "0x1833CC640", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x33CC230", Offset = "0x33CAE30", VA = "0x1833CC230", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] LBLDONKHBCF, int BPPENCELOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x33CC940", Offset = "0x33CB540", VA = "0x1833CC940")]
	public void LFMPFEAFMAL(TVal OOIECLPAPEE, TKey KKDEFIFHPNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x33CC9C0", Offset = "0x33CB5C0", VA = "0x1833CC9C0")]
	public void LFMPFEAFMAL(KeyValuePair<TVal, TKey> IGAPBICELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x33CCA30", Offset = "0x33CB630", VA = "0x1833CCA30")]
	public bool NMGBHFPBKPM(TVal KKDEFIFHPNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x29A2CB0", Offset = "0x29A18B0", VA = "0x1829A2CB0")]
	public bool ACOKKIFAPKJ(KeyValuePair<TVal, TKey> IGAPBICELKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x28FC1A0", Offset = "0x28FADA0", VA = "0x1828FC1A0")]
	public bool JNIHJKFEBJI(TVal KKDEFIFHPNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x28FC1A0", Offset = "0x28FADA0", VA = "0x1828FC1A0")]
	public bool JNIHJKFEBJI(KeyValuePair<TVal, TKey> IGAPBICELKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x33CC6C0", Offset = "0x33CB2C0", VA = "0x1833CC6C0")]
	public bool HMDEELNDPOI(TVal KKDEFIFHPNN, out TKey KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x33CC6F0", Offset = "0x33CB2F0", VA = "0x1833CC6F0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> ICJGMMHMBNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x33CC890", Offset = "0x33CB490", VA = "0x1833CC890")]
	private void JDMAFHPFPNF(TKey KKDEFIFHPNN, TVal OOIECLPAPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x33CC0C0", Offset = "0x33CACC0", VA = "0x1833CC0C0")]
	private void COFBCKICJOE(TKey KKDEFIFHPNN, TVal OOIECLPAPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x33CC4D0", Offset = "0x33CB0D0", VA = "0x1833CC4D0")]
	private bool DABKMIOMOJG(TKey KKDEFIFHPNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x33CC290", Offset = "0x33CAE90", VA = "0x1833CC290")]
	private bool DABKMIOMOJG(TVal OOIECLPAPEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x33CCB60", Offset = "0x33CB760", VA = "0x1833CCB60")]
	public CGDLNGIMIEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class LHEGHBLPCBE<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private global::LHEGHBLPCBE<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x1150E60", Offset = "0x114FA60", VA = "0x181150E60", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x39AE170", Offset = "0x39ACD70", VA = "0x1839AE170", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x39AE680", Offset = "0x39AD280", VA = "0x1839AE680")]
		public Enumerator(global::LHEGHBLPCBE<T> LGIIJIKLGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x39ADDC0", Offset = "0x39AC9C0", VA = "0x1839ADDC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x39AE080", Offset = "0x39ACC80", VA = "0x1839AE080", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x39AD950", Offset = "0x39AC550", VA = "0x1839AD950")]
		private void EPIGOEENOOF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private T[] PICCBBKHEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private int KAENBJHHHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private int NNKKJOCABAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private int MAAFFLODELA;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x39B6350", Offset = "0x39B4F50", VA = "0x1839B6350")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public T GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x39B5B00", Offset = "0x39B4700", VA = "0x1839B5B00")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x39B58E0", Offset = "0x39B44E0", VA = "0x1839B58E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x39B6C20", Offset = "0x39B5820", VA = "0x1839B6C20")]
	public LHEGHBLPCBE(int LAODCMGHKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x39B60F0", Offset = "0x39B4CF0", VA = "0x1839B60F0")]
	public void LFMPFEAFMAL(T LDKDBEMBOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x39B5550", Offset = "0x39B4150", VA = "0x1839B5550")]
	public void BHLBJEJJMFO(IEnumerable<T> AIFJHEPBPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x39B6330", Offset = "0x39B4F30", VA = "0x1839B6330")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x39B5850", Offset = "0x39B4450", VA = "0x1839B5850")]
	public void BLBPHKANEJP(int BKKGFAKFDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x39B4BA0", Offset = "0x39B37A0", VA = "0x1839B4BA0")]
	public void AHAFIALJIGF(int BKKGFAKFDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x39B64F0", Offset = "0x39B50F0", VA = "0x1839B64F0")]
	public void PLJCJKLBIDG(T[] LBLDONKHBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x39B6480", Offset = "0x39B5080", VA = "0x1839B6480")]
	public Enumerator OKMFHIDEJFI()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x39B6AE0", Offset = "0x39B56E0", VA = "0x1839B6AE0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x39B6AE0", Offset = "0x39B56E0", VA = "0x1839B6AE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x39B5E60", Offset = "0x39B4A60", VA = "0x1839B5E60")]
	private int FOKHDMKDCMB(int HIANDEDCLIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x39B5AD0", Offset = "0x39B46D0", VA = "0x1839B5AD0")]
	private int CLAMINAAMBC(int HIANDEDCLIF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct NHBNLPHJNBG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly IDisposable[] ILHLJGCJPMC;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x72D470", Offset = "0x72C070", VA = "0x18072D470")]
	public NHBNLPHJNBG(params IDisposable[] IOKOEGGOMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xE3FDF0", Offset = "0xE3E9F0", VA = "0x180E3FDF0")]
	public static NHBNLPHJNBG GLGBCEHJPPK(params IDisposable[] IOKOEGGOMPK)
	{
		return default(NHBNLPHJNBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x57930B0", Offset = "0x5791CB0", VA = "0x1857930B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct BDGGOLJBLMC<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IDisposable BHGGBLDCKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public T ONGHMHAEIAB;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2901E70", Offset = "0x2900A70", VA = "0x182901E70")]
	public BDGGOLJBLMC(IDisposable PIKMLOGMBBA, in T KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1FB43B0", Offset = "0x1FB2FB0", VA = "0x181FB43B0")]
	public static global::BDGGOLJBLMC<U> KNGCADPEDBN<U>(in global::BDGGOLJBLMC<T> PIKMLOGMBBA, in U KGJOJGIPNPH)
	{
		return default(global::BDGGOLJBLMC<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4380", Offset = "0x1FB2F80", VA = "0x181FB4380")]
	public global::BDGGOLJBLMC<U> GJCEKIMIHBD<U>(in U KGJOJGIPNPH)
	{
		return default(global::BDGGOLJBLMC<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x1FB43F0", Offset = "0x1FB2FF0", VA = "0x181FB43F0")]
	public static global::BDGGOLJBLMC<(T, U)> OGOONHBBHGP<U>(in global::BDGGOLJBLMC<T> FNKIIBFNLFB, in global::BDGGOLJBLMC<U> EDLPJGEPJPK)
	{
		return default(global::BDGGOLJBLMC<(T, U)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2901CE0", Offset = "0x29008E0", VA = "0x182901CE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class KMCOALOPJLF
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x1FBC5C0", Offset = "0x1FBB1C0", VA = "0x181FBC5C0")]
	public static global::BDGGOLJBLMC<T> GLGBCEHJPPK<T>(IDisposable PIKMLOGMBBA, in T KGJOJGIPNPH)
	{
		return default(global::BDGGOLJBLMC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4380", Offset = "0x1FB2F80", VA = "0x181FB4380")]
	public static global::BDGGOLJBLMC<U> KNGCADPEDBN<U, T>(in global::BDGGOLJBLMC<T> DOEFFDFKBJN, in U KGJOJGIPNPH)
	{
		return default(global::BDGGOLJBLMC<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x1FBC610", Offset = "0x1FBB210", VA = "0x181FBC610")]
	public static global::BDGGOLJBLMC<(T, U)> OGOONHBBHGP<T, U>(in global::BDGGOLJBLMC<T> FNKIIBFNLFB, in global::BDGGOLJBLMC<U> EDLPJGEPJPK)
	{
		return default(global::BDGGOLJBLMC<(T, U)>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct OCCNDPBMNNC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0")]
	public static OCCNDPBMNNC OIJCCGOAGBB<T>([Optional] string IPEKBMPIEKB, [Optional] string DLGGCCFLDLO, bool CKGPNOKFJDH = false)
	{
		return default(OCCNDPBMNNC);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public readonly struct AKKFKCPKBEF<T> : global::NPLDJALPNAC<T, global::AKKFKCPKBEF<T>.BHKFMHMONHO>, global::IOPLDKDIGGC<T>, global::EPCHNKGLMFP<T, global::AKKFKCPKBEF<T>.BHKFMHMONHO>, IEnumerable<T>, IEnumerable, global::EIKCEKABEEJ<T>, LIEBLJHOMNH
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct BHKFMHMONHO : LIEBLJHOMNH, global::PJBCEPJCBDK<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly T[] KJJBMKIAPLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int NIKGHOOEPAJ;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int NGNMMFPKHGG
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x25EFEE0", Offset = "0x25EEAE0", VA = "0x1825EFEE0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public T IJPBKONCNPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x2872A20", Offset = "0x2871620", VA = "0x182872A20", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x28729D0", Offset = "0x28715D0", VA = "0x1828729D0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x28729D0", Offset = "0x28715D0", VA = "0x1828729D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xA2DA90", Offset = "0xA2C690", VA = "0x180A2DA90")]
		private BHKFMHMONHO(T[] FNGHHBJHDMF, int HIANDEDCLIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2872930", Offset = "0x2871530", VA = "0x182872930")]
		public static BHKFMHMONHO GLGBCEHJPPK(T[] FNGHHBJHDMF)
		{
			return default(BHKFMHMONHO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2872990", Offset = "0x2871590", VA = "0x182872990", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x28729C0", Offset = "0x28715C0", VA = "0x1828729C0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly T[] NLOCKJCDMMH;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int BBJDPOLPLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x25EFEE0", Offset = "0x25EEAE0", VA = "0x1825EFEE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2870D50", Offset = "0x286F950", VA = "0x182870D50", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public T GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2870B10", Offset = "0x286F710", VA = "0x182870B10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x72D470", Offset = "0x72C070", VA = "0x18072D470")]
	internal AKKFKCPKBEF(T[] LBLDONKHBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2870A50", Offset = "0x286F650", VA = "0x182870A50")]
	public static global::AKKFKCPKBEF<T> BPOGOELLAPH()
	{
		return default(global::AKKFKCPKBEF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x2870C50", Offset = "0x286F850", VA = "0x182870C50", Slot = "9")]
	public T FNLBPOMBHHO(int HIANDEDCLIF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2870CB0", Offset = "0x286F8B0", VA = "0x182870CB0", Slot = "6")]
	public BHKFMHMONHO GetEnumerator()
	{
		return default(BHKFMHMONHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2870B50", Offset = "0x286F750", VA = "0x182870B50", Slot = "5")]
	private global::PJBCEPJCBDK<T> FNDBPEHMELG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2870B50", Offset = "0x286F750", VA = "0x182870B50", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2870B50", Offset = "0x286F750", VA = "0x182870B50", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class JMDGDENBHGF
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA6F0", Offset = "0x1FB92F0", VA = "0x181FBA6F0")]
	public static global::AKKFKCPKBEF<T> GLGBCEHJPPK<T>(T[] LBLDONKHBCF)
	{
		return default(global::AKKFKCPKBEF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x1E30CD0", Offset = "0x1E2F8D0", VA = "0x181E30CD0")]
	public static global::AKKFKCPKBEF<T> HAAKMJPOEHA<T>(this T[] FNGHHBJHDMF)
	{
		return default(global::AKKFKCPKBEF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA720", Offset = "0x1FB9320", VA = "0x181FBA720")]
	public static global::AKKFKCPKBEF<T>.BHKFMHMONHO POBMJOJDIDP<T>(this T[] FNGHHBJHDMF)
	{
		return default(global::AKKFKCPKBEF<T>.BHKFMHMONHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x1E30CD0", Offset = "0x1E2F8D0", VA = "0x181E30CD0")]
	public static global::AKKFKCPKBEF<T> PDGGJADACBH<T>(this T[] FNGHHBJHDMF)
	{
		return default(global::AKKFKCPKBEF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct FKDFHJNKBKM<T, U> : global::NPLDJALPNAC<T, U>, global::IOPLDKDIGGC<T>, global::EPCHNKGLMFP<T, U>, IEnumerable<T>, IEnumerable where U : global::PJBCEPJCBDK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly U KHJHHNJNDNE;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x226C420", Offset = "0x226B020", VA = "0x18226C420")]
	internal FKDFHJNKBKM(in U EMOMAAKECJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7C23E0", Offset = "0x7C0FE0", VA = "0x1807C23E0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x28C0580", Offset = "0x28BF180", VA = "0x1828C0580", Slot = "5")]
	private global::PJBCEPJCBDK<T> FNDBPEHMELG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x28C0580", Offset = "0x28BF180", VA = "0x1828C0580", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x28C0580", Offset = "0x28BF180", VA = "0x1828C0580", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class BHIDHGFPDHG<T>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x20CE0C0", Offset = "0x20CCCC0", VA = "0x1820CE0C0")]
	public static global::FKDFHJNKBKM<T, U> GLGBCEHJPPK<U>(in U EMOMAAKECJI) where U : global::PJBCEPJCBDK<T>
	{
		return default(global::FKDFHJNKBKM<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class LDEADAKIAFP<TResult, TResultEnumerator> where TResultEnumerator : global::PJBCEPJCBDK<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x1FBC650", Offset = "0x1FBB250", VA = "0x181FBC650")]
	public static global::BAFGKLJDONP<TSourceEnumerator, TResultEnumerator, TResult> OJLHEHNJLKK<TSourceEnumerator>(in TSourceEnumerator FNGHHBJHDMF) where TSourceEnumerator : IEnumerator<TResultEnumerator>
	{
		return default(global::BAFGKLJDONP<TSourceEnumerator, TResultEnumerator, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct BAFGKLJDONP<TSourceEnumerator, TResultEnumerator, TResult> : global::PJBCEPJCBDK<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : IEnumerator<TResultEnumerator> where TResultEnumerator : global::PJBCEPJCBDK<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private TSourceEnumerator KJJBMKIAPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private TResultEnumerator GBKIGFLIELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool PBOCCPMKDMM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public TResult IJPBKONCNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x2871BB0", Offset = "0x28707B0", VA = "0x182871BB0", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2871B10", Offset = "0x2870710", VA = "0x182871B10", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2871B10", Offset = "0x2870710", VA = "0x182871B10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x2871B60", Offset = "0x2870760", VA = "0x182871B60")]
	internal BAFGKLJDONP(in TSourceEnumerator FNGHHBJHDMF, in TResultEnumerator CKANEDPIGGC, bool EPANACMGKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2871990", Offset = "0x2870590", VA = "0x182871990", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x2871AC0", Offset = "0x28706C0", VA = "0x182871AC0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2871940", Offset = "0x2870540", VA = "0x182871940", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct CDMDGIGOGLE<TSourceEnumerator, TSource, TResult> : LIEBLJHOMNH, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : LIEBLJHOMNH, global::PJBCEPJCBDK<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private TSourceEnumerator KJJBMKIAPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly global::PEJBAIBNPEG<TSource, TResult> MNCNNPPFMKK;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x33C99E0", Offset = "0x33C85E0", VA = "0x1833C99E0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public TResult IJPBKONCNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x33C9F80", Offset = "0x33C8B80", VA = "0x1833C9F80", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x33C9D80", Offset = "0x33C8980", VA = "0x1833C9D80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2A964A0", Offset = "0x2A950A0", VA = "0x182A964A0")]
	internal CDMDGIGOGLE(in TSourceEnumerator FNGHHBJHDMF, global::PEJBAIBNPEG<TSource, TResult> PDGIDFKMLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x33C9700", Offset = "0x33C8300", VA = "0x1833C9700", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x33C9C10", Offset = "0x33C8810", VA = "0x1833C9C10", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x33C9520", Offset = "0x33C8120", VA = "0x1833C9520", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct DOMEHJCLKAL<TSourceEnumerator, TSource, TResultEnumerator, TResult> : global::PJBCEPJCBDK<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : global::PJBCEPJCBDK<TSource> where TResultEnumerator : global::PJBCEPJCBDK<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private TSourceEnumerator KJJBMKIAPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private TResultEnumerator GBKIGFLIELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly global::PEJBAIBNPEG<TSource, TResultEnumerator> MNCNNPPFMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool PBOCCPMKDMM;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TResult IJPBKONCNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3982470", Offset = "0x3981070", VA = "0x183982470", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3982380", Offset = "0x3980F80", VA = "0x183982380", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3982380", Offset = "0x3980F80", VA = "0x183982380", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3982410", Offset = "0x3981010", VA = "0x183982410")]
	internal DOMEHJCLKAL(in TSourceEnumerator FNGHHBJHDMF, in TResultEnumerator CKANEDPIGGC, global::PEJBAIBNPEG<TSource, TResultEnumerator> PDGIDFKMLKH, bool EPANACMGKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x39821A0", Offset = "0x3980DA0", VA = "0x1839821A0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3982330", Offset = "0x3980F30", VA = "0x183982330", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3982150", Offset = "0x3980D50", VA = "0x183982150", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct DBNCKAAGLOJ<TSource1Enumerator, TSource1, TSource2Enumerator, TSource2> : LIEBLJHOMNH, IEnumerator<(TSource1, TSource2)>, IEnumerator, IDisposable where TSource1Enumerator : LIEBLJHOMNH, global::PJBCEPJCBDK<TSource1> where TSource2Enumerator : LIEBLJHOMNH, global::PJBCEPJCBDK<TSource2>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private TSource1Enumerator PCOPPCIBAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private TSource2Enumerator FACAOGLIJMA;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2F5F110", Offset = "0x2F5DD10", VA = "0x182F5F110", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public (TSource1, TSource2) IJPBKONCNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2F5F300", Offset = "0x2F5DF00", VA = "0x182F5F300", Slot = "5")]
		get
		{
			return default((TSource1, TSource2));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2F5F220", Offset = "0x2F5DE20", VA = "0x182F5F220", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2F5F2C0", Offset = "0x2F5DEC0", VA = "0x182F5F2C0")]
	internal DBNCKAAGLOJ(in TSource1Enumerator ALNIOOAPJAD, in TSource2Enumerator DPPFONCALIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2F5F0A0", Offset = "0x2F5DCA0", VA = "0x182F5F0A0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2F5F1B0", Offset = "0x2F5DDB0", VA = "0x182F5F1B0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2F5F040", Offset = "0x2F5DC40", VA = "0x182F5F040", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct NEJNJDCDNEL<T, U> : global::EPCHNKGLMFP<T, U>, IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly U KHJHHNJNDNE;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x28C06E0", Offset = "0x28BF2E0", VA = "0x1828C06E0")]
	internal NEJNJDCDNEL(in U EMOMAAKECJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x28C0560", Offset = "0x28BF160", VA = "0x1828C0560", Slot = "4")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x28C05B0", Offset = "0x28BF1B0", VA = "0x1828C05B0", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x28C05B0", Offset = "0x28BF1B0", VA = "0x1828C05B0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class HLIKLPGKKEP<T>
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x20CE080", Offset = "0x20CCC80", VA = "0x1820CE080")]
	public static global::NEJNJDCDNEL<T, U> GLGBCEHJPPK<U>(in U EMOMAAKECJI) where U : IEnumerator<T>
	{
		return default(global::NEJNJDCDNEL<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct AKOGJHNIHAM<TSourceEnumerator, TSource, TResult> : LIEBLJHOMNH, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : LIEBLJHOMNH, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private TSourceEnumerator KJJBMKIAPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Func<TSource, TResult> MNCNNPPFMKK;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2870E30", Offset = "0x286FA30", VA = "0x182870E30", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public TResult IJPBKONCNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2870F50", Offset = "0x286FB50", VA = "0x182870F50", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2870ED0", Offset = "0x286FAD0", VA = "0x182870ED0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2870F10", Offset = "0x286FB10", VA = "0x182870F10")]
	internal AKOGJHNIHAM(in TSourceEnumerator FNGHHBJHDMF, Func<TSource, TResult> PDGIDFKMLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2870DE0", Offset = "0x286F9E0", VA = "0x182870DE0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2870E80", Offset = "0x286FA80", VA = "0x182870E80", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2870D90", Offset = "0x286F990", VA = "0x182870D90", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class KEHLDMHNDCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x27E6650", Offset = "0x27E5250", VA = "0x1827E6650")]
	public static bool AKOEBDEPDOE<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator FNGHHBJHDMF, in TArgs ALIJPBPLEAE, in global::BFEBAIHNHJM<TArgs, TSource, bool> PCBFDJAIHMO) where TSourceEnumerator : global::PJBCEPJCBDK<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x22D0A40", Offset = "0x22CF640", VA = "0x1822D0A40")]
	public static int EDFPAFHJPNH<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator FNGHHBJHDMF, in TArgs ALIJPBPLEAE, global::BFEBAIHNHJM<TArgs, TSource, bool> PCBFDJAIHMO) where TSourceEnumerator : global::PJBCEPJCBDK<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x27E6570", Offset = "0x27E5170", VA = "0x1827E6570")]
	public static bool AHIHDGHGGKF<TSourceEnumerator, TSource>(this TSourceEnumerator FNGHHBJHDMF, in TSource IGAPBICELKB) where TSourceEnumerator : global::PJBCEPJCBDK<TSource> where TSource : global::AMFKIKPGKDH<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x22D0D30", Offset = "0x22CF930", VA = "0x1822D0D30")]
	public static int NCGGHDOFLNH<TSourceEnumerator, TSource>(this TSourceEnumerator FNGHHBJHDMF, in TSource KGJOJGIPNPH) where TSourceEnumerator : global::PJBCEPJCBDK<TSource> where TSource : global::AMFKIKPGKDH<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x1FBC4E0", Offset = "0x1FBB0E0", VA = "0x181FBC4E0")]
	public static global::CDMDGIGOGLE<TSourceEnumerator, TSource, TResult> AIGPPCKJFMA<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator FNGHHBJHDMF, global::PEJBAIBNPEG<TSource, TResult> PDGIDFKMLKH) where TSourceEnumerator : LIEBLJHOMNH, global::PJBCEPJCBDK<TSource>
	{
		return default(global::CDMDGIGOGLE<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x1FBC530", Offset = "0x1FBB130", VA = "0x181FBC530")]
	public static global::AKOGJHNIHAM<TSourceEnumerator, TSource, TResult> FOEEDNLPFDN<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator FNGHHBJHDMF, Func<TSource, TResult> PDGIDFKMLKH) where TSourceEnumerator : LIEBLJHOMNH, IEnumerator<TSource>
	{
		return default(global::AKOGJHNIHAM<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class NJKKEGOAENF<T>
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x27EC930", Offset = "0x27EB530", VA = "0x1827EC930")]
	public static bool AAHIBAANGKI<TSourceEnumerator>(TSourceEnumerator FNGHHBJHDMF) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x1E33BD0", Offset = "0x1E327D0", VA = "0x181E33BD0")]
	public static T FNOMAEPMHKB<TSourceEnumerator>(TSourceEnumerator FNGHHBJHDMF) where TSourceEnumerator : global::PJBCEPJCBDK<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x1FBCB90", Offset = "0x1FBB790", VA = "0x181FBCB90")]
	public static global::DOMEHJCLKAL<TSourceEnumerator, TSource, TResultEnumerator, T> GPNLLFKPBKI<TSourceEnumerator, TSource, TResultEnumerator>(in TSourceEnumerator FNGHHBJHDMF, global::PEJBAIBNPEG<TSource, TResultEnumerator> PDGIDFKMLKH) where TSourceEnumerator : global::PJBCEPJCBDK<TSource> where TResultEnumerator : global::PJBCEPJCBDK<T>
	{
		return default(global::DOMEHJCLKAL<TSourceEnumerator, TSource, TResultEnumerator, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2145040", Offset = "0x2143C40", VA = "0x182145040")]
	public static string OCDOKDMCJKI<TSourceEnumerator>(TSourceEnumerator FNGHHBJHDMF) where TSourceEnumerator : IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2BD6EA0", Offset = "0x2BD5AA0", VA = "0x182BD6EA0")]
	public static T[] GFAKIILDDNB<TSourceEnumerator>(TSourceEnumerator FNGHHBJHDMF) where TSourceEnumerator : LIEBLJHOMNH, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x2029180", Offset = "0x2027D80", VA = "0x182029180")]
	public static T JOBIDDGMBNA<TSourceEnumerator>(TSourceEnumerator FNGHHBJHDMF) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x27ECA60", Offset = "0x27EB660", VA = "0x1827ECA60")]
	public static bool NEJJIHLCNPJ<TSourceEnumerator>(TSourceEnumerator FNGHHBJHDMF) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class PBBHJMGGIOF<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD260", Offset = "0x1FBBE60", VA = "0x181FBD260")]
	public static global::DBNCKAAGLOJ<TSource1Enumerator, T, TSource2Enumerator, U> IPPBEEJNCMN<TSource1Enumerator, TSource2Enumerator>(in TSource1Enumerator ALNIOOAPJAD, in TSource2Enumerator DPPFONCALIF) where TSource1Enumerator : LIEBLJHOMNH, global::PJBCEPJCBDK<T> where TSource2Enumerator : LIEBLJHOMNH, global::PJBCEPJCBDK<U>
	{
		return default(global::DBNCKAAGLOJ<TSource1Enumerator, T, TSource2Enumerator, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface IOPLDKDIGGC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::PJBCEPJCBDK<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface NPLDJALPNAC<T, TEnumerator> : global::IOPLDKDIGGC<T>, global::EPCHNKGLMFP<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::PJBCEPJCBDK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface PJBCEPJCBDK<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T IJPBKONCNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface EIKCEKABEEJ<T> : LIEBLJHOMNH
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T FNLBPOMBHHO(int JNJLPHNJHIN);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface EPCHNKGLMFP<T, TEnumerator> : IEnumerable<T>, IEnumerable where TEnumerator : IEnumerator<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface LIEBLJHOMNH
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface AMFKIKPGKDH<T>
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HDEAJIPIIDL(in T NPKIIGGBCCI);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface HPIMHAGOMMH<T>
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::KJAADGLJOHG<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface IPAEEKBEOBE<T, TEnumerator> : global::HPIMHAGOMMH<T>, global::NPLDJALPNAC<T, TEnumerator>, global::IOPLDKDIGGC<T>, global::EPCHNKGLMFP<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::KJAADGLJOHG<T>
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface KJAADGLJOHG<T> : global::PJBCEPJCBDK<T>, IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	new T IJPBKONCNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public delegate void GFMNHONHNLF<T>(in T NFEIKMHMJPL);
[Cpp2IlInjected.Token(Token = "0x200004A")]
public delegate void CJLAACNCIDH<T1, T2>(in T1 LMIOPPEOHDG, in T2 KCFMNFENJOE);
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class MOMJEDKJAOH
{
	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x27E9080", Offset = "0x27E7C80", VA = "0x1827E9080")]
	public static bool OJLLEDLILAD<T, U>(this T FNGHHBJHDMF, in U EBMPLNBFAKM) where T : global::AMFKIKPGKDH<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public delegate TResult PEJBAIBNPEG<T, out TResult>(in T NFEIKMHMJPL);
[Cpp2IlInjected.Token(Token = "0x200004D")]
public delegate TResult BFEBAIHNHJM<T1, T2, out TResult>(in T1 LMIOPPEOHDG, in T2 KCFMNFENJOE);
[Cpp2IlInjected.Token(Token = "0x200004E")]
public delegate TResult GFMJKNDAMCE<T1, T2, T3, out TResult>(in T1 LMIOPPEOHDG, in T2 KCFMNFENJOE, in T3 DGAILNALKAC);
[Cpp2IlInjected.Token(Token = "0x200004F")]
public delegate TResult NLLGKDBLABC<T1, T2, T3, T4, out TResult>(in T1 LMIOPPEOHDG, in T2 KCFMNFENJOE, in T3 DGAILNALKAC, in T4 NNNIFDDLGGL);
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate TResult KBBIJPALCOA<T1, T2, T3, T4, T5, out TResult>(in T1 LMIOPPEOHDG, in T2 KCFMNFENJOE, in T3 DGAILNALKAC, in T4 NNNIFDDLGGL, in T5 FLFGAIIMPOP);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate TResult CIBKBKDJKFJ<T, TResult>(in T NFEIKMHMJPL);
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate TResult GIGLNHIACJH<T1, T2, TResult>(in T1 LMIOPPEOHDG, in T2 KCFMNFENJOE);
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate TResult AFMDCAMJLOG<T1, T2, T3, TResult>(in T1 LMIOPPEOHDG, in T2 KCFMNFENJOE, in T3 DGAILNALKAC);
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DefaultMember("Item")]
public struct LPCKCPBBOLA<T> : global::IPAEEKBEOBE<T, global::LPCKCPBBOLA<T>.NLHLOIJJEHA>, global::HPIMHAGOMMH<T>, global::NPLDJALPNAC<T, global::LPCKCPBBOLA<T>.NLHLOIJJEHA>, global::IOPLDKDIGGC<T>, global::EPCHNKGLMFP<T, global::LPCKCPBBOLA<T>.NLHLOIJJEHA>, IEnumerable<T>, IEnumerable, global::EIKCEKABEEJ<T>, LIEBLJHOMNH
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct NLHLOIJJEHA : LIEBLJHOMNH, global::KJAADGLJOHG<T>, global::PJBCEPJCBDK<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private T[] KJJBMKIAPLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int NIKGHOOEPAJ;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int NGNMMFPKHGG
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x25EFEE0", Offset = "0x25EEAE0", VA = "0x1825EFEE0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public T IJPBKONCNPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x2872A20", Offset = "0x2871620", VA = "0x182872A20", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		private T BMLCBKEIGEF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x36F3BC0", Offset = "0x36F27C0", VA = "0x1836F3BC0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x28729D0", Offset = "0x28715D0", VA = "0x1828729D0", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x28729D0", Offset = "0x28715D0", VA = "0x1828729D0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA2DA90", Offset = "0xA2C690", VA = "0x180A2DA90")]
		private NLHLOIJJEHA(T[] FNGHHBJHDMF, int HIANDEDCLIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x2872930", Offset = "0x2871530", VA = "0x182872930")]
		public static NLHLOIJJEHA GLGBCEHJPPK(T[] FNGHHBJHDMF)
		{
			return default(NLHLOIJJEHA);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2872990", Offset = "0x2871590", VA = "0x182872990", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x28729C0", Offset = "0x28715C0", VA = "0x1828729C0", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private T[] NLOCKJCDMMH;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public int BBJDPOLPLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x25EFEE0", Offset = "0x25EEAE0", VA = "0x1825EFEE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2870D50", Offset = "0x286F950", VA = "0x182870D50", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public T GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2870B10", Offset = "0x286F710", VA = "0x182870B10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x72D470", Offset = "0x72C070", VA = "0x18072D470")]
	internal LPCKCPBBOLA(T[] LBLDONKHBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2870A50", Offset = "0x286F650", VA = "0x182870A50")]
	public static global::LPCKCPBBOLA<T> BPOGOELLAPH()
	{
		return default(global::LPCKCPBBOLA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2870C50", Offset = "0x286F850", VA = "0x182870C50", Slot = "11")]
	public T FNLBPOMBHHO(int HIANDEDCLIF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x36E8790", Offset = "0x36E7390", VA = "0x1836E8790")]
	public global::AKKFKCPKBEF<T> AMHJFFLCDME()
	{
		return default(global::AKKFKCPKBEF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x36E8910", Offset = "0x36E7510", VA = "0x1836E8910", Slot = "8")]
	public NLHLOIJJEHA GetEnumerator()
	{
		return default(NLHLOIJJEHA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x36E8810", Offset = "0x36E7410", VA = "0x1836E8810", Slot = "5")]
	private global::KJAADGLJOHG<T> EBDLCIIHKAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x36E8810", Offset = "0x36E7410", VA = "0x1836E8810", Slot = "7")]
	private global::PJBCEPJCBDK<T> FNDBPEHMELG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x36E8810", Offset = "0x36E7410", VA = "0x1836E8810", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x36E8810", Offset = "0x36E7410", VA = "0x1836E8810", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class JHKMCHJKHAD
{
	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA6F0", Offset = "0x1FB92F0", VA = "0x181FBA6F0")]
	public static global::LPCKCPBBOLA<T> GLGBCEHJPPK<T>(T[] LBLDONKHBCF)
	{
		return default(global::LPCKCPBBOLA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1E30CD0", Offset = "0x1E2F8D0", VA = "0x181E30CD0")]
	public static global::LPCKCPBBOLA<T> GPBHEOOMPFJ<T>(this T[] FNGHHBJHDMF)
	{
		return default(global::LPCKCPBBOLA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA720", Offset = "0x1FB9320", VA = "0x181FBA720")]
	public static global::LPCKCPBBOLA<T>.NLHLOIJJEHA OLFOEIJJCCD<T>(this T[] FNGHHBJHDMF)
	{
		return default(global::LPCKCPBBOLA<T>.NLHLOIJJEHA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x1E30CD0", Offset = "0x1E2F8D0", VA = "0x181E30CD0")]
	public static global::LPCKCPBBOLA<T> DHGOGACOAHH<T>(this T[] FNGHHBJHDMF)
	{
		return default(global::LPCKCPBBOLA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct NGKMKHIINNB<T, U> : global::IPAEEKBEOBE<T, U>, global::HPIMHAGOMMH<T>, global::NPLDJALPNAC<T, U>, global::IOPLDKDIGGC<T>, global::EPCHNKGLMFP<T, U>, IEnumerable<T>, IEnumerable where U : global::KJAADGLJOHG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly U KHJHHNJNDNE;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x226C420", Offset = "0x226B020", VA = "0x18226C420")]
	internal NGKMKHIINNB(in U EMOMAAKECJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7C23E0", Offset = "0x7C0FE0", VA = "0x1807C23E0", Slot = "8")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x28C0580", Offset = "0x28BF180", VA = "0x1828C0580", Slot = "5")]
	private global::KJAADGLJOHG<T> EBDLCIIHKAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x28C0580", Offset = "0x28BF180", VA = "0x1828C0580", Slot = "7")]
	private global::PJBCEPJCBDK<T> FNDBPEHMELG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x28C0580", Offset = "0x28BF180", VA = "0x1828C0580", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x28C0580", Offset = "0x28BF180", VA = "0x1828C0580", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class ICIHACMNABA<T>
{
	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x20CE0C0", Offset = "0x20CCCC0", VA = "0x1820CE0C0")]
	public static global::NGKMKHIINNB<T, U> GLGBCEHJPPK<U>(in U EMOMAAKECJI) where U : global::KJAADGLJOHG<T>
	{
		return default(global::NGKMKHIINNB<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DefaultMember("Item")]
public class JJJABBILFGO<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly Func<Internal, External> IGPHAIGDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly Func<External, Internal> IHHPOLINCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private IList<Internal> FPPBJGHNMLI;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public IList<Internal> LGNNPJFJLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDF0", Offset = "0x5ED9F0", VA = "0x1805EEDF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x616D70", Offset = "0x615970", VA = "0x180616D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool IDIBHBMOFCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x66D990", Offset = "0x66C590", VA = "0x18066D990", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA3B180", Offset = "0xA39D80", VA = "0x180A3B180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public External GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3667FB0", Offset = "0x3666BB0", VA = "0x183667FB0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3668050", Offset = "0x3666C50", VA = "0x183668050", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3667F50", Offset = "0x3666B50", VA = "0x183667F50", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3667EC0", Offset = "0x3666AC0", VA = "0x183667EC0")]
	public JJJABBILFGO(Func<Internal, External> IGPHAIGDIDM, Func<External, Internal> IHHPOLINCOO, bool CBJFFCIPOCL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x3667BD0", Offset = "0x36667D0", VA = "0x183667BD0", Slot = "6")]
	public int IndexOf(External IGAPBICELKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x36677A0", Offset = "0x36663A0", VA = "0x1836677A0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x3667850", Offset = "0x3666450", VA = "0x183667850", Slot = "13")]
	public bool Contains(External IGAPBICELKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x36678E0", Offset = "0x36664E0", VA = "0x1836678E0", Slot = "14")]
	public void CopyTo(External[] LBLDONKHBCF, int BPPENCELOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x36676B0", Offset = "0x36662B0", VA = "0x1836676B0", Slot = "11")]
	public void Add(External IGAPBICELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x3667CC0", Offset = "0x36668C0", VA = "0x183667CC0", Slot = "7")]
	public void Insert(int HIANDEDCLIF, External IGAPBICELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x3667E30", Offset = "0x3666A30", VA = "0x183667E30", Slot = "15")]
	public bool Remove(External IGAPBICELKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x3667D60", Offset = "0x3666960", VA = "0x183667D60", Slot = "8")]
	public void RemoveAt(int HIANDEDCLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x3667B00", Offset = "0x3666700", VA = "0x183667B00", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x1FCE600", Offset = "0x1FCD200", VA = "0x181FCE600", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[DefaultMember("Item")]
public class LALHOBNHAPE<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Func<Internal, External> IGPHAIGDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private IReadOnlyList<Internal> FPPBJGHNMLI;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public IReadOnlyList<Internal> LGNNPJFJLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4A0", Offset = "0x5EB0A0", VA = "0x1805EC4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool IDIBHBMOFCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFE0", Offset = "0x5EBBE0", VA = "0x1805ECFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public External GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x453D060", Offset = "0x453BC60", VA = "0x18453D060", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x453D000", Offset = "0x453BC00", VA = "0x18453D000", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2265A90", Offset = "0x2264690", VA = "0x182265A90")]
	public LALHOBNHAPE(Func<Internal, External> IGPHAIGDIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x453CFB0", Offset = "0x453BBB0", VA = "0x18453CFB0")]
	public LALHOBNHAPE(IReadOnlyList<Internal> FPPBJGHNMLI, Func<Internal, External> IGPHAIGDIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x453CD90", Offset = "0x453B990", VA = "0x18453CD90")]
	public void PLJCJKLBIDG(External[] LBLDONKHBCF, int BPPENCELOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x453CD20", Offset = "0x453B920", VA = "0x18453CD20", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x1EAA690", Offset = "0x1EA9290", VA = "0x181EAA690", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[DefaultMember("Item")]
public class NCFLPPGBGFG<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private IReadOnlyList<Internal> FPPBJGHNMLI;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public IReadOnlyList<Internal> LGNNPJFJLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5EC490", Offset = "0x5EB090", VA = "0x1805EC490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool IDIBHBMOFCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFE0", Offset = "0x5EBBE0", VA = "0x1805ECFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public External GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x28BDEF0", Offset = "0x28BCAF0", VA = "0x1828BDEF0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x28BDE90", Offset = "0x28BCA90", VA = "0x1828BDE90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2265A90", Offset = "0x2264690", VA = "0x182265A90")]
	public NCFLPPGBGFG(IReadOnlyList<Internal> FPPBJGHNMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x28BDB50", Offset = "0x28BC750", VA = "0x1828BDB50")]
	public bool ACOKKIFAPKJ(External IGAPBICELKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x28BDC60", Offset = "0x28BC860", VA = "0x1828BDC60")]
	public void PLJCJKLBIDG(External[] LBLDONKHBCF, int BPPENCELOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x28BDBF0", Offset = "0x28BC7F0", VA = "0x1828BDBF0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x1FCE600", Offset = "0x1FCD200", VA = "0x181FCE600", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class FKLHAICPPMP
{
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void CBILEIFKMED(object[] ALIJPBPLEAE);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	protected FKLHAICPPMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class KGHJNJDIMKJ<T> : FKLHAICPPMP
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	protected struct FAJLNJEEJOM
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public enum DDMNHAJIOJC
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
		public DDMNHAJIOJC LIJLAEFJGCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public T KINCGCMCJLI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int PIOEPFHPHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly bool LEEFBJJDFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	protected readonly bool MCFGFOBADDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	protected List<T> LBIPEEJKOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private List<FAJLNJEEJOM> BDCOIBHEIAM;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool FOINPNMKDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3EE9B90", Offset = "0x3EE8790", VA = "0x183EE9B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3EE9BD0", Offset = "0x3EE87D0", VA = "0x183EE9BD0")]
	protected KGHJNJDIMKJ(bool MCFGFOBADDO, bool LEEFBJJDFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3EE9AF0", Offset = "0x3EE86F0", VA = "0x183EE9AF0")]
	protected bool PKPKBGGLOBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3EE9600", Offset = "0x3EE8200", VA = "0x183EE9600")]
	protected void JLFFINOHOGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3EE9450", Offset = "0x3EE8050", VA = "0x183EE9450")]
	protected void BFHMDHFOFHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x2D45AD0", Offset = "0x2D446D0", VA = "0x182D45AD0")]
	private static void DDAIAJJNBHJ<U>(ref List<U> FPPBJGHNMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3EE9840", Offset = "0x3EE8440", VA = "0x183EE9840", Slot = "5")]
	public void LFMPFEAFMAL(T KINCGCMCJLI, bool HCGGBGPNKOF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3EE96E0", Offset = "0x3EE82E0", VA = "0x183EE96E0", Slot = "6")]
	public void JNIHJKFEBJI(T KINCGCMCJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3EE99C0", Offset = "0x3EE85C0", VA = "0x183EE99C0")]
	public void LONCNHKPMCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface PGPHCPEEFBB
{
	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFMPFEAFMAL(Action KINCGCMCJLI, bool HCGGBGPNKOF = false);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNIHJKFEBJI(Action KINCGCMCJLI);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public sealed class DJNHHHNCJAC : global::KGHJNJDIMKJ<Action>, PGPHCPEEFBB
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x578E980", Offset = "0x578D580", VA = "0x18578E980")]
	public DJNHHHNCJAC(bool MCFGFOBADDO = false, bool LEEFBJJDFED = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x578E680", Offset = "0x578D280", VA = "0x18578E680")]
	public void BEBMDLKMKEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x578E840", Offset = "0x578D440", VA = "0x18578E840", Slot = "4")]
	public override void CBILEIFKMED(object[] ALIJPBPLEAE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x578E920", Offset = "0x578D520", VA = "0x18578E920")]
	public static DJNHHHNCJAC FKFPNHOAGME(DJNHHHNCJAC DELANOBNBLI, Action KINCGCMCJLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x578E8C0", Offset = "0x578D4C0", VA = "0x18578E8C0")]
	public static DJNHHHNCJAC CKPHDFNGGOG(DJNHHHNCJAC DELANOBNBLI, Action KINCGCMCJLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface PICKLJIOBKD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFMPFEAFMAL(Action<T> KINCGCMCJLI, bool HCGGBGPNKOF = false);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNIHJKFEBJI(Action<T> KINCGCMCJLI);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public sealed class GDHOEMDADGP<T> : global::KGHJNJDIMKJ<Action<T>>, global::PICKLJIOBKD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x2275400", Offset = "0x2274000", VA = "0x182275400")]
	public GDHOEMDADGP(bool MCFGFOBADDO = false, bool LEEFBJJDFED = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x29AB330", Offset = "0x29A9F30", VA = "0x1829AB330")]
	public void BEBMDLKMKEA(T LDKDBEMBOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x29ACEA0", Offset = "0x29ABAA0", VA = "0x1829ACEA0", Slot = "4")]
	public override void CBILEIFKMED(object[] ALIJPBPLEAE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x29AD6E0", Offset = "0x29AC2E0", VA = "0x1829AD6E0")]
	public static global::GDHOEMDADGP<T> FKFPNHOAGME(global::GDHOEMDADGP<T> DELANOBNBLI, Action<T> KINCGCMCJLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x29AD640", Offset = "0x29AC240", VA = "0x1829AD640")]
	public static global::GDHOEMDADGP<T> CKPHDFNGGOG(global::GDHOEMDADGP<T> DELANOBNBLI, Action<T> KINCGCMCJLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface BDDCHJJHJDF<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFMPFEAFMAL(Action<T, U> KINCGCMCJLI, bool HCGGBGPNKOF = false);

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNIHJKFEBJI(Action<T, U> KINCGCMCJLI);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public sealed class GPFDHKIFHJO<T, U> : global::KGHJNJDIMKJ<Action<T, U>>, global::BDDCHJJHJDF<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2275400", Offset = "0x2274000", VA = "0x182275400")]
	public GPFDHKIFHJO(bool MCFGFOBADDO = false, bool LEEFBJJDFED = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x22725D0", Offset = "0x22711D0", VA = "0x1822725D0")]
	public void BEBMDLKMKEA(T LDKDBEMBOCB, U GDDOOGGEKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x22745A0", Offset = "0x22731A0", VA = "0x1822745A0", Slot = "4")]
	public override void CBILEIFKMED(object[] ALIJPBPLEAE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2275360", Offset = "0x2273F60", VA = "0x182275360")]
	public static global::GPFDHKIFHJO<T, U> FKFPNHOAGME(global::GPFDHKIFHJO<T, U> DELANOBNBLI, Action<T, U> KINCGCMCJLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x22752C0", Offset = "0x2273EC0", VA = "0x1822752C0")]
	public static global::GPFDHKIFHJO<T, U> CKPHDFNGGOG(global::GPFDHKIFHJO<T, U> DELANOBNBLI, Action<T, U> KINCGCMCJLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface HGPNLNJEPHC<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFMPFEAFMAL(Action<T, U, V> KINCGCMCJLI, bool HCGGBGPNKOF = false);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNIHJKFEBJI(Action<T, U, V> KINCGCMCJLI);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public sealed class EMIDECPHJND<T, U, V> : global::KGHJNJDIMKJ<Action<T, U, V>>, global::HGPNLNJEPHC<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x2275400", Offset = "0x2274000", VA = "0x182275400")]
	public EMIDECPHJND(bool MCFGFOBADDO = false, bool LEEFBJJDFED = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x36CAE00", Offset = "0x36C9A00", VA = "0x1836CAE00")]
	public void BEBMDLKMKEA(T LDKDBEMBOCB, U GDDOOGGEKFM, V BMIMFPIIMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x36CD330", Offset = "0x36CBF30", VA = "0x1836CD330", Slot = "4")]
	public override void CBILEIFKMED(object[] ALIJPBPLEAE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x36CD630", Offset = "0x36CC230", VA = "0x1836CD630")]
	public static global::EMIDECPHJND<T, U, V> FKFPNHOAGME(global::EMIDECPHJND<T, U, V> DELANOBNBLI, Action<T, U, V> KINCGCMCJLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x36CD590", Offset = "0x36CC190", VA = "0x1836CD590")]
	public static global::EMIDECPHJND<T, U, V> CKPHDFNGGOG(global::EMIDECPHJND<T, U, V> DELANOBNBLI, Action<T, U, V> KINCGCMCJLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface OCOELFGBBJM<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFMPFEAFMAL(Action<T, U, V, W> KINCGCMCJLI, bool HCGGBGPNKOF = false);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNIHJKFEBJI(Action<T, U, V, W> KINCGCMCJLI);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public sealed class CMHFCLABCLA<T, U, V, W> : global::KGHJNJDIMKJ<Action<T, U, V, W>>, global::OCOELFGBBJM<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x2275400", Offset = "0x2274000", VA = "0x182275400")]
	public CMHFCLABCLA(bool MCFGFOBADDO = false, bool LEEFBJJDFED = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x2A5CB40", Offset = "0x2A5B740", VA = "0x182A5CB40")]
	public void BEBMDLKMKEA(T LDKDBEMBOCB, U GDDOOGGEKFM, V BMIMFPIIMDL, W LLGIACMDDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E540", Offset = "0x2A5D140", VA = "0x182A5E540", Slot = "4")]
	public override void CBILEIFKMED(object[] ALIJPBPLEAE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x2A5ED70", Offset = "0x2A5D970", VA = "0x182A5ED70")]
	public static global::CMHFCLABCLA<T, U, V, W> FKFPNHOAGME(global::CMHFCLABCLA<T, U, V, W> DELANOBNBLI, Action<T, U, V, W> KINCGCMCJLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2A5ECD0", Offset = "0x2A5D8D0", VA = "0x182A5ECD0")]
	public static global::CMHFCLABCLA<T, U, V, W> CKPHDFNGGOG(global::CMHFCLABCLA<T, U, V, W> DELANOBNBLI, Action<T, U, V, W> KINCGCMCJLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface FBCJBPJAFGO<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFMPFEAFMAL(Action<T, U, V, W, X> KINCGCMCJLI, bool HCGGBGPNKOF = false);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNIHJKFEBJI(Action<T, U, V, W, X> KINCGCMCJLI);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public sealed class POBGACLEKKL<T, U, V, W, X> : global::KGHJNJDIMKJ<Action<T, U, V, W, X>>, global::FBCJBPJAFGO<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2275400", Offset = "0x2274000", VA = "0x182275400")]
	public POBGACLEKKL(bool MCFGFOBADDO = false, bool LEEFBJJDFED = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x22E5C10", Offset = "0x22E4810", VA = "0x1822E5C10")]
	public void BEBMDLKMKEA(T LDKDBEMBOCB, U GDDOOGGEKFM, V BMIMFPIIMDL, W LLGIACMDDKP, X FEMNKHHBNAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x22E5EB0", Offset = "0x22E4AB0", VA = "0x1822E5EB0", Slot = "4")]
	public override void CBILEIFKMED(object[] ALIJPBPLEAE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x22E6560", Offset = "0x22E5160", VA = "0x1822E6560")]
	public static global::POBGACLEKKL<T, U, V, W, X> FKFPNHOAGME(global::POBGACLEKKL<T, U, V, W, X> DELANOBNBLI, Action<T, U, V, W, X> KINCGCMCJLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x22E64C0", Offset = "0x22E50C0", VA = "0x1822E64C0")]
	public static global::POBGACLEKKL<T, U, V, W, X> CKPHDFNGGOG(global::POBGACLEKKL<T, U, V, W, X> DELANOBNBLI, Action<T, U, V, W, X> KINCGCMCJLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface DLHKJMNAPDH<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFMPFEAFMAL(Action<T, U, V, W, X, Y> KINCGCMCJLI, bool HCGGBGPNKOF = false);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNIHJKFEBJI(Action<T, U, V, W, X, Y> KINCGCMCJLI);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public sealed class OHEGBHOKCLB<T, U, V, W, X, Y> : global::KGHJNJDIMKJ<Action<T, U, V, W, X, Y>>, global::DLHKJMNAPDH<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2275400", Offset = "0x2274000", VA = "0x182275400")]
	public OHEGBHOKCLB(bool MCFGFOBADDO = false, bool LEEFBJJDFED = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2627180", Offset = "0x2625D80", VA = "0x182627180")]
	public void BEBMDLKMKEA(T LDKDBEMBOCB, U GDDOOGGEKFM, V BMIMFPIIMDL, W LLGIACMDDKP, X FEMNKHHBNAG, Y FAKOIENNMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2627D80", Offset = "0x2626980", VA = "0x182627D80", Slot = "4")]
	public override void CBILEIFKMED(object[] ALIJPBPLEAE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x26284B0", Offset = "0x26270B0", VA = "0x1826284B0")]
	public static global::OHEGBHOKCLB<T, U, V, W, X, Y> FKFPNHOAGME(global::OHEGBHOKCLB<T, U, V, W, X, Y> DELANOBNBLI, Action<T, U, V, W, X, Y> KINCGCMCJLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2628410", Offset = "0x2627010", VA = "0x182628410")]
	public static global::OHEGBHOKCLB<T, U, V, W, X, Y> CKPHDFNGGOG(global::OHEGBHOKCLB<T, U, V, W, X, Y> DELANOBNBLI, Action<T, U, V, W, X, Y> KINCGCMCJLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public sealed class LOIPHPGNAKK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct IEPAHDPNCFK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly global::LOIPHPGNAKK<T> PBPEOKJHOMG;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public T ONGHMHAEIAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x36E3C00", Offset = "0x36E2800", VA = "0x1836E3C00")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x36E3BD0", Offset = "0x36E27D0", VA = "0x1836E3BD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x72D470", Offset = "0x72C070", VA = "0x18072D470")]
		public IEPAHDPNCFK(global::LOIPHPGNAKK<T> PBPEOKJHOMG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct HEKAKMAKHLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder<IEPAHDPNCFK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::LOIPHPGNAKK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x36E3830", Offset = "0x36E2430", VA = "0x1836E3830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x2A77DA0", Offset = "0x2A769A0", VA = "0x182A77DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct NJGAMOECCNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public AsyncTaskMethodBuilder<IEPAHDPNCFK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public global::LOIPHPGNAKK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x36F3820", Offset = "0x36F2420", VA = "0x1836F3820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2A77DA0", Offset = "0x2A769A0", VA = "0x182A77DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly SemaphoreSlim GEILOGOCHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private T NMAALHOKDMG;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int LEBLCPHMAAF
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x36E7FC0", Offset = "0x36E6BC0", VA = "0x1836E7FC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x36E8650", Offset = "0x36E7250", VA = "0x1836E8650")]
	public LOIPHPGNAKK(in T NMAALHOKDMG, int NEKOBKACFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x36E8620", Offset = "0x36E7220", VA = "0x1836E8620")]
	public LOIPHPGNAKK(in T NMAALHOKDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x36E7FE0", Offset = "0x36E6BE0", VA = "0x1836E7FE0")]
	public IEPAHDPNCFK LIMNAADDJBF()
	{
		return default(IEPAHDPNCFK);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x36E8020", Offset = "0x36E6C20", VA = "0x1836E8020")]
	public IEPAHDPNCFK LIMNAADDJBF(CancellationToken DHCIMDILIGO)
	{
		return default(IEPAHDPNCFK);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x36E81E0", Offset = "0x36E6DE0", VA = "0x1836E81E0")]
	[AsyncStateMachine(typeof(global::LOIPHPGNAKK<>.HEKAKMAKHLM))]
	public Task<IEPAHDPNCFK> OKOGFEOKNDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x36E8340", Offset = "0x36E6F40", VA = "0x1836E8340")]
	[AsyncStateMachine(typeof(global::LOIPHPGNAKK<>.NJGAMOECCNP))]
	public Task<IEPAHDPNCFK> OKOGFEOKNDG(CancellationToken DHCIMDILIGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class NIBNFHAKOMA
{
	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5793240", Offset = "0x5791E40", VA = "0x185793240")]
	public static global::LOIPHPGNAKK<CLMGAOKFIAE> GLGBCEHJPPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x57931D0", Offset = "0x5791DD0", VA = "0x1857931D0")]
	public static global::LOIPHPGNAKK<CLMGAOKFIAE> GLGBCEHJPPK(int NEKOBKACFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x1E38E00", Offset = "0x1E37A00", VA = "0x181E38E00")]
	public static global::LOIPHPGNAKK<T> GLGBCEHJPPK<T>(in T NMAALHOKDMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8EA0", Offset = "0x1FB7AA0", VA = "0x181FB8EA0")]
	public static global::LOIPHPGNAKK<T> GLGBCEHJPPK<T>(in T NMAALHOKDMG, int NEKOBKACFGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class MJGHCDCGIBB<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public delegate Task<TResult> IJDEDJIFIFN(TRequest IMIDEOCLBEC, CancellationToken DHCIMDILIGO);

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public enum ENLPGKPFOBF
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class KACENCNMNFG
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private const float KKHLJNADMMK = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private TimeSpan HDBLCIMJNKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public int GENPJMAFIDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public ENLPGKPFOBF CKEHHJKHEGJ;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public static readonly KACENCNMNFG KEBFNIGMDAM;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public float OCMAPOILAJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B540", Offset = "0x2A1A140", VA = "0x182A1B540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public TimeSpan CPGPKMKJMCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2A1B620", Offset = "0x2A1A220", VA = "0x182A1B620")]
		public KACENCNMNFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private readonly struct LBANMLMKPMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public readonly TRequest IMIDEOCLBEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public readonly CancellationToken DHCIMDILIGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public readonly TaskCompletionSource<TResult> HPGKPOHFJPC;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2A1B880", Offset = "0x2A1A480", VA = "0x182A1B880")]
		public LBANMLMKPMG(TRequest IMIDEOCLBEC, TaskCompletionSource<TResult> HPGKPOHFJPC, CancellationToken DHCIMDILIGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class CGEMNENKADN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		public CGEMNENKADN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2777150", Offset = "0x2775D50", VA = "0x182777150")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct HBNKNEEBJIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public global::MJGHCDCGIBB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x2A18E20", Offset = "0x2A17A20", VA = "0x182A18E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct AJPNAAAKCJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public global::MJGHCDCGIBB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private LBANMLMKPMG <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2A177B0", Offset = "0x2A163B0", VA = "0x182A177B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly CancellationTokenSource JJNKCEICOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly List<LBANMLMKPMG> GAPCBMDLOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly KACENCNMNFG KGDFAHJKAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly IJDEDJIFIFN FMPJENLBJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Task HLDOBEIPNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int AKNAPPPDJLG;

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2A1DC00", Offset = "0x2A1C800", VA = "0x182A1DC00")]
	public MJGHCDCGIBB(IJDEDJIFIFN FMPJENLBJPG, [Optional] KACENCNMNFG KGDFAHJKAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2A1CD00", Offset = "0x2A1B900", VA = "0x182A1CD00")]
	public Task<TResult> IIJLHLINNML(TRequest IMIDEOCLBEC, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x2A1CF60", Offset = "0x2A1BB60", VA = "0x182A1CF60")]
	private void MGAGHKCMNGN(LBANMLMKPMG FPNKALHPAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C500", Offset = "0x2A1B100", VA = "0x182A1C500")]
	[AsyncStateMachine(typeof(global::MJGHCDCGIBB<, >.HBNKNEEBJIN))]
	private Task HLFMEICMHII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x2A1D130", Offset = "0x2A1BD30", VA = "0x182A1D130")]
	private LBANMLMKPMG NLPLPJPDFOH()
	{
		return default(LBANMLMKPMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x2A1DAD0", Offset = "0x2A1C6D0", VA = "0x182A1DAD0")]
	[AsyncStateMachine(typeof(global::MJGHCDCGIBB<, >.AJPNAAAKCJN))]
	private Task PLAJOJIIOKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C320", Offset = "0x2A1AF20", VA = "0x182A1C320")]
	private void DHDKHFPDKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C4C0", Offset = "0x2A1B0C0", VA = "0x182A1C4C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class HDBFOPOINKD<TKey, TVal> : global::NLJENLIBGCG<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int ICLHLHIJENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	internal Dictionary<TKey, (TVal value, int size)> CLCCCELKFJI;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	internal override int ABAJKMDGLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x3883DA0", Offset = "0x38829A0", VA = "0x183883DA0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	internal int OAKFEAMOEJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x38836F0", Offset = "0x38822F0", VA = "0x1838836F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public override int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x3883D40", Offset = "0x3882940", VA = "0x183883D40", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x3883DD0", Offset = "0x38829D0", VA = "0x183883DD0")]
	public HDBFOPOINKD(int LAODCMGHKOP, [Optional] BOLNJJOLBGO PLEKBFIEFKC, [Optional] IEqualityComparer<TKey> IKLBJIBPDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x3883B80", Offset = "0x3882780", VA = "0x183883B80")]
	public void MGIODNIKAFO(TKey KKDEFIFHPNN, TVal KGJOJGIPNPH, bool DNFDNCACJLK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x3883CC0", Offset = "0x38828C0", VA = "0x183883CC0")]
	public bool NCMIFOJAAPA(TKey KKDEFIFHPNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x3883A60", Offset = "0x3882660", VA = "0x183883A60", Slot = "6")]
	public override bool HMDEELNDPOI(TKey KOAANLEBAPP, out TVal KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x3883830", Offset = "0x3882430", VA = "0x183883830")]
	public bool HCGFJGFGMCK(TKey KKDEFIFHPNN, TVal KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x3883720", Offset = "0x3882320", VA = "0x183883720")]
	public bool BPPKKEIEJPP(TKey KKDEFIFHPNN, TVal KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x3883B10", Offset = "0x3882710", VA = "0x183883B10", Slot = "7")]
	public override void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x3883C20", Offset = "0x3882820", VA = "0x183883C20")]
	private bool NAMNBECMMIM(TKey KKDEFIFHPNN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[DefaultMember("Item")]
public class NLJENLIBGCG<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public delegate int BOLNJJOLBGO(TKey KKDEFIFHPNN, TVal KGJOJGIPNPH);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class OKIHFPFEFPA
	{
		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public TKey OFHJGIGNJLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x5ECED0", Offset = "0x5EBAD0", VA = "0x1805ECED0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public TVal ONGHMHAEIAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x5EC4A0", Offset = "0x5EB0A0", VA = "0x1805EC4A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public int PIOMCNFKLDK
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x5ECCD0", Offset = "0x5EB8D0", VA = "0x1805ECCD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x66DA10", Offset = "0x66C610", VA = "0x18066DA10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public DateTime OLJBCBHDAII
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x6150C0", Offset = "0x613CC0", VA = "0x1806150C0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x1664CE0", Offset = "0x16638E0", VA = "0x181664CE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x28CA280", Offset = "0x28C8E80", VA = "0x1828CA280")]
		public OKIHFPFEFPA(TKey KKDEFIFHPNN, TVal OOIECLPAPEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const int MDNMNDDIAJI = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<TKey, LinkedListNode<OKIHFPFEFPA>> OAJPDKOGEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly LinkedList<OKIHFPFEFPA> CBGFNOKPBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly BOLNJJOLBGO PLEKBFIEFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly TimeSpan HCEKADONCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly EMGBJKDEGII MGFAEMNBKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int EILIPFCGLPE;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public int LNGADAPJAOK
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x747CD0", Offset = "0x7468D0", VA = "0x180747CD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private bool LGHCGPDHLCH
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x28C9A30", Offset = "0x28C8630", VA = "0x1828C9A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	internal virtual int ABAJKMDGLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x747CE0", Offset = "0x7468E0", VA = "0x180747CE0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	private int BKKGFAKFDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x22E57E0", Offset = "0x22E43E0", VA = "0x1822E57E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public virtual int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x1EAA400", Offset = "0x1EA9000", VA = "0x181EAA400", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IEnumerable<TKey> BAECMHCJKEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x28C9240", Offset = "0x28C7E40", VA = "0x1828C9240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public TVal GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x260F0A0", Offset = "0x260DCA0", VA = "0x18260F0A0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x28C9600", Offset = "0x28C8200", VA = "0x1828C9600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x28C9EE0", Offset = "0x28C8AE0", VA = "0x1828C9EE0")]
	public NLJENLIBGCG(int LAODCMGHKOP, [Optional] BOLNJJOLBGO PLEKBFIEFKC, [Optional] IEqualityComparer<TKey> IKLBJIBPDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x28C9E40", Offset = "0x28C8A40", VA = "0x1828C9E40")]
	public NLJENLIBGCG(TimeSpan HCEKADONCON, [Optional] IEqualityComparer<TKey> IKLBJIBPDGN, [Optional] EMGBJKDEGII MGFAEMNBKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x28C9E90", Offset = "0x28C8A90", VA = "0x1828C9E90")]
	public NLJENLIBGCG(int LAODCMGHKOP, TimeSpan HCEKADONCON, [Optional] IEqualityComparer<TKey> IKLBJIBPDGN, [Optional] EMGBJKDEGII MGFAEMNBKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x28C9FB0", Offset = "0x28C8BB0", VA = "0x1828C9FB0")]
	public NLJENLIBGCG(int LAODCMGHKOP, BOLNJJOLBGO PLEKBFIEFKC, TimeSpan HCEKADONCON, [Optional] IEqualityComparer<TKey> IKLBJIBPDGN, [Optional] EMGBJKDEGII MGFAEMNBKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x28C90D0", Offset = "0x28C7CD0", VA = "0x1828C90D0")]
	public void AEKMHIMHHBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x28C9810", Offset = "0x28C8410", VA = "0x1828C9810")]
	public void GELHLBKPBFF(TKey KKDEFIFHPNN, TVal KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x3383F10", Offset = "0x3382B10", VA = "0x183383F10")]
	public bool JNIHJKFEBJI(TKey KKDEFIFHPNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x28C9AC0", Offset = "0x28C86C0", VA = "0x1828C9AC0")]
	private TVal JHLAPKAGPFG(TKey KOAANLEBAPP)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x28C98D0", Offset = "0x28C84D0", VA = "0x1828C98D0", Slot = "6")]
	public virtual bool HMDEELNDPOI(TKey KOAANLEBAPP, out TVal KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x28C9D10", Offset = "0x28C8910", VA = "0x1828C9D10", Slot = "7")]
	public virtual void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x28C9D80", Offset = "0x28C8980", VA = "0x1828C9D80")]
	private bool NKMNBAIKDFO(OKIHFPFEFPA IAPEGOPBHLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x28C8E90", Offset = "0x28C7A90", VA = "0x1828C8E90")]
	private void AEIICHBNPAI(LinkedListNode<OKIHFPFEFPA> FIIBKHOJPOP, TVal FMKHLEANADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x28C9630", Offset = "0x28C8230", VA = "0x1828C9630")]
	private void GDKIADOKKKE(TKey KKDEFIFHPNN, TVal KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x28C9460", Offset = "0x28C8060", VA = "0x1828C9460")]
	private void BCPPHLDIJDL(OKIHFPFEFPA IAPEGOPBHLH, TVal FMKHLEANADK, int GFPBEMBPAFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DefaultMember("Item")]
public class HOJFPGKDMJH<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly List<T> FPPBJGHNMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private HashSet<T> LIMOOMANGMP;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2777150", Offset = "0x2775D50", VA = "0x182777150", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool IDIBHBMOFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2CA65E0", Offset = "0x2CA51E0", VA = "0x182CA65E0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6610", Offset = "0x2CA5210", VA = "0x182CA6610", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x22E8A80", Offset = "0x22E7680", VA = "0x1822E8A80", Slot = "11")]
	public void Add(T IGAPBICELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5F40", Offset = "0x2CA4B40", VA = "0x182CA5F40")]
	public bool HMPINEEPGPG(T IGAPBICELKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x2CA6480", Offset = "0x2CA5080", VA = "0x182CA6480", Slot = "15")]
	public bool Remove(T IGAPBICELKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5EC0", Offset = "0x2CA4AC0", VA = "0x182CA5EC0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x226BBF0", Offset = "0x226A7F0", VA = "0x18226BBF0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5DD0", Offset = "0x2CA49D0", VA = "0x182CA5DD0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5E30", Offset = "0x2CA4A30", VA = "0x182CA5E30", Slot = "13")]
	public bool Contains(T IGAPBICELKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5E60", Offset = "0x2CA4A60", VA = "0x182CA5E60", Slot = "14")]
	public void CopyTo(T[] LBLDONKHBCF, int BPPENCELOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2CA6090", Offset = "0x2CA4C90", VA = "0x182CA6090", Slot = "6")]
	public int IndexOf(T IGAPBICELKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2CA6190", Offset = "0x2CA4D90", VA = "0x182CA6190", Slot = "7")]
	public void Insert(int HIANDEDCLIF, T IGAPBICELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x2CA6250", Offset = "0x2CA4E50", VA = "0x182CA6250", Slot = "8")]
	public void RemoveAt(int HIANDEDCLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5D00", Offset = "0x2CA4900", VA = "0x182CA5D00")]
	public void AOCOKCGBDFF(Predicate<T> NLAOGHDGOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5E90", Offset = "0x2CA4A90", VA = "0x182CA5E90")]
	public void EOGECOLDIPK(Comparison<T> GECJJJOJIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x2CA6500", Offset = "0x2CA5100", VA = "0x182CA6500")]
	public HOJFPGKDMJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class LIDNHOFGIGO
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x5792DA0", Offset = "0x57919A0", VA = "0x185792DA0")]
	public static Vector3 FAKPJPLLPFK(this GameObject MHECAANKLIB, float CPLAIECGPIJ)
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
			[Cpp2IlInjected.Address(RVA = "0x228D280", Offset = "0x228BE80", VA = "0x18228D280")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x5795C80", Offset = "0x5794880", VA = "0x185795C80")]
		public SerializedGuid(in Guid JLMDLFJCONJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x5795B30", Offset = "0x5794730", VA = "0x185795B30")]
		public static SerializedGuid LEIONAAMPDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x5795A20", Offset = "0x5794620", VA = "0x185795A20")]
		public static SerializedGuid HNLAFEBJBJJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x5795AA0", Offset = "0x57946A0", VA = "0x185795AA0")]
		public bool KJLHILCOCHK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x5795C50", Offset = "0x5794850", VA = "0x185795C50", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x5795BB0", Offset = "0x57947B0", VA = "0x185795BB0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x5795980", Offset = "0x5794580", VA = "0x185795980")]
		public bool GLBPEIKDFCD(in Guid JLMDLFJCONJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x5795800", Offset = "0x5794400", VA = "0x185795800", Slot = "7")]
		public bool Equals(SerializedGuid NPKIIGGBCCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x57958A0", Offset = "0x57944A0", VA = "0x1857958A0", Slot = "0")]
		public override bool Equals(object EBMPLNBFAKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x5795A10", Offset = "0x5794610", VA = "0x185795A10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x57957D0", Offset = "0x57943D0", VA = "0x1857957D0", Slot = "6")]
		public int CompareTo(SerializedGuid NPKIIGGBCCI)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class ACMPJCONIOF : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public readonly Type BKOGCBJCJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public readonly string JKNAMDALJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public readonly bool PGCHEBJHPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public readonly bool MFPPJJAAFEH;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x578C940", Offset = "0x578B540", VA = "0x18578C940")]
	public ACMPJCONIOF(Type KBOBOODOPEO, string GJNKKDNAPLG, bool OEAJLKKMIED = false, bool GBIOIDDMDEI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface JMFDEGKNLCJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface DONBJNIOKME<T> : JMFDEGKNLCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000078")]
	T ONGHMHAEIAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	bool HBJFEHMEAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	string OODIPHCKCDM
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
	global::DONBJNIOKME<T> GCFBFBIFGJI(Action<T> EECJKPCOOLC);

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::DONBJNIOKME<T> BNJPJEEJJGG(Action<T> EECJKPCOOLC);

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::DONBJNIOKME<T> EFGFAHLIEKC(Action<T, T> MCOHOMJDBIK);

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::DONBJNIOKME<T> BAEEKDDAMOO(Action<T, T> MCOHOMJDBIK);

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::DONBJNIOKME<T> CGMNOMOLAPD(Action<string> NJHECNHOIAI);

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::DONBJNIOKME<T> LDKGCCNNPBA(Action<string> NJHECNHOIAI);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class HPMDMPAKNJM<T> : global::DONBJNIOKME<T>, JMFDEGKNLCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private global::GPFDHKIFHJO<T, T> IGHLMNNMJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private global::GDHOEMDADGP<T> HGLLMFJMHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private global::GDHOEMDADGP<string> KHNJOEMBINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private string FJDEDBEGBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private T MIILAJKCKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool HDOCPBNKHOF;

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T ONGHMHAEIAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x614A30", Offset = "0x613630", VA = "0x180614A30", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x2610160", Offset = "0x260ED60", VA = "0x182610160", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool HBJFEHMEAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x66E8B0", Offset = "0x66D4B0", VA = "0x18066E8B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public string OODIPHCKCDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6150C0", Offset = "0x613CC0", VA = "0x1806150C0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x28D3DD0", Offset = "0x28D29D0", VA = "0x1828D3DD0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x2CA7350", Offset = "0x2CA5F50", VA = "0x182CA7350")]
	private void BPLIDKKNCCH(T LEPAGINGHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x2CA7260", Offset = "0x2CA5E60", VA = "0x182CA7260")]
	private void BCLIIDOMPNE(string CIJKLAFFGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x2CA75D0", Offset = "0x2CA61D0", VA = "0x182CA75D0")]
	public void MFLCPIEJCKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x2CA7480", Offset = "0x2CA6080", VA = "0x182CA7480", Slot = "6")]
	public global::DONBJNIOKME<T> EFGFAHLIEKC(Action<T, T> MCOHOMJDBIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x2CA7210", Offset = "0x2CA5E10", VA = "0x182CA7210", Slot = "7")]
	public global::DONBJNIOKME<T> BAEEKDDAMOO(Action<T, T> MCOHOMJDBIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x2CA74D0", Offset = "0x2CA60D0", VA = "0x182CA74D0", Slot = "4")]
	public global::DONBJNIOKME<T> GCFBFBIFGJI(Action<T> MCOHOMJDBIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x2CA7300", Offset = "0x2CA5F00", VA = "0x182CA7300", Slot = "5")]
	public global::DONBJNIOKME<T> BNJPJEEJJGG(Action<T> EECJKPCOOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x2CA73F0", Offset = "0x2CA5FF0", VA = "0x182CA73F0", Slot = "8")]
	public global::DONBJNIOKME<T> CGMNOMOLAPD(Action<string> NJHECNHOIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x2CA7560", Offset = "0x2CA6160", VA = "0x182CA7560", Slot = "9")]
	public global::DONBJNIOKME<T> LDKGCCNNPBA(Action<string> NJHECNHOIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x2CA7680", Offset = "0x2CA6280", VA = "0x182CA7680")]
	public HPMDMPAKNJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class EFFBIOBDKHP
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class NMBNEBAJEFB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public global::DONBJNIOKME<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::DHNNFIFBMBD<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		public NMBNEBAJEFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x29CA7E0", Offset = "0x29C93E0", VA = "0x1829CA7E0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x1FF5FA0", Offset = "0x1FF4BA0", VA = "0x181FF5FA0")]
	public static global::FCECEOPAAFH<T> MBOMINHFCOP<T>(this global::DONBJNIOKME<T> KBPJEEJJLMN, Action<T> KCGMNIDCJMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class ECGIJGGMGEF<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public readonly struct PPPLBHFHEDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly long BNHFAGHFNBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public readonly long NOBNJMJBBPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public readonly int FLIILMNJOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public readonly int HBGBHCKHKOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly bool PDGBKPNAKEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly string KAJOPNFBGNO;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x29CAC80", Offset = "0x29C9880", VA = "0x1829CAC80")]
		public PPPLBHFHEDO(long BNHFAGHFNBF, int FLIILMNJOMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x29CACF0", Offset = "0x29C98F0", VA = "0x1829CACF0")]
		public PPPLBHFHEDO(long BNHFAGHFNBF, long NOBNJMJBBPF, int FLIILMNJOMB, int HBGBHCKHKOA, bool PDGBKPNAKEA, string KAJOPNFBGNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x29CAAE0", Offset = "0x29C96E0", VA = "0x1829CAAE0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void OHJIOBFABNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x29CAA70", Offset = "0x29C9670", VA = "0x1829CAA70")]
		public int FKDEBNOGIJL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x29CAAC0", Offset = "0x29C96C0", VA = "0x1829CAAC0")]
		public int KADKOACKKGM(int GDLLGLOPMMB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x29CAB50", Offset = "0x29C9750", VA = "0x1829CAB50")]
		public double PDBNGPJLMHN()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x29CABC0", Offset = "0x29C97C0", VA = "0x1829CABC0")]
		public PPPLBHFHEDO PFFHCALJACG(long NOBNJMJBBPF, int HBGBHCKHKOA)
		{
			return default(PPPLBHFHEDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class JBHAGEIOKBE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public readonly TKey OFHJGIGNJLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly global::ECGIJGGMGEF<TKey> HHBOJHHPENA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private List<JBHAGEIOKBE> HKONDJIBKLG;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public string IJDKGKIGFBB
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x2191E80", Offset = "0x2190A80", VA = "0x182191E80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x28BD380", Offset = "0x28BBF80", VA = "0x1828BD380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public IEnumerable<JBHAGEIOKBE> KKHMGMKNEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x29CA5E0", Offset = "0x29C91E0", VA = "0x1829CA5E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public PPPLBHFHEDO DPEBBAECFFK
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0xFBA8C0", Offset = "0xFB94C0", VA = "0x180FBA8C0")]
			[CompilerGenerated]
			get
			{
				return default(PPPLBHFHEDO);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x29CA600", Offset = "0x29C9200", VA = "0x1829CA600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x29CA630", Offset = "0x29C9230", VA = "0x1829CA630")]
		internal JBHAGEIOKBE(global::ECGIJGGMGEF<TKey> HHBOJHHPENA, TKey KKDEFIFHPNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x29CA3D0", Offset = "0x29C8FD0", VA = "0x1829CA3D0")]
		public JBHAGEIOKBE EMOOGHNIBLF(TKey KKDEFIFHPNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x29CA4E0", Offset = "0x29C90E0", VA = "0x1829CA4E0")]
		public void HDEHMKMPAPI(TKey KKDEFIFHPNN, Action<JBHAGEIOKBE> KINCGCMCJLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x20205D0", Offset = "0x201F1D0", VA = "0x1820205D0")]
		public T HDEHMKMPAPI<T>(TKey KKDEFIFHPNN, Func<JBHAGEIOKBE, T> OJFOLJJJFLE)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD490", Offset = "0x1FAC090", VA = "0x181FAD490")]
		[AsyncStateMachine(typeof(IPOEAJMOKKC))]
		public Task<T> JKNNAPCOJLN<T>(TKey KKDEFIFHPNN, Func<JBHAGEIOKBE, Task<T>> OJFOLJJJFLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x29CA210", Offset = "0x29C8E10", VA = "0x1829CA210", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class FHAKPFMLMKE : IEnumerable<(TKey, List<TKey>, PPPLBHFHEDO)>, IEnumerable, IEnumerator<(TKey, List<TKey>, PPPLBHFHEDO)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private (TKey key, List<TKey> path, PPPLBHFHEDO timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public global::ECGIJGGMGEF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private IEnumerator<(TKey key, List<TKey> path, PPPLBHFHEDO timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		private (TKey, List<TKey>, PPPLBHFHEDO) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x2776840", Offset = "0x2775440", VA = "0x182776840", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, PPPLBHFHEDO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x4653300", Offset = "0x4651F00", VA = "0x184653300", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x2776D10", Offset = "0x2775910", VA = "0x182776D10")]
		[DebuggerHidden]
		public FHAKPFMLMKE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x4653360", Offset = "0x4651F60", VA = "0x184653360", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x4652F30", Offset = "0x4651B30", VA = "0x184652F30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x46533E0", Offset = "0x4651FE0", VA = "0x1846533E0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x46532B0", Offset = "0x4651EB0", VA = "0x1846532B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x46531F0", Offset = "0x4651DF0", VA = "0x1846531F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, PPPLBHFHEDO)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x1FD46E0", Offset = "0x1FD32E0", VA = "0x181FD46E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class GOHMPMMBBJI : IEnumerable<(TKey, List<TKey>, PPPLBHFHEDO)>, IEnumerable, IEnumerator<(TKey, List<TKey>, PPPLBHFHEDO)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private (TKey key, List<TKey> path, PPPLBHFHEDO timerEntry) <>2__current;

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
		private JBHAGEIOKBE timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public JBHAGEIOKBE <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public global::ECGIJGGMGEF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private IEnumerator<JBHAGEIOKBE> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private IEnumerator<(TKey key, List<TKey> path, PPPLBHFHEDO timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		private (TKey, List<TKey>, PPPLBHFHEDO) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x2776840", Offset = "0x2775440", VA = "0x182776840", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, PPPLBHFHEDO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x29C6E70", Offset = "0x29C5A70", VA = "0x1829C6E70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2776D10", Offset = "0x2775910", VA = "0x182776D10")]
		[DebuggerHidden]
		public GOHMPMMBBJI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x29C6ED0", Offset = "0x29C5AD0", VA = "0x1829C6ED0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x29C6790", Offset = "0x29C5390", VA = "0x1829C6790", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x29C6FA0", Offset = "0x29C5BA0", VA = "0x1829C6FA0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x29C6FF0", Offset = "0x29C5BF0", VA = "0x1829C6FF0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x29C6E20", Offset = "0x29C5A20", VA = "0x1829C6E20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x29C6D20", Offset = "0x29C5920", VA = "0x1829C6D20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, PPPLBHFHEDO)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x29C6DF0", Offset = "0x29C59F0", VA = "0x1829C6DF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Action<TKey, PPPLBHFHEDO> MDAOBGIBONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Action<TKey, PPPLBHFHEDO> PJFBJJOHMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Action<global::ECGIJGGMGEF<TKey>> LJFIINGBPAO;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private const string KOHCCFFFCMF = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly JBHAGEIOKBE GMADCJPJJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private bool KNBPMOOFAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int JBGGFGPNCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Stopwatch CMOAPILJKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public readonly int KPMAOPLAEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private string PFFCJOMIJMC;

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public JBHAGEIOKBE DIDKCPKNNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x6150C0", Offset = "0x613CC0", VA = "0x1806150C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	[NotNull]
	public string IJDKGKIGFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x63F130", Offset = "0x63DD30", VA = "0x18063F130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x29BA380", Offset = "0x29B8F80", VA = "0x1829BA380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public long HEMACNLHMDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x29BA4C0", Offset = "0x29B90C0", VA = "0x1829BA4C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public int BLFBMKPPLFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x29BA3E0", Offset = "0x29B8FE0", VA = "0x1829BA3E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x29BA6F0", Offset = "0x29B92F0", VA = "0x1829BA6F0")]
	public ECGIJGGMGEF(TKey FJJBNFKEDGN, [Optional] int? FLIILMNJOMB, [Optional][CanBeNull] Stopwatch CMOAPILJKIA, [Optional] Action<TKey, PPPLBHFHEDO> MDAOBGIBONP, [Optional] Action<TKey, PPPLBHFHEDO> PJFBJJOHMPL, [Optional] Action<global::ECGIJGGMGEF<TKey>> LJFIINGBPAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x29BA410", Offset = "0x29B9010", VA = "0x1829BA410", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x29BA640", Offset = "0x29B9240", VA = "0x1829BA640")]
	public void JEGPOEBHLIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x29BA4A0", Offset = "0x29B90A0", VA = "0x1829BA4A0")]
	public void ECJPAIMDFNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x29BA4E0", Offset = "0x29B90E0", VA = "0x1829BA4E0")]
	[IteratorStateMachine(typeof(global::ECGIJGGMGEF<>.FHAKPFMLMKE))]
	public IEnumerable<(TKey, List<TKey>, PPPLBHFHEDO)> FGKPFEPGJGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x29BA570", Offset = "0x29B9170", VA = "0x1829BA570")]
	[IteratorStateMachine(typeof(global::ECGIJGGMGEF<>.GOHMPMMBBJI))]
	private IEnumerable<(TKey, List<TKey>, PPPLBHFHEDO)> FGKPFEPGJGD(List<TKey> ABEDOAAIHDK, JBHAGEIOKBE FOPIPGOCAEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x29BA660", Offset = "0x29B9260", VA = "0x1829BA660")]
	private (long, int) NKPPPIJJIBL()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public abstract class LJFHADMDEBA<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut KDFBDPAMHIH(global::ECGIJGGMGEF<TKey> HHBOJHHPENA);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
	protected LJFHADMDEBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public abstract class CIMHDFAKBPA<TKey> : global::LJFHADMDEBA<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public delegate string MAJIDPKFBAA(TKey KKDEFIFHPNN);

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x21E3D00", Offset = "0x21E2900", VA = "0x1821E3D00")]
	protected string GCDOCEFBMAO(double MIHPHHFGLMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x21E3D60", Offset = "0x21E2960", VA = "0x1821E3D60")]
	protected string GCNHAHPNBGO(int OLPPNGCIODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x21E3F80", Offset = "0x21E2B80", VA = "0x1821E3F80")]
	private static string KHIHKLEENKD(TKey KKDEFIFHPNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x21E3DB0", Offset = "0x21E29B0", VA = "0x1821E3DB0", Slot = "4")]
	public override string KDFBDPAMHIH(global::ECGIJGGMGEF<TKey> HHBOJHHPENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x21E3E60", Offset = "0x21E2A60", VA = "0x1821E3E60")]
	public string KDFBDPAMHIH(global::ECGIJGGMGEF<TKey> HHBOJHHPENA, [NotNull] MAJIDPKFBAA OCAIJBGEDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string ODPNOKNFDGJ(global::ECGIJGGMGEF<TKey> HHBOJHHPENA, [NotNull] MAJIDPKFBAA OCAIJBGEDBF);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1FCE600", Offset = "0x1FCD200", VA = "0x181FCE600")]
	protected CIMHDFAKBPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class IDAHIPHGGFK<TKey> : global::LJFHADMDEBA<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public delegate string NJHALPMJHKH(TKey KKDEFIFHPNN);

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int BLMBJGBFAOL = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly string KDBKAKJJGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly double JPLBFGEMKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly bool HCPNDMKLIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly int HFKBFAFFEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly ISet<string> JIBJCHMFJMP;

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2CA88E0", Offset = "0x2CA74E0", VA = "0x182CA88E0")]
	private static string KHIHKLEENKD(TKey KKDEFIFHPNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8A80", Offset = "0x2CA7680", VA = "0x182CA8A80")]
	public IDAHIPHGGFK(string KDBKAKJJGGE = "F2", double JPLBFGEMKKM = double.MaxValue, bool HCPNDMKLIJA = false, int HFKBFAFFEFF = int.MaxValue, [Optional] ISet<string> JIBJCHMFJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8830", Offset = "0x2CA7430", VA = "0x182CA8830", Slot = "4")]
	public override Dictionary<string, string> KDFBDPAMHIH(global::ECGIJGGMGEF<TKey> HHBOJHHPENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2CA82B0", Offset = "0x2CA6EB0", VA = "0x182CA82B0")]
	private bool IABKBAEPHKH(string BDALKBCJOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8390", Offset = "0x2CA6F90", VA = "0x182CA8390")]
	public Dictionary<string, string> KDFBDPAMHIH(global::ECGIJGGMGEF<TKey> HHBOJHHPENA, NJHALPMJHKH OCAIJBGEDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8100", Offset = "0x2CA6D00", VA = "0x182CA8100")]
	private string BNEIBBPNJKA(StringBuilder EAIJABJLJPP, List<TKey> EDHKDKJLIAC, NJHALPMJHKH OCAIJBGEDBF, bool BFBDKEJBMDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8920", Offset = "0x2CA7520", VA = "0x182CA8920")]
	private static void MJOJHHMCEFK(StringBuilder HPAHJNNLEDP, string HGNMIOGONEP, bool IGGFIDKPKJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class DLHEIOBBNNI<TKey> : global::CIMHDFAKBPA<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct EPCHDDLDJLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public MAJIDPKFBAA keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static global::DLHEIOBBNNI<TKey> DBFNMCLAAPC;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int EOHCLIHIHCG = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly string[] BLICLGODBEJ;

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x38519F0", Offset = "0x38505F0", VA = "0x1838519F0")]
	private DLHEIOBBNNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x38509D0", Offset = "0x384F5D0", VA = "0x1838509D0", Slot = "5")]
	protected override string ODPNOKNFDGJ(global::ECGIJGGMGEF<TKey> HHBOJHHPENA, MAJIDPKFBAA OCAIJBGEDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x38508F0", Offset = "0x384F4F0", VA = "0x1838508F0")]
	[CompilerGenerated]
	internal static string CLNCDCMBNJK(string AFCJOGOHCIJ, TKey KKDEFIFHPNN, ref EPCHDDLDJLI P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class AGFKFNKNMAL<TKey> : global::CIMHDFAKBPA<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class NBCNFJEBCNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public MAJIDPKFBAA keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		public NBCNFJEBCNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2788D10", Offset = "0x2787910", VA = "0x182788D10")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2D96430", Offset = "0x2D95030", VA = "0x182D96430", Slot = "5")]
	protected override string ODPNOKNFDGJ(global::ECGIJGGMGEF<TKey> HHBOJHHPENA, MAJIDPKFBAA OCAIJBGEDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2D96B80", Offset = "0x2D95780", VA = "0x182D96B80")]
	public AGFKFNKNMAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public sealed class OMKOHCFOCGE : global::ECGIJGGMGEF<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class MHOPMHFEKJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public Action<OMKOHCFOCGE> callback;

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public MHOPMHFEKJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x5793030", Offset = "0x5791C30", VA = "0x185793030")]
		internal void <Wrap>b__0(global::ECGIJGGMGEF<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5793D70", Offset = "0x5792970", VA = "0x185793D70")]
	public OMKOHCFOCGE([Optional] string KLPEGNFCKMN, [Optional] int? FLIILMNJOMB, [Optional] Stopwatch CMOAPILJKIA, [Optional] Action<string, PPPLBHFHEDO> MDAOBGIBONP, [Optional] Action<string, PPPLBHFHEDO> PJFBJJOHMPL, [Optional] Action<OMKOHCFOCGE> LJFIINGBPAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x5793CB0", Offset = "0x57928B0", VA = "0x185793CB0")]
	private static Action<global::ECGIJGGMGEF<string>> HDEHMKMPAPI(Action<OMKOHCFOCGE> KCGMNIDCJMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public abstract class EMGBJKDEGII
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private class CJJEDBBCFHK : EMGBJKDEGII
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public static EMGBJKDEGII DBFNMCLAAPC
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x578D680", Offset = "0x578C280", VA = "0x18578D680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public override DateTime FPKHDKINDPF
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x578D630", Offset = "0x578C230", VA = "0x18578D630", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public override float DHFKFPFDLDK
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x578D620", Offset = "0x578C220", VA = "0x18578D620", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x578D780", Offset = "0x578C380", VA = "0x18578D780")]
		public CJJEDBBCFHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static EMGBJKDEGII KKBLBCPLONN;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public static EMGBJKDEGII KEBFNIGMDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x578E9E0", Offset = "0x578D5E0", VA = "0x18578E9E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public abstract DateTime FPKHDKINDPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public abstract float DHFKFPFDLDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	protected EMGBJKDEGII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class PKNFKIMNOPM : global::PFAFLABIOOJ<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x5793FC0", Offset = "0x5792BC0", VA = "0x185793FC0")]
	public PKNFKIMNOPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class PFAFLABIOOJ<T> : global::EBGIJCEGKOP<T>, NOOKMHHEHND, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Task<T> GJAPNKPKDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Task FGPDPJABCHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5B80", Offset = "0x1FC4780", VA = "0x181FC5B80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public global::FCECEOPAAFH<T> MKNMBHOFFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private OCBCLOGKDMK EDFILBJKIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x1FCC4C0", Offset = "0x1FCB0C0", VA = "0x181FCC4C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x3A1F430", Offset = "0x3A1E030", VA = "0x183A1F430")]
	public PFAFLABIOOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class HAJMOCLCEMP : global::EGGKAOKGJAN<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x57907A0", Offset = "0x578F3A0", VA = "0x1857907A0")]
	public HAJMOCLCEMP(Exception PKPFAHAEBCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class EGGKAOKGJAN<T> : global::EBGIJCEGKOP<T>, NOOKMHHEHND, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Task<T> GJAPNKPKDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private Task FGPDPJABCHI
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5B80", Offset = "0x1FC4780", VA = "0x181FC5B80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public global::FCECEOPAAFH<T> MKNMBHOFFBL
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private OCBCLOGKDMK EDFILBJKIHN
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x1FCC4C0", Offset = "0x1FCB0C0", VA = "0x181FCC4C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x29C5450", Offset = "0x29C4050", VA = "0x1829C5450")]
	public EGGKAOKGJAN(Exception PKPFAHAEBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface NOOKMHHEHND : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000097")]
	[NotNull]
	Task GJAPNKPKDIN
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	[NotNull]
	OCBCLOGKDMK MKNMBHOFFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface EBGIJCEGKOP<T> : NOOKMHHEHND, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000099")]
	[NotNull]
	new Task<T> GJAPNKPKDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	[NotNull]
	new global::FCECEOPAAFH<T> MKNMBHOFFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public abstract class CMNKPBGDIBF<TTask, T> : global::EBGIJCEGKOP<T>, NOOKMHHEHND, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class EMKFCPMOEAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public global::CMNKPBGDIBF<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		public EMKFCPMOEAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static bool OMJONHACCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly Task<T> FFAHJNHCBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	protected readonly CancellationTokenSource LHFNCMCPHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private bool KNBPMOOFAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private SynchronizationContext AHPNAMAELAC;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Task<T> GJAPNKPKDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private Task FGPDPJABCHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public global::FCECEOPAAFH<T> MKNMBHOFFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private OCBCLOGKDMK EDFILBJKIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x21834A0", Offset = "0x21820A0", VA = "0x1821834A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool GAILNDCGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x66D990", Offset = "0x66C590", VA = "0x18066D990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2A60AA0", Offset = "0x2A5F6A0", VA = "0x182A60AA0")]
	static CMNKPBGDIBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x2A60D80", Offset = "0x2A5F980", VA = "0x182A60D80")]
	protected CMNKPBGDIBF(TTask FFAHJNHCBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x2A609B0", Offset = "0x2A5F5B0", VA = "0x182A609B0", Slot = "1")]
	~CMNKPBGDIBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x2A608E0", Offset = "0x2A5F4E0", VA = "0x182A608E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2A60770", Offset = "0x2A5F370", VA = "0x182A60770")]
	private void BMILBDCJANP(bool CNFKCHKOBDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T MNLKBPLBCBB(TTask AHJKMLBLGJO);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void FGNBOFDFHJI();

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2A60A50", Offset = "0x2A5F650", VA = "0x182A60A50")]
	[CompilerGenerated]
	private void LLCHGNBLKAL(object DHOMHGLAOFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface OADNCHGAGFG
{
	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	float AGGEFHFFNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event OOJMIDCJEKE GLJGLONHFNK;
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class CJLNBKFABKE : OADNCHGAGFG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public readonly struct CIMKNJNACCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public readonly float IBPCOHCJGHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public readonly float LPPKHHOIDAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		internal readonly bool PDABALEFEIL;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float PIOMCNFKLDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x578D380", Offset = "0x578BF80", VA = "0x18578D380")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x578D4F0", Offset = "0x578C0F0", VA = "0x18578D4F0")]
		public CIMKNJNACCH(float HGAEFGJCCPH, float OFINKJCDEMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x578D390", Offset = "0x578BF90", VA = "0x18578D390", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class PFEFOKAFKLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public CJLNBKFABKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public PFEFOKAFKLF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly int LAODCMGHKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private int AKHFMGKODPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly OADNCHGAGFG[] PLMKALBJHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly OOJMIDCJEKE[] NOMIILNDOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly CIMKNJNACCH[] IHCCJINFAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private CIMKNJNACCH OOMKJNLNLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly AAIEOKMHKNK LPOCGEBEGBG;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public CIMKNJNACCH NDEMOGIIBKF
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x3504A70", Offset = "0x3503670", VA = "0x183504A70")]
		get
		{
			return default(CIMKNJNACCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float AGGEFHFFNHL
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x578D860", Offset = "0x578C460", VA = "0x18578D860", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event OOJMIDCJEKE GLJGLONHFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x578DE90", Offset = "0x578CA90", VA = "0x18578DE90", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x578DF50", Offset = "0x578CB50", VA = "0x18578DF50", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x578E010", Offset = "0x578CC10", VA = "0x18578E010")]
	public CJLNBKFABKE(int LAODCMGHKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x578D7E0", Offset = "0x578C3E0", VA = "0x18578D7E0")]
	public AAIEOKMHKNK CHJJFAFGGLK(CIMKNJNACCH AIFJHEPBPCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x578DAB0", Offset = "0x578C6B0", VA = "0x18578DAB0")]
	public void FABKFMAGOHF(OADNCHGAGFG CNJHINGAICA, [Optional] CIMKNJNACCH AKFLMIKBNOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x578D880", Offset = "0x578C480", VA = "0x18578D880")]
	internal int DPCKACGJMLB(OADNCHGAGFG ONDHKLNLONF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x578DA60", Offset = "0x578C660", VA = "0x18578DA60")]
	internal CIMKNJNACCH EPNDHILAHBM(int HIANDEDCLIF)
	{
		return default(CIMKNJNACCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x578D8D0", Offset = "0x578C4D0", VA = "0x18578D8D0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public delegate void OOJMIDCJEKE(float HFAAFEANOLI);
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal static class FLIEFCJALND
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	internal const float ELOEKLEJBHN = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class GPCFHMBDCGC
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class JAGPDGFPHHD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly OADNCHGAGFG ONDHKLNLONF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private readonly OOJMIDCJEKE KCGMNIDCJMF;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x5791AA0", Offset = "0x57906A0", VA = "0x185791AA0")]
		public JAGPDGFPHHD(OADNCHGAGFG ONDHKLNLONF, OOJMIDCJEKE KCGMNIDCJMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x5791A50", Offset = "0x5790650", VA = "0x185791A50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x5790720", Offset = "0x578F320", VA = "0x185790720")]
	internal static bool JGJFHHACPHD(float FNKIIBFNLFB, float EDLPJGEPJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x3BAEBD0", Offset = "0x3BAD7D0", VA = "0x183BAEBD0")]
	internal static float MOHDAKEOKFL(float FNKIIBFNLFB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x5790660", Offset = "0x578F260", VA = "0x185790660")]
	public static IDisposable CIHAJKBICJM(this OADNCHGAGFG ONDHKLNLONF, OOJMIDCJEKE KCGMNIDCJMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class AAIEOKMHKNK : OADNCHGAGFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private float HFAAFEANOLI;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float AGGEFHFFNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x124C640", Offset = "0x124B240", VA = "0x18124C640", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x578C7D0", Offset = "0x578B3D0", VA = "0x18578C7D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event OOJMIDCJEKE GLJGLONHFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x578C730", Offset = "0x578B330", VA = "0x18578C730", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x578C8A0", Offset = "0x578B4A0", VA = "0x18578C8A0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public AAIEOKMHKNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class OKDJOFGFJFO
{
	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x5793910", Offset = "0x5792510", VA = "0x185793910")]
	[NotNull]
	public static byte[] GFHHJAFLBEI(this HMMHNBPHCGO EJKBMOFMBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x5793980", Offset = "0x5792580", VA = "0x185793980")]
	[NotNull]
	public static byte[] GFHHJAFLBEI(this HMMHNBPHCGO EJKBMOFMBJO, HashAlgorithmName AEFBCAIHCJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x5793620", Offset = "0x5792220", VA = "0x185793620")]
	public static bool AFHJIPGOMCN([CanBeNull] this HMMHNBPHCGO EJKBMOFMBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x5793790", Offset = "0x5792390", VA = "0x185793790")]
	public static bool AFHJIPGOMCN([CanBeNull] this HMMHNBPHCGO EJKBMOFMBJO, out string FJDEDBEGBLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x5793B20", Offset = "0x5792720", VA = "0x185793B20")]
	private static string PCLENICBHFN([CanBeNull] byte[] IAIFCDOPKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x57939F0", Offset = "0x57925F0", VA = "0x1857939F0")]
	private static bool IIGLKIGNGGJ([NotNull] HMMHNBPHCGO EJKBMOFMBJO, [CanBeNull] out byte[] MIMLOFMKLBF, [CanBeNull] out byte[] PHMFBEHPODK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class BDEPHPPENBE
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x578CEC0", Offset = "0x578BAC0", VA = "0x18578CEC0")]
	[NotNull]
	public static byte[] GFHHJAFLBEI(this JKGNMEEONGA FIMJEFMGIBJ, byte[] LBENBJKBPFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x578CCA0", Offset = "0x578B8A0", VA = "0x18578CCA0")]
	[NotNull]
	public static byte[] GFHHJAFLBEI(this JKGNMEEONGA FIMJEFMGIBJ, HashAlgorithmName AEFBCAIHCJK, byte[] LBENBJKBPFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public interface JKGNMEEONGA
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash CLFDHFBNGEA);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public interface HMMHNBPHCGO : JKGNMEEONGA
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	[CanBeNull]
	byte[] ONAFCDMHPFA
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
	byte[] DIEHOGKHGFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	UnityEngine.Object PMJCEFIANLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public static class KBOGAHEFNNM
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class FMAJMAECEOF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x578EF10", Offset = "0x578DB10", VA = "0x18578EF10")]
		public FMAJMAECEOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x578EEB0", Offset = "0x578DAB0", VA = "0x18578EEB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private const byte JJPGMEILIMC = 1;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private const byte JOBMNAHFILG = 0;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly ArrayPool<byte> OLJJOGKPJCD;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static bool JBOEDHBFONB;

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2D44DE0", Offset = "0x2D439E0", VA = "0x182D44DE0")]
	[Conditional("UNITY_EDITOR")]
	private static void NBMBPFGCPMK<T>(params T[] CFCGJFFKEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x57924E0", Offset = "0x57910E0", VA = "0x1857924E0")]
	public static IDisposable HLJEGHEEKAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x5791F60", Offset = "0x5790B60", VA = "0x185791F60")]
	public static void EABNGPGLENE(this IncrementalHash KCCNCBDGIPE, [CanBeNull] GameObject MHECAANKLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2D441C0", Offset = "0x2D42DC0", VA = "0x182D441C0")]
	public static void EABNGPGLENE<T>(this IncrementalHash KCCNCBDGIPE, [CanBeNull] T DGHFPMGLNEJ) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2D44D50", Offset = "0x2D43950", VA = "0x182D44D50")]
	public static void LMIMKEDIDHA<T>(this IncrementalHash KCCNCBDGIPE, [CanBeNull] T FIMJEFMGIBJ) where T : JKGNMEEONGA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2D448F0", Offset = "0x2D434F0", VA = "0x182D448F0")]
	public static void FOJGMKELPMO<T>(this IncrementalHash KCCNCBDGIPE, [CanBeNull] IList<T> LNCNFDPHCJO) where T : JKGNMEEONGA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x5792B90", Offset = "0x5791790", VA = "0x185792B90")]
	private static bool MLFNGCGBHOL([CanBeNull] JKGNMEEONGA FIMJEFMGIBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x5792040", Offset = "0x5790C40", VA = "0x185792040")]
	public static void EGHIIMDHNDK(this IncrementalHash CLFDHFBNGEA, [CanBeNull] string IOPMIBHIJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x57927A0", Offset = "0x57913A0", VA = "0x1857927A0")]
	public static void LJBDKGDGBFN(this IncrementalHash CLFDHFBNGEA, long BCCGJPNPNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x57922F0", Offset = "0x5790EF0", VA = "0x1857922F0")]
	public static void HBKKDAPAKGM(this IncrementalHash CLFDHFBNGEA, int IEBNAPEPMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x57920A0", Offset = "0x5790CA0", VA = "0x1857920A0")]
	public static void FOKHJABBBPC(this IncrementalHash CLFDHFBNGEA, short JPEEHCCIJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x5792990", Offset = "0x5791590", VA = "0x185792990")]
	public static void LKEIADFMBHK(this IncrementalHash CLFDHFBNGEA, byte MEJHFFKFOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x5791D70", Offset = "0x5790970", VA = "0x185791D70")]
	public static void DOGHHOLKONF(this IncrementalHash CLFDHFBNGEA, bool AFEENJHGMLB, bool DHGGHPGBFMC = false, bool MPJODLDEEOJ = false, bool KBADMNNNGMI = false, bool CJHOBEBALCC = false, bool CMODGNHLHFL = false, bool COAONPBDODK = false, bool IHPIKFHCMBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2D44280", Offset = "0x2D42E80", VA = "0x182D44280")]
	public static void EDGLHCGGGPA<T>(this IncrementalHash CLFDHFBNGEA, T OLPMEAMCBBH) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x5791CB0", Offset = "0x57908B0", VA = "0x185791CB0")]
	public static void CLOLHKFAOBN(this IncrementalHash CLFDHFBNGEA, float LHCHFCCOALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x5791D10", Offset = "0x5790910", VA = "0x185791D10")]
	public static void CMMAAJMAMBL(this IncrementalHash CLFDHFBNGEA, double PIDJBEADPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x5792B20", Offset = "0x5791720", VA = "0x185792B20")]
	public static void LNKOHKGKOGF(this IncrementalHash CLFDHFBNGEA, ulong OFGKINHNIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x5792290", Offset = "0x5790E90", VA = "0x185792290")]
	public static void GIJBJIHDONA(this IncrementalHash CLFDHFBNGEA, uint OGNAOBLIOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x5792730", Offset = "0x5791330", VA = "0x185792730")]
	public static void KDANGDBMIEL(this IncrementalHash CLFDHFBNGEA, ushort ENFCFHGEBFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x5791B30", Offset = "0x5790730", VA = "0x185791B30")]
	public static void ABIHEFCDFKP(this IncrementalHash CLFDHFBNGEA, Vector3 LNJDBJIJKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x5792580", Offset = "0x5791180", VA = "0x185792580")]
	public static void JHIHOJHENFO(this IncrementalHash CLFDHFBNGEA, Quaternion LCBCLFHDOKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class LCGDMKPDLFH : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public readonly Type BKOGCBJCJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public readonly string JKNAMDALJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public readonly bool PGCHEBJHPHP;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x5792D40", Offset = "0x5791940", VA = "0x185792D40")]
	public LCGDMKPDLFH(Type KBOBOODOPEO, string GJNKKDNAPLG, bool OEAJLKKMIED = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class AKEDKDDDABD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x578CA30", Offset = "0x578B630", VA = "0x18578CA30")]
	public AKEDKDDDABD(string CIJKLAFFGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x578C9B0", Offset = "0x578B5B0", VA = "0x18578C9B0")]
	public AKEDKDDDABD(string CIJKLAFFGJI, Exception BDDOPJHNKMA)
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
			[Cpp2IlInjected.Address(RVA = "0x5ECED0", Offset = "0x5EBAD0", VA = "0x1805ECED0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x610710", Offset = "0x60F310", VA = "0x180610710")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public T this[int JNJLPHNJHIN, int KLLLICDPIBA]
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x218C900", Offset = "0x218B500", VA = "0x18218C900")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x218C9A0", Offset = "0x218B5A0", VA = "0x18218C9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x218C870", Offset = "0x218B470", VA = "0x18218C870")]
		public Array2D(uint ODJKCOFMAJL, uint HEHBEAHJOKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x218C7F0", Offset = "0x218B3F0", VA = "0x18218C7F0")]
		public void LONCNHKPMCG()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x578CC40", Offset = "0x578B840", VA = "0x18578CC40")]
		public Array2DVector3(uint ODJKCOFMAJL, uint HEHBEAHJOKL)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal static class EJKMBDOJFGF
{
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public const int JPFMDOCHIJL = -1;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public const int EJDMPFNBCAH = 0;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[DefaultMember("Item")]
public class BBIJONEMJFB<THandle, TValue> : IDisposable where THandle : struct, FBMJPDGBHLO where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly List<THandle> CPMPJGKLBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly List<TValue> HNDHJGFLHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private readonly Func<TValue> JCOCOJPCCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly Action<TValue> OCADHPPNGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private int EGNPCFLANPD;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TValue GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x28FC1A0", Offset = "0x28FADA0", VA = "0x1828FC1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x28FCA10", Offset = "0x28FB610", VA = "0x1828FCA10")]
	public BBIJONEMJFB(Action<TValue> OCADHPPNGLK, [Optional] Func<TValue> JCOCOJPCCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x28FC120", Offset = "0x28FAD20", VA = "0x1828FC120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x28FBFE0", Offset = "0x28FABE0", VA = "0x1828FBFE0")]
	public THandle DPFIJBHMAAN()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x28FC650", Offset = "0x28FB250", VA = "0x1828FC650")]
	public THandle LFMPFEAFMAL(TValue KGJOJGIPNPH)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x28FC5A0", Offset = "0x28FB1A0", VA = "0x1828FC5A0")]
	public bool JNIHJKFEBJI(THandle CGGCCCAGOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x28FC6F0", Offset = "0x28FB2F0", VA = "0x1828FC6F0")]
	public bool MOANCCAMPPP(THandle CGGCCCAGOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x28FC970", Offset = "0x28FB570", VA = "0x1828FC970")]
	public bool POIHJJLHJCC(THandle CGGCCCAGOLF, out TValue KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x28FC550", Offset = "0x28FB150", VA = "0x1828FC550")]
	public TValue JHLAPKAGPFG(THandle CGGCCCAGOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x28FBE90", Offset = "0x28FAA90", VA = "0x1828FBE90")]
	public bool CAACINLFJOH(THandle CGGCCCAGOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x28FC1D0", Offset = "0x28FADD0", VA = "0x1828FC1D0")]
	private THandle FJLJGDPPJCP(int HIANDEDCLIF)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x28FC6C0", Offset = "0x28FB2C0", VA = "0x1828FC6C0")]
	private TValue MBOMINHFCOP(int HIANDEDCLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x28FC930", Offset = "0x28FB530", VA = "0x1828FC930")]
	private void OOCHKFDNPHL(int HIANDEDCLIF, in THandle CGGCCCAGOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x28FBE50", Offset = "0x28FAA50", VA = "0x1828FBE50")]
	private void BPLIDKKNCCH(int HIANDEDCLIF, in TValue KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x28FC260", Offset = "0x28FAE60", VA = "0x1828FC260")]
	private THandle HFCBGLDKFHN()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x28FC490", Offset = "0x28FB090", VA = "0x1828FC490")]
	private void IILJODBECPM(THandle CGGCCCAGOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x28FBE40", Offset = "0x28FAA40", VA = "0x1828FBE40")]
	private int AMKPAOADGBE(int MAAFFLODELA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x28FC920", Offset = "0x28FB520", VA = "0x1828FC920")]
	private bool OLJDPDMKBEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x63D9A0", Offset = "0x63C5A0", VA = "0x18063D9A0")]
	private void KOFHMEPEKKO(THandle CGGCCCAGOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x28FC7D0", Offset = "0x28FB3D0", VA = "0x1828FC7D0")]
	private bool NGHAOJNIGEE(out THandle CGGCCCAGOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x28FC850", Offset = "0x28FB450", VA = "0x1828FC850")]
	private bool OBJKPHFLNGP(out THandle CGGCCCAGOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x28FC200", Offset = "0x28FAE00", VA = "0x1828FC200")]
	private void GPKBHBKGBKJ(THandle CGGCCCAGOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x28FC370", Offset = "0x28FAF70", VA = "0x1828FC370")]
	private void IDOPELOAACL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public interface FBMJPDGBHLO
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	int PAOIHHHPKNO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	int EKKPBKBJINC
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
public interface POBAFBEGBJN<T> : FBMJPDGBHLO, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public static class ANPDEDNKKDB
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0xD725F0", Offset = "0xD711F0", VA = "0x180D725F0")]
	public static bool NJGNBFGJCGK<T>(this T CGGCCCAGOLF, T NPKIIGGBCCI) where T : struct, FBMJPDGBHLO
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x3121300", Offset = "0x311FF00", VA = "0x183121300")]
	public static bool PDABALEFEIL<T>(this T CGGCCCAGOLF) where T : struct, FBMJPDGBHLO
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x578CB50", Offset = "0x578B750", VA = "0x18578CB50")]
	public static string HJFCIHNILCM(this FBMJPDGBHLO CGGCCCAGOLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public class HMGINCFNLFG
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum DJFGJGLJFCH : byte
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
	private int CLFDHFBNGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private bool LCLOFEEMGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private DJFGJGLJFCH IADJLOGDJJD;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool BPOGOELLAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x5791580", Offset = "0x5790180", VA = "0x185791580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool BINJJPMLDHP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x57907F0", Offset = "0x578F3F0", VA = "0x1857907F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x57915D0", Offset = "0x57901D0", VA = "0x1857915D0")]
	public HMGINCFNLFG(bool LCLOFEEMGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x5791060", Offset = "0x578FC60", VA = "0x185791060")]
	public void NEKHDDDMNAI(object EBMPLNBFAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x5790E10", Offset = "0x578FA10", VA = "0x185790E10")]
	public void INPGNHIDLLB(int KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x5790EC0", Offset = "0x578FAC0", VA = "0x185790EC0")]
	public void IPNHHHKHJHP(uint ONCBAEEDPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x5791000", Offset = "0x578FC00", VA = "0x185791000")]
	public void MHECNHGIOEP(bool OAPJHIMKEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x5791590", Offset = "0x5790190", VA = "0x185791590")]
	public void OPMKCKMKGOF(long FDNAKPKLEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x5791020", Offset = "0x578FC20", VA = "0x185791020")]
	public void MIOOMPLCNKO(ulong NOOBPADNLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5790870", Offset = "0x578F470", VA = "0x185790870")]
	public void DACGBILBMFH(string BFOAINCGILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x57908E0", Offset = "0x578F4E0", VA = "0x1857908E0")]
	public void DCIGGILDJJF(Enum PKPFAHAEBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x5790ED0", Offset = "0x578FAD0", VA = "0x185790ED0")]
	public void KNJBGCGOGDH(IList FPPBJGHNMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x2D42570", Offset = "0x2D41170", VA = "0x182D42570")]
	public void MGFKMGEMEKD<T, U>(Dictionary<T, U> OMEABACFPCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x5790970", Offset = "0x578F570", VA = "0x185790970")]
	private void GBNBPNHHJGI(IDictionary OMEABACFPCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5790DA0", Offset = "0x578F9A0", VA = "0x185790DA0")]
	public int IMAOJBFIHLM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5790800", Offset = "0x578F400", VA = "0x185790800")]
	public short BOAICJLGMGJ()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5790FF0", Offset = "0x578FBF0", VA = "0x185790FF0")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5790D30", Offset = "0x578F930", VA = "0x185790D30")]
	private void HNFEBPEFOGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public abstract class HNLAHMNNPGN<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	internal class HPEOEJHJECA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public TNode FNGHHBJHDMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public TNode MKOLBPGKLJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public CENJMMPELAD PIKMLOGMBBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public List<CENJMMPELAD> HFFOKFCPHHD;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		public HPEOEJHJECA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	internal struct CENJMMPELAD : IComparable<CENJMMPELAD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int OPGMLDDCKPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public TClaimant DOEKCPIHEIE;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5F4CF0", Offset = "0x5F38F0", VA = "0x1805F4CF0")]
		public CENJMMPELAD(int OPGMLDDCKPJ, TClaimant DOEKCPIHEIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F9F0", Offset = "0x2C9E5F0", VA = "0x182C9F9F0")]
		public bool EFKLHEIJPCK(in CENJMMPELAD NPKIIGGBCCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x2C9FA50", Offset = "0x2C9E650", VA = "0x182C9FA50")]
		public bool FHOKKMICNIG(in CENJMMPELAD NPKIIGGBCCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F9E0", Offset = "0x2C9E5E0", VA = "0x182C9F9E0", Slot = "4")]
		public int CompareTo(CENJMMPELAD NPKIIGGBCCI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x2C9FA60", Offset = "0x2C9E660", VA = "0x182C9FA60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public enum BMILLMJBBHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class GDFHDIAIJON : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public global::HNLAHMNNPGN<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x2176720", Offset = "0x2175320", VA = "0x182176720")]
		[DebuggerHidden]
		public GDFHDIAIJON(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2F60", Offset = "0x2CA1B60", VA = "0x182CA2F60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3120", Offset = "0x2CA1D20", VA = "0x182CA3120", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3040", Offset = "0x2CA1C40", VA = "0x182CA3040", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x1EB3BB0", Offset = "0x1EB27B0", VA = "0x181EB3BB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly global::OLFEEJOJIBH<HPEOEJHJECA> HJMGPDLPEFB;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly global::OLFEEJOJIBH<List<CENJMMPELAD>> OACBCAIPADN;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static int HEAFNFCDIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	internal readonly Dictionary<TClaimant, TNode> DHHGIADMPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	internal readonly Dictionary<TNode, HPEOEJHJECA> JGDPKDACDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private BMILLMJBBHK FALFKKIACAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private bool JMNCCKFMNPP;

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode DPNLFEGJALJ(TNode PKMOGGONLGF);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void OMABNDMAAPF(TNode PKMOGGONLGF, TClaimant OLBGOPKBBJD, TClaimant CKDHLKEIDPF);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5A70", Offset = "0x2CA4670", VA = "0x182CA5A70")]
	public HNLAHMNNPGN(BMILLMJBBHK FALFKKIACAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5360", Offset = "0x2CA3F60", VA = "0x182CA5360")]
	public void LNANAMFKMJC(TNode PKMOGGONLGF, TNode BIMAKIIINII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x2CA50A0", Offset = "0x2CA3CA0", VA = "0x182CA50A0")]
	public void HEEKJAGPODE(TClaimant DOEKCPIHEIE, TNode ELFJDMEMGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4D30", Offset = "0x2CA3930", VA = "0x182CA4D30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5000", Offset = "0x2CA3C00", VA = "0x182CA5000")]
	private void GPLIJJBCDMO(TClaimant DOEKCPIHEIE, TNode NKDIMGEOFCG, TNode ELFJDMEMGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4F90", Offset = "0x2CA3B90", VA = "0x182CA4F90")]
	private int GBHLMPNEGDH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x2CA48C0", Offset = "0x2CA34C0", VA = "0x182CA48C0")]
	private void DBCPINNDFJC(TClaimant DOEKCPIHEIE, TNode PIPOGHLEACO, TNode MCHPJLFOAJC, int ENJLAENBGCN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5780", Offset = "0x2CA4380", VA = "0x182CA5780")]
	private void OMGHDCCGEOC(CENJMMPELAD GHENMKLAALP, HPEOEJHJECA MCPKHNELNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4650", Offset = "0x2CA3250", VA = "0x182CA4650")]
	private void BIKFKFHKCHE(TClaimant DOEKCPIHEIE, TNode PIPOGHLEACO, TNode MCHPJLFOAJC, int ENJLAENBGCN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5810", Offset = "0x2CA4410", VA = "0x182CA5810")]
	private void PPJOBLKPNNA(CENJMMPELAD GHENMKLAALP, TNode PKMOGGONLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5260", Offset = "0x2CA3E60", VA = "0x182CA5260")]
	private void LGABNPLEIMP(CENJMMPELAD GHENMKLAALP, HPEOEJHJECA MCPKHNELNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x2CA54B0", Offset = "0x2CA40B0", VA = "0x182CA54B0")]
	private void ODMKGCIAAFK(HPEOEJHJECA MCPKHNELNEB, bool LOOBFEHJKDL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4210", Offset = "0x2CA2E10", VA = "0x182CA4210")]
	private void ACANIJKCPFP(HPEOEJHJECA MCPKHNELNEB, TNode BIMAKIIINII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x2CA53E0", Offset = "0x2CA3FE0", VA = "0x182CA53E0")]
	[IteratorStateMachine(typeof(global::HNLAHMNNPGN<, >.GDFHDIAIJON))]
	private IEnumerable<TNode> OCCMDPCAHGL(TNode PIPOGHLEACO, TNode MCHPJLFOAJC, bool NJFGNDKFAJH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x2CA51A0", Offset = "0x2CA3DA0", VA = "0x182CA51A0")]
	private HPEOEJHJECA KADBBFJNNIE(TNode PKMOGGONLGF, TNode MKOLBPGKLJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x2CA55F0", Offset = "0x2CA41F0", VA = "0x182CA55F0")]
	private HPEOEJHJECA OLNEEKKINMM(TNode PKMOGGONLGF, TNode MKOLBPGKLJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4B70", Offset = "0x2CA3770", VA = "0x182CA4B70")]
	private void DJMENLLGAPB(HPEOEJHJECA MCPKHNELNEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class KMMNMGPMDCL<T> : IEnumerable<global::KMMNMGPMDCL<T>.NODPGKNJGNO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public struct NODPGKNJGNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public T KGJOJGIPNPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int HIANDEDCLIF;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public class AJMBALGMPNK : IEnumerator<NODPGKNJGNO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private global::KMMNMGPMDCL<T> BBDNOECODFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private int HIANDEDCLIF;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x2CD5440", Offset = "0x2CD4040", VA = "0x182CD5440", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public NODPGKNJGNO IJPBKONCNPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x48F7E50", Offset = "0x48F6A50", VA = "0x1848F7E50", Slot = "4")]
			get
			{
				return default(NODPGKNJGNO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x91A330", Offset = "0x918F30", VA = "0x18091A330")]
		public AJMBALGMPNK(global::KMMNMGPMDCL<T> BBDNOECODFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x48F7C40", Offset = "0x48F6840", VA = "0x1848F7C40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x87D780", Offset = "0x87C380", VA = "0x18087D780", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x8B2280", Offset = "0x8B0E80", VA = "0x1808B2280", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	private struct JLFOLKMMHEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public bool NNHJIDJEOJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public T KGJOJGIPNPH;
	}

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private const int NJNNOIAHEBF = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private readonly Dictionary<T, int> BGPBELKBDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private JLFOLKMMHEK[] IJBNOCIAMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private int DBMHONBJEAJ;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public int BKGGAODOJAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCC0", Offset = "0x5EB8C0", VA = "0x1805ECCC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x7471B0", Offset = "0x745DB0", VA = "0x1807471B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x2777150", Offset = "0x2775D50", VA = "0x182777150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x490B0E0", Offset = "0x4909CE0", VA = "0x18490B0E0")]
	public KMMNMGPMDCL(int LAODCMGHKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x490B5B0", Offset = "0x490A1B0", VA = "0x18490B5B0")]
	public KMMNMGPMDCL(NODPGKNJGNO[] BOKEGPABBHH, bool PDCCHFAIJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x490A660", Offset = "0x4909260", VA = "0x18490A660")]
	public int LDKCLCGFCCC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x490A6D0", Offset = "0x49092D0", VA = "0x18490A6D0")]
	private int LOGMGPJJAEL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x490A500", Offset = "0x4909100", VA = "0x18490A500", Slot = "6")]
	protected virtual uint ILPFKINAKDO(uint CLFDHFBNGEA, T KGJOJGIPNPH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x4909F70", Offset = "0x4908B70", VA = "0x184909F70")]
	public bool HGCBHMCIPOF(T KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x490AFA0", Offset = "0x4909BA0", VA = "0x18490AFA0")]
	public bool NKDGGKEELMF(int HIANDEDCLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x4909A80", Offset = "0x4908680", VA = "0x184909A80")]
	public bool ACOKKIFAPKJ(Func<T, bool> APPBMIEBDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x4909F10", Offset = "0x4908B10", VA = "0x184909F10")]
	public int GFMHOHIKPGL(T KGJOJGIPNPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x490AC00", Offset = "0x4909800", VA = "0x18490AC00")]
	public T MBOMINHFCOP(int HIANDEDCLIF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x490AB80", Offset = "0x4909780", VA = "0x18490AB80")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x4909FE0", Offset = "0x4908BE0", VA = "0x184909FE0")]
	public bool HMPINEEPGPG(T KGJOJGIPNPH, bool AIOMNEMBJPA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x490A020", Offset = "0x4908C20", VA = "0x18490A020")]
	public bool HMPINEEPGPG(T KGJOJGIPNPH, int HIANDEDCLIF, bool AIOMNEMBJPA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x490A550", Offset = "0x4909150", VA = "0x18490A550")]
	public bool JNIHJKFEBJI(T KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x4909E70", Offset = "0x4908A70", VA = "0x184909E70")]
	public bool FNJJGGMAHAD(int HIANDEDCLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x4909D80", Offset = "0x4908980", VA = "0x184909D80")]
	private void DABKMIOMOJG(int HIANDEDCLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x490AE60", Offset = "0x4909A60", VA = "0x18490AE60")]
	public NODPGKNJGNO[] NAAOBDLEDEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x4909C00", Offset = "0x4908800", VA = "0x184909C00")]
	private int BMIMCPJBLGM(int KAENBJHHHIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x490B060", Offset = "0x4909C60", VA = "0x18490B060", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x490B060", Offset = "0x4909C60", VA = "0x18490B060", Slot = "4")]
	private IEnumerator<NODPGKNJGNO> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public struct JGMCFAJJDFK<Handle> where Handle : FBMJPDGBHLO, new()
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	private struct IDCLLEPGBBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private readonly global::JGMCFAJJDFK<Handle> DCIFJJJFNLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private int HIANDEDCLIF;

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public int AKDEBGIIMAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x3EC0030", Offset = "0x3EBEC30", VA = "0x183EC0030")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Handle NKLCIPGDKBH
		{
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0x3EBF6D0", Offset = "0x3EBE2D0", VA = "0x183EBF6D0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x3EC04F0", Offset = "0x3EBF0F0", VA = "0x183EC04F0")]
		public IDCLLEPGBBA(global::JGMCFAJJDFK<Handle> DCIFJJJFNLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x3EBFA40", Offset = "0x3EBE640", VA = "0x183EBFA40")]
		public CLIGAIBIKFB GLGBCEHJPPK(in CLIGAIBIKFB ELDEGBGONOE)
		{
			return default(CLIGAIBIKFB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x3EBF990", Offset = "0x3EBE590", VA = "0x183EBF990")]
		public CNAJDAHAFCK GLGBCEHJPPK(in CNAJDAHAFCK ELDEGBGONOE)
		{
			return default(CNAJDAHAFCK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x3EBFAF0", Offset = "0x3EBE6F0", VA = "0x183EBFAF0")]
		public bool GNMIKIPPKDL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x3EC03D0", Offset = "0x3EBEFD0", VA = "0x183EC03D0")]
		private int NIOIEFOAKPG(string CIJKLAFFGJI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x3EC02B0", Offset = "0x3EBEEB0", VA = "0x183EC02B0")]
		private Handle MHIODEEJIAL(string CIJKLAFFGJI)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public struct CLIGAIBIKFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private IDCLLEPGBBA PDJJHKPGCNL;

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public int IJPBKONCNPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x3EBF020", Offset = "0x3EBDC20", VA = "0x183EBF020")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x3EBF180", Offset = "0x3EBDD80", VA = "0x183EBF180")]
		public CLIGAIBIKFB(global::JGMCFAJJDFK<Handle> DCIFJJJFNLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x3EBEF20", Offset = "0x3EBDB20", VA = "0x183EBEF20")]
		public bool GNMIKIPPKDL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x3EBF0A0", Offset = "0x3EBDCA0", VA = "0x183EBF0A0")]
		public CLIGAIBIKFB OKMFHIDEJFI()
		{
			return default(CLIGAIBIKFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public struct CNAJDAHAFCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private IDCLLEPGBBA PDJJHKPGCNL;

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Handle IJPBKONCNPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0x3EBF260", Offset = "0x3EBDE60", VA = "0x183EBF260")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x3EBF180", Offset = "0x3EBDD80", VA = "0x183EBF180")]
		public CNAJDAHAFCK(global::JGMCFAJJDFK<Handle> DCIFJJJFNLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x3EBEF20", Offset = "0x3EBDB20", VA = "0x183EBEF20")]
		public bool GNMIKIPPKDL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x3EBF2E0", Offset = "0x3EBDEE0", VA = "0x183EBF2E0")]
		public CNAJDAHAFCK OKMFHIDEJFI()
		{
			return default(CNAJDAHAFCK);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private NativeList<int> GKHNHLKNEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private NativeList<int> GKICCMNMKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private int FDCANKINNOC;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool GAJOLDEOPJK
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x3EC8AB0", Offset = "0x3EC76B0", VA = "0x183EC8AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public int LNGADAPJAOK
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x3EC9950", Offset = "0x3EC8550", VA = "0x183EC9950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public int LCBMBHMCJOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCD0", Offset = "0x5EB8D0", VA = "0x1805ECCD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public int JOCGBEBALLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCD0", Offset = "0x5EB8D0", VA = "0x1805ECCD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public CLIGAIBIKFB EDNCLIGCOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x3EC97E0", Offset = "0x3EC83E0", VA = "0x183EC97E0")]
		get
		{
			return default(CLIGAIBIKFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CNAJDAHAFCK BILMEPFKAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x3EC8070", Offset = "0x3EC6C70", VA = "0x183EC8070")]
		get
		{
			return default(CNAJDAHAFCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x3ECA930", Offset = "0x3EC9530", VA = "0x183ECA930")]
	public JGMCFAJJDFK(int BEMMAFOHLHE, Allocator HGKGLCNFHPJ = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x3EC7C20", Offset = "0x3EC6820", VA = "0x183EC7C20")]
	public void BMILBDCJANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x1BF4910", Offset = "0x1BF3510", VA = "0x181BF4910")]
	public static int AMKPAOADGBE(int BMIMFPIIMDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x3EC7F20", Offset = "0x3EC6B20", VA = "0x183EC7F20")]
	public static bool DAHOIMCDGLJ(int BMIMFPIIMDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x3EC88E0", Offset = "0x3EC74E0", VA = "0x183EC88E0")]
	public static bool IBKKKKDAOID(int BMIMFPIIMDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x3EC7820", Offset = "0x3EC6420", VA = "0x183EC7820")]
	public bool ANAFGPEHENC(int HIANDEDCLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x3EC7720", Offset = "0x3EC6320", VA = "0x183EC7720")]
	public bool AEBJHIHIJJH(int HIANDEDCLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x3EC90A0", Offset = "0x3EC7CA0", VA = "0x183EC90A0")]
	public bool LNPPABKEELL(Handle CGGCCCAGOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x3ECA110", Offset = "0x3EC8D10", VA = "0x183ECA110")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void OECDBNOBFKG(Handle CGGCCCAGOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9520", Offset = "0x3EC8120", VA = "0x183EC9520")]
	public Handle NDPEDGCKBBM()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6D80", Offset = "0x3EC5980", VA = "0x183EC6D80")]
	public void ADHGDEIDCPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x3EC8020", Offset = "0x3EC6C20", VA = "0x183EC8020")]
	public void DCILNCLCNGI(Handle CGGCCCAGOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x3EC8120", Offset = "0x3EC6D20", VA = "0x183EC8120")]
	public bool FICHMGEBBOJ(Handle CGGCCCAGOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x3EC88F0", Offset = "0x3EC74F0", VA = "0x183EC88F0")]
	private bool IEPMCKKPEOO(int HIANDEDCLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x3EC8640", Offset = "0x3EC7240", VA = "0x183EC8640")]
	private void GPLMDCIDPLO(out int HIANDEDCLIF, out int MAAFFLODELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x3ECA5F0", Offset = "0x3EC91F0", VA = "0x183ECA5F0")]
	private void PGNLIDOPLHD(Handle CGGCCCAGOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x3EC8CF0", Offset = "0x3EC78F0", VA = "0x183EC8CF0")]
	private void LLNJNAAJJKF(int HIANDEDCLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9340", Offset = "0x3EC7F40", VA = "0x183EC9340")]
	private bool MHJDHBPOHPJ(out int HIANDEDCLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x3EC8C60", Offset = "0x3EC7860", VA = "0x183EC8C60")]
	private static Handle LBMEGMJNLMM(int HIANDEDCLIF, int MAAFFLODELA)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[DefaultMember("Item")]
public struct LMBOEJIDHPD<Handle, T> where Handle : FBMJPDGBHLO, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private global::JGMCFAJJDFK<Handle> JIAFFDCEGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private T[] MKBEOGLCAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private Action<T> AFPFGMKMCPF;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool GAJOLDEOPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x39BDDF0", Offset = "0x39BC9F0", VA = "0x1839BDDF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public int LNGADAPJAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x39BEBB0", Offset = "0x39BD7B0", VA = "0x1839BEBB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x36E5AD0", Offset = "0x36E46D0", VA = "0x1836E5AD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public T GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x36E4520", Offset = "0x36E3120", VA = "0x1836E4520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x39BEE50", Offset = "0x39BDA50", VA = "0x1839BEE50")]
	public LMBOEJIDHPD(int BEMMAFOHLHE, [Optional] Action<T> AFPFGMKMCPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x39BDA50", Offset = "0x39BC650", VA = "0x1839BDA50")]
	public void BMILBDCJANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x39BE730", Offset = "0x39BD330", VA = "0x1839BE730")]
	public bool LNPPABKEELL(Handle CGGCCCAGOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void OECDBNOBFKG(Handle CGGCCCAGOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x36E4C90", Offset = "0x36E3890", VA = "0x1836E4C90")]
	public T JHLAPKAGPFG(Handle CGGCCCAGOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x39BECA0", Offset = "0x39BD8A0", VA = "0x1839BECA0")]
	public bool POIHJJLHJCC(Handle CGGCCCAGOLF, out T EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x36E4700", Offset = "0x36E3300", VA = "0x1836E4700")]
	public void GELHLBKPBFF(Handle CGGCCCAGOLF, T APGHKNOCFIB, out T EDBCCGJPLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x36E47A0", Offset = "0x36E33A0", VA = "0x1836E47A0")]
	public void GELHLBKPBFF(Handle CGGCCCAGOLF, T APGHKNOCFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x39BE440", Offset = "0x39BD040", VA = "0x1839BE440")]
	public bool KEPLMFEGDNM(Handle CGGCCCAGOLF, T APGHKNOCFIB, out T EDBCCGJPLJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x39BE360", Offset = "0x39BCF60", VA = "0x1839BE360")]
	public bool KEPLMFEGDNM(Handle CGGCCCAGOLF, T APGHKNOCFIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x39BE630", Offset = "0x39BD230", VA = "0x1839BE630")]
	public Handle LFMPFEAFMAL(T EBMPLNBFAKM)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x39BD5F0", Offset = "0x39BC1F0", VA = "0x1839BD5F0")]
	public void AOCOKCGBDFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x39BE0B0", Offset = "0x39BCCB0", VA = "0x1839BE0B0")]
	public void JNIHJKFEBJI(Handle CGGCCCAGOLF, out T EDBCCGJPLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x39BDFE0", Offset = "0x39BCBE0", VA = "0x1839BDFE0")]
	public void JNIHJKFEBJI(Handle CGGCCCAGOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x39BE8B0", Offset = "0x39BD4B0", VA = "0x1839BE8B0")]
	public bool MHEJJFJIIJI(Handle CGGCCCAGOLF, out T EDBCCGJPLJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x39BE7D0", Offset = "0x39BD3D0", VA = "0x1839BE7D0")]
	public bool MHEJJFJIIJI(Handle CGGCCCAGOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x36E45D0", Offset = "0x36E31D0", VA = "0x1836E45D0")]
	private T FNJJGGMAHAD(int HIANDEDCLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x39BDBB0", Offset = "0x39BC7B0", VA = "0x1839BDBB0")]
	private void IMOGNEIGOBH(int MEBMJNEMGFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class OLFEEJOJIBH<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Stack<T> DCIFJJJFNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly List<T> OJILINCMEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly int LGFOOCKIMEJ;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public int FDFDFKKKCLF
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x2191E80", Offset = "0x2190A80", VA = "0x182191E80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int CJJKCCNKJNP
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x21DEB20", Offset = "0x21DD720", VA = "0x1821DEB20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x497DD30", Offset = "0x497C930", VA = "0x18497DD30")]
	public static global::OLFEEJOJIBH<T> IGJLMAHHOAG(int LAODCMGHKOP = 0, int LGFOOCKIMEJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x497DC60", Offset = "0x497C860", VA = "0x18497DC60")]
	public static global::OLFEEJOJIBH<T> GHBNHOIMDDN(int LAODCMGHKOP = 0, int LGFOOCKIMEJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x497DFE0", Offset = "0x497CBE0", VA = "0x18497DFE0")]
	public OLFEEJOJIBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x497E020", Offset = "0x497CC20", VA = "0x18497E020")]
	public OLFEEJOJIBH(int LAODCMGHKOP, int LGFOOCKIMEJ = int.MaxValue, bool FDDJDJCAFAP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x497DEB0", Offset = "0x497CAB0", VA = "0x18497DEB0")]
	public T PGAPCMDIPNA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x497DB00", Offset = "0x497C700", VA = "0x18497DB00")]
	public void EMMKKOCKPGD(T KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x497D6F0", Offset = "0x497C2F0", VA = "0x18497D6F0")]
	private void AGNBILAFHKP(T KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x497D9D0", Offset = "0x497C5D0", VA = "0x18497D9D0")]
	private void BLCLPLLMEHN(T KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x497DBC0", Offset = "0x497C7C0", VA = "0x18497DBC0")]
	[Conditional("DEBUG_BUILD")]
	private void GGOAGBIKDCO(T LDGBABJBNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x497DE00", Offset = "0x497CA00", VA = "0x18497DE00")]
	[Conditional("DEBUG_BUILD")]
	private void NFMFPBAODPC(T LDGBABJBNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x497D9F0", Offset = "0x497C5F0", VA = "0x18497D9F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x497D7B0", Offset = "0x497C3B0", VA = "0x18497D7B0")]
	private void AOAADLDDGDN(IEnumerable<T> HNDHJGFLHLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class MCCLPJLGHAA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private Dictionary<int, T> FIDLDDIAMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private T HIADKKONJNG;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public virtual T GDNLIFIOBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4A0", Offset = "0x5EB0A0", VA = "0x1805EC4A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool OMPGBAADHPL
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x36E9850", Offset = "0x36E8450", VA = "0x1836E9850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x36E98F0", Offset = "0x36E84F0", VA = "0x1836E98F0")]
	public bool GDKIADOKKKE(T KGJOJGIPNPH, int OPGMLDDCKPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x36E9980", Offset = "0x36E8580", VA = "0x1836E9980")]
	public bool HNCEHIKFEKB(int OPGMLDDCKPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x36E9BE0", Offset = "0x36E87E0", VA = "0x1836E9BE0")]
	public T OBCLNHOEFCK(int JHBNPPCHOHN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x36E99E0", Offset = "0x36E85E0", VA = "0x1836E99E0")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x36E9B50", Offset = "0x36E8750", VA = "0x1836E9B50")]
	private bool MAPHJCNHECL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x36E9950", Offset = "0x36E8550", VA = "0x1836E9950")]
	public bool HMDEELNDPOI(int OPGMLDDCKPJ, out T KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x29C0500", Offset = "0x29BF100", VA = "0x1829C0500")]
	public MCCLPJLGHAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class EFPNOFHMDNH<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	protected struct CCAKLEKCNIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public T ONGHMHAEIAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public int FBJJFHGNIKI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	protected readonly List<CCAKLEKCNIB> PICCBBKHEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private T EFIOHGDICHM;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x2777150", Offset = "0x2775D50", VA = "0x182777150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x29C4C40", Offset = "0x29C3840", VA = "0x1829C4C40")]
	public bool ACOKKIFAPKJ(T KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x29C5250", Offset = "0x29C3E50", VA = "0x1829C5250")]
	public void LFMPFEAFMAL(T KGJOJGIPNPH, int OPGMLDDCKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x29C4F20", Offset = "0x29C3B20", VA = "0x1829C4F20")]
	public bool JNIHJKFEBJI(T KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x29C52F0", Offset = "0x29C3EF0", VA = "0x1829C52F0")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x29C4E90", Offset = "0x29C3A90", VA = "0x1829C4E90")]
	public T ALFPNACKGMA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x29C5350", Offset = "0x29C3F50", VA = "0x1829C5350")]
	public T NLPLPJPDFOH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x29C5040", Offset = "0x29C3C40", VA = "0x1829C5040")]
	private void KKFOGOGBMIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x29C53C0", Offset = "0x29C3FC0", VA = "0x1829C53C0")]
	public EFPNOFHMDNH()
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
		[FKJMAODFHJL(GIPDBINLIND.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0x57941E0", Offset = "0x5792DE0", VA = "0x1857941E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0x57946B0", Offset = "0x57932B0", VA = "0x1857946B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0x57944D0", Offset = "0x57930D0", VA = "0x1857944D0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0x5794850", Offset = "0x5793450", VA = "0x185794850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0x57940A0", Offset = "0x5792CA0", VA = "0x1857940A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0x5794570", Offset = "0x5793170", VA = "0x185794570")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000482")]
			[Cpp2IlInjected.Address(RVA = "0x5794390", Offset = "0x5792F90", VA = "0x185794390")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x5794000", Offset = "0x5792C00", VA = "0x185794000")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public interface OAENPPMPJIG
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public abstract class ResourcePrefabReference<T> : OAENPPMPJIG where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x21983D0", Offset = "0x2196FD0", VA = "0x1821983D0", Slot = "4")]
		public virtual T LNLGKADEJKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class GCFOCIJBOHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly Dictionary<byte, CNJGPICNGJL> HAGAAANNOAN;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public CNJGPICNGJL JANIPHHNEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x5EC490", Offset = "0x5EB090", VA = "0x1805EC490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public Vector2 HCJCODMMADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x18F47D0", Offset = "0x18F33D0", VA = "0x1818F47D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x29C0480", Offset = "0x29BF080", VA = "0x1829C0480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public Vector2 JCNBFKDAKDF
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x1F28960", Offset = "0x1F27560", VA = "0x181F28960")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x20D9F40", Offset = "0x20D8B40", VA = "0x1820D9F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector2 EJCLHOIKEDL
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x578F6E0", Offset = "0x578E2E0", VA = "0x18578F6E0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x578F050", Offset = "0x578DC50", VA = "0x18578F050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public int HAKFJNEABNE
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x6177E0", Offset = "0x6163E0", VA = "0x1806177E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x63D9A0", Offset = "0x63C5A0", VA = "0x18063D9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x578F850", Offset = "0x578E450", VA = "0x18578F850")]
	public GCFOCIJBOHE(Bounds KKEMNOKMGOJ, Vector2[] BEDBJAMBAHG, int LPMLBBJIJHK, byte KAENBJHHHIL, float JICLFLBNDHM = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x578F070", Offset = "0x578DC70", VA = "0x18578F070")]
	public CNJGPICNGJL DIDKJBIOIMH(byte HIANDEDCLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x578F0D0", Offset = "0x578DCD0", VA = "0x18578F0D0")]
	public void HCJCHIACIML(Vector3 JACLPJHPOFC, float EMCOOACKGAO, float EDCMLPGLDCK, ref List<byte> EDBPCGFAPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x578F830", Offset = "0x578E430", VA = "0x18578F830")]
	public void PKPBNFDALPA(CNJGPICNGJL.OCLKMILIEEH PNGBBMOODMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x578F700", Offset = "0x578E300", VA = "0x18578F700")]
	private CNJGPICNGJL MHCOHNMBDBO(byte HIANDEDCLIF, CNJGPICNGJL.DNAPEDANHEP MACJHAJNDAL, CNJGPICNGJL MKOLBPGKLJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x578F1C0", Offset = "0x578DDC0", VA = "0x18578F1C0")]
	private void KDCHLIHLMCO(CNJGPICNGJL MKOLBPGKLJP, Vector2[] BEDBJAMBAHG, int BBAHGKHGJCB, int EIEFAMGIMJC, int LDMHMDKJBMF, int PNNPOGDNMHF, float JICLFLBNDHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public class CNJGPICNGJL
{
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public enum DNAPEDANHEP
	{
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public enum OCLKMILIEEH
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
	public byte ICNLNAJKHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public Vector3 PCLJNGFBPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public Vector3 PIOMCNFKLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public Vector3 LEFFEBKANIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public Vector3 FHIJBIIOMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public DNAPEDANHEP LKJCIFIGKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public CNJGPICNGJL CFPOOABENIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public List<CNJGPICNGJL> HLLPPNAEFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public bool NIJCPEOEDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x578E580", Offset = "0x578D180", VA = "0x18578E580")]
	public CNJGPICNGJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x578E520", Offset = "0x578D120", VA = "0x18578E520")]
	public CNJGPICNGJL(byte DJHPMDEHJMK, DNAPEDANHEP MACJHAJNDAL, CNJGPICNGJL MKOLBPGKLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x578E150", Offset = "0x578CD50", VA = "0x18578E150")]
	public void BGLLMBLHMEJ(CNJGPICNGJL ACGOMEFGGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	public void PKPBNFDALPA(int HDDJANBCJPO, OCLKMILIEEH PNGBBMOODMM, int PJAJJOKBFDH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x578E1F0", Offset = "0x578CDF0", VA = "0x18578E1F0")]
	public void HCJCHIACIML(List<byte> EDBPCGFAPCC, Vector3 JACLPJHPOFC, float EMCOOACKGAO, float EDCMLPGLDCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x578E4C0", Offset = "0x578D0C0", VA = "0x18578E4C0")]
	public bool NHFCGPFOKPH(Vector3 KFDINOECEFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x578E480", Offset = "0x578D080", VA = "0x18578E480")]
	public bool MGCLFPAMPKK(Vector3 KFDINOECEFB, float FFOFFKHGNBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public class ANIHKMOHBMD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly Dictionary<T, object> GNDKAGIOPPJ;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x2788D10", Offset = "0x2787910", VA = "0x182788D10")]
	public bool KBMABAGBNME(T OFLEHNNCBOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x2871850", Offset = "0x2870450", VA = "0x182871850")]
	public bool KBMABAGBNME(T OFLEHNNCBOC, object KJKNLGILOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x28717F0", Offset = "0x28703F0", VA = "0x1828717F0")]
	public bool KBMABAGBNME(T OFLEHNNCBOC, object KJKNLGILOFJ, out object GHKDJFGAINI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x2871640", Offset = "0x2870240", VA = "0x182871640")]
	public bool AKAKNOPBNMC(T OFLEHNNCBOC, object KJKNLGILOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x2871710", Offset = "0x2870310", VA = "0x182871710")]
	public bool BBAPLNPMJEO(T OFLEHNNCBOC, object KJKNLGILOFJ, out object GHKDJFGAINI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x2871680", Offset = "0x2870280", VA = "0x182871680")]
	public bool AKAKNOPBNMC(T OFLEHNNCBOC, object KJKNLGILOFJ, out object GHKDJFGAINI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x2871890", Offset = "0x2870490", VA = "0x182871890")]
	public void POOEHJLJDCD(T OFLEHNNCBOC, object KJKNLGILOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x2871750", Offset = "0x2870350", VA = "0x182871750")]
	public void JONOLIMMGLA(T OFLEHNNCBOC, object KJKNLGILOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x28718C0", Offset = "0x28704C0", VA = "0x1828718C0")]
	public ANIHKMOHBMD()
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
		public struct KDJPCPDBDML<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			private readonly List<Component> FPPBJGHNMLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			private readonly bool GJADEHNCJLM;

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x82C360", Offset = "0x82AF60", VA = "0x18082C360")]
			public KDJPCPDBDML(List<Component> FPPBJGHNMLI, bool GJADEHNCJLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x2193710", Offset = "0x2192310", VA = "0x182193710")]
			public NJNKDOKIAPG<T> OKMFHIDEJFI()
			{
				return default(NJNKDOKIAPG<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x2193780", Offset = "0x2192380", VA = "0x182193780", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x2193780", Offset = "0x2192380", VA = "0x182193780", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		public struct NJNKDOKIAPG<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			private readonly List<Component> FPPBJGHNMLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			private readonly bool GJADEHNCJLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			private int HIANDEDCLIF;

			[Cpp2IlInjected.Token(Token = "0x170000D4")]
			public T IJPBKONCNPJ
			{
				[Cpp2IlInjected.Token(Token = "0x60004BB")]
				[Cpp2IlInjected.Address(RVA = "0x2194AA0", Offset = "0x21936A0", VA = "0x182194AA0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D5")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004BC")]
				[Cpp2IlInjected.Address(RVA = "0x2194A30", Offset = "0x2193630", VA = "0x182194A30", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x2194A70", Offset = "0x2193670", VA = "0x182194A70")]
			public NJNKDOKIAPG(List<Component> FPPBJGHNMLI, bool GJADEHNCJLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x2194960", Offset = "0x2193560", VA = "0x182194960", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x2194970", Offset = "0x2193570", VA = "0x182194970", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x2194A20", Offset = "0x2193620", VA = "0x182194A20", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x5796510", Offset = "0x5795110", VA = "0x185796510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x57964D0", Offset = "0x57950D0", VA = "0x1857964D0")]
		public ToolHierarchyCache(GameObject LBFKJDAPOEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x57962C0", Offset = "0x5794EC0", VA = "0x1857962C0")]
		private void NEDKCOBOAHP(GameObject LBFKJDAPOEC, bool CJFDGGNEKPC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x57963E0", Offset = "0x5794FE0", VA = "0x1857963E0")]
		public static void NEDKCOBOAHP(GameObject LBFKJDAPOEC, ref ToolHierarchyCache MACDONHOALK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x5796050", Offset = "0x5794C50", VA = "0x185796050")]
		public void HGBGHMHJKGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x57961B0", Offset = "0x5794DB0", VA = "0x1857961B0")]
		public void LCCJBPAKEGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x22FA9C0", Offset = "0x22F95C0", VA = "0x1822FA9C0")]
		public void IENAKEHLNHF<T>(Action<T> KINCGCMCJLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x5796200", Offset = "0x5794E00", VA = "0x185796200")]
		public Component MIFPPNHBKFF(Type LIJLAEFJGCI, bool GJADEHNCJLM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x202D0F0", Offset = "0x202BCF0", VA = "0x18202D0F0")]
		public T MIFPPNHBKFF<T>(bool GJADEHNCJLM = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x5796120", Offset = "0x5794D20", VA = "0x185796120")]
		public KDJPCPDBDML<Component> HNMBFEGGFIE(Type LIJLAEFJGCI, bool GJADEHNCJLM = false)
		{
			return default(KDJPCPDBDML<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x3138E20", Offset = "0x3137A20", VA = "0x183138E20")]
		public KDJPCPDBDML<T> HNMBFEGGFIE<T>(bool GJADEHNCJLM = false) where T : class
		{
			return default(KDJPCPDBDML<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x5795D30", Offset = "0x5794930", VA = "0x185795D30")]
		public List<Component> GFGJAALIDND(Type LIJLAEFJGCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x5795CB0", Offset = "0x57948B0", VA = "0x185795CB0", Slot = "4")]
		public bool Equals(ToolHierarchyCache FEMNKHHBNAG, ToolHierarchyCache FAKOIENNMNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x5795FE0", Offset = "0x5794BE0", VA = "0x185795FE0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache EBMPLNBFAKM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public class NGFDEPBPOLI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private int LAODCMGHKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private int EJELKKFGDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private List<T> FNLGPCALBEM;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x2191E80", Offset = "0x2190A80", VA = "0x182191E80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public T EIBNEFBIJLC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x28C4050", Offset = "0x28C2C50", VA = "0x1828C4050")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public T PANCKGNEMMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x28C41E0", Offset = "0x28C2DE0", VA = "0x1828C41E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public T GMBKJDIGGGO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x28C4380", Offset = "0x28C2F80", VA = "0x1828C4380")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x28C45D0", Offset = "0x28C31D0", VA = "0x1828C45D0")]
	public NGFDEPBPOLI(int LAODCMGHKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x28C44B0", Offset = "0x28C30B0", VA = "0x1828C44B0")]
	public void LFMPFEAFMAL(T BHHPLLKMOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x28C4590", Offset = "0x28C3190", VA = "0x1828C4590")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x28C4270", Offset = "0x28C2E70", VA = "0x1828C4270")]
	public void ILIPFMCADOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x28C4220", Offset = "0x28C2E20", VA = "0x1828C4220")]
	public void ELGMKPLGGCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x28C4580", Offset = "0x28C3180", VA = "0x1828C4580")]
	public void LMKDILFHNJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public class GNJJGIGKKHF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private bool JLKHHJJCOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private Action KINCGCMCJLI;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public static GNJJGIGKKHF JIGLPICGFAB
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x57905C0", Offset = "0x578F1C0", VA = "0x1857905C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool HBFALBKBGEA
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x6177B0", Offset = "0x6163B0", VA = "0x1806177B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x903C50", Offset = "0x902850", VA = "0x180903C50")]
	public GNJJGIGKKHF(Action KINCGCMCJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x5790640", Offset = "0x578F240", VA = "0x185790640")]
	public void KBJMPKKPODE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x5790640", Offset = "0x578F240", VA = "0x185790640", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class CMBHKBJAFAK
{
	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	public static void MFHEPCIJGJL(IPBJIJBMOIC JANGOMFIKHC, string NDCJGBKBHBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public class ECIFCCHELCL<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	private struct LLNFEEBNEOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public int FBJJFHGNIKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public T ONGHMHAEIAB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private readonly Dictionary<object, LLNFEEBNEOH> FIDLDDIAMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private T HIADKKONJNG;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public virtual T GDNLIFIOBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x18F47D0", Offset = "0x18F33D0", VA = "0x1818F47D0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x29C0480", Offset = "0x29BF080", VA = "0x1829C0480", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool OMPGBAADHPL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x29BA850", Offset = "0x29B9450", VA = "0x1829BA850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public object GJPOIKPHEMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDF0", Offset = "0x5ED9F0", VA = "0x1805EEDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x616D70", Offset = "0x615970", VA = "0x180616D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x29BAD30", Offset = "0x29B9930", VA = "0x1829BAD30")]
	public bool GDKIADOKKKE(T KGJOJGIPNPH, object KJKNLGILOFJ, int OPGMLDDCKPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x29BB740", Offset = "0x29BA340", VA = "0x1829BB740")]
	public bool HNCEHIKFEKB(object KJKNLGILOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x29BB170", Offset = "0x29B9D70", VA = "0x1829BB170")]
	public bool HMDEELNDPOI(object KJKNLGILOFJ, out T KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x29BB7B0", Offset = "0x29BA3B0", VA = "0x1829BB7B0")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x29BF070", Offset = "0x29BDC70", VA = "0x1829BF070")]
	private bool MAPHJCNHECL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x29C0500", Offset = "0x29BF100", VA = "0x1829C0500")]
	public ECIFCCHELCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public class ODANDHLOFGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private Dictionary<object, float> FIDLDDIAMFE;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public float NLIPLGDCFIB
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x124C640", Offset = "0x124B240", VA = "0x18124C640")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xE3F130", Offset = "0xE3DD30", VA = "0x180E3F130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x57932A0", Offset = "0x5791EA0", VA = "0x1857932A0")]
	public void GDKIADOKKKE(float KGJOJGIPNPH, object KJKNLGILOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x5793430", Offset = "0x5792030", VA = "0x185793430")]
	public void HNCEHIKFEKB(object KJKNLGILOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x5793310", Offset = "0x5791F10", VA = "0x185793310")]
	private void GMFHFDLCEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x57934A0", Offset = "0x57920A0", VA = "0x1857934A0")]
	public ODANDHLOFGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public class ODJMLBBJHBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public readonly string GFNEENJFIHJ;

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x721660", Offset = "0x720260", VA = "0x180721660")]
	public ODJMLBBJHBE(string MGDKFOCPJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x5793570", Offset = "0x5792170", VA = "0x185793570")]
	public ODJMLBBJHBE(UnityEngine.Object IICMDBDCOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x5793520", Offset = "0x5792120", VA = "0x185793520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class IPBJIJBMOIC
{
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class AMBHLCNCFNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public AMBHLCNCFNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x578CAA0", Offset = "0x578B6A0", VA = "0x18578CAA0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private HashSet<object> GOGFKMJANKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private int LOMFENPACDA;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public IReadOnlyCollection<object> AMLIANGLAJF
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x5791820", Offset = "0x5790420", VA = "0x185791820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool AHFDEKHIGMC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x5791750", Offset = "0x5790350", VA = "0x185791750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x678670", Offset = "0x677270", VA = "0x180678670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x5791760", Offset = "0x5790360", VA = "0x185791760")]
	public bool LFMPFEAFMAL(object KJKNLGILOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x57916C0", Offset = "0x57902C0", VA = "0x1857916C0")]
	public bool JNIHJKFEBJI(object KJKNLGILOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x5791600", Offset = "0x5790200", VA = "0x185791600")]
	public bool ACOKKIFAPKJ(object KJKNLGILOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x5791660", Offset = "0x5790260", VA = "0x185791660")]
	public void AODFPNJDIJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x57918F0", Offset = "0x57904F0", VA = "0x1857918F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public IPBJIJBMOIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public class HGONKAADFGN<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	private struct DADEBJJGJDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public float NCALJMHDMEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public T ONGHMHAEIAB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private Dictionary<object, DADEBJJGJDN> FIDLDDIAMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private T LOKELEMIBJP;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public virtual T EAICDHNLEDM
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x19DBEA0", Offset = "0x19DAAA0", VA = "0x1819DBEA0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x19DB620", Offset = "0x19DA220", VA = "0x1819DB620", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public object ICHHGIAGPFH
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x614A30", Offset = "0x613630", VA = "0x180614A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x724880", Offset = "0x723480", VA = "0x180724880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public bool OMPGBAADHPL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x3A5AF10", Offset = "0x3A59B10", VA = "0x183A5AF10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x3A5B420", Offset = "0x3A5A020", VA = "0x183A5B420")]
	public bool GDKIADOKKKE(T KGJOJGIPNPH, object KJKNLGILOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x3A5B7A0", Offset = "0x3A5A3A0", VA = "0x183A5B7A0")]
	public bool HNCEHIKFEKB(object KJKNLGILOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x29BB7B0", Offset = "0x29BA3B0", VA = "0x1829BB7B0")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x3A5B520", Offset = "0x3A5A120", VA = "0x183A5B520")]
	public bool HMDEELNDPOI(object KJKNLGILOFJ, out T KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x3A5BE70", Offset = "0x3A5AA70", VA = "0x183A5BE70")]
	private bool MAPHJCNHECL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x3A5D060", Offset = "0x3A5BC60", VA = "0x183A5D060")]
	public HGONKAADFGN()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class GGMACBOFMDA
{
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private static byte[] HNILJCLIGCF;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private static int MHDNNHPLAAF;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static int JKLLCIMILJG;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private static BigInteger JLHIBEKHFGK;

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public GGMACBOFMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x5790200", Offset = "0x578EE00", VA = "0x185790200")]
	private static string PBMOEILNFIF(byte[] EDLPJGEPJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x578FED0", Offset = "0x578EAD0", VA = "0x18578FED0")]
	public static string EICDLCDOCAE(byte[] IAIFCDOPKGE, bool LFDDCGMHEMH)
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
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
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
