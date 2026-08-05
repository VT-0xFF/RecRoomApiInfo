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
public class KHGCHOJPEPO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xBA69F0", Offset = "0xBA5BF0", VA = "0x180BA69F0")]
	public KHGCHOJPEPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, EDJIOCIKNEJ, JMIIPNGAANF, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FFB00", Offset = "0x6FED00", VA = "0x1806FFB00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7BB020", Offset = "0x7BA220", VA = "0x1807BB020", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85CB60", VA = "0x18085D960", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash NDFMMDHCKFC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F9FF0", Offset = "0x6F91F0", VA = "0x1806F9FF0")]
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
	[EFEFIKFHIDK]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[EFEFIKFHIDK]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6625900", Offset = "0x6624B00", VA = "0x186625900")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x66258C0", Offset = "0x6624AC0", VA = "0x1866258C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6625940", Offset = "0x6624B40", VA = "0x186625940")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6625B10", Offset = "0x6624D10", VA = "0x186625B10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6625A80", Offset = "0x6624C80", VA = "0x186625A80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xB53E30", Offset = "0xB53030", VA = "0x180B53E30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xB53E20", Offset = "0xB53020", VA = "0x180B53E20")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6625880", Offset = "0x6624A80", VA = "0x186625880")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x66259F0", Offset = "0x6624BF0", VA = "0x1866259F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x66252C0", Offset = "0x66244C0", VA = "0x1866252C0")]
	public void CopyBounds(SavedExtents HNPEBINPOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x66257E0", Offset = "0x66249E0", VA = "0x1866257E0")]
	public void SetLocalSpaceBounds(Bounds IOKMCLEJIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xF3ACA0", Offset = "0xF39EA0", VA = "0x180F3ACA0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x66257D0", Offset = "0x66249D0", VA = "0x1866257D0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x66253B0", Offset = "0x66245B0", VA = "0x1866253B0")]
	private void MELBHNMBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x66255A0", Offset = "0x66247A0", VA = "0x1866255A0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6624C80", Offset = "0x6623E80", VA = "0x186624C80")]
	public static void CalculateLocalBoundsFor(GameObject BMNLOPDIJGF, out Bounds IOKMCLEJIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x66252F0", Offset = "0x66244F0", VA = "0x1866252F0")]
	private static void KMKMIGOHGCG(Bounds EFNJCAIBDLA, Color DHNNLHJMKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6625800", Offset = "0x6624A00", VA = "0x186625800")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F6400", Offset = "0x6F5600", VA = "0x1806F6400")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7E49D0", Offset = "0x7E3BD0", VA = "0x1807E49D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x879DF0", Offset = "0x878FF0", VA = "0x180879DF0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1BE7FB0", Offset = "0x1BE71B0", VA = "0x181BE7FB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "4")]
	public virtual void NCDEMEJJJGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
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
	[KHGCHOJPEPO]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x29DBD50", Offset = "0x29DAF50", VA = "0x1829DBD50", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x29DB480", Offset = "0x29DA680", VA = "0x1829DB480", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x29DC290", Offset = "0x29DB490", VA = "0x1829DC290")]
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
	private sealed class NGAHMECFHPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public NGAHMECFHPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2777360", Offset = "0x2776560", VA = "0x182777360")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[KHGCHOJPEPO]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x895BC0", Offset = "0x894DC0", VA = "0x180895BC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x895BF0", Offset = "0x894DF0", VA = "0x180895BF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x895B10", Offset = "0x894D10", VA = "0x180895B10", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey FDAIMOMOHIG]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x895B70", Offset = "0x894D70", VA = "0x180895B70", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x895A10", Offset = "0x894C10", VA = "0x180895A10", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x895560", Offset = "0x894760", VA = "0x180895560", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x894D80", Offset = "0x893F80", VA = "0x180894D80", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x894A00", Offset = "0x893C00", VA = "0x180894A00", Slot = "14")]
	protected virtual string JEBHFECOOHJ(TKeyVal OJLALMPBEAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x894910", Offset = "0x893B10", VA = "0x180894910", Slot = "4")]
	public bool ContainsKey(TKey FDAIMOMOHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x895900", Offset = "0x894B00", VA = "0x180895900", Slot = "5")]
	public bool TryGetValue(TKey FDAIMOMOHIG, out TVal IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x894940", Offset = "0x893B40", VA = "0x180894940", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x894940", Offset = "0x893B40", VA = "0x180894940", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x895930", Offset = "0x894B30", VA = "0x180895930")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class IOFCIGCGOBM<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class PHFAMIHGAMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public PHFAMIHGAMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x30DBA70", Offset = "0x30DAC70", VA = "0x1830DBA70")]
		internal bool <GetSamples>b__0(global::HBBHKKBNKHE<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float FBKONKABACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float OPNPCAJEEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::HBBHKKBNKHE<float, T>> DOEIKJEAMPB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int CFLAAOMNKLF
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1B437A0", Offset = "0x1B429A0", VA = "0x181B437A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1B44280", Offset = "0x1B43480", VA = "0x181B44280")]
	public IOFCIGCGOBM(float JCDHGFKOFCF, float JOLJCKJIPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1B439E0", Offset = "0x1B42BE0", VA = "0x181B439E0")]
	public bool IIMKAEJLKKM(float BBGNJMKOHPL, T IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1B43820", Offset = "0x1B42A20", VA = "0x181B43820")]
	public int HPHFJICHDFM(float BBGNJMKOHPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1B43F40", Offset = "0x1B43140", VA = "0x181B43F40")]
	public IEnumerable<T> NEOCENOBKFP(float BBGNJMKOHPL, [Optional] float? OGDOCILDNIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1B436F0", Offset = "0x1B428F0", VA = "0x181B436F0")]
	public void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1B43B40", Offset = "0x1B42D40", VA = "0x181B43B40")]
	private void MPNECAFPKMC(float BBGNJMKOHPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class OENGILJIKEA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct FHNIOEBHJAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T LKDHJKNGKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float KJFMJKBBIGN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float AEIBAHPHNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> ECFJIFMCEDO;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int LGNLCILHEGG = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private FHNIOEBHJAD[] HAHPMNMCEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int HJKMGMBILCI;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float DOGLHJKIHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x702430", Offset = "0x701630", VA = "0x180702430")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x886540", Offset = "0x885740", VA = "0x180886540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2A33740", Offset = "0x2A32940", VA = "0x182A33740")]
	public OENGILJIKEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2A33770", Offset = "0x2A32970", VA = "0x182A33770")]
	public OENGILJIKEA(int CAPKFCHDLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2A32BD0", Offset = "0x2A31DD0", VA = "0x182A32BD0")]
	public void CPCILMEHKPA(float BBGNJMKOHPL, T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2A32FD0", Offset = "0x2A321D0", VA = "0x182A32FD0")]
	public void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2A32660", Offset = "0x2A31860", VA = "0x182A32660")]
	public bool AEKCMGLHLOA(float HDGFHFCPNPD, float FJKIDPPLMMJ, out T IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2A33420", Offset = "0x2A32620", VA = "0x182A33420")]
	public bool MEJFEEKMPFC(float HDGFHFCPNPD, float FJKIDPPLMMJ, out T IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2A32860", Offset = "0x2A31A60", VA = "0x182A32860")]
	public void CHOCNDFLNGN(float HDGFHFCPNPD, float FJKIDPPLMMJ, List<T> ACMMHKGMFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2A32E50", Offset = "0x2A32050", VA = "0x182A32E50")]
	private int DEHJCLFKPJC(int PAGIFJDLMNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2A32820", Offset = "0x2A31A20", VA = "0x182A32820")]
	private void CBPHLIHLOAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GHDKNLLCPCI();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T LCPAMALNCPJ(T BLFKABPCHLN, T NPFMAENOPCH, float IHPJCBCPLCM);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T EAFCCNDHBHA(T IPMIIEAGJKC, float IHPJCBCPLCM);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T JHBCPNGFCNI(T BLFKABPCHLN, T NPFMAENOPCH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T JBOECCOKDEF(T BLFKABPCHLN, T NPFMAENOPCH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PFPHHBKDIOO : global::OENGILJIKEA<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xCB54E0", Offset = "0xCB46E0", VA = "0x180CB54E0", Slot = "4")]
	protected override Vector3 GHDKNLLCPCI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x199C9A0", Offset = "0x199BBA0", VA = "0x18199C9A0", Slot = "5")]
	protected override Vector3 LCPAMALNCPJ(Vector3 BLFKABPCHLN, Vector3 NPFMAENOPCH, float IHPJCBCPLCM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6622870", Offset = "0x6621A70", VA = "0x186622870", Slot = "6")]
	protected override Vector3 EAFCCNDHBHA(Vector3 IPMIIEAGJKC, float IHPJCBCPLCM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6622940", Offset = "0x6621B40", VA = "0x186622940", Slot = "7")]
	protected override Vector3 JHBCPNGFCNI(Vector3 BLFKABPCHLN, Vector3 NPFMAENOPCH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x66228D0", Offset = "0x6621AD0", VA = "0x1866228D0", Slot = "8")]
	protected override Vector3 JBOECCOKDEF(Vector3 BLFKABPCHLN, Vector3 NPFMAENOPCH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x66229C0", Offset = "0x6621BC0", VA = "0x1866229C0")]
	public PFPHHBKDIOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KJKFGMJOOBD : global::OENGILJIKEA<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6620900", Offset = "0x661FB00", VA = "0x186620900")]
	public KJKFGMJOOBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6620890", Offset = "0x661FA90", VA = "0x186620890")]
	public KJKFGMJOOBD(int CAPKFCHDLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x908D40", Offset = "0x907F40", VA = "0x180908D40", Slot = "4")]
	protected override float GHDKNLLCPCI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x34A21F0", Offset = "0x34A13F0", VA = "0x1834A21F0", Slot = "5")]
	protected override float LCPAMALNCPJ(float BLFKABPCHLN, float NPFMAENOPCH, float IHPJCBCPLCM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x51E21A0", Offset = "0x51E13A0", VA = "0x1851E21A0", Slot = "6")]
	protected override float EAFCCNDHBHA(float IPMIIEAGJKC, float IHPJCBCPLCM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2E3D9A0", Offset = "0x2E3CBA0", VA = "0x182E3D9A0", Slot = "7")]
	protected override float JHBCPNGFCNI(float BLFKABPCHLN, float NPFMAENOPCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6620880", Offset = "0x661FA80", VA = "0x186620880", Slot = "8")]
	protected override float JBOECCOKDEF(float BLFKABPCHLN, float NPFMAENOPCH)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CALFHGEJPCK
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1151550", Offset = "0x1150750", VA = "0x181151550")]
	public static global::EAFFHMLGHGC<T1> GPGHDDABLEF<T1>(T1 DBADPPPFPNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1150FE0", Offset = "0x11501E0", VA = "0x181150FE0")]
	public static global::HBBHKKBNKHE<T1, T2> GPGHDDABLEF<T1, T2>(T1 DBADPPPFPNC, T2 EHNKCGFAPEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1151050", Offset = "0x1150250", VA = "0x181151050")]
	public static global::ENCPCMGEBCL<T1, T2, T3> GPGHDDABLEF<T1, T2, T3>(T1 DBADPPPFPNC, T2 EHNKCGFAPEG, T3 JFEAKLCCCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x11513C0", Offset = "0x11505C0", VA = "0x1811513C0")]
	public static global::KCCKBBJOLIE<T1, T2, T3, T4> GPGHDDABLEF<T1, T2, T3, T4>(T1 DBADPPPFPNC, T2 EHNKCGFAPEG, T3 JFEAKLCCCGE, T4 NFDIECMCHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1151320", Offset = "0x1150520", VA = "0x181151320")]
	public static global::GILFODFNMFH<T1, T2, T3, T4, T5> GPGHDDABLEF<T1, T2, T3, T4, T5>(T1 DBADPPPFPNC, T2 EHNKCGFAPEG, T3 JFEAKLCCCGE, T4 NFDIECMCHHO, T5 PJLMKHNPPBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1151270", Offset = "0x1150470", VA = "0x181151270")]
	public static global::PJPEADABEEF<T1, T2, T3, T4, T5, T6> GPGHDDABLEF<T1, T2, T3, T4, T5, T6>(T1 DBADPPPFPNC, T2 EHNKCGFAPEG, T3 JFEAKLCCCGE, T4 NFDIECMCHHO, T5 PJLMKHNPPBB, T6 HCJCKEIBJAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x11511B0", Offset = "0x11503B0", VA = "0x1811511B0")]
	public static global::GFPNGJPIEPK<T1, T2, T3, T4, T5, T6, T7> GPGHDDABLEF<T1, T2, T3, T4, T5, T6, T7>(T1 DBADPPPFPNC, T2 EHNKCGFAPEG, T3 JFEAKLCCCGE, T4 NFDIECMCHHO, T5 PJLMKHNPPBB, T6 HCJCKEIBJAM, T7 HAMCEMELIBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x11510E0", Offset = "0x11502E0", VA = "0x1811510E0")]
	public static global::NDMHDHMIGKB<T1, T2, T3, T4, T5, T6, T7, T8> GPGHDDABLEF<T1, T2, T3, T4, T5, T6, T7, T8>(T1 DBADPPPFPNC, T2 EHNKCGFAPEG, T3 JFEAKLCCCGE, T4 NFDIECMCHHO, T5 PJLMKHNPPBB, T6 HCJCKEIBJAM, T7 HAMCEMELIBF, T8 GJCEHMMGEND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xEEE4C0", Offset = "0xEED6C0", VA = "0x180EEE4C0")]
	[IteratorStateMachine(typeof(JMOMFCJNKOO))]
	public static IEnumerable<global::HBBHKKBNKHE<T1, T2>> KGDKNEJOBLF<T1, T2>(IEnumerable<T1> NNMPJECKECI, IEnumerable<T2> EFNJCAIBDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xEEE600", Offset = "0xEED800", VA = "0x180EEE600")]
	[IteratorStateMachine(typeof(BFDFHKHDALB))]
	public static IEnumerable<global::ENCPCMGEBCL<T1, T2, T3>> KGDKNEJOBLF<T1, T2, T3>(IEnumerable<T1> NNMPJECKECI, IEnumerable<T2> EFNJCAIBDLA, IEnumerable<T3> DHNNLHJMKIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x249F900", Offset = "0x249EB00", VA = "0x18249F900")]
	internal static int KMBNJFLGEJM(int PFMLIDFBHKC, int CFNKLIMPEDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3D91270", Offset = "0x3D90470", VA = "0x183D91270")]
	internal static int KMBNJFLGEJM(int PFMLIDFBHKC, int CFNKLIMPEDG, int IPPPPBLHFDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3D91250", Offset = "0x3D90450", VA = "0x183D91250")]
	internal static int KMBNJFLGEJM(int PFMLIDFBHKC, int CFNKLIMPEDG, int IPPPPBLHFDJ, int GGMHJCPIOMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3D91280", Offset = "0x3D90480", VA = "0x183D91280")]
	internal static int KMBNJFLGEJM(int PFMLIDFBHKC, int CFNKLIMPEDG, int IPPPPBLHFDJ, int GGMHJCPIOMD, int INCJOAJKPJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x661D2F0", Offset = "0x661C4F0", VA = "0x18661D2F0")]
	internal static int KMBNJFLGEJM(int PFMLIDFBHKC, int CFNKLIMPEDG, int IPPPPBLHFDJ, int GGMHJCPIOMD, int INCJOAJKPJH, int EODDNNHCFAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x661D2C0", Offset = "0x661C4C0", VA = "0x18661D2C0")]
	internal static int KMBNJFLGEJM(int PFMLIDFBHKC, int CFNKLIMPEDG, int IPPPPBLHFDJ, int GGMHJCPIOMD, int INCJOAJKPJH, int EODDNNHCFAG, int MGKHCEJFGJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x661D290", Offset = "0x661C490", VA = "0x18661D290")]
	internal static int KMBNJFLGEJM(int PFMLIDFBHKC, int CFNKLIMPEDG, int IPPPPBLHFDJ, int GGMHJCPIOMD, int INCJOAJKPJH, int EODDNNHCFAG, int MGKHCEJFGJH, int FPBAMFLFGDL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EAFFHMLGHGC<T1> : IComparable<global::EAFFHMLGHGC<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 JLGKOBLGBLM;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1B3B7F0", Offset = "0x1B3A9F0", VA = "0x181B3B7F0")]
	public EAFFHMLGHGC(T1 DBADPPPFPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x238C9A0", Offset = "0x238BBA0", VA = "0x18238C9A0", Slot = "4")]
	public int CompareTo(global::EAFFHMLGHGC<T1> HNPEBINPOBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x238CA10", Offset = "0x238BC10", VA = "0x18238CA10", Slot = "0")]
	public override bool Equals(object HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x238CAB0", Offset = "0x238BCB0", VA = "0x18238CAB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x238CAE0", Offset = "0x238BCE0", VA = "0x18238CAE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HBBHKKBNKHE<T1, T2> : IComparable<global::HBBHKKBNKHE<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 JLGKOBLGBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 FNGLGFJJJOF;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x213B880", Offset = "0x213AA80", VA = "0x18213B880")]
	public HBBHKKBNKHE(T1 DBADPPPFPNC, T2 EHNKCGFAPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3665710", Offset = "0x3664910", VA = "0x183665710", Slot = "4")]
	public int CompareTo(global::HBBHKKBNKHE<T1, T2> HNPEBINPOBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x36657D0", Offset = "0x36649D0", VA = "0x1836657D0", Slot = "0")]
	public override bool Equals(object HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3666470", Offset = "0x3665670", VA = "0x183666470", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x36670B0", Offset = "0x36662B0", VA = "0x1836670B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ENCPCMGEBCL<T1, T2, T3> : IComparable<global::ENCPCMGEBCL<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 JLGKOBLGBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 FNGLGFJJJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 NPEGHGPOEEL;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x27EF150", Offset = "0x27EE350", VA = "0x1827EF150")]
	public ENCPCMGEBCL(T1 DBADPPPFPNC, T2 EHNKCGFAPEG, T3 JFEAKLCCCGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x27EE940", Offset = "0x27EDB40", VA = "0x1827EE940", Slot = "4")]
	public int CompareTo(global::ENCPCMGEBCL<T1, T2, T3> HNPEBINPOBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x27EEB40", Offset = "0x27EDD40", VA = "0x1827EEB40", Slot = "0")]
	public override bool Equals(object HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x27EEE30", Offset = "0x27EE030", VA = "0x1827EEE30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x27EEE90", Offset = "0x27EE090", VA = "0x1827EEE90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class KCCKBBJOLIE<T1, T2, T3, T4> : IComparable<global::KCCKBBJOLIE<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 JLGKOBLGBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 FNGLGFJJJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 NPEGHGPOEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 LNPKCLEBOFG;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1BA9580", Offset = "0x1BA8780", VA = "0x181BA9580")]
	public KCCKBBJOLIE(T1 DBADPPPFPNC, T2 EHNKCGFAPEG, T3 JFEAKLCCCGE, T4 NFDIECMCHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x21621E0", Offset = "0x21613E0", VA = "0x1821621E0", Slot = "4")]
	public int CompareTo(global::KCCKBBJOLIE<T1, T2, T3, T4> HNPEBINPOBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2162320", Offset = "0x2161520", VA = "0x182162320", Slot = "0")]
	public override bool Equals(object HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2162440", Offset = "0x2161640", VA = "0x182162440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2162500", Offset = "0x2161700", VA = "0x182162500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GILFODFNMFH<T1, T2, T3, T4, T5> : IComparable<global::GILFODFNMFH<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 JLGKOBLGBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 FNGLGFJJJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 NPEGHGPOEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 LNPKCLEBOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 KKGHOAKFCLD;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2FF3370", Offset = "0x2FF2570", VA = "0x182FF3370")]
	public GILFODFNMFH(T1 DBADPPPFPNC, T2 EHNKCGFAPEG, T3 JFEAKLCCCGE, T4 NFDIECMCHHO, T5 PJLMKHNPPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2FF2E60", Offset = "0x2FF2060", VA = "0x182FF2E60", Slot = "4")]
	public int CompareTo(global::GILFODFNMFH<T1, T2, T3, T4, T5> HNPEBINPOBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2FF2FE0", Offset = "0x2FF21E0", VA = "0x182FF2FE0", Slot = "0")]
	public override bool Equals(object HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2FF3120", Offset = "0x2FF2320", VA = "0x182FF3120", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2FF3220", Offset = "0x2FF2420", VA = "0x182FF3220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class PJPEADABEEF<T1, T2, T3, T4, T5, T6> : IComparable<global::PJPEADABEEF<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 JLGKOBLGBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 FNGLGFJJJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 NPEGHGPOEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 LNPKCLEBOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 KKGHOAKFCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 PJJIOCIIKLO;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC950", Offset = "0x2BEBB50", VA = "0x182BEC950")]
	public PJPEADABEEF(T1 DBADPPPFPNC, T2 EHNKCGFAPEG, T3 JFEAKLCCCGE, T4 NFDIECMCHHO, T5 PJLMKHNPPBB, T6 HCJCKEIBJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC390", Offset = "0x2BEB590", VA = "0x182BEC390", Slot = "4")]
	public int CompareTo(global::PJPEADABEEF<T1, T2, T3, T4, T5, T6> HNPEBINPOBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC550", Offset = "0x2BEB750", VA = "0x182BEC550", Slot = "0")]
	public override bool Equals(object HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC6C0", Offset = "0x2BEB8C0", VA = "0x182BEC6C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC7E0", Offset = "0x2BEB9E0", VA = "0x182BEC7E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GFPNGJPIEPK<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::GFPNGJPIEPK<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 JLGKOBLGBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 FNGLGFJJJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 NPEGHGPOEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 LNPKCLEBOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 KKGHOAKFCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 PJJIOCIIKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 NMPJHNHGJJM;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1730", Offset = "0x2FF0930", VA = "0x182FF1730")]
	public GFPNGJPIEPK(T1 DBADPPPFPNC, T2 EHNKCGFAPEG, T3 JFEAKLCCCGE, T4 NFDIECMCHHO, T5 PJLMKHNPPBB, T6 HCJCKEIBJAM, T7 HAMCEMELIBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2FF10B0", Offset = "0x2FF02B0", VA = "0x182FF10B0", Slot = "4")]
	public int CompareTo(global::GFPNGJPIEPK<T1, T2, T3, T4, T5, T6, T7> HNPEBINPOBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2FF12B0", Offset = "0x2FF04B0", VA = "0x182FF12B0", Slot = "0")]
	public override bool Equals(object HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1450", Offset = "0x2FF0650", VA = "0x182FF1450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2FF15A0", Offset = "0x2FF07A0", VA = "0x182FF15A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NDMHDHMIGKB<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::NDMHDHMIGKB<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 JLGKOBLGBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 FNGLGFJJJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 NPEGHGPOEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 LNPKCLEBOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 KKGHOAKFCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 PJJIOCIIKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 NMPJHNHGJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 DCIHAHMKPBB;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x24B4840", Offset = "0x24B3A40", VA = "0x1824B4840")]
	public NDMHDHMIGKB(T1 DBADPPPFPNC, T2 EHNKCGFAPEG, T3 JFEAKLCCCGE, T4 NFDIECMCHHO, T5 PJLMKHNPPBB, T6 HCJCKEIBJAM, T7 HAMCEMELIBF, T8 GJCEHMMGEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x24B4110", Offset = "0x24B3310", VA = "0x1824B4110", Slot = "4")]
	public int CompareTo(global::NDMHDHMIGKB<T1, T2, T3, T4, T5, T6, T7, T8> HNPEBINPOBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x24B4360", Offset = "0x24B3560", VA = "0x1824B4360", Slot = "0")]
	public override bool Equals(object HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x24B4520", Offset = "0x24B3720", VA = "0x1824B4520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x24B4690", Offset = "0x24B3890", VA = "0x1824B4690", Slot = "3")]
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
	public T LKDHJKNGKHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x32913E0", Offset = "0x32905E0", VA = "0x1832913E0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x32913F0", Offset = "0x32905F0", VA = "0x1832913F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float KDLBMNHMFDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6D0", Offset = "0xAAA8D0", VA = "0x180AAB6D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3CCF5A0", Offset = "0x3CCE7A0", VA = "0x183CCF5A0")]
	public T CONCMILKFON(float IHPJCBCPLCM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3CCF840", Offset = "0x3CCEA40", VA = "0x183CCF840")]
	public T HPBKEOLEGAO(float IHPJCBCPLCM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LCPAMALNCPJ(T BLFKABPCHLN, T NPFMAENOPCH, float IHPJCBCPLCM);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x34A21F0", Offset = "0x34A13F0", VA = "0x1834A21F0", Slot = "4")]
	protected override float LCPAMALNCPJ(float BLFKABPCHLN, float NPFMAENOPCH, float IHPJCBCPLCM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x661E880", Offset = "0x661DA80", VA = "0x18661E880")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x199C9A0", Offset = "0x199BBA0", VA = "0x18199C9A0", Slot = "4")]
	protected override Vector3 LCPAMALNCPJ(Vector3 BLFKABPCHLN, Vector3 NPFMAENOPCH, float IHPJCBCPLCM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6626A20", Offset = "0x6625C20", VA = "0x186626A20")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x661D7B0", Offset = "0x661C9B0", VA = "0x18661D7B0", Slot = "4")]
	protected override Color LCPAMALNCPJ(Color BLFKABPCHLN, Color NPFMAENOPCH, float IHPJCBCPLCM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x661D800", Offset = "0x661CA00", VA = "0x18661D800")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GMJGFOEIDJB : global::IDEIBFFIHHC<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x661F520", Offset = "0x661E720", VA = "0x18661F520")]
	public GMJGFOEIDJB(int FAPOEIDOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x661F570", Offset = "0x661E770", VA = "0x18661F570")]
	public GMJGFOEIDJB(PMJFLPOGIBH[] KBAHNGPHOHC, bool JNACAGIJMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x661F4B0", Offset = "0x661E6B0", VA = "0x18661F4B0", Slot = "6")]
	protected override uint BAJBPHKGPAG(uint NDFMMDHCKFC, string IPMIIEAGJKC)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class AJEDCBAKPED : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public AJEDCBAKPED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct JEKNBGHMBJN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class AGFLGKNEAOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public AGFLGKNEAOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x23B8350", Offset = "0x23B7550", VA = "0x1823B8350")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> CIAGJOLODAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int BHOAMBFMFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int MIJNLNGJCFL;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x24A0360", Offset = "0x249F560", VA = "0x1824A0360")]
	private JEKNBGHMBJN(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> BFCHNDOOGIL, int HOKNJJMGDMH, int AMGNCPLIAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2BD80D0", Offset = "0x2BD72D0", VA = "0x182BD80D0")]
	public static global::JEKNBGHMBJN<T> ELCFDEFNBDD()
	{
		return default(global::JEKNBGHMBJN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2BD88F0", Offset = "0x2BD7AF0", VA = "0x182BD88F0")]
	public (int, int, Task<T>) LFDILEDDBFL(int AMMLAHNGBBA, [Optional] CancellationToken NDKAKDJMDIF, double BGGBEMDBOHE = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2BD7BC0", Offset = "0x2BD6DC0", VA = "0x182BD7BC0")]
	public void DAFPENHFOMC(int AMMLAHNGBBA, int AMGNCPLIAAC, in T CDNLFEOBNKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class CEOKEDANLEG
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x661D5C0", Offset = "0x661C7C0", VA = "0x18661D5C0")]
	public static global::JEKNBGHMBJN<MFEHAEMCKCJ> ELCFDEFNBDD()
	{
		return default(global::JEKNBGHMBJN<MFEHAEMCKCJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x661D540", Offset = "0x661C740", VA = "0x18661D540")]
	public static void DAFPENHFOMC(this in global::JEKNBGHMBJN<MFEHAEMCKCJ> DIJPFIMLAFB, int AMMLAHNGBBA, int AMGNCPLIAAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class NNHJCDEPLCG<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> AACEKHEIADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> BKBILMBHEJH;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1932D80", Offset = "0x1931F80", VA = "0x181932D80", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool NNJLEOOEELM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> MDKPNDACNBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x20AA880", Offset = "0x20A9A80", VA = "0x1820AA880", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> PAMDCECBKIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x23F2E80", Offset = "0x23F2080", VA = "0x1823F2E80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x23F2E40", Offset = "0x23F2040", VA = "0x1823F2E40", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x23F2EE0", Offset = "0x23F20E0", VA = "0x1823F2EE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x23F2BA0", Offset = "0x23F1DA0", VA = "0x1823F2BA0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x23F1CA0", Offset = "0x23F0EA0", VA = "0x1823F1CA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x23F1E50", Offset = "0x23F1050", VA = "0x1823F1E50", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x23F2CC0", Offset = "0x23F1EC0", VA = "0x1823F2CC0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x23F1AD0", Offset = "0x23F0CD0", VA = "0x1823F1AD0", Slot = "9")]
	public void Add(TKey FDAIMOMOHIG, TVal IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x23F1B10", Offset = "0x23F0D10", VA = "0x1823F1B10", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> ONCGIPFNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x23F1EB0", Offset = "0x23F10B0", VA = "0x1823F1EB0", Slot = "8")]
	public bool ContainsKey(TKey FDAIMOMOHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x23F1F10", Offset = "0x23F1110", VA = "0x1823F1F10", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> ONCGIPFNENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x23F2BE0", Offset = "0x23F1DE0", VA = "0x1823F2BE0", Slot = "10")]
	public bool Remove(TKey FDAIMOMOHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x23F2C40", Offset = "0x23F1E40", VA = "0x1823F2C40", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> ONCGIPFNENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x21BA700", Offset = "0x21B9900", VA = "0x1821BA700", Slot = "11")]
	public bool TryGetValue(TKey FDAIMOMOHIG, out TVal IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x23F2200", Offset = "0x23F1400", VA = "0x1823F2200", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x23F1F70", Offset = "0x23F1170", VA = "0x1823F1F70", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] HAHPMNMCEBD, int PBNJDHGCIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x23F1E10", Offset = "0x23F1010", VA = "0x1823F1E10")]
	public void CPCILMEHKPA(TVal DGAGNFOEEIJ, TKey FDAIMOMOHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x23F1DD0", Offset = "0x23F0FD0", VA = "0x1823F1DD0")]
	public void CPCILMEHKPA(KeyValuePair<TVal, TKey> ONCGIPFNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x23F2950", Offset = "0x23F1B50", VA = "0x1823F2950")]
	public bool OPHJCIKACBI(TVal FDAIMOMOHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x23F1BB0", Offset = "0x23F0DB0", VA = "0x1823F1BB0")]
	public bool BPCENLKELKP(KeyValuePair<TVal, TKey> ONCGIPFNENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x23F28B0", Offset = "0x23F1AB0", VA = "0x1823F28B0")]
	public bool MILDLLFOGOM(TVal FDAIMOMOHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x23F28B0", Offset = "0x23F1AB0", VA = "0x1823F28B0")]
	public bool MILDLLFOGOM(KeyValuePair<TVal, TKey> ONCGIPFNENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x23F22B0", Offset = "0x23F14B0", VA = "0x1823F22B0")]
	public bool HOAIDNCFMEI(TVal FDAIMOMOHIG, out TKey IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x23F22F0", Offset = "0x23F14F0", VA = "0x1823F22F0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> IEJEJLPOBFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x23F20E0", Offset = "0x23F12E0", VA = "0x1823F20E0")]
	private void DMPCGHMBOKB(TKey FDAIMOMOHIG, TVal DGAGNFOEEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x23F2AD0", Offset = "0x23F1CD0", VA = "0x1823F2AD0")]
	private void PBDMDGNJOKE(TKey FDAIMOMOHIG, TVal DGAGNFOEEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x23F27E0", Offset = "0x23F19E0", VA = "0x1823F27E0")]
	private bool JHLKPHEHNHA(TKey FDAIMOMOHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x23F24C0", Offset = "0x23F16C0", VA = "0x1823F24C0")]
	private bool JHLKPHEHNHA(TVal DGAGNFOEEIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x23F2D60", Offset = "0x23F1F60", VA = "0x1823F2D60")]
	public NNHJCDEPLCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class DOMOOLBLFAH<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::DOMOOLBLFAH<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6140", Offset = "0x2AE5340", VA = "0x182AE6140", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AE6FE0", Offset = "0x2AE61E0", VA = "0x182AE6FE0")]
		public Enumerator(global::DOMOOLBLFAH<T> ACMMHKGMFIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0DB0", Offset = "0x2ADFFB0", VA = "0x182AE0DB0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3820", Offset = "0x2AE2A20", VA = "0x182AE3820", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF400", Offset = "0x2ADE600", VA = "0x182ADF400")]
		private void FPHOHOEDKGD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] JGHJLJLPGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int JDHIICINABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int FNDKHFCCKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int EOGFAFNNICF;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3C190F0", Offset = "0x3C182F0", VA = "0x183C190F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3C1A1E0", Offset = "0x3C193E0", VA = "0x183C1A1E0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3C19260", Offset = "0x3C18460", VA = "0x183C19260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3C1A400", Offset = "0x3C19600", VA = "0x183C1A400")]
	public DOMOOLBLFAH(int FAPOEIDOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3C19490", Offset = "0x3C18690", VA = "0x183C19490")]
	public void CPCILMEHKPA(T IHPJCBCPLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3C18DD0", Offset = "0x3C17FD0", VA = "0x183C18DD0")]
	public void AKIKAHMEOBL(IEnumerable<T> IIGHOHLJPIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3C19B10", Offset = "0x3C18D10", VA = "0x183C19B10")]
	public void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3C19B30", Offset = "0x3C18D30", VA = "0x183C19B30")]
	public void KCEDAMAMKFN(int BFFJHKFEFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3C196C0", Offset = "0x3C188C0", VA = "0x183C196C0")]
	public void EKKJODMOCLI(int BFFJHKFEFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3C19D10", Offset = "0x3C18F10", VA = "0x183C19D10")]
	public void PEBLHKOPNAC(T[] HAHPMNMCEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3C19130", Offset = "0x3C18330", VA = "0x183C19130")]
	public Enumerator BECNODPGHJK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3C1A380", Offset = "0x3C19580", VA = "0x183C1A380", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3C1A380", Offset = "0x3C19580", VA = "0x183C1A380", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3C19A20", Offset = "0x3C18C20", VA = "0x183C19A20")]
	private int GANCBGFHNHM(int GMEHLIHLGEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3C190C0", Offset = "0x3C182C0", VA = "0x183C190C0")]
	private int ALEEEMMGMED(int GMEHLIHLGEH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class NDCFDMPPPNM<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> GOIOJEGDINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> FKHGIDOBCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> JAAGBDPDCIE;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> IEMFDFOAKEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7BB020", Offset = "0x7BA220", VA = "0x1807BB020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool NNJLEOOEELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xAD84D0", Offset = "0xAD76D0", VA = "0x180AD84D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xAD8900", Offset = "0xAD7B00", VA = "0x180AD8900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x24B3A40", Offset = "0x24B2C40", VA = "0x1824B3A40", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x24B3AE0", Offset = "0x24B2CE0", VA = "0x1824B3AE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x24B39E0", Offset = "0x24B2BE0", VA = "0x1824B39E0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x24B3950", Offset = "0x24B2B50", VA = "0x1824B3950")]
	public NDCFDMPPPNM(Func<Internal, External> GOIOJEGDINC, Func<External, Internal> FKHGIDOBCCH, bool ANPMMNBJEGA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x24B3670", Offset = "0x24B2870", VA = "0x1824B3670", Slot = "6")]
	public int IndexOf(External ONCGIPFNENB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x24B32F0", Offset = "0x24B24F0", VA = "0x1824B32F0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x24B3350", Offset = "0x24B2550", VA = "0x1824B3350", Slot = "13")]
	public bool Contains(External ONCGIPFNENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x24B33E0", Offset = "0x24B25E0", VA = "0x1824B33E0", Slot = "14")]
	public void CopyTo(External[] HAHPMNMCEBD, int PBNJDHGCIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x24B3200", Offset = "0x24B2400", VA = "0x1824B3200", Slot = "11")]
	public void Add(External ONCGIPFNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x24B3760", Offset = "0x24B2960", VA = "0x1824B3760", Slot = "7")]
	public void Insert(int GMEHLIHLGEH, External ONCGIPFNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x24B38C0", Offset = "0x24B2AC0", VA = "0x1824B38C0", Slot = "15")]
	public bool Remove(External ONCGIPFNENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x24B3800", Offset = "0x24B2A00", VA = "0x1824B3800", Slot = "8")]
	public void RemoveAt(int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x24B3600", Offset = "0x24B2800", VA = "0x1824B3600", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8925F0", Offset = "0x8917F0", VA = "0x1808925F0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class FPAIECIOBFF<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> GOIOJEGDINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> JAAGBDPDCIE;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> IEMFDFOAKEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6FFB00", Offset = "0x6FED00", VA = "0x1806FFB00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool NNJLEOOEELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7004F0", Offset = "0x6FF6F0", VA = "0x1807004F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2F47010", Offset = "0x2F46210", VA = "0x182F47010", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2F46FB0", Offset = "0x2F461B0", VA = "0x182F46FB0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1B3B7F0", Offset = "0x1B3A9F0", VA = "0x181B3B7F0")]
	public FPAIECIOBFF(Func<Internal, External> GOIOJEGDINC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2F46F60", Offset = "0x2F46160", VA = "0x182F46F60")]
	public FPAIECIOBFF(IReadOnlyList<Internal> JAAGBDPDCIE, Func<Internal, External> GOIOJEGDINC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2F46D40", Offset = "0x2F45F40", VA = "0x182F46D40")]
	public void PEBLHKOPNAC(External[] HAHPMNMCEBD, int PBNJDHGCIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2F46C70", Offset = "0x2F45E70", VA = "0x182F46C70", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1B57740", Offset = "0x1B56940", VA = "0x181B57740", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public class MGJEBKJMGEC<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> JAAGBDPDCIE;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> IEMFDFOAKEP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x82F780", Offset = "0x82E980", VA = "0x18082F780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool NNJLEOOEELM
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7004F0", Offset = "0x6FF6F0", VA = "0x1807004F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2628250", Offset = "0x2627450", VA = "0x182628250", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x26281F0", Offset = "0x26273F0", VA = "0x1826281F0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1B3B7F0", Offset = "0x1B3A9F0", VA = "0x181B3B7F0")]
	public MGJEBKJMGEC(IReadOnlyList<Internal> JAAGBDPDCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2627EB0", Offset = "0x26270B0", VA = "0x182627EB0")]
	public bool BPCENLKELKP(External ONCGIPFNENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2627FC0", Offset = "0x26271C0", VA = "0x182627FC0")]
	public void PEBLHKOPNAC(External[] HAHPMNMCEBD, int PBNJDHGCIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2627F50", Offset = "0x2627150", VA = "0x182627F50", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8925F0", Offset = "0x8917F0", VA = "0x1808925F0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class JGBIFKLAMCM
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BPKLHKGNBHI(object[] ADCFFAJGNAM);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	protected JGBIFKLAMCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public abstract class POFIOKDDNBH<T> : JGBIFKLAMCM
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	protected struct CGHHIOOABLP
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public enum HBPPGGMHOPN
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
		public HBPPGGMHOPN NIFOGEBEDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T IBKGKDECOEG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int NJGAIJHHDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool LHAKJMANOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool BNDJLIFCGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> JEKNJJBBBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<CGHHIOOABLP> KLDLHFPFBON;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool NDMJCGACGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2461730", Offset = "0x2460930", VA = "0x182461730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2461770", Offset = "0x2460970", VA = "0x182461770")]
	protected POFIOKDDNBH(bool BNDJLIFCGII, bool LHAKJMANOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x24611F0", Offset = "0x24603F0", VA = "0x1824611F0")]
	protected bool EICPGFFIHJF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2461670", Offset = "0x2460870", VA = "0x182461670")]
	protected void OFOHHPGBKCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2461380", Offset = "0x2460580", VA = "0x182461380")]
	protected void LBNEOEKECAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x190EC60", Offset = "0x190DE60", VA = "0x18190EC60")]
	private static void BIKMELFOPED<U>(ref List<U> JAAGBDPDCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2461090", Offset = "0x2460290", VA = "0x182461090", Slot = "5")]
	public void CPCILMEHKPA(T IBKGKDECOEG, bool NHLGFPHIAMD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2461530", Offset = "0x2460730", VA = "0x182461530", Slot = "6")]
	public void MILDLLFOGOM(T IBKGKDECOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2461270", Offset = "0x2460470", VA = "0x182461270")]
	public void GLBPPAIACJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface EAEIBIOPOPO
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPCILMEHKPA(Action IBKGKDECOEG, bool NHLGFPHIAMD = false);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MILDLLFOGOM(Action IBKGKDECOEG);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class EEANDDJEMJC : global::POFIOKDDNBH<Action>, EAEIBIOPOPO
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x661E0B0", Offset = "0x661D2B0", VA = "0x18661E0B0")]
	public EEANDDJEMJC(bool BNDJLIFCGII = false, bool LHAKJMANOMP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x661DE40", Offset = "0x661D040", VA = "0x18661DE40")]
	public void LMIEJCDPBOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x661DD70", Offset = "0x661CF70", VA = "0x18661DD70", Slot = "4")]
	public override void BPKLHKGNBHI(object[] ADCFFAJGNAM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x661DDE0", Offset = "0x661CFE0", VA = "0x18661DDE0")]
	public static EEANDDJEMJC IOPGNDIMCDO(EEANDDJEMJC KGBNOLJDOLO, Action IBKGKDECOEG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x661E050", Offset = "0x661D250", VA = "0x18661E050")]
	public static EEANDDJEMJC NNBLJOMEMGD(EEANDDJEMJC KGBNOLJDOLO, Action IBKGKDECOEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface GEBDAEJFJCK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPCILMEHKPA(Action<T> IBKGKDECOEG, bool NHLGFPHIAMD = false);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MILDLLFOGOM(Action<T> IBKGKDECOEG);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class HHOBPMOCKMJ<T> : global::POFIOKDDNBH<Action<T>>, global::GEBDAEJFJCK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x1B456F0", Offset = "0x1B448F0", VA = "0x181B456F0")]
	public HHOBPMOCKMJ(bool BNDJLIFCGII = false, bool LHAKJMANOMP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x400EF10", Offset = "0x400E110", VA = "0x18400EF10")]
	public void LMIEJCDPBOC(T IHPJCBCPLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x400C240", Offset = "0x400B440", VA = "0x18400C240", Slot = "4")]
	public override void BPKLHKGNBHI(object[] ADCFFAJGNAM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x400D7F0", Offset = "0x400C9F0", VA = "0x18400D7F0")]
	public static global::HHOBPMOCKMJ<T> IOPGNDIMCDO(global::HHOBPMOCKMJ<T> KGBNOLJDOLO, Action<T> IBKGKDECOEG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x400F3E0", Offset = "0x400E5E0", VA = "0x18400F3E0")]
	public static global::HHOBPMOCKMJ<T> NNBLJOMEMGD(global::HHOBPMOCKMJ<T> KGBNOLJDOLO, Action<T> IBKGKDECOEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface BEHMNCHGIOA<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPCILMEHKPA(Action<T, U> IBKGKDECOEG, bool NHLGFPHIAMD = false);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MILDLLFOGOM(Action<T, U> IBKGKDECOEG);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class BPEPJJDICII<T, U> : global::POFIOKDDNBH<Action<T, U>>, global::BEHMNCHGIOA<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x1B456F0", Offset = "0x1B448F0", VA = "0x181B456F0")]
	public BPEPJJDICII(bool BNDJLIFCGII = false, bool LHAKJMANOMP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x1EC32C0", Offset = "0x1EC24C0", VA = "0x181EC32C0")]
	public void LMIEJCDPBOC(T IHPJCBCPLCM, U DJGCMHNEBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1FD0", Offset = "0x1EC11D0", VA = "0x181EC1FD0", Slot = "4")]
	public override void BPKLHKGNBHI(object[] ADCFFAJGNAM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x1EC26A0", Offset = "0x1EC18A0", VA = "0x181EC26A0")]
	public static global::BPEPJJDICII<T, U> IOPGNDIMCDO(global::BPEPJJDICII<T, U> KGBNOLJDOLO, Action<T, U> IBKGKDECOEG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x1EC4EB0", Offset = "0x1EC40B0", VA = "0x181EC4EB0")]
	public static global::BPEPJJDICII<T, U> NNBLJOMEMGD(global::BPEPJJDICII<T, U> KGBNOLJDOLO, Action<T, U> IBKGKDECOEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface JFLMNEFLMLI<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPCILMEHKPA(Action<T, U, V> IBKGKDECOEG, bool NHLGFPHIAMD = false);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MILDLLFOGOM(Action<T, U, V> IBKGKDECOEG);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class CBEFDECGNBJ<T, U, V> : global::POFIOKDDNBH<Action<T, U, V>>, global::JFLMNEFLMLI<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x1B456F0", Offset = "0x1B448F0", VA = "0x181B456F0")]
	public CBEFDECGNBJ(bool BNDJLIFCGII = false, bool LHAKJMANOMP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x26E3900", Offset = "0x26E2B00", VA = "0x1826E3900")]
	public void LMIEJCDPBOC(T IHPJCBCPLCM, U DJGCMHNEBOC, V MLIPDLAHDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x26E28E0", Offset = "0x26E1AE0", VA = "0x1826E28E0", Slot = "4")]
	public override void BPKLHKGNBHI(object[] ADCFFAJGNAM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x26E2F10", Offset = "0x26E2110", VA = "0x1826E2F10")]
	public static global::CBEFDECGNBJ<T, U, V> IOPGNDIMCDO(global::CBEFDECGNBJ<T, U, V> KGBNOLJDOLO, Action<T, U, V> IBKGKDECOEG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x26E5020", Offset = "0x26E4220", VA = "0x1826E5020")]
	public static global::CBEFDECGNBJ<T, U, V> NNBLJOMEMGD(global::CBEFDECGNBJ<T, U, V> KGBNOLJDOLO, Action<T, U, V> IBKGKDECOEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface NIPBACIHKDG<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPCILMEHKPA(Action<T, U, V, W> IBKGKDECOEG, bool NHLGFPHIAMD = false);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MILDLLFOGOM(Action<T, U, V, W> IBKGKDECOEG);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class KAJFMPHPBGO<T, U, V, W> : global::POFIOKDDNBH<Action<T, U, V, W>>, global::NIPBACIHKDG<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x1B456F0", Offset = "0x1B448F0", VA = "0x181B456F0")]
	public KAJFMPHPBGO(bool BNDJLIFCGII = false, bool LHAKJMANOMP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2159590", Offset = "0x2158790", VA = "0x182159590")]
	public void LMIEJCDPBOC(T IHPJCBCPLCM, U DJGCMHNEBOC, V MLIPDLAHDHI, W NHEDGPECFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2157330", Offset = "0x2156530", VA = "0x182157330", Slot = "4")]
	public override void BPKLHKGNBHI(object[] ADCFFAJGNAM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x2158260", Offset = "0x2157460", VA = "0x182158260")]
	public static global::KAJFMPHPBGO<T, U, V, W> IOPGNDIMCDO(global::KAJFMPHPBGO<T, U, V, W> KGBNOLJDOLO, Action<T, U, V, W> IBKGKDECOEG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2159800", Offset = "0x2158A00", VA = "0x182159800")]
	public static global::KAJFMPHPBGO<T, U, V, W> NNBLJOMEMGD(global::KAJFMPHPBGO<T, U, V, W> KGBNOLJDOLO, Action<T, U, V, W> IBKGKDECOEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface KEJILCDDHIN<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPCILMEHKPA(Action<T, U, V, W, X> IBKGKDECOEG, bool NHLGFPHIAMD = false);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MILDLLFOGOM(Action<T, U, V, W, X> IBKGKDECOEG);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class GOFBGHMGCLI<T, U, V, W, X> : global::POFIOKDDNBH<Action<T, U, V, W, X>>, global::KEJILCDDHIN<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x1B456F0", Offset = "0x1B448F0", VA = "0x181B456F0")]
	public GOFBGHMGCLI(bool BNDJLIFCGII = false, bool LHAKJMANOMP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x23BD110", Offset = "0x23BC310", VA = "0x1823BD110")]
	public void LMIEJCDPBOC(T IHPJCBCPLCM, U DJGCMHNEBOC, V MLIPDLAHDHI, W NHEDGPECFAM, X FCCGDNMAHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x23BCA60", Offset = "0x23BBC60", VA = "0x1823BCA60", Slot = "4")]
	public override void BPKLHKGNBHI(object[] ADCFFAJGNAM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x23BD070", Offset = "0x23BC270", VA = "0x1823BD070")]
	public static global::GOFBGHMGCLI<T, U, V, W, X> IOPGNDIMCDO(global::GOFBGHMGCLI<T, U, V, W, X> KGBNOLJDOLO, Action<T, U, V, W, X> IBKGKDECOEG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x23BD6D0", Offset = "0x23BC8D0", VA = "0x1823BD6D0")]
	public static global::GOFBGHMGCLI<T, U, V, W, X> NNBLJOMEMGD(global::GOFBGHMGCLI<T, U, V, W, X> KGBNOLJDOLO, Action<T, U, V, W, X> IBKGKDECOEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface MCBCEFFNFKM<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPCILMEHKPA(Action<T, U, V, W, X, Y> IBKGKDECOEG, bool NHLGFPHIAMD = false);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MILDLLFOGOM(Action<T, U, V, W, X, Y> IBKGKDECOEG);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class IOFEIMHAMHJ<T, U, V, W, X, Y> : global::POFIOKDDNBH<Action<T, U, V, W, X, Y>>, global::MCBCEFFNFKM<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x1B456F0", Offset = "0x1B448F0", VA = "0x181B456F0")]
	public IOFEIMHAMHJ(bool BNDJLIFCGII = false, bool LHAKJMANOMP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x1B45080", Offset = "0x1B44280", VA = "0x181B45080")]
	public void LMIEJCDPBOC(T IHPJCBCPLCM, U DJGCMHNEBOC, V MLIPDLAHDHI, W NHEDGPECFAM, X FCCGDNMAHPA, Y BADLFKONABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x1B446A0", Offset = "0x1B438A0", VA = "0x181B446A0", Slot = "4")]
	public override void BPKLHKGNBHI(object[] ADCFFAJGNAM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x1B44D30", Offset = "0x1B43F30", VA = "0x181B44D30")]
	public static global::IOFEIMHAMHJ<T, U, V, W, X, Y> IOPGNDIMCDO(global::IOFEIMHAMHJ<T, U, V, W, X, Y> KGBNOLJDOLO, Action<T, U, V, W, X, Y> IBKGKDECOEG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x1B45650", Offset = "0x1B44850", VA = "0x181B45650")]
	public static global::IOFEIMHAMHJ<T, U, V, W, X, Y> NNBLJOMEMGD(global::IOFEIMHAMHJ<T, U, V, W, X, Y> KGBNOLJDOLO, Action<T, U, V, W, X, Y> IBKGKDECOEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class CEPFLDPHNLD<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct HPLGKFANDPH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::CEPFLDPHNLD<T> NOAECHEDOHM;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T LKDHJKNGKHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2C85450", Offset = "0x2C84650", VA = "0x182C85450")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2C85470", Offset = "0x2C84670", VA = "0x182C85470", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7AF920", Offset = "0x7AEB20", VA = "0x1807AF920")]
		public HPLGKFANDPH(global::CEPFLDPHNLD<T> NOAECHEDOHM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct NPEEOCOBAHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<HPLGKFANDPH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::CEPFLDPHNLD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x23F7FE0", Offset = "0x23F71E0", VA = "0x1823F7FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1723030", Offset = "0x1722230", VA = "0x181723030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct NGJGCADMMKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<HPLGKFANDPH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::CEPFLDPHNLD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2777850", Offset = "0x2776A50", VA = "0x182777850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x1723030", Offset = "0x1722230", VA = "0x181723030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim LJCOJJHKBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T HIDHNHCKGEH;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int FLPHOEGPDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x26EC610", Offset = "0x26EB810", VA = "0x1826EC610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x26ECC80", Offset = "0x26EBE80", VA = "0x1826ECC80")]
	public CEPFLDPHNLD(in T HIDHNHCKGEH, int KHMGGPNBGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x26ECC50", Offset = "0x26EBE50", VA = "0x1826ECC50")]
	public CEPFLDPHNLD(in T HIDHNHCKGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x26ECBD0", Offset = "0x26EBDD0", VA = "0x1826ECBD0")]
	public HPLGKFANDPH NDOCIFBPCMD()
	{
		return default(HPLGKFANDPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x26ECC10", Offset = "0x26EBE10", VA = "0x1826ECC10")]
	public HPLGKFANDPH NDOCIFBPCMD(CancellationToken NDKAKDJMDIF)
	{
		return default(HPLGKFANDPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x26EC630", Offset = "0x26EB830", VA = "0x1826EC630")]
	[AsyncStateMachine(typeof(global::CEPFLDPHNLD<>.NPEEOCOBAHD))]
	public Task<HPLGKFANDPH> MDHHDFFDHJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x26EC900", Offset = "0x26EBB00", VA = "0x1826EC900")]
	[AsyncStateMachine(typeof(global::CEPFLDPHNLD<>.NGJGCADMMKI))]
	public Task<HPLGKFANDPH> MDHHDFFDHJC(CancellationToken NDKAKDJMDIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class EABCNCEHIHP
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x661DAB0", Offset = "0x661CCB0", VA = "0x18661DAB0")]
	public static global::CEPFLDPHNLD<MFEHAEMCKCJ> ELCFDEFNBDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x661DB10", Offset = "0x661CD10", VA = "0x18661DB10")]
	public static global::CEPFLDPHNLD<MFEHAEMCKCJ> ELCFDEFNBDD(int KHMGGPNBGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1151550", Offset = "0x1150750", VA = "0x181151550")]
	public static global::CEPFLDPHNLD<T> ELCFDEFNBDD<T>(in T HIDHNHCKGEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1D20970", Offset = "0x1D1FB70", VA = "0x181D20970")]
	public static global::CEPFLDPHNLD<T> ELCFDEFNBDD<T>(in T HIDHNHCKGEH, int KHMGGPNBGID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class JFIKHMCGCBA<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TResult> COFIDEMOMDI(TRequest BEODCPFFPCC, CancellationToken NDKAKDJMDIF);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum DHCKAMIICGB
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class FHAGBOGHLFO
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float GMAHGHDLOLD = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan CCPHLGHEHME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int PALHAMGNCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public DHCKAMIICGB PIGJKFBJLGK;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly FHAGBOGHLFO FBJHBFFDBDJ;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float GMPLKPKBGKA
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x1B62680", Offset = "0x1B61880", VA = "0x181B62680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan FLNPIMLGNDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x1B628B0", Offset = "0x1B61AB0", VA = "0x181B628B0")]
		public FHAGBOGHLFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private readonly struct CDGMGEEOKGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest BEODCPFFPCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken NDKAKDJMDIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> LCILDPHMBNI;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x26E8970", Offset = "0x26E7B70", VA = "0x1826E8970")]
		public CDGMGEEOKGA(TRequest BEODCPFFPCC, TaskCompletionSource<TResult> LCILDPHMBNI, CancellationToken NDKAKDJMDIF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class HHIDNBOCDLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public HHIDNBOCDLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x1932D80", Offset = "0x1931F80", VA = "0x181932D80")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct ENNOFENMBGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::JFIKHMCGCBA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x27EF250", Offset = "0x27EE450", VA = "0x1827EF250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x87A5F0", Offset = "0x8797F0", VA = "0x18087A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct PIAJCCFLFHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::JFIKHMCGCBA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private CDGMGEEOKGA <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2BE5D40", Offset = "0x2BE4F40", VA = "0x182BE5D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x87A5F0", Offset = "0x8797F0", VA = "0x18087A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource KPDIDKNEAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<CDGMGEEOKGA> NEDDDHFCEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly FHAGBOGHLFO OBGDFDMHEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly COFIDEMOMDI HCEJKPFNMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task FHOAHNGEHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int JLODAPCADGC;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2BDEE70", Offset = "0x2BDE070", VA = "0x182BDEE70")]
	public JFIKHMCGCBA(COFIDEMOMDI HCEJKPFNMPF, [Optional] FHAGBOGHLFO OBGDFDMHEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2BDE9D0", Offset = "0x2BDDBD0", VA = "0x182BDE9D0")]
	public Task<TResult> PMMODHJGLDB(TRequest BEODCPFFPCC, CancellationToken NDKAKDJMDIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2BDD580", Offset = "0x2BDC780", VA = "0x182BDD580")]
	private void CEKAKHFIEOD(CDGMGEEOKGA KMIHMKAGAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2BDDE90", Offset = "0x2BDD090", VA = "0x182BDDE90")]
	[AsyncStateMachine(typeof(global::JFIKHMCGCBA<, >.ENNOFENMBGB))]
	private Task EKFKNGMGIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2BDDC00", Offset = "0x2BDCE00", VA = "0x182BDDC00")]
	private CDGMGEEOKGA DMHGMKKDBDG()
	{
		return default(CDGMGEEOKGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2BDE2B0", Offset = "0x2BDD4B0", VA = "0x182BDE2B0")]
	[AsyncStateMachine(typeof(global::JFIKHMCGCBA<, >.PIAJCCFLFHH))]
	private Task JFCGCJDPLEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2BDE5C0", Offset = "0x2BDD7C0", VA = "0x182BDE5C0")]
	private void LENLLGJJKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2BDDE50", Offset = "0x2BDD050", VA = "0x182BDDE50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class PCKOBNFDEOF<TKey, TVal> : global::PFCCOJONNHA<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int MKBNEKGNDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> MKBHCEIDHNN;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int LHCIAOMDFNH
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x33F0250", Offset = "0x33EF450", VA = "0x1833F0250", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int HJBPIKBCBCN
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x33F05C0", Offset = "0x33EF7C0", VA = "0x1833F05C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x33EFF40", Offset = "0x33EF140", VA = "0x1833EFF40", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x33F05F0", Offset = "0x33EF7F0", VA = "0x1833F05F0")]
	public PCKOBNFDEOF(int FAPOEIDOLFP, [Optional] DPPLLIHKEMK GNADLHDCDMN, [Optional] IEqualityComparer<TKey> AIDGPMBEFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x33F01B0", Offset = "0x33EF3B0", VA = "0x1833F01B0")]
	public void BMEMKOOACOI(TKey FDAIMOMOHIG, TVal IPMIIEAGJKC, bool MACLHFIEECK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x33F0430", Offset = "0x33EF630", VA = "0x1833F0430")]
	public bool JIFILAGOKII(TKey FDAIMOMOHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x33F0390", Offset = "0x33EF590", VA = "0x1833F0390", Slot = "6")]
	public override bool HOAIDNCFMEI(TKey HICDIMAPLDO, out TVal IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x33EFFA0", Offset = "0x33EF1A0", VA = "0x1833EFFA0")]
	public bool BJCIGNOODCK(TKey FDAIMOMOHIG, TVal IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x33F04B0", Offset = "0x33EF6B0", VA = "0x1833F04B0")]
	public bool MKHPHINMFDB(TKey FDAIMOMOHIG, TVal IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x33F0280", Offset = "0x33EF480", VA = "0x1833F0280", Slot = "7")]
	public override void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x33F02F0", Offset = "0x33EF4F0", VA = "0x1833F02F0")]
	private bool HNLANDKCONE(TKey FDAIMOMOHIG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DefaultMember("Item")]
public class PFCCOJONNHA<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public delegate int DPPLLIHKEMK(TKey FDAIMOMOHIG, TVal IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class BDGBHMGHIKA
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey EGJKFMADELN
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x7DA2E0", Offset = "0x7D94E0", VA = "0x1807DA2E0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal LKDHJKNGKHD
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x7BB020", Offset = "0x7BA220", VA = "0x1807BB020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int HEIPHEGLBIF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x952290", Offset = "0x951490", VA = "0x180952290")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x9521B0", Offset = "0x9513B0", VA = "0x1809521B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime IFAJBGCHENL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xA10690", Offset = "0xA0F890", VA = "0x180A10690")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x21B2900", Offset = "0x21B1B00", VA = "0x1821B2900")]
		public BDGBHMGHIKA(TKey FDAIMOMOHIG, TVal DGAGNFOEEIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int CNMNBKCMAJD = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<BDGBHMGHIKA>> JKHHEAHFCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<BDGBHMGHIKA> IBCILMFPINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly DPPLLIHKEMK GNADLHDCDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan BAJLECNPLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly DADMFNPJDIJ JPLBFPGCDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int AEDCDCNEBKD;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int EPBJKODLMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x91C3D0", Offset = "0x91B5D0", VA = "0x18091C3D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool LOLABIACMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x30D0C90", Offset = "0x30CFE90", VA = "0x1830D0C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int LHCIAOMDFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x12F8400", Offset = "0x12F7600", VA = "0x1812F8400", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int BFFJHKFEFPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1BA67C0", Offset = "0x1BA59C0", VA = "0x181BA67C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x1B4D430", Offset = "0x1B4C630", VA = "0x181B4D430", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> MDKPNDACNBE
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x30D04F0", Offset = "0x30CF6F0", VA = "0x1830D04F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x30D1C30", Offset = "0x30D0E30", VA = "0x1830D1C30")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x26DA7A0", Offset = "0x26D99A0", VA = "0x1826DA7A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x30D2380", Offset = "0x30D1580", VA = "0x1830D2380")]
	public PFCCOJONNHA(int FAPOEIDOLFP, [Optional] DPPLLIHKEMK GNADLHDCDMN, [Optional] IEqualityComparer<TKey> AIDGPMBEFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x30D1F90", Offset = "0x30D1190", VA = "0x1830D1F90")]
	public PFCCOJONNHA(TimeSpan BAJLECNPLPD, [Optional] IEqualityComparer<TKey> AIDGPMBEFIP, [Optional] DADMFNPJDIJ JPLBFPGCDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x30D20B0", Offset = "0x30D12B0", VA = "0x1830D20B0")]
	public PFCCOJONNHA(int FAPOEIDOLFP, TimeSpan BAJLECNPLPD, [Optional] IEqualityComparer<TKey> AIDGPMBEFIP, [Optional] DADMFNPJDIJ JPLBFPGCDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x30D27A0", Offset = "0x30D19A0", VA = "0x1830D27A0")]
	public PFCCOJONNHA(int FAPOEIDOLFP, DPPLLIHKEMK GNADLHDCDMN, TimeSpan BAJLECNPLPD, [Optional] IEqualityComparer<TKey> AIDGPMBEFIP, [Optional] DADMFNPJDIJ JPLBFPGCDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x30CF6D0", Offset = "0x30CE8D0", VA = "0x1830CF6D0")]
	public void FLPCMCLHIBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x30D1C70", Offset = "0x30D0E70", VA = "0x1830D1C70")]
	public void PLCAKFAMFIL(TKey FDAIMOMOHIG, TVal IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x30D0E80", Offset = "0x30D0080", VA = "0x1830D0E80")]
	public bool MILDLLFOGOM(TKey FDAIMOMOHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x30D0270", Offset = "0x30CF470", VA = "0x1830D0270")]
	private TVal HHCPOGCCGNF(TKey HICDIMAPLDO)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x30D09D0", Offset = "0x30CFBD0", VA = "0x1830D09D0", Slot = "6")]
	public virtual bool HOAIDNCFMEI(TKey HICDIMAPLDO, out TVal IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x30CF850", Offset = "0x30CEA50", VA = "0x1830CF850", Slot = "7")]
	public virtual void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x30D19C0", Offset = "0x30D0BC0", VA = "0x1830D19C0")]
	private bool PGILBNOEIKL(BDGBHMGHIKA BIKGMLHPEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x30CFB00", Offset = "0x30CED00", VA = "0x1830CFB00")]
	private void HFAMDOGFDLP(LinkedListNode<BDGBHMGHIKA> BIJPLBOHNKF, TVal DLEMNBPMGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x30D1510", Offset = "0x30D0710", VA = "0x1830D1510")]
	private void NBGMFEOMHDO(TKey FDAIMOMOHIG, TVal IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x30CF0A0", Offset = "0x30CE2A0", VA = "0x1830CF0A0")]
	private void DHJENDAJOHA(BDGBHMGHIKA BIKGMLHPEGN, TVal DLEMNBPMGBG, int NOCCMAIOCDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DefaultMember("Item")]
public class BLOEGHHEDHJ<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> JAAGBDPDCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> NCDJGGEEOFC;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1932D80", Offset = "0x1931F80", VA = "0x181932D80", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool NNJLEOOEELM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1EB1A80", Offset = "0x1EB0C80", VA = "0x181EB1A80", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x1EB1B70", Offset = "0x1EB0D70", VA = "0x181EB1B70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1B43430", Offset = "0x1B42630", VA = "0x181B43430", Slot = "11")]
	public void Add(T ONCGIPFNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x1EB15A0", Offset = "0x1EB07A0", VA = "0x181EB15A0")]
	public bool OIACEIIALAO(T ONCGIPFNENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x1EB1890", Offset = "0x1EB0A90", VA = "0x181EB1890", Slot = "15")]
	public bool Remove(T ONCGIPFNENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x1EB1360", Offset = "0x1EB0560", VA = "0x181EB1360", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x1BB8290", Offset = "0x1BB7490", VA = "0x181BB8290", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x1EB12A0", Offset = "0x1EB04A0", VA = "0x181EB12A0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x1EB1300", Offset = "0x1EB0500", VA = "0x181EB1300", Slot = "13")]
	public bool Contains(T ONCGIPFNENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x1EB1330", Offset = "0x1EB0530", VA = "0x181EB1330", Slot = "14")]
	public void CopyTo(T[] HAHPMNMCEBD, int PBNJDHGCIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x1EB13E0", Offset = "0x1EB05E0", VA = "0x181EB13E0", Slot = "6")]
	public int IndexOf(T ONCGIPFNENB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x1EB14E0", Offset = "0x1EB06E0", VA = "0x181EB14E0", Slot = "7")]
	public void Insert(int GMEHLIHLGEH, T ONCGIPFNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x1EB16F0", Offset = "0x1EB08F0", VA = "0x181EB16F0", Slot = "8")]
	public void RemoveAt(int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1EB1100", Offset = "0x1EB0300", VA = "0x181EB1100")]
	public void BJMNFFHNJDK(Predicate<T> PGEONKOMPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1EB10D0", Offset = "0x1EB02D0", VA = "0x181EB10D0")]
	public void BFGJAOCGAGD(Comparison<T> DCGHLAPALPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x1EB19A0", Offset = "0x1EB0BA0", VA = "0x181EB19A0")]
	public BLOEGHHEDHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class LDPBKPADNKO
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6620970", Offset = "0x661FB70", VA = "0x186620970")]
	public static Vector3 BGKAMHFEEGP(this GameObject BMNLOPDIJGF, float JDOLOMCFHML)
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
			[Cpp2IlInjected.Address(RVA = "0x1E4A560", Offset = "0x1E49760", VA = "0x181E4A560")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x66142B0", Offset = "0x66134B0", VA = "0x1866142B0")]
		public SerializedGuid(in Guid JMIFIJDBMNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6625BA0", Offset = "0x6624DA0", VA = "0x186625BA0")]
		public static SerializedGuid AHCHCMKDLAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6625C30", Offset = "0x6624E30", VA = "0x186625C30")]
		public static SerializedGuid CBDCOOBEFBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6625E50", Offset = "0x6625050", VA = "0x186625E50")]
		public bool KGIFMFOFOPL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6614280", Offset = "0x6613480", VA = "0x186614280", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6625F70", Offset = "0x6625170", VA = "0x186625F70", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6625EE0", Offset = "0x66250E0", VA = "0x186625EE0")]
		public bool OFPEIHMPLIL(in Guid JMIFIJDBMNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6625CC0", Offset = "0x6624EC0", VA = "0x186625CC0", Slot = "7")]
		public bool Equals(SerializedGuid HNPEBINPOBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6625D70", Offset = "0x6624F70", VA = "0x186625D70", Slot = "0")]
		public override bool Equals(object ICHBECDKHOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x66141D0", Offset = "0x66133D0", VA = "0x1866141D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6614010", Offset = "0x6613210", VA = "0x186614010", Slot = "6")]
		public int CompareTo(SerializedGuid HNPEBINPOBO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class EAMMKLHOPGM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type AEOLIMOLMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string GDKDLFKKKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool ALHFJEPKOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool AIMCFPIIADB;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x661DD00", Offset = "0x661CF00", VA = "0x18661DD00")]
	public EAMMKLHOPGM(Type MJFLFKAJLFF, string AMLLBFFOFHG, bool LFKFGODAHIN = false, bool ICHOEGGJAHC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface IJHLGPBLEFG
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface GBFANDMDGCC<T> : IJHLGPBLEFG
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T LKDHJKNGKHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool LIMNBHBPKGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string LEFPGJEKFGF
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
	global::GBFANDMDGCC<T> IAJHGFDLDEE(Action<T> JHDIKDKJLFG);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::GBFANDMDGCC<T> OLLBOFILOIA(Action<T> JHDIKDKJLFG);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::GBFANDMDGCC<T> NEDBMIPFAOM(Action<T, T> JPALKLHNFAL);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::GBFANDMDGCC<T> ADGCNJILHJO(Action<T, T> JPALKLHNFAL);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::GBFANDMDGCC<T> OCOHEAMBBIL(Action<string> JEJLJKDNFPI);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::GBFANDMDGCC<T> LKDIBEIOIGC(Action<string> JEJLJKDNFPI);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class BKOFBKBECBF<T> : global::GBFANDMDGCC<T>, IJHLGPBLEFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::BPEPJJDICII<T, T> DEELEKJODJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::HHOBPMOCKMJ<T> GHPHKCJNBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::HHOBPMOCKMJ<string> GJFABBIEGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string NLJOHEKGNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T CDNLFEOBNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool POOFFNLKOBC;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T LKDHJKNGKHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x892680", Offset = "0x891880", VA = "0x180892680", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool LIMNBHBPKGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7B4980", Offset = "0x7B3B80", VA = "0x1807B4980", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string LEFPGJEKFGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x75C710", Offset = "0x75B910", VA = "0x18075C710", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xD67BB0", Offset = "0xD66DB0", VA = "0x180D67BB0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x21C63A0", Offset = "0x21C55A0", VA = "0x1821C63A0")]
	private void FIDBGNANPBO(T KHKGGNHOCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x21C6540", Offset = "0x21C5740", VA = "0x1821C6540")]
	private void NALEMNDBDDB(string OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x21C6730", Offset = "0x21C5930", VA = "0x1821C6730")]
	public void PAKIMOKGMBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x21C65F0", Offset = "0x21C57F0", VA = "0x1821C65F0", Slot = "6")]
	public global::GBFANDMDGCC<T> NEDBMIPFAOM(Action<T, T> JPALKLHNFAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x21C6350", Offset = "0x21C5550", VA = "0x1821C6350", Slot = "7")]
	public global::GBFANDMDGCC<T> ADGCNJILHJO(Action<T, T> JPALKLHNFAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x21C6440", Offset = "0x21C5640", VA = "0x1821C6440", Slot = "4")]
	public global::GBFANDMDGCC<T> IAJHGFDLDEE(Action<T> JPALKLHNFAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x21C66E0", Offset = "0x21C58E0", VA = "0x1821C66E0", Slot = "5")]
	public global::GBFANDMDGCC<T> OLLBOFILOIA(Action<T> JHDIKDKJLFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x21C6640", Offset = "0x21C5840", VA = "0x1821C6640", Slot = "8")]
	public global::GBFANDMDGCC<T> OCOHEAMBBIL(Action<string> JEJLJKDNFPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x21C64D0", Offset = "0x21C56D0", VA = "0x1821C64D0", Slot = "9")]
	public global::GBFANDMDGCC<T> LKDIBEIOIGC(Action<string> JEJLJKDNFPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x21C67E0", Offset = "0x21C59E0", VA = "0x1821C67E0")]
	public BKOFBKBECBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class GOAGGMCMBKK
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class MMICANCIEOP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::GBFANDMDGCC<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::PHLHFLLLDLK<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public MMICANCIEOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x2633C20", Offset = "0x2632E20", VA = "0x182633C20")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x22674A0", Offset = "0x22666A0", VA = "0x1822674A0")]
	public static global::NCOKFFGPIJM<T> IIEIMKIPEKF<T>(this global::GBFANDMDGCC<T> KBMGKAFEIEJ, Action<T> ONAFALABHKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class FKCKMADGELN<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public readonly struct AMDOLIADBCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long FEHMMEPKFIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long FHMIBHAINDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int BAJPMLMLCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int PPNPFFLKEOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool JHHMENOLKCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string LMAKMIFAAGI;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x31DF140", Offset = "0x31DE340", VA = "0x1831DF140")]
		public AMDOLIADBCB(long FEHMMEPKFIH, int BAJPMLMLCCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x31DF110", Offset = "0x31DE310", VA = "0x1831DF110")]
		public AMDOLIADBCB(long FEHMMEPKFIH, long FHMIBHAINDC, int BAJPMLMLCCC, int PPNPFFLKEOK, bool JHHMENOLKCG, string LMAKMIFAAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x31DF0A0", Offset = "0x31DE2A0", VA = "0x1831DF0A0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void MHJOJECPLNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x31DF030", Offset = "0x31DE230", VA = "0x1831DF030")]
		public int HGJDAEHBJJM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x31DF080", Offset = "0x31DE280", VA = "0x1831DF080")]
		public int IAJLNEAFKOE(int OMHKKLCKMOL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x31DEF30", Offset = "0x31DE130", VA = "0x1831DEF30")]
		public double BDCLKAKFNAJ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x31DEFA0", Offset = "0x31DE1A0", VA = "0x1831DEFA0")]
		public AMDOLIADBCB EJLPBKHHOOC(long FHMIBHAINDC, int PPNPFFLKEOK)
		{
			return default(AMDOLIADBCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class PPKAMDIDPFK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey EGJKFMADELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::FKCKMADGELN<TKey> LIJGJGIGLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<PPKAMDIDPFK> GGLFEBJJOCE;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string FMJIJEEFAHK
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x1B45720", Offset = "0x1B44920", VA = "0x181B45720")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x20BB960", Offset = "0x20BAB60", VA = "0x1820BB960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<PPKAMDIDPFK> NCLNEDAIDDA
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x2467E60", Offset = "0x2467060", VA = "0x182467E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public AMDOLIADBCB FLFKNPFALBC
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x105FA20", Offset = "0x105EC20", VA = "0x18105FA20")]
			[CompilerGenerated]
			get
			{
				return default(AMDOLIADBCB);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x2468030", Offset = "0x2467230", VA = "0x182468030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2468140", Offset = "0x2467340", VA = "0x182468140")]
		internal PPKAMDIDPFK(global::FKCKMADGELN<TKey> LIJGJGIGLOD, TKey FDAIMOMOHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2467D50", Offset = "0x2466F50", VA = "0x182467D50")]
		public PPKAMDIDPFK CKGEEECJHAB(TKey FDAIMOMOHIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2468060", Offset = "0x2467260", VA = "0x182468060")]
		public void JKDNKDLAOMP(TKey FDAIMOMOHIG, Action<PPKAMDIDPFK> IBKGKDECOEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x190EE40", Offset = "0x190E040", VA = "0x18190EE40")]
		public T JKDNKDLAOMP<T>(TKey FDAIMOMOHIG, Func<PPKAMDIDPFK, T> CFEEHGJEDHI)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x190ECD0", Offset = "0x190DED0", VA = "0x18190ECD0")]
		[AsyncStateMachine(typeof(AOLMCPGAFOD))]
		public Task<T> FEKNDFMECDI<T>(TKey FDAIMOMOHIG, Func<PPKAMDIDPFK, Task<T>> CFEEHGJEDHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x2467E80", Offset = "0x2467080", VA = "0x182467E80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class KKJDNAMBBLF : IEnumerable<(TKey, List<TKey>, AMDOLIADBCB)>, IEnumerable, IEnumerator<(TKey, List<TKey>, AMDOLIADBCB)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, AMDOLIADBCB timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::FKCKMADGELN<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, AMDOLIADBCB timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, AMDOLIADBCB) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x1FC34F0", Offset = "0x1FC26F0", VA = "0x181FC34F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, AMDOLIADBCB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3590", Offset = "0x1FC2790", VA = "0x181FC3590", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3640", Offset = "0x1FC2840", VA = "0x181FC3640")]
		[DebuggerHidden]
		public KKJDNAMBBLF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1BB69D0", Offset = "0x1BB5BD0", VA = "0x181BB69D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3180", Offset = "0x1FC2380", VA = "0x181FC3180", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1FC35F0", Offset = "0x1FC27F0", VA = "0x181FC35F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3550", Offset = "0x1FC2750", VA = "0x181FC3550", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3430", Offset = "0x1FC2630", VA = "0x181FC3430", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, AMDOLIADBCB)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3520", Offset = "0x1FC2720", VA = "0x181FC3520", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class NBLMFOFHBLD : IEnumerable<(TKey, List<TKey>, AMDOLIADBCB)>, IEnumerable, IEnumerator<(TKey, List<TKey>, AMDOLIADBCB)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, AMDOLIADBCB timerEntry) <>2__current;

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
		private PPKAMDIDPFK timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public PPKAMDIDPFK <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::FKCKMADGELN<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<PPKAMDIDPFK> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, AMDOLIADBCB timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, AMDOLIADBCB) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x1FC34F0", Offset = "0x1FC26F0", VA = "0x181FC34F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, AMDOLIADBCB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x24AFEE0", Offset = "0x24AF0E0", VA = "0x1824AFEE0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3640", Offset = "0x1FC2840", VA = "0x181FC3640")]
		[DebuggerHidden]
		public NBLMFOFHBLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x24AFF40", Offset = "0x24AF140", VA = "0x1824AFF40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x24AF7F0", Offset = "0x24AE9F0", VA = "0x1824AF7F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x24AFFE0", Offset = "0x24AF1E0", VA = "0x1824AFFE0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x24B0040", Offset = "0x24AF240", VA = "0x1824B0040")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x24AFEA0", Offset = "0x24AF0A0", VA = "0x1824AFEA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x24AFD90", Offset = "0x24AEF90", VA = "0x1824AFD90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, AMDOLIADBCB)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x24AFE70", Offset = "0x24AF070", VA = "0x1824AFE70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, AMDOLIADBCB> GOKFMOMFFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, AMDOLIADBCB> MGHHHOFJPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::FKCKMADGELN<TKey>> GDPBAHPAHCD;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string MOIGECDBOIA = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly PPKAMDIDPFK JFADEBEPCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool CAPGEKKMIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int BCAEOEOEGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch LKKCBBBBCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int MKBHNPKOJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string LBAJDDBJAIJ;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public PPKAMDIDPFK AJHEGHJBPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x75C710", Offset = "0x75B910", VA = "0x18075C710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string FMJIJEEFAHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x75F110", Offset = "0x75E310", VA = "0x18075F110")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x2F3FE60", Offset = "0x2F3F060", VA = "0x182F3FE60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long FFGMFOBNNNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x2F3FD90", Offset = "0x2F3EF90", VA = "0x182F3FD90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int PBKDDMHDJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x2F3FDB0", Offset = "0x2F3EFB0", VA = "0x182F3FDB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2F40040", Offset = "0x2F3F240", VA = "0x182F40040")]
	public FKCKMADGELN(TKey AGJPIDNNEGM, [Optional] int? BAJPMLMLCCC, [Optional][CanBeNull] Stopwatch LKKCBBBBCOG, [Optional] Action<TKey, AMDOLIADBCB> GOKFMOMFFFC, [Optional] Action<TKey, AMDOLIADBCB> MGHHHOFJPDB, [Optional] Action<global::FKCKMADGELN<TKey>> GDPBAHPAHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2F3FCE0", Offset = "0x2F3EEE0", VA = "0x182F3FCE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2F3FD70", Offset = "0x2F3EF70", VA = "0x182F3FD70")]
	public void FHBILIJBOGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x2F40020", Offset = "0x2F3F220", VA = "0x182F40020")]
	public void NOMPIEABHOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x2F3FF90", Offset = "0x2F3F190", VA = "0x182F3FF90")]
	[IteratorStateMachine(typeof(global::FKCKMADGELN<>.KKJDNAMBBLF))]
	public IEnumerable<(TKey, List<TKey>, AMDOLIADBCB)> MBJBMPPEHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x2F3FEC0", Offset = "0x2F3F0C0", VA = "0x182F3FEC0")]
	[IteratorStateMachine(typeof(global::FKCKMADGELN<>.NBLMFOFHBLD))]
	private IEnumerable<(TKey, List<TKey>, AMDOLIADBCB)> MBJBMPPEHAE(List<TKey> KDENKOIEIEI, PPKAMDIDPFK GPANJEJEFMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x2F3FDE0", Offset = "0x2F3EFE0", VA = "0x182F3FDE0")]
	private (long, int) KOFGGFFIAGJ()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class CMDGEOOLONJ<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut KEABAFDPLIB(global::FKCKMADGELN<TKey> LIJGJGIGLOD);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
	protected CMDGEOOLONJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public abstract class EPCELKGGNOL<TKey> : global::CMDGEOOLONJ<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate string DPLLDKFPAFJ(TKey FDAIMOMOHIG);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x892520", Offset = "0x891720", VA = "0x180892520")]
	protected string NGBKPCALLKD(double PIGJDLCGFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x892590", Offset = "0x891790", VA = "0x180892590")]
	protected string OHMLHMMIMJL(int ABGNCPANCHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x892300", Offset = "0x891500", VA = "0x180892300")]
	private static string ENBBBMLNBNP(TKey FDAIMOMOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x892470", Offset = "0x891670", VA = "0x180892470", Slot = "4")]
	public override string KEABAFDPLIB(global::FKCKMADGELN<TKey> LIJGJGIGLOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x892340", Offset = "0x891540", VA = "0x180892340")]
	public string KEABAFDPLIB(global::FKCKMADGELN<TKey> LIJGJGIGLOD, [NotNull] DPLLDKFPAFJ LIGBFNBKBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string CKKBFHBDPIO(global::FKCKMADGELN<TKey> LIJGJGIGLOD, [NotNull] DPLLDKFPAFJ LIGBFNBKBGL);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x8925F0", Offset = "0x8917F0", VA = "0x1808925F0")]
	protected EPCELKGGNOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class BINPFFNEBGL<TKey> : global::CMDGEOOLONJ<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate string AFPDJNOPBPM(TKey FDAIMOMOHIG);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int MIBNIALGPMJ = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string LKHANKHCGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double PCGJABNJPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool CCKIGHDAPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int LMFLALHNNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> GPFEIAMIDEE;

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x21C4270", Offset = "0x21C3470", VA = "0x1821C4270")]
	private static string ENBBBMLNBNP(TKey FDAIMOMOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x21C4CB0", Offset = "0x21C3EB0", VA = "0x1821C4CB0")]
	public BINPFFNEBGL(string LKHANKHCGBI = "F2", double PCGJABNJPKD = double.MaxValue, bool CCKIGHDAPNO = false, int LMFLALHNNCF = int.MaxValue, [Optional] ISet<string> GPFEIAMIDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x21C49A0", Offset = "0x21C3BA0", VA = "0x1821C49A0", Slot = "4")]
	public override Dictionary<string, string> KEABAFDPLIB(global::FKCKMADGELN<TKey> LIJGJGIGLOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x21C4BD0", Offset = "0x21C3DD0", VA = "0x1821C4BD0")]
	private bool OJCMAEDLKDA(string DPDMCDLGKOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x21C4460", Offset = "0x21C3660", VA = "0x1821C4460")]
	public Dictionary<string, string> KEABAFDPLIB(global::FKCKMADGELN<TKey> LIJGJGIGLOD, AFPDJNOPBPM LIGBFNBKBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x21C42B0", Offset = "0x21C34B0", VA = "0x1821C42B0")]
	private string HKOCPJNAIFH(StringBuilder LHNLACLCEDM, List<TKey> HJFMIHONFHC, AFPDJNOPBPM LIGBFNBKBGL, bool NIDALPGEAEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x21C4A50", Offset = "0x21C3C50", VA = "0x1821C4A50")]
	private static void OIMFIENIAGE(StringBuilder HJBDCEBKBDN, string LMALDHNEHNG, bool IKCLLIPIHHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class DAEGACHJLMF<TKey> : global::EPCELKGGNOL<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct FKMHNPLEKGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public DPLLDKFPAFJ keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::DAEGACHJLMF<TKey> OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int LEKBGFFLIEN = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] EKECHNDCOBN;

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x20B9670", Offset = "0x20B8870", VA = "0x1820B9670")]
	private DAEGACHJLMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x20B8590", Offset = "0x20B7790", VA = "0x1820B8590", Slot = "5")]
	protected override string CKKBFHBDPIO(global::FKCKMADGELN<TKey> LIJGJGIGLOD, DPLLDKFPAFJ LIGBFNBKBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x20B9480", Offset = "0x20B8680", VA = "0x1820B9480")]
	[CompilerGenerated]
	internal static string CMFLPNHBICN(string ICKCGEDGCLI, TKey FDAIMOMOHIG, ref FKMHNPLEKGM P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class BFFFDPOAFEA<TKey> : global::EPCELKGGNOL<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class JHJNGKGCNCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public DPLLDKFPAFJ keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public JHJNGKGCNCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x1934CE0", Offset = "0x1933EE0", VA = "0x181934CE0")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x21B9D50", Offset = "0x21B8F50", VA = "0x1821B9D50", Slot = "5")]
	protected override string CKKBFHBDPIO(global::FKCKMADGELN<TKey> LIJGJGIGLOD, DPLLDKFPAFJ LIGBFNBKBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x21BA640", Offset = "0x21B9840", VA = "0x1821BA640")]
	public BFFFDPOAFEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public sealed class CEMPCLLNDGG : global::FKCKMADGELN<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class CKCKNNLAFPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<CEMPCLLNDGG> callback;

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public CKCKNNLAFPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x661D720", Offset = "0x661C920", VA = "0x18661D720")]
		internal void <Wrap>b__0(global::FKCKMADGELN<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x661D3F0", Offset = "0x661C5F0", VA = "0x18661D3F0")]
	public CEMPCLLNDGG([Optional] string ALNOIBLAICB, [Optional] int? BAJPMLMLCCC, [Optional] Stopwatch LKKCBBBBCOG, [Optional] Action<string, AMDOLIADBCB> GOKFMOMFFFC, [Optional] Action<string, AMDOLIADBCB> MGHHHOFJPDB, [Optional] Action<CEMPCLLNDGG> GDPBAHPAHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x661D310", Offset = "0x661C510", VA = "0x18661D310")]
	private static Action<global::FKCKMADGELN<string>> JKDNKDLAOMP(Action<CEMPCLLNDGG> ONAFALABHKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class DADMFNPJDIJ
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class FGGDMMMLKGF : DADMFNPJDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static DADMFNPJDIJ OFDKPDDLIJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x661E1C0", Offset = "0x661D3C0", VA = "0x18661E1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime GFJEGPJAKAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x661E170", Offset = "0x661D370", VA = "0x18661E170", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float HFNJIINDMAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x661E220", Offset = "0x661D420", VA = "0x18661E220", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x661E2D0", Offset = "0x661D4D0", VA = "0x18661E2D0")]
		public FGGDMMMLKGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static DADMFNPJDIJ KIHHHIDFNGO;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static DADMFNPJDIJ FBJHBFFDBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x661D840", Offset = "0x661CA40", VA = "0x18661D840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime GFJEGPJAKAB
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float HFNJIINDMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	protected DADMFNPJDIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class HNMOPBKDJDD : global::LNAGPMFLPMC<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x661FC20", Offset = "0x661EE20", VA = "0x18661FC20")]
	public HNMOPBKDJDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class LNAGPMFLPMC<T> : global::EHOCIICLNGN<T>, CEOIDCLNHCN, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> EJIHIIKGPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task NMBCGKGHDCM
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x892030", Offset = "0x891230", VA = "0x180892030", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::NCOKFFGPIJM<T> PIELGNCIHFB
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private LAHBDKNMNHN BHGEEJHCPIE
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x892130", Offset = "0x891330", VA = "0x180892130", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x247C110", Offset = "0x247B310", VA = "0x18247C110")]
	public LNAGPMFLPMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class FJCMJOBNJHG : global::OPLOFPJOIBF<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x661E830", Offset = "0x661DA30", VA = "0x18661E830")]
	public FJCMJOBNJHG(Exception GCBHEJANCJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class OPLOFPJOIBF<T> : global::EHOCIICLNGN<T>, CEOIDCLNHCN, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> EJIHIIKGPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task NMBCGKGHDCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x892030", Offset = "0x891230", VA = "0x180892030", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::NCOKFFGPIJM<T> PIELGNCIHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private LAHBDKNMNHN BHGEEJHCPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x892130", Offset = "0x891330", VA = "0x180892130", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x4028010", Offset = "0x4027210", VA = "0x184028010")]
	public OPLOFPJOIBF(Exception GCBHEJANCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface CEOIDCLNHCN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task EJIHIIKGPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	LAHBDKNMNHN PIELGNCIHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface EHOCIICLNGN<T> : CEOIDCLNHCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> EJIHIIKGPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::NCOKFFGPIJM<T> PIELGNCIHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public abstract class PJDDDFJIBDP<TTask, T> : global::EHOCIICLNGN<T>, CEOIDCLNHCN, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class NGGPDPMEJDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public global::PJDDDFJIBDP<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public NGGPDPMEJDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool OFLNKJJOBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> BEONMNODOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource HMHGCNBJGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool CAPGEKKMIBE;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> EJIHIIKGPPO
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task NMBCGKGHDCM
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::NCOKFFGPIJM<T> PIELGNCIHFB
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private LAHBDKNMNHN BHGEEJHCPIE
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xD75B50", Offset = "0xD74D50", VA = "0x180D75B50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool ICJICHLKHIE
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xAD84D0", Offset = "0xAD76D0", VA = "0x180AD84D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x2BEBA80", Offset = "0x2BEAC80", VA = "0x182BEBA80")]
	static PJDDDFJIBDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x2BEBD60", Offset = "0x2BEAF60", VA = "0x182BEBD60")]
	protected PJDDDFJIBDP(TTask BEONMNODOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x2BEBA10", Offset = "0x2BEAC10", VA = "0x182BEBA10", Slot = "1")]
	~PJDDDFJIBDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB9E0", Offset = "0x2BEABE0", VA = "0x182BEB9E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB640", Offset = "0x2BEA840", VA = "0x182BEB640")]
	private void AFELIDKEEFL(bool KNNOELAJKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T JKNICOLMDME(TTask NNKDCKHHNFC);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void MHOLKAMLKBJ();
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface LGCCNEMEJDE
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float FIHHDCCDKON
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BBJDKABPFCJ CMPJJAHAFJK;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class PNCAIFCLJGG : LGCCNEMEJDE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public readonly struct JHEBPFAFMFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public readonly float OJFIFFKKFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float OELCFPDDHFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		internal readonly bool PJAJGNFHPGD;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float HEIPHEGLBIF
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x6620220", Offset = "0x661F420", VA = "0x186620220")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x66203B0", Offset = "0x661F5B0", VA = "0x1866203B0")]
		public JHEBPFAFMFG(float EBEICGFALNG, float OGINPOLMPBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6620230", Offset = "0x661F430", VA = "0x186620230", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class GFOHNDLCMMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public PNCAIFCLJGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public GFOHNDLCMMK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly int FAPOEIDOLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int LBHCCOIFBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly LGCCNEMEJDE[] NJAPCPNGHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly BBJDKABPFCJ[] FPLPHBFOJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly JHEBPFAFMFG[] IMANNBIILGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private JHEBPFAFMFG FLOJKLLPIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly KAFLHKGMOKK PPCFCHKLBHO;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public JHEBPFAFMFG JAELBIKGKAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x176F2B0", Offset = "0x176E4B0", VA = "0x18176F2B0")]
		get
		{
			return default(JHEBPFAFMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float FIHHDCCDKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6623FE0", Offset = "0x66231E0", VA = "0x186623FE0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event BBJDKABPFCJ CMPJJAHAFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6623F20", Offset = "0x6623120", VA = "0x186623F20", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6623BA0", Offset = "0x6622DA0", VA = "0x186623BA0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6624450", Offset = "0x6623650", VA = "0x186624450")]
	public PNCAIFCLJGG(int FAPOEIDOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6623C60", Offset = "0x6622E60", VA = "0x186623C60")]
	public KAFLHKGMOKK DFDBOBKFCBJ(JHEBPFAFMFG IIGHOHLJPIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6624000", Offset = "0x6623200", VA = "0x186624000")]
	public void NHCJDMGFNAE(LGCCNEMEJDE FAHCALIOMKA, [Optional] JHEBPFAFMFG BCCEKEBHMLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6623E80", Offset = "0x6623080", VA = "0x186623E80")]
	internal int JEBHMABMKPB(LGCCNEMEJDE FIPCMLNPBFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6623ED0", Offset = "0x66230D0", VA = "0x186623ED0")]
	internal JHEBPFAFMFG LJLCEIOJCGG(int GMEHLIHLGEH)
	{
		return default(JHEBPFAFMFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6623CF0", Offset = "0x6622EF0", VA = "0x186623CF0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public delegate void BBJDKABPFCJ(float DDKCONDPEJF);
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class HNJPHOFCNDE
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	internal const float CGKMMBNAAJK = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class HPELCFHEJNK
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private class MCONBMBBEBH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly LGCCNEMEJDE FIPCMLNPBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly BBJDKABPFCJ ONAFALABHKI;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6620C90", Offset = "0x661FE90", VA = "0x186620C90")]
		public MCONBMBBEBH(LGCCNEMEJDE FIPCMLNPBFB, BBJDKABPFCJ ONAFALABHKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6620C40", Offset = "0x661FE40", VA = "0x186620C40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x661FD20", Offset = "0x661EF20", VA = "0x18661FD20")]
	internal static bool NFFJMILPGNP(float NNMPJECKECI, float EFNJCAIBDLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x44BC1D0", Offset = "0x44BB3D0", VA = "0x1844BC1D0")]
	internal static float FOHIJLFBLIB(float NNMPJECKECI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x661FC60", Offset = "0x661EE60", VA = "0x18661FC60")]
	public static IDisposable KPALDFEDBHJ(this LGCCNEMEJDE FIPCMLNPBFB, BBJDKABPFCJ ONAFALABHKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class KAFLHKGMOKK : LGCCNEMEJDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float DDKCONDPEJF;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float FIHHDCCDKON
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xB53E30", Offset = "0xB53030", VA = "0x180B53E30", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6620630", Offset = "0x661F830", VA = "0x186620630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event BBJDKABPFCJ CMPJJAHAFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6620590", Offset = "0x661F790", VA = "0x186620590", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x66204F0", Offset = "0x661F6F0", VA = "0x1866204F0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public KAFLHKGMOKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class GMNMJNFLENM
{
	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x661F7D0", Offset = "0x661E9D0", VA = "0x18661F7D0")]
	[NotNull]
	public static byte[] NEMHPNGCHEP(this EDJIOCIKNEJ BEOMAAMDMEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x661F760", Offset = "0x661E960", VA = "0x18661F760")]
	[NotNull]
	public static byte[] NEMHPNGCHEP(this EDJIOCIKNEJ BEOMAAMDMEJ, HashAlgorithmName FHDGMBHCPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x661F9E0", Offset = "0x661EBE0", VA = "0x18661F9E0")]
	public static bool PHDKAKNKGBO([CanBeNull] this EDJIOCIKNEJ BEOMAAMDMEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x661F840", Offset = "0x661EA40", VA = "0x18661F840")]
	public static bool PHDKAKNKGBO([CanBeNull] this EDJIOCIKNEJ BEOMAAMDMEJ, out string NLJOHEKGNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x661F6F0", Offset = "0x661E8F0", VA = "0x18661F6F0")]
	private static string IIKEGGKJBJM([CanBeNull] byte[] ODBGNNDKAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x661F5D0", Offset = "0x661E7D0", VA = "0x18661F5D0")]
	private static bool IFOKJEHIICH([NotNull] EDJIOCIKNEJ BEOMAAMDMEJ, [CanBeNull] out byte[] FKBNONKPNIA, [CanBeNull] out byte[] GGNHLHMEFJL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class MPHHCFHKJFM
{
	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6621060", Offset = "0x6620260", VA = "0x186621060")]
	[NotNull]
	public static byte[] NEMHPNGCHEP(this JMIIPNGAANF CNEMOIBNHAH, byte[] HBGCNDFCAAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6620E30", Offset = "0x6620030", VA = "0x186620E30")]
	[NotNull]
	public static byte[] NEMHPNGCHEP(this JMIIPNGAANF CNEMOIBNHAH, HashAlgorithmName FHDGMBHCPGI, byte[] HBGCNDFCAAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface JMIIPNGAANF
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash NDFMMDHCKFC);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface EDJIOCIKNEJ : JMIIPNGAANF
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] LCADOBCOAND
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
	byte[] CENGJLHNABJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object IHFLKJHCIPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class PIGDLPOBFIG
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private class DGKILANDBOI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x661DA30", Offset = "0x661CC30", VA = "0x18661DA30")]
		public DGKILANDBOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x661D9D0", Offset = "0x661CBD0", VA = "0x18661D9D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private const byte MKAGFIPBNBO = 1;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte GMAEILOKCNH = 0;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly ArrayPool<byte> GEDKACPPOLD;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static bool IGHKDJPODPC;

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x25B8740", Offset = "0x25B7940", VA = "0x1825B8740")]
	[Conditional("UNITY_EDITOR")]
	private static void OBEBDIFHHLH<T>(params T[] OBMFEGLDKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6622EB0", Offset = "0x66220B0", VA = "0x186622EB0")]
	public static IDisposable IFHJDPIHPFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6622B90", Offset = "0x6621D90", VA = "0x186622B90")]
	public static void FOGJKLMIIPB(this IncrementalHash LBGCEGMNOGG, [CanBeNull] GameObject BMNLOPDIJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x25B8210", Offset = "0x25B7410", VA = "0x1825B8210")]
	public static void FOGJKLMIIPB<T>(this IncrementalHash LBGCEGMNOGG, [CanBeNull] T KLEOIMLJIAC) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x25B8A30", Offset = "0x25B7C30", VA = "0x1825B8A30")]
	public static void PLNMJADPEAN<T>(this IncrementalHash LBGCEGMNOGG, [CanBeNull] T CNEMOIBNHAH) where T : JMIIPNGAANF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x25B82E0", Offset = "0x25B74E0", VA = "0x1825B82E0")]
	public static void IHEDONIMBGN<T>(this IncrementalHash LBGCEGMNOGG, [CanBeNull] IList<T> PCEHKDAEHBM) where T : JMIIPNGAANF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6622AA0", Offset = "0x6621CA0", VA = "0x186622AA0")]
	private static bool EJFNLENHABL([CanBeNull] JMIIPNGAANF CNEMOIBNHAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6622B30", Offset = "0x6621D30", VA = "0x186622B30")]
	public static void EKBEEPJELBG(this IncrementalHash NDFMMDHCKFC, [CanBeNull] string PNGPNDKOAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6623450", Offset = "0x6622650", VA = "0x186623450")]
	public static void NDJNNHHNBFA(this IncrementalHash NDFMMDHCKFC, long BEJBINLGLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6623620", Offset = "0x6622820", VA = "0x186623620")]
	public static void NDOOPEHNHMO(this IncrementalHash NDFMMDHCKFC, int FKBADCHKJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x66237F0", Offset = "0x66229F0", VA = "0x1866237F0")]
	public static void OJFFJNABEEB(this IncrementalHash NDFMMDHCKFC, short MNCOOHPHEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x66232E0", Offset = "0x66224E0", VA = "0x1866232E0")]
	public static void LPNBHOOCPPC(this IncrementalHash NDFMMDHCKFC, byte DHAHLGJLALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6622CE0", Offset = "0x6621EE0", VA = "0x186622CE0")]
	public static void HJMJFPGMPIA(this IncrementalHash NDFMMDHCKFC, bool HCCHLDNNKAA, bool JLDOMECFMPJ = false, bool NAANLJNODAH = false, bool BDIPEGJOAIH = false, bool JKFGHJJHEJB = false, bool BLOGDCDLDMP = false, bool BKFKIBMKGHE = false, bool MAMHHKHKDFP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x25B7B20", Offset = "0x25B6D20", VA = "0x1825B7B20")]
	public static void AFHKLNANPAL<T>(this IncrementalHash NDFMMDHCKFC, T MFCNJMCAPLA) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6622C80", Offset = "0x6621E80", VA = "0x186622C80")]
	public static void GKHIEDNHEKP(this IncrementalHash NDFMMDHCKFC, float HPNKNBDHCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x66239C0", Offset = "0x6622BC0", VA = "0x1866239C0")]
	public static void POLFIBHFIEF(this IncrementalHash NDFMMDHCKFC, double IGIEJADPOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6622A30", Offset = "0x6621C30", VA = "0x186622A30")]
	public static void DALDDKPEACH(this IncrementalHash NDFMMDHCKFC, ulong PGOJCDGCGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6623110", Offset = "0x6622310", VA = "0x186623110")]
	public static void JICIHCNEPLM(this IncrementalHash NDFMMDHCKFC, uint IAHNHOLEMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6623A20", Offset = "0x6622C20", VA = "0x186623A20")]
	public static void PPKFJAHHHLD(this IncrementalHash NDFMMDHCKFC, ushort ENODHDIJOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6623170", Offset = "0x6622370", VA = "0x186623170")]
	public static void JMMBPGMEJEE(this IncrementalHash NDFMMDHCKFC, Vector3 HGEKHCCFPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6622F50", Offset = "0x6622150", VA = "0x186622F50")]
	public static void JCDJJDGAKIB(this IncrementalHash NDFMMDHCKFC, Quaternion IJNBIIPNAGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class EPOLCKDEKMN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly Type AEOLIMOLMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly string GDKDLFKKKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly bool ALHFJEPKOJC;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x661E110", Offset = "0x661D310", VA = "0x18661E110")]
	public EPOLCKDEKMN(Type MJFLFKAJLFF, string AMLLBFFOFHG, bool LFKFGODAHIN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class KHPEGOODEIN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6620790", Offset = "0x661F990", VA = "0x186620790")]
	public KHPEGOODEIN(string OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6620800", Offset = "0x661FA00", VA = "0x186620800")]
	public KHPEGOODEIN(string OFCFPGACNJB, Exception OAFPGAMPFDL)
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
			[Cpp2IlInjected.Address(RVA = "0x6F6400", Offset = "0x6F5600", VA = "0x1806F6400")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x7E4830", Offset = "0x7E3A30", VA = "0x1807E4830")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int MLECAGAJCGO, int JIEKLDFOLNF]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x309CAD0", Offset = "0x309BCD0", VA = "0x18309CAD0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x309CB70", Offset = "0x309BD70", VA = "0x18309CB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x309CA40", Offset = "0x309BC40", VA = "0x18309CA40")]
		public Array2D(uint LBPFDOBECLE, uint BICGJAOHKIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x309C9C0", Offset = "0x309BBC0", VA = "0x18309C9C0")]
		public void GLBPPAIACJF()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x661D1B0", Offset = "0x661C3B0", VA = "0x18661D1B0")]
		public Array2DVector3(uint LBPFDOBECLE, uint BICGJAOHKIJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal static class LOKPALMCEPD
{
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public const int EEFCEAOIOGJ = -1;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public const int DHMNMFEDBDL = 0;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[DefaultMember("Item")]
public class LCFJEOPKOJK<THandle, TValue> : IDisposable where THandle : struct, ONMCCIDPEOK where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly List<THandle> OBDCNEMMCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly List<TValue> MKPAEINNGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly Func<TValue> BKINLOOODOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly Action<TValue> LEMFIHPPIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private int EPKNJFPHCCN;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x23F28F0", Offset = "0x23F1AF0", VA = "0x1823F28F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x3BE36B0", Offset = "0x3BE28B0", VA = "0x183BE36B0")]
	public LCFJEOPKOJK(Action<TValue> LEMFIHPPIEC, [Optional] Func<TValue> BKINLOOODOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x3BE2CD0", Offset = "0x3BE1ED0", VA = "0x183BE2CD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x3BE2F80", Offset = "0x3BE2180", VA = "0x183BE2F80")]
	public THandle GPGHDDABLEF()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x3BE2B90", Offset = "0x3BE1D90", VA = "0x183BE2B90")]
	public THandle CPCILMEHKPA(TValue IPMIIEAGJKC)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x3BE32E0", Offset = "0x3BE24E0", VA = "0x183BE32E0")]
	public bool MILDLLFOGOM(THandle PLFCHHKILCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x3BE2C00", Offset = "0x3BE1E00", VA = "0x183BE2C00")]
	public bool DPHICADNPGH(THandle PLFCHHKILCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x3BE30D0", Offset = "0x3BE22D0", VA = "0x183BE30D0")]
	public bool IJDPOKFHBJA(THandle PLFCHHKILCM, out TValue IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x3BE3050", Offset = "0x3BE2250", VA = "0x183BE3050")]
	public TValue HHCPOGCCGNF(THandle PLFCHHKILCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x3BE3410", Offset = "0x3BE2610", VA = "0x183BE3410")]
	public bool NHKKABBPFMM(THandle PLFCHHKILCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x3BE3020", Offset = "0x3BE2220", VA = "0x183BE3020")]
	private THandle HCPKIDFCLNC(int GMEHLIHLGEH)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x3BE30A0", Offset = "0x3BE22A0", VA = "0x183BE30A0")]
	private TValue IIEIMKIPEKF(int GMEHLIHLGEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x3BE3170", Offset = "0x3BE2370", VA = "0x183BE3170")]
	private void INCGLFLBPIP(int GMEHLIHLGEH, in THandle PLFCHHKILCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x3BE2E00", Offset = "0x3BE2000", VA = "0x183BE2E00")]
	private void FIDBGNANPBO(int GMEHLIHLGEH, in TValue IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x3BE35A0", Offset = "0x3BE27A0", VA = "0x183BE35A0")]
	private THandle PPHMPNALFLA()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x3BE2D50", Offset = "0x3BE1F50", VA = "0x183BE2D50")]
	private void EODJFFILPJH(THandle PLFCHHKILCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x3BE3590", Offset = "0x3BE2790", VA = "0x183BE3590")]
	private int OKFIJCLEBOI(int EOGFAFNNICF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x3BE32D0", Offset = "0x3BE24D0", VA = "0x183BE32D0")]
	private bool JCILGCFONAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x85A6D0", Offset = "0x8598D0", VA = "0x18085A6D0")]
	private void GABELKGFBGN(THandle PLFCHHKILCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x3BE3390", Offset = "0x3BE2590", VA = "0x183BE3390")]
	private bool MPDFAPJFKAB(out THandle PLFCHHKILCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x3BE34C0", Offset = "0x3BE26C0", VA = "0x183BE34C0")]
	private bool OJMNPLJOPKE(out THandle PLFCHHKILCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x3BE2B30", Offset = "0x3BE1D30", VA = "0x183BE2B30")]
	private void CKNOCEBBGNE(THandle PLFCHHKILCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x3BE31B0", Offset = "0x3BE23B0", VA = "0x183BE31B0")]
	private void IOCGMGBHCBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface ONMCCIDPEOK
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int BCGMDEIHEMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int OLGKJALIAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public interface ECNPNPKOHHG<T> : ONMCCIDPEOK, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class CFJALPNNOHH
{
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x1152FF0", Offset = "0x11521F0", VA = "0x181152FF0")]
	public static bool IEPAOKCDACC<T>(this T PLFCHHKILCM, T HNPEBINPOBO) where T : struct, ONMCCIDPEOK
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x1153010", Offset = "0x1152210", VA = "0x181153010")]
	public static bool PJAJGNFHPGD<T>(this T PLFCHHKILCM) where T : struct, ONMCCIDPEOK
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x661D610", Offset = "0x661C810", VA = "0x18661D610")]
	public static string NIPANBLNFPF(this ONMCCIDPEOK PLFCHHKILCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class OJGAOMHLIHC
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private enum KJKCKMOFKCK : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private int NDFMMDHCKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private bool OKJNMNFALLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private KJKCKMOFKCK DADHJJNJEFA;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool DPPJPBMGLNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6621B10", Offset = "0x6620D10", VA = "0x186621B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool JMFCAJBHHAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6622700", Offset = "0x6621900", VA = "0x186622700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6622840", Offset = "0x6621A40", VA = "0x186622840")]
	public OJGAOMHLIHC(bool OKJNMNFALLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6621B40", Offset = "0x6620D40", VA = "0x186621B40")]
	public void HHKKNLEIDOC(object ICHBECDKHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6621A00", Offset = "0x6620C00", VA = "0x186621A00")]
	public void BCOPPIJOEFA(int IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6621B20", Offset = "0x6620D20", VA = "0x186621B20")]
	public void EKDLIAHDLOD(uint MDKDFFMBEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6622630", Offset = "0x6621830", VA = "0x186622630")]
	public void KOIOJBOKDIK(bool ABFEDJBPDDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x66219C0", Offset = "0x6620BC0", VA = "0x1866219C0")]
	public void AIBGNGCIBDI(long EAPCACPHCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x66226C0", Offset = "0x66218C0", VA = "0x1866226C0")]
	public void MKJFHFCBNNO(ulong DGIKOHMIDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x6622650", Offset = "0x6621850", VA = "0x186622650")]
	public void MHAJNEAIJLJ(string EIBIHJOIINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x66225A0", Offset = "0x66217A0", VA = "0x1866225A0")]
	public void HPGLPOHBCHD(Enum GCBHEJANCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6622710", Offset = "0x6621910", VA = "0x186622710")]
	public void OONPAEDFMMJ(IList JAAGBDPDCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2051320", Offset = "0x2050520", VA = "0x182051320")]
	public void LKIGACANPMM<T, U>(Dictionary<T, U> GFJINOOPPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x66221C0", Offset = "0x66213C0", VA = "0x1866221C0")]
	private void HLLJJBKLKKM(IDictionary GFJINOOPPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6621AA0", Offset = "0x6620CA0", VA = "0x186621AA0")]
	public int BJALJJOKNFM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6622530", Offset = "0x6621730", VA = "0x186622530")]
	public short HOFMBABNLEB()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6621B30", Offset = "0x6620D30", VA = "0x186621B30")]
	public void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6621950", Offset = "0x6620B50", VA = "0x186621950")]
	private void ABLHIBPKEKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public abstract class KJOGMODDKFC<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal class OGICDJJBPOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public TNode DIJPFIMLAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public TNode HHFDFFDPCGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public NICBKDBGDCD GCILADHGICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public List<NICBKDBGDCD> ALNPCJGNMBI;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public OGICDJJBPOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	internal struct NICBKDBGDCD : IComparable<NICBKDBGDCD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public int LAGADKBKLAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public TClaimant JHPHCFMELOK;

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x9DFCD0", Offset = "0x9DEED0", VA = "0x1809DFCD0")]
		public NICBKDBGDCD(int LAGADKBKLAD, TClaimant JHPHCFMELOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x2780A70", Offset = "0x277FC70", VA = "0x182780A70")]
		public bool MHGLAPFILDG(in NICBKDBGDCD HNPEBINPOBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x2780A60", Offset = "0x277FC60", VA = "0x182780A60")]
		public bool LNAEEBLHDOE(in NICBKDBGDCD HNPEBINPOBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x2780A50", Offset = "0x277FC50", VA = "0x182780A50", Slot = "4")]
		public int CompareTo(NICBKDBGDCD HNPEBINPOBO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x2780AD0", Offset = "0x277FCD0", VA = "0x182780AD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public enum IFGKCHKJGLN
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class FEKPBBCDGHJ : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public global::KJOGMODDKFC<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x1B5FAB0", Offset = "0x1B5ECB0", VA = "0x181B5FAB0")]
		[DebuggerHidden]
		public FEKPBBCDGHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x1B5F8B0", Offset = "0x1B5EAB0", VA = "0x181B5F8B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x1B5FA70", Offset = "0x1B5EC70", VA = "0x181B5FA70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x1B5F990", Offset = "0x1B5EB90", VA = "0x181B5F990", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xD66070", Offset = "0xD65270", VA = "0x180D66070", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly global::MMKGBMOBGDF<OGICDJJBPOG> BCFHKPJIKPI;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly global::MMKGBMOBGDF<List<NICBKDBGDCD>> OGOKPGHHLKI;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static int LNAIGELCEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	internal readonly Dictionary<TClaimant, TNode> CFHNOKPOCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	internal readonly Dictionary<TNode, OGICDJJBPOG> IPODMAHOGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private IFGKCHKJGLN DNLPIHIBJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private bool KBDIBPJIHNN;

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode FONBPFGIHGB(TNode KNBPIEINLIG);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void BNEEFMLDFED(TNode KNBPIEINLIG, TClaimant HMDMLFEONNH, TClaimant CMNODMLEKGJ);

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x1FC25E0", Offset = "0x1FC17E0", VA = "0x181FC25E0")]
	public KJOGMODDKFC(IFGKCHKJGLN DNLPIHIBJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1990", Offset = "0x1FC0B90", VA = "0x181FC1990")]
	public void IGFGHCNABDI(TNode KNBPIEINLIG, TNode BDBBMBMDCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0E90", Offset = "0x1FC0090", VA = "0x181FC0E90")]
	public void AMMJBDIBAAG(TClaimant JHPHCFMELOK, TNode MOKCHOHDCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1160", Offset = "0x1FC0360", VA = "0x181FC1160", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1BA0", Offset = "0x1FC0DA0", VA = "0x181FC1BA0")]
	private void NCMKGJCAKED(TClaimant JHPHCFMELOK, TNode KIAFNBJEKJF, TNode MOKCHOHDCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2060", Offset = "0x1FC1260", VA = "0x181FC2060")]
	private int OLNNINAIPFC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC20C0", Offset = "0x1FC12C0", VA = "0x181FC20C0")]
	private void PDEKKLPJIBI(TClaimant JHPHCFMELOK, TNode BHDFDPAKGMI, TNode MIONKFPACCE, int NCHMCMMPGDA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1E10", Offset = "0x1FC1010", VA = "0x181FC1E10")]
	private void NPJHPKEDHAE(NICBKDBGDCD FHCEADAHFKD, OGICDJJBPOG KFECLMFEPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1730", Offset = "0x1FC0930", VA = "0x181FC1730")]
	private void HKLHJMDLJMB(TClaimant JHPHCFMELOK, TNode BHDFDPAKGMI, TNode MIONKFPACCE, int NCHMCMMPGDA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2370", Offset = "0x1FC1570", VA = "0x181FC2370")]
	private void PGGFIBPHLII(NICBKDBGDCD FHCEADAHFKD, TNode KNBPIEINLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0F90", Offset = "0x1FC0190", VA = "0x181FC0F90")]
	private void BNNLPEPFHIC(NICBKDBGDCD FHCEADAHFKD, OGICDJJBPOG KFECLMFEPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1C40", Offset = "0x1FC0E40", VA = "0x181FC1C40")]
	private void NDBFAFGBLPA(OGICDJJBPOG KFECLMFEPBA, bool MCABGMPJLJG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x1FC13C0", Offset = "0x1FC05C0", VA = "0x181FC13C0")]
	private void FDJOKAMEEEC(OGICDJJBPOG KFECLMFEPBA, TNode BDBBMBMDCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1090", Offset = "0x1FC0290", VA = "0x181FC1090")]
	[IteratorStateMachine(typeof(global::KJOGMODDKFC<, >.FEKPBBCDGHJ))]
	private IEnumerable<TNode> CNDEJOIJHMA(TNode BHDFDPAKGMI, TNode MIONKFPACCE, bool JMHFAPFEMBE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1D50", Offset = "0x1FC0F50", VA = "0x181FC1D50")]
	private OGICDJJBPOG NIDAFBKHBPD(TNode KNBPIEINLIG, TNode HHFDFFDPCGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1A10", Offset = "0x1FC0C10", VA = "0x181FC1A10")]
	private OGICDJJBPOG MKBCCFNIKJN(TNode KNBPIEINLIG, TNode HHFDFFDPCGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1EA0", Offset = "0x1FC10A0", VA = "0x181FC1EA0")]
	private void OIGJGFOIPNG(OGICDJJBPOG KFECLMFEPBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class IDEIBFFIHHC<T> : IEnumerable<global::IDEIBFFIHHC<T>.PMJFLPOGIBH>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public struct PMJFLPOGIBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public T IPMIIEAGJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int GMEHLIHLGEH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class HGAFFBJACBM : IEnumerator<PMJFLPOGIBH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private global::IDEIBFFIHHC<T> GHKLFJFOHKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private int GMEHLIHLGEH;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x896320", Offset = "0x895520", VA = "0x180896320", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public PMJFLPOGIBH DMBDEPMHMNP
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x3FF52F0", Offset = "0x3FF44F0", VA = "0x183FF52F0", Slot = "4")]
			get
			{
				return default(PMJFLPOGIBH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA360", Offset = "0x2DD9560", VA = "0x182DDA360")]
		public HGAFFBJACBM(global::IDEIBFFIHHC<T> GHKLFJFOHKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x3FF51B0", Offset = "0x3FF43B0", VA = "0x183FF51B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x19ED260", Offset = "0x19EC460", VA = "0x1819ED260", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D10", Offset = "0x8C6F10", VA = "0x1808C7D10", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private struct GLPCGPFOOLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public bool HCPEILNMFJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T IPMIIEAGJKC;
	}

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private const int POCMBFFHGNJ = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly Dictionary<T, int> LEMDBKOKFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private GLPCGPFOOLC[] IKEFNKEGELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private int JLJDEAODJGO;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int KKMJMFJMNCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x827270", Offset = "0x826470", VA = "0x180827270")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xB9AE40", Offset = "0xB9A040", VA = "0x180B9AE40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x1932D80", Offset = "0x1931F80", VA = "0x181932D80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x19341E0", Offset = "0x19333E0", VA = "0x1819341E0")]
	public IDEIBFFIHHC(int FAPOEIDOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x19342C0", Offset = "0x19334C0", VA = "0x1819342C0")]
	public IDEIBFFIHHC(PMJFLPOGIBH[] KBAHNGPHOHC, bool JNACAGIJMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x1932D10", Offset = "0x1931F10", VA = "0x181932D10")]
	public int AIMFIEDFLMH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x19330A0", Offset = "0x19322A0", VA = "0x1819330A0")]
	private int HKGHCMFAGDG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x1932DB0", Offset = "0x1931FB0", VA = "0x181932DB0", Slot = "6")]
	protected virtual uint BAJBPHKGPAG(uint NDFMMDHCKFC, T IPMIIEAGJKC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x19337F0", Offset = "0x19329F0", VA = "0x1819337F0")]
	public bool KFOBAEKGLOH(T IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x19335A0", Offset = "0x19327A0", VA = "0x1819335A0")]
	public bool IJEGOBBMKJI(int GMEHLIHLGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x1932EB0", Offset = "0x19320B0", VA = "0x181932EB0")]
	public bool BPCENLKELKP(Func<T, bool> HNGJGPJCNBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x1933830", Offset = "0x1932A30", VA = "0x181933830")]
	public int KHOHIDLIBCB(T IPMIIEAGJKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x19334F0", Offset = "0x19326F0", VA = "0x1819334F0")]
	public T IIEIMKIPEKF(int GMEHLIHLGEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x1933020", Offset = "0x1932220", VA = "0x181933020")]
	public void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x1933EA0", Offset = "0x19330A0", VA = "0x181933EA0")]
	public bool OIACEIIALAO(T IPMIIEAGJKC, bool IGIIDNJBIBA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x1933F10", Offset = "0x1933110", VA = "0x181933F10")]
	public bool OIACEIIALAO(T IPMIIEAGJKC, int GMEHLIHLGEH, bool IGIIDNJBIBA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x1933B90", Offset = "0x1932D90", VA = "0x181933B90")]
	public bool MILDLLFOGOM(T IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x1934110", Offset = "0x1933310", VA = "0x181934110")]
	public bool PDJCDCJJNPH(int GMEHLIHLGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x19335F0", Offset = "0x19327F0", VA = "0x1819335F0")]
	private void JHLKPHEHNHA(int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x1933A50", Offset = "0x1932C50", VA = "0x181933A50")]
	public PMJFLPOGIBH[] LBKAIIPADDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x1932FD0", Offset = "0x19321D0", VA = "0x181932FD0")]
	private int COKICDDNCNM(int JDHIICINABH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x1934160", Offset = "0x1933360", VA = "0x181934160", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x1934160", Offset = "0x1933360", VA = "0x181934160", Slot = "4")]
	private IEnumerator<PMJFLPOGIBH> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct DOHBIFCKEGF<Handle> where Handle : ONMCCIDPEOK, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private struct LDGHDEOFPGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly global::DOHBIFCKEGF<Handle> IOKGCKHEEEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int GMEHLIHLGEH;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int FKIJHOAOMOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x219F730", Offset = "0x219E930", VA = "0x18219F730")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle PPCAPPKFBME
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x219E910", Offset = "0x219DB10", VA = "0x18219E910")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x219F970", Offset = "0x219EB70", VA = "0x18219F970")]
		public LDGHDEOFPGK(global::DOHBIFCKEGF<Handle> IOKGCKHEEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x219ED30", Offset = "0x219DF30", VA = "0x18219ED30")]
		public PHOIPIDBKLD ELCFDEFNBDD(in PHOIPIDBKLD GADDGJANIGG)
		{
			return default(PHOIPIDBKLD);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x219EDD0", Offset = "0x219DFD0", VA = "0x18219EDD0")]
		public FILGNFDMPKH ELCFDEFNBDD(in FILGNFDMPKH GADDGJANIGG)
		{
			return default(FILGNFDMPKH);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x219EE70", Offset = "0x219E070", VA = "0x18219EE70")]
		public bool JNNCKMAELPF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x219F340", Offset = "0x219E540", VA = "0x18219F340")]
		private int LMIELIGPHDD(string OFCFPGACNJB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x219F8D0", Offset = "0x219EAD0", VA = "0x18219F8D0")]
		private Handle OEMPCHANJDN(string OFCFPGACNJB)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct PHOIPIDBKLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private LDGHDEOFPGK OMGIDBLLCGF;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int DMBDEPMHMNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x2BE5C40", Offset = "0x2BE4E40", VA = "0x182BE5C40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x2BE5C80", Offset = "0x2BE4E80", VA = "0x182BE5C80")]
		public PHOIPIDBKLD(global::DOHBIFCKEGF<Handle> IOKGCKHEEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x2BE5B40", Offset = "0x2BE4D40", VA = "0x182BE5B40")]
		public bool JNNCKMAELPF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x2BE5A00", Offset = "0x2BE4C00", VA = "0x182BE5A00")]
		public PHOIPIDBKLD BECNODPGHJK()
		{
			return default(PHOIPIDBKLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public struct FILGNFDMPKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private LDGHDEOFPGK OMGIDBLLCGF;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle DMBDEPMHMNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x2F3C5A0", Offset = "0x2F3B7A0", VA = "0x182F3C5A0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x2BE5C80", Offset = "0x2BE4E80", VA = "0x182BE5C80")]
		public FILGNFDMPKH(global::DOHBIFCKEGF<Handle> IOKGCKHEEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x2BE5B40", Offset = "0x2BE4D40", VA = "0x182BE5B40")]
		public bool JNNCKMAELPF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x2F3C4A0", Offset = "0x2F3B6A0", VA = "0x182F3C4A0")]
		public FILGNFDMPKH BECNODPGHJK()
		{
			return default(FILGNFDMPKH);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private NativeList<int> NHPGEPEAEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private NativeList<int> BENPEDHJIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private int CHOMJIDKFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private int OAIOLICOHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private bool GIDMKEMHMNK;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool OEPEEFKGKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xAD84D0", Offset = "0xAD76D0", VA = "0x180AD84D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int EPBJKODLMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x3C17A60", Offset = "0x3C16C60", VA = "0x183C17A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int DFIKCHLBMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x6FB720", Offset = "0x6FA920", VA = "0x1806FB720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int CNPNNABEBKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x6FB720", Offset = "0x6FA920", VA = "0x1806FB720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public PHOIPIDBKLD NCOMDJELNAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x3C17B30", Offset = "0x3C16D30", VA = "0x183C17B30")]
		get
		{
			return default(PHOIPIDBKLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public FILGNFDMPKH CKIDHFHDIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x3C17060", Offset = "0x3C16260", VA = "0x183C17060")]
		get
		{
			return default(FILGNFDMPKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3C17BD0", Offset = "0x3C16DD0", VA = "0x183C17BD0")]
	public DOHBIFCKEGF(int MMLIEOIKGGL, Allocator HCEMBCPANJM = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3C13890", Offset = "0x3C12A90", VA = "0x183C13890")]
	public void AFELIDKEEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x1BE7650", Offset = "0x1BE6850", VA = "0x181BE7650")]
	public static int OKFIJCLEBOI(int MLIPDLAHDHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3C13ED0", Offset = "0x3C130D0", VA = "0x183C13ED0")]
	public static bool CMMPGINEPLN(int MLIPDLAHDHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3C17B20", Offset = "0x3C16D20", VA = "0x183C17B20")]
	public static bool PJOMNEIBGGO(int MLIPDLAHDHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x3C14760", Offset = "0x3C13960", VA = "0x183C14760")]
	public bool FKGAGDKPJPJ(int GMEHLIHLGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x3C14BE0", Offset = "0x3C13DE0", VA = "0x183C14BE0")]
	public bool GMHPPDAMFNO(int GMEHLIHLGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x3C13DC0", Offset = "0x3C12FC0", VA = "0x183C13DC0")]
	public bool CCKJJBMAMBF(Handle PLFCHHKILCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x3C15660", Offset = "0x3C14860", VA = "0x183C15660")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void HBNBLBKHDCM(Handle PLFCHHKILCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x3C17350", Offset = "0x3C16550", VA = "0x183C17350")]
	public Handle KHJJFODAIPN()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x3C168D0", Offset = "0x3C15AD0", VA = "0x183C168D0")]
	public void IMOLBDDPOPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x3C15E20", Offset = "0x3C15020", VA = "0x183C15E20")]
	public void IAEHFAMDPLH(Handle PLFCHHKILCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3C146B0", Offset = "0x3C138B0", VA = "0x183C146B0")]
	public bool EDNGELMMLLC(Handle PLFCHHKILCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0xAD84D0", Offset = "0xAD76D0", VA = "0x180AD84D0")]
	private bool KMGBMOMECAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x3C17220", Offset = "0x3C16420", VA = "0x183C17220")]
	private bool KCKIOBNGPAP(int GMEHLIHLGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x3C13EE0", Offset = "0x3C130E0", VA = "0x183C13EE0")]
	private void DPJOILNPIPF(out int GMEHLIHLGEH, out int EOGFAFNNICF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x3C17820", Offset = "0x3C16A20", VA = "0x183C17820")]
	private void MBEJKHCEDLC(Handle PLFCHHKILCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x3C16250", Offset = "0x3C15450", VA = "0x183C16250")]
	private void IGNHKNDLFEI(int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x3C160B0", Offset = "0x3C152B0", VA = "0x183C160B0")]
	private bool IGCKCCKHMHI(out int GMEHLIHLGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x3C16ED0", Offset = "0x3C160D0", VA = "0x183C16ED0")]
	private static Handle JAEHDBOBCLP(int GMEHLIHLGEH, int EOGFAFNNICF)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[DefaultMember("Item")]
public struct MFEFOKNAOGN<Handle, T> where Handle : ONMCCIDPEOK, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private global::DOHBIFCKEGF<Handle> INEBDEENHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private T[] JPOALJOJAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private Action<T> IALBGMFNJAI;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool OEPEEFKGKGF
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x2625BD0", Offset = "0x2624DD0", VA = "0x182625BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int EPBJKODLMLB
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x26247E0", Offset = "0x26239E0", VA = "0x1826247E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x2622D50", Offset = "0x2621F50", VA = "0x182622D50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x2625700", Offset = "0x2624900", VA = "0x182625700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x2625F00", Offset = "0x2625100", VA = "0x182625F00")]
	public MFEFOKNAOGN(int MMLIEOIKGGL, [Optional] Action<T> IALBGMFNJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x2622BA0", Offset = "0x2621DA0", VA = "0x182622BA0")]
	public void AFELIDKEEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2623E50", Offset = "0x2623050", VA = "0x182623E50")]
	public bool CCKJJBMAMBF(Handle PLFCHHKILCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void HBNBLBKHDCM(Handle PLFCHHKILCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x26243F0", Offset = "0x26235F0", VA = "0x1826243F0")]
	public T HHCPOGCCGNF(Handle PLFCHHKILCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x26244B0", Offset = "0x26236B0", VA = "0x1826244B0")]
	public bool IJDPOKFHBJA(Handle PLFCHHKILCM, out T ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x2625B30", Offset = "0x2624D30", VA = "0x182625B30")]
	public void PLCAKFAMFIL(Handle PLFCHHKILCM, T GOLKJDAMBOF, out T INGPOLCICFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x2625A10", Offset = "0x2624C10", VA = "0x182625A10")]
	public void PLCAKFAMFIL(Handle PLFCHHKILCM, T GOLKJDAMBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x2623310", Offset = "0x2622510", VA = "0x182623310")]
	public bool AOHLPHLILHI(Handle PLFCHHKILCM, T GOLKJDAMBOF, out T INGPOLCICFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2622E70", Offset = "0x2622070", VA = "0x182622E70")]
	public bool AOHLPHLILHI(Handle PLFCHHKILCM, T GOLKJDAMBOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2624220", Offset = "0x2623420", VA = "0x182624220")]
	public Handle CPCILMEHKPA(T ICHBECDKHOJ)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x26234F0", Offset = "0x26226F0", VA = "0x1826234F0")]
	public void BJMNFFHNJDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2624DC0", Offset = "0x2623FC0", VA = "0x182624DC0")]
	public void MILDLLFOGOM(Handle PLFCHHKILCM, out T INGPOLCICFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x2624BE0", Offset = "0x2623DE0", VA = "0x182624BE0")]
	public void MILDLLFOGOM(Handle PLFCHHKILCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x26255C0", Offset = "0x26247C0", VA = "0x1826255C0")]
	public bool NHIJNHCGHBB(Handle PLFCHHKILCM, out T INGPOLCICFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x2625160", Offset = "0x2624360", VA = "0x182625160")]
	public bool NHIJNHCGHBB(Handle PLFCHHKILCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x26256A0", Offset = "0x26248A0", VA = "0x1826256A0")]
	private T PDJCDCJJNPH(int GMEHLIHLGEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x2624320", Offset = "0x2623520", VA = "0x182624320")]
	private void ENLOKNJJMLM(int GMPECCKAPPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class MMKGBMOBGDF<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Stack<T> IOKGCKHEEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly List<T> AOGOFPCEJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly int BIKBGOKEPGB;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int GOLPKKPKCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x1B45720", Offset = "0x1B44920", VA = "0x181B45720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int FCJCMNLPDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x21A1490", Offset = "0x21A0690", VA = "0x1821A1490")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x2410CF0", Offset = "0x240FEF0", VA = "0x182410CF0")]
	public static global::MMKGBMOBGDF<T> BPFHHDOKKII(int FAPOEIDOLFP = 0, int BIKBGOKEPGB = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2410FC0", Offset = "0x24101C0", VA = "0x182410FC0")]
	public static global::MMKGBMOBGDF<T> FOKEIEEBLLG(int FAPOEIDOLFP = 0, int BIKBGOKEPGB = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x24115A0", Offset = "0x24107A0", VA = "0x1824115A0")]
	public MMKGBMOBGDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x2411410", Offset = "0x2410610", VA = "0x182411410")]
	public MMKGBMOBGDF(int FAPOEIDOLFP, int BIKBGOKEPGB = int.MaxValue, bool DFLOKMNNFHN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2410DC0", Offset = "0x240FFC0", VA = "0x182410DC0")]
	public T CKPFPCMEEHI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2411090", Offset = "0x2410290", VA = "0x182411090")]
	public void MBLNKLCECMD(T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2410C20", Offset = "0x240FE20", VA = "0x182410C20")]
	private void BJPCNKFIIOJ(T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x24113F0", Offset = "0x24105F0", VA = "0x1824113F0")]
	private void OIMKAFBCHBA(T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x2411370", Offset = "0x2410570", VA = "0x182411370")]
	[Conditional("DEBUG_BUILD")]
	private void ODCODKMOOJC(T KLMCNEIFLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x2411140", Offset = "0x2410340", VA = "0x182411140")]
	[Conditional("DEBUG_BUILD")]
	private void MKLGIECKCJA(T KLMCNEIFLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x2410ED0", Offset = "0x24100D0", VA = "0x182410ED0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x24111D0", Offset = "0x24103D0", VA = "0x1824111D0")]
	private void NOJAEHBJPOC(IEnumerable<T> MKPAEINNGNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class ONFONCEBGPD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private Dictionary<int, T> OEGCIGPEFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private T MFLGMNEPOJC;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T AOLLAPFKFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x6FFB00", Offset = "0x6FED00", VA = "0x1806FFB00", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool OFEGJNJAJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x4358600", Offset = "0x4357800", VA = "0x184358600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x4358540", Offset = "0x4357740", VA = "0x184358540")]
	public bool NBGMFEOMHDO(T IPMIIEAGJKC, int LAGADKBKLAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x4358450", Offset = "0x4357650", VA = "0x184358450")]
	public bool GDINGAPJGOI(int LAGADKBKLAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x4358260", Offset = "0x4357460", VA = "0x184358260")]
	public T DIPPCKIELMC(int CIMEHOCNJPP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x43584B0", Offset = "0x43576B0", VA = "0x1843584B0")]
	public void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x4357EC0", Offset = "0x43570C0", VA = "0x184357EC0")]
	private bool BDOCMAMMBCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x4358510", Offset = "0x4357710", VA = "0x184358510")]
	public bool HOAIDNCFMEI(int LAGADKBKLAD, out T IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x4358640", Offset = "0x4357840", VA = "0x184358640")]
	public ONFONCEBGPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class FLJMJFNJMFP<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	protected struct AODHEAMBGAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public T LKDHJKNGKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public int LDHIBGALEDK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	protected readonly List<AODHEAMBGAC> JGHJLJLPGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private T OJLCILOKFCN;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x1932D80", Offset = "0x1931F80", VA = "0x181932D80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2F42C60", Offset = "0x2F41E60", VA = "0x182F42C60")]
	public bool BPCENLKELKP(T IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x2F43030", Offset = "0x2F42230", VA = "0x182F43030")]
	public void CPCILMEHKPA(T IPMIIEAGJKC, int LAGADKBKLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2F43210", Offset = "0x2F42410", VA = "0x182F43210")]
	public bool MILDLLFOGOM(T IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x2F431B0", Offset = "0x2F423B0", VA = "0x182F431B0")]
	public void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2F43140", Offset = "0x2F42340", VA = "0x182F43140")]
	public T GJCIHJDKMHJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2F430D0", Offset = "0x2F422D0", VA = "0x182F430D0")]
	public T DMHGMKKDBDG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2F42E70", Offset = "0x2F42070", VA = "0x182F42E70")]
	private void CLCEIHFDHBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x2F43330", Offset = "0x2F42530", VA = "0x182F43330")]
	public FLJMJFNJMFP()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		[ELEHEHIOAGB(MFGBMPAPHGB.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x6624700", Offset = "0x6623900", VA = "0x186624700")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x6624A90", Offset = "0x6623C90", VA = "0x186624A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x6624910", Offset = "0x6623B10", VA = "0x186624910")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x6624BF0", Offset = "0x6623DF0", VA = "0x186624BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x6624620", Offset = "0x6623820", VA = "0x186624620")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x66249B0", Offset = "0x6623BB0", VA = "0x1866249B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x6624830", Offset = "0x6623A30", VA = "0x186624830")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x66245D0", Offset = "0x66237D0", VA = "0x1866245D0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public interface IKNLDBOLLMA
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public abstract class ResourcePrefabReference<T> : IKNLDBOLLMA where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x1F1B490", Offset = "0x1F1A690", VA = "0x181F1B490", Slot = "4")]
		public virtual T EEOHKMPFBKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class GLPBGPCBBCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private readonly Dictionary<byte, ICENLMEELBA> ABLNIKGHCMC;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public ICENLMEELBA NOCABECCPBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x82F780", Offset = "0x82E980", VA = "0x18082F780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 OGJOBFKEALM
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x15FDB40", Offset = "0x15FCD40", VA = "0x1815FDB40")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xA71AC0", Offset = "0xA70CC0", VA = "0x180A71AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 IIKBLFJIHLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x1E31E50", Offset = "0x1E31050", VA = "0x181E31E50")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA10720", Offset = "0xA0F920", VA = "0x180A10720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 KEIJHCPOGEF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x661EBD0", Offset = "0x661DDD0", VA = "0x18661EBD0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xEE3F20", Offset = "0xEE3120", VA = "0x180EE3F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int JFCNKGCGOHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6FB860", Offset = "0x6FAA60", VA = "0x1806FB860")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x85A6D0", Offset = "0x8598D0", VA = "0x18085A6D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x661F050", Offset = "0x661E250", VA = "0x18661F050")]
	public GLPBGPCBBCO(Bounds HOOKNECCJFJ, Vector2[] ACJBGEJMJGD, int MCDANPKPFBG, byte JDHIICINABH, float ILDNNKGNIBE = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x661EFF0", Offset = "0x661E1F0", VA = "0x18661EFF0")]
	public ICENLMEELBA OLECAIHEPOE(byte GMEHLIHLGEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x661EAD0", Offset = "0x661DCD0", VA = "0x18661EAD0")]
	public void DPEHMLLOPBB(Vector3 INLGLHIPOMC, float KIFJHLFLMCE, float JJALJHJCKPA, ref List<byte> NKLFPKJCGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x661E950", Offset = "0x661DB50", VA = "0x18661E950")]
	public void DABGCMADHEE(ICENLMEELBA.LMNBKADDPDK LIOMIFMCKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x661E970", Offset = "0x661DB70", VA = "0x18661E970")]
	private ICENLMEELBA DLFGFALGNCK(byte GMEHLIHLGEH, ICENLMEELBA.CJKCCMHKGMC KGNLILIOCJG, ICENLMEELBA HHFDFFDPCGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x661EBF0", Offset = "0x661DDF0", VA = "0x18661EBF0")]
	private void HJMDJCFAOLC(ICENLMEELBA HHFDFFDPCGO, Vector2[] ACJBGEJMJGD, int DPMMLDIFHIP, int NHMJLFBAMPK, int LNHIEJONANH, int FKGIJCLHLDC, float ILDNNKGNIBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class ICENLMEELBA
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public enum CJKCCMHKGMC
	{
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public enum LMNBKADDPDK
	{
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public byte GHIEHEOOCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public Vector3 PJGJPKCAGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public Vector3 HEIPHEGLBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector3 EPECEOLLDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Vector3 OPBFABHCJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public CJKCCMHKGMC CPHOBHNMLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public ICENLMEELBA HKAHNOCIENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public List<ICENLMEELBA> CPEPEEMHGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public bool MAIKJOOGILB;

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x6620200", Offset = "0x661F400", VA = "0x186620200")]
	public ICENLMEELBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x66201A0", Offset = "0x661F3A0", VA = "0x1866201A0")]
	public ICENLMEELBA(byte IKHNIJKGJFD, CJKCCMHKGMC KGNLILIOCJG, ICENLMEELBA HHFDFFDPCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6620050", Offset = "0x661F250", VA = "0x186620050")]
	public void HDJNLHIMONE(ICENLMEELBA AAFNLLCIFBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	public void DABGCMADHEE(int PFOOBEGPCPG, LMNBKADDPDK LIOMIFMCKOJ, int OFMKJBIBDCL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x661FDA0", Offset = "0x661EFA0", VA = "0x18661FDA0")]
	public void DPEHMLLOPBB(List<byte> NKLFPKJCGCE, Vector3 INLGLHIPOMC, float KIFJHLFLMCE, float JJALJHJCKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6620110", Offset = "0x661F310", VA = "0x186620110")]
	public bool KOCIEBFMPGL(Vector3 PDFEDMAOMNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6620160", Offset = "0x661F360", VA = "0x186620160")]
	public bool PJOGPPILAOK(Vector3 PDFEDMAOMNH, float HABGGLIGKCJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class JJAKKMCBMPE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly Dictionary<T, object> EFMDPDFNDNP;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x1934CE0", Offset = "0x1933EE0", VA = "0x181934CE0")]
	public bool HNEPGFJIFFC(T IEJFFJNKFMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x233ED60", Offset = "0x233DF60", VA = "0x18233ED60")]
	public bool HNEPGFJIFFC(T IEJFFJNKFMK, object IALNODEHBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x233ED00", Offset = "0x233DF00", VA = "0x18233ED00")]
	public bool HNEPGFJIFFC(T IEJFFJNKFMK, object IALNODEHBNN, out object IBLNLOCNJCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x233EE30", Offset = "0x233E030", VA = "0x18233EE30")]
	public bool JMMGIGDNEEJ(T IEJFFJNKFMK, object IALNODEHBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x233ECC0", Offset = "0x233DEC0", VA = "0x18233ECC0")]
	public bool DNGEJKKPAPC(T IEJFFJNKFMK, object IALNODEHBNN, out object IBLNLOCNJCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x233EDA0", Offset = "0x233DFA0", VA = "0x18233EDA0")]
	public bool JMMGIGDNEEJ(T IEJFFJNKFMK, object IALNODEHBNN, out object IBLNLOCNJCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x233EC90", Offset = "0x233DE90", VA = "0x18233EC90")]
	public void ACDHCKDGNAN(T IEJFFJNKFMK, object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x233EE70", Offset = "0x233E070", VA = "0x18233EE70")]
	public void MGBNCINMPAD(T IEJFFJNKFMK, object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x233EF10", Offset = "0x233E110", VA = "0x18233EF10")]
	public JJAKKMCBMPE()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		public struct JOMANGOOOJF<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			private readonly List<Component> JAAGBDPDCIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			private readonly bool AAADJPJJFDJ;

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0xD970A0", Offset = "0xD962A0", VA = "0x180D970A0")]
			public JOMANGOOOJF(List<Component> JAAGBDPDCIE, bool AAADJPJJFDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x2141530", Offset = "0x2140730", VA = "0x182141530")]
			public BIJPGFBMNHH<T> BECNODPGHJK()
			{
				return default(BIJPGFBMNHH<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x21415A0", Offset = "0x21407A0", VA = "0x1821415A0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x21415A0", Offset = "0x21407A0", VA = "0x1821415A0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		public struct BIJPGFBMNHH<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private readonly List<Component> JAAGBDPDCIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private readonly bool AAADJPJJFDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private int GMEHLIHLGEH;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T DMBDEPMHMNP
			{
				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0x21C4160", Offset = "0x21C3360", VA = "0x1821C4160", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003E3")]
				[Cpp2IlInjected.Address(RVA = "0x21C40F0", Offset = "0x21C32F0", VA = "0x1821C40F0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x21C4130", Offset = "0x21C3330", VA = "0x1821C4130")]
			public BIJPGFBMNHH(List<Component> JAAGBDPDCIE, bool AAADJPJJFDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x21C4020", Offset = "0x21C3220", VA = "0x1821C4020", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x21C4030", Offset = "0x21C3230", VA = "0x1821C4030", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x21C40E0", Offset = "0x21C32E0", VA = "0x1821C40E0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x66268C0", Offset = "0x6625AC0", VA = "0x1866268C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x6626880", Offset = "0x6625A80", VA = "0x186626880")]
		public ToolHierarchyCache(GameObject HKPJJHILEBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x6626170", Offset = "0x6625370", VA = "0x186626170")]
		private void IHEKMEOIBOI(GameObject HKPJJHILEBG, bool COPOILGLIAJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x66262D0", Offset = "0x66254D0", VA = "0x1866262D0")]
		public static void IHEKMEOIBOI(GameObject HKPJJHILEBG, ref ToolHierarchyCache MGGAFPGBPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x66260E0", Offset = "0x66252E0", VA = "0x1866260E0")]
		public void GODLBKDFPDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x6626010", Offset = "0x6625210", VA = "0x186626010")]
		public void EGJBMNPICPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2D53770", Offset = "0x2D52970", VA = "0x182D53770")]
		public void HBGIGPAPOBA<T>(Action<T> IBKGKDECOEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x6626730", Offset = "0x6625930", VA = "0x186626730")]
		public Component PKFLMDHHBKE(Type NIFOGEBEDNG, bool AAADJPJJFDJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2D53AD0", Offset = "0x2D52CD0", VA = "0x182D53AD0")]
		public T PKFLMDHHBKE<T>(bool AAADJPJJFDJ = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x6626360", Offset = "0x6625560", VA = "0x186626360")]
		public JOMANGOOOJF<Component> MEPHJAFACCB(Type NIFOGEBEDNG, bool AAADJPJJFDJ = false)
		{
			return default(JOMANGOOOJF<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x2D53A00", Offset = "0x2D52C00", VA = "0x182D53A00")]
		public JOMANGOOOJF<T> MEPHJAFACCB<T>(bool AAADJPJJFDJ = false) where T : class
		{
			return default(JOMANGOOOJF<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x66263E0", Offset = "0x66255E0", VA = "0x1866263E0")]
		public List<Component> OJPDPHCMDMN(Type NIFOGEBEDNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x6626060", Offset = "0x6625260", VA = "0x186626060", Slot = "4")]
		public bool Equals(ToolHierarchyCache FCCGDNMAHPA, ToolHierarchyCache BADLFKONABM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x66260F0", Offset = "0x66252F0", VA = "0x1866260F0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache ICHBECDKHOJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class ADIBECMODCM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private int FAPOEIDOLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private int LMHMLMPCJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private List<T> DKIPBFCBBBG;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x1B45720", Offset = "0x1B44920", VA = "0x181B45720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T EDOFMOHMNAN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x1BAF0E0", Offset = "0x1BAE2E0", VA = "0x181BAF0E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T LAFAOOJHJAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x1BAF1B0", Offset = "0x1BAE3B0", VA = "0x181BAF1B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T HNMPCJHHKCI
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x1BAF300", Offset = "0x1BAE500", VA = "0x181BAF300")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x1BAF3B0", Offset = "0x1BAE5B0", VA = "0x181BAF3B0")]
	public ADIBECMODCM(int FAPOEIDOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x1BAEE70", Offset = "0x1BAE070", VA = "0x181BAEE70")]
	public void CPCILMEHKPA(T KCHOJOEJIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x1BAF020", Offset = "0x1BAE220", VA = "0x181BAF020")]
	public void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x1BAF210", Offset = "0x1BAE410", VA = "0x181BAF210")]
	public void IFKKOCEDBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x1BAF2B0", Offset = "0x1BAE4B0", VA = "0x181BAF2B0")]
	public void MFPHKPPPPFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x1BAEE60", Offset = "0x1BAE060", VA = "0x181BAEE60")]
	public void BHECJJGPKLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public class KBIPJAKAJOM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private bool PEEGPFGOBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private Action IBKGKDECOEG;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static KBIPJAKAJOM FFBNAEOEIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x6620710", Offset = "0x661F910", VA = "0x186620710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool OGEPDGHINAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x707B80", Offset = "0x706D80", VA = "0x180707B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x133D310", Offset = "0x133C510", VA = "0x18133D310")]
	public KBIPJAKAJOM(Action IBKGKDECOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x66206F0", Offset = "0x661F8F0", VA = "0x1866206F0")]
	public void ANFOOJOGONB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x66206F0", Offset = "0x661F8F0", VA = "0x1866206F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class EACHENNKLOA
{
	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x661DB80", Offset = "0x661CD80", VA = "0x18661DB80")]
	public static void OEODOKLHEKK(FIHGBEHGLGB NCJCLJGCIMF, string KHPAEFAEHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	public static void OEODOKLHEKK(IEnumerable<object> LKGFBGELPCN, string KHPAEFAEHDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class AFHOAHNAMGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private struct IDPDPBDCJNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public int LDHIBGALEDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public T LKDHJKNGKHD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly Dictionary<object, IDPDPBDCJNF> OEGCIGPEFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly EqualityComparer<T> OBEKFLMCPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private T MFLGMNEPOJC;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T AOLLAPFKFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xB53DB0", Offset = "0xB52FB0", VA = "0x180B53DB0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x2189850", Offset = "0x2188A50", VA = "0x182189850", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool OFEGJNJAJBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x29E8C50", Offset = "0x29E7E50", VA = "0x1829E8C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object JGNDJNMOGFI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x7B43F0", Offset = "0x7B35F0", VA = "0x1807B43F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x29E8610", Offset = "0x29E7810", VA = "0x1829E8610")]
	public bool NBGMFEOMHDO(T IPMIIEAGJKC, object IALNODEHBNN, int LAGADKBKLAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x29E7CE0", Offset = "0x29E6EE0", VA = "0x1829E7CE0")]
	public bool GDINGAPJGOI(object IALNODEHBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x29E8270", Offset = "0x29E7470", VA = "0x1829E8270")]
	public bool HOAIDNCFMEI(object IALNODEHBNN, out T IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x2134860", Offset = "0x2133A60", VA = "0x182134860")]
	public void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x29E73E0", Offset = "0x29E65E0", VA = "0x1829E73E0")]
	private bool BDOCMAMMBCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x29E8C80", Offset = "0x29E7E80", VA = "0x1829E8C80")]
	public AFHOAHNAMGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class NCIMIGIHJDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private Dictionary<object, float> OEGCIGPEFGP;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float CANNOEIKFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xB53E30", Offset = "0xB53030", VA = "0x180B53E30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xD9DB70", Offset = "0xD9CD70", VA = "0x180D9DB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x6621230", Offset = "0x6620430", VA = "0x186621230")]
	public void NBGMFEOMHDO(float IPMIIEAGJKC, object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x66210A0", Offset = "0x66202A0", VA = "0x1866210A0")]
	public void GDINGAPJGOI(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x6621110", Offset = "0x6620310", VA = "0x186621110")]
	private void GOIFONCLPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x66212A0", Offset = "0x66204A0", VA = "0x1866212A0")]
	public NCIMIGIHJDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class MDKHKMMJIAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public readonly string AFDAONNKPOK;

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x7A4ED0", Offset = "0x7A40D0", VA = "0x1807A4ED0")]
	public MDKHKMMJIAB(string HAOPNHBOOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x6620D70", Offset = "0x661FF70", VA = "0x186620D70")]
	public MDKHKMMJIAB(UnityEngine.Object DGMNHOPJOJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x6620D20", Offset = "0x661FF20", VA = "0x186620D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public sealed class FIHGBEHGLGB
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class GOPGHFDLMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public GOPGHFDLMJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x661FB70", Offset = "0x661ED70", VA = "0x18661FB70")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private HashSet<object> LKGFBGELPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private int HOCLIKKLNLG;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> NHEINPMGMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x661E480", Offset = "0x661D680", VA = "0x18661E480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool OGFHDNBGHMH
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x661E5F0", Offset = "0x661D7F0", VA = "0x18661E5F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x7DEBF0", Offset = "0x7DDDF0", VA = "0x1807DEBF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x661E390", Offset = "0x661D590", VA = "0x18661E390")]
	public bool CPCILMEHKPA(object IALNODEHBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x661E550", Offset = "0x661D750", VA = "0x18661E550")]
	public bool MILDLLFOGOM(object IALNODEHBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x661E330", Offset = "0x661D530", VA = "0x18661E330")]
	public bool BPCENLKELKP(object IALNODEHBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x661E600", Offset = "0x661D800", VA = "0x18661E600")]
	public void PKOFJCGKMJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x661E670", Offset = "0x661D870", VA = "0x18661E670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public FIHGBEHGLGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class MKJNCDLHHNA<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private struct INDCNHJIAPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public float KJFMJKBBIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public T LKDHJKNGKHD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private Dictionary<object, INDCNHJIAPL> OEGCIGPEFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private T GJKJBFANOKJ;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T BHMIODMAGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x9D1870", Offset = "0x9D0A70", VA = "0x1809D1870", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1060560", Offset = "0x105F760", VA = "0x181060560", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object EAGDNENIDEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x7B43F0", Offset = "0x7B35F0", VA = "0x1807B43F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool OFEGJNJAJBD
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x262D020", Offset = "0x262C220", VA = "0x18262D020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x262CE50", Offset = "0x262C050", VA = "0x18262CE50")]
	public bool NBGMFEOMHDO(T IPMIIEAGJKC, object IALNODEHBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x262C780", Offset = "0x262B980", VA = "0x18262C780")]
	public bool GDINGAPJGOI(object IALNODEHBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x2134860", Offset = "0x2133A60", VA = "0x182134860")]
	public void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x262C7E0", Offset = "0x262B9E0", VA = "0x18262C7E0")]
	public bool HOAIDNCFMEI(object IALNODEHBNN, out T IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x262BDF0", Offset = "0x262AFF0", VA = "0x18262BDF0")]
	private bool BDOCMAMMBCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x262D060", Offset = "0x262C260", VA = "0x18262D060")]
	public MKJNCDLHHNA()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class NFLCIDIFMGO
{
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static byte[] OFIIJNPNABI;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static int AJJJCGJNNOF;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static int HJKCCLPHOML;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static BigInteger KJPEHCDEKDE;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NFLCIDIFMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x6621320", Offset = "0x6620520", VA = "0x186621320")]
	private static string DHECIEFNHGE(byte[] EFNJCAIBDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x6621430", Offset = "0x6620630", VA = "0x186621430")]
	public static string EAFEFBMLFGD(byte[] ODBGNNDKAMK, bool MKOEKIGFDJD)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
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
