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
public class GLFPKDMDIAN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x53F4C0", Offset = "0x53E6C0", VA = "0x18053F4C0")]
	public GLFPKDMDIAN()
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
		[Cpp2IlInjected.Address(RVA = "0x4251A0", Offset = "0x4243A0", VA = "0x1804251A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x425E60", Offset = "0x425060", VA = "0x180425E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x425450", Offset = "0x424650", VA = "0x180425450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "4")]
	public virtual void BPDAFFAAJHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x179F430", Offset = "0x179E630", VA = "0x18179F430")]
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
	[GLFPKDMDIAN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x33B6EB0", Offset = "0x33B60B0", VA = "0x1833B6EB0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x33B69F0", Offset = "0x33B5BF0", VA = "0x1833B69F0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x33B74B0", Offset = "0x33B66B0", VA = "0x1833B74B0")]
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
	private sealed class DNMBGKGHPID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x179F430", Offset = "0x179E630", VA = "0x18179F430")]
		public DNMBGKGHPID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1C81F60", Offset = "0x1C81160", VA = "0x181C81F60")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[GLFPKDMDIAN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1C894B0", Offset = "0x1C886B0", VA = "0x181C894B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1C894E0", Offset = "0x1C886E0", VA = "0x181C894E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1C89400", Offset = "0x1C88600", VA = "0x181C89400", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey BGJKOMDILFD]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1C89430", Offset = "0x1C88630", VA = "0x181C89430", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1C89310", Offset = "0x1C88510", VA = "0x181C89310", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1C88B80", Offset = "0x1C87D80", VA = "0x181C88B80", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1C884F0", Offset = "0x1C876F0", VA = "0x181C884F0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1C88120", Offset = "0x1C87320", VA = "0x181C88120", Slot = "14")]
	protected virtual string LHBGNFGONKE(TKeyVal HIJBPJNECOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1C88030", Offset = "0x1C87230", VA = "0x181C88030", Slot = "4")]
	public bool ContainsKey(TKey BGJKOMDILFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1C89210", Offset = "0x1C88410", VA = "0x181C89210", Slot = "5")]
	public bool TryGetValue(TKey BGJKOMDILFD, out TVal NAOGMHDFAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1C88060", Offset = "0x1C87260", VA = "0x181C88060", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1C88060", Offset = "0x1C87260", VA = "0x181C88060", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1C89240", Offset = "0x1C88440", VA = "0x181C89240")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class JAECAGJNBLH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class FHFONHFIEFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x179F430", Offset = "0x179E630", VA = "0x18179F430")]
		public FHFONHFIEFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2309FB0", Offset = "0x23091B0", VA = "0x182309FB0")]
		internal bool <GetSamples>b__0(global::CIGAGOPKJGJ<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float IOCKJBEMHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float BLIHFDMEGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<global::CIGAGOPKJGJ<float, T>> KNDJCFFFEDI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int CBMKMPBAEGG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2318DF0", Offset = "0x2317FF0", VA = "0x182318DF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x23197C0", Offset = "0x23189C0", VA = "0x1823197C0")]
	public JAECAGJNBLH(float GNCADHICOLC, float AJOAKEDEJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2319500", Offset = "0x2318700", VA = "0x182319500")]
	public bool PKCHCEDOBLO(float MKHFDKJGEEK, T NAOGMHDFAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x23191D0", Offset = "0x23183D0", VA = "0x1823191D0")]
	public IEnumerable<T> MAOILPBBNIN(float MKHFDKJGEEK, [Optional] float? KEPGICOLMFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2318E70", Offset = "0x2318070", VA = "0x182318E70")]
	public void JOFBHKLPDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2318CB0", Offset = "0x2317EB0", VA = "0x182318CB0")]
	private void FJILOJHMFDA(float MKHFDKJGEEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class ILMMBANLMPE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct HFJNKGDMIPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public T NBLACJEKEDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float AGECNIHDPBC;
	}

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static float MOABILMPFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private List<T> NEPADAHLGDG;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const int OKDGFOHFNCL = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private HFJNKGDMIPE[] BLOIINFLKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int NHOFKCJPGGB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float FDPNFLFGIGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD8EDF0", Offset = "0xD8DFF0", VA = "0x180D8EDF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xE829D0", Offset = "0xE81BD0", VA = "0x180E829D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2317880", Offset = "0x2316A80", VA = "0x182317880")]
	public ILMMBANLMPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x23178B0", Offset = "0x2316AB0", VA = "0x1823178B0")]
	public ILMMBANLMPE(int GINDFGEIJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2316AC0", Offset = "0x2315CC0", VA = "0x182316AC0")]
	public void AJPLHOGDMBC(float MKHFDKJGEEK, T NAOGMHDFAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2317060", Offset = "0x2316260", VA = "0x182317060")]
	public void JOFBHKLPDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2317460", Offset = "0x2316660", VA = "0x182317460")]
	public bool MNJLJEJIDGL(float NIHOHIHOBGF, float KHPNJOKOJOI, out T NAOGMHDFAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2316D40", Offset = "0x2315F40", VA = "0x182316D40")]
	public bool BMMPGFLOPNN(float NIHOHIHOBGF, float KHPNJOKOJOI, out T NAOGMHDFAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2317310", Offset = "0x2316510", VA = "0x182317310")]
	public void KCPMHHEAOOP(float NIHOHIHOBGF, float KHPNJOKOJOI, List<T> PIPDEHLIFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2316EE0", Offset = "0x23160E0", VA = "0x182316EE0")]
	private int DHLJMKADJAA(int OHDJPNPOAKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2316EA0", Offset = "0x23160A0", VA = "0x182316EA0")]
	private void DCAIHEPFPIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T OELGLHPJNHF();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T HDCBKBAODMB(T NAOGMHDFAEF, float JLIIBLHINMF);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T KFEKIDOMMHH(T BLDEGPDDAOH, T FHGMCBDODMG);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T PFHGFOKMLKN(T BLDEGPDDAOH, T FHGMCBDODMG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class HGIPNBGJPLA : global::ILMMBANLMPE<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3D534A0", Offset = "0x3D526A0", VA = "0x183D534A0", Slot = "4")]
	protected override Vector3 OELGLHPJNHF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3D53350", Offset = "0x3D52550", VA = "0x183D53350", Slot = "5")]
	protected override Vector3 HDCBKBAODMB(Vector3 NAOGMHDFAEF, float JLIIBLHINMF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3D533F0", Offset = "0x3D525F0", VA = "0x183D533F0", Slot = "6")]
	protected override Vector3 KFEKIDOMMHH(Vector3 BLDEGPDDAOH, Vector3 FHGMCBDODMG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3D53510", Offset = "0x3D52710", VA = "0x183D53510", Slot = "7")]
	protected override Vector3 PFHGFOKMLKN(Vector3 BLDEGPDDAOH, Vector3 FHGMCBDODMG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3D53580", Offset = "0x3D52780", VA = "0x183D53580")]
	public HGIPNBGJPLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class FGNCLJGNJGD
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1EA20F0", Offset = "0x1EA12F0", VA = "0x181EA20F0")]
	public static global::CIGAGOPKJGJ<T1, T2> AEKPMIMCBBN<T1, T2>(T1 DBHHAJLBPAD, T2 JNMNNEMIGKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1EA2160", Offset = "0x1EA1360", VA = "0x181EA2160")]
	public static global::JNONOFJGACI<T1, T2, T3> AEKPMIMCBBN<T1, T2, T3>(T1 DBHHAJLBPAD, T2 JNMNNEMIGKB, T3 NKECLOAHMLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2AD52B0", Offset = "0x2AD44B0", VA = "0x182AD52B0")]
	internal static int DEOADPLHOGC(int FPLDENNKLBK, int BBHLFGGDOHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x391A1E0", Offset = "0x39193E0", VA = "0x18391A1E0")]
	internal static int DEOADPLHOGC(int FPLDENNKLBK, int BBHLFGGDOHD, int AGMHDPBLINH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class CIGAGOPKJGJ<T1, T2> : IComparable<global::CIGAGOPKJGJ<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T1 KLKCCIFMLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly T2 OHHPHMIADAO;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x218FC80", Offset = "0x218EE80", VA = "0x18218FC80")]
	public CIGAGOPKJGJ(T1 DBHHAJLBPAD, T2 JNMNNEMIGKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x218E360", Offset = "0x218D560", VA = "0x18218E360", Slot = "4")]
	public int CompareTo(global::CIGAGOPKJGJ<T1, T2> ILOMCFJFIKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x218EDF0", Offset = "0x218DFF0", VA = "0x18218EDF0", Slot = "0")]
	public override bool Equals(object ILOMCFJFIKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x218F2E0", Offset = "0x218E4E0", VA = "0x18218F2E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x218F5F0", Offset = "0x218E7F0", VA = "0x18218F5F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class JNONOFJGACI<T1, T2, T3> : IComparable<global::JNONOFJGACI<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly T1 KLKCCIFMLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly T2 OHHPHMIADAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly T3 PIEEHDIKIKJ;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2E2DCD0", Offset = "0x2E2CED0", VA = "0x182E2DCD0")]
	public JNONOFJGACI(T1 DBHHAJLBPAD, T2 JNMNNEMIGKB, T3 NKECLOAHMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D4F0", Offset = "0x2E2C6F0", VA = "0x182E2D4F0", Slot = "4")]
	public int CompareTo(global::JNONOFJGACI<T1, T2, T3> ILOMCFJFIKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D7E0", Offset = "0x2E2C9E0", VA = "0x182E2D7E0", Slot = "0")]
	public override bool Equals(object ILOMCFJFIKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D9E0", Offset = "0x2E2CBE0", VA = "0x182E2D9E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2E2DA50", Offset = "0x2E2CC50", VA = "0x182E2DA50", Slot = "3")]
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
	public T NBLACJEKEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x44C670", Offset = "0x44B870", VA = "0x18044C670")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x514DD0", Offset = "0x513FD0", VA = "0x180514DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float HFILJOEOLCG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xB74B70", Offset = "0xB73D70", VA = "0x180B74B70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2D85160", Offset = "0x2D84360", VA = "0x182D85160")]
	public T DFDLODEHMLE(float JLIIBLHINMF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2D853E0", Offset = "0x2D845E0", VA = "0x182D853E0")]
	public T IMLMILJIKII(float JLIIBLHINMF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T KCEEIBKEHBB(T BLDEGPDDAOH, T FHGMCBDODMG, float JLIIBLHINMF);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x179F430", Offset = "0x179E630", VA = "0x18179F430")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3D52FC0", Offset = "0x3D521C0", VA = "0x183D52FC0", Slot = "4")]
	protected override float KCEEIBKEHBB(float BLDEGPDDAOH, float FHGMCBDODMG, float JLIIBLHINMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3D53040", Offset = "0x3D52240", VA = "0x183D53040")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3D54980", Offset = "0x3D53B80", VA = "0x183D54980", Slot = "4")]
	protected override Vector3 KCEEIBKEHBB(Vector3 BLDEGPDDAOH, Vector3 FHGMCBDODMG, float JLIIBLHINMF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3D54A40", Offset = "0x3D53C40", VA = "0x183D54A40")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3D33120", Offset = "0x3D32320", VA = "0x183D33120", Slot = "4")]
	protected override Color KCEEIBKEHBB(Color BLDEGPDDAOH, Color FHGMCBDODMG, float JLIIBLHINMF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3D52B30", Offset = "0x3D51D30", VA = "0x183D52B30")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class CJCCFCLNAFL<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<TKey, TVal> DLDPLDDGLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TVal, TKey> CFIAEEHKKIG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int JNHNEJAPHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x183C8A0", Offset = "0x183BAA0", VA = "0x18183C8A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool FADKHHBLJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x425E40", Offset = "0x425040", VA = "0x180425E40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ICollection<TKey> NJJDPLJBGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x213AC90", Offset = "0x2139E90", VA = "0x18213AC90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ICollection<TVal> ACLMPOOEGEL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2191070", Offset = "0x2190270", VA = "0x182191070", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal KHNJKPLBNNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2191040", Offset = "0x2190240", VA = "0x182191040", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x21910A0", Offset = "0x21902A0", VA = "0x1821910A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x21909D0", Offset = "0x218FBD0", VA = "0x1821909D0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2190EF0", Offset = "0x21900F0", VA = "0x182190EF0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x21907F0", Offset = "0x218F9F0", VA = "0x1821907F0", Slot = "9")]
	public void Add(TKey BGJKOMDILFD, TVal NAOGMHDFAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2190820", Offset = "0x218FA20", VA = "0x182190820", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> DFFDCAGJFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2190A30", Offset = "0x218FC30", VA = "0x182190A30", Slot = "8")]
	public bool ContainsKey(TKey BGJKOMDILFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2190A60", Offset = "0x218FC60", VA = "0x182190A60", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> DFFDCAGJFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2190E40", Offset = "0x2190040", VA = "0x182190E40", Slot = "10")]
	public bool Remove(TKey BGJKOMDILFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2190E40", Offset = "0x2190040", VA = "0x182190E40", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> DFFDCAGJFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2190F40", Offset = "0x2190140", VA = "0x182190F40", Slot = "11")]
	public bool TryGetValue(TKey BGJKOMDILFD, out TVal NAOGMHDFAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2190BA0", Offset = "0x218FDA0", VA = "0x182190BA0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2190AC0", Offset = "0x218FCC0", VA = "0x182190AC0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] BLOIINFLKLG, int OONPMAPGCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2190790", Offset = "0x218F990", VA = "0x182190790")]
	public bool ACCNBKIANOB(TVal BGJKOMDILFD, out TKey NAOGMHDFAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2190DC0", Offset = "0x218FFC0", VA = "0x182190DC0")]
	private void PCOMLMFDJMC(TKey BGJKOMDILFD, TVal KGNCHGHEBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2190C20", Offset = "0x218FE20", VA = "0x182190C20")]
	private void LLAPNHAFGCH(TKey BGJKOMDILFD, TVal KGNCHGHEBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2190910", Offset = "0x218FB10", VA = "0x182190910")]
	private bool CHGBLODFAIM(TKey BGJKOMDILFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2190F70", Offset = "0x2190170", VA = "0x182190F70")]
	public CJCCFCLNAFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public class HNIDLLEADPG<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private global::HNIDLLEADPG<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0xD8EDF0", Offset = "0xD8DFF0", VA = "0x180D8EDF0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x1B61EF0", Offset = "0x1B610F0", VA = "0x181B61EF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1B62150", Offset = "0x1B61350", VA = "0x181B62150")]
		public Enumerator(global::HNIDLLEADPG<T> PIPDEHLIFKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1B61560", Offset = "0x1B60760", VA = "0x181B61560", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1B61BA0", Offset = "0x1B60DA0", VA = "0x181B61BA0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1B61A00", Offset = "0x1B60C00", VA = "0x181B61A00")]
		private void OIJEGFODHKP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T[] POMNAGMBIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int PCIKPIFMCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int DPAONLOJAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int LINIBNLLKGO;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int JNHNEJAPHMG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1B69E90", Offset = "0x1B69090", VA = "0x181B69E90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public T KHNJKPLBNNI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1B69CF0", Offset = "0x1B68EF0", VA = "0x181B69CF0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1B69620", Offset = "0x1B68820", VA = "0x181B69620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1B6A4B0", Offset = "0x1B696B0", VA = "0x181B6A4B0")]
	public HNIDLLEADPG(int CENKHLNGHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1B69350", Offset = "0x1B68550", VA = "0x181B69350")]
	public void AJPLHOGDMBC(T JLIIBLHINMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1B69E70", Offset = "0x1B69070", VA = "0x181B69E70")]
	public void JOFBHKLPDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1B69ED0", Offset = "0x1B690D0", VA = "0x181B69ED0")]
	public void LEBMLLLKGAN(int KIAPCNBNHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1B69900", Offset = "0x1B68B00", VA = "0x181B69900")]
	public void FHCPFKOKCOF(T[] BLOIINFLKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1B69690", Offset = "0x1B68890", VA = "0x181B69690")]
	public Enumerator EANJKFHBFKH()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1B6A320", Offset = "0x1B69520", VA = "0x181B6A320", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1B6A320", Offset = "0x1B69520", VA = "0x181B6A320", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1B69F60", Offset = "0x1B69160", VA = "0x181B69F60")]
	private int PDLNMINPKDH(int GKLPGEBNHCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1B69780", Offset = "0x1B68980", VA = "0x181B69780")]
	private int EEBMLGEHFAP(int GKLPGEBNHCO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class IMLNOGKLAIC
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
	protected IMLNOGKLAIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class BLCMGDAOFPK<T> : IMLNOGKLAIC
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	protected struct PCGIMKKGNMF
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum HDJIGAHCJDG
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
		public HDJIGAHCJDG NBODGAKLJFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public T EPNGAEBBFEF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int ILKLMNFHGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly bool BADCCPNCBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	protected readonly bool PPHKKHEJNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	protected List<T> NGHIADFDHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<PCGIMKKGNMF> LFLCEGGFFIB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool NGMBMMAMCOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x282F780", Offset = "0x282E980", VA = "0x18282F780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x282FBB0", Offset = "0x282EDB0", VA = "0x18282FBB0")]
	protected BLCMGDAOFPK(bool PPHKKHEJNDE, bool BADCCPNCBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x282F900", Offset = "0x282EB00", VA = "0x18282F900")]
	protected bool GNPHDIOBBBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x282F9A0", Offset = "0x282EBA0", VA = "0x18282F9A0")]
	protected void JAFMPJKMMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x282F5D0", Offset = "0x282E7D0", VA = "0x18282F5D0")]
	protected void BFEMGLDECMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2004660", Offset = "0x2003860", VA = "0x182004660")]
	private static void GPMKKPNAIBC<U>(ref List<U> NKOHDLEIAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x282F480", Offset = "0x282E680", VA = "0x18282F480", Slot = "4")]
	public void AJPLHOGDMBC(T EPNGAEBBFEF, bool PNDGFDGLPOE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x282F7C0", Offset = "0x282E9C0", VA = "0x18282F7C0", Slot = "5")]
	public void BMFIDCHECMB(T EPNGAEBBFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x282FA80", Offset = "0x282EC80", VA = "0x18282FA80")]
	public void JOFBHKLPDKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class GNKFNHJJKGC : global::BLCMGDAOFPK<Action>
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3D532F0", Offset = "0x3D524F0", VA = "0x183D532F0")]
	public GNKFNHJJKGC(bool PPHKKHEJNDE = false, bool BADCCPNCBHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3D53080", Offset = "0x3D52280", VA = "0x183D53080")]
	public void APFPNHPIBGO()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3D53230", Offset = "0x3D52430", VA = "0x183D53230")]
	public static GNKFNHJJKGC CJIPIAABGFO(GNKFNHJJKGC JACBJGGMKOK, Action EPNGAEBBFEF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3D53290", Offset = "0x3D52490", VA = "0x183D53290")]
	public static GNKFNHJJKGC NHMOGBLIFHM(GNKFNHJJKGC JACBJGGMKOK, Action EPNGAEBBFEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface PKLPKCJHHNL<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AJPLHOGDMBC(Action<T> EPNGAEBBFEF, bool PNDGFDGLPOE = false);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BMFIDCHECMB(Action<T> EPNGAEBBFEF);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class NLHNPBMDKFB<T> : global::BLCMGDAOFPK<Action<T>>, global::PKLPKCJHHNL<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1988A20", Offset = "0x1987C20", VA = "0x181988A20")]
	public NLHNPBMDKFB(bool PPHKKHEJNDE = false, bool BADCCPNCBHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1988180", Offset = "0x1987380", VA = "0x181988180")]
	public void APFPNHPIBGO(T JLIIBLHINMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x19888E0", Offset = "0x1987AE0", VA = "0x1819888E0")]
	public static global::NLHNPBMDKFB<T> CJIPIAABGFO(global::NLHNPBMDKFB<T> JACBJGGMKOK, Action<T> EPNGAEBBFEF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1988980", Offset = "0x1987B80", VA = "0x181988980")]
	public static global::NLHNPBMDKFB<T> NHMOGBLIFHM(global::NLHNPBMDKFB<T> JACBJGGMKOK, Action<T> EPNGAEBBFEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FEACEMKKNEC<T, U>
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class JAGLFMOCPAG<T, U> : global::BLCMGDAOFPK<Action<T, U>>, global::FEACEMKKNEC<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1988A20", Offset = "0x1987C20", VA = "0x181988A20")]
	public JAGLFMOCPAG(bool PPHKKHEJNDE = false, bool BADCCPNCBHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x24969F0", Offset = "0x2495BF0", VA = "0x1824969F0")]
	public void APFPNHPIBGO(T JLIIBLHINMF, U HHADJCLGAFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x19888E0", Offset = "0x1987AE0", VA = "0x1819888E0")]
	public static global::JAGLFMOCPAG<T, U> CJIPIAABGFO(global::JAGLFMOCPAG<T, U> JACBJGGMKOK, Action<T, U> EPNGAEBBFEF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1988980", Offset = "0x1987B80", VA = "0x181988980")]
	public static global::JAGLFMOCPAG<T, U> NHMOGBLIFHM(global::JAGLFMOCPAG<T, U> JACBJGGMKOK, Action<T, U> EPNGAEBBFEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class FIEBANOPALP<T, U, V> : global::BLCMGDAOFPK<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1988A20", Offset = "0x1987C20", VA = "0x181988A20")]
	public FIEBANOPALP(bool PPHKKHEJNDE = false, bool BADCCPNCBHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x28BB940", Offset = "0x28BAB40", VA = "0x1828BB940")]
	public void APFPNHPIBGO(T JLIIBLHINMF, U HHADJCLGAFG, V OGNGOMIHEOH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x19888E0", Offset = "0x1987AE0", VA = "0x1819888E0")]
	public static global::FIEBANOPALP<T, U, V> CJIPIAABGFO(global::FIEBANOPALP<T, U, V> JACBJGGMKOK, Action<T, U, V> EPNGAEBBFEF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1988980", Offset = "0x1987B80", VA = "0x181988980")]
	public static global::FIEBANOPALP<T, U, V> NHMOGBLIFHM(global::FIEBANOPALP<T, U, V> JACBJGGMKOK, Action<T, U, V> EPNGAEBBFEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EIGJBKEKNLL<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class MPKAOLCFHBB<T, U, V, W> : global::BLCMGDAOFPK<Action<T, U, V, W>>, global::EIGJBKEKNLL<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1988A20", Offset = "0x1987C20", VA = "0x181988A20")]
	public MPKAOLCFHBB(bool PPHKKHEJNDE = false, bool BADCCPNCBHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1EF5FE0", Offset = "0x1EF51E0", VA = "0x181EF5FE0")]
	public void APFPNHPIBGO(T JLIIBLHINMF, U HHADJCLGAFG, V OGNGOMIHEOH, W KLJHICMKBFI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x19888E0", Offset = "0x1987AE0", VA = "0x1819888E0")]
	public static global::MPKAOLCFHBB<T, U, V, W> CJIPIAABGFO(global::MPKAOLCFHBB<T, U, V, W> JACBJGGMKOK, Action<T, U, V, W> EPNGAEBBFEF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1988980", Offset = "0x1987B80", VA = "0x181988980")]
	public static global::MPKAOLCFHBB<T, U, V, W> NHMOGBLIFHM(global::MPKAOLCFHBB<T, U, V, W> JACBJGGMKOK, Action<T, U, V, W> EPNGAEBBFEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class MHLAEEFPLHC<T, U, V, W, X> : global::BLCMGDAOFPK<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1988A20", Offset = "0x1987C20", VA = "0x181988A20")]
	public MHLAEEFPLHC(bool PPHKKHEJNDE = false, bool BADCCPNCBHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1EF3840", Offset = "0x1EF2A40", VA = "0x181EF3840")]
	public void APFPNHPIBGO(T JLIIBLHINMF, U HHADJCLGAFG, V OGNGOMIHEOH, W KLJHICMKBFI, X JOBKHMNDDOJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x19888E0", Offset = "0x1987AE0", VA = "0x1819888E0")]
	public static global::MHLAEEFPLHC<T, U, V, W, X> CJIPIAABGFO(global::MHLAEEFPLHC<T, U, V, W, X> JACBJGGMKOK, Action<T, U, V, W, X> EPNGAEBBFEF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1988980", Offset = "0x1987B80", VA = "0x181988980")]
	public static global::MHLAEEFPLHC<T, U, V, W, X> NHMOGBLIFHM(global::MHLAEEFPLHC<T, U, V, W, X> JACBJGGMKOK, Action<T, U, V, W, X> EPNGAEBBFEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class CFBAIEJIKFG<T, U, V, W, X, Y> : global::BLCMGDAOFPK<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1988A20", Offset = "0x1987C20", VA = "0x181988A20")]
	public CFBAIEJIKFG(bool PPHKKHEJNDE = false, bool BADCCPNCBHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x218B340", Offset = "0x218A540", VA = "0x18218B340")]
	public void APFPNHPIBGO(T JLIIBLHINMF, U HHADJCLGAFG, V OGNGOMIHEOH, W KLJHICMKBFI, X JOBKHMNDDOJ, Y IFCPAEEHEPP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x19888E0", Offset = "0x1987AE0", VA = "0x1819888E0")]
	public static global::CFBAIEJIKFG<T, U, V, W, X, Y> CJIPIAABGFO(global::CFBAIEJIKFG<T, U, V, W, X, Y> JACBJGGMKOK, Action<T, U, V, W, X, Y> EPNGAEBBFEF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1988980", Offset = "0x1987B80", VA = "0x181988980")]
	public static global::CFBAIEJIKFG<T, U, V, W, X, Y> NHMOGBLIFHM(global::CFBAIEJIKFG<T, U, V, W, X, Y> JACBJGGMKOK, Action<T, U, V, W, X, Y> EPNGAEBBFEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class FJCLDHOCJMP<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate bool KLCBCMOAAAO(global::FJCLDHOCJMP<T> HCOPKCKJMHE);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class AAHDEMGFBNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public global::FJCLDHOCJMP<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x179F430", Offset = "0x179E630", VA = "0x18179F430")]
		public AAHDEMGFBNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x28BA220", Offset = "0x28B9420", VA = "0x1828BA220")]
		internal bool <FindNode>b__0(global::FJCLDHOCJMP<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public T KLGGACGNKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public LinkedList<global::FJCLDHOCJMP<T>> MHNOBOBJNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public global::FJCLDHOCJMP<T> AFJIAHENNLB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public global::FJCLDHOCJMP<T> KKFKLBDAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x475A20", Offset = "0x474C20", VA = "0x180475A20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x28BC8B0", Offset = "0x28BBAB0", VA = "0x1828BC8B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MCJICBECLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x28BC350", Offset = "0x28BB550", VA = "0x1828BC350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool IFHKHNIEGEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x28BE320", Offset = "0x28BD520", VA = "0x1828BE320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public global::FJCLDHOCJMP<T> HDNKNNPIEOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x28BC380", Offset = "0x28BB580", VA = "0x1828BC380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x28BE360", Offset = "0x28BD560", VA = "0x1828BE360")]
	public FJCLDHOCJMP(T NIFPJGCFIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x28BC5E0", Offset = "0x28BB7E0", VA = "0x1828BC5E0")]
	public global::FJCLDHOCJMP<T> FLCFMPFKNCH(T EFDBKIGLAHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x28BBFC0", Offset = "0x28BB1C0", VA = "0x1828BBFC0")]
	public global::FJCLDHOCJMP<T> DGJFECKCGCJ(T FBFFMDJPBDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x28BBE80", Offset = "0x28BB080", VA = "0x1828BBE80")]
	public global::FJCLDHOCJMP<T> BMFIDCHECMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x28BD410", Offset = "0x28BC610", VA = "0x1828BD410")]
	public void JOFBHKLPDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x28BC4D0", Offset = "0x28BB6D0", VA = "0x1828BC4D0")]
	public global::FJCLDHOCJMP<T> EOBIFPDEPKP(T NHBBADGGNFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x28BCD90", Offset = "0x28BBF90", VA = "0x1828BCD90")]
	public static void HHBIOEDFFLN(global::FJCLDHOCJMP<T> DIEAGJDEIPN, KLCBCMOAAAO JNGFIHAIEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x200C6B0", Offset = "0x200B8B0", VA = "0x18200C6B0")]
	public static void HHBIOEDFFLN<A>(global::FJCLDHOCJMP<T> DIEAGJDEIPN, Func<global::FJCLDHOCJMP<T>, A, bool> JNGFIHAIEPD, A EICNKBHLJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x28BDDD0", Offset = "0x28BCFD0", VA = "0x1828BDDD0")]
	public static string JPGKKHKHCIN(global::FJCLDHOCJMP<T> DIEAGJDEIPN, int NKFNADHOJPM = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x28BC970", Offset = "0x28BBB70", VA = "0x1828BC970")]
	public static global::FJCLDHOCJMP<T> GNFDKHCJDFL(global::FJCLDHOCJMP<T> DIEAGJDEIPN, T DOEGEHJFGIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class BBOIDBEGICA<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate int NAAMJAFGOPK(TKey BGJKOMDILFD, TVal NAOGMHDFAEF);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private class FJECFJIJMOB
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public TKey CHAPOCEIMFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x4251A0", Offset = "0x4243A0", VA = "0x1804251A0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public TVal NBLACJEKEDC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x5B1F60", Offset = "0x5B1160", VA = "0x1805B1F60")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x5E8260", Offset = "0x5E7460", VA = "0x1805E8260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int CDLAIBPMEEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x52E730", Offset = "0x52D930", VA = "0x18052E730")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x52E760", Offset = "0x52D960", VA = "0x18052E760")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public DateTime LGGJNJIOMOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x427CF0", Offset = "0x426EF0", VA = "0x180427CF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x44E7D0", Offset = "0x44D9D0", VA = "0x18044E7D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2F02180", Offset = "0x2F01380", VA = "0x182F02180")]
		public FJECFJIJMOB(TKey BGJKOMDILFD, TVal KGNCHGHEBOO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const int MPFKCEEICPM = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Dictionary<TKey, LinkedListNode<FJECFJIJMOB>> KADAMMKMANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly LinkedList<FJECFJIJMOB> NHDANDAJJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly NAAMJAFGOPK FMGGLOIDFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly TimeSpan HGGFMCEMDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly NMGNBNEGKCO GMAJIJKCHAF;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int GHKFFHAMIMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x537860", Offset = "0x536A60", VA = "0x180537860")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool JFFEFEAOACK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2EF0C90", Offset = "0x2EEFE90", VA = "0x182EF0C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal int MGBELGFKHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x537870", Offset = "0x536A70", VA = "0x180537870")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x52C8B0", Offset = "0x52BAB0", VA = "0x18052C8B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey KHNJKPLBNNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2EF1000", Offset = "0x2EF0200", VA = "0x182EF1000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2EF2390", Offset = "0x2EF1590", VA = "0x182EF2390")]
	public BBOIDBEGICA(int CENKHLNGHOM, [Optional] NAAMJAFGOPK FMGGLOIDFDF, [Optional] IEqualityComparer<TKey> GLKEMOOLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2EF1E80", Offset = "0x2EF1080", VA = "0x182EF1E80")]
	public BBOIDBEGICA(int CENKHLNGHOM, NAAMJAFGOPK FMGGLOIDFDF, TimeSpan HGGFMCEMDOF, [Optional] IEqualityComparer<TKey> GLKEMOOLDBK, [Optional] NMGNBNEGKCO GMAJIJKCHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2EF0EA0", Offset = "0x2EF00A0", VA = "0x182EF0EA0")]
	public void DCLBGMGDGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2EF0D20", Offset = "0x2EEFF20", VA = "0x182EF0D20")]
	public void CGGNJAMPKCG(TKey BGJKOMDILFD, TVal NAOGMHDFAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2EF0B10", Offset = "0x2EEFD10", VA = "0x182EF0B10")]
	public bool BMFIDCHECMB(TKey BGJKOMDILFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2EF0870", Offset = "0x2EEFA70", VA = "0x182EF0870")]
	public bool ACCNBKIANOB(TKey DLHJKBCONHN, out TVal NAOGMHDFAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2EF19F0", Offset = "0x2EF0BF0", VA = "0x182EF19F0")]
	public void JOFBHKLPDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2EF1530", Offset = "0x2EF0730", VA = "0x182EF1530")]
	private bool GBNECPHAEJI(FJECFJIJMOB MHIEPNKCEHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2EF1030", Offset = "0x2EF0230", VA = "0x182EF1030")]
	private void GAGNFEGFLKH(LinkedListNode<FJECFJIJMOB> IDOMKBLEEFN, TVal MJFLDBGDCNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2EF1C70", Offset = "0x2EF0E70", VA = "0x182EF1C70")]
	private void LDGHDILJELL(TKey BGJKOMDILFD, TVal NAOGMHDFAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2EF1850", Offset = "0x2EF0A50", VA = "0x182EF1850")]
	private void HGFDHNBMBOK(FJECFJIJMOB MHIEPNKCEHE, TVal MJFLDBGDCNC, int IOFBOHKBLGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public class JAMEMCCAHBP<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly List<T> NKOHDLEIAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private HashSet<T> PJFAOJEFFCE;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int JNHNEJAPHMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x183C8A0", Offset = "0x183BAA0", VA = "0x18183C8A0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool FADKHHBLJOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x425E40", Offset = "0x425040", VA = "0x180425E40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T KHNJKPLBNNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2497900", Offset = "0x2496B00", VA = "0x182497900", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2497930", Offset = "0x2496B30", VA = "0x182497930", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1EED910", Offset = "0x1EECB10", VA = "0x181EED910", Slot = "11")]
	public void Add(T DFFDCAGJFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x24974E0", Offset = "0x24966E0", VA = "0x1824974E0")]
	public bool NKNICAOCPNM(T DFFDCAGJFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x24977B0", Offset = "0x24969B0", VA = "0x1824977B0", Slot = "15")]
	public bool Remove(T DFFDCAGJFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2497220", Offset = "0x2496420", VA = "0x182497220", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x21407B0", Offset = "0x213F9B0", VA = "0x1821407B0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2497160", Offset = "0x2496360", VA = "0x182497160", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x24971C0", Offset = "0x24963C0", VA = "0x1824971C0", Slot = "13")]
	public bool Contains(T DFFDCAGJFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x24971F0", Offset = "0x24963F0", VA = "0x1824971F0", Slot = "14")]
	public void CopyTo(T[] BLOIINFLKLG, int OONPMAPGCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2191040", Offset = "0x2190240", VA = "0x182191040", Slot = "6")]
	public int IndexOf(T DFFDCAGJFNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x24972A0", Offset = "0x24964A0", VA = "0x1824972A0", Slot = "7")]
	public void Insert(int GKLPGEBNHCO, T DFFDCAGJFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2497650", Offset = "0x2496850", VA = "0x182497650", Slot = "8")]
	public void RemoveAt(int GKLPGEBNHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2497830", Offset = "0x2496A30", VA = "0x182497830")]
	public JAMEMCCAHBP()
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
			[Cpp2IlInjected.Address(RVA = "0x20E1500", Offset = "0x20E0700", VA = "0x1820E1500")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3D54950", Offset = "0x3D53B50", VA = "0x183D54950")]
		public SerializedGuid(in Guid BFMEJCCADEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3D54790", Offset = "0x3D53990", VA = "0x183D54790")]
		public static SerializedGuid LMBBDJKEKPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3D54810", Offset = "0x3D53A10", VA = "0x183D54810")]
		public static SerializedGuid MDNILDHPLEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3D54540", Offset = "0x3D53740", VA = "0x183D54540")]
		public bool AKDOONKDCNI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3D54930", Offset = "0x3D53B30", VA = "0x183D54930", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3D54890", Offset = "0x3D53A90", VA = "0x183D54890", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3D54600", Offset = "0x3D53800", VA = "0x183D54600", Slot = "7")]
		public bool Equals(SerializedGuid ILOMCFJFIKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3D546A0", Offset = "0x3D538A0", VA = "0x183D546A0", Slot = "0")]
		public override bool Equals(object NKNAILFIDNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3D54780", Offset = "0x3D53980", VA = "0x183D54780", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D545D0", Offset = "0x3D537D0", VA = "0x183D545D0", Slot = "6")]
		public int CompareTo(SerializedGuid ILOMCFJFIKP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class JFAJNNLAHML : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly Type IFBFBPJHGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly string EBLOBEGDDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool HMLJGGDEHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly bool OAIMINDMPLF;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3D53630", Offset = "0x3D52830", VA = "0x183D53630")]
	public JFAJNNLAHML(Type MBFEHLGIPHG, string CJOGCIPKFAJ, bool PGGLIFJDINP = false, bool DJNNPGDHJJN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface NODNGHNFPKL<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	T NBLACJEKEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool CEEIBOBKDKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::NODNGHNFPKL<T> NAGGLMNCKGI(Action<T> IGLPJNAFHPJ);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::NODNGHNFPKL<T> PECJODDOCJB(Action<T> IGLPJNAFHPJ);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class AJMLKCLDLGF<T> : global::NODNGHNFPKL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private global::JAGLFMOCPAG<T, T> FMPGOOBIENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private global::NLHNPBMDKFB<T> PCOKNJDJMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private global::NLHNPBMDKFB<string> BOFCHAGKJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private string CJNIHHAKCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private T KLEOEPAEIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool KIJMGIMDGPD;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T NBLACJEKEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x44C670", Offset = "0x44B870", VA = "0x18044C670", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1C82000", Offset = "0x1C81200", VA = "0x181C82000", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool CEEIBOBKDKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x52C690", Offset = "0x52B890", VA = "0x18052C690", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2EEE770", Offset = "0x2EED970", VA = "0x182EEE770")]
	private void JDDADGBDHNL(T LGDFMPAAJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2EEE7F0", Offset = "0x2EED9F0", VA = "0x182EEE7F0", Slot = "4")]
	public global::NODNGHNFPKL<T> NAGGLMNCKGI(Action<T> AGJFCNIKBPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2EEE870", Offset = "0x2EEDA70", VA = "0x182EEE870", Slot = "5")]
	public global::NODNGHNFPKL<T> PECJODDOCJB(Action<T> IGLPJNAFHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2EEE8A0", Offset = "0x2EEDAA0", VA = "0x182EEE8A0")]
	public AJMLKCLDLGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class FGMGJKMJNKP
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class HGEGCIKMGIH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public global::NODNGHNFPKL<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public global::IBEPJEMMAFD<T> promise;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x179F430", Offset = "0x179E630", VA = "0x18179F430")]
		public HGEGCIKMGIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1C8A960", Offset = "0x1C89B60", VA = "0x181C8A960")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1FEEF10", Offset = "0x1FEE110", VA = "0x181FEEF10")]
	public static global::MGLHMIMFOOP<T> NOELIPOGLDK<T>(this global::NODNGHNFPKL<T> HOHOJPGLIGM, Action<T> HMCGKHCFDKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public abstract class NMGNBNEGKCO
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class FKJJAIFBEKG : NMGNBNEGKCO
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static NMGNBNEGKCO NAOEKEOMFHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x3D52BC0", Offset = "0x3D51DC0", VA = "0x183D52BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override DateTime FEPGGHHHEKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x3D52B70", Offset = "0x3D51D70", VA = "0x183D52B70", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3D52CB0", Offset = "0x3D51EB0", VA = "0x183D52CB0")]
		public FKJJAIFBEKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static NMGNBNEGKCO BIEFBOKOMFG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static NMGNBNEGKCO MBCHHFHFNHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3D53690", Offset = "0x3D52890", VA = "0x183D53690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract DateTime FEPGGHHHEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
	protected NMGNBNEGKCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class FPCHJIBGKIK : global::ONOACCADGDC<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3D52F80", Offset = "0x3D52180", VA = "0x183D52F80")]
	public FPCHJIBGKIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class ONOACCADGDC<T> : global::OFPLHPIPKMA<T>, CDBKLJANLOE, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Task<T> IEBNFCCMBMO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4251A0", Offset = "0x4243A0", VA = "0x1804251A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public global::MGLHMIMFOOP<T> BLFHNIBPNOC
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private FIIDGPMBKPK CMIOBBLBGNI
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x17A2DE0", Offset = "0x17A1FE0", VA = "0x1817A2DE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x213FD30", Offset = "0x213EF30", VA = "0x18213FD30")]
	public ONOACCADGDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class IKLHLKPPACF<T> : global::OFPLHPIPKMA<T>, CDBKLJANLOE, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Task<T> IEBNFCCMBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4251A0", Offset = "0x4243A0", VA = "0x1804251A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public global::MGLHMIMFOOP<T> BLFHNIBPNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private FIIDGPMBKPK CMIOBBLBGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x17A2DE0", Offset = "0x17A1FE0", VA = "0x1817A2DE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x23168F0", Offset = "0x2315AF0", VA = "0x1823168F0")]
	public IKLHLKPPACF(Exception MELPNJNHLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface CDBKLJANLOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	[NotNull]
	FIIDGPMBKPK BLFHNIBPNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface OFPLHPIPKMA<T> : CDBKLJANLOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[NotNull]
	Task<T> IEBNFCCMBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	new global::MGLHMIMFOOP<T> BLFHNIBPNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class GIDHPIDLFOA<TTask, T> : global::OFPLHPIPKMA<T>, CDBKLJANLOE, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class AANFHMPDLJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public global::GIDHPIDLFOA<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public TTask task;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x179F430", Offset = "0x179E630", VA = "0x18179F430")]
		public AANFHMPDLJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class BFMNOPOOIFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public AANFHMPDLJA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x179F430", Offset = "0x179E630", VA = "0x18179F430")]
		public BFMNOPOOIFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x28BA2E0", Offset = "0x28B94E0", VA = "0x1828BA2E0")]
		internal T <.ctor>b__0(Task t)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static bool HDHCEKKDKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly global::IBEPJEMMAFD<T> LHCKLOEFACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Task<T> EKPLFAGLFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly CancellationTokenSource DIBFINIJHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool NLJOHDMIPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private SynchronizationContext EBIKOPJEFJJ;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task<T> IEBNFCCMBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public global::MGLHMIMFOOP<T> BLFHNIBPNOC
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4251A0", Offset = "0x4243A0", VA = "0x1804251A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private FIIDGPMBKPK CMIOBBLBGNI
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4251A0", Offset = "0x4243A0", VA = "0x1804251A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool LIBAJCCEJEB
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4E8A20", Offset = "0x4E7C20", VA = "0x1804E8A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x28CAE40", Offset = "0x28CA040", VA = "0x1828CAE40")]
	static GIDHPIDLFOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x28CB200", Offset = "0x28CA400", VA = "0x1828CB200")]
	protected GIDHPIDLFOA(TTask EKPLFAGLFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x28CA7C0", Offset = "0x28C99C0", VA = "0x1828CA7C0", Slot = "1")]
	~GIDHPIDLFOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x28CA5B0", Offset = "0x28C97B0", VA = "0x1828CA5B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x28CAA50", Offset = "0x28C9C50", VA = "0x1828CAA50")]
	private void IILOAGJDJIA(bool CMMFGBFEDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T LFENEELCFHL(TTask KIEFGDHCHFE);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract void DENBGIFBKPG();

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x28CABC0", Offset = "0x28C9DC0", VA = "0x1828CABC0")]
	protected void OFADKNDEAKM(T LGDFMPAAJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x28CA860", Offset = "0x28C9A60", VA = "0x1828CA860")]
	protected void GAMDFFMPHJM(string CJNIHHAKCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x28CA680", Offset = "0x28C9880", VA = "0x1828CA680")]
	[CompilerGenerated]
	private void EDDFBPKMLJG(object ICHBBLCAHBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class OCGMFIOIPCJ<T> : IEnumerable<global::OCGMFIOIPCJ<T>.AJDOAPPIAIM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct AJDOAPPIAIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public T NAOGMHDFAEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int GKLPGEBNHCO;
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class GALKMMFEHCC : IEnumerator<AJDOAPPIAIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::OCGMFIOIPCJ<T> EKPCFEDJKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int GKLPGEBNHCO;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x2136540", Offset = "0x2135740", VA = "0x182136540", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public AJDOAPPIAIM JJJLIAGIDMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x21365B0", Offset = "0x21357B0", VA = "0x1821365B0", Slot = "4")]
			get
			{
				return default(AJDOAPPIAIM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x647720", Offset = "0x646920", VA = "0x180647720")]
		public GALKMMFEHCC(global::OCGMFIOIPCJ<T> EKPCFEDJKFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x21364B0", Offset = "0x21356B0", VA = "0x1821364B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x585270", Offset = "0x584470", VA = "0x180585270", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7E7220", Offset = "0x7E6420", VA = "0x1807E7220", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private struct EMCOAIMJFMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public bool JBCJKONAJON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public T NAOGMHDFAEF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private const int FBBLBLAMNJK = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private Dictionary<T, int> MHCHHBFCJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private EMCOAIMJFMK[] PLCOAPGAIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int DNOGJOHEOJF;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int JNHNEJAPHMG
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x213AC90", Offset = "0x2139E90", VA = "0x18213AC90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x213AF20", Offset = "0x213A120", VA = "0x18213AF20")]
	public static global::OCGMFIOIPCJ<T> OIHKJGNDHNJ(AJDOAPPIAIM[] KGNLHNPBFCK, bool EDOKHBEHBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x213B350", Offset = "0x213A550", VA = "0x18213B350")]
	public OCGMFIOIPCJ(int CENKHLNGHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x213AAB0", Offset = "0x2139CB0", VA = "0x18213AAB0")]
	public int ALBFIAONKKI(T NAOGMHDFAEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x213AEB0", Offset = "0x213A0B0", VA = "0x18213AEB0")]
	public T NOELIPOGLDK(int GKLPGEBNHCO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x213ACC0", Offset = "0x2139EC0", VA = "0x18213ACC0")]
	public bool NKNICAOCPNM(T NAOGMHDFAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x213ACE0", Offset = "0x2139EE0", VA = "0x18213ACE0")]
	public bool NKNICAOCPNM(T NAOGMHDFAEF, int GKLPGEBNHCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x213AB00", Offset = "0x2139D00", VA = "0x18213AB00")]
	public AJDOAPPIAIM[] COPGGMIPIBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x213AC40", Offset = "0x2139E40", VA = "0x18213AC40")]
	private int DIPHJMDIIDA(int PCIKPIFMCMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x213B2E0", Offset = "0x213A4E0", VA = "0x18213B2E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x213B2E0", Offset = "0x213A4E0", VA = "0x18213B2E0", Slot = "4")]
	private IEnumerator<AJDOAPPIAIM> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class INNJNMBGNMA<T> where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private List<T> JHEKKHNICJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<T> JIGBGBFKMMA;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2317BA0", Offset = "0x2316DA0", VA = "0x182317BA0")]
	public INNJNMBGNMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2317BD0", Offset = "0x2316DD0", VA = "0x182317BD0")]
	public INNJNMBGNMA(int CENKHLNGHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x2317AA0", Offset = "0x2316CA0", VA = "0x182317AA0")]
	public T MILFJMOCPLP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2317980", Offset = "0x2316B80", VA = "0x182317980")]
	public void DCFNMHKJJLO(T FIEHCFOEIPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class FJLEJGHPMFN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private Dictionary<int, T> AMIFPLCLAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private T BEPOICNPNMB;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public virtual T IBGAGIIGFMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x425450", Offset = "0x424650", VA = "0x180425450", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x28BE520", Offset = "0x28BD720", VA = "0x1828BE520")]
	public bool LDGHDILJELL(T NAOGMHDFAEF, int PNFGGBBCOIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x28BEA50", Offset = "0x28BDC50", VA = "0x1828BEA50")]
	public bool NCFDPNMJHEB(int PNFGGBBCOIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x28BE580", Offset = "0x28BD780", VA = "0x1828BE580")]
	public T MDHKBJFFHAM(int KGPIDAIFMKJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x28BEBC0", Offset = "0x28BDDC0", VA = "0x1828BEBC0")]
	private bool OIAIHHNIMDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x28BE490", Offset = "0x28BD690", VA = "0x1828BE490")]
	public bool ACCNBKIANOB(int PNFGGBBCOIE, out T NAOGMHDFAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x28BEC50", Offset = "0x28BDE50", VA = "0x1828BEC50")]
	public FJLEJGHPMFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class CPDEKFEFOKF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	protected struct FHMFJKBMKDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public T NBLACJEKEDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int JCCOKIHEHME;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	protected readonly List<FHMFJKBMKDC> POMNAGMBIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private T HJKKDKFKPOC;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int JNHNEJAPHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x183C8A0", Offset = "0x183BAA0", VA = "0x18183C8A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2193190", Offset = "0x2192390", VA = "0x182193190")]
	public bool IAKKNJLNOIC(T NAOGMHDFAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2192FF0", Offset = "0x21921F0", VA = "0x182192FF0")]
	public void AJPLHOGDMBC(T NAOGMHDFAEF, int PNFGGBBCOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2193070", Offset = "0x2192270", VA = "0x182193070")]
	public bool BMFIDCHECMB(T NAOGMHDFAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x21933E0", Offset = "0x21925E0", VA = "0x1821933E0")]
	public void JOFBHKLPDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2193440", Offset = "0x2192640", VA = "0x182193440")]
	public T PAMDLFNDMID()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x21934D0", Offset = "0x21926D0", VA = "0x1821934D0")]
	private void PIOHDEPFMAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x21936E0", Offset = "0x21928E0", VA = "0x1821936E0")]
	public CPDEKFEFOKF()
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
		[Cpp2IlInjected.Address(RVA = "0x18462D0", Offset = "0x18454D0", VA = "0x1818462D0", Slot = "4")]
		public virtual T AALOHMFDDNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x179F430", Offset = "0x179E630", VA = "0x18179F430")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class PADOLPPCOMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<byte, APHBBLEEPKE> EBCJJEOPCFE;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public APHBBLEEPKE JJIPGDIFIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x4251A0", Offset = "0x4243A0", VA = "0x1804251A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x425440", Offset = "0x424640", VA = "0x180425440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Vector2 ABGKHLKFJEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xBE1410", Offset = "0xBE0610", VA = "0x180BE1410")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x218D740", Offset = "0x218C940", VA = "0x18218D740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private Vector2 DDEOIDICOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x12EC820", Offset = "0x12EBA20", VA = "0x1812EC820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Vector2 HAAGIJCNPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F790", Offset = "0x2D9E990", VA = "0x182D9F790")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F7B0", Offset = "0x2D9E9B0", VA = "0x182D9F7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int MLMKEHDDCPC
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x44F1B0", Offset = "0x44E3B0", VA = "0x18044F1B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x474360", Offset = "0x473560", VA = "0x180474360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3D54050", Offset = "0x3D53250", VA = "0x183D54050")]
	public PADOLPPCOMO(Bounds MCKFEACLPLK, Vector2[] KPLGIFDPJFG, int LLILAPGNBBM, byte PCIKPIFMCMH, float AEHCNDCKBCC = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3D539D0", Offset = "0x3D52BD0", VA = "0x183D539D0")]
	public APHBBLEEPKE FFFGOOFMCCD(byte GKLPGEBNHCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3D53F70", Offset = "0x3D53170", VA = "0x183D53F70")]
	public void MIMEPHDDGPE(Vector3 CHDOIMLCBAB, float NDLONOHLFHB, float DMJNLJBIFPK, ref List<byte> EHDFCDIADJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3D53A30", Offset = "0x3D52C30", VA = "0x183D53A30")]
	public void GGMLCAJILPN(APHBBLEEPKE.KEHFMDBICKP BONDDDCMGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3D538B0", Offset = "0x3D52AB0", VA = "0x183D538B0")]
	private APHBBLEEPKE FBNJCHLOCMO(byte GKLPGEBNHCO, APHBBLEEPKE.IDMDEHFOFIJ OIBEKPPEHHD, APHBBLEEPKE AIJNAMEGHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3D53A50", Offset = "0x3D52C50", VA = "0x183D53A50")]
	private void HOAEIOADBHM(APHBBLEEPKE AIJNAMEGHNF, Vector2[] KPLGIFDPJFG, int BDFHPOIKACP, int JHIHBGBLCLJ, int FAJIICOOIOB, int OCFAOPBEPEO, float AEHCNDCKBCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class APHBBLEEPKE
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public enum IDMDEHFOFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum KEHFMDBICKP
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
	public byte KMIDPIMFNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Vector3 MHLODLPBHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Vector3 CDLAIBPMEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Vector3 PABELAJBKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Vector3 LJCPNKHKOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public IDMDEHFOFIJ NCKNBMGBGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public APHBBLEEPKE KKFKLBDAIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public List<APHBBLEEPKE> DPBECHPCAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public bool HKGDJEKMJFD;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3D52AE0", Offset = "0x3D51CE0", VA = "0x183D52AE0")]
	public APHBBLEEPKE(byte PPEJJBAPEIC, IDMDEHFOFIJ OIBEKPPEHHD, APHBBLEEPKE AIJNAMEGHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3D52780", Offset = "0x3D51980", VA = "0x183D52780")]
	public void FLCFMPFKNCH(APHBBLEEPKE CGHJBFNHCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00")]
	public void GGMLCAJILPN(int JHPDLDHMMNE, KEHFMDBICKP BONDDDCMGLC, int NKPODFONADL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3D52850", Offset = "0x3D51A50", VA = "0x183D52850")]
	public void MIMEPHDDGPE(List<byte> EHDFCDIADJJ, Vector3 CHDOIMLCBAB, float NDLONOHLFHB, float DMJNLJBIFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3D52720", Offset = "0x3D51920", VA = "0x183D52720")]
	public bool ECFHNBMNEIC(Vector3 JEMGAFGIIDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3D52810", Offset = "0x3D51A10", VA = "0x183D52810")]
	public bool GONJFEEDLGA(Vector3 JEMGAFGIIDC, float COLDFMAEMNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class BCJMLIIHLHE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private int CENKHLNGHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int AIFIDDJLHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private List<T> OFCLPPLCAOF;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public T NIGFICOEAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2EFC000", Offset = "0x2EFB200", VA = "0x182EFC000")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public T IHEAGEDKOCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2EFBFC0", Offset = "0x2EFB1C0", VA = "0x182EFBFC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public T JHKEABECEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2EFC1C0", Offset = "0x2EFB3C0", VA = "0x182EFC1C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2EFC280", Offset = "0x2EFB480", VA = "0x182EFC280")]
	public BCJMLIIHLHE(int CENKHLNGHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2EFBE10", Offset = "0x2EFB010", VA = "0x182EFBE10")]
	public void AJPLHOGDMBC(T DGGFHNJKDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2EFC120", Offset = "0x2EFB320", VA = "0x182EFC120")]
	public void JOFBHKLPDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2EFC160", Offset = "0x2EFB360", VA = "0x182EFC160")]
	public void KOLLOLHKLAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2EFC1B0", Offset = "0x2EFB3B0", VA = "0x182EFC1B0")]
	public void KPKBOBFPFKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class EDDDOPMLJFG<T>
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private struct GCDBKCJICJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int JCCOKIHEHME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public T NBLACJEKEDC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Dictionary<object, GCDBKCJICJL> AMIFPLCLAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private T BEPOICNPNMB;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public virtual T IBGAGIIGFMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x25C6A10", Offset = "0x25C5C10", VA = "0x1825C6A10", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x26B0160", Offset = "0x26AF360", VA = "0x1826B0160", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool GPHMDJBKJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x26B0190", Offset = "0x26AF390", VA = "0x1826B0190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public object HMNNPCIDLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x425F90", Offset = "0x425190", VA = "0x180425F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x425FA0", Offset = "0x4251A0", VA = "0x180425FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x26B04A0", Offset = "0x26AF6A0", VA = "0x1826B04A0")]
	public bool LDGHDILJELL(T NAOGMHDFAEF, object LEOPDAJLNNM, int PNFGGBBCOIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x26B0920", Offset = "0x26AFB20", VA = "0x1826B0920")]
	public bool NCFDPNMJHEB(object LEOPDAJLNNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x26AFF70", Offset = "0x26AF170", VA = "0x1826AFF70")]
	public bool ACCNBKIANOB(object LEOPDAJLNNM, out T NAOGMHDFAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x26B01C0", Offset = "0x26AF3C0", VA = "0x1826B01C0")]
	public void JOFBHKLPDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x26B0990", Offset = "0x26AFB90", VA = "0x1826B0990")]
	private bool OIAIHHNIMDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x26B5640", Offset = "0x26B4840", VA = "0x1826B5640")]
	public EDDDOPMLJFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class FNAEBLBKDFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Dictionary<object, float> AMIFPLCLAOE;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float PBHMNGNCNHO
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xBB2120", Offset = "0xBB1320", VA = "0x180BB2120")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xABAA90", Offset = "0xAB9C90", VA = "0x180ABAA90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x3D52E30", Offset = "0x3D52030", VA = "0x183D52E30")]
	public void LDGHDILJELL(float NAOGMHDFAEF, object LEOPDAJLNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3D52EA0", Offset = "0x3D520A0", VA = "0x183D52EA0")]
	public void NCFDPNMJHEB(object LEOPDAJLNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3D52D10", Offset = "0x3D51F10", VA = "0x183D52D10")]
	private void HKGJECICEEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3D52F10", Offset = "0x3D52110", VA = "0x183D52F10")]
	public FNAEBLBKDFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class AKLBCAHEGND
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public sealed class HLCKBAAGIBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly string DCPFKOLOBLJ;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
		private HLCKBAAGIBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x511D10", Offset = "0x510F10", VA = "0x180511D10")]
		public HLCKBAAGIBL(string DCPFKOLOBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3D535E0", Offset = "0x3D527E0", VA = "0x183D535E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class OJEBIACHCAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
		public OJEBIACHCAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3D53800", Offset = "0x3D52A00", VA = "0x183D53800")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly HashSet<object> IEPFGEJGDCJ;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool NKNGIJHPMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3D52520", Offset = "0x3D51720", VA = "0x183D52520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3D523B0", Offset = "0x3D515B0", VA = "0x183D523B0")]
	public void AJPLHOGDMBC(object LEOPDAJLNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3D52410", Offset = "0x3D51610", VA = "0x183D52410")]
	public void BMFIDCHECMB(object LEOPDAJLNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3D52470", Offset = "0x3D51670", VA = "0x183D52470")]
	public bool IAKKNJLNOIC(object LEOPDAJLNNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3D524D0", Offset = "0x3D516D0", VA = "0x183D524D0")]
	public void JECCAKDMNFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3D52560", Offset = "0x3D51760", VA = "0x183D52560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3D526C0", Offset = "0x3D518C0", VA = "0x183D526C0")]
	public AKLBCAHEGND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class KOEEOENAFNJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct BKLLDMLJAOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public float AGECNIHDPBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public T NBLACJEKEDC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Dictionary<object, BKLLDMLJAOI> AMIFPLCLAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private T KLMOEEKNAJK;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T CKDEIJLNJAK
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xF9E4D0", Offset = "0xF9D6D0", VA = "0x180F9E4D0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x26B0170", Offset = "0x26AF370", VA = "0x1826B0170", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public object MPIHIIMMMMI
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x44C670", Offset = "0x44B870", VA = "0x18044C670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x514DD0", Offset = "0x513FD0", VA = "0x180514DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool GPHMDJBKJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2A4AA30", Offset = "0x2A49C30", VA = "0x182A4AA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2A4AB40", Offset = "0x2A49D40", VA = "0x182A4AB40")]
	public bool LDGHDILJELL(T NAOGMHDFAEF, object LEOPDAJLNNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2A4AE00", Offset = "0x2A4A000", VA = "0x182A4AE00")]
	public bool NCFDPNMJHEB(object LEOPDAJLNNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x26B01C0", Offset = "0x26AF3C0", VA = "0x1826B01C0")]
	public void JOFBHKLPDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x2E3AE60", Offset = "0x2E3A060", VA = "0x182E3AE60")]
	public bool ACCNBKIANOB(object LEOPDAJLNNM, out T NAOGMHDFAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2E3BAF0", Offset = "0x2E3ACF0", VA = "0x182E3BAF0")]
	private bool OIAIHHNIMDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2A4BB80", Offset = "0x2A4AD80", VA = "0x182A4BB80")]
	public KOEEOENAFNJ()
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
