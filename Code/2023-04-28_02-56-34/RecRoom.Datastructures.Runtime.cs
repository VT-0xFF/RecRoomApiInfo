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
public class DOALBNIBMPE : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x778740", Offset = "0x777140", VA = "0x180778740")]
	public DOALBNIBMPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, FAIGGLEHEDM, LKBIMFKHBEM, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x730AF0", Offset = "0x72F4F0", VA = "0x180730AF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74C3F0", Offset = "0x74ADF0", VA = "0x18074C3F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84FC20", Offset = "0x84E620", VA = "0x18084FC20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash IECKGMJMGEA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xDC40C0", Offset = "0xDC2AC0", VA = "0x180DC40C0")]
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
	[CHFCICJFDEJ]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[CHFCICJFDEJ]
	[SerializeField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68ED2A0", Offset = "0x68EBCA0", VA = "0x1868ED2A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68ED260", Offset = "0x68EBC60", VA = "0x1868ED260")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x68ED2E0", Offset = "0x68EBCE0", VA = "0x1868ED2E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x68ED4B0", Offset = "0x68EBEB0", VA = "0x1868ED4B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x68ED420", Offset = "0x68EBE20", VA = "0x1868ED420")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xE61050", Offset = "0xE5FA50", VA = "0x180E61050")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xEF8A50", Offset = "0xEF7450", VA = "0x180EF8A50")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x68ED220", Offset = "0x68EBC20", VA = "0x1868ED220")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x68ED390", Offset = "0x68EBD90", VA = "0x1868ED390")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x68ECC60", Offset = "0x68EB660", VA = "0x1868ECC60")]
	public void CopyBounds(SavedExtents MPHACEGLFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68ED180", Offset = "0x68EBB80", VA = "0x1868ED180")]
	public void SetLocalSpaceBounds(Bounds FLPLLNOELMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x11E94A0", Offset = "0x11E7EA0", VA = "0x1811E94A0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x68ED170", Offset = "0x68EBB70", VA = "0x1868ED170")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68ECD50", Offset = "0x68EB750", VA = "0x1868ECD50")]
	private void IEBCGMFAIDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68ECF40", Offset = "0x68EB940", VA = "0x1868ECF40")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x68EC620", Offset = "0x68EB020", VA = "0x1868EC620")]
	public static void CalculateLocalBoundsFor(GameObject DLNMCGFEPOP, out Bounds FLPLLNOELMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68ECC90", Offset = "0x68EB690", VA = "0x1868ECC90")]
	private static void GJLHMFIKAIK(Bounds GFCGIJPPCBN, Color ENPEAFFEEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x68ED1A0", Offset = "0x68EBBA0", VA = "0x1868ED1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x727020", Offset = "0x725A20", VA = "0x180727020")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7318F0", Offset = "0x7302F0", VA = "0x1807318F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1063EC0", Offset = "0x10628C0", VA = "0x181063EC0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA9FC50", Offset = "0xA9E650", VA = "0x180A9FC50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "4")]
	public virtual void KAOPMFLIGPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
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
	[DOALBNIBMPE]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3658AC0", Offset = "0x36574C0", VA = "0x183658AC0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x36581F0", Offset = "0x3656BF0", VA = "0x1836581F0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3659000", Offset = "0x3657A00", VA = "0x183659000")]
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
	private sealed class JKFHJNAPHDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public JKFHJNAPHDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x33347A0", Offset = "0x33331A0", VA = "0x1833347A0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[DOALBNIBMPE]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x225B6C0", Offset = "0x225A0C0", VA = "0x18225B6C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x225B6F0", Offset = "0x225A0F0", VA = "0x18225B6F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x225B610", Offset = "0x225A010", VA = "0x18225B610", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey OGFDNCPKECB]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x225B670", Offset = "0x225A070", VA = "0x18225B670", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x225B510", Offset = "0x2259F10", VA = "0x18225B510", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x225B060", Offset = "0x2259A60", VA = "0x18225B060", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x225A880", Offset = "0x2259280", VA = "0x18225A880", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x225A500", Offset = "0x2258F00", VA = "0x18225A500", Slot = "14")]
	protected virtual string JNBIFEMJNDI(TKeyVal KIOPLOOGKCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x225A410", Offset = "0x2258E10", VA = "0x18225A410", Slot = "4")]
	public bool ContainsKey(TKey OGFDNCPKECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x225B400", Offset = "0x2259E00", VA = "0x18225B400", Slot = "5")]
	public bool TryGetValue(TKey OGFDNCPKECB, out TVal LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x225A440", Offset = "0x2258E40", VA = "0x18225A440", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x225A440", Offset = "0x2258E40", VA = "0x18225A440", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x225B430", Offset = "0x2259E30", VA = "0x18225B430")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HMNMDKHJCOA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class MONIEOCKDJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public MONIEOCKDJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3035140", Offset = "0x3033B40", VA = "0x183035140")]
		internal bool <GetSamples>b__0(global::KHDOJBFMABD<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float PGFKDMAMGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float CKJODAJNIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::KHDOJBFMABD<float, T>> PMGGNKHIHEI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int MDDJEKPNEJA
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2FD2000", Offset = "0x2FD0A00", VA = "0x182FD2000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2FD2780", Offset = "0x2FD1180", VA = "0x182FD2780")]
	public HMNMDKHJCOA(float EGIFDOFGJJL, float INLLLKDCDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2FD1EA0", Offset = "0x2FD08A0", VA = "0x182FD1EA0")]
	public bool IDJENFJOIIJ(float LAOEDLDFAJL, T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2FD1CE0", Offset = "0x2FD06E0", VA = "0x182FD1CE0")]
	public int FEDOLLPBIJL(float LAOEDLDFAJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2FD2100", Offset = "0x2FD0B00", VA = "0x182FD2100")]
	public IEnumerable<T> OMNMNGOJFJD(float LAOEDLDFAJL, [Optional] float? KBJIGJPDOGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2FD1BF0", Offset = "0x2FD05F0", VA = "0x182FD1BF0")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2FD1C20", Offset = "0x2FD0620", VA = "0x182FD1C20")]
	private void CJGGDCDHKLD(float LAOEDLDFAJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class FFANKEEFKID<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct PKODMJABIDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T NDNOLKCBONM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float PKIGECIECGK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float BKAOAGEHAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> DBNDJPCHPEO;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int MPFJCHNJHIB = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private PKODMJABIDJ[] BGAKDGCGOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int DOFKJNFAGGN;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float OKNKBFPIIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x115F980", Offset = "0x115E380", VA = "0x18115F980")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x12556F0", Offset = "0x12540F0", VA = "0x1812556F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x38B4400", Offset = "0x38B2E00", VA = "0x1838B4400")]
	public FFANKEEFKID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x38B4430", Offset = "0x38B2E30", VA = "0x1838B4430")]
	public FFANKEEFKID(int GBNBGNMHGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x38B3030", Offset = "0x38B1A30", VA = "0x1838B3030")]
	public void AGMLDLCGDGN(float LAOEDLDFAJL, T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x38B31D0", Offset = "0x38B1BD0", VA = "0x1838B31D0")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x38B3990", Offset = "0x38B2390", VA = "0x1838B3990")]
	public bool FGEOKDFCOPE(float DELPKOCBGIP, float CEPELLGJCAI, out T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x38B4200", Offset = "0x38B2C00", VA = "0x1838B4200")]
	public bool KDKAMCIHOJM(float DELPKOCBGIP, float CEPELLGJCAI, out T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x38B3C90", Offset = "0x38B2690", VA = "0x1838B3C90")]
	public void KACPOLHKOCD(float DELPKOCBGIP, float CEPELLGJCAI, List<T> NPOGECPDPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x38B3B50", Offset = "0x38B2550", VA = "0x1838B3B50")]
	private int IMBKPKMPHEI(int DPKHDGOBNNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x38B4370", Offset = "0x38B2D70", VA = "0x1838B4370")]
	private void LMDCCEHMKFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GOJLNPEDGJA();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T OPNBMENLDND(T GBEJHLEFDJM, T BDGBOHJLNIE, float FOHPMIEDDCH);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T GIDKIJHPLDC(T LPJDDLMPNCG, float FOHPMIEDDCH);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T GFBCKLOIMNI(T GBEJHLEFDJM, T BDGBOHJLNIE);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T DCKEFAHDOKG(T GBEJHLEFDJM, T BDGBOHJLNIE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OBMFKBLCPGA : global::FFANKEEFKID<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1293A80", Offset = "0x1292480", VA = "0x181293A80", Slot = "4")]
	protected override Vector3 GOJLNPEDGJA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x16496A0", Offset = "0x16480A0", VA = "0x1816496A0", Slot = "5")]
	protected override Vector3 OPNBMENLDND(Vector3 GBEJHLEFDJM, Vector3 BDGBOHJLNIE, float FOHPMIEDDCH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x68EAE60", Offset = "0x68E9860", VA = "0x1868EAE60", Slot = "6")]
	protected override Vector3 GIDKIJHPLDC(Vector3 LPJDDLMPNCG, float FOHPMIEDDCH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x68EADE0", Offset = "0x68E97E0", VA = "0x1868EADE0", Slot = "7")]
	protected override Vector3 GFBCKLOIMNI(Vector3 GBEJHLEFDJM, Vector3 BDGBOHJLNIE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x68EAD70", Offset = "0x68E9770", VA = "0x1868EAD70", Slot = "8")]
	protected override Vector3 DCKEFAHDOKG(Vector3 GBEJHLEFDJM, Vector3 BDGBOHJLNIE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x68EAEC0", Offset = "0x68E98C0", VA = "0x1868EAEC0")]
	public OBMFKBLCPGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NGNMLEFAJJL : global::FFANKEEFKID<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x68E9AC0", Offset = "0x68E84C0", VA = "0x1868E9AC0")]
	public NGNMLEFAJJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x68E9A50", Offset = "0x68E8450", VA = "0x1868E9A50")]
	public NGNMLEFAJJL(int GBNBGNMHGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x12E9F50", Offset = "0x12E8950", VA = "0x1812E9F50", Slot = "4")]
	protected override float GOJLNPEDGJA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3C37000", Offset = "0x3C35A00", VA = "0x183C37000", Slot = "5")]
	protected override float OPNBMENLDND(float GBEJHLEFDJM, float BDGBOHJLNIE, float FOHPMIEDDCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5655E70", Offset = "0x5654870", VA = "0x185655E70", Slot = "6")]
	protected override float GIDKIJHPLDC(float LPJDDLMPNCG, float FOHPMIEDDCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2DBB780", Offset = "0x2DBA180", VA = "0x182DBB780", Slot = "7")]
	protected override float GFBCKLOIMNI(float GBEJHLEFDJM, float BDGBOHJLNIE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x68E9A40", Offset = "0x68E8440", VA = "0x1868E9A40", Slot = "8")]
	protected override float DCKEFAHDOKG(float GBEJHLEFDJM, float BDGBOHJLNIE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NPJKEOMCHCE
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x25058C0", Offset = "0x25042C0", VA = "0x1825058C0")]
	public static global::IDHEECGILOE<T1> IDIKGABNBEI<T1>(T1 BAAKFPHJJIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2B7ABD0", Offset = "0x2B795D0", VA = "0x182B7ABD0")]
	public static global::KHDOJBFMABD<T1, T2> IDIKGABNBEI<T1, T2>(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2B7AC40", Offset = "0x2B79640", VA = "0x182B7AC40")]
	public static global::ODFDCHKMIJF<T1, T2, T3> IDIKGABNBEI<T1, T2, T3>(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x22000E0", Offset = "0x21FEAE0", VA = "0x1822000E0")]
	public static global::PMONLEGIIKG<T1, T2, T3, T4> IDIKGABNBEI<T1, T2, T3, T4>(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO, T4 PJOMOCIFAJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2B7AF10", Offset = "0x2B79910", VA = "0x182B7AF10")]
	public static global::NNKLGPEJENN<T1, T2, T3, T4, T5> IDIKGABNBEI<T1, T2, T3, T4, T5>(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO, T4 PJOMOCIFAJM, T5 OMFBODPJPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2B7AE60", Offset = "0x2B79860", VA = "0x182B7AE60")]
	public static global::AAECMIKOOPJ<T1, T2, T3, T4, T5, T6> IDIKGABNBEI<T1, T2, T3, T4, T5, T6>(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO, T4 PJOMOCIFAJM, T5 OMFBODPJPAA, T6 CGFBJPGBKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2B7ADA0", Offset = "0x2B797A0", VA = "0x182B7ADA0")]
	public static global::JJNJEJCFCGJ<T1, T2, T3, T4, T5, T6, T7> IDIKGABNBEI<T1, T2, T3, T4, T5, T6, T7>(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO, T4 PJOMOCIFAJM, T5 OMFBODPJPAA, T6 CGFBJPGBKBE, T7 KLCJIHKLGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2B7ACD0", Offset = "0x2B796D0", VA = "0x182B7ACD0")]
	public static global::KDJMGHBAKCH<T1, T2, T3, T4, T5, T6, T7, T8> IDIKGABNBEI<T1, T2, T3, T4, T5, T6, T7, T8>(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO, T4 PJOMOCIFAJM, T5 OMFBODPJPAA, T6 CGFBJPGBKBE, T7 KLCJIHKLGHO, T8 DPMJEHBBNNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1D04C70", Offset = "0x1D03670", VA = "0x181D04C70")]
	[IteratorStateMachine(typeof(GPEFEBJIEPE))]
	public static IEnumerable<global::KHDOJBFMABD<T1, T2>> EEJIMLGNFOI<T1, T2>(IEnumerable<T1> HFOFADIOHHP, IEnumerable<T2> GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1D04DB0", Offset = "0x1D037B0", VA = "0x181D04DB0")]
	[IteratorStateMachine(typeof(HJNPPHCMGEM))]
	public static IEnumerable<global::ODFDCHKMIJF<T1, T2, T3>> EEJIMLGNFOI<T1, T2, T3>(IEnumerable<T1> HFOFADIOHHP, IEnumerable<T2> GFCGIJPPCBN, IEnumerable<T3> ENPEAFFEEPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8969D0", Offset = "0x8953D0", VA = "0x1808969D0")]
	internal static int DECIANJDDBP(int FAGNMGMIOLL, int JINGHNNPNED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8969A0", Offset = "0x8953A0", VA = "0x1808969A0")]
	internal static int DECIANJDDBP(int FAGNMGMIOLL, int JINGHNNPNED, int LBCFNNKCJPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x896980", Offset = "0x895380", VA = "0x180896980")]
	internal static int DECIANJDDBP(int FAGNMGMIOLL, int JINGHNNPNED, int LBCFNNKCJPN, int EIMIBLJJKDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8969B0", Offset = "0x8953B0", VA = "0x1808969B0")]
	internal static int DECIANJDDBP(int FAGNMGMIOLL, int JINGHNNPNED, int LBCFNNKCJPN, int EIMIBLJJKDP, int LDAEEACHNLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x68EAD50", Offset = "0x68E9750", VA = "0x1868EAD50")]
	internal static int DECIANJDDBP(int FAGNMGMIOLL, int JINGHNNPNED, int LBCFNNKCJPN, int EIMIBLJJKDP, int LDAEEACHNLC, int FLGGOBDMODA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x68EAD20", Offset = "0x68E9720", VA = "0x1868EAD20")]
	internal static int DECIANJDDBP(int FAGNMGMIOLL, int JINGHNNPNED, int LBCFNNKCJPN, int EIMIBLJJKDP, int LDAEEACHNLC, int FLGGOBDMODA, int KDPCLKFLOHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x68EACF0", Offset = "0x68E96F0", VA = "0x1868EACF0")]
	internal static int DECIANJDDBP(int FAGNMGMIOLL, int JINGHNNPNED, int LBCFNNKCJPN, int EIMIBLJJKDP, int LDAEEACHNLC, int FLGGOBDMODA, int KDPCLKFLOHF, int DLLMMFNCCHO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IDHEECGILOE<T1> : IComparable<global::IDHEECGILOE<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 ONAMHOIMNII;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x225EE20", Offset = "0x225D820", VA = "0x18225EE20")]
	public IDHEECGILOE(T1 BAAKFPHJJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3001820", Offset = "0x3000220", VA = "0x183001820", Slot = "4")]
	public int CompareTo(global::IDHEECGILOE<T1> MPHACEGLFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3001890", Offset = "0x3000290", VA = "0x183001890", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xC066A0", Offset = "0xC050A0", VA = "0x180C066A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3001930", Offset = "0x3000330", VA = "0x183001930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KHDOJBFMABD<T1, T2> : IComparable<global::KHDOJBFMABD<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 ONAMHOIMNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 BJJJAGPPKKC;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2D30830", Offset = "0x2D2F230", VA = "0x182D30830")]
	public KHDOJBFMABD(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x38E75C0", Offset = "0x38E5FC0", VA = "0x1838E75C0", Slot = "4")]
	public int CompareTo(global::KHDOJBFMABD<T1, T2> MPHACEGLFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x38E7CB0", Offset = "0x38E66B0", VA = "0x1838E7CB0", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x38E8460", Offset = "0x38E6E60", VA = "0x1838E8460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x38E8E10", Offset = "0x38E7810", VA = "0x1838E8E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ODFDCHKMIJF<T1, T2, T3> : IComparable<global::ODFDCHKMIJF<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 ONAMHOIMNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 BJJJAGPPKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 FAHENIFLPFL;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2D2CD40", Offset = "0x2D2B740", VA = "0x182D2CD40")]
	public ODFDCHKMIJF(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C530", Offset = "0x2D2AF30", VA = "0x182D2C530", Slot = "4")]
	public int CompareTo(global::ODFDCHKMIJF<T1, T2, T3> MPHACEGLFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C730", Offset = "0x2D2B130", VA = "0x182D2C730", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2D2CA20", Offset = "0x2D2B420", VA = "0x182D2CA20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2D2CA80", Offset = "0x2D2B480", VA = "0x182D2CA80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class PMONLEGIIKG<T1, T2, T3, T4> : IComparable<global::PMONLEGIIKG<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 ONAMHOIMNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 BJJJAGPPKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 FAHENIFLPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 HKBNACIMEHF;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2298620", Offset = "0x2297020", VA = "0x182298620")]
	public PMONLEGIIKG(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO, T4 PJOMOCIFAJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2619470", Offset = "0x2617E70", VA = "0x182619470", Slot = "4")]
	public int CompareTo(global::PMONLEGIIKG<T1, T2, T3, T4> MPHACEGLFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x26195B0", Offset = "0x2617FB0", VA = "0x1826195B0", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x26196D0", Offset = "0x26180D0", VA = "0x1826196D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2619790", Offset = "0x2618190", VA = "0x182619790", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NNKLGPEJENN<T1, T2, T3, T4, T5> : IComparable<global::NNKLGPEJENN<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 ONAMHOIMNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 BJJJAGPPKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 FAHENIFLPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 HKBNACIMEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 ONLMGLFJHAO;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x398A1F0", Offset = "0x3988BF0", VA = "0x18398A1F0")]
	public NNKLGPEJENN(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO, T4 PJOMOCIFAJM, T5 OMFBODPJPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3989CE0", Offset = "0x39886E0", VA = "0x183989CE0", Slot = "4")]
	public int CompareTo(global::NNKLGPEJENN<T1, T2, T3, T4, T5> MPHACEGLFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3989E60", Offset = "0x3988860", VA = "0x183989E60", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3989FA0", Offset = "0x39889A0", VA = "0x183989FA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x398A0A0", Offset = "0x3988AA0", VA = "0x18398A0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AAECMIKOOPJ<T1, T2, T3, T4, T5, T6> : IComparable<global::AAECMIKOOPJ<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 ONAMHOIMNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 BJJJAGPPKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 FAHENIFLPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 HKBNACIMEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 ONLMGLFJHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 OHFKCHKPNLO;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x37DB6A0", Offset = "0x37DA0A0", VA = "0x1837DB6A0")]
	public AAECMIKOOPJ(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO, T4 PJOMOCIFAJM, T5 OMFBODPJPAA, T6 CGFBJPGBKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x37DB0E0", Offset = "0x37D9AE0", VA = "0x1837DB0E0", Slot = "4")]
	public int CompareTo(global::AAECMIKOOPJ<T1, T2, T3, T4, T5, T6> MPHACEGLFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x37DB2A0", Offset = "0x37D9CA0", VA = "0x1837DB2A0", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x37DB410", Offset = "0x37D9E10", VA = "0x1837DB410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x37DB530", Offset = "0x37D9F30", VA = "0x1837DB530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JJNJEJCFCGJ<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::JJNJEJCFCGJ<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 ONAMHOIMNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 BJJJAGPPKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 FAHENIFLPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 HKBNACIMEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 ONLMGLFJHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 OHFKCHKPNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 FEJPJNFEMOH;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3333C20", Offset = "0x3332620", VA = "0x183333C20")]
	public JJNJEJCFCGJ(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO, T4 PJOMOCIFAJM, T5 OMFBODPJPAA, T6 CGFBJPGBKBE, T7 KLCJIHKLGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x33335A0", Offset = "0x3331FA0", VA = "0x1833335A0", Slot = "4")]
	public int CompareTo(global::JJNJEJCFCGJ<T1, T2, T3, T4, T5, T6, T7> MPHACEGLFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x33337A0", Offset = "0x33321A0", VA = "0x1833337A0", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3333940", Offset = "0x3332340", VA = "0x183333940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3333A90", Offset = "0x3332490", VA = "0x183333A90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class KDJMGHBAKCH<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::KDJMGHBAKCH<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 ONAMHOIMNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 BJJJAGPPKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 FAHENIFLPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 HKBNACIMEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 ONLMGLFJHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 OHFKCHKPNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 FEJPJNFEMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 IFIHHPCNCAE;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC570", Offset = "0x2BBAF70", VA = "0x182BBC570")]
	public KDJMGHBAKCH(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO, T4 PJOMOCIFAJM, T5 OMFBODPJPAA, T6 CGFBJPGBKBE, T7 KLCJIHKLGHO, T8 DPMJEHBBNNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBE40", Offset = "0x2BBA840", VA = "0x182BBBE40", Slot = "4")]
	public int CompareTo(global::KDJMGHBAKCH<T1, T2, T3, T4, T5, T6, T7, T8> MPHACEGLFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC090", Offset = "0x2BBAA90", VA = "0x182BBC090", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC250", Offset = "0x2BBAC50", VA = "0x182BBC250", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC3C0", Offset = "0x2BBADC0", VA = "0x182BBC3C0", Slot = "3")]
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
	public T NDNOLKCBONM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4500CE0", Offset = "0x44FF6E0", VA = "0x184500CE0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4501200", Offset = "0x44FFC00", VA = "0x184501200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float LGOOOHEJJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1077F50", Offset = "0x1076950", VA = "0x181077F50")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4500F30", Offset = "0x44FF930", VA = "0x184500F30")]
	public T GONPMLGOLCK(float FOHPMIEDDCH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4500DF0", Offset = "0x44FF7F0", VA = "0x184500DF0")]
	public T FHIOHFMFPGA(float FOHPMIEDDCH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T OPNBMENLDND(T GBEJHLEFDJM, T BDGBOHJLNIE, float FOHPMIEDDCH);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3C37000", Offset = "0x3C35A00", VA = "0x183C37000", Slot = "4")]
	protected override float OPNBMENLDND(float GBEJHLEFDJM, float BDGBOHJLNIE, float FOHPMIEDDCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x68E6910", Offset = "0x68E5310", VA = "0x1868E6910")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x16496A0", Offset = "0x16480A0", VA = "0x1816496A0", Slot = "4")]
	protected override Vector3 OPNBMENLDND(Vector3 GBEJHLEFDJM, Vector3 BDGBOHJLNIE, float FOHPMIEDDCH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x68EE3C0", Offset = "0x68ECDC0", VA = "0x1868EE3C0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x68E5AB0", Offset = "0x68E44B0", VA = "0x1868E5AB0", Slot = "4")]
	protected override Color OPNBMENLDND(Color GBEJHLEFDJM, Color BDGBOHJLNIE, float FOHPMIEDDCH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x68E5B00", Offset = "0x68E4500", VA = "0x1868E5B00")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GCNBNFFDNNO : global::HOJEFBPKHEA<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x68E6C50", Offset = "0x68E5650", VA = "0x1868E6C50")]
	public GCNBNFFDNNO(int IPADGNLNKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x68E6BF0", Offset = "0x68E55F0", VA = "0x1868E6BF0")]
	public GCNBNFFDNNO(BDPFMFCEMKE[] HOCBAECCFMC, bool JGFAPJJFELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x68E6B80", Offset = "0x68E5580", VA = "0x1868E6B80", Slot = "6")]
	protected override uint JHAECAAOODP(uint IECKGMJMGEA, string LPJDDLMPNCG)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FCIEMCHIFDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable AGBLMGNNIDO;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public FCIEMCHIFDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct BLAKBBMHPKG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class FODHJOBBMGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public FODHJOBBMGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2881390", Offset = "0x287FD90", VA = "0x182881390")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> IEFKJEEFEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int LNFEJOBPFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int GLDLAAGPKBA;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xC175A0", Offset = "0xC15FA0", VA = "0x180C175A0")]
	private BLAKBBMHPKG(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> BJJFEKNKIDN, int LEAKNFIMFEB, int EAIJJIKGJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x231DC30", Offset = "0x231C630", VA = "0x18231DC30")]
	public static global::BLAKBBMHPKG<T> GILBACJLDCL()
	{
		return default(global::BLAKBBMHPKG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x231C6A0", Offset = "0x231B0A0", VA = "0x18231C6A0")]
	public (int, int, Task<T>) AIAIHCALLPK(int DJHDDENMEPB, [Optional] CancellationToken OIMNLGJCBEC, double ONPCMEEMBBB = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x231E060", Offset = "0x231CA60", VA = "0x18231E060")]
	public void OGKIOPBPKJG(int DJHDDENMEPB, int EAIJJIKGJEE, in T JGINNNKFHFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class JCGDINGJCOC
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x68E7470", Offset = "0x68E5E70", VA = "0x1868E7470")]
	public static global::BLAKBBMHPKG<JAPIHNFIDBB> GILBACJLDCL()
	{
		return default(global::BLAKBBMHPKG<JAPIHNFIDBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x68E74C0", Offset = "0x68E5EC0", VA = "0x1868E74C0")]
	public static void OGKIOPBPKJG(this in global::BLAKBBMHPKG<JAPIHNFIDBB> INHKNJBCCPD, int DJHDDENMEPB, int EAIJJIKGJEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class GNFFLKLNNJJ<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> OOFPEEBOBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> KMLDPPEALEM;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1AA53F0", Offset = "0x1AA3DF0", VA = "0x181AA53F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool ADPPFIHDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> GIOIOBGHAEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1AAE2A0", Offset = "0x1AACCA0", VA = "0x181AAE2A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> NJOPDFPBKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2656E80", Offset = "0x2655880", VA = "0x182656E80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x348E660", Offset = "0x348D060", VA = "0x18348E660", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x348E6D0", Offset = "0x348D0D0", VA = "0x18348E6D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x348D7D0", Offset = "0x348C1D0", VA = "0x18348D7D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x348E310", Offset = "0x348CD10", VA = "0x18348E310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x348D650", Offset = "0x348C050", VA = "0x18348D650", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x348E4B0", Offset = "0x348CEB0", VA = "0x18348E4B0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x348D4A0", Offset = "0x348BEA0", VA = "0x18348D4A0", Slot = "9")]
	public void Add(TKey OGFDNCPKECB, TVal LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x348D460", Offset = "0x348BE60", VA = "0x18348D460", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x348D6B0", Offset = "0x348C0B0", VA = "0x18348D6B0", Slot = "8")]
	public bool ContainsKey(TKey OGFDNCPKECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x348D710", Offset = "0x348C110", VA = "0x18348D710", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x348E400", Offset = "0x348CE00", VA = "0x18348E400", Slot = "10")]
	public bool Remove(TKey OGFDNCPKECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x348E430", Offset = "0x348CE30", VA = "0x18348E430", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x348E550", Offset = "0x348CF50", VA = "0x18348E550", Slot = "11")]
	public bool TryGetValue(TKey OGFDNCPKECB, out TVal LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x348E1A0", Offset = "0x348CBA0", VA = "0x18348E1A0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x348D740", Offset = "0x348C140", VA = "0x18348D740", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] BGAKDGCGOMH, int HJEGHEJBGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x348D3F0", Offset = "0x348BDF0", VA = "0x18348D3F0")]
	public void AGMLDLCGDGN(TVal IHADMCKJLJA, TKey OGFDNCPKECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x348D2F0", Offset = "0x348BCF0", VA = "0x18348D2F0")]
	public void AGMLDLCGDGN(KeyValuePair<TVal, TKey> JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x348E2D0", Offset = "0x348CCD0", VA = "0x18348E2D0")]
	public bool LACPNLKHFIJ(TVal OGFDNCPKECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x348E130", Offset = "0x348CB30", VA = "0x18348E130")]
	public bool GMBMHDKFMPB(KeyValuePair<TVal, TKey> JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x348E0C0", Offset = "0x348CAC0", VA = "0x18348E0C0")]
	public bool FJEBMLODAAK(TVal OGFDNCPKECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x348E0C0", Offset = "0x348CAC0", VA = "0x18348E0C0")]
	public bool FJEBMLODAAK(KeyValuePair<TVal, TKey> JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x348D840", Offset = "0x348C240", VA = "0x18348D840")]
	public bool DJKANKJNGBD(TVal OGFDNCPKECB, out TKey LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x348D540", Offset = "0x348BF40", VA = "0x18348D540")]
	public IEnumerator<KeyValuePair<TVal, TKey>> CLBKJDKBHNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x348DF60", Offset = "0x348C960", VA = "0x18348DF60")]
	private void FDKKIKKMFHJ(TKey OGFDNCPKECB, TVal IHADMCKJLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x348DD30", Offset = "0x348C730", VA = "0x18348DD30")]
	private void FDJPOJAPDHI(TKey OGFDNCPKECB, TVal IHADMCKJLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x348DA00", Offset = "0x348C400", VA = "0x18348DA00")]
	private bool EKPADMIHGAE(TKey OGFDNCPKECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x348DC50", Offset = "0x348C650", VA = "0x18348DC50")]
	private bool EKPADMIHGAE(TVal IHADMCKJLJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x348E580", Offset = "0x348CF80", VA = "0x18348E580")]
	public GNFFLKLNNJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class OMJJIJBGECP<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::OMJJIJBGECP<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3296350", Offset = "0x3294D50", VA = "0x183296350", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x31E5960", Offset = "0x31E4360", VA = "0x1831E5960")]
		public Enumerator(global::OMJJIJBGECP<T> NPOGECPDPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x32934D0", Offset = "0x3291ED0", VA = "0x1832934D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3295720", Offset = "0x3294120", VA = "0x183295720", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3292C60", Offset = "0x3291660", VA = "0x183292C60")]
		private void EFKOIONIPJN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] EBPHBCJGGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int OKIEINKEHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int BIOOCOFHAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int NHBDMCDLELK;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4B704A0", Offset = "0x4B6EEA0", VA = "0x184B704A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4B70260", Offset = "0x4B6EC60", VA = "0x184B70260")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4B71590", Offset = "0x4B6FF90", VA = "0x184B71590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4B71E90", Offset = "0x4B70890", VA = "0x184B71E90")]
	public OMJJIJBGECP(int IPADGNLNKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4B70010", Offset = "0x4B6EA10", VA = "0x184B70010")]
	public void AGMLDLCGDGN(T FOHPMIEDDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4B70B00", Offset = "0x4B6F500", VA = "0x184B70B00")]
	public void JHAKILBFFKF(IEnumerable<T> FAOHJBCBHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4B70240", Offset = "0x4B6EC40", VA = "0x184B70240")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4B71C80", Offset = "0x4B70680", VA = "0x184B71C80")]
	public void OPPAJPENCPP(int EJMNNLNLAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4B70410", Offset = "0x4B6EE10", VA = "0x184B70410")]
	public void HLKGMCBNPMN(int EJMNNLNLAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4B717E0", Offset = "0x4B701E0", VA = "0x184B717E0")]
	public void NNIJEOGCGNL(T[] BGAKDGCGOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4B71C00", Offset = "0x4B70600", VA = "0x184B71C00")]
	public Enumerator OKFDNCHLPHK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4B71E10", Offset = "0x4B70810", VA = "0x184B71E10", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4B71E10", Offset = "0x4B70810", VA = "0x184B71E10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4B711D0", Offset = "0x4B6FBD0", VA = "0x184B711D0")]
	private int KNHFLOBKBJL(int EGNHJGKABLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4B703E0", Offset = "0x4B6EDE0", VA = "0x184B703E0")]
	private int FAIEBMBPJPI(int EGNHJGKABLC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class JKFHCJPBKPG<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> FHJNDBAFJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> JJKFOPGJCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> BDHPAGCMKHB;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> OBBBGIKHGGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x74C3F0", Offset = "0x74ADF0", VA = "0x18074C3F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool ADPPFIHDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x802050", Offset = "0x800A50", VA = "0x180802050", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE50", Offset = "0x7C9850", VA = "0x1807CAE50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x33345C0", Offset = "0x3332FC0", VA = "0x1833345C0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3334660", Offset = "0x3333060", VA = "0x183334660", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3334560", Offset = "0x3332F60", VA = "0x183334560", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x33344D0", Offset = "0x3332ED0", VA = "0x1833344D0")]
	public JKFHCJPBKPG(Func<Internal, External> FHJNDBAFJCD, Func<External, Internal> JJKFOPGJCGG, bool GLNNHMBNJIG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x33341F0", Offset = "0x3332BF0", VA = "0x1833341F0", Slot = "6")]
	public int IndexOf(External JPOBIIKLHON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3333E70", Offset = "0x3332870", VA = "0x183333E70", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3333ED0", Offset = "0x33328D0", VA = "0x183333ED0", Slot = "13")]
	public bool Contains(External JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3333F60", Offset = "0x3332960", VA = "0x183333F60", Slot = "14")]
	public void CopyTo(External[] BGAKDGCGOMH, int HJEGHEJBGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3333D80", Offset = "0x3332780", VA = "0x183333D80", Slot = "11")]
	public void Add(External JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x33342E0", Offset = "0x3332CE0", VA = "0x1833342E0", Slot = "7")]
	public void Insert(int EGNHJGKABLC, External JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3334440", Offset = "0x3332E40", VA = "0x183334440", Slot = "15")]
	public bool Remove(External JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3334380", Offset = "0x3332D80", VA = "0x183334380", Slot = "8")]
	public void RemoveAt(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3334180", Offset = "0x3332B80", VA = "0x183334180", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2307950", Offset = "0x2306350", VA = "0x182307950", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class LMKJIODFIMJ<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> FHJNDBAFJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> BDHPAGCMKHB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> OBBBGIKHGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x730AF0", Offset = "0x72F4F0", VA = "0x180730AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool ADPPFIHDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7319E0", Offset = "0x7303E0", VA = "0x1807319E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x229D020", Offset = "0x229BA20", VA = "0x18229D020", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x229CFC0", Offset = "0x229B9C0", VA = "0x18229CFC0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x225EE20", Offset = "0x225D820", VA = "0x18225EE20")]
	public LMKJIODFIMJ(Func<Internal, External> FHJNDBAFJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x229CF70", Offset = "0x229B970", VA = "0x18229CF70")]
	public LMKJIODFIMJ(IReadOnlyList<Internal> BDHPAGCMKHB, Func<Internal, External> FHJNDBAFJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x229CD20", Offset = "0x229B720", VA = "0x18229CD20")]
	public void NNIJEOGCGNL(External[] BGAKDGCGOMH, int HJEGHEJBGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x229CC50", Offset = "0x229B650", VA = "0x18229CC50", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x229CF40", Offset = "0x229B940", VA = "0x18229CF40", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public class GNCNGGNBDOO<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> BDHPAGCMKHB;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> OBBBGIKHGGE
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x730AE0", Offset = "0x72F4E0", VA = "0x180730AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool ADPPFIHDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7319E0", Offset = "0x7303E0", VA = "0x1807319E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x348D230", Offset = "0x348BC30", VA = "0x18348D230", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x348D1D0", Offset = "0x348BBD0", VA = "0x18348D1D0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x225EE20", Offset = "0x225D820", VA = "0x18225EE20")]
	public GNCNGGNBDOO(IReadOnlyList<Internal> BDHPAGCMKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x348CE90", Offset = "0x348B890", VA = "0x18348CE90")]
	public bool GMBMHDKFMPB(External JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x348CFA0", Offset = "0x348B9A0", VA = "0x18348CFA0")]
	public void NNIJEOGCGNL(External[] BGAKDGCGOMH, int HJEGHEJBGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x348CF30", Offset = "0x348B930", VA = "0x18348CF30", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2307950", Offset = "0x2306350", VA = "0x182307950", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class MDFMGIHHANF
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void DFKNCBFBJKJ(object[] FKFCAPAEHKO);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	protected MDFMGIHHANF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public abstract class AEEPEBKNINE<T> : MDFMGIHHANF
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	protected struct BOJNEBLAIFF
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public enum MIACFDDLEFL
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
		public MIACFDDLEFL OGILDIMGIOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T DAAMKALKLMO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int GGDNPGHCBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool EBBDMEOEGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool IOLDBGKMDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> JCIIFEMEGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<BOJNEBLAIFF> EMOKHCOBPKH;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool IDLANPBCNKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5A40", Offset = "0x2AA4440", VA = "0x182AA5A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5A80", Offset = "0x2AA4480", VA = "0x182AA5A80")]
	protected AEEPEBKNINE(bool IOLDBGKMDLA, bool EBBDMEOEGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2AA53A0", Offset = "0x2AA3DA0", VA = "0x182AA53A0")]
	protected bool AEBHEPAPDOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5980", Offset = "0x2AA4380", VA = "0x182AA5980")]
	protected void KBHHKHLCCFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5690", Offset = "0x2AA4090", VA = "0x182AA5690")]
	protected void EBFAMAMGDLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x276DF20", Offset = "0x276C920", VA = "0x18276DF20")]
	private static void JGHBICPBILJ<U>(ref List<U> BDHPAGCMKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5420", Offset = "0x2AA3E20", VA = "0x182AA5420", Slot = "5")]
	public void AGMLDLCGDGN(T DAAMKALKLMO, bool CNENNJJMJBN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5840", Offset = "0x2AA4240", VA = "0x182AA5840", Slot = "6")]
	public void FJEBMLODAAK(T DAAMKALKLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5580", Offset = "0x2AA3F80", VA = "0x182AA5580")]
	public void BONIBAPHNIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface CEBJCOPDFBE
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGMLDLCGDGN(Action DAAMKALKLMO, bool CNENNJJMJBN = false);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJEBMLODAAK(Action DAAMKALKLMO);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class FNCKCCFNKKK : global::AEEPEBKNINE<Action>, CEBJCOPDFBE
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x68E68B0", Offset = "0x68E52B0", VA = "0x1868E68B0")]
	public FNCKCCFNKKK(bool IOLDBGKMDLA = false, bool EBBDMEOEGJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x68E6640", Offset = "0x68E5040", VA = "0x1868E6640")]
	public void GODLCEDBDHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x68E6570", Offset = "0x68E4F70", VA = "0x1868E6570", Slot = "4")]
	public override void DFKNCBFBJKJ(object[] FKFCAPAEHKO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x68E65E0", Offset = "0x68E4FE0", VA = "0x1868E65E0")]
	public static FNCKCCFNKKK FGAONODGAFA(FNCKCCFNKKK KHEIFICKPKO, Action DAAMKALKLMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x68E6850", Offset = "0x68E5250", VA = "0x1868E6850")]
	public static FNCKCCFNKKK HMIJFFMKNJE(FNCKCCFNKKK KHEIFICKPKO, Action DAAMKALKLMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface MAABDNPIBGO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGMLDLCGDGN(Action<T> DAAMKALKLMO, bool CNENNJJMJBN = false);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJEBMLODAAK(Action<T> DAAMKALKLMO);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class PCAPMAFAHIC<T> : global::AEEPEBKNINE<Action<T>>, global::MAABDNPIBGO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2319220", Offset = "0x2317C20", VA = "0x182319220")]
	public PCAPMAFAHIC(bool IOLDBGKMDLA = false, bool EBBDMEOEGJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2991AE0", Offset = "0x29904E0", VA = "0x182991AE0")]
	public void GODLCEDBDHK(T FOHPMIEDDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x298F6E0", Offset = "0x298E0E0", VA = "0x18298F6E0", Slot = "4")]
	public override void DFKNCBFBJKJ(object[] FKFCAPAEHKO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2990F60", Offset = "0x298F960", VA = "0x182990F60")]
	public static global::PCAPMAFAHIC<T> FGAONODGAFA(global::PCAPMAFAHIC<T> KHEIFICKPKO, Action<T> DAAMKALKLMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2992B50", Offset = "0x2991550", VA = "0x182992B50")]
	public static global::PCAPMAFAHIC<T> HMIJFFMKNJE(global::PCAPMAFAHIC<T> KHEIFICKPKO, Action<T> DAAMKALKLMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface PKKKBCHFMMJ<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGMLDLCGDGN(Action<T, U> DAAMKALKLMO, bool CNENNJJMJBN = false);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJEBMLODAAK(Action<T, U> DAAMKALKLMO);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class NPPEIHJBHGM<T, U> : global::AEEPEBKNINE<Action<T, U>>, global::PKKKBCHFMMJ<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2319220", Offset = "0x2317C20", VA = "0x182319220")]
	public NPPEIHJBHGM(bool IOLDBGKMDLA = false, bool EBBDMEOEGJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3995930", Offset = "0x3994330", VA = "0x183995930")]
	public void GODLCEDBDHK(T FOHPMIEDDCH, U HOIFEJJDOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3994250", Offset = "0x3992C50", VA = "0x183994250", Slot = "4")]
	public override void DFKNCBFBJKJ(object[] FKFCAPAEHKO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3994AD0", Offset = "0x39934D0", VA = "0x183994AD0")]
	public static global::NPPEIHJBHGM<T, U> FGAONODGAFA(global::NPPEIHJBHGM<T, U> KHEIFICKPKO, Action<T, U> DAAMKALKLMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x39972E0", Offset = "0x3995CE0", VA = "0x1839972E0")]
	public static global::NPPEIHJBHGM<T, U> HMIJFFMKNJE(global::NPPEIHJBHGM<T, U> KHEIFICKPKO, Action<T, U> DAAMKALKLMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface GHCEKCNPAOM<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGMLDLCGDGN(Action<T, U, V> DAAMKALKLMO, bool CNENNJJMJBN = false);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJEBMLODAAK(Action<T, U, V> DAAMKALKLMO);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class AGNJNOILJEP<T, U, V> : global::AEEPEBKNINE<Action<T, U, V>>, global::GHCEKCNPAOM<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2319220", Offset = "0x2317C20", VA = "0x182319220")]
	public AGNJNOILJEP(bool IOLDBGKMDLA = false, bool EBBDMEOEGJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2AABAB0", Offset = "0x2AAA4B0", VA = "0x182AABAB0")]
	public void GODLCEDBDHK(T FOHPMIEDDCH, U HOIFEJJDOKO, V CMBMGCLLFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2AAB100", Offset = "0x2AA9B00", VA = "0x182AAB100", Slot = "4")]
	public override void DFKNCBFBJKJ(object[] FKFCAPAEHKO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2AAB570", Offset = "0x2AA9F70", VA = "0x182AAB570")]
	public static global::AGNJNOILJEP<T, U, V> FGAONODGAFA(global::AGNJNOILJEP<T, U, V> KHEIFICKPKO, Action<T, U, V> DAAMKALKLMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2AACC20", Offset = "0x2AAB620", VA = "0x182AACC20")]
	public static global::AGNJNOILJEP<T, U, V> HMIJFFMKNJE(global::AGNJNOILJEP<T, U, V> KHEIFICKPKO, Action<T, U, V> DAAMKALKLMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface IGMNFFFILGJ<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGMLDLCGDGN(Action<T, U, V, W> DAAMKALKLMO, bool CNENNJJMJBN = false);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJEBMLODAAK(Action<T, U, V, W> DAAMKALKLMO);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class HCLMHGJANDG<T, U, V, W> : global::AEEPEBKNINE<Action<T, U, V, W>>, global::IGMNFFFILGJ<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2319220", Offset = "0x2317C20", VA = "0x182319220")]
	public HCLMHGJANDG(bool IOLDBGKMDLA = false, bool EBBDMEOEGJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x357A710", Offset = "0x3579110", VA = "0x18357A710")]
	public void GODLCEDBDHK(T FOHPMIEDDCH, U HOIFEJJDOKO, V CMBMGCLLFDP, W APNGGCJAEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3579490", Offset = "0x3577E90", VA = "0x183579490", Slot = "4")]
	public override void DFKNCBFBJKJ(object[] FKFCAPAEHKO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x357A190", Offset = "0x3578B90", VA = "0x18357A190")]
	public static global::HCLMHGJANDG<T, U, V, W> FGAONODGAFA(global::HCLMHGJANDG<T, U, V, W> KHEIFICKPKO, Action<T, U, V, W> DAAMKALKLMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x357B730", Offset = "0x357A130", VA = "0x18357B730")]
	public static global::HCLMHGJANDG<T, U, V, W> HMIJFFMKNJE(global::HCLMHGJANDG<T, U, V, W> KHEIFICKPKO, Action<T, U, V, W> DAAMKALKLMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface OFPDBPIFAFD<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGMLDLCGDGN(Action<T, U, V, W, X> DAAMKALKLMO, bool CNENNJJMJBN = false);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJEBMLODAAK(Action<T, U, V, W, X> DAAMKALKLMO);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class JDDIDAJGJJN<T, U, V, W, X> : global::AEEPEBKNINE<Action<T, U, V, W, X>>, global::OFPDBPIFAFD<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2319220", Offset = "0x2317C20", VA = "0x182319220")]
	public JDDIDAJGJJN(bool IOLDBGKMDLA = false, bool EBBDMEOEGJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x43A8C80", Offset = "0x43A7680", VA = "0x1843A8C80")]
	public void GODLCEDBDHK(T FOHPMIEDDCH, U HOIFEJJDOKO, V CMBMGCLLFDP, W APNGGCJAEIO, X GKBCEINHOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x43A82A0", Offset = "0x43A6CA0", VA = "0x1843A82A0", Slot = "4")]
	public override void DFKNCBFBJKJ(object[] FKFCAPAEHKO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x43A88B0", Offset = "0x43A72B0", VA = "0x1843A88B0")]
	public static global::JDDIDAJGJJN<T, U, V, W, X> FGAONODGAFA(global::JDDIDAJGJJN<T, U, V, W, X> KHEIFICKPKO, Action<T, U, V, W, X> DAAMKALKLMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x43A8F10", Offset = "0x43A7910", VA = "0x1843A8F10")]
	public static global::JDDIDAJGJJN<T, U, V, W, X> HMIJFFMKNJE(global::JDDIDAJGJJN<T, U, V, W, X> KHEIFICKPKO, Action<T, U, V, W, X> DAAMKALKLMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface JKIACLFAHMH<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGMLDLCGDGN(Action<T, U, V, W, X, Y> DAAMKALKLMO, bool CNENNJJMJBN = false);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJEBMLODAAK(Action<T, U, V, W, X, Y> DAAMKALKLMO);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class HOMFNLMAJFD<T, U, V, W, X, Y> : global::AEEPEBKNINE<Action<T, U, V, W, X, Y>>, global::JKIACLFAHMH<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2319220", Offset = "0x2317C20", VA = "0x182319220")]
	public HOMFNLMAJFD(bool IOLDBGKMDLA = false, bool EBBDMEOEGJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2FDFB60", Offset = "0x2FDE560", VA = "0x182FDFB60")]
	public void GODLCEDBDHK(T FOHPMIEDDCH, U HOIFEJJDOKO, V CMBMGCLLFDP, W APNGGCJAEIO, X GKBCEINHOJB, Y LAMHEDHCIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2FDF430", Offset = "0x2FDDE30", VA = "0x182FDF430", Slot = "4")]
	public override void DFKNCBFBJKJ(object[] FKFCAPAEHKO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2FDFAC0", Offset = "0x2FDE4C0", VA = "0x182FDFAC0")]
	public static global::HOMFNLMAJFD<T, U, V, W, X, Y> FGAONODGAFA(global::HOMFNLMAJFD<T, U, V, W, X, Y> KHEIFICKPKO, Action<T, U, V, W, X, Y> DAAMKALKLMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2FE03E0", Offset = "0x2FDEDE0", VA = "0x182FE03E0")]
	public static global::HOMFNLMAJFD<T, U, V, W, X, Y> HMIJFFMKNJE(global::HOMFNLMAJFD<T, U, V, W, X, Y> KHEIFICKPKO, Action<T, U, V, W, X, Y> DAAMKALKLMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class NBHNMJJGFPL<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct IMGOMBMFCKP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::NBHNMJJGFPL<T> FKKJBFJKOOE;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T NDNOLKCBONM
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2871F20", Offset = "0x2870920", VA = "0x182871F20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2871EF0", Offset = "0x28708F0", VA = "0x182871EF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8D19D0", Offset = "0x8D03D0", VA = "0x1808D19D0")]
		public IMGOMBMFCKP(global::NBHNMJJGFPL<T> FKKJBFJKOOE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct NEECMGKHMNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<IMGOMBMFCKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::NBHNMJJGFPL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x27A6D20", Offset = "0x27A5720", VA = "0x1827A6D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1EECFC0", Offset = "0x1EEB9C0", VA = "0x181EECFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct LNNIJPFHANO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<IMGOMBMFCKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::NBHNMJJGFPL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x22A1660", Offset = "0x22A0060", VA = "0x1822A1660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x1EECFC0", Offset = "0x1EEB9C0", VA = "0x181EECFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim HLAPOLMFLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T DGDHDKBPDKJ;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int JKKHDPJFNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x235AC70", Offset = "0x2359670", VA = "0x18235AC70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x235AD60", Offset = "0x2359760", VA = "0x18235AD60")]
	public NBHNMJJGFPL(in T DGDHDKBPDKJ, int NLDHPOFAAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x235AC90", Offset = "0x2359690", VA = "0x18235AC90")]
	public NBHNMJJGFPL(in T DGDHDKBPDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x235ABF0", Offset = "0x23595F0", VA = "0x18235ABF0")]
	public IMGOMBMFCKP HNGJAHIMFPD()
	{
		return default(IMGOMBMFCKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x235AC30", Offset = "0x2359630", VA = "0x18235AC30")]
	public IMGOMBMFCKP HNGJAHIMFPD(CancellationToken OIMNLGJCBEC)
	{
		return default(IMGOMBMFCKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x235A650", Offset = "0x2359050", VA = "0x18235A650")]
	[AsyncStateMachine(typeof(global::NBHNMJJGFPL<>.NEECMGKHMNL))]
	public Task<IMGOMBMFCKP> GBMEKFCJICF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x235A7B0", Offset = "0x23591B0", VA = "0x18235A7B0")]
	[AsyncStateMachine(typeof(global::NBHNMJJGFPL<>.LNNIJPFHANO))]
	public Task<IMGOMBMFCKP> GBMEKFCJICF(CancellationToken OIMNLGJCBEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class NDPKPBBENLK
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x68E98A0", Offset = "0x68E82A0", VA = "0x1868E98A0")]
	public static global::NBHNMJJGFPL<JAPIHNFIDBB> GILBACJLDCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x68E9830", Offset = "0x68E8230", VA = "0x1868E9830")]
	public static global::NBHNMJJGFPL<JAPIHNFIDBB> GILBACJLDCL(int NLDHPOFAAIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x25058C0", Offset = "0x25042C0", VA = "0x1825058C0")]
	public static global::NBHNMJJGFPL<T> GILBACJLDCL<T>(in T DGDHDKBPDKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2596170", Offset = "0x2594B70", VA = "0x182596170")]
	public static global::NBHNMJJGFPL<T> GILBACJLDCL<T>(in T DGDHDKBPDKJ, int NLDHPOFAAIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class NMHOLBIFPJD<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TResult> NOCDHBJHILD(TRequest FLDKBCEOGMK, CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum ODEKILALMKF
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class KGFEGJEBHDF
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float BEKCNBOEGHM = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan EPCPCEKELNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int PNNNMKPHAFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public ODEKILALMKF LCBGDBNCNCD;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly KGFEGJEBHDF EBMJMAANCBN;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float FOIBNJLBPMI
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x38E58B0", Offset = "0x38E42B0", VA = "0x1838E58B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan LIEJGJFJONC
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x38E5A70", Offset = "0x38E4470", VA = "0x1838E5A70")]
		public KGFEGJEBHDF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private readonly struct ECEJFNHDPAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest FLDKBCEOGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken OIMNLGJCBEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> MFBBPIFPOJB;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2963D20", Offset = "0x2962720", VA = "0x182963D20")]
		public ECEJFNHDPAO(TRequest FLDKBCEOGMK, TaskCompletionSource<TResult> MFBBPIFPOJB, CancellationToken OIMNLGJCBEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class AAODCMOIINL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public AAODCMOIINL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x1AA53F0", Offset = "0x1AA3DF0", VA = "0x181AA53F0")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct PAHIDDECONG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::NMHOLBIFPJD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x298BFA0", Offset = "0x298A9A0", VA = "0x18298BFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct BBDOEOAEAJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::NMHOLBIFPJD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private ECEJFNHDPAO <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x381D7D0", Offset = "0x381C1D0", VA = "0x18381D7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource PDLJJFMOODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<ECEJFNHDPAO> ELEDCPBCNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly KGFEGJEBHDF BJAABKGEFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly NOCDHBJHILD BGCGJCDLFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task IGDAGMKDCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int ECNCJNDEMLA;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E140", Offset = "0x2E1CB40", VA = "0x182E1E140")]
	public NMHOLBIFPJD(NOCDHBJHILD BGCGJCDLFDJ, [Optional] KGFEGJEBHDF BJAABKGEFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2E1CC70", Offset = "0x2E1B670", VA = "0x182E1CC70")]
	public Task<TResult> CHJFGMJLAIG(TRequest FLDKBCEOGMK, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2E1C990", Offset = "0x2E1B390", VA = "0x182E1C990")]
	private void CBJEJOLBHGJ(ECEJFNHDPAO JINCAJCMEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2E1DBE0", Offset = "0x2E1C5E0", VA = "0x182E1DBE0")]
	[AsyncStateMachine(typeof(global::NMHOLBIFPJD<, >.PAHIDDECONG))]
	private Task KEDPOELLBJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D620", Offset = "0x2E1C020", VA = "0x182E1D620")]
	private ECEJFNHDPAO GDAHFDDJKFE()
	{
		return default(ECEJFNHDPAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2E1DDE0", Offset = "0x2E1C7E0", VA = "0x182E1DDE0")]
	[AsyncStateMachine(typeof(global::NMHOLBIFPJD<, >.BBDOEOAEAJB))]
	private Task KMBJDHBKCIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2E1DA10", Offset = "0x2E1C410", VA = "0x182E1DA10")]
	private void JEEGIHECHJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D130", Offset = "0x2E1BB30", VA = "0x182E1D130", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class OKNGGKIMDJE<TKey, TVal> : global::HFIHKANKGNG<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int OFFCGKNHCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> NCKIOEMHOPM;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int LHEFHMFBKLA
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x339F1C0", Offset = "0x339DBC0", VA = "0x18339F1C0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int FBKCMBIGOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x339EDE0", Offset = "0x339D7E0", VA = "0x18339EDE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x339EF50", Offset = "0x339D950", VA = "0x18339EF50", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x339F300", Offset = "0x339DD00", VA = "0x18339F300")]
	public OKNGGKIMDJE(int IPADGNLNKOB, [Optional] KJKECMIOFDD IGIPODFNIHC, [Optional] IEqualityComparer<TKey> KODMKCMCJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x339EC50", Offset = "0x339D650", VA = "0x18339EC50")]
	public void BCGJFDCGEBL(TKey OGFDNCPKECB, TVal LPJDDLMPNCG, bool JOMPHGOEHAN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x339ECF0", Offset = "0x339D6F0", VA = "0x18339ECF0")]
	public bool BGKDECKBCKM(TKey OGFDNCPKECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x339EE10", Offset = "0x339D810", VA = "0x18339EE10", Slot = "6")]
	public override bool DJKANKJNGBD(TKey OBALLIKLNDH, out TVal LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x339EFB0", Offset = "0x339D9B0", VA = "0x18339EFB0")]
	public bool KMEJBEPGHMF(TKey OGFDNCPKECB, TVal LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x339F1F0", Offset = "0x339DBF0", VA = "0x18339F1F0")]
	public bool PFAKIPBOJJK(TKey OGFDNCPKECB, TVal LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x339ED70", Offset = "0x339D770", VA = "0x18339ED70", Slot = "7")]
	public override void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x339EEB0", Offset = "0x339D8B0", VA = "0x18339EEB0")]
	private bool GFBFBDGIMCE(TKey OGFDNCPKECB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DefaultMember("Item")]
public class HFIHKANKGNG<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public delegate int KJKECMIOFDD(TKey OGFDNCPKECB, TVal LPJDDLMPNCG);

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class LPGOPFKJGCE
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey MKIHFPLFIBO
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xCB3A00", Offset = "0xCB2400", VA = "0x180CB3A00")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal NDNOLKCBONM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x74C3F0", Offset = "0x74ADF0", VA = "0x18074C3F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int MDFKAKBJDBG
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x732B90", Offset = "0x731590", VA = "0x180732B90")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x998CF0", Offset = "0x9976F0", VA = "0x180998CF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime FBAPCPICNJB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xD7F010", Offset = "0xD7DA10", VA = "0x180D7F010")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x416A2F0", Offset = "0x4168CF0", VA = "0x18416A2F0")]
		public LPGOPFKJGCE(TKey OGFDNCPKECB, TVal IHADMCKJLJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int MFLHNKFMKFK = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<LPGOPFKJGCE>> BAEHCPGKKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<LPGOPFKJGCE> IMEKBHDCNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly KJKECMIOFDD IGIPODFNIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan OIDDBECDJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly KODONBPOAKI LKAJCPDJAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int BIDJMFINOHI;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int CMKLLLCOEGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3D0", Offset = "0x7AADD0", VA = "0x1807AC3D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool PEMODNBNJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3581D90", Offset = "0x3580790", VA = "0x183581D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int LHEFHMFBKLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x937340", Offset = "0x935D40", VA = "0x180937340", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int EJMNNLNLAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x234B110", Offset = "0x2349B10", VA = "0x18234B110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x25B1B40", Offset = "0x25B0540", VA = "0x1825B1B40", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> GIOIOBGHAEG
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3583AE0", Offset = "0x35824E0", VA = "0x183583AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3582970", Offset = "0x3581370", VA = "0x183582970")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3583D00", Offset = "0x3582700", VA = "0x183583D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x35850D0", Offset = "0x3583AD0", VA = "0x1835850D0")]
	public HFIHKANKGNG(int IPADGNLNKOB, [Optional] KJKECMIOFDD IGIPODFNIHC, [Optional] IEqualityComparer<TKey> KODMKCMCJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x35851A0", Offset = "0x3583BA0", VA = "0x1835851A0")]
	public HFIHKANKGNG(TimeSpan OIDDBECDJJM, [Optional] IEqualityComparer<TKey> KODMKCMCJEA, [Optional] KODONBPOAKI LKAJCPDJAFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x3585540", Offset = "0x3583F40", VA = "0x183585540")]
	public HFIHKANKGNG(int IPADGNLNKOB, TimeSpan OIDDBECDJJM, [Optional] IEqualityComparer<TKey> KODMKCMCJEA, [Optional] KODONBPOAKI LKAJCPDJAFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x3585590", Offset = "0x3583F90", VA = "0x183585590")]
	public HFIHKANKGNG(int IPADGNLNKOB, KJKECMIOFDD IGIPODFNIHC, TimeSpan OIDDBECDJJM, [Optional] IEqualityComparer<TKey> KODMKCMCJEA, [Optional] KODONBPOAKI LKAJCPDJAFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x35829B0", Offset = "0x35813B0", VA = "0x1835829B0")]
	public void DFKDLGOGOMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3583510", Offset = "0x3581F10", VA = "0x183583510")]
	public void EFMALMFMJGL(TKey OGFDNCPKECB, TVal LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3583970", Offset = "0x3582370", VA = "0x183583970")]
	public bool FJEBMLODAAK(TKey OGFDNCPKECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3584480", Offset = "0x3582E80", VA = "0x183584480")]
	private TVal MKLBNKEKMJE(TKey OBALLIKLNDH)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3582E10", Offset = "0x3581810", VA = "0x183582E10", Slot = "6")]
	public virtual bool DJKANKJNGBD(TKey OBALLIKLNDH, out TVal LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3581E20", Offset = "0x3580820", VA = "0x183581E20", Slot = "7")]
	public virtual void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3582880", Offset = "0x3581280", VA = "0x183582880")]
	private bool COCKJAFJBPA(LPGOPFKJGCE PDCHFFGGJFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3584DB0", Offset = "0x35837B0", VA = "0x183584DB0")]
	private void PHNBHHCBHJF(LinkedListNode<LPGOPFKJGCE> ILEJJGCBEDI, TVal CKCLLMGGJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x3582070", Offset = "0x3580A70", VA = "0x183582070")]
	private void CJNLKFPNHDF(TKey OGFDNCPKECB, TVal LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x3584090", Offset = "0x3582A90", VA = "0x183584090")]
	private void MFNDPMGDEAI(LPGOPFKJGCE PDCHFFGGJFJ, TVal CKCLLMGGJFK, int DNLNCODPELD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DefaultMember("Item")]
public class DHJBNEOPNAH<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> BDHPAGCMKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> PFBNMCNAHJB;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1AA53F0", Offset = "0x1AA3DF0", VA = "0x181AA53F0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool ADPPFIHDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x25EFE40", Offset = "0x25EE840", VA = "0x1825EFE40", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2CFD340", Offset = "0x2CFBD40", VA = "0x182CFD340", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2610340", Offset = "0x260ED40", VA = "0x182610340", Slot = "11")]
	public void Add(T JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2CFCE60", Offset = "0x2CFB860", VA = "0x182CFCE60")]
	public bool MGFMFMIIKAH(T JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2CFD1E0", Offset = "0x2CFBBE0", VA = "0x182CFD1E0", Slot = "15")]
	public bool Remove(T JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2CFCA50", Offset = "0x2CFB450", VA = "0x182CFCA50", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x223ED20", Offset = "0x223D720", VA = "0x18223ED20", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2CFC9C0", Offset = "0x2CFB3C0", VA = "0x182CFC9C0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2C3AC00", Offset = "0x2C39600", VA = "0x182C3AC00", Slot = "13")]
	public bool Contains(T JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2CFCA20", Offset = "0x2CFB420", VA = "0x182CFCA20", Slot = "14")]
	public void CopyTo(T[] BGAKDGCGOMH, int HJEGHEJBGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2CFCAD0", Offset = "0x2CFB4D0", VA = "0x182CFCAD0", Slot = "6")]
	public int IndexOf(T JPOBIIKLHON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2CFCBD0", Offset = "0x2CFB5D0", VA = "0x182CFCBD0", Slot = "7")]
	public void Insert(int EGNHJGKABLC, T JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2CFD080", Offset = "0x2CFBA80", VA = "0x182CFD080", Slot = "8")]
	public void RemoveAt(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2CFCD60", Offset = "0x2CFB760", VA = "0x182CFCD60")]
	public void JCDEBDNJNNJ(Predicate<T> PBPBFOEECGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x2CFCE30", Offset = "0x2CFB830", VA = "0x182CFCE30")]
	public void KJCPAGPFOFN(Comparison<T> IBMCFMEKNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x2CFD260", Offset = "0x2CFBC60", VA = "0x182CFD260")]
	public DHJBNEOPNAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class GPKFEFFGMNK
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x68E6CA0", Offset = "0x68E56A0", VA = "0x1868E6CA0")]
	public static Vector3 GMIBPELKBBM(this GameObject DLNMCGFEPOP, float GNBLJNNIOBG)
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
			[Cpp2IlInjected.Address(RVA = "0x33B89C0", Offset = "0x33B73C0", VA = "0x1833B89C0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x68A9430", Offset = "0x68A7E30", VA = "0x1868A9430")]
		public SerializedGuid(in Guid NPIFLODGAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x68ED6D0", Offset = "0x68EC0D0", VA = "0x1868ED6D0")]
		public static SerializedGuid FEDNMKCFCHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x68ED760", Offset = "0x68EC160", VA = "0x1868ED760")]
		public static SerializedGuid GBJBNHKBCON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x68ED7F0", Offset = "0x68EC1F0", VA = "0x1868ED7F0")]
		public bool JEJILLMBCFE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x68A9400", Offset = "0x68A7E00", VA = "0x1868A9400", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x68ED910", Offset = "0x68EC310", VA = "0x1868ED910", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x68ED880", Offset = "0x68EC280", VA = "0x1868ED880")]
		public bool MDDDKCHCFCJ(in Guid NPIFLODGAHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x68ED540", Offset = "0x68EBF40", VA = "0x1868ED540", Slot = "7")]
		public bool Equals(SerializedGuid MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x68ED5F0", Offset = "0x68EBFF0", VA = "0x1868ED5F0", Slot = "0")]
		public override bool Equals(object NBNOMDAKOCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x68A9350", Offset = "0x68A7D50", VA = "0x1868A9350", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x68A9190", Offset = "0x68A7B90", VA = "0x1868A9190", Slot = "6")]
		public int CompareTo(SerializedGuid MPHACEGLFIL)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class KJLCINHKICN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type KKKDALCMGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string PPINFLFMILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool PAHDPKEHCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool FBLOJLFFCGJ;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x68E7F50", Offset = "0x68E6950", VA = "0x1868E7F50")]
	public KJLCINHKICN(Type KNLHMKMEPNN, string DCJDNPPAHJB, bool JGOHFHJABHJ = false, bool KDJHAIFEPCD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface KGJHPCFPHNI
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface CPJLHEIHPFO<T> : KGJHPCFPHNI
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T NDNOLKCBONM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool JJCLCDIGMPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string NKHBOIDCGJC
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
	global::CPJLHEIHPFO<T> NPPMHDEJOGJ(Action<T> ONJKGLOKENE);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::CPJLHEIHPFO<T> EGNHLIMAKJC(Action<T> ONJKGLOKENE);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::CPJLHEIHPFO<T> LPHBENJHJKC(Action<T, T> JAMAPGHBECG);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::CPJLHEIHPFO<T> LIKBOMDJIBG(Action<T, T> JAMAPGHBECG);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::CPJLHEIHPFO<T> MPJHLEJNHFA(Action<string> KDIPKAPLKHI);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::CPJLHEIHPFO<T> DAMBHEIPNPP(Action<string> KDIPKAPLKHI);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class KNNEHPMANMC<T> : global::CPJLHEIHPFO<T>, KGJHPCFPHNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::NPPEIHJBHGM<T, T> AEOCHOMDADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::PCAPMAFAHIC<T> DNDOKKPGDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::PCAPMAFAHIC<string> BEHOIFDEAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string NOGDNAGMMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T JGINNNKFHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool KBIIEKFJNKN;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T NDNOLKCBONM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2720E90", Offset = "0x271F890", VA = "0x182720E90", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool JJCLCDIGMPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7DC220", Offset = "0x7DAC20", VA = "0x1807DC220", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string NKHBOIDCGJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x72B270", Offset = "0x729C70", VA = "0x18072B270", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x18DAE30", Offset = "0x18D9830", VA = "0x1818DAE30", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x31F4050", Offset = "0x31F2A50", VA = "0x1831F4050")]
	private void BLINKILGJLB(T GJNIFGAPEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x31F4300", Offset = "0x31F2D00", VA = "0x1831F4300")]
	private void MPHHEKKBJOI(string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x31F41B0", Offset = "0x31F2BB0", VA = "0x1831F41B0")]
	public void JAIKDMLJCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x31F42B0", Offset = "0x31F2CB0", VA = "0x1831F42B0", Slot = "6")]
	public global::CPJLHEIHPFO<T> LPHBENJHJKC(Action<T, T> JAMAPGHBECG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x31F4260", Offset = "0x31F2C60", VA = "0x1831F4260", Slot = "7")]
	public global::CPJLHEIHPFO<T> LIKBOMDJIBG(Action<T, T> JAMAPGHBECG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x31F4450", Offset = "0x31F2E50", VA = "0x1831F4450", Slot = "4")]
	public global::CPJLHEIHPFO<T> NPPMHDEJOGJ(Action<T> JAMAPGHBECG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x31F4160", Offset = "0x31F2B60", VA = "0x1831F4160", Slot = "5")]
	public global::CPJLHEIHPFO<T> EGNHLIMAKJC(Action<T> ONJKGLOKENE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x31F43B0", Offset = "0x31F2DB0", VA = "0x1831F43B0", Slot = "8")]
	public global::CPJLHEIHPFO<T> MPJHLEJNHFA(Action<string> KDIPKAPLKHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x31F40F0", Offset = "0x31F2AF0", VA = "0x1831F40F0", Slot = "9")]
	public global::CPJLHEIHPFO<T> DAMBHEIPNPP(Action<string> KDIPKAPLKHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x31F44E0", Offset = "0x31F2EE0", VA = "0x1831F44E0")]
	public KNNEHPMANMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class FJDGBNHBHOK
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class KIBIAFICIOP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::CPJLHEIHPFO<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::GOEHKJJNHGC<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public KIBIAFICIOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x38E9E90", Offset = "0x38E8890", VA = "0x1838E9E90")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x2F7EE50", Offset = "0x2F7D850", VA = "0x182F7EE50")]
	public static global::ODHJGGEEIEO<T> PKFLHEEHOPC<T>(this global::CPJLHEIHPFO<T> OAHJIKPJCJA, Action<T> MIKGEIBIMCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class JIHOHILIMPL<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public readonly struct JMMAOJMBHJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long FAPMLKJJLDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long MLFOHKEPDDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int CJHHEPAJDGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int HDHAEBNPHOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool CIHOENEOJAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string IOHEEGMAJDK;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3338650", Offset = "0x3337050", VA = "0x183338650")]
		public JMMAOJMBHJK(long FAPMLKJJLDM, int CJHHEPAJDGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x33386C0", Offset = "0x33370C0", VA = "0x1833386C0")]
		public JMMAOJMBHJK(long FAPMLKJJLDM, long MLFOHKEPDDG, int CJHHEPAJDGG, int HDHAEBNPHOK, bool CIHOENEOJAJ, string IOHEEGMAJDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3338590", Offset = "0x3336F90", VA = "0x183338590")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void LNNHODGNCGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3338600", Offset = "0x3337000", VA = "0x183338600")]
		public int MMACAPOLKME()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3338570", Offset = "0x3336F70", VA = "0x183338570")]
		public int KNJGAECNIBG(int KCJMLAFEOFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3338470", Offset = "0x3336E70", VA = "0x183338470")]
		public double DNGOHBBEACL()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x33384E0", Offset = "0x3336EE0", VA = "0x1833384E0")]
		public JMMAOJMBHJK FFLPKKJKMGG(long MLFOHKEPDDG, int HDHAEBNPHOK)
		{
			return default(JMMAOJMBHJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class HKNIJBILNIP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey MKIHFPLFIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::JIHOHILIMPL<TKey> MJOCLEMBKBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<HKNIJBILNIP> AMODHNECGEF;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string KAHMJAFBPOE
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x1ABC450", Offset = "0x1ABAE50", VA = "0x181ABC450")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x1ABC3A0", Offset = "0x1ABADA0", VA = "0x181ABC3A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<HKNIJBILNIP> PHPDFDJEEEA
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x3E7C370", Offset = "0x3E7AD70", VA = "0x183E7C370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public JMMAOJMBHJK BADNJIAHOOE
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x16E4FA0", Offset = "0x16E39A0", VA = "0x1816E4FA0")]
			[CompilerGenerated]
			get
			{
				return default(JMMAOJMBHJK);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x3E7C390", Offset = "0x3E7AD90", VA = "0x183E7C390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C4A0", Offset = "0x3E7AEA0", VA = "0x183E7C4A0")]
		internal HKNIJBILNIP(global::JIHOHILIMPL<TKey> MJOCLEMBKBO, TKey OGFDNCPKECB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C0B0", Offset = "0x3E7AAB0", VA = "0x183E7C0B0")]
		public HKNIJBILNIP BDBOCMEBKIB(TKey OGFDNCPKECB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C3C0", Offset = "0x3E7ADC0", VA = "0x183E7C3C0")]
		public void MMBFNPPJLAK(TKey OGFDNCPKECB, Action<HKNIJBILNIP> DAAMKALKLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2490E70", Offset = "0x248F870", VA = "0x182490E70")]
		public T MMBFNPPJLAK<T>(TKey OGFDNCPKECB, Func<HKNIJBILNIP, T> MPPDBHKFNNP)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2490D00", Offset = "0x248F700", VA = "0x182490D00")]
		[AsyncStateMachine(typeof(NJHLLDJEBCG))]
		public Task<T> CKJEFFKIKEP<T>(TKey OGFDNCPKECB, Func<HKNIJBILNIP, Task<T>> MPPDBHKFNNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C1C0", Offset = "0x3E7ABC0", VA = "0x183E7C1C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class BEIGFDBFKFF : IEnumerable<(TKey, List<TKey>, JMMAOJMBHJK)>, IEnumerable, IEnumerator<(TKey, List<TKey>, JMMAOJMBHJK)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, JMMAOJMBHJK timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::JIHOHILIMPL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, JMMAOJMBHJK timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, JMMAOJMBHJK) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x23074D0", Offset = "0x2305ED0", VA = "0x1823074D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, JMMAOJMBHJK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x2307570", Offset = "0x2305F70", VA = "0x182307570", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2307620", Offset = "0x2306020", VA = "0x182307620")]
		[DebuggerHidden]
		public BEIGFDBFKFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2295B60", Offset = "0x2294560", VA = "0x182295B60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x2307160", Offset = "0x2305B60", VA = "0x182307160", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x23075D0", Offset = "0x2305FD0", VA = "0x1823075D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x2307530", Offset = "0x2305F30", VA = "0x182307530", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2307410", Offset = "0x2305E10", VA = "0x182307410", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, JMMAOJMBHJK)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x2307500", Offset = "0x2305F00", VA = "0x182307500", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class CJBIKMOGOON : IEnumerable<(TKey, List<TKey>, JMMAOJMBHJK)>, IEnumerable, IEnumerator<(TKey, List<TKey>, JMMAOJMBHJK)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, JMMAOJMBHJK timerEntry) <>2__current;

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
		private HKNIJBILNIP timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public HKNIJBILNIP <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::JIHOHILIMPL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<HKNIJBILNIP> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, JMMAOJMBHJK timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, JMMAOJMBHJK) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x23074D0", Offset = "0x2305ED0", VA = "0x1823074D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, JMMAOJMBHJK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x2EF9960", Offset = "0x2EF8360", VA = "0x182EF9960", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2307620", Offset = "0x2306020", VA = "0x182307620")]
		[DebuggerHidden]
		public CJBIKMOGOON(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2EF99C0", Offset = "0x2EF83C0", VA = "0x182EF99C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x2EF9270", Offset = "0x2EF7C70", VA = "0x182EF9270", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2EF9A60", Offset = "0x2EF8460", VA = "0x182EF9A60")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2EF9AC0", Offset = "0x2EF84C0", VA = "0x182EF9AC0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2EF9920", Offset = "0x2EF8320", VA = "0x182EF9920", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x2EF9810", Offset = "0x2EF8210", VA = "0x182EF9810", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, JMMAOJMBHJK)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2EF98F0", Offset = "0x2EF82F0", VA = "0x182EF98F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, JMMAOJMBHJK> COKLPKAABGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, JMMAOJMBHJK> NODLPGLEFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::JIHOHILIMPL<TKey>> HCHLKLFNEGO;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string LBONLEKBKBI = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly HKNIJBILNIP FAPAIIGMCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool AJCOIBJBODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int KGOJGEOHEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch DDCPMELELDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int KJHNJJFJBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string DFLGMPJDMFO;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public HKNIJBILNIP NGBFKGAEPJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x72B270", Offset = "0x729C70", VA = "0x18072B270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string KAHMJAFBPOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7270F0", Offset = "0x725AF0", VA = "0x1807270F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x332FAE0", Offset = "0x332E4E0", VA = "0x18332FAE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long GHBLFPODMCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x332FDE0", Offset = "0x332E7E0", VA = "0x18332FDE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int HJALGADEINK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x332FDB0", Offset = "0x332E7B0", VA = "0x18332FDB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x332FE20", Offset = "0x332E820", VA = "0x18332FE20")]
	public JIHOHILIMPL(TKey DBJMDGJGPDC, [Optional] int? CJHHEPAJDGG, [Optional][CanBeNull] Stopwatch DDCPMELELDJ, [Optional] Action<TKey, JMMAOJMBHJK> COKLPKAABGN, [Optional] Action<TKey, JMMAOJMBHJK> NODLPGLEFIB, [Optional] Action<global::JIHOHILIMPL<TKey>> HCHLKLFNEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x332FCA0", Offset = "0x332E6A0", VA = "0x18332FCA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x332FAC0", Offset = "0x332E4C0", VA = "0x18332FAC0")]
	public void CBABINIJGKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x332FE00", Offset = "0x332E800", VA = "0x18332FE00")]
	public void HIIBJMKOCAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x332FC10", Offset = "0x332E610", VA = "0x18332FC10")]
	[IteratorStateMachine(typeof(global::JIHOHILIMPL<>.BEIGFDBFKFF))]
	public IEnumerable<(TKey, List<TKey>, JMMAOJMBHJK)> DGCHFHLGKFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x332FB40", Offset = "0x332E540", VA = "0x18332FB40")]
	[IteratorStateMachine(typeof(global::JIHOHILIMPL<>.CJBIKMOGOON))]
	private IEnumerable<(TKey, List<TKey>, JMMAOJMBHJK)> DGCHFHLGKFL(List<TKey> CCJFOCJJBJG, HKNIJBILNIP PALCKANNDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x332FD30", Offset = "0x332E730", VA = "0x18332FD30")]
	private (long, int) EIGDBDNLKNK()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class BKGGJHCGCBG<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut EPKFIKOBHCN(global::JIHOHILIMPL<TKey> MJOCLEMBKBO);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
	protected BKGGJHCGCBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public abstract class BEJLEKBJGKO<TKey> : global::BKGGJHCGCBG<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate string LBNCNMKMHHM(TKey OGFDNCPKECB);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2307660", Offset = "0x2306060", VA = "0x182307660")]
	protected string ALDLPKCGCLN(double HGMGDKBLDGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x23078F0", Offset = "0x23062F0", VA = "0x1823078F0")]
	protected string LNNHPNENOOO(int PKAHDKMMFHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x23078B0", Offset = "0x23062B0", VA = "0x1823078B0")]
	private static string FAPDHNGHDIL(TKey OGFDNCPKECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x23076D0", Offset = "0x23060D0", VA = "0x1823076D0", Slot = "4")]
	public override string EPKFIKOBHCN(global::JIHOHILIMPL<TKey> MJOCLEMBKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x2307780", Offset = "0x2306180", VA = "0x182307780")]
	public string EPKFIKOBHCN(global::JIHOHILIMPL<TKey> MJOCLEMBKBO, [NotNull] LBNCNMKMHHM BDJGKOHMMJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string DKEELFMGOJI(global::JIHOHILIMPL<TKey> MJOCLEMBKBO, [NotNull] LBNCNMKMHHM BDJGKOHMMJP);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2307950", Offset = "0x2306350", VA = "0x182307950")]
	protected BEJLEKBJGKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class DDBGEBFDEKP<TKey> : global::BKGGJHCGCBG<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate string JFPKCCKGMJC(TKey OGFDNCPKECB);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int IHNOLMFGJBG = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string FFNJKJJPDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double NNNIFDJHGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool PFAOBJGKIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int OAKJIPCPCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> OCGEDHJAJHA;

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2CF15B0", Offset = "0x2CEFFB0", VA = "0x182CF15B0")]
	private static string FAPDHNGHDIL(TKey OGFDNCPKECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2CF1920", Offset = "0x2CF0320", VA = "0x182CF1920")]
	public DDBGEBFDEKP(string FFNJKJJPDHO = "F2", double NNNIFDJHGDA = double.MaxValue, bool PFAOBJGKIDL = false, int OAKJIPCPCBD = int.MaxValue, [Optional] ISet<string> OCGEDHJAJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2CF0FC0", Offset = "0x2CEF9C0", VA = "0x182CF0FC0", Slot = "4")]
	public override Dictionary<string, string> EPKFIKOBHCN(global::JIHOHILIMPL<TKey> MJOCLEMBKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2CF0EE0", Offset = "0x2CEF8E0", VA = "0x182CF0EE0")]
	private bool AOJEAAKCEJL(string JNCLPNAAHHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2CF1070", Offset = "0x2CEFA70", VA = "0x182CF1070")]
	public Dictionary<string, string> EPKFIKOBHCN(global::JIHOHILIMPL<TKey> MJOCLEMBKBO, JFPKCCKGMJC BDJGKOHMMJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x2CF15F0", Offset = "0x2CEFFF0", VA = "0x182CF15F0")]
	private string JFOJGAHBKPC(StringBuilder HCLLLIOFJIC, List<TKey> BKDLMACMGAL, JFPKCCKGMJC BDJGKOHMMJP, bool PPNMHEJNELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x2CF17A0", Offset = "0x2CF01A0", VA = "0x182CF17A0")]
	private static void OEKEDDIJBBE(StringBuilder LJOHODPAOEJ, string CPCEIPDEIGM, bool CHDALPDLOME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class HDPMOGBOGLB<TKey> : global::BEJLEKBJGKO<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct FAGOHPBJGIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public LBNCNMKMHHM keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::HDPMOGBOGLB<TKey> AGBLMGNNIDO;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int LDECEMGEGKJ = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] DCAELNFPPGD;

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x357D3B0", Offset = "0x357BDB0", VA = "0x18357D3B0")]
	private HDPMOGBOGLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x357C3C0", Offset = "0x357ADC0", VA = "0x18357C3C0", Slot = "5")]
	protected override string DKEELFMGOJI(global::JIHOHILIMPL<TKey> MJOCLEMBKBO, LBNCNMKMHHM BDJGKOHMMJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x357C2D0", Offset = "0x357ACD0", VA = "0x18357C2D0")]
	[CompilerGenerated]
	internal static string CBJBIMGPKCL(string HBBKGHPAOGL, TKey OGFDNCPKECB, ref FAGOHPBJGIK P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class PBMGFPDCDJM<TKey> : global::BEJLEKBJGKO<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class JKIPFPJIOGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public LBNCNMKMHHM keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public JKIPFPJIOGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x1ABC980", Offset = "0x1ABB380", VA = "0x181ABC980")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x298E6F0", Offset = "0x298D0F0", VA = "0x18298E6F0", Slot = "5")]
	protected override string DKEELFMGOJI(global::JIHOHILIMPL<TKey> MJOCLEMBKBO, LBNCNMKMHHM BDJGKOHMMJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x298F140", Offset = "0x298DB40", VA = "0x18298F140")]
	public PBMGFPDCDJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public sealed class GCJGKGEEBNN : global::JIHOHILIMPL<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class OOHNNFJGPGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<GCJGKGEEBNN> callback;

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public OOHNNFJGPGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x68EAF30", Offset = "0x68E9930", VA = "0x1868EAF30")]
		internal void <Wrap>b__0(global::JIHOHILIMPL<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x68E6A30", Offset = "0x68E5430", VA = "0x1868E6A30")]
	public GCJGKGEEBNN([Optional] string LAGLMNHLDAA, [Optional] int? CJHHEPAJDGG, [Optional] Stopwatch DDCPMELELDJ, [Optional] Action<string, JMMAOJMBHJK> COKLPKAABGN, [Optional] Action<string, JMMAOJMBHJK> NODLPGLEFIB, [Optional] Action<GCJGKGEEBNN> HCHLKLFNEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x68E6950", Offset = "0x68E5350", VA = "0x1868E6950")]
	private static Action<global::JIHOHILIMPL<string>> MMBFNPPJLAK(Action<GCJGKGEEBNN> MIKGEIBIMCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class KODONBPOAKI
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class FEJECCMAOJI : KODONBPOAKI
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static KODONBPOAKI AGBLMGNNIDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x68E5EF0", Offset = "0x68E48F0", VA = "0x1868E5EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime LDLMCHDJNFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x68E5F60", Offset = "0x68E4960", VA = "0x1868E5F60", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float OOHNDBILHBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x68E5F50", Offset = "0x68E4950", VA = "0x1868E5F50", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x68E6050", Offset = "0x68E4A50", VA = "0x1868E6050")]
		public FEJECCMAOJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static KODONBPOAKI FKNONFGLPLG;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static KODONBPOAKI EBMJMAANCBN
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x68E85F0", Offset = "0x68E6FF0", VA = "0x1868E85F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime LDLMCHDJNFI
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float OOHNDBILHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	protected KODONBPOAKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class AEDBNBJMPNK : global::HOLGIBPNJJN<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x68E53F0", Offset = "0x68E3DF0", VA = "0x1868E53F0")]
	public AEDBNBJMPNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class HOLGIBPNJJN<T> : global::EBCMIJBCHOC<T>, CNCDPCJODNI, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> LJIHFECCOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task NABIIJNOOBO
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1375A20", Offset = "0x1374420", VA = "0x181375A20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::ODHJGGEEIEO<T> GDHMGJIPGBA
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private JKAHJLGEFLE PCKBHIEKEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x18DA120", Offset = "0x18D8B20", VA = "0x1818DA120", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2FDEAF0", Offset = "0x2FDD4F0", VA = "0x182FDEAF0")]
	public HOLGIBPNJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class NIHJLIINIEH : global::CFJOJAKKIAA<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x68E9B30", Offset = "0x68E8530", VA = "0x1868E9B30")]
	public NIHJLIINIEH(Exception CCICIDAGDNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class CFJOJAKKIAA<T> : global::EBCMIJBCHOC<T>, CNCDPCJODNI, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> LJIHFECCOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task NABIIJNOOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1375A20", Offset = "0x1374420", VA = "0x181375A20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::ODHJGGEEIEO<T> GDHMGJIPGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private JKAHJLGEFLE PCKBHIEKEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x18DA120", Offset = "0x18D8B20", VA = "0x1818DA120", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x2EF0780", Offset = "0x2EEF180", VA = "0x182EF0780")]
	public CFJOJAKKIAA(Exception CCICIDAGDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface CNCDPCJODNI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task LJIHFECCOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	JKAHJLGEFLE GDHMGJIPGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface EBCMIJBCHOC<T> : CNCDPCJODNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> LJIHFECCOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::ODHJGGEEIEO<T> GDHMGJIPGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public abstract class MHEOJPLBDHK<TTask, T> : global::EBCMIJBCHOC<T>, CNCDPCJODNI, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class FMCEKHDCONP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public global::MHEOJPLBDHK<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public FMCEKHDCONP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool JFBJFCODIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> IBCOHPONNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource FFLFGHGEBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool AJCOIBJBODA;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> LJIHFECCOGI
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task NABIIJNOOBO
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::ODHJGGEEIEO<T> GDHMGJIPGBA
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private JKAHJLGEFLE PCKBHIEKEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x18E8130", Offset = "0x18E6B30", VA = "0x1818E8130", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool AMOPNJPCIDE
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x802050", Offset = "0x800A50", VA = "0x180802050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x3029710", Offset = "0x3028110", VA = "0x183029710")]
	static MHEOJPLBDHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x3029B60", Offset = "0x3028560", VA = "0x183029B60")]
	protected MHEOJPLBDHK(TTask IBCOHPONNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x30296A0", Offset = "0x30280A0", VA = "0x1830296A0", Slot = "1")]
	~MHEOJPLBDHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x3029670", Offset = "0x3028070", VA = "0x183029670", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x30294A0", Offset = "0x3027EA0", VA = "0x1830294A0")]
	private void BINPACHFFEJ(bool EAHOPLANFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T MINEMMPJOIG(TTask HBFIDOBGAPM);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void KOALCNLAFEB();
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface KMMCOMBMDMN
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float DJDJFCOJPAG
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BDIJCOBGOEN KBCLEKGFIKC;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class KHLCNBENFGM : KMMCOMBMDMN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public readonly struct FFOKOENCHPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public readonly float FHHOHIGFIIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float GLLHIGHMNHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		internal readonly bool FAKGJGPBFFP;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float MDFKAKBJDBG
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x68E60B0", Offset = "0x68E4AB0", VA = "0x1868E60B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x68E6240", Offset = "0x68E4C40", VA = "0x1868E6240")]
		public FFOKOENCHPG(float LOEMONDJCMM, float FHNIHLGHOIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x68E60C0", Offset = "0x68E4AC0", VA = "0x1868E60C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class PHALGFIEMPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public KHLCNBENFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public PHALGFIEMPJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly int IPADGNLNKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int DEKBMMBKAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly KMMCOMBMDMN[] JNPPFFIIFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly BDIJCOBGOEN[] NOHGMFJPJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly FFOKOENCHPG[] JNPBEPOKPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private FFOKOENCHPG LJHNGOAJDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly IIFMDBOLPBK BAPOMLOEIFI;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public FFOKOENCHPG EFMOMBHEABH
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x113B1F0", Offset = "0x1139BF0", VA = "0x18113B1F0")]
		get
		{
			return default(FFOKOENCHPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float DJDJFCOJPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x1E8BC20", Offset = "0x1E8A620", VA = "0x181E8BC20", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event BDIJCOBGOEN KBCLEKGFIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x68E7D10", Offset = "0x68E6710", VA = "0x1868E7D10", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x68E7BB0", Offset = "0x68E65B0", VA = "0x1868E7BB0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x68E7DD0", Offset = "0x68E67D0", VA = "0x1868E7DD0")]
	public KHLCNBENFGM(int IPADGNLNKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x68E7540", Offset = "0x68E5F40", VA = "0x1868E7540")]
	public IIFMDBOLPBK AMKEFKFNPHM(FFOKOENCHPG FAOHJBCBHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x68E75D0", Offset = "0x68E5FD0", VA = "0x1868E75D0")]
	public void BJEMJCMIGEI(KMMCOMBMDMN GNMHMDLPNNJ, [Optional] FFOKOENCHPG KFPLIKEEDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x68E7CC0", Offset = "0x68E66C0", VA = "0x1868E7CC0")]
	internal int JPAOIDBBCIF(KMMCOMBMDMN AKAFEPHMBOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x68E7C70", Offset = "0x68E6670", VA = "0x1868E7C70")]
	internal FFOKOENCHPG JMLECADAFEH(int EGNHJGKABLC)
	{
		return default(FFOKOENCHPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x68E7A20", Offset = "0x68E6420", VA = "0x1868E7A20", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public delegate void BDIJCOBGOEN(float PDMEDOHHOJO);
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class LBPCEGMMHGF
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	internal const float IFECMHFJHCP = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class NEHOEAKCDCC
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private class DDKNKMMEMIM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly KMMCOMBMDMN AKAFEPHMBOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly BDIJCOBGOEN MIKGEIBIMCG;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x68E5B90", Offset = "0x68E4590", VA = "0x1868E5B90")]
		public DDKNKMMEMIM(KMMCOMBMDMN AKAFEPHMBOO, BDIJCOBGOEN MIKGEIBIMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x68E5B40", Offset = "0x68E4540", VA = "0x1868E5B40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x68E99C0", Offset = "0x68E83C0", VA = "0x1868E99C0")]
	internal static bool NOPKMNHPAME(float HFOFADIOHHP, float GFCGIJPPCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x4AC8A60", Offset = "0x4AC7460", VA = "0x184AC8A60")]
	internal static float IKALADPEBMK(float HFOFADIOHHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x68E9900", Offset = "0x68E8300", VA = "0x1868E9900")]
	public static IDisposable FPMJEILKHCJ(this KMMCOMBMDMN AKAFEPHMBOO, BDIJCOBGOEN MIKGEIBIMCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class IIFMDBOLPBK : KMMCOMBMDMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float PDMEDOHHOJO;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float DJDJFCOJPAG
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xE61050", Offset = "0xE5FA50", VA = "0x180E61050", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x68E7180", Offset = "0x68E5B80", VA = "0x1868E7180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event BDIJCOBGOEN KBCLEKGFIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x68E7240", Offset = "0x68E5C40", VA = "0x1868E7240", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x68E70E0", Offset = "0x68E5AE0", VA = "0x1868E70E0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public IIFMDBOLPBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class BCKAINFMIAF
{
	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x68E5490", Offset = "0x68E3E90", VA = "0x1868E5490")]
	[NotNull]
	public static byte[] BCDOJAHCBCP(this FAIGGLEHEDM MGLHBIIFODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x68E5500", Offset = "0x68E3F00", VA = "0x1868E5500")]
	[NotNull]
	public static byte[] BCDOJAHCBCP(this FAIGGLEHEDM MGLHBIIFODH, HashAlgorithmName IIKDGHKHDHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x68E58A0", Offset = "0x68E42A0", VA = "0x1868E58A0")]
	public static bool PEGPHMCDMPP([CanBeNull] this FAIGGLEHEDM MGLHBIIFODH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x68E5700", Offset = "0x68E4100", VA = "0x1868E5700")]
	public static bool PEGPHMCDMPP([CanBeNull] this FAIGGLEHEDM MGLHBIIFODH, out string NOGDNAGMMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x68E5690", Offset = "0x68E4090", VA = "0x1868E5690")]
	private static string PADFCJJDFHB([CanBeNull] byte[] EMIAMELGKNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x68E5570", Offset = "0x68E3F70", VA = "0x1868E5570")]
	private static bool LGIGIDBIABH([NotNull] FAIGGLEHEDM MGLHBIIFODH, [CanBeNull] out byte[] FFBBLNFFIMC, [CanBeNull] out byte[] JMNAELLEPIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class FCBHLPFOGPO
{
	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x68E5E50", Offset = "0x68E4850", VA = "0x1868E5E50")]
	[NotNull]
	public static byte[] BCDOJAHCBCP(this LKBIMFKHBEM FNIEIJGCFBK, byte[] NHOLNGAAEHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x68E5C20", Offset = "0x68E4620", VA = "0x1868E5C20")]
	[NotNull]
	public static byte[] BCDOJAHCBCP(this LKBIMFKHBEM FNIEIJGCFBK, HashAlgorithmName IIKDGHKHDHB, byte[] NHOLNGAAEHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface LKBIMFKHBEM
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash IECKGMJMGEA);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface FAIGGLEHEDM : LKBIMFKHBEM
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] LHEPIPBKNJC
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
	byte[] ADPIDMIGKAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object JDFCIAMCACO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class NMNKCFJILIG
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private class FKNEAIKPHIL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x68E64F0", Offset = "0x68E4EF0", VA = "0x1868E64F0")]
		public FKNEAIKPHIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x68E6490", Offset = "0x68E4E90", VA = "0x1868E6490", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private const byte POIFJEHNKKP = 1;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte GLCBKEKPPOG = 0;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly ArrayPool<byte> EFOKBOHHFDM;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static bool ABLJEKPBDIM;

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x2B79080", Offset = "0x2B77A80", VA = "0x182B79080")]
	[Conditional("UNITY_EDITOR")]
	private static void DPJKMJODBAI<T>(params T[] PLABMCDKLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x68EA5D0", Offset = "0x68E8FD0", VA = "0x1868EA5D0")]
	public static IDisposable JNBHIJOGGBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x68EA9B0", Offset = "0x68E93B0", VA = "0x1868EA9B0")]
	public static void LGJMFINFEPJ(this IncrementalHash GJLFEMNLDOL, [CanBeNull] GameObject DLNMCGFEPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2B79860", Offset = "0x2B78260", VA = "0x182B79860")]
	public static void LGJMFINFEPJ<T>(this IncrementalHash GJLFEMNLDOL, [CanBeNull] T AFCHMEJMNBE) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2B79370", Offset = "0x2B77D70", VA = "0x182B79370")]
	public static void GNBNGFPMCAO<T>(this IncrementalHash GJLFEMNLDOL, [CanBeNull] T FNIEIJGCFBK) where T : LKBIMFKHBEM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2B79400", Offset = "0x2B77E00", VA = "0x182B79400")]
	public static void HOAOPNDJNLN<T>(this IncrementalHash GJLFEMNLDOL, [CanBeNull] IList<T> CDFFAECNDLJ) where T : LKBIMFKHBEM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x68E9F20", Offset = "0x68E8920", VA = "0x1868E9F20")]
	private static bool CHGBKKBBEAD([CanBeNull] LKBIMFKHBEM FNIEIJGCFBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x68EA570", Offset = "0x68E8F70", VA = "0x1868EA570")]
	public static void IEHLDPJIGAB(this IncrementalHash IECKGMJMGEA, [CanBeNull] string BOPPCHMNKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x68EA7E0", Offset = "0x68E91E0", VA = "0x1868EA7E0")]
	public static void LCEEIPBECEN(this IncrementalHash IECKGMJMGEA, long FJCDCEEJJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x68E9B80", Offset = "0x68E8580", VA = "0x1868E9B80")]
	public static void ABOGJJADDJI(this IncrementalHash IECKGMJMGEA, int OLAOPLEEFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x68E9D50", Offset = "0x68E8750", VA = "0x1868E9D50")]
	public static void BANBJKHJONF(this IncrementalHash IECKGMJMGEA, short GEBDKOIOLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x68EA670", Offset = "0x68E9070", VA = "0x1868EA670")]
	public static void KOLLHFIFLLE(this IncrementalHash IECKGMJMGEA, byte AFFOIGDGJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x68EA120", Offset = "0x68E8B20", VA = "0x1868EA120")]
	public static void EPBKNEDKNJC(this IncrementalHash IECKGMJMGEA, bool DOIDFCJHFKF, bool PMOHPJMBEKK = false, bool JNKPLGNNDAP = false, bool KKIBMIAPMOE = false, bool BMGGJNOMIHJ = false, bool PJMLLJPGGGG = false, bool GHLOGMEKBDB = false, bool LJGHNNKPPEL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2B78990", Offset = "0x2B77390", VA = "0x182B78990")]
	public static void ABGOCIFGJBH<T>(this IncrementalHash IECKGMJMGEA, T LOCDANMFCCO) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x68EA510", Offset = "0x68E8F10", VA = "0x1868EA510")]
	public static void GNOBJCGODJE(this IncrementalHash IECKGMJMGEA, float DLMMCNAKBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x68EAB10", Offset = "0x68E9510", VA = "0x1868EAB10")]
	public static void OFEOFFBOCCM(this IncrementalHash IECKGMJMGEA, double KIEHLANHILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x68EAAA0", Offset = "0x68E94A0", VA = "0x1868EAAA0")]
	public static void NIHPEOLMLBN(this IncrementalHash IECKGMJMGEA, ulong LKOBDFEMPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x68EA4B0", Offset = "0x68E8EB0", VA = "0x1868EA4B0")]
	public static void GKLALBPCPLL(this IncrementalHash IECKGMJMGEA, uint PLNIAFCPMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x68EAB70", Offset = "0x68E9570", VA = "0x1868EAB70")]
	public static void PGNMNMKGOKE(this IncrementalHash IECKGMJMGEA, ushort CKFMJDMBBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x68E9FB0", Offset = "0x68E89B0", VA = "0x1868E9FB0")]
	public static void CLEIDBOBJPE(this IncrementalHash IECKGMJMGEA, Vector3 JDIACDFLEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x68EA2F0", Offset = "0x68E8CF0", VA = "0x1868EA2F0")]
	public static void FKLOFFJIAPD(this IncrementalHash IECKGMJMGEA, Quaternion DFLIBNDHMJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class HMPHHPHADKB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly Type KKKDALCMGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly string PPINFLFMILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly bool PAHDPKEHCMJ;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x68E7080", Offset = "0x68E5A80", VA = "0x1868E7080")]
	public HMPHHPHADKB(Type KNLHMKMEPNN, string DCJDNPPAHJB, bool JGOHFHJABHJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class IPNHABKPCLJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x68E7360", Offset = "0x68E5D60", VA = "0x1868E7360")]
	public IPNHABKPCLJ(string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x68E72E0", Offset = "0x68E5CE0", VA = "0x1868E72E0")]
	public IPNHABKPCLJ(string BALNMHDNCIN, Exception FCOGIEGFKLD)
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
			[Cpp2IlInjected.Address(RVA = "0x727020", Offset = "0x725A20", VA = "0x180727020")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x7270E0", Offset = "0x725AE0", VA = "0x1807270E0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int FMPGMDDDGFN, int MCPCFIDHHAB]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x39777C0", Offset = "0x39761C0", VA = "0x1839777C0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x3977860", Offset = "0x3976260", VA = "0x183977860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x3977730", Offset = "0x3976130", VA = "0x183977730")]
		public Array2D(uint CNHIJOPNDKB, uint PJDCFLLCMEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x39776B0", Offset = "0x39760B0", VA = "0x1839776B0")]
		public void BONIBAPHNIO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x68E5430", Offset = "0x68E3E30", VA = "0x1868E5430")]
		public Array2DVector3(uint CNHIJOPNDKB, uint PJDCFLLCMEF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal static class GIPCHDBGCJA
{
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public const int FHMOKNMPIDI = -1;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public const int FOAGCPPACCD = 0;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[DefaultMember("Item")]
public class CLENJHDFPIE<THandle, TValue> : IDisposable where THandle : struct, AHPPOODHHGC where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly List<THandle> FENIMIGFDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly List<TValue> FMHMDECCGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly Func<TValue> NLNLNBDDADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly Action<TValue> BJDGPHOBIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private int HJMJCDGHHOC;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x27201A0", Offset = "0x271EBA0", VA = "0x1827201A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2720BA0", Offset = "0x271F5A0", VA = "0x182720BA0")]
	public CLENJHDFPIE(Action<TValue> BJDGPHOBIED, [Optional] Func<TValue> NLNLNBDDADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2720200", Offset = "0x271EC00", VA = "0x182720200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2720610", Offset = "0x271F010", VA = "0x182720610")]
	public THandle IDIKGABNBEI()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2720000", Offset = "0x271EA00", VA = "0x182720000")]
	public THandle AGMLDLCGDGN(TValue LPJDDLMPNCG)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2720440", Offset = "0x271EE40", VA = "0x182720440")]
	public bool FJEBMLODAAK(THandle IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2720870", Offset = "0x271F270", VA = "0x182720870")]
	public bool JALMAFNAIBH(THandle IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2720AD0", Offset = "0x271F4D0", VA = "0x182720AD0")]
	public bool OBCGBBDEENH(THandle IGELLPOEMHM, out TValue LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x2720A20", Offset = "0x271F420", VA = "0x182720A20")]
	public TValue MKLBNKEKMJE(THandle IGELLPOEMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2720390", Offset = "0x271ED90", VA = "0x182720390")]
	public bool FIKLEKNKGJP(THandle IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x27201D0", Offset = "0x271EBD0", VA = "0x1827201D0")]
	private THandle DMOMDPLOGFE(int EGNHJGKABLC)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x2720B70", Offset = "0x271F570", VA = "0x182720B70")]
	private TValue PKFLHEEHOPC(int EGNHJGKABLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2720070", Offset = "0x271EA70", VA = "0x182720070")]
	private void APJILCOBIBI(int EGNHJGKABLC, in THandle IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x27200B0", Offset = "0x271EAB0", VA = "0x1827200B0")]
	private void BLINKILGJLB(int EGNHJGKABLC, in TValue LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2720280", Offset = "0x271EC80", VA = "0x182720280")]
	private THandle EFJHLEDGEDE()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x27200F0", Offset = "0x271EAF0", VA = "0x1827200F0")]
	private void CJFOEHEMAHG(THandle IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2720A10", Offset = "0x271F410", VA = "0x182720A10")]
	private int LBLHAGKICIN(int NHBDMCDLELK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x271FFF0", Offset = "0x271E9F0", VA = "0x18271FFF0")]
	private bool AAEHFAEHJNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7780A0", Offset = "0x776AA0", VA = "0x1807780A0")]
	private void PMJHJPGINOF(THandle IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x27204F0", Offset = "0x271EEF0", VA = "0x1827204F0")]
	private bool HFDKKIDPDIE(out THandle IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2720940", Offset = "0x271F340", VA = "0x182720940")]
	private bool JJEBLKPGKOP(out THandle IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2720A70", Offset = "0x271F470", VA = "0x182720A70")]
	private void NKEOLJANKOB(THandle IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2720750", Offset = "0x271F150", VA = "0x182720750")]
	private void ILCDFPNEIAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface AHPPOODHHGC
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int CMHFEELAEBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int PELKNHEANOH
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
public interface CMECDGBHMLE<T> : AHPPOODHHGC, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class HHDGLGGLABK
{
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0xCCC090", Offset = "0xCCAA90", VA = "0x180CCC090")]
	public static bool EPHFNJKGAEI<T>(this T IGELLPOEMHM, T MPHACEGLFIL) where T : struct, AHPPOODHHGC
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x36C4D80", Offset = "0x36C3780", VA = "0x1836C4D80")]
	public static bool FAKGJGPBFFP<T>(this T IGELLPOEMHM) where T : struct, AHPPOODHHGC
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x68E6F70", Offset = "0x68E5970", VA = "0x1868E6F70")]
	public static string HJOOMKAIGJN(this AHPPOODHHGC IGELLPOEMHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class POPGJGFHLDH
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private enum AGOIHHCGNAN : byte
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
	private int IECKGMJMGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private bool MEKLLCFGGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private AGOIHHCGNAN OJNFGJAPBNC;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool IDMILJKGOPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x68EB340", Offset = "0x68E9D40", VA = "0x1868EB340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool ICKLCMMNJKD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x68EB180", Offset = "0x68E9B80", VA = "0x1868EB180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x68EBF40", Offset = "0x68EA940", VA = "0x1868EBF40")]
	public POPGJGFHLDH(bool MEKLLCFGGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x68EB350", Offset = "0x68E9D50", VA = "0x1868EB350")]
	public void IGAINJAPODI(object NBNOMDAKOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x68EB230", Offset = "0x68E9C30", VA = "0x1868EB230")]
	public void EHCBNIDBEHH(int LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x68EBBC0", Offset = "0x68EA5C0", VA = "0x1868EBBC0")]
	public void MNIPEODDIMN(uint MLKIMELJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x68EBB60", Offset = "0x68EA560", VA = "0x1868EBB60")]
	public void LIDKLPHDEOC(bool GIFMAENCFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x68EBB80", Offset = "0x68EA580", VA = "0x1868EBB80")]
	public void LIDNILHBFFP(long GMEAMCBCPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x68EB9D0", Offset = "0x68EA3D0", VA = "0x1868EB9D0")]
	public void JBICBKMJPKK(ulong JHDAFJCDGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x68EBAF0", Offset = "0x68EA4F0", VA = "0x1868EBAF0")]
	public void LICEINAIOJD(string ADAJMBMBPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x68EB190", Offset = "0x68E9B90", VA = "0x1868EB190")]
	public void AKEHMMDAHAF(Enum CCICIDAGDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x68EB050", Offset = "0x68E9A50", VA = "0x1868EB050")]
	public void AFBADBKMPFF(IList BDHPAGCMKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x22DB1B0", Offset = "0x22D9BB0", VA = "0x1822DB1B0")]
	public void BICOGHBMBOB<T, U>(Dictionary<T, U> EJLCKGIMPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x68EBBD0", Offset = "0x68EA5D0", VA = "0x1868EBBD0")]
	private void OPCIEFHNCLN(IDictionary EJLCKGIMPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x68EBA80", Offset = "0x68EA480", VA = "0x1868EBA80")]
	public int LCBKIOBHGMB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x68EB2D0", Offset = "0x68E9CD0", VA = "0x1868EB2D0")]
	public short EJCHMBCPGNF()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x68EB220", Offset = "0x68E9C20", VA = "0x1868EB220")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x68EBA10", Offset = "0x68EA410", VA = "0x1868EBA10")]
	private void LBJDHCEADPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public abstract class JAPJGABBKJA<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal class BEOJEGMMGFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public TNode INHKNJBCCPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public TNode GGEKFPEBLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public JJJLMLOANEM HCAPMBLBEEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public List<JJJLMLOANEM> JCOKABFBFFG;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public BEOJEGMMGFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	internal struct JJJLMLOANEM : IComparable<JJJLMLOANEM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public int EICBOGNBLMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public TClaimant MMDGKGGDGMM;

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x73BAF0", Offset = "0x73A4F0", VA = "0x18073BAF0")]
		public JJJLMLOANEM(int EICBOGNBLMD, TClaimant MMDGKGGDGMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x33334D0", Offset = "0x3331ED0", VA = "0x1833334D0")]
		public bool LMNIICCNLNL(in JJJLMLOANEM MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x33334B0", Offset = "0x3331EB0", VA = "0x1833334B0")]
		public bool AMDIGGJIENG(in JJJLMLOANEM MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x33334C0", Offset = "0x3331EC0", VA = "0x1833334C0", Slot = "4")]
		public int CompareTo(JJJLMLOANEM MPHACEGLFIL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x3333530", Offset = "0x3331F30", VA = "0x183333530", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public enum GDKANIKGDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class OAAGNHMNOBB : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public global::JAPJGABBKJA<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2318F30", Offset = "0x2317930", VA = "0x182318F30")]
		[DebuggerHidden]
		public OAAGNHMNOBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x2D18460", Offset = "0x2D16E60", VA = "0x182D18460", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x2D18620", Offset = "0x2D17020", VA = "0x182D18620", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x2D18540", Offset = "0x2D16F40", VA = "0x182D18540", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x18D8620", Offset = "0x18D7020", VA = "0x1818D8620", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly global::OODFGNEIEDH<BEOJEGMMGFC> COHMADBHONO;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly global::OODFGNEIEDH<List<JJJLMLOANEM>> CPDOFDFOMBF;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static int GGDEDGONGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	internal readonly Dictionary<TClaimant, TNode> PJKEPGJMDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	internal readonly Dictionary<TNode, BEOJEGMMGFC> ADAJEKMPEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private GDKANIKGDNJ FLAGJIBPLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private bool FCPODLMHINC;

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode NGLDHLBMECO(TNode PPCJAOBHBIP);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void JBMODGIADKB(TNode PPCJAOBHBIP, TClaimant OAEIEJDGJHG, TClaimant FEBFEFJMAHB);

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x39197B0", Offset = "0x39181B0", VA = "0x1839197B0")]
	public JAPJGABBKJA(GDKANIKGDNJ FLAGJIBPLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3918AD0", Offset = "0x39174D0", VA = "0x183918AD0")]
	public void GGOPEBBCBPF(TNode PPCJAOBHBIP, TNode BJNIPOLNMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x3918BF0", Offset = "0x39175F0", VA = "0x183918BF0")]
	public void HHGAIAHPLDB(TClaimant MMDGKGGDGMM, TNode KKCGOAAIEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x3918870", Offset = "0x3917270", VA = "0x183918870", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x3918B50", Offset = "0x3917550", VA = "0x183918B50")]
	private void GNMNAFGCBGK(TClaimant MMDGKGGDGMM, TNode KLHCLLOOKOK, TNode KKCGOAAIEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x39192B0", Offset = "0x3917CB0", VA = "0x1839192B0")]
	private int KKMPAMHCLEC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x39193A0", Offset = "0x3917DA0", VA = "0x1839193A0")]
	private void NGEONABLEAH(TClaimant MMDGKGGDGMM, TNode CKOPGNMJNCC, TNode NLBEDCCLIFO, int GIMFBOOEENP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3919310", Offset = "0x3917D10", VA = "0x183919310")]
	private void LBNBIDKNALH(JJJLMLOANEM NPKJKPKBBEM, BEOJEGMMGFC MEMFIMDDIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3919050", Offset = "0x3917A50", VA = "0x183919050")]
	private void KKEPCGMBPLJ(TClaimant MMDGKGGDGMM, TNode CKOPGNMJNCC, TNode NLBEDCCLIFO, int GIMFBOOEENP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x39184E0", Offset = "0x3916EE0", VA = "0x1839184E0")]
	private void BDKEMOGIPIA(JJJLMLOANEM NPKJKPKBBEM, TNode PPCJAOBHBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3918CF0", Offset = "0x39176F0", VA = "0x183918CF0")]
	private void INKIPIENKGE(JJJLMLOANEM NPKJKPKBBEM, BEOJEGMMGFC MEMFIMDDIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x3918060", Offset = "0x3916A60", VA = "0x183918060")]
	private void AOBOLNHMEHP(BEOJEGMMGFC MEMFIMDDIMD, bool GDHKAFNPJPB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x3918170", Offset = "0x3916B70", VA = "0x183918170")]
	private void APLEKHBAIEH(BEOJEGMMGFC MEMFIMDDIMD, TNode BJNIPOLNMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x3918F80", Offset = "0x3917980", VA = "0x183918F80")]
	[IteratorStateMachine(typeof(global::JAPJGABBKJA<, >.OAAGNHMNOBB))]
	private IEnumerable<TNode> KGGEKPIHKJI(TNode CKOPGNMJNCC, TNode NLBEDCCLIFO, bool MBCCOHPEJLH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x39187B0", Offset = "0x39171B0", VA = "0x1839187B0")]
	private BEOJEGMMGFC DMLAKNPOEIK(TNode PPCJAOBHBIP, TNode GGEKFPEBLKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3918DF0", Offset = "0x39177F0", VA = "0x183918DF0")]
	private BEOJEGMMGFC JADCCKEPHHA(TNode PPCJAOBHBIP, TNode GGEKFPEBLKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x39185F0", Offset = "0x3916FF0", VA = "0x1839185F0")]
	private void DAAIMFPEGLO(BEOJEGMMGFC MEMFIMDDIMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class HOJEFBPKHEA<T> : IEnumerable<global::HOJEFBPKHEA<T>.BDPFMFCEMKE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public struct BDPFMFCEMKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public T LPJDDLMPNCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int EGNHJGKABLC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class LNJHIFMIODE : IEnumerator<BDPFMFCEMKE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private global::HOJEFBPKHEA<T> MCHKFDMHGLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private int EGNHJGKABLC;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x1374790", Offset = "0x1373190", VA = "0x181374790", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public BDPFMFCEMKE IFFLDLNKLFF
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x22A1500", Offset = "0x229FF00", VA = "0x1822A1500", Slot = "4")]
			get
			{
				return default(BDPFMFCEMKE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB00", Offset = "0x7BE500", VA = "0x1807BFB00")]
		public LNJHIFMIODE(global::HOJEFBPKHEA<T> MCHKFDMHGLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x22A1480", Offset = "0x229FE80", VA = "0x1822A1480", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x7BFAF0", Offset = "0x7BE4F0", VA = "0x1807BFAF0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xC05440", Offset = "0xC03E40", VA = "0x180C05440", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private struct HAOBCOCMINL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public bool GEPNEKCKOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T LPJDDLMPNCG;
	}

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private const int JPMNDEMKBGP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly Dictionary<T, int> GLADMAHGIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private HAOBCOCMINL[] DDKGOFNLGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private int PEDPEJIJOPO;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int ADGCJNJNCAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x731740", Offset = "0x730140", VA = "0x180731740")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x893820", Offset = "0x892220", VA = "0x180893820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x1AA53F0", Offset = "0x1AA3DF0", VA = "0x181AA53F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2FDDAF0", Offset = "0x2FDC4F0", VA = "0x182FDDAF0")]
	public HOJEFBPKHEA(int IPADGNLNKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2FDD310", Offset = "0x2FDBD10", VA = "0x182FDD310")]
	public HOJEFBPKHEA(BDPFMFCEMKE[] HOCBAECCFMC, bool JGFAPJJFELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2FDD160", Offset = "0x2FDBB60", VA = "0x182FDD160")]
	public int MODIIHIEPKJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2FDCA30", Offset = "0x2FDB430", VA = "0x182FDCA30")]
	private int KOFEPMCLMEP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2FDC4D0", Offset = "0x2FDAED0", VA = "0x182FDC4D0", Slot = "6")]
	protected virtual uint JHAECAAOODP(uint IECKGMJMGEA, T LPJDDLMPNCG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2FDCC60", Offset = "0x2FDB660", VA = "0x182FDCC60")]
	public bool LLOEHOIILEI(T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2FDC4F0", Offset = "0x2FDAEF0", VA = "0x182FDC4F0")]
	public bool JPBNDEJFNLB(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x2FDC320", Offset = "0x2FDAD20", VA = "0x182FDC320")]
	public bool GMBMHDKFMPB(Func<T, bool> DGJHENDBKJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2FDBF90", Offset = "0x2FDA990", VA = "0x182FDBF90")]
	public int DJHLMKBGKHN(T LPJDDLMPNCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2FDD230", Offset = "0x2FDBC30", VA = "0x182FDD230")]
	public T PKFLHEEHOPC(int EGNHJGKABLC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x2FDBE70", Offset = "0x2FDA870", VA = "0x182FDBE70")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2FDCD20", Offset = "0x2FDB720", VA = "0x182FDCD20")]
	public bool MGFMFMIIKAH(T LPJDDLMPNCG, bool OLCLOOHNCFE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2FDCD60", Offset = "0x2FDB760", VA = "0x182FDCD60")]
	public bool MGFMFMIIKAH(T LPJDDLMPNCG, int EGNHJGKABLC, bool OLCLOOHNCFE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2FDC210", Offset = "0x2FDAC10", VA = "0x182FDC210")]
	public bool FJEBMLODAAK(T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2FDCCA0", Offset = "0x2FDB6A0", VA = "0x182FDCCA0")]
	public bool MDGCJLLGPHG(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2FDC120", Offset = "0x2FDAB20", VA = "0x182FDC120")]
	private void EKPADMIHGAE(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2FDC590", Offset = "0x2FDAF90", VA = "0x182FDC590")]
	public BDPFMFCEMKE[] JPMGPEBODFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2FDBEF0", Offset = "0x2FDA8F0", VA = "0x182FDBEF0")]
	private int CEFBNJJOPDA(int OKIEINKEHAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2FDD290", Offset = "0x2FDBC90", VA = "0x182FDD290", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x2FDD290", Offset = "0x2FDBC90", VA = "0x182FDD290", Slot = "4")]
	private IEnumerator<BDPFMFCEMKE> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct NIEDBBGIPJP<Handle> where Handle : AHPPOODHHGC, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private struct BGCAMPLDGIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly global::NIEDBBGIPJP<Handle> BOKJKCIHGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int EGNHJGKABLC;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int ACBICPOGOIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x230A150", Offset = "0x2308B50", VA = "0x18230A150")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle BDFHJONIMHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x230A5F0", Offset = "0x2308FF0", VA = "0x18230A5F0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x230AFD0", Offset = "0x23099D0", VA = "0x18230AFD0")]
		public BGCAMPLDGIG(global::NIEDBBGIPJP<Handle> BOKJKCIHGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x230A3F0", Offset = "0x2308DF0", VA = "0x18230A3F0")]
		public BBJHGJLHICD GILBACJLDCL(in BBJHGJLHICD PJEHHDIBMKL)
		{
			return default(BBJHGJLHICD);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x230A350", Offset = "0x2308D50", VA = "0x18230A350")]
		public FJHGIMHGDEG GILBACJLDCL(in FJHGIMHGDEG PJEHHDIBMKL)
		{
			return default(FJHGIMHGDEG);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x230AB30", Offset = "0x2309530", VA = "0x18230AB30")]
		public bool MPMANKAPNAG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x2309E10", Offset = "0x2308810", VA = "0x182309E10")]
		private int DIOLINFMKBD(string BALNMHDNCIN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x230AEE0", Offset = "0x23098E0", VA = "0x18230AEE0")]
		private Handle OOGMKADPLOB(string BALNMHDNCIN)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct BBJHGJLHICD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private BGCAMPLDGIG PJEHMLPMGAH;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int IFFLDLNKLFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x381DD20", Offset = "0x381C720", VA = "0x18381DD20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x381DF60", Offset = "0x381C960", VA = "0x18381DF60")]
		public BBJHGJLHICD(global::NIEDBBGIPJP<Handle> BOKJKCIHGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x381DEA0", Offset = "0x381C8A0", VA = "0x18381DEA0")]
		public bool MPMANKAPNAG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x381DEE0", Offset = "0x381C8E0", VA = "0x18381DEE0")]
		public BBJHGJLHICD OKFDNCHLPHK()
		{
			return default(BBJHGJLHICD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public struct FJHGIMHGDEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private BGCAMPLDGIG PJEHMLPMGAH;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle IFFLDLNKLFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x38C1B20", Offset = "0x38C0520", VA = "0x1838C1B20")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x381DF60", Offset = "0x381C960", VA = "0x18381DF60")]
		public FJHGIMHGDEG(global::NIEDBBGIPJP<Handle> BOKJKCIHGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x381DEA0", Offset = "0x381C8A0", VA = "0x18381DEA0")]
		public bool MPMANKAPNAG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x38C1C20", Offset = "0x38C0620", VA = "0x1838C1C20")]
		public FJHGIMHGDEG OKFDNCHLPHK()
		{
			return default(FJHGIMHGDEG);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private NativeList<int> PKACHFEFBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private NativeList<int> FBPPPJIBJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private int HDBCKDBFFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private int ECFMPMIOPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private bool EEIFLGPCHBN;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool JKIEOPECNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x802050", Offset = "0x800A50", VA = "0x180802050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int CMKLLLCOEGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x27C46D0", Offset = "0x27C30D0", VA = "0x1827C46D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int HMIKANFANFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x731750", Offset = "0x730150", VA = "0x180731750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int BMHJLICEFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x731750", Offset = "0x730150", VA = "0x180731750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public BBJHGJLHICD NINCONHJHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x27C4520", Offset = "0x27C2F20", VA = "0x1827C4520")]
		get
		{
			return default(BBJHGJLHICD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public FJHGIMHGDEG HCNNFIDBFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x27C38F0", Offset = "0x27C22F0", VA = "0x1827C38F0")]
		get
		{
			return default(FJHGIMHGDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x27C47E0", Offset = "0x27C31E0", VA = "0x1827C47E0")]
	public NIEDBBGIPJP(int BDGJGFLHFOF, Allocator FKHAEPDPDAI = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x27C3830", Offset = "0x27C2230", VA = "0x1827C3830")]
	public void BINPACHFFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x1D41550", Offset = "0x1D3FF50", VA = "0x181D41550")]
	public static int LBLHAGKICIN(int CMBMGCLLFDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x27C4710", Offset = "0x27C3110", VA = "0x1827C4710")]
	public static bool NCHIJBFLCOC(int CMBMGCLLFDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x27C47D0", Offset = "0x27C31D0", VA = "0x1827C47D0")]
	public static bool PDIKKJJKIMI(int CMBMGCLLFDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x27C35A0", Offset = "0x27C1FA0", VA = "0x1827C35A0")]
	public bool AAIFPCKMBEE(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x27C4350", Offset = "0x27C2D50", VA = "0x1827C4350")]
	public bool INKBBHGAAIA(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x27C45C0", Offset = "0x27C2FC0", VA = "0x1827C45C0")]
	public bool KFBJKDBJGLL(Handle IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x27C3F60", Offset = "0x27C2960", VA = "0x1827C3F60")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void IDFGEFJIKON(Handle IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x27C4280", Offset = "0x27C2C80", VA = "0x1827C4280")]
	public Handle IHPEELINPGO()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x27C3AE0", Offset = "0x27C24E0", VA = "0x1827C3AE0")]
	public void GCLCIABIBHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x27C3DE0", Offset = "0x27C27E0", VA = "0x1827C3DE0")]
	public void GHBCJIMAKBA(Handle IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x27C4470", Offset = "0x27C2E70", VA = "0x1827C4470")]
	public bool JAADMNDGODC(Handle IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x802050", Offset = "0x800A50", VA = "0x180802050")]
	private bool KDGHPOCFIGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x27C4770", Offset = "0x27C3170", VA = "0x1827C4770")]
	private bool OHOCDCAJBPC(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x27C36C0", Offset = "0x27C20C0", VA = "0x1827C36C0")]
	private void AKIGCKMEABO(out int EGNHJGKABLC, out int NHBDMCDLELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x27C3E60", Offset = "0x27C2860", VA = "0x1827C3E60")]
	private void GKBLOBKDEAK(Handle IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x27C4720", Offset = "0x27C3120", VA = "0x1827C4720")]
	private void OGKJJBOALPO(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x27C3990", Offset = "0x27C2390", VA = "0x1827C3990")]
	private bool EOLIAIDEBJC(out int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x27C3A40", Offset = "0x27C2440", VA = "0x1827C3A40")]
	private static Handle FJCFCPMJCKI(int EGNHJGKABLC, int NHBDMCDLELK)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[DefaultMember("Item")]
public struct EAJFHNJEBAG<Handle, T> where Handle : AHPPOODHHGC, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private global::NIEDBBGIPJP<Handle> LFBENPHALMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private T[] EFPDIALOKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private Action<T> MBEGLEKHBGP;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool JKIEOPECNID
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x29557C0", Offset = "0x29541C0", VA = "0x1829557C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int CMKLLLCOEGO
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956360", VA = "0x182957960")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x2956690", Offset = "0x2955090", VA = "0x182956690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x2955A30", Offset = "0x2954430", VA = "0x182955A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x2958480", Offset = "0x2956E80", VA = "0x182958480")]
	public EAJFHNJEBAG(int BDGJGFLHFOF, [Optional] Action<T> MBEGLEKHBGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x29557F0", Offset = "0x29541F0", VA = "0x1829557F0")]
	public void BINPACHFFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2957020", Offset = "0x2955A20", VA = "0x182957020")]
	public bool KFBJKDBJGLL(Handle IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void IDFGEFJIKON(Handle IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x29578E0", Offset = "0x29562E0", VA = "0x1829578E0")]
	public T MKLBNKEKMJE(Handle IGELLPOEMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x29582F0", Offset = "0x2956CF0", VA = "0x1829582F0")]
	public bool OBCGBBDEENH(Handle IGELLPOEMHM, out T NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x2955B20", Offset = "0x2954520", VA = "0x182955B20")]
	public void EFMALMFMJGL(Handle IGELLPOEMHM, T DAIAHPILHFA, out T CDNDKPKKBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x2955DE0", Offset = "0x29547E0", VA = "0x182955DE0")]
	public void EFMALMFMJGL(Handle IGELLPOEMHM, T DAIAHPILHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x2957F80", Offset = "0x2956980", VA = "0x182957F80")]
	public bool NFPBPFFPICN(Handle IGELLPOEMHM, T DAIAHPILHFA, out T CDNDKPKKBND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2957CD0", Offset = "0x29566D0", VA = "0x182957CD0")]
	public bool NFPBPFFPICN(Handle IGELLPOEMHM, T DAIAHPILHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x29554C0", Offset = "0x2953EC0", VA = "0x1829554C0")]
	public Handle AGMLDLCGDGN(T NBNOMDAKOCG)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x29568F0", Offset = "0x29552F0", VA = "0x1829568F0")]
	public void JCDEBDNJNNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2955F00", Offset = "0x2954900", VA = "0x182955F00")]
	public void FJEBMLODAAK(Handle IGELLPOEMHM, out T CDNDKPKKBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x29563E0", Offset = "0x2954DE0", VA = "0x1829563E0")]
	public void FJEBMLODAAK(Handle IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2957480", Offset = "0x2955E80", VA = "0x182957480")]
	public bool KLEOIKLJCKJ(Handle IGELLPOEMHM, out T CDNDKPKKBND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x2957560", Offset = "0x2955F60", VA = "0x182957560")]
	public bool KLEOIKLJCKJ(Handle IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x2957800", Offset = "0x2956200", VA = "0x182957800")]
	private T MDGCJLLGPHG(int EGNHJGKABLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x29565C0", Offset = "0x2954FC0", VA = "0x1829565C0")]
	private void GOMLPJNLOAO(int HELIDNDMHAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class OODFGNEIEDH<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Stack<T> BOKJKCIHGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly List<T> LOEKJFHKIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly int GAGIKJGINNA;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int LCCFEGJHMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x1ABC450", Offset = "0x1ABAE50", VA = "0x181ABC450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int GJKPGCJKOGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x2883C20", Offset = "0x2882620", VA = "0x182883C20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A0A0", Offset = "0x3D08AA0", VA = "0x183D0A0A0")]
	public static global::OODFGNEIEDH<T> CDIIKPFBGNN(int IPADGNLNKOB = 0, int GAGIKJGINNA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A580", Offset = "0x3D08F80", VA = "0x183D0A580")]
	public static global::OODFGNEIEDH<T> KFHHEJEBPGC(int IPADGNLNKOB = 0, int GAGIKJGINNA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x3D0AA20", Offset = "0x3D09420", VA = "0x183D0AA20")]
	public OODFGNEIEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A890", Offset = "0x3D09290", VA = "0x183D0A890")]
	public OODFGNEIEDH(int IPADGNLNKOB, int GAGIKJGINNA = int.MaxValue, bool AOAADCDIBPL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A650", Offset = "0x3D09050", VA = "0x183D0A650")]
	public T LFLLANPBDJN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A170", Offset = "0x3D08B70", VA = "0x183D0A170")]
	public void CKAJENPILHN(T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A4B0", Offset = "0x3D08EB0", VA = "0x183D0A4B0")]
	private void JMCEPDIHJKF(T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A760", Offset = "0x3D09160", VA = "0x183D0A760")]
	private void LGFCLICDNHD(T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A810", Offset = "0x3D09210", VA = "0x183D0A810")]
	[Conditional("DEBUG_BUILD")]
	private void PJAKBCOPHPF(T BMLPBIDECCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A780", Offset = "0x3D09180", VA = "0x183D0A780")]
	[Conditional("DEBUG_BUILD")]
	private void OAGDAEOOEJP(T BMLPBIDECCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A3C0", Offset = "0x3D08DC0", VA = "0x183D0A3C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A220", Offset = "0x3D08C20", VA = "0x183D0A220")]
	private void DEBHNHAGBOA(IEnumerable<T> FMHMDECCGKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class ENGECGGMOFE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private Dictionary<int, T> GDCEFHMGFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private T AAFFHJEIOFO;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T KECOEMHKDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x730AF0", Offset = "0x72F4F0", VA = "0x180730AF0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool HDDGJFGBFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x2243070", Offset = "0x2241A70", VA = "0x182243070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2242FE0", Offset = "0x22419E0", VA = "0x182242FE0")]
	public bool CJNLKFPNHDF(T LPJDDLMPNCG, int EICBOGNBLMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2243640", Offset = "0x2242040", VA = "0x182243640")]
	public bool PBFPIEEMKFJ(int EICBOGNBLMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2243250", Offset = "0x2241C50", VA = "0x182243250")]
	public T LHBCDDFCHFA(int LOLNKMMBLLF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2242F20", Offset = "0x2241920", VA = "0x182242F20")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x22431C0", Offset = "0x2241BC0", VA = "0x1822431C0")]
	private bool KBFDGGDEHPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x2243040", Offset = "0x2241A40", VA = "0x182243040")]
	public bool DJKANKJNGBD(int EICBOGNBLMD, out T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x22436A0", Offset = "0x22420A0", VA = "0x1822436A0")]
	public ENGECGGMOFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class GDIPENFMNMN<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	protected struct NGHGKLCLODN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public T NDNOLKCBONM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public int LEEDLNNOGGM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	protected readonly List<NGHGKLCLODN> EBPHBCJGGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private T HKEGKLCJMLD;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x1AA53F0", Offset = "0x1AA3DF0", VA = "0x181AA53F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x32EE0E0", Offset = "0x32ECAE0", VA = "0x1832EE0E0")]
	public bool GMBMHDKFMPB(T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x32EDC90", Offset = "0x32EC690", VA = "0x1832EDC90")]
	public void AGMLDLCGDGN(T LPJDDLMPNCG, int EICBOGNBLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x32EDF50", Offset = "0x32EC950", VA = "0x1832EDF50")]
	public bool FJEBMLODAAK(T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x32EDD30", Offset = "0x32EC730", VA = "0x1832EDD30")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x32EE2F0", Offset = "0x32ECCF0", VA = "0x1832EE2F0")]
	public T PBEJFEKOPPK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x32EE070", Offset = "0x32ECA70", VA = "0x1832EE070")]
	public T GDAHFDDJKFE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x32EDD90", Offset = "0x32EC790", VA = "0x1832EDD90")]
	private void ECGNDEMLKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x32EE360", Offset = "0x32ECD60", VA = "0x1832EE360")]
	public GDIPENFMNMN()
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
		[EPAJBOKMDOH(DIMAPHHKBON.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x68EC0A0", Offset = "0x68EAAA0", VA = "0x1868EC0A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x68EC430", Offset = "0x68EAE30", VA = "0x1868EC430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x68EC2B0", Offset = "0x68EACB0", VA = "0x1868EC2B0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x68EC590", Offset = "0x68EAF90", VA = "0x1868EC590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x68EBFC0", Offset = "0x68EA9C0", VA = "0x1868EBFC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x68EC350", Offset = "0x68EAD50", VA = "0x1868EC350")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x68EC1D0", Offset = "0x68EABD0", VA = "0x1868EC1D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x68EBF70", Offset = "0x68EA970", VA = "0x1868EBF70")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public interface PDKDBOAFBMH
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public abstract class ResourcePrefabReference<T> : PDKDBOAFBMH where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x29A00D0", Offset = "0x299EAD0", VA = "0x1829A00D0", Slot = "4")]
		public virtual T NOCJKNIDPIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class LHLIEMELEHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private readonly Dictionary<byte, LBIHILHOPGL> LHLJLNFPJLD;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public LBIHILHOPGL MGNMJGAEMKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x730AE0", Offset = "0x72F4E0", VA = "0x180730AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 JMGPMPHJOGH
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x1448230", Offset = "0x1446C30", VA = "0x181448230")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x75A810", Offset = "0x759210", VA = "0x18075A810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 DKKFMDKFKID
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x27BBC00", Offset = "0x27BA600", VA = "0x1827BBC00")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA12F90", Offset = "0xA11990", VA = "0x180A12F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 HEIJGPAFEPD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x68E92E0", Offset = "0x68E7CE0", VA = "0x1868E92E0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x18F8A40", Offset = "0x18F7440", VA = "0x1818F8A40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int POGCHBNGDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x76E2C0", Offset = "0x76CCC0", VA = "0x18076E2C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7780A0", Offset = "0x776AA0", VA = "0x1807780A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x68E9300", Offset = "0x68E7D00", VA = "0x1868E9300")]
	public LHLIEMELEHI(Bounds DLPPBBKJMPH, Vector2[] CFOOBGPFDEP, int OBKOADPICBG, byte OKIEINKEHAF, float BCJIJMMDNFE = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x68E8C00", Offset = "0x68E7600", VA = "0x1868E8C00")]
	public LBIHILHOPGL FBBBNGDFPIM(byte EGNHJGKABLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x68E8C80", Offset = "0x68E7680", VA = "0x1868E8C80")]
	public void IOGDPIDBNFA(Vector3 PICDPPHNNLH, float AKCCEHCICDG, float FKCINMBFAOG, ref List<byte> DCJMPJONGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x68E8C60", Offset = "0x68E7660", VA = "0x1868E8C60")]
	public void GACDPKONDLB(LBIHILHOPGL.IGAGAPJNCAI FBIMJMKHBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x68E8D80", Offset = "0x68E7780", VA = "0x1868E8D80")]
	private LBIHILHOPGL LDKGKBMNJFB(byte EGNHJGKABLC, LBIHILHOPGL.IHOHJOIMAMA DFECGGPGPML, LBIHILHOPGL GGEKFPEBLKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x68E8EE0", Offset = "0x68E78E0", VA = "0x1868E8EE0")]
	private void MCAKEAPBFHL(LBIHILHOPGL GGEKFPEBLKN, Vector2[] CFOOBGPFDEP, int EDDCINKFBNB, int BBHANNFFBLH, int MONGMPNHILE, int FLGIPDEIHLC, float BCJIJMMDNFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class LBIHILHOPGL
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public enum IHOHJOIMAMA
	{
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public enum IGAGAPJNCAI
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
	public byte IKLMOKJELML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public Vector3 EJKEKPKBIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public Vector3 MDFKAKBJDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector3 IKNDNHOALNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Vector3 BPKHIFDFMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public IHOHJOIMAMA LBMOIGKAHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public LBIHILHOPGL GKEMABFNEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public List<LBIHILHOPGL> IOKLKPKOPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public bool NKLAFMJBLJK;

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x68E8BE0", Offset = "0x68E75E0", VA = "0x1868E8BE0")]
	public LBIHILHOPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x68E8B80", Offset = "0x68E7580", VA = "0x1868E8B80")]
	public LBIHILHOPGL(byte PKNOIGMENLD, IHOHJOIMAMA DFECGGPGPML, LBIHILHOPGL GGEKFPEBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x68E8A80", Offset = "0x68E7480", VA = "0x1868E8A80")]
	public void LBIPGKKJCGE(LBIHILHOPGL ILLPMKANGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	public void GACDPKONDLB(int EAAOOHDIPBF, IGAGAPJNCAI FBIMJMKHBJL, int JOAKCNLGLDG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x68E87D0", Offset = "0x68E71D0", VA = "0x1868E87D0")]
	public void IOGDPIDBNFA(List<byte> DCJMPJONGLP, Vector3 PICDPPHNNLH, float AKCCEHCICDG, float FKCINMBFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x68E8780", Offset = "0x68E7180", VA = "0x1868E8780")]
	public bool FHNHBLLAIBE(Vector3 JDJHGHDNLLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x68E8B40", Offset = "0x68E7540", VA = "0x1868E8B40")]
	public bool NKBNJGCCGDG(Vector3 JDJHGHDNLLP, float AJKNDAGEMJN)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		public struct DAAONKLOOAD<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			private readonly List<Component> BDHPAGCMKHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			private readonly bool IOBFEBPFGHD;

			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x8C8AC0", Offset = "0x8C74C0", VA = "0x1808C8AC0")]
			public DAAONKLOOAD(List<Component> BDHPAGCMKHB, bool IOBFEBPFGHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x33727F0", Offset = "0x33711F0", VA = "0x1833727F0")]
			public GAFBJNJAGIJ<T> OKFDNCHLPHK()
			{
				return default(GAFBJNJAGIJ<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x3372860", Offset = "0x3371260", VA = "0x183372860", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x3372860", Offset = "0x3371260", VA = "0x183372860", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		public struct GAFBJNJAGIJ<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			private readonly List<Component> BDHPAGCMKHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private readonly bool IOBFEBPFGHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private int EGNHJGKABLC;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T IFFLDLNKLFF
			{
				[Cpp2IlInjected.Token(Token = "0x60003D9")]
				[Cpp2IlInjected.Address(RVA = "0x32E2E90", Offset = "0x32E1890", VA = "0x1832E2E90", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003DA")]
				[Cpp2IlInjected.Address(RVA = "0x32E2E20", Offset = "0x32E1820", VA = "0x1832E2E20", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x32E2E60", Offset = "0x32E1860", VA = "0x1832E2E60")]
			public GAFBJNJAGIJ(List<Component> BDHPAGCMKHB, bool IOBFEBPFGHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x32E2D60", Offset = "0x32E1760", VA = "0x1832E2D60", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x32E2D70", Offset = "0x32E1770", VA = "0x1832E2D70", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x1AA8D20", Offset = "0x1AA7720", VA = "0x181AA8D20", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x68EE260", Offset = "0x68ECC60", VA = "0x1868EE260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x68EE220", Offset = "0x68ECC20", VA = "0x1868EE220")]
		public ToolHierarchyCache(GameObject JNONJGMFMNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x68EDFA0", Offset = "0x68EC9A0", VA = "0x1868EDFA0")]
		private void KADCCJJCHBP(GameObject JNONJGMFMNE, bool HKPPDHFDHMN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x68EE100", Offset = "0x68ECB00", VA = "0x1868EE100")]
		public static void KADCCJJCHBP(GameObject JNONJGMFMNE, ref ToolHierarchyCache PGFLNEHBIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x68EE190", Offset = "0x68ECB90", VA = "0x1868EE190")]
		public void KFAMBFAIBIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x68ED9B0", Offset = "0x68EC3B0", VA = "0x1868ED9B0")]
		public void AOOOKAEDLJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x25074C0", Offset = "0x2505EC0", VA = "0x1825074C0")]
		public void IOMAAOJKNNO<T>(Action<T> DAAMKALKLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x68EDE50", Offset = "0x68EC850", VA = "0x1868EDE50")]
		public Component GPJOBHGAGDA(Type OGILDIMGIOH, bool IOBFEBPFGHD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x2507440", Offset = "0x2505E40", VA = "0x182507440")]
		public T GPJOBHGAGDA<T>(bool IOBFEBPFGHD = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x68EDA00", Offset = "0x68EC400", VA = "0x1868EDA00")]
		public DAAONKLOOAD<Component> BCDCHCCCEEE(Type OGILDIMGIOH, bool IOBFEBPFGHD = false)
		{
			return default(DAAONKLOOAD<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x2507370", Offset = "0x2505D70", VA = "0x182507370")]
		public DAAONKLOOAD<T> BCDCHCCCEEE<T>(bool IOBFEBPFGHD = false) where T : class
		{
			return default(DAAONKLOOAD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x68EDA80", Offset = "0x68EC480", VA = "0x1868EDA80")]
		public List<Component> BGHPNJHPAKO(Type OGILDIMGIOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x68EDDD0", Offset = "0x68EC7D0", VA = "0x1868EDDD0", Slot = "4")]
		public bool Equals(ToolHierarchyCache GKBCEINHOJB, ToolHierarchyCache LAMHEDHCIJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x68EDF20", Offset = "0x68EC920", VA = "0x1868EDF20", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache NBNOMDAKOCG)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public class JPIOPBBDNGF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private int IPADGNLNKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private int PAOMNFIMCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private List<T> BNJGAHEFJPB;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x1ABC450", Offset = "0x1ABAE50", VA = "0x181ABC450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T BPAJEMADNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x3344290", Offset = "0x3342C90", VA = "0x183344290")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T JMDNCGBCLEA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x3344450", Offset = "0x3342E50", VA = "0x183344450")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T NKCBDKJFNEO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x33444B0", Offset = "0x3342EB0", VA = "0x1833444B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x33445B0", Offset = "0x3342FB0", VA = "0x1833445B0")]
	public JPIOPBBDNGF(int IPADGNLNKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x3344060", Offset = "0x3342A60", VA = "0x183344060")]
	public void AGMLDLCGDGN(T IHKDONGFEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x3344320", Offset = "0x3342D20", VA = "0x183344320")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x3344370", Offset = "0x3342D70", VA = "0x183344370")]
	public void FABABNJCNNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x3344560", Offset = "0x3342F60", VA = "0x183344560")]
	public void OFLNFFKCDIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x3344360", Offset = "0x3342D60", VA = "0x183344360")]
	public void CMJFFMGMJNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class JCEIOCIGDAC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private bool BNNPMDCDNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private Action DAAMKALKLMO;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static JCEIOCIGDAC BKJPPNEGDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x68E73D0", Offset = "0x68E5DD0", VA = "0x1868E73D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool FOBJJPHHEOO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x754640", Offset = "0x753040", VA = "0x180754640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0xC053A0", Offset = "0xC03DA0", VA = "0x180C053A0")]
	public JCEIOCIGDAC(Action DAAMKALKLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x68E7450", Offset = "0x68E5E50", VA = "0x1868E7450")]
	public void JHOFICMAMCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x68E7450", Offset = "0x68E5E50", VA = "0x1868E7450", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class NBIPOKCIHAA
{
	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x68E9760", Offset = "0x68E8160", VA = "0x1868E9760")]
	public static void AEDJCPNNHPB(BHECNCBBLMC PIALGNLFEHH, string NKBPDLOGGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	public static void AEDJCPNNHPB(IEnumerable<object> EFOCNJAEIPA, string NKBPDLOGGPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class KDKEPPIAPOA<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private struct PIHIPBNECMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public int LEEDLNNOGGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public T NDNOLKCBONM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly Dictionary<object, PIHIPBNECMF> GDCEFHMGFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly EqualityComparer<T> JNIIMGFPAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private T AAFFHJEIOFO;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T KECOEMHKDHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xBFC260", Offset = "0xBFAC60", VA = "0x180BFC260", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x2752CE0", Offset = "0x27516E0", VA = "0x182752CE0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool HDDGJFGBFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x2BBD4F0", Offset = "0x2BBBEF0", VA = "0x182BBD4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object MDKCBBAIAEA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7A9630", Offset = "0x7A8030", VA = "0x1807A9630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2BBCC00", Offset = "0x2BBB600", VA = "0x182BBCC00")]
	public bool CJNLKFPNHDF(T LPJDDLMPNCG, object MIFCLBEAOPM, int EICBOGNBLMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2BC1610", Offset = "0x2BC0010", VA = "0x182BC1610")]
	public bool PBFPIEEMKFJ(object MIFCLBEAOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2BBD120", Offset = "0x2BBBB20", VA = "0x182BBD120")]
	public bool DJKANKJNGBD(object MIFCLBEAOPM, out T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x287FF00", Offset = "0x287E900", VA = "0x18287FF00")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0FC0", Offset = "0x2BBF9C0", VA = "0x182BC0FC0")]
	private bool KBFDGGDEHPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2BC1680", Offset = "0x2BC0080", VA = "0x182BC1680")]
	public KDKEPPIAPOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class FGFCKLFBJIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly string IHKDKNCFIDD;

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x74A940", Offset = "0x749340", VA = "0x18074A940")]
	public FGFCKLFBJIP(string IAHKIHLNCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x68E63D0", Offset = "0x68E4DD0", VA = "0x1868E63D0")]
	public FGFCKLFBJIP(UnityEngine.Object FBAGKFPKONN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x68E6380", Offset = "0x68E4D80", VA = "0x1868E6380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x68E8310", Offset = "0x68E6D10", VA = "0x1868E8310")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x68E7FC0", Offset = "0x68E69C0", VA = "0x1868E7FC0")]
	public static string GLIIACIKPKK(byte[] EMIAMELGKNF, bool LLPOIDPCGKE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
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
