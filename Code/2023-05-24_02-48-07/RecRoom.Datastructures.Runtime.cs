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
		[Cpp2IlInjected.Address(RVA = "0x7F0000", Offset = "0x7EEC00", VA = "0x1807F0000")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7F03D0", Offset = "0x7EEFD0", VA = "0x1807F03D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA66B10", Offset = "0xA65710", VA = "0x180A66B10")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA66CC0", Offset = "0xA658C0", VA = "0x180A66CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "4")]
	public virtual void JFMEPFIDBGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
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
	[Cpp2IlInjected.Address(RVA = "0x455C0C0", Offset = "0x455ACC0", VA = "0x18455C0C0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x455B7F0", Offset = "0x455A3F0", VA = "0x18455B7F0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x455C600", Offset = "0x455B200", VA = "0x18455C600")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
		public MMJMINFFNBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x35FBC10", Offset = "0x35FA810", VA = "0x1835FBC10")]
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
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x14BAE20", Offset = "0x14B9A20", VA = "0x1814BAE20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x14BAE50", Offset = "0x14B9A50", VA = "0x1814BAE50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x14BAD70", Offset = "0x14B9970", VA = "0x1814BAD70", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public TVal this[TKey BDFCACLHAFA]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x14BADD0", Offset = "0x14B99D0", VA = "0x1814BADD0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x14BAC70", Offset = "0x14B9870", VA = "0x1814BAC70", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x14BA7C0", Offset = "0x14B93C0", VA = "0x1814BA7C0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x14B9FE0", Offset = "0x14B8BE0", VA = "0x1814B9FE0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x14B9C90", Offset = "0x14B8890", VA = "0x1814B9C90", Slot = "14")]
	protected virtual string NEFECHKBEFL(TKeyVal BNDCFAJLFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x14B9B70", Offset = "0x14B8770", VA = "0x1814B9B70", Slot = "4")]
	public bool ContainsKey(TKey BDFCACLHAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x14BAB60", Offset = "0x14B9760", VA = "0x1814BAB60", Slot = "5")]
	public bool TryGetValue(TKey BDFCACLHAFA, out TVal ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x14B9BA0", Offset = "0x14B87A0", VA = "0x1814B9BA0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x14B9BA0", Offset = "0x14B87A0", VA = "0x1814B9BA0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x14BAB90", Offset = "0x14B9790", VA = "0x1814BAB90")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
		public OBBBBFHBOEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x48F6820", Offset = "0x48F5420", VA = "0x1848F6820")]
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
		[Cpp2IlInjected.Address(RVA = "0x4413320", Offset = "0x4411F20", VA = "0x184413320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x44136C0", Offset = "0x44122C0", VA = "0x1844136C0")]
	public CNNIIPPIOPJ(float DKKFNKOOCJP, float IPJBOBKGHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x44133A0", Offset = "0x4411FA0", VA = "0x1844133A0")]
	public bool LMBLOMODHDD(float EAJNKPCKLBB, T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4413660", Offset = "0x4412260", VA = "0x184413660")]
	public int OLCBCPFMDCE(float EAJNKPCKLBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4412C20", Offset = "0x4411820", VA = "0x184412C20")]
	public IEnumerable<T> JJMGPPHLILD(float EAJNKPCKLBB, [Optional] float? LMJBKPCPDMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4412BF0", Offset = "0x44117F0", VA = "0x184412BF0")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4412B30", Offset = "0x4411730", VA = "0x184412B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x408AA40", Offset = "0x4089640", VA = "0x18408AA40")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x408AA50", Offset = "0x4089650", VA = "0x18408AA50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float KCJJFHHFMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xF749E0", Offset = "0xF735E0", VA = "0x180F749E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x408A770", Offset = "0x4089370", VA = "0x18408A770")]
	public T AMDGGMCPAGC(float NFOHJNABMAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x408AA60", Offset = "0x4089660", VA = "0x18408AA60")]
	public T GHIOHNJFFFC(float NFOHJNABMAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GAIKGPLFBOK(T EOEOFNCKKHJ, T AOEAFBFCPPC, float NFOHJNABMAP);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3BA0020", Offset = "0x3B9EC20", VA = "0x183BA0020", Slot = "4")]
	protected override float GAIKGPLFBOK(float EOEOFNCKKHJ, float AOEAFBFCPPC, float NFOHJNABMAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6F14480", Offset = "0x6F13080", VA = "0x186F14480")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1FA15F0", Offset = "0x1FA01F0", VA = "0x181FA15F0", Slot = "4")]
	protected override Vector3 GAIKGPLFBOK(Vector3 EOEOFNCKKHJ, Vector3 AOEAFBFCPPC, float NFOHJNABMAP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F19A50", Offset = "0x6F18650", VA = "0x186F19A50")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6F13ED0", Offset = "0x6F12AD0", VA = "0x186F13ED0", Slot = "4")]
	protected override Color GAIKGPLFBOK(Color EOEOFNCKKHJ, Color AOEAFBFCPPC, float NFOHJNABMAP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F13F30", Offset = "0x6F12B30", VA = "0x186F13F30")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HKFGBLBDDNE
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2058240", Offset = "0x2056E40", VA = "0x182058240")]
	public static global::JNBEGEHKKJM<T1> JLAKJAPJOGA<T1>(T1 JOIOHBCDFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B270", Offset = "0x2B79E70", VA = "0x182B7B270")]
	public static global::DKKIFMJJILM<T1, T2> JLAKJAPJOGA<T1, T2>(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B2E0", Offset = "0x2B79EE0", VA = "0x182B7B2E0")]
	public static global::HOMFIJMJJHM<T1, T2, T3> JLAKJAPJOGA<T1, T2, T3>(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2028F20", Offset = "0x2027B20", VA = "0x182028F20")]
	public static global::CDDKCCPIDDP<T1, T2, T3, T4> JLAKJAPJOGA<T1, T2, T3, T4>(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B5B0", Offset = "0x2B7A1B0", VA = "0x182B7B5B0")]
	public static global::ADGBDOJBFMC<T1, T2, T3, T4, T5> JLAKJAPJOGA<T1, T2, T3, T4, T5>(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B500", Offset = "0x2B7A100", VA = "0x182B7B500")]
	public static global::GEOAJILLIMF<T1, T2, T3, T4, T5, T6> JLAKJAPJOGA<T1, T2, T3, T4, T5, T6>(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ, T6 EMIINFLAGLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B440", Offset = "0x2B7A040", VA = "0x182B7B440")]
	public static global::ICIIMIDMKDJ<T1, T2, T3, T4, T5, T6, T7> JLAKJAPJOGA<T1, T2, T3, T4, T5, T6, T7>(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ, T6 EMIINFLAGLO, T7 IEGCJACCDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B370", Offset = "0x2B79F70", VA = "0x182B7B370")]
	public static global::OFIAOOPFNIN<T1, T2, T3, T4, T5, T6, T7, T8> JLAKJAPJOGA<T1, T2, T3, T4, T5, T6, T7, T8>(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ, T6 EMIINFLAGLO, T7 IEGCJACCDDH, T8 BLDJGMBLIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x214EF10", Offset = "0x214DB10", VA = "0x18214EF10")]
	[IteratorStateMachine(typeof(PNGEMDOFCPN))]
	public static IEnumerable<global::DKKIFMJJILM<T1, T2>> IIONLKHJGPM<T1, T2>(IEnumerable<T1> NBLDAOBEAEA, IEnumerable<T2> PAJLLFKCBBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x252CDC0", Offset = "0x252B9C0", VA = "0x18252CDC0")]
	[IteratorStateMachine(typeof(DGHBLAMNHLE))]
	public static IEnumerable<global::HOMFIJMJJHM<T1, T2, T3>> IIONLKHJGPM<T1, T2, T3>(IEnumerable<T1> NBLDAOBEAEA, IEnumerable<T2> PAJLLFKCBBD, IEnumerable<T3> CKEDCDKNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6F14B90", Offset = "0x6F13790", VA = "0x186F14B90")]
	internal static int LGKODIFOLJA(int PMBDJGMHKEL, int FPPGIJAPGLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F14BF0", Offset = "0x6F137F0", VA = "0x186F14BF0")]
	internal static int LGKODIFOLJA(int PMBDJGMHKEL, int FPPGIJAPGLA, int HPCKIBLPPLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F14BD0", Offset = "0x6F137D0", VA = "0x186F14BD0")]
	internal static int LGKODIFOLJA(int PMBDJGMHKEL, int FPPGIJAPGLA, int HPCKIBLPPLG, int LMGFBGGABJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F14C30", Offset = "0x6F13830", VA = "0x186F14C30")]
	internal static int LGKODIFOLJA(int PMBDJGMHKEL, int FPPGIJAPGLA, int HPCKIBLPPLG, int LMGFBGGABJK, int FKFGAJKGKKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F14BA0", Offset = "0x6F137A0", VA = "0x186F14BA0")]
	internal static int LGKODIFOLJA(int PMBDJGMHKEL, int FPPGIJAPGLA, int HPCKIBLPPLG, int LMGFBGGABJK, int FKFGAJKGKKO, int AKHLOFDPCJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F14B60", Offset = "0x6F13760", VA = "0x186F14B60")]
	internal static int LGKODIFOLJA(int PMBDJGMHKEL, int FPPGIJAPGLA, int HPCKIBLPPLG, int LMGFBGGABJK, int FKFGAJKGKKO, int AKHLOFDPCJO, int GAJHMIDDLHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F14C00", Offset = "0x6F13800", VA = "0x186F14C00")]
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
	[Cpp2IlInjected.Address(RVA = "0x1A0C660", Offset = "0x1A0B260", VA = "0x181A0C660")]
	public JNBEGEHKKJM(T1 JOIOHBCDFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x350D920", Offset = "0x350C520", VA = "0x18350D920", Slot = "4")]
	public int CompareTo(global::JNBEGEHKKJM<T1> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x350D990", Offset = "0x350C590", VA = "0x18350D990", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xD86A90", Offset = "0xD85690", VA = "0x180D86A90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x350DA30", Offset = "0x350C630", VA = "0x18350DA30", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x19FE160", Offset = "0x19FCD60", VA = "0x1819FE160")]
	public DKKIFMJJILM(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x341D9A0", Offset = "0x341C5A0", VA = "0x18341D9A0", Slot = "4")]
	public int CompareTo(global::DKKIFMJJILM<T1, T2> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x341DBC0", Offset = "0x341C7C0", VA = "0x18341DBC0", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x341E400", Offset = "0x341D000", VA = "0x18341E400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x341E960", Offset = "0x341D560", VA = "0x18341E960", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x477E3E0", Offset = "0x477CFE0", VA = "0x18477E3E0")]
	public HOMFIJMJJHM(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x477DBA0", Offset = "0x477C7A0", VA = "0x18477DBA0", Slot = "4")]
	public int CompareTo(global::HOMFIJMJJHM<T1, T2, T3> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x477DDA0", Offset = "0x477C9A0", VA = "0x18477DDA0", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x477E030", Offset = "0x477CC30", VA = "0x18477E030", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x477E120", Offset = "0x477CD20", VA = "0x18477E120", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x28BBFF0", Offset = "0x28BABF0", VA = "0x1828BBFF0")]
	public CDDKCCPIDDP(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x33DD1C0", Offset = "0x33DBDC0", VA = "0x1833DD1C0", Slot = "4")]
	public int CompareTo(global::CDDKCCPIDDP<T1, T2, T3, T4> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x33DD300", Offset = "0x33DBF00", VA = "0x1833DD300", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x33DD440", Offset = "0x33DC040", VA = "0x1833DD440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x33DD500", Offset = "0x33DC100", VA = "0x1833DD500", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x37FC8D0", Offset = "0x37FB4D0", VA = "0x1837FC8D0")]
	public ADGBDOJBFMC(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x39102D0", Offset = "0x390EED0", VA = "0x1839102D0", Slot = "4")]
	public int CompareTo(global::ADGBDOJBFMC<T1, T2, T3, T4, T5> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3910450", Offset = "0x390F050", VA = "0x183910450", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x39105C0", Offset = "0x390F1C0", VA = "0x1839105C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x39106C0", Offset = "0x390F2C0", VA = "0x1839106C0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x28B76F0", Offset = "0x28B62F0", VA = "0x1828B76F0")]
	public GEOAJILLIMF(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ, T6 EMIINFLAGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x28B7110", Offset = "0x28B5D10", VA = "0x1828B7110", Slot = "4")]
	public int CompareTo(global::GEOAJILLIMF<T1, T2, T3, T4, T5, T6> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x28B72D0", Offset = "0x28B5ED0", VA = "0x1828B72D0", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x28B7460", Offset = "0x28B6060", VA = "0x1828B7460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x28B7580", Offset = "0x28B6180", VA = "0x1828B7580", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1A0AA70", Offset = "0x1A09670", VA = "0x181A0AA70")]
	public ICIIMIDMKDJ(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ, T6 EMIINFLAGLO, T7 IEGCJACCDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1A0A3D0", Offset = "0x1A08FD0", VA = "0x181A0A3D0", Slot = "4")]
	public int CompareTo(global::ICIIMIDMKDJ<T1, T2, T3, T4, T5, T6, T7> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1A0A5D0", Offset = "0x1A091D0", VA = "0x181A0A5D0", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1A0A790", Offset = "0x1A09390", VA = "0x181A0A790", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1A0A8E0", Offset = "0x1A094E0", VA = "0x181A0A8E0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x4069C20", Offset = "0x4068820", VA = "0x184069C20")]
	public OFIAOOPFNIN(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ, T6 EMIINFLAGLO, T7 IEGCJACCDDH, T8 BLDJGMBLIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x40694D0", Offset = "0x40680D0", VA = "0x1840694D0", Slot = "4")]
	public int CompareTo(global::OFIAOOPFNIN<T1, T2, T3, T4, T5, T6, T7, T8> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4069720", Offset = "0x4068320", VA = "0x184069720", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4069900", Offset = "0x4068500", VA = "0x184069900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4069A70", Offset = "0x4068670", VA = "0x184069A70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GGOALGOKAII : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8B8290", Offset = "0x8B6E90", VA = "0x1808B8290")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7F3030", Offset = "0x7F1C30", VA = "0x1807F3030", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8370C0", Offset = "0x835CC0", VA = "0x1808370C0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8370D0", Offset = "0x835CD0", VA = "0x1808370D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8D5ED0", Offset = "0x8D4AD0", VA = "0x1808D5ED0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash DKKDLHLFHOF);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x12EAAC0", Offset = "0x12E96C0", VA = "0x1812EAAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F18930", Offset = "0x6F17530", VA = "0x186F18930")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6F188F0", Offset = "0x6F174F0", VA = "0x186F188F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F18970", Offset = "0x6F17570", VA = "0x186F18970")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F18B40", Offset = "0x6F17740", VA = "0x186F18B40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6F18AB0", Offset = "0x6F176B0", VA = "0x186F18AB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x14D3EB0", Offset = "0x14D2AB0", VA = "0x1814D3EB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x11CFEB0", Offset = "0x11CEAB0", VA = "0x1811CFEB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F188B0", Offset = "0x6F174B0", VA = "0x186F188B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F18A20", Offset = "0x6F17620", VA = "0x186F18A20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6F184E0", Offset = "0x6F170E0", VA = "0x186F184E0")]
	public void CopyBounds(SavedExtents MDHJAFNLPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6F18810", Offset = "0x6F17410", VA = "0x186F18810")]
	public void SetLocalSpaceBounds(Bounds PDOKDMEPNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6F17E80", Offset = "0x6F16A80", VA = "0x186F17E80")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6F18800", Offset = "0x6F17400", VA = "0x186F18800")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6F17C90", Offset = "0x6F16890", VA = "0x186F17C90")]
	private void AMFJDGCNLGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6F185D0", Offset = "0x6F171D0", VA = "0x186F185D0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6F17EA0", Offset = "0x6F16AA0", VA = "0x186F17EA0")]
	public static void CalculateLocalBoundsFor(GameObject ALBKEDBKENG, out Bounds PDOKDMEPNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6F18510", Offset = "0x6F17110", VA = "0x186F18510")]
	private static void MMDCCKHCKON(Bounds PAJLLFKCBBD, Color CKEDCDKNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6F18830", Offset = "0x6F17430", VA = "0x186F18830")]
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
		[Cpp2IlInjected.Address(RVA = "0x11C15D0", Offset = "0x11C01D0", VA = "0x1811C15D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBE0", Offset = "0xFBB7E0", VA = "0x180FBCBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9190", Offset = "0x2BE7D90", VA = "0x182BE9190")]
	public FGGONGOBJMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9090", Offset = "0x2BE7C90", VA = "0x182BE9090")]
	public FGGONGOBJMA(int GEFPLPIBMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7D50", Offset = "0x2BE6950", VA = "0x182BE7D50")]
	public void CAILCKFFJIK(float EAJNKPCKLBB, T ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7E30", Offset = "0x2BE6A30", VA = "0x182BE7E30")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2BE8890", Offset = "0x2BE7490", VA = "0x182BE8890")]
	public bool LDONHAGGEGK(float JINIMOJBGDF, float LMCEDNNCHKG, out T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2BE8220", Offset = "0x2BE6E20", VA = "0x182BE8220")]
	public bool FEGGBFBCJPA(float JINIMOJBGDF, float LMCEDNNCHKG, out T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2BE8D90", Offset = "0x2BE7990", VA = "0x182BE8D90")]
	public void MHMAJDPNOML(float JINIMOJBGDF, float LMCEDNNCHKG, List<T> NLANKBLAOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9010", Offset = "0x2BE7C10", VA = "0x182BE9010")]
	private int MOBMDCJCEJA(int CFJGKJHIILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2BE86A0", Offset = "0x2BE72A0", VA = "0x182BE86A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x12E6900", Offset = "0x12E5500", VA = "0x1812E6900", Slot = "4")]
	protected override Vector3 AHFJOCGODJH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1FA15F0", Offset = "0x1FA01F0", VA = "0x181FA15F0", Slot = "5")]
	protected override Vector3 GAIKGPLFBOK(Vector3 EOEOFNCKKHJ, Vector3 AOEAFBFCPPC, float NFOHJNABMAP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F12530", Offset = "0x6F11130", VA = "0x186F12530", Slot = "6")]
	protected override Vector3 BOIJDEBEJHH(Vector3 ECNGHFJBIJL, float NFOHJNABMAP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F12590", Offset = "0x6F11190", VA = "0x186F12590", Slot = "7")]
	protected override Vector3 GHONKFPHFFA(Vector3 EOEOFNCKKHJ, Vector3 AOEAFBFCPPC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F12610", Offset = "0x6F11210", VA = "0x186F12610", Slot = "8")]
	protected override Vector3 GIBLADJBOON(Vector3 EOEOFNCKKHJ, Vector3 AOEAFBFCPPC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F12680", Offset = "0x6F11280", VA = "0x186F12680")]
	public AEKEOHGLNID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GPEJKPPFPKA : global::FGGONGOBJMA<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F14550", Offset = "0x6F13150", VA = "0x186F14550")]
	public GPEJKPPFPKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F144E0", Offset = "0x6F130E0", VA = "0x186F144E0")]
	public GPEJKPPFPKA(int GEFPLPIBMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xC95DA0", Offset = "0xC949A0", VA = "0x180C95DA0", Slot = "4")]
	protected override float AHFJOCGODJH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3BA0020", Offset = "0x3B9EC20", VA = "0x183BA0020", Slot = "5")]
	protected override float GAIKGPLFBOK(float EOEOFNCKKHJ, float AOEAFBFCPPC, float NFOHJNABMAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x59DED10", Offset = "0x59DD910", VA = "0x1859DED10", Slot = "6")]
	protected override float BOIJDEBEJHH(float ECNGHFJBIJL, float NFOHJNABMAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F144C0", Offset = "0x6F130C0", VA = "0x186F144C0", Slot = "7")]
	protected override float GHONKFPHFFA(float EOEOFNCKKHJ, float AOEAFBFCPPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F144D0", Offset = "0x6F130D0", VA = "0x186F144D0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public KIGJBHHMGOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ILMMOMFFIAJ : global::ODDMALFOGNH<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F14D50", Offset = "0x6F13950", VA = "0x186F14D50")]
	public ILMMOMFFIAJ(int CABFJBCMJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F14DA0", Offset = "0x6F139A0", VA = "0x186F14DA0")]
	public ILMMOMFFIAJ(LJBOMMPGMCM[] LMHLDELFGFA, bool BFBLJDNFJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F14CE0", Offset = "0x6F138E0", VA = "0x186F14CE0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x353DD80", Offset = "0x353C980", VA = "0x18353DD80")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x353DDA0", Offset = "0x353C9A0", VA = "0x18353DDA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xAF3280", Offset = "0xAF1E80", VA = "0x180AF3280")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
		public BDNJBAEGAII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x27B0640", Offset = "0x27AF240", VA = "0x1827B0640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
		public AOJFJKEBMGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x383F9F0", Offset = "0x383E5F0", VA = "0x18383F9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x383E150", Offset = "0x383CD50", VA = "0x18383E150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x383E210", Offset = "0x383CE10", VA = "0x18383E210")]
	public AMPEKBKFHNB(in T GIFKGKNAFME, int AOMOMCDDNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x383E2B0", Offset = "0x383CEB0", VA = "0x18383E2B0")]
	public AMPEKBKFHNB(in T GIFKGKNAFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x383DA10", Offset = "0x383C610", VA = "0x18383DA10")]
	public EOLEDHHFLLG DJCIPMFGKEI()
	{
		return default(EOLEDHHFLLG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x383D9D0", Offset = "0x383C5D0", VA = "0x18383D9D0")]
	public EOLEDHHFLLG DJCIPMFGKEI(CancellationToken GFFFFCALMCA)
	{
		return default(EOLEDHHFLLG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x383DDD0", Offset = "0x383C9D0", VA = "0x18383DDD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::AMPEKBKFHNB<>.BDNJBAEGAII))]
	public Task<EOLEDHHFLLG> KPABIKOBAPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x383DC00", Offset = "0x383C800", VA = "0x18383DC00")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F13E70", Offset = "0x6F12A70", VA = "0x186F13E70")]
	public static global::AMPEKBKFHNB<DPIJIKFEAOC> DOBPLOGGNLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F13E00", Offset = "0x6F12A00", VA = "0x186F13E00")]
	public static global::AMPEKBKFHNB<DPIJIKFEAOC> DOBPLOGGNLM(int AOMOMCDDNBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2058240", Offset = "0x2056E40", VA = "0x182058240")]
	public static global::AMPEKBKFHNB<T> DOBPLOGGNLM<T>(in T GIFKGKNAFME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x235A6B0", Offset = "0x23592B0", VA = "0x18235A6B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x954D50", Offset = "0x953950", VA = "0x180954D50", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x30C9290", Offset = "0x30C7E90", VA = "0x1830C9290", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x30CBB10", Offset = "0x30CA710", VA = "0x1830CBB10")]
		public Enumerator(global::PGDLNHIILLB<T> NLANKBLAOCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x30C6C30", Offset = "0x30C5830", VA = "0x1830C6C30", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x30C8170", Offset = "0x30C6D70", VA = "0x1830C8170", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x30C4EC0", Offset = "0x30C3AC0", VA = "0x1830C4EC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E096F0", Offset = "0x3E082F0", VA = "0x183E096F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3E080D0", Offset = "0x3E06CD0", VA = "0x183E080D0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3E08300", Offset = "0x3E06F00", VA = "0x183E08300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3E09CA0", Offset = "0x3E088A0", VA = "0x183E09CA0")]
	public PGDLNHIILLB(int CABFJBCMJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3E07D60", Offset = "0x3E06960", VA = "0x183E07D60")]
	public void CAILCKFFJIK(T NFOHJNABMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3E08E20", Offset = "0x3E07A20", VA = "0x183E08E20")]
	public void MIEPPGEFOLJ(IEnumerable<T> OMCHMPJJNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3E08050", Offset = "0x3E06C50", VA = "0x183E08050")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3E08970", Offset = "0x3E07570", VA = "0x183E08970")]
	public void LENIFPHCDAG(int FGHOJPFDCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3E081F0", Offset = "0x3E06DF0", VA = "0x183E081F0")]
	public void GECMALKHHPP(int FGHOJPFDCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3E085B0", Offset = "0x3E071B0", VA = "0x183E085B0")]
	public void IMKOGLOMGAJ(T[] EABDNHJFDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3E08A00", Offset = "0x3E07600", VA = "0x183E08A00")]
	public Enumerator MEOEHOBEEMI()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3E09C20", Offset = "0x3E08820", VA = "0x183E09C20", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3E09C20", Offset = "0x3E08820", VA = "0x183E09C20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3E09910", Offset = "0x3E08510", VA = "0x183E09910")]
	private int OBAPAMDGAKF(int NHHNPPKPBIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3E09AF0", Offset = "0x3E086F0", VA = "0x183E09AF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E05EB0", Offset = "0x3E04AB0", VA = "0x183E05EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3E06030", Offset = "0x3E04C30", VA = "0x183E06030")]
	protected PEMOMEOLKEJ(bool CICPIOFKENJ, bool IHLCILHELIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3E05FB0", Offset = "0x3E04BB0", VA = "0x183E05FB0")]
	protected bool KNGMDNHCGFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3E05EF0", Offset = "0x3E04AF0", VA = "0x183E05EF0")]
	protected void KBBPAIDBMGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3E05940", Offset = "0x3E04540", VA = "0x183E05940")]
	protected void ABDCADBEJBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x347FD50", Offset = "0x347E950", VA = "0x18347FD50")]
	private static void OGPPOMJFBOH<U>(ref List<U> IFADMANLNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3E05AF0", Offset = "0x3E046F0", VA = "0x183E05AF0", Slot = "5")]
	public void CAILCKFFJIK(T FOGMDOMFJBB, bool AKPODJDOLHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3E05C50", Offset = "0x3E04850", VA = "0x183E05C50", Slot = "6")]
	public void CPPHPNNFPKL(T FOGMDOMFJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3E05DA0", Offset = "0x3E049A0", VA = "0x183E05DA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F151E0", Offset = "0x6F13DE0", VA = "0x186F151E0")]
	public KBJOPGEOOCH(bool CICPIOFKENJ = false, bool IHLCILHELIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6F14F10", Offset = "0x6F13B10", VA = "0x186F14F10")]
	public void MKOHINBGHOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F15110", Offset = "0x6F13D10", VA = "0x186F15110", Slot = "4")]
	public override void NACLKOJNEAO(object[] PFFFGKKOEPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F15180", Offset = "0x6F13D80", VA = "0x186F15180")]
	public static KBJOPGEOOCH OGNHPCPAOIL(KBJOPGEOOCH GJLGCDFBOPB, Action FOGMDOMFJBB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F14EB0", Offset = "0x6F13AB0", VA = "0x186F14EB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2888DC0", Offset = "0x28879C0", VA = "0x182888DC0")]
	public NAOGJOJMPFD(bool CICPIOFKENJ = false, bool IHLCILHELIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x28863F0", Offset = "0x2884FF0", VA = "0x1828863F0")]
	public void MKOHINBGHOB(T NFOHJNABMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2936A70", Offset = "0x2935670", VA = "0x182936A70", Slot = "4")]
	public override void NACLKOJNEAO(object[] PFFFGKKOEPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2888D20", Offset = "0x2887920", VA = "0x182888D20")]
	public static global::NAOGJOJMPFD<T> OGNHPCPAOIL(global::NAOGJOJMPFD<T> GJLGCDFBOPB, Action<T> FOGMDOMFJBB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2885A30", Offset = "0x2884630", VA = "0x182885A30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2888DC0", Offset = "0x28879C0", VA = "0x182888DC0")]
	public HJMCHKIHGED(bool CICPIOFKENJ = false, bool IHLCILHELIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2EB6940", Offset = "0x2EB5540", VA = "0x182EB6940")]
	public void MKOHINBGHOB(T NFOHJNABMAP, U CFKHIDLOGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2EB9660", Offset = "0x2EB8260", VA = "0x182EB9660", Slot = "4")]
	public override void NACLKOJNEAO(object[] PFFFGKKOEPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2EBB500", Offset = "0x2EBA100", VA = "0x182EBB500")]
	public static global::HJMCHKIHGED<T, U> OGNHPCPAOIL(global::HJMCHKIHGED<T, U> GJLGCDFBOPB, Action<T, U> FOGMDOMFJBB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2EB5880", Offset = "0x2EB4480", VA = "0x182EB5880")]
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
	[Cpp2IlInjected.Address(RVA = "0x2888DC0", Offset = "0x28879C0", VA = "0x182888DC0")]
	public KJIOPDDOALH(bool CICPIOFKENJ = false, bool IHLCILHELIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2C1DAA0", Offset = "0x2C1C6A0", VA = "0x182C1DAA0")]
	public void MKOHINBGHOB(T NFOHJNABMAP, U CFKHIDLOGCG, V KNLEJKEBOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2C1F4F0", Offset = "0x2C1E0F0", VA = "0x182C1F4F0", Slot = "4")]
	public override void NACLKOJNEAO(object[] PFFFGKKOEPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2C20E80", Offset = "0x2C1FA80", VA = "0x182C20E80")]
	public static global::KJIOPDDOALH<T, U, V> OGNHPCPAOIL(global::KJIOPDDOALH<T, U, V> GJLGCDFBOPB, Action<T, U, V> FOGMDOMFJBB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2C1CFA0", Offset = "0x2C1BBA0", VA = "0x182C1CFA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2888DC0", Offset = "0x28879C0", VA = "0x182888DC0")]
	public KBBANGGGBBP(bool CICPIOFKENJ = false, bool IHLCILHELIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3189B40", Offset = "0x3188740", VA = "0x183189B40")]
	public void MKOHINBGHOB(T NFOHJNABMAP, U CFKHIDLOGCG, V KNLEJKEBOMM, W OJBIOMHAGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x318AB10", Offset = "0x3189710", VA = "0x18318AB10", Slot = "4")]
	public override void NACLKOJNEAO(object[] PFFFGKKOEPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2C0EB70", Offset = "0x2C0D770", VA = "0x182C0EB70")]
	public static global::KBBANGGGBBP<T, U, V, W> OGNHPCPAOIL(global::KBBANGGGBBP<T, U, V, W> GJLGCDFBOPB, Action<T, U, V, W> FOGMDOMFJBB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2C0D620", Offset = "0x2C0C220", VA = "0x182C0D620")]
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
	[Cpp2IlInjected.Address(RVA = "0x2888DC0", Offset = "0x28879C0", VA = "0x182888DC0")]
	public KPGINHGLGBA(bool CICPIOFKENJ = false, bool IHLCILHELIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4368220", Offset = "0x4366E20", VA = "0x184368220")]
	public void MKOHINBGHOB(T NFOHJNABMAP, U CFKHIDLOGCG, V KNLEJKEBOMM, W OJBIOMHAGBL, X OLGJDFCIILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x43684B0", Offset = "0x43670B0", VA = "0x1843684B0", Slot = "4")]
	public override void NACLKOJNEAO(object[] PFFFGKKOEPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4368AC0", Offset = "0x43676C0", VA = "0x184368AC0")]
	public static global::KPGINHGLGBA<T, U, V, W, X> OGNHPCPAOIL(global::KPGINHGLGBA<T, U, V, W, X> GJLGCDFBOPB, Action<T, U, V, W, X> FOGMDOMFJBB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4367E50", Offset = "0x4366A50", VA = "0x184367E50")]
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
	[Cpp2IlInjected.Address(RVA = "0x2888DC0", Offset = "0x28879C0", VA = "0x182888DC0")]
	public CDNDLCKKIIJ(bool CICPIOFKENJ = false, bool IHLCILHELIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x33DDE60", Offset = "0x33DCA60", VA = "0x1833DDE60")]
	public void MKOHINBGHOB(T NFOHJNABMAP, U CFKHIDLOGCG, V KNLEJKEBOMM, W OJBIOMHAGBL, X OLGJDFCIILF, Y IKFJLOPMKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x33DE490", Offset = "0x33DD090", VA = "0x1833DE490", Slot = "4")]
	public override void NACLKOJNEAO(object[] PFFFGKKOEPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x33DEB20", Offset = "0x33DD720", VA = "0x1833DEB20")]
	public static global::CDNDLCKKIIJ<T, U, V, W, X, Y> OGNHPCPAOIL(global::CDNDLCKKIIJ<T, U, V, W, X, Y> GJLGCDFBOPB, Action<T, U, V, W, X, Y> FOGMDOMFJBB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x33DD7F0", Offset = "0x33DC3F0", VA = "0x1833DD7F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
		public HNFDGCGAFAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x30CDE80", Offset = "0x30CCA80", VA = "0x1830CDE80")]
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
	[Cpp2IlInjected.Address(RVA = "0xF621E0", Offset = "0xF60DE0", VA = "0x180F621E0")]
	private PBHEEDKBLDK(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> MLICDOOHGLO, int BFEDDGBJLGL, int NLBBJHJNDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3DF74D0", Offset = "0x3DF60D0", VA = "0x183DF74D0")]
	public static global::PBHEEDKBLDK<T> DOBPLOGGNLM()
	{
		return default(global::PBHEEDKBLDK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3DF5F10", Offset = "0x3DF4B10", VA = "0x183DF5F10")]
	public (int, int, Task<T>) DFFBOIKCNMM(int JIKEGDDBPDP, [Optional] CancellationToken GFFFFCALMCA, double JJEEOOEDFIC = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3DF75C0", Offset = "0x3DF61C0", VA = "0x183DF75C0")]
	public void IMNICMNPGDG(int JIKEGDDBPDP, int NLBBJHJNDIP, in T IIMBBHEIGGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class ENAPBGFAADC
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6F14120", Offset = "0x6F12D20", VA = "0x186F14120")]
	public static global::PBHEEDKBLDK<DPIJIKFEAOC> DOBPLOGGNLM()
	{
		return default(global::PBHEEDKBLDK<DPIJIKFEAOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6F14170", Offset = "0x6F12D70", VA = "0x186F14170")]
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
		[Cpp2IlInjected.Address(RVA = "0x1A0C630", Offset = "0x1A0B230", VA = "0x181A0C630", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool JKOPFKMGHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public ICollection<TKey> NJNAPAHAGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2AED9D0", Offset = "0x2AEC5D0", VA = "0x182AED9D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ICollection<TVal> OCFAGHJFNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2E702A0", Offset = "0x2E6EEA0", VA = "0x182E702A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public TVal OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2E70260", Offset = "0x2E6EE60", VA = "0x182E70260", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2E702D0", Offset = "0x2E6EED0", VA = "0x182E702D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TKey OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2E6F300", Offset = "0x2E6DF00", VA = "0x182E6F300")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2E6F5C0", Offset = "0x2E6E1C0", VA = "0x182E6F5C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F180", Offset = "0x2E6DD80", VA = "0x182E6F180", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2E70100", Offset = "0x2E6ED00", VA = "0x182E70100", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x2E6EF00", Offset = "0x2E6DB00", VA = "0x182E6EF00", Slot = "9")]
	public void Add(TKey BDFCACLHAFA, TVal ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2E6EE90", Offset = "0x2E6DA90", VA = "0x182E6EE90", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> FHJBBMIILLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F1E0", Offset = "0x2E6DDE0", VA = "0x182E6F1E0", Slot = "8")]
	public bool ContainsKey(TKey BDFCACLHAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F210", Offset = "0x2E6DE10", VA = "0x182E6F210", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2E6FFD0", Offset = "0x2E6EBD0", VA = "0x182E6FFD0", Slot = "10")]
	public bool Remove(TKey BDFCACLHAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2E70030", Offset = "0x2E6EC30", VA = "0x182E70030", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x27BB910", Offset = "0x27BA510", VA = "0x1827BB910", Slot = "11")]
	public bool TryGetValue(TKey BDFCACLHAFA, out TVal ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F500", Offset = "0x2E6E100", VA = "0x182E6F500", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F2A0", Offset = "0x2E6DEA0", VA = "0x182E6F2A0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] EABDNHJFDCB, int KHLMLDANMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2E6EF70", Offset = "0x2E6DB70", VA = "0x182E6EF70")]
	public void CAILCKFFJIK(TVal FOHLJCNEPNC, TKey BDFCACLHAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2E6EFB0", Offset = "0x2E6DBB0", VA = "0x182E6EFB0")]
	public void CAILCKFFJIK(KeyValuePair<TVal, TKey> FHJBBMIILLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2E6FAE0", Offset = "0x2E6E6E0", VA = "0x182E6FAE0")]
	public bool PBFMMEHNOBJ(TVal BDFCACLHAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2E6FA70", Offset = "0x2E6E670", VA = "0x182E6FA70")]
	public bool ODOLPHCGINH(KeyValuePair<TVal, TKey> FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F110", Offset = "0x2E6DD10", VA = "0x182E6F110")]
	public bool CPPHPNNFPKL(TVal BDFCACLHAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F110", Offset = "0x2E6DD10", VA = "0x182E6F110")]
	public bool CPPHPNNFPKL(KeyValuePair<TVal, TKey> FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F7F0", Offset = "0x2E6E3F0", VA = "0x182E6F7F0")]
	public bool KFBGNHHGLGM(TVal BDFCACLHAFA, out TKey ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F3F0", Offset = "0x2E6DFF0", VA = "0x182E6F3F0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> FOPHCKACLHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F750", Offset = "0x2E6E350", VA = "0x182E6F750")]
	private void HMAODFLOOLI(TKey BDFCACLHAFA, TVal FOHLJCNEPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F860", Offset = "0x2E6E460", VA = "0x182E6F860")]
	private void MCIJLJCKBNK(TKey BDFCACLHAFA, TVal FOHLJCNEPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2E6FB20", Offset = "0x2E6E720", VA = "0x182E6FB20")]
	private bool PLKEILCEGJN(TKey BDFCACLHAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x2E6FD70", Offset = "0x2E6E970", VA = "0x182E6FD70")]
	private bool PLKEILCEGJN(TVal FOHLJCNEPNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2E70150", Offset = "0x2E6ED50", VA = "0x182E70150")]
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
		[Cpp2IlInjected.Address(RVA = "0x8370C0", Offset = "0x835CC0", VA = "0x1808370C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8370D0", Offset = "0x835CD0", VA = "0x1808370D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool JKOPFKMGHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9ABC90", Offset = "0x9AA890", VA = "0x1809ABC90", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x974F20", Offset = "0x973B20", VA = "0x180974F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public External OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3FFDB60", Offset = "0x3FFC760", VA = "0x183FFDB60", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3FFDC00", Offset = "0x3FFC800", VA = "0x183FFDC00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3FFDB00", Offset = "0x3FFC700", VA = "0x183FFDB00", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3E06850", Offset = "0x3E05450", VA = "0x183E06850")]
	public HEKPBOBAIDI(Func<Internal, External> OOFAJPBIDBP, Func<External, Internal> HHEDOLCCPGA, bool INCMGOFNCLP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3FFD820", Offset = "0x3FFC420", VA = "0x183FFD820", Slot = "6")]
	public int IndexOf(External FHJBBMIILLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3FFD4A0", Offset = "0x3FFC0A0", VA = "0x183FFD4A0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3FFD500", Offset = "0x3FFC100", VA = "0x183FFD500", Slot = "13")]
	public bool Contains(External FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3FFD590", Offset = "0x3FFC190", VA = "0x183FFD590", Slot = "14")]
	public void CopyTo(External[] EABDNHJFDCB, int KHLMLDANMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3FFD3B0", Offset = "0x3FFBFB0", VA = "0x183FFD3B0", Slot = "11")]
	public void Add(External FHJBBMIILLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3FFD910", Offset = "0x3FFC510", VA = "0x183FFD910", Slot = "7")]
	public void Insert(int NHHNPPKPBIA, External FHJBBMIILLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3FFDA70", Offset = "0x3FFC670", VA = "0x183FFDA70", Slot = "15")]
	public bool Remove(External FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3FFD9B0", Offset = "0x3FFC5B0", VA = "0x183FFD9B0", Slot = "8")]
	public void RemoveAt(int NHHNPPKPBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3FFD7B0", Offset = "0x3FFC3B0", VA = "0x183FFD7B0", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x27C0ED0", Offset = "0x27BFAD0", VA = "0x1827C0ED0", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7F3030", Offset = "0x7F1C30", VA = "0x1807F3030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool JKOPFKMGHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D00", Offset = "0x7F1900", VA = "0x1807F2D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public External OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2C11D00", Offset = "0x2C10900", VA = "0x182C11D00", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2C11CA0", Offset = "0x2C108A0", VA = "0x182C11CA0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x1A0C660", Offset = "0x1A0B260", VA = "0x181A0C660")]
	public KEEHLMDHALL(Func<Internal, External> OOFAJPBIDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2C11C50", Offset = "0x2C10850", VA = "0x182C11C50")]
	public KEEHLMDHALL(IReadOnlyList<Internal> IFADMANLNLG, Func<Internal, External> OOFAJPBIDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2C11A30", Offset = "0x2C10630", VA = "0x182C11A30")]
	public void IMKOGLOMGAJ(External[] EABDNHJFDCB, int KHLMLDANMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2C11960", Offset = "0x2C10560", VA = "0x182C11960", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x1A0B7D0", Offset = "0x1A0A3D0", VA = "0x181A0B7D0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x857190", Offset = "0x855D90", VA = "0x180857190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool JKOPFKMGHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D00", Offset = "0x7F1900", VA = "0x1807F2D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public External OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3FEE730", Offset = "0x3FED330", VA = "0x183FEE730", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3FEE6D0", Offset = "0x3FED2D0", VA = "0x183FEE6D0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1A0C660", Offset = "0x1A0B260", VA = "0x181A0C660")]
	public HBPOIIBKJNC(IReadOnlyList<Internal> IFADMANLNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3FEE630", Offset = "0x3FED230", VA = "0x183FEE630")]
	public bool ODOLPHCGINH(External FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3FEE400", Offset = "0x3FED000", VA = "0x183FEE400")]
	public void IMKOGLOMGAJ(External[] EABDNHJFDCB, int KHLMLDANMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3FEE390", Offset = "0x3FECF90", VA = "0x183FEE390", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x27C0ED0", Offset = "0x27BFAD0", VA = "0x1827C0ED0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x30D61D0", Offset = "0x30D4DD0", VA = "0x1830D61D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan BIMGNANIFOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x30D62B0", Offset = "0x30D4EB0", VA = "0x1830D62B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x31C4F50", Offset = "0x31C3B50", VA = "0x1831C4F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
		public DHNGFCJGIIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x1A0C630", Offset = "0x1A0B230", VA = "0x181A0C630")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
		public NGJPMDHDFBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2898F70", Offset = "0x2897B70", VA = "0x182898F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
		public PIBCCICFIOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3A84940", Offset = "0x3A83540", VA = "0x183A84940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3524320", Offset = "0x3522F20", VA = "0x183524320")]
	public EKFJNFEBJEA(BGAJEDKKFII BGBEHENHJEK, [Optional] JGDMBLEFKKE DKMEANFNLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3522620", Offset = "0x3521220", VA = "0x183522620")]
	public Task<TResult> AIDOFGLCCHD(TRequest PAJPFFIMEFB, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3523CE0", Offset = "0x35228E0", VA = "0x183523CE0")]
	private void KHEGKMJBODH(ONIOPFMHMPC FIPDHKGPCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3524010", Offset = "0x3522C10", VA = "0x183524010")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::EKFJNFEBJEA<, >.NGJPMDHDFBE))]
	private Task LGMAMEGNNDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3523670", Offset = "0x3522270", VA = "0x183523670")]
	private ONIOPFMHMPC GJLDCBJIJID()
	{
		return default(ONIOPFMHMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3522D30", Offset = "0x3521930", VA = "0x183522D30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::EKFJNFEBJEA<, >.PIBCCICFIOC))]
	private Task CANCAKFOEIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3523120", Offset = "0x3521D20", VA = "0x183523120")]
	private void CMLPNALAHKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x35233C0", Offset = "0x3521FC0", VA = "0x1835233C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xAA8F80", Offset = "0xAA7B80", VA = "0x180AA8F80", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1B9E6F0", Offset = "0x1B9D2F0", VA = "0x181B9E6F0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool PNJODNOGGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x9862F0", Offset = "0x984EF0", VA = "0x1809862F0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string DFFLLHDOFCE
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA77C30", Offset = "0xA76830", VA = "0x180A77C30", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x14EF6D0", Offset = "0x14EE2D0", VA = "0x1814EF6D0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x341A190", Offset = "0x3418D90", VA = "0x18341A190")]
	private void MNBHKBFFHBK(T MEKBNGFFPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x341A090", Offset = "0x3418C90", VA = "0x18341A090")]
	private void LCADPBBFAGG(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x341A230", Offset = "0x3418E30", VA = "0x18341A230")]
	public void NHGHFKAFNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x341A140", Offset = "0x3418D40", VA = "0x18341A140", Slot = "6")]
	public global::AACICHIEKPH<T> LIFJBAKHMEG(Action<T, T> FOOMJEJICME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3419FA0", Offset = "0x3418BA0", VA = "0x183419FA0", Slot = "7")]
	public global::AACICHIEKPH<T> ENLLKKOMPDO(Action<T, T> FOOMJEJICME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x341A2E0", Offset = "0x3418EE0", VA = "0x18341A2E0", Slot = "4")]
	public global::AACICHIEKPH<T> OPNLGLFHHJA(Action<T> FOOMJEJICME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3419F50", Offset = "0x3418B50", VA = "0x183419F50", Slot = "5")]
	public global::AACICHIEKPH<T> CEDGGHAFJKO(Action<T> EJHEMANGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3419FF0", Offset = "0x3418BF0", VA = "0x183419FF0", Slot = "8")]
	public global::AACICHIEKPH<T> GFAGJPBHKLG(Action<string> LKICEHJCLKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3419EE0", Offset = "0x3418AE0", VA = "0x183419EE0", Slot = "9")]
	public global::AACICHIEKPH<T> APPBPNLCCGB(Action<string> LKICEHJCLKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x341A370", Offset = "0x3418F70", VA = "0x18341A370")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
		public APGBOGNLDIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x383FDB0", Offset = "0x383E9B0", VA = "0x18383FDB0")]
		internal void GLMMHMOIHJG(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x202AD10", Offset = "0x2029910", VA = "0x18202AD10")]
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
			[Cpp2IlInjected.Address(RVA = "0x39C45F0", Offset = "0x39C31F0", VA = "0x1839C45F0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6E92210", Offset = "0x6E90E10", VA = "0x186E92210")]
		public SerializedGuid(in Guid PCFHAIHNKAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F18E80", Offset = "0x6F17A80", VA = "0x186F18E80")]
		public static SerializedGuid OFDHHOGOACB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F18DF0", Offset = "0x6F179F0", VA = "0x186F18DF0")]
		public static SerializedGuid JFNFONDAPFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F18F10", Offset = "0x6F17B10", VA = "0x186F18F10")]
		public bool OKHCPHKNICN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E921E0", Offset = "0x6E90DE0", VA = "0x186E921E0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F18FA0", Offset = "0x6F17BA0", VA = "0x186F18FA0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F18D60", Offset = "0x6F17960", VA = "0x186F18D60")]
		public bool FMOLALLCICL(in Guid PCFHAIHNKAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F18BD0", Offset = "0x6F177D0", VA = "0x186F18BD0", Slot = "7")]
		public bool Equals(SerializedGuid MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F18C80", Offset = "0x6F17880", VA = "0x186F18C80", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E92130", Offset = "0x6E90D30", VA = "0x186E92130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E91F70", Offset = "0x6E90B70", VA = "0x186E91F70", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F176A0", Offset = "0x6F162A0", VA = "0x186F176A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1A0C630", Offset = "0x1A0B230", VA = "0x181A0C630", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JKOPFKMGHEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7F0460", Offset = "0x7EF060", VA = "0x1807F0460", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public T OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2A92800", Offset = "0x2A91400", VA = "0x182A92800", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D019D0", Offset = "0x3D005D0", VA = "0x183D019D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3599010", Offset = "0x3597C10", VA = "0x183599010", Slot = "11")]
	public void Add(T FHJBBMIILLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3D014F0", Offset = "0x3D000F0", VA = "0x183D014F0")]
	public bool JCOHIHLGEAI(T FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3D017E0", Offset = "0x3D003E0", VA = "0x183D017E0", Slot = "15")]
	public bool Remove(T FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2891710", Offset = "0x2890310", VA = "0x182891710", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2E79B90", Offset = "0x2E78790", VA = "0x182E79B90", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3D01130", Offset = "0x3CFFD30", VA = "0x183D01130", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2C17690", Offset = "0x2C16290", VA = "0x182C17690", Slot = "13")]
	public bool Contains(T FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3D01190", Offset = "0x3CFFD90", VA = "0x183D01190", Slot = "14")]
	public void CopyTo(T[] EABDNHJFDCB, int KHLMLDANMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2E70230", Offset = "0x2E6EE30", VA = "0x182E70230", Slot = "6")]
	public int IndexOf(T FHJBBMIILLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x3D01430", Offset = "0x3D00030", VA = "0x183D01430", Slot = "7")]
	public void Insert(int NHHNPPKPBIA, T FHJBBMIILLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3D01640", Offset = "0x3D00240", VA = "0x183D01640", Slot = "8")]
	public void RemoveAt(int NHHNPPKPBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3D011C0", Offset = "0x3CFFDC0", VA = "0x183D011C0")]
	public void IHBIIKDAKOI(Predicate<T> LDNIBEBMKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x38F19A0", Offset = "0x38F05A0", VA = "0x1838F19A0")]
	public void HOIHKHFBLLG(Comparison<T> OBDHEPNLMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3D018F0", Offset = "0x3D004F0", VA = "0x183D018F0")]
	public JBEMIBHHCAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class NGNEDPOIMFM
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F16870", Offset = "0x6F15470", VA = "0x186F16870")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F17710", Offset = "0x6F16310", VA = "0x186F17710")]
	public PFLOOOBDIHA(Type HGBBHGHBLFE, string GHDKOMENMKC, bool FOBNDAAIBNH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class KNLEPHMPGDG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6F15320", Offset = "0x6F13F20", VA = "0x186F15320")]
	public KNLEPHMPGDG(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6F152A0", Offset = "0x6F13EA0", VA = "0x186F152A0")]
	public KNLEPHMPGDG(string DKIECHCHJFL, Exception NCFNHKNLKKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class CLDJFIHFHLI
{
	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6F13D70", Offset = "0x6F12970", VA = "0x186F13D70")]
	[NotNull]
	public static byte[] EKPELJIKGFA(this INPIODOCMAF EKNEHDJHLJF, byte[] IDKBGDBOHNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F13B30", Offset = "0x6F12730", VA = "0x186F13B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F13FD0", Offset = "0x6F12BD0", VA = "0x186F13FD0")]
		public DNMAGGAJLEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F13F70", Offset = "0x6F12B70", VA = "0x186F13F70", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3208800", Offset = "0x3207400", VA = "0x183208800")]
	[Conditional("UNITY_EDITOR")]
	private static void MBMMEKELBLE<T>(params T[] ENBMDODBPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F138E0", Offset = "0x6F124E0", VA = "0x186F138E0")]
	public static IDisposable PBCBAJOHDLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F12FD0", Offset = "0x6F11BD0", VA = "0x186F12FD0")]
	public static void GBHCEDAGLCB(this IncrementalHash ALNNPHJMFIL, [CanBeNull] GameObject ALBKEDBKENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3208730", Offset = "0x3207330", VA = "0x183208730")]
	public static void GBHCEDAGLCB<T>(this IncrementalHash ALNNPHJMFIL, [CanBeNull] T DPLEBJGMEDE) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x32086A0", Offset = "0x32072A0", VA = "0x1832086A0")]
	public static void FMMGOBKJECI<T>(this IncrementalHash ALNNPHJMFIL, [CanBeNull] T EKNEHDJHLJF) where T : INPIODOCMAF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3208AF0", Offset = "0x32076F0", VA = "0x183208AF0")]
	public static void NDNBOLDFGLE<T>(this IncrementalHash ALNNPHJMFIL, [CanBeNull] IList<T> CFBEPOFGJFK) where T : INPIODOCMAF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F130C0", Offset = "0x6F11CC0", VA = "0x186F130C0")]
	private static bool GCKEMAFCIAH([CanBeNull] INPIODOCMAF EKNEHDJHLJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F13980", Offset = "0x6F12580", VA = "0x186F13980")]
	public static void PMGHKCKLIBJ(this IncrementalHash DKKDLHLFHOF, [CanBeNull] string IHEIAPOCOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F135A0", Offset = "0x6F121A0", VA = "0x186F135A0")]
	public static void NMKMPNACABA(this IncrementalHash DKKDLHLFHOF, long AAACKIAOAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F131B0", Offset = "0x6F11DB0", VA = "0x186F131B0")]
	public static void IFMPIFADCCK(this IncrementalHash DKKDLHLFHOF, int CPOCCBGJOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F12980", Offset = "0x6F11580", VA = "0x186F12980")]
	public static void AFNDAMCPINI(this IncrementalHash DKKDLHLFHOF, short DLAMMDHENLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F13770", Offset = "0x6F12370", VA = "0x186F13770")]
	public static void OCIDBOPAICL(this IncrementalHash DKKDLHLFHOF, byte AOJNFIFCAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F12B50", Offset = "0x6F11750", VA = "0x186F12B50")]
	public static void BAIKMMKLGPJ(this IncrementalHash DKKDLHLFHOF, bool COGGBAODFBM, bool BDOIJAHLIIP = false, bool GHIKJHJAJPB = false, bool JDPFAHHEEFL = false, bool FMMJIPDCINK = false, bool IBKPNFDDOFP = false, bool MHOKCHELOKC = false, bool FLBPMBPBADC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x3208F50", Offset = "0x3207B50", VA = "0x183208F50")]
	public static void ODHKCPGHCOH<T>(this IncrementalHash DKKDLHLFHOF, T AMNNIMCNJDH) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F12D90", Offset = "0x6F11990", VA = "0x186F12D90")]
	public static void DFHBBDKPEKE(this IncrementalHash DKKDLHLFHOF, float GHHIHMFDJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F13150", Offset = "0x6F11D50", VA = "0x186F13150")]
	public static void HBJHNEMPALP(this IncrementalHash DKKDLHLFHOF, double JEHKHBEKMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F12F60", Offset = "0x6F11B60", VA = "0x186F12F60")]
	public static void FNOAJHGKFOB(this IncrementalHash DKKDLHLFHOF, ulong ADHLDIBIHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F13540", Offset = "0x6F12140", VA = "0x186F13540")]
	public static void JJCIOFHLIBI(this IncrementalHash DKKDLHLFHOF, uint LFNGHAPJAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F12D20", Offset = "0x6F11920", VA = "0x186F12D20")]
	public static void BMJLAHDIFEC(this IncrementalHash DKKDLHLFHOF, ushort BLNNHACDOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F12DF0", Offset = "0x6F119F0", VA = "0x186F12DF0")]
	public static void EABJBLKANBE(this IncrementalHash DKKDLHLFHOF, Vector3 IKBGLOMGGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F13380", Offset = "0x6F11F80", VA = "0x186F13380")]
	public static void JELCMHAHCCG(this IncrementalHash DKKDLHLFHOF, Quaternion IKJHPFLGHKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class HIGINMENPKE
{
	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F145C0", Offset = "0x6F131C0", VA = "0x186F145C0")]
	[NotNull]
	public static byte[] EKPELJIKGFA(this IEEAIAKPCEK OHIFKEKKGBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F14630", Offset = "0x6F13230", VA = "0x186F14630")]
	[NotNull]
	public static byte[] EKPELJIKGFA(this IEEAIAKPCEK OHIFKEKKGBE, HashAlgorithmName INMIEOBOCOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F14830", Offset = "0x6F13430", VA = "0x186F14830")]
	public static bool JLECPPEIGPM([CanBeNull] this IEEAIAKPCEK OHIFKEKKGBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F149C0", Offset = "0x6F135C0", VA = "0x186F149C0")]
	public static bool JLECPPEIGPM([CanBeNull] this IEEAIAKPCEK OHIFKEKKGBE, out string FKPBDLDGFCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F146A0", Offset = "0x6F132A0", VA = "0x186F146A0")]
	private static string GNELJCECGNF([CanBeNull] byte[] ENEAOCDMOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F14710", Offset = "0x6F13310", VA = "0x186F14710")]
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
			[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
			public <<-ctor>g__AwaitThenTransformTaskResult|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x2550C00", Offset = "0x254F800", VA = "0x182550C00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
		public CCIHNODDNIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x33DCAD0", Offset = "0x33DB6D0", VA = "0x1833DCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Task NMOONEGGGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public global::NBFPPJGKGOH<T> NFMMEGLCENH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B9E7E0", Offset = "0x1B9D3E0", VA = "0x181B9E7E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool JHFNJCFMCPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x9ABC90", Offset = "0x9AA890", VA = "0x1809ABC90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x31CBF50", Offset = "0x31CAB50", VA = "0x1831CBF50")]
	static OPMDLAPLJBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x31CC100", Offset = "0x31CAD00", VA = "0x1831CC100")]
	protected OPMDLAPLJBA(TTask GAKDIIFBLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x31CB990", Offset = "0x31CA590", VA = "0x1831CB990", Slot = "1")]
	~OPMDLAPLJBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x31CB960", Offset = "0x31CA560", VA = "0x1831CB960", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x31CBA00", Offset = "0x31CA600", VA = "0x1831CBA00")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F13DB0", Offset = "0x6F129B0", VA = "0x186F13DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1701F20", Offset = "0x1700B20", VA = "0x181701F20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public global::NBFPPJGKGOH<T> NFMMEGLCENH
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x14EF0D0", Offset = "0x14EDCD0", VA = "0x1814EF0D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x3A95A10", Offset = "0x3A94610", VA = "0x183A95A10")]
	public PLHBFOCCPAO(Exception KIEMAGPGLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F13AF0", Offset = "0x6F126F0", VA = "0x186F13AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1701F20", Offset = "0x1700B20", VA = "0x181701F20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public global::NBFPPJGKGOH<T> NFMMEGLCENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x14EF0D0", Offset = "0x14EDCD0", VA = "0x1814EF0D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x3DEE880", Offset = "0x3DED480", VA = "0x183DEE880")]
	public PBFOOBDDNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public IKCGLDBLFAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6F14C50", Offset = "0x6F13850", VA = "0x186F14C50")]
		internal void PKFOHKCNHGL(global::JAPPGKMKBNF<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6F12830", Offset = "0x6F11430", VA = "0x186F12830")]
	public BDPOMAKGMDN([Optional] string EKLNNMKJFJE, [Optional] int? FENNDHCJJPL, [Optional] Stopwatch NGBOPHHNHAL, [Optional] Action<string, AHBCFPPHHDO> MGOLJMIHAJI, [Optional] Action<string, AHBCFPPHHDO> ENMNJFPNDPE, [Optional] Action<BDPOMAKGMDN> PHAGACJHDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6F12750", Offset = "0x6F11350", VA = "0x186F12750")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
		public EMFBBFEBCMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x28CE2B0", Offset = "0x28CCEB0", VA = "0x1828CE2B0")]
		internal string EDJOIBDDLEL(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x3E09D40", Offset = "0x3E08940", VA = "0x183E09D40", Slot = "5")]
	protected override string KLFBMEGCMOO(global::JAPPGKMKBNF<TKey> IDIJCJCNEPO, HPMMNIDOMCP LGDBOJKCHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x2891930", Offset = "0x2890530", VA = "0x182891930")]
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
	[Cpp2IlInjected.Address(RVA = "0x2891C40", Offset = "0x2890840", VA = "0x182891C40")]
	private static string DHNMLCJPLHP(TKey BDFCACLHAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x2892680", Offset = "0x2891280", VA = "0x182892680")]
	public NDNNEJNANJD(string AGOMEPFMNMI = "F2", double ACMHMPFHEGL = double.MaxValue, bool MFMOBLBGILH = false, int OELNLLDOMIP = int.MaxValue, [Optional] ISet<string> IEKBODLLLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x2892420", Offset = "0x2891020", VA = "0x182892420", Slot = "4")]
	public override Dictionary<string, string> GBBAFINFGIO(global::JAPPGKMKBNF<TKey> IDIJCJCNEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x2891C80", Offset = "0x2890880", VA = "0x182891C80")]
	private bool DIOMMJEIOBB(string LPCDIMOBLNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x2891EE0", Offset = "0x2890AE0", VA = "0x182891EE0")]
	public Dictionary<string, string> GBBAFINFGIO(global::JAPPGKMKBNF<TKey> IDIJCJCNEPO, NIHJPELOJBN LGDBOJKCHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x28924D0", Offset = "0x28910D0", VA = "0x1828924D0")]
	private string ONJCLHAIGLE(StringBuilder IOBIMBJLCJB, List<TKey> PGEPAHPIDFO, NIHJPELOJBN LGDBOJKCHND, bool DKEIJDLIPDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2891D60", Offset = "0x2890960", VA = "0x182891D60")]
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
	[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
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
	[Cpp2IlInjected.Address(RVA = "0x36DBE00", Offset = "0x36DAA00", VA = "0x1836DBE00")]
	protected string JFHAPFGKJPB(double MBPEFNOIKNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x36DBBC0", Offset = "0x36DA7C0", VA = "0x1836DBBC0")]
	protected string EPAIEBGHBDC(int NBGDFKLHLOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x36DBB80", Offset = "0x36DA780", VA = "0x1836DBB80")]
	private static string DHNMLCJPLHP(TKey BDFCACLHAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x36DBD50", Offset = "0x36DA950", VA = "0x1836DBD50", Slot = "4")]
	public override string GBBAFINFGIO(global::JAPPGKMKBNF<TKey> IDIJCJCNEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x36DBC20", Offset = "0x36DA820", VA = "0x1836DBC20")]
	public string GBBAFINFGIO(global::JAPPGKMKBNF<TKey> IDIJCJCNEPO, [NotNull] HPMMNIDOMCP LGDBOJKCHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string KLFBMEGCMOO(global::JAPPGKMKBNF<TKey> IDIJCJCNEPO, [NotNull] HPMMNIDOMCP LGDBOJKCHND);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x27C0ED0", Offset = "0x27BFAD0", VA = "0x1827C0ED0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F141F0", Offset = "0x6F12DF0", VA = "0x186F141F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F14250", Offset = "0x6F12E50", VA = "0x186F14250", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public override float LGNCOMMFFDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x13ABBE0", Offset = "0x13AA7E0", VA = "0x1813ABBE0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6F14340", Offset = "0x6F12F40", VA = "0x186F14340")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F166E0", Offset = "0x6F152E0", VA = "0x186F166E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2EBF0C0", Offset = "0x2EBDCC0", VA = "0x182EBF0C0")]
	private HKFCPNLCEIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x2EBE0E0", Offset = "0x2EBCCE0", VA = "0x182EBE0E0", Slot = "5")]
	protected override string KLFBMEGCMOO(global::JAPPGKMKBNF<TKey> IDIJCJCNEPO, HPMMNIDOMCP LGDBOJKCHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2EBDFF0", Offset = "0x2EBCBF0", VA = "0x182EBDFF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x43847A0", Offset = "0x43833A0", VA = "0x1843847A0")]
		public AHBCFPPHHDO(long BAHOEHOOJGF, int FENNDHCJJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x4384770", Offset = "0x4383370", VA = "0x184384770")]
		public AHBCFPPHHDO(long BAHOEHOOJGF, long NHIEONFMGLD, int FENNDHCJJPL, int APIDBNJMOJD, bool HONBDECDNIP, string HOEMMCAKAAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x43846D0", Offset = "0x43832D0", VA = "0x1843846D0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void ONMAAIJMEKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x4384680", Offset = "0x4383280", VA = "0x184384680")]
		public int NFHAOHLLALE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x4384750", Offset = "0x4383350", VA = "0x184384750")]
		public int PMCLDDHPBCH(int OBNGPCHGBMF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x4384610", Offset = "0x4383210", VA = "0x184384610")]
		public double MLCGGBPAPHJ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x4384550", Offset = "0x4383150", VA = "0x184384550")]
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
			[Cpp2IlInjected.Address(RVA = "0x1A0C410", Offset = "0x1A0B010", VA = "0x181A0C410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x1A0BFD0", Offset = "0x1A0ABD0", VA = "0x181A0BFD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public IEnumerable<AALOEEPNEOP> GLGFKAIAEPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x4FFA4B0", Offset = "0x4FF90B0", VA = "0x184FFA4B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public AHBCFPPHHDO ICCFEAONLLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x1D30E80", Offset = "0x1D2FA80", VA = "0x181D30E80")]
			[CompilerGenerated]
			get
			{
				return default(AHBCFPPHHDO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x4FFA3A0", Offset = "0x4FF8FA0", VA = "0x184FFA3A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x4FFA4D0", Offset = "0x4FF90D0", VA = "0x184FFA4D0")]
		internal AALOEEPNEOP(global::JAPPGKMKBNF<TKey> IDIJCJCNEPO, TKey BDFCACLHAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x4FFA0E0", Offset = "0x4FF8CE0", VA = "0x184FFA0E0")]
		public AALOEEPNEOP AMICMCIKJKC(TKey BDFCACLHAFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x4FFA3D0", Offset = "0x4FF8FD0", VA = "0x184FFA3D0")]
		public void KMBKEDOPFCG(TKey BDFCACLHAFA, Action<AALOEEPNEOP> FOGMDOMFJBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x300C5F0", Offset = "0x300B1F0", VA = "0x18300C5F0")]
		public T KMBKEDOPFCG<T>(TKey BDFCACLHAFA, Func<AALOEEPNEOP, T> ELKBEDCOHFJ)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x300C470", Offset = "0x300B070", VA = "0x18300C470")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(LOADMBEPIJP))]
		public Task<T> JHEGKLHHLAN<T>(TKey BDFCACLHAFA, Func<AALOEEPNEOP, Task<T>> ELKBEDCOHFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x4FFA1F0", Offset = "0x4FF8DF0", VA = "0x184FFA1F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x28BF910", Offset = "0x28BE510", VA = "0x1828BF910", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x43937B0", Offset = "0x43923B0", VA = "0x1843937B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x28BFAA0", Offset = "0x28BE6A0", VA = "0x1828BFAA0")]
		[DebuggerHidden]
		public AKCOJPIOKAN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x27C0F40", Offset = "0x27BFB40", VA = "0x1827C0F40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x4393380", Offset = "0x4391F80", VA = "0x184393380", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x4393330", Offset = "0x4391F30", VA = "0x184393330")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x4393770", Offset = "0x4392370", VA = "0x184393770", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x43936B0", Offset = "0x43922B0", VA = "0x1843936B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, AHBCFPPHHDO)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x347D900", Offset = "0x347C500", VA = "0x18347D900", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x28BF910", Offset = "0x28BE510", VA = "0x1828BF910", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x28BF9B0", Offset = "0x28BE5B0", VA = "0x1828BF9B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x28BFAA0", Offset = "0x28BE6A0", VA = "0x1828BFAA0")]
		[DebuggerHidden]
		public GMDOKKMNAIF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x28BFA10", Offset = "0x28BE610", VA = "0x1828BFA10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x28BF1B0", Offset = "0x28BDDB0", VA = "0x1828BF1B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x28BF150", Offset = "0x28BDD50", VA = "0x1828BF150")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x28BF7D0", Offset = "0x28BE3D0", VA = "0x1828BF7D0")]
		private void NDPBPNJDDHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x28BF970", Offset = "0x28BE570", VA = "0x1828BF970", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x28BF830", Offset = "0x28BE430", VA = "0x1828BF830", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, AHBCFPPHHDO)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x28BF940", Offset = "0x28BE540", VA = "0x1828BF940", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F0240", Offset = "0x7EEE40", VA = "0x1807F0240")]
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
		[Cpp2IlInjected.Address(RVA = "0x836090", Offset = "0x834C90", VA = "0x180836090")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x3D00D60", Offset = "0x3CFF960", VA = "0x183D00D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public long JLABMGHGBPA
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x3D00DE0", Offset = "0x3CFF9E0", VA = "0x183D00DE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int PAMGGJEPCOH
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x3D00E00", Offset = "0x3CFFA00", VA = "0x183D00E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x3D00FB0", Offset = "0x3CFFBB0", VA = "0x183D00FB0")]
	public JAPPGKMKBNF(TKey DOFEACJBFLN, [Optional] int? FENNDHCJJPL, [Optional][CanBeNull] Stopwatch NGBOPHHNHAL, [Optional] Action<TKey, AHBCFPPHHDO> MGOLJMIHAJI, [Optional] Action<TKey, AHBCFPPHHDO> ENMNJFPNDPE, [Optional] Action<global::JAPPGKMKBNF<TKey>> PHAGACJHDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x3D00CD0", Offset = "0x3CFF8D0", VA = "0x183D00CD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x3D00F90", Offset = "0x3CFFB90", VA = "0x183D00F90")]
	public void NEDAAMABCNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x3D00DC0", Offset = "0x3CFF9C0", VA = "0x183D00DC0")]
	public void IKGIICDJABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x3D00F00", Offset = "0x3CFFB00", VA = "0x183D00F00")]
	[IteratorStateMachine(typeof(global::JAPPGKMKBNF<>.AKCOJPIOKAN))]
	public IEnumerable<(TKey, List<TKey>, AHBCFPPHHDO)> NCKIECPAKPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x3D00E30", Offset = "0x3CFFA30", VA = "0x183D00E30")]
	[IteratorStateMachine(typeof(global::JAPPGKMKBNF<>.GMDOKKMNAIF))]
	private IEnumerable<(TKey, List<TKey>, AHBCFPPHHDO)> NCKIECPAKPF(List<TKey> FMALCPACLGP, AALOEEPNEOP MPOFGPPJKDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x3D00C50", Offset = "0x3CFF850", VA = "0x183D00C50")]
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
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x857190", Offset = "0x855D90", VA = "0x180857190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector2 FIMHFHEPMJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x17B7480", Offset = "0x17B6080", VA = "0x1817B7480")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x880CF0", Offset = "0x87F8F0", VA = "0x180880CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector2 LMHJNKIBKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1A13180", Offset = "0x1A11D80", VA = "0x181A13180")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xABBE90", Offset = "0xABAA90", VA = "0x180ABBE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector2 EPFGMMNIBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6F16B40", Offset = "0x6F15740", VA = "0x186F16B40")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x10FD840", Offset = "0x10FC440", VA = "0x1810FD840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int APEIDHOMMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8360A0", Offset = "0x834CA0", VA = "0x1808360A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8B7BF0", Offset = "0x8B67F0", VA = "0x1808B7BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6F17240", Offset = "0x6F15E40", VA = "0x186F17240")]
	public NNDAHABCPBF(Bounds HPDFBJOLJPK, Vector2[] MEKPDIJBFHD, int DIGDPOPOLAN, byte GOGKDEGLBIL, float LPFICPPOAOL = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6F17080", Offset = "0x6F15C80", VA = "0x186F17080")]
	public MJLLOGCLAHK LFEINNEAFNP(byte NHHNPPKPBIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6F16B80", Offset = "0x6F15780", VA = "0x186F16B80")]
	public void ICCMCFLBNJE(Vector3 NABPHMOHNDG, float DDHPBADLENH, float JNFDEPAMMBN, ref List<byte> BEEKMCIHMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6F16B60", Offset = "0x6F15760", VA = "0x186F16B60")]
	public void FEHOKBLMJPE(MJLLOGCLAHK.KOILCJIOKNP KKIFBMFOGLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6F170E0", Offset = "0x6F15CE0", VA = "0x186F170E0")]
	private MJLLOGCLAHK PNPBOFGNLHL(byte NHHNPPKPBIA, MJLLOGCLAHK.OPMMNHJPGMG KDIGJFOIKJP, MJLLOGCLAHK ONIJEEBBCHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6F16C80", Offset = "0x6F15880", VA = "0x186F16C80")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F166C0", Offset = "0x6F152C0", VA = "0x186F166C0")]
	public MJLLOGCLAHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6F16660", Offset = "0x6F15260", VA = "0x186F16660")]
	public MJLLOGCLAHK(byte EDPPELMHBFA, OPMMNHJPGMG KDIGJFOIKJP, MJLLOGCLAHK ONIJEEBBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6F16320", Offset = "0x6F14F20", VA = "0x186F16320")]
	public void ANNGLPCKBKA(MJLLOGCLAHK PIKIEEICNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	public void FEHOKBLMJPE(int KBFDDKIHGJG, KOILCJIOKNP KKIFBMFOGLE, int HMAPHJEJDII = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6F163E0", Offset = "0x6F14FE0", VA = "0x186F163E0")]
	public void ICCMCFLBNJE(List<byte> BEEKMCIHMLL, Vector3 NABPHMOHNDG, float DDHPBADLENH, float JNFDEPAMMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6F162C0", Offset = "0x6F14EC0", VA = "0x186F162C0")]
	public bool ADHBNDPDEMC(Vector3 DBMHGAAIFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6F16620", Offset = "0x6F15220", VA = "0x186F16620")]
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
		[Cpp2IlInjected.Address(RVA = "0x1A0C410", Offset = "0x1A0B010", VA = "0x181A0C410")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int ANAACLAKIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x28BD340", Offset = "0x28BBF40", VA = "0x1828BD340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x3E04F90", Offset = "0x3E03B90", VA = "0x183E04F90")]
	public static global::PELPFEPHMAD<T> BAFOHBINEOF(int CABFJBCMJEP = 0, int MIFKLGGGFMB = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x3E05210", Offset = "0x3E03E10", VA = "0x183E05210")]
	public static global::PELPFEPHMAD<T> GGJPEOJFGOE(int CABFJBCMJEP = 0, int MIFKLGGGFMB = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x3E05900", Offset = "0x3E04500", VA = "0x183E05900")]
	public PELPFEPHMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x3E05770", Offset = "0x3E04370", VA = "0x183E05770")]
	public PELPFEPHMAD(int CABFJBCMJEP, int MIFKLGGGFMB = int.MaxValue, bool LENKKJLEHGG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x3E052E0", Offset = "0x3E03EE0", VA = "0x183E052E0")]
	public T HOMPIJPBAAK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x3E05170", Offset = "0x3E03D70", VA = "0x183E05170")]
	public void GCNLFMGFLMB(T ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x3E053F0", Offset = "0x3E03FF0", VA = "0x183E053F0")]
	private void JPPJPDMPFBO(T ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x3E05150", Offset = "0x3E03D50", VA = "0x183E05150")]
	private void FLIPLIMLBHB(T ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x3E05660", Offset = "0x3E04260", VA = "0x183E05660")]
	[Conditional("DEBUG_BUILD")]
	private void LIPHCFDHODM(T PECELBJIIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x3E056E0", Offset = "0x3E042E0", VA = "0x183E056E0")]
	[Conditional("DEBUG_BUILD")]
	private void NJPCOOFGIDN(T PECELBJIIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x3E05060", Offset = "0x3E03C60", VA = "0x183E05060", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x3E054C0", Offset = "0x3E040C0", VA = "0x183E054C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F15840", Offset = "0x6F14440", VA = "0x186F15840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool JBKFDKKFIGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F15400", Offset = "0x6F14000", VA = "0x186F15400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F16280", Offset = "0x6F14E80", VA = "0x186F16280")]
	public MENGMGNCHAD(bool DKEIPANPPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F159B0", Offset = "0x6F145B0", VA = "0x186F159B0")]
	public void MHGICPEJBKI(object HHNPCHNMLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F15910", Offset = "0x6F14510", VA = "0x186F15910")]
	public void LNLODCAJFHL(int ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F15900", Offset = "0x6F14500", VA = "0x186F15900")]
	public void KMFGLNICOCG(uint LMBKKGHKCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F160A0", Offset = "0x6F14CA0", VA = "0x186F160A0")]
	public void MNGIKHHHMNH(bool ICCLFAJGICJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F15850", Offset = "0x6F14450", VA = "0x186F15850")]
	public void HPKJALIKPBO(long EMIHEDBEOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F15780", Offset = "0x6F14380", VA = "0x186F15780")]
	public void EICJDPNCLCN(ulong PEMMBHLEMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F15890", Offset = "0x6F14490", VA = "0x186F15890")]
	public void KKOBPEEALOP(string EIJFOGFJFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F160C0", Offset = "0x6F14CC0", VA = "0x186F160C0")]
	public void MNLNBHNMAGF(Enum KIEMAGPGLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F16150", Offset = "0x6F14D50", VA = "0x186F16150")]
	public void NGCBDFBKNCC(IList IFADMANLNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x23477A0", Offset = "0x23463A0", VA = "0x1823477A0")]
	public void MNLMDMKNKPH<T, U>(Dictionary<T, U> HFKHBPEFOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F15410", Offset = "0x6F14010", VA = "0x186F15410")]
	private void DDCMKJDKNOK(IDictionary HFKHBPEFOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F157D0", Offset = "0x6F143D0", VA = "0x186F157D0")]
	public int GGAILEDDGEJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F16030", Offset = "0x6F14C30", VA = "0x186F16030")]
	public short MLFCMGHNNBG()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F157C0", Offset = "0x6F143C0", VA = "0x186F157C0")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F15390", Offset = "0x6F13F90", VA = "0x186F15390")]
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
		[Cpp2IlInjected.Address(RVA = "0x314AA30", Offset = "0x3149630", VA = "0x18314AA30", Slot = "4")]
		public virtual T EJDINAAHLDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
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
			[Cpp2IlInjected.Address(RVA = "0x14BB370", Offset = "0x14B9F70", VA = "0x1814BB370", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public LJBOMMPGMCM NIBFGHDNPCH
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x29B1730", Offset = "0x29B0330", VA = "0x1829B1730", Slot = "4")]
			get
			{
				return default(LJBOMMPGMCM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x83B600", Offset = "0x83A200", VA = "0x18083B600")]
		public PONHNNKFMCD(global::ODDMALFOGNH<T> GNJLJGGMKOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x29B16B0", Offset = "0x29B02B0", VA = "0x1829B16B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x83B5F0", Offset = "0x83A1F0", VA = "0x18083B5F0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xF50180", Offset = "0xF4ED80", VA = "0x180F50180", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x857DE0", Offset = "0x8569E0", VA = "0x180857DE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA82AD0", Offset = "0xA816D0", VA = "0x180A82AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x1A0C630", Offset = "0x1A0B230", VA = "0x181A0C630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x4906990", Offset = "0x4905590", VA = "0x184906990")]
	public ODDMALFOGNH(int CABFJBCMJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x4906A60", Offset = "0x4905660", VA = "0x184906A60")]
	public ODDMALFOGNH(LJBOMMPGMCM[] LMHLDELFGFA, bool BFBLJDNFJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x4905B40", Offset = "0x4904740", VA = "0x184905B40")]
	public int HKMEJEIBDMP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x49060C0", Offset = "0x4904CC0", VA = "0x1849060C0")]
	private int MCIKOHNCKFK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x49064E0", Offset = "0x49050E0", VA = "0x1849064E0", Slot = "6")]
	protected virtual uint NOOACFKFHCM(uint DKKDLHLFHOF, T ECNGHFJBIJL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x49056B0", Offset = "0x49042B0", VA = "0x1849056B0")]
	public bool EJCEIGEMLDE(T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x4906070", Offset = "0x4904C70", VA = "0x184906070")]
	public bool LKGBCPBLPKL(int NHHNPPKPBIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x49065B0", Offset = "0x49051B0", VA = "0x1849065B0")]
	public bool ODOLPHCGINH(Func<T, bool> GPMFMCCDAKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x4906690", Offset = "0x4905290", VA = "0x184906690")]
	public int OKNGNIBBBIN(T ECNGHFJBIJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x49057C0", Offset = "0x49043C0", VA = "0x1849057C0")]
	public T GCHGIFGBMBE(int NHHNPPKPBIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x49056F0", Offset = "0x49042F0", VA = "0x1849056F0")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x4905DB0", Offset = "0x49049B0", VA = "0x184905DB0")]
	public bool JCOHIHLGEAI(T ECNGHFJBIJL, bool MBBKNCOABPJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x4905DF0", Offset = "0x49049F0", VA = "0x184905DF0")]
	public bool JCOHIHLGEAI(T ECNGHFJBIJL, int NHHNPPKPBIA, bool MBBKNCOABPJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x4905620", Offset = "0x4904220", VA = "0x184905620")]
	public bool CPPHPNNFPKL(T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x4905770", Offset = "0x4904370", VA = "0x184905770")]
	public bool FLLDAADPLON(int NHHNPPKPBIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x4906740", Offset = "0x4905340", VA = "0x184906740")]
	private void PLKEILCEGJN(int NHHNPPKPBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x4905890", Offset = "0x4904490", VA = "0x184905890")]
	public LJBOMMPGMCM[] GMJCFHAOGEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x4905500", Offset = "0x4904100", VA = "0x184905500")]
	private int BNIANHFGIEL(int GOGKDEGLBIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x4906910", Offset = "0x4905510", VA = "0x184906910", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x4906910", Offset = "0x4905510", VA = "0x184906910", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F17860", Offset = "0x6F16460", VA = "0x186F17860")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x6F17AF0", Offset = "0x6F166F0", VA = "0x186F17AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x6F17A20", Offset = "0x6F16620", VA = "0x186F17A20")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x6F17C50", Offset = "0x6F16850", VA = "0x186F17C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x6F177D0", Offset = "0x6F163D0", VA = "0x186F177D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x6F17A60", Offset = "0x6F16660", VA = "0x186F17A60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x6F17990", Offset = "0x6F16590", VA = "0x186F17990")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x6F17770", Offset = "0x6F16370", VA = "0x186F17770")]
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
		[Cpp2IlInjected.Address(RVA = "0x1A0C410", Offset = "0x1A0B010", VA = "0x181A0C410")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T FGBCPLCCPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x3A841F0", Offset = "0x3A82DF0", VA = "0x183A841F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T IHFHFPJDIEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x3A84190", Offset = "0x3A82D90", VA = "0x183A84190")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T IEFOFNHJPJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x3A83E00", Offset = "0x3A82A00", VA = "0x183A83E00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x3A84300", Offset = "0x3A82F00", VA = "0x183A84300")]
	public PHHJDALPKOO(int CABFJBCMJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x3A83E60", Offset = "0x3A82A60", VA = "0x183A83E60")]
	public void CAILCKFFJIK(T PELNFFOMEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x3A84010", Offset = "0x3A82C10", VA = "0x183A84010")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x3A840B0", Offset = "0x3A82CB0", VA = "0x183A840B0")]
	public void LGIJHOHKAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x3A84060", Offset = "0x3A82C60", VA = "0x183A84060")]
	public void KAHJOMCPNBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x3A84050", Offset = "0x3A82C50", VA = "0x183A84050")]
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
			[Cpp2IlInjected.Address(RVA = "0xAEA540", Offset = "0xAE9140", VA = "0x180AEA540")]
			public AOIFHMHEOBD(List<Component> IFADMANLNLG, bool NIIBMIPCAIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x383F8A0", Offset = "0x383E4A0", VA = "0x18383F8A0")]
			public ILPKPLJCBEG<T> MEOEHOBEEMI()
			{
				return default(ILPKPLJCBEG<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x383F910", Offset = "0x383E510", VA = "0x18383F910", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x383F910", Offset = "0x383E510", VA = "0x18383F910", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x2B38220", Offset = "0x2B36E20", VA = "0x182B38220", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x2B381B0", Offset = "0x2B36DB0", VA = "0x182B381B0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B381F0", Offset = "0x2B36DF0", VA = "0x182B381F0")]
			public ILPKPLJCBEG(List<Component> IFADMANLNLG, bool NIIBMIPCAIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x2B380E0", Offset = "0x2B36CE0", VA = "0x182B380E0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x2B380F0", Offset = "0x2B36CF0", VA = "0x182B380F0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x1A0F870", Offset = "0x1A0E470", VA = "0x181A0F870", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F198F0", Offset = "0x6F184F0", VA = "0x186F198F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6F198B0", Offset = "0x6F184B0", VA = "0x186F198B0")]
		public ToolHierarchyCache(GameObject NBIMDBPEIEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F19640", Offset = "0x6F18240", VA = "0x186F19640")]
		private void PBAELFIBGFO(GameObject NBIMDBPEIEO, bool HCKNDFMIDDI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F197A0", Offset = "0x6F183A0", VA = "0x186F197A0")]
		public static void PBAELFIBGFO(GameObject NBIMDBPEIEO, ref ToolHierarchyCache LFMIPHMBPFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F19040", Offset = "0x6F17C40", VA = "0x186F19040")]
		public void ANPJJMKPGMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F194F0", Offset = "0x6F180F0", VA = "0x186F194F0")]
		public void GKIIAEKNGIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x2059D40", Offset = "0x2058940", VA = "0x182059D40")]
		public void EEAGIEBGMCO<T>(Action<T> FOGMDOMFJBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x6F19050", Offset = "0x6F17C50", VA = "0x186F19050")]
		public Component DCCFLCNADKN(Type FIJCKHKKDCC, bool NIIBMIPCAIP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x2059CC0", Offset = "0x20588C0", VA = "0x182059CC0")]
		public T DCCFLCNADKN<T>(bool NIIBMIPCAIP = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F195C0", Offset = "0x6F181C0", VA = "0x186F195C0")]
		public AOIFHMHEOBD<Component> KAFLFGBEGNK(Type FIJCKHKKDCC, bool NIIBMIPCAIP = false)
		{
			return default(AOIFHMHEOBD<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x2059FD0", Offset = "0x2058BD0", VA = "0x182059FD0")]
		public AOIFHMHEOBD<T> KAFLFGBEGNK<T>(bool NIIBMIPCAIP = false) where T : class
		{
			return default(AOIFHMHEOBD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F19120", Offset = "0x6F17D20", VA = "0x186F19120")]
		public List<Component> ECLFANLFHCP(Type FIJCKHKKDCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6F19470", Offset = "0x6F18070", VA = "0x186F19470", Slot = "4")]
		public bool Equals(ToolHierarchyCache OLGJDFCIILF, ToolHierarchyCache IKFJLOPMKHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6F19540", Offset = "0x6F18140", VA = "0x186F19540", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x945B70", Offset = "0x944770", VA = "0x180945B70", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x7F3030", Offset = "0x7F1C30", VA = "0x1807F3030", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool LKOPKHPHBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x31C8DE0", Offset = "0x31C79E0", VA = "0x1831C8DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x31C8BB0", Offset = "0x31C77B0", VA = "0x1831C8BB0")]
	public bool JKMEINBJGBN(T ECNGHFJBIJL, int KPEDMKNLCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x31C8A90", Offset = "0x31C7690", VA = "0x1831C8A90")]
	public bool CBLDDCBDCPG(int KPEDMKNLCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x31C8890", Offset = "0x31C7490", VA = "0x1831C8890")]
	public T BKLJFFBODNE(int ILGDIFFHGJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x31C8AF0", Offset = "0x31C76F0", VA = "0x1831C8AF0")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x31C8D50", Offset = "0x31C7950", VA = "0x1831C8D50")]
	private bool KOEJMAALIAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x31C8C10", Offset = "0x31C7810", VA = "0x1831C8C10")]
	public bool KFBGNHHGLGM(int KPEDMKNLCKL, out T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x31C8E20", Offset = "0x31C7A20", VA = "0x1831C8E20")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F0000", Offset = "0x7EEC00", VA = "0x1807F0000")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x7F0220", Offset = "0x7EEE20", VA = "0x1807F0220")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public T this[int OCIFJAIBHIA, int BJBICJAGAJI]
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x41C4BE0", Offset = "0x41C37E0", VA = "0x1841C4BE0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x41C4C80", Offset = "0x41C3880", VA = "0x1841C4C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x41C4B50", Offset = "0x41C3750", VA = "0x1841C4B50")]
		public Array2D(uint JJJHCGPEBDK, uint BABILIHBNMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x41C4AD0", Offset = "0x41C36D0", VA = "0x1841C4AD0")]
		public void ELJLHOEKJGC()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6F126F0", Offset = "0x6F112F0", VA = "0x186F126F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
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
		[Cpp2IlInjected.Address(RVA = "0x8620A0", Offset = "0x860CA0", VA = "0x1808620A0")]
		public JLILJGDKBBL(int KPEDMKNLCKL, TClaimant EGEEGBMEGLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x3508900", Offset = "0x3507500", VA = "0x183508900")]
		public bool GPEADCLPDIN(in JLILJGDKBBL MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x3508960", Offset = "0x3507560", VA = "0x183508960")]
		public bool KEJEEAFEICO(in JLILJGDKBBL MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x35088F0", Offset = "0x35074F0", VA = "0x1835088F0", Slot = "4")]
		public int CompareTo(JLILJGDKBBL MDHJAFNLPON)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x3508970", Offset = "0x3507570", VA = "0x183508970", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x27C0FA0", Offset = "0x27BFBA0", VA = "0x1827C0FA0")]
		[DebuggerHidden]
		public NPKDNEBFNHL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x3A41580", Offset = "0x3A40180", VA = "0x183A41580", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x3A41740", Offset = "0x3A40340", VA = "0x183A41740", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x3A41660", Offset = "0x3A40260", VA = "0x183A41660", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x1A04020", Offset = "0x1A02C20", VA = "0x181A04020", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3528870", Offset = "0x3527470", VA = "0x183528870")]
	public EKNDDHLLNAF(PELFGNAENHP JBENBACJFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x35279A0", Offset = "0x35265A0", VA = "0x1835279A0")]
	public void FKGJDDAEGLK(TNode KGOMINCBAMA, TNode PBNMPICADBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x3528290", Offset = "0x3526E90", VA = "0x183528290")]
	public void JPCDDCFOIGI(TClaimant EGEEGBMEGLE, TNode CLJGCEOPLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x3527390", Offset = "0x3525F90", VA = "0x183527390", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x35271E0", Offset = "0x3525DE0", VA = "0x1835271E0")]
	private void CPAJAOFAAFJ(TClaimant EGEEGBMEGLE, TNode POMMEIPFPHP, TNode CLJGCEOPLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3527C70", Offset = "0x3526870", VA = "0x183527C70")]
	private int HEJMHANDCGK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3528390", Offset = "0x3526F90", VA = "0x183528390")]
	private void KHCOABMANLN(TClaimant EGEEGBMEGLE, TNode IMPGKOHBIPN, TNode ILLJGBKEOAD, int BMIEHFOKELI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x3528040", Offset = "0x3526C40", VA = "0x183528040")]
	private void IMBAJJGHDCD(JLILJGDKBBL OPJLAOONFEH, KHKLKKIPEJN OHMGDMICHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3527CD0", Offset = "0x35268D0", VA = "0x183527CD0")]
	private void HPBCIBBKMPL(TClaimant EGEEGBMEGLE, TNode IMPGKOHBIPN, TNode ILLJGBKEOAD, int BMIEHFOKELI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x3527280", Offset = "0x3525E80", VA = "0x183527280")]
	private void DFCGKHFBIDA(JLILJGDKBBL OPJLAOONFEH, TNode KGOMINCBAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x35270E0", Offset = "0x3525CE0", VA = "0x1835270E0")]
	private void COLCFPHPLDE(JLILJGDKBBL OPJLAOONFEH, KHKLKKIPEJN OHMGDMICHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x3527F30", Offset = "0x3526B30", VA = "0x183527F30")]
	private void IHILHNKOHNP(KHKLKKIPEJN OHMGDMICHJP, bool BGGLIBKOBCP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x35275F0", Offset = "0x35261F0", VA = "0x1835275F0")]
	private void FFFEOJFGAIG(KHKLKKIPEJN OHMGDMICHJP, TNode PBNMPICADBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3528640", Offset = "0x3527240", VA = "0x183528640")]
	[IteratorStateMachine(typeof(global::EKNDDHLLNAF<, >.NPKDNEBFNHL))]
	private IEnumerable<TNode> MNIDAKMNMJF(TNode IMPGKOHBIPN, TNode ILLJGBKEOAD, bool KFHLMAACNGD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3527BB0", Offset = "0x35267B0", VA = "0x183527BB0")]
	private KHKLKKIPEJN GDCGDMODFFD(TNode KGOMINCBAMA, TNode ONIJEEBBCHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x3527A20", Offset = "0x3526620", VA = "0x183527A20")]
	private KHKLKKIPEJN GANJBHGFBOM(TNode KGOMINCBAMA, TNode ONIJEEBBCHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x35280D0", Offset = "0x3526CD0", VA = "0x1835280D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1A0C630", Offset = "0x1A0B230", VA = "0x181A0C630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x358EC50", Offset = "0x358D850", VA = "0x18358EC50")]
	public bool ODOLPHCGINH(T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x358E790", Offset = "0x358D390", VA = "0x18358E790")]
	public void CAILCKFFJIK(T ECNGHFJBIJL, int KPEDMKNLCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x358E8A0", Offset = "0x358D4A0", VA = "0x18358E8A0")]
	public bool CPPHPNNFPKL(T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x358E9C0", Offset = "0x358D5C0", VA = "0x18358E9C0")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x358E830", Offset = "0x358D430", VA = "0x18358E830")]
	public T CNIMANKOCJI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x358EA20", Offset = "0x358D620", VA = "0x18358EA20")]
	public T GJLDCBJIJID()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x358EA90", Offset = "0x358D690", VA = "0x18358EA90")]
	private void LPOKGMLFAHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x358EE60", Offset = "0x358DA60", VA = "0x18358EE60")]
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
		[Cpp2IlInjected.Address(RVA = "0x1A13150", Offset = "0x1A11D50", VA = "0x181A13150", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x1A13200", Offset = "0x1A11E00", VA = "0x181A13200", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool LKOPKHPHBFE
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x1A15AE0", Offset = "0x1A146E0", VA = "0x181A15AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public object IGIAPBEOOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x84D780", Offset = "0x84C380", VA = "0x18084D780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x8A4420", Offset = "0x8A3020", VA = "0x1808A4420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x1A13230", Offset = "0x1A11E30", VA = "0x181A13230")]
	public bool JKMEINBJGBN(T ECNGHFJBIJL, object FLDJLPKNKKO, int KPEDMKNLCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x1A130E0", Offset = "0x1A11CE0", VA = "0x181A130E0")]
	public bool CBLDDCBDCPG(object FLDJLPKNKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x1A137F0", Offset = "0x1A123F0", VA = "0x181A137F0")]
	public bool KFBGNHHGLGM(object FLDJLPKNKKO, out T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1A131D0", Offset = "0x1A11DD0", VA = "0x181A131D0")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x1A147B0", Offset = "0x1A133B0", VA = "0x181A147B0")]
	private bool KOEJMAALIAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x1A15B10", Offset = "0x1A14710", VA = "0x181A15B10")]
	public IGKFDGODDKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class EDOHCHPDFEG
{
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x6F14050", Offset = "0x6F12C50", VA = "0x186F14050")]
	public static void AEJPPLPBPDK(FMDOKKBAPOM AOCJDBLPGHC, string ALGKPJEIDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F143C0", Offset = "0x6F12FC0", VA = "0x186F143C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool BCIDLILPMOL
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CB0", Offset = "0x7F18B0", VA = "0x1807F2CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6F14440", Offset = "0x6F13040", VA = "0x186F14440")]
	public FGBDFJACAML(Action FOGMDOMFJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x6F143A0", Offset = "0x6F12FA0", VA = "0x186F143A0")]
	public void KOGMCNBOFCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6F143A0", Offset = "0x6F12FA0", VA = "0x186F143A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public class JPPAIIMIMHD : PKHKKGNCOIB
{
	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6F14E00", Offset = "0x6F13A00", VA = "0x186F14E00")]
	public JPPAIIMIMHD(UnityEngine.Object ICENKGBLLMO)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAC60", Offset = "0x1DD9860", VA = "0x181DDAC60")]
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
