using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class DNFENKNGIOJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::JEIPIOCCKKP<TRpcParam> where TActionReceiver : global::LEKLLGEGOLH<TAction, Task<global::DPAEKNFIIFN<object, IGAAKPFEHJP>>> where TActionDeps : global::BKEOFJAIIEH<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class KFBNMKGGHON
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct <<SendActionToAll>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public KFBNMKGGHON <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private TaskCompletionSource<global::DPAEKNFIIFN<object, IGAAKPFEHJP>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskAwaiter<global::DPAEKNFIIFN<object, IGAAKPFEHJP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2A3E940", Offset = "0x2A3DD40", VA = "0x182A3E940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public global::DNFENKNGIOJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<global::DPAEKNFIIFN<object, IGAAKPFEHJP>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public KFBNMKGGHON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3BC8080", Offset = "0x3BC7480", VA = "0x183BC8080")]
		[AsyncStateMachine(typeof(global::DNFENKNGIOJ<, , , , , >.KFBNMKGGHON.<<SendActionToAll>b__0>d))]
		internal Task <SendActionToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly global::MLBJFLBLEJN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> PPHNDGGADPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<global::MKGFFLLANNG<CPFIDKHNIPH>, global::MKGFFLLANNG<PNKGFAJDNGF>> AGMBPHKIOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HashSet<global::MKGFFLLANNG<CPFIDKHNIPH>> EEONAGLJLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private global::ELIEDAPLHCP<int> NECLJAMMLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly List<(global::MKGFFLLANNG<PNFGGCGFAAE> ActorId, global::MKGFFLLANNG<NHCPBGGICCO> RequestId, TAction Action)> MOPGDOBBFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool COPBGEIMEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<Func<Task>> FMMNIFALGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly global::NDPKFABCDGC<FHKAIACHAJB, global::MKGFFLLANNG<PNFGGCGFAAE>, TRpcParam, TRpcReceiver, global::BHOAFPBHIBH<PNFGGCGFAAE, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::MLBJFLBLEJN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> PJOGFPHFCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly global::EHCIGMNEMGK<TAction, TActionReceiver, TActionDeps, global::MLBJFLBLEJN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> EELLKPMDLNH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool PMNCHCMPLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3709900", Offset = "0x3708D00", VA = "0x183709900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::MKGFFLLANNG<PNFGGCGFAAE> JLDBICMPKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7530", Offset = "0x2CD6930", VA = "0x182CD7530")]
		get
		{
			return default(global::MKGFFLLANNG<PNFGGCGFAAE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x370A0F0", Offset = "0x37094F0", VA = "0x18370A0F0")]
	private DNFENKNGIOJ(global::MLBJFLBLEJN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> DNELEABCBIJ, global::NDPKFABCDGC<FHKAIACHAJB, global::MKGFFLLANNG<PNFGGCGFAAE>, TRpcParam, TRpcReceiver, global::BHOAFPBHIBH<PNFGGCGFAAE, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::MLBJFLBLEJN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> JHCEPENCPNA, global::EHCIGMNEMGK<TAction, TActionReceiver, TActionDeps, global::MLBJFLBLEJN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> GEODKFJBLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2CDE840", Offset = "0x2CDDC40", VA = "0x182CDE840", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3709A40", Offset = "0x3708E40", VA = "0x183709A40")]
	internal static global::DNFENKNGIOJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GEGCLDEHDAN(global::MLBJFLBLEJN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> DNELEABCBIJ, global::NDPKFABCDGC<FHKAIACHAJB, global::MKGFFLLANNG<PNFGGCGFAAE>, TRpcParam, TRpcReceiver, global::BHOAFPBHIBH<PNFGGCGFAAE, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::MLBJFLBLEJN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> JHCEPENCPNA, global::EHCIGMNEMGK<TAction, TActionReceiver, TActionDeps, global::MLBJFLBLEJN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> GEODKFJBLAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2530A40", Offset = "0x252FE40", VA = "0x182530A40")]
	public global::MKGFFLLANNG<PNKGFAJDNGF> ANFJKPJOEGF()
	{
		return default(global::MKGFFLLANNG<PNKGFAJDNGF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3709B50", Offset = "0x3708F50", VA = "0x183709B50")]
	internal global::MKGFFLLANNG<PNKGFAJDNGF> IFOFBDILNFE(global::MKGFFLLANNG<CPFIDKHNIPH> BJKMNBIBKCI, in FHKAIACHAJB JGHFLANLLNE)
	{
		return default(global::MKGFFLLANNG<PNKGFAJDNGF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3709F40", Offset = "0x3709340", VA = "0x183709F40")]
	internal void NAHBFFFECOK(global::MKGFFLLANNG<CPFIDKHNIPH> JGHFLANLLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x370A090", Offset = "0x3709490", VA = "0x18370A090")]
	internal void PBKDKOJMPFO(global::MKGFFLLANNG<CPFIDKHNIPH> JGHFLANLLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3709840", Offset = "0x3708C40", VA = "0x183709840")]
	internal void AJNLKAFBDII(global::MKGFFLLANNG<CPFIDKHNIPH> JGHFLANLLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3709FC0", Offset = "0x37093C0", VA = "0x183709FC0")]
	internal void OFGJBOFFNDL(global::MKGFFLLANNG<CPFIDKHNIPH> JGHFLANLLNE, in TRpcParam MKABJKLMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3709E50", Offset = "0x3709250", VA = "0x183709E50")]
	internal void MDHOMFFHILK(global::MKGFFLLANNG<PGFGOIIPAAI> FFGILIGGKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3709970", Offset = "0x3708D70", VA = "0x183709970")]
	public global::MKGFFLLANNG<PNKGFAJDNGF> CEPDCLPGPJH(global::MKGFFLLANNG<CPFIDKHNIPH> JGHFLANLLNE)
	{
		return default(global::MKGFFLLANNG<PNKGFAJDNGF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3709B20", Offset = "0x3708F20", VA = "0x183709B20")]
	public void HCMHEAHLFMH(global::MKGFFLLANNG<PNKGFAJDNGF> JGHFLANLLNE, in TRpcParam MKABJKLMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3709BF0", Offset = "0x3708FF0", VA = "0x183709BF0")]
	public void IGEKOMEKBJL(global::MKGFFLLANNG<PNKGFAJDNGF> JGHFLANLLNE, in TRpcParam MKABJKLMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x37098A0", Offset = "0x3708CA0", VA = "0x1837098A0")]
	public void BAIGEEBCNKA(global::MKGFFLLANNG<PNKGFAJDNGF> JGHFLANLLNE, in TRpcParam MKABJKLMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x370A060", Offset = "0x3709460", VA = "0x18370A060")]
	public void OHPBKIDHDCM(global::MKGFFLLANNG<PNKGFAJDNGF> JGHFLANLLNE, in TRpcParam MKABJKLMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3709810", Offset = "0x3708C10", VA = "0x183709810")]
	public void AEKGPBCNOOH(global::MKGFFLLANNG<PNKGFAJDNGF> JGHFLANLLNE, in TRpcReceiver IAHCGEAPOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3709E20", Offset = "0x3709220", VA = "0x183709E20")]
	public global::MKGFFLLANNG<PNFGGCGFAAE> LHFODIIPAGM(global::MKGFFLLANNG<PNKGFAJDNGF> JGHFLANLLNE)
	{
		return default(global::MKGFFLLANNG<PNFGGCGFAAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x37099D0", Offset = "0x3708DD0", VA = "0x1837099D0")]
	public bool DLAGBIDNOFN(global::MKGFFLLANNG<PNKGFAJDNGF> JGHFLANLLNE, global::MKGFFLLANNG<PNFGGCGFAAE> AGDFLBCNCIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3709A10", Offset = "0x3708E10", VA = "0x183709A10")]
	public global::MKGFFLLANNG<PGFGOIIPAAI> EJFMFNLIFFD(global::MKGFFLLANNG<PNKGFAJDNGF> JGHFLANLLNE, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) MKABJKLMICD)
	{
		return default(global::MKGFFLLANNG<PGFGOIIPAAI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3709F10", Offset = "0x3709310", VA = "0x183709F10")]
	public void NAAGKOOHKFP(global::MKGFFLLANNG<PGFGOIIPAAI> HACCDHDJEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x37098D0", Offset = "0x3708CD0", VA = "0x1837098D0")]
	public void BBKBIKJCCPD(global::MKGFFLLANNG<PGFGOIIPAAI> HACCDHDJEDO, in TSyncFieldValue FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3709C50", Offset = "0x3709050", VA = "0x183709C50")]
	public Task<global::DPAEKNFIIFN<object, IGAAKPFEHJP>> LDGIBHLIJEP(in TAction EFFJGLADCMH, bool KJCDDHNCOPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3709C20", Offset = "0x3709020", VA = "0x183709C20")]
	public void JOFBDNMCKIM(in TActionReceiver PJGJKGCIKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3709680", Offset = "0x3708A80", VA = "0x183709680")]
	public void ADICAPMKHIC(global::MKGFFLLANNG<PNFGGCGFAAE> HBEOHAENGAI, global::MKGFFLLANNG<NHCPBGGICCO> OOOKBBDPMIM, in TAction EFFJGLADCMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class MLBJFLBLEJN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : global::KKDCGJCAFFE<FHKAIACHAJB, global::MKGFFLLANNG<PNFGGCGFAAE>, TRpcParam, global::BHOAFPBHIBH<PNFGGCGFAAE, TSyncFieldValue>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::ELPIHIFLEMB<TAction> where TRpcReceiver : global::JEIPIOCCKKP<TRpcParam> where TActionReceiver : global::LEKLLGEGOLH<TAction, Task<global::DPAEKNFIIFN<object, IGAAKPFEHJP>>> where TActionDeps : global::BKEOFJAIIEH<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly global::HHKNHFLNFNO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> HOHEOEIEIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly global::MKGFFLLANNG<PNFGGCGFAAE> JDGBNLLMOOA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public global::MKGFFLLANNG<PNFGGCGFAAE> JLDBICMPKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x705BA0", Offset = "0x704FA0", VA = "0x180705BA0", Slot = "4")]
		get
		{
			return default(global::MKGFFLLANNG<PNFGGCGFAAE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::MKGFFLLANNG<PNFGGCGFAAE> GKFMDPCMKAP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x705BA0", Offset = "0x704FA0", VA = "0x180705BA0", Slot = "14")]
		get
		{
			return default(global::MKGFFLLANNG<PNFGGCGFAAE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HDLFCEDENJL
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6C6930", Offset = "0x6C5D30", VA = "0x1806C6930", Slot = "17")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x35F0F80", Offset = "0x35F0380", VA = "0x1835F0F80")]
	private MLBJFLBLEJN(global::HHKNHFLNFNO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> PDFNGODAECK, global::MKGFFLLANNG<PNFGGCGFAAE> BJKMNBIBKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x35F0BB0", Offset = "0x35EFFB0", VA = "0x1835F0BB0")]
	public static global::MLBJFLBLEJN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GEGCLDEHDAN(global::MKGFFLLANNG<PNFGGCGFAAE> BJKMNBIBKCI, global::HHKNHFLNFNO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> PDFNGODAECK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x35F0810", Offset = "0x35EFC10", VA = "0x1835F0810")]
	public global::MKGFFLLANNG<PNKGFAJDNGF> ANFJKPJOEGF()
	{
		return default(global::MKGFFLLANNG<PNKGFAJDNGF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x35F0C80", Offset = "0x35F0080", VA = "0x1835F0C80")]
	public void HCMHEAHLFMH(in FHKAIACHAJB JGHFLANLLNE, in TRpcParam MKABJKLMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x35F0CF0", Offset = "0x35F00F0", VA = "0x1835F0CF0")]
	public void IGEKOMEKBJL(in FHKAIACHAJB JGHFLANLLNE, in TRpcParam MKABJKLMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x35F0850", Offset = "0x35EFC50", VA = "0x1835F0850")]
	public void BAIGEEBCNKA(in FHKAIACHAJB JGHFLANLLNE, in TRpcParam MKABJKLMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x35F0E90", Offset = "0x35F0290", VA = "0x1835F0E90")]
	public void OHPBKIDHDCM(in FHKAIACHAJB JGHFLANLLNE, in TRpcParam MKABJKLMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x35F0DF0", Offset = "0x35F01F0", VA = "0x1835F0DF0")]
	public global::MKGFFLLANNG<PNFGGCGFAAE> LHFODIIPAGM(in FHKAIACHAJB JGHFLANLLNE)
	{
		return default(global::MKGFFLLANNG<PNFGGCGFAAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x35F0A30", Offset = "0x35EFE30", VA = "0x1835F0A30")]
	public bool DLAGBIDNOFN(in FHKAIACHAJB JGHFLANLLNE, global::MKGFFLLANNG<PNFGGCGFAAE> AGDFLBCNCIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x35F0AE0", Offset = "0x35EFEE0", VA = "0x1835F0AE0")]
	public global::BHOAFPBHIBH<PNFGGCGFAAE, TSyncFieldValue> EJFMFNLIFFD(global::MKGFFLLANNG<PGFGOIIPAAI> FFGILIGGKDK, in FHKAIACHAJB FKBMHFEKLIC, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) MKABJKLMICD)
	{
		return default(global::BHOAFPBHIBH<PNFGGCGFAAE, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x35F0E30", Offset = "0x35F0230", VA = "0x1835F0E30")]
	public void NAAGKOOHKFP(in global::BHOAFPBHIBH<PNFGGCGFAAE, TSyncFieldValue> MKABJKLMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x35F0F10", Offset = "0x35F0310", VA = "0x1835F0F10")]
	public void PCBHAOJGOGO(in global::BHOAFPBHIBH<PNFGGCGFAAE, TSyncFieldValue> HACCDHDJEDO, in TSyncFieldValue FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x35F0990", Offset = "0x35EFD90", VA = "0x1835F0990", Slot = "15")]
	public void CIFEFLJHDEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x35F0D70", Offset = "0x35F0170", VA = "0x1835F0D70", Slot = "16")]
	public void LDGIBHLIJEP(global::MKGFFLLANNG<NHCPBGGICCO> OOOKBBDPMIM, TAction EFFJGLADCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x35F0CC0", Offset = "0x35F00C0", VA = "0x1835F0CC0", Slot = "5")]
	private void IENGONMHNGP(in FHKAIACHAJB JGHFLANLLNE, in TRpcParam MKABJKLMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x35F0DC0", Offset = "0x35F01C0", VA = "0x1835F0DC0", Slot = "6")]
	private void LHEPDPABDGP(in FHKAIACHAJB JGHFLANLLNE, in TRpcParam MKABJKLMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3232570", Offset = "0x3231970", VA = "0x183232570", Slot = "7")]
	private void HCIDPCDFNFA(in FHKAIACHAJB JGHFLANLLNE, in TRpcParam MKABJKLMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x35F0900", Offset = "0x35EFD00", VA = "0x1835F0900", Slot = "8")]
	private void BJAFNAMAACL(in FHKAIACHAJB JGHFLANLLNE, in TRpcParam MKABJKLMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x35F0960", Offset = "0x35EFD60", VA = "0x1835F0960", Slot = "9")]
	private global::MKGFFLLANNG<PNFGGCGFAAE> BMBKMMCHNDL(in FHKAIACHAJB JGHFLANLLNE)
	{
		return default(global::MKGFFLLANNG<PNFGGCGFAAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x35F08D0", Offset = "0x35EFCD0", VA = "0x1835F08D0", Slot = "10")]
	private bool BIBLKCDEAGM(in FHKAIACHAJB JGHFLANLLNE, global::MKGFFLLANNG<PNFGGCGFAAE> AGDFLBCNCIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x35F09C0", Offset = "0x35EFDC0", VA = "0x1835F09C0", Slot = "11")]
	private global::BHOAFPBHIBH<PNFGGCGFAAE, TSyncFieldValue> CIMGKPAOCGA(global::MKGFFLLANNG<PGFGOIIPAAI> BJKMNBIBKCI, in FHKAIACHAJB JGHFLANLLNE, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) MKABJKLMICD)
	{
		return default(global::BHOAFPBHIBH<PNFGGCGFAAE, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3231B90", Offset = "0x3230F90", VA = "0x183231B90", Slot = "12")]
	private void MDPOMCHFLLP(in global::BHOAFPBHIBH<PNFGGCGFAAE, TSyncFieldValue> MKABJKLMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x35F0930", Offset = "0x35EFD30", VA = "0x1835F0930", Slot = "13")]
	private void BKLNOMKGOGJ(in global::BHOAFPBHIBH<PNFGGCGFAAE, TSyncFieldValue> HACCDHDJEDO, in TSyncFieldValue FPLJCBGEJAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HHKNHFLNFNO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::JEIPIOCCKKP<TRpcParam> where TActionReceiver : global::LEKLLGEGOLH<TAction, Task<global::DPAEKNFIIFN<object, IGAAKPFEHJP>>> where TActionDeps : global::BKEOFJAIIEH<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::MKGFFLLANNG<PNFGGCGFAAE> FGFGKONHILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private global::FJMNDOIHAEB<CPFIDKHNIPH, global::BLKNELCINPO<PNFGGCGFAAE>> EPAKAPFGELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Dictionary<string, global::AIMBHHIAOPM<PNFGGCGFAAE, TSyncFieldValue>> MMHFHLFCCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private global::IBAMIFLEJOJ<PNFGGCGFAAE, global::DNFENKNGIOJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> EBPCCOMDPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly TActionDeps HDNBNFMOIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly List<(global::MKGFFLLANNG<PNFGGCGFAAE> ActorId, global::MKGFFLLANNG<NHCPBGGICCO> RequestId, TAction Action)> GNEOIPGFKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly int? EODEGGFNGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly int? LMHHFHNOILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Queue<(global::MKGFFLLANNG<PNFGGCGFAAE> ActorId, global::MKGFFLLANNG<NHCPBGGICCO> RequestId, TAction Action)> MHHEJIEIJGF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal global::MKGFFLLANNG<PNFGGCGFAAE> CLPAGBEIDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6E4780", Offset = "0x6E3B80", VA = "0x1806E4780")]
		get
		{
			return default(global::MKGFFLLANNG<PNFGGCGFAAE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x39CCE90", Offset = "0x39CC290", VA = "0x1839CCE90")]
	protected HHKNHFLNFNO(TActionDeps PFPFGJJHBFI, int? HFMECMKLADC, int? GJFLHNHBPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x39CBB40", Offset = "0x39CAF40", VA = "0x1839CBB40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x39CC170", Offset = "0x39CB570", VA = "0x1839CC170")]
	public global::DNFENKNGIOJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> JKDOBIPDOCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x39CB420", Offset = "0x39CA820", VA = "0x1839CB420")]
	internal global::MKGFFLLANNG<PNKGFAJDNGF> ANFJKPJOEGF(global::MKGFFLLANNG<PNFGGCGFAAE> HIGKAANONJG)
	{
		return default(global::MKGFFLLANNG<PNKGFAJDNGF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x39CBEB0", Offset = "0x39CB2B0", VA = "0x1839CBEB0")]
	internal void IIIFNMOKCCB(global::MKGFFLLANNG<CPFIDKHNIPH> JGHFLANLLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x39CC9F0", Offset = "0x39CBDF0", VA = "0x1839CC9F0")]
	internal global::MKGFFLLANNG<PNFGGCGFAAE> LHFODIIPAGM(global::MKGFFLLANNG<CPFIDKHNIPH> JGHFLANLLNE)
	{
		return default(global::MKGFFLLANNG<PNFGGCGFAAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x39CCA40", Offset = "0x39CBE40", VA = "0x1839CCA40")]
	internal void LODKOJEDCID(global::MKGFFLLANNG<PNFGGCGFAAE> ICFOBEAIECP, global::MKGFFLLANNG<CPFIDKHNIPH> JGHFLANLLNE, in TRpcParam MKABJKLMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x39CC100", Offset = "0x39CB500", VA = "0x1839CC100")]
	internal void IKGJFHGDAKF(global::MKGFFLLANNG<PNFGGCGFAAE> ILAEOFBGAHD, global::MKGFFLLANNG<CPFIDKHNIPH> JGHFLANLLNE, in TRpcParam MKABJKLMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x39CB920", Offset = "0x39CAD20", VA = "0x1839CB920")]
	internal void DJIHANLHCPO(global::MKGFFLLANNG<PNFGGCGFAAE> ICFOBEAIECP, global::MKGFFLLANNG<CPFIDKHNIPH> JGHFLANLLNE, in TRpcParam MKABJKLMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x39CCCF0", Offset = "0x39CC0F0", VA = "0x1839CCCF0")]
	internal global::BHOAFPBHIBH<PNFGGCGFAAE, TSyncFieldValue> MMJFGJEIDPM(global::MKGFFLLANNG<PNFGGCGFAAE> IKIJMIKGPNJ, global::MKGFFLLANNG<PGFGOIIPAAI> FFGILIGGKDK, string NPBDKCONLNC, in TSyncFieldValue FPLJCBGEJAP, Action KCKLDKHBENC, Action<object> LOLCHKLFLKM, Func<bool> HAHKFBAPEPN)
	{
		return default(global::BHOAFPBHIBH<PNFGGCGFAAE, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x39CB720", Offset = "0x39CAB20", VA = "0x1839CB720")]
	internal void BAAAGKNJNJN(global::MKGFFLLANNG<PNFGGCGFAAE> IKIJMIKGPNJ, string NPBDKCONLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x39CCAD0", Offset = "0x39CBED0", VA = "0x1839CCAD0")]
	internal void MDHOMFFHILK(global::AIMBHHIAOPM<PNFGGCGFAAE, TSyncFieldValue> FFGILIGGKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x39CB810", Offset = "0x39CAC10", VA = "0x1839CB810")]
	internal void CIFEFLJHDEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x39CC560", Offset = "0x39CB960", VA = "0x1839CC560")]
	internal void LDGIBHLIJEP(global::MKGFFLLANNG<PNFGGCGFAAE> HBEOHAENGAI, global::MKGFFLLANNG<NHCPBGGICCO> OOOKBBDPMIM, in TAction EFFJGLADCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x39CB850", Offset = "0x39CAC50", VA = "0x1839CB850")]
	[CompilerGenerated]
	private global::DNFENKNGIOJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> DHHJOCHFLON(global::MKGFFLLANNG<PNFGGCGFAAE> AODHICDFMKF)
	{
		return null;
	}
}
namespace Cpp2IlInjected;

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
