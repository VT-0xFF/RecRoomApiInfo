using System;
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
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class NHOMBGOPFCA : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x99CCD0", Offset = "0x99BCD0", VA = "0x18099CCD0")]
	public NHOMBGOPFCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4D55370", Offset = "0x4D54370", VA = "0x184D55370")]
	public byte[] LOAGLBKBCPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void GFFDDNLEGBP(IncrementalHash NPNGOLKAOFF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6AC390", Offset = "0x6AB390", VA = "0x1806AC390")]
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
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[OKEHLIENMIP]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[OKEHLIENMIP]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4D58ED0", Offset = "0x4D57ED0", VA = "0x184D58ED0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4D58E90", Offset = "0x4D57E90", VA = "0x184D58E90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4D58F10", Offset = "0x4D57F10", VA = "0x184D58F10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4D59120", Offset = "0x4D58120", VA = "0x184D59120")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4D59090", Offset = "0x4D58090", VA = "0x184D59090")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D20", Offset = "0x7E0D20", VA = "0x1807E1D20")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D70", Offset = "0x7E0D70", VA = "0x1807E1D70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4D58E50", Offset = "0x4D57E50", VA = "0x184D58E50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4D59000", Offset = "0x4D58000", VA = "0x184D59000")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4D58880", Offset = "0x4D57880", VA = "0x184D58880")]
	public void CopyBounds(SavedExtents GJPJDOANCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4D58DC0", Offset = "0x4D57DC0", VA = "0x184D58DC0")]
	public void SetLocalSpaceBounds(Bounds IIDEHGPDOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8005C0", Offset = "0x7FF5C0", VA = "0x1808005C0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4D58DB0", Offset = "0x4D57DB0", VA = "0x184D58DB0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4D588B0", Offset = "0x4D578B0", VA = "0x184D588B0")]
	private void EBCLMHLPNCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4D58B80", Offset = "0x4D57B80", VA = "0x184D58B80")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4D582C0", Offset = "0x4D572C0", VA = "0x184D582C0")]
	public static void CalculateLocalBoundsFor(GameObject NIKGFIPEJKD, out Bounds IIDEHGPDOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D58AC0", Offset = "0x4D57AC0", VA = "0x184D58AC0")]
	private static void IBEFMMFPCMP(Bounds IIFMPDAMAIA, Color AHENHIDOBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4D58DE0", Offset = "0x4D57DE0", VA = "0x184D58DE0")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5A81F0", Offset = "0x5A71F0", VA = "0x1805A81F0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5B1940", Offset = "0x5B0940", VA = "0x1805B1940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5AB360", Offset = "0x5AA360", VA = "0x1805AB360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220", Slot = "4")]
	public virtual void NJMINPBMPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	[NHOMBGOPFCA]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x40F22C0", Offset = "0x40F12C0", VA = "0x1840F22C0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x40F1E00", Offset = "0x40F0E00", VA = "0x1840F1E00", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x40F28C0", Offset = "0x40F18C0", VA = "0x1840F28C0")]
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
	private sealed class NJHHCIMPFMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public NJHHCIMPFMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3D7D370", Offset = "0x3D7C370", VA = "0x183D7D370")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[NHOMBGOPFCA]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5A81F0", Offset = "0x5A71F0", VA = "0x1805A81F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3D78070", Offset = "0x3D77070", VA = "0x183D78070", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3D780A0", Offset = "0x3D770A0", VA = "0x183D780A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3D77FC0", Offset = "0x3D76FC0", VA = "0x183D77FC0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey MKDJIBNCKNC]
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3D77FF0", Offset = "0x3D76FF0", VA = "0x183D77FF0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3D77EC0", Offset = "0x3D76EC0", VA = "0x183D77EC0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3D77720", Offset = "0x3D76720", VA = "0x183D77720", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3D77090", Offset = "0x3D76090", VA = "0x183D77090", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D76CC0", Offset = "0x3D75CC0", VA = "0x183D76CC0", Slot = "14")]
	protected virtual string KNFGDOONBGC(TKeyVal HBGCCCMAKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3C0D8D0", Offset = "0x3C0C8D0", VA = "0x183C0D8D0", Slot = "4")]
	public bool ContainsKey(TKey MKDJIBNCKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3D77DB0", Offset = "0x3D76DB0", VA = "0x183D77DB0", Slot = "5")]
	public bool TryGetValue(TKey MKDJIBNCKNC, out TVal MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3D76C00", Offset = "0x3D75C00", VA = "0x183D76C00", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3D76C00", Offset = "0x3D75C00", VA = "0x183D76C00", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3D77DE0", Offset = "0x3D76DE0", VA = "0x183D77DE0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FIOODBKGPEL<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HCKLBOCHLBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public HCKLBOCHLBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3762760", Offset = "0x3761760", VA = "0x183762760")]
		internal bool <GetSamples>b__0(global::JHJGCPBBALP<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float NNAELBGPJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float DPGEJIENANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::JHJGCPBBALP<float, T>> CHJNIBJHOJB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int KAKIBIPNINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x375DD50", Offset = "0x375CD50", VA = "0x18375DD50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x375DDD0", Offset = "0x375CDD0", VA = "0x18375DDD0")]
	public FIOODBKGPEL(float JKNDPNGCEKN, float AHPPANIAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x375D950", Offset = "0x375C950", VA = "0x18375D950")]
	public bool HDIDHMKDGPJ(float BNLHHMHBFBE, T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x375D8C0", Offset = "0x375C8C0", VA = "0x18375D8C0")]
	public int BLGPLPDGLHC(float BNLHHMHBFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x375D580", Offset = "0x375C580", VA = "0x18375D580")]
	public IEnumerable<T> AIPMNLEMDLF(float BNLHHMHBFBE, [Optional] float? FCHAFMHONED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x375D920", Offset = "0x375C920", VA = "0x18375D920")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x375DC10", Offset = "0x375CC10", VA = "0x18375DC10")]
	private void KJANGJBBJEI(float BNLHHMHBFBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class EBEDLPGCCAP<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct HLBJKHGLCIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T NLLJAAOBNLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float FMGIAHDPMAP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float PNOCIOJPGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> MCAAHOJCHDC;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int GMABBJANONE = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private HLBJKHGLCIB[] BEGPAFGBCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int KJJHFDMOEHC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float CINHIGMBFFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D30", Offset = "0x7E0D30", VA = "0x1807E1D30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D50", Offset = "0x7E0D50", VA = "0x1807E1D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3023260", Offset = "0x3022260", VA = "0x183023260")]
	public EBEDLPGCCAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3023290", Offset = "0x3022290", VA = "0x183023290")]
	public EBEDLPGCCAP(int KMCJMFPOINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3022D40", Offset = "0x3021D40", VA = "0x183022D40")]
	public void NENJMCKJAJO(float BNLHHMHBFBE, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3021D30", Offset = "0x3020D30", VA = "0x183021D30")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3022120", Offset = "0x3021120", VA = "0x183022120")]
	public bool EFEIJPNCBAL(float FDAHJLCPCMG, float FCDDNKPOGKC, out T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x30229C0", Offset = "0x30219C0", VA = "0x1830229C0")]
	public bool JHOFCOMOONE(float FDAHJLCPCMG, float FCDDNKPOGKC, out T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x30230C0", Offset = "0x30220C0", VA = "0x1830230C0")]
	public void NKIEEBKGPLK(float FDAHJLCPCMG, float FCDDNKPOGKC, List<T> HKAAJCFANGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3022B70", Offset = "0x3021B70", VA = "0x183022B70")]
	private int NDGIPCKGGOO(int LNHAEDKIBGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3022B30", Offset = "0x3021B30", VA = "0x183022B30")]
	private void MFMMLCOIFBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T DPMLJDDJBJO();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T LIJNAOMAFOB(T NNKIPLHOMAE, T JDKIOCBBPAN, float JDLAIFIMIJD);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T BLIELPCGJDN(T MPHFKGJNMOK, float JDLAIFIMIJD);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T KLKAMBMGDLE(T NNKIPLHOMAE, T JDKIOCBBPAN);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T LNFJFBLJGGL(T NNKIPLHOMAE, T JDKIOCBBPAN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LJGCFHMJDDC : global::EBEDLPGCCAP<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4D55610", Offset = "0x4D54610", VA = "0x184D55610", Slot = "4")]
	protected override Vector3 DPMLJDDJBJO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4D55730", Offset = "0x4D54730", VA = "0x184D55730", Slot = "5")]
	protected override Vector3 LIJNAOMAFOB(Vector3 NNKIPLHOMAE, Vector3 JDKIOCBBPAN, float JDLAIFIMIJD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4D55570", Offset = "0x4D54570", VA = "0x184D55570", Slot = "6")]
	protected override Vector3 BLIELPCGJDN(Vector3 MPHFKGJNMOK, float JDLAIFIMIJD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4D55680", Offset = "0x4D54680", VA = "0x184D55680", Slot = "7")]
	protected override Vector3 KLKAMBMGDLE(Vector3 NNKIPLHOMAE, Vector3 JDKIOCBBPAN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4D557F0", Offset = "0x4D547F0", VA = "0x184D557F0", Slot = "8")]
	protected override Vector3 LNFJFBLJGGL(Vector3 NNKIPLHOMAE, Vector3 JDKIOCBBPAN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4D55860", Offset = "0x4D54860", VA = "0x184D55860")]
	public LJGCFHMJDDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AAADGANKBMP : global::EBEDLPGCCAP<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4D535F0", Offset = "0x4D525F0", VA = "0x184D535F0")]
	public AAADGANKBMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4D53580", Offset = "0x4D52580", VA = "0x184D53580")]
	public AAADGANKBMP(int KMCJMFPOINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x853220", Offset = "0x852220", VA = "0x180853220", Slot = "4")]
	protected override float DPMLJDDJBJO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4D534F0", Offset = "0x4D524F0", VA = "0x184D534F0", Slot = "5")]
	protected override float LIJNAOMAFOB(float NNKIPLHOMAE, float JDKIOCBBPAN, float JDLAIFIMIJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x40BC560", Offset = "0x40BB560", VA = "0x1840BC560", Slot = "6")]
	protected override float BLIELPCGJDN(float MPHFKGJNMOK, float JDLAIFIMIJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA831C0", Offset = "0xA821C0", VA = "0x180A831C0", Slot = "7")]
	protected override float KLKAMBMGDLE(float NNKIPLHOMAE, float JDKIOCBBPAN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4D53570", Offset = "0x4D52570", VA = "0x184D53570", Slot = "8")]
	protected override float LNFJFBLJGGL(float NNKIPLHOMAE, float JDKIOCBBPAN)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DFJGABGBPPI
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2C00350", Offset = "0x2BFF350", VA = "0x182C00350")]
	public static global::CECEKFMKBAH<T1> GPCBEJLMGEM<T1>(T1 LIMDOAJDHOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2E87760", Offset = "0x2E86760", VA = "0x182E87760")]
	public static global::JHJGCPBBALP<T1, T2> GPCBEJLMGEM<T1, T2>(T1 LIMDOAJDHOL, T2 FCIBOALGCOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x32A2960", Offset = "0x32A1960", VA = "0x1832A2960")]
	public static global::ECEIKOHDBEL<T1, T2, T3> GPCBEJLMGEM<T1, T2, T3>(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2E98430", Offset = "0x2E97430", VA = "0x182E98430")]
	public static global::GKKKNGCMPIB<T1, T2, T3, T4> GPCBEJLMGEM<T1, T2, T3, T4>(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ, T4 DKLDFMCMENI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2E877D0", Offset = "0x2E867D0", VA = "0x182E877D0")]
	public static global::OMCHOBOBKLI<T1, T2, T3, T4, T5> GPCBEJLMGEM<T1, T2, T3, T4, T5>(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ, T4 DKLDFMCMENI, T5 AIPJCDDJENB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x32E0D20", Offset = "0x32DFD20", VA = "0x1832E0D20")]
	public static global::BDKJBMEECAA<T1, T2, T3, T4, T5, T6> GPCBEJLMGEM<T1, T2, T3, T4, T5, T6>(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ, T4 DKLDFMCMENI, T5 AIPJCDDJENB, T6 DBKNGGEPDEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A080", Offset = "0x2D99080", VA = "0x182D9A080")]
	public static global::CHOFLPMMMHF<T1, T2, T3, T4, T5, T6, T7> GPCBEJLMGEM<T1, T2, T3, T4, T5, T6, T7>(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ, T4 DKLDFMCMENI, T5 AIPJCDDJENB, T6 DBKNGGEPDEO, T7 DCCMAJMIBEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x32A29F0", Offset = "0x32A19F0", VA = "0x1832A29F0")]
	public static global::GGPKMGOAGII<T1, T2, T3, T4, T5, T6, T7, T8> GPCBEJLMGEM<T1, T2, T3, T4, T5, T6, T7, T8>(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ, T4 DKLDFMCMENI, T5 AIPJCDDJENB, T6 DBKNGGEPDEO, T7 DCCMAJMIBEJ, T8 DNBBFCFAAFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x298AFA0", Offset = "0x2989FA0", VA = "0x18298AFA0")]
	[IteratorStateMachine(typeof(ADOCDALCLGP))]
	public static IEnumerable<global::JHJGCPBBALP<T1, T2>> NGBENFEAAIJ<T1, T2>(IEnumerable<T1> NCGEKBENJBA, IEnumerable<T2> IIFMPDAMAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2BE6970", Offset = "0x2BE5970", VA = "0x182BE6970")]
	[IteratorStateMachine(typeof(BLAAFPBCEIG))]
	public static IEnumerable<global::ECEIKOHDBEL<T1, T2, T3>> NGBENFEAAIJ<T1, T2, T3>(IEnumerable<T1> NCGEKBENJBA, IEnumerable<T2> IIFMPDAMAIA, IEnumerable<T3> AHENHIDOBEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x32539A0", Offset = "0x32529A0", VA = "0x1832539A0")]
	internal static int LDEBBOPDIAC(int FAKCNNJKKOE, int BDOCKLFDBKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x46114A0", Offset = "0x46104A0", VA = "0x1846114A0")]
	internal static int LDEBBOPDIAC(int FAKCNNJKKOE, int BDOCKLFDBKD, int HNLGIDJODIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x46114B0", Offset = "0x46104B0", VA = "0x1846114B0")]
	internal static int LDEBBOPDIAC(int FAKCNNJKKOE, int BDOCKLFDBKD, int HNLGIDJODIB, int DHIJKHCMMCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4D53EE0", Offset = "0x4D52EE0", VA = "0x184D53EE0")]
	internal static int LDEBBOPDIAC(int FAKCNNJKKOE, int BDOCKLFDBKD, int HNLGIDJODIB, int DHIJKHCMMCL, int HDNILMNNHKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4D53F60", Offset = "0x4D52F60", VA = "0x184D53F60")]
	internal static int LDEBBOPDIAC(int FAKCNNJKKOE, int BDOCKLFDBKD, int HNLGIDJODIB, int DHIJKHCMMCL, int HDNILMNNHKG, int BFOKIIHDMBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4D53F00", Offset = "0x4D52F00", VA = "0x184D53F00")]
	internal static int LDEBBOPDIAC(int FAKCNNJKKOE, int BDOCKLFDBKD, int HNLGIDJODIB, int DHIJKHCMMCL, int HDNILMNNHKG, int BFOKIIHDMBD, int MPGPMONCLMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4D53F30", Offset = "0x4D52F30", VA = "0x184D53F30")]
	internal static int LDEBBOPDIAC(int FAKCNNJKKOE, int BDOCKLFDBKD, int HNLGIDJODIB, int DHIJKHCMMCL, int HDNILMNNHKG, int BFOKIIHDMBD, int MPGPMONCLMN, int AJOKJJHJFAK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CECEKFMKBAH<T1> : IComparable<global::CECEKFMKBAH<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 MCMEECGHCJN;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8C6F60", Offset = "0x8C5F60", VA = "0x1808C6F60")]
	public CECEKFMKBAH(T1 LIMDOAJDHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x30F7FB0", Offset = "0x30F6FB0", VA = "0x1830F7FB0", Slot = "4")]
	public int CompareTo(global::CECEKFMKBAH<T1> GJPJDOANCNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x30F8020", Offset = "0x30F7020", VA = "0x1830F8020", Slot = "0")]
	public override bool Equals(object GJPJDOANCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x715100", Offset = "0x714100", VA = "0x180715100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x30F80C0", Offset = "0x30F70C0", VA = "0x1830F80C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JHJGCPBBALP<T1, T2> : IComparable<global::JHJGCPBBALP<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 MCMEECGHCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 DNOGNKDMMDB;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x366CD70", Offset = "0x366BD70", VA = "0x18366CD70")]
	public JHJGCPBBALP(T1 LIMDOAJDHOL, T2 FCIBOALGCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x366B2E0", Offset = "0x366A2E0", VA = "0x18366B2E0", Slot = "4")]
	public int CompareTo(global::JHJGCPBBALP<T1, T2> GJPJDOANCNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x366BD30", Offset = "0x366AD30", VA = "0x18366BD30", Slot = "0")]
	public override bool Equals(object GJPJDOANCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x366BF30", Offset = "0x366AF30", VA = "0x18366BF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x366C6E0", Offset = "0x366B6E0", VA = "0x18366C6E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ECEIKOHDBEL<T1, T2, T3> : IComparable<global::ECEIKOHDBEL<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 MCMEECGHCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 DNOGNKDMMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 JGDNKLMAEJE;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x302A3C0", Offset = "0x30293C0", VA = "0x18302A3C0")]
	public ECEIKOHDBEL(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3029CE0", Offset = "0x3028CE0", VA = "0x183029CE0", Slot = "4")]
	public int CompareTo(global::ECEIKOHDBEL<T1, T2, T3> GJPJDOANCNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3029ED0", Offset = "0x3028ED0", VA = "0x183029ED0", Slot = "0")]
	public override bool Equals(object GJPJDOANCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x302A040", Offset = "0x3029040", VA = "0x18302A040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x302A230", Offset = "0x3029230", VA = "0x18302A230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class GKKKNGCMPIB<T1, T2, T3, T4> : IComparable<global::GKKKNGCMPIB<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 MCMEECGHCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 DNOGNKDMMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 JGDNKLMAEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 LMMFHJDBJHM;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8C52A0", Offset = "0x8C42A0", VA = "0x1808C52A0")]
	public GKKKNGCMPIB(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ, T4 DKLDFMCMENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x38F91C0", Offset = "0x38F81C0", VA = "0x1838F91C0", Slot = "4")]
	public int CompareTo(global::GKKKNGCMPIB<T1, T2, T3, T4> GJPJDOANCNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x38F9300", Offset = "0x38F8300", VA = "0x1838F9300", Slot = "0")]
	public override bool Equals(object GJPJDOANCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x38F9420", Offset = "0x38F8420", VA = "0x1838F9420", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x38F94E0", Offset = "0x38F84E0", VA = "0x1838F94E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OMCHOBOBKLI<T1, T2, T3, T4, T5> : IComparable<global::OMCHOBOBKLI<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 MCMEECGHCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 DNOGNKDMMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 JGDNKLMAEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 LMMFHJDBJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 KGFLKIJLFMK;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4090120", Offset = "0x408F120", VA = "0x184090120")]
	public OMCHOBOBKLI(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ, T4 DKLDFMCMENI, T5 AIPJCDDJENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x408FC30", Offset = "0x408EC30", VA = "0x18408FC30", Slot = "4")]
	public int CompareTo(global::OMCHOBOBKLI<T1, T2, T3, T4, T5> GJPJDOANCNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x408FDB0", Offset = "0x408EDB0", VA = "0x18408FDB0", Slot = "0")]
	public override bool Equals(object GJPJDOANCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x408FEF0", Offset = "0x408EEF0", VA = "0x18408FEF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x408FFF0", Offset = "0x408EFF0", VA = "0x18408FFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BDKJBMEECAA<T1, T2, T3, T4, T5, T6> : IComparable<global::BDKJBMEECAA<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 MCMEECGHCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 DNOGNKDMMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 JGDNKLMAEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 LMMFHJDBJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 KGFLKIJLFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 LFOOBGBBCGH;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x389CEE0", Offset = "0x389BEE0", VA = "0x18389CEE0")]
	public BDKJBMEECAA(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ, T4 DKLDFMCMENI, T5 AIPJCDDJENB, T6 DBKNGGEPDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x389C940", Offset = "0x389B940", VA = "0x18389C940", Slot = "4")]
	public int CompareTo(global::BDKJBMEECAA<T1, T2, T3, T4, T5, T6> GJPJDOANCNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x389CB00", Offset = "0x389BB00", VA = "0x18389CB00", Slot = "0")]
	public override bool Equals(object GJPJDOANCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x389CC70", Offset = "0x389BC70", VA = "0x18389CC70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x389CD90", Offset = "0x389BD90", VA = "0x18389CD90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CHOFLPMMMHF<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::CHOFLPMMMHF<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 MCMEECGHCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 DNOGNKDMMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 JGDNKLMAEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 LMMFHJDBJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 KGFLKIJLFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 LFOOBGBBCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 HDNGNMJIGMH;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x30F9DB0", Offset = "0x30F8DB0", VA = "0x1830F9DB0")]
	public CHOFLPMMMHF(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ, T4 DKLDFMCMENI, T5 AIPJCDDJENB, T6 DBKNGGEPDEO, T7 DCCMAJMIBEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x30F9750", Offset = "0x30F8750", VA = "0x1830F9750", Slot = "4")]
	public int CompareTo(global::CHOFLPMMMHF<T1, T2, T3, T4, T5, T6, T7> GJPJDOANCNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x30F9950", Offset = "0x30F8950", VA = "0x1830F9950", Slot = "0")]
	public override bool Equals(object GJPJDOANCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x30F9AF0", Offset = "0x30F8AF0", VA = "0x1830F9AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x30F9C40", Offset = "0x30F8C40", VA = "0x1830F9C40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class GGPKMGOAGII<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::GGPKMGOAGII<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 MCMEECGHCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 DNOGNKDMMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 JGDNKLMAEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 LMMFHJDBJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 KGFLKIJLFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 LFOOBGBBCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 HDNGNMJIGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 LOIOGEBEKPD;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3A3AE20", Offset = "0x3A39E20", VA = "0x183A3AE20")]
	public GGPKMGOAGII(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ, T4 DKLDFMCMENI, T5 AIPJCDDJENB, T6 DBKNGGEPDEO, T7 DCCMAJMIBEJ, T8 DNBBFCFAAFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3A3A710", Offset = "0x3A39710", VA = "0x183A3A710", Slot = "4")]
	public int CompareTo(global::GGPKMGOAGII<T1, T2, T3, T4, T5, T6, T7, T8> GJPJDOANCNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3A3A960", Offset = "0x3A39960", VA = "0x183A3A960", Slot = "0")]
	public override bool Equals(object GJPJDOANCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3A3AB20", Offset = "0x3A39B20", VA = "0x183A3AB20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3A3AC90", Offset = "0x3A39C90", VA = "0x183A3AC90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T NLLJAAOBNLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5CB390", Offset = "0x5CA390", VA = "0x1805CB390")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A05C0", Offset = "0x69F5C0", VA = "0x1806A05C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float CIDGMEGAIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7405A0", Offset = "0x73F5A0", VA = "0x1807405A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3E06CC0", Offset = "0x3E05CC0", VA = "0x183E06CC0")]
	public T GADHBBEMMJI(float JDLAIFIMIJD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3E06E20", Offset = "0x3E05E20", VA = "0x183E06E20")]
	public T GCAAOKIAELE(float JDLAIFIMIJD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LIJNAOMAFOB(T NNKIPLHOMAE, T JDKIOCBBPAN, float JDLAIFIMIJD);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4D54680", Offset = "0x4D53680", VA = "0x184D54680", Slot = "4")]
	protected override float LIJNAOMAFOB(float NNKIPLHOMAE, float JDKIOCBBPAN, float JDLAIFIMIJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4D54700", Offset = "0x4D53700", VA = "0x184D54700")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4D5A080", Offset = "0x4D59080", VA = "0x184D5A080", Slot = "4")]
	protected override Vector3 LIJNAOMAFOB(Vector3 NNKIPLHOMAE, Vector3 JDKIOCBBPAN, float JDLAIFIMIJD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4D5A140", Offset = "0x4D59140", VA = "0x184D5A140")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3F60", Offset = "0x1DB2F60", VA = "0x181DB3F60", Slot = "4")]
	protected override Color LIJNAOMAFOB(Color NNKIPLHOMAE, Color JDKIOCBBPAN, float JDLAIFIMIJD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4D53EA0", Offset = "0x4D52EA0", VA = "0x184D53EA0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public sealed class PFMKJMCKNDM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly BIJHJKPHMII LEOFFENECGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private T[] EOCLDHKCFCG;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5AA1A0", Offset = "0x5A91A0", VA = "0x1805AA1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5AA190", Offset = "0x5A9190", VA = "0x1805AA190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3B9F6C0", Offset = "0x3B9E6C0", VA = "0x183B9F6C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3B9ED20", Offset = "0x3B9DD20", VA = "0x183B9ED20")]
	public static global::PFMKJMCKNDM<T> CIAOGEOFBKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3B9EBE0", Offset = "0x3B9DBE0", VA = "0x183B9EBE0")]
	public static global::PFMKJMCKNDM<T> BILDOHHICAG(int NKJBJGFALMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3BA05D0", Offset = "0x3B9F5D0", VA = "0x183BA05D0")]
	private PFMKJMCKNDM(T[] BJJEPAFIFKG, int NKJBJGFALMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F070", Offset = "0x3B9E070", VA = "0x183B9F070", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F2C0", Offset = "0x3B9E2C0", VA = "0x183B9F2C0")]
	public void NENJMCKJAJO(in T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3B9EFD0", Offset = "0x3B9DFD0", VA = "0x183B9EFD0")]
	public void DPNMENBOJNI(int HOOANEAGKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F940", Offset = "0x3B9E940", VA = "0x183B9F940")]
	public void PIAMKOCKCLL(int KMCJMFPOINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3B9EE50", Offset = "0x3B9DE50", VA = "0x183B9EE50")]
	private void DKIJAJMBPMB(int NKJBJGFALMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class LBOLPINMHBA
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2E94930", Offset = "0x2E93930", VA = "0x182E94930")]
	public static global::PFMKJMCKNDM<T> CIAOGEOFBKG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2C05500", Offset = "0x2C04500", VA = "0x182C05500")]
	public static global::PFMKJMCKNDM<T> BILDOHHICAG<T>(int NKJBJGFALMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct BAHKBGKEHEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<CBIFGBDDJND>> FPPCMBNHJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int FGJGAEICBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int KLEELIOKMFH;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1292610", Offset = "0x1291610", VA = "0x181292610")]
	private BAHKBGKEHEL(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<CBIFGBDDJND>> LAGLGCKDHGD, int DFBNFBBEACO, int MJHHNBMJNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4D536B0", Offset = "0x4D526B0", VA = "0x184D536B0")]
	public static BAHKBGKEHEL CIAOGEOFBKG()
	{
		return default(BAHKBGKEHEL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4D53730", Offset = "0x4D52730", VA = "0x184D53730")]
	public (int, int, Task) MBJCFOHDDIA(int PLFEGFLMJIJ)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4D539A0", Offset = "0x4D529A0", VA = "0x184D539A0")]
	public void MOIJNOFJGED(int PLFEGFLMJIJ, int MJHHNBMJNKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class EHMJGPNKKDD<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly Dictionary<TKey, TVal> POKFIONPBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<TVal, TKey> LJCENICLIEH;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1402F00", Offset = "0x1401F00", VA = "0x181402F00", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool GCLNONOIJMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x551490", Offset = "0x550490", VA = "0x180551490", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICollection<TKey> GCFCKHBGHHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8CB370", Offset = "0x8CA370", VA = "0x1808CB370", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TVal> JBFKKFMHIKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x14032C0", Offset = "0x14022C0", VA = "0x1814032C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TVal NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x31CC290", Offset = "0x31CB290", VA = "0x1831CC290", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x30F2090", Offset = "0x30F1090", VA = "0x1830F2090", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TKey NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3E93E60", Offset = "0x3E92E60", VA = "0x183E93E60")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3E934C0", Offset = "0x3E924C0", VA = "0x183E934C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3E93540", Offset = "0x3E92540", VA = "0x183E93540", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3E93F10", Offset = "0x3E92F10", VA = "0x183E93F10", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3D4FBE0", Offset = "0x3D4EBE0", VA = "0x183D4FBE0", Slot = "9")]
	public void Add(TKey MKDJIBNCKNC, TVal MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3E93490", Offset = "0x3E92490", VA = "0x183E93490", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> JAKHJIEAJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x31CAB30", Offset = "0x31C9B30", VA = "0x1831CAB30", Slot = "8")]
	public bool ContainsKey(TKey MKDJIBNCKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9240", Offset = "0x3BA8240", VA = "0x183BA9240", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> JAKHJIEAJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x392D2F0", Offset = "0x392C2F0", VA = "0x18392D2F0", Slot = "10")]
	public bool Remove(TKey MKDJIBNCKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x392D2F0", Offset = "0x392C2F0", VA = "0x18392D2F0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> JAKHJIEAJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1403350", Offset = "0x1402350", VA = "0x181403350", Slot = "11")]
	public bool TryGetValue(TKey MKDJIBNCKNC, out TVal MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3E93880", Offset = "0x3E92880", VA = "0x183E93880", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3E935D0", Offset = "0x3E925D0", VA = "0x183E935D0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] BEGPAFGBCJM, int KHBOJEFOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3E93D80", Offset = "0x3E92D80", VA = "0x183E93D80")]
	public void NENJMCKJAJO(TVal GBDFHGIMHBD, TKey MKDJIBNCKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3E93DC0", Offset = "0x3E92DC0", VA = "0x183E93DC0")]
	public void NENJMCKJAJO(KeyValuePair<TVal, TKey> JAKHJIEAJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3E93E30", Offset = "0x3E92E30", VA = "0x183E93E30")]
	public bool NHEDMKBNPEE(TVal MKDJIBNCKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3759C00", Offset = "0x3758C00", VA = "0x183759C00")]
	public bool FECGJJAPIMF(KeyValuePair<TVal, TKey> JAKHJIEAJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x389C700", Offset = "0x389B700", VA = "0x18389C700")]
	public bool MNHCGCIEOKP(TVal MKDJIBNCKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x389C700", Offset = "0x389B700", VA = "0x18389C700")]
	public bool MNHCGCIEOKP(KeyValuePair<TVal, TKey> JAKHJIEAJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3E93430", Offset = "0x3E92430", VA = "0x183E93430")]
	public bool ACEOCCKNHLM(TVal MKDJIBNCKNC, out TKey MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3E93630", Offset = "0x3E92630", VA = "0x183E93630")]
	public IEnumerator<KeyValuePair<TVal, TKey>> FAIIIGOOGAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3E93740", Offset = "0x3E92740", VA = "0x183E93740")]
	private void FAPOMAJEKNH(TKey MKDJIBNCKNC, TVal GBDFHGIMHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3E93900", Offset = "0x3E92900", VA = "0x183E93900")]
	private void JCCLPNAMJMP(TKey MKDJIBNCKNC, TVal GBDFHGIMHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3E93A40", Offset = "0x3E92A40", VA = "0x183E93A40")]
	private bool NCMECPNLCLN(TKey MKDJIBNCKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3E93BC0", Offset = "0x3E92BC0", VA = "0x183E93BC0")]
	private bool NCMECPNLCLN(TVal GBDFHGIMHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3E93F60", Offset = "0x3E92F60", VA = "0x183E93F60")]
	public EHMJGPNKKDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class BLOKKMGOFOK<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private global::BLOKKMGOFOK<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7E1D30", Offset = "0x7E0D30", VA = "0x1807E1D30", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x38AC2E0", Offset = "0x38AB2E0", VA = "0x1838AC2E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x38AC550", Offset = "0x38AB550", VA = "0x1838AC550")]
		public Enumerator(global::BLOKKMGOFOK<T> HKAAJCFANGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x38ABDD0", Offset = "0x38AADD0", VA = "0x1838ABDD0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x38ABF50", Offset = "0x38AAF50", VA = "0x1838ABF50", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x38AB9A0", Offset = "0x38AA9A0", VA = "0x1838AB9A0")]
		private void IKBLPICIHLO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private T[] CMMPHNBJIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int AHNBCGDLBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private int LLFJHOJDMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int MNOJMAIICKJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x38A35A0", Offset = "0x38A25A0", VA = "0x1838A35A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public T NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x38A5300", Offset = "0x38A4300", VA = "0x1838A5300")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x38A36D0", Offset = "0x38A26D0", VA = "0x1838A36D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x38A55F0", Offset = "0x38A45F0", VA = "0x1838A55F0")]
	public BLOKKMGOFOK(int NKJBJGFALMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x38A51C0", Offset = "0x38A41C0", VA = "0x1838A51C0")]
	public void NENJMCKJAJO(T JDLAIFIMIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x38A3E10", Offset = "0x38A2E10", VA = "0x1838A3E10")]
	public void CPDHKEOOMID(IEnumerable<T> PDBKEOJNNAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x38A37D0", Offset = "0x38A27D0", VA = "0x1838A37D0")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x38A4DA0", Offset = "0x38A3DA0", VA = "0x1838A4DA0")]
	public void MHBEHKDDJFA(int DHNBJNKGAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x38A4D10", Offset = "0x38A3D10", VA = "0x1838A4D10")]
	public void HJFBFMIDPLL(int DHNBJNKGAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x38A4BC0", Offset = "0x38A3BC0", VA = "0x1838A4BC0")]
	public void EJHGKGPLOIF(T[] BEGPAFGBCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x38A4EA0", Offset = "0x38A3EA0", VA = "0x1838A4EA0")]
	public Enumerator NECPELKHGNK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x38A5400", Offset = "0x38A4400", VA = "0x1838A5400", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x38A5400", Offset = "0x38A4400", VA = "0x1838A5400", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x38A4500", Offset = "0x38A3500", VA = "0x1838A4500")]
	private int DJKGBPCMOCG(int HOOANEAGKNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x38A3570", Offset = "0x38A2570", VA = "0x1838A3570")]
	private int AJBCJHLPPIH(int HOOANEAGKNH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct LKFGLOLIKNN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly IDisposable[] EOCLDHKCFCG;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x64B540", Offset = "0x64A540", VA = "0x18064B540")]
	public LKFGLOLIKNN(params IDisposable[] BJJEPAFIFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x64B460", Offset = "0x64A460", VA = "0x18064B460")]
	public static LKFGLOLIKNN CIAOGEOFBKG(params IDisposable[] BJJEPAFIFKG)
	{
		return default(LKFGLOLIKNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4D558C0", Offset = "0x4D548C0", VA = "0x184D558C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct PFDBHDCAEPE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly IDisposable DMLBJFANNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public T NLLJAAOBNLN;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x389DDB0", Offset = "0x389CDB0", VA = "0x18389DDB0")]
	public PFDBHDCAEPE(IDisposable OGIOFICPCOK, in T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2E9A3D0", Offset = "0x2E993D0", VA = "0x182E9A3D0")]
	public static global::PFDBHDCAEPE<U> FJPODPPLCMM<U>(in global::PFDBHDCAEPE<T> OGIOFICPCOK, in U MPHFKGJNMOK)
	{
		return default(global::PFDBHDCAEPE<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D5C0", Offset = "0x2D9C5C0", VA = "0x182D9D5C0")]
	public global::PFDBHDCAEPE<U> OFEOLDNDPJN<U>(in U MPHFKGJNMOK)
	{
		return default(global::PFDBHDCAEPE<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2E9A410", Offset = "0x2E99410", VA = "0x182E9A410")]
	public static global::PFDBHDCAEPE<(T, U)> LPIKICKGJBP<U>(in global::PFDBHDCAEPE<T> NCGEKBENJBA, in global::PFDBHDCAEPE<U> IIFMPDAMAIA)
	{
		return default(global::PFDBHDCAEPE<(T, U)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3B9CBB0", Offset = "0x3B9BBB0", VA = "0x183B9CBB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class KNCOMNPAJKP
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2E947A0", Offset = "0x2E937A0", VA = "0x182E947A0")]
	public static global::PFDBHDCAEPE<T> CIAOGEOFBKG<T>(IDisposable OGIOFICPCOK, in T MPHFKGJNMOK)
	{
		return default(global::PFDBHDCAEPE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D5C0", Offset = "0x2D9C5C0", VA = "0x182D9D5C0")]
	public static global::PFDBHDCAEPE<U> FJPODPPLCMM<U, T>(in global::PFDBHDCAEPE<T> EDEAKAPKGCH, in U MPHFKGJNMOK)
	{
		return default(global::PFDBHDCAEPE<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D580", Offset = "0x2D9C580", VA = "0x182D9D580")]
	public static global::PFDBHDCAEPE<(T, U)> LPIKICKGJBP<T, U>(in global::PFDBHDCAEPE<T> NCGEKBENJBA, in global::PFDBHDCAEPE<U> IIFMPDAMAIA)
	{
		return default(global::PFDBHDCAEPE<(T, U)>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct BIJHJKPHMII : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x551490", Offset = "0x550490", VA = "0x180551490")]
	public static BIJHJKPHMII BIOJJPJDKDG<T>([Optional] string DCIJEJBJLOB, [Optional] string JACAJNINABN, bool DDCDEOGJJAF = false)
	{
		return default(BIJHJKPHMII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public class OEKGOGBNJJA<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<Internal, External> PPLBFPDDENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Func<External, Internal> AHCEMKPPODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private IList<Internal> EJCFBHKFPEM;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IList<Internal> APKEOLLAIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5B1950", Offset = "0x5B0950", VA = "0x1805B1950")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5B19A0", Offset = "0x5B09A0", VA = "0x1805B19A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool GCLNONOIJMG
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6C03E0", Offset = "0x6BF3E0", VA = "0x1806C03E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6C0430", Offset = "0x6BF430", VA = "0x1806C0430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public External NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3F46950", Offset = "0x3F45950", VA = "0x183F46950", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3F469F0", Offset = "0x3F459F0", VA = "0x183F469F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3F468F0", Offset = "0x3F458F0", VA = "0x183F468F0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3F46860", Offset = "0x3F45860", VA = "0x183F46860")]
	public OEKGOGBNJJA(Func<Internal, External> PPLBFPDDENP, Func<External, Internal> AHCEMKPPODP, bool LNCLBBEBHPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3F46570", Offset = "0x3F45570", VA = "0x183F46570", Slot = "6")]
	public int IndexOf(External JAKHJIEAJDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3F46190", Offset = "0x3F45190", VA = "0x183F46190", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3F461F0", Offset = "0x3F451F0", VA = "0x183F461F0", Slot = "13")]
	public bool Contains(External JAKHJIEAJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3F46280", Offset = "0x3F45280", VA = "0x183F46280", Slot = "14")]
	public void CopyTo(External[] BEGPAFGBCJM, int KHBOJEFOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3F460A0", Offset = "0x3F450A0", VA = "0x183F460A0", Slot = "11")]
	public void Add(External JAKHJIEAJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3F46660", Offset = "0x3F45660", VA = "0x183F46660", Slot = "7")]
	public void Insert(int HOOANEAGKNH, External JAKHJIEAJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3F467D0", Offset = "0x3F457D0", VA = "0x183F467D0", Slot = "15")]
	public bool Remove(External JAKHJIEAJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3F46700", Offset = "0x3F45700", VA = "0x183F46700", Slot = "8")]
	public void RemoveAt(int HOOANEAGKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3F464A0", Offset = "0x3F454A0", VA = "0x183F464A0", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2CDD390", Offset = "0x2CDC390", VA = "0x182CDD390", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public class MGLODNAEJAK<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly Func<Internal, External> PPLBFPDDENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> EJCFBHKFPEM;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<Internal> APKEOLLAIJO
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5AB360", Offset = "0x5AA360", VA = "0x1805AB360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool GCLNONOIJMG
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x557FC0", Offset = "0x556FC0", VA = "0x180557FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public External NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4013150", Offset = "0x4012150", VA = "0x184013150", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x40130F0", Offset = "0x40120F0", VA = "0x1840130F0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8C6F60", Offset = "0x8C5F60", VA = "0x1808C6F60")]
	public MGLODNAEJAK(Func<Internal, External> PPLBFPDDENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x40130A0", Offset = "0x40120A0", VA = "0x1840130A0")]
	public MGLODNAEJAK(IReadOnlyList<Internal> EJCFBHKFPEM, Func<Internal, External> PPLBFPDDENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4012E10", Offset = "0x4011E10", VA = "0x184012E10")]
	public void EJHGKGPLOIF(External[] BEGPAFGBCJM, int KHBOJEFOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4013030", Offset = "0x4012030", VA = "0x184013030", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D10", Offset = "0x8C5D10", VA = "0x1808C6D10", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class LJFPEAECACI<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private IReadOnlyList<Internal> EJCFBHKFPEM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<Internal> APKEOLLAIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5A81F0", Offset = "0x5A71F0", VA = "0x1805A81F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5C5A10", Offset = "0x5C4A10", VA = "0x1805C5A10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool GCLNONOIJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x557FC0", Offset = "0x556FC0", VA = "0x180557FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public External NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3926170", Offset = "0x3925170", VA = "0x183926170", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x3926110", Offset = "0x3925110", VA = "0x183926110", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x8C6F60", Offset = "0x8C5F60", VA = "0x1808C6F60")]
	public LJFPEAECACI(IReadOnlyList<Internal> EJCFBHKFPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3925FA0", Offset = "0x3924FA0", VA = "0x183925FA0")]
	public bool FECGJJAPIMF(External JAKHJIEAJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3925D70", Offset = "0x3924D70", VA = "0x183925D70")]
	public void EJHGKGPLOIF(External[] BEGPAFGBCJM, int KHBOJEFOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3926040", Offset = "0x3925040", VA = "0x183926040", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2CDD390", Offset = "0x2CDC390", VA = "0x182CDD390", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public abstract class CPJFFOALPNM
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void EPLEHJEKGCH(object[] DFPAFIPCLLC);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	protected CPJFFOALPNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public abstract class JCIOECKHLAD<T> : CPJFFOALPNM
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	protected struct MJDJNAFBEKO
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public enum JPOJMMELLGA
		{
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public JPOJMMELLGA ONIHNDBDHGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public T BKCLKIJOKLP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private int LCPJEFJMLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly bool LDHCMKFNDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected readonly bool PMCPACKPOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	protected List<T> EHNFCAHJFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private List<MJDJNAFBEKO> KMNLADENAGF;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool GMPEHNKMMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x41C2180", Offset = "0x41C1180", VA = "0x1841C2180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x41C2900", Offset = "0x41C1900", VA = "0x1841C2900")]
	protected JCIOECKHLAD(bool PMCPACKPOOP, bool LDHCMKFNDPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x41C22F0", Offset = "0x41C12F0", VA = "0x1841C22F0")]
	protected bool DAODDKHBOOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x41C2540", Offset = "0x41C1540", VA = "0x1841C2540")]
	protected void FLGGINDPLDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x41C2390", Offset = "0x41C1390", VA = "0x1841C2390")]
	protected void DDMKJOEGNIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x38DD960", Offset = "0x38DC960", VA = "0x1838DD960")]
	private static void CFGNMOLDHBP<U>(ref List<U> EJCFBHKFPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x41C2780", Offset = "0x41C1780", VA = "0x1841C2780", Slot = "5")]
	public void NENJMCKJAJO(T BKCLKIJOKLP, bool GPJDNBLFFPN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x41C2620", Offset = "0x41C1620", VA = "0x1841C2620", Slot = "6")]
	public void MNHCGCIEOKP(T BKCLKIJOKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x41C21C0", Offset = "0x41C11C0", VA = "0x1841C21C0")]
	public void CGFAFPCCKIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface CIANFEHCHKI
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NENJMCKJAJO(Action BKCLKIJOKLP, bool GPJDNBLFFPN = false);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNHCGCIEOKP(Action BKCLKIJOKLP);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class DMENMFODFLB : global::JCIOECKHLAD<Action>, CIANFEHCHKI
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x4D54280", Offset = "0x4D53280", VA = "0x184D54280")]
	public DMENMFODFLB(bool PMCPACKPOOP = false, bool LDHCMKFNDPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x4D53FE0", Offset = "0x4D52FE0", VA = "0x184D53FE0")]
	public void CEKPADBFJKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x4D541A0", Offset = "0x4D531A0", VA = "0x184D541A0", Slot = "4")]
	public override void EPLEHJEKGCH(object[] DFPAFIPCLLC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4D53F80", Offset = "0x4D52F80", VA = "0x184D53F80")]
	public static DMENMFODFLB BNJHJDGNPLG(DMENMFODFLB IEJHAHAJFAP, Action BKCLKIJOKLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x4D54220", Offset = "0x4D53220", VA = "0x184D54220")]
	public static DMENMFODFLB ODGGBCCOGPF(DMENMFODFLB IEJHAHAJFAP, Action BKCLKIJOKLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface ACCABCAMEPF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NENJMCKJAJO(Action<T> BKCLKIJOKLP, bool GPJDNBLFFPN = false);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNHCGCIEOKP(Action<T> BKCLKIJOKLP);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class JKHHCHAOBGN<T> : global::JCIOECKHLAD<Action<T>>, global::ACCABCAMEPF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x30F5C40", Offset = "0x30F4C40", VA = "0x1830F5C40")]
	public JKHHCHAOBGN(bool PMCPACKPOOP = false, bool LDHCMKFNDPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3B365D0", Offset = "0x3B355D0", VA = "0x183B365D0")]
	public void CEKPADBFJKO(T JDLAIFIMIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3675060", Offset = "0x3674060", VA = "0x183675060", Slot = "4")]
	public override void EPLEHJEKGCH(object[] DFPAFIPCLLC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x3672520", Offset = "0x3671520", VA = "0x183672520")]
	public static global::JKHHCHAOBGN<T> BNJHJDGNPLG(global::JKHHCHAOBGN<T> IEJHAHAJFAP, Action<T> BKCLKIJOKLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3675F80", Offset = "0x3674F80", VA = "0x183675F80")]
	public static global::JKHHCHAOBGN<T> ODGGBCCOGPF(global::JKHHCHAOBGN<T> IEJHAHAJFAP, Action<T> BKCLKIJOKLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface ACKAIJMPPCO<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NENJMCKJAJO(Action<T, U> BKCLKIJOKLP, bool GPJDNBLFFPN = false);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNHCGCIEOKP(Action<T, U> BKCLKIJOKLP);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class HEMGBEBKGKH<T, U> : global::JCIOECKHLAD<Action<T, U>>, global::ACKAIJMPPCO<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x30F5C40", Offset = "0x30F4C40", VA = "0x1830F5C40")]
	public HEMGBEBKGKH(bool PMCPACKPOOP = false, bool LDHCMKFNDPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x35D7F60", Offset = "0x35D6F60", VA = "0x1835D7F60")]
	public void CEKPADBFJKO(T JDLAIFIMIJD, U MNLIMBKAJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x35DA390", Offset = "0x35D9390", VA = "0x1835DA390", Slot = "4")]
	public override void EPLEHJEKGCH(object[] DFPAFIPCLLC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x35D5380", Offset = "0x35D4380", VA = "0x1835D5380")]
	public static global::HEMGBEBKGKH<T, U> BNJHJDGNPLG(global::HEMGBEBKGKH<T, U> IEJHAHAJFAP, Action<T, U> BKCLKIJOKLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x35DB8D0", Offset = "0x35DA8D0", VA = "0x1835DB8D0")]
	public static global::HEMGBEBKGKH<T, U> ODGGBCCOGPF(global::HEMGBEBKGKH<T, U> IEJHAHAJFAP, Action<T, U> BKCLKIJOKLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface DNFOGDLKNAL<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NENJMCKJAJO(Action<T, U, V> BKCLKIJOKLP, bool GPJDNBLFFPN = false);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNHCGCIEOKP(Action<T, U, V> BKCLKIJOKLP);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class GHPNKKCLPNO<T, U, V> : global::JCIOECKHLAD<Action<T, U, V>>, global::DNFOGDLKNAL<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x30F5C40", Offset = "0x30F4C40", VA = "0x1830F5C40")]
	public GHPNKKCLPNO(bool PMCPACKPOOP = false, bool LDHCMKFNDPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F990", Offset = "0x3A3E990", VA = "0x183A3F990")]
	public void CEKPADBFJKO(T JDLAIFIMIJD, U MNLIMBKAJDP, V LNDKNIFDPNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x3A40B10", Offset = "0x3A3FB10", VA = "0x183A40B10", Slot = "4")]
	public override void EPLEHJEKGCH(object[] DFPAFIPCLLC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x3A3DED0", Offset = "0x3A3CED0", VA = "0x183A3DED0")]
	public static global::GHPNKKCLPNO<T, U, V> BNJHJDGNPLG(global::GHPNKKCLPNO<T, U, V> IEJHAHAJFAP, Action<T, U, V> BKCLKIJOKLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3A41BD0", Offset = "0x3A40BD0", VA = "0x183A41BD0")]
	public static global::GHPNKKCLPNO<T, U, V> ODGGBCCOGPF(global::GHPNKKCLPNO<T, U, V> IEJHAHAJFAP, Action<T, U, V> BKCLKIJOKLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface BPNKCEMAPIG<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NENJMCKJAJO(Action<T, U, V, W> BKCLKIJOKLP, bool GPJDNBLFFPN = false);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNHCGCIEOKP(Action<T, U, V, W> BKCLKIJOKLP);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class CDGFJDGMEDE<T, U, V, W> : global::JCIOECKHLAD<Action<T, U, V, W>>, global::BPNKCEMAPIG<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x30F5C40", Offset = "0x30F4C40", VA = "0x1830F5C40")]
	public CDGFJDGMEDE(bool PMCPACKPOOP = false, bool LDHCMKFNDPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x30F37F0", Offset = "0x30F27F0", VA = "0x1830F37F0")]
	public void CEKPADBFJKO(T JDLAIFIMIJD, U MNLIMBKAJDP, V LNDKNIFDPNN, W PCMOEMJBGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x30F4530", Offset = "0x30F3530", VA = "0x1830F4530", Slot = "4")]
	public override void EPLEHJEKGCH(object[] DFPAFIPCLLC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x30F2C60", Offset = "0x30F1C60", VA = "0x1830F2C60")]
	public static global::CDGFJDGMEDE<T, U, V, W> BNJHJDGNPLG(global::CDGFJDGMEDE<T, U, V, W> IEJHAHAJFAP, Action<T, U, V, W> BKCLKIJOKLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x30F5BA0", Offset = "0x30F4BA0", VA = "0x1830F5BA0")]
	public static global::CDGFJDGMEDE<T, U, V, W> ODGGBCCOGPF(global::CDGFJDGMEDE<T, U, V, W> IEJHAHAJFAP, Action<T, U, V, W> BKCLKIJOKLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface JIDGJNHKLMA<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NENJMCKJAJO(Action<T, U, V, W, X> BKCLKIJOKLP, bool GPJDNBLFFPN = false);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNHCGCIEOKP(Action<T, U, V, W, X> BKCLKIJOKLP);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class LACMDDHJPGJ<T, U, V, W, X> : global::JCIOECKHLAD<Action<T, U, V, W, X>>, global::JIDGJNHKLMA<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x30F5C40", Offset = "0x30F4C40", VA = "0x1830F5C40")]
	public LACMDDHJPGJ(bool PMCPACKPOOP = false, bool LDHCMKFNDPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3913890", Offset = "0x3912890", VA = "0x183913890")]
	public void CEKPADBFJKO(T JDLAIFIMIJD, U MNLIMBKAJDP, V LNDKNIFDPNN, W PCMOEMJBGBJ, X KDNDPAEEMPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3914160", Offset = "0x3913160", VA = "0x183914160", Slot = "4")]
	public override void EPLEHJEKGCH(object[] DFPAFIPCLLC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x39137F0", Offset = "0x39127F0", VA = "0x1839137F0")]
	public static global::LACMDDHJPGJ<T, U, V, W, X> BNJHJDGNPLG(global::LACMDDHJPGJ<T, U, V, W, X> IEJHAHAJFAP, Action<T, U, V, W, X> BKCLKIJOKLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3914450", Offset = "0x3913450", VA = "0x183914450")]
	public static global::LACMDDHJPGJ<T, U, V, W, X> ODGGBCCOGPF(global::LACMDDHJPGJ<T, U, V, W, X> IEJHAHAJFAP, Action<T, U, V, W, X> BKCLKIJOKLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface GKPFHJHPDIE<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NENJMCKJAJO(Action<T, U, V, W, X, Y> BKCLKIJOKLP, bool GPJDNBLFFPN = false);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNHCGCIEOKP(Action<T, U, V, W, X, Y> BKCLKIJOKLP);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class GPINHFDLANA<T, U, V, W, X, Y> : global::JCIOECKHLAD<Action<T, U, V, W, X, Y>>, global::GKPFHJHPDIE<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x30F5C40", Offset = "0x30F4C40", VA = "0x1830F5C40")]
	public GPINHFDLANA(bool PMCPACKPOOP = false, bool LDHCMKFNDPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x38FA390", Offset = "0x38F9390", VA = "0x1838FA390")]
	public void CEKPADBFJKO(T JDLAIFIMIJD, U MNLIMBKAJDP, V LNDKNIFDPNN, W PCMOEMJBGBJ, X KDNDPAEEMPL, Y HJCNEOFEOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x38FACB0", Offset = "0x38F9CB0", VA = "0x1838FACB0", Slot = "4")]
	public override void EPLEHJEKGCH(object[] DFPAFIPCLLC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x38FA030", Offset = "0x38F9030", VA = "0x1838FA030")]
	public static global::GPINHFDLANA<T, U, V, W, X, Y> BNJHJDGNPLG(global::GPINHFDLANA<T, U, V, W, X, Y> IEJHAHAJFAP, Action<T, U, V, W, X, Y> BKCLKIJOKLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x38FB360", Offset = "0x38FA360", VA = "0x1838FB360")]
	public static global::GPINHFDLANA<T, U, V, W, X, Y> ODGGBCCOGPF(global::GPINHFDLANA<T, U, V, W, X, Y> IEJHAHAJFAP, Action<T, U, V, W, X, Y> BKCLKIJOKLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public sealed class LDFGCLJIJJG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public readonly struct JCPCOCFAFNO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly global::LDFGCLJIJJG<T> FGHGOHMNDJC;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public T NLLJAAOBNLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x390F330", Offset = "0x390E330", VA = "0x18390F330")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x390F350", Offset = "0x390E350", VA = "0x18390F350", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x64B540", Offset = "0x64A540", VA = "0x18064B540")]
		public JCPCOCFAFNO(global::LDFGCLJIJJG<T> FGHGOHMNDJC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct KBDIFEKOEKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder<JCPCOCFAFNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public global::LDFGCLJIJJG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3912EB0", Offset = "0x3911EB0", VA = "0x183912EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x390F2E0", Offset = "0x390E2E0", VA = "0x18390F2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct EEEAPECIFHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder<JCPCOCFAFNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public global::LDFGCLJIJJG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x390EF40", Offset = "0x390DF40", VA = "0x18390EF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x390F2E0", Offset = "0x390E2E0", VA = "0x18390F2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly SemaphoreSlim AJIDLHJEKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private T FFBDFOMCMBB;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int GKBLPIEKKIK
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3916570", Offset = "0x3915570", VA = "0x183916570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3916BD0", Offset = "0x3915BD0", VA = "0x183916BD0")]
	public LDFGCLJIJJG(in T FFBDFOMCMBB, int DCDEECPEDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3916C70", Offset = "0x3915C70", VA = "0x183916C70")]
	public LDFGCLJIJJG(in T FFBDFOMCMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3916B50", Offset = "0x3915B50", VA = "0x183916B50")]
	public JCPCOCFAFNO MCOEOLJBILA()
	{
		return default(JCPCOCFAFNO);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3916B90", Offset = "0x3915B90", VA = "0x183916B90")]
	public JCPCOCFAFNO MCOEOLJBILA(CancellationToken CMOIBOJIACL)
	{
		return default(JCPCOCFAFNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3916590", Offset = "0x3915590", VA = "0x183916590")]
	[AsyncStateMachine(typeof(global::LDFGCLJIJJG<>.KBDIFEKOEKF))]
	public Task<JCPCOCFAFNO> KCBHEMBFHIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x39169D0", Offset = "0x39159D0", VA = "0x1839169D0")]
	[AsyncStateMachine(typeof(global::LDFGCLJIJJG<>.EEEAPECIFHB))]
	public Task<JCPCOCFAFNO> KCBHEMBFHIG(CancellationToken CMOIBOJIACL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class IAANNDHCAPH
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x4D554C0", Offset = "0x4D544C0", VA = "0x184D554C0")]
	public static global::LDFGCLJIJJG<CBIFGBDDJND> CIAOGEOFBKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x4D55450", Offset = "0x4D54450", VA = "0x184D55450")]
	public static global::LDFGCLJIJJG<CBIFGBDDJND> CIAOGEOFBKG(int DCDEECPEDHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x2C00350", Offset = "0x2BFF350", VA = "0x182C00350")]
	public static global::LDFGCLJIJJG<T> CIAOGEOFBKG<T>(in T FFBDFOMCMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2E8E5D0", Offset = "0x2E8D5D0", VA = "0x182E8E5D0")]
	public static global::LDFGCLJIJJG<T> CIAOGEOFBKG<T>(in T FFBDFOMCMBB, int DCDEECPEDHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class KAOKELGFGBD<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate bool JHPNCFBIPAE(global::KAOKELGFGBD<T> BOKLJENJLOP);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class HDFNDPJBBMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public global::KAOKELGFGBD<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public HDFNDPJBBMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3D3EEE0", Offset = "0x3D3DEE0", VA = "0x183D3EEE0")]
		internal bool <FindNode>b__0(global::KAOKELGFGBD<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public T CHNAKPMIOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public LinkedList<global::KAOKELGFGBD<T>> BOKHLLHODJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public global::KAOKELGFGBD<T> KPIDJCNLPLH;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public global::KAOKELGFGBD<T> ANDKMGNGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6513C0", Offset = "0x6503C0", VA = "0x1806513C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3D3F080", Offset = "0x3D3E080", VA = "0x183D3F080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool BAPGHJHPPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3D406C0", Offset = "0x3D3F6C0", VA = "0x183D406C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool LLAKFPHNMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3D41510", Offset = "0x3D40510", VA = "0x183D41510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public global::KAOKELGFGBD<T> MPLJPEEIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3D40030", Offset = "0x3D3F030", VA = "0x183D40030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3D41550", Offset = "0x3D40550", VA = "0x183D41550")]
	public KAOKELGFGBD(T FEILBPJMFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3D407E0", Offset = "0x3D3F7E0", VA = "0x183D407E0")]
	public global::KAOKELGFGBD<T> MLADKEOGKBF(T IBENHFJNCNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3D3F7E0", Offset = "0x3D3E7E0", VA = "0x183D3F7E0")]
	public global::KAOKELGFGBD<T> EFDDPMDIGJJ(T IEONNBOFCGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3D40990", Offset = "0x3D3F990", VA = "0x183D40990")]
	public global::KAOKELGFGBD<T> MNHCGCIEOKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3D3F3C0", Offset = "0x3D3E3C0", VA = "0x183D3F3C0")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3D40180", Offset = "0x3D3F180", VA = "0x183D40180")]
	public global::KAOKELGFGBD<T> JBEHHMLAKHA(T GLGDDCPCPHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x3D3F9B0", Offset = "0x3D3E9B0", VA = "0x183D3F9B0")]
	public static void HDIKIJHHCEG(global::KAOKELGFGBD<T> HKDGPAFLHLL, JHPNCFBIPAE ADCHCDBFMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x38DFD70", Offset = "0x38DED70", VA = "0x1838DFD70")]
	public static void HDIKIJHHCEG<A>(global::KAOKELGFGBD<T> HKDGPAFLHLL, Func<global::KAOKELGFGBD<T>, A, bool> ADCHCDBFMEI, A NOGDFKMIPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x3D40F90", Offset = "0x3D3FF90", VA = "0x183D40F90")]
	public static string OLMBJKNCJKO(global::KAOKELGFGBD<T> HKDGPAFLHLL, int DIAIBOCHHHM = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3D40290", Offset = "0x3D3F290", VA = "0x183D40290")]
	public static global::KAOKELGFGBD<T> MJJBIMCMAJE(global::KAOKELGFGBD<T> HKDGPAFLHLL, T PFCODKFOECI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class EKHPPECGNEP<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public delegate Task<TResult> DDLCJIODBNN(TRequest DMFHFDFMIOL, CancellationToken CMOIBOJIACL);

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum DFCAKGMBJFC
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class BGJIBKKPONF
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private const float MEHHOKFEFCM = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TimeSpan IDICCFEMMNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int HIBLOKNBJPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public DFCAKGMBJFC IGKAGDPHNKN;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly BGJIBKKPONF KAKLFEMJBPO;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float DLEALDPDOGH
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3E87D80", Offset = "0x3E86D80", VA = "0x183E87D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public TimeSpan MKMMMBPKECM
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x5A81F0", Offset = "0x5A71F0", VA = "0x1805A81F0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3E87FB0", Offset = "0x3E86FB0", VA = "0x183E87FB0")]
		public BGJIBKKPONF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private readonly struct CPDPKOGNDMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public readonly TRequest DMFHFDFMIOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public readonly CancellationToken CMOIBOJIACL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public readonly TaskCompletionSource<TResult> IFBJDGECJAB;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3E88080", Offset = "0x3E87080", VA = "0x183E88080")]
		public CPDPKOGNDMK(TRequest DMFHFDFMIOL, TaskCompletionSource<TResult> IFBJDGECJAB, CancellationToken CMOIBOJIACL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class BIHOMPADBPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public BIHOMPADBPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1402F00", Offset = "0x1401F00", VA = "0x181402F00")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct PLHBOMNHNCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public global::EKHPPECGNEP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3E98100", Offset = "0x3E97100", VA = "0x183E98100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5A9460", Offset = "0x5A8460", VA = "0x1805A9460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class EKAKBFKCNNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CPDPKOGNDMK req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public global::EKHPPECGNEP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public EKAKBFKCNNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3E95770", Offset = "0x3E94770", VA = "0x183E95770")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly CancellationTokenSource NELLOLNKPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<CPDPKOGNDMK> OBAKNPENLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly BGJIBKKPONF KKPFBJICEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly DDLCJIODBNN BDLAJAFHBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Task BAFHFLGICBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int FHCLKLEABMI;

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3E978B0", Offset = "0x3E968B0", VA = "0x183E978B0")]
	public EKHPPECGNEP(DDLCJIODBNN BDLAJAFHBFJ, [Optional] BGJIBKKPONF KKPFBJICEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3E96860", Offset = "0x3E95860", VA = "0x183E96860")]
	public Task<TResult> MNJBLIJCDFD(TRequest DMFHFDFMIOL, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3E95C80", Offset = "0x3E94C80", VA = "0x183E95C80")]
	private void BENHOGEOEOP(CPDPKOGNDMK FPLKOOCDOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3E95F00", Offset = "0x3E94F00", VA = "0x183E95F00")]
	[AsyncStateMachine(typeof(global::EKHPPECGNEP<, >.PLHBOMNHNCH))]
	private Task GDCLGIJEKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3E96600", Offset = "0x3E95600", VA = "0x183E96600")]
	private CPDPKOGNDMK IMCOKFECAJL()
	{
		return default(CPDPKOGNDMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3E96F80", Offset = "0x3E95F80", VA = "0x183E96F80")]
	private void OAJGKGCOEDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3E95DB0", Offset = "0x3E94DB0", VA = "0x183E95DB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class AAOBANAHOBE<TKey, TVal> : global::MNJJEOCAODK<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int IGLDDNGINAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	internal Dictionary<TKey, (TVal value, int size)> OHICEBKCCGF;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	internal override int APANJMKHEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x1402880", Offset = "0x1401880", VA = "0x181402880", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	internal int GHFLINOAECP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1402AE0", Offset = "0x1401AE0", VA = "0x181402AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public override int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1402710", Offset = "0x1401710", VA = "0x181402710", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x1402CA0", Offset = "0x1401CA0", VA = "0x181402CA0")]
	public AAOBANAHOBE(int NKJBJGFALMO, [Optional] KBEBHCMPFNO MGNGOHNPJMK, [Optional] IEqualityComparer<TKey> IMMINEHIHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x1402770", Offset = "0x1401770", VA = "0x181402770")]
	public void BOMMHKAGJPD(TKey MKDJIBNCKNC, TVal MPHFKGJNMOK, bool LOBFFGFGIHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x1402C20", Offset = "0x1401C20", VA = "0x181402C20")]
	public bool OFKBBGGDFII(TKey MKDJIBNCKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x14025C0", Offset = "0x14015C0", VA = "0x1814025C0", Slot = "6")]
	public override bool ACEOCCKNHLM(TKey DPILHFBKDPD, out TVal MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x14028B0", Offset = "0x14018B0", VA = "0x1814028B0")]
	public bool GLACPOKAIAE(TKey MKDJIBNCKNC, TVal MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x1402B10", Offset = "0x1401B10", VA = "0x181402B10")]
	public bool NKFCLMIEBBF(TKey MKDJIBNCKNC, TVal MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x1402810", Offset = "0x1401810", VA = "0x181402810", Slot = "7")]
	public override void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x1402670", Offset = "0x1401670", VA = "0x181402670")]
	private bool BBBOAFHBNEH(TKey MKDJIBNCKNC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[DefaultMember("Item")]
public class MNJJEOCAODK<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public delegate int KBEBHCMPFNO(TKey MKDJIBNCKNC, TVal MPHFKGJNMOK);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class EBBCEOAHEDN
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public TKey FJPMPBHLOOP
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x5A81F0", Offset = "0x5A71F0", VA = "0x1805A81F0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public TVal NLLJAAOBNLN
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x7D5110", Offset = "0x7D4110", VA = "0x1807D5110")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x8C4BD0", Offset = "0x8C3BD0", VA = "0x1808C4BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public int OJCJOGAFMFG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x5AA200", Offset = "0x5A9200", VA = "0x1805AA200")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x5AA250", Offset = "0x5A9250", VA = "0x1805AA250")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public DateTime FFJGAHEEILE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x5B1950", Offset = "0x5B0950", VA = "0x1805B1950")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x888D80", Offset = "0x887D80", VA = "0x180888D80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x40019B0", Offset = "0x40009B0", VA = "0x1840019B0")]
		public EBBCEOAHEDN(TKey MKDJIBNCKNC, TVal GBDFHGIMHBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public const int NOKBGKBILHO = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly Dictionary<TKey, LinkedListNode<EBBCEOAHEDN>> CGHENOKHCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly LinkedList<EBBCEOAHEDN> FNAAFFKCDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	protected readonly KBEBHCMPFNO MGNGOHNPJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly TimeSpan OAJCCBLDMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly NHFJKNGOAGN CAJMJEDGGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int LELNFFOEHKA;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int NPEDIGKGFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x5CB380", Offset = "0x5CA380", VA = "0x1805CB380")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private bool CNDPNPLFLLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4016970", Offset = "0x4015970", VA = "0x184016970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	internal virtual int APANJMKHEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8005B0", Offset = "0x7FF5B0", VA = "0x1808005B0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private int DHNBJNKGAHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x1403DC0", Offset = "0x1402DC0", VA = "0x181403DC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public virtual int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2CDD440", Offset = "0x2CDC440", VA = "0x182CDD440", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<TKey> GCFCKHBGHHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4017190", Offset = "0x4016190", VA = "0x184017190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public TVal NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3403450", Offset = "0x3402450", VA = "0x183403450")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x389C4C0", Offset = "0x389B4C0", VA = "0x18389C4C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4017EA0", Offset = "0x4016EA0", VA = "0x184017EA0")]
	public MNJJEOCAODK(int NKJBJGFALMO, [Optional] KBEBHCMPFNO MGNGOHNPJMK, [Optional] IEqualityComparer<TKey> IMMINEHIHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x4017960", Offset = "0x4016960", VA = "0x184017960")]
	public MNJJEOCAODK(TimeSpan OAJCCBLDMCD, [Optional] IEqualityComparer<TKey> IMMINEHIHCI, [Optional] NHFJKNGOAGN CAJMJEDGGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x40179B0", Offset = "0x40169B0", VA = "0x1840179B0")]
	public MNJJEOCAODK(int NKJBJGFALMO, TimeSpan OAJCCBLDMCD, [Optional] IEqualityComparer<TKey> IMMINEHIHCI, [Optional] NHFJKNGOAGN CAJMJEDGGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x4017C50", Offset = "0x4016C50", VA = "0x184017C50")]
	public MNJJEOCAODK(int NKJBJGFALMO, KBEBHCMPFNO MGNGOHNPJMK, TimeSpan OAJCCBLDMCD, [Optional] IEqualityComparer<TKey> IMMINEHIHCI, [Optional] NHFJKNGOAGN CAJMJEDGGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x40177F0", Offset = "0x40167F0", VA = "0x1840177F0")]
	public void OKGGIJMCCBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x40173B0", Offset = "0x40163B0", VA = "0x1840173B0")]
	public void KJOMPIGOOHG(TKey MKDJIBNCKNC, TVal MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4017530", Offset = "0x4016530", VA = "0x184017530")]
	public bool MNHCGCIEOKP(TKey MKDJIBNCKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4017740", Offset = "0x4016740", VA = "0x184017740")]
	private TVal NELNIMGBJDL(TKey DPILHFBKDPD)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4016130", Offset = "0x4015130", VA = "0x184016130", Slot = "6")]
	public virtual bool ACEOCCKNHLM(TKey DPILHFBKDPD, out TVal MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4016560", Offset = "0x4015560", VA = "0x184016560", Slot = "7")]
	public virtual void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x40163E0", Offset = "0x40153E0", VA = "0x1840163E0")]
	private bool AJGFBOGIILO(EBBCEOAHEDN FHIFMCKLKIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4016D40", Offset = "0x4015D40", VA = "0x184016D40")]
	private void GAKEJIECJMO(LinkedListNode<EBBCEOAHEDN> INLBOMPPGEC, TVal JKGBMLLOBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x40165D0", Offset = "0x40155D0", VA = "0x1840165D0")]
	private void EMKENJFOCJF(TKey MKDJIBNCKNC, TVal MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x4016A00", Offset = "0x4015A00", VA = "0x184016A00")]
	private void FIOEDJLHAGG(EBBCEOAHEDN FHIFMCKLKIJ, TVal JKGBMLLOBKK, int IHELJAFNFGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DefaultMember("Item")]
public class PCOKAEPICEC<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly List<T> EJCFBHKFPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private HashSet<T> MLIIGDCHMLG;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x1402F00", Offset = "0x1401F00", VA = "0x181402F00", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool GCLNONOIJMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x551490", Offset = "0x550490", VA = "0x180551490", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public T NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x1403320", Offset = "0x1402320", VA = "0x181403320", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4092310", Offset = "0x4091310", VA = "0x184092310", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x35D51C0", Offset = "0x35D41C0", VA = "0x1835D51C0", Slot = "11")]
	public void Add(T JAKHJIEAJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4091E30", Offset = "0x4090E30", VA = "0x184091E30")]
	public bool LHNHAJKKNNC(T JAKHJIEAJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4092120", Offset = "0x4091120", VA = "0x184092120", Slot = "15")]
	public bool Remove(T JAKHJIEAJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3923660", Offset = "0x3922660", VA = "0x183923660", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1403C90", Offset = "0x1402C90", VA = "0x181403C90", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4091A70", Offset = "0x4090A70", VA = "0x184091A70", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x370EB50", Offset = "0x370DB50", VA = "0x18370EB50", Slot = "13")]
	public bool Contains(T JAKHJIEAJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x1402E10", Offset = "0x1401E10", VA = "0x181402E10", Slot = "14")]
	public void CopyTo(T[] BEGPAFGBCJM, int KHBOJEFOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x31CC290", Offset = "0x31CB290", VA = "0x1831CC290", Slot = "6")]
	public int IndexOf(T JAKHJIEAJDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4091BD0", Offset = "0x4090BD0", VA = "0x184091BD0", Slot = "7")]
	public void Insert(int HOOANEAGKNH, T JAKHJIEAJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x4091F80", Offset = "0x4090F80", VA = "0x184091F80", Slot = "8")]
	public void RemoveAt(int HOOANEAGKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x4091D60", Offset = "0x4090D60", VA = "0x184091D60")]
	public void JPDGOHOAFDO(Predicate<T> MOCGNKJBNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x4091AD0", Offset = "0x4090AD0", VA = "0x184091AD0")]
	public void GODLBFOGBPL(Comparison<T> OLNLPDCDNHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x4092230", Offset = "0x4091230", VA = "0x184092230")]
	public PCOKAEPICEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class GDGPHELNJNO
{
	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x4D54740", Offset = "0x4D53740", VA = "0x184D54740")]
	public static Vector3 FPDALGMJCJH(this GameObject NIKGFIPEJKD, float HKAGPPDOKGA)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x6ACEE0", Offset = "0x6ABEE0", VA = "0x1806ACEE0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4D59660", Offset = "0x4D58660", VA = "0x184D59660")]
		public SerializedGuid(in Guid JAEJGMEOIFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x4D591B0", Offset = "0x4D581B0", VA = "0x184D591B0")]
		public static SerializedGuid BGDPBAKHENH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4D59480", Offset = "0x4D58480", VA = "0x184D59480")]
		public static SerializedGuid LNBFHDGHKCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4D59500", Offset = "0x4D58500", VA = "0x184D59500")]
		public bool OEEIPECNPFA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4D59630", Offset = "0x4D58630", VA = "0x184D59630", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4D59590", Offset = "0x4D58590", VA = "0x184D59590", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4D59260", Offset = "0x4D58260", VA = "0x184D59260")]
		public bool EODIBPOHCMG(in Guid JAEJGMEOIFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4D592F0", Offset = "0x4D582F0", VA = "0x184D592F0", Slot = "7")]
		public bool Equals(SerializedGuid GJPJDOANCNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x4D59390", Offset = "0x4D58390", VA = "0x184D59390", Slot = "0")]
		public override bool Equals(object FIEDOLNFNLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x4D59470", Offset = "0x4D58470", VA = "0x184D59470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x4D59230", Offset = "0x4D58230", VA = "0x184D59230", Slot = "6")]
		public int CompareTo(SerializedGuid GJPJDOANCNK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class EBJBMKGEPOF : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly Type JNGKNCDPJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly string LHMNCCJEFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly bool IDEEADDIBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly bool AAHNOIHMCHM;

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x4D542E0", Offset = "0x4D532E0", VA = "0x184D542E0")]
	public EBJBMKGEPOF(Type JFOHOJCMPFN, string HEJPHGDJLFJ, bool EHJILPCPPNA = false, bool KNBPAJNJHGG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface HMCJOMOJICA
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface HIOHEHIBBAB<T> : HMCJOMOJICA
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	T NLLJAAOBNLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool AMFKCCOECJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string DDACGDALABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::HIOHEHIBBAB<T> NABIICCLMIE(Action<T> HAMPEPEMKKP);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::HIOHEHIBBAB<T> NKLBBHCBAFG(Action<T> HAMPEPEMKKP);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::HIOHEHIBBAB<T> GNAPGOKJNAF(Action<T, T> JGCLGOFNOEF);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::HIOHEHIBBAB<T> IAIMPEBPJPC(Action<T, T> JGCLGOFNOEF);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::HIOHEHIBBAB<T> HEIHFCBPGCG(Action<string> PPAFCJMLBKH);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::HIOHEHIBBAB<T> ICCGDMFPEDB(Action<string> PPAFCJMLBKH);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class BHNDNAOGBDH<T> : global::HIOHEHIBBAB<T>, HMCJOMOJICA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private global::HEMGBEBKGKH<T, T> HLDKCBJDKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private global::JKHHCHAOBGN<T> CFDAEHFHOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private global::JKHHCHAOBGN<string> BGKLDIOCHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private string IOBNDAKOHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private T AEOILPMENGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool NFOFGNIFILC;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public T NLLJAAOBNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5CB390", Offset = "0x5CA390", VA = "0x1805CB390", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3410160", Offset = "0x340F160", VA = "0x183410160", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool AMFKCCOECJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6C03B0", Offset = "0x6BF3B0", VA = "0x1806C03B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string DDACGDALABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5CBDD0", Offset = "0x5CADD0", VA = "0x1805CBDD0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x32C1D70", Offset = "0x32C0D70", VA = "0x1832C1D70", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x38A0350", Offset = "0x389F350", VA = "0x1838A0350")]
	private void GOMBGNICLJL(T JMPKGJCDKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x38A0540", Offset = "0x389F540", VA = "0x1838A0540")]
	private void MGPPKDDGIOD(string EPAKPJCIEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x38A0670", Offset = "0x389F670", VA = "0x1838A0670")]
	public void NFEMDFDACGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x38A0300", Offset = "0x389F300", VA = "0x1838A0300", Slot = "6")]
	public global::HIOHEHIBBAB<T> GNAPGOKJNAF(Action<T, T> JGCLGOFNOEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x38A0480", Offset = "0x389F480", VA = "0x1838A0480", Slot = "7")]
	public global::HIOHEHIBBAB<T> IAIMPEBPJPC(Action<T, T> JGCLGOFNOEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x38A05E0", Offset = "0x389F5E0", VA = "0x1838A05E0", Slot = "4")]
	public global::HIOHEHIBBAB<T> NABIICCLMIE(Action<T> JGCLGOFNOEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x38A0720", Offset = "0x389F720", VA = "0x1838A0720", Slot = "5")]
	public global::HIOHEHIBBAB<T> NKLBBHCBAFG(Action<T> HAMPEPEMKKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x38A03F0", Offset = "0x389F3F0", VA = "0x1838A03F0", Slot = "8")]
	public global::HIOHEHIBBAB<T> HEIHFCBPGCG(Action<string> PPAFCJMLBKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x38A04D0", Offset = "0x389F4D0", VA = "0x1838A04D0", Slot = "9")]
	public global::HIOHEHIBBAB<T> ICCGDMFPEDB(Action<string> PPAFCJMLBKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x38A0770", Offset = "0x389F770", VA = "0x1838A0770")]
	public BHNDNAOGBDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class FLACLONOMKD
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class IBAJPDPAADF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public global::HIOHEHIBBAB<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public global::GKABJNPDFNH<T> promise;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public IBAJPDPAADF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3762C60", Offset = "0x3761C60", VA = "0x183762C60")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x32FF4D0", Offset = "0x32FE4D0", VA = "0x1832FF4D0")]
	public static global::DBIKMJJJBLJ<T> EKBBEKNBECD<T>(this global::HIOHEHIBBAB<T> LJGBBNNBFPD, Action<T> HKHGMJEBNHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class NHFJKNGOAGN
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private class MILIBNLKNOF : NHFJKNGOAGN
	{
		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public static NHFJKNGOAGN NNHENCBEIJC
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x4D55A40", Offset = "0x4D54A40", VA = "0x184D55A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public override DateTime NCNDHGHHKHK
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x4D559F0", Offset = "0x4D549F0", VA = "0x184D559F0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public override float NOLLPMMLKJD
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x4D559E0", Offset = "0x4D549E0", VA = "0x184D559E0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x4D55B40", Offset = "0x4D54B40", VA = "0x184D55B40")]
		public MILIBNLKNOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static NHFJKNGOAGN OKFEOJBPJBJ;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static NHFJKNGOAGN KAKLFEMJBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x4D55CF0", Offset = "0x4D54CF0", VA = "0x184D55CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public abstract DateTime NCNDHGHHKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public abstract float NOLLPMMLKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	protected NHFJKNGOAGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class PJBLBLCHIFH : global::AHJIKHKMCDI<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4D579A0", Offset = "0x4D569A0", VA = "0x184D579A0")]
	public PJBLBLCHIFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class AHJIKHKMCDI<T> : global::JCLACCKFIDM<T>, LGAPFCEPPIC, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Task<T> JCFIGADOAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5A81F0", Offset = "0x5A71F0", VA = "0x1805A81F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private Task COONIMNAIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public global::DBIKMJJJBLJ<T> GKHIOGLLJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private APPFHLGLKJA EKNOALKKOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xD08A80", Offset = "0xD07A80", VA = "0x180D08A80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x35F4B20", Offset = "0x35F3B20", VA = "0x1835F4B20")]
	public AHJIKHKMCDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class FHJAKKGBEKJ : global::FCEOCOBEBDJ<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4D54630", Offset = "0x4D53630", VA = "0x184D54630")]
	public FHJAKKGBEKJ(Exception BACBMFCMEGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class FCEOCOBEBDJ<T> : global::JCLACCKFIDM<T>, LGAPFCEPPIC, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Task<T> JCFIGADOAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x5A81F0", Offset = "0x5A71F0", VA = "0x1805A81F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	private Task COONIMNAIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public global::DBIKMJJJBLJ<T> GKHIOGLLJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private APPFHLGLKJA EKNOALKKOEE
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xD08A80", Offset = "0xD07A80", VA = "0x180D08A80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x347CE80", Offset = "0x347BE80", VA = "0x18347CE80")]
	public FCEOCOBEBDJ(Exception BACBMFCMEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface LGAPFCEPPIC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	[NotNull]
	Task JCFIGADOAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	[NotNull]
	APPFHLGLKJA GKHIOGLLJDF
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface JCLACCKFIDM<T> : LGAPFCEPPIC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	[NotNull]
	new Task<T> JCFIGADOAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	[NotNull]
	new global::DBIKMJJJBLJ<T> GKHIOGLLJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class GHGFFGBOLOB<TTask, T> : global::JCLACCKFIDM<T>, LGAPFCEPPIC, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class JGIBIEMKEBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public global::GHGFFGBOLOB<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public JGIBIEMKEBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static bool AGNHLHEAKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly Task<T> IPFPIIBOBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	protected readonly CancellationTokenSource LJJFJBNCDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool PGGNJMMOIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private SynchronizationContext HIHNLMOEPDP;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> JCFIGADOAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x5A81F0", Offset = "0x5A71F0", VA = "0x1805A81F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task COONIMNAIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x5A81F0", Offset = "0x5A71F0", VA = "0x1805A81F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::DBIKMJJJBLJ<T> GKHIOGLLJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private APPFHLGLKJA EKNOALKKOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x17E5BD0", Offset = "0x17E4BD0", VA = "0x1817E5BD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool FAIGJIHBAPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6C03E0", Offset = "0x6BF3E0", VA = "0x1806C03E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x3A3B360", Offset = "0x3A3A360", VA = "0x183A3B360")]
	static GHGFFGBOLOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3A3B640", Offset = "0x3A3A640", VA = "0x183A3B640")]
	protected GHGFFGBOLOB(TTask IPFPIIBOBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x3A3AFE0", Offset = "0x3A39FE0", VA = "0x183A3AFE0", Slot = "1")]
	~GHGFFGBOLOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3852EF0", Offset = "0x3851EF0", VA = "0x183852EF0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x3A3B080", Offset = "0x3A3A080", VA = "0x183A3B080")]
	private void HLHLNLIFMIH(bool PAKHJBEPDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T FMPKNFLALEF(TTask COJLNPLMJBD);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void LOEEBHLGKFG();

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x3A3AEF0", Offset = "0x3A39EF0", VA = "0x183A3AEF0")]
	[CompilerGenerated]
	private void APOEOAEHPEO(object JIGKFMMLBHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class EFODBOGLLLN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly Type JNGKNCDPJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly string LHMNCCJEFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly bool IDEEADDIBHF;

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x4D54350", Offset = "0x4D53350", VA = "0x184D54350")]
	public EFODBOGLLLN(Type JFOHOJCMPFN, string HEJPHGDJLFJ, bool EHJILPCPPNA = false)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x5A9980", Offset = "0x5A8980", VA = "0x1805A9980")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x5AA280", Offset = "0x5A9280", VA = "0x1805AA280")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public T this[int CKOCCIDDCLA, int ECEAAAFOIBE]
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x35E0280", Offset = "0x35DF280", VA = "0x1835E0280")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x35E0320", Offset = "0x35DF320", VA = "0x1835E0320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x35E01F0", Offset = "0x35DF1F0", VA = "0x1835E01F0")]
		public Array2D(uint KIDBPFAHLEE, uint CNJPPLLLBHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x35E0170", Offset = "0x35DF170", VA = "0x1835E0170")]
		public void CGFAFPCCKIC()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x4D53650", Offset = "0x4D52650", VA = "0x184D53650")]
		public Array2DVector3(uint KIDBPFAHLEE, uint CNJPPLLLBHD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal static class CKNFOJAGOKK
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public const int DLGGHJMPCIC = -1;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public const int NAKJBFKGCJO = 0;
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[DefaultMember("Item")]
public class NGOAGBPGLJE<THandle, TValue> : IDisposable where THandle : struct, HIOBFMFHHNO where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly List<THandle> HLDMDPPGMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly List<TValue> FLJHHGNBDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Func<TValue> NMHAGANEFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Action<TValue> KEALOEJJNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int HHJICIDPDCE;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public TValue NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x389C700", Offset = "0x389B700", VA = "0x18389C700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x40A4B70", Offset = "0x40A3B70", VA = "0x1840A4B70")]
	public NGOAGBPGLJE(Action<TValue> KEALOEJJNAA, [Optional] Func<TValue> NMHAGANEFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x40A4140", Offset = "0x40A3140", VA = "0x1840A4140", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x40A4450", Offset = "0x40A3450", VA = "0x1840A4450")]
	public THandle GPCBEJLMGEM()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x40A4940", Offset = "0x40A3940", VA = "0x1840A4940")]
	public THandle NENJMCKJAJO(TValue MPHFKGJNMOK)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x40A4840", Offset = "0x40A3840", VA = "0x1840A4840")]
	public bool MNHCGCIEOKP(THandle JDOONLDLMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x40A4A90", Offset = "0x40A3A90", VA = "0x1840A4A90")]
	public bool PILHJPINMMC(THandle JDOONLDLMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x40A49B0", Offset = "0x40A39B0", VA = "0x1840A49B0")]
	public bool ODOHFJDGPNB(THandle JDOONLDLMNB, out TValue MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x40A48F0", Offset = "0x40A38F0", VA = "0x1840A48F0")]
	public TValue NELNIMGBJDL(THandle JDOONLDLMNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x40A4050", Offset = "0x40A3050", VA = "0x1840A4050")]
	public bool BCEGDDCILHE(THandle JDOONLDLMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x40A4A60", Offset = "0x40A3A60", VA = "0x1840A4A60")]
	private THandle OHINCNKNFHF(int HOOANEAGKNH)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x40A41C0", Offset = "0x40A31C0", VA = "0x1840A41C0")]
	private TValue EKBBEKNBECD(int HOOANEAGKNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x40A4100", Offset = "0x40A3100", VA = "0x1840A4100")]
	private void DOKIDABGIKC(int HOOANEAGKNH, in THandle JDOONLDLMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x40A4370", Offset = "0x40A3370", VA = "0x1840A4370")]
	private void GOMBGNICLJL(int HOOANEAGKNH, in TValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x40A45A0", Offset = "0x40A35A0", VA = "0x1840A45A0")]
	private THandle HPODAFDFNFN()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x40A4780", Offset = "0x40A3780", VA = "0x1840A4780")]
	private void LCAANIAOGGP(THandle JDOONLDLMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x40A4590", Offset = "0x40A3590", VA = "0x1840A4590")]
	private int HLLBFPOFIMD(int MNOJMAIICKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x40A4A50", Offset = "0x40A3A50", VA = "0x1840A4A50")]
	private bool OGDCOGGMFMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x640D80", Offset = "0x63FD80", VA = "0x180640D80")]
	private void AMEHBEDAPLO(THandle JDOONLDLMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x40A3FD0", Offset = "0x40A2FD0", VA = "0x1840A3FD0")]
	private bool ADLPOELHGCD(out THandle JDOONLDLMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x40A46B0", Offset = "0x40A36B0", VA = "0x1840A46B0")]
	private bool JMEODAEKGND(out THandle JDOONLDLMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x40A41F0", Offset = "0x40A31F0", VA = "0x1840A41F0")]
	private void GAHODKPOCKI(THandle JDOONLDLMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x40A4250", Offset = "0x40A3250", VA = "0x1840A4250")]
	private void GEAMEIPHNEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface HIOBFMFHHNO
{
	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	int OOODCJOIDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	int BGIBIINMANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface IBNHPOIIGBN<T> : HIOBFMFHHNO, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class OBODLAKFOCE
{
	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x2F71860", Offset = "0x2F70860", VA = "0x182F71860")]
	public static bool PEKIMJGAHDI<T>(this T JDOONLDLMNB) where T : struct, HIOBFMFHHNO
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class OCGNCOEEANA
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private enum NOGMLHFBLEP : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int NPNGOLKAOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool GMCFBENGBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NOGMLHFBLEP HMGOCFOIBEE;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool PGNEIIMMCHM
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x4D56060", Offset = "0x4D55060", VA = "0x184D56060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool KJPPGFPIMLB
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x4D567C0", Offset = "0x4D557C0", VA = "0x184D567C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x4D56C50", Offset = "0x4D55C50", VA = "0x184D56C50")]
	public OCGNCOEEANA(bool GMCFBENGBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x4D56080", Offset = "0x4D55080", VA = "0x184D56080")]
	public void CKGMELJJGCG(object FIEDOLNFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x4D55FB0", Offset = "0x4D54FB0", VA = "0x184D55FB0")]
	public void CBJOFMOBAGP(int MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x4D56C00", Offset = "0x4D55C00", VA = "0x184D56C00")]
	public void OAFNBGMKADI(uint PMPFHJPGCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x4D55E70", Offset = "0x4D54E70", VA = "0x184D55E70")]
	public void APNDMJJNFGO(bool MJNLGMBFHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x4D56C10", Offset = "0x4D55C10", VA = "0x184D56C10")]
	public void OAGJHDGEKGP(long JAMCMBENHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x4D56780", Offset = "0x4D55780", VA = "0x184D56780")]
	public void LKAKFDNMABH(ulong AKGOEMFCLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x4D56610", Offset = "0x4D55610", VA = "0x184D56610")]
	public void GBIPJNGEOHM(string IOLGJHAFBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x4D566F0", Offset = "0x4D556F0", VA = "0x184D566F0")]
	public void KOCNCDBNHGN(Enum BACBMFCMEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x4D55E90", Offset = "0x4D54E90", VA = "0x184D55E90")]
	public void BAOHNILAFHG(IList EJCFBHKFPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x38EA2E0", Offset = "0x38E92E0", VA = "0x1838EA2E0")]
	public void GAKNIMDGPKE<T, U>(Dictionary<T, U> JFPAPBLAAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x4D56840", Offset = "0x4D55840", VA = "0x184D56840")]
	private void NHFJJDNGDKP(IDictionary JFPAPBLAAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x4D565A0", Offset = "0x4D555A0", VA = "0x184D565A0")]
	public int FKOIBIPNLKP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x4D567D0", Offset = "0x4D557D0", VA = "0x184D567D0")]
	public short MOPPMFJKDOK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x4D56070", Offset = "0x4D55070", VA = "0x184D56070")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x4D56680", Offset = "0x4D55680", VA = "0x184D56680")]
	private void HIPINLMMBAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public abstract class AEOLALLGKEO<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	internal class CIKFCFIJNCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public TNode GNFIGHOBONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public TNode COLFLONKFJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public LJEHGKOLACE OGIOFICPCOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public List<LJEHGKOLACE> ODGFPDNHIPP;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public CIKFCFIJNCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal struct LJEHGKOLACE : IComparable<LJEHGKOLACE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int MBHEGCHNPDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public TClaimant APHPCLKAACF;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x5F81D0", Offset = "0x5F71D0", VA = "0x1805F81D0")]
		public LJEHGKOLACE(int MBHEGCHNPDE, TClaimant APHPCLKAACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x140AA90", Offset = "0x1409A90", VA = "0x18140AA90")]
		public bool BAKDKFBHCKN(in LJEHGKOLACE GJPJDOANCNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x140AB00", Offset = "0x1409B00", VA = "0x18140AB00")]
		public bool JONLKKKFGBI(in LJEHGKOLACE GJPJDOANCNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x140AAF0", Offset = "0x1409AF0", VA = "0x18140AAF0", Slot = "4")]
		public int CompareTo(LJEHGKOLACE GJPJDOANCNK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x140AB10", Offset = "0x1409B10", VA = "0x18140AB10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum BIHPEGCAPGK
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class ODMCLGGPHFM : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public global::AEOLALLGKEO<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x140DA50", Offset = "0x140CA50", VA = "0x18140DA50")]
		[DebuggerHidden]
		public ODMCLGGPHFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x140D810", Offset = "0x140C810", VA = "0x18140D810", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x140DA00", Offset = "0x140CA00", VA = "0x18140DA00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x140D8F0", Offset = "0x140C8F0", VA = "0x18140D8F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x140D9D0", Offset = "0x140C9D0", VA = "0x18140D9D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly global::HBJLICKFJIO<CIKFCFIJNCG> HHMDIGGALIM;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly global::HBJLICKFJIO<List<LJEHGKOLACE>> CPBJJALNGKB;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static int BDOKFKNNLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	internal readonly Dictionary<TClaimant, TNode> OHAIKHNEINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	internal readonly Dictionary<TNode, CIKFCFIJNCG> LHCNKJGDGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private BIHPEGCAPGK EAPLEPGNBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private bool ECMCAACONHH;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode KEOGLGFJKMO(TNode BOKLJENJLOP);

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void OCOCJFLDOPD(TNode BOKLJENJLOP, TClaimant CJPNLCMLIKI, TClaimant DJLBBEJBKHM);

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x14057D0", Offset = "0x14047D0", VA = "0x1814057D0")]
	public AEOLALLGKEO(BIHPEGCAPGK EAPLEPGNBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x1404550", Offset = "0x1403550", VA = "0x181404550")]
	public void BPGJJNCCNJI(TNode BOKLJENJLOP, TNode GLGDDCPCPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x1404A00", Offset = "0x1403A00", VA = "0x181404A00")]
	public void IAMCHPFMBHP(TClaimant APHPCLKAACF, TNode JAFNCECJODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x1404640", Offset = "0x1403640", VA = "0x181404640", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x14044B0", Offset = "0x14034B0", VA = "0x1814044B0")]
	private void BMDJNPILBEH(TClaimant APHPCLKAACF, TNode PLJILEIJPGP, TNode JAFNCECJODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x14045D0", Offset = "0x14035D0", VA = "0x1814045D0")]
	private int CLDICIIOBNI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x1404B00", Offset = "0x1403B00", VA = "0x181404B00")]
	private void IPHHBBAOKKJ(TClaimant APHPCLKAACF, TNode AFNDIAJPOAN, TNode KOAFJALDAFB, int BHCLMPNOLIG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x14048A0", Offset = "0x14038A0", VA = "0x1814048A0")]
	private void GAOLEENJAJI(LJEHGKOLACE DBEMPPMLEHC, CIKFCFIJNCG AAAFOBDFEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x1405240", Offset = "0x1404240", VA = "0x181405240")]
	private void PBLMJDFOONJ(TClaimant APHPCLKAACF, TNode AFNDIAJPOAN, TNode KOAFJALDAFB, int BHCLMPNOLIG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x14043B0", Offset = "0x14033B0", VA = "0x1814043B0")]
	private void ANOAOFDGOAK(LJEHGKOLACE DBEMPPMLEHC, TNode BOKLJENJLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x1405570", Offset = "0x1404570", VA = "0x181405570")]
	private void PNDDBFPJCKL(LJEHGKOLACE DBEMPPMLEHC, CIKFCFIJNCG AAAFOBDFEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x1405100", Offset = "0x1404100", VA = "0x181405100")]
	private void NMEHKPKACFM(CIKFCFIJNCG AAAFOBDFEMH, bool PGLJPKEDFGD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x1403F70", Offset = "0x1402F70", VA = "0x181403F70")]
	private void AJBJKALEHCE(CIKFCFIJNCG AAAFOBDFEMH, TNode GLGDDCPCPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x1404930", Offset = "0x1403930", VA = "0x181404930")]
	[IteratorStateMachine(typeof(global::AEOLALLGKEO<, >.ODMCLGGPHFM))]
	private IEnumerable<TNode> GKKKHMFDPEP(TNode AFNDIAJPOAN, TNode KOAFJALDAFB, bool CAKLNPJIFKH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x14054B0", Offset = "0x14044B0", VA = "0x1814054B0")]
	private CIKFCFIJNCG PDBMDAKBCKJ(TNode BOKLJENJLOP, TNode COLFLONKFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x1404F70", Offset = "0x1403F70", VA = "0x181404F70")]
	private CIKFCFIJNCG MLLBJKGABMM(TNode BOKLJENJLOP, TNode COLFLONKFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x1404DB0", Offset = "0x1403DB0", VA = "0x181404DB0")]
	private void KBJKINPPCDM(CIKFCFIJNCG AAAFOBDFEMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class IGGDGPNFHDG<T> : IEnumerable<global::IGGDGPNFHDG<T>.OMELAKCGOAG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public struct OMELAKCGOAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T MPHFKGJNMOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int HOOANEAGKNH;
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class CBMDMACNNGJ : IEnumerator<OMELAKCGOAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private global::IGGDGPNFHDG<T> HGLPMHHCNKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private int HOOANEAGKNH;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x8B60C0", Offset = "0x8B50C0", VA = "0x1808B60C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public OMELAKCGOAG ANMAFMODJCP
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x8B6170", Offset = "0x8B5170", VA = "0x1808B6170", Slot = "4")]
			get
			{
				return default(OMELAKCGOAG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8B6130", Offset = "0x8B5130", VA = "0x1808B6130")]
		public CBMDMACNNGJ(global::IGGDGPNFHDG<T> HGLPMHHCNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8B6020", Offset = "0x8B5020", VA = "0x1808B6020", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8B60B0", Offset = "0x8B50B0", VA = "0x1808B60B0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8B6000", Offset = "0x8B5000", VA = "0x1808B6000", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct CCNCNADPILI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool PEEJEHPIILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public T MPHFKGJNMOK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int NPAINHCLJIB = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private Dictionary<T, int> JFLOKGHEKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private CCNCNADPILI[] KLJPADGFFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int FPAOMGALAAK;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8CB370", Offset = "0x8CA370", VA = "0x1808CB370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x8CB440", Offset = "0x8CA440", VA = "0x1808CB440")]
	public static global::IGGDGPNFHDG<T> EDIEEHOLKNH(OMELAKCGOAG[] FPDDLLOHFAD, bool BHJODBGOKGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x8CBFE0", Offset = "0x8CAFE0", VA = "0x1808CBFE0")]
	public IGGDGPNFHDG(int NKJBJGFALMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x8CBF30", Offset = "0x8CAF30", VA = "0x1808CBF30")]
	public bool OOHILGBIADI(T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x8CBAB0", Offset = "0x8CAAB0", VA = "0x1808CBAB0")]
	public bool HJNFPPBJHAH(int HOOANEAGKNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x8CB890", Offset = "0x8CA890", VA = "0x1808CB890")]
	public bool FECGJJAPIMF(Func<T, bool> CJHEFBNLMBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x8CBEE0", Offset = "0x8CAEE0", VA = "0x1808CBEE0")]
	public int ODFAONLHFEP(T MPHFKGJNMOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x8CB820", Offset = "0x8CA820", VA = "0x1808CB820")]
	public T EKBBEKNBECD(int HOOANEAGKNH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x8CB3A0", Offset = "0x8CA3A0", VA = "0x1808CB3A0")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x8CBD90", Offset = "0x8CAD90", VA = "0x1808CBD90")]
	public bool LHNHAJKKNNC(T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x8CBB60", Offset = "0x8CAB60", VA = "0x1808CBB60")]
	public bool LHNHAJKKNNC(T MPHFKGJNMOK, int HOOANEAGKNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x8CBDB0", Offset = "0x8CADB0", VA = "0x1808CBDB0")]
	public bool MNHCGCIEOKP(T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x8CB3F0", Offset = "0x8CA3F0", VA = "0x1808CB3F0")]
	public bool DPNMENBOJNI(int HOOANEAGKNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x8CBE30", Offset = "0x8CAE30", VA = "0x1808CBE30")]
	private void NCMECPNLCLN(int HOOANEAGKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x8CB940", Offset = "0x8CA940", VA = "0x1808CB940")]
	public OMELAKCGOAG[] GPKIFPIDNBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x8CBB10", Offset = "0x8CAB10", VA = "0x1808CBB10")]
	private int HNFNEIIKKDM(int AHNBCGDLBJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x8CBF60", Offset = "0x8CAF60", VA = "0x1808CBF60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8CBF60", Offset = "0x8CAF60", VA = "0x1808CBF60", Slot = "4")]
	private IEnumerator<OMELAKCGOAG> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class HBJLICKFJIO<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly Stack<T> POMAOKDAOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly List<T> IAONPJKHHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly int HNGMFADIDIM;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public int JIFKAMGGOCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xCED520", Offset = "0xCEC520", VA = "0x180CED520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public int BBINKLLEGNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x31CA6D0", Offset = "0x31C96D0", VA = "0x1831CA6D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x35D2070", Offset = "0x35D1070", VA = "0x1835D2070")]
	public static global::HBJLICKFJIO<T> LGPDCOMIHKC(int NKJBJGFALMO = 0, int HNGMFADIDIM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x35D1C20", Offset = "0x35D0C20", VA = "0x1835D1C20")]
	public static global::HBJLICKFJIO<T> HCNLPGGLAFD(int NKJBJGFALMO = 0, int HNGMFADIDIM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x35D24B0", Offset = "0x35D14B0", VA = "0x1835D24B0")]
	public HBJLICKFJIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x35D2320", Offset = "0x35D1320", VA = "0x1835D2320")]
	public HBJLICKFJIO(int NKJBJGFALMO, int HNGMFADIDIM = int.MaxValue, bool ADCKDHJDAFH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x35D21F0", Offset = "0x35D11F0", VA = "0x1835D21F0")]
	public T MJHEFBCDFIC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x35D1F10", Offset = "0x35D0F10", VA = "0x1835D1F10")]
	public void JFHMBJGHKHM(T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x35D1A30", Offset = "0x35D0A30", VA = "0x1835D1A30")]
	private void DDPIABHMCGA(T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x35D1AF0", Offset = "0x35D0AF0", VA = "0x1835D1AF0")]
	private void DPIAOBNHBMM(T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x35D1FD0", Offset = "0x35D0FD0", VA = "0x1835D1FD0")]
	[Conditional("DEBUG_BUILD")]
	private void JKGMMNHLNHG(T MNCDJFFLIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x35D2140", Offset = "0x35D1140", VA = "0x1835D2140")]
	[Conditional("DEBUG_BUILD")]
	private void LOJEOMDGEPE(T MNCDJFFLIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x35D1B10", Offset = "0x35D0B10", VA = "0x1835D1B10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x35D1CF0", Offset = "0x35D0CF0", VA = "0x1835D1CF0")]
	private void IDGEHDPJLHN(IEnumerable<T> FLJHHGNBDOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class JCAOLIJBJIG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private Dictionary<int, T> MICECLKMJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private T EAKKGKOPNGO;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public virtual T PIMAENKOLPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x5AB360", Offset = "0x5AA360", VA = "0x1805AB360", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool HGAIKDNEBJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x3933BA0", Offset = "0x3932BA0", VA = "0x183933BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x3933CA0", Offset = "0x3932CA0", VA = "0x183933CA0")]
	public bool EMKENJFOCJF(T MPHFKGJNMOK, int MBHEGCHNPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x3933D00", Offset = "0x3932D00", VA = "0x183933D00")]
	public bool OKFFAJCGNAA(int MBHEGCHNPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x39337A0", Offset = "0x39327A0", VA = "0x1839337A0")]
	public T AJLPACBHFDJ(int PDDEBBLBPFE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x3933BE0", Offset = "0x3932BE0", VA = "0x183933BE0")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x3933A00", Offset = "0x3932A00", VA = "0x183933A00")]
	private bool ALMLKFCILGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x3933500", Offset = "0x3932500", VA = "0x183933500")]
	public bool ACEOCCKNHLM(int MBHEGCHNPDE, out T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x8C5110", Offset = "0x8C4110", VA = "0x1808C5110")]
	public JCAOLIJBJIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class NOLFCOFOKDD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	protected struct AIMGGENLJDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public T NLLJAAOBNLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int EIHHJJJMHFB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	protected readonly List<AIMGGENLJDI> CMMPHNBJIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private T KLEPABGADJC;

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1402F00", Offset = "0x1401F00", VA = "0x181402F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x37B9C30", Offset = "0x37B8C30", VA = "0x1837B9C30")]
	public bool FECGJJAPIMF(T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x37BA2B0", Offset = "0x37B92B0", VA = "0x1837BA2B0")]
	public void NENJMCKJAJO(T MPHFKGJNMOK, int MBHEGCHNPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x37BA190", Offset = "0x37B9190", VA = "0x1837BA190")]
	public bool MNHCGCIEOKP(T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x37B9BD0", Offset = "0x37B8BD0", VA = "0x1837B9BD0")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x37B9EF0", Offset = "0x37B8EF0", VA = "0x1837B9EF0")]
	public T JAGIABOOFFF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x37B9E80", Offset = "0x37B8E80", VA = "0x1837B9E80")]
	public T IMCOKFECAJL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x37B9F80", Offset = "0x37B8F80", VA = "0x1837B9F80")]
	private void JNFFAFGDLCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x37BA350", Offset = "0x37B9350", VA = "0x1837BA350")]
	public NOLFCOFOKDD()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		[DPGOFBBDGFL(BHKPCKHAKLF.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x4D57BC0", Offset = "0x4D56BC0", VA = "0x184D57BC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x4D58090", Offset = "0x4D57090", VA = "0x184D58090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x4D57EB0", Offset = "0x4D56EB0", VA = "0x184D57EB0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x4D58230", Offset = "0x4D57230", VA = "0x184D58230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x4D57A80", Offset = "0x4D56A80", VA = "0x184D57A80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x4D57F50", Offset = "0x4D56F50", VA = "0x184D57F50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x4D57D70", Offset = "0x4D56D70", VA = "0x184D57D70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x4D579E0", Offset = "0x4D569E0", VA = "0x184D579E0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface LBFEGJJCJFN
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public abstract class ResourcePrefabReference<T> : LBFEGJJCJFN where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x35F4B00", Offset = "0x35F3B00", VA = "0x1835F4B00", Slot = "4")]
		public virtual T NIGJJKMIMDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class ONEFOGDEHAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly Dictionary<byte, BCANKGNNLEN> ABOPCPNAHHA;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public BCANKGNNLEN CIPJIDIBMFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x5A81F0", Offset = "0x5A71F0", VA = "0x1805A81F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x5C5A10", Offset = "0x5C4A10", VA = "0x1805C5A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector2 CFKDGHHHKDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x1222010", Offset = "0x1221010", VA = "0x181222010")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1BBA0D0", Offset = "0x1BB90D0", VA = "0x181BBA0D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Vector2 CKIDIEPAOKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x1BDEFC0", Offset = "0x1BDDFC0", VA = "0x181BDEFC0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x25F03C0", Offset = "0x25EF3C0", VA = "0x1825F03C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector2 LEEHIAMABPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x4D57220", Offset = "0x4D56220", VA = "0x184D57220")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x4D57200", Offset = "0x4D56200", VA = "0x184D57200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int MKHGFABMIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x61AC00", Offset = "0x619C00", VA = "0x18061AC00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x640D80", Offset = "0x63FD80", VA = "0x180640D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x4D57480", Offset = "0x4D56480", VA = "0x184D57480")]
	public ONEFOGDEHAG(Bounds CDMOGCAFJND, Vector2[] PHHIOALDPMO, int DEOECBAJIEB, byte AHNBCGDLBJF, float LEJDKEPHMOP = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x4D571A0", Offset = "0x4D561A0", VA = "0x184D571A0")]
	public BCANKGNNLEN DBMIGCNEALN(byte HOOANEAGKNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x4D57370", Offset = "0x4D56370", VA = "0x184D57370")]
	public void MMCFJHLLEMF(Vector3 MMBOHLJHNFP, float IJDDGCJPOKN, float NLHEGDALIJI, ref List<byte> JCGDDOPINCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x4D57460", Offset = "0x4D56460", VA = "0x184D57460")]
	public void PCODIJLCAII(BCANKGNNLEN.IOIDGLJCNKF APJKFAJNHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x4D57240", Offset = "0x4D56240", VA = "0x184D57240")]
	private BCANKGNNLEN LAOJBKDLCNJ(byte HOOANEAGKNH, BCANKGNNLEN.CDLPJMLCJNM MKMCBPHHFNB, BCANKGNNLEN COLFLONKFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x4D56C80", Offset = "0x4D55C80", VA = "0x184D56C80")]
	private void ABCBALLFEAF(BCANKGNNLEN COLFLONKFJK, Vector2[] PHHIOALDPMO, int CKNACIINEAJ, int MEFEGPBJPPP, int KCKKHEFDDEF, int JOFIBFAADKM, float LEJDKEPHMOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class BCANKGNNLEN
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public enum CDLPJMLCJNM
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public enum IOIDGLJCNKF
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public byte INMFENJMHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public Vector3 KAMMCENCMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public Vector3 OJCJOGAFMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public Vector3 EMDJBDGNOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public Vector3 FEAIEIDFDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public CDLPJMLCJNM LFKJANJNKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public BCANKGNNLEN ANDKMGNGEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public List<BCANKGNNLEN> CFNALLDDAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public bool CEMBLDJLPPG;

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x4D53E20", Offset = "0x4D52E20", VA = "0x184D53E20")]
	public BCANKGNNLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x4D53E40", Offset = "0x4D52E40", VA = "0x184D53E40")]
	public BCANKGNNLEN(byte IAKMMHHICJO, CDLPJMLCJNM MKMCBPHHFNB, BCANKGNNLEN COLFLONKFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x4D53AF0", Offset = "0x4D52AF0", VA = "0x184D53AF0")]
	public void MLADKEOGKBF(BCANKGNNLEN JOFIFOFIAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220")]
	public void PCODIJLCAII(int HPJJLHFNLOK, IOIDGLJCNKF APJKFAJNHPG, int FIFBNMEDPDC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x4D53B90", Offset = "0x4D52B90", VA = "0x184D53B90")]
	public void MMCFJHLLEMF(List<byte> JCGDDOPINCJ, Vector3 MMBOHLJHNFP, float IJDDGCJPOKN, float NLHEGDALIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x4D53A90", Offset = "0x4D52A90", VA = "0x184D53A90")]
	public bool KIJBJCDMPOD(Vector3 ECAKKCJGNHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x4D53A50", Offset = "0x4D52A50", VA = "0x184D53A50")]
	public bool AMAOLGFKOKH(Vector3 ECAKKCJGNHD, float OLNJEBHHKNG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class NJNBENCAKHJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly Dictionary<T, object> CMPKDJNBBOL;

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0xCEBC20", Offset = "0xCEAC20", VA = "0x180CEBC20")]
	public bool MJDAEFAIDPP(T JCOBGPNLILC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x40A5210", Offset = "0x40A4210", VA = "0x1840A5210")]
	public bool MJDAEFAIDPP(T JCOBGPNLILC, object GJGFJFLAGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x40A5250", Offset = "0x40A4250", VA = "0x1840A5250")]
	public bool MJDAEFAIDPP(T JCOBGPNLILC, object GJGFJFLAGKH, out object EJDBJDEBBBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x40A50A0", Offset = "0x40A40A0", VA = "0x1840A50A0")]
	public bool CIIMNGMHMJH(T JCOBGPNLILC, object GJGFJFLAGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x40A5060", Offset = "0x40A4060", VA = "0x1840A5060")]
	public bool ADFMFJHNAFD(T JCOBGPNLILC, object GJGFJFLAGKH, out object EJDBJDEBBBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x40A50E0", Offset = "0x40A40E0", VA = "0x1840A50E0")]
	public bool CIIMNGMHMJH(T JCOBGPNLILC, object GJGFJFLAGKH, out object EJDBJDEBBBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x1403260", Offset = "0x1402260", VA = "0x181403260")]
	public void EHKKAHOPNED(T JCOBGPNLILC, object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x40A5170", Offset = "0x40A4170", VA = "0x1840A5170")]
	public void GOHIIEGJPNA(T JCOBGPNLILC, object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x40A52B0", Offset = "0x40A42B0", VA = "0x1840A52B0")]
	public NJNBENCAKHJ()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		public struct FFEJOGAEIHI<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private readonly List<Component> EJCFBHKFPEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			private readonly bool BAOMNFNBNBP;

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0xD98C50", Offset = "0xD97C50", VA = "0x180D98C50")]
			public FFEJOGAEIHI(List<Component> EJCFBHKFPEM, bool BAOMNFNBNBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x35E0D10", Offset = "0x35DFD10", VA = "0x1835E0D10")]
			public FEALKCHNHDE<T> NECPELKHGNK()
			{
				return default(FEALKCHNHDE<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x35E0D80", Offset = "0x35DFD80", VA = "0x1835E0D80", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x35E0D80", Offset = "0x35DFD80", VA = "0x1835E0D80", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public struct FEALKCHNHDE<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private readonly List<Component> EJCFBHKFPEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private readonly bool BAOMNFNBNBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			private int HOOANEAGKNH;

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public T ANMAFMODJCP
			{
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0x35E0C00", Offset = "0x35DFC00", VA = "0x1835E0C00", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000319")]
				[Cpp2IlInjected.Address(RVA = "0x35E0B90", Offset = "0x35DFB90", VA = "0x1835E0B90", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x35E0BD0", Offset = "0x35DFBD0", VA = "0x1835E0BD0")]
			public FEALKCHNHDE(List<Component> EJCFBHKFPEM, bool BAOMNFNBNBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x35E0AC0", Offset = "0x35DFAC0", VA = "0x1835E0AC0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x35E0AD0", Offset = "0x35DFAD0", VA = "0x1835E0AD0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x35E0B80", Offset = "0x35DFB80", VA = "0x1835E0B80", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x4D59EF0", Offset = "0x4D58EF0", VA = "0x184D59EF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x4D59EB0", Offset = "0x4D58EB0", VA = "0x184D59EB0")]
		public ToolHierarchyCache(GameObject KOIOFEEIFDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x4D59770", Offset = "0x4D58770", VA = "0x184D59770")]
		private void EDEIJCODOEL(GameObject KOIOFEEIFDN, bool LLLNICPNHJM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x4D596E0", Offset = "0x4D586E0", VA = "0x184D596E0")]
		public static void EDEIJCODOEL(GameObject KOIOFEEIFDN, ref ToolHierarchyCache JFHJFCDGNCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x4D59D80", Offset = "0x4D58D80", VA = "0x184D59D80")]
		public void NPNOKHMIKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x4D59690", Offset = "0x4D58690", VA = "0x184D59690")]
		public void AMKOIJCGEJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x300AA20", Offset = "0x3009A20", VA = "0x18300AA20")]
		public void HGJGLIGLJAK<T>(Action<T> BKCLKIJOKLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x4D59A10", Offset = "0x4D58A10", VA = "0x184D59A10")]
		public Component JDOMOAMFFKH(Type ONIHNDBDHGC, bool BAOMNFNBNBP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x2E465B0", Offset = "0x2E455B0", VA = "0x182E465B0")]
		public T JDOMOAMFFKH<T>(bool BAOMNFNBNBP = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x4D59910", Offset = "0x4D58910", VA = "0x184D59910")]
		public FFEJOGAEIHI<Component> GGJAALACBCP(Type ONIHNDBDHGC, bool BAOMNFNBNBP = false)
		{
			return default(FFEJOGAEIHI<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x2E9B8E0", Offset = "0x2E9A8E0", VA = "0x182E9B8E0")]
		public FFEJOGAEIHI<T> GGJAALACBCP<T>(bool BAOMNFNBNBP = false) where T : class
		{
			return default(FFEJOGAEIHI<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x4D59AD0", Offset = "0x4D58AD0", VA = "0x184D59AD0")]
		public List<Component> MLCMFLNDJNP(Type ONIHNDBDHGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x4D59890", Offset = "0x4D58890", VA = "0x184D59890", Slot = "4")]
		public bool Equals(ToolHierarchyCache KDNDPAEEMPL, ToolHierarchyCache HJCNEOFEOPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x4D599A0", Offset = "0x4D589A0", VA = "0x184D599A0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache FIEDOLNFNLH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class COIAGMHEHHF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int NKJBJGFALMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private int IANFLKDBHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private List<T> FPHBFHHHPMJ;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xCED520", Offset = "0xCEC520", VA = "0x180CED520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public T MKGHNHOEKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xCED7A0", Offset = "0xCEC7A0", VA = "0x180CED7A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public T FPJDLBJBDNC
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xCED870", Offset = "0xCEC870", VA = "0x180CED870")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public T LBPEHICGJBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xCED590", Offset = "0xCEC590", VA = "0x180CED590")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0xCEDAD0", Offset = "0xCECAD0", VA = "0x180CEDAD0")]
	public COIAGMHEHHF(int NKJBJGFALMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0xCED920", Offset = "0xCEC920", VA = "0x180CED920")]
	public void NENJMCKJAJO(T KOGMIPGMNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0xCED550", Offset = "0xCEC550", VA = "0x180CED550")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0xCED650", Offset = "0xCEC650", VA = "0x180CED650")]
	public void FMAIMKFOMEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0xCED820", Offset = "0xCEC820", VA = "0x180CED820")]
	public void KHIFOAAJIJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0xCED6F0", Offset = "0xCEC6F0", VA = "0x180CED6F0")]
	public void HFFJDMLFHOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class MLMJAAKIAGO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private bool BLNNMOJBDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Action BKCLKIJOKLP;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public static MLMJAAKIAGO JMFPIPNGGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x4D55BC0", Offset = "0x4D54BC0", VA = "0x184D55BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool EHMINPKKADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x5AA270", Offset = "0x5A9270", VA = "0x1805AA270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x803250", Offset = "0x802250", VA = "0x180803250")]
	public MLMJAAKIAGO(Action BKCLKIJOKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x4D55BA0", Offset = "0x4D54BA0", VA = "0x184D55BA0")]
	public void AKPIIOLAJBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x4D55BA0", Offset = "0x4D54BA0", VA = "0x184D55BA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class IGKJHECICFN
{
	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220")]
	public static void JBILLMHMLGH(HEFIGJJHMHM PNLOOPBPOJC, string HPJALKGHNFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class HJGIFFEDANB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private struct CIADDOLFDPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int EIHHJJJMHFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public T NLLJAAOBNLN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Dictionary<object, CIADDOLFDPM> MICECLKMJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private T EAKKGKOPNGO;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public virtual T PIMAENKOLPC
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x1222010", Offset = "0x1221010", VA = "0x181222010", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x1BBA0D0", Offset = "0x1BB90D0", VA = "0x181BBA0D0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool HGAIKDNEBJH
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C20", Offset = "0x8C3C20", VA = "0x1808C4C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public object FKOBBGAOJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x5B1950", Offset = "0x5B0950", VA = "0x1805B1950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x5B19A0", Offset = "0x5B09A0", VA = "0x1805B19A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8C4DA0", Offset = "0x8C3DA0", VA = "0x1808C4DA0")]
	public bool EMKENJFOCJF(T MPHFKGJNMOK, object GJGFJFLAGKH, int MBHEGCHNPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8C50A0", Offset = "0x8C40A0", VA = "0x1808C50A0")]
	public bool OKFFAJCGNAA(object GJGFJFLAGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x35DC340", Offset = "0x35DB340", VA = "0x1835DC340")]
	public bool ACEOCCKNHLM(object GJGFJFLAGKH, out T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C50", Offset = "0x8C3C50", VA = "0x1808C4C50")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x35DD770", Offset = "0x35DC770", VA = "0x1835DD770")]
	private bool ALMLKFCILGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x8C5110", Offset = "0x8C4110", VA = "0x1808C5110")]
	public HJGIFFEDANB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class EONHDLDCGOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private Dictionary<object, float> MICECLKMJHJ;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public float NJKOOEKKNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D20", Offset = "0x7E0D20", VA = "0x1807E1D20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x7E1DB0", Offset = "0x7E0DB0", VA = "0x1807E1DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x4D543B0", Offset = "0x4D533B0", VA = "0x184D543B0")]
	public void EMKENJFOCJF(float MPHFKGJNMOK, object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x4D54540", Offset = "0x4D53540", VA = "0x184D54540")]
	public void OKFFAJCGNAA(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x4D54420", Offset = "0x4D53420", VA = "0x184D54420")]
	private void JDCCCBOMICC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x4D545B0", Offset = "0x4D535B0", VA = "0x184D545B0")]
	public EONHDLDCGOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public sealed class HEFIGJJHMHM
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class IFCAPIFICBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly string JGILIGHGNEB;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		private IFCAPIFICBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x74E8A0", Offset = "0x74D8A0", VA = "0x18074E8A0")]
		public IFCAPIFICBH(string JGILIGHGNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x4D55520", Offset = "0x4D54520", VA = "0x184D55520", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class NDOONHPJLAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		public NDOONHPJLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x4D55C40", Offset = "0x4D54C40", VA = "0x184D55C40")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly HashSet<object> FKIBCGKGOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int LBGFCBBILNL;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool NJODEIMNIEL
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x4D54A90", Offset = "0x4D53A90", VA = "0x184D54A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x5AA180", Offset = "0x5A9180", VA = "0x1805AA180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x4D54B20", Offset = "0x4D53B20", VA = "0x184D54B20")]
	public bool NENJMCKJAJO(object GJGFJFLAGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x4D54AA0", Offset = "0x4D53AA0", VA = "0x184D54AA0")]
	public bool MNHCGCIEOKP(object GJGFJFLAGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x4D54A30", Offset = "0x4D53A30", VA = "0x184D54A30")]
	public bool FECGJJAPIMF(object GJGFJFLAGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x4D549D0", Offset = "0x4D539D0", VA = "0x184D549D0")]
	public void FBHHBBMPJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x4D54BA0", Offset = "0x4D53BA0", VA = "0x184D54BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x4D54D10", Offset = "0x4D53D10", VA = "0x184D54D10")]
	public HEFIGJJHMHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class AJNMEGICPOE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private struct FAMGGHBKBCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public float FMGIAHDPMAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public T NLLJAAOBNLN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private Dictionary<object, FAMGGHBKBCC> MICECLKMJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private T KMOMAPPGMGM;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public virtual T AGELLDHNNKD
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x81CB30", Offset = "0x81BB30", VA = "0x18081CB30", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x25233F0", Offset = "0x25223F0", VA = "0x1825233F0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public object KJJMJHDDCIH
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x5CB390", Offset = "0x5CA390", VA = "0x1805CB390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x6A05C0", Offset = "0x69F5C0", VA = "0x1806A05C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool HGAIKDNEBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x35F76A0", Offset = "0x35F66A0", VA = "0x1835F76A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x35F77D0", Offset = "0x35F67D0", VA = "0x1835F77D0")]
	public bool EMKENJFOCJF(T MPHFKGJNMOK, object GJGFJFLAGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x35F7CB0", Offset = "0x35F6CB0", VA = "0x1835F7CB0")]
	public bool OKFFAJCGNAA(object GJGFJFLAGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C50", Offset = "0x8C3C50", VA = "0x1808C4C50")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x35F5BC0", Offset = "0x35F4BC0", VA = "0x1835F5BC0")]
	public bool ACEOCCKNHLM(object GJGFJFLAGKH, out T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x35F6BF0", Offset = "0x35F5BF0", VA = "0x1835F6BF0")]
	private bool ALMLKFCILGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x35F7D10", Offset = "0x35F6D10", VA = "0x1835F7D10")]
	public AJNMEGICPOE()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class HGPPKMCDCLL
{
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static byte[] PIDGMPFPDGI;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static int CONMIAOECKG;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static int PDHBFKNINGO;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static BigInteger EDLLKHJPMCN;

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	public HGPPKMCDCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x4D54D80", Offset = "0x4D53D80", VA = "0x184D54D80")]
	private static string CKGLFMJKOPM(byte[] IIFMPDAMAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x4D54E80", Offset = "0x4D53E80", VA = "0x184D54E80")]
	public static string IOHOBOIOFIG(byte[] KFCJKMJDFKE, bool OLNJLDMOIJP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
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
