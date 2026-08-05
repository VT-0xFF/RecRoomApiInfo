using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class FBGGOAJELOF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x62DFB0", Offset = "0x62C9B0", VA = "0x18062DFB0")]
	public FBGGOAJELOF()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4271A0", Offset = "0x425BA0", VA = "0x1804271A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x427E60", Offset = "0x426860", VA = "0x180427E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x427450", Offset = "0x425E50", VA = "0x180427450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "4")]
	public virtual void IAIBFLOJIGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA48440", Offset = "0xA46E40", VA = "0x180A48440")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[FBGGOAJELOF]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2FC1140", Offset = "0x2FBFB40", VA = "0x182FC1140", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2FC0C80", Offset = "0x2FBF680", VA = "0x182FC0C80", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2FC1740", Offset = "0x2FC0140", VA = "0x182FC1740")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class DKHILEDBGIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA48440", Offset = "0xA46E40", VA = "0x180A48440")]
		public DKHILEDBGIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2F0EDF0", Offset = "0x2F0D7F0", VA = "0x182F0EDF0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[FBGGOAJELOF]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2F11970", Offset = "0x2F10370", VA = "0x182F11970", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2F119A0", Offset = "0x2F103A0", VA = "0x182F119A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2F118C0", Offset = "0x2F102C0", VA = "0x182F118C0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey AOLPFBNJMEA]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2F118F0", Offset = "0x2F102F0", VA = "0x182F118F0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2F117D0", Offset = "0x2F101D0", VA = "0x182F117D0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2F11040", Offset = "0x2F0FA40", VA = "0x182F11040", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2F109B0", Offset = "0x2F0F3B0", VA = "0x182F109B0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2F10550", Offset = "0x2F0EF50", VA = "0x182F10550", Slot = "14")]
	protected virtual string DPCDEJLDOCP(TKeyVal PKACEJMGKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2F104F0", Offset = "0x2F0EEF0", VA = "0x182F104F0", Slot = "4")]
	public bool ContainsKey(TKey AOLPFBNJMEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2F116D0", Offset = "0x2F100D0", VA = "0x182F116D0", Slot = "5")]
	public bool TryGetValue(TKey AOLPFBNJMEA, out TVal MDAEJMIAMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2F105B0", Offset = "0x2F0EFB0", VA = "0x182F105B0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2F105B0", Offset = "0x2F0EFB0", VA = "0x182F105B0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2F11700", Offset = "0x2F10100", VA = "0x182F11700")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HLGJPMMMCLF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class MCJOOKAJING
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA48440", Offset = "0xA46E40", VA = "0x180A48440")]
		public MCJOOKAJING()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x33219E0", Offset = "0x33203E0", VA = "0x1833219E0")]
		internal bool <GetSamples>b__0(global::EEKMHDNGEFB<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float FNBIHEBLNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float EKHNECMGGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<global::EEKMHDNGEFB<float, T>> PLDDOIGBOJA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int LNJBNBHHDFK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x331F400", Offset = "0x331DE00", VA = "0x18331F400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x331FF10", Offset = "0x331E910", VA = "0x18331FF10")]
	public HLGJPMMMCLF(float LBKENGDOLDK, float INFJDPNPLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x331FCF0", Offset = "0x331E6F0", VA = "0x18331FCF0")]
	public bool JOMMONBFLJC(float FBECFIHCILC, T MDAEJMIAMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x331F830", Offset = "0x331E230", VA = "0x18331F830")]
	public IEnumerable<T> EGFNKNEJKKN(float FBECFIHCILC, [Optional] float? KMCHDKEAELL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x331FB60", Offset = "0x331E560", VA = "0x18331FB60")]
	public void ENEFFEHIEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x331FE50", Offset = "0x331E850", VA = "0x18331FE50")]
	private void OHADHBLLMPK(float FBECFIHCILC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class IDJILDOKBOP<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct JBDDMLMIINC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public T KJIPGBPKLDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float NKGHPNMDKEA;
	}

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static float JKPCHKCLEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private List<T> GCLHCLOPEGH;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const int HKIEFOMCGKF = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private JBDDMLMIINC[] MFDIDAMKFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int HPNGLBAPEAG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MOBIGNPKBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x73ECE0", Offset = "0x73D6E0", VA = "0x18073ECE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x73EDC0", Offset = "0x73D7C0", VA = "0x18073EDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2D48C30", Offset = "0x2D47630", VA = "0x182D48C30")]
	public IDJILDOKBOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2D48C60", Offset = "0x2D47660", VA = "0x182D48C60")]
	public IDJILDOKBOP(int OOJNMIFKLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2D48720", Offset = "0x2D47120", VA = "0x182D48720")]
	public void MDMPNEGHIKO(float FBECFIHCILC, T MDAEJMIAMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2D48190", Offset = "0x2D46B90", VA = "0x182D48190")]
	public void ENEFFEHIEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2D48540", Offset = "0x2D46F40", VA = "0x182D48540")]
	public bool IDDMHMJBFAM(float LJBPJFGAPNI, float EMDHPPDDGCE, out T MDAEJMIAMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2D48A80", Offset = "0x2D47480", VA = "0x182D48A80")]
	public bool OIFHDKEIHFB(float LJBPJFGAPNI, float EMDHPPDDGCE, out T MDAEJMIAMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2D47D90", Offset = "0x2D46790", VA = "0x182D47D90")]
	public void DBMLBNLCFFF(float LJBPJFGAPNI, float EMDHPPDDGCE, List<T> EKANCEBKLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2D486F0", Offset = "0x2D470F0", VA = "0x182D486F0")]
	private int JMACEFHBAFE(int HEJAMLIDJFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2D482E0", Offset = "0x2D46CE0", VA = "0x182D482E0")]
	private void GEHNPNEBNMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T ANOOIBKNFPD();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T DEHDNOLBMBL(T MDAEJMIAMDO, float NNKBIBBPOAL);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T HNKDAEFFJJC(T FLBBBEGIIKC, T CKLMPCMJGEK);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T NJGFJNLFEDH(T FLBBBEGIIKC, T CKLMPCMJGEK);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class KCKMBEHMDFP : global::IDJILDOKBOP<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3D815A0", Offset = "0x3D7FFA0", VA = "0x183D815A0", Slot = "4")]
	protected override Vector3 ANOOIBKNFPD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3D81610", Offset = "0x3D80010", VA = "0x183D81610", Slot = "5")]
	protected override Vector3 DEHDNOLBMBL(Vector3 MDAEJMIAMDO, float NNKBIBBPOAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3D816B0", Offset = "0x3D800B0", VA = "0x183D816B0", Slot = "6")]
	protected override Vector3 HNKDAEFFJJC(Vector3 FLBBBEGIIKC, Vector3 CKLMPCMJGEK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3D81760", Offset = "0x3D80160", VA = "0x183D81760", Slot = "7")]
	protected override Vector3 NJGFJNLFEDH(Vector3 FLBBBEGIIKC, Vector3 CKLMPCMJGEK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3D817D0", Offset = "0x3D801D0", VA = "0x183D817D0")]
	public KCKMBEHMDFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PHABEDCBMEE
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x235A0B0", Offset = "0x2358AB0", VA = "0x18235A0B0")]
	public static global::EEKMHDNGEFB<T1, T2> KNEDIEMGNBJ<T1, T2>(T1 KPCOHIJCMJJ, T2 LHBDMGJFDFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x235A120", Offset = "0x2358B20", VA = "0x18235A120")]
	public static global::DMCOCOMAJAO<T1, T2, T3> KNEDIEMGNBJ<T1, T2, T3>(T1 KPCOHIJCMJJ, T2 LHBDMGJFDFO, T3 HOEJJGLBFJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2F593F0", Offset = "0x2F57DF0", VA = "0x182F593F0")]
	internal static int FCAPHKNEKNG(int BBJKAKOPENK, int IADKLFDANDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3953000", Offset = "0x3951A00", VA = "0x183953000")]
	internal static int FCAPHKNEKNG(int BBJKAKOPENK, int IADKLFDANDB, int AGHLMILPABE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EEKMHDNGEFB<T1, T2> : IComparable<global::EEKMHDNGEFB<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T1 OMBNFJOAEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly T2 OJCDFKCKIOK;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2DA4D40", Offset = "0x2DA3740", VA = "0x182DA4D40")]
	public EEKMHDNGEFB(T1 KPCOHIJCMJJ, T2 LHBDMGJFDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2DA79C0", Offset = "0x2DA63C0", VA = "0x182DA79C0", Slot = "4")]
	public int CompareTo(global::EEKMHDNGEFB<T1, T2> CMJEBKOALJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2DA7B80", Offset = "0x2DA6580", VA = "0x182DA7B80", Slot = "0")]
	public override bool Equals(object CMJEBKOALJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2DA84C0", Offset = "0x2DA6EC0", VA = "0x182DA84C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2DA8900", Offset = "0x2DA7300", VA = "0x182DA8900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class DMCOCOMAJAO<T1, T2, T3> : IComparable<global::DMCOCOMAJAO<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly T1 OMBNFJOAEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly T2 OJCDFKCKIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly T3 LCBBPFGMGOJ;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2DA38A0", Offset = "0x2DA22A0", VA = "0x182DA38A0")]
	public DMCOCOMAJAO(T1 KPCOHIJCMJJ, T2 LHBDMGJFDFO, T3 HOEJJGLBFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2DA30C0", Offset = "0x2DA1AC0", VA = "0x182DA30C0", Slot = "4")]
	public int CompareTo(global::DMCOCOMAJAO<T1, T2, T3> CMJEBKOALJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2DA33B0", Offset = "0x2DA1DB0", VA = "0x182DA33B0", Slot = "0")]
	public override bool Equals(object CMJEBKOALJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2DA35B0", Offset = "0x2DA1FB0", VA = "0x182DA35B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2DA3620", Offset = "0x2DA2020", VA = "0x182DA3620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T KJIPGBPKLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x44E670", Offset = "0x44D070", VA = "0x18044E670")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4C2130", Offset = "0x4C0B30", VA = "0x1804C2130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float DNGCNCDLHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4E67C0", Offset = "0x4E51C0", VA = "0x1804E67C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x31C3A80", Offset = "0x31C2480", VA = "0x1831C3A80")]
	public T MDCMNLAHEOK(float NNKBIBBPOAL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x31C3D10", Offset = "0x31C2710", VA = "0x1831C3D10")]
	public T OBPDFFJLPBE(float NNKBIBBPOAL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BHFPHHGDPMO(T FLBBBEGIIKC, T CKLMPCMJGEK, float NNKBIBBPOAL);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0xA48440", Offset = "0xA46E40", VA = "0x180A48440")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3D813E0", Offset = "0x3D7FDE0", VA = "0x183D813E0", Slot = "4")]
	protected override float BHFPHHGDPMO(float FLBBBEGIIKC, float CKLMPCMJGEK, float NNKBIBBPOAL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3D81460", Offset = "0x3D7FE60", VA = "0x183D81460")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3D82150", Offset = "0x3D80B50", VA = "0x183D82150", Slot = "4")]
	protected override Vector3 BHFPHHGDPMO(Vector3 FLBBBEGIIKC, Vector3 CKLMPCMJGEK, float NNKBIBBPOAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3D82210", Offset = "0x3D80C10", VA = "0x183D82210")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x10A8FE0", Offset = "0x10A79E0", VA = "0x1810A8FE0", Slot = "4")]
	protected override Color BHFPHHGDPMO(Color FLBBBEGIIKC, Color CKLMPCMJGEK, float NNKBIBBPOAL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3D80030", Offset = "0x3D7EA30", VA = "0x183D80030")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class MBPDELHCPMF<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<TKey, TVal> CGGLAENBJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TVal, TKey> NJPGPJGABIH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int JCPPMPGPJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1CD4EA0", Offset = "0x1CD38A0", VA = "0x181CD4EA0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool CHEAJHOHHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x427E40", Offset = "0x426840", VA = "0x180427E40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ICollection<TKey> IDKJKPINCGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1F94070", Offset = "0x1F92A70", VA = "0x181F94070", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ICollection<TVal> LDKGIPBHCPI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1F940A0", Offset = "0x1F92AA0", VA = "0x181F940A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal ENGONBPMAAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1F92B90", Offset = "0x1F91590", VA = "0x181F92B90", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1F940D0", Offset = "0x1F92AD0", VA = "0x181F940D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1F93850", Offset = "0x1F92250", VA = "0x181F93850", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1F93ED0", Offset = "0x1F928D0", VA = "0x181F93ED0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1F937F0", Offset = "0x1F921F0", VA = "0x181F937F0", Slot = "9")]
	public void Add(TKey AOLPFBNJMEA, TVal MDAEJMIAMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1F93820", Offset = "0x1F92220", VA = "0x181F93820", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> EAGFLBCMGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1F938B0", Offset = "0x1F922B0", VA = "0x181F938B0", Slot = "8")]
	public bool ContainsKey(TKey AOLPFBNJMEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1F938E0", Offset = "0x1F922E0", VA = "0x181F938E0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> EAGFLBCMGPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1F93E70", Offset = "0x1F92870", VA = "0x181F93E70", Slot = "10")]
	public bool Remove(TKey AOLPFBNJMEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1F93E70", Offset = "0x1F92870", VA = "0x181F93E70", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> EAGFLBCMGPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1F93F70", Offset = "0x1F92970", VA = "0x181F93F70", Slot = "11")]
	public bool TryGetValue(TKey AOLPFBNJMEA, out TVal MDAEJMIAMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1F939A0", Offset = "0x1F923A0", VA = "0x181F939A0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1F93940", Offset = "0x1F92340", VA = "0x181F93940", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] MFDIDAMKFJA, int DEILGMBHALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1F93E40", Offset = "0x1F92840", VA = "0x181F93E40")]
	public bool ONOIJJCGCFB(TVal AOLPFBNJMEA, out TKey MDAEJMIAMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1F93DC0", Offset = "0x1F927C0", VA = "0x181F93DC0")]
	private void OFCJFAKGCHJ(TKey AOLPFBNJMEA, TVal HODMGEEDEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1F93C20", Offset = "0x1F92620", VA = "0x181F93C20")]
	private void MALGLFBAFDJ(TKey AOLPFBNJMEA, TVal HODMGEEDEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1F93B60", Offset = "0x1F92560", VA = "0x181F93B60")]
	private bool HOJKKLEILGE(TKey AOLPFBNJMEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1F93FA0", Offset = "0x1F929A0", VA = "0x181F93FA0")]
	public MBPDELHCPMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public class DEFNDHLAKJJ<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private global::DEFNDHLAKJJ<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x73ECE0", Offset = "0x73D6E0", VA = "0x18073ECE0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x352A150", Offset = "0x3528B50", VA = "0x18352A150", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x352A420", Offset = "0x3528E20", VA = "0x18352A420")]
		public Enumerator(global::DEFNDHLAKJJ<T> EKANCEBKLBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x35299C0", Offset = "0x35283C0", VA = "0x1835299C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3529E60", Offset = "0x3528860", VA = "0x183529E60", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3529810", Offset = "0x3528210", VA = "0x183529810")]
		private void LKCEGCICDAE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T[] EGBKELJKCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int PFBHAOPJJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int NKJHHDKHEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int CDLFFBAPNOH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int JCPPMPGPJJD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x351EAE0", Offset = "0x351D4E0", VA = "0x18351EAE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public T ENGONBPMAAB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x351EC20", Offset = "0x351D620", VA = "0x18351EC20")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x351F0C0", Offset = "0x351DAC0", VA = "0x18351F0C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x351F3B0", Offset = "0x351DDB0", VA = "0x18351F3B0")]
	public DEFNDHLAKJJ(int JNKPDCKMDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x351EF00", Offset = "0x351D900", VA = "0x18351EF00")]
	public void MDMPNEGHIKO(T NNKBIBBPOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x351EAC0", Offset = "0x351D4C0", VA = "0x18351EAC0")]
	public void ENEFFEHIEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x351EFB0", Offset = "0x351D9B0", VA = "0x18351EFB0")]
	public void NEHNBMLDGFB(int OLGKPPPGOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x351E820", Offset = "0x351D220", VA = "0x18351E820")]
	public void DEPDEJOHPHB(T[] MFDIDAMKFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x351E530", Offset = "0x351CF30", VA = "0x18351E530")]
	public Enumerator CNGLBEBHAKA()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x351F220", Offset = "0x351DC20", VA = "0x18351F220", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x351F220", Offset = "0x351DC20", VA = "0x18351F220", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x351E2B0", Offset = "0x351CCB0", VA = "0x18351E2B0")]
	private int ACIKHNMFFBM(int EIKINLJPKBL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x351EB20", Offset = "0x351D520", VA = "0x18351EB20")]
	private int HNNJIMBLMGP(int EIKINLJPKBL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class GDCFCDAAFHK
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
	protected GDCFCDAAFHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class BBNHDCMAIKA<T> : GDCFCDAAFHK
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	protected struct FANIGNOBNIM
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum OALFEMEBFEI
		{
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public OALFEMEBFEI DIJOHCCOMIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public T OOLHPCIPCBL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int NEALHFGIHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly bool BDDCAKMHNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	protected readonly bool IDLNPGJAGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	protected List<T> HKLLEBPNNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<FANIGNOBNIM> IFPGJGKFBJL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool BLCHDILKMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2E98D60", Offset = "0x2E97760", VA = "0x182E98D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2E99180", Offset = "0x2E97B80", VA = "0x182E99180")]
	protected BBNHDCMAIKA(bool IDLNPGJAGJJ, bool BDDCAKMHNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2E98CC0", Offset = "0x2E976C0", VA = "0x182E98CC0")]
	protected bool GFDPLKJAFDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2E990A0", Offset = "0x2E97AA0", VA = "0x182E990A0")]
	protected void PNAKDGKGNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2E98EF0", Offset = "0x2E978F0", VA = "0x182E98EF0")]
	protected void NDJOABJLCFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x249C6C0", Offset = "0x249B0C0", VA = "0x18249C6C0")]
	private static void OMHCMJGEKJB<U>(ref List<U> DNACHBDDKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2E98DA0", Offset = "0x2E977A0", VA = "0x182E98DA0", Slot = "4")]
	public void MDMPNEGHIKO(T OOLHPCIPCBL, bool EIAGDHMLJEH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2E98B80", Offset = "0x2E97580", VA = "0x182E98B80", Slot = "5")]
	public void FIAJBIFJEOJ(T OOLHPCIPCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2E98A50", Offset = "0x2E97450", VA = "0x182E98A50")]
	public void ENEFFEHIEKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class EMHINGNNCEH : global::BBNHDCMAIKA<Action>
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3D81380", Offset = "0x3D7FD80", VA = "0x183D81380")]
	public EMHINGNNCEH(bool IDLNPGJAGJJ = false, bool BDDCAKMHNLB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3D81170", Offset = "0x3D7FB70", VA = "0x183D81170")]
	public void FLILEAELALF()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3D81110", Offset = "0x3D7FB10", VA = "0x183D81110")]
	public static EMHINGNNCEH EALHGNEGLFD(EMHINGNNCEH HDOGJGNPAHH, Action OOLHPCIPCBL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3D81320", Offset = "0x3D7FD20", VA = "0x183D81320")]
	public static EMHINGNNCEH OGCCMMCAJAC(EMHINGNNCEH HDOGJGNPAHH, Action OOLHPCIPCBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface DEACDHPCKGG<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDMPNEGHIKO(Action<T> OOLHPCIPCBL, bool EIAGDHMLJEH = false);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIAJBIFJEOJ(Action<T> OOLHPCIPCBL);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class CDIFFIEGHBE<T> : global::BBNHDCMAIKA<Action<T>>, global::DEACDHPCKGG<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DAD0", Offset = "0x1F9C4D0", VA = "0x181F9DAD0")]
	public CDIFFIEGHBE(bool IDLNPGJAGJJ = false, bool BDDCAKMHNLB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x20BA030", Offset = "0x20B8A30", VA = "0x1820BA030")]
	public void FLILEAELALF(T NNKBIBBPOAL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D3B0", Offset = "0x1F9BDB0", VA = "0x181F9D3B0")]
	public static global::CDIFFIEGHBE<T> EALHGNEGLFD(global::CDIFFIEGHBE<T> HDOGJGNPAHH, Action<T> OOLHPCIPCBL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DA30", Offset = "0x1F9C430", VA = "0x181F9DA30")]
	public static global::CDIFFIEGHBE<T> OGCCMMCAJAC(global::CDIFFIEGHBE<T> HDOGJGNPAHH, Action<T> OOLHPCIPCBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JNPCPHLFOJI<T, U>
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class AEDHBMHMEAL<T, U> : global::BBNHDCMAIKA<Action<T, U>>, global::JNPCPHLFOJI<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DAD0", Offset = "0x1F9C4D0", VA = "0x181F9DAD0")]
	public AEDHBMHMEAL(bool IDLNPGJAGJJ = false, bool BDDCAKMHNLB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x310FF00", Offset = "0x310E900", VA = "0x18310FF00")]
	public void FLILEAELALF(T NNKBIBBPOAL, U AFLIPGODIKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D3B0", Offset = "0x1F9BDB0", VA = "0x181F9D3B0")]
	public static global::AEDHBMHMEAL<T, U> EALHGNEGLFD(global::AEDHBMHMEAL<T, U> HDOGJGNPAHH, Action<T, U> OOLHPCIPCBL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DA30", Offset = "0x1F9C430", VA = "0x181F9DA30")]
	public static global::AEDHBMHMEAL<T, U> OGCCMMCAJAC(global::AEDHBMHMEAL<T, U> HDOGJGNPAHH, Action<T, U> OOLHPCIPCBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class OKPBBGCIKIM<T, U, V> : global::BBNHDCMAIKA<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DAD0", Offset = "0x1F9C4D0", VA = "0x181F9DAD0")]
	public OKPBBGCIKIM(bool IDLNPGJAGJJ = false, bool BDDCAKMHNLB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3357010", Offset = "0x3355A10", VA = "0x183357010")]
	public void FLILEAELALF(T NNKBIBBPOAL, U AFLIPGODIKF, V PDFDDLDMBCH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D3B0", Offset = "0x1F9BDB0", VA = "0x181F9D3B0")]
	public static global::OKPBBGCIKIM<T, U, V> EALHGNEGLFD(global::OKPBBGCIKIM<T, U, V> HDOGJGNPAHH, Action<T, U, V> OOLHPCIPCBL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DA30", Offset = "0x1F9C430", VA = "0x181F9DA30")]
	public static global::OKPBBGCIKIM<T, U, V> OGCCMMCAJAC(global::OKPBBGCIKIM<T, U, V> HDOGJGNPAHH, Action<T, U, V> OOLHPCIPCBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LNGLDKBJPHM<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class PLOCBBKIBOL<T, U, V, W> : global::BBNHDCMAIKA<Action<T, U, V, W>>, global::LNGLDKBJPHM<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DAD0", Offset = "0x1F9C4D0", VA = "0x181F9DAD0")]
	public PLOCBBKIBOL(bool IDLNPGJAGJJ = false, bool BDDCAKMHNLB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2EEBD00", Offset = "0x2EEA700", VA = "0x182EEBD00")]
	public void FLILEAELALF(T NNKBIBBPOAL, U AFLIPGODIKF, V PDFDDLDMBCH, W EBPKCMGAIBJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D3B0", Offset = "0x1F9BDB0", VA = "0x181F9D3B0")]
	public static global::PLOCBBKIBOL<T, U, V, W> EALHGNEGLFD(global::PLOCBBKIBOL<T, U, V, W> HDOGJGNPAHH, Action<T, U, V, W> OOLHPCIPCBL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DA30", Offset = "0x1F9C430", VA = "0x181F9DA30")]
	public static global::PLOCBBKIBOL<T, U, V, W> OGCCMMCAJAC(global::PLOCBBKIBOL<T, U, V, W> HDOGJGNPAHH, Action<T, U, V, W> OOLHPCIPCBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class MLNMCCFIAJK<T, U, V, W, X> : global::BBNHDCMAIKA<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DAD0", Offset = "0x1F9C4D0", VA = "0x181F9DAD0")]
	public MLNMCCFIAJK(bool IDLNPGJAGJJ = false, bool BDDCAKMHNLB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D770", Offset = "0x1F9C170", VA = "0x181F9D770")]
	public void FLILEAELALF(T NNKBIBBPOAL, U AFLIPGODIKF, V PDFDDLDMBCH, W EBPKCMGAIBJ, X IDCEIHIONGP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D3B0", Offset = "0x1F9BDB0", VA = "0x181F9D3B0")]
	public static global::MLNMCCFIAJK<T, U, V, W, X> EALHGNEGLFD(global::MLNMCCFIAJK<T, U, V, W, X> HDOGJGNPAHH, Action<T, U, V, W, X> OOLHPCIPCBL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DA30", Offset = "0x1F9C430", VA = "0x181F9DA30")]
	public static global::MLNMCCFIAJK<T, U, V, W, X> OGCCMMCAJAC(global::MLNMCCFIAJK<T, U, V, W, X> HDOGJGNPAHH, Action<T, U, V, W, X> OOLHPCIPCBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class BAKIJOIKLGG<T, U, V, W, X, Y> : global::BBNHDCMAIKA<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DAD0", Offset = "0x1F9C4D0", VA = "0x181F9DAD0")]
	public BAKIJOIKLGG(bool IDLNPGJAGJJ = false, bool BDDCAKMHNLB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2E98430", Offset = "0x2E96E30", VA = "0x182E98430")]
	public void FLILEAELALF(T NNKBIBBPOAL, U AFLIPGODIKF, V PDFDDLDMBCH, W EBPKCMGAIBJ, X IDCEIHIONGP, Y ADCOBJDHEMO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D3B0", Offset = "0x1F9BDB0", VA = "0x181F9D3B0")]
	public static global::BAKIJOIKLGG<T, U, V, W, X, Y> EALHGNEGLFD(global::BAKIJOIKLGG<T, U, V, W, X, Y> HDOGJGNPAHH, Action<T, U, V, W, X, Y> OOLHPCIPCBL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DA30", Offset = "0x1F9C430", VA = "0x181F9DA30")]
	public static global::BAKIJOIKLGG<T, U, V, W, X, Y> OGCCMMCAJAC(global::BAKIJOIKLGG<T, U, V, W, X, Y> HDOGJGNPAHH, Action<T, U, V, W, X, Y> OOLHPCIPCBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class IADNLNGJBHP<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate bool NBBKCLHMAHB(global::IADNLNGJBHP<T> EEPFHMANNLB);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class FKLBOILNCFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public global::IADNLNGJBHP<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA48440", Offset = "0xA46E40", VA = "0x180A48440")]
		public FKLBOILNCFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2D40A50", Offset = "0x2D3F450", VA = "0x182D40A50")]
		internal bool <FindNode>b__0(global::IADNLNGJBHP<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public T ILAODMFEJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public LinkedList<global::IADNLNGJBHP<T>> HOFAIJMGMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public global::IADNLNGJBHP<T> GGLHCBNGJAC;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public global::IADNLNGJBHP<T> IPIJCOPIOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4958A0", Offset = "0x4942A0", VA = "0x1804958A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2D42350", Offset = "0x2D40D50", VA = "0x182D42350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool FLJBDBIEPPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2D43B00", Offset = "0x2D42500", VA = "0x182D43B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool ELHOAADJNCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2D42B10", Offset = "0x2D41510", VA = "0x182D42B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public global::IADNLNGJBHP<T> BLBJDONJLMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2D42A90", Offset = "0x2D41490", VA = "0x182D42A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2D44800", Offset = "0x2D43200", VA = "0x182D44800")]
	public IADNLNGJBHP(T FJOMPBIHPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2D44650", Offset = "0x2D43050", VA = "0x182D44650")]
	public global::IADNLNGJBHP<T> PHBAIPEJLOE(T LGLAFAAIMDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2D43930", Offset = "0x2D42330", VA = "0x182D43930")]
	public global::IADNLNGJBHP<T> KIJJPFHAGMO(T EPANBCIMNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2D42C20", Offset = "0x2D41620", VA = "0x182D42C20")]
	public global::IADNLNGJBHP<T> FIAJBIFJEOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2D425F0", Offset = "0x2D40FF0", VA = "0x182D425F0")]
	public void ENEFFEHIEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2D424E0", Offset = "0x2D40EE0", VA = "0x182D424E0")]
	public global::IADNLNGJBHP<T> DDPBABKKMBH(T EEJNELMJNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2D43010", Offset = "0x2D41A10", VA = "0x182D43010")]
	public static void HELJMHGPCBM(global::IADNLNGJBHP<T> JELKLDGECEM, NBBKCLHMAHB IPFHANEAHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x218EE30", Offset = "0x218D830", VA = "0x18218EE30")]
	public static void HELJMHGPCBM<A>(global::IADNLNGJBHP<T> JELKLDGECEM, Func<global::IADNLNGJBHP<T>, A, bool> IPFHANEAHNC, A APNEMKFCDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2D44050", Offset = "0x2D42A50", VA = "0x182D44050")]
	public static string PAIHNNPHMAJ(global::IADNLNGJBHP<T> JELKLDGECEM, int LAOBEMNJLOH = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2D43550", Offset = "0x2D41F50", VA = "0x182D43550")]
	public static global::IADNLNGJBHP<T> JAFEIBJMPDK(global::IADNLNGJBHP<T> JELKLDGECEM, T PFBOPFIEDPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class NIJNMFPGPEL<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate int MOAJMMHFJFB(TKey AOLPFBNJMEA, TVal MDAEJMIAMDO);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private class MPBDKBDAOFH
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public TKey PBPONIOKHGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x4271A0", Offset = "0x425BA0", VA = "0x1804271A0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public TVal KJIPGBPKLDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x5BE4C0", Offset = "0x5BCEC0", VA = "0x1805BE4C0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x5BE7E0", Offset = "0x5BD1E0", VA = "0x1805BE7E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int CBBLPKBABFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x61A970", Offset = "0x619370", VA = "0x18061A970")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x61A990", Offset = "0x619390", VA = "0x18061A990")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public DateTime ELEFONMMMIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x429CF0", Offset = "0x4286F0", VA = "0x180429CF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x4507D0", Offset = "0x44F1D0", VA = "0x1804507D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x312F030", Offset = "0x312DA30", VA = "0x18312F030")]
		public MPBDKBDAOFH(TKey AOLPFBNJMEA, TVal HODMGEEDEKD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const int GIBAEKIEBIK = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Dictionary<TKey, LinkedListNode<MPBDKBDAOFH>> EEIFOGGODGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly LinkedList<MPBDKBDAOFH> JAMCGEDCPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly MOAJMMHFJFB AHJHDKJCNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly TimeSpan OMPHOBNJKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly PIDFGHCJHON BHLKBMNJJHH;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int MDMNNLMNDBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x545110", Offset = "0x543B10", VA = "0x180545110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool KHCFGIGEBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B40D10", Offset = "0x2B3F710", VA = "0x182B40D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal int KINCLAIEBEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x556C80", Offset = "0x555680", VA = "0x180556C80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x663E70", Offset = "0x662870", VA = "0x180663E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey ENGONBPMAAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B410F0", Offset = "0x2B3FAF0", VA = "0x182B410F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2B412C0", Offset = "0x2B3FCC0", VA = "0x182B412C0")]
	public NIJNMFPGPEL(int JNKPDCKMDII, [Optional] MOAJMMHFJFB AHJHDKJCNDO, [Optional] IEqualityComparer<TKey> EBMHHHMCCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x313C4B0", Offset = "0x313AEB0", VA = "0x18313C4B0")]
	public NIJNMFPGPEL(int JNKPDCKMDII, MOAJMMHFJFB AHJHDKJCNDO, TimeSpan OMPHOBNJKDF, [Optional] IEqualityComparer<TKey> EBMHHHMCCBA, [Optional] PIDFGHCJHON BHLKBMNJJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2B40870", Offset = "0x2B3F270", VA = "0x182B40870")]
	public void IIHFJACCOKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x313BE20", Offset = "0x313A820", VA = "0x18313BE20")]
	public void JKEIGHEEKBL(TKey AOLPFBNJMEA, TVal MDAEJMIAMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2B406F0", Offset = "0x2B3F0F0", VA = "0x182B406F0")]
	public bool FIAJBIFJEOJ(TKey AOLPFBNJMEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2B40FA0", Offset = "0x2B3F9A0", VA = "0x182B40FA0")]
	public bool ONOIJJCGCFB(TKey BOANLGEPAEO, out TVal MDAEJMIAMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2B405B0", Offset = "0x2B3EFB0", VA = "0x182B405B0")]
	public void ENEFFEHIEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x313BAE0", Offset = "0x313A4E0", VA = "0x18313BAE0")]
	private bool FAEFFFKDBMO(MPBDKBDAOFH CELBIAILGHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x313BBA0", Offset = "0x313A5A0", VA = "0x18313BBA0")]
	private void JJGEIMCPDNC(LinkedListNode<MPBDKBDAOFH> GFAPEJLNECM, TVal LNKMEGOAEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x313BEE0", Offset = "0x313A8E0", VA = "0x18313BEE0")]
	private void LPBCDCAONMA(TKey AOLPFBNJMEA, TVal MDAEJMIAMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x313C240", Offset = "0x313AC40", VA = "0x18313C240")]
	private void PNHDIGOIDAJ(MPBDKBDAOFH CELBIAILGHB, TVal LNKMEGOAEOI, int PDBCNFAJOGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public class NIFIOCPPDFE<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly List<T> DNACHBDDKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private HashSet<T> IBGKEIJGNBL;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int JCPPMPGPJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1CD4EA0", Offset = "0x1CD38A0", VA = "0x181CD4EA0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool CHEAJHOHHML
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x427E40", Offset = "0x426840", VA = "0x180427E40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T ENGONBPMAAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA4A5D0", Offset = "0xA48FD0", VA = "0x180A4A5D0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x313B960", Offset = "0x313A360", VA = "0x18313B960", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2D41780", Offset = "0x2D40180", VA = "0x182D41780", Slot = "11")]
	public void Add(T EAGFLBCMGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x313B560", Offset = "0x3139F60", VA = "0x18313B560")]
	public bool PICLHMELHNM(T EAGFLBCMGPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x313B850", Offset = "0x313A250", VA = "0x18313B850", Slot = "15")]
	public bool Remove(T EAGFLBCMGPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x20B1BB0", Offset = "0x20B05B0", VA = "0x1820B1BB0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2F154F0", Offset = "0x2F13EF0", VA = "0x182F154F0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x313B340", Offset = "0x3139D40", VA = "0x18313B340", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0xA4F5A0", Offset = "0xA4DFA0", VA = "0x180A4F5A0", Slot = "13")]
	public bool Contains(T EAGFLBCMGPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x313B3A0", Offset = "0x3139DA0", VA = "0x18313B3A0", Slot = "14")]
	public void CopyTo(T[] MFDIDAMKFJA, int DEILGMBHALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1F92B90", Offset = "0x1F91590", VA = "0x181F92B90", Slot = "6")]
	public int IndexOf(T EAGFLBCMGPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x313B3D0", Offset = "0x3139DD0", VA = "0x18313B3D0", Slot = "7")]
	public void Insert(int EIKINLJPKBL, T EAGFLBCMGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x313B6B0", Offset = "0x313A0B0", VA = "0x18313B6B0", Slot = "8")]
	public void RemoveAt(int EIKINLJPKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2F07750", Offset = "0x2F06150", VA = "0x182F07750")]
	public NIFIOCPPDFE()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x2112470", Offset = "0x2110E70", VA = "0x182112470")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3D82120", Offset = "0x3D80B20", VA = "0x183D82120")]
		public SerializedGuid(in Guid DJMDFHMKGLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3D81DD0", Offset = "0x3D807D0", VA = "0x183D81DD0")]
		public static SerializedGuid EIANNFHONDB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3D81FE0", Offset = "0x3D809E0", VA = "0x183D81FE0")]
		public static SerializedGuid OMOBAAJAMBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3D81D10", Offset = "0x3D80710", VA = "0x183D81D10")]
		public bool AOMBPPIAKCH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3D82100", Offset = "0x3D80B00", VA = "0x183D82100", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3D82060", Offset = "0x3D80A60", VA = "0x183D82060", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3D81E50", Offset = "0x3D80850", VA = "0x183D81E50", Slot = "7")]
		public bool Equals(SerializedGuid CMJEBKOALJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3D81EF0", Offset = "0x3D808F0", VA = "0x183D81EF0", Slot = "0")]
		public override bool Equals(object AEFCLOMAMKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3D81FD0", Offset = "0x3D809D0", VA = "0x183D81FD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D81DA0", Offset = "0x3D807A0", VA = "0x183D81DA0", Slot = "6")]
		public int CompareTo(SerializedGuid CMJEBKOALJE)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class COGNHKPAOMJ : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly Type LLMCMHPLGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly string PGPMEPOIDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool MKGPMOEBJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly bool HAKANKMNKDG;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3D7FFD0", Offset = "0x3D7E9D0", VA = "0x183D7FFD0")]
	public COGNHKPAOMJ(Type DBGCHIIGHKD, string GPNNCNDEMJP, bool LDGJPIBINFB = false, bool JFKGHPEBHON = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface GIJGKGKEDFN<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	T KJIPGBPKLDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool AKJJBNDJGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::GIJGKGKEDFN<T> HNNIOEMGLCE(Action<T> FCGCCNCLPDM);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::GIJGKGKEDFN<T> BOBCNPHLCKG(Action<T> FCGCCNCLPDM);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class HDPLDCCKGIN<T> : global::GIJGKGKEDFN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private global::AEDHBMHMEAL<T, T> PCEENIJFIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private global::CDIFFIEGHBE<T> DMFJDDCJDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private global::CDIFFIEGHBE<string> KDLDAGPFNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private string PFPOFNKJBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private T ANEPELFNGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool GKECLKCPDCJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T KJIPGBPKLDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x44E670", Offset = "0x44D070", VA = "0x18044E670", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x21C1580", Offset = "0x21BFF80", VA = "0x1821C1580", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool AKJJBNDJGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x487EA0", Offset = "0x4868A0", VA = "0x180487EA0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x331D4F0", Offset = "0x331BEF0", VA = "0x18331D4F0")]
	private void KGFOAJPEOIL(T LEAHBAHGOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x331D470", Offset = "0x331BE70", VA = "0x18331D470", Slot = "4")]
	public global::GIJGKGKEDFN<T> HNNIOEMGLCE(Action<T> EJGMCNMKBFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x331D440", Offset = "0x331BE40", VA = "0x18331D440", Slot = "5")]
	public global::GIJGKGKEDFN<T> BOBCNPHLCKG(Action<T> FCGCCNCLPDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x331D570", Offset = "0x331BF70", VA = "0x18331D570")]
	public HDPLDCCKGIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class ECEOGBJMEFG
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class DNLAMPBABDB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public global::GIJGKGKEDFN<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public global::AILNGNLEFKP<T> promise;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA48440", Offset = "0xA46E40", VA = "0x180A48440")]
		public DNLAMPBABDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2DA38F0", Offset = "0x2DA22F0", VA = "0x182DA38F0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x24D67E0", Offset = "0x24D51E0", VA = "0x1824D67E0")]
	public static global::GDHDNGFJPDI<T> DLIHKELJPHA<T>(this global::GIJGKGKEDFN<T> FGDBECMFLGH, Action<T> OPOGBFLEIMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public abstract class PIDFGHCJHON
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class EHFJMGOFKJL : PIDFGHCJHON
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static PIDFGHCJHON FOFECEPFNIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x3D80F70", Offset = "0x3D7F970", VA = "0x183D80F70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override DateTime FEHOEJAMGNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x3D80FD0", Offset = "0x3D7F9D0", VA = "0x183D80FD0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3D810B0", Offset = "0x3D7FAB0", VA = "0x183D810B0")]
		public EHFJMGOFKJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static PIDFGHCJHON JFLENDFCKGH;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static PIDFGHCJHON ANNFOKCLLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3D81830", Offset = "0x3D80230", VA = "0x183D81830")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract DateTime FEHOEJAMGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
	protected PIDFGHCJHON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class BDJAMANPNLA : global::EEBKPMGCNJL<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3D7FB80", Offset = "0x3D7E580", VA = "0x183D7FB80")]
	public BDJAMANPNLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class EEBKPMGCNJL<T> : global::CFCGMKKEGMC<T>, FMCDDABFPDJ, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Task<T> EJLCIMDNJOA
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4271A0", Offset = "0x425BA0", VA = "0x1804271A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public global::GDHDNGFJPDI<T> EEFOGABAACH
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private OJNMJAKAOEK HIGMHJAAIOI
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1CD28D0", Offset = "0x1CD12D0", VA = "0x181CD28D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2DA7520", Offset = "0x2DA5F20", VA = "0x182DA7520")]
	public EEBKPMGCNJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class NNENCDEJIKI<T> : global::CFCGMKKEGMC<T>, FMCDDABFPDJ, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Task<T> EJLCIMDNJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4271A0", Offset = "0x425BA0", VA = "0x1804271A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public global::GDHDNGFJPDI<T> EEFOGABAACH
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private OJNMJAKAOEK HIGMHJAAIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x1CD28D0", Offset = "0x1CD12D0", VA = "0x181CD28D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2B48EA0", Offset = "0x2B478A0", VA = "0x182B48EA0")]
	public NNENCDEJIKI(Exception HIHCHEKBDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface FMCDDABFPDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	[NotNull]
	OJNMJAKAOEK EEFOGABAACH
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface CFCGMKKEGMC<T> : FMCDDABFPDJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[NotNull]
	Task<T> EJLCIMDNJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	new global::GDHDNGFJPDI<T> EEFOGABAACH
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class FBMKDPILKKN<TTask, T> : global::CFCGMKKEGMC<T>, FMCDDABFPDJ, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class PGKGALGHAEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public global::FBMKDPILKKN<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public TTask task;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA48440", Offset = "0xA46E40", VA = "0x180A48440")]
		public PGKGALGHAEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class BMGBJKJLNBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public PGKGALGHAEN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA48440", Offset = "0xA46E40", VA = "0x180A48440")]
		public BMGBJKJLNBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2F0ECA0", Offset = "0x2F0D6A0", VA = "0x182F0ECA0")]
		internal T <.ctor>b__0(Task t)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static bool NHBILDKOPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly global::AILNGNLEFKP<T> NMGBPABMION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Task<T> ODOAMNOAJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly CancellationTokenSource KOKKEAHCNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool DKOHABBPODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private SynchronizationContext HDCALMJIEEP;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task<T> EJLCIMDNJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public global::GDHDNGFJPDI<T> EEFOGABAACH
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4271A0", Offset = "0x425BA0", VA = "0x1804271A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private OJNMJAKAOEK HIGMHJAAIOI
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4271A0", Offset = "0x425BA0", VA = "0x1804271A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool FKEGPJNDADI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x487ED0", Offset = "0x4868D0", VA = "0x180487ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2F124B0", Offset = "0x2F10EB0", VA = "0x182F124B0")]
	static FBMKDPILKKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2F12870", Offset = "0x2F11270", VA = "0x182F12870")]
	protected FBMKDPILKKN(TTask ODOAMNOAJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2F11EA0", Offset = "0x2F108A0", VA = "0x182F11EA0", Slot = "1")]
	~FBMKDPILKKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2F11E70", Offset = "0x2F10870", VA = "0x182F11E70", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2F12150", Offset = "0x2F10B50", VA = "0x182F12150")]
	private void IECPGPMNMCA(bool IKFGIONDCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T INCBDANMCHP(TTask OGBOLABOKBO);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract void KJLMBJEHEJP();

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2F11CA0", Offset = "0x2F106A0", VA = "0x182F11CA0")]
	protected void AHKHNHNIGEO(T LEAHBAHGOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2F122C0", Offset = "0x2F10CC0", VA = "0x182F122C0")]
	protected void ODDMMCIFHEK(string PFPOFNKJBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2F11DD0", Offset = "0x2F107D0", VA = "0x182F11DD0")]
	[CompilerGenerated]
	private void DBLAGMPGJEN(object KMBAPMNLHOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class NJIGAEGHJOA<T> : IEnumerable<global::NJIGAEGHJOA<T>.FLPLBPOMCBB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct FLPLBPOMCBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public T MDAEJMIAMDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int EIKINLJPKBL;
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class MKLMECDHPPL : IEnumerator<FLPLBPOMCBB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::NJIGAEGHJOA<T> HKCLEKBIILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int EIKINLJPKBL;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x2721C60", Offset = "0x2720660", VA = "0x182721C60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public FLPLBPOMCBB JMFHABLLKKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x2B40120", Offset = "0x2B3EB20", VA = "0x182B40120", Slot = "4")]
			get
			{
				return default(FLPLBPOMCBB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x773070", Offset = "0x771A70", VA = "0x180773070")]
		public MKLMECDHPPL(global::NJIGAEGHJOA<T> HKCLEKBIILA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x2B40090", Offset = "0x2B3EA90", VA = "0x182B40090", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6D67F0", Offset = "0x6D51F0", VA = "0x1806D67F0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x90B1E0", Offset = "0x909BE0", VA = "0x18090B1E0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private struct NJGIMMGPEAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public bool CLFHKGICMML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public T MDAEJMIAMDO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private const int DKPHDJDIJMM = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private Dictionary<T, int> JNCNDOJLADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NJGIMMGPEAF[] GDEKAMJGFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int BKEAPDAOCFL;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int JCPPMPGPJJD
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1F94070", Offset = "0x1F92A70", VA = "0x181F94070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2B416C0", Offset = "0x2B400C0", VA = "0x182B416C0")]
	public static global::NJIGAEGHJOA<T> IHIPAIKAHLP(FLPLBPOMCBB[] OAGCHFEMBKG, bool FLCGGKPAOOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2B41E70", Offset = "0x2B40870", VA = "0x182B41E70")]
	public NJIGAEGHJOA(int JNKPDCKMDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2B41BC0", Offset = "0x2B405C0", VA = "0x182B41BC0")]
	public int NOMMCIMEHNB(T MDAEJMIAMDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2B41650", Offset = "0x2B40050", VA = "0x182B41650")]
	public T DLIHKELJPHA(int EIKINLJPKBL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2B41DE0", Offset = "0x2B407E0", VA = "0x182B41DE0")]
	public bool PICLHMELHNM(T MDAEJMIAMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2B41C10", Offset = "0x2B40610", VA = "0x182B41C10")]
	public bool PICLHMELHNM(T MDAEJMIAMDO, int EIKINLJPKBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2B41A80", Offset = "0x2B40480", VA = "0x182B41A80")]
	public FLPLBPOMCBB[] MFHMDLJMPOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2B41600", Offset = "0x2B40000", VA = "0x182B41600")]
	private int APEPLEHDFJM(int PFBHAOPJJFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x2B41E00", Offset = "0x2B40800", VA = "0x182B41E00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2B41E00", Offset = "0x2B40800", VA = "0x182B41E00", Slot = "4")]
	private IEnumerator<FLPLBPOMCBB> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class LOCGDNMDDIM<T> where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private List<T> FMCBOMNCIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<T> AEILNPCNKNM;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1F91F40", Offset = "0x1F90940", VA = "0x181F91F40")]
	public LOCGDNMDDIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1F91DE0", Offset = "0x1F907E0", VA = "0x181F91DE0")]
	public LOCGDNMDDIM(int JNKPDCKMDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1F91CE0", Offset = "0x1F906E0", VA = "0x181F91CE0")]
	public T KPMGHJGDLDC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x1F91BC0", Offset = "0x1F905C0", VA = "0x181F91BC0")]
	public void EFOILKKOJFG(T BCKGJACLPMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class PADOKHNAPOG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private Dictionary<int, T> NNJAJJFLLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private T KIOEECFBIHM;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public virtual T APPMBDBALJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x427450", Offset = "0x425E50", VA = "0x180427450", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2EE8CE0", Offset = "0x2EE76E0", VA = "0x182EE8CE0")]
	public bool LPBCDCAONMA(T MDAEJMIAMDO, int KNJCFEFJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x2EE85B0", Offset = "0x2EE6FB0", VA = "0x182EE85B0")]
	public bool EIJEJMNEAKK(int KNJCFEFJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2EE8A20", Offset = "0x2EE7420", VA = "0x182EE8A20")]
	public T HFPLBPKPKOF(int GKIBDLPONBI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2EE8610", Offset = "0x2EE7010", VA = "0x182EE8610")]
	private bool ELPEDCMJAMJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2EE8D40", Offset = "0x2EE7740", VA = "0x182EE8D40")]
	public bool ONOIJJCGCFB(int KNJCFEFJAPN, out T MDAEJMIAMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2EE8D70", Offset = "0x2EE7770", VA = "0x182EE8D70")]
	public PADOKHNAPOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class JADNKEFFCOK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	protected struct KDLJNDPJFEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public T KJIPGBPKLDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int BEJNCJJCMCB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	protected readonly List<KDLJNDPJFEN> EGBKELJKCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private T LKJGCFJLPNA;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int JCPPMPGPJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x1CD4EA0", Offset = "0x1CD38A0", VA = "0x181CD4EA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3081920", Offset = "0x3080320", VA = "0x183081920")]
	public bool CGMDOCCGPIP(T MDAEJMIAMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3081D80", Offset = "0x3080780", VA = "0x183081D80")]
	public void MDMPNEGHIKO(T MDAEJMIAMDO, int KNJCFEFJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3081BD0", Offset = "0x30805D0", VA = "0x183081BD0")]
	public bool FIAJBIFJEOJ(T MDAEJMIAMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3081B70", Offset = "0x3080570", VA = "0x183081B70")]
	public void ENEFFEHIEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3081CF0", Offset = "0x30806F0", VA = "0x183081CF0")]
	public T LFABDNHFCMD()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3081710", Offset = "0x3080110", VA = "0x183081710")]
	private void BBFKNNLFFKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3081E00", Offset = "0x3080800", VA = "0x183081E00")]
	public JADNKEFFCOK()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6880", Offset = "0x1CE5280", VA = "0x181CE6880", Slot = "4")]
		public virtual T NHCNHLGGBFB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA48440", Offset = "0xA46E40", VA = "0x180A48440")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class DCODKANCMCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<byte, CACDJJAJAKB> ONLDIGIJGLM;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public CACDJJAJAKB AJCGCODGOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x4271A0", Offset = "0x425BA0", VA = "0x1804271A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x427440", Offset = "0x425E40", VA = "0x180427440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Vector2 GGMGOBFCGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x1385D60", Offset = "0x1384760", VA = "0x181385D60")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x20437F0", Offset = "0x20421F0", VA = "0x1820437F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private Vector2 JGIBCJBINNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x72E990", Offset = "0x72D390", VA = "0x18072E990")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Vector2 MOCOGEJLBCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x303A290", Offset = "0x3038C90", VA = "0x18303A290")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x303A2B0", Offset = "0x3038CB0", VA = "0x18303A2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int JPJODEDEGKN
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x4511B0", Offset = "0x44FBB0", VA = "0x1804511B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x476360", Offset = "0x474D60", VA = "0x180476360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3D80810", Offset = "0x3D7F210", VA = "0x183D80810")]
	public DCODKANCMCH(Bounds CEGFHAAFECM, Vector2[] IGGEKPAECBE, int CHHIGILJEEB, byte PFBHAOPJJFA, float LGAHANKPBFJ = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3D80190", Offset = "0x3D7EB90", VA = "0x183D80190")]
	public CACDJJAJAKB BHBOHDALOAL(byte EIKINLJPKBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3D80210", Offset = "0x3D7EC10", VA = "0x183D80210")]
	public void LNDNHBOLHNB(Vector3 BCMMMEIBPFI, float PKMOOBNEJEP, float ADGPDACFOLN, ref List<byte> FCAPKKBOILA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3D801F0", Offset = "0x3D7EBF0", VA = "0x183D801F0")]
	public void LMNOEMICNAK(CACDJJAJAKB.OFOPBBAEOLA OFMLGGCNBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3D80070", Offset = "0x3D7EA70", VA = "0x183D80070")]
	private CACDJJAJAKB APFDNAFBIDA(byte EIKINLJPKBL, CACDJJAJAKB.JMAKKLMJEDN CBMPBJOJOGC, CACDJJAJAKB PDMALPKAHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3D802F0", Offset = "0x3D7ECF0", VA = "0x183D802F0")]
	private void LNPGDABNNBP(CACDJJAJAKB PDMALPKAHLK, Vector2[] IGGEKPAECBE, int OCPLKPMJLCL, int BLHBINLLKBH, int IBJMIJEKKPB, int PGEECLIFGKH, float LGAHANKPBFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class CACDJJAJAKB
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public enum JMAKKLMJEDN
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum OFOPBBAEOLA
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public byte FEMLPHBAMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Vector3 ECICJOKPHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Vector3 CBBLPKBABFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Vector3 PKJOHCFPNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Vector3 JLEFBEPEIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public JMAKKLMJEDN PPGHBPIGHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public CACDJJAJAKB IPIJCOPIOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public List<CACDJJAJAKB> ILIJCHNKGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public bool IEJDMKDOIMA;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3D7FF80", Offset = "0x3D7E980", VA = "0x183D7FF80")]
	public CACDJJAJAKB(byte EKIIKIKCLJI, JMAKKLMJEDN CBMPBJOJOGC, CACDJJAJAKB PDMALPKAHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3D7FEB0", Offset = "0x3D7E8B0", VA = "0x183D7FEB0")]
	public void PHBAIPEJLOE(CACDJJAJAKB LJIGPMINKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00")]
	public void LMNOEMICNAK(int GPAGOPDFMJO, OFOPBBAEOLA OFMLGGCNBEK, int GPNDOEMKLIC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3D7FC20", Offset = "0x3D7E620", VA = "0x183D7FC20")]
	public void LNDNHBOLHNB(List<byte> FCAPKKBOILA, Vector3 BCMMMEIBPFI, float PKMOOBNEJEP, float ADGPDACFOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3D7FBC0", Offset = "0x3D7E5C0", VA = "0x183D7FBC0")]
	public bool HEGGJEHLEEA(Vector3 KJGGEMFNJDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3D7FF40", Offset = "0x3D7E940", VA = "0x183D7FF40")]
	public bool PMAGFPEFMBH(Vector3 KJGGEMFNJDK, float JLNFJDODHEG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class CCPHPABDOAK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private int JNKPDCKMDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int APILEIMHDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private List<T> JFDDDGFCNLN;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public T BLKPCMKEEFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x20B77A0", Offset = "0x20B61A0", VA = "0x1820B77A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public T GMDBDAKOFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x20B78C0", Offset = "0x20B62C0", VA = "0x1820B78C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public T KAJCKJDPBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x20B7C60", Offset = "0x20B6660", VA = "0x1820B7C60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x20B7D10", Offset = "0x20B6710", VA = "0x1820B7D10")]
	public CCPHPABDOAK(int JNKPDCKMDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x20B7AB0", Offset = "0x20B64B0", VA = "0x1820B7AB0")]
	public void MDMPNEGHIKO(T IHDDFMIMOMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x20B7760", Offset = "0x20B6160", VA = "0x1820B7760")]
	public void ENEFFEHIEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x20B7CC0", Offset = "0x20B66C0", VA = "0x1820B7CC0")]
	public void PAJCCOCNJDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x20B7CB0", Offset = "0x20B66B0", VA = "0x1820B7CB0")]
	public void OEBCOJMGGCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class KJFIABLPOAI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private struct MNBGENFPLHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int BEJNCJJCMCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public T KJIPGBPKLDI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Dictionary<object, MNBGENFPLHC> NNJAJJFLLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private T KIOEECFBIHM;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public virtual T APPMBDBALJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x1385D60", Offset = "0x1384760", VA = "0x181385D60", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x20437F0", Offset = "0x20421F0", VA = "0x1820437F0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool DLOEGPBPDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2045510", Offset = "0x2043F10", VA = "0x182045510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public object MBHDLMICMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x429CF0", Offset = "0x4286F0", VA = "0x180429CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x4507D0", Offset = "0x44F1D0", VA = "0x1804507D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x222F1C0", Offset = "0x222DBC0", VA = "0x18222F1C0")]
	public bool LPBCDCAONMA(T MDAEJMIAMDO, object AHLEOHFEOPA, int KNJCFEFJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2043860", Offset = "0x2042260", VA = "0x182043860")]
	public bool EIJEJMNEAKK(object AHLEOHFEOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2045990", Offset = "0x2044390", VA = "0x182045990")]
	public bool ONOIJJCGCFB(object AHLEOHFEOPA, out T MDAEJMIAMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x20454E0", Offset = "0x2043EE0", VA = "0x1820454E0")]
	public void ENEFFEHIEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x20443B0", Offset = "0x2042DB0", VA = "0x1820443B0")]
	private bool ELPEDCMJAMJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2045B40", Offset = "0x2044540", VA = "0x182045B40")]
	public KJFIABLPOAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class DMLAKMKPEAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Dictionary<object, float> NNJAJJFLLCG;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float FOGADIAHGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x950740", Offset = "0x94F140", VA = "0x180950740")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x950730", Offset = "0x94F130", VA = "0x180950730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x3D80E90", Offset = "0x3D7F890", VA = "0x183D80E90")]
	public void LPBCDCAONMA(float MDAEJMIAMDO, object AHLEOHFEOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3D80D00", Offset = "0x3D7F700", VA = "0x183D80D00")]
	public void EIJEJMNEAKK(object AHLEOHFEOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3D80D70", Offset = "0x3D7F770", VA = "0x183D80D70")]
	private void JDPOKIACLJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3D80F00", Offset = "0x3D7F900", VA = "0x183D80F00")]
	public DMLAKMKPEAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class POGLOCLPBAO
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public sealed class IGFPHIOPHLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly string DEFPIGHINGL;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
		private IGFPHIOPHLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x558960", Offset = "0x557360", VA = "0x180558960")]
		public IGFPHIOPHLJ(string DEFPIGHINGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3D81550", Offset = "0x3D7FF50", VA = "0x183D81550", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class GKIPCMNNHGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
		public GKIPCMNNHGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3D814A0", Offset = "0x3D7FEA0", VA = "0x183D814A0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly HashSet<object> BONNBFFMDMD;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool HOINJMKPLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3D81B10", Offset = "0x3D80510", VA = "0x183D81B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3D81A60", Offset = "0x3D80460", VA = "0x183D81A60")]
	public void MDMPNEGHIKO(object AHLEOHFEOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3D81A00", Offset = "0x3D80400", VA = "0x183D81A00")]
	public void FIAJBIFJEOJ(object AHLEOHFEOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3D819A0", Offset = "0x3D803A0", VA = "0x183D819A0")]
	public bool CGMDOCCGPIP(object AHLEOHFEOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3D81AC0", Offset = "0x3D804C0", VA = "0x183D81AC0")]
	public void NILLIKMKCCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3D81B50", Offset = "0x3D80550", VA = "0x183D81B50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3D81CB0", Offset = "0x3D806B0", VA = "0x183D81CB0")]
	public POGLOCLPBAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class GEJHEACGBBO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct HFAHBIMKHAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public float NKGHPNMDKEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public T KJIPGBPKLDI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Dictionary<object, HFAHBIMKHAK> NNJAJJFLLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private T BICPFLKFKDC;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T IMCNIODHGOL
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x1B8B0C0", Offset = "0x1B89AC0", VA = "0x181B8B0C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2043820", Offset = "0x2042220", VA = "0x182043820", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public object DBPIDMCDCMB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x44E670", Offset = "0x44D070", VA = "0x18044E670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x4C2130", Offset = "0x4C0B30", VA = "0x1804C2130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool DLOEGPBPDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x21C8AC0", Offset = "0x21C74C0", VA = "0x1821C8AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x21C8B00", Offset = "0x21C7500", VA = "0x1821C8B00")]
	public bool LPBCDCAONMA(T MDAEJMIAMDO, object AHLEOHFEOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x21C6DB0", Offset = "0x21C57B0", VA = "0x1821C6DB0")]
	public bool EIJEJMNEAKK(object AHLEOHFEOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x20454E0", Offset = "0x2043EE0", VA = "0x1820454E0")]
	public void ENEFFEHIEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x21C93F0", Offset = "0x21C7DF0", VA = "0x1821C93F0")]
	public bool ONOIJJCGCFB(object AHLEOHFEOPA, out T MDAEJMIAMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x21C7C30", Offset = "0x21C6630", VA = "0x1821C7C30")]
	private bool ELPEDCMJAMJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x21C94D0", Offset = "0x21C7ED0", VA = "0x1821C94D0")]
	public GEJHEACGBBO()
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
