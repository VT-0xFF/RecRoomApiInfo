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
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class MPKNIEHBMHL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7595A0", Offset = "0x757DA0", VA = "0x1807595A0")]
	public MPKNIEHBMHL()
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
		[Cpp2IlInjected.Address(RVA = "0x50B450", Offset = "0x509C50", VA = "0x18050B450")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x52F8B0", Offset = "0x52E0B0", VA = "0x18052F8B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x50E430", Offset = "0x50CC30", VA = "0x18050E430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "4")]
	public virtual void HHJBFPFBHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
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
	[SerializeField]
	[MPKNIEHBMHL]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x388BD20", Offset = "0x388A520", VA = "0x18388BD20", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x388B860", Offset = "0x388A060", VA = "0x18388B860", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x388C320", Offset = "0x388AB20", VA = "0x18388C320")]
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
	private sealed class IPFBICNEBMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public IPFBICNEBMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3B9CD00", Offset = "0x3B9B500", VA = "0x183B9CD00")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[MPKNIEHBMHL]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3B99380", Offset = "0x3B97B80", VA = "0x183B99380", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3B993B0", Offset = "0x3B97BB0", VA = "0x183B993B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3B992D0", Offset = "0x3B97AD0", VA = "0x183B992D0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey DOMICNELCFM]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3B99300", Offset = "0x3B97B00", VA = "0x183B99300", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3B991D0", Offset = "0x3B979D0", VA = "0x183B991D0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3B98A30", Offset = "0x3B97230", VA = "0x183B98A30", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3B983A0", Offset = "0x3B96BA0", VA = "0x183B983A0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3B97FA0", Offset = "0x3B967A0", VA = "0x183B97FA0", Slot = "14")]
	protected virtual string IBNALICLMOI(TKeyVal PDMDLBNCPMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2AD72E0", Offset = "0x2AD5AE0", VA = "0x182AD72E0", Slot = "4")]
	public bool ContainsKey(TKey DOMICNELCFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3B990C0", Offset = "0x3B978C0", VA = "0x183B990C0", Slot = "5")]
	public bool TryGetValue(TKey DOMICNELCFM, out TVal HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3B97F10", Offset = "0x3B96710", VA = "0x183B97F10", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3B97F10", Offset = "0x3B96710", VA = "0x183B97F10", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3B990F0", Offset = "0x3B978F0", VA = "0x183B990F0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OAEJCJMPOPC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class AHEHLIBKCPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public AHEHLIBKCPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4391980", Offset = "0x4390180", VA = "0x184391980")]
		internal bool <GetSamples>b__0(global::MKCPCJMPKBK<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float FGLGFMJMCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float NCKEFAKGJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<global::MKCPCJMPKBK<float, T>> HCGGMNJNBJH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KCKAJNKHJBL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x439F130", Offset = "0x439D930", VA = "0x18439F130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x439FC60", Offset = "0x439E460", VA = "0x18439FC60")]
	public OAEJCJMPOPC(float FMIJKMMKIMK, float EKAIMJLDMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x439F9A0", Offset = "0x439E1A0", VA = "0x18439F9A0")]
	public bool NHFMEGIHEGM(float HPIAPBJIBHH, T HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x439F660", Offset = "0x439DE60", VA = "0x18439F660")]
	public IEnumerable<T> LKKPIDELPMJ(float HPIAPBJIBHH, [Optional] float? AIBEJCMGLEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x439F2F0", Offset = "0x439DAF0", VA = "0x18439F2F0")]
	public void FMAHHIGMIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x439F230", Offset = "0x439DA30", VA = "0x18439F230")]
	private void DIPDNGALHJN(float HPIAPBJIBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class JLIDMJHGFHD<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct ELGBIGACAPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public T FPOHGGJHLDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float HEDPNLHKDPO;
	}

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static float OKPJECEJICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private List<T> HNJOCPCPHLH;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const int FIMBDPNGEAB = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private ELGBIGACAPJ[] IKFPKGEHMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int ODFFFILGBKF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float ENCFDEHNOJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6EC0D0", Offset = "0x6EA8D0", VA = "0x1806EC0D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6EC1A0", Offset = "0x6EA9A0", VA = "0x1806EC1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3B5ACD0", Offset = "0x3B594D0", VA = "0x183B5ACD0")]
	public JLIDMJHGFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3B5ABF0", Offset = "0x3B593F0", VA = "0x183B5ABF0")]
	public JLIDMJHGFHD(int GDBDJPILDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3B5A9B0", Offset = "0x3B591B0", VA = "0x183B5A9B0")]
	public void MFDJFDLHFHG(float HPIAPBJIBHH, T HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3B5A5B0", Offset = "0x3B58DB0", VA = "0x183B5A5B0")]
	public void FMAHHIGMIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3B59D60", Offset = "0x3B58560", VA = "0x183B59D60")]
	public bool DKPNOKHPOPG(float KFIIFMJNGBF, float LFNGIMFKIEG, out T HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3B5A2F0", Offset = "0x3B58AF0", VA = "0x183B5A2F0")]
	public bool FCFGMEEOIJD(float KFIIFMJNGBF, float LFNGIMFKIEG, out T HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3B5A700", Offset = "0x3B58F00", VA = "0x183B5A700")]
	public void MDMBJKBLLJJ(float KFIIFMJNGBF, float LFNGIMFKIEG, List<T> KIJIMACKNGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3B5AB70", Offset = "0x3B59370", VA = "0x183B5AB70")]
	private int NMJMFCBMOJL(int FKKBCAIHMEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3B59D20", Offset = "0x3B58520", VA = "0x183B59D20")]
	private void BEMPFDIIJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BKLPHLELKJG();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T PLNPJCBPNLC(T HNCFAALBJCG, float NIDNHHLCCNA);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T GNKBGLGMICL(T PMMONDFDJHC, T EDBHGEDEAKF);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T HIIKJJLACEB(T PMMONDFDJHC, T EDBHGEDEAKF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class EODABJMCNHC : global::JLIDMJHGFHD<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x49748E0", Offset = "0x49730E0", VA = "0x1849748E0", Slot = "4")]
	protected override Vector3 BKLPHLELKJG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4974A70", Offset = "0x4973270", VA = "0x184974A70", Slot = "5")]
	protected override Vector3 PLNPJCBPNLC(Vector3 HNCFAALBJCG, float NIDNHHLCCNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4974950", Offset = "0x4973150", VA = "0x184974950", Slot = "6")]
	protected override Vector3 GNKBGLGMICL(Vector3 PMMONDFDJHC, Vector3 EDBHGEDEAKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4974A00", Offset = "0x4973200", VA = "0x184974A00", Slot = "7")]
	protected override Vector3 HIIKJJLACEB(Vector3 PMMONDFDJHC, Vector3 EDBHGEDEAKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4974B10", Offset = "0x4973310", VA = "0x184974B10")]
	public EODABJMCNHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class EHBHJAPLGGJ
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x34C0880", Offset = "0x34BF080", VA = "0x1834C0880")]
	public static global::MKCPCJMPKBK<T1, T2> OALNFBLCHMK<T1, T2>(T1 OMBIKHKFGBK, T2 LJGPFMDHPDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2AEC360", Offset = "0x2AEAB60", VA = "0x182AEC360")]
	public static global::IDKLAHBFKML<T1, T2, T3> OALNFBLCHMK<T1, T2, T3>(T1 OMBIKHKFGBK, T2 LJGPFMDHPDJ, T3 OKOAOMCOKHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x303FE20", Offset = "0x303E620", VA = "0x18303FE20")]
	internal static int POPBHDICOCJ(int GONFKJGEMED, int CDILICJHOIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x424D850", Offset = "0x424C050", VA = "0x18424D850")]
	internal static int POPBHDICOCJ(int GONFKJGEMED, int CDILICJHOIJ, int PFNAJPCPBMI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MKCPCJMPKBK<T1, T2> : IComparable<global::MKCPCJMPKBK<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T1 IJNMOIHOMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly T2 LNCBDMGGGEL;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3B22150", Offset = "0x3B20950", VA = "0x183B22150")]
	public MKCPCJMPKBK(T1 OMBIKHKFGBK, T2 LJGPFMDHPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3B20700", Offset = "0x3B1EF00", VA = "0x183B20700", Slot = "4")]
	public int CompareTo(global::MKCPCJMPKBK<T1, T2> AJEOGBNDGHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3B20820", Offset = "0x3B1F020", VA = "0x183B20820", Slot = "0")]
	public override bool Equals(object AJEOGBNDGHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3B215A0", Offset = "0x3B1FDA0", VA = "0x183B215A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3B21DE0", Offset = "0x3B205E0", VA = "0x183B21DE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class IDKLAHBFKML<T1, T2, T3> : IComparable<global::IDKLAHBFKML<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly T1 IJNMOIHOMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly T2 LNCBDMGGGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly T3 JMCHBPPJJOH;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3AC40A0", Offset = "0x3AC28A0", VA = "0x183AC40A0")]
	public IDKLAHBFKML(T1 OMBIKHKFGBK, T2 LJGPFMDHPDJ, T3 OKOAOMCOKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3AC39C0", Offset = "0x3AC21C0", VA = "0x183AC39C0", Slot = "4")]
	public int CompareTo(global::IDKLAHBFKML<T1, T2, T3> AJEOGBNDGHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3AC0", Offset = "0x3AC22C0", VA = "0x183AC3AC0", Slot = "0")]
	public override bool Equals(object AJEOGBNDGHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3D20", Offset = "0x3AC2520", VA = "0x183AC3D20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3E20", Offset = "0x3AC2620", VA = "0x183AC3E20", Slot = "3")]
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
	public T FPOHGGJHLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x50A9E0", Offset = "0x5091E0", VA = "0x18050A9E0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5C33B0", Offset = "0x5C1BB0", VA = "0x1805C33B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float ADDIFEHDJCB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6633F0", Offset = "0x661BF0", VA = "0x1806633F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3E64370", Offset = "0x3E62B70", VA = "0x183E64370")]
	public T NDMDAABILCI(float NIDNHHLCCNA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3E63F80", Offset = "0x3E62780", VA = "0x183E63F80")]
	public T DCALDPAEBHP(float NIDNHHLCCNA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T PHDAJLCFGFH(T PMMONDFDJHC, T EDBHGEDEAKF, float NIDNHHLCCNA);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4974F20", Offset = "0x4973720", VA = "0x184974F20", Slot = "4")]
	protected override float PHDAJLCFGFH(float PMMONDFDJHC, float EDBHGEDEAKF, float NIDNHHLCCNA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4974FA0", Offset = "0x49737A0", VA = "0x184974FA0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x49775C0", Offset = "0x4975DC0", VA = "0x1849775C0", Slot = "4")]
	protected override Vector3 PHDAJLCFGFH(Vector3 PMMONDFDJHC, Vector3 EDBHGEDEAKF, float NIDNHHLCCNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4977680", Offset = "0x4975E80", VA = "0x184977680")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1B4A050", Offset = "0x1B48850", VA = "0x181B4A050", Slot = "4")]
	protected override Color PHDAJLCFGFH(Color PMMONDFDJHC, Color EDBHGEDEAKF, float NIDNHHLCCNA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x49747F0", Offset = "0x4972FF0", VA = "0x1849747F0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public sealed class KPPKJLIPFKJ<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private T[] KNABCJIGLFG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DEPGKLODCFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x50B440", Offset = "0x509C40", VA = "0x18050B440")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5C71C0", Offset = "0x5C59C0", VA = "0x1805C71C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T BBAEBFDMEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3AE16E0", Offset = "0x3ADFEE0", VA = "0x183AE16E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3AE15B0", Offset = "0x3ADFDB0", VA = "0x183AE15B0")]
	public static global::KPPKJLIPFKJ<T> KCAFCIFFNBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3AE1B50", Offset = "0x3AE0350", VA = "0x183AE1B50")]
	private KPPKJLIPFKJ(T[] BALEELMCDBI, int IBEBPLKPLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3AE13C0", Offset = "0x3ADFBC0", VA = "0x183AE13C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3AE19D0", Offset = "0x3AE01D0", VA = "0x183AE19D0")]
	public void PHKHOKEBGPP(int GDBDJPILDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3AE1430", Offset = "0x3ADFC30", VA = "0x183AE1430")]
	private void EOAJOHPEAEG(int IBEBPLKPLGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class EJEDNFJPANE
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2DDEC10", Offset = "0x2DDD410", VA = "0x182DDEC10")]
	public static global::KPPKJLIPFKJ<T> KCAFCIFFNBB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public class JILFDBMLECK<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TKey, TVal> BCCCAFNIAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<TVal, TKey> DNJBAAGBJDO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int DEPGKLODCFL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2BE76B0", Offset = "0x2BE5EB0", VA = "0x182BE76B0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool DHMJLNKCOCK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x52F8A0", Offset = "0x52E0A0", VA = "0x18052F8A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public ICollection<TKey> DKPGBFMPBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2F7CD60", Offset = "0x2F7B560", VA = "0x182F7CD60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public ICollection<TVal> PPLFKJOLADG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x352B1B0", Offset = "0x35299B0", VA = "0x18352B1B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal BBAEBFDMEHL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x352D130", Offset = "0x352B930", VA = "0x18352D130", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3B56780", Offset = "0x3B54F80", VA = "0x183B56780", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3B56210", Offset = "0x3B54A10", VA = "0x183B56210", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3B56650", Offset = "0x3B54E50", VA = "0x183B56650", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3B56030", Offset = "0x3B54830", VA = "0x183B56030", Slot = "9")]
	public void Add(TKey DOMICNELCFM, TVal HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3B55FD0", Offset = "0x3B547D0", VA = "0x183B55FD0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> FGLBFEIBEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x38CFB80", Offset = "0x38CE380", VA = "0x1838CFB80", Slot = "8")]
	public bool ContainsKey(TKey DOMICNELCFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3638FF0", Offset = "0x36377F0", VA = "0x183638FF0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> FGLBFEIBEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3B565A0", Offset = "0x3B54DA0", VA = "0x183B565A0", Slot = "10")]
	public bool Remove(TKey DOMICNELCFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3B565A0", Offset = "0x3B54DA0", VA = "0x183B565A0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> FGLBFEIBEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x36FD2B0", Offset = "0x36FBAB0", VA = "0x1836FD2B0", Slot = "11")]
	public bool TryGetValue(TKey DOMICNELCFM, out TVal HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3B56520", Offset = "0x3B54D20", VA = "0x183B56520", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3B562A0", Offset = "0x3B54AA0", VA = "0x183B562A0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] IKFPKGEHMKB, int LOJFHMHINCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3B56060", Offset = "0x3B54860", VA = "0x183B56060")]
	public bool BDIOKLAMBCH(TVal DOMICNELCFM, out TKey HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3B56300", Offset = "0x3B54B00", VA = "0x183B56300")]
	private void DGDPDFMPNLJ(TKey DOMICNELCFM, TVal JLCAKPLDGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3B56410", Offset = "0x3B54C10", VA = "0x183B56410")]
	private void GIBJBEMAOCC(TKey DOMICNELCFM, TVal JLCAKPLDGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3B56090", Offset = "0x3B54890", VA = "0x183B56090")]
	private bool CGICPNDIMLO(TKey DOMICNELCFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3B566A0", Offset = "0x3B54EA0", VA = "0x183B566A0")]
	public JILFDBMLECK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class MIGPAMEAHFP<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private global::MIGPAMEAHFP<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x6EC0D0", Offset = "0x6EA8D0", VA = "0x1806EC0D0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x3B1B810", Offset = "0x3B1A010", VA = "0x183B1B810", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B970", Offset = "0x3B1A170", VA = "0x183B1B970")]
		public Enumerator(global::MIGPAMEAHFP<T> KIJIMACKNGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3B1ADF0", Offset = "0x3B195F0", VA = "0x183B1ADF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B370", Offset = "0x3B19B70", VA = "0x183B1B370", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3B1ACF0", Offset = "0x3B194F0", VA = "0x183B1ACF0")]
		private void GHAMKNNANDN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private T[] AIGELJJHJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int AHCEFDPBKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int DKGBDJNADIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int KOCLBHPLCOA;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int DEPGKLODCFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3B1CBA0", Offset = "0x3B1B3A0", VA = "0x183B1CBA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T BBAEBFDMEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3B1D850", Offset = "0x3B1C050", VA = "0x183B1D850")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3B1D640", Offset = "0x3B1BE40", VA = "0x183B1D640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3B1DF70", Offset = "0x3B1C770", VA = "0x183B1DF70")]
	public MIGPAMEAHFP(int IBEBPLKPLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D9D0", Offset = "0x3B1C1D0", VA = "0x183B1D9D0")]
	public void MFDJFDLHFHG(T NIDNHHLCCNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D830", Offset = "0x3B1C030", VA = "0x183B1D830")]
	public void FMAHHIGMIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3B1DCF0", Offset = "0x3B1C4F0", VA = "0x183B1DCF0")]
	public void OOOHGLAEGBO(int BPCIMPGFHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3B1CD40", Offset = "0x3B1B540", VA = "0x183B1CD40")]
	public void EOGKCAHPICA(T[] IKFPKGEHMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3B1CCD0", Offset = "0x3B1B4D0", VA = "0x183B1CCD0")]
	public Enumerator CHGGCAEJBPN()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3B1DE20", Offset = "0x3B1C620", VA = "0x183B1DE20", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3B1DE20", Offset = "0x3B1C620", VA = "0x183B1DE20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D460", Offset = "0x3B1BC60", VA = "0x183B1D460")]
	private int FFCDJKMINBD(int INFKIDFCOKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3B1DCC0", Offset = "0x3B1C4C0", VA = "0x183B1DCC0")]
	private int MLPKPIGDEHG(int INFKIDFCOKN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class NBACBFGEFAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	protected NBACBFGEFAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class AMEEPMIONBA<T> : NBACBFGEFAJ
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	protected struct CAJOKMPAIGF
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public enum DFOBIHCPGEP
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public DFOBIHCPGEP BJNLFFPNEBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public T HPPFCEEDPMJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int KHFFEMEGONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly bool AGAPJEEKDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	protected readonly bool GKJNFOMFBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	protected List<T> BKCBBKLIJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private List<CAJOKMPAIGF> CLMMPFDHEND;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool HLEHJNHCHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3642FC0", Offset = "0x36417C0", VA = "0x183642FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x36434B0", Offset = "0x3641CB0", VA = "0x1836434B0")]
	protected AMEEPMIONBA(bool GKJNFOMFBKJ, bool AGAPJEEKDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3643410", Offset = "0x3641C10", VA = "0x183643410")]
	protected bool PIODKEBKIBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3642EE0", Offset = "0x36416E0", VA = "0x183642EE0")]
	protected void BIIOMGJLIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3642D30", Offset = "0x3641530", VA = "0x183642D30")]
	protected void AEBJMNHIJND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2D4A9A0", Offset = "0x2D491A0", VA = "0x182D4A9A0")]
	private static void MJHDEHCNMPH<U>(ref List<U> CMAOAKODJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3643290", Offset = "0x3641A90", VA = "0x183643290", Slot = "4")]
	public void MFDJFDLHFHG(T HPPFCEEDPMJ, bool HDICLLCDDKB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3643000", Offset = "0x3641800", VA = "0x183643000", Slot = "5")]
	public void EHAJBJDJBJH(T HPPFCEEDPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3643160", Offset = "0x3641960", VA = "0x183643160")]
	public void FMAHHIGMIBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class JCOGEPDMPJF : global::AMEEPMIONBA<Action>
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x49753E0", Offset = "0x4973BE0", VA = "0x1849753E0")]
	public JCOGEPDMPJF(bool GKJNFOMFBKJ = false, bool AGAPJEEKDMF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x49751C0", Offset = "0x49739C0", VA = "0x1849751C0")]
	public void HBLBNLLMEPO()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4975160", Offset = "0x4973960", VA = "0x184975160")]
	public static JCOGEPDMPJF AAELLMJBLNM(JCOGEPDMPJF JILECJLLBPL, Action HPPFCEEDPMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4975380", Offset = "0x4973B80", VA = "0x184975380")]
	public static JCOGEPDMPJF IFJHOACCPOG(JCOGEPDMPJF JILECJLLBPL, Action HPPFCEEDPMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JFIGDIHCOPP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFDJFDLHFHG(Action<T> HPPFCEEDPMJ, bool HDICLLCDDKB = false);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHAJBJDJBJH(Action<T> HPPFCEEDPMJ);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class HFNBLJPFNGC<T> : global::AMEEPMIONBA<Action<T>>, global::JFIGDIHCOPP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2F82F00", Offset = "0x2F81700", VA = "0x182F82F00")]
	public HFNBLJPFNGC(bool GKJNFOMFBKJ = false, bool AGAPJEEKDMF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3DBFE40", Offset = "0x3DBE640", VA = "0x183DBFE40")]
	public void HBLBNLLMEPO(T NIDNHHLCCNA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2F7F470", Offset = "0x2F7DC70", VA = "0x182F7F470")]
	public static global::HFNBLJPFNGC<T> AAELLMJBLNM(global::HFNBLJPFNGC<T> JILECJLLBPL, Action<T> HPPFCEEDPMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2F82E60", Offset = "0x2F81660", VA = "0x182F82E60")]
	public static global::HFNBLJPFNGC<T> IFJHOACCPOG(global::HFNBLJPFNGC<T> JILECJLLBPL, Action<T> HPPFCEEDPMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface ODNAHCEMAGB<T, U>
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class EAACOHMHFMD<T, U> : global::AMEEPMIONBA<Action<T, U>>, global::ODNAHCEMAGB<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2F82F00", Offset = "0x2F81700", VA = "0x182F82F00")]
	public EAACOHMHFMD(bool GKJNFOMFBKJ = false, bool AGAPJEEKDMF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2F80FC0", Offset = "0x2F7F7C0", VA = "0x182F80FC0")]
	public void HBLBNLLMEPO(T NIDNHHLCCNA, U EGIBPAIAGAM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2F7F470", Offset = "0x2F7DC70", VA = "0x182F7F470")]
	public static global::EAACOHMHFMD<T, U> AAELLMJBLNM(global::EAACOHMHFMD<T, U> JILECJLLBPL, Action<T, U> HPPFCEEDPMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2F82E60", Offset = "0x2F81660", VA = "0x182F82E60")]
	public static global::EAACOHMHFMD<T, U> IFJHOACCPOG(global::EAACOHMHFMD<T, U> JILECJLLBPL, Action<T, U> HPPFCEEDPMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class OOFMMFNBCAE<T, U, V> : global::AMEEPMIONBA<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2F82F00", Offset = "0x2F81700", VA = "0x182F82F00")]
	public OOFMMFNBCAE(bool GKJNFOMFBKJ = false, bool AGAPJEEKDMF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3504AD0", Offset = "0x35032D0", VA = "0x183504AD0")]
	public void HBLBNLLMEPO(T NIDNHHLCCNA, U EGIBPAIAGAM, V PFMJOAEMNFL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2F7F470", Offset = "0x2F7DC70", VA = "0x182F7F470")]
	public static global::OOFMMFNBCAE<T, U, V> AAELLMJBLNM(global::OOFMMFNBCAE<T, U, V> JILECJLLBPL, Action<T, U, V> HPPFCEEDPMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2F82E60", Offset = "0x2F81660", VA = "0x182F82E60")]
	public static global::OOFMMFNBCAE<T, U, V> IFJHOACCPOG(global::OOFMMFNBCAE<T, U, V> JILECJLLBPL, Action<T, U, V> HPPFCEEDPMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface FDEDOCFIEPC<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class CBJICOJMNLF<T, U, V, W> : global::AMEEPMIONBA<Action<T, U, V, W>>, global::FDEDOCFIEPC<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2F82F00", Offset = "0x2F81700", VA = "0x182F82F00")]
	public CBJICOJMNLF(bool GKJNFOMFBKJ = false, bool AGAPJEEKDMF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3CFFE20", Offset = "0x3CFE620", VA = "0x183CFFE20")]
	public void HBLBNLLMEPO(T NIDNHHLCCNA, U EGIBPAIAGAM, V PFMJOAEMNFL, W AEFBFMJCCOH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2F7F470", Offset = "0x2F7DC70", VA = "0x182F7F470")]
	public static global::CBJICOJMNLF<T, U, V, W> AAELLMJBLNM(global::CBJICOJMNLF<T, U, V, W> JILECJLLBPL, Action<T, U, V, W> HPPFCEEDPMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2F82E60", Offset = "0x2F81660", VA = "0x182F82E60")]
	public static global::CBJICOJMNLF<T, U, V, W> IFJHOACCPOG(global::CBJICOJMNLF<T, U, V, W> JILECJLLBPL, Action<T, U, V, W> HPPFCEEDPMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class IGOKFHGGPPE<T, U, V, W, X> : global::AMEEPMIONBA<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2F82F00", Offset = "0x2F81700", VA = "0x182F82F00")]
	public IGOKFHGGPPE(bool GKJNFOMFBKJ = false, bool AGAPJEEKDMF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3AC5870", Offset = "0x3AC4070", VA = "0x183AC5870")]
	public void HBLBNLLMEPO(T NIDNHHLCCNA, U EGIBPAIAGAM, V PFMJOAEMNFL, W AEFBFMJCCOH, X ODDCIAGBNFM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2F7F470", Offset = "0x2F7DC70", VA = "0x182F7F470")]
	public static global::IGOKFHGGPPE<T, U, V, W, X> AAELLMJBLNM(global::IGOKFHGGPPE<T, U, V, W, X> JILECJLLBPL, Action<T, U, V, W, X> HPPFCEEDPMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2F82E60", Offset = "0x2F81660", VA = "0x182F82E60")]
	public static global::IGOKFHGGPPE<T, U, V, W, X> IFJHOACCPOG(global::IGOKFHGGPPE<T, U, V, W, X> JILECJLLBPL, Action<T, U, V, W, X> HPPFCEEDPMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class BCNGJGAMHOA<T, U, V, W, X, Y> : global::AMEEPMIONBA<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2F82F00", Offset = "0x2F81700", VA = "0x182F82F00")]
	public BCNGJGAMHOA(bool GKJNFOMFBKJ = false, bool AGAPJEEKDMF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x449A4F0", Offset = "0x4498CF0", VA = "0x18449A4F0")]
	public void HBLBNLLMEPO(T NIDNHHLCCNA, U EGIBPAIAGAM, V PFMJOAEMNFL, W AEFBFMJCCOH, X ODDCIAGBNFM, Y AAHOONHJJFO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2F7F470", Offset = "0x2F7DC70", VA = "0x182F7F470")]
	public static global::BCNGJGAMHOA<T, U, V, W, X, Y> AAELLMJBLNM(global::BCNGJGAMHOA<T, U, V, W, X, Y> JILECJLLBPL, Action<T, U, V, W, X, Y> HPPFCEEDPMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2F82E60", Offset = "0x2F81660", VA = "0x182F82E60")]
	public static global::BCNGJGAMHOA<T, U, V, W, X, Y> IFJHOACCPOG(global::BCNGJGAMHOA<T, U, V, W, X, Y> JILECJLLBPL, Action<T, U, V, W, X, Y> HPPFCEEDPMJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct JDNNFLGDBLE
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class OAHHHGHMNCK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public readonly struct PCCBGAEDEIH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly global::OAHHHGHMNCK<T> EPGDINOOLFD;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T FPOHGGJHLDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x43A3E60", Offset = "0x43A2660", VA = "0x1843A3E60")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x43A3E30", Offset = "0x43A2630", VA = "0x1843A3E30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x78E050", Offset = "0x78C850", VA = "0x18078E050")]
		public PCCBGAEDEIH(global::OAHHHGHMNCK<T> EPGDINOOLFD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly SemaphoreSlim PCANHGDGLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T JFEFDFHIECG;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x439FD50", Offset = "0x439E550", VA = "0x18439FD50")]
	public OAHHHGHMNCK(in T JFEFDFHIECG, int GLPNGBMGABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3526B10", Offset = "0x3525310", VA = "0x183526B10")]
	public OAHHHGHMNCK(in T JFEFDFHIECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x439FD10", Offset = "0x439E510", VA = "0x18439FD10")]
	public PCCBGAEDEIH FPIENJEKLNL()
	{
		return default(PCCBGAEDEIH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class MNPCKPACFFI
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4976A30", Offset = "0x4975230", VA = "0x184976A30")]
	public static global::OAHHHGHMNCK<JDNNFLGDBLE> KCAFCIFFNBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x29C3B10", Offset = "0x29C2310", VA = "0x1829C3B10")]
	public static global::OAHHHGHMNCK<T> KCAFCIFFNBB<T>(in T JFEFDFHIECG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class KKPJOPADNBN<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate bool ILBKKBHOIFB(global::KKPJOPADNBN<T> MDPGPMLNPNN);

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class OOFAHCJNHKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public global::KKPJOPADNBN<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public OOFAHCJNHKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1BC0", Offset = "0x3AE03C0", VA = "0x183AE1BC0")]
		internal bool <FindNode>b__0(global::KKPJOPADNBN<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public T HLPDPPFAPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public LinkedList<global::KKPJOPADNBN<T>> FDNHAEEEKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public global::KKPJOPADNBN<T> BPLOHBNOOEE;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public global::KKPJOPADNBN<T> JPGKMOIKAHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5A9790", Offset = "0x5A7F90", VA = "0x1805A9790")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3ADD840", Offset = "0x3ADC040", VA = "0x183ADD840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool LOILHAMJMFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3ADD810", Offset = "0x3ADC010", VA = "0x183ADD810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool GLKLEHNNBGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3ADD790", Offset = "0x3ADBF90", VA = "0x183ADD790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public global::KKPJOPADNBN<T> JLLLOONDCPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3ADE9D0", Offset = "0x3ADD1D0", VA = "0x183ADE9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3ADFD40", Offset = "0x3ADE540", VA = "0x183ADFD40")]
	public KKPJOPADNBN(T HDKCONLAJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3ADE8B0", Offset = "0x3ADD0B0", VA = "0x183ADE8B0")]
	public global::KKPJOPADNBN<T> IMCJFGPHLMO(T EDKOLJPFGBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3ADE430", Offset = "0x3ADCC30", VA = "0x183ADE430")]
	public global::KKPJOPADNBN<T> GLLEHAGFFBH(T BNCPFKOOHEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3ADDA90", Offset = "0x3ADC290", VA = "0x183ADDA90")]
	public global::KKPJOPADNBN<T> EHAJBJDJBJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3ADDB40", Offset = "0x3ADC340", VA = "0x183ADDB40")]
	public void FMAHHIGMIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3ADFB60", Offset = "0x3ADE360", VA = "0x183ADFB60")]
	public global::KKPJOPADNBN<T> OLBLMANNDDJ(T ICDIGNPBGMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3ADF820", Offset = "0x3ADE020", VA = "0x183ADF820")]
	public static void OEJFCEHHOEP(global::KKPJOPADNBN<T> HNHLNODKAGB, ILBKKBHOIFB PIHGOFNNIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3831F00", Offset = "0x3830700", VA = "0x183831F00")]
	public static void OEJFCEHHOEP<A>(global::KKPJOPADNBN<T> HNHLNODKAGB, Func<global::KKPJOPADNBN<T>, A, bool> PIHGOFNNIOF, A GFIBBDDIJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3ADEA50", Offset = "0x3ADD250", VA = "0x183ADEA50")]
	public static string MMHOCBCCIKO(global::KKPJOPADNBN<T> HNHLNODKAGB, int PKLAHCEIMIH = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3ADE000", Offset = "0x3ADC800", VA = "0x183ADE000")]
	public static global::KKPJOPADNBN<T> GGIKJDKMNGK(global::KKPJOPADNBN<T> HNHLNODKAGB, T AGCEAJMFOEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[DefaultMember("Item")]
public class FGGGDGBICAI<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public delegate int NPDAENDCOIG(TKey DOMICNELCFM, TVal HNCFAALBJCG);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class GNKKFGAJPMG
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public TKey IICELGCNCMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x50B450", Offset = "0x509C50", VA = "0x18050B450")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public TVal FPOHGGJHLDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7DDC00", Offset = "0x7DC400", VA = "0x1807DDC00")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x837710", Offset = "0x835F10", VA = "0x180837710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int BAPHJMOAMDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x5C6C70", Offset = "0x5C5470", VA = "0x1805C6C70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x596E50", Offset = "0x595650", VA = "0x180596E50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public DateTime ABNMEFPJACL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x50B480", Offset = "0x509C80", VA = "0x18050B480")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7574C0", Offset = "0x755CC0", VA = "0x1807574C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x370BF30", Offset = "0x370A730", VA = "0x18370BF30")]
		public GNKKFGAJPMG(TKey DOMICNELCFM, TVal JLCAKPLDGCF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public const int LOGDMJFKHNF = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly Dictionary<TKey, LinkedListNode<GNKKFGAJPMG>> MAGNABNLFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly LinkedList<GNKKFGAJPMG> FEINNEFMNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly NPDAENDCOIG PHGMHOKNKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly TimeSpan IEGHHLDHKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly HHHLCKGADEJ FAIELKNOEIC;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int IGAFOHGABHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x50A9D0", Offset = "0x5091D0", VA = "0x18050A9D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private bool GFHMHEGOCNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3592DE0", Offset = "0x35915E0", VA = "0x183592DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal int MJMJDDILHMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x73BE80", Offset = "0x73A680", VA = "0x18073BE80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x73BE70", Offset = "0x73A670", VA = "0x18073BE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TKey BBAEBFDMEHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3592D30", Offset = "0x3591530", VA = "0x183592D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3593DA0", Offset = "0x35925A0", VA = "0x183593DA0")]
	public FGGGDGBICAI(int IBEBPLKPLGA, [Optional] NPDAENDCOIG PHGMHOKNKCB, [Optional] IEqualityComparer<TKey> EBDMMIHEJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3593B50", Offset = "0x3592350", VA = "0x183593B50")]
	public FGGGDGBICAI(int IBEBPLKPLGA, NPDAENDCOIG PHGMHOKNKCB, TimeSpan IEGHHLDHKGD, [Optional] IEqualityComparer<TKey> EBDMMIHEJOC, [Optional] HHHLCKGADEJ FAIELKNOEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3592640", Offset = "0x3590E40", VA = "0x183592640")]
	public void DDIPNBEKBMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3592580", Offset = "0x3590D80", VA = "0x183592580")]
	public void BMOBMIEFBBI(TKey DOMICNELCFM, TVal HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3592BB0", Offset = "0x35913B0", VA = "0x183592BB0")]
	public bool EHAJBJDJBJH(TKey DOMICNELCFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3592360", Offset = "0x3590B60", VA = "0x183592360")]
	public bool BDIOKLAMBCH(TKey GHFKAADCFMM, out TVal HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3592D60", Offset = "0x3591560", VA = "0x183592D60")]
	public void FMAHHIGMIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3592E70", Offset = "0x3591670", VA = "0x183592E70")]
	private bool MCIKMNIKECK(GNKKFGAJPMG ECMNIOLEFFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3593270", Offset = "0x3591A70", VA = "0x183593270")]
	private void OEOHMEGADBJ(LinkedListNode<GNKKFGAJPMG> NHLPDPLFBIJ, TVal EACOKIMHCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x35929A0", Offset = "0x35911A0", VA = "0x1835929A0")]
	private void DNMJNHNECML(TKey DOMICNELCFM, TVal HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3593690", Offset = "0x3591E90", VA = "0x183593690")]
	private void PMAPPEPNCPN(GNKKFGAJPMG ECMNIOLEFFM, TVal EACOKIMHCPN, int EBNGJNDBCAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DefaultMember("Item")]
public class PMFJHAMDHFM<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<T> CMAOAKODJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private HashSet<T> NMHOIGMGBHL;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public int DEPGKLODCFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BE76B0", Offset = "0x2BE5EB0", VA = "0x182BE76B0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool DHMJLNKCOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x52F8A0", Offset = "0x52E0A0", VA = "0x18052F8A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public T BBAEBFDMEHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3587260", Offset = "0x3585A60", VA = "0x183587260", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3587350", Offset = "0x3585B50", VA = "0x183587350", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4020", Offset = "0x2AD2820", VA = "0x182AD4020", Slot = "11")]
	public void Add(T FGLBFEIBEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3586CA0", Offset = "0x35854A0", VA = "0x183586CA0")]
	public bool HAKCAENOJKG(T FGLBFEIBEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3587100", Offset = "0x3585900", VA = "0x183587100", Slot = "15")]
	public bool Remove(T FGLBFEIBEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3586B70", Offset = "0x3585370", VA = "0x183586B70", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C034B0", Offset = "0x2C01CB0", VA = "0x182C034B0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3586AE0", Offset = "0x35852E0", VA = "0x183586AE0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3539730", Offset = "0x3537F30", VA = "0x183539730", Slot = "13")]
	public bool Contains(T FGLBFEIBEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3586B40", Offset = "0x3585340", VA = "0x183586B40", Slot = "14")]
	public void CopyTo(T[] IKFPKGEHMKB, int LOJFHMHINCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x352D130", Offset = "0x352B930", VA = "0x18352D130", Slot = "6")]
	public int IndexOf(T FGLBFEIBEMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3586D40", Offset = "0x3585540", VA = "0x183586D40", Slot = "7")]
	public void Insert(int INFKIDFCOKN, T FGLBFEIBEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3586FA0", Offset = "0x35857A0", VA = "0x183586FA0", Slot = "8")]
	public void RemoveAt(int INFKIDFCOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3587180", Offset = "0x3585980", VA = "0x183587180")]
	public PMFJHAMDHFM()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x5CFD00", Offset = "0x5CE500", VA = "0x1805CFD00")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4976F00", Offset = "0x4975700", VA = "0x184976F00")]
		public SerializedGuid(in Guid NHFICLBMMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4976E80", Offset = "0x4975680", VA = "0x184976E80")]
		public static SerializedGuid PPDBDJDNFGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4976CA0", Offset = "0x49754A0", VA = "0x184976CA0")]
		public static SerializedGuid JCBKDAJIMMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4976D20", Offset = "0x4975520", VA = "0x184976D20")]
		public bool KPKLDEKBIKN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4976E50", Offset = "0x4975650", VA = "0x184976E50", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x4976DB0", Offset = "0x49755B0", VA = "0x184976DB0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4976B10", Offset = "0x4975310", VA = "0x184976B10", Slot = "7")]
		public bool Equals(SerializedGuid AJEOGBNDGHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4976BB0", Offset = "0x49753B0", VA = "0x184976BB0", Slot = "0")]
		public override bool Equals(object JGHAOGLDGDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4976C90", Offset = "0x4975490", VA = "0x184976C90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4976AE0", Offset = "0x49752E0", VA = "0x184976AE0", Slot = "6")]
		public int CompareTo(SerializedGuid AJEOGBNDGHH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class DOAKIOALEMB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly Type DGLDBFANLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly string GEILNEJFFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly bool EKJGLLLHKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly bool NJNIAGJEIFL;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4974830", Offset = "0x4973030", VA = "0x184974830")]
	public DOAKIOALEMB(Type ABPCIABNLDM, string PLPDCEJBBIP, bool CKMIINMOHBK = false, bool JHBLEBLEHCF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface NCPMKLBPPBN<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class CMPGAIPFFEB<T> : global::NCPMKLBPPBN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private global::EAACOHMHFMD<T, T> AOBHDLGPABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private global::HFNBLJPFNGC<T> PGALJGACGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private global::HFNBLJPFNGC<string> HJPFFNANPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private string CAPFNHGLOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private T HMCKBHOBBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool HDMLEGHIOGO;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T FPOHGGJHLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2AD43A0", Offset = "0x2AD2BA0", VA = "0x182AD43A0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4300", Offset = "0x2AD2B00", VA = "0x182AD4300")]
	private void AICBFKCKJNC(T KKPFFIGAGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4270", Offset = "0x2AD2A70", VA = "0x182AD4270", Slot = "5")]
	public global::NCPMKLBPPBN<T> ABJFAAKNBEJ(Action<T> JIIKDLLGHFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2AD43D0", Offset = "0x2AD2BD0", VA = "0x182AD43D0", Slot = "6")]
	public global::NCPMKLBPPBN<T> NPPAFCLBOGK(Action<T> PIOCLGEHILF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4420", Offset = "0x2AD2C20", VA = "0x182AD4420")]
	public CMPGAIPFFEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class HHHLCKGADEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private class MBLLHDILNLM : HHHLCKGADEJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static HHHLCKGADEJ OONGLDHDBNL
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x4976880", Offset = "0x4975080", VA = "0x184976880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override DateTime HAPLGCEAGEC
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x49768E0", Offset = "0x49750E0", VA = "0x1849768E0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x49769D0", Offset = "0x49751D0", VA = "0x1849769D0")]
		public MBLLHDILNLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static HHHLCKGADEJ BILOPFKMBLL;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static HHHLCKGADEJ OJLDJOBNOGB
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4974FE0", Offset = "0x49737E0", VA = "0x184974FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract DateTime HAPLGCEAGEC
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	protected HHHLCKGADEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class EBLCJCMDLOH : global::JIKFFHKNLIB<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x49748A0", Offset = "0x49730A0", VA = "0x1849748A0")]
	public EBLCJCMDLOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class JIKFFHKNLIB<T> : global::JGAJGHNDLKP<T>, OECGAMIDEEE, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Task<T> LIBHHCGDJPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x50B450", Offset = "0x509C50", VA = "0x18050B450", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public global::KGPLAJBADNH<T> KALDMAHDGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private LFPFPAAINHE AIMPAGPBBMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2720CA0", Offset = "0x271F4A0", VA = "0x182720CA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3B55EF0", Offset = "0x3B546F0", VA = "0x183B55EF0")]
	public JIKFFHKNLIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class KHLKJFFBPPO<T> : global::JGAJGHNDLKP<T>, OECGAMIDEEE, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Task<T> LIBHHCGDJPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x50B450", Offset = "0x509C50", VA = "0x18050B450", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public global::KGPLAJBADNH<T> KALDMAHDGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private LFPFPAAINHE AIMPAGPBBMD
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2720CA0", Offset = "0x271F4A0", VA = "0x182720CA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3ADB210", Offset = "0x3AD9A10", VA = "0x183ADB210")]
	public KHLKJFFBPPO(Exception BCENOHLAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface OECGAMIDEEE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	[NotNull]
	LFPFPAAINHE KALDMAHDGEI
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface JGAJGHNDLKP<T> : OECGAMIDEEE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[NotNull]
	Task<T> LIBHHCGDJPO
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	new global::KGPLAJBADNH<T> KALDMAHDGEI
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public abstract class EDIADGEANJA<TTask, T> : global::JGAJGHNDLKP<T>, OECGAMIDEEE, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class KDGHENNHCMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public global::EDIADGEANJA<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public KDGHENNHCMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static bool ABFJFAIIMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Task<T> MJKIPKFAGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	protected readonly CancellationTokenSource CIADFPMBPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool CEBFLEDNJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private SynchronizationContext HLMHGEFAHMM;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task<T> LIBHHCGDJPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x50B450", Offset = "0x509C50", VA = "0x18050B450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public global::KGPLAJBADNH<T> KALDMAHDGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private LFPFPAAINHE AIMPAGPBBMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2CC1110", Offset = "0x2CBF910", VA = "0x182CC1110", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool AEEMBAMLGLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5E3200", Offset = "0x5E1A00", VA = "0x1805E3200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3234830", Offset = "0x3233030", VA = "0x183234830")]
	static EDIADGEANJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x32349A0", Offset = "0x32331A0", VA = "0x1832349A0")]
	protected EDIADGEANJA(TTask MJKIPKFAGGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x32342F0", Offset = "0x3232AF0", VA = "0x1832342F0", Slot = "1")]
	~EDIADGEANJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3234220", Offset = "0x3232A20", VA = "0x183234220", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3234390", Offset = "0x3232B90", VA = "0x183234390")]
	private void MIJAAKNMDAH(bool LEHDKCIOJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T OCKHHPJGHBH(TTask EDLDNPIDGMO);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract void KEHJENOKDLL();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3234670", Offset = "0x3232E70", VA = "0x183234670")]
	[CompilerGenerated]
	private void NKFEOBBILAB(object EDECAOALAAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public abstract class FDHKDNJNOOJ<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal class CDECBECDGKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public TNode ENIBKELLOBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TNode ECKBOFJGCOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public NBCCHMGGEDB HFAOLNFLEGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public List<NBCCHMGGEDB> HBJICOOJBPH;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public CDECBECDGKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	internal struct NBCCHMGGEDB : IComparable<NBCCHMGGEDB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int FCBGEDDMHBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TClaimant AINLLGCKBIJ;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x537690", Offset = "0x535E90", VA = "0x180537690")]
		public NBCCHMGGEDB(int FCBGEDDMHBG, TClaimant AINLLGCKBIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x370C800", Offset = "0x370B000", VA = "0x18370C800")]
		public bool GOAHGLEOPEJ(in NBCCHMGGEDB AJEOGBNDGHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x370C860", Offset = "0x370B060", VA = "0x18370C860")]
		public bool MANMLOJLFBL(in NBCCHMGGEDB AJEOGBNDGHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x370C7F0", Offset = "0x370AFF0", VA = "0x18370C7F0", Slot = "4")]
		public int CompareTo(NBCCHMGGEDB AJEOGBNDGHH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x370C870", Offset = "0x370B070", VA = "0x18370C870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum GOHLBPGJFJL
	{
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class HLHLJOIFHID : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public global::FDHKDNJNOOJ<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x2BFAB60", Offset = "0x2BF9360", VA = "0x182BFAB60")]
		[DebuggerHidden]
		public HLHLJOIFHID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x370C190", Offset = "0x370A990", VA = "0x18370C190", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x370C350", Offset = "0x370AB50", VA = "0x18370C350", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x370C270", Offset = "0x370AA70", VA = "0x18370C270", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2732FE0", Offset = "0x27317E0", VA = "0x182732FE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly global::NOHDCMKFKCG<CDECBECDGKD> CJPBJNBPEEP;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly global::NOHDCMKFKCG<List<NBCCHMGGEDB>> DALIGOAJONN;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int IPLEIIACCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	internal readonly Dictionary<TClaimant, TNode> BPOGDFOGDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	internal readonly Dictionary<TNode, CDECBECDGKD> CFAOJCFBJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly HashSet<TNode> CHELPIBGKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private GOHLBPGJFJL HLBIKDBGOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool IIJGDAHFIEG;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode JHEDFEFGKCM(TNode MDPGPMLNPNN);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void ILAOEDKKBCB(TNode MDPGPMLNPNN, TClaimant PKHLFPGDKEN, TClaimant CLDJBNHGKEL);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3704BE0", Offset = "0x37033E0", VA = "0x183704BE0")]
	public FDHKDNJNOOJ(GOHLBPGJFJL HLBIKDBGOCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3703870", Offset = "0x3702070", VA = "0x183703870")]
	public void EOIAJOCNOBG(TNode MDPGPMLNPNN, TNode ICDIGNPBGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3703350", Offset = "0x3701B50", VA = "0x183703350")]
	public void AMECDPEMODO(TClaimant AINLLGCKBIJ, TNode ALNLHIJLMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x37035E0", Offset = "0x3701DE0", VA = "0x1837035E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3703BA0", Offset = "0x37023A0", VA = "0x183703BA0")]
	private void HEFEAILPKBJ(TClaimant AINLLGCKBIJ, TNode CIMDALEBIMC, TNode ALNLHIJLMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3704950", Offset = "0x3703150", VA = "0x183704950")]
	private int NIKJMJNDNKG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x37038F0", Offset = "0x37020F0", VA = "0x1837038F0")]
	private void FPEMOANJLEA(TClaimant AINLLGCKBIJ, TNode OFMMLIGGFJM, TNode EOKMMGPPPAP, int OCAAKIJDBBG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3703D10", Offset = "0x3702510", VA = "0x183703D10")]
	private void HKOPHDKIPHF(NBCCHMGGEDB FMKPILCLLGO, CDECBECDGKD IADICDODJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3703EA0", Offset = "0x37026A0", VA = "0x183703EA0")]
	private void JOKPMIAKIIA(TClaimant AINLLGCKBIJ, TNode OFMMLIGGFJM, TNode EOKMMGPPPAP, int OCAAKIJDBBG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3704110", Offset = "0x3702910", VA = "0x183704110")]
	private void KEOGGJGKPAL(NBCCHMGGEDB FMKPILCLLGO, TNode MDPGPMLNPNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3703DA0", Offset = "0x37025A0", VA = "0x183703DA0")]
	private void JKJLCPIHDCL(NBCCHMGGEDB FMKPILCLLGO, CDECBECDGKD IADICDODJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3704810", Offset = "0x3703010", VA = "0x183704810")]
	private void MCDJCAPJPJL(CDECBECDGKD IADICDODJNM, bool HKDGFHAJNND = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3704210", Offset = "0x3702A10", VA = "0x183704210")]
	private void KMDPOGGHODJ(CDECBECDGKD IADICDODJNM, TNode ICDIGNPBGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3703C40", Offset = "0x3702440", VA = "0x183703C40")]
	[IteratorStateMachine(typeof(global::FDHKDNJNOOJ<, >.HLHLJOIFHID))]
	private IEnumerable<TNode> HHLNONAOAPA(TNode OFMMLIGGFJM, TNode EOKMMGPPPAP, bool NCFIHNIAFKH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x37049C0", Offset = "0x37031C0", VA = "0x1837049C0")]
	private CDECBECDGKD OKBKNOCIPAK(TNode MDPGPMLNPNN, TNode ECKBOFJGCOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3703450", Offset = "0x3701C50", VA = "0x183703450")]
	private CDECBECDGKD BBBKNFKFEEK(TNode MDPGPMLNPNN, TNode ECKBOFJGCOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3704650", Offset = "0x3702E50", VA = "0x183704650")]
	private void LHGECPHINML(CDECBECDGKD IADICDODJNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class JDMHHKFPOPP<T> : IEnumerable<global::JDMHHKFPOPP<T>.EGOCFIMEDBF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct EGOCFIMEDBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public T HNCFAALBJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int INFKIDFCOKN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class KEHPMABNKCL : IEnumerator<EGOCFIMEDBF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private global::JDMHHKFPOPP<T> GAGJCMDENPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int INFKIDFCOKN;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x30841D0", Offset = "0x30829D0", VA = "0x1830841D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public EGOCFIMEDBF CLNJBLHHCPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x354D1F0", Offset = "0x354B9F0", VA = "0x18354D1F0", Slot = "4")]
			get
			{
				return default(EGOCFIMEDBF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xB68FF0", Offset = "0xB677F0", VA = "0x180B68FF0")]
		public KEHPMABNKCL(global::JDMHHKFPOPP<T> GAGJCMDENPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x354D160", Offset = "0x354B960", VA = "0x18354D160", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9D5A60", Offset = "0x9D4260", VA = "0x1809D5A60", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xD23270", Offset = "0xD21A70", VA = "0x180D23270", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct NLJMKGKLCDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public bool CPEAFAEHNBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public T HNCFAALBJCG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private const int OHJDIGBGDHA = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Dictionary<T, int> DGAFKAKLGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private NLJMKGKLCDI[] KFKFJNCOLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int KOEKDNKMGNE;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int DEPGKLODCFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2F7CD60", Offset = "0x2F7B560", VA = "0x182F7CD60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x353D580", Offset = "0x353BD80", VA = "0x18353D580")]
	public static global::JDMHHKFPOPP<T> NGFOGOJPPFI(EGOCFIMEDBF[] FEILJIJKPNF, bool EFGJDOGLAGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x353D9D0", Offset = "0x353C1D0", VA = "0x18353D9D0")]
	public JDMHHKFPOPP(int IBEBPLKPLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x353D4E0", Offset = "0x353BCE0", VA = "0x18353D4E0")]
	public int KHAAECBDAGE(T HNCFAALBJCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x353D220", Offset = "0x353BA20", VA = "0x18353D220")]
	public T GDNIBDLPBJN(int INFKIDFCOKN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x353D4C0", Offset = "0x353BCC0", VA = "0x18353D4C0")]
	public bool HAKCAENOJKG(T HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x353D290", Offset = "0x353BA90", VA = "0x18353D290")]
	public bool HAKCAENOJKG(T HNCFAALBJCG, int INFKIDFCOKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x353D0B0", Offset = "0x353B8B0", VA = "0x18353D0B0")]
	public EGOCFIMEDBF[] CEALNEPOJIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x353D530", Offset = "0x353BD30", VA = "0x18353D530")]
	private int MOBMGHLMHKH(int AHCEFDPBKKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x353D960", Offset = "0x353C160", VA = "0x18353D960", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x353D960", Offset = "0x353C160", VA = "0x18353D960", Slot = "4")]
	private IEnumerator<EGOCFIMEDBF> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class NOHDCMKFKCG<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly Stack<T> FFDLCHKGKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<T> IENMPNGANLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly int MPDDFIIAEMH;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x39AE330", Offset = "0x39ACB30", VA = "0x1839AE330")]
	public static global::NOHDCMKFKCG<T> KACELFLOEHK(int IBEBPLKPLGA = 0, int MPDDFIIAEMH = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x39AE940", Offset = "0x39AD140", VA = "0x1839AE940")]
	public NOHDCMKFKCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x39AE7B0", Offset = "0x39ACFB0", VA = "0x1839AE7B0")]
	public NOHDCMKFKCG(int IBEBPLKPLGA, int MPDDFIIAEMH = int.MaxValue, bool BAFGNOFAONO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x39AE5C0", Offset = "0x39ACDC0", VA = "0x1839AE5C0")]
	public T OLMAMDLCHGL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x39AE270", Offset = "0x39ACA70", VA = "0x1839AE270")]
	public void GIELAIEHAPP(T HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x39AE6F0", Offset = "0x39ACEF0", VA = "0x1839AE6F0")]
	private void PMCGPOEOGEM(T HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x39AE250", Offset = "0x39ACA50", VA = "0x1839AE250")]
	private void FPLAGJKFPDE(T HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x39AE140", Offset = "0x39AC940", VA = "0x1839AE140", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x39AE400", Offset = "0x39ACC00", VA = "0x1839AE400")]
	private void LBHAPEKFLIB(IEnumerable<T> GIFCHONKIKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class OEJGMAEOPMI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Dictionary<int, T> OBPLLAABPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private T HOFCDIKCDBN;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public virtual T PPKIKGCEAFM
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x50E430", Offset = "0x50CC30", VA = "0x18050E430", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x439FEF0", Offset = "0x439E6F0", VA = "0x18439FEF0")]
	public bool DNMJNHNECML(T HNCFAALBJCG, int FCBGEDDMHBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x439FFB0", Offset = "0x439E7B0", VA = "0x18439FFB0")]
	public bool HJADIGAJONG(int FCBGEDDMHBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x43A0280", Offset = "0x439EA80", VA = "0x1843A0280")]
	public T JEAEHGAMKFD(int BENDGOGFIMI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x439FF50", Offset = "0x439E750", VA = "0x18439FF50")]
	public void FMAHHIGMIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x43A04E0", Offset = "0x439ECE0", VA = "0x1843A04E0")]
	private bool NAPDHOKCGJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3586B40", Offset = "0x3585340", VA = "0x183586B40")]
	public bool BDIOKLAMBCH(int FCBGEDDMHBG, out T HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x43A0680", Offset = "0x439EE80", VA = "0x1843A0680")]
	public OEJGMAEOPMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class OEJPGOKBLCM<T>
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	protected struct ODGEMPPBMCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public T FPOHGGJHLDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int FFCGMNODNGP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	protected readonly List<ODGEMPPBMCD> AIGELJJHJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private T MMIGAJFAFGN;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int DEPGKLODCFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2BE76B0", Offset = "0x2BE5EB0", VA = "0x182BE76B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x43A0920", Offset = "0x439F120", VA = "0x1843A0920")]
	public bool KGCHNPGEFLL(T HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x43A0B70", Offset = "0x439F370", VA = "0x1843A0B70")]
	public void MFDJFDLHFHG(T HNCFAALBJCG, int FCBGEDDMHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x43A0710", Offset = "0x439EF10", VA = "0x1843A0710")]
	public bool EHAJBJDJBJH(T HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x43A08C0", Offset = "0x439F0C0", VA = "0x1843A08C0")]
	public void FMAHHIGMIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x43A0830", Offset = "0x439F030", VA = "0x1843A0830")]
	public T EPOKMEJLMCA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x43A0C10", Offset = "0x439F410", VA = "0x1843A0C10")]
	private void PIONCNIFJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x43A0E20", Offset = "0x439F620", VA = "0x1843A0E20")]
	public OEJPGOKBLCM()
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
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2732C70", Offset = "0x2731470", VA = "0x182732C70", Slot = "4")]
		public virtual T MNEDCHDGDOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class JHODGFJKEDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Dictionary<byte, KMKMFENDLFE> FFJCCGJMGCL;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public KMKMFENDLFE FLIKNFMJKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x50B450", Offset = "0x509C50", VA = "0x18050B450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x52EE90", Offset = "0x52D690", VA = "0x18052EE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Vector2 JFLCIGCAOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x109E540", Offset = "0x109CD40", VA = "0x18109E540")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x1971360", Offset = "0x196FB60", VA = "0x181971360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private Vector2 PEGDCAPOEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xEEE420", Offset = "0xEECC20", VA = "0x180EEE420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Vector2 GMODGLOAMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x14A6BF0", Offset = "0x14A53F0", VA = "0x1814A6BF0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x14A6C10", Offset = "0x14A5410", VA = "0x1814A6C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int DOFEBDEEIAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x55A120", Offset = "0x558920", VA = "0x18055A120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x580290", Offset = "0x57EA90", VA = "0x180580290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x4975C00", Offset = "0x4974400", VA = "0x184975C00")]
	public JHODGFJKEDN(Bounds BHBKGDCFHEI, Vector2[] EGAMLAGOLHG, int HPPPOIDJFGN, byte AHCEFDPBKKA, float CEPPADEDFJG = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x4975A50", Offset = "0x4974250", VA = "0x184975A50")]
	public KMKMFENDLFE ECNBEEGAIBP(byte INFKIDFCOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x4975960", Offset = "0x4974160", VA = "0x184975960")]
	public void DIDOHMNIDIM(Vector3 PBEKABJHDMI, float EDMEECBCOBG, float LHNGKFMJFAJ, ref List<byte> ADGHCJNAMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x4975AB0", Offset = "0x49742B0", VA = "0x184975AB0")]
	public void LCPLOMJEMGK(KMKMFENDLFE.EIHFLMAEGOM EJINPFDJKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x4975AD0", Offset = "0x49742D0", VA = "0x184975AD0")]
	private KMKMFENDLFE ONMGFJPMBJP(byte INFKIDFCOKN, KMKMFENDLFE.ONIMAEGNAJL KODPLBIGCKE, KMKMFENDLFE ECKBOFJGCOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4975440", Offset = "0x4973C40", VA = "0x184975440")]
	private void CEGMHLAEIDP(KMKMFENDLFE ECKBOFJGCOL, Vector2[] EGAMLAGOLHG, int ALAIFHALDEN, int AIFONMNKMIL, int FICHIDCHEJE, int MJPKDJHLCBG, float CEPPADEDFJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class KMKMFENDLFE
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public enum ONIMAEGNAJL
	{
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public enum EIHFLMAEGOM
	{
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public byte GOIOPIJGACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public Vector3 PLFHNPBCPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Vector3 BAPHJMOAMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Vector3 JBHNFEHNOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Vector3 LHFJIDANOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public ONIMAEGNAJL LACCEIJGGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public KMKMFENDLFE JPGKMOIKAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public List<KMKMFENDLFE> HFNCKOHHBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool AKOLCLHIJAG;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4976820", Offset = "0x4975020", VA = "0x184976820")]
	public KMKMFENDLFE(byte KCKIAGIOHJN, ONIMAEGNAJL KODPLBIGCKE, KMKMFENDLFE ECKBOFJGCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4976720", Offset = "0x4974F20", VA = "0x184976720")]
	public void IMCJFGPHLMO(KMKMFENDLFE EPMHHCMKJBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30")]
	public void LCPLOMJEMGK(int PLNPDEJOHKA, EIHFLMAEGOM EJINPFDJKIH, int KLKAGDBJEGI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x4976450", Offset = "0x4974C50", VA = "0x184976450")]
	public void DIDOHMNIDIM(List<byte> ADGHCJNAMLA, Vector3 PBEKABJHDMI, float EDMEECBCOBG, float LHNGKFMJFAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x49767C0", Offset = "0x4974FC0", VA = "0x1849767C0")]
	public bool KOIKLHNHBCA(Vector3 JMBNGJDJLPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x49766E0", Offset = "0x4974EE0", VA = "0x1849766E0")]
	public bool EKDJEIKFLMK(Vector3 JMBNGJDJLPO, float ADDJJNHPKMI)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public struct MJNIAOPLLNO<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private readonly List<Component> CMAOAKODJGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private readonly bool JGNCGGGFKMH;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xBC1760", Offset = "0xBBFF60", VA = "0x180BC1760")]
			public MJNIAOPLLNO(List<Component> CMAOAKODJGB, bool JGNCGGGFKMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x2726EF0", Offset = "0x27256F0", VA = "0x182726EF0")]
			public NONPHGJPBJN<T> CHGGCAEJBPN()
			{
				return default(NONPHGJPBJN<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x2726F60", Offset = "0x2725760", VA = "0x182726F60", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x2726F60", Offset = "0x2725760", VA = "0x182726F60", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public struct NONPHGJPBJN<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private readonly List<Component> CMAOAKODJGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private readonly bool JGNCGGGFKMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private int INFKIDFCOKN;

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public T CLNJBLHHCPB
			{
				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0x272ED90", Offset = "0x272D590", VA = "0x18272ED90", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0x272ED20", Offset = "0x272D520", VA = "0x18272ED20", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x272ED60", Offset = "0x272D560", VA = "0x18272ED60")]
			public NONPHGJPBJN(List<Component> CMAOAKODJGB, bool JGNCGGGFKMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x272EC50", Offset = "0x272D450", VA = "0x18272EC50", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x272EC60", Offset = "0x272D460", VA = "0x18272EC60", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x272ED10", Offset = "0x272D510", VA = "0x18272ED10", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4977440", Offset = "0x4975C40", VA = "0x184977440")]
		private void PJKFEDAIHFG(GameObject IIOMBHKPAJE, bool MIEPOKNFBKA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x49772D0", Offset = "0x4975AD0", VA = "0x1849772D0")]
		public static void PJKFEDAIHFG(GameObject IIOMBHKPAJE, ref ToolHierarchyCache FNJKKFHKNGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x296F0F0", Offset = "0x296D8F0", VA = "0x18296F0F0")]
		public void KHPMPCANKML<T>(Action<T> HPPFCEEDPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x34C87D0", Offset = "0x34C6FD0", VA = "0x1834C87D0")]
		public MJNIAOPLLNO<T> BJAHGJEJOII<T>(bool JGNCGGGFKMH = false) where T : class
		{
			return default(MJNIAOPLLNO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4977020", Offset = "0x4975820", VA = "0x184977020")]
		public List<Component> MKCPEKLAJEP(Type BJNLFFPNEBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x4976F30", Offset = "0x4975730", VA = "0x184976F30", Slot = "4")]
		public bool Equals(ToolHierarchyCache ODDCIAGBNFM, ToolHierarchyCache AAHOONHJJFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4976FB0", Offset = "0x49757B0", VA = "0x184976FB0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache JGHAOGLDGDA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class ALHGELIBDHD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private int IBEBPLKPLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private int GCBEJIJPHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private List<T> FOBBJIMBMJH;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public T EIGEDKFDAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x36419A0", Offset = "0x36401A0", VA = "0x1836419A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public T PHFMIICDIOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3641DB0", Offset = "0x36405B0", VA = "0x183641DB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public T OANPJEIHNGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3641D10", Offset = "0x3640510", VA = "0x183641D10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3641E70", Offset = "0x3640670", VA = "0x183641E70")]
	public ALHGELIBDHD(int IBEBPLKPLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3641A20", Offset = "0x3640220", VA = "0x183641A20")]
	public void MFDJFDLHFHG(T ICIPOPAIALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x36418C0", Offset = "0x36400C0", VA = "0x1836418C0")]
	public void FMAHHIGMIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3641D60", Offset = "0x3640560", VA = "0x183641D60")]
	public void OACGLNMLGAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3641E60", Offset = "0x3640660", VA = "0x183641E60")]
	public void PHLJCEBAIIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class PBPANOJBECE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct GPHBNFFMICH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int FFCGMNODNGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public T FPOHGGJHLDI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Dictionary<object, GPHBNFFMICH> OBPLLAABPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private T HOFCDIKCDBN;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public virtual T PPKIKGCEAFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2BFA540", Offset = "0x2BF8D40", VA = "0x182BFA540", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x357CBE0", Offset = "0x357B3E0", VA = "0x18357CBE0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool LCFAENKHHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x357D4B0", Offset = "0x357BCB0", VA = "0x18357D4B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public object LBMLLKHGGNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x50B470", Offset = "0x509C70", VA = "0x18050B470")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x52F9E0", Offset = "0x52E1E0", VA = "0x18052F9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x357D070", Offset = "0x357B870", VA = "0x18357D070")]
	public bool DNMJNHNECML(T HNCFAALBJCG, object JJGMEBEPKFF, int FCBGEDDMHBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x357D510", Offset = "0x357BD10", VA = "0x18357D510")]
	public bool HJADIGAJONG(object JJGMEBEPKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x357C7C0", Offset = "0x357AFC0", VA = "0x18357C7C0")]
	public bool BDIOKLAMBCH(object JJGMEBEPKFF, out T HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x357D4E0", Offset = "0x357BCE0", VA = "0x18357D4E0")]
	public void FMAHHIGMIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x357D580", Offset = "0x357BD80", VA = "0x18357D580")]
	private bool NAPDHOKCGJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3582210", Offset = "0x3580A10", VA = "0x183582210")]
	public PBPANOJBECE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class KKGFJBKKMDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Dictionary<object, float> OBPLLAABPBC;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public float CBEPOBNHMIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8909E0", Offset = "0x88F1E0", VA = "0x1808909E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8908A0", Offset = "0x88F0A0", VA = "0x1808908A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x49761D0", Offset = "0x49749D0", VA = "0x1849761D0")]
	public void DNMJNHNECML(float HNCFAALBJCG, object JJGMEBEPKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4976240", Offset = "0x4974A40", VA = "0x184976240")]
	public void HJADIGAJONG(object JJGMEBEPKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x49762B0", Offset = "0x4974AB0", VA = "0x1849762B0")]
	private void KLMHOAJPDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x49763D0", Offset = "0x4974BD0", VA = "0x1849763D0")]
	public KKGFJBKKMDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class FAHLEKLFCEB
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public sealed class NLJHKOMEGMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly string DNIBNEFMLAM;

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		private NLJHKOMEGMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6B5950", Offset = "0x6B4150", VA = "0x1806B5950")]
		public NLJHKOMEGMG(string DNIBNEFMLAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4976A90", Offset = "0x4975290", VA = "0x184976A90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class JNFJCDFMDIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public JNFJCDFMDIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4976120", Offset = "0x4974920", VA = "0x184976120")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly HashSet<object> CJPPDOJGPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private int PKNKJKONIIE;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool KMCJJGMKKPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x4974C50", Offset = "0x4973450", VA = "0x184974C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public int DEPGKLODCFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x50B440", Offset = "0x509C40", VA = "0x18050B440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4974CC0", Offset = "0x49734C0", VA = "0x184974CC0")]
	public bool MFDJFDLHFHG(object JJGMEBEPKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4974B70", Offset = "0x4973370", VA = "0x184974B70")]
	public bool EHAJBJDJBJH(object JJGMEBEPKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4974C60", Offset = "0x4973460", VA = "0x184974C60")]
	public bool KGCHNPGEFLL(object JJGMEBEPKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x4974BF0", Offset = "0x49733F0", VA = "0x184974BF0")]
	public void ENEJEJPMDHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4974D40", Offset = "0x4973540", VA = "0x184974D40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x4974EB0", Offset = "0x49736B0", VA = "0x184974EB0")]
	public FAHLEKLFCEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class CCGMJBIMIPE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct MKJDOFNCLBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public float HEDPNLHKDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public T FPOHGGJHLDI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Dictionary<object, MKJDOFNCLBN> OBPLLAABPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private T IEOOPAEHBFL;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public virtual T KJKHJLBFILO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1A90B00", Offset = "0x1A8F300", VA = "0x181A90B00", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x357CC00", Offset = "0x357B400", VA = "0x18357CC00", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public object ADHHKGJINIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x50A9E0", Offset = "0x5091E0", VA = "0x18050A9E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5C33B0", Offset = "0x5C1BB0", VA = "0x1805C33B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool LCFAENKHHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3D02060", Offset = "0x3D00860", VA = "0x183D02060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x3D01C00", Offset = "0x3D00400", VA = "0x183D01C00")]
	public bool DNMJNHNECML(T HNCFAALBJCG, object JJGMEBEPKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x3D020A0", Offset = "0x3D008A0", VA = "0x183D020A0")]
	public bool HJADIGAJONG(object JJGMEBEPKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x357D4E0", Offset = "0x357BCE0", VA = "0x18357D4E0")]
	public void FMAHHIGMIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3D01700", Offset = "0x3CFFF00", VA = "0x183D01700")]
	public bool BDIOKLAMBCH(object JJGMEBEPKFF, out T HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3D039D0", Offset = "0x3D021D0", VA = "0x183D039D0")]
	private bool NAPDHOKCGJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3D03DB0", Offset = "0x3D025B0", VA = "0x183D03DB0")]
	public CCGMJBIMIPE()
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
