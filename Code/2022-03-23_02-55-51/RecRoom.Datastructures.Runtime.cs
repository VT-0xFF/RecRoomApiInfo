using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class BGPGJKINABG : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6853A0", Offset = "0x683BA0", VA = "0x1806853A0")]
	public BGPGJKINABG()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000003")]
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
	[BGEBFJLHIKH]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[BGEBFJLHIKH]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4A89870", Offset = "0x4A88070", VA = "0x184A89870")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4A89830", Offset = "0x4A88030", VA = "0x184A89830")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4A898B0", Offset = "0x4A880B0", VA = "0x184A898B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4A89AC0", Offset = "0x4A882C0", VA = "0x184A89AC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4A89A30", Offset = "0x4A88230", VA = "0x184A89A30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xE34B40", Offset = "0xE33340", VA = "0x180E34B40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE34B20", Offset = "0xE33320", VA = "0x180E34B20")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4A897F0", Offset = "0x4A87FF0", VA = "0x184A897F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4A899A0", Offset = "0x4A881A0", VA = "0x184A899A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4A89220", Offset = "0x4A87A20", VA = "0x184A89220")]
	public void CopyBounds(SavedExtents DKNLIFHKLLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4A89760", Offset = "0x4A87F60", VA = "0x184A89760")]
	public void SetLocalSpaceBounds(Bounds MHMCNPPGFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x83C920", Offset = "0x83B120", VA = "0x18083C920")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4A89750", Offset = "0x4A87F50", VA = "0x184A89750")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4A89310", Offset = "0x4A87B10", VA = "0x184A89310")]
	private void MOBCIONHMLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4A89520", Offset = "0x4A87D20", VA = "0x184A89520")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4A88C60", Offset = "0x4A87460", VA = "0x184A88C60")]
	public static void CalculateLocalBoundsFor(GameObject EMIOHDNKBKG, out Bounds MHMCNPPGFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4A89250", Offset = "0x4A87A50", VA = "0x184A89250")]
	private static void HEJMJMKLBBD(Bounds DOMNMKJGGGI, Color BBFAELNBDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4A89780", Offset = "0x4A87F80", VA = "0x184A89780")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000005")]
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
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5211D0", Offset = "0x51F9D0", VA = "0x1805211D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x521EE0", Offset = "0x5206E0", VA = "0x180521EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5214A0", Offset = "0x51FCA0", VA = "0x1805214A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "4")]
	public virtual void FOBDKMFNDKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[BGPGJKINABG]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3D24850", Offset = "0x3D23050", VA = "0x183D24850", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3D24390", Offset = "0x3D22B90", VA = "0x183D24390", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3D24E50", Offset = "0x3D23650", VA = "0x183D24E50")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class GAJCAAHGCCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
		public GAJCAAHGCCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3256E60", Offset = "0x3255660", VA = "0x183256E60")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[BGPGJKINABG]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5211D0", Offset = "0x51F9D0", VA = "0x1805211D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x324D020", Offset = "0x324B820", VA = "0x18324D020", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x324D050", Offset = "0x324B850", VA = "0x18324D050", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x324CF70", Offset = "0x324B770", VA = "0x18324CF70", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey MHAAPGJKGCK]
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x324CFA0", Offset = "0x324B7A0", VA = "0x18324CFA0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x324CE70", Offset = "0x324B670", VA = "0x18324CE70", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x324C6D0", Offset = "0x324AED0", VA = "0x18324C6D0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x324C040", Offset = "0x324A840", VA = "0x18324C040", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x324BBB0", Offset = "0x324A3B0", VA = "0x18324BBB0", Slot = "14")]
	protected virtual string FHGOIFNICAA(TKeyVal PBMAMIDIIPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x26973A0", Offset = "0x2695BA0", VA = "0x1826973A0", Slot = "4")]
	public bool ContainsKey(TKey MHAAPGJKGCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x324CD60", Offset = "0x324B560", VA = "0x18324CD60", Slot = "5")]
	public bool TryGetValue(TKey MHAAPGJKGCK, out TVal DOBKOKNNFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x324BC40", Offset = "0x324A440", VA = "0x18324BC40", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x324BC40", Offset = "0x324A440", VA = "0x18324BC40", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x324CD90", Offset = "0x324B590", VA = "0x18324CD90")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class OIHGBKLGBDN<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class COOCGIAMCFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
		public COOCGIAMCFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3325360", Offset = "0x3323B60", VA = "0x183325360")]
		internal bool <GetSamples>b__0(global::NEFPBMJPAEA<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float DMMAMPAEAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float ENMNKPHBGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::NEFPBMJPAEA<float, T>> CAMAEJDCPLM;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int HNOADKGOCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x332E300", Offset = "0x332CB00", VA = "0x18332E300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x332E400", Offset = "0x332CC00", VA = "0x18332E400")]
	public OIHGBKLGBDN(float PIIOLLGMGBG, float LGBJBGDMKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x332DA30", Offset = "0x332C230", VA = "0x18332DA30")]
	public bool DFKBACLMPGD(float COFPBMLJNKJ, T DOBKOKNNFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x332D870", Offset = "0x332C070", VA = "0x18332D870")]
	public int BAMIBBIHCJA(float COFPBMLJNKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x332DC80", Offset = "0x332C480", VA = "0x18332DC80")]
	public IEnumerable<T> FCDBKNOADDE(float COFPBMLJNKJ, [Optional] float? MKGPJHOPAEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x332DB90", Offset = "0x332C390", VA = "0x18332DB90")]
	public void DKOADGNIPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x332DBC0", Offset = "0x332C3C0", VA = "0x18332DBC0")]
	private void ECFPIOKNNGJ(float COFPBMLJNKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public abstract class IOGFBFLBDBL<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct MBPDEJJIKBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T MPJDHKAGMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float FCDEAOIBGIB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float NKKMLMCLIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> DJFKHIAHICP;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int LBPJDMPHAOA = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private MBPDEJJIKBJ[] GGAIBHJOFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int KMJCFMEFNIP;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float CIGNHJNBOAO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xF16780", Offset = "0xF14F80", VA = "0x180F16780")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xF167B0", Offset = "0xF14FB0", VA = "0x180F167B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3209BA0", Offset = "0x32083A0", VA = "0x183209BA0")]
	public IOGFBFLBDBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3209AC0", Offset = "0x32082C0", VA = "0x183209AC0")]
	public IOGFBFLBDBL(int LGIEDJBGIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3208F10", Offset = "0x3207710", VA = "0x183208F10")]
	public void EFDMEADFFJF(float COFPBMLJNKJ, T DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x32086E0", Offset = "0x3206EE0", VA = "0x1832086E0")]
	public void DKOADGNIPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3209020", Offset = "0x3207820", VA = "0x183209020")]
	public bool MOEANEAPHFH(float EMPDPLNIBBA, float MEBKPMKOLDP, out T DOBKOKNNFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x32095B0", Offset = "0x3207DB0", VA = "0x1832095B0")]
	public bool OLMHEFNGBMC(float EMPDPLNIBBA, float MEBKPMKOLDP, out T DOBKOKNNFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3208980", Offset = "0x3207180", VA = "0x183208980")]
	public void DNOLHCIBMKB(float EMPDPLNIBBA, float MEBKPMKOLDP, List<T> FFBNFFLLBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3208FF0", Offset = "0x32077F0", VA = "0x183208FF0")]
	private int JMJIHEEGKDJ(int GOLMPOOCPFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3209A30", Offset = "0x3208230", VA = "0x183209A30")]
	private void PFBDHEHEFAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CEPKBEIMIGJ();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T AGFCFOOGHEJ(T NFKMLPDPPMJ, T DLLGEGNNIDF, float PKNCKFNLBFL);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T HODGNAAHKOE(T DOBKOKNNFGA, float PKNCKFNLBFL);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T IBBDBDMGGBI(T NFKMLPDPPMJ, T DLLGEGNNIDF);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T MALJIJAGMEO(T NFKMLPDPPMJ, T DLLGEGNNIDF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class ALKODKBEAIE : global::IOGFBFLBDBL<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4A84A00", Offset = "0x4A83200", VA = "0x184A84A00", Slot = "4")]
	protected override Vector3 CEPKBEIMIGJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4A84940", Offset = "0x4A83140", VA = "0x184A84940", Slot = "5")]
	protected override Vector3 AGFCFOOGHEJ(Vector3 NFKMLPDPPMJ, Vector3 DLLGEGNNIDF, float PKNCKFNLBFL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4A84A70", Offset = "0x4A83270", VA = "0x184A84A70", Slot = "6")]
	protected override Vector3 HODGNAAHKOE(Vector3 DOBKOKNNFGA, float PKNCKFNLBFL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4A84B10", Offset = "0x4A83310", VA = "0x184A84B10", Slot = "7")]
	protected override Vector3 IBBDBDMGGBI(Vector3 NFKMLPDPPMJ, Vector3 DLLGEGNNIDF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4A84BC0", Offset = "0x4A833C0", VA = "0x184A84BC0", Slot = "8")]
	protected override Vector3 MALJIJAGMEO(Vector3 NFKMLPDPPMJ, Vector3 DLLGEGNNIDF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4A84C30", Offset = "0x4A83430", VA = "0x184A84C30")]
	public ALKODKBEAIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PCKEPAPBAOB : global::IOGFBFLBDBL<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4A881B0", Offset = "0x4A869B0", VA = "0x184A881B0")]
	public PCKEPAPBAOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4A88210", Offset = "0x4A86A10", VA = "0x184A88210")]
	public PCKEPAPBAOB(int LGIEDJBGIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xDC69B0", Offset = "0xDC51B0", VA = "0x180DC69B0", Slot = "4")]
	protected override float CEPKBEIMIGJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4A88120", Offset = "0x4A86920", VA = "0x184A88120", Slot = "5")]
	protected override float AGFCFOOGHEJ(float NFKMLPDPPMJ, float DLLGEGNNIDF, float PKNCKFNLBFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2E90", Offset = "0x3ED1690", VA = "0x183ED2E90", Slot = "6")]
	protected override float HODGNAAHKOE(float DOBKOKNNFGA, float PKNCKFNLBFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x228FA40", Offset = "0x228E240", VA = "0x18228FA40", Slot = "7")]
	protected override float IBBDBDMGGBI(float NFKMLPDPPMJ, float DLLGEGNNIDF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4A881A0", Offset = "0x4A869A0", VA = "0x184A881A0", Slot = "8")]
	protected override float MALJIJAGMEO(float NFKMLPDPPMJ, float DLLGEGNNIDF)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CDFBGLAFKHM
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1988710", Offset = "0x1986F10", VA = "0x181988710")]
	public static global::BGOBOBACLNH<T1> OGMFEGPOBPM<T1>(T1 EEHLOCJHJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1CEE970", Offset = "0x1CED170", VA = "0x181CEE970")]
	public static global::NEFPBMJPAEA<T1, T2> OGMFEGPOBPM<T1, T2>(T1 EEHLOCJHJFM, T2 GKIMEJILPHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x250E740", Offset = "0x250CF40", VA = "0x18250E740")]
	public static global::HPINPEMCIKK<T1, T2, T3> OGMFEGPOBPM<T1, T2, T3>(T1 EEHLOCJHJFM, T2 GKIMEJILPHL, T3 MPDMAJMOFHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x29C84B0", Offset = "0x29C6CB0", VA = "0x1829C84B0")]
	public static global::DMMHOEHEBEN<T1, T2, T3, T4> OGMFEGPOBPM<T1, T2, T3, T4>(T1 EEHLOCJHJFM, T2 GKIMEJILPHL, T3 MPDMAJMOFHD, T4 HCADMEJOPKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1CEEB60", Offset = "0x1CED360", VA = "0x181CEEB60")]
	public static global::MFHJFIIOGHB<T1, T2, T3, T4, T5> OGMFEGPOBPM<T1, T2, T3, T4, T5>(T1 EEHLOCJHJFM, T2 GKIMEJILPHL, T3 MPDMAJMOFHD, T4 HCADMEJOPKB, T5 KPMHNBIGGDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1CEEAB0", Offset = "0x1CED2B0", VA = "0x181CEEAB0")]
	public static global::OGCAOMIMEHF<T1, T2, T3, T4, T5, T6> OGMFEGPOBPM<T1, T2, T3, T4, T5, T6>(T1 EEHLOCJHJFM, T2 GKIMEJILPHL, T3 MPDMAJMOFHD, T4 HCADMEJOPKB, T5 KPMHNBIGGDM, T6 EEHPILMFPPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x29C83F0", Offset = "0x29C6BF0", VA = "0x1829C83F0")]
	public static global::EKPKHLCKFBH<T1, T2, T3, T4, T5, T6, T7> OGMFEGPOBPM<T1, T2, T3, T4, T5, T6, T7>(T1 EEHLOCJHJFM, T2 GKIMEJILPHL, T3 MPDMAJMOFHD, T4 HCADMEJOPKB, T5 KPMHNBIGGDM, T6 EEHPILMFPPG, T7 DPGHMIMINFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1CEE9E0", Offset = "0x1CED1E0", VA = "0x181CEE9E0")]
	public static global::JIMJHCAKCHJ<T1, T2, T3, T4, T5, T6, T7, T8> OGMFEGPOBPM<T1, T2, T3, T4, T5, T6, T7, T8>(T1 EEHLOCJHJFM, T2 GKIMEJILPHL, T3 MPDMAJMOFHD, T4 HCADMEJOPKB, T5 KPMHNBIGGDM, T6 EEHPILMFPPG, T7 DPGHMIMINFM, T8 FBHEDKHNBHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x18A7EE0", Offset = "0x18A66E0", VA = "0x1818A7EE0")]
	[IteratorStateMachine(typeof(PKEMJBLGECN))]
	public static IEnumerable<global::NEFPBMJPAEA<T1, T2>> ABGDJBABMKK<T1, T2>(IEnumerable<T1> DIDMABCLHLL, IEnumerable<T2> DOMNMKJGGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x18A9DB0", Offset = "0x18A85B0", VA = "0x1818A9DB0")]
	[IteratorStateMachine(typeof(DEFDIMMKNIH))]
	public static IEnumerable<global::HPINPEMCIKK<T1, T2, T3>> ABGDJBABMKK<T1, T2, T3>(IEnumerable<T1> DIDMABCLHLL, IEnumerable<T2> DOMNMKJGGGI, IEnumerable<T3> BBFAELNBDJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2408A40", Offset = "0x2407240", VA = "0x182408A40")]
	internal static int FNMINOFKHPF(int CFDDMNMNBKF, int ACNDNGJIDDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4259A40", Offset = "0x4258240", VA = "0x184259A40")]
	internal static int FNMINOFKHPF(int CFDDMNMNBKF, int ACNDNGJIDDO, int IJFKGCBCOMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4259A50", Offset = "0x4258250", VA = "0x184259A50")]
	internal static int FNMINOFKHPF(int CFDDMNMNBKF, int ACNDNGJIDDO, int IJFKGCBCOMC, int JBICPPJOIAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4A84D10", Offset = "0x4A83510", VA = "0x184A84D10")]
	internal static int FNMINOFKHPF(int CFDDMNMNBKF, int ACNDNGJIDDO, int IJFKGCBCOMC, int JBICPPJOIAO, int LGKIJFBOJCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4A84CF0", Offset = "0x4A834F0", VA = "0x184A84CF0")]
	internal static int FNMINOFKHPF(int CFDDMNMNBKF, int ACNDNGJIDDO, int IJFKGCBCOMC, int JBICPPJOIAO, int LGKIJFBOJCF, int DNIBMJFOIJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4A84D60", Offset = "0x4A83560", VA = "0x184A84D60")]
	internal static int FNMINOFKHPF(int CFDDMNMNBKF, int ACNDNGJIDDO, int IJFKGCBCOMC, int JBICPPJOIAO, int LGKIJFBOJCF, int DNIBMJFOIJJ, int INKHHLAIFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4A84D30", Offset = "0x4A83530", VA = "0x184A84D30")]
	internal static int FNMINOFKHPF(int CFDDMNMNBKF, int ACNDNGJIDDO, int IJFKGCBCOMC, int JBICPPJOIAO, int LGKIJFBOJCF, int DNIBMJFOIJJ, int INKHHLAIFIL, int KMDLLLBHIGC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class BGOBOBACLNH<T1> : IComparable<global::BGOBOBACLNH<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 DLLJMFFGNKI;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x21260B0", Offset = "0x21248B0", VA = "0x1821260B0")]
	public BGOBOBACLNH(T1 EEHLOCJHJFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x36B4630", Offset = "0x36B2E30", VA = "0x1836B4630", Slot = "4")]
	public int CompareTo(global::BGOBOBACLNH<T1> DKNLIFHKLLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x36B46A0", Offset = "0x36B2EA0", VA = "0x1836B46A0", Slot = "0")]
	public override bool Equals(object DKNLIFHKLLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x82F3D0", Offset = "0x82DBD0", VA = "0x18082F3D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x36B4740", Offset = "0x36B2F40", VA = "0x1836B4740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NEFPBMJPAEA<T1, T2> : IComparable<global::NEFPBMJPAEA<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 DLLJMFFGNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 IIINCEAOPLJ;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1C0CD70", Offset = "0x1C0B570", VA = "0x181C0CD70")]
	public NEFPBMJPAEA(T1 EEHLOCJHJFM, T2 GKIMEJILPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1C0AEF0", Offset = "0x1C096F0", VA = "0x181C0AEF0", Slot = "4")]
	public int CompareTo(global::NEFPBMJPAEA<T1, T2> DKNLIFHKLLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1C0BB70", Offset = "0x1C0A370", VA = "0x181C0BB70", Slot = "0")]
	public override bool Equals(object DKNLIFHKLLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1C0C090", Offset = "0x1C0A890", VA = "0x181C0C090", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1C0C600", Offset = "0x1C0AE00", VA = "0x181C0C600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HPINPEMCIKK<T1, T2, T3> : IComparable<global::HPINPEMCIKK<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 DLLJMFFGNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 IIINCEAOPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 BKABDCAHFBF;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3484FC0", Offset = "0x34837C0", VA = "0x183484FC0")]
	public HPINPEMCIKK(T1 EEHLOCJHJFM, T2 GKIMEJILPHL, T3 MPDMAJMOFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x34848E0", Offset = "0x34830E0", VA = "0x1834848E0", Slot = "4")]
	public int CompareTo(global::HPINPEMCIKK<T1, T2, T3> DKNLIFHKLLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x34849E0", Offset = "0x34831E0", VA = "0x1834849E0", Slot = "0")]
	public override bool Equals(object DKNLIFHKLLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3484CD0", Offset = "0x34834D0", VA = "0x183484CD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3484E30", Offset = "0x3483630", VA = "0x183484E30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DMMHOEHEBEN<T1, T2, T3, T4> : IComparable<global::DMMHOEHEBEN<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 DLLJMFFGNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 IIINCEAOPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 BKABDCAHFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 GAEOAGOIGOJ;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3A3FF70", Offset = "0x3A3E770", VA = "0x183A3FF70")]
	public DMMHOEHEBEN(T1 EEHLOCJHJFM, T2 GKIMEJILPHL, T3 MPDMAJMOFHD, T4 HCADMEJOPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3A3FB40", Offset = "0x3A3E340", VA = "0x183A3FB40", Slot = "4")]
	public int CompareTo(global::DMMHOEHEBEN<T1, T2, T3, T4> DKNLIFHKLLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3A3FC80", Offset = "0x3A3E480", VA = "0x183A3FC80", Slot = "0")]
	public override bool Equals(object DKNLIFHKLLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3A3FDA0", Offset = "0x3A3E5A0", VA = "0x183A3FDA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3A3FE60", Offset = "0x3A3E660", VA = "0x183A3FE60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MFHJFIIOGHB<T1, T2, T3, T4, T5> : IComparable<global::MFHJFIIOGHB<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 DLLJMFFGNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 IIINCEAOPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 BKABDCAHFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 GAEOAGOIGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 LMFNAOMEELP;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2B777A0", Offset = "0x2B75FA0", VA = "0x182B777A0")]
	public MFHJFIIOGHB(T1 EEHLOCJHJFM, T2 GKIMEJILPHL, T3 MPDMAJMOFHD, T4 HCADMEJOPKB, T5 KPMHNBIGGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2B772B0", Offset = "0x2B75AB0", VA = "0x182B772B0", Slot = "4")]
	public int CompareTo(global::MFHJFIIOGHB<T1, T2, T3, T4, T5> DKNLIFHKLLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2B77430", Offset = "0x2B75C30", VA = "0x182B77430", Slot = "0")]
	public override bool Equals(object DKNLIFHKLLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2B77570", Offset = "0x2B75D70", VA = "0x182B77570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2B77670", Offset = "0x2B75E70", VA = "0x182B77670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OGCAOMIMEHF<T1, T2, T3, T4, T5, T6> : IComparable<global::OGCAOMIMEHF<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 DLLJMFFGNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 IIINCEAOPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 BKABDCAHFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 GAEOAGOIGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 LMFNAOMEELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 DDMENAMKGJN;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x332AC80", Offset = "0x3329480", VA = "0x18332AC80")]
	public OGCAOMIMEHF(T1 EEHLOCJHJFM, T2 GKIMEJILPHL, T3 MPDMAJMOFHD, T4 HCADMEJOPKB, T5 KPMHNBIGGDM, T6 EEHPILMFPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x332A6E0", Offset = "0x3328EE0", VA = "0x18332A6E0", Slot = "4")]
	public int CompareTo(global::OGCAOMIMEHF<T1, T2, T3, T4, T5, T6> DKNLIFHKLLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x332A8A0", Offset = "0x33290A0", VA = "0x18332A8A0", Slot = "0")]
	public override bool Equals(object DKNLIFHKLLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x332AA10", Offset = "0x3329210", VA = "0x18332AA10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x332AB30", Offset = "0x3329330", VA = "0x18332AB30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EKPKHLCKFBH<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::EKPKHLCKFBH<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 DLLJMFFGNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 IIINCEAOPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 BKABDCAHFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 GAEOAGOIGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 LMFNAOMEELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 DDMENAMKGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 DEFHBIHBLKN;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x38CBDD0", Offset = "0x38CA5D0", VA = "0x1838CBDD0")]
	public EKPKHLCKFBH(T1 EEHLOCJHJFM, T2 GKIMEJILPHL, T3 MPDMAJMOFHD, T4 HCADMEJOPKB, T5 KPMHNBIGGDM, T6 EEHPILMFPPG, T7 DPGHMIMINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x38CB770", Offset = "0x38C9F70", VA = "0x1838CB770", Slot = "4")]
	public int CompareTo(global::EKPKHLCKFBH<T1, T2, T3, T4, T5, T6, T7> DKNLIFHKLLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x38CB970", Offset = "0x38CA170", VA = "0x1838CB970", Slot = "0")]
	public override bool Equals(object DKNLIFHKLLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x38CBB10", Offset = "0x38CA310", VA = "0x1838CBB10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x38CBC60", Offset = "0x38CA460", VA = "0x1838CBC60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JIMJHCAKCHJ<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::JIMJHCAKCHJ<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 DLLJMFFGNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 IIINCEAOPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 BKABDCAHFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 GAEOAGOIGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 LMFNAOMEELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 DDMENAMKGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 DEFHBIHBLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 NABMDJFEOHE;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2EA7A30", Offset = "0x2EA6230", VA = "0x182EA7A30")]
	public JIMJHCAKCHJ(T1 EEHLOCJHJFM, T2 GKIMEJILPHL, T3 MPDMAJMOFHD, T4 HCADMEJOPKB, T5 KPMHNBIGGDM, T6 EEHPILMFPPG, T7 DPGHMIMINFM, T8 FBHEDKHNBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2EA7320", Offset = "0x2EA5B20", VA = "0x182EA7320", Slot = "4")]
	public int CompareTo(global::JIMJHCAKCHJ<T1, T2, T3, T4, T5, T6, T7, T8> DKNLIFHKLLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2EA7570", Offset = "0x2EA5D70", VA = "0x182EA7570", Slot = "0")]
	public override bool Equals(object DKNLIFHKLLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2EA7730", Offset = "0x2EA5F30", VA = "0x182EA7730", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2EA78A0", Offset = "0x2EA60A0", VA = "0x182EA78A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
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
	public T MPJDHKAGMAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x549A30", Offset = "0x548230", VA = "0x180549A30")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x659540", Offset = "0x657D40", VA = "0x180659540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float PLOMPLLNJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xE34B10", Offset = "0xE33310", VA = "0x180E34B10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x38EE9C0", Offset = "0x38ED1C0", VA = "0x1838EE9C0")]
	public T IPMOAFLJODE(float PKNCKFNLBFL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x38EE6E0", Offset = "0x38ECEE0", VA = "0x1838EE6E0")]
	public T ADJGANJHKHD(float PKNCKFNLBFL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T AGFCFOOGHEJ(T NFKMLPDPPMJ, T DLLGEGNNIDF, float PKNCKFNLBFL);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4A85150", Offset = "0x4A83950", VA = "0x184A85150", Slot = "4")]
	protected override float AGFCFOOGHEJ(float NFKMLPDPPMJ, float DLLGEGNNIDF, float PKNCKFNLBFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4A851D0", Offset = "0x4A839D0", VA = "0x184A851D0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4A8AA20", Offset = "0x4A89220", VA = "0x184A8AA20", Slot = "4")]
	protected override Vector3 AGFCFOOGHEJ(Vector3 NFKMLPDPPMJ, Vector3 DLLGEGNNIDF, float PKNCKFNLBFL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4A8AAE0", Offset = "0x4A892E0", VA = "0x184A8AAE0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4A85080", Offset = "0x4A83880", VA = "0x184A85080", Slot = "4")]
	protected override Color AGFCFOOGHEJ(Color NFKMLPDPPMJ, Color DLLGEGNNIDF, float PKNCKFNLBFL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4A850D0", Offset = "0x4A838D0", VA = "0x184A850D0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public sealed class IINBIHFGFAM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private T[] DMNBBDNJDJN;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int MKFJBHDFMPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5AD670", Offset = "0x5ABE70", VA = "0x1805AD670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6735D0", Offset = "0x671DD0", VA = "0x1806735D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T EDFJNANCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x37EFD20", Offset = "0x37EE520", VA = "0x1837EFD20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x31F9D90", Offset = "0x31F8590", VA = "0x1831F9D90")]
	public static global::IINBIHFGFAM<T> PKKPJKMPPCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x31F9610", Offset = "0x31F7E10", VA = "0x1831F9610")]
	public static global::IINBIHFGFAM<T> ACEKLPJHEDE(int PODLECMNECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x31F9EC0", Offset = "0x31F86C0", VA = "0x1831F9EC0")]
	private IINBIHFGFAM(T[] INAFKNEDBHA, int PODLECMNECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x31F9750", Offset = "0x31F7F50", VA = "0x1831F9750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x37EF880", Offset = "0x37EE080", VA = "0x1837EF880")]
	public void EFDMEADFFJF(in T DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x31F97C0", Offset = "0x31F7FC0", VA = "0x1831F97C0")]
	public void EEIBIAAMIOE(int MPFAEFMOAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x37EF990", Offset = "0x37EE190", VA = "0x1837EF990")]
	public void HICPDAONBIK(in T DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x37EF4E0", Offset = "0x37EDCE0", VA = "0x1837EF4E0")]
	public void EEKFNAFJALE(int LGIEDJBGIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x31F9C10", Offset = "0x31F8410", VA = "0x1831F9C10")]
	private void MDKOBEAOKGA(int PODLECMNECF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class NFDPGKCDBGA
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F22140", Offset = "0x1F20940", VA = "0x181F22140")]
	public static global::IINBIHFGFAM<T> PKKPJKMPPCP<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x161AB10", Offset = "0x1619310", VA = "0x18161AB10")]
	public static global::IINBIHFGFAM<T> ACEKLPJHEDE<T>(int PODLECMNECF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DefaultMember("Item")]
public class LPCKKDDLEGD<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<TKey, TVal> FKCMGMPKAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<TVal, TKey> ICFHHJEDNIG;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int MKFJBHDFMPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1C0DBD0", Offset = "0x1C0C3D0", VA = "0x181C0DBD0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool OOALHAMOCCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x521EC0", Offset = "0x5206C0", VA = "0x180521EC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICollection<TKey> NEBCCOFIBMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x26A7CF0", Offset = "0x26A64F0", VA = "0x1826A7CF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TVal> DGKMJADMADF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2117C70", Offset = "0x2116470", VA = "0x182117C70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TVal EDFJNANCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x26A7CC0", Offset = "0x26A64C0", VA = "0x1826A7CC0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x26A7D20", Offset = "0x26A6520", VA = "0x1826A7D20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TKey EDFJNANCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x26A7970", Offset = "0x26A6170", VA = "0x1826A7970")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x26A7010", Offset = "0x26A5810", VA = "0x1826A7010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x26A7050", Offset = "0x26A5850", VA = "0x1826A7050", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x26A7B90", Offset = "0x26A6390", VA = "0x1826A7B90", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x26A6F40", Offset = "0x26A5740", VA = "0x1826A6F40", Slot = "9")]
	public void Add(TKey MHAAPGJKGCK, TVal DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x26A6FA0", Offset = "0x26A57A0", VA = "0x1826A6FA0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> HBCHABBOMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x26A70B0", Offset = "0x26A58B0", VA = "0x1826A70B0", Slot = "8")]
	public bool ContainsKey(TKey MHAAPGJKGCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1C042F0", Offset = "0x1C02AF0", VA = "0x181C042F0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> HBCHABBOMEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x26A7B10", Offset = "0x26A6310", VA = "0x1826A7B10", Slot = "10")]
	public bool Remove(TKey MHAAPGJKGCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x26A7B10", Offset = "0x26A6310", VA = "0x1826A7B10", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> HBCHABBOMEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2120D20", Offset = "0x211F520", VA = "0x182120D20", Slot = "11")]
	public bool TryGetValue(TKey MHAAPGJKGCK, out TVal DOBKOKNNFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x26A7700", Offset = "0x26A5F00", VA = "0x1826A7700", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x26A7110", Offset = "0x26A5910", VA = "0x1826A7110", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] GGAIBHJOFBE, int COCCJJHDKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x26A71F0", Offset = "0x26A59F0", VA = "0x1826A71F0")]
	public void EFDMEADFFJF(TVal OCHDAFFGFED, TKey MHAAPGJKGCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x26A71B0", Offset = "0x26A59B0", VA = "0x1826A71B0")]
	public void EFDMEADFFJF(KeyValuePair<TVal, TKey> HBCHABBOMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x26A7560", Offset = "0x26A5D60", VA = "0x1826A7560")]
	public bool FFIBFKMNELM(TVal MHAAPGJKGCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x26A76A0", Offset = "0x26A5EA0", VA = "0x1826A76A0")]
	public bool GNDANEOMOEO(KeyValuePair<TVal, TKey> HBCHABBOMEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x26A7800", Offset = "0x26A6000", VA = "0x1826A7800")]
	public bool HICPDAONBIK(TVal MHAAPGJKGCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x26A7800", Offset = "0x26A6000", VA = "0x1826A7800")]
	public bool HICPDAONBIK(KeyValuePair<TVal, TKey> HBCHABBOMEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x26A79A0", Offset = "0x26A61A0", VA = "0x1826A79A0")]
	public bool NFIDKFMHPHL(TVal MHAAPGJKGCK, out TKey DOBKOKNNFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x26A7620", Offset = "0x26A5E20", VA = "0x1826A7620")]
	public IEnumerator<KeyValuePair<TVal, TKey>> FIEPEGFAJFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x26A79D0", Offset = "0x26A61D0", VA = "0x1826A79D0")]
	private void NHGLPDICBGL(TKey MHAAPGJKGCK, TVal OCHDAFFGFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x26A78F0", Offset = "0x26A60F0", VA = "0x1826A78F0")]
	private void HPBMCEPJOHK(TKey MHAAPGJKGCK, TVal OCHDAFFGFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x26A7320", Offset = "0x26A5B20", VA = "0x1826A7320")]
	private bool ENOIEEAECFC(TKey MHAAPGJKGCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x26A7260", Offset = "0x26A5A60", VA = "0x1826A7260")]
	private bool ENOIEEAECFC(TVal OCHDAFFGFED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x26A7BE0", Offset = "0x26A63E0", VA = "0x1826A7BE0")]
	public LPCKKDDLEGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class AAKALAJMBHF<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private global::AAKALAJMBHF<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xF16780", Offset = "0xF14F80", VA = "0x180F16780", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x3D43800", Offset = "0x3D42000", VA = "0x183D43800", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3D43D60", Offset = "0x3D42560", VA = "0x183D43D60")]
		public Enumerator(global::AAKALAJMBHF<T> FFBNFFLLBIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D43460", Offset = "0x3D41C60", VA = "0x183D43460", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3D436C0", Offset = "0x3D41EC0", VA = "0x183D436C0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3D43160", Offset = "0x3D41960", VA = "0x183D43160")]
		private void MIJMKALLDLA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private T[] HMCECDOOLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int LFFIOCBDPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private int IHJLAPKMKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int MNLJLEDEGGI;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int MKFJBHDFMPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3D38E30", Offset = "0x3D37630", VA = "0x183D38E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public T EDFJNANCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3D38D50", Offset = "0x3D37550", VA = "0x183D38D50")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3D37150", Offset = "0x3D35950", VA = "0x183D37150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3D39060", Offset = "0x3D37860", VA = "0x183D39060")]
	public AAKALAJMBHF(int PODLECMNECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3D37670", Offset = "0x3D35E70", VA = "0x183D37670")]
	public void EFDMEADFFJF(T PKNCKFNLBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3D37F40", Offset = "0x3D36740", VA = "0x183D37F40")]
	public void EOJKJNMCLDG(IEnumerable<T> HDIJCKHHGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3D37590", Offset = "0x3D35D90", VA = "0x183D37590")]
	public void DKOADGNIPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3D38BF0", Offset = "0x3D373F0", VA = "0x183D38BF0")]
	public void KFFEANJAGAJ(int KALABHLPPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3D38B60", Offset = "0x3D37360", VA = "0x183D38B60")]
	public void IHCNHOGBODJ(int KALABHLPPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3D37A00", Offset = "0x3D36200", VA = "0x183D37A00")]
	public void EJPBKHDAECL(T[] GGAIBHJOFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3D378A0", Offset = "0x3D360A0", VA = "0x183D378A0")]
	public Enumerator EIFBDBIKCMD()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3D38F10", Offset = "0x3D37710", VA = "0x183D38F10", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3D38F10", Offset = "0x3D37710", VA = "0x183D38F10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3D374A0", Offset = "0x3D35CA0", VA = "0x183D374A0")]
	private int DDABGGBIJDG(int MPFAEFMOAIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3D38E00", Offset = "0x3D37600", VA = "0x183D38E00")]
	private int MLIIKILMGEO(int MPFAEFMOAIE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class KBGIONFCNPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void PBKAFGMLKML(object[] GDMHKIKJBHH);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	protected KBGIONFCNPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class EOGOLBMHBCH<T> : KBGIONFCNPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	protected struct DHPHFPJMNDA
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public enum PLFKKODGACF
		{
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public PLFKKODGACF MIDEMNGPEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public T BOJLOMGNIOM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int LLDNHAHNHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly bool LCMDEEGNEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	protected readonly bool FFJLIDKIOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	protected List<T> FMBPMIDHNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<DHPHFPJMNDA> EFJAJKHNNCJ;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool JGHILEEJCBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x38D63C0", Offset = "0x38D4BC0", VA = "0x1838D63C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x38D6A10", Offset = "0x38D5210", VA = "0x1838D6A10")]
	protected EOGOLBMHBCH(bool FFJLIDKIOHE, bool LCMDEEGNEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x38D6970", Offset = "0x38D5170", VA = "0x1838D6970")]
	protected bool JKADCPOCLFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x38D6730", Offset = "0x38D4F30", VA = "0x1838D6730")]
	protected void GAKJPGMPJNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x38D6580", Offset = "0x38D4D80", VA = "0x1838D6580")]
	protected void FABNNJGINLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x27ACA60", Offset = "0x27AB260", VA = "0x1827ACA60")]
	private static void MKKOMCIGOAO<U>(ref List<U> EIEGEJMBDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x38D6400", Offset = "0x38D4C00", VA = "0x1838D6400", Slot = "5")]
	public void EFDMEADFFJF(T BOJLOMGNIOM, bool DEEDLJOGOBI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x38D6810", Offset = "0x38D5010", VA = "0x1838D6810", Slot = "6")]
	public void HICPDAONBIK(T BOJLOMGNIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x38D6290", Offset = "0x38D4A90", VA = "0x1838D6290")]
	public void DKOADGNIPCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface LKOMHFGGFNE
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EFDMEADFFJF(Action BOJLOMGNIOM, bool DEEDLJOGOBI = false);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HICPDAONBIK(Action BOJLOMGNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class AIPMLCOLGIN : global::EOGOLBMHBCH<Action>, LKOMHFGGFNE
{
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4A848E0", Offset = "0x4A830E0", VA = "0x184A848E0")]
	public AIPMLCOLGIN(bool FFJLIDKIOHE = false, bool LCMDEEGNEOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4A84640", Offset = "0x4A82E40", VA = "0x184A84640")]
	public void KKEJFKCOKHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4A84860", Offset = "0x4A83060", VA = "0x184A84860", Slot = "4")]
	public override void PBKAFGMLKML(object[] GDMHKIKJBHH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4A845E0", Offset = "0x4A82DE0", VA = "0x184A845E0")]
	public static AIPMLCOLGIN GFNNOFBKLGG(AIPMLCOLGIN FKMMJHAONKA, Action BOJLOMGNIOM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4A84800", Offset = "0x4A83000", VA = "0x184A84800")]
	public static AIPMLCOLGIN LDMDGADKNOP(AIPMLCOLGIN FKMMJHAONKA, Action BOJLOMGNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface FHMLCKGPNFN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EFDMEADFFJF(Action<T> BOJLOMGNIOM, bool DEEDLJOGOBI = false);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HICPDAONBIK(Action<T> BOJLOMGNIOM);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class CKAAIOEAKMB<T> : global::EOGOLBMHBCH<Action<T>>, global::FHMLCKGPNFN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1C04C30", Offset = "0x1C03430", VA = "0x181C04C30")]
	public CKAAIOEAKMB(bool FFJLIDKIOHE = false, bool LCMDEEGNEOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x1E74910", Offset = "0x1E73110", VA = "0x181E74910")]
	public void KKEJFKCOKHL(T PKNCKFNLBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x1E74D50", Offset = "0x1E73550", VA = "0x181E74D50", Slot = "4")]
	public override void PBKAFGMLKML(object[] GDMHKIKJBHH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1E71290", Offset = "0x1E6FA90", VA = "0x181E71290")]
	public static global::CKAAIOEAKMB<T> GFNNOFBKLGG(global::CKAAIOEAKMB<T> FKMMJHAONKA, Action<T> BOJLOMGNIOM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1E74B50", Offset = "0x1E73350", VA = "0x181E74B50")]
	public static global::CKAAIOEAKMB<T> LDMDGADKNOP(global::CKAAIOEAKMB<T> FKMMJHAONKA, Action<T> BOJLOMGNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface AOEEECGJNMN<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EFDMEADFFJF(Action<T, U> BOJLOMGNIOM, bool DEEDLJOGOBI = false);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HICPDAONBIK(Action<T, U> BOJLOMGNIOM);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class PJEANGOAMBK<T, U> : global::EOGOLBMHBCH<Action<T, U>>, global::AOEEECGJNMN<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1C04C30", Offset = "0x1C03430", VA = "0x181C04C30")]
	public PJEANGOAMBK(bool FFJLIDKIOHE = false, bool LCMDEEGNEOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3B4EC20", Offset = "0x3B4D420", VA = "0x183B4EC20")]
	public void KKEJFKCOKHL(T PKNCKFNLBFL, U DMCOPCLNNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3B51190", Offset = "0x3B4F990", VA = "0x183B51190", Slot = "4")]
	public override void PBKAFGMLKML(object[] GDMHKIKJBHH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3B4CEE0", Offset = "0x3B4B6E0", VA = "0x183B4CEE0")]
	public static global::PJEANGOAMBK<T, U> GFNNOFBKLGG(global::PJEANGOAMBK<T, U> FKMMJHAONKA, Action<T, U> BOJLOMGNIOM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3B508D0", Offset = "0x3B4F0D0", VA = "0x183B508D0")]
	public static global::PJEANGOAMBK<T, U> LDMDGADKNOP(global::PJEANGOAMBK<T, U> FKMMJHAONKA, Action<T, U> BOJLOMGNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface FIBEIKJEPBL<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EFDMEADFFJF(Action<T, U, V> BOJLOMGNIOM, bool DEEDLJOGOBI = false);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HICPDAONBIK(Action<T, U, V> BOJLOMGNIOM);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class OMEKKFGJBNA<T, U, V> : global::EOGOLBMHBCH<Action<T, U, V>>, global::FIBEIKJEPBL<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1C04C30", Offset = "0x1C03430", VA = "0x181C04C30")]
	public OMEKKFGJBNA(bool FFJLIDKIOHE = false, bool LCMDEEGNEOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3917030", Offset = "0x3915830", VA = "0x183917030")]
	public void KKEJFKCOKHL(T PKNCKFNLBFL, U DMCOPCLNNEC, V PNNIPMMOJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3919390", Offset = "0x3917B90", VA = "0x183919390", Slot = "4")]
	public override void PBKAFGMLKML(object[] GDMHKIKJBHH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3916F90", Offset = "0x3915790", VA = "0x183916F90")]
	public static global::OMEKKFGJBNA<T, U, V> GFNNOFBKLGG(global::OMEKKFGJBNA<T, U, V> FKMMJHAONKA, Action<T, U, V> BOJLOMGNIOM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3918CF0", Offset = "0x39174F0", VA = "0x183918CF0")]
	public static global::OMEKKFGJBNA<T, U, V> LDMDGADKNOP(global::OMEKKFGJBNA<T, U, V> FKMMJHAONKA, Action<T, U, V> BOJLOMGNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface IPAIDMNOAEO<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EFDMEADFFJF(Action<T, U, V, W> BOJLOMGNIOM, bool DEEDLJOGOBI = false);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HICPDAONBIK(Action<T, U, V, W> BOJLOMGNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class JKMLMKHJPEH<T, U, V, W> : global::EOGOLBMHBCH<Action<T, U, V, W>>, global::IPAIDMNOAEO<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1C04C30", Offset = "0x1C03430", VA = "0x181C04C30")]
	public JKMLMKHJPEH(bool FFJLIDKIOHE = false, bool LCMDEEGNEOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2EA8FD0", Offset = "0x2EA77D0", VA = "0x182EA8FD0")]
	public void KKEJFKCOKHL(T PKNCKFNLBFL, U DMCOPCLNNEC, V PNNIPMMOJMD, W IHDEFGBHAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2EAA8A0", Offset = "0x2EA90A0", VA = "0x182EAA8A0", Slot = "4")]
	public override void PBKAFGMLKML(object[] GDMHKIKJBHH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2EA8CA0", Offset = "0x2EA74A0", VA = "0x182EA8CA0")]
	public static global::JKMLMKHJPEH<T, U, V, W> GFNNOFBKLGG(global::JKMLMKHJPEH<T, U, V, W> FKMMJHAONKA, Action<T, U, V, W> BOJLOMGNIOM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2EAA800", Offset = "0x2EA9000", VA = "0x182EAA800")]
	public static global::JKMLMKHJPEH<T, U, V, W> LDMDGADKNOP(global::JKMLMKHJPEH<T, U, V, W> FKMMJHAONKA, Action<T, U, V, W> BOJLOMGNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface HCOIBEIENJB<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EFDMEADFFJF(Action<T, U, V, W, X> BOJLOMGNIOM, bool DEEDLJOGOBI = false);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HICPDAONBIK(Action<T, U, V, W, X> BOJLOMGNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class FKGNGBKMDJN<T, U, V, W, X> : global::EOGOLBMHBCH<Action<T, U, V, W, X>>, global::HCOIBEIENJB<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1C04C30", Offset = "0x1C03430", VA = "0x181C04C30")]
	public FKGNGBKMDJN(bool FFJLIDKIOHE = false, bool LCMDEEGNEOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2119180", Offset = "0x2117980", VA = "0x182119180")]
	public void KKEJFKCOKHL(T PKNCKFNLBFL, U DMCOPCLNNEC, V PNNIPMMOJMD, W IHDEFGBHAOB, X DNCFOPMJGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x21194C0", Offset = "0x2117CC0", VA = "0x1821194C0", Slot = "4")]
	public override void PBKAFGMLKML(object[] GDMHKIKJBHH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2118DD0", Offset = "0x21175D0", VA = "0x182118DD0")]
	public static global::FKGNGBKMDJN<T, U, V, W, X> GFNNOFBKLGG(global::FKGNGBKMDJN<T, U, V, W, X> FKMMJHAONKA, Action<T, U, V, W, X> BOJLOMGNIOM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2119420", Offset = "0x2117C20", VA = "0x182119420")]
	public static global::FKGNGBKMDJN<T, U, V, W, X> LDMDGADKNOP(global::FKGNGBKMDJN<T, U, V, W, X> FKMMJHAONKA, Action<T, U, V, W, X> BOJLOMGNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface ALAELBGFAKM<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EFDMEADFFJF(Action<T, U, V, W, X, Y> BOJLOMGNIOM, bool DEEDLJOGOBI = false);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HICPDAONBIK(Action<T, U, V, W, X, Y> BOJLOMGNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class NJOCHNLFPFL<T, U, V, W, X, Y> : global::EOGOLBMHBCH<Action<T, U, V, W, X, Y>>, global::ALAELBGFAKM<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x1C04C30", Offset = "0x1C03430", VA = "0x181C04C30")]
	public NJOCHNLFPFL(bool FFJLIDKIOHE = false, bool LCMDEEGNEOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3688E60", Offset = "0x3687660", VA = "0x183688E60")]
	public void KKEJFKCOKHL(T PKNCKFNLBFL, U DMCOPCLNNEC, V PNNIPMMOJMD, W IHDEFGBHAOB, X DNCFOPMJGLJ, Y DEMCFCBJOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3689560", Offset = "0x3687D60", VA = "0x183689560", Slot = "4")]
	public override void PBKAFGMLKML(object[] GDMHKIKJBHH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3688B00", Offset = "0x3687300", VA = "0x183688B00")]
	public static global::NJOCHNLFPFL<T, U, V, W, X, Y> GFNNOFBKLGG(global::NJOCHNLFPFL<T, U, V, W, X, Y> FKMMJHAONKA, Action<T, U, V, W, X, Y> BOJLOMGNIOM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3689170", Offset = "0x3687970", VA = "0x183689170")]
	public static global::NJOCHNLFPFL<T, U, V, W, X, Y> LDMDGADKNOP(global::NJOCHNLFPFL<T, U, V, W, X, Y> FKMMJHAONKA, Action<T, U, V, W, X, Y> BOJLOMGNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class CPKAOBCLOKM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct BBGBLELINNH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly global::CPKAOBCLOKM<T> LOKFOAFJAPO;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public T MPJDHKAGMAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x1E6FA10", Offset = "0x1E6E210", VA = "0x181E6FA10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1E6F9E0", Offset = "0x1E6E1E0", VA = "0x181E6F9E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x662130", Offset = "0x660930", VA = "0x180662130")]
		public BBGBLELINNH(global::CPKAOBCLOKM<T> LOKFOAFJAPO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct OFKJGHCBHPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder<BBGBLELINNH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public global::CPKAOBCLOKM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1E7C680", Offset = "0x1E7AE80", VA = "0x181E7C680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1E7A960", Offset = "0x1E79160", VA = "0x181E7A960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct EMMAOBDGDOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<BBGBLELINNH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public global::CPKAOBCLOKM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1E7A5C0", Offset = "0x1E78DC0", VA = "0x181E7A5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x1E7A960", Offset = "0x1E79160", VA = "0x181E7A960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly SemaphoreSlim FENKIIGBBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private T KCMKAFIAKEP;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int LJNPLLABJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1E7A1E0", Offset = "0x1E789E0", VA = "0x181E7A1E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x1E7A350", Offset = "0x1E78B50", VA = "0x181E7A350")]
	public CPKAOBCLOKM(in T KCMKAFIAKEP, int NJMJENBMPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x1E7A320", Offset = "0x1E78B20", VA = "0x181E7A320")]
	public CPKAOBCLOKM(in T KCMKAFIAKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x1E7A200", Offset = "0x1E78A00", VA = "0x181E7A200")]
	public BBGBLELINNH PHEFDALNAKB()
	{
		return default(BBGBLELINNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x1E7A240", Offset = "0x1E78A40", VA = "0x181E7A240")]
	public BBGBLELINNH PHEFDALNAKB(CancellationToken MOIIDJBIJCG)
	{
		return default(BBGBLELINNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x1E79C20", Offset = "0x1E78420", VA = "0x181E79C20")]
	[AsyncStateMachine(typeof(global::CPKAOBCLOKM<>.OFKJGHCBHPI))]
	public Task<BBGBLELINNH> AKDBAIBEIIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x1E7A060", Offset = "0x1E78860", VA = "0x181E7A060")]
	[AsyncStateMachine(typeof(global::CPKAOBCLOKM<>.EMMAOBDGDOJ))]
	public Task<BBGBLELINNH> AKDBAIBEIIN(CancellationToken MOIIDJBIJCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class GFDOGFFHOEF
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x4A85210", Offset = "0x4A83A10", VA = "0x184A85210")]
	public static global::CPKAOBCLOKM<HBFEIGNGBEF> PKKPJKMPPCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x4A85270", Offset = "0x4A83A70", VA = "0x184A85270")]
	public static global::CPKAOBCLOKM<HBFEIGNGBEF> PKKPJKMPPCP(int NJMJENBMPAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x1988710", Offset = "0x1986F10", VA = "0x181988710")]
	public static global::CPKAOBCLOKM<T> PKKPJKMPPCP<T>(in T KCMKAFIAKEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x29CACE0", Offset = "0x29C94E0", VA = "0x1829CACE0")]
	public static global::CPKAOBCLOKM<T> PKKPJKMPPCP<T>(in T KCMKAFIAKEP, int NJMJENBMPAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class HJMGDOHHMIL<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate bool GEEFJCDLGAO(global::HJMGDOHHMIL<T> BNMBBMFILCA);

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class INEIIPMIAFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public global::HJMGDOHHMIL<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
		public INEIIPMIAFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3486160", Offset = "0x3484960", VA = "0x183486160")]
		internal bool <FindNode>b__0(global::HJMGDOHHMIL<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public T DFNPNGKLJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public LinkedList<global::HJMGDOHHMIL<T>> IIECFEEAOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public global::HJMGDOHHMIL<T> LIBHEMJCOIB;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public global::HJMGDOHHMIL<T> INIDEFLHEEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x574130", Offset = "0x572930", VA = "0x180574130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3480D90", Offset = "0x347F590", VA = "0x183480D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool HICPGFJPPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3481B90", Offset = "0x3480390", VA = "0x183481B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool CEKLGJELDND
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3483010", Offset = "0x3481810", VA = "0x183483010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public global::HJMGDOHHMIL<T> CNMJPCHFBBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3481BC0", Offset = "0x34803C0", VA = "0x183481BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3483300", Offset = "0x3481B00", VA = "0x183483300")]
	public HJMGDOHHMIL(T MHBINAOONDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3483050", Offset = "0x3481850", VA = "0x183483050")]
	public global::HJMGDOHHMIL<T> PAIMFNKPAOA(T JMMDMIFPPHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3482370", Offset = "0x3480B70", VA = "0x183482370")]
	public global::HJMGDOHHMIL<T> LLHDIDCNAPJ(T CGFEMMLJNJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3481CD0", Offset = "0x34804D0", VA = "0x183481CD0")]
	public global::HJMGDOHHMIL<T> HICPDAONBIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3481930", Offset = "0x3480130", VA = "0x183481930")]
	public void DKOADGNIPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3480F40", Offset = "0x347F740", VA = "0x183480F40")]
	public global::HJMGDOHHMIL<T> BFPJDFPHDPP(T GCGOKGDFKNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3481390", Offset = "0x347FB90", VA = "0x183481390")]
	public static void CPNOMCKMDGD(global::HJMGDOHHMIL<T> KHOILHBFIPP, GEEFJCDLGAO LEBFOKPPLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x27B0730", Offset = "0x27AEF30", VA = "0x1827B0730")]
	public static void CPNOMCKMDGD<A>(global::HJMGDOHHMIL<T> KHOILHBFIPP, Func<global::HJMGDOHHMIL<T>, A, bool> LEBFOKPPLDN, A EJNLPJMKJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3482540", Offset = "0x3480D40", VA = "0x183482540")]
	public static string MAGHAMMOJDF(global::HJMGDOHHMIL<T> KHOILHBFIPP, int LOBHBEGMMDM = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3481F90", Offset = "0x3480790", VA = "0x183481F90")]
	public static global::HJMGDOHHMIL<T> IJHIAMOPIOF(global::HJMGDOHHMIL<T> KHOILHBFIPP, T KHCCGHGFCJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class HFNNDBKNEDK<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public delegate Task<TResult> DEGLKGCEPCM(TRequest OLLHJMHJJAI, CancellationToken MOIIDJBIJCG);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum BNMNPMIBJKB
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class LNOJHKLPMKE
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private const float LIAIGNIANHE = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TimeSpan JDJGMMMEIFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int JGJBNACOJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public BNMNPMIBJKB JPIKDFLFHOM;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly LNOJHKLPMKE LAADFIIMHNA;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float CLMJACGBDAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x3B925E0", Offset = "0x3B90DE0", VA = "0x183B925E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public TimeSpan OIHKBLOMJDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x5211D0", Offset = "0x51F9D0", VA = "0x1805211D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3B92810", Offset = "0x3B91010", VA = "0x183B92810")]
		public LNOJHKLPMKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private readonly struct IPLILNIEDPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly TRequest OLLHJMHJJAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly CancellationToken MOIIDJBIJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public readonly TaskCompletionSource<TResult> NBBLBIPNONI;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3B920F0", Offset = "0x3B908F0", VA = "0x183B920F0")]
		public IPLILNIEDPK(TRequest OLLHJMHJJAI, TaskCompletionSource<TResult> NBBLBIPNONI, CancellationToken MOIIDJBIJCG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class LANEDNGNPCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
		public LANEDNGNPCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x1C0DBD0", Offset = "0x1C0C3D0", VA = "0x181C0DBD0")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct NMPKDDOLAAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public global::HFNNDBKNEDK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3B9F850", Offset = "0x3B9E050", VA = "0x183B9F850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6B6A70", Offset = "0x6B5270", VA = "0x1806B6A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class CLDHHGOFICO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IPLILNIEDPK req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public global::HFNNDBKNEDK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
		public CLDHHGOFICO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3B8A800", Offset = "0x3B89000", VA = "0x183B8A800")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CancellationTokenSource DPKCCCIBNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly List<IPLILNIEDPK> OPBNAGEHICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly LNOJHKLPMKE CCIGBLHINIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly DEGLKGCEPCM KBDFAKAIJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Task GJOPFBCEJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private int FMIJNEPHCNA;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3B8F0A0", Offset = "0x3B8D8A0", VA = "0x183B8F0A0")]
	public HFNNDBKNEDK(DEGLKGCEPCM KBDFAKAIJHL, [Optional] LNOJHKLPMKE CCIGBLHINIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3B8E530", Offset = "0x3B8CD30", VA = "0x183B8E530")]
	public Task<TResult> IPMIJPFNGCP(TRequest OLLHJMHJJAI, CancellationToken MOIIDJBIJCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3B8DE90", Offset = "0x3B8C690", VA = "0x183B8DE90")]
	private void ACLJGFNFBLH(IPLILNIEDPK OPKLLDPOGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3B8E420", Offset = "0x3B8CC20", VA = "0x183B8E420")]
	[AsyncStateMachine(typeof(global::HFNNDBKNEDK<, >.NMPKDDOLAAB))]
	private Task GJHGIOPMGHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3B8EC90", Offset = "0x3B8D490", VA = "0x183B8EC90")]
	private IPLILNIEDPK MLMFIOBECJE()
	{
		return default(IPLILNIEDPK);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3B8DF20", Offset = "0x3B8C720", VA = "0x183B8DF20")]
	private void GAOAHJBOAFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x347A2D0", Offset = "0x3478AD0", VA = "0x18347A2D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[DefaultMember("Item")]
public class DCNNGAJCKFN<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public delegate int EONPIGOCNJG(TKey MHAAPGJKGCK, TVal DOBKOKNNFGA);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class FNBFMJDJEDH
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public TKey BNGGPGAGIBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x5211D0", Offset = "0x51F9D0", VA = "0x1805211D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public TVal MPJDHKAGMAD
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x64FBA0", Offset = "0x64E3A0", VA = "0x18064FBA0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x6B63B0", Offset = "0x6B4BB0", VA = "0x1806B63B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int NLOJDNDIBNE
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x673590", Offset = "0x671D90", VA = "0x180673590")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x6735C0", Offset = "0x671DC0", VA = "0x1806735C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public DateTime AJMLANBIHEL
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x523DF0", Offset = "0x5225F0", VA = "0x180523DF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x103B900", Offset = "0x103A100", VA = "0x18103B900")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3E16610", Offset = "0x3E14E10", VA = "0x183E16610")]
		public FNBFMJDJEDH(TKey MHAAPGJKGCK, TVal OCHDAFFGFED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public const int PKEMABEGJOE = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Dictionary<TKey, LinkedListNode<FNBFMJDJEDH>> HHKEGPFMLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly LinkedList<FNBFMJDJEDH> AJLOPDHPEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly EONPIGOCNJG LIIAMDNMJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly TimeSpan NCGANGBFNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly NPDEABGKKIO ICNAGJBLNPO;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int HBCKAAKJPNE
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x67C990", Offset = "0x67B190", VA = "0x18067C990")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private bool MDHBKNLLNIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3E13140", Offset = "0x3E11940", VA = "0x183E13140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	internal int PMHGEEKINJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x67C9A0", Offset = "0x67B1A0", VA = "0x18067C9A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6716B0", Offset = "0x66FEB0", VA = "0x1806716B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int MKFJBHDFMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x1C0CE90", Offset = "0x1C0B690", VA = "0x181C0CE90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IEnumerable<TKey> NEBCCOFIBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3E12C70", Offset = "0x3E11470", VA = "0x183E12C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public TVal EDFJNANCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x26A7800", Offset = "0x26A6000", VA = "0x1826A7800")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3E11C90", Offset = "0x3E10490", VA = "0x183E11C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3E138D0", Offset = "0x3E120D0", VA = "0x183E138D0")]
	public DCNNGAJCKFN(int PODLECMNECF, [Optional] EONPIGOCNJG LIIAMDNMJGL, [Optional] IEqualityComparer<TKey> GLFGBADGANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3E13880", Offset = "0x3E12080", VA = "0x183E13880")]
	public DCNNGAJCKFN(TimeSpan NCGANGBFNEI, [Optional] IEqualityComparer<TKey> GLFGBADGANB, [Optional] NPDEABGKKIO ICNAGJBLNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3E135E0", Offset = "0x3E11DE0", VA = "0x183E135E0")]
	public DCNNGAJCKFN(int PODLECMNECF, TimeSpan NCGANGBFNEI, [Optional] IEqualityComparer<TKey> GLFGBADGANB, [Optional] NPDEABGKKIO ICNAGJBLNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3E139A0", Offset = "0x3E121A0", VA = "0x183E139A0")]
	public DCNNGAJCKFN(int PODLECMNECF, EONPIGOCNJG LIIAMDNMJGL, TimeSpan NCGANGBFNEI, [Optional] IEqualityComparer<TKey> GLFGBADGANB, [Optional] NPDEABGKKIO ICNAGJBLNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3E125E0", Offset = "0x3E10DE0", VA = "0x183E125E0")]
	public void IBKOGCIOMPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3E122D0", Offset = "0x3E10AD0", VA = "0x183E122D0")]
	public void FCOKICFHMIC(TKey MHAAPGJKGCK, TVal DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x3E12450", Offset = "0x3E10C50", VA = "0x183E12450")]
	public bool HICPDAONBIK(TKey MHAAPGJKGCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3E11BD0", Offset = "0x3E103D0", VA = "0x183E11BD0")]
	private TVal ACAMCBFIHPP(TKey HBDBKGOFGLM)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3E12FE0", Offset = "0x3E117E0", VA = "0x183E12FE0")]
	public bool NFIDKFMHPHL(TKey HBDBKGOFGLM, out TVal DOBKOKNNFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3E11E40", Offset = "0x3E10640", VA = "0x183E11E40")]
	public void DKOADGNIPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3E11CC0", Offset = "0x3E104C0", VA = "0x183E11CC0")]
	private bool BECBCAOLKFL(FNBFMJDJEDH JFKKECACDCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3E129E0", Offset = "0x3E111E0", VA = "0x183E129E0")]
	private void IODHMLDPELK(LinkedListNode<FNBFMJDJEDH> LOGKBHDDLMB, TVal ANNHMLONOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3E11EC0", Offset = "0x3E106C0", VA = "0x183E11EC0")]
	private void EKPNDINILNN(TKey MHAAPGJKGCK, TVal DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3E131D0", Offset = "0x3E119D0", VA = "0x183E131D0")]
	private void PNLNLLMGPJC(FNBFMJDJEDH JFKKECACDCJ, TVal ANNHMLONOMD, int AAJCBPNFCIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class ENHCNAJHJBD<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly List<T> EIEGEJMBDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private HashSet<T> NLKELNAMDED;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int MKFJBHDFMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x1C0DBD0", Offset = "0x1C0C3D0", VA = "0x181C0DBD0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool OOALHAMOCCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x521EC0", Offset = "0x5206C0", VA = "0x180521EC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T EDFJNANCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x34041A0", Offset = "0x34029A0", VA = "0x1834041A0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x38CC760", Offset = "0x38CAF60", VA = "0x1838CC760", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2B19B50", Offset = "0x2B18350", VA = "0x182B19B50", Slot = "11")]
	public void Add(T HBCHABBOMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x38CC0E0", Offset = "0x38CA8E0", VA = "0x1838CC0E0")]
	public bool LOLGLADEDCA(T HBCHABBOMEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x38CC600", Offset = "0x38CAE00", VA = "0x1838CC600", Slot = "15")]
	public bool Remove(T HBCHABBOMEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2120C70", Offset = "0x211F470", VA = "0x182120C70", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x1B04760", Offset = "0x1B02F60", VA = "0x181B04760", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x38CBE90", Offset = "0x38CA690", VA = "0x1838CBE90", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x3400AB0", Offset = "0x33FF2B0", VA = "0x183400AB0", Slot = "13")]
	public bool Contains(T HBCHABBOMEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x38CBEF0", Offset = "0x38CA6F0", VA = "0x1838CBEF0", Slot = "14")]
	public void CopyTo(T[] GGAIBHJOFBE, int COCCJJHDKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x26A7CC0", Offset = "0x26A64C0", VA = "0x1826A7CC0", Slot = "6")]
	public int IndexOf(T HBCHABBOMEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x38CBF50", Offset = "0x38CA750", VA = "0x1838CBF50", Slot = "7")]
	public void Insert(int MPFAEFMOAIE, T HBCHABBOMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x38CC3D0", Offset = "0x38CABD0", VA = "0x1838CC3D0", Slot = "8")]
	public void RemoveAt(int MPFAEFMOAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x38CC300", Offset = "0x38CAB00", VA = "0x1838CC300")]
	public void OKHMNHIMJHH(Predicate<T> FECEJNMFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x38CBF20", Offset = "0x38CA720", VA = "0x1838CBF20")]
	public void FBKIMOKOBEL(Comparison<T> KHLEJGHPAJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x38CC680", Offset = "0x38CAE80", VA = "0x1838CC680")]
	public ENHCNAJHJBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class OJMMGMNNHGO
{
	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x4A87E90", Offset = "0x4A86690", VA = "0x184A87E90")]
	public static Vector3 KGONDLLGABI(this GameObject EMIOHDNKBKG, float KFFAPIBBCAM)
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
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x1D6C540", Offset = "0x1D6AD40", VA = "0x181D6C540")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4A8A000", Offset = "0x4A88800", VA = "0x184A8A000")]
		public SerializedGuid(in Guid PCPBEMIPBMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4A89D90", Offset = "0x4A88590", VA = "0x184A89D90")]
		public static SerializedGuid HKJLOCCECGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4A89B80", Offset = "0x4A88380", VA = "0x184A89B80")]
		public static SerializedGuid EHJABIFBIIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4A89E10", Offset = "0x4A88610", VA = "0x184A89E10")]
		public bool IKINKJPEMEP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4A89FD0", Offset = "0x4A887D0", VA = "0x184A89FD0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4A89F30", Offset = "0x4A88730", VA = "0x184A89F30", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4A89EA0", Offset = "0x4A886A0", VA = "0x184A89EA0")]
		public bool LIHCCHCJGIF(in Guid PCPBEMIPBMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4A89C00", Offset = "0x4A88400", VA = "0x184A89C00", Slot = "7")]
		public bool Equals(SerializedGuid DKNLIFHKLLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4A89CA0", Offset = "0x4A884A0", VA = "0x184A89CA0", Slot = "0")]
		public override bool Equals(object HDKLJDMDCGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4A89D80", Offset = "0x4A88580", VA = "0x184A89D80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4A89B50", Offset = "0x4A88350", VA = "0x184A89B50", Slot = "6")]
		public int CompareTo(SerializedGuid DKNLIFHKLLN)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class CDKOIGJCAOK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Type IEFMHMCJKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly string MDAJFIAMKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly bool JKPPHOFPCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly bool MOHBGOGKCIL;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x4A84D90", Offset = "0x4A83590", VA = "0x184A84D90")]
	public CDKOIGJCAOK(Type EOBEKIGJKJD, string DCIPBFEKCAP, bool IBFHEIEPJMD = false, bool NNFIAONJLJO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface IDAPLEJPGPM
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface HJCFILPFCEK<T> : IDAPLEJPGPM
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	T MPJDHKAGMAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	bool LHFDHDBCIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string NINIGJIMLNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::HJCFILPFCEK<T> PFPDMBOGDED(Action<T> JGAHGBBGEIB);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::HJCFILPFCEK<T> KPECOFNIBHN(Action<T> JGAHGBBGEIB);

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::HJCFILPFCEK<T> OJDPHHLJPCB(Action<T, T> BBJKFKLNFIB);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::HJCFILPFCEK<T> IIJPMILFELK(Action<T, T> BBJKFKLNFIB);

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::HJCFILPFCEK<T> CHAHHPLCINJ(Action<string> HMOCNJGFACG);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::HJCFILPFCEK<T> IJOPGOPKJJK(Action<string> HMOCNJGFACG);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class IFNHOMLOIAC<T> : global::HJCFILPFCEK<T>, IDAPLEJPGPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private global::PJEANGOAMBK<T, T> HKLEKCHEPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private global::CKAAIOEAKMB<T> IKGADNDKDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private global::CKAAIOEAKMB<string> EGEEABDDHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private string CFMOADFJIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private T IAGHMNJKEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private bool KMIKBAGJEHM;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public T MPJDHKAGMAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x549A30", Offset = "0x548230", VA = "0x180549A30", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x22C37D0", Offset = "0x22C1FD0", VA = "0x1822C37D0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool LHFDHDBCIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x5A38B0", Offset = "0x5A20B0", VA = "0x1805A38B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string NINIGJIMLNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x54A0C0", Offset = "0x5488C0", VA = "0x18054A0C0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2669B30", Offset = "0x2668330", VA = "0x182669B30", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x39F9DA0", Offset = "0x39F85A0", VA = "0x1839F9DA0")]
	private void CPFMDOLCCGC(T HIDBDGNHHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x39FA000", Offset = "0x39F8800", VA = "0x1839FA000")]
	private void OGILLIOAEEC(string AGOJMOHICBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x39F9E40", Offset = "0x39F8640", VA = "0x1839F9E40")]
	public void HJODMEDLLNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x39FA0A0", Offset = "0x39F88A0", VA = "0x1839FA0A0", Slot = "6")]
	public global::HJCFILPFCEK<T> OJDPHHLJPCB(Action<T, T> BBJKFKLNFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x39F9EF0", Offset = "0x39F86F0", VA = "0x1839F9EF0", Slot = "7")]
	public global::HJCFILPFCEK<T> IIJPMILFELK(Action<T, T> BBJKFKLNFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x39FA0F0", Offset = "0x39F88F0", VA = "0x1839FA0F0", Slot = "4")]
	public global::HJCFILPFCEK<T> PFPDMBOGDED(Action<T> BBJKFKLNFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x39F9FB0", Offset = "0x39F87B0", VA = "0x1839F9FB0", Slot = "5")]
	public global::HJCFILPFCEK<T> KPECOFNIBHN(Action<T> JGAHGBBGEIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x39F9D10", Offset = "0x39F8510", VA = "0x1839F9D10", Slot = "8")]
	public global::HJCFILPFCEK<T> CHAHHPLCINJ(Action<string> HMOCNJGFACG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x39F9F40", Offset = "0x39F8740", VA = "0x1839F9F40", Slot = "9")]
	public global::HJCFILPFCEK<T> IJOPGOPKJJK(Action<string> HMOCNJGFACG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x39FA180", Offset = "0x39F8980", VA = "0x1839FA180")]
	public IFNHOMLOIAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class KHHAOJNJNLF
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class EEILMOHKGOB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public global::HJCFILPFCEK<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public global::IFPNNBFIADD<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
		public EEILMOHKGOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F740", Offset = "0x2B0DF40", VA = "0x182B0F740")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1CDD850", Offset = "0x1CDC050", VA = "0x181CDD850")]
	public static global::HBEENCCJBCB<T> CONEJLBHBKC<T>(this global::HJCFILPFCEK<T> MHOCLHDKJJM, Action<T> MKGMOFPDGOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public abstract class NPDEABGKKIO
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class ACIKHEPGMGJ : NPDEABGKKIO
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static NPDEABGKKIO IPNCHOCFJCD
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x4A84480", Offset = "0x4A82C80", VA = "0x184A84480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override DateTime NBIADMMECNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x4A84430", Offset = "0x4A82C30", VA = "0x184A84430", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override float BHCHPDOKCDD
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x4A7E380", Offset = "0x4A7CB80", VA = "0x184A7E380", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4A84580", Offset = "0x4A82D80", VA = "0x184A84580")]
		public ACIKHEPGMGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static NPDEABGKKIO COKMMNAJIAC;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static NPDEABGKKIO LAADFIIMHNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4A87960", Offset = "0x4A86160", VA = "0x184A87960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public abstract DateTime NBIADMMECNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public abstract float BHCHPDOKCDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	protected NPDEABGKKIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class DIMOFJEEGEA : global::KDCKIHLBJAA<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4A85110", Offset = "0x4A83910", VA = "0x184A85110")]
	public DIMOFJEEGEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class KDCKIHLBJAA<T> : global::PLJOFEOPGOB<T>, POIAFJFENFJ, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public Task<T> JKMFILEEBJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5211D0", Offset = "0x51F9D0", VA = "0x1805211D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private Task AACGMGLJAKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x1AF98B0", Offset = "0x1AF80B0", VA = "0x181AF98B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public global::HBEENCCJBCB<T> HADJPFHLKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private CDJPJKPGHKC MOKDOJDMCBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x1B03640", Offset = "0x1B01E40", VA = "0x181B03640", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2B16240", Offset = "0x2B14A40", VA = "0x182B16240")]
	public KDCKIHLBJAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class KKOBJEFINIG : global::GAHCLHKJPOI<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4A861F0", Offset = "0x4A849F0", VA = "0x184A861F0")]
	public KKOBJEFINIG(Exception NAAPPGENNFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class GAHCLHKJPOI<T> : global::PLJOFEOPGOB<T>, POIAFJFENFJ, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public Task<T> JKMFILEEBJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5211D0", Offset = "0x51F9D0", VA = "0x1805211D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	private Task AACGMGLJAKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x1AF98B0", Offset = "0x1AF80B0", VA = "0x181AF98B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public global::HBEENCCJBCB<T> HADJPFHLKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private CDJPJKPGHKC MOKDOJDMCBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x1B03640", Offset = "0x1B01E40", VA = "0x181B03640", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x21215E0", Offset = "0x211FDE0", VA = "0x1821215E0")]
	public GAHCLHKJPOI(Exception NAAPPGENNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface POIAFJFENFJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	Task JKMFILEEBJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	[NotNull]
	CDJPJKPGHKC HADJPFHLKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface PLJOFEOPGOB<T> : POIAFJFENFJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[NotNull]
	new Task<T> JKMFILEEBJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[NotNull]
	new global::HBEENCCJBCB<T> HADJPFHLKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public abstract class NBLHJBFGGMH<TTask, T> : global::PLJOFEOPGOB<T>, POIAFJFENFJ, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class JIIENPJOJMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public global::NBLHJBFGGMH<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
		public JIIENPJOJMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static bool PEANCGPIBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly Task<T> CACAAGBMCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	protected readonly CancellationTokenSource HAHKKKNBINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private bool NCNAFNHDFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private SynchronizationContext OCPAADOBECO;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Task<T> JKMFILEEBJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5211D0", Offset = "0x51F9D0", VA = "0x1805211D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Task AACGMGLJAKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x5211D0", Offset = "0x51F9D0", VA = "0x1805211D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public global::HBEENCCJBCB<T> HADJPFHLKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private CDJPJKPGHKC MOKDOJDMCBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1AFC610", Offset = "0x1AFAE10", VA = "0x181AFC610", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool ALABMJEGNFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x5A2990", Offset = "0x5A1190", VA = "0x1805A2990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x437B0C0", Offset = "0x43798C0", VA = "0x18437B0C0")]
	static NBLHJBFGGMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x437B3A0", Offset = "0x4379BA0", VA = "0x18437B3A0")]
	protected NBLHJBFGGMH(TTask CACAAGBMCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x437AF80", Offset = "0x4379780", VA = "0x18437AF80", Slot = "1")]
	~NBLHJBFGGMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3EF58A0", Offset = "0x3EF40A0", VA = "0x183EF58A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x437AE10", Offset = "0x4379610", VA = "0x18437AE10")]
	private void BMLOFNJHHAA(bool BDOPAGIGNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T PPJAMCOPAKP(TTask MHIAHMCNMAM);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void JCKEKHBCGPB();

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x437AC50", Offset = "0x4379450", VA = "0x18437AC50")]
	[CompilerGenerated]
	private void BBBAFDLLEFN(object BBMLHLLDABG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class GFHKLMHPPLH : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly Type IEFMHMCJKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly string MDAJFIAMKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly bool JKPPHOFPCGH;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4A852E0", Offset = "0x4A83AE0", VA = "0x184A852E0")]
	public GFHKLMHPPLH(Type EOBEKIGJKJD, string DCIPBFEKCAP, bool IBFHEIEPJMD = false)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x521ED0", Offset = "0x5206D0", VA = "0x180521ED0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x545710", Offset = "0x543F10", VA = "0x180545710")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public T this[int DBEFKGHKNPJ, int BMDEJOONDEG]
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x1E92130", Offset = "0x1E90930", VA = "0x181E92130")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x1E921D0", Offset = "0x1E909D0", VA = "0x181E921D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1E920A0", Offset = "0x1E908A0", VA = "0x181E920A0")]
		public Array2D(uint JBENCIOJCIN, uint DHDPHMHHLFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x1E92020", Offset = "0x1E90820", VA = "0x181E92020")]
		public void DKOADGNIPCC()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x4A84C90", Offset = "0x4A83490", VA = "0x184A84C90")]
		public Array2DVector3(uint JBENCIOJCIN, uint DHDPHMHHLFN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal static class CJIDLDMOAAD
{
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const int MLNLMCFJJHI = -1;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const int ELHKANLMANO = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[DefaultMember("Item")]
public class HKDIGCDDGGD<THandle, TValue> : IDisposable where THandle : struct, ACBJOINGLIO where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly List<THandle> KNADCANBAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly List<TValue> BHDDAABDKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly Func<TValue> GGABHNLLMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly Action<TValue> GFMIDLOBCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private int ONFMGCHOKOH;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public TValue EDFJNANCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x26A7800", Offset = "0x26A6000", VA = "0x1826A7800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x3483F50", Offset = "0x3482750", VA = "0x183483F50")]
	public HKDIGCDDGGD(Action<TValue> GFMIDLOBCFG, [Optional] Func<TValue> GGABHNLLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x3483570", Offset = "0x3481D70", VA = "0x183483570", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x3483D20", Offset = "0x3482520", VA = "0x183483D20")]
	public THandle OGMFEGPOBPM()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x3483710", Offset = "0x3481F10", VA = "0x183483710")]
	public THandle EFDMEADFFJF(TValue DOBKOKNNFGA)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x3483A60", Offset = "0x3482260", VA = "0x183483A60")]
	public bool HICPDAONBIK(THandle OGBIEODJMBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x3483850", Offset = "0x3482050", VA = "0x183483850")]
	public bool EPMMOGIHKBP(THandle OGBIEODJMBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x34839C0", Offset = "0x34821C0", VA = "0x1834839C0")]
	public bool HHNLKFFHOIA(THandle OGBIEODJMBL, out TValue DOBKOKNNFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x34833B0", Offset = "0x3481BB0", VA = "0x1834833B0")]
	public TValue ACAMCBFIHPP(THandle OGBIEODJMBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x3483E60", Offset = "0x3482660", VA = "0x183483E60")]
	public bool PHBAEBBBFLI(THandle OGBIEODJMBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3483540", Offset = "0x3481D40", VA = "0x183483540")]
	private THandle DBFHIAKGFPJ(int MPFAEFMOAIE)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x34834D0", Offset = "0x3481CD0", VA = "0x1834834D0")]
	private TValue CONEJLBHBKC(int MPFAEFMOAIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x3483F10", Offset = "0x3482710", VA = "0x183483F10")]
	private void PMBGKCMLLOJ(int MPFAEFMOAIE, in THandle OGBIEODJMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x3483500", Offset = "0x3481D00", VA = "0x183483500")]
	private void CPFMDOLCCGC(int MPFAEFMOAIE, in TValue DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x3483B10", Offset = "0x3482310", VA = "0x183483B10")]
	private THandle JHFIJDHLLDK()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x3483410", Offset = "0x3481C10", VA = "0x183483410")]
	private void CCMOBEJKJJF(THandle OGBIEODJMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x34839B0", Offset = "0x34821B0", VA = "0x1834839B0")]
	private int HFGHKPMDNHO(int MNLJLEDEGGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x3483400", Offset = "0x3481C00", VA = "0x183483400")]
	private bool BHBAAEPBFHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5729A0", Offset = "0x5711A0", VA = "0x1805729A0")]
	private void BKDAFHHEDFC(THandle OGBIEODJMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x3483930", Offset = "0x3482130", VA = "0x183483930")]
	private bool GBFBCFIFHHA(out THandle OGBIEODJMBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x3483780", Offset = "0x3481F80", VA = "0x183483780")]
	private bool EIHHABDCKJP(out THandle OGBIEODJMBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x3483C20", Offset = "0x3482420", VA = "0x183483C20")]
	private void NMHDFDKGEBD(THandle OGBIEODJMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x34835F0", Offset = "0x3481DF0", VA = "0x1834835F0")]
	private void EEAEHALAIOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface ACBJOINGLIO
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int ICFFKCCKJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	int FPBDGOECKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface PHHIIDHHBDI<T> : ACBJOINGLIO, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class FEHKPGJILAP
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x1F15680", Offset = "0x1F13E80", VA = "0x181F15680")]
	public static bool IKPFFJMEBHL<T>(this T OGBIEODJMBL) where T : struct, ACBJOINGLIO
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class IIEKJECLBAN
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private enum ABAJMFCKFNP : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private int DPHKJINOCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool OICOMCKGGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private ABAJMFCKFNP KMMEHLGHJPG;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool PCPIMEGKCPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x4A859A0", Offset = "0x4A841A0", VA = "0x184A859A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool BANGMMMMOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x4A85490", Offset = "0x4A83C90", VA = "0x184A85490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4A861C0", Offset = "0x4A849C0", VA = "0x184A861C0")]
	public IIEKJECLBAN(bool OICOMCKGGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x4A85C60", Offset = "0x4A84460", VA = "0x184A85C60")]
	public void LOEMKENMMLJ(object HDKLJDMDCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x4A853E0", Offset = "0x4A83BE0", VA = "0x184A853E0")]
	public void AIEHNHENCMK(int DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x4A85C50", Offset = "0x4A84450", VA = "0x184A85C50")]
	public void KLGJAMCDDJF(uint AEBIEOGMKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x4A85980", Offset = "0x4A84180", VA = "0x184A85980")]
	public void COJOLKBKIEF(bool ELJMDLKEIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x4A85C10", Offset = "0x4A84410", VA = "0x184A85C10")]
	public void IKAIGEDACPL(long POIDOFMGPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x4A86180", Offset = "0x4A84980", VA = "0x184A86180")]
	public void MCMLFEMCBDN(ulong ADCEAAIKIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x4A85B30", Offset = "0x4A84330", VA = "0x184A85B30")]
	public void IGDJAKGAKLJ(string MKAGMJEJDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x4A859B0", Offset = "0x4A841B0", VA = "0x184A859B0")]
	public void DKHIDAHAAGO(Enum NAAPPGENNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x4A854A0", Offset = "0x4A83CA0", VA = "0x184A854A0")]
	public void AJNNOHLNAEB(IList EIEGEJMBDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x27B13C0", Offset = "0x27AFBC0", VA = "0x1827B13C0")]
	public void BEMLGGGGDLM<T, U>(Dictionary<T, U> KHPDHLPGJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x4A855C0", Offset = "0x4A83DC0", VA = "0x184A855C0")]
	private void CGHKPBMAMCJ(IDictionary KHPDHLPGJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x4A85BA0", Offset = "0x4A843A0", VA = "0x184A85BA0")]
	public int IHHHMJKBLLH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x4A85AC0", Offset = "0x4A842C0", VA = "0x184A85AC0")]
	public short ELEJNHOGCIL()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x4A85A40", Offset = "0x4A84240", VA = "0x184A85A40")]
	public void DKOADGNIPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x4A85A50", Offset = "0x4A84250", VA = "0x184A85A50")]
	private void ECPELBHCEHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public abstract class LJNEIDGADCD<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	internal class NNKBGBIDPBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public TNode IEFNIJLKNAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public TNode AIECLMDDNDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public DBLOLPBMKNL GNHALPBJHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public List<DBLOLPBMKNL> DDGHDGMPNAB;

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
		public NNKBGBIDPBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal struct DBLOLPBMKNL : IComparable<DBLOLPBMKNL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int GHFHAMBKBLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public TClaimant JHMCJFIFJOG;

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x529CF0", Offset = "0x5284F0", VA = "0x180529CF0")]
		public DBLOLPBMKNL(int GHFHAMBKBLB, TClaimant JHMCJFIFJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x22C17D0", Offset = "0x22BFFD0", VA = "0x1822C17D0")]
		public bool OJOGIIBMLCG(in DBLOLPBMKNL DKNLIFHKLLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x22C17B0", Offset = "0x22BFFB0", VA = "0x1822C17B0")]
		public bool BMLFIJBDLAL(in DBLOLPBMKNL DKNLIFHKLLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x22C17C0", Offset = "0x22BFFC0", VA = "0x1822C17C0", Slot = "4")]
		public int CompareTo(DBLOLPBMKNL DKNLIFHKLLN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x22C1830", Offset = "0x22C0030", VA = "0x1822C1830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public enum PJKOGCHIOCD
	{
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class FBOHGBLPBIL : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public global::LJNEIDGADCD<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x208DFA0", Offset = "0x208C7A0", VA = "0x18208DFA0")]
		[DebuggerHidden]
		public FBOHGBLPBIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x22C1C60", Offset = "0x22C0460", VA = "0x1822C1C60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x22C1E20", Offset = "0x22C0620", VA = "0x1822C1E20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x22C1D40", Offset = "0x22C0540", VA = "0x1822C1D40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x1B07490", Offset = "0x1B05C90", VA = "0x181B07490", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly global::BEDMIIPGBCA<NNKBGBIDPBG> EGMFGICMJEB;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly global::BEDMIIPGBCA<List<DBLOLPBMKNL>> IFEJMFEMGHB;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static int BKAFKJLAEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	internal readonly Dictionary<TClaimant, TNode> BKEDPOPHFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	internal readonly Dictionary<TNode, NNKBGBIDPBG> ELHJOGIFHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private PJKOGCHIOCD MKIJLPJFOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private bool AGFBONPPMGD;

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode GFIIMHHNNNO(TNode BNMBBMFILCA);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void DPENONDIKOH(TNode BNMBBMFILCA, TClaimant KPGANBHAHLN, TClaimant AMLFNFIIBOA);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x22CF650", Offset = "0x22CDE50", VA = "0x1822CF650")]
	public LJNEIDGADCD(PJKOGCHIOCD MKIJLPJFOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x22CE510", Offset = "0x22CCD10", VA = "0x1822CE510")]
	public void FFNGJAAAEON(TNode BNMBBMFILCA, TNode GCGOKGDFKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x22CECA0", Offset = "0x22CD4A0", VA = "0x1822CECA0")]
	public void ICBAOCNKBNG(TClaimant JHMCJFIFJOG, TNode KFOFJMELADN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x22CE120", Offset = "0x22CC920", VA = "0x1822CE120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x22CF050", Offset = "0x22CD850", VA = "0x1822CF050")]
	private void KFNGKBOMPID(TClaimant JHMCJFIFJOG, TNode IDHJMLJOBGM, TNode KFOFJMELADN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x22CF480", Offset = "0x22CDC80", VA = "0x1822CF480")]
	private int POCLCLLKNBC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x22CEDA0", Offset = "0x22CD5A0", VA = "0x1822CEDA0")]
	private void JDOOIECBCNH(TClaimant JHMCJFIFJOG, TNode LIIMCBOJBBL, TNode JLDEGBFBEOA, int PENEOFFJBFP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x22CE7D0", Offset = "0x22CCFD0", VA = "0x1822CE7D0")]
	private void GPOECBFGINO(DBLOLPBMKNL FKGGFKFIJOD, NNKBGBIDPBG NBFKCCJFFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x22CDEB0", Offset = "0x22CC6B0", VA = "0x1822CDEB0")]
	private void DFFDLCKMKMD(TClaimant JHMCJFIFJOG, TNode LIIMCBOJBBL, TNode JLDEGBFBEOA, int PENEOFFJBFP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x22CF0F0", Offset = "0x22CD8F0", VA = "0x1822CF0F0")]
	private void NJFHKCNDIHC(DBLOLPBMKNL FKGGFKFIJOD, TNode BNMBBMFILCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x22CE590", Offset = "0x22CCD90", VA = "0x1822CE590")]
	private void FNHNMCPCANI(DBLOLPBMKNL FKGGFKFIJOD, NNKBGBIDPBG NBFKCCJFFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x22CE690", Offset = "0x22CCE90", VA = "0x1822CE690")]
	private void FPCKFNEICNC(NNKBGBIDPBG NBFKCCJFFFE, bool HNKIFCCLCAC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x22CE860", Offset = "0x22CD060", VA = "0x1822CE860")]
	private void HIDIALLBGJM(NNKBGBIDPBG NBFKCCJFFFE, TNode GCGOKGDFKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x22CF3B0", Offset = "0x22CDBB0", VA = "0x1822CF3B0")]
	[IteratorStateMachine(typeof(global::LJNEIDGADCD<, >.FBOHGBLPBIL))]
	private IEnumerable<TNode> OOCFOIBBJFB(TNode LIIMCBOJBBL, TNode JLDEGBFBEOA, bool JLAGFOEAEJA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x22CDDF0", Offset = "0x22CC5F0", VA = "0x1822CDDF0")]
	private NNKBGBIDPBG BFCCEAGOEEA(TNode BNMBBMFILCA, TNode AIECLMDDNDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x22CE380", Offset = "0x22CCB80", VA = "0x1822CE380")]
	private NNKBGBIDPBG FDMMGPELJHB(TNode BNMBBMFILCA, TNode AIECLMDDNDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x22CF1F0", Offset = "0x22CD9F0", VA = "0x1822CF1F0")]
	private void NOEEAGLELPO(NNKBGBIDPBG NBFKCCJFFFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class MFMPLOHPKFN<T> : IEnumerable<global::MFMPLOHPKFN<T>.CEKMFNPCMCJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct CEKMFNPCMCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public T DOBKOKNNFGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int MPFAEFMOAIE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class LNMPCHAPIAC : IEnumerator<CEKMFNPCMCJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private global::MFMPLOHPKFN<T> HOGLDPPOBKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int MPFAEFMOAIE;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x2782FE0", Offset = "0x27817E0", VA = "0x182782FE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public CEKMFNPCMCJ GJJLJPDPKDB
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x2B760A0", Offset = "0x2B748A0", VA = "0x182B760A0", Slot = "4")]
			get
			{
				return default(CEKMFNPCMCJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x853520", Offset = "0x851D20", VA = "0x180853520")]
		public LNMPCHAPIAC(global::MFMPLOHPKFN<T> HOGLDPPOBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x2B76010", Offset = "0x2B74810", VA = "0x182B76010", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6CA7E0", Offset = "0x6C8FE0", VA = "0x1806CA7E0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7EB520", Offset = "0x7E9D20", VA = "0x1807EB520", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private struct CIFHJKBKINC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public bool APDGDCMDEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public T DOBKOKNNFGA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private const int ECJJECIFLLF = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Dictionary<T, int> CEIJGHODACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private CIFHJKBKINC[] PNPFNAAOCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int CDBJBLDBOEF;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public int MKFJBHDFMPL
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x26A7CF0", Offset = "0x26A64F0", VA = "0x1826A7CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2B7ABB0", Offset = "0x2B793B0", VA = "0x182B7ABB0")]
	public static global::MFMPLOHPKFN<T> MFJGGFBBBIA(CEKMFNPCMCJ[] HOOKOBIPOOJ, bool JDCKGPHPICA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B070", Offset = "0x2B79870", VA = "0x182B7B070")]
	public MFMPLOHPKFN(int PODLECMNECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x2120C10", Offset = "0x211F410", VA = "0x182120C10")]
	public bool GMOJELIMFAK(T DOBKOKNNFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x2B7AF90", Offset = "0x2B79790", VA = "0x182B7AF90")]
	public bool OKEIOMPHIKN(int MPFAEFMOAIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A670", Offset = "0x2B78E70", VA = "0x182B7A670")]
	public bool GNDANEOMOEO(Func<T, bool> NKHIHPJGCDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A460", Offset = "0x2B78C60", VA = "0x182B7A460")]
	public int ADCHNBDDGPI(T DOBKOKNNFGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A4B0", Offset = "0x2B78CB0", VA = "0x182B7A4B0")]
	public T CONEJLBHBKC(int MPFAEFMOAIE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A520", Offset = "0x2B78D20", VA = "0x182B7A520")]
	public void DKOADGNIPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A960", Offset = "0x2B79160", VA = "0x182B7A960")]
	public bool LOLGLADEDCA(T DOBKOKNNFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A980", Offset = "0x2B79180", VA = "0x182B7A980")]
	public bool LOLGLADEDCA(T DOBKOKNNFGA, int MPFAEFMOAIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A720", Offset = "0x2B78F20", VA = "0x182B7A720")]
	public bool HICPDAONBIK(T DOBKOKNNFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A570", Offset = "0x2B78D70", VA = "0x182B7A570")]
	public bool EEIBIAAMIOE(int MPFAEFMOAIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A5C0", Offset = "0x2B78DC0", VA = "0x182B7A5C0")]
	private void ENOIEEAECFC(int MPFAEFMOAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A7A0", Offset = "0x2B78FA0", VA = "0x182B7A7A0")]
	public CEKMFNPCMCJ[] KMNACKHEIOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A910", Offset = "0x2B79110", VA = "0x182B7A910")]
	private int LDBMPFFLMKJ(int LFFIOCBDPNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x2B7AFF0", Offset = "0x2B797F0", VA = "0x182B7AFF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x2B7AFF0", Offset = "0x2B797F0", VA = "0x182B7AFF0", Slot = "4")]
	private IEnumerator<CEKMFNPCMCJ> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class BEDMIIPGBCA<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly Stack<T> FNLBEJAKEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly List<T> JKFIODKKHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly int FAIHMJFCOIA;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public int ABBPCOACDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x1E9C400", Offset = "0x1E9AC00", VA = "0x181E9C400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int AOGAENHDFHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x1E9A660", Offset = "0x1E98E60", VA = "0x181E9A660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x36B1360", Offset = "0x36AFB60", VA = "0x1836B1360")]
	public static global::BEDMIIPGBCA<T> MLCLIMDEANE(int PODLECMNECF = 0, int FAIHMJFCOIA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x36B1030", Offset = "0x36AF830", VA = "0x1836B1030")]
	public static global::BEDMIIPGBCA<T> ILEIEKPGHLC(int PODLECMNECF = 0, int FAIHMJFCOIA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x36B1620", Offset = "0x36AFE20", VA = "0x1836B1620")]
	public BEDMIIPGBCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x36B1660", Offset = "0x36AFE60", VA = "0x1836B1660")]
	public BEDMIIPGBCA(int PODLECMNECF, int FAIHMJFCOIA = int.MaxValue, bool DGLBNHEBAPD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x36B14F0", Offset = "0x36AFCF0", VA = "0x1836B14F0")]
	public T POKMHLEGAGK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x36B0D90", Offset = "0x36AF590", VA = "0x1836B0D90")]
	public void AHHGOMJHABC(T DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x36B1430", Offset = "0x36AFC30", VA = "0x1836B1430")]
	private void PLCANIKLBCJ(T DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x36B0E50", Offset = "0x36AF650", VA = "0x1836B0E50")]
	private void APMINGNNFPN(T DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x36B1100", Offset = "0x36AF900", VA = "0x1836B1100")]
	[Conditional("DEBUG_BUILD")]
	private void IMFGJMDGONA(T OKCCFADKIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x36B0E70", Offset = "0x36AF670", VA = "0x1836B0E70")]
	[Conditional("DEBUG_BUILD")]
	private void CNAOBMEBBCN(T OKCCFADKIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x36B0F20", Offset = "0x36AF720", VA = "0x1836B0F20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x36B11A0", Offset = "0x36AF9A0", VA = "0x1836B11A0")]
	private void LKLNOHPMGNA(IEnumerable<T> BHDDAABDKKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class NOOKFLLAKNA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private Dictionary<int, T> CKGACPCDBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private T LPMPHNGBGON;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T LPMKGBPLNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x5214A0", Offset = "0x51FCA0", VA = "0x1805214A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool DLPECECICDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x368E790", Offset = "0x368CF90", VA = "0x18368E790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x368E730", Offset = "0x368CF30", VA = "0x18368E730")]
	public bool EKPNDINILNN(T DOBKOKNNFGA, int GHFHAMBKBLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x368E800", Offset = "0x368D000", VA = "0x18368E800")]
	public bool NMBJDOKCLPN(int GHFHAMBKBLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x368E860", Offset = "0x368D060", VA = "0x18368E860")]
	public T OKMCDPIDHMC(int PKEGADFEHDO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x368E670", Offset = "0x368CE70", VA = "0x18368E670")]
	public void DKOADGNIPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x368E5E0", Offset = "0x368CDE0", VA = "0x18368E5E0")]
	private bool ANINNPPKPGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x368E7D0", Offset = "0x368CFD0", VA = "0x18368E7D0")]
	public bool NFIDKFMHPHL(int GHFHAMBKBLB, out T DOBKOKNNFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x22D2AB0", Offset = "0x22D12B0", VA = "0x1822D2AB0")]
	public NOOKFLLAKNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class BMKIPKOAFLH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	protected struct JKNCIOILHAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public T MPJDHKAGMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int BCIIPGPKAKI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	protected readonly List<JKNCIOILHAE> HMCECDOOLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private T GEDLELPFKOK;

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int MKFJBHDFMPL
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x1C0DBD0", Offset = "0x1C0C3D0", VA = "0x181C0DBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x36B5DC0", Offset = "0x36B45C0", VA = "0x1836B5DC0")]
	public bool GNDANEOMOEO(T DOBKOKNNFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x36B5D20", Offset = "0x36B4520", VA = "0x1836B5D20")]
	public void EFDMEADFFJF(T DOBKOKNNFGA, int GHFHAMBKBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x36B6010", Offset = "0x36B4810", VA = "0x1836B6010")]
	public bool HICPDAONBIK(T DOBKOKNNFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x36B5CC0", Offset = "0x36B44C0", VA = "0x1836B5CC0")]
	public void DKOADGNIPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x36B6130", Offset = "0x36B4930", VA = "0x1836B6130")]
	public T JDCDLFGMBIM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x36B61C0", Offset = "0x36B49C0", VA = "0x1836B61C0")]
	public T MLMFIOBECJE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x36B6230", Offset = "0x36B4A30", VA = "0x1836B6230")]
	private void NMBMPHPLCJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x36B6440", Offset = "0x36B4C40", VA = "0x1836B6440")]
	public BMKIPKOAFLH()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		[LBKCPHKKGJL(PCCPJPANDII.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x4A88560", Offset = "0x4A86D60", VA = "0x184A88560")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x4A88A30", Offset = "0x4A87230", VA = "0x184A88A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x4A88850", Offset = "0x4A87050", VA = "0x184A88850")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x4A88BD0", Offset = "0x4A873D0", VA = "0x184A88BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x4A88420", Offset = "0x4A86C20", VA = "0x184A88420")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x4A888F0", Offset = "0x4A870F0", VA = "0x184A888F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x4A88710", Offset = "0x4A86F10", VA = "0x184A88710")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x4A88380", Offset = "0x4A86B80", VA = "0x184A88380")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface NONMCIOADOC
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public abstract class ResourcePrefabReference<T> : NONMCIOADOC where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1EA5B30", Offset = "0x1EA4330", VA = "0x181EA5B30", Slot = "4")]
		public virtual T MICMJIOHICH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class KLECAOGDPGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly Dictionary<byte, KNCJFCBGMLD> PDKFPPFIEPO;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public KNCJFCBGMLD PCCBBGBHELE
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x5211D0", Offset = "0x51F9D0", VA = "0x1805211D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x521490", Offset = "0x51FC90", VA = "0x180521490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector2 OMDKIBMNDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x11C0EC0", Offset = "0x11BF6C0", VA = "0x1811C0EC0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x1C103B0", Offset = "0x1C0EBB0", VA = "0x181C103B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector2 ELHMIOHJJMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x16BF260", Offset = "0x16BDA60", VA = "0x1816BF260")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x16BF2C0", Offset = "0x16BDAC0", VA = "0x1816BF2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector2 OMDICGMENFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x34A0870", Offset = "0x349F070", VA = "0x1834A0870")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x34A0890", Offset = "0x349F090", VA = "0x1834A0890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public int GFDKIIICEEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x54C7E0", Offset = "0x54AFE0", VA = "0x18054C7E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x5729A0", Offset = "0x5711A0", VA = "0x1805729A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x4A86A00", Offset = "0x4A85200", VA = "0x184A86A00")]
	public KLECAOGDPGC(Bounds NNKDKCCKCEI, Vector2[] JLEMJGJCPAP, int NHLJHGDGJJM, byte LFFIOCBDPNK, float DEMNPPAGKFC = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x4A86850", Offset = "0x4A85050", VA = "0x184A86850")]
	public KNCJFCBGMLD COLBEMCJHBE(byte MPFAEFMOAIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x4A86760", Offset = "0x4A84F60", VA = "0x184A86760")]
	public void CMMPEEHLIJD(Vector3 LILNOJCGNDN, float CANMIIPEJLJ, float OHJIFAHDIDM, ref List<byte> ALAGJAIMMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x4A869E0", Offset = "0x4A851E0", VA = "0x184A869E0")]
	public void KJJIHJLOPBI(KNCJFCBGMLD.HCEPAGALLBP EHDBHJFJBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x4A868B0", Offset = "0x4A850B0", VA = "0x184A868B0")]
	private KNCJFCBGMLD JBDICGBPGHP(byte MPFAEFMOAIE, KNCJFCBGMLD.ANGKNDGGMHF JLPIHKGBDDB, KNCJFCBGMLD AIECLMDDNDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x4A86240", Offset = "0x4A84A40", VA = "0x184A86240")]
	private void ANPJDMPLMPO(KNCJFCBGMLD AIECLMDDNDL, Vector2[] JLEMJGJCPAP, int HNBOFDKEDKN, int ENJHCCPCABK, int AMHKCGCDJOF, int OOOCPFDJCFA, float DEMNPPAGKFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class KNCJFCBGMLD
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum ANGKNDGGMHF
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public enum HCEPAGALLBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public byte CPMLAIPIOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public Vector3 HLGAOPDMEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public Vector3 NLOJDNDIBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public Vector3 LAMFGIMABEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public Vector3 ONDPBKFGPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public ANGKNDGGMHF CNIGCMJMBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public KNCJFCBGMLD INIDEFLHEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public List<KNCJFCBGMLD> IKEDAEFIDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public bool APBMIGMCDIE;

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x4A87350", Offset = "0x4A85B50", VA = "0x184A87350")]
	public KNCJFCBGMLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x4A872F0", Offset = "0x4A85AF0", VA = "0x184A872F0")]
	public KNCJFCBGMLD(byte PEIAGKGLLKC, ANGKNDGGMHF JLPIHKGBDDB, KNCJFCBGMLD AIECLMDDNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x4A87250", Offset = "0x4A85A50", VA = "0x184A87250")]
	public void PAIMFNKPAOA(KNCJFCBGMLD BLMOOMCFFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80")]
	public void KJJIHJLOPBI(int DACKLJPHBHH, HCEPAGALLBP EHDBHJFJBNA, int IGAFPLMBJIP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x4A86F20", Offset = "0x4A85720", VA = "0x184A86F20")]
	public void CMMPEEHLIJD(List<byte> ALAGJAIMMGA, Vector3 LILNOJCGNDN, float CANMIIPEJLJ, float OHJIFAHDIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x4A871F0", Offset = "0x4A859F0", VA = "0x184A871F0")]
	public bool NLJEPEOFNEL(Vector3 HCKJMBFLDJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x4A871B0", Offset = "0x4A859B0", VA = "0x184A871B0")]
	public bool MBOLPIGGGBJ(Vector3 HCKJMBFLDJI, float OHICKADHECF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class CGNNJFEDIHF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly Dictionary<T, object> HPDDALOEFOE;

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2122340", Offset = "0x2120B40", VA = "0x182122340")]
	public bool LLLIAELBLJE(T JGEMMLOPPBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x36EBA90", Offset = "0x36EA290", VA = "0x1836EBA90")]
	public bool LLLIAELBLJE(T JGEMMLOPPBN, object OIFAEHGKHPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x36EBAD0", Offset = "0x36EA2D0", VA = "0x1836EBAD0")]
	public bool LLLIAELBLJE(T JGEMMLOPPBN, object OIFAEHGKHPE, out object BMNPDIKKDHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x36EB980", Offset = "0x36EA180", VA = "0x1836EB980")]
	public bool AOFJOHOMDBL(T JGEMMLOPPBN, object OIFAEHGKHPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x36EBB30", Offset = "0x36EA330", VA = "0x1836EBB30")]
	public bool PIMHJLDENLP(T JGEMMLOPPBN, object OIFAEHGKHPE, out object BMNPDIKKDHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x36EB8F0", Offset = "0x36EA0F0", VA = "0x1836EB8F0")]
	public bool AOFJOHOMDBL(T JGEMMLOPPBN, object OIFAEHGKHPE, out object BMNPDIKKDHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x36EBA60", Offset = "0x36EA260", VA = "0x1836EBA60")]
	public void KBBJCPKKCNM(T JGEMMLOPPBN, object OIFAEHGKHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x36EB9C0", Offset = "0x36EA1C0", VA = "0x1836EB9C0")]
	public void BCNOBPNHNFG(T JGEMMLOPPBN, object OIFAEHGKHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x36EBB70", Offset = "0x36EA370", VA = "0x1836EBB70")]
	public CGNNJFEDIHF()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public struct NKFCEGPAPIF<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			private readonly List<Component> EIEGEJMBDDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			private readonly bool EFAIICBGGNO;

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x7796B0", Offset = "0x777EB0", VA = "0x1807796B0")]
			public NKFCEGPAPIF(List<Component> EIEGEJMBDDP, bool EFAIICBGGNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x1E9CCA0", Offset = "0x1E9B4A0", VA = "0x181E9CCA0")]
			public GBLKLLKEDAP<T> EIFBDBIKCMD()
			{
				return default(GBLKLLKEDAP<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x1E9CD10", Offset = "0x1E9B510", VA = "0x181E9CD10", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x1E9CD10", Offset = "0x1E9B510", VA = "0x181E9CD10", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public struct GBLKLLKEDAP<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private readonly List<Component> EIEGEJMBDDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			private readonly bool EFAIICBGGNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private int MPFAEFMOAIE;

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public T GJJLJPDPKDB
			{
				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x1E9AFB0", Offset = "0x1E997B0", VA = "0x181E9AFB0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002D5")]
				[Cpp2IlInjected.Address(RVA = "0x1E9AF40", Offset = "0x1E99740", VA = "0x181E9AF40", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x1E9AF80", Offset = "0x1E99780", VA = "0x181E9AF80")]
			public GBLKLLKEDAP(List<Component> EIEGEJMBDDP, bool EFAIICBGGNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x1E9AE70", Offset = "0x1E99670", VA = "0x181E9AE70", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x1E9AE80", Offset = "0x1E99680", VA = "0x181E9AE80", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x1E9AF30", Offset = "0x1E99730", VA = "0x181E9AF30", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x4A8A890", Offset = "0x4A89090", VA = "0x184A8A890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x4A8A850", Offset = "0x4A89050", VA = "0x184A8A850")]
		public ToolHierarchyCache(GameObject PLMAOJKKMEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x4A8A340", Offset = "0x4A88B40", VA = "0x184A8A340")]
		private void LHPLLNMCLEE(GameObject PLMAOJKKMEA, bool NMOGGLCILMM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x4A8A460", Offset = "0x4A88C60", VA = "0x184A8A460")]
		public static void LHPLLNMCLEE(GameObject PLMAOJKKMEA, ref ToolHierarchyCache GMGIAPHDHLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x4A8A030", Offset = "0x4A88830", VA = "0x184A8A030")]
		public void BKOFBDKDDAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x4A8A7A0", Offset = "0x4A88FA0", VA = "0x184A8A7A0")]
		public void PBGIIBFIPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1B936C0", Offset = "0x1B91EC0", VA = "0x181B936C0")]
		public void EMBAFHLEDKP<T>(Action<T> BOJLOMGNIOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x4A8A1F0", Offset = "0x4A889F0", VA = "0x184A8A1F0")]
		public Component JIDAHFHLFFE(Type MIDEMNGPEAG, bool EFAIICBGGNO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1CB07E0", Offset = "0x1CAEFE0", VA = "0x181CB07E0")]
		public T JIDAHFHLFFE<T>(bool EFAIICBGGNO = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x4A8A2B0", Offset = "0x4A88AB0", VA = "0x184A8A2B0")]
		public NKFCEGPAPIF<Component> LBAKPDJCBLK(Type MIDEMNGPEAG, bool EFAIICBGGNO = false)
		{
			return default(NKFCEGPAPIF<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x1CFA9A0", Offset = "0x1CF91A0", VA = "0x181CFA9A0")]
		public NKFCEGPAPIF<T> LBAKPDJCBLK<T>(bool EFAIICBGGNO = false) where T : class
		{
			return default(NKFCEGPAPIF<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x4A8A4F0", Offset = "0x4A88CF0", VA = "0x184A8A4F0")]
		public List<Component> MFEDDDDMPCP(Type MIDEMNGPEAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x4A8A100", Offset = "0x4A88900", VA = "0x184A8A100", Slot = "4")]
		public bool Equals(ToolHierarchyCache DNCFOPMJGLJ, ToolHierarchyCache DEMCFCBJOPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x4A8A180", Offset = "0x4A88980", VA = "0x184A8A180", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache HDKLJDMDCGI)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class IPCPLHNBPAE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private int PODLECMNECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private int OBKANBBNDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private List<T> PLNJEFBBBME;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int MKFJBHDFMPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x1E9C400", Offset = "0x1E9AC00", VA = "0x181E9C400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T KFDCAJOFAAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x3209F30", Offset = "0x3208730", VA = "0x183209F30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T JCFIBNFKIIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x320A0C0", Offset = "0x32088C0", VA = "0x18320A0C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T HDGLPLPNHFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x3209D30", Offset = "0x3208530", VA = "0x183209D30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x320A150", Offset = "0x3208950", VA = "0x18320A150")]
	public IPCPLHNBPAE(int PODLECMNECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x3209D80", Offset = "0x3208580", VA = "0x183209D80")]
	public void EFDMEADFFJF(T OPEBMPOKNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x3209C80", Offset = "0x3208480", VA = "0x183209C80")]
	public void DKOADGNIPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x3209BE0", Offset = "0x32083E0", VA = "0x183209BE0")]
	public void BFEKNAHLELI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x320A100", Offset = "0x3208900", VA = "0x18320A100")]
	public void OOMJLNCLPCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x3209BD0", Offset = "0x32083D0", VA = "0x183209BD0")]
	public void AEGEJFMKPKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class IHGBAPMMFCB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool COHELELJNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Action BOJLOMGNIOM;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public static IHGBAPMMFCB EKPNGANAFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x4A85360", Offset = "0x4A83B60", VA = "0x184A85360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool DOFIHGIMLDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x54C7B0", Offset = "0x54AFB0", VA = "0x18054C7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x83CEE0", Offset = "0x83B6E0", VA = "0x18083CEE0")]
	public IHGBAPMMFCB(Action BOJLOMGNIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x4A85340", Offset = "0x4A83B40", VA = "0x184A85340")]
	public void HOCHBDLCMIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x4A85340", Offset = "0x4A83B40", VA = "0x184A85340", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class MMHKIEMJBHL
{
	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80")]
	public static void IONCICNIFMB(OBLBGCIALPL ECONKGPCNDK, string PFEAHOONGKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class LKMDIBCNOFL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private struct DJIMNDHJFDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public int BCIIPGPKAKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public T MPJDHKAGMAD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private Dictionary<object, DJIMNDHJFDL> CKGACPCDBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private T LPMPHNGBGON;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public virtual T LPMKGBPLNGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x522000", Offset = "0x520800", VA = "0x180522000", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x1C10360", Offset = "0x1C0EB60", VA = "0x181C10360", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool DLPECECICDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x22D2670", Offset = "0x22D0E70", VA = "0x1822D2670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public object KKHHLDNJAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x54A0C0", Offset = "0x5488C0", VA = "0x18054A0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x644A90", Offset = "0x643290", VA = "0x180644A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x22D2520", Offset = "0x22D0D20", VA = "0x1822D2520")]
	public bool EKPNDINILNN(T DOBKOKNNFGA, object OIFAEHGKHPE, int GHFHAMBKBLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x22D2A40", Offset = "0x22D1240", VA = "0x1822D2A40")]
	public bool NMBJDOKCLPN(object OIFAEHGKHPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x22D2880", Offset = "0x22D1080", VA = "0x1822D2880")]
	public bool NFIDKFMHPHL(object OIFAEHGKHPE, out T DOBKOKNNFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x1C0FBB0", Offset = "0x1C0E3B0", VA = "0x181C0FBB0")]
	public void DKOADGNIPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x22D1710", Offset = "0x22CFF10", VA = "0x1822D1710")]
	private bool ANINNPPKPGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x22D2AB0", Offset = "0x22D12B0", VA = "0x1822D2AB0")]
	public LKMDIBCNOFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class COMBEAHMNPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private Dictionary<object, float> CKGACPCDBIC;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float CGMPNMLKAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xE34B40", Offset = "0xE33340", VA = "0x180E34B40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xCF8C20", Offset = "0xCF7420", VA = "0x180CF8C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x4A84E00", Offset = "0x4A83600", VA = "0x184A84E00")]
	public void EKPNDINILNN(float DOBKOKNNFGA, object OIFAEHGKHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x4A84E70", Offset = "0x4A83670", VA = "0x184A84E70")]
	public void NMBJDOKCLPN(object OIFAEHGKHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x4A84EE0", Offset = "0x4A836E0", VA = "0x184A84EE0")]
	private void OBIBFGPKLBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x4A85000", Offset = "0x4A83800", VA = "0x184A85000")]
	public COMBEAHMNPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class OBLBGCIALPL
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class PHPOCICCHHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly string MLPFAPHBNJC;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		private PHPOCICCHHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x656320", Offset = "0x654B20", VA = "0x180656320")]
		public PHPOCICCHHD(string MLPFAPHBNJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x4A88280", Offset = "0x4A86A80", VA = "0x184A88280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class PJGIKPLGDJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public PJGIKPLGDJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x4A882D0", Offset = "0x4A86AD0", VA = "0x184A882D0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly HashSet<object> NDHBPGANIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int IDAAAAKBAGF;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public bool HBBIMFOGFII
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x4A87CA0", Offset = "0x4A864A0", VA = "0x184A87CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int MKFJBHDFMPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x5AD670", Offset = "0x5ABE70", VA = "0x1805AD670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x4A87B40", Offset = "0x4A86340", VA = "0x184A87B40")]
	public bool EFDMEADFFJF(object OIFAEHGKHPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x4A87C20", Offset = "0x4A86420", VA = "0x184A87C20")]
	public bool HICPDAONBIK(object OIFAEHGKHPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x4A87BC0", Offset = "0x4A863C0", VA = "0x184A87BC0")]
	public bool GNDANEOMOEO(object OIFAEHGKHPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x4A87AE0", Offset = "0x4A862E0", VA = "0x184A87AE0")]
	public void ANFCFHMFGGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x4A87CB0", Offset = "0x4A864B0", VA = "0x184A87CB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x4A87E20", Offset = "0x4A86620", VA = "0x184A87E20")]
	public OBLBGCIALPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class NHCHFLNKOHN<T>
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private struct JHMGCBJLMLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public float FCDEAOIBGIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public T MPJDHKAGMAD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private Dictionary<object, JHMGCBJLMLI> CKGACPCDBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private T FLCDECLEENG;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public virtual T GAAKBCFBHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xFFD380", Offset = "0xFFBB80", VA = "0x180FFD380", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x1C103D0", Offset = "0x1C0EBD0", VA = "0x181C103D0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public object CJBIPKFOKHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x549A30", Offset = "0x548230", VA = "0x180549A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x659540", Offset = "0x657D40", VA = "0x180659540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool DLPECECICDG
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1C10320", Offset = "0x1C0EB20", VA = "0x181C10320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1C0FBE0", Offset = "0x1C0E3E0", VA = "0x181C0FBE0")]
	public bool EKPNDINILNN(T DOBKOKNNFGA, object OIFAEHGKHPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x1C10720", Offset = "0x1C0EF20", VA = "0x181C10720")]
	public bool NMBJDOKCLPN(object OIFAEHGKHPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x1C0FBB0", Offset = "0x1C0E3B0", VA = "0x181C0FBB0")]
	public void DKOADGNIPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x1C105D0", Offset = "0x1C0EDD0", VA = "0x181C105D0")]
	public bool NFIDKFMHPHL(object OIFAEHGKHPE, out T DOBKOKNNFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x1C0F0F0", Offset = "0x1C0D8F0", VA = "0x181C0F0F0")]
	private bool ANINNPPKPGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x1C10780", Offset = "0x1C0EF80", VA = "0x181C10780")]
	public NHCHFLNKOHN()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class LPHGEELGLMB
{
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static byte[] GPJANLJHPME;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private static int PPCKGPBBLCP;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private static int JEFPLDJMJDE;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private static BigInteger ABCMBKBOAFJ;

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public LPHGEELGLMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x4A87370", Offset = "0x4A85B70", VA = "0x184A87370")]
	private static string EOENAFMMDNF(byte[] DOMNMKJGGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x4A87470", Offset = "0x4A85C70", VA = "0x184A87470")]
	public static string OPCCKPNHHLB(byte[] MIIBCOAJABM, bool NJCHAECDCAB)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
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
