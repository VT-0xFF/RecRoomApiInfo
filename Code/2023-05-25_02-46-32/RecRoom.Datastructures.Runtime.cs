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
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000002")]
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
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x80EE30", Offset = "0x80D630", VA = "0x18080EE30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xADC640", Offset = "0xADAE40", VA = "0x180ADC640")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xADC7F0", Offset = "0xADAFF0", VA = "0x180ADC7F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "4")]
	public virtual void JFMEPFIDBGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	[GGOALGOKAII]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x47A0E20", Offset = "0x479F620", VA = "0x1847A0E20", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x47A0550", Offset = "0x479ED50", VA = "0x1847A0550", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x47A1360", Offset = "0x479FB60", VA = "0x1847A1360")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class MMJMINFFNBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public MMJMINFFNBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0600", Offset = "0x2F9EE00", VA = "0x182FA0600")]
		internal int BFMJKLDOFHH(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[GGOALGOKAII]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1863BC0", Offset = "0x18623C0", VA = "0x181863BC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1863BF0", Offset = "0x18623F0", VA = "0x181863BF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1863B10", Offset = "0x1862310", VA = "0x181863B10", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public TVal this[TKey BDFCACLHAFA]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1863B70", Offset = "0x1862370", VA = "0x181863B70", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1863A10", Offset = "0x1862210", VA = "0x181863A10", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1863560", Offset = "0x1861D60", VA = "0x181863560", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1862D80", Offset = "0x1861580", VA = "0x181862D80", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1862A30", Offset = "0x1861230", VA = "0x181862A30", Slot = "14")]
	protected virtual string NEFECHKBEFL(TKeyVal BNDCFAJLFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1862910", Offset = "0x1861110", VA = "0x181862910", Slot = "4")]
	public bool ContainsKey(TKey BDFCACLHAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1863900", Offset = "0x1862100", VA = "0x181863900", Slot = "5")]
	public bool TryGetValue(TKey BDFCACLHAFA, out TVal ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1862940", Offset = "0x1861140", VA = "0x181862940", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1862940", Offset = "0x1861140", VA = "0x181862940", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1863930", Offset = "0x1862130", VA = "0x181863930")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CNNIIPPIOPJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class OBBBBFHBOEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public OBBBBFHBOEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x31454E0", Offset = "0x3143CE0", VA = "0x1831454E0")]
		internal bool FAENIIHPBOI(global::DKKIFMJJILM<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float EIBCHBCFBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float OKOJMDPOAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<global::DKKIFMJJILM<float, T>> PELCAIHKCCE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int JOKICCHKEPE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x39118D0", Offset = "0x39100D0", VA = "0x1839118D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3911C70", Offset = "0x3910470", VA = "0x183911C70")]
	public CNNIIPPIOPJ(float DKKFNKOOCJP, float IPJBOBKGHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3911950", Offset = "0x3910150", VA = "0x183911950")]
	public bool LMBLOMODHDD(float EAJNKPCKLBB, T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3911C10", Offset = "0x3910410", VA = "0x183911C10")]
	public int OLCBCPFMDCE(float EAJNKPCKLBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x39111D0", Offset = "0x390F9D0", VA = "0x1839111D0")]
	public IEnumerable<T> JJMGPPHLILD(float EAJNKPCKLBB, [Optional] float? LMJBKPCPDMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x39111A0", Offset = "0x390F9A0", VA = "0x1839111A0")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x39110E0", Offset = "0x390F8E0", VA = "0x1839110E0")]
	private void BNPCLNEKCJI(float EAJNKPCKLBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T MHGNIJCIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x43041B0", Offset = "0x43029B0", VA = "0x1843041B0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x43041C0", Offset = "0x43029C0", VA = "0x1843041C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float KCJJFHHFMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x10D00E0", Offset = "0x10CE8E0", VA = "0x1810D00E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4303EE0", Offset = "0x43026E0", VA = "0x184303EE0")]
	public T AMDGGMCPAGC(float NFOHJNABMAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x43041D0", Offset = "0x43029D0", VA = "0x1843041D0")]
	public T GHIOHNJFFFC(float NFOHJNABMAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GAIKGPLFBOK(T EOEOFNCKKHJ, T AOEAFBFCPPC, float NFOHJNABMAP);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3E80E30", Offset = "0x3E7F630", VA = "0x183E80E30", Slot = "4")]
	protected override float GAIKGPLFBOK(float EOEOFNCKKHJ, float AOEAFBFCPPC, float NFOHJNABMAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6F4CED0", Offset = "0x6F4B6D0", VA = "0x186F4CED0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2277340", Offset = "0x2275B40", VA = "0x182277340", Slot = "4")]
	protected override Vector3 GAIKGPLFBOK(Vector3 EOEOFNCKKHJ, Vector3 AOEAFBFCPPC, float NFOHJNABMAP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F524A0", Offset = "0x6F50CA0", VA = "0x186F524A0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x15F7160", Offset = "0x15F5960", VA = "0x1815F7160", Slot = "4")]
	protected override Color GAIKGPLFBOK(Color EOEOFNCKKHJ, Color AOEAFBFCPPC, float NFOHJNABMAP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C980", Offset = "0x6F4B180", VA = "0x186F4C980")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HKFGBLBDDNE
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2325260", Offset = "0x2323A60", VA = "0x182325260")]
	public static global::JNBEGEHKKJM<T1> JLAKJAPJOGA<T1>(T1 JOIOHBCDFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2DDAC90", Offset = "0x2DD9490", VA = "0x182DDAC90")]
	public static global::DKKIFMJJILM<T1, T2> JLAKJAPJOGA<T1, T2>(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2DDAD00", Offset = "0x2DD9500", VA = "0x182DDAD00")]
	public static global::HOMFIJMJJHM<T1, T2, T3> JLAKJAPJOGA<T1, T2, T3>(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x240C040", Offset = "0x240A840", VA = "0x18240C040")]
	public static global::CDDKCCPIDDP<T1, T2, T3, T4> JLAKJAPJOGA<T1, T2, T3, T4>(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2DDAFD0", Offset = "0x2DD97D0", VA = "0x182DDAFD0")]
	public static global::ADGBDOJBFMC<T1, T2, T3, T4, T5> JLAKJAPJOGA<T1, T2, T3, T4, T5>(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2DDAF20", Offset = "0x2DD9720", VA = "0x182DDAF20")]
	public static global::GEOAJILLIMF<T1, T2, T3, T4, T5, T6> JLAKJAPJOGA<T1, T2, T3, T4, T5, T6>(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ, T6 EMIINFLAGLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2DDAE60", Offset = "0x2DD9660", VA = "0x182DDAE60")]
	public static global::ICIIMIDMKDJ<T1, T2, T3, T4, T5, T6, T7> JLAKJAPJOGA<T1, T2, T3, T4, T5, T6, T7>(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ, T6 EMIINFLAGLO, T7 IEGCJACCDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2DDAD90", Offset = "0x2DD9590", VA = "0x182DDAD90")]
	public static global::OFIAOOPFNIN<T1, T2, T3, T4, T5, T6, T7, T8> JLAKJAPJOGA<T1, T2, T3, T4, T5, T6, T7, T8>(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ, T6 EMIINFLAGLO, T7 IEGCJACCDDH, T8 BLDJGMBLIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2434800", Offset = "0x2433000", VA = "0x182434800")]
	[IteratorStateMachine(typeof(PNGEMDOFCPN))]
	public static IEnumerable<global::DKKIFMJJILM<T1, T2>> IIONLKHJGPM<T1, T2>(IEnumerable<T1> NBLDAOBEAEA, IEnumerable<T2> PAJLLFKCBBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x26CCC00", Offset = "0x26CB400", VA = "0x1826CCC00")]
	[IteratorStateMachine(typeof(DGHBLAMNHLE))]
	public static IEnumerable<global::HOMFIJMJJHM<T1, T2, T3>> IIONLKHJGPM<T1, T2, T3>(IEnumerable<T1> NBLDAOBEAEA, IEnumerable<T2> PAJLLFKCBBD, IEnumerable<T3> CKEDCDKNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D5E0", Offset = "0x6F4BDE0", VA = "0x186F4D5E0")]
	internal static int LGKODIFOLJA(int PMBDJGMHKEL, int FPPGIJAPGLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D640", Offset = "0x6F4BE40", VA = "0x186F4D640")]
	internal static int LGKODIFOLJA(int PMBDJGMHKEL, int FPPGIJAPGLA, int HPCKIBLPPLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D620", Offset = "0x6F4BE20", VA = "0x186F4D620")]
	internal static int LGKODIFOLJA(int PMBDJGMHKEL, int FPPGIJAPGLA, int HPCKIBLPPLG, int LMGFBGGABJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D680", Offset = "0x6F4BE80", VA = "0x186F4D680")]
	internal static int LGKODIFOLJA(int PMBDJGMHKEL, int FPPGIJAPGLA, int HPCKIBLPPLG, int LMGFBGGABJK, int FKFGAJKGKKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D5F0", Offset = "0x6F4BDF0", VA = "0x186F4D5F0")]
	internal static int LGKODIFOLJA(int PMBDJGMHKEL, int FPPGIJAPGLA, int HPCKIBLPPLG, int LMGFBGGABJK, int FKFGAJKGKKO, int AKHLOFDPCJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D5B0", Offset = "0x6F4BDB0", VA = "0x186F4D5B0")]
	internal static int LGKODIFOLJA(int PMBDJGMHKEL, int FPPGIJAPGLA, int HPCKIBLPPLG, int LMGFBGGABJK, int FKFGAJKGKKO, int AKHLOFDPCJO, int GAJHMIDDLHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D650", Offset = "0x6F4BE50", VA = "0x186F4D650")]
	internal static int LGKODIFOLJA(int PMBDJGMHKEL, int FPPGIJAPGLA, int HPCKIBLPPLG, int LMGFBGGABJK, int FKFGAJKGKKO, int AKHLOFDPCJO, int GAJHMIDDLHL, int IAFFEMADAAG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JNBEGEHKKJM<T1> : IComparable<global::JNBEGEHKKJM<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T1 OOBAPIBDNNO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1CA08D0", Offset = "0x1C9F0D0", VA = "0x181CA08D0")]
	public JNBEGEHKKJM(T1 JOIOHBCDFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3D18970", Offset = "0x3D17170", VA = "0x183D18970", Slot = "4")]
	public int CompareTo(global::JNBEGEHKKJM<T1> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3D189E0", Offset = "0x3D171E0", VA = "0x183D189E0", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xAF0720", Offset = "0xAEEF20", VA = "0x180AF0720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3D18A80", Offset = "0x3D17280", VA = "0x183D18A80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DKKIFMJJILM<T1, T2> : IComparable<global::DKKIFMJJILM<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly T1 OOBAPIBDNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T2 NEDEEMBHHOC;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2E0CCA0", Offset = "0x2E0B4A0", VA = "0x182E0CCA0")]
	public DKKIFMJJILM(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2F80360", Offset = "0x2F7EB60", VA = "0x182F80360", Slot = "4")]
	public int CompareTo(global::DKKIFMJJILM<T1, T2> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2F80580", Offset = "0x2F7ED80", VA = "0x182F80580", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2F81220", Offset = "0x2F7FA20", VA = "0x182F81220", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2F81B00", Offset = "0x2F80300", VA = "0x182F81B00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HOMFIJMJJHM<T1, T2, T3> : IComparable<global::HOMFIJMJJHM<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly T1 OOBAPIBDNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly T2 NEDEEMBHHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly T3 PDJIKFHNIKB;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x358CBE0", Offset = "0x358B3E0", VA = "0x18358CBE0")]
	public HOMFIJMJJHM(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x358C320", Offset = "0x358AB20", VA = "0x18358C320", Slot = "4")]
	public int CompareTo(global::HOMFIJMJJHM<T1, T2, T3> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x358C520", Offset = "0x358AD20", VA = "0x18358C520", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x358C7B0", Offset = "0x358AFB0", VA = "0x18358C7B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x358C8A0", Offset = "0x358B0A0", VA = "0x18358C8A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CDDKCCPIDDP<T1, T2, T3, T4> : IComparable<global::CDDKCCPIDDP<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 OOBAPIBDNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T2 NEDEEMBHHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T3 PDJIKFHNIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T4 MNAHNNCCKKF;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1CB4180", Offset = "0x1CB2980", VA = "0x181CB4180")]
	public CDDKCCPIDDP(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2D4C600", Offset = "0x2D4AE00", VA = "0x182D4C600", Slot = "4")]
	public int CompareTo(global::CDDKCCPIDDP<T1, T2, T3, T4> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2D4C740", Offset = "0x2D4AF40", VA = "0x182D4C740", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2D4C880", Offset = "0x2D4B080", VA = "0x182D4C880", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2D4C940", Offset = "0x2D4B140", VA = "0x182D4C940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ADGBDOJBFMC<T1, T2, T3, T4, T5> : IComparable<global::ADGBDOJBFMC<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T1 OOBAPIBDNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T2 NEDEEMBHHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T3 PDJIKFHNIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T4 MNAHNNCCKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T5 IIENJDPJBMD;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2FA5FD0", Offset = "0x2FA47D0", VA = "0x182FA5FD0")]
	public ADGBDOJBFMC(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3B9E470", Offset = "0x3B9CC70", VA = "0x183B9E470", Slot = "4")]
	public int CompareTo(global::ADGBDOJBFMC<T1, T2, T3, T4, T5> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3B9E5F0", Offset = "0x3B9CDF0", VA = "0x183B9E5F0", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3B9E760", Offset = "0x3B9CF60", VA = "0x183B9E760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3B9E860", Offset = "0x3B9D060", VA = "0x183B9E860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GEOAJILLIMF<T1, T2, T3, T4, T5, T6> : IComparable<global::GEOAJILLIMF<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T1 OOBAPIBDNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T2 NEDEEMBHHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T3 PDJIKFHNIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T4 MNAHNNCCKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T5 IIENJDPJBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T6 JFBLCIDLNCG;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB830", Offset = "0x2BDA030", VA = "0x182BDB830")]
	public GEOAJILLIMF(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ, T6 EMIINFLAGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB250", Offset = "0x2BD9A50", VA = "0x182BDB250", Slot = "4")]
	public int CompareTo(global::GEOAJILLIMF<T1, T2, T3, T4, T5, T6> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB410", Offset = "0x2BD9C10", VA = "0x182BDB410", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB5A0", Offset = "0x2BD9DA0", VA = "0x182BDB5A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB6C0", Offset = "0x2BD9EC0", VA = "0x182BDB6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ICIIMIDMKDJ<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::ICIIMIDMKDJ<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 OOBAPIBDNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 NEDEEMBHHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 PDJIKFHNIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 MNAHNNCCKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 IIENJDPJBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 JFBLCIDLNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T7 AHKLAPOGIEA;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x51F6740", Offset = "0x51F4F40", VA = "0x1851F6740")]
	public ICIIMIDMKDJ(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ, T6 EMIINFLAGLO, T7 IEGCJACCDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x51F60A0", Offset = "0x51F48A0", VA = "0x1851F60A0", Slot = "4")]
	public int CompareTo(global::ICIIMIDMKDJ<T1, T2, T3, T4, T5, T6, T7> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x51F62A0", Offset = "0x51F4AA0", VA = "0x1851F62A0", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x51F6460", Offset = "0x51F4C60", VA = "0x1851F6460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x51F65B0", Offset = "0x51F4DB0", VA = "0x1851F65B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class OFIAOOPFNIN<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::OFIAOOPFNIN<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T1 OOBAPIBDNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T2 NEDEEMBHHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T3 PDJIKFHNIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T4 MNAHNNCCKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T5 IIENJDPJBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T6 JFBLCIDLNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T7 AHKLAPOGIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T8 MGGEGLLBIIB;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3AA65E0", Offset = "0x3AA4DE0", VA = "0x183AA65E0")]
	public OFIAOOPFNIN(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ, T6 EMIINFLAGLO, T7 IEGCJACCDDH, T8 BLDJGMBLIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5E90", Offset = "0x3AA4690", VA = "0x183AA5E90", Slot = "4")]
	public int CompareTo(global::OFIAOOPFNIN<T1, T2, T3, T4, T5, T6, T7, T8> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3AA60E0", Offset = "0x3AA48E0", VA = "0x183AA60E0", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3AA62C0", Offset = "0x3AA4AC0", VA = "0x183AA62C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6430", Offset = "0x3AA4C30", VA = "0x183AA6430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GGOALGOKAII : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x92DE00", Offset = "0x92C600", VA = "0x18092DE00")]
	public GGOALGOKAII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class HashableScriptableObject : ScriptableObject, IEEAIAKPCEK, INPIODOCMAF, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x811A70", Offset = "0x810270", VA = "0x180811A70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF10", Offset = "0x8AB710", VA = "0x1808ACF10", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x94BA40", Offset = "0x94A240", VA = "0x18094BA40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash DKKDLHLFHOF);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xBBBD50", Offset = "0xBBA550", VA = "0x180BBBD50")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[LBBBOIMCAIE]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[SerializeField]
	[LBBBOIMCAIE]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F51380", Offset = "0x6F4FB80", VA = "0x186F51380")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6F51340", Offset = "0x6F4FB40", VA = "0x186F51340")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F513C0", Offset = "0x6F4FBC0", VA = "0x186F513C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F51590", Offset = "0x6F4FD90", VA = "0x186F51590")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6F51500", Offset = "0x6F4FD00", VA = "0x186F51500")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xBBBD80", Offset = "0xBBA580", VA = "0x180BBBD80")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xBBBD90", Offset = "0xBBA590", VA = "0x180BBBD90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F51300", Offset = "0x6F4FB00", VA = "0x186F51300")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F51470", Offset = "0x6F4FC70", VA = "0x186F51470")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6F50F30", Offset = "0x6F4F730", VA = "0x186F50F30")]
	public void CopyBounds(SavedExtents MDHJAFNLPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6F51260", Offset = "0x6F4FA60", VA = "0x186F51260")]
	public void SetLocalSpaceBounds(Bounds PDOKDMEPNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6F508D0", Offset = "0x6F4F0D0", VA = "0x186F508D0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6F51250", Offset = "0x6F4FA50", VA = "0x186F51250")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6F506E0", Offset = "0x6F4EEE0", VA = "0x186F506E0")]
	private void AMFJDGCNLGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6F51020", Offset = "0x6F4F820", VA = "0x186F51020")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6F508F0", Offset = "0x6F4F0F0", VA = "0x186F508F0")]
	public static void CalculateLocalBoundsFor(GameObject ALBKEDBKENG, out Bounds PDOKDMEPNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6F50F60", Offset = "0x6F4F760", VA = "0x186F50F60")]
	private static void MMDCCKHCKON(Bounds PAJLLFKCBBD, Color CKEDCDKNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6F51280", Offset = "0x6F4FA80", VA = "0x186F51280")]
	public SavedExtents()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class FGGONGOBJMA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct BDJKFENFEFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public T MHGNIJCIFFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float CNINICBHKIE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static float MGJJPDPIMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private List<T> AINCAOMCLBE;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private const int ACNLCFDBDJJ = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private BDJKFENFEFM[] EABDNHJFDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int BAPAIKADPMC;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float DCPNKAMOCIG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xBBDDC0", Offset = "0xBBC5C0", VA = "0x180BBDDC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xEF33A0", Offset = "0xEF1BA0", VA = "0x180EF33A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x35EE6B0", Offset = "0x35ECEB0", VA = "0x1835EE6B0")]
	public FGGONGOBJMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x35EE5B0", Offset = "0x35ECDB0", VA = "0x1835EE5B0")]
	public FGGONGOBJMA(int GEFPLPIBMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x35ED270", Offset = "0x35EBA70", VA = "0x1835ED270")]
	public void CAILCKFFJIK(float EAJNKPCKLBB, T ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x35ED350", Offset = "0x35EBB50", VA = "0x1835ED350")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x35EDDB0", Offset = "0x35EC5B0", VA = "0x1835EDDB0")]
	public bool LDONHAGGEGK(float JINIMOJBGDF, float LMCEDNNCHKG, out T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x35ED740", Offset = "0x35EBF40", VA = "0x1835ED740")]
	public bool FEGGBFBCJPA(float JINIMOJBGDF, float LMCEDNNCHKG, out T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x35EE2B0", Offset = "0x35ECAB0", VA = "0x1835EE2B0")]
	public void MHMAJDPNOML(float JINIMOJBGDF, float LMCEDNNCHKG, List<T> NLANKBLAOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x35EE530", Offset = "0x35ECD30", VA = "0x1835EE530")]
	private int MOBMDCJCEJA(int CFJGKJHIILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x35EDBC0", Offset = "0x35EC3C0", VA = "0x1835EDBC0")]
	private void GMIFGBMNEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T AHFJOCGODJH();

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T GAIKGPLFBOK(T EOEOFNCKKHJ, T AOEAFBFCPPC, float NFOHJNABMAP);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T BOIJDEBEJHH(T ECNGHFJBIJL, float NFOHJNABMAP);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T GHONKFPHFFA(T EOEOFNCKKHJ, T AOEAFBFCPPC);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T GIBLADJBOON(T EOEOFNCKKHJ, T AOEAFBFCPPC);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AEKEOHGLNID : global::FGGONGOBJMA<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1599D60", Offset = "0x1598560", VA = "0x181599D60", Slot = "4")]
	protected override Vector3 AHFJOCGODJH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2277340", Offset = "0x2275B40", VA = "0x182277340", Slot = "5")]
	protected override Vector3 GAIKGPLFBOK(Vector3 EOEOFNCKKHJ, Vector3 AOEAFBFCPPC, float NFOHJNABMAP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AFE0", Offset = "0x6F497E0", VA = "0x186F4AFE0", Slot = "6")]
	protected override Vector3 BOIJDEBEJHH(Vector3 ECNGHFJBIJL, float NFOHJNABMAP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B040", Offset = "0x6F49840", VA = "0x186F4B040", Slot = "7")]
	protected override Vector3 GHONKFPHFFA(Vector3 EOEOFNCKKHJ, Vector3 AOEAFBFCPPC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B0C0", Offset = "0x6F498C0", VA = "0x186F4B0C0", Slot = "8")]
	protected override Vector3 GIBLADJBOON(Vector3 EOEOFNCKKHJ, Vector3 AOEAFBFCPPC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B130", Offset = "0x6F49930", VA = "0x186F4B130")]
	public AEKEOHGLNID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GPEJKPPFPKA : global::FGGONGOBJMA<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F4CFA0", Offset = "0x6F4B7A0", VA = "0x186F4CFA0")]
	public GPEJKPPFPKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F4CF30", Offset = "0x6F4B730", VA = "0x186F4CF30")]
	public GPEJKPPFPKA(int GEFPLPIBMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xD8DDF0", Offset = "0xD8C5F0", VA = "0x180D8DDF0", Slot = "4")]
	protected override float AHFJOCGODJH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3E80E30", Offset = "0x3E7F630", VA = "0x183E80E30", Slot = "5")]
	protected override float GAIKGPLFBOK(float EOEOFNCKKHJ, float AOEAFBFCPPC, float NFOHJNABMAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5B802E0", Offset = "0x5B7EAE0", VA = "0x185B802E0", Slot = "6")]
	protected override float BOIJDEBEJHH(float ECNGHFJBIJL, float NFOHJNABMAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F4CF10", Offset = "0x6F4B710", VA = "0x186F4CF10", Slot = "7")]
	protected override float GHONKFPHFFA(float EOEOFNCKKHJ, float AOEAFBFCPPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F4CF20", Offset = "0x6F4B720", VA = "0x186F4CF20", Slot = "8")]
	protected override float GIBLADJBOON(float EOEOFNCKKHJ, float AOEAFBFCPPC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KIGJBHHMGOL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly IDisposable EABDDJEADPB;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public KIGJBHHMGOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ILMMOMFFIAJ : global::ODDMALFOGNH<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D7A0", Offset = "0x6F4BFA0", VA = "0x186F4D7A0")]
	public ILMMOMFFIAJ(int CABFJBCMJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D7F0", Offset = "0x6F4BFF0", VA = "0x186F4D7F0")]
	public ILMMOMFFIAJ(LJBOMMPGMCM[] LMHLDELFGFA, bool BFBLJDNFJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D730", Offset = "0x6F4BF30", VA = "0x186F4D730", Slot = "6")]
	protected override uint NOOACFKFHCM(uint DKKDLHLFHOF, string ECNGHFJBIJL)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class AMPEKBKFHNB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public readonly struct EOLEDHHFLLG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly global::AMPEKBKFHNB<T> GFKFIAALCBF;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T MHGNIJCIFFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x185E570", Offset = "0x185CD70", VA = "0x18185E570")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x185E590", Offset = "0x185CD90", VA = "0x18185E590", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xB91230", Offset = "0xB8FA30", VA = "0x180B91230")]
		public EOLEDHHFLLG(global::AMPEKBKFHNB<T> GFKFIAALCBF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class BDNJBAEGAII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder<EOLEDHHFLLG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public global::AMPEKBKFHNB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public BDNJBAEGAII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2D0A640", Offset = "0x2D08E40", VA = "0x182D0A640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class AOJFJKEBMGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<EOLEDHHFLLG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public global::AMPEKBKFHNB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public AOJFJKEBMGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3B13C90", Offset = "0x3B12490", VA = "0x183B13C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly SemaphoreSlim HLKNAPHLMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private T GIFKGKNAFME;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int GJAANALIPGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3B123F0", Offset = "0x3B10BF0", VA = "0x183B123F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3B124B0", Offset = "0x3B10CB0", VA = "0x183B124B0")]
	public AMPEKBKFHNB(in T GIFKGKNAFME, int AOMOMCDDNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3B12550", Offset = "0x3B10D50", VA = "0x183B12550")]
	public AMPEKBKFHNB(in T GIFKGKNAFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3B11CB0", Offset = "0x3B104B0", VA = "0x183B11CB0")]
	public EOLEDHHFLLG DJCIPMFGKEI()
	{
		return default(EOLEDHHFLLG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3B11C70", Offset = "0x3B10470", VA = "0x183B11C70")]
	public EOLEDHHFLLG DJCIPMFGKEI(CancellationToken GFFFFCALMCA)
	{
		return default(EOLEDHHFLLG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3B12070", Offset = "0x3B10870", VA = "0x183B12070")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::AMPEKBKFHNB<>.BDNJBAEGAII))]
	public Task<EOLEDHHFLLG> KPABIKOBAPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3B11EA0", Offset = "0x3B106A0", VA = "0x183B11EA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::AMPEKBKFHNB<>.AOJFJKEBMGC))]
	public Task<EOLEDHHFLLG> KPABIKOBAPK(CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class CODPNHOLMNA
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C920", Offset = "0x6F4B120", VA = "0x186F4C920")]
	public static global::AMPEKBKFHNB<DPIJIKFEAOC> DOBPLOGGNLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C8B0", Offset = "0x6F4B0B0", VA = "0x186F4C8B0")]
	public static global::AMPEKBKFHNB<DPIJIKFEAOC> DOBPLOGGNLM(int AOMOMCDDNBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2325260", Offset = "0x2323A60", VA = "0x182325260")]
	public static global::AMPEKBKFHNB<T> DOBPLOGGNLM<T>(in T GIFKGKNAFME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2C002F0", Offset = "0x2BFEAF0", VA = "0x182C002F0")]
	public static global::AMPEKBKFHNB<T> DOBPLOGGNLM<T>(in T GIFKGKNAFME, int AOMOMCDDNBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class PGDLNHIILLB<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private global::PGDLNHIILLB<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x841940", Offset = "0x840140", VA = "0x180841940", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x34CA940", Offset = "0x34C9140", VA = "0x1834CA940", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x334BEA0", Offset = "0x334A6A0", VA = "0x18334BEA0")]
		public Enumerator(global::PGDLNHIILLB<T> NLANKBLAOCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x34C84C0", Offset = "0x34C6CC0", VA = "0x1834C84C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x34C9B50", Offset = "0x34C8350", VA = "0x1834C9B50", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x34C6FC0", Offset = "0x34C57C0", VA = "0x1834C6FC0")]
		private void LBPMHNCKNKL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private T[] FFPFEFDNOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private int GOGKDEGLBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private int JBOMFIHOBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private int FPBNFBFIPHI;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x40ACA60", Offset = "0x40AB260", VA = "0x1840ACA60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x40AB440", Offset = "0x40A9C40", VA = "0x1840AB440")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x40AB670", Offset = "0x40A9E70", VA = "0x1840AB670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x40AD010", Offset = "0x40AB810", VA = "0x1840AD010")]
	public PGDLNHIILLB(int CABFJBCMJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x40AB0D0", Offset = "0x40A98D0", VA = "0x1840AB0D0")]
	public void CAILCKFFJIK(T NFOHJNABMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x40AC190", Offset = "0x40AA990", VA = "0x1840AC190")]
	public void MIEPPGEFOLJ(IEnumerable<T> OMCHMPJJNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x40AB3C0", Offset = "0x40A9BC0", VA = "0x1840AB3C0")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x40ABCE0", Offset = "0x40AA4E0", VA = "0x1840ABCE0")]
	public void LENIFPHCDAG(int FGHOJPFDCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x40AB560", Offset = "0x40A9D60", VA = "0x1840AB560")]
	public void GECMALKHHPP(int FGHOJPFDCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x40AB920", Offset = "0x40AA120", VA = "0x1840AB920")]
	public void IMKOGLOMGAJ(T[] EABDNHJFDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x40ABD70", Offset = "0x40AA570", VA = "0x1840ABD70")]
	public Enumerator MEOEHOBEEMI()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x40ACF90", Offset = "0x40AB790", VA = "0x1840ACF90", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x40ACF90", Offset = "0x40AB790", VA = "0x1840ACF90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x40ACC80", Offset = "0x40AB480", VA = "0x1840ACC80")]
	private int OBAPAMDGAKF(int NHHNPPKPBIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x40ACE60", Offset = "0x40AB660", VA = "0x1840ACE60")]
	private int PDCILPABJMN(int NHHNPPKPBIA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class KJFMDBFPCPL
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void NACLKOJNEAO(object[] PFFFGKKOEPM);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	protected KJFMDBFPCPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class PEMOMEOLKEJ<T> : KJFMDBFPCPL
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	protected struct DDFBELANOCE
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum FJMLGHLLHOP
		{
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public FJMLGHLLHOP FIJCKHKKDCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public T FOGMDOMFJBB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private int KNBILKDKKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly bool IHLCILHELIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	protected readonly bool CICPIOFKENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	protected List<T> EGKNAOOFGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<DDFBELANOCE> HCIOCPBELBH;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool BOFOJEMFJAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x40A92E0", Offset = "0x40A7AE0", VA = "0x1840A92E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x40A9460", Offset = "0x40A7C60", VA = "0x1840A9460")]
	protected PEMOMEOLKEJ(bool CICPIOFKENJ, bool IHLCILHELIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x40A93E0", Offset = "0x40A7BE0", VA = "0x1840A93E0")]
	protected bool KNGMDNHCGFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x40A9320", Offset = "0x40A7B20", VA = "0x1840A9320")]
	protected void KBBPAIDBMGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x40A8D70", Offset = "0x40A7570", VA = "0x1840A8D70")]
	protected void ABDCADBEJBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3761450", Offset = "0x375FC50", VA = "0x183761450")]
	private static void OGPPOMJFBOH<U>(ref List<U> IFADMANLNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x40A8F20", Offset = "0x40A7720", VA = "0x1840A8F20", Slot = "5")]
	public void CAILCKFFJIK(T FOGMDOMFJBB, bool AKPODJDOLHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x40A9080", Offset = "0x40A7880", VA = "0x1840A9080", Slot = "6")]
	public void CPPHPNNFPKL(T FOGMDOMFJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x40A91D0", Offset = "0x40A79D0", VA = "0x1840A91D0")]
	public void ELJLHOEKJGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface CFELNKMGIIB
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAILCKFFJIK(Action FOGMDOMFJBB, bool AKPODJDOLHD = false);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPPHPNNFPKL(Action FOGMDOMFJBB);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class KBJOPGEOOCH : global::PEMOMEOLKEJ<Action>, CFELNKMGIIB
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DC30", Offset = "0x6F4C430", VA = "0x186F4DC30")]
	public KBJOPGEOOCH(bool CICPIOFKENJ = false, bool IHLCILHELIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D960", Offset = "0x6F4C160", VA = "0x186F4D960")]
	public void MKOHINBGHOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DB60", Offset = "0x6F4C360", VA = "0x186F4DB60", Slot = "4")]
	public override void NACLKOJNEAO(object[] PFFFGKKOEPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DBD0", Offset = "0x6F4C3D0", VA = "0x186F4DBD0")]
	public static KBJOPGEOOCH OGNHPCPAOIL(KBJOPGEOOCH GJLGCDFBOPB, Action FOGMDOMFJBB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D900", Offset = "0x6F4C100", VA = "0x186F4D900")]
	public static KBJOPGEOOCH EPKAGIOEOFM(KBJOPGEOOCH GJLGCDFBOPB, Action FOGMDOMFJBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface JEMMICINFPD<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAILCKFFJIK(Action<T> FOGMDOMFJBB, bool AKPODJDOLHD = false);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPPHPNNFPKL(Action<T> FOGMDOMFJBB);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class NAOGJOJMPFD<T> : global::PEMOMEOLKEJ<Action<T>>, global::JEMMICINFPD<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2499C00", Offset = "0x2498400", VA = "0x182499C00")]
	public NAOGJOJMPFD(bool CICPIOFKENJ = false, bool IHLCILHELIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3419720", Offset = "0x3417F20", VA = "0x183419720")]
	public void MKOHINBGHOB(T NFOHJNABMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x341BD80", Offset = "0x341A580", VA = "0x18341BD80", Slot = "4")]
	public override void NACLKOJNEAO(object[] PFFFGKKOEPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x341C740", Offset = "0x341AF40", VA = "0x18341C740")]
	public static global::NAOGJOJMPFD<T> OGNHPCPAOIL(global::NAOGJOJMPFD<T> GJLGCDFBOPB, Action<T> FOGMDOMFJBB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3418AB0", Offset = "0x34172B0", VA = "0x183418AB0")]
	public static global::NAOGJOJMPFD<T> EPKAGIOEOFM(global::NAOGJOJMPFD<T> GJLGCDFBOPB, Action<T> FOGMDOMFJBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface MKOCEIDPNEN<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAILCKFFJIK(Action<T, U> FOGMDOMFJBB, bool AKPODJDOLHD = false);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPPHPNNFPKL(Action<T, U> FOGMDOMFJBB);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class HJMCHKIHGED<T, U> : global::PEMOMEOLKEJ<Action<T, U>>, global::MKOCEIDPNEN<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2499C00", Offset = "0x2498400", VA = "0x182499C00")]
	public HJMCHKIHGED(bool CICPIOFKENJ = false, bool IHLCILHELIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4530E20", Offset = "0x452F620", VA = "0x184530E20")]
	public void MKOHINBGHOB(T NFOHJNABMAP, U CFKHIDLOGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4533B40", Offset = "0x4532340", VA = "0x184533B40", Slot = "4")]
	public override void NACLKOJNEAO(object[] PFFFGKKOEPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x45359E0", Offset = "0x45341E0", VA = "0x1845359E0")]
	public static global::HJMCHKIHGED<T, U> OGNHPCPAOIL(global::HJMCHKIHGED<T, U> GJLGCDFBOPB, Action<T, U> FOGMDOMFJBB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x452FD60", Offset = "0x452E560", VA = "0x18452FD60")]
	public static global::HJMCHKIHGED<T, U> EPKAGIOEOFM(global::HJMCHKIHGED<T, U> GJLGCDFBOPB, Action<T, U> FOGMDOMFJBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface FEBNCCLAJPG<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAILCKFFJIK(Action<T, U, V> FOGMDOMFJBB, bool AKPODJDOLHD = false);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPPHPNNFPKL(Action<T, U, V> FOGMDOMFJBB);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class KJIOPDDOALH<T, U, V> : global::PEMOMEOLKEJ<Action<T, U, V>>, global::FEBNCCLAJPG<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2499C00", Offset = "0x2498400", VA = "0x182499C00")]
	public KJIOPDDOALH(bool CICPIOFKENJ = false, bool IHLCILHELIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x324DA50", Offset = "0x324C250", VA = "0x18324DA50")]
	public void MKOHINBGHOB(T NFOHJNABMAP, U CFKHIDLOGCG, V KNLEJKEBOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x324F4A0", Offset = "0x324DCA0", VA = "0x18324F4A0", Slot = "4")]
	public override void NACLKOJNEAO(object[] PFFFGKKOEPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3250E30", Offset = "0x324F630", VA = "0x183250E30")]
	public static global::KJIOPDDOALH<T, U, V> OGNHPCPAOIL(global::KJIOPDDOALH<T, U, V> GJLGCDFBOPB, Action<T, U, V> FOGMDOMFJBB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x324CF50", Offset = "0x324B750", VA = "0x18324CF50")]
	public static global::KJIOPDDOALH<T, U, V> EPKAGIOEOFM(global::KJIOPDDOALH<T, U, V> GJLGCDFBOPB, Action<T, U, V> FOGMDOMFJBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface CDKHBNHOIDE<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAILCKFFJIK(Action<T, U, V, W> FOGMDOMFJBB, bool AKPODJDOLHD = false);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPPHPNNFPKL(Action<T, U, V, W> FOGMDOMFJBB);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class KBBANGGGBBP<T, U, V, W> : global::PEMOMEOLKEJ<Action<T, U, V, W>>, global::CDKHBNHOIDE<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2499C00", Offset = "0x2498400", VA = "0x182499C00")]
	public KBBANGGGBBP(bool CICPIOFKENJ = false, bool IHLCILHELIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2497970", Offset = "0x2496170", VA = "0x182497970")]
	public void MKOHINBGHOB(T NFOHJNABMAP, U CFKHIDLOGCG, V KNLEJKEBOMM, W OJBIOMHAGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x24998F0", Offset = "0x24980F0", VA = "0x1824998F0", Slot = "4")]
	public override void NACLKOJNEAO(object[] PFFFGKKOEPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2499B60", Offset = "0x2498360", VA = "0x182499B60")]
	public static global::KBBANGGGBBP<T, U, V, W> OGNHPCPAOIL(global::KBBANGGGBBP<T, U, V, W> GJLGCDFBOPB, Action<T, U, V, W> FOGMDOMFJBB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2497160", Offset = "0x2495960", VA = "0x182497160")]
	public static global::KBBANGGGBBP<T, U, V, W> EPKAGIOEOFM(global::KBBANGGGBBP<T, U, V, W> GJLGCDFBOPB, Action<T, U, V, W> FOGMDOMFJBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface AIIOBBAJEGA<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAILCKFFJIK(Action<T, U, V, W, X> FOGMDOMFJBB, bool AKPODJDOLHD = false);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPPHPNNFPKL(Action<T, U, V, W, X> FOGMDOMFJBB);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class KPGINHGLGBA<T, U, V, W, X> : global::PEMOMEOLKEJ<Action<T, U, V, W, X>>, global::AIIOBBAJEGA<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2499C00", Offset = "0x2498400", VA = "0x182499C00")]
	public KPGINHGLGBA(bool CICPIOFKENJ = false, bool IHLCILHELIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4649300", Offset = "0x4647B00", VA = "0x184649300")]
	public void MKOHINBGHOB(T NFOHJNABMAP, U CFKHIDLOGCG, V KNLEJKEBOMM, W OJBIOMHAGBL, X OLGJDFCIILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4649590", Offset = "0x4647D90", VA = "0x184649590", Slot = "4")]
	public override void NACLKOJNEAO(object[] PFFFGKKOEPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4649BA0", Offset = "0x46483A0", VA = "0x184649BA0")]
	public static global::KPGINHGLGBA<T, U, V, W, X> OGNHPCPAOIL(global::KPGINHGLGBA<T, U, V, W, X> GJLGCDFBOPB, Action<T, U, V, W, X> FOGMDOMFJBB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4648F30", Offset = "0x4647730", VA = "0x184648F30")]
	public static global::KPGINHGLGBA<T, U, V, W, X> EPKAGIOEOFM(global::KPGINHGLGBA<T, U, V, W, X> GJLGCDFBOPB, Action<T, U, V, W, X> FOGMDOMFJBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface PCHKEHAPBBA<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAILCKFFJIK(Action<T, U, V, W, X, Y> FOGMDOMFJBB, bool AKPODJDOLHD = false);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPPHPNNFPKL(Action<T, U, V, W, X, Y> FOGMDOMFJBB);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class CDNDLCKKIIJ<T, U, V, W, X, Y> : global::PEMOMEOLKEJ<Action<T, U, V, W, X, Y>>, global::PCHKEHAPBBA<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2499C00", Offset = "0x2498400", VA = "0x182499C00")]
	public CDNDLCKKIIJ(bool CICPIOFKENJ = false, bool IHLCILHELIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2D4D2A0", Offset = "0x2D4BAA0", VA = "0x182D4D2A0")]
	public void MKOHINBGHOB(T NFOHJNABMAP, U CFKHIDLOGCG, V KNLEJKEBOMM, W OJBIOMHAGBL, X OLGJDFCIILF, Y IKFJLOPMKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2D4D8D0", Offset = "0x2D4C0D0", VA = "0x182D4D8D0", Slot = "4")]
	public override void NACLKOJNEAO(object[] PFFFGKKOEPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2D4DF60", Offset = "0x2D4C760", VA = "0x182D4DF60")]
	public static global::CDNDLCKKIIJ<T, U, V, W, X, Y> OGNHPCPAOIL(global::CDNDLCKKIIJ<T, U, V, W, X, Y> GJLGCDFBOPB, Action<T, U, V, W, X, Y> FOGMDOMFJBB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2D4CC30", Offset = "0x2D4B430", VA = "0x182D4CC30")]
	public static global::CDNDLCKKIIJ<T, U, V, W, X, Y> EPKAGIOEOFM(global::CDNDLCKKIIJ<T, U, V, W, X, Y> GJLGCDFBOPB, Action<T, U, V, W, X, Y> FOGMDOMFJBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct PBHEEDKBLDK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class HNFDGCGAFAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public HNFDGCGAFAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x32ED960", Offset = "0x32EC160", VA = "0x1832ED960")]
		internal void NHFCKJJIIKC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> OLCFPOMJGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private int LEKEBEOLEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private int HANFGKPEECM;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xCFE970", Offset = "0xCFD170", VA = "0x180CFE970")]
	private PBHEEDKBLDK(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> MLICDOOHGLO, int BFEDDGBJLGL, int NLBBJHJNDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x409A900", Offset = "0x4099100", VA = "0x18409A900")]
	public static global::PBHEEDKBLDK<T> DOBPLOGGNLM()
	{
		return default(global::PBHEEDKBLDK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4099340", Offset = "0x4097B40", VA = "0x184099340")]
	public (int, int, Task<T>) DFFBOIKCNMM(int JIKEGDDBPDP, [Optional] CancellationToken GFFFFCALMCA, double JJEEOOEDFIC = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x409A9F0", Offset = "0x40991F0", VA = "0x18409A9F0")]
	public void IMNICMNPGDG(int JIKEGDDBPDP, int NLBBJHJNDIP, in T IIMBBHEIGGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class ENAPBGFAADC
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6F4CB70", Offset = "0x6F4B370", VA = "0x186F4CB70")]
	public static global::PBHEEDKBLDK<DPIJIKFEAOC> DOBPLOGGNLM()
	{
		return default(global::PBHEEDKBLDK<DPIJIKFEAOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6F4CBC0", Offset = "0x6F4B3C0", VA = "0x186F4CBC0")]
	public static void IMNICMNPGDG(this in global::PBHEEDKBLDK<DPIJIKFEAOC> GPOCLJBKMHA, int JIKEGDDBPDP, int NLBBJHJNDIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DefaultMember("Item")]
public class CIHALCFMIHM<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Dictionary<TKey, TVal> KMCJMFMLCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly Dictionary<TVal, TKey> EICIDPKNFLH;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x1CA0870", Offset = "0x1C9F070", VA = "0x181CA0870", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool JKOPFKMGHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x80D0A0", Offset = "0x80B8A0", VA = "0x18080D0A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public ICollection<TKey> NJNAPAHAGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2E05480", Offset = "0x2E03C80", VA = "0x182E05480", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ICollection<TVal> OCFAGHJFNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x371D080", Offset = "0x371B880", VA = "0x18371D080", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public TVal OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF250", Offset = "0x3AEDA50", VA = "0x183AEF250", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF290", Offset = "0x3AEDA90", VA = "0x183AEF290", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TKey OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE320", Offset = "0x3AECB20", VA = "0x183AEE320")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE5E0", Offset = "0x3AECDE0", VA = "0x183AEE5E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE1D0", Offset = "0x3AEC9D0", VA = "0x183AEE1D0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3AEF0F0", Offset = "0x3AED8F0", VA = "0x183AEF0F0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3AEDF80", Offset = "0x3AEC780", VA = "0x183AEDF80", Slot = "9")]
	public void Add(TKey BDFCACLHAFA, TVal ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3AEDF10", Offset = "0x3AEC710", VA = "0x183AEDF10", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> FHJBBMIILLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE230", Offset = "0x3AECA30", VA = "0x183AEE230", Slot = "8")]
	public bool ContainsKey(TKey BDFCACLHAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE260", Offset = "0x3AECA60", VA = "0x183AEE260", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2BD21B0", Offset = "0x2BD09B0", VA = "0x182BD21B0", Slot = "10")]
	public bool Remove(TKey BDFCACLHAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3AEF020", Offset = "0x3AED820", VA = "0x183AEF020", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x29C3D60", Offset = "0x29C2560", VA = "0x1829C3D60", Slot = "11")]
	public bool TryGetValue(TKey BDFCACLHAFA, out TVal ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE520", Offset = "0x3AECD20", VA = "0x183AEE520", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE2C0", Offset = "0x3AECAC0", VA = "0x183AEE2C0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] EABDNHJFDCB, int KHLMLDANMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3AEDFF0", Offset = "0x3AEC7F0", VA = "0x183AEDFF0")]
	public void CAILCKFFJIK(TVal FOHLJCNEPNC, TKey BDFCACLHAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE030", Offset = "0x3AEC830", VA = "0x183AEE030")]
	public void CAILCKFFJIK(KeyValuePair<TVal, TKey> FHJBBMIILLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3AEEB00", Offset = "0x3AED300", VA = "0x183AEEB00")]
	public bool PBFMMEHNOBJ(TVal BDFCACLHAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3AEEA90", Offset = "0x3AED290", VA = "0x183AEEA90")]
	public bool ODOLPHCGINH(KeyValuePair<TVal, TKey> FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE160", Offset = "0x3AEC960", VA = "0x183AEE160")]
	public bool CPPHPNNFPKL(TVal BDFCACLHAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE160", Offset = "0x3AEC960", VA = "0x183AEE160")]
	public bool CPPHPNNFPKL(KeyValuePair<TVal, TKey> FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE810", Offset = "0x3AED010", VA = "0x183AEE810")]
	public bool KFBGNHHGLGM(TVal BDFCACLHAFA, out TKey ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE410", Offset = "0x3AECC10", VA = "0x183AEE410")]
	public IEnumerator<KeyValuePair<TVal, TKey>> FOPHCKACLHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE770", Offset = "0x3AECF70", VA = "0x183AEE770")]
	private void HMAODFLOOLI(TKey BDFCACLHAFA, TVal FOHLJCNEPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE880", Offset = "0x3AED080", VA = "0x183AEE880")]
	private void MCIJLJCKBNK(TKey BDFCACLHAFA, TVal FOHLJCNEPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3AEEB40", Offset = "0x3AED340", VA = "0x183AEEB40")]
	private bool PLKEILCEGJN(TKey BDFCACLHAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3AEED90", Offset = "0x3AED590", VA = "0x183AEED90")]
	private bool PLKEILCEGJN(TVal FOHLJCNEPNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3AEF140", Offset = "0x3AED940", VA = "0x183AEF140")]
	public CIHALCFMIHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DefaultMember("Item")]
public class HEKPBOBAIDI<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly Func<Internal, External> OOFAJPBIDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly Func<External, Internal> HHEDOLCCPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private IList<Internal> IFADMANLNLG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IList<Internal> CNDMAIFAHFN
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF10", Offset = "0x8AB710", VA = "0x1808ACF10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool JKOPFKMGHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA217D0", Offset = "0xA1FFD0", VA = "0x180A217D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9EAA60", Offset = "0x9E9260", VA = "0x1809EAA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public External OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x4927A80", Offset = "0x4926280", VA = "0x184927A80", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4927B20", Offset = "0x4926320", VA = "0x184927B20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x4927A20", Offset = "0x4926220", VA = "0x184927A20", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x40A9C80", Offset = "0x40A8480", VA = "0x1840A9C80")]
	public HEKPBOBAIDI(Func<Internal, External> OOFAJPBIDBP, Func<External, Internal> HHEDOLCCPGA, bool INCMGOFNCLP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4927790", Offset = "0x4925F90", VA = "0x184927790", Slot = "6")]
	public int IndexOf(External FHJBBMIILLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x4927410", Offset = "0x4925C10", VA = "0x184927410", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4927470", Offset = "0x4925C70", VA = "0x184927470", Slot = "13")]
	public bool Contains(External FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4927500", Offset = "0x4925D00", VA = "0x184927500", Slot = "14")]
	public void CopyTo(External[] EABDNHJFDCB, int KHLMLDANMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4927320", Offset = "0x4925B20", VA = "0x184927320", Slot = "11")]
	public void Add(External FHJBBMIILLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4927880", Offset = "0x4926080", VA = "0x184927880", Slot = "7")]
	public void Insert(int NHHNPPKPBIA, External FHJBBMIILLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4927990", Offset = "0x4926190", VA = "0x184927990", Slot = "15")]
	public bool Remove(External FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4927920", Offset = "0x4926120", VA = "0x184927920", Slot = "8")]
	public void RemoveAt(int NHHNPPKPBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4927720", Offset = "0x4925F20", VA = "0x184927720", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2C66EF0", Offset = "0x2C656F0", VA = "0x182C66EF0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public class KEEHLMDHALL<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly Func<Internal, External> OOFAJPBIDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private IReadOnlyList<Internal> IFADMANLNLG;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<Internal> CNDMAIFAHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x811A70", Offset = "0x810270", VA = "0x180811A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool JKOPFKMGHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x811740", Offset = "0x80FF40", VA = "0x180811740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public External OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x249CD50", Offset = "0x249B550", VA = "0x18249CD50", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x249CCF0", Offset = "0x249B4F0", VA = "0x18249CCF0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x1CA08D0", Offset = "0x1C9F0D0", VA = "0x181CA08D0")]
	public KEEHLMDHALL(Func<Internal, External> OOFAJPBIDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x249CCA0", Offset = "0x249B4A0", VA = "0x18249CCA0")]
	public KEEHLMDHALL(IReadOnlyList<Internal> IFADMANLNLG, Func<Internal, External> OOFAJPBIDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x249CA80", Offset = "0x249B280", VA = "0x18249CA80")]
	public void IMKOGLOMGAJ(External[] EABDNHJFDCB, int KHLMLDANMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x249C9B0", Offset = "0x249B1B0", VA = "0x18249C9B0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x1C9FA60", Offset = "0x1C9E260", VA = "0x181C9FA60", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[DefaultMember("Item")]
public class HBPOIIBKJNC<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyList<Internal> IFADMANLNLG;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public IReadOnlyList<Internal> CNDMAIFAHFN
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8CCF80", Offset = "0x8CB780", VA = "0x1808CCF80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool JKOPFKMGHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x811740", Offset = "0x80FF40", VA = "0x180811740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public External OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x4239CA0", Offset = "0x42384A0", VA = "0x184239CA0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x4239C40", Offset = "0x4238440", VA = "0x184239C40", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1CA08D0", Offset = "0x1C9F0D0", VA = "0x181CA08D0")]
	public HBPOIIBKJNC(IReadOnlyList<Internal> IFADMANLNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x4239BA0", Offset = "0x42383A0", VA = "0x184239BA0")]
	public bool ODOLPHCGINH(External FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x4239970", Offset = "0x4238170", VA = "0x184239970")]
	public void IMKOGLOMGAJ(External[] EABDNHJFDCB, int KHLMLDANMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x4239900", Offset = "0x4238100", VA = "0x184239900", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2C66EF0", Offset = "0x2C656F0", VA = "0x182C66EF0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class EKFJNFEBJEA<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TResult> BGAJEDKKFII(TRequest PAJPFFIMEFB, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum MFDJBKDDELK
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class JGDMBLEFKKE
	{
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private const float DDCCCCEHDDE = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TimeSpan NNOONHOMBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int OIFGLAEGACO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public MFDJBKDDELK ACEAOIPODJF;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly JGDMBLEFKKE OAEIAFEPBFB;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float IIECNIAHEPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x32F5CB0", Offset = "0x32F44B0", VA = "0x1832F5CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan BIMGNANIFOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x32F5D90", Offset = "0x32F4590", VA = "0x1832F5D90")]
		public JGDMBLEFKKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private readonly struct ONIOPFMHMPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly TRequest PAJPFFIMEFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public readonly CancellationToken GFFFFCALMCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public readonly TaskCompletionSource<TResult> BFLDPIIJLEC;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3FE9C30", Offset = "0x3FE8430", VA = "0x183FE9C30")]
		public ONIOPFMHMPC(TRequest PAJPFFIMEFB, TaskCompletionSource<TResult> BFLDPIIJLEC, CancellationToken GFFFFCALMCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class DHNGFCJGIIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public DHNGFCJGIIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x1CA0870", Offset = "0x1C9F070", VA = "0x181CA0870")]
		internal void NJPMBAKGOBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class NGJPMDHDFBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public global::EKFJNFEBJEA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public NGJPMDHDFBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x29CB540", Offset = "0x29C9D40", VA = "0x1829CB540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class PIBCCICFIOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public global::EKFJNFEBJEA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private ONIOPFMHMPC <req>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private Task<TResult> <processTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TResult <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TResult <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private OperationCanceledException <oce>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private Exception <ex>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public PIBCCICFIOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3D4F3E0", Offset = "0x3D4DBE0", VA = "0x183D4F3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CancellationTokenSource DEPPNCOAKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly List<ONIOPFMHMPC> ADJLFKKCAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly JGDMBLEFKKE DKMEANFNLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly BGAJEDKKFII BGBEHENHJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Task EIKDEJFCDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int BJJLKHFGGDL;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3869F30", Offset = "0x3868730", VA = "0x183869F30")]
	public EKFJNFEBJEA(BGAJEDKKFII BGBEHENHJEK, [Optional] JGDMBLEFKKE DKMEANFNLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3868230", Offset = "0x3866A30", VA = "0x183868230")]
	public Task<TResult> AIDOFGLCCHD(TRequest PAJPFFIMEFB, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x38698F0", Offset = "0x38680F0", VA = "0x1838698F0")]
	private void KHEGKMJBODH(ONIOPFMHMPC FIPDHKGPCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3869C20", Offset = "0x3868420", VA = "0x183869C20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::EKFJNFEBJEA<, >.NGJPMDHDFBE))]
	private Task LGMAMEGNNDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3869280", Offset = "0x3867A80", VA = "0x183869280")]
	private ONIOPFMHMPC GJLDCBJIJID()
	{
		return default(ONIOPFMHMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3868940", Offset = "0x3867140", VA = "0x183868940")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::EKFJNFEBJEA<, >.PIBCCICFIOC))]
	private Task CANCAKFOEIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3868D30", Offset = "0x3867530", VA = "0x183868D30")]
	private void CMLPNALAHKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3868FD0", Offset = "0x38677D0", VA = "0x183868FD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface DDGAGPGNFPJ
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface AACICHIEKPH<T> : DDGAGPGNFPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	T MHGNIJCIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool PNJODNOGGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string DFFLLHDOFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::AACICHIEKPH<T> OPNLGLFHHJA(Action<T> EJHEMANGOEK);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::AACICHIEKPH<T> CEDGGHAFJKO(Action<T> EJHEMANGOEK);

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::AACICHIEKPH<T> LIFJBAKHMEG(Action<T, T> FOOMJEJICME);

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::AACICHIEKPH<T> ENLLKKOMPDO(Action<T, T> FOOMJEJICME);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::AACICHIEKPH<T> GFAGJPBHKLG(Action<string> LKICEHJCLKB);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::AACICHIEKPH<T> APPBPNLCCGB(Action<string> LKICEHJCLKB);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class DHALFLDNIDD<T> : global::AACICHIEKPH<T>, DDGAGPGNFPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private global::HJMCHKIHGED<T, T> MNLOIFBIJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private global::NAOGJOJMPFD<T> BONMDADOCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private global::NAOGJOJMPFD<string> BEKJAKGICEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private string FKPBDLDGFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private T IIMBBHEIGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool PHLPDICNKFG;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T MHGNIJCIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xAF2360", Offset = "0xAF0B60", VA = "0x180AF2360", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x249D730", Offset = "0x249BF30", VA = "0x18249D730", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool PNJODNOGGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x9FBE30", Offset = "0x9FA630", VA = "0x1809FBE30", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string DFFLLHDOFCE
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xAF2370", Offset = "0xAF0B70", VA = "0x180AF2370", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2744090", Offset = "0x2742890", VA = "0x182744090", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C990", Offset = "0x2F7B190", VA = "0x182F7C990")]
	private void MNBHKBFFHBK(T MEKBNGFFPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C890", Offset = "0x2F7B090", VA = "0x182F7C890")]
	private void LCADPBBFAGG(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2F7CA30", Offset = "0x2F7B230", VA = "0x182F7CA30")]
	public void NHGHFKAFNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C940", Offset = "0x2F7B140", VA = "0x182F7C940", Slot = "6")]
	public global::AACICHIEKPH<T> LIFJBAKHMEG(Action<T, T> FOOMJEJICME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C7A0", Offset = "0x2F7AFA0", VA = "0x182F7C7A0", Slot = "7")]
	public global::AACICHIEKPH<T> ENLLKKOMPDO(Action<T, T> FOOMJEJICME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2F7CAE0", Offset = "0x2F7B2E0", VA = "0x182F7CAE0", Slot = "4")]
	public global::AACICHIEKPH<T> OPNLGLFHHJA(Action<T> FOOMJEJICME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C750", Offset = "0x2F7AF50", VA = "0x182F7C750", Slot = "5")]
	public global::AACICHIEKPH<T> CEDGGHAFJKO(Action<T> EJHEMANGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C7F0", Offset = "0x2F7AFF0", VA = "0x182F7C7F0", Slot = "8")]
	public global::AACICHIEKPH<T> GFAGJPBHKLG(Action<string> LKICEHJCLKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C6E0", Offset = "0x2F7AEE0", VA = "0x182F7C6E0", Slot = "9")]
	public global::AACICHIEKPH<T> APPBPNLCCGB(Action<string> LKICEHJCLKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2F7CB70", Offset = "0x2F7B370", VA = "0x182F7CB70")]
	public DHALFLDNIDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class FJJKDFGAIAO
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class APGBOGNLDIM<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public global::AACICHIEKPH<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public global::GBNOCCBNCBC<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public APGBOGNLDIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3B14050", Offset = "0x3B12850", VA = "0x183B14050")]
		internal void GLMMHMOIHJG(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x240DE30", Offset = "0x240C630", VA = "0x18240DE30")]
	public static global::NBFPPJGKGOH<T> GCHGIFGBMBE<T>(this global::AACICHIEKPH<T> GFFJLKBKGKP, Action<T> IACLOIAOHJF)
	{
		return null;
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x3C60AF0", Offset = "0x3C5F2F0", VA = "0x183C60AF0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA230", Offset = "0x6EE8A30", VA = "0x186EEA230")]
		public SerializedGuid(in Guid PCFHAIHNKAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F518D0", Offset = "0x6F500D0", VA = "0x186F518D0")]
		public static SerializedGuid OFDHHOGOACB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F51840", Offset = "0x6F50040", VA = "0x186F51840")]
		public static SerializedGuid JFNFONDAPFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F51960", Offset = "0x6F50160", VA = "0x186F51960")]
		public bool OKHCPHKNICN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA200", Offset = "0x6EE8A00", VA = "0x186EEA200", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F519F0", Offset = "0x6F501F0", VA = "0x186F519F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F517B0", Offset = "0x6F4FFB0", VA = "0x186F517B0")]
		public bool FMOLALLCICL(in Guid PCFHAIHNKAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F51620", Offset = "0x6F4FE20", VA = "0x186F51620", Slot = "7")]
		public bool Equals(SerializedGuid MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F516D0", Offset = "0x6F4FED0", VA = "0x186F516D0", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA150", Offset = "0x6EE8950", VA = "0x186EEA150", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9F90", Offset = "0x6EE8790", VA = "0x186EE9F90", Slot = "6")]
		public int CompareTo(SerializedGuid MDHJAFNLPON)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class NNJFCKNKHBA : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly Type MGEPNNKCKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly string LAKGEPFEJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool JHDJEAPEEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly bool AMELPFAIPOL;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F500F0", Offset = "0x6F4E8F0", VA = "0x186F500F0")]
	public NNJFCKNKHBA(Type HGBBHGHBLFE, string GHDKOMENMKC, bool FOBNDAAIBNH = false, bool NNHFFLPCIGL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[DefaultMember("Item")]
public class JBEMIBHHCAC<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly List<T> IFADMANLNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private HashSet<T> JAEDJOIGJCA;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1CA0870", Offset = "0x1C9F070", VA = "0x181CA0870", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JKOPFKMGHEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7F35F0", Offset = "0x7F1DF0", VA = "0x1807F35F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public T OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2D5D890", Offset = "0x2D5C090", VA = "0x182D5D890", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3CBFDE0", Offset = "0x3CBE5E0", VA = "0x183CBFDE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x30DE0E0", Offset = "0x30DC8E0", VA = "0x1830DE0E0", Slot = "11")]
	public void Add(T FHJBBMIILLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF900", Offset = "0x3CBE100", VA = "0x183CBF900")]
	public bool JCOHIHLGEAI(T FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3CBFBF0", Offset = "0x3CBE3F0", VA = "0x183CBFBF0", Slot = "15")]
	public bool Remove(T FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x29C3CE0", Offset = "0x29C24E0", VA = "0x1829C3CE0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x185F4C0", Offset = "0x185DCC0", VA = "0x18185F4C0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF540", Offset = "0x3CBDD40", VA = "0x183CBF540", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x24A27E0", Offset = "0x24A0FE0", VA = "0x1824A27E0", Slot = "13")]
	public bool Contains(T FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF5A0", Offset = "0x3CBDDA0", VA = "0x183CBF5A0", Slot = "14")]
	public void CopyTo(T[] EABDNHJFDCB, int KHLMLDANMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3AEF220", Offset = "0x3AEDA20", VA = "0x183AEF220", Slot = "6")]
	public int IndexOf(T FHJBBMIILLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF840", Offset = "0x3CBE040", VA = "0x183CBF840", Slot = "7")]
	public void Insert(int NHHNPPKPBIA, T FHJBBMIILLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3CBFA50", Offset = "0x3CBE250", VA = "0x183CBFA50", Slot = "8")]
	public void RemoveAt(int NHHNPPKPBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF5D0", Offset = "0x3CBDDD0", VA = "0x183CBF5D0")]
	public void IHBIIKDAKOI(Predicate<T> LDNIBEBMKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x29CD080", Offset = "0x29CB880", VA = "0x1829CD080")]
	public void HOIHKHFBLLG(Comparison<T> OBDHEPNLMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3CBFD00", Offset = "0x3CBE500", VA = "0x183CBFD00")]
	public JBEMIBHHCAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class NGNEDPOIMFM
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F2C0", Offset = "0x6F4DAC0", VA = "0x186F4F2C0")]
	public static Vector3 DBEDDMGMBIL(this GameObject ALBKEDBKENG, float NKMLOAFCLKE)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class PFLOOOBDIHA : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly Type MGEPNNKCKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly string LAKGEPFEJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool JHDJEAPEEEL;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6F50160", Offset = "0x6F4E960", VA = "0x186F50160")]
	public PFLOOOBDIHA(Type HGBBHGHBLFE, string GHDKOMENMKC, bool FOBNDAAIBNH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class KNLEPHMPGDG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DD70", Offset = "0x6F4C570", VA = "0x186F4DD70")]
	public KNLEPHMPGDG(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DCF0", Offset = "0x6F4C4F0", VA = "0x186F4DCF0")]
	public KNLEPHMPGDG(string DKIECHCHJFL, Exception NCFNHKNLKKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class CLDJFIHFHLI
{
	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C820", Offset = "0x6F4B020", VA = "0x186F4C820")]
	[NotNull]
	public static byte[] EKPELJIKGFA(this INPIODOCMAF EKNEHDJHLJF, byte[] IDKBGDBOHNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C5E0", Offset = "0x6F4ADE0", VA = "0x186F4C5E0")]
	[NotNull]
	public static byte[] EKPELJIKGFA(this INPIODOCMAF EKNEHDJHLJF, HashAlgorithmName INMIEOBOCOF, byte[] IDKBGDBOHNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface INPIODOCMAF
{
	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash DKKDLHLFHOF);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface IEEAIAKPCEK : INPIODOCMAF
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[CanBeNull]
	byte[] LKOCLPINJLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	[CanBeNull]
	byte[] KKGKKCLGPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	UnityEngine.Object BGNPIGCBKPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class BJAEKPDMJHC
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class DNMAGGAJLEO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F4CA20", Offset = "0x6F4B220", VA = "0x186F4CA20")]
		public DNMAGGAJLEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F4C9C0", Offset = "0x6F4B1C0", VA = "0x186F4C9C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private const byte NABDKGFPOGC = 1;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const byte BCPOFEJIFNL = 0;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly ArrayPool<byte> OEGBGGGCCAF;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static bool LOLMGOLOCEO;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x347C160", Offset = "0x347A960", VA = "0x18347C160")]
	[Conditional("UNITY_EDITOR")]
	private static void MBMMEKELBLE<T>(params T[] ENBMDODBPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C390", Offset = "0x6F4AB90", VA = "0x186F4C390")]
	public static IDisposable PBCBAJOHDLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F4BA80", Offset = "0x6F4A280", VA = "0x186F4BA80")]
	public static void GBHCEDAGLCB(this IncrementalHash ALNNPHJMFIL, [CanBeNull] GameObject ALBKEDBKENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x347C090", Offset = "0x347A890", VA = "0x18347C090")]
	public static void GBHCEDAGLCB<T>(this IncrementalHash ALNNPHJMFIL, [CanBeNull] T DPLEBJGMEDE) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x347C000", Offset = "0x347A800", VA = "0x18347C000")]
	public static void FMMGOBKJECI<T>(this IncrementalHash ALNNPHJMFIL, [CanBeNull] T EKNEHDJHLJF) where T : INPIODOCMAF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x347C450", Offset = "0x347AC50", VA = "0x18347C450")]
	public static void NDNBOLDFGLE<T>(this IncrementalHash ALNNPHJMFIL, [CanBeNull] IList<T> CFBEPOFGJFK) where T : INPIODOCMAF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F4BB70", Offset = "0x6F4A370", VA = "0x186F4BB70")]
	private static bool GCKEMAFCIAH([CanBeNull] INPIODOCMAF EKNEHDJHLJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C430", Offset = "0x6F4AC30", VA = "0x186F4C430")]
	public static void PMGHKCKLIBJ(this IncrementalHash DKKDLHLFHOF, [CanBeNull] string IHEIAPOCOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C050", Offset = "0x6F4A850", VA = "0x186F4C050")]
	public static void NMKMPNACABA(this IncrementalHash DKKDLHLFHOF, long AAACKIAOAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F4BC60", Offset = "0x6F4A460", VA = "0x186F4BC60")]
	public static void IFMPIFADCCK(this IncrementalHash DKKDLHLFHOF, int CPOCCBGJOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B430", Offset = "0x6F49C30", VA = "0x186F4B430")]
	public static void AFNDAMCPINI(this IncrementalHash DKKDLHLFHOF, short DLAMMDHENLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C220", Offset = "0x6F4AA20", VA = "0x186F4C220")]
	public static void OCIDBOPAICL(this IncrementalHash DKKDLHLFHOF, byte AOJNFIFCAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B600", Offset = "0x6F49E00", VA = "0x186F4B600")]
	public static void BAIKMMKLGPJ(this IncrementalHash DKKDLHLFHOF, bool COGGBAODFBM, bool BDOIJAHLIIP = false, bool GHIKJHJAJPB = false, bool JDPFAHHEEFL = false, bool FMMJIPDCINK = false, bool IBKPNFDDOFP = false, bool MHOKCHELOKC = false, bool FLBPMBPBADC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x347C8B0", Offset = "0x347B0B0", VA = "0x18347C8B0")]
	public static void ODHKCPGHCOH<T>(this IncrementalHash DKKDLHLFHOF, T AMNNIMCNJDH) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B840", Offset = "0x6F4A040", VA = "0x186F4B840")]
	public static void DFHBBDKPEKE(this IncrementalHash DKKDLHLFHOF, float GHHIHMFDJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F4BC00", Offset = "0x6F4A400", VA = "0x186F4BC00")]
	public static void HBJHNEMPALP(this IncrementalHash DKKDLHLFHOF, double JEHKHBEKMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F4BA10", Offset = "0x6F4A210", VA = "0x186F4BA10")]
	public static void FNOAJHGKFOB(this IncrementalHash DKKDLHLFHOF, ulong ADHLDIBIHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F4BFF0", Offset = "0x6F4A7F0", VA = "0x186F4BFF0")]
	public static void JJCIOFHLIBI(this IncrementalHash DKKDLHLFHOF, uint LFNGHAPJAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B7D0", Offset = "0x6F49FD0", VA = "0x186F4B7D0")]
	public static void BMJLAHDIFEC(this IncrementalHash DKKDLHLFHOF, ushort BLNNHACDOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B8A0", Offset = "0x6F4A0A0", VA = "0x186F4B8A0")]
	public static void EABJBLKANBE(this IncrementalHash DKKDLHLFHOF, Vector3 IKBGLOMGGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F4BE30", Offset = "0x6F4A630", VA = "0x186F4BE30")]
	public static void JELCMHAHCCG(this IncrementalHash DKKDLHLFHOF, Quaternion IKJHPFLGHKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class HIGINMENPKE
{
	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D010", Offset = "0x6F4B810", VA = "0x186F4D010")]
	[NotNull]
	public static byte[] EKPELJIKGFA(this IEEAIAKPCEK OHIFKEKKGBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D080", Offset = "0x6F4B880", VA = "0x186F4D080")]
	[NotNull]
	public static byte[] EKPELJIKGFA(this IEEAIAKPCEK OHIFKEKKGBE, HashAlgorithmName INMIEOBOCOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D280", Offset = "0x6F4BA80", VA = "0x186F4D280")]
	public static bool JLECPPEIGPM([CanBeNull] this IEEAIAKPCEK OHIFKEKKGBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D410", Offset = "0x6F4BC10", VA = "0x186F4D410")]
	public static bool JLECPPEIGPM([CanBeNull] this IEEAIAKPCEK OHIFKEKKGBE, out string FKPBDLDGFCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D0F0", Offset = "0x6F4B8F0", VA = "0x186F4D0F0")]
	private static string GNELJCECGNF([CanBeNull] byte[] ENEAOCDMOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D160", Offset = "0x6F4B960", VA = "0x186F4D160")]
	private static bool JHHKFIOLDMP([NotNull] IEEAIAKPCEK OHIFKEKKGBE, [CanBeNull] out byte[] DBOIMFAIFIH, [CanBeNull] out byte[] ELGLFFLEHII)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class OPMDLAPLJBA<TTask, T> : global::BMMLLBKLJDM<T>, FNEGELMJDBM, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class CCIHNODDNIK
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		private sealed class <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public CCIHNODDNIK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
			public <<-ctor>g__AwaitThenTransformTaskResult|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x28784F0", Offset = "0x2876CF0", VA = "0x1828784F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public global::OPMDLAPLJBA<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public CCIHNODDNIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2D4BF10", Offset = "0x2D4A710", VA = "0x182D4BF10")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(global::OPMDLAPLJBA<, >.CCIHNODDNIK.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> GFHPBEBEGFA(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static bool JKPPEODFBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly Task<T> GAKDIIFBLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	protected readonly CancellationTokenSource MFGBDLCLLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool GHKACLCDPMJ;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Task<T> DAKHKMPDFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Task NMOONEGGGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public global::NBFPPJGKGOH<T> NFMMEGLCENH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private EILHPPDHBHH LOKNNCIAKDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC180", Offset = "0x2BDA980", VA = "0x182BDC180", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool JHFNJCFMCPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA217D0", Offset = "0xA1FFD0", VA = "0x180A217D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x3FF0BD0", Offset = "0x3FEF3D0", VA = "0x183FF0BD0")]
	static OPMDLAPLJBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x3FF0D80", Offset = "0x3FEF580", VA = "0x183FF0D80")]
	protected OPMDLAPLJBA(TTask GAKDIIFBLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x3FF0610", Offset = "0x3FEEE10", VA = "0x183FF0610", Slot = "1")]
	~OPMDLAPLJBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x3FF05E0", Offset = "0x3FEEDE0", VA = "0x183FF05E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x3FF0680", Offset = "0x3FEEE80", VA = "0x183FF0680")]
	private void LIEFKNGBAEG(bool MDEOJBFAIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T JLNNKDEAEDL(TTask CNOKCNJONIB);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void JAMCMKIDADE();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class CNIIHJDMKOI : global::PLHBFOCCPAO<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C860", Offset = "0x6F4B060", VA = "0x186F4C860")]
	public CNIIHJDMKOI(Exception KIEMAGPGLGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class PLHBFOCCPAO<T> : global::BMMLLBKLJDM<T>, FNEGELMJDBM, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public Task<T> DAKHKMPDFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private Task NMOONEGGGJP
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1B7C270", Offset = "0x1B7AA70", VA = "0x181B7C270", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public global::NBFPPJGKGOH<T> NFMMEGLCENH
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private EILHPPDHBHH LOKNNCIAKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1CA08A0", Offset = "0x1C9F0A0", VA = "0x181CA08A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x3D603E0", Offset = "0x3D5EBE0", VA = "0x183D603E0")]
	public PLHBFOCCPAO(Exception KIEMAGPGLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface FNEGELMJDBM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	[NotNull]
	Task DAKHKMPDFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	[NotNull]
	EILHPPDHBHH NFMMEGLCENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface BMMLLBKLJDM<T> : FNEGELMJDBM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	[NotNull]
	new Task<T> DAKHKMPDFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	new global::NBFPPJGKGOH<T> NFMMEGLCENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class BPEANJCACFL : global::PBFOOBDDNHD<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C5A0", Offset = "0x6F4ADA0", VA = "0x186F4C5A0")]
	public BPEANJCACFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class PBFOOBDDNHD<T> : global::BMMLLBKLJDM<T>, FNEGELMJDBM, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Task<T> DAKHKMPDFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private Task NMOONEGGGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1B7C270", Offset = "0x1B7AA70", VA = "0x181B7C270", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public global::NBFPPJGKGOH<T> NFMMEGLCENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private EILHPPDHBHH LOKNNCIAKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1CA08A0", Offset = "0x1C9F0A0", VA = "0x181CA08A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4091CB0", Offset = "0x40904B0", VA = "0x184091CB0")]
	public PBFOOBDDNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public sealed class BDPOMAKGMDN : global::JAPPGKMKBNF<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class IKCGLDBLFAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public Action<BDPOMAKGMDN> callback;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public IKCGLDBLFAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D6A0", Offset = "0x6F4BEA0", VA = "0x186F4D6A0")]
		internal void PKFOHKCNHGL(global::JAPPGKMKBNF<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B2E0", Offset = "0x6F49AE0", VA = "0x186F4B2E0")]
	public BDPOMAKGMDN([Optional] string EKLNNMKJFJE, [Optional] int? FENNDHCJJPL, [Optional] Stopwatch NGBOPHHNHAL, [Optional] Action<string, AHBCFPPHHDO> MGOLJMIHAJI, [Optional] Action<string, AHBCFPPHHDO> ENMNJFPNDPE, [Optional] Action<BDPOMAKGMDN> PHAGACJHDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B200", Offset = "0x6F49A00", VA = "0x186F4B200")]
	private static Action<global::JAPPGKMKBNF<string>> KMBKEDOPFCG(Action<BDPOMAKGMDN> IACLOIAOHJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class PGFIODPNGPE<TKey> : global::DPNILAIBCPB<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class EMFBBFEBCMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public HPMMNIDOMCP keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public EMFBBFEBCMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2315360", Offset = "0x2313B60", VA = "0x182315360")]
		internal string EDJOIBDDLEL(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x40AD0B0", Offset = "0x40AB8B0", VA = "0x1840AD0B0", Slot = "5")]
	protected override string KLFBMEGCMOO(global::JAPPGKMKBNF<TKey> IDIJCJCNEPO, HPMMNIDOMCP LGDBOJKCHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x29C3F00", Offset = "0x29C2700", VA = "0x1829C3F00")]
	public PGFIODPNGPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class NDNNEJNANJD<TKey> : global::MFDHBKFONEG<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate string NIHJPELOJBN(TKey BDFCACLHAFA);

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private const int OBBFNPFJIFM = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly string AGOMEPFMNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly double ACMHMPFHEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly bool MFMOBLBGILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly int OELNLLDOMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly ISet<string> IEKBODLLLOH;

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x29C41E0", Offset = "0x29C29E0", VA = "0x1829C41E0")]
	private static string DHNMLCJPLHP(TKey BDFCACLHAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x29C4C20", Offset = "0x29C3420", VA = "0x1829C4C20")]
	public NDNNEJNANJD(string AGOMEPFMNMI = "F2", double ACMHMPFHEGL = double.MaxValue, bool MFMOBLBGILH = false, int OELNLLDOMIP = int.MaxValue, [Optional] ISet<string> IEKBODLLLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x29C49C0", Offset = "0x29C31C0", VA = "0x1829C49C0", Slot = "4")]
	public override Dictionary<string, string> GBBAFINFGIO(global::JAPPGKMKBNF<TKey> IDIJCJCNEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x29C4220", Offset = "0x29C2A20", VA = "0x1829C4220")]
	private bool DIOMMJEIOBB(string LPCDIMOBLNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x29C4480", Offset = "0x29C2C80", VA = "0x1829C4480")]
	public Dictionary<string, string> GBBAFINFGIO(global::JAPPGKMKBNF<TKey> IDIJCJCNEPO, NIHJPELOJBN LGDBOJKCHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x29C4A70", Offset = "0x29C3270", VA = "0x1829C4A70")]
	private string ONJCLHAIGLE(StringBuilder IOBIMBJLCJB, List<TKey> PGEPAHPIDFO, NIHJPELOJBN LGDBOJKCHND, bool DKEIJDLIPDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x29C4300", Offset = "0x29C2B00", VA = "0x1829C4300")]
	private static void FAOBNEGEOBP(StringBuilder DOAKNDKFOJJ, string MIOGHELNGNI, bool OHIBDAHDNAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public abstract class MFDHBKFONEG<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut GBBAFINFGIO(global::JAPPGKMKBNF<TKey> IDIJCJCNEPO);

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
	protected MFDHBKFONEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public abstract class DPNILAIBCPB<TKey> : global::MFDHBKFONEG<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public delegate string HPMMNIDOMCP(TKey BDFCACLHAFA);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2F8ADD0", Offset = "0x2F895D0", VA = "0x182F8ADD0")]
	protected string JFHAPFGKJPB(double MBPEFNOIKNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x2F8AB90", Offset = "0x2F89390", VA = "0x182F8AB90")]
	protected string EPAIEBGHBDC(int NBGDFKLHLOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2F8AB50", Offset = "0x2F89350", VA = "0x182F8AB50")]
	private static string DHNMLCJPLHP(TKey BDFCACLHAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2F8AD20", Offset = "0x2F89520", VA = "0x182F8AD20", Slot = "4")]
	public override string GBBAFINFGIO(global::JAPPGKMKBNF<TKey> IDIJCJCNEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2F8ABF0", Offset = "0x2F893F0", VA = "0x182F8ABF0")]
	public string GBBAFINFGIO(global::JAPPGKMKBNF<TKey> IDIJCJCNEPO, [NotNull] HPMMNIDOMCP LGDBOJKCHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string KLFBMEGCMOO(global::JAPPGKMKBNF<TKey> IDIJCJCNEPO, [NotNull] HPMMNIDOMCP LGDBOJKCHND);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2C66EF0", Offset = "0x2C656F0", VA = "0x182C66EF0")]
	protected DPNILAIBCPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public abstract class NAJOFKHOGHM
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private class FFPGKPCBMGB : NAJOFKHOGHM
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public static NAJOFKHOGHM EABDDJEADPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x6F4CC40", Offset = "0x6F4B440", VA = "0x186F4CC40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override DateTime NOOMFHNGOEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x6F4CCA0", Offset = "0x6F4B4A0", VA = "0x186F4CCA0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public override float LGNCOMMFFDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x1694820", Offset = "0x1693020", VA = "0x181694820", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6F4CD90", Offset = "0x6F4B590", VA = "0x186F4CD90")]
		public FFPGKPCBMGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static NAJOFKHOGHM FKACPJJDDIO;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static NAJOFKHOGHM OAEIAFEPBFB
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F130", Offset = "0x6F4D930", VA = "0x186F4F130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public abstract DateTime NOOMFHNGOEF
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public abstract float LGNCOMMFFDP
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	protected NAJOFKHOGHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class HKFCPNLCEIC<TKey> : global::DPNILAIBCPB<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct OJBMHDCLFCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public HPMMNIDOMCP keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static global::HKFCPNLCEIC<TKey> EABDDJEADPB;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private const int GMKCGFCDFEE = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly string[] MJHFLMBNMMO;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x35824E0", Offset = "0x3580CE0", VA = "0x1835824E0")]
	private HKFCPNLCEIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x3581500", Offset = "0x357FD00", VA = "0x183581500", Slot = "5")]
	protected override string KLFBMEGCMOO(global::JAPPGKMKBNF<TKey> IDIJCJCNEPO, HPMMNIDOMCP LGDBOJKCHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x3581410", Offset = "0x357FC10", VA = "0x183581410")]
	[CompilerGenerated]
	internal static string JCIMNOPKPPN(string LIJPLFFEDOP, TKey BDFCACLHAFA, ref OJBMHDCLFCH P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class JAPPGKMKBNF<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public readonly struct AHBCFPPHHDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public readonly long BAHOEHOOJGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public readonly long NHIEONFMGLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public readonly int FENNDHCJJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public readonly int APIDBNJMOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public readonly bool HONBDECDNIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly string HOEMMCAKAAG;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x4629D10", Offset = "0x4628510", VA = "0x184629D10")]
		public AHBCFPPHHDO(long BAHOEHOOJGF, int FENNDHCJJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x4629CE0", Offset = "0x46284E0", VA = "0x184629CE0")]
		public AHBCFPPHHDO(long BAHOEHOOJGF, long NHIEONFMGLD, int FENNDHCJJPL, int APIDBNJMOJD, bool HONBDECDNIP, string HOEMMCAKAAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x4629C40", Offset = "0x4628440", VA = "0x184629C40")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void ONMAAIJMEKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x4629BF0", Offset = "0x46283F0", VA = "0x184629BF0")]
		public int NFHAOHLLALE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x4629CC0", Offset = "0x46284C0", VA = "0x184629CC0")]
		public int PMCLDDHPBCH(int OBNGPCHGBMF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x4629B80", Offset = "0x4628380", VA = "0x184629B80")]
		public double MLCGGBPAPHJ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x4629AC0", Offset = "0x46282C0", VA = "0x184629AC0")]
		public AHBCFPPHHDO EABKMEAPNDD(long NHIEONFMGLD, int APIDBNJMOJD)
		{
			return default(AHBCFPPHHDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class AALOEEPNEOP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public readonly TKey JKHFJODHGEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly global::JAPPGKMKBNF<TKey> IDIJCJCNEPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private List<AALOEEPNEOP> PPGKEPMFCLE;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string AMMJLBNDGMI
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x1CA0650", Offset = "0x1C9EE50", VA = "0x181CA0650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x1CA0260", Offset = "0x1C9EA60", VA = "0x181CA0260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public IEnumerable<AALOEEPNEOP> GLGFKAIAEPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x5168840", Offset = "0x5167040", VA = "0x185168840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public AHBCFPPHHDO ICCFEAONLLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x2006E00", Offset = "0x2005600", VA = "0x182006E00")]
			[CompilerGenerated]
			get
			{
				return default(AHBCFPPHHDO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x5168730", Offset = "0x5166F30", VA = "0x185168730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x5168860", Offset = "0x5167060", VA = "0x185168860")]
		internal AALOEEPNEOP(global::JAPPGKMKBNF<TKey> IDIJCJCNEPO, TKey BDFCACLHAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5168470", Offset = "0x5166C70", VA = "0x185168470")]
		public AALOEEPNEOP AMICMCIKJKC(TKey BDFCACLHAFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5168760", Offset = "0x5166F60", VA = "0x185168760")]
		public void KMBKEDOPFCG(TKey BDFCACLHAFA, Action<AALOEEPNEOP> FOGMDOMFJBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x3295F70", Offset = "0x3294770", VA = "0x183295F70")]
		public T KMBKEDOPFCG<T>(TKey BDFCACLHAFA, Func<AALOEEPNEOP, T> ELKBEDCOHFJ)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x3295DF0", Offset = "0x32945F0", VA = "0x183295DF0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(LOADMBEPIJP))]
		public Task<T> JHEGKLHHLAN<T>(TKey BDFCACLHAFA, Func<AALOEEPNEOP, Task<T>> ELKBEDCOHFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x5168580", Offset = "0x5166D80", VA = "0x185168580", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class AKCOJPIOKAN : IEnumerable<(TKey, List<TKey>, AHBCFPPHHDO)>, IEnumerable, IEnumerator<(TKey, List<TKey>, AHBCFPPHHDO)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private (TKey key, List<TKey> path, AHBCFPPHHDO timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public global::JAPPGKMKBNF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private List<TKey> <path>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private IEnumerator<(TKey key, List<TKey> path, AHBCFPPHHDO timerEntry)> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private (TKey key, List<TKey> path, AHBCFPPHHDO timerEntry) <rootTuple>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		private (TKey, List<TKey>, AHBCFPPHHDO) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x2BE3690", Offset = "0x2BE1E90", VA = "0x182BE3690", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, AHBCFPPHHDO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x4638D20", Offset = "0x4637520", VA = "0x184638D20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3820", Offset = "0x2BE2020", VA = "0x182BE3820")]
		[DebuggerHidden]
		public AKCOJPIOKAN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2EED510", Offset = "0x2EEBD10", VA = "0x182EED510", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x46388F0", Offset = "0x46370F0", VA = "0x1846388F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x46388A0", Offset = "0x46370A0", VA = "0x1846388A0")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x4638CE0", Offset = "0x46374E0", VA = "0x184638CE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x4638C20", Offset = "0x4637420", VA = "0x184638C20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, AHBCFPPHHDO)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x2316EB0", Offset = "0x23156B0", VA = "0x182316EB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class GMDOKKMNAIF : IEnumerable<(TKey, List<TKey>, AHBCFPPHHDO)>, IEnumerable, IEnumerator<(TKey, List<TKey>, AHBCFPPHHDO)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private (TKey key, List<TKey> path, AHBCFPPHHDO timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private AALOEEPNEOP timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public AALOEEPNEOP <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public global::JAPPGKMKBNF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private IEnumerator<AALOEEPNEOP> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private AALOEEPNEOP <timerScopeChild>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private IEnumerator<(TKey key, List<TKey> path, AHBCFPPHHDO timerEntry)> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private (TKey key, List<TKey> path, AHBCFPPHHDO timerEntry) <childTuple>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		private (TKey, List<TKey>, AHBCFPPHHDO) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x2BE3690", Offset = "0x2BE1E90", VA = "0x182BE3690", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, AHBCFPPHHDO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x2BE3730", Offset = "0x2BE1F30", VA = "0x182BE3730", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3820", Offset = "0x2BE2020", VA = "0x182BE3820")]
		[DebuggerHidden]
		public GMDOKKMNAIF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3790", Offset = "0x2BE1F90", VA = "0x182BE3790", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2F30", Offset = "0x2BE1730", VA = "0x182BE2F30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2ED0", Offset = "0x2BE16D0", VA = "0x182BE2ED0")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3550", Offset = "0x2BE1D50", VA = "0x182BE3550")]
		private void NDPBPNJDDHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2BE36F0", Offset = "0x2BE1EF0", VA = "0x182BE36F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2BE35B0", Offset = "0x2BE1DB0", VA = "0x182BE35B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, AHBCFPPHHDO)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2BE36C0", Offset = "0x2BE1EC0", VA = "0x182BE36C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Action<TKey, AHBCFPPHHDO> MGOLJMIHAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly Action<TKey, AHBCFPPHHDO> ENMNJFPNDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Action<global::JAPPGKMKBNF<TKey>> PHAGACJHDKJ;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private const string JMMJAHODMHK = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly AALOEEPNEOP DCGEHADKAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool GHKACLCDPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int JPNGHIHINAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly Stopwatch NGBOPHHNHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly int BBMFKGICJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private string CABNFDFLEJF;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public AALOEEPNEOP AABDNGDDMML
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CE0", Offset = "0x7F14E0", VA = "0x1807F2CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	[NotNull]
	public string AMMJLBNDGMI
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x80DE70", Offset = "0x80C670", VA = "0x18080DE70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x3CBF170", Offset = "0x3CBD970", VA = "0x183CBF170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public long JLABMGHGBPA
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x3CBF1F0", Offset = "0x3CBD9F0", VA = "0x183CBF1F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int PAMGGJEPCOH
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x3CBF210", Offset = "0x3CBDA10", VA = "0x183CBF210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF3C0", Offset = "0x3CBDBC0", VA = "0x183CBF3C0")]
	public JAPPGKMKBNF(TKey DOFEACJBFLN, [Optional] int? FENNDHCJJPL, [Optional][CanBeNull] Stopwatch NGBOPHHNHAL, [Optional] Action<TKey, AHBCFPPHHDO> MGOLJMIHAJI, [Optional] Action<TKey, AHBCFPPHHDO> ENMNJFPNDPE, [Optional] Action<global::JAPPGKMKBNF<TKey>> PHAGACJHDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF0E0", Offset = "0x3CBD8E0", VA = "0x183CBF0E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF3A0", Offset = "0x3CBDBA0", VA = "0x183CBF3A0")]
	public void NEDAAMABCNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF1D0", Offset = "0x3CBD9D0", VA = "0x183CBF1D0")]
	public void IKGIICDJABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF310", Offset = "0x3CBDB10", VA = "0x183CBF310")]
	[IteratorStateMachine(typeof(global::JAPPGKMKBNF<>.AKCOJPIOKAN))]
	public IEnumerable<(TKey, List<TKey>, AHBCFPPHHDO)> NCKIECPAKPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF240", Offset = "0x3CBDA40", VA = "0x183CBF240")]
	[IteratorStateMachine(typeof(global::JAPPGKMKBNF<>.GMDOKKMNAIF))]
	private IEnumerable<(TKey, List<TKey>, AHBCFPPHHDO)> NCKIECPAKPF(List<TKey> FMALCPACLGP, AALOEEPNEOP MPOFGPPJKDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF060", Offset = "0x3CBD860", VA = "0x183CBF060")]
	private (long, int) DMNOPEMNDFO()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class NNDAHABCPBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly Dictionary<byte, MJLLOGCLAHK> KLFGJONGGEG;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public MJLLOGCLAHK HJEBMDOFADN
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8CCF80", Offset = "0x8CB780", VA = "0x1808CCF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector2 FIMHFHEPMJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x126DB20", Offset = "0x126C320", VA = "0x18126DB20")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x847280", Offset = "0x845A80", VA = "0x180847280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector2 LMHJNKIBKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1CA7490", Offset = "0x1CA5C90", VA = "0x181CA7490")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xB59E60", Offset = "0xB58660", VA = "0x180B59E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector2 EPFGMMNIBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F590", Offset = "0x6F4DD90", VA = "0x186F4F590")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x131D070", Offset = "0x131B870", VA = "0x18131D070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int APEIDHOMMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8ABEE0", Offset = "0x8AA6E0", VA = "0x1808ABEE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x92D760", Offset = "0x92BF60", VA = "0x18092D760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6F4FC90", Offset = "0x6F4E490", VA = "0x186F4FC90")]
	public NNDAHABCPBF(Bounds HPDFBJOLJPK, Vector2[] MEKPDIJBFHD, int DIGDPOPOLAN, byte GOGKDEGLBIL, float LPFICPPOAOL = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6F4FAD0", Offset = "0x6F4E2D0", VA = "0x186F4FAD0")]
	public MJLLOGCLAHK LFEINNEAFNP(byte NHHNPPKPBIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F5D0", Offset = "0x6F4DDD0", VA = "0x186F4F5D0")]
	public void ICCMCFLBNJE(Vector3 NABPHMOHNDG, float DDHPBADLENH, float JNFDEPAMMBN, ref List<byte> BEEKMCIHMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F5B0", Offset = "0x6F4DDB0", VA = "0x186F4F5B0")]
	public void FEHOKBLMJPE(MJLLOGCLAHK.KOILCJIOKNP KKIFBMFOGLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6F4FB30", Offset = "0x6F4E330", VA = "0x186F4FB30")]
	private MJLLOGCLAHK PNPBOFGNLHL(byte NHHNPPKPBIA, MJLLOGCLAHK.OPMMNHJPGMG KDIGJFOIKJP, MJLLOGCLAHK ONIJEEBBCHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F6D0", Offset = "0x6F4DED0", VA = "0x186F4F6D0")]
	private void IFADBHFFDNE(MJLLOGCLAHK ONIJEEBBCHK, Vector2[] MEKPDIJBFHD, int CILMBPKFFCE, int EAFEPBDFDIM, int GJJEPMBFAAA, int OPFCBHMHGAL, float LPFICPPOAOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class MJLLOGCLAHK
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public enum OPMMNHJPGMG
	{
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum KOILCJIOKNP
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public byte FKAHMJGAGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public Vector3 PNELKCHEAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public Vector3 NPEKKJBJFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public Vector3 JBCADIHHLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Vector3 EBPPKLNOGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public OPMMNHJPGMG CCPNOJKNAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public MJLLOGCLAHK PANFGPHKOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public List<MJLLOGCLAHK> LAJEILDOCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool JHBAPHFFLAF;

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F110", Offset = "0x6F4D910", VA = "0x186F4F110")]
	public MJLLOGCLAHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F0B0", Offset = "0x6F4D8B0", VA = "0x186F4F0B0")]
	public MJLLOGCLAHK(byte EDPPELMHBFA, OPMMNHJPGMG KDIGJFOIKJP, MJLLOGCLAHK ONIJEEBBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6F4ED70", Offset = "0x6F4D570", VA = "0x186F4ED70")]
	public void ANNGLPCKBKA(MJLLOGCLAHK PIKIEEICNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	public void FEHOKBLMJPE(int KBFDDKIHGJG, KOILCJIOKNP KKIFBMFOGLE, int HMAPHJEJDII = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6F4EE30", Offset = "0x6F4D630", VA = "0x186F4EE30")]
	public void ICCMCFLBNJE(List<byte> BEEKMCIHMLL, Vector3 NABPHMOHNDG, float DDHPBADLENH, float JNFDEPAMMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6F4ED10", Offset = "0x6F4D510", VA = "0x186F4ED10")]
	public bool ADHBNDPDEMC(Vector3 DBMHGAAIFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F070", Offset = "0x6F4D870", VA = "0x186F4F070")]
	public bool IFFGLHKMHOG(Vector3 DBMHGAAIFOA, float OMLGCLHOMLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class PELPFEPHMAD<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly Stack<T> IJBEJNBKLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly List<T> INABOCOMNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly int MIFKLGGGFMB;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int MLOGCOBMICF
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1CA0650", Offset = "0x1C9EE50", VA = "0x181CA0650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int ANAACLAKIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2BE10C0", Offset = "0x2BDF8C0", VA = "0x182BE10C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x40A83C0", Offset = "0x40A6BC0", VA = "0x1840A83C0")]
	public static global::PELPFEPHMAD<T> BAFOHBINEOF(int CABFJBCMJEP = 0, int MIFKLGGGFMB = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x40A8640", Offset = "0x40A6E40", VA = "0x1840A8640")]
	public static global::PELPFEPHMAD<T> GGJPEOJFGOE(int CABFJBCMJEP = 0, int MIFKLGGGFMB = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x40A8D30", Offset = "0x40A7530", VA = "0x1840A8D30")]
	public PELPFEPHMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x40A8BA0", Offset = "0x40A73A0", VA = "0x1840A8BA0")]
	public PELPFEPHMAD(int CABFJBCMJEP, int MIFKLGGGFMB = int.MaxValue, bool LENKKJLEHGG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x40A8710", Offset = "0x40A6F10", VA = "0x1840A8710")]
	public T HOMPIJPBAAK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x40A85A0", Offset = "0x40A6DA0", VA = "0x1840A85A0")]
	public void GCNLFMGFLMB(T ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x40A8820", Offset = "0x40A7020", VA = "0x1840A8820")]
	private void JPPJPDMPFBO(T ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x40A8580", Offset = "0x40A6D80", VA = "0x1840A8580")]
	private void FLIPLIMLBHB(T ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x40A8A90", Offset = "0x40A7290", VA = "0x1840A8A90")]
	[Conditional("DEBUG_BUILD")]
	private void LIPHCFDHODM(T PECELBJIIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x40A8B10", Offset = "0x40A7310", VA = "0x1840A8B10")]
	[Conditional("DEBUG_BUILD")]
	private void NJPCOOFGIDN(T PECELBJIIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x40A8490", Offset = "0x40A6C90", VA = "0x1840A8490", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x40A88F0", Offset = "0x40A70F0", VA = "0x1840A88F0")]
	private void LHHFPKAJLKC(IEnumerable<T> EFLCMDHDGNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class MENGMGNCHAD
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private enum MOEANLDJBFP : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private int DKKDLHLFHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private bool DKEIPANPPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private MOEANLDJBFP LLBKKANHBEL;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool DGAPNEIIHNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F4E290", Offset = "0x6F4CA90", VA = "0x186F4E290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool JBKFDKKFIGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DE50", Offset = "0x6F4C650", VA = "0x186F4DE50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F4ECD0", Offset = "0x6F4D4D0", VA = "0x186F4ECD0")]
	public MENGMGNCHAD(bool DKEIPANPPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E400", Offset = "0x6F4CC00", VA = "0x186F4E400")]
	public void MHGICPEJBKI(object HHNPCHNMLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E360", Offset = "0x6F4CB60", VA = "0x186F4E360")]
	public void LNLODCAJFHL(int ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E350", Offset = "0x6F4CB50", VA = "0x186F4E350")]
	public void KMFGLNICOCG(uint LMBKKGHKCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F4EAF0", Offset = "0x6F4D2F0", VA = "0x186F4EAF0")]
	public void MNGIKHHHMNH(bool ICCLFAJGICJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E2A0", Offset = "0x6F4CAA0", VA = "0x186F4E2A0")]
	public void HPKJALIKPBO(long EMIHEDBEOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E1D0", Offset = "0x6F4C9D0", VA = "0x186F4E1D0")]
	public void EICJDPNCLCN(ulong PEMMBHLEMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E2E0", Offset = "0x6F4CAE0", VA = "0x186F4E2E0")]
	public void KKOBPEEALOP(string EIJFOGFJFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F4EB10", Offset = "0x6F4D310", VA = "0x186F4EB10")]
	public void MNLNBHNMAGF(Enum KIEMAGPGLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F4EBA0", Offset = "0x6F4D3A0", VA = "0x186F4EBA0")]
	public void NGCBDFBKNCC(IList IFADMANLNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2BED530", Offset = "0x2BEBD30", VA = "0x182BED530")]
	public void MNLMDMKNKPH<T, U>(Dictionary<T, U> HFKHBPEFOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DE60", Offset = "0x6F4C660", VA = "0x186F4DE60")]
	private void DDCMKJDKNOK(IDictionary HFKHBPEFOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E220", Offset = "0x6F4CA20", VA = "0x186F4E220")]
	public int GGAILEDDGEJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F4EA80", Offset = "0x6F4D280", VA = "0x186F4EA80")]
	public short MLFCMGHNNBG()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E210", Offset = "0x6F4CA10", VA = "0x186F4E210")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DDE0", Offset = "0x6F4C5E0", VA = "0x186F4DDE0")]
	private void AIIBHFDFMLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface FNNMNCCHNGH
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class ResourcePrefabReference<T> : FNNMNCCHNGH where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x339F330", Offset = "0x339DB30", VA = "0x18339F330", Slot = "4")]
		public virtual T EJDINAAHLDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class ODDMALFOGNH<T> : IEnumerable<global::ODDMALFOGNH<T>.LJBOMMPGMCM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public struct LJBOMMPGMCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public T ECNGHFJBIJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public int NHHNPPKPBIA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class PONHNNKFMCD : IEnumerator<LJBOMMPGMCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private global::ODDMALFOGNH<T> GNJLJGGMKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private int NHHNPPKPBIA;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x1864080", Offset = "0x1862880", VA = "0x181864080", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public LJBOMMPGMCM NIBFGHDNPCH
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x2C6ED10", Offset = "0x2C6D510", VA = "0x182C6ED10", Slot = "4")]
			get
			{
				return default(LJBOMMPGMCM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8B1430", Offset = "0x8AFC30", VA = "0x1808B1430")]
		public PONHNNKFMCD(global::ODDMALFOGNH<T> GNJLJGGMKOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2C6EC90", Offset = "0x2C6D490", VA = "0x182C6EC90", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x8B1420", Offset = "0x8AFC20", VA = "0x1808B1420", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x1080410", Offset = "0x107EC10", VA = "0x181080410", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private struct BDDPHMEMNGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public bool IOMDHHNPFPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public T ECNGHFJBIJL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private const int GEFPLMHDKPO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Dictionary<T, int> KDKMLBIHINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private BDDPHMEMNGO[] JBBDGCLGNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int POAAGMGMFLG;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int ACPNKHONGLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8CDBD0", Offset = "0x8CC3D0", VA = "0x1808CDBD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xB20BA0", Offset = "0xB1F3A0", VA = "0x180B20BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x1CA0870", Offset = "0x1C9F070", VA = "0x181CA0870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x58D5310", Offset = "0x58D3B10", VA = "0x1858D5310")]
	public ODDMALFOGNH(int CABFJBCMJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x58D53E0", Offset = "0x58D3BE0", VA = "0x1858D53E0")]
	public ODDMALFOGNH(LJBOMMPGMCM[] LMHLDELFGFA, bool BFBLJDNFJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x58D44C0", Offset = "0x58D2CC0", VA = "0x1858D44C0")]
	public int HKMEJEIBDMP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x58D4A40", Offset = "0x58D3240", VA = "0x1858D4A40")]
	private int MCIKOHNCKFK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x58D4E60", Offset = "0x58D3660", VA = "0x1858D4E60", Slot = "6")]
	protected virtual uint NOOACFKFHCM(uint DKKDLHLFHOF, T ECNGHFJBIJL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x58D4030", Offset = "0x58D2830", VA = "0x1858D4030")]
	public bool EJCEIGEMLDE(T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x58D49F0", Offset = "0x58D31F0", VA = "0x1858D49F0")]
	public bool LKGBCPBLPKL(int NHHNPPKPBIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x58D4F30", Offset = "0x58D3730", VA = "0x1858D4F30")]
	public bool ODOLPHCGINH(Func<T, bool> GPMFMCCDAKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x58D5010", Offset = "0x58D3810", VA = "0x1858D5010")]
	public int OKNGNIBBBIN(T ECNGHFJBIJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x58D4140", Offset = "0x58D2940", VA = "0x1858D4140")]
	public T GCHGIFGBMBE(int NHHNPPKPBIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x58D4070", Offset = "0x58D2870", VA = "0x1858D4070")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x58D4730", Offset = "0x58D2F30", VA = "0x1858D4730")]
	public bool JCOHIHLGEAI(T ECNGHFJBIJL, bool MBBKNCOABPJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x58D4770", Offset = "0x58D2F70", VA = "0x1858D4770")]
	public bool JCOHIHLGEAI(T ECNGHFJBIJL, int NHHNPPKPBIA, bool MBBKNCOABPJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x58D3FA0", Offset = "0x58D27A0", VA = "0x1858D3FA0")]
	public bool CPPHPNNFPKL(T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x58D40F0", Offset = "0x58D28F0", VA = "0x1858D40F0")]
	public bool FLLDAADPLON(int NHHNPPKPBIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x58D50C0", Offset = "0x58D38C0", VA = "0x1858D50C0")]
	private void PLKEILCEGJN(int NHHNPPKPBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x58D4210", Offset = "0x58D2A10", VA = "0x1858D4210")]
	public LJBOMMPGMCM[] GMJCFHAOGEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x58D3E80", Offset = "0x58D2680", VA = "0x1858D3E80")]
	private int BNIANHFGIEL(int GOGKDEGLBIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x58D5290", Offset = "0x58D3A90", VA = "0x1858D5290", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x58D5290", Offset = "0x58D3A90", VA = "0x1858D5290", Slot = "4")]
	private IEnumerator<LJBOMMPGMCM> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x6F502B0", Offset = "0x6F4EAB0", VA = "0x186F502B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x6F50540", Offset = "0x6F4ED40", VA = "0x186F50540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x6F50470", Offset = "0x6F4EC70", VA = "0x186F50470")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x6F506A0", Offset = "0x6F4EEA0", VA = "0x186F506A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x6F50220", Offset = "0x6F4EA20", VA = "0x186F50220")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x6F504B0", Offset = "0x6F4ECB0", VA = "0x186F504B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x6F503E0", Offset = "0x6F4EBE0", VA = "0x186F503E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x6F501C0", Offset = "0x6F4E9C0", VA = "0x186F501C0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class PHHJDALPKOO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private int CABFJBCMJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int AIHECMHOMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private List<T> CHCFPJJJGHE;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x1CA0650", Offset = "0x1C9EE50", VA = "0x181CA0650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T FGBCPLCCPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x3D4EC90", Offset = "0x3D4D490", VA = "0x183D4EC90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T IHFHFPJDIEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x3D4EC30", Offset = "0x3D4D430", VA = "0x183D4EC30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T IEFOFNHJPJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x3D4E8A0", Offset = "0x3D4D0A0", VA = "0x183D4E8A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x3D4EDA0", Offset = "0x3D4D5A0", VA = "0x183D4EDA0")]
	public PHHJDALPKOO(int CABFJBCMJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x3D4E900", Offset = "0x3D4D100", VA = "0x183D4E900")]
	public void CAILCKFFJIK(T PELNFFOMEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x3D4EAB0", Offset = "0x3D4D2B0", VA = "0x183D4EAB0")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x3D4EB50", Offset = "0x3D4D350", VA = "0x183D4EB50")]
	public void LGIJHOHKAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x3D4EB00", Offset = "0x3D4D300", VA = "0x183D4EB00")]
	public void KAHJOMCPNBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x3D4EAF0", Offset = "0x3D4D2F0", VA = "0x183D4EAF0")]
	public void GNNOECBFBEH()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		public struct AOIFHMHEOBD<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private readonly List<Component> IFADMANLNLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private readonly bool NIIBMIPCAIP;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0xB884F0", Offset = "0xB86CF0", VA = "0x180B884F0")]
			public AOIFHMHEOBD(List<Component> IFADMANLNLG, bool NIIBMIPCAIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x3B13B40", Offset = "0x3B12340", VA = "0x183B13B40")]
			public ILPKPLJCBEG<T> MEOEHOBEEMI()
			{
				return default(ILPKPLJCBEG<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x3B13BB0", Offset = "0x3B123B0", VA = "0x183B13BB0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x3B13BB0", Offset = "0x3B123B0", VA = "0x183B13BB0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		public struct ILPKPLJCBEG<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private readonly List<Component> IFADMANLNLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private readonly bool NIIBMIPCAIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private int NHHNPPKPBIA;

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public T NIBFGHDNPCH
			{
				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x34C20C0", Offset = "0x34C08C0", VA = "0x1834C20C0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x34C2050", Offset = "0x34C0850", VA = "0x1834C2050", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x34C2090", Offset = "0x34C0890", VA = "0x1834C2090")]
			public ILPKPLJCBEG(List<Component> IFADMANLNLG, bool NIIBMIPCAIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x34C1F80", Offset = "0x34C0780", VA = "0x1834C1F80", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x34C1F90", Offset = "0x34C0790", VA = "0x1834C1F90", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x1CA3B40", Offset = "0x1CA2340", VA = "0x181CA3B40", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x6F52340", Offset = "0x6F50B40", VA = "0x186F52340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6F52300", Offset = "0x6F50B00", VA = "0x186F52300")]
		public ToolHierarchyCache(GameObject NBIMDBPEIEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F52090", Offset = "0x6F50890", VA = "0x186F52090")]
		private void PBAELFIBGFO(GameObject NBIMDBPEIEO, bool HCKNDFMIDDI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F521F0", Offset = "0x6F509F0", VA = "0x186F521F0")]
		public static void PBAELFIBGFO(GameObject NBIMDBPEIEO, ref ToolHierarchyCache LFMIPHMBPFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F51A90", Offset = "0x6F50290", VA = "0x186F51A90")]
		public void ANPJJMKPGMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F51F40", Offset = "0x6F50740", VA = "0x186F51F40")]
		public void GKIIAEKNGIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x2326D60", Offset = "0x2325560", VA = "0x182326D60")]
		public void EEAGIEBGMCO<T>(Action<T> FOGMDOMFJBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x6F51AA0", Offset = "0x6F502A0", VA = "0x186F51AA0")]
		public Component DCCFLCNADKN(Type FIJCKHKKDCC, bool NIIBMIPCAIP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x2326CE0", Offset = "0x23254E0", VA = "0x182326CE0")]
		public T DCCFLCNADKN<T>(bool NIIBMIPCAIP = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F52010", Offset = "0x6F50810", VA = "0x186F52010")]
		public AOIFHMHEOBD<Component> KAFLFGBEGNK(Type FIJCKHKKDCC, bool NIIBMIPCAIP = false)
		{
			return default(AOIFHMHEOBD<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x2326FF0", Offset = "0x23257F0", VA = "0x182326FF0")]
		public AOIFHMHEOBD<T> KAFLFGBEGNK<T>(bool NIIBMIPCAIP = false) where T : class
		{
			return default(AOIFHMHEOBD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F51B70", Offset = "0x6F50370", VA = "0x186F51B70")]
		public List<Component> ECLFANLFHCP(Type FIJCKHKKDCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6F51EC0", Offset = "0x6F506C0", VA = "0x186F51EC0", Slot = "4")]
		public bool Equals(ToolHierarchyCache OLGJDFCIILF, ToolHierarchyCache IKFJLOPMKHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6F51F90", Offset = "0x6F50790", VA = "0x186F51F90", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache HHNPCHNMLMA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class ONOCFLKCDJK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private Dictionary<int, T> BAOLHJKGDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private T JIJJCBMAPHG;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public virtual T FJMEJLGHOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8445F0", Offset = "0x842DF0", VA = "0x1808445F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x811A70", Offset = "0x810270", VA = "0x180811A70", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool LKOPKHPHBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x3FEDA60", Offset = "0x3FEC260", VA = "0x183FEDA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x3FED830", Offset = "0x3FEC030", VA = "0x183FED830")]
	public bool JKMEINBJGBN(T ECNGHFJBIJL, int KPEDMKNLCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x3CA5D00", Offset = "0x3CA4500", VA = "0x183CA5D00")]
	public bool CBLDDCBDCPG(int KPEDMKNLCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x3FED570", Offset = "0x3FEBD70", VA = "0x183FED570")]
	public T BKLJFFBODNE(int ILGDIFFHGJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x3FED770", Offset = "0x3FEBF70", VA = "0x183FED770")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x3FED9D0", Offset = "0x3FEC1D0", VA = "0x183FED9D0")]
	private bool KOEJMAALIAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x3FED890", Offset = "0x3FEC090", VA = "0x183FED890")]
	public bool KFBGNHHGLGM(int KPEDMKNLCKL, out T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x3FEDAA0", Offset = "0x3FEC2A0", VA = "0x183FEDAA0")]
	public ONOCFLKCDJK()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x80EC90", Offset = "0x80D490", VA = "0x18080EC90")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public T this[int OCIFJAIBHIA, int BJBICJAGAJI]
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x460EBC0", Offset = "0x460D3C0", VA = "0x18460EBC0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x460EC60", Offset = "0x460D460", VA = "0x18460EC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x460EB30", Offset = "0x460D330", VA = "0x18460EB30")]
		public Array2D(uint JJJHCGPEBDK, uint BABILIHBNMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x460EAB0", Offset = "0x460D2B0", VA = "0x18460EAB0")]
		public void ELJLHOEKJGC()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B1A0", Offset = "0x6F499A0", VA = "0x186F4B1A0")]
		public Array2DVector3(uint JJJHCGPEBDK, uint BABILIHBNMO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public abstract class EKNDDHLLNAF<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	internal class KHKLKKIPEJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public TNode GPOCLJBKMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public TNode ONIJEEBBCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public JLILJGDKBBL IAHKGFLACPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public List<JLILJGDKBBL> ANODFGDANPC;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public KHKLKKIPEJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	internal struct JLILJGDKBBL : IComparable<JLILJGDKBBL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public int KPEDMKNLCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public TClaimant EGEEGBMEGLE;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8D7E80", Offset = "0x8D6680", VA = "0x1808D7E80")]
		public JLILJGDKBBL(int KPEDMKNLCKL, TClaimant EGEEGBMEGLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x398CAA0", Offset = "0x398B2A0", VA = "0x18398CAA0")]
		public bool GPEADCLPDIN(in JLILJGDKBBL MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x398CB00", Offset = "0x398B300", VA = "0x18398CB00")]
		public bool KEJEEAFEICO(in JLILJGDKBBL MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x398CA90", Offset = "0x398B290", VA = "0x18398CA90", Slot = "4")]
		public int CompareTo(JLILJGDKBBL MDHJAFNLPON)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x398CB10", Offset = "0x398B310", VA = "0x18398CB10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public enum PELFGNAENHP
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class NPKDNEBFNHL : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public global::EKNDDHLLNAF<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x185F5D0", Offset = "0x185DDD0", VA = "0x18185F5D0")]
		[DebuggerHidden]
		public NPKDNEBFNHL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x453A060", Offset = "0x4538860", VA = "0x18453A060", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x453A220", Offset = "0x4538A20", VA = "0x18453A220", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x453A140", Offset = "0x4538940", VA = "0x18453A140", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x29CB1D0", Offset = "0x29C99D0", VA = "0x1829CB1D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly global::PELPFEPHMAD<KHKLKKIPEJN> EELCAEBOFFM;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static readonly global::PELPFEPHMAD<List<JLILJGDKBBL>> MFEGPLFNDDJ;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static int CHBMPNJIEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	internal readonly Dictionary<TClaimant, TNode> HGCNNOPPNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	internal readonly Dictionary<TNode, KHKLKKIPEJN> IJEMPJFPEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private PELFGNAENHP JBENBACJFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private bool FNDAICJNELC;

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode DMFKJLCKIIE(TNode KGOMINCBAMA);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void CHIPGINFBJC(TNode KGOMINCBAMA, TClaimant PJOIPLFMOAI, TClaimant CALJEIEACGE);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x386E480", Offset = "0x386CC80", VA = "0x18386E480")]
	public EKNDDHLLNAF(PELFGNAENHP JBENBACJFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x386D5B0", Offset = "0x386BDB0", VA = "0x18386D5B0")]
	public void FKGJDDAEGLK(TNode KGOMINCBAMA, TNode PBNMPICADBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x386DEA0", Offset = "0x386C6A0", VA = "0x18386DEA0")]
	public void JPCDDCFOIGI(TClaimant EGEEGBMEGLE, TNode CLJGCEOPLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x386CFA0", Offset = "0x386B7A0", VA = "0x18386CFA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x386CDF0", Offset = "0x386B5F0", VA = "0x18386CDF0")]
	private void CPAJAOFAAFJ(TClaimant EGEEGBMEGLE, TNode POMMEIPFPHP, TNode CLJGCEOPLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x386D880", Offset = "0x386C080", VA = "0x18386D880")]
	private int HEJMHANDCGK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x386DFA0", Offset = "0x386C7A0", VA = "0x18386DFA0")]
	private void KHCOABMANLN(TClaimant EGEEGBMEGLE, TNode IMPGKOHBIPN, TNode ILLJGBKEOAD, int BMIEHFOKELI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x386DC50", Offset = "0x386C450", VA = "0x18386DC50")]
	private void IMBAJJGHDCD(JLILJGDKBBL OPJLAOONFEH, KHKLKKIPEJN OHMGDMICHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x386D8E0", Offset = "0x386C0E0", VA = "0x18386D8E0")]
	private void HPBCIBBKMPL(TClaimant EGEEGBMEGLE, TNode IMPGKOHBIPN, TNode ILLJGBKEOAD, int BMIEHFOKELI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x386CE90", Offset = "0x386B690", VA = "0x18386CE90")]
	private void DFCGKHFBIDA(JLILJGDKBBL OPJLAOONFEH, TNode KGOMINCBAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x386CCF0", Offset = "0x386B4F0", VA = "0x18386CCF0")]
	private void COLCFPHPLDE(JLILJGDKBBL OPJLAOONFEH, KHKLKKIPEJN OHMGDMICHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x386DB40", Offset = "0x386C340", VA = "0x18386DB40")]
	private void IHILHNKOHNP(KHKLKKIPEJN OHMGDMICHJP, bool BGGLIBKOBCP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x386D200", Offset = "0x386BA00", VA = "0x18386D200")]
	private void FFFEOJFGAIG(KHKLKKIPEJN OHMGDMICHJP, TNode PBNMPICADBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x386E250", Offset = "0x386CA50", VA = "0x18386E250")]
	[IteratorStateMachine(typeof(global::EKNDDHLLNAF<, >.NPKDNEBFNHL))]
	private IEnumerable<TNode> MNIDAKMNMJF(TNode IMPGKOHBIPN, TNode ILLJGBKEOAD, bool KFHLMAACNGD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x386D7C0", Offset = "0x386BFC0", VA = "0x18386D7C0")]
	private KHKLKKIPEJN GDCGDMODFFD(TNode KGOMINCBAMA, TNode ONIJEEBBCHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x386D630", Offset = "0x386BE30", VA = "0x18386D630")]
	private KHKLKKIPEJN GANJBHGFBOM(TNode KGOMINCBAMA, TNode ONIJEEBBCHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x386DCE0", Offset = "0x386C4E0", VA = "0x18386DCE0")]
	private void JBDCLPHMMEJ(KHKLKKIPEJN OHMGDMICHJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class EIIPLGIKDAC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	protected struct AIFHIDMLANH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public T MHGNIJCIFFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int FEBAPKLGMEF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	protected readonly List<AIFHIDMLANH> FFPFEFDNOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private T AHKMPCAKAAP;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x1CA0870", Offset = "0x1C9F070", VA = "0x181CA0870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3863360", Offset = "0x3861B60", VA = "0x183863360")]
	public bool ODOLPHCGINH(T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x3862EA0", Offset = "0x38616A0", VA = "0x183862EA0")]
	public void CAILCKFFJIK(T ECNGHFJBIJL, int KPEDMKNLCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x3862FB0", Offset = "0x38617B0", VA = "0x183862FB0")]
	public bool CPPHPNNFPKL(T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x38630D0", Offset = "0x38618D0", VA = "0x1838630D0")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x3862F40", Offset = "0x3861740", VA = "0x183862F40")]
	public T CNIMANKOCJI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x3863130", Offset = "0x3861930", VA = "0x183863130")]
	public T GJLDCBJIJID()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x38631A0", Offset = "0x38619A0", VA = "0x1838631A0")]
	private void LPOKGMLFAHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x3863570", Offset = "0x3861D70", VA = "0x183863570")]
	public EIIPLGIKDAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class IGKFDGODDKG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private struct LCCDDKDFKNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int FEBAPKLGMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public T MHGNIJCIFFL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly Dictionary<object, LCCDDKDFKNF> BAOLHJKGDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly EqualityComparer<T> EPMCDJFENIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private T JIJJCBMAPHG;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public virtual T FJMEJLGHOFI
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x1CA7440", Offset = "0x1CA5C40", VA = "0x181CA7440", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x1CA75A0", Offset = "0x1CA5DA0", VA = "0x181CA75A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool LKOPKHPHBFE
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x1CAC4D0", Offset = "0x1CAACD0", VA = "0x181CAC4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public object IGIAPBEOOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A40", Offset = "0x7F1240", VA = "0x1807F2A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x919F90", Offset = "0x918790", VA = "0x180919F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x1CA75E0", Offset = "0x1CA5DE0", VA = "0x181CA75E0")]
	public bool JKMEINBJGBN(T ECNGHFJBIJL, object FLDJLPKNKKO, int KPEDMKNLCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x1CA73B0", Offset = "0x1CA5BB0", VA = "0x181CA73B0")]
	public bool CBLDDCBDCPG(object FLDJLPKNKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x1CA7FF0", Offset = "0x1CA67F0", VA = "0x181CA7FF0")]
	public bool KFBGNHHGLGM(object FLDJLPKNKKO, out T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1CA7500", Offset = "0x1CA5D00", VA = "0x181CA7500")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x1CAAB80", Offset = "0x1CA9380", VA = "0x181CAAB80")]
	private bool KOEJMAALIAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x1CAC500", Offset = "0x1CAAD00", VA = "0x181CAC500")]
	public IGKFDGODDKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class EDOHCHPDFEG
{
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x6F4CAA0", Offset = "0x6F4B2A0", VA = "0x186F4CAA0")]
	public static void AEJPPLPBPDK(FMDOKKBAPOM AOCJDBLPGHC, string ALGKPJEIDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	public static void AEJPPLPBPDK(IEnumerable<object> APMAFHMKLGB, string ALGKPJEIDOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class FGBDFJACAML : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private bool DGJLKLLEJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private Action FOGMDOMFJBB;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public static FGBDFJACAML LNLMHDNBOJI
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x6F4CE10", Offset = "0x6F4B610", VA = "0x186F4CE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool BCIDLILPMOL
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x8116F0", Offset = "0x80FEF0", VA = "0x1808116F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6F4CE90", Offset = "0x6F4B690", VA = "0x186F4CE90")]
	public FGBDFJACAML(Action FOGMDOMFJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x6F4CDF0", Offset = "0x6F4B5F0", VA = "0x186F4CDF0")]
	public void KOGMCNBOFCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6F4CDF0", Offset = "0x6F4B5F0", VA = "0x186F4CDF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public class JPPAIIMIMHD : PKHKKGNCOIB
{
	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D850", Offset = "0x6F4C050", VA = "0x186F4D850")]
	public JPPAIIMIMHD(UnityEngine.Object ICENKGBLLMO)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0xBC23C0", Offset = "0xBC0BC0", VA = "0x180BC23C0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
