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
		[Cpp2IlInjected.Address(RVA = "0x80EA60", Offset = "0x80DE60", VA = "0x18080EA60")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x80EE20", Offset = "0x80E220", VA = "0x18080EE20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB1A390", Offset = "0xB19790", VA = "0x180B1A390")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB1A540", Offset = "0xB19940", VA = "0x180B1A540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "4")]
	public virtual void PABHOAPJDGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
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
	[CAOLMLJBJPJ]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4276C80", Offset = "0x4276080", VA = "0x184276C80", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x42763B0", Offset = "0x42757B0", VA = "0x1842763B0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x42771C0", Offset = "0x42765C0", VA = "0x1842771C0")]
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
	private sealed class GPBDHJDFCAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public GPBDHJDFCAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5787D60", Offset = "0x5787160", VA = "0x185787D60")]
		internal int IJLEOMLMFNK(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[CAOLMLJBJPJ]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1A86AA0", Offset = "0x1A85EA0", VA = "0x181A86AA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1A86AD0", Offset = "0x1A85ED0", VA = "0x181A86AD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1A86A40", Offset = "0x1A85E40", VA = "0x181A86A40", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public TVal this[TKey LOLIOKKJLEH]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1C7A6A0", Offset = "0x1C79AA0", VA = "0x181C7A6A0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1A86940", Offset = "0x1A85D40", VA = "0x181A86940", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1C7A4D0", Offset = "0x1C798D0", VA = "0x181C7A4D0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1C79FE0", Offset = "0x1C793E0", VA = "0x181C79FE0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1C79C90", Offset = "0x1C79090", VA = "0x181C79C90", Slot = "14")]
	protected virtual string IICLLDONBEH(TKeyVal ADDPDFOJHJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1A86280", Offset = "0x1A85680", VA = "0x181A86280", Slot = "4")]
	public bool ContainsKey(TKey LOLIOKKJLEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1A86830", Offset = "0x1A85C30", VA = "0x181A86830", Slot = "5")]
	public bool TryGetValue(TKey LOLIOKKJLEH, out TVal EOEKGHMNIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1A862B0", Offset = "0x1A856B0", VA = "0x181A862B0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1A862B0", Offset = "0x1A856B0", VA = "0x181A862B0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1A86860", Offset = "0x1A85C60", VA = "0x181A86860")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KPMHAJCMANJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class GFADBHONBCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public GFADBHONBCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x34FFEB0", Offset = "0x34FF2B0", VA = "0x1834FFEB0")]
		internal bool EEKIAMHODHF(global::MHFKHOILBDC<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float CODJEIMEPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float AJDAHOINDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<global::MHFKHOILBDC<float, T>> HNIMEEKLALO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int DCGOKOAECIE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x42FF340", Offset = "0x42FE740", VA = "0x1842FF340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x42FF3C0", Offset = "0x42FE7C0", VA = "0x1842FF3C0")]
	public KPMHAJCMANJ(float LEGELHKELEP, float JCEDHEKKNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x42FF000", Offset = "0x42FE400", VA = "0x1842FF000")]
	public bool IPBNNOEALJK(float BPCFECOOAOP, T EOEKGHMNIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x42FEFA0", Offset = "0x42FE3A0", VA = "0x1842FEFA0")]
	public int INEFDPMKFPK(float BPCFECOOAOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x42FE830", Offset = "0x42FDC30", VA = "0x1842FE830")]
	public IEnumerable<T> ANDPJJLEDHJ(float BPCFECOOAOP, [Optional] float? BDCGECJBLPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x42FEF70", Offset = "0x42FE370", VA = "0x1842FEF70")]
	public void DDMMLHIFNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x42FEEB0", Offset = "0x42FE2B0", VA = "0x1842FEEB0")]
	private void BNNIHANNOAD(float BPCFECOOAOP)
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
	public T DEMEBAENMIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4783730", Offset = "0x4782B30", VA = "0x184783730")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4783720", Offset = "0x4782B20", VA = "0x184783720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float BAJPFCEEAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x113E8C0", Offset = "0x113DCC0", VA = "0x18113E8C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x47837F0", Offset = "0x4782BF0", VA = "0x1847837F0")]
	public T IBOGCGEHACP(float GGHBBCGIKPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4783B30", Offset = "0x4782F30", VA = "0x184783B30")]
	public T MKIHADKDDBB(float GGHBBCGIKPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T EEKLKBOGKOD(T JMFOJDPECFB, T PHAPIDHPFME, float GGHBBCGIKPJ);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3E89E20", Offset = "0x3E89220", VA = "0x183E89E20", Slot = "4")]
	protected override float EEKLKBOGKOD(float JMFOJDPECFB, float PHAPIDHPFME, float GGHBBCGIKPJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6F41920", Offset = "0x6F40D20", VA = "0x186F41920")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x183BED0", Offset = "0x183B2D0", VA = "0x18183BED0", Slot = "4")]
	protected override Vector3 EEKLKBOGKOD(Vector3 JMFOJDPECFB, Vector3 PHAPIDHPFME, float GGHBBCGIKPJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F47AA0", Offset = "0x6F46EA0", VA = "0x186F47AA0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x167A4D0", Offset = "0x16798D0", VA = "0x18167A4D0", Slot = "4")]
	protected override Color EEKLKBOGKOD(Color JMFOJDPECFB, Color PHAPIDHPFME, float GGHBBCGIKPJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F40A90", Offset = "0x6F3FE90", VA = "0x186F40A90")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class AFHAPNOJEBD
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C830", Offset = "0x1A4BC30", VA = "0x181A4C830")]
	public static global::LHHIMDDGJNN<T1> EDGHPEHNECD<T1>(T1 DFIDNFKIEIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C2C0", Offset = "0x1A4B6C0", VA = "0x181A4C2C0")]
	public static global::MHFKHOILBDC<T1, T2> EDGHPEHNECD<T1, T2>(T1 DFIDNFKIEIH, T2 ALBGNHACHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C330", Offset = "0x1A4B730", VA = "0x181A4C330")]
	public static global::HDOKDFLOHKN<T1, T2, T3> EDGHPEHNECD<T1, T2, T3>(T1 DFIDNFKIEIH, T2 ALBGNHACHIK, T3 OCOLCPGBJNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C6A0", Offset = "0x1A4BAA0", VA = "0x181A4C6A0")]
	public static global::DPBDJHAGOPL<T1, T2, T3, T4> EDGHPEHNECD<T1, T2, T3, T4>(T1 DFIDNFKIEIH, T2 ALBGNHACHIK, T3 OCOLCPGBJNB, T4 JNACHGIKHLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C600", Offset = "0x1A4BA00", VA = "0x181A4C600")]
	public static global::FBEDMHKKCNE<T1, T2, T3, T4, T5> EDGHPEHNECD<T1, T2, T3, T4, T5>(T1 DFIDNFKIEIH, T2 ALBGNHACHIK, T3 OCOLCPGBJNB, T4 JNACHGIKHLN, T5 NCIMBMEJMJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C550", Offset = "0x1A4B950", VA = "0x181A4C550")]
	public static global::BHMKCIJOFJB<T1, T2, T3, T4, T5, T6> EDGHPEHNECD<T1, T2, T3, T4, T5, T6>(T1 DFIDNFKIEIH, T2 ALBGNHACHIK, T3 OCOLCPGBJNB, T4 JNACHGIKHLN, T5 NCIMBMEJMJH, T6 LFPJEEGLEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C490", Offset = "0x1A4B890", VA = "0x181A4C490")]
	public static global::CODKAEKGJNK<T1, T2, T3, T4, T5, T6, T7> EDGHPEHNECD<T1, T2, T3, T4, T5, T6, T7>(T1 DFIDNFKIEIH, T2 ALBGNHACHIK, T3 OCOLCPGBJNB, T4 JNACHGIKHLN, T5 NCIMBMEJMJH, T6 LFPJEEGLEEG, T7 ALALFDDPLMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C3C0", Offset = "0x1A4B7C0", VA = "0x181A4C3C0")]
	public static global::ALOFIIDMILA<T1, T2, T3, T4, T5, T6, T7, T8> EDGHPEHNECD<T1, T2, T3, T4, T5, T6, T7, T8>(T1 DFIDNFKIEIH, T2 ALBGNHACHIK, T3 OCOLCPGBJNB, T4 JNACHGIKHLN, T5 NCIMBMEJMJH, T6 LFPJEEGLEEG, T7 ALALFDDPLMD, T8 LBGDGMNCGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C950", Offset = "0x1A4BD50", VA = "0x181A4C950")]
	[IteratorStateMachine(typeof(PFFCHINFONB))]
	public static IEnumerable<global::MHFKHOILBDC<T1, T2>> FOECCMPPLKH<T1, T2>(IEnumerable<T1> ELMEJGEELII, IEnumerable<T2> EOKEPOJIFJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C890", Offset = "0x1A4BC90", VA = "0x181A4C890")]
	[IteratorStateMachine(typeof(AIOGONOENDO))]
	public static IEnumerable<global::HDOKDFLOHKN<T1, T2, T3>> FOECCMPPLKH<T1, T2, T3>(IEnumerable<T1> ELMEJGEELII, IEnumerable<T2> EOKEPOJIFJF, IEnumerable<T3> KBGOGJMMMNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6F40610", Offset = "0x6F3FA10", VA = "0x186F40610")]
	internal static int IHDPAHNEACC(int KMJLJDCCGKF, int KHMDKPMAIBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F40660", Offset = "0x6F3FA60", VA = "0x186F40660")]
	internal static int IHDPAHNEACC(int KMJLJDCCGKF, int KHMDKPMAIBJ, int AECKDNEDIGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F40640", Offset = "0x6F3FA40", VA = "0x186F40640")]
	internal static int IHDPAHNEACC(int KMJLJDCCGKF, int KHMDKPMAIBJ, int AECKDNEDIGL, int NBCIOOLCBFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F40620", Offset = "0x6F3FA20", VA = "0x186F40620")]
	internal static int IHDPAHNEACC(int KMJLJDCCGKF, int KHMDKPMAIBJ, int AECKDNEDIGL, int NBCIOOLCBFG, int IBHIBGFODOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F406A0", Offset = "0x6F3FAA0", VA = "0x186F406A0")]
	internal static int IHDPAHNEACC(int KMJLJDCCGKF, int KHMDKPMAIBJ, int AECKDNEDIGL, int NBCIOOLCBFG, int IBHIBGFODOK, int KDOHBJDEJFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F40670", Offset = "0x6F3FA70", VA = "0x186F40670")]
	internal static int IHDPAHNEACC(int KMJLJDCCGKF, int KHMDKPMAIBJ, int AECKDNEDIGL, int NBCIOOLCBFG, int IBHIBGFODOK, int KDOHBJDEJFA, int JLFEHJJBFFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F405E0", Offset = "0x6F3F9E0", VA = "0x186F405E0")]
	internal static int IHDPAHNEACC(int KMJLJDCCGKF, int KHMDKPMAIBJ, int AECKDNEDIGL, int NBCIOOLCBFG, int IBHIBGFODOK, int KDOHBJDEJFA, int JLFEHJJBFFB, int ENAAHDHKLDD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LHHIMDDGJNN<T1> : IComparable<global::LHHIMDDGJNN<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T1 FEFMMAEIDNE;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x25DFEC0", Offset = "0x25DF2C0", VA = "0x1825DFEC0")]
	public LHHIMDDGJNN(T1 DFIDNFKIEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3B27D80", Offset = "0x3B27180", VA = "0x183B27D80", Slot = "4")]
	public int CompareTo(global::LHHIMDDGJNN<T1> CCJMBGJFGLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3B27DF0", Offset = "0x3B271F0", VA = "0x183B27DF0", Slot = "0")]
	public override bool Equals(object CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xEBF570", Offset = "0xEBE970", VA = "0x180EBF570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3B27E90", Offset = "0x3B27290", VA = "0x183B27E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MHFKHOILBDC<T1, T2> : IComparable<global::MHFKHOILBDC<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly T1 FEFMMAEIDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T2 ADHHACIAEDF;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3254110", Offset = "0x3253510", VA = "0x183254110")]
	public MHFKHOILBDC(T1 DFIDNFKIEIH, T2 ALBGNHACHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x44DBE30", Offset = "0x44DB230", VA = "0x1844DBE30", Slot = "4")]
	public int CompareTo(global::MHFKHOILBDC<T1, T2> CCJMBGJFGLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x44DC6F0", Offset = "0x44DBAF0", VA = "0x1844DC6F0", Slot = "0")]
	public override bool Equals(object CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x44DCE80", Offset = "0x44DC280", VA = "0x1844DCE80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x44DDA40", Offset = "0x44DCE40", VA = "0x1844DDA40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HDOKDFLOHKN<T1, T2, T3> : IComparable<global::HDOKDFLOHKN<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly T1 FEFMMAEIDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly T2 ADHHACIAEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly T3 IPJPDNPHGOC;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x43364E0", Offset = "0x43358E0", VA = "0x1843364E0")]
	public HDOKDFLOHKN(T1 DFIDNFKIEIH, T2 ALBGNHACHIK, T3 OCOLCPGBJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4335CA0", Offset = "0x43350A0", VA = "0x184335CA0", Slot = "4")]
	public int CompareTo(global::HDOKDFLOHKN<T1, T2, T3> CCJMBGJFGLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4335FC0", Offset = "0x43353C0", VA = "0x184335FC0", Slot = "0")]
	public override bool Equals(object CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4336130", Offset = "0x4335530", VA = "0x184336130", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4336220", Offset = "0x4335620", VA = "0x184336220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DPBDJHAGOPL<T1, T2, T3, T4> : IComparable<global::DPBDJHAGOPL<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 FEFMMAEIDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T2 ADHHACIAEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T3 IPJPDNPHGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T4 IILHHONGJLK;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x322B190", Offset = "0x322A590", VA = "0x18322B190")]
	public DPBDJHAGOPL(T1 DFIDNFKIEIH, T2 ALBGNHACHIK, T3 OCOLCPGBJNB, T4 JNACHGIKHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3C15570", Offset = "0x3C14970", VA = "0x183C15570", Slot = "4")]
	public int CompareTo(global::DPBDJHAGOPL<T1, T2, T3, T4> CCJMBGJFGLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3C156B0", Offset = "0x3C14AB0", VA = "0x183C156B0", Slot = "0")]
	public override bool Equals(object CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3C157F0", Offset = "0x3C14BF0", VA = "0x183C157F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3C158B0", Offset = "0x3C14CB0", VA = "0x183C158B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FBEDMHKKCNE<T1, T2, T3, T4, T5> : IComparable<global::FBEDMHKKCNE<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T1 FEFMMAEIDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T2 ADHHACIAEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T3 IPJPDNPHGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T4 IILHHONGJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T5 CGNHFNAIGGI;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3419CE0", Offset = "0x34190E0", VA = "0x183419CE0")]
	public FBEDMHKKCNE(T1 DFIDNFKIEIH, T2 ALBGNHACHIK, T3 OCOLCPGBJNB, T4 JNACHGIKHLN, T5 NCIMBMEJMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x34197A0", Offset = "0x3418BA0", VA = "0x1834197A0", Slot = "4")]
	public int CompareTo(global::FBEDMHKKCNE<T1, T2, T3, T4, T5> CCJMBGJFGLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3419920", Offset = "0x3418D20", VA = "0x183419920", Slot = "0")]
	public override bool Equals(object CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3419A90", Offset = "0x3418E90", VA = "0x183419A90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3419B90", Offset = "0x3418F90", VA = "0x183419B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BHMKCIJOFJB<T1, T2, T3, T4, T5, T6> : IComparable<global::BHMKCIJOFJB<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T1 FEFMMAEIDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T2 ADHHACIAEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T3 IPJPDNPHGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T4 IILHHONGJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T5 CGNHFNAIGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T6 LOENKFDABII;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x37DE940", Offset = "0x37DDD40", VA = "0x1837DE940")]
	public BHMKCIJOFJB(T1 DFIDNFKIEIH, T2 ALBGNHACHIK, T3 OCOLCPGBJNB, T4 JNACHGIKHLN, T5 NCIMBMEJMJH, T6 LFPJEEGLEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x37DE360", Offset = "0x37DD760", VA = "0x1837DE360", Slot = "4")]
	public int CompareTo(global::BHMKCIJOFJB<T1, T2, T3, T4, T5, T6> CCJMBGJFGLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x37DE520", Offset = "0x37DD920", VA = "0x1837DE520", Slot = "0")]
	public override bool Equals(object CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x37DE6B0", Offset = "0x37DDAB0", VA = "0x1837DE6B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x37DE7D0", Offset = "0x37DDBD0", VA = "0x1837DE7D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CODKAEKGJNK<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::CODKAEKGJNK<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 FEFMMAEIDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 ADHHACIAEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 IPJPDNPHGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 IILHHONGJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 CGNHFNAIGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 LOENKFDABII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T7 AFBBOPBOJHI;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3C9EF80", Offset = "0x3C9E380", VA = "0x183C9EF80")]
	public CODKAEKGJNK(T1 DFIDNFKIEIH, T2 ALBGNHACHIK, T3 OCOLCPGBJNB, T4 JNACHGIKHLN, T5 NCIMBMEJMJH, T6 LFPJEEGLEEG, T7 ALALFDDPLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3C9E8E0", Offset = "0x3C9DCE0", VA = "0x183C9E8E0", Slot = "4")]
	public int CompareTo(global::CODKAEKGJNK<T1, T2, T3, T4, T5, T6, T7> CCJMBGJFGLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3C9EAE0", Offset = "0x3C9DEE0", VA = "0x183C9EAE0", Slot = "0")]
	public override bool Equals(object CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3C9ECA0", Offset = "0x3C9E0A0", VA = "0x183C9ECA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3C9EDF0", Offset = "0x3C9E1F0", VA = "0x183C9EDF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ALOFIIDMILA<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::ALOFIIDMILA<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T1 FEFMMAEIDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T2 ADHHACIAEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T3 IPJPDNPHGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T4 IILHHONGJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T5 CGNHFNAIGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T6 LOENKFDABII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T7 AFBBOPBOJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T8 KOGJJEPAIAI;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3416330", Offset = "0x3415730", VA = "0x183416330")]
	public ALOFIIDMILA(T1 DFIDNFKIEIH, T2 ALBGNHACHIK, T3 OCOLCPGBJNB, T4 JNACHGIKHLN, T5 NCIMBMEJMJH, T6 LFPJEEGLEEG, T7 ALALFDDPLMD, T8 LBGDGMNCGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3415BE0", Offset = "0x3414FE0", VA = "0x183415BE0", Slot = "4")]
	public int CompareTo(global::ALOFIIDMILA<T1, T2, T3, T4, T5, T6, T7, T8> CCJMBGJFGLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3415E30", Offset = "0x3415230", VA = "0x183415E30", Slot = "0")]
	public override bool Equals(object CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3416010", Offset = "0x3415410", VA = "0x183416010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3416180", Offset = "0x3415580", VA = "0x183416180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CAOLMLJBJPJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x973F80", Offset = "0x973380", VA = "0x180973F80")]
	public CAOLMLJBJPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class HashableScriptableObject : ScriptableObject, LEKBKLMMEEC, MCAKLHNHDFK, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x811A60", Offset = "0x810E60", VA = "0x180811A60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x855AE0", Offset = "0x854EE0", VA = "0x180855AE0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x855AF0", Offset = "0x854EF0", VA = "0x180855AF0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x991BC0", Offset = "0x990FC0", VA = "0x180991BC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash IMDHKCCMAPF);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xBBA390", Offset = "0xBB9790", VA = "0x180BBA390")]
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
	[LFKPGLNIOPL]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[SerializeField]
	[LFKPGLNIOPL]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F46980", Offset = "0x6F45D80", VA = "0x186F46980")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6F46940", Offset = "0x6F45D40", VA = "0x186F46940")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F469C0", Offset = "0x6F45DC0", VA = "0x186F469C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F46B90", Offset = "0x6F45F90", VA = "0x186F46B90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6F46B00", Offset = "0x6F45F00", VA = "0x186F46B00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xBBA3C0", Offset = "0xBB97C0", VA = "0x180BBA3C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xBBA3D0", Offset = "0xBB97D0", VA = "0x180BBA3D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F46900", Offset = "0x6F45D00", VA = "0x186F46900")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F46A70", Offset = "0x6F45E70", VA = "0x186F46A70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6F46340", Offset = "0x6F45740", VA = "0x186F46340")]
	public void CopyBounds(SavedExtents CCJMBGJFGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6F46860", Offset = "0x6F45C60", VA = "0x186F46860")]
	public void SetLocalSpaceBounds(Bounds EPJEBNNDOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6F45CE0", Offset = "0x6F450E0", VA = "0x186F45CE0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6F46850", Offset = "0x6F45C50", VA = "0x186F46850")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6F46370", Offset = "0x6F45770", VA = "0x186F46370")]
	private void JJFLNEHFDIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6F46620", Offset = "0x6F45A20", VA = "0x186F46620")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6F45D00", Offset = "0x6F45100", VA = "0x186F45D00")]
	public static void CalculateLocalBoundsFor(GameObject NJMBJKHNCBN, out Bounds EPJEBNNDOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6F46560", Offset = "0x6F45960", VA = "0x186F46560")]
	private static void NLLKIENFIFP(Bounds EOKEPOJIFJF, Color KBGOGJMMMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6F46880", Offset = "0x6F45C80", VA = "0x186F46880")]
	public SavedExtents()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class LPBOKFJOJKE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct BOAOJENAPGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public T DEMEBAENMIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float DGPGPMIBNMF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static float EJFKLAOAINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private List<T> CMCELABEJPK;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private const int JPFLPPANEJK = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private BOAOJENAPGJ[] BIBDBFOMNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int EDNFCMKEANN;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float APMMBMDANIB
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xBBC3F0", Offset = "0xBBB7F0", VA = "0x180BBC3F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xC7B280", Offset = "0xC7A680", VA = "0x180C7B280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x38C9210", Offset = "0x38C8610", VA = "0x1838C9210")]
	public LPBOKFJOJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x38C9110", Offset = "0x38C8510", VA = "0x1838C9110")]
	public LPBOKFJOJKE(int ABBKELIMEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x38C8670", Offset = "0x38C7A70", VA = "0x1838C8670")]
	public void MGOOIKEIGMG(float BPCFECOOAOP, T EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x38C7ED0", Offset = "0x38C72D0", VA = "0x1838C7ED0")]
	public void DDMMLHIFNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x38C8020", Offset = "0x38C7420", VA = "0x1838C8020")]
	public bool GCBHOLGGEDH(float FCHEKHELBEL, float FIMHKGEAHJH, out T EOEKGHMNIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x38C8860", Offset = "0x38C7C60", VA = "0x1838C8860")]
	public bool NICKPFEMJIL(float FCHEKHELBEL, float FIMHKGEAHJH, out T EOEKGHMNIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x38C8F50", Offset = "0x38C8350", VA = "0x1838C8F50")]
	public void OBFGMODNIIB(float FCHEKHELBEL, float FIMHKGEAHJH, List<T> ENPOOOLHCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x38C8830", Offset = "0x38C7C30", VA = "0x1838C8830")]
	private int NDDLMECCHFM(int EGJHBIAGJNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x38C9080", Offset = "0x38C8480", VA = "0x1838C9080")]
	private void PKNIIAMOEMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T JAKFIJAAEGB();

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T EEKLKBOGKOD(T JMFOJDPECFB, T PHAPIDHPFME, float GGHBBCGIKPJ);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T EKLADAGPJGF(T EOEKGHMNIDN, float GGHBBCGIKPJ);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T HFPOPDHMJMO(T JMFOJDPECFB, T PHAPIDHPFME);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T BNFJFJMIECD(T JMFOJDPECFB, T PHAPIDHPFME);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DGEDJHLDCEA : global::LPBOKFJOJKE<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x16197F0", Offset = "0x1618BF0", VA = "0x1816197F0", Slot = "4")]
	protected override Vector3 JAKFIJAAEGB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x183BED0", Offset = "0x183B2D0", VA = "0x18183BED0", Slot = "5")]
	protected override Vector3 EEKLKBOGKOD(Vector3 JMFOJDPECFB, Vector3 PHAPIDHPFME, float GGHBBCGIKPJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F40B40", Offset = "0x6F3FF40", VA = "0x186F40B40", Slot = "6")]
	protected override Vector3 EKLADAGPJGF(Vector3 EOEKGHMNIDN, float GGHBBCGIKPJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F40BA0", Offset = "0x6F3FFA0", VA = "0x186F40BA0", Slot = "7")]
	protected override Vector3 HFPOPDHMJMO(Vector3 JMFOJDPECFB, Vector3 PHAPIDHPFME)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F40AD0", Offset = "0x6F3FED0", VA = "0x186F40AD0", Slot = "8")]
	protected override Vector3 BNFJFJMIECD(Vector3 JMFOJDPECFB, Vector3 PHAPIDHPFME)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F40C20", Offset = "0x6F40020", VA = "0x186F40C20")]
	public DGEDJHLDCEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HMLLGPAFGKA : global::LPBOKFJOJKE<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F41BA0", Offset = "0x6F40FA0", VA = "0x186F41BA0")]
	public HMLLGPAFGKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F41B30", Offset = "0x6F40F30", VA = "0x186F41B30")]
	public HMLLGPAFGKA(int ABBKELIMEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xD87420", Offset = "0xD86820", VA = "0x180D87420", Slot = "4")]
	protected override float JAKFIJAAEGB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3E89E20", Offset = "0x3E89220", VA = "0x183E89E20", Slot = "5")]
	protected override float EEKLKBOGKOD(float JMFOJDPECFB, float PHAPIDHPFME, float GGHBBCGIKPJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5C28CD0", Offset = "0x5C280D0", VA = "0x185C28CD0", Slot = "6")]
	protected override float EKLADAGPJGF(float EOEKGHMNIDN, float GGHBBCGIKPJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F41B20", Offset = "0x6F40F20", VA = "0x186F41B20", Slot = "7")]
	protected override float HFPOPDHMJMO(float JMFOJDPECFB, float PHAPIDHPFME)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F41B10", Offset = "0x6F40F10", VA = "0x186F41B10", Slot = "8")]
	protected override float BNFJFJMIECD(float JMFOJDPECFB, float PHAPIDHPFME)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ILBADPLJCKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly IDisposable BGHJOACDLLH;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public ILBADPLJCKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NFGNCLIKGPA : global::FBBIKFEAGNC<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F43AA0", Offset = "0x6F42EA0", VA = "0x186F43AA0")]
	public NFGNCLIKGPA(int FJOEBJHKPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F43AF0", Offset = "0x6F42EF0", VA = "0x186F43AF0")]
	public NFGNCLIKGPA(IMCAAHLLPEN[] BCICFPLGOEG, bool DKCOIJJMCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F43A30", Offset = "0x6F42E30", VA = "0x186F43A30", Slot = "6")]
	protected override uint EPGMCGODPHC(uint IMDHKCCMAPF, string EOEKGHMNIDN)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class CLCEPFPNDDF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public readonly struct DFFHCNLEPBG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly global::CLCEPFPNDDF<T> FPEDKGJHABM;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T DEMEBAENMIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x3606A10", Offset = "0x3605E10", VA = "0x183606A10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x36069E0", Offset = "0x3605DE0", VA = "0x1836069E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xB8F880", Offset = "0xB8EC80", VA = "0x180B8F880")]
		public DFFHCNLEPBG(global::CLCEPFPNDDF<T> FPEDKGJHABM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class JCGCKGMPPIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder<DFFHCNLEPBG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public global::CLCEPFPNDDF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public JCGCKGMPPIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3398FF0", Offset = "0x33983F0", VA = "0x183398FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class JKMOLFPMEMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<DFFHCNLEPBG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public global::CLCEPFPNDDF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public JKMOLFPMEMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x308E490", Offset = "0x308D890", VA = "0x18308E490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly SemaphoreSlim ABPNLEEOFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private T CPMGHKOLOND;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int EBEDHOKNIIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3C970D0", Offset = "0x3C964D0", VA = "0x183C970D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3C97120", Offset = "0x3C96520", VA = "0x183C97120")]
	public CLCEPFPNDDF(in T CPMGHKOLOND, int ELHGAHJDAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3C970F0", Offset = "0x3C964F0", VA = "0x183C970F0")]
	public CLCEPFPNDDF(in T CPMGHKOLOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3C97050", Offset = "0x3C96450", VA = "0x183C97050")]
	public DFFHCNLEPBG DJIJJEGLOPN()
	{
		return default(DFFHCNLEPBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3C97090", Offset = "0x3C96490", VA = "0x183C97090")]
	public DFFHCNLEPBG DJIJJEGLOPN(CancellationToken EMJFDFLJKFG)
	{
		return default(DFFHCNLEPBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3C96EA0", Offset = "0x3C962A0", VA = "0x183C96EA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::CLCEPFPNDDF<>.JCGCKGMPPIE))]
	public Task<DFFHCNLEPBG> CEDGOPHAAJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3C96950", Offset = "0x3C95D50", VA = "0x183C96950")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::CLCEPFPNDDF<>.JKMOLFPMEMM))]
	public Task<DFFHCNLEPBG> CEDGOPHAAJB(CancellationToken EMJFDFLJKFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class AGPDKPGAJCK
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F407C0", Offset = "0x6F3FBC0", VA = "0x186F407C0")]
	public static global::CLCEPFPNDDF<CPKDLGGKAMN> FHHJOGLDILM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F40820", Offset = "0x6F3FC20", VA = "0x186F40820")]
	public static global::CLCEPFPNDDF<CPKDLGGKAMN> FHHJOGLDILM(int ELHGAHJDAFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C830", Offset = "0x1A4BC30", VA = "0x181A4C830")]
	public static global::CLCEPFPNDDF<T> FHHJOGLDILM<T>(in T CPMGHKOLOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1A4CF80", Offset = "0x1A4C380", VA = "0x181A4CF80")]
	public static global::CLCEPFPNDDF<T> FHHJOGLDILM<T>(in T CPMGHKOLOND, int ELHGAHJDAFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class DDMLEBDHDNM<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private global::DDMLEBDHDNM<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x86EF30", Offset = "0x86E330", VA = "0x18086EF30", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x3547AD0", Offset = "0x3546ED0", VA = "0x183547AD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3548E30", Offset = "0x3548230", VA = "0x183548E30")]
		public Enumerator(global::DDMLEBDHDNM<T> ENPOOOLHCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3544AA0", Offset = "0x3543EA0", VA = "0x183544AA0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x35466A0", Offset = "0x3545AA0", VA = "0x1835466A0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3545F40", Offset = "0x3545340", VA = "0x183545F40")]
		private void OKIJHGKIIDP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private T[] HOCKGLIBNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private int CBDFEPEIFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private int GNJDOFDCIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private int EGPHDEMHMDI;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int KLCJBBHGHFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3606180", Offset = "0x3605580", VA = "0x183606180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x36044E0", Offset = "0x36038E0", VA = "0x1836044E0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3605BB0", Offset = "0x3604FB0", VA = "0x183605BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3606340", Offset = "0x3605740", VA = "0x183606340")]
	public DDMLEBDHDNM(int FJOEBJHKPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3606000", Offset = "0x3605400", VA = "0x183606000")]
	public void MGOOIKEIGMG(T GGHBBCGIKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3604B80", Offset = "0x3603F80", VA = "0x183604B80")]
	public void FDAAJPHOJAO(IEnumerable<T> BOIGNFPOPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3604580", Offset = "0x3603980", VA = "0x183604580")]
	public void DDMMLHIFNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x36051A0", Offset = "0x36045A0", VA = "0x1836051A0")]
	public void FGAHAFDJKMC(int HHFCIFFLNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3605B20", Offset = "0x3604F20", VA = "0x183605B20")]
	public void HLALICLCPJL(int HHFCIFFLNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3605620", Offset = "0x3604A20", VA = "0x183605620")]
	public void HIOGEOEHHAM(T[] BIBDBFOMNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3605E40", Offset = "0x3605240", VA = "0x183605E40")]
	public Enumerator KLBJEDHKGHJ()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x36061C0", Offset = "0x36055C0", VA = "0x1836061C0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x36061C0", Offset = "0x36055C0", VA = "0x1836061C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3605230", Offset = "0x3604630", VA = "0x183605230")]
	private int GGJEHODHDFO(int CJOLACIBAJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x36055F0", Offset = "0x36049F0", VA = "0x1836055F0")]
	private int GKDLIKJABPN(int CJOLACIBAJH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class NAPGMEEADKF
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void LOAILDHBBCJ(object[] KBOOOAILJFG);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	protected NAPGMEEADKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class CDODABMCIEL<T> : NAPGMEEADKF
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	protected struct HEEMAGOMGAH
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum MOMKHCHICLE
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
		public MOMKHCHICLE ONBHBHIHHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public T ENOAFIICPMH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private int JBCKNHANMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly bool MJLENFGHCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	protected readonly bool NCCLLCNMPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	protected List<T> FHJNDGCOJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<HEEMAGOMGAH> LBMLDFNNIBG;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool PDCLPBBPMAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x385DB00", Offset = "0x385CF00", VA = "0x18385DB00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x385E0A0", Offset = "0x385D4A0", VA = "0x18385E0A0")]
	protected CDODABMCIEL(bool NCCLLCNMPEL, bool MJLENFGHCIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x385DE00", Offset = "0x385D200", VA = "0x18385DE00")]
	protected bool FLKLDMKHNEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x385DE80", Offset = "0x385D280", VA = "0x18385DE80")]
	protected void IDHLFLMFICC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x385DB40", Offset = "0x385CF40", VA = "0x18385DB40")]
	protected void CEIKFKBNIGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8F40", Offset = "0x2CA8340", VA = "0x182CA8F40")]
	private static void FEAKGBNKBCH<U>(ref List<U> FGINDFDIDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x385DF40", Offset = "0x385D340", VA = "0x18385DF40", Slot = "5")]
	public void MGOOIKEIGMG(T ENOAFIICPMH, bool FHPDAMCEDOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x385D9B0", Offset = "0x385CDB0", VA = "0x18385D9B0", Slot = "6")]
	public void AJCNBIMBJPF(T ENOAFIICPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x385DCF0", Offset = "0x385D0F0", VA = "0x18385DCF0")]
	public void DDMMLHIFNLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface LGNEKBHBJIH
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGOOIKEIGMG(Action ENOAFIICPMH, bool FHPDAMCEDOJ = false);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJCNBIMBJPF(Action ENOAFIICPMH);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class PBANGFKDEGA : global::CDODABMCIEL<Action>, LGNEKBHBJIH
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F441E0", Offset = "0x6F435E0", VA = "0x186F441E0")]
	public PBANGFKDEGA(bool NCCLLCNMPEL = false, bool MJLENFGHCIL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6F43FE0", Offset = "0x6F433E0", VA = "0x186F43FE0")]
	public void NKHICBNDNPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F43F10", Offset = "0x6F43310", VA = "0x186F43F10", Slot = "4")]
	public override void LOAILDHBBCJ(object[] KBOOOAILJFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F43F80", Offset = "0x6F43380", VA = "0x186F43F80")]
	public static PBANGFKDEGA MMONCNIPLKJ(PBANGFKDEGA INFMHMFOGBI, Action ENOAFIICPMH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F43EB0", Offset = "0x6F432B0", VA = "0x186F43EB0")]
	public static PBANGFKDEGA FDINAEPEOCM(PBANGFKDEGA INFMHMFOGBI, Action ENOAFIICPMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface BKPDEGKDPNM<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGOOIKEIGMG(Action<T> ENOAFIICPMH, bool FHPDAMCEDOJ = false);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJCNBIMBJPF(Action<T> ENOAFIICPMH);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class KDDMDDMMGFF<T> : global::CDODABMCIEL<Action<T>>, global::BKPDEGKDPNM<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2ECC890", Offset = "0x2ECBC90", VA = "0x182ECC890")]
	public KDDMDDMMGFF(bool NCCLLCNMPEL = false, bool MJLENFGHCIL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2ECBD30", Offset = "0x2ECB130", VA = "0x182ECBD30")]
	public void NKHICBNDNPN(T GGHBBCGIKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2ECA040", Offset = "0x2EC9440", VA = "0x182ECA040", Slot = "4")]
	public override void LOAILDHBBCJ(object[] KBOOOAILJFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2ECAA00", Offset = "0x2EC9E00", VA = "0x182ECAA00")]
	public static global::KDDMDDMMGFF<T> MMONCNIPLKJ(global::KDDMDDMMGFF<T> INFMHMFOGBI, Action<T> ENOAFIICPMH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2EC8B60", Offset = "0x2EC7F60", VA = "0x182EC8B60")]
	public static global::KDDMDDMMGFF<T> FDINAEPEOCM(global::KDDMDDMMGFF<T> INFMHMFOGBI, Action<T> ENOAFIICPMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface HABGHELGEHD<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGOOIKEIGMG(Action<T, U> ENOAFIICPMH, bool FHPDAMCEDOJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJCNBIMBJPF(Action<T, U> ENOAFIICPMH);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class BHKLKEHGEFA<T, U> : global::CDODABMCIEL<Action<T, U>>, global::HABGHELGEHD<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2ECC890", Offset = "0x2ECBC90", VA = "0x182ECC890")]
	public BHKLKEHGEFA(bool NCCLLCNMPEL = false, bool MJLENFGHCIL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x37DBFF0", Offset = "0x37DB3F0", VA = "0x1837DBFF0")]
	public void NKHICBNDNPN(T GGHBBCGIKPJ, U KMIEKFALHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x37DB6D0", Offset = "0x37DAAD0", VA = "0x1837DB6D0", Slot = "4")]
	public override void LOAILDHBBCJ(object[] KBOOOAILJFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x37DB880", Offset = "0x37DAC80", VA = "0x1837DB880")]
	public static global::BHKLKEHGEFA<T, U> MMONCNIPLKJ(global::BHKLKEHGEFA<T, U> INFMHMFOGBI, Action<T, U> ENOAFIICPMH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x37D8640", Offset = "0x37D7A40", VA = "0x1837D8640")]
	public static global::BHKLKEHGEFA<T, U> FDINAEPEOCM(global::BHKLKEHGEFA<T, U> INFMHMFOGBI, Action<T, U> ENOAFIICPMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface KMHGDMIKHNL<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGOOIKEIGMG(Action<T, U, V> ENOAFIICPMH, bool FHPDAMCEDOJ = false);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJCNBIMBJPF(Action<T, U, V> ENOAFIICPMH);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class FADFJBGFMFG<T, U, V> : global::CDODABMCIEL<Action<T, U, V>>, global::KMHGDMIKHNL<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2ECC890", Offset = "0x2ECBC90", VA = "0x182ECC890")]
	public FADFJBGFMFG(bool NCCLLCNMPEL = false, bool MJLENFGHCIL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x511D810", Offset = "0x511CC10", VA = "0x18511D810")]
	public void NKHICBNDNPN(T GGHBBCGIKPJ, U KMIEKFALHHB, V PKIAPNEHKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x511C7E0", Offset = "0x511BBE0", VA = "0x18511C7E0", Slot = "4")]
	public override void LOAILDHBBCJ(object[] KBOOOAILJFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x511D2B0", Offset = "0x511C6B0", VA = "0x18511D2B0")]
	public static global::FADFJBGFMFG<T, U, V> MMONCNIPLKJ(global::FADFJBGFMFG<T, U, V> INFMHMFOGBI, Action<T, U, V> ENOAFIICPMH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x511B460", Offset = "0x511A860", VA = "0x18511B460")]
	public static global::FADFJBGFMFG<T, U, V> FDINAEPEOCM(global::FADFJBGFMFG<T, U, V> INFMHMFOGBI, Action<T, U, V> ENOAFIICPMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface NGHMNHFCDOK<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGOOIKEIGMG(Action<T, U, V, W> ENOAFIICPMH, bool FHPDAMCEDOJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJCNBIMBJPF(Action<T, U, V, W> ENOAFIICPMH);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class NKJEEGFCHCH<T, U, V, W> : global::CDODABMCIEL<Action<T, U, V, W>>, global::NGHMNHFCDOK<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2ECC890", Offset = "0x2ECBC90", VA = "0x182ECC890")]
	public NKJEEGFCHCH(bool NCCLLCNMPEL = false, bool MJLENFGHCIL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8A40", Offset = "0x3BB7E40", VA = "0x183BB8A40")]
	public void NKHICBNDNPN(T GGHBBCGIKPJ, U KMIEKFALHHB, V PKIAPNEHKCP, W EPJNHAFGAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3BB7940", Offset = "0x3BB6D40", VA = "0x183BB7940", Slot = "4")]
	public override void LOAILDHBBCJ(object[] KBOOOAILJFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8100", Offset = "0x3BB7500", VA = "0x183BB8100")]
	public static global::NKJEEGFCHCH<T, U, V, W> MMONCNIPLKJ(global::NKJEEGFCHCH<T, U, V, W> INFMHMFOGBI, Action<T, U, V, W> ENOAFIICPMH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3BB6BF0", Offset = "0x3BB5FF0", VA = "0x183BB6BF0")]
	public static global::NKJEEGFCHCH<T, U, V, W> FDINAEPEOCM(global::NKJEEGFCHCH<T, U, V, W> INFMHMFOGBI, Action<T, U, V, W> ENOAFIICPMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface BNIBOEOKHIN<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGOOIKEIGMG(Action<T, U, V, W, X> ENOAFIICPMH, bool FHPDAMCEDOJ = false);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJCNBIMBJPF(Action<T, U, V, W, X> ENOAFIICPMH);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class FFDGMAIHJCH<T, U, V, W, X> : global::CDODABMCIEL<Action<T, U, V, W, X>>, global::BNIBOEOKHIN<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2ECC890", Offset = "0x2ECBC90", VA = "0x182ECC890")]
	public FFDGMAIHJCH(bool NCCLLCNMPEL = false, bool MJLENFGHCIL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x34203F0", Offset = "0x341F7F0", VA = "0x1834203F0")]
	public void NKHICBNDNPN(T GGHBBCGIKPJ, U KMIEKFALHHB, V PKIAPNEHKCP, W EPJNHAFGAON, X MIKJHKLKLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x341FD30", Offset = "0x341F130", VA = "0x18341FD30", Slot = "4")]
	public override void LOAILDHBBCJ(object[] KBOOOAILJFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3420020", Offset = "0x341F420", VA = "0x183420020")]
	public static global::FFDGMAIHJCH<T, U, V, W, X> MMONCNIPLKJ(global::FFDGMAIHJCH<T, U, V, W, X> INFMHMFOGBI, Action<T, U, V, W, X> ENOAFIICPMH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x341F970", Offset = "0x341ED70", VA = "0x18341F970")]
	public static global::FFDGMAIHJCH<T, U, V, W, X> FDINAEPEOCM(global::FFDGMAIHJCH<T, U, V, W, X> INFMHMFOGBI, Action<T, U, V, W, X> ENOAFIICPMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface AKAKOFCKIBO<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGOOIKEIGMG(Action<T, U, V, W, X, Y> ENOAFIICPMH, bool FHPDAMCEDOJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJCNBIMBJPF(Action<T, U, V, W, X, Y> ENOAFIICPMH);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class JBIOEMJINKF<T, U, V, W, X, Y> : global::CDODABMCIEL<Action<T, U, V, W, X, Y>>, global::AKAKOFCKIBO<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2ECC890", Offset = "0x2ECBC90", VA = "0x182ECC890")]
	public JBIOEMJINKF(bool NCCLLCNMPEL = false, bool MJLENFGHCIL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3392090", Offset = "0x3391490", VA = "0x183392090")]
	public void NKHICBNDNPN(T GGHBBCGIKPJ, U KMIEKFALHHB, V PKIAPNEHKCP, W EPJNHAFGAON, X MIKJHKLKLDH, Y EJBKGAHMBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x33916A0", Offset = "0x3390AA0", VA = "0x1833916A0", Slot = "4")]
	public override void LOAILDHBBCJ(object[] KBOOOAILJFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3391D30", Offset = "0x3391130", VA = "0x183391D30")]
	public static global::JBIOEMJINKF<T, U, V, W, X, Y> MMONCNIPLKJ(global::JBIOEMJINKF<T, U, V, W, X, Y> INFMHMFOGBI, Action<T, U, V, W, X, Y> ENOAFIICPMH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3391290", Offset = "0x3390690", VA = "0x183391290")]
	public static global::JBIOEMJINKF<T, U, V, W, X, Y> FDINAEPEOCM(global::JBIOEMJINKF<T, U, V, W, X, Y> INFMHMFOGBI, Action<T, U, V, W, X, Y> ENOAFIICPMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct CLLEJBKPGNC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class ENMAEPAMDHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public ENMAEPAMDHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1C67650", Offset = "0x1C66A50", VA = "0x181C67650")]
		internal void KHMFEHGHALN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> JNDELHFJGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private int GBPILDOPAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private int NCJGJCLDHDA;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x10F9EC0", Offset = "0x10F92C0", VA = "0x1810F9EC0")]
	private CLLEJBKPGNC(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> KHAECKHFOLF, int KKFHLMGPOFG, int EKJOEHFFLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3C97A80", Offset = "0x3C96E80", VA = "0x183C97A80")]
	public static global::CLLEJBKPGNC<T> FHHJOGLDILM()
	{
		return default(global::CLLEJBKPGNC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3C98F00", Offset = "0x3C98300", VA = "0x183C98F00")]
	public (int, int, Task<T>) MELMHAFJAII(int MECBOLDGBGO, [Optional] CancellationToken EMJFDFLJKFG, double BLFHJAPLEGL = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3C97EB0", Offset = "0x3C972B0", VA = "0x183C97EB0")]
	public void IAABKIDGKAA(int MECBOLDGBGO, int EKJOEHFFLAG, in T LGNNINPIMGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class CFBBIMKAPHE
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6F409C0", Offset = "0x6F3FDC0", VA = "0x186F409C0")]
	public static global::CLLEJBKPGNC<CPKDLGGKAMN> FHHJOGLDILM()
	{
		return default(global::CLLEJBKPGNC<CPKDLGGKAMN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6F40A10", Offset = "0x6F3FE10", VA = "0x186F40A10")]
	public static void IAABKIDGKAA(this in global::CLLEJBKPGNC<CPKDLGGKAMN> LGKAJJKAMAG, int MECBOLDGBGO, int EKJOEHFFLAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DefaultMember("Item")]
public class MACILFMEBMA<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Dictionary<TKey, TVal> INFJJGLPHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly Dictionary<TVal, TKey> MJECJKFONBA;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int KLCJBBHGHFA
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x279A3F0", Offset = "0x27997F0", VA = "0x18279A3F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool MNGNEMEDFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7FB3B0", Offset = "0x7FA7B0", VA = "0x1807FB3B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public ICollection<TKey> GFKCLPNOLME
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x279AD70", Offset = "0x279A170", VA = "0x18279AD70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ICollection<TVal> OEBIMCNMIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x354B370", Offset = "0x354A770", VA = "0x18354B370", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public TVal KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4769850", Offset = "0x4768C50", VA = "0x184769850", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x47698C0", Offset = "0x4768CC0", VA = "0x1847698C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TKey KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4768740", Offset = "0x4767B40", VA = "0x184768740")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4768D70", Offset = "0x4768170", VA = "0x184768D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x47687F0", Offset = "0x4767BF0", VA = "0x1847687F0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4769680", Offset = "0x4768A80", VA = "0x184769680", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4768690", Offset = "0x4767A90", VA = "0x184768690", Slot = "9")]
	public void Add(TKey LOLIOKKJLEH, TVal EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x47686D0", Offset = "0x4767AD0", VA = "0x1847686D0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> NFFDNBMMLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4768850", Offset = "0x4767C50", VA = "0x184768850", Slot = "8")]
	public bool ContainsKey(TKey LOLIOKKJLEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x4768880", Offset = "0x4767C80", VA = "0x184768880", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> NFFDNBMMLPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x25E50B0", Offset = "0x25E44B0", VA = "0x1825E50B0", Slot = "10")]
	public bool Remove(TKey LOLIOKKJLEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x4769650", Offset = "0x4768A50", VA = "0x184769650", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> NFFDNBMMLPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x309C3A0", Offset = "0x309B7A0", VA = "0x18309C3A0", Slot = "11")]
	public bool TryGetValue(TKey LOLIOKKJLEH, out TVal EOEKGHMNIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2F53640", Offset = "0x2F52A40", VA = "0x182F53640", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x47688E0", Offset = "0x4767CE0", VA = "0x1847688E0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] BIBDBFOMNHM, int JMKONIJDHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x4768E50", Offset = "0x4768250", VA = "0x184768E50")]
	public void MGOOIKEIGMG(TVal NLNMFNDNKJH, TKey LOLIOKKJLEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x4768ED0", Offset = "0x47682D0", VA = "0x184768ED0")]
	public void MGOOIKEIGMG(KeyValuePair<TVal, TKey> NFFDNBMMLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x4768B00", Offset = "0x4767F00", VA = "0x184768B00")]
	public bool HIGOBODMDFO(TVal LOLIOKKJLEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x4768E10", Offset = "0x4768210", VA = "0x184768E10")]
	public bool MEIKKLBJCPM(KeyValuePair<TVal, TKey> NFFDNBMMLPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x47685C0", Offset = "0x47679C0", VA = "0x1847685C0")]
	public bool AJCNBIMBJPF(TVal LOLIOKKJLEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x47685C0", Offset = "0x47679C0", VA = "0x1847685C0")]
	public bool AJCNBIMBJPF(KeyValuePair<TVal, TKey> NFFDNBMMLPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x4768780", Offset = "0x4767B80", VA = "0x184768780")]
	public bool CIAJMCMLAHH(TVal LOLIOKKJLEH, out TKey EOEKGHMNIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x4768940", Offset = "0x4767D40", VA = "0x184768940")]
	public IEnumerator<KeyValuePair<TVal, TKey>> FJNDPEOFMKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x4768FC0", Offset = "0x47683C0", VA = "0x184768FC0")]
	private void NLKNAGJIHJM(TKey LOLIOKKJLEH, TVal NLNMFNDNKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x4768B40", Offset = "0x4767F40", VA = "0x184768B40")]
	private void HJJMEBLHAMP(TKey LOLIOKKJLEH, TVal NLNMFNDNKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x4769230", Offset = "0x4768630", VA = "0x184769230")]
	private bool OIPBNJLCHMO(TKey LOLIOKKJLEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x4769480", Offset = "0x4768880", VA = "0x184769480")]
	private bool OIPBNJLCHMO(TVal NLNMFNDNKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x4769770", Offset = "0x4768B70", VA = "0x184769770")]
	public MACILFMEBMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DefaultMember("Item")]
public class JKFIGPLEOEE<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly Func<Internal, External> ONDJAAPIBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly Func<External, Internal> FDDPONPKLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private IList<Internal> FGINDFDIDLG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IList<Internal> HFAJNAPEJGP
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x855AE0", Offset = "0x854EE0", VA = "0x180855AE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x855AF0", Offset = "0x854EF0", VA = "0x180855AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool MNGNEMEDFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA5F540", Offset = "0xA5E940", VA = "0x180A5F540", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA287D0", Offset = "0xA27BD0", VA = "0x180A287D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public External KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x308DF30", Offset = "0x308D330", VA = "0x18308DF30", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x308DFD0", Offset = "0x308D3D0", VA = "0x18308DFD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int KLCJBBHGHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x308DED0", Offset = "0x308D2D0", VA = "0x18308DED0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x308DE40", Offset = "0x308D240", VA = "0x18308DE40")]
	public JKFIGPLEOEE(Func<Internal, External> ONDJAAPIBMM, Func<External, Internal> FDDPONPKLDK, bool FMCAIONNHHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x308DB80", Offset = "0x308CF80", VA = "0x18308DB80", Slot = "6")]
	public int IndexOf(External NFFDNBMMLPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x308D800", Offset = "0x308CC00", VA = "0x18308D800", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x308D860", Offset = "0x308CC60", VA = "0x18308D860", Slot = "13")]
	public bool Contains(External NFFDNBMMLPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x308D8F0", Offset = "0x308CCF0", VA = "0x18308D8F0", Slot = "14")]
	public void CopyTo(External[] BIBDBFOMNHM, int JMKONIJDHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x308D770", Offset = "0x308CB70", VA = "0x18308D770", Slot = "11")]
	public void Add(External NFFDNBMMLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x308DC70", Offset = "0x308D070", VA = "0x18308DC70", Slot = "7")]
	public void Insert(int CJOLACIBAJH, External NFFDNBMMLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x308DD80", Offset = "0x308D180", VA = "0x18308DD80", Slot = "15")]
	public bool Remove(External NFFDNBMMLPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x308DD10", Offset = "0x308D110", VA = "0x18308DD10", Slot = "8")]
	public void RemoveAt(int CJOLACIBAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x308DB10", Offset = "0x308CF10", VA = "0x18308DB10", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x308DE10", Offset = "0x308D210", VA = "0x18308DE10", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public class BKAIBKHMKJJ<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly Func<Internal, External> ONDJAAPIBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private IReadOnlyList<Internal> FGINDFDIDLG;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<Internal> HFAJNAPEJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x811A60", Offset = "0x810E60", VA = "0x180811A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool MNGNEMEDFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x811730", Offset = "0x810B30", VA = "0x180811730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public External KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x37E93E0", Offset = "0x37E87E0", VA = "0x1837E93E0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int KLCJBBHGHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x37E9380", Offset = "0x37E8780", VA = "0x1837E9380", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x25DFEC0", Offset = "0x25DF2C0", VA = "0x1825DFEC0")]
	public BKAIBKHMKJJ(Func<Internal, External> ONDJAAPIBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x37E9330", Offset = "0x37E8730", VA = "0x1837E9330")]
	public BKAIBKHMKJJ(IReadOnlyList<Internal> FGINDFDIDLG, Func<Internal, External> ONDJAAPIBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x37E9110", Offset = "0x37E8510", VA = "0x1837E9110")]
	public void HIOGEOEHHAM(External[] BIBDBFOMNHM, int JMKONIJDHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x37E90A0", Offset = "0x37E84A0", VA = "0x1837E90A0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2F9BF50", Offset = "0x2F9B350", VA = "0x182F9BF50", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[DefaultMember("Item")]
public class OECBHPBDGAL<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyList<Internal> FGINDFDIDLG;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public IReadOnlyList<Internal> HFAJNAPEJGP
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x87D040", Offset = "0x87C440", VA = "0x18087D040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool MNGNEMEDFBP
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x811730", Offset = "0x810B30", VA = "0x180811730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public External KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B5F0", Offset = "0x3F2A9F0", VA = "0x183F2B5F0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int KLCJBBHGHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B590", Offset = "0x3F2A990", VA = "0x183F2B590", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x25DFEC0", Offset = "0x25DF2C0", VA = "0x1825DFEC0")]
	public OECBHPBDGAL(IReadOnlyList<Internal> FGINDFDIDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3F2B4F0", Offset = "0x3F2A8F0", VA = "0x183F2B4F0")]
	public bool MEIKKLBJCPM(External NFFDNBMMLPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3F2B2C0", Offset = "0x3F2A6C0", VA = "0x183F2B2C0")]
	public void HIOGEOEHHAM(External[] BIBDBFOMNHM, int JMKONIJDHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3F2B250", Offset = "0x3F2A650", VA = "0x183F2B250", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x308DE10", Offset = "0x308D210", VA = "0x18308DE10", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class LGABAFLDHKL<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TResult> KMMCHGFHCAF(TRequest OLCOAAKJEBF, CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum LNOFOPDDLKK
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class EEFOHBPAMHE
	{
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private const float JLANJEHCLAJ = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TimeSpan DAFOCAMBPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int AKJHGIKDLOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public LNOFOPDDLKK JKCLHPHGJPP;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly EEFOHBPAMHE JCHJHPLBGGN;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float BEBMHEEBEAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x349A040", Offset = "0x3499440", VA = "0x18349A040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan KLIBODKMFBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x349A0B0", Offset = "0x34994B0", VA = "0x18349A0B0")]
		public EEFOHBPAMHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private readonly struct FMLDDPHGOON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly TRequest OLCOAAKJEBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public readonly CancellationToken EMJFDFLJKFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public readonly TaskCompletionSource<TResult> EJFHLNMABLP;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x389ADC0", Offset = "0x389A1C0", VA = "0x18389ADC0")]
		public FMLDDPHGOON(TRequest OLCOAAKJEBF, TaskCompletionSource<TResult> EJFHLNMABLP, CancellationToken EMJFDFLJKFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class COFIHKNCLHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public COFIHKNCLHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x279A3F0", Offset = "0x27997F0", VA = "0x18279A3F0")]
		internal void AOFDCNBBGLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class KJEGHCAAPIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public global::LGABAFLDHKL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public KJEGHCAAPIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2F5ED40", Offset = "0x2F5E140", VA = "0x182F5ED40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class HOHOACHGAGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public global::LGABAFLDHKL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private FMLDDPHGOON <req>5__1;

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
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public HOHOACHGAGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3238F10", Offset = "0x3238310", VA = "0x183238F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CancellationTokenSource DGKGIAKCEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly List<FMLDDPHGOON> PIANCEILHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly EEFOHBPAMHE JPKLEOPLIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly KMMCHGFHCAF DOHEFANHAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Task KKEGJGJHCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int EGDDFHEIKNC;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3B27070", Offset = "0x3B26470", VA = "0x183B27070")]
	public LGABAFLDHKL(KMMCHGFHCAF DOHEFANHAEB, [Optional] EEFOHBPAMHE JPKLEOPLIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3B26A10", Offset = "0x3B25E10", VA = "0x183B26A10")]
	public Task<TResult> LELFAAPMNAF(TRequest OLCOAAKJEBF, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3B26320", Offset = "0x3B25720", VA = "0x183B26320")]
	private void JJFMEHJAIHJ(FMLDDPHGOON FKBODFBOHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3B258F0", Offset = "0x3B24CF0", VA = "0x183B258F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::LGABAFLDHKL<, >.KJEGHCAAPIJ))]
	private Task GNGNFAPEEMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3B25F70", Offset = "0x3B25370", VA = "0x183B25F70")]
	private FMLDDPHGOON HJPLNKAJKMN()
	{
		return default(FMLDDPHGOON);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3B26500", Offset = "0x3B25900", VA = "0x183B26500")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::LGABAFLDHKL<, >.HOHOACHGAGB))]
	private Task KNOEBGHFOCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3B25370", Offset = "0x3B24770", VA = "0x183B25370")]
	private void CKFKMODOCCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3B25610", Offset = "0x3B24A10", VA = "0x183B25610", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface BNPLEGFEIOO
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface MNCNGNNMPMD<T> : BNPLEGFEIOO
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	T DEMEBAENMIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool GCNIMLALNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string CKOPPMBDMPF
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
	global::MNCNGNNMPMD<T> MOMLJLHHAEA(Action<T> DILCIABPOGM);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::MNCNGNNMPMD<T> PDEEGMLNDEC(Action<T> DILCIABPOGM);

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::MNCNGNNMPMD<T> AGJDOMJFLLA(Action<T, T> FDGOAPEPHDH);

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::MNCNGNNMPMD<T> OAOKFBGHIHB(Action<T, T> FDGOAPEPHDH);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::MNCNGNNMPMD<T> FDELMICJJLI(Action<string> HHFKMFNIPGO);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::MNCNGNNMPMD<T> ONJNJPFINJC(Action<string> HHFKMFNIPGO);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class DPLOMKCBDDE<T> : global::MNCNGNNMPMD<T>, BNPLEGFEIOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private global::BHKLKEHGEFA<T, T> PGPGAJIIJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private global::KDDMDDMMGFF<T> DDGBBKHFIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private global::KDDMDDMMGFF<string> IOJHNMLENLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private string OAAMGJCNLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private T LGNNINPIMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool HKLAMIOFKMK;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T DEMEBAENMIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xB56C30", Offset = "0xB56030", VA = "0x180B56C30", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x25DDD60", Offset = "0x25DD160", VA = "0x1825DDD60", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool GCNIMLALNDH
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA39BA0", Offset = "0xA38FA0", VA = "0x180A39BA0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string CKOPPMBDMPF
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x872B10", Offset = "0x871F10", VA = "0x180872B10", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x19438F0", Offset = "0x1942CF0", VA = "0x1819438F0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x3C15D00", Offset = "0x3C15100", VA = "0x183C15D00")]
	private void BHKFGKHNKPG(T PCDLJHELPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x3C15EF0", Offset = "0x3C152F0", VA = "0x183C15EF0")]
	private void MOJPBHBBONJ(string HGJOENLBDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3C15E40", Offset = "0x3C15240", VA = "0x183C15E40")]
	public void LLMEAOAJOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3C15CB0", Offset = "0x3C150B0", VA = "0x183C15CB0", Slot = "6")]
	public global::MNCNGNNMPMD<T> AGJDOMJFLLA(Action<T, T> FDGOAPEPHDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3C16030", Offset = "0x3C15430", VA = "0x183C16030", Slot = "7")]
	public global::MNCNGNNMPMD<T> OAOKFBGHIHB(Action<T, T> FDGOAPEPHDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3C15FA0", Offset = "0x3C153A0", VA = "0x183C15FA0", Slot = "4")]
	public global::MNCNGNNMPMD<T> MOMLJLHHAEA(Action<T> FDGOAPEPHDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3C160F0", Offset = "0x3C154F0", VA = "0x183C160F0", Slot = "5")]
	public global::MNCNGNNMPMD<T> PDEEGMLNDEC(Action<T> DILCIABPOGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3C15DA0", Offset = "0x3C151A0", VA = "0x183C15DA0", Slot = "8")]
	public global::MNCNGNNMPMD<T> FDELMICJJLI(Action<string> HHFKMFNIPGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3C16080", Offset = "0x3C15480", VA = "0x183C16080", Slot = "9")]
	public global::MNCNGNNMPMD<T> ONJNJPFINJC(Action<string> HHFKMFNIPGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3C16140", Offset = "0x3C15540", VA = "0x183C16140")]
	public DPLOMKCBDDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class FHDGDDLOBEC
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class ONHPHHLMJJO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public global::MNCNGNNMPMD<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public global::FACCBPHKIDN<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public ONHPHHLMJJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x42906A0", Offset = "0x428FAA0", VA = "0x1842906A0")]
		internal void PPIBHNMIMKJ(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x2FB8300", Offset = "0x2FB7700", VA = "0x182FB8300")]
	public static global::CBFHNKNAJIN<T> IHBHDLPBOOO<T>(this global::MNCNGNNMPMD<T> NNHPOLMMPIL, Action<T> JGHGBFJPJFD)
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
			[Cpp2IlInjected.Address(RVA = "0x3AEBA70", Offset = "0x3AEAE70", VA = "0x183AEBA70")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6EDA810", Offset = "0x6ED9C10", VA = "0x186EDA810")]
		public SerializedGuid(in Guid LKDOBHNFOAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F46E40", Offset = "0x6F46240", VA = "0x186F46E40")]
		public static SerializedGuid KFBJHMMNMBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F46ED0", Offset = "0x6F462D0", VA = "0x186F46ED0")]
		public static SerializedGuid LLCGDEBGDNO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F46DB0", Offset = "0x6F461B0", VA = "0x186F46DB0")]
		public bool IMMNJJKMOPK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6EDA7E0", Offset = "0x6ED9BE0", VA = "0x186EDA7E0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F46FF0", Offset = "0x6F463F0", VA = "0x186F46FF0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F46F60", Offset = "0x6F46360", VA = "0x186F46F60")]
		public bool MAJHKDDMOKI(in Guid LKDOBHNFOAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F46C20", Offset = "0x6F46020", VA = "0x186F46C20", Slot = "7")]
		public bool Equals(SerializedGuid CCJMBGJFGLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F46CD0", Offset = "0x6F460D0", VA = "0x186F46CD0", Slot = "0")]
		public override bool Equals(object GHHNOPFOGCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6EDA730", Offset = "0x6ED9B30", VA = "0x186EDA730", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6EDA570", Offset = "0x6ED9970", VA = "0x186EDA570", Slot = "6")]
		public int CompareTo(SerializedGuid CCJMBGJFGLH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class IMONNADIJPL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly Type JBALCMMFOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly string COIAOMABAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool KGJGBIMNOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly bool HPAPOEMEFBK;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F423C0", Offset = "0x6F417C0", VA = "0x186F423C0")]
	public IMONNADIJPL(Type JAGBBFEBDHC, string MIFFHCDBJOK, bool MJJNEBBCEOJ = false, bool DOOKMICLEBN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[DefaultMember("Item")]
public class EKFPDHJBHPP<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly List<T> FGINDFDIDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private HashSet<T> NKAIBFCCOOJ;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int KLCJBBHGHFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x279A3F0", Offset = "0x27997F0", VA = "0x18279A3F0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool MNGNEMEDFBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CD0", Offset = "0x7F20D0", VA = "0x1807F2CD0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public T KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2CA9CC0", Offset = "0x2CA90C0", VA = "0x182CA9CC0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x375B530", Offset = "0x375A930", VA = "0x18375B530", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x375ABE0", Offset = "0x3759FE0", VA = "0x18375ABE0", Slot = "11")]
	public void Add(T NFFDNBMMLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x375AA90", Offset = "0x3759E90", VA = "0x18375AA90")]
	public bool ADFCMLEOCDN(T NFFDNBMMLPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x375B280", Offset = "0x375A680", VA = "0x18375B280", Slot = "15")]
	public bool Remove(T NFFDNBMMLPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x375AE70", Offset = "0x375A270", VA = "0x18375AE70", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3607550", Offset = "0x3606950", VA = "0x183607550", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x375ADB0", Offset = "0x375A1B0", VA = "0x18375ADB0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x375AE10", Offset = "0x375A210", VA = "0x18375AE10", Slot = "13")]
	public bool Contains(T NFFDNBMMLPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x375AE40", Offset = "0x375A240", VA = "0x18375AE40", Slot = "14")]
	public void CopyTo(T[] BIBDBFOMNHM, int JMKONIJDHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x375AEF0", Offset = "0x375A2F0", VA = "0x18375AEF0", Slot = "6")]
	public int IndexOf(T NFFDNBMMLPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x375AFF0", Offset = "0x375A3F0", VA = "0x18375AFF0", Slot = "7")]
	public void Insert(int CJOLACIBAJH, T NFFDNBMMLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x375B0E0", Offset = "0x375A4E0", VA = "0x18375B0E0", Slot = "8")]
	public void RemoveAt(int CJOLACIBAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x375AC10", Offset = "0x375A010", VA = "0x18375AC10")]
	public void CNKIPOADCNK(Predicate<T> KFEPNPJEKON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x375B0B0", Offset = "0x375A4B0", VA = "0x18375B0B0")]
	public void PFDOMCFIJGE(Comparison<T> HGFNEKEGDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x375B390", Offset = "0x375A790", VA = "0x18375B390")]
	public EKFPDHJBHPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class HOINJBJOMBN
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F42090", Offset = "0x6F41490", VA = "0x186F42090")]
	public static Vector3 FGJPEEJAEIJ(this GameObject NJMBJKHNCBN, float POOBGMKOHMD)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class HOEEABIDHDB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly Type JBALCMMFOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly string COIAOMABAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool KGJGBIMNOCO;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6F42030", Offset = "0x6F41430", VA = "0x186F42030")]
	public HOEEABIDHDB(Type JAGBBFEBDHC, string MIFFHCDBJOK, bool MJJNEBBCEOJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class AFPBKDJPFCO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6F406D0", Offset = "0x6F3FAD0", VA = "0x186F406D0")]
	public AFPBKDJPFCO(string HGJOENLBDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6F40740", Offset = "0x6F3FB40", VA = "0x186F40740")]
	public AFPBKDJPFCO(string HGJOENLBDNH, Exception LALNAHCKPJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class OOLMDLFIJHM
{
	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6F43E70", Offset = "0x6F43270", VA = "0x186F43E70")]
	[NotNull]
	public static byte[] NEPGMKAEHLF(this MCAKLHNHDFK PKOLIHAPNLJ, byte[] DFEAKDKDNNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F43C30", Offset = "0x6F43030", VA = "0x186F43C30")]
	[NotNull]
	public static byte[] NEPGMKAEHLF(this MCAKLHNHDFK PKOLIHAPNLJ, HashAlgorithmName ILAICBNBOKL, byte[] DFEAKDKDNNE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface MCAKLHNHDFK
{
	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash IMDHKCCMAPF);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface LEKBKLMMEEC : MCAKLHNHDFK
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[CanBeNull]
	byte[] AHBFINOPKAH
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
	byte[] HDAJJMGFLJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	UnityEngine.Object MLDJBMMDKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class JNGDBIIDANJ
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class OGPDKLMJOFJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F43BB0", Offset = "0x6F42FB0", VA = "0x186F43BB0")]
		public OGPDKLMJOFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F43B50", Offset = "0x6F42F50", VA = "0x186F43B50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private const byte JFCNFHAEFOJ = 1;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const byte NHPJHPDGOAP = 0;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly ArrayPool<byte> NIDEGOOHNOH;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static bool OENKJMPCFNL;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x20D6F50", Offset = "0x20D6350", VA = "0x1820D6F50")]
	[Conditional("UNITY_EDITOR")]
	private static void GKGNDAMMIIO<T>(params T[] MAKCNBMBHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F42F70", Offset = "0x6F42370", VA = "0x186F42F70")]
	public static IDisposable IKAIIFKGLJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F42E80", Offset = "0x6F42280", VA = "0x186F42E80")]
	public static void HPGIKKKNNFD(this IncrementalHash NNMFLEBPMGJ, [CanBeNull] GameObject NJMBJKHNCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x20D72D0", Offset = "0x20D66D0", VA = "0x1820D72D0")]
	public static void HPGIKKKNNFD<T>(this IncrementalHash NNMFLEBPMGJ, [CanBeNull] T COGHLJDPMKN) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x20D7240", Offset = "0x20D6640", VA = "0x1820D7240")]
	public static void HHEOLEABAGF<T>(this IncrementalHash NNMFLEBPMGJ, [CanBeNull] T PKOLIHAPNLJ) where T : MCAKLHNHDFK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x20D6400", Offset = "0x20D5800", VA = "0x1820D6400")]
	public static void BIIBINDNBJC<T>(this IncrementalHash NNMFLEBPMGJ, [CanBeNull] IList<T> PANMEHAFBBA) where T : MCAKLHNHDFK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F42470", Offset = "0x6F41870", VA = "0x186F42470")]
	private static bool CINDOLJFEEH([CanBeNull] MCAKLHNHDFK PKOLIHAPNLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F43010", Offset = "0x6F42410", VA = "0x186F43010")]
	public static void IKCKAKAIMFL(this IncrementalHash IMDHKCCMAPF, [CanBeNull] string EEJCJJFDOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F42970", Offset = "0x6F41D70", VA = "0x186F42970")]
	public static void GJPANGGEGAM(this IncrementalHash IMDHKCCMAPF, long HICLMOGDNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F42CB0", Offset = "0x6F420B0", VA = "0x186F42CB0")]
	public static void HEIJCOINEHM(this IncrementalHash IMDHKCCMAPF, int KKEPKKLEMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F42740", Offset = "0x6F41B40", VA = "0x186F42740")]
	public static void FJINOHFHJBO(this IncrementalHash IMDHKCCMAPF, short BIPMNPEFEKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F42B40", Offset = "0x6F41F40", VA = "0x186F42B40")]
	public static void HDBLBMCLHJI(this IncrementalHash IMDHKCCMAPF, byte BBPAPANELJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F42500", Offset = "0x6F41900", VA = "0x186F42500")]
	public static void DEDMENGFKNK(this IncrementalHash IMDHKCCMAPF, bool GAOJPIJHEAH, bool IEGOEKEMHFM = false, bool OGHAGJDGFDJ = false, bool HFBHBHFNDJI = false, bool DDGDOGMDJID = false, bool GLMHMDPPIEH = false, bool COINIIMNNMH = false, bool PCJADJNNKBA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x20D6860", Offset = "0x20D5C60", VA = "0x1820D6860")]
	public static void FPKKEBIMPCM<T>(this IncrementalHash IMDHKCCMAPF, T NFPNNPGKLPI) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F42910", Offset = "0x6F41D10", VA = "0x186F42910")]
	public static void FMJNBMPGFIH(this IncrementalHash IMDHKCCMAPF, float OILBGMMJIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F43240", Offset = "0x6F42640", VA = "0x186F43240")]
	public static void MGJHDOGKBGI(this IncrementalHash IMDHKCCMAPF, double FBAAEAHNDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F43460", Offset = "0x6F42860", VA = "0x186F43460")]
	public static void ONOCJDIECDF(this IncrementalHash IMDHKCCMAPF, ulong KPANKABJBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F43070", Offset = "0x6F42470", VA = "0x186F43070")]
	public static void JLDBGAKMLKF(this IncrementalHash IMDHKCCMAPF, uint NIFFFDJMMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F426D0", Offset = "0x6F41AD0", VA = "0x186F426D0")]
	public static void ELNFPBCBFGH(this IncrementalHash IMDHKCCMAPF, ushort MIPEPOFHMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F430D0", Offset = "0x6F424D0", VA = "0x186F430D0")]
	public static void KKPKHAMJIAJ(this IncrementalHash IMDHKCCMAPF, Vector3 NPPMBCBPONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F432A0", Offset = "0x6F426A0", VA = "0x186F432A0")]
	public static void NBKACGMKGHF(this IncrementalHash IMDHKCCMAPF, Quaternion JDJKHKAPKCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class POJJADFOLBP
{
	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F456E0", Offset = "0x6F44AE0", VA = "0x186F456E0")]
	[NotNull]
	public static byte[] NEPGMKAEHLF(this LEKBKLMMEEC AMCLGONCMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F45670", Offset = "0x6F44A70", VA = "0x186F45670")]
	[NotNull]
	public static byte[] NEPGMKAEHLF(this LEKBKLMMEEC AMCLGONCMIH, HashAlgorithmName ILAICBNBOKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F453C0", Offset = "0x6F447C0", VA = "0x186F453C0")]
	public static bool DDFHKABNOFM([CanBeNull] this LEKBKLMMEEC AMCLGONCMIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F45220", Offset = "0x6F44620", VA = "0x186F45220")]
	public static bool DDFHKABNOFM([CanBeNull] this LEKBKLMMEEC AMCLGONCMIH, out string OAAMGJCNLFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F45750", Offset = "0x6F44B50", VA = "0x186F45750")]
	private static string PBJCPEHKMDM([CanBeNull] byte[] FDJAKBCCGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F45550", Offset = "0x6F44950", VA = "0x186F45550")]
	private static bool EELOELACEOC([NotNull] LEKBKLMMEEC AMCLGONCMIH, [CanBeNull] out byte[] LMHDKDMJKBB, [CanBeNull] out byte[] PNJNCIEKCLC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class NNDOHKCNEMF<TTask, T> : global::KFBENPHJFEN<T>, KBEAHKJNPMN, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class BJHAMGOGKBP
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
			public BJHAMGOGKBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
			public <<-ctor>g__AwaitThenTransformTaskResult|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x28ACA90", Offset = "0x28ABE90", VA = "0x1828ACA90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
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
		public global::NNDOHKCNEMF<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public BJHAMGOGKBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x37E4A90", Offset = "0x37E3E90", VA = "0x1837E4A90")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(global::NNDOHKCNEMF<, >.BJHAMGOGKBP.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> GMMPGANCMCD(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static bool MFJCHLHHKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly Task<T> AFHGFPNANEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	protected readonly CancellationTokenSource KJMNKMJBOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool OFAGMECEDPC;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Task<T> NOLFHMGACNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Task ACKFFHOOGGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public global::CBFHNKNAJIN<T> FMLDFLIAFEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private FKADHPEOOEO DBGBIJPFDHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3048E90", Offset = "0x3048290", VA = "0x183048E90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool LBFDKGPBIJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA5F540", Offset = "0xA5E940", VA = "0x180A5F540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x3C1C940", Offset = "0x3C1BD40", VA = "0x183C1C940")]
	static NNDOHKCNEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x3C1CCA0", Offset = "0x3C1C0A0", VA = "0x183C1CCA0")]
	protected NNDOHKCNEMF(TTask AFHGFPNANEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x3C1C8D0", Offset = "0x3C1BCD0", VA = "0x183C1C8D0", Slot = "1")]
	~NNDOHKCNEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x3C1C8A0", Offset = "0x3C1BCA0", VA = "0x183C1C8A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x3C1C500", Offset = "0x3C1B900", VA = "0x183C1C500")]
	private void BPGEOBNBMJK(bool OHPEBBADOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T HMHBONGCHJE(TTask JMOMGPFDODI);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void DHJJBILNOAM();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class DHKGDFOMKBB : global::GLMONFOBHEL<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6F40C90", Offset = "0x6F40090", VA = "0x186F40C90")]
	public DHKGDFOMKBB(Exception FELJPOLMEJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class GLMONFOBHEL<T> : global::KFBENPHJFEN<T>, KBEAHKJNPMN, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public Task<T> NOLFHMGACNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private Task ACKFFHOOGGF
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1A92430", Offset = "0x1A91830", VA = "0x181A92430", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public global::CBFHNKNAJIN<T> FMLDFLIAFEK
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private FKADHPEOOEO DBGBIJPFDHE
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x19432E0", Offset = "0x19426E0", VA = "0x1819432E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x350CA10", Offset = "0x350BE10", VA = "0x18350CA10")]
	public GLMONFOBHEL(Exception FELJPOLMEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface KBEAHKJNPMN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	[NotNull]
	Task NOLFHMGACNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	[NotNull]
	FKADHPEOOEO FMLDFLIAFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface KFBENPHJFEN<T> : KBEAHKJNPMN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	[NotNull]
	new Task<T> NOLFHMGACNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	new global::CBFHNKNAJIN<T> FMLDFLIAFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class JJAHKDGJFGB : global::ABFDLCDPJOO<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6F42430", Offset = "0x6F41830", VA = "0x186F42430")]
	public JJAHKDGJFGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class ABFDLCDPJOO<T> : global::KFBENPHJFEN<T>, KBEAHKJNPMN, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Task<T> NOLFHMGACNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private Task ACKFFHOOGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1A92430", Offset = "0x1A91830", VA = "0x181A92430", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public global::CBFHNKNAJIN<T> FMLDFLIAFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private FKADHPEOOEO DBGBIJPFDHE
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x19432E0", Offset = "0x19426E0", VA = "0x1819432E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4A21340", Offset = "0x4A20740", VA = "0x184A21340")]
	public ABFDLCDPJOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public sealed class KIHLHEFAEEL : global::IECBLAAJLIH<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class NAPDDCNAONC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public Action<KIHLHEFAEEL> callback;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NAPDDCNAONC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6F439A0", Offset = "0x6F42DA0", VA = "0x186F439A0")]
		internal void HEAEAINAMDE(global::IECBLAAJLIH<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6F436C0", Offset = "0x6F42AC0", VA = "0x186F436C0")]
	public KIHLHEFAEEL([Optional] string BOIIKOAFDGP, [Optional] int? BLNGJFMGMCB, [Optional] Stopwatch FPHLBBLLCJH, [Optional] Action<string, MNOLBOHJOLO> JGCNCAABOIA, [Optional] Action<string, MNOLBOHJOLO> GPCBOJJPEAB, [Optional] Action<KIHLHEFAEEL> PPIPKEBFDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6F435E0", Offset = "0x6F429E0", VA = "0x186F435E0")]
	private static Action<global::IECBLAAJLIH<string>> ADPDGFIAGEF(Action<KIHLHEFAEEL> JGHGBFJPJFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class FBDMHFFEIOE<TKey> : global::DOGJKJLEJPH<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class IKFBGJBNGJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public CCIKLGFEKAK keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public IKFBGJBNGJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2792960", Offset = "0x2791D60", VA = "0x182792960")]
		internal string DNHDLDDONDN(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5127120", Offset = "0x5126520", VA = "0x185127120", Slot = "5")]
	protected override string EEKELCIECGN(global::IECBLAAJLIH<TKey> JLHLJFGHKCP, CCIKLGFEKAK OAJBHOLLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x36A9550", Offset = "0x36A8950", VA = "0x1836A9550")]
	public FBDMHFFEIOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class FOJNCIAJOKL<TKey> : global::LAMMKENDCOA<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate string EKFEBIIPHIE(TKey LOLIOKKJLEH);

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private const int LANDBIGLDEF = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly string GLNFCHNCOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly double ECMFAMHMFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly bool HBCAHAOGPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly int HKAGCDEAIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly ISet<string> LHODLLFCDCC;

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x38A2BD0", Offset = "0x38A1FD0", VA = "0x1838A2BD0")]
	private static string LMABNJHMBGB(TKey LOLIOKKJLEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x38A2EA0", Offset = "0x38A22A0", VA = "0x1838A2EA0")]
	public FOJNCIAJOKL(string GLNFCHNCOLO = "F2", double ECMFAMHMFEG = double.MaxValue, bool HBCAHAOGPGM = false, int HKAGCDEAIDF = int.MaxValue, [Optional] ISet<string> LHODLLFCDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x38A2460", Offset = "0x38A1860", VA = "0x1838A2460", Slot = "4")]
	public override Dictionary<string, string> BALEPNOHDLP(global::IECBLAAJLIH<TKey> JLHLJFGHKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x38A2DC0", Offset = "0x38A21C0", VA = "0x1838A2DC0")]
	private bool PCOJKBIEDMA(string KHACJEGKMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x38A2510", Offset = "0x38A1910", VA = "0x1838A2510")]
	public Dictionary<string, string> BALEPNOHDLP(global::IECBLAAJLIH<TKey> JLHLJFGHKCP, EKFEBIIPHIE OAJBHOLLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x38A2C10", Offset = "0x38A2010", VA = "0x1838A2C10")]
	private string MPODLPGIHGI(StringBuilder FGHNPLCEPPD, List<TKey> LHCHKHGOIML, EKFEBIIPHIE OAJBHOLLMDL, bool LOAHHIONBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x38A2A50", Offset = "0x38A1E50", VA = "0x1838A2A50")]
	private static void BILGNKEDMJI(StringBuilder PAPICDECPEM, string AKJIDBLJJJN, bool CCAHBNIIDDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public abstract class LAMMKENDCOA<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut BALEPNOHDLP(global::IECBLAAJLIH<TKey> JLHLJFGHKCP);

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
	protected LAMMKENDCOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public abstract class DOGJKJLEJPH<TKey> : global::LAMMKENDCOA<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public delegate string CCIKLGFEKAK(TKey LOLIOKKJLEH);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3C11A50", Offset = "0x3C10E50", VA = "0x183C11A50")]
	protected string GHKDENPOAKL(double NICDHEJECAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3C11B00", Offset = "0x3C10F00", VA = "0x183C11B00")]
	protected string NBMADECFFAJ(int JEINBBHDJEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3C11AC0", Offset = "0x3C10EC0", VA = "0x183C11AC0")]
	private static string LMABNJHMBGB(TKey LOLIOKKJLEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x3C119A0", Offset = "0x3C10DA0", VA = "0x183C119A0", Slot = "4")]
	public override string BALEPNOHDLP(global::IECBLAAJLIH<TKey> JLHLJFGHKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3C11870", Offset = "0x3C10C70", VA = "0x183C11870")]
	public string BALEPNOHDLP(global::IECBLAAJLIH<TKey> JLHLJFGHKCP, [NotNull] CCIKLGFEKAK OAJBHOLLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string EEKELCIECGN(global::IECBLAAJLIH<TKey> JLHLJFGHKCP, [NotNull] CCIKLGFEKAK OAJBHOLLMDL);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x308DE10", Offset = "0x308D210", VA = "0x18308DE10")]
	protected DOGJKJLEJPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public abstract class MABHEINALJO
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private class GNDKHLBLKIM : MABHEINALJO
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public static MABHEINALJO BGHJOACDLLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x6F419B0", Offset = "0x6F40DB0", VA = "0x186F419B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override DateTime MBPOLEJNNFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x6F41960", Offset = "0x6F40D60", VA = "0x186F41960", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public override float MCMBALLKAFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x1714D60", Offset = "0x1714160", VA = "0x181714D60", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6F41AB0", Offset = "0x6F40EB0", VA = "0x186F41AB0")]
		public GNDKHLBLKIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static MABHEINALJO GIBEABBJLGD;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static MABHEINALJO JCHJHPLBGGN
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6F43810", Offset = "0x6F42C10", VA = "0x186F43810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public abstract DateTime MBPOLEJNNFN
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public abstract float MCMBALLKAFD
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	protected MABHEINALJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class LEPALHJOMNC<TKey> : global::DOGJKJLEJPH<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct LMDMNDBCCFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public CCIKLGFEKAK keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static global::LEPALHJOMNC<TKey> BGHJOACDLLH;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private const int JMKBNHIEOEA = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly string[] JOBMMHAMAOC;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x32AC400", Offset = "0x32AB800", VA = "0x1832AC400")]
	private LEPALHJOMNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x32AB330", Offset = "0x32AA730", VA = "0x1832AB330", Slot = "5")]
	protected override string EEKELCIECGN(global::IECBLAAJLIH<TKey> JLHLJFGHKCP, CCIKLGFEKAK OAJBHOLLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x32AC210", Offset = "0x32AB610", VA = "0x1832AC210")]
	[CompilerGenerated]
	internal static string HKAHENLNIJH(string LFFGGPGDHAK, TKey LOLIOKKJLEH, ref LMDMNDBCCFH P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class IECBLAAJLIH<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public readonly struct MNOLBOHJOLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public readonly long BBPIFNOIIOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public readonly long LIBBMAIIDGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public readonly int BLNGJFMGMCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public readonly int DFJEDFLJLKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public readonly bool JMPLEPLGHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly string KNAAFCBCCMD;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x36C3650", Offset = "0x36C2A50", VA = "0x1836C3650")]
		public MNOLBOHJOLO(long BBPIFNOIIOH, int BLNGJFMGMCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x36C36C0", Offset = "0x36C2AC0", VA = "0x1836C36C0")]
		public MNOLBOHJOLO(long BBPIFNOIIOH, long LIBBMAIIDGL, int BLNGJFMGMCB, int DFJEDFLJLKA, bool JMPLEPLGHKE, string KNAAFCBCCMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x36C3430", Offset = "0x36C2830", VA = "0x1836C3430")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void BGCFCIFKCBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x36C35E0", Offset = "0x36C29E0", VA = "0x1836C35E0")]
		public int IFEACDIEKOE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x36C3630", Offset = "0x36C2A30", VA = "0x1836C3630")]
		public int INDAPILMHOO(int AOOOOGBCDBK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x36C3570", Offset = "0x36C2970", VA = "0x1836C3570")]
		public double HGDLPMDELPH()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x36C34B0", Offset = "0x36C28B0", VA = "0x1836C34B0")]
		public MNOLBOHJOLO ENFOHPJGJBK(long LIBBMAIIDGL, int DFJEDFLJLKA)
		{
			return default(MNOLBOHJOLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class MJNNFHEKAHC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public readonly TKey KGGJGJMDBPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly global::IECBLAAJLIH<TKey> JLHLJFGHKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private List<MJNNFHEKAHC> MNIOJDKBAOF;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string GCILCKIDHJK
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x25E1190", Offset = "0x25E0590", VA = "0x1825E1190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x32A1860", Offset = "0x32A0C60", VA = "0x1832A1860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public IEnumerable<MJNNFHEKAHC> ANNJFKHLGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x44E3D40", Offset = "0x44E3140", VA = "0x1844E3D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public MNOLBOHJOLO NEKBIBKEGDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x2105890", Offset = "0x2104C90", VA = "0x182105890")]
			[CompilerGenerated]
			get
			{
				return default(MNOLBOHJOLO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x44E3D60", Offset = "0x44E3160", VA = "0x1844E3D60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x44E3EA0", Offset = "0x44E32A0", VA = "0x1844E3EA0")]
		internal MJNNFHEKAHC(global::IECBLAAJLIH<TKey> JLHLJFGHKCP, TKey LOLIOKKJLEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x44E3D90", Offset = "0x44E3190", VA = "0x1844E3D90")]
		public MJNNFHEKAHC LMONEFLEGHK(TKey LOLIOKKJLEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x44E3AB0", Offset = "0x44E2EB0", VA = "0x1844E3AB0")]
		public void ADPDGFIAGEF(TKey LOLIOKKJLEH, Action<MJNNFHEKAHC> ENOAFIICPMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2F8AF70", Offset = "0x2F8A370", VA = "0x182F8AF70")]
		public T ADPDGFIAGEF<T>(TKey LOLIOKKJLEH, Func<MJNNFHEKAHC, T> NJHDOOLMDMN)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2F8B060", Offset = "0x2F8A460", VA = "0x182F8B060")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(AMAFFGCEAMH))]
		public Task<T> DAIABOJPDIC<T>(TKey LOLIOKKJLEH, Func<MJNNFHEKAHC, Task<T>> NJHDOOLMDMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x44E3B90", Offset = "0x44E2F90", VA = "0x1844E3B90", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class JAGFNFNKMLM : IEnumerable<(TKey, List<TKey>, MNOLBOHJOLO)>, IEnumerable, IEnumerator<(TKey, List<TKey>, MNOLBOHJOLO)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private (TKey key, List<TKey> path, MNOLBOHJOLO timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public global::IECBLAAJLIH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private List<TKey> <path>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private IEnumerator<(TKey key, List<TKey> path, MNOLBOHJOLO timerEntry)> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private (TKey key, List<TKey> path, MNOLBOHJOLO timerEntry) <rootTuple>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		private (TKey, List<TKey>, MNOLBOHJOLO) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x338E120", Offset = "0x338D520", VA = "0x18338E120", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, MNOLBOHJOLO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x338E190", Offset = "0x338D590", VA = "0x18338E190", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x338E1F0", Offset = "0x338D5F0", VA = "0x18338E1F0")]
		[DebuggerHidden]
		public JAGFNFNKMLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x1C68840", Offset = "0x1C67C40", VA = "0x181C68840", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x338DCD0", Offset = "0x338D0D0", VA = "0x18338DCD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x338DC80", Offset = "0x338D080", VA = "0x18338DC80")]
		private void DJGMDMALOCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x338E150", Offset = "0x338D550", VA = "0x18338E150", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x338E060", Offset = "0x338D460", VA = "0x18338E060", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, MNOLBOHJOLO)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x281F8D0", Offset = "0x281ECD0", VA = "0x18281F8D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class BABHIFCNBPF : IEnumerable<(TKey, List<TKey>, MNOLBOHJOLO)>, IEnumerable, IEnumerator<(TKey, List<TKey>, MNOLBOHJOLO)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private (TKey key, List<TKey> path, MNOLBOHJOLO timerEntry) <>2__current;

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
		private MJNNFHEKAHC timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public MJNNFHEKAHC <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public global::IECBLAAJLIH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private IEnumerator<MJNNFHEKAHC> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private MJNNFHEKAHC <timerScopeChild>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private IEnumerator<(TKey key, List<TKey> path, MNOLBOHJOLO timerEntry)> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private (TKey key, List<TKey> path, MNOLBOHJOLO timerEntry) <childTuple>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		private (TKey, List<TKey>, MNOLBOHJOLO) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x338E120", Offset = "0x338D520", VA = "0x18338E120", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, MNOLBOHJOLO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x36A5460", Offset = "0x36A4860", VA = "0x1836A5460", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x338E1F0", Offset = "0x338D5F0", VA = "0x18338E1F0")]
		[DebuggerHidden]
		public BABHIFCNBPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x36A54C0", Offset = "0x36A48C0", VA = "0x1836A54C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x36A4CF0", Offset = "0x36A40F0", VA = "0x1836A4CF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x36A4C30", Offset = "0x36A4030", VA = "0x1836A4C30")]
		private void DJGMDMALOCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x36A4C90", Offset = "0x36A4090", VA = "0x1836A4C90")]
		private void KPMMGNEJCBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x36A5420", Offset = "0x36A4820", VA = "0x1836A5420", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x36A5310", Offset = "0x36A4710", VA = "0x1836A5310", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, MNOLBOHJOLO)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x36A53F0", Offset = "0x36A47F0", VA = "0x1836A53F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Action<TKey, MNOLBOHJOLO> JGCNCAABOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly Action<TKey, MNOLBOHJOLO> GPCBOJJPEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Action<global::IECBLAAJLIH<TKey>> PPIPKEBFDEB;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private const string BOAHIDMBJCM = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly MJNNFHEKAHC FGFNBIBBDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool OFAGMECEDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int EBODGBLBNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly Stopwatch FPHLBBLLCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly int EHPCEPABELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private string PODHBKGMGOF;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public MJNNFHEKAHC HNMPGFKHDOG
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B00", Offset = "0x7F7F00", VA = "0x1807F8B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	[NotNull]
	public string GCILCKIDHJK
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x809410", Offset = "0x808810", VA = "0x180809410")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x30F1170", Offset = "0x30F0570", VA = "0x1830F1170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public long APOBJJDLEKI
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x30F10A0", Offset = "0x30F04A0", VA = "0x1830F10A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int JDLLJMPLKLD
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x30F11D0", Offset = "0x30F05D0", VA = "0x1830F11D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x30F1400", Offset = "0x30F0800", VA = "0x1830F1400")]
	public IECBLAAJLIH(TKey OPMJAGANKEJ, [Optional] int? BLNGJFMGMCB, [Optional][CanBeNull] Stopwatch FPHLBBLLCJH, [Optional] Action<TKey, MNOLBOHJOLO> JGCNCAABOIA, [Optional] Action<TKey, MNOLBOHJOLO> GPCBOJJPEAB, [Optional] Action<global::IECBLAAJLIH<TKey>> PPIPKEBFDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x30F10E0", Offset = "0x30F04E0", VA = "0x1830F10E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x30F13E0", Offset = "0x30F07E0", VA = "0x1830F13E0")]
	public void JNFDCJLEDFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x30F10C0", Offset = "0x30F04C0", VA = "0x1830F10C0")]
	public void BLFMEPAEBCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x30F12D0", Offset = "0x30F06D0", VA = "0x1830F12D0")]
	[IteratorStateMachine(typeof(global::IECBLAAJLIH<>.JAGFNFNKMLM))]
	public IEnumerable<(TKey, List<TKey>, MNOLBOHJOLO)> IJPFOIGMMJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x30F1200", Offset = "0x30F0600", VA = "0x1830F1200")]
	[IteratorStateMachine(typeof(global::IECBLAAJLIH<>.BABHIFCNBPF))]
	private IEnumerable<(TKey, List<TKey>, MNOLBOHJOLO)> IJPFOIGMMJL(List<TKey> PHCGGMEPABN, MJNNFHEKAHC PNEOHLGKEBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x30F1360", Offset = "0x30F0760", VA = "0x1830F1360")]
	private (long, int) JKEPKJIHDIL()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class ECALAJOKJOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly Dictionary<byte, HODDCGFLGKB> CBOOPMHKBAN;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public HODDCGFLGKB IPPPONECJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x87D040", Offset = "0x87C440", VA = "0x18087D040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector2 JFMDEJFFKDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x12AC030", Offset = "0x12AB430", VA = "0x1812AC030")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x89D030", Offset = "0x89C430", VA = "0x18089D030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector2 PENHLIOFJJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2E87DE0", Offset = "0x2E871E0", VA = "0x182E87DE0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x887750", Offset = "0x886B50", VA = "0x180887750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector2 NMHGFJMDMLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6F40DE0", Offset = "0x6F401E0", VA = "0x186F40DE0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x880FD0", Offset = "0x8803D0", VA = "0x180880FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int ECCIKEHCBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x854AC0", Offset = "0x853EC0", VA = "0x180854AC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x9738E0", Offset = "0x972CE0", VA = "0x1809738E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6F414C0", Offset = "0x6F408C0", VA = "0x186F414C0")]
	public ECALAJOKJOC(Bounds ODEHKCAHPJL, Vector2[] OAIGFONNCEM, int PMCHHFLFOIP, byte CBDFEPEIFFE, float EPMFEGDGHIN = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6F40F60", Offset = "0x6F40360", VA = "0x186F40F60")]
	public HODDCGFLGKB IKLCBHGAEDK(byte CJOLACIBAJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6F413C0", Offset = "0x6F407C0", VA = "0x186F413C0")]
	public void NOGBMDACKEA(Vector3 FLBOBIODIJO, float JNBNCAEAPJA, float HOKPGOKHMPC, ref List<byte> HKJINFIGDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6F40DC0", Offset = "0x6F401C0", VA = "0x186F40DC0")]
	public void EFANAGDDDHP(HODDCGFLGKB.OEHMFMGILFH FJJKPJLHBJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6F40E00", Offset = "0x6F40200", VA = "0x186F40E00")]
	private HODDCGFLGKB FJCJNFPBHGA(byte CJOLACIBAJH, HODDCGFLGKB.FCJBALJPGNL FBIICNEGHAA, HODDCGFLGKB MOHMMJFCOKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6F40FC0", Offset = "0x6F403C0", VA = "0x186F40FC0")]
	private void NDBCJKFAMGE(HODDCGFLGKB MOHMMJFCOKF, Vector2[] OAIGFONNCEM, int INNEOMEMNGC, int JDBCMKINHBJ, int BHFPDHILMDF, int ICOOLPNEMPN, float EPMFEGDGHIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class HODDCGFLGKB
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public enum FCJBALJPGNL
	{
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum OEHMFMGILFH
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
	public byte JNDLCCECDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public Vector3 KIIINGNLDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public Vector3 PKAEOJAKEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public Vector3 GOKBCOCCGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Vector3 FBOEDAMMBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public FCJBALJPGNL JCEKOAPPNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public HODDCGFLGKB GCKCFOBIHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public List<HODDCGFLGKB> CEEFCCGBHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool HFPCOMKCHCM;

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6F42010", Offset = "0x6F41410", VA = "0x186F42010")]
	public HODDCGFLGKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6F41FB0", Offset = "0x6F413B0", VA = "0x186F41FB0")]
	public HODDCGFLGKB(byte IDFOGLKIIHM, FCJBALJPGNL FBIICNEGHAA, HODDCGFLGKB MOHMMJFCOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6F41C10", Offset = "0x6F41010", VA = "0x186F41C10")]
	public void CHLDIHBNOLG(HODDCGFLGKB GJELBDOMMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	public void EFANAGDDDHP(int ALLBEGGGILN, OEHMFMGILFH FJJKPJLHBJE, int LDGPKNGFKDA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6F41D10", Offset = "0x6F41110", VA = "0x186F41D10")]
	public void NOGBMDACKEA(List<byte> HKJINFIGDFB, Vector3 FLBOBIODIJO, float JNBNCAEAPJA, float HOKPGOKHMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6F41F50", Offset = "0x6F41350", VA = "0x186F41F50")]
	public bool OPCKPJFFJIG(Vector3 PIFKAMCJGGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6F41CD0", Offset = "0x6F410D0", VA = "0x186F41CD0")]
	public bool NMNLIPFPIPH(Vector3 PIFKAMCJGGD, float EGFIODMINNB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class EFDJKAAJPCF<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly Stack<T> GPDLMHCBDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly List<T> MAPGMBKICAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly int HCPDCHPLOCJ;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int MBAGBNEJACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x25E1190", Offset = "0x25E0590", VA = "0x1825E1190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int FJMPNHJLJPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3323300", Offset = "0x3322700", VA = "0x183323300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x34AFE50", Offset = "0x34AF250", VA = "0x1834AFE50")]
	public static global::EFDJKAAJPCF<T> IMOHFHAFFGL(int FJOEBJHKPLP = 0, int HCPDCHPLOCJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x34AFA70", Offset = "0x34AEE70", VA = "0x1834AFA70")]
	public static global::EFDJKAAJPCF<T> CCLHMLOHFPF(int FJOEBJHKPLP = 0, int HCPDCHPLOCJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x34B01B0", Offset = "0x34AF5B0", VA = "0x1834B01B0")]
	public EFDJKAAJPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x34B01F0", Offset = "0x34AF5F0", VA = "0x1834B01F0")]
	public EFDJKAAJPCF(int FJOEBJHKPLP, int HCPDCHPLOCJ = int.MaxValue, bool PIENJFAOEEL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x34AFCC0", Offset = "0x34AF0C0", VA = "0x1834AFCC0")]
	public T EBEKLFHMJCO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x34AF9D0", Offset = "0x34AEDD0", VA = "0x1834AF9D0")]
	public void BBKGKHKOOHH(T EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x34B00E0", Offset = "0x34AF4E0", VA = "0x1834B00E0")]
	private void LHEDNFDIGHI(T EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x34B00C0", Offset = "0x34AF4C0", VA = "0x1834B00C0")]
	private void JPDIIHCJHEC(T EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x34AFDD0", Offset = "0x34AF1D0", VA = "0x1834AFDD0")]
	[Conditional("DEBUG_BUILD")]
	private void EEOHCAFAFCC(T KAKBJFFEAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x34AFB40", Offset = "0x34AEF40", VA = "0x1834AFB40")]
	[Conditional("DEBUG_BUILD")]
	private void CNDJDJCPGJH(T KAKBJFFEAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x34AFBD0", Offset = "0x34AEFD0", VA = "0x1834AFBD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x34AFF20", Offset = "0x34AF320", VA = "0x1834AFF20")]
	private void INMGELAFDFD(IEnumerable<T> ICOGIPBOJIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class POHKJODJDCM
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private enum DGJFNCGEDKH : byte
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
	private int IMDHKCCMAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private bool NHOMODGNAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private DGJFNCGEDKH JJENMDNFAKI;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool LCFFDKCHEPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F451D0", Offset = "0x6F445D0", VA = "0x186F451D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool MOELDFHPMIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F451C0", Offset = "0x6F445C0", VA = "0x186F451C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F451E0", Offset = "0x6F445E0", VA = "0x186F451E0")]
	public POHKJODJDCM(bool NHOMODGNAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F44450", Offset = "0x6F43850", VA = "0x186F44450")]
	public void GKOFIADPLBN(object GHHNOPFOGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F442F0", Offset = "0x6F436F0", VA = "0x186F442F0")]
	public void ADHJGECFFHP(int EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F44B40", Offset = "0x6F43F40", VA = "0x186F44B40")]
	public void HAHCEKLDCOJ(uint KOIGCJCDPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F44BE0", Offset = "0x6F43FE0", VA = "0x186F44BE0")]
	public void HJFODDBKHGL(bool MNICLBBELHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F45180", Offset = "0x6F44580", VA = "0x186F45180")]
	public void LOHHMKDPFDH(long LMMCFMDFHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F44390", Offset = "0x6F43790", VA = "0x186F44390")]
	public void APFJPBBCMGC(ulong CLPOKHIHNPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F44C00", Offset = "0x6F44000", VA = "0x186F44C00")]
	public void IBIMHHIAKDE(string NEMKEJKFJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F44B50", Offset = "0x6F43F50", VA = "0x186F44B50")]
	public void HJFOBPEPLOG(Enum FELJPOLMEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F44C70", Offset = "0x6F44070", VA = "0x186F44C70")]
	public void IEGHLNJHAHB(IList FGINDFDIDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x24DF9E0", Offset = "0x24DEDE0", VA = "0x1824DF9E0")]
	public void JLAJMJBINCD<T, U>(Dictionary<T, U> HEKIAEOGHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F44DA0", Offset = "0x6F441A0", VA = "0x186F44DA0")]
	private void JLLJEJJKIDN(IDictionary HEKIAEOGHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F44AD0", Offset = "0x6F43ED0", VA = "0x186F44AD0")]
	public int GNBCEAADOEB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F45110", Offset = "0x6F44510", VA = "0x186F45110")]
	public short KJJECGEAHND()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F443D0", Offset = "0x6F437D0", VA = "0x186F443D0")]
	public void DDMMLHIFNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F443E0", Offset = "0x6F437E0", VA = "0x186F443E0")]
	private void DKIJDHCNEDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface JHCNIIHFCBA
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class ResourcePrefabReference<T> : JHCNIIHFCBA where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3072870", Offset = "0x3071C70", VA = "0x183072870", Slot = "4")]
		public virtual T GCNDJLKOOFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class FBBIKFEAGNC<T> : IEnumerable<global::FBBIKFEAGNC<T>.IMCAAHLLPEN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public struct IMCAAHLLPEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public T EOEKGHMNIDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public int CJOLACIBAJH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class PHCMBFMLINP : IEnumerator<IMCAAHLLPEN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private global::FBBIKFEAGNC<T> FHEFHDDBGPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private int CJOLACIBAJH;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x19385C0", Offset = "0x19379C0", VA = "0x1819385C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public IMCAAHLLPEN HHNCKLAAHCM
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x3D4EBF0", Offset = "0x3D4DFF0", VA = "0x183D4EBF0", Slot = "4")]
			get
			{
				return default(IMCAAHLLPEN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x85A020", Offset = "0x859420", VA = "0x18085A020")]
		public PHCMBFMLINP(global::FBBIKFEAGNC<T> FHEFHDDBGPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x3D4EAF0", Offset = "0x3D4DEF0", VA = "0x183D4EAF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x85A010", Offset = "0x859410", VA = "0x18085A010", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x10C0900", Offset = "0x10BFD00", VA = "0x1810C0900", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private struct ALPOHLEMFFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public bool DNIGICNOBLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public T EOEKGHMNIDN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private const int MKNPNIHAPNM = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Dictionary<T, int> ENGIFJANOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private ALPOHLEMFFP[] NBFJNJODJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int OLGOFNAFPBA;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int IKCJMBDMJLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x913DB0", Offset = "0x9131B0", VA = "0x180913DB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xB36340", Offset = "0xB35740", VA = "0x180B36340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public int KLCJBBHGHFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x279A3F0", Offset = "0x27997F0", VA = "0x18279A3F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x51258A0", Offset = "0x5124CA0", VA = "0x1851258A0")]
	public FBBIKFEAGNC(int FJOEBJHKPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5125970", Offset = "0x5124D70", VA = "0x185125970")]
	public FBBIKFEAGNC(IMCAAHLLPEN[] BCICFPLGOEG, bool DKCOIJJMCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x51254A0", Offset = "0x51248A0", VA = "0x1851254A0")]
	public int OIAIINLDMNN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5124CA0", Offset = "0x51240A0", VA = "0x185124CA0")]
	private int HGFODDFGLOH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x5124A10", Offset = "0x5123E10", VA = "0x185124A10", Slot = "6")]
	protected virtual uint EPGMCGODPHC(uint IMDHKCCMAPF, T EOEKGHMNIDN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x5125020", Offset = "0x5124420", VA = "0x185125020")]
	public bool LCMPEGCHLAM(T EOEKGHMNIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x5125510", Offset = "0x5124910", VA = "0x185125510")]
	public bool OIHBNIEFLBO(int CJOLACIBAJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x5125060", Offset = "0x5124460", VA = "0x185125060")]
	public bool MEIKKLBJCPM(Func<T, bool> NHCJLGOCMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x5124FC0", Offset = "0x51243C0", VA = "0x185124FC0")]
	public int JCLAAOILLKN(T EOEKGHMNIDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x5124F00", Offset = "0x5124300", VA = "0x185124F00")]
	public T IHBHDLPBOOO(int CJOLACIBAJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5124990", Offset = "0x5123D90", VA = "0x185124990")]
	public void DDMMLHIFNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5124440", Offset = "0x5123840", VA = "0x185124440")]
	public bool ADFCMLEOCDN(T EOEKGHMNIDN, bool KODCNCFNJDK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5124680", Offset = "0x5123A80", VA = "0x185124680")]
	public bool ADFCMLEOCDN(T EOEKGHMNIDN, int CJOLACIBAJH, bool KODCNCFNJDK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x5124880", Offset = "0x5123C80", VA = "0x185124880")]
	public bool AJCNBIMBJPF(T EOEKGHMNIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x5124A60", Offset = "0x5123E60", VA = "0x185124A60")]
	public bool GFKHMCIOCHP(int CJOLACIBAJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x5125690", Offset = "0x5124A90", VA = "0x185125690")]
	private void OIPBNJLCHMO(int CJOLACIBAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x5125360", Offset = "0x5124760", VA = "0x185125360")]
	public IMCAAHLLPEN[] MOPALDLJLLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x51257D0", Offset = "0x5124BD0", VA = "0x1851257D0")]
	private int POBMPDJHHDH(int CBDFEPEIFFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x5125820", Offset = "0x5124C20", VA = "0x185125820", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x5125820", Offset = "0x5124C20", VA = "0x185125820", Slot = "4")]
	private IEnumerator<IMCAAHLLPEN> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
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
		[BCPMGDDGKGM(BGDDCFKMKBJ.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x6F458B0", Offset = "0x6F44CB0", VA = "0x186F458B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x6F45B40", Offset = "0x6F44F40", VA = "0x186F45B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x6F45A70", Offset = "0x6F44E70", VA = "0x186F45A70")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x6F45CA0", Offset = "0x6F450A0", VA = "0x186F45CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x6F45820", Offset = "0x6F44C20", VA = "0x186F45820")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x6F45AB0", Offset = "0x6F44EB0", VA = "0x186F45AB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x6F459E0", Offset = "0x6F44DE0", VA = "0x186F459E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x6F457C0", Offset = "0x6F44BC0", VA = "0x186F457C0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class EANKKPEAAPL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private int FJOEBJHKPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int KEDBPJHFHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private List<T> FDOLNONHOJG;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int KLCJBBHGHFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x25E1190", Offset = "0x25E0590", VA = "0x1825E1190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T GGMILLFJIAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x2E9F3E0", Offset = "0x2E9E7E0", VA = "0x182E9F3E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T LALJEBOHFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x2E9F740", Offset = "0x2E9EB40", VA = "0x182E9F740")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T CFJABHGNJGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x2E9F830", Offset = "0x2E9EC30", VA = "0x182E9F830")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2E9F890", Offset = "0x2E9EC90", VA = "0x182E9F890")]
	public EANKKPEAAPL(int FJOEBJHKPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2E9F660", Offset = "0x2E9EA60", VA = "0x182E9F660")]
	public void MGOOIKEIGMG(T FGAFGKJAOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2E9F390", Offset = "0x2E9E790", VA = "0x182E9F390")]
	public void DDMMLHIFNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2E9F4F0", Offset = "0x2E9E8F0", VA = "0x182E9F4F0")]
	public void LEPDNNAHLAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2E9F340", Offset = "0x2E9E740", VA = "0x182E9F340")]
	public void CNBJMKAFCGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2E9F3D0", Offset = "0x2E9E7D0", VA = "0x182E9F3D0")]
	public void FONAGACNHMM()
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
		public struct CJMDPHHMKFK<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private readonly List<Component> FGINDFDIDLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private readonly bool OPDPIPODHNM;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0xB86AD0", Offset = "0xB85ED0", VA = "0x180B86AD0")]
			public CJMDPHHMKFK(List<Component> FGINDFDIDLG, bool OPDPIPODHNM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x51A0C50", Offset = "0x51A0050", VA = "0x1851A0C50")]
			public FAJDOLDNAPD<T> KLBJEDHKGHJ()
			{
				return default(FAJDOLDNAPD<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x51A0CC0", Offset = "0x51A00C0", VA = "0x1851A0CC0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x51A0CC0", Offset = "0x51A00C0", VA = "0x1851A0CC0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		public struct FAJDOLDNAPD<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private readonly List<Component> FGINDFDIDLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private readonly bool OPDPIPODHNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private int CJOLACIBAJH;

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public T HHNCKLAAHCM
			{
				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x511F6F0", Offset = "0x511EAF0", VA = "0x18511F6F0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x511F680", Offset = "0x511EA80", VA = "0x18511F680", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x511F6C0", Offset = "0x511EAC0", VA = "0x18511F6C0")]
			public FAJDOLDNAPD(List<Component> FGINDFDIDLG, bool OPDPIPODHNM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x511F5B0", Offset = "0x511E9B0", VA = "0x18511F5B0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x511F5C0", Offset = "0x511E9C0", VA = "0x18511F5C0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x342B760", Offset = "0x342AB60", VA = "0x18342B760", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F47940", Offset = "0x6F46D40", VA = "0x186F47940")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6F47900", Offset = "0x6F46D00", VA = "0x186F47900")]
		public ToolHierarchyCache(GameObject NPKKHNDMELE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F47680", Offset = "0x6F46A80", VA = "0x186F47680")]
		private void OAGJEKOOFKN(GameObject NPKKHNDMELE, bool BLLAAOPKLPH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F477E0", Offset = "0x6F46BE0", VA = "0x186F477E0")]
		public static void OAGJEKOOFKN(GameObject NPKKHNDMELE, ref ToolHierarchyCache BBOGLLHMOGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F47870", Offset = "0x6F46C70", VA = "0x186F47870")]
		public void OEIJINLFDEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F47090", Offset = "0x6F46490", VA = "0x186F47090")]
		public void DHJGCLBMNKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x2458490", Offset = "0x2457890", VA = "0x182458490")]
		public void INJEJFENMJJ<T>(Action<T> ENOAFIICPMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x6F475B0", Offset = "0x6F469B0", VA = "0x186F475B0")]
		public Component LMIOICLDHNI(Type ONBHBHIHHNE, bool OPDPIPODHNM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x2458720", Offset = "0x2457B20", VA = "0x182458720")]
		public T LMIOICLDHNI<T>(bool OPDPIPODHNM = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F47530", Offset = "0x6F46930", VA = "0x186F47530")]
		public CJMDPHHMKFK<Component> HLJIEENKGED(Type ONBHBHIHHNE, bool OPDPIPODHNM = false)
		{
			return default(CJMDPHHMKFK<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x24583C0", Offset = "0x24577C0", VA = "0x1824583C0")]
		public CJMDPHHMKFK<T> HLJIEENKGED<T>(bool OPDPIPODHNM = false) where T : class
		{
			return default(CJMDPHHMKFK<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F470E0", Offset = "0x6F464E0", VA = "0x186F470E0")]
		public List<Component> DLLJCKKDANK(Type ONBHBHIHHNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6F47430", Offset = "0x6F46830", VA = "0x186F47430", Slot = "4")]
		public bool Equals(ToolHierarchyCache MIKJHKLKLDH, ToolHierarchyCache EJBKGAHMBFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6F474B0", Offset = "0x6F468B0", VA = "0x186F474B0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache GHHNOPFOGCC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class OGEFLHHCELB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private Dictionary<int, T> MMGMKLGCLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private T KOAHJAIENPP;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public virtual T AOFILGEFLFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x87B360", Offset = "0x87A760", VA = "0x18087B360", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x811A60", Offset = "0x810E60", VA = "0x180811A60", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool DHFKPKEINEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x354DAD0", Offset = "0x354CED0", VA = "0x18354DAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x354D8D0", Offset = "0x354CCD0", VA = "0x18354D8D0")]
	public bool DHOHJFEOLDL(T EOEKGHMNIDN, int LHEGNPFIDGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x339B850", Offset = "0x339AC50", VA = "0x18339B850")]
	public bool DNCHDENHGON(int LHEGNPFIDGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x354D3D0", Offset = "0x354C7D0", VA = "0x18354D3D0")]
	public T BOHJPKFFMBL(int AKAMEDGHBOI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x354D810", Offset = "0x354CC10", VA = "0x18354D810")]
	public void DDMMLHIFNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x354DA40", Offset = "0x354CE40", VA = "0x18354DA40")]
	private bool DHPEOMGFPPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x354D7E0", Offset = "0x354CBE0", VA = "0x18354D7E0")]
	public bool CIAJMCMLAHH(int LHEGNPFIDGH, out T EOEKGHMNIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x354DB10", Offset = "0x354CF10", VA = "0x18354DB10")]
	public OGEFLHHCELB()
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
			[Cpp2IlInjected.Address(RVA = "0x80EA60", Offset = "0x80DE60", VA = "0x18080EA60")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x80EC80", Offset = "0x80E080", VA = "0x18080EC80")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public T this[int GGGLLOBDBOL, int JIHCAKBKHFN]
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x405F9E0", Offset = "0x405EDE0", VA = "0x18405F9E0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x405FA80", Offset = "0x405EE80", VA = "0x18405FA80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x405F950", Offset = "0x405ED50", VA = "0x18405F950")]
		public Array2D(uint CNMMFNANECF, uint OHIHFDKEEFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x405F8D0", Offset = "0x405ECD0", VA = "0x18405F8D0")]
		public void DDMMLHIFNLF()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6F40890", Offset = "0x6F3FC90", VA = "0x186F40890")]
		public Array2DVector3(uint CNMMFNANECF, uint OHIHFDKEEFB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public abstract class DHIJJCKJMCO<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	internal class DGAHMCNMHFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public TNode LGKAJJKAMAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public TNode MOHMMJFCOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public KNEOKCOCCGA DKHCFGEENMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public List<KNEOKCOCCGA> LBMHEGODOPD;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public DGAHMCNMHFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	internal struct KNEOKCOCCGA : IComparable<KNEOKCOCCGA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public int LHEGNPFIDGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public TClaimant IDNLFAANAEC;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x91E060", Offset = "0x91D460", VA = "0x18091E060")]
		public KNEOKCOCCGA(int LHEGNPFIDGH, TClaimant IDNLFAANAEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x42F5010", Offset = "0x42F4410", VA = "0x1842F5010")]
		public bool KEFKMMLMCJL(in KNEOKCOCCGA CCJMBGJFGLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x42F4FF0", Offset = "0x42F43F0", VA = "0x1842F4FF0")]
		public bool APDFGNPOKBM(in KNEOKCOCCGA CCJMBGJFGLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x42F5000", Offset = "0x42F4400", VA = "0x1842F5000", Slot = "4")]
		public int CompareTo(KNEOKCOCCGA CCJMBGJFGLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x42F5070", Offset = "0x42F4470", VA = "0x1842F5070", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public enum MCIJLFNJGFH
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class LGELJKFJECE : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public global::DHIJJCKJMCO<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x1C6E5C0", Offset = "0x1C6D9C0", VA = "0x181C6E5C0")]
		[DebuggerHidden]
		public LGELJKFJECE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x3B273F0", Offset = "0x3B267F0", VA = "0x183B273F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x3B275B0", Offset = "0x3B269B0", VA = "0x183B275B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x3B274D0", Offset = "0x3B268D0", VA = "0x183B274D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x1C6C2F0", Offset = "0x1C6B6F0", VA = "0x181C6C2F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly global::EFDJKAAJPCF<DGAHMCNMHFN> BKPCDPNNMKC;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static readonly global::EFDJKAAJPCF<List<KNEOKCOCCGA>> EAGAJAKMHHD;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static int EFNGIJONAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	internal readonly Dictionary<TClaimant, TNode> IJGLKCALFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	internal readonly Dictionary<TNode, DGAHMCNMHFN> PAGCFGIAFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private MCIJLFNJGFH KEHLBJHLAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private bool OLOGLDMJOBK;

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode HFLAOFHLDCL(TNode CGDIPNGPFNP);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void LKOCNHHIMCE(TNode CGDIPNGPFNP, TClaimant ADGIGOBHNEI, TClaimant EBMFGAJCDJK);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x360CC90", Offset = "0x360C090", VA = "0x18360CC90")]
	public DHIJJCKJMCO(MCIJLFNJGFH KEHLBJHLAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x360C510", Offset = "0x360B910", VA = "0x18360C510")]
	public void MBDFICLCNLI(TNode CGDIPNGPFNP, TNode OFEIPHKKILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x360C410", Offset = "0x360B810", VA = "0x18360C410")]
	public void LIAPALELGIF(TClaimant IDNLFAANAEC, TNode EDEBFCOBNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x360BCE0", Offset = "0x360B0E0", VA = "0x18360BCE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x360BC40", Offset = "0x360B040", VA = "0x18360BC40")]
	private void DIJADBJCCLD(TClaimant IDNLFAANAEC, TNode NBLNCBMDOEI, TNode EDEBFCOBNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x360C050", Offset = "0x360B450", VA = "0x18360C050")]
	private int JHHAJABKMPB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x360C660", Offset = "0x360BA60", VA = "0x18360C660")]
	private void NBFOPGGCDLF(TClaimant IDNLFAANAEC, TNode NBGNBFPHPFB, TNode DBLKGKBGOJF, int IKEIPOKKLDD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x360CAA0", Offset = "0x360BEA0", VA = "0x18360CAA0")]
	private void OIAFNDFGPBI(KNEOKCOCCGA FACEIOMBABJ, DGAHMCNMHFN KOONCGHOKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x360C1B0", Offset = "0x360B5B0", VA = "0x18360C1B0")]
	private void LHMLJLPFLPM(TClaimant IDNLFAANAEC, TNode NBGNBFPHPFB, TNode DBLKGKBGOJF, int IKEIPOKKLDD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x360BF40", Offset = "0x360B340", VA = "0x18360BF40")]
	private void FHKFMPCCEGK(KNEOKCOCCGA FACEIOMBABJ, TNode CGDIPNGPFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x360C0B0", Offset = "0x360B4B0", VA = "0x18360C0B0")]
	private void KIOAGLIPBBE(KNEOKCOCCGA FACEIOMBABJ, DGAHMCNMHFN KOONCGHOKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x360BB30", Offset = "0x360AF30", VA = "0x18360BB30")]
	private void CPHOCHLHKAP(DGAHMCNMHFN KOONCGHOKEL, bool GOCHHLEIEGA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x360B5C0", Offset = "0x360A9C0", VA = "0x18360B5C0")]
	private void AJLLFKNAKNF(DGAHMCNMHFN KOONCGHOKEL, TNode OFEIPHKKILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x360C590", Offset = "0x360B990", VA = "0x18360C590")]
	[IteratorStateMachine(typeof(global::DHIJJCKJMCO<, >.LGELJKFJECE))]
	private IEnumerable<TNode> MLNILJAGDNE(TNode NBGNBFPHPFB, TNode DBLKGKBGOJF, bool GEGFPCEGILL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x360B500", Offset = "0x360A900", VA = "0x18360B500")]
	private DGAHMCNMHFN AEIOKJIBAFC(TNode CGDIPNGPFNP, TNode MOHMMJFCOKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x360C910", Offset = "0x360BD10", VA = "0x18360C910")]
	private DGAHMCNMHFN NOIOIAAOKDE(TNode CGDIPNGPFNP, TNode MOHMMJFCOKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x360B970", Offset = "0x360AD70", VA = "0x18360B970")]
	private void AMOIEOLCAFN(DGAHMCNMHFN KOONCGHOKEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class OJMILEDDPDA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	protected struct GBMKJHKLFGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public T DEMEBAENMIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int MAOODCNPJOI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	protected readonly List<GBMKJHKLFGO> HOCKGLIBNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private T CJACOCKGIAP;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int KLCJBBHGHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x279A3F0", Offset = "0x27997F0", VA = "0x18279A3F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x355C2E0", Offset = "0x355B6E0", VA = "0x18355C2E0")]
	public bool MEIKKLBJCPM(T EOEKGHMNIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x355C6B0", Offset = "0x355BAB0", VA = "0x18355C6B0")]
	public void MGOOIKEIGMG(T EOEKGHMNIDN, int LHEGNPFIDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x355C080", Offset = "0x355B480", VA = "0x18355C080")]
	public bool AJCNBIMBJPF(T EOEKGHMNIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x355C1A0", Offset = "0x355B5A0", VA = "0x18355C1A0")]
	public void DDMMLHIFNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x355C270", Offset = "0x355B670", VA = "0x18355C270")]
	public T KPIHBDAIJCB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x355C200", Offset = "0x355B600", VA = "0x18355C200")]
	public T HJPLNKAJKMN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x355C4F0", Offset = "0x355B8F0", VA = "0x18355C4F0")]
	private void MFDCKFAJGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x355C750", Offset = "0x355BB50", VA = "0x18355C750")]
	public OJMILEDDPDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class OEMENINJKCO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private struct ANNKNHGNFDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int MAOODCNPJOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public T DEMEBAENMIP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly Dictionary<object, ANNKNHGNFDD> MMGMKLGCLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly EqualityComparer<T> NIFGMAMFCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private T KOAHJAIENPP;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public virtual T AOFILGEFLFL
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x3F31650", Offset = "0x3F30A50", VA = "0x183F31650", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x2F64320", Offset = "0x2F63720", VA = "0x182F64320", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool DHFKPKEINEH
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x3F314F0", Offset = "0x3F308F0", VA = "0x183F314F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public object KNEKKBOJOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x7F1280", Offset = "0x7F0680", VA = "0x1807F1280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x89EC00", Offset = "0x89E000", VA = "0x18089EC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3F2CE80", Offset = "0x3F2C280", VA = "0x183F2CE80")]
	public bool DHOHJFEOLDL(T EOEKGHMNIDN, object IJNLJGNNJFA, int LHEGNPFIDGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3F31480", Offset = "0x3F30880", VA = "0x183F31480")]
	public bool DNCHDENHGON(object IJNLJGNNJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x3F2C5D0", Offset = "0x3F2B9D0", VA = "0x183F2C5D0")]
	public bool CIAJMCMLAHH(object IJNLJGNNJFA, out T EOEKGHMNIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x3F2CB70", Offset = "0x3F2BF70", VA = "0x183F2CB70")]
	public void DDMMLHIFNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x3F30860", Offset = "0x3F2FC60", VA = "0x183F30860")]
	private bool DHPEOMGFPPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x3F31660", Offset = "0x3F30A60", VA = "0x183F31660")]
	public OEMENINJKCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class BCKFCOHHHFO
{
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x6F408F0", Offset = "0x6F3FCF0", VA = "0x186F408F0")]
	public static void KDFCDJFMPAA(KBENAKLNOBE GOKAGNCECMF, string DFCFFDJHJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	public static void KDFCDJFMPAA(IEnumerable<object> EBLMGLJOEHF, string DFCFFDJHJJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class DMGPDAHLJIA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private bool POKINMDGJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private Action ENOAFIICPMH;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public static DMGPDAHLJIA JHHIJMNBDPH
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x6F40CE0", Offset = "0x6F400E0", VA = "0x186F40CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool ECCICFEDGAO
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x8116E0", Offset = "0x810AE0", VA = "0x1808116E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6F40D80", Offset = "0x6F40180", VA = "0x186F40D80")]
	public DMGPDAHLJIA(Action ENOAFIICPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x6F40D60", Offset = "0x6F40160", VA = "0x186F40D60")]
	public void FABBDADBDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6F40D60", Offset = "0x6F40160", VA = "0x186F40D60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public class PGKHMBPAHKF : NDMPNILAOGM
{
	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6F44240", Offset = "0x6F43640", VA = "0x186F44240")]
	public PGKHMBPAHKF(UnityEngine.Object JKMNBFOBGGJ)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public class AOIEPJGNBNP
{
	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public AOIEPJGNBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x8C6BB0", Offset = "0x8C5FB0", VA = "0x1808C6BB0")]
	public static string NLHKAJNPDJN(byte[] AMGPPENALAL, byte[] DKDGFKIJFBC)
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
