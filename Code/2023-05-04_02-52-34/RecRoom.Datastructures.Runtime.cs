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
	[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
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
		[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x734AF0", Offset = "0x733EF0", VA = "0x180734AF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7A04D0", Offset = "0x79F8D0", VA = "0x1807A04D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7532F0", Offset = "0x7526F0", VA = "0x1807532F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash IECKGMJMGEA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xC5D680", Offset = "0xC5CA80", VA = "0x180C5D680")]
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
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x694DEF0", Offset = "0x694D2F0", VA = "0x18694DEF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x694DEB0", Offset = "0x694D2B0", VA = "0x18694DEB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x694DF30", Offset = "0x694D330", VA = "0x18694DF30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x694E100", Offset = "0x694D500", VA = "0x18694E100")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x694E070", Offset = "0x694D470", VA = "0x18694E070")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xCDDBB0", Offset = "0xCDCFB0", VA = "0x180CDDBB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xDD7780", Offset = "0xDD6B80", VA = "0x180DD7780")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x694DE70", Offset = "0x694D270", VA = "0x18694DE70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x694DFE0", Offset = "0x694D3E0", VA = "0x18694DFE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x694D8B0", Offset = "0x694CCB0", VA = "0x18694D8B0")]
	public void CopyBounds(SavedExtents MPHACEGLFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x694DDD0", Offset = "0x694D1D0", VA = "0x18694DDD0")]
	public void SetLocalSpaceBounds(Bounds FLPLLNOELMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x160E6D0", Offset = "0x160DAD0", VA = "0x18160E6D0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x694DDC0", Offset = "0x694D1C0", VA = "0x18694DDC0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x694D9A0", Offset = "0x694CDA0", VA = "0x18694D9A0")]
	private void IEBCGMFAIDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x694DB90", Offset = "0x694CF90", VA = "0x18694DB90")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x694D270", Offset = "0x694C670", VA = "0x18694D270")]
	public static void CalculateLocalBoundsFor(GameObject DLNMCGFEPOP, out Bounds FLPLLNOELMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x694D8E0", Offset = "0x694CCE0", VA = "0x18694D8E0")]
	private static void GJLHMFIKAIK(Bounds GFCGIJPPCBN, Color ENPEAFFEEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x694DDF0", Offset = "0x694D1F0", VA = "0x18694DDF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72B020", Offset = "0x72A420", VA = "0x18072B020")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7358F0", Offset = "0x734CF0", VA = "0x1807358F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xE60BE0", Offset = "0xE5FFE0", VA = "0x180E60BE0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9FA670", Offset = "0x9F9A70", VA = "0x1809FA670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "4")]
	public virtual void KAOPMFLIGPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3793580", Offset = "0x3792980", VA = "0x183793580", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3792CB0", Offset = "0x37920B0", VA = "0x183792CB0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3793AC0", Offset = "0x3792EC0", VA = "0x183793AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public JKFHJNAPHDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3D601B0", Offset = "0x3D5F5B0", VA = "0x183D601B0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[DOALBNIBMPE]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xF936C0", Offset = "0xF92AC0", VA = "0x180F936C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xF936F0", Offset = "0xF92AF0", VA = "0x180F936F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xF93610", Offset = "0xF92A10", VA = "0x180F93610", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey OGFDNCPKECB]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xF93670", Offset = "0xF92A70", VA = "0x180F93670", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xF93510", Offset = "0xF92910", VA = "0x180F93510", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xF93060", Offset = "0xF92460", VA = "0x180F93060", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xF92880", Offset = "0xF91C80", VA = "0x180F92880", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xF92500", Offset = "0xF91900", VA = "0x180F92500", Slot = "14")]
	protected virtual string JNBIFEMJNDI(TKeyVal KIOPLOOGKCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xF92410", Offset = "0xF91810", VA = "0x180F92410", Slot = "4")]
	public bool ContainsKey(TKey OGFDNCPKECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xF93400", Offset = "0xF92800", VA = "0x180F93400", Slot = "5")]
	public bool TryGetValue(TKey OGFDNCPKECB, out TVal LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xF92440", Offset = "0xF91840", VA = "0x180F92440", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xF92440", Offset = "0xF91840", VA = "0x180F92440", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xF93430", Offset = "0xF92830", VA = "0x180F93430")]
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
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public MONIEOCKDJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E010", Offset = "0x2B2D410", VA = "0x182B2E010")]
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
		[Cpp2IlInjected.Address(RVA = "0x35A0D20", Offset = "0x35A0120", VA = "0x1835A0D20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x35A14A0", Offset = "0x35A08A0", VA = "0x1835A14A0")]
	public HMNMDKHJCOA(float EGIFDOFGJJL, float INLLLKDCDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x35A0BC0", Offset = "0x359FFC0", VA = "0x1835A0BC0")]
	public bool IDJENFJOIIJ(float LAOEDLDFAJL, T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x35A0A00", Offset = "0x359FE00", VA = "0x1835A0A00")]
	public int FEDOLLPBIJL(float LAOEDLDFAJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x35A0E20", Offset = "0x35A0220", VA = "0x1835A0E20")]
	public IEnumerable<T> OMNMNGOJFJD(float LAOEDLDFAJL, [Optional] float? KBJIGJPDOGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x35A0910", Offset = "0x359FD10", VA = "0x1835A0910")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x35A0940", Offset = "0x359FD40", VA = "0x1835A0940")]
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
		[Cpp2IlInjected.Address(RVA = "0xBFBA60", Offset = "0xBFAE60", VA = "0x180BFBA60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xBFBA70", Offset = "0xBFAE70", VA = "0x180BFBA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x242CE50", Offset = "0x242C250", VA = "0x18242CE50")]
	public FFANKEEFKID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x242CE80", Offset = "0x242C280", VA = "0x18242CE80")]
	public FFANKEEFKID(int GBNBGNMHGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x242BA80", Offset = "0x242AE80", VA = "0x18242BA80")]
	public void AGMLDLCGDGN(float LAOEDLDFAJL, T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x242BC20", Offset = "0x242B020", VA = "0x18242BC20")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x242C3E0", Offset = "0x242B7E0", VA = "0x18242C3E0")]
	public bool FGEOKDFCOPE(float DELPKOCBGIP, float CEPELLGJCAI, out T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x242CC50", Offset = "0x242C050", VA = "0x18242CC50")]
	public bool KDKAMCIHOJM(float DELPKOCBGIP, float CEPELLGJCAI, out T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x242C6E0", Offset = "0x242BAE0", VA = "0x18242C6E0")]
	public void KACPOLHKOCD(float DELPKOCBGIP, float CEPELLGJCAI, List<T> NPOGECPDPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x242C5A0", Offset = "0x242B9A0", VA = "0x18242C5A0")]
	private int IMBKPKMPHEI(int DPKHDGOBNNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x242CDC0", Offset = "0x242C1C0", VA = "0x18242CDC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x108ABC0", Offset = "0x1089FC0", VA = "0x18108ABC0", Slot = "4")]
	protected override Vector3 GOJLNPEDGJA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1557C00", Offset = "0x1557000", VA = "0x181557C00", Slot = "5")]
	protected override Vector3 OPNBMENLDND(Vector3 GBEJHLEFDJM, Vector3 BDGBOHJLNIE, float FOHPMIEDDCH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x694BB40", Offset = "0x694AF40", VA = "0x18694BB40", Slot = "6")]
	protected override Vector3 GIDKIJHPLDC(Vector3 LPJDDLMPNCG, float FOHPMIEDDCH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x694BAC0", Offset = "0x694AEC0", VA = "0x18694BAC0", Slot = "7")]
	protected override Vector3 GFBCKLOIMNI(Vector3 GBEJHLEFDJM, Vector3 BDGBOHJLNIE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x694BA50", Offset = "0x694AE50", VA = "0x18694BA50", Slot = "8")]
	protected override Vector3 DCKEFAHDOKG(Vector3 GBEJHLEFDJM, Vector3 BDGBOHJLNIE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x694BBA0", Offset = "0x694AFA0", VA = "0x18694BBA0")]
	public OBMFKBLCPGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NGNMLEFAJJL : global::FFANKEEFKID<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x694A7A0", Offset = "0x6949BA0", VA = "0x18694A7A0")]
	public NGNMLEFAJJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x694A730", Offset = "0x6949B30", VA = "0x18694A730")]
	public NGNMLEFAJJL(int GBNBGNMHGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1133200", Offset = "0x1132600", VA = "0x181133200", Slot = "4")]
	protected override float GOJLNPEDGJA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3A05F00", Offset = "0x3A05300", VA = "0x183A05F00", Slot = "5")]
	protected override float OPNBMENLDND(float GBEJHLEFDJM, float BDGBOHJLNIE, float FOHPMIEDDCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x568CAD0", Offset = "0x568BED0", VA = "0x18568CAD0", Slot = "6")]
	protected override float GIDKIJHPLDC(float LPJDDLMPNCG, float FOHPMIEDDCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x48BCEF0", Offset = "0x48BC2F0", VA = "0x1848BCEF0", Slot = "7")]
	protected override float GFBCKLOIMNI(float GBEJHLEFDJM, float BDGBOHJLNIE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x694A720", Offset = "0x6949B20", VA = "0x18694A720", Slot = "8")]
	protected override float DCKEFAHDOKG(float GBEJHLEFDJM, float BDGBOHJLNIE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NPJKEOMCHCE
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x167FD30", Offset = "0x167F130", VA = "0x18167FD30")]
	public static global::IDHEECGILOE<T1> IDIKGABNBEI<T1>(T1 BAAKFPHJJIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3FB6170", Offset = "0x3FB5570", VA = "0x183FB6170")]
	public static global::KHDOJBFMABD<T1, T2> IDIKGABNBEI<T1, T2>(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3FB61E0", Offset = "0x3FB55E0", VA = "0x183FB61E0")]
	public static global::ODFDCHKMIJF<T1, T2, T3> IDIKGABNBEI<T1, T2, T3>(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1A7FFD0", Offset = "0x1A7F3D0", VA = "0x181A7FFD0")]
	public static global::PMONLEGIIKG<T1, T2, T3, T4> IDIKGABNBEI<T1, T2, T3, T4>(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO, T4 PJOMOCIFAJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3032280", Offset = "0x3031680", VA = "0x183032280")]
	public static global::NNKLGPEJENN<T1, T2, T3, T4, T5> IDIKGABNBEI<T1, T2, T3, T4, T5>(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO, T4 PJOMOCIFAJM, T5 OMFBODPJPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3FB6400", Offset = "0x3FB5800", VA = "0x183FB6400")]
	public static global::AAECMIKOOPJ<T1, T2, T3, T4, T5, T6> IDIKGABNBEI<T1, T2, T3, T4, T5, T6>(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO, T4 PJOMOCIFAJM, T5 OMFBODPJPAA, T6 CGFBJPGBKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3FB6340", Offset = "0x3FB5740", VA = "0x183FB6340")]
	public static global::JJNJEJCFCGJ<T1, T2, T3, T4, T5, T6, T7> IDIKGABNBEI<T1, T2, T3, T4, T5, T6, T7>(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO, T4 PJOMOCIFAJM, T5 OMFBODPJPAA, T6 CGFBJPGBKBE, T7 KLCJIHKLGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3FB6270", Offset = "0x3FB5670", VA = "0x183FB6270")]
	public static global::KDJMGHBAKCH<T1, T2, T3, T4, T5, T6, T7, T8> IDIKGABNBEI<T1, T2, T3, T4, T5, T6, T7, T8>(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO, T4 PJOMOCIFAJM, T5 OMFBODPJPAA, T6 CGFBJPGBKBE, T7 KLCJIHKLGHO, T8 DPMJEHBBNNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x16C0AB0", Offset = "0x16BFEB0", VA = "0x1816C0AB0")]
	[IteratorStateMachine(typeof(GPEFEBJIEPE))]
	public static IEnumerable<global::KHDOJBFMABD<T1, T2>> EEJIMLGNFOI<T1, T2>(IEnumerable<T1> HFOFADIOHHP, IEnumerable<T2> GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x16C0BF0", Offset = "0x16BFFF0", VA = "0x1816C0BF0")]
	[IteratorStateMachine(typeof(HJNPPHCMGEM))]
	public static IEnumerable<global::ODFDCHKMIJF<T1, T2, T3>> EEJIMLGNFOI<T1, T2, T3>(IEnumerable<T1> HFOFADIOHHP, IEnumerable<T2> GFCGIJPPCBN, IEnumerable<T3> ENPEAFFEEPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x86C700", Offset = "0x86BB00", VA = "0x18086C700")]
	internal static int DECIANJDDBP(int FAGNMGMIOLL, int JINGHNNPNED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x86C6D0", Offset = "0x86BAD0", VA = "0x18086C6D0")]
	internal static int DECIANJDDBP(int FAGNMGMIOLL, int JINGHNNPNED, int LBCFNNKCJPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x86C6B0", Offset = "0x86BAB0", VA = "0x18086C6B0")]
	internal static int DECIANJDDBP(int FAGNMGMIOLL, int JINGHNNPNED, int LBCFNNKCJPN, int EIMIBLJJKDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x86C6E0", Offset = "0x86BAE0", VA = "0x18086C6E0")]
	internal static int DECIANJDDBP(int FAGNMGMIOLL, int JINGHNNPNED, int LBCFNNKCJPN, int EIMIBLJJKDP, int LDAEEACHNLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x694BA30", Offset = "0x694AE30", VA = "0x18694BA30")]
	internal static int DECIANJDDBP(int FAGNMGMIOLL, int JINGHNNPNED, int LBCFNNKCJPN, int EIMIBLJJKDP, int LDAEEACHNLC, int FLGGOBDMODA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x694BA00", Offset = "0x694AE00", VA = "0x18694BA00")]
	internal static int DECIANJDDBP(int FAGNMGMIOLL, int JINGHNNPNED, int LBCFNNKCJPN, int EIMIBLJJKDP, int LDAEEACHNLC, int FLGGOBDMODA, int KDPCLKFLOHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x694B9D0", Offset = "0x694ADD0", VA = "0x18694B9D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1622680", Offset = "0x1621A80", VA = "0x181622680")]
	public IDHEECGILOE(T1 BAAKFPHJJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x16224B0", Offset = "0x16218B0", VA = "0x1816224B0", Slot = "4")]
	public int CompareTo(global::IDHEECGILOE<T1> MPHACEGLFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1622520", Offset = "0x1621920", VA = "0x181622520", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x754730", Offset = "0x753B30", VA = "0x180754730", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x16225C0", Offset = "0x16219C0", VA = "0x1816225C0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x2AA1BC0", Offset = "0x2AA0FC0", VA = "0x182AA1BC0")]
	public KHDOJBFMABD(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0690", Offset = "0x2A9FA90", VA = "0x182AA0690", Slot = "4")]
	public int CompareTo(global::KHDOJBFMABD<T1, T2> MPHACEGLFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA09C0", Offset = "0x2A9FDC0", VA = "0x182AA09C0", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1170", Offset = "0x2AA0570", VA = "0x182AA1170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1770", Offset = "0x2AA0B70", VA = "0x182AA1770", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CB82F0", Offset = "0x2CB76F0", VA = "0x182CB82F0")]
	public ODFDCHKMIJF(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2CB7A60", Offset = "0x2CB6E60", VA = "0x182CB7A60", Slot = "4")]
	public int CompareTo(global::ODFDCHKMIJF<T1, T2, T3> MPHACEGLFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2CB7C60", Offset = "0x2CB7060", VA = "0x182CB7C60", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2CB7F50", Offset = "0x2CB7350", VA = "0x182CB7F50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2CB7FB0", Offset = "0x2CB73B0", VA = "0x182CB7FB0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1F95120", Offset = "0x1F94520", VA = "0x181F95120")]
	public PMONLEGIIKG(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO, T4 PJOMOCIFAJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2643D20", Offset = "0x2643120", VA = "0x182643D20", Slot = "4")]
	public int CompareTo(global::PMONLEGIIKG<T1, T2, T3, T4> MPHACEGLFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2643E60", Offset = "0x2643260", VA = "0x182643E60", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2643F80", Offset = "0x2643380", VA = "0x182643F80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2644040", Offset = "0x2643440", VA = "0x182644040", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D9A910", Offset = "0x2D99D10", VA = "0x182D9A910")]
	public NNKLGPEJENN(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO, T4 PJOMOCIFAJM, T5 OMFBODPJPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A400", Offset = "0x2D99800", VA = "0x182D9A400", Slot = "4")]
	public int CompareTo(global::NNKLGPEJENN<T1, T2, T3, T4, T5> MPHACEGLFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A580", Offset = "0x2D99980", VA = "0x182D9A580", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A6C0", Offset = "0x2D99AC0", VA = "0x182D9A6C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A7C0", Offset = "0x2D99BC0", VA = "0x182D9A7C0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x4252A00", Offset = "0x4251E00", VA = "0x184252A00")]
	public AAECMIKOOPJ(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO, T4 PJOMOCIFAJM, T5 OMFBODPJPAA, T6 CGFBJPGBKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4DD4E80", Offset = "0x4DD4280", VA = "0x184DD4E80", Slot = "4")]
	public int CompareTo(global::AAECMIKOOPJ<T1, T2, T3, T4, T5, T6> MPHACEGLFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4DD5040", Offset = "0x4DD4440", VA = "0x184DD5040", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4DD51B0", Offset = "0x4DD45B0", VA = "0x184DD51B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4DD52D0", Offset = "0x4DD46D0", VA = "0x184DD52D0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D5F6C0", Offset = "0x3D5EAC0", VA = "0x183D5F6C0")]
	public JJNJEJCFCGJ(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO, T4 PJOMOCIFAJM, T5 OMFBODPJPAA, T6 CGFBJPGBKBE, T7 KLCJIHKLGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3D5F040", Offset = "0x3D5E440", VA = "0x183D5F040", Slot = "4")]
	public int CompareTo(global::JJNJEJCFCGJ<T1, T2, T3, T4, T5, T6, T7> MPHACEGLFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3D5F240", Offset = "0x3D5E640", VA = "0x183D5F240", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3D5F3E0", Offset = "0x3D5E7E0", VA = "0x183D5F3E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3D5F530", Offset = "0x3D5E930", VA = "0x183D5F530", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3131680", Offset = "0x3130A80", VA = "0x183131680")]
	public KDJMGHBAKCH(T1 BAAKFPHJJIK, T2 ICAJBCDHCHK, T3 ELAKHKMLECO, T4 PJOMOCIFAJM, T5 OMFBODPJPAA, T6 CGFBJPGBKBE, T7 KLCJIHKLGHO, T8 DPMJEHBBNNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3130F50", Offset = "0x3130350", VA = "0x183130F50", Slot = "4")]
	public int CompareTo(global::KDJMGHBAKCH<T1, T2, T3, T4, T5, T6, T7, T8> MPHACEGLFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x31311A0", Offset = "0x31305A0", VA = "0x1831311A0", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3131360", Offset = "0x3130760", VA = "0x183131360", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x31314D0", Offset = "0x31308D0", VA = "0x1831314D0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x44CF960", Offset = "0x44CED60", VA = "0x1844CF960")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x44CFE80", Offset = "0x44CF280", VA = "0x1844CFE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float LGOOOHEJJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xE75C50", Offset = "0xE75050", VA = "0x180E75C50")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x44CFBB0", Offset = "0x44CEFB0", VA = "0x1844CFBB0")]
	public T GONPMLGOLCK(float FOHPMIEDDCH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x44CFA70", Offset = "0x44CEE70", VA = "0x1844CFA70")]
	public T FHIOHFMFPGA(float FOHPMIEDDCH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T OPNBMENLDND(T GBEJHLEFDJM, T BDGBOHJLNIE, float FOHPMIEDDCH);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3A05F00", Offset = "0x3A05300", VA = "0x183A05F00", Slot = "4")]
	protected override float OPNBMENLDND(float GBEJHLEFDJM, float BDGBOHJLNIE, float FOHPMIEDDCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6948340", Offset = "0x6947740", VA = "0x186948340")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1557C00", Offset = "0x1557000", VA = "0x181557C00", Slot = "4")]
	protected override Vector3 OPNBMENLDND(Vector3 GBEJHLEFDJM, Vector3 BDGBOHJLNIE, float FOHPMIEDDCH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x694F010", Offset = "0x694E410", VA = "0x18694F010")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x69478A0", Offset = "0x6946CA0", VA = "0x1869478A0", Slot = "4")]
	protected override Color OPNBMENLDND(Color GBEJHLEFDJM, Color BDGBOHJLNIE, float FOHPMIEDDCH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x69478F0", Offset = "0x6946CF0", VA = "0x1869478F0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GCNBNFFDNNO : global::HOJEFBPKHEA<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6948680", Offset = "0x6947A80", VA = "0x186948680")]
	public GCNBNFFDNNO(int IPADGNLNKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6948620", Offset = "0x6947A20", VA = "0x186948620")]
	public GCNBNFFDNNO(BDPFMFCEMKE[] HOCBAECCFMC, bool JGFAPJJFELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x69485B0", Offset = "0x69479B0", VA = "0x1869485B0", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
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
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public FODHJOBBMGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F250", Offset = "0x2B0E650", VA = "0x182B0F250")]
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
	[Cpp2IlInjected.Address(RVA = "0xB1FA20", Offset = "0xB1EE20", VA = "0x180B1FA20")]
	private BLAKBBMHPKG(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> BJJFEKNKIDN, int LEAKNFIMFEB, int EAIJJIKGJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x20B4690", Offset = "0x20B3A90", VA = "0x1820B4690")]
	public static global::BLAKBBMHPKG<T> GILBACJLDCL()
	{
		return default(global::BLAKBBMHPKG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x20B3100", Offset = "0x20B2500", VA = "0x1820B3100")]
	public (int, int, Task<T>) AIAIHCALLPK(int DJHDDENMEPB, [Optional] CancellationToken OIMNLGJCBEC, double ONPCMEEMBBB = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x20B4AC0", Offset = "0x20B3EC0", VA = "0x1820B4AC0")]
	public void OGKIOPBPKJG(int DJHDDENMEPB, int EAIJJIKGJEE, in T JGINNNKFHFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class JCGDINGJCOC
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6948CA0", Offset = "0x69480A0", VA = "0x186948CA0")]
	public static global::BLAKBBMHPKG<JAPIHNFIDBB> GILBACJLDCL()
	{
		return default(global::BLAKBBMHPKG<JAPIHNFIDBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6948CF0", Offset = "0x69480F0", VA = "0x186948CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1621CA0", Offset = "0x16210A0", VA = "0x181621CA0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool ADPPFIHDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> GIOIOBGHAEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x16337C0", Offset = "0x1632BC0", VA = "0x1816337C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> NJOPDFPBKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2507980", Offset = "0x2506D80", VA = "0x182507980", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3477BB0", Offset = "0x3476FB0", VA = "0x183477BB0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3477C20", Offset = "0x3477020", VA = "0x183477C20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3476D50", Offset = "0x3476150", VA = "0x183476D50")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3477890", Offset = "0x3476C90", VA = "0x183477890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3476BD0", Offset = "0x3475FD0", VA = "0x183476BD0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3477A30", Offset = "0x3476E30", VA = "0x183477A30", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3476A20", Offset = "0x3475E20", VA = "0x183476A20", Slot = "9")]
	public void Add(TKey OGFDNCPKECB, TVal LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x34769E0", Offset = "0x3475DE0", VA = "0x1834769E0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3476C30", Offset = "0x3476030", VA = "0x183476C30", Slot = "8")]
	public bool ContainsKey(TKey OGFDNCPKECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3476C90", Offset = "0x3476090", VA = "0x183476C90", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3477980", Offset = "0x3476D80", VA = "0x183477980", Slot = "10")]
	public bool Remove(TKey OGFDNCPKECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x34779B0", Offset = "0x3476DB0", VA = "0x1834779B0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F620", Offset = "0x2A9EA20", VA = "0x182A9F620", Slot = "11")]
	public bool TryGetValue(TKey OGFDNCPKECB, out TVal LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3477720", Offset = "0x3476B20", VA = "0x183477720", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3476CC0", Offset = "0x34760C0", VA = "0x183476CC0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] BGAKDGCGOMH, int HJEGHEJBGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3476970", Offset = "0x3475D70", VA = "0x183476970")]
	public void AGMLDLCGDGN(TVal IHADMCKJLJA, TKey OGFDNCPKECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3476870", Offset = "0x3475C70", VA = "0x183476870")]
	public void AGMLDLCGDGN(KeyValuePair<TVal, TKey> JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3477850", Offset = "0x3476C50", VA = "0x183477850")]
	public bool LACPNLKHFIJ(TVal OGFDNCPKECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x34776B0", Offset = "0x3476AB0", VA = "0x1834776B0")]
	public bool GMBMHDKFMPB(KeyValuePair<TVal, TKey> JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3477640", Offset = "0x3476A40", VA = "0x183477640")]
	public bool FJEBMLODAAK(TVal OGFDNCPKECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3477640", Offset = "0x3476A40", VA = "0x183477640")]
	public bool FJEBMLODAAK(KeyValuePair<TVal, TKey> JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3476DC0", Offset = "0x34761C0", VA = "0x183476DC0")]
	public bool DJKANKJNGBD(TVal OGFDNCPKECB, out TKey LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3476AC0", Offset = "0x3475EC0", VA = "0x183476AC0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> CLBKJDKBHNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x34774E0", Offset = "0x34768E0", VA = "0x1834774E0")]
	private void FDKKIKKMFHJ(TKey OGFDNCPKECB, TVal IHADMCKJLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x34772B0", Offset = "0x34766B0", VA = "0x1834772B0")]
	private void FDJPOJAPDHI(TKey OGFDNCPKECB, TVal IHADMCKJLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3476F80", Offset = "0x3476380", VA = "0x183476F80")]
	private bool EKPADMIHGAE(TKey OGFDNCPKECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x34771D0", Offset = "0x34765D0", VA = "0x1834771D0")]
	private bool EKPADMIHGAE(TVal IHADMCKJLJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3477AD0", Offset = "0x3476ED0", VA = "0x183477AD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3211370", Offset = "0x3210770", VA = "0x183211370", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2F10920", Offset = "0x2F0FD20", VA = "0x182F10920")]
		public Enumerator(global::OMJJIJBGECP<T> NPOGECPDPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x320E6E0", Offset = "0x320DAE0", VA = "0x18320E6E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3210080", Offset = "0x320F480", VA = "0x183210080", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x320E240", Offset = "0x320D640", VA = "0x18320E240")]
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
		[Cpp2IlInjected.Address(RVA = "0x493BD10", Offset = "0x493B110", VA = "0x18493BD10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x493BAD0", Offset = "0x493AED0", VA = "0x18493BAD0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x493CE00", Offset = "0x493C200", VA = "0x18493CE00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x493D700", Offset = "0x493CB00", VA = "0x18493D700")]
	public OMJJIJBGECP(int IPADGNLNKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x493B880", Offset = "0x493AC80", VA = "0x18493B880")]
	public void AGMLDLCGDGN(T FOHPMIEDDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x493C370", Offset = "0x493B770", VA = "0x18493C370")]
	public void JHAKILBFFKF(IEnumerable<T> FAOHJBCBHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x493BAB0", Offset = "0x493AEB0", VA = "0x18493BAB0")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x493D4F0", Offset = "0x493C8F0", VA = "0x18493D4F0")]
	public void OPPAJPENCPP(int EJMNNLNLAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x493BC80", Offset = "0x493B080", VA = "0x18493BC80")]
	public void HLKGMCBNPMN(int EJMNNLNLAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x493D050", Offset = "0x493C450", VA = "0x18493D050")]
	public void NNIJEOGCGNL(T[] BGAKDGCGOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x493D470", Offset = "0x493C870", VA = "0x18493D470")]
	public Enumerator OKFDNCHLPHK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x493D680", Offset = "0x493CA80", VA = "0x18493D680", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x493D680", Offset = "0x493CA80", VA = "0x18493D680", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x493CA40", Offset = "0x493BE40", VA = "0x18493CA40")]
	private int KNHFLOBKBJL(int EGNHJGKABLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x493BC50", Offset = "0x493B050", VA = "0x18493BC50")]
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
		[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7A04D0", Offset = "0x79F8D0", VA = "0x1807A04D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool ADPPFIHDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x754680", Offset = "0x753A80", VA = "0x180754680", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x754690", Offset = "0x753A90", VA = "0x180754690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3D5FFD0", Offset = "0x3D5F3D0", VA = "0x183D5FFD0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3D60070", Offset = "0x3D5F470", VA = "0x183D60070", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3D5FF70", Offset = "0x3D5F370", VA = "0x183D5FF70", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x33990A0", Offset = "0x33984A0", VA = "0x1833990A0")]
	public JKFHCJPBKPG(Func<Internal, External> FHJNDBAFJCD, Func<External, Internal> JJKFOPGJCGG, bool GLNNHMBNJIG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3D5FC90", Offset = "0x3D5F090", VA = "0x183D5FC90", Slot = "6")]
	public int IndexOf(External JPOBIIKLHON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3D5F910", Offset = "0x3D5ED10", VA = "0x183D5F910", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3D5F970", Offset = "0x3D5ED70", VA = "0x183D5F970", Slot = "13")]
	public bool Contains(External JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3D5FA00", Offset = "0x3D5EE00", VA = "0x183D5FA00", Slot = "14")]
	public void CopyTo(External[] BGAKDGCGOMH, int HJEGHEJBGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3D5F820", Offset = "0x3D5EC20", VA = "0x183D5F820", Slot = "11")]
	public void Add(External JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3D5FD80", Offset = "0x3D5F180", VA = "0x183D5FD80", Slot = "7")]
	public void Insert(int EGNHJGKABLC, External JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3D5FEE0", Offset = "0x3D5F2E0", VA = "0x183D5FEE0", Slot = "15")]
	public bool Remove(External JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3D5FE20", Offset = "0x3D5F220", VA = "0x183D5FE20", Slot = "8")]
	public void RemoveAt(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3D5FC20", Offset = "0x3D5F020", VA = "0x183D5FC20", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x20C0920", Offset = "0x20BFD20", VA = "0x1820C0920", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x734AF0", Offset = "0x733EF0", VA = "0x180734AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool ADPPFIHDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7359E0", Offset = "0x734DE0", VA = "0x1807359E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1F99AC0", Offset = "0x1F98EC0", VA = "0x181F99AC0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x1F99A60", Offset = "0x1F98E60", VA = "0x181F99A60", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1622680", Offset = "0x1621A80", VA = "0x181622680")]
	public LMKJIODFIMJ(Func<Internal, External> FHJNDBAFJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x1F99A10", Offset = "0x1F98E10", VA = "0x181F99A10")]
	public LMKJIODFIMJ(IReadOnlyList<Internal> BDHPAGCMKHB, Func<Internal, External> FHJNDBAFJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1F997C0", Offset = "0x1F98BC0", VA = "0x181F997C0")]
	public void NNIJEOGCGNL(External[] BGAKDGCGOMH, int HJEGHEJBGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1F99750", Offset = "0x1F98B50", VA = "0x181F99750", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1F999E0", Offset = "0x1F98DE0", VA = "0x181F999E0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x734AE0", Offset = "0x733EE0", VA = "0x180734AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool ADPPFIHDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7359E0", Offset = "0x734DE0", VA = "0x1807359E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x34767B0", Offset = "0x3475BB0", VA = "0x1834767B0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3476750", Offset = "0x3475B50", VA = "0x183476750", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1622680", Offset = "0x1621A80", VA = "0x181622680")]
	public GNCNGGNBDOO(IReadOnlyList<Internal> BDHPAGCMKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3476410", Offset = "0x3475810", VA = "0x183476410")]
	public bool GMBMHDKFMPB(External JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3476520", Offset = "0x3475920", VA = "0x183476520")]
	public void NNIJEOGCGNL(External[] BGAKDGCGOMH, int HJEGHEJBGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x34764B0", Offset = "0x34758B0", VA = "0x1834764B0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x20C0920", Offset = "0x20BFD20", VA = "0x1820C0920", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A39D10", Offset = "0x2A39110", VA = "0x182A39D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2A39D50", Offset = "0x2A39150", VA = "0x182A39D50")]
	protected AEEPEBKNINE(bool IOLDBGKMDLA, bool EBBDMEOEGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2A39670", Offset = "0x2A38A70", VA = "0x182A39670")]
	protected bool AEBHEPAPDOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2A39C50", Offset = "0x2A39050", VA = "0x182A39C50")]
	protected void KBHHKHLCCFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2A39960", Offset = "0x2A38D60", VA = "0x182A39960")]
	protected void EBFAMAMGDLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x252B690", Offset = "0x252AA90", VA = "0x18252B690")]
	private static void JGHBICPBILJ<U>(ref List<U> BDHPAGCMKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2A396F0", Offset = "0x2A38AF0", VA = "0x182A396F0", Slot = "5")]
	public void AGMLDLCGDGN(T DAAMKALKLMO, bool CNENNJJMJBN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2A39B10", Offset = "0x2A38F10", VA = "0x182A39B10", Slot = "6")]
	public void FJEBMLODAAK(T DAAMKALKLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2A39850", Offset = "0x2A38C50", VA = "0x182A39850")]
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
	[Cpp2IlInjected.Address(RVA = "0x69482E0", Offset = "0x69476E0", VA = "0x1869482E0")]
	public FNCKCCFNKKK(bool IOLDBGKMDLA = false, bool EBBDMEOEGJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6948070", Offset = "0x6947470", VA = "0x186948070")]
	public void GODLCEDBDHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6947FA0", Offset = "0x69473A0", VA = "0x186947FA0", Slot = "4")]
	public override void DFKNCBFBJKJ(object[] FKFCAPAEHKO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6948010", Offset = "0x6947410", VA = "0x186948010")]
	public static FNCKCCFNKKK FGAONODGAFA(FNCKCCFNKKK KHEIFICKPKO, Action DAAMKALKLMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6948280", Offset = "0x6947680", VA = "0x186948280")]
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
	[Cpp2IlInjected.Address(RVA = "0x20AFC80", Offset = "0x20AF080", VA = "0x1820AFC80")]
	public PCAPMAFAHIC(bool IOLDBGKMDLA = false, bool EBBDMEOEGJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2848D20", Offset = "0x2848120", VA = "0x182848D20")]
	public void GODLCEDBDHK(T FOHPMIEDDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2846920", Offset = "0x2845D20", VA = "0x182846920", Slot = "4")]
	public override void DFKNCBFBJKJ(object[] FKFCAPAEHKO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x28481A0", Offset = "0x28475A0", VA = "0x1828481A0")]
	public static global::PCAPMAFAHIC<T> FGAONODGAFA(global::PCAPMAFAHIC<T> KHEIFICKPKO, Action<T> DAAMKALKLMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2849D90", Offset = "0x2849190", VA = "0x182849D90")]
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
	[Cpp2IlInjected.Address(RVA = "0x20AFC80", Offset = "0x20AF080", VA = "0x1820AFC80")]
	public NPPEIHJBHGM(bool IOLDBGKMDLA = false, bool EBBDMEOEGJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x37ECE90", Offset = "0x37EC290", VA = "0x1837ECE90")]
	public void GODLCEDBDHK(T FOHPMIEDDCH, U HOIFEJJDOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x37EB7B0", Offset = "0x37EABB0", VA = "0x1837EB7B0", Slot = "4")]
	public override void DFKNCBFBJKJ(object[] FKFCAPAEHKO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x37EC030", Offset = "0x37EB430", VA = "0x1837EC030")]
	public static global::NPPEIHJBHGM<T, U> FGAONODGAFA(global::NPPEIHJBHGM<T, U> KHEIFICKPKO, Action<T, U> DAAMKALKLMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x37EE840", Offset = "0x37EDC40", VA = "0x1837EE840")]
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
	[Cpp2IlInjected.Address(RVA = "0x20AFC80", Offset = "0x20AF080", VA = "0x1820AFC80")]
	public AGNJNOILJEP(bool IOLDBGKMDLA = false, bool EBBDMEOEGJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2B9E130", Offset = "0x2B9D530", VA = "0x182B9E130")]
	public void GODLCEDBDHK(T FOHPMIEDDCH, U HOIFEJJDOKO, V CMBMGCLLFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2B9CE30", Offset = "0x2B9C230", VA = "0x182B9CE30", Slot = "4")]
	public override void DFKNCBFBJKJ(object[] FKFCAPAEHKO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D6E0", Offset = "0x2B9CAE0", VA = "0x182B9D6E0")]
	public static global::AGNJNOILJEP<T, U, V> FGAONODGAFA(global::AGNJNOILJEP<T, U, V> KHEIFICKPKO, Action<T, U, V> DAAMKALKLMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2B9F7F0", Offset = "0x2B9EBF0", VA = "0x182B9F7F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x20AFC80", Offset = "0x20AF080", VA = "0x1820AFC80")]
	public HCLMHGJANDG(bool IOLDBGKMDLA = false, bool EBBDMEOEGJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x32E0310", Offset = "0x32DF710", VA = "0x1832E0310")]
	public void GODLCEDBDHK(T FOHPMIEDDCH, U HOIFEJJDOKO, V CMBMGCLLFDP, W APNGGCJAEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x32DF090", Offset = "0x32DE490", VA = "0x1832DF090", Slot = "4")]
	public override void DFKNCBFBJKJ(object[] FKFCAPAEHKO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x32DFD90", Offset = "0x32DF190", VA = "0x1832DFD90")]
	public static global::HCLMHGJANDG<T, U, V, W> FGAONODGAFA(global::HCLMHGJANDG<T, U, V, W> KHEIFICKPKO, Action<T, U, V, W> DAAMKALKLMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x32E1330", Offset = "0x32E0730", VA = "0x1832E1330")]
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
	[Cpp2IlInjected.Address(RVA = "0x20AFC80", Offset = "0x20AF080", VA = "0x1820AFC80")]
	public JDDIDAJGJJN(bool IOLDBGKMDLA = false, bool EBBDMEOEGJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3C035E0", Offset = "0x3C029E0", VA = "0x183C035E0")]
	public void GODLCEDBDHK(T FOHPMIEDDCH, U HOIFEJJDOKO, V CMBMGCLLFDP, W APNGGCJAEIO, X GKBCEINHOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3C02C00", Offset = "0x3C02000", VA = "0x183C02C00", Slot = "4")]
	public override void DFKNCBFBJKJ(object[] FKFCAPAEHKO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3C03210", Offset = "0x3C02610", VA = "0x183C03210")]
	public static global::JDDIDAJGJJN<T, U, V, W, X> FGAONODGAFA(global::JDDIDAJGJJN<T, U, V, W, X> KHEIFICKPKO, Action<T, U, V, W, X> DAAMKALKLMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3C03870", Offset = "0x3C02C70", VA = "0x183C03870")]
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
	[Cpp2IlInjected.Address(RVA = "0x20AFC80", Offset = "0x20AF080", VA = "0x1820AFC80")]
	public HOMFNLMAJFD(bool IOLDBGKMDLA = false, bool EBBDMEOEGJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x35AE2D0", Offset = "0x35AD6D0", VA = "0x1835AE2D0")]
	public void GODLCEDBDHK(T FOHPMIEDDCH, U HOIFEJJDOKO, V CMBMGCLLFDP, W APNGGCJAEIO, X GKBCEINHOJB, Y LAMHEDHCIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x35ADBA0", Offset = "0x35ACFA0", VA = "0x1835ADBA0", Slot = "4")]
	public override void DFKNCBFBJKJ(object[] FKFCAPAEHKO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x35AE230", Offset = "0x35AD630", VA = "0x1835AE230")]
	public static global::HOMFNLMAJFD<T, U, V, W, X, Y> FGAONODGAFA(global::HOMFNLMAJFD<T, U, V, W, X, Y> KHEIFICKPKO, Action<T, U, V, W, X, Y> DAAMKALKLMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x35AEB50", Offset = "0x35ADF50", VA = "0x1835AEB50")]
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
			[Cpp2IlInjected.Address(RVA = "0x24F9620", Offset = "0x24F8A20", VA = "0x1824F9620")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x24F95F0", Offset = "0x24F89F0", VA = "0x1824F95F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x982140", Offset = "0x981540", VA = "0x180982140")]
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
		[Cpp2IlInjected.Address(RVA = "0x26D5430", Offset = "0x26D4830", VA = "0x1826D5430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1DCFC40", Offset = "0x1DCF040", VA = "0x181DCFC40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F9DC30", Offset = "0x1F9D030", VA = "0x181F9DC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x1DCFC40", Offset = "0x1DCF040", VA = "0x181DCFC40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2200600", Offset = "0x21FFA00", VA = "0x182200600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x22006F0", Offset = "0x21FFAF0", VA = "0x1822006F0")]
	public NBHNMJJGFPL(in T DGDHDKBPDKJ, int NLDHPOFAAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2200620", Offset = "0x21FFA20", VA = "0x182200620")]
	public NBHNMJJGFPL(in T DGDHDKBPDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2200580", Offset = "0x21FF980", VA = "0x182200580")]
	public IMGOMBMFCKP HNGJAHIMFPD()
	{
		return default(IMGOMBMFCKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x22005C0", Offset = "0x21FF9C0", VA = "0x1822005C0")]
	public IMGOMBMFCKP HNGJAHIMFPD(CancellationToken OIMNLGJCBEC)
	{
		return default(IMGOMBMFCKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x21FFFE0", Offset = "0x21FF3E0", VA = "0x1821FFFE0")]
	[AsyncStateMachine(typeof(global::NBHNMJJGFPL<>.NEECMGKHMNL))]
	public Task<IMGOMBMFCKP> GBMEKFCJICF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2200140", Offset = "0x21FF540", VA = "0x182200140")]
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
	[Cpp2IlInjected.Address(RVA = "0x694A6C0", Offset = "0x6949AC0", VA = "0x18694A6C0")]
	public static global::NBHNMJJGFPL<JAPIHNFIDBB> GILBACJLDCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x694A650", Offset = "0x6949A50", VA = "0x18694A650")]
	public static global::NBHNMJJGFPL<JAPIHNFIDBB> GILBACJLDCL(int NLDHPOFAAIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x167FD30", Offset = "0x167F130", VA = "0x18167FD30")]
	public static global::NBHNMJJGFPL<T> GILBACJLDCL<T>(in T DGDHDKBPDKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x26269B0", Offset = "0x2625DB0", VA = "0x1826269B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A9EA00", Offset = "0x2A9DE00", VA = "0x182A9EA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan LIEJGJFJONC
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EBC0", Offset = "0x2A9DFC0", VA = "0x182A9EBC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x342C050", Offset = "0x342B450", VA = "0x18342C050")]
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
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public AAODCMOIINL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x1621CA0", Offset = "0x16210A0", VA = "0x181621CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28431E0", Offset = "0x28425E0", VA = "0x1828431E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2235080", Offset = "0x2234480", VA = "0x182235080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D98230", Offset = "0x2D97630", VA = "0x182D98230")]
	public NMHOLBIFPJD(NOCDHBJHILD BGCGJCDLFDJ, [Optional] KGFEGJEBHDF BJAABKGEFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2D96D60", Offset = "0x2D96160", VA = "0x182D96D60")]
	public Task<TResult> CHJFGMJLAIG(TRequest FLDKBCEOGMK, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2D96A80", Offset = "0x2D95E80", VA = "0x182D96A80")]
	private void CBJEJOLBHGJ(ECEJFNHDPAO JINCAJCMEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2D97CD0", Offset = "0x2D970D0", VA = "0x182D97CD0")]
	[AsyncStateMachine(typeof(global::NMHOLBIFPJD<, >.PAHIDDECONG))]
	private Task KEDPOELLBJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2D97710", Offset = "0x2D96B10", VA = "0x182D97710")]
	private ECEJFNHDPAO GDAHFDDJKFE()
	{
		return default(ECEJFNHDPAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2D97ED0", Offset = "0x2D972D0", VA = "0x182D97ED0")]
	[AsyncStateMachine(typeof(global::NMHOLBIFPJD<, >.BBDOEOAEAJB))]
	private Task KMBJDHBKCIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2D97B00", Offset = "0x2D96F00", VA = "0x182D97B00")]
	private void JEEGIHECHJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2D97220", Offset = "0x2D96620", VA = "0x182D97220", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class DHJBNEOPNAH<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<T> BDHPAGCMKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private HashSet<T> PFBNMCNAHJB;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x1621CA0", Offset = "0x16210A0", VA = "0x181621CA0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool ADPPFIHDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public T JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2453550", Offset = "0x2452950", VA = "0x182453550", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x29A8400", Offset = "0x29A7800", VA = "0x1829A8400", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x263ABF0", Offset = "0x2639FF0", VA = "0x18263ABF0", Slot = "11")]
	public void Add(T JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x29A7F20", Offset = "0x29A7320", VA = "0x1829A7F20")]
	public bool MGFMFMIIKAH(T JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x29A82A0", Offset = "0x29A76A0", VA = "0x1829A82A0", Slot = "15")]
	public bool Remove(T JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x29A7B10", Offset = "0x29A6F10", VA = "0x1829A7B10", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2423410", Offset = "0x2422810", VA = "0x182423410", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x29A7A50", Offset = "0x29A6E50", VA = "0x1829A7A50", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x29A7AB0", Offset = "0x29A6EB0", VA = "0x1829A7AB0", Slot = "13")]
	public bool Contains(T JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x29A7AE0", Offset = "0x29A6EE0", VA = "0x1829A7AE0", Slot = "14")]
	public void CopyTo(T[] BGAKDGCGOMH, int HJEGHEJBGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x29A7B90", Offset = "0x29A6F90", VA = "0x1829A7B90", Slot = "6")]
	public int IndexOf(T JPOBIIKLHON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x29A7C90", Offset = "0x29A7090", VA = "0x1829A7C90", Slot = "7")]
	public void Insert(int EGNHJGKABLC, T JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x29A8140", Offset = "0x29A7540", VA = "0x1829A8140", Slot = "8")]
	public void RemoveAt(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x29A7E20", Offset = "0x29A7220", VA = "0x1829A7E20")]
	public void JCDEBDNJNNJ(Predicate<T> PBPBFOEECGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x29A7EF0", Offset = "0x29A72F0", VA = "0x1829A7EF0")]
	public void KJCPAGPFOFN(Comparison<T> IBMCFMEKNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x29A8320", Offset = "0x29A7720", VA = "0x1829A8320")]
	public DHJBNEOPNAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class GPKFEFFGMNK
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x69486D0", Offset = "0x6947AD0", VA = "0x1869486D0")]
	public static Vector3 GMIBPELKBBM(this GameObject DLNMCGFEPOP, float GNBLJNNIOBG)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x158A780", Offset = "0x1589B80", VA = "0x18158A780")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x68D7FC0", Offset = "0x68D73C0", VA = "0x1868D7FC0")]
		public SerializedGuid(in Guid NPIFLODGAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x694E320", Offset = "0x694D720", VA = "0x18694E320")]
		public static SerializedGuid FEDNMKCFCHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x694E3B0", Offset = "0x694D7B0", VA = "0x18694E3B0")]
		public static SerializedGuid GBJBNHKBCON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x694E440", Offset = "0x694D840", VA = "0x18694E440")]
		public bool JEJILLMBCFE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x68D7F90", Offset = "0x68D7390", VA = "0x1868D7F90", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x694E560", Offset = "0x694D960", VA = "0x18694E560", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x694E4D0", Offset = "0x694D8D0", VA = "0x18694E4D0")]
		public bool MDDDKCHCFCJ(in Guid NPIFLODGAHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x694E190", Offset = "0x694D590", VA = "0x18694E190", Slot = "7")]
		public bool Equals(SerializedGuid MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x694E240", Offset = "0x694D640", VA = "0x18694E240", Slot = "0")]
		public override bool Equals(object NBNOMDAKOCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x68D7EE0", Offset = "0x68D72E0", VA = "0x1868D7EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x68D7D20", Offset = "0x68D7120", VA = "0x1868D7D20", Slot = "6")]
		public int CompareTo(SerializedGuid MPHACEGLFIL)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class KJLCINHKICN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Type KKKDALCMGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly string PPINFLFMILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly bool PAHDPKEHCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly bool FBLOJLFFCGJ;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6948D70", Offset = "0x6948170", VA = "0x186948D70")]
	public KJLCINHKICN(Type KNLHMKMEPNN, string DCJDNPPAHJB, bool JGOHFHJABHJ = false, bool KDJHAIFEPCD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface KGJHPCFPHNI
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface CPJLHEIHPFO<T> : KGJHPCFPHNI
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	T NDNOLKCBONM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool JJCLCDIGMPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string NKHBOIDCGJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::CPJLHEIHPFO<T> NPPMHDEJOGJ(Action<T> ONJKGLOKENE);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::CPJLHEIHPFO<T> EGNHLIMAKJC(Action<T> ONJKGLOKENE);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::CPJLHEIHPFO<T> LPHBENJHJKC(Action<T, T> JAMAPGHBECG);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::CPJLHEIHPFO<T> LIKBOMDJIBG(Action<T, T> JAMAPGHBECG);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::CPJLHEIHPFO<T> MPJHLEJNHFA(Action<string> KDIPKAPLKHI);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::CPJLHEIHPFO<T> DAMBHEIPNPP(Action<string> KDIPKAPLKHI);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class KNNEHPMANMC<T> : global::CPJLHEIHPFO<T>, KGJHPCFPHNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private global::NPPEIHJBHGM<T, T> AEOCHOMDADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private global::PCAPMAFAHIC<T> DNDOKKPGDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private global::PCAPMAFAHIC<string> BEHOIFDEAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private string NOGDNAGMMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private T JGINNNKFHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private bool KBIIEKFJNKN;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public T NDNOLKCBONM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x72A400", VA = "0x18072B000", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x161EF90", Offset = "0x161E390", VA = "0x18161EF90", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JJCLCDIGMPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7B1900", Offset = "0x7B0D00", VA = "0x1807B1900", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string NKHBOIDCGJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x72F270", Offset = "0x72E670", VA = "0x18072F270", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xECB870", Offset = "0xECAC70", VA = "0x180ECB870", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3023E30", Offset = "0x3023230", VA = "0x183023E30")]
	private void BLINKILGJLB(T GJNIFGAPEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x30240E0", Offset = "0x30234E0", VA = "0x1830240E0")]
	private void MPHHEKKBJOI(string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3023F90", Offset = "0x3023390", VA = "0x183023F90")]
	public void JAIKDMLJCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3024090", Offset = "0x3023490", VA = "0x183024090", Slot = "6")]
	public global::CPJLHEIHPFO<T> LPHBENJHJKC(Action<T, T> JAMAPGHBECG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3024040", Offset = "0x3023440", VA = "0x183024040", Slot = "7")]
	public global::CPJLHEIHPFO<T> LIKBOMDJIBG(Action<T, T> JAMAPGHBECG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3024230", Offset = "0x3023630", VA = "0x183024230", Slot = "4")]
	public global::CPJLHEIHPFO<T> NPPMHDEJOGJ(Action<T> JAMAPGHBECG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3023F40", Offset = "0x3023340", VA = "0x183023F40", Slot = "5")]
	public global::CPJLHEIHPFO<T> EGNHLIMAKJC(Action<T> ONJKGLOKENE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3024190", Offset = "0x3023590", VA = "0x183024190", Slot = "8")]
	public global::CPJLHEIHPFO<T> MPJHLEJNHFA(Action<string> KDIPKAPLKHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3023ED0", Offset = "0x30232D0", VA = "0x183023ED0", Slot = "9")]
	public global::CPJLHEIHPFO<T> DAMBHEIPNPP(Action<string> KDIPKAPLKHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x30242C0", Offset = "0x30236C0", VA = "0x1830242C0")]
	public KNNEHPMANMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class FJDGBNHBHOK
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class KIBIAFICIOP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public global::CPJLHEIHPFO<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public global::GOEHKJJNHGC<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public KIBIAFICIOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x338D070", Offset = "0x338C470", VA = "0x18338D070")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x261D020", Offset = "0x261C420", VA = "0x18261D020")]
	public static global::ODHJGGEEIEO<T> PKFLHEEHOPC<T>(this global::CPJLHEIHPFO<T> OAHJIKPJCJA, Action<T> MIKGEIBIMCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class JIHOHILIMPL<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public readonly struct JMMAOJMBHJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly long FAPMLKJJLDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public readonly long MLFOHKEPDDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public readonly int CJHHEPAJDGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public readonly int HDHAEBNPHOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public readonly bool CIHOENEOJAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly string IOHEEGMAJDK;

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x2CCBB60", Offset = "0x2CCAF60", VA = "0x182CCBB60")]
		public JMMAOJMBHJK(long FAPMLKJJLDM, int CJHHEPAJDGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x2CCBBD0", Offset = "0x2CCAFD0", VA = "0x182CCBBD0")]
		public JMMAOJMBHJK(long FAPMLKJJLDM, long MLFOHKEPDDG, int CJHHEPAJDGG, int HDHAEBNPHOK, bool CIHOENEOJAJ, string IOHEEGMAJDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2CCBAA0", Offset = "0x2CCAEA0", VA = "0x182CCBAA0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void LNNHODGNCGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x2CCBB10", Offset = "0x2CCAF10", VA = "0x182CCBB10")]
		public int MMACAPOLKME()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2CCBA80", Offset = "0x2CCAE80", VA = "0x182CCBA80")]
		public int KNJGAECNIBG(int KCJMLAFEOFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x2CCB980", Offset = "0x2CCAD80", VA = "0x182CCB980")]
		public double DNGOHBBEACL()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x2CCB9F0", Offset = "0x2CCADF0", VA = "0x182CCB9F0")]
		public JMMAOJMBHJK FFLPKKJKMGG(long MLFOHKEPDDG, int HDHAEBNPHOK)
		{
			return default(JMMAOJMBHJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class HKNIJBILNIP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public readonly TKey MKIHFPLFIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly global::JIHOHILIMPL<TKey> MJOCLEMBKBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private List<HKNIJBILNIP> AMODHNECGEF;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string KAHMJAFBPOE
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x2420290", Offset = "0x241F690", VA = "0x182420290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x24F1D50", Offset = "0x24F1150", VA = "0x1824F1D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public IEnumerable<HKNIJBILNIP> PHPDFDJEEEA
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x3AA7600", Offset = "0x3AA6A00", VA = "0x183AA7600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public JMMAOJMBHJK BADNJIAHOOE
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x16BB1E0", Offset = "0x16BA5E0", VA = "0x1816BB1E0")]
			[CompilerGenerated]
			get
			{
				return default(JMMAOJMBHJK);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x3AA7620", Offset = "0x3AA6A20", VA = "0x183AA7620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3AA7730", Offset = "0x3AA6B30", VA = "0x183AA7730")]
		internal HKNIJBILNIP(global::JIHOHILIMPL<TKey> MJOCLEMBKBO, TKey OGFDNCPKECB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3AA7340", Offset = "0x3AA6740", VA = "0x183AA7340")]
		public HKNIJBILNIP BDBOCMEBKIB(TKey OGFDNCPKECB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3AA7650", Offset = "0x3AA6A50", VA = "0x183AA7650")]
		public void MMBFNPPJLAK(TKey OGFDNCPKECB, Action<HKNIJBILNIP> DAAMKALKLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x1A3B780", Offset = "0x1A3AB80", VA = "0x181A3B780")]
		public T MMBFNPPJLAK<T>(TKey OGFDNCPKECB, Func<HKNIJBILNIP, T> MPPDBHKFNNP)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x1A3B610", Offset = "0x1A3AA10", VA = "0x181A3B610")]
		[AsyncStateMachine(typeof(NJHLLDJEBCG))]
		public Task<T> CKJEFFKIKEP<T>(TKey OGFDNCPKECB, Func<HKNIJBILNIP, Task<T>> MPPDBHKFNNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3AA7450", Offset = "0x3AA6850", VA = "0x183AA7450", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class BEIGFDBFKFF : IEnumerable<(TKey, List<TKey>, JMMAOJMBHJK)>, IEnumerable, IEnumerator<(TKey, List<TKey>, JMMAOJMBHJK)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private (TKey key, List<TKey> path, JMMAOJMBHJK timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public global::JIHOHILIMPL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private IEnumerator<(TKey key, List<TKey> path, JMMAOJMBHJK timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private (TKey, List<TKey>, JMMAOJMBHJK) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x223AB70", Offset = "0x2239F70", VA = "0x18223AB70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, JMMAOJMBHJK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x223ABE0", Offset = "0x2239FE0", VA = "0x18223ABE0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x223AC90", Offset = "0x223A090", VA = "0x18223AC90")]
		[DebuggerHidden]
		public BEIGFDBFKFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x1F92660", Offset = "0x1F91A60", VA = "0x181F92660", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x223A800", Offset = "0x2239C00", VA = "0x18223A800", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x223AC40", Offset = "0x223A040", VA = "0x18223AC40")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x223ABA0", Offset = "0x2239FA0", VA = "0x18223ABA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x223AAB0", Offset = "0x2239EB0", VA = "0x18223AAB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, JMMAOJMBHJK)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x1D001E0", Offset = "0x1CFF5E0", VA = "0x181D001E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class CJBIKMOGOON : IEnumerable<(TKey, List<TKey>, JMMAOJMBHJK)>, IEnumerable, IEnumerator<(TKey, List<TKey>, JMMAOJMBHJK)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private (TKey key, List<TKey> path, JMMAOJMBHJK timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private HKNIJBILNIP timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public HKNIJBILNIP <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public global::JIHOHILIMPL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private IEnumerator<HKNIJBILNIP> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private IEnumerator<(TKey key, List<TKey> path, JMMAOJMBHJK timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		private (TKey, List<TKey>, JMMAOJMBHJK) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x223AB70", Offset = "0x2239F70", VA = "0x18223AB70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, JMMAOJMBHJK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x258C770", Offset = "0x258BB70", VA = "0x18258C770", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x223AC90", Offset = "0x223A090", VA = "0x18223AC90")]
		[DebuggerHidden]
		public CJBIKMOGOON(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x258C7D0", Offset = "0x258BBD0", VA = "0x18258C7D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x258C080", Offset = "0x258B480", VA = "0x18258C080", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x258C870", Offset = "0x258BC70", VA = "0x18258C870")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x258C8D0", Offset = "0x258BCD0", VA = "0x18258C8D0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x258C730", Offset = "0x258BB30", VA = "0x18258C730", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x258C620", Offset = "0x258BA20", VA = "0x18258C620", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, JMMAOJMBHJK)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x258C700", Offset = "0x258BB00", VA = "0x18258C700", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Action<TKey, JMMAOJMBHJK> COKLPKAABGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly Action<TKey, JMMAOJMBHJK> NODLPGLEFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Action<global::JIHOHILIMPL<TKey>> HCHLKLFNEGO;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const string LBONLEKBKBI = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly HKNIJBILNIP FAPAIIGMCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool AJCOIBJBODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int KGOJGEOHEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly Stopwatch DDCPMELELDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly int KJHNJJFJBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private string DFLGMPJDMFO;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public HKNIJBILNIP NGBFKGAEPJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x72F270", Offset = "0x72E670", VA = "0x18072F270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	[NotNull]
	public string KAHMJAFBPOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x72B0F0", Offset = "0x72A4F0", VA = "0x18072B0F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3D5B580", Offset = "0x3D5A980", VA = "0x183D5B580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public long GHBLFPODMCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3D5B880", Offset = "0x3D5AC80", VA = "0x183D5B880")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int HJALGADEINK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3D5B850", Offset = "0x3D5AC50", VA = "0x183D5B850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3D5B8C0", Offset = "0x3D5ACC0", VA = "0x183D5B8C0")]
	public JIHOHILIMPL(TKey DBJMDGJGPDC, [Optional] int? CJHHEPAJDGG, [Optional][CanBeNull] Stopwatch DDCPMELELDJ, [Optional] Action<TKey, JMMAOJMBHJK> COKLPKAABGN, [Optional] Action<TKey, JMMAOJMBHJK> NODLPGLEFIB, [Optional] Action<global::JIHOHILIMPL<TKey>> HCHLKLFNEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3D5B740", Offset = "0x3D5AB40", VA = "0x183D5B740", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x3D5B560", Offset = "0x3D5A960", VA = "0x183D5B560")]
	public void CBABINIJGKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x3D5B8A0", Offset = "0x3D5ACA0", VA = "0x183D5B8A0")]
	public void HIIBJMKOCAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x3D5B6B0", Offset = "0x3D5AAB0", VA = "0x183D5B6B0")]
	[IteratorStateMachine(typeof(global::JIHOHILIMPL<>.BEIGFDBFKFF))]
	public IEnumerable<(TKey, List<TKey>, JMMAOJMBHJK)> DGCHFHLGKFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x3D5B5E0", Offset = "0x3D5A9E0", VA = "0x183D5B5E0")]
	[IteratorStateMachine(typeof(global::JIHOHILIMPL<>.CJBIKMOGOON))]
	private IEnumerable<(TKey, List<TKey>, JMMAOJMBHJK)> DGCHFHLGKFL(List<TKey> CCJFOCJJBJG, HKNIJBILNIP PALCKANNDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x3D5B7D0", Offset = "0x3D5ABD0", VA = "0x183D5B7D0")]
	private (long, int) EIGDBDNLKNK()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class BKGGJHCGCBG<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut EPKFIKOBHCN(global::JIHOHILIMPL<TKey> MJOCLEMBKBO);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
	protected BKGGJHCGCBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public abstract class BEJLEKBJGKO<TKey> : global::BKGGJHCGCBG<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate string LBNCNMKMHHM(TKey OGFDNCPKECB);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x223ACD0", Offset = "0x223A0D0", VA = "0x18223ACD0")]
	protected string ALDLPKCGCLN(double HGMGDKBLDGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x223AF60", Offset = "0x223A360", VA = "0x18223AF60")]
	protected string LNNHPNENOOO(int PKAHDKMMFHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x223AF20", Offset = "0x223A320", VA = "0x18223AF20")]
	private static string FAPDHNGHDIL(TKey OGFDNCPKECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x223AD40", Offset = "0x223A140", VA = "0x18223AD40", Slot = "4")]
	public override string EPKFIKOBHCN(global::JIHOHILIMPL<TKey> MJOCLEMBKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x223ADF0", Offset = "0x223A1F0", VA = "0x18223ADF0")]
	public string EPKFIKOBHCN(global::JIHOHILIMPL<TKey> MJOCLEMBKBO, [NotNull] LBNCNMKMHHM BDJGKOHMMJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string DKEELFMGOJI(global::JIHOHILIMPL<TKey> MJOCLEMBKBO, [NotNull] LBNCNMKMHHM BDJGKOHMMJP);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x20C0920", Offset = "0x20BFD20", VA = "0x1820C0920")]
	protected BEJLEKBJGKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class DDBGEBFDEKP<TKey> : global::BKGGJHCGCBG<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public delegate string JFPKCCKGMJC(TKey OGFDNCPKECB);

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private const int IHNOLMFGJBG = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly string FFNJKJJPDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly double NNNIFDJHGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly bool PFAOBJGKIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly int OAKJIPCPCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly ISet<string> OCGEDHJAJHA;

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x299BF90", Offset = "0x299B390", VA = "0x18299BF90")]
	private static string FAPDHNGHDIL(TKey OGFDNCPKECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x299C300", Offset = "0x299B700", VA = "0x18299C300")]
	public DDBGEBFDEKP(string FFNJKJJPDHO = "F2", double NNNIFDJHGDA = double.MaxValue, bool PFAOBJGKIDL = false, int OAKJIPCPCBD = int.MaxValue, [Optional] ISet<string> OCGEDHJAJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x299B9A0", Offset = "0x299ADA0", VA = "0x18299B9A0", Slot = "4")]
	public override Dictionary<string, string> EPKFIKOBHCN(global::JIHOHILIMPL<TKey> MJOCLEMBKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x299B8C0", Offset = "0x299ACC0", VA = "0x18299B8C0")]
	private bool AOJEAAKCEJL(string JNCLPNAAHHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x299BA50", Offset = "0x299AE50", VA = "0x18299BA50")]
	public Dictionary<string, string> EPKFIKOBHCN(global::JIHOHILIMPL<TKey> MJOCLEMBKBO, JFPKCCKGMJC BDJGKOHMMJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x299BFD0", Offset = "0x299B3D0", VA = "0x18299BFD0")]
	private string JFOJGAHBKPC(StringBuilder HCLLLIOFJIC, List<TKey> BKDLMACMGAL, JFPKCCKGMJC BDJGKOHMMJP, bool PPNMHEJNELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x299C180", Offset = "0x299B580", VA = "0x18299C180")]
	private static void OEKEDDIJBBE(StringBuilder LJOHODPAOEJ, string CPCEIPDEIGM, bool CHDALPDLOME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class HDPMOGBOGLB<TKey> : global::BEJLEKBJGKO<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct FAGOHPBJGIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public LBNCNMKMHHM keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static global::HDPMOGBOGLB<TKey> AGBLMGNNIDO;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private const int LDECEMGEGKJ = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly string[] DCAELNFPPGD;

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x32E2FB0", Offset = "0x32E23B0", VA = "0x1832E2FB0")]
	private HDPMOGBOGLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x32E1FC0", Offset = "0x32E13C0", VA = "0x1832E1FC0", Slot = "5")]
	protected override string DKEELFMGOJI(global::JIHOHILIMPL<TKey> MJOCLEMBKBO, LBNCNMKMHHM BDJGKOHMMJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x32E1ED0", Offset = "0x32E12D0", VA = "0x1832E1ED0")]
	[CompilerGenerated]
	internal static string CBJBIMGPKCL(string HBBKGHPAOGL, TKey OGFDNCPKECB, ref FAGOHPBJGIK P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class PBMGFPDCDJM<TKey> : global::BEJLEKBJGKO<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class JKIPFPJIOGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public LBNCNMKMHHM keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public JKIPFPJIOGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x16226C0", Offset = "0x1621AC0", VA = "0x1816226C0")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x2845930", Offset = "0x2844D30", VA = "0x182845930", Slot = "5")]
	protected override string DKEELFMGOJI(global::JIHOHILIMPL<TKey> MJOCLEMBKBO, LBNCNMKMHHM BDJGKOHMMJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x2846380", Offset = "0x2845780", VA = "0x182846380")]
	public PBMGFPDCDJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public sealed class GCJGKGEEBNN : global::JIHOHILIMPL<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class OOHNNFJGPGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Action<GCJGKGEEBNN> callback;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public OOHNNFJGPGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x694BC10", Offset = "0x694B010", VA = "0x18694BC10")]
		internal void <Wrap>b__0(global::JIHOHILIMPL<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6948460", Offset = "0x6947860", VA = "0x186948460")]
	public GCJGKGEEBNN([Optional] string LAGLMNHLDAA, [Optional] int? CJHHEPAJDGG, [Optional] Stopwatch DDCPMELELDJ, [Optional] Action<string, JMMAOJMBHJK> COKLPKAABGN, [Optional] Action<string, JMMAOJMBHJK> NODLPGLEFIB, [Optional] Action<GCJGKGEEBNN> HCHLKLFNEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6948380", Offset = "0x6947780", VA = "0x186948380")]
	private static Action<global::JIHOHILIMPL<string>> MMBFNPPJLAK(Action<GCJGKGEEBNN> MIKGEIBIMCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class KODONBPOAKI
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private class FEJECCMAOJI : KODONBPOAKI
	{
		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public static KODONBPOAKI AGBLMGNNIDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x6947C00", Offset = "0x6947000", VA = "0x186947C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public override DateTime LDLMCHDJNFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x6947C60", Offset = "0x6947060", VA = "0x186947C60", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public override float OOHNDBILHBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0xCC68E0", Offset = "0xCC5CE0", VA = "0x180CC68E0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x6947D50", Offset = "0x6947150", VA = "0x186947D50")]
		public FEJECCMAOJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static KODONBPOAKI FKNONFGLPLG;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public static KODONBPOAKI EBMJMAANCBN
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6949410", Offset = "0x6948810", VA = "0x186949410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract DateTime LDLMCHDJNFI
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public abstract float OOHNDBILHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	protected KODONBPOAKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class AEDBNBJMPNK : global::HOLGIBPNJJN<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6947260", Offset = "0x6946660", VA = "0x186947260")]
	public AEDBNBJMPNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class HOLGIBPNJJN<T> : global::EBCMIJBCHOC<T>, CNCDPCJODNI, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Task<T> LJIHFECCOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	private Task NABIIJNOOBO
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x1379D50", Offset = "0x1379150", VA = "0x181379D50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public global::ODHJGGEEIEO<T> GDHMGJIPGBA
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private JKAHJLGEFLE PCKBHIEKEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xECAB60", Offset = "0xEC9F60", VA = "0x180ECAB60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x35AD260", Offset = "0x35AC660", VA = "0x1835AD260")]
	public HOLGIBPNJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class NIHJLIINIEH : global::CFJOJAKKIAA<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x694A810", Offset = "0x6949C10", VA = "0x18694A810")]
	public NIHJLIINIEH(Exception CCICIDAGDNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class CFJOJAKKIAA<T> : global::EBCMIJBCHOC<T>, CNCDPCJODNI, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Task<T> LJIHFECCOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private Task NABIIJNOOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x1379D50", Offset = "0x1379150", VA = "0x181379D50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public global::ODHJGGEEIEO<T> GDHMGJIPGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private JKAHJLGEFLE PCKBHIEKEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xECAB60", Offset = "0xEC9F60", VA = "0x180ECAB60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x41907D0", Offset = "0x418FBD0", VA = "0x1841907D0")]
	public CFJOJAKKIAA(Exception CCICIDAGDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface CNCDPCJODNI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	[NotNull]
	Task LJIHFECCOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	[NotNull]
	JKAHJLGEFLE GDHMGJIPGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface EBCMIJBCHOC<T> : CNCDPCJODNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	[NotNull]
	new Task<T> LJIHFECCOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	[NotNull]
	new global::ODHJGGEEIEO<T> GDHMGJIPGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public abstract class MHEOJPLBDHK<TTask, T> : global::EBCMIJBCHOC<T>, CNCDPCJODNI, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class FMCEKHDCONP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public global::MHEOJPLBDHK<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public FMCEKHDCONP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static bool JFBJFCODIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly Task<T> IBCOHPONNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	protected readonly CancellationTokenSource FFLFGHGEBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private bool AJCOIBJBODA;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Task<T> LJIHFECCOGI
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private Task NABIIJNOOBO
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public global::ODHJGGEEIEO<T> GDHMGJIPGBA
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private JKAHJLGEFLE PCKBHIEKEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x1614FC0", Offset = "0x16143C0", VA = "0x181614FC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool AMOPNJPCIDE
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x754680", Offset = "0x753A80", VA = "0x180754680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2B22FB0", Offset = "0x2B223B0", VA = "0x182B22FB0")]
	static MHEOJPLBDHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x2B23400", Offset = "0x2B22800", VA = "0x182B23400")]
	protected MHEOJPLBDHK(TTask IBCOHPONNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x2B22F40", Offset = "0x2B22340", VA = "0x182B22F40", Slot = "1")]
	~MHEOJPLBDHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x2B22F10", Offset = "0x2B22310", VA = "0x182B22F10", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2B22D40", Offset = "0x2B22140", VA = "0x182B22D40")]
	private void BINPACHFFEJ(bool EAHOPLANFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T MINEMMPJOIG(TTask HBFIDOBGAPM);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void KOALCNLAFEB();
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class BCKAINFMIAF
{
	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6947300", Offset = "0x6946700", VA = "0x186947300")]
	[NotNull]
	public static byte[] BCDOJAHCBCP(this FAIGGLEHEDM MGLHBIIFODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6947370", Offset = "0x6946770", VA = "0x186947370")]
	[NotNull]
	public static byte[] BCDOJAHCBCP(this FAIGGLEHEDM MGLHBIIFODH, HashAlgorithmName IIKDGHKHDHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6947710", Offset = "0x6946B10", VA = "0x186947710")]
	public static bool PEGPHMCDMPP([CanBeNull] this FAIGGLEHEDM MGLHBIIFODH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6947570", Offset = "0x6946970", VA = "0x186947570")]
	public static bool PEGPHMCDMPP([CanBeNull] this FAIGGLEHEDM MGLHBIIFODH, out string NOGDNAGMMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6947500", Offset = "0x6946900", VA = "0x186947500")]
	private static string PADFCJJDFHB([CanBeNull] byte[] EMIAMELGKNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x69473E0", Offset = "0x69467E0", VA = "0x1869473E0")]
	private static bool LGIGIDBIABH([NotNull] FAIGGLEHEDM MGLHBIIFODH, [CanBeNull] out byte[] FFBBLNFFIMC, [CanBeNull] out byte[] JMNAELLEPIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class FCBHLPFOGPO
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6947B60", Offset = "0x6946F60", VA = "0x186947B60")]
	[NotNull]
	public static byte[] BCDOJAHCBCP(this LKBIMFKHBEM FNIEIJGCFBK, byte[] NHOLNGAAEHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6947930", Offset = "0x6946D30", VA = "0x186947930")]
	[NotNull]
	public static byte[] BCDOJAHCBCP(this LKBIMFKHBEM FNIEIJGCFBK, HashAlgorithmName IIKDGHKHDHB, byte[] NHOLNGAAEHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface LKBIMFKHBEM
{
	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash IECKGMJMGEA);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface FAIGGLEHEDM : LKBIMFKHBEM
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	[CanBeNull]
	byte[] LHEPIPBKNJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	[CanBeNull]
	byte[] ADPIDMIGKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	UnityEngine.Object JDFCIAMCACO
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class NMNKCFJILIG
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private class FKNEAIKPHIL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6947F20", Offset = "0x6947320", VA = "0x186947F20")]
		public FKNEAIKPHIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6947EC0", Offset = "0x69472C0", VA = "0x186947EC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const byte POIFJEHNKKP = 1;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private const byte GLCBKEKPPOG = 0;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly ArrayPool<byte> EFOKBOHHFDM;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool ABLJEKPBDIM;

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x3FB4620", Offset = "0x3FB3A20", VA = "0x183FB4620")]
	[Conditional("UNITY_EDITOR")]
	private static void DPJKMJODBAI<T>(params T[] PLABMCDKLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x694B2B0", Offset = "0x694A6B0", VA = "0x18694B2B0")]
	public static IDisposable JNBHIJOGGBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x694B690", Offset = "0x694AA90", VA = "0x18694B690")]
	public static void LGJMFINFEPJ(this IncrementalHash GJLFEMNLDOL, [CanBeNull] GameObject DLNMCGFEPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x3FB4E00", Offset = "0x3FB4200", VA = "0x183FB4E00")]
	public static void LGJMFINFEPJ<T>(this IncrementalHash GJLFEMNLDOL, [CanBeNull] T AFCHMEJMNBE) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x3FB4910", Offset = "0x3FB3D10", VA = "0x183FB4910")]
	public static void GNBNGFPMCAO<T>(this IncrementalHash GJLFEMNLDOL, [CanBeNull] T FNIEIJGCFBK) where T : LKBIMFKHBEM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x3FB49A0", Offset = "0x3FB3DA0", VA = "0x183FB49A0")]
	public static void HOAOPNDJNLN<T>(this IncrementalHash GJLFEMNLDOL, [CanBeNull] IList<T> CDFFAECNDLJ) where T : LKBIMFKHBEM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x694AC00", Offset = "0x694A000", VA = "0x18694AC00")]
	private static bool CHGBKKBBEAD([CanBeNull] LKBIMFKHBEM FNIEIJGCFBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x694B250", Offset = "0x694A650", VA = "0x18694B250")]
	public static void IEHLDPJIGAB(this IncrementalHash IECKGMJMGEA, [CanBeNull] string BOPPCHMNKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x694B4C0", Offset = "0x694A8C0", VA = "0x18694B4C0")]
	public static void LCEEIPBECEN(this IncrementalHash IECKGMJMGEA, long FJCDCEEJJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x694A860", Offset = "0x6949C60", VA = "0x18694A860")]
	public static void ABOGJJADDJI(this IncrementalHash IECKGMJMGEA, int OLAOPLEEFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x694AA30", Offset = "0x6949E30", VA = "0x18694AA30")]
	public static void BANBJKHJONF(this IncrementalHash IECKGMJMGEA, short GEBDKOIOLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x694B350", Offset = "0x694A750", VA = "0x18694B350")]
	public static void KOLLHFIFLLE(this IncrementalHash IECKGMJMGEA, byte AFFOIGDGJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x694AE00", Offset = "0x694A200", VA = "0x18694AE00")]
	public static void EPBKNEDKNJC(this IncrementalHash IECKGMJMGEA, bool DOIDFCJHFKF, bool PMOHPJMBEKK = false, bool JNKPLGNNDAP = false, bool KKIBMIAPMOE = false, bool BMGGJNOMIHJ = false, bool PJMLLJPGGGG = false, bool GHLOGMEKBDB = false, bool LJGHNNKPPEL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x3FB3F30", Offset = "0x3FB3330", VA = "0x183FB3F30")]
	public static void ABGOCIFGJBH<T>(this IncrementalHash IECKGMJMGEA, T LOCDANMFCCO) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x694B1F0", Offset = "0x694A5F0", VA = "0x18694B1F0")]
	public static void GNOBJCGODJE(this IncrementalHash IECKGMJMGEA, float DLMMCNAKBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x694B7F0", Offset = "0x694ABF0", VA = "0x18694B7F0")]
	public static void OFEOFFBOCCM(this IncrementalHash IECKGMJMGEA, double KIEHLANHILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x694B780", Offset = "0x694AB80", VA = "0x18694B780")]
	public static void NIHPEOLMLBN(this IncrementalHash IECKGMJMGEA, ulong LKOBDFEMPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x694B190", Offset = "0x694A590", VA = "0x18694B190")]
	public static void GKLALBPCPLL(this IncrementalHash IECKGMJMGEA, uint PLNIAFCPMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x694B850", Offset = "0x694AC50", VA = "0x18694B850")]
	public static void PGNMNMKGOKE(this IncrementalHash IECKGMJMGEA, ushort CKFMJDMBBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x694AC90", Offset = "0x694A090", VA = "0x18694AC90")]
	public static void CLEIDBOBJPE(this IncrementalHash IECKGMJMGEA, Vector3 JDIACDFLEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x694AFD0", Offset = "0x694A3D0", VA = "0x18694AFD0")]
	public static void FKLOFFJIAPD(this IncrementalHash IECKGMJMGEA, Quaternion DFLIBNDHMJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class HMPHHPHADKB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public readonly Type KKKDALCMGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public readonly string PPINFLFMILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public readonly bool PAHDPKEHCMJ;

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x6948AB0", Offset = "0x6947EB0", VA = "0x186948AB0")]
	public HMPHHPHADKB(Type KNLHMKMEPNN, string DCJDNPPAHJB, bool JGOHFHJABHJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class IPNHABKPCLJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6948B90", Offset = "0x6947F90", VA = "0x186948B90")]
	public IPNHABKPCLJ(string BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x6948B10", Offset = "0x6947F10", VA = "0x186948B10")]
	public IPNHABKPCLJ(string BALNMHDNCIN, Exception FCOGIEGFKLD)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x72B020", Offset = "0x72A420", VA = "0x18072B020")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x72B0E0", Offset = "0x72A4E0", VA = "0x18072B0E0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public T this[int FMPGMDDDGFN, int MCPCFIDHHAB]
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x36B2AD0", Offset = "0x36B1ED0", VA = "0x1836B2AD0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x36B2B70", Offset = "0x36B1F70", VA = "0x1836B2B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x36B2A40", Offset = "0x36B1E40", VA = "0x1836B2A40")]
		public Array2D(uint CNHIJOPNDKB, uint PJDCFLLCMEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x36B29C0", Offset = "0x36B1DC0", VA = "0x1836B29C0")]
		public void BONIBAPHNIO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x69472A0", Offset = "0x69466A0", VA = "0x1869472A0")]
		public Array2DVector3(uint CNHIJOPNDKB, uint PJDCFLLCMEF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal static class GIPCHDBGCJA
{
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public const int FHMOKNMPIDI = -1;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public const int FOAGCPPACCD = 0;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[DefaultMember("Item")]
public class CLENJHDFPIE<THandle, TValue> : IDisposable where THandle : struct, AHPPOODHHGC where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly List<THandle> FENIMIGFDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly List<TValue> FMHMDECCGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly Func<TValue> NLNLNBDDADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Action<TValue> BJDGPHOBIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int HJMJCDGHHOC;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public TValue JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2593F70", Offset = "0x2593370", VA = "0x182593F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x2594970", Offset = "0x2593D70", VA = "0x182594970")]
	public CLENJHDFPIE(Action<TValue> BJDGPHOBIED, [Optional] Func<TValue> NLNLNBDDADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x2593FD0", Offset = "0x25933D0", VA = "0x182593FD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x25943E0", Offset = "0x25937E0", VA = "0x1825943E0")]
	public THandle IDIKGABNBEI()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x2593DD0", Offset = "0x25931D0", VA = "0x182593DD0")]
	public THandle AGMLDLCGDGN(TValue LPJDDLMPNCG)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x2594210", Offset = "0x2593610", VA = "0x182594210")]
	public bool FJEBMLODAAK(THandle IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x2594640", Offset = "0x2593A40", VA = "0x182594640")]
	public bool JALMAFNAIBH(THandle IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x25948A0", Offset = "0x2593CA0", VA = "0x1825948A0")]
	public bool OBCGBBDEENH(THandle IGELLPOEMHM, out TValue LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x25947F0", Offset = "0x2593BF0", VA = "0x1825947F0")]
	public TValue MKLBNKEKMJE(THandle IGELLPOEMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2594160", Offset = "0x2593560", VA = "0x182594160")]
	public bool FIKLEKNKGJP(THandle IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x2593FA0", Offset = "0x25933A0", VA = "0x182593FA0")]
	private THandle DMOMDPLOGFE(int EGNHJGKABLC)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x2594940", Offset = "0x2593D40", VA = "0x182594940")]
	private TValue PKFLHEEHOPC(int EGNHJGKABLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x2593E40", Offset = "0x2593240", VA = "0x182593E40")]
	private void APJILCOBIBI(int EGNHJGKABLC, in THandle IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x2593E80", Offset = "0x2593280", VA = "0x182593E80")]
	private void BLINKILGJLB(int EGNHJGKABLC, in TValue LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x2594050", Offset = "0x2593450", VA = "0x182594050")]
	private THandle EFJHLEDGEDE()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x2593EC0", Offset = "0x25932C0", VA = "0x182593EC0")]
	private void CJFOEHEMAHG(THandle IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x25947E0", Offset = "0x2593BE0", VA = "0x1825947E0")]
	private int LBLHAGKICIN(int NHBDMCDLELK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x2593DC0", Offset = "0x25931C0", VA = "0x182593DC0")]
	private bool AAEHFAEHJNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x785A50", Offset = "0x784E50", VA = "0x180785A50")]
	private void PMJHJPGINOF(THandle IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x25942C0", Offset = "0x25936C0", VA = "0x1825942C0")]
	private bool HFDKKIDPDIE(out THandle IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x2594710", Offset = "0x2593B10", VA = "0x182594710")]
	private bool JJEBLKPGKOP(out THandle IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x2594840", Offset = "0x2593C40", VA = "0x182594840")]
	private void NKEOLJANKOB(THandle IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x2594520", Offset = "0x2593920", VA = "0x182594520")]
	private void ILCDFPNEIAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public interface AHPPOODHHGC
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	int CMHFEELAEBD
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int PELKNHEANOH
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface CMECDGBHMLE<T> : AHPPOODHHGC, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class HHDGLGGLABK
{
	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x29FC330", Offset = "0x29FB730", VA = "0x1829FC330")]
	public static bool EPHFNJKGAEI<T>(this T IGELLPOEMHM, T MPHACEGLFIL) where T : struct, AHPPOODHHGC
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x29FC350", Offset = "0x29FB750", VA = "0x1829FC350")]
	public static bool FAKGJGPBFFP<T>(this T IGELLPOEMHM) where T : struct, AHPPOODHHGC
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x69489A0", Offset = "0x6947DA0", VA = "0x1869489A0")]
	public static string HJOOMKAIGJN(this AHPPOODHHGC IGELLPOEMHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class POPGJGFHLDH
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private enum AGOIHHCGNAN : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int IECKGMJMGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private bool MEKLLCFGGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private AGOIHHCGNAN OJNFGJAPBNC;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool IDMILJKGOPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x694BF90", Offset = "0x694B390", VA = "0x18694BF90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool ICKLCMMNJKD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x694BDD0", Offset = "0x694B1D0", VA = "0x18694BDD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x694CB90", Offset = "0x694BF90", VA = "0x18694CB90")]
	public POPGJGFHLDH(bool MEKLLCFGGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x694BFA0", Offset = "0x694B3A0", VA = "0x18694BFA0")]
	public void IGAINJAPODI(object NBNOMDAKOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x694BE80", Offset = "0x694B280", VA = "0x18694BE80")]
	public void EHCBNIDBEHH(int LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x694C810", Offset = "0x694BC10", VA = "0x18694C810")]
	public void MNIPEODDIMN(uint MLKIMELJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x694C7B0", Offset = "0x694BBB0", VA = "0x18694C7B0")]
	public void LIDKLPHDEOC(bool GIFMAENCFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x694C7D0", Offset = "0x694BBD0", VA = "0x18694C7D0")]
	public void LIDNILHBFFP(long GMEAMCBCPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x694C620", Offset = "0x694BA20", VA = "0x18694C620")]
	public void JBICBKMJPKK(ulong JHDAFJCDGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x694C740", Offset = "0x694BB40", VA = "0x18694C740")]
	public void LICEINAIOJD(string ADAJMBMBPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x694BDE0", Offset = "0x694B1E0", VA = "0x18694BDE0")]
	public void AKEHMMDAHAF(Enum CCICIDAGDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x694BCA0", Offset = "0x694B0A0", VA = "0x18694BCA0")]
	public void AFBADBKMPFF(IList BDHPAGCMKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D2E0", Offset = "0x2D0C6E0", VA = "0x182D0D2E0")]
	public void BICOGHBMBOB<T, U>(Dictionary<T, U> EJLCKGIMPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x694C820", Offset = "0x694BC20", VA = "0x18694C820")]
	private void OPCIEFHNCLN(IDictionary EJLCKGIMPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x694C6D0", Offset = "0x694BAD0", VA = "0x18694C6D0")]
	public int LCBKIOBHGMB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x694BF20", Offset = "0x694B320", VA = "0x18694BF20")]
	public short EJCHMBCPGNF()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x694BE70", Offset = "0x694B270", VA = "0x18694BE70")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x694C660", Offset = "0x694BA60", VA = "0x18694C660")]
	private void LBJDHCEADPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public abstract class JAPJGABBKJA<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	internal class BEOJEGMMGFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public TNode INHKNJBCCPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public TNode GGEKFPEBLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public JJJLMLOANEM HCAPMBLBEEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public List<JJJLMLOANEM> JCOKABFBFFG;

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public BEOJEGMMGFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	internal struct JJJLMLOANEM : IComparable<JJJLMLOANEM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public int EICBOGNBLMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public TClaimant MMDGKGGDGMM;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x73FAF0", Offset = "0x73EEF0", VA = "0x18073FAF0")]
		public JJJLMLOANEM(int EICBOGNBLMD, TClaimant MMDGKGGDGMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x3D5EF70", Offset = "0x3D5E370", VA = "0x183D5EF70")]
		public bool LMNIICCNLNL(in JJJLMLOANEM MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x3D5EF50", Offset = "0x3D5E350", VA = "0x183D5EF50")]
		public bool AMDIGGJIENG(in JJJLMLOANEM MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x3D5EF60", Offset = "0x3D5E360", VA = "0x183D5EF60", Slot = "4")]
		public int CompareTo(JJJLMLOANEM MPHACEGLFIL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D5EFD0", Offset = "0x3D5E3D0", VA = "0x183D5EFD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public enum GDKANIKGDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class OAAGNHMNOBB : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public global::JAPJGABBKJA<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x20AF990", Offset = "0x20AED90", VA = "0x1820AF990")]
		[DebuggerHidden]
		public OAAGNHMNOBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3980", Offset = "0x2CA2D80", VA = "0x182CA3980", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3B40", Offset = "0x2CA2F40", VA = "0x182CA3B40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3A60", Offset = "0x2CA2E60", VA = "0x182CA3A60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xEC9060", Offset = "0xEC8460", VA = "0x180EC9060", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly global::OODFGNEIEDH<BEOJEGMMGFC> COHMADBHONO;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly global::OODFGNEIEDH<List<JJJLMLOANEM>> CPDOFDFOMBF;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static int GGDEDGONGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	internal readonly Dictionary<TClaimant, TNode> PJKEPGJMDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	internal readonly Dictionary<TNode, BEOJEGMMGFC> ADAJEKMPEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private GDKANIKGDNJ FLAGJIBPLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private bool FCPODLMHINC;

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode NGLDHLBMECO(TNode PPCJAOBHBIP);

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void JBMODGIADKB(TNode PPCJAOBHBIP, TClaimant OAEIEJDGJHG, TClaimant FEBFEFJMAHB);

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0AE0", Offset = "0x3BEFEE0", VA = "0x183BF0AE0")]
	public JAPJGABBKJA(GDKANIKGDNJ FLAGJIBPLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x3BEFE00", Offset = "0x3BEF200", VA = "0x183BEFE00")]
	public void GGOPEBBCBPF(TNode PPCJAOBHBIP, TNode BJNIPOLNMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x3BEFF20", Offset = "0x3BEF320", VA = "0x183BEFF20")]
	public void HHGAIAHPLDB(TClaimant MMDGKGGDGMM, TNode KKCGOAAIEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x3BEFBA0", Offset = "0x3BEEFA0", VA = "0x183BEFBA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x3BEFE80", Offset = "0x3BEF280", VA = "0x183BEFE80")]
	private void GNMNAFGCBGK(TClaimant MMDGKGGDGMM, TNode KLHCLLOOKOK, TNode KKCGOAAIEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x3BF05E0", Offset = "0x3BEF9E0", VA = "0x183BF05E0")]
	private int KKMPAMHCLEC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x3BF06D0", Offset = "0x3BEFAD0", VA = "0x183BF06D0")]
	private void NGEONABLEAH(TClaimant MMDGKGGDGMM, TNode CKOPGNMJNCC, TNode NLBEDCCLIFO, int GIMFBOOEENP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0640", Offset = "0x3BEFA40", VA = "0x183BF0640")]
	private void LBNBIDKNALH(JJJLMLOANEM NPKJKPKBBEM, BEOJEGMMGFC MEMFIMDDIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0380", Offset = "0x3BEF780", VA = "0x183BF0380")]
	private void KKEPCGMBPLJ(TClaimant MMDGKGGDGMM, TNode CKOPGNMJNCC, TNode NLBEDCCLIFO, int GIMFBOOEENP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x3BEF810", Offset = "0x3BEEC10", VA = "0x183BEF810")]
	private void BDKEMOGIPIA(JJJLMLOANEM NPKJKPKBBEM, TNode PPCJAOBHBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0020", Offset = "0x3BEF420", VA = "0x183BF0020")]
	private void INKIPIENKGE(JJJLMLOANEM NPKJKPKBBEM, BEOJEGMMGFC MEMFIMDDIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x3BEF390", Offset = "0x3BEE790", VA = "0x183BEF390")]
	private void AOBOLNHMEHP(BEOJEGMMGFC MEMFIMDDIMD, bool GDHKAFNPJPB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x3BEF4A0", Offset = "0x3BEE8A0", VA = "0x183BEF4A0")]
	private void APLEKHBAIEH(BEOJEGMMGFC MEMFIMDDIMD, TNode BJNIPOLNMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x3BF02B0", Offset = "0x3BEF6B0", VA = "0x183BF02B0")]
	[IteratorStateMachine(typeof(global::JAPJGABBKJA<, >.OAAGNHMNOBB))]
	private IEnumerable<TNode> KGGEKPIHKJI(TNode CKOPGNMJNCC, TNode NLBEDCCLIFO, bool MBCCOHPEJLH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x3BEFAE0", Offset = "0x3BEEEE0", VA = "0x183BEFAE0")]
	private BEOJEGMMGFC DMLAKNPOEIK(TNode PPCJAOBHBIP, TNode GGEKFPEBLKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0120", Offset = "0x3BEF520", VA = "0x183BF0120")]
	private BEOJEGMMGFC JADCCKEPHHA(TNode PPCJAOBHBIP, TNode GGEKFPEBLKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x3BEF920", Offset = "0x3BEED20", VA = "0x183BEF920")]
	private void DAAIMFPEGLO(BEOJEGMMGFC MEMFIMDDIMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class HOJEFBPKHEA<T> : IEnumerable<global::HOJEFBPKHEA<T>.BDPFMFCEMKE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public struct BDPFMFCEMKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public T LPJDDLMPNCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int EGNHJGKABLC;
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class LNJHIFMIODE : IEnumerator<BDPFMFCEMKE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private global::HOJEFBPKHEA<T> MCHKFDMHGLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private int EGNHJGKABLC;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xEBE780", Offset = "0xEBDB80", VA = "0x180EBE780", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public BDPFMFCEMKE IFFLDLNKLFF
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x1F9DAD0", Offset = "0x1F9CED0", VA = "0x181F9DAD0", Slot = "4")]
			get
			{
				return default(BDPFMFCEMKE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xBF2750", Offset = "0xBF1B50", VA = "0x180BF2750")]
		public LNJHIFMIODE(global::HOJEFBPKHEA<T> MCHKFDMHGLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x1F9DA50", Offset = "0x1F9CE50", VA = "0x181F9DA50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xB04570", Offset = "0xB03970", VA = "0x180B04570", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xB0D7D0", Offset = "0xB0CBD0", VA = "0x180B0D7D0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private struct HAOBCOCMINL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public bool GEPNEKCKOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public T LPJDDLMPNCG;
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private const int JPMNDEMKBGP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly Dictionary<T, int> GLADMAHGIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private HAOBCOCMINL[] DDKGOFNLGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private int PEDPEJIJOPO;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public int ADGCJNJNCAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x735740", Offset = "0x734B40", VA = "0x180735740")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x869550", Offset = "0x868950", VA = "0x180869550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1621CA0", Offset = "0x16210A0", VA = "0x181621CA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x35AC810", Offset = "0x35ABC10", VA = "0x1835AC810")]
	public HOJEFBPKHEA(int IPADGNLNKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x35AC030", Offset = "0x35AB430", VA = "0x1835AC030")]
	public HOJEFBPKHEA(BDPFMFCEMKE[] HOCBAECCFMC, bool JGFAPJJFELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x35ABE80", Offset = "0x35AB280", VA = "0x1835ABE80")]
	public int MODIIHIEPKJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x35AB750", Offset = "0x35AAB50", VA = "0x1835AB750")]
	private int KOFEPMCLMEP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x35AB1F0", Offset = "0x35AA5F0", VA = "0x1835AB1F0", Slot = "6")]
	protected virtual uint JHAECAAOODP(uint IECKGMJMGEA, T LPJDDLMPNCG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x35AB980", Offset = "0x35AAD80", VA = "0x1835AB980")]
	public bool LLOEHOIILEI(T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x35AB210", Offset = "0x35AA610", VA = "0x1835AB210")]
	public bool JPBNDEJFNLB(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x35AB040", Offset = "0x35AA440", VA = "0x1835AB040")]
	public bool GMBMHDKFMPB(Func<T, bool> DGJHENDBKJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x35AACB0", Offset = "0x35AA0B0", VA = "0x1835AACB0")]
	public int DJHLMKBGKHN(T LPJDDLMPNCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x35ABF50", Offset = "0x35AB350", VA = "0x1835ABF50")]
	public T PKFLHEEHOPC(int EGNHJGKABLC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x35AAB90", Offset = "0x35A9F90", VA = "0x1835AAB90")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x35ABA40", Offset = "0x35AAE40", VA = "0x1835ABA40")]
	public bool MGFMFMIIKAH(T LPJDDLMPNCG, bool OLCLOOHNCFE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x35ABA80", Offset = "0x35AAE80", VA = "0x1835ABA80")]
	public bool MGFMFMIIKAH(T LPJDDLMPNCG, int EGNHJGKABLC, bool OLCLOOHNCFE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x35AAF30", Offset = "0x35AA330", VA = "0x1835AAF30")]
	public bool FJEBMLODAAK(T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x35AB9C0", Offset = "0x35AADC0", VA = "0x1835AB9C0")]
	public bool MDGCJLLGPHG(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x35AAE40", Offset = "0x35AA240", VA = "0x1835AAE40")]
	private void EKPADMIHGAE(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x35AB2B0", Offset = "0x35AA6B0", VA = "0x1835AB2B0")]
	public BDPFMFCEMKE[] JPMGPEBODFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x35AAC10", Offset = "0x35AA010", VA = "0x1835AAC10")]
	private int CEFBNJJOPDA(int OKIEINKEHAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x35ABFB0", Offset = "0x35AB3B0", VA = "0x1835ABFB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x35ABFB0", Offset = "0x35AB3B0", VA = "0x1835ABFB0", Slot = "4")]
	private IEnumerator<BDPFMFCEMKE> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct NIEDBBGIPJP<Handle> where Handle : AHPPOODHHGC, new()
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct BGCAMPLDGIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly global::NIEDBBGIPJP<Handle> BOKJKCIHGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int EGNHJGKABLC;

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public int ACBICPOGOIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x223D790", Offset = "0x223CB90", VA = "0x18223D790")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Handle BDFHJONIMHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x223DC60", Offset = "0x223D060", VA = "0x18223DC60")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x223E640", Offset = "0x223DA40", VA = "0x18223E640")]
		public BGCAMPLDGIG(global::NIEDBBGIPJP<Handle> BOKJKCIHGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x223DA30", Offset = "0x223CE30", VA = "0x18223DA30")]
		public BBJHGJLHICD GILBACJLDCL(in BBJHGJLHICD PJEHHDIBMKL)
		{
			return default(BBJHGJLHICD);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x223D990", Offset = "0x223CD90", VA = "0x18223D990")]
		public FJHGIMHGDEG GILBACJLDCL(in FJHGIMHGDEG PJEHHDIBMKL)
		{
			return default(FJHGIMHGDEG);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x223E1A0", Offset = "0x223D5A0", VA = "0x18223E1A0")]
		public bool MPMANKAPNAG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x223D450", Offset = "0x223C850", VA = "0x18223D450")]
		private int DIOLINFMKBD(string BALNMHDNCIN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x223E550", Offset = "0x223D950", VA = "0x18223E550")]
		private Handle OOGMKADPLOB(string BALNMHDNCIN)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public struct BBJHGJLHICD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private BGCAMPLDGIG PJEHMLPMGAH;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public int IFFLDLNKLFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x22355D0", Offset = "0x22349D0", VA = "0x1822355D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x2235810", Offset = "0x2234C10", VA = "0x182235810")]
		public BBJHGJLHICD(global::NIEDBBGIPJP<Handle> BOKJKCIHGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x2235750", Offset = "0x2234B50", VA = "0x182235750")]
		public bool MPMANKAPNAG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x2235790", Offset = "0x2234B90", VA = "0x182235790")]
		public BBJHGJLHICD OKFDNCHLPHK()
		{
			return default(BBJHGJLHICD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public struct FJHGIMHGDEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private BGCAMPLDGIG PJEHMLPMGAH;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public Handle IFFLDLNKLFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x2B02330", Offset = "0x2B01730", VA = "0x182B02330")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x2B025B0", Offset = "0x2B019B0", VA = "0x182B025B0")]
		public FJHGIMHGDEG(global::NIEDBBGIPJP<Handle> BOKJKCIHGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x2B024F0", Offset = "0x2B018F0", VA = "0x182B024F0")]
		public bool MPMANKAPNAG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x2B02530", Offset = "0x2B01930", VA = "0x182B02530")]
		public FJHGIMHGDEG OKFDNCHLPHK()
		{
			return default(FJHGIMHGDEG);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private NativeList<int> PKACHFEFBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private NativeList<int> FBPPPJIBJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int HDBCKDBFFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int ECFMPMIOPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private bool EEIFLGPCHBN;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool JKIEOPECNID
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x754680", Offset = "0x753A80", VA = "0x180754680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public int CMKLLLCOEGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x349CA90", Offset = "0x349BE90", VA = "0x18349CA90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public int HMIKANFANFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x735750", Offset = "0x734B50", VA = "0x180735750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public int BMHJLICEFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x735750", Offset = "0x734B50", VA = "0x180735750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public BBJHGJLHICD NINCONHJHBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x349C4B0", Offset = "0x349B8B0", VA = "0x18349C4B0")]
		get
		{
			return default(BBJHGJLHICD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public FJHGIMHGDEG HCNNFIDBFBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x3499670", Offset = "0x3498A70", VA = "0x183499670")]
		get
		{
			return default(FJHGIMHGDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x349D030", Offset = "0x349C430", VA = "0x18349D030")]
	public NIEDBBGIPJP(int BDGJGFLHFOF, Allocator FKHAEPDPDAI = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x34994F0", Offset = "0x34988F0", VA = "0x1834994F0")]
	public void BINPACHFFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x1C900D0", Offset = "0x1C8F4D0", VA = "0x181C900D0")]
	public static int LBLHAGKICIN(int CMBMGCLLFDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x349CB10", Offset = "0x349BF10", VA = "0x18349CB10")]
	public static bool NCHIJBFLCOC(int CMBMGCLLFDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x349CDE0", Offset = "0x349C1E0", VA = "0x18349CDE0")]
	public static bool PDIKKJJKIMI(int CMBMGCLLFDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x3498930", Offset = "0x3497D30", VA = "0x183498930")]
	public bool AAIFPCKMBEE(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x349C0D0", Offset = "0x349B4D0", VA = "0x18349C0D0")]
	public bool INKBBHGAAIA(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x349C550", Offset = "0x349B950", VA = "0x18349C550")]
	public bool KFBJKDBJGLL(Handle IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x349B110", Offset = "0x349A510", VA = "0x18349B110")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void IDFGEFJIKON(Handle IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x349BA30", Offset = "0x349AE30", VA = "0x18349BA30")]
	public Handle IHPEELINPGO()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x3499E60", Offset = "0x3499260", VA = "0x183499E60")]
	public void GCLCIABIBHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x349A810", Offset = "0x3499C10", VA = "0x18349A810")]
	public void GHBCJIMAKBA(Handle IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x349C400", Offset = "0x349B800", VA = "0x18349C400")]
	public bool JAADMNDGODC(Handle IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x754680", Offset = "0x753A80", VA = "0x180754680")]
	private bool KDGHPOCFIGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x349CC60", Offset = "0x349C060", VA = "0x18349CC60")]
	private bool OHOCDCAJBPC(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x3498F20", Offset = "0x3498320", VA = "0x183498F20")]
	private void AKIGCKMEABO(out int EGNHJGKABLC, out int NHBDMCDLELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x349ACF0", Offset = "0x349A0F0", VA = "0x18349ACF0")]
	private void GKBLOBKDEAK(Handle IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x349CC10", Offset = "0x349C010", VA = "0x18349CC10")]
	private void OGKJJBOALPO(int EGNHJGKABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x3499710", Offset = "0x3498B10", VA = "0x183499710")]
	private bool EOLIAIDEBJC(out int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x34999D0", Offset = "0x3498DD0", VA = "0x1834999D0")]
	private static Handle FJCFCPMJCKI(int EGNHJGKABLC, int NHBDMCDLELK)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[DefaultMember("Item")]
public struct EAJFHNJEBAG<Handle, T> where Handle : AHPPOODHHGC, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private global::NIEDBBGIPJP<Handle> LFBENPHALMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private T[] EFPDIALOKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Action<T> MBEGLEKHBGP;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public bool JKIEOPECNID
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x34201D0", Offset = "0x341F5D0", VA = "0x1834201D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public int CMKLLLCOEGO
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x35245E0", Offset = "0x35239E0", VA = "0x1835245E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x34207F0", Offset = "0x341FBF0", VA = "0x1834207F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public T JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x35231E0", Offset = "0x35225E0", VA = "0x1835231E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3524E20", Offset = "0x3524220", VA = "0x183524E20")]
	public EAJFHNJEBAG(int BDGJGFLHFOF, [Optional] Action<T> MBEGLEKHBGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x3523030", Offset = "0x3522430", VA = "0x183523030")]
	public void BINPACHFFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3523FC0", Offset = "0x35233C0", VA = "0x183523FC0")]
	public bool KFBJKDBJGLL(Handle IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void IDFGEFJIKON(Handle IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x35245A0", Offset = "0x35239A0", VA = "0x1835245A0")]
	public T MKLBNKEKMJE(Handle IGELLPOEMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x3524D70", Offset = "0x3524170", VA = "0x183524D70")]
	public bool OBCGBBDEENH(Handle IGELLPOEMHM, out T NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x3523240", Offset = "0x3522640", VA = "0x183523240")]
	public void EFMALMFMJGL(Handle IGELLPOEMHM, T DAIAHPILHFA, out T CDNDKPKKBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x35232E0", Offset = "0x35226E0", VA = "0x1835232E0")]
	public void EFMALMFMJGL(Handle IGELLPOEMHM, T DAIAHPILHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x3524B20", Offset = "0x3523F20", VA = "0x183524B20")]
	public bool NFPBPFFPICN(Handle IGELLPOEMHM, T DAIAHPILHFA, out T CDNDKPKKBND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x3524870", Offset = "0x3523C70", VA = "0x183524870")]
	public bool NFPBPFFPICN(Handle IGELLPOEMHM, T DAIAHPILHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3522D30", Offset = "0x3522130", VA = "0x183522D30")]
	public Handle AGMLDLCGDGN(T NBNOMDAKOCG)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x35238E0", Offset = "0x3522CE0", VA = "0x1835238E0")]
	public void JCDEBDNJNNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x3523400", Offset = "0x3522800", VA = "0x183523400")]
	public void FJEBMLODAAK(Handle IGELLPOEMHM, out T CDNDKPKKBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x3523810", Offset = "0x3522C10", VA = "0x183523810")]
	public void FJEBMLODAAK(Handle IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x3524220", Offset = "0x3523620", VA = "0x183524220")]
	public bool KLEOIKLJCKJ(Handle IGELLPOEMHM, out T CDNDKPKKBND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x3524300", Offset = "0x3523700", VA = "0x183524300")]
	public bool KLEOIKLJCKJ(Handle IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x3420CA0", Offset = "0x34200A0", VA = "0x183420CA0")]
	private T MDGCJLLGPHG(int EGNHJGKABLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x3420720", Offset = "0x341FB20", VA = "0x183420720")]
	private void GOMLPJNLOAO(int HELIDNDMHAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class OODFGNEIEDH<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly Stack<T> BOKJKCIHGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly List<T> LOEKJFHKIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly int GAGIKJGINNA;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public int LCCFEGJHMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x2420290", Offset = "0x241F690", VA = "0x182420290")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int GJKPGCJKOGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x1621C40", Offset = "0x1621040", VA = "0x181621C40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x4940C60", Offset = "0x4940060", VA = "0x184940C60")]
	public static global::OODFGNEIEDH<T> CDIIKPFBGNN(int IPADGNLNKOB = 0, int GAGIKJGINNA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x4941140", Offset = "0x4940540", VA = "0x184941140")]
	public static global::OODFGNEIEDH<T> KFHHEJEBPGC(int IPADGNLNKOB = 0, int GAGIKJGINNA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x49415E0", Offset = "0x49409E0", VA = "0x1849415E0")]
	public OODFGNEIEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x4941450", Offset = "0x4940850", VA = "0x184941450")]
	public OODFGNEIEDH(int IPADGNLNKOB, int GAGIKJGINNA = int.MaxValue, bool AOAADCDIBPL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x4941210", Offset = "0x4940610", VA = "0x184941210")]
	public T LFLLANPBDJN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x4940D30", Offset = "0x4940130", VA = "0x184940D30")]
	public void CKAJENPILHN(T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x4941070", Offset = "0x4940470", VA = "0x184941070")]
	private void JMCEPDIHJKF(T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x4941320", Offset = "0x4940720", VA = "0x184941320")]
	private void LGFCLICDNHD(T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x49413D0", Offset = "0x49407D0", VA = "0x1849413D0")]
	[Conditional("DEBUG_BUILD")]
	private void PJAKBCOPHPF(T BMLPBIDECCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x4941340", Offset = "0x4940740", VA = "0x184941340")]
	[Conditional("DEBUG_BUILD")]
	private void OAGDAEOOEJP(T BMLPBIDECCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x4940F80", Offset = "0x4940380", VA = "0x184940F80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x4940DE0", Offset = "0x49401E0", VA = "0x184940DE0")]
	private void DEBHNHAGBOA(IEnumerable<T> FMHMDECCGKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class ENGECGGMOFE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private Dictionary<int, T> GDCEFHMGFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private T AAFFHJEIOFO;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public virtual T KECOEMHKDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x734AF0", Offset = "0x733EF0", VA = "0x180734AF0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public bool HDDGJFGBFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x3A6D480", Offset = "0x3A6C880", VA = "0x183A6D480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D3F0", Offset = "0x3A6C7F0", VA = "0x183A6D3F0")]
	public bool CJNLKFPNHDF(T LPJDDLMPNCG, int EICBOGNBLMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x26E37F0", Offset = "0x26E2BF0", VA = "0x1826E37F0")]
	public bool PBFPIEEMKFJ(int EICBOGNBLMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D660", Offset = "0x3A6CA60", VA = "0x183A6D660")]
	public T LHBCDDFCHFA(int LOLNKMMBLLF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D330", Offset = "0x3A6C730", VA = "0x183A6D330")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D5D0", Offset = "0x3A6C9D0", VA = "0x183A6D5D0")]
	private bool KBFDGGDEHPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D450", Offset = "0x3A6C850", VA = "0x183A6D450")]
	public bool DJKANKJNGBD(int EICBOGNBLMD, out T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x26E3870", Offset = "0x26E2C70", VA = "0x1826E3870")]
	public ENGECGGMOFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class GDIPENFMNMN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	protected struct NGHGKLCLODN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public T NDNOLKCBONM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int LEEDLNNOGGM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	protected readonly List<NGHGKLCLODN> EBPHBCJGGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private T HKEGKLCJMLD;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x1621CA0", Offset = "0x16210A0", VA = "0x181621CA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x310EBE0", Offset = "0x310DFE0", VA = "0x18310EBE0")]
	public bool GMBMHDKFMPB(T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x310E790", Offset = "0x310DB90", VA = "0x18310E790")]
	public void AGMLDLCGDGN(T LPJDDLMPNCG, int EICBOGNBLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x310EA50", Offset = "0x310DE50", VA = "0x18310EA50")]
	public bool FJEBMLODAAK(T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x310E830", Offset = "0x310DC30", VA = "0x18310E830")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x310EDF0", Offset = "0x310E1F0", VA = "0x18310EDF0")]
	public T PBEJFEKOPPK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x310EB70", Offset = "0x310DF70", VA = "0x18310EB70")]
	public T GDAHFDDJKFE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x310E890", Offset = "0x310DC90", VA = "0x18310E890")]
	private void ECGNDEMLKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x310EE60", Offset = "0x310E260", VA = "0x18310EE60")]
	public GDIPENFMNMN()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		[EPAJBOKMDOH(DIMAPHHKBON.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x694CCF0", Offset = "0x694C0F0", VA = "0x18694CCF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x694D080", Offset = "0x694C480", VA = "0x18694D080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x694CF00", Offset = "0x694C300", VA = "0x18694CF00")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x694D1E0", Offset = "0x694C5E0", VA = "0x18694D1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x694CC10", Offset = "0x694C010", VA = "0x18694CC10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x694CFA0", Offset = "0x694C3A0", VA = "0x18694CFA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x694CE20", Offset = "0x694C220", VA = "0x18694CE20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x694CBC0", Offset = "0x694BFC0", VA = "0x18694CBC0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public interface PDKDBOAFBMH
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public abstract class ResourcePrefabReference<T> : PDKDBOAFBMH where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x39B30D0", Offset = "0x39B24D0", VA = "0x1839B30D0", Slot = "4")]
		public virtual T NOCJKNIDPIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class LHLIEMELEHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly Dictionary<byte, LBIHILHOPGL> LHLJLNFPJLD;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public LBIHILHOPGL MGNMJGAEMKD
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x734AE0", Offset = "0x733EE0", VA = "0x180734AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Vector2 JMGPMPHJOGH
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x13DB010", Offset = "0x13DA410", VA = "0x1813DB010")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x982120", Offset = "0x981520", VA = "0x180982120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Vector2 DKKFMDKFKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x26EA400", Offset = "0x26E9800", VA = "0x1826EA400")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x982130", Offset = "0x981530", VA = "0x180982130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Vector2 HEIJGPAFEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x694A100", Offset = "0x6949500", VA = "0x18694A100")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xCCB550", Offset = "0xCCA950", VA = "0x180CCB550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public int POGCHBNGDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x7677A0", Offset = "0x766BA0", VA = "0x1807677A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x785A50", Offset = "0x784E50", VA = "0x180785A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x694A120", Offset = "0x6949520", VA = "0x18694A120")]
	public LHLIEMELEHI(Bounds DLPPBBKJMPH, Vector2[] CFOOBGPFDEP, int OBKOADPICBG, byte OKIEINKEHAF, float BCJIJMMDNFE = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x6949A20", Offset = "0x6948E20", VA = "0x186949A20")]
	public LBIHILHOPGL FBBBNGDFPIM(byte EGNHJGKABLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x6949AA0", Offset = "0x6948EA0", VA = "0x186949AA0")]
	public void IOGDPIDBNFA(Vector3 PICDPPHNNLH, float AKCCEHCICDG, float FKCINMBFAOG, ref List<byte> DCJMPJONGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x6949A80", Offset = "0x6948E80", VA = "0x186949A80")]
	public void GACDPKONDLB(LBIHILHOPGL.IGAGAPJNCAI FBIMJMKHBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6949BA0", Offset = "0x6948FA0", VA = "0x186949BA0")]
	private LBIHILHOPGL LDKGKBMNJFB(byte EGNHJGKABLC, LBIHILHOPGL.IHOHJOIMAMA DFECGGPGPML, LBIHILHOPGL GGEKFPEBLKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x6949D00", Offset = "0x6949100", VA = "0x186949D00")]
	private void MCAKEAPBFHL(LBIHILHOPGL GGEKFPEBLKN, Vector2[] CFOOBGPFDEP, int EDDCINKFBNB, int BBHANNFFBLH, int MONGMPNHILE, int FLGIPDEIHLC, float BCJIJMMDNFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public class LBIHILHOPGL
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public enum IHOHJOIMAMA
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public enum IGAGAPJNCAI
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public byte IKLMOKJELML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public Vector3 EJKEKPKBIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public Vector3 MDFKAKBJDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public Vector3 IKNDNHOALNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public Vector3 BPKHIFDFMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public IHOHJOIMAMA LBMOIGKAHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public LBIHILHOPGL GKEMABFNEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public List<LBIHILHOPGL> IOKLKPKOPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public bool NKLAFMJBLJK;

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x6949A00", Offset = "0x6948E00", VA = "0x186949A00")]
	public LBIHILHOPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x69499A0", Offset = "0x6948DA0", VA = "0x1869499A0")]
	public LBIHILHOPGL(byte PKNOIGMENLD, IHOHJOIMAMA DFECGGPGPML, LBIHILHOPGL GGEKFPEBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x69498A0", Offset = "0x6948CA0", VA = "0x1869498A0")]
	public void LBIPGKKJCGE(LBIHILHOPGL ILLPMKANGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	public void GACDPKONDLB(int EAAOOHDIPBF, IGAGAPJNCAI FBIMJMKHBJL, int JOAKCNLGLDG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x69495F0", Offset = "0x69489F0", VA = "0x1869495F0")]
	public void IOGDPIDBNFA(List<byte> DCJMPJONGLP, Vector3 PICDPPHNNLH, float AKCCEHCICDG, float FKCINMBFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x69495A0", Offset = "0x69489A0", VA = "0x1869495A0")]
	public bool FHNHBLLAIBE(Vector3 JDJHGHDNLLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x6949960", Offset = "0x6948D60", VA = "0x186949960")]
	public bool NKBNJGCCGDG(Vector3 JDJHGHDNLLP, float AJKNDAGEMJN)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public struct DAAONKLOOAD<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			private readonly List<Component> BDHPAGCMKHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			private readonly bool IOBFEBPFGHD;

			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0xAB9F10", Offset = "0xAB9310", VA = "0x180AB9F10")]
			public DAAONKLOOAD(List<Component> BDHPAGCMKHB, bool IOBFEBPFGHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x2990120", Offset = "0x298F520", VA = "0x182990120")]
			public GAFBJNJAGIJ<T> OKFDNCHLPHK()
			{
				return default(GAFBJNJAGIJ<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x2990190", Offset = "0x298F590", VA = "0x182990190", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x2990190", Offset = "0x298F590", VA = "0x182990190", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		public struct GAFBJNJAGIJ<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			private readonly List<Component> BDHPAGCMKHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			private readonly bool IOBFEBPFGHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			private int EGNHJGKABLC;

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public T IFFLDLNKLFF
			{
				[Cpp2IlInjected.Token(Token = "0x6000389")]
				[Cpp2IlInjected.Address(RVA = "0x3103990", Offset = "0x3102D90", VA = "0x183103990", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600038A")]
				[Cpp2IlInjected.Address(RVA = "0x3103920", Offset = "0x3102D20", VA = "0x183103920", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x3103960", Offset = "0x3102D60", VA = "0x183103960")]
			public GAFBJNJAGIJ(List<Component> BDHPAGCMKHB, bool IOBFEBPFGHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x3103860", Offset = "0x3102C60", VA = "0x183103860", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x3103870", Offset = "0x3102C70", VA = "0x183103870", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x162DEE0", Offset = "0x162D2E0", VA = "0x18162DEE0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x694EEB0", Offset = "0x694E2B0", VA = "0x18694EEB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x694EE70", Offset = "0x694E270", VA = "0x18694EE70")]
		public ToolHierarchyCache(GameObject JNONJGMFMNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x694EBF0", Offset = "0x694DFF0", VA = "0x18694EBF0")]
		private void KADCCJJCHBP(GameObject JNONJGMFMNE, bool HKPPDHFDHMN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x694ED50", Offset = "0x694E150", VA = "0x18694ED50")]
		public static void KADCCJJCHBP(GameObject JNONJGMFMNE, ref ToolHierarchyCache PGFLNEHBIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x694EDE0", Offset = "0x694E1E0", VA = "0x18694EDE0")]
		public void KFAMBFAIBIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x694E600", Offset = "0x694DA00", VA = "0x18694E600")]
		public void AOOOKAEDLJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x302EAF0", Offset = "0x302DEF0", VA = "0x18302EAF0")]
		public void IOMAAOJKNNO<T>(Action<T> DAAMKALKLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x694EAA0", Offset = "0x694DEA0", VA = "0x18694EAA0")]
		public Component GPJOBHGAGDA(Type OGILDIMGIOH, bool IOBFEBPFGHD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x302EA70", Offset = "0x302DE70", VA = "0x18302EA70")]
		public T GPJOBHGAGDA<T>(bool IOBFEBPFGHD = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x694E650", Offset = "0x694DA50", VA = "0x18694E650")]
		public DAAONKLOOAD<Component> BCDCHCCCEEE(Type OGILDIMGIOH, bool IOBFEBPFGHD = false)
		{
			return default(DAAONKLOOAD<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x302E9A0", Offset = "0x302DDA0", VA = "0x18302E9A0")]
		public DAAONKLOOAD<T> BCDCHCCCEEE<T>(bool IOBFEBPFGHD = false) where T : class
		{
			return default(DAAONKLOOAD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x694E6D0", Offset = "0x694DAD0", VA = "0x18694E6D0")]
		public List<Component> BGHPNJHPAKO(Type OGILDIMGIOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x694EA20", Offset = "0x694DE20", VA = "0x18694EA20", Slot = "4")]
		public bool Equals(ToolHierarchyCache GKBCEINHOJB, ToolHierarchyCache LAMHEDHCIJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x694EB70", Offset = "0x694DF70", VA = "0x18694EB70", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache NBNOMDAKOCG)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class JPIOPBBDNGF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private int IPADGNLNKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private int PAOMNFIMCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private List<T> BNJGAHEFJPB;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2420290", Offset = "0x241F690", VA = "0x182420290")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public T BPAJEMADNLI
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF3F0", Offset = "0x2CDE7F0", VA = "0x182CDF3F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public T JMDNCGBCLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF5B0", Offset = "0x2CDE9B0", VA = "0x182CDF5B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public T NKCBDKJFNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF610", Offset = "0x2CDEA10", VA = "0x182CDF610")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF710", Offset = "0x2CDEB10", VA = "0x182CDF710")]
	public JPIOPBBDNGF(int IPADGNLNKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF1C0", Offset = "0x2CDE5C0", VA = "0x182CDF1C0")]
	public void AGMLDLCGDGN(T IHKDONGFEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF480", Offset = "0x2CDE880", VA = "0x182CDF480")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF4D0", Offset = "0x2CDE8D0", VA = "0x182CDF4D0")]
	public void FABABNJCNNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF6C0", Offset = "0x2CDEAC0", VA = "0x182CDF6C0")]
	public void OFLNFFKCDIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF4C0", Offset = "0x2CDE8C0", VA = "0x182CDF4C0")]
	public void CMJFFMGMJNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class JCEIOCIGDAC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private bool BNNPMDCDNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private Action DAAMKALKLMO;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public static JCEIOCIGDAC BKJPPNEGDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6948C00", Offset = "0x6948000", VA = "0x186948C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool FOBJJPHHEOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7B1910", Offset = "0x7B0D10", VA = "0x1807B1910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0xB0D730", Offset = "0xB0CB30", VA = "0x180B0D730")]
	public JCEIOCIGDAC(Action DAAMKALKLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x6948C80", Offset = "0x6948080", VA = "0x186948C80")]
	public void JHOFICMAMCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x6948C80", Offset = "0x6948080", VA = "0x186948C80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public static class NBIPOKCIHAA
{
	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x694A580", Offset = "0x6949980", VA = "0x18694A580")]
	public static void AEDJCPNNHPB(BHECNCBBLMC PIALGNLFEHH, string NKBPDLOGGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	public static void AEDJCPNNHPB(IEnumerable<object> EFOCNJAEIPA, string NKBPDLOGGPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class KDKEPPIAPOA<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private struct PIHIPBNECMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int LEEDLNNOGGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public T NDNOLKCBONM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private readonly Dictionary<object, PIHIPBNECMF> GDCEFHMGFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly EqualityComparer<T> JNIIMGFPAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private T AAFFHJEIOFO;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public virtual T KECOEMHKDHF
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xB04540", Offset = "0xB03940", VA = "0x180B04540", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x2557510", Offset = "0x2556910", VA = "0x182557510", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool HDDGJFGBFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x2A90350", Offset = "0x2A8F750", VA = "0x182A90350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public object MDKCBBAIAEA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x72A400", VA = "0x18072B000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7B1930", Offset = "0x7B0D30", VA = "0x1807B1930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FCC0", Offset = "0x2A8F0C0", VA = "0x182A8FCC0")]
	public bool CJNLKFPNHDF(T LPJDDLMPNCG, object MIFCLBEAOPM, int EICBOGNBLMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x2A92620", Offset = "0x2A91A20", VA = "0x182A92620")]
	public bool PBFPIEEMKFJ(object MIFCLBEAOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x3131AD0", Offset = "0x3130ED0", VA = "0x183131AD0")]
	public bool DJKANKJNGBD(object MIFCLBEAOPM, out T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x2508350", Offset = "0x2507750", VA = "0x182508350")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x3133780", Offset = "0x3132B80", VA = "0x183133780")]
	private bool KBFDGGDEHPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x2A92690", Offset = "0x2A91A90", VA = "0x182A92690")]
	public KDKEPPIAPOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public class FGFCKLFBJIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public readonly string IHKDKNCFIDD;

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x756370", Offset = "0x755770", VA = "0x180756370")]
	public FGFCKLFBJIP(string IAHKIHLNCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6947E00", Offset = "0x6947200", VA = "0x186947E00")]
	public FGFCKLFBJIP(UnityEngine.Object FBAGKFPKONN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6947DB0", Offset = "0x69471B0", VA = "0x186947DB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6949130", Offset = "0x6948530", VA = "0x186949130")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x6948DE0", Offset = "0x69481E0", VA = "0x186948DE0")]
	public static string GLIIACIKPKK(byte[] EMIAMELGKNF, bool LLPOIDPCGKE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
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
