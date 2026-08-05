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
public class HGPDHEMOIEE : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x77F100", Offset = "0x77DF00", VA = "0x18077F100")]
	public HGPDHEMOIEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, AIBBHMFDMPN, JIEICLNNGCF, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x770C70", Offset = "0x76FA70", VA = "0x180770C70", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x775E10", Offset = "0x774C10", VA = "0x180775E10", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x770C80", Offset = "0x76FA80", VA = "0x180770C80", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8146C0", Offset = "0x8134C0", VA = "0x1808146C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash BAKOIMDGEAF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x800FF0", Offset = "0x7FFDF0", VA = "0x180800FF0")]
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
	[EJFODAINCIH]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[HideInInspector]
	[EJFODAINCIH]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0660", Offset = "0x5DBF460", VA = "0x185DC0660")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0620", Offset = "0x5DBF420", VA = "0x185DC0620")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DC06A0", Offset = "0x5DBF4A0", VA = "0x185DC06A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0850", Offset = "0x5DBF650", VA = "0x185DC0850")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DC07C0", Offset = "0x5DBF5C0", VA = "0x185DC07C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x83BB90", Offset = "0x83A990", VA = "0x18083BB90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF40", Offset = "0x8DDD40", VA = "0x1808DEF40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5DC05E0", Offset = "0x5DBF3E0", VA = "0x185DC05E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0730", Offset = "0x5DBF530", VA = "0x185DC0730")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0050", Offset = "0x5DBEE50", VA = "0x185DC0050")]
	public void CopyBounds(SavedExtents LCIDHBCOPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0530", Offset = "0x5DBF330", VA = "0x185DC0530")]
	public void SetLocalSpaceBounds(Bounds PIAFHOLFHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x932B40", Offset = "0x931940", VA = "0x180932B40")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0520", Offset = "0x5DBF320", VA = "0x185DC0520")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0080", Offset = "0x5DBEE80", VA = "0x185DC0080")]
	private void FLKOGJPNPBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0300", Offset = "0x5DBF100", VA = "0x185DC0300")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DBF9E0", Offset = "0x5DBE7E0", VA = "0x185DBF9E0")]
	public static void CalculateLocalBoundsFor(GameObject CJHJDJNKIGF, [Out] Bounds PIAFHOLFHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0240", Offset = "0x5DBF040", VA = "0x185DC0240")]
	private static void JDJECCFCHKO(Bounds DCODMCLNKEM, Color HOEIFLHBAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0550", Offset = "0x5DBF350", VA = "0x185DC0550")]
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
		[Cpp2IlInjected.Address(RVA = "0x76E180", Offset = "0x76CF80", VA = "0x18076E180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x775E30", Offset = "0x774C30", VA = "0x180775E30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xD1B200", Offset = "0xD1A000", VA = "0x180D1B200")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x40E9CF0", Offset = "0x40E8AF0", VA = "0x1840E9CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "4")]
	public virtual void JHJBAMNDGGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
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
	[HGPDHEMOIEE]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x40E98D0", Offset = "0x40E86D0", VA = "0x1840E98D0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x40E8570", Offset = "0x40E7370", VA = "0x1840E8570", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x40E9C20", Offset = "0x40E8A20", VA = "0x1840E9C20")]
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
	private sealed class DGPCOLLFPPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public DGPCOLLFPPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4D81150", Offset = "0x4D7FF50", VA = "0x184D81150")]
		internal int EFALBNBPHIG(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[HGPDHEMOIEE]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3107780", Offset = "0x3106580", VA = "0x183107780", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x31077D0", Offset = "0x31065D0", VA = "0x1831077D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3107680", Offset = "0x3106480", VA = "0x183107680", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey GAMCILOFBAF]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3107720", Offset = "0x3106520", VA = "0x183107720", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3107560", Offset = "0x3106360", VA = "0x183107560", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3107280", Offset = "0x3106080", VA = "0x183107280", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3106720", Offset = "0x3105520", VA = "0x183106720", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3106690", Offset = "0x3105490", VA = "0x183106690", Slot = "14")]
	protected virtual string JGKNPKKIFLI(TKeyVal MFOJIBPCOBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x31065A0", Offset = "0x31053A0", VA = "0x1831065A0", Slot = "4")]
	public bool ContainsKey(TKey GAMCILOFBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3107420", Offset = "0x3106220", VA = "0x183107420", Slot = "5")]
	public bool TryGetValue(TKey GAMCILOFBAF, [Out] TVal PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x31065F0", Offset = "0x31053F0", VA = "0x1831065F0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x31065F0", Offset = "0x31053F0", VA = "0x1831065F0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3107470", Offset = "0x3106270", VA = "0x183107470")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MFFBHMGDKFP<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NDMAAOEBCHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public NDMAAOEBCHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3D08A40", Offset = "0x3D07840", VA = "0x183D08A40")]
		internal bool MHMCOCEBDFP(HLBFOKGCHKJ<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float PJPGCNILJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float GOAIGPLKKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<HLBFOKGCHKJ<float, T>> OHFBDCFFLBP;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int BOGBGHECFEG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3CA1230", Offset = "0x3CA0030", VA = "0x183CA1230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3CA18F0", Offset = "0x3CA06F0", VA = "0x183CA18F0")]
	public MFFBHMGDKFP(float CNFLBFPFOJA, float GOGDAHOILNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3CA1030", Offset = "0x3C9FE30", VA = "0x183CA1030")]
	public bool EGCGHCPFNDG(float MMMBHMDFODK, T PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3CA12D0", Offset = "0x3CA00D0", VA = "0x183CA12D0")]
	public IEnumerable<T> MMPOHDEHPOP(float MMMBHMDFODK, [Optional] float? HNMDMNEAEEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3CA12A0", Offset = "0x3CA00A0", VA = "0x183CA12A0")]
	public void LPNBJONBLDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0DC0", Offset = "0x3C9FBC0", VA = "0x183CA0DC0")]
	private void DLCDAKJOAIL(float MMMBHMDFODK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class JENCAIIEFAI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct AOKNCHFMKDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T DHGNDNJJJIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float CKEIKCNNFIB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float EMKFGPNMJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> FJFGHIBIKJH;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int HJDDNFMPAIN = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private AOKNCHFMKDF[] LPMIAHOCPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int OKFKENBDAOJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float NPOBOBPANKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAE8BA0", Offset = "0xAE79A0", VA = "0x180AE8BA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xAE8BB0", Offset = "0xAE79B0", VA = "0x180AE8BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x394AE40", Offset = "0x3949C40", VA = "0x18394AE40")]
	public JENCAIIEFAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x394AD50", Offset = "0x3949B50", VA = "0x18394AD50")]
	public JENCAIIEFAI(int ICPPKLAMHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x394A910", Offset = "0x3949710", VA = "0x18394A910")]
	public void JHPNFEHLKNP(float MMMBHMDFODK, T PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x394ABB0", Offset = "0x39499B0", VA = "0x18394ABB0")]
	public void LPNBJONBLDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x394A200", Offset = "0x3949000", VA = "0x18394A200")]
	public bool FEDPGOJGGLF(float EFJGLOOEAKI, float NPGFKNGHGKM, [Out] T PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x394A060", Offset = "0x3948E60", VA = "0x18394A060")]
	public bool EBHDHIICAFD(float EFJGLOOEAKI, float NPGFKNGHGKM, [Out] T PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x394A7D0", Offset = "0x39495D0", VA = "0x18394A7D0")]
	public void IMGOIHBJANB(float EFJGLOOEAKI, float NPGFKNGHGKM, List<T> BNFLLCFHIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x394AA90", Offset = "0x3949890", VA = "0x18394AA90")]
	private int KHACJJGCIBN(int CNCAMNDKJKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x394ACA0", Offset = "0x3949AA0", VA = "0x18394ACA0")]
	private void MOFAJCPPGOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T MONKJJELCOH();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T GAANLOFIIPB(T PHPDIJICBJO, float KMHHCKOIFKM);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T NJIHDKAAFAA(T KADNMONNONH, T DCAFNABOJJA);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T OIJGKHGCHGL(T KADNMONNONH, T DCAFNABOJJA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class IENKCNHLMFL : JENCAIIEFAI<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x77F990", Offset = "0x77E790", VA = "0x18077F990", Slot = "4")]
	protected override Vector3 MONKJJELCOH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD2F0", Offset = "0x5DBC0F0", VA = "0x185DBD2F0", Slot = "5")]
	protected override Vector3 GAANLOFIIPB(Vector3 PHPDIJICBJO, float KMHHCKOIFKM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD330", Offset = "0x5DBC130", VA = "0x185DBD330", Slot = "6")]
	protected override Vector3 NJIHDKAAFAA(Vector3 KADNMONNONH, Vector3 DCAFNABOJJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD380", Offset = "0x5DBC180", VA = "0x185DBD380", Slot = "7")]
	protected override Vector3 OIJGKHGCHGL(Vector3 KADNMONNONH, Vector3 DCAFNABOJJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD400", Offset = "0x5DBC200", VA = "0x185DBD400")]
	public IENKCNHLMFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HPABECMKBEJ
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2513EC0", Offset = "0x2512CC0", VA = "0x182513EC0")]
	public static HLBFOKGCHKJ<T1, T2> CBILMLOBPDD<T1, T2>(T1 AAKKPPCNMPP, T2 BACHDIBGPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2513F40", Offset = "0x2512D40", VA = "0x182513F40")]
	public static MNGHAKFLIOK<T1, T2, T3> CBILMLOBPDD<T1, T2, T3>(T1 AAKKPPCNMPP, T2 BACHDIBGPPN, T3 BOHGPOGLANM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3CEFA10", Offset = "0x3CEE810", VA = "0x183CEFA10")]
	internal static int INIFJOHAGAF(int ODMKCBHNIDO, int HBCMEBHOAKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5294640", Offset = "0x5293440", VA = "0x185294640")]
	internal static int INIFJOHAGAF(int ODMKCBHNIDO, int HBCMEBHOAKF, int GGDNBOPCCAG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HLBFOKGCHKJ<T1, T2> : IComparable<HLBFOKGCHKJ<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T1 FNNLOJMEAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T2 NKBCENGCANK;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x36899E0", Offset = "0x36887E0", VA = "0x1836899E0")]
	public HLBFOKGCHKJ(T1 AAKKPPCNMPP, T2 BACHDIBGPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3687820", Offset = "0x3686620", VA = "0x183687820", Slot = "4")]
	public int CompareTo(HLBFOKGCHKJ<T1, T2> LCIDHBCOPEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3688390", Offset = "0x3687190", VA = "0x183688390", Slot = "0")]
	public override bool Equals(object LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3688C80", Offset = "0x3687A80", VA = "0x183688C80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3688FF0", Offset = "0x3687DF0", VA = "0x183688FF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MNGHAKFLIOK<T1, T2, T3> : IComparable<MNGHAKFLIOK<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T1 FNNLOJMEAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T2 NKBCENGCANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T3 IMCOMNNDKII;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6CF0", Offset = "0x3CC5AF0", VA = "0x183CC6CF0")]
	public MNGHAKFLIOK(T1 AAKKPPCNMPP, T2 BACHDIBGPPN, T3 BOHGPOGLANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3CC64F0", Offset = "0x3CC52F0", VA = "0x183CC64F0", Slot = "4")]
	public int CompareTo(MNGHAKFLIOK<T1, T2, T3> LCIDHBCOPEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6740", Offset = "0x3CC5540", VA = "0x183CC6740", Slot = "0")]
	public override bool Equals(object LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6980", Offset = "0x3CC5780", VA = "0x183CC6980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6A20", Offset = "0x3CC5820", VA = "0x183CC6A20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T DHGNDNJJJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1F08EB0", Offset = "0x1F07CB0", VA = "0x181F08EB0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1F08CA0", Offset = "0x1F07AA0", VA = "0x181F08CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float EDAFDKJEBNK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAAF580", Offset = "0xAAE380", VA = "0x180AAF580")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x42FA390", Offset = "0x42F9190", VA = "0x1842FA390")]
	public T PMIABILFGCL(float KMHHCKOIFKM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x42F9F00", Offset = "0x42F8D00", VA = "0x1842F9F00")]
	public T MHPGIFMMCEJ(float KMHHCKOIFKM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T EPKJHFPNBLD(T KADNMONNONH, T DCAFNABOJJA, float KMHHCKOIFKM);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD270", Offset = "0x5DBC070", VA = "0x185DBD270", Slot = "4")]
	protected override float EPKJHFPNBLD(float KADNMONNONH, float DCAFNABOJJA, float KMHHCKOIFKM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD2B0", Offset = "0x5DBC0B0", VA = "0x185DBD2B0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xBF4C30", Offset = "0xBF3A30", VA = "0x180BF4C30", Slot = "4")]
	protected override Vector3 EPKJHFPNBLD(Vector3 KADNMONNONH, Vector3 DCAFNABOJJA, float KMHHCKOIFKM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1670", Offset = "0x5DC0470", VA = "0x185DC1670")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCD40", Offset = "0x5DBBB40", VA = "0x185DBCD40", Slot = "4")]
	protected override Color EPKJHFPNBLD(Color KADNMONNONH, Color DCAFNABOJJA, float KMHHCKOIFKM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCE00", Offset = "0x5DBBC00", VA = "0x185DBCE00")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class EFNIJNBJLHE : EBAPGGFHLAC<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD070", Offset = "0x5DBBE70", VA = "0x185DBD070")]
	public EFNIJNBJLHE(int FNJNELBIPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD000", Offset = "0x5DBBE00", VA = "0x185DBD000", Slot = "6")]
	protected override uint LGJNBIKAEEM(uint BAKOIMDGEAF, string PHPDIJICBJO)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JFCFKCBAFMI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IDisposable ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public JFCFKCBAFMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OLPGMLFHENJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> MMEDOOILPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int ELONAMHGIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int PFEOJLKLEBO;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x37AF160", Offset = "0x37ADF60", VA = "0x1837AF160")]
	private OLPGMLFHENJ(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> CACHJJFBNGA, int FHKCNGPFHBA, int ALCCPEOPNBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3E17DA0", Offset = "0x3E16BA0", VA = "0x183E17DA0")]
	public static OLPGMLFHENJ<T> FMIHPEHEFKO()
	{
		return default(OLPGMLFHENJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3E183E0", Offset = "0x3E171E0", VA = "0x183E183E0")]
	public (int, int, Task<T>) LLEFCGBONMM(int FEKFCIGLEEF, [Optional] CancellationToken ELPOPHCEGNN, double IGPHDAEBEMO = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3E18050", Offset = "0x3E16E50", VA = "0x183E18050")]
	public void LCBEJFHIFOM(int FEKFCIGLEEF, int ALCCPEOPNBP, [In] T OKONIBAEEBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class CGPFCFHNGAF
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCC70", Offset = "0x5DBBA70", VA = "0x185DBCC70")]
	public static OLPGMLFHENJ<CJPHMHJPNKO> FMIHPEHEFKO()
	{
		return default(OLPGMLFHENJ<CJPHMHJPNKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCCC0", Offset = "0x5DBBAC0", VA = "0x185DBCCC0")]
	public static void LCBEJFHIFOM([In] this OLPGMLFHENJ<CJPHMHJPNKO> HLCOOGAGOEK, int FEKFCIGLEEF, int ALCCPEOPNBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DefaultMember("Item")]
public class KLJONNPNKOB<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TKey, TVal> AELIKDFMBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly Dictionary<TVal, TKey> COBNFPOIEME;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2F6E180", Offset = "0x2F6CF80", VA = "0x182F6E180", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool FDJGALFBLIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> LJNPJAKIEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3949540", Offset = "0x3948340", VA = "0x183949540", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> NMKAJDCHPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3A41EF0", Offset = "0x3A40CF0", VA = "0x183A41EF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal LNGAKLGPPKB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3A41E90", Offset = "0x3A40C90", VA = "0x183A41E90", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3A41F50", Offset = "0x3A40D50", VA = "0x183A41F50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey LNGAKLGPPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3A41980", Offset = "0x3A40780", VA = "0x183A41980")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3A411B0", Offset = "0x3A3FFB0", VA = "0x183A411B0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3A41C20", Offset = "0x3A40A20", VA = "0x183A41C20", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3A41160", Offset = "0x3A3FF60", VA = "0x183A41160", Slot = "9")]
	public void Add(TKey GAMCILOFBAF, TVal PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3A41130", Offset = "0x3A3FF30", VA = "0x183A41130", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> DAPKCDOOBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x34529B0", Offset = "0x34517B0", VA = "0x1834529B0", Slot = "8")]
	public bool ContainsKey(TKey GAMCILOFBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3A41270", Offset = "0x3A40070", VA = "0x183A41270", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> DAPKCDOOBFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3A41B90", Offset = "0x3A40990", VA = "0x183A41B90", Slot = "10")]
	public bool Remove(TKey GAMCILOFBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3A41BC0", Offset = "0x3A409C0", VA = "0x183A41BC0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> DAPKCDOOBFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3A41D10", Offset = "0x3A40B10", VA = "0x183A41D10", Slot = "11")]
	public bool TryGetValue(TKey GAMCILOFBAF, [Out] TVal PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3A413B0", Offset = "0x3A401B0", VA = "0x183A413B0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3A412A0", Offset = "0x3A400A0", VA = "0x183A412A0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] LPMIAHOCPLL, int LKGKKAPFOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3A41890", Offset = "0x3A40690", VA = "0x183A41890")]
	public bool OLBECDHEMJL(TVal GAMCILOFBAF, [Out] TKey PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3A416D0", Offset = "0x3A404D0", VA = "0x183A416D0")]
	private void MAPHBLBDLPM(TKey GAMCILOFBAF, TVal DEEINHGIBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3A419D0", Offset = "0x3A407D0", VA = "0x183A419D0")]
	private void PLIPCINLJIK(TKey GAMCILOFBAF, TVal DEEINHGIBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3A415F0", Offset = "0x3A403F0", VA = "0x183A415F0")]
	private bool IMFCOMMJIAF(TKey GAMCILOFBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3A41D50", Offset = "0x3A40B50", VA = "0x183A41D50")]
	public KLJONNPNKOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class NACGFCEKKDC<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private NACGFCEKKDC<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x3160E20", Offset = "0x315FC20", VA = "0x183160E20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3162390", Offset = "0x3161190", VA = "0x183162390")]
		public Enumerator(NACGFCEKKDC<T> BNFLLCFHIAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x315FAB0", Offset = "0x315E8B0", VA = "0x18315FAB0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x315FEF0", Offset = "0x315ECF0", VA = "0x18315FEF0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x315FBF0", Offset = "0x315E9F0", VA = "0x18315FBF0")]
		private void PLFJFLKIKII()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private T[] ABPCBCABECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int FNPACLAMELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int HFFNIOFEMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int PPBKIGHJOID;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3CFE260", Offset = "0x3CFD060", VA = "0x183CFE260")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T LNGAKLGPPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3CFF460", Offset = "0x3CFE260", VA = "0x183CFF460")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3CFEE80", Offset = "0x3CFDC80", VA = "0x183CFEE80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3CFF630", Offset = "0x3CFE430", VA = "0x183CFF630")]
	public NACGFCEKKDC(int FNJNELBIPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3CFEB70", Offset = "0x3CFD970", VA = "0x183CFEB70")]
	public void JHPNFEHLKNP(T KMHHCKOIFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3CFEC70", Offset = "0x3CFDA70", VA = "0x183CFEC70")]
	public void LPNBJONBLDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3CFE2A0", Offset = "0x3CFD0A0", VA = "0x183CFE2A0")]
	public void HCEPCGCKPEJ(int PDNIMDHODLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3CFE350", Offset = "0x3CFD150", VA = "0x183CFE350")]
	public void HKIOIMJLIOP(T[] LPMIAHOCPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3CFECC0", Offset = "0x3CFDAC0", VA = "0x183CFECC0")]
	public Enumerator NABGDMMLCNI()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3CFF4B0", Offset = "0x3CFE2B0", VA = "0x183CFF4B0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3CFF4B0", Offset = "0x3CFE2B0", VA = "0x183CFF4B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3CFEEF0", Offset = "0x3CFDCF0", VA = "0x183CFEEF0")]
	private int NOIAHBBGPDA(int NGIPPLLBEKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3CFEC40", Offset = "0x3CFDA40", VA = "0x183CFEC40")]
	private int LJKKECPHDDE(int NGIPPLLBEKC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class DKKEBPAGMOH<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Func<Internal, External> PEHHEKOFDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private IReadOnlyList<Internal> LCPNBOPPGBK;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External LNGAKLGPPKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4DA0660", Offset = "0x4D9F460", VA = "0x184DA0660", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4DA05A0", Offset = "0x4D9F3A0", VA = "0x184DA05A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x770FF0", Offset = "0x76FDF0", VA = "0x180770FF0")]
	public DKKEBPAGMOH(Func<Internal, External> PEHHEKOFDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4DA0550", Offset = "0x4D9F350", VA = "0x184DA0550")]
	public DKKEBPAGMOH(IReadOnlyList<Internal> LCPNBOPPGBK, Func<Internal, External> PEHHEKOFDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4DA04D0", Offset = "0x4D9F2D0", VA = "0x184DA04D0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x33BBF00", Offset = "0x33BAD00", VA = "0x1833BBF00", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class OKPDOKOKFPI<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate Task<TResult> BFDINGOGCKD(TRequest MGDLKMJIAPA, CancellationToken ELPOPHCEGNN);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum NFJGAAFFONK
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class NODHKOOMPMF
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const float OFBDEEPFFOD = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TimeSpan GAHHIJHLEBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int PIIFBOBOAID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NFJGAAFFONK MBPAKJBMLJK;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly NODHKOOMPMF PJHGNDJLIEP;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float HIFGMMGELKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x3D2EF70", Offset = "0x3D2DD70", VA = "0x183D2EF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan FIIEECAEFKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3D2EFE0", Offset = "0x3D2DDE0", VA = "0x183D2EFE0")]
		public NODHKOOMPMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private readonly struct KHECLNGPNHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly TRequest MGDLKMJIAPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly CancellationToken ELPOPHCEGNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly TaskCompletionSource<TResult> MJMIBDGKDFM;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3A39280", Offset = "0x3A38080", VA = "0x183A39280")]
		public KHECLNGPNHH(TRequest MGDLKMJIAPA, TaskCompletionSource<TResult> MJMIBDGKDFM, CancellationToken ELPOPHCEGNN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct GOIIGBNOOLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public OKPDOKOKFPI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x35F7E90", Offset = "0x35F6C90", VA = "0x1835F7E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x35F8AF0", Offset = "0x35F78F0", VA = "0x1835F8AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct HBGGPPICFIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public OKPDOKOKFPI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private KHECLNGPNHH <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x36299C0", Offset = "0x36287C0", VA = "0x1836299C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x362AB30", Offset = "0x3629930", VA = "0x18362AB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CancellationTokenSource ODJBPANPHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<KHECLNGPNHH> BGKDDJBBOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly NODHKOOMPMF AGFKLOFDPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly BFDINGOGCKD JCLPJHLBNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Task AOEHNBOLLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int HFHLEABBJGM;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3E0CA20", Offset = "0x3E0B820", VA = "0x183E0CA20")]
	public OKPDOKOKFPI(BFDINGOGCKD JCLPJHLBNOA, [Optional] NODHKOOMPMF AGFKLOFDPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B3B0", Offset = "0x3E0A1B0", VA = "0x183E0B3B0")]
	public Task<TResult> CJECGFDDAID(TRequest MGDLKMJIAPA, CancellationToken ELPOPHCEGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B270", Offset = "0x3E0A070", VA = "0x183E0B270")]
	private void AJKKBOMFLDN(KHECLNGPNHH JIPAGJBNLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C3A0", Offset = "0x3E0B1A0", VA = "0x183E0C3A0")]
	[AsyncStateMachine(typeof(OKPDOKOKFPI<, >.GOIIGBNOOLP))]
	private Task EDCKJHGDLNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B9F0", Offset = "0x3E0A7F0", VA = "0x183E0B9F0")]
	private KHECLNGPNHH DFDKKBCOIHD()
	{
		return default(KHECLNGPNHH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C740", Offset = "0x3E0B540", VA = "0x183E0C740")]
	[AsyncStateMachine(typeof(OKPDOKOKFPI<, >.HBGGPPICFIO))]
	private Task MPIFLKNMHDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C650", Offset = "0x3E0B450", VA = "0x183E0C650")]
	private void KEKCFNKEAJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C1C0", Offset = "0x3E0AFC0", VA = "0x183E0C1C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class BKPJBPNBNAD<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly List<T> LCPNBOPPGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private HashSet<T> JIOMEFBJNHJ;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2F6E180", Offset = "0x2F6CF80", VA = "0x182F6E180", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool FDJGALFBLIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T LNGAKLGPPKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3E19820", Offset = "0x3E18620", VA = "0x183E19820", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x45F8080", Offset = "0x45F6E80", VA = "0x1845F8080", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x34A9F50", Offset = "0x34A8D50", VA = "0x1834A9F50", Slot = "11")]
	public void Add(T DAPKCDOOBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x45F7AE0", Offset = "0x45F68E0", VA = "0x1845F7AE0")]
	public bool MFJPCMAFKDM(T DAPKCDOOBFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x45F7EF0", Offset = "0x45F6CF0", VA = "0x1845F7EF0", Slot = "15")]
	public bool Remove(T DAPKCDOOBFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3CAF8A0", Offset = "0x3CAE6A0", VA = "0x183CAF8A0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x34C9870", Offset = "0x34C8670", VA = "0x1834C9870", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x45F7850", Offset = "0x45F6650", VA = "0x1845F7850", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x45F78B0", Offset = "0x45F66B0", VA = "0x1845F78B0", Slot = "13")]
	public bool Contains(T DAPKCDOOBFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x45F78F0", Offset = "0x45F66F0", VA = "0x1845F78F0", Slot = "14")]
	public void CopyTo(T[] LPMIAHOCPLL, int LKGKKAPFOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3A5EEE0", Offset = "0x3A5DCE0", VA = "0x183A5EEE0", Slot = "6")]
	public int IndexOf(T DAPKCDOOBFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x45F7920", Offset = "0x45F6720", VA = "0x1845F7920", Slot = "7")]
	public void Insert(int NGIPPLLBEKC, T DAPKCDOOBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x45F7D60", Offset = "0x45F6B60", VA = "0x1845F7D60", Slot = "8")]
	public void RemoveAt(int NGIPPLLBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x45F7F90", Offset = "0x45F6D90", VA = "0x1845F7F90")]
	public BKPJBPNBNAD()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x204A440", Offset = "0x2049240", VA = "0x18204A440")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0BF0", Offset = "0x5DBF9F0", VA = "0x185DC0BF0")]
		public SerializedGuid([In] Guid CHLMGBPAGHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0AB0", Offset = "0x5DBF8B0", VA = "0x185DC0AB0")]
		public static SerializedGuid GELGIIBGMFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0940", Offset = "0x5DBF740", VA = "0x185DC0940")]
		public static SerializedGuid BNIONBCHCGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5DC08E0", Offset = "0x5DBF6E0", VA = "0x185DC08E0")]
		public bool BGJCPKHADFA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0BC0", Offset = "0x5DBF9C0", VA = "0x185DC0BC0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0B40", Offset = "0x5DBF940", VA = "0x185DC0B40", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5DC09E0", Offset = "0x5DBF7E0", VA = "0x185DC09E0", Slot = "7")]
		public bool Equals(SerializedGuid LCIDHBCOPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0A20", Offset = "0x5DBF820", VA = "0x185DC0A20", Slot = "0")]
		public override bool Equals(object KANAGAAAGHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0B30", Offset = "0x5DBF930", VA = "0x185DC0B30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5DC09B0", Offset = "0x5DBF7B0", VA = "0x185DC09B0", Slot = "6")]
		public int CompareTo(SerializedGuid LCIDHBCOPEO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EADGKOPLMEK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly Type GEGOJCACMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly string GFCPEGDOLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly bool PBHOJBEPECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly bool GNKGMBJCOIN;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCE40", Offset = "0x5DBBC40", VA = "0x185DBCE40")]
	public EADGKOPLMEK(Type MFEALBBGKFA, string ILGPDBNCHFJ, bool FHDAIPKPOGP = false, bool FDOLLBHBCAE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class EFBOHLFDEBA<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public readonly struct ABHHLFCKLGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public readonly long FICIFIIKHII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public readonly long PIKDMOIMIFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly int PODFBGDEPMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly int DIDDHNMHLAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly bool ADCOKFCGMIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string DBIBEGNBOCF;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x379BE70", Offset = "0x379AC70", VA = "0x18379BE70")]
		public ABHHLFCKLGH(long FICIFIIKHII, int PODFBGDEPMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x379BEE0", Offset = "0x379ACE0", VA = "0x18379BEE0")]
		public ABHHLFCKLGH(long FICIFIIKHII, long PIKDMOIMIFO, int PODFBGDEPMI, int DIDDHNMHLAL, bool ADCOKFCGMIH, string DBIBEGNBOCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x379BD80", Offset = "0x379AB80", VA = "0x18379BD80")]
		public int BGHKNFELFHL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x379BD60", Offset = "0x379AB60", VA = "0x18379BD60")]
		public int BCIKKEPPBPI(int HBOICPENABE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x379BD00", Offset = "0x379AB00", VA = "0x18379BD00")]
		public double ABNMBCGHHBL()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x379BDD0", Offset = "0x379ABD0", VA = "0x18379BDD0")]
		public ABHHLFCKLGH DBFCEGLFOBH(long PIKDMOIMIFO, int DIDDHNMHLAL)
		{
			return default(ABHHLFCKLGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class IPACEPEMCAN : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct JNBMFEJAEJD<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public IPACEPEMCAN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public Func<IPACEPEMCAN, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private IPACEPEMCAN <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x39C91C0", Offset = "0x39C7FC0", VA = "0x1839C91C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x30D0840", Offset = "0x30CF640", VA = "0x1830D0840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly TKey OLNAGICFANI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly EFBOHLFDEBA<TKey> CGEFCMPOECE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly BOGDNAKJHCL BNIILMIMBGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private List<IPACEPEMCAN> MDNBFDAFFFO;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string BMFONDKBFJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x376F5B0", Offset = "0x376E3B0", VA = "0x18376F5B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<IPACEPEMCAN> KEEMEJDOOCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x376F210", Offset = "0x376E010", VA = "0x18376F210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public ABHHLFCKLGH EEOOMDLEFOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x376F5E0", Offset = "0x376E3E0", VA = "0x18376F5E0")]
			[CompilerGenerated]
			get
			{
				return default(ABHHLFCKLGH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x376F600", Offset = "0x376E400", VA = "0x18376F600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x376F630", Offset = "0x376E430", VA = "0x18376F630")]
		internal IPACEPEMCAN(EFBOHLFDEBA<TKey> CGEFCMPOECE, TKey GAMCILOFBAF, BOGDNAKJHCL BNIILMIMBGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x376F450", Offset = "0x376E250", VA = "0x18376F450")]
		public IPACEPEMCAN GCOGNLFNCED(TKey GAMCILOFBAF, [Optional] BOGDNAKJHCL? AGBDOPMEHIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x23811B0", Offset = "0x237FFB0", VA = "0x1823811B0")]
		[AsyncStateMachine(typeof(JNBMFEJAEJD<>))]
		public Task<T> JIEHNJAAELK<T>(TKey GAMCILOFBAF, Func<IPACEPEMCAN, Task<T>> MGDCGIGLBNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x376F250", Offset = "0x376E050", VA = "0x18376F250", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class EODOANEMNKE : IEnumerable<(TKey, List<TKey>, ABHHLFCKLGH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, ABHHLFCKLGH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private (TKey key, List<TKey> path, ABHHLFCKLGH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public EFBOHLFDEBA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private IEnumerator<(TKey key, List<TKey> path, ABHHLFCKLGH timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, ABHHLFCKLGH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2039540", Offset = "0x2038340", VA = "0x182039540", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, ABHHLFCKLGH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x30FEEA0", Offset = "0x30FDCA0", VA = "0x1830FEEA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2039630", Offset = "0x2038430", VA = "0x182039630")]
		[DebuggerHidden]
		public EODOANEMNKE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x30FEF00", Offset = "0x30FDD00", VA = "0x1830FEF00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x30FE9F0", Offset = "0x30FD7F0", VA = "0x1830FE9F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x30FE9A0", Offset = "0x30FD7A0", VA = "0x1830FE9A0")]
		private void FKICEAEIDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x30FEE50", Offset = "0x30FDC50", VA = "0x1830FEE50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x30FED90", Offset = "0x30FDB90", VA = "0x1830FED90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, ABHHLFCKLGH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x30FA990", Offset = "0x30F9790", VA = "0x1830FA990", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class DPAFFFCGFLO : IEnumerable<(TKey, List<TKey>, ABHHLFCKLGH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, ABHHLFCKLGH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private (TKey key, List<TKey> path, ABHHLFCKLGH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private IPACEPEMCAN timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public IPACEPEMCAN <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public EFBOHLFDEBA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private IEnumerator<IPACEPEMCAN> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private IEnumerator<(TKey key, List<TKey> path, ABHHLFCKLGH timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, ABHHLFCKLGH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2039540", Offset = "0x2038340", VA = "0x182039540", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, ABHHLFCKLGH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x4DCE670", Offset = "0x4DCD470", VA = "0x184DCE670", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2039630", Offset = "0x2038430", VA = "0x182039630")]
		[DebuggerHidden]
		public DPAFFFCGFLO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4DCE6D0", Offset = "0x4DCD4D0", VA = "0x184DCE6D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4DCDD90", Offset = "0x4DCCB90", VA = "0x184DCDD90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4DCDD30", Offset = "0x4DCCB30", VA = "0x184DCDD30")]
		private void FKICEAEIDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4DCDCD0", Offset = "0x4DCCAD0", VA = "0x184DCDCD0")]
		private void CEJKOOJCMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4DCE620", Offset = "0x4DCD420", VA = "0x184DCE620", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4DCE540", Offset = "0x4DCD340", VA = "0x184DCE540", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, ABHHLFCKLGH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4106E00", Offset = "0x4105C00", VA = "0x184106E00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly Action<TKey, ABHHLFCKLGH, BOGDNAKJHCL> EDMDHFJBPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Action<TKey, ABHHLFCKLGH, BOGDNAKJHCL> DBGBGBPGHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly Action<EFBOHLFDEBA<TKey>, BOGDNAKJHCL> JJDNBFNIPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly BOGDNAKJHCL BNIILMIMBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly IPACEPEMCAN NMHPKKJPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool AOBNNKEMCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private int KGKBCCJAMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Stopwatch AOOGNFOIAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly int NPEBKJMNFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private string BFIIBKPLIDE;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IPACEPEMCAN GLAPGENNBKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x772C00", Offset = "0x771A00", VA = "0x180772C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string BMFONDKBFJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x76FF50", Offset = "0x76ED50", VA = "0x18076FF50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x30DA720", Offset = "0x30D9520", VA = "0x1830DA720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x30DA800", Offset = "0x30D9600", VA = "0x1830DA800")]
	public EFBOHLFDEBA(TKey CCAMDIEOBGP, BOGDNAKJHCL BNIILMIMBGO, [Optional] int? PODFBGDEPMI, [Optional][CanBeNull] Stopwatch AOOGNFOIAFL, [Optional] Action<TKey, ABHHLFCKLGH, BOGDNAKJHCL> EDMDHFJBPBJ, [Optional] Action<TKey, ABHHLFCKLGH, BOGDNAKJHCL> DBGBGBPGHFL, [Optional] Action<EFBOHLFDEBA<TKey>, BOGDNAKJHCL> JJDNBFNIPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x30DA690", Offset = "0x30D9490", VA = "0x1830DA690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x30DA600", Offset = "0x30D9400", VA = "0x1830DA600")]
	[IteratorStateMachine(typeof(EFBOHLFDEBA<>.EODOANEMNKE))]
	public IEnumerable<(TKey, List<TKey>, ABHHLFCKLGH)> BGCPKFOPODL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x30DA530", Offset = "0x30D9330", VA = "0x1830DA530")]
	[IteratorStateMachine(typeof(EFBOHLFDEBA<>.DPAFFFCGFLO))]
	private IEnumerable<(TKey, List<TKey>, ABHHLFCKLGH)> BGCPKFOPODL(List<TKey> HIHCOIEMKOI, IPACEPEMCAN IPJFCAHHMLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x30DA780", Offset = "0x30D9580", VA = "0x1830DA780")]
	private (long, int) PJFOHIBFKGC()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public abstract class FDFLMDENMMJ<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut EBGMKEPDKHB(EFBOHLFDEBA<TKey> CGEFCMPOECE);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	protected FDFLMDENMMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public abstract class ELBLHFFGLLK<TKey> : FDFLMDENMMJ<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate string LAKIEIMEFKM(TKey GAMCILOFBAF);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x30FACA0", Offset = "0x30F9AA0", VA = "0x1830FACA0")]
	private static string CLJIFNMNILP(TKey GAMCILOFBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x30FAE30", Offset = "0x30F9C30", VA = "0x1830FAE30", Slot = "4")]
	public override string EBGMKEPDKHB(EFBOHLFDEBA<TKey> CGEFCMPOECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x30FACE0", Offset = "0x30F9AE0", VA = "0x1830FACE0")]
	public string EBGMKEPDKHB(EFBOHLFDEBA<TKey> CGEFCMPOECE, [NotNull] LAKIEIMEFKM PNINICCHNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string LLHMGCEFCHD(EFBOHLFDEBA<TKey> CGEFCMPOECE, [NotNull] LAKIEIMEFKM PNINICCHNOB);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x30FAEF0", Offset = "0x30F9CF0", VA = "0x1830FAEF0")]
	protected ELBLHFFGLLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class DCKEMIGADKM<TKey> : FDFLMDENMMJ<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate string DFIIOCEKJKL(TKey GAMCILOFBAF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly string BGKGEIMOHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly double GLHCLAIJIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly bool PDNPOPKJNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int CIGILIPNDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly ISet<string> DGNABIIDCIO;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4D75D00", Offset = "0x4D74B00", VA = "0x184D75D00")]
	private static string CLJIFNMNILP(TKey GAMCILOFBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4D76870", Offset = "0x4D75670", VA = "0x184D76870")]
	public DCKEMIGADKM(string BGKGEIMOHAL = "F2", double GLHCLAIJIDG = double.MaxValue, bool PDNPOPKJNFA = false, int CIGILIPNDLA = int.MaxValue, [Optional] ISet<string> DGNABIIDCIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x4D76330", Offset = "0x4D75130", VA = "0x184D76330", Slot = "4")]
	public override Dictionary<string, string> EBGMKEPDKHB(EFBOHLFDEBA<TKey> CGEFCMPOECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4D76790", Offset = "0x4D75590", VA = "0x184D76790")]
	private bool OIHBCFLIONC(string DBEBCGICEMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4D75D40", Offset = "0x4D74B40", VA = "0x184D75D40")]
	public Dictionary<string, string> EBGMKEPDKHB(EFBOHLFDEBA<TKey> CGEFCMPOECE, DFIIOCEKJKL PNINICCHNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4D76550", Offset = "0x4D75350", VA = "0x184D76550")]
	private string IBLPENHLDHH(StringBuilder FGLDGPJBHIJ, List<TKey> CLNHHIOMJHG, DFIIOCEKJKL PNINICCHNOB, bool FAPPMALPFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4D763F0", Offset = "0x4D751F0", VA = "0x184D763F0")]
	private static void GDOKNPALLIG(StringBuilder ECPLGKJJECI, string HFOGEFPEMAA, bool EEBIPECKKHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class NJEOLIMNMCF<TKey> : ELBLHFFGLLK<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct HBPFKOGBCIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public LAKIEIMEFKM keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static NJEOLIMNMCF<TKey> ANGIAPALHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string[] ALLEKJOFDLC;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3D1F420", Offset = "0x3D1E220", VA = "0x183D1F420")]
	private NJEOLIMNMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3D1E3C0", Offset = "0x3D1D1C0", VA = "0x183D1E3C0", Slot = "5")]
	protected override string LLHMGCEFCHD(EFBOHLFDEBA<TKey> CGEFCMPOECE, LAKIEIMEFKM PNINICCHNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3D1F1F0", Offset = "0x3D1DFF0", VA = "0x183D1F1F0")]
	[CompilerGenerated]
	internal static string NKKOCAOAEMK(string OLBNDDKOPIM, TKey GAMCILOFBAF, HBPFKOGBCIM P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class OAPFDHPJMOP : EFBOHLFDEBA<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class ILADNNHGEPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Action<OAPFDHPJMOP, BOGDNAKJHCL> callback;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public ILADNNHGEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD460", Offset = "0x5DBC260", VA = "0x185DBD460")]
		internal void GBNPBAAFCKP(EFBOHLFDEBA<string> timer, BOGDNAKJHCL log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5DBF350", Offset = "0x5DBE150", VA = "0x185DBF350")]
	public OAPFDHPJMOP(BOGDNAKJHCL BNIILMIMBGO, [Optional] string NMEMBBHLHIJ, [Optional] int? PODFBGDEPMI, [Optional] Stopwatch AOOGNFOIAFL, [Optional] Action<string, ABHHLFCKLGH, BOGDNAKJHCL> EDMDHFJBPBJ, [Optional] Action<string, ABHHLFCKLGH, BOGDNAKJHCL> DBGBGBPGHFL, [Optional] Action<OAPFDHPJMOP, BOGDNAKJHCL> JJDNBFNIPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5DBF290", Offset = "0x5DBE090", VA = "0x185DBF290")]
	private static Action<EFBOHLFDEBA<string>, BOGDNAKJHCL> GKPJFPMDIHO(Action<OAPFDHPJMOP, BOGDNAKJHCL> PJJEKPONKPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public abstract class EMFHBELMKOK
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private class EFHHBPAGNCH : EMFHBELMKOK
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static EMFHBELMKOK ANGIAPALHML
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x5DBCEB0", Offset = "0x5DBBCB0", VA = "0x185DBCEB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float DIIGEEDEIED
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x1C8D930", Offset = "0x1C8C730", VA = "0x181C8D930", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5DBCFB0", Offset = "0x5DBBDB0", VA = "0x185DBCFB0")]
		public EFHHBPAGNCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static EMFHBELMKOK HMLNDDIAKPH;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static EMFHBELMKOK PJHGNDJLIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD0C0", Offset = "0x5DBBEC0", VA = "0x185DBD0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float DIIGEEDEIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	protected EMFHBELMKOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class FOAAHGBAPBN : CFJNJKOFNOK<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD230", Offset = "0x5DBC030", VA = "0x185DBD230")]
	public FOAAHGBAPBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CFJNJKOFNOK<T> : ENDMHFEHIBD<T>, GNJDEICEPMH, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task<T> EIFMLFKMLIG
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public HIIDJBNNIDE<T> LIFGIPKKMDK
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x49B5E20", Offset = "0x49B4C20", VA = "0x1849B5E20")]
	public CFJNJKOFNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class LLNPJPHPFOG<T> : ENDMHFEHIBD<T>, GNJDEICEPMH, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Task<T> EIFMLFKMLIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public HIIDJBNNIDE<T> LIFGIPKKMDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3ACAA20", Offset = "0x3AC9820", VA = "0x183ACAA20")]
	public LLNPJPHPFOG(Exception HCEKMCLPHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface GNJDEICEPMH : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface ENDMHFEHIBD<T> : GNJDEICEPMH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	[NotNull]
	Task<T> EIFMLFKMLIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	HIIDJBNNIDE<T> LIFGIPKKMDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class LAMLADAMGBC
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	protected static bool JJEMAEEMCHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDD40", Offset = "0x5DBCB40", VA = "0x185DBDD40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDD90", Offset = "0x5DBCB90", VA = "0x185DBDD90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5DBDDF0", Offset = "0x5DBCBF0", VA = "0x185DBDDF0")]
	static LAMLADAMGBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	protected LAMLADAMGBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public abstract class ECCLGGJNNDK<TTask, T> : LAMLADAMGBC, ENDMHFEHIBD<T>, GNJDEICEPMH, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class ACODCEOMDLA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public ACODCEOMDLA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x2F5EDD0", Offset = "0x2F5DBD0", VA = "0x182F5EDD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x2F5F340", Offset = "0x2F5E140", VA = "0x182F5F340", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public ECCLGGJNNDK<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public ACODCEOMDLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x379D320", Offset = "0x379C120", VA = "0x18379D320")]
		[AsyncStateMachine(typeof(ECCLGGJNNDK<, >.ACODCEOMDLA.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> NIDMOFNMJNP(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Task<T> JFHMPGCGNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	protected readonly CancellationTokenSource MHPFKGBLOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool AOBNNKEMCKA;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Task<T> EIFMLFKMLIG
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public HIIDJBNNIDE<T> LIFGIPKKMDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JHCMEJDPEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x81DA80", Offset = "0x81C880", VA = "0x18081DA80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x30CFC10", Offset = "0x30CEA10", VA = "0x1830CFC10")]
	protected ECCLGGJNNDK(TTask JFHMPGCGNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x30CF9D0", Offset = "0x30CE7D0", VA = "0x1830CF9D0", Slot = "1")]
	~ECCLGGJNNDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x30CF9B0", Offset = "0x30CE7B0", VA = "0x1830CF9B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x30CF840", Offset = "0x30CE640", VA = "0x1830CF840")]
	private void DGLMKNHCGON(bool NOJBJHKLEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T EAILKACIGGH(TTask LMFDAMHHFPF);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void PBIFHIAPBCH();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class KPLJOICHOJM
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5DBDBB0", Offset = "0x5DBC9B0", VA = "0x185DBDBB0")]
	[NotNull]
	public static byte[] KOGCJKEFCIO(this AIBBHMFDMPN KEGCBOMBCGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5DBDB40", Offset = "0x5DBC940", VA = "0x185DBDB40")]
	[NotNull]
	public static byte[] KOGCJKEFCIO(this AIBBHMFDMPN KEGCBOMBCGK, HashAlgorithmName DEGAFMPCGOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD9B0", Offset = "0x5DBC7B0", VA = "0x185DBD9B0")]
	public static bool HDPGDGJNLBD([CanBeNull] this AIBBHMFDMPN KEGCBOMBCGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD810", Offset = "0x5DBC610", VA = "0x185DBD810")]
	public static bool HDPGDGJNLBD([CanBeNull] this AIBBHMFDMPN KEGCBOMBCGK, [Out] string LMJIIJBFLBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5DBDC20", Offset = "0x5DBCA20", VA = "0x185DBDC20")]
	private static bool NHAIKNPFIEL([NotNull] AIBBHMFDMPN KEGCBOMBCGK, [Out][CanBeNull] byte[] KJLBAPABBBE, [Out][CanBeNull] byte[] DBDBKNKNEDA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class IOHMGNOGGGN
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD4F0", Offset = "0x5DBC2F0", VA = "0x185DBD4F0")]
	[NotNull]
	public static byte[] KOGCJKEFCIO(this JIEICLNNGCF CJGPNPBNMHA, HashAlgorithmName DEGAFMPCGOP, byte[] DAFHOJMKDOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface JIEICLNNGCF
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash BAKOIMDGEAF);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface AIBBHMFDMPN : JIEICLNNGCF
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[CanBeNull]
	byte[] BAIFDECJCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[CanBeNull]
	byte[] KCFLGMMCGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class AKNGMELJFPM
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static readonly ArrayPool<byte> MOHPMKKPDBN;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static bool DGKNHOOFMGE;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4C0", Offset = "0x5DBB2C0", VA = "0x185DBC4C0")]
	public static void HOPEGHAAHAG(this IncrementalHash PHOAPDHFNID, [CanBeNull] GameObject CJHJDJNKIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2AFE5E0", Offset = "0x2AFD3E0", VA = "0x182AFE5E0")]
	public static void HOPEGHAAHAG<T>(this IncrementalHash PHOAPDHFNID, [CanBeNull] T FMOHLHFOMNJ) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2AFE550", Offset = "0x2AFD350", VA = "0x182AFE550")]
	public static void DLJLCLGKKMD<T>(this IncrementalHash PHOAPDHFNID, [CanBeNull] T CJGPNPBNMHA) where T : JIEICLNNGCF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2AFECD0", Offset = "0x2AFDAD0", VA = "0x182AFECD0")]
	public static void MPDNNDINKNP<T>(this IncrementalHash PHOAPDHFNID, [CanBeNull] IList<T> NEIMCILLPBM) where T : JIEICLNNGCF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC8A0", Offset = "0x5DBB6A0", VA = "0x185DBC8A0")]
	private static bool OCBNFLDODJG([CanBeNull] JIEICLNNGCF CJGPNPBNMHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC400", Offset = "0x5DBB200", VA = "0x185DBC400")]
	public static void GDCFJBMJAOA(this IncrementalHash BAKOIMDGEAF, [CanBeNull] string NEEABJMPINJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC120", Offset = "0x5DBAF20", VA = "0x185DBC120")]
	public static void EOEOCGKPIEK(this IncrementalHash BAKOIMDGEAF, long KCKHGNEDGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5DBBF50", Offset = "0x5DBAD50", VA = "0x185DBBF50")]
	public static void CDAGEPMLHJL(this IncrementalHash BAKOIMDGEAF, int GCKAADKPANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC930", Offset = "0x5DBB730", VA = "0x185DBC930")]
	public static void OLIJOBCHCIA(this IncrementalHash BAKOIMDGEAF, short IPDOFHCFLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC2F0", Offset = "0x5DBB0F0", VA = "0x185DBC2F0")]
	public static void FNCFBNILPEE(this IncrementalHash BAKOIMDGEAF, byte OAGIIBOAANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC6D0", Offset = "0x5DBB4D0", VA = "0x185DBC6D0")]
	public static void LIKNBFGKADF(this IncrementalHash BAKOIMDGEAF, bool CGHMDFCKCJE, bool HBAMJPKJBEF = false, bool PAJMFCFNAON = false, bool FKCEKNGANFE = false, bool DGAAODCEFCP = false, bool MKMDEEEIKAB = false, bool NGMAMDAODBB = false, bool DNIPDFBJPJI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2AFE6A0", Offset = "0x2AFD4A0", VA = "0x182AFE6A0")]
	public static void KKGMDKEGMLA<T>(this IncrementalHash BAKOIMDGEAF, T AONAOKPLIKJ) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCB00", Offset = "0x5DBB900", VA = "0x185DBCB00")]
	public static void OOOGKCGGIHD(this IncrementalHash BAKOIMDGEAF, float OJDFJONDAGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5DBBEF0", Offset = "0x5DBACF0", VA = "0x185DBBEF0")]
	public static void ABJHNLHNGOB(this IncrementalHash BAKOIMDGEAF, ulong DGNIIBABCAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC840", Offset = "0x5DBB640", VA = "0x185DBC840")]
	public static void LJFLPMMDIAO(this IncrementalHash BAKOIMDGEAF, uint KNECKECOCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC460", Offset = "0x5DBB260", VA = "0x185DBC460")]
	public static void HEEFOGIJNBM(this IncrementalHash BAKOIMDGEAF, ushort MBFOGKCHIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC5A0", Offset = "0x5DBB3A0", VA = "0x185DBC5A0")]
	public static void KCHANNGNANF(this IncrementalHash BAKOIMDGEAF, Vector3 DKOIOEAKNOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class JMEFBLKMKDE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD7B0", Offset = "0x5DBC5B0", VA = "0x185DBD7B0")]
	public JMEFBLKMKDE(string KHIFMDJDLEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class NOEMCHLALGD<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class APHDDPAEAOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public TNode HLCOOGAGOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public TNode BMNEKBHDGLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public JCEIPGFHLGA GLLNGEOKFID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public List<JCEIPGFHLGA> LIAJGHNLCBB;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public APHDDPAEAOJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal struct JCEIPGFHLGA : IComparable<JCEIPGFHLGA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int CFGOOEPMJGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public TClaimant CNNPIJDAIIB;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xB355E0", Offset = "0xB343E0", VA = "0x180B355E0")]
		public JCEIPGFHLGA(int CFGOOEPMJGN, TClaimant CNNPIJDAIIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3923D00", Offset = "0x3922B00", VA = "0x183923D00")]
		public bool EMHGOHEADDB([In] JCEIPGFHLGA LCIDHBCOPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3923D60", Offset = "0x3922B60", VA = "0x183923D60")]
		public bool NBLFHNHGDLK([In] JCEIPGFHLGA LCIDHBCOPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3923CF0", Offset = "0x3922AF0", VA = "0x183923CF0", Slot = "4")]
		public int CompareTo(JCEIPGFHLGA LCIDHBCOPEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3923D70", Offset = "0x3922B70", VA = "0x183923D70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum FJMGKDFGACL
	{
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class EGCBLNKIOPI : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public NOEMCHLALGD<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8C4CB0", Offset = "0x8C3AB0", VA = "0x1808C4CB0")]
		[DebuggerHidden]
		public EGCBLNKIOPI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x30E2410", Offset = "0x30E1210", VA = "0x1830E2410", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x30E2600", Offset = "0x30E1400", VA = "0x1830E2600", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x30E24F0", Offset = "0x30E12F0", VA = "0x1830E24F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x30E25D0", Offset = "0x30E13D0", VA = "0x1830E25D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly JBNDELMDIFB<APHDDPAEAOJ> FHJFCHADEGH;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly JBNDELMDIFB<List<JCEIPGFHLGA>> NGAPAFJIKNO;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static int BPLCCBHKKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	internal readonly Dictionary<TClaimant, TNode> AKKPFFDCANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	internal readonly Dictionary<TNode, APHDDPAEAOJ> GIAMGOKMBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private FJMGKDFGACL JCEEBKDBNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool JJLFBNEDAFO;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode DOGIJGBLGNI(TNode JAHOBDMOOOJ);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void MILGMIAMKKD(TNode JAHOBDMOOOJ, TClaimant GOFBEBDIIHF, TClaimant GLNLLIBBFEA);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3D30950", Offset = "0x3D2F750", VA = "0x183D30950")]
	public NOEMCHLALGD(FJMGKDFGACL JCEEBKDBNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F410", Offset = "0x3D2E210", VA = "0x183D2F410")]
	public void BPOFMPMFIAL(TNode JAHOBDMOOOJ, TNode BNOFKPJBDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F810", Offset = "0x3D2E610", VA = "0x183D2F810")]
	public void EDAGPINHCHG(TClaimant CNNPIJDAIIB, TNode MACNKPNIIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F640", Offset = "0x3D2E440", VA = "0x183D2F640", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3D305C0", Offset = "0x3D2F3C0", VA = "0x183D305C0")]
	private void MFCBAOEADKG(TClaimant CNNPIJDAIIB, TNode NCNGFJIEDCD, TNode MACNKPNIIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3D2FB90", Offset = "0x3D2E990", VA = "0x183D2FB90")]
	private int GGNHLOBEFOE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3D30190", Offset = "0x3D2EF90", VA = "0x183D30190")]
	private void KGOGODKKAEH(TClaimant CNNPIJDAIIB, TNode PJMOJHCIPKC, TNode LOMNBAMLPAF, int GMMPHFLEOMN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F5B0", Offset = "0x3D2E3B0", VA = "0x183D2F5B0")]
	private void DMKOJFLKOJO(JCEIPGFHLGA KLLIBBEBIKN, APHDDPAEAOJ NEEKJCNICKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F130", Offset = "0x3D2DF30", VA = "0x183D2F130")]
	private void BBEAPPNHDPI(TClaimant CNNPIJDAIIB, TNode PJMOJHCIPKC, TNode LOMNBAMLPAF, int GMMPHFLEOMN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F4A0", Offset = "0x3D2E2A0", VA = "0x183D2F4A0")]
	private void DKLECCELCLO(JCEIPGFHLGA KLLIBBEBIKN, TNode JAHOBDMOOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3D304D0", Offset = "0x3D2F2D0", VA = "0x183D304D0")]
	private void LCJLKIDMKGG(JCEIPGFHLGA KLLIBBEBIKN, APHDDPAEAOJ NEEKJCNICKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3D30660", Offset = "0x3D2F460", VA = "0x183D30660")]
	private void OBAMIIKCICE(APHDDPAEAOJ NEEKJCNICKO, bool FKHHJAFNLPD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3D2FC00", Offset = "0x3D2EA00", VA = "0x183D2FC00")]
	private void IBFOAFIJIOM(APHDDPAEAOJ NEEKJCNICKO, TNode BNOFKPJBDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3D2FF40", Offset = "0x3D2ED40", VA = "0x183D2FF40")]
	[IteratorStateMachine(typeof(NOEMCHLALGD<, >.EGCBLNKIOPI))]
	private IEnumerable<TNode> JLKOEGDBDJP(TNode PJMOJHCIPKC, TNode LOMNBAMLPAF, bool GAGNLEAAJCF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3D2FAA0", Offset = "0x3D2E8A0", VA = "0x183D2FAA0")]
	private APHDDPAEAOJ FLJGEDDOHAE(TNode JAHOBDMOOOJ, TNode BMNEKBHDGLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F930", Offset = "0x3D2E730", VA = "0x183D2F930")]
	private APHDDPAEAOJ FCOAGBCGGNG(TNode JAHOBDMOOOJ, TNode BMNEKBHDGLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3D30020", Offset = "0x3D2EE20", VA = "0x183D30020")]
	private void KDOOKPEJFOJ(APHDDPAEAOJ NEEKJCNICKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class EBAPGGFHLAC<T> : IEnumerable<EBAPGGFHLAC<T>.OEBBHPKIFKK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct OEBBHPKIFKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public T PHPDIJICBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int NGIPPLLBEKC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class GMFCOFBMBNJ : IEnumerator<OEBBHPKIFKK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private EBAPGGFHLAC<T> DCOGCCKNMPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private int NGIPPLLBEKC;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3107A60", Offset = "0x3106860", VA = "0x183107A60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public OEBBHPKIFKK POOLCAAKLKE
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x35EB060", Offset = "0x35E9E60", VA = "0x1835EB060", Slot = "4")]
			get
			{
				return default(OEBBHPKIFKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x35EAF70", Offset = "0x35E9D70", VA = "0x1835EAF70")]
		public GMFCOFBMBNJ(EBAPGGFHLAC<T> DCOGCCKNMPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x35EAE70", Offset = "0x35E9C70", VA = "0x1835EAE70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3157E20", Offset = "0x3156C20", VA = "0x183157E20", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1AD1810", Offset = "0x1AD0610", VA = "0x181AD1810", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct IDOADJOFELH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public bool HAHIOMDFIBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public T PHPDIJICBJO;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const int PIOEPMDMAEM = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly Dictionary<T, int> LMPDAEEAAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private IDOADJOFELH[] NNBKNMLOGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int NLFGKJFMPDB;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int GNBIHMPJOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF60", Offset = "0x7AED60", VA = "0x1807AFF60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7AF560", Offset = "0x7AE360", VA = "0x1807AF560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2F6E180", Offset = "0x2F6CF80", VA = "0x182F6E180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x30CD780", Offset = "0x30CC580", VA = "0x1830CD780")]
	public EBAPGGFHLAC(int FNJNELBIPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x30CD860", Offset = "0x30CC660", VA = "0x1830CD860")]
	public EBAPGGFHLAC(OEBBHPKIFKK[] GLIJHCPOLLK, bool CGBMEDEPOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x30CC680", Offset = "0x30CB480", VA = "0x1830CC680")]
	public int BBINFPDKLDG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x30CD140", Offset = "0x30CBF40", VA = "0x1830CD140")]
	private int PPFIGENPIEK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x30CC940", Offset = "0x30CB740", VA = "0x1830CC940", Slot = "6")]
	protected virtual uint LGJNBIKAEEM(uint BAKOIMDGEAF, T PHPDIJICBJO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x30CC870", Offset = "0x30CB670", VA = "0x1830CC870")]
	public bool LFOKLKCBMAF(T PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x30CCEE0", Offset = "0x30CBCE0", VA = "0x1830CCEE0")]
	public int NFPIHBFHJEB(T PHPDIJICBJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x30CC710", Offset = "0x30CB510", VA = "0x1830CC710")]
	public T JCFBGOJJKGI(int NGIPPLLBEKC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x30CCBD0", Offset = "0x30CB9D0", VA = "0x1830CCBD0")]
	public bool MFJPCMAFKDM(T PHPDIJICBJO, bool KJPLPKKLOPL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x30CCC70", Offset = "0x30CBA70", VA = "0x1830CCC70")]
	public bool MFJPCMAFKDM(T PHPDIJICBJO, int NGIPPLLBEKC, bool KJPLPKKLOPL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x30CC820", Offset = "0x30CB620", VA = "0x1830CC820")]
	private int LDFKFNAACFL(int FNPACLAMELJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x30CD330", Offset = "0x30CC130", VA = "0x1830CD330", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x30CD330", Offset = "0x30CC130", VA = "0x1830CD330", Slot = "4")]
	private IEnumerator<OEBBHPKIFKK> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class JBNDELMDIFB<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Stack<T> CCJIOIOELHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly List<T> KHEADAPJKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly int DIKOGNKOPBG;

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x391D370", Offset = "0x391C170", VA = "0x18391D370")]
	public static JBNDELMDIFB<T> EJCAIFANJPM(int FNJNELBIPIL = 0, int DIKOGNKOPBG = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x391DBC0", Offset = "0x391C9C0", VA = "0x18391DBC0")]
	public JBNDELMDIFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x391DA20", Offset = "0x391C820", VA = "0x18391DA20")]
	public JBNDELMDIFB(int FNJNELBIPIL, int DIKOGNKOPBG = int.MaxValue, bool FJMIBLBPOEE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x391D8A0", Offset = "0x391C6A0", VA = "0x18391D8A0")]
	public T PCLHBOCFOJG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x391D450", Offset = "0x391C250", VA = "0x18391D450")]
	public void HCFLFLFMJJD(T PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x391D7A0", Offset = "0x391C5A0", VA = "0x18391D7A0")]
	private void LBOJLGGOKNF(T PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x391D880", Offset = "0x391C680", VA = "0x18391D880")]
	private void OIGGJKHIKNJ(T PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x391D230", Offset = "0x391C030", VA = "0x18391D230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x391D520", Offset = "0x391C320", VA = "0x18391D520")]
	private void IFAMBNFJNAL(IEnumerable<T> CMKGLPFECEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class OABILDEOCEK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Dictionary<int, T> OOCFAHFELIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private T CMLFOMNIOCP;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual T PACPLEAHNCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x770C70", Offset = "0x76FA70", VA = "0x180770C70", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3DD83D0", Offset = "0x3DD71D0", VA = "0x183DD83D0")]
	public bool LGBBGBJPJPF(T PHPDIJICBJO, int CFGOOEPMJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7D60", Offset = "0x3DD6B60", VA = "0x183DD7D60")]
	public bool AKIGHCHOBPD(int CFGOOEPMJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7FC0", Offset = "0x3DD6DC0", VA = "0x183DD7FC0")]
	public T DABNLOLNBMG(int NDLDPHMDJMF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3DD82C0", Offset = "0x3DD70C0", VA = "0x183DD82C0")]
	private bool JJLCOBODHAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3DD8450", Offset = "0x3DD7250", VA = "0x183DD8450")]
	public bool OLBECDHEMJL(int CFGOOEPMJGN, [Out] T PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3DD84A0", Offset = "0x3DD72A0", VA = "0x183DD84A0")]
	public OABILDEOCEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class FPCGDFNLMDH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	protected struct LAKDOBPNHMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public T DHGNDNJJJIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int PDPPHKDGLEB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly List<LAKDOBPNHMI> ABPCBCABECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private T KCJLEOIDOFB;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2F6E180", Offset = "0x2F6CF80", VA = "0x182F6E180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3491E90", Offset = "0x3490C90", VA = "0x183491E90")]
	public bool ONHABPEFGAG(T PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x3491D10", Offset = "0x3490B10", VA = "0x183491D10")]
	public void JHPNFEHLKNP(T PHPDIJICBJO, int CFGOOEPMJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x3491A60", Offset = "0x3490860", VA = "0x183491A60")]
	public bool BFKGBCINJJC(T PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x3491E30", Offset = "0x3490C30", VA = "0x183491E30")]
	public void LPNBJONBLDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x3491DB0", Offset = "0x3490BB0", VA = "0x183491DB0")]
	public T KPBAIGDIAAL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3491BB0", Offset = "0x34909B0", VA = "0x183491BB0")]
	private void FKPGOIOGKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3492010", Offset = "0x3490E10", VA = "0x183492010")]
	public FPCGDFNLMDH()
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
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		[EHGCIBCPLHN(CDIJBINDLCN.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x5DBF5E0", Offset = "0x5DBE3E0", VA = "0x185DBF5E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5DBF8B0", Offset = "0x5DBE6B0", VA = "0x185DBF8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5DBF7C0", Offset = "0x5DBE5C0", VA = "0x185DBF7C0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5DBF530", Offset = "0x5DBE330", VA = "0x185DBF530")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5DBF800", Offset = "0x5DBE600", VA = "0x185DBF800")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5DBF710", Offset = "0x5DBE510", VA = "0x185DBF710")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5DBF4A0", Offset = "0x5DBE2A0", VA = "0x185DBF4A0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x40B21B0", Offset = "0x40B0FB0", VA = "0x1840B21B0", Slot = "4")]
		public virtual T BPDCMLDJAHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class NNCLEPCKIMK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly Dictionary<byte, NBKHFNIMFEL> AOAHEPPEOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly JBNDELMDIFB<NBKHFNIMFEL> EHJOJOBEPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly bool BEIGCFEHIHC;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public NBKHFNIMFEL HDOGFHFAMJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x770F00", Offset = "0x76FD00", VA = "0x180770F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public Vector2 DKLIDCKAKNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xABC270", Offset = "0xABB070", VA = "0x180ABC270")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xD92FB0", Offset = "0xD91DB0", VA = "0x180D92FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private Vector2 ELINFGBFDCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xDC2630", Offset = "0xDC1430", VA = "0x180DC2630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Vector2 DPDCMNOENDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE8E0", Offset = "0x5DBD6E0", VA = "0x185DBE8E0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x772A00", Offset = "0x771800", VA = "0x180772A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int ANNMBIFJBBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x779D60", Offset = "0x778B60", VA = "0x180779D60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x779D80", Offset = "0x778B80", VA = "0x180779D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DBEE00", Offset = "0x5DBDC00", VA = "0x185DBEE00")]
	public NNCLEPCKIMK(Bounds GPOLDEEJKPO, Vector2[] LKCJPFDNGMI, int KOLLBDKBGNA, byte FNPACLAMELJ, float DIJGOHNBAGH = 0f, [Optional] JBNDELMDIFB<NBKHFNIMFEL> EHJOJOBEPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DBEDA0", Offset = "0x5DBDBA0", VA = "0x185DBEDA0")]
	public NBKHFNIMFEL PGAEJFONNKN(byte NGIPPLLBEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE3F0", Offset = "0x5DBD1F0", VA = "0x185DBE3F0")]
	public void HJAPLAEFCKE(Vector3 LMGPBOPOFGA, float HKCFKNFCLLC, float GMOPKCGDHNG, List<byte> FNLOFAPJGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1ADA3E0", Offset = "0x1AD91E0", VA = "0x181ADA3E0")]
	public void BHBDAOJBALO(NBKHFNIMFEL.GEDELOFGOCH CEEECHCIDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE900", Offset = "0x5DBD700", VA = "0x185DBE900")]
	public static int MFCKJNKACLH(Vector2[] LKCJPFDNGMI, int KOLLBDKBGNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE4C0", Offset = "0x5DBD2C0", VA = "0x185DBE4C0")]
	private NBKHFNIMFEL KKCFCIKHFCK(byte NGIPPLLBEKC, NBKHFNIMFEL.COBOBCMNIPE FIIKOPJKJCE, NBKHFNIMFEL BMNEKBHDGLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE9F0", Offset = "0x5DBD7F0", VA = "0x185DBE9F0")]
	private void PANGAKEEEHG(NBKHFNIMFEL BMNEKBHDGLJ, Vector2[] LKCJPFDNGMI, int DJBBNMNEBBA, int AKFGFHFJMJC, int NHNKDABNOJK, int AGIDCILHFDI, float DIJGOHNBAGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE6C0", Offset = "0x5DBD4C0", VA = "0x185DBE6C0")]
	private void LLGNGOFPAFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE330", Offset = "0x5DBD130", VA = "0x185DBE330", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE390", Offset = "0x5DBD190", VA = "0x185DBE390", Slot = "1")]
	~NNCLEPCKIMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class NBKHFNIMFEL
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum COBOBCMNIPE
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum GEDELOFGOCH
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public byte EDMBHINBAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public Vector3 JIOADLGMACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Vector3 BMGCJGPBFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Vector3 CBIKMPAKFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public Vector3 OANOBCHBFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public COBOBCMNIPE AIMAPAKMMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public NBKHFNIMFEL ELFFPEGDBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public List<NBKHFNIMFEL> DKGPLPNCFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public bool BPEFEFFGMOG;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE310", Offset = "0x5DBD110", VA = "0x185DBE310")]
	public NBKHFNIMFEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE1F0", Offset = "0x5DBCFF0", VA = "0x185DBE1F0")]
	public void MKPCBGMLOBB(NBKHFNIMFEL COBMMEELOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200")]
	public void BHBDAOJBALO(int OFEMCCCDLAL, GEDELOFGOCH CEEECHCIDOM, int POGHILFEMND = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DBDF60", Offset = "0x5DBCD60", VA = "0x185DBDF60")]
	public void HJAPLAEFCKE(List<byte> FNLOFAPJGFJ, Vector3 LMGPBOPOFGA, float HKCFKNFCLLC, float GMOPKCGDHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE1C0", Offset = "0x5DBCFC0", VA = "0x185DBE1C0")]
	public bool KGJBCBGIPMF(Vector3 MFPMPHOGKHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DBDF30", Offset = "0x5DBCD30", VA = "0x185DBDF30")]
	public bool HHFMBOEBBLO(Vector3 MFPMPHOGKHO, float HMBBPAOJIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DBDEA0", Offset = "0x5DBCCA0", VA = "0x185DBDEA0")]
	public void CAKCEPELMIL()
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
		public struct DPJIGHJDKKB<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private readonly List<Component> LCPNBOPPGBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private readonly bool MBCFIFMDMBE;

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x3A9E300", Offset = "0x3A9D100", VA = "0x183A9E300")]
			public DPJIGHJDKKB(List<Component> LCPNBOPPGBK, bool MBCFIFMDMBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x4DD12A0", Offset = "0x4DD00A0", VA = "0x184DD12A0")]
			public KKDLFHIOHJP<T> NABGDMMLCNI()
			{
				return default(KKDLFHIOHJP<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x4DD1310", Offset = "0x4DD0110", VA = "0x184DD1310", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x4DD1310", Offset = "0x4DD0110", VA = "0x184DD1310", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public struct KKDLFHIOHJP<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private readonly List<Component> LCPNBOPPGBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly bool MBCFIFMDMBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private int NGIPPLLBEKC;

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public T POOLCAAKLKE
			{
				[Cpp2IlInjected.Token(Token = "0x60001EB")]
				[Cpp2IlInjected.Address(RVA = "0x3A3EB90", Offset = "0x3A3D990", VA = "0x183A3EB90", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x3A3EB20", Offset = "0x3A3D920", VA = "0x183A3EB20", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x3A3EB60", Offset = "0x3A3D960", VA = "0x183A3EB60")]
			public KKDLFHIOHJP(List<Component> LCPNBOPPGBK, bool MBCFIFMDMBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x3A3EA60", Offset = "0x3A3D860", VA = "0x183A3EA60", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x3A3EA70", Offset = "0x3A3D870", VA = "0x183A3EA70", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x3149750", Offset = "0x3148550", VA = "0x183149750", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0DE0", Offset = "0x5DBFBE0", VA = "0x185DC0DE0")]
		private void CAKCEPELMIL(GameObject OEBPJKHEKGE, bool OOFPOBCGECA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0C20", Offset = "0x5DBFA20", VA = "0x185DC0C20")]
		public static void CAKCEPELMIL(GameObject OEBPJKHEKGE, ToolHierarchyCache AGPPNFKJGDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2786760", Offset = "0x2785560", VA = "0x182786760")]
		public void CGFAGOEJMEB<T>(Action<T> CBNAIFNPGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2786980", Offset = "0x2785780", VA = "0x182786980")]
		public T NGFFABPBJOO<T>(bool MBCFIFMDMBE = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x27869F0", Offset = "0x27857F0", VA = "0x1827869F0")]
		public DPJIGHJDKKB<T> PJHBCCCGLCI<T>(bool MBCFIFMDMBE = false) where T : class
		{
			return default(DPJIGHJDKKB<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5DC1040", Offset = "0x5DBFE40", VA = "0x185DC1040")]
		public List<Component> KEHJAMPIOPI(Type AOPDMLJGEMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0F50", Offset = "0x5DBFD50", VA = "0x185DC0F50", Slot = "4")]
		public bool Equals(ToolHierarchyCache GPMOHKANAAB, ToolHierarchyCache GGKPCMCCKDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0FD0", Offset = "0x5DBFDD0", VA = "0x185DC0FD0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache KANAGAAAGHJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class DLOGDLOMKMM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private int FNJNELBIPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private int PBJCDPHLMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private List<T> JGKKOAMEPPD;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public int BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3426190", Offset = "0x3424F90", VA = "0x183426190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T PFPABELFGLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4DA1860", Offset = "0x4DA0660", VA = "0x184DA1860")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T PNLHEDJBNFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4DA1B70", Offset = "0x4DA0970", VA = "0x184DA1B70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T FPODICBMLEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4DA17E0", Offset = "0x4DA05E0", VA = "0x184DA17E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x4DA1E10", Offset = "0x4DA0C10", VA = "0x184DA1E10")]
	public DLOGDLOMKMM(int FNJNELBIPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x4DA1CD0", Offset = "0x4DA0AD0", VA = "0x184DA1CD0")]
	public void JHPNFEHLKNP(T KFCNHHDOPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x4DA1DD0", Offset = "0x4DA0BD0", VA = "0x184DA1DD0")]
	public void LPNBJONBLDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x4DA19E0", Offset = "0x4DA07E0", VA = "0x184DA19E0")]
	public void GJMMPHAGKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x4DA1AB0", Offset = "0x4DA08B0", VA = "0x184DA1AB0")]
	public void HJNOGHAANLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x4DA19D0", Offset = "0x4DA07D0", VA = "0x184DA19D0")]
	public void DPGJCGNIJAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class AOMINKIABKH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private struct MJJLFFPFDGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int PDPPHKDGLEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public T DHGNDNJJJIH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Dictionary<object, MJJLFFPFDGM> OOCFAHFELIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly EqualityComparer<T> FCMLJMMMDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private T CMLFOMNIOCP;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public virtual T PACPLEAHNCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xEC76A0", Offset = "0xEC64A0", VA = "0x180EC76A0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3890E20", Offset = "0x388FC20", VA = "0x183890E20", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool BDDFEPNGHJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3890E40", Offset = "0x388FC40", VA = "0x183890E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public object GNDELKLPNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x772C00", Offset = "0x771A00", VA = "0x180772C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x777020", Offset = "0x775E20", VA = "0x180777020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x3893940", Offset = "0x3892740", VA = "0x183893940")]
	public bool LGBBGBJPJPF(T PHPDIJICBJO, object HOBAPMCPFML, int CFGOOEPMJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x3890D10", Offset = "0x388FB10", VA = "0x183890D10")]
	public bool AKIGHCHOBPD(object HOBAPMCPFML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3894660", Offset = "0x3893460", VA = "0x183894660")]
	public bool OLBECDHEMJL(object HOBAPMCPFML, [Out] T PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3894290", Offset = "0x3893090", VA = "0x183894290")]
	public void LPNBJONBLDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3890E90", Offset = "0x388FC90", VA = "0x183890E90")]
	private bool JJLCOBODHAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3894AD0", Offset = "0x38938D0", VA = "0x183894AD0")]
	public AOMINKIABKH()
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
