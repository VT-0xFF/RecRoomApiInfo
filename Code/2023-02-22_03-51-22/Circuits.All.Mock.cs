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
public sealed class DFPCDCNFMHC<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::KILLKJHAAPP<TRpcParam> where TActionReceiver : global::KMANKBKIKOF<TAction, Task<global::OHFECDBHLHC<object, NPKBEKPOKML>>> where TActionDeps : global::GLMLOKDOEPB<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class FOLGEEKDGHO
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
			public FOLGEEKDGHO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private TaskCompletionSource<global::OHFECDBHLHC<object, NPKBEKPOKML>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskAwaiter<global::OHFECDBHLHC<object, NPKBEKPOKML>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1DA40F0", Offset = "0x1DA32F0", VA = "0x181DA40F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6CF320", Offset = "0x6CE520", VA = "0x1806CF320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public global::DFPCDCNFMHC<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<global::OHFECDBHLHC<object, NPKBEKPOKML>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public FOLGEEKDGHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x30488F0", Offset = "0x3047AF0", VA = "0x1830488F0")]
		[AsyncStateMachine(typeof(global::DFPCDCNFMHC<, , , , , >.FOLGEEKDGHO.<<SendActionToAll>b__0>d))]
		internal Task <SendActionToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly global::KLANNKJBBJE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> FHGAMNFIHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<global::IOJDDMIHILI<DADGGCNLMDC>, global::IOJDDMIHILI<NEIPEEIDEIJ>> DEPIIBFAMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HashSet<global::IOJDDMIHILI<DADGGCNLMDC>> IGLAFGMMEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private global::MBPMAHFIKHD<int> JFJBBBJIGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly List<(global::IOJDDMIHILI<IBDPOCJOHKG> ActorId, global::IOJDDMIHILI<GGICLPCGLOC> RequestId, TAction Action)> LGNNEOEIGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool PANHGCNNCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<Func<Task>> EOEENEFNFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly global::JDEJCIKLJDE<KIEGPKHNPAI, global::IOJDDMIHILI<IBDPOCJOHKG>, TRpcParam, TRpcReceiver, global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::KLANNKJBBJE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> ENJPOILGNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly global::GPHBPBOCDCO<TAction, TActionReceiver, TActionDeps, global::KLANNKJBBJE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> JJOKOIEGCEA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool BFMJFJKOGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2A15090", Offset = "0x2A14290", VA = "0x182A15090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::IOJDDMIHILI<IBDPOCJOHKG> JIHMNJJIKIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x265CF10", Offset = "0x265C110", VA = "0x18265CF10")]
		get
		{
			return default(global::IOJDDMIHILI<IBDPOCJOHKG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2A156C0", Offset = "0x2A148C0", VA = "0x182A156C0")]
	private DFPCDCNFMHC(global::KLANNKJBBJE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> IAPGLFJKDEF, global::JDEJCIKLJDE<KIEGPKHNPAI, global::IOJDDMIHILI<IBDPOCJOHKG>, TRpcParam, TRpcReceiver, global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::KLANNKJBBJE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> FAHGNHLMLPK, global::GPHBPBOCDCO<TAction, TActionReceiver, TActionDeps, global::KLANNKJBBJE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> DLHDPKIEKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2664E10", Offset = "0x2664010", VA = "0x182664E10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2A15100", Offset = "0x2A14300", VA = "0x182A15100")]
	internal static global::DFPCDCNFMHC<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GDHAFJANMPF(global::KLANNKJBBJE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> IAPGLFJKDEF, global::JDEJCIKLJDE<KIEGPKHNPAI, global::IOJDDMIHILI<IBDPOCJOHKG>, TRpcParam, TRpcReceiver, global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::KLANNKJBBJE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> FAHGNHLMLPK, global::GPHBPBOCDCO<TAction, TActionReceiver, TActionDeps, global::KLANNKJBBJE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> DLHDPKIEKJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1CFE640", Offset = "0x1CFD840", VA = "0x181CFE640")]
	public global::IOJDDMIHILI<NEIPEEIDEIJ> GHPFGFOBOMB()
	{
		return default(global::IOJDDMIHILI<NEIPEEIDEIJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A14D10", Offset = "0x2A13F10", VA = "0x182A14D10")]
	internal global::IOJDDMIHILI<NEIPEEIDEIJ> CPIDDLCHGIP(global::IOJDDMIHILI<DADGGCNLMDC> LIKFEBDBPON, in KIEGPKHNPAI ADHHHFDPAPI)
	{
		return default(global::IOJDDMIHILI<NEIPEEIDEIJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2A15310", Offset = "0x2A14510", VA = "0x182A15310")]
	internal void HAGILDBFPKF(global::IOJDDMIHILI<DADGGCNLMDC> ADHHHFDPAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2A15210", Offset = "0x2A14410", VA = "0x182A15210")]
	internal void GIEHENOAGPE(global::IOJDDMIHILI<DADGGCNLMDC> ADHHHFDPAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2A14DE0", Offset = "0x2A13FE0", VA = "0x182A14DE0")]
	internal void DDMHJEFBDCI(global::IOJDDMIHILI<DADGGCNLMDC> ADHHHFDPAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2A15270", Offset = "0x2A14470", VA = "0x182A15270")]
	internal void GKMIABGKFEE(global::IOJDDMIHILI<DADGGCNLMDC> ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2A14C50", Offset = "0x2A13E50", VA = "0x182A14C50")]
	internal void ABDKCAPGEOF(global::IOJDDMIHILI<OADMPFEFGLH> KBJBPEAKGPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2A15030", Offset = "0x2A14230", VA = "0x182A15030")]
	public global::IOJDDMIHILI<NEIPEEIDEIJ> GAGENOLJEAL(global::IOJDDMIHILI<DADGGCNLMDC> ADHHHFDPAPI)
	{
		return default(global::IOJDDMIHILI<NEIPEEIDEIJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2A15390", Offset = "0x2A14590", VA = "0x182A15390")]
	public void HLLJEIJECBK(global::IOJDDMIHILI<NEIPEEIDEIJ> ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2A14E70", Offset = "0x2A14070", VA = "0x182A14E70")]
	public void EAECIJBDAKL(global::IOJDDMIHILI<NEIPEEIDEIJ> ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2A15690", Offset = "0x2A14890", VA = "0x182A15690")]
	public void PHNBJCEMCDJ(global::IOJDDMIHILI<NEIPEEIDEIJ> ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2A153C0", Offset = "0x2A145C0", VA = "0x182A153C0")]
	public void JGBIGHCOMEN(global::IOJDDMIHILI<NEIPEEIDEIJ> ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2A14E40", Offset = "0x2A14040", VA = "0x182A14E40")]
	public void DNKBICFEOLF(global::IOJDDMIHILI<NEIPEEIDEIJ> ADHHHFDPAPI, in TRpcReceiver ADGDOKPCBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2A15630", Offset = "0x2A14830", VA = "0x182A15630")]
	public global::IOJDDMIHILI<IBDPOCJOHKG> KNOEGEEMKJN(global::IOJDDMIHILI<NEIPEEIDEIJ> ADHHHFDPAPI)
	{
		return default(global::IOJDDMIHILI<IBDPOCJOHKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2A155F0", Offset = "0x2A147F0", VA = "0x182A155F0")]
	public bool KNIPLHMEFKN(global::IOJDDMIHILI<NEIPEEIDEIJ> ADHHHFDPAPI, global::IOJDDMIHILI<IBDPOCJOHKG> AKGNOBJJLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2A151E0", Offset = "0x2A143E0", VA = "0x182A151E0")]
	public global::IOJDDMIHILI<OADMPFEFGLH> GGCFFHAPFKE(global::IOJDDMIHILI<NEIPEEIDEIJ> ADHHHFDPAPI, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) CFMAPONGMKH)
	{
		return default(global::IOJDDMIHILI<OADMPFEFGLH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2A15660", Offset = "0x2A14860", VA = "0x182A15660")]
	public void LPLGCLJNABA(global::IOJDDMIHILI<OADMPFEFGLH> PHLLDEOMGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2A155C0", Offset = "0x2A147C0", VA = "0x182A155C0")]
	public void KHDIAHPDKAH(global::IOJDDMIHILI<OADMPFEFGLH> PHLLDEOMGCD, in TSyncFieldValue JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2A153F0", Offset = "0x2A145F0", VA = "0x182A153F0")]
	public Task<global::OHFECDBHLHC<object, NPKBEKPOKML>> JILLBFEJHGO(in TAction GPNJNMLGIEN, bool HKEPEHPCOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2A14DB0", Offset = "0x2A13FB0", VA = "0x182A14DB0")]
	public void DCCOMMDGIIL(in TActionReceiver EGIJMPKBLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2A14EA0", Offset = "0x2A140A0", VA = "0x182A14EA0")]
	public void FAGLKLPEJDH(global::IOJDDMIHILI<IBDPOCJOHKG> NOJAHDOHDIN, global::IOJDDMIHILI<GGICLPCGLOC> DAPJGJIMAOA, in TAction GPNJNMLGIEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class KLANNKJBBJE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : global::IMFOHPBMDFM<KIEGPKHNPAI, global::IOJDDMIHILI<IBDPOCJOHKG>, TRpcParam, global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::MFPGEPDJDLB<TAction> where TRpcReceiver : global::KILLKJHAAPP<TRpcParam> where TActionReceiver : global::KMANKBKIKOF<TAction, Task<global::OHFECDBHLHC<object, NPKBEKPOKML>>> where TActionDeps : global::GLMLOKDOEPB<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly global::AMHHNDLMNIA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> OBLJPLMAPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly global::IOJDDMIHILI<IBDPOCJOHKG> OKBCCCGAONO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public global::IOJDDMIHILI<IBDPOCJOHKG> JIHMNJJIKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6C8BD0", Offset = "0x6C7DD0", VA = "0x1806C8BD0", Slot = "4")]
		get
		{
			return default(global::IOJDDMIHILI<IBDPOCJOHKG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::IOJDDMIHILI<IBDPOCJOHKG> GKFEINNKKHI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8BD0", Offset = "0x6C7DD0", VA = "0x1806C8BD0", Slot = "14")]
		get
		{
			return default(global::IOJDDMIHILI<IBDPOCJOHKG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int ENENLNBCHMI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD370", VA = "0x1806CE170", Slot = "17")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2351BE0", Offset = "0x2350DE0", VA = "0x182351BE0")]
	private KLANNKJBBJE(global::AMHHNDLMNIA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> PICAOCFCGHD, global::IOJDDMIHILI<IBDPOCJOHKG> LIKFEBDBPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x23515E0", Offset = "0x23507E0", VA = "0x1823515E0")]
	public static global::KLANNKJBBJE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GDHAFJANMPF(global::IOJDDMIHILI<IBDPOCJOHKG> LIKFEBDBPON, global::AMHHNDLMNIA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> PICAOCFCGHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2351780", Offset = "0x2350980", VA = "0x182351780")]
	public global::IOJDDMIHILI<NEIPEEIDEIJ> GHPFGFOBOMB()
	{
		return default(global::IOJDDMIHILI<NEIPEEIDEIJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x23517F0", Offset = "0x23509F0", VA = "0x1823517F0")]
	public void HLLJEIJECBK(in KIEGPKHNPAI ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2351530", Offset = "0x2350730", VA = "0x182351530")]
	public void EAECIJBDAKL(in KIEGPKHNPAI ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2351B60", Offset = "0x2350D60", VA = "0x182351B60")]
	public void PHNBJCEMCDJ(in KIEGPKHNPAI ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2351860", Offset = "0x2350A60", VA = "0x182351860")]
	public void JGBIGHCOMEN(in KIEGPKHNPAI ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x23519F0", Offset = "0x2350BF0", VA = "0x1823519F0")]
	public global::IOJDDMIHILI<IBDPOCJOHKG> KNOEGEEMKJN(in KIEGPKHNPAI ADHHHFDPAPI)
	{
		return default(global::IOJDDMIHILI<IBDPOCJOHKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2351960", Offset = "0x2350B60", VA = "0x182351960")]
	public bool KNIPLHMEFKN(in KIEGPKHNPAI ADHHHFDPAPI, global::IOJDDMIHILI<IBDPOCJOHKG> AKGNOBJJLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x23516B0", Offset = "0x23508B0", VA = "0x1823516B0")]
	public global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue> GGCFFHAPFKE(global::IOJDDMIHILI<OADMPFEFGLH> KBJBPEAKGPP, in KIEGPKHNPAI IGJFJCHKKMF, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) CFMAPONGMKH)
	{
		return default(global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2351A30", Offset = "0x2350C30", VA = "0x182351A30")]
	public void LPLGCLJNABA(in global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue> CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2351A90", Offset = "0x2350C90", VA = "0x182351A90")]
	public void NCALKIIAKCE(in global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue> PHLLDEOMGCD, in TSyncFieldValue JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2351430", Offset = "0x2350630", VA = "0x182351430", Slot = "15")]
	public void AJBNHHLKAGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x23518E0", Offset = "0x2350AE0", VA = "0x1823518E0", Slot = "16")]
	public void JILLBFEJHGO(global::IOJDDMIHILI<GGICLPCGLOC> DAPJGJIMAOA, TAction GPNJNMLGIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2351B30", Offset = "0x2350D30", VA = "0x182351B30", Slot = "5")]
	private void PDNEGFFNOFN(in KIEGPKHNPAI ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2351B00", Offset = "0x2350D00", VA = "0x182351B00", Slot = "6")]
	private void PCBMHPLCDCI(in KIEGPKHNPAI ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2351460", Offset = "0x2350660", VA = "0x182351460", Slot = "7")]
	private void BIOJEIAIPHJ(in KIEGPKHNPAI ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2351490", Offset = "0x2350690", VA = "0x182351490", Slot = "8")]
	private void CJOEBLHIOKC(in KIEGPKHNPAI ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x23515B0", Offset = "0x23507B0", VA = "0x1823515B0", Slot = "9")]
	private global::IOJDDMIHILI<IBDPOCJOHKG> GAEHNHHIJNO(in KIEGPKHNPAI ADHHHFDPAPI)
	{
		return default(global::IOJDDMIHILI<IBDPOCJOHKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2351830", Offset = "0x2350A30", VA = "0x182351830", Slot = "10")]
	private bool JCFDHEPECJP(in KIEGPKHNPAI ADHHHFDPAPI, global::IOJDDMIHILI<IBDPOCJOHKG> AKGNOBJJLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x23514C0", Offset = "0x23506C0", VA = "0x1823514C0", Slot = "11")]
	private global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue> DEFHADKNNLE(global::IOJDDMIHILI<OADMPFEFGLH> LIKFEBDBPON, in KIEGPKHNPAI ADHHHFDPAPI, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) CFMAPONGMKH)
	{
		return default(global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2351930", Offset = "0x2350B30", VA = "0x182351930", Slot = "12")]
	private void JNKPAAJFGCJ(in global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue> CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x23517C0", Offset = "0x23509C0", VA = "0x1823517C0", Slot = "13")]
	private void HBECMGOBFJL(in global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue> PHLLDEOMGCD, in TSyncFieldValue JFBPNBNBHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AMHHNDLMNIA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::KILLKJHAAPP<TRpcParam> where TActionReceiver : global::KMANKBKIKOF<TAction, Task<global::OHFECDBHLHC<object, NPKBEKPOKML>>> where TActionDeps : global::GLMLOKDOEPB<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::IOJDDMIHILI<IBDPOCJOHKG> LAGOCDJOIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private global::LDEGJHNGFHB<DADGGCNLMDC, global::KBIIMCFJNAF<IBDPOCJOHKG>> NAPMIGLCIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Dictionary<string, global::AHBCNHEDODP<IBDPOCJOHKG, TSyncFieldValue>> ODHNCGDKEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private global::ALHIEDAIMPD<IBDPOCJOHKG, global::DFPCDCNFMHC<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> MDGKFJOLMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly TActionDeps PINDPOOCJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly List<(global::IOJDDMIHILI<IBDPOCJOHKG> ActorId, global::IOJDDMIHILI<GGICLPCGLOC> RequestId, TAction Action)> IFLKPEJFNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly int? DNCEPFJKDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly int? LDCDEEKHGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Queue<(global::IOJDDMIHILI<IBDPOCJOHKG> ActorId, global::IOJDDMIHILI<GGICLPCGLOC> RequestId, TAction Action)> DBBJGIFADFO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal global::IOJDDMIHILI<IBDPOCJOHKG> JFKDKJJPEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6C7040", Offset = "0x6C6240", VA = "0x1806C7040")]
		get
		{
			return default(global::IOJDDMIHILI<IBDPOCJOHKG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x338E7A0", Offset = "0x338D9A0", VA = "0x18338E7A0")]
	protected AMHHNDLMNIA(TActionDeps MPBKKECLGHP, int? DKEMHCHHINN, int? KPLKGOBDFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x338D270", Offset = "0x338C470", VA = "0x18338D270", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x338D5E0", Offset = "0x338C7E0", VA = "0x18338D5E0")]
	public global::DFPCDCNFMHC<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> FBCBIAOKFMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x338D9D0", Offset = "0x338CBD0", VA = "0x18338D9D0")]
	internal global::IOJDDMIHILI<NEIPEEIDEIJ> GHPFGFOBOMB(global::IOJDDMIHILI<IBDPOCJOHKG> BBBEPKHMHPD)
	{
		return default(global::IOJDDMIHILI<NEIPEEIDEIJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x338DD60", Offset = "0x338CF60", VA = "0x18338DD60")]
	internal void IMPGHFMPLKG(global::IOJDDMIHILI<DADGGCNLMDC> ADHHHFDPAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x338E440", Offset = "0x338D640", VA = "0x18338E440")]
	internal global::IOJDDMIHILI<IBDPOCJOHKG> KNOEGEEMKJN(global::IOJDDMIHILI<DADGGCNLMDC> ADHHHFDPAPI)
	{
		return default(global::IOJDDMIHILI<IBDPOCJOHKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x338DCD0", Offset = "0x338CED0", VA = "0x18338DCD0")]
	internal void GMKFGABKLOM(global::IOJDDMIHILI<IBDPOCJOHKG> AFLJPCGPOEC, global::IOJDDMIHILI<DADGGCNLMDC> ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x338D130", Offset = "0x338C330", VA = "0x18338D130")]
	internal void CFDBMJEJEEE(global::IOJDDMIHILI<IBDPOCJOHKG> DAACGBFECDE, global::IOJDDMIHILI<DADGGCNLMDC> ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x338E490", Offset = "0x338D690", VA = "0x18338E490")]
	internal void MPJFFGDKILF(global::IOJDDMIHILI<IBDPOCJOHKG> AFLJPCGPOEC, global::IOJDDMIHILI<DADGGCNLMDC> ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x338CD30", Offset = "0x338BF30", VA = "0x18338CD30")]
	internal global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue> ABAKMDBIOJA(global::IOJDDMIHILI<IBDPOCJOHKG> HNCANGJNGFC, global::IOJDDMIHILI<OADMPFEFGLH> KBJBPEAKGPP, string EBOEHIFNNLM, in TSyncFieldValue JFBPNBNBHOE, Action IGAMPECHIKO, Action<object> IFJBPOMDHMJ, Func<bool> MHNADODPMHK)
	{
		return default(global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x338E6B0", Offset = "0x338D8B0", VA = "0x18338E6B0")]
	internal void NLJILAPKPAC(global::IOJDDMIHILI<IBDPOCJOHKG> HNCANGJNGFC, string EBOEHIFNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x338CED0", Offset = "0x338C0D0", VA = "0x18338CED0")]
	internal void ABDKCAPGEOF(global::AHBCNHEDODP<IBDPOCJOHKG, TSyncFieldValue> KBJBPEAKGPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x338D0F0", Offset = "0x338C2F0", VA = "0x18338D0F0")]
	internal void AJBNHHLKAGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x338DFB0", Offset = "0x338D1B0", VA = "0x18338DFB0")]
	internal void JILLBFEJHGO(global::IOJDDMIHILI<IBDPOCJOHKG> NOJAHDOHDIN, global::IOJDDMIHILI<GGICLPCGLOC> DAPJGJIMAOA, in TAction GPNJNMLGIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x338D1A0", Offset = "0x338C3A0", VA = "0x18338D1A0")]
	[CompilerGenerated]
	private global::DFPCDCNFMHC<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> CKELDLCGCGC(global::IOJDDMIHILI<IBDPOCJOHKG> DFHHNEIGJPB)
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
