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
public class JDNCJLAKNCA : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5F44B0", Offset = "0x5F34B0", VA = "0x1805F44B0")]
	public JDNCJLAKNCA()
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
		[Cpp2IlInjected.Address(RVA = "0x4E31D0", Offset = "0x4E21D0", VA = "0x1804E31D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4E3EE0", Offset = "0x4E2EE0", VA = "0x1804E3EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4E34A0", Offset = "0x4E24A0", VA = "0x1804E34A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "4")]
	public virtual void DEMHDDGJLCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1A526F0", Offset = "0x1A516F0", VA = "0x181A526F0")]
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
	[JDNCJLAKNCA]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3AB6050", Offset = "0x3AB5050", VA = "0x183AB6050", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3AB5B90", Offset = "0x3AB4B90", VA = "0x183AB5B90", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3AB6650", Offset = "0x3AB5650", VA = "0x183AB6650")]
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
	private sealed class AMKAICFCCLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1A526F0", Offset = "0x1A516F0", VA = "0x181A526F0")]
		public AMKAICFCCLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x260D730", Offset = "0x260C730", VA = "0x18260D730")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[JDNCJLAKNCA]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x26139A0", Offset = "0x26129A0", VA = "0x1826139A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x26139D0", Offset = "0x26129D0", VA = "0x1826139D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x26138F0", Offset = "0x26128F0", VA = "0x1826138F0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey GOLKIAIKMMJ]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2613920", Offset = "0x2612920", VA = "0x182613920", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x26137F0", Offset = "0x26127F0", VA = "0x1826137F0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2613050", Offset = "0x2612050", VA = "0x182613050", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x26129C0", Offset = "0x26119C0", VA = "0x1826129C0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2612620", Offset = "0x2611620", VA = "0x182612620", Slot = "14")]
	protected virtual string HHKAMFCMLED(TKeyVal JPLHGLOGMPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x24DB3A0", Offset = "0x24DA3A0", VA = "0x1824DB3A0", Slot = "4")]
	public bool ContainsKey(TKey GOLKIAIKMMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x26136E0", Offset = "0x26126E0", VA = "0x1826136E0", Slot = "5")]
	public bool TryGetValue(TKey GOLKIAIKMMJ, out TVal NBFFDDDBNPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2612530", Offset = "0x2611530", VA = "0x182612530", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2612530", Offset = "0x2611530", VA = "0x182612530", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2613710", Offset = "0x2612710", VA = "0x182613710")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MIBPJLFGDFF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class DFCJCJDMDLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1A526F0", Offset = "0x1A516F0", VA = "0x181A526F0")]
		public DFCJCJDMDLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1FB0090", Offset = "0x1FAF090", VA = "0x181FB0090")]
		internal bool <GetSamples>b__0(global::IGFGKCCAEIB<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float APLGCCBINGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float MJNGIODLFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<global::IGFGKCCAEIB<float, T>> GEENLIPDMNP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int IGABNLFNGME
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1FC0130", Offset = "0x1FBF130", VA = "0x181FC0130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC01B0", Offset = "0x1FBF1B0", VA = "0x181FC01B0")]
	public MIBPJLFGDFF(float IDLFPDDNJNG, float GKEEFBCPHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFF20", Offset = "0x1FBEF20", VA = "0x181FBFF20")]
	public bool IHEPIAEKHNK(float KONAAKMFLBB, T NBFFDDDBNPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFA80", Offset = "0x1FBEA80", VA = "0x181FBFA80")]
	public IEnumerable<T> GCACOLDPOKP(float KONAAKMFLBB, [Optional] float? DKBEKGAIGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0080", Offset = "0x1FBF080", VA = "0x181FC0080")]
	public void JFKIAFPDGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF680", Offset = "0x1FBE680", VA = "0x181FBF680")]
	private void CLMEENCPIPI(float KONAAKMFLBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class OIFIBHBAMCC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct OEKKBCODEIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public T AGMOAIIIIJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float GPPEEHEFOBE;
	}

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static float DIMPJNNMKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private List<T> KCJODIJFLFA;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const int PFNNJPPMPCA = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private OEKKBCODEIN[] EOAEGGPMECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int POKCCCEAFAP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float CCBACPCHLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xC7FB30", Offset = "0xC7EB30", VA = "0x180C7FB30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xC78DF0", Offset = "0xC77DF0", VA = "0x180C78DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3167F20", Offset = "0x3166F20", VA = "0x183167F20")]
	public OIFIBHBAMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3167F50", Offset = "0x3166F50", VA = "0x183167F50")]
	public OIFIBHBAMCC(int MMNEHHBHOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3167740", Offset = "0x3166740", VA = "0x183167740")]
	public void IDCEJGBHLFK(float KONAAKMFLBB, T NBFFDDDBNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3167C00", Offset = "0x3166C00", VA = "0x183167C00")]
	public void JFKIAFPDGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3167820", Offset = "0x3166820", VA = "0x183167820")]
	public bool IDPHDLKHHFM(float FFDCFEIKCKI, float CKMHILEAECA, out T NBFFDDDBNPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3167050", Offset = "0x3166050", VA = "0x183167050")]
	public bool BGJLMAGFHBB(float FFDCFEIKCKI, float CKMHILEAECA, out T NBFFDDDBNPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x31674D0", Offset = "0x31664D0", VA = "0x1831674D0")]
	public void CNMKBIEIBBK(float FFDCFEIKCKI, float CKMHILEAECA, List<T> LGFOFCOBEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3167EA0", Offset = "0x3166EA0", VA = "0x183167EA0")]
	private int OCEDLLBGOAA(int OKIFAPELHGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3167620", Offset = "0x3166620", VA = "0x183167620")]
	private void DNFCCCKEMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CECADJDKJGK();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T IEBLOBPFCGC(T NBFFDDDBNPN, float GHJCIPMLMCA);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T CEFLNIPMCGF(T DFDNMMCIADI, T GIKFIBEPHBO);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T MAIKMGICFFL(T DFDNMMCIADI, T GIKFIBEPHBO);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class JDKBLFPLCOJ : global::OIFIBHBAMCC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x468D870", Offset = "0x468C870", VA = "0x18468D870", Slot = "4")]
	protected override Vector3 CECADJDKJGK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x468D990", Offset = "0x468C990", VA = "0x18468D990", Slot = "5")]
	protected override Vector3 IEBLOBPFCGC(Vector3 NBFFDDDBNPN, float GHJCIPMLMCA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x468D8E0", Offset = "0x468C8E0", VA = "0x18468D8E0", Slot = "6")]
	protected override Vector3 CEFLNIPMCGF(Vector3 DFDNMMCIADI, Vector3 GIKFIBEPHBO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x468DA30", Offset = "0x468CA30", VA = "0x18468DA30", Slot = "7")]
	protected override Vector3 MAIKMGICFFL(Vector3 DFDNMMCIADI, Vector3 GIKFIBEPHBO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x468DAA0", Offset = "0x468CAA0", VA = "0x18468DAA0")]
	public JDKBLFPLCOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MCCAHDJBPNO
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1C92D70", Offset = "0x1C91D70", VA = "0x181C92D70")]
	public static global::IGFGKCCAEIB<T1, T2> OHLBCBNLJLB<T1, T2>(T1 DGAHILANBFA, T2 BNFNDDFAJAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1C92DE0", Offset = "0x1C91DE0", VA = "0x181C92DE0")]
	public static global::MIJPPGMDMON<T1, T2, T3> OHLBCBNLJLB<T1, T2, T3>(T1 DGAHILANBFA, T2 BNFNDDFAJAM, T3 JGBBCCLBKNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2139EF0", Offset = "0x2138EF0", VA = "0x182139EF0")]
	internal static int JILGDOEOGPH(int BKKBHNIFMAE, int NPJEDNKJFED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4162EB0", Offset = "0x4161EB0", VA = "0x184162EB0")]
	internal static int JILGDOEOGPH(int BKKBHNIFMAE, int NPJEDNKJFED, int FMPFFDJLEAC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IGFGKCCAEIB<T1, T2> : IComparable<global::IGFGKCCAEIB<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T1 GFKHPKBHJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly T2 PCNGAOKLNAP;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2041930", Offset = "0x2040930", VA = "0x182041930")]
	public IGFGKCCAEIB(T1 DGAHILANBFA, T2 BNFNDDFAJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x24C8B20", Offset = "0x24C7B20", VA = "0x1824C8B20", Slot = "4")]
	public int CompareTo(global::IGFGKCCAEIB<T1, T2> DOGDGMKLIFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x24C9480", Offset = "0x24C8480", VA = "0x1824C9480", Slot = "0")]
	public override bool Equals(object DOGDGMKLIFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x24C99A0", Offset = "0x24C89A0", VA = "0x1824C99A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x24CA160", Offset = "0x24C9160", VA = "0x1824CA160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MIJPPGMDMON<T1, T2, T3> : IComparable<global::MIJPPGMDMON<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly T1 GFKHPKBHJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly T2 PCNGAOKLNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly T3 JKHNAGGAHEH;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0A40", Offset = "0x1FBFA40", VA = "0x181FC0A40")]
	public MIJPPGMDMON(T1 DGAHILANBFA, T2 BNFNDDFAJAM, T3 JGBBCCLBKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0260", Offset = "0x1FBF260", VA = "0x181FC0260", Slot = "4")]
	public int CompareTo(global::MIJPPGMDMON<T1, T2, T3> DOGDGMKLIFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0460", Offset = "0x1FBF460", VA = "0x181FC0460", Slot = "0")]
	public override bool Equals(object DOGDGMKLIFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1FC06C0", Offset = "0x1FBF6C0", VA = "0x181FC06C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1FC07C0", Offset = "0x1FBF7C0", VA = "0x181FC07C0", Slot = "3")]
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
	public T AGMOAIIIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x50BA30", Offset = "0x50AA30", VA = "0x18050BA30")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5C85E0", Offset = "0x5C75E0", VA = "0x1805C85E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float DEEEBBPBAPM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xF3E560", Offset = "0xF3D560", VA = "0x180F3E560")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x390ADF0", Offset = "0x3909DF0", VA = "0x18390ADF0")]
	public T AHFKMLDAOLB(float GHJCIPMLMCA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x390B160", Offset = "0x390A160", VA = "0x18390B160")]
	public T IGBEPOOFGBN(float GHJCIPMLMCA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T AMMHEEAOLCI(T DFDNMMCIADI, T GIKFIBEPHBO, float GHJCIPMLMCA);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1A526F0", Offset = "0x1A516F0", VA = "0x181A526F0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x468D2E0", Offset = "0x468C2E0", VA = "0x18468D2E0", Slot = "4")]
	protected override float AMMHEEAOLCI(float DFDNMMCIADI, float GIKFIBEPHBO, float GHJCIPMLMCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x468D360", Offset = "0x468C360", VA = "0x18468D360")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x468EA40", Offset = "0x468DA40", VA = "0x18468EA40", Slot = "4")]
	protected override Vector3 AMMHEEAOLCI(Vector3 DFDNMMCIADI, Vector3 GIKFIBEPHBO, float GHJCIPMLMCA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x468EB00", Offset = "0x468DB00", VA = "0x18468EB00")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x46719C0", Offset = "0x46709C0", VA = "0x1846719C0", Slot = "4")]
	protected override Color AMMHEEAOLCI(Color DFDNMMCIADI, Color GIKFIBEPHBO, float GHJCIPMLMCA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x468C9E0", Offset = "0x468B9E0", VA = "0x18468C9E0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class AILGPGNIAMB<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<TKey, TVal> DAPPDNFNHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TVal, TKey> KBNHKDEAMOO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int NKNPCMBDPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1A566E0", Offset = "0x1A556E0", VA = "0x181A566E0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool FDJDDGAFGIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4E3EC0", Offset = "0x4E2EC0", VA = "0x1804E3EC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ICollection<TKey> AMGIMEIEEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1B7FCF0", Offset = "0x1B7ECF0", VA = "0x181B7FCF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ICollection<TVal> OHHAODHHHNN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1B70C30", Offset = "0x1B6FC30", VA = "0x181B70C30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal MBHJLEHEHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1C03FB0", Offset = "0x1C02FB0", VA = "0x181C03FB0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1C03FE0", Offset = "0x1C02FE0", VA = "0x181C03FE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1C03800", Offset = "0x1C02800", VA = "0x181C03800", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1C03E50", Offset = "0x1C02E50", VA = "0x181C03E50", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1C037A0", Offset = "0x1C027A0", VA = "0x181C037A0", Slot = "9")]
	public void Add(TKey GOLKIAIKMMJ, TVal NBFFDDDBNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1C037D0", Offset = "0x1C027D0", VA = "0x181C037D0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> HAMMCKCENAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1C03860", Offset = "0x1C02860", VA = "0x181C03860", Slot = "8")]
	public bool ContainsKey(TKey GOLKIAIKMMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1C03890", Offset = "0x1C02890", VA = "0x181C03890", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> HAMMCKCENAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1C03DA0", Offset = "0x1C02DA0", VA = "0x181C03DA0", Slot = "10")]
	public bool Remove(TKey GOLKIAIKMMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1C03DA0", Offset = "0x1C02DA0", VA = "0x181C03DA0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> HAMMCKCENAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1C03EA0", Offset = "0x1C02EA0", VA = "0x181C03EA0", Slot = "11")]
	public bool TryGetValue(TKey GOLKIAIKMMJ, out TVal NBFFDDDBNPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1C03A60", Offset = "0x1C02A60", VA = "0x181C03A60", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1C038F0", Offset = "0x1C028F0", VA = "0x181C038F0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] EOAEGGPMECO, int NOPPLJIPOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1C03D70", Offset = "0x1C02D70", VA = "0x181C03D70")]
	public bool LHDMFMLDGFN(TVal GOLKIAIKMMJ, out TKey NBFFDDDBNPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1C03950", Offset = "0x1C02950", VA = "0x181C03950")]
	private void EMFIDPNEAJB(TKey GOLKIAIKMMJ, TVal PGEGNPPIILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1C03CF0", Offset = "0x1C02CF0", VA = "0x181C03CF0")]
	private void IHEBHKIGCND(TKey GOLKIAIKMMJ, TVal PGEGNPPIILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1C03AE0", Offset = "0x1C02AE0", VA = "0x181C03AE0")]
	private bool IBOCHLEBING(TKey GOLKIAIKMMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1C03ED0", Offset = "0x1C02ED0", VA = "0x181C03ED0")]
	public AILGPGNIAMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public class KDOAFPLIMOG<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private global::KDOAFPLIMOG<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0xC7FB30", Offset = "0xC7EB30", VA = "0x180C7FB30", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x395D620", Offset = "0x395C620", VA = "0x18395D620", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x395D910", Offset = "0x395C910", VA = "0x18395D910")]
		public Enumerator(global::KDOAFPLIMOG<T> LGFOFCOBEDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x395CD50", Offset = "0x395BD50", VA = "0x18395CD50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x395D2D0", Offset = "0x395C2D0", VA = "0x18395D2D0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x395CCD0", Offset = "0x395BCD0", VA = "0x18395CCD0")]
		private void FNOPLHNICOA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T[] NPGIILGGKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int IGAJMLAENFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int MKIMKDNJBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int GDDDELIOHBI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int NKNPCMBDPKD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3967320", Offset = "0x3966320", VA = "0x183967320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public T MBHJLEHEHJP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3968430", Offset = "0x3967430", VA = "0x183968430")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3967890", Offset = "0x3966890", VA = "0x183967890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x39686F0", Offset = "0x39676F0", VA = "0x1839686F0")]
	public KDOAFPLIMOG(int CEIHLDFNAFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3967910", Offset = "0x3966910", VA = "0x183967910")]
	public void IDCEJGBHLFK(T GHJCIPMLMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3967C00", Offset = "0x3966C00", VA = "0x183967C00")]
	public void JFKIAFPDGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3968160", Offset = "0x3967160", VA = "0x183968160")]
	public void LMLNABJFCMH(int PDCIKKOCPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3968010", Offset = "0x3967010", VA = "0x183968010")]
	public void JMKJHDCHCCE(T[] EOAEGGPMECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3968260", Offset = "0x3967260", VA = "0x183968260")]
	public Enumerator LNBBCILFLNL()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3968500", Offset = "0x3967500", VA = "0x183968500", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3968500", Offset = "0x3967500", VA = "0x183968500", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3967450", Offset = "0x3966450", VA = "0x183967450")]
	private int EADIGBFACAJ(int ODKCMELFFGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x39684D0", Offset = "0x39674D0", VA = "0x1839684D0")]
	private int OLENEAPIKCN(int ODKCMELFFGF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class JAIJKODJODL
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
	protected JAIJKODJODL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class DOCMICCHLDG<T> : JAIJKODJODL
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	protected struct IAEACFLCINO
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum EJEKAEAOMKA
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
		public EJEKAEAOMKA ELMEHHJGGCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public T PGICAAEJFJD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int MDEHDLPOCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly bool IAFLDJNGJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	protected readonly bool LIOOMBCAAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	protected List<T> BAKLAHGHCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<IAEACFLCINO> GIPHLGKNLCM;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool NPIHEFFEHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1EB44E0", Offset = "0x1EB34E0", VA = "0x181EB44E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4C60", Offset = "0x1EB3C60", VA = "0x181EB4C60")]
	protected DOCMICCHLDG(bool LIOOMBCAAHK, bool IAFLDJNGJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4780", Offset = "0x1EB3780", VA = "0x181EB4780")]
	protected bool JBPLFKPLLNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4520", Offset = "0x1EB3520", VA = "0x181EB4520")]
	protected void GGFFBLGJFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4950", Offset = "0x1EB3950", VA = "0x181EB4950")]
	protected void OGMPOLAAKCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2955300", Offset = "0x2954300", VA = "0x182955300")]
	private static void PLMPCAFHHGK<U>(ref List<U> IKDBPOECNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4600", Offset = "0x1EB3600", VA = "0x181EB4600", Slot = "4")]
	public void IDCEJGBHLFK(T PGICAAEJFJD, bool GJKFCECKNEL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4B00", Offset = "0x1EB3B00", VA = "0x181EB4B00", Slot = "5")]
	public void PMCHHOBKDIO(T PGICAAEJFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4820", Offset = "0x1EB3820", VA = "0x181EB4820")]
	public void JFKIAFPDGGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class KNOFHMGDNMF : global::DOCMICCHLDG<Action>
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x468DD80", Offset = "0x468CD80", VA = "0x18468DD80")]
	public KNOFHMGDNMF(bool LIOOMBCAAHK = false, bool IAFLDJNGJBO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x468DB60", Offset = "0x468CB60", VA = "0x18468DB60")]
	public void GEAFPFEILAP()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x468DB00", Offset = "0x468CB00", VA = "0x18468DB00")]
	public static KNOFHMGDNMF BKJBEFGNPEG(KNOFHMGDNMF CNGDPOBOEGG, Action PGICAAEJFJD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x468DD20", Offset = "0x468CD20", VA = "0x18468DD20")]
	public static KNOFHMGDNMF KHMJOOLKHHF(KNOFHMGDNMF CNGDPOBOEGG, Action PGICAAEJFJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface ECEBELNELOP<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IDCEJGBHLFK(Action<T> PGICAAEJFJD, bool GJKFCECKNEL = false);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMCHHOBKDIO(Action<T> PGICAAEJFJD);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class FAIIJKIBCAG<T> : global::DOCMICCHLDG<Action<T>>, global::ECEBELNELOP<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1EA3950", Offset = "0x1EA2950", VA = "0x181EA3950")]
	public FAIIJKIBCAG(bool LIOOMBCAAHK = false, bool IAFLDJNGJBO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x33E7280", Offset = "0x33E6280", VA = "0x1833E7280")]
	public void GEAFPFEILAP(T GHJCIPMLMCA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4A80", Offset = "0x1FB3A80", VA = "0x181FB4A80")]
	public static global::FAIIJKIBCAG<T> BKJBEFGNPEG(global::FAIIJKIBCAG<T> CNGDPOBOEGG, Action<T> PGICAAEJFJD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1FB65E0", Offset = "0x1FB55E0", VA = "0x181FB65E0")]
	public static global::FAIIJKIBCAG<T> KHMJOOLKHHF(global::FAIIJKIBCAG<T> CNGDPOBOEGG, Action<T> PGICAAEJFJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface PFCJFONCOHM<T, U>
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class JHDHFMCILFL<T, U> : global::DOCMICCHLDG<Action<T, U>>, global::PFCJFONCOHM<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1EA3950", Offset = "0x1EA2950", VA = "0x181EA3950")]
	public JHDHFMCILFL(bool LIOOMBCAAHK = false, bool IAFLDJNGJBO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B450", Offset = "0x2D1A450", VA = "0x182D1B450")]
	public void GEAFPFEILAP(T GHJCIPMLMCA, U MENLBGMCDEC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4A80", Offset = "0x1FB3A80", VA = "0x181FB4A80")]
	public static global::JHDHFMCILFL<T, U> BKJBEFGNPEG(global::JHDHFMCILFL<T, U> CNGDPOBOEGG, Action<T, U> PGICAAEJFJD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1FB65E0", Offset = "0x1FB55E0", VA = "0x181FB65E0")]
	public static global::JHDHFMCILFL<T, U> KHMJOOLKHHF(global::JHDHFMCILFL<T, U> CNGDPOBOEGG, Action<T, U> PGICAAEJFJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class PAPIBBHDKEO<T, U, V> : global::DOCMICCHLDG<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1EA3950", Offset = "0x1EA2950", VA = "0x181EA3950")]
	public PAPIBBHDKEO(bool LIOOMBCAAHK = false, bool IAFLDJNGJBO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x203F100", Offset = "0x203E100", VA = "0x18203F100")]
	public void GEAFPFEILAP(T GHJCIPMLMCA, U MENLBGMCDEC, V DOHJBAOPOKG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4A80", Offset = "0x1FB3A80", VA = "0x181FB4A80")]
	public static global::PAPIBBHDKEO<T, U, V> BKJBEFGNPEG(global::PAPIBBHDKEO<T, U, V> CNGDPOBOEGG, Action<T, U, V> PGICAAEJFJD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1FB65E0", Offset = "0x1FB55E0", VA = "0x181FB65E0")]
	public static global::PAPIBBHDKEO<T, U, V> KHMJOOLKHHF(global::PAPIBBHDKEO<T, U, V> CNGDPOBOEGG, Action<T, U, V> PGICAAEJFJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PAMOMEMGIKN<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class MFBCHAOPBEA<T, U, V, W> : global::DOCMICCHLDG<Action<T, U, V, W>>, global::PAMOMEMGIKN<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1EA3950", Offset = "0x1EA2950", VA = "0x181EA3950")]
	public MFBCHAOPBEA(bool LIOOMBCAAHK = false, bool IAFLDJNGJBO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1FB60C0", Offset = "0x1FB50C0", VA = "0x181FB60C0")]
	public void GEAFPFEILAP(T GHJCIPMLMCA, U MENLBGMCDEC, V DOHJBAOPOKG, W DLEMLHMNLPH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4A80", Offset = "0x1FB3A80", VA = "0x181FB4A80")]
	public static global::MFBCHAOPBEA<T, U, V, W> BKJBEFGNPEG(global::MFBCHAOPBEA<T, U, V, W> CNGDPOBOEGG, Action<T, U, V, W> PGICAAEJFJD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1FB65E0", Offset = "0x1FB55E0", VA = "0x181FB65E0")]
	public static global::MFBCHAOPBEA<T, U, V, W> KHMJOOLKHHF(global::MFBCHAOPBEA<T, U, V, W> CNGDPOBOEGG, Action<T, U, V, W> PGICAAEJFJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class NNGKMFPBJLN<T, U, V, W, X> : global::DOCMICCHLDG<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1EA3950", Offset = "0x1EA2950", VA = "0x181EA3950")]
	public NNGKMFPBJLN(bool LIOOMBCAAHK = false, bool IAFLDJNGJBO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x339C4B0", Offset = "0x339B4B0", VA = "0x18339C4B0")]
	public void GEAFPFEILAP(T GHJCIPMLMCA, U MENLBGMCDEC, V DOHJBAOPOKG, W DLEMLHMNLPH, X APLMPEFFNCL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4A80", Offset = "0x1FB3A80", VA = "0x181FB4A80")]
	public static global::NNGKMFPBJLN<T, U, V, W, X> BKJBEFGNPEG(global::NNGKMFPBJLN<T, U, V, W, X> CNGDPOBOEGG, Action<T, U, V, W, X> PGICAAEJFJD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1FB65E0", Offset = "0x1FB55E0", VA = "0x181FB65E0")]
	public static global::NNGKMFPBJLN<T, U, V, W, X> KHMJOOLKHHF(global::NNGKMFPBJLN<T, U, V, W, X> CNGDPOBOEGG, Action<T, U, V, W, X> PGICAAEJFJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class JPJAPFLCEHL<T, U, V, W, X, Y> : global::DOCMICCHLDG<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1EA3950", Offset = "0x1EA2950", VA = "0x181EA3950")]
	public JPJAPFLCEHL(bool LIOOMBCAAHK = false, bool IAFLDJNGJBO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2D29770", Offset = "0x2D28770", VA = "0x182D29770")]
	public void GEAFPFEILAP(T GHJCIPMLMCA, U MENLBGMCDEC, V DOHJBAOPOKG, W DLEMLHMNLPH, X APLMPEFFNCL, Y IKBPIALPOCI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4A80", Offset = "0x1FB3A80", VA = "0x181FB4A80")]
	public static global::JPJAPFLCEHL<T, U, V, W, X, Y> BKJBEFGNPEG(global::JPJAPFLCEHL<T, U, V, W, X, Y> CNGDPOBOEGG, Action<T, U, V, W, X, Y> PGICAAEJFJD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1FB65E0", Offset = "0x1FB55E0", VA = "0x181FB65E0")]
	public static global::JPJAPFLCEHL<T, U, V, W, X, Y> KHMJOOLKHHF(global::JPJAPFLCEHL<T, U, V, W, X, Y> CNGDPOBOEGG, Action<T, U, V, W, X, Y> PGICAAEJFJD)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct NBNACMJECAI
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class AFMHOFHHGGC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct IBLNGAPAAOJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly global::AFMHOFHHGGC<T> GDNOIENAODE;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public T AGMOAIIIIJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x23B5DE0", Offset = "0x23B4DE0", VA = "0x1823B5DE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x23B5DB0", Offset = "0x23B4DB0", VA = "0x1823B5DB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5D1210", Offset = "0x5D0210", VA = "0x1805D1210")]
		public IBLNGAPAAOJ(global::AFMHOFHHGGC<T> GDNOIENAODE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly SemaphoreSlim PDFDPKLAMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T CNLBCALBMNI;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x23AD980", Offset = "0x23AC980", VA = "0x1823AD980")]
	public AFMHOFHHGGC(in T CNLBCALBMNI, int PDBJKGGGHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x23ADA20", Offset = "0x23ACA20", VA = "0x1823ADA20")]
	public AFMHOFHHGGC(in T CNLBCALBMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x23AD940", Offset = "0x23AC940", VA = "0x1823AD940")]
	public IBLNGAPAAOJ BECODAELGMN()
	{
		return default(IBLNGAPAAOJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class FKKCOBFGGIK
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x468D280", Offset = "0x468C280", VA = "0x18468D280")]
	public static global::AFMHOFHHGGC<NBNACMJECAI> ABPFEPFKAMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1C8BAE0", Offset = "0x1C8AAE0", VA = "0x181C8BAE0")]
	public static global::AFMHOFHHGGC<T> ABPFEPFKAMD<T>(in T CNLBCALBMNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class KPDDIBKACGG<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public delegate bool EBKPHCAEOBD(global::KPDDIBKACGG<T> AGPKFNBHLMB);

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class JGPOHJDDKCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public global::KPDDIBKACGG<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x1A526F0", Offset = "0x1A516F0", VA = "0x181A526F0")]
		public JGPOHJDDKCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2F64820", Offset = "0x2F63820", VA = "0x182F64820")]
		internal bool <FindNode>b__0(global::KPDDIBKACGG<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public T BMNIHIBPJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public LinkedList<global::KPDDIBKACGG<T>> ONAHGABEBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public global::KPDDIBKACGG<T> HDKLMBLFBLP;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public global::KPDDIBKACGG<T> PKDHBKIGODE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x536130", Offset = "0x535130", VA = "0x180536130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2F702A0", Offset = "0x2F6F2A0", VA = "0x182F702A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool KFDLBMIIJMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2F6F5C0", Offset = "0x2F6E5C0", VA = "0x182F6F5C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool EECPCFHLLDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2F6DE10", Offset = "0x2F6CE10", VA = "0x182F6DE10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public global::KPDDIBKACGG<T> FEOJFLNDPMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2F6DE50", Offset = "0x2F6CE50", VA = "0x182F6DE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2F70420", Offset = "0x2F6F420", VA = "0x182F70420")]
	public KPDDIBKACGG(T BHLIJEBGEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2F6E960", Offset = "0x2F6D960", VA = "0x182F6E960")]
	public global::KPDDIBKACGG<T> IIJDFKFDIIP(T MOCGNLDMKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2F6DED0", Offset = "0x2F6CED0", VA = "0x182F6DED0")]
	public global::KPDDIBKACGG<T> GOHHDNHENGG(T LJKPOFDHPII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2F70110", Offset = "0x2F6F110", VA = "0x182F70110")]
	public global::KPDDIBKACGG<T> PMCHHOBKDIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2F6ECE0", Offset = "0x2F6DCE0", VA = "0x182F6ECE0")]
	public void JFKIAFPDGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2F6E260", Offset = "0x2F6D260", VA = "0x182F6E260")]
	public global::KPDDIBKACGG<T> IEPPBEHJAKE(T NEPEDOHDOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2F6F280", Offset = "0x2F6E280", VA = "0x182F6F280")]
	public static void KFDHKLPPHLE(global::KPDDIBKACGG<T> AFKMHDOIGOI, EBKPHCAEOBD NMPAGBDMNDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x21F3490", Offset = "0x21F2490", VA = "0x1821F3490")]
	public static void KFDHKLPPHLE<A>(global::KPDDIBKACGG<T> AFKMHDOIGOI, Func<global::KPDDIBKACGG<T>, A, bool> NMPAGBDMNDB, A KCHKDKLAFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2F6FB40", Offset = "0x2F6EB40", VA = "0x182F6FB40")]
	public static string NMNPNDLOECB(global::KPDDIBKACGG<T> AFKMHDOIGOI, int JFPEIDMPMBL = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2F6E650", Offset = "0x2F6D650", VA = "0x182F6E650")]
	public static global::KPDDIBKACGG<T> IFPNCPGGCFD(global::KPDDIBKACGG<T> AFKMHDOIGOI, T MLCKDIHFMKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class PMPEHCMNCLP<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate int FOBALPFDMAJ(TKey GOLKIAIKMMJ, TVal NBFFDDDBNPN);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class MFNENONDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public TKey OPCJIONGLGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x4E31D0", Offset = "0x4E21D0", VA = "0x1804E31D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TVal AGMOAIIIIJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x668DA0", Offset = "0x667DA0", VA = "0x180668DA0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x6A77B0", Offset = "0x6A67B0", VA = "0x1806A77B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int PJIMDIEEEPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x5E26A0", Offset = "0x5E16A0", VA = "0x1805E26A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x5E26D0", Offset = "0x5E16D0", VA = "0x1805E26D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public DateTime CJBEGBCAAMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x4E5DF0", Offset = "0x4E4DF0", VA = "0x1804E5DF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xCBA4E0", Offset = "0xCB94E0", VA = "0x180CBA4E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3509A70", Offset = "0x3508A70", VA = "0x183509A70")]
		public MFNENONDKFC(TKey GOLKIAIKMMJ, TVal PGEGNPPIILP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const int AAKHNFKBIPO = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly Dictionary<TKey, LinkedListNode<MFNENONDKFC>> BBHFBILHMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly LinkedList<MFNENONDKFC> DINDLMNBONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly FOBALPFDMAJ MFDEJOFCAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly TimeSpan JNCMIJCBPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly MFEIOLONHDB BJJALKGOAFF;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int AOPKBCJDPID
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5EBAA0", Offset = "0x5EAAA0", VA = "0x1805EBAA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool BDPFIDNIMDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x350DF40", Offset = "0x350CF40", VA = "0x18350DF40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal int LPMGGOFAOGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5EBAB0", Offset = "0x5EAAB0", VA = "0x1805EBAB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E07C0", Offset = "0x5DF7C0", VA = "0x1805E07C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TKey MBHJLEHEHJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x350DF10", Offset = "0x350CF10", VA = "0x18350DF10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x350F3B0", Offset = "0x350E3B0", VA = "0x18350F3B0")]
	public PMPEHCMNCLP(int CEIHLDFNAFK, [Optional] FOBALPFDMAJ MFDEJOFCAKH, [Optional] IEqualityComparer<TKey> HINFNEOBOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x350F160", Offset = "0x350E160", VA = "0x18350F160")]
	public PMPEHCMNCLP(int CEIHLDFNAFK, FOBALPFDMAJ MFDEJOFCAKH, TimeSpan JNCMIJCBPIG, [Optional] IEqualityComparer<TKey> HINFNEOBOJB, [Optional] MFEIOLONHDB BJJALKGOAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x350D8F0", Offset = "0x350C8F0", VA = "0x18350D8F0")]
	public void CAMPHAHMDGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x350EC10", Offset = "0x350DC10", VA = "0x18350EC10")]
	public void OHEHFDMPDEJ(TKey GOLKIAIKMMJ, TVal NBFFDDDBNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x350ED90", Offset = "0x350DD90", VA = "0x18350ED90")]
	public bool PMCHHOBKDIO(TKey GOLKIAIKMMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x350E550", Offset = "0x350D550", VA = "0x18350E550")]
	public bool LHDMFMLDGFN(TKey CNEJIOEDOAA, out TVal NBFFDDDBNPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x350DFD0", Offset = "0x350CFD0", VA = "0x18350DFD0")]
	public void JFKIAFPDGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x350DB10", Offset = "0x350CB10", VA = "0x18350DB10")]
	private bool CPCCMFEBEBP(MFNENONDKFC BCGPIMNKDDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x350E050", Offset = "0x350D050", VA = "0x18350E050")]
	private void LFMOKPHGHJO(LinkedListNode<MFNENONDKFC> GEIFCKLLBKD, TVal LLIKEJCGBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x350EA00", Offset = "0x350DA00", VA = "0x18350EA00")]
	private void NCDFCOHKEPP(TKey GOLKIAIKMMJ, TVal NBFFDDDBNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x350DD70", Offset = "0x350CD70", VA = "0x18350DD70")]
	private void DKEFKIIPHMM(MFNENONDKFC BCGPIMNKDDN, TVal LLIKEJCGBFH, int MGGOHBMCICI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public class JJAAELMMKEG<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly List<T> IKDBPOECNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private HashSet<T> KPMLGODEIME;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int NKNPCMBDPKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1A566E0", Offset = "0x1A556E0", VA = "0x181A566E0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool FDJDDGAFGIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4E3EC0", Offset = "0x4E2EC0", VA = "0x1804E3EC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public T MBHJLEHEHJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2D21100", Offset = "0x2D20100", VA = "0x182D21100", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2D21130", Offset = "0x2D20130", VA = "0x182D21130", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2D20860", Offset = "0x2D1F860", VA = "0x182D20860", Slot = "11")]
	public void Add(T HAMMCKCENAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2D20980", Offset = "0x2D1F980", VA = "0x182D20980")]
	public bool CEDPIJFDAAH(T HAMMCKCENAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2D20FA0", Offset = "0x2D1FFA0", VA = "0x182D20FA0", Slot = "15")]
	public bool Remove(T HAMMCKCENAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2D20B60", Offset = "0x2D1FB60", VA = "0x182D20B60", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1EBCAB0", Offset = "0x1EBBAB0", VA = "0x181EBCAB0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2D20AD0", Offset = "0x2D1FAD0", VA = "0x182D20AD0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1BF3250", Offset = "0x1BF2250", VA = "0x181BF3250", Slot = "13")]
	public bool Contains(T HAMMCKCENAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2D20B30", Offset = "0x2D1FB30", VA = "0x182D20B30", Slot = "14")]
	public void CopyTo(T[] EOAEGGPMECO, int NOPPLJIPOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1C03FB0", Offset = "0x1C02FB0", VA = "0x181C03FB0", Slot = "6")]
	public int IndexOf(T HAMMCKCENAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2D20BE0", Offset = "0x2D1FBE0", VA = "0x182D20BE0", Slot = "7")]
	public void Insert(int ODKCMELFFGF, T HAMMCKCENAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2D20E40", Offset = "0x2D1FE40", VA = "0x182D20E40", Slot = "8")]
	public void RemoveAt(int ODKCMELFFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2D21020", Offset = "0x2D20020", VA = "0x182D21020")]
	public JJAAELMMKEG()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x1DDDF20", Offset = "0x1DDCF20", VA = "0x181DDDF20")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x468E380", Offset = "0x468D380", VA = "0x18468E380")]
		public SerializedGuid(in Guid PMOGMNOFHAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x468E1B0", Offset = "0x468D1B0", VA = "0x18468E1B0")]
		public static SerializedGuid HBKGJDCGHBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x468E230", Offset = "0x468D230", VA = "0x18468E230")]
		public static SerializedGuid MDGAJOCGFNJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x468DF90", Offset = "0x468CF90", VA = "0x18468DF90")]
		public bool DPGNELBBFJF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x468E350", Offset = "0x468D350", VA = "0x18468E350", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x468E2B0", Offset = "0x468D2B0", VA = "0x18468E2B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x468E020", Offset = "0x468D020", VA = "0x18468E020", Slot = "7")]
		public bool Equals(SerializedGuid DOGDGMKLIFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x468E0C0", Offset = "0x468D0C0", VA = "0x18468E0C0", Slot = "0")]
		public override bool Equals(object HPPOIDNICFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x468E1A0", Offset = "0x468D1A0", VA = "0x18468E1A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x468DF60", Offset = "0x468CF60", VA = "0x18468DF60", Slot = "6")]
		public int CompareTo(SerializedGuid DOGDGMKLIFB)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class IIMOGEMNFGH : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly Type PIMNNLIKKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly string HJHDNOLKNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly bool KEMNIBOICEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly bool MHDOCGJAGPL;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x468D800", Offset = "0x468C800", VA = "0x18468D800")]
	public IIMOGEMNFGH(Type FIPMJHFKKPC, string PBCHLJGEKCA, bool DNMPDEJAPPA = false, bool IBNFOPEOMBL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface NODJLIOIDHK<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	T AGMOAIIIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool HAKCMHPLLOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::NODJLIOIDHK<T> KPHCHOMINAG(Action<T> HDLDBKCLKMG);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::NODJLIOIDHK<T> MCHJNCNPMMM(Action<T> HDLDBKCLKMG);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class GDPDCJKCGEK<T> : global::NODJLIOIDHK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private global::JHDHFMCILFL<T, T> FODBJMCDEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private global::FAIIJKIBCAG<T> LOCJBDDNMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private global::FAIIJKIBCAG<string> AGGGHJMHDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string GEJGBLPCCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private T NCHHACLBALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private bool CMNECJJLNJA;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T AGMOAIIIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x50BA30", Offset = "0x50AA30", VA = "0x18050BA30", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1B759D0", Offset = "0x1B749D0", VA = "0x181B759D0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool HAKCMHPLLOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x58ACB0", Offset = "0x589CB0", VA = "0x18058ACB0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x1D91710", Offset = "0x1D90710", VA = "0x181D91710")]
	private void IECDDLMMIHC(T IBOJHLFNLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1D917B0", Offset = "0x1D907B0", VA = "0x181D917B0", Slot = "4")]
	public global::NODJLIOIDHK<T> KPHCHOMINAG(Action<T> BOGEGGHKIBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x1D91840", Offset = "0x1D90840", VA = "0x181D91840", Slot = "5")]
	public global::NODJLIOIDHK<T> MCHJNCNPMMM(Action<T> HDLDBKCLKMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1D91890", Offset = "0x1D90890", VA = "0x181D91890")]
	public GDPDCJKCGEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class CMGLBKOIIEN
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class FHDGCDMBIEG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public global::NODJLIOIDHK<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public global::NAIPFLHHPNG<T> promise;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1A526F0", Offset = "0x1A516F0", VA = "0x181A526F0")]
		public FHDGCDMBIEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x1B7A560", Offset = "0x1B79560", VA = "0x181B7A560")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1E521D0", Offset = "0x1E511D0", VA = "0x181E521D0")]
	public static global::IDCJFNACHEM<T> DHCNPGHLPIM<T>(this global::NODJLIOIDHK<T> LOFFAKHKBKF, Action<T> MBNIDEHOLID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class MFEIOLONHDB
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private class FHMJLAMFEOB : MFEIOLONHDB
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static MFEIOLONHDB BGMCCDCKKBI
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x468D120", Offset = "0x468C120", VA = "0x18468D120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override DateTime MNBOJMPBGEG
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x468D0D0", Offset = "0x468C0D0", VA = "0x18468D0D0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x468D220", Offset = "0x468C220", VA = "0x18468D220")]
		public FHMJLAMFEOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static MFEIOLONHDB PDCJEEJJNOJ;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static MFEIOLONHDB BIMNJJNELON
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x468DDE0", Offset = "0x468CDE0", VA = "0x18468DDE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract DateTime MNBOJMPBGEG
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
	protected MFEIOLONHDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class AMJIJAOMNLF : global::EBNHBCEAHHK<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x468BC70", Offset = "0x468AC70", VA = "0x18468BC70")]
	public AMJIJAOMNLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class EBNHBCEAHHK<T> : global::OHHMHNFCPPO<T>, AIAADONNNFN, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task<T> IAAOJDAGFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4E31D0", Offset = "0x4E21D0", VA = "0x1804E31D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public global::IDCJFNACHEM<T> AIBACDDAIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private BKMNEANDFIL DJOJNJAAADH
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1A52710", Offset = "0x1A51710", VA = "0x181A52710", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7B30", Offset = "0x1EB6B30", VA = "0x181EB7B30")]
	public EBNHBCEAHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class BBPEIJMPGDC<T> : global::OHHMHNFCPPO<T>, AIAADONNNFN, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Task<T> IAAOJDAGFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4E31D0", Offset = "0x4E21D0", VA = "0x1804E31D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public global::IDCJFNACHEM<T> AIBACDDAIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private BKMNEANDFIL DJOJNJAAADH
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1A52710", Offset = "0x1A51710", VA = "0x181A52710", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x31EF990", Offset = "0x31EE990", VA = "0x1831EF990")]
	public BBPEIJMPGDC(Exception FLCLFKPPOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface AIAADONNNFN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[NotNull]
	BKMNEANDFIL AIBACDDAIGN
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface OHHMHNFCPPO<T> : AIAADONNNFN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> IAAOJDAGFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	new global::IDCJFNACHEM<T> AIBACDDAIGN
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public abstract class CKOPCHIGCNK<TTask, T> : global::OHHMHNFCPPO<T>, AIAADONNNFN, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class HEHLILPHBLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public global::CKOPCHIGCNK<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x1A526F0", Offset = "0x1A516F0", VA = "0x181A526F0")]
		public HEHLILPHBLK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static bool PAEPANNFOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly Task<T> JKPJNOGMAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected readonly CancellationTokenSource FEMOEHGHHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool GOOBEBDGAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private SynchronizationContext GKKHJCMICDE;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task<T> IAAOJDAGFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4E31D0", Offset = "0x4E21D0", VA = "0x1804E31D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public global::IDCJFNACHEM<T> AIBACDDAIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private BKMNEANDFIL DJOJNJAAADH
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1A7F3E0", Offset = "0x1A7E3E0", VA = "0x181A7F3E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool GDCPIBKHMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x589D90", Offset = "0x588D90", VA = "0x180589D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1B789D0", Offset = "0x1B779D0", VA = "0x181B789D0")]
	static CKOPCHIGCNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x1B78CF0", Offset = "0x1B77CF0", VA = "0x181B78CF0")]
	protected CKOPCHIGCNK(TTask JKPJNOGMAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1B783F0", Offset = "0x1B773F0", VA = "0x181B783F0", Slot = "1")]
	~CKOPCHIGCNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1B783C0", Offset = "0x1B773C0", VA = "0x181B783C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x1B786A0", Offset = "0x1B776A0", VA = "0x181B786A0")]
	private void JAHIHIBCNCC(bool NKDMMAOMGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T CINOAIMNDAC(TTask LMOFJFLHMNB);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract void IPJHLJNBFIF();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x1B78810", Offset = "0x1B77810", VA = "0x181B78810")]
	[CompilerGenerated]
	private void LCICLAGINAI(object KKOCFGHMHMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public abstract class DDIODMBPEOO<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal class PGCOCFICGFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TNode FIIPLAIHDJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public TNode DOGKMHLECMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public GJHMOOAJJEP AJMDOGNODKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public List<GJHMOOAJJEP> CCHFLOPENHK;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x1A526F0", Offset = "0x1A516F0", VA = "0x181A526F0")]
		public PGCOCFICGFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	internal struct GJHMOOAJJEP : IComparable<GJHMOOAJJEP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int OPIJGMPOOOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public TClaimant JHFGDHLDIPN;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4EBCF0", Offset = "0x4EACF0", VA = "0x1804EBCF0")]
		public GJHMOOAJJEP(int OPIJGMPOOOO, TClaimant JHFGDHLDIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3C14B60", Offset = "0x3C13B60", VA = "0x183C14B60")]
		public bool KGEEGHAHHDO(in GJHMOOAJJEP DOGDGMKLIFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3C14B50", Offset = "0x3C13B50", VA = "0x183C14B50")]
		public bool IDLHCGGNMIO(in GJHMOOAJJEP DOGDGMKLIFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3C14B40", Offset = "0x3C13B40", VA = "0x183C14B40", Slot = "4")]
		public int CompareTo(GJHMOOAJJEP DOGDGMKLIFB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3C14BC0", Offset = "0x3C13BC0", VA = "0x183C14BC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum PCAIGAJJOJO
	{
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class BEFBJABCHKL : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public global::DDIODMBPEOO<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x1D80960", Offset = "0x1D7F960", VA = "0x181D80960")]
		[DebuggerHidden]
		public BEFBJABCHKL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3C02AE0", Offset = "0x3C01AE0", VA = "0x183C02AE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3C02CA0", Offset = "0x3C01CA0", VA = "0x183C02CA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3C02BC0", Offset = "0x3C01BC0", VA = "0x183C02BC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1A5ED40", Offset = "0x1A5DD40", VA = "0x181A5ED40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly global::HEGCGJFJNMI<PGCOCFICGFN> DMLNHBCEOBH;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly global::HEGCGJFJNMI<List<GJHMOOAJJEP>> GDPFJDEHKBE;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static int EPFGMPBGOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	internal readonly Dictionary<TClaimant, TNode> HPMGEDIJMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	internal readonly Dictionary<TNode, PGCOCFICGFN> EBMNLGHAPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly HashSet<TNode> EGNBEBFKGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private PCAIGAJJOJO OEHGHDNMNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private bool FFKBKKFHALG;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode DGHEMCBPBAE(TNode AGPKFNBHLMB);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void MBCPNFLLPPA(TNode AGPKFNBHLMB, TClaimant INCFAIGHFDA, TClaimant MAMBHKHEJIA);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3C0BD20", Offset = "0x3C0AD20", VA = "0x183C0BD20")]
	public DDIODMBPEOO(PCAIGAJJOJO OEHGHDNMNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3C0B3E0", Offset = "0x3C0A3E0", VA = "0x183C0B3E0")]
	public void KOHKHLNEKPK(TNode AGPKFNBHLMB, TNode NEPEDOHDOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3C0B460", Offset = "0x3C0A460", VA = "0x183C0B460")]
	public void MLGHPGNEPAB(TClaimant JHFGDHLDIPN, TNode CMDEHMGCHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3C0A7B0", Offset = "0x3C097B0", VA = "0x183C0A7B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3C0B960", Offset = "0x3C0A960", VA = "0x183C0B960")]
	private void OFDPFFABIIK(TClaimant JHFGDHLDIPN, TNode FKCJJBDALEH, TNode CMDEHMGCHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3C0A490", Offset = "0x3C09490", VA = "0x183C0A490")]
	private int AKIOOFNGKOL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3C0A500", Offset = "0x3C09500", VA = "0x183C0A500")]
	private void DFKOKNEAFIN(TClaimant JHFGDHLDIPN, TNode CELOKLOKCKI, TNode KHAJDBLBPJM, int LJLIIBPDOMJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3C0B350", Offset = "0x3C0A350", VA = "0x183C0B350")]
	private void JGKOKECBCMD(GJHMOOAJJEP APOLCLNKHLG, PGCOCFICGFN FFKGPJHKENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3C0B560", Offset = "0x3C0A560", VA = "0x183C0B560")]
	private void NMBKIBFJEPM(TClaimant JHFGDHLDIPN, TNode CELOKLOKCKI, TNode KHAJDBLBPJM, int LJLIIBPDOMJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3C0AB00", Offset = "0x3C09B00", VA = "0x183C0AB00")]
	private void GLNIPPAHOBH(GJHMOOAJJEP APOLCLNKHLG, TNode AGPKFNBHLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3C0AC00", Offset = "0x3C09C00", VA = "0x183C0AC00")]
	private void HAOEIJOCCNC(GJHMOOAJJEP APOLCLNKHLG, PGCOCFICGFN FFKGPJHKENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3C0B210", Offset = "0x3C0A210", VA = "0x183C0B210")]
	private void HKDJFINBOJL(PGCOCFICGFN FFKGPJHKENK, bool EMNFBEKEBFC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3C0ADD0", Offset = "0x3C09DD0", VA = "0x183C0ADD0")]
	private void HKCIONLAJBJ(PGCOCFICGFN FFKGPJHKENK, TNode NEPEDOHDOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3C0AD00", Offset = "0x3C09D00", VA = "0x183C0AD00")]
	[IteratorStateMachine(typeof(global::DDIODMBPEOO<, >.BEFBJABCHKL))]
	private IEnumerable<TNode> HFAEOBACNLK(TNode CELOKLOKCKI, TNode KHAJDBLBPJM, bool ACJMGJIKGPD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3C0AA40", Offset = "0x3C09A40", VA = "0x183C0AA40")]
	private PGCOCFICGFN FPNFKHBOKLF(TNode AGPKFNBHLMB, TNode DOGKMHLECMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3C0B7D0", Offset = "0x3C0A7D0", VA = "0x183C0B7D0")]
	private PGCOCFICGFN NNLCDMDLFHD(TNode AGPKFNBHLMB, TNode DOGKMHLECMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3C0BA00", Offset = "0x3C0AA00", VA = "0x183C0BA00")]
	private void ONKLJHFLJIJ(PGCOCFICGFN FFKGPJHKENK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class BAJCKENEAEP<T> : IEnumerable<global::BAJCKENEAEP<T>.OHDMHFIELJP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct OHDMHFIELJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public T NBFFDDDBNPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int ODKCMELFFGF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class ECPKPJOKKME : IEnumerator<OHDMHFIELJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private global::BAJCKENEAEP<T> NDDNNDJMEOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private int ODKCMELFFGF;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x2530550", Offset = "0x252F550", VA = "0x182530550", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public OHDMHFIELJP GONKNLDLIJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x31F4B40", Offset = "0x31F3B40", VA = "0x1831F4B40", Slot = "4")]
			get
			{
				return default(OHDMHFIELJP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x78C1B0", Offset = "0x78B1B0", VA = "0x18078C1B0")]
		public ECPKPJOKKME(global::BAJCKENEAEP<T> NDDNNDJMEOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x31F4AB0", Offset = "0x31F3AB0", VA = "0x1831F4AB0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x63BF60", Offset = "0x63AF60", VA = "0x18063BF60", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x756F10", Offset = "0x755F10", VA = "0x180756F10", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct IELIGIGDMND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public bool DDGGKKMAIDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public T NBFFDDDBNPN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private const int PJLJCIDKCIO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<T, int> GKAMCPENPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private IELIGIGDMND[] JOPFBOHCKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private int CCGELDJIMNG;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int NKNPCMBDPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x1B7FCF0", Offset = "0x1B7ECF0", VA = "0x181B7FCF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x31EECE0", Offset = "0x31EDCE0", VA = "0x1831EECE0")]
	public static global::BAJCKENEAEP<T> FDHHIAHDNCL(OHDMHFIELJP[] GNBKKBBIPBM, bool ECNGHDHFJLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x31EF340", Offset = "0x31EE340", VA = "0x1831EF340")]
	public BAJCKENEAEP(int CEIHLDFNAFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x31EF0C0", Offset = "0x31EE0C0", VA = "0x1831EF0C0")]
	public int FGJBIOAFINK(T NBFFDDDBNPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x31EEC70", Offset = "0x31EDC70", VA = "0x1831EEC70")]
	public T DHCNPGHLPIM(int ODKCMELFFGF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x31EEC50", Offset = "0x31EDC50", VA = "0x1831EEC50")]
	public bool CEDPIJFDAAH(T NBFFDDDBNPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x31EEA20", Offset = "0x31EDA20", VA = "0x1831EEA20")]
	public bool CEDPIJFDAAH(T NBFFDDDBNPN, int ODKCMELFFGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x31EF110", Offset = "0x31EE110", VA = "0x1831EF110")]
	public OHDMHFIELJP[] KFLKCIGDOFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x31EF280", Offset = "0x31EE280", VA = "0x1831EF280")]
	private int MMICNKDANAM(int IGAJMLAENFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x31EF2D0", Offset = "0x31EE2D0", VA = "0x1831EF2D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x31EF2D0", Offset = "0x31EE2D0", VA = "0x1831EF2D0", Slot = "4")]
	private IEnumerator<OHDMHFIELJP> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class HEGCGJFJNMI<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Stack<T> AKGHMJLKDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly List<T> PDIKJILNCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly int HCAMFIAOIHL;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x38A66A0", Offset = "0x38A56A0", VA = "0x1838A66A0")]
	public static global::HEGCGJFJNMI<T> FIMBINONCHM(int CEIHLDFNAFK = 0, int HCAMFIAOIHL = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x38A6CD0", Offset = "0x38A5CD0", VA = "0x1838A6CD0")]
	public HEGCGJFJNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x38A6B40", Offset = "0x38A5B40", VA = "0x1838A6B40")]
	public HEGCGJFJNMI(int CEIHLDFNAFK, int HCAMFIAOIHL = int.MaxValue, bool IIMAENIMFPP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x38A6A10", Offset = "0x38A5A10", VA = "0x1838A6A10")]
	public T ONPACIJFMDE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x38A6950", Offset = "0x38A5950", VA = "0x1838A6950")]
	public void OBOGLNDOFEE(T NBFFDDDBNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x38A64D0", Offset = "0x38A54D0", VA = "0x1838A64D0")]
	private void BJEFHAOBNLC(T NBFFDDDBNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x38A6770", Offset = "0x38A5770", VA = "0x1838A6770")]
	private void IEPNBNBEPNI(T NBFFDDDBNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x38A6590", Offset = "0x38A5590", VA = "0x1838A6590", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x38A6790", Offset = "0x38A5790", VA = "0x1838A6790")]
	private void LBHKKNCPKGH(IEnumerable<T> GHNCGCBDHEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class IACFHKHOONM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Dictionary<int, T> PHHANMIOILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private T FAGJLGCDFOL;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public virtual T FCMODJEPONN
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x4E34A0", Offset = "0x4E24A0", VA = "0x1804E34A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x24C76A0", Offset = "0x24C66A0", VA = "0x1824C76A0")]
	public bool NCDFCOHKEPP(T NBFFDDDBNPN, int OPIJGMPOOOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x24C7610", Offset = "0x24C6610", VA = "0x1824C7610")]
	public bool GGHPDBGEJAG(int OPIJGMPOOOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x24C73B0", Offset = "0x24C63B0", VA = "0x1824C73B0")]
	public T FJILLKMDBIG(int ELAIPFOKGDJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x24C6FA0", Offset = "0x24C5FA0", VA = "0x1824C6FA0")]
	private bool EAEOPNGGGHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x24C7670", Offset = "0x24C6670", VA = "0x1824C7670")]
	public bool LHDMFMLDGFN(int OPIJGMPOOOO, out T NBFFDDDBNPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x24C7760", Offset = "0x24C6760", VA = "0x1824C7760")]
	public IACFHKHOONM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class FIBDHMNMNAN<T>
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	protected struct ACCAMLPNODC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public T AGMOAIIIIJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int HIPCDHNIJFJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	protected readonly List<ACCAMLPNODC> NPGIILGGKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private T HEMLCDIDOGD;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int NKNPCMBDPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x1A566E0", Offset = "0x1A556E0", VA = "0x181A566E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3040", Offset = "0x3AC2040", VA = "0x183AC3040")]
	public bool NDDGMEBCJMI(T NBFFDDDBNPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3AC2F40", Offset = "0x3AC1F40", VA = "0x183AC2F40")]
	public void IDCEJGBHLFK(T NBFFDDDBNPN, int OPIJGMPOOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3290", Offset = "0x3AC2290", VA = "0x183AC3290")]
	public bool PMCHHOBKDIO(T NBFFDDDBNPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3AC2FE0", Offset = "0x3AC1FE0", VA = "0x183AC2FE0")]
	public void JFKIAFPDGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3AC2EB0", Offset = "0x3AC1EB0", VA = "0x183AC2EB0")]
	public T ECCKKLJPPPD()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x3AC2CA0", Offset = "0x3AC1CA0", VA = "0x183AC2CA0")]
	private void BFKHALHGOKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3AC33B0", Offset = "0x3AC23B0", VA = "0x183AC33B0")]
	public FIBDHMNMNAN()
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
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x1A66130", Offset = "0x1A65130", VA = "0x181A66130", Slot = "4")]
		public virtual T IAMPOLJNHMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x1A526F0", Offset = "0x1A516F0", VA = "0x181A526F0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class BOFKPDJEDKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly Dictionary<byte, EBJEBIKNFIF> LOBEAFIDJEG;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EBJEBIKNFIF OFFOBHLIDAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4E31D0", Offset = "0x4E21D0", VA = "0x1804E31D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4E3490", Offset = "0x4E2490", VA = "0x1804E3490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public Vector2 OMMAGDBNOGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x14CA960", Offset = "0x14C9960", VA = "0x1814CA960")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x1EA4590", Offset = "0x1EA3590", VA = "0x181EA4590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private Vector2 PDGLFHPHACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x1220000", Offset = "0x121F000", VA = "0x181220000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public Vector2 GDHKHOPMMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x32EA3D0", Offset = "0x32E93D0", VA = "0x1832EA3D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x32EA3F0", Offset = "0x32E93F0", VA = "0x1832EA3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int PGGDOAMOGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x50E7E0", Offset = "0x50D7E0", VA = "0x18050E7E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5349A0", Offset = "0x5339A0", VA = "0x1805349A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x468C4C0", Offset = "0x468B4C0", VA = "0x18468C4C0")]
	public BOFKPDJEDKJ(Bounds LAMGHLIAHPG, Vector2[] PPCCACLDCED, int MBAAFOEILNJ, byte IGAJMLAENFA, float MJDHIOBFFCG = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x468C330", Offset = "0x468B330", VA = "0x18468C330")]
	public EBJEBIKNFIF KDGGOABMEGA(byte ODKCMELFFGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x468BD20", Offset = "0x468AD20", VA = "0x18468BD20")]
	public void EHIEGLEFKMJ(Vector3 MKCADMKFJHF, float AKIPNMPPPPJ, float FMAADGOBDOD, ref List<byte> HFIFMLBOPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x468BD00", Offset = "0x468AD00", VA = "0x18468BD00")]
	public void CDDAGJLLJCL(EBJEBIKNFIF.DGDLAELKJPE AICHGEMBCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x468C390", Offset = "0x468B390", VA = "0x18468C390")]
	private EBJEBIKNFIF KNAMPGPGDBH(byte ODKCMELFFGF, EBJEBIKNFIF.ENNIJCNNBCJ PEGNILHPJPK, EBJEBIKNFIF DOGKMHLECMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x468BE10", Offset = "0x468AE10", VA = "0x18468BE10")]
	private void JGPOINONFBG(EBJEBIKNFIF DOGKMHLECMH, Vector2[] PPCCACLDCED, int HIPCAFPMIAD, int BMPNCNGGJMA, int GICNAMEJIFB, int NOGKAIHBIFK, float MJDHIOBFFCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class EBJEBIKNFIF
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public enum ENNIJCNNBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public enum DGDLAELKJPE
	{
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public byte HCKEFMJFGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Vector3 CPFNKJLMFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Vector3 PJIMDIEEEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Vector3 MCGNFJEDHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public Vector3 MJAJDFCMKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public ENNIJCNNBCJ GNGBGMACNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public EBJEBIKNFIF PKDHBKIGODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public List<EBJEBIKNFIF> LHJFDEPMJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool DANNDHAFEFI;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x468D070", Offset = "0x468C070", VA = "0x18468D070")]
	public EBJEBIKNFIF(byte DDPAIIBBEOH, ENNIJCNNBCJ PEGNILHPJPK, EBJEBIKNFIF DOGKMHLECMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x468CFD0", Offset = "0x468BFD0", VA = "0x18468CFD0")]
	public void IIJDFKFDIIP(EBJEBIKNFIF GLJOABABIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80")]
	public void CDDAGJLLJCL(int MDFKPGONCGH, DGDLAELKJPE AICHGEMBCPL, int AAIGGBFHJDJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x468CCE0", Offset = "0x468BCE0", VA = "0x18468CCE0")]
	public void EHIEGLEFKMJ(List<byte> HFIFMLBOPCJ, Vector3 MKCADMKFJHF, float AKIPNMPPPPJ, float FMAADGOBDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x468CF70", Offset = "0x468BF70", VA = "0x18468CF70")]
	public bool HPNDCHGGOJH(Vector3 CHAKKPCNPLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x468CCA0", Offset = "0x468BCA0", VA = "0x18468CCA0")]
	public bool DOHAJNLMFHK(Vector3 CHAKKPCNPLE, float KNDPJIEAJDD)
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
		public struct GLNNNJNMKAN<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private readonly List<Component> IKDBPOECNOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private readonly bool BAEPGGJKMHJ;

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x6E7940", Offset = "0x6E6940", VA = "0x1806E7940")]
			public GLNNNJNMKAN(List<Component> IKDBPOECNOG, bool BAEPGGJKMHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x1A56020", Offset = "0x1A55020", VA = "0x181A56020")]
			public MKDMKKIPLDN<T> LNBBCILFLNL()
			{
				return default(MKDMKKIPLDN<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x1A56090", Offset = "0x1A55090", VA = "0x181A56090", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x1A56090", Offset = "0x1A55090", VA = "0x181A56090", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public struct MKDMKKIPLDN<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private readonly List<Component> IKDBPOECNOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private readonly bool BAEPGGJKMHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int ODKCMELFFGF;

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public T GONKNLDLIJA
			{
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x1A5D640", Offset = "0x1A5C640", VA = "0x181A5D640", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0x1A5D5D0", Offset = "0x1A5C5D0", VA = "0x181A5D5D0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x1A5D610", Offset = "0x1A5C610", VA = "0x181A5D610")]
			public MKDMKKIPLDN(List<Component> IKDBPOECNOG, bool BAEPGGJKMHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x1A5D500", Offset = "0x1A5C500", VA = "0x181A5D500", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x1A5D510", Offset = "0x1A5C510", VA = "0x181A5D510", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1A5D5C0", Offset = "0x1A5C5C0", VA = "0x181A5D5C0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x468E610", Offset = "0x468D610", VA = "0x18468E610")]
		private void JJACNFBHGAP(GameObject PGCDHHIBCHL, bool LHOIPIGNODN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x468E4A0", Offset = "0x468D4A0", VA = "0x18468E4A0")]
		public static void JJACNFBHGAP(GameObject PGCDHHIBCHL, ref ToolHierarchyCache MPGDAHEICII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x1D05820", Offset = "0x1D04820", VA = "0x181D05820")]
		public void IJHDJIDCIAA<T>(Action<T> PGICAAEJFJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x293ADA0", Offset = "0x2939DA0", VA = "0x18293ADA0")]
		public GLNNNJNMKAN<T> HFEFBPLHNJA<T>(bool BAEPGGJKMHJ = false) where T : class
		{
			return default(GLNNNJNMKAN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x468E730", Offset = "0x468D730", VA = "0x18468E730")]
		public List<Component> OGHLKPIBHBE(Type ELMEHHJGGCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x468E3B0", Offset = "0x468D3B0", VA = "0x18468E3B0", Slot = "4")]
		public bool Equals(ToolHierarchyCache APLMPEFFNCL, ToolHierarchyCache IKBPIALPOCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x468E430", Offset = "0x468D430", VA = "0x18468E430", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache HPPOIDNICFG)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class FNFNKOOFJMH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private int CEIHLDFNAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int PFDNECMPPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private List<T> LDPGOKJDEON;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public T HDAKEFJCJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1D8E6F0", Offset = "0x1D8D6F0", VA = "0x181D8E6F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public T AIAIMDLFMPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1D8E610", Offset = "0x1D8D610", VA = "0x181D8E610")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public T HFCOINOKMGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x1D8E4E0", Offset = "0x1D8D4E0", VA = "0x181D8E4E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x1D8E770", Offset = "0x1D8D770", VA = "0x181D8E770")]
	public FNFNKOOFJMH(int CEIHLDFNAFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x1D8E220", Offset = "0x1D8D220", VA = "0x181D8E220")]
	public void IDCEJGBHLFK(T MDCAMIPJNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x1D8E4A0", Offset = "0x1D8D4A0", VA = "0x181D8E4A0")]
	public void JFKIAFPDGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x1D8E1C0", Offset = "0x1D8D1C0", VA = "0x181D8E1C0")]
	public void BAEHOFLILHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x1D8E210", Offset = "0x1D8D210", VA = "0x181D8E210")]
	public void EAKHAFEMHMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class LNEAPOJBBKJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct KLFCFOGBEPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int HIPCDHNIJFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public T AGMOAIIIIJB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Dictionary<object, KLFCFOGBEPH> PHHANMIOILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private T FAGJLGCDFOL;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T FCMODJEPONN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x14CA960", Offset = "0x14C9960", VA = "0x1814CA960", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x1EA4590", Offset = "0x1EA3590", VA = "0x181EA4590", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool MNCAKPKJENH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x1EAA280", Offset = "0x1EA9280", VA = "0x181EAA280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public object PAIOMCEKJPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4E5DF0", Offset = "0x4E4DF0", VA = "0x1804E5DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x50DD70", Offset = "0x50CD70", VA = "0x18050DD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1EA9C50", Offset = "0x1EA8C50", VA = "0x181EA9C50")]
	public bool NCDFCOHKEPP(T NBFFDDDBNPN, object HLENDKCOLOM, int OPIJGMPOOOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x1EA9340", Offset = "0x1EA8340", VA = "0x181EA9340")]
	public bool GGHPDBGEJAG(object HLENDKCOLOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x1EA9520", Offset = "0x1EA8520", VA = "0x181EA9520")]
	public bool LHDMFMLDGFN(object HLENDKCOLOM, out T NBFFDDDBNPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x1EA93B0", Offset = "0x1EA83B0", VA = "0x181EA93B0")]
	public void JFKIAFPDGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x1EA7D80", Offset = "0x1EA6D80", VA = "0x181EA7D80")]
	private bool EAEOPNGGGHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x1EAA2B0", Offset = "0x1EA92B0", VA = "0x181EAA2B0")]
	public LNEAPOJBBKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class DPBGJPDHMNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Dictionary<object, float> PHHANMIOILD;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public float IHBIHFBJPKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xE9B640", Offset = "0xE9A640", VA = "0x180E9B640")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xC54570", Offset = "0xC53570", VA = "0x180C54570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x468CBB0", Offset = "0x468BBB0", VA = "0x18468CBB0")]
	public void NCDFCOHKEPP(float NBFFDDDBNPN, object HLENDKCOLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x468CA20", Offset = "0x468BA20", VA = "0x18468CA20")]
	public void GGHPDBGEJAG(object HLENDKCOLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x468CA90", Offset = "0x468BA90", VA = "0x18468CA90")]
	private void HCEAFFPIPPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x468CC20", Offset = "0x468BC20", VA = "0x18468CC20")]
	public DPBGJPDHMNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class GOOKDOAADEN
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public sealed class BMGMBLKIOKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly string LNGNCDOEPLJ;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
		private BMGMBLKIOKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5C53C0", Offset = "0x5C43C0", VA = "0x1805C53C0")]
		public BMGMBLKIOKL(string LNGNCDOEPLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x468BCB0", Offset = "0x468ACB0", VA = "0x18468BCB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class HFMDNFMNKKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
		public HFMDNFMNKKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x468D750", Offset = "0x468C750", VA = "0x18468D750")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly HashSet<object> JHHCJMKMMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int JBJBBGKCCGF;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool FPJJEHLPMHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x468D3A0", Offset = "0x468C3A0", VA = "0x18468D3A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int NKNPCMBDPKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x56ABE0", Offset = "0x569BE0", VA = "0x18056ABE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x468D3B0", Offset = "0x468C3B0", VA = "0x18468D3B0")]
	public bool IDCEJGBHLFK(object HLENDKCOLOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x468D4F0", Offset = "0x468C4F0", VA = "0x18468D4F0")]
	public bool PMCHHOBKDIO(object HLENDKCOLOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x468D430", Offset = "0x468C430", VA = "0x18468D430")]
	public bool NDDGMEBCJMI(object HLENDKCOLOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x468D490", Offset = "0x468C490", VA = "0x18468D490")]
	public void NLHHOGLMJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x468D570", Offset = "0x468C570", VA = "0x18468D570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x468D6E0", Offset = "0x468C6E0", VA = "0x18468D6E0")]
	public GOOKDOAADEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class MGMOHCKHBDE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct FCGONNEHIAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float GPPEEHEFOBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public T AGMOAIIIIJB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Dictionary<object, FCGONNEHIAI> PHHANMIOILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private T HPMAICPIGGH;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public virtual T MCFIDOIINJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xDE34F0", Offset = "0xDE24F0", VA = "0x180DE34F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1EA4610", Offset = "0x1EA3610", VA = "0x181EA4610", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public object JDLMNFEMDMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x50BA30", Offset = "0x50AA30", VA = "0x18050BA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5C85E0", Offset = "0x5C75E0", VA = "0x1805C85E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool MNCAKPKJENH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1FBE2C0", Offset = "0x1FBD2C0", VA = "0x181FBE2C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x1FBE1C0", Offset = "0x1FBD1C0", VA = "0x181FBE1C0")]
	public bool NCDFCOHKEPP(T NBFFDDDBNPN, object HLENDKCOLOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD7F0", Offset = "0x1FBC7F0", VA = "0x181FBD7F0")]
	public bool GGHPDBGEJAG(object HLENDKCOLOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x1EA93B0", Offset = "0x1EA83B0", VA = "0x181EA93B0")]
	public void JFKIAFPDGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x1FBDA90", Offset = "0x1FBCA90", VA = "0x181FBDA90")]
	public bool LHDMFMLDGFN(object HLENDKCOLOM, out T NBFFDDDBNPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x1FBCF90", Offset = "0x1FBBF90", VA = "0x181FBCF90")]
	private bool EAEOPNGGGHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x1FBE300", Offset = "0x1FBD300", VA = "0x181FBE300")]
	public MGMOHCKHBDE()
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
