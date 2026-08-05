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
public class EAIJEGFABOK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0")]
	public EAIJEGFABOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, LCOBBBOEKKP, MJLFMLIJBDB, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x697540", VA = "0x180698140", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x679130", Offset = "0x678530", VA = "0x180679130", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x775500", Offset = "0x774900", VA = "0x180775500", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash BMNGMMBLJFF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xEE1590", Offset = "0xEE0990", VA = "0x180EE1590")]
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
	[OOPNHPOANBP]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[OOPNHPOANBP]
	[SerializeField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F72040", Offset = "0x5F71440", VA = "0x185F72040")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F72000", Offset = "0x5F71400", VA = "0x185F72000")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5F72080", Offset = "0x5F71480", VA = "0x185F72080")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5F72250", Offset = "0x5F71650", VA = "0x185F72250")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5F721C0", Offset = "0x5F715C0", VA = "0x185F721C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1030690", Offset = "0x102FA90", VA = "0x181030690")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1030680", Offset = "0x102FA80", VA = "0x181030680")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5F71FC0", Offset = "0x5F713C0", VA = "0x185F71FC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5F72130", Offset = "0x5F71530", VA = "0x185F72130")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5F71A00", Offset = "0x5F70E00", VA = "0x185F71A00")]
	public void CopyBounds(SavedExtents EPJIAIAEMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5F71F20", Offset = "0x5F71320", VA = "0x185F71F20")]
	public void SetLocalSpaceBounds(Bounds KOCEJALFNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x11F9A30", Offset = "0x11F8E30", VA = "0x1811F9A30")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5F71F10", Offset = "0x5F71310", VA = "0x185F71F10")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5F71A30", Offset = "0x5F70E30", VA = "0x185F71A30")]
	private void FOPHGAPLALN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5F71CE0", Offset = "0x5F710E0", VA = "0x185F71CE0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5F713C0", Offset = "0x5F707C0", VA = "0x185F713C0")]
	public static void CalculateLocalBoundsFor(GameObject FLFBOHHHJJB, out Bounds KOCEJALFNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5F71C20", Offset = "0x5F71020", VA = "0x185F71C20")]
	private static void KBDBIHKDJKP(Bounds IKDBBHHKFLJ, Color LAPNDBKJOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5F71F40", Offset = "0x5F71340", VA = "0x185F71F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677440", VA = "0x180678040")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x698F30", Offset = "0x698330", VA = "0x180698F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x126EDA0", Offset = "0x126E1A0", VA = "0x18126EDA0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAEA750", Offset = "0xAE9B50", VA = "0x180AEA750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "4")]
	public virtual void ODLHLJOCOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
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
	[EAIJEGFABOK]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2BDF8F0", Offset = "0x2BDECF0", VA = "0x182BDF8F0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2BDF020", Offset = "0x2BDE420", VA = "0x182BDF020", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2BDFE30", Offset = "0x2BDF230", VA = "0x182BDFE30")]
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
	private sealed class IHIPKBOJNEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public IHIPKBOJNEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1BB1620", Offset = "0x1BB0A20", VA = "0x181BB1620")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[EAIJEGFABOK]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1110190", Offset = "0x110F590", VA = "0x181110190", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x11101C0", Offset = "0x110F5C0", VA = "0x1811101C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x11100E0", Offset = "0x110F4E0", VA = "0x1811100E0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey FOJIGKKHICE]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1110110", Offset = "0x110F510", VA = "0x181110110", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x110FFE0", Offset = "0x110F3E0", VA = "0x18110FFE0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x110F960", Offset = "0x110ED60", VA = "0x18110F960", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x110F030", Offset = "0x110E430", VA = "0x18110F030", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x110EFD0", Offset = "0x110E3D0", VA = "0x18110EFD0", Slot = "14")]
	protected virtual string JCJMHOLFKDF(TKeyVal JJIKHMNBEBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x110EEE0", Offset = "0x110E2E0", VA = "0x18110EEE0", Slot = "4")]
	public bool ContainsKey(TKey FOJIGKKHICE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x110FED0", Offset = "0x110F2D0", VA = "0x18110FED0", Slot = "5")]
	public bool TryGetValue(TKey FOJIGKKHICE, out TVal IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x110EF10", Offset = "0x110E310", VA = "0x18110EF10", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x110EF10", Offset = "0x110E310", VA = "0x18110EF10", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x110FF00", Offset = "0x110F300", VA = "0x18110FF00")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class KEAPOKBIODH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DBILDGCOEOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public DBILDGCOEOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x27F0BF0", Offset = "0x27EFFF0", VA = "0x1827F0BF0")]
		internal bool <GetSamples>b__0(global::NGHPEIAIIKD<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float POEEDLBLKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float KFPJGKNDALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::NGHPEIAIIKD<float, T>> NKBDAGGOBBA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int GNPHHEIAJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x33842A0", Offset = "0x33836A0", VA = "0x1833842A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3384E00", Offset = "0x3384200", VA = "0x183384E00")]
	public KEAPOKBIODH(float EDBGIJJOKCC, float BNJIDADKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x33844C0", Offset = "0x33838C0", VA = "0x1833844C0")]
	public bool HKAINPLBNCD(float PMEEKMNFEBL, T IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x33843A0", Offset = "0x33837A0", VA = "0x1833843A0")]
	public int GDGKNJABAFJ(float PMEEKMNFEBL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3384780", Offset = "0x3383B80", VA = "0x183384780")]
	public IEnumerable<T> OLIDEBDCCPF(float PMEEKMNFEBL, [Optional] float? PMOOCJELDMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3384270", Offset = "0x3383670", VA = "0x183384270")]
	public void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3384400", Offset = "0x3383800", VA = "0x183384400")]
	private void GKMNBNOPBGH(float PMEEKMNFEBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class ELCNKHPIBEH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct CJGGNPCCKIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T KGOGAJOHGBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float KAGEDLIDCJL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float DMGHDPMOPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> LHJOBPDIHJA;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int PCPIEEFOFEL = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private CJGGNPCCKIH[] ICPECNGAFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int NJJPMOPBLOG;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float AFNFIBNNFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xEAC480", Offset = "0xEAB880", VA = "0x180EAC480")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xEAC490", Offset = "0xEAB890", VA = "0x180EAC490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2447AE0", Offset = "0x2446EE0", VA = "0x182447AE0")]
	public ELCNKHPIBEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2447B10", Offset = "0x2446F10", VA = "0x182447B10")]
	public ELCNKHPIBEH(int DEBAMGFBJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x24467D0", Offset = "0x2445BD0", VA = "0x1824467D0")]
	public void AKBMAMDKLNI(float PMEEKMNFEBL, T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2446B50", Offset = "0x2445F50", VA = "0x182446B50")]
	public void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2447500", Offset = "0x2446900", VA = "0x182447500")]
	public bool NNIPLLINMEG(float KEAGJKMPOBK, float NLJGIEPNDCD, out T IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2446FE0", Offset = "0x24463E0", VA = "0x182446FE0")]
	public bool DNIPGKIHLPB(float KEAGJKMPOBK, float NLJGIEPNDCD, out T IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x24472D0", Offset = "0x24466D0", VA = "0x1824472D0")]
	public void MJGDBDBKFFK(float KEAGJKMPOBK, float NLJGIEPNDCD, List<T> CCBBJEPJPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2446CA0", Offset = "0x24460A0", VA = "0x182446CA0")]
	private int CBDKHMGNPIC(int KFCONOKJLHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2447150", Offset = "0x2446550", VA = "0x182447150")]
	private void HPFGLEIGJJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T DKFGCMOPEOF();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T MHOLJNOIKPD(T LBABLKMFGKM, T MGCAIGBBIIM, float BJKDLBIJMNC);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T PEOCLGMJNLO(T IGDJJEECDAF, float BJKDLBIJMNC);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T BPMNFEJJPHA(T LBABLKMFGKM, T MGCAIGBBIIM);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T ENFBCNJPLIF(T LBABLKMFGKM, T MGCAIGBBIIM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OGHNABABGKB : global::ELCNKHPIBEH<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1421F80", Offset = "0x1421380", VA = "0x181421F80", Slot = "4")]
	protected override Vector3 DKFGCMOPEOF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xF840B0", Offset = "0xF834B0", VA = "0x180F840B0", Slot = "5")]
	protected override Vector3 MHOLJNOIKPD(Vector3 LBABLKMFGKM, Vector3 MGCAIGBBIIM, float BJKDLBIJMNC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5F704B0", Offset = "0x5F6F8B0", VA = "0x185F704B0", Slot = "6")]
	protected override Vector3 PEOCLGMJNLO(Vector3 IGDJJEECDAF, float BJKDLBIJMNC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5F703C0", Offset = "0x5F6F7C0", VA = "0x185F703C0", Slot = "7")]
	protected override Vector3 BPMNFEJJPHA(Vector3 LBABLKMFGKM, Vector3 MGCAIGBBIIM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5F70440", Offset = "0x5F6F840", VA = "0x185F70440", Slot = "8")]
	protected override Vector3 ENFBCNJPLIF(Vector3 LBABLKMFGKM, Vector3 MGCAIGBBIIM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5F70510", Offset = "0x5F6F910", VA = "0x185F70510")]
	public OGHNABABGKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ELMNEFODKBO : global::ELCNKHPIBEH<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B520", Offset = "0x5F6A920", VA = "0x185F6B520")]
	public ELMNEFODKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B590", Offset = "0x5F6A990", VA = "0x185F6B590")]
	public ELMNEFODKBO(int DEBAMGFBJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xFFA5D0", Offset = "0xFF99D0", VA = "0x180FFA5D0", Slot = "4")]
	protected override float DKFGCMOPEOF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x37F7420", Offset = "0x37F6820", VA = "0x1837F7420", Slot = "5")]
	protected override float MHOLJNOIKPD(float LBABLKMFGKM, float MGCAIGBBIIM, float BJKDLBIJMNC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x50C9BE0", Offset = "0x50C8FE0", VA = "0x1850C9BE0", Slot = "6")]
	protected override float PEOCLGMJNLO(float IGDJJEECDAF, float BJKDLBIJMNC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2B3DFF0", Offset = "0x2B3D3F0", VA = "0x182B3DFF0", Slot = "7")]
	protected override float BPMNFEJJPHA(float LBABLKMFGKM, float MGCAIGBBIIM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B510", Offset = "0x5F6A910", VA = "0x185F6B510", Slot = "8")]
	protected override float ENFBCNJPLIF(float LBABLKMFGKM, float MGCAIGBBIIM)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class KODLLABDMOF
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1FC71C0", Offset = "0x1FC65C0", VA = "0x181FC71C0")]
	public static global::FPCKLBLFLDE<T1> FNICMNFMKAL<T1>(T1 IBEKMKEBFKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x25B63A0", Offset = "0x25B57A0", VA = "0x1825B63A0")]
	public static global::NGHPEIAIIKD<T1, T2> FNICMNFMKAL<T1, T2>(T1 IBEKMKEBFKD, T2 GHPDLBFNBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x25B6410", Offset = "0x25B5810", VA = "0x1825B6410")]
	public static global::NIKCPLHEHNF<T1, T2, T3> FNICMNFMKAL<T1, T2, T3>(T1 IBEKMKEBFKD, T2 GHPDLBFNBEB, T3 KGGAJFOCJAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1F82520", Offset = "0x1F81920", VA = "0x181F82520")]
	public static global::AMBJACAPLBH<T1, T2, T3, T4> FNICMNFMKAL<T1, T2, T3, T4>(T1 IBEKMKEBFKD, T2 GHPDLBFNBEB, T3 KGGAJFOCJAH, T4 NGDJFAMBENL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x25B66E0", Offset = "0x25B5AE0", VA = "0x1825B66E0")]
	public static global::NBNAPDHICBE<T1, T2, T3, T4, T5> FNICMNFMKAL<T1, T2, T3, T4, T5>(T1 IBEKMKEBFKD, T2 GHPDLBFNBEB, T3 KGGAJFOCJAH, T4 NGDJFAMBENL, T5 AIKAMBEAFLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x25B6630", Offset = "0x25B5A30", VA = "0x1825B6630")]
	public static global::BOIMIMLKFAO<T1, T2, T3, T4, T5, T6> FNICMNFMKAL<T1, T2, T3, T4, T5, T6>(T1 IBEKMKEBFKD, T2 GHPDLBFNBEB, T3 KGGAJFOCJAH, T4 NGDJFAMBENL, T5 AIKAMBEAFLM, T6 PCMICFEBNMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x25B6570", Offset = "0x25B5970", VA = "0x1825B6570")]
	public static global::CEEOIKPIDEG<T1, T2, T3, T4, T5, T6, T7> FNICMNFMKAL<T1, T2, T3, T4, T5, T6, T7>(T1 IBEKMKEBFKD, T2 GHPDLBFNBEB, T3 KGGAJFOCJAH, T4 NGDJFAMBENL, T5 AIKAMBEAFLM, T6 PCMICFEBNMJ, T7 NIADFPLHKEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x25B64A0", Offset = "0x25B58A0", VA = "0x1825B64A0")]
	public static global::FPNPNGEOPAI<T1, T2, T3, T4, T5, T6, T7, T8> FNICMNFMKAL<T1, T2, T3, T4, T5, T6, T7, T8>(T1 IBEKMKEBFKD, T2 GHPDLBFNBEB, T3 KGGAJFOCJAH, T4 NGDJFAMBENL, T5 AIKAMBEAFLM, T6 PCMICFEBNMJ, T7 NIADFPLHKEI, T8 IEOCNOJFGKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1D23530", Offset = "0x1D22930", VA = "0x181D23530")]
	[IteratorStateMachine(typeof(HNHEACJGFKH))]
	public static IEnumerable<global::NGHPEIAIIKD<T1, T2>> OFBJCMEEEIM<T1, T2>(IEnumerable<T1> GHJDMBPGMHF, IEnumerable<T2> IKDBBHHKFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1D23710", Offset = "0x1D22B10", VA = "0x181D23710")]
	[IteratorStateMachine(typeof(LALBJPHHDIF))]
	public static IEnumerable<global::NIKCPLHEHNF<T1, T2, T3>> OFBJCMEEEIM<T1, T2, T3>(IEnumerable<T1> GHJDMBPGMHF, IEnumerable<T2> IKDBBHHKFLJ, IEnumerable<T3> LAPNDBKJOMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x84E040", Offset = "0x84D440", VA = "0x18084E040")]
	internal static int OMMPNDEPKJM(int OCFLHCNKIOC, int OAJDIGHLBBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x84E030", Offset = "0x84D430", VA = "0x18084E030")]
	internal static int OMMPNDEPKJM(int OCFLHCNKIOC, int OAJDIGHLBBJ, int NICHKODOGIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x84E010", Offset = "0x84D410", VA = "0x18084E010")]
	internal static int OMMPNDEPKJM(int OCFLHCNKIOC, int OAJDIGHLBBJ, int NICHKODOGIG, int POKNFEDPNND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E150", Offset = "0x5F6D550", VA = "0x185F6E150")]
	internal static int OMMPNDEPKJM(int OCFLHCNKIOC, int OAJDIGHLBBJ, int NICHKODOGIG, int POKNFEDPNND, int JBNJCEPGEBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E170", Offset = "0x5F6D570", VA = "0x185F6E170")]
	internal static int OMMPNDEPKJM(int OCFLHCNKIOC, int OAJDIGHLBBJ, int NICHKODOGIG, int POKNFEDPNND, int JBNJCEPGEBJ, int GNIKAIOKPBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E120", Offset = "0x5F6D520", VA = "0x185F6E120")]
	internal static int OMMPNDEPKJM(int OCFLHCNKIOC, int OAJDIGHLBBJ, int NICHKODOGIG, int POKNFEDPNND, int JBNJCEPGEBJ, int GNIKAIOKPBO, int INAPLBPADGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E190", Offset = "0x5F6D590", VA = "0x185F6E190")]
	internal static int OMMPNDEPKJM(int OCFLHCNKIOC, int OAJDIGHLBBJ, int NICHKODOGIG, int POKNFEDPNND, int JBNJCEPGEBJ, int GNIKAIOKPBO, int INAPLBPADGK, int FCDOCFOMIOF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FPCKLBLFLDE<T1> : IComparable<global::FPCKLBLFLDE<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 GCFLMFHKLIK;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1D528D0", Offset = "0x1D51CD0", VA = "0x181D528D0")]
	public FPCKLBLFLDE(T1 IBEKMKEBFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x25DA4B0", Offset = "0x25D98B0", VA = "0x1825DA4B0", Slot = "4")]
	public int CompareTo(global::FPCKLBLFLDE<T1> EPJIAIAEMFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x25DA520", Offset = "0x25D9920", VA = "0x1825DA520", Slot = "0")]
	public override bool Equals(object EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x956D80", Offset = "0x956180", VA = "0x180956D80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x25DA5C0", Offset = "0x25D99C0", VA = "0x1825DA5C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NGHPEIAIIKD<T1, T2> : IComparable<global::NGHPEIAIIKD<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 GCFLMFHKLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 AOCENNMLIBP;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x287AFB0", Offset = "0x287A3B0", VA = "0x18287AFB0")]
	public NGHPEIAIIKD(T1 IBEKMKEBFKD, T2 GHPDLBFNBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3434580", Offset = "0x3433980", VA = "0x183434580", Slot = "4")]
	public int CompareTo(global::NGHPEIAIIKD<T1, T2> EPJIAIAEMFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3434990", Offset = "0x3433D90", VA = "0x183434990", Slot = "0")]
	public override bool Equals(object EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3435420", Offset = "0x3434820", VA = "0x183435420", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3435B60", Offset = "0x3434F60", VA = "0x183435B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NIKCPLHEHNF<T1, T2, T3> : IComparable<global::NIKCPLHEHNF<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 GCFLMFHKLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 AOCENNMLIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 MCBDMEDFCIE;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x39C3590", Offset = "0x39C2990", VA = "0x1839C3590")]
	public NIKCPLHEHNF(T1 IBEKMKEBFKD, T2 GHPDLBFNBEB, T3 KGGAJFOCJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x39C2D80", Offset = "0x39C2180", VA = "0x1839C2D80", Slot = "4")]
	public int CompareTo(global::NIKCPLHEHNF<T1, T2, T3> EPJIAIAEMFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x39C2F80", Offset = "0x39C2380", VA = "0x1839C2F80", Slot = "0")]
	public override bool Equals(object EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x39C31E0", Offset = "0x39C25E0", VA = "0x1839C31E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x39C33E0", Offset = "0x39C27E0", VA = "0x1839C33E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class AMBJACAPLBH<T1, T2, T3, T4> : IComparable<global::AMBJACAPLBH<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 GCFLMFHKLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 AOCENNMLIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 MCBDMEDFCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 NFKEPCLFKDJ;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x278FC70", Offset = "0x278F070", VA = "0x18278FC70")]
	public AMBJACAPLBH(T1 IBEKMKEBFKD, T2 GHPDLBFNBEB, T3 KGGAJFOCJAH, T4 NGDJFAMBENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x30FD930", Offset = "0x30FCD30", VA = "0x1830FD930", Slot = "4")]
	public int CompareTo(global::AMBJACAPLBH<T1, T2, T3, T4> EPJIAIAEMFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x30FDA70", Offset = "0x30FCE70", VA = "0x1830FDA70", Slot = "0")]
	public override bool Equals(object EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x30FDB90", Offset = "0x30FCF90", VA = "0x1830FDB90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x30FDC50", Offset = "0x30FD050", VA = "0x1830FDC50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NBNAPDHICBE<T1, T2, T3, T4, T5> : IComparable<global::NBNAPDHICBE<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 GCFLMFHKLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 AOCENNMLIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 MCBDMEDFCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 NFKEPCLFKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 DLIOLKDAOEC;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x279BEF0", Offset = "0x279B2F0", VA = "0x18279BEF0")]
	public NBNAPDHICBE(T1 IBEKMKEBFKD, T2 GHPDLBFNBEB, T3 KGGAJFOCJAH, T4 NGDJFAMBENL, T5 AIKAMBEAFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2F8B680", Offset = "0x2F8AA80", VA = "0x182F8B680", Slot = "4")]
	public int CompareTo(global::NBNAPDHICBE<T1, T2, T3, T4, T5> EPJIAIAEMFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2F8B800", Offset = "0x2F8AC00", VA = "0x182F8B800", Slot = "0")]
	public override bool Equals(object EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2F8B940", Offset = "0x2F8AD40", VA = "0x182F8B940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2F8BA40", Offset = "0x2F8AE40", VA = "0x182F8BA40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BOIMIMLKFAO<T1, T2, T3, T4, T5, T6> : IComparable<global::BOIMIMLKFAO<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 GCFLMFHKLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 AOCENNMLIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 MCBDMEDFCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 NFKEPCLFKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 DLIOLKDAOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 AMOHBAIJKPI;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2392AF0", Offset = "0x2391EF0", VA = "0x182392AF0")]
	public BOIMIMLKFAO(T1 IBEKMKEBFKD, T2 GHPDLBFNBEB, T3 KGGAJFOCJAH, T4 NGDJFAMBENL, T5 AIKAMBEAFLM, T6 PCMICFEBNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2392530", Offset = "0x2391930", VA = "0x182392530", Slot = "4")]
	public int CompareTo(global::BOIMIMLKFAO<T1, T2, T3, T4, T5, T6> EPJIAIAEMFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x23926F0", Offset = "0x2391AF0", VA = "0x1823926F0", Slot = "0")]
	public override bool Equals(object EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2392860", Offset = "0x2391C60", VA = "0x182392860", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2392980", Offset = "0x2391D80", VA = "0x182392980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CEEOIKPIDEG<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::CEEOIKPIDEG<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 GCFLMFHKLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 AOCENNMLIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 MCBDMEDFCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 NFKEPCLFKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 DLIOLKDAOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 AMOHBAIJKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 AIFFMOJAHEA;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x35A8480", Offset = "0x35A7880", VA = "0x1835A8480")]
	public CEEOIKPIDEG(T1 IBEKMKEBFKD, T2 GHPDLBFNBEB, T3 KGGAJFOCJAH, T4 NGDJFAMBENL, T5 AIKAMBEAFLM, T6 PCMICFEBNMJ, T7 NIADFPLHKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x35A7E00", Offset = "0x35A7200", VA = "0x1835A7E00", Slot = "4")]
	public int CompareTo(global::CEEOIKPIDEG<T1, T2, T3, T4, T5, T6, T7> EPJIAIAEMFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x35A8000", Offset = "0x35A7400", VA = "0x1835A8000", Slot = "0")]
	public override bool Equals(object EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x35A81A0", Offset = "0x35A75A0", VA = "0x1835A81A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x35A82F0", Offset = "0x35A76F0", VA = "0x1835A82F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FPNPNGEOPAI<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::FPNPNGEOPAI<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 GCFLMFHKLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 AOCENNMLIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 MCBDMEDFCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 NFKEPCLFKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 DLIOLKDAOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 AMOHBAIJKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 AIFFMOJAHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 PGPIACEGLAG;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x25E4FF0", Offset = "0x25E43F0", VA = "0x1825E4FF0")]
	public FPNPNGEOPAI(T1 IBEKMKEBFKD, T2 GHPDLBFNBEB, T3 KGGAJFOCJAH, T4 NGDJFAMBENL, T5 AIKAMBEAFLM, T6 PCMICFEBNMJ, T7 NIADFPLHKEI, T8 IEOCNOJFGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x25E48C0", Offset = "0x25E3CC0", VA = "0x1825E48C0", Slot = "4")]
	public int CompareTo(global::FPNPNGEOPAI<T1, T2, T3, T4, T5, T6, T7, T8> EPJIAIAEMFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x25E4B10", Offset = "0x25E3F10", VA = "0x1825E4B10", Slot = "0")]
	public override bool Equals(object EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x25E4CD0", Offset = "0x25E40D0", VA = "0x1825E4CD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x25E4E40", Offset = "0x25E4240", VA = "0x1825E4E40", Slot = "3")]
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
	public T KGOGAJOHGBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1936AA0", Offset = "0x1935EA0", VA = "0x181936AA0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x424E690", Offset = "0x424DA90", VA = "0x18424E690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float NPPPEDBNIOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1146300", Offset = "0x1145700", VA = "0x181146300")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x424E410", Offset = "0x424D810", VA = "0x18424E410")]
	public T BKCHNMMDBNH(float BJKDLBIJMNC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x424E600", Offset = "0x424DA00", VA = "0x18424E600")]
	public T MMEKAMHDEBH(float BJKDLBIJMNC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T MHOLJNOIKPD(T LBABLKMFGKM, T MGCAIGBBIIM, float BJKDLBIJMNC);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x37F7420", Offset = "0x37F6820", VA = "0x1837F7420", Slot = "4")]
	protected override float MHOLJNOIKPD(float LBABLKMFGKM, float MGCAIGBBIIM, float BJKDLBIJMNC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C0D0", Offset = "0x5F6B4D0", VA = "0x185F6C0D0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0xF840B0", Offset = "0xF834B0", VA = "0x180F840B0", Slot = "4")]
	protected override Vector3 MHOLJNOIKPD(Vector3 LBABLKMFGKM, Vector3 MGCAIGBBIIM, float BJKDLBIJMNC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5F731E0", Offset = "0x5F725E0", VA = "0x185F731E0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B180", Offset = "0x5F6A580", VA = "0x185F6B180", Slot = "4")]
	protected override Color MHOLJNOIKPD(Color LBABLKMFGKM, Color MGCAIGBBIIM, float BJKDLBIJMNC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B1D0", Offset = "0x5F6A5D0", VA = "0x185F6B1D0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DFIDLGFCANC : global::LFENAALNENL<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B2E0", Offset = "0x5F6A6E0", VA = "0x185F6B2E0")]
	public DFIDLGFCANC(int OAKAJHNNELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B280", Offset = "0x5F6A680", VA = "0x185F6B280")]
	public DFIDLGFCANC(MCIOPFHDPDF[] GPMNJBAKNOM, bool JFFACHBBBJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B210", Offset = "0x5F6A610", VA = "0x185F6B210", Slot = "6")]
	protected override uint IKIBFCMNDCD(uint BMNGMMBLJFF, string IGDJJEECDAF)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GNEADLIKJOL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public GNEADLIKJOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct IDIGCDBLJDA
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class MJKJNFINAPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<IMOBLFIBELG> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public MJKJNFINAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5F6E830", Offset = "0x5F6DC30", VA = "0x185F6E830")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<IMOBLFIBELG>> GFKECICMGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int FPBIBKDPPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int EEADCELPACL;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xCCCD80", Offset = "0xCCC180", VA = "0x180CCCD80")]
	private IDIGCDBLJDA(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<IMOBLFIBELG>> MJIOFEBIHIO, int IAKAJGKLODC, int BCALFIAJEJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5F6CA00", Offset = "0x5F6BE00", VA = "0x185F6CA00")]
	public static IDIGCDBLJDA IKMCJIAOBME()
	{
		return default(IDIGCDBLJDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C610", Offset = "0x5F6BA10", VA = "0x185F6C610")]
	public (int, int, Task) AGHHJBLKCNB(int NKDDBGPFFOL, [Optional] CancellationToken BJOMIPBBJKO)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5F6CA80", Offset = "0x5F6BE80", VA = "0x185F6CA80")]
	public void LDOGFLDGBCC(int NKDDBGPFFOL, int BCALFIAJEJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class NPKJDFANMEL<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> JFCMDMLKBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> KOFKNBFEJLP;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1FAEDA0", Offset = "0x1FAE1A0", VA = "0x181FAEDA0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool DMJNBBKFGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> DPOHLNEFLGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2445D50", Offset = "0x2445150", VA = "0x182445D50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> NBNNPOMEFJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2801D60", Offset = "0x2801160", VA = "0x182801D60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x25C37A0", Offset = "0x25C2BA0", VA = "0x1825C37A0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x29D3210", Offset = "0x29D2610", VA = "0x1829D3210", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x39D60E0", Offset = "0x39D54E0", VA = "0x1839D60E0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x39D6590", Offset = "0x39D5990", VA = "0x1839D6590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x39D5CC0", Offset = "0x39D50C0", VA = "0x1839D5CC0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x39D6630", Offset = "0x39D5A30", VA = "0x1839D6630", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x279F170", Offset = "0x279E570", VA = "0x18279F170", Slot = "9")]
	public void Add(TKey FOJIGKKHICE, TVal IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x39D5C30", Offset = "0x39D5030", VA = "0x1839D5C30", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> BKADPMHNDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x39D5D20", Offset = "0x39D5120", VA = "0x1839D5D20", Slot = "8")]
	public bool ContainsKey(TKey FOJIGKKHICE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x37B6D80", Offset = "0x37B6180", VA = "0x1837B6D80", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> BKADPMHNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x39D6600", Offset = "0x39D5A00", VA = "0x1839D6600", Slot = "10")]
	public bool Remove(TKey FOJIGKKHICE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x39D6600", Offset = "0x39D5A00", VA = "0x1839D6600", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> BKADPMHNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x28E3600", Offset = "0x28E2A00", VA = "0x1828E3600", Slot = "11")]
	public bool TryGetValue(TKey FOJIGKKHICE, out TVal IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x39D6060", Offset = "0x39D5460", VA = "0x1839D6060", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x39D5D80", Offset = "0x39D5180", VA = "0x1839D5D80", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] ICPECNGAFCL, int LMNNOEJODCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x39D5B90", Offset = "0x39D4F90", VA = "0x1839D5B90")]
	public void AKBMAMDKLNI(TVal NGJFGGENEKP, TKey FOJIGKKHICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x39D5B10", Offset = "0x39D4F10", VA = "0x1839D5B10")]
	public void AKBMAMDKLNI(KeyValuePair<TVal, TKey> BKADPMHNDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x39D6110", Offset = "0x39D5510", VA = "0x1839D6110")]
	public bool JHADEOHHAIH(TVal FOJIGKKHICE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x39D5C60", Offset = "0x39D5060", VA = "0x1839D5C60")]
	public bool BJDJCLJIFEK(KeyValuePair<TVal, TKey> BKADPMHNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x29D3470", Offset = "0x29D2870", VA = "0x1829D3470")]
	public bool GKDAOIMBAHJ(TVal FOJIGKKHICE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x29D3470", Offset = "0x29D2870", VA = "0x1829D3470")]
	public bool GKDAOIMBAHJ(KeyValuePair<TVal, TKey> BKADPMHNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x39D6000", Offset = "0x39D5400", VA = "0x1839D6000")]
	public bool GAMCGCGFADK(TVal FOJIGKKHICE, out TKey IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x39D64D0", Offset = "0x39D58D0", VA = "0x1839D64D0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> MBFFFBMBLJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x39D5DE0", Offset = "0x39D51E0", VA = "0x1839D5DE0")]
	private void DCOCJNGACJL(TKey FOJIGKKHICE, TVal NGJFGGENEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x39D5F80", Offset = "0x39D5380", VA = "0x1839D5F80")]
	private void FMNCDICEDEE(TKey FOJIGKKHICE, TVal NGJFGGENEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x39D6380", Offset = "0x39D5780", VA = "0x1839D6380")]
	private bool JKMAANLMKJI(TKey FOJIGKKHICE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x39D6140", Offset = "0x39D5540", VA = "0x1839D6140")]
	private bool JKMAANLMKJI(TVal NGJFGGENEKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x39D66D0", Offset = "0x39D5AD0", VA = "0x1839D66D0")]
	public NPKJDFANMEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class MFPEFCBFNNG<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::MFPEFCBFNNG<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x3187200", Offset = "0x3186600", VA = "0x183187200", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x301EC70", Offset = "0x301E070", VA = "0x18301EC70")]
		public Enumerator(global::MFPEFCBFNNG<T> CCBBJEPJPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3185A20", Offset = "0x3184E20", VA = "0x183185A20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x31867D0", Offset = "0x3185BD0", VA = "0x1831867D0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3183CF0", Offset = "0x31830F0", VA = "0x183183CF0")]
		private void EGAFIDOIAOP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] ENFGAHDEDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int PKHCKPMMLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int FKHOGGNJKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int FMCKDMNHLLD;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x29CBBD0", Offset = "0x29CAFD0", VA = "0x1829CBBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x29CAEB0", Offset = "0x29CA2B0", VA = "0x1829CAEB0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x29CBD80", Offset = "0x29CB180", VA = "0x1829CBD80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x29CC4B0", Offset = "0x29CB8B0", VA = "0x1829CC4B0")]
	public MFPEFCBFNNG(int OAKAJHNNELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x29CA630", Offset = "0x29C9A30", VA = "0x1829CA630")]
	public void AKBMAMDKLNI(T BJKDLBIJMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x29CB8E0", Offset = "0x29CACE0", VA = "0x1829CB8E0")]
	public void MAJCBPCOFJK(IEnumerable<T> KMGJAAODLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x29CA860", Offset = "0x29C9C60", VA = "0x1829CA860")]
	public void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x29CA880", Offset = "0x29C9C80", VA = "0x1829CA880")]
	public void EHBADOOCBPA(int LKJCGNNPEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x29CC1C0", Offset = "0x29CB5C0", VA = "0x1829CC1C0")]
	public void NKHHKHAMEON(int LKJCGNNPEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x29CAD00", Offset = "0x29CA100", VA = "0x1829CAD00")]
	public void GAACNCMFMAJ(T[] ICPECNGAFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x29CC280", Offset = "0x29CB680", VA = "0x1829CC280")]
	public Enumerator PEKBJENCCON()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x29CC330", Offset = "0x29CB730", VA = "0x1829CC330", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x29CC330", Offset = "0x29CB730", VA = "0x1829CC330", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x29CBEF0", Offset = "0x29CB2F0", VA = "0x1829CBEF0")]
	private int MPBAMAJDDJM(int HMJKJGLHFKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x29CC250", Offset = "0x29CB650", VA = "0x1829CC250")]
	private int OMAHALELBHL(int HMJKJGLHFKE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class DAKJPJGFFHE<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> GPNBAJLFPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> KOKNBHPJDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> MOBONMBAIDJ;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> DGMFDIGFKNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x679130", Offset = "0x678530", VA = "0x180679130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool DMJNBBKFGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x768F80", Offset = "0x768380", VA = "0x180768F80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x732170", Offset = "0x731570", VA = "0x180732170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x27ED410", Offset = "0x27EC810", VA = "0x1827ED410", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x27ED4B0", Offset = "0x27EC8B0", VA = "0x1827ED4B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x27ED3B0", Offset = "0x27EC7B0", VA = "0x1827ED3B0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x27ED320", Offset = "0x27EC720", VA = "0x1827ED320")]
	public DAKJPJGFFHE(Func<Internal, External> GPNBAJLFPAC, Func<External, Internal> KOKNBHPJDNK, bool MFAHGLHJJKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x27ED0A0", Offset = "0x27EC4A0", VA = "0x1827ED0A0", Slot = "6")]
	public int IndexOf(External BKADPMHNDEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x27ECD20", Offset = "0x27EC120", VA = "0x1827ECD20", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x27ECD80", Offset = "0x27EC180", VA = "0x1827ECD80", Slot = "13")]
	public bool Contains(External BKADPMHNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x27ECE10", Offset = "0x27EC210", VA = "0x1827ECE10", Slot = "14")]
	public void CopyTo(External[] ICPECNGAFCL, int LMNNOEJODCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x27ECC90", Offset = "0x27EC090", VA = "0x1827ECC90", Slot = "11")]
	public void Add(External BKADPMHNDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x27ED130", Offset = "0x27EC530", VA = "0x1827ED130", Slot = "7")]
	public void Insert(int HMJKJGLHFKE, External BKADPMHNDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x27ED290", Offset = "0x27EC690", VA = "0x1827ED290", Slot = "15")]
	public bool Remove(External BKADPMHNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x27ED1D0", Offset = "0x27EC5D0", VA = "0x1827ED1D0", Slot = "8")]
	public void RemoveAt(int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x27ED030", Offset = "0x27EC430", VA = "0x1827ED030", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1BB0730", Offset = "0x1BAFB30", VA = "0x181BB0730", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class EFKOCJGKCOE<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> GPNBAJLFPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> MOBONMBAIDJ;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> DGMFDIGFKNO
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x697540", VA = "0x180698140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool DMJNBBKFGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x699020", Offset = "0x698420", VA = "0x180699020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x243D0C0", Offset = "0x243C4C0", VA = "0x18243D0C0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x243D060", Offset = "0x243C460", VA = "0x18243D060", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1D528D0", Offset = "0x1D51CD0", VA = "0x181D528D0")]
	public EFKOCJGKCOE(Func<Internal, External> GPNBAJLFPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x243D010", Offset = "0x243C410", VA = "0x18243D010")]
	public EFKOCJGKCOE(IReadOnlyList<Internal> MOBONMBAIDJ, Func<Internal, External> GPNBAJLFPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x243CD80", Offset = "0x243C180", VA = "0x18243CD80")]
	public void GAACNCMFMAJ(External[] ICPECNGAFCL, int LMNNOEJODCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x243CFA0", Offset = "0x243C3A0", VA = "0x18243CFA0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1F14E50", Offset = "0x1F14250", VA = "0x181F14E50", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class MKJKLKHFONH<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> MOBONMBAIDJ;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> DGMFDIGFKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x697530", VA = "0x180698130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool DMJNBBKFGJL
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x699020", Offset = "0x698420", VA = "0x180699020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x29CF3D0", Offset = "0x29CE7D0", VA = "0x1829CF3D0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x29CF370", Offset = "0x29CE770", VA = "0x1829CF370", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1D528D0", Offset = "0x1D51CD0", VA = "0x181D528D0")]
	public MKJKLKHFONH(IReadOnlyList<Internal> MOBONMBAIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x29CF030", Offset = "0x29CE430", VA = "0x1829CF030")]
	public bool BJDJCLJIFEK(External BKADPMHNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x29CF0D0", Offset = "0x29CE4D0", VA = "0x1829CF0D0")]
	public void GAACNCMFMAJ(External[] ICPECNGAFCL, int LMNNOEJODCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x29CF300", Offset = "0x29CE700", VA = "0x1829CF300", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1BB0730", Offset = "0x1BAFB30", VA = "0x181BB0730", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class NDNJJDBBPPD
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void CIHOGKMMCKL(object[] MMLIFJCNOMF);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	protected NDNJJDBBPPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class LKPPNGJBHGB<T> : NDNJJDBBPPD
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	protected struct MBGIOAPDKDD
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum LNGGCPOLMKC
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
		public LNGGCPOLMKC FPPBLNEEHBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T LECDCDLGAEL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int AJKBHMJFJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool LJJLCJHJFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool CLMBLAFGKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> MLECCKLAEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<MBGIOAPDKDD> FKNPIECDDOM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool CEBKNDBANAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3098290", Offset = "0x3097690", VA = "0x183098290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3098410", Offset = "0x3097810", VA = "0x183098410")]
	protected LKPPNGJBHGB(bool CLMBLAFGKOG, bool LJJLCJHJFJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3098390", Offset = "0x3097790", VA = "0x183098390")]
	protected bool LLFHFBPJAOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x30982D0", Offset = "0x30976D0", VA = "0x1830982D0")]
	protected void KKCADPBCECE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3097FA0", Offset = "0x30973A0", VA = "0x183097FA0")]
	protected void DPAACKDJGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x241E760", Offset = "0x241DB60", VA = "0x18241E760")]
	private static void HDJIHGCCJLL<U>(ref List<U> MOBONMBAIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3097D30", Offset = "0x3097130", VA = "0x183097D30", Slot = "5")]
	public void AKBMAMDKLNI(T LECDCDLGAEL, bool OBPBLALEFNO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3098150", Offset = "0x3097550", VA = "0x183098150", Slot = "6")]
	public void GKDAOIMBAHJ(T LECDCDLGAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3097E90", Offset = "0x3097290", VA = "0x183097E90")]
	public void BNMOGLEIOOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface NCBGHHJGMFL
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKBMAMDKLNI(Action LECDCDLGAEL, bool OBPBLALEFNO = false);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKDAOIMBAHJ(Action LECDCDLGAEL);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class PENMMECJMBL : global::LKPPNGJBHGB<Action>, NCBGHHJGMFL
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5F70B30", Offset = "0x5F6FF30", VA = "0x185F70B30")]
	public PENMMECJMBL(bool CLMBLAFGKOG = false, bool LJJLCJHJFJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5F708C0", Offset = "0x5F6FCC0", VA = "0x185F708C0")]
	public void FGMLNBEAMPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5F707F0", Offset = "0x5F6FBF0", VA = "0x185F707F0", Slot = "4")]
	public override void CIHOGKMMCKL(object[] MMLIFJCNOMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5F70860", Offset = "0x5F6FC60", VA = "0x185F70860")]
	public static PENMMECJMBL CJKGECOCJLM(PENMMECJMBL HKMJDMPGNHN, Action LECDCDLGAEL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5F70AD0", Offset = "0x5F6FED0", VA = "0x185F70AD0")]
	public static PENMMECJMBL OKEHOEDNOBN(PENMMECJMBL HKMJDMPGNHN, Action LECDCDLGAEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface GMKKILCBLGK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKBMAMDKLNI(Action<T> LECDCDLGAEL, bool OBPBLALEFNO = false);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKDAOIMBAHJ(Action<T> LECDCDLGAEL);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class DJLAHHEMKBC<T> : global::LKPPNGJBHGB<Action<T>>, global::GMKKILCBLGK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x1BA7730", Offset = "0x1BA6B30", VA = "0x181BA7730")]
	public DJLAHHEMKBC(bool CLMBLAFGKOG = false, bool LJJLCJHJFJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3576840", Offset = "0x3575C40", VA = "0x183576840")]
	public void FGMLNBEAMPP(T BJKDLBIJMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x35751D0", Offset = "0x35745D0", VA = "0x1835751D0", Slot = "4")]
	public override void CIHOGKMMCKL(object[] MMLIFJCNOMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3575350", Offset = "0x3574750", VA = "0x183575350")]
	public static global::DJLAHHEMKBC<T> CJKGECOCJLM(global::DJLAHHEMKBC<T> HKMJDMPGNHN, Action<T> LECDCDLGAEL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3576F40", Offset = "0x3576340", VA = "0x183576F40")]
	public static global::DJLAHHEMKBC<T> OKEHOEDNOBN(global::DJLAHHEMKBC<T> HKMJDMPGNHN, Action<T> LECDCDLGAEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface COCNMPCPIIO<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKBMAMDKLNI(Action<T, U> LECDCDLGAEL, bool OBPBLALEFNO = false);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKDAOIMBAHJ(Action<T, U> LECDCDLGAEL);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class IANNIOIAEJN<T, U> : global::LKPPNGJBHGB<Action<T, U>>, global::COCNMPCPIIO<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1BA7730", Offset = "0x1BA6B30", VA = "0x181BA7730")]
	public IANNIOIAEJN(bool CLMBLAFGKOG = false, bool LJJLCJHJFJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1BA5690", Offset = "0x1BA4A90", VA = "0x181BA5690")]
	public void FGMLNBEAMPP(T BJKDLBIJMNC, U OCJJKIPGOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x1BA4F40", Offset = "0x1BA4340", VA = "0x181BA4F40", Slot = "4")]
	public override void CIHOGKMMCKL(object[] MMLIFJCNOMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x1BA50F0", Offset = "0x1BA44F0", VA = "0x181BA50F0")]
	public static global::IANNIOIAEJN<T, U> CJKGECOCJLM(global::IANNIOIAEJN<T, U> HKMJDMPGNHN, Action<T, U> LECDCDLGAEL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x1BA7690", Offset = "0x1BA6A90", VA = "0x181BA7690")]
	public static global::IANNIOIAEJN<T, U> OKEHOEDNOBN(global::IANNIOIAEJN<T, U> HKMJDMPGNHN, Action<T, U> LECDCDLGAEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface NIDFICEDBDI<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKBMAMDKLNI(Action<T, U, V> LECDCDLGAEL, bool OBPBLALEFNO = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKDAOIMBAHJ(Action<T, U, V> LECDCDLGAEL);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class PEGGEILGJFO<T, U, V> : global::LKPPNGJBHGB<Action<T, U, V>>, global::NIDFICEDBDI<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x1BA7730", Offset = "0x1BA6B30", VA = "0x181BA7730")]
	public PEGGEILGJFO(bool CLMBLAFGKOG = false, bool LJJLCJHJFJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x28DCF10", Offset = "0x28DC310", VA = "0x1828DCF10")]
	public void FGMLNBEAMPP(T BJKDLBIJMNC, U OCJJKIPGOAE, V FHHDDMKIIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x28DC0F0", Offset = "0x28DB4F0", VA = "0x1828DC0F0", Slot = "4")]
	public override void CIHOGKMMCKL(object[] MMLIFJCNOMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x28DC950", Offset = "0x28DBD50", VA = "0x1828DC950")]
	public static global::PEGGEILGJFO<T, U, V> CJKGECOCJLM(global::PEGGEILGJFO<T, U, V> HKMJDMPGNHN, Action<T, U, V> LECDCDLGAEL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x28DEA60", Offset = "0x28DDE60", VA = "0x1828DEA60")]
	public static global::PEGGEILGJFO<T, U, V> OKEHOEDNOBN(global::PEGGEILGJFO<T, U, V> HKMJDMPGNHN, Action<T, U, V> LECDCDLGAEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface DHBDBAJHGHK<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKBMAMDKLNI(Action<T, U, V, W> LECDCDLGAEL, bool OBPBLALEFNO = false);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKDAOIMBAHJ(Action<T, U, V, W> LECDCDLGAEL);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class OCAKMAOKEFB<T, U, V, W> : global::LKPPNGJBHGB<Action<T, U, V, W>>, global::DHBDBAJHGHK<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x1BA7730", Offset = "0x1BA6B30", VA = "0x181BA7730")]
	public OCAKMAOKEFB(bool CLMBLAFGKOG = false, bool LJJLCJHJFJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3A48820", Offset = "0x3A47C20", VA = "0x183A48820")]
	public void FGMLNBEAMPP(T BJKDLBIJMNC, U OCJJKIPGOAE, V FHHDDMKIIBK, W NBBEJJDNGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3A470A0", Offset = "0x3A464A0", VA = "0x183A470A0", Slot = "4")]
	public override void CIHOGKMMCKL(object[] MMLIFJCNOMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3A48510", Offset = "0x3A47910", VA = "0x183A48510")]
	public static global::OCAKMAOKEFB<T, U, V, W> CJKGECOCJLM(global::OCAKMAOKEFB<T, U, V, W> HKMJDMPGNHN, Action<T, U, V, W> LECDCDLGAEL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3A49AB0", Offset = "0x3A48EB0", VA = "0x183A49AB0")]
	public static global::OCAKMAOKEFB<T, U, V, W> OKEHOEDNOBN(global::OCAKMAOKEFB<T, U, V, W> HKMJDMPGNHN, Action<T, U, V, W> LECDCDLGAEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface HLCJEELLHJM<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKBMAMDKLNI(Action<T, U, V, W, X> LECDCDLGAEL, bool OBPBLALEFNO = false);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKDAOIMBAHJ(Action<T, U, V, W, X> LECDCDLGAEL);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class EMOCHMPAMHG<T, U, V, W, X> : global::LKPPNGJBHGB<Action<T, U, V, W, X>>, global::HLCJEELLHJM<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x1BA7730", Offset = "0x1BA6B30", VA = "0x181BA7730")]
	public EMOCHMPAMHG(bool CLMBLAFGKOG = false, bool LJJLCJHJFJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2456BD0", Offset = "0x2455FD0", VA = "0x182456BD0")]
	public void FGMLNBEAMPP(T BJKDLBIJMNC, U OCJJKIPGOAE, V FHHDDMKIIBK, W NBBEJJDNGHM, X BCJCIOLMPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2456840", Offset = "0x2455C40", VA = "0x182456840", Slot = "4")]
	public override void CIHOGKMMCKL(object[] MMLIFJCNOMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2456B30", Offset = "0x2455F30", VA = "0x182456B30")]
	public static global::EMOCHMPAMHG<T, U, V, W, X> CJKGECOCJLM(global::EMOCHMPAMHG<T, U, V, W, X> HKMJDMPGNHN, Action<T, U, V, W, X> LECDCDLGAEL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2457190", Offset = "0x2456590", VA = "0x182457190")]
	public static global::EMOCHMPAMHG<T, U, V, W, X> OKEHOEDNOBN(global::EMOCHMPAMHG<T, U, V, W, X> HKMJDMPGNHN, Action<T, U, V, W, X> LECDCDLGAEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface FLEFOMKNLHH<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKBMAMDKLNI(Action<T, U, V, W, X, Y> LECDCDLGAEL, bool OBPBLALEFNO = false);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKDAOIMBAHJ(Action<T, U, V, W, X, Y> LECDCDLGAEL);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class JLGCFAILFEO<T, U, V, W, X, Y> : global::LKPPNGJBHGB<Action<T, U, V, W, X, Y>>, global::FLEFOMKNLHH<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1BA7730", Offset = "0x1BA6B30", VA = "0x181BA7730")]
	public JLGCFAILFEO(bool CLMBLAFGKOG = false, bool LJJLCJHJFJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x20B8F00", Offset = "0x20B8300", VA = "0x1820B8F00")]
	public void FGMLNBEAMPP(T BJKDLBIJMNC, U OCJJKIPGOAE, V FHHDDMKIIBK, W NBBEJJDNGHM, X BCJCIOLMPPL, Y OIPENDMCMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x20B7E90", Offset = "0x20B7290", VA = "0x1820B7E90", Slot = "4")]
	public override void CIHOGKMMCKL(object[] MMLIFJCNOMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x20B8890", Offset = "0x20B7C90", VA = "0x1820B8890")]
	public static global::JLGCFAILFEO<T, U, V, W, X, Y> CJKGECOCJLM(global::JLGCFAILFEO<T, U, V, W, X, Y> HKMJDMPGNHN, Action<T, U, V, W, X, Y> LECDCDLGAEL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x20B91B0", Offset = "0x20B85B0", VA = "0x1820B91B0")]
	public static global::JLGCFAILFEO<T, U, V, W, X, Y> OKEHOEDNOBN(global::JLGCFAILFEO<T, U, V, W, X, Y> HKMJDMPGNHN, Action<T, U, V, W, X, Y> LECDCDLGAEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class GALHLJJNKAK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct MKPINBECCNO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::GALHLJJNKAK<T> PCFCGONNNGD;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T KGOGAJOHGBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x29CFB80", Offset = "0x29CEF80", VA = "0x1829CFB80")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x29CFBA0", Offset = "0x29CEFA0", VA = "0x1829CFBA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x88DB80", Offset = "0x88CF80", VA = "0x18088DB80")]
		public MKPINBECCNO(global::GALHLJJNKAK<T> PCFCGONNNGD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct AFCIICPFIEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<MKPINBECCNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::GALHLJJNKAK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x384E220", Offset = "0x384D620", VA = "0x18384E220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x1FA1880", Offset = "0x1FA0C80", VA = "0x181FA1880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct LFLPMNADCCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<MKPINBECCNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::GALHLJJNKAK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3887040", Offset = "0x3886440", VA = "0x183887040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1FA1880", Offset = "0x1FA0C80", VA = "0x181FA1880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim GHNLLOMCJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T FMFJJGIPNEC;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int DBKEDPNGGFE
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2D35CE0", Offset = "0x2D350E0", VA = "0x182D35CE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2D363F0", Offset = "0x2D357F0", VA = "0x182D363F0")]
	public GALHLJJNKAK(in T FMFJJGIPNEC, int ICLJBDJDACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2D363C0", Offset = "0x2D357C0", VA = "0x182D363C0")]
	public GALHLJJNKAK(in T FMFJJGIPNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2D35D00", Offset = "0x2D35100", VA = "0x182D35D00")]
	public MKPINBECCNO BBPNMAFMEMB()
	{
		return default(MKPINBECCNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2D35D40", Offset = "0x2D35140", VA = "0x182D35D40")]
	public MKPINBECCNO BBPNMAFMEMB(CancellationToken BJOMIPBBJKO)
	{
		return default(MKPINBECCNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2D35D80", Offset = "0x2D35180", VA = "0x182D35D80")]
	[AsyncStateMachine(typeof(global::GALHLJJNKAK<>.AFCIICPFIEG))]
	public Task<MKPINBECCNO> PAEADCAJNMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2D35EE0", Offset = "0x2D352E0", VA = "0x182D35EE0")]
	[AsyncStateMachine(typeof(global::GALHLJJNKAK<>.LFLPMNADCCA))]
	public Task<MKPINBECCNO> PAEADCAJNMA(CancellationToken BJOMIPBBJKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class LHEAECIJDDN
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E680", Offset = "0x5F6DA80", VA = "0x185F6E680")]
	public static global::GALHLJJNKAK<IMOBLFIBELG> IKMCJIAOBME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E6E0", Offset = "0x5F6DAE0", VA = "0x185F6E6E0")]
	public static global::GALHLJJNKAK<IMOBLFIBELG> IKMCJIAOBME(int ICLJBDJDACF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC71C0", Offset = "0x1FC65C0", VA = "0x181FC71C0")]
	public static global::GALHLJJNKAK<T> IKMCJIAOBME<T>(in T FMFJJGIPNEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x1F82390", Offset = "0x1F81790", VA = "0x181F82390")]
	public static global::GALHLJJNKAK<T> IKMCJIAOBME<T>(in T FMFJJGIPNEC, int ICLJBDJDACF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class JHCBLGEPLFP<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate Task<TResult> OMNHOHKGKOK(TRequest EMCPHLBMEHO, CancellationToken BJOMIPBBJKO);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum ANJNBFPLEFN
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class LAOPNHEAKDH
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float DLFCINFPIOO = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan NBONAKOGICP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int OOGGEKMHHHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public ANJNBFPLEFN HGHJFCEOOOB;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly LAOPNHEAKDH BKIMHMJINMC;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float FBMEJOFCPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4337F00", Offset = "0x4337300", VA = "0x184337F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan GIKJBJCIHBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4337FE0", Offset = "0x43373E0", VA = "0x184337FE0")]
		public LAOPNHEAKDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private readonly struct DHIMOELFGFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest EMCPHLBMEHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken BJOMIPBBJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> KICLMEDDHKN;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2801380", Offset = "0x2800780", VA = "0x182801380")]
		public DHIMOELFGFD(TRequest EMCPHLBMEHO, TaskCompletionSource<TResult> KICLMEDDHKN, CancellationToken BJOMIPBBJKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class KIJOGMKKLHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public KIJOGMKKLHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x1FAEDA0", Offset = "0x1FAE1A0", VA = "0x181FAEDA0")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct LGAOBPFPNEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::JHCBLGEPLFP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3889980", Offset = "0x3888D80", VA = "0x183889980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct CGFFCMMOGFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::JHCBLGEPLFP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private DHIMOELFGFD <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3A738B0", Offset = "0x3A72CB0", VA = "0x183A738B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource ACFHBFPLOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<DHIMOELFGFD> PADHGOLEDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly LAOPNHEAKDH CMMIGGBMPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly OMNHOHKGKOK HEDHLOKPPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task KDDHGHJAJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int GKAKCACJKOH;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x20A6410", Offset = "0x20A5810", VA = "0x1820A6410")]
	public JHCBLGEPLFP(OMNHOHKGKOK HEDHLOKPPKE, [Optional] LAOPNHEAKDH CMMIGGBMPGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x20A5490", Offset = "0x20A4890", VA = "0x1820A5490")]
	public Task<TResult> DLKMEGHOAJH(TRequest EMCPHLBMEHO, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x20A5D20", Offset = "0x20A5120", VA = "0x1820A5D20")]
	private void MMOOEJMPCII(DHIMOELFGFD FHHBPLFIMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x20A6110", Offset = "0x20A5510", VA = "0x1820A6110")]
	[AsyncStateMachine(typeof(global::JHCBLGEPLFP<, >.LGAOBPFPNEE))]
	private Task PGOEIJANBLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x20A4FD0", Offset = "0x20A43D0", VA = "0x1820A4FD0")]
	private DHIMOELFGFD BMADKCMEKHI()
	{
		return default(DHIMOELFGFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x20A5FF0", Offset = "0x20A53F0", VA = "0x1820A5FF0")]
	[AsyncStateMachine(typeof(global::JHCBLGEPLFP<, >.CGFFCMMOGFL))]
	private Task PAEDOJNFFPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x20A5A40", Offset = "0x20A4E40", VA = "0x1820A5A40")]
	private void KLDKCLCNCPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x20A5930", Offset = "0x20A4D30", VA = "0x1820A5930", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class CDFMOFLHBNI<TKey, TVal> : global::ODGDCGAILJD<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int AHJNEHECFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> LBPCLKDIKFB;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int PDJLKGFFENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x35A6860", Offset = "0x35A5C60", VA = "0x1835A6860", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int CBJJEHMCIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x35A6890", Offset = "0x35A5C90", VA = "0x1835A6890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x35A68C0", Offset = "0x35A5CC0", VA = "0x1835A68C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x35A69A0", Offset = "0x35A5DA0", VA = "0x1835A69A0")]
	public CDFMOFLHBNI(int OAKAJHNNELN, [Optional] AFIGGBJIMMM MEBJLAPKIML, [Optional] IEqualityComparer<TKey> BGCOKDNOFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x35A6470", Offset = "0x35A5870", VA = "0x1835A6470")]
	public void FJMNBCEEBAJ(TKey FOJIGKKHICE, TVal IGDJJEECDAF, bool KHBAFGNBBPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x35A6920", Offset = "0x35A5D20", VA = "0x1835A6920")]
	public bool NDDDMLEMBGA(TKey FOJIGKKHICE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x35A6510", Offset = "0x35A5910", VA = "0x1835A6510", Slot = "6")]
	public override bool GAMCGCGFADK(TKey GKFBFMGIFOF, out TVal IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x35A6650", Offset = "0x35A5A50", VA = "0x1835A6650")]
	public bool IMFKFMPJEEB(TKey FOJIGKKHICE, TVal IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x35A62F0", Offset = "0x35A56F0", VA = "0x1835A62F0")]
	public bool BJDMMDAKLOL(TKey FOJIGKKHICE, TVal IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x35A6400", Offset = "0x35A5800", VA = "0x1835A6400", Slot = "7")]
	public override void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x35A65B0", Offset = "0x35A59B0", VA = "0x1835A65B0")]
	private bool GGJBJEEABFM(TKey FOJIGKKHICE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class ODGDCGAILJD<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public delegate int AFIGGBJIMMM(TKey FOJIGKKHICE, TVal IGDJJEECDAF);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class JHKEHGLLCCB
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey HJIIJNBEIGA
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xD85780", Offset = "0xD84B80", VA = "0x180D85780")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal KGOGAJOHGBC
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x679130", Offset = "0x678530", VA = "0x180679130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int HEHPNMDAHOP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x69A1B0", Offset = "0x6995B0", VA = "0x18069A1B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x82DDE0", Offset = "0x82D1E0", VA = "0x18082DDE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime ODJIFPFCODF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x68E6F0", Offset = "0x68DAF0", VA = "0x18068E6F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xE804D0", Offset = "0xE7F8D0", VA = "0x180E804D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x20AD080", Offset = "0x20AC480", VA = "0x1820AD080")]
		public JHKEHGLLCCB(TKey FOJIGKKHICE, TVal NGJFGGENEKP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int PEKAMHJDPOO = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<JHKEHGLLCCB>> DHDOPALDODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<JHKEHGLLCCB> DFPHEMODJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly AFIGGBJIMMM MEBJLAPKIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan MADMCNBPMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly EGDEKDJLFCB IAKFGOKFEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int EDGHAJJNAHM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int HIDCIHPOCOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x678020", Offset = "0x677420", VA = "0x180678020")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool OFPPEIGGCCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3A4CFD0", Offset = "0x3A4C3D0", VA = "0x183A4CFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int PDJLKGFFENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x960870", Offset = "0x95FC70", VA = "0x180960870", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int LKJCGNNPEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1D51710", Offset = "0x1D50B10", VA = "0x181D51710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x239FFA0", Offset = "0x239F3A0", VA = "0x18239FFA0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> DPOHLNEFLGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3A4D060", Offset = "0x3A4C460", VA = "0x183A4D060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3A4E090", Offset = "0x3A4D490", VA = "0x183A4E090")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3A4F9E0", Offset = "0x3A4EDE0", VA = "0x183A4F9E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3A50340", Offset = "0x3A4F740", VA = "0x183A50340")]
	public ODGDCGAILJD(int OAKAJHNNELN, [Optional] AFIGGBJIMMM MEBJLAPKIML, [Optional] IEqualityComparer<TKey> BGCOKDNOFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3A50220", Offset = "0x3A4F620", VA = "0x183A50220")]
	public ODGDCGAILJD(TimeSpan MADMCNBPMEF, [Optional] IEqualityComparer<TKey> BGCOKDNOFIG, [Optional] EGDEKDJLFCB IAKFGOKFEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3A501D0", Offset = "0x3A4F5D0", VA = "0x183A501D0")]
	public ODGDCGAILJD(int OAKAJHNNELN, TimeSpan MADMCNBPMEF, [Optional] IEqualityComparer<TKey> BGCOKDNOFIG, [Optional] EGDEKDJLFCB IAKFGOKFEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x3A50C60", Offset = "0x3A50060", VA = "0x183A50C60")]
	public ODGDCGAILJD(int OAKAJHNNELN, AFIGGBJIMMM MEBJLAPKIML, TimeSpan MADMCNBPMEF, [Optional] IEqualityComparer<TKey> BGCOKDNOFIG, [Optional] EGDEKDJLFCB IAKFGOKFEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x3A4D560", Offset = "0x3A4C960", VA = "0x183A4D560")]
	public void FPANEGIHLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3A4ED30", Offset = "0x3A4E130", VA = "0x183A4ED30")]
	public void KNBGLHDOKIA(TKey FOJIGKKHICE, TVal IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3A4DDC0", Offset = "0x3A4D1C0", VA = "0x183A4DDC0")]
	public bool GKDAOIMBAHJ(TKey FOJIGKKHICE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3A4EA10", Offset = "0x3A4DE10", VA = "0x183A4EA10")]
	private TVal JLHLNIPLDNM(TKey GKFBFMGIFOF)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3A4DAF0", Offset = "0x3A4CEF0", VA = "0x183A4DAF0", Slot = "6")]
	public virtual bool GAMCGCGFADK(TKey GKFBFMGIFOF, out TVal IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3A4CF60", Offset = "0x3A4C360", VA = "0x183A4CF60", Slot = "7")]
	public virtual void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3A4F7A0", Offset = "0x3A4EBA0", VA = "0x183A4F7A0")]
	private bool MKBNDKAOJIO(JHKEHGLLCCB PBBEIIGMMFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3A4E100", Offset = "0x3A4D500", VA = "0x183A4E100")]
	private void HLJFDHMIDMO(LinkedListNode<JHKEHGLLCCB> GGDLENCNLDM, TVal NDKJFJECHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3A4FFD0", Offset = "0x3A4F3D0", VA = "0x183A4FFD0")]
	private void NLLNELGPFFC(TKey FOJIGKKHICE, TVal IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3A4F540", Offset = "0x3A4E940", VA = "0x183A4F540")]
	private void MJLHDANCJJF(JHKEHGLLCCB PBBEIIGMMFD, TVal NDKJFJECHPC, int OOJCGOEDBOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
public class FGLOAFCAHBH<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> MOBONMBAIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> PDKBLOGAKEO;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1FAEDA0", Offset = "0x1FAE1A0", VA = "0x181FAEDA0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool DMJNBBKFGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1BAA7E0", Offset = "0x1BA9BE0", VA = "0x181BAA7E0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x25C3CF0", Offset = "0x25C30F0", VA = "0x1825C3CF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x25C3310", Offset = "0x25C2710", VA = "0x1825C3310", Slot = "11")]
	public void Add(T BKADPMHNDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x25C3650", Offset = "0x25C2A50", VA = "0x1825C3650")]
	public bool INCCOKIDJLO(T BKADPMHNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x25C3B90", Offset = "0x25C2F90", VA = "0x1825C3B90", Slot = "15")]
	public bool Remove(T BKADPMHNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x25C35D0", Offset = "0x25C29D0", VA = "0x1825C35D0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x20B9860", Offset = "0x20B8C60", VA = "0x1820B9860", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x25C34E0", Offset = "0x25C28E0", VA = "0x1825C34E0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x25C3540", Offset = "0x25C2940", VA = "0x1825C3540", Slot = "13")]
	public bool Contains(T BKADPMHNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x25C3570", Offset = "0x25C2970", VA = "0x1825C3570", Slot = "14")]
	public void CopyTo(T[] ICPECNGAFCL, int LMNNOEJODCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x25C37A0", Offset = "0x25C2BA0", VA = "0x1825C37A0", Slot = "6")]
	public int IndexOf(T BKADPMHNDEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x25C37D0", Offset = "0x25C2BD0", VA = "0x1825C37D0", Slot = "7")]
	public void Insert(int HMJKJGLHFKE, T BKADPMHNDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x25C3A30", Offset = "0x25C2E30", VA = "0x1825C3A30", Slot = "8")]
	public void RemoveAt(int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x25C3340", Offset = "0x25C2740", VA = "0x1825C3340")]
	public void CEPJALHNIFG(Predicate<T> ECIPILDKLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x25C35A0", Offset = "0x25C29A0", VA = "0x1825C35A0")]
	public void FPPNDNHICGI(Comparison<T> FEOOJDIDFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x25C3C10", Offset = "0x25C3010", VA = "0x1825C3C10")]
	public FGLOAFCAHBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class CGKHPFMENGG
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A350", Offset = "0x5F69750", VA = "0x185F6A350")]
	public static Vector3 FANKKEOOMLD(this GameObject FLFBOHHHJJB, float EPDPNMFAHGM)
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
			[Cpp2IlInjected.Address(RVA = "0x3015210", Offset = "0x3014610", VA = "0x183015210")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5F727C0", Offset = "0x5F71BC0", VA = "0x185F727C0")]
		public SerializedGuid(in Guid NOCBJPFIBOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5F72540", Offset = "0x5F71940", VA = "0x185F72540")]
		public static SerializedGuid KIFBJPGLCPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5F725D0", Offset = "0x5F719D0", VA = "0x185F725D0")]
		public static SerializedGuid OGDKDMGECNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5F722E0", Offset = "0x5F716E0", VA = "0x185F722E0")]
		public bool BOLKCDBAAGN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5F72700", Offset = "0x5F71B00", VA = "0x185F72700", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5F72660", Offset = "0x5F71A60", VA = "0x185F72660", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5F72730", Offset = "0x5F71B30", VA = "0x185F72730")]
		public bool PNCPEDMHILH(in Guid NOCBJPFIBOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5F723A0", Offset = "0x5F717A0", VA = "0x185F723A0", Slot = "7")]
		public bool Equals(SerializedGuid EPJIAIAEMFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5F72450", Offset = "0x5F71850", VA = "0x185F72450", Slot = "0")]
		public override bool Equals(object JLBINKLPHKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5F72530", Offset = "0x5F71930", VA = "0x185F72530", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5F72370", Offset = "0x5F71770", VA = "0x185F72370", Slot = "6")]
		public int CompareTo(SerializedGuid EPJIAIAEMFF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class ABDDIPIDJND : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type BNPGDPGIGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string HEMNCBIAGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool HNBFJOHCCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool MLLIIBMPOMD;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5F693A0", Offset = "0x5F687A0", VA = "0x185F693A0")]
	public ABDDIPIDJND(Type PDEGBIJGLHH, string NBEKHFNCECL, bool FGJANHDJALL = false, bool GNLMCNCBGPD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface IMBAJKEPNIA
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface GBKEBFFOAMH<T> : IMBAJKEPNIA
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T KGOGAJOHGBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool CDKABAOHNMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string OFJLLDFCGJC
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
	global::GBKEBFFOAMH<T> KPEPCJLDNFG(Action<T> OGFLFJNGDMC);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::GBKEBFFOAMH<T> DNJLKJMBJAJ(Action<T> OGFLFJNGDMC);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::GBKEBFFOAMH<T> NFCDGDBPHJJ(Action<T, T> PMPCPMNEBPA);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::GBKEBFFOAMH<T> GFDJKANIACE(Action<T, T> PMPCPMNEBPA);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::GBKEBFFOAMH<T> AGNMPAIGAEB(Action<string> DKEKCCKDOLE);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::GBKEBFFOAMH<T> IHNBFNIDGMG(Action<string> DKEKCCKDOLE);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class IMGFJFICJMM<T> : global::GBKEBFFOAMH<T>, IMBAJKEPNIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::IANNIOIAEJN<T, T> IAFDGLIGFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::DJLAHHEMKBC<T> ALFJLKKOHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::DJLAHHEMKBC<string> JFDONPJPEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string CIMKHIELLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T MHKNFNJAIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool IFLBHDGIFPH;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T KGOGAJOHGBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x68E6F0", Offset = "0x68DAF0", VA = "0x18068E6F0", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x1EFD060", Offset = "0x1EFC460", VA = "0x181EFD060", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool CDKABAOHNMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x743540", Offset = "0x742940", VA = "0x180743540", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string OFJLLDFCGJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6928E0", Offset = "0x691CE0", VA = "0x1806928E0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x1EFCC40", Offset = "0x1EFC040", VA = "0x181EFCC40", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x1EFCE30", Offset = "0x1EFC230", VA = "0x181EFCE30")]
	private void JLPLCBKLHLI(T NEIPJLDAIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x1EFCF60", Offset = "0x1EFC360", VA = "0x181EFCF60")]
	private void NBHAACHCECH(string KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x1EFCC70", Offset = "0x1EFC070", VA = "0x181EFCC70")]
	public void DKMEPNBBIOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x1EFD010", Offset = "0x1EFC410", VA = "0x181EFD010", Slot = "6")]
	public global::GBKEBFFOAMH<T> NFCDGDBPHJJ(Action<T, T> PMPCPMNEBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x1EFCD70", Offset = "0x1EFC170", VA = "0x181EFCD70", Slot = "7")]
	public global::GBKEBFFOAMH<T> GFDJKANIACE(Action<T, T> PMPCPMNEBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x1EFCED0", Offset = "0x1EFC2D0", VA = "0x181EFCED0", Slot = "4")]
	public global::GBKEBFFOAMH<T> KPEPCJLDNFG(Action<T> PMPCPMNEBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x1EFCD20", Offset = "0x1EFC120", VA = "0x181EFCD20", Slot = "5")]
	public global::GBKEBFFOAMH<T> DNJLKJMBJAJ(Action<T> OGFLFJNGDMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x1EFCBA0", Offset = "0x1EFBFA0", VA = "0x181EFCBA0", Slot = "8")]
	public global::GBKEBFFOAMH<T> AGNMPAIGAEB(Action<string> DKEKCCKDOLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1EFCDC0", Offset = "0x1EFC1C0", VA = "0x181EFCDC0", Slot = "9")]
	public global::GBKEBFFOAMH<T> IHNBFNIDGMG(Action<string> DKEKCCKDOLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1EFD090", Offset = "0x1EFC490", VA = "0x181EFD090")]
	public IMGFJFICJMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class CAGJMJFPIKH
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class PEMMNEHOPJK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::GBKEBFFOAMH<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::AHANDFLOFLD<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public PEMMNEHOPJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x28DFB50", Offset = "0x28DEF50", VA = "0x1828DFB50")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2702080", Offset = "0x2701480", VA = "0x182702080")]
	public static global::JENPMPFICOP<T> GKJHPELBGMO<T>(this global::GBKEBFFOAMH<T> MMPPFPEAPHI, Action<T> MCFINHLOBAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class DGKJHGKIMMO<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public readonly struct FGGJIAIMKFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long CFDEGGGMMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long ANGHPGOALEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int MEMGCJOPIBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int DMNOOKKPHAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool BAAIBOLHHOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string AIOIJCLKGCN;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x253C010", Offset = "0x253B410", VA = "0x18253C010")]
		public FGGJIAIMKFN(long CFDEGGGMMGE, int MEMGCJOPIBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x253C080", Offset = "0x253B480", VA = "0x18253C080")]
		public FGGJIAIMKFN(long CFDEGGGMMGE, long ANGHPGOALEH, int MEMGCJOPIBP, int DMNOOKKPHAB, bool BAAIBOLHHOO, string AIOIJCLKGCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x253BEE0", Offset = "0x253B2E0", VA = "0x18253BEE0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void GGHJLDPGFJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x253BF50", Offset = "0x253B350", VA = "0x18253BF50")]
		public int IBNAGCGLOCB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x253BEC0", Offset = "0x253B2C0", VA = "0x18253BEC0")]
		public int CBFPCMBLPPI(int FDCKIBDAFIH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x253BFA0", Offset = "0x253B3A0", VA = "0x18253BFA0")]
		public double MMCGCDGGGNL()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x253BE30", Offset = "0x253B230", VA = "0x18253BE30")]
		public FGGJIAIMKFN AIOEEEPBOCE(long ANGHPGOALEH, int DMNOOKKPHAB)
		{
			return default(FGGJIAIMKFN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class IKIBJCADMMP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey HJIIJNBEIGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::DGKJHGKIMMO<TKey> ANOJNPAHJKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<IKIBJCADMMP> GGNNKEJKNIH;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string DBAFFHNJKCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x1EF7A00", Offset = "0x1EF6E00", VA = "0x181EF7A00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x1EF9830", Offset = "0x1EF8C30", VA = "0x181EF9830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<IKIBJCADMMP> BACNDKNLMGG
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x1EF9700", Offset = "0x1EF8B00", VA = "0x181EF9700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public FGGJIAIMKFN KJBOJALIHCO
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x16BA6A0", Offset = "0x16B9AA0", VA = "0x1816BA6A0")]
			[CompilerGenerated]
			get
			{
				return default(FGGJIAIMKFN);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x1EF9800", Offset = "0x1EF8C00", VA = "0x181EF9800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1EF9860", Offset = "0x1EF8C60", VA = "0x181EF9860")]
		internal IKIBJCADMMP(global::DGKJHGKIMMO<TKey> ANOJNPAHJKB, TKey FOJIGKKHICE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1EF95F0", Offset = "0x1EF89F0", VA = "0x181EF95F0")]
		public IKIBJCADMMP EIKLLAJANFC(TKey FOJIGKKHICE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1EF9720", Offset = "0x1EF8B20", VA = "0x181EF9720")]
		public void HODGKBOIDOM(TKey FOJIGKKHICE, Action<IKIBJCADMMP> LECDCDLGAEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x23E5040", Offset = "0x23E4440", VA = "0x1823E5040")]
		public T HODGKBOIDOM<T>(TKey FOJIGKKHICE, Func<IKIBJCADMMP, T> JLCMJEMLFDK)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x23E4ED0", Offset = "0x23E42D0", VA = "0x1823E4ED0")]
		[AsyncStateMachine(typeof(PGCLDOEHLLG))]
		public Task<T> ALAPMMHDMLF<T>(TKey FOJIGKKHICE, Func<IKIBJCADMMP, Task<T>> JLCMJEMLFDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x1EF9440", Offset = "0x1EF8840", VA = "0x181EF9440", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class MNKEPDEBAHG : IEnumerable<(TKey, List<TKey>, FGGJIAIMKFN)>, IEnumerable, IEnumerator<(TKey, List<TKey>, FGGJIAIMKFN)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, FGGJIAIMKFN timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::DGKJHGKIMMO<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, FGGJIAIMKFN timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, FGGJIAIMKFN) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x1BA1EA0", Offset = "0x1BA12A0", VA = "0x181BA1EA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, FGGJIAIMKFN));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x29D41E0", Offset = "0x29D35E0", VA = "0x1829D41E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x1BA22A0", Offset = "0x1BA16A0", VA = "0x181BA22A0")]
		[DebuggerHidden]
		public MNKEPDEBAHG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x29D4240", Offset = "0x29D3640", VA = "0x1829D4240", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x29D3E30", Offset = "0x29D3230", VA = "0x1829D3E30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x29D42A0", Offset = "0x29D36A0", VA = "0x1829D42A0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x29D41A0", Offset = "0x29D35A0", VA = "0x1829D41A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x29D40E0", Offset = "0x29D34E0", VA = "0x1829D40E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, FGGJIAIMKFN)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1BA1ED0", Offset = "0x1BA12D0", VA = "0x181BA1ED0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class MBGHIBGAGPM : IEnumerable<(TKey, List<TKey>, FGGJIAIMKFN)>, IEnumerable, IEnumerator<(TKey, List<TKey>, FGGJIAIMKFN)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, FGGJIAIMKFN timerEntry) <>2__current;

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
		private IKIBJCADMMP timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public IKIBJCADMMP <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::DGKJHGKIMMO<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<IKIBJCADMMP> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, FGGJIAIMKFN timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, FGGJIAIMKFN) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x1BA1EA0", Offset = "0x1BA12A0", VA = "0x181BA1EA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, FGGJIAIMKFN));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x3B5AAC0", Offset = "0x3B59EC0", VA = "0x183B5AAC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1BA22A0", Offset = "0x1BA16A0", VA = "0x181BA22A0")]
		[DebuggerHidden]
		public MBGHIBGAGPM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3B5AB20", Offset = "0x3B59F20", VA = "0x183B5AB20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3B5A400", Offset = "0x3B59800", VA = "0x183B5A400", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3B5ABC0", Offset = "0x3B59FC0", VA = "0x183B5ABC0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3B5AC20", Offset = "0x3B5A020", VA = "0x183B5AC20")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3B5AA80", Offset = "0x3B59E80", VA = "0x183B5AA80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3B5A9A0", Offset = "0x3B59DA0", VA = "0x183B5A9A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, FGGJIAIMKFN)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x374EC80", Offset = "0x374E080", VA = "0x18374EC80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, FGGJIAIMKFN> NOEIMHCNJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, FGGJIAIMKFN> NPEIKGCIECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::DGKJHGKIMMO<TKey>> HBGGGBBOCJI;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string LDBNDAEANOL = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly IKIBJCADMMP ICLGCDNEEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool DAIKPAIAHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int HOJGKGOLOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch PBKGENHMNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int PNJJKLMJBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string NEFGFBMGHOM;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public IKIBJCADMMP IOHIKBHIFHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6928E0", Offset = "0x691CE0", VA = "0x1806928E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string DBAFFHNJKCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6780D0", Offset = "0x6774D0", VA = "0x1806780D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x28004B0", Offset = "0x27FF8B0", VA = "0x1828004B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long DJKGILGPIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x2800490", Offset = "0x27FF890", VA = "0x182800490")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int MHHHBBFFJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x28003C0", Offset = "0x27FF7C0", VA = "0x1828003C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2800510", Offset = "0x27FF910", VA = "0x182800510")]
	public DGKJHGKIMMO(TKey EBBONOJNAAE, [Optional] int? MEMGCJOPIBP, [Optional][CanBeNull] Stopwatch PBKGENHMNJP, [Optional] Action<TKey, FGGJIAIMKFN> NOEIMHCNJHO, [Optional] Action<TKey, FGGJIAIMKFN> NPEIKGCIECD, [Optional] Action<global::DGKJHGKIMMO<TKey>> HBGGGBBOCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x2800330", Offset = "0x27FF730", VA = "0x182800330", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2800310", Offset = "0x27FF710", VA = "0x182800310")]
	public void DELKNCOMIBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x28003F0", Offset = "0x27FF7F0", VA = "0x1828003F0")]
	public void HPNNPFACEPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2800280", Offset = "0x27FF680", VA = "0x182800280")]
	[IteratorStateMachine(typeof(global::DGKJHGKIMMO<>.MNKEPDEBAHG))]
	public IEnumerable<(TKey, List<TKey>, FGGJIAIMKFN)> BLHHOLKMKKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x28001B0", Offset = "0x27FF5B0", VA = "0x1828001B0")]
	[IteratorStateMachine(typeof(global::DGKJHGKIMMO<>.MBGHIBGAGPM))]
	private IEnumerable<(TKey, List<TKey>, FGGJIAIMKFN)> BLHHOLKMKKP(List<TKey> GKBEAKNFHBF, IKIBJCADMMP MNPNNOIIOOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x2800410", Offset = "0x27FF810", VA = "0x182800410")]
	private (long, int) LPCHNENOGLG()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class MGDNPONJLGI<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut GPOBGFKHBGD(global::DGKJHGKIMMO<TKey> ANOJNPAHJKB);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
	protected MGDNPONJLGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class HLKCGDHPGBP<TKey> : global::MGDNPONJLGI<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate string JHFOHKGAAIP(TKey FOJIGKKHICE);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B1F0", Offset = "0x2A4A5F0", VA = "0x182A4B1F0")]
	protected string HNIDJEGIMCO(double LPFLILNIGOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2A4AF70", Offset = "0x2A4A370", VA = "0x182A4AF70")]
	protected string DEBPJBOCKLA(int JAIMNCNOAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B1B0", Offset = "0x2A4A5B0", VA = "0x182A4B1B0")]
	private static string HGDFDEOAEIN(TKey FOJIGKKHICE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B100", Offset = "0x2A4A500", VA = "0x182A4B100", Slot = "4")]
	public override string GPOBGFKHBGD(global::DGKJHGKIMMO<TKey> ANOJNPAHJKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2A4AFD0", Offset = "0x2A4A3D0", VA = "0x182A4AFD0")]
	public string GPOBGFKHBGD(global::DGKJHGKIMMO<TKey> ANOJNPAHJKB, [NotNull] JHFOHKGAAIP IGFABKJHECM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string KEECJODINJB(global::DGKJHGKIMMO<TKey> ANOJNPAHJKB, [NotNull] JHFOHKGAAIP IGFABKJHECM);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x1BB0730", Offset = "0x1BAFB30", VA = "0x181BB0730")]
	protected HLKCGDHPGBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class EIMCENNJNCC<TKey> : global::MGDNPONJLGI<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate string LDCFFICHMBL(TKey FOJIGKKHICE);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int JECNOALPAEP = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string KBMFIBGLIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double ANKALBCEHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool NCJKENBLFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int LNLPFFBMCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> FAFFEGPDALJ;

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x24423F0", Offset = "0x24417F0", VA = "0x1824423F0")]
	private static string HGDFDEOAEIN(TKey FOJIGKKHICE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2442840", Offset = "0x2441C40", VA = "0x182442840")]
	public EIMCENNJNCC(string KBMFIBGLIAL = "F2", double ANKALBCEHEF = double.MaxValue, bool NCJKENBLFGN = false, int LNLPFFBMCMF = int.MaxValue, [Optional] ISet<string> FAFFEGPDALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2442340", Offset = "0x2441740", VA = "0x182442340", Slot = "4")]
	public override Dictionary<string, string> GPOBGFKHBGD(global::DGKJHGKIMMO<TKey> ANOJNPAHJKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2442760", Offset = "0x2441B60", VA = "0x182442760")]
	private bool NNOLPJNGBAK(string PCAMJMEHHCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2441E00", Offset = "0x2441200", VA = "0x182441E00")]
	public Dictionary<string, string> GPOBGFKHBGD(global::DGKJHGKIMMO<TKey> ANOJNPAHJKB, LDCFFICHMBL IGFABKJHECM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x24425B0", Offset = "0x24419B0", VA = "0x1824425B0")]
	private string LMNDOBKAOHP(StringBuilder GNIMPBCPEOM, List<TKey> MPEFCEKBAGE, LDCFFICHMBL IGFABKJHECM, bool KNIHCCIOFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2442430", Offset = "0x2441830", VA = "0x182442430")]
	private static void KOGICCCGMKA(StringBuilder JEIMPDFAIAE, string GCDCKIAHGJO, bool EFCIBGMNIJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class PHJILNBLMPN<TKey> : global::HLKCGDHPGBP<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct MKFPADACBEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public JHFOHKGAAIP keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::PHJILNBLMPN<TKey> KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int NFGILCJKPJE = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] POGNKIAPNJE;

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x28EE830", Offset = "0x28EDC30", VA = "0x1828EE830")]
	private PHJILNBLMPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x28ED840", Offset = "0x28ECC40", VA = "0x1828ED840", Slot = "5")]
	protected override string KEECJODINJB(global::DGKJHGKIMMO<TKey> ANOJNPAHJKB, JHFOHKGAAIP IGFABKJHECM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x28ED750", Offset = "0x28ECB50", VA = "0x1828ED750")]
	[CompilerGenerated]
	internal static string EIEGMGKAPKC(string HNIIBGLILAO, TKey FOJIGKKHICE, ref MKFPADACBEL P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class OFKCHMCCINE<TKey> : global::HLKCGDHPGBP<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class LECLFOGPAOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public JHFOHKGAAIP keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public LECLFOGPAOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1D51D50", Offset = "0x1D51150", VA = "0x181D51D50")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x3A5B250", Offset = "0x3A5A650", VA = "0x183A5B250", Slot = "5")]
	protected override string KEECJODINJB(global::DGKJHGKIMMO<TKey> ANOJNPAHJKB, JHFOHKGAAIP IGFABKJHECM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x28E3730", Offset = "0x28E2B30", VA = "0x1828E3730")]
	public OFKCHMCCINE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public sealed class OPPGAGOMFPA : global::DGKJHGKIMMO<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class GLJPNNKAMDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<OPPGAGOMFPA> callback;

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public GLJPNNKAMDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5F6C250", Offset = "0x5F6B650", VA = "0x185F6C250")]
		internal void <Wrap>b__0(global::DGKJHGKIMMO<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5F70660", Offset = "0x5F6FA60", VA = "0x185F70660")]
	public OPPGAGOMFPA([Optional] string CKGHLMHPIFI, [Optional] int? MEMGCJOPIBP, [Optional] Stopwatch PBKGENHMNJP, [Optional] Action<string, FGGJIAIMKFN> NOEIMHCNJHO, [Optional] Action<string, FGGJIAIMKFN> NPEIKGCIECD, [Optional] Action<OPPGAGOMFPA> HBGGGBBOCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5F70580", Offset = "0x5F6F980", VA = "0x185F70580")]
	private static Action<global::DGKJHGKIMMO<string>> HODGKBOIDOM(Action<OPPGAGOMFPA> MCFINHLOBAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class EGDEKDJLFCB
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class LFJLANNNCIB : EGDEKDJLFCB
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static EGDEKDJLFCB KGKEDLDKCKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x5F6E440", Offset = "0x5F6D840", VA = "0x185F6E440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime MJJJONFECJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x5F6E4A0", Offset = "0x5F6D8A0", VA = "0x185F6E4A0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float NCAOKEEFNCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x5F6E4F0", Offset = "0x5F6D8F0", VA = "0x185F6E4F0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5F6E5A0", Offset = "0x5F6D9A0", VA = "0x185F6E5A0")]
		public LFJLANNNCIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static EGDEKDJLFCB FPNHAHFHHFA;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static EGDEKDJLFCB BKIMHMJINMC
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5F6B380", Offset = "0x5F6A780", VA = "0x185F6B380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime MJJJONFECJF
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float NCAOKEEFNCN
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	protected EGDEKDJLFCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class PBBFINGKAFC : global::FHCLJDPHPFN<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5F707B0", Offset = "0x5F6FBB0", VA = "0x185F707B0")]
	public PBBFINGKAFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class FHCLJDPHPFN<T> : global::HDJHLDKFKIP<T>, FDMOPFJCOHD, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> FKOGOBHBHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task MJKCMFAPEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x158D680", Offset = "0x158CA80", VA = "0x18158D680", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::JENPMPFICOP<T> NGHOAACJCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private JLFOFKFALKJ OKLJGIOAHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x20A4AF0", Offset = "0x20A3EF0", VA = "0x1820A4AF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x25C7990", Offset = "0x25C6D90", VA = "0x1825C7990")]
	public FHCLJDPHPFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class ECBFCBPKEPC : global::EHJPBKBELOC<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B330", Offset = "0x5F6A730", VA = "0x185F6B330")]
	public ECBFCBPKEPC(Exception PNJNNEOHMAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class EHJPBKBELOC<T> : global::HDJHLDKFKIP<T>, FDMOPFJCOHD, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> FKOGOBHBHBN
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task MJKCMFAPEIH
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x158D680", Offset = "0x158CA80", VA = "0x18158D680", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::JENPMPFICOP<T> NGHOAACJCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private JLFOFKFALKJ OKLJGIOAHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x20A4AF0", Offset = "0x20A3EF0", VA = "0x1820A4AF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2441600", Offset = "0x2440A00", VA = "0x182441600")]
	public EHJPBKBELOC(Exception PNJNNEOHMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface FDMOPFJCOHD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task FKOGOBHBHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	JLFOFKFALKJ NGHOAACJCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface HDJHLDKFKIP<T> : FDMOPFJCOHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> FKOGOBHBHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::JENPMPFICOP<T> NGHOAACJCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public abstract class HHICLGNEDEK<TTask, T> : global::HDJHLDKFKIP<T>, FDMOPFJCOHD, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class ENJBBGLMLAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public global::HHICLGNEDEK<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public ENJBBGLMLAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool OGHMGIBONMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> MPDGFCFNFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource KNPMPMKONCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool DAIKPAIAHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private SynchronizationContext HMDNCIIKGGE;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> FKOGOBHBHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task MJKCMFAPEIH
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::JENPMPFICOP<T> NGHOAACJCOE
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private JLFOFKFALKJ OKLJGIOAHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x20AD520", Offset = "0x20AC920", VA = "0x1820AD520", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool NMHLJFGMGOF
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x768F80", Offset = "0x768380", VA = "0x180768F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x2A36B70", Offset = "0x2A35F70", VA = "0x182A36B70")]
	static HHICLGNEDEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x2A37020", Offset = "0x2A36420", VA = "0x182A37020")]
	protected HHICLGNEDEK(TTask MPDGFCFNFOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x2A367D0", Offset = "0x2A35BD0", VA = "0x182A367D0", Slot = "1")]
	~HHICLGNEDEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x2A367A0", Offset = "0x2A35BA0", VA = "0x182A367A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x2A36840", Offset = "0x2A35C40", VA = "0x182A36840")]
	private void NPNFNKBABCO(bool KIKGMGHLHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T BGHDPLFANAD(TTask ILOCBKPHOMM);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void BOGFNOLILAO();

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x2A36B20", Offset = "0x2A35F20", VA = "0x182A36B20")]
	[CompilerGenerated]
	private void PBJJMFKAJJC(object CDDIFFKMAEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface PPBHKKGGKNA
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float GMEKFOLMDDO
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event LGDLELCMDMM JBMMGCLEDAA;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class FMIJFIJBOLP : PPBHKKGGKNA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public readonly struct BNMBKGBDPKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float DBNCCLOFLDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public readonly float KMOBBENPDFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		internal readonly bool EFFOACKHLFJ;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float HEHPNMDAHOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x5F6A080", Offset = "0x5F69480", VA = "0x185F6A080")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x5F6A210", Offset = "0x5F69610", VA = "0x185F6A210")]
		public BNMBKGBDPKP(float BKLFOLNGODN, float AJIMECHHNCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x5F6A090", Offset = "0x5F69490", VA = "0x185F6A090", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class BCPFJDDMMGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public FMIJFIJBOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public BCPFJDDMMGG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly int OAKAJHNNELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private int LKJGGJAHFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly PPBHKKGGKNA[] NOMNIFPKKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly LGDLELCMDMM[] GEEOPHADFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly BNMBKGBDPKP[] JDHAMKIGANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private BNMBKGBDPKP NCCJJKKKINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly MKNHLIJNJKP LIIFGGNDHCC;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public BNMBKGBDPKP PDMKAFNPNLG
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3380230", Offset = "0x337F630", VA = "0x183380230")]
		get
		{
			return default(BNMBKGBDPKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float GMEKFOLMDDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5F6BDF0", Offset = "0x5F6B1F0", VA = "0x185F6BDF0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event LGDLELCMDMM JBMMGCLEDAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5F6BBE0", Offset = "0x5F6AFE0", VA = "0x185F6BBE0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5F6BCA0", Offset = "0x5F6B0A0", VA = "0x185F6BCA0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BEB0", Offset = "0x5F6B2B0", VA = "0x185F6BEB0")]
	public FMIJFIJBOLP(int OAKAJHNNELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BD60", Offset = "0x5F6B160", VA = "0x185F6BD60")]
	public MKNHLIJNJKP MAIPBKPLEFF(BNMBKGBDPKP KMGJAAODLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B790", Offset = "0x5F6AB90", VA = "0x185F6B790")]
	public void HBIKFIJBBNG(PPBHKKGGKNA DFBFNAGMGCN, [Optional] BNMBKGBDPKP CLEDOBCKAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BE10", Offset = "0x5F6B210", VA = "0x185F6BE10")]
	internal int PIPJCOJIJLM(PPBHKKGGKNA GLFLGLFHEHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BE60", Offset = "0x5F6B260", VA = "0x185F6BE60")]
	internal BNMBKGBDPKP PMHJIHIFGMK(int HMJKJGLHFKE)
	{
		return default(BNMBKGBDPKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B600", Offset = "0x5F6AA00", VA = "0x185F6B600", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public delegate void LGDLELCMDMM(float AEAEDGLFDAP);
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal static class EHHCFMFLOIB
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	internal const float AOHGKIPCLMC = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class GJKMDGPCKHG
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private class BLMKOOBOEBM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly PPBHKKGGKNA GLFLGLFHEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly LGDLELCMDMM MCFINHLOBAO;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5F69FF0", Offset = "0x5F693F0", VA = "0x185F69FF0")]
		public BLMKOOBOEBM(PPBHKKGGKNA GLFLGLFHEHH, LGDLELCMDMM MCFINHLOBAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5F69FA0", Offset = "0x5F693A0", VA = "0x185F69FA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C110", Offset = "0x5F6B510", VA = "0x185F6C110")]
	internal static bool LILKEGPGOHB(float GHJDMBPGMHF, float IKDBBHHKFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x4A15890", Offset = "0x4A14C90", VA = "0x184A15890")]
	internal static float KCCPNDOCDBI(float GHJDMBPGMHF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C190", Offset = "0x5F6B590", VA = "0x185F6C190")]
	public static IDisposable OHBGIANDAMP(this PPBHKKGGKNA GLFLGLFHEHH, LGDLELCMDMM MCFINHLOBAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class MKNHLIJNJKP : PPBHKKGGKNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float AEAEDGLFDAP;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float GMEKFOLMDDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x1030690", Offset = "0x102FA90", VA = "0x181030690", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x5F6E930", Offset = "0x5F6DD30", VA = "0x185F6E930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event LGDLELCMDMM JBMMGCLEDAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x5F6E9F0", Offset = "0x5F6DDF0", VA = "0x185F6E9F0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x5F6EA90", Offset = "0x5F6DE90", VA = "0x185F6EA90", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public MKNHLIJNJKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class BGOEFKANHKB
{
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5F69E10", Offset = "0x5F69210", VA = "0x185F69E10")]
	[NotNull]
	public static byte[] EKDBBIGPOKB(this LCOBBBOEKKP MAAIJDLNODJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5F69DA0", Offset = "0x5F691A0", VA = "0x185F69DA0")]
	[NotNull]
	public static byte[] EKDBBIGPOKB(this LCOBBBOEKKP MAAIJDLNODJ, HashAlgorithmName MOPOAOMAMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5F69C10", Offset = "0x5F69010", VA = "0x185F69C10")]
	public static bool DFONLJPAPNG([CanBeNull] this LCOBBBOEKKP MAAIJDLNODJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5F69A70", Offset = "0x5F68E70", VA = "0x185F69A70")]
	public static bool DFONLJPAPNG([CanBeNull] this LCOBBBOEKKP MAAIJDLNODJ, out string CIMKHIELLCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5F69A00", Offset = "0x5F68E00", VA = "0x185F69A00")]
	private static string DDDNHKLAEFF([CanBeNull] byte[] EEMDNKKFCBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5F69E80", Offset = "0x5F69280", VA = "0x185F69E80")]
	private static bool HIIFNMCCELP([NotNull] LCOBBBOEKKP MAAIJDLNODJ, [CanBeNull] out byte[] BADKNGODHLN, [CanBeNull] out byte[] BHKBJBMKBCJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class IDCLDLIBHFD
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C3A0", Offset = "0x5F6B7A0", VA = "0x185F6C3A0")]
	[NotNull]
	public static byte[] EKDBBIGPOKB(this MJLFMLIJBDB IOLNABLCPAK, byte[] OJGEGDKAEDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C3E0", Offset = "0x5F6B7E0", VA = "0x185F6C3E0")]
	[NotNull]
	public static byte[] EKDBBIGPOKB(this MJLFMLIJBDB IOLNABLCPAK, HashAlgorithmName MOPOAOMAMEP, byte[] OJGEGDKAEDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface MJLFMLIJBDB
{
	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash BMNGMMBLJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface LCOBBBOEKKP : MJLFMLIJBDB
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] AGLPHENECBI
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
	byte[] FLIJIEJFIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object OBFGOCKBAAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class NKPCCJPKIII
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private class LJFKBJGPBPD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x5F6E7B0", Offset = "0x5F6DBB0", VA = "0x185F6E7B0")]
		public LJFKBJGPBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5F6E750", Offset = "0x5F6DB50", VA = "0x185F6E750", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte OEBMJEEOFNL = 1;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private const byte BMJBHDJNJJL = 0;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly ArrayPool<byte> AIBPDGIFCJN;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static bool GEHMALLDKKE;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x30DEA10", Offset = "0x30DDE10", VA = "0x1830DEA10")]
	[Conditional("UNITY_EDITOR")]
	private static void AJKIGNLNOJD<T>(params T[] EKNHODFNHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5F6FA00", Offset = "0x5F6EE00", VA = "0x185F6FA00")]
	public static IDisposable MNJIDEANIJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x5F6EFB0", Offset = "0x5F6E3B0", VA = "0x185F6EFB0")]
	public static void EBLMGLJAHFH(this IncrementalHash ECNGOPCGGEO, [CanBeNull] GameObject FLFBOHHHJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x30DF3F0", Offset = "0x30DE7F0", VA = "0x1830DF3F0")]
	public static void EBLMGLJAHFH<T>(this IncrementalHash ECNGOPCGGEO, [CanBeNull] T HEKOHKDELMN) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x30DF4C0", Offset = "0x30DE8C0", VA = "0x1830DF4C0")]
	public static void IPCOGOMOFJD<T>(this IncrementalHash ECNGOPCGGEO, [CanBeNull] T IOLNABLCPAK) where T : MJLFMLIJBDB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x30DF550", Offset = "0x30DE950", VA = "0x1830DF550")]
	public static void JALCMHPPAOA<T>(this IncrementalHash ECNGOPCGGEO, [CanBeNull] IList<T> JNAIGPNNHIO) where T : MJLFMLIJBDB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5F6FB00", Offset = "0x5F6EF00", VA = "0x185F6FB00")]
	private static bool ONFLNGGOKKO([CanBeNull] MJLFMLIJBDB IOLNABLCPAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5F6F7E0", Offset = "0x5F6EBE0", VA = "0x185F6F7E0")]
	public static void KCPMGAPPDHN(this IncrementalHash BMNGMMBLJFF, [CanBeNull] string OEHLBFDKEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5F6F440", Offset = "0x5F6E840", VA = "0x185F6F440")]
	public static void JCFCHGDLHNB(this IncrementalHash BMNGMMBLJFF, long MLFLDFHOPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5F6F210", Offset = "0x5F6E610", VA = "0x185F6F210")]
	public static void FBPHDCJFABF(this IncrementalHash BMNGMMBLJFF, int MPBKNKDCOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5F6ED00", Offset = "0x5F6E100", VA = "0x185F6ED00")]
	public static void APBKOLLBHAC(this IncrementalHash BMNGMMBLJFF, short ELGMJDBMGDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5F6F670", Offset = "0x5F6EA70", VA = "0x185F6F670")]
	public static void JPAMNJMIACL(this IncrementalHash BMNGMMBLJFF, byte DIODIEFGDEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F6EB30", Offset = "0x5F6DF30", VA = "0x185F6EB30")]
	public static void AFADCJGCCBO(this IncrementalHash BMNGMMBLJFF, bool GEHMPJPMKLB, bool FFLKMENACHD = false, bool IJOMDLBOEAC = false, bool LAGEDOPJHHC = false, bool FPOAKEMMOGN = false, bool DPAMMJHAGPO = false, bool KAPDLMGBAIH = false, bool AHAFKJENLIA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x30DED00", Offset = "0x30DE100", VA = "0x1830DED00")]
	public static void BOHCOIPHPFJ<T>(this IncrementalHash BMNGMMBLJFF, T HAEFIAIKANL) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5F6FAA0", Offset = "0x5F6EEA0", VA = "0x185F6FAA0")]
	public static void OAODFLADDPA(this IncrementalHash BMNGMMBLJFF, float HOLNDPJGMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5F6F3E0", Offset = "0x5F6E7E0", VA = "0x185F6F3E0")]
	public static void GAFKOOKGDAB(this IncrementalHash BMNGMMBLJFF, double EKJDFBHEIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5F6EED0", Offset = "0x5F6E2D0", VA = "0x185F6EED0")]
	public static void CNJCCPPDLNO(this IncrementalHash BMNGMMBLJFF, ulong NJDIIEIHCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5F6F610", Offset = "0x5F6EA10", VA = "0x185F6F610")]
	public static void JEPNCACCELD(this IncrementalHash BMNGMMBLJFF, uint GKEMFFDOGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5F6EF40", Offset = "0x5F6E340", VA = "0x185F6EF40")]
	public static void DCPDHLKBAKI(this IncrementalHash BMNGMMBLJFF, ushort NCBCGIAGEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5F6F0A0", Offset = "0x5F6E4A0", VA = "0x185F6F0A0")]
	public static void EKIGPDKJFPO(this IncrementalHash BMNGMMBLJFF, Vector3 KBJMANOIEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5F6F840", Offset = "0x5F6EC40", VA = "0x185F6F840")]
	public static void MDDLFAMLHNI(this IncrementalHash BMNGMMBLJFF, Quaternion IEOLEMGOKFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class HACEFJMEJGG : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly Type BNPGDPGIGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly string HEMNCBIAGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly bool HNBFJOHCCDH;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C340", Offset = "0x5F6B740", VA = "0x185F6C340")]
	public HACEFJMEJGG(Type PDEGBIJGLHH, string NBEKHFNCECL, bool FGJANHDJALL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class OEMCBDDKLAA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5F70350", Offset = "0x5F6F750", VA = "0x185F70350")]
	public OEMCBDDKLAA(string KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5F702D0", Offset = "0x5F6F6D0", VA = "0x185F702D0")]
	public OEMCBDDKLAA(string KAKCNEMJMJL, Exception GKFIKAGHEFN)
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
			[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677440", VA = "0x180678040")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x68E790", Offset = "0x68DB90", VA = "0x18068E790")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int FNHGJOONKOH, int BIDLLBKLLJN]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x364CF40", Offset = "0x364C340", VA = "0x18364CF40")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x364CFE0", Offset = "0x364C3E0", VA = "0x18364CFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x364CEB0", Offset = "0x364C2B0", VA = "0x18364CEB0")]
		public Array2D(uint HGELIJGMFCF, uint INLFDHDPLNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x364CE30", Offset = "0x364C230", VA = "0x18364CE30")]
		public void BNMOGLEIOOC()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5F69910", Offset = "0x5F68D10", VA = "0x185F69910")]
		public Array2DVector3(uint HGELIJGMFCF, uint INLFDHDPLNM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal static class KFIOCJEIOIM
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public const int CHNGKMENIJL = -1;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public const int OJCLFAPCOHF = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[DefaultMember("Item")]
public class HBNFHFECEEB<THandle, TValue> : IDisposable where THandle : struct, PIEOKMGFPCE where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly List<THandle> LMBGEPHNCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly List<TValue> LKAPNLFPHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly Func<TValue> AMPEPJLNAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly Action<TValue> ANOPLPLFGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int PDEPIGCMKBK;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x29D3470", Offset = "0x29D2870", VA = "0x1829D3470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6D90", Offset = "0x2FC6190", VA = "0x182FC6D90")]
	public HBNFHFECEEB(Action<TValue> ANOPLPLFGPN, [Optional] Func<TValue> AMPEPJLNAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6340", Offset = "0x2FC5740", VA = "0x182FC6340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2FC64A0", Offset = "0x2FC58A0", VA = "0x182FC64A0")]
	public THandle FNICMNFMKAL()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6210", Offset = "0x2FC5610", VA = "0x182FC6210")]
	public THandle AKBMAMDKLNI(TValue IGDJJEECDAF)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2FC65E0", Offset = "0x2FC59E0", VA = "0x182FC65E0")]
	public bool GKDAOIMBAHJ(THandle CPAMCPHEBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6BB0", Offset = "0x2FC5FB0", VA = "0x182FC6BB0")]
	public bool NPMFLDOJCPB(THandle CPAMCPHEBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6770", Offset = "0x2FC5B70", VA = "0x182FC6770")]
	public bool HIJHOGNBHHL(THandle CPAMCPHEBME, out TValue IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2FC68E0", Offset = "0x2FC5CE0", VA = "0x182FC68E0")]
	public TValue JLHLNIPLDNM(THandle CPAMCPHEBME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2FC66C0", Offset = "0x2FC5AC0", VA = "0x182FC66C0")]
	public bool HGNKBEMEDCJ(THandle CPAMCPHEBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6970", Offset = "0x2FC5D70", VA = "0x182FC6970")]
	private THandle JNPMIEMLGLC(int HMJKJGLHFKE)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6690", Offset = "0x2FC5A90", VA = "0x182FC6690")]
	private TValue GKJHPELBGMO(int HMJKJGLHFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x2FC63C0", Offset = "0x2FC57C0", VA = "0x182FC63C0")]
	private void ECFOPCLNHCI(int HMJKJGLHFKE, in THandle CPAMCPHEBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6930", Offset = "0x2FC5D30", VA = "0x182FC6930")]
	private void JLPLCBKLHLI(int HMJKJGLHFKE, in TValue IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6C80", Offset = "0x2FC6080", VA = "0x182FC6C80")]
	private THandle PPPDPKDLFDF()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6280", Offset = "0x2FC5680", VA = "0x182FC6280")]
	private void BLFODPHDILK(THandle CPAMCPHEBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6330", Offset = "0x2FC5730", VA = "0x182FC6330")]
	private int CMDLDIAOPEF(int FMCKDMNHLLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2FC69A0", Offset = "0x2FC5DA0", VA = "0x182FC69A0")]
	private bool KGDIGLOIOLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6DF640", Offset = "0x6DEA40", VA = "0x1806DF640")]
	private void EDOMGIMBNHP(THandle CPAMCPHEBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6A10", Offset = "0x2FC5E10", VA = "0x182FC6A10")]
	private bool MABILLOACMG(out THandle CPAMCPHEBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6810", Offset = "0x2FC5C10", VA = "0x182FC6810")]
	private bool IBJDHFNHPMB(out THandle CPAMCPHEBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2FC69B0", Offset = "0x2FC5DB0", VA = "0x182FC69B0")]
	private void KMFOIGNHLFO(THandle CPAMCPHEBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6A90", Offset = "0x2FC5E90", VA = "0x182FC6A90")]
	private void NOOOALPCDDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface PIEOKMGFPCE
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int IJHDILKKDIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int BBEGHBAAMGP
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
public interface GPFPNOKLPCO<T> : PIEOKMGFPCE, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class JGDJFDFLMBC
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0xD9DDE0", Offset = "0xD9D1E0", VA = "0x180D9DDE0")]
	public static bool BDEJBDLOPPE<T>(this T CPAMCPHEBME, T EPJIAIAEMFF) where T : struct, PIEOKMGFPCE
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x2D10070", Offset = "0x2D0F470", VA = "0x182D10070")]
	public static bool EFFOACKHLFJ<T>(this T CPAMCPHEBME) where T : struct, PIEOKMGFPCE
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5F6CFE0", Offset = "0x5F6C3E0", VA = "0x185F6CFE0")]
	public static string CODEJGKFDIL(this PIEOKMGFPCE CPAMCPHEBME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class KMMJGEOECJD
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private enum DJKADGODNPG : byte
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
	private int BMNGMMBLJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private bool EBFHLAHMIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private DJKADGODNPG OHACFAMPHAM;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool PIHAGFGPKDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5F6D410", Offset = "0x5F6C810", VA = "0x185F6D410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool HKOOEPNCGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5F6DEF0", Offset = "0x5F6D2F0", VA = "0x185F6DEF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E0F0", Offset = "0x5F6D4F0", VA = "0x185F6E0F0")]
	public KMMJGEOECJD(bool EBFHLAHMIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D420", Offset = "0x5F6C820", VA = "0x185F6D420")]
	public void ELIEGAFCGJE(object JLBINKLPHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D2C0", Offset = "0x5F6C6C0", VA = "0x185F6D2C0")]
	public void CIHFLFFDHOL(int IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x5F6DF90", Offset = "0x5F6D390", VA = "0x185F6DF90")]
	public void LNIANLNAOPA(uint OLNHBOCBHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E0D0", Offset = "0x5F6D4D0", VA = "0x185F6E0D0")]
	public void PJABLOLOBIK(bool PPICNJEPCDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D360", Offset = "0x5F6C760", VA = "0x185F6D360")]
	public void DHLKCNGGNIO(long GFGCCMPKPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D200", Offset = "0x5F6C600", VA = "0x185F6D200")]
	public void AKPDBCFPFKJ(ulong JKIDPIMHFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D240", Offset = "0x5F6C640", VA = "0x185F6D240")]
	public void ANHINHOBHPG(string IFGCPKEMIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5F6DF00", Offset = "0x5F6D300", VA = "0x185F6DF00")]
	public void LHILMKDHGIG(Enum PNJNNEOHMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5F6DFA0", Offset = "0x5F6D3A0", VA = "0x185F6DFA0")]
	public void PBDBDDEHFJI(IList MOBONMBAIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x25B5F70", Offset = "0x25B5370", VA = "0x1825B5F70")]
	public void NPIIIDONILP<T, U>(Dictionary<T, U> DCGOBEPFIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5F6DB10", Offset = "0x5F6CF10", VA = "0x185F6DB10")]
	private void HKAGCGPNLDK(IDictionary DCGOBEPFIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D3A0", Offset = "0x5F6C7A0", VA = "0x185F6D3A0")]
	public int DJIPCKJOHGD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5F6DE80", Offset = "0x5F6D280", VA = "0x185F6DE80")]
	public short HNDABHIAANA()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D2B0", Offset = "0x5F6C6B0", VA = "0x185F6D2B0")]
	public void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5F6DAA0", Offset = "0x5F6CEA0", VA = "0x185F6DAA0")]
	private void HIHHAFABOCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public abstract class JAFAMIAODBF<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	internal class LPCJBAPFLOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public TNode LKINCHDLDIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public TNode JFCNGAACNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public BBBMMDPKFNA FPGLNAGBBFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public List<BBBMMDPKFNA> OKDHGMIAEIK;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public LPCJBAPFLOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal struct BBBMMDPKFNA : IComparable<BBBMMDPKFNA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int HFEAKOCKPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public TClaimant GOGFEIADBJH;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x6A30B0", Offset = "0x6A24B0", VA = "0x1806A30B0")]
		public BBBMMDPKFNA(int HFEAKOCKPHO, TClaimant GOGFEIADBJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x45F8F20", Offset = "0x45F8320", VA = "0x1845F8F20")]
		public bool JCCJCGEFBOG(in BBBMMDPKFNA EPJIAIAEMFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x45F8F80", Offset = "0x45F8380", VA = "0x1845F8F80")]
		public bool PKIDELLBEKB(in BBBMMDPKFNA EPJIAIAEMFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x45F8F10", Offset = "0x45F8310", VA = "0x1845F8F10", Slot = "4")]
		public int CompareTo(BBBMMDPKFNA EPJIAIAEMFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x45F8F90", Offset = "0x45F8390", VA = "0x1845F8F90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum MJNDAPIMNMH
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class BCKCNFJFFED : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public global::JAFAMIAODBF<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x1BB07A0", Offset = "0x1BAFBA0", VA = "0x181BB07A0")]
		[DebuggerHidden]
		public BCKCNFJFFED(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1240", Offset = "0x3CE0640", VA = "0x183CE1240", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1400", Offset = "0x3CE0800", VA = "0x183CE1400", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1320", Offset = "0x3CE0720", VA = "0x183CE1320", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x1B9E100", Offset = "0x1B9D500", VA = "0x181B9E100", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly global::JLCHEKEPFGC<LPCJBAPFLOC> JFBILOBIEAD;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly global::JLCHEKEPFGC<List<BBBMMDPKFNA>> BHCGBNNFIGG;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static int FCHIAJIMGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	internal readonly Dictionary<TClaimant, TNode> DHODNKJLGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	internal readonly Dictionary<TNode, LPCJBAPFLOC> DGKOIOKCHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private MJNDAPIMNMH JHDOIDGIHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool HIBODKPCONP;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode IONCGDONMPM(TNode EJMIEPKLJDN);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void JOFEMDDFHJB(TNode EJMIEPKLJDN, TClaimant DHNOPLKGDIK, TClaimant LOODCOLBDHK);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x31BFE40", Offset = "0x31BF240", VA = "0x1831BFE40")]
	public JAFAMIAODBF(MJNDAPIMNMH JHDOIDGIHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x31BE6F0", Offset = "0x31BDAF0", VA = "0x1831BE6F0")]
	public void BMJGIHPFEKJ(TNode EJMIEPKLJDN, TNode CNMJLCOJOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x31BFB50", Offset = "0x31BEF50", VA = "0x1831BFB50")]
	public void MFGDGGMAFNP(TClaimant GOGFEIADBJH, TNode KEJEOFFFKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x31BE770", Offset = "0x31BDB70", VA = "0x1831BE770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x31BF680", Offset = "0x31BEA80", VA = "0x1831BF680")]
	private void JMMDBIGDDNE(TClaimant GOGFEIADBJH, TNode LDIFINOMHFO, TNode KEJEOFFFKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x31BF0E0", Offset = "0x31BE4E0", VA = "0x1831BF0E0")]
	private int INCIKHBJAGM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x31BF3D0", Offset = "0x31BE7D0", VA = "0x1831BF3D0")]
	private void JDKPOELKBAP(TClaimant GOGFEIADBJH, TNode KJFAHGPAHDF, TNode BFMALIMGJBJ, int OAPJNIINAKK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x31BFC50", Offset = "0x31BF050", VA = "0x1831BFC50")]
	private void OPLCCAMDKHM(BBBMMDPKFNA NEKPKJEMGPE, LPCJBAPFLOC CLIHPHOPMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x31BE9D0", Offset = "0x31BDDD0", VA = "0x1831BE9D0")]
	private void ELIKIBNBGJB(TClaimant GOGFEIADBJH, TNode KJFAHGPAHDF, TNode BFMALIMGJBJ, int OAPJNIINAKK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x31BEEC0", Offset = "0x31BE2C0", VA = "0x1831BEEC0")]
	private void HMJFIEFCJGO(BBBMMDPKFNA NEKPKJEMGPE, TNode EJMIEPKLJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x31BEC30", Offset = "0x31BE030", VA = "0x1831BEC30")]
	private void FDNJFOCOPNF(BBBMMDPKFNA NEKPKJEMGPE, LPCJBAPFLOC CLIHPHOPMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x31BEFD0", Offset = "0x31BE3D0", VA = "0x1831BEFD0")]
	private void IJPIMMEBPDN(LPCJBAPFLOC CLIHPHOPMDP, bool EHBLHCBOKCM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x31BF720", Offset = "0x31BEB20", VA = "0x1831BF720")]
	private void KIIGDKOOAIC(LPCJBAPFLOC CLIHPHOPMDP, TNode CNMJLCOJOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x31BF140", Offset = "0x31BE540", VA = "0x1831BF140")]
	[IteratorStateMachine(typeof(global::JAFAMIAODBF<, >.BCKCNFJFFED))]
	private IEnumerable<TNode> JBAJOANNMIL(TNode KJFAHGPAHDF, TNode BFMALIMGJBJ, bool JKJKCMPILDE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x31BFA90", Offset = "0x31BEE90", VA = "0x1831BFA90")]
	private LPCJBAPFLOC LDDEFNLKNKA(TNode EJMIEPKLJDN, TNode JFCNGAACNEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x31BED30", Offset = "0x31BE130", VA = "0x1831BED30")]
	private LPCJBAPFLOC FLONMDDIKON(TNode EJMIEPKLJDN, TNode JFCNGAACNEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x31BF210", Offset = "0x31BE610", VA = "0x1831BF210")]
	private void JCFBMHKDBMB(LPCJBAPFLOC CLIHPHOPMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class LFENAALNENL<T> : IEnumerable<global::LFENAALNENL<T>.MCIOPFHDPDF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public struct MCIOPFHDPDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public T IGDJJEECDAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int HMJKJGLHFKE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class FLOJGOOIBNM : IEnumerator<MCIOPFHDPDF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private global::LFENAALNENL<T> LJGGGAEIPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private int HMJKJGLHFKE;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x11106C0", Offset = "0x110FAC0", VA = "0x1811106C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public MCIOPFHDPDF BHDIBOCECJI
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x25D80C0", Offset = "0x25D74C0", VA = "0x1825D80C0", Slot = "4")]
			get
			{
				return default(MCIOPFHDPDF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x67C060", Offset = "0x67B460", VA = "0x18067C060")]
		public FLOJGOOIBNM(global::LFENAALNENL<T> LJGGGAEIPBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x25D7FC0", Offset = "0x25D73C0", VA = "0x1825D7FC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x67C050", Offset = "0x67B450", VA = "0x18067C050", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x89EBC0", Offset = "0x89DFC0", VA = "0x18089EBC0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private struct NHJJAMNOHDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public bool JLGCFMDDLNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public T IGDJJEECDAF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private const int HGBAGAGONLN = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Dictionary<T, int> AGMEHLKJCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private NHJJAMNOHDE[] PNAEOJICLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int EBAMFKNMDGB;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int ECBABFIHGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x698D90", Offset = "0x698190", VA = "0x180698D90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x84AEB0", Offset = "0x84A2B0", VA = "0x18084AEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x1FAEDA0", Offset = "0x1FAE1A0", VA = "0x181FAEDA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x38865D0", Offset = "0x38859D0", VA = "0x1838865D0")]
	public LFENAALNENL(int OAKAJHNNELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x38866B0", Offset = "0x3885AB0", VA = "0x1838866B0")]
	public LFENAALNENL(MCIOPFHDPDF[] GPMNJBAKNOM, bool JFFACHBBBJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x38858F0", Offset = "0x3884CF0", VA = "0x1838858F0")]
	public int HHDOLBICBFG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3886290", Offset = "0x3885690", VA = "0x183886290")]
	private int LLJDMBHPINM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3885960", Offset = "0x3884D60", VA = "0x183885960", Slot = "6")]
	protected virtual uint IKIBFCMNDCD(uint BMNGMMBLJFF, T IGDJJEECDAF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x3886510", Offset = "0x3885910", VA = "0x183886510")]
	public bool NNGBDCFGFGM(T IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x38855E0", Offset = "0x38849E0", VA = "0x1838855E0")]
	public bool EEHJLGABABP(int HMJKJGLHFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x38851E0", Offset = "0x38845E0", VA = "0x1838851E0")]
	public bool BJDJCLJIFEK(Func<T, bool> HOJCMPMFJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x3886040", Offset = "0x3885440", VA = "0x183886040")]
	public int JNLFKMINOFP(T IGDJJEECDAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x3885830", Offset = "0x3884C30", VA = "0x183885830")]
	public T GKJHPELBGMO(int HMJKJGLHFKE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x38852B0", Offset = "0x38846B0", VA = "0x1838852B0")]
	public void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x3885BB0", Offset = "0x3884FB0", VA = "0x183885BB0")]
	public bool INCCOKIDJLO(T IGDJJEECDAF, bool BMBEKEPPBPB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x38859B0", Offset = "0x3884DB0", VA = "0x1838859B0")]
	public bool INCCOKIDJLO(T IGDJJEECDAF, int HMJKJGLHFKE, bool BMBEKEPPBPB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x38857A0", Offset = "0x3884BA0", VA = "0x1838857A0")]
	public bool GKDAOIMBAHJ(T IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3886490", Offset = "0x3885890", VA = "0x183886490")]
	public bool MPEIJCCPMAM(int HMJKJGLHFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x3885E20", Offset = "0x3885220", VA = "0x183885E20")]
	private void JKMAANLMKJI(int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x3885330", Offset = "0x3884730", VA = "0x183885330")]
	public MCIOPFHDPDF[] DGKKAOADICN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x3885680", Offset = "0x3884A80", VA = "0x183885680")]
	private int FJODLHPNKBM(int PKHCKPMMLFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x3886550", Offset = "0x3885950", VA = "0x183886550", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x3886550", Offset = "0x3885950", VA = "0x183886550", Slot = "4")]
	private IEnumerator<MCIOPFHDPDF> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct MPAKMLCCEDB<Handle> where Handle : PIEOKMGFPCE, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct GBKEBMHNEEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly global::MPAKMLCCEDB<Handle> BFOMJNGFEGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private int HMJKJGLHFKE;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int HJDOHBKKHCC
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x2D38EC0", Offset = "0x2D382C0", VA = "0x182D38EC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle JPIHLHOIELA
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x2D39460", Offset = "0x2D38860", VA = "0x182D39460")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x2D39E40", Offset = "0x2D39240", VA = "0x182D39E40")]
		public GBKEBMHNEEL(global::MPAKMLCCEDB<Handle> BFOMJNGFEGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x2D391C0", Offset = "0x2D385C0", VA = "0x182D391C0")]
		public PHLJHJLDFPN IKMCJIAOBME(in PHLJHJLDFPN FAHGJOEFBKN)
		{
			return default(PHLJHJLDFPN);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x2D39260", Offset = "0x2D38660", VA = "0x182D39260")]
		public GIIIOALEGCJ IKMCJIAOBME(in GIIIOALEGCJ FAHGJOEFBKN)
		{
			return default(GIIIOALEGCJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x2D39AE0", Offset = "0x2D38EE0", VA = "0x182D39AE0")]
		public bool NGAIBNDHFMG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x2D38D20", Offset = "0x2D38120", VA = "0x182D38D20")]
		private int ABNOKKHAOOI(string KAKCNEMJMJL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x2D398D0", Offset = "0x2D38CD0", VA = "0x182D398D0")]
		private Handle LEOJGJHBNFE(string KAKCNEMJMJL)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public struct PHLJHJLDFPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private GBKEBMHNEEL IMGFPNPBOCC;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int BHDIBOCECJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x28EE9F0", Offset = "0x28EDDF0", VA = "0x1828EE9F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x279C210", Offset = "0x279B610", VA = "0x18279C210")]
		public PHLJHJLDFPN(global::MPAKMLCCEDB<Handle> BFOMJNGFEGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x279C110", Offset = "0x279B510", VA = "0x18279C110")]
		public bool NGAIBNDHFMG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x28EEA70", Offset = "0x28EDE70", VA = "0x1828EEA70")]
		public PHLJHJLDFPN PEKBJENCCON()
		{
			return default(PHLJHJLDFPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct GIIIOALEGCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private GBKEBMHNEEL IMGFPNPBOCC;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle BHDIBOCECJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x279BF90", Offset = "0x279B390", VA = "0x18279BF90")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x279C210", Offset = "0x279B610", VA = "0x18279C210")]
		public GIIIOALEGCJ(global::MPAKMLCCEDB<Handle> BFOMJNGFEGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x279C110", Offset = "0x279B510", VA = "0x18279C110")]
		public bool NGAIBNDHFMG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x279C190", Offset = "0x279B590", VA = "0x18279C190")]
		public GIIIOALEGCJ PEKBJENCCON()
		{
			return default(GIIIOALEGCJ);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private NativeList<int> HJMEKKAOBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private NativeList<int> JGDBMACDADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private int LGMLGMMJJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private int COGIBBJNHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private bool KMMNILGMMKM;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool IGFHGDGAIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x768F80", Offset = "0x768380", VA = "0x180768F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int HIDCIHPOCOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x29D5950", Offset = "0x29D4D50", VA = "0x1829D5950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int GODKGLJAIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x678010", Offset = "0x677410", VA = "0x180678010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int FCNKPOLLABF
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x678010", Offset = "0x677410", VA = "0x180678010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public PHLJHJLDFPN JOECGJBHDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x29D5460", Offset = "0x29D4860", VA = "0x1829D5460")]
		get
		{
			return default(PHLJHJLDFPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public GIIIOALEGCJ IOEMCHCAMGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x29D60A0", Offset = "0x29D54A0", VA = "0x1829D60A0")]
		get
		{
			return default(GIIIOALEGCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x29D6140", Offset = "0x29D5540", VA = "0x1829D6140")]
	public MPAKMLCCEDB(int BAFJBCBEPBN, Allocator JLPBABJNDBH = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x29D5DC0", Offset = "0x29D51C0", VA = "0x1829D5DC0")]
	public void NPNFNKBABCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x1952080", Offset = "0x1951480", VA = "0x181952080")]
	public static int CMDLDIAOPEF(int FHHDDMKIIBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x29D50D0", Offset = "0x29D44D0", VA = "0x1829D50D0")]
	public static bool DMIAPMJDHDF(int FHHDDMKIIBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x29D5990", Offset = "0x29D4D90", VA = "0x1829D5990")]
	public static bool LLJIANDBJNC(int FHHDDMKIIBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x29D5CA0", Offset = "0x29D50A0", VA = "0x1829D5CA0")]
	public bool MOFDPLANPBB(int HMJKJGLHFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x29D5E80", Offset = "0x29D5280", VA = "0x1829D5E80")]
	public bool OEFJOMHMOEI(int HMJKJGLHFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x29D5350", Offset = "0x29D4750", VA = "0x1829D5350")]
	public bool HPBNPEKMOMF(Handle CPAMCPHEBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x29D55B0", Offset = "0x29D49B0", VA = "0x1829D55B0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void JJFNCPHDFJN(Handle CPAMCPHEBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x29D5280", Offset = "0x29D4680", VA = "0x1829D5280")]
	public Handle HHBIJIHDAOC()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x29D59A0", Offset = "0x29D4DA0", VA = "0x1829D59A0")]
	public void MKNEHDNHKGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x29D58D0", Offset = "0x29D4CD0", VA = "0x1829D58D0")]
	public void KJDJDPGDKDJ(Handle CPAMCPHEBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x29D5FF0", Offset = "0x29D53F0", VA = "0x1829D5FF0")]
	public bool OINMPFAILEF(Handle CPAMCPHEBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x768F80", Offset = "0x768380", VA = "0x180768F80")]
	private bool OHDBAOGJIFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x29D4F00", Offset = "0x29D4300", VA = "0x1829D4F00")]
	private bool AFOKNBGILAE(int HMJKJGLHFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x29D4F60", Offset = "0x29D4360", VA = "0x1829D4F60")]
	private void ANAGMEAOGEH(out int HMJKJGLHFKE, out int FMCKDMNHLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x29D5180", Offset = "0x29D4580", VA = "0x1829D5180")]
	private void HEOBHAGJNLO(Handle CPAMCPHEBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x29D5FA0", Offset = "0x29D53A0", VA = "0x1829D5FA0")]
	private void OICOAOPAIGF(int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x29D5500", Offset = "0x29D4900", VA = "0x1829D5500")]
	private bool JBJAILKFENC(out int HMJKJGLHFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x29D50E0", Offset = "0x29D44E0", VA = "0x1829D50E0")]
	private static Handle DMPPNKONGAJ(int HMJKJGLHFKE, int FMCKDMNHLLD)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[DefaultMember("Item")]
public struct DAMBNPJKGIF<Handle, T> where Handle : PIEOKMGFPCE, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private global::MPAKMLCCEDB<Handle> AIONJLNFBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private T[] DAFGKHGBAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private Action<T> OMJENNKPPLG;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool IGFHGDGAIFM
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x27F0610", Offset = "0x27EFA10", VA = "0x1827F0610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int HIDCIHPOCOB
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x27EF720", Offset = "0x27EEB20", VA = "0x1827EF720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x27F0340", Offset = "0x27EF740", VA = "0x1827F0340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x27EF140", Offset = "0x27EE540", VA = "0x1827EF140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x27F0840", Offset = "0x27EFC40", VA = "0x1827F0840")]
	public DAMBNPJKGIF(int BAFJBCBEPBN, [Optional] Action<T> OMJENNKPPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x27F0580", Offset = "0x27EF980", VA = "0x1827F0580")]
	public void NPNFNKBABCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x27EF520", Offset = "0x27EE920", VA = "0x1827EF520")]
	public bool HPBNPEKMOMF(Handle CPAMCPHEBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void JJFNCPHDFJN(Handle CPAMCPHEBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x27EF660", Offset = "0x27EEA60", VA = "0x1827EF660")]
	public T JLHLNIPLDNM(Handle CPAMCPHEBME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x27EF230", Offset = "0x27EE630", VA = "0x1827EF230")]
	public bool HIJHOGNBHHL(Handle CPAMCPHEBME, out T JLBINKLPHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x27EFB60", Offset = "0x27EEF60", VA = "0x1827EFB60")]
	public void KNBGLHDOKIA(Handle CPAMCPHEBME, T JBHEOFLJOHI, out T EGEJLGJFFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x27EF820", Offset = "0x27EEC20", VA = "0x1827EF820")]
	public void KNBGLHDOKIA(Handle CPAMCPHEBME, T JBHEOFLJOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x27EE530", Offset = "0x27ED930", VA = "0x1827EE530")]
	public bool CJCMGJAHJPM(Handle CPAMCPHEBME, T JBHEOFLJOHI, out T EGEJLGJFFPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x27EE700", Offset = "0x27EDB00", VA = "0x1827EE700")]
	public bool CJCMGJAHJPM(Handle CPAMCPHEBME, T JBHEOFLJOHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x27ED650", Offset = "0x27ECA50", VA = "0x1827ED650")]
	public Handle AKBMAMDKLNI(T JLBINKLPHKJ)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x27ED980", Offset = "0x27ECD80", VA = "0x1827ED980")]
	public void CEPJALHNIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x27EED30", Offset = "0x27EE130", VA = "0x1827EED30")]
	public void GKDAOIMBAHJ(Handle CPAMCPHEBME, out T EGEJLGJFFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x27EEC60", Offset = "0x27EE060", VA = "0x1827EEC60")]
	public void GKDAOIMBAHJ(Handle CPAMCPHEBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x27EFDC0", Offset = "0x27EF1C0", VA = "0x1827EFDC0")]
	public bool LOMHHMPOGBE(Handle CPAMCPHEBME, out T EGEJLGJFFPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x27EFCE0", Offset = "0x27EF0E0", VA = "0x1827EFCE0")]
	public bool LOMHHMPOGBE(Handle CPAMCPHEBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x27F0370", Offset = "0x27EF770", VA = "0x1827F0370")]
	private T MPEIJCCPMAM(int HMJKJGLHFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x27EE9B0", Offset = "0x27EDDB0", VA = "0x1827EE9B0")]
	private void ECNINJLKKPH(int BMOONABBIIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class JLCHEKEPFGC<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Stack<T> BFOMJNGFEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<T> DKCLDPEPMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly int FCDJGLCODCA;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int BLDPPCGEECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x1EF7A00", Offset = "0x1EF6E00", VA = "0x181EF7A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int POBDHKJHAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x1F14F60", Offset = "0x1F14360", VA = "0x181F14F60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x20B26F0", Offset = "0x20B1AF0", VA = "0x1820B26F0")]
	public static global::JLCHEKEPFGC<T> HBMGFILAINN(int OAKAJHNNELN = 0, int FCDJGLCODCA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x20B23E0", Offset = "0x20B17E0", VA = "0x1820B23E0")]
	public static global::JLCHEKEPFGC<T> EEKHJDDDPOD(int OAKAJHNNELN = 0, int FCDJGLCODCA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x20B2AE0", Offset = "0x20B1EE0", VA = "0x1820B2AE0")]
	public JLCHEKEPFGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x20B2B20", Offset = "0x20B1F20", VA = "0x1820B2B20")]
	public JLCHEKEPFGC(int OAKAJHNNELN, int FCDJGLCODCA = int.MaxValue, bool NLBALMNJDMJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x20B2560", Offset = "0x20B1960", VA = "0x1820B2560")]
	public T GJGNFIMMHOA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x20B24B0", Offset = "0x20B18B0", VA = "0x1820B24B0")]
	public void FLGFHANBACE(T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x20B2960", Offset = "0x20B1D60", VA = "0x1820B2960")]
	private void JCLAAAJHJLC(T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x20B2A30", Offset = "0x20B1E30", VA = "0x1820B2A30")]
	private void LLGCFMBKPBM(T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x20B2670", Offset = "0x20B1A70", VA = "0x1820B2670")]
	[Conditional("DEBUG_BUILD")]
	private void HBBKFPNIJFP(T PFAPKPDCMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x20B2A50", Offset = "0x20B1E50", VA = "0x1820B2A50")]
	[Conditional("DEBUG_BUILD")]
	private void LNKDKPEIFGC(T PFAPKPDCMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x20B22F0", Offset = "0x20B16F0", VA = "0x1820B22F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x20B27C0", Offset = "0x20B1BC0", VA = "0x1820B27C0")]
	private void IIILMKJAFNK(IEnumerable<T> LKAPNLFPHIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class FHKGFPJOGAF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private Dictionary<int, T> LJBMIHJBFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private T LKBNDDBLNPD;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T LKLPEIKAAAK
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x697540", VA = "0x180698140", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool POENGJDJMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x25C7F00", Offset = "0x25C7300", VA = "0x1825C7F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x25C80E0", Offset = "0x25C74E0", VA = "0x1825C80E0")]
	public bool NLLNELGPFFC(T IGDJJEECDAF, int HFEAKOCKPHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x25C81A0", Offset = "0x25C75A0", VA = "0x1825C81A0")]
	public bool OLBCNDJLEDE(int HFEAKOCKPHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x25C7B10", Offset = "0x25C6F10", VA = "0x1825C7B10")]
	public T HOPDNKOFCEN(int ELINECJKCHF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x25C7A80", Offset = "0x25C6E80", VA = "0x1825C7A80")]
	public void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x25C7F40", Offset = "0x25C7340", VA = "0x1825C7F40")]
	private bool IOKPIHMJHHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x25C7AE0", Offset = "0x25C6EE0", VA = "0x1825C7AE0")]
	public bool GAMCGCGFADK(int HFEAKOCKPHO, out T IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x25C8200", Offset = "0x25C7600", VA = "0x1825C8200")]
	public FHKGFPJOGAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class LDOPGIPMLOF<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	protected struct LADFLEKNLCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public T KGOGAJOHGBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int HPIPOHGBCMN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	protected readonly List<LADFLEKNLCN> ENFGAHDEDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private T AEJHFBMNPHI;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x1FAEDA0", Offset = "0x1FAE1A0", VA = "0x181FAEDA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x43390A0", Offset = "0x43384A0", VA = "0x1843390A0")]
	public bool BJDJCLJIFEK(T IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x4339000", Offset = "0x4338400", VA = "0x184339000")]
	public void AKBMAMDKLNI(T IGDJJEECDAF, int HFEAKOCKPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x43393F0", Offset = "0x43387F0", VA = "0x1843393F0")]
	public bool GKDAOIMBAHJ(T IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x4339390", Offset = "0x4338790", VA = "0x184339390")]
	public void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x43392B0", Offset = "0x43386B0", VA = "0x1843392B0")]
	public T BKOEGGADHEH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x4339320", Offset = "0x4338720", VA = "0x184339320")]
	public T BMADKCMEKHI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x4339510", Offset = "0x4338910", VA = "0x184339510")]
	private void MMPFJALOOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x43396D0", Offset = "0x4338AD0", VA = "0x1843396D0")]
	public LDOPGIPMLOF()
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
		[OMNCBHLNHGK(IJIMEJPPCDF.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x5F70E40", Offset = "0x5F70240", VA = "0x185F70E40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x5F711D0", Offset = "0x5F705D0", VA = "0x185F711D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x5F71050", Offset = "0x5F70450", VA = "0x185F71050")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x5F71330", Offset = "0x5F70730", VA = "0x185F71330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x5F70D60", Offset = "0x5F70160", VA = "0x185F70D60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x5F710F0", Offset = "0x5F704F0", VA = "0x185F710F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x5F70F70", Offset = "0x5F70370", VA = "0x185F70F70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5F70D10", Offset = "0x5F70110", VA = "0x185F70D10")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface MACGKIGDIPL
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class ResourcePrefabReference<T> : MACGKIGDIPL where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x2F59960", Offset = "0x2F58D60", VA = "0x182F59960", Slot = "4")]
		public virtual T EBABLAEBEMB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class CHNMPECDLPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly Dictionary<byte, ILAPJFEJEDD> AKMCLCIMNFP;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public ILAPJFEJEDD HOODJIJPOJP
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x697530", VA = "0x180698130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 MHKKPAAJAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x1817AE0", Offset = "0x1816EE0", VA = "0x181817AE0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x6C1CD0", Offset = "0x6C10D0", VA = "0x1806C1CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 JFOLCHKEJIE
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x21CBC00", Offset = "0x21CB000", VA = "0x1821CBC00")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x1087DD0", Offset = "0x10871D0", VA = "0x181087DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 KHNNCKHIHLL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x5F6A900", Offset = "0x5F69D00", VA = "0x185F6A900")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x1D099E0", Offset = "0x1D08DE0", VA = "0x181D099E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int OMACOEGBNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x6780E0", Offset = "0x6774E0", VA = "0x1806780E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6DF640", Offset = "0x6DEA40", VA = "0x1806DF640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F6AD20", Offset = "0x5F6A120", VA = "0x185F6AD20")]
	public CHNMPECDLPE(Bounds ELMPEGCJNGE, Vector2[] MJJDFOMLPHG, int EAMEHFAIJLE, byte PKHCKPMMLFP, float MAEAJPGMKLB = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A880", Offset = "0x5F69C80", VA = "0x185F6A880")]
	public ILAPJFEJEDD IEOLCDIPNGN(byte HMJKJGLHFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A780", Offset = "0x5F69B80", VA = "0x185F6A780")]
	public void IBGFAIOPCMN(Vector3 EFKMIDDCAKM, float FIDLPHJLKAH, float LGAOPGHOHKC, ref List<byte> IDAMJKFMHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A8E0", Offset = "0x5F69CE0", VA = "0x185F6A8E0")]
	public void LCALOLDCPKK(ILAPJFEJEDD.JMONOBLGLNH JBEOGDJKAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A620", Offset = "0x5F69A20", VA = "0x185F6A620")]
	private ILAPJFEJEDD FCEGGHPIDPP(byte HMJKJGLHFKE, ILAPJFEJEDD.OAMPNPFGMJH CAIDAKAFOEH, ILAPJFEJEDD JFCNGAACNEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A920", Offset = "0x5F69D20", VA = "0x185F6A920")]
	private void PGHBNACFAFK(ILAPJFEJEDD JFCNGAACNEO, Vector2[] MJJDFOMLPHG, int AFHEBGMGLAA, int AGNNPIDHCOJ, int GGCFNLMFABJ, int AOEFJLIJPEO, float MAEAJPGMKLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class ILAPJFEJEDD
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public enum OAMPNPFGMJH
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public enum JMONOBLGLNH
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
	public byte JHEAENOKMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public Vector3 JJOGFHNBGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector3 HEHPNMDAHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Vector3 EAAGBIHEGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public Vector3 JCFMNFBJCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public OAMPNPFGMJH EEEIDGPIJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public ILAPJFEJEDD AEPDHOKLCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public List<ILAPJFEJEDD> GBBKDMDAIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public bool MIJIGAKBOKF;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5F6CF60", Offset = "0x5F6C360", VA = "0x185F6CF60")]
	public ILAPJFEJEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5F6CF80", Offset = "0x5F6C380", VA = "0x185F6CF80")]
	public ILAPJFEJEDD(byte KDFBMFGPICB, OAMPNPFGMJH CAIDAKAFOEH, ILAPJFEJEDD JFCNGAACNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5F6CEA0", Offset = "0x5F6C2A0", VA = "0x185F6CEA0")]
	public void LJBOEABGKKO(ILAPJFEJEDD JKAAFIAPPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public void LCALOLDCPKK(int PDBMMBDCHMC, JMONOBLGLNH JBEOGDJKAFM, int IAFCCCKLDJP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5F6CBF0", Offset = "0x5F6BFF0", VA = "0x185F6CBF0")]
	public void IBGFAIOPCMN(List<byte> IDAMJKFMHNO, Vector3 EFKMIDDCAKM, float FIDLPHJLKAH, float LGAOPGHOHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5F6CBA0", Offset = "0x5F6BFA0", VA = "0x185F6CBA0")]
	public bool DBNLADDBDBM(Vector3 COCHOPELBHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x5F6CB60", Offset = "0x5F6BF60", VA = "0x185F6CB60")]
	public bool BNBEFEPHIOO(Vector3 COCHOPELBHG, float CGFJCHBIACA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class KGMACCHIIDN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly Dictionary<T, object> KEFNKFCHIHN;

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x1D51D50", Offset = "0x1D51150", VA = "0x181D51D50")]
	public bool MLDANBCFOBP(T JDHAHNMMNBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x32B87A0", Offset = "0x32B7BA0", VA = "0x1832B87A0")]
	public bool MLDANBCFOBP(T JDHAHNMMNBL, object MJNGPHMPILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x32B8740", Offset = "0x32B7B40", VA = "0x1832B8740")]
	public bool MLDANBCFOBP(T JDHAHNMMNBL, object MJNGPHMPILM, out object FKLABAKAKKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x32B8670", Offset = "0x32B7A70", VA = "0x1832B8670")]
	public bool KLMLNEDPHMF(T JDHAHNMMNBL, object MJNGPHMPILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x32B8630", Offset = "0x32B7A30", VA = "0x1832B8630")]
	public bool DEJKHIIAEPD(T JDHAHNMMNBL, object MJNGPHMPILM, out object FKLABAKAKKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x32B86B0", Offset = "0x32B7AB0", VA = "0x1832B86B0")]
	public bool KLMLNEDPHMF(T JDHAHNMMNBL, object MJNGPHMPILM, out object FKLABAKAKKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x32B87E0", Offset = "0x32B7BE0", VA = "0x1832B87E0")]
	public void OMKEEDAEHII(T JDHAHNMMNBL, object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x32B8810", Offset = "0x32B7C10", VA = "0x1832B8810")]
	public void PEMALJABGAL(T JDHAHNMMNBL, object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x32B88B0", Offset = "0x32B7CB0", VA = "0x1832B88B0")]
	public KGMACCHIIDN()
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
		public struct OMKBNINDKFE<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			private readonly List<Component> MOBONMBAIDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private readonly bool NDKCHOMODPI;

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x8D8970", Offset = "0x8D7D70", VA = "0x1808D8970")]
			public OMKBNINDKFE(List<Component> MOBONMBAIDJ, bool NDKCHOMODPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x37BF450", Offset = "0x37BE850", VA = "0x1837BF450")]
			public EPKPAIMIFBC<T> PEKBJENCCON()
			{
				return default(EPKPAIMIFBC<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x37BF4C0", Offset = "0x37BE8C0", VA = "0x1837BF4C0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x37BF4C0", Offset = "0x37BE8C0", VA = "0x1837BF4C0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		public struct EPKPAIMIFBC<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private readonly List<Component> MOBONMBAIDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private readonly bool NDKCHOMODPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private int HMJKJGLHFKE;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T BHDIBOCECJI
			{
				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x245B1F0", Offset = "0x245A5F0", VA = "0x18245B1F0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0x245B180", Offset = "0x245A580", VA = "0x18245B180", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x245B1C0", Offset = "0x245A5C0", VA = "0x18245B1C0")]
			public EPKPAIMIFBC(List<Component> MOBONMBAIDJ, bool NDKCHOMODPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x245B0B0", Offset = "0x245A4B0", VA = "0x18245B0B0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x245B0C0", Offset = "0x245A4C0", VA = "0x18245B0C0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x245B170", Offset = "0x245A570", VA = "0x18245B170", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x5F73080", Offset = "0x5F72480", VA = "0x185F73080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5F73040", Offset = "0x5F72440", VA = "0x185F73040")]
		public ToolHierarchyCache(GameObject GEMPPKOEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5F72DE0", Offset = "0x5F721E0", VA = "0x185F72DE0")]
		private void LJAJKOINHPD(GameObject GEMPPKOEIPE, bool POKKNFLDEOM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5F72D50", Offset = "0x5F72150", VA = "0x185F72D50")]
		public static void LJAJKOINHPD(GameObject GEMPPKOEIPE, ref ToolHierarchyCache GJFJIDJNDMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5F72D40", Offset = "0x5F72140", VA = "0x185F72D40")]
		public void JJKKEINLJPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x5F727F0", Offset = "0x5F71BF0", VA = "0x185F727F0")]
		public void ACCHNHHJCMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x3606ED0", Offset = "0x36062D0", VA = "0x183606ED0")]
		public void NDIDDEENNHC<T>(Action<T> LECDCDLGAEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x5F72840", Offset = "0x5F71C40", VA = "0x185F72840")]
		public Component AFGHPGBEIFD(Type FPPBLNEEHBP, bool NDKCHOMODPI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x3606D80", Offset = "0x3606180", VA = "0x183606D80")]
		public T AFGHPGBEIFD<T>(bool NDKCHOMODPI = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x5F72F40", Offset = "0x5F72340", VA = "0x185F72F40")]
		public OMKBNINDKFE<Component> MPJOPNMNELA(Type FPPBLNEEHBP, bool NDKCHOMODPI = false)
		{
			return default(OMKBNINDKFE<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x3606E00", Offset = "0x3606200", VA = "0x183606E00")]
		public OMKBNINDKFE<T> MPJOPNMNELA<T>(bool NDKCHOMODPI = false) where T : class
		{
			return default(OMKBNINDKFE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x5F72910", Offset = "0x5F71D10", VA = "0x185F72910")]
		public List<Component> CCCIFKHOKAM(Type FPPBLNEEHBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x5F72C40", Offset = "0x5F72040", VA = "0x185F72C40", Slot = "4")]
		public bool Equals(ToolHierarchyCache BCJCIOLMPPL, ToolHierarchyCache OIPENDMCMEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x5F72CC0", Offset = "0x5F720C0", VA = "0x185F72CC0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache JLBINKLPHKJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public class OBOLPLIHHKG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private int OAKAJHNNELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private int LOGBIDKMDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private List<T> KOPDMFDFEFH;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x1EF7A00", Offset = "0x1EF6E00", VA = "0x181EF7A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T KEADCECDCJB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x3A46C60", Offset = "0x3A46060", VA = "0x183A46C60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T NOOOMJPNIFN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x3A46F90", Offset = "0x3A46390", VA = "0x183A46F90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T AAKDLFNPDMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x3A46EF0", Offset = "0x3A462F0", VA = "0x183A46EF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x3A47000", Offset = "0x3A46400", VA = "0x183A47000")]
	public OBOLPLIHHKG(int OAKAJHNNELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x3A46AB0", Offset = "0x3A45EB0", VA = "0x183A46AB0")]
	public void AKBMAMDKLNI(T LECBLMBGOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x3A46D70", Offset = "0x3A46170", VA = "0x183A46D70")]
	public void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x3A46E00", Offset = "0x3A46200", VA = "0x183A46E00")]
	public void IFEFCPJIEFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x3A46DB0", Offset = "0x3A461B0", VA = "0x183A46DB0")]
	public void GJPJDJFHDJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x3A46FF0", Offset = "0x3A463F0", VA = "0x183A46FF0")]
	public void PGCIBEJGJHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class FNJMJPNIGIC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private bool AMDEFLNKDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private Action LECDCDLGAEL;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static FNJMJPNIGIC HAOGFGHKMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5F6C030", Offset = "0x5F6B430", VA = "0x185F6C030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool BGIJLMEDMLG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x67C250", Offset = "0x67B650", VA = "0x18067C250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x82D810", Offset = "0x82CC10", VA = "0x18082D810")]
	public FNJMJPNIGIC(Action LECDCDLGAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C0B0", Offset = "0x5F6B4B0", VA = "0x185F6C0B0")]
	public void OBGGPPJCKMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C0B0", Offset = "0x5F6B4B0", VA = "0x185F6C0B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class PLAKDABHDCH
{
	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x5F70B90", Offset = "0x5F6FF90", VA = "0x185F70B90")]
	public static void JDCGKPDLECH(AKHDANBKPMC DLKKHAHFEJL, string GDAOJPFFMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void JDCGKPDLECH(IEnumerable<object> AOIGECIOMCP, string GDAOJPFFMIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class BPGKGGKGLFM<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private struct MKIIOLOHMBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public int HPIPOHGBCMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public T KGOGAJOHGBC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly Dictionary<object, MKIIOLOHMBH> LJBMIHJBFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly EqualityComparer<T> PLBFOHOICHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private T LKBNDDBLNPD;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T LKLPEIKAAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B40", Offset = "0xCB0F40", VA = "0x180CB1B40", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x239D7D0", Offset = "0x239CBD0", VA = "0x18239D7D0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool POENGJDJMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x23996F0", Offset = "0x2398AF0", VA = "0x1823996F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object DLDPDLCKJPI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x68E6F0", Offset = "0x68DAF0", VA = "0x18068E6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x710AE0", Offset = "0x70FEE0", VA = "0x180710AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x239DBB0", Offset = "0x239CFB0", VA = "0x18239DBB0")]
	public bool NLLNELGPFFC(T IGDJJEECDAF, object MJNGPHMPILM, int HFEAKOCKPHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x239E0A0", Offset = "0x239D4A0", VA = "0x18239E0A0")]
	public bool OLBCNDJLEDE(object MJNGPHMPILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x23990E0", Offset = "0x23984E0", VA = "0x1823990E0")]
	public bool GAMCGCGFADK(object MJNGPHMPILM, out T IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2399080", Offset = "0x2398480", VA = "0x182399080")]
	public void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x2399720", Offset = "0x2398B20", VA = "0x182399720")]
	private bool IOKPIHMJHHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x239E110", Offset = "0x239D510", VA = "0x18239E110")]
	public BPGKGGKGLFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class KPMMBOLJBPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private Dictionary<object, float> LJBMIHJBFKO;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float KLLBLNNMEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x1030690", Offset = "0x102FA90", VA = "0x181030690")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xEE2DF0", Offset = "0xEE21F0", VA = "0x180EE2DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E2E0", Offset = "0x5F6D6E0", VA = "0x185F6E2E0")]
	public void NLLNELGPFFC(float IGDJJEECDAF, object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E350", Offset = "0x5F6D750", VA = "0x185F6E350")]
	public void OLBCNDJLEDE(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E1C0", Offset = "0x5F6D5C0", VA = "0x185F6E1C0")]
	private void DBMKANHCAJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E3C0", Offset = "0x5F6D7C0", VA = "0x185F6E3C0")]
	public KPMMBOLJBPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class JGNPMEGNACG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public readonly string JPBENJDLADC;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x678F40", Offset = "0x678340", VA = "0x180678F40")]
	public JGNPMEGNACG(string ELDKHMGBAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D140", Offset = "0x5F6C540", VA = "0x185F6D140")]
	public JGNPMEGNACG(UnityEngine.Object PKPIBFAGOKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D0F0", Offset = "0x5F6C4F0", VA = "0x185F6D0F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class AKHDANBKPMC
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class MKBPGLJJDNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public MKBPGLJJDNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x5F6E880", Offset = "0x5F6DC80", VA = "0x185F6E880")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private HashSet<object> AOIGECIOMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private int KKADGNHAFDP;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> POMBOBCBFFC
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x5F69560", Offset = "0x5F68960", VA = "0x185F69560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool JNPAKENCLIA
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x5F69630", Offset = "0x5F68A30", VA = "0x185F69630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x679BD0", Offset = "0x678FD0", VA = "0x180679BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5F69410", Offset = "0x5F68810", VA = "0x185F69410")]
	public bool AKBMAMDKLNI(object MJNGPHMPILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5F69640", Offset = "0x5F68A40", VA = "0x185F69640")]
	public bool GKDAOIMBAHJ(object MJNGPHMPILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5F69500", Offset = "0x5F68900", VA = "0x185F69500")]
	public bool BJDJCLJIFEK(object MJNGPHMPILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5F696E0", Offset = "0x5F68AE0", VA = "0x185F696E0")]
	public void IFDDMJOOHBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5F69750", Offset = "0x5F68B50", VA = "0x185F69750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public AKHDANBKPMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class NIBMCCJIKPI<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private struct PFDMHCNMCMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public float KAGEDLIDCJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public T KGOGAJOHGBC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private Dictionary<object, PFDMHCNMCMJ> LJBMIHJBFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private T DPOOEFCAFJP;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T CNEONJBDCDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x16BB9E0", Offset = "0x16BADE0", VA = "0x1816BB9E0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x16BB180", Offset = "0x16BA580", VA = "0x1816BB180", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object KFLDJMNPCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x68E6F0", Offset = "0x68DAF0", VA = "0x18068E6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x710AE0", Offset = "0x70FEE0", VA = "0x180710AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool POENGJDJMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x343AC80", Offset = "0x343A080", VA = "0x18343AC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x343C3F0", Offset = "0x343B7F0", VA = "0x18343C3F0")]
	public bool NLLNELGPFFC(T IGDJJEECDAF, object MJNGPHMPILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x343C8F0", Offset = "0x343BCF0", VA = "0x18343C8F0")]
	public bool OLBCNDJLEDE(object MJNGPHMPILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x2399080", Offset = "0x2398480", VA = "0x182399080")]
	public void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x343AA70", Offset = "0x3439E70", VA = "0x18343AA70")]
	public bool GAMCGCGFADK(object MJNGPHMPILM, out T IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x343BC60", Offset = "0x343B060", VA = "0x18343BC60")]
	private bool IOKPIHMJHHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x343C950", Offset = "0x343BD50", VA = "0x18343C950")]
	public NIBMCCJIKPI()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class NLJAGALCJKH
{
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static byte[] JCLCDCCNAPM;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static int BKAHGFCDIKL;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static int GJMNCFGIJLO;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static BigInteger MOEAOMJCPNL;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public NLJAGALCJKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x5F6FCA0", Offset = "0x5F6F0A0", VA = "0x185F6FCA0")]
	private static string EMKPABEMONO(byte[] IKDBBHHKFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5F6FDB0", Offset = "0x5F6F1B0", VA = "0x185F6FDB0")]
	public static string NJEIEMNKMPN(byte[] EEMDNKKFCBK, bool DIMJIPPBEJB)
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
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
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
