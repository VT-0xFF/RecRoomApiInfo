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
		[Cpp2IlInjected.Address(RVA = "0x7EA1A0", Offset = "0x7E87A0", VA = "0x1807EA1A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9B6E30", Offset = "0x9B5430", VA = "0x1809B6E30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xE3A080", Offset = "0xE38680", VA = "0x180E3A080")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xE3A160", Offset = "0xE38760", VA = "0x180E3A160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "4")]
	public virtual void OKACPBABCLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
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
	[NJPMDPFPPOI]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4FAC9A0", Offset = "0x4FAAFA0", VA = "0x184FAC9A0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4FAC100", Offset = "0x4FAA700", VA = "0x184FAC100", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4FACED0", Offset = "0x4FAB4D0", VA = "0x184FACED0")]
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
	private sealed class GMAPIPGAIMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public GMAPIPGAIMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x33C21C0", Offset = "0x33C07C0", VA = "0x1833C21C0")]
		internal int GGDKKNLABJE(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[NJPMDPFPPOI]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8FB830", Offset = "0x8F9E30", VA = "0x1808FB830", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8FB860", Offset = "0x8F9E60", VA = "0x1808FB860", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8FB780", Offset = "0x8F9D80", VA = "0x1808FB780", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey BOMEFJIOGGM]
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8FB7E0", Offset = "0x8F9DE0", VA = "0x1808FB7E0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8FB680", Offset = "0x8F9C80", VA = "0x1808FB680", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8FB1A0", Offset = "0x8F97A0", VA = "0x1808FB1A0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8FA9C0", Offset = "0x8F8FC0", VA = "0x1808FA9C0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8FA640", Offset = "0x8F8C40", VA = "0x1808FA640", Slot = "14")]
	protected virtual string MHJJOLGKBLL(TKeyVal DHADIPDGBFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8FA550", Offset = "0x8F8B50", VA = "0x1808FA550", Slot = "4")]
	public bool ContainsKey(TKey BOMEFJIOGGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8FB560", Offset = "0x8F9B60", VA = "0x1808FB560", Slot = "5")]
	public bool TryGetValue(TKey BOMEFJIOGGM, out TVal MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8FA580", Offset = "0x8F8B80", VA = "0x1808FA580", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8FA580", Offset = "0x8F8B80", VA = "0x1808FA580", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8FB590", Offset = "0x8F9B90", VA = "0x1808FB590")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EFALJCAELJL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class PKEOJJGGBNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public PKEOJJGGBNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x22B5460", Offset = "0x22B3A60", VA = "0x1822B5460")]
		internal bool IJFDCFLPPHF(FOMNGLJCNMI<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float ENELEECOIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float EPNJFNGCHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<FOMNGLJCNMI<float, T>> AHOONMMFIFH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int JDBHEJBGAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x23E2520", Offset = "0x23E0B20", VA = "0x1823E2520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x23E26E0", Offset = "0x23E0CE0", VA = "0x1823E26E0")]
	public EFALJCAELJL(float OLGEOFBPHDI, float CPBEAJCMMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x23E23C0", Offset = "0x23E09C0", VA = "0x1823E23C0")]
	public bool JLHLDFNDADK(float CKDPHHLMOGA, T MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x23E1F20", Offset = "0x23E0520", VA = "0x1823E1F20")]
	public IEnumerable<T> ILBBCNPOJGF(float CKDPHHLMOGA, [Optional] float? KAAALLAFMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x23E1BB0", Offset = "0x23E01B0", VA = "0x1823E1BB0")]
	public void FBJOPIHCMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x23E2620", Offset = "0x23E0C20", VA = "0x1823E2620")]
	private void MFNGHKOBFJG(float CKDPHHLMOGA)
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

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public T INKIKMDHKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2EAF910", Offset = "0x2EADF10", VA = "0x182EAF910")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2EAF860", Offset = "0x2EADE60", VA = "0x182EAF860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float BCGBCDBOFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9E9840", Offset = "0x9E7E40", VA = "0x1809E9840")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3A401C0", Offset = "0x3A3E7C0", VA = "0x183A401C0")]
	public T EGKMFFNLLKC(float KAIHGPIIHIB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3A3FFF0", Offset = "0x3A3E5F0", VA = "0x183A3FFF0")]
	public T DDOPPKMGFDC(float KAIHGPIIHIB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T PAHOCPPOCMP(T MBOGNALMNPH, T NDCLMFPKHPF, float KAIHGPIIHIB);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5016540", Offset = "0x5014B40", VA = "0x185016540", Slot = "4")]
	protected override float PAHOCPPOCMP(float MBOGNALMNPH, float NDCLMFPKHPF, float KAIHGPIIHIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8F70", Offset = "0x6EE7570", VA = "0x186EE8F70")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x10ABAE0", Offset = "0x10AA0E0", VA = "0x1810ABAE0", Slot = "4")]
	protected override Vector3 PAHOCPPOCMP(Vector3 MBOGNALMNPH, Vector3 NDCLMFPKHPF, float KAIHGPIIHIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC850", Offset = "0x6EEAE50", VA = "0x186EEC850")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE75F0", Offset = "0x6EE5BF0", VA = "0x186EE75F0", Slot = "4")]
	protected override Color PAHOCPPOCMP(Color MBOGNALMNPH, Color NDCLMFPKHPF, float KAIHGPIIHIB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7650", Offset = "0x6EE5C50", VA = "0x186EE7650")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GNBGKLNBJKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2B42020", Offset = "0x2B40620", VA = "0x182B42020")]
	public static FOMNGLJCNMI<T1, T2> HKLENFAPHAP<T1, T2>(T1 HDEPFCEHGDF, T2 GBMDIJDFCDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2B42090", Offset = "0x2B40690", VA = "0x182B42090")]
	public static ANJJBKMBNKC<T1, T2, T3> HKLENFAPHAP<T1, T2, T3>(T1 HDEPFCEHGDF, T2 GBMDIJDFCDG, T3 PJGGPCEPHAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6EE93C0", Offset = "0x6EE79C0", VA = "0x186EE93C0")]
	internal static int HDBHCPNIKGB(int OFHNJBJLHMI, int CIPHDKHMPMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6EE93D0", Offset = "0x6EE79D0", VA = "0x186EE93D0")]
	internal static int HDBHCPNIKGB(int OFHNJBJLHMI, int CIPHDKHMPMP, int ENDOAFHGICG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class FOMNGLJCNMI<T1, T2> : IComparable<FOMNGLJCNMI<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly T1 NHAHKJLEIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly T2 NOCJMMHDCIB;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x297B680", Offset = "0x2979C80", VA = "0x18297B680")]
	public FOMNGLJCNMI(T1 HDEPFCEHGDF, T2 GBMDIJDFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x31CFEA0", Offset = "0x31CE4A0", VA = "0x1831CFEA0", Slot = "4")]
	public int CompareTo(FOMNGLJCNMI<T1, T2> FKJGPCABBJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x31D0720", Offset = "0x31CED20", VA = "0x1831D0720", Slot = "0")]
	public override bool Equals(object FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x31D0C10", Offset = "0x31CF210", VA = "0x1831D0C10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x31D15A0", Offset = "0x31CFBA0", VA = "0x1831D15A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ANJJBKMBNKC<T1, T2, T3> : IComparable<ANJJBKMBNKC<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly T1 NHAHKJLEIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T2 NOCJMMHDCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly T3 CKDKPFELFJE;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x20855E0", Offset = "0x2083BE0", VA = "0x1820855E0")]
	public ANJJBKMBNKC(T1 HDEPFCEHGDF, T2 GBMDIJDFCDG, T3 PJGGPCEPHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2084D20", Offset = "0x2083320", VA = "0x182084D20", Slot = "4")]
	public int CompareTo(ANJJBKMBNKC<T1, T2, T3> FKJGPCABBJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2085040", Offset = "0x2083640", VA = "0x182085040", Slot = "0")]
	public override bool Equals(object FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x20851B0", Offset = "0x20837B0", VA = "0x1820851B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x20852A0", Offset = "0x20838A0", VA = "0x1820852A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NJPMDPFPPOI : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8D40F0", Offset = "0x8D26F0", VA = "0x1808D40F0")]
	public NJPMDPFPPOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class HashableScriptableObject : ScriptableObject, EPDJHAPCLEA, GGPIMHBGJEH, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C00", Offset = "0x7F5200", VA = "0x1807F6C00", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x91A1A0", Offset = "0x9187A0", VA = "0x18091A1A0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x974F00", Offset = "0x973500", VA = "0x180974F00", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash DEOOIHJFHDN);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x9341D0", Offset = "0x9327D0", VA = "0x1809341D0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[LFGDDIAOPDB]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[LFGDDIAOPDB]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6EEB8E0", Offset = "0x6EE9EE0", VA = "0x186EEB8E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6EEB8A0", Offset = "0x6EE9EA0", VA = "0x186EEB8A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6EEB920", Offset = "0x6EE9F20", VA = "0x186EEB920")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6EEBAD0", Offset = "0x6EEA0D0", VA = "0x186EEBAD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6EEBA40", Offset = "0x6EEA040", VA = "0x186EEBA40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x935910", Offset = "0x933F10", VA = "0x180935910")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x935900", Offset = "0x933F00", VA = "0x180935900")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6EEB860", Offset = "0x6EE9E60", VA = "0x186EEB860")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6EEB9B0", Offset = "0x6EE9FB0", VA = "0x186EEB9B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6EEB370", Offset = "0x6EE9970", VA = "0x186EEB370")]
	public void CopyBounds(SavedExtents FKJGPCABBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6EEB7C0", Offset = "0x6EE9DC0", VA = "0x186EEB7C0")]
	public void SetLocalSpaceBounds(Bounds FHALDJDBHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6EEAC50", Offset = "0x6EE9250", VA = "0x186EEAC50")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6EEB7B0", Offset = "0x6EE9DB0", VA = "0x186EEB7B0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6EEB3A0", Offset = "0x6EE99A0", VA = "0x186EEB3A0")]
	private void OJBDEMPDPKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6EEB580", Offset = "0x6EE9B80", VA = "0x186EEB580")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6EEAD30", Offset = "0x6EE9330", VA = "0x186EEAD30")]
	public static void CalculateLocalBoundsFor(GameObject FLCGKEKAMCK, out Bounds FHALDJDBHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6EEAC70", Offset = "0x6EE9270", VA = "0x186EEAC70")]
	private static void BMFOKFCAEDD(Bounds HEPECHBEGLE, Color AMEIOKDAEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6EEB7E0", Offset = "0x6EE9DE0", VA = "0x186EEB7E0")]
	public SavedExtents()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class KJDNFKLIEAK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct AEMOFDOJDEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public T INKIKMDHKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public float ODPIHCJNICN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static float FFNIEAKDCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private List<T> AAJGGFAEBHE;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private const int FMDGHLAAMNH = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private AEMOFDOJDEF[] IACDCADJJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int JKHNKEPJNDF;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float OJJKKFNADPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8D1DE0", Offset = "0x8D03E0", VA = "0x1808D1DE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8D1DC0", Offset = "0x8D03C0", VA = "0x1808D1DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x265B000", Offset = "0x2659600", VA = "0x18265B000")]
	public KJDNFKLIEAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x265AF00", Offset = "0x2659500", VA = "0x18265AF00")]
	public KJDNFKLIEAK(int OCMPILAHMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x265ADD0", Offset = "0x26593D0", VA = "0x18265ADD0")]
	public void PDDBDHJNBOH(float CKDPHHLMOGA, T MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x265A440", Offset = "0x2658A40", VA = "0x18265A440")]
	public void FBJOPIHCMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x265A060", Offset = "0x2658660", VA = "0x18265A060")]
	public bool BEIDBDPLJBG(float AOBHKJKOOND, float KJGNCKBPPEI, out T MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x265A8D0", Offset = "0x2658ED0", VA = "0x18265A8D0")]
	public bool JCHHIIHGIOJ(float AOBHKJKOOND, float KJGNCKBPPEI, out T MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x265AA70", Offset = "0x2659070", VA = "0x18265AA70")]
	public void NBBAPECIDBB(float AOBHKJKOOND, float KJGNCKBPPEI, List<T> GLAHAIKDMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x265AA40", Offset = "0x2659040", VA = "0x18265AA40")]
	private int MKBNHKOGOJE(int JJAEECMBIJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x265A6E0", Offset = "0x2658CE0", VA = "0x18265A6E0")]
	private void GJFEPMCHEBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T JJMHIFOJEDB();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T BPHEINFHLPF(T MOLEJFDINLH, float KAIHGPIIHIB);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T IBGEJFEGBAJ(T MBOGNALMNPH, T NDCLMFPKHPF);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T EGLMDJIPICE(T MBOGNALMNPH, T NDCLMFPKHPF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ONGNCDDNKBC : KJDNFKLIEAK<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xE0CB00", Offset = "0xE0B100", VA = "0x180E0CB00", Slot = "4")]
	protected override Vector3 JJMHIFOJEDB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6EEA4A0", Offset = "0x6EE8AA0", VA = "0x186EEA4A0", Slot = "5")]
	protected override Vector3 BPHEINFHLPF(Vector3 MOLEJFDINLH, float KAIHGPIIHIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6EEA550", Offset = "0x6EE8B50", VA = "0x186EEA550", Slot = "6")]
	protected override Vector3 IBGEJFEGBAJ(Vector3 MBOGNALMNPH, Vector3 NDCLMFPKHPF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6EEA4E0", Offset = "0x6EE8AE0", VA = "0x186EEA4E0", Slot = "7")]
	protected override Vector3 EGLMDJIPICE(Vector3 MBOGNALMNPH, Vector3 NDCLMFPKHPF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6EEA5A0", Offset = "0x6EE8BA0", VA = "0x186EEA5A0")]
	public ONGNCDDNKBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FBKLJGLLLBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IDisposable HAMPJMKDJOL;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public FBKLJGLLLBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PHEPDEKEJDP : ICLFBBGCNNL<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6EEA6C0", Offset = "0x6EE8CC0", VA = "0x186EEA6C0")]
	public PHEPDEKEJDP(int LEFNHMBHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6EEA650", Offset = "0x6EE8C50", VA = "0x186EEA650", Slot = "6")]
	protected override uint FGHNMFHKGGL(uint DEOOIHJFHDN, string MOLEJFDINLH)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public class ILEAGJFLIIM<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private ILEAGJFLIIM<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xE93CC0", Offset = "0xE922C0", VA = "0x180E93CC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x278D1D0", Offset = "0x278B7D0", VA = "0x18278D1D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x278E8C0", Offset = "0x278CEC0", VA = "0x18278E8C0")]
		public Enumerator(ILEAGJFLIIM<T> GLAHAIKDMIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x27882D0", Offset = "0x27868D0", VA = "0x1827882D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x278B000", Offset = "0x2789600", VA = "0x18278B000", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2787700", Offset = "0x2785D00", VA = "0x182787700")]
		private void BJCKCEGMCAO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private T[] AJIILDPOFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int FJBDCKBJAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int DCPIMNCPENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int MPNDOHBKHJO;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x30517B0", Offset = "0x304FDB0", VA = "0x1830517B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3051990", Offset = "0x304FF90", VA = "0x183051990")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3051C00", Offset = "0x3050200", VA = "0x183051C00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3052A30", Offset = "0x3051030", VA = "0x183052A30")]
	public ILEAGJFLIIM(int LEFNHMBHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3052740", Offset = "0x3050D40", VA = "0x183052740")]
	public void PDDBDHJNBOH(T KAIHGPIIHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x30517F0", Offset = "0x304FDF0", VA = "0x1830517F0")]
	public void FBJOPIHCMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3051900", Offset = "0x304FF00", VA = "0x183051900")]
	public void GCDGKBGOEJI(int FJLPCOJGEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3051F80", Offset = "0x3050580", VA = "0x183051F80")]
	public void HJEFDKOEHDC(T[] IACDCADJJAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x30518B0", Offset = "0x304FEB0", VA = "0x1830518B0")]
	public Enumerator FGHGHABHEPH()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x30528B0", Offset = "0x3050EB0", VA = "0x1830528B0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x30528B0", Offset = "0x3050EB0", VA = "0x1830528B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x30524D0", Offset = "0x3050AD0", VA = "0x1830524D0")]
	private int PABOILPNPJM(int OLGOBCPPPBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3051780", Offset = "0x304FD80", VA = "0x183051780")]
	private int BMBLDGCLMEJ(int OLGOBCPPPBB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct AAHDGLMODJL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> FICGELBOLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int OOGJLHKHPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int FEIMNPLDIPE;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x24D6070", Offset = "0x24D4670", VA = "0x1824D6070")]
	private AAHDGLMODJL(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> AIPMIHEGLMP, int AEHGCGABDII, int GMKBFDBHHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2C4F9E0", Offset = "0x2C4DFE0", VA = "0x182C4F9E0")]
	public static AAHDGLMODJL<T> OGNDBCBGIDA()
	{
		return default(AAHDGLMODJL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2C4ED80", Offset = "0x2C4D380", VA = "0x182C4ED80")]
	public (int, int, Task<T>) DICOHPMMJCL(int FCNDKEMFAHH, [Optional] CancellationToken KEGMOCPJOHL, double MIKGPKAPCMA = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2C4E590", Offset = "0x2C4CB90", VA = "0x182C4E590")]
	public void AHNODGKEAND(int FCNDKEMFAHH, int GMKBFDBHHMD, in T NKONLKNLFIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class NJJJNJJAHKH
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6EEA450", Offset = "0x6EE8A50", VA = "0x186EEA450")]
	public static AAHDGLMODJL<CMCGOMMIJLE> OGNDBCBGIDA()
	{
		return default(AAHDGLMODJL<CMCGOMMIJLE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6EEA3D0", Offset = "0x6EE89D0", VA = "0x186EEA3D0")]
	public static void AHNODGKEAND(this in AAHDGLMODJL<CMCGOMMIJLE> CDBMADFDGCE, int FCNDKEMFAHH, int GMKBFDBHHMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[DefaultMember("Item")]
public class CGMGKHJLCJO<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TVal> MBIEOAAAJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TVal, TKey> DNAFPAODIDL;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x17B56D0", Offset = "0x17B3CD0", VA = "0x1817B56D0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool MIKIMACELCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICollection<TKey> GLBJABAABEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2272730", Offset = "0x2270D30", VA = "0x182272730", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TVal> DFPIHABKBDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x179B850", Offset = "0x1799E50", VA = "0x18179B850", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TVal ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2B79B30", Offset = "0x2B78130", VA = "0x182B79B30", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B79BA0", Offset = "0x2B781A0", VA = "0x182B79BA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TKey ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B79590", Offset = "0x2B77B90", VA = "0x182B79590")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2B791C0", Offset = "0x2B777C0", VA = "0x182B791C0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2B79950", Offset = "0x2B77F50", VA = "0x182B79950", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2B790E0", Offset = "0x2B776E0", VA = "0x182B790E0", Slot = "9")]
	public void Add(TKey BOMEFJIOGGM, TVal MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2B79180", Offset = "0x2B77780", VA = "0x182B79180", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> MDCAOIKFJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2B79220", Offset = "0x2B77820", VA = "0x182B79220", Slot = "8")]
	public bool ContainsKey(TKey BOMEFJIOGGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2B79250", Offset = "0x2B77850", VA = "0x182B79250", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> MDCAOIKFJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x25444A0", Offset = "0x2542AA0", VA = "0x1825444A0", Slot = "10")]
	public bool Remove(TKey BOMEFJIOGGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2B79920", Offset = "0x2B77F20", VA = "0x182B79920", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> MDCAOIKFJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x17B55B0", Offset = "0x17B3BB0", VA = "0x1817B55B0", Slot = "11")]
	public bool TryGetValue(TKey BOMEFJIOGGM, out TVal MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2B795D0", Offset = "0x2B77BD0", VA = "0x182B795D0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2B792E0", Offset = "0x2B778E0", VA = "0x182B792E0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] IACDCADJJAN, int AJIOAJHCAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2B79880", Offset = "0x2B77E80", VA = "0x182B79880")]
	public bool PFDPJLFFHJD(TVal BOMEFJIOGGM, out TKey MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2B79760", Offset = "0x2B77D60", VA = "0x182B79760")]
	private void PBFLNNGNJLH(TKey BOMEFJIOGGM, TVal PMMAPONKBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2B78F80", Offset = "0x2B77580", VA = "0x182B78F80")]
	private void AHIFFONEPKE(TKey BOMEFJIOGGM, TVal PMMAPONKBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2B794C0", Offset = "0x2B77AC0", VA = "0x182B794C0")]
	private bool DEMMIHACPNI(TKey BOMEFJIOGGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2B79A40", Offset = "0x2B78040", VA = "0x182B79A40")]
	public CGMGKHJLCJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class NLEILNCFPDP<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Func<Internal, External> NJEILCFGOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private IReadOnlyList<Internal> CKIKFMIOAHP;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2722370", Offset = "0x2720970", VA = "0x182722370", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2722310", Offset = "0x2720910", VA = "0x182722310", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1F085A0", Offset = "0x1F06BA0", VA = "0x181F085A0")]
	public NLEILNCFPDP(Func<Internal, External> NJEILCFGOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x27222C0", Offset = "0x27208C0", VA = "0x1827222C0")]
	public NLEILNCFPDP(IReadOnlyList<Internal> CKIKFMIOAHP, Func<Internal, External> NJEILCFGOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2722250", Offset = "0x2720850", VA = "0x182722250", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1E71B70", Offset = "0x1E70170", VA = "0x181E71B70", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NMDBJHGPGIP<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate Task<TResult> HDAEGECHFAN(TRequest FEBOEFLLEJB, CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum OHMJDLCANFO
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class IDNPJGFEIEP
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const float AHMGHHIEFNE = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TimeSpan EHPKFPKEPJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int LKLHEFHMKKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public OHMJDLCANFO EAGHAIMCNFA;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly IDNPJGFEIEP EOJNEJPDGDL;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float KBKCELAGFHP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x1CE2850", Offset = "0x1CE0E50", VA = "0x181CE2850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan LOJFGBLICLO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1CE29A0", Offset = "0x1CE0FA0", VA = "0x181CE29A0")]
		public IDNPJGFEIEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private readonly struct NIHOMDGKCBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly TRequest FEBOEFLLEJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly CancellationToken KEGMOCPJOHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly TaskCompletionSource<TResult> BDGEAAHMFOM;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x271E230", Offset = "0x271C830", VA = "0x18271E230")]
		public NIHOMDGKCBA(TRequest FEBOEFLLEJB, TaskCompletionSource<TResult> BDGEAAHMFOM, CancellationToken KEGMOCPJOHL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class MGOHOMIACCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public NMDBJHGPGIP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public MGOHOMIACCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B860", Offset = "0x2B49E60", VA = "0x182B4B860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class IMNDFFNOEJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NMDBJHGPGIP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private NIHOMDGKCBA <req>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Task<TResult> <processTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TResult <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TResult <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private OperationCanceledException <oce>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private Exception <ex>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public IMNDFFNOEJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x305FA50", Offset = "0x305E050", VA = "0x18305FA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CancellationTokenSource GHEFIMMEABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<NIHOMDGKCBA> ECIGHCJACHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly IDNPJGFEIEP HLCNAHCDDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly HDAEGECHFAN PFOABFFNAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Task CHNNNFGKEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int AONOBCHINPG;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2725F80", Offset = "0x2724580", VA = "0x182725F80")]
	public NMDBJHGPGIP(HDAEGECHFAN PFOABFFNAEO, [Optional] IDNPJGFEIEP HLCNAHCDDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2725820", Offset = "0x2723E20", VA = "0x182725820")]
	public Task<TResult> JNFFCJDHMGH(TRequest FEBOEFLLEJB, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x27253E0", Offset = "0x27239E0", VA = "0x1827253E0")]
	private void JBMCDKAFKKN(NIHOMDGKCBA KFABPNIMDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2725C70", Offset = "0x2724270", VA = "0x182725C70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NMDBJHGPGIP<, >.MGOHOMIACCK))]
	private Task PIKGLKECAAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2724AE0", Offset = "0x27230E0", VA = "0x182724AE0")]
	private NIHOMDGKCBA CIMFLLNENFH()
	{
		return default(NIHOMDGKCBA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x27245E0", Offset = "0x2722BE0", VA = "0x1827245E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NMDBJHGPGIP<, >.IMNDFFNOEJP))]
	private Task BHKJLCGAJAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x27251D0", Offset = "0x27237D0", VA = "0x1827251D0")]
	private void GOIIDGHAEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2724FF0", Offset = "0x27235F0", VA = "0x182724FF0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x271E0A0", Offset = "0x271C6A0", VA = "0x18271E0A0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6D65910", Offset = "0x6D63F10", VA = "0x186D65910")]
		public SerializedGuid(in Guid NAMBIBPENHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6EEBB60", Offset = "0x6EEA160", VA = "0x186EEBB60")]
		public static SerializedGuid DEIGECCALDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6EEBD80", Offset = "0x6EEA380", VA = "0x186EEBD80")]
		public static SerializedGuid HAEMDFHBLDH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6EEBE10", Offset = "0x6EEA410", VA = "0x186EEBE10")]
		public bool NAOMKKANDIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6D658E0", Offset = "0x6D63EE0", VA = "0x186D658E0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6EEBEA0", Offset = "0x6EEA4A0", VA = "0x186EEBEA0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6EEBBF0", Offset = "0x6EEA1F0", VA = "0x186EEBBF0", Slot = "7")]
		public bool Equals(SerializedGuid FKJGPCABBJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6EEBCA0", Offset = "0x6EEA2A0", VA = "0x186EEBCA0", Slot = "0")]
		public override bool Equals(object NKFOPKJGBEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6D65830", Offset = "0x6D63E30", VA = "0x186D65830", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6D65670", Offset = "0x6D63C70", VA = "0x186D65670", Slot = "6")]
		public int CompareTo(SerializedGuid FKJGPCABBJN)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PMCBIBNBIDM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type PCFFLNGLFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string HAHAKNJCMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool FHNHHNFIJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool IGNMIBJBIBJ;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6EEA710", Offset = "0x6EE8D10", VA = "0x186EEA710")]
	public PMCBIBNBIDM(Type GFKAHEIMDME, string HGIOBMLIBOP, bool NLKCHIAENJN = false, bool DOEGMDDBKID = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class HHOPHEDOKCA<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly List<T> CKIKFMIOAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private HashSet<T> COHNNGFMCFH;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x17B56D0", Offset = "0x17B3CD0", VA = "0x1817B56D0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool MIKIMACELCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x928C00", Offset = "0x927200", VA = "0x180928C00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x218D270", Offset = "0x218B870", VA = "0x18218D270", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x218D2A0", Offset = "0x218B8A0", VA = "0x18218D2A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x218CAD0", Offset = "0x218B0D0", VA = "0x18218CAD0", Slot = "11")]
	public void Add(T MDCAOIKFJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x218CD50", Offset = "0x218B350", VA = "0x18218CD50")]
	public bool NJPHEIIBGFB(T MDCAOIKFJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x218D040", Offset = "0x218B640", VA = "0x18218D040", Slot = "15")]
	public bool Remove(T MDCAOIKFJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x17B5500", Offset = "0x17B3B00", VA = "0x1817B5500", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x218D150", Offset = "0x218B750", VA = "0x18218D150", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x218CB00", Offset = "0x218B100", VA = "0x18218CB00", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x18CC790", Offset = "0x18CAD90", VA = "0x1818CC790", Slot = "13")]
	public bool Contains(T MDCAOIKFJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x218CB60", Offset = "0x218B160", VA = "0x18218CB60", Slot = "14")]
	public void CopyTo(T[] IACDCADJJAN, int AJIOAJHCAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x218CB90", Offset = "0x218B190", VA = "0x18218CB90", Slot = "6")]
	public int IndexOf(T MDCAOIKFJBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x218CBC0", Offset = "0x218B1C0", VA = "0x18218CBC0", Slot = "7")]
	public void Insert(int OLGOBCPPPBB, T MDCAOIKFJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x218CF70", Offset = "0x218B570", VA = "0x18218CF70", Slot = "8")]
	public void RemoveAt(int OLGOBCPPPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x218D180", Offset = "0x218B780", VA = "0x18218D180")]
	public HHOPHEDOKCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class AOOMNIGLNBK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7340", Offset = "0x6EE5940", VA = "0x186EE7340")]
	public AOOMNIGLNBK(string DPAJDIEBNKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class DHGFDGDCGEP
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7690", Offset = "0x6EE5C90", VA = "0x186EE7690")]
	[NotNull]
	public static byte[] DBKAFFIFFJK(this GGPIMHBGJEH BPPFPBOMGJA, HashAlgorithmName PJLIFDCHONE, byte[] LLCAOMKFMIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface GGPIMHBGJEH
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash DEOOIHJFHDN);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface EPDJHAPCLEA : GGPIMHBGJEH
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	[CanBeNull]
	byte[] PEFNHFPLEDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[CanBeNull]
	byte[] OEIJKFHLJDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class FEGODLJGHHD
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly ArrayPool<byte> OIOOHAAMGBH;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static bool BOOGPFPEIPI;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8580", Offset = "0x6EE6B80", VA = "0x186EE8580")]
	public static void MILDGAGIFOC(this IncrementalHash JMEGBHAICIH, [CanBeNull] GameObject FLCGKEKAMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1C637D0", Offset = "0x1C61DD0", VA = "0x181C637D0")]
	public static void MILDGAGIFOC<T>(this IncrementalHash JMEGBHAICIH, [CanBeNull] T JPNJMHFMKKE) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x1C638A0", Offset = "0x1C61EA0", VA = "0x181C638A0")]
	public static void OFPHNPPOJLB<T>(this IncrementalHash JMEGBHAICIH, [CanBeNull] T BPPFPBOMGJA) where T : GGPIMHBGJEH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1C62C90", Offset = "0x1C61290", VA = "0x181C62C90")]
	public static void BMOCIIOJGCH<T>(this IncrementalHash JMEGBHAICIH, [CanBeNull] IList<T> GEGFPLOGDNL) where T : GGPIMHBGJEH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6EE82B0", Offset = "0x6EE68B0", VA = "0x186EE82B0")]
	private static bool FECHCEAJNMJ([CanBeNull] GGPIMHBGJEH BPPFPBOMGJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7F10", Offset = "0x6EE6510", VA = "0x186EE7F10")]
	public static void DKMKDDFNHHI(this IncrementalHash DEOOIHJFHDN, [CanBeNull] string ELBMKBLGKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6EE86D0", Offset = "0x6EE6CD0", VA = "0x186EE86D0")]
	public static void NOCBFNALFGI(this IncrementalHash DEOOIHJFHDN, long CNOBIBKFMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7CE0", Offset = "0x6EE62E0", VA = "0x186EE7CE0")]
	public static void CADECAJIJKP(this IncrementalHash DEOOIHJFHDN, int HNGNOGPHHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6EE80E0", Offset = "0x6EE66E0", VA = "0x186EE80E0")]
	public static void EGIHHEJNAGH(this IncrementalHash DEOOIHJFHDN, short LAAIGIBOOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7F70", Offset = "0x6EE6570", VA = "0x186EE7F70")]
	public static void DMLPJLEGKEC(this IncrementalHash DEOOIHJFHDN, byte OIANNLODHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7B10", Offset = "0x6EE6110", VA = "0x186EE7B10")]
	public static void BNCBOBOPIHH(this IncrementalHash DEOOIHJFHDN, bool JNOKHNMJFOC, bool FKGKHNIPFKD = false, bool EOFFFAMHEJB = false, bool FDNFEPEPEPF = false, bool PPEAHAEOIIN = false, bool AIMBKKPNDGP = false, bool IFFDGEBGMEH = false, bool IDCJBDIFAII = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1C630E0", Offset = "0x1C616E0", VA = "0x181C630E0")]
	public static void MIAAKEGCAEB<T>(this IncrementalHash DEOOIHJFHDN, T KEFANKKKDEM) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7EB0", Offset = "0x6EE64B0", VA = "0x186EE7EB0")]
	public static void CDIMEDFNOJB(this IncrementalHash DEOOIHJFHDN, float HCHLCIFNKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8510", Offset = "0x6EE6B10", VA = "0x186EE8510")]
	public static void KIGLNNDHLPM(this IncrementalHash DEOOIHJFHDN, ulong LJEOBPDHFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8670", Offset = "0x6EE6C70", VA = "0x186EE8670")]
	public static void NBGPBEGOIMP(this IncrementalHash DEOOIHJFHDN, uint OKLIFDOKKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6EE84A0", Offset = "0x6EE6AA0", VA = "0x186EE84A0")]
	public static void JFCIKNIBOPI(this IncrementalHash DEOOIHJFHDN, ushort HCOLKGIKGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8340", Offset = "0x6EE6940", VA = "0x186EE8340")]
	public static void IOCEBOBFHOP(this IncrementalHash DEOOIHJFHDN, Vector3 BIGCGEOONKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class FHEBEFBHCOH
{
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8A10", Offset = "0x6EE7010", VA = "0x186EE8A10")]
	[NotNull]
	public static byte[] DBKAFFIFFJK(this EPDJHAPCLEA HFKJKBGJBKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6EE89A0", Offset = "0x6EE6FA0", VA = "0x186EE89A0")]
	[NotNull]
	public static byte[] DBKAFFIFFJK(this EPDJHAPCLEA HFKJKBGJBKN, HashAlgorithmName PJLIFDCHONE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8BA0", Offset = "0x6EE71A0", VA = "0x186EE8BA0")]
	public static bool KKLJKGEFPCD([CanBeNull] this EPDJHAPCLEA HFKJKBGJBKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8D30", Offset = "0x6EE7330", VA = "0x186EE8D30")]
	public static bool KKLJKGEFPCD([CanBeNull] this EPDJHAPCLEA HFKJKBGJBKN, out string PMBGBHCKNKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8A80", Offset = "0x6EE7080", VA = "0x186EE8A80")]
	private static bool DGGAEEGBAAC([NotNull] EPDJHAPCLEA HFKJKBGJBKN, [CanBeNull] out byte[] KOIHKFCAKOE, [CanBeNull] out byte[] LEAMBJEFBHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public abstract class MPMNKJBGPIP<TTask, T> : GNLDNMJDMJM<T>, EHFDGFBHKBK, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class HIJBECMFGLN
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private sealed class <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public HIJBECMFGLN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
			public <<-ctor>g__AwaitThenTransformTaskResult|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x19A6120", Offset = "0x19A4720", VA = "0x1819A6120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public MPMNKJBGPIP<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public HIJBECMFGLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x218D920", Offset = "0x218BF20", VA = "0x18218D920")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(MPMNKJBGPIP<, >.HIJBECMFGLN.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> AGMNIFNCNAD(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static bool KGKGIOLIGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Task<T> JDOLHKOIGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	protected readonly CancellationTokenSource CGFLGAGNMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool IPAONFGPPJE;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Task<T> IGAFCMFMDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public MFBKDKPGMNP<T> OOILNEMBFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool HJJCFGPENBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x9C9820", Offset = "0x9C7E20", VA = "0x1809C9820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2416400", Offset = "0x2414A00", VA = "0x182416400")]
	static MPMNKJBGPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2416760", Offset = "0x2414D60", VA = "0x182416760")]
	protected MPMNKJBGPIP(TTask JDOLHKOIGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2416390", Offset = "0x2414990", VA = "0x182416390", Slot = "1")]
	~MPMNKJBGPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2416360", Offset = "0x2414960", VA = "0x182416360", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2416190", Offset = "0x2414790", VA = "0x182416190")]
	private void CDAHFAFMGOG(bool NIIIECNHJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T BCKCJGPGBLI(TTask HAIKOCAOHIE);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void KIIJLCGMCLK();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class KCAKDDOAHOB<T> : GNLDNMJDMJM<T>, EHFDGFBHKBK, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task<T> IGAFCMFMDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public MFBKDKPGMNP<T> OOILNEMBFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2544BF0", Offset = "0x25431F0", VA = "0x182544BF0")]
	public KCAKDDOAHOB(Exception IAPFIFFPKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface EHFDGFBHKBK : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface GNLDNMJDMJM<T> : EHFDGFBHKBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	[NotNull]
	Task<T> IGAFCMFMDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	[NotNull]
	MFBKDKPGMNP<T> OOILNEMBFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class OOLLOAHGMNA : OINIMJILHNA<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6EEA610", Offset = "0x6EE8C10", VA = "0x186EEA610")]
	public OOLLOAHGMNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class OINIMJILHNA<T> : GNLDNMJDMJM<T>, EHFDGFBHKBK, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Task<T> IGAFCMFMDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MFBKDKPGMNP<T> OOILNEMBFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2F328D0", Offset = "0x2F30ED0", VA = "0x182F328D0")]
	public OINIMJILHNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class BPMBBNCDHHK : BAOHAJMDGEC<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class FMNJCCLHOEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Action<BPMBBNCDHHK, IAMDAJKPFJC> callback;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FMNJCCLHOEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8ED0", Offset = "0x6EE74D0", VA = "0x186EE8ED0")]
		internal void NMLPAMGAMNC(BAOHAJMDGEC<string> timer, IAMDAJKPFJC log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7490", Offset = "0x6EE5A90", VA = "0x186EE7490")]
	public BPMBBNCDHHK(IAMDAJKPFJC BILPDCGHAAG, [Optional] string GHPJAKNJMON, [Optional] int? FFKDGFPKPIC, [Optional] Stopwatch HFOBMDAADLC, [Optional] Action<string, FDCPHNMOMAM, IAMDAJKPFJC> JGLPCJNJOLB, [Optional] Action<string, FDCPHNMOMAM, IAMDAJKPFJC> OMKHBIMIKCO, [Optional] Action<BPMBBNCDHHK, IAMDAJKPFJC> LBKLDGLBHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE73B0", Offset = "0x6EE59B0", VA = "0x186EE73B0")]
	private static Action<BAOHAJMDGEC<string>, IAMDAJKPFJC> EFBOGMHFLEF(Action<BPMBBNCDHHK, IAMDAJKPFJC> AJNAMFOHMMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class OICGNPMHOGE<TKey> : KPAGOOOPGJB<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public delegate string GKNOACKEDMJ(TKey BOMEFJIOGGM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly string NKAJJOJMABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly double CPMIEDGLMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly bool HBCBCHJIKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly int LAKJNCMAAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly ISet<string> FJANKNHNEAO;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2F2FF60", Offset = "0x2F2E560", VA = "0x182F2FF60")]
	private static string EFHPKOCFMEG(TKey BOMEFJIOGGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2F30820", Offset = "0x2F2EE20", VA = "0x182F30820")]
	public OICGNPMHOGE(string NKAJJOJMABG = "F2", double CPMIEDGLMHJ = double.MaxValue, bool HBCBCHJIKGO = false, int LAKJNCMAAHI = int.MaxValue, [Optional] ISet<string> FJANKNHNEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2F304E0", Offset = "0x2F2EAE0", VA = "0x182F304E0", Slot = "4")]
	public override Dictionary<string, string> FJPFLDLNCBI(BAOHAJMDGEC<TKey> MHKBFIBGEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2F30740", Offset = "0x2F2ED40", VA = "0x182F30740")]
	private bool OLPBGIIJLME(string KIEKOIOBPMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2F2FFA0", Offset = "0x2F2E5A0", VA = "0x182F2FFA0")]
	public Dictionary<string, string> FJPFLDLNCBI(BAOHAJMDGEC<TKey> MHKBFIBGEFP, GKNOACKEDMJ NFALCOOLBBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2F30590", Offset = "0x2F2EB90", VA = "0x182F30590")]
	private string IICFIMAKLIB(StringBuilder HAGBFNLJFCE, List<TKey> EJHKMCNCDLP, GKNOACKEDMJ NFALCOOLBBK, bool AEBPPPAJEND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2F2FDE0", Offset = "0x2F2E3E0", VA = "0x182F2FDE0")]
	private static void BJNMJNHCINF(StringBuilder HCLHIODIPBB, string KNKCMJOBMBB, bool LLFKEAFPGOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public abstract class KPAGOOOPGJB<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut FJPFLDLNCBI(BAOHAJMDGEC<TKey> MHKBFIBGEFP);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
	protected KPAGOOOPGJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public abstract class INJBMMMJBAE<TKey> : KPAGOOOPGJB<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate string PHFOIJLIICC(TKey BOMEFJIOGGM);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3E25AF0", Offset = "0x3E240F0", VA = "0x183E25AF0")]
	private static string EFHPKOCFMEG(TKey BOMEFJIOGGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3E25C60", Offset = "0x3E24260", VA = "0x183E25C60", Slot = "4")]
	public override string FJPFLDLNCBI(BAOHAJMDGEC<TKey> MHKBFIBGEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3E25B30", Offset = "0x3E24130", VA = "0x183E25B30")]
	public string FJPFLDLNCBI(BAOHAJMDGEC<TKey> MHKBFIBGEFP, [NotNull] PHFOIJLIICC NFALCOOLBBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string JBHOLDNFPKF(BAOHAJMDGEC<TKey> MHKBFIBGEFP, [NotNull] PHFOIJLIICC NFALCOOLBBK);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x227D590", Offset = "0x227BB90", VA = "0x18227D590")]
	protected INJBMMMJBAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class EPJNEAGPCHD
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private class NBPOGGMLMEI : EPJNEAGPCHD
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public static EPJNEAGPCHD HAMPJMKDJOL
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x6EEA270", Offset = "0x6EE8870", VA = "0x186EEA270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override float LCDAEPPKMLH
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x6E708A0", Offset = "0x6E6EEA0", VA = "0x186E708A0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA370", Offset = "0x6EE8970", VA = "0x186EEA370")]
		public NBPOGGMLMEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static EPJNEAGPCHD CMKALKCDJBD;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static EPJNEAGPCHD EOJNEJPDGDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7920", Offset = "0x6EE5F20", VA = "0x186EE7920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public abstract float LCDAEPPKMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	protected EPJNEAGPCHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class APKHCFMDHOD<TKey> : INJBMMMJBAE<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct CCBKKGMJECH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public PHFOIJLIICC keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static APKHCFMDHOD<TKey> HAMPJMKDJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly string[] CFKCNOAEFFN;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x208C570", Offset = "0x208AB70", VA = "0x18208C570")]
	private APKHCFMDHOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x208B580", Offset = "0x2089B80", VA = "0x18208B580", Slot = "5")]
	protected override string JBHOLDNFPKF(BAOHAJMDGEC<TKey> MHKBFIBGEFP, PHFOIJLIICC NFALCOOLBBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x208B490", Offset = "0x2089A90", VA = "0x18208B490")]
	[CompilerGenerated]
	internal static string CAEFOKMEFLB(string GHCCOJKNNAP, TKey BOMEFJIOGGM, ref CCBKKGMJECH P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class BAOHAJMDGEC<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public readonly struct FDCPHNMOMAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly long IPAJOCLCEGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly long PAKFCEIPDIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public readonly int FFKDGFPKPIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public readonly int AAANJEIJPBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public readonly bool JNBFFFPPDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly string HPODKBBOPEO;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x49DE1C0", Offset = "0x49DC7C0", VA = "0x1849DE1C0")]
		public FDCPHNMOMAM(long IPAJOCLCEGK, int FFKDGFPKPIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x49DE230", Offset = "0x49DC830", VA = "0x1849DE230")]
		public FDCPHNMOMAM(long IPAJOCLCEGK, long PAKFCEIPDIJ, int FFKDGFPKPIC, int AAANJEIJPBJ, bool JNBFFFPPDHE, string HPODKBBOPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x49DE020", Offset = "0x49DC620", VA = "0x1849DE020")]
		public int BFKPELMHLEO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x49DE1A0", Offset = "0x49DC7A0", VA = "0x1849DE1A0")]
		public int JONPOOMJCBO(int PKPNEGIKKNC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x49DE070", Offset = "0x49DC670", VA = "0x1849DE070")]
		public double EHGKLNFFLBD()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x49DE0E0", Offset = "0x49DC6E0", VA = "0x1849DE0E0")]
		public FDCPHNMOMAM FCNBGMAGLBC(long PAKFCEIPDIJ, int AAANJEIJPBJ)
		{
			return default(FDCPHNMOMAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class AEJDDJEKDHH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class INKHAOOEPJG<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public Func<AEJDDJEKDHH, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public AEJDDJEKDHH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private AEJDDJEKDHH <internalTimer>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private T <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
			public INKHAOOEPJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x3E25D10", Offset = "0x3E24310", VA = "0x183E25D10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public readonly TKey GGPPGDHBOOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly BAOHAJMDGEC<TKey> MHKBFIBGEFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IAMDAJKPFJC BILPDCGHAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private List<AEJDDJEKDHH> MOCEAKMGPGB;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string GOFCKPHMONF
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x21806F0", Offset = "0x217ECF0", VA = "0x1821806F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public IEnumerable<AEJDDJEKDHH> NJANFDAOLBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x29D3FB0", Offset = "0x29D25B0", VA = "0x1829D3FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public FDCPHNMOMAM AGIHGCGGEOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x29D3F60", Offset = "0x29D2560", VA = "0x1829D3F60")]
			[CompilerGenerated]
			get
			{
				return default(FDCPHNMOMAM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x29D3F80", Offset = "0x29D2580", VA = "0x1829D3F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x29D3FD0", Offset = "0x29D25D0", VA = "0x1829D3FD0")]
		internal AEJDDJEKDHH(BAOHAJMDGEC<TKey> MHKBFIBGEFP, TKey BOMEFJIOGGM, IAMDAJKPFJC BILPDCGHAAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x29D3C60", Offset = "0x29D2260", VA = "0x1829D3C60")]
		public AEJDDJEKDHH BHGMFKMAMKB(TKey BOMEFJIOGGM, [Optional] IAMDAJKPFJC? NJNDAMNMJNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2669970", Offset = "0x2667F70", VA = "0x182669970")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(INKHAOOEPJG<>))]
		public Task<T> DEMIDGJLHKH<T>(TKey BOMEFJIOGGM, Func<AEJDDJEKDHH, Task<T>> JHHCIKOIKGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x29D3DB0", Offset = "0x29D23B0", VA = "0x1829D3DB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class HHDPJAGKMEA : IEnumerable<(TKey, List<TKey>, FDCPHNMOMAM)>, IEnumerable, IEnumerator<(TKey, List<TKey>, FDCPHNMOMAM)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private (TKey key, List<TKey> path, FDCPHNMOMAM timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public BAOHAJMDGEC<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private List<TKey> <path>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private IEnumerator<(TKey key, List<TKey> path, FDCPHNMOMAM timerEntry)> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private (TKey key, List<TKey> path, FDCPHNMOMAM timerEntry) <rootTuple>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		private (TKey, List<TKey>, FDCPHNMOMAM) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x218B340", Offset = "0x2189940", VA = "0x18218B340", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, FDCPHNMOMAM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x218B3E0", Offset = "0x21899E0", VA = "0x18218B3E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x218B4A0", Offset = "0x2189AA0", VA = "0x18218B4A0")]
		[DebuggerHidden]
		public HHDPJAGKMEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x218B440", Offset = "0x2189A40", VA = "0x18218B440", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x218AF50", Offset = "0x2189550", VA = "0x18218AF50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x218AF00", Offset = "0x2189500", VA = "0x18218AF00")]
		private void FGFPPIJLKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x218B3A0", Offset = "0x21899A0", VA = "0x18218B3A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x218B280", Offset = "0x2189880", VA = "0x18218B280", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, FDCPHNMOMAM)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x218B370", Offset = "0x2189970", VA = "0x18218B370", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class FMJNMPMLAIP : IEnumerable<(TKey, List<TKey>, FDCPHNMOMAM)>, IEnumerable, IEnumerator<(TKey, List<TKey>, FDCPHNMOMAM)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private (TKey key, List<TKey> path, FDCPHNMOMAM timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private AEJDDJEKDHH timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AEJDDJEKDHH <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public BAOHAJMDGEC<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private IEnumerator<AEJDDJEKDHH> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private AEJDDJEKDHH <timerScopeChild>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private IEnumerator<(TKey key, List<TKey> path, FDCPHNMOMAM timerEntry)> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private (TKey key, List<TKey> path, FDCPHNMOMAM timerEntry) <childTuple>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private (TKey, List<TKey>, FDCPHNMOMAM) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x218B340", Offset = "0x2189940", VA = "0x18218B340", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, FDCPHNMOMAM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x31C8360", Offset = "0x31C6960", VA = "0x1831C8360", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x218B4A0", Offset = "0x2189AA0", VA = "0x18218B4A0")]
		[DebuggerHidden]
		public FMJNMPMLAIP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x31C83C0", Offset = "0x31C69C0", VA = "0x1831C83C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x31C7C30", Offset = "0x31C6230", VA = "0x1831C7C30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x31C7B70", Offset = "0x31C6170", VA = "0x1831C7B70")]
		private void FGFPPIJLKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x31C7BD0", Offset = "0x31C61D0", VA = "0x1831C7BD0")]
		private void GKPOLPOJHMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x31C8320", Offset = "0x31C6920", VA = "0x1831C8320", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x31C8240", Offset = "0x31C6840", VA = "0x1831C8240", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, FDCPHNMOMAM)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x22757D0", Offset = "0x2273DD0", VA = "0x1822757D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly Action<TKey, FDCPHNMOMAM, IAMDAJKPFJC> JGLPCJNJOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Action<TKey, FDCPHNMOMAM, IAMDAJKPFJC> OMKHBIMIKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Action<BAOHAJMDGEC<TKey>, IAMDAJKPFJC> LBKLDGLBHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly AEJDDJEKDHH CFJJMLGHDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private bool IPAONFGPPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int BKLHEIKFOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Stopwatch HFOBMDAADLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly int BGCHFMOBEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private string MLKHPDADHLP;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public AEJDDJEKDHH LCCJNEAFLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	[NotNull]
	public string GOFCKPHMONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x99CEA0", Offset = "0x99B4A0", VA = "0x18099CEA0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x2FEA090", Offset = "0x2FE8690", VA = "0x182FEA090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2FEA170", Offset = "0x2FE8770", VA = "0x182FEA170")]
	public BAOHAJMDGEC(TKey CINBPBLKMAM, IAMDAJKPFJC BILPDCGHAAG, [Optional] int? FFKDGFPKPIC, [Optional][CanBeNull] Stopwatch HFOBMDAADLC, [Optional] Action<TKey, FDCPHNMOMAM, IAMDAJKPFJC> JGLPCJNJOLB, [Optional] Action<TKey, FDCPHNMOMAM, IAMDAJKPFJC> OMKHBIMIKCO, [Optional] Action<BAOHAJMDGEC<TKey>, IAMDAJKPFJC> LBKLDGLBHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2FEA000", Offset = "0x2FE8600", VA = "0x182FEA000", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2FE9F70", Offset = "0x2FE8570", VA = "0x182FE9F70")]
	[IteratorStateMachine(typeof(BAOHAJMDGEC<>.HHDPJAGKMEA))]
	public IEnumerable<(TKey, List<TKey>, FDCPHNMOMAM)> BMDNJGBAICI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2FE9EA0", Offset = "0x2FE84A0", VA = "0x182FE9EA0")]
	[IteratorStateMachine(typeof(BAOHAJMDGEC<>.FMJNMPMLAIP))]
	private IEnumerable<(TKey, List<TKey>, FDCPHNMOMAM)> BMDNJGBAICI(List<TKey> KMNDPDKPPEJ, AEJDDJEKDHH PHCOMMFCIEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2FEA0F0", Offset = "0x2FE86F0", VA = "0x182FEA0F0")]
	private (long, int) ILAMPIMPDIE()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class MOLCOJMHKNG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly Dictionary<byte, GIECEEBEBOE> JHHFNOIPIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly ECOKPAPDJFL<GIECEEBEBOE> LHOLJLLCLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly bool JCBMKHFBGBH;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public GIECEEBEBOE BDFHNHMLOFG
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x97E0F0", Offset = "0x97C6F0", VA = "0x18097E0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Vector2 KJOEDAKPFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x99DBE0", Offset = "0x99C1E0", VA = "0x18099DBE0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x1158A40", Offset = "0x1157040", VA = "0x181158A40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private Vector2 POOIBPHGJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xFB1330", Offset = "0xFAF930", VA = "0x180FB1330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Vector2 FDDMAPHFMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9C80", Offset = "0x6EE8280", VA = "0x186EE9C80")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x16BE640", Offset = "0x16BCC40", VA = "0x1816BE640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int OMEHHNCPFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9A9BE0", Offset = "0x9A81E0", VA = "0x1809A9BE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9A9C70", Offset = "0x9A8270", VA = "0x1809A9C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9E20", Offset = "0x6EE8420", VA = "0x186EE9E20")]
	public MOLCOJMHKNG(Bounds DABFHNJHGGI, Vector2[] BHEOFJLBGOC, int HIPCNOEAECP, byte FJBDCKBJAGA, float PKKBEFMAFIH = 0f, [Optional] ECOKPAPDJFL<GIECEEBEBOE> LHOLJLLCLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9C20", Offset = "0x6EE8220", VA = "0x186EE9C20")]
	public GIECEEBEBOE NAJOLMEGDJK(byte OLGOBCPPPBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9D50", Offset = "0x6EE8350", VA = "0x186EE9D50")]
	public void PJPFKJBEIKD(Vector3 POOFJFBIOJJ, float BDKAPHFEFIA, float ADGLBNDKANL, ref List<byte> NBLMMAJBCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6EE99B0", Offset = "0x6EE7FB0", VA = "0x186EE99B0")]
	public void FEKLAGEPINJ(GIECEEBEBOE.MDCFMHCLGJP MCJLBNENGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9CA0", Offset = "0x6EE82A0", VA = "0x186EE9CA0")]
	public static int PEFHEGCIBON(Vector2[] BHEOFJLBGOC, int HIPCNOEAECP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE93E0", Offset = "0x6EE79E0", VA = "0x186EE93E0")]
	private GIECEEBEBOE AKBNGPAPONK(byte OLGOBCPPPBB, GIECEEBEBOE.NCFJOHOINNO ALOAFOCAPLM, GIECEEBEBOE HDBBNLFBJKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9570", Offset = "0x6EE7B70", VA = "0x186EE9570")]
	private void DDOMBHJJKLO(GIECEEBEBOE HDBBNLFBJKG, Vector2[] BHEOFJLBGOC, int IILLFLCALBC, int AIHIPEOABPE, int FBBFJGCHHJK, int OGMDABFLEMB, float PKKBEFMAFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE99D0", Offset = "0x6EE7FD0", VA = "0x186EE99D0")]
	private void FKIDBFAEFNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9950", Offset = "0x6EE7F50", VA = "0x186EE9950", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9BD0", Offset = "0x6EE81D0", VA = "0x186EE9BD0", Slot = "1")]
	~MOLCOJMHKNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class GIECEEBEBOE
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public enum NCFJOHOINNO
	{
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum MDCFMHCLGJP
	{
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public byte HJEFIBFMHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public Vector3 IJGLGPDDMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public Vector3 JLLEAFLJKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public Vector3 OBAAPAAFKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public Vector3 KMGKLECOLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public NCFJOHOINNO IKLCEHMKPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public GIECEEBEBOE ALENDOCOGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public List<GIECEEBEBOE> FFFOLOBLCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool GFBNPBPCPCD;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6EE93A0", Offset = "0x6EE79A0", VA = "0x186EE93A0")]
	public GIECEEBEBOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8FB0", Offset = "0x6EE75B0", VA = "0x186EE8FB0")]
	public void CNLHCEJCBPI(GIECEEBEBOE BIKOOLOFJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	public void FEKLAGEPINJ(int AOFPJMGIHGM, MDCFMHCLGJP MCJLBNENGND, int KEDAMGOIABL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9170", Offset = "0x6EE7770", VA = "0x186EE9170")]
	public void PJPFKJBEIKD(List<byte> NBLMMAJBCJJ, Vector3 POOFJFBIOJJ, float BDKAPHFEFIA, float ADGLBNDKANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9070", Offset = "0x6EE7670", VA = "0x186EE9070")]
	public bool FALEGOJGCEE(Vector3 DFPNLMILODO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9140", Offset = "0x6EE7740", VA = "0x186EE9140")]
	public bool HLELEHFDPGP(Vector3 DFPNLMILODO, float AMOLGCHGDPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6EE90C0", Offset = "0x6EE76C0", VA = "0x186EE90C0")]
	public void GMAKAKECEDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class ECOKPAPDJFL<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly Stack<T> BACDGKCHMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly List<T> PDAHEEPJKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly int OIFPADLCMPJ;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x23D8FE0", Offset = "0x23D75E0", VA = "0x1823D8FE0")]
	public static ECOKPAPDJFL<T> KAAFJKFBJIP(int LEFNHMBHKEC = 0, int OIFPADLCMPJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x23D9510", Offset = "0x23D7B10", VA = "0x1823D9510")]
	public ECOKPAPDJFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x23D9380", Offset = "0x23D7980", VA = "0x1823D9380")]
	public ECOKPAPDJFL(int LEFNHMBHKEC, int OIFPADLCMPJ = int.MaxValue, bool BCBBCHGOGGL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x23D9250", Offset = "0x23D7850", VA = "0x1823D9250")]
	public T LOHOBJFJPFF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x23D8F40", Offset = "0x23D7540", VA = "0x1823D8F40")]
	public void GIBKAEADFCC(T MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x23D8E70", Offset = "0x23D7470", VA = "0x1823D8E70")]
	private void EMCKCHBPIMK(T MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x23D9360", Offset = "0x23D7960", VA = "0x1823D9360")]
	private void MMPABDJIJJB(T MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x23D8D80", Offset = "0x23D7380", VA = "0x1823D8D80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x23D90B0", Offset = "0x23D76B0", VA = "0x1823D90B0")]
	private void KFGELDEEFDB(IEnumerable<T> AEEDPBOFDFB)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2570B60", Offset = "0x256F160", VA = "0x182570B60", Slot = "4")]
		public virtual T NJBFNPKAGNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class ICLFBBGCNNL<T> : IEnumerable<ICLFBBGCNNL<T>.MAEHMCPMLLO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct MAEHMCPMLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public T MOLEJFDINLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int OLGOBCPPPBB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class GMAOIMPHDPG : IEnumerator<MAEHMCPMLLO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private ICLFBBGCNNL<T> LAMHHEIMNAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int OLGOBCPPPBB;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x8FBD10", Offset = "0x8FA310", VA = "0x1808FBD10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public MAEHMCPMLLO PLBILPKBCNO
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x33C2120", Offset = "0x33C0720", VA = "0x1833C2120", Slot = "4")]
			get
			{
				return default(MAEHMCPMLLO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x2F80E50", Offset = "0x2F7F450", VA = "0x182F80E50")]
		public GMAOIMPHDPG(ICLFBBGCNNL<T> LAMHHEIMNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x33C1FE0", Offset = "0x33C05E0", VA = "0x1833C1FE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x278AAC0", Offset = "0x27890C0", VA = "0x18278AAC0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xC0B550", Offset = "0xC09B50", VA = "0x180C0B550", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct HMGCPIIDFHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public bool OJPCLHHGLCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public T MOLEJFDINLH;
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private const int OHKHCBFOIIO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Dictionary<T, int> AOJBLGDMNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private HMGCPIIDFHA[] IKFKMJJDCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private int ADHLCAHIENF;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int ADMIFGKKJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x9A37B0", Offset = "0x9A1DB0", VA = "0x1809A37B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9B8070", Offset = "0x9B6670", VA = "0x1809B8070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x17B56D0", Offset = "0x17B3CD0", VA = "0x1817B56D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1600", Offset = "0x1CDFC00", VA = "0x181CE1600")]
	public ICLFBBGCNNL(int LEFNHMBHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1AB0", Offset = "0x1CE00B0", VA = "0x181CE1AB0")]
	public ICLFBBGCNNL(MAEHMCPMLLO[] JMCAJMJAJMF, bool POLJNKICNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x1CE0EA0", Offset = "0x1CDF4A0", VA = "0x181CE0EA0")]
	public int GKBFJCFJIDJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x1CE0BC0", Offset = "0x1CDF1C0", VA = "0x181CE0BC0")]
	private int EABEEDDKKIG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x1CE0DE0", Offset = "0x1CDF3E0", VA = "0x181CE0DE0", Slot = "6")]
	protected virtual uint FGHNMFHKGGL(uint DEOOIHJFHDN, T MOLEJFDINLH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1540", Offset = "0x1CDFB40", VA = "0x181CE1540")]
	public bool PKJKKCJBFNL(T MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1460", Offset = "0x1CDFA60", VA = "0x181CE1460")]
	public int OLHJKBABJNI(T MOLEJFDINLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x1CE0F80", Offset = "0x1CDF580", VA = "0x181CE0F80")]
	public T KMEKHMMFBCC(int OLGOBCPPPBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1000", Offset = "0x1CDF600", VA = "0x181CE1000")]
	public bool NJPHEIIBGFB(T MOLEJFDINLH, bool ONNJBKMLHPC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1040", Offset = "0x1CDF640", VA = "0x181CE1040")]
	public bool NJPHEIIBGFB(T MOLEJFDINLH, int OLGOBCPPPBB, bool ONNJBKMLHPC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x1CE0E00", Offset = "0x1CDF400", VA = "0x181CE0E00")]
	private int FOAPIHPIEJG(int FJBDCKBJAGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1580", Offset = "0x1CDFB80", VA = "0x181CE1580", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1580", Offset = "0x1CDFB80", VA = "0x181CE1580", Slot = "4")]
	private IEnumerator<MAEHMCPMLLO> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		[GBPFONMOEMB(JHNBNMNOADF.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x6EEA870", Offset = "0x6EE8E70", VA = "0x186EEA870")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x6EEAB00", Offset = "0x6EE9100", VA = "0x186EEAB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x6EEAA30", Offset = "0x6EE9030", VA = "0x186EEAA30")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x6EEA7E0", Offset = "0x6EE8DE0", VA = "0x186EEA7E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x6EEAA70", Offset = "0x6EE9070", VA = "0x186EEAA70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x6EEA9A0", Offset = "0x6EE8FA0", VA = "0x186EEA9A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA780", Offset = "0x6EE8D80", VA = "0x186EEA780")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class OMPDCPALPLD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private int LEFNHMBHKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private int FGHNMEMEJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private List<T> NCBGBGGOJOG;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x225B220", Offset = "0x2259820", VA = "0x18225B220")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public T LEMPBCPLEBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2912E30", Offset = "0x2911430", VA = "0x182912E30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public T CBCFAGMCNAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2912F00", Offset = "0x2911500", VA = "0x182912F00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public T FNAOGAAODNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2912BC0", Offset = "0x29111C0", VA = "0x182912BC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x2913110", Offset = "0x2911710", VA = "0x182913110")]
	public OMPDCPALPLD(int LEFNHMBHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x2913030", Offset = "0x2911630", VA = "0x182913030")]
	public void PDDBDHJNBOH(T CCPLLCNEIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x2912C70", Offset = "0x2911270", VA = "0x182912C70")]
	public void FBJOPIHCMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x2912D00", Offset = "0x2911300", VA = "0x182912D00")]
	public void HDDKKMDIMAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x2912CB0", Offset = "0x29112B0", VA = "0x182912CB0")]
	public void GCPDFCHIBON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2912DA0", Offset = "0x29113A0", VA = "0x182912DA0")]
	public void IHHHCLLCGAA()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public struct KPLNEADJDPP<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private readonly List<Component> CKIKFMIOAHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private readonly bool JLKFOPHCCAI;

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x1D42BE0", Offset = "0x1D411E0", VA = "0x181D42BE0")]
			public KPLNEADJDPP(List<Component> CKIKFMIOAHP, bool JLKFOPHCCAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x3546E40", Offset = "0x3545440", VA = "0x183546E40")]
			public BNDPEBDHGFF<T> FGHGHABHEPH()
			{
				return default(BNDPEBDHGFF<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x3546EB0", Offset = "0x35454B0", VA = "0x183546EB0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x3546EB0", Offset = "0x35454B0", VA = "0x183546EB0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct BNDPEBDHGFF<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private readonly List<Component> CKIKFMIOAHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private readonly bool JLKFOPHCCAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private int OLGOBCPPPBB;

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public T PLBILPKBCNO
			{
				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x1E691E0", Offset = "0x1E677E0", VA = "0x181E691E0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x1E69170", Offset = "0x1E67770", VA = "0x181E69170", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x1E691B0", Offset = "0x1E677B0", VA = "0x181E691B0")]
			public BNDPEBDHGFF(List<Component> CKIKFMIOAHP, bool JLKFOPHCCAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x1E69090", Offset = "0x1E67690", VA = "0x181E69090", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x1E690A0", Offset = "0x1E676A0", VA = "0x181E690A0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1E69160", Offset = "0x1E67760", VA = "0x181E69160", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC310", Offset = "0x6EEA910", VA = "0x186EEC310")]
		private void GMAKAKECEDK(GameObject LFMEKIMOADD, bool ODPLBAPFKKP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC480", Offset = "0x6EEAA80", VA = "0x186EEC480")]
		public static void GMAKAKECEDK(GameObject LFMEKIMOADD, ref ToolHierarchyCache IFBIMPBNLEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x16EEC60", Offset = "0x16ED260", VA = "0x1816EEC60")]
		public void BMHICBEKFFL<T>(Action<T> ILLCNPCAHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x16EEBE0", Offset = "0x16ED1E0", VA = "0x1816EEBE0")]
		public T AFKNHDKGOMJ<T>(bool JLKFOPHCCAI = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x16EEEF0", Offset = "0x16ED4F0", VA = "0x1816EEEF0")]
		public KPLNEADJDPP<T> ELMGECBCMCP<T>(bool JLKFOPHCCAI = false) where T : class
		{
			return default(KPLNEADJDPP<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6EEBF40", Offset = "0x6EEA540", VA = "0x186EEBF40")]
		public List<Component> CELBOOCGGAD(Type KLGGKKGCLHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC290", Offset = "0x6EEA890", VA = "0x186EEC290", Slot = "4")]
		public bool Equals(ToolHierarchyCache HEICJNINGBE, ToolHierarchyCache DNLDNFFNIEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC630", Offset = "0x6EEAC30", VA = "0x186EEC630", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache NKFOPKJGBEM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class PGCEDPKIBDF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private Dictionary<int, T> PPGANGPLNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private T KCDPKKFAKPM;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public virtual T EGNDMIHNEFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7EEED0", Offset = "0x7ED4D0", VA = "0x1807EEED0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C00", Offset = "0x7F5200", VA = "0x1807F6C00", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F11D30", Offset = "0x1F10330", VA = "0x181F11D30")]
	public bool BDAJONNAIOB(T MOLEJFDINLH, int PBKHINIBPED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x1F12210", Offset = "0x1F10810", VA = "0x181F12210")]
	public bool KOIAEECBLND(int PBKHINIBPED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x1F11DF0", Offset = "0x1F103F0", VA = "0x181F11DF0")]
	public T CIFMKHLAOHC(int NJEIGBKCJOH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x1F12270", Offset = "0x1F10870", VA = "0x181F12270")]
	private bool NGHDAADEPHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x1F12410", Offset = "0x1F10A10", VA = "0x181F12410")]
	public bool PFDPJLFFHJD(int PBKHINIBPED, out T MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x1F12440", Offset = "0x1F10A40", VA = "0x181F12440")]
	public PGCEDPKIBDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class HBNPJNOEPAB<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal class JHLBGKKGKCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public TNode CDBMADFDGCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public TNode HDBBNLFBJKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public EIHDNCLABEP OKKDBGDAAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public List<EIHDNCLABEP> FPOFAMIDLKK;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public JHLBGKKGKCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal struct EIHDNCLABEP : IComparable<EIHDNCLABEP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int PBKHINIBPED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public TClaimant DKAPHJJEHFN;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xC10030", Offset = "0xC0E630", VA = "0x180C10030")]
		public EIHDNCLABEP(int PBKHINIBPED, TClaimant DKAPHJJEHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x33D6EC0", Offset = "0x33D54C0", VA = "0x1833D6EC0")]
		public bool GPENEBHHAFO(in EIHDNCLABEP FKJGPCABBJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x33D6F20", Offset = "0x33D5520", VA = "0x1833D6F20")]
		public bool OGPGCEHJBPI(in EIHDNCLABEP FKJGPCABBJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x33D6EB0", Offset = "0x33D54B0", VA = "0x1833D6EB0", Slot = "4")]
		public int CompareTo(EIHDNCLABEP FKJGPCABBJN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x33D6F30", Offset = "0x33D5530", VA = "0x1833D6F30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum DNAINAIMBGK
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class FLEJBPCDODG : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public HBNPJNOEPAB<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x18C5790", Offset = "0x18C3D90", VA = "0x1818C5790")]
		[DebuggerHidden]
		public FLEJBPCDODG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x31C2290", Offset = "0x31C0890", VA = "0x1831C2290", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x31C2460", Offset = "0x31C0A60", VA = "0x1831C2460", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x31C2380", Offset = "0x31C0980", VA = "0x1831C2380", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x18C5720", Offset = "0x18C3D20", VA = "0x1818C5720", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly ECOKPAPDJFL<JHLBGKKGKCH> GDPCDMOJCHL;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly ECOKPAPDJFL<List<EIHDNCLABEP>> PCKBDHAOJMG;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static int PKJPNMNPMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	internal readonly Dictionary<TClaimant, TNode> BHAEKOEBCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	internal readonly Dictionary<TNode, JHLBGKKGKCH> GPNLJHPDCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private DNAINAIMBGK CFNBBPIIFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode OPPJHONDIOF(TNode ELLNBMOONAG);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void GMCJEHNHCCL(TNode ELLNBMOONAG, TClaimant KILCHIKGELI, TClaimant CDLNCONNCPL);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x458D390", Offset = "0x458B990", VA = "0x18458D390")]
	public HBNPJNOEPAB(DNAINAIMBGK CFNBBPIIFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x458CCC0", Offset = "0x458B2C0", VA = "0x18458CCC0")]
	public void NLNGFKAKKAH(TNode ELLNBMOONAG, TNode EPBIFMJLJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x458CAB0", Offset = "0x458B0B0", VA = "0x18458CAB0")]
	public void KCKGBJEJBHP(TClaimant DKAPHJJEHFN, TNode MGIJJBPAENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x458BCB0", Offset = "0x458A2B0", VA = "0x18458BCB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x458C5A0", Offset = "0x458ABA0", VA = "0x18458C5A0")]
	private void GOFJFKEDADD(TClaimant DKAPHJJEHFN, TNode DHOIMABALOH, TNode MGIJJBPAENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x458BC50", Offset = "0x458A250", VA = "0x18458BC50")]
	private int DEAGBEJNJMD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x458C2E0", Offset = "0x458A8E0", VA = "0x18458C2E0")]
	private void FKONNDLKMLP(TClaimant DKAPHJJEHFN, TNode HJCEPLBONOO, TNode IOKDMANFCEJ, int JLJMJOOCBIP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x458BBC0", Offset = "0x458A1C0", VA = "0x18458BBC0")]
	private void CAGKPNCAADM(EIHDNCLABEP ODNNAAFICHB, JHLBGKKGKCH HJDDKPIFHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x458CD40", Offset = "0x458B340", VA = "0x18458CD40")]
	private void NMOJHGEJBCO(TClaimant DKAPHJJEHFN, TNode HJCEPLBONOO, TNode IOKDMANFCEJ, int JLJMJOOCBIP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x458CBB0", Offset = "0x458B1B0", VA = "0x18458CBB0")]
	private void KDGAIBINHGE(EIHDNCLABEP ODNNAAFICHB, TNode ELLNBMOONAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x458C760", Offset = "0x458AD60", VA = "0x18458C760")]
	private void INLLOGNCNND(EIHDNCLABEP ODNNAAFICHB, JHLBGKKGKCH HJDDKPIFHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x458C640", Offset = "0x458AC40", VA = "0x18458C640")]
	private void HJCLAMJAFII(JHLBGKKGKCH HJDDKPIFHLI, bool CNGHEJANKLH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x458BF10", Offset = "0x458A510", VA = "0x18458BF10")]
	private void EFHIIFEMGCD(JHLBGKKGKCH HJDDKPIFHLI, TNode EPBIFMJLJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x458CFA0", Offset = "0x458B5A0", VA = "0x18458CFA0")]
	[IteratorStateMachine(typeof(HBNPJNOEPAB<, >.FLEJBPCDODG))]
	private IEnumerable<TNode> OIDHLKGJAOH(TNode HJCEPLBONOO, TNode IOKDMANFCEJ, bool MGLBIFGFIKC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x458C9F0", Offset = "0x458AFF0", VA = "0x18458C9F0")]
	private JHLBGKKGKCH JPGGCDCJOMI(TNode ELLNBMOONAG, TNode HDBBNLFBJKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x458C860", Offset = "0x458AE60", VA = "0x18458C860")]
	private JHLBGKKGKCH JFDDEELPFPM(TNode ELLNBMOONAG, TNode HDBBNLFBJKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x458D070", Offset = "0x458B670", VA = "0x18458D070")]
	private void OINGNINHGIA(JHLBGKKGKCH HJDDKPIFHLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class LPGPEFKBMJK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	protected struct CNFDMINNGIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public T INKIKMDHKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int FFMLLKOAMMF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	protected readonly List<CNFDMINNGIG> AJIILDPOFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private T DFKEJAMBGCC;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x17B56D0", Offset = "0x17B3CD0", VA = "0x1817B56D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x28E5B50", Offset = "0x28E4150", VA = "0x1828E5B50")]
	public bool JDABAMPMFDA(T MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x28E5DC0", Offset = "0x28E43C0", VA = "0x1828E5DC0")]
	public void PDDBDHJNBOH(T MOLEJFDINLH, int PBKHINIBPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x28E59D0", Offset = "0x28E3FD0", VA = "0x1828E59D0")]
	public bool EIILGGCBFDG(T MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x28E5AF0", Offset = "0x28E40F0", VA = "0x1828E5AF0")]
	public void FBJOPIHCMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x28E5D50", Offset = "0x28E4350", VA = "0x1828E5D50")]
	public T JMOKFICCGNA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x28E5E60", Offset = "0x28E4460", VA = "0x1828E5E60")]
	private void PGMACMJDLNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x28E6010", Offset = "0x28E4610", VA = "0x1828E6010")]
	public LPGPEFKBMJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class DGEKMKDMONG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct LCGPJGIHAII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int FFMLLKOAMMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public T INKIKMDHKDA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<object, LCGPJGIHAII> PPGANGPLNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly EqualityComparer<T> FNOFOABKNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private T KCDPKKFAKPM;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public virtual T EGNDMIHNEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2DB7F10", Offset = "0x2DB6510", VA = "0x182DB7F10", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x2103270", Offset = "0x2101870", VA = "0x182103270", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool GOAODNGONAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2340", Offset = "0x2BD0940", VA = "0x182BD2340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public object LDKLFHAGGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x919C70", Offset = "0x918270", VA = "0x180919C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1D10", Offset = "0x2BD0310", VA = "0x182BD1D10")]
	public bool BDAJONNAIOB(T MOLEJFDINLH, object DCEGGIJLHGI, int PBKHINIBPED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2BD2470", Offset = "0x2BD0A70", VA = "0x182BD2470")]
	public bool KOIAEECBLND(object DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2DB89E0", Offset = "0x2DB6FE0", VA = "0x182DB89E0")]
	public bool PFDPJLFFHJD(object DCEGGIJLHGI, out T MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2BD2370", Offset = "0x2BD0970", VA = "0x182BD2370")]
	public void FBJOPIHCMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2DB8460", Offset = "0x2DB6A60", VA = "0x182DB8460")]
	private bool NGHDAADEPHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2BD5F70", Offset = "0x2BD4570", VA = "0x182BD5F70")]
	public DGEKMKDMONG()
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
