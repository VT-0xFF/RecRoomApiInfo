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
public class JCAFKCIONPL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x78A370", Offset = "0x788B70", VA = "0x18078A370")]
	public JCAFKCIONPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4F85F10", Offset = "0x4F84710", VA = "0x184F85F10")]
	public byte[] JDBOAGBHAIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void DNHIEDIHLNE(IncrementalHash FBPMKCBKEGD);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6213B0", Offset = "0x61FBB0", VA = "0x1806213B0")]
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
	[LHJJJDLOFKM]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[LHJJJDLOFKM]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4F8B1C0", Offset = "0x4F899C0", VA = "0x184F8B1C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4F8B180", Offset = "0x4F89980", VA = "0x184F8B180")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4F8B200", Offset = "0x4F89A00", VA = "0x184F8B200")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4F8B410", Offset = "0x4F89C10", VA = "0x184F8B410")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4F8B380", Offset = "0x4F89B80", VA = "0x184F8B380")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7BCF70", Offset = "0x7BB770", VA = "0x1807BCF70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8217F0", Offset = "0x81FFF0", VA = "0x1808217F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4F8B140", Offset = "0x4F89940", VA = "0x184F8B140")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4F8B2F0", Offset = "0x4F89AF0", VA = "0x184F8B2F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4F8AB70", Offset = "0x4F89370", VA = "0x184F8AB70")]
	public void CopyBounds(SavedExtents EFDJFLPIKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4F8B0B0", Offset = "0x4F898B0", VA = "0x184F8B0B0")]
	public void SetLocalSpaceBounds(Bounds LCDMLGAKKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9C5FE0", Offset = "0x9C47E0", VA = "0x1809C5FE0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4F8B0A0", Offset = "0x4F898A0", VA = "0x184F8B0A0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4F8ABA0", Offset = "0x4F893A0", VA = "0x184F8ABA0")]
	private void KBKALKJGOFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4F8AE70", Offset = "0x4F89670", VA = "0x184F8AE70")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4F8A5B0", Offset = "0x4F88DB0", VA = "0x184F8A5B0")]
	public static void CalculateLocalBoundsFor(GameObject HDDLEPINJNG, out Bounds LCDMLGAKKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4F8ADB0", Offset = "0x4F895B0", VA = "0x184F8ADB0")]
	private static void LACLMIPEHLC(Bounds EOEFACHALFF, Color NBFCFFGLCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4F8B0D0", Offset = "0x4F898D0", VA = "0x184F8B0D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F780", VA = "0x180570F80")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5D51F0", Offset = "0x5D39F0", VA = "0x1805D51F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x575980", Offset = "0x574180", VA = "0x180575980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "4")]
	public virtual void FHGKECOHNFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
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
	[JCAFKCIONPL]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2D7BC10", Offset = "0x2D7A410", VA = "0x182D7BC10", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2D7B750", Offset = "0x2D79F50", VA = "0x182D7B750", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2D7C210", Offset = "0x2D7AA10", VA = "0x182D7C210")]
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
	private sealed class FFMFDAJFNPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
		public FFMFDAJFNPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x35096B0", Offset = "0x3507EB0", VA = "0x1835096B0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[JCAFKCIONPL]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F780", VA = "0x180570F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x35091D0", Offset = "0x35079D0", VA = "0x1835091D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3509200", Offset = "0x3507A00", VA = "0x183509200", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3509120", Offset = "0x3507920", VA = "0x183509120", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey HJCJKDOGPGK]
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3509150", Offset = "0x3507950", VA = "0x183509150", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3509020", Offset = "0x3507820", VA = "0x183509020", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3508880", Offset = "0x3507080", VA = "0x183508880", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x35081F0", Offset = "0x35069F0", VA = "0x1835081F0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3507E50", Offset = "0x3506650", VA = "0x183507E50", Slot = "14")]
	protected virtual string IINEFHEBHNI(TKeyVal PCPONHDGOJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3507D30", Offset = "0x3506530", VA = "0x183507D30", Slot = "4")]
	public bool ContainsKey(TKey HJCJKDOGPGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3508F10", Offset = "0x3507710", VA = "0x183508F10", Slot = "5")]
	public bool TryGetValue(TKey HJCJKDOGPGK, out TVal HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3507D60", Offset = "0x3506560", VA = "0x183507D60", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3507D60", Offset = "0x3506560", VA = "0x183507D60", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3508F40", Offset = "0x3507740", VA = "0x183508F40")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NIKJBIACJAN<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KEIGIMMPPCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
		public KEIGIMMPPCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2EF2E80", Offset = "0x2EF1680", VA = "0x182EF2E80")]
		internal bool <GetSamples>b__0(global::AOGGADFBHBO<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float BFBKADHALEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float FLMILMNCPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::AOGGADFBHBO<float, T>> BOEDJKOCEBF;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int GOCOAFGBPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2EFB350", Offset = "0x2EF9B50", VA = "0x182EFB350")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2EFB860", Offset = "0x2EFA060", VA = "0x182EFB860")]
	public NIKJBIACJAN(float KHHDHLNEEDC, float NGLFLLKIDJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2EFB640", Offset = "0x2EF9E40", VA = "0x182EFB640")]
	public bool FHLAJPPFOIF(float PLJGFNAMCGB, T HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2EFB450", Offset = "0x2EF9C50", VA = "0x182EFB450")]
	public int BPIDNJPLNKH(float PLJGFNAMCGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2EFACD0", Offset = "0x2EF94D0", VA = "0x182EFACD0")]
	public IEnumerable<T> ABKHMFINLAC(float PLJGFNAMCGB, [Optional] float? LJEOCLHGPPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2EFB4B0", Offset = "0x2EF9CB0", VA = "0x182EFB4B0")]
	public void CPGPLJLMCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2EFB7A0", Offset = "0x2EF9FA0", VA = "0x182EFB7A0")]
	private void MHHFJDFNNEP(float PLJGFNAMCGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class JOPMONILGIP<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct MEIOLFMILAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T MKOCEBDLMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float ICBDJDBNCEL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float ONHPFEPPABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> PPNKGKAEDDI;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int KDBIAPCHBJM = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private MEIOLFMILAH[] FOLGEBPFFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int NHBGGNKHALH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float JCCMHGEGDCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4B0", Offset = "0x5D9CB0", VA = "0x1805DB4B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4C0", Offset = "0x5D9CC0", VA = "0x1805DB4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2BDE8D0", Offset = "0x2BDD0D0", VA = "0x182BDE8D0")]
	public JOPMONILGIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2BDE900", Offset = "0x2BDD100", VA = "0x182BDE900")]
	public JOPMONILGIP(int NBGGIOPLKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9590", Offset = "0x2CF7D90", VA = "0x182CF9590")]
	public void DEOBKNOOHMB(float PLJGFNAMCGB, T HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9380", Offset = "0x2CF7B80", VA = "0x182CF9380")]
	public void CPGPLJLMCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9AF0", Offset = "0x2CF82F0", VA = "0x182CF9AF0")]
	public bool DMPLHOPOACK(float AJNBLPLFEKD, float CKGIDKMKILL, out T HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2CF97D0", Offset = "0x2CF7FD0", VA = "0x182CF97D0")]
	public bool DIJFEIJJBJK(float AJNBLPLFEKD, float CKGIDKMKILL, out T HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9CB0", Offset = "0x2CF84B0", VA = "0x182CF9CB0")]
	public void PJDONHPLPKD(float AJNBLPLFEKD, float CKGIDKMKILL, List<T> AFIAMHMLMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2BDE0B0", Offset = "0x2BDC8B0", VA = "0x182BDE0B0")]
	private int ACEKPAELNDK(int AINKLCJKGOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2BDE0E0", Offset = "0x2BDC8E0", VA = "0x182BDE0E0")]
	private void BEKEOGDFLPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T HLHEEMJNNJG();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T ACJOFLGEOCO(T BPMLEJCIOKJ, T HPMKMLPAGEM, float AELOFOBLNEI);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T PFIKDCHIDLE(T HKJMLEKHILN, float AELOFOBLNEI);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T OMJMNGLFPLG(T BPMLEJCIOKJ, T HPMKMLPAGEM);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T HKCIBFPNKKG(T BPMLEJCIOKJ, T HPMKMLPAGEM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ELDCKOHOIIK : global::JOPMONILGIP<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4F85660", Offset = "0x4F83E60", VA = "0x184F85660", Slot = "4")]
	protected override Vector3 HLHEEMJNNJG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4F85530", Offset = "0x4F83D30", VA = "0x184F85530", Slot = "5")]
	protected override Vector3 ACJOFLGEOCO(Vector3 BPMLEJCIOKJ, Vector3 HPMKMLPAGEM, float AELOFOBLNEI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4F85780", Offset = "0x4F83F80", VA = "0x184F85780", Slot = "6")]
	protected override Vector3 PFIKDCHIDLE(Vector3 HKJMLEKHILN, float AELOFOBLNEI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4F856D0", Offset = "0x4F83ED0", VA = "0x184F856D0", Slot = "7")]
	protected override Vector3 OMJMNGLFPLG(Vector3 BPMLEJCIOKJ, Vector3 HPMKMLPAGEM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4F855F0", Offset = "0x4F83DF0", VA = "0x184F855F0", Slot = "8")]
	protected override Vector3 HKCIBFPNKKG(Vector3 BPMLEJCIOKJ, Vector3 HPMKMLPAGEM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4F85820", Offset = "0x4F84020", VA = "0x184F85820")]
	public ELDCKOHOIIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FEBFHHGIABB : global::JOPMONILGIP<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4F85910", Offset = "0x4F84110", VA = "0x184F85910")]
	public FEBFHHGIABB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4F85970", Offset = "0x4F84170", VA = "0x184F85970")]
	public FEBFHHGIABB(int NBGGIOPLKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x86B010", Offset = "0x869810", VA = "0x18086B010", Slot = "4")]
	protected override float HLHEEMJNNJG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4F85880", Offset = "0x4F84080", VA = "0x184F85880", Slot = "5")]
	protected override float ACJOFLGEOCO(float BPMLEJCIOKJ, float HPMKMLPAGEM, float AELOFOBLNEI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x41286C0", Offset = "0x4126EC0", VA = "0x1841286C0", Slot = "6")]
	protected override float PFIKDCHIDLE(float HKJMLEKHILN, float AELOFOBLNEI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2913E00", Offset = "0x2912600", VA = "0x182913E00", Slot = "7")]
	protected override float OMJMNGLFPLG(float BPMLEJCIOKJ, float HPMKMLPAGEM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4F85900", Offset = "0x4F84100", VA = "0x184F85900", Slot = "8")]
	protected override float HKCIBFPNKKG(float BPMLEJCIOKJ, float HPMKMLPAGEM)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class KOPNBJMJKLJ
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x21A7A80", Offset = "0x21A6280", VA = "0x1821A7A80")]
	public static global::JCLBJLDLMGD<T1> DIFMOOHBFDA<T1>(T1 ABIJCFEFOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x247DB50", Offset = "0x247C350", VA = "0x18247DB50")]
	public static global::AOGGADFBHBO<T1, T2> DIFMOOHBFDA<T1, T2>(T1 ABIJCFEFOHG, T2 LMHJNEIIEJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x247DBC0", Offset = "0x247C3C0", VA = "0x18247DBC0")]
	public static global::DCAPFLLIDOD<T1, T2, T3> DIFMOOHBFDA<T1, T2, T3>(T1 ABIJCFEFOHG, T2 LMHJNEIIEJB, T3 MFNOHGEGJJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2230EA0", Offset = "0x222F6A0", VA = "0x182230EA0")]
	public static global::HJMMCDENHCM<T1, T2, T3, T4> DIFMOOHBFDA<T1, T2, T3, T4>(T1 ABIJCFEFOHG, T2 LMHJNEIIEJB, T3 MFNOHGEGJJG, T4 FBJIKLJDKOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x247DC50", Offset = "0x247C450", VA = "0x18247DC50")]
	public static global::ABBMOIENJMJ<T1, T2, T3, T4, T5> DIFMOOHBFDA<T1, T2, T3, T4, T5>(T1 ABIJCFEFOHG, T2 LMHJNEIIEJB, T3 MFNOHGEGJJG, T4 FBJIKLJDKOK, T5 NMKOKCDBKBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x29B1CA0", Offset = "0x29B04A0", VA = "0x1829B1CA0")]
	public static global::IOMHBNHDDHN<T1, T2, T3, T4, T5, T6> DIFMOOHBFDA<T1, T2, T3, T4, T5, T6>(T1 ABIJCFEFOHG, T2 LMHJNEIIEJB, T3 MFNOHGEGJJG, T4 FBJIKLJDKOK, T5 NMKOKCDBKBG, T6 LFIPIOLLFDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x29B1BE0", Offset = "0x29B03E0", VA = "0x1829B1BE0")]
	public static global::ICPKLMIIPDE<T1, T2, T3, T4, T5, T6, T7> DIFMOOHBFDA<T1, T2, T3, T4, T5, T6, T7>(T1 ABIJCFEFOHG, T2 LMHJNEIIEJB, T3 MFNOHGEGJJG, T4 FBJIKLJDKOK, T5 NMKOKCDBKBG, T6 LFIPIOLLFDA, T7 JNACFMEIPHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x24A89A0", Offset = "0x24A71A0", VA = "0x1824A89A0")]
	public static global::PBBEOKBKIKP<T1, T2, T3, T4, T5, T6, T7, T8> DIFMOOHBFDA<T1, T2, T3, T4, T5, T6, T7, T8>(T1 ABIJCFEFOHG, T2 LMHJNEIIEJB, T3 MFNOHGEGJJG, T4 FBJIKLJDKOK, T5 NMKOKCDBKBG, T6 LFIPIOLLFDA, T7 JNACFMEIPHE, T8 CLIPOJEDPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1D66D30", Offset = "0x1D65530", VA = "0x181D66D30")]
	[IteratorStateMachine(typeof(PNEFDKIPBGO))]
	public static IEnumerable<global::AOGGADFBHBO<T1, T2>> EFHPFOBNDCB<T1, T2>(IEnumerable<T1> FCCDOLKCOHD, IEnumerable<T2> EOEFACHALFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x209CCE0", Offset = "0x209B4E0", VA = "0x18209CCE0")]
	[IteratorStateMachine(typeof(BHCHIMEICON))]
	public static IEnumerable<global::DCAPFLLIDOD<T1, T2, T3>> EFHPFOBNDCB<T1, T2, T3>(IEnumerable<T1> FCCDOLKCOHD, IEnumerable<T2> EOEFACHALFF, IEnumerable<T3> NBFCFFGLCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x28CE3D0", Offset = "0x28CCBD0", VA = "0x1828CE3D0")]
	internal static int ACIMCDPMIDI(int BBFFKCBIJGJ, int CAJIJPLJKCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3DEF660", Offset = "0x3DEDE60", VA = "0x183DEF660")]
	internal static int ACIMCDPMIDI(int BBFFKCBIJGJ, int CAJIJPLJKCP, int CPLNIFFEPFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3DEF670", Offset = "0x3DEDE70", VA = "0x183DEF670")]
	internal static int ACIMCDPMIDI(int BBFFKCBIJGJ, int CAJIJPLJKCP, int CPLNIFFEPFL, int LMHGJODOLON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4F87930", Offset = "0x4F86130", VA = "0x184F87930")]
	internal static int ACIMCDPMIDI(int BBFFKCBIJGJ, int CAJIJPLJKCP, int CPLNIFFEPFL, int LMHGJODOLON, int EJHGLNCBMEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4F878E0", Offset = "0x4F860E0", VA = "0x184F878E0")]
	internal static int ACIMCDPMIDI(int BBFFKCBIJGJ, int CAJIJPLJKCP, int CPLNIFFEPFL, int LMHGJODOLON, int EJHGLNCBMEC, int JKFBIKPFHIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4F87950", Offset = "0x4F86150", VA = "0x184F87950")]
	internal static int ACIMCDPMIDI(int BBFFKCBIJGJ, int CAJIJPLJKCP, int CPLNIFFEPFL, int LMHGJODOLON, int EJHGLNCBMEC, int JKFBIKPFHIC, int JBKIHPPMDGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4F87900", Offset = "0x4F86100", VA = "0x184F87900")]
	internal static int ACIMCDPMIDI(int BBFFKCBIJGJ, int CAJIJPLJKCP, int CPLNIFFEPFL, int LMHGJODOLON, int EJHGLNCBMEC, int JKFBIKPFHIC, int JBKIHPPMDGO, int IBGIBMJLDOJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JCLBJLDLMGD<T1> : IComparable<global::JCLBJLDLMGD<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 BADFEICOAEI;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2806BE0", Offset = "0x28053E0", VA = "0x182806BE0")]
	public JCLBJLDLMGD(T1 ABIJCFEFOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4295600", Offset = "0x4293E00", VA = "0x184295600", Slot = "4")]
	public int CompareTo(global::JCLBJLDLMGD<T1> EFDJFLPIKFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4295670", Offset = "0x4293E70", VA = "0x184295670", Slot = "0")]
	public override bool Equals(object EFDJFLPIKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8722A0", Offset = "0x870AA0", VA = "0x1808722A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4295710", Offset = "0x4293F10", VA = "0x184295710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class AOGGADFBHBO<T1, T2> : IComparable<global::AOGGADFBHBO<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 BADFEICOAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 OIJMKMBPOCH;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x41BA6F0", Offset = "0x41B8EF0", VA = "0x1841BA6F0")]
	public AOGGADFBHBO(T1 ABIJCFEFOHG, T2 LMHJNEIIEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x41B8DC0", Offset = "0x41B75C0", VA = "0x1841B8DC0", Slot = "4")]
	public int CompareTo(global::AOGGADFBHBO<T1, T2> EFDJFLPIKFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x41B9750", Offset = "0x41B7F50", VA = "0x1841B9750", Slot = "0")]
	public override bool Equals(object EFDJFLPIKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x41B9B00", Offset = "0x41B8300", VA = "0x1841B9B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x41BA030", Offset = "0x41B8830", VA = "0x1841BA030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DCAPFLLIDOD<T1, T2, T3> : IComparable<global::DCAPFLLIDOD<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 BADFEICOAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 OIJMKMBPOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 ALIMNJEPJGO;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3FEB250", Offset = "0x3FE9A50", VA = "0x183FEB250")]
	public DCAPFLLIDOD(T1 ABIJCFEFOHG, T2 LMHJNEIIEJB, T3 MFNOHGEGJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3FEAA70", Offset = "0x3FE9270", VA = "0x183FEAA70", Slot = "4")]
	public int CompareTo(global::DCAPFLLIDOD<T1, T2, T3> EFDJFLPIKFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3FEAC70", Offset = "0x3FE9470", VA = "0x183FEAC70", Slot = "0")]
	public override bool Equals(object EFDJFLPIKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3FEAED0", Offset = "0x3FE96D0", VA = "0x183FEAED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3FEB0C0", Offset = "0x3FE98C0", VA = "0x183FEB0C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HJMMCDENHCM<T1, T2, T3, T4> : IComparable<global::HJMMCDENHCM<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 BADFEICOAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 OIJMKMBPOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 ALIMNJEPJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 EBFOEMPBLKG;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4094D50", Offset = "0x4093550", VA = "0x184094D50")]
	public HJMMCDENHCM(T1 ABIJCFEFOHG, T2 LMHJNEIIEJB, T3 MFNOHGEGJJG, T4 FBJIKLJDKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x42F2CD0", Offset = "0x42F14D0", VA = "0x1842F2CD0", Slot = "4")]
	public int CompareTo(global::HJMMCDENHCM<T1, T2, T3, T4> EFDJFLPIKFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x42F2E10", Offset = "0x42F1610", VA = "0x1842F2E10", Slot = "0")]
	public override bool Equals(object EFDJFLPIKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x42F2F30", Offset = "0x42F1730", VA = "0x1842F2F30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x42F2FF0", Offset = "0x42F17F0", VA = "0x1842F2FF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class ABBMOIENJMJ<T1, T2, T3, T4, T5> : IComparable<global::ABBMOIENJMJ<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 BADFEICOAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 OIJMKMBPOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 ALIMNJEPJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 EBFOEMPBLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 AFNHKFGOKPB;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3836F10", Offset = "0x3835710", VA = "0x183836F10")]
	public ABBMOIENJMJ(T1 ABIJCFEFOHG, T2 LMHJNEIIEJB, T3 MFNOHGEGJJG, T4 FBJIKLJDKOK, T5 NMKOKCDBKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3836A20", Offset = "0x3835220", VA = "0x183836A20", Slot = "4")]
	public int CompareTo(global::ABBMOIENJMJ<T1, T2, T3, T4, T5> EFDJFLPIKFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3836BA0", Offset = "0x38353A0", VA = "0x183836BA0", Slot = "0")]
	public override bool Equals(object EFDJFLPIKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3836CE0", Offset = "0x38354E0", VA = "0x183836CE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3836DE0", Offset = "0x38355E0", VA = "0x183836DE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class IOMHBNHDDHN<T1, T2, T3, T4, T5, T6> : IComparable<global::IOMHBNHDDHN<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 BADFEICOAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 OIJMKMBPOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 ALIMNJEPJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 EBFOEMPBLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 AFNHKFGOKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 CHFNGCBNLPL;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4292A50", Offset = "0x4291250", VA = "0x184292A50")]
	public IOMHBNHDDHN(T1 ABIJCFEFOHG, T2 LMHJNEIIEJB, T3 MFNOHGEGJJG, T4 FBJIKLJDKOK, T5 NMKOKCDBKBG, T6 LFIPIOLLFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x42924B0", Offset = "0x4290CB0", VA = "0x1842924B0", Slot = "4")]
	public int CompareTo(global::IOMHBNHDDHN<T1, T2, T3, T4, T5, T6> EFDJFLPIKFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4292670", Offset = "0x4290E70", VA = "0x184292670", Slot = "0")]
	public override bool Equals(object EFDJFLPIKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x42927E0", Offset = "0x4290FE0", VA = "0x1842927E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4292900", Offset = "0x4291100", VA = "0x184292900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ICPKLMIIPDE<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::ICPKLMIIPDE<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 BADFEICOAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 OIJMKMBPOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 ALIMNJEPJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 EBFOEMPBLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 AFNHKFGOKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 CHFNGCBNLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 ADBHNHMOODJ;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C140", Offset = "0x2A3A940", VA = "0x182A3C140")]
	public ICPKLMIIPDE(T1 ABIJCFEFOHG, T2 LMHJNEIIEJB, T3 MFNOHGEGJJG, T4 FBJIKLJDKOK, T5 NMKOKCDBKBG, T6 LFIPIOLLFDA, T7 JNACFMEIPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BAE0", Offset = "0x2A3A2E0", VA = "0x182A3BAE0", Slot = "4")]
	public int CompareTo(global::ICPKLMIIPDE<T1, T2, T3, T4, T5, T6, T7> EFDJFLPIKFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BCE0", Offset = "0x2A3A4E0", VA = "0x182A3BCE0", Slot = "0")]
	public override bool Equals(object EFDJFLPIKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BE80", Offset = "0x2A3A680", VA = "0x182A3BE80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BFD0", Offset = "0x2A3A7D0", VA = "0x182A3BFD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PBBEOKBKIKP<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::PBBEOKBKIKP<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 BADFEICOAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 OIJMKMBPOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 ALIMNJEPJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 EBFOEMPBLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 AFNHKFGOKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 CHFNGCBNLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 ADBHNHMOODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 BFOLOEFGMGI;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8A70", Offset = "0x2CA7270", VA = "0x182CA8A70")]
	public PBBEOKBKIKP(T1 ABIJCFEFOHG, T2 LMHJNEIIEJB, T3 MFNOHGEGJJG, T4 FBJIKLJDKOK, T5 NMKOKCDBKBG, T6 LFIPIOLLFDA, T7 JNACFMEIPHE, T8 CLIPOJEDPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8360", Offset = "0x2CA6B60", VA = "0x182CA8360", Slot = "4")]
	public int CompareTo(global::PBBEOKBKIKP<T1, T2, T3, T4, T5, T6, T7, T8> EFDJFLPIKFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2CA85B0", Offset = "0x2CA6DB0", VA = "0x182CA85B0", Slot = "0")]
	public override bool Equals(object EFDJFLPIKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8770", Offset = "0x2CA6F70", VA = "0x182CA8770", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2CA88E0", Offset = "0x2CA70E0", VA = "0x182CA88E0", Slot = "3")]
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
	public T MKOCEBDLMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x574330", Offset = "0x572B30", VA = "0x180574330")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6155C0", Offset = "0x613DC0", VA = "0x1806155C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float OJNLOEMFBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x69BDB0", Offset = "0x69A5B0", VA = "0x18069BDB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3F61400", Offset = "0x3F5FC00", VA = "0x183F61400")]
	public T NAMOACNCABO(float AELOFOBLNEI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3F61170", Offset = "0x3F5F970", VA = "0x183F61170")]
	public T BADAPOOHOIM(float AELOFOBLNEI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T ACJOFLGEOCO(T BPMLEJCIOKJ, T HPMKMLPAGEM, float AELOFOBLNEI);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4F85BA0", Offset = "0x4F843A0", VA = "0x184F85BA0", Slot = "4")]
	protected override float ACJOFLGEOCO(float BPMLEJCIOKJ, float HPMKMLPAGEM, float AELOFOBLNEI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4F85C20", Offset = "0x4F84420", VA = "0x184F85C20")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4F8C370", Offset = "0x4F8AB70", VA = "0x184F8C370", Slot = "4")]
	protected override Vector3 ACJOFLGEOCO(Vector3 BPMLEJCIOKJ, Vector3 HPMKMLPAGEM, float AELOFOBLNEI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4F8C430", Offset = "0x4F8AC30", VA = "0x184F8C430")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x11DAED0", Offset = "0x11D96D0", VA = "0x1811DAED0", Slot = "4")]
	protected override Color ACJOFLGEOCO(Color BPMLEJCIOKJ, Color HPMKMLPAGEM, float AELOFOBLNEI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4F84F20", Offset = "0x4F83720", VA = "0x184F84F20")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PLHBKNNCCEJ : global::HJLJHALOHDB<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4F89C20", Offset = "0x4F88420", VA = "0x184F89C20")]
	public PLHBKNNCCEJ(int LJMMIINDJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4F89C70", Offset = "0x4F88470", VA = "0x184F89C70")]
	public PLHBKNNCCEJ(KLGHKIGIFLB[] HOJPMJEOHPD, bool GIIOFIPAEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4F89BB0", Offset = "0x4F883B0", VA = "0x184F89BB0", Slot = "6")]
	protected override uint PIHHJMNENNF(uint FBPMKCBKEGD, string HKJMLEKHILN)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PCDJOJGCICC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly IDisposable JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public PCDJOJGCICC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(global::GJBHNNCOPFI<>.PAHBDDMPGHC))]
public sealed class GJBHNNCOPFI<T> : IDisposable, global::KABAINCMBHP<T>, DOGPBFKLNCD, global::BMKGLPHGONC<T, global::GJBHNNCOPFI<T>.KOEGMALGPNB>, global::DCNGNGOICNG<T>, global::IHOJEPDHGCI<T, global::GJBHNNCOPFI<T>.KOEGMALGPNB>, global::DKDCGAGJCCA<T>, global::NLOOGAGDPDH<T, global::GJBHNNCOPFI<T>.KOEGMALGPNB>, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct KOEGMALGPNB : DOGPBFKLNCD, global::OFBGFBMNOAO<T>, global::MJJHLCGLCHL<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly global::GJBHNNCOPFI<T> JADENONKCBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private int KLIIEEHOFDJ;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int MPKAKPNFLIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2186160", Offset = "0x2184960", VA = "0x182186160", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T DIBBIBNFCIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x3F3AD40", Offset = "0x3F39540", VA = "0x183F3AD40", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private T NFCNCKOHALN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x3F3A710", Offset = "0x3F38F10", VA = "0x183F3A710", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x3F3A890", Offset = "0x3F39090", VA = "0x183F3A890", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x3F3ABE0", Offset = "0x3F393E0", VA = "0x183F3ABE0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xBF17A0", Offset = "0xBEFFA0", VA = "0x180BF17A0")]
		private KOEGMALGPNB(global::GJBHNNCOPFI<T> MHKBKFBCDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2EF1AF0", Offset = "0x2EF02F0", VA = "0x182EF1AF0")]
		public static KOEGMALGPNB HFGDAGIMEIK(global::GJBHNNCOPFI<T> MHKBKFBCDKB)
		{
			return default(KOEGMALGPNB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3F3A770", Offset = "0x3F38F70", VA = "0x183F3A770", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xBF1640", Offset = "0xBEFE40", VA = "0x180BF1640", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class PAHBDDMPGHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly global::GJBHNNCOPFI<T> JADENONKCBF;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int MPKAKPNFLIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x230E970", Offset = "0x230D170", VA = "0x18230E970")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public T[] BPKFCJDIIKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x3F3B340", Offset = "0x3F39B40", VA = "0x183F3B340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool DINLCPKDMOA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x3F3B400", Offset = "0x3F39C00", VA = "0x183F3B400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2806BE0", Offset = "0x28053E0", VA = "0x182806BE0")]
		public PAHBDDMPGHC(global::GJBHNNCOPFI<T> MHKBKFBCDKB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly FLJHNHBBNOP LLNOODGMCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private T[] PHPHDDBEKAA;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int MPKAKPNFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5EB260", Offset = "0x5E9A60", VA = "0x1805EB260", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5EB270", Offset = "0x5E9A70", VA = "0x1805EB270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Span<T> BPKFCJDIIKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3F33C20", Offset = "0x3F32420", VA = "0x183F33C20")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public T KJIAGDJOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3F345B0", Offset = "0x3F32DB0", VA = "0x183F345B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x31953C0", Offset = "0x3193BC0", VA = "0x1831953C0")]
	public static global::GJBHNNCOPFI<T> HFGDAGIMEIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3195240", Offset = "0x3193A40", VA = "0x183195240")]
	public static global::GJBHNNCOPFI<T> GDPPDNBCDLH(int LJMMIINDJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3F35160", Offset = "0x3F33960", VA = "0x183F35160")]
	private GJBHNNCOPFI(T[] JKJDLBFGICE, int LJMMIINDJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C5D0", Offset = "0x2A3ADD0", VA = "0x182A3C5D0", Slot = "5")]
	public T CNHABHDIDFG(int HPENCEMKHKB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x31951C0", Offset = "0x31939C0", VA = "0x1831951C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3F342D0", Offset = "0x3F32AD0", VA = "0x183F342D0")]
	public void DEOBKNOOHMB(in T HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3195540", Offset = "0x3193D40", VA = "0x183195540")]
	public void LACDHDJJICN(int EDBBKGCLEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3F34EF0", Offset = "0x3F336F0", VA = "0x183F34EF0")]
	public void PLJNBJJLFFD(int NBGGIOPLKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x31955E0", Offset = "0x3193DE0", VA = "0x1831955E0")]
	private void OFBJOOCPCKO(int LJMMIINDJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3195380", Offset = "0x3193B80", VA = "0x183195380", Slot = "11")]
	public KOEGMALGPNB GetEnumerator()
	{
		return default(KOEGMALGPNB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3195060", Offset = "0x3193860", VA = "0x183195060", Slot = "8")]
	private global::OFBGFBMNOAO<T> GLIBNPGIFKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3195060", Offset = "0x3193860", VA = "0x183195060", Slot = "10")]
	private global::MJJHLCGLCHL<T> CEHACJCGODK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3195060", Offset = "0x3193860", VA = "0x183195060", Slot = "12")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3195060", Offset = "0x3193860", VA = "0x183195060", Slot = "13")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class LPMEPPCINMH
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2851EA0", Offset = "0x28506A0", VA = "0x182851EA0")]
	public static global::GJBHNNCOPFI<T> HFGDAGIMEIK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1BDC260", Offset = "0x1BDAA60", VA = "0x181BDC260")]
	public static global::GJBHNNCOPFI<T> GDPPDNBCDLH<T>(int LJMMIINDJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2469280", Offset = "0x2467A80", VA = "0x182469280")]
	public static bool OFKIPBDJFHB<T>(this global::GJBHNNCOPFI<T> MHKBKFBCDKB, in T HKJMLEKHILN) where T : global::DGOCHJFNFHL<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct DCBENJKHDPM
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class OOOGKIPLNGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public TaskCompletionSource<CMMMKLGEKCJ> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public OOOGKIPLNGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4F897A0", Offset = "0x4F87FA0", VA = "0x184F897A0")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<CMMMKLGEKCJ>> JDGNGDOMGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int NPGNMDBDNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int ODEGKACKMCH;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x28D27F0", Offset = "0x28D0FF0", VA = "0x1828D27F0")]
	private DCBENJKHDPM(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<CMMMKLGEKCJ>> GECJPNAMDGN, int PNENKMJNFFP, int OPHEIECBKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4F84F60", Offset = "0x4F83760", VA = "0x184F84F60")]
	public static DCBENJKHDPM HFGDAGIMEIK()
	{
		return default(DCBENJKHDPM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4F85090", Offset = "0x4F83890", VA = "0x184F85090")]
	public (int, int, Task) NMDDHBCACGB(int OCMBECMMGPG, [Optional] CancellationToken OFMMACGDFGM)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4F84FE0", Offset = "0x4F837E0", VA = "0x184F84FE0")]
	public void LPELPNJIFIA(int OCMBECMMGPG, int OPHEIECBKKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class CJCLEOGCFJI<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<TKey, TVal> BCGIBIIDKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly Dictionary<TVal, TKey> ACPPEOKHLPN;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public int MPKAKPNFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x230E970", Offset = "0x230D170", VA = "0x18230E970", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool FIOIIHPDJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5757E0", Offset = "0x573FE0", VA = "0x1805757E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ICollection<TKey> OAHNPONBHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2D683B0", Offset = "0x2D66BB0", VA = "0x182D683B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ICollection<TVal> EOOOLIDEMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x230EE50", Offset = "0x230D650", VA = "0x18230EE50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TVal KJIAGDJOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2800850", Offset = "0x27FF050", VA = "0x182800850", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2A3F950", Offset = "0x2A3E150", VA = "0x182A3F950", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TKey KJIAGDJOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x32D6290", Offset = "0x32D4A90", VA = "0x1832D6290")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x32D6320", Offset = "0x32D4B20", VA = "0x1832D6320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x32D5950", Offset = "0x32D4150", VA = "0x1832D5950", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x32D6400", Offset = "0x32D4C00", VA = "0x1832D6400", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3283600", Offset = "0x3281E00", VA = "0x183283600", Slot = "9")]
	public void Add(TKey HJCJKDOGPGK, TVal HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x32D58C0", Offset = "0x32D40C0", VA = "0x1832D58C0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> BOJBBPBHNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2CADAD0", Offset = "0x2CAC2D0", VA = "0x182CADAD0", Slot = "8")]
	public bool ContainsKey(TKey HJCJKDOGPGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C6C0", Offset = "0x2A3AEC0", VA = "0x182A3C6C0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> BOJBBPBHNOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C5D0", Offset = "0x2A3ADD0", VA = "0x182A3C5D0", Slot = "10")]
	public bool Remove(TKey HJCJKDOGPGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C5D0", Offset = "0x2A3ADD0", VA = "0x182A3C5D0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> BOJBBPBHNOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x230ECA0", Offset = "0x230D4A0", VA = "0x18230ECA0", Slot = "11")]
	public bool TryGetValue(TKey HJCJKDOGPGK, out TVal HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x32D5C70", Offset = "0x32D4470", VA = "0x1832D5C70", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x32D59E0", Offset = "0x32D41E0", VA = "0x1832D59E0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] FOLGEBPFFME, int ACENJMBACBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x32D5A80", Offset = "0x32D4280", VA = "0x1832D5A80")]
	public void DEOBKNOOHMB(TVal FMHKLFGOBKK, TKey HJCJKDOGPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x32D5A40", Offset = "0x32D4240", VA = "0x1832D5A40")]
	public void DEOBKNOOHMB(KeyValuePair<TVal, TKey> BOJBBPBHNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x32D63A0", Offset = "0x32D4BA0", VA = "0x1832D63A0")]
	public bool MDPNLHCBEFJ(TVal HJCJKDOGPGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2CED080", Offset = "0x2CEB880", VA = "0x182CED080")]
	public bool BMCMFPADDFE(KeyValuePair<TVal, TKey> BOJBBPBHNOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x32D62F0", Offset = "0x32D4AF0", VA = "0x1832D62F0")]
	public bool IIDOOJBFPNM(TVal HJCJKDOGPGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x32D62F0", Offset = "0x32D4AF0", VA = "0x1832D62F0")]
	public bool IIDOOJBFPNM(KeyValuePair<TVal, TKey> BOJBBPBHNOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x32D5B30", Offset = "0x32D4330", VA = "0x1832D5B30")]
	public bool DHIHCKAPBED(TVal HJCJKDOGPGK, out TKey HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x32D6180", Offset = "0x32D4980", VA = "0x1832D6180")]
	public IEnumerator<KeyValuePair<TVal, TKey>> HMDCLPBOCFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x32D5BF0", Offset = "0x32D43F0", VA = "0x1832D5BF0")]
	private void GONIINFDOJC(TKey HJCJKDOGPGK, TVal FMHKLFGOBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x32D5E00", Offset = "0x32D4600", VA = "0x1832D5E00")]
	private void HCFNDOOPDIP(TKey HJCJKDOGPGK, TVal FMHKLFGOBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x32D5F40", Offset = "0x32D4740", VA = "0x1832D5F40")]
	private bool HGIINAJKLPP(TKey HJCJKDOGPGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x32D5E80", Offset = "0x32D4680", VA = "0x1832D5E80")]
	private bool HGIINAJKLPP(TVal FMHKLFGOBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x32D64A0", Offset = "0x32D4CA0", VA = "0x1832D64A0")]
	public CJCLEOGCFJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class KOIBNHKDLFM<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private global::KOIBNHKDLFM<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x5DB4B0", Offset = "0x5D9CB0", VA = "0x1805DB4B0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x38634A0", Offset = "0x3861CA0", VA = "0x1838634A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x38638B0", Offset = "0x38620B0", VA = "0x1838638B0")]
		public Enumerator(global::KOIBNHKDLFM<T> AFIAMHMLMFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3862D30", Offset = "0x3861530", VA = "0x183862D30", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x38632B0", Offset = "0x3861AB0", VA = "0x1838632B0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3862C30", Offset = "0x3861430", VA = "0x183862C30")]
		private void MJKNDAHONKN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private T[] NIJENAEGDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private int NCBFFIFJMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private int JNMAGPIAHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private int CDHIMBPFFEA;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int MPKAKPNFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3867600", Offset = "0x3865E00", VA = "0x183867600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public T KJIAGDJOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3866DD0", Offset = "0x38655D0", VA = "0x183866DD0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3867490", Offset = "0x3865C90", VA = "0x183867490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3867830", Offset = "0x3866030", VA = "0x183867830")]
	public KOIBNHKDLFM(int LJMMIINDJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3865E90", Offset = "0x3864690", VA = "0x183865E90")]
	public void DEOBKNOOHMB(T AELOFOBLNEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x38669E0", Offset = "0x38651E0", VA = "0x1838669E0")]
	public void FDLFKOMFIAC(IEnumerable<T> OLKPHIDNPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3865DB0", Offset = "0x38645B0", VA = "0x183865DB0")]
	public void CPGPLJLMCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x38657E0", Offset = "0x3863FE0", VA = "0x1838657E0")]
	public void AFNKBIHJNJO(int NLKMJJJPIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3866CE0", Offset = "0x38654E0", VA = "0x183866CE0")]
	public void HKMDLAGKDEA(int NLKMJJJPIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x38659C0", Offset = "0x38641C0", VA = "0x1838659C0")]
	public void AGMNAELGCNF(T[] FOLGEBPFFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3866EF0", Offset = "0x38656F0", VA = "0x183866EF0")]
	public Enumerator JNPKLKEOKNK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3867640", Offset = "0x3865E40", VA = "0x183867640", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3867640", Offset = "0x3865E40", VA = "0x183867640", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3867140", Offset = "0x3865940", VA = "0x183867140")]
	private int KFJBGNLBEPC(int EDBBKGCLEJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x38657B0", Offset = "0x3863FB0", VA = "0x1838657B0")]
	private int AFDBFHPPJCI(int EDBBKGCLEJF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct NKMLOPHHKCD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IDisposable[] PHPHDDBEKAA;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x719100", Offset = "0x717900", VA = "0x180719100")]
	public NKMLOPHHKCD(params IDisposable[] JKJDLBFGICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x120C8D0", Offset = "0x120B0D0", VA = "0x18120C8D0")]
	public static NKMLOPHHKCD HFGDAGIMEIK(params IDisposable[] JKJDLBFGICE)
	{
		return default(NKMLOPHHKCD);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4F88960", Offset = "0x4F87160", VA = "0x184F88960", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct AAJAGMPABFN<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IDisposable NLIMJANCDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public T MKOCEBDLMLE;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2BEAB70", Offset = "0x2BE9370", VA = "0x182BEAB70")]
	public AAJAGMPABFN(IDisposable EFHMDPBKJPI, in T HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2470830", Offset = "0x246F030", VA = "0x182470830")]
	public static global::AAJAGMPABFN<U> FLIFAHEMGND<U>(in global::AAJAGMPABFN<T> EFHMDPBKJPI, in U HKJMLEKHILN)
	{
		return default(global::AAJAGMPABFN<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2470870", Offset = "0x246F070", VA = "0x182470870")]
	public global::AAJAGMPABFN<U> LJHJNGONGIH<U>(in U HKJMLEKHILN)
	{
		return default(global::AAJAGMPABFN<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x24705D0", Offset = "0x246EDD0", VA = "0x1824705D0")]
	public static global::AAJAGMPABFN<(T, U)> BDKBJNODEIO<U>(in global::AAJAGMPABFN<T> FCCDOLKCOHD, in global::AAJAGMPABFN<U> EOEFACHALFF)
	{
		return default(global::AAJAGMPABFN<(T, U)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3836740", Offset = "0x3834F40", VA = "0x183836740", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class ODFDMKIHLOD
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x247F950", Offset = "0x247E150", VA = "0x18247F950")]
	public static global::AAJAGMPABFN<T> HFGDAGIMEIK<T>(IDisposable EFHMDPBKJPI, in T HKJMLEKHILN)
	{
		return default(global::AAJAGMPABFN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2470870", Offset = "0x246F070", VA = "0x182470870")]
	public static global::AAJAGMPABFN<U> FLIFAHEMGND<U, T>(in global::AAJAGMPABFN<T> EJAEFPHCCEO, in U HKJMLEKHILN)
	{
		return default(global::AAJAGMPABFN<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x247ED50", Offset = "0x247D550", VA = "0x18247ED50")]
	public static global::AAJAGMPABFN<(T, U)> BDKBJNODEIO<T, U>(in global::AAJAGMPABFN<T> FCCDOLKCOHD, in global::AAJAGMPABFN<U> EOEFACHALFF)
	{
		return default(global::AAJAGMPABFN<(T, U)>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct FLJHNHBBNOP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5757E0", Offset = "0x573FE0", VA = "0x1805757E0")]
	public static FLJHNHBBNOP BFCKDGNJCLO<T>([Optional] string HECJPKEOMNF, [Optional] string OJKMLFLEIAI, bool OALOEABDLMC = false)
	{
		return default(FLJHNHBBNOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public readonly struct NDOFNCFDHGM<T> : global::IHOJEPDHGCI<T, global::NDOFNCFDHGM<T>.GMOIEHCAKPE>, global::DKDCGAGJCCA<T>, global::NLOOGAGDPDH<T, global::NDOFNCFDHGM<T>.GMOIEHCAKPE>, IEnumerable<T>, IEnumerable, global::KABAINCMBHP<T>, DOGPBFKLNCD
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct GMOIEHCAKPE : DOGPBFKLNCD, global::MJJHLCGLCHL<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly T[] JADENONKCBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int KLIIEEHOFDJ;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int MPKAKPNFLIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x6EE550", Offset = "0x6ECD50", VA = "0x1806EE550", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public T DIBBIBNFCIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x2EF1BA0", Offset = "0x2EF03A0", VA = "0x182EF1BA0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x2EF1B50", Offset = "0x2EF0350", VA = "0x182EF1B50", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x2EF1B50", Offset = "0x2EF0350", VA = "0x182EF1B50", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA2DC80", Offset = "0xA2C480", VA = "0x180A2DC80")]
		private GMOIEHCAKPE(T[] MHKBKFBCDKB, int EDBBKGCLEJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2EF1AF0", Offset = "0x2EF02F0", VA = "0x182EF1AF0")]
		public static GMOIEHCAKPE HFGDAGIMEIK(T[] MHKBKFBCDKB)
		{
			return default(GMOIEHCAKPE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x1253BC0", Offset = "0x12523C0", VA = "0x181253BC0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xBF1640", Offset = "0xBEFE40", VA = "0x180BF1640", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly T[] BGKIEACJMGF;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int ADPNOPOPGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6EE550", Offset = "0x6ECD50", VA = "0x1806EE550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int MPKAKPNFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2EF5B90", Offset = "0x2EF4390", VA = "0x182EF5B90", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public T KJIAGDJOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2EF5B50", Offset = "0x2EF4350", VA = "0x182EF5B50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x719100", Offset = "0x717900", VA = "0x180719100")]
	internal NDOFNCFDHGM(T[] FOLGEBPFFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2EF5A50", Offset = "0x2EF4250", VA = "0x182EF5A50", Slot = "9")]
	public T CNHABHDIDFG(int EDBBKGCLEJF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2EF5AB0", Offset = "0x2EF42B0", VA = "0x182EF5AB0", Slot = "6")]
	public GMOIEHCAKPE GetEnumerator()
	{
		return default(GMOIEHCAKPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2EF5950", Offset = "0x2EF4150", VA = "0x182EF5950", Slot = "5")]
	private global::MJJHLCGLCHL<T> CEHACJCGODK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2EF5950", Offset = "0x2EF4150", VA = "0x182EF5950", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2EF5950", Offset = "0x2EF4150", VA = "0x182EF5950", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class EENOJMJNMGF
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x247D870", Offset = "0x247C070", VA = "0x18247D870")]
	public static global::NDOFNCFDHGM<T> HFGDAGIMEIK<T>(T[] FOLGEBPFFME)
	{
		return default(global::NDOFNCFDHGM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x247D8A0", Offset = "0x247C0A0", VA = "0x18247D8A0")]
	public static global::NDOFNCFDHGM<T> HKPJOEMCIBF<T>()
	{
		return default(global::NDOFNCFDHGM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1BDC260", Offset = "0x1BDAA60", VA = "0x181BDC260")]
	public static global::NDOFNCFDHGM<T> BCJJDMEJGJP<T>(this T[] MHKBKFBCDKB)
	{
		return default(global::NDOFNCFDHGM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2230CF0", Offset = "0x222F4F0", VA = "0x182230CF0")]
	public static global::NDOFNCFDHGM<T>.GMOIEHCAKPE NPHICBADFLK<T>(this T[] MHKBKFBCDKB)
	{
		return default(global::NDOFNCFDHGM<T>.GMOIEHCAKPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1BDC260", Offset = "0x1BDAA60", VA = "0x181BDC260")]
	public static global::NDOFNCFDHGM<T> ADIHFJEACPC<T>(this T[] MHKBKFBCDKB)
	{
		return default(global::NDOFNCFDHGM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct GILAIBBIHNA<T, U> : global::IHOJEPDHGCI<T, U>, global::DKDCGAGJCCA<T>, global::NLOOGAGDPDH<T, U>, IEnumerable<T>, IEnumerable where U : global::MJJHLCGLCHL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly U OAGHNMFHJGN;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2A3DF60", Offset = "0x2A3C760", VA = "0x182A3DF60")]
	internal GILAIBBIHNA(in U MJKCNLOOHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x60DD50", Offset = "0x60C550", VA = "0x18060DD50", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3F32940", Offset = "0x3F31140", VA = "0x183F32940", Slot = "5")]
	private global::MJJHLCGLCHL<T> CEHACJCGODK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3F32940", Offset = "0x3F31140", VA = "0x183F32940", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3F32940", Offset = "0x3F31140", VA = "0x183F32940", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class CACOGCOBEJF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x247BCF0", Offset = "0x247A4F0", VA = "0x18247BCF0")]
	public static global::GILAIBBIHNA<T, U> HFGDAGIMEIK<U>(in U MJKCNLOOHEI) where U : global::MJJHLCGLCHL<T>
	{
		return default(global::GILAIBBIHNA<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class JNEPMEKHAJO<TResult, TResultEnumerator> where TResultEnumerator : global::MJJHLCGLCHL<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x29B1B80", Offset = "0x29B0380", VA = "0x1829B1B80")]
	public static global::JDCDOIAPAPF<TSourceEnumerator, TResultEnumerator, TResult> JHJEMGCCOKM<TSourceEnumerator>(in TSourceEnumerator MHKBKFBCDKB) where TSourceEnumerator : IEnumerator<TResultEnumerator>
	{
		return default(global::JDCDOIAPAPF<TSourceEnumerator, TResultEnumerator, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct JDCDOIAPAPF<TSourceEnumerator, TResultEnumerator, TResult> : global::MJJHLCGLCHL<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : IEnumerator<TResultEnumerator> where TResultEnumerator : global::MJJHLCGLCHL<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private TSourceEnumerator JADENONKCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private TResultEnumerator JFEOPBBMNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool MNOBCLDCNII;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public TResult DIBBIBNFCIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4295A20", Offset = "0x4294220", VA = "0x184295A20", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x4295980", Offset = "0x4294180", VA = "0x184295980", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x4295980", Offset = "0x4294180", VA = "0x184295980", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x42959D0", Offset = "0x42941D0", VA = "0x1842959D0")]
	internal JDCDOIAPAPF(in TSourceEnumerator MHKBKFBCDKB, in TResultEnumerator CDOEEBFGICL, bool GIAGKAMJKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x4295800", Offset = "0x4294000", VA = "0x184295800", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x4295930", Offset = "0x4294130", VA = "0x184295930", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x42957B0", Offset = "0x4293FB0", VA = "0x1842957B0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct IDKNPDIHHJH<TSourceEnumerator, TSource, TResult> : DOGPBFKLNCD, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : DOGPBFKLNCD, global::MJJHLCGLCHL<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private TSourceEnumerator JADENONKCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly global::EPDDKFPIBDB<TSource, TResult> LOPDDPMMIDE;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int MPKAKPNFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2A3CD30", Offset = "0x2A3B530", VA = "0x182A3CD30", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public TResult DIBBIBNFCIE
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D550", Offset = "0x2A3BD50", VA = "0x182A3D550", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D180", Offset = "0x2A3B980", VA = "0x182A3D180", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x29844D0", Offset = "0x2982CD0", VA = "0x1829844D0")]
	internal IDKNPDIHHJH(in TSourceEnumerator MHKBKFBCDKB, global::EPDDKFPIBDB<TSource, TResult> HIDOPMCGPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2A3CA10", Offset = "0x2A3B210", VA = "0x182A3CA10", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x2A3D010", Offset = "0x2A3B810", VA = "0x182A3D010", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C830", Offset = "0x2A3B030", VA = "0x182A3C830", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct LIILHCHFKPJ<TSourceEnumerator, TSource, TResultEnumerator, TResult> : global::MJJHLCGLCHL<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : global::MJJHLCGLCHL<TSource> where TResultEnumerator : global::MJJHLCGLCHL<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private TSourceEnumerator JADENONKCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private TResultEnumerator JFEOPBBMNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly global::EPDDKFPIBDB<TSource, TResultEnumerator> LOPDDPMMIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private bool MNOBCLDCNII;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public TResult DIBBIBNFCIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x414F310", Offset = "0x414DB10", VA = "0x18414F310", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x414F220", Offset = "0x414DA20", VA = "0x18414F220", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x414F220", Offset = "0x414DA20", VA = "0x18414F220", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x414F2B0", Offset = "0x414DAB0", VA = "0x18414F2B0")]
	internal LIILHCHFKPJ(in TSourceEnumerator MHKBKFBCDKB, in TResultEnumerator CDOEEBFGICL, global::EPDDKFPIBDB<TSource, TResultEnumerator> HIDOPMCGPCH, bool GIAGKAMJKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x414F040", Offset = "0x414D840", VA = "0x18414F040", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x414F1D0", Offset = "0x414D9D0", VA = "0x18414F1D0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x414EFF0", Offset = "0x414D7F0", VA = "0x18414EFF0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct BPPKLPMGOAD<TSource1Enumerator, TSource1, TSource2Enumerator, TSource2> : DOGPBFKLNCD, IEnumerator<(TSource1, TSource2)>, IEnumerator, IDisposable where TSource1Enumerator : DOGPBFKLNCD, global::MJJHLCGLCHL<TSource1> where TSource2Enumerator : DOGPBFKLNCD, global::MJJHLCGLCHL<TSource2>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private TSource1Enumerator GLPMKEFOIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private TSource2Enumerator LNHIPLCCGOF;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int MPKAKPNFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x23CEC90", Offset = "0x23CD490", VA = "0x1823CEC90", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public (TSource1, TSource2) DIBBIBNFCIE
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x23CEE80", Offset = "0x23CD680", VA = "0x1823CEE80", Slot = "5")]
		get
		{
			return default((TSource1, TSource2));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x23CEDA0", Offset = "0x23CD5A0", VA = "0x1823CEDA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x23CEE40", Offset = "0x23CD640", VA = "0x1823CEE40")]
	internal BPPKLPMGOAD(in TSource1Enumerator EMLDBJCLMGJ, in TSource2Enumerator PAJPFIPFNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x23CEC20", Offset = "0x23CD420", VA = "0x1823CEC20", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x23CED30", Offset = "0x23CD530", VA = "0x1823CED30", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x23CEBC0", Offset = "0x23CD3C0", VA = "0x1823CEBC0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct DDLHIKHBBPH<T, U> : global::NLOOGAGDPDH<T, U>, IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly U OAGHNMFHJGN;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x357E8F0", Offset = "0x357D0F0", VA = "0x18357E8F0")]
	internal DDLHIKHBBPH(in U MJKCNLOOHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x721500", Offset = "0x71FD00", VA = "0x180721500", Slot = "4")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3FEC130", Offset = "0x3FEA930", VA = "0x183FEC130", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3FEC130", Offset = "0x3FEA930", VA = "0x183FEC130", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class HBBCEPKJPAF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x247BCB0", Offset = "0x247A4B0", VA = "0x18247BCB0")]
	public static global::DDLHIKHBBPH<T, U> HFGDAGIMEIK<U>(in U MJKCNLOOHEI) where U : IEnumerator<T>
	{
		return default(global::DDLHIKHBBPH<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct JMAGOCJKDKP<TSourceEnumerator, TSource, TResult> : DOGPBFKLNCD, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : DOGPBFKLNCD, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private TSourceEnumerator JADENONKCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Func<TSource, TResult> LOPDDPMMIDE;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int MPKAKPNFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2CF59B0", Offset = "0x2CF41B0", VA = "0x182CF59B0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public TResult DIBBIBNFCIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2CF5AF0", Offset = "0x2CF42F0", VA = "0x182CF5AF0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2CF5AB0", Offset = "0x2CF42B0", VA = "0x182CF5AB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2A3D240", Offset = "0x2A3BA40", VA = "0x182A3D240")]
	internal JMAGOCJKDKP(in TSourceEnumerator MHKBKFBCDKB, Func<TSource, TResult> HIDOPMCGPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2CF5960", Offset = "0x2CF4160", VA = "0x182CF5960", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2CF5A60", Offset = "0x2CF4260", VA = "0x182CF5A60", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2CF5910", Offset = "0x2CF4110", VA = "0x182CF5910", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class BINBGJHDFLD
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3B2EA30", Offset = "0x3B2D230", VA = "0x183B2EA30")]
	public static bool IMNIMGICAOB<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator MHKBKFBCDKB, in TArgs IKIFFPJKHAG, in global::HANABMBLECC<TArgs, TSource, bool> IKPJLAAHIHL) where TSourceEnumerator : global::MJJHLCGLCHL<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x26A9A00", Offset = "0x26A8200", VA = "0x1826A9A00")]
	public static int HBPPPGIENPL<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator MHKBKFBCDKB, in TArgs IKIFFPJKHAG, global::HANABMBLECC<TArgs, TSource, bool> IKPJLAAHIHL) where TSourceEnumerator : global::MJJHLCGLCHL<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3B2E8E0", Offset = "0x3B2D0E0", VA = "0x183B2E8E0")]
	public static bool GPLBIEJFMLP<TSourceEnumerator, TSource>(this TSourceEnumerator MHKBKFBCDKB, in TSource BOJBBPBHNOH) where TSourceEnumerator : global::MJJHLCGLCHL<TSource> where TSource : global::DGOCHJFNFHL<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x26A96E0", Offset = "0x26A7EE0", VA = "0x1826A96E0")]
	public static int COEPLBGAHLA<TSourceEnumerator, TSource>(this TSourceEnumerator MHKBKFBCDKB, in TSource HKJMLEKHILN) where TSourceEnumerator : global::MJJHLCGLCHL<TSource> where TSource : global::DGOCHJFNFHL<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x29A84B0", Offset = "0x29A6CB0", VA = "0x1829A84B0")]
	public static global::IDKNPDIHHJH<TSourceEnumerator, TSource, TResult> GMBDPADLIKD<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator MHKBKFBCDKB, global::EPDDKFPIBDB<TSource, TResult> HIDOPMCGPCH) where TSourceEnumerator : DOGPBFKLNCD, global::MJJHLCGLCHL<TSource>
	{
		return default(global::IDKNPDIHHJH<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x24AC6F0", Offset = "0x24AAEF0", VA = "0x1824AC6F0")]
	public static global::JMAGOCJKDKP<TSourceEnumerator, TSource, TResult> PLJJCNHIPFO<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator MHKBKFBCDKB, Func<TSource, TResult> HIDOPMCGPCH) where TSourceEnumerator : DOGPBFKLNCD, IEnumerator<TSource>
	{
		return default(global::JMAGOCJKDKP<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class CPOFODGJPEL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3B2F1B0", Offset = "0x3B2D9B0", VA = "0x183B2F1B0")]
	public static bool EKAFFJPIOCF<TSourceEnumerator>(TSourceEnumerator MHKBKFBCDKB) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F280", Offset = "0x2A6DA80", VA = "0x182A6F280")]
	public static T PBPAMHBAFLI<TSourceEnumerator>(TSourceEnumerator MHKBKFBCDKB) where TSourceEnumerator : global::MJJHLCGLCHL<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x222B8D0", Offset = "0x222A0D0", VA = "0x18222B8D0")]
	public static global::LIILHCHFKPJ<TSourceEnumerator, TSource, TResultEnumerator, T> MBENLALCAPP<TSourceEnumerator, TSource, TResultEnumerator>(in TSourceEnumerator MHKBKFBCDKB, global::EPDDKFPIBDB<TSource, TResultEnumerator> HIDOPMCGPCH) where TSourceEnumerator : global::MJJHLCGLCHL<TSource> where TResultEnumerator : global::MJJHLCGLCHL<T>
	{
		return default(global::LIILHCHFKPJ<TSourceEnumerator, TSource, TResultEnumerator, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0F30", Offset = "0x2BBF730", VA = "0x182BC0F30")]
	public static string GFDMDDDMDKC<TSourceEnumerator>(TSourceEnumerator MHKBKFBCDKB) where TSourceEnumerator : IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3979AA0", Offset = "0x39782A0", VA = "0x183979AA0")]
	public static T[] GBBFLKJIECM<TSourceEnumerator>(TSourceEnumerator MHKBKFBCDKB) where TSourceEnumerator : DOGPBFKLNCD, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x238DE50", Offset = "0x238C650", VA = "0x18238DE50")]
	public static T NADHABEINJI<TSourceEnumerator>(TSourceEnumerator MHKBKFBCDKB) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3B2F2E0", Offset = "0x3B2DAE0", VA = "0x183B2F2E0")]
	public static bool HPLLPJEFFPI<TSourceEnumerator>(TSourceEnumerator MHKBKFBCDKB) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class OBBHDCAPCMK<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x247F680", Offset = "0x247DE80", VA = "0x18247F680")]
	public static global::BPPKLPMGOAD<TSource1Enumerator, T, TSource2Enumerator, U> COGBLJJIGEH<TSource1Enumerator, TSource2Enumerator>(in TSource1Enumerator EMLDBJCLMGJ, in TSource2Enumerator PAJPFIPFNMG) where TSource1Enumerator : DOGPBFKLNCD, global::MJJHLCGLCHL<T> where TSource2Enumerator : DOGPBFKLNCD, global::MJJHLCGLCHL<U>
	{
		return default(global::BPPKLPMGOAD<TSource1Enumerator, T, TSource2Enumerator, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface DKDCGAGJCCA<T>
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::MJJHLCGLCHL<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface IHOJEPDHGCI<T, TEnumerator> : global::DKDCGAGJCCA<T>, global::NLOOGAGDPDH<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::MJJHLCGLCHL<T>
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface MJJHLCGLCHL<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	T DIBBIBNFCIE
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface KABAINCMBHP<T> : DOGPBFKLNCD
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T CNHABHDIDFG(int HPENCEMKHKB);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface NLOOGAGDPDH<T, TEnumerator> : IEnumerable<T>, IEnumerable where TEnumerator : IEnumerator<T>
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface DOGPBFKLNCD
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	int MPKAKPNFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface DGOCHJFNFHL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AHLDFICBMOI(in T EFDJFLPIKFF);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface DCNGNGOICNG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::OFBGFBMNOAO<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface BMKGLPHGONC<T, TEnumerator> : global::DCNGNGOICNG<T>, global::IHOJEPDHGCI<T, TEnumerator>, global::DKDCGAGJCCA<T>, global::NLOOGAGDPDH<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::OFBGFBMNOAO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface OFBGFBMNOAO<T> : global::MJJHLCGLCHL<T>, IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	new T DIBBIBNFCIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public delegate void IFPCKEPJKDN<T>(in T NJMKOLAAABP);
[Cpp2IlInjected.Token(Token = "0x200004A")]
public delegate void CMHLCMMEKJO<T1, T2>(in T1 KOCKFGDKICI, in T2 DALGOMGHMNB);
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class OPEDDMDOOHM
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x246E020", Offset = "0x246C820", VA = "0x18246E020")]
	public static bool GFAMHLCELFF<T, U>(this T MHKBKFBCDKB, in U ALCFLDIFDGE) where T : global::DGOCHJFNFHL<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public delegate TResult EPDDKFPIBDB<T, out TResult>(in T NJMKOLAAABP);
[Cpp2IlInjected.Token(Token = "0x200004D")]
public delegate TResult HANABMBLECC<T1, T2, out TResult>(in T1 KOCKFGDKICI, in T2 DALGOMGHMNB);
[Cpp2IlInjected.Token(Token = "0x200004E")]
public delegate TResult DPOIJLEGAOK<T1, T2, T3, out TResult>(in T1 KOCKFGDKICI, in T2 DALGOMGHMNB, in T3 LIKHPGLGJBG);
[Cpp2IlInjected.Token(Token = "0x200004F")]
public delegate TResult FLGLOJHKPBL<T, TResult>(in T NJMKOLAAABP);
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate TResult KFNLJBEFDCJ<T1, T2, TResult>(in T1 KOCKFGDKICI, in T2 DALGOMGHMNB);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate TResult DNJHFIDLJGH<T1, T2, T3, TResult>(in T1 KOCKFGDKICI, in T2 DALGOMGHMNB, in T3 LIKHPGLGJBG);
[Cpp2IlInjected.Token(Token = "0x2000052")]
[DefaultMember("Item")]
public struct EECNKKJNOPN<T> : global::BMKGLPHGONC<T, global::EECNKKJNOPN<T>.JNMEDKFGOII>, global::DCNGNGOICNG<T>, global::IHOJEPDHGCI<T, global::EECNKKJNOPN<T>.JNMEDKFGOII>, global::DKDCGAGJCCA<T>, global::NLOOGAGDPDH<T, global::EECNKKJNOPN<T>.JNMEDKFGOII>, IEnumerable<T>, IEnumerable, global::KABAINCMBHP<T>, DOGPBFKLNCD
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct JNMEDKFGOII : DOGPBFKLNCD, global::OFBGFBMNOAO<T>, global::MJJHLCGLCHL<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private T[] JADENONKCBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int KLIIEEHOFDJ;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int MPKAKPNFLIB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x6EE550", Offset = "0x6ECD50", VA = "0x1806EE550", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public T DIBBIBNFCIE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x2EF1BA0", Offset = "0x2EF03A0", VA = "0x182EF1BA0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		private T NFCNCKOHALN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x382F6A0", Offset = "0x382DEA0", VA = "0x18382F6A0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x2EF1B50", Offset = "0x2EF0350", VA = "0x182EF1B50", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x2EF1B50", Offset = "0x2EF0350", VA = "0x182EF1B50", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA2DC80", Offset = "0xA2C480", VA = "0x180A2DC80")]
		private JNMEDKFGOII(T[] MHKBKFBCDKB, int EDBBKGCLEJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2EF1AF0", Offset = "0x2EF02F0", VA = "0x182EF1AF0")]
		public static JNMEDKFGOII HFGDAGIMEIK(T[] MHKBKFBCDKB)
		{
			return default(JNMEDKFGOII);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1253BC0", Offset = "0x12523C0", VA = "0x181253BC0", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xBF1640", Offset = "0xBEFE40", VA = "0x180BF1640", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private T[] BGKIEACJMGF;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int ADPNOPOPGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6EE550", Offset = "0x6ECD50", VA = "0x1806EE550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int MPKAKPNFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x2EF5B90", Offset = "0x2EF4390", VA = "0x182EF5B90", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public T KJIAGDJOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x2EF5B50", Offset = "0x2EF4350", VA = "0x182EF5B50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x719100", Offset = "0x717900", VA = "0x180719100")]
	internal EECNKKJNOPN(T[] FOLGEBPFFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x2EF5A50", Offset = "0x2EF4250", VA = "0x182EF5A50", Slot = "11")]
	public T CNHABHDIDFG(int EDBBKGCLEJF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3192660", Offset = "0x3190E60", VA = "0x183192660")]
	public global::NDOFNCFDHGM<T> IFOOGCMEHDF()
	{
		return default(global::NDOFNCFDHGM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x38249D0", Offset = "0x38231D0", VA = "0x1838249D0", Slot = "8")]
	public JNMEDKFGOII GetEnumerator()
	{
		return default(JNMEDKFGOII);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x38248D0", Offset = "0x38230D0", VA = "0x1838248D0", Slot = "5")]
	private global::OFBGFBMNOAO<T> GLIBNPGIFKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x38248D0", Offset = "0x38230D0", VA = "0x1838248D0", Slot = "7")]
	private global::MJJHLCGLCHL<T> CEHACJCGODK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x38248D0", Offset = "0x38230D0", VA = "0x1838248D0", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x38248D0", Offset = "0x38230D0", VA = "0x1838248D0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class JHEFLMPCHDI
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x247D870", Offset = "0x247C070", VA = "0x18247D870")]
	public static global::EECNKKJNOPN<T> HFGDAGIMEIK<T>(T[] FOLGEBPFFME)
	{
		return default(global::EECNKKJNOPN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x247D8A0", Offset = "0x247C0A0", VA = "0x18247D8A0")]
	public static global::EECNKKJNOPN<T> HKPJOEMCIBF<T>()
	{
		return default(global::EECNKKJNOPN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x1BDC260", Offset = "0x1BDAA60", VA = "0x181BDC260")]
	public static global::EECNKKJNOPN<T> GDINAJIIEGI<T>(this T[] MHKBKFBCDKB)
	{
		return default(global::EECNKKJNOPN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2230CF0", Offset = "0x222F4F0", VA = "0x182230CF0")]
	public static global::EECNKKJNOPN<T>.JNMEDKFGOII FLBFBJGBIGH<T>(this T[] MHKBKFBCDKB)
	{
		return default(global::EECNKKJNOPN<T>.JNMEDKFGOII);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x1BDC260", Offset = "0x1BDAA60", VA = "0x181BDC260")]
	public static global::EECNKKJNOPN<T> DABIHJGGDAA<T>(this T[] MHKBKFBCDKB)
	{
		return default(global::EECNKKJNOPN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct HCPONFONFNA<T, U> : global::BMKGLPHGONC<T, U>, global::DCNGNGOICNG<T>, global::IHOJEPDHGCI<T, U>, global::DKDCGAGJCCA<T>, global::NLOOGAGDPDH<T, U>, IEnumerable<T>, IEnumerable where U : global::OFBGFBMNOAO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly U OAGHNMFHJGN;

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2A3DF60", Offset = "0x2A3C760", VA = "0x182A3DF60")]
	internal HCPONFONFNA(in U MJKCNLOOHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x60DD50", Offset = "0x60C550", VA = "0x18060DD50", Slot = "8")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3F32940", Offset = "0x3F31140", VA = "0x183F32940", Slot = "5")]
	private global::OFBGFBMNOAO<T> GLIBNPGIFKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3F32940", Offset = "0x3F31140", VA = "0x183F32940", Slot = "7")]
	private global::MJJHLCGLCHL<T> CEHACJCGODK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3F32940", Offset = "0x3F31140", VA = "0x183F32940", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x3F32940", Offset = "0x3F31140", VA = "0x183F32940", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class ALAKNIOAKCI<T>
{
	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x247BCF0", Offset = "0x247A4F0", VA = "0x18247BCF0")]
	public static global::HCPONFONFNA<T, U> HFGDAGIMEIK<U>(in U MJKCNLOOHEI) where U : global::OFBGFBMNOAO<T>
	{
		return default(global::HCPONFONFNA<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[DefaultMember("Item")]
public class JCFBPCMJALD<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly Func<Internal, External> KPMPGCMFKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Func<External, Internal> GPGCFJDADPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private IList<Internal> JKPOELIJJNH;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public IList<Internal> HLJKGMIKKKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x574E70", Offset = "0x573670", VA = "0x180574E70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x576710", Offset = "0x574F10", VA = "0x180576710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool FIOIIHPDJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x73E020", Offset = "0x73C820", VA = "0x18073E020", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x73E070", Offset = "0x73C870", VA = "0x18073E070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public External KJIAGDJOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x42954A0", Offset = "0x4293CA0", VA = "0x1842954A0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4295540", Offset = "0x4293D40", VA = "0x184295540", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int MPKAKPNFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4295440", Offset = "0x4293C40", VA = "0x184295440", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x42953B0", Offset = "0x4293BB0", VA = "0x1842953B0")]
	public JCFBPCMJALD(Func<Internal, External> KPMPGCMFKFM, Func<External, Internal> GPGCFJDADPP, bool OBJOEKFIIBF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x42950C0", Offset = "0x42938C0", VA = "0x1842950C0", Slot = "6")]
	public int IndexOf(External BOJBBPBHNOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4294D40", Offset = "0x4293540", VA = "0x184294D40", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4294DA0", Offset = "0x42935A0", VA = "0x184294DA0", Slot = "13")]
	public bool Contains(External BOJBBPBHNOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x4294E30", Offset = "0x4293630", VA = "0x184294E30", Slot = "14")]
	public void CopyTo(External[] FOLGEBPFFME, int ACENJMBACBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4294C50", Offset = "0x4293450", VA = "0x184294C50", Slot = "11")]
	public void Add(External BOJBBPBHNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x42951B0", Offset = "0x42939B0", VA = "0x1842951B0", Slot = "7")]
	public void Insert(int EDBBKGCLEJF, External BOJBBPBHNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x4295320", Offset = "0x4293B20", VA = "0x184295320", Slot = "15")]
	public bool Remove(External BOJBBPBHNOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x4295250", Offset = "0x4293A50", VA = "0x184295250", Slot = "8")]
	public void RemoveAt(int EDBBKGCLEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x4295050", Offset = "0x4293850", VA = "0x184295050", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2313FB0", Offset = "0x23127B0", VA = "0x182313FB0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[DefaultMember("Item")]
public class IJLHFKPPPMK<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Func<Internal, External> KPMPGCMFKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyList<Internal> JKPOELIJJNH;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public IReadOnlyList<Internal> HLJKGMIKKKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x575980", Offset = "0x574180", VA = "0x180575980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool FIOIIHPDJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5749D0", Offset = "0x5731D0", VA = "0x1805749D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public External KJIAGDJOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x42917C0", Offset = "0x428FFC0", VA = "0x1842917C0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public int MPKAKPNFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x4291760", Offset = "0x428FF60", VA = "0x184291760", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2806BE0", Offset = "0x28053E0", VA = "0x182806BE0")]
	public IJLHFKPPPMK(Func<Internal, External> KPMPGCMFKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4291710", Offset = "0x428FF10", VA = "0x184291710")]
	public IJLHFKPPPMK(IReadOnlyList<Internal> JKPOELIJJNH, Func<Internal, External> KPMPGCMFKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4291480", Offset = "0x428FC80", VA = "0x184291480")]
	public void AGMNAELGCNF(External[] FOLGEBPFFME, int ACENJMBACBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x42916A0", Offset = "0x428FEA0", VA = "0x1842916A0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x24978A0", Offset = "0x24960A0", VA = "0x1824978A0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DefaultMember("Item")]
public class HDHMHCLMGBB<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private IReadOnlyList<Internal> JKPOELIJJNH;

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public IReadOnlyList<Internal> HLJKGMIKKKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F780", VA = "0x180570F80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5DDA30", Offset = "0x5DC230", VA = "0x1805DDA30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool FIOIIHPDJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5749D0", Offset = "0x5731D0", VA = "0x1805749D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public External KJIAGDJOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x43EAC60", Offset = "0x43E9460", VA = "0x1843EAC60", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int MPKAKPNFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x43EAC00", Offset = "0x43E9400", VA = "0x1843EAC00", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x2806BE0", Offset = "0x28053E0", VA = "0x182806BE0")]
	public HDHMHCLMGBB(IReadOnlyList<Internal> JKPOELIJJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x43EAAF0", Offset = "0x43E92F0", VA = "0x1843EAAF0")]
	public bool BMCMFPADDFE(External BOJBBPBHNOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x43EA8C0", Offset = "0x43E90C0", VA = "0x1843EA8C0")]
	public void AGMNAELGCNF(External[] FOLGEBPFFME, int ACENJMBACBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x43EAB90", Offset = "0x43E9390", VA = "0x1843EAB90", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2313FB0", Offset = "0x23127B0", VA = "0x182313FB0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public abstract class BNILJDFIJHN
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void DDBPKEFIMCI(object[] IKIFFPJKHAG);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	protected BNILJDFIJHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public abstract class BHJELKILIBL<T> : BNILJDFIJHN
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	protected struct BFBIALCNMKL
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public enum CGALJOALKNH
		{
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public CGALJOALKNH LIBGCFIILKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public T BBFDPEJCJGH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int AIDBFNANPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly bool KMPKIPICOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	protected readonly bool LGMFMKCGPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	protected List<T> EAAOEIOFCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private List<BFBIALCNMKL> MMKJJKBOJAO;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool GHJDBCJBLNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x42D8EA0", Offset = "0x42D76A0", VA = "0x1842D8EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x42D9370", Offset = "0x42D7B70", VA = "0x1842D9370")]
	protected BHJELKILIBL(bool LGMFMKCGPIN, bool KMPKIPICOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x42D8EE0", Offset = "0x42D76E0", VA = "0x1842D8EE0")]
	protected bool GOEDFBLGPLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x42D90E0", Offset = "0x42D78E0", VA = "0x1842D90E0")]
	protected void MJJDFPLLOOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x42D91C0", Offset = "0x42D79C0", VA = "0x1842D91C0")]
	protected void PBGOBFFKIAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x25A9B70", Offset = "0x25A8370", VA = "0x1825A9B70")]
	private static void PHJBDJJCIKA<U>(ref List<U> JKPOELIJJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x42D8D20", Offset = "0x42D7520", VA = "0x1842D8D20", Slot = "5")]
	public void DEOBKNOOHMB(T BBFDPEJCJGH, bool BBEFNBEPNBO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x42D8F80", Offset = "0x42D7780", VA = "0x1842D8F80", Slot = "6")]
	public void IIDOOJBFPNM(T BBFDPEJCJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x42D8BF0", Offset = "0x42D73F0", VA = "0x1842D8BF0")]
	public void CPGPLJLMCBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface BMCOKMLOIOC
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEOBKNOOHMB(Action BBFDPEJCJGH, bool BBEFNBEPNBO = false);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIDOOJBFPNM(Action BBFDPEJCJGH);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class KKJEBJGGJMD : global::BHJELKILIBL<Action>, BMCOKMLOIOC
{
	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x4F87820", Offset = "0x4F86020", VA = "0x184F87820")]
	public KKJEBJGGJMD(bool LGMFMKCGPIN = false, bool KMPKIPICOKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x4F87660", Offset = "0x4F85E60", VA = "0x184F87660")]
	public void OPLNNDBDGBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x4F87520", Offset = "0x4F85D20", VA = "0x184F87520", Slot = "4")]
	public override void DDBPKEFIMCI(object[] IKIFFPJKHAG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x4F875A0", Offset = "0x4F85DA0", VA = "0x184F875A0")]
	public static KKJEBJGGJMD DNNHMNKHDPN(KKJEBJGGJMD CLDNIGNMGOP, Action BBFDPEJCJGH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x4F87600", Offset = "0x4F85E00", VA = "0x184F87600")]
	public static KKJEBJGGJMD JHLNBHPJLDA(KKJEBJGGJMD CLDNIGNMGOP, Action BBFDPEJCJGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface KOBJANKENNB<T>
{
	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEOBKNOOHMB(Action<T> BBFDPEJCJGH, bool BBEFNBEPNBO = false);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIDOOJBFPNM(Action<T> BBFDPEJCJGH);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public sealed class HNGBGJMLEKL<T> : global::BHJELKILIBL<Action<T>>, global::KOBJANKENNB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0xF4A960", Offset = "0xF49160", VA = "0x180F4A960")]
	public HNGBGJMLEKL(bool LGMFMKCGPIN = false, bool KMPKIPICOKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3D98BA0", Offset = "0x3D973A0", VA = "0x183D98BA0")]
	public void OPLNNDBDGBH(T AELOFOBLNEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3D960D0", Offset = "0x3D948D0", VA = "0x183D960D0", Slot = "4")]
	public override void DDBPKEFIMCI(object[] IKIFFPJKHAG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3D977B0", Offset = "0x3D95FB0", VA = "0x183D977B0")]
	public static global::HNGBGJMLEKL<T> DNNHMNKHDPN(global::HNGBGJMLEKL<T> CLDNIGNMGOP, Action<T> BBFDPEJCJGH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3D97850", Offset = "0x3D96050", VA = "0x183D97850")]
	public static global::HNGBGJMLEKL<T> JHLNBHPJLDA(global::HNGBGJMLEKL<T> CLDNIGNMGOP, Action<T> BBFDPEJCJGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface OLCMCIAJCNC<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEOBKNOOHMB(Action<T, U> BBFDPEJCJGH, bool BBEFNBEPNBO = false);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIDOOJBFPNM(Action<T, U> BBFDPEJCJGH);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public sealed class DAAFDLANJFF<T, U> : global::BHJELKILIBL<Action<T, U>>, global::OLCMCIAJCNC<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xF4A960", Offset = "0xF49160", VA = "0x180F4A960")]
	public DAAFDLANJFF(bool LGMFMKCGPIN = false, bool KMPKIPICOKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x3FE7860", Offset = "0x3FE6060", VA = "0x183FE7860")]
	public void OPLNNDBDGBH(T AELOFOBLNEI, U FKOKJBHGNOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x3FE2940", Offset = "0x3FE1140", VA = "0x183FE2940", Slot = "4")]
	public override void DDBPKEFIMCI(object[] IKIFFPJKHAG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x3FE50A0", Offset = "0x3FE38A0", VA = "0x183FE50A0")]
	public static global::DAAFDLANJFF<T, U> DNNHMNKHDPN(global::DAAFDLANJFF<T, U> CLDNIGNMGOP, Action<T, U> BBFDPEJCJGH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x3FE5140", Offset = "0x3FE3940", VA = "0x183FE5140")]
	public static global::DAAFDLANJFF<T, U> JHLNBHPJLDA(global::DAAFDLANJFF<T, U> CLDNIGNMGOP, Action<T, U> BBFDPEJCJGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface CDENHNKPPAK<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEOBKNOOHMB(Action<T, U, V> BBFDPEJCJGH, bool BBEFNBEPNBO = false);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIDOOJBFPNM(Action<T, U, V> BBFDPEJCJGH);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public sealed class KJJOEBLAINO<T, U, V> : global::BHJELKILIBL<Action<T, U, V>>, global::CDENHNKPPAK<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0xF4A960", Offset = "0xF49160", VA = "0x180F4A960")]
	public KJJOEBLAINO(bool LGMFMKCGPIN = false, bool KMPKIPICOKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x33BE000", Offset = "0x33BC800", VA = "0x1833BE000")]
	public void OPLNNDBDGBH(T AELOFOBLNEI, U FKOKJBHGNOI, V KDMLNPNMPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x33BB130", Offset = "0x33B9930", VA = "0x1833BB130", Slot = "4")]
	public override void DDBPKEFIMCI(object[] IKIFFPJKHAG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x33BC9D0", Offset = "0x33BB1D0", VA = "0x1833BC9D0")]
	public static global::KJJOEBLAINO<T, U, V> DNNHMNKHDPN(global::KJJOEBLAINO<T, U, V> CLDNIGNMGOP, Action<T, U, V> BBFDPEJCJGH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x33BCA70", Offset = "0x33BB270", VA = "0x1833BCA70")]
	public static global::KJJOEBLAINO<T, U, V> JHLNBHPJLDA(global::KJJOEBLAINO<T, U, V> CLDNIGNMGOP, Action<T, U, V> BBFDPEJCJGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface KKFNKELNJPC<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEOBKNOOHMB(Action<T, U, V, W> BBFDPEJCJGH, bool BBEFNBEPNBO = false);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIDOOJBFPNM(Action<T, U, V, W> BBFDPEJCJGH);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public sealed class NEBNECJCBDG<T, U, V, W> : global::BHJELKILIBL<Action<T, U, V, W>>, global::KKFNKELNJPC<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xF4A960", Offset = "0xF49160", VA = "0x180F4A960")]
	public NEBNECJCBDG(bool LGMFMKCGPIN = false, bool KMPKIPICOKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x2EF8690", Offset = "0x2EF6E90", VA = "0x182EF8690")]
	public void OPLNNDBDGBH(T AELOFOBLNEI, U FKOKJBHGNOI, V KDMLNPNMPPG, W JOBBLOMPKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2EF60B0", Offset = "0x2EF48B0", VA = "0x182EF60B0", Slot = "4")]
	public override void DDBPKEFIMCI(object[] IKIFFPJKHAG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2EF7240", Offset = "0x2EF5A40", VA = "0x182EF7240")]
	public static global::NEBNECJCBDG<T, U, V, W> DNNHMNKHDPN(global::NEBNECJCBDG<T, U, V, W> CLDNIGNMGOP, Action<T, U, V, W> BBFDPEJCJGH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2EF72E0", Offset = "0x2EF5AE0", VA = "0x182EF72E0")]
	public static global::NEBNECJCBDG<T, U, V, W> JHLNBHPJLDA(global::NEBNECJCBDG<T, U, V, W> CLDNIGNMGOP, Action<T, U, V, W> BBFDPEJCJGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface EHGODOHDBLI<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEOBKNOOHMB(Action<T, U, V, W, X> BBFDPEJCJGH, bool BBEFNBEPNBO = false);

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIDOOJBFPNM(Action<T, U, V, W, X> BBFDPEJCJGH);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public sealed class JIMNLOELBFA<T, U, V, W, X> : global::BHJELKILIBL<Action<T, U, V, W, X>>, global::EHGODOHDBLI<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xF4A960", Offset = "0xF49160", VA = "0x180F4A960")]
	public JIMNLOELBFA(bool LGMFMKCGPIN = false, bool KMPKIPICOKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2CF5040", Offset = "0x2CF3840", VA = "0x182CF5040")]
	public void OPLNNDBDGBH(T AELOFOBLNEI, U FKOKJBHGNOI, V KDMLNPNMPPG, W JOBBLOMPKMF, X FNGOAMCGAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2CF4C10", Offset = "0x2CF3410", VA = "0x182CF4C10", Slot = "4")]
	public override void DDBPKEFIMCI(object[] IKIFFPJKHAG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x2CF4F00", Offset = "0x2CF3700", VA = "0x182CF4F00")]
	public static global::JIMNLOELBFA<T, U, V, W, X> DNNHMNKHDPN(global::JIMNLOELBFA<T, U, V, W, X> CLDNIGNMGOP, Action<T, U, V, W, X> BBFDPEJCJGH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x2CF4FA0", Offset = "0x2CF37A0", VA = "0x182CF4FA0")]
	public static global::JIMNLOELBFA<T, U, V, W, X> JHLNBHPJLDA(global::JIMNLOELBFA<T, U, V, W, X> CLDNIGNMGOP, Action<T, U, V, W, X> BBFDPEJCJGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface EPBPOPEECMF<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEOBKNOOHMB(Action<T, U, V, W, X, Y> BBFDPEJCJGH, bool BBEFNBEPNBO = false);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIDOOJBFPNM(Action<T, U, V, W, X, Y> BBFDPEJCJGH);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public sealed class HCJONJIJLKC<T, U, V, W, X, Y> : global::BHJELKILIBL<Action<T, U, V, W, X, Y>>, global::EPBPOPEECMF<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0xF4A960", Offset = "0xF49160", VA = "0x180F4A960")]
	public HCJONJIJLKC(bool LGMFMKCGPIN = false, bool KMPKIPICOKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x43EA320", Offset = "0x43E8B20", VA = "0x1843EA320")]
	public void OPLNNDBDGBH(T AELOFOBLNEI, U FKOKJBHGNOI, V KDMLNPNMPPG, W JOBBLOMPKMF, X FNGOAMCGAPH, Y HDKMFDOPGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x43E94D0", Offset = "0x43E7CD0", VA = "0x1843E94D0", Slot = "4")]
	public override void DDBPKEFIMCI(object[] IKIFFPJKHAG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x43E9ED0", Offset = "0x43E86D0", VA = "0x1843E9ED0")]
	public static global::HCJONJIJLKC<T, U, V, W, X, Y> DNNHMNKHDPN(global::HCJONJIJLKC<T, U, V, W, X, Y> CLDNIGNMGOP, Action<T, U, V, W, X, Y> BBFDPEJCJGH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x43E9F70", Offset = "0x43E8770", VA = "0x1843E9F70")]
	public static global::HCJONJIJLKC<T, U, V, W, X, Y> JHLNBHPJLDA(global::HCJONJIJLKC<T, U, V, W, X, Y> CLDNIGNMGOP, Action<T, U, V, W, X, Y> BBFDPEJCJGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public sealed class GGKKMPLLADB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public readonly struct LNOFNFPJNDE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly global::GGKKMPLLADB<T> LGOPECBPCIC;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public T MKOCEBDLMLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x3F3AF00", Offset = "0x3F39700", VA = "0x183F3AF00")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3F3AED0", Offset = "0x3F396D0", VA = "0x183F3AED0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x719100", Offset = "0x717900", VA = "0x180719100")]
		public LNOFNFPJNDE(global::GGKKMPLLADB<T> LGOPECBPCIC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct MMPCAIDPKON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<LNOFNFPJNDE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public global::GGKKMPLLADB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3F3B0F0", Offset = "0x3F398F0", VA = "0x183F3B0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3F3B2C0", Offset = "0x3F39AC0", VA = "0x183F3B2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct PKDMKAEAMIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder<LNOFNFPJNDE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public global::GGKKMPLLADB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3F3B4C0", Offset = "0x3F39CC0", VA = "0x183F3B4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3F3B2C0", Offset = "0x3F39AC0", VA = "0x183F3B2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly SemaphoreSlim DNCFOPDBAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private T DKNCEFKFGPL;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int CPODCINDHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3F321F0", Offset = "0x3F309F0", VA = "0x183F321F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x3F327D0", Offset = "0x3F30FD0", VA = "0x183F327D0")]
	public GGKKMPLLADB(in T DKNCEFKFGPL, int GDPMJFGEPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x3F32910", Offset = "0x3F31110", VA = "0x183F32910")]
	public GGKKMPLLADB(in T DKNCEFKFGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x3F321B0", Offset = "0x3F309B0", VA = "0x183F321B0")]
	public LNOFNFPJNDE DDMLGGCLIAF()
	{
		return default(LNOFNFPJNDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x3F32170", Offset = "0x3F30970", VA = "0x183F32170")]
	public LNOFNFPJNDE DDMLGGCLIAF(CancellationToken OFMMACGDFGM)
	{
		return default(LNOFNFPJNDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x3F32390", Offset = "0x3F30B90", VA = "0x183F32390")]
	[AsyncStateMachine(typeof(global::GGKKMPLLADB<>.MMPCAIDPKON))]
	public Task<LNOFNFPJNDE> PPCAHHLELME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x3F32210", Offset = "0x3F30A10", VA = "0x183F32210")]
	[AsyncStateMachine(typeof(global::GGKKMPLLADB<>.PKDMKAEAMIH))]
	public Task<LNOFNFPJNDE> PPCAHHLELME(CancellationToken OFMMACGDFGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class FENBPJKDDMF
{
	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x4F85A50", Offset = "0x4F84250", VA = "0x184F85A50")]
	public static global::GGKKMPLLADB<CMMMKLGEKCJ> HFGDAGIMEIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x4F859E0", Offset = "0x4F841E0", VA = "0x184F859E0")]
	public static global::GGKKMPLLADB<CMMMKLGEKCJ> HFGDAGIMEIK(int GDPMJFGEPEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x21A7A80", Offset = "0x21A6280", VA = "0x1821A7A80")]
	public static global::GGKKMPLLADB<T> HFGDAGIMEIK<T>(in T DKNCEFKFGPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x247D790", Offset = "0x247BF90", VA = "0x18247D790")]
	public static global::GGKKMPLLADB<T> HFGDAGIMEIK<T>(in T DKNCEFKFGPL, int GDPMJFGEPEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class JNBLHLKAFAH<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public delegate bool JBHCJAKKAOP(global::JNBLHLKAFAH<T> OGNJOKKMMDG);

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class OECJGCANAKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public global::JNBLHLKAFAH<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
		public OECJGCANAKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2CFB010", Offset = "0x2CF9810", VA = "0x182CFB010")]
		internal bool <FindNode>b__0(global::JNBLHLKAFAH<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public T PNCNJIDHGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public LinkedList<global::JNBLHLKAFAH<T>> ADKJKIGDMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public global::JNBLHLKAFAH<T> LBPHHDGHGIO;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public global::JNBLHLKAFAH<T> IKJEADEFGPG
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x5FBAB0", Offset = "0x5FA2B0", VA = "0x1805FBAB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2CF6F30", Offset = "0x2CF5730", VA = "0x182CF6F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool JOAEDFEBEGL
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2CF6F00", Offset = "0x2CF5700", VA = "0x182CF6F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool BOJFDIAOMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2CF7F10", Offset = "0x2CF6710", VA = "0x182CF7F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public global::JNBLHLKAFAH<T> ANEDAECPNGH
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2CF85D0", Offset = "0x2CF6DD0", VA = "0x182CF85D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9090", Offset = "0x2CF7890", VA = "0x182CF9090")]
	public JNBLHLKAFAH(T KKNFDFEBEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x2CF70F0", Offset = "0x2CF58F0", VA = "0x182CF70F0")]
	public global::JNBLHLKAFAH<T> EKIJJHANCGF(T NHEAIHKAGIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8C60", Offset = "0x2CF7460", VA = "0x182CF8C60")]
	public global::JNBLHLKAFAH<T> PGFGBCKHLBH(T FDIDICPMPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7E20", Offset = "0x2CF6620", VA = "0x182CF7E20")]
	public global::JNBLHLKAFAH<T> IIDOOJBFPNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6A40", Offset = "0x2CF5240", VA = "0x182CF6A40")]
	public void CPGPLJLMCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8720", Offset = "0x2CF6F20", VA = "0x182CF8720")]
	public global::JNBLHLKAFAH<T> LBPKIFGNMOA(T IKMEAKHBLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8290", Offset = "0x2CF6A90", VA = "0x182CF8290")]
	public static void JKOPIOAFMNB(global::JNBLHLKAFAH<T> DFCHFALJEHM, JBHCJAKKAOP DMEDCBKJHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2AACD10", Offset = "0x2AAB510", VA = "0x182AACD10")]
	public static void JKOPIOAFMNB<A>(global::JNBLHLKAFAH<T> DFCHFALJEHM, Func<global::JNBLHLKAFAH<T>, A, bool> DMEDCBKJHHF, A NJMKOLAAABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7850", Offset = "0x2CF6050", VA = "0x182CF7850")]
	public static string IBGHIKIMOBJ(global::JNBLHLKAFAH<T> DFCHFALJEHM, int GFBINNEGMEM = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8A40", Offset = "0x2CF7240", VA = "0x182CF8A40")]
	public static global::JNBLHLKAFAH<T> MBGHAJIPMOK(global::JNBLHLKAFAH<T> DFCHFALJEHM, T KJJNIACBELJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class KCGKCJBPPLJ<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public delegate Task<TResult> PLEMCACENHM(TRequest EPNHPDGPFKK, CancellationToken OFMMACGDFGM);

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public enum BGEODENHDOL
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class HIDMCIHOJIL
	{
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private const float HOOGCCCEGKF = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TimeSpan EEOCLGMGBNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int NBDNOCONBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public BGEODENHDOL BCECFNEOKJA;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static readonly HIDMCIHOJIL GJCBCFPBGOE;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public float LDOCLBLNAAI
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x2BDCF60", Offset = "0x2BDB760", VA = "0x182BDCF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public TimeSpan KEKFAGMCDGE
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F780", VA = "0x180570F80")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD190", Offset = "0x2BDB990", VA = "0x182BDD190")]
		public HIDMCIHOJIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private readonly struct NPBAOPDMPFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public readonly TRequest EPNHPDGPFKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public readonly CancellationToken OFMMACGDFGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public readonly TaskCompletionSource<TResult> NEEBOAPDJEP;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x2BEF520", Offset = "0x2BEDD20", VA = "0x182BEF520")]
		public NPBAOPDMPFM(TRequest EPNHPDGPFKK, TaskCompletionSource<TResult> NEEBOAPDJEP, CancellationToken OFMMACGDFGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class HGMHIOAHNII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
		public HGMHIOAHNII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x230E970", Offset = "0x230D170", VA = "0x18230E970")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct NNFCJPKFMGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public global::KCGKCJBPPLJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2BEEFE0", Offset = "0x2BED7E0", VA = "0x182BEEFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class HMLIHOOJKLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public NPBAOPDMPFM req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::KCGKCJBPPLJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
		public HMLIHOOJKLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD200", Offset = "0x2BDBA00", VA = "0x182BDD200")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly CancellationTokenSource IPDAMNOLBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly List<NPBAOPDMPFM> HCBKKNMMDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly HIDMCIHOJIL CKBCINAKLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly PLEMCACENHM KFNAOFHGMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Task FGILJFINBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int LLCKJJGGICE;

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9C40", Offset = "0x2BE8440", VA = "0x182BE9C40")]
	public KCGKCJBPPLJ(PLEMCACENHM KFNAOFHGMMM, [Optional] HIDMCIHOJIL CKBCINAKLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x2BE8480", Offset = "0x2BE6C80", VA = "0x182BE8480")]
	public Task<TResult> EJEHDECFDDG(TRequest EPNHPDGPFKK, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x2BE8780", Offset = "0x2BE6F80", VA = "0x182BE8780")]
	private void JPPGIMEOLDD(NPBAOPDMPFM MMKOHOJCFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x2BE96C0", Offset = "0x2BE7EC0", VA = "0x182BE96C0")]
	[AsyncStateMachine(typeof(global::KCGKCJBPPLJ<, >.NNFCJPKFMGH))]
	private Task MLMOJJCDPND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9350", Offset = "0x2BE7B50", VA = "0x182BE9350")]
	private NPBAOPDMPFM MLDNHPAPKBC()
	{
		return default(NPBAOPDMPFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x2BE8C80", Offset = "0x2BE7480", VA = "0x182BE8C80")]
	private void LBGEFBBKGJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7F80", Offset = "0x2BE6780", VA = "0x182BE7F80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class HAIKBFLADJE<TKey, TVal> : global::FHBODBGDCEI<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int NOAMHHKNFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	internal Dictionary<TKey, (TVal value, int size)> LIENLAMJAPB;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	internal override int MEJMPOHLPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x42772D0", Offset = "0x4275AD0", VA = "0x1842772D0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	internal int CEINMAAFNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x4277120", Offset = "0x4275920", VA = "0x184277120")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public override int MPKAKPNFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x4277270", Offset = "0x4275A70", VA = "0x184277270", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x4277300", Offset = "0x4275B00", VA = "0x184277300")]
	public HAIKBFLADJE(int LJMMIINDJEO, [Optional] HCAKKADBNIM OIAIFKFFIJM, [Optional] IEqualityComparer<TKey> IEKFDIIIEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x4277080", Offset = "0x4275880", VA = "0x184277080")]
	public void JLCEJAAGLDA(TKey HJCJKDOGPGK, TVal HKJMLEKHILN, bool APNCNJLDJPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x42771F0", Offset = "0x42759F0", VA = "0x1842771F0")]
	public bool OHAIFEFKBJK(TKey HJCJKDOGPGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x4276DA0", Offset = "0x42755A0", VA = "0x184276DA0", Slot = "6")]
	public override bool DHIHCKAPBED(TKey DKNEDOGFIOE, out TVal HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x4276E50", Offset = "0x4275650", VA = "0x184276E50")]
	public bool GMBLPODHAMF(TKey HJCJKDOGPGK, TVal HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x4276C20", Offset = "0x4275420", VA = "0x184276C20")]
	public bool BBDBPKGKBOB(TKey HJCJKDOGPGK, TVal HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x4276D30", Offset = "0x4275530", VA = "0x184276D30", Slot = "7")]
	public override void CPGPLJLMCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x4277150", Offset = "0x4275950", VA = "0x184277150")]
	private bool KJFHLNHEMNM(TKey HJCJKDOGPGK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[DefaultMember("Item")]
public class FHBODBGDCEI<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public delegate int HCAKKADBNIM(TKey HJCJKDOGPGK, TVal HKJMLEKHILN);

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private class HAENDBLAAGL
	{
		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public TKey CNJCNJLJNLG
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F780", VA = "0x180570F80")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public TVal MKOCEBDLMLE
		{
			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x739330", Offset = "0x737B30", VA = "0x180739330")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x739910", Offset = "0x738110", VA = "0x180739910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public int KNCNKJJPBPG
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x5D78B0", Offset = "0x5D60B0", VA = "0x1805D78B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x5B3FA0", Offset = "0x5B27A0", VA = "0x1805B3FA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public DateTime FNHEJELCEDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x574E70", Offset = "0x573670", VA = "0x180574E70")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x748030", Offset = "0x746830", VA = "0x180748030")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x32861E0", Offset = "0x32849E0", VA = "0x1832861E0")]
		public HAENDBLAAGL(TKey HJCJKDOGPGK, TVal FMHKLFGOBKK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const int LPHACLPMBCB = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<TKey, LinkedListNode<HAENDBLAAGL>> NHEGGACGGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly LinkedList<HAENDBLAAGL> KAEAJPCBFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly HCAKKADBNIM OIAIFKFFIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly TimeSpan HNGHPAKLKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly AFCAJEOMCHN MMFINDDAGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int PFEMMKJOGOA;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int LKJMEHCOHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x72A1B0", Offset = "0x7289B0", VA = "0x18072A1B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	private bool HHKAOOOINGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x3280800", Offset = "0x327F000", VA = "0x183280800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	internal virtual int MEJMPOHLPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x781970", Offset = "0x780170", VA = "0x180781970", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	private int NLKMJJJPIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x23CC2B0", Offset = "0x23CAAB0", VA = "0x1823CC2B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public virtual int MPKAKPNFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x24893A0", Offset = "0x2487BA0", VA = "0x1824893A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public IEnumerable<TKey> OAHNPONBHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x3280A20", Offset = "0x327F220", VA = "0x183280A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public TVal KJIAGDJOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3280890", Offset = "0x327F090", VA = "0x183280890")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3281090", Offset = "0x327F890", VA = "0x183281090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x3281760", Offset = "0x327FF60", VA = "0x183281760")]
	public FHBODBGDCEI(int LJMMIINDJEO, [Optional] HCAKKADBNIM OIAIFKFFIJM, [Optional] IEqualityComparer<TKey> IEKFDIIIEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x3281AD0", Offset = "0x32802D0", VA = "0x183281AD0")]
	public FHBODBGDCEI(TimeSpan HNGHPAKLKGA, [Optional] IEqualityComparer<TKey> IEKFDIIIEEA, [Optional] AFCAJEOMCHN MMFINDDAGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x3281A80", Offset = "0x3280280", VA = "0x183281A80")]
	public FHBODBGDCEI(int LJMMIINDJEO, TimeSpan HNGHPAKLKGA, [Optional] IEqualityComparer<TKey> IEKFDIIIEEA, [Optional] AFCAJEOMCHN MMFINDDAGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x3281830", Offset = "0x3280030", VA = "0x183281830")]
	public FHBODBGDCEI(int LJMMIINDJEO, HCAKKADBNIM OIAIFKFFIJM, TimeSpan HNGHPAKLKGA, [Optional] IEqualityComparer<TKey> IEKFDIIIEEA, [Optional] AFCAJEOMCHN MMFINDDAGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x3281220", Offset = "0x327FA20", VA = "0x183281220")]
	public void NNFFBEGELMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x327FD40", Offset = "0x327E540", VA = "0x18327FD40")]
	public void AGHFILABLHM(TKey HJCJKDOGPGK, TVal HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x32808C0", Offset = "0x327F0C0", VA = "0x1832808C0")]
	public bool IIDOOJBFPNM(TKey HJCJKDOGPGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x32810C0", Offset = "0x327F8C0", VA = "0x1832810C0")]
	private TVal NMFOBHDGKIK(TKey DKNEDOGFIOE)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x32801B0", Offset = "0x327E9B0", VA = "0x1832801B0", Slot = "6")]
	public virtual bool DHIHCKAPBED(TKey DKNEDOGFIOE, out TVal HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x3280140", Offset = "0x327E940", VA = "0x183280140", Slot = "7")]
	public virtual void CPGPLJLMCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x3281390", Offset = "0x327FB90", VA = "0x183281390")]
	private bool PPIPPLLLJGH(HAENDBLAAGL KBKNKBPHHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x3280E60", Offset = "0x327F660", VA = "0x183280E60")]
	private void JODMNBPNFBA(LinkedListNode<HAENDBLAAGL> LOFHFAPCFLE, TVal LIKKHFGNLEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x3280460", Offset = "0x327EC60", VA = "0x183280460")]
	private void EFBFJEKHDBL(TKey HJCJKDOGPGK, TVal HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x327FFA0", Offset = "0x327E7A0", VA = "0x18327FFA0")]
	private void AGIBDDKHHHG(HAENDBLAAGL KBKNKBPHHPA, TVal LIKKHFGNLEM, int KNDIHNKCKJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DefaultMember("Item")]
public class OHEANIEDDBD<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly List<T> JKPOELIJJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private HashSet<T> HMCJBPNAGFD;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int MPKAKPNFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x230E970", Offset = "0x230D170", VA = "0x18230E970", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool FIOIIHPDJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x5757E0", Offset = "0x573FE0", VA = "0x1805757E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T KJIAGDJOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x230E9D0", Offset = "0x230D1D0", VA = "0x18230E9D0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2800FB0", Offset = "0x27FF7B0", VA = "0x182800FB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x23CFF40", Offset = "0x23CE740", VA = "0x1823CFF40", Slot = "11")]
	public void Add(T BOJBBPBHNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x2800A10", Offset = "0x27FF210", VA = "0x182800A10")]
	public bool KMHCKOBLAGL(T BOJBBPBHNOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2800D90", Offset = "0x27FF590", VA = "0x182800D90", Slot = "15")]
	public bool Remove(T BOJBBPBHNOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x28007D0", Offset = "0x27FEFD0", VA = "0x1828007D0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x2486EF0", Offset = "0x24856F0", VA = "0x182486EF0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2800570", Offset = "0x27FED70", VA = "0x182800570", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x28005D0", Offset = "0x27FEDD0", VA = "0x1828005D0", Slot = "13")]
	public bool Contains(T BOJBBPBHNOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x230EF70", Offset = "0x230D770", VA = "0x18230EF70", Slot = "14")]
	public void CopyTo(T[] FOLGEBPFFME, int ACENJMBACBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2800850", Offset = "0x27FF050", VA = "0x182800850", Slot = "6")]
	public int IndexOf(T BOJBBPBHNOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x2800880", Offset = "0x27FF080", VA = "0x182800880", Slot = "7")]
	public void Insert(int EDBBKGCLEJF, T BOJBBPBHNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x2800B60", Offset = "0x27FF360", VA = "0x182800B60", Slot = "8")]
	public void RemoveAt(int EDBBKGCLEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x2800700", Offset = "0x27FEF00", VA = "0x182800700")]
	public void EEKFKMFHFCE(Predicate<T> KNGLLBDNLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x2800600", Offset = "0x27FEE00", VA = "0x182800600")]
	public void DGLEGFPJCJG(Comparison<T> JEOFLPADBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x2800E10", Offset = "0x27FF610", VA = "0x182800E10")]
	public OHEANIEDDBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class BKKNOLBJOPC
{
	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x4F846A0", Offset = "0x4F82EA0", VA = "0x184F846A0")]
	public static Vector3 OOLJKALGJGB(this GameObject HDDLEPINJNG, float BKMPIMLBKBE)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
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

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x621F00", Offset = "0x620700", VA = "0x180621F00")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x4F8B950", Offset = "0x4F8A150", VA = "0x184F8B950")]
		public SerializedGuid(in Guid GLJDCMAAKFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x4F8B530", Offset = "0x4F89D30", VA = "0x184F8B530")]
		public static SerializedGuid ANIEIHIFBGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x4F8B5E0", Offset = "0x4F89DE0", VA = "0x184F8B5E0")]
		public static SerializedGuid DLICDNFJCEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x4F8B7E0", Offset = "0x4F89FE0", VA = "0x184F8B7E0")]
		public bool GLIFCCAJCPP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x4F8B920", Offset = "0x4F8A120", VA = "0x184F8B920", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x4F8B880", Offset = "0x4F8A080", VA = "0x184F8B880", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x4F8B4A0", Offset = "0x4F89CA0", VA = "0x184F8B4A0")]
		public bool ANFHIHCOHAE(in Guid GLJDCMAAKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x4F8B660", Offset = "0x4F89E60", VA = "0x184F8B660", Slot = "7")]
		public bool Equals(SerializedGuid EFDJFLPIKFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x4F8B700", Offset = "0x4F89F00", VA = "0x184F8B700", Slot = "0")]
		public override bool Equals(object ALCFLDIFDGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x4F8B870", Offset = "0x4F8A070", VA = "0x184F8B870", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x4F8B5B0", Offset = "0x4F89DB0", VA = "0x184F8B5B0", Slot = "6")]
		public int CompareTo(SerializedGuid EFDJFLPIKFF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class DIAOMBEGIAM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public readonly Type COKMEJHICJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public readonly string LNHAICOCGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public readonly bool IEDBJIMEOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public readonly bool MNHAJOFMOPL;

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x4F85420", Offset = "0x4F83C20", VA = "0x184F85420")]
	public DIAOMBEGIAM(Type MOGHDKADDGH, string FNJKLMGJCND, bool NHMNPDHELKA = false, bool PHNDKGKNMJC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface HAGEEKNNDMG
{
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public interface JHCBIPLDKFK<T> : HAGEEKNNDMG
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	T MKOCEBDLMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool KGDAAIHOJAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	string DFJHLLIOBIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::JHCBIPLDKFK<T> KKDONHGJMOM(Action<T> GJEONEMDNNE);

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::JHCBIPLDKFK<T> DHHHPAIIFCO(Action<T> GJEONEMDNNE);

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::JHCBIPLDKFK<T> FKCJGPPPBDD(Action<T, T> MOHMGOCDNPK);

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::JHCBIPLDKFK<T> BOFJNIJJJAN(Action<T, T> MOHMGOCDNPK);

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::JHCBIPLDKFK<T> OHHFNLHIAGO(Action<string> CICMHOBBCNJ);

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::JHCBIPLDKFK<T> MIBCKAFHLEB(Action<string> CICMHOBBCNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class JGLNHDCLDOE<T> : global::JHCBIPLDKFK<T>, HAGEEKNNDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private global::DAAFDLANJFF<T, T> NACEFPEHKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private global::HNGBGJMLEKL<T> GOOPBIFMFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private global::HNGBGJMLEKL<string> FIHKOOPPKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private string NCDAHJANGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private T JOPBNPIPIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool EHCNADFJKCH;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T MKOCEBDLMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x574330", Offset = "0x572B30", VA = "0x180574330", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x2C5E830", Offset = "0x2C5D030", VA = "0x182C5E830", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public bool KGDAAIHOJAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x5D51B0", Offset = "0x5D39B0", VA = "0x1805D51B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public string DFJHLLIOBIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x5749E0", Offset = "0x5731E0", VA = "0x1805749E0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x2CF45D0", Offset = "0x2CF2DD0", VA = "0x182CF45D0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x2CF44A0", Offset = "0x2CF2CA0", VA = "0x182CF44A0")]
	private void JDDJOILGGOI(T MDKOIJJHDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x2CF43B0", Offset = "0x2CF2BB0", VA = "0x182CF43B0")]
	private void FJMBFBJMHEB(string BOBNBIKICDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x2CF4670", Offset = "0x2CF2E70", VA = "0x182CF4670")]
	public void OFNBBDALODO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x2CF4450", Offset = "0x2CF2C50", VA = "0x182CF4450", Slot = "6")]
	public global::JHCBIPLDKFK<T> FKCJGPPPBDD(Action<T, T> MOHMGOCDNPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x2CF4310", Offset = "0x2CF2B10", VA = "0x182CF4310", Slot = "7")]
	public global::JHCBIPLDKFK<T> BOFJNIJJJAN(Action<T, T> MOHMGOCDNPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x2CF4540", Offset = "0x2CF2D40", VA = "0x182CF4540", Slot = "4")]
	public global::JHCBIPLDKFK<T> KKDONHGJMOM(Action<T> MOHMGOCDNPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x2CF4360", Offset = "0x2CF2B60", VA = "0x182CF4360", Slot = "5")]
	public global::JHCBIPLDKFK<T> DHHHPAIIFCO(Action<T> GJEONEMDNNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x2CF4720", Offset = "0x2CF2F20", VA = "0x182CF4720", Slot = "8")]
	public global::JHCBIPLDKFK<T> OHHFNLHIAGO(Action<string> CICMHOBBCNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x2CF4600", Offset = "0x2CF2E00", VA = "0x182CF4600", Slot = "9")]
	public global::JHCBIPLDKFK<T> MIBCKAFHLEB(Action<string> CICMHOBBCNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x2CF47B0", Offset = "0x2CF2FB0", VA = "0x182CF47B0")]
	public JGLNHDCLDOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class JNOBAAGNMFF
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class AGCINKBKKMO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public global::JHCBIPLDKFK<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::KHKLHEMGFGI<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
		public AGCINKBKKMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2CE50E0", Offset = "0x2CE38E0", VA = "0x182CE50E0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2B50730", Offset = "0x2B4EF30", VA = "0x182B50730")]
	public static global::MJKMFAPMHBB<T> HNKKECKIEEI<T>(this global::JHCBIPLDKFK<T> BNLLIFFNJHH, Action<T> HNMFGPCGPOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class OHFIIPLOOFJ<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public readonly struct DGELBEAGFKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly long OFKPFKAFNNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public readonly long OIJGOGEJIHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public readonly int IPJBNJNKNGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public readonly int CDFOJOLHIOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly bool FNKABDDJJHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly string PGHJPOJFHNB;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x27F00F0", Offset = "0x27EE8F0", VA = "0x1827F00F0")]
		public DGELBEAGFKE(long OFKPFKAFNNO, int IPJBNJNKNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x27F0160", Offset = "0x27EE960", VA = "0x1827F0160")]
		public DGELBEAGFKE(long OFKPFKAFNNO, long OIJGOGEJIHM, int IPJBNJNKNGI, int CDFOJOLHIOB, bool FNKABDDJJHG, string PGHJPOJFHNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x27EFEE0", Offset = "0x27EE6E0", VA = "0x1827EFEE0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void GOCBGJIHCHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x27F00A0", Offset = "0x27EE8A0", VA = "0x1827F00A0")]
		public int POAJCCAIPHI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x27F0080", Offset = "0x27EE880", VA = "0x1827F0080")]
		public int OGCGPPENENF(int LOOHDCEEFPH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x27F0010", Offset = "0x27EE810", VA = "0x1827F0010")]
		public double JEJCNIDNMNK()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x27EFF50", Offset = "0x27EE750", VA = "0x1827EFF50")]
		public DGELBEAGFKE JAHCMAEHDNM(long OIJGOGEJIHM, int CDFOJOLHIOB)
		{
			return default(DGELBEAGFKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class MEEOFKIMDJG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public readonly TKey CNJCNJLJNLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly global::OHFIIPLOOFJ<TKey> JABEDHNBEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private List<MEEOFKIMDJG> BAGGLJNALPM;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public string CCPAKGJJJKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x2187C40", Offset = "0x2186440", VA = "0x182187C40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x27F1F20", Offset = "0x27F0720", VA = "0x1827F1F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public IEnumerable<MEEOFKIMDJG> ADKJKIGDMKK
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x27F1F50", Offset = "0x27F0750", VA = "0x1827F1F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public DGELBEAGFKE AHBCMADGJCE
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x85B180", Offset = "0x859980", VA = "0x18085B180")]
			[CompilerGenerated]
			get
			{
				return default(DGELBEAGFKE);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x27F1F70", Offset = "0x27F0770", VA = "0x1827F1F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x27F1FA0", Offset = "0x27F07A0", VA = "0x1827F1FA0")]
		internal MEEOFKIMDJG(global::OHFIIPLOOFJ<TKey> JABEDHNBEFJ, TKey HJCJKDOGPGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x27F1B50", Offset = "0x27F0350", VA = "0x1827F1B50")]
		public MEEOFKIMDJG AAALKPKFBCE(TKey HJCJKDOGPGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x27F1E20", Offset = "0x27F0620", VA = "0x1827F1E20")]
		public void ECFAOBDLKPM(TKey HJCJKDOGPGK, Action<MEEOFKIMDJG> BBFDPEJCJGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x239E050", Offset = "0x239C850", VA = "0x18239E050")]
		public T ECFAOBDLKPM<T>(TKey HJCJKDOGPGK, Func<MEEOFKIMDJG, T> HECNJCDFNNF)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x25B6570", Offset = "0x25B4D70", VA = "0x1825B6570")]
		[AsyncStateMachine(typeof(EJGMLHDANBI))]
		public Task<T> HIFBLJCEHNF<T>(TKey HJCJKDOGPGK, Func<MEEOFKIMDJG, Task<T>> HECNJCDFNNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x27F1C60", Offset = "0x27F0460", VA = "0x1827F1C60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class GEJCHCIBJEF : IEnumerable<(TKey, List<TKey>, DGELBEAGFKE)>, IEnumerable, IEnumerator<(TKey, List<TKey>, DGELBEAGFKE)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private (TKey key, List<TKey> path, DGELBEAGFKE timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public global::OHFIIPLOOFJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private IEnumerator<(TKey key, List<TKey> path, DGELBEAGFKE timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private (TKey, List<TKey>, DGELBEAGFKE) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x27F0BC0", Offset = "0x27EF3C0", VA = "0x1827F0BC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, DGELBEAGFKE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x27F1340", Offset = "0x27EFB40", VA = "0x1827F1340", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x27F0E40", Offset = "0x27EF640", VA = "0x1827F0E40")]
		[DebuggerHidden]
		public GEJCHCIBJEF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x27F13A0", Offset = "0x27EFBA0", VA = "0x1827F13A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x27F0FC0", Offset = "0x27EF7C0", VA = "0x1827F0FC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x27F1420", Offset = "0x27EFC20", VA = "0x1827F1420")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x27F12F0", Offset = "0x27EFAF0", VA = "0x1827F12F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x27F1230", Offset = "0x27EFA30", VA = "0x1827F1230", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, DGELBEAGFKE)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x2494FE0", Offset = "0x24937E0", VA = "0x182494FE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class EMGEPHELIAL : IEnumerable<(TKey, List<TKey>, DGELBEAGFKE)>, IEnumerable, IEnumerator<(TKey, List<TKey>, DGELBEAGFKE)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private (TKey key, List<TKey> path, DGELBEAGFKE timerEntry) <>2__current;

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
		private MEEOFKIMDJG timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public MEEOFKIMDJG <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public global::OHFIIPLOOFJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private IEnumerator<MEEOFKIMDJG> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private IEnumerator<(TKey key, List<TKey> path, DGELBEAGFKE timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private (TKey, List<TKey>, DGELBEAGFKE) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x27F0BC0", Offset = "0x27EF3C0", VA = "0x1827F0BC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, DGELBEAGFKE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x27F0C70", Offset = "0x27EF470", VA = "0x1827F0C70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x27F0E40", Offset = "0x27EF640", VA = "0x1827F0E40")]
		[DebuggerHidden]
		public EMGEPHELIAL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x27F0CD0", Offset = "0x27EF4D0", VA = "0x1827F0CD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x27F05B0", Offset = "0x27EEDB0", VA = "0x1827F05B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x27F0DA0", Offset = "0x27EF5A0", VA = "0x1827F0DA0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x27F0DF0", Offset = "0x27EF5F0", VA = "0x1827F0DF0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x27F0C20", Offset = "0x27EF420", VA = "0x1827F0C20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x27F0AF0", Offset = "0x27EF2F0", VA = "0x1827F0AF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, DGELBEAGFKE)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x27F0BF0", Offset = "0x27EF3F0", VA = "0x1827F0BF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Action<TKey, DGELBEAGFKE> HIMIEDJEMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Action<TKey, DGELBEAGFKE> BFHDMMLLMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Action<global::OHFIIPLOOFJ<TKey>> MDPFMEALDBC;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private const string FBFDGNLKDGJ = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly MEEOFKIMDJG PHIJHBKCEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private bool BPDPEACPAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int HGONDJJALFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Stopwatch FMCEIMPJGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public readonly int HJPOCLAGBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private string AOBPIDCNFGF;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public MEEOFKIMDJG EMACILCBGBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x5749E0", Offset = "0x5731E0", VA = "0x1805749E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	[NotNull]
	public string CCPAKGJJJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x5FBAB0", Offset = "0x5FA2B0", VA = "0x1805FBAB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x2802210", Offset = "0x2800A10", VA = "0x182802210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public long IGAAIBLDMBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x2802080", Offset = "0x2800880", VA = "0x182802080")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public int EBPJMDFIBLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x28021E0", Offset = "0x28009E0", VA = "0x1828021E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2802290", Offset = "0x2800A90", VA = "0x182802290")]
	public OHFIIPLOOFJ(TKey CCLJKPJGPJH, [Optional] int? IPJBNJNKNGI, [Optional][CanBeNull] Stopwatch FMCEIMPJGJA, [Optional] Action<TKey, DGELBEAGFKE> HIMIEDJEMJK, [Optional] Action<TKey, DGELBEAGFKE> BFHDMMLLMBP, [Optional] Action<global::OHFIIPLOOFJ<TKey>> MDPFMEALDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x28020A0", Offset = "0x28008A0", VA = "0x1828020A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x28021C0", Offset = "0x28009C0", VA = "0x1828021C0")]
	public void GKLPGKHKDJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x2802270", Offset = "0x2800A70", VA = "0x182802270")]
	public void NPINFOLKPPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2801FF0", Offset = "0x28007F0", VA = "0x182801FF0")]
	[IteratorStateMachine(typeof(global::OHFIIPLOOFJ<>.GEJCHCIBJEF))]
	public IEnumerable<(TKey, List<TKey>, DGELBEAGFKE)> BIBMNOGJHPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2801F20", Offset = "0x2800720", VA = "0x182801F20")]
	[IteratorStateMachine(typeof(global::OHFIIPLOOFJ<>.EMGEPHELIAL))]
	private IEnumerable<(TKey, List<TKey>, DGELBEAGFKE)> BIBMNOGJHPD(List<TKey> DBNJCAPPLBF, MEEOFKIMDJG BCLGGADAIGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2802130", Offset = "0x2800930", VA = "0x182802130")]
	private (long, int) EHPHAODELCL()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public abstract class BKFHFFGELBI<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut DDMCCCCOCPH(global::OHFIIPLOOFJ<TKey> JABEDHNBEFJ);

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
	protected BKFHFFGELBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public abstract class IGKBBMJJBPA<TKey> : global::BKFHFFGELBI<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public delegate string CFJKGCFFPKO(TKey HJCJKDOGPGK);

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2A3E1A0", Offset = "0x2A3C9A0", VA = "0x182A3E1A0")]
	protected string KINIGJDFAJF(double JNBEGKMPHAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2A3DF80", Offset = "0x2A3C780", VA = "0x182A3DF80")]
	protected string COEMEFOEONN(int ACMENOFNJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2A3E200", Offset = "0x2A3CA00", VA = "0x182A3E200")]
	private static string NIBAENODHKJ(TKey HJCJKDOGPGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x2A3E0F0", Offset = "0x2A3C8F0", VA = "0x182A3E0F0", Slot = "4")]
	public override string DDMCCCCOCPH(global::OHFIIPLOOFJ<TKey> JABEDHNBEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2A3DFD0", Offset = "0x2A3C7D0", VA = "0x182A3DFD0")]
	public string DDMCCCCOCPH(global::OHFIIPLOOFJ<TKey> JABEDHNBEFJ, [NotNull] CFJKGCFFPKO IMHNBJEHMGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string EPFDIHIPDOH(global::OHFIIPLOOFJ<TKey> JABEDHNBEFJ, [NotNull] CFJKGCFFPKO IMHNBJEHMGL);

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2313FB0", Offset = "0x23127B0", VA = "0x182313FB0")]
	protected IGKBBMJJBPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class HCELIHDNAAH<TKey> : global::BKFHFFGELBI<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public delegate string PFGCPNOEEPC(TKey HJCJKDOGPGK);

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int DMOMCPLEKCE = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly string LGLDNNKAAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly double CDLMLMEDING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly bool NIOHODICEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly int PCGFNHBJOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly ISet<string> DCCNDFOABIJ;

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x4279690", Offset = "0x4277E90", VA = "0x184279690")]
	private static string NIBAENODHKJ(TKey HJCJKDOGPGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x42796D0", Offset = "0x4277ED0", VA = "0x1842796D0")]
	public HCELIHDNAAH(string LGLDNNKAAOD = "F2", double CDLMLMEDING = double.MaxValue, bool NIOHODICEIK = false, int PCGFNHBJOKD = int.MaxValue, [Optional] ISet<string> DCCNDFOABIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x4279480", Offset = "0x4277C80", VA = "0x184279480", Slot = "4")]
	public override Dictionary<string, string> DDMCCCCOCPH(global::OHFIIPLOOFJ<TKey> JABEDHNBEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x4278D50", Offset = "0x4277550", VA = "0x184278D50")]
	private bool DCFDGBJOJHN(string GPMJEPCEGNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x4278FE0", Offset = "0x42777E0", VA = "0x184278FE0")]
	public Dictionary<string, string> DDMCCCCOCPH(global::OHFIIPLOOFJ<TKey> JABEDHNBEFJ, PFGCPNOEEPC IMHNBJEHMGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x4278E30", Offset = "0x4277630", VA = "0x184278E30")]
	private string DDLHKIEEGCF(StringBuilder BGNNHKJIBOK, List<TKey> EGBMBIDDAAI, PFGCPNOEEPC IMHNBJEHMGL, bool CPDDLHPOAOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x4279530", Offset = "0x4277D30", VA = "0x184279530")]
	private static void FFNDLFBGKOD(StringBuilder FJKJIEFFPKO, string LAOAMAHCCAF, bool FLKIOIJJGMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class PBCOHGHDKLL<TKey> : global::IGKBBMJJBPA<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct OKGEHDGFOKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public CFJKGCFFPKO keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static global::PBCOHGHDKLL<TKey> JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int OFDLGMFIBPE = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly string[] CPMBHHKLDGD;

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9B40", Offset = "0x2CA8340", VA = "0x182CA9B40")]
	private PBCOHGHDKLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8B40", Offset = "0x2CA7340", VA = "0x182CA8B40", Slot = "5")]
	protected override string EPFDIHIPDOH(global::OHFIIPLOOFJ<TKey> JABEDHNBEFJ, CFJKGCFFPKO IMHNBJEHMGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9960", Offset = "0x2CA8160", VA = "0x182CA9960")]
	[CompilerGenerated]
	internal static string MMPJFFINLJP(string CFBNJGDGBGB, TKey HJCJKDOGPGK, ref OKGEHDGFOKP P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class DNIGIFGIFGB<TKey> : global::IGKBBMJJBPA<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class PEAMGLNBLNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public CFJKGCFFPKO keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
		public PEAMGLNBLNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F680", Offset = "0x2C9DE80", VA = "0x182C9F680")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x34186B0", Offset = "0x3416EB0", VA = "0x1834186B0", Slot = "5")]
	protected override string EPFDIHIPDOH(global::OHFIIPLOOFJ<TKey> JABEDHNBEFJ, CFJKGCFFPKO IMHNBJEHMGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7BD0", Offset = "0x2BE63D0", VA = "0x182BE7BD0")]
	public DNIGIFGIFGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public sealed class GAMFOMFHAHH : global::OHFIIPLOOFJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class JPDJKCNJBEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public Action<GAMFOMFHAHH> callback;

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public JPDJKCNJBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x4F873F0", Offset = "0x4F85BF0", VA = "0x184F873F0")]
		internal void <Wrap>b__0(global::OHFIIPLOOFJ<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x4F85D20", Offset = "0x4F84520", VA = "0x184F85D20")]
	public GAMFOMFHAHH([Optional] string NNGGAIDPLJO, [Optional] int? IPJBNJNKNGI, [Optional] Stopwatch FMCEIMPJGJA, [Optional] Action<string, DGELBEAGFKE> HIMIEDJEMJK, [Optional] Action<string, DGELBEAGFKE> BFHDMMLLMBP, [Optional] Action<GAMFOMFHAHH> MDPFMEALDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x4F85C60", Offset = "0x4F84460", VA = "0x184F85C60")]
	private static Action<global::OHFIIPLOOFJ<string>> ECFAOBDLKPM(Action<GAMFOMFHAHH> HNMFGPCGPOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public abstract class AFCAJEOMCHN
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private class LINIGALPHLI : AFCAJEOMCHN
	{
		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public static AFCAJEOMCHN JNLINCDFKKC
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x4F87980", Offset = "0x4F86180", VA = "0x184F87980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public override DateTime PCHJPGMPPAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x4F879E0", Offset = "0x4F861E0", VA = "0x184F879E0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public override float MAPBJLOICHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x4F87A30", Offset = "0x4F86230", VA = "0x184F87A30", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x4F87AE0", Offset = "0x4F862E0", VA = "0x184F87AE0")]
		public LINIGALPHLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static AFCAJEOMCHN LLKCFGNBGKK;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public static AFCAJEOMCHN GJCBCFPBGOE
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x4F83FC0", Offset = "0x4F827C0", VA = "0x184F83FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public abstract DateTime PCHJPGMPPAD
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public abstract float MAPBJLOICHN
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	protected AFCAJEOMCHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class DEJMJJGKJFA : global::ABPLEHEGLLA<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x4F853E0", Offset = "0x4F83BE0", VA = "0x184F853E0")]
	public DEJMJJGKJFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class ABPLEHEGLLA<T> : global::EJDFLFAJOME<T>, OOHMAHKNJID, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Task<T> ICOPCNLFACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F780", VA = "0x180570F80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Task JMDDCFBIGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x217F720", Offset = "0x217DF20", VA = "0x18217F720", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public global::MJKMFAPMHBB<T> FKADDHAMGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private OHCOLEGJNAC PIPDIMGOPCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x2181850", Offset = "0x2180050", VA = "0x182181850", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x3836FB0", Offset = "0x38357B0", VA = "0x183836FB0")]
	public ABPLEHEGLLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class GODBGHDOKCF : global::MCAMCGBIHBD<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x4F85EC0", Offset = "0x4F846C0", VA = "0x184F85EC0")]
	public GODBGHDOKCF(Exception AEAEPNFFAPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class MCAMCGBIHBD<T> : global::EJDFLFAJOME<T>, OOHMAHKNJID, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Task<T> ICOPCNLFACM
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F780", VA = "0x180570F80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Task JMDDCFBIGAO
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x217F720", Offset = "0x217DF20", VA = "0x18217F720", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public global::MJKMFAPMHBB<T> FKADDHAMGFK
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private OHCOLEGJNAC PIPDIMGOPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x2181850", Offset = "0x2180050", VA = "0x182181850", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x388ED30", Offset = "0x388D530", VA = "0x18388ED30")]
	public MCAMCGBIHBD(Exception AEAEPNFFAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface OOHMAHKNJID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000096")]
	[NotNull]
	Task ICOPCNLFACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	[NotNull]
	OHCOLEGJNAC FKADDHAMGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public interface EJDFLFAJOME<T> : OOHMAHKNJID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000098")]
	[NotNull]
	new Task<T> ICOPCNLFACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	[NotNull]
	new global::MJKMFAPMHBB<T> FKADDHAMGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public abstract class LJFGOKOBIDA<TTask, T> : global::EJDFLFAJOME<T>, OOHMAHKNJID, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class AJHGNIKHAAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public global::LJFGOKOBIDA<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
		public AJHGNIKHAAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static bool LODOALPJGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly Task<T> IIJNLEIHGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	protected readonly CancellationTokenSource LCJMCFAEJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private bool BPDPEACPAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private SynchronizationContext HILPMEMLJHJ;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Task<T> ICOPCNLFACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F780", VA = "0x180570F80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private Task JMDDCFBIGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F780", VA = "0x180570F80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public global::MJKMFAPMHBB<T> FKADDHAMGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private OHCOLEGJNAC PIPDIMGOPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x2310E40", Offset = "0x230F640", VA = "0x182310E40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool DINLCPKDMOA
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x73E020", Offset = "0x73C820", VA = "0x18073E020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x414FCD0", Offset = "0x414E4D0", VA = "0x18414FCD0")]
	static LJFGOKOBIDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x4150160", Offset = "0x414E960", VA = "0x184150160")]
	protected LJFGOKOBIDA(TTask IIJNLEIHGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x414F950", Offset = "0x414E150", VA = "0x18414F950", Slot = "1")]
	~LJFGOKOBIDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x3BF88E0", Offset = "0x3BF70E0", VA = "0x183BF88E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x414F9F0", Offset = "0x414E1F0", VA = "0x18414F9F0")]
	private void HCHOKKKPDGO(bool HAJJBBCBIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T FBABIAMHEGP(TTask EPEPABAIMCL);

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void FALGDEEKMEP();

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x414F860", Offset = "0x414E060", VA = "0x18414F860")]
	[CompilerGenerated]
	private void DBBOBDEJOEE(object OHBEELPIGMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public interface HBOCEOFFBMC
{
	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	float KGMODKBKFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event GGPHJFNMMNN GMPKCKAOMIE;
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class NHLHCIPCLFM : HBOCEOFFBMC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public readonly struct CCHBLONJJCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public readonly float DKJABLKCLKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public readonly float HDIKODACPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		internal readonly bool CFOOMENBKKF;

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public float KNCNKJJPBPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x4F84C80", Offset = "0x4F83480", VA = "0x184F84C80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x4F84DF0", Offset = "0x4F835F0", VA = "0x184F84DF0")]
		public CCHBLONJJCB(float EDGNDOFMPJJ, float KLPHHCIKKJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x4F84C90", Offset = "0x4F83490", VA = "0x184F84C90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class AHBMMNFJGLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public NHLHCIPCLFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public AHBMMNFJGLN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly int LJMMIINDJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private int KCEEDBEAIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly HBOCEOFFBMC[] AEAJENJLAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly GGPHJFNMMNN[] JMODMMLPIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly CCHBLONJJCB[] LJKBJDCGKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private CCHBLONJJCB KMMCFAOIOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly BNKIBKJLBKC LMGCBKPJIPP;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public CCHBLONJJCB DIJLKENBCEC
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x3475060", Offset = "0x3473860", VA = "0x183475060")]
		get
		{
			return default(CCHBLONJJCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float KGMODKBKFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x4F88360", Offset = "0x4F86B60", VA = "0x184F88360", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event GGPHJFNMMNN GMPKCKAOMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x4F88760", Offset = "0x4F86F60", VA = "0x184F88760", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x4F880C0", Offset = "0x4F868C0", VA = "0x184F880C0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x4F88820", Offset = "0x4F87020", VA = "0x184F88820")]
	public NHLHCIPCLFM(int LJMMIINDJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x4F88040", Offset = "0x4F86840", VA = "0x184F88040")]
	public BNKIBKJLBKC BIIJFDIBPED(CCHBLONJJCB OLKPHIDNPHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x4F88380", Offset = "0x4F86B80", VA = "0x184F88380")]
	public void ICAECEDOLAG(HBOCEOFFBMC OKCAGEKAOOP, [Optional] CCHBLONJJCB FFNLIMNMJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x4F88310", Offset = "0x4F86B10", VA = "0x184F88310")]
	internal int EOPDLECKEID(HBOCEOFFBMC EPGBELLPIBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x4F87FF0", Offset = "0x4F867F0", VA = "0x184F87FF0")]
	internal CCHBLONJJCB BBMKGJFMGHH(int EDBBKGCLEJF)
	{
		return default(CCHBLONJJCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x4F88180", Offset = "0x4F86980", VA = "0x184F88180", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public delegate void GGPHJFNMMNN(float HGPDOMHKMGI);
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal static class DKBNJNLNEPN
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	internal const float COMCIECNKOH = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class BPAJOELCJPC
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	private class PCIDNFOEEHC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly HBOCEOFFBMC EPGBELLPIBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private readonly GGPHJFNMMNN HNMFGPCGPOH;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x4F89B20", Offset = "0x4F88320", VA = "0x184F89B20")]
		public PCIDNFOEEHC(HBOCEOFFBMC EPGBELLPIBG, GGPHJFNMMNN HNMFGPCGPOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x4F89AD0", Offset = "0x4F882D0", VA = "0x184F89AD0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x4F84B40", Offset = "0x4F83340", VA = "0x184F84B40")]
	internal static bool GIAJMLFAOKE(float FCCDOLKCOHD, float EOEFACHALFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x3D61B50", Offset = "0x3D60350", VA = "0x183D61B50")]
	internal static float APNPGJPNLPP(float FCCDOLKCOHD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x4F84BC0", Offset = "0x4F833C0", VA = "0x184F84BC0")]
	public static IDisposable PPDDNEDPMCP(this HBOCEOFFBMC EPGBELLPIBG, GGPHJFNMMNN HNMFGPCGPOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public class BNKIBKJLBKC : HBOCEOFFBMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private float HGPDOMHKMGI;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float KGMODKBKFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7BCF70", Offset = "0x7BB770", VA = "0x1807BCF70", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x4F84930", Offset = "0x4F83130", VA = "0x184F84930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event GGPHJFNMMNN GMPKCKAOMIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x4F84AA0", Offset = "0x4F832A0", VA = "0x184F84AA0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x4F84A00", Offset = "0x4F83200", VA = "0x184F84A00", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public BNKIBKJLBKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class KKLMGEGEFAA : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public readonly Type COKMEJHICJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public readonly string LNHAICOCGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public readonly bool IEDBJIMEOME;

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x4F87880", Offset = "0x4F86080", VA = "0x184F87880")]
	public KKLMGEGEFAA(Type MOGHDKADDGH, string FNJKLMGJCND, bool NHMNPDHELKA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class FMHACOEPKGL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x4F85AB0", Offset = "0x4F842B0", VA = "0x184F85AB0")]
	public FMHACOEPKGL(string BOBNBIKICDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x4F85B20", Offset = "0x4F84320", VA = "0x184F85B20")]
	public FMHACOEPKGL(string BOBNBIKICDK, Exception CPJFNIFMLAN)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x570F90", Offset = "0x56F790", VA = "0x180570F90")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x5D5180", Offset = "0x5D3980", VA = "0x1805D5180")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public T this[int HPENCEMKHKB, int CGLGHIBOHDL]
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x217F860", Offset = "0x217E060", VA = "0x18217F860")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x217F900", Offset = "0x217E100", VA = "0x18217F900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x217F7D0", Offset = "0x217DFD0", VA = "0x18217F7D0")]
		public Array2D(uint CNIBEDGIPIB, uint JMJIBONNFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x217F750", Offset = "0x217DF50", VA = "0x18217F750")]
		public void CPGPLJLMCBF()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x4F84640", Offset = "0x4F82E40", VA = "0x184F84640")]
		public Array2DVector3(uint CNIBEDGIPIB, uint JMJIBONNFGD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal static class BJLBGDFCJBL
{
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public const int BOELKGANAKL = -1;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public const int DDNPMOLONKB = 0;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[DefaultMember("Item")]
public class KNMHEHLIHHL<THandle, TValue> : IDisposable where THandle : struct, KKIKBKBCNID where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly List<THandle> IKCMDAABGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly List<TValue> DKICDNIDDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly Func<TValue> OENAMCPPKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly Action<TValue> KFABMDEIIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private int KJNKFINHGKC;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public TValue KJIAGDJOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x32D62F0", Offset = "0x32D4AF0", VA = "0x1832D62F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x38653C0", Offset = "0x3863BC0", VA = "0x1838653C0")]
	public KNMHEHLIHHL(Action<TValue> KFABMDEIIEH, [Optional] Func<TValue> OENAMCPPKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x3864E00", Offset = "0x3863600", VA = "0x183864E00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x3864CC0", Offset = "0x38634C0", VA = "0x183864CC0")]
	public THandle DIFMOOHBFDA()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x3864BB0", Offset = "0x38633B0", VA = "0x183864BB0")]
	public THandle DEOBKNOOHMB(TValue HKJMLEKHILN)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x3864F40", Offset = "0x3863740", VA = "0x183864F40")]
	public bool IIDOOJBFPNM(THandle IFKKNJFNCCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x38651D0", Offset = "0x38639D0", VA = "0x1838651D0")]
	public bool MCPFBBOJBGI(THandle IFKKNJFNCCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x3865310", Offset = "0x3863B10", VA = "0x183865310")]
	public bool NMGABNCLOGE(THandle IFKKNJFNCCG, out TValue HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x38652C0", Offset = "0x3863AC0", VA = "0x1838652C0")]
	public TValue NMFOBHDGKIK(THandle IFKKNJFNCCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x3864B00", Offset = "0x3863300", VA = "0x183864B00")]
	public bool DCOCANLGNBD(THandle IFKKNJFNCCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x3864E80", Offset = "0x3863680", VA = "0x183864E80")]
	private THandle EGEKDKJOFPD(int EDBBKGCLEJF)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3864F10", Offset = "0x3863710", VA = "0x183864F10")]
	private TValue HNKKECKIEEI(int EDBBKGCLEJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x38648E0", Offset = "0x38630E0", VA = "0x1838648E0")]
	private void BKHDFPLGIIC(int EDBBKGCLEJF, in THandle IFKKNJFNCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x3865070", Offset = "0x3863870", VA = "0x183865070")]
	private void JDDJOILGGOI(int EDBBKGCLEJF, in TValue HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3864920", Offset = "0x3863120", VA = "0x183864920")]
	private THandle BLPADEHNHIO()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x3864820", Offset = "0x3863020", VA = "0x183864820")]
	private void APHJOOGJFEC(THandle IFKKNJFNCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x38652B0", Offset = "0x3863AB0", VA = "0x1838652B0")]
	private int MKDLAAIDFAJ(int CDHIMBPFFEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x38653B0", Offset = "0x3863BB0", VA = "0x1838653B0")]
	private bool PJDMDLOJKAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x59D3B0", Offset = "0x59BBB0", VA = "0x18059D3B0")]
	private void BFBCGNIJNAM(THandle IFKKNJFNCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x3864FF0", Offset = "0x38637F0", VA = "0x183864FF0")]
	private bool ILKDHPOEBID(out THandle IFKKNJFNCCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x3864A30", Offset = "0x3863230", VA = "0x183864A30")]
	private bool BMIEOCIJIBB(out THandle IFKKNJFNCCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x3864EB0", Offset = "0x38636B0", VA = "0x183864EB0")]
	private void FMNCOBKIGNM(THandle IFKKNJFNCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x38650B0", Offset = "0x38638B0", VA = "0x1838650B0")]
	private void LEPNEJDGCOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public interface KKIKBKBCNID
{
	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	int EHCNLDNBCOB
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	int LPDIHOLGOMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public interface DMEBJJLLDIP<T> : KKIKBKBCNID, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public static class EIABJPJAFGP
{
	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x3B34740", Offset = "0x3B32F40", VA = "0x183B34740")]
	public static bool CFOOMENBKKF<T>(this T IFKKNJFNCCG) where T : struct, KKIKBKBCNID
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public class IKBOFNDPOOK
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private enum MBLGGELNIBJ : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private int FBPMKCBKEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool KJJDDMLPHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private MBLGGELNIBJ KIKBBCLABKM;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool HKPJOEMCIBF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x4F86940", Offset = "0x4F85140", VA = "0x184F86940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool DHHMFMLIJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x4F868C0", Offset = "0x4F850C0", VA = "0x184F868C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x4F86DD0", Offset = "0x4F855D0", VA = "0x184F86DD0")]
	public IKBOFNDPOOK(bool KJJDDMLPHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x4F86360", Offset = "0x4F84B60", VA = "0x184F86360")]
	public void JOIOLOKPICI(object ALCFLDIFDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x4F86D10", Offset = "0x4F85510", VA = "0x184F86D10")]
	public void PIPIECELIGB(int HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x4F86DC0", Offset = "0x4F855C0", VA = "0x184F86DC0")]
	public void PJMGANFFELL(uint OMCEACNPJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x4F85FF0", Offset = "0x4F847F0", VA = "0x184F85FF0")]
	public void BHLOOFFMHBG(bool PBOEHILEGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x4F86880", Offset = "0x4F85080", VA = "0x184F86880")]
	public void MMCDCMAMEKK(long OOBPCACLEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x4F861B0", Offset = "0x4F849B0", VA = "0x184F861B0")]
	public void HKIBOGCNEBD(ulong FFMCGBGBIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x4F868D0", Offset = "0x4F850D0", VA = "0x184F868D0")]
	public void NIGJEJMJEMJ(string CMNNFMDFJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x4F86260", Offset = "0x4F84A60", VA = "0x184F86260")]
	public void ILIFFDODMFD(Enum AEAEPNFFAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x4F86010", Offset = "0x4F84810", VA = "0x184F86010")]
	public void CNFNJOFCGHE(IList JKPOELIJJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x2AAC060", Offset = "0x2AAA860", VA = "0x182AAC060")]
	public void JAPAHPBPBMP<T, U>(Dictionary<T, U> GELCAKCPJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x4F86950", Offset = "0x4F85150", VA = "0x184F86950")]
	private void OOGJJDCIPIC(IDictionary GELCAKCPJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x4F862F0", Offset = "0x4F84AF0", VA = "0x184F862F0")]
	public int JMJOAIJAFEF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x4F861F0", Offset = "0x4F849F0", VA = "0x184F861F0")]
	public short IFFMOCPGBKL()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x4F86130", Offset = "0x4F84930", VA = "0x184F86130")]
	public void CPGPLJLMCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x4F86140", Offset = "0x4F84940", VA = "0x184F86140")]
	private void DJALJOLODFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public abstract class MCHCCOHEPOI<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	internal class OPKELAICGAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public TNode MHKBKFBCDKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public TNode BNOBPGHCIOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public BOOGOKICICE EFHMDPBKJPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<BOOGOKICICE> HDANJOEOKAO;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
		public OPKELAICGAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	internal struct BOOGOKICICE : IComparable<BOOGOKICICE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int IJCLFNIDFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public TClaimant NHJEGOCFEFC;

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x9E82D0", Offset = "0x9E6AD0", VA = "0x1809E82D0")]
		public BOOGOKICICE(int IJCLFNIDFIK, TClaimant NHJEGOCFEFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x3883730", Offset = "0x3881F30", VA = "0x183883730")]
		public bool IAILPAGFINL(in BOOGOKICICE EFDJFLPIKFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x3883790", Offset = "0x3881F90", VA = "0x183883790")]
		public bool OPLJGNJGKKF(in BOOGOKICICE EFDJFLPIKFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x3883720", Offset = "0x3881F20", VA = "0x183883720", Slot = "4")]
		public int CompareTo(BOOGOKICICE EFDJFLPIKFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x38837A0", Offset = "0x3881FA0", VA = "0x1838837A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public enum IPCJOHDJDNG
	{
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class EPONNCGGBPN : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public global::MCHCCOHEPOI<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x2314030", Offset = "0x2312830", VA = "0x182314030")]
		[DebuggerHidden]
		public EPONNCGGBPN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x3883800", Offset = "0x3882000", VA = "0x183883800", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x38839C0", Offset = "0x38821C0", VA = "0x1838839C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x38838E0", Offset = "0x38820E0", VA = "0x1838838E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2313730", Offset = "0x2311F30", VA = "0x182313730", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private static readonly global::OGDBBNLOJNO<OPKELAICGAL> ODOONMFAKLN;

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private static readonly global::OGDBBNLOJNO<List<BOOGOKICICE>> PHDEPIKIINO;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private static int ENMPJFBGELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	internal readonly Dictionary<TClaimant, TNode> BFHOKGPAPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	internal readonly Dictionary<TNode, OPKELAICGAL> FDDKNBFAGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private IPCJOHDJDNG LLMKIKMAMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private bool BKEPAEJLPBM;

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode GDAPHCNGNMJ(TNode OGNJOKKMMDG);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void BEBFKPFOKMC(TNode OGNJOKKMMDG, TClaimant PKPDFFIBGDO, TClaimant KGCBOKFOAOB);

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x3890690", Offset = "0x388EE90", VA = "0x183890690")]
	public MCHCCOHEPOI(IPCJOHDJDNG LLMKIKMAMMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x388FB10", Offset = "0x388E310", VA = "0x18388FB10")]
	public void HLOAGOLCMII(TNode OGNJOKKMMDG, TNode IKMEAKHBLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x3890430", Offset = "0x388EC30", VA = "0x183890430")]
	public void PPINICNDEPJ(TClaimant NHJEGOCFEFC, TNode OCILDDHGCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x388F4A0", Offset = "0x388DCA0", VA = "0x18388F4A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x3890290", Offset = "0x388EA90", VA = "0x183890290")]
	private void OPNJILFPCLA(TClaimant NHJEGOCFEFC, TNode HBIALLNCIKO, TNode OCILDDHGCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x388FAA0", Offset = "0x388E2A0", VA = "0x18388FAA0")]
	private int GIFOBFBEBAL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x388F1F0", Offset = "0x388D9F0", VA = "0x18388F1F0")]
	private void CCLMDAPKLBK(TClaimant NHJEGOCFEFC, TNode CJICHPMOGNK, TNode DOIEKGFGOJH, int NHPJDEOMMLB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x388EE30", Offset = "0x388D630", VA = "0x18388EE30")]
	private void AEIAACMPKGM(BOOGOKICICE NELANPPFCMO, OPKELAICGAL GKAFIJJCMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x388EF80", Offset = "0x388D780", VA = "0x18388EF80")]
	private void BNMCECBDMLJ(TClaimant NHJEGOCFEFC, TNode CJICHPMOGNK, TNode DOIEKGFGOJH, int NHPJDEOMMLB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x3890190", Offset = "0x388E990", VA = "0x183890190")]
	private void MHGKICIKDFG(BOOGOKICICE NELANPPFCMO, TNode OGNJOKKMMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x3890330", Offset = "0x388EB30", VA = "0x183890330")]
	private void PELOOJBIFBF(BOOGOKICICE NELANPPFCMO, OPKELAICGAL GKAFIJJCMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x388F960", Offset = "0x388E160", VA = "0x18388F960")]
	private void FMOLEOHEPIC(OPKELAICGAL GKAFIJJCMCA, bool MAMLKKKCEHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x388FB90", Offset = "0x388E390", VA = "0x18388FB90")]
	private void HNKGBCLCLNG(OPKELAICGAL GKAFIJJCMCA, TNode IKMEAKHBLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x388F700", Offset = "0x388DF00", VA = "0x18388F700")]
	[IteratorStateMachine(typeof(global::MCHCCOHEPOI<, >.EPONNCGGBPN))]
	private IEnumerable<TNode> ELMPCFKBJJA(TNode CJICHPMOGNK, TNode DOIEKGFGOJH, bool IJBFOJBGAGL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x388EEC0", Offset = "0x388D6C0", VA = "0x18388EEC0")]
	private OPKELAICGAL AJJCCPFHKMO(TNode OGNJOKKMMDG, TNode BNOBPGHCIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x388F7D0", Offset = "0x388DFD0", VA = "0x18388F7D0")]
	private OPKELAICGAL ENHJGHBKEGA(TNode OGNJOKKMMDG, TNode BNOBPGHCIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x388FFD0", Offset = "0x388E7D0", VA = "0x18388FFD0")]
	private void KJLFBFNCCIE(OPKELAICGAL GKAFIJJCMCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public class HJLJHALOHDB<T> : IEnumerable<global::HJLJHALOHDB<T>.KLGHKIGIFLB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public struct KLGHKIGIFLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public T HKJMLEKHILN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int EDBBKGCLEJF;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public class DJIHCDFOFND : IEnumerator<KLGHKIGIFLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private global::HJLJHALOHDB<T> OEKOFOPKINB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private int EDBBKGCLEJF;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x2C5EDF0", Offset = "0x2C5D5F0", VA = "0x182C5EDF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public KLGHKIGIFLB DIBBIBNFCIE
		{
			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x42EFD80", Offset = "0x42EE580", VA = "0x1842EFD80", Slot = "4")]
			get
			{
				return default(KLGHKIGIFLB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x9DCB30", Offset = "0x9DB330", VA = "0x1809DCB30")]
		public DJIHCDFOFND(global::HJLJHALOHDB<T> OEKOFOPKINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x42EFCF0", Offset = "0x42EE4F0", VA = "0x1842EFCF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x9DCB20", Offset = "0x9DB320", VA = "0x1809DCB20", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xA64EA0", Offset = "0xA636A0", VA = "0x180A64EA0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private struct IIHDOADPJAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public bool KGCLDOBCGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public T HKJMLEKHILN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private const int KDLNHHIKDBJ = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly Dictionary<T, int> CCEAAKFOJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private IIHDOADPJAA[] GDJIPBEBJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private int GCIOMNNAFCE;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int ODOEPNJDGKI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9D0", Offset = "0x5E91D0", VA = "0x1805EA9D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9E0", Offset = "0x5E91E0", VA = "0x1805EA9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public int MPKAKPNFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x230E970", Offset = "0x230D170", VA = "0x18230E970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x42F2BF0", Offset = "0x42F13F0", VA = "0x1842F2BF0")]
	public HJLJHALOHDB(int LJMMIINDJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x42F2800", Offset = "0x42F1000", VA = "0x1842F2800")]
	public HJLJHALOHDB(KLGHKIGIFLB[] HOJPMJEOHPD, bool GIIOFIPAEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x42F1DA0", Offset = "0x42F05A0", VA = "0x1842F1DA0")]
	public int FCJKMBHAELG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x42F2030", Offset = "0x42F0830", VA = "0x1842F2030")]
	private int JGADBFLPGLG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x42F2750", Offset = "0x42F0F50", VA = "0x1842F2750", Slot = "6")]
	protected virtual uint PIHHJMNENNF(uint FBPMKCBKEGD, T HKJMLEKHILN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x42F26D0", Offset = "0x42F0ED0", VA = "0x1842F26D0")]
	public bool MKNPLJFBIHE(T HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x42F1C10", Offset = "0x42F0410", VA = "0x1842F1C10")]
	public bool BFBAPIPOEGN(int EDBBKGCLEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x42F1C70", Offset = "0x42F0470", VA = "0x1842F1C70")]
	public bool BMCMFPADDFE(Func<T, bool> EPKLCBJAHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x42F2700", Offset = "0x42F0F00", VA = "0x1842F2700")]
	public int OKOJAHIBPFM(T HKJMLEKHILN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x42F1F40", Offset = "0x42F0740", VA = "0x1842F1F40")]
	public T HNKKECKIEEI(int EDBBKGCLEJF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x42F1D20", Offset = "0x42F0520", VA = "0x1842F1D20")]
	public void CPGPLJLMCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x42F2650", Offset = "0x42F0E50", VA = "0x1842F2650")]
	public bool KMHCKOBLAGL(T HKJMLEKHILN, bool ICCOMIAOJLO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x42F23F0", Offset = "0x42F0BF0", VA = "0x1842F23F0")]
	public bool KMHCKOBLAGL(T HKJMLEKHILN, int EDBBKGCLEJF, bool ICCOMIAOJLO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x42F1FB0", Offset = "0x42F07B0", VA = "0x1842F1FB0")]
	public bool IIDOOJBFPNM(T HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x42F2680", Offset = "0x42F0E80", VA = "0x1842F2680")]
	public bool LACDHDJJICN(int EDBBKGCLEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x42F1E60", Offset = "0x42F0660", VA = "0x1842F1E60")]
	private void HGIINAJKLPP(int EDBBKGCLEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x42F2280", Offset = "0x42F0A80", VA = "0x1842F2280")]
	public KLGHKIGIFLB[] JLNEILJALPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x42F1E10", Offset = "0x42F0610", VA = "0x1842F1E10")]
	private int FIMCDKLNCDI(int NCBFFIFJMOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x42F2780", Offset = "0x42F0F80", VA = "0x1842F2780", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x42F2780", Offset = "0x42F0F80", VA = "0x1842F2780", Slot = "4")]
	private IEnumerator<KLGHKIGIFLB> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class OGDBBNLOJNO<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly Stack<T> NLLAMJHJALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly List<T> JANIEJPNODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly int DKHKMPIIIKA;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public int BEDMCIALEJP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x2187C40", Offset = "0x2186440", VA = "0x182187C40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public int CEFALKMGBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x2800110", Offset = "0x27FE910", VA = "0x182800110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x27FFED0", Offset = "0x27FE6D0", VA = "0x1827FFED0")]
	public static global::OGDBBNLOJNO<T> EKJOOFGCJDK(int LJMMIINDJEO = 0, int DKHKMPIIIKA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x27FFCD0", Offset = "0x27FE4D0", VA = "0x1827FFCD0")]
	public static global::OGDBBNLOJNO<T> BGCNEBADLJN(int LJMMIINDJEO = 0, int DKHKMPIIIKA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x28003A0", Offset = "0x27FEBA0", VA = "0x1828003A0")]
	public OGDBBNLOJNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x28003E0", Offset = "0x27FEBE0", VA = "0x1828003E0")]
	public OGDBBNLOJNO(int LJMMIINDJEO, int DKHKMPIIIKA = int.MaxValue, bool AAGOLIHJOGH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x27FFBA0", Offset = "0x27FE3A0", VA = "0x1827FFBA0")]
	public T ALINGLOJNDA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x27FFFA0", Offset = "0x27FE7A0", VA = "0x1827FFFA0")]
	public void GONEKFIPKMK(T HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x27FFAE0", Offset = "0x27FE2E0", VA = "0x1827FFAE0")]
	private void AAFBHGBGHGL(T HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x27FFDA0", Offset = "0x27FE5A0", VA = "0x1827FFDA0")]
	private void BKJAOADGIGG(T HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2800140", Offset = "0x27FE940", VA = "0x182800140")]
	[Conditional("DEBUG_BUILD")]
	private void KJHJJNHGAKD(T DGNBPCMFHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2800060", Offset = "0x27FE860", VA = "0x182800060")]
	[Conditional("DEBUG_BUILD")]
	private void JAILOBKLFDD(T DGNBPCMFHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x27FFDC0", Offset = "0x27FE5C0", VA = "0x1827FFDC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x28001E0", Offset = "0x27FE9E0", VA = "0x1828001E0")]
	private void KPAPJPPHKHC(IEnumerable<T> DKICDNIDDLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class MBCGDJMIKBF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private Dictionary<int, T> HFHAJIMAMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private T KIJFBEKAJAN;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public virtual T CBBEODDLEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x575980", Offset = "0x574180", VA = "0x180575980", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool OGMKFHECBCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x3888DD0", Offset = "0x38875D0", VA = "0x183888DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x3888D10", Offset = "0x3887510", VA = "0x183888D10")]
	public bool EFBFJEKHDBL(T HKJMLEKHILN, int IJCLFNIDFIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x3888D70", Offset = "0x3887570", VA = "0x183888D70")]
	public bool LAHIJGOLBBE(int IJCLFNIDFIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x3888E10", Offset = "0x3887610", VA = "0x183888E10")]
	public T LHEFPHDFBDH(int BAABHKJFIGE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x3888C20", Offset = "0x3887420", VA = "0x183888C20")]
	public void CPGPLJLMCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x38893F0", Offset = "0x3887BF0", VA = "0x1838893F0")]
	private bool PJAGJOOKLPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x3888C80", Offset = "0x3887480", VA = "0x183888C80")]
	public bool DHIHCKAPBED(int IJCLFNIDFIK, out T HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x3421760", Offset = "0x341FF60", VA = "0x183421760")]
	public MBCGDJMIKBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class DAPFOBBMLEH<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	protected struct NBEGHPFLCID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public T MKOCEBDLMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int GJFKAPHFOBI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	protected readonly List<NBEGHPFLCID> NIJENAEGDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private T HPBDPPPADMP;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public int MPKAKPNFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x230E970", Offset = "0x230D170", VA = "0x18230E970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x3FE9F60", Offset = "0x3FE8760", VA = "0x183FE9F60")]
	public bool BMCMFPADDFE(T HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x3FEA210", Offset = "0x3FE8A10", VA = "0x183FEA210")]
	public void DEOBKNOOHMB(T HKJMLEKHILN, int IJCLFNIDFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x3FEA2B0", Offset = "0x3FE8AB0", VA = "0x183FEA2B0")]
	public bool IIDOOJBFPNM(T HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x3FEA1B0", Offset = "0x3FE89B0", VA = "0x183FEA1B0")]
	public void CPGPLJLMCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x3FEA650", Offset = "0x3FE8E50", VA = "0x183FEA650")]
	public T OBELBMFOPNH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x3FEA5E0", Offset = "0x3FE8DE0", VA = "0x183FEA5E0")]
	public T MLDNHPAPKBC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x3FEA3D0", Offset = "0x3FE8BD0", VA = "0x183FEA3D0")]
	private void MGCKKEBBMBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x3FEA6E0", Offset = "0x3FE8EE0", VA = "0x183FEA6E0")]
	public DAPFOBBMLEH()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		[LDCIOLBBPHN(CDEHJIBIIED.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x4F89EB0", Offset = "0x4F886B0", VA = "0x184F89EB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x4F8A380", Offset = "0x4F88B80", VA = "0x184F8A380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x4F8A1A0", Offset = "0x4F889A0", VA = "0x184F8A1A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x4F8A520", Offset = "0x4F88D20", VA = "0x184F8A520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x4F89D70", Offset = "0x4F88570", VA = "0x184F89D70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x4F8A240", Offset = "0x4F88A40", VA = "0x184F8A240")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x4F8A060", Offset = "0x4F88860", VA = "0x184F8A060")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x4F89CD0", Offset = "0x4F884D0", VA = "0x184F89CD0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public interface MOJOKBHHOBH
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public abstract class ResourcePrefabReference<T> : MOJOKBHHOBH where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x21919D0", Offset = "0x21901D0", VA = "0x1821919D0", Slot = "4")]
		public virtual T IGKMMMBGFEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class OEPIFKDOMAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly Dictionary<byte, ALIEGONLDEF> FLOHNJELLLC;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public ALIEGONLDEF ANAKIAOKGBN
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F780", VA = "0x180570F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x5DDA30", Offset = "0x5DC230", VA = "0x1805DDA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector2 HLFMKAJMBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xB2C780", Offset = "0xB2AF80", VA = "0x180B2C780")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x2ED8150", Offset = "0x2ED6950", VA = "0x182ED8150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector2 KDIFBBGBAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x108D8C0", Offset = "0x108C0C0", VA = "0x18108D8C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x19EF110", Offset = "0x19ED910", VA = "0x1819EF110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector2 LKLOFPHKPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x4F89260", Offset = "0x4F87A60", VA = "0x184F89260")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x4F89240", Offset = "0x4F87A40", VA = "0x184F89240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public int HMJNOEPDBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x577190", Offset = "0x575990", VA = "0x180577190")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x59D3B0", Offset = "0x59BBB0", VA = "0x18059D3B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x4F89280", Offset = "0x4F87A80", VA = "0x184F89280")]
	public OEPIFKDOMAA(Bounds DBPMKIJKABB, Vector2[] AILFLJLNFBE, int ADJHKNFKCCH, byte NCBFFIFJMOM, float BBIMJKPKFKI = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x4F88B90", Offset = "0x4F87390", VA = "0x184F88B90")]
	public ALIEGONLDEF IBPHHMIPOIB(byte EDBBKGCLEJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x4F88A80", Offset = "0x4F87280", VA = "0x184F88A80")]
	public void AFECIIEGKKO(Vector3 MGHDMPNEKLG, float GIMAABJIAHK, float IICJDCOEGIG, ref List<byte> GKABKAMLNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x4F88B70", Offset = "0x4F87370", VA = "0x184F88B70")]
	public void FFJAKBCPMKA(ALIEGONLDEF.FDIGOBOPBML NHOBPFJICBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x4F88BF0", Offset = "0x4F873F0", VA = "0x184F88BF0")]
	private ALIEGONLDEF ICLJFFPJHNI(byte EDBBKGCLEJF, ALIEGONLDEF.PBIOHBDBJGO PJJLBGOKKMH, ALIEGONLDEF BNOBPGHCIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x4F88D20", Offset = "0x4F87520", VA = "0x184F88D20")]
	private void JNJCDPBCEMP(ALIEGONLDEF BNOBPGHCIOL, Vector2[] AILFLJLNFBE, int BIOLLOKBCPP, int JECGKNKMDDK, int JMBEHKJCKPJ, int IJPMJKLJDBP, float BBIMJKPKFKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class ALIEGONLDEF
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public enum PBIOHBDBJGO
	{
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public enum FDIGOBOPBML
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public byte MCPFJGEDMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public Vector3 OIOAJLADKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public Vector3 KNCNKJJPBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public Vector3 MEDBKENPIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public Vector3 EILFHICBMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public PBIOHBDBJGO FMINDJOKMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public ALIEGONLDEF IKJEADEFGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public List<ALIEGONLDEF> MFNKBJINACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public bool BAFNEFPPKJE;

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x4F84620", Offset = "0x4F82E20", VA = "0x184F84620")]
	public ALIEGONLDEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x4F845C0", Offset = "0x4F82DC0", VA = "0x184F845C0")]
	public ALIEGONLDEF(byte BKOGMFPFOOA, PBIOHBDBJGO PJJLBGOKKMH, ALIEGONLDEF BNOBPGHCIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x4F844E0", Offset = "0x4F82CE0", VA = "0x184F844E0")]
	public void EKIJJHANCGF(ALIEGONLDEF OKNCABINNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910")]
	public void FFJAKBCPMKA(int CFAGLLKCCBM, FDIGOBOPBML NHOBPFJICBJ, int JDHLCIILNEO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x4F841F0", Offset = "0x4F829F0", VA = "0x184F841F0")]
	public void AFECIIEGKKO(List<byte> GKABKAMLNPM, Vector3 MGHDMPNEKLG, float GIMAABJIAHK, float IICJDCOEGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x4F84480", Offset = "0x4F82C80", VA = "0x184F84480")]
	public bool BMDJAHALPGE(Vector3 BFLKNHJAHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x4F84580", Offset = "0x4F82D80", VA = "0x184F84580")]
	public bool GDJHKENCDGH(Vector3 BFLKNHJAHLJ, float LHJAHIOMDDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class LJGFMIAIBMK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly Dictionary<T, object> PNGPDMGMOLE;

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x2C9F680", Offset = "0x2C9DE80", VA = "0x182C9F680")]
	public bool OIMDHPCANJO(T CHJGLBJIOLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x4151120", Offset = "0x414F920", VA = "0x184151120")]
	public bool OIMDHPCANJO(T CHJGLBJIOLN, object FIGDHHNIEAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x41510C0", Offset = "0x414F8C0", VA = "0x1841510C0")]
	public bool OIMDHPCANJO(T CHJGLBJIOLN, object FIGDHHNIEAN, out object OCNOEKGAENM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x4150FE0", Offset = "0x414F7E0", VA = "0x184150FE0")]
	public bool DDEENBHDNBE(T CHJGLBJIOLN, object FIGDHHNIEAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x4150F10", Offset = "0x414F710", VA = "0x184150F10")]
	public bool ABCJDPGPKAP(T CHJGLBJIOLN, object FIGDHHNIEAN, out object OCNOEKGAENM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x4150F50", Offset = "0x414F750", VA = "0x184150F50")]
	public bool DDEENBHDNBE(T CHJGLBJIOLN, object FIGDHHNIEAN, out object OCNOEKGAENM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x230F000", Offset = "0x230D800", VA = "0x18230F000")]
	public void AJHDCCEOJDD(T CHJGLBJIOLN, object FIGDHHNIEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x4151020", Offset = "0x414F820", VA = "0x184151020")]
	public void HPAIFFIMMID(T CHJGLBJIOLN, object FIGDHHNIEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x4151160", Offset = "0x414F960", VA = "0x184151160")]
	public LJGFMIAIBMK()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		public struct EENBJNOINNJ<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			private readonly List<Component> JKPOELIJJNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			private readonly bool NDGHMAHCMGD;

			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x1AE8360", Offset = "0x1AE6B60", VA = "0x181AE8360")]
			public EENBJNOINNJ(List<Component> JKPOELIJJNH, bool NDGHMAHCMGD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x2183760", Offset = "0x2181F60", VA = "0x182183760")]
			public OPJHLIBJLDH<T> JNPKLKEOKNK()
			{
				return default(OPJHLIBJLDH<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x21837D0", Offset = "0x2181FD0", VA = "0x1821837D0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x21837D0", Offset = "0x2181FD0", VA = "0x1821837D0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		public struct OPJHLIBJLDH<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			private readonly List<Component> JKPOELIJJNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			private readonly bool NDGHMAHCMGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			private int EDBBKGCLEJF;

			[Cpp2IlInjected.Token(Token = "0x170000C2")]
			public T DIBBIBNFCIE
			{
				[Cpp2IlInjected.Token(Token = "0x6000454")]
				[Cpp2IlInjected.Address(RVA = "0x218C2F0", Offset = "0x218AAF0", VA = "0x18218C2F0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C3")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000455")]
				[Cpp2IlInjected.Address(RVA = "0x218C280", Offset = "0x218AA80", VA = "0x18218C280", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x218C2C0", Offset = "0x218AAC0", VA = "0x18218C2C0")]
			public OPJHLIBJLDH(List<Component> JKPOELIJJNH, bool NDGHMAHCMGD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x218C1B0", Offset = "0x218A9B0", VA = "0x18218C1B0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x218C1C0", Offset = "0x218A9C0", VA = "0x18218C1C0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x218C270", Offset = "0x218AA70", VA = "0x18218C270", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x4F8C1E0", Offset = "0x4F8A9E0", VA = "0x184F8C1E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x4F8C1A0", Offset = "0x4F8A9A0", VA = "0x184F8C1A0")]
		public ToolHierarchyCache(GameObject KGBJKMMPNGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x4F8B9D0", Offset = "0x4F8A1D0", VA = "0x184F8B9D0")]
		private void CDGCMJJMEMA(GameObject KGBJKMMPNGC, bool EONIGAFBBGK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x4F8BAF0", Offset = "0x4F8A2F0", VA = "0x184F8BAF0")]
		public static void CDGCMJJMEMA(GameObject KGBJKMMPNGC, ref ToolHierarchyCache CFJAHBNPDIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x4F8BFB0", Offset = "0x4F8A7B0", VA = "0x184F8BFB0")]
		public void NHGMDHKKFOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x4F8B980", Offset = "0x4F8A180", VA = "0x184F8B980")]
		public void AFCLIHCDGOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x217C8C0", Offset = "0x217B0C0", VA = "0x18217C8C0")]
		public void IOGLLCECEPO<T>(Action<T> BBFDPEJCJGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x4F8C080", Offset = "0x4F8A880", VA = "0x184F8C080")]
		public Component PLLIDGKCLLA(Type LIBGCFIILKM, bool NDGHMAHCMGD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x23A3B40", Offset = "0x23A2340", VA = "0x1823A3B40")]
		public T PLLIDGKCLLA<T>(bool NDGHMAHCMGD = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x4F8BF20", Offset = "0x4F8A720", VA = "0x184F8BF20")]
		public EENBJNOINNJ<Component> NDPJDDALAEK(Type LIBGCFIILKM, bool NDGHMAHCMGD = false)
		{
			return default(EENBJNOINNJ<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x24AD9B0", Offset = "0x24AC1B0", VA = "0x1824AD9B0")]
		public EENBJNOINNJ<T> NDPJDDALAEK<T>(bool NDGHMAHCMGD = false) where T : class
		{
			return default(EENBJNOINNJ<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x4F8BC70", Offset = "0x4F8A470", VA = "0x184F8BC70")]
		public List<Component> NCHNHAJIODA(Type LIBGCFIILKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x4F8BB80", Offset = "0x4F8A380", VA = "0x184F8BB80", Slot = "4")]
		public bool Equals(ToolHierarchyCache FNGOAMCGAPH, ToolHierarchyCache HDKMFDOPGKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x4F8BC00", Offset = "0x4F8A400", VA = "0x184F8BC00", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache ALCFLDIFDGE)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public class DEFADNACHDC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private int LJMMIINDJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private int JFOGNJHKJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private List<T> CGCHDFAFNPL;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public int MPKAKPNFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x2187C40", Offset = "0x2186440", VA = "0x182187C40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public T OJCDEMLLCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x3FEC570", Offset = "0x3FEAD70", VA = "0x183FEC570")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public T NDBOJIJFKGB
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x3FEC690", Offset = "0x3FEAE90", VA = "0x183FEC690")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public T PGCPMFNMFDN
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x3FEC1D0", Offset = "0x3FEA9D0", VA = "0x183FEC1D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x3FEC750", Offset = "0x3FEAF50", VA = "0x183FEC750")]
	public DEFADNACHDC(int LJMMIINDJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x3FEC3B0", Offset = "0x3FEABB0", VA = "0x183FEC3B0")]
	public void DEOBKNOOHMB(T GFKIKPLELCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x3FEC290", Offset = "0x3FEAA90", VA = "0x183FEC290")]
	public void CPGPLJLMCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x3FEC5F0", Offset = "0x3FEADF0", VA = "0x183FEC5F0")]
	public void IFDMGHKCMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x3FEC480", Offset = "0x3FEAC80", VA = "0x183FEC480")]
	public void DJMJEKPGICE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x3FEC740", Offset = "0x3FEAF40", VA = "0x183FEC740")]
	public void LMKDNAKCAIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public class EFFGHCHIBIC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private bool EJJOGLGKACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private Action BBFDPEJCJGH;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public static EFFGHCHIBIC PNCFKANMOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x4F854B0", Offset = "0x4F83CB0", VA = "0x184F854B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool OCNHIAHCIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x577160", Offset = "0x575960", VA = "0x180577160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x7AC6F0", Offset = "0x7AAEF0", VA = "0x1807AC6F0")]
	public EFFGHCHIBIC(Action BBFDPEJCJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x4F85490", Offset = "0x4F83C90", VA = "0x184F85490")]
	public void GINAAGHMPKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x4F85490", Offset = "0x4F83C90", VA = "0x184F85490", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public static class BFPHNDLBAMF
{
	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910")]
	public static void FPFKLJGHFBF(MNGMCMOECDN MGFJPGGANLO, string MJHEMCKEHKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class DOPDKFJLBKJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	private struct BHBBAGFLJBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int GJFKAPHFOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public T MKOCEBDLMLE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly Dictionary<object, BHBBAGFLJBI> HFHAJIMAMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private T KIJFBEKAJAN;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public virtual T CBBEODDLEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x5EB790", Offset = "0x5E9F90", VA = "0x1805EB790", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x2A48400", Offset = "0x2A46C00", VA = "0x182A48400", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool OGMKFHECBCO
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x341CA30", Offset = "0x341B230", VA = "0x18341CA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public object HMAIJECGIJH
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x5749E0", Offset = "0x5731E0", VA = "0x1805749E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x5D51A0", Offset = "0x5D39A0", VA = "0x1805D51A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x341C580", Offset = "0x341AD80", VA = "0x18341C580")]
	public bool EFBFJEKHDBL(T HKJMLEKHILN, object FIGDHHNIEAN, int IJCLFNIDFIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x341C9C0", Offset = "0x341B1C0", VA = "0x18341C9C0")]
	public bool LAHIJGOLBBE(object FIGDHHNIEAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x341BC80", Offset = "0x341A480", VA = "0x18341BC80")]
	public bool DHIHCKAPBED(object FIGDHHNIEAN, out T HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x2ED7830", Offset = "0x2ED6030", VA = "0x182ED7830")]
	public void CPGPLJLMCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x341F4A0", Offset = "0x341DCA0", VA = "0x18341F4A0")]
	private bool PJAGJOOKLPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x3421760", Offset = "0x341FF60", VA = "0x183421760")]
	public DOPDKFJLBKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public class OPJPEONBADK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private Dictionary<object, float> HFHAJIMAMJA;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public float BIIJJMIIGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x7BCF70", Offset = "0x7BB770", VA = "0x1807BCF70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x7BCE00", Offset = "0x7BB600", VA = "0x1807BCE00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x4F897F0", Offset = "0x4F87FF0", VA = "0x184F897F0")]
	public void EFBFJEKHDBL(float HKJMLEKHILN, object FIGDHHNIEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x4F89980", Offset = "0x4F88180", VA = "0x184F89980")]
	public void LAHIJGOLBBE(object FIGDHHNIEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x4F89860", Offset = "0x4F88060", VA = "0x184F89860")]
	private void GFCDEEPJLDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x4F899F0", Offset = "0x4F881F0", VA = "0x184F899F0")]
	public OPJPEONBADK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public class MHJKMEIIICB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public readonly string FIMNAGACLAD;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x668D60", Offset = "0x667560", VA = "0x180668D60")]
	public MHJKMEIIICB(string DNDDNFNCDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x4F87B90", Offset = "0x4F86390", VA = "0x184F87B90")]
	public MHJKMEIIICB(UnityEngine.Object KCIPDLGMCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x4F87B40", Offset = "0x4F86340", VA = "0x184F87B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class MNGMCMOECDN
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private sealed class KDLABGEMKCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public KDLABGEMKCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x4F87470", Offset = "0x4F85C70", VA = "0x184F87470")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly HashSet<object> LIKEOCCPPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private int OPGKPPBJBBN;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public IReadOnlyCollection<object> ANJIIOKDMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F780", VA = "0x180570F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool OAAKLHHCIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x4F87DA0", Offset = "0x4F865A0", VA = "0x184F87DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public int MPKAKPNFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x5D78C0", Offset = "0x5D60C0", VA = "0x1805D78C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x4F87CA0", Offset = "0x4F864A0", VA = "0x184F87CA0")]
	public bool DEOBKNOOHMB(object FIGDHHNIEAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x4F87D20", Offset = "0x4F86520", VA = "0x184F87D20")]
	public bool IIDOOJBFPNM(object FIGDHHNIEAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x4F87C40", Offset = "0x4F86440", VA = "0x184F87C40")]
	public bool BMCMFPADDFE(object FIGDHHNIEAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x4F87DB0", Offset = "0x4F865B0", VA = "0x184F87DB0")]
	public void JDONKNDALCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x4F87E10", Offset = "0x4F86610", VA = "0x184F87E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x4F87F80", Offset = "0x4F86780", VA = "0x184F87F80")]
	public MNGMCMOECDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public class OCKOGJDNCMG<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	private struct CCICFCGDIFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public float ICBDJDBNCEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public T MKOCEBDLMLE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private Dictionary<object, CCICFCGDIFP> HFHAJIMAMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private T NLOMBPOJOOL;

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public virtual T MEABEKHDEFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x1125920", Offset = "0x1124120", VA = "0x181125920", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x1DB71D0", Offset = "0x1DB59D0", VA = "0x181DB71D0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public object IJNNBFJFPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x574330", Offset = "0x572B30", VA = "0x180574330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x6155C0", Offset = "0x613DC0", VA = "0x1806155C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool OGMKFHECBCO
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x2ED8110", Offset = "0x2ED6910", VA = "0x182ED8110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x2ED7BD0", Offset = "0x2ED63D0", VA = "0x182ED7BD0")]
	public bool EFBFJEKHDBL(T HKJMLEKHILN, object FIGDHHNIEAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x2ED80B0", Offset = "0x2ED68B0", VA = "0x182ED80B0")]
	public bool LAHIJGOLBBE(object FIGDHHNIEAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x2ED7830", Offset = "0x2ED6030", VA = "0x182ED7830")]
	public void CPGPLJLMCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x2ED7930", Offset = "0x2ED6130", VA = "0x182ED7930")]
	public bool DHIHCKAPBED(object FIGDHHNIEAN, out T HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x2ED8460", Offset = "0x2ED6C60", VA = "0x182ED8460")]
	private bool PJAGJOOKLPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x2ED99D0", Offset = "0x2ED81D0", VA = "0x182ED99D0")]
	public OCKOGJDNCMG()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public class JOLDJLBOGLF
{
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static byte[] NNDNCLBIBCO;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static int BOAHHKDAAGN;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static int BEAECOMNAKK;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static BigInteger HPFDFIDLOGO;

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public JOLDJLBOGLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x4F86E00", Offset = "0x4F85600", VA = "0x184F86E00")]
	private static string AAANGJFGDHI(byte[] EOEFACHALFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x4F86F00", Offset = "0x4F85700", VA = "0x184F86F00")]
	public static string CHJFNPPOLEP(byte[] IFAOIOLKGMC, bool CCLJOEHHPGP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
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
