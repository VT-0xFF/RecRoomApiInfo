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
	[Cpp2IlInjected.Address(RVA = "0x6CE000", Offset = "0x6CC600", VA = "0x1806CE000")]
	public NHOMBGOPFCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4DDFF40", Offset = "0x4DDE540", VA = "0x184DDFF40")]
	public byte[] LOAGLBKBCPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void GFFDDNLEGBP(IncrementalHash NPNGOLKAOFF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xC6C390", Offset = "0xC6A990", VA = "0x180C6C390")]
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
		[Cpp2IlInjected.Address(RVA = "0x4DE3CC0", Offset = "0x4DE22C0", VA = "0x184DE3CC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4DE3C80", Offset = "0x4DE2280", VA = "0x184DE3C80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4DE3D00", Offset = "0x4DE2300", VA = "0x184DE3D00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4DE3F10", Offset = "0x4DE2510", VA = "0x184DE3F10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4DE3E80", Offset = "0x4DE2480", VA = "0x184DE3E80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD8B0A0", Offset = "0xD896A0", VA = "0x180D8B0A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDA7BB0", Offset = "0xDA61B0", VA = "0x180DA7BB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4DE3C40", Offset = "0x4DE2240", VA = "0x184DE3C40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4DE3DF0", Offset = "0x4DE23F0", VA = "0x184DE3DF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3670", Offset = "0x4DE1C70", VA = "0x184DE3670")]
	public void CopyBounds(SavedExtents GJPJDOANCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3BB0", Offset = "0x4DE21B0", VA = "0x184DE3BB0")]
	public void SetLocalSpaceBounds(Bounds IIDEHGPDOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x83FCE0", Offset = "0x83E2E0", VA = "0x18083FCE0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3BA0", Offset = "0x4DE21A0", VA = "0x184DE3BA0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4DE36A0", Offset = "0x4DE1CA0", VA = "0x184DE36A0")]
	private void EBCLMHLPNCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3970", Offset = "0x4DE1F70", VA = "0x184DE3970")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4DE30B0", Offset = "0x4DE16B0", VA = "0x184DE30B0")]
	public static void CalculateLocalBoundsFor(GameObject NIKGFIPEJKD, out Bounds IIDEHGPDOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4DE38B0", Offset = "0x4DE1EB0", VA = "0x184DE38B0")]
	private static void IBEFMMFPCMP(Bounds IIFMPDAMAIA, Color AHENHIDOBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3BD0", Offset = "0x4DE21D0", VA = "0x184DE3BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x560EE0", Offset = "0x55F4E0", VA = "0x180560EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5604A0", Offset = "0x55EAA0", VA = "0x1805604A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "4")]
	public virtual void NJMINPBMPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
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
	[Cpp2IlInjected.Address(RVA = "0x2964720", Offset = "0x2962D20", VA = "0x182964720", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2964260", Offset = "0x2962860", VA = "0x182964260", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2964D20", Offset = "0x2963320", VA = "0x182964D20")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		public NJHHCIMPFMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x38D22A0", Offset = "0x38D08A0", VA = "0x1838D22A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x38CFB70", Offset = "0x38CE170", VA = "0x1838CFB70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x38CFBA0", Offset = "0x38CE1A0", VA = "0x1838CFBA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x38CFAC0", Offset = "0x38CE0C0", VA = "0x1838CFAC0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey MKDJIBNCKNC]
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x38CFAF0", Offset = "0x38CE0F0", VA = "0x1838CFAF0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x38CF9C0", Offset = "0x38CDFC0", VA = "0x1838CF9C0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x38CF220", Offset = "0x38CD820", VA = "0x1838CF220", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x38CEB90", Offset = "0x38CD190", VA = "0x1838CEB90", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x38CE7C0", Offset = "0x38CCDC0", VA = "0x1838CE7C0", Slot = "14")]
	protected virtual string KNFGDOONBGC(TKeyVal HBGCCCMAKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x30A6ED0", Offset = "0x30A54D0", VA = "0x1830A6ED0", Slot = "4")]
	public bool ContainsKey(TKey MKDJIBNCKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x38CF8B0", Offset = "0x38CDEB0", VA = "0x1838CF8B0", Slot = "5")]
	public bool TryGetValue(TKey MKDJIBNCKNC, out TVal MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x38CE700", Offset = "0x38CCD00", VA = "0x1838CE700", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x38CE700", Offset = "0x38CCD00", VA = "0x1838CE700", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x38CF8E0", Offset = "0x38CDEE0", VA = "0x1838CF8E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		public HCKLBOCHLBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2C77420", Offset = "0x2C75A20", VA = "0x182C77420")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C72AC0", Offset = "0x2C710C0", VA = "0x182C72AC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2C72B40", Offset = "0x2C71140", VA = "0x182C72B40")]
	public FIOODBKGPEL(float JKNDPNGCEKN, float AHPPANIAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2C726C0", Offset = "0x2C70CC0", VA = "0x182C726C0")]
	public bool HDIDHMKDGPJ(float BNLHHMHBFBE, T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2C72630", Offset = "0x2C70C30", VA = "0x182C72630")]
	public int BLGPLPDGLHC(float BNLHHMHBFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2C722F0", Offset = "0x2C708F0", VA = "0x182C722F0")]
	public IEnumerable<T> AIPMNLEMDLF(float BNLHHMHBFBE, [Optional] float? FCHAFMHONED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2C72690", Offset = "0x2C70C90", VA = "0x182C72690")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2C72980", Offset = "0x2C70F80", VA = "0x182C72980")]
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
		[Cpp2IlInjected.Address(RVA = "0xFA2230", Offset = "0xFA0830", VA = "0x180FA2230")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xFA2260", Offset = "0xFA0860", VA = "0x180FA2260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1320", Offset = "0x1EBF920", VA = "0x181EC1320")]
	public EBEDLPGCCAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1350", Offset = "0x1EBF950", VA = "0x181EC1350")]
	public EBEDLPGCCAP(int KMCJMFPOINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1EC0E00", Offset = "0x1EBF400", VA = "0x181EC0E00")]
	public void NENJMCKJAJO(float BNLHHMHBFBE, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1EBFDF0", Offset = "0x1EBE3F0", VA = "0x181EBFDF0")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1EC01E0", Offset = "0x1EBE7E0", VA = "0x181EC01E0")]
	public bool EFEIJPNCBAL(float FDAHJLCPCMG, float FCDDNKPOGKC, out T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1EC0A80", Offset = "0x1EBF080", VA = "0x181EC0A80")]
	public bool JHOFCOMOONE(float FDAHJLCPCMG, float FCDDNKPOGKC, out T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1180", Offset = "0x1EBF780", VA = "0x181EC1180")]
	public void NKIEEBKGPLK(float FDAHJLCPCMG, float FCDDNKPOGKC, List<T> HKAAJCFANGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1EC0C30", Offset = "0x1EBF230", VA = "0x181EC0C30")]
	private int NDGIPCKGGOO(int LNHAEDKIBGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1EC0BF0", Offset = "0x1EBF1F0", VA = "0x181EC0BF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4DE0310", Offset = "0x4DDE910", VA = "0x184DE0310", Slot = "4")]
	protected override Vector3 DPMLJDDJBJO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0430", Offset = "0x4DDEA30", VA = "0x184DE0430", Slot = "5")]
	protected override Vector3 LIJNAOMAFOB(Vector3 NNKIPLHOMAE, Vector3 JDKIOCBBPAN, float JDLAIFIMIJD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0270", Offset = "0x4DDE870", VA = "0x184DE0270", Slot = "6")]
	protected override Vector3 BLIELPCGJDN(Vector3 MPHFKGJNMOK, float JDLAIFIMIJD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0380", Offset = "0x4DDE980", VA = "0x184DE0380", Slot = "7")]
	protected override Vector3 KLKAMBMGDLE(Vector3 NNKIPLHOMAE, Vector3 JDKIOCBBPAN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4DE04F0", Offset = "0x4DDEAF0", VA = "0x184DE04F0", Slot = "8")]
	protected override Vector3 LNFJFBLJGGL(Vector3 NNKIPLHOMAE, Vector3 JDKIOCBBPAN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0560", Offset = "0x4DDEB60", VA = "0x184DE0560")]
	public LJGCFHMJDDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AAADGANKBMP : global::EBEDLPGCCAP<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDDD0", Offset = "0x4DDC3D0", VA = "0x184DDDDD0")]
	public AAADGANKBMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDD60", Offset = "0x4DDC360", VA = "0x184DDDD60")]
	public AAADGANKBMP(int KMCJMFPOINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xDB6200", Offset = "0xDB4800", VA = "0x180DB6200", Slot = "4")]
	protected override float DPMLJDDJBJO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDCD0", Offset = "0x4DDC2D0", VA = "0x184DDDCD0", Slot = "5")]
	protected override float LIJNAOMAFOB(float NNKIPLHOMAE, float JDKIOCBBPAN, float JDLAIFIMIJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3ED7710", Offset = "0x3ED5D10", VA = "0x183ED7710", Slot = "6")]
	protected override float BLIELPCGJDN(float MPHFKGJNMOK, float JDLAIFIMIJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x25B7D60", Offset = "0x25B6360", VA = "0x1825B7D60", Slot = "7")]
	protected override float KLKAMBMGDLE(float NNKIPLHOMAE, float JDKIOCBBPAN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDD50", Offset = "0x4DDC350", VA = "0x184DDDD50", Slot = "8")]
	protected override float LNFJFBLJGGL(float NNKIPLHOMAE, float JDKIOCBBPAN)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DFJGABGBPPI
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1A8E8A0", Offset = "0x1A8CEA0", VA = "0x181A8E8A0")]
	public static global::CECEKFMKBAH<T1> GPCBEJLMGEM<T1>(T1 LIMDOAJDHOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1D90610", Offset = "0x1D8EC10", VA = "0x181D90610")]
	public static global::JHJGCPBBALP<T1, T2> GPCBEJLMGEM<T1, T2>(T1 LIMDOAJDHOL, T2 FCIBOALGCOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x258A6B0", Offset = "0x2588CB0", VA = "0x18258A6B0")]
	public static global::ECEIKOHDBEL<T1, T2, T3> GPCBEJLMGEM<T1, T2, T3>(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1D9EF50", Offset = "0x1D9D550", VA = "0x181D9EF50")]
	public static global::GKKKNGCMPIB<T1, T2, T3, T4> GPCBEJLMGEM<T1, T2, T3, T4>(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ, T4 DKLDFMCMENI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1D90680", Offset = "0x1D8EC80", VA = "0x181D90680")]
	public static global::OMCHOBOBKLI<T1, T2, T3, T4, T5> GPCBEJLMGEM<T1, T2, T3, T4, T5>(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ, T4 DKLDFMCMENI, T5 AIPJCDDJENB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x254D470", Offset = "0x254BA70", VA = "0x18254D470")]
	public static global::BDKJBMEECAA<T1, T2, T3, T4, T5, T6> GPCBEJLMGEM<T1, T2, T3, T4, T5, T6>(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ, T4 DKLDFMCMENI, T5 AIPJCDDJENB, T6 DBKNGGEPDEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1C1BF50", Offset = "0x1C1A550", VA = "0x181C1BF50")]
	public static global::CHOFLPMMMHF<T1, T2, T3, T4, T5, T6, T7> GPCBEJLMGEM<T1, T2, T3, T4, T5, T6, T7>(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ, T4 DKLDFMCMENI, T5 AIPJCDDJENB, T6 DBKNGGEPDEO, T7 DCCMAJMIBEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x258A740", Offset = "0x2588D40", VA = "0x18258A740")]
	public static global::GGPKMGOAGII<T1, T2, T3, T4, T5, T6, T7, T8> GPCBEJLMGEM<T1, T2, T3, T4, T5, T6, T7, T8>(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ, T4 DKLDFMCMENI, T5 AIPJCDDJENB, T6 DBKNGGEPDEO, T7 DCCMAJMIBEJ, T8 DNBBFCFAAFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x18CB870", Offset = "0x18C9E70", VA = "0x1818CB870")]
	[IteratorStateMachine(typeof(ADOCDALCLGP))]
	public static IEnumerable<global::JHJGCPBBALP<T1, T2>> NGBENFEAAIJ<T1, T2>(IEnumerable<T1> NCGEKBENJBA, IEnumerable<T2> IIFMPDAMAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1A96250", Offset = "0x1A94850", VA = "0x181A96250")]
	[IteratorStateMachine(typeof(BLAAFPBCEIG))]
	public static IEnumerable<global::ECEIKOHDBEL<T1, T2, T3>> NGBENFEAAIJ<T1, T2, T3>(IEnumerable<T1> NCGEKBENJBA, IEnumerable<T2> IIFMPDAMAIA, IEnumerable<T3> AHENHIDOBEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x24D1A50", Offset = "0x24D0050", VA = "0x1824D1A50")]
	internal static int LDEBBOPDIAC(int FAKCNNJKKOE, int BDOCKLFDBKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3B6B260", Offset = "0x3B69860", VA = "0x183B6B260")]
	internal static int LDEBBOPDIAC(int FAKCNNJKKOE, int BDOCKLFDBKD, int HNLGIDJODIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3B6B270", Offset = "0x3B69870", VA = "0x183B6B270")]
	internal static int LDEBBOPDIAC(int FAKCNNJKKOE, int BDOCKLFDBKD, int HNLGIDJODIB, int DHIJKHCMMCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4DDEA50", Offset = "0x4DDD050", VA = "0x184DDEA50")]
	internal static int LDEBBOPDIAC(int FAKCNNJKKOE, int BDOCKLFDBKD, int HNLGIDJODIB, int DHIJKHCMMCL, int HDNILMNNHKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4DDEAD0", Offset = "0x4DDD0D0", VA = "0x184DDEAD0")]
	internal static int LDEBBOPDIAC(int FAKCNNJKKOE, int BDOCKLFDBKD, int HNLGIDJODIB, int DHIJKHCMMCL, int HDNILMNNHKG, int BFOKIIHDMBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4DDEA70", Offset = "0x4DDD070", VA = "0x184DDEA70")]
	internal static int LDEBBOPDIAC(int FAKCNNJKKOE, int BDOCKLFDBKD, int HNLGIDJODIB, int DHIJKHCMMCL, int HDNILMNNHKG, int BFOKIIHDMBD, int MPGPMONCLMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4DDEAA0", Offset = "0x4DDD0A0", VA = "0x184DDEAA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x20B8150", Offset = "0x20B6750", VA = "0x1820B8150")]
	public CECEKFMKBAH(T1 LIMDOAJDHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x23D1680", Offset = "0x23CFC80", VA = "0x1823D1680", Slot = "4")]
	public int CompareTo(global::CECEKFMKBAH<T1> GJPJDOANCNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x23D16F0", Offset = "0x23CFCF0", VA = "0x1823D16F0", Slot = "0")]
	public override bool Equals(object GJPJDOANCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8327A0", Offset = "0x830DA0", VA = "0x1808327A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x23D1790", Offset = "0x23CFD90", VA = "0x1823D1790", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BFDB40", Offset = "0x2BFC140", VA = "0x182BFDB40")]
	public JHJGCPBBALP(T1 LIMDOAJDHOL, T2 FCIBOALGCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2BFC0B0", Offset = "0x2BFA6B0", VA = "0x182BFC0B0", Slot = "4")]
	public int CompareTo(global::JHJGCPBBALP<T1, T2> GJPJDOANCNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2BFCB00", Offset = "0x2BFB100", VA = "0x182BFCB00", Slot = "0")]
	public override bool Equals(object GJPJDOANCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2BFCD00", Offset = "0x2BFB300", VA = "0x182BFCD00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2BFD4B0", Offset = "0x2BFBAB0", VA = "0x182BFD4B0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1EC8480", Offset = "0x1EC6A80", VA = "0x181EC8480")]
	public ECEIKOHDBEL(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1EC7DA0", Offset = "0x1EC63A0", VA = "0x181EC7DA0", Slot = "4")]
	public int CompareTo(global::ECEIKOHDBEL<T1, T2, T3> GJPJDOANCNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1EC7F90", Offset = "0x1EC6590", VA = "0x181EC7F90", Slot = "0")]
	public override bool Equals(object GJPJDOANCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1EC8100", Offset = "0x1EC6700", VA = "0x181EC8100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1EC82F0", Offset = "0x1EC68F0", VA = "0x181EC82F0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x20B6E10", Offset = "0x20B5410", VA = "0x1820B6E10")]
	public GKKKNGCMPIB(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ, T4 DKLDFMCMENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x31D2DE0", Offset = "0x31D13E0", VA = "0x1831D2DE0", Slot = "4")]
	public int CompareTo(global::GKKKNGCMPIB<T1, T2, T3, T4> GJPJDOANCNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x31D2F20", Offset = "0x31D1520", VA = "0x1831D2F20", Slot = "0")]
	public override bool Equals(object GJPJDOANCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x31D3040", Offset = "0x31D1640", VA = "0x1831D3040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x31D3100", Offset = "0x31D1700", VA = "0x1831D3100", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A08140", Offset = "0x3A06740", VA = "0x183A08140")]
	public OMCHOBOBKLI(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ, T4 DKLDFMCMENI, T5 AIPJCDDJENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3A07C50", Offset = "0x3A06250", VA = "0x183A07C50", Slot = "4")]
	public int CompareTo(global::OMCHOBOBKLI<T1, T2, T3, T4, T5> GJPJDOANCNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3A07DD0", Offset = "0x3A063D0", VA = "0x183A07DD0", Slot = "0")]
	public override bool Equals(object GJPJDOANCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3A07F10", Offset = "0x3A06510", VA = "0x183A07F10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3A08010", Offset = "0x3A06610", VA = "0x183A08010", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x2695E70", Offset = "0x2694470", VA = "0x182695E70")]
	public BDKJBMEECAA(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ, T4 DKLDFMCMENI, T5 AIPJCDDJENB, T6 DBKNGGEPDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x26958D0", Offset = "0x2693ED0", VA = "0x1826958D0", Slot = "4")]
	public int CompareTo(global::BDKJBMEECAA<T1, T2, T3, T4, T5, T6> GJPJDOANCNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2695A90", Offset = "0x2694090", VA = "0x182695A90", Slot = "0")]
	public override bool Equals(object GJPJDOANCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2695C00", Offset = "0x2694200", VA = "0x182695C00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2695D20", Offset = "0x2694320", VA = "0x182695D20", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x23D3480", Offset = "0x23D1A80", VA = "0x1823D3480")]
	public CHOFLPMMMHF(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ, T4 DKLDFMCMENI, T5 AIPJCDDJENB, T6 DBKNGGEPDEO, T7 DCCMAJMIBEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x23D2E20", Offset = "0x23D1420", VA = "0x1823D2E20", Slot = "4")]
	public int CompareTo(global::CHOFLPMMMHF<T1, T2, T3, T4, T5, T6, T7> GJPJDOANCNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x23D3020", Offset = "0x23D1620", VA = "0x1823D3020", Slot = "0")]
	public override bool Equals(object GJPJDOANCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x23D31C0", Offset = "0x23D17C0", VA = "0x1823D31C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x23D3310", Offset = "0x23D1910", VA = "0x1823D3310", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x32D4BA0", Offset = "0x32D31A0", VA = "0x1832D4BA0")]
	public GGPKMGOAGII(T1 LIMDOAJDHOL, T2 FCIBOALGCOG, T3 LGCNPIENKHJ, T4 DKLDFMCMENI, T5 AIPJCDDJENB, T6 DBKNGGEPDEO, T7 DCCMAJMIBEJ, T8 DNBBFCFAAFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x32D4490", Offset = "0x32D2A90", VA = "0x1832D4490", Slot = "4")]
	public int CompareTo(global::GGPKMGOAGII<T1, T2, T3, T4, T5, T6, T7, T8> GJPJDOANCNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x32D46E0", Offset = "0x32D2CE0", VA = "0x1832D46E0", Slot = "0")]
	public override bool Equals(object GJPJDOANCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x32D48A0", Offset = "0x32D2EA0", VA = "0x1832D48A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x32D4A10", Offset = "0x32D3010", VA = "0x1832D4A10", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x588A30", Offset = "0x587030", VA = "0x180588A30")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6818D0", Offset = "0x67FED0", VA = "0x1806818D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float CIDGMEGAIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xDA7BA0", Offset = "0xDA61A0", VA = "0x180DA7BA0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x37682F0", Offset = "0x37668F0", VA = "0x1837682F0")]
	public T GADHBBEMMJI(float JDLAIFIMIJD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3768450", Offset = "0x3766A50", VA = "0x183768450")]
	public T GCAAOKIAELE(float JDLAIFIMIJD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LIJNAOMAFOB(T NNKIPLHOMAE, T JDKIOCBBPAN, float JDLAIFIMIJD);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4DDF250", Offset = "0x4DDD850", VA = "0x184DDF250", Slot = "4")]
	protected override float LIJNAOMAFOB(float NNKIPLHOMAE, float JDKIOCBBPAN, float JDLAIFIMIJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4DDF2D0", Offset = "0x4DDD8D0", VA = "0x184DDF2D0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4DE4E70", Offset = "0x4DE3470", VA = "0x184DE4E70", Slot = "4")]
	protected override Vector3 LIJNAOMAFOB(Vector3 NNKIPLHOMAE, Vector3 JDKIOCBBPAN, float JDLAIFIMIJD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4DE4F30", Offset = "0x4DE3530", VA = "0x184DE4F30")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4DDE9C0", Offset = "0x4DDCFC0", VA = "0x184DDE9C0", Slot = "4")]
	protected override Color LIJNAOMAFOB(Color NNKIPLHOMAE, Color JDKIOCBBPAN, float JDLAIFIMIJD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4DDEA10", Offset = "0x4DDD010", VA = "0x184DDEA10")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DMKHBNGJDKN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly IDisposable NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public DMKHBNGJDKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DefaultMember("Item")]
public sealed class PFMKJMCKNDM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly BIJHJKPHMII LEOFFENECGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private T[] EOCLDHKCFCG;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x560CD0", Offset = "0x55F2D0", VA = "0x180560CD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5E1A10", Offset = "0x5E0010", VA = "0x1805E1A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x39A2500", Offset = "0x39A0B00", VA = "0x1839A2500")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x39A1B60", Offset = "0x39A0160", VA = "0x1839A1B60")]
	public static global::PFMKJMCKNDM<T> CIAOGEOFBKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x39A1A20", Offset = "0x39A0020", VA = "0x1839A1A20")]
	public static global::PFMKJMCKNDM<T> BILDOHHICAG(int NKJBJGFALMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x39A3410", Offset = "0x39A1A10", VA = "0x1839A3410")]
	private PFMKJMCKNDM(T[] BJJEPAFIFKG, int NKJBJGFALMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x39A1EB0", Offset = "0x39A04B0", VA = "0x1839A1EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x39A2100", Offset = "0x39A0700", VA = "0x1839A2100")]
	public void NENJMCKJAJO(in T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x39A1E10", Offset = "0x39A0410", VA = "0x1839A1E10")]
	public void DPNMENBOJNI(int HOOANEAGKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x39A2780", Offset = "0x39A0D80", VA = "0x1839A2780")]
	public void PIAMKOCKCLL(int KMCJMFPOINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x39A1C90", Offset = "0x39A0290", VA = "0x1839A1C90")]
	private void DKIJAJMBPMB(int NKJBJGFALMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class LBOLPINMHBA
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1D9B450", Offset = "0x1D99A50", VA = "0x181D9B450")]
	public static global::PFMKJMCKNDM<T> CIAOGEOFBKG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x170D310", Offset = "0x170B910", VA = "0x18170D310")]
	public static global::PFMKJMCKNDM<T> BILDOHHICAG<T>(int NKJBJGFALMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct BAHKBGKEHEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<CBIFGBDDJND>> FPPCMBNHJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int FGJGAEICBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private int KLEELIOKMFH;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x919440", Offset = "0x917A40", VA = "0x180919440")]
	private BAHKBGKEHEL(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<CBIFGBDDJND>> LAGLGCKDHGD, int DFBNFBBEACO, int MJHHNBMJNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDE90", Offset = "0x4DDC490", VA = "0x184DDDE90")]
	public static BAHKBGKEHEL CIAOGEOFBKG()
	{
		return default(BAHKBGKEHEL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDF10", Offset = "0x4DDC510", VA = "0x184DDDF10")]
	public (int, int, Task) MBJCFOHDDIA(int PLFEGFLMJIJ)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4DDE180", Offset = "0x4DDC780", VA = "0x184DDE180")]
	public void MOIJNOFJGED(int PLFEGFLMJIJ, int MJHHNBMJNKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class EHMJGPNKKDD<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<TKey, TVal> POKFIONPBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TVal, TKey> LJCENICLIEH;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1E33150", Offset = "0x1E31750", VA = "0x181E33150", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool GCLNONOIJMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x560EC0", Offset = "0x55F4C0", VA = "0x180560EC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICollection<TKey> GCFCKHBGHHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1EBAFF0", Offset = "0x1EB95F0", VA = "0x181EBAFF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TVal> JBFKKFMHIKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2881E80", Offset = "0x2880480", VA = "0x182881E80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TVal NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x22A9280", Offset = "0x22A7880", VA = "0x1822A9280", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2695770", Offset = "0x2693D70", VA = "0x182695770", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TKey NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x39304B0", Offset = "0x392EAB0", VA = "0x1839304B0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x392FB10", Offset = "0x392E110", VA = "0x18392FB10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x392FB90", Offset = "0x392E190", VA = "0x18392FB90", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3930560", Offset = "0x392EB60", VA = "0x183930560", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x38E7B90", Offset = "0x38E6190", VA = "0x1838E7B90", Slot = "9")]
	public void Add(TKey MKDJIBNCKNC, TVal MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x392FAE0", Offset = "0x392E0E0", VA = "0x18392FAE0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> JAKHJIEAJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x22A7B20", Offset = "0x22A6120", VA = "0x1822A7B20", Slot = "8")]
	public bool ContainsKey(TKey MKDJIBNCKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x30AAB60", Offset = "0x30A9160", VA = "0x1830AAB60", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> JAKHJIEAJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B3B0", Offset = "0x2F399B0", VA = "0x182F3B3B0", Slot = "10")]
	public bool Remove(TKey MKDJIBNCKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B3B0", Offset = "0x2F399B0", VA = "0x182F3B3B0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> JAKHJIEAJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x287EA30", Offset = "0x287D030", VA = "0x18287EA30", Slot = "11")]
	public bool TryGetValue(TKey MKDJIBNCKNC, out TVal MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x392FED0", Offset = "0x392E4D0", VA = "0x18392FED0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x392FC20", Offset = "0x392E220", VA = "0x18392FC20", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] BEGPAFGBCJM, int KHBOJEFOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x39303D0", Offset = "0x392E9D0", VA = "0x1839303D0")]
	public void NENJMCKJAJO(TVal GBDFHGIMHBD, TKey MKDJIBNCKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3930410", Offset = "0x392EA10", VA = "0x183930410")]
	public void NENJMCKJAJO(KeyValuePair<TVal, TKey> JAKHJIEAJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3930480", Offset = "0x392EA80", VA = "0x183930480")]
	public bool NHEDMKBNPEE(TVal MKDJIBNCKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2C6E900", Offset = "0x2C6CF00", VA = "0x182C6E900")]
	public bool FECGJJAPIMF(KeyValuePair<TVal, TKey> JAKHJIEAJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2695660", Offset = "0x2693C60", VA = "0x182695660")]
	public bool MNHCGCIEOKP(TVal MKDJIBNCKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2695660", Offset = "0x2693C60", VA = "0x182695660")]
	public bool MNHCGCIEOKP(KeyValuePair<TVal, TKey> JAKHJIEAJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x392FA80", Offset = "0x392E080", VA = "0x18392FA80")]
	public bool ACEOCCKNHLM(TVal MKDJIBNCKNC, out TKey MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x392FC80", Offset = "0x392E280", VA = "0x18392FC80")]
	public IEnumerator<KeyValuePair<TVal, TKey>> FAIIIGOOGAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x392FD90", Offset = "0x392E390", VA = "0x18392FD90")]
	private void FAPOMAJEKNH(TKey MKDJIBNCKNC, TVal GBDFHGIMHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x392FF50", Offset = "0x392E550", VA = "0x18392FF50")]
	private void JCCLPNAMJMP(TKey MKDJIBNCKNC, TVal GBDFHGIMHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3930090", Offset = "0x392E690", VA = "0x183930090")]
	private bool NCMECPNLCLN(TKey MKDJIBNCKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3930210", Offset = "0x392E810", VA = "0x183930210")]
	private bool NCMECPNLCLN(TVal GBDFHGIMHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x39305B0", Offset = "0x392EBB0", VA = "0x1839305B0")]
	public EHMJGPNKKDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class BLOKKMGOFOK<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private global::BLOKKMGOFOK<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xFA2230", Offset = "0xFA0830", VA = "0x180FA2230", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2FDBE10", Offset = "0x2FDA410", VA = "0x182FDBE10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2FDC080", Offset = "0x2FDA680", VA = "0x182FDC080")]
		public Enumerator(global::BLOKKMGOFOK<T> HKAAJCFANGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2FDB900", Offset = "0x2FD9F00", VA = "0x182FDB900", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2FDBA80", Offset = "0x2FDA080", VA = "0x182FDBA80", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2FDB4D0", Offset = "0x2FD9AD0", VA = "0x182FDB4D0")]
		private void IKBLPICIHLO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private T[] CMMPHNBJIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private int AHNBCGDLBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int LLFJHOJDMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int MNOJMAIICKJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2FD1A10", Offset = "0x2FD0010", VA = "0x182FD1A10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public T NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2FD3770", Offset = "0x2FD1D70", VA = "0x182FD3770")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2FD1B40", Offset = "0x2FD0140", VA = "0x182FD1B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2FD3A60", Offset = "0x2FD2060", VA = "0x182FD3A60")]
	public BLOKKMGOFOK(int NKJBJGFALMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2FD3630", Offset = "0x2FD1C30", VA = "0x182FD3630")]
	public void NENJMCKJAJO(T JDLAIFIMIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2FD2280", Offset = "0x2FD0880", VA = "0x182FD2280")]
	public void CPDHKEOOMID(IEnumerable<T> PDBKEOJNNAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2FD1C40", Offset = "0x2FD0240", VA = "0x182FD1C40")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2FD3210", Offset = "0x2FD1810", VA = "0x182FD3210")]
	public void MHBEHKDDJFA(int DHNBJNKGAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2FD3180", Offset = "0x2FD1780", VA = "0x182FD3180")]
	public void HJFBFMIDPLL(int DHNBJNKGAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2FD3030", Offset = "0x2FD1630", VA = "0x182FD3030")]
	public void EJHGKGPLOIF(T[] BEGPAFGBCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2FD3310", Offset = "0x2FD1910", VA = "0x182FD3310")]
	public Enumerator NECPELKHGNK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2FD3870", Offset = "0x2FD1E70", VA = "0x182FD3870", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2FD3870", Offset = "0x2FD1E70", VA = "0x182FD3870", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2FD2970", Offset = "0x2FD0F70", VA = "0x182FD2970")]
	private int DJKGBPCMOCG(int HOOANEAGKNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2FD19E0", Offset = "0x2FCFFE0", VA = "0x182FD19E0")]
	private int AJBCJHLPPIH(int HOOANEAGKNH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct LKFGLOLIKNN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly IDisposable[] EOCLDHKCFCG;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6AAD90", Offset = "0x6A9390", VA = "0x1806AAD90")]
	public LKFGLOLIKNN(params IDisposable[] BJJEPAFIFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0xCC49D0", Offset = "0xCC2FD0", VA = "0x180CC49D0")]
	public static LKFGLOLIKNN CIAOGEOFBKG(params IDisposable[] BJJEPAFIFKG)
	{
		return default(LKFGLOLIKNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4DE05C0", Offset = "0x4DDEBC0", VA = "0x184DE05C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct PFDBHDCAEPE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly IDisposable DMLBJFANNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public T NLLJAAOBNLN;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2696D40", Offset = "0x2695340", VA = "0x182696D40")]
	public PFDBHDCAEPE(IDisposable OGIOFICPCOK, in T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x1DA0F70", Offset = "0x1D9F570", VA = "0x181DA0F70")]
	public static global::PFDBHDCAEPE<U> FJPODPPLCMM<U>(in global::PFDBHDCAEPE<T> OGIOFICPCOK, in U MPHFKGJNMOK)
	{
		return default(global::PFDBHDCAEPE<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1C1F3F0", Offset = "0x1C1D9F0", VA = "0x181C1F3F0")]
	public global::PFDBHDCAEPE<U> OFEOLDNDPJN<U>(in U MPHFKGJNMOK)
	{
		return default(global::PFDBHDCAEPE<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x1DA0FB0", Offset = "0x1D9F5B0", VA = "0x181DA0FB0")]
	public static global::PFDBHDCAEPE<(T, U)> LPIKICKGJBP<U>(in global::PFDBHDCAEPE<T> NCGEKBENJBA, in global::PFDBHDCAEPE<U> IIFMPDAMAIA)
	{
		return default(global::PFDBHDCAEPE<(T, U)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x399F730", Offset = "0x399DD30", VA = "0x18399F730", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class KNCOMNPAJKP
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1D9B2C0", Offset = "0x1D998C0", VA = "0x181D9B2C0")]
	public static global::PFDBHDCAEPE<T> CIAOGEOFBKG<T>(IDisposable OGIOFICPCOK, in T MPHFKGJNMOK)
	{
		return default(global::PFDBHDCAEPE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1C1F3F0", Offset = "0x1C1D9F0", VA = "0x181C1F3F0")]
	public static global::PFDBHDCAEPE<U> FJPODPPLCMM<U, T>(in global::PFDBHDCAEPE<T> EDEAKAPKGCH, in U MPHFKGJNMOK)
	{
		return default(global::PFDBHDCAEPE<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1C1F3B0", Offset = "0x1C1D9B0", VA = "0x181C1F3B0")]
	public static global::PFDBHDCAEPE<(T, U)> LPIKICKGJBP<T, U>(in global::PFDBHDCAEPE<T> NCGEKBENJBA, in global::PFDBHDCAEPE<U> IIFMPDAMAIA)
	{
		return default(global::PFDBHDCAEPE<(T, U)>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct BIJHJKPHMII : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x560EC0", Offset = "0x55F4C0", VA = "0x180560EC0")]
	public static BIJHJKPHMII BIOJJPJDKDG<T>([Optional] string DCIJEJBJLOB, [Optional] string JACAJNINABN, bool DDCDEOGJJAF = false)
	{
		return default(BIJHJKPHMII);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public class OEKGOGBNJJA<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Func<Internal, External> PPLBFPDDENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Func<External, Internal> AHCEMKPPODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private IList<Internal> EJCFBHKFPEM;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IList<Internal> APKEOLLAIJO
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x562DF0", Offset = "0x5613F0", VA = "0x180562DF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x58AD70", Offset = "0x589370", VA = "0x18058AD70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool GCLNONOIJMG
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5E1990", Offset = "0x5DFF90", VA = "0x1805E1990", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3F0", Offset = "0x6FD9F0", VA = "0x1806FF3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public External NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3DD66F0", Offset = "0x3DD4CF0", VA = "0x183DD66F0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6790", Offset = "0x3DD4D90", VA = "0x183DD6790", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6690", Offset = "0x3DD4C90", VA = "0x183DD6690", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3DD6600", Offset = "0x3DD4C00", VA = "0x183DD6600")]
	public OEKGOGBNJJA(Func<Internal, External> PPLBFPDDENP, Func<External, Internal> AHCEMKPPODP, bool LNCLBBEBHPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3DD6310", Offset = "0x3DD4910", VA = "0x183DD6310", Slot = "6")]
	public int IndexOf(External JAKHJIEAJDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3DD5F90", Offset = "0x3DD4590", VA = "0x183DD5F90", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3DD5FF0", Offset = "0x3DD45F0", VA = "0x183DD5FF0", Slot = "13")]
	public bool Contains(External JAKHJIEAJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3DD6080", Offset = "0x3DD4680", VA = "0x183DD6080", Slot = "14")]
	public void CopyTo(External[] BEGPAFGBCJM, int KHBOJEFOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3DD5EA0", Offset = "0x3DD44A0", VA = "0x183DD5EA0", Slot = "11")]
	public void Add(External JAKHJIEAJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3DD6400", Offset = "0x3DD4A00", VA = "0x183DD6400", Slot = "7")]
	public void Insert(int HOOANEAGKNH, External JAKHJIEAJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3DD6570", Offset = "0x3DD4B70", VA = "0x183DD6570", Slot = "15")]
	public bool Remove(External JAKHJIEAJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3DD64A0", Offset = "0x3DD4AA0", VA = "0x183DD64A0", Slot = "8")]
	public void RemoveAt(int HOOANEAGKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3DD62A0", Offset = "0x3DD48A0", VA = "0x183DD62A0", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1C6B390", Offset = "0x1C69990", VA = "0x181C6B390", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class MGLODNAEJAK<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly Func<Internal, External> PPLBFPDDENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private IReadOnlyList<Internal> EJCFBHKFPEM;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<Internal> APKEOLLAIJO
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5604A0", Offset = "0x55EAA0", VA = "0x1805604A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool GCLNONOIJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x560FE0", Offset = "0x55F5E0", VA = "0x180560FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public External NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3919BF0", Offset = "0x39181F0", VA = "0x183919BF0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3919B90", Offset = "0x3918190", VA = "0x183919B90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x20B8150", Offset = "0x20B6750", VA = "0x1820B8150")]
	public MGLODNAEJAK(Func<Internal, External> PPLBFPDDENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3919B40", Offset = "0x3918140", VA = "0x183919B40")]
	public MGLODNAEJAK(IReadOnlyList<Internal> EJCFBHKFPEM, Func<Internal, External> PPLBFPDDENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x39198B0", Offset = "0x3917EB0", VA = "0x1839198B0")]
	public void EJHGKGPLOIF(External[] BEGPAFGBCJM, int KHBOJEFOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3919AD0", Offset = "0x39180D0", VA = "0x183919AD0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1C72CC0", Offset = "0x1C712C0", VA = "0x181C72CC0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[DefaultMember("Item")]
public class LJFPEAECACI<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private IReadOnlyList<Internal> EJCFBHKFPEM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<Internal> APKEOLLAIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x560490", Offset = "0x55EA90", VA = "0x180560490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool GCLNONOIJMG
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x560FE0", Offset = "0x55F5E0", VA = "0x180560FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public External NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x28847E0", Offset = "0x2882DE0", VA = "0x1828847E0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2884780", Offset = "0x2882D80", VA = "0x182884780", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x20B8150", Offset = "0x20B6750", VA = "0x1820B8150")]
	public LJFPEAECACI(IReadOnlyList<Internal> EJCFBHKFPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2884670", Offset = "0x2882C70", VA = "0x182884670")]
	public bool FECGJJAPIMF(External JAKHJIEAJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2884440", Offset = "0x2882A40", VA = "0x182884440")]
	public void EJHGKGPLOIF(External[] BEGPAFGBCJM, int KHBOJEFOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2884710", Offset = "0x2882D10", VA = "0x182884710", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x1C6B390", Offset = "0x1C69990", VA = "0x181C6B390", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public abstract class CPJFFOALPNM
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void EPLEHJEKGCH(object[] DFPAFIPCLLC);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	protected CPJFFOALPNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public abstract class JCIOECKHLAD<T> : CPJFFOALPNM
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	protected struct MJDJNAFBEKO
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public enum JPOJMMELLGA
		{
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public JPOJMMELLGA ONIHNDBDHGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public T BKCLKIJOKLP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private int LCPJEFJMLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly bool LDHCMKFNDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	protected readonly bool PMCPACKPOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	protected List<T> EHNFCAHJFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<MJDJNAFBEKO> KMNLADENAGF;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool GMPEHNKMMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x385A7D0", Offset = "0x3858DD0", VA = "0x18385A7D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x385AF50", Offset = "0x3859550", VA = "0x18385AF50")]
	protected JCIOECKHLAD(bool PMCPACKPOOP, bool LDHCMKFNDPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x385A940", Offset = "0x3858F40", VA = "0x18385A940")]
	protected bool DAODDKHBOOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x385AB90", Offset = "0x3859190", VA = "0x18385AB90")]
	protected void FLGGINDPLDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x385A9E0", Offset = "0x3858FE0", VA = "0x18385A9E0")]
	protected void DDMKJOEGNIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2F23ED0", Offset = "0x2F224D0", VA = "0x182F23ED0")]
	private static void CFGNMOLDHBP<U>(ref List<U> EJCFBHKFPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x385ADD0", Offset = "0x38593D0", VA = "0x18385ADD0", Slot = "5")]
	public void NENJMCKJAJO(T BKCLKIJOKLP, bool GPJDNBLFFPN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x385AC70", Offset = "0x3859270", VA = "0x18385AC70", Slot = "6")]
	public void MNHCGCIEOKP(T BKCLKIJOKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x385A810", Offset = "0x3858E10", VA = "0x18385A810")]
	public void CGFAFPCCKIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface CIANFEHCHKI
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NENJMCKJAJO(Action BKCLKIJOKLP, bool GPJDNBLFFPN = false);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNHCGCIEOKP(Action BKCLKIJOKLP);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class DMENMFODFLB : global::JCIOECKHLAD<Action>, CIANFEHCHKI
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4DDEDF0", Offset = "0x4DDD3F0", VA = "0x184DDEDF0")]
	public DMENMFODFLB(bool PMCPACKPOOP = false, bool LDHCMKFNDPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x4DDEB50", Offset = "0x4DDD150", VA = "0x184DDEB50")]
	public void CEKPADBFJKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x4DDED10", Offset = "0x4DDD310", VA = "0x184DDED10", Slot = "4")]
	public override void EPLEHJEKGCH(object[] DFPAFIPCLLC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x4DDEAF0", Offset = "0x4DDD0F0", VA = "0x184DDEAF0")]
	public static DMENMFODFLB BNJHJDGNPLG(DMENMFODFLB IEJHAHAJFAP, Action BKCLKIJOKLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x4DDED90", Offset = "0x4DDD390", VA = "0x184DDED90")]
	public static DMENMFODFLB ODGGBCCOGPF(DMENMFODFLB IEJHAHAJFAP, Action BKCLKIJOKLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface ACCABCAMEPF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NENJMCKJAJO(Action<T> BKCLKIJOKLP, bool GPJDNBLFFPN = false);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNHCGCIEOKP(Action<T> BKCLKIJOKLP);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class JKHHCHAOBGN<T> : global::JCIOECKHLAD<Action<T>>, global::ACCABCAMEPF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x22AB080", Offset = "0x22A9680", VA = "0x1822AB080")]
	public JKHHCHAOBGN(bool PMCPACKPOOP = false, bool LDHCMKFNDPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6840", Offset = "0x2FC4E40", VA = "0x182FC6840")]
	public void CEKPADBFJKO(T JDLAIFIMIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9980", Offset = "0x2FC7F80", VA = "0x182FC9980", Slot = "4")]
	public override void EPLEHJEKGCH(object[] DFPAFIPCLLC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2FC5B90", Offset = "0x2FC4190", VA = "0x182FC5B90")]
	public static global::JKHHCHAOBGN<T> BNJHJDGNPLG(global::JKHHCHAOBGN<T> IEJHAHAJFAP, Action<T> BKCLKIJOKLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2FCAEF0", Offset = "0x2FC94F0", VA = "0x182FCAEF0")]
	public static global::JKHHCHAOBGN<T> ODGGBCCOGPF(global::JKHHCHAOBGN<T> IEJHAHAJFAP, Action<T> BKCLKIJOKLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface ACKAIJMPPCO<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NENJMCKJAJO(Action<T, U> BKCLKIJOKLP, bool GPJDNBLFFPN = false);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNHCGCIEOKP(Action<T, U> BKCLKIJOKLP);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class HEMGBEBKGKH<T, U> : global::JCIOECKHLAD<Action<T, U>>, global::ACKAIJMPPCO<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x22AB080", Offset = "0x22A9680", VA = "0x1822AB080")]
	public HEMGBEBKGKH(bool PMCPACKPOOP = false, bool LDHCMKFNDPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x27928D0", Offset = "0x2790ED0", VA = "0x1827928D0")]
	public void CEKPADBFJKO(T JDLAIFIMIJD, U MNLIMBKAJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2794D00", Offset = "0x2793300", VA = "0x182794D00", Slot = "4")]
	public override void EPLEHJEKGCH(object[] DFPAFIPCLLC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x278FCF0", Offset = "0x278E2F0", VA = "0x18278FCF0")]
	public static global::HEMGBEBKGKH<T, U> BNJHJDGNPLG(global::HEMGBEBKGKH<T, U> IEJHAHAJFAP, Action<T, U> BKCLKIJOKLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x2796240", Offset = "0x2794840", VA = "0x182796240")]
	public static global::HEMGBEBKGKH<T, U> ODGGBCCOGPF(global::HEMGBEBKGKH<T, U> IEJHAHAJFAP, Action<T, U> BKCLKIJOKLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface DNFOGDLKNAL<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NENJMCKJAJO(Action<T, U, V> BKCLKIJOKLP, bool GPJDNBLFFPN = false);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNHCGCIEOKP(Action<T, U, V> BKCLKIJOKLP);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class GHPNKKCLPNO<T, U, V> : global::JCIOECKHLAD<Action<T, U, V>>, global::DNFOGDLKNAL<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x22AB080", Offset = "0x22A9680", VA = "0x1822AB080")]
	public GHPNKKCLPNO(bool PMCPACKPOOP = false, bool LDHCMKFNDPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x32D9740", Offset = "0x32D7D40", VA = "0x1832D9740")]
	public void CEKPADBFJKO(T JDLAIFIMIJD, U MNLIMBKAJDP, V LNDKNIFDPNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x32DA8C0", Offset = "0x32D8EC0", VA = "0x1832DA8C0", Slot = "4")]
	public override void EPLEHJEKGCH(object[] DFPAFIPCLLC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x32D7C80", Offset = "0x32D6280", VA = "0x1832D7C80")]
	public static global::GHPNKKCLPNO<T, U, V> BNJHJDGNPLG(global::GHPNKKCLPNO<T, U, V> IEJHAHAJFAP, Action<T, U, V> BKCLKIJOKLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x32DB980", Offset = "0x32D9F80", VA = "0x1832DB980")]
	public static global::GHPNKKCLPNO<T, U, V> ODGGBCCOGPF(global::GHPNKKCLPNO<T, U, V> IEJHAHAJFAP, Action<T, U, V> BKCLKIJOKLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface BPNKCEMAPIG<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NENJMCKJAJO(Action<T, U, V, W> BKCLKIJOKLP, bool GPJDNBLFFPN = false);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNHCGCIEOKP(Action<T, U, V, W> BKCLKIJOKLP);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class CDGFJDGMEDE<T, U, V, W> : global::JCIOECKHLAD<Action<T, U, V, W>>, global::BPNKCEMAPIG<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x22AB080", Offset = "0x22A9680", VA = "0x1822AB080")]
	public CDGFJDGMEDE(bool PMCPACKPOOP = false, bool LDHCMKFNDPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x23CCEF0", Offset = "0x23CB4F0", VA = "0x1823CCEF0")]
	public void CEKPADBFJKO(T JDLAIFIMIJD, U MNLIMBKAJDP, V LNDKNIFDPNN, W PCMOEMJBGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x23CDC30", Offset = "0x23CC230", VA = "0x1823CDC30", Slot = "4")]
	public override void EPLEHJEKGCH(object[] DFPAFIPCLLC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x23CC360", Offset = "0x23CA960", VA = "0x1823CC360")]
	public static global::CDGFJDGMEDE<T, U, V, W> BNJHJDGNPLG(global::CDGFJDGMEDE<T, U, V, W> IEJHAHAJFAP, Action<T, U, V, W> BKCLKIJOKLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x23CF2A0", Offset = "0x23CD8A0", VA = "0x1823CF2A0")]
	public static global::CDGFJDGMEDE<T, U, V, W> ODGGBCCOGPF(global::CDGFJDGMEDE<T, U, V, W> IEJHAHAJFAP, Action<T, U, V, W> BKCLKIJOKLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface JIDGJNHKLMA<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NENJMCKJAJO(Action<T, U, V, W, X> BKCLKIJOKLP, bool GPJDNBLFFPN = false);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNHCGCIEOKP(Action<T, U, V, W, X> BKCLKIJOKLP);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class LACMDDHJPGJ<T, U, V, W, X> : global::JCIOECKHLAD<Action<T, U, V, W, X>>, global::JIDGJNHKLMA<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x22AB080", Offset = "0x22A9680", VA = "0x1822AB080")]
	public LACMDDHJPGJ(bool PMCPACKPOOP = false, bool LDHCMKFNDPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x38E8570", Offset = "0x38E6B70", VA = "0x1838E8570")]
	public void CEKPADBFJKO(T JDLAIFIMIJD, U MNLIMBKAJDP, V LNDKNIFDPNN, W PCMOEMJBGBJ, X KDNDPAEEMPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x38E8E40", Offset = "0x38E7440", VA = "0x1838E8E40", Slot = "4")]
	public override void EPLEHJEKGCH(object[] DFPAFIPCLLC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x38E84D0", Offset = "0x38E6AD0", VA = "0x1838E84D0")]
	public static global::LACMDDHJPGJ<T, U, V, W, X> BNJHJDGNPLG(global::LACMDDHJPGJ<T, U, V, W, X> IEJHAHAJFAP, Action<T, U, V, W, X> BKCLKIJOKLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x38E9130", Offset = "0x38E7730", VA = "0x1838E9130")]
	public static global::LACMDDHJPGJ<T, U, V, W, X> ODGGBCCOGPF(global::LACMDDHJPGJ<T, U, V, W, X> IEJHAHAJFAP, Action<T, U, V, W, X> BKCLKIJOKLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface GKPFHJHPDIE<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NENJMCKJAJO(Action<T, U, V, W, X, Y> BKCLKIJOKLP, bool GPJDNBLFFPN = false);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNHCGCIEOKP(Action<T, U, V, W, X, Y> BKCLKIJOKLP);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public sealed class GPINHFDLANA<T, U, V, W, X, Y> : global::JCIOECKHLAD<Action<T, U, V, W, X, Y>>, global::GKPFHJHPDIE<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x22AB080", Offset = "0x22A9680", VA = "0x1822AB080")]
	public GPINHFDLANA(bool PMCPACKPOOP = false, bool LDHCMKFNDPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x31D3FB0", Offset = "0x31D25B0", VA = "0x1831D3FB0")]
	public void CEKPADBFJKO(T JDLAIFIMIJD, U MNLIMBKAJDP, V LNDKNIFDPNN, W PCMOEMJBGBJ, X KDNDPAEEMPL, Y HJCNEOFEOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x31D48D0", Offset = "0x31D2ED0", VA = "0x1831D48D0", Slot = "4")]
	public override void EPLEHJEKGCH(object[] DFPAFIPCLLC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x31D3C50", Offset = "0x31D2250", VA = "0x1831D3C50")]
	public static global::GPINHFDLANA<T, U, V, W, X, Y> BNJHJDGNPLG(global::GPINHFDLANA<T, U, V, W, X, Y> IEJHAHAJFAP, Action<T, U, V, W, X, Y> BKCLKIJOKLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x31D4F80", Offset = "0x31D3580", VA = "0x1831D4F80")]
	public static global::GPINHFDLANA<T, U, V, W, X, Y> ODGGBCCOGPF(global::GPINHFDLANA<T, U, V, W, X, Y> IEJHAHAJFAP, Action<T, U, V, W, X, Y> BKCLKIJOKLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class LDFGCLJIJJG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public readonly struct JCPCOCFAFNO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly global::LDFGCLJIJJG<T> FGHGOHMNDJC;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public T NLLJAAOBNLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x38E0830", Offset = "0x38DEE30", VA = "0x1838E0830")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x38E0850", Offset = "0x38DEE50", VA = "0x1838E0850", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6AAD90", Offset = "0x6A9390", VA = "0x1806AAD90")]
		public JCPCOCFAFNO(global::LDFGCLJIJJG<T> FGHGOHMNDJC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct KBDIFEKOEKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<JCPCOCFAFNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public global::LDFGCLJIJJG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x38E0A50", Offset = "0x38DF050", VA = "0x1838E0A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x32EA380", Offset = "0x32E8980", VA = "0x1832EA380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct EEEAPECIFHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder<JCPCOCFAFNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public global::LDFGCLJIJJG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x38DFF10", Offset = "0x38DE510", VA = "0x1838DFF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x32EA380", Offset = "0x32E8980", VA = "0x1832EA380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly SemaphoreSlim AJIDLHJEKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private T FFBDFOMCMBB;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int GKBLPIEKKIK
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x38EB250", Offset = "0x38E9850", VA = "0x1838EB250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x38EB8B0", Offset = "0x38E9EB0", VA = "0x1838EB8B0")]
	public LDFGCLJIJJG(in T FFBDFOMCMBB, int DCDEECPEDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B2D0", Offset = "0x2F398D0", VA = "0x182F3B2D0")]
	public LDFGCLJIJJG(in T FFBDFOMCMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x38EB830", Offset = "0x38E9E30", VA = "0x1838EB830")]
	public JCPCOCFAFNO MCOEOLJBILA()
	{
		return default(JCPCOCFAFNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x38EB870", Offset = "0x38E9E70", VA = "0x1838EB870")]
	public JCPCOCFAFNO MCOEOLJBILA(CancellationToken CMOIBOJIACL)
	{
		return default(JCPCOCFAFNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x38EB270", Offset = "0x38E9870", VA = "0x1838EB270")]
	[AsyncStateMachine(typeof(global::LDFGCLJIJJG<>.KBDIFEKOEKF))]
	public Task<JCPCOCFAFNO> KCBHEMBFHIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x38EB6B0", Offset = "0x38E9CB0", VA = "0x1838EB6B0")]
	[AsyncStateMachine(typeof(global::LDFGCLJIJJG<>.EEEAPECIFHB))]
	public Task<JCPCOCFAFNO> KCBHEMBFHIG(CancellationToken CMOIBOJIACL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class IAANNDHCAPH
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0090", Offset = "0x4DDE690", VA = "0x184DE0090")]
	public static global::LDFGCLJIJJG<CBIFGBDDJND> CIAOGEOFBKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0020", Offset = "0x4DDE620", VA = "0x184DE0020")]
	public static global::LDFGCLJIJJG<CBIFGBDDJND> CIAOGEOFBKG(int DCDEECPEDHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x1A8E8A0", Offset = "0x1A8CEA0", VA = "0x181A8E8A0")]
	public static global::LDFGCLJIJJG<T> CIAOGEOFBKG<T>(in T FFBDFOMCMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x1D950B0", Offset = "0x1D936B0", VA = "0x181D950B0")]
	public static global::LDFGCLJIJJG<T> CIAOGEOFBKG<T>(in T FFBDFOMCMBB, int DCDEECPEDHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class KAOKELGFGBD<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public delegate bool JHPNCFBIPAE(global::KAOKELGFGBD<T> BOKLJENJLOP);

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class HDFNDPJBBMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public global::KAOKELGFGBD<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		public HDFNDPJBBMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3F99C70", Offset = "0x3F98270", VA = "0x183F99C70")]
		internal bool <FindNode>b__0(global::KAOKELGFGBD<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public T CHNAKPMIOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public LinkedList<global::KAOKELGFGBD<T>> BOKHLLHODJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public global::KAOKELGFGBD<T> KPIDJCNLPLH;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public global::KAOKELGFGBD<T> ANDKMGNGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5B3130", Offset = "0x5B1730", VA = "0x1805B3130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3F9C290", Offset = "0x3F9A890", VA = "0x183F9C290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool BAPGHJHPPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3F9D8D0", Offset = "0x3F9BED0", VA = "0x183F9D8D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool LLAKFPHNMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3F9E720", Offset = "0x3F9CD20", VA = "0x183F9E720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public global::KAOKELGFGBD<T> MPLJPEEIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3F9D240", Offset = "0x3F9B840", VA = "0x183F9D240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3F9E760", Offset = "0x3F9CD60", VA = "0x183F9E760")]
	public KAOKELGFGBD(T FEILBPJMFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3F9D9F0", Offset = "0x3F9BFF0", VA = "0x183F9D9F0")]
	public global::KAOKELGFGBD<T> MLADKEOGKBF(T IBENHFJNCNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3F9C9F0", Offset = "0x3F9AFF0", VA = "0x183F9C9F0")]
	public global::KAOKELGFGBD<T> EFDDPMDIGJJ(T IEONNBOFCGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x3F9DBA0", Offset = "0x3F9C1A0", VA = "0x183F9DBA0")]
	public global::KAOKELGFGBD<T> MNHCGCIEOKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x3F9C5D0", Offset = "0x3F9ABD0", VA = "0x183F9C5D0")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x3F9D390", Offset = "0x3F9B990", VA = "0x183F9D390")]
	public global::KAOKELGFGBD<T> JBEHHMLAKHA(T GLGDDCPCPHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3F9CBC0", Offset = "0x3F9B1C0", VA = "0x183F9CBC0")]
	public static void HDIKIJHHCEG(global::KAOKELGFGBD<T> HKDGPAFLHLL, JHPNCFBIPAE ADCHCDBFMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2F26170", Offset = "0x2F24770", VA = "0x182F26170")]
	public static void HDIKIJHHCEG<A>(global::KAOKELGFGBD<T> HKDGPAFLHLL, Func<global::KAOKELGFGBD<T>, A, bool> ADCHCDBFMEI, A NOGDFKMIPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3F9E1A0", Offset = "0x3F9C7A0", VA = "0x183F9E1A0")]
	public static string OLMBJKNCJKO(global::KAOKELGFGBD<T> HKDGPAFLHLL, int DIAIBOCHHHM = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3F9D4A0", Offset = "0x3F9BAA0", VA = "0x183F9D4A0")]
	public static global::KAOKELGFGBD<T> MJJBIMCMAJE(global::KAOKELGFGBD<T> HKDGPAFLHLL, T PFCODKFOECI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class EKHPPECGNEP<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public delegate Task<TResult> DDLCJIODBNN(TRequest DMFHFDFMIOL, CancellationToken CMOIBOJIACL);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public enum DFCAKGMBJFC
	{
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class BGJIBKKPONF
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private const float MEHHOKFEFCM = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private TimeSpan IDICCFEMMNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int HIBLOKNBJPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public DFCAKGMBJFC IGKAGDPHNKN;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public static readonly BGJIBKKPONF KAKLFEMJBPO;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float DLEALDPDOGH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x3923E80", Offset = "0x3922480", VA = "0x183923E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public TimeSpan MKMMMBPKECM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x39240B0", Offset = "0x39226B0", VA = "0x1839240B0")]
		public BGJIBKKPONF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private readonly struct CPDPKOGNDMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public readonly TRequest DMFHFDFMIOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public readonly CancellationToken CMOIBOJIACL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public readonly TaskCompletionSource<TResult> IFBJDGECJAB;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3924180", Offset = "0x3922780", VA = "0x183924180")]
		public CPDPKOGNDMK(TRequest DMFHFDFMIOL, TaskCompletionSource<TResult> IFBJDGECJAB, CancellationToken CMOIBOJIACL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class BIHOMPADBPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		public BIHOMPADBPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x1E33150", Offset = "0x1E31750", VA = "0x181E33150")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct PLHBOMNHNCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public global::EKHPPECGNEP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3934240", Offset = "0x3932840", VA = "0x183934240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class EKAKBFKCNNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CPDPKOGNDMK req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public global::EKHPPECGNEP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		public EKAKBFKCNNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3931E80", Offset = "0x3930480", VA = "0x183931E80")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly CancellationTokenSource NELLOLNKPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<CPDPKOGNDMK> OBAKNPENLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly BGJIBKKPONF KKPFBJICEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly DDLCJIODBNN BDLAJAFHBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Task BAFHFLGICBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int FHCLKLEABMI;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x39335F0", Offset = "0x3931BF0", VA = "0x1839335F0")]
	public EKHPPECGNEP(DDLCJIODBNN BDLAJAFHBFJ, [Optional] BGJIBKKPONF KKPFBJICEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3932B80", Offset = "0x3931180", VA = "0x183932B80")]
	public Task<TResult> MNJBLIJCDFD(TRequest DMFHFDFMIOL, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3932300", Offset = "0x3930900", VA = "0x183932300")]
	private void BENHOGEOEOP(CPDPKOGNDMK FPLKOOCDOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3932580", Offset = "0x3930B80", VA = "0x183932580")]
	[AsyncStateMachine(typeof(global::EKHPPECGNEP<, >.PLHBOMNHNCH))]
	private Task GDCLGIJEKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3932920", Offset = "0x3930F20", VA = "0x183932920")]
	private CPDPKOGNDMK IMCOKFECAJL()
	{
		return default(CPDPKOGNDMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3933050", Offset = "0x3931650", VA = "0x183933050")]
	private void OAJGKGCOEDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3932430", Offset = "0x3930A30", VA = "0x183932430", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class AAOBANAHOBE<TKey, TVal> : global::MNJJEOCAODK<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int IGLDDNGINAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	internal Dictionary<TKey, (TVal value, int size)> OHICEBKCCGF;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	internal override int APANJMKHEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x210ABF0", Offset = "0x21091F0", VA = "0x18210ABF0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	internal int GHFLINOAECP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x210AE50", Offset = "0x2109450", VA = "0x18210AE50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public override int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x210AA80", Offset = "0x2109080", VA = "0x18210AA80", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x210B010", Offset = "0x2109610", VA = "0x18210B010")]
	public AAOBANAHOBE(int NKJBJGFALMO, [Optional] KBEBHCMPFNO MGNGOHNPJMK, [Optional] IEqualityComparer<TKey> IMMINEHIHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x210AAE0", Offset = "0x21090E0", VA = "0x18210AAE0")]
	public void BOMMHKAGJPD(TKey MKDJIBNCKNC, TVal MPHFKGJNMOK, bool LOBFFGFGIHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x210AF90", Offset = "0x2109590", VA = "0x18210AF90")]
	public bool OFKBBGGDFII(TKey MKDJIBNCKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x210A930", Offset = "0x2108F30", VA = "0x18210A930", Slot = "6")]
	public override bool ACEOCCKNHLM(TKey DPILHFBKDPD, out TVal MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x210AC20", Offset = "0x2109220", VA = "0x18210AC20")]
	public bool GLACPOKAIAE(TKey MKDJIBNCKNC, TVal MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x210AE80", Offset = "0x2109480", VA = "0x18210AE80")]
	public bool NKFCLMIEBBF(TKey MKDJIBNCKNC, TVal MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x210AB80", Offset = "0x2109180", VA = "0x18210AB80", Slot = "7")]
	public override void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x210A9E0", Offset = "0x2108FE0", VA = "0x18210A9E0")]
	private bool BBBOAFHBNEH(TKey MKDJIBNCKNC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[DefaultMember("Item")]
public class MNJJEOCAODK<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public delegate int KBEBHCMPFNO(TKey MKDJIBNCKNC, TVal MPHFKGJNMOK);

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class EBBCEOAHEDN
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public TKey FJPMPBHLOOP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public TVal NLLJAAOBNLN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x687F70", Offset = "0x686570", VA = "0x180687F70")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x6FF010", Offset = "0x6FD610", VA = "0x1806FF010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public int OJCJOGAFMFG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x6BC1F0", Offset = "0x6BA7F0", VA = "0x1806BC1F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x6BC220", Offset = "0x6BA820", VA = "0x1806BC220")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public DateTime FFJGAHEEILE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x562DF0", Offset = "0x5613F0", VA = "0x180562DF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xFD9060", Offset = "0xFD7660", VA = "0x180FD9060")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3909030", Offset = "0x3907630", VA = "0x183909030")]
		public EBBCEOAHEDN(TKey MKDJIBNCKNC, TVal GBDFHGIMHBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public const int NOKBGKBILHO = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly Dictionary<TKey, LinkedListNode<EBBCEOAHEDN>> CGHENOKHCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly LinkedList<EBBCEOAHEDN> FNAAFFKCDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	protected readonly KBEBHCMPFNO MGNGOHNPJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly TimeSpan OAJCCBLDMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly NHFJKNGOAGN CAJMJEDGGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int LELNFFOEHKA;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int NPEDIGKGFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6C55F0", Offset = "0x6C3BF0", VA = "0x1806C55F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private bool CNDPNPLFLLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x391D410", Offset = "0x391BA10", VA = "0x18391D410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	internal virtual int APANJMKHEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6C5600", Offset = "0x6C3C00", VA = "0x1806C5600", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private int DHNBJNKGAHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1FC6530", Offset = "0x1FC4B30", VA = "0x181FC6530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public virtual int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1C6B4F0", Offset = "0x1C69AF0", VA = "0x181C6B4F0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<TKey> GCFCKHBGHHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x391DC30", Offset = "0x391C230", VA = "0x18391DC30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public TVal NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x28AD2D0", Offset = "0x28AB8D0", VA = "0x1828AD2D0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x26953F0", Offset = "0x26939F0", VA = "0x1826953F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x391E940", Offset = "0x391CF40", VA = "0x18391E940")]
	public MNJJEOCAODK(int NKJBJGFALMO, [Optional] KBEBHCMPFNO MGNGOHNPJMK, [Optional] IEqualityComparer<TKey> IMMINEHIHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x391E400", Offset = "0x391CA00", VA = "0x18391E400")]
	public MNJJEOCAODK(TimeSpan OAJCCBLDMCD, [Optional] IEqualityComparer<TKey> IMMINEHIHCI, [Optional] NHFJKNGOAGN CAJMJEDGGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x391E450", Offset = "0x391CA50", VA = "0x18391E450")]
	public MNJJEOCAODK(int NKJBJGFALMO, TimeSpan OAJCCBLDMCD, [Optional] IEqualityComparer<TKey> IMMINEHIHCI, [Optional] NHFJKNGOAGN CAJMJEDGGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x391E6F0", Offset = "0x391CCF0", VA = "0x18391E6F0")]
	public MNJJEOCAODK(int NKJBJGFALMO, KBEBHCMPFNO MGNGOHNPJMK, TimeSpan OAJCCBLDMCD, [Optional] IEqualityComparer<TKey> IMMINEHIHCI, [Optional] NHFJKNGOAGN CAJMJEDGGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x391E290", Offset = "0x391C890", VA = "0x18391E290")]
	public void OKGGIJMCCBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x391DE50", Offset = "0x391C450", VA = "0x18391DE50")]
	public void KJOMPIGOOHG(TKey MKDJIBNCKNC, TVal MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x391DFD0", Offset = "0x391C5D0", VA = "0x18391DFD0")]
	public bool MNHCGCIEOKP(TKey MKDJIBNCKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x391E1E0", Offset = "0x391C7E0", VA = "0x18391E1E0")]
	private TVal NELNIMGBJDL(TKey DPILHFBKDPD)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x391CBD0", Offset = "0x391B1D0", VA = "0x18391CBD0", Slot = "6")]
	public virtual bool ACEOCCKNHLM(TKey DPILHFBKDPD, out TVal MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x391D000", Offset = "0x391B600", VA = "0x18391D000", Slot = "7")]
	public virtual void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x391CE80", Offset = "0x391B480", VA = "0x18391CE80")]
	private bool AJGFBOGIILO(EBBCEOAHEDN FHIFMCKLKIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x391D7E0", Offset = "0x391BDE0", VA = "0x18391D7E0")]
	private void GAKEJIECJMO(LinkedListNode<EBBCEOAHEDN> INLBOMPPGEC, TVal JKGBMLLOBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x391D070", Offset = "0x391B670", VA = "0x18391D070")]
	private void EMKENJFOCJF(TKey MKDJIBNCKNC, TVal MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x391D4A0", Offset = "0x391BAA0", VA = "0x18391D4A0")]
	private void FIOEDJLHAGG(EBBCEOAHEDN FHIFMCKLKIJ, TVal JKGBMLLOBKK, int IHELJAFNFGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[DefaultMember("Item")]
public class PCOKAEPICEC<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly List<T> EJCFBHKFPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private HashSet<T> MLIIGDCHMLG;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x1E33150", Offset = "0x1E31750", VA = "0x181E33150", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool GCLNONOIJMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x560EC0", Offset = "0x55F4C0", VA = "0x180560EC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public T NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x2967FC0", Offset = "0x29665C0", VA = "0x182967FC0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3A09D90", Offset = "0x3A08390", VA = "0x183A09D90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x2694F60", Offset = "0x2693560", VA = "0x182694F60", Slot = "11")]
	public void Add(T JAKHJIEAJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x3A098B0", Offset = "0x3A07EB0", VA = "0x183A098B0")]
	public bool LHNHAJKKNNC(T JAKHJIEAJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x3A09BA0", Offset = "0x3A081A0", VA = "0x183A09BA0", Slot = "15")]
	public bool Remove(T JAKHJIEAJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x287E9B0", Offset = "0x287CFB0", VA = "0x18287E9B0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x1ECAE10", Offset = "0x1EC9410", VA = "0x181ECAE10", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x3A094F0", Offset = "0x3A07AF0", VA = "0x183A094F0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x2CD6190", Offset = "0x2CD4790", VA = "0x182CD6190", Slot = "13")]
	public bool Contains(T JAKHJIEAJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2FD1400", Offset = "0x2FCFA00", VA = "0x182FD1400", Slot = "14")]
	public void CopyTo(T[] BEGPAFGBCJM, int KHBOJEFOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x22A9280", Offset = "0x22A7880", VA = "0x1822A9280", Slot = "6")]
	public int IndexOf(T JAKHJIEAJDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x3A09650", Offset = "0x3A07C50", VA = "0x183A09650", Slot = "7")]
	public void Insert(int HOOANEAGKNH, T JAKHJIEAJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x3A09A00", Offset = "0x3A08000", VA = "0x183A09A00", Slot = "8")]
	public void RemoveAt(int HOOANEAGKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3A097E0", Offset = "0x3A07DE0", VA = "0x183A097E0")]
	public void JPDGOHOAFDO(Predicate<T> MOCGNKJBNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3A09550", Offset = "0x3A07B50", VA = "0x183A09550")]
	public void GODLBFOGBPL(Comparison<T> OLNLPDCDNHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x3A09CB0", Offset = "0x3A082B0", VA = "0x183A09CB0")]
	public PCOKAEPICEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class GDGPHELNJNO
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x4DDF310", Offset = "0x4DDD910", VA = "0x184DDF310")]
	public static Vector3 FPDALGMJCJH(this GameObject NIKGFIPEJKD, float HKAGPPDOKGA)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x1D06AE0", Offset = "0x1D050E0", VA = "0x181D06AE0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4450", Offset = "0x4DE2A50", VA = "0x184DE4450")]
		public SerializedGuid(in Guid JAEJGMEOIFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4DE3FA0", Offset = "0x4DE25A0", VA = "0x184DE3FA0")]
		public static SerializedGuid BGDPBAKHENH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4270", Offset = "0x4DE2870", VA = "0x184DE4270")]
		public static SerializedGuid LNBFHDGHKCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4DE42F0", Offset = "0x4DE28F0", VA = "0x184DE42F0")]
		public bool OEEIPECNPFA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4420", Offset = "0x4DE2A20", VA = "0x184DE4420", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4380", Offset = "0x4DE2980", VA = "0x184DE4380", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4050", Offset = "0x4DE2650", VA = "0x184DE4050")]
		public bool EODIBPOHCMG(in Guid JAEJGMEOIFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x4DE40E0", Offset = "0x4DE26E0", VA = "0x184DE40E0", Slot = "7")]
		public bool Equals(SerializedGuid GJPJDOANCNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4180", Offset = "0x4DE2780", VA = "0x184DE4180", Slot = "0")]
		public override bool Equals(object FIEDOLNFNLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4260", Offset = "0x4DE2860", VA = "0x184DE4260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4020", Offset = "0x4DE2620", VA = "0x184DE4020", Slot = "6")]
		public int CompareTo(SerializedGuid GJPJDOANCNK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class EBJBMKGEPOF : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Type JNGKNCDPJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly string LHMNCCJEFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly bool IDEEADDIBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly bool AAHNOIHMCHM;

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x4DDEEB0", Offset = "0x4DDD4B0", VA = "0x184DDEEB0")]
	public EBJBMKGEPOF(Type JFOHOJCMPFN, string HEJPHGDJLFJ, bool EHJILPCPPNA = false, bool KNBPAJNJHGG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface HMCJOMOJICA
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface HIOHEHIBBAB<T> : HMCJOMOJICA
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	T NLLJAAOBNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool AMFKCCOECJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string DDACGDALABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::HIOHEHIBBAB<T> NABIICCLMIE(Action<T> HAMPEPEMKKP);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::HIOHEHIBBAB<T> NKLBBHCBAFG(Action<T> HAMPEPEMKKP);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::HIOHEHIBBAB<T> GNAPGOKJNAF(Action<T, T> JGCLGOFNOEF);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::HIOHEHIBBAB<T> IAIMPEBPJPC(Action<T, T> JGCLGOFNOEF);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::HIOHEHIBBAB<T> HEIHFCBPGCG(Action<string> PPAFCJMLBKH);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::HIOHEHIBBAB<T> ICCGDMFPEDB(Action<string> PPAFCJMLBKH);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class BHNDNAOGBDH<T> : global::HIOHEHIBBAB<T>, HMCJOMOJICA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private global::HEMGBEBKGKH<T, T> HLDKCBJDKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private global::JKHHCHAOBGN<T> CFDAEHFHOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private global::JKHHCHAOBGN<string> BGKLDIOCHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private string IOBNDAKOHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private T AEOILPMENGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private bool NFOFGNIFILC;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public T NLLJAAOBNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x588A30", Offset = "0x587030", VA = "0x180588A30", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x28AE040", Offset = "0x28AC640", VA = "0x1828AE040", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool AMFKCCOECJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x5E28B0", Offset = "0x5E0EB0", VA = "0x1805E28B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string DDACGDALABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x5890C0", Offset = "0x5876C0", VA = "0x1805890C0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x26D5930", Offset = "0x26D3F30", VA = "0x1826D5930", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE220", Offset = "0x2FCC820", VA = "0x182FCE220")]
	private void GOMBGNICLJL(T JMPKGJCDKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE410", Offset = "0x2FCCA10", VA = "0x182FCE410")]
	private void MGPPKDDGIOD(string EPAKPJCIEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE540", Offset = "0x2FCCB40", VA = "0x182FCE540")]
	public void NFEMDFDACGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE1D0", Offset = "0x2FCC7D0", VA = "0x182FCE1D0", Slot = "6")]
	public global::HIOHEHIBBAB<T> GNAPGOKJNAF(Action<T, T> JGCLGOFNOEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE350", Offset = "0x2FCC950", VA = "0x182FCE350", Slot = "7")]
	public global::HIOHEHIBBAB<T> IAIMPEBPJPC(Action<T, T> JGCLGOFNOEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE4B0", Offset = "0x2FCCAB0", VA = "0x182FCE4B0", Slot = "4")]
	public global::HIOHEHIBBAB<T> NABIICCLMIE(Action<T> JGCLGOFNOEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE5F0", Offset = "0x2FCCBF0", VA = "0x182FCE5F0", Slot = "5")]
	public global::HIOHEHIBBAB<T> NKLBBHCBAFG(Action<T> HAMPEPEMKKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE2C0", Offset = "0x2FCC8C0", VA = "0x182FCE2C0", Slot = "8")]
	public global::HIOHEHIBBAB<T> HEIHFCBPGCG(Action<string> PPAFCJMLBKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE3A0", Offset = "0x2FCC9A0", VA = "0x182FCE3A0", Slot = "9")]
	public global::HIOHEHIBBAB<T> ICCGDMFPEDB(Action<string> PPAFCJMLBKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE640", Offset = "0x2FCCC40", VA = "0x182FCE640")]
	public BHNDNAOGBDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class FLACLONOMKD
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class IBAJPDPAADF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public global::HIOHEHIBBAB<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public global::GKABJNPDFNH<T> promise;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		public IBAJPDPAADF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2C77500", Offset = "0x2C75B00", VA = "0x182C77500")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x2617E50", Offset = "0x2616450", VA = "0x182617E50")]
	public static global::DBIKMJJJBLJ<T> EKBBEKNBECD<T>(this global::HIOHEHIBBAB<T> LJGBBNNBFPD, Action<T> HKHGMJEBNHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class BJHOOGFBDGF : global::OFKOAFMHNFG<string>
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class KGEJJOBDEFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Action<BJHOOGFBDGF> callback;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public KGEJJOBDEFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x4DE01F0", Offset = "0x4DDE7F0", VA = "0x184DE01F0")]
		internal void <Wrap>b__0(global::OFKOAFMHNFG<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x4DDE8B0", Offset = "0x4DDCEB0", VA = "0x184DDE8B0")]
	public BJHOOGFBDGF([Optional] int? HKAAKKEEGCK, [Optional] Stopwatch ODAEFAFDGKE, [Optional] Action<string, GFOOEOAFMNK> JGIKMNABAKP, [Optional] Action<string, GFOOEOAFMNK> GOMCOPKOLNG, [Optional] Action<BJHOOGFBDGF> POKBCIFJMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x4DDE680", Offset = "0x4DDCC80", VA = "0x184DDE680")]
	private static Action<global::OFKOAFMHNFG<string>> EENFABPJAEN(Action<BJHOOGFBDGF> HKHGMJEBNHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4DDE740", Offset = "0x4DDCD40", VA = "0x184DDE740")]
	public static global::EJAKMHICFJG<BJHOOGFBDGF, string> IGNMNINCJJA(BJHOOGFBDGF NJKJIAHPBGG, [Optional] Action<BJHOOGFBDGF> FIMALGOHGFN)
	{
		return default(global::EJAKMHICFJG<BJHOOGFBDGF, string>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class OFKOAFMHNFG<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private class KAFADAKMGEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public TKey FJPMPBHLOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public GFOOEOAFMNK NKIDNBKJDBF;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		public KAFADAKMGEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct GFOOEOAFMNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public readonly long LEOAIGPGPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly long HLPNNHOGLBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly int HKAAKKEEGCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly int GBFCNFNMGLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly bool KKFLBPAHLGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly string BGIFPOMJEJP;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x39F8830", Offset = "0x39F6E30", VA = "0x1839F8830")]
		public GFOOEOAFMNK(long LEOAIGPGPAP, int HKAAKKEEGCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x39F8800", Offset = "0x39F6E00", VA = "0x1839F8800")]
		public GFOOEOAFMNK(long LEOAIGPGPAP, long HLPNNHOGLBA, int HKAAKKEEGCK, int GBFCNFNMGLB, bool KKFLBPAHLGI, string BGIFPOMJEJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x39F8790", Offset = "0x39F6D90", VA = "0x1839F8790")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void ODKBLGNJCCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x39F8740", Offset = "0x39F6D40", VA = "0x1839F8740")]
		public int LDJBECGOECC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x39F85F0", Offset = "0x39F6BF0", VA = "0x1839F85F0")]
		public int EJMGLKDEKGL(int GKNEDFLCIOG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x39F8610", Offset = "0x39F6C10", VA = "0x1839F8610")]
		public double GIDIJIEAMDG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x39F8680", Offset = "0x39F6C80", VA = "0x1839F8680")]
		public GFOOEOAFMNK KHNEOBFFLBP(long HLPNNHOGLBA, int GBFCNFNMGLB)
		{
			return default(GFOOEOAFMNK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct GAAMEIHCBEJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly global::OFKOAFMHNFG<TKey> NJKJIAHPBGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly TKey MKDJIBNCKNC;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x39F8540", Offset = "0x39F6B40", VA = "0x1839F8540")]
		internal GAAMEIHCBEJ(global::OFKOAFMHNFG<TKey> NJKJIAHPBGG, TKey MKDJIBNCKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x39F84A0", Offset = "0x39F6AA0", VA = "0x1839F84A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class LBEPIFIKJFK : IEnumerable<(TKey, List<TKey>, GFOOEOAFMNK)>, IEnumerable, IEnumerator<(TKey, List<TKey>, GFOOEOAFMNK)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, GFOOEOAFMNK timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::OFKOAFMHNFG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private HashSet<KAFADAKMGEJ>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private IEnumerator<(TKey key, List<TKey> path, GFOOEOAFMNK timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		private (TKey, List<TKey>, GFOOEOAFMNK) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x1ECBDE0", Offset = "0x1ECA3E0", VA = "0x181ECBDE0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, GFOOEOAFMNK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x3A02F60", Offset = "0x3A01560", VA = "0x183A02F60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x1ECC330", Offset = "0x1ECA930", VA = "0x181ECC330")]
		[DebuggerHidden]
		public LBEPIFIKJFK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3A02FC0", Offset = "0x3A015C0", VA = "0x183A02FC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3A02AF0", Offset = "0x3A010F0", VA = "0x183A02AF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3A03090", Offset = "0x3A01690", VA = "0x183A03090")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3A03190", Offset = "0x3A01790", VA = "0x183A03190")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3A02F10", Offset = "0x3A01510", VA = "0x183A02F10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3A02E50", Offset = "0x3A01450", VA = "0x183A02E50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, GFOOEOAFMNK)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x210C240", Offset = "0x210A840", VA = "0x18210C240", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class ALKGHKEPHLP : IEnumerable<(TKey, List<TKey>, GFOOEOAFMNK)>, IEnumerable, IEnumerator<(TKey, List<TKey>, GFOOEOAFMNK)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private (TKey key, List<TKey> path, GFOOEOAFMNK timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private KAFADAKMGEJ timerStackEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public KAFADAKMGEJ <>3__timerStackEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public global::OFKOAFMHNFG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private HashSet<KAFADAKMGEJ>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private IEnumerator<(TKey key, List<TKey> path, GFOOEOAFMNK timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		private (TKey, List<TKey>, GFOOEOAFMNK) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x1ECBDE0", Offset = "0x1ECA3E0", VA = "0x181ECBDE0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, GFOOEOAFMNK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x3DC1AB0", Offset = "0x3DC00B0", VA = "0x183DC1AB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x1ECC330", Offset = "0x1ECA930", VA = "0x181ECC330")]
		[DebuggerHidden]
		public ALKGHKEPHLP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1B10", Offset = "0x3DC0110", VA = "0x183DC1B10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3DC14C0", Offset = "0x3DBFAC0", VA = "0x183DC14C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1BE0", Offset = "0x3DC01E0", VA = "0x183DC1BE0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1CF0", Offset = "0x3DC02F0", VA = "0x183DC1CF0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1A60", Offset = "0x3DC0060", VA = "0x183DC1A60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1990", Offset = "0x3DBFF90", VA = "0x183DC1990", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, GFOOEOAFMNK)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2B50B20", Offset = "0x2B4F120", VA = "0x182B50B20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly Action<TKey, GFOOEOAFMNK> JGIKMNABAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly Action<TKey, GFOOEOAFMNK> GOMCOPKOLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Action<global::OFKOAFMHNFG<TKey>> POKBCIFJMOD;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private const string CCAJJMFPNOP = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly HashSet<KAFADAKMGEJ> FOKJAKMKKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly Dictionary<KAFADAKMGEJ, HashSet<KAFADAKMGEJ>> HBJOLNBINBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly Stack<KAFADAKMGEJ> IBOJPAAEHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool PGGNJMMOIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private int KBKIGHECOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly Stopwatch ODAEFAFDGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public readonly int IBGJKIKBACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private string KMDINGLHODE;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[NotNull]
	public string EHMBCOCMLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x572220", Offset = "0x570820", VA = "0x180572220")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3A03B00", Offset = "0x3A02100", VA = "0x183A03B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public long KAAGFEFILCK
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3A038A0", Offset = "0x3A01EA0", VA = "0x183A038A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public int MEJOCMKLGMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3A03AD0", Offset = "0x3A020D0", VA = "0x183A03AD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x3A04370", Offset = "0x3A02970", VA = "0x183A04370")]
	public OFKOAFMHNFG([Optional] int? HKAAKKEEGCK, [Optional][CanBeNull] Stopwatch ODAEFAFDGKE, [Optional] Action<TKey, GFOOEOAFMNK> JGIKMNABAKP, [Optional] Action<TKey, GFOOEOAFMNK> GOMCOPKOLNG, [Optional] Action<global::OFKOAFMHNFG<TKey>> POKBCIFJMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x3A038C0", Offset = "0x3A01EC0", VA = "0x183A038C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x3A040F0", Offset = "0x3A026F0", VA = "0x183A040F0")]
	public void KBOJIKDOCLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x3A04110", Offset = "0x3A02710", VA = "0x183A04110")]
	public void MGFOIONEGHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x3A03B60", Offset = "0x3A02160", VA = "0x183A03B60")]
	public static global::EJAKMHICFJG<global::OFKOAFMHNFG<TKey>, TKey> IGNMNINCJJA(global::OFKOAFMHNFG<TKey> NJKJIAHPBGG, [Optional] Action<global::OFKOAFMHNFG<TKey>> FIMALGOHGFN)
	{
		return default(global::EJAKMHICFJG<global::OFKOAFMHNFG<TKey>, TKey>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x3A04130", Offset = "0x3A02730", VA = "0x183A04130")]
	[IteratorStateMachine(typeof(global::OFKOAFMHNFG<>.LBEPIFIKJFK))]
	public IEnumerable<(TKey, List<TKey>, GFOOEOAFMNK)> MMHAEDFJICJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x3A041C0", Offset = "0x3A027C0", VA = "0x183A041C0")]
	[IteratorStateMachine(typeof(global::OFKOAFMHNFG<>.ALKGHKEPHLP))]
	private IEnumerable<(TKey, List<TKey>, GFOOEOAFMNK)> MMHAEDFJICJ(List<TKey> IOMEMFDDFKN, KAFADAKMGEJ OCEMDBEMHGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x3A03810", Offset = "0x3A01E10", VA = "0x183A03810")]
	private (long, int) DFDLHLMCONB()
	{
		return default((long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x3A03CB0", Offset = "0x3A022B0", VA = "0x183A03CB0")]
	public void IPJAPPENFFG(TKey MKDJIBNCKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x3A03FC0", Offset = "0x3A025C0", VA = "0x183A03FC0")]
	public void JCNIFFINAOH(TKey MKDJIBNCKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x3A03930", Offset = "0x3A01F30", VA = "0x183A03930")]
	public void EENFABPJAEN(TKey MKDJIBNCKNC, Action BKCLKIJOKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x1E25A70", Offset = "0x1E24070", VA = "0x181E25A70")]
	public T EENFABPJAEN<T>(TKey MKDJIBNCKNC, Func<T> PMOCGMLKNMF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2648D70", Offset = "0x2647370", VA = "0x182648D70")]
	[AsyncStateMachine(typeof(OKAGMPFPMHM))]
	public Task<T> GEDOGAHNNOH<T>(TKey MKDJIBNCKNC, Func<Task<T>> PMOCGMLKNMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x3A04290", Offset = "0x3A02890", VA = "0x183A04290")]
	public GAAMEIHCBEJ NNDPDJEFNNJ(TKey MKDJIBNCKNC)
	{
		return default(GAAMEIHCBEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct EJAKMHICFJG<T, TKey> : IDisposable where T : global::OFKOAFMHNFG<TKey>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly bool GJBGKJMHPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly T NJKJIAHPBGG;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T EDLAIOGHJEM
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8620C0", Offset = "0x8606C0", VA = "0x1808620C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x3931D00", Offset = "0x3930300", VA = "0x183931D00")]
	internal EJAKMHICFJG(T NJKJIAHPBGG, bool GJBGKJMHPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x3931C70", Offset = "0x3930270", VA = "0x183931C70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class NEENKHHGHBI<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut PMODPMPGJCC(global::OFKOAFMHNFG<TKey> NJKJIAHPBGG);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
	protected NEENKHHGHBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class PIGKEPMLPOB<TKey> : global::NEENKHHGHBI<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public delegate string CHEOEAHCNAI(TKey MKDJIBNCKNC);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x30A92E0", Offset = "0x30A78E0", VA = "0x1830A92E0")]
	protected string LDHBOIDACNE(double GJHDGCCEIIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x30A9550", Offset = "0x30A7B50", VA = "0x1830A9550")]
	protected string PONBILAPHMC(int MDKMMIJFACN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x30A9340", Offset = "0x30A7940", VA = "0x1830A9340")]
	private static string LIAGICPEDGN(TKey MKDJIBNCKNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x30A9380", Offset = "0x30A7980", VA = "0x1830A9380", Slot = "4")]
	public override string PMODPMPGJCC(global::OFKOAFMHNFG<TKey> NJKJIAHPBGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x30A9430", Offset = "0x30A7A30", VA = "0x1830A9430")]
	public string PMODPMPGJCC(global::OFKOAFMHNFG<TKey> NJKJIAHPBGG, [NotNull] CHEOEAHCNAI LAPBLIHFJBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string NBMPLJFPNMO(global::OFKOAFMHNFG<TKey> NJKJIAHPBGG, [NotNull] CHEOEAHCNAI LAPBLIHFJBE);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x1C6B390", Offset = "0x1C69990", VA = "0x181C6B390")]
	protected PIGKEPMLPOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class IPICOLPPEIF<TKey> : global::NEENKHHGHBI<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public delegate string JGOLFIMBEFD(TKey MKDJIBNCKNC);

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private const int HHNAKIEGJEG = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly string GMJFGFMPIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly double ONLHLNLLDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly bool ILJNKGLNPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly int CEGOKMIOHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly ISet<string> DMIMMEKEJFP;

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x3855AB0", Offset = "0x38540B0", VA = "0x183855AB0")]
	private static string LIAGICPEDGN(TKey MKDJIBNCKNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x38563B0", Offset = "0x38549B0", VA = "0x1838563B0")]
	public IPICOLPPEIF(string GMJFGFMPIBL = "F2", double ONLHLNLLDLA = double.MaxValue, bool ILJNKGLNPGL = false, int CEGOKMIOHOH = int.MaxValue, [Optional] ISet<string> DMIMMEKEJFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x3855C50", Offset = "0x3854250", VA = "0x183855C50", Slot = "4")]
	public override Dictionary<string, string> PMODPMPGJCC(global::OFKOAFMHNFG<TKey> NJKJIAHPBGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x38559D0", Offset = "0x3853FD0", VA = "0x1838559D0")]
	private bool LGDEJJINMBO(string MAHCNJKPHIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x3855D00", Offset = "0x3854300", VA = "0x183855D00")]
	public Dictionary<string, string> PMODPMPGJCC(global::OFKOAFMHNFG<TKey> NJKJIAHPBGG, JGOLFIMBEFD LAPBLIHFJBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x3856200", Offset = "0x3854800", VA = "0x183856200")]
	private string POEGEADKDDK(StringBuilder LIJIGAEHALJ, List<TKey> ABJCNILCPJF, JGOLFIMBEFD LAPBLIHFJBE, bool KDHHOECMFHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x3855AF0", Offset = "0x38540F0", VA = "0x183855AF0")]
	private static void PBKIFOIFNGN(StringBuilder MLKNFIIGCNN, string DECPLGNFEFA, bool OOKDMEBILDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class HANIOLCKDAG<TKey> : global::PIGKEPMLPOB<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct AMMODKMNGOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public CHEOEAHCNAI keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static global::HANIOLCKDAG<TKey> NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int ELONLOJLKFP = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly string[] AEALPEELOOB;

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x3A30270", Offset = "0x3A2E870", VA = "0x183A30270")]
	private HANIOLCKDAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x3A2F2B0", Offset = "0x3A2D8B0", VA = "0x183A2F2B0", Slot = "5")]
	protected override string NBMPLJFPNMO(global::OFKOAFMHNFG<TKey> NJKJIAHPBGG, CHEOEAHCNAI LAPBLIHFJBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x3A2F1D0", Offset = "0x3A2D7D0", VA = "0x183A2F1D0")]
	[CompilerGenerated]
	internal static string JHBMENLBJJM(string BCEKFABBDJE, TKey MKDJIBNCKNC, ref AMMODKMNGOJ P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class ADBEFCALLFJ<TKey> : global::PIGKEPMLPOB<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class PKCFPJLKCIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public CHEOEAHCNAI keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		public PKCFPJLKCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x1ECC8D0", Offset = "0x1ECAED0", VA = "0x181ECC8D0")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x210BAF0", Offset = "0x210A0F0", VA = "0x18210BAF0", Slot = "5")]
	protected override string NBMPLJFPNMO(global::OFKOAFMHNFG<TKey> NJKJIAHPBGG, CHEOEAHCNAI LAPBLIHFJBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x210C240", Offset = "0x210A840", VA = "0x18210C240")]
	public ADBEFCALLFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public abstract class NHFJKNGOAGN
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private class MILIBNLKNOF : NHFJKNGOAGN
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static NHFJKNGOAGN NNHENCBEIJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x4DE0740", Offset = "0x4DDED40", VA = "0x184DE0740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime NCNDHGHHKHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x4DE06F0", Offset = "0x4DDECF0", VA = "0x184DE06F0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float NOLLPMMLKJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x4DE06E0", Offset = "0x4DDECE0", VA = "0x184DE06E0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x4DE0840", Offset = "0x4DDEE40", VA = "0x184DE0840")]
		public MILIBNLKNOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static NHFJKNGOAGN OKFEOJBPJBJ;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static NHFJKNGOAGN KAKLFEMJBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x4DE0A30", Offset = "0x4DDF030", VA = "0x184DE0A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime NCNDHGHHKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float NOLLPMMLKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	protected NHFJKNGOAGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class PJBLBLCHIFH : global::AHJIKHKMCDI<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x4DE2790", Offset = "0x4DE0D90", VA = "0x184DE2790")]
	public PJBLBLCHIFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class AHJIKHKMCDI<T> : global::JCLACCKFIDM<T>, LGAPFCEPPIC, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> JCFIGADOAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task COONIMNAIIB
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x1C65D00", Offset = "0x1C64300", VA = "0x181C65D00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::DBIKMJJJBLJ<T> GKHIOGLLJDF
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private APPFHLGLKJA EKNOALKKOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x1C6ACE0", Offset = "0x1C692E0", VA = "0x181C6ACE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x268E850", Offset = "0x268CE50", VA = "0x18268E850")]
	public AHJIKHKMCDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class FHJAKKGBEKJ : global::FCEOCOBEBDJ<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x4DDF200", Offset = "0x4DDD800", VA = "0x184DDF200")]
	public FHJAKKGBEKJ(Exception BACBMFCMEGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class FCEOCOBEBDJ<T> : global::JCLACCKFIDM<T>, LGAPFCEPPIC, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> JCFIGADOAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task COONIMNAIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1C65D00", Offset = "0x1C64300", VA = "0x181C65D00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::DBIKMJJJBLJ<T> GKHIOGLLJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private APPFHLGLKJA EKNOALKKOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1C6ACE0", Offset = "0x1C692E0", VA = "0x181C6ACE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x296B340", Offset = "0x2969940", VA = "0x18296B340")]
	public FCEOCOBEBDJ(Exception BACBMFCMEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface LGAPFCEPPIC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task JCFIGADOAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	APPFHLGLKJA GKHIOGLLJDF
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface JCLACCKFIDM<T> : LGAPFCEPPIC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> JCFIGADOAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::DBIKMJJJBLJ<T> GKHIOGLLJDF
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class GHGFFGBOLOB<TTask, T> : global::JCLACCKFIDM<T>, LGAPFCEPPIC, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class JGIBIEMKEBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public global::GHGFFGBOLOB<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		public JGIBIEMKEBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static bool AGNHLHEAKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly Task<T> IPFPIIBOBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	protected readonly CancellationTokenSource LJJFJBNCDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private bool PGGNJMMOIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private SynchronizationContext HIHNLMOEPDP;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> JCFIGADOAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task COONIMNAIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::DBIKMJJJBLJ<T> GKHIOGLLJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private APPFHLGLKJA EKNOALKKOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x209F570", Offset = "0x209DB70", VA = "0x18209F570", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool FAIGJIHBAPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x5E1990", Offset = "0x5DFF90", VA = "0x1805E1990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x32D5110", Offset = "0x32D3710", VA = "0x1832D5110")]
	static GHGFFGBOLOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x32D53F0", Offset = "0x32D39F0", VA = "0x1832D53F0")]
	protected GHGFFGBOLOB(TTask IPFPIIBOBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x32D4D90", Offset = "0x32D3390", VA = "0x1832D4D90", Slot = "1")]
	~GHGFFGBOLOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x32D4CC0", Offset = "0x32D32C0", VA = "0x1832D4CC0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x32D4E30", Offset = "0x32D3430", VA = "0x1832D4E30")]
	private void HLHLNLIFMIH(bool PAKHJBEPDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T FMPKNFLALEF(TTask COJLNPLMJBD);

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void LOEEBHLGKFG();

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x32D4C70", Offset = "0x32D3270", VA = "0x1832D4C70")]
	[CompilerGenerated]
	private void APOEOAEHPEO(object JIGKFMMLBHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class EFODBOGLLLN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public readonly Type JNGKNCDPJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public readonly string LHMNCCJEFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public readonly bool IDEEADDIBHF;

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x4DDEF20", Offset = "0x4DDD520", VA = "0x184DDEF20")]
	public EFODBOGLLLN(Type JFOHOJCMPFN, string HEJPHGDJLFJ, bool EHJILPCPPNA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class NBBKMLMEKOJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x4DE09C0", Offset = "0x4DDEFC0", VA = "0x184DE09C0")]
	public NBBKMLMEKOJ(string EPAKPJCIEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0940", Offset = "0x4DDEF40", VA = "0x184DE0940")]
	public NBBKMLMEKOJ(string EPAKPJCIEHE, Exception AIBMBKKNCHD)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x560ED0", Offset = "0x55F4D0", VA = "0x180560ED0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x584710", Offset = "0x582D10", VA = "0x180584710")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public T this[int CKOCCIDDCLA, int ECEAAAFOIBE]
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x1E2AD90", Offset = "0x1E29390", VA = "0x181E2AD90")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x1E2AE30", Offset = "0x1E29430", VA = "0x181E2AE30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x1E2AD00", Offset = "0x1E29300", VA = "0x181E2AD00")]
		public Array2D(uint KIDBPFAHLEE, uint CNJPPLLLBHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x1E2AC80", Offset = "0x1E29280", VA = "0x181E2AC80")]
		public void CGFAFPCCKIC()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x4DDDE30", Offset = "0x4DDC430", VA = "0x184DDDE30")]
		public Array2DVector3(uint KIDBPFAHLEE, uint CNJPPLLLBHD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal static class CKNFOJAGOKK
{
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public const int DLGGHJMPCIC = -1;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public const int NAKJBFKGCJO = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DefaultMember("Item")]
public class NGOAGBPGLJE<THandle, TValue> : IDisposable where THandle : struct, HIOBFMFHHNO where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly List<THandle> HLDMDPPGMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly List<TValue> FLJHHGNBDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Func<TValue> NMHAGANEFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly Action<TValue> KEALOEJJNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private int HHJICIDPDCE;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public TValue NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x2695660", Offset = "0x2693C60", VA = "0x182695660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x3434580", Offset = "0x3432B80", VA = "0x183434580")]
	public NGOAGBPGLJE(Action<TValue> KEALOEJJNAA, [Optional] Func<TValue> NMHAGANEFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x3433B50", Offset = "0x3432150", VA = "0x183433B50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x3433E60", Offset = "0x3432460", VA = "0x183433E60")]
	public THandle GPCBEJLMGEM()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x3434350", Offset = "0x3432950", VA = "0x183434350")]
	public THandle NENJMCKJAJO(TValue MPHFKGJNMOK)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x3434250", Offset = "0x3432850", VA = "0x183434250")]
	public bool MNHCGCIEOKP(THandle JDOONLDLMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x34344A0", Offset = "0x3432AA0", VA = "0x1834344A0")]
	public bool PILHJPINMMC(THandle JDOONLDLMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x34343C0", Offset = "0x34329C0", VA = "0x1834343C0")]
	public bool ODOHFJDGPNB(THandle JDOONLDLMNB, out TValue MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x3434300", Offset = "0x3432900", VA = "0x183434300")]
	public TValue NELNIMGBJDL(THandle JDOONLDLMNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x3433A60", Offset = "0x3432060", VA = "0x183433A60")]
	public bool BCEGDDCILHE(THandle JDOONLDLMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x3434470", Offset = "0x3432A70", VA = "0x183434470")]
	private THandle OHINCNKNFHF(int HOOANEAGKNH)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x3433BD0", Offset = "0x34321D0", VA = "0x183433BD0")]
	private TValue EKBBEKNBECD(int HOOANEAGKNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x3433B10", Offset = "0x3432110", VA = "0x183433B10")]
	private void DOKIDABGIKC(int HOOANEAGKNH, in THandle JDOONLDLMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x3433D80", Offset = "0x3432380", VA = "0x183433D80")]
	private void GOMBGNICLJL(int HOOANEAGKNH, in TValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x3433FB0", Offset = "0x34325B0", VA = "0x183433FB0")]
	private THandle HPODAFDFNFN()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x3434190", Offset = "0x3432790", VA = "0x183434190")]
	private void LCAANIAOGGP(THandle JDOONLDLMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x3433FA0", Offset = "0x34325A0", VA = "0x183433FA0")]
	private int HLLBFPOFIMD(int MNOJMAIICKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x3434460", Offset = "0x3432A60", VA = "0x183434460")]
	private bool OGDCOGGMFMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5B19A0", Offset = "0x5AFFA0", VA = "0x1805B19A0")]
	private void AMEHBEDAPLO(THandle JDOONLDLMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x34339E0", Offset = "0x3431FE0", VA = "0x1834339E0")]
	private bool ADLPOELHGCD(out THandle JDOONLDLMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x34340C0", Offset = "0x34326C0", VA = "0x1834340C0")]
	private bool JMEODAEKGND(out THandle JDOONLDLMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x3433C00", Offset = "0x3432200", VA = "0x183433C00")]
	private void GAHODKPOCKI(THandle JDOONLDLMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x3433C60", Offset = "0x3432260", VA = "0x183433C60")]
	private void GEAMEIPHNEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface HIOBFMFHHNO
{
	[Cpp2IlInjected.Token(Token = "0x17000076")]
	int OOODCJOIDPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	int BGIBIINMANG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface IBNHPOIIGBN<T> : HIOBFMFHHNO, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class OBODLAKFOCE
{
	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x1EF77B0", Offset = "0x1EF5DB0", VA = "0x181EF77B0")]
	public static bool PEKIMJGAHDI<T>(this T JDOONLDLMNB) where T : struct, HIOBFMFHHNO
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class OCGNCOEEANA
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private enum NOGMLHFBLEP : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private int NPNGOLKAOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private bool GMCFBENGBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private NOGMLHFBLEP HMGOCFOIBEE;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public bool PGNEIIMMCHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x4DE0DA0", Offset = "0x4DDF3A0", VA = "0x184DE0DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool KJPPGFPIMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x4DE1500", Offset = "0x4DDFB00", VA = "0x184DE1500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1990", Offset = "0x4DDFF90", VA = "0x184DE1990")]
	public OCGNCOEEANA(bool GMCFBENGBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0DC0", Offset = "0x4DDF3C0", VA = "0x184DE0DC0")]
	public void CKGMELJJGCG(object FIEDOLNFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0CF0", Offset = "0x4DDF2F0", VA = "0x184DE0CF0")]
	public void CBJOFMOBAGP(int MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1940", Offset = "0x4DDFF40", VA = "0x184DE1940")]
	public void OAFNBGMKADI(uint PMPFHJPGCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0BB0", Offset = "0x4DDF1B0", VA = "0x184DE0BB0")]
	public void APNDMJJNFGO(bool MJNLGMBFHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1950", Offset = "0x4DDFF50", VA = "0x184DE1950")]
	public void OAGJHDGEKGP(long JAMCMBENHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x4DE14C0", Offset = "0x4DDFAC0", VA = "0x184DE14C0")]
	public void LKAKFDNMABH(ulong AKGOEMFCLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1350", Offset = "0x4DDF950", VA = "0x184DE1350")]
	public void GBIPJNGEOHM(string IOLGJHAFBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1430", Offset = "0x4DDFA30", VA = "0x184DE1430")]
	public void KOCNCDBNHGN(Enum BACBMFCMEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0BD0", Offset = "0x4DDF1D0", VA = "0x184DE0BD0")]
	public void BAOHNILAFHG(IList EJCFBHKFPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x2F303B0", Offset = "0x2F2E9B0", VA = "0x182F303B0")]
	public void GAKNIMDGPKE<T, U>(Dictionary<T, U> JFPAPBLAAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1580", Offset = "0x4DDFB80", VA = "0x184DE1580")]
	private void NHFJJDNGDKP(IDictionary JFPAPBLAAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x4DE12E0", Offset = "0x4DDF8E0", VA = "0x184DE12E0")]
	public int FKOIBIPNLKP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1510", Offset = "0x4DDFB10", VA = "0x184DE1510")]
	public short MOPPMFJKDOK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0DB0", Offset = "0x4DDF3B0", VA = "0x184DE0DB0")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x4DE13C0", Offset = "0x4DDF9C0", VA = "0x184DE13C0")]
	private void HIPINLMMBAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public abstract class AEOLALLGKEO<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	internal class CIKFCFIJNCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public TNode GNFIGHOBONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public TNode COLFLONKFJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public LJEHGKOLACE OGIOFICPCOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public List<LJEHGKOLACE> ODGFPDNHIPP;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		public CIKFCFIJNCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	internal struct LJEHGKOLACE : IComparable<LJEHGKOLACE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int MBHEGCHNPDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public TClaimant APHPCLKAACF;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x568CF0", Offset = "0x5672F0", VA = "0x180568CF0")]
		public LJEHGKOLACE(int MBHEGCHNPDE, TClaimant APHPCLKAACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x2116900", Offset = "0x2114F00", VA = "0x182116900")]
		public bool BAKDKFBHCKN(in LJEHGKOLACE GJPJDOANCNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x2116970", Offset = "0x2114F70", VA = "0x182116970")]
		public bool JONLKKKFGBI(in LJEHGKOLACE GJPJDOANCNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x2116960", Offset = "0x2114F60", VA = "0x182116960", Slot = "4")]
		public int CompareTo(LJEHGKOLACE GJPJDOANCNK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x2116980", Offset = "0x2114F80", VA = "0x182116980", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public enum BIHPEGCAPGK
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class ODMCLGGPHFM : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public global::AEOLALLGKEO<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x1ECA960", Offset = "0x1EC8F60", VA = "0x181ECA960")]
		[DebuggerHidden]
		public ODMCLGGPHFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2119680", Offset = "0x2117C80", VA = "0x182119680", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x2119840", Offset = "0x2117E40", VA = "0x182119840", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2119760", Offset = "0x2117D60", VA = "0x182119760", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x1C6BCA0", Offset = "0x1C6A2A0", VA = "0x181C6BCA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly global::HBJLICKFJIO<CIKFCFIJNCG> HHMDIGGALIM;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly global::HBJLICKFJIO<List<LJEHGKOLACE>> CPBJJALNGKB;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static int BDOKFKNNLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	internal readonly Dictionary<TClaimant, TNode> OHAIKHNEINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	internal readonly Dictionary<TNode, CIKFCFIJNCG> LHCNKJGDGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private BIHPEGCAPGK EAPLEPGNBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private bool ECMCAACONHH;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode KEOGLGFJKMO(TNode BOKLJENJLOP);

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void OCOCJFLDOPD(TNode BOKLJENJLOP, TClaimant CJPNLCMLIKI, TClaimant DJLBBEJBKHM);

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x210DAD0", Offset = "0x210C0D0", VA = "0x18210DAD0")]
	public AEOLALLGKEO(BIHPEGCAPGK EAPLEPGNBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x210C850", Offset = "0x210AE50", VA = "0x18210C850")]
	public void BPGJJNCCNJI(TNode BOKLJENJLOP, TNode GLGDDCPCPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x210CD00", Offset = "0x210B300", VA = "0x18210CD00")]
	public void IAMCHPFMBHP(TClaimant APHPCLKAACF, TNode JAFNCECJODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x210C940", Offset = "0x210AF40", VA = "0x18210C940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x210C7B0", Offset = "0x210ADB0", VA = "0x18210C7B0")]
	private void BMDJNPILBEH(TClaimant APHPCLKAACF, TNode PLJILEIJPGP, TNode JAFNCECJODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x210C8D0", Offset = "0x210AED0", VA = "0x18210C8D0")]
	private int CLDICIIOBNI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x210CE00", Offset = "0x210B400", VA = "0x18210CE00")]
	private void IPHHBBAOKKJ(TClaimant APHPCLKAACF, TNode AFNDIAJPOAN, TNode KOAFJALDAFB, int BHCLMPNOLIG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x210CBA0", Offset = "0x210B1A0", VA = "0x18210CBA0")]
	private void GAOLEENJAJI(LJEHGKOLACE DBEMPPMLEHC, CIKFCFIJNCG AAAFOBDFEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x210D540", Offset = "0x210BB40", VA = "0x18210D540")]
	private void PBLMJDFOONJ(TClaimant APHPCLKAACF, TNode AFNDIAJPOAN, TNode KOAFJALDAFB, int BHCLMPNOLIG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x210C6B0", Offset = "0x210ACB0", VA = "0x18210C6B0")]
	private void ANOAOFDGOAK(LJEHGKOLACE DBEMPPMLEHC, TNode BOKLJENJLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x210D870", Offset = "0x210BE70", VA = "0x18210D870")]
	private void PNDDBFPJCKL(LJEHGKOLACE DBEMPPMLEHC, CIKFCFIJNCG AAAFOBDFEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x210D400", Offset = "0x210BA00", VA = "0x18210D400")]
	private void NMEHKPKACFM(CIKFCFIJNCG AAAFOBDFEMH, bool PGLJPKEDFGD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x210C270", Offset = "0x210A870", VA = "0x18210C270")]
	private void AJBJKALEHCE(CIKFCFIJNCG AAAFOBDFEMH, TNode GLGDDCPCPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x210CC30", Offset = "0x210B230", VA = "0x18210CC30")]
	[IteratorStateMachine(typeof(global::AEOLALLGKEO<, >.ODMCLGGPHFM))]
	private IEnumerable<TNode> GKKKHMFDPEP(TNode AFNDIAJPOAN, TNode KOAFJALDAFB, bool CAKLNPJIFKH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x210D7B0", Offset = "0x210BDB0", VA = "0x18210D7B0")]
	private CIKFCFIJNCG PDBMDAKBCKJ(TNode BOKLJENJLOP, TNode COLFLONKFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x210D270", Offset = "0x210B870", VA = "0x18210D270")]
	private CIKFCFIJNCG MLLBJKGABMM(TNode BOKLJENJLOP, TNode COLFLONKFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x210D0B0", Offset = "0x210B6B0", VA = "0x18210D0B0")]
	private void KBJKINPPCDM(CIKFCFIJNCG AAAFOBDFEMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class IGGDGPNFHDG<T> : IEnumerable<global::IGGDGPNFHDG<T>.OMELAKCGOAG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public struct OMELAKCGOAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public T MPHFKGJNMOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int HOOANEAGKNH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class CBMDMACNNGJ : IEnumerator<OMELAKCGOAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private global::IGGDGPNFHDG<T> HGLPMHHCNKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private int HOOANEAGKNH;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x262BE60", Offset = "0x262A460", VA = "0x18262BE60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public OMELAKCGOAG ANMAFMODJCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x2F31670", Offset = "0x2F2FC70", VA = "0x182F31670", Slot = "4")]
			get
			{
				return default(OMELAKCGOAG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8568E0", Offset = "0x854EE0", VA = "0x1808568E0")]
		public CBMDMACNNGJ(global::IGGDGPNFHDG<T> HGLPMHHCNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x2F315E0", Offset = "0x2F2FBE0", VA = "0x182F315E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x7D9520", Offset = "0x7D7B20", VA = "0x1807D9520", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x893540", Offset = "0x891B40", VA = "0x180893540", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private struct CCNCNADPILI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public bool PEEJEHPIILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public T MPHFKGJNMOK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private const int NPAINHCLJIB = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Dictionary<T, int> JFLOKGHEKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private CCNCNADPILI[] KLJPADGFFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private int FPAOMGALAAK;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x1EBAFF0", Offset = "0x1EB95F0", VA = "0x181EBAFF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2F37280", Offset = "0x2F35880", VA = "0x182F37280")]
	public static global::IGGDGPNFHDG<T> EDIEEHOLKNH(OMELAKCGOAG[] FPDDLLOHFAD, bool BHJODBGOKGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x2F37DF0", Offset = "0x2F363F0", VA = "0x182F37DF0")]
	public IGGDGPNFHDG(int NKJBJGFALMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x287E950", Offset = "0x287CF50", VA = "0x18287E950")]
	public bool OOHILGBIADI(T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x2F378F0", Offset = "0x2F35EF0", VA = "0x182F378F0")]
	public bool HJNFPPBJHAH(int HOOANEAGKNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x2F376D0", Offset = "0x2F35CD0", VA = "0x182F376D0")]
	public bool FECGJJAPIMF(Func<T, bool> CJHEFBNLMBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x2F37D20", Offset = "0x2F36320", VA = "0x182F37D20")]
	public int ODFAONLHFEP(T MPHFKGJNMOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2F37660", Offset = "0x2F35C60", VA = "0x182F37660")]
	public T EKBBEKNBECD(int HOOANEAGKNH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2F371E0", Offset = "0x2F357E0", VA = "0x182F371E0")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2F37BD0", Offset = "0x2F361D0", VA = "0x182F37BD0")]
	public bool LHNHAJKKNNC(T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2F379A0", Offset = "0x2F35FA0", VA = "0x182F379A0")]
	public bool LHNHAJKKNNC(T MPHFKGJNMOK, int HOOANEAGKNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2F37BF0", Offset = "0x2F361F0", VA = "0x182F37BF0")]
	public bool MNHCGCIEOKP(T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x2F37230", Offset = "0x2F35830", VA = "0x182F37230")]
	public bool DPNMENBOJNI(int HOOANEAGKNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2F37C70", Offset = "0x2F36270", VA = "0x182F37C70")]
	private void NCMECPNLCLN(int HOOANEAGKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x2F37780", Offset = "0x2F35D80", VA = "0x182F37780")]
	public OMELAKCGOAG[] GPKIFPIDNBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2F37950", Offset = "0x2F35F50", VA = "0x182F37950")]
	private int HNFNEIIKKDM(int AHNBCGDLBJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2F37D70", Offset = "0x2F36370", VA = "0x182F37D70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2F37D70", Offset = "0x2F36370", VA = "0x182F37D70", Slot = "4")]
	private IEnumerator<OMELAKCGOAG> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class HBJLICKFJIO<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly Stack<T> POMAOKDAOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly List<T> IAONPJKHHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly int HNGMFADIDIM;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public int JIFKAMGGOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E690", Offset = "0x1E2CC90", VA = "0x181E2E690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public int BBINKLLEGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x1E31EB0", Offset = "0x1E304B0", VA = "0x181E31EB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x278BC80", Offset = "0x278A280", VA = "0x18278BC80")]
	public static global::HBJLICKFJIO<T> LGPDCOMIHKC(int NKJBJGFALMO = 0, int HNGMFADIDIM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x278B830", Offset = "0x2789E30", VA = "0x18278B830")]
	public static global::HBJLICKFJIO<T> HCNLPGGLAFD(int NKJBJGFALMO = 0, int HNGMFADIDIM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x278C0C0", Offset = "0x278A6C0", VA = "0x18278C0C0")]
	public HBJLICKFJIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x278BF30", Offset = "0x278A530", VA = "0x18278BF30")]
	public HBJLICKFJIO(int NKJBJGFALMO, int HNGMFADIDIM = int.MaxValue, bool ADCKDHJDAFH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x278BE00", Offset = "0x278A400", VA = "0x18278BE00")]
	public T MJHEFBCDFIC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x278BB20", Offset = "0x278A120", VA = "0x18278BB20")]
	public void JFHMBJGHKHM(T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x278B640", Offset = "0x2789C40", VA = "0x18278B640")]
	private void DDPIABHMCGA(T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x278B700", Offset = "0x2789D00", VA = "0x18278B700")]
	private void DPIAOBNHBMM(T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x278BBE0", Offset = "0x278A1E0", VA = "0x18278BBE0")]
	[Conditional("DEBUG_BUILD")]
	private void JKGMMNHLNHG(T MNCDJFFLIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x278BD50", Offset = "0x278A350", VA = "0x18278BD50")]
	[Conditional("DEBUG_BUILD")]
	private void LOJEOMDGEPE(T MNCDJFFLIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x278B720", Offset = "0x2789D20", VA = "0x18278B720", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x278B900", Offset = "0x2789F00", VA = "0x18278B900")]
	private void IDGEHDPJLHN(IEnumerable<T> FLJHHGNBDOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class JCAOLIJBJIG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private Dictionary<int, T> MICECLKMJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private T EAKKGKOPNGO;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public virtual T PIMAENKOLPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x5604A0", Offset = "0x55EAA0", VA = "0x1805604A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public bool HGAIKDNEBJH
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x385A610", Offset = "0x3858C10", VA = "0x18385A610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x385A710", Offset = "0x3858D10", VA = "0x18385A710")]
	public bool EMKENJFOCJF(T MPHFKGJNMOK, int MBHEGCHNPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x385A770", Offset = "0x3858D70", VA = "0x18385A770")]
	public bool OKFFAJCGNAA(int MBHEGCHNPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x385A210", Offset = "0x3858810", VA = "0x18385A210")]
	public T AJLPACBHFDJ(int PDDEBBLBPFE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x385A650", Offset = "0x3858C50", VA = "0x18385A650")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x385A470", Offset = "0x3858A70", VA = "0x18385A470")]
	private bool ALMLKFCILGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x3859F70", Offset = "0x3858570", VA = "0x183859F70")]
	public bool ACEOCCKNHLM(int MBHEGCHNPDE, out T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x20B6C80", Offset = "0x20B5280", VA = "0x1820B6C80")]
	public JCAOLIJBJIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class NOLFCOFOKDD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	protected struct AIMGGENLJDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public T NLLJAAOBNLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public int EIHHJJJMHFB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected readonly List<AIMGGENLJDI> CMMPHNBJIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private T KLEPABGADJC;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x1E33150", Offset = "0x1E31750", VA = "0x181E33150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x33A1810", Offset = "0x339FE10", VA = "0x1833A1810")]
	public bool FECGJJAPIMF(T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x33A1E90", Offset = "0x33A0490", VA = "0x1833A1E90")]
	public void NENJMCKJAJO(T MPHFKGJNMOK, int MBHEGCHNPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x33A1D70", Offset = "0x33A0370", VA = "0x1833A1D70")]
	public bool MNHCGCIEOKP(T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x33A17B0", Offset = "0x339FDB0", VA = "0x1833A17B0")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x33A1AD0", Offset = "0x33A00D0", VA = "0x1833A1AD0")]
	public T JAGIABOOFFF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x33A1A60", Offset = "0x33A0060", VA = "0x1833A1A60")]
	public T IMCOKFECAJL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x33A1B60", Offset = "0x33A0160", VA = "0x1833A1B60")]
	private void JNFFAFGDLCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x33A1F30", Offset = "0x33A0530", VA = "0x1833A1F30")]
	public NOLFCOFOKDD()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		[DPGOFBBDGFL(BHKPCKHAKLF.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x4DE29B0", Offset = "0x4DE0FB0", VA = "0x184DE29B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x4DE2E80", Offset = "0x4DE1480", VA = "0x184DE2E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x4DE2CA0", Offset = "0x4DE12A0", VA = "0x184DE2CA0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x4DE3020", Offset = "0x4DE1620", VA = "0x184DE3020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x4DE2870", Offset = "0x4DE0E70", VA = "0x184DE2870")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x4DE2D40", Offset = "0x4DE1340", VA = "0x184DE2D40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x4DE2B60", Offset = "0x4DE1160", VA = "0x184DE2B60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x4DE27D0", Offset = "0x4DE0DD0", VA = "0x184DE27D0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public interface LBFEGJJCJFN
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public abstract class ResourcePrefabReference<T> : LBFEGJJCJFN where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x1E3EBB0", Offset = "0x1E3D1B0", VA = "0x181E3EBB0", Slot = "4")]
		public virtual T NIGJJKMIMDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public class ONEFOGDEHAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly Dictionary<byte, BCANKGNNLEN> ABOPCPNAHHA;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public BCANKGNNLEN CIPJIDIBMFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x560490", Offset = "0x55EA90", VA = "0x180560490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public Vector2 CFKDGHHHKDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x13EE830", Offset = "0x13ECE30", VA = "0x1813EE830")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x26919E0", Offset = "0x268FFE0", VA = "0x1826919E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public Vector2 CKIDIEPAOKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x15262D0", Offset = "0x15248D0", VA = "0x1815262D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x1526360", Offset = "0x1524960", VA = "0x181526360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public Vector2 LEEHIAMABPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x4DE2010", Offset = "0x4DE0610", VA = "0x184DE2010")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x4DE1FF0", Offset = "0x4DE05F0", VA = "0x184DE1FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public int MKHGFABMIIE
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x58B7E0", Offset = "0x589DE0", VA = "0x18058B7E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x5B19A0", Offset = "0x5AFFA0", VA = "0x1805B19A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x4DE2270", Offset = "0x4DE0870", VA = "0x184DE2270")]
	public ONEFOGDEHAG(Bounds CDMOGCAFJND, Vector2[] PHHIOALDPMO, int DEOECBAJIEB, byte AHNBCGDLBJF, float LEJDKEPHMOP = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1F90", Offset = "0x4DE0590", VA = "0x184DE1F90")]
	public BCANKGNNLEN DBMIGCNEALN(byte HOOANEAGKNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x4DE2160", Offset = "0x4DE0760", VA = "0x184DE2160")]
	public void MMCFJHLLEMF(Vector3 MMBOHLJHNFP, float IJDDGCJPOKN, float NLHEGDALIJI, ref List<byte> JCGDDOPINCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x4DE2250", Offset = "0x4DE0850", VA = "0x184DE2250")]
	public void PCODIJLCAII(BCANKGNNLEN.IOIDGLJCNKF APJKFAJNHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x4DE2030", Offset = "0x4DE0630", VA = "0x184DE2030")]
	private BCANKGNNLEN LAOJBKDLCNJ(byte HOOANEAGKNH, BCANKGNNLEN.CDLPJMLCJNM MKMCBPHHFNB, BCANKGNNLEN COLFLONKFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1A70", Offset = "0x4DE0070", VA = "0x184DE1A70")]
	private void ABCBALLFEAF(BCANKGNNLEN COLFLONKFJK, Vector2[] PHHIOALDPMO, int CKNACIINEAJ, int MEFEGPBJPPP, int KCKKHEFDDEF, int JOFIBFAADKM, float LEJDKEPHMOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public class BCANKGNNLEN
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public enum CDLPJMLCJNM
	{
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public enum IOIDGLJCNKF
	{
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public byte INMFENJMHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public Vector3 KAMMCENCMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public Vector3 OJCJOGAFMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public Vector3 EMDJBDGNOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public Vector3 FEAIEIDFDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public CDLPJMLCJNM LFKJANJNKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public BCANKGNNLEN ANDKMGNGEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public List<BCANKGNNLEN> CFNALLDDAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public bool CEMBLDJLPPG;

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x4DDE600", Offset = "0x4DDCC00", VA = "0x184DDE600")]
	public BCANKGNNLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x4DDE620", Offset = "0x4DDCC20", VA = "0x184DDE620")]
	public BCANKGNNLEN(byte IAKMMHHICJO, CDLPJMLCJNM MKMCBPHHFNB, BCANKGNNLEN COLFLONKFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x4DDE2D0", Offset = "0x4DDC8D0", VA = "0x184DDE2D0")]
	public void MLADKEOGKBF(BCANKGNNLEN JOFIFOFIAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80")]
	public void PCODIJLCAII(int HPJJLHFNLOK, IOIDGLJCNKF APJKFAJNHPG, int FIFBNMEDPDC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x4DDE370", Offset = "0x4DDC970", VA = "0x184DDE370")]
	public void MMCFJHLLEMF(List<byte> JCGDDOPINCJ, Vector3 MMBOHLJHNFP, float IJDDGCJPOKN, float NLHEGDALIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x4DDE270", Offset = "0x4DDC870", VA = "0x184DDE270")]
	public bool KIJBJCDMPOD(Vector3 ECAKKCJGNHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x4DDE230", Offset = "0x4DDC830", VA = "0x184DDE230")]
	public bool AMAOLGFKOKH(Vector3 ECAKKCJGNHD, float OLNJEBHHKNG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class NJNBENCAKHJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly Dictionary<T, object> CMPKDJNBBOL;

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x1ECC8D0", Offset = "0x1ECAED0", VA = "0x181ECC8D0")]
	public bool MJDAEFAIDPP(T JCOBGPNLILC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x3434C20", Offset = "0x3433220", VA = "0x183434C20")]
	public bool MJDAEFAIDPP(T JCOBGPNLILC, object GJGFJFLAGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x3434C60", Offset = "0x3433260", VA = "0x183434C60")]
	public bool MJDAEFAIDPP(T JCOBGPNLILC, object GJGFJFLAGKH, out object EJDBJDEBBBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3434AB0", Offset = "0x34330B0", VA = "0x183434AB0")]
	public bool CIIMNGMHMJH(T JCOBGPNLILC, object GJGFJFLAGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x3434A70", Offset = "0x3433070", VA = "0x183434A70")]
	public bool ADFMFJHNAFD(T JCOBGPNLILC, object GJGFJFLAGKH, out object EJDBJDEBBBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x3434AF0", Offset = "0x34330F0", VA = "0x183434AF0")]
	public bool CIIMNGMHMJH(T JCOBGPNLILC, object GJGFJFLAGKH, out object EJDBJDEBBBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x2FD1880", Offset = "0x2FCFE80", VA = "0x182FD1880")]
	public void EHKKAHOPNED(T JCOBGPNLILC, object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x3434B80", Offset = "0x3433180", VA = "0x183434B80")]
	public void GOHIIEGJPNA(T JCOBGPNLILC, object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x3434CC0", Offset = "0x34332C0", VA = "0x183434CC0")]
	public NJNBENCAKHJ()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public struct FFEJOGAEIHI<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			private readonly List<Component> EJCFBHKFPEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			private readonly bool BAOMNFNBNBP;

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x79D880", Offset = "0x79BE80", VA = "0x18079D880")]
			public FFEJOGAEIHI(List<Component> EJCFBHKFPEM, bool BAOMNFNBNBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x1E2ED30", Offset = "0x1E2D330", VA = "0x181E2ED30")]
			public FEALKCHNHDE<T> NECPELKHGNK()
			{
				return default(FEALKCHNHDE<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x1E2EDA0", Offset = "0x1E2D3A0", VA = "0x181E2EDA0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x1E2EDA0", Offset = "0x1E2D3A0", VA = "0x181E2EDA0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		public struct FEALKCHNHDE<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			private readonly List<Component> EJCFBHKFPEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly bool BAOMNFNBNBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			private int HOOANEAGKNH;

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public T ANMAFMODJCP
			{
				[Cpp2IlInjected.Token(Token = "0x6000377")]
				[Cpp2IlInjected.Address(RVA = "0x1E2E880", Offset = "0x1E2CE80", VA = "0x181E2E880", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000378")]
				[Cpp2IlInjected.Address(RVA = "0x1E2E810", Offset = "0x1E2CE10", VA = "0x181E2E810", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x1E2E850", Offset = "0x1E2CE50", VA = "0x181E2E850")]
			public FEALKCHNHDE(List<Component> EJCFBHKFPEM, bool BAOMNFNBNBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x1E2E740", Offset = "0x1E2CD40", VA = "0x181E2E740", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x1E2E750", Offset = "0x1E2CD50", VA = "0x181E2E750", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x1E2E800", Offset = "0x1E2CE00", VA = "0x181E2E800", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x4DE4CE0", Offset = "0x4DE32E0", VA = "0x184DE4CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4CA0", Offset = "0x4DE32A0", VA = "0x184DE4CA0")]
		public ToolHierarchyCache(GameObject KOIOFEEIFDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4560", Offset = "0x4DE2B60", VA = "0x184DE4560")]
		private void EDEIJCODOEL(GameObject KOIOFEEIFDN, bool LLLNICPNHJM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x4DE44D0", Offset = "0x4DE2AD0", VA = "0x184DE44D0")]
		public static void EDEIJCODOEL(GameObject KOIOFEEIFDN, ref ToolHierarchyCache JFHJFCDGNCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4B70", Offset = "0x4DE3170", VA = "0x184DE4B70")]
		public void NPNOKHMIKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4480", Offset = "0x4DE2A80", VA = "0x184DE4480")]
		public void AMKOIJCGEJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x19B3640", Offset = "0x19B1C40", VA = "0x1819B3640")]
		public void HGJGLIGLJAK<T>(Action<T> BKCLKIJOKLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4800", Offset = "0x4DE2E00", VA = "0x184DE4800")]
		public Component JDOMOAMFFKH(Type ONIHNDBDHGC, bool BAOMNFNBNBP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x1E29E90", Offset = "0x1E28490", VA = "0x181E29E90")]
		public T JDOMOAMFFKH<T>(bool BAOMNFNBNBP = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4700", Offset = "0x4DE2D00", VA = "0x184DE4700")]
		public FFEJOGAEIHI<Component> GGJAALACBCP(Type ONIHNDBDHGC, bool BAOMNFNBNBP = false)
		{
			return default(FFEJOGAEIHI<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x1DA2480", Offset = "0x1DA0A80", VA = "0x181DA2480")]
		public FFEJOGAEIHI<T> GGJAALACBCP<T>(bool BAOMNFNBNBP = false) where T : class
		{
			return default(FFEJOGAEIHI<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x4DE48C0", Offset = "0x4DE2EC0", VA = "0x184DE48C0")]
		public List<Component> MLCMFLNDJNP(Type ONIHNDBDHGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4680", Offset = "0x4DE2C80", VA = "0x184DE4680", Slot = "4")]
		public bool Equals(ToolHierarchyCache KDNDPAEEMPL, ToolHierarchyCache HJCNEOFEOPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4790", Offset = "0x4DE2D90", VA = "0x184DE4790", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache FIEDOLNFNLH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class COIAGMHEHHF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private int NKJBJGFALMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private int IANFLKDBHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private List<T> FPHBFHHHPMJ;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E690", Offset = "0x1E2CC90", VA = "0x181E2E690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public T MKGHNHOEKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x3066590", Offset = "0x3064B90", VA = "0x183066590")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public T FPJDLBJBDNC
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x3066660", Offset = "0x3064C60", VA = "0x183066660")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public T LBPEHICGJBL
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x3066380", Offset = "0x3064980", VA = "0x183066380")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x30668C0", Offset = "0x3064EC0", VA = "0x1830668C0")]
	public COIAGMHEHHF(int NKJBJGFALMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x3066710", Offset = "0x3064D10", VA = "0x183066710")]
	public void NENJMCKJAJO(T KOGMIPGMNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x3066340", Offset = "0x3064940", VA = "0x183066340")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x3066440", Offset = "0x3064A40", VA = "0x183066440")]
	public void FMAIMKFOMEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x3066610", Offset = "0x3064C10", VA = "0x183066610")]
	public void KHIFOAAJIJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x30664E0", Offset = "0x3064AE0", VA = "0x1830664E0")]
	public void HFFJDMLFHOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class MLMJAAKIAGO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private bool BLNNMOJBDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private Action BKCLKIJOKLP;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public static MLMJAAKIAGO JMFPIPNGGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x4DE08C0", Offset = "0x4DDEEC0", VA = "0x184DE08C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool EHMINPKKADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x58B7B0", Offset = "0x589DB0", VA = "0x18058B7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x8402A0", Offset = "0x83E8A0", VA = "0x1808402A0")]
	public MLMJAAKIAGO(Action BKCLKIJOKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x4DE08A0", Offset = "0x4DDEEA0", VA = "0x184DE08A0")]
	public void AKPIIOLAJBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x4DE08A0", Offset = "0x4DDEEA0", VA = "0x184DE08A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class IGKJHECICFN
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80")]
	public static void JBILLMHMLGH(HEFIGJJHMHM PNLOOPBPOJC, string HPJALKGHNFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public class HJGIFFEDANB<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private struct CIADDOLFDPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int EIHHJJJMHFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public T NLLJAAOBNLN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly Dictionary<object, CIADDOLFDPM> MICECLKMJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private T EAKKGKOPNGO;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public virtual T PIMAENKOLPC
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x13EE830", Offset = "0x13ECE30", VA = "0x1813EE830", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x26919E0", Offset = "0x268FFE0", VA = "0x1826919E0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool HGAIKDNEBJH
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x20B65A0", Offset = "0x20B4BA0", VA = "0x1820B65A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public object FKOBBGAOJHK
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x562DF0", Offset = "0x5613F0", VA = "0x180562DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x58AD70", Offset = "0x589370", VA = "0x18058AD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x20B6890", Offset = "0x20B4E90", VA = "0x1820B6890")]
	public bool EMKENJFOCJF(T MPHFKGJNMOK, object GJGFJFLAGKH, int MBHEGCHNPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x20B6C10", Offset = "0x20B5210", VA = "0x1820B6C10")]
	public bool OKFFAJCGNAA(object GJGFJFLAGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2796C20", Offset = "0x2795220", VA = "0x182796C20")]
	public bool ACEOCCKNHLM(object GJGFJFLAGKH, out T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x20B65D0", Offset = "0x20B4BD0", VA = "0x1820B65D0")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2797F70", Offset = "0x2796570", VA = "0x182797F70")]
	private bool ALMLKFCILGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x20B6C80", Offset = "0x20B5280", VA = "0x1820B6C80")]
	public HJGIFFEDANB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class EONHDLDCGOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private Dictionary<object, float> MICECLKMJHJ;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public float NJKOOEKKNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xD8B0A0", Offset = "0xD896A0", VA = "0x180D8B0A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xCC3D10", Offset = "0xCC2310", VA = "0x180CC3D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x4DDEF80", Offset = "0x4DDD580", VA = "0x184DDEF80")]
	public void EMKENJFOCJF(float MPHFKGJNMOK, object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x4DDF110", Offset = "0x4DDD710", VA = "0x184DDF110")]
	public void OKFFAJCGNAA(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x4DDEFF0", Offset = "0x4DDD5F0", VA = "0x184DDEFF0")]
	private void JDCCCBOMICC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x4DDF180", Offset = "0x4DDD780", VA = "0x184DDF180")]
	public EONHDLDCGOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class KCOJKHFGNGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public readonly string HPJLKFMCBIK;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x69EFB0", Offset = "0x69D5B0", VA = "0x18069EFB0")]
	public KCOJKHFGNGK(string GBHKDABIDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0140", Offset = "0x4DDE740", VA = "0x184DE0140")]
	public KCOJKHFGNGK(UnityEngine.Object PGHCEBAIPOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x4DE00F0", Offset = "0x4DDE6F0", VA = "0x184DE00F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public sealed class HEFIGJJHMHM
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class OGEAIFPFOHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public OGEAIFPFOHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x4DE19C0", Offset = "0x4DDFFC0", VA = "0x184DE19C0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly HashSet<object> FKIBCGKGOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private int LBGFCBBILNL;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyCollection<object> ICKPNMGKCFI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool NJODEIMNIEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x4DDF660", Offset = "0x4DDDC60", VA = "0x184DDF660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public int LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x5EC670", Offset = "0x5EAC70", VA = "0x1805EC670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x4DDF6F0", Offset = "0x4DDDCF0", VA = "0x184DDF6F0")]
	public bool NENJMCKJAJO(object GJGFJFLAGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x4DDF670", Offset = "0x4DDDC70", VA = "0x184DDF670")]
	public bool MNHCGCIEOKP(object GJGFJFLAGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x4DDF600", Offset = "0x4DDDC00", VA = "0x184DDF600")]
	public bool FECGJJAPIMF(object GJGFJFLAGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x4DDF5A0", Offset = "0x4DDDBA0", VA = "0x184DDF5A0")]
	public void FBHHBBMPJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x4DDF770", Offset = "0x4DDDD70", VA = "0x184DDF770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x4DDF8E0", Offset = "0x4DDDEE0", VA = "0x184DDF8E0")]
	public HEFIGJJHMHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class AJNMEGICPOE<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private struct FAMGGHBKBCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public float FMGIAHDPMAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public T NLLJAAOBNLN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private Dictionary<object, FAMGGHBKBCC> MICECLKMJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private T KMOMAPPGMGM;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public virtual T AGELLDHNNKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xFE3120", Offset = "0xFE1720", VA = "0x180FE3120", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x18001D0", Offset = "0x17FE7D0", VA = "0x1818001D0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public object KJJMJHDDCIH
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x588A30", Offset = "0x587030", VA = "0x180588A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x6818D0", Offset = "0x67FED0", VA = "0x1806818D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool HGAIKDNEBJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x26913D0", Offset = "0x268F9D0", VA = "0x1826913D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x2691500", Offset = "0x268FB00", VA = "0x182691500")]
	public bool EMKENJFOCJF(T MPHFKGJNMOK, object GJGFJFLAGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x2691A00", Offset = "0x2690000", VA = "0x182691A00")]
	public bool OKFFAJCGNAA(object GJGFJFLAGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x20B65D0", Offset = "0x20B4BD0", VA = "0x1820B65D0")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x268F8F0", Offset = "0x268DEF0", VA = "0x18268F8F0")]
	public bool ACEOCCKNHLM(object GJGFJFLAGKH, out T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x2690920", Offset = "0x268EF20", VA = "0x182690920")]
	private bool ALMLKFCILGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x2691A60", Offset = "0x2690060", VA = "0x182691A60")]
	public AJNMEGICPOE()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public class HGPPKMCDCLL
{
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private static byte[] PIDGMPFPDGI;

	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private static int CONMIAOECKG;

	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private static int PDHBFKNINGO;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static BigInteger EDLLKHJPMCN;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public HGPPKMCDCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x4DDF950", Offset = "0x4DDDF50", VA = "0x184DDF950")]
	private static string CKGLFMJKOPM(byte[] IIFMPDAMAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x4DDFA50", Offset = "0x4DDE050", VA = "0x184DDFA50")]
	public static string IOHOBOIOFIG(byte[] KFCJKMJDFKE, bool OLNJLDMOIJP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x20000AE")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
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
